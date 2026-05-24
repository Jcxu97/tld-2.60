using Cpp2ILInjected;
using NodeCanvas.Framework;
using ParadoxNotion;

namespace NodeCanvas.BehaviourTrees;

[Token(Token = "0x2001021")]
public abstract class BTDecorator : BTNode
{
	[Token(Token = "0x1700076E")]
	public sealed override int maxOutConnections
	{
		[Token(Token = "0x6006D91")]
		[Address(RVA = "0x457110", Offset = "0x455F10", Length = "0x6")]
		get
		{
			return 0;
		}
	}

	[Token(Token = "0x1700076F")]
	public sealed override Alignment2x2 commentsAlignment
	{
		[Token(Token = "0x6006D92")]
		[Address(RVA = "0x901E60", Offset = "0x900C60", Length = "0x6")]
		get
		{
			return default(Alignment2x2);
		}
	}

	[Token(Token = "0x17000770")]
	protected Connection decoratedConnection
	{
		[Token(Token = "0x6006D93")]
		[Address(RVA = "0x10AEE00", Offset = "0x10ADC00", Length = "0x80")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000771")]
	protected Node decoratedNode
	{
		[Token(Token = "0x6006D94")]
		[Address(RVA = "0x10AEE90", Offset = "0x10ADC90", Length = "0x1E")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6006D95")]
	[Address(RVA = "0x10AEDC0", Offset = "0x10ADBC0", Length = "0x7")]
	protected BTDecorator()
	{
	}
}
