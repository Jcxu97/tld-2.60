using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x2000205")]
public class BasicMenuItem : MonoBehaviour
{
	[Token(Token = "0x400125B")]
	[FieldOffset(Offset = "0x20")]
	public BasicMenu.BasicMenuItemView m_View;

	[Token(Token = "0x6001259")]
	[Address(RVA = "0x4AF5E0", Offset = "0x4AE3E0", Length = "0x43")]
	public BasicMenuItem()
	{
	}
}
