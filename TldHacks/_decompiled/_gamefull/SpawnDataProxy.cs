using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x2000184")]
public class SpawnDataProxy
{
	[Token(Token = "0x4000DFB")]
	[FieldOffset(Offset = "0x10")]
	public Vector3 m_Position;

	[Token(Token = "0x4000DFC")]
	[FieldOffset(Offset = "0x1C")]
	public Quaternion m_Rotation;

	[Token(Token = "0x4000DFD")]
	[FieldOffset(Offset = "0x2C")]
	public AiMode m_AiMode;

	[Token(Token = "0x4000DFE")]
	[FieldOffset(Offset = "0x30")]
	public string m_Guid;

	[Token(Token = "0x4000DFF")]
	[FieldOffset(Offset = "0x38")]
	public string m_AssetReferenceGUID;

	[Token(Token = "0x4000E00")]
	[FieldOffset(Offset = "0x40")]
	public string m_BaseAiSerialized;

	[Token(Token = "0x6000EC9")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public SpawnDataProxy()
	{
	}
}
