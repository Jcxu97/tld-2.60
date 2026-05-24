using System.Collections.Generic;
using Cpp2ILInjected;
using TLD.Scenes;
using TLD.UI;
using UnityEngine;
using UnityEngine.ResourceManagement.AsyncOperations;

[Token(Token = "0x20006C6")]
public class Panel_SelectRegion_Map : Panel_AutoReferenced
{
	[Token(Token = "0x20006C7")]
	private enum AnimationState
	{
		[Token(Token = "0x4004848")]
		None,
		[Token(Token = "0x4004849")]
		RegionSelect,
		[Token(Token = "0x400484A")]
		RegionDeselect
	}

	[Token(Token = "0x400482F")]
	[FieldOffset(Offset = "0x30")]
	public Animator m_EpisodeAnimator;

	[Token(Token = "0x4004830")]
	[FieldOffset(Offset = "0x38")]
	public Transform m_ItemParent;

	[Token(Token = "0x4004831")]
	[FieldOffset(Offset = "0x40")]
	public Transform m_LabelParent;

	[Token(Token = "0x4004832")]
	[FieldOffset(Offset = "0x48")]
	public ButtonLegendContainer m_ButtonLegendContainer;

	[Token(Token = "0x4004833")]
	[FieldOffset(Offset = "0x50")]
	public GenericButtonMouseSpawner m_ConfirmButtonMouseSpawner;

	[Token(Token = "0x4004834")]
	[FieldOffset(Offset = "0x58")]
	public GenericButtonMouseSpawner m_RandomButtonMouseSpawner;

	[Token(Token = "0x4004835")]
	[FieldOffset(Offset = "0x60")]
	public GenericButtonMouseSpawner m_SwitchWorldMapButtonMouseSpawner;

	[Token(Token = "0x4004836")]
	[FieldOffset(Offset = "0x68")]
	public SelectRegionItem m_RandomItem;

	[Token(Token = "0x4004837")]
	[FieldOffset(Offset = "0x70")]
	public RegionSpecification m_DefaultRegion;

	[Token(Token = "0x4004838")]
	[FieldOffset(Offset = "0x78")]
	public AnimationStateRef m_StartupAnimation;

	[Token(Token = "0x4004839")]
	[FieldOffset(Offset = "0x80")]
	public AnimationStateRef m_RegionItemSelectAnimation;

	[Token(Token = "0x400483A")]
	[FieldOffset(Offset = "0x88")]
	public AnimationStateRef m_RegionItemDeselectAnimation;

	[SerializeField]
	[Token(Token = "0x400483B")]
	[FieldOffset(Offset = "0x90")]
	private GameObject m_MapSmokeParent;

	[SerializeField]
	[Token(Token = "0x400483C")]
	[FieldOffset(Offset = "0x98")]
	private Transform m_WorldMapParent;

	[SerializeField]
	[Token(Token = "0x400483D")]
	[FieldOffset(Offset = "0xA0")]
	private WorldMapChangedEvent m_WorldMapChangedEvent;

	[Token(Token = "0x400483E")]
	[FieldOffset(Offset = "0xA8")]
	private readonly List<SelectRegionItem> m_Items;

	[Token(Token = "0x400483F")]
	[FieldOffset(Offset = "0xB0")]
	private readonly Dictionary<RegionSpecification, AsyncOperationHandle<GameObject>> m_MapIconLabels;

	[Token(Token = "0x4004840")]
	[FieldOffset(Offset = "0xB8")]
	private IList<WorldMapSpecification> m_AvailableMaps;

	[Token(Token = "0x4004841")]
	[FieldOffset(Offset = "0xC0")]
	private readonly Dictionary<WorldMapSpecification, SelectRegionItem> m_LastHoveredRegions;

	[Token(Token = "0x4004842")]
	[FieldOffset(Offset = "0xC8")]
	private SelectRegionItem m_HoveredItem;

	[Token(Token = "0x4004843")]
	[FieldOffset(Offset = "0xD0")]
	private SelectRegionItem m_SelectedItem;

	[Token(Token = "0x4004844")]
	[FieldOffset(Offset = "0xD8")]
	private SelectRegionItem m_PreviousSelectedItem;

	[Token(Token = "0x4004845")]
	[FieldOffset(Offset = "0xE0")]
	private AnimationState m_CurrentAnimationState;

	[Token(Token = "0x4004846")]
	[FieldOffset(Offset = "0xE8")]
	private readonly HashSet<AsyncOperationHandle<GameObject>> m_PendingInstantiations;

	[Token(Token = "0x6003B65")]
	[Address(RVA = "0xB5E9D0", Offset = "0xB5D7D0", Length = "0x1B7")]
	public override void Initialize()
	{
	}

