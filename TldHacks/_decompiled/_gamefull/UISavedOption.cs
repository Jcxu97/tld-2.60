using Cpp2ILInjected;
using UnityEngine;

[AddComponentMenu("NGUI/Interaction/Saved Option")]
[Token(Token = "0x2000092")]
public class UISavedOption : MonoBehaviour
{
	[Token(Token = "0x4000513")]
	[FieldOffset(Offset = "0x20")]
	public string keyName;

	[Token(Token = "0x4000514")]
	[FieldOffset(Offset = "0x28")]
	private UIPopupList mList;

	[Token(Token = "0x4000515")]
	[FieldOffset(Offset = "0x30")]
	private UIToggle mCheck;

	[Token(Token = "0x4000516")]
	[FieldOffset(Offset = "0x38")]
	private UIProgressBar mSlider;

	[Token(Token = "0x17000058")]
	private string key
	{
		[Token(Token = "0x6000508")]
		[Address(RVA = "0xBE79A0", Offset = "0xBE67A0", Length = "0x60")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6000509")]
	[Address(RVA = "0xBE7A00", Offset = "0xBE6800", Length = "0x189")]
	private void Awake()
	{
	}

	[Token(Token = "0x600050A")]
	[Address(RVA = "0xBE7B90", Offset = "0xBE6990", Length = "0x610")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x600050B")]
	[Address(RVA = "0xBE81B0", Offset = "0xBE6FB0", Length = "0x3E0")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x600050C")]
	[Address(RVA = "0xBE85A0", Offset = "0xBE73A0", Length = "0xA8")]
	public void SaveSelection()
	{
	}

	[Token(Token = "0x600050D")]
	[Address(RVA = "0xBE8650", Offset = "0xBE7450", Length = "0xE0")]
	public void SaveState()
	{
	}

	[Token(Token = "0x600050E")]
	[Address(RVA = "0xBE8740", Offset = "0xBE7540", Length = "0xDF")]
	public void SaveProgress()
	{
	}

	[Token(Token = "0x600050F")]
	[Address(RVA = "0x4AF5E0", Offset = "0x4AE3E0", Length = "0x43")]
	public UISavedOption()
	{
	}
}
