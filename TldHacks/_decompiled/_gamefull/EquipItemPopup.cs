using Cpp2ILInjected;
using TLD.UI.Generics;
using UnityEngine;

[Token(Token = "0x2000238")]
public class EquipItemPopup : MonoBehaviour
{
	[SerializeField]
	[Token(Token = "0x400138D")]
	[FieldOffset(Offset = "0x20")]
	private Panel_HUD m_HUD;

	[SerializeField]
	[Token(Token = "0x400138E")]
	[FieldOffset(Offset = "0x28")]
	private PanelReference<Panel_Actions> m_Actions;

	[SerializeField]
	[Token(Token = "0x400138F")]
	[FieldOffset(Offset = "0x30")]
	private PanelReference<Panel_ActionsRadial> m_ActionsRadial;

	[Token(Token = "0x4001390")]
	[FieldOffset(Offset = "0x38")]
	public ButtonPrompt m_ButtonPromptFire;

	[Token(Token = "0x4001391")]
	[FieldOffset(Offset = "0x40")]
	public ButtonPrompt m_ButtonPromptAltFire;

	[Token(Token = "0x4001392")]
	[FieldOffset(Offset = "0x48")]
	public ButtonPrompt m_ButtonPromptReload;

	[Token(Token = "0x4001393")]
	[FieldOffset(Offset = "0x50")]
	public ButtonPrompt m_ButtonPromptHolster;

	[Token(Token = "0x4001394")]
	[FieldOffset(Offset = "0x58")]
	public ButtonPrompt m_ButtonPromptLeft;

	[Token(Token = "0x4001395")]
	[FieldOffset(Offset = "0x60")]
	public ButtonPrompt m_ButtonPromptRight;

	[Token(Token = "0x4001396")]
	[FieldOffset(Offset = "0x68")]
	public ButtonPrompt m_ButtonPromptScrollWheel;

	[Token(Token = "0x4001397")]
	[FieldOffset(Offset = "0x70")]
	public UILabel m_LabelDurationValue;

	[Token(Token = "0x4001398")]
	[FieldOffset(Offset = "0x78")]
	public UISprite m_SpriteFillDuration;

	[Token(Token = "0x4001399")]
	[FieldOffset(Offset = "0x80")]
	public float m_SpriteFillDurationOffset;

	[Token(Token = "0x400139A")]
	[FieldOffset(Offset = "0x88")]
	public GameObject m_ObjectDuration;

	[Token(Token = "0x400139B")]
	[FieldOffset(Offset = "0x90")]
	public UIWidget m_EquipPopupWidget;

	[Token(Token = "0x400139C")]
	[FieldOffset(Offset = "0x98")]
	public GameObject m_EquipPopupTopLeft;

	[Token(Token = "0x400139D")]
	[FieldOffset(Offset = "0xA0")]
	public GameObject m_EquipPopupBottom;

	[Token(Token = "0x400139E")]
	[FieldOffset(Offset = "0xA8")]
	public UIWidget m_AmmoWidget;

	[Token(Token = "0x400139F")]
	[FieldOffset(Offset = "0xB0")]
	public UISprite m_AmmoTypeSprite;

	[Token(Token = "0x40013A0")]
	[FieldOffset(Offset = "0xB8")]
	public UISprite[] m_ListAmmoSprites;

	[Token(Token = "0x40013A1")]
	[FieldOffset(Offset = "0xC0")]
	public UILabel m_LabelAmmoReserve;

	[Token(Token = "0x40013A2")]
	[FieldOffset(Offset = "0xC8")]
	public UILabel m_LabelItemCount;

	[Token(Token = "0x40013A3")]
	[FieldOffset(Offset = "0xD0")]
	private float m_TimeToHidePopup;

	[Token(Token = "0x40013A4")]
	[FieldOffset(Offset = "0xD4")]
	private float m_TimeToHideAmmo;

	[Token(Token = "0x40013A5")]
	[FieldOffset(Offset = "0xD8")]
	private bool m_ShowingPlaceMeshIcons;

	[Token(Token = "0x40013A6")]
	[FieldOffset(Offset = "0xE0")]
	private string m_FireText;

	[Token(Token = "0x40013A7")]
	[FieldOffset(Offset = "0xE8")]
	private string m_AltFireText;

	[Token(Token = "0x40013A8")]
	[FieldOffset(Offset = "0xF0")]
	private bool m_ShowedAmmoCountForNoRoundsInClip;

	[Token(Token = "0x40013A9")]
	[FieldOffset(Offset = "0xF4")]
	private Vector3 m_ButtonPromptFireOriginalPosition;

	[Token(Token = "0x40013AA")]
	[FieldOffset(Offset = "0x100")]
	private Vector3 m_ButtonPromptAltFireOriginalPosition;

	[Token(Token = "0x40013AB")]
	[FieldOffset(Offset = "0x10C")]
	private Vector3 m_ButtonPromptCenteredOriginalPosition;

	[Token(Token = "0x40013AC")]
	[FieldOffset(Offset = "0x118")]
	private bool m_HasInitialized;

	[Token(Token = "0x40013AD")]
	[FieldOffset(Offset = "0x120")]
	private GearItem m_GearItem;

	[Token(Token = "0x40013AE")]
	[FieldOffset(Offset = "0x128")]
	private int m_LastReserveValue;

