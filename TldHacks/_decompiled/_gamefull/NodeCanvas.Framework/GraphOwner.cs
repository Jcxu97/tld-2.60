using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using ParadoxNotion;
using UnityEngine;

namespace NodeCanvas.Framework;

[Token(Token = "0x2001056")]
public abstract class GraphOwner : MonoBehaviour
{
	[Token(Token = "0x2001057")]
	public enum EnableAction
	{
		[Token(Token = "0x4008553")]
		EnableBehaviour,
		[Token(Token = "0x4008554")]
		DoNothing
	}

	[Token(Token = "0x2001058")]
	public enum DisableAction
	{
		[Token(Token = "0x4008556")]
		DisableBehaviour,
		[Token(Token = "0x4008557")]
		PauseBehaviour,
		[Token(Token = "0x4008558")]
		DoNothing
	}

	[SerializeField]
	[Token(Token = "0x4008549")]
	[FieldOffset(Offset = "0x20")]
	private string boundGraphSerialization;

	[SerializeField]
	[Token(Token = "0x400854A")]
	[FieldOffset(Offset = "0x28")]
	private List<UnityEngine.Object> boundGraphObjectReferences;

	[HideInInspector]
	[Token(Token = "0x400854B")]
	[FieldOffset(Offset = "0x30")]
	public EnableAction enableAction;

	[HideInInspector]
	[Token(Token = "0x400854C")]
	[FieldOffset(Offset = "0x34")]
	public DisableAction disableAction;

	[Token(Token = "0x400854D")]
	public static Action<GraphOwner> onOwnerBehaviourStateChange;

	[Token(Token = "0x400854E")]
	[FieldOffset(Offset = "0x38")]
	private Dictionary<Graph, Graph> instances;

	[Token(Token = "0x400854F")]
	[FieldOffset(Offset = "0x40")]
	private bool initialized;

	[Token(Token = "0x4008550")]
	[FieldOffset(Offset = "0x41")]
	private bool startCalled;

	[Token(Token = "0x4008551")]
	private static bool isQuiting;

	[Token(Token = "0x170007AA")]
	public abstract Graph graph
	{
		[Token(Token = "0x6006ECF")]
		get;
		[Token(Token = "0x6006ED0")]
		set;
	}

	[Token(Token = "0x170007AB")]
	public abstract IBlackboard blackboard
	{
		[Token(Token = "0x6006ED1")]
		get;
		[Token(Token = "0x6006ED2")]
		set;
	}

	[Token(Token = "0x170007AC")]
	public abstract Type graphType
	{
		[Token(Token = "0x6006ED3")]
		get;
	}

	[Token(Token = "0x170007AD")]
	public bool isRunning
	{
		[Token(Token = "0x6006ED4")]
		[Address(RVA = "0x10BF060", Offset = "0x10BDE60", Length = "0x110")]
		get
		{
			return false;
		}
	}

	[Token(Token = "0x170007AE")]
	public bool isPaused
	{
		[Token(Token = "0x6006ED5")]
		[Address(RVA = "0x10BF180", Offset = "0x10BDF80", Length = "0x110")]
		get
		{
			return false;
		}
	}

	[Token(Token = "0x170007AF")]
	public float elapsedTime
	{
		[Token(Token = "0x6006ED6")]
		[Address(RVA = "0x10BF2A0", Offset = "0x10BE0A0", Length = "0x168")]
		get
		{
			return 0f;
		}
	}

	[Token(Token = "0x6006ED7")]
	[Address(RVA = "0x10BF410", Offset = "0x10BE210", Length = "0x267")]
	public Graph GetInstance(Graph originalGraph)
	{
		return null;
	}

	[Token(Token = "0x6006ED8")]
	[Address(RVA = "0x10BF680", Offset = "0x10BE480", Length = "0xD")]
	public void StartBehaviour()
	{
	}

	[Token(Token = "0x6006ED9")]
	[Address(RVA = "0x10BF690", Offset = "0x10BE490", Length = "0xD")]
	public void StartBehaviour(Action<bool> callback)
	{
	}

	[Token(Token = "0x6006EDA")]
	[Address(RVA = "0x10BF6A0", Offset = "0x10BE4A0", Length = "0x1C4")]
	public void StartBehaviour(bool autoUpdate, Action<bool> callback)
	{
	}

	[Token(Token = "0x6006EDB")]
	[Address(RVA = "0x10BF870", Offset = "0x10BE670", Length = "0x13B")]
	public void PauseBehaviour()
	{
	}

	[Token(Token = "0x6006EDC")]
	[Address(RVA = "0x10BF9B0", Offset = "0x10BE7B0", Length = "0x14D")]
	public void StopBehaviour(bool success = true)
	{
	}

	[Token(Token = "0x6006EDD")]
	[Address(RVA = "0x10BFB00", Offset = "0x10BE900", Length = "0x119")]
	public void UpdateBehaviour()
	{
	}

	[Token(Token = "0x6006EDE")]
	[Address(RVA = "0x10BFC20", Offset = "0x10BEA20", Length = "0x28")]
	public void RestartBehaviour()
	{
	}

	[Token(Token = "0x6006EDF")]
	[Address(RVA = "0x10BFC50", Offset = "0x10BEA50", Length = "0xAC")]
	public void SendEvent(string eventName)
	{
	}

	[Token(Token = "0x6006EE0")]
	[Address(RVA = "0x18E41F0", Offset = "0x18E2FF0", Length = "0x105")]
	public void SendEvent<T>(string eventName, T eventValue)
	{
	}

