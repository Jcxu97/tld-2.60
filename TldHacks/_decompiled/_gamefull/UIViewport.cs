using Cpp2ILInjected;
using UnityEngine;

[ExecuteInEditMode]
[RequireComponent(typeof(Camera))]
[AddComponentMenu("NGUI/UI/Viewport Camera")]
[Token(Token = "0x200012D")]
public class UIViewport : MonoBehaviour
{
	[Token(Token = "0x4000957")]
	[FieldOffset(Offset = "0x20")]
	public Camera sourceCamera;

	[Token(Token = "0x4000958")]
	[FieldOffset(Offset = "0x28")]
	public Transform topLeft;

	[Token(Token = "0x4000959")]
	[FieldOffset(Offset = "0x30")]
	public Transform bottomRight;

	[Token(Token = "0x400095A")]
	[FieldOffset(Offset = "0x38")]
	public float fullSize;

	[Token(Token = "0x400095B")]
	[FieldOffset(Offset = "0x40")]
	private Camera mCam;

	[Token(Token = "0x6000B05")]
	[Address(RVA = "0x5CE8B0", Offset = "0x5CD6B0", Length = "0x199")]
	private void Start()
	{
	}

	[Token(Token = "0x6000B06")]
	[Address(RVA = "0x5CEA50", Offset = "0x5CD850", Length = "0x78A")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x6000B07")]
	[Address(RVA = "0x5CF1E0", Offset = "0x5CDFE0", Length = "0x4A")]
	public UIViewport()
	{
	}
}
