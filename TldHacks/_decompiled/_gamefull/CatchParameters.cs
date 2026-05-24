using System.ComponentModel;
using Cpp2ILInjected;
using UnityEngine.AddressableAssets;

[Token(Token = "0x200058B")]
public class CatchParameters
{
	[DefaultValue(float.PositiveInfinity)]
	[Token(Token = "0x4003307")]
	[FieldOffset(Offset = "0x10")]
	public float m_MinutesToNextCatch;

	[Token(Token = "0x4003308")]
	[FieldOffset(Offset = "0x14")]
	public bool m_SnapLine;

	[Token(Token = "0x4003309")]
	[FieldOffset(Offset = "0x18")]
	public AssetReference m_FishReference;

	[DefaultValue(1f)]
	[Token(Token = "0x400330A")]
	[FieldOffset(Offset = "0x20")]
	public float m_FishMinWeightModifier;

	[DefaultValue(1f)]
	[Token(Token = "0x400330B")]
	[FieldOffset(Offset = "0x24")]
	public float m_FishWeightScale;

	[Token(Token = "0x400330C")]
	[FieldOffset(Offset = "0x28")]
	public float m_FishHealthRoll;

	[Token(Token = "0x400330D")]
	[FieldOffset(Offset = "0x2C")]
	public float m_FishWeightRoll;

	[Token(Token = "0x6002AAD")]
	[Address(RVA = "0x908820", Offset = "0x907620", Length = "0x6A")]
	public void ResetParameters()
	{
	}

	[Token(Token = "0x6002AAE")]
	[Address(RVA = "0x908890", Offset = "0x907690", Length = "0x89")]
	public void CopyParameters(CatchParameters parameters)
	{
	}

	[Token(Token = "0x6002AAF")]
	[Address(RVA = "0x908920", Offset = "0x907720", Length = "0x16")]
	public CatchParameters()
	{
	}
}
