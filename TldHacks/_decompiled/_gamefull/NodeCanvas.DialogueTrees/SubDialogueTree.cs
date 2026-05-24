using System.Collections.Generic;
using Cpp2ILInjected;
using NodeCanvas.Framework;
using NodeCanvas.Framework.Internal;
using ParadoxNotion.Design;
using UnityEngine;

namespace NodeCanvas.DialogueTrees;

[Name("Sub Dialogue Tree", 0)]
[Category("Nested")]
[Description("Execute a Sub Dialogue Tree. When that Dialogue Tree is finished, this node will continue either in Success or Failure if it has any connections.\nUseful for making reusable and self-contained Dialogue Trees.")]
[Token(Token = "0x2001107")]
public class SubDialogueTree : DTNode, IGraphAssignable, ISubParametersContainer
{
	[Token(Token = "0x4008711")]
	[FieldOffset(Offset = "0x88")]
	public BBParameter<bool> trustDialogue;

	[SerializeField]
	[Token(Token = "0x4008712")]
	[FieldOffset(Offset = "0x90")]
	private BBParameter<DialogueTree> _subTree;

	[SerializeField]
	[Token(Token = "0x4008713")]
	[FieldOffset(Offset = "0x98")]
	private Dictionary<string, string> actorParametersMap;

	[SerializeField]
	[Token(Token = "0x4008714")]
	[FieldOffset(Offset = "0xA0")]
	private Dictionary<string, BBObjectParameter> variablesMap;

	[Token(Token = "0x4008715")]
	[FieldOffset(Offset = "0xA8")]
	private Dictionary<DialogueTree, DialogueTree> instances;

	[Token(Token = "0x170008C9")]
	public override int maxOutConnections
	{
		[Token(Token = "0x6007368")]
		[Address(RVA = "0x901E60", Offset = "0x900C60", Length = "0x6")]
		get
		{
			return 0;
		}
	}

	[Token(Token = "0x170008CA")]
	public DialogueTree subTree
	{
		[Token(Token = "0x6007369")]
		[Address(RVA = "0x10EBB30", Offset = "0x10EA930", Length = "0x4C")]
		get
		{
			return null;
		}
		[Token(Token = "0x600736A")]
		[Address(RVA = "0x10EBB80", Offset = "0x10EA980", Length = "0x5B")]
		set
		{
		}
	}

	[Token(Token = "0x170008CB")]
	Graph IGraphAssignable.nestedGraph
	{
		[Token(Token = "0x600736B")]
		[Address(RVA = "0x10EBB30", Offset = "0x10EA930", Length = "0x4C")]
		get
		{
			return null;
		}
		[Token(Token = "0x600736C")]
		[Address(RVA = "0x10EBBE0", Offset = "0x10EA9E0", Length = "0xB1")]
		set
		{
		}
	}

	[Token(Token = "0x600736D")]
	[Address(RVA = "0x10EBCA0", Offset = "0x10EAAA0", Length = "0xE2")]
	Graph[] IGraphAssignable.GetInstances()
	{
		return null;
	}

	[Token(Token = "0x600736E")]
	[Address(RVA = "0x10EBD90", Offset = "0x10EAB90", Length = "0xE2")]
	BBParameter[] ISubParametersContainer.GetSubParameters()
	{
		return null;
	}

	[Token(Token = "0x600736F")]
	[Address(RVA = "0x10EBE80", Offset = "0x10EAC80", Length = "0x42D")]
	protected override Status OnExecute(Component agent, IBlackboard bb)
	{
		return default(Status);
	}

	[Token(Token = "0x6007370")]
	[Address(RVA = "0x10EC2B0", Offset = "0x10EB0B0", Length = "0x2D3")]
	private void SetActorParametersMapping()
	{
	}

	[Token(Token = "0x6007371")]
	[Address(RVA = "0x10EC590", Offset = "0x10EB390", Length = "0x299")]
	private void SetVariablesMapping()
	{
	}

	[Token(Token = "0x6007372")]
	[Address(RVA = "0x10EC830", Offset = "0x10EB630", Length = "0x37")]
	private void OnSubDialogueFinish(bool success)
	{
	}

	[Token(Token = "0x6007373")]
	[Address(RVA = "0x10EC870", Offset = "0x10EB670", Length = "0xE9")]
	public override void OnGraphStoped()
	{
	}

	[Token(Token = "0x6007374")]
	[Address(RVA = "0x10EC960", Offset = "0x10EB760", Length = "0xE6")]
	public override void OnGraphPaused()
	{
	}

	[Token(Token = "0x6007375")]
	[Address(RVA = "0x10ECA50", Offset = "0x10EB850", Length = "0x5B")]
	private bool IsInstance(DialogueTree dt)
	{
		return false;
	}

	[Token(Token = "0x6007376")]
	[Address(RVA = "0x10ECAB0", Offset = "0x10EB8B0", Length = "0x291")]
	private void CheckInstance()
	{
	}

	[Token(Token = "0x6007377")]
	[Address(RVA = "0x10ECD50", Offset = "0x10EBB50", Length = "0x1F2")]
	public SubDialogueTree()
	{
	}
}
