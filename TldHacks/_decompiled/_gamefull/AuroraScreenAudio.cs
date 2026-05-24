using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x20001C3")]
public class AuroraScreenAudio : MonoBehaviour
{
	[SerializeField]
	[Token(Token = "0x4000F61")]
	[FieldOffset(Offset = "0x20")]
	private string m_ScreenOffWwiseEvent;

	[SerializeField]
	[Token(Token = "0x4000F62")]
	[FieldOffset(Offset = "0x28")]
	private string m_ScreenLowWwiseEvent;

	[SerializeField]
	[Token(Token = "0x4000F63")]
	[FieldOffset(Offset = "0x30")]
	private string m_ScreenStableWwiseEvent;

	[HideInInspector]
	[Token(Token = "0x4000F64")]
	[FieldOffset(Offset = "0x38")]
	public GameObject m_LinkedScreen;

	[Token(Token = "0x6001042")]
	[Address(RVA = "0x623060", Offset = "0x621E60", Length = "0x8E")]
	public void SetState(AuroraScreenDisplay.State state)
	{
	}

	[Token(Token = "0x6001043")]
	[Address(RVA = "0x4AF5E0", Offset = "0x4AE3E0", Length = "0x43")]
	public AuroraScreenAudio()
	{
	}
}
