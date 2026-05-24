using Cpp2ILInjected;
using ParadoxNotion;

namespace NodeCanvas.BehaviourTrees;

[Token(Token = "0x2001020")]
public abstract class BTComposite : BTNode
{
	[Token(Token = "0x1700076B")]
	public override string name
	{
		[Token(Token = "0x6006D8D")]
		[Address(RVA = "0x10AEDD0", Offset = "0x10ADBD0", Length = "0x23")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700076C")]
	public sealed override int maxOutConnections
	{
		[Token(Token = "0x6006D8E")]
		[Address(RVA = "0xC7D4F0", Offset = "0xC7C2F0", Length = "0x6")]
		get
		{
			return 0;
		}
	}

	[Token(Token = "0x1700076D")]
	public sealed override Alignment2x2 commentsAlignment
	{
		[Token(Token = "0x6006D8F")]
		[Address(RVA = "0x901E60", Offset = "0x900C60", Length = "0x6")]
		get
		{
			return default(Alignment2x2);
		}
	}

	[Token(Token = "0x6006D90")]
	[Address(RVA = "0x10AEDC0", Offset = "0x10ADBC0", Length = "0x7")]
	protected BTComposite()
	{
	}
}
