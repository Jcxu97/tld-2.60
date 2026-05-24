using Cpp2ILInjected;

[Token(Token = "0x2000932")]
public class InfoSaveGameFormat
{
	[Token(Token = "0x4005FBB")]
	[FieldOffset(Offset = "0x10")]
	public string m_XPMode;

	[Token(Token = "0x4005FBC")]
	[FieldOffset(Offset = "0x18")]
	public string m_Region;

	[Token(Token = "0x4005FBD")]
	[FieldOffset(Offset = "0x20")]
	public string m_LocationOverride;

	[Token(Token = "0x4005FBE")]
	[FieldOffset(Offset = "0x28")]
	public VoicePersona m_Persona;

	[Token(Token = "0x4005FBF")]
	[FieldOffset(Offset = "0x2C")]
	public float m_Condition;

	[Token(Token = "0x4005FC0")]
	[FieldOffset(Offset = "0x30")]
	public float m_HoursSurvived;

	[Token(Token = "0x4005FC1")]
	[FieldOffset(Offset = "0x34")]
	public float m_WorldExplored;

	[Token(Token = "0x4005FC2")]
	[FieldOffset(Offset = "0x38")]
	public float m_EpisodeProgress;

	[Token(Token = "0x4005FC3")]
	[FieldOffset(Offset = "0x3C")]
	public bool m_EpisodeCompleted;

	[Token(Token = "0x4005FC4")]
	[FieldOffset(Offset = "0x40")]
	public string m_ActiveMissionLocId;

	[Token(Token = "0x4005FC5")]
	[FieldOffset(Offset = "0x48")]
	public string m_ActiveMissionId;

	[Token(Token = "0x60053C7")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public InfoSaveGameFormat()
	{
	}
}
