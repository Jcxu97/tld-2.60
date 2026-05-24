using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using ParadoxNotion;
using ParadoxNotion.Design;
using UnityEngine;

namespace NodeCanvas.Framework;

[Serializable]
[SpoofAOT]
[Token(Token = "0x2001063")]
public abstract class Node : IGraphElement
{
	[CompilerGenerated]
	[Token(Token = "0x2001068")]
	private sealed class _003CYieldBreak_003Ed__85 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4008572")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4008573")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4008574")]
		[FieldOffset(Offset = "0x20")]
		public Action resume;

		[Token(Token = "0x170007CF")]
		object IEnumerator<object>.Current
		{
			[DebuggerHidden]
			[Token(Token = "0x6006F64")]
			[Address(RVA = "0x4571D0", Offset = "0x455FD0", Length = "0x5")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170007D0")]
		object IEnumerator.Current
		{
			[DebuggerHidden]
			[Token(Token = "0x6006F66")]
			[Address(RVA = "0x4571D0", Offset = "0x455FD0", Length = "0x5")]
			get
			{
				return null;
			}
		}

		[DebuggerHidden]
		[Token(Token = "0x6006F61")]
		[Address(RVA = "0x4096E0", Offset = "0x4084E0", Length = "0x4")]
		public _003CYieldBreak_003Ed__85(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		[Token(Token = "0x6006F62")]
		[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
		void IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6006F63")]
		[Address(RVA = "0x10C3890", Offset = "0x10C2690", Length = "0x114")]
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
		[Token(Token = "0x6006F65")]
		[Address(RVA = "0x10C39B0", Offset = "0x10C27B0", Length = "0x3E")]
		void IEnumerator.Reset()
		{
		}
	}

	[SerializeField]
	[Token(Token = "0x400855B")]
	[FieldOffset(Offset = "0x10")]
	private Vector2 _position;

	[SerializeField]
	[Token(Token = "0x400855C")]
	[FieldOffset(Offset = "0x18")]
	private string _UID;

	[SerializeField]
	[Token(Token = "0x400855D")]
	[FieldOffset(Offset = "0x20")]
	private string _name;

	[SerializeField]
	[Token(Token = "0x400855E")]
	[FieldOffset(Offset = "0x28")]
	private string _tag;

	[SerializeField]
	[Token(Token = "0x400855F")]
	[FieldOffset(Offset = "0x30")]
	private string _comment;

	[SerializeField]
	[Token(Token = "0x4008560")]
	[FieldOffset(Offset = "0x38")]
	private bool _isBreakpoint;

	[Token(Token = "0x4008561")]
	[FieldOffset(Offset = "0x40")]
	private Graph _graph;

	[Token(Token = "0x4008562")]
	[FieldOffset(Offset = "0x48")]
	private List<Connection> _inConnections;

	[Token(Token = "0x4008563")]
	[FieldOffset(Offset = "0x50")]
	private List<Connection> _outConnections;

	[Token(Token = "0x4008564")]
	[FieldOffset(Offset = "0x58")]
	private int _ID;

	[NonSerialized]
	[Token(Token = "0x4008565")]
	[FieldOffset(Offset = "0x5C")]
	private Status _status;

	[NonSerialized]
	[Token(Token = "0x4008566")]
	[FieldOffset(Offset = "0x60")]
	private string _nameCache;

	[NonSerialized]
	[Token(Token = "0x4008567")]
	[FieldOffset(Offset = "0x68")]
	private string _descriptionCache;

	[NonSerialized]
	[Token(Token = "0x4008568")]
	[FieldOffset(Offset = "0x70")]
	private int _priorityCache;

	[Token(Token = "0x170007B7")]
	public Graph graph
	{
		[Token(Token = "0x6006F05")]
		[Address(RVA = "0x4A7D60", Offset = "0x4A6B60", Length = "0x5")]
		get
		{
			return null;
		}
		[Token(Token = "0x6006F06")]
		[Address(RVA = "0x4D0B00", Offset = "0x4CF900", Length = "0x52")]
		set
		{
		}
	}

	[Token(Token = "0x170007B8")]
	public int ID
	{
		[Token(Token = "0x6006F07")]
		[Address(RVA = "0xE1E900", Offset = "0xE1D700", Length = "0x4")]
		get
		{
			return 0;
		}
		[Token(Token = "0x6006F08")]
		[Address(RVA = "0xE1F180", Offset = "0xE1DF80", Length = "0x4")]
		set
		{
		}
	}

	[Token(Token = "0x170007B9")]
	public List<Connection> inConnections
	{
		[Token(Token = "0x6006F09")]
		[Address(RVA = "0x4B2FE0", Offset = "0x4B1DE0", Length = "0x5")]
		get
		{
			return null;
		}
		[Token(Token = "0x6006F0A")]
		[Address(RVA = "0x4D0B60", Offset = "0x4CF960", Length = "0x52")]
		protected set
		{
		}
	}

	[Token(Token = "0x170007BA")]
	public List<Connection> outConnections
	{
		[Token(Token = "0x6006F0B")]
		[Address(RVA = "0x669640", Offset = "0x668440", Length = "0x5")]
		get
		{
			return null;
		}
		[Token(Token = "0x6006F0C")]
		[Address(RVA = "0x6339B0", Offset = "0x6327B0", Length = "0xED7")]
		protected set
		{
		}
	}

	[Token(Token = "0x170007BB")]
	public Vector2 position
	{
		[Token(Token = "0x6006F0D")]
		[Address(RVA = "0x10C0810", Offset = "0x10BF610", Length = "0x13")]
		get
		{
			return default(Vector2);
		}
		[Token(Token = "0x6006F0E")]
		[Address(RVA = "0x10C0830", Offset = "0x10BF630", Length = "0x5")]
		set
		{
		}
	}

	[Token(Token = "0x170007BC")]
	public string UID
	{
		[Token(Token = "0x6006F0F")]
		[Address(RVA = "0x10C0840", Offset = "0x10BF640", Length = "0xEA")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170007BD")]
	private string customName
	{
		[Token(Token = "0x6006F10")]
		[Address(RVA = "0x40E110", Offset = "0x40CF10", Length = "0x5")]
		get
		{
			return null;
		}
		[Token(Token = "0x6006F11")]
		[Address(RVA = "0x40E120", Offset = "0x40CF20", Length = "0x52")]
		set
		{
		}
	}

	[Token(Token = "0x170007BE")]
	public string tag
	{
		[Token(Token = "0x6006F12")]
		[Address(RVA = "0x413AB0", Offset = "0x4128B0", Length = "0x5")]
		get
		{
			return null;
		}
		[Token(Token = "0x6006F13")]
		[Address(RVA = "0x4A9DB0", Offset = "0x4A8BB0", Length = "0x52")]
		set
		{
		}
	}

	[Token(Token = "0x170007BF")]
	public string comments
	{
		[Token(Token = "0x6006F14")]
		[Address(RVA = "0x457420", Offset = "0x456220", Length = "0x5")]
		get
		{
			return null;
		}
		[Token(Token = "0x6006F15")]
		[Address(RVA = "0x4B1CB0", Offset = "0x4B0AB0", Length = "0x52")]
		set
		{
		}
	}

	[Token(Token = "0x170007C0")]
	public bool isBreakpoint
	{
		[Token(Token = "0x6006F16")]
		[Address(RVA = "0x8BE400", Offset = "0x8BD200", Length = "0x5")]
		get
		{
			return false;
		}
		[Token(Token = "0x6006F17")]
		[Address(RVA = "0x8BE410", Offset = "0x8BD210", Length = "0x4")]
		set
		{
		}
	}

	[Token(Token = "0x170007C1")]
	public virtual string name
	{
		[Token(Token = "0x6006F18")]
		[Address(RVA = "0x10C0930", Offset = "0x10BF730", Length = "0x16F")]
		get
		{
			return null;
		}
		[Token(Token = "0x6006F19")]
		[Address(RVA = "0x40E120", Offset = "0x40CF20", Length = "0x52")]
		set
		{
		}
	}

	[Token(Token = "0x170007C2")]
	public virtual string description
	{
		[Token(Token = "0x6006F1A")]
		[Address(RVA = "0x10C0AA0", Offset = "0x10BF8A0", Length = "0x100")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170007C3")]
	public virtual int priority
	{
		[Token(Token = "0x6006F1B")]
		[Address(RVA = "0x10C0BA0", Offset = "0x10BF9A0", Length = "0xA0")]
		get
		{
			return 0;
		}
	}

	[Token(Token = "0x170007C4")]
	public abstract int maxInConnections
	{
		[Token(Token = "0x6006F1C")]
		get;
	}

	[Token(Token = "0x170007C5")]
	public abstract int maxOutConnections
	{
		[Token(Token = "0x6006F1D")]
		get;
	}

	[Token(Token = "0x170007C6")]
	public abstract Type outConnectionType
	{
		[Token(Token = "0x6006F1E")]
		get;
	}

	[Token(Token = "0x170007C7")]
	public abstract bool allowAsPrime
	{
		[Token(Token = "0x6006F1F")]
		get;
	}

	[Token(Token = "0x170007C8")]
	public abstract Alignment2x2 commentsAlignment
	{
		[Token(Token = "0x6006F20")]
		get;
	}

	[Token(Token = "0x170007C9")]
	public abstract Alignment2x2 iconAlignment
	{
		[Token(Token = "0x6006F21")]
		get;
	}

	[Token(Token = "0x170007CA")]
	public Status status
	{
		[Token(Token = "0x6006F22")]
		[Address(RVA = "0x10C0C40", Offset = "0x10BFA40", Length = "0x4")]
		get
		{
			return default(Status);
		}
		[Token(Token = "0x6006F23")]
		[Address(RVA = "0x10C0C50", Offset = "0x10BFA50", Length = "0x4")]
		protected set
		{
		}
	}

	[Token(Token = "0x170007CB")]
	public Component graphAgent
	{
		[Token(Token = "0x6006F24")]
		[Address(RVA = "0x10C0C60", Offset = "0x10BFA60", Length = "0xE9")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170007CC")]
	public IBlackboard graphBlackboard
	{
		[Token(Token = "0x6006F25")]
		[Address(RVA = "0x10C0D50", Offset = "0x10BFB50", Length = "0x117")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170007CD")]
	[field: Token(Token = "0x4008569")]
	[field: FieldOffset(Offset = "0x74")]
	private bool isChecked
	{
		[Token(Token = "0x6006F26")]
		[Address(RVA = "0x756030", Offset = "0x754E30", Length = "0x5")]
		get;
		[Token(Token = "0x6006F27")]
		[Address(RVA = "0x1025040", Offset = "0x1023E40", Length = "0x4")]
		set;
	}

	[Token(Token = "0x170007CE")]
	[field: Token(Token = "0x400856A")]
	[field: FieldOffset(Offset = "0x75")]
	private bool breakPointReached
	{
		[Token(Token = "0x6006F28")]
		[Address(RVA = "0x10C0E70", Offset = "0x10BFC70", Length = "0x5")]
		get;
		[Token(Token = "0x6006F29")]
		[Address(RVA = "0x10C0E80", Offset = "0x10BFC80", Length = "0x4")]
		set;
	}

	[Token(Token = "0x6006F2A")]
	[Address(RVA = "0x10C0E90", Offset = "0x10BFC90", Length = "0x147")]
	public Node()
	{
	}

	[Token(Token = "0x6006F2B")]
	[Address(RVA = "0x10C0FE0", Offset = "0x10BFDE0", Length = "0x38A")]
	public static Node Create(Graph targetGraph, Type nodeType, Vector2 pos)
	{
		return null;
	}

	[Token(Token = "0x6006F2C")]
	[Address(RVA = "0x10C1370", Offset = "0x10C0170", Length = "0x566")]
	public Node Duplicate(Graph targetGraph)
	{
		return null;
	}

	[Token(Token = "0x6006F2D")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public virtual void OnCreate(Graph assignedGraph)
	{
	}

	[Token(Token = "0x6006F2E")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public virtual void OnValidate(Graph assignedGraph)
	{
	}

	[Token(Token = "0x6006F2F")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public virtual void OnDestroy()
	{
	}

	[Token(Token = "0x6006F30")]
	[Address(RVA = "0x10C18E0", Offset = "0x10C06E0", Length = "0x25")]
	public Status Execute(Component agent, IBlackboard blackboard)
	{
		return default(Status);
	}

	[Token(Token = "0x6006F31")]
	[Address(RVA = "0x10C1910", Offset = "0x10C0710", Length = "0xF6")]
	public void Reset(bool recursively = true)
	{
	}

	[IteratorStateMachine(typeof(_003CYieldBreak_003Ed__85))]
	[Token(Token = "0x6006F32")]
	[Address(RVA = "0x10C1A10", Offset = "0x10C0810", Length = "0x9A")]
	private IEnumerator YieldBreak(Action resume)
	{
		return null;
	}

	[Token(Token = "0x6006F33")]
	[Address(RVA = "0x10C1AB0", Offset = "0x10C08B0", Length = "0x11B")]
	public Status Error(object msg)
	{
		return default(Status);
	}

	[Token(Token = "0x6006F34")]
	[Address(RVA = "0x10C1BD0", Offset = "0x10C09D0", Length = "0x80")]
	public Status Fail(string msg)
	{
		return default(Status);
	}

	[Token(Token = "0x6006F35")]
	[Address(RVA = "0x10C1C50", Offset = "0x10C0A50", Length = "0x76")]
	public void Warn(string msg)
	{
	}

	[Token(Token = "0x6006F36")]
	[Address(RVA = "0x10C0C50", Offset = "0x10BFA50", Length = "0x4")]
	public void SetStatus(Status status)
	{
	}

	[Token(Token = "0x6006F37")]
	[Address(RVA = "0x10C1CD0", Offset = "0x10C0AD0", Length = "0x24")]
	protected void SendEvent(EventData eventData)
	{
	}

	[Token(Token = "0x6006F38")]
	[Address(RVA = "0x10C1D00", Offset = "0x10C0B00", Length = "0x32")]
	public void RegisterEvents(params string[] eventNames)
	{
	}

	[Token(Token = "0x6006F39")]
	[Address(RVA = "0x10C1D40", Offset = "0x10C0B40", Length = "0x254")]
	public void RegisterEvents(Component targetAgent, params string[] eventNames)
	{
	}

	[Token(Token = "0x6006F3A")]
	[Address(RVA = "0x10C1FA0", Offset = "0x10C0DA0", Length = "0x1A6")]
	public void UnRegisterEvents(params string[] eventNames)
	{
	}

	[Token(Token = "0x6006F3B")]
	[Address(RVA = "0x10C2150", Offset = "0x10C0F50", Length = "0x19F")]
	public void UnRegisterEvents(Component targetAgent, params string[] eventNames)
	{
	}

	[Token(Token = "0x6006F3C")]
	[Address(RVA = "0x10C22F0", Offset = "0x10C10F0", Length = "0x196")]
	public void UnregisterAllEvents()
	{
	}

	[Token(Token = "0x6006F3D")]
	[Address(RVA = "0x10C2490", Offset = "0x10C1290", Length = "0x18F")]
	public void UnregisterAllEvents(Component targetAgent)
	{
	}

	[Token(Token = "0x6006F3E")]
	[Address(RVA = "0x10C2620", Offset = "0x10C1420", Length = "0x295")]
	public static bool IsNewConnectionAllowed(Node sourceNode, Node targetNode, Connection refConnection = null)
	{
		return false;
	}

	[Token(Token = "0x6006F3F")]
	[Address(RVA = "0x430B50", Offset = "0x42F950", Length = "0x3")]
	protected virtual bool CanConnectToTarget(Node targetNode)
	{
		return false;
	}

	[Token(Token = "0x6006F40")]
	[Address(RVA = "0x430B50", Offset = "0x42F950", Length = "0x3")]
	protected virtual bool CanConnectFromSource(Node sourceNode)
	{
		return false;
	}

	[Token(Token = "0x6006F41")]
	[Address(RVA = "0x10C28C0", Offset = "0x10C16C0", Length = "0x209")]
	public static bool AreNodesConnected(Node a, Node b)
	{
		return false;
	}

	[Token(Token = "0x6006F42")]
	[Address(RVA = "0x10C2AD0", Offset = "0x10C18D0", Length = "0x63")]
	protected Coroutine StartCoroutine(IEnumerator routine)
	{
		return null;
	}

	[Token(Token = "0x6006F43")]
	[Address(RVA = "0x10C2B40", Offset = "0x10C1940", Length = "0x63")]
	protected void StopCoroutine(Coroutine routine)
	{
	}

	[Token(Token = "0x6006F44")]
	[Address(RVA = "0x10C2BB0", Offset = "0x10C19B0", Length = "0x242")]
	public Node[] GetParentNodes()
	{
		return null;
	}

	[Token(Token = "0x6006F45")]
	[Address(RVA = "0x10C2E00", Offset = "0x10C1C00", Length = "0x242")]
	public Node[] GetChildNodes()
	{
		return null;
	}

	[Token(Token = "0x6006F46")]
	[Address(RVA = "0x10C3050", Offset = "0x10C1E50", Length = "0x11F")]
	public bool IsChildOf(Node parentNode)
	{
		return false;
	}

	[Token(Token = "0x6006F47")]
	[Address(RVA = "0x10C3170", Offset = "0x10C1F70", Length = "0x11F")]
	public bool IsParentOf(Node childNode)
	{
		return false;
	}

	[Token(Token = "0x6006F48")]
	[Address(RVA = "0x4582A0", Offset = "0x4570A0", Length = "0x3")]
	public virtual string GetAdditionalState()
	{
		return null;
	}

	[Token(Token = "0x6006F49")]
	[Address(RVA = "0x10C0C40", Offset = "0x10BFA40", Length = "0x4")]
	protected virtual Status OnExecute(Component agent, IBlackboard blackboard)
	{
		return default(Status);
	}

	[Token(Token = "0x6006F4A")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	protected virtual void OnReset()
	{
	}

	[Token(Token = "0x6006F4B")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public virtual void OnParentConnected(int connectionIndex)
	{
	}

	[Token(Token = "0x6006F4C")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public virtual void OnParentDisconnected(int connectionIndex)
	{
	}

	[Token(Token = "0x6006F4D")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public virtual void OnChildConnected(int connectionIndex)
	{
	}

	[Token(Token = "0x6006F4E")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public virtual void OnChildDisconnected(int connectionIndex)
	{
	}

	[Token(Token = "0x6006F4F")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public virtual void OnGraphStarted()
	{
	}

	[Token(Token = "0x6006F50")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public virtual void OnGraphStoped()
	{
	}

	[Token(Token = "0x6006F51")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public virtual void OnGraphPaused()
	{
	}

	[Token(Token = "0x6006F52")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public virtual void OnGraphUnpaused()
	{
	}

	[Token(Token = "0x6006F53")]
	[Address(RVA = "0x10C3290", Offset = "0x10C2090", Length = "0x319")]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6006F54")]
	[Address(RVA = "0x10C35B0", Offset = "0x10C23B0", Length = "0xD4")]
	public virtual void OnDrawGizmos()
	{
	}

	[Token(Token = "0x6006F55")]
	[Address(RVA = "0x10C3690", Offset = "0x10C2490", Length = "0xD4")]
	public virtual void OnDrawGizmosSelected()
	{
	}
}
