using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using TLD.BigCarry;
using TLD.Interactions;
using UnityEngine;

[Token(Token = "0x200085F")]
public class NPC : MonoBehaviour
{
	[Token(Token = "0x2000860")]
	public class NPCSavedData
	{
		[Token(Token = "0x40056ED")]
		[FieldOffset(Offset = "0x10")]
		public string m_AfflictionsSerialized;

		[Token(Token = "0x40056EE")]
		[FieldOffset(Offset = "0x18")]
		public string m_ConditionSerialized;

		[Token(Token = "0x40056EF")]
		[FieldOffset(Offset = "0x20")]
		public string m_FreezingSerialized;

		[Token(Token = "0x40056F0")]
		[FieldOffset(Offset = "0x28")]
		public string m_ThirstSerialized;

		[Token(Token = "0x40056F1")]
		[FieldOffset(Offset = "0x30")]
		public bool m_EnableConditionUpdate;

		[Token(Token = "0x40056F2")]
		[FieldOffset(Offset = "0x38")]
		public string m_Guid;

		[Token(Token = "0x40056F3")]
		[FieldOffset(Offset = "0x40")]
		public float m_LastUpdatedTODHours;

		[Token(Token = "0x40056F4")]
		[FieldOffset(Offset = "0x44")]
		public float m_NextAmbientAudioTime;

		[Token(Token = "0x40056F5")]
		[FieldOffset(Offset = "0x48")]
		public bool m_HasBeenInteractedWith;

		[Token(Token = "0x6004D1A")]
		[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
		public NPCSavedData()
		{
		}
	}

	[Token(Token = "0x2000861")]
	public class NPCGlobalSaveData
	{
		[Token(Token = "0x40056F6")]
		[FieldOffset(Offset = "0x10")]
		public string m_ActiveGuid;

		[Token(Token = "0x6004D1B")]
		[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
		public NPCGlobalSaveData()
		{
		}
	}

	[Flags]
	[Token(Token = "0x2000862")]
	private enum UpdateFlags
	{
		[Token(Token = "0x40056F8")]
		None = 0,
		[Token(Token = "0x40056F9")]
		UpdateCondition = 1,
		[Token(Token = "0x40056FA")]
		CinematicActive = 2
	}

	[Flags]
	[Token(Token = "0x2000863")]
	public enum FindFlags
	{
		[Token(Token = "0x40056FC")]
		None = 0,
		[Token(Token = "0x40056FD")]
		InteractedWith = 1,
		[Token(Token = "0x40056FE")]
		ConditionUpdating = 2
	}

	[Token(Token = "0x40056D6")]
	public static bool s_DisableConditionUpdates;

	[Token(Token = "0x40056D7")]
	public static bool s_Invulnerable;

	[Token(Token = "0x40056D8")]
	[FieldOffset(Offset = "0x20")]
	public LocalizedString m_DisplayName;

	[Token(Token = "0x40056D9")]
	[FieldOffset(Offset = "0x28")]
	public bool m_EnableConditionUpdate;

	[Header("Audio")]
	[Token(Token = "0x40056DA")]
	[FieldOffset(Offset = "0x2C")]
	public float m_AmbientAudioTimeVariance;

	[Token(Token = "0x40056DB")]
	[FieldOffset(Offset = "0x30")]
	public float m_MinTimeBetweenAmbientAudio;

	[Token(Token = "0x40056DC")]
	[FieldOffset(Offset = "0x38")]
	public string m_AmbientAudioEvent;

	[Token(Token = "0x40056DD")]
	[FieldOffset(Offset = "0x40")]
	public float m_MinTimeBetweenCarryAmbientAudio;

	[Token(Token = "0x40056DE")]
	[FieldOffset(Offset = "0x48")]
	public string m_CarryAmbientAudioEvent;

	[NonSerialized]
	[Token(Token = "0x40056DF")]
	[FieldOffset(Offset = "0x50")]
	public NPCAfflictions m_AfflictionsComponent;

	[NonSerialized]
	[Token(Token = "0x40056E0")]
	[FieldOffset(Offset = "0x58")]
	public NPCCondition m_Condition;

	[NonSerialized]
	[Token(Token = "0x40056E1")]
	[FieldOffset(Offset = "0x60")]
	public NPCFreezing m_Freezing;

	[NonSerialized]
	[Token(Token = "0x40056E2")]
	[FieldOffset(Offset = "0x68")]
	public NPCThirst m_Thirst;

