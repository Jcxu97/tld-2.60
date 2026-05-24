using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x200041E")]
public class FireSaveDataProxy
{
	[Token(Token = "0x4002506")]
	[FieldOffset(Offset = "0x10")]
	public float m_HoursPlayed;

	[Token(Token = "0x4002507")]
	[FieldOffset(Offset = "0x14")]
	public Vector3 m_Position;

	[Token(Token = "0x4002508")]
	[FieldOffset(Offset = "0x20")]
	public Quaternion m_Rotation;

	[Token(Token = "0x4002509")]
	[FieldOffset(Offset = "0x30")]
	public FireState m_FireStateProxy;

	[Token(Token = "0x400250A")]
	[FieldOffset(Offset = "0x34")]
	public float m_ElapsedOnTODSecondsProxy;

	[Token(Token = "0x400250B")]
	[FieldOffset(Offset = "0x38")]
	public float m_ElapsedOnTODSecondsUnmodifiedProxy;

	[Token(Token = "0x400250C")]
	[FieldOffset(Offset = "0x3C")]
	public float m_MaxOnTODSecondsProxy;

	[Token(Token = "0x400250D")]
	[FieldOffset(Offset = "0x40")]
	public string m_HeatSourceSerialized;

	[Token(Token = "0x400250E")]
	[FieldOffset(Offset = "0x48")]
	public string m_CampfireSerialized;

	[Token(Token = "0x400250F")]
	[FieldOffset(Offset = "0x50")]
	public float m_FuelHeatIncrease;

	[Token(Token = "0x4002510")]
	[FieldOffset(Offset = "0x54")]
	public float m_EmberTimer;

	[Token(Token = "0x4002511")]
	[FieldOffset(Offset = "0x58")]
	public bool m_FullBurnTriggered;

	[Token(Token = "0x4002512")]
	[FieldOffset(Offset = "0x59")]
	public bool m_StartedByPlayer;

	[Token(Token = "0x4002513")]
	[FieldOffset(Offset = "0x5C")]
	public int m_NumGeneratedCharcoalPieces;

	[Token(Token = "0x4002514")]
	[FieldOffset(Offset = "0x60")]
	public bool m_HasCollectedCharcoal;

	[Token(Token = "0x4002515")]
	[FieldOffset(Offset = "0x68")]
	public string[] m_TrackedBurntItems;

	[Token(Token = "0x6001EF5")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public FireSaveDataProxy()
	{
	}
}
