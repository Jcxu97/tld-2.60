using Cpp2ILInjected;
using TLD.UI.Generics;
using UnityEngine;

[Token(Token = "0x20006E3")]
public class SafehouseClearJunkIndicator : MonoBehaviour
{
	[SerializeField]
	[Token(Token = "0x4004964")]
	[FieldOffset(Offset = "0x20")]
	private UIWidget m_Widget;

	[SerializeField]
	[Token(Token = "0x4004965")]
	[FieldOffset(Offset = "0x28")]
	private ButtonPrompt m_ButtonPrompt;

	[SerializeField]
	[Token(Token = "0x4004966")]
	[FieldOffset(Offset = "0x30")]
	private LocalizedString m_ClearJunkText;

	[Header("Panel References")]
	[SerializeField]
	[Token(Token = "0x4004967")]
	[FieldOffset(Offset = "0x38")]
	private PanelReference<Panel_HUD> m_HUD;

	[Token(Token = "0x4004968")]
	[FieldOffset(Offset = "0x40")]
	private float m_IndicatorTimer;

	[Token(Token = "0x4004969")]
	[FieldOffset(Offset = "0x44")]
	private float m_FadeOutTime;

	[Token(Token = "0x400496A")]
	[FieldOffset(Offset = "0x48")]
	private bool m_IsShown;

	[Token(Token = "0x6003CAF")]
	[Address(RVA = "0xB82F70", Offset = "0xB81D70", Length = "0x34")]
	private void Awake()
	{
	}

	[Token(Token = "0x6003CB0")]
	[Address(RVA = "0xB82FB0", Offset = "0xB81DB0", Length = "0x1B8")]
	public void RefreshIndicator()
	{
	}

	[Token(Token = "0x6003CB1")]
	[Address(RVA = "0xB83170", Offset = "0xB81F70", Length = "0x316")]
	public void UpdateIndicator()
	{
	}

	[Token(Token = "0x6003CB2")]
	[Address(RVA = "0xB83490", Offset = "0xB82290", Length = "0xF3")]
	private bool ShouldHideIndicatorTemporarily()
	{
		return false;
	}

	[Token(Token = "0x6003CB3")]
	[Address(RVA = "0xB82F70", Offset = "0xB81D70", Length = "0x34")]
	private void HideIndicator()
	{
	}

	[Token(Token = "0x6003CB4")]
	[Address(RVA = "0xB83590", Offset = "0xB82390", Length = "0x36")]
	private void OnControllerScheme(bool _)
	{
	}

	[Token(Token = "0x6003CB5")]
	[Address(RVA = "0x4AF5E0", Offset = "0x4AE3E0", Length = "0x43")]
	public SafehouseClearJunkIndicator()
	{
	}
}
