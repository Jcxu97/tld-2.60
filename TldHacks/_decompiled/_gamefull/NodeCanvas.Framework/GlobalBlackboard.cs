using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;

namespace NodeCanvas.Framework;

[ExecuteInEditMode]
[Token(Token = "0x2001081")]
public class GlobalBlackboard : Blackboard
{
	[Token(Token = "0x40085C1")]
	public static List<GlobalBlackboard> allGlobals;

	[Token(Token = "0x40085C2")]
	[FieldOffset(Offset = "0x50")]
	public bool dontDestroy;

	[Token(Token = "0x1700080B")]
	public new string name
	{
		[Token(Token = "0x6007044")]
		[Address(RVA = "0x10CD0D0", Offset = "0x10CBED0", Length = "0x7")]
		get
		{
			return null;
		}
		[Token(Token = "0x6007045")]
		[Address(RVA = "0x10CD0E0", Offset = "0x10CBEE0", Length = "0x193")]
		set
		{
		}
	}

	[Token(Token = "0x6007046")]
	[Address(RVA = "0x10CD280", Offset = "0x10CC080", Length = "0xF9")]
	public static GlobalBlackboard Create()
	{
		return null;
	}

	[Token(Token = "0x6007047")]
	[Address(RVA = "0x10CD380", Offset = "0x10CC180", Length = "0x47A")]
	public static GlobalBlackboard Find(string name)
	{
		return null;
	}

	[Token(Token = "0x6007048")]
	[Address(RVA = "0x10CD800", Offset = "0x10CC600", Length = "0x413")]
	protected override void Awake()
	{
	}

	[Token(Token = "0x6007049")]
	[Address(RVA = "0x10CDC20", Offset = "0x10CCA20", Length = "0x82")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x600704A")]
	[Address(RVA = "0x10CDCB0", Offset = "0x10CCAB0", Length = "0x197")]
	private bool IsUnique()
	{
		return false;
	}

	[Token(Token = "0x600704B")]
	[Address(RVA = "0x10CDE50", Offset = "0x10CCC50", Length = "0xD2")]
	public GlobalBlackboard()
	{
	}
}
