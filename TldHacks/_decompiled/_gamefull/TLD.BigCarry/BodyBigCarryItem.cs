using System;
using AK.Wwise;
using Cpp2ILInjected;
using UnityEngine;

namespace TLD.BigCarry;

[Token(Token = "0x20014D8")]
public class BodyBigCarryItem : BigCarryItem
{
	[Serializable]
	[Token(Token = "0x20014D9")]
	private struct IntensityAudio
	{
		[Token(Token = "0x40096B1")]
		[FieldOffset(Offset = "0x0")]
		public AK.Wwise.Event m_Pickup;

		[Token(Token = "0x40096B2")]
		[FieldOffset(Offset = "0x8")]
		public AK.Wwise.Event m_Putdown;

		[Token(Token = "0x40096B3")]
		[FieldOffset(Offset = "0x10")]
		public AK.Wwise.Event m_Breath;
	}

	[Token(Token = "0x20014DA")]
	private enum BodyPickupIntensity
	{
		[Token(Token = "0x40096B5")]
		Low,
		[Token(Token = "0x40096B6")]
		Medium,
		[Token(Token = "0x40096B7")]
		High
	}

	[Token(Token = "0x20014DB")]
	private class BodyBigCarryItemSaveData
	{
		[Token(Token = "0x40096B8")]
		[FieldOffset(Offset = "0x10")]
		public bool m_HasBeenDropped;

		[Token(Token = "0x60083B6")]
		[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
		public BodyBigCarryItemSaveData()
		{
		}
	}

	[Header("Body Settings")]
	[SerializeField]
	[Token(Token = "0x40096A0")]
	[FieldOffset(Offset = "0x98")]
	private ShowOnMapItem m_ShowItemOnMap;

	[Header("Body Audio")]
	[SerializeField]
	[Token(Token = "0x40096A1")]
	[FieldOffset(Offset = "0xA0")]
	private IntensityAudio m_LowIntensityAudio;

	[SerializeField]
	[Token(Token = "0x40096A2")]
	[FieldOffset(Offset = "0xB8")]
	private IntensityAudio m_MediumIntensityAudio;

	[SerializeField]
	[Token(Token = "0x40096A3")]
	[FieldOffset(Offset = "0xD0")]
	private IntensityAudio m_HighIntensityAudio;

	[Header("Body Animations")]
	[SerializeField]
	[Token(Token = "0x40096A4")]
	[FieldOffset(Offset = "0xE8")]
	private AnimationStateRef m_DropAnimation;

	[SerializeField]
	[Token(Token = "0x40096A5")]
	[FieldOffset(Offset = "0xF0")]
	private AnimationStateRef m_DroppedIdleAnimation;

	[SerializeField]
	[Token(Token = "0x40096A6")]
	[FieldOffset(Offset = "0xF8")]
	private AnimationStateRef m_PlacementMeshIdleAnimation;

	[Token(Token = "0x40096A7")]
	[FieldOffset(Offset = "0x100")]
	private readonly int m_IdleAnimationStateHash;

	[Token(Token = "0x40096AB")]
	[FieldOffset(Offset = "0x118")]
	private bool m_HasBeenDropped;

	[Token(Token = "0x40096AC")]
	[FieldOffset(Offset = "0x120")]
	private Animator m_Animator;

	[Token(Token = "0x40096AD")]
	[FieldOffset(Offset = "0x128")]
	private Container m_Container;

	[Token(Token = "0x40096AE")]
	[FieldOffset(Offset = "0x130")]
	private ActionPickerItemData m_DiagnosePickerData;

	[Token(Token = "0x40096AF")]
	[FieldOffset(Offset = "0x138")]
	private ActionPickerItemData m_SearchPickerData;

	[Token(Token = "0x40096B0")]
	private static BodyBigCarryItemSaveData m_BodyBigCarryItemSaveData;

	[Token(Token = "0x17000B6B")]
	public override int IdleAnimationStateHash
	{
		[Token(Token = "0x6008398")]
		[Address(RVA = "0xA0A700", Offset = "0xA09500", Length = "0x7")]
		get
		{
			return 0;
		}
	}

	[Token(Token = "0x17000B6C")]
	[field: Token(Token = "0x40096A8")]
	[field: FieldOffset(Offset = "0x104")]
	public bool ReplacedOriginal
	{
		[Token(Token = "0x6008399")]
		[Address(RVA = "0x908950", Offset = "0x907750", Length = "0x8")]
		get;
		[Token(Token = "0x600839A")]
		[Address(RVA = "0x908960", Offset = "0x907760", Length = "0x7")]
		private set;
	}

	[Token(Token = "0x17000B6D")]
	[field: Token(Token = "0x40096A9")]
	[field: FieldOffset(Offset = "0x108")]
	public Bed Bed
	{
		[Token(Token = "0x600839B")]
		[Address(RVA = "0x814FC0", Offset = "0x813DC0", Length = "0x8")]
		get;
		[Token(Token = "0x600839C")]
		[Address(RVA = "0x97CFA0", Offset = "0x97BDA0", Length = "0x52")]
		private set;
	}

