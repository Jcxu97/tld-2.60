using Cpp2ILInjected;
using NodeCanvas.Framework;
using ParadoxNotion;
using ParadoxNotion.Design;
using UnityEngine;

namespace NodeCanvas.Tasks.Conditions;

[Category("System Events")]
[EventReceiver(new string[] { "OnCollisionEnter", "OnCollisionExit" })]
[Token(Token = "0x200118F")]
public class CheckCollision : ConditionTask<Collider>
{
	[Token(Token = "0x400886A")]
	[FieldOffset(Offset = "0x68")]
	public CollisionTypes checkType;

	[Token(Token = "0x400886B")]
	[FieldOffset(Offset = "0x6C")]
	public bool specifiedTagOnly;

	[TagField]
	[Token(Token = "0x400886C")]
	[FieldOffset(Offset = "0x70")]
	public string objectTag;

	[BlackboardOnly]
	[Token(Token = "0x400886D")]
	[FieldOffset(Offset = "0x78")]
	public BBParameter<GameObject> saveGameObjectAs;

	[BlackboardOnly]
	[Token(Token = "0x400886E")]
	[FieldOffset(Offset = "0x80")]
	public BBParameter<Vector3> saveContactPoint;

	[BlackboardOnly]
	[Token(Token = "0x400886F")]
	[FieldOffset(Offset = "0x88")]
	public BBParameter<Vector3> saveContactNormal;

	[Token(Token = "0x4008870")]
	[FieldOffset(Offset = "0x90")]
	private bool stay;

	[Token(Token = "0x17000949")]
	protected override string info
	{
		[Token(Token = "0x600756A")]
		[Address(RVA = "0x110F050", Offset = "0x110DE50", Length = "0xCD")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600756B")]
	[Address(RVA = "0x110F120", Offset = "0x110DF20", Length = "0x11")]
	protected override bool OnCheck()
	{
		return false;
	}

	[Token(Token = "0x600756C")]
	[Address(RVA = "0x110F140", Offset = "0x110DF40", Length = "0x1AF")]
	public void OnCollisionEnter(Collision info)
	{
	}

	[Token(Token = "0x600756D")]
	[Address(RVA = "0x110F2F0", Offset = "0x110E0F0", Length = "0xF1")]
	public void OnCollisionExit(Collision info)
	{
	}

	[Token(Token = "0x600756E")]
	[Address(RVA = "0x110F3F0", Offset = "0x110E1F0", Length = "0x9E")]
	public CheckCollision()
	{
	}
}
