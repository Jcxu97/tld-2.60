using System;
using Cpp2ILInjected;
using UnityEngine;

[RequireComponent(typeof(UIInput))]
[Token(Token = "0x2000113")]
public class UIInputOnGUI : MonoBehaviour
{
	[NonSerialized]
	[Token(Token = "0x400086E")]
	[FieldOffset(Offset = "0x20")]
	private UIInput mInput;

	[Token(Token = "0x60009AE")]
	[Address(RVA = "0x127F8F0", Offset = "0x127E6F0", Length = "0x8C")]
	private void Awake()
	{
	}

	[Token(Token = "0x60009AF")]
	[Address(RVA = "0x127F980", Offset = "0x127E780", Length = "0x104")]
	private void OnGUI()
	{
	}

	[Token(Token = "0x60009B0")]
	[Address(RVA = "0x4AF5E0", Offset = "0x4AE3E0", Length = "0x43")]
	public UIInputOnGUI()
	{
	}
}
