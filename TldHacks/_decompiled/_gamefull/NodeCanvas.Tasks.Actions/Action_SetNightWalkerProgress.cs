using Cpp2ILInjected;
using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;

namespace NodeCanvas.Tasks.Actions;

[Name("Set Night Walker Feat Progress", 0)]
[Category("TLD Actions/Utils")]
[Token(Token = "0x200127A")]
public class Action_SetNightWalkerProgress : ActionTask
{
	[Range(0f, 1f)]
	[Token(Token = "0x4008B05")]
	[FieldOffset(Offset = "0x68")]
	public float m_Progress;

	[Token(Token = "0x4008B06")]
	[FieldOffset(Offset = "0x6C")]
	public bool m_SkipProfileSave;

	[Token(Token = "0x4008B07")]
	[FieldOffset(Offset = "0x6D")]
	private bool m_ReadyToRun;

	[Token(Token = "0x170009B3")]
	protected override string info
	{
		[Token(Token = "0x600782A")]
		[Address(RVA = "0x116A750", Offset = "0x1169550", Length = "0x9E")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600782B")]
	[Address(RVA = "0x116A7F0", Offset = "0x11695F0", Length = "0xD1")]
	protected override void OnExecute()
	{
	}

	[Token(Token = "0x600782C")]
	[Address(RVA = "0x116A8D0", Offset = "0x11696D0", Length = "0xBB")]
	protected override void OnUpdate()
	{
	}

	[Token(Token = "0x600782D")]
	[Address(RVA = "0xD769F0", Offset = "0xD757F0", Length = "0x8")]
	public Action_SetNightWalkerProgress()
	{
	}
}
