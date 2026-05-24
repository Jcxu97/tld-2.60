using Cpp2ILInjected;
using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;

namespace NodeCanvas.Tasks.Conditions;

[Name("Is In Transition", 0)]
[Category("Animator")]
[Token(Token = "0x2001167")]
public class MecanimIsInTransition : ConditionTask<Animator>
{
	[Token(Token = "0x40087F8")]
	[FieldOffset(Offset = "0x68")]
	public BBParameter<int> layerIndex;

	[Token(Token = "0x17000916")]
	protected override string info
	{
		[Token(Token = "0x60074C0")]
		[Address(RVA = "0x1103490", Offset = "0x1102290", Length = "0x31")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60074C1")]
	[Address(RVA = "0x11034D0", Offset = "0x11022D0", Length = "0xC6")]
	protected override bool OnCheck()
	{
		return false;
	}

	[Token(Token = "0x60074C2")]
	[Address(RVA = "0x11035A0", Offset = "0x11023A0", Length = "0x44")]
	public MecanimIsInTransition()
	{
	}
}
