using Cpp2ILInjected;
using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;

namespace NodeCanvas.Tasks.Conditions;

[Category("TLD Conditions/Utils")]
[Description("Tests either: if object B is visible from the camera, or object B is visible from object A.")]
[Name("Visibility Test", 0)]
[Token(Token = "0x200114A")]
public class Condition_VisibilityTest : ConditionTask
{
	[Token(Token = "0x40087B8")]
	[FieldOffset(Offset = "0x68")]
	public bool testFromCamera;

	[Token(Token = "0x40087B9")]
	[FieldOffset(Offset = "0x70")]
	public BBParameter<string> objectA;

	[Token(Token = "0x40087BA")]
	[FieldOffset(Offset = "0x78")]
	public BBParameter<string> objectB;

	[Token(Token = "0x40087BB")]
	[FieldOffset(Offset = "0x80")]
	public Vector3 objectAOffset;

	[Token(Token = "0x40087BC")]
	[FieldOffset(Offset = "0x8C")]
	public Vector3 objectBOffset;

	[Token(Token = "0x40087BD")]
	[FieldOffset(Offset = "0x98")]
	public float objectBRadius;

	[Token(Token = "0x40087BE")]
	[FieldOffset(Offset = "0x9C")]
	public bool justXZ;

	[Token(Token = "0x40087BF")]
	[FieldOffset(Offset = "0xA0")]
	public float coneAngle;

	[Token(Token = "0x40087C0")]
	[FieldOffset(Offset = "0xA4")]
	public float alwaysVisibleRadius;

	[Token(Token = "0x40087C1")]
	[FieldOffset(Offset = "0xA8")]
	public float maxDistance;

	[Token(Token = "0x40087C2")]
	[FieldOffset(Offset = "0xAC")]
	public float sphereCastRadius;

	[Token(Token = "0x40087C3")]
	[FieldOffset(Offset = "0xB0")]
	public LayerMask sphereCastLayers;

	[Token(Token = "0x40087C4")]
	[FieldOffset(Offset = "0xB4")]
	public bool debugOutput;

	[Token(Token = "0x17000902")]
	protected override string info
	{
		[Token(Token = "0x600746A")]
		[Address(RVA = "0x10FD7A0", Offset = "0x10FC5A0", Length = "0xDD")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600746B")]
	[Address(RVA = "0x10FD880", Offset = "0x10FC680", Length = "0xAA6")]
	protected override bool OnCheck()
	{
		return false;
	}

	[Token(Token = "0x600746C")]
	[Address(RVA = "0x10FE330", Offset = "0x10FD130", Length = "0x291")]
	public Condition_VisibilityTest()
	{
	}
}
