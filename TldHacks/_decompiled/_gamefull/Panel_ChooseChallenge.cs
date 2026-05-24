using Cpp2ILInjected;
using TLD.UI;
using TLD.UI.Generics;
using UnityEngine;

[Token(Token = "0x200061D")]
public class Panel_ChooseChallenge : Panel_AutoReferenced
{
	[SerializeField]
	[Token(Token = "0x40039AB")]
	[FieldOffset(Offset = "0x30")]
	private PanelReference<Panel_Challenges> m_Challenges;

	[SerializeField]
	[Token(Token = "0x40039AC")]
	[FieldOffset(Offset = "0x38")]
	private PanelReference<Panel_Confirmation> m_Confirmation;

	[SerializeField]
	[Token(Token = "0x40039AD")]
	[FieldOffset(Offset = "0x40")]
	private PanelReference<Panel_Loading> m_Loading;

	[SerializeField]
	[Token(Token = "0x40039AE")]
	[FieldOffset(Offset = "0x48")]
	private PanelReference<Panel_MainMenu> m_MainMenu;

	[SerializeField]
	[Token(Token = "0x40039AF")]
	[FieldOffset(Offset = "0x50")]
	private PanelReference<Panel_SurvivalSettings> m_SurvivalSettings;

	[Token(Token = "0x40039B0")]
	[FieldOffset(Offset = "0x58")]
	public ButtonLegendContainer m_ButtonLegendContainer;

	[Token(Token = "0x40039B1")]
	[FieldOffset(Offset = "0x60")]
	public UtilsPanelChoose.DetailsObjets m_DetailObjects;

	[Header("Menu items")]
	[Token(Token = "0x40039B2")]
	[FieldOffset(Offset = "0x68")]
	public LocalizedString m_Title;

	[Token(Token = "0x40039B3")]
	[FieldOffset(Offset = "0x70")]
	public LocalizedString m_TitleHeader;

	[Token(Token = "0x40039B4")]
	[FieldOffset(Offset = "0x78")]
	public Vector3 m_TitleHeaderOffset;

	[Token(Token = "0x40039B5")]
	[FieldOffset(Offset = "0x88")]
	public GameObject m_BasicMenuRoot;

	[Header("Invalid Save")]
	[Token(Token = "0x40039B6")]
	[FieldOffset(Offset = "0x90")]
	public Color m_InvalidSaveColor;

	[Token(Token = "0x40039B7")]
	[FieldOffset(Offset = "0xA0")]
	public LocalizedString m_MissingDLCString;

	[Header("Slots In Use")]
	[Token(Token = "0x40039B8")]
	[FieldOffset(Offset = "0xA8")]
	public SaveSpaceInfo m_SaveSpaceInfo;

	[Header("Mouse button")]
	[Token(Token = "0x40039B9")]
	[FieldOffset(Offset = "0xB0")]
	public GameObject m_MouseButtonDelete;

	[Token(Token = "0x40039BA")]
	[FieldOffset(Offset = "0xB8")]
	public GameObject m_MouseButtonRename;

	[Header("Steam Cloud")]
	[Token(Token = "0x40039BB")]
	[FieldOffset(Offset = "0xC0")]
	public UILabel m_CloudMessageLabel;

	[Token(Token = "0x40039BC")]
	[FieldOffset(Offset = "0xC8")]
	private SaveSlotInfo m_SlotToRename;

	[Token(Token = "0x40039BD")]
	[FieldOffset(Offset = "0xD0")]
	private SaveSlotInfo m_SlotToDelete;

	[Token(Token = "0x40039BE")]
	[FieldOffset(Offset = "0xD8")]
	private BasicMenu m_BasicMenu;

	[Token(Token = "0x40039BF")]
	[FieldOffset(Offset = "0xE0")]
	private CloudSaveMenuExtension m_CloudSaveMenuExtension;

	[Token(Token = "0x40039C0")]
	[FieldOffset(Offset = "0xE8")]
	private int m_IndexToLoad;

	[Token(Token = "0x600306A")]
	[Address(RVA = "0x9AA490", Offset = "0x9A9290", Length = "0x13F")]
	public override void Initialize()
	{
	}

	[Token(Token = "0x600306B")]
	[Address(RVA = "0x9AA5D0", Offset = "0x9A93D0", Length = "0x1E")]
	protected override void OnDestroy()
	{
	}

	[Token(Token = "0x600306C")]
	[Address(RVA = "0x9AA5F0", Offset = "0x9A93F0", Length = "0x309")]
	private void ConfigureMenu()
	{
	}

