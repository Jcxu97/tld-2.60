using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using NodeCanvas.Framework.Internal;
using ParadoxNotion;
using UnityEngine;

namespace NodeCanvas.Framework;

[Serializable]
[Token(Token = "0x2001051")]
public abstract class Graph : ScriptableObject, ITaskSystem, ISerializationCallbackReceiver
{
	[SerializeField]
	[Token(Token = "0x4008529")]
	[FieldOffset(Offset = "0x18")]
	private string _serializedGraph;

	[SerializeField]
	[Token(Token = "0x400852A")]
	[FieldOffset(Offset = "0x20")]
	private List<UnityEngine.Object> _objectReferences;

	[SerializeField]
	[Token(Token = "0x400852B")]
	[FieldOffset(Offset = "0x28")]
	private bool _deserializationFailed;

	[NonSerialized]
	[Token(Token = "0x400852C")]
	[FieldOffset(Offset = "0x29")]
	private bool hasDeserialized;

	[Token(Token = "0x400852F")]
	[FieldOffset(Offset = "0x30")]
	private string _category;

	[Token(Token = "0x4008530")]
	[FieldOffset(Offset = "0x38")]
	private string _comments;

	[Token(Token = "0x4008531")]
	[FieldOffset(Offset = "0x40")]
	private Vector2 _translation;

	[Token(Token = "0x4008532")]
	[FieldOffset(Offset = "0x48")]
	private float _zoomFactor;

	[Token(Token = "0x4008533")]
	[FieldOffset(Offset = "0x50")]
	private List<Node> _nodes;

	[Token(Token = "0x4008534")]
	[FieldOffset(Offset = "0x58")]
	private List<CanvasGroup> _canvasGroups;

	[Token(Token = "0x4008535")]
	[FieldOffset(Offset = "0x60")]
	private BlackboardSource _localBlackboard;

	[NonSerialized]
	[Token(Token = "0x4008537")]
	[FieldOffset(Offset = "0x70")]
	private Component _agent;

	[NonSerialized]
	[Token(Token = "0x4008538")]
	[FieldOffset(Offset = "0x78")]
	private IBlackboard _blackboard;

	[NonSerialized]
	[Token(Token = "0x4008539")]
	private static List<Graph> runningGraphs;

	[NonSerialized]
	[Token(Token = "0x400853A")]
	[FieldOffset(Offset = "0x80")]
	private float timeStarted;

	[NonSerialized]
	[Token(Token = "0x400853B")]
	[FieldOffset(Offset = "0x84")]
	private bool initialReferencesUpdated;

	[NonSerialized]
	[Token(Token = "0x400853C")]
	[FieldOffset(Offset = "0x85")]
	private bool _isAutoUpdated;

	[NonSerialized]
	[Token(Token = "0x400853D")]
	[FieldOffset(Offset = "0x86")]
	private bool _isRunning;

	[NonSerialized]
	[Token(Token = "0x400853E")]
	[FieldOffset(Offset = "0x87")]
	private bool _isPaused;

	[NonSerialized]
	[Token(Token = "0x400853F")]
	[FieldOffset(Offset = "0x88")]
	private float deltaTimeAccumulated;

	[Token(Token = "0x17000793")]
	public abstract Type baseNodeType
	{
		[Token(Token = "0x6006E69")]
		get;
	}

	[Token(Token = "0x17000794")]
	public abstract bool requiresAgent
	{
		[Token(Token = "0x6006E6A")]
		get;
	}

	[Token(Token = "0x17000795")]
	public abstract bool requiresPrimeNode
	{
		[Token(Token = "0x6006E6B")]
		get;
	}

	[Token(Token = "0x17000796")]
	public abstract bool isTree
	{
		[Token(Token = "0x6006E6C")]
		get;
	}

	[Token(Token = "0x17000797")]
	public abstract bool useLocalBlackboard
	{
		[Token(Token = "0x6006E6D")]
		get;
	}

	[Token(Token = "0x17000798")]
	public abstract bool canAcceptVariableDrops
	{
		[Token(Token = "0x6006E6E")]
		get;
	}

