using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using NodeCanvas.Framework;
using ParadoxNotion.Design;
using TLD.UI.Generics;
using UnityEngine;

namespace NodeCanvas.DialogueTrees;

[Name("TLD Multiple Choice", 0)]
[Description("Prompt a Dialogue Multiple Choice. A choice will be available if the connection's condition is true or there is no condition on that connection. The Actor selected is used for the Condition checks as well as will Say the selection if the option is checked.")]
[Token(Token = "0x20010E5")]
public class Dialogue_MultipleChoiceNode : DTNode
{
	[Token(Token = "0x20010E6")]
	public enum ChoiceCategory
	{
		[Token(Token = "0x40086C2")]
		None = 0,
		[Token(Token = "0x40086C3")]
		MissionUnlockAvailable = 6,
		[Token(Token = "0x40086C4")]
		New = 7,
		[Token(Token = "0x40086C5")]
		NewMissionUnlockAvailable = 8
	}

	[Serializable]
	[Token(Token = "0x20010E7")]
	public class Choice
	{
		[Token(Token = "0x40086C6")]
		[FieldOffset(Offset = "0x10")]
		public bool isUnfolded;

		[Token(Token = "0x40086C7")]
		[FieldOffset(Offset = "0x11")]
		public bool isHidden;

		[Token(Token = "0x40086C8")]
		[FieldOffset(Offset = "0x14")]
		public DialogueOptionTopic topic;

		[Token(Token = "0x40086C9")]
		[FieldOffset(Offset = "0x18")]
		public ChoiceCategory category;

		[Token(Token = "0x40086CA")]
		[FieldOffset(Offset = "0x20")]
		public VoiceOverItem statement;

		[Token(Token = "0x40086CB")]
		[FieldOffset(Offset = "0x28")]
		public ConditionTask condition;

		[Token(Token = "0x40086CC")]
		[FieldOffset(Offset = "0x30")]
		public ConditionTask showChoiceCondition;

		[Token(Token = "0x40086CD")]
		[FieldOffset(Offset = "0x38")]
		public BBParameter<float> textSize;

		[Token(Token = "0x60072A8")]
		[Address(RVA = "0x10E4910", Offset = "0x10E3710", Length = "0x89")]
		public Choice()
		{
		}

		[Token(Token = "0x60072A9")]
		[Address(RVA = "0x10E49A0", Offset = "0x10E37A0", Length = "0xFB")]
		public Choice(VoiceOverItem statement)
		{
		}
	}

	[Token(Token = "0x40086AF")]
	[FieldOffset(Offset = "0x88")]
	private bool m_DialogueChoicesSpecified;

	[Token(Token = "0x40086B0")]
	[FieldOffset(Offset = "0x90")]
	private List<string> m_LocalizedChoices;

	[Token(Token = "0x40086B1")]
	[FieldOffset(Offset = "0x98")]
	private List<ChoiceCategory> m_CategoryChoices;

	[Token(Token = "0x40086B2")]
	[FieldOffset(Offset = "0xA0")]
	private List<DialogueOptionTopic> m_TopicChoices;

	[Token(Token = "0x40086B3")]
	[FieldOffset(Offset = "0xA8")]
	private Dictionary<int, int> m_LocalizedChoicesMapToAvailableChoices;

	[Token(Token = "0x40086B4")]
	[FieldOffset(Offset = "0xB0")]
	private PanelReference<Panel_HUD> m_HUD;

	[Token(Token = "0x40086B5")]
	[FieldOffset(Offset = "0xB8")]
	public float availableTime;

	[Token(Token = "0x40086B6")]
	[FieldOffset(Offset = "0xBC")]
	public bool saySelection;

	[Token(Token = "0x40086B7")]
	[FieldOffset(Offset = "0xBD")]
	public bool useEndingChoice;

	[Token(Token = "0x40086B8")]
	[FieldOffset(Offset = "0xC0")]
	public int endingChoiceIndex;

	[Token(Token = "0x40086B9")]
	[FieldOffset(Offset = "0xC4")]
	public bool enableExitUI;

	[Token(Token = "0x40086BA")]
	[FieldOffset(Offset = "0xC5")]
	public bool useTwoButtonUI;

	[Token(Token = "0x40086BB")]
	[FieldOffset(Offset = "0xC8")]
	public List<Choice> availableChoices;

	[Token(Token = "0x40086BC")]
	[FieldOffset(Offset = "0xD0")]
	private bool m_ExitRequested;

	[Token(Token = "0x40086BD")]
	[FieldOffset(Offset = "0xD1")]
	private bool m_ChoiceSelected;

	[Token(Token = "0x40086BE")]
	[FieldOffset(Offset = "0xD2")]
	private bool m_EndingChoicePending;

	[Token(Token = "0x40086BF")]
	[FieldOffset(Offset = "0xD4")]
	private PlayerControlMode m_PreviousControlMode;

	[Token(Token = "0x40086C0")]
	[FieldOffset(Offset = "0xD8")]
	private bool m_HasSetEnableExit;

	[Token(Token = "0x17000884")]
	public override int maxOutConnections
	{
		[Token(Token = "0x60072A0")]
		[Address(RVA = "0x10E2CB0", Offset = "0x10E1AB0", Length = "0x44")]
		get
		{
			return 0;
		}
	}

	[Token(Token = "0x600729F")]
	[Address(RVA = "0x10E29F0", Offset = "0x10E17F0", Length = "0x2B7")]
	public Task[] GetSubTasks()
	{
		return null;
	}

	[Token(Token = "0x60072A1")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public override void OnChildConnected(int index)
	{
	}

	[Token(Token = "0x60072A2")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public override void OnChildDisconnected(int index)
	{
	}

	[Token(Token = "0x60072A3")]
	[Address(RVA = "0x10E2D00", Offset = "0x10E1B00", Length = "0x1372")]
	protected override Status OnExecute(Component agent, IBlackboard bb)
	{
		return default(Status);
	}

	[Token(Token = "0x60072A4")]
	[Address(RVA = "0x10E4080", Offset = "0x10E2E80", Length = "0xA4")]
	private void OnExitRequested()
	{
	}

	[Token(Token = "0x60072A5")]
	[Address(RVA = "0x10E4130", Offset = "0x10E2F30", Length = "0x25B")]
	private void MaybeShowTwoButtonsUI()
	{
	}

	[Token(Token = "0x60072A6")]
	[Address(RVA = "0x10E4390", Offset = "0x10E3190", Length = "0x24A")]
	private void OnButtonSelected(int buttonSelected)
	{
	}

	[Token(Token = "0x60072A7")]
	[Address(RVA = "0x10E45E0", Offset = "0x10E33E0", Length = "0x324")]
	public Dialogue_MultipleChoiceNode()
	{
	}
}
