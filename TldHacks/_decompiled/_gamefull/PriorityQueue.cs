using System;
using System.Collections;
using System.Collections.Generic;
using Cpp2ILInjected;

[Token(Token = "0x2000A2D")]
public class PriorityQueue<TEntry> : IEnumerable<TEntry>, IEnumerable where TEntry : IPrioritizable
{
	[Token(Token = "0x2000A2E")]
	private class PriorityQueueEntry
	{
		[Token(Token = "0x400666D")]
		private const int s_DefaultEntriesCapacity = 4;

		[Token(Token = "0x400666E")]
		[FieldOffset(Offset = "0x0")]
		public readonly int m_Priority;

		[Token(Token = "0x400666F")]
		[FieldOffset(Offset = "0x0")]
		public readonly Queue<TEntry> m_Entries;

		[Token(Token = "0x6005904")]
		[Address(RVA = "0x1E7AF60", Offset = "0x1E79D60", Length = "0xC9")]
		public PriorityQueueEntry(int Priority)
		{
		}
	}

	[Token(Token = "0x2000A2F")]
	public struct Enumerator : IEnumerator<TEntry>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4006670")]
		[FieldOffset(Offset = "0x0")]
		private PriorityQueue<TEntry> m_Queue;

		[Token(Token = "0x4006671")]
		[FieldOffset(Offset = "0x0")]
		private int m_PriorityIndex;

		[Token(Token = "0x4006672")]
		[FieldOffset(Offset = "0x0")]
		private Queue<TEntry>.Enumerator m_CurrentEnumerator;

		[Token(Token = "0x1700039F")]
		public TEntry Current
		{
			[Token(Token = "0x6005906")]
			[Address(RVA = "0x273ACE0", Offset = "0x2739AE0", Length = "0x5F")]
			get
			{
				return default(TEntry);
			}
		}

		[Token(Token = "0x170003A0")]
		object IEnumerator.Current
		{
			[Token(Token = "0x6005907")]
			[Address(RVA = "0x273ACE0", Offset = "0x2739AE0", Length = "0x5F")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6005905")]
		[Address(RVA = "0x273AA80", Offset = "0x2739880", Length = "0x251")]
		public Enumerator(PriorityQueue<TEntry> priorityQueue)
		{
			m_Queue = null;
			m_PriorityIndex = 0;
			m_CurrentEnumerator = default(Queue<TEntry>.Enumerator);
		}

		[Token(Token = "0x6005908")]
		[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
		public void Dispose()
		{
		}

		[Token(Token = "0x6005909")]
		[Address(RVA = "0x273AD40", Offset = "0x2739B40", Length = "0x293")]
		public bool MoveNext()
		{
			return false;
		}

		[Token(Token = "0x600590A")]
		[Address(RVA = "0x178F4D0", Offset = "0x178E2D0", Length = "0x39")]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x400666C")]
	[FieldOffset(Offset = "0x0")]
	private List<PriorityQueueEntry> m_Queues;

	[Token(Token = "0x1700039E")]
	public int Count
	{
		[Token(Token = "0x60058FD")]
		[Address(RVA = "0x1E7B2B0", Offset = "0x1E7A0B0", Length = "0x136")]
		get
		{
			return 0;
		}
	}

	[Token(Token = "0x60058FC")]
	[Address(RVA = "0x1E7B100", Offset = "0x1E79F00", Length = "0x1A9")]
	public bool Contains(TEntry entry)
	{
		return false;
	}

	[Token(Token = "0x60058FE")]
	[Address(RVA = "0x1E7B3F0", Offset = "0x1E7A1F0", Length = "0x14E")]
	public TEntry Dequeue()
	{
		return default(TEntry);
	}

	[Token(Token = "0x60058FF")]
	[Address(RVA = "0x1E7B540", Offset = "0x1E7A340", Length = "0x5C4")]
	public void Enqueue(TEntry entry)
	{
	}

	[Token(Token = "0x6005900")]
	[Address(RVA = "0x1E7BB10", Offset = "0x1E7A910", Length = "0x14E")]
	public TEntry Peek()
	{
		return default(TEntry);
	}

	[Token(Token = "0x6005901")]
	[Address(RVA = "0x1E7BC60", Offset = "0x1E7AA60", Length = "0x7E")]
	public IEnumerator<TEntry> GetEnumerator()
	{
		return null;
	}

	[Token(Token = "0x6005902")]
	[Address(RVA = "0x1E7BC60", Offset = "0x1E7AA60", Length = "0x7E")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Token(Token = "0x6005903")]
	[Address(RVA = "0x1E7BCE0", Offset = "0x1E7AAE0", Length = "0xB1")]
	public PriorityQueue()
	{
	}
}