	[Token(Token = "0x17000799")]
	public new string name
	{
		[Token(Token = "0x6006E6F")]
		[Address(RVA = "0x10B87B0", Offset = "0x10B75B0", Length = "0x9")]
		get
		{
			return null;
		}
		[Token(Token = "0x6006E70")]
		[Address(RVA = "0x10B87C0", Offset = "0x10B75C0", Length = "0x8")]
		set
		{
		}
	}

	[Token(Token = "0x1700079A")]
	public string category
	{
		[Token(Token = "0x6006E71")]
		[Address(RVA = "0x457420", Offset = "0x456220", Length = "0x5")]
		get
		{
			return null;
		}
		[Token(Token = "0x6006E72")]
		[Address(RVA = "0x4B1CB0", Offset = "0x4B0AB0", Length = "0x52")]
		set
		{
		}
	}

	[Token(Token = "0x1700079B")]
	public string comments
	{
		[Token(Token = "0x6006E73")]
		[Address(RVA = "0x4A7D50", Offset = "0x4A6B50", Length = "0x5")]
		get
		{
			return null;
		}
		[Token(Token = "0x6006E74")]
		[Address(RVA = "0x509400", Offset = "0x508200", Length = "0x52")]
		set
		{
		}
	}

	[Token(Token = "0x1700079C")]
	public float elapsedTime
	{
		[Token(Token = "0x6006E75")]
		[Address(RVA = "0x10B87D0", Offset = "0x10B75D0", Length = "0x6E")]
		get
		{
			return 0f;
		}
	}

	[Token(Token = "0x1700079D")]
	public float deltaTime
	{
		[Token(Token = "0x6006E76")]
		[Address(RVA = "0x760E30", Offset = "0x75FC30", Length = "0x9")]
		get
		{
			return 0f;
		}
	}

	[Token(Token = "0x1700079E")]
	public bool isRunning
	{
		[Token(Token = "0x6006E77")]
		[Address(RVA = "0x10B8840", Offset = "0x10B7640", Length = "0x8")]
		get
		{
			return false;
		}
		[Token(Token = "0x6006E78")]
		[Address(RVA = "0x10B8850", Offset = "0x10B7650", Length = "0x7")]
		private set
		{
		}
	}

	[Token(Token = "0x1700079F")]
	public bool isPaused
	{
		[Token(Token = "0x6006E79")]
		[Address(RVA = "0x10B8860", Offset = "0x10B7660", Length = "0x8")]
		get
		{
			return false;
		}
		[Token(Token = "0x6006E7A")]
		[Address(RVA = "0x10B8870", Offset = "0x10B7670", Length = "0x7")]
		private set
		{
		}
	}

	[Token(Token = "0x170007A0")]
	public bool isAutoUpdated
	{
		[Token(Token = "0x6006E7B")]
		[Address(RVA = "0x10B8880", Offset = "0x10B7680", Length = "0x8")]
		get
		{
			return false;
		}
		[Token(Token = "0x6006E7C")]
		[Address(RVA = "0x5F76E0", Offset = "0x5F64E0", Length = "0x7")]
		private set
		{
		}
	}

	[Token(Token = "0x170007A1")]
	public List<Node> allNodes
	{
		[Token(Token = "0x6006E7D")]
		[Address(RVA = "0x669640", Offset = "0x668440", Length = "0x5")]
		get
		{
			return null;
		}
		[Token(Token = "0x6006E7E")]
		[Address(RVA = "0x6339B0", Offset = "0x6327B0", Length = "0xED7")]
		private set
		{
		}
	}

	[Token(Token = "0x170007A2")]
	public Node primeNode
	{
		[Token(Token = "0x6006E7F")]
		[Address(RVA = "0x10B8890", Offset = "0x10B7690", Length = "0xBE")]
		get
		{
			return null;
		}
		[Token(Token = "0x6006E80")]
		[Address(RVA = "0x10B8950", Offset = "0x10B7750", Length = "0x14B")]
		set
		{
		}
	}

