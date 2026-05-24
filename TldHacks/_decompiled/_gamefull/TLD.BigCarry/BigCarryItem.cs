using System;
using System.Collections.Generic;
using AK.Wwise;
using Cpp2ILInjected;
using TLD.Interactions;
using TLD.UI.Generics;
using UnityEngine;

namespace TLD.BigCarry;

[Token(Token = "0x20014CF")]
public abstract class BigCarryItem : BaseInteraction
{
	[Header("Carry Config")]
	[Token(Token = "0x4009668")]
	[FieldOffset(Offset = "0x40")]
	public AssetReferenceBigCarryItem m_AssetReference;

	[Token(Token = "0x4009669")]
	[FieldOffset(Offset = "0x48")]
	public AssetReferenceGearItem m_FPHDummyGearItem;

	[Token(Token = "0x400966A")]
	[FieldOffset(Offset = "0x50")]
	public float m_PlacementDistance;

	[Header("Drop Config")]
	[SerializeField]
	[Token(Token = "0x400966B")]
	[FieldOffset(Offset = "0x54")]
	protected float m_DropDistanceFudge;

	[Header("Panel References")]
	[SerializeField]
	[Token(Token = "0x400966C")]
	[FieldOffset(Offset = "0x58")]
	private PanelReference<Panel_ActionPicker> m_ActionPicker;

	[Token(Token = "0x400966F")]
	[FieldOffset(Offset = "0x6C")]
	protected Vector3 m_LastDroppedPosition;

	[Token(Token = "0x4009670")]
	[FieldOffset(Offset = "0x78")]
	protected Quaternion m_LastDroppedRotation;

	[Token(Token = "0x4009671")]
	[FieldOffset(Offset = "0x88")]
	protected List<ActionPickerItemData> m_ActionPickerData;

	[Token(Token = "0x4009672")]
	[FieldOffset(Offset = "0x90")]
	protected ActionPickerItemData m_CarryPickerData;

	[Token(Token = "0x17000B62")]
	[field: Token(Token = "0x400966D")]
	[field: FieldOffset(Offset = "0x60")]
	public string GUID
	{
		[Token(Token = "0x6008348")]
		[Address(RVA = "0x6E2FE0", Offset = "0x6E1DE0", Length = "0x5")]
		get;
		[Token(Token = "0x6008349")]
		[Address(RVA = "0x8F4D50", Offset = "0x8F3B50", Length = "0x52")]
		private set;
	}

	[Token(Token = "0x17000B63")]
	[field: Token(Token = "0x400966E")]
	[field: FieldOffset(Offset = "0x68")]
	public bool IsCarried
	{
		[Token(Token = "0x600834A")]
		[Address(RVA = "0x4C3B90", Offset = "0x4C2990", Length = "0x5")]
		protected get;
		[Token(Token = "0x600834B")]
		[Address(RVA = "0x91DC40", Offset = "0x91CA40", Length = "0x4")]
		set;
	}

	[Token(Token = "0x17000B64")]
	public virtual bool CanCarryWhileCrouched
	{
		[Token(Token = "0x600834C")]
		[Address(RVA = "0x4A2140", Offset = "0x4A0F40", Length = "0x3")]
		get
		{
			return false;
		}
	}

	[Token(Token = "0x17000B65")]
	public virtual bool AlwaysSkipDropAnimation
	{
		[Token(Token = "0x600834D")]
		[Address(RVA = "0x4A2140", Offset = "0x4A0F40", Length = "0x3")]
		get
		{
			return false;
		}
	}

	[Token(Token = "0x17000B66")]
	public virtual int IdleAnimationStateHash
	{
		[Token(Token = "0x600834E")]
		[Address(RVA = "0xC7D4F0", Offset = "0xC7C2F0", Length = "0x6")]
		get
		{
			return 0;
		}
	}

	[Token(Token = "0x600834F")]
	[Address(RVA = "0x12468A0", Offset = "0x12456A0", Length = "0xE0")]
	protected void Awake()
	{
	}

	[Token(Token = "0x6008350")]
	[Address(RVA = "0x1246990", Offset = "0x1245790", Length = "0x11")]
	public virtual void Initialize()
	{
	}

	[Token(Token = "0x6008351")]
	[Address(RVA = "0x12469B0", Offset = "0x12457B0", Length = "0x1D6")]
	public void SetGUID(string guid)
	{
	}

