using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x2000242")]
public class GenericGearGridFilterButton : GenericGearGridButton
{
	[SerializeField]
	[Token(Token = "0x40013EE")]
	[FieldOffset(Offset = "0x30")]
	private InventoryFilterType m_FilterType;

	[Token(Token = "0x170001C4")]
	public InventoryFilterType FilterType
	{
		[Token(Token = "0x60013D8")]
		[Address(RVA = "0x677F80", Offset = "0x676D80", Length = "0x4")]
		get
		{
			return default(InventoryFilterType);
		}
	}

	[Token(Token = "0x60013D9")]
	[Address(RVA = "0x4AF5E0", Offset = "0x4AE3E0", Length = "0x43")]
	public GenericGearGridFilterButton()
	{
	}
}
