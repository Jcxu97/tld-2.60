using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using MissionTypes;
using NodeCanvas.Framework;
using NodeCanvas.StateMachines;
using TLD.IntBackedUnit;
using UnityEngine;

namespace NodeCanvas;

[Token(Token = "0x2001018")]
public class NCUtils
{
	[Token(Token = "0x2001019")]
	public interface IItemRequirementsCollection
	{
		[Token(Token = "0x6006D57")]
		int GetNumGearWithName(string gearName);

		[Token(Token = "0x6006D58")]
		ItemWeight GetMeasurableTotalByType(string type);
	}

	[Token(Token = "0x400848A")]
	private const string START_FROM_RESTORE = "_startFromRestore";

	[Token(Token = "0x400848B")]
	private const string START_BY_MISSION_JUMP = "_startByMissionJump";

	[Token(Token = "0x400848C")]
	private static char[] m_FieldDividers;

	[Token(Token = "0x400848D")]
	private static int tmpVarIndex;

	[Token(Token = "0x400848E")]
	private static List<string> tagListsToRemove;

	[Token(Token = "0x6006D39")]
	[Address(RVA = "0x10A2840", Offset = "0x10A1640", Length = "0x84")]
	public static Variable GetOrAddVar(IBlackboard bb, string name, Type type)
	{
		return null;
	}

	[Token(Token = "0x6006D3A")]
	[Address(RVA = "0x1957860", Offset = "0x1956660", Length = "0x182")]
	public static Variable<T> GetOrAddVar<T>(IBlackboard bb, string name)
	{
		return null;
	}

	[Token(Token = "0x6006D3B")]
	[Address(RVA = "0x10A28D0", Offset = "0x10A16D0", Length = "0x1D9")]
	public static bool SetInitialStateByTag(FSM fsm, string tag)
	{
		return false;
	}

	[Token(Token = "0x6006D3C")]
	[Address(RVA = "0x10A2AB0", Offset = "0x10A18B0", Length = "0x14B")]
	public static bool EnterStateByTag(FSM fsm, string tag)
	{
		return false;
	}

	[Token(Token = "0x6006D3D")]
	[Address(RVA = "0x10A2C00", Offset = "0x10A1A00", Length = "0x56E")]
	public static GameObject SpawnChildGraph(GameObject prefab, GameObject parent)
	{
		return null;
	}

	[Token(Token = "0x6006D3E")]
	[Address(RVA = "0x10A3170", Offset = "0x10A1F70", Length = "0x37D")]
	public static void AddBlackboardMembersIfRequired(IBlackboard source, IBlackboard dest)
	{
	}

	[Token(Token = "0x6006D3F")]
	[Address(RVA = "0x1957610", Offset = "0x1956410", Length = "0x245")]
	public static T GetHostState<T>(ActionTask action, IBlackboard bb) where T : class
	{
		return null;
	}

	[Token(Token = "0x6006D40")]
	[Address(RVA = "0x10A34F0", Offset = "0x10A22F0", Length = "0x44")]
	public static string GetSerializedBlackboard(Blackboard bb)
	{
		return null;
	}

	[Token(Token = "0x6006D41")]
	[Address(RVA = "0x10A3540", Offset = "0x10A2340", Length = "0xD60")]
	public static string ProcessCommandBlockLines(IBlackboard blackboard, string[] lines, IBlackboard writeBlackboard = null)
	{
		return null;
	}

	[Token(Token = "0x6006D42")]
	[Address(RVA = "0x10A42B0", Offset = "0x10A30B0", Length = "0xA80")]
	public static string[] SubstituteVarsInStrings(IBlackboard blackboard, string[] lines)
	{
		return null;
	}

	[Token(Token = "0x6006D43")]
	[Address(RVA = "0x10A4D40", Offset = "0x10A3B40", Length = "0xA91")]
	private static object GetValue(string val, bool allowListDecl = true)
	{
		return null;
	}

	[Token(Token = "0x6006D44")]
	[Address(RVA = "0x10A57E0", Offset = "0x10A45E0", Length = "0x374")]
	private static object GetValue2(string[] fields)
	{
		return null;
	}

	[Token(Token = "0x6006D45")]
	[Address(RVA = "0x10A5B60", Offset = "0x10A4960", Length = "0x4E1")]
	private static object GetValue3(string[] fields)
	{
		return null;
	}

