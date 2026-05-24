using Cpp2ILInjected;
using UnityEngine;

namespace TLD.UI;

[RequireComponent(typeof(BoxCollider), typeof(UIButton), typeof(UIButtonScale))]
[Token(Token = "0x200138F")]
public class MiniTopNavButton : MonoBehaviour
{
	[Token(Token = "0x4008FAE")]
	[FieldOffset(Offset = "0x20")]
	public bool m_IsCurrentView;

	[SerializeField]
	[Token(Token = "0x4008FAF")]
	[FieldOffset(Offset = "0x28")]
	private PanelReference m_TargetPanel;

	[AutoComponent(ComponentRequirement.Required)]
	[SerializeField]
	[Token(Token = "0x4008FB0")]
	[FieldOffset(Offset = "0x30")]
	private BoxCollider m_BoxCollider;

	[AutoComponent(ComponentRequirement.Required)]
	[SerializeField]
	[Token(Token = "0x4008FB1")]
	[FieldOffset(Offset = "0x38")]
	private UIButton m_UIButton;

	[AutoComponent(ComponentRequirement.Required)]
	[SerializeField]
	[Token(Token = "0x4008FB2")]
	[FieldOffset(Offset = "0x40")]
	private UIButtonScale m_UIButtonScale;

	[Token(Token = "0x4008FB3")]
	[FieldOffset(Offset = "0x48")]
	private Panel_Base m_PanelOwner;

	[Token(Token = "0x6007CEB")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	private void OnValidate()
	{
	}

	[Token(Token = "0x6007CEC")]
	[Address(RVA = "0x4D0B60", Offset = "0x4CF960", Length = "0x52")]
	public void SetOwner(Panel_Base owner)
	{
	}

	[Token(Token = "0x6007CED")]
	[Address(RVA = "0x11C22D0", Offset = "0x11C10D0", Length = "0x58")]
	public void SetEnabled(bool enable)
	{
	}

	[Token(Token = "0x6007CEE")]
	[Address(RVA = "0x11C2330", Offset = "0x11C1130", Length = "0x11C")]
	public bool CanShow()
	{
		return false;
	}

	[Token(Token = "0x6007CEF")]
	[Address(RVA = "0x11C2450", Offset = "0x11C1250", Length = "0x1B7")]
	public void OnButtonClick()
	{
	}

	[Token(Token = "0x6007CF0")]
	[Address(RVA = "0x4AF5E0", Offset = "0x4AE3E0", Length = "0x43")]
	public MiniTopNavButton()
	{
	}
}
