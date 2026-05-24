using Cpp2ILInjected;
using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;

namespace NodeCanvas.Tasks.Actions;

[Name("Set Parameter Bool", 0)]
[Category("Animator")]
[Description("You can either use a parameter name OR hashID. Leave the parameter name empty or none to use hashID instead.")]
[Token(Token = "0x2001285")]
public class MecanimSetBool : ActionTask<Animator>
{
	[Token(Token = "0x4008B2D")]
	[FieldOffset(Offset = "0x68")]
	public BBParameter<string> parameter;

	[Token(Token = "0x4008B2E")]
	[FieldOffset(Offset = "0x70")]
	public BBParameter<int> parameterHashID;

	[Token(Token = "0x4008B2F")]
	[FieldOffset(Offset = "0x78")]
	public BBParameter<bool> setTo;

	[Token(Token = "0x170009B9")]
	protected override string info
	{
		[Token(Token = "0x6007858")]
		[Address(RVA = "0x116D700", Offset = "0x116C500", Length = "0x106")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6007859")]
	[Address(RVA = "0x116D810", Offset = "0x116C610", Length = "0x1CF")]
	protected override void OnExecute()
	{
	}

	[Token(Token = "0x600785A")]
	[Address(RVA = "0x116D9E0", Offset = "0x116C7E0", Length = "0x44")]
	public MecanimSetBool()
	{
	}
}
