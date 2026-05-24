using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x2000244")]
public class GenericGearGridSortButton : GenericGearGridButton
{
	[SerializeField]
	[Token(Token = "0x400140B")]
	[FieldOffset(Offset = "0x30")]
	private Panel_GenericGearGrid.Sorting m_SortType;

	[Token(Token = "0x170001CA")]
	public Panel_GenericGearGrid.Sorting SortType
	{
		[Token(Token = "0x60013F4")]
		[Address(RVA = "0x677F80", Offset = "0x676D80", Length = "0x4")]
		get
		{
			return default(Panel_GenericGearGrid.Sorting);
		}
	}

	[Token(Token = "0x60013F5")]
	[Address(RVA = "0x4AF5E0", Offset = "0x4AE3E0", Length = "0x43")]
	public GenericGearGridSortButton()
	{
	}
}
