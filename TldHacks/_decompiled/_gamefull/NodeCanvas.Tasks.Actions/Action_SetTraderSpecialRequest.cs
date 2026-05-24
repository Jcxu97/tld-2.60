using Cpp2ILInjected;
using NodeCanvas.Framework;
using ParadoxNotion.Design;

namespace NodeCanvas.Tasks.Actions;

[Name("Set Trader Special Request", 0)]
[Description("Sets the localized header and description for a Trader Special Request")]
[Category("TLD Actions/Trader")]
[Token(Token = "0x2001239")]
public class Action_SetTraderSpecialRequest : ActionTask
{
	[Token(Token = "0x4008A60")]
	[FieldOffset(Offset = "0x68")]
	public string m_HeaderLocID;

	[Token(Token = "0x4008A61")]
	[FieldOffset(Offset = "0x70")]
	public string m_DescriptionLocID;

	[Token(Token = "0x1700098C")]
	private bool IsClearing
	{
		[Token(Token = "0x600777A")]
		[Address(RVA = "0x115D5D0", Offset = "0x115C3D0", Length = "0x24")]
		get
		{
			return false;
		}
	}

	[Token(Token = "0x1700098D")]
	protected override string info
	{
		[Token(Token = "0x600777B")]
		[Address(RVA = "0x115D600", Offset = "0x115C400", Length = "0x6D")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600777C")]
	[Address(RVA = "0x115D670", Offset = "0x115C470", Length = "0xDF")]
	protected override void OnExecute()
	{
	}

	[Token(Token = "0x600777D")]
	[Address(RVA = "0xD769F0", Offset = "0xD757F0", Length = "0x8")]
	public Action_SetTraderSpecialRequest()
	{
	}
}
