using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x2000A1D")]
public class OctreeBounds<T>
{
	[Token(Token = "0x400662D")]
	[FieldOffset(Offset = "0x0")]
	private OctreeBoundsNode<T> rootNode;

	[Token(Token = "0x400662E")]
	[FieldOffset(Offset = "0x0")]
	private readonly float looseness;

	[Token(Token = "0x400662F")]
	[FieldOffset(Offset = "0x0")]
	private readonly float initialSize;

	[Token(Token = "0x4006630")]
	[FieldOffset(Offset = "0x0")]
	private readonly float minSize;

	[Token(Token = "0x17000397")]
	public int Count
	{
		[Token(Token = "0x600589F")]
		[Address(RVA = "0x40E0A0", Offset = "0x40CEA0", Length = "0x4")]
		get;
		[Token(Token = "0x60058A0")]
		[Address(RVA = "0x4096E0", Offset = "0x4084E0", Length = "0x4")]
		private set;
	}

	[Token(Token = "0x60058A1")]
	[Address(RVA = "0x1E55C40", Offset = "0x1E54A40", Length = "0x289")]
	public OctreeBounds(float initialWorldSize, Vector3 initialWorldPos, float minNodeSize, float loosenessVal)
	{
	}

	[Token(Token = "0x60058A2")]
	[Address(RVA = "0x1E55ED0", Offset = "0x1E54CD0", Length = "0x214")]
	public void Add(T obj, Bounds objBounds)
	{
	}

	[Token(Token = "0x60058A3")]
	[Address(RVA = "0x1E560F0", Offset = "0x1E54EF0", Length = "0xE1")]
	public bool Remove(T obj)
	{
		return false;
	}

	[Token(Token = "0x60058A4")]
	[Address(RVA = "0x1E561E0", Offset = "0x1E54FE0", Length = "0x43")]
	public bool IsColliding(Bounds checkBounds)
	{
		return false;
	}

	[Token(Token = "0x60058A5")]
	[Address(RVA = "0x1E56230", Offset = "0x1E55030", Length = "0x9B")]
	public void GetColliding(Bounds checkBounds, ref List<T> resultList)
	{
	}

	[Token(Token = "0x60058A6")]
	[Address(RVA = "0x1E562D0", Offset = "0x1E550D0", Length = "0x88")]
	public void FrustumCapture(Plane[] frustumPlanes, ref List<T> captureList)
	{
	}

	[Token(Token = "0x60058A7")]
	[Address(RVA = "0x1E56360", Offset = "0x1E55160", Length = "0x30")]
	public void DrawAllBounds()
	{
	}

	[Token(Token = "0x60058A8")]
	[Address(RVA = "0x1E563A0", Offset = "0x1E551A0", Length = "0x2D")]
	public void DrawAllObjects()
	{
	}

	[Token(Token = "0x60058A9")]
	[Address(RVA = "0x1E563D0", Offset = "0x1E551D0", Length = "0x578")]
	private void Grow(Vector3 direction)
	{
	}

	[Token(Token = "0x60058AA")]
	[Address(RVA = "0x1E56950", Offset = "0x1E55750", Length = "0x7E")]
	private void Shrink()
	{
	}

	[Token(Token = "0x60058AB")]
	[Address(RVA = "0x1E569D0", Offset = "0x1E557D0", Length = "0x1B")]
	private static int GetRootPosIndex(int xDir, int yDir, int zDir)
	{
		return 0;
	}
}
