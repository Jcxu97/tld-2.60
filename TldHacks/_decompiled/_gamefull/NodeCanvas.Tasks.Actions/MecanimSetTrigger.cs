using Cpp2ILInjected;
using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;

namespace NodeCanvas.Tasks.Actions;

[Name("Set Parameter Trigger", 0)]
[Category("Animator")]
[Description("You can either use a parameter name OR hashID. Leave the parameter name empty or none to use hashID instead.")]
[Token(Token = "0x200128B")]
public class MecanimSetTrigger : ActionTask<Animator>
{
	[Token(Token = "0x4008B46")]
	[FieldOffset(Offset = "0x68")]
	public BBParameter<string> parameter;

	[Token(Token = "0x4008B47")]
	[FieldOffset(Offset = "0x70")]
	public BBParameter<int> parameterHashID;

	[Token(Token = "0x170009BF")]
	protected override string info
	{
		[Token(Token = "0x600786F")]
		[Address(RVA = "0x116F5E0", Offset = "0x116E3E0", Length = "0x102")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6007870")]
	[Address(RVA = "0x116F6F0", Offset = "0x116E4F0", Length = "0x178")]
	protected override void OnExecute()
	{
	}

	[Token(Token = "0x6007871")]
	[Address(RVA = "0x116F870", Offset = "0x116E670", Length = "0x44")]
	public MecanimSetTrigger()
	{
	}
}
