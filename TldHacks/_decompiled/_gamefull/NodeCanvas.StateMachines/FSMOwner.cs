using Cpp2ILInjected;
using NodeCanvas.Framework;
using UnityEngine;

namespace NodeCanvas.StateMachines;

[AddComponentMenu("NodeCanvas/FSM Owner")]
[Token(Token = "0x20010CE")]
public class FSMOwner : GraphOwner<FSM>
{
	[Token(Token = "0x17000857")]
	public string currentRootStateName
	{
		[Token(Token = "0x6007204")]
		[Address(RVA = "0x10DBC70", Offset = "0x10DAA70", Length = "0x115")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000858")]
	public string previousRootStateName
	{
		[Token(Token = "0x6007205")]
		[Address(RVA = "0x10DBD90", Offset = "0x10DAB90", Length = "0x115")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000859")]
	public string currentDeepStateName
	{
		[Token(Token = "0x6007206")]
		[Address(RVA = "0x10DBEB0", Offset = "0x10DACB0", Length = "0x58")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700085A")]
	public string previousDeepStateName
	{
		[Token(Token = "0x6007207")]
		[Address(RVA = "0x10DBF10", Offset = "0x10DAD10", Length = "0x58")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6007208")]
	[Address(RVA = "0x10DBF70", Offset = "0x10DAD70", Length = "0x295")]
	public IState GetCurrentState(bool includeSubFSMs = true)
	{
		return null;
	}

	[Token(Token = "0x6007209")]
	[Address(RVA = "0x10DC210", Offset = "0x10DB010", Length = "0x356")]
	public IState GetPreviousState(bool includeSubFSMs = true)
	{
		return null;
	}

	[Token(Token = "0x600720A")]
	[Address(RVA = "0x10DC570", Offset = "0x10DB370", Length = "0x112")]
	public IState TriggerState(string stateName)
	{
		return null;
	}

	[Token(Token = "0x600720B")]
	[Address(RVA = "0x10DC690", Offset = "0x10DB490", Length = "0xFC")]
	public string[] GetStateNames()
	{
		return null;
	}

	[Token(Token = "0x600720C")]
	[Address(RVA = "0x10DC790", Offset = "0x10DB590", Length = "0x3E")]
	public FSMOwner()
	{
	}
}
