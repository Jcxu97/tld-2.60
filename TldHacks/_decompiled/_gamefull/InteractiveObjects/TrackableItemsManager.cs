using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using NodeCanvas.Framework;
using TLD.Scenes.ObjectReferences;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.ResourceManagement.AsyncOperations;

namespace InteractiveObjects;

[Token(Token = "0x2001324")]
public class TrackableItemsManager : MonoBehaviour
{
	[Token(Token = "0x2001325")]
	private class ManagerSaveDataProxyGlobal
	{
		[Token(Token = "0x4008D77")]
		[FieldOffset(Offset = "0x10")]
		public Dictionary<string, TrackableItemSaveData> m_ListDataProxyGlobal;

		[Token(Token = "0x6007AC0")]
		[Address(RVA = "0x1197C00", Offset = "0x1196A00", Length = "0xAD")]
		public ManagerSaveDataProxyGlobal()
		{
		}
	}

	[CompilerGenerated]
	[Token(Token = "0x2001326")]
	private sealed class _003CWaitForResearchSet_003Ed__19 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4008D78")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4008D79")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4008D7A")]
		[FieldOffset(Offset = "0x20")]
		public TrackableItemsManager _003C_003E4__this;

		[Token(Token = "0x4008D7B")]
		[FieldOffset(Offset = "0x28")]
		private MissionServicesManager _003CmissionManager_003E5__2;

		[Token(Token = "0x4008D7C")]
		[FieldOffset(Offset = "0x30")]
		private IBlackboard _003Cbb_003E5__3;

		[Token(Token = "0x17000A37")]
		object IEnumerator<object>.Current
		{
			[DebuggerHidden]
			[Token(Token = "0x6007AC4")]
			[Address(RVA = "0x4571D0", Offset = "0x455FD0", Length = "0x5")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000A38")]
		object IEnumerator.Current
		{
			[DebuggerHidden]
			[Token(Token = "0x6007AC6")]
			[Address(RVA = "0x4571D0", Offset = "0x455FD0", Length = "0x5")]
			get
			{
				return null;
			}
		}

		[DebuggerHidden]
		[Token(Token = "0x6007AC1")]
		[Address(RVA = "0x4096E0", Offset = "0x4084E0", Length = "0x4")]
		public _003CWaitForResearchSet_003Ed__19(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		[Token(Token = "0x6007AC2")]
		[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
		void IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6007AC3")]
		[Address(RVA = "0x1197CB0", Offset = "0x1196AB0", Length = "0x5AD")]
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
		[Token(Token = "0x6007AC5")]
		[Address(RVA = "0x1198260", Offset = "0x1197060", Length = "0x3E")]
		void IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4008D6D")]
	private const string ResearchSetVariableName = "ResearchSet";

	[Token(Token = "0x4008D6E")]
	private const int ExpectedCapacity = 100;

	[SerializeField]
	[Token(Token = "0x4008D71")]
	[FieldOffset(Offset = "0x20")]
	private AssetLabelReference m_TrackableItemLabel;

	[Token(Token = "0x4008D72")]
	[FieldOffset(Offset = "0x28")]
	private AsyncOperationHandle<IList<TrackableItemData>> m_TrackableItemsHandle;

	[Token(Token = "0x4008D73")]
	[FieldOffset(Offset = "0x40")]
	private readonly List<TrackableItemData> m_ActiveItems;

	[Token(Token = "0x4008D74")]
	[FieldOffset(Offset = "0x48")]
	private readonly Dictionary<string, TrackableItemSaveData> m_SaveData;

	[Token(Token = "0x4008D75")]
	[FieldOffset(Offset = "0x50")]
	private readonly List<ITrackable> m_ItemReferences;

	[Token(Token = "0x4008D76")]
	[FieldOffset(Offset = "0x58")]
	private Variable<int> m_ResearchSetVariable;

	[Token(Token = "0x17000A36")]
	[field: Token(Token = "0x4008D6F")]
	public static TrackableItemsManager Instance
	{
		[Token(Token = "0x6007AAC")]
		[Address(RVA = "0x1195A10", Offset = "0x1194810", Length = "0x3B")]
		get;
		[Token(Token = "0x6007AAD")]
		[Address(RVA = "0x1195A50", Offset = "0x1194850", Length = "0x97")]
		private set;
	}

	[Token(Token = "0x1400003D")]
	public static event Action OnDeserializeCompleted
	{
		[CompilerGenerated]
		[Token(Token = "0x6007AAE")]
		[Address(RVA = "0x1195AF0", Offset = "0x11948F0", Length = "0x10A")]
		add
		{
		}
		[CompilerGenerated]
		[Token(Token = "0x6007AAF")]
		[Address(RVA = "0x1195C00", Offset = "0x1194A00", Length = "0x10A")]
		remove
		{
		}
	}

	[Token(Token = "0x6007AB0")]
	[Address(RVA = "0x1195D10", Offset = "0x1194B10", Length = "0xDC")]
	private void Awake()
	{
	}

	[Token(Token = "0x6007AB1")]
	[Address(RVA = "0x1195DF0", Offset = "0x1194BF0", Length = "0xA4")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6007AB2")]
	[Address(RVA = "0x1195EA0", Offset = "0x1194CA0", Length = "0x56D")]
	private void OnDestroy()
	{
	}

	[IteratorStateMachine(typeof(_003CWaitForResearchSet_003Ed__19))]
	[Token(Token = "0x6007AB3")]
	[Address(RVA = "0x1196410", Offset = "0x1195210", Length = "0x9A")]
	private IEnumerator WaitForResearchSet()
	{
		return null;
	}

	[Token(Token = "0x6007AB4")]
	[Address(RVA = "0x11964B0", Offset = "0x11952B0", Length = "0xE6")]
	private void OnResearchSetChanged(string variableName, object variableValue)
	{
	}

	[Token(Token = "0x6007AB5")]
	[Address(RVA = "0x11965A0", Offset = "0x11953A0", Length = "0x315")]
	private void PrepareAllTransmitterItems()
	{
	}

	[Token(Token = "0x6007AB6")]
	[Address(RVA = "0x11968C0", Offset = "0x11956C0", Length = "0x36A")]
	private void FilterActiveItemsByResearchSet(string researchSet)
	{
	}

	[Token(Token = "0x6007AB7")]
	[Address(RVA = "0x1196C30", Offset = "0x1195A30", Length = "0x136")]
	public static string SerializeAll()
	{
		return null;
	}

	[Token(Token = "0x6007AB8")]
	[Address(RVA = "0x1196D70", Offset = "0x1195B70", Length = "0x13F")]
	public static void DeserializeAll(string json)
	{
	}

	[Token(Token = "0x6007AB9")]
	[Address(RVA = "0x1196EB0", Offset = "0x1195CB0", Length = "0x34C")]
	private string Serialize()
	{
		return null;
	}

	[Token(Token = "0x6007ABA")]
	[Address(RVA = "0x1197200", Offset = "0x1196000", Length = "0x276")]
	private void Deserialize(string text)
	{
	}

	[Token(Token = "0x6007ABB")]
	[Address(RVA = "0x1197480", Offset = "0x1196280", Length = "0xF0")]
	public TrackableItemSaveData GetTrackableItemSavedData(string guid)
	{
		return null;
	}

	[Token(Token = "0x6007ABC")]
	[Address(RVA = "0x1197580", Offset = "0x1196380", Length = "0xA5")]
	public bool IsInActiveList(TrackableItemData trackableItem)
	{
		return false;
	}

	[Token(Token = "0x6007ABD")]
	[Address(RVA = "0x669640", Offset = "0x668440", Length = "0x5")]
	public List<ITrackable> GetItemReferences()
	{
		return null;
	}

	[Token(Token = "0x6007ABE")]
	[Address(RVA = "0x1197630", Offset = "0x1196430", Length = "0x1EC")]
	private void AddAvailableItem(SceneObjectReference sender, GameObject owner)
	{
	}

	[Token(Token = "0x6007ABF")]
	[Address(RVA = "0x1197820", Offset = "0x1196620", Length = "0x3D4")]
	public TrackableItemsManager()
	{
	}
}
