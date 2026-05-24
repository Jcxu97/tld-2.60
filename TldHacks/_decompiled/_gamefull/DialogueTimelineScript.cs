using Cpp2ILInjected;
using TLD.AddressableAssets;
using UnityEngine;

[CreateAssetMenu(fileName = "DialogueTimelineScript", menuName = "Dialogue/Timeline Script", order = 10003)]
[Token(Token = "0x20002CD")]
public class DialogueTimelineScript : ScriptableObject
{
	[Token(Token = "0x4001919")]
	[FieldOffset(Offset = "0x18")]
	public AssetReferenceTimeline m_TimelineRef;

	[Token(Token = "0x400191A")]
	[FieldOffset(Offset = "0x20")]
	public string m_CameraFramingIn;

	[Token(Token = "0x400191B")]
	[FieldOffset(Offset = "0x28")]
	public float m_CameraFramingInDurationSeconds;

	[Token(Token = "0x400191C")]
	[FieldOffset(Offset = "0x30")]
	public string m_CameraFramingOut;

	[Token(Token = "0x400191D")]
	[FieldOffset(Offset = "0x38")]
	public float m_CameraFramingOutDurationSeconds;

	[Token(Token = "0x400191E")]
	[FieldOffset(Offset = "0x3C")]
	public bool m_CameraLocked;

	[Token(Token = "0x400191F")]
	[FieldOffset(Offset = "0x3D")]
	public bool m_LerpCameraOffset;

	[Token(Token = "0x4001920")]
	[FieldOffset(Offset = "0x3E")]
	public bool m_FadedOutOnLoad;

	[Token(Token = "0x4001921")]
	[FieldOffset(Offset = "0x3F")]
	public bool m_DisabledBreathFX;

	[Token(Token = "0x60017F4")]
	[Address(RVA = "0x6E2F40", Offset = "0x6E1D40", Length = "0x94")]
	public DialogueTimelineScript()
	{
	}
}
