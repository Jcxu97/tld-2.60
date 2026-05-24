using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x20006E9")]
public class TableItem : MonoBehaviour
{
	[Token(Token = "0x40049B2")]
	[FieldOffset(Offset = "0x20")]
	public bool m_JustClicked;

	[Token(Token = "0x6003CCD")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public void Start()
	{
	}

	[Token(Token = "0x6003CCE")]
	[Address(RVA = "0x92F5C0", Offset = "0x92E3C0", Length = "0x5")]
	public void OnItemClick()
	{
	}

	[Token(Token = "0x6003CCF")]
	[Address(RVA = "0x4AF5E0", Offset = "0x4AE3E0", Length = "0x43")]
	public TableItem()
	{
	}
}
