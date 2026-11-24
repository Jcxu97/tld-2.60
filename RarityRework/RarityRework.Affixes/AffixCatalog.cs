using System.Collections.Generic;
using Il2Cpp;
using RarityRework.Enums;
using RarityRework.Managers;
using RarityRework.Properties;
using UnityEngine;

namespace RarityRework.Affixes;

internal enum GearKind
{
	None,
	Clothing,
	Gun,
	Bow,
	Blade,
	FireStarter,
	Light,
	Heater,
	Medicine
}

internal sealed class AffixDef
{
	internal readonly string Id;
	internal readonly string Name;
	internal readonly float Min;
	internal readonly float Max;
	internal readonly bool Points;
	internal readonly bool Lower;

	internal AffixDef(string id, string name, float min, float max, bool lower = false, bool points = false)
	{
		Id = id;
		Name = name;
		Min = min;
		Max = max;
		Lower = lower;
		Points = points;
	}
}

internal static class AffixCatalog
{
	internal static readonly Dictionary<string, AffixDef> Defs = new Dictionary<string, AffixDef>();

	private static readonly Dictionary<GearKind, string[]> Pools = new Dictionary<GearKind, string[]>
	{
		[GearKind.Clothing] = new[] { "warmth", "wetwarmth", "windproof", "waterproof", "tough", "dry", "wear", "sprint", "weight" },
		[GearKind.Gun] = new[] { "damage", "steady", "recoil", "reload", "reliable", "durable", "weight" },
		[GearKind.Bow] = new[] { "bowdamage", "steady", "durable", "weight" },
		[GearKind.Blade] = new[] { "struggle", "flee", "harvest", "breakdown", "craft", "durable", "weight" },
		[GearKind.FireStarter] = new[] { "firechance", "firefast", "durable", "weight" },
		[GearKind.Light] = new[] { "battery", "recharge", "durable", "weight" },
		[GearKind.Heater] = new[] { "fuel", "heat", "durable", "weight" },
		[GearKind.Medicine] = new[] { "heal", "quickuse", "weight" }
	};

	// Weights come from the settings, index 1..6 as in Rarities. All zero means the defaults.
	private static readonly float[] DefaultWeights = { 0f, 45f, 28f, 15f, 8f, 3.5f, 0.5f };

	private static int PickTier(double roll)
	{
		float[] w = Settings.Instance.TierWeights();
		float sum = 0f;
		for (int i = 1; i <= 6; i++)
		{
			w[i] = System.Math.Max(0f, w[i]);
			sum += w[i];
		}
		if (sum <= 0f)
		{
			w = DefaultWeights;
			sum = 100f;
		}
		double pick = roll * sum;
		double acc = 0;
		int last = 1;
		for (int i = 1; i <= 6; i++)
		{
			if (w[i] <= 0f)
			{
				continue;
			}
			last = i;
			acc += w[i];
			if (pick < acc)
			{
				return i;
			}
		}
		return last;
	}

	// Index 1..6 as in Rarities. Mythic doubles the raw roll.
	internal static readonly float[] Boost = { 1f, 1f, 1.3f, 1.4f, 1.5f, 1.6f, 2f };

	// Reductions stop at 90% so wear, weight or time never reach zero.
	internal const float LowerCap = 0.9f;

	private static readonly string[] MetalNames = { "", "锈铁", "熟铁", "精钢", "淬火钢", "黑钢", "陨铁" };
	private static readonly string[] WoodNames = { "", "白桦", "枫木", "橡木", "白蜡木", "紫杉", "乌木" };
	private static readonly string[] ClothNames = { "", "旧料", "结实", "精纺", "加厚", "极地", "传世" };
	private static readonly string[] MedNames = { "", "粗制", "常规", "精制", "药厂", "军用", "特效" };

	private static readonly Color[] MetalTints =
	{
		Color.white, new Color(0.78f, 0.58f, 0.46f), new Color(0.82f, 0.82f, 0.82f), new Color(0.96f, 0.97f, 1f),
		new Color(0.74f, 0.84f, 1f), new Color(0.45f, 0.45f, 0.5f), new Color(0.82f, 0.62f, 0.92f)
	};

