using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;

[Token(Token = "0x20000A9")]
public class BetterList<T>
{
	[Token(Token = "0x20000AA")]
	public delegate int CompareFunc(T left, T right);

	[CompilerGenerated]
	[Token(Token = "0x20000AB")]
	private sealed class _003CGetEnumerator_003Ed__2 : IEnumerator<T>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40005A3")]
		[FieldOffset(Offset = "0x0")]
		private int _003C_003E1__state;

		[Token(Token = "0x40005A4")]
		[FieldOffset(Offset = "0x0")]
		private T _003C_003E2__current;

		[Token(Token = "0x40005A5")]
		[FieldOffset(Offset = "0x0")]
		public BetterList<T> _003C_003E4__this;

		[Token(Token = "0x40005A6")]
		[FieldOffset(Offset = "0x0")]
		private int _003Ci_003E5__2;

		[Token(Token = "0x1700006C")]
		T IEnumerator<T>.Current
		{
			[DebuggerHidden]
			[Token(Token = "0x60005A7")]
			[Address(RVA = "0x1AA76D0", Offset = "0x1AA64D0", Length = "0xB")]
			get
			{
				return default(T);
			}
		}

		[Token(Token = "0x1700006D")]
		object IEnumerator.Current
		{
			[DebuggerHidden]
			[Token(Token = "0x60005A9")]
			[Address(RVA = "0x1AB0C50", Offset = "0x1AAFA50", Length = "0x2B")]
			get
			{
				return null;
			}
		}

		[DebuggerHidden]
		[Token(Token = "0x60005A4")]
		[Address(RVA = "0x4096E0", Offset = "0x4084E0", Length = "0x4")]
		public _003CGetEnumerator_003Ed__2(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		[Token(Token = "0x60005A5")]
		[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
		void IDisposable.Dispose()
		{
		}

		[DebuggerHidden]
		[DebuggerStepThrough]
		[Token(Token = "0x60005A6")]
		[Address(RVA = "0x1AB0BC0", Offset = "0x1AAF9C0", Length = "0x83")]
		private bool MoveNext()
		{
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		[DebuggerHidden]
		[Token(Token = "0x60005A8")]
		[Address(RVA = "0x1AA27E0", Offset = "0x1AA15E0", Length = "0x39")]
		void IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x40005A1")]
	[FieldOffset(Offset = "0x0")]
	public T[] buffer;

	[Token(Token = "0x40005A2")]
	[FieldOffset(Offset = "0x0")]
	public int size;

	[DebuggerHidden]
	[Token(Token = "0x1700006B")]
	public T this[int i]
	{
		[Token(Token = "0x6000590")]
		[Address(RVA = "0x22A64F0", Offset = "0x22A52F0", Length = "0x38")]
		get
		{
			return default(T);
		}
		[Token(Token = "0x6000591")]
		[Address(RVA = "0x22A6530", Offset = "0x22A5330", Length = "0x36")]
		set
		{
		}
	}

	[IteratorStateMachine(typeof(BetterList<>._003CGetEnumerator_003Ed__2))]
	[DebuggerHidden]
	[DebuggerStepThrough]
	[Token(Token = "0x600058F")]
	[Address(RVA = "0x1E5B690", Offset = "0x1E5A490", Length = "0x8A")]
	public IEnumerator<T> GetEnumerator()
	{
		return null;
	}

	[Token(Token = "0x6000592")]
	[Address(RVA = "0x22A6570", Offset = "0x22A5370", Length = "0xF1")]
	private void AllocateMore()
	{
	}

	[Token(Token = "0x6000593")]
	[Address(RVA = "0x22A6670", Offset = "0x22A5470", Length = "0x164")]
	private void Trim()
	{
	}

	[Token(Token = "0x6000594")]
	[Address(RVA = "0xD2C520", Offset = "0xD2B320", Length = "0x8")]
	public void Clear()
	{
	}

	[Token(Token = "0x6000595")]
	[Address(RVA = "0x22A67E0", Offset = "0x22A55E0", Length = "0x52")]
	public void Release()
	{
	}

	[Token(Token = "0x6000596")]
	[Address(RVA = "0x22A6840", Offset = "0x22A5640", Length = "0x71")]
	public void Add(T item)
	{
	}

	[Token(Token = "0x6000597")]
	[Address(RVA = "0x22A68C0", Offset = "0x22A56C0", Length = "0x14B")]
	public void Insert(int index, T item)
	{
	}

	[Token(Token = "0x6000598")]
	[Address(RVA = "0x22A6A10", Offset = "0x22A5810", Length = "0x129")]
	public bool Contains(T item)
	{
		return false;
	}

	[Token(Token = "0x6000599")]
	[Address(RVA = "0x22A6B40", Offset = "0x22A5940", Length = "0x12C")]
	public int IndexOf(T item)
	{
		return 0;
	}

	[Token(Token = "0x600059A")]
	[Address(RVA = "0x22A6C70", Offset = "0x22A5A70", Length = "0x157")]
	public bool Remove(T item)
	{
		return false;
	}

	[Token(Token = "0x600059B")]
	[Address(RVA = "0x22A6DD0", Offset = "0x22A5BD0", Length = "0xAD")]
	public void RemoveAt(int index)
	{
	}

	[Token(Token = "0x600059C")]
	[Address(RVA = "0x22A6E80", Offset = "0x22A5C80", Length = "0x67")]
	public T Pop()
	{
		return default(T);
	}

	[Token(Token = "0x600059D")]
	[Address(RVA = "0x22A6EF0", Offset = "0x22A5CF0", Length = "0x198")]
	public T[] ToArray()
	{
		return null;
	}

	[DebuggerHidden]
	[DebuggerStepThrough]
	[Token(Token = "0x600059E")]
	[Address(RVA = "0x22A7090", Offset = "0x22A5E90", Length = "0x13D")]
	public void Sort(CompareFunc comparer)
	{
	}

	[Token(Token = "0x600059F")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public BetterList()
	{
	}
}
