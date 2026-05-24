using AK.Wwise;
using Cpp2ILInjected;
using TLD.Gear;
using TLD.IntBackedUnit;
using UnityEngine;

[Token(Token = "0x20004E8")]
public class WaterSupply : MonoBehaviour
{
	[Token(Token = "0x4002CDF")]
	[FieldOffset(Offset = "0x20")]
	public LiquidType m_LiquidType;

	[Token(Token = "0x4002CE0")]
	[FieldOffset(Offset = "0x28")]
	public ItemLiquidVolume m_VolumeInLiters;

	[Token(Token = "0x4002CE1")]
	[FieldOffset(Offset = "0x30")]
	public float m_TimeToDrinkSeconds;

	[Token(Token = "0x4002CE2")]
	[FieldOffset(Offset = "0x38")]
	public AK.Wwise.Event m_DrinkingAudio;

	[Token(Token = "0x4002CE3")]
	private static WaterSupplySaveDataProxy m_WaterSupplySaveDataProxy;

	[Token(Token = "0x17000252")]
	public LiquidQuality m_WaterQuality
	{
		[Token(Token = "0x600254C")]
		[Address(RVA = "0x878AF0", Offset = "0x8778F0", Length = "0x1F")]
		get
		{
			return default(LiquidQuality);
		}
	}

	[Token(Token = "0x600254D")]
	[Address(RVA = "0x878B10", Offset = "0x877910", Length = "0xE1")]
	public string Serialize()
	{
		return null;
	}

	[Token(Token = "0x600254E")]
	[Address(RVA = "0x878C00", Offset = "0x877A00", Length = "0x8E")]
	public void Deserialize(string text)
	{
	}

	[Token(Token = "0x600254F")]
	[Address(RVA = "0x4AF5E0", Offset = "0x4AE3E0", Length = "0x43")]
	public WaterSupply()
	{
	}
}
