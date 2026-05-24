using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;

[RequireComponent(typeof(Animator))]
[Token(Token = "0x20001A4")]
public class PersistentControllerState : MonoBehaviour
{
	[Token(Token = "0x4000EEE")]
	[FieldOffset(Offset = "0x20")]
	private Animator m_Animator;

	[Token(Token = "0x4000EEF")]
	private static List<PersistentControllerState> s_PersistentControllerStates;

	[Token(Token = "0x4000EF0")]
	[FieldOffset(Offset = "0x28")]
	private string m_Id;

	[Token(Token = "0x4000EF1")]
	private const int INVALIDLAYERINDEX = -1;

	[Token(Token = "0x4000EF2")]
	[FieldOffset(Offset = "0x30")]
	private PersistentControllerStateSaveData m_RestoreData;

	[Token(Token = "0x6000F76")]
	[Address(RVA = "0x614950", Offset = "0x613750", Length = "0x2FF")]
	public void Awake()
	{
	}

	[Token(Token = "0x6000F77")]
	[Address(RVA = "0x614C50", Offset = "0x613A50", Length = "0x11D")]
	public void Update()
	{
	}

	[Token(Token = "0x6000F78")]
	[Address(RVA = "0x614D70", Offset = "0x613B70", Length = "0x82")]
	public void OnDestroy()
	{
	}

	[Token(Token = "0x6000F79")]
	[Address(RVA = "0x4B1CB0", Offset = "0x4B0AB0", Length = "0x52")]
	private void RequestRestoreState(PersistentControllerStateSaveData saveData)
	{
	}

	[Token(Token = "0x6000F7A")]
	[Address(RVA = "0x614E00", Offset = "0x613C00", Length = "0x489")]
	public static string SerializeAll()
	{
		return null;
	}

	[Token(Token = "0x6000F7B")]
	[Address(RVA = "0x615290", Offset = "0x614090", Length = "0x24E")]
	private static void SaveParameters(Animator animator, PersistentControllerStateSaveData pcd)
	{
	}

	[Token(Token = "0x6000F7C")]
	[Address(RVA = "0x6154E0", Offset = "0x6142E0", Length = "0x313")]
	private static PersistentControllerStateSaveData.ParameterSaveData SaveParameter(Animator animator, AnimatorControllerParameter param)
	{
		return default(PersistentControllerStateSaveData.ParameterSaveData);
	}

	[Token(Token = "0x6000F7D")]
	[Address(RVA = "0x615800", Offset = "0x614600", Length = "0x348")]
	private static void SaveStates(PersistentControllerState pc, Animator animator, PersistentControllerStateSaveData pcd)
	{
	}

	[Token(Token = "0x6000F7E")]
	[Address(RVA = "0x615B50", Offset = "0x614950", Length = "0x309")]
	public static void DeserializeAll(string text)
	{
	}

	[Token(Token = "0x6000F7F")]
	[Address(RVA = "0x615E60", Offset = "0x614C60", Length = "0x84")]
	private static void RestoreState(PersistentControllerStateSaveData pcd, Animator animator)
	{
	}

	[Token(Token = "0x6000F80")]
	[Address(RVA = "0x615EF0", Offset = "0x614CF0", Length = "0x141")]
	private static void RequestRestoreState(PersistentControllerStateSaveData pcd, Animator animator)
	{
	}

	[Token(Token = "0x6000F81")]
	[Address(RVA = "0x616040", Offset = "0x614E40", Length = "0x93")]
	public static void Reset()
	{
	}

	[Token(Token = "0x6000F82")]
	[Address(RVA = "0x6160E0", Offset = "0x614EE0", Length = "0x316")]
	private static void LoadStates(PersistentControllerStateSaveData pcd, Animator animator)
	{
	}

	[Token(Token = "0x6000F83")]
	[Address(RVA = "0x616400", Offset = "0x615200", Length = "0x12C")]
	private static int GetLayerIndex(string layerName, Animator animator)
	{
		return 0;
	}

	[Token(Token = "0x6000F84")]
	[Address(RVA = "0x616530", Offset = "0x615330", Length = "0x1C1")]
	private static void LoadParameters(PersistentControllerStateSaveData pcd, Animator animator)
	{
	}

	[Token(Token = "0x6000F85")]
	[Address(RVA = "0x616700", Offset = "0x615500", Length = "0x31B")]
	private static void LoadParameter(Animator animator, PersistentControllerStateSaveData.ParameterSaveData paramData)
	{
	}

	[Token(Token = "0x6000F86")]
	[Address(RVA = "0x616A20", Offset = "0x615820", Length = "0x11C")]
	private static void LoadInt(Animator animator, PersistentControllerStateSaveData.ParameterSaveData paramData)
	{
	}

	[Token(Token = "0x6000F87")]
	[Address(RVA = "0x616B40", Offset = "0x615940", Length = "0xE5")]
	private static void LoadFloat(Animator animator, PersistentControllerStateSaveData.ParameterSaveData paramData)
	{
	}

	[Token(Token = "0x6000F88")]
	[Address(RVA = "0x616C30", Offset = "0x615A30", Length = "0xF6")]
	private static void LoadBool(Animator animator, PersistentControllerStateSaveData.ParameterSaveData paramData)
	{
	}

	[Token(Token = "0x6000F89")]
	[Address(RVA = "0x4AF5E0", Offset = "0x4AE3E0", Length = "0x43")]
	public PersistentControllerState()
	{
	}
}
