using Cpp2ILInjected;
using UnityEngine;

[RequireComponent(typeof(UIInput))]
[AddComponentMenu("NGUI/Examples/Chat Input")]
[Token(Token = "0x200004B")]
public class ChatInput : MonoBehaviour
{
	[Token(Token = "0x400034E")]
	[FieldOffset(Offset = "0x20")]
	public UITextList textList;

	[Token(Token = "0x400034F")]
	[FieldOffset(Offset = "0x28")]
	public bool fillWithDummyData;

	[Token(Token = "0x4000350")]
	[FieldOffset(Offset = "0x30")]
	private UIInput mInput;

	[Token(Token = "0x6000359")]
	[Address(RVA = "0xA1C8E0", Offset = "0xA1B6E0", Length = "0x278")]
	private void Start()
	{
	}

	[Token(Token = "0x600035A")]
	[Address(RVA = "0xA1CB60", Offset = "0xA1B960", Length = "0x1D8")]
	public void OnSubmit()
	{
	}

	[Token(Token = "0x600035B")]
	[Address(RVA = "0x4AF5E0", Offset = "0x4AE3E0", Length = "0x43")]
	public ChatInput()
	{
	}
}
