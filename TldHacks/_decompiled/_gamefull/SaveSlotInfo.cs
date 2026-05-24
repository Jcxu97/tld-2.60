using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using TLD.Gameplay;

[Token(Token = "0x200091B")]
public class SaveSlotInfo
{
	[Token(Token = "0x4005EB2")]
	[FieldOffset(Offset = "0x10")]
	public string m_SaveSlotName;

	[Token(Token = "0x4005EB3")]
	[FieldOffset(Offset = "0x18")]
	public SaveSlotType m_GameMode;

	[Token(Token = "0x4005EB4")]
	[FieldOffset(Offset = "0x1C")]
	public uint m_GameId;

	[Token(Token = "0x4005EB5")]
	[FieldOffset(Offset = "0x20")]
	public Episode m_Episode;

	[Token(Token = "0x4005EB6")]
	[FieldOffset(Offset = "0x28")]
	public DateTime m_Timestamp;

	[Token(Token = "0x4005EB7")]
	[FieldOffset(Offset = "0x30")]
	public string m_Region;

	[Token(Token = "0x4005EB8")]
	[FieldOffset(Offset = "0x38")]
	public string m_Location;

	[Token(Token = "0x4005EB9")]
	[FieldOffset(Offset = "0x40")]
	public float m_HoursSurvived;

	[Token(Token = "0x4005EBA")]
	[FieldOffset(Offset = "0x44")]
	public VoicePersona m_Persona;

	[Token(Token = "0x4005EBB")]
	[FieldOffset(Offset = "0x48")]
	public float m_Condition;

	[Token(Token = "0x4005EBC")]
	[FieldOffset(Offset = "0x50")]
	public string m_UserDefinedName;

	[Token(Token = "0x4005EBD")]
	[FieldOffset(Offset = "0x58")]
	public float m_WorldExplored;

	[Token(Token = "0x4005EBE")]
	[FieldOffset(Offset = "0x5C")]
	public ExperienceModeType m_XPMode;

	[Token(Token = "0x4005EBF")]
	[FieldOffset(Offset = "0x60")]
	public GameModeConfig m_GameModeConfig;

	[Token(Token = "0x4005EC0")]
	[FieldOffset(Offset = "0x68")]
	public string m_LocationOverride;

	[Token(Token = "0x4005EC1")]
	[FieldOffset(Offset = "0x70")]
	public string m_SandboxManagerSerialized;

	[Token(Token = "0x4005EC2")]
	[FieldOffset(Offset = "0x78")]
	public string m_StoryManagerSerialized;

	[Token(Token = "0x4005EC3")]
	[FieldOffset(Offset = "0x80")]
	public bool m_Corrupt;

	[Token(Token = "0x4005EC4")]
	[FieldOffset(Offset = "0x88")]
	public string m_ActiveMissionLocId;

	[Token(Token = "0x4005EC5")]
	[FieldOffset(Offset = "0x90")]
	public string m_ActiveMissionId;

	[Token(Token = "0x4005EC6")]
	[FieldOffset(Offset = "0x98")]
	public bool m_EpisodeCompleted;

	[Token(Token = "0x4005EC7")]
	[FieldOffset(Offset = "0x9C")]
	public float m_EpisodeProgress;

	[Token(Token = "0x4005EC8")]
	[FieldOffset(Offset = "0xA0")]
	public ScreenshotSaveGameFormat m_ScreenshotData;

	[Token(Token = "0x4005EC9")]
	[FieldOffset(Offset = "0xA8")]
	public int m_SaveChangelistVersion;

	[Token(Token = "0x4005ECA")]
	[FieldOffset(Offset = "0xAC")]
	public int m_CompressedSizeBytes;

	[Token(Token = "0x4005ECB")]
	[FieldOffset(Offset = "0xB0")]
	public string m_SceneManagerSerialized;

	[Token(Token = "0x4005ECC")]
	[FieldOffset(Offset = "0xB8")]
	public readonly List<string> m_InstalledOptionalContent;

	[Token(Token = "0x60052E0")]
	[Address(RVA = "0xE52D80", Offset = "0xE51B80", Length = "0x2E")]
	public bool ShowInLoadScreen()
	{
		return false;
	}

	[Token(Token = "0x60052E1")]
	[Address(RVA = "0xE52DB0", Offset = "0xE51BB0", Length = "0x2E")]
	public bool CanBeLoaded()
	{
		return false;
	}

	[Token(Token = "0x60052E2")]
	[Address(RVA = "0xE52DE0", Offset = "0xE51BE0", Length = "0x162")]
	private bool IsLoadable()
	{
		return false;
	}

	[Token(Token = "0x60052E3")]
	[Address(RVA = "0xE52F50", Offset = "0xE51D50", Length = "0x242")]
	public bool IsMissingOptionalContent(List<string> missingContent = null)
	{
		return false;
	}

	[Token(Token = "0x60052E4")]
	[Address(RVA = "0xE531A0", Offset = "0xE51FA0", Length = "0xBC")]
	public SaveSlotInfo()
	{
	}
}
