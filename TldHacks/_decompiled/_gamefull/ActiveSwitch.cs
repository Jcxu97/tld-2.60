using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x20009EC")]
public class ActiveSwitch : MonoBehaviour
{
	[Token(Token = "0x400651E")]
	[FieldOffset(Offset = "0x20")]
	public int m_ActiveStateIndex;

	[Token(Token = "0x400651F")]
	[FieldOffset(Offset = "0x28")]
	public GameObject[] m_States;

	[Token(Token = "0x4006520")]
	[FieldOffset(Offset = "0x30")]
	private string m_Guid;

	[Token(Token = "0x4006521")]
	private static List<ActiveSwitch> m_ActiveSwitches;

	[Token(Token = "0x6005775")]
	[Address(RVA = "0xED4990", Offset = "0xED3790", Length = "0x13D")]
	private void Start()
	{
	}

	[Token(Token = "0x6005776")]
	[Address(RVA = "0xED4AD0", Offset = "0xED38D0", Length = "0x1B3")]
	public void SetActiveStateIndex(int index)
	{
	}

	[Token(Token = "0x6005777")]
	[Address(RVA = "0xED4C90", Offset = "0xED3A90", Length = "0x93")]
	public static void Reset()
	{
	}

	[Token(Token = "0x6005778")]
	[Address(RVA = "0xED4D30", Offset = "0xED3B30", Length = "0x30D")]
	public static string SerializeAll()
	{
		return null;
	}

	[Token(Token = "0x6005779")]
	[Address(RVA = "0xED5040", Offset = "0xED3E40", Length = "0x31F")]
	public static void DeserializeAll(string text)
	{
	}

	[Token(Token = "0x600577A")]
	[Address(RVA = "0xED5360", Offset = "0xED4160", Length = "0x117")]
	private static ActiveSwitch FindActiveSwitchByGuid(string guid)
	{
		return null;
	}

	[Token(Token = "0x600577B")]
	[Address(RVA = "0x4AF5E0", Offset = "0x4AE3E0", Length = "0x43")]
	public ActiveSwitch()
	{
	}
}
