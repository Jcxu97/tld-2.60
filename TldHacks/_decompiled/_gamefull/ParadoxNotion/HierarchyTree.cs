using System.Collections.Generic;
using Cpp2ILInjected;

namespace ParadoxNotion;

[Token(Token = "0x2000D5A")]
public class HierarchyTree
{
	[Token(Token = "0x2000D5B")]
	public class Element
	{
		[Token(Token = "0x4008390")]
		[FieldOffset(Offset = "0x10")]
		public object reference;

		[Token(Token = "0x4008391")]
		[FieldOffset(Offset = "0x18")]
		public Element parent;

		[Token(Token = "0x4008392")]
		[FieldOffset(Offset = "0x20")]
		public List<Element> children;

		[Token(Token = "0x6006819")]
		[Address(RVA = "0x4094C0", Offset = "0x4082C0", Length = "0x52")]
		public Element(object reference)
		{
		}

		[Token(Token = "0x600681A")]
		[Address(RVA = "0x105EE50", Offset = "0x105DC50", Length = "0x1B4")]
		public void AddChild(Element child)
		{
		}

		[Token(Token = "0x600681B")]
		[Address(RVA = "0x105F010", Offset = "0x105DE10", Length = "0x54")]
		public void RemoveChild(Element child)
		{
		}

		[Token(Token = "0x600681C")]
		[Address(RVA = "0x105F070", Offset = "0x105DE70", Length = "0x1A")]
		public Element GetRoot()
		{
			return null;
		}

		[Token(Token = "0x600681D")]
		[Address(RVA = "0x105F090", Offset = "0x105DE90", Length = "0xEB")]
		public Element FindReferenceElement(object target)
		{
			return null;
		}

		[Token(Token = "0x600681E")]
		[Address(RVA = "0x1A69030", Offset = "0x1A67E30", Length = "0xC7")]
		public T GetFirstParentReferenceOfType<T>()
		{
			return default(T);
		}

		[Token(Token = "0x600681F")]
		[Address(RVA = "0x1A68B00", Offset = "0x1A67900", Length = "0x28C")]
		public List<T> GetAllChildrenReferencesOfType<T>()
		{
			return null;
		}
	}

	[Token(Token = "0x6006818")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public HierarchyTree()
	{
	}
}
