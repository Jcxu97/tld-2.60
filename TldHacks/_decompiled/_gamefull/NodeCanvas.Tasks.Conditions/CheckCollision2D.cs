using Cpp2ILInjected;
using NodeCanvas.Framework;
using ParadoxNotion;
using ParadoxNotion.Design;
using UnityEngine;

namespace NodeCanvas.Tasks.Conditions;

[Category("System Events")]
[Name("Check Collision 2D", 0)]
[EventReceiver(new string[] { "OnCollisionEnter2D", "OnCollisionExit2D" })]
[Token(Token = "0x2001190")]
public class CheckCollision2D : ConditionTask<Collider2D>
{
	[Token(Token = "0x4008871")]
	[FieldOffset(Offset = "0x68")]
	public CollisionTypes checkType;

	[Token(Token = "0x4008872")]
	[FieldOffset(Offset = "0x6C")]
	public bool specifiedTagOnly;

	[TagField]
	[Token(Token = "0x4008873")]
	[FieldOffset(Offset = "0x70")]
	public string objectTag;

	[BlackboardOnly]
	[Token(Token = "0x4008874")]
	[FieldOffset(Offset = "0x78")]
	public BBParameter<GameObject> saveGameObjectAs;

	[BlackboardOnly]
	[Token(Token = "0x4008875")]
	[FieldOffset(Offset = "0x80")]
	public BBParameter<Vector3> saveContactPoint;

	[BlackboardOnly]
	[Token(Token = "0x4008876")]
	[FieldOffset(Offset = "0x88")]
	public BBParameter<Vector3> saveContactNormal;

	[Token(Token = "0x4008877")]
	[FieldOffset(Offset = "0x90")]
	private bool stay;

	[Token(Token = "0x1700094A")]
	protected override string info
	{
		[Token(Token = "0x600756F")]
		[Address(RVA = "0x110F490", Offset = "0x110E290", Length = "0xCD")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6007570")]
	[Address(RVA = "0x110F120", Offset = "0x110DF20", Length = "0x11")]
	protected override bool OnCheck()
	{
		return false;
	}

	[Token(Token = "0x6007571")]
	[Address(RVA = "0x110F560", Offset = "0x110E360", Length = "0x1F3")]
	public void OnCollisionEnter2D(Collision2D info)
	{
	}

	[Token(Token = "0x6007572")]
	[Address(RVA = "0x110F760", Offset = "0x110E560", Length = "0xF1")]
	public void OnCollisionExit2D(Collision2D info)
	{
	}

	[Token(Token = "0x6007573")]
	[Address(RVA = "0x110F860", Offset = "0x110E660", Length = "0x9E")]
	public CheckCollision2D()
	{
	}
}
