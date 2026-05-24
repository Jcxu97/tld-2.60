using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x200001C")]
public class vp_Spring
{
	[Token(Token = "0x200001D")]
	public enum TransformType
	{
		[Token(Token = "0x400020B")]
		Position,
		[Token(Token = "0x400020C")]
		PositionAdditive,
		[Token(Token = "0x400020D")]
		Rotation,
		[Token(Token = "0x400020E")]
		RotationAdditive,
		[Token(Token = "0x400020F")]
		Scale,
		[Token(Token = "0x4000210")]
		ScaleAdditive
	}

	[Token(Token = "0x200001E")]
	protected delegate void TransformDelegate();

	[Token(Token = "0x40001F8")]
	[FieldOffset(Offset = "0x10")]
	public TransformType Modifier;

	[Token(Token = "0x40001F9")]
	[FieldOffset(Offset = "0x18")]
	protected TransformDelegate m_TransformFunc;

	[Token(Token = "0x40001FA")]
	[FieldOffset(Offset = "0x20")]
	public Vector3 State;

	[Token(Token = "0x40001FB")]
	[FieldOffset(Offset = "0x2C")]
	protected TransformType m_CurrentTransformType;

	[Token(Token = "0x40001FC")]
	[FieldOffset(Offset = "0x30")]
	protected Vector3 m_Velocity;

	[Token(Token = "0x40001FD")]
	[FieldOffset(Offset = "0x3C")]
	public Vector3 RestState;

	[Token(Token = "0x40001FE")]
	[FieldOffset(Offset = "0x48")]
	public Vector3 Stiffness;

	[Token(Token = "0x40001FF")]
	[FieldOffset(Offset = "0x54")]
	public Vector3 Damping;

	[Token(Token = "0x4000200")]
	[FieldOffset(Offset = "0x60")]
	protected float m_VelocityFadeInCap;

	[Token(Token = "0x4000201")]
	[FieldOffset(Offset = "0x64")]
	protected float m_VelocityFadeInEndTime;

	[Token(Token = "0x4000202")]
	[FieldOffset(Offset = "0x68")]
	protected float m_VelocityFadeInLength;

	[Token(Token = "0x4000203")]
	[FieldOffset(Offset = "0x6C")]
	public float MaxVelocity;

	[Token(Token = "0x4000204")]
	[FieldOffset(Offset = "0x70")]
	public float MinVelocity;

	[Token(Token = "0x4000205")]
	[FieldOffset(Offset = "0x74")]
	public Vector3 MaxState;

	[Token(Token = "0x4000206")]
	[FieldOffset(Offset = "0x80")]
	public Vector3 MinState;

	[Token(Token = "0x4000207")]
	[FieldOffset(Offset = "0x8C")]
	public float RotationResetThreshold;

	[Token(Token = "0x4000208")]
	[FieldOffset(Offset = "0x90")]
	protected Transform m_Transform;

	[Token(Token = "0x4000209")]
	[FieldOffset(Offset = "0x98")]
	protected bool m_IsRefreshing;

	[Token(Token = "0x1700001C")]
	public Transform Transform
	{
		[Token(Token = "0x60001A9")]
		[Address(RVA = "0x579620", Offset = "0x578420", Length = "0x5B")]
		set
		{
		}
	}

	[Token(Token = "0x60001AA")]
	[Address(RVA = "0x579680", Offset = "0x578480", Length = "0x1FF")]
	public vp_Spring(Transform transform, TransformType modifier)
	{
	}

	[Token(Token = "0x60001AB")]
	[Address(RVA = "0x579880", Offset = "0x578680", Length = "0xDA")]
	public void FixedUpdate(float fixedTime, float fixedDeltaTime)
	{
	}

	[Token(Token = "0x60001AC")]
	[Address(RVA = "0x579960", Offset = "0x578760", Length = "0x45")]
	public void Refresh()
	{
	}

	[Token(Token = "0x60001AD")]
	[Address(RVA = "0x5799B0", Offset = "0x5787B0", Length = "0xBC")]
	private void Position()
	{
	}

	[Token(Token = "0x60001AE")]
	[Address(RVA = "0x579A70", Offset = "0x578870", Length = "0x198")]
	private void PositionAdditive()
	{
	}

	[Token(Token = "0x60001AF")]
	[Address(RVA = "0x579C10", Offset = "0x578A10", Length = "0x116")]
	private void Rotation()
	{
	}

	[Token(Token = "0x60001B0")]
	[Address(RVA = "0x579D30", Offset = "0x578B30", Length = "0x18D")]
	private void RotationAdditive()
	{
	}

	[Token(Token = "0x60001B1")]
	[Address(RVA = "0x579EC0", Offset = "0x578CC0", Length = "0xBC")]
	private void Scale()
	{
	}

	[Token(Token = "0x60001B2")]
	[Address(RVA = "0x579F80", Offset = "0x578D80", Length = "0x198")]
	private void ScaleAdditive()
	{
	}

	[Token(Token = "0x60001B3")]
	[Address(RVA = "0x57A120", Offset = "0x578F20", Length = "0xAC")]
	protected void RefreshTransformType()
	{
	}

	[Token(Token = "0x60001B4")]
	[Address(RVA = "0x57A3C0", Offset = "0x5791C0", Length = "0x1DE")]
	protected void Calculate()
	{
	}

	[Token(Token = "0x60001B5")]
	[Address(RVA = "0x57A5A0", Offset = "0x5793A0", Length = "0xBA")]
	public void AddForce(Vector3 force)
	{
	}

	[Token(Token = "0x60001B6")]
	[Address(RVA = "0x57A660", Offset = "0x579460", Length = "0x30")]
	public void AddForce(float x, float y, float z)
	{
	}

	[Token(Token = "0x60001B7")]
	[Address(RVA = "0x57A690", Offset = "0x579490", Length = "0xD8")]
	protected void Move()
	{
	}

	[Token(Token = "0x60001B8")]
	[Address(RVA = "0x57A770", Offset = "0x579570", Length = "0x5D")]
	public void Reset()
	{
	}

	[Token(Token = "0x60001B9")]
	[Address(RVA = "0x57A7D0", Offset = "0x5795D0", Length = "0x4D")]
	public void Stop()
	{
	}

	[Token(Token = "0x60001BA")]
	[Address(RVA = "0x57A820", Offset = "0x579620", Length = "0x6D")]
	public void ForceVelocityFadeIn(float seconds)
	{
	}
}
