using Cpp2ILInjected;
using NodeCanvas.Framework;
using ParadoxNotion.Design;

namespace NodeCanvas.Tasks.Actions;

[Category("✫ Blackboard")]
[Description("Loads the blackboard variables previously saved in the provided PlayerPrefs key if at all. Returns false if no saves found or load was failed")]
[Token(Token = "0x20012A1")]
public class LoadBlackboard : ActionTask<Blackboard>
{
	[RequiredField]
	[Token(Token = "0x4008B7F")]
	[FieldOffset(Offset = "0x68")]
	public BBParameter<string> saveKey;

	[Token(Token = "0x170009D1")]
	protected override string info
	{
		[Token(Token = "0x60078AF")]
		[Address(RVA = "0x11718B0", Offset = "0x11706B0", Length = "0x9B")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60078B0")]
	[Address(RVA = "0x1171950", Offset = "0x1170750", Length = "0xD9")]
	protected override void OnExecute()
	{
	}

	[Token(Token = "0x60078B1")]
	[Address(RVA = "0x1171A30", Offset = "0x1170830", Length = "0x44")]
	public LoadBlackboard()
	{
	}
}
