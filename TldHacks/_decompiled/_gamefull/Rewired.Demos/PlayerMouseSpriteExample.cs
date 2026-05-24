using System;
using Cpp2ILInjected;
using UnityEngine;

namespace Rewired.Demos;

[AddComponentMenu(null)]
[Token(Token = "0x2000C4D")]
public class PlayerMouseSpriteExample : MonoBehaviour
{
	[Tooltip("The Player that will control the mouse")]
	[Token(Token = "0x4007CF6")]
	[FieldOffset(Offset = "0x20")]
	public int playerId;

	[Tooltip("The Rewired Action used for the mouse horizontal axis.")]
	[Token(Token = "0x4007CF7")]
	[FieldOffset(Offset = "0x28")]
	public string horizontalAction;

	[Tooltip("The Rewired Action used for the mouse vertical axis.")]
	[Token(Token = "0x4007CF8")]
	[FieldOffset(Offset = "0x30")]
	public string verticalAction;

	[Tooltip("The Rewired Action used for the mouse wheel axis.")]
	[Token(Token = "0x4007CF9")]
	[FieldOffset(Offset = "0x38")]
	public string wheelAction;

	[Tooltip("The Rewired Action used for the mouse left button.")]
	[Token(Token = "0x4007CFA")]
	[FieldOffset(Offset = "0x40")]
	public string leftButtonAction;

	[Tooltip("The Rewired Action used for the mouse right button.")]
	[Token(Token = "0x4007CFB")]
	[FieldOffset(Offset = "0x48")]
	public string rightButtonAction;

	[Tooltip("The Rewired Action used for the mouse middle button.")]
	[Token(Token = "0x4007CFC")]
	[FieldOffset(Offset = "0x50")]
	public string middleButtonAction;

	[Tooltip("The distance from the camera that the pointer will be drawn.")]
	[Token(Token = "0x4007CFD")]
	[FieldOffset(Offset = "0x58")]
	public float distanceFromCamera;

	[Tooltip("The scale of the sprite pointer.")]
	[Token(Token = "0x4007CFE")]
	[FieldOffset(Offset = "0x5C")]
	public float spriteScale;

	[Tooltip("The pointer prefab.")]
	[Token(Token = "0x4007CFF")]
	[FieldOffset(Offset = "0x60")]
	public GameObject pointerPrefab;

	[Tooltip("The click effect prefab.")]
	[Token(Token = "0x4007D00")]
	[FieldOffset(Offset = "0x68")]
	public GameObject clickEffectPrefab;

	[Tooltip("Should the hardware pointer be hidden?")]
	[Token(Token = "0x4007D01")]
	[FieldOffset(Offset = "0x70")]
	public bool hideHardwarePointer;

	[NonSerialized]
	[Token(Token = "0x4007D02")]
	[FieldOffset(Offset = "0x78")]
	private GameObject pointer;

	[NonSerialized]
	[Token(Token = "0x4007D03")]
	[FieldOffset(Offset = "0x80")]
	private PlayerMouse mouse;

	[Token(Token = "0x60063A7")]
	[Address(RVA = "0xFD2FA0", Offset = "0xFD1DA0", Length = "0x729")]
	private void Awake()
	{
	}

	[Token(Token = "0x60063A8")]
	[Address(RVA = "0xFD36D0", Offset = "0xFD24D0", Length = "0x358")]
	private void Update()
	{
	}

	[Token(Token = "0x60063A9")]
	[Address(RVA = "0xFD3A30", Offset = "0xFD2830", Length = "0x105")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x60063AA")]
	[Address(RVA = "0xFD3B40", Offset = "0xFD2940", Length = "0x3F1")]
	private void CreateClickEffect(Color color)
	{
	}

	[Token(Token = "0x60063AB")]
	[Address(RVA = "0xFD3F40", Offset = "0xFD2D40", Length = "0x1BA")]
	private void OnScreenPositionChanged(Vector2 position)
	{
	}

	[Token(Token = "0x60063AC")]
	[Address(RVA = "0xFD4100", Offset = "0xFD2F00", Length = "0x30E")]
	public PlayerMouseSpriteExample()
	{
	}
}