	[Token(Token = "0x170007A3")]
	public List<CanvasGroup> canvasGroups
	{
		[Token(Token = "0x6006E81")]
		[Address(RVA = "0x6BCD40", Offset = "0x6BBB40", Length = "0x5")]
		get
		{
			return null;
		}
		[Token(Token = "0x6006E82")]
		[Address(RVA = "0x95D320", Offset = "0x95C120", Length = "0x52")]
		set
		{
		}
	}

	[Token(Token = "0x170007A4")]
	public Vector2 translation
	{
		[Token(Token = "0x6006E83")]
		[Address(RVA = "0x10B8AA0", Offset = "0x10B78A0", Length = "0x13")]
		get
		{
			return default(Vector2);
		}
		[Token(Token = "0x6006E84")]
		[Address(RVA = "0x10B8AC0", Offset = "0x10B78C0", Length = "0x5")]
		set
		{
		}
	}

	[Token(Token = "0x170007A5")]
	public float zoomFactor
	{
		[Token(Token = "0x6006E85")]
		[Address(RVA = "0x5737C0", Offset = "0x5725C0", Length = "0x6")]
		get
		{
			return 0f;
		}
		[Token(Token = "0x6006E86")]
		[Address(RVA = "0x5737D0", Offset = "0x5725D0", Length = "0x6")]
		set
		{
		}
	}

	[Token(Token = "0x170007A6")]
	public Component agent
	{
		[Token(Token = "0x6006E87")]
		[Address(RVA = "0x502690", Offset = "0x501490", Length = "0x5")]
		get
		{
			return null;
		}
		[Token(Token = "0x6006E88")]
		[Address(RVA = "0x5026A0", Offset = "0x5014A0", Length = "0x52")]
		private set
		{
		}
	}

	[Token(Token = "0x170007A7")]
	public IBlackboard blackboard
	{
		[Token(Token = "0x6006E89")]
		[Address(RVA = "0x10B8AD0", Offset = "0x10B78D0", Length = "0x39")]
		get
		{
			return null;
		}
		[Token(Token = "0x6006E8A")]
		[Address(RVA = "0x10B8B10", Offset = "0x10B7910", Length = "0x4C")]
		set
		{
		}
	}

