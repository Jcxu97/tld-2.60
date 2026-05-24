using Cpp2ILInjected;
using UnityEngine;

[ExecuteInEditMode]
[RequireComponent(typeof(Camera))]
[AddComponentMenu("NGUI/UI/Orthographic Camera")]
[Token(Token = "0x2000119")]
public class UIOrthoCamera : MonoBehaviour
{
	[Token(Token = "0x40008B1")]
	[FieldOffset(Offset = "0x20")]
	private Camera mCam;

	[Token(Token = "0x40008B2")]
	[FieldOffset(Offset = "0x28")]
	private Transform mTrans;

	[Token(Token = "0x6000A31")]
	[Address(RVA = "0x12895A0", Offset = "0x12883A0", Length = "0x135")]
	private void Start()
	{
	}

	[Token(Token = "0x6000A32")]
	[Address(RVA = "0x12896E0", Offset = "0x12884E0", Length = "0x3DD")]
	private void Update()
	{
	}

	[Token(Token = "0x6000A33")]
	[Address(RVA = "0x4AF5E0", Offset = "0x4AE3E0", Length = "0x43")]
	public UIOrthoCamera()
	{
	}
}
