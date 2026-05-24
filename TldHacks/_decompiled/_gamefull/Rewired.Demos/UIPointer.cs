using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.EventSystems;

namespace Rewired.Demos;

[AddComponentMenu(null)]
[RequireComponent(typeof(RectTransform))]
[Token(Token = "0x2000C4F")]
public sealed class UIPointer : UIBehaviour
{
	[Tooltip("Should the hardware pointer be hidden?")]
	[SerializeField]
	[Token(Token = "0x4007D07")]
	[FieldOffset(Offset = "0x20")]
	private bool _hideHardwarePointer;

	[Tooltip("Sets the pointer to the last sibling in the parent hierarchy. Do not enable this on multiple UIPointers under the same parent transform or they will constantly fight each other for dominance.")]
	[SerializeField]
	[Token(Token = "0x4007D08")]
	[FieldOffset(Offset = "0x21")]
	private bool _autoSort;

	[Token(Token = "0x4007D09")]
	[FieldOffset(Offset = "0x28")]
	private Canvas _canvas;

	[Token(Token = "0x170006AC")]
	public bool autoSort
	{
		[Token(Token = "0x60063BA")]
		[Address(RVA = "0x5327B0", Offset = "0x5315B0", Length = "0x5")]
		get
		{
			return false;
		}
		[Token(Token = "0x60063BB")]
		[Address(RVA = "0xFD6C60", Offset = "0xFD5A60", Length = "0x34")]
		set
		{
		}
	}

	[Token(Token = "0x60063BC")]
	[Address(RVA = "0xFD6CA0", Offset = "0xFD5AA0", Length = "0x21F")]
	protected override void Awake()
	{
	}

	[Token(Token = "0x60063BD")]
	[Address(RVA = "0xFD6EC0", Offset = "0xFD5CC0", Length = "0x83")]
	private void Update()
	{
	}

	[Token(Token = "0x60063BE")]
	[Address(RVA = "0xFD6F50", Offset = "0xFD5D50", Length = "0x7")]
	protected override void OnTransformParentChanged()
	{
	}

	[Token(Token = "0x60063BF")]
	[Address(RVA = "0xFD6F50", Offset = "0xFD5D50", Length = "0x7")]
	protected override void OnCanvasGroupChanged()
	{
	}

	[Token(Token = "0x60063C0")]
	[Address(RVA = "0xFD6F60", Offset = "0xFD5D60", Length = "0x338")]
	public void OnScreenPositionChanged(Vector2 screenPosition)
	{
	}

	[Token(Token = "0x60063C1")]
	[Address(RVA = "0xFD72A0", Offset = "0xFD60A0", Length = "0xAC")]
	private void GetDependencies()
	{
	}

	[Token(Token = "0x60063C2")]
	[Address(RVA = "0xEED6B0", Offset = "0xEEC4B0", Length = "0x49")]
	public UIPointer()
	{
	}
}
