using System;
using Cpp2ILInjected;
using ParadoxNotion.Design;
using UnityEngine;

namespace NodeCanvas.Framework;

[SpoofAOT]
[Token(Token = "0x2001050")]
public abstract class Connection : IGraphElement
{
	[SerializeField]
	[Token(Token = "0x4008525")]
	[FieldOffset(Offset = "0x10")]
	private Node _sourceNode;

	[SerializeField]
	[Token(Token = "0x4008526")]
	[FieldOffset(Offset = "0x18")]
	private Node _targetNode;

	[SerializeField]
	[Token(Token = "0x4008527")]
	[FieldOffset(Offset = "0x20")]
	private bool _isDisabled;

	[NonSerialized]
	[Token(Token = "0x4008528")]
	[FieldOffset(Offset = "0x24")]
	private Status _status;

	[Token(Token = "0x1700078E")]
	public Node sourceNode
	{
		[Token(Token = "0x6006E38")]
		[Address(RVA = "0x49DED0", Offset = "0x49CCD0", Length = "0x5")]
		get
		{
			return null;
		}
		[Token(Token = "0x6006E39")]
		[Address(RVA = "0x4094C0", Offset = "0x4082C0", Length = "0x52")]
		protected set
		{
		}
	}

	[Token(Token = "0x1700078F")]
	public Node targetNode
	{
		[Token(Token = "0x6006E3A")]
		[Address(RVA = "0x4571D0", Offset = "0x455FD0", Length = "0x5")]
		get
		{
			return null;
		}
		[Token(Token = "0x6006E3B")]
		[Address(RVA = "0x49DEE0", Offset = "0x49CCE0", Length = "0x52")]
		protected set
		{
		}
	}

	[Token(Token = "0x17000790")]
	public bool isActive
	{
		[Token(Token = "0x6006E3C")]
		[Address(RVA = "0x6283C0", Offset = "0x6271C0", Length = "0x8")]
		get
		{
			return false;
		}
		[Token(Token = "0x6006E3D")]
		[Address(RVA = "0x10B5FF0", Offset = "0x10B4DF0", Length = "0x50")]
		set
		{
		}
	}

	[Token(Token = "0x17000791")]
	public Status status
	{
		[Token(Token = "0x6006E3E")]
		[Address(RVA = "0x4AA8A0", Offset = "0x4A96A0", Length = "0x4")]
		get
		{
			return default(Status);
		}
		[Token(Token = "0x6006E3F")]
		[Address(RVA = "0x4AA8B0", Offset = "0x4A96B0", Length = "0x4")]
		set
		{
		}
	}

	[Token(Token = "0x17000792")]
	public Graph graph
	{
		[Token(Token = "0x6006E40")]
		[Address(RVA = "0x10B6050", Offset = "0x10B4E50", Length = "0xF")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6006E41")]
	[Address(RVA = "0x10AED30", Offset = "0x10ADB30", Length = "0x8")]
	public Connection()
	{
	}

	[Token(Token = "0x6006E42")]
	[Address(RVA = "0x10B6060", Offset = "0x10B4E60", Length = "0x303")]
	public static Connection Create(Node source, Node target, int sourceIndex = -1, int targetIndex = -1)
	{
		return null;
	}

	[Token(Token = "0x6006E43")]
	[Address(RVA = "0x10B6370", Offset = "0x10B5170", Length = "0x2B6")]
	public Connection Duplicate(Node newSource, Node newTarget)
	{
		return null;
	}

	[Token(Token = "0x6006E44")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public virtual void OnCreate(int sourceIndex, int targetIndex)
	{
	}

	[Token(Token = "0x6006E45")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public virtual void OnValidate(int sourceIndex, int targetIndex)
	{
	}

	[Token(Token = "0x6006E46")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public virtual void OnDestroy()
	{
	}

	[Token(Token = "0x6006E47")]
	[Address(RVA = "0x10B6630", Offset = "0x10B5430", Length = "0x2EA")]
	public int SetSourceNode(Node newSource, int index = -1)
	{
		return 0;
	}

	[Token(Token = "0x6006E48")]
	[Address(RVA = "0x10B6920", Offset = "0x10B5720", Length = "0x2E9")]
	public int SetTargetNode(Node newTarget, int index = -1)
	{
		return 0;
	}

	[Token(Token = "0x6006E49")]
	[Address(RVA = "0x10B6C10", Offset = "0x10B5A10", Length = "0x60")]
	public sealed override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6006E4A")]
	[Address(RVA = "0x10B6C70", Offset = "0x10B5A70", Length = "0x54")]
	public Status Execute(Component agent, IBlackboard blackboard)
	{
		return default(Status);
	}

	[Token(Token = "0x6006E4B")]
	[Address(RVA = "0x10B6CD0", Offset = "0x10B5AD0", Length = "0x34")]
	public void Reset(bool recursively = true)
	{
	}

	[Token(Token = "0x6006E4C")]
	[Address(RVA = "0x10B6D10", Offset = "0x10B5B10", Length = "0x1E")]
	public void SetActiveNonRecursive(bool value)
	{
	}
}
