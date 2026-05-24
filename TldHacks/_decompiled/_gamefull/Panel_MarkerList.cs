using System.Collections.Generic;
using Cpp2ILInjected;
using TLD.UI.Generics;
using UnityEngine;

[Token(Token = "0x200026A")]
public class Panel_MarkerList : Panel_List<MarkerListDisplayItem, MapElementSaveData>
{
	[SerializeField]
	[Token(Token = "0x400160F")]
	[FieldOffset(Offset = "0x88")]
	private PanelReference<Panel_Confirmation> m_Confirmation;

	[SerializeField]
	[Token(Token = "0x4001610")]
	[FieldOffset(Offset = "0x90")]
	private PanelReference<Panel_Map> m_Map;

	[Token(Token = "0x4001611")]
	[FieldOffset(Offset = "0x98")]
	public GameObject m_RootObject;

	[Token(Token = "0x4001612")]
	[FieldOffset(Offset = "0xA0")]
	public GameObject m_DeleteAllGroup;

	[Token(Token = "0x4001613")]
	[FieldOffset(Offset = "0xA8")]
	private int m_ClusterCellX;

	[Token(Token = "0x4001614")]
	[FieldOffset(Offset = "0xAC")]
	private int m_ClusterCellY;

	[Token(Token = "0x4001615")]
	[FieldOffset(Offset = "0xB0")]
	private bool m_IsClusterSet;

	[Token(Token = "0x4001616")]
	[FieldOffset(Offset = "0xB4")]
	private int m_IndexToRemove;

	[Token(Token = "0x4001617")]
	[FieldOffset(Offset = "0xB8")]
	private int m_LastClusterCellX;

	[Token(Token = "0x4001618")]
	[FieldOffset(Offset = "0xBC")]
	private int m_LastClusterCellY;

	[Token(Token = "0x4001619")]
	[FieldOffset(Offset = "0xC0")]
	private bool m_LastClusterSet;

	[Token(Token = "0x400161A")]
	[FieldOffset(Offset = "0xC1")]
	private bool m_CanDeleteAll;

	[Token(Token = "0x600152A")]
	[Address(RVA = "0x69A480", Offset = "0x699280", Length = "0x48")]
	public void SetCluster(ClusterCell clusterCell)
	{
	}

	[Token(Token = "0x600152B")]
	[Address(RVA = "0x69A4D0", Offset = "0x6992D0", Length = "0x8")]
	public void ResetLastCluster()
	{
	}

	[Token(Token = "0x600152C")]
	[Address(RVA = "0x69A4E0", Offset = "0x6992E0", Length = "0x2C")]
	public bool IsLastCluster(ClusterCell clusterCell)
	{
		return false;
	}

	[Token(Token = "0x600152D")]
	[Address(RVA = "0x69A510", Offset = "0x699310", Length = "0x2C")]
	public bool IsClusterSet(ClusterCell clusterCell)
	{
		return false;
	}

	[Token(Token = "0x600152E")]
	[Address(RVA = "0x69A540", Offset = "0x699340", Length = "0x45E")]
	public void UpdatePosition()
	{
	}

	[Token(Token = "0x600152F")]
	[Address(RVA = "0x69A9A0", Offset = "0x6997A0", Length = "0x1B7")]
	public void OnClickedDeleteAll()
	{
	}

	[Token(Token = "0x6001530")]
	[Address(RVA = "0x69AB60", Offset = "0x699960", Length = "0xA7")]
	protected override void Enable_Internal(bool isEnabled)
	{
	}

	[Token(Token = "0x6001531")]
	[Address(RVA = "0x69AC10", Offset = "0x699A10", Length = "0xB")]
	protected override void Awake_Internal()
	{
	}

	[Token(Token = "0x6001532")]
	[Address(RVA = "0x69AC20", Offset = "0x699A20", Length = "0xBF")]
	protected override void Update_Internal()
	{
	}

