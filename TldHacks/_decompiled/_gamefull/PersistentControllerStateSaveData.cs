using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x20001A1")]
public class PersistentControllerStateSaveData
{
	[Token(Token = "0x20001A2")]
	public struct StateSaveData
	{
		[Token(Token = "0x4000EE8")]
		[FieldOffset(Offset = "0x0")]
		public int m_StateHash;

		[Token(Token = "0x4000EE9")]
		[FieldOffset(Offset = "0x4")]
		public float m_Time;

		[Token(Token = "0x4000EEA")]
		[FieldOffset(Offset = "0x8")]
		public string m_LayerName;
	}

	[Token(Token = "0x20001A3")]
	public struct ParameterSaveData
	{
		[Token(Token = "0x4000EEB")]
		[FieldOffset(Offset = "0x0")]
		public int m_Hash;

		[Token(Token = "0x4000EEC")]
		[FieldOffset(Offset = "0x8")]
		public string m_Value;

		[Token(Token = "0x4000EED")]
		[FieldOffset(Offset = "0x10")]
		public AnimatorControllerParameterType m_Type;
	}

	[Token(Token = "0x4000EE5")]
	[FieldOffset(Offset = "0x10")]
	public List<StateSaveData> m_States;

	[Token(Token = "0x4000EE6")]
	[FieldOffset(Offset = "0x18")]
	public List<ParameterSaveData> m_Parameters;

	[Token(Token = "0x4000EE7")]
	[FieldOffset(Offset = "0x20")]
	public string m_Id;

	[Token(Token = "0x6000F75")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public PersistentControllerStateSaveData()
	{
	}
}
