using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x20007AF")]
public class PlayerManagerSaveDataProxy
{
	[Token(Token = "0x40052B7")]
	[FieldOffset(Offset = "0x10")]
	public Vector3 m_SaveGamePosition;

	[Token(Token = "0x40052B8")]
	[FieldOffset(Offset = "0x1C")]
	public Quaternion m_SaveGameRotation;

	[Token(Token = "0x40052B9")]
	[FieldOffset(Offset = "0x2C")]
	public bool m_StartGearAppliedProxy;

	[Token(Token = "0x40052BA")]
	[FieldOffset(Offset = "0x30")]
	public int m_ItemInHandsInstanceID;

	[Token(Token = "0x40052BB")]
	[FieldOffset(Offset = "0x34")]
	public int m_LastUnequippedItemInstanceID;

	[Token(Token = "0x40052BC")]
	[FieldOffset(Offset = "0x38")]
	public bool m_InRunMode;

	[Token(Token = "0x40052BD")]
	[FieldOffset(Offset = "0x39")]
	public bool m_Ghost;

	[Token(Token = "0x40052BE")]
	[FieldOffset(Offset = "0x3A")]
	public bool m_God;

	[Token(Token = "0x40052BF")]
	[FieldOffset(Offset = "0x3B")]
	public bool m_CheatsUsed;

	[Token(Token = "0x40052C0")]
	[FieldOffset(Offset = "0x3C")]
	public VoicePersona m_VoicePersona;

	[Token(Token = "0x40052C1")]
	[FieldOffset(Offset = "0x40")]
	public float m_FreezingRateScale;

	[Token(Token = "0x40052C2")]
	[FieldOffset(Offset = "0x44")]
	public float m_FatigueRateScale;

	[Token(Token = "0x40052C3")]
	[FieldOffset(Offset = "0x48")]
	public float m_ConditonPercentBonus;

	[Token(Token = "0x40052C4")]
	[FieldOffset(Offset = "0x4C")]
	public float m_FatigueBuffHoursRemaining;

	[Token(Token = "0x40052C5")]
	[FieldOffset(Offset = "0x50")]
	public float m_FatigueBuffHoursDuration;

	[Token(Token = "0x40052C6")]
	[FieldOffset(Offset = "0x54")]
	public float m_FreezingBuffHoursRemaining;

	[Token(Token = "0x40052C7")]
	[FieldOffset(Offset = "0x58")]
	public float m_FreezingBuffHoursDuration;

	[Token(Token = "0x40052C8")]
	[FieldOffset(Offset = "0x5C")]
	public float m_ConditionRestBuffHoursRemaining;

	[Token(Token = "0x40052C9")]
	[FieldOffset(Offset = "0x60")]
	public float m_ConditionRestBuffHoursDuration;

	[Token(Token = "0x40052CA")]
	[FieldOffset(Offset = "0x68")]
	public string m_ConditionRestBuffCauseLocID;

	[Obsolete("Only retained for serialization compatibility")]
	[Token(Token = "0x40052CB")]
	[FieldOffset(Offset = "0x70")]
	public string m_StartingRegionName;

	[Token(Token = "0x40052CC")]
	[FieldOffset(Offset = "0x78")]
	public int m_SelectedBlueprintItemIndexWorkbench;

	[Token(Token = "0x40052CD")]
	[FieldOffset(Offset = "0x7C")]
	public int m_SelectedBlueprintItemIndexForge;

	[Token(Token = "0x40052CE")]
	[FieldOffset(Offset = "0x80")]
	public bool m_PlayerInVehicle;

	[Token(Token = "0x40052CF")]
	[FieldOffset(Offset = "0x84")]
	public Vector3 m_PlayerInVehicleCameraPos;

	[Token(Token = "0x40052D0")]
	[FieldOffset(Offset = "0x90")]
	public bool m_PlayerInSnowShelter;

	[Token(Token = "0x40052D1")]
	[FieldOffset(Offset = "0x94")]
	public float m_PumpkinPieBuffHoursRemaining;

	[Token(Token = "0x40052D2")]
	[FieldOffset(Offset = "0x98")]
	public float m_PumpkinPieBuffHoursDuration;

	[Token(Token = "0x40052D3")]
	[FieldOffset(Offset = "0x9C")]
	public float m_PumpkinPieFreezingRateScale;

	[Token(Token = "0x40052D4")]
	[FieldOffset(Offset = "0xA0")]
	public List<int> m_KnownCodes;

	[Token(Token = "0x40052D5")]
	[FieldOffset(Offset = "0xA8")]
	public SerializableBounds m_LimitCampfiresToBounds;

	[Token(Token = "0x40052D6")]
	[FieldOffset(Offset = "0xB0")]
	public bool m_StatusBarsLocked;

	[Token(Token = "0x40052D7")]
	[FieldOffset(Offset = "0xB4")]
	public float m_ConditionPerHourBonus;

	[Token(Token = "0x40052D8")]
	[FieldOffset(Offset = "0xB8")]
	public float m_ConditionPerHourHoursRemaining;

	[Token(Token = "0x40052D9")]
	[FieldOffset(Offset = "0xBC")]
	public float m_ConditionPerHourHoursDuration;

	[Token(Token = "0x40052DA")]
	[FieldOffset(Offset = "0xC0")]
	public string m_FatigueBuffCauseLocID;

	[Token(Token = "0x40052DB")]
	[FieldOffset(Offset = "0xC8")]
	public bool m_ForceAIFlee;

	[Token(Token = "0x40052DC")]
	[FieldOffset(Offset = "0xC9")]
	public bool m_SuspendConditionUpdate;

	[Token(Token = "0x40052DD")]
	[FieldOffset(Offset = "0xCA")]
	public bool m_ForceHideDiscoveryText;

	[Token(Token = "0x40052DE")]
	[FieldOffset(Offset = "0xCB")]
	public bool m_DisableAllSpeech;

	[Token(Token = "0x40052DF")]
	[FieldOffset(Offset = "0xCC")]
	public bool m_HasSavedItemInHands;

	[Token(Token = "0x40052E0")]
	[FieldOffset(Offset = "0xCD")]
	public bool m_RestoreSavedItemInHandsPending;

	[Token(Token = "0x40052E1")]
	[FieldOffset(Offset = "0xCE")]
	public bool m_HasEverSprayPainted;

	[Token(Token = "0x40052E2")]
	[FieldOffset(Offset = "0xD0")]
	public List<PlayerManager.IngestedCarryCapacityBuff> m_IngestedCarryCapacityBuffs;

	[Token(Token = "0x600492F")]
	[Address(RVA = "0xD16120", Offset = "0xD14F20", Length = "0x159")]
	public PlayerManagerSaveDataProxy()
	{
	}
}
