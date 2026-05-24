using Cpp2ILInjected;
using TLD.UI.Generics;
using UnityEngine;

[Token(Token = "0x20008B5")]
public class PlayerCough : MonoBehaviour
{
	[Token(Token = "0x4005ADC")]
	[FieldOffset(Offset = "0x20")]
	public float m_DelayBetweenCaptions;

	[Token(Token = "0x4005ADD")]
	[FieldOffset(Offset = "0x24")]
	public float m_CaptionDisplayTime;

	[SerializeField]
	[Token(Token = "0x4005ADE")]
	[FieldOffset(Offset = "0x28")]
	private PanelReference<Panel_Subtitles> m_Subtitles;

	[Token(Token = "0x4005ADF")]
	[FieldOffset(Offset = "0x30")]
	private float m_NextCaptionDisplayTime;

	[Token(Token = "0x4005AE0")]
	[FieldOffset(Offset = "0x34")]
	private uint m_PlayingID;

	[Token(Token = "0x6005015")]
	[Address(RVA = "0xDFE450", Offset = "0xDFD250", Length = "0x8")]
	public bool IsActive()
	{
		return false;
	}

	[Token(Token = "0x6005016")]
	[Address(RVA = "0xDFE460", Offset = "0xDFD260", Length = "0x15E")]
	public void MaybeStart(string eventName)
	{
	}

	[Token(Token = "0x6005017")]
	[Address(RVA = "0xDFE5C0", Offset = "0xDFD3C0", Length = "0x6B")]
	public void Stop()
	{
	}

	[Token(Token = "0x6005018")]
	[Address(RVA = "0xDFE630", Offset = "0xDFD430", Length = "0x1A7")]
	private void OnAkVoiceEvent(object in_cookie, AkCallbackType in_type, object in_info)
	{
	}

	[Token(Token = "0x6005019")]
	[Address(RVA = "0xDFE7E0", Offset = "0xDFD5E0", Length = "0x4A")]
	public PlayerCough()
	{
	}
}
