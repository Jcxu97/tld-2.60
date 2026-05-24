using Cpp2ILInjected;
using UnityEngine;

[AddComponentMenu("NGUI/Examples/Window Auto-Yaw")]
[Token(Token = "0x200005B")]
public class WindowAutoYaw : MonoBehaviour
{
	[Token(Token = "0x400037E")]
	[FieldOffset(Offset = "0x20")]
	public int updateOrder;

	[Token(Token = "0x400037F")]
	[FieldOffset(Offset = "0x28")]
	public Camera uiCamera;

	[Token(Token = "0x4000380")]
	[FieldOffset(Offset = "0x30")]
	public float yawAmount;

	[Token(Token = "0x4000381")]
	[FieldOffset(Offset = "0x38")]
	private Transform mTrans;

	[Token(Token = "0x600038C")]
	[Address(RVA = "0xA21860", Offset = "0xA20660", Length = "0xD5")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x600038D")]
	[Address(RVA = "0xA21940", Offset = "0xA20740", Length = "0x1F3")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x600038E")]
	[Address(RVA = "0xA21B40", Offset = "0xA20940", Length = "0x38B")]
	private void Update()
	{
	}

	[Token(Token = "0x600038F")]
	[Address(RVA = "0xA21ED0", Offset = "0xA20CD0", Length = "0x4A")]
	public WindowAutoYaw()
	{
	}
}
