using Cpp2ILInjected;
using NodeCanvas.Framework;
using ParadoxNotion.Design;

namespace NodeCanvas.Tasks.Actions;

[Name("Get Variable To String", 0)]
[Category("✫ Blackboard")]
[Token(Token = "0x2001294")]
public class GetToString : ActionTask
{
	[BlackboardOnly]
	[Token(Token = "0x4008B62")]
	[FieldOffset(Offset = "0x68")]
	public BBParameter<object> variable;

	[BlackboardOnly]
	[Token(Token = "0x4008B63")]
	[FieldOffset(Offset = "0x70")]
	public BBParameter<string> toString;

	[Token(Token = "0x170009C7")]
	protected override string info
	{
		[Token(Token = "0x600788A")]
		[Address(RVA = "0x1170610", Offset = "0x116F410", Length = "0x88")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600788B")]
	[Address(RVA = "0x11706A0", Offset = "0x116F4A0", Length = "0xD5")]
	protected override void OnExecute()
	{
	}

	[Token(Token = "0x600788C")]
	[Address(RVA = "0xD769F0", Offset = "0xD757F0", Length = "0x8")]
	public GetToString()
	{
	}
}
