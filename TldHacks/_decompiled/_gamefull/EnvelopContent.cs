using Cpp2ILInjected;
using UnityEngine;

[RequireComponent(typeof(UIWidget))]
[AddComponentMenu("NGUI/Examples/Envelop Content")]
[Token(Token = "0x200004C")]
public class EnvelopContent : MonoBehaviour
{
	[Token(Token = "0x4000351")]
	[FieldOffset(Offset = "0x20")]
	public Transform targetRoot;

	[Token(Token = "0x4000352")]
	[FieldOffset(Offset = "0x28")]
	public int padLeft;

	[Token(Token = "0x4000353")]
	[FieldOffset(Offset = "0x2C")]
	public int padRight;

	[Token(Token = "0x4000354")]
	[FieldOffset(Offset = "0x30")]
	public int padBottom;

	[Token(Token = "0x4000355")]
	[FieldOffset(Offset = "0x34")]
	public int padTop;

	[Token(Token = "0x4000356")]
	[FieldOffset(Offset = "0x38")]
	private bool mStarted;

	[Token(Token = "0x600035C")]
	[Address(RVA = "0xA1CD40", Offset = "0xA1BB40", Length = "0xB")]
	private void Start()
	{
	}

	[Token(Token = "0x600035D")]
	[Address(RVA = "0xA1CD50", Offset = "0xA1BB50", Length = "0xE")]
	private void OnEnable()
	{
	}

	[ContextMenu("Execute")]
	[Token(Token = "0x600035E")]
	[Address(RVA = "0xA1CD60", Offset = "0xA1BB60", Length = "0x36A")]
	public void Execute()
	{
	}

	[Token(Token = "0x600035F")]
	[Address(RVA = "0x4AF5E0", Offset = "0x4AE3E0", Length = "0x43")]
	public EnvelopContent()
	{
	}
}