	[Token(Token = "0x6006EE1")]
	[Address(RVA = "0x10BFD00", Offset = "0x10BEB00", Length = "0x127")]
	public void SendEvent(EventData eventData, object sender)
	{
	}

	[Token(Token = "0x6006EE2")]
	[Address(RVA = "0x10BFE30", Offset = "0x10BEC30", Length = "0x3B1")]
	public void Initialize()
	{
	}

	[Token(Token = "0x6006EE3")]
	[Address(RVA = "0x10C01F0", Offset = "0x10BEFF0", Length = "0x7")]
	protected virtual void Awake()
	{
	}

	[Token(Token = "0x6006EE4")]
	[Address(RVA = "0x10C0200", Offset = "0x10BF000", Length = "0x1A")]
	protected void OnEnable()
	{
	}

	[Token(Token = "0x6006EE5")]
	[Address(RVA = "0x10C0220", Offset = "0x10BF020", Length = "0x18")]
	protected void Start()
	{
	}

	[Token(Token = "0x6006EE6")]
	[Address(RVA = "0x10C0240", Offset = "0x10BF040", Length = "0x6C")]
	protected void OnDisable()
	{
	}

	[Token(Token = "0x6006EE7")]
	[Address(RVA = "0x10C02B0", Offset = "0x10BF0B0", Length = "0x421")]
	protected virtual void OnDestroy()
	{
	}

	[Token(Token = "0x6006EE8")]
	[Address(RVA = "0x10C06E0", Offset = "0x10BF4E0", Length = "0x3C")]
	protected void OnApplicationQuit()
	{
	}

	[Token(Token = "0x6006EE9")]
	[Address(RVA = "0x10C0720", Offset = "0x10BF520", Length = "0xE3")]
	protected GraphOwner()
	{
	}
}
[Token(Token = "0x2001059")]
public abstract class GraphOwner<T> : GraphOwner where T : Graph
{
	[SerializeField]
	[Token(Token = "0x4008559")]
	[FieldOffset(Offset = "0x0")]
	private T _graph;

	[SerializeField]
	[Token(Token = "0x400855A")]
	[FieldOffset(Offset = "0x0")]
	private UnityEngine.Object _blackboard;

	[Token(Token = "0x170007B0")]
	public sealed override Graph graph
	{
		[Token(Token = "0x6006EEA")]
		[Address(RVA = "0x4B2FE0", Offset = "0x4B1DE0", Length = "0x5")]
		get
		{
			return null;
		}
		[Token(Token = "0x6006EEB")]
		[Address(RVA = "0x2959A00", Offset = "0x2958800", Length = "0x10D")]
		set
		{
		}
	}

	[Token(Token = "0x170007B1")]
	public T behaviour
	{
		[Token(Token = "0x6006EEC")]
		[Address(RVA = "0x4B2FE0", Offset = "0x4B1DE0", Length = "0x5")]
		get
		{
			return null;
		}
		[Token(Token = "0x6006EED")]
		[Address(RVA = "0x4D0B60", Offset = "0x4CF960", Length = "0x52")]
		set
		{
		}
	}

	[Token(Token = "0x170007B2")]
	public sealed override IBlackboard blackboard
	{
		[Token(Token = "0x6006EEE")]
		[Address(RVA = "0x2959B10", Offset = "0x2958910", Length = "0x285")]
		get
		{
			return null;
		}
		[Token(Token = "0x6006EEF")]
		[Address(RVA = "0x2959DA0", Offset = "0x2958BA0", Length = "0x233")]
		set
		{
		}
	}

	[Token(Token = "0x170007B3")]
	public sealed override Type graphType
	{
		[Token(Token = "0x6006EF0")]
		[Address(RVA = "0x2959FE0", Offset = "0x2958DE0", Length = "0x64")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6006EF1")]
	[Address(RVA = "0x295A050", Offset = "0x2958E50", Length = "0x54")]
	public void StartBehaviour(T newGraph)
	{
	}

	[Token(Token = "0x6006EF2")]
	[Address(RVA = "0x295A0B0", Offset = "0x2958EB0", Length = "0x61")]
	public void StartBehaviour(T newGraph, Action<bool> callback)
	{
	}

	[Token(Token = "0x6006EF3")]
	[Address(RVA = "0x295A120", Offset = "0x2958F20", Length = "0x71")]
	public void StartBehaviour(T newGraph, bool autoUpdate, Action<bool> callback)
	{
	}

	[Token(Token = "0x6006EF4")]
	[Address(RVA = "0x295A050", Offset = "0x2958E50", Length = "0x54")]
	public void SwitchBehaviour(T newGraph)
	{
	}

	[Token(Token = "0x6006EF5")]
	[Address(RVA = "0x295A0B0", Offset = "0x2958EB0", Length = "0x61")]
	public void SwitchBehaviour(T newGraph, Action<bool> callback)
	{
	}

	[Token(Token = "0x6006EF6")]
	[Address(RVA = "0x295A120", Offset = "0x2958F20", Length = "0x71")]
	public void SwitchBehaviour(T newGraph, bool autoUpdate, Action<bool> callback)
	{
	}

	[Token(Token = "0x6006EF7")]
	[Address(RVA = "0x10C0720", Offset = "0x10BF520", Length = "0xE3")]
	protected GraphOwner()
	{
	}
}
