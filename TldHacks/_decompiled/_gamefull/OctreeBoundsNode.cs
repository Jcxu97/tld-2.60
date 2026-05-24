using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x2000A1E")]
public class OctreeBoundsNode<T>
{
	[Token(Token = "0x2000A1F")]
	private struct OctreeObject : IEquatable<OctreeObject>
	{
		[Token(Token = "0x400663B")]
		[FieldOffset(Offset = "0x0")]
		public T Obj;

		[Token(Token = "0x400663C")]
		[FieldOffset(Offset = "0x0")]
		public Bounds Bounds;

		[Token(Token = "0x60058C2")]
		[Address(RVA = "0x1E57780", Offset = "0x1E56580", Length = "0x153")]
		public override bool Equals(object obj)
		{
			return false;
		}

		[Token(Token = "0x60058C3")]
		[Address(RVA = "0x1E578E0", Offset = "0x1E566E0", Length = "0x102")]
		public bool Equals(OctreeObject obj)
		{
			return false;
		}

		[Token(Token = "0x60058C4")]
		[Address(RVA = "0x1E579F0", Offset = "0x1E567F0", Length = "0x46")]
		public override int GetHashCode()
		{
			return 0;
		}

		[Token(Token = "0x60058C5")]
		[Address(RVA = "0x1E57A40", Offset = "0x1E56840", Length = "0x4B")]
		public static bool operator ==(OctreeObject lhs, OctreeObject rhs)
		{
			return false;
		}

		[Token(Token = "0x60058C6")]
		[Address(RVA = "0x1E57A90", Offset = "0x1E56890", Length = "0x50")]
		public static bool operator !=(OctreeObject lhs, OctreeObject rhs)
		{
			return false;
		}
	}

	[Token(Token = "0x4006633")]
	[FieldOffset(Offset = "0x0")]
	private float looseness;

	[Token(Token = "0x4006634")]
	[FieldOffset(Offset = "0x0")]
	private float minSize;

	[Token(Token = "0x4006635")]
	[FieldOffset(Offset = "0x0")]
	private float adjLength;

	[Token(Token = "0x4006636")]
	[FieldOffset(Offset = "0x0")]
	private Bounds bounds;

	[Token(Token = "0x4006637")]
	[FieldOffset(Offset = "0x0")]
	private readonly List<OctreeObject> objects;

	[Token(Token = "0x4006638")]
	[FieldOffset(Offset = "0x0")]
	private OctreeBoundsNode<T>[] children;

	[Token(Token = "0x4006639")]
	[FieldOffset(Offset = "0x0")]
	private Bounds[] childBounds;

	[Token(Token = "0x400663A")]
	private const int numObjectsAllowed = 8;

	[Token(Token = "0x17000398")]
	public Vector3 Center
	{
		[Token(Token = "0x60058AC")]
		[Address(RVA = "0x1A9C3F0", Offset = "0x1A9B1F0", Length = "0x13")]
		get;
		[Token(Token = "0x60058AD")]
		[Address(RVA = "0x1B21DA0", Offset = "0x1B20BA0", Length = "0x10")]
		private set;
	}

	[Token(Token = "0x17000399")]
	public float BaseLength
	{
		[Token(Token = "0x60058AE")]
		[Address(RVA = "0x5042D0", Offset = "0x5030D0", Length = "0x6")]
		get;
		[Token(Token = "0x60058AF")]
		[Address(RVA = "0x5042E0", Offset = "0x5030E0", Length = "0x6")]
		private set;
	}

	[Token(Token = "0x60058B0")]
	[Address(RVA = "0x1E4EC00", Offset = "0x1E4DA00", Length = "0x12D")]
	public OctreeBoundsNode(float baseLengthVal, float minSizeVal, float loosenessVal, Vector3 centerVal)
	{
	}

	[Token(Token = "0x60058B1")]
	[Address(RVA = "0x1E4ED30", Offset = "0x1E4DB30", Length = "0xA6")]
	public bool Add(T obj, Bounds objBounds)
	{
		return false;
	}

	[Token(Token = "0x60058B2")]
	[Address(RVA = "0x1E4EDE0", Offset = "0x1E4DBE0", Length = "0x379")]
	public bool Remove(T obj)
	{
		return false;
	}

	[Token(Token = "0x60058B3")]
	[Address(RVA = "0x1E4F160", Offset = "0x1E4DF60", Length = "0x166")]
	public bool IsColliding(Bounds checkBounds)
	{
		return false;
	}

	[Token(Token = "0x60058B4")]
	[Address(RVA = "0x1E4F2D0", Offset = "0x1E4E0D0", Length = "0x28D")]
	public void GetColliding(Bounds checkBounds, ref List<T> resultList)
	{
	}

	[Token(Token = "0x60058B5")]
	[Address(RVA = "0x1E4F560", Offset = "0x1E4E360", Length = "0x348")]
	public void FrustumCapture(Plane[] frustumPlanes, ref List<T> captureList)
	{
	}

	[Token(Token = "0x60058B6")]
	[Address(RVA = "0x1E4F8B0", Offset = "0x1E4E6B0", Length = "0x17E")]
	public void SetChildren(OctreeBoundsNode<T>[] childOctrees)
	{
	}

	[Token(Token = "0x60058B7")]
	[Address(RVA = "0x1E4FA30", Offset = "0x1E4E830", Length = "0x204")]
	public void DrawAllBounds(float depth = 0f)
	{
	}

	[Token(Token = "0x60058B8")]
	[Address(RVA = "0x1E4FC40", Offset = "0x1E4EA40", Length = "0x317")]
	public void DrawAllObjects()
	{
	}

	[Token(Token = "0x60058B9")]
	[Address(RVA = "0x1E4FF60", Offset = "0x1E4ED60", Length = "0x2EF")]
	public OctreeBoundsNode<T> ShrinkIfPossible(float minLength)
	{
		return null;
	}

	[Token(Token = "0x60058BA")]
	[Address(RVA = "0x1E50250", Offset = "0x1E4F050", Length = "0x5AB")]
	private void SetValues(float baseLengthVal, float minSizeVal, float loosenessVal, Vector3 centerVal)
	{
	}

	[Token(Token = "0x60058BB")]
	[Address(RVA = "0x1E50800", Offset = "0x1E4F600", Length = "0x74F")]
	private void SubAdd(T obj, Bounds objBounds)
	{
	}

	[Token(Token = "0x60058BC")]
	[Address(RVA = "0x1E50F50", Offset = "0x1E4FD50", Length = "0x8CF")]
	private void Split()
	{
	}

	[Token(Token = "0x60058BD")]
	[Address(RVA = "0x1E51820", Offset = "0x1E50620", Length = "0x15D")]
	private void Merge()
	{
	}

	[Token(Token = "0x60058BE")]
	[Address(RVA = "0x1E51980", Offset = "0x1E50780", Length = "0x16A")]
	private static bool Encapsulates(Bounds outerBounds, Bounds innerBounds)
	{
		return false;
	}

	[Token(Token = "0x60058BF")]
	[Address(RVA = "0x1E51AF0", Offset = "0x1E508F0", Length = "0x7A")]
	private int BestFitChild(Bounds objBounds)
	{
		return 0;
	}

	[Token(Token = "0x60058C0")]
	[Address(RVA = "0x1E51B70", Offset = "0x1E50970", Length = "0x6F")]
	private bool ShouldMerge()
	{
		return false;
	}

	[Token(Token = "0x60058C1")]
	[Address(RVA = "0x1E51BE0", Offset = "0x1E509E0", Length = "0x9C")]
	private bool HasAnyObjects()
	{
		return false;
	}
}
