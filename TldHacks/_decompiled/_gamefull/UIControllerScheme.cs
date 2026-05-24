using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x2000A41")]
public class UIControllerScheme : MonoBehaviour
{
	[Token(Token = "0x2000A42")]
	public enum ControlScheme
	{
		[Token(Token = "0x40066B6")]
		Controller,
		[Token(Token = "0x40066B7")]
		Mouse
	}

	[Token(Token = "0x40066B4")]
	[FieldOffset(Offset = "0x20")]
	public ControlScheme m_ControlScheme;

	[Token(Token = "0x6005944")]
	[Address(RVA = "0xEF4C50", Offset = "0xEF3A50", Length = "0xAB")]
	private void Awake()
	{
	}

	[Token(Token = "0x6005945")]
	[Address(RVA = "0xEF4D00", Offset = "0xEF3B00", Length = "0x9F")]
	public void Start()
	{
	}

	[Token(Token = "0x6005946")]
	[Address(RVA = "0xEF4DA0", Offset = "0xEF3BA0", Length = "0x9F")]
	protected void OnEnable()
	{
	}

	[Token(Token = "0x6005947")]
	[Address(RVA = "0xEF4E40", Offset = "0xEF3C40", Length = "0x3F4")]
	private void SetActiveChildren(bool enabled)
	{
	}

	[Token(Token = "0x6005948")]
	[Address(RVA = "0xEF5240", Offset = "0xEF4040", Length = "0x9F")]
	public void LateUpdate()
	{
	}

	[Token(Token = "0x6005949")]
	[Address(RVA = "0x4AF5E0", Offset = "0x4AE3E0", Length = "0x43")]
	public UIControllerScheme()
	{
	}
}
