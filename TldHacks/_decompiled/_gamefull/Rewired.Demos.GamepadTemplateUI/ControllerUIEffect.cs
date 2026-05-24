using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.UI;

namespace Rewired.Demos.GamepadTemplateUI;

[RequireComponent(typeof(Image))]
[Token(Token = "0x2000C5F")]
public class ControllerUIEffect : MonoBehaviour
{
	[SerializeField]
	[Token(Token = "0x4007D57")]
	[FieldOffset(Offset = "0x20")]
	private Color _highlightColor;

	[Token(Token = "0x4007D58")]
	[FieldOffset(Offset = "0x30")]
	private Image _image;

	[Token(Token = "0x4007D59")]
	[FieldOffset(Offset = "0x38")]
	private Color _color;

	[Token(Token = "0x4007D5A")]
	[FieldOffset(Offset = "0x48")]
	private Color _origColor;

	[Token(Token = "0x4007D5B")]
	[FieldOffset(Offset = "0x58")]
	private bool _isActive;

	[Token(Token = "0x4007D5C")]
	[FieldOffset(Offset = "0x5C")]
	private float _highlightAmount;

	[Token(Token = "0x600640D")]
	[Address(RVA = "0xFDE280", Offset = "0xFDD080", Length = "0xCD")]
	private void Awake()
	{
	}

	[Token(Token = "0x600640E")]
	[Address(RVA = "0xFDE350", Offset = "0xFDD150", Length = "0x12E")]
	public void Activate(float amount)
	{
	}

	[Token(Token = "0x600640F")]
	[Address(RVA = "0xFDE480", Offset = "0xFDD280", Length = "0x6A")]
	public void Deactivate()
	{
	}

	[Token(Token = "0x6006410")]
	[Address(RVA = "0xFDE4F0", Offset = "0xFDD2F0", Length = "0x4F")]
	private void RedrawImage()
	{
	}

	[Token(Token = "0x6006411")]
	[Address(RVA = "0xFDE540", Offset = "0xFDD340", Length = "0x53")]
	public ControllerUIEffect()
	{
	}
}
