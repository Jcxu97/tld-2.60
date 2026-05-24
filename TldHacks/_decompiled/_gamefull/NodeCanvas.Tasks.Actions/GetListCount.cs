using System.Collections;
using Cpp2ILInjected;
using NodeCanvas.Framework;
using ParadoxNotion.Design;

namespace NodeCanvas.Tasks.Actions;

[Category("✫ Blackboard/Lists")]
[Token(Token = "0x2001299")]
public class GetListCount : ActionTask
{
	[RequiredField]
	[BlackboardOnly]
	[Token(Token = "0x4008B6C")]
	[FieldOffset(Offset = "0x68")]
	public BBParameter<IList> targetList;

	[BlackboardOnly]
	[Token(Token = "0x4008B6D")]
	[FieldOffset(Offset = "0x70")]
	public BBParameter<int> saveAs;

	[Token(Token = "0x170009CB")]
	protected override string info
	{
		[Token(Token = "0x6007898")]
		[Address(RVA = "0x1170E60", Offset = "0x116FC60", Length = "0x88")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6007899")]
	[Address(RVA = "0x1170EF0", Offset = "0x116FCF0", Length = "0xAD")]
	protected override void OnExecute()
	{
	}

	[Token(Token = "0x600789A")]
	[Address(RVA = "0xD769F0", Offset = "0xD757F0", Length = "0x8")]
	public GetListCount()
	{
	}
}
