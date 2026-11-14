using System.Collections.Generic;
using Il2Cpp;
using UnityEngine;

namespace RarityRework.Affixes;

internal static class AffixApplier
{
	// Values captured from the first untouched instance of each GEAR name. Every apply writes base * factor,
	// so applying twice to one object, or once to a fresh copy after a scene load, gives the same result.
	private static readonly Dictionary<string, float> baseValues = new Dictionary<string, float>();

	private static readonly Dictionary<string, long> baseFuel = new Dictionary<string, long>();

	private static MaterialPropertyBlock block;

	private static float Base(GearItem gi, string field, float current)
	{
		string key = gi.name + "|" + field;
		if (!baseValues.TryGetValue(key, out float v))
		{
			v = current;
			baseValues[key] = v;
		}
		return v;
	}

	// Unit and field per affix for the description line. Affixes that are pure rate multipliers
	// (wear, sway, harvest time and so on) have no useful absolute number and show the percent only.
	private static readonly Dictionary<string, (string field, string unit, bool fraction)> Shown = new Dictionary<string, (string, string, bool)>
	{
		["warmth"] = ("warmth", "°C", false),
		["wetwarmth"] = ("wetwarmth", "°C", false),
		["windproof"] = ("windproof", "°C", false),
		["waterproof"] = ("waterproof", "%", true),
		["tough"] = ("tough", "%", true),
		["dry"] = ("dry", "%/小时", false),
		["sprint"] = ("sprint", "%", true),
		["damage"] = ("damage", "", false),
		["reload"] = ("reload", " 秒", false),
		["quickuse"] = ("use", " 秒", false),
		["heal"] = ("heal", "%", true),
		["heat"] = ("heat0", "°C", false)
	};

	// With a known base value the line shows before and after, for example "温暖加成 1°C → 1.2°C（+20%）".
	// Without one it says the change in words, for example "状态损耗 减少 43%".
	internal static string Describe(GearItem gi, string id, float v)
	{
		if (!AffixCatalog.Defs.TryGetValue(id, out AffixDef def))
		{
			return null;
		}
		if (def.Points)
		{
			return $"{def.Name} 提高 {v:0.#}%";
		}
		if (!Shown.TryGetValue(id, out var shown) || !baseValues.TryGetValue(gi.name + "|" + shown.field, out float b) || b == 0f)
		{
			return $"{def.Name} {(def.Lower ? "减少" : "提高")} {v * 100f:0}%";
		}
		float after = b * (def.Lower ? 1f - v : 1f + v);
		if (id == "waterproof")
		{
			after = Mathf.Min(1f, after);
		}
		// Fields stored as 0..1 are shown as percent like the vanilla clothing panel.
		float scale = shown.fraction && Mathf.Abs(b) <= 1f ? 100f : 1f;
		return $"{def.Name} {b * scale:0.#}{shown.unit} → {after * scale:0.#}{shown.unit}（{(def.Lower ? "-" : "+")}{v * 100f:0}%）";
	}

	private static float Up(GearItem gi, ItemRoll r, string id, string field, float current)
	{
		return Base(gi, field, current) * (1f + r.Get(id));
	}

	private static float Down(GearItem gi, ItemRoll r, string id, string field, float current)
	{
		return Base(gi, field, current) * (1f - r.Get(id));
	}

