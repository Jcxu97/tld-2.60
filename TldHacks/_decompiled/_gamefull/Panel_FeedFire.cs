using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using TLD.UI;
using TLD.UI.Generics;
using UnityEngine;

[Token(Token = "0x2000651")]
public class Panel_FeedFire : Panel_AutoReferenced
{
	[Token(Token = "0x4003CEB")]
	[FieldOffset(Offset = "0x30")]
	public string m_FeedFireAudio;

	[Token(Token = "0x4003CEC")]
	[FieldOffset(Offset = "0x38")]
	public float m_HoursRemainingFullFireSprite;

	[Token(Token = "0x4003CED")]
	[FieldOffset(Offset = "0x3C")]
	public Color m_ScrollListSelectedColor;

	[Token(Token = "0x4003CEE")]
	[FieldOffset(Offset = "0x4C")]
	public Color m_ScrollListUnselectedColor;

	[Token(Token = "0x4003CEF")]
	[FieldOffset(Offset = "0x60")]
	public ScrollList m_FuelScrollList;

	[Token(Token = "0x4003CF0")]
	[FieldOffset(Offset = "0x68")]
	public UILabel m_Label_EstimatedFireDuration;

	[Token(Token = "0x4003CF1")]
	[FieldOffset(Offset = "0x70")]
	public UILabel m_Label_FireTemperature;

	[Token(Token = "0x4003CF2")]
	[FieldOffset(Offset = "0x78")]
	public UITexture m_Texture_GearItem;

	[Token(Token = "0x4003CF3")]
	[FieldOffset(Offset = "0x80")]
	public UITexture m_Texture_InspectItem;

	[Token(Token = "0x4003CF4")]
	[FieldOffset(Offset = "0x88")]
	public ButtonLegendContainer m_ButtonLegendContainer;

	[Token(Token = "0x4003CF5")]
	[FieldOffset(Offset = "0x90")]
	public GameObject m_MouseButtonParent;

	[Token(Token = "0x4003CF6")]
	[FieldOffset(Offset = "0x98")]
	public GameObject m_ActionButtonObject;

	[Token(Token = "0x4003CF7")]
	[FieldOffset(Offset = "0xA0")]
	public GameObject m_ActionSecondaryButtonObject;

	[Token(Token = "0x4003CF8")]
	[FieldOffset(Offset = "0xA8")]
	public UISprite m_Sprite_FireFill;

	[Token(Token = "0x4003CF9")]
	[FieldOffset(Offset = "0xB0")]
	public GameObject m_DefaultSelectedButton;

	[Token(Token = "0x4003CFA")]
	[FieldOffset(Offset = "0xB8")]
	public float m_InspectModeSizeModifier;

	[Header("Torch Grabbing")]
	[SerializeField]
	[Token(Token = "0x4003CFB")]
	[FieldOffset(Offset = "0xC0")]
	private AssetReferenceGearItem m_TorchAssetReference;

	[SerializeField]
	[Token(Token = "0x4003CFC")]
	[FieldOffset(Offset = "0xC8")]
	private float m_MinNormalizedTorchCondition;

	[SerializeField]
	[Token(Token = "0x4003CFD")]
	[FieldOffset(Offset = "0xCC")]
	private float m_MaxNormalizedTorchCondition;

	[Token(Token = "0x4003CFE")]
	[FieldOffset(Offset = "0xD0")]
	private UILabel m_Label_ButtonAction;

	[Token(Token = "0x4003CFF")]
	[FieldOffset(Offset = "0xD8")]
	private UILabel m_Label_ButtonSecondaryAction;

	[Token(Token = "0x4003D00")]
	[FieldOffset(Offset = "0xE0")]
	private FireplaceInteraction m_FireplaceInteraction;

	[Token(Token = "0x4003D01")]
	[FieldOffset(Offset = "0xE8")]
	private GearItem m_PrevSelectedGearItem;

	[Token(Token = "0x4003D02")]
	[FieldOffset(Offset = "0xF0")]
	private GearItem m_ResearchItemToBurn;

	[Token(Token = "0x4003D03")]
	[FieldOffset(Offset = "0xF8")]
	private Action m_OnDoneFeedingFire;

