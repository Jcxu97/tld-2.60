using Cpp2ILInjected;
using UnityEngine;

[ExecuteInEditMode]
[RequireComponent(typeof(UIWidget))]
[AddComponentMenu("NGUI/UI/Localize")]
[Token(Token = "0x2000118")]
public class UILocalize : MonoBehaviour
{
	[Token(Token = "0x40008AF")]
	[FieldOffset(Offset = "0x20")]
	public string key;

	[Token(Token = "0x40008B0")]
	[FieldOffset(Offset = "0x28")]
	private bool mStarted;

	[Token(Token = "0x17000164")]
	public string value
	{
		[Token(Token = "0x6000A2C")]
		[Address(RVA = "0x1288BF0", Offset = "0x12879F0", Length = "0x7A9")]
		set
		{
		}
	}

	[Token(Token = "0x6000A2D")]
	[Address(RVA = "0x12893A0", Offset = "0x12881A0", Length = "0xE")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000A2E")]
	[Address(RVA = "0x12893B0", Offset = "0x12881B0", Length = "0xB")]
	private void Start()
	{
	}

	[Token(Token = "0x6000A2F")]
	[Address(RVA = "0x12893C0", Offset = "0x12881C0", Length = "0x1D2")]
	private void OnLocalize()
	{
	}

	[Token(Token = "0x6000A30")]
	[Address(RVA = "0x4AF5E0", Offset = "0x4AE3E0", Length = "0x43")]
	public UILocalize()
	{
	}
}
