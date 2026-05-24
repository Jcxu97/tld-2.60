using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.Events;

[Token(Token = "0x20009F4")]
public class CameraFadeTrigger : MonoBehaviour
{
	[SerializeField]
	[Token(Token = "0x400653E")]
	[FieldOffset(Offset = "0x20")]
	private float m_FadeFrom;

	[SerializeField]
	[Token(Token = "0x400653F")]
	[FieldOffset(Offset = "0x24")]
	private float m_FadeTo;

	[SerializeField]
	[Token(Token = "0x4006540")]
	[FieldOffset(Offset = "0x28")]
	private float m_Time;

	[SerializeField]
	[Token(Token = "0x4006541")]
	[FieldOffset(Offset = "0x2C")]
	private float m_Delay;

	[SerializeField]
	[Token(Token = "0x4006542")]
	[FieldOffset(Offset = "0x30")]
	private UnityEvent m_OnCameraFadeComplete;

	[Token(Token = "0x60057A8")]
	[Address(RVA = "0xED74D0", Offset = "0xED62D0", Length = "0xFA")]
	public void TriggerFade()
	{
	}

	[Token(Token = "0x60057A9")]
	[Address(RVA = "0xED75D0", Offset = "0xED63D0", Length = "0x1D")]
	private void HandleOnFadeFinished()
	{
	}

	[Token(Token = "0x60057AA")]
	[Address(RVA = "0x4AF5E0", Offset = "0x4AE3E0", Length = "0x43")]
	public CameraFadeTrigger()
	{
	}
}
