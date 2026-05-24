using Cpp2ILInjected;
using UnityEngine;

[AddComponentMenu("NGUI/UI/Image Button")]
[Token(Token = "0x200007F")]
public class UIImageButton : MonoBehaviour
{
	[Token(Token = "0x4000469")]
	[FieldOffset(Offset = "0x20")]
	public UISprite target;

	[Token(Token = "0x400046A")]
	[FieldOffset(Offset = "0x28")]
	public string normalSprite;

	[Token(Token = "0x400046B")]
	[FieldOffset(Offset = "0x30")]
	public string hoverSprite;

	[Token(Token = "0x400046C")]
	[FieldOffset(Offset = "0x38")]
	public string pressedSprite;

	[Token(Token = "0x400046D")]
	[FieldOffset(Offset = "0x40")]
	public string disabledSprite;

	[Token(Token = "0x400046E")]
	[FieldOffset(Offset = "0x48")]
	public bool pixelSnap;

	[Token(Token = "0x1700003E")]
	public bool isEnabled
	{
		[Token(Token = "0x6000463")]
		[Address(RVA = "0xA3C220", Offset = "0xA3B020", Length = "0x109")]
		get
		{
			return false;
		}
		[Token(Token = "0x6000464")]
		[Address(RVA = "0xA3C330", Offset = "0xA3B130", Length = "0x136")]
		set
		{
		}
	}

	[Token(Token = "0x6000465")]
	[Address(RVA = "0xA3C470", Offset = "0xA3B270", Length = "0x14A")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000466")]
	[Address(RVA = "0xA3C5C0", Offset = "0xA3B3C0", Length = "0x299")]
	private void OnValidate()
	{
	}

	[Token(Token = "0x6000467")]
	[Address(RVA = "0xA3C860", Offset = "0xA3B660", Length = "0x148")]
	private void UpdateImage()
	{
	}

	[Token(Token = "0x6000468")]
	[Address(RVA = "0xA3C9B0", Offset = "0xA3B7B0", Length = "0x103")]
	private void OnHover(bool isOver)
	{
	}

	[Token(Token = "0x6000469")]
	[Address(RVA = "0xA3CAC0", Offset = "0xA3B8C0", Length = "0x17")]
	private void OnPress(bool pressed)
	{
	}

	[Token(Token = "0x600046A")]
	[Address(RVA = "0xA3CAE0", Offset = "0xA3B8E0", Length = "0x144")]
	private void SetSprite(string sprite)
	{
	}

	[Token(Token = "0x600046B")]
	[Address(RVA = "0xA3CC30", Offset = "0xA3BA30", Length = "0x47")]
	public UIImageButton()
	{
	}
}