	[Token(Token = "0x4003D04")]
	[FieldOffset(Offset = "0x100")]
	private int m_SelectedFuelSourceIndexVal;

	[Token(Token = "0x4003D05")]
	[FieldOffset(Offset = "0x108")]
	private List<GearItem> m_FuelSourcesList;

	[Token(Token = "0x4003D06")]
	[FieldOffset(Offset = "0x110")]
	private bool m_EnablePending;

	[Token(Token = "0x4003D07")]
	[FieldOffset(Offset = "0x114")]
	private float m_EnableDelaySeconds;

	[Token(Token = "0x4003D08")]
	[FieldOffset(Offset = "0x118")]
	private float m_EnableDelayElapsed;

	[Token(Token = "0x4003D09")]
	[FieldOffset(Offset = "0x120")]
	private FireManager m_FireManager;

	[Token(Token = "0x4003D0A")]
	[FieldOffset(Offset = "0x128")]
	private int m_NumFramesInPanel;

	[Header("Panel References")]
	[SerializeField]
	[Token(Token = "0x4003D0B")]
	[FieldOffset(Offset = "0x130")]
	private PanelReference<Panel_Confirmation> m_Confirmation;

	[Token(Token = "0x170002F1")]
	private int m_SelectedFuelSourceIndex
	{
		[Token(Token = "0x6003343")]
		[Address(RVA = "0xA0A700", Offset = "0xA09500", Length = "0x7")]
		get
		{
			return 0;
		}
		[Token(Token = "0x6003344")]
		[Address(RVA = "0xA0A710", Offset = "0xA09510", Length = "0x10A")]
		set
		{
		}
	}

	[Token(Token = "0x6003345")]
	[Address(RVA = "0xA0A820", Offset = "0xA09620", Length = "0x17E")]
	public override void Initialize()
	{
	}

	[Token(Token = "0x6003346")]
	[Address(RVA = "0xA0A9A0", Offset = "0xA097A0", Length = "0x3DD")]
	private void Update()
	{
	}

	[Token(Token = "0x6003347")]
	[Address(RVA = "0xA0AD80", Offset = "0xA09B80", Length = "0x37")]
	public void Refresh()
	{
	}

	[Token(Token = "0x6003348")]
	[Address(RVA = "0xA0ADC0", Offset = "0xA09BC0", Length = "0x22E")]
	public void SetFireplaceInteraction(FireplaceInteraction fireplaceInteraction)
	{
	}

	[Token(Token = "0x6003349")]
	[Address(RVA = "0xA0AFF0", Offset = "0xA09DF0", Length = "0x6ED")]
	public void ShowFeedFire(float delaySeconds, Action onDoneFeedingFire)
	{
	}

	[Token(Token = "0x600334A")]
	[Address(RVA = "0xA0B6E0", Offset = "0xA0A4E0", Length = "0x57C")]
	public override void Enable(bool enable)
	{
	}

	[Token(Token = "0x600334B")]
	[Address(RVA = "0xA0BC60", Offset = "0xA0AA60", Length = "0x35A")]
	private void RefreshFireDurationLabel()
	{
	}

	[Token(Token = "0x600334C")]
	[Address(RVA = "0xA0BFC0", Offset = "0xA0ADC0", Length = "0x63")]
	public void OnScrollItemSelect(int itemIndex)
	{
	}

	[Token(Token = "0x600334D")]
	[Address(RVA = "0xA0C030", Offset = "0xA0AE30", Length = "0x11E")]
	public void OnDoAction()
	{
	}

	[Token(Token = "0x600334E")]
	[Address(RVA = "0xA0C150", Offset = "0xA0AF50", Length = "0x54")]
	public void OnDoActionSecondary()
	{
	}

	[Token(Token = "0x600334F")]
	[Address(RVA = "0xA0C1B0", Offset = "0xA0AFB0", Length = "0x86A")]
	public void OnFeedFire()
	{
	}

	[Token(Token = "0x6003350")]
	[Address(RVA = "0xA0CA20", Offset = "0xA0B820", Length = "0x12A")]
	private void ForceBurnResearchItem()
	{
	}

