using Cpp2ILInjected;
using TLD.Gameplay;
using UnityEngine;

[Token(Token = "0x2000749")]
public class SceneTransitionData
{
	[Token(Token = "0x4004D03")]
	[FieldOffset(Offset = "0x10")]
	public bool m_TeleportPlayerSaveGamePosition;

	[Token(Token = "0x4004D04")]
	[FieldOffset(Offset = "0x18")]
	public string m_SpawnPointName;

	[Token(Token = "0x4004D05")]
	[FieldOffset(Offset = "0x20")]
	public string m_SpawnPointAudio;

	[Token(Token = "0x4004D06")]
	[FieldOffset(Offset = "0x28")]
	public string m_ForceNextSceneLoadTriggerScene;

	[Token(Token = "0x4004D07")]
	[FieldOffset(Offset = "0x30")]
	public Vector3 m_PosBeforeInteriorLoad;

	[Token(Token = "0x4004D08")]
	[FieldOffset(Offset = "0x40")]
	public string m_SceneSaveFilenameCurrent;

	[Token(Token = "0x4004D09")]
	[FieldOffset(Offset = "0x48")]
	public string m_SceneSaveFilenameNextLoad;

	[Token(Token = "0x4004D0A")]
	[FieldOffset(Offset = "0x50")]
	public string m_SceneLocationLocIDOverride;

	[Token(Token = "0x4004D0B")]
	[FieldOffset(Offset = "0x58")]
	public int m_GameRandomSeed;

	[Token(Token = "0x4004D0C")]
	[FieldOffset(Offset = "0x60")]
	public string m_Location;

	[Token(Token = "0x4004D0D")]
	[FieldOffset(Offset = "0x68")]
	public string m_LastOutdoorScene;

	[Token(Token = "0x4004D0E")]
	[FieldOffset(Offset = "0x70")]
	public LifeAfterDeathSpawnPointType m_PendingLifeAfterDeathSpawnPoint;

	[Token(Token = "0x60041FD")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public SceneTransitionData()
	{
	}
}
