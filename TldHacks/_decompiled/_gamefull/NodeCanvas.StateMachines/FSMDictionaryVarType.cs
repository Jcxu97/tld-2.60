using System.Collections.Generic;
using Cpp2ILInjected;
using NodeCanvas.Framework;

namespace NodeCanvas.StateMachines;

[Token(Token = "0x20010BF")]
public class FSMDictionaryVarType
{
	[Token(Token = "0x4008640")]
	[FieldOffset(Offset = "0x10")]
	public Dictionary<Graph, State_TLDBaseFSM> dict;

	[Token(Token = "0x6007185")]
	[Address(RVA = "0x10D3C60", Offset = "0x10D2A60", Length = "0xAD")]
	public FSMDictionaryVarType()
	{
	}

	[Token(Token = "0x6007186")]
	[Address(RVA = "0x10D3D10", Offset = "0x10D2B10", Length = "0x83")]
	public void AddElement(Graph g, State_TLDBaseFSM s)
	{
	}

	[Token(Token = "0x6007187")]
	[Address(RVA = "0x10D3DA0", Offset = "0x10D2BA0", Length = "0x58")]
	public void RemoveElement(Graph g)
	{
	}
}
