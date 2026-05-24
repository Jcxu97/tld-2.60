using Cpp2ILInjected;
using NodeCanvas.Framework;
using ParadoxNotion.Design;

[Name("Force Hunted Anim For Struggle", 0)]
[Description("Forces the bear struggles to use the Hunted animation")]
[Category("TLD Actions/Code Missions")]
[Token(Token = "0x2000850")]
public class Action_ForceHuntedStruggleAnim : ActionTask
{
	[Name("Set Bear Encounter Player Outcome After Spear Miss", 0)]
	[Description("Set what happens to the player after failing to raise the spear when bear charges. Default is not dying.")]
	[Category("TLD Actions/Code Missions")]
	[Token(Token = "0x2000851")]
	public class Action_SetBearEncounterPlayerOutcomeAfterSpearMiss : ActionTask
	{
		[Token(Token = "0x400568E")]
		[FieldOffset(Offset = "0x68")]
		public bool m_PlayerDies;

		[Token(Token = "0x17000357")]
		protected override string info
		{
			[Token(Token = "0x6004CC6")]
			[Address(RVA = "0xD77400", Offset = "0xD76200", Length = "0x54")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6004CC7")]
		[Address(RVA = "0xD77460", Offset = "0xD76260", Length = "0xA6")]
		protected override void OnExecute()
		{
		}

		[Token(Token = "0x6004CC8")]
		[Address(RVA = "0xD769F0", Offset = "0xD757F0", Length = "0x8")]
		public Action_SetBearEncounterPlayerOutcomeAfterSpearMiss()
		{
		}
	}

	[Token(Token = "0x4005688")]
	[FieldOffset(Offset = "0x68")]
	public BBParameter<bool> forceHuntedStruggleAnim;

	[Token(Token = "0x4005689")]
	[FieldOffset(Offset = "0x70")]
	public BBParameter<bool> dropItems;

	[Token(Token = "0x400568A")]
	[FieldOffset(Offset = "0x78")]
	public BBParameter<bool> shouldForceHuntedStruggleDragFacing;

	[Token(Token = "0x400568B")]
	[FieldOffset(Offset = "0x80")]
	public BBParameter<float> forceHuntedStruggleDragFacingAngle;

	[Token(Token = "0x400568C")]
	[FieldOffset(Offset = "0x88")]
	public BBParameter<float> forceHuntedStruggleDragRollAngle;

	[Token(Token = "0x400568D")]
	[FieldOffset(Offset = "0x90")]
	public string struggleFaceTargetObjectIdentifier;

	[Token(Token = "0x6004CC4")]
	[Address(RVA = "0xD76DD0", Offset = "0xD75BD0", Length = "0x4B3")]
	protected override void OnExecute()
	{
	}

	[Token(Token = "0x6004CC5")]
	[Address(RVA = "0xD77290", Offset = "0xD76090", Length = "0x162")]
	public Action_ForceHuntedStruggleAnim()
	{
	}
}