	[Token(Token = "0x170007A8")]
	public BlackboardSource localBlackboard
	{
		[Token(Token = "0x6006E8B")]
		[Address(RVA = "0x10B8B60", Offset = "0x10B7960", Length = "0x138")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170007A9")]
	UnityEngine.Object ITaskSystem.contextObject
	{
		[Token(Token = "0x6006E8C")]
		[Address(RVA = "0x10AD7C0", Offset = "0x10AC5C0", Length = "0x4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x14000024")]
	public static event Action<Graph> onGraphSerialized
	{
		[CompilerGenerated]
		[Token(Token = "0x6006E4D")]
		[Address(RVA = "0x10B6D30", Offset = "0x10B5B30", Length = "0x1B7")]
		add
		{
		}
		[CompilerGenerated]
		[Token(Token = "0x6006E4E")]
		[Address(RVA = "0x10B6EF0", Offset = "0x10B5CF0", Length = "0x1B7")]
		remove
		{
		}
	}

	[Token(Token = "0x14000025")]
	public static event Action<Graph> onGraphDeserialized
	{
		[CompilerGenerated]
		[Token(Token = "0x6006E4F")]
		[Address(RVA = "0x10B70B0", Offset = "0x10B5EB0", Length = "0x1C6")]
		add
		{
		}
		[CompilerGenerated]
		[Token(Token = "0x6006E50")]
		[Address(RVA = "0x10B7280", Offset = "0x10B6080", Length = "0x1C6")]
		remove
		{
		}
	}

	[Token(Token = "0x14000026")]
	public event Action<bool> onFinish
	{
		[CompilerGenerated]
		[Token(Token = "0x6006E67")]
		[Address(RVA = "0x10B84D0", Offset = "0x10B72D0", Length = "0x166")]
		add
		{
		}
		[CompilerGenerated]
		[Token(Token = "0x6006E68")]
		[Address(RVA = "0x10B8640", Offset = "0x10B7440", Length = "0x166")]
		remove
		{
		}
	}

	[Token(Token = "0x6006E51")]
	[Address(RVA = "0x10B7450", Offset = "0x10B6250", Length = "0x7")]
	void ISerializationCallbackReceiver.OnBeforeSerialize()
	{
	}

	[Token(Token = "0x6006E52")]
	[Address(RVA = "0x10B7460", Offset = "0x10B6260", Length = "0x7")]
	void ISerializationCallbackReceiver.OnAfterDeserialize()
	{
	}

	[Token(Token = "0x6006E53")]
	[Address(RVA = "0x10B7470", Offset = "0x10B6270", Length = "0xE")]
	protected void OnEnable()
	{
	}

	[Token(Token = "0x6006E54")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	protected void OnDisable()
	{
	}

	[Token(Token = "0x6006E55")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	protected void OnDestroy()
	{
	}

	[Token(Token = "0x6006E56")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	protected void OnValidate()
	{
	}

	[Token(Token = "0x6006E57")]
	[Address(RVA = "0x10B7480", Offset = "0x10B6280", Length = "0x7")]
	protected void Reset()
	{
	}

	[Token(Token = "0x6006E58")]
	[Address(RVA = "0x10B7490", Offset = "0x10B6290", Length = "0xEF")]
	public void Serialize()
	{
	}

	[Token(Token = "0x6006E59")]
	[Address(RVA = "0x10B7580", Offset = "0x10B6380", Length = "0x14A")]
	public void Deserialize()
	{
	}

	[Token(Token = "0x6006E5A")]
	[Address(RVA = "0x10B76D0", Offset = "0x10B64D0", Length = "0x1DB")]
	public string Serialize(bool pretyJson, List<UnityEngine.Object> objectReferences)
	{
		return null;
	}

	[Token(Token = "0x6006E5B")]
	[Address(RVA = "0x10B78B0", Offset = "0x10B66B0", Length = "0x1CD")]
	public GraphSerializationData Deserialize(string serializedGraph, bool validate, List<UnityEngine.Object> objectReferences)
	{
		return null;
	}

	[Token(Token = "0x6006E5C")]
	[Address(RVA = "0x10B7A80", Offset = "0x10B6880", Length = "0x30C")]
	private bool LoadGraphData(GraphSerializationData data, bool validate)
	{
		return false;
	}

	[Token(Token = "0x6006E5D")]
	[Address(RVA = "0x4582A0", Offset = "0x4570A0", Length = "0x3")]
	public virtual object OnDerivedDataSerialization()
	{
		return null;
	}

	[Token(Token = "0x6006E5E")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public virtual void OnDerivedDataDeserialization(object data)
	{
	}

	[Token(Token = "0x6006E5F")]
	[Address(RVA = "0x10B7D90", Offset = "0x10B6B90", Length = "0x13E")]
	public void GetSerializationData(out string json, out List<UnityEngine.Object> references)
	{
		json = null;
		references = null;
	}

	[Token(Token = "0x6006E60")]
	[Address(RVA = "0x40E120", Offset = "0x40CF20", Length = "0x52")]
	public void SetSerializationObjectReferences(List<UnityEngine.Object> references)
	{
	}

	[Token(Token = "0x6006E61")]
	[Address(RVA = "0x10B7ED0", Offset = "0x10B6CD0", Length = "0xD7")]
	public string SerializeLocalBlackboard()
	{
		return null;
	}

	[Token(Token = "0x6006E62")]
	[Address(RVA = "0x10B7FB0", Offset = "0x10B6DB0", Length = "0x19F")]
	public bool DeserializeLocalBlackboard(string json)
	{
		return false;
	}

	[Token(Token = "0x6006E63")]
	[Address(RVA = "0x18E2EC0", Offset = "0x18E1CC0", Length = "0xC8")]
	public static T Clone<T>(T graph) where T : Graph
	{
		return null;
	}

	[Token(Token = "0x6006E64")]
	[Address(RVA = "0x10B8150", Offset = "0x10B6F50", Length = "0x4E")]
	public void CopySerialized(Graph target)
	{
	}

	[Token(Token = "0x6006E65")]
	[Address(RVA = "0x10B81A0", Offset = "0x10B6FA0", Length = "0x329")]
	public void Validate()
	{
	}

	[Token(Token = "0x6006E66")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	protected virtual void OnGraphValidate()
	{
	}

	[Token(Token = "0x6006E8D")]
	[Address(RVA = "0x10B8CA0", Offset = "0x10B7AA0", Length = "0xFA9")]
	public static List<Node> CloneNodes(List<Node> originalNodes, Graph targetGraph = null, Vector2 originPosition = default(Vector2))
	{
		return null;
	}

	[Token(Token = "0x6006E8E")]
	[Address(RVA = "0x10B9C50", Offset = "0x10B8A50", Length = "0xFD")]
	public void UpdateReferencesFromOwner(GraphOwner owner)
	{
	}

	[Token(Token = "0x6006E8F")]
	[Address(RVA = "0x10B9D50", Offset = "0x10B8B50", Length = "0x304")]
	public void UpdateReferences(Component newAgent, IBlackboard newBlackboard)
	{
	}

	[Token(Token = "0x6006E90")]
	[Address(RVA = "0x10BA060", Offset = "0x10B8E60", Length = "0x136")]
	private void UpdateNodeBBFields()
	{
	}

	[Token(Token = "0x6006E91")]
	[Address(RVA = "0x10BA1A0", Offset = "0x10B8FA0", Length = "0x214")]
	public void SendTaskOwnerDefaults()
	{
	}

	[Token(Token = "0x6006E92")]
	[Address(RVA = "0x10BA3C0", Offset = "0x10B91C0", Length = "0x593")]
	public void UpdateNodeIDs(bool alsoReorderList)
	{
	}

	[Token(Token = "0x6006E93")]
	[Address(RVA = "0x10BA960", Offset = "0x10B9760", Length = "0x1AA")]
	private int AssignNodeID(Node node, int lastID, ref Node[] parsed)
	{
		return 0;
	}

	[Token(Token = "0x6006E94")]
	[Address(RVA = "0x10BAB10", Offset = "0x10B9910", Length = "0x928")]
	public void StartGraph(Component newAgent, IBlackboard newBlackboard, bool autoUpdate, Action<bool> callback = null)
	{
	}

	[Token(Token = "0x6006E95")]
	[Address(RVA = "0x10BB440", Offset = "0x10BA240", Length = "0x460")]
	public void Stop(bool success = true)
	{
	}

	[Token(Token = "0x6006E96")]
	[Address(RVA = "0x10BB8B0", Offset = "0x10BA6B0", Length = "0x373")]
	public void Pause()
	{
	}

	[Token(Token = "0x6006E97")]
	[Address(RVA = "0x10BBC30", Offset = "0x10BAA30", Length = "0x1B")]
	public void UpdateGraph()
	{
	}

	[Token(Token = "0x6006E98")]
	[Address(RVA = "0x10BBC50", Offset = "0x10BAA50", Length = "0x9")]
	public void SetAccumulatedDeltaTime(float deltaTime)
	{
	}

	[Token(Token = "0x6006E99")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	protected virtual void OnGraphStarted()
	{
	}

	[Token(Token = "0x6006E9A")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	protected virtual void OnGraphUpdate()
	{
	}

	[Token(Token = "0x6006E9B")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	protected virtual void OnGraphStoped()
	{
	}

	[Token(Token = "0x6006E9C")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	protected virtual void OnGraphPaused()
	{
	}

	[Token(Token = "0x6006E9D")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	protected virtual void OnGraphUnpaused()
	{
	}

	[Token(Token = "0x6006E9E")]
	[Address(RVA = "0x10BBC60", Offset = "0x10BAA60", Length = "0x24C")]
	public void SendEvent(EventData eventData, object sender)
	{
	}

	[Token(Token = "0x6006E9F")]
	[Address(RVA = "0x10BBEB0", Offset = "0x10BACB0", Length = "0x24D")]
	public static void SendGlobalEvent(EventData eventData, object sender)
	{
	}

	[Token(Token = "0x6006EA0")]
	[Address(RVA = "0x10BC100", Offset = "0x10BAF00", Length = "0xFE")]
	public Node GetNodeWithID(int searchID)
	{
		return null;
	}

	[Token(Token = "0x6006EA1")]
	[Address(RVA = "0x18E3440", Offset = "0x18E2240", Length = "0xBE")]
	public List<T> GetAllNodesOfType<T>() where T : Node
	{
		return null;
	}

	[Token(Token = "0x6006EA2")]
	[Address(RVA = "0x18E3B50", Offset = "0x18E2950", Length = "0x1DA")]
	public T GetNodeWithTag<T>(string tagName) where T : Node
	{
		return null;
	}

	[Token(Token = "0x6006EA3")]
	[Address(RVA = "0x18E3D30", Offset = "0x18E2B30", Length = "0x29F")]
	public List<T> GetNodesWithTag<T>(string tagName) where T : Node
	{
		return null;
	}

	[Token(Token = "0x6006EA4")]
	[Address(RVA = "0x18E3500", Offset = "0x18E2300", Length = "0x265")]
	public List<T> GetAllTagedNodes<T>() where T : Node
	{
		return null;
	}

	[Token(Token = "0x6006EA5")]
	[Address(RVA = "0x10BC200", Offset = "0x10BB000", Length = "0x1EC")]
	public List<Node> GetRootNodes()
	{
		return null;
	}

	[Token(Token = "0x6006EA6")]
	[Address(RVA = "0x10BC3F0", Offset = "0x10BB1F0", Length = "0x1EC")]
	public List<Node> GetLeafNodes()
	{
		return null;
	}

	[Token(Token = "0x6006EA7")]
	[Address(RVA = "0x18E2F90", Offset = "0x18E1D90", Length = "0x4A9")]
	public List<T> GetAllNestedGraphs<T>(bool recursive) where T : Graph
	{
		return null;
	}

	[Token(Token = "0x6006EA8")]
	[Address(RVA = "0x10BC5E0", Offset = "0x10BB3E0", Length = "0x31E")]
	public List<Graph> GetAllInstancedNestedGraphs()
	{
		return null;
	}

	[Token(Token = "0x6006EA9")]
	[Address(RVA = "0x10BC900", Offset = "0x10BB700", Length = "0x281")]
	public static Graph GetElementGraph(object obj)
	{
		return null;
	}

	[Token(Token = "0x6006EAA")]
	[Address(RVA = "0x18E3770", Offset = "0x18E2570", Length = "0x3DB")]
	public List<T> GetAllTasksOfType<T>() where T : Task
	{
		return null;
	}

	[Token(Token = "0x6006EAB")]
	[Address(RVA = "0x18E3FD0", Offset = "0x18E2DD0", Length = "0x21E")]
	private void GetObjectTasks<T>(object obj, ref List<T> tasks) where T : Task
	{
	}

	[Token(Token = "0x6006EAC")]
	[Address(RVA = "0x10BCB90", Offset = "0x10BB990", Length = "0x251")]
	public HierarchyTree.Element GetFlatGraphHierarchy()
	{
		return null;
	}

	[Token(Token = "0x6006EAD")]
	[Address(RVA = "0x10BCDF0", Offset = "0x10BBBF0", Length = "0x1C9")]
	public HierarchyTree.Element GetFullGraphHierarchy()
	{
		return null;
	}

	[Token(Token = "0x6006EAE")]
	[Address(RVA = "0x10BCFC0", Offset = "0x10BBDC0", Length = "0x2AA")]
	public HierarchyTree.Element GetNestedGraphHierarchy()
	{
		return null;
	}

	[Token(Token = "0x6006EAF")]
	[Address(RVA = "0x10BD270", Offset = "0x10BC070", Length = "0x1AA")]
	private HierarchyTree.Element GetTreeNodeElement(Node node, bool recurse, ref int lastID)
	{
		return null;
	}

	[Token(Token = "0x6006EB0")]
	[Address(RVA = "0x10BD420", Offset = "0x10BC220", Length = "0x37F")]
	public static HierarchyTree.Element GetTaskAndParametersStructureInTarget(object obj)
	{
		return null;
	}

	[Token(Token = "0x6006EB1")]
	[Address(RVA = "0x10BD7A0", Offset = "0x10BC5A0", Length = "0x7C")]
	public IGraphElement GetTaskParentElement(Task targetTask)
	{
		return null;
	}

	[Token(Token = "0x6006EB2")]
	[Address(RVA = "0x10BD820", Offset = "0x10BC620", Length = "0x7C")]
	public IGraphElement GetParameterParentElement(BBParameter targetParameter)
	{
		return null;
	}

	[Token(Token = "0x6006EB3")]
	[Address(RVA = "0x10BD8A0", Offset = "0x10BC6A0", Length = "0x9D")]
	public static Task[] GetTasksInElement(IGraphElement target)
	{
		return null;
	}

	[Token(Token = "0x6006EB4")]
	[Address(RVA = "0x10BD940", Offset = "0x10BC740", Length = "0x9D")]
	public static BBParameter[] GetParametersInElement(IGraphElement target)
	{
		return null;
	}

	[Token(Token = "0x6006EB5")]
	[Address(RVA = "0x10BD9E0", Offset = "0x10BC7E0", Length = "0x232")]
	public BBParameter[] GetDefinedParameters()
	{
		return null;
	}

	[Token(Token = "0x6006EB6")]
	[Address(RVA = "0x10BDC20", Offset = "0x10BCA20", Length = "0x69")]
	public void PromoteDefinedParametersToVariables(IBlackboard bb)
	{
	}

	[Token(Token = "0x6006EB7")]
	[Address(RVA = "0x18E2CA0", Offset = "0x18E1AA0", Length = "0x110")]
	public T AddNode<T>() where T : Node
	{
		return null;
	}

	[Token(Token = "0x6006EB8")]
	[Address(RVA = "0x18E2DC0", Offset = "0x18E1BC0", Length = "0xF4")]
	public T AddNode<T>(Vector2 pos) where T : Node
	{
		return null;
	}

	[Token(Token = "0x6006EB9")]
	[Address(RVA = "0x10BDC90", Offset = "0x10BCA90", Length = "0x38")]
	public Node AddNode(Type nodeType)
	{
		return null;
	}

	[Token(Token = "0x6006EBA")]
	[Address(RVA = "0x10BDCD0", Offset = "0x10BCAD0", Length = "0x424")]
	public Node AddNode(Type nodeType, Vector2 pos)
	{
		return null;
	}

	[Token(Token = "0x6006EBB")]
	[Address(RVA = "0x10BE100", Offset = "0x10BCF00", Length = "0x626")]
	public void RemoveNode(Node node, bool recordUndo = true, bool force = false)
	{
	}

	[Token(Token = "0x6006EBC")]
	[Address(RVA = "0x10BE730", Offset = "0x10BD530", Length = "0x9E")]
	public Connection ConnectNodes(Node sourceNode, Node targetNode, int sourceIndex = -1, int targetIndex = -1)
	{
		return null;
	}

	[Token(Token = "0x6006EBD")]
	[Address(RVA = "0x10BE7D0", Offset = "0x10BD5D0", Length = "0x228")]
	public void RemoveConnection(Connection connection, bool recordUndo = true)
	{
	}

	[Token(Token = "0x6006EBE")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public void RecordUndo(string name)
	{
	}

	[Token(Token = "0x6006EBF")]
	[Address(RVA = "0x10BEA00", Offset = "0x10BD800", Length = "0xEC")]
	public void ClearGraph()
	{
	}

	[Token(Token = "0x6006EC0")]
	[Address(RVA = "0x10BEAF0", Offset = "0x10BD8F0", Length = "0x194")]
	protected Graph()
	{
	}
}
