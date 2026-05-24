using Cpp2ILInjected;
using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;

namespace NodeCanvas.DialogueTrees;

[Name("JUMP", 0)]
[Description("Select a target node to jump to.\nFor your convenience in identifying nodes in the dropdown, please give a Tag name to the nodes you want to use in this way.")]
[Category("Control")]
[Icon("Set", false, null)]
[Color("00b9e8")]
[Token(Token = "0x20010FD")]
public class Jumper : DTNode
{
	[SerializeField]
	[Token(Token = "0x40086FC")]
	[FieldOffset(Offset = "0x88")]
	private string _sourceNodeUID;

	[Token(Token = "0x40086FD")]
	[FieldOffset(Offset = "0x90")]
	private object _sourceNode;

	[Token(Token = "0x170008BF")]
	private string sourceNodeUID
	{
		[Token(Token = "0x6007339")]
		[Address(RVA = "0x4C0240", Offset = "0x4BF040", Length = "0x8")]
		get
		{
			return null;
		}
		[Token(Token = "0x600733A")]
		[Address(RVA = "0xB69600", Offset = "0xB68400", Length = "0x52")]
		set
		{
		}
	}

	[Token(Token = "0x170008C0")]
	private DTNode sourceNode
	{
		[Token(Token = "0x600733B")]
		[Address(RVA = "0x10E93A0", Offset = "0x10E81A0", Length = "0x209")]
		get
		{
			return null;
		}
		[Token(Token = "0x600733C")]
		[Address(RVA = "0x40DA10", Offset = "0x40C810", Length = "0x52")]
		set
		{
		}
	}

	[Token(Token = "0x170008C1")]
	public override int maxOutConnections
	{
		[Token(Token = "0x600733D")]
		[Address(RVA = "0x4582A0", Offset = "0x4570A0", Length = "0x3")]
		get
		{
			return 0;
		}
	}

	[Token(Token = "0x170008C2")]
	public override bool requireActorSelection
	{
		[Token(Token = "0x600733E")]
		[Address(RVA = "0x4A2140", Offset = "0x4A0F40", Length = "0x3")]
		get
		{
			return false;
		}
	}

	[Token(Token = "0x170008C3")]
	public override string name
	{
		[Token(Token = "0x600733F")]
		[Address(RVA = "0x10E95B0", Offset = "0x10E83B0", Length = "0x10E")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6007340")]
	[Address(RVA = "0x10E96C0", Offset = "0x10E84C0", Length = "0x91")]
	protected override Status OnExecute(Component agent, IBlackboard bb)
	{
		return default(Status);
	}

	[Token(Token = "0x6007341")]
	[Address(RVA = "0x10E0B40", Offset = "0x10DF940", Length = "0x7")]
	public Jumper()
	{
	}
}
