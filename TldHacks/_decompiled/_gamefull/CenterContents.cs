using Cpp2ILInjected;
using UnityEngine;

[RequireComponent(typeof(UIWidget))]
[Token(Token = "0x20009F5")]
public class CenterContents : MonoBehaviour
{
	[Token(Token = "0x4006543")]
	[FieldOffset(Offset = "0x20")]
	public Transform targetRoot;

	[Token(Token = "0x4006544")]
	[FieldOffset(Offset = "0x28")]
	public int padLeft;

	[Token(Token = "0x4006545")]
	[FieldOffset(Offset = "0x2C")]
	public int padRight;

	[Token(Token = "0x4006546")]
	[FieldOffset(Offset = "0x30")]
	public int padBottom;

	[Token(Token = "0x4006547")]
	[FieldOffset(Offset = "0x34")]
	public int padTop;

	[Token(Token = "0x4006548")]
	[FieldOffset(Offset = "0x38")]
	private bool mStarted;

	[Token(Token = "0x60057AB")]
	[Address(RVA = "0xED75F0", Offset = "0xED63F0", Length = "0xB")]
	private void Start()
	{
	}

	[Token(Token = "0x60057AC")]
	[Address(RVA = "0xED7600", Offset = "0xED6400", Length = "0xE")]
	private void OnEnable()
	{
	}

	[ContextMenu("Execute")]
	[Token(Token = "0x60057AD")]
	[Address(RVA = "0xED7610", Offset = "0xED6410", Length = "0x6D7")]
	public void LateUpdate()
	{
	}

	[Token(Token = "0x60057AE")]
	[Address(RVA = "0x4AF5E0", Offset = "0x4AE3E0", Length = "0x43")]
	public CenterContents()
	{
	}
}
