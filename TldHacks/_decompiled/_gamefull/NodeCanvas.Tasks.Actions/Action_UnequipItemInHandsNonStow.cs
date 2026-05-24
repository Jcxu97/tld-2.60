using Cpp2ILInjected;
using NodeCanvas.Framework;
using ParadoxNotion.Design;

namespace NodeCanvas.Tasks.Actions;

[Name("Unequip Item In Hands", 0)]
[Description("Unequips the current item in hands")]
[Category("TLD Actions/Player")]
[Token(Token = "0x20011DE")]
public class Action_UnequipItemInHandsNonStow : ActionTask
{
	[Token(Token = "0x400893A")]
	[FieldOffset(Offset = "0x68")]
	public BBParameter<bool> m_UnequipImmediately;

	[Token(Token = "0x17000968")]
	protected override string info
	{
		[Token(Token = "0x6007672")]
		[Address(RVA = "0x1148220", Offset = "0x1147020", Length = "0x98")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6007673")]
	[Address(RVA = "0x11482C0", Offset = "0x11470C0", Length = "0xCF")]
	protected override void OnExecute()
	{
	}

	[Token(Token = "0x6007674")]
	[Address(RVA = "0x1148390", Offset = "0x1147190", Length = "0x93")]
	public Action_UnequipItemInHandsNonStow()
	{
	}
}
