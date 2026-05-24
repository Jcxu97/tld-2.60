using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x20006F9")]
public class LoadSceneParentSaveDataProxy
{
	[Token(Token = "0x4004A1D")]
	[FieldOffset(Offset = "0x10")]
	public Vector3 m_Position;

	[Token(Token = "0x4004A1E")]
	[FieldOffset(Offset = "0x20")]
	public string m_GUID;

	[Token(Token = "0x6003D35")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public LoadSceneParentSaveDataProxy()
	{
	}
}
