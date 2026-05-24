using Cpp2ILInjected;
using UnityEngine;

[AddComponentMenu("NGUI/Examples/Slider Colors")]
[Token(Token = "0x200005A")]
public class UISliderColors : MonoBehaviour
{
	[Token(Token = "0x400037B")]
	[FieldOffset(Offset = "0x20")]
	public UISprite sprite;

	[Token(Token = "0x400037C")]
	[FieldOffset(Offset = "0x28")]
	public Color[] colors;

	[Token(Token = "0x400037D")]
	[FieldOffset(Offset = "0x30")]
	private UIProgressBar mBar;

	[Token(Token = "0x6000389")]
	[Address(RVA = "0xA21330", Offset = "0xA20130", Length = "0x95")]
	private void Start()
	{
	}

	[Token(Token = "0x600038A")]
	[Address(RVA = "0xA213D0", Offset = "0xA201D0", Length = "0x350")]
	private void Update()
	{
	}

	[Token(Token = "0x600038B")]
	[Address(RVA = "0xA21730", Offset = "0xA20530", Length = "0x123")]
	public UISliderColors()
	{
	}
}
