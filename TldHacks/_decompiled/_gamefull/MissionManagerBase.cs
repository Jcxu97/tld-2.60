using Cpp2ILInjected;
using NodeCanvas.Framework;
using NodeCanvas.StateMachines;
using ParadoxNotion;

[Token(Token = "0x2000821")]
public abstract class MissionManagerBase
{
	[Token(Token = "0x400558E")]
	[FieldOffset(Offset = "0x10")]
	public FSMOwner m_FSMOwner;

	[Token(Token = "0x400558F")]
	[FieldOffset(Offset = "0x18")]
	public string m_MissionId;

	[Token(Token = "0x4005590")]
	[FieldOffset(Offset = "0x20")]
	public FSMHierarchy m_FSMHierarchy;

	[Token(Token = "0x4005591")]
	[FieldOffset(Offset = "0x28")]
	public string[] m_JumpToIds;

	[Token(Token = "0x4005592")]
	[FieldOffset(Offset = "0x30")]
	public bool m_IsActive;

	[Token(Token = "0x4005593")]
	[FieldOffset(Offset = "0x31")]
	public bool m_WasCompleted;

	[Token(Token = "0x4005594")]
	[FieldOffset(Offset = "0x34")]
	private int m_NextIdIndex;

	[Token(Token = "0x4005595")]
	[FieldOffset(Offset = "0x38")]
	private int m_NextFSMIndex;

	[Token(Token = "0x4005596")]
	private static int m_NextId;

	[Token(Token = "0x4005597")]
	[FieldOffset(Offset = "0x3C")]
	public int m_MyId;

	[Token(Token = "0x4005598")]
	[FieldOffset(Offset = "0x40")]
	private MissionManagerSaveProxy m_DeserializeData;

	[Token(Token = "0x4005599")]
	private static MissionManagerSaveProxy m_MissionManagerSaveProxy;

	[Token(Token = "0x6004B8B")]
	[Address(RVA = "0xD56CC0", Offset = "0xD55AC0", Length = "0x31E")]
	protected MissionManagerBase(string missionId, FSMOwner fsmOwner)
	{
	}

	[Token(Token = "0x6004B8C")]
	[Address(RVA = "0xD56FE0", Offset = "0xD55DE0", Length = "0x2E")]
	public void Start()
	{
	}

	[Token(Token = "0x6004B8D")]
	[Address(RVA = "0xD57010", Offset = "0xD55E10", Length = "0x175")]
	public void Stop()
	{
	}

	[Token(Token = "0x6004B8E")]
	[Address(RVA = "0xD57190", Offset = "0xD55F90", Length = "0x2C1")]
	public void InitiateJumpTo(string[] jumpToIds, FSMHierarchy.Rank firstRank, string missionConfigData)
	{
	}

	[Token(Token = "0x6004B8F")]
	[Address(RVA = "0xD57460", Offset = "0xD56260", Length = "0x5C")]
	public string GetNextJumpToId()
	{
		return null;
	}

	[Token(Token = "0x6004B90")]
	[Address(RVA = "0xD574C0", Offset = "0xD562C0", Length = "0xA")]
	public FSMHierarchy.Rank AssignFSMRank()
	{
		return default(FSMHierarchy.Rank);
	}

	[Token(Token = "0x6004B91")]
	[Address(RVA = "0xD574D0", Offset = "0xD562D0", Length = "0x95")]
	public void PreRegisterGraphOwner(GraphOwner graphOwner)
	{
	}

	[Token(Token = "0x6004B92")]
	[Address(RVA = "0xD57570", Offset = "0xD56370", Length = "0xA2")]
	public void RegisterFSM(FSMHierarchy.Rank rank, FSM fsm, GraphOwner graphOwner = null)
	{
	}

	[Token(Token = "0x6004B93")]
	[Address(RVA = "0xD57620", Offset = "0xD56420", Length = "0x4A")]
	public void UnregisterFSM(FSMHierarchy.Rank rank)
	{
	}

	[Token(Token = "0x6004B94")]
	[Address(RVA = "0xD57670", Offset = "0xD56470", Length = "0x180")]
	public void PreRegisterChildGraph(FSMHierarchy.Rank rank, GraphOwner childGraph)
	{
	}

	[Token(Token = "0x6004B95")]
	[Address(RVA = "0xD57800", Offset = "0xD56600", Length = "0x172")]
	public void RegisterChildGraph(FSMHierarchy.Rank rank, GraphOwner childGraph)
	{
	}

	[Token(Token = "0x6004B96")]
	[Address(RVA = "0xD57980", Offset = "0xD56780", Length = "0x71")]
	public void UnregisterChildGraph(FSMHierarchy.Rank rank)
	{
	}

	[Token(Token = "0x6004B97")]
	[Address(RVA = "0xD57A00", Offset = "0xD56800", Length = "0x560")]
	public string Serialize()
	{
		return null;
	}

	[Token(Token = "0x6004B98")]
	[Address(RVA = "0xD57F70", Offset = "0xD56D70", Length = "0xBC")]
	public void Deserialize(string text)
	{
	}

	[Token(Token = "0x6004B99")]
	[Address(RVA = "0xD58030", Offset = "0xD56E30", Length = "0x52")]
	public void FlushDeserializeData()
	{
	}

	[Token(Token = "0x6004B9A")]
	[Address(RVA = "0xD58090", Offset = "0xD56E90", Length = "0x44")]
	public void SendMissionEvent(string eventString)
	{
	}

	[Token(Token = "0x6004B9B")]
	[Address(RVA = "0xD580E0", Offset = "0xD56EE0", Length = "0x4E")]
	public void SendMissionEvent(EventData ev)
	{
	}

	[Token(Token = "0x6004B9C")]
	[Address(RVA = "0x1954120", Offset = "0x1952F20", Length = "0x166")]
	public void SendMissionEvent<T>(string eventString, T value)
	{
	}

	[Token(Token = "0x6004B9D")]
	[Address(RVA = "0x1954510", Offset = "0x1953310", Length = "0x138")]
	public void SetTopLevelBlackboardVar<T>(string varName, T value)
	{
	}

	[Token(Token = "0x6004B9E")]
	[Address(RVA = "0x1954290", Offset = "0x1953090", Length = "0xF0")]
	public void SetMissionBlackboardVar<T>(string varName, T value, FSMHierarchy.Rank rank = FSMHierarchy.Rank.SubStage)
	{
	}

	[Token(Token = "0x6004B9F")]
	[Address(RVA = "0x1953AF0", Offset = "0x19528F0", Length = "0x2A4")]
	public bool GetMissionBlackboardVar<T>(string varName, out T value, FSMHierarchy.Rank rank = FSMHierarchy.Rank.SubStage)
	{
		value = default(T);
		return false;
	}

	[Token(Token = "0x6004BA0")]
	[Address(RVA = "0xD58130", Offset = "0xD56F30", Length = "0x49A")]
	public GraphOwner GetMissionGraphOwner(string graphName)
	{
		return null;
	}

	[Token(Token = "0x6004BA1")]
	[Address(RVA = "0xD585D0", Offset = "0xD573D0", Length = "0x56D")]
	public bool TryGetBlackboardVarAsFloatFullSearch(string varName, out float result)
	{
		result = default(float);
		return false;
	}
}
