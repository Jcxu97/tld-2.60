using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using MissionTypes;
using NodeCanvas.Framework;
using NodeCanvas.StateMachines;
using ParadoxNotion;
using ParadoxNotion.Services;
using TLD.UI.Generics;
using UnityEngine;

[Token(Token = "0x200082F")]
public abstract class MissionServicesManager : MonoBehaviour
{
	[CompilerGenerated]
	[Token(Token = "0x2000830")]
	private sealed class _003CJumpCo_003Ed__129 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40055F3")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x40055F4")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x40055F5")]
		[FieldOffset(Offset = "0x20")]
		public MissionServicesManager _003C_003E4__this;

		[Token(Token = "0x40055F6")]
		[FieldOffset(Offset = "0x28")]
		public bool isDeserialize;

		[Token(Token = "0x40055F7")]
		[FieldOffset(Offset = "0x29")]
		public bool isDebug;

		[Token(Token = "0x40055F8")]
		[FieldOffset(Offset = "0x30")]
		public string missionName;

		[Token(Token = "0x40055F9")]
		[FieldOffset(Offset = "0x38")]
		private MissionManagerBase _003Cmm_003E5__2;

		[Token(Token = "0x40055FA")]
		[FieldOffset(Offset = "0x40")]
		private int _003Ci_003E5__3;

		[Token(Token = "0x1700034D")]
		object IEnumerator<object>.Current
		{
			[DebuggerHidden]
			[Token(Token = "0x6004C4C")]
			[Address(RVA = "0x4571D0", Offset = "0x455FD0", Length = "0x5")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700034E")]
		object IEnumerator.Current
		{
			[DebuggerHidden]
			[Token(Token = "0x6004C4E")]
			[Address(RVA = "0x4571D0", Offset = "0x455FD0", Length = "0x5")]
			get
			{
				return null;
			}
		}

		[DebuggerHidden]
		[Token(Token = "0x6004C49")]
		[Address(RVA = "0x4096E0", Offset = "0x4084E0", Length = "0x4")]
		public _003CJumpCo_003Ed__129(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		[Token(Token = "0x6004C4A")]
		[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
		void IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6004C4B")]
		[Address(RVA = "0xD6D520", Offset = "0xD6C320", Length = "0x6BA")]
		private bool MoveNext()
		{
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		[DebuggerHidden]
		[Token(Token = "0x6004C4D")]
		[Address(RVA = "0xD6DBE0", Offset = "0xD6C9E0", Length = "0x3E")]
		void IEnumerator.Reset()
		{
		}
	}

	[CompilerGenerated]
	[Token(Token = "0x2000831")]
	private sealed class _003CPostSceneLoadCo_003Ed__108 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40055FB")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x40055FC")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x40055FD")]
		[FieldOffset(Offset = "0x20")]
		public MissionServicesManager _003C_003E4__this;

		[Token(Token = "0x1700034F")]
		object IEnumerator<object>.Current
		{
			[DebuggerHidden]
			[Token(Token = "0x6004C52")]
			[Address(RVA = "0x4571D0", Offset = "0x455FD0", Length = "0x5")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000350")]
		object IEnumerator.Current
		{
			[DebuggerHidden]
			[Token(Token = "0x6004C54")]
			[Address(RVA = "0x4571D0", Offset = "0x455FD0", Length = "0x5")]
			get
			{
				return null;
			}
		}

		[DebuggerHidden]
		[Token(Token = "0x6004C4F")]
		[Address(RVA = "0x4096E0", Offset = "0x4084E0", Length = "0x4")]
		public _003CPostSceneLoadCo_003Ed__108(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		[Token(Token = "0x6004C50")]
		[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
		void IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6004C51")]
		[Address(RVA = "0xD6DC20", Offset = "0xD6CA20", Length = "0x395")]
		private bool MoveNext()
		{
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		[DebuggerHidden]
		[Token(Token = "0x6004C53")]
		[Address(RVA = "0xD6DFC0", Offset = "0xD6CDC0", Length = "0x3E")]
		void IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x40055D4")]
	private const int FRAMES_BEFORE_DESERIALIZATION_CLEAN_UP = 20;

	[Token(Token = "0x40055D5")]
	[FieldOffset(Offset = "0x20")]
	public FSMOwner m_MainMissionFSMOwner;

	[Token(Token = "0x40055D6")]
	[FieldOffset(Offset = "0x28")]
	public FSMOwner[] m_SideMissionFSMOwners;

	[Token(Token = "0x40055D7")]
	[FieldOffset(Offset = "0x30")]
	public GlobalBlackboard m_GlobalBlackboard;

	[SerializeField]
	[Token(Token = "0x40055D8")]
	[FieldOffset(Offset = "0x38")]
	private GameObject m_SideMissionParent;

	[SerializeField]
	[Token(Token = "0x40055D9")]
	[FieldOffset(Offset = "0x40")]
	private PanelReference<Panel_HUD> m_HUD;

	[SerializeField]
	[Token(Token = "0x40055DA")]
	[FieldOffset(Offset = "0x48")]
	private PanelReference<Panel_Loading> m_LoadingPanel;

	[SerializeField]
	[Token(Token = "0x40055DB")]
	[FieldOffset(Offset = "0x50")]
	private List<LogType> m_SuppressedLogTypes;

	[HideInInspector]
	[Token(Token = "0x40055DC")]
	[FieldOffset(Offset = "0x58")]
	public MainMissionManager m_MainMissionManager;

	[Token(Token = "0x40055DD")]
	[FieldOffset(Offset = "0x60")]
	protected readonly Dictionary<string, MissionManagerBase> m_AllMissions;

	[Token(Token = "0x40055DE")]
	[FieldOffset(Offset = "0x68")]
	protected readonly Dictionary<string, ConcurrentGraphState> m_ConcurrentGraphs;

	[Token(Token = "0x40055DF")]
	[FieldOffset(Offset = "0x70")]
	protected readonly Dictionary<string, MissionObjectIdentifier> m_RegisteredMissionObjects;

	[Token(Token = "0x40055E0")]
	[FieldOffset(Offset = "0x78")]
	private readonly List<MissionManagerBase> m_MissionsToRemove;

	[Token(Token = "0x40055E1")]
	[FieldOffset(Offset = "0x80")]
	protected readonly Dictionary<string, List<MissionTrigger>> m_ObjectInTriggerInfo;

	[Token(Token = "0x40055E2")]
	[FieldOffset(Offset = "0x88")]
	protected readonly List<MissionTimer> m_MissionTimers;

	[Token(Token = "0x40055E3")]
	[FieldOffset(Offset = "0x90")]
	protected MissionTimer m_VisibleMissionTimer;

	[Token(Token = "0x40055E4")]
	[FieldOffset(Offset = "0x98")]
	public string[] m_MissionObjectFilterTags;

	[Token(Token = "0x40055E5")]
	[FieldOffset(Offset = "0xA0")]
	private readonly Dictionary<string, bool> m_FilteredMissionObjects;

	[Token(Token = "0x40055E6")]
	[FieldOffset(Offset = "0xA8")]
	private readonly Dictionary<string, CustomManagedObjectState> m_CustomManagedObjects;

	[Token(Token = "0x40055E7")]
	public static bool m_SuppressItemAddedEvent;

	[Token(Token = "0x40055E8")]
	public static bool m_SuppressItemRemovedEvent;

	[Token(Token = "0x40055E9")]
	public static bool m_StartFromRestore;

	[Token(Token = "0x40055EA")]
	public static int m_StartByMissionJumpCount;

	[Token(Token = "0x40055EB")]
	[FieldOffset(Offset = "0xB0")]
	private readonly List<PendingEvent> m_PendingEventList;

	[Token(Token = "0x40055EC")]
	[FieldOffset(Offset = "0xB8")]
	private readonly List<MissionObjectIdentifier> m_QueuedRegistrations;

	[HideInInspector]
	[Token(Token = "0x40055ED")]
	public static bool m_DeserializeEnabled;

	[Token(Token = "0x40055EE")]
	[FieldOffset(Offset = "0xC0")]
	private int m_DeserializationCleanupTicker;

	[Token(Token = "0x40055EF")]
	[FieldOffset(Offset = "0xC4")]
	private bool m_DeserializeComplete;

	[Token(Token = "0x40055F0")]
	private static readonly MissionServicesManagerSaveProxy m_MissionServicesManagerSaveProxy;

	[Token(Token = "0x40055F1")]
	private static readonly List<string> m_RegisteredObjectsToRemove;

	[Token(Token = "0x40055F2")]
	private static readonly List<string> m_ConcurrentGraphRemoveList;

	[Token(Token = "0x1700034C")]
	private GameObject SideMissionParent
	{
		[Token(Token = "0x6004BD5")]
		[Address(RVA = "0xD5C230", Offset = "0xD5B030", Length = "0x1FC")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6004BD6")]
	[Address(RVA = "0xD5C430", Offset = "0xD5B230", Length = "0x347")]
	protected void Awake()
	{
	}

	[Token(Token = "0x6004BD7")]
	[Address(RVA = "0xD5C780", Offset = "0xD5B580", Length = "0x104")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6004BD8")]
	[Address(RVA = "0xD5C890", Offset = "0xD5B690", Length = "0x8D")]
	private bool OnNodeCanvasLogMessage(ParadoxNotion.Services.Logger.Message message)
	{
		return false;
	}

	[Token(Token = "0x6004BD9")]
	[Address(RVA = "0xD5C920", Offset = "0xD5B720", Length = "0x77")]
	public MissionManagerBase GetMissionManager(string missionId)
	{
		return null;
	}

	[Token(Token = "0x6004BDA")]
	[Address(RVA = "0xD5C9A0", Offset = "0xD5B7A0", Length = "0x6B")]
	public bool IsDeserializationComplete()
	{
		return false;
	}

	[Token(Token = "0x6004BDB")]
	[Address(RVA = "0xD5CA10", Offset = "0xD5B810", Length = "0x70")]
	public bool IsMissionActive(string missionId)
	{
		return false;
	}

	[Token(Token = "0x6004BDC")]
	[Address(RVA = "0xD5CA90", Offset = "0xD5B890", Length = "0x71F")]
	public void InstantiateMission(string missionId)
	{
	}

	[Token(Token = "0x6004BDD")]
	[Address(RVA = "0xD5D1B0", Offset = "0xD5BFB0", Length = "0x1C2")]
	public string GetActiveGraphNameFromObjective(StoryMissionObjective objective)
	{
		return null;
	}

	[Token(Token = "0x6004BDE")]
	[Address(RVA = "0xD5D380", Offset = "0xD5C180", Length = "0x11E")]
	public float GetBlackboardVarAsFloat(string varName, string graphName)
	{
		return 0f;
	}

	[Token(Token = "0x6004BDF")]
	[Address(RVA = "0xD5D4A0", Offset = "0xD5C2A0", Length = "0x22D")]
	public float GetBlackboardVarAsFloatFullSearch(string varName)
	{
		return 0f;
	}

	[Token(Token = "0x6004BE0")]
	[Address(RVA = "0xD5D6D0", Offset = "0xD5C4D0", Length = "0x2D7")]
	public GraphOwner GetMissionGraphOwner(string graphName)
	{
		return null;
	}

	[Token(Token = "0x6004BE1")]
	[Address(RVA = "0xD5D9B0", Offset = "0xD5C7B0", Length = "0xBF")]
	public void StopMission(string missionId, bool forceNow = false)
	{
	}

	[Token(Token = "0x6004BE2")]
	[Address(RVA = "0xD5DA70", Offset = "0xD5C870", Length = "0x1F2")]
	public void StopAllMissions()
	{
	}

	[Token(Token = "0x6004BE3")]
	[Address(RVA = "0xD5DC70", Offset = "0xD5CA70", Length = "0x244")]
	public string GetAllActiveMissionNamesAsString()
	{
		return null;
	}

	[Token(Token = "0x6004BE4")]
	[Address(RVA = "0xD5DEC0", Offset = "0xD5CCC0", Length = "0x174")]
	public void SceneLoadCompleted()
	{
	}

	[Token(Token = "0x6004BE5")]
	[Address(RVA = "0xD5E040", Offset = "0xD5CE40", Length = "0x4D3")]
	public void SceneUnloaded()
	{
	}

	[Token(Token = "0x6004BE6")]
	[Address(RVA = "0xD5E520", Offset = "0xD5D320", Length = "0xA7")]
	public Variable GetGlobalVariable(string name)
	{
		return null;
	}

	[Token(Token = "0x6004BE7")]
	[Address(RVA = "0xD5E5D0", Offset = "0xD5D3D0", Length = "0x37F")]
	public void AddMissionObjectFilterTags(string tags)
	{
	}

	[Token(Token = "0x6004BE8")]
	[Address(RVA = "0xD5E950", Offset = "0xD5D750", Length = "0x375")]
	public void RemoveMissionObjectFilterTags(string tags)
	{
	}

	[Token(Token = "0x6004BE9")]
	[Address(RVA = "0xD5ECD0", Offset = "0xD5DAD0", Length = "0x93")]
	public string GetCurrentMissionFilterTags()
	{
		return null;
	}

	[Token(Token = "0x6004BEA")]
	[Address(RVA = "0xD5ED70", Offset = "0xD5DB70", Length = "0x34")]
	public bool FiltersAllowObject(MissionObjectIdentifier moi)
	{
		return false;
	}

	[Token(Token = "0x6004BEB")]
	[Address(RVA = "0xD5EDB0", Offset = "0xD5DBB0", Length = "0x3EA")]
	public void AddCustomManagedObject(string name, bool reqState)
	{
	}

	[Token(Token = "0x6004BEC")]
	[Address(RVA = "0xD5F1A0", Offset = "0xD5DFA0", Length = "0x2B8")]
	public void RemoveCustomManagedObject(string name)
	{
	}

	[Token(Token = "0x6004BED")]
	[Address(RVA = "0xD5F460", Offset = "0xD5E260", Length = "0x2B7")]
	public void RemoveCustomManagedObject(MissionObjectIdentifier moi)
	{
	}

	[Token(Token = "0x6004BEE")]
	[Address(RVA = "0xD5F720", Offset = "0xD5E520", Length = "0x73")]
	public bool HasCustomManagedObject(string name)
	{
		return false;
	}

	[Token(Token = "0x6004BEF")]
	[Address(RVA = "0xD5F7A0", Offset = "0xD5E5A0", Length = "0x150F")]
	public string Serialize()
	{
		return null;
	}

	[Token(Token = "0x6004BF0")]
	[Address(RVA = "0xD60CB0", Offset = "0xD5FAB0", Length = "0x29A")]
	public void Deserialize(string text)
	{
	}

	[Token(Token = "0x6004BF1")]
	[Address(RVA = "0xD60F50", Offset = "0xD5FD50", Length = "0x20F")]
	public void AfterGlobalDeserialize()
	{
	}

	[Token(Token = "0x6004BF2")]
	[Address(RVA = "0xD61160", Offset = "0xD5FF60", Length = "0xF7")]
	public void SendMissionEvent(string missionId, string eventString)
	{
	}

	[Token(Token = "0x6004BF3")]
	[Address(RVA = "0x1955150", Offset = "0x1953F50", Length = "0x160")]
	public void SendMissionEvent<T>(string missionId, string eventString, T value)
	{
	}

	[Token(Token = "0x6004BF4")]
	[Address(RVA = "0xD61260", Offset = "0xD60060", Length = "0xAC")]
	public void BroadcastMissionEvent(string eventString)
	{
	}

	[Token(Token = "0x6004BF5")]
	[Address(RVA = "0x1954720", Offset = "0x1953520", Length = "0x86")]
	public void BroadcastMissionEvent<T>(string eventString, T value)
	{
	}

	[Token(Token = "0x6004BF6")]
	[Address(RVA = "0xD61310", Offset = "0xD60110", Length = "0xDC")]
	public void BroadcastMissionEvent(MissionEvent missionEvent)
	{
	}

	[Token(Token = "0x6004BF7")]
	[Address(RVA = "0x19547B0", Offset = "0x19535B0", Length = "0x148")]
	public void BroadcastMissionEvent<T>(MissionEvent missionEvent, T value)
	{
	}

	[Token(Token = "0x6004BF8")]
	[Address(RVA = "0x1954650", Offset = "0x1953450", Length = "0xC5")]
	public void BroadcastMissionEvent<T>(MissionObjectEvent missionEvent, T value)
	{
	}

	[Token(Token = "0x6004BF9")]
	[Address(RVA = "0xD613F0", Offset = "0xD601F0", Length = "0x125")]
	public string GetMissionTimerDebugText()
	{
		return null;
	}

	[Token(Token = "0x6004BFA")]
	[Address(RVA = "0xD61520", Offset = "0xD60320", Length = "0x5EC")]
	public static bool ShouldIgnoreMissionObject(MissionObjectIdentifier moi)
	{
		return false;
	}

	[Token(Token = "0x6004BFB")]
	[Address(RVA = "0xD61B10", Offset = "0xD60910", Length = "0x7E")]
	public void QueueRegistration(MissionObjectIdentifier moi)
	{
	}

	[Token(Token = "0x6004BFC")]
	[Address(RVA = "0xD61B90", Offset = "0xD60990", Length = "0x300")]
	public void ProcessRegistrationQueue()
	{
	}

	[Token(Token = "0x6004BFD")]
	[Address(RVA = "0xD61EA0", Offset = "0xD60CA0", Length = "0x50E")]
	public void RegisterMissionObject(MissionObjectIdentifier moi)
	{
	}

	[Token(Token = "0x6004BFE")]
	[Address(RVA = "0xD623B0", Offset = "0xD611B0", Length = "0x292")]
	public void UnregisterMissionObject(MissionObjectIdentifier moi)
	{
	}

	[Token(Token = "0x6004BFF")]
	[Address(RVA = "0xD62650", Offset = "0xD61450", Length = "0xAF")]
	public MissionObjectIdentifier FindMissionObject(string name)
	{
		return null;
	}

	[Token(Token = "0x6004C00")]
	[Address(RVA = "0x1954B60", Offset = "0x1953960", Length = "0x22A")]
	public T FindMissionObject<T>(string name) where T : Component
	{
		return null;
	}

	[Token(Token = "0x6004C01")]
	[Address(RVA = "0xD62700", Offset = "0xD61500", Length = "0x1D1")]
	public List<MissionObjectIdentifier> FindMissionObjectsByTag(string[] tags)
	{
		return null;
	}

	[Token(Token = "0x6004C02")]
	[Address(RVA = "0xD628E0", Offset = "0xD616E0", Length = "0x1D9")]
	public List<MissionObjectIdentifier> FindMissionObjectsWithoutTag()
	{
		return null;
	}

	[Token(Token = "0x6004C03")]
	[Address(RVA = "0xD62AC0", Offset = "0xD618C0", Length = "0x4E2")]
	public void UnregisterAllMissionObjects()
	{
	}

	[Token(Token = "0x6004C04")]
	[Address(RVA = "0xD62FB0", Offset = "0xD61DB0", Length = "0x4EF")]
	public void RegisterConcurrentGraph(string id, GraphOwner graphOwner)
	{
	}

	[Token(Token = "0x6004C05")]
	[Address(RVA = "0xD634A0", Offset = "0xD622A0", Length = "0x21D")]
	public void RemoveConcurrentGraph(string id)
	{
	}

	[Token(Token = "0x6004C06")]
	[Address(RVA = "0xD636C0", Offset = "0xD624C0", Length = "0xAE")]
	public GraphOwner LookupConcurrentGraph(string id)
	{
		return null;
	}

	[Token(Token = "0x6004C07")]
	[Address(RVA = "0xD63770", Offset = "0xD62570", Length = "0x356")]
	public void StartMissionTimer(MissionManagerBase manager, string name, float duration, string eventOnExpire, MissionTimer.MissionTimerOptions options)
	{
	}

	[Token(Token = "0x6004C08")]
	[Address(RVA = "0xD63AD0", Offset = "0xD628D0", Length = "0x1A0")]
	public void RemoveMissionTimer(string name, bool postEvent = true)
	{
	}

	[Token(Token = "0x6004C09")]
	[Address(RVA = "0xD63C80", Offset = "0xD62A80", Length = "0x39A")]
	public void OnEnterMissionTrigger(ObjectInTriggerInfo info)
	{
	}

	[Token(Token = "0x6004C0A")]
	[Address(RVA = "0xD64020", Offset = "0xD62E20", Length = "0x2F7")]
	public void OnExitMissionTrigger(ObjectInTriggerInfo info, bool bypassListRemove = false)
	{
	}

	[Token(Token = "0x6004C0B")]
	[Address(RVA = "0xD64320", Offset = "0xD63120", Length = "0x53B")]
	public void MissionTriggerRemoved(MissionTrigger mt)
	{
	}

	[Token(Token = "0x6004C0C")]
	[Address(RVA = "0xD64860", Offset = "0xD63660", Length = "0xB2")]
	public List<MissionTrigger> IsPlayerInMissionTrigger()
	{
		return null;
	}

	[Token(Token = "0x6004C0D")]
	[Address(RVA = "0xD64920", Offset = "0xD63720", Length = "0x14A")]
	public List<MissionTrigger> IsMissionObjectInMissionTrigger(MissionObjectIdentifier moi)
	{
		return null;
	}

	[Token(Token = "0x6004C0E")]
	[Address(RVA = "0xD64A70", Offset = "0xD63870", Length = "0xFC")]
	public List<MissionTrigger> IsGameObjectInMissionTrigger(GameObject obj)
	{
		return null;
	}

	[Token(Token = "0x6004C0F")]
	[Address(RVA = "0xD64B70", Offset = "0xD63970", Length = "0x6F")]
	public void OnInventoryItemAdded()
	{
	}

	[Token(Token = "0x6004C10")]
	[Address(RVA = "0xD64BE0", Offset = "0xD639E0", Length = "0x70")]
	public void OnInventoryItemRemoved()
	{
	}

	[Token(Token = "0x6004C11")]
	[Address(RVA = "0xD64C50", Offset = "0xD63A50", Length = "0x2B4")]
	public void RegisterAnyMissionObjects()
	{
	}

	[Token(Token = "0x6004C12")]
	[Address(RVA = "0xD64F10", Offset = "0xD63D10", Length = "0x41")]
	public void OnItemEquipped()
	{
	}

	[Token(Token = "0x6004C13")]
	[Address(RVA = "0xD64F60", Offset = "0xD63D60", Length = "0x41")]
	public void OnFiredEquippedWeapon()
	{
	}

	[Token(Token = "0x6004C14")]
	[Address(RVA = "0xD64FB0", Offset = "0xD63DB0", Length = "0x11B")]
	public MissionTimer GetMissionTimerByName(string timerName)
	{
		return null;
	}

	[Token(Token = "0x6004C15")]
	[Address(RVA = "0xD650D0", Offset = "0xD63ED0", Length = "0x15A")]
	public void RefreshMissionIds()
	{
	}

	[Token(Token = "0x6004C16")]
	[Address(RVA = "0xD65230", Offset = "0xD64030", Length = "0xB4D")]
	public void JumpTo(string id, bool isDebug, string missionConfigData = null)
	{
	}

	[Token(Token = "0x6004C17")]
	[Address(RVA = "0xD65D80", Offset = "0xD64B80", Length = "0x1B4")]
	public int GetMissionsActiveActionCount()
	{
		return 0;
	}

	[Token(Token = "0x6004C18")]
	[Address(RVA = "0xD65F40", Offset = "0xD64D40", Length = "0x80")]
	public static bool IsDuplicateAllowed(MissionObjectIdentifier moi)
	{
		return false;
	}

	[Token(Token = "0x6004C19")]
	[Address(RVA = "0x19552C0", Offset = "0x19540C0", Length = "0x1E4")]
	public static bool TryGetMissionBlackboardVar<T>(GraphOwner go, string varName, out T value)
	{
		value = default(T);
		return false;
	}

	[Token(Token = "0x6004C1A")]
	[Address(RVA = "0x1954D90", Offset = "0x1953B90", Length = "0x11D")]
	public static T GetComponentForMissionObject<T>(string moi) where T : Behaviour
	{
		return null;
	}

	[Token(Token = "0x6004C1B")]
	[Address(RVA = "0xD65FD0", Offset = "0xD64DD0", Length = "0x101")]
	public static GameObject GetMissionObject(string moi)
	{
		return null;
	}

	[Token(Token = "0x6004C1C")]
	[Address(RVA = "0xD660E0", Offset = "0xD64EE0", Length = "0x24C")]
	public static MissionObjectIdentifier GetMissionObjectIdentifier(string moi)
	{
		return null;
	}

	[Token(Token = "0x6004C1D")]
	[Address(RVA = "0x1954EB0", Offset = "0x1953CB0", Length = "0x29A")]
	public static T[] GetComponentsInChildrenForMissionObject<T>(string moi, bool includeInactive) where T : Behaviour
	{
		return null;
	}

	[Token(Token = "0x6004C1E")]
	[Address(RVA = "0xD66330", Offset = "0xD65130", Length = "0xF6A")]
	protected void Update()
	{
	}

	[Token(Token = "0x6004C1F")]
	[Address(RVA = "0xD672A0", Offset = "0xD660A0", Length = "0x140")]
	private string GetActiveGraphName(string[] graphNames)
	{
		return null;
	}

	[Token(Token = "0x6004C20")]
	[Address(RVA = "0xD673F0", Offset = "0xD661F0", Length = "0x4B")]
	private bool IsSideMission(string missionName)
	{
		return false;
	}

	[IteratorStateMachine(typeof(_003CPostSceneLoadCo_003Ed__108))]
	[Token(Token = "0x6004C21")]
	[Address(RVA = "0xD67440", Offset = "0xD66240", Length = "0x9A")]
	private IEnumerator PostSceneLoadCo()
	{
		return null;
	}

	[Token(Token = "0x6004C22")]
	[Address(RVA = "0xD674E0", Offset = "0xD662E0", Length = "0x2C8")]
	private void FilterObjectsByTag()
	{
	}

	[Token(Token = "0x6004C23")]
	[Address(RVA = "0xD677B0", Offset = "0xD665B0", Length = "0xA96")]
	private void MaybeCleanupDuplicateBody(MissionObjectIdentifier mo)
	{
	}

	[Token(Token = "0x6004C24")]
	[Address(RVA = "0xD68250", Offset = "0xD67050", Length = "0x855")]
	private void ReviewObjectFiltering()
	{
	}

	[Token(Token = "0x6004C25")]
	[Address(RVA = "0xD68AB0", Offset = "0xD678B0", Length = "0x40")]
	private void DeserializeGlobalBB(MissionServicesManagerSaveProxy proxy)
	{
	}

	[Token(Token = "0x6004C26")]
	[Address(RVA = "0xD68B00", Offset = "0xD67900", Length = "0xD5")]
	private void DeserializeMissions(MissionServicesManagerSaveProxy proxy)
	{
	}

	[Token(Token = "0x6004C27")]
	[Address(RVA = "0xD68BE0", Offset = "0xD679E0", Length = "0x27C")]
	private void DeserializeConcurrentGraphs(MissionServicesManagerSaveProxy proxy)
	{
	}

	[Token(Token = "0x6004C28")]
	[Address(RVA = "0xD68E60", Offset = "0xD67C60", Length = "0x318")]
	private void DeserializeTimers(MissionServicesManagerSaveProxy proxy)
	{
	}

	[Token(Token = "0x6004C29")]
	[Address(RVA = "0xD69180", Offset = "0xD67F80", Length = "0x93")]
	private void TryUnregisterGuid(GameObject gameObject)
	{
	}

	[Token(Token = "0x6004C2A")]
	[Address(RVA = "0xD69220", Offset = "0xD68020", Length = "0x19E")]
	private void EliminateDuplicateAndRestoreAI(MissionObjectIdentifier sceneAiMissionId, BaseAi baseAI, BaseAi sceneAi)
	{
	}

	[Token(Token = "0x6004C2B")]
	[Address(RVA = "0xD693C0", Offset = "0xD681C0", Length = "0x1A3")]
	private void EliminateDuplicateAndRestoreBodyHarvest(MissionObjectIdentifier sceneBodyHarvestMissionId, BodyHarvest bodyHarvest, BodyHarvest sceneBodyHarvest)
	{
	}

	[Token(Token = "0x6004C2C")]
	[Address(RVA = "0xD69570", Offset = "0xD68370", Length = "0x409")]
	private void UnregisterDuplicatedGuids(BaseAi[] sceneAiList, BodyHarvest[] sceneBodyHarvestList)
	{
	}

	[Token(Token = "0x6004C2D")]
	[Address(RVA = "0xD69980", Offset = "0xD68780", Length = "0xEF8")]
	private void EliminateDuplicateAndRestore(BaseAi[] sceneAiList, BodyHarvest[] sceneBodyHarvestList)
	{
	}

	[Token(Token = "0x6004C2E")]
	[Address(RVA = "0xD6A880", Offset = "0xD69680", Length = "0x112")]
	private void MaybeResumeStateOnDeserialize(MissionObjectIdentifier moi, CustomManagedObjectState stateInfo)
	{
	}

	[Token(Token = "0x6004C2F")]
	[Address(RVA = "0xD6A9A0", Offset = "0xD697A0", Length = "0x458")]
	private void DeserializeCustomManagedObjects(MissionServicesManagerSaveProxy proxy)
	{
	}

	[Token(Token = "0x6004C30")]
	[Address(RVA = "0xD6AE00", Offset = "0xD69C00", Length = "0x106")]
	private void SendEvent(EventData ev, string missionId)
	{
	}

	[Token(Token = "0x6004C31")]
	[Address(RVA = "0xD6AF10", Offset = "0xD69D10", Length = "0x2D7")]
	private void SendOrQueueEvent(EventData ev, string missionId)
	{
	}

	[Token(Token = "0x6004C32")]
	[Address(RVA = "0xD6B1F0", Offset = "0xD69FF0", Length = "0x193")]
	private void RemoveMissionTimer(int timerIndex, bool postEvent = true)
	{
	}

	[Token(Token = "0x6004C33")]
	[Address(RVA = "0xD6B390", Offset = "0xD6A190", Length = "0x115")]
	private void ProcessRemoveMissionList()
	{
	}

	[Token(Token = "0x6004C34")]
	[Address(RVA = "0xD6B4B0", Offset = "0xD6A2B0", Length = "0x27F")]
	private void MissionCompleted(MissionManagerBase mm)
	{
	}

	[Token(Token = "0x6004C35")]
	[Address(RVA = "0xD6B730", Offset = "0xD6A530", Length = "0x1AA")]
	private void DestroyMission(MissionManagerBase mm)
	{
	}

	[IteratorStateMachine(typeof(_003CJumpCo_003Ed__129))]
	[Token(Token = "0x6004C36")]
	[Address(RVA = "0xD6B8E0", Offset = "0xD6A6E0", Length = "0x129")]
	private IEnumerator JumpCo(string missionName, bool isDeserialize, bool isDebug)
	{
		return null;
	}

	[Token(Token = "0x6004C37")]
	[Address(RVA = "0xD6BA10", Offset = "0xD6A810", Length = "0x93")]
	private Node GetActiveNode(string mission)
	{
		return null;
	}

	[Token(Token = "0x6004C38")]
	[Address(RVA = "0xD6BAB0", Offset = "0xD6A8B0", Length = "0x1BE")]
	private int RecursiveActionListCounter(ActionList actionList)
	{
		return 0;
	}

	[Token(Token = "0x6004C39")]
	[Address(RVA = "0xD6BC70", Offset = "0xD6AA70", Length = "0x464")]
	private int GetSubNodeActionCountRecursive(Node node)
	{
		return 0;
	}

	[Token(Token = "0x6004C3A")]
	[Address(RVA = "0xD6C0E0", Offset = "0xD6AEE0", Length = "0x283")]
	private int GetNodeActiveActionCountRecursive(Node node)
	{
		return 0;
	}

	[Token(Token = "0x6004C3B")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public static void LogConditionEnabledRecursive(ConditionTask conditionTask)
	{
	}

	[Token(Token = "0x6004C3C")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public static void LogTransitionRecursive(ConditionTask conditionTask)
	{
	}

	[Token(Token = "0x6004C3D")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public static void LogActionTaskEnter(ActionTask actionTask)
	{
	}

	[Token(Token = "0x6004C3E")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public static void LogActionTaskEnd(ActionTask actionTask, Status status)
	{
	}

	[Token(Token = "0x6004C3F")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public static void LogActonStateEnter(ActionState actionState)
	{
	}

	[Token(Token = "0x6004C40")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public static void LogActonStateExit(ActionState actionState)
	{
	}

	[Token(Token = "0x6004C41")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public static void LogPendingSave()
	{
	}

	[Token(Token = "0x6004C42")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public static void LogSave(float timePending)
	{
	}

	[Token(Token = "0x6004C43")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public static void LogPendingSaveTimeout(float time)
	{
	}

	[Token(Token = "0x6004C44")]
	[Address(RVA = "0xD6C370", Offset = "0xD6B170", Length = "0x678")]
	public static Node GetOwner(FSM fsm, Task task)
	{
		return null;
	}

	[Token(Token = "0x6004C45")]
	[Address(RVA = "0xD6C9F0", Offset = "0xD6B7F0", Length = "0x129")]
	private static bool GetOwnerRecursive(ConditionTask conditionTask, Task child)
	{
		return false;
	}

	[Token(Token = "0x6004C46")]
	[Address(RVA = "0xD6CB20", Offset = "0xD6B920", Length = "0x153")]
	private static bool GetNodeOwnsChild(Node node, Task child)
	{
		return false;
	}

	[Token(Token = "0x6004C47")]
	[Address(RVA = "0xD6CC80", Offset = "0xD6BA80", Length = "0x61F")]
	protected MissionServicesManager()
	{
	}
}
