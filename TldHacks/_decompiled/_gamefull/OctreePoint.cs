using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x2000A20")]
public class OctreePoint<T> where T : class
{
	[Token(Token = "0x400663E")]
	[FieldOffset(Offset = "0x0")]
	private OctreePointNode<T> rootNode;

	[Token(Token = "0x400663F")]
	[FieldOffset(Offset = "0x0")]
	private readonly float initialSize;

	[Token(Token = "0x4006640")]
	[FieldOffset(Offset = "0x0")]
	private readonly float minSize;

	[Token(Token = "0x1700039A")]
	public int Count
	{
		[Token(Token = "0x60058C7")]
		[Address(RVA = "0x40E0A0", Offset = "0x40CEA0", Length = "0x4")]
		get;
		[Token(Token = "0x60058C8")]
		[Address(RVA = "0x4096E0", Offset = "0x4084E0", Length = "0x4")]
		private set;
	}

	[Token(Token = "0x60058C9")]
	[Address(RVA = "0x1E5AA70", Offset = "0x1E59870", Length = "0x245")]
	public OctreePoint(float initialWorldSize, Vector3 initialWorldPos, float minNodeSize)
	{
	}

	[Token(Token = "0x60058CA")]
	[Address(RVA = "0x1E5ACC0", Offset = "0x1E59AC0", Length = "0x243")]
	public void Add(T obj, Vector3 objPos)
	{
	}

	[Token(Token = "0x60058CB")]
	[Address(RVA = "0x1E5AF10", Offset = "0x1E59D10", Length = "0xE1")]
	public bool Remove(T obj)
	{
		return false;
	}

	[Token(Token = "0x60058CC")]
	[Address(RVA = "0x1E5B000", Offset = "0x1E59E00", Length = "0x43")]
	public T[] GetNearby(Ray ray, float maxDistance)
	{
		return null;
	}

	[Token(Token = "0x60058CD")]
	[Address(RVA = "0x1E5B050", Offset = "0x1E59E50", Length = "0x2D")]
	public void DrawAllBounds()
	{
	}

	[Token(Token = "0x60058CE")]
	[Address(RVA = "0x1E5B080", Offset = "0x1E59E80", Length = "0x2A")]
	public void DrawAllObjects()
	{
	}

	[Token(Token = "0x60058CF")]
	[Address(RVA = "0x1E5B0B0", Offset = "0x1E59EB0", Length = "0x553")]
	private void Grow(Vector3 direction)
	{
	}

	[Token(Token = "0x60058D0")]
	[Address(RVA = "0x1E5B610", Offset = "0x1E5A410", Length = "0x7E")]
	private void Shrink()
	{
	}

	[Token(Token = "0x60058D1")]
	[Address(RVA = "0x1E569D0", Offset = "0x1E557D0", Length = "0x1B")]
	private static int GetRootPosIndex(int xDir, int yDir, int zDir)
	{
		return 0;
	}
}