	[NonSerialized]
	[Token(Token = "0x40056E3")]
	[FieldOffset(Offset = "0x70")]
	public NPCVoice m_Voice;

	[NonSerialized]
	[Token(Token = "0x40056E4")]
	[FieldOffset(Offset = "0x78")]
	public BodyBigCarryItem m_BodyBigCarryItem;

	[NonSerialized]
	[Token(Token = "0x40056E5")]
	[FieldOffset(Offset = "0x80")]
	public string m_Guid;

	[NonSerialized]
	[Token(Token = "0x40056E6")]
	[FieldOffset(Offset = "0x88")]
	public IndoorSpaceTrigger m_IndoorSpaceTrigger;

	[Token(Token = "0x40056E7")]
	[FieldOffset(Offset = "0x90")]
	private bool m_Initialized;

	[Token(Token = "0x40056E8")]
	[FieldOffset(Offset = "0x94")]
	private float m_LastUpdatedTODHours;

	[Token(Token = "0x40056E9")]
	[FieldOffset(Offset = "0x98")]
	private float m_NextAmbientAudioTime;

	[Token(Token = "0x40056EA")]
	[FieldOffset(Offset = "0x9C")]
	private bool m_HasBeenInteractedWith;

	[Token(Token = "0x40056EB")]
	private static List<NPC> s_NPCList;

	[Token(Token = "0x40056EC")]
	private static string s_ActiveGuid;

	[Token(Token = "0x6004CF4")]
	[Address(RVA = "0xD7F8F0", Offset = "0xD7E6F0", Length = "0xA7")]
	public void HandlePickUp()
	{
	}

	[Token(Token = "0x6004CF5")]
	[Address(RVA = "0xD7F9A0", Offset = "0xD7E7A0", Length = "0xEB")]
	public bool IsAlive()
	{
		return false;
	}

	[Token(Token = "0x6004CF6")]
	[Address(RVA = "0xD7FA90", Offset = "0xD7E890", Length = "0x20E")]
	public bool IsBeingCarried()
	{
		return false;
	}

	[Token(Token = "0x6004CF7")]
	[Address(RVA = "0xB97C80", Offset = "0xB96A80", Length = "0x5")]
	public bool IsConditionUpdateEnabled()
	{
		return false;
	}

	[Token(Token = "0x6004CF8")]
	[Address(RVA = "0xD7FCA0", Offset = "0xD7EAA0", Length = "0x146")]
	public bool IsIndoors()
	{
		return false;
	}

	[Token(Token = "0x6004CF9")]
	[Address(RVA = "0xD7FDF0", Offset = "0xD7EBF0", Length = "0xF")]
	public void SetConditionUpdateEnabled(bool enabled)
	{
	}

	[Token(Token = "0x6004CFA")]
	[Address(RVA = "0xD7FE00", Offset = "0xD7EC00", Length = "0x7")]
	public void SetHasBeenInteractedWith(bool flag)
	{
	}

	[Token(Token = "0x6004CFB")]
	[Address(RVA = "0xD7FE10", Offset = "0xD7EC10", Length = "0xE6")]
	public void PerformInteraction()
	{
	}

	[Token(Token = "0x6004CFC")]
	[Address(RVA = "0xD7FF00", Offset = "0xD7ED00", Length = "0x6C")]
	public void UpdateInteraction(BaseInteraction baseInteraction)
	{
	}

	[Token(Token = "0x6004CFD")]
	[Address(RVA = "0xD7FF70", Offset = "0xD7ED70", Length = "0x1F9")]
	public string GetHoverText()
	{
		return null;
	}

	[Token(Token = "0x6004CFE")]
	[Address(RVA = "0xD80170", Offset = "0xD7EF70", Length = "0x6DD")]
	public NPCSavedData Serialize()
	{
		return null;
	}

	[Token(Token = "0x6004CFF")]
	[Address(RVA = "0xD80850", Offset = "0xD7F650", Length = "0x50C")]
	public void Deserialize(NPCSavedData savedData)
	{
	}

	[Token(Token = "0x6004D00")]
	[Address(RVA = "0xD80D60", Offset = "0xD7FB60", Length = "0x95")]
	public void ResetNextAmbientAudioTimer()
	{
	}

	[Token(Token = "0x6004D01")]
	[Address(RVA = "0xD80E00", Offset = "0xD7FC00", Length = "0x7")]
	private void Awake()
	{
	}

	[Token(Token = "0x6004D02")]
	[Address(RVA = "0xD80E10", Offset = "0xD7FC10", Length = "0x63E")]
	private void DoConditionUpdate()
	{
	}

