using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using NodeCanvas.Framework;
using UnityEngine;

[RequireComponent(typeof(Blackboard))]
[Token(Token = "0x2000810")]
public class BlackboardPatch : MonoBehaviour
{
	[Serializable]
	[Token(Token = "0x2000811")]
	public struct Patch
	{
		[Token(Token = "0x400554B")]
		[FieldOffset(Offset = "0x0")]
		public string m_Key;

		[Token(Token = "0x400554C")]
		[FieldOffset(Offset = "0x8")]
		public float m_Value;
	}

	[Token(Token = "0x400554A")]
	[FieldOffset(Offset = "0x20")]
	public List<Patch> m_PatchList;

	[Token(Token = "0x6004B46")]
	[Address(RVA = "0xD50880", Offset = "0xD4F680", Length = "0x1B7")]
	public void Update()
	{
	}

	[Token(Token = "0x6004B47")]
	[Address(RVA = "0xD50A40", Offset = "0xD4F840", Length = "0x39C")]
	private void ApplyPatch()
	{
	}

	[Token(Token = "0x6004B48")]
	[Address(RVA = "0xD50DE0", Offset = "0xD4FBE0", Length = "0xE3")]
	public BlackboardPatch()
	{
	}
}
