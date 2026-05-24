using Cpp2ILInjected;
using NodeCanvas.Framework;
using ParadoxNotion.Design;

namespace NodeCanvas.Tasks.Actions;

[Name("Suppress Explore Music", 0)]
[Description("Suppress or restore the Explore Music")]
[Category("TLD Actions/Audio")]
[Token(Token = "0x20011C0")]
public class ACtion_SuppressExploreMusic : ActionTask
{
	[Token(Token = "0x40088E6")]
	[FieldOffset(Offset = "0x68")]
	public bool suppress;

	[Token(Token = "0x40088E7")]
	[FieldOffset(Offset = "0x69")]
	public bool resetTimerOnRestore;

	[Token(Token = "0x1700095D")]
	protected override string info
	{
		[Token(Token = "0x600761B")]
		[Address(RVA = "0x11183A0", Offset = "0x11171A0", Length = "0x54")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600761C")]
	[Address(RVA = "0x1118400", Offset = "0x1117200", Length = "0x1D5")]
	protected override void OnExecute()
	{
	}

	[Token(Token = "0x600761D")]
	[Address(RVA = "0x11185E0", Offset = "0x11173E0", Length = "0xC")]
	public ACtion_SuppressExploreMusic()
	{
	}
}