	[Token(Token = "0x600306D")]
	[Address(RVA = "0x9AA900", Offset = "0x9A9700", Length = "0x742")]
	private void AddSavesOfTypeToMenu()
	{
	}

	[Token(Token = "0x600306E")]
	[Address(RVA = "0x9AB050", Offset = "0x9A9E50", Length = "0x1A1")]
	private void Update()
	{
	}

	[Token(Token = "0x600306F")]
	[Address(RVA = "0x9AB200", Offset = "0x9AA000", Length = "0x159")]
	public override void Enable(bool enable)
	{
	}

	[Token(Token = "0x6003070")]
	[Address(RVA = "0x9AB360", Offset = "0x9AA160", Length = "0xDC")]
	public void OnClickBack()
	{
	}

	[Token(Token = "0x6003071")]
	[Address(RVA = "0x9AB440", Offset = "0x9AA240", Length = "0x56")]
	public void BackWithouSFX()
	{
	}

	[Token(Token = "0x6003072")]
	[Address(RVA = "0x9AB4A0", Offset = "0x9AA2A0", Length = "0x23F")]
	private void ProcessMenu()
	{
	}

	[Token(Token = "0x6003073")]
	[Address(RVA = "0x9AB6E0", Offset = "0x9AA4E0", Length = "0x51")]
	private SaveSlotInfo GetSaveSlotInfo(int index)
	{
		return null;
	}

	[Token(Token = "0x6003074")]
	[Address(RVA = "0x9AB740", Offset = "0x9AA540", Length = "0x70")]
	private SaveSlotInfo GetSelectedSaveSlotInfo()
	{
		return null;
	}

	[Token(Token = "0x6003075")]
	[Address(RVA = "0x9AB7C0", Offset = "0x9AA5C0", Length = "0x28E")]
	public void OnRename()
	{
	}

	[Token(Token = "0x6003076")]
	[Address(RVA = "0x9ABA50", Offset = "0x9AA850", Length = "0x52")]
	public void OnRenameExistingChallengeCancelled(bool wasCancelled)
	{
	}

	[Token(Token = "0x6003077")]
	[Address(RVA = "0x9ABAB0", Offset = "0x9AA8B0", Length = "0x1E0")]
	private void OnRenameExistingChallengeConfirmed()
	{
	}

	[Token(Token = "0x6003078")]
	[Address(RVA = "0x9ABCA0", Offset = "0x9AAAA0", Length = "0x1CD")]
	public void OnDelete()
	{
	}

	[Token(Token = "0x6003079")]
	[Address(RVA = "0x9ABE70", Offset = "0x9AAC70", Length = "0x148")]
	private void DeleteSaveSlot()
	{
	}

	[Token(Token = "0x600307A")]
	[Address(RVA = "0x9ABFC0", Offset = "0x9AADC0", Length = "0x52")]
	private void OnDeleteCancelled(bool wasCancelled)
	{
	}

	[Token(Token = "0x600307B")]
	[Address(RVA = "0x9AC020", Offset = "0x9AAE20", Length = "0x10D")]
	private void RefreshDetails(SaveSlotInfo slotInfo)
	{
	}

	[Token(Token = "0x600307C")]
	[Address(RVA = "0x9AC130", Offset = "0x9AAF30", Length = "0xB7")]
	private void OnSelectionUpdate(string name, int value, int itemIndex)
	{
	}

	[Token(Token = "0x600307D")]
	[Address(RVA = "0x9AC1F0", Offset = "0x9AAFF0", Length = "0x298")]
	private void OnLoadSlotClicked(int index)
	{
	}

	[Token(Token = "0x600307E")]
	[Address(RVA = "0x9A9F30", Offset = "0x9A8D30", Length = "0x13")]
	private void OnGoBackInSurvivalSettings()
	{
	}

	[Token(Token = "0x600307F")]
	[Address(RVA = "0x9AC490", Offset = "0x9AB290", Length = "0x89")]
	private void OnDoneShowingSurvivalSettings()
	{
	}

	[Token(Token = "0x6003080")]
	[Address(RVA = "0x9AC520", Offset = "0x9AB320", Length = "0xC4")]
	private void OnSlotClicked()
	{
	}

	[Token(Token = "0x6003081")]
	[Address(RVA = "0x9AC5F0", Offset = "0x9AB3F0", Length = "0x15C")]
	public Panel_ChooseChallenge()
	{
	}
}