	[Token(Token = "0x6006D46")]
	[Address(RVA = "0x10A6050", Offset = "0x10A4E50", Length = "0x5BE")]
	private static object GetValue4(string[] fields)
	{
		return null;
	}

	[Token(Token = "0x6006D47")]
	[Address(RVA = "0x10A6610", Offset = "0x10A5410", Length = "0x3F1")]
	private static object GetValue5(string[] fields)
	{
		return null;
	}

	[Token(Token = "0x6006D48")]
	[Address(RVA = "0x10A6A10", Offset = "0x10A5810", Length = "0x232C")]
	public static string ProcessAssignmentString(IBlackboard readBlackboard, IBlackboard writeBlackboard, string str, int eq)
	{
		return null;
	}

	[Token(Token = "0x6006D49")]
	[Address(RVA = "0x10A8DA0", Offset = "0x10A7BA0", Length = "0x15B")]
	public static float SumMissionSelectionWeights(Dictionary<string, object>[] data)
	{
		return 0f;
	}

	[Token(Token = "0x6006D4A")]
	[Address(RVA = "0x10A8F00", Offset = "0x10A7D00", Length = "0x10A")]
	public static MissionManagerBase GetMissionManagerForFSM(IBlackboard blackboard)
	{
		return null;
	}

	[Token(Token = "0x6006D4B")]
	[Address(RVA = "0x10A9010", Offset = "0x10A7E10", Length = "0x15F")]
	public static string BuildFullStageName(string episode, string stage, string subStage, string worker1, string worker2)
	{
		return null;
	}

	[Token(Token = "0x6006D4C")]
	[Address(RVA = "0x10A9170", Offset = "0x10A7F70", Length = "0x208")]
	public static void LogStateInfo(string state, string info)
	{
	}

	[Token(Token = "0x6006D4D")]
	[Address(RVA = "0x10A9380", Offset = "0x10A8180", Length = "0x8FD")]
	public static bool ParseConditional(IBlackboard blackboard, string str, out Variable lhVar, out string op, out Variable rhVar)
	{
		lhVar = null;
		op = null;
		rhVar = null;
		return false;
	}

	[Token(Token = "0x6006D4E")]
	[Address(RVA = "0x10A9C80", Offset = "0x10A8A80", Length = "0x76D")]
	public static bool ParseConditionalForCommandBlock(IBlackboard blackboard, string str, out Variable lhVar, out string op, out object rhVal)
	{
		lhVar = null;
		op = null;
		rhVal = null;
		return false;
	}

	[Token(Token = "0x6006D4F")]
	[Address(RVA = "0x10AA3F0", Offset = "0x10A91F0", Length = "0x11B8")]
	public static bool TestConditional(Variable lhVar, string op, object rhVal)
	{
		return false;
	}

	[Token(Token = "0x6006D50")]
	[Address(RVA = "0x10AB5B0", Offset = "0x10AA3B0", Length = "0x40")]
	public static bool GetGameState(MissionGameState gameState)
	{
		return false;
	}

	[Token(Token = "0x6006D51")]
	[Address(RVA = "0x10AC700", Offset = "0x10AB500", Length = "0x122")]
	public static bool TestItemRequirements(Dictionary<string, List<InventoryItemRequirement>> requirementsDict, IItemRequirementsCollection collection, bool mustHaveAll, IBlackboard blackboard, ITaskSystem taskSystemOwner)
	{
		return false;
	}

	[Token(Token = "0x6006D52")]
	[Address(RVA = "0x10AC830", Offset = "0x10AB630", Length = "0x849")]
	public static int GetItemRequirementsMatchCount(Dictionary<string, List<InventoryItemRequirement>> requirementsDict, IItemRequirementsCollection collection, bool testAll, bool allowEarlyOut, IBlackboard blackboard, ITaskSystem taskSystemOwner)
	{
		return 0;
	}

	[Token(Token = "0x6006D53")]
	[Address(RVA = "0x10AD080", Offset = "0x10ABE80", Length = "0x24C")]
	public static Dictionary<string, List<InventoryItemRequirement>> BuildRequirementsDictionary(List<InventoryItemRequirement> reqItemList)
	{
		return null;
	}

	[Token(Token = "0x6006D54")]
	[Address(RVA = "0x10AD2D0", Offset = "0x10AC0D0", Length = "0xA5")]
	public static bool IsValidRequirementIndex(List<InventoryItemRequirement> items, int index)
	{
		return false;
	}

	[Token(Token = "0x6006D55")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public NCUtils()
	{
	}
}
