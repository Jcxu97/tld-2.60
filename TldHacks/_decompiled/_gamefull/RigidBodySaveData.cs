using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x200049A")]
public struct RigidBodySaveData
{
	[Token(Token = "0x40029FB")]
	[FieldOffset(Offset = "0x0")]
	public bool m_IsKinematic;

	[Token(Token = "0x40029FC")]
	[FieldOffset(Offset = "0x4")]
	public Vector3 m_Velocity;

	[Token(Token = "0x40029FD")]
	[FieldOffset(Offset = "0x10")]
	public Vector3 m_AngularVelocity;

	[Token(Token = "0x40029FE")]
	[FieldOffset(Offset = "0x1C")]
	public CollisionDetectionMode m_CollisionDetectionMode;

	[Token(Token = "0x40029FF")]
	[FieldOffset(Offset = "0x20")]
	public float m_Mass;

	[Token(Token = "0x4002A00")]
	[FieldOffset(Offset = "0x24")]
	public float m_Drag;

	[Token(Token = "0x4002A01")]
	[FieldOffset(Offset = "0x28")]
	public float m_AngularDrag;

	[Token(Token = "0x4002A02")]
	[FieldOffset(Offset = "0x2C")]
	public Vector3 m_CenterOfMass;
}
