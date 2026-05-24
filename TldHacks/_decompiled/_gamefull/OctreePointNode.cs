using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x2000A21")]
public class OctreePointNode<T> where T : class
{
	[Token(Token = "0x2000A22")]
	private class OctreeObject
	{
		[Token(Token = "0x4006649")]
		[FieldOffset(Offset = "0x0")]
		public T Obj;

		[Token(Token = "0x400664A")]
		[FieldOffset(Offset = "0x0")]
		public Vector3 Pos;

		[Token(Token = "0x60058E7")]
		[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
		public OctreeObject()
		{
		}
	}

	[Token(Token = "0x4006643")]
	[FieldOffset(Offset = "0x0")]
	private float minSize;

	[Token(Token = "0x4006644")]
	[FieldOffset(Offset = "0x0")]
	private Bounds bounds;

	[Token(Token = "0x4006645")]
	[FieldOffset(Offset = "0x0")]
	private readonly List<OctreeObject> objects;

	[Token(Token = "0x4006646")]
	[FieldOffset(Offset = "0x0")]
	private OctreePointNode<T>[] children;

	[Token(Token = "0x4006647")]
	[FieldOffset(Offset = "0x0")]
	private Bounds[] childBounds;

	[Token(Token = "0x4006648")]
	private const int numObjectsAllowed = 8;

	[Token(Token = "0x1700039B")]
	public Vector3 Center
	{
		[Token(Token = "0x60058D2")]
		[Address(RVA = "0x1A9C3F0", Offset = "0x1A9B1F0", Length = "0x13")]
		get;
		[Token(Token = "0x60058D3")]
		[Address(RVA = "0x1B21DA0", Offset = "0x1B20BA0", Length = "0x10")]
		private set;
	}

	[Token(Token = "0x1700039C")]
	public float SideLength
	{
		[Token(Token = "0x60058D4")]
		[Address(RVA = "0x5042D0", Offset = "0x5030D0", Length = "0x6")]
		get;
		[Token(Token = "0x60058D5")]
		[Address(RVA = "0x5042E0", Offset = "0x5030E0", Length = "0x6")]
		private set;
	}

	[Token(Token = "0x60058D6")]
	[Address(RVA = "0x1E58390", Offset = "0x1E57190", Length = "0x11E")]
	public OctreePointNode(float baseLengthVal, float minSizeVal, Vector3 centerVal)
	{
	}

	[Token(Token = "0x60058D7")]
	[Address(RVA = "0x1E584B0", Offset = "0x1E572B0", Length = "0xDC")]
	public bool Add(T obj, Vector3 objPos)
	{
		return false;
	}

	[Token(Token = "0x60058D8")]
	[Address(RVA = "0x1E58590", Offset = "0x1E57390", Length = "0x2D9")]
	public bool Remove(T obj)
	{
		return false;
	}

	[Token(Token = "0x60058D9")]
	[Address(RVA = "0x1E58870", Offset = "0x1E57670", Length = "0x3A3")]
	public T[] GetNearby(Ray ray, float maxDistance)
	{
		return null;
	}

	[Token(Token = "0x60058DA")]
	[Address(RVA = "0x1E58C20", Offset = "0x1E57A20", Length = "0x17E")]
	public void SetChildren(OctreePointNode<T>[] childOctrees)
	{
	}

	[Token(Token = "0x60058DB")]
	[Address(RVA = "0x1E58DA0", Offset = "0x1E57BA0", Length = "0x204")]
	public void DrawAllBounds(float depth = 0f)
	{
	}

	[Token(Token = "0x60058DC")]
	[Address(RVA = "0x1E58FB0", Offset = "0x1E57DB0", Length = "0x2D6")]
	public void DrawAllObjects()
	{
	}

	[Token(Token = "0x60058DD")]
	[Address(RVA = "0x1E59290", Offset = "0x1E58090", Length = "0x241")]
	public OctreePointNode<T> ShrinkIfPossible(float minLength)
	{
		return null;
	}

	[Token(Token = "0x60058DE")]
	[Address(RVA = "0x1E594E0", Offset = "0x1E582E0", Length = "0x562")]
	private void SetValues(float baseLengthVal, float minSizeVal, Vector3 centerVal)
	{
	}

	[Token(Token = "0x60058DF")]
	[Address(RVA = "0x1E59A50", Offset = "0x1E58850", Length = "0x3E4")]
	private void SubAdd(T obj, Vector3 objPos)
	{
	}

	[Token(Token = "0x60058E0")]
	[Address(RVA = "0x1E59E40", Offset = "0x1E58C40", Length = "0x845")]
	private void Split()
	{
	}

	[Token(Token = "0x60058E1")]
	[Address(RVA = "0x1E5A690", Offset = "0x1E59490", Length = "0x115")]
	private void Merge()
	{
	}

	[Token(Token = "0x60058E2")]
	[Address(RVA = "0x1E5A7B0", Offset = "0x1E595B0", Length = "0x64")]
	private static bool Encapsulates(Bounds outerBounds, Vector3 point)
	{
		return false;
	}

	[Token(Token = "0x60058E3")]
	[Address(RVA = "0x1E5A820", Offset = "0x1E59620", Length = "0x57")]
	private int BestFitChild(Vector3 objPos)
	{
		return 0;
	}

	[Token(Token = "0x60058E4")]
	[Address(RVA = "0x1E5A880", Offset = "0x1E59680", Length = "0x6F")]
	private bool ShouldMerge()
	{
		return false;
	}

	[Token(Token = "0x60058E5")]
	[Address(RVA = "0x1E5A8F0", Offset = "0x1E596F0", Length = "0x9C")]
	private bool HasAnyObjects()
	{
		return false;
	}

	[Token(Token = "0x60058E6")]
	[Address(RVA = "0x1E5A990", Offset = "0x1E59790", Length = "0xDA")]
	public static float DistanceToRay(Ray ray, Vector3 point)
	{
		return 0f;
	}
}
