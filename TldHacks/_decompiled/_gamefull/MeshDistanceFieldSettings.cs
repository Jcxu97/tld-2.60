using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x20008FD")]
public class MeshDistanceFieldSettings : MonoBehaviour
{
	[Tooltip("The mesh from this renderer will be ignored if this is enabled.")]
	[Token(Token = "0x4005E31")]
	[FieldOffset(Offset = "0x20")]
	public bool m_Ignored;

	[Tooltip("Use this mesh instead of the one found through the mesh renderer to generate the sdf.")]
	[Token(Token = "0x4005E32")]
	[FieldOffset(Offset = "0x28")]
	public Mesh m_OverrideMesh;

	[Token(Token = "0x4005E33")]
	[FieldOffset(Offset = "0x30")]
	public bool m_OverrideSignPassesCount;

	[Token(Token = "0x4005E34")]
	[FieldOffset(Offset = "0x34")]
	public int m_SignPassesCount;

	[Token(Token = "0x4005E35")]
	[FieldOffset(Offset = "0x38")]
	public bool m_OverrideDistanceThreshold;

	[Token(Token = "0x4005E36")]
	[FieldOffset(Offset = "0x3C")]
	public float m_DistanceThreshold;

	[Token(Token = "0x4005E37")]
	[FieldOffset(Offset = "0x40")]
	public bool m_OverrideDistanceOffset;

	[Token(Token = "0x4005E38")]
	[FieldOffset(Offset = "0x44")]
	public float m_DistanceOffset;

	[Token(Token = "0x600524D")]
	[Address(RVA = "0xE46890", Offset = "0xE45690", Length = "0x51")]
	public MeshDistanceFieldSettings()
	{
	}
}
