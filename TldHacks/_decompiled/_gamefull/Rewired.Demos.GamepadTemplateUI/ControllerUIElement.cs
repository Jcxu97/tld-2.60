using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.UI;

namespace Rewired.Demos.GamepadTemplateUI;

[RequireComponent(typeof(Image))]
[Token(Token = "0x2000C60")]
public class ControllerUIElement : MonoBehaviour
{
	[SerializeField]
	[Token(Token = "0x4007D5D")]
	[FieldOffset(Offset = "0x20")]
	private Color _highlightColor;

	[SerializeField]
	[Token(Token = "0x4007D5E")]
	[FieldOffset(Offset = "0x30")]
	private ControllerUIEffect _positiveUIEffect;

	[SerializeField]
	[Token(Token = "0x4007D5F")]
	[FieldOffset(Offset = "0x38")]
	private ControllerUIEffect _negativeUIEffect;

	[SerializeField]
	[Token(Token = "0x4007D60")]
	[FieldOffset(Offset = "0x40")]
	private Text _label;

	[SerializeField]
	[Token(Token = "0x4007D61")]
	[FieldOffset(Offset = "0x48")]
	private Text _positiveLabel;

	[SerializeField]
	[Token(Token = "0x4007D62")]
	[FieldOffset(Offset = "0x50")]
	private Text _negativeLabel;

	[SerializeField]
	[Token(Token = "0x4007D63")]
	[FieldOffset(Offset = "0x58")]
	private ControllerUIElement[] _childElements;

	[Token(Token = "0x4007D64")]
	[FieldOffset(Offset = "0x60")]
	private Image _image;

	[Token(Token = "0x4007D65")]
	[FieldOffset(Offset = "0x68")]
	private Color _color;

	[Token(Token = "0x4007D66")]
	[FieldOffset(Offset = "0x78")]
	private Color _origColor;

	[Token(Token = "0x4007D67")]
	[FieldOffset(Offset = "0x88")]
	private bool _isActive;

	[Token(Token = "0x4007D68")]
	[FieldOffset(Offset = "0x8C")]
	private float _highlightAmount;

	[Token(Token = "0x170006B7")]
	private bool hasEffects
	{
		[Token(Token = "0x6006412")]
		[Address(RVA = "0xFDE5A0", Offset = "0xFDD3A0", Length = "0x176")]
		get
		{
			return false;
		}
	}

	[Token(Token = "0x6006413")]
	[Address(RVA = "0xFDE720", Offset = "0xFDD520", Length = "0xC8")]
	private void Awake()
	{
	}

	[Token(Token = "0x6006414")]
	[Address(RVA = "0xFDE7F0", Offset = "0xFDD5F0", Length = "0x582")]
	public void Activate(float amount)
	{
	}

	[Token(Token = "0x6006415")]
	[Address(RVA = "0xFDED80", Offset = "0xFDDB80", Length = "0x2E5")]
	public void Deactivate()
	{
	}

	[Token(Token = "0x6006416")]
	[Address(RVA = "0xFDF070", Offset = "0xFDDE70", Length = "0x235")]
	public void SetLabel(string text, AxisRange labelType)
	{
	}

	[Token(Token = "0x6006417")]
	[Address(RVA = "0xFDF2B0", Offset = "0xFDE0B0", Length = "0x3A1")]
	public void ClearLabels()
	{
	}

	[Token(Token = "0x6006418")]
	[Address(RVA = "0xFDF660", Offset = "0xFDE460", Length = "0x38")]
	private void RedrawImage()
	{
	}

	[Token(Token = "0x6006419")]
	[Address(RVA = "0xFDF6A0", Offset = "0xFDE4A0", Length = "0xD4")]
	public ControllerUIElement()
	{
	}
}
