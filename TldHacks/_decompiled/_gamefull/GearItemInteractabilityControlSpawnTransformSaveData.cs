using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x2000583")]
public class GearItemInteractabilityControlSpawnTransformSaveData
{
	[Token(Token = "0x40032C3")]
	[FieldOffset(Offset = "0x10")]
	public string m_GearItemGuid;

	[Token(Token = "0x40032C4")]
	[FieldOffset(Offset = "0x18")]
	public Vector3 m_LocalPosition;

	[Token(Token = "0x40032C5")]
	[FieldOffset(Offset = "0x24")]
	public Quaternion m_LocalRotation;

	[Token(Token = "0x40032C6")]
	[FieldOffset(Offset = "0x34")]
	public Vector3 m_LocalScale;

	[Token(Token = "0x6002A78")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public GearItemInteractabilityControlSpawnTransformSaveData()
	{
	}
}
