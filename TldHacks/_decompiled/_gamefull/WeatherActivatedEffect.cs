using System;
using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.Events;

[Token(Token = "0x200040E")]
public class WeatherActivatedEffect : MonoBehaviour
{
	[Serializable]
	[Token(Token = "0x200040F")]
	public class StopWithCallbackEvent : UnityEvent<Action>
	{
		[Token(Token = "0x6001ECC")]
		[Address(RVA = "0x7CCDA0", Offset = "0x7CBBA0", Length = "0x80")]
		public StopWithCallbackEvent()
		{
		}
	}

	[SerializeField]
	[Token(Token = "0x40024BC")]
	[FieldOffset(Offset = "0x20")]
	private UnityEvent m_PlayEvents;

	[SerializeField]
	[Token(Token = "0x40024BD")]
	[FieldOffset(Offset = "0x28")]
	private StopWithCallbackEvent m_StopEvents;

	[Token(Token = "0x6001EC9")]
	[Address(RVA = "0x7CCB50", Offset = "0x7CB950", Length = "0x42")]
	public void Play()
	{
	}

	[Token(Token = "0x6001ECA")]
	[Address(RVA = "0x7CCBA0", Offset = "0x7CB9A0", Length = "0x1F6")]
	public void Stop(Action onComplete)
	{
	}

	[Token(Token = "0x6001ECB")]
	[Address(RVA = "0x4AF5E0", Offset = "0x4AE3E0", Length = "0x43")]
	public WeatherActivatedEffect()
	{
	}
}
