using System.ComponentModel;
using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.AddressableAssets;

[Token(Token = "0x200058A")]
public class IceFishingHoleSaveData
{
	[Token(Token = "0x40032FB")]
	[FieldOffset(Offset = "0x10")]
	public Vector3 m_Position;

	[Token(Token = "0x40032FC")]
	[FieldOffset(Offset = "0x20")]
	public string m_Guid;

	[Token(Token = "0x40032FD")]
	[FieldOffset(Offset = "0x28")]
	public AssetReference m_AssetReference;

	[Token(Token = "0x40032FE")]
	[FieldOffset(Offset = "0x30")]
	public float m_HoursPlayed;

	[Token(Token = "0x40032FF")]
	[FieldOffset(Offset = "0x34")]
	public float m_MinutesSinceLastClearing;

	[Token(Token = "0x4003300")]
	[FieldOffset(Offset = "0x38")]
	public float m_NormalizedFrozen;

	[Token(Token = "0x4003301")]
	[FieldOffset(Offset = "0x3C")]
	public FishingState m_FishingState;

	[Token(Token = "0x4003302")]
	[FieldOffset(Offset = "0x40")]
	public CatchParameters m_NextCatch;

	[DefaultValue(1f)]
	[Token(Token = "0x4003303")]
	[FieldOffset(Offset = "0x48")]
	public float m_CatchMaxTimeModifier;

	[Token(Token = "0x4003304")]
	[FieldOffset(Offset = "0x50")]
	public SerializedTackle m_SerializedBait;

	[Token(Token = "0x4003305")]
	[FieldOffset(Offset = "0x58")]
	public SerializedTackle m_SerializedLure;

	[Token(Token = "0x4003306")]
	[FieldOffset(Offset = "0x60")]
	public SerializedTackle m_SerializedTipup;

	[Token(Token = "0x6002AAC")]
	[Address(RVA = "0x908810", Offset = "0x907610", Length = "0x8")]
	public IceFishingHoleSaveData()
	{
	}
}
