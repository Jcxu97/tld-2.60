using Cpp2ILInjected;
using NodeCanvas.Framework;
using ParadoxNotion;
using ParadoxNotion.Design;
using UnityEngine;

namespace NodeCanvas.Tasks.Conditions;

[Category("System Events")]
[EventReceiver(new string[] { "OnTriggerEnter", "OnTriggerExit" })]
[Token(Token = "0x2001195")]
public class CheckTrigger : ConditionTask<Collider>
{
	[Token(Token = "0x400887C")]
	[FieldOffset(Offset = "0x68")]
	public TriggerTypes checkType;

	[Token(Token = "0x400887D")]
	[FieldOffset(Offset = "0x6C")]
	public bool specifiedTagOnly;

	[TagField]
	[ShowIf("specifiedTagOnly", 1)]
	[Token(Token = "0x400887E")]
	[FieldOffset(Offset = "0x70")]
	public string objectTag;

	[BlackboardOnly]
	[Token(Token = "0x400887F")]
	[FieldOffset(Offset = "0x78")]
	public BBParameter<GameObject> saveGameObjectAs;

	[Token(Token = "0x4008880")]
	[FieldOffset(Offset = "0x80")]
	private bool stay;

	[Token(Token = "0x1700094F")]
	protected override string info
	{
		[Token(Token = "0x600758A")]
		[Address(RVA = "0x110FC20", Offset = "0x110EA20", Length = "0xCD")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600758B")]
	[Address(RVA = "0x110FCF0", Offset = "0x110EAF0", Length = "0x11")]
	protected override bool OnCheck()
	{
		return false;
	}

	[Token(Token = "0x600758C")]
	[Address(RVA = "0x110FD10", Offset = "0x110EB10", Length = "0xF4")]
	public void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x600758D")]
	[Address(RVA = "0x110FE10", Offset = "0x110EC10", Length = "0xF1")]
	public void OnTriggerExit(Collider other)
	{
	}

	[Token(Token = "0x600758E")]
	[Address(RVA = "0x110FF10", Offset = "0x110ED10", Length = "0x9E")]
	public CheckTrigger()
	{
	}
}
