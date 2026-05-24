using Cpp2ILInjected;
using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;

namespace NodeCanvas.Tasks.Actions;

[Name("Set Parameter Integer", 0)]
[Category("Animator")]
[Description("You can either use a parameter name OR hashID. Leave the parameter name empty or none to use hashID instead.")]
[Token(Token = "0x2001288")]
public class MecanimSetInt : ActionTask<Animator>
{
	[Token(Token = "0x4008B38")]
	[FieldOffset(Offset = "0x68")]
	public BBParameter<string> parameter;

	[Token(Token = "0x4008B39")]
	[FieldOffset(Offset = "0x70")]
	public BBParameter<int> parameterHashID;

	[Token(Token = "0x4008B3A")]
	[FieldOffset(Offset = "0x78")]
	public BBParameter<int> setTo;

	[Token(Token = "0x170009BC")]
	protected override string info
	{
		[Token(Token = "0x6007864")]
		[Address(RVA = "0x116E420", Offset = "0x116D220", Length = "0x106")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6007865")]
	[Address(RVA = "0x116E530", Offset = "0x116D330", Length = "0x1BC")]
	protected override void OnExecute()
	{
	}

	[Token(Token = "0x6007866")]
	[Address(RVA = "0x116E6F0", Offset = "0x116D4F0", Length = "0x44")]
	public MecanimSetInt()
	{
	}
}
