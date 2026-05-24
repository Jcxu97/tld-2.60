using System.Collections.Generic;
using Cpp2ILInjected;

[Token(Token = "0x2000185")]
public class SpawnRegionDataProxy
{
	[Token(Token = "0x4000E01")]
	[FieldOffset(Offset = "0x10")]
	public float m_HoursPlayed;

	[Token(Token = "0x4000E02")]
	[FieldOffset(Offset = "0x14")]
	public float m_ElapsedHoursAtLastActiveReRoll;

	[Token(Token = "0x4000E03")]
	[FieldOffset(Offset = "0x18")]
	public bool m_IsActive;

	[Token(Token = "0x4000E04")]
	[FieldOffset(Offset = "0x20")]
	public List<SpawnDataProxy> m_ActiveSpawns;

	[Token(Token = "0x4000E05")]
	[FieldOffset(Offset = "0x28")]
	public int m_NumRespawnsPending;

	[Token(Token = "0x4000E06")]
	[FieldOffset(Offset = "0x2C")]
	public float m_ElapasedHoursNextRespawnAllowed;

	[Token(Token = "0x4000E07")]
	[FieldOffset(Offset = "0x30")]
	public int m_NumTrapped;

	[Token(Token = "0x4000E08")]
	[FieldOffset(Offset = "0x34")]
	public float m_HoursNextTrapReset;

	[Token(Token = "0x4000E09")]
	[FieldOffset(Offset = "0x38")]
	public int m_SpawnGuidCounter;

	[Token(Token = "0x4000E0A")]
	[FieldOffset(Offset = "0x3C")]
	public int m_CurrentWaypointPathIndex;

	[Token(Token = "0x4000E0B")]
	[FieldOffset(Offset = "0x40")]
	public WildlifeMode m_WildlifeMode;

	[Token(Token = "0x4000E0C")]
	[FieldOffset(Offset = "0x44")]
	public bool m_HasBeenDisabledByAurora;

	[Token(Token = "0x4000E0D")]
	[FieldOffset(Offset = "0x45")]
	public bool m_WasActiveBeforeAurora;

	[Token(Token = "0x4000E0E")]
	[FieldOffset(Offset = "0x48")]
	public float m_CooldownTimerHours;

	[Token(Token = "0x6000ECA")]
	[Address(RVA = "0x600B00", Offset = "0x5FF900", Length = "0xAD")]
	public SpawnRegionDataProxy()
	{
	}
}
