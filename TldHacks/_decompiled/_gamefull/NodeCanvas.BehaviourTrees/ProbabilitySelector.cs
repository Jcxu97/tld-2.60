using System.Collections.Generic;
using Cpp2ILInjected;
using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;

namespace NodeCanvas.BehaviourTrees;

[Category("Composites")]
[Description("Select a child to execute based on it's chance to be selected and return Success if it returns Success, otherwise pick another.\nReturns Failure if no child returns Success or a direct 'Failure Chance' is introduced")]
[Icon("ProbabilitySelector", false, null)]
[Color("b3ff7f")]
[Token(Token = "0x2001027")]
public class ProbabilitySelector : BTComposite
{
	[Token(Token = "0x40084A9")]
	[FieldOffset(Offset = "0x78")]
	public List<BBParameter<float>> childWeights;

	[Token(Token = "0x40084AA")]
	[FieldOffset(Offset = "0x80")]
	public BBParameter<float> failChance;

	[Token(Token = "0x40084AB")]
	[FieldOffset(Offset = "0x88")]
	public BBParameter<bool> synchronous;

	[Token(Token = "0x40084AC")]
	[FieldOffset(Offset = "0x90")]
	private float probability;

	[Token(Token = "0x40084AD")]
	[FieldOffset(Offset = "0x94")]
	private float currentProbability;

	[Token(Token = "0x40084AE")]
	[FieldOffset(Offset = "0x98")]
	private List<int> failedIndeces;

	[Token(Token = "0x6006DAD")]
	[Address(RVA = "0x10AFF90", Offset = "0x10AED90", Length = "0x183")]
	public override void OnChildConnected(int index)
	{
	}

	[Token(Token = "0x6006DAE")]
	[Address(RVA = "0x10B0120", Offset = "0x10AEF20", Length = "0x56")]
	public override void OnChildDisconnected(int index)
	{
	}

	[Token(Token = "0x6006DAF")]
	[Address(RVA = "0x10B0180", Offset = "0x10AEF80", Length = "0x11")]
	public override void OnGraphStarted()
	{
	}

	[Token(Token = "0x6006DB0")]
	[Address(RVA = "0x10B01A0", Offset = "0x10AEFA0", Length = "0x327")]
	protected override Status OnExecute(Component agent, IBlackboard blackboard)
	{
		return default(Status);
	}

	[Token(Token = "0x6006DB1")]
	[Address(RVA = "0x10B04D0", Offset = "0x10AF2D0", Length = "0xAD")]
	protected override void OnReset()
	{
	}

	[Token(Token = "0x6006DB2")]
	[Address(RVA = "0x10B0580", Offset = "0x10AF380", Length = "0x1B1")]
	private float GetTotal()
	{
		return 0f;
	}

	[Token(Token = "0x6006DB3")]
	[Address(RVA = "0x10B0740", Offset = "0x10AF540", Length = "0x2E2")]
	public ProbabilitySelector()
	{
	}
}