	internal static void Apply(GearItem gi, ItemRoll r)
	{
		if (gi == null || r == null)
		{
			return;
		}
		ClothingItem c = gi.m_ClothingItem;
		if (c != null)
		{
			c.m_Warmth = Up(gi, r, "warmth", "warmth", c.m_Warmth);
			c.m_WarmthWhenWet = Up(gi, r, "wetwarmth", "wetwarmth", c.m_WarmthWhenWet);
			c.m_Windproof = Up(gi, r, "windproof", "windproof", c.m_Windproof);
			c.m_Waterproofness = Mathf.Min(1f, Up(gi, r, "waterproof", "waterproof", c.m_Waterproofness));
			c.m_Toughness = Up(gi, r, "tough", "tough", c.m_Toughness);
			c.m_DryPercentPerHour = Up(gi, r, "dry", "dry", c.m_DryPercentPerHour);
			c.m_DryPercentPerHourNoFire = Up(gi, r, "dry", "drynofire", c.m_DryPercentPerHourNoFire);
			c.m_SprintBarReductionPercent = Down(gi, r, "sprint", "sprint", c.m_SprintBarReductionPercent);
		}
		GunItem g = gi.m_GunItem;
		if (g != null)
		{
			g.m_DamageHP = Up(gi, r, "damage", "damage", g.m_DamageHP);
			g.m_SwayValueZeroFatigue = Down(gi, r, "steady", "sway0", g.m_SwayValueZeroFatigue);
			g.m_SwayValueMaxFatigue = Down(gi, r, "steady", "swaymax", g.m_SwayValueMaxFatigue);
			g.m_SwayIncreasePerSecond = Down(gi, r, "steady", "swayinc", g.m_SwayIncreasePerSecond);
			g.m_PitchRecoilMin = Down(gi, r, "recoil", "pitchmin", g.m_PitchRecoilMin);
			g.m_PitchRecoilMax = Down(gi, r, "recoil", "pitchmax", g.m_PitchRecoilMax);
			g.m_YawRecoilMin = Down(gi, r, "recoil", "yawmin", g.m_YawRecoilMin);
			g.m_YawRecoilMax = Down(gi, r, "recoil", "yawmax", g.m_YawRecoilMax);
			g.m_ReloadCoolDownSeconds = Down(gi, r, "reload", "reload", g.m_ReloadCoolDownSeconds);
		}
		BowItem b = gi.m_BowItem;
		if (b != null)
		{
			b.m_BowDamageMultiplier = Up(gi, r, "bowdamage", "bowdamage", b.m_BowDamageMultiplier);
			b.m_SwayValueZeroFatigue = Down(gi, r, "steady", "sway0", b.m_SwayValueZeroFatigue);
			b.m_SwayValueMaxFatigue = Down(gi, r, "steady", "swaymax", b.m_SwayValueMaxFatigue);
			b.m_SwayIncreasePerSecond = Down(gi, r, "steady", "swayinc", b.m_SwayIncreasePerSecond);
		}
		StruggleBonus s = gi.GetComponent<StruggleBonus>();
		if (s != null)
		{
			s.m_DamageScalePercent = Up(gi, r, "struggle", "struggle", s.m_DamageScalePercent);
			s.m_FleeChanceScale = Up(gi, r, "flee", "flee", s.m_FleeChanceScale);
		}
		ToolsItem t = gi.m_ToolsItem;
		if (t != null)
		{
			t.m_CraftingAndRepairTimeModifier = Down(gi, r, "craft", "craft", t.m_CraftingAndRepairTimeModifier);
		}
		FireStarterItem f = gi.m_FireStarterItem;
		if (f != null)
		{
			f.m_FireStartSkillModifier = Base(gi, "firechance", f.m_FireStartSkillModifier) + r.Get("firechance");
			f.m_FireStartDurationModifier = Down(gi, r, "firefast", "firefast", f.m_FireStartDurationModifier);
		}
		FlashlightItem l = gi.m_FlashlightItem;
		if (l != null)
		{
			l.m_LowBeamDuration = Up(gi, r, "battery", "lowbeam", l.m_LowBeamDuration);
			l.m_HighBeamDuration = Up(gi, r, "battery", "highbeam", l.m_HighBeamDuration);
			l.m_RechargeTime = Down(gi, r, "recharge", "recharge", l.m_RechargeTime);
		}
		WhaleOilHeaterItem h = gi.m_WhaleOilHeaterItem;
		if (h != null)
		{
			for (int i = 0; h.m_Settings != null && i < h.m_Settings.Length; i++)
			{
				WhaleOilHeaterItem.HeaterSetting hs = h.m_Settings[i];
				hs.m_Temperature = Up(gi, r, "heat", "heat" + i, hs.m_Temperature);
				hs.m_FuelUsedPerHour = BaseVolume(gi, i, hs.m_FuelUsedPerHour) * (1f - r.Get("fuel"));
			}
		}
		// Pills made as food (FirstAid category) use quickuse for their eating time.
		FoodItem food = gi.m_FoodItem;
		if (food != null)
		{
			food.m_TimeToEatSeconds = Down(gi, r, "quickuse", "eat", food.m_TimeToEatSeconds);
			food.m_TimeToOpenAndEatSeconds = Down(gi, r, "quickuse", "openeat", food.m_TimeToOpenAndEatSeconds);
		}
		FirstAidItem aid = gi.m_FirstAidItem;
		if (aid != null)
		{
			aid.m_HPIncrease = Up(gi, r, "heal", "heal", aid.m_HPIncrease);
			aid.m_TimeToUseSeconds = Down(gi, r, "quickuse", "use", aid.m_TimeToUseSeconds);
		}
		Tint(gi, r);
	}

	private static Il2CppTLD.IntBackedUnit.ItemLiquidVolume BaseVolume(GearItem gi, int setting, Il2CppTLD.IntBackedUnit.ItemLiquidVolume current)
	{
		string key = gi.name + "|fuel" + setting;
		if (!baseFuel.TryGetValue(key, out long units))
		{
			units = current.m_Units;
			baseFuel[key] = units;
		}
		return new Il2CppTLD.IntBackedUnit.ItemLiquidVolume(units);
	}

	private static void Tint(GearItem gi, ItemRoll r)
	{
		if (!AffixCatalog.TryGetTint(AffixCatalog.KindOf(gi), r.t, out Color tint))
		{
			return;
		}
		block ??= new MaterialPropertyBlock();
		foreach (Renderer renderer in gi.GetComponentsInChildren<Renderer>(true))
		{
			renderer.GetPropertyBlock(block);
			block.SetColor("_Color", tint);
			renderer.SetPropertyBlock(block);
		}
	}
}