	private static readonly Color[] WoodTints =
	{
		Color.white, new Color(1f, 0.97f, 0.9f), new Color(1f, 0.86f, 0.7f), new Color(0.86f, 0.7f, 0.5f),
		new Color(0.95f, 0.9f, 0.8f), new Color(0.8f, 0.5f, 0.4f), new Color(0.36f, 0.3f, 0.3f)
	};

	static AffixCatalog()
	{
		Add(new AffixDef("warmth", "温暖加成", 0.05f, 0.30f));
		Add(new AffixDef("wetwarmth", "潮湿时温暖加成", 0.10f, 0.50f));
		Add(new AffixDef("windproof", "防风加成", 0.05f, 0.30f));
		Add(new AffixDef("waterproof", "防水性能", 0.05f, 0.30f));
		Add(new AffixDef("tough", "坚韧程度", 0.05f, 0.30f));
		Add(new AffixDef("dry", "干燥速度", 0.10f, 0.60f));
		Add(new AffixDef("wear", "状态损耗", 0.10f, 0.50f, lower: true));
		Add(new AffixDef("sprint", "行动力惩罚", 0.10f, 0.50f, lower: true));
		Add(new AffixDef("damage", "伤害", 0.05f, 0.25f));
		Add(new AffixDef("bowdamage", "伤害", 0.05f, 0.25f));
		Add(new AffixDef("steady", "瞄准晃动", 0.10f, 0.40f, lower: true));
		Add(new AffixDef("recoil", "后坐力", 0.10f, 0.40f, lower: true));
		Add(new AffixDef("reload", "装填时间", 0.10f, 0.40f, lower: true));
		Add(new AffixDef("reliable", "卡壳几率", 0.20f, 0.80f, lower: true));
		Add(new AffixDef("struggle", "打斗伤害", 0.10f, 0.40f));
		Add(new AffixDef("flee", "打斗中野生动物逃离几率", 0.10f, 0.40f));
		Add(new AffixDef("harvest", "采集尸骸时间", 0.10f, 0.40f, lower: true));
		Add(new AffixDef("breakdown", "场景物件拆解时间", 0.10f, 0.40f, lower: true));
		Add(new AffixDef("craft", "制造和修理时间", 0.10f, 0.30f, lower: true));
		Add(new AffixDef("firechance", "生火成功几率", 5f, 25f, points: true));
		Add(new AffixDef("firefast", "生火时间", 0.10f, 0.40f, lower: true));
		Add(new AffixDef("battery", "照明时间", 0.20f, 1.00f));
		Add(new AffixDef("recharge", "充电时间", 0.20f, 0.50f, lower: true));
		Add(new AffixDef("fuel", "燃料消耗", 0.10f, 0.40f, lower: true));
		Add(new AffixDef("heat", "取暖温度", 0.10f, 0.40f));
		Add(new AffixDef("durable", "状态损耗", 0.10f, 0.50f, lower: true));
		Add(new AffixDef("weight", "重量", 0.05f, 0.30f, lower: true));
		Add(new AffixDef("heal", "状态恢复", 0.20f, 1.00f));
		Add(new AffixDef("quickuse", "使用时间", 0.20f, 0.60f, lower: true));
	}

	private static void Add(AffixDef def)
	{
		Defs[def.Id] = def;
	}

