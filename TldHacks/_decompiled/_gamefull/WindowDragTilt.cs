using Cpp2ILInjected;
using UnityEngine;

[AddComponentMenu("NGUI/Examples/Window Drag Tilt")]
[Token(Token = "0x200005C")]
public class WindowDragTilt : MonoBehaviour
{
	[Token(Token = "0x4000382")]
	[FieldOffset(Offset = "0x20")]
	public int updateOrder;

	[Token(Token = "0x4000383")]
	[FieldOffset(Offset = "0x24")]
	public float degrees;

	[Token(Token = "0x4000384")]
	[FieldOffset(Offset = "0x28")]
	private Vector3 mLastPos;

	[Token(Token = "0x4000385")]
	[FieldOffset(Offset = "0x38")]
	private Transform mTrans;

	[Token(Token = "0x4000386")]
	[FieldOffset(Offset = "0x40")]
	private float mAngle;

	[Token(Token = "0x6000390")]
	[Address(RVA = "0xA21F20", Offset = "0xA20D20", Length = "0x11F")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000391")]
	[Address(RVA = "0xA22040", Offset = "0xA20E40", Length = "0x343")]
	private void Update()
	{
	}

	[Token(Token = "0x6000392")]
	[Address(RVA = "0xA22390", Offset = "0xA21190", Length = "0x4A")]
	public WindowDragTilt()
	{
	}
}
