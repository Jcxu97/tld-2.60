using Cpp2ILInjected;
using UnityEngine;

[AddComponentMenu("NGUI/Examples/Pan With Mouse")]
[Token(Token = "0x2000054")]
public class PanWithMouse : MonoBehaviour
{
	[Token(Token = "0x4000369")]
	[FieldOffset(Offset = "0x20")]
	public Vector2 degrees;

	[Token(Token = "0x400036A")]
	[FieldOffset(Offset = "0x28")]
	public float range;

	[Token(Token = "0x400036B")]
	[FieldOffset(Offset = "0x30")]
	private Transform mTrans;

	[Token(Token = "0x400036C")]
	[FieldOffset(Offset = "0x38")]
	private Quaternion mStart;

	[Token(Token = "0x400036D")]
	[FieldOffset(Offset = "0x48")]
	private Vector2 mRot;

	[Token(Token = "0x6000377")]
	[Address(RVA = "0xA1EC10", Offset = "0xA1DA10", Length = "0x10F")]
	private void Start()
	{
	}

	[Token(Token = "0x6000378")]
	[Address(RVA = "0xA1ED20", Offset = "0xA1DB20", Length = "0x4BD")]
	private void Update()
	{
	}

	[Token(Token = "0x6000379")]
	[Address(RVA = "0xA1F1E0", Offset = "0xA1DFE0", Length = "0xA1")]
	public PanWithMouse()
	{
	}
}