	[Token(Token = "0x6008352")]
	[Address(RVA = "0x1246B90", Offset = "0x1245990", Length = "0x10A")]
	public void SetPositionAndRotation(Vector3 position, Quaternion rotation)
	{
	}

	[Token(Token = "0x6008353")]
	[Address(RVA = "0x1246CA0", Offset = "0x1245AA0", Length = "0x166")]
	protected virtual void OnDestroy()
	{
	}

	[Token(Token = "0x6008354")]
	[Address(RVA = "0x1246E10", Offset = "0x1245C10", Length = "0x211")]
	public virtual bool DropItemOnGround(Vector3 desiredPosition)
	{
		return false;
	}

	[Token(Token = "0x6008355")]
	[Address(RVA = "0x1247030", Offset = "0x1245E30", Length = "0x836")]
	public virtual BigCarryItemSaveData Serialize()
	{
		return null;
	}

	[Token(Token = "0x6008356")]
	[Address(RVA = "0x1247870", Offset = "0x1246670", Length = "0xA1")]
	public virtual void Deserialize(BigCarryItemSaveData data, bool isCarried)
	{
	}

	[Token(Token = "0x6008357")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public virtual void DeserializePostSceneLoad()
	{
	}

	[Token(Token = "0x6008358")]
	[Address(RVA = "0x430B50", Offset = "0x42F950", Length = "0x3")]
	public virtual bool CanPerformInteractionWhileCarrying(IInteraction interaction)
	{
		return false;
	}

	[Token(Token = "0x6008359")]
	public abstract void PlayHoistAudio(bool pickingUp);

	[Token(Token = "0x600835A")]
	public abstract AK.Wwise.Event GetBreathAudioEvent();

	[Token(Token = "0x600835B")]
	public abstract void OnPrepareForCarry(bool restoringCarry, Action onDonePreparing);

	[Token(Token = "0x600835C")]
	public abstract void OnCarried(bool restoringCarry);

	[Token(Token = "0x600835D")]
	public abstract void OnRestored(bool replacedOriginal);

	[Token(Token = "0x600835E")]
	public abstract void OnPrepareForDrop();

	[Token(Token = "0x600835F")]
	public abstract void OnDropped();

	[Token(Token = "0x6008360")]
	public abstract void OnBeginPlacement();

	[Token(Token = "0x6008361")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public virtual void UpdateItem()
	{
	}

	[Token(Token = "0x6008362")]
	[Address(RVA = "0x4A2290", Offset = "0x4A1090", Length = "0x9")]
	public virtual float GetMovementSpeedModifier(bool isSprinting)
	{
		return 0f;
	}

	[Token(Token = "0x6008363")]
	[Address(RVA = "0x4A2290", Offset = "0x4A1090", Length = "0x9")]
	public virtual float GetTurnSpeedModifier()
	{
		return 0f;
	}

	[Token(Token = "0x6008364")]
	[Address(RVA = "0x1247920", Offset = "0x1246720", Length = "0x124")]
	protected virtual void InitializeActionPickerItems()
	{
	}

	[Token(Token = "0x6008365")]
	[Address(RVA = "0x1247A50", Offset = "0x1246850", Length = "0x7E")]
	public override void InitializeInteraction()
	{
	}

	[Token(Token = "0x6008366")]
	[Address(RVA = "0x87E130", Offset = "0x87CF30", Length = "0x5D")]
	public virtual string GetHoverText()
	{
		return null;
	}

	[Token(Token = "0x6008367")]
	[Address(RVA = "0x1247AD0", Offset = "0x12468D0", Length = "0x1C1")]
	public override bool PerformInteraction()
	{
		return false;
	}

	[Token(Token = "0x6008368")]
	[Address(RVA = "0x1247CA0", Offset = "0x1246AA0", Length = "0xAA")]
	protected virtual bool CanInteractWithItem()
	{
		return false;
	}

	[Token(Token = "0x6008369")]
	protected abstract void BuildActionPickerData();

	[Token(Token = "0x600836A")]
	[Address(RVA = "0x1247D50", Offset = "0x1246B50", Length = "0xCE")]
	private void CarryCallback()
	{
	}

	[Token(Token = "0x600836B")]
	[Address(RVA = "0x1247E20", Offset = "0x1246C20", Length = "0xC7")]
	protected BigCarryItem()
	{
	}
}