	[Token(Token = "0x6001393")]
	[Address(RVA = "0x66E2F0", Offset = "0x66D0F0", Length = "0x29")]
	private void Awake()
	{
	}

	[Token(Token = "0x6001394")]
	[Address(RVA = "0x66E320", Offset = "0x66D120", Length = "0x307")]
	public void OnControllerScheme(bool isController)
	{
	}

	[Token(Token = "0x6001395")]
	[Address(RVA = "0x66E630", Offset = "0x66D430", Length = "0xAD4")]
	private void Update()
	{
	}

	[Token(Token = "0x6001396")]
	[Address(RVA = "0x66F110", Offset = "0x66DF10", Length = "0x231")]
	private void InitializeValues()
	{
	}

	[Token(Token = "0x6001397")]
	[Address(RVA = "0x66F350", Offset = "0x66E150", Length = "0x6E")]
	private bool IsHoveringInteractiveObject()
	{
		return false;
	}

	[Token(Token = "0x6001398")]
	[Address(RVA = "0x66F3C0", Offset = "0x66E1C0", Length = "0x188")]
	private void MaybeRepositionAltFireButtonPrompt(string otherButtonText)
	{
	}

	[Token(Token = "0x6001399")]
	[Address(RVA = "0x66F550", Offset = "0x66E350", Length = "0x188")]
	private void MaybeRepositionFireButtonPrompt(string otherButtonText)
	{
	}

	[Token(Token = "0x600139A")]
	[Address(RVA = "0x66F6E0", Offset = "0x66E4E0", Length = "0xD8")]
	public void ShowPlaceMeshItem(bool show, bool isDecal)
	{
	}

	[Token(Token = "0x600139B")]
	[Address(RVA = "0x66F7C0", Offset = "0x66E5C0", Length = "0x838")]
	private void UpdatePlacementButtonLabels()
	{
	}

	[Token(Token = "0x600139C")]
	[Address(RVA = "0x670000", Offset = "0x66EE00", Length = "0x10EE")]
	public void ShowEquippedItem(GearItem gi)
	{
	}

	[Token(Token = "0x600139D")]
	[Address(RVA = "0x6710F0", Offset = "0x66FEF0", Length = "0x1F5")]
	public void ShowGenericPopup(string fireButtonStr, string fireButtonAction, string altFireButtonStr, string altFireButtonAction)
	{
	}

	[Token(Token = "0x600139E")]
	[Address(RVA = "0x6712F0", Offset = "0x6700F0", Length = "0x2DD")]
	public void ShowGenericPopupWithDefaultActions(string fireButtonStr, string altFireButtonStr)
	{
	}

	[Token(Token = "0x600139F")]
	[Address(RVA = "0x6715D0", Offset = "0x6703D0", Length = "0x64")]
	public void ShowAmmoForTime(float seconds)
	{
	}

	[Token(Token = "0x60013A0")]
	[Address(RVA = "0x671640", Offset = "0x670440", Length = "0x32")]
	private void HideEquipPopupWidget()
	{
	}

	[Token(Token = "0x60013A1")]
	[Address(RVA = "0x671680", Offset = "0x670480", Length = "0x9C")]
	public void HideEquipPopup()
	{
	}

	[Token(Token = "0x60013A2")]
	[Address(RVA = "0x671720", Offset = "0x670520", Length = "0xAD")]
	public void HideAmmoPopup()
	{
	}

	[Token(Token = "0x60013A3")]
	[Address(RVA = "0x6717D0", Offset = "0x6705D0", Length = "0x50D")]
	private bool AllowedToHideAmmoPopup()
	{
		return false;
	}

	[Token(Token = "0x60013A4")]
	[Address(RVA = "0x671CE0", Offset = "0x670AE0", Length = "0x619")]
	private void UpdateButtonStatus()
	{
	}

	[Token(Token = "0x60013A5")]
	[Address(RVA = "0x672300", Offset = "0x671100", Length = "0x158F")]
	private void UpdateAmmoStatus()
	{
	}

	[Token(Token = "0x60013A6")]
	[Address(RVA = "0x673890", Offset = "0x672690", Length = "0x4E")]
	private void ShowEquipPopupWidget()
	{
	}

	[Token(Token = "0x60013A7")]
	[Address(RVA = "0x6738E0", Offset = "0x6726E0", Length = "0x2DA")]
	private void ShowItemIcons(string fireButtonStr, string altFireButtonStr, bool showAmmo)
	{
	}

	[Token(Token = "0x60013A8")]
	[Address(RVA = "0x673BC0", Offset = "0x6729C0", Length = "0x20F")]
	private bool ControlModeAllowsInterface()
	{
		return false;
	}

	[Token(Token = "0x60013A9")]
	[Address(RVA = "0x673DD0", Offset = "0x672BD0", Length = "0x1F1")]
	private bool ShouldHideEquipPopup()
	{
		return false;
	}

	[Token(Token = "0x60013AA")]
	[Address(RVA = "0x673FD0", Offset = "0x672DD0", Length = "0xD0")]
	private bool ShouldHideAmmoPopup()
	{
		return false;
	}

	[Token(Token = "0x60013AB")]
	[Address(RVA = "0x6740B0", Offset = "0x672EB0", Length = "0x7C")]
	private void SetFillDurationAmount(float value)
	{
	}

	[Token(Token = "0x60013AC")]
	[Address(RVA = "0x674130", Offset = "0x672F30", Length = "0x188")]
	public EquipItemPopup()
	{
	}
}
