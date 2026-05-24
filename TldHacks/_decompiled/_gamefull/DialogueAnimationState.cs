using Cpp2ILInjected;
using UnityEngine;

[CreateAssetMenu(fileName = "DialogueAnimationState", menuName = "Dialogue/Animation State", order = 10003)]
[Token(Token = "0x20002B9")]
public class DialogueAnimationState : ScriptableObject
{
	[HideInInspector]
	[Token(Token = "0x4001810")]
	[FieldOffset(Offset = "0x18")]
	public string m_AnimationStateKey;

	[Token(Token = "0x4001811")]
	[FieldOffset(Offset = "0x20")]
	public string m_CameraFramingIn;

	[Token(Token = "0x4001812")]
	[FieldOffset(Offset = "0x28")]
	public string m_CameraFramingOut;

	[Token(Token = "0x4001813")]
	[FieldOffset(Offset = "0x30")]
	public string m_ExitDialoguePoint;

	[Token(Token = "0x4001814")]
	[FieldOffset(Offset = "0x38")]
	public bool m_FadedOutOnLoad;

	[Token(Token = "0x4001815")]
	[FieldOffset(Offset = "0x39")]
	public bool m_FadedOutOnExit;

	[Token(Token = "0x4001816")]
	[FieldOffset(Offset = "0x3A")]
	public bool m_CanApplyCameraMotionToJoint;

	[Token(Token = "0x4001817")]
	[FieldOffset(Offset = "0x3B")]
	public bool m_ResetAimingMode;

	[Token(Token = "0x600170C")]
	[Address(RVA = "0x6C8030", Offset = "0x6C6E30", Length = "0xB")]
	public DialogueAnimationState()
	{
	}
}
