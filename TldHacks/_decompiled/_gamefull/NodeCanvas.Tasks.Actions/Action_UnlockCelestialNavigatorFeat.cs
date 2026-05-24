using Cpp2ILInjected;
using NodeCanvas.Framework;
using ParadoxNotion.Design;

namespace NodeCanvas.Tasks.Actions;

[Name("Unlock Celestial Navigator Feat", 0)]
[Category("TLD Actions/Utils")]
[Token(Token = "0x2001278")]
public class Action_UnlockCelestialNavigatorFeat : ActionTask
{
	[Token(Token = "0x170009B1")]
	protected override string info
	{
		[Token(Token = "0x6007824")]
		[Address(RVA = "0x116A530", Offset = "0x1169330", Length = "0x31")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6007825")]
	[Address(RVA = "0x116A570", Offset = "0x1169370", Length = "0xFA")]
	protected override void OnExecute()
	{
	}

	[Token(Token = "0x6007826")]
	[Address(RVA = "0xD769F0", Offset = "0xD757F0", Length = "0x8")]
	public Action_UnlockCelestialNavigatorFeat()
	{
	}
}
