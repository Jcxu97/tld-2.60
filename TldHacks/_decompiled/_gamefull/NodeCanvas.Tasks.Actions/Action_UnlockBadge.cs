using Cpp2ILInjected;
using NodeCanvas.Framework;
using ParadoxNotion.Design;
using TLD.SaveState;

namespace NodeCanvas.Tasks.Actions;

[Name("Unlock Badge", 0)]
[Category("TLD Actions/Utils")]
[Token(Token = "0x2001279")]
public class Action_UnlockBadge : ActionTask
{
	[Token(Token = "0x4008B03")]
	[FieldOffset(Offset = "0x68")]
	public BadgeInfoType m_Badge;

	[Token(Token = "0x4008B04")]
	[FieldOffset(Offset = "0x6C")]
	public bool m_SkipProfileSave;

	[Token(Token = "0x170009B2")]
	protected override string info
	{
		[Token(Token = "0x6007827")]
		[Address(RVA = "0x116A670", Offset = "0x1169470", Length = "0xA3")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6007828")]
	[Address(RVA = "0x116A720", Offset = "0x1169520", Length = "0x2A")]
	protected override void OnExecute()
	{
	}

	[Token(Token = "0x6007829")]
	[Address(RVA = "0xD769F0", Offset = "0xD757F0", Length = "0x8")]
	public Action_UnlockBadge()
	{
	}
}