	[Token(Token = "0x6003351")]
	[Address(RVA = "0xA0CB50", Offset = "0xA0B950", Length = "0x440")]
	public void OnTakeTorch()
	{
	}

	[Token(Token = "0x6003352")]
	[Address(RVA = "0xA0CFA0", Offset = "0xA0BDA0", Length = "0x55")]
	public void OnDone()
	{
	}

	[Token(Token = "0x6003353")]
	[Address(RVA = "0xA0D000", Offset = "0xA0BE00", Length = "0x5F")]
	public void OnCancel()
	{
	}

	[Token(Token = "0x6003354")]
	[Address(RVA = "0xA0D060", Offset = "0xA0BE60", Length = "0x45")]
	public void PlayButtonClick()
	{
	}

	[Token(Token = "0x6003355")]
	[Address(RVA = "0xA0D0B0", Offset = "0xA0BEB0", Length = "0x28B")]
	public void InspectPrevGearItem()
	{
	}

	[Token(Token = "0x6003356")]
	[Address(RVA = "0xA0D340", Offset = "0xA0C140", Length = "0xE7")]
	public void ExitFeedFireInterface()
	{
	}

	[Token(Token = "0x6003357")]
	[Address(RVA = "0xA0D430", Offset = "0xA0C230", Length = "0x147")]
	private void UpdateScrollLists()
	{
	}

	[Token(Token = "0x6003358")]
	[Address(RVA = "0xA0D580", Offset = "0xA0C380", Length = "0x93")]
	private void ScrollDown()
	{
	}

	[Token(Token = "0x6003359")]
	[Address(RVA = "0xA0D620", Offset = "0xA0C420", Length = "0x6D")]
	private void ScrollUp()
	{
	}

	[Token(Token = "0x600335A")]
	[Address(RVA = "0xA0D690", Offset = "0xA0C490", Length = "0x75")]
	private bool FilterItemFuelSource(GameObject go)
	{
		return false;
	}

	[Token(Token = "0x600335B")]
	[Address(RVA = "0xA0D710", Offset = "0xA0C510", Length = "0x8D")]
	private GearItem GetSelectedFuelSource()
	{
		return null;
	}

	[Token(Token = "0x600335C")]
	[Address(RVA = "0xA0D7A0", Offset = "0xA0C5A0", Length = "0xB30")]
	private void RefreshFuelSources()
	{
	}

	[Token(Token = "0x600335D")]
	[Address(RVA = "0xA0E2E0", Offset = "0xA0D0E0", Length = "0xA")]
	private void MakeDefaultSelections()
	{
	}

	[Token(Token = "0x600335E")]
	[Address(RVA = "0xA0E2F0", Offset = "0xA0D0F0", Length = "0x572")]
	private void UpdateGearItem(GearItem gi)
	{
	}

	[Token(Token = "0x600335F")]
	[Address(RVA = "0xA0E870", Offset = "0xA0D670", Length = "0x122")]
	private void EnableActionButton(bool enabled)
	{
	}

	[Token(Token = "0x6003360")]
	[Address(RVA = "0xA0E9A0", Offset = "0xA0D7A0", Length = "0x6B0")]
	private void UpdateButtonLegend()
	{
	}

	[Token(Token = "0x6003361")]
	[Address(RVA = "0xA0F060", Offset = "0xA0DE60", Length = "0x1F6")]
	private void UpdateListItemColors(ScrollList scrollList, int selectedIndex)
	{
	}

	[Token(Token = "0x6003362")]
	[Address(RVA = "0xA0F260", Offset = "0xA0E060", Length = "0xFA")]
	private bool CanTakeTorch()
	{
		return false;
	}

	[Token(Token = "0x6003363")]
	[Address(RVA = "0xA0F360", Offset = "0xA0E160", Length = "0xDF")]
	private bool FireInForge()
	{
		return false;
	}

	[Token(Token = "0x6003364")]
	[Address(RVA = "0xA0F440", Offset = "0xA0E240", Length = "0x191")]
	public Panel_FeedFire()
	{
	}
}
