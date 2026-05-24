using Cpp2ILInjected;
using UnityEngine;

[AddComponentMenu("NGUI/Examples/Spin With Mouse")]
[Token(Token = "0x2000058")]
public class SpinWithMouse : MonoBehaviour
{
	[Token(Token = "0x4000378")]
	[FieldOffset(Offset = "0x20")]
	public Transform target;

	[Token(Token = "0x4000379")]
	[FieldOffset(Offset = "0x28")]
	public float speed;

	[Token(Token = "0x400037A")]
	[FieldOffset(Offset = "0x30")]
	private Transform mTrans;

	[Token(Token = "0x6000384")]
	[Address(RVA = "0xA1DB20", Offset = "0xA1C920", Length = "0x57")]
	private void Start()
	{
	}

	[Token(Token = "0x6000385")]
	[Address(RVA = "0xA20CB0", Offset = "0xA1FAB0", Length = "0x50B")]
	private void OnDrag(Vector2 delta)
	{
	}

	[Token(Token = "0x6000386")]
	[Address(RVA = "0x880940", Offset = "0x87F740", Length = "0x4A")]
	public SpinWithMouse()
	{
	}
}
