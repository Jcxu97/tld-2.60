using Cpp2ILInjected;
using NodeCanvas.Framework;
using ParadoxNotion;
using ParadoxNotion.Design;
using UnityEngine;

namespace NodeCanvas.Tasks.Conditions;

[Category("System Events")]
[Name("Check Trigger 2D", 0)]
[EventReceiver(new string[] { "OnTriggerEnter2D", "OnTriggerExit2D" })]
[Token(Token = "0x2001196")]
public class CheckTrigger2D : ConditionTask<Collider2D>
{
	[Token(Token = "0x4008881")]
	[FieldOffset(Offset = "0x68")]
	public TriggerTypes CheckType;

	[Token(Token = "0x4008882")]
	[FieldOffset(Offset = "0x6C")]
	public bool specifiedTagOnly;

	[TagField]
	[Token(Token = "0x4008883")]
	[FieldOffset(Offset = "0x70")]
	public string objectTag;

	[BlackboardOnly]
	[Token(Token = "0x4008884")]
	[FieldOffset(Offset = "0x78")]
	public BBParameter<GameObject> saveGameObjectAs;

	[Token(Token = "0x4008885")]
	[FieldOffset(Offset = "0x80")]
	private bool stay;

	[Token(Token = "0x17000950")]
	protected override string info
	{
		[Token(Token = "0x600758F")]
		[Address(RVA = "0x110FFB0", Offset = "0x110EDB0", Length = "0xCD")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6007590")]
	[Address(RVA = "0x110FCF0", Offset = "0x110EAF0", Length = "0x11")]
	protected override bool OnCheck()
	{
		return false;
	}

	[Token(Token = "0x6007591")]
	[Address(RVA = "0x1110080", Offset = "0x110EE80", Length = "0xF4")]
	public void OnTriggerEnter2D(Collider2D other)
	{
	}

	[Token(Token = "0x6007592")]
	[Address(RVA = "0x1110180", Offset = "0x110EF80", Length = "0xF1")]
	public void OnTriggerExit2D(Collider2D other)
	{
	}

	[Token(Token = "0x6007593")]
	[Address(RVA = "0x1110280", Offset = "0x110F080", Length = "0x9E")]
	public CheckTrigger2D()
	{
	}
}
