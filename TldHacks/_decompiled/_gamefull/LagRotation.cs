using Cpp2ILInjected;
using UnityEngine;

[AddComponentMenu("NGUI/Examples/Lag Rotation")]
[Token(Token = "0x2000050")]
public class LagRotation : MonoBehaviour
{
	[Token(Token = "0x400035F")]
	[FieldOffset(Offset = "0x20")]
	public float speed;

	[Token(Token = "0x4000360")]
	[FieldOffset(Offset = "0x24")]
	public bool ignoreTimeScale;

	[Token(Token = "0x4000361")]
	[FieldOffset(Offset = "0x28")]
	private Transform mTrans;

	[Token(Token = "0x4000362")]
	[FieldOffset(Offset = "0x30")]
	private Quaternion mRelative;

	[Token(Token = "0x4000363")]
	[FieldOffset(Offset = "0x40")]
	private Quaternion mAbsolute;

	[Token(Token = "0x600036B")]
	[Address(RVA = "0xA1DE30", Offset = "0xA1CC30", Length = "0x10")]
	public void OnRepositionEnd()
	{
	}

	[Token(Token = "0x600036C")]
	[Address(RVA = "0xA1DE40", Offset = "0xA1CC40", Length = "0x385")]
	private void Interpolate(float delta)
	{
	}

	[Token(Token = "0x600036D")]
	[Address(RVA = "0xA1E1D0", Offset = "0xA1CFD0", Length = "0x1BC")]
	private void Start()
	{
	}

	[Token(Token = "0x600036E")]
	[Address(RVA = "0xA1E390", Offset = "0xA1D190", Length = "0x9B")]
	private void Update()
	{
	}

	[Token(Token = "0x600036F")]
	[Address(RVA = "0xA1E430", Offset = "0xA1D230", Length = "0x4A")]
	public LagRotation()
	{
	}
}
