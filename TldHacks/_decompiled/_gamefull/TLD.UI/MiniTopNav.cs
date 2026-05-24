using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;

namespace TLD.UI;

[Token(Token = "0x200138E")]
public class MiniTopNav : MonoBehaviour
{
	[SerializeField]
	[Token(Token = "0x4008FA1")]
	[FieldOffset(Offset = "0x20")]
	private Panel_Base m_PanelOwner;

	[SerializeField]
	[Token(Token = "0x4008FA2")]
	[FieldOffset(Offset = "0x28")]
	private List<MiniTopNavButton> m_NavElements;

	[SerializeField]
	[Token(Token = "0x4008FA3")]
	[FieldOffset(Offset = "0x30")]
	private float m_NavElementSize;

	[SerializeField]
	[Token(Token = "0x4008FA4")]
	[FieldOffset(Offset = "0x34")]
	private float m_NavElementStart;

	[SerializeField]
	[Token(Token = "0x4008FA5")]
	[FieldOffset(Offset = "0x38")]
	private GameObject m_HighlightSprite;

	[SerializeField]
	[Token(Token = "0x4008FA6")]
	[FieldOffset(Offset = "0x40")]
	private GameObject m_Controller;

	[SerializeField]
	[Token(Token = "0x4008FA7")]
	[FieldOffset(Offset = "0x48")]
	private GameObject m_SpriteLT;

	[SerializeField]
	[Token(Token = "0x4008FA8")]
	[FieldOffset(Offset = "0x50")]
	private GameObject m_SpriteRT;

	[SerializeField]
	[Token(Token = "0x4008FA9")]
	[FieldOffset(Offset = "0x58")]
	private ButtonLegendContainer m_ButtonLegendContainer;

	[SerializeField]
	[Token(Token = "0x4008FAA")]
	[FieldOffset(Offset = "0x60")]
	private GamepadButtonSprite[] m_GamepadButtonSprites;

	[Token(Token = "0x4008FAB")]
	[FieldOffset(Offset = "0x68")]
	public Action m_ControllerPreviousOverride;

	[Token(Token = "0x4008FAC")]
	[FieldOffset(Offset = "0x70")]
	private List<MiniTopNavButton> m_ActiveElements;

	[Token(Token = "0x4008FAD")]
	[FieldOffset(Offset = "0x78")]
	private MonoBehaviour m_ParentContext;

	[Token(Token = "0x6007CE3")]
	[Address(RVA = "0x11C03B0", Offset = "0x11BF1B0", Length = "0x35E")]
	public void Awake()
	{
	}

	[Token(Token = "0x6007CE4")]
	[Address(RVA = "0x11C0710", Offset = "0x11BF510", Length = "0x1BF")]
	public void OnButtonClickPrevious()
	{
	}

	[Token(Token = "0x6007CE5")]
	[Address(RVA = "0x11C08D0", Offset = "0x11BF6D0", Length = "0x1D6")]
	public void OnButtonClickNext()
	{
	}

	[Token(Token = "0x6007CE6")]
	[Address(RVA = "0x11C0AB0", Offset = "0x11BF8B0", Length = "0x107B")]
	public void Show(MonoBehaviour parentContext)
	{
	}

	[Token(Token = "0x6007CE7")]
	[Address(RVA = "0x11C1B30", Offset = "0x11C0930", Length = "0x2FA")]
	public void Hide()
	{
	}

	[Token(Token = "0x6007CE8")]
	[Address(RVA = "0x11C1E30", Offset = "0x11C0C30", Length = "0x8C")]
	private void SpriteEnable(bool enable)
	{
	}

	[Token(Token = "0x6007CE9")]
	[Address(RVA = "0x11C1EC0", Offset = "0x11C0CC0", Length = "0x20E")]
	private void Update()
	{
	}

	[Token(Token = "0x6007CEA")]
	[Address(RVA = "0x11C20D0", Offset = "0x11C0ED0", Length = "0x1F1")]
	public MiniTopNav()
	{
	}
}
