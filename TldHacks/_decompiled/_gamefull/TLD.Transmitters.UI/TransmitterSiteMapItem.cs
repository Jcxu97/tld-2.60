using Cpp2ILInjected;
using InteractiveObjects;
using UnityEngine;

namespace TLD.Transmitters.UI;

[Token(Token = "0x20013EA")]
public class TransmitterSiteMapItem : MonoBehaviour
{
	[SerializeField]
	[Token(Token = "0x40091C4")]
	[FieldOffset(Offset = "0x20")]
	private UISprite m_RepairedSprite;

	[SerializeField]
	[Token(Token = "0x40091C5")]
	[FieldOffset(Offset = "0x28")]
	private UISprite m_UnrepairedSprite;

	[SerializeField]
	[Token(Token = "0x40091C6")]
	[FieldOffset(Offset = "0x30")]
	private UISprite m_BackgroundSprite;

	[SerializeField]
	[Token(Token = "0x40091C7")]
	[FieldOffset(Offset = "0x38")]
	private UISprite m_HoverSprite;

	[Token(Token = "0x6007EF2")]
	[Address(RVA = "0x11EA050", Offset = "0x11E8E50", Length = "0x22F")]
	public void SetTransmitter(TransmitterData transmitter)
	{
	}

	[Token(Token = "0x6007EF3")]
	[Address(RVA = "0x4AF5E0", Offset = "0x4AE3E0", Length = "0x43")]
	public TransmitterSiteMapItem()
	{
	}
}
