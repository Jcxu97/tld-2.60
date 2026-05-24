using Cpp2ILInjected;
using NodeCanvas.Framework;
using ParadoxNotion.Design;

namespace NodeCanvas.Tasks.Actions;

[Name("Fail Mission", 0)]
[Category("TLD Actions")]
[Token(Token = "0x20011EA")]
public class Action_FailMission : ActionTask
{
	[Token(Token = "0x4008952")]
	[FieldOffset(Offset = "0x68")]
	public BBParameter<LocalizedString> failureMessage;

	[Token(Token = "0x1700096F")]
	protected override string info
	{
		[Token(Token = "0x6007698")]
		[Address(RVA = "0x114B1E0", Offset = "0x1149FE0", Length = "0x129")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6007699")]
	[Address(RVA = "0x114B310", Offset = "0x114A110", Length = "0x1FD")]
	protected override void OnExecute()
	{
	}

	[Token(Token = "0x600769A")]
	[Address(RVA = "0x114B510", Offset = "0x114A310", Length = "0x108")]
	public Action_FailMission()
	{
	}
}
