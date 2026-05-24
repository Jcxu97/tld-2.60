using System;
using Cpp2ILInjected;
using UnityEngine;

[Serializable]
[Token(Token = "0x2000904")]
public class VoronoiPointSet
{
	[Token(Token = "0x4005E5C")]
	public const int POINT_COUNT = 16;

	[SerializeField]
	[Token(Token = "0x4005E5D")]
	[FieldOffset(Offset = "0x10")]
	private Vector4[] m_Points;

	[Token(Token = "0x6005266")]
	[Address(RVA = "0xE49110", Offset = "0xE47F10", Length = "0x13A")]
	public VoronoiPointSet()
	{
	}

	[Token(Token = "0x6005267")]
	[Address(RVA = "0xE49250", Offset = "0xE48050", Length = "0x160")]
	public int ComputeNearestPointIndex(Vector2 pos)
	{
		return 0;
	}

	[Token(Token = "0x6005268")]
	[Address(RVA = "0xE493B0", Offset = "0xE481B0", Length = "0x99")]
	public Vector2 GetPoint(int index)
	{
		return default(Vector2);
	}

	[Token(Token = "0x6005269")]
	[Address(RVA = "0xE49450", Offset = "0xE48250", Length = "0x1AB")]
	public void Randomize()
	{
	}

	[Token(Token = "0x600526A")]
	[Address(RVA = "0xE49600", Offset = "0xE48400", Length = "0x1E")]
	public void CopyTo(Vector4[] array, int index)
	{
	}

	[Token(Token = "0x600526B")]
	[Address(RVA = "0xE49620", Offset = "0xE48420", Length = "0xB1")]
	public void SetPoint(int index, Vector2 point)
	{
	}
}