	[Token(Token = "0x17000B6E")]
	[field: Token(Token = "0x40096AA")]
	[field: FieldOffset(Offset = "0x110")]
	public NPC NPC
	{
		[Token(Token = "0x600839D")]
		[Address(RVA = "0x677F90", Offset = "0x676D90", Length = "0x8")]
		get;
		[Token(Token = "0x600839E")]
		[Address(RVA = "0x677FA0", Offset = "0x676DA0", Length = "0x52")]
		private set;
	}

	[Token(Token = "0x600839F")]
	[Address(RVA = "0x124CE60", Offset = "0x124BC60", Length = "0x199")]
	public override void Initialize()
	{
	}

	[Token(Token = "0x60083A0")]
	[Address(RVA = "0x124D000", Offset = "0x124BE00", Length = "0x114")]
	public override BigCarryItemSaveData Serialize()
	{
		return null;
	}

	[Token(Token = "0x60083A1")]
	[Address(RVA = "0x124D120", Offset = "0x124BF20", Length = "0x219")]
	public override void Deserialize(BigCarryItemSaveData data, bool isCarried)
	{
	}

	[Token(Token = "0x60083A2")]
	[Address(RVA = "0x124D340", Offset = "0x124C140", Length = "0x104")]
	public override void PlayHoistAudio(bool pickingUp)
	{
	}

	[Token(Token = "0x60083A3")]
	[Address(RVA = "0x124D450", Offset = "0x124C250", Length = "0x37")]
	private AK.Wwise.Event GetHoistAudio(bool pickingUp, BodyPickupIntensity intensity)
	{
		return null;
	}

	[Token(Token = "0x60083A4")]
	[Address(RVA = "0x124D490", Offset = "0x124C290", Length = "0x8E")]
	public override AK.Wwise.Event GetBreathAudioEvent()
	{
		return null;
	}

	[Token(Token = "0x60083A5")]
	[Address(RVA = "0x124D520", Offset = "0x124C320", Length = "0xA4")]
	private IntensityAudio GetIntensityAudio()
	{
		return default(IntensityAudio);
	}

	[Token(Token = "0x60083A6")]
	[Address(RVA = "0x124D5D0", Offset = "0x124C3D0", Length = "0x12")]
	public override void OnPrepareForCarry(bool restoringCarry, Action onDonePreparing)
	{
	}

	[Token(Token = "0x60083A7")]
	[Address(RVA = "0x124D5F0", Offset = "0x124C3F0", Length = "0x320")]
	public override void OnCarried(bool restoringCarry)
	{
	}

	[Token(Token = "0x60083A8")]
	[Address(RVA = "0x908960", Offset = "0x907760", Length = "0x7")]
	public override void OnRestored(bool replacedOriginal)
	{
	}

	[Token(Token = "0x60083A9")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public override void OnPrepareForDrop()
	{
	}

	[Token(Token = "0x60083AA")]
	[Address(RVA = "0x124D920", Offset = "0x124C720", Length = "0x24C")]
	public override void OnDropped()
	{
	}

	[Token(Token = "0x60083AB")]
	[Address(RVA = "0x124DB70", Offset = "0x124C970", Length = "0x66")]
	public override void OnBeginPlacement()
	{
	}

	[Token(Token = "0x60083AC")]
	[Address(RVA = "0x124DBE0", Offset = "0x124C9E0", Length = "0x13B")]
	public override string GetHoverText()
	{
		return null;
	}

	[Token(Token = "0x60083AD")]
	[Address(RVA = "0x124DD20", Offset = "0x124CB20", Length = "0x227")]
	protected override bool CanInteractWithItem()
	{
		return false;
	}

	[Token(Token = "0x60083AE")]
	[Address(RVA = "0x124DF50", Offset = "0x124CD50", Length = "0x33E")]
	protected override void InitializeActionPickerItems()
	{
	}

	[Token(Token = "0x60083AF")]
	[Address(RVA = "0x124E290", Offset = "0x124D090", Length = "0x363")]
	protected override void BuildActionPickerData()
	{
	}

	[Token(Token = "0x60083B0")]
	[Address(RVA = "0x124E600", Offset = "0x124D400", Length = "0x6C")]
	private void DiagnoseCallback()
	{
	}

	[Token(Token = "0x60083B1")]
	[Address(RVA = "0x124E670", Offset = "0x124D470", Length = "0x66")]
	private void SearchCallback()
	{
	}

	[Token(Token = "0x60083B2")]
	[Address(RVA = "0x97CFA0", Offset = "0x97BDA0", Length = "0x52")]
	public void OnPlacedInBed(Bed bed)
	{
	}

	[Token(Token = "0x60083B3")]
	[Address(RVA = "0x124E6E0", Offset = "0x124D4E0", Length = "0x52")]
	public void OnRemovedFromBed(Bed bed)
	{
	}

	[Token(Token = "0x60083B4")]
	[Address(RVA = "0x124E740", Offset = "0x124D540", Length = "0x4D")]
	public BodyBigCarryItem()
	{
	}
}
