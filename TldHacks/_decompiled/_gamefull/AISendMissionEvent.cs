using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x200080F")]
public class AISendMissionEvent : MonoBehaviour
{
	[Token(Token = "0x4005545")]
	[FieldOffset(Offset = "0x20")]
	public AiMode m_AITriggerState;

	[Token(Token = "0x4005546")]
	[FieldOffset(Offset = "0x24")]
	public bool m_IsStoryMission;

	[Token(Token = "0x4005547")]
	[FieldOffset(Offset = "0x28")]
	public string m_EventName;

	[Token(Token = "0x4005548")]
	[FieldOffset(Offset = "0x30")]
	private BaseAi m_BaseAI;

	[Token(Token = "0x4005549")]
	[FieldOffset(Offset = "0x38")]
	private bool m_SentEvent;

	[Token(Token = "0x6004B43")]
	[Address(RVA = "0xD50720", Offset = "0xD4F520", Length = "0x8C")]
	private void Start()
	{
	}

	[Token(Token = "0x6004B44")]
	[Address(RVA = "0xD507B0", Offset = "0xD4F5B0", Length = "0xC4")]
	private void Update()
	{
	}

	[Token(Token = "0x6004B45")]
	[Address(RVA = "0x4AF5E0", Offset = "0x4AE3E0", Length = "0x43")]
	public AISendMissionEvent()
	{
	}
}