	internal static GearKind KindOf(GearItem gi)
	{
		if (gi == null || gi.m_NarrativeCollectibleItem != null)
		{
			return GearKind.None;
		}
		// Medicine rolls per stack: a stack is one GearItem, and stacks with different tiers are kept apart.
		// Mods often build pills as food with a few calories, so the inventory category decides, not the component.
		if (gi.m_FirstAidItem != null || (gi.m_FoodItem != null && gi.IsGearType(Il2CppTLD.Gear.GearType.FirstAid)))
		{
			return GearKind.Medicine;
		}
		if (gi.m_FoodItem != null)
		{
			return GearKind.None;
		}
		if (gi.m_StackableItem != null || gi.m_NarrativeCollectibleItem != null || gi.m_FlareItem != null || gi.m_TorchItem != null || gi.m_MatchesItem != null)
		{
			return GearKind.None;
		}
		if (gi.m_ClothingItem != null)
		{
			return GearKind.Clothing;
		}
		if (gi.m_GunItem != null)
		{
			return GearKind.Gun;
		}
		if (gi.m_BowItem != null)
		{
			return GearKind.Bow;
		}
		if (gi.m_WhaleOilHeaterItem != null)
		{
			return GearKind.Heater;
		}
		if (gi.m_FlashlightItem != null)
		{
			return GearKind.Light;
		}
		FireStarterItem fire = gi.m_FireStarterItem;
		if (fire != null)
		{
			return (fire.m_ConsumeOnUse || fire.m_IsAccelerant || gi.m_MatchesItem != null) ? GearKind.None : GearKind.FireStarter;
		}
		// ToolsItem alone also covers sewing kits, cleaning kits and fishing tackle.
		if (gi.m_BearSpearItem != null || gi.m_StruggleBonus != null || gi.m_BodyHarvestItem != null || gi.m_BreakDownItem != null)
		{
			return GearKind.Blade;
		}
		return GearKind.None;
	}

	internal static string MaterialName(GearKind kind, int tier)
	{
		return kind switch
		{
			GearKind.Clothing => ClothNames[tier],
			GearKind.Bow => WoodNames[tier],
			GearKind.Medicine => MedNames[tier],
			_ => MetalNames[tier]
		};
	}

	internal static bool TryGetTint(GearKind kind, int tier, out Color tint)
	{
		tint = kind == GearKind.Bow ? WoodTints[tier] : MetalTints[tier];
		return kind != GearKind.Clothing && kind != GearKind.Medicine;
	}

	internal static bool RemoveInapplicable(GearItem gi, GearKind kind, ItemRoll roll)
	{
		if (roll.a.Count == 0)
		{
			return false;
		}
		bool removed = false;
		foreach (string id in new List<string>(roll.a.Keys))
		{
			if (!Pools.TryGetValue(kind, out string[] pool) || System.Array.IndexOf(pool, id) < 0 || !Applies(gi, id))
			{
				removed |= roll.a.Remove(id);
			}
		}
		return removed;
	}

	private static bool Applies(GearItem gi, string id)
	{
		ClothingItem c = gi.m_ClothingItem;
		GunItem g = gi.m_GunItem;
		BowItem b = gi.m_BowItem;
		return id switch
		{
			"heal" => gi.m_FirstAidItem?.m_HPIncrease > 0f,
			"quickuse" => gi.m_FirstAidItem?.m_TimeToUseSeconds > 0f || gi.m_FoodItem?.m_TimeToEatSeconds > 0f ||
				gi.m_FoodItem?.m_TimeToOpenAndEatSeconds > 0f,
			"warmth" => c.m_Warmth > 0f,
			"wetwarmth" => c.m_WarmthWhenWet > 0f,
			"windproof" => c.m_Windproof > 0f,
			"waterproof" => c.m_Waterproofness > 0f && c.m_Waterproofness < 1f,
			"tough" => c.m_Toughness > 0f,
			"dry" => c.m_DryPercentPerHour > 0f || c.m_DryPercentPerHourNoFire > 0f,
			"sprint" => c.m_SprintBarReductionPercent > 0f,
			"damage" => (g.m_GunType is GunType.Rifle or GunType.Revolver or GunType.Shotgun) && g.m_DamageHP > 0f,
			"bowdamage" => b.m_BowDamageMultiplier > 0f,
			"steady" => g != null
				? g.m_SwayValueZeroFatigue > 0f || g.m_SwayValueMaxFatigue > 0f || g.m_SwayIncreasePerSecond > 0f
				: b.m_SwayValueZeroFatigue > 0f || b.m_SwayValueMaxFatigue > 0f || b.m_SwayIncreasePerSecond > 0f,
			"recoil" => g.m_PitchRecoilMin != 0f || g.m_PitchRecoilMax != 0f ||
				g.m_YawRecoilMin != 0f || g.m_YawRecoilMax != 0f,
			"reload" => g.m_GunType != GunType.Camera,
			"reliable" => g.m_MisfireTable != null,
			"struggle" => gi.m_StruggleBonus?.m_DamageScalePercent > 0f,
			"flee" => gi.m_StruggleBonus?.m_FleeChanceScale > 0f,
			"harvest" => CanHarvest(gi.m_BodyHarvestItem),
			"breakdown" => gi.m_BreakDownItem?.m_BreakDownTimeModifier > 0f,
			"craft" => gi.m_ToolsItem?.m_CraftingAndRepairTimeModifier > 0f,
			"battery" => gi.m_FlashlightItem.m_LowBeamDuration > 0f || gi.m_FlashlightItem.m_HighBeamDuration > 0f,
			"recharge" => gi.m_FlashlightItem.m_RechargeTime > 0f,
			"fuel" => HasHeaterSetting(gi.m_WhaleOilHeaterItem, fuel: true),
			"heat" => HasHeaterSetting(gi.m_WhaleOilHeaterItem, fuel: false),
			"durable" => gi.GearItemData?.DailyHPDecay > 0f || gi.m_DegradeOnUse?.m_DegradeHP > 0f ||
				gi.m_StruggleBonus != null || gi.m_BodyHarvestItem?.m_HPDecreasePerHourUse > 0f ||
				gi.m_ToolsItem?.m_DegradePerHourCrafting > 0f || gi.m_FireStarterItem?.m_ConditionDegradeOnUse > 0f,
			"weight" => gi.WeightKG.m_Units > 0,
			"wear" or "firechance" or "firefast" => true,
			_ => false
		};
	}

