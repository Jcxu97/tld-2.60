using System.Collections.Generic;
using Cpp2ILInjected;

namespace ParadoxNotion.Serialization.FullSerializer.Internal;

[Token(Token = "0x2000DAF")]
public class fsCyclicReferenceManager
{
	[Token(Token = "0x2000DB0")]
	private class ObjectReferenceEqualityComparator : IEqualityComparer<object>
	{
		[Token(Token = "0x4008471")]
		public static readonly IEqualityComparer<object> Instance;

		[Token(Token = "0x6006A9F")]
		[Address(RVA = "0x108DDF0", Offset = "0x108CBF0", Length = "0x7")]
		bool IEqualityComparer<object>.Equals(object x, object y)
		{
			return false;
		}

		[Token(Token = "0x6006AA0")]
		[Address(RVA = "0x108DE00", Offset = "0x108CC00", Length = "0xA")]
		int IEqualityComparer<object>.GetHashCode(object obj)
		{
			return 0;
		}

		[Token(Token = "0x6006AA1")]
		[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
		public ObjectReferenceEqualityComparator()
		{
		}
	}

	[Token(Token = "0x400846D")]
	[FieldOffset(Offset = "0x10")]
	private Dictionary<object, int> _objectIds;

	[Token(Token = "0x400846E")]
	[FieldOffset(Offset = "0x18")]
	private int _nextId;

	[Token(Token = "0x400846F")]
	[FieldOffset(Offset = "0x20")]
	private Dictionary<int, object> _marked;

	[Token(Token = "0x4008470")]
	[FieldOffset(Offset = "0x28")]
	private int _depth;

	[Token(Token = "0x6006A97")]
	[Address(RVA = "0x108D6D0", Offset = "0x108C4D0", Length = "0x199")]
	public fsCyclicReferenceManager()
	{
	}

	[Token(Token = "0x6006A98")]
	[Address(RVA = "0x108D870", Offset = "0x108C670", Length = "0x4")]
	public void Enter()
	{
	}

	[Token(Token = "0x6006A99")]
	[Address(RVA = "0x108D880", Offset = "0x108C680", Length = "0xDB")]
	public bool Exit()
	{
		return false;
	}

	[Token(Token = "0x6006A9A")]
	[Address(RVA = "0x108D960", Offset = "0x108C760", Length = "0xED")]
	public object GetReferenceObject(int id)
	{
		return null;
	}

	[Token(Token = "0x6006A9B")]
	[Address(RVA = "0x108DA50", Offset = "0x108C850", Length = "0x81")]
	public void AddReferenceWithId(int id, object reference)
	{
	}

	[Token(Token = "0x6006A9C")]
	[Address(RVA = "0x108DAE0", Offset = "0x108C8E0", Length = "0x101")]
	public int GetReferenceId(object item)
	{
		return 0;
	}

	[Token(Token = "0x6006A9D")]
	[Address(RVA = "0x108DBF0", Offset = "0x108C9F0", Length = "0x8A")]
	public bool IsReference(object item)
	{
		return false;
	}

	[Token(Token = "0x6006A9E")]
	[Address(RVA = "0x108DC80", Offset = "0x108CA80", Length = "0x160")]
	public void MarkSerialized(object item)
	{
	}
}
