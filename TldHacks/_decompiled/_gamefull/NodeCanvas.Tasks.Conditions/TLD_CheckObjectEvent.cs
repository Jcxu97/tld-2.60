using Cpp2ILInjected;
using NodeCanvas.Framework;
using ParadoxNotion;
using ParadoxNotion.Design;
using UnityEngine;

namespace NodeCanvas.Tasks.Conditions;

[Category("TLD Conditions")]
[Description("Check if an event relating to a specific mission object has been received and return true for one frame")]
[Name("Check Object Event (EVENT)", 0)]
[EventReceiver(new string[] { "OnCustomEvent" })]
[Token(Token = "0x2001117")]
public class TLD_CheckObjectEvent : ConditionTask<GraphOwner>
{
	[RequiredField]
	[HideInInspector]
	[Token(Token = "0x400874F")]
	[FieldOffset(Offset = "0x68")]
	public BBParameter<string> eventName;

	[Token(Token = "0x4008750")]
	[FieldOffset(Offset = "0x70")]
	public BBParameter<string> missionObjectName;

	[Token(Token = "0x4008751")]
	[FieldOffset(Offset = "0x78")]
	public MissionObjectClass missionObjectClass;

	[Token(Token = "0x4008752")]
	[FieldOffset(Offset = "0x80")]
	public GameObject[] prefabTypes;

	[Token(Token = "0x170008E1")]
	protected override string info
	{
		[Token(Token = "0x60073C8")]
		[Address(RVA = "0x10F1C00", Offset = "0x10F0A00", Length = "0x32F")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60073C9")]
	[Address(RVA = "0x4A2140", Offset = "0x4A0F40", Length = "0x3")]
	protected override bool OnCheck()
	{
		return false;
	}

	[Token(Token = "0x60073CA")]
	[Address(RVA = "0x10F1F30", Offset = "0x10F0D30", Length = "0x2D1")]
	public void OnCustomEvent(EventData receivedEvent)
	{
	}

	[Token(Token = "0x60073CB")]
	[Address(RVA = "0x10F2210", Offset = "0x10F1010", Length = "0x138")]
	public TLD_CheckObjectEvent()
	{
	}
}