	[Token(Token = "0x6003B66")]
	[Address(RVA = "0xB5EB90", Offset = "0xB5D990", Length = "0x6A5")]
	protected override void OnDestroy()
	{
	}

	[Token(Token = "0x6003B67")]
	[Address(RVA = "0xB5F240", Offset = "0xB5E040", Length = "0x651")]
	private void OnRegionsLoaded(AsyncOperationHandle<IList<RegionSpecification>> loadOperation)
	{
	}

	[Token(Token = "0x6003B68")]
	[Address(RVA = "0xB5F8A0", Offset = "0xB5E6A0", Length = "0xAE4")]
	private void OnSelectRegionItemInstantiated(AsyncOperationHandle<GameObject> selectRegionItemOperation)
	{
	}

	[Token(Token = "0x6003B69")]
	[Address(RVA = "0xB60390", Offset = "0xB5F190", Length = "0x53")]
	private void Update()
	{
	}

	[Token(Token = "0x6003B6A")]
	[Address(RVA = "0xB603F0", Offset = "0xB5F1F0", Length = "0x2AE")]
	public override void Enable(bool enable)
	{
	}

	[Token(Token = "0x6003B6B")]
	[Address(RVA = "0xB606A0", Offset = "0xB5F4A0", Length = "0xB")]
	public void OnItemSelected(SelectRegionItem item)
	{
	}

	[Token(Token = "0x6003B6C")]
	[Address(RVA = "0xB606B0", Offset = "0xB5F4B0", Length = "0x230")]
	public void OnSwitchMapsSelected()
	{
	}

	[Token(Token = "0x6003B6D")]
	[Address(RVA = "0xB608F0", Offset = "0xB5F6F0", Length = "0xF")]
	public void OnRandomSelected()
	{
	}

	[Token(Token = "0x6003B6E")]
	[Address(RVA = "0xB60900", Offset = "0xB5F700", Length = "0x547")]
	public void OnClickBack()
	{
	}

	[Token(Token = "0x6003B6F")]
	[Address(RVA = "0xB60E50", Offset = "0xB5FC50", Length = "0x215")]
	public void OnSelectRegionContinue()
	{
	}

	[Token(Token = "0x6003B70")]
	[Address(RVA = "0xB61070", Offset = "0xB5FE70", Length = "0x2C1")]
	private void SelectItem(SelectRegionItem item, bool showMapSmoke)
	{
	}

	[Token(Token = "0x6003B71")]
	[Address(RVA = "0xB61340", Offset = "0xB60140", Length = "0x2A1")]
	private SelectRegionItem GetHoveredItem()
	{
		return null;
	}

	[Token(Token = "0x6003B72")]
	[Address(RVA = "0xB615F0", Offset = "0xB603F0", Length = "0x2C5")]
	private void UpdateControls()
	{
	}

	[Token(Token = "0x6003B73")]
	[Address(RVA = "0xB618C0", Offset = "0xB606C0", Length = "0x35F")]
	private void NavigateToItem(SelectRegionItem item)
	{
	}

	[Token(Token = "0x6003B74")]
	[Address(RVA = "0xB61C20", Offset = "0xB60A20", Length = "0x1A1")]
	private void UpdateHoveredItem()
	{
	}

	[Token(Token = "0x6003B75")]
	[Address(RVA = "0xB61DD0", Offset = "0xB60BD0", Length = "0x576")]
	private void UpdateButtonLegend()
	{
	}

	[Token(Token = "0x6003B76")]
	[Address(RVA = "0xB62350", Offset = "0xB61150", Length = "0x2EF")]
	private bool IsAnyAnimationInProgress()
	{
		return false;
	}

	[Token(Token = "0x6003B77")]
	[Address(RVA = "0xB62640", Offset = "0xB61440", Length = "0x88F")]
	private void UpdateAnimation()
	{
	}

	[Token(Token = "0x6003B78")]
	[Address(RVA = "0xB62ED0", Offset = "0xB61CD0", Length = "0x21D")]
	private void PlayAnimation(SelectRegionItem region, AnimationState animation)
	{
	}

	[Token(Token = "0x6003B79")]
	[Address(RVA = "0xB630F0", Offset = "0xB61EF0", Length = "0x1155")]
	private void UpdateDisplayedRegions()
	{
	}

	[Token(Token = "0x6003B7A")]
	[Address(RVA = "0xB64250", Offset = "0xB63050", Length = "0x36")]
	private UIWorldMap GetWorldMap(WorldMapSpecification worldMap)
	{
		return null;
	}

	[Token(Token = "0x6003B7B")]
	[Address(RVA = "0xB64290", Offset = "0xB63090", Length = "0x6DA")]
	public Panel_SelectRegion_Map()
	{
	}
}
