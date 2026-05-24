using System;
using Cpp2ILInjected;
using NodeCanvas.Framework;
using ParadoxNotion;

namespace NodeCanvas.BehaviourTrees;

[Token(Token = "0x200101F")]
public abstract class BTNode : Node
{
	[Token(Token = "0x17000765")]
	public sealed override Type outConnectionType
	{
		[Token(Token = "0x6006D84")]
		[Address(RVA = "0x10AED40", Offset = "0x10ADB40", Length = "0x7D")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000766")]
	public override int maxInConnections
	{
		[Token(Token = "0x6006D85")]
		[Address(RVA = "0x457110", Offset = "0x455F10", Length = "0x6")]
		get
		{
			return 0;
		}
	}

	[Token(Token = "0x17000767")]
	public override int maxOutConnections
	{
		[Token(Token = "0x6006D86")]
		[Address(RVA = "0x4582A0", Offset = "0x4570A0", Length = "0x3")]
		get
		{
			return 0;
		}
	}

	[Token(Token = "0x17000768")]
	public override bool allowAsPrime
	{
		[Token(Token = "0x6006D87")]
		[Address(RVA = "0x430B50", Offset = "0x42F950", Length = "0x3")]
		get
		{
			return false;
		}
	}

	[Token(Token = "0x17000769")]
	public override Alignment2x2 commentsAlignment
	{
		[Token(Token = "0x6006D88")]
		[Address(RVA = "0x7D84A0", Offset = "0x7D72A0", Length = "0x6")]
		get
		{
			return default(Alignment2x2);
		}
	}

	[Token(Token = "0x1700076A")]
	public override Alignment2x2 iconAlignment
	{
		[Token(Token = "0x6006D89")]
		[Address(RVA = "0x4582A0", Offset = "0x4570A0", Length = "0x3")]
		get
		{
			return default(Alignment2x2);
		}
	}

	[Token(Token = "0x6006D8A")]
	[Address(RVA = "0x1870790", Offset = "0x186F590", Length = "0xF3")]
	public T AddChild<T>(int childIndex) where T : BTNode
	{
		return null;
	}

	[Token(Token = "0x6006D8B")]
	[Address(RVA = "0x1870690", Offset = "0x186F490", Length = "0xF8")]
	public T AddChild<T>() where T : BTNode
	{
		return null;
	}

	[Token(Token = "0x6006D8C")]
	[Address(RVA = "0x10AEDC0", Offset = "0x10ADBC0", Length = "0x7")]
	protected BTNode()
	{
	}
}