	[Token(Token = "0x6004D03")]
	[Address(RVA = "0xD81450", Offset = "0xD80250", Length = "0x27F")]
	private void DoUpdate(UpdateFlags flags)
	{
	}

	[Token(Token = "0x6004D04")]
	[Address(RVA = "0xD816D0", Offset = "0xD804D0", Length = "0x933")]
	private void Initialize()
	{
	}

	[Token(Token = "0x6004D05")]
	[Address(RVA = "0xD82010", Offset = "0xD80E10", Length = "0x83")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6004D06")]
	[Address(RVA = "0xD820A0", Offset = "0xD80EA0", Length = "0x18D")]
	private void UpdateAmbientVoiceOver()
	{
	}

	[Token(Token = "0x6004D07")]
	[Address(RVA = "0xD82230", Offset = "0xD81030", Length = "0x78")]
	private void UpdateTODHours()
	{
	}

	[Token(Token = "0x6004D08")]
	[Address(RVA = "0xD822B0", Offset = "0xD810B0", Length = "0xB6")]
	public static void ClearActive()
	{
	}

	[Token(Token = "0x6004D09")]
	[Address(RVA = "0xD82370", Offset = "0xD81170", Length = "0x1E1")]
	public static NPC GetFromGuid(string guid)
	{
		return null;
	}

	[Token(Token = "0x6004D0A")]
	[Address(RVA = "0xD82560", Offset = "0xD81360", Length = "0x81")]
	public static NPC GetActive()
	{
		return null;
	}

	[Token(Token = "0x6004D0B")]
	[Address(RVA = "0xD825F0", Offset = "0xD813F0", Length = "0x68")]
	public static bool HasActive()
	{
		return false;
	}

	[Token(Token = "0x6004D0C")]
	[Address(RVA = "0xD82660", Offset = "0xD81460", Length = "0xC5")]
	public static bool IsActive(string guid)
	{
		return false;
	}

	[Token(Token = "0x6004D0D")]
	[Address(RVA = "0xD82730", Offset = "0xD81530", Length = "0x19A")]
	public static void SetActive(NPC npc)
	{
	}

	[Token(Token = "0x6004D0E")]
	[Address(RVA = "0xD828D0", Offset = "0xD816D0", Length = "0x54")]
	public static IEnumerable<NPC> GetAll()
	{
		return null;
	}

	[Token(Token = "0x6004D0F")]
	[Address(RVA = "0xD82930", Offset = "0xD81730", Length = "0x1B4")]
	public static void DeserializeGlobal(string serialized)
	{
	}

	[Token(Token = "0x6004D10")]
	[Address(RVA = "0xD82AF0", Offset = "0xD818F0", Length = "0x16B")]
	public static string SerializeGlobal()
	{
		return null;
	}

	[Token(Token = "0x6004D11")]
	[Address(RVA = "0xD82C60", Offset = "0xD81A60", Length = "0x22D")]
	public static string SerializeAll()
	{
		return null;
	}

	[Token(Token = "0x6004D12")]
	[Address(RVA = "0xD82E90", Offset = "0xD81C90", Length = "0x360")]
	public static void DeserializeAll(string text)
	{
	}

	[Token(Token = "0x6004D13")]
	[Address(RVA = "0xD83200", Offset = "0xD82000", Length = "0x259")]
	public static void FindAll()
	{
	}

	[Token(Token = "0x6004D14")]
	[Address(RVA = "0xD83460", Offset = "0xD82260", Length = "0x94")]
	public static void Reset()
	{
	}

	[Token(Token = "0x6004D15")]
	[Address(RVA = "0xD83500", Offset = "0xD82300", Length = "0x2E8")]
	public static void UpdateAll()
	{
	}

	[Token(Token = "0x6004D16")]
	[Address(RVA = "0xD837F0", Offset = "0xD825F0", Length = "0x117")]
	private static NPC FindNPCByGuid(string guid)
	{
		return null;
	}

	[Token(Token = "0x6004D17")]
	[Address(RVA = "0xD83910", Offset = "0xD82710", Length = "0x290")]
	public static NPC FindNearest(Vector3 position, float maxDistance, FindFlags flags)
	{
		return null;
	}

	[Token(Token = "0x6004D18")]
	[Address(RVA = "0x4AF5E0", Offset = "0x4AE3E0", Length = "0x43")]
	public NPC()
	{
	}
}