	[Token(Token = "0x6001533")]
	[Address(RVA = "0x69ACE0", Offset = "0x699AE0", Length = "0x9F")]
	protected override List<MapElementSaveData> GatherItems()
	{
		return null;
	}

	[Token(Token = "0x6001534")]
	[Address(RVA = "0x69AD80", Offset = "0x699B80", Length = "0x326")]
	protected override void ConfigureDisplay(MarkerListDisplayItem display, int index)
	{
	}

	[Token(Token = "0x6001535")]
	[Address(RVA = "0x69B0B0", Offset = "0x699EB0", Length = "0x14B")]
	protected override void SetSelected(MarkerListDisplayItem display, bool selected)
	{
	}

	[Token(Token = "0x6001536")]
	[Address(RVA = "0x69B200", Offset = "0x69A000", Length = "0x168")]
	protected override void ClearDisplay(MarkerListDisplayItem display)
	{
	}

	[Token(Token = "0x6001537")]
	[Address(RVA = "0x69B370", Offset = "0x69A170", Length = "0x26")]
	protected override void SetupDisplay(MarkerListDisplayItem display, MapElementSaveData item)
	{
	}

	[Token(Token = "0x6001538")]
	[Address(RVA = "0x69B3A0", Offset = "0x69A1A0", Length = "0x228")]
	protected override void OnDeleteItemRequested(int itemIndex)
	{
	}

	[Token(Token = "0x6001539")]
	[Address(RVA = "0x69B5D0", Offset = "0x69A3D0", Length = "0x15B")]
	private bool CanDeleteAll()
	{
		return false;
	}

	[Token(Token = "0x600153A")]
	[Address(RVA = "0x69B730", Offset = "0x69A530", Length = "0xF")]
	private void OnConfirmCanceled(bool hasCanceled)
	{
	}

	[Token(Token = "0x600153B")]
	[Address(RVA = "0x69B740", Offset = "0x69A540", Length = "0x29")]
	private void OnSprayPaintMarkerRemoveConfirm()
	{
	}

	[Token(Token = "0x600153C")]
	[Address(RVA = "0x69B770", Offset = "0x69A570", Length = "0xED")]
	private void OnDeleteAllMarkerRemoveConfirm()
	{
	}

	[Token(Token = "0x600153D")]
	[Address(RVA = "0x69B860", Offset = "0x69A660", Length = "0x16F")]
	private void DoDeleteItem(int index)
	{
	}

	[Token(Token = "0x600153E")]
	[Address(RVA = "0x69B9D0", Offset = "0x69A7D0", Length = "0xC9")]
	private void DeleteAllDeleteableItems()
	{
	}

	[Token(Token = "0x600153F")]
	[Address(RVA = "0x69BAA0", Offset = "0x69A8A0", Length = "0xA1")]
	private void Hide(bool isHidden)
	{
	}

	[Token(Token = "0x6001540")]
	[Address(RVA = "0x69BB50", Offset = "0x69A950", Length = "0xBB")]
	private void UpdateDeleteAllGroup()
	{
	}

	[Token(Token = "0x6001541")]
	[Address(RVA = "0x69BC10", Offset = "0x69AA10", Length = "0x379")]
	private void UpdateGamePad()
	{
	}

	[Token(Token = "0x6001542")]
	[Address(RVA = "0x69BF90", Offset = "0x69AD90", Length = "0x98")]
	private void OnDisplayClickedOpen(int index)
	{
	}

	[Token(Token = "0x6001543")]
	[Address(RVA = "0x69C030", Offset = "0x69AE30", Length = "0x96")]
	private void OpenRockCache(MapElementSaveData me)
	{
	}

	[Token(Token = "0x6001544")]
	[Address(RVA = "0x69C0D0", Offset = "0x69AED0", Length = "0x1BB")]
	public Panel_MarkerList()
	{
	}
}
