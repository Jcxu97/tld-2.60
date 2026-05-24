using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x2000A1A")]
public class NGUIEventHandler : MonoBehaviour
{
	[Token(Token = "0x4006627")]
	[FieldOffset(Offset = "0x20")]
	private GameObject LastSelectedByKeys;

	[Token(Token = "0x6005887")]
	[Address(RVA = "0xEEC4B0", Offset = "0xEEB2B0", Length = "0x3C5")]
	private void Start()
	{
	}

	[Token(Token = "0x6005888")]
	[Address(RVA = "0xEEC880", Offset = "0xEEB680", Length = "0x1B6")]
	private void OnSelectDelegate(GameObject go, bool selected)
	{
	}

	[Token(Token = "0x6005889")]
	[Address(RVA = "0xEECA40", Offset = "0xEEB840", Length = "0x2C9")]
	private void OnKeyDelegate(GameObject go, KeyCode keyCode)
	{
	}

	[Token(Token = "0x600588A")]
	[Address(RVA = "0x4AF5E0", Offset = "0x4AE3E0", Length = "0x43")]
	public NGUIEventHandler()
	{
	}
}
