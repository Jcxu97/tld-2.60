using System;
using AK.Wwise;
using Cpp2ILInjected;
using UnityEngine;

namespace TLD.Gear;

[CreateAssetMenu(menuName = "The Long Dark/Gear/Liquid Type", fileName = "LIQUID_NewLiquidType")]
[Token(Token = "0x2001429")]
public class LiquidType : ScriptableObject
{
	[Token(Token = "0x200142A")]
	public enum LiquidQuality
	{
		[Token(Token = "0x4009334")]
		Potable,
		[Token(Token = "0x4009335")]
		NonPotable,
		[Token(Token = "0x4009336")]
		Unsafe
	}

	[Token(Token = "0x4009324")]
	private const string POTABLE_WATER_KEY = "LIQUID_WaterPotable";

	[Token(Token = "0x4009325")]
	private const string NONPOTABLE_WATER_KEY = "LIQUID_WaterNonPotable";

	[Token(Token = "0x4009326")]
	private const string KEROSENE_KEY = "LIQUID_Kerosene";

	[Token(Token = "0x4009327")]
	private const string ANTISEPTIC_KEY = "LIQUID_Antiseptic";

	[SerializeField]
	[Token(Token = "0x4009328")]
	[FieldOffset(Offset = "0x18")]
	private GearItemData m_DefaultContainer;

	[SerializeField]
	[Token(Token = "0x4009329")]
	[FieldOffset(Offset = "0x20")]
	private float m_Density;

	[SerializeField]
	[Token(Token = "0x400932A")]
	[FieldOffset(Offset = "0x28")]
	private LocalizedString m_LiquidName;

	[SerializeField]
	[Token(Token = "0x400932B")]
	[FieldOffset(Offset = "0x30")]
	private LocalizedString m_LiquidDescription;

	[SerializeField]
	[Token(Token = "0x400932C")]
	[FieldOffset(Offset = "0x38")]
	private LiquidQuality m_Quality;

	[SerializeField]
	[Token(Token = "0x400932D")]
	[FieldOffset(Offset = "0x40")]
	private AK.Wwise.Switch m_AudioSwitch;

	[Token(Token = "0x400932E")]
	private static LiquidType m_PotableWater;

	[Token(Token = "0x400932F")]
	private static LiquidType m_NonpotableWater;

	[Token(Token = "0x4009330")]
	private static LiquidType m_Kerosene;

	[Token(Token = "0x4009331")]
	private static LiquidType m_Antiseptic;

	[NonSerialized]
	[Token(Token = "0x4009332")]
	[FieldOffset(Offset = "0x48")]
	private Texture2D m_CachedInventoryIcon;

	[Token(Token = "0x17000B18")]
	public GearItemData DefaultContainer
	{
		[Token(Token = "0x60080B4")]
		[Address(RVA = "0x4571D0", Offset = "0x455FD0", Length = "0x5")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000B19")]
	public float Density
	{
		[Token(Token = "0x60080B5")]
		[Address(RVA = "0x5042F0", Offset = "0x5030F0", Length = "0x6")]
		get
		{
			return 0f;
		}
	}

	[Token(Token = "0x17000B1A")]
	public LocalizedString LiquidName
	{
		[Token(Token = "0x60080B6")]
		[Address(RVA = "0x413AB0", Offset = "0x4128B0", Length = "0x5")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000B1B")]
	public LocalizedString LiquidDescription
	{
		[Token(Token = "0x60080B7")]
		[Address(RVA = "0x457420", Offset = "0x456220", Length = "0x5")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000B1C")]
	public LiquidQuality Quality
	{
		[Token(Token = "0x60080B8")]
		[Address(RVA = "0x502760", Offset = "0x501560", Length = "0x4")]
		get
		{
			return default(LiquidQuality);
		}
	}

	[Token(Token = "0x17000B1D")]
	public AK.Wwise.Switch AudioSwitch
	{
		[Token(Token = "0x60080B9")]
		[Address(RVA = "0x4A7D60", Offset = "0x4A6B60", Length = "0x5")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000B1E")]
	public bool IsDrinkable
	{
		[Token(Token = "0x60080BA")]
		[Address(RVA = "0x120DEE0", Offset = "0x120CCE0", Length = "0x8")]
		get
		{
			return false;
		}
	}

	[Token(Token = "0x17000B1F")]
	public bool IsPotable
	{
		[Token(Token = "0x60080BB")]
		[Address(RVA = "0x120DEF0", Offset = "0x120CCF0", Length = "0x8")]
		get
		{
			return false;
		}
	}

	[Token(Token = "0x60080BC")]
	[Address(RVA = "0x120DF00", Offset = "0x120CD00", Length = "0x3CE")]
	public Texture2D GetInventoryIcon()
	{
		return null;
	}

	[Token(Token = "0x60080BD")]
	[Address(RVA = "0x120E2D0", Offset = "0x120D0D0", Length = "0x150")]
	public static void CacheLiquidTypes()
	{
	}

	[Token(Token = "0x60080BE")]
	[Address(RVA = "0x120E420", Offset = "0x120D220", Length = "0x57")]
	public static LiquidType GetPotableWater()
	{
		return null;
	}

	[Token(Token = "0x60080BF")]
	[Address(RVA = "0x120E480", Offset = "0x120D280", Length = "0x5B")]
	public static LiquidType GetNonPotableWater()
	{
		return null;
	}

	[Token(Token = "0x60080C0")]
	[Address(RVA = "0x120E4E0", Offset = "0x120D2E0", Length = "0x5B")]
	public static LiquidType GetKerosene()
	{
		return null;
	}

	[Token(Token = "0x60080C1")]
	[Address(RVA = "0x120E540", Offset = "0x120D340", Length = "0x5B")]
	public static LiquidType GetAntiseptic()
	{
		return null;
	}

	[Token(Token = "0x60080C2")]
	[Address(RVA = "0x120E5A0", Offset = "0x120D3A0", Length = "0x13B")]
	private static LiquidType GetCachedLiquidType(string addressableKey, ref LiquidType cachedLiquid)
	{
		return null;
	}

	[Token(Token = "0x60080C3")]
	[Address(RVA = "0x120E6E0", Offset = "0x120D4E0", Length = "0x15")]
	public LiquidType()
	{
	}
}
