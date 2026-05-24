using Cpp2ILInjected;
using TLD.Gear;
using TLD.UI.Scroll;
using UnityEngine;

[Token(Token = "0x2000206")]
public class BlueprintDisplayItem : ScrollBehaviourItem
{
	[Token(Token = "0x400125C")]
	[FieldOffset(Offset = "0x38")]
	public UISprite m_Available;

	[Token(Token = "0x400125D")]
	[FieldOffset(Offset = "0x40")]
	public UISprite m_Background;

	[Token(Token = "0x400125E")]
	[FieldOffset(Offset = "0x48")]
	public UIButton m_Button;

	[Token(Token = "0x400125F")]
	[FieldOffset(Offset = "0x50")]
	public UILabel m_DisplayName;

	[Token(Token = "0x4001260")]
	[FieldOffset(Offset = "0x58")]
	public UITexture m_Icon;

	[Token(Token = "0x4001261")]
	[FieldOffset(Offset = "0x60")]
	public UIWidget m_Root;

	[Token(Token = "0x4001262")]
	[FieldOffset(Offset = "0x68")]
	public UISprite m_Unavailable;

	[Token(Token = "0x4001263")]
	[FieldOffset(Offset = "0x70")]
	public Color m_Disabled;

	[Token(Token = "0x4001264")]
	[FieldOffset(Offset = "0x80")]
	public Color m_Normal;

	[Token(Token = "0x4001265")]
	[FieldOffset(Offset = "0x90")]
	public Color m_Selected;

	[Token(Token = "0x4001266")]
	[FieldOffset(Offset = "0xA0")]
	public GameObject m_NotificationFlag;

	[Token(Token = "0x4001267")]
	[FieldOffset(Offset = "0xA8")]
	private bool m_CanCraftBlueprint;

	[Token(Token = "0x4001268")]
	[FieldOffset(Offset = "0xB0")]
	private BlueprintData m_BlueprintData;

	[Token(Token = "0x600125A")]
	[Address(RVA = "0x64F5C0", Offset = "0x64E3C0", Length = "0x188")]
	public void Clear()
	{
	}

	[Token(Token = "0x600125B")]
	[Address(RVA = "0x64F750", Offset = "0x64E550", Length = "0x45")]
	protected override void OnItemClick()
	{
	}

	[Token(Token = "0x600125C")]
	[Address(RVA = "0x64F7A0", Offset = "0x64E5A0", Length = "0x276")]
	public override void SetSelected(bool selected)
	{
	}

	[Token(Token = "0x600125D")]
	[Address(RVA = "0x64FA20", Offset = "0x64E820", Length = "0x488")]
	public void Setup(BlueprintData bpi, bool canCraftBlueprint)
	{
	}

	[Token(Token = "0x600125E")]
	[Address(RVA = "0x502310", Offset = "0x501110", Length = "0x8")]
	public BlueprintData GetBlueprintData()
	{
		return null;
	}

	[Token(Token = "0x600125F")]
	[Address(RVA = "0x4AF5E0", Offset = "0x4AE3E0", Length = "0x43")]
	public BlueprintDisplayItem()
	{
	}
}