	private static bool CanHarvest(BodyHarvestItem tool)
	{
		return tool != null && (tool.m_HarvestMeatMinutesPerKG > 0f || tool.m_HarvestFrozenMeatMinutesPerKG > 0f ||
			tool.m_HarvestHideMinutesPerUnit > 0f || tool.m_HarvestGutMinutesPerUnit > 0f);
	}

	private static bool HasHeaterSetting(WhaleOilHeaterItem heater, bool fuel)
	{
		var settings = heater.m_Settings;
		for (int i = 0; settings != null && i < settings.Length; i++)
		{
			var setting = settings[i];
			if (setting != null && (fuel ? setting.m_FuelUsedPerHour.m_Units > 0 : setting.m_Temperature > 0f))
			{
				return true;
			}
		}
		return false;
	}

	internal static ItemRoll Roll(GearItem gi, GearKind kind, uint seed)
	{
		System.Random rng = new System.Random((int)seed);
		int tier = PickTier(rng.NextDouble());
		if (RarityManager.GetRarity(gi.name) >= Rarities.Epic && tier < (int)Rarities.Rare)
		{
			tier = (int)Rarities.Rare;
		}
		ItemRoll roll = new ItemRoll { t = tier, m = MaterialName(kind, tier), ApplicabilityChecked = true };
		List<string> pool = new List<string>(Pools[kind]);
		pool.RemoveAll(id => !Applies(gi, id));
		int count = System.Math.Min(tier - 1, pool.Count);
		float lo = (tier - 1) / 10f;
		for (int i = 0; i < count; i++)
		{
			int k = rng.Next(pool.Count);
			AffixDef def = Defs[pool[k]];
			pool.RemoveAt(k);
			float r = lo + (1f - lo) * (float)rng.NextDouble();
			float v = def.Min + (def.Max - def.Min) * r;
			roll.a[def.Id] = def.Points ? Mathf.Round(v) : Mathf.Round(v * 100f) / 100f;
		}
		return roll;
	}
}

internal sealed class ItemRoll
{
	public int t;

	public string m;

	public Dictionary<string, float> a = new Dictionary<string, float>();
	internal bool ApplicabilityChecked;

	// Stored values are the raw roll. The tier boost is applied on read, so saved items follow boost changes.
	internal float Get(string id)
	{
		if (!a.TryGetValue(id, out float v))
		{
			return 0f;
		}
		v *= AffixCatalog.Boost[Mathf.Clamp(t, 0, 6)];
		return AffixCatalog.Defs.TryGetValue(id, out AffixDef d) && d.Lower ? Mathf.Min(v, AffixCatalog.LowerCap) : v;
	}
}
