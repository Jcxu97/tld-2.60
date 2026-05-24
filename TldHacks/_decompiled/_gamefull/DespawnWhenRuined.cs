using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x200047C")]
public class DespawnWhenRuined : MonoBehaviour
{
	[Token(Token = "0x40028AE")]
	[FieldOffset(Offset = "0x20")]
	public bool m_AllowDespawnOnCamera;

	[Token(Token = "0x40028AF")]
	[FieldOffset(Offset = "0x21")]
	public bool m_AllowDespawnInInventory;

	[Token(Token = "0x40028B0")]
	[FieldOffset(Offset = "0x24")]
	public float m_MinDistanceToDespawnWhenDestroyed;

	[Token(Token = "0x40028B1")]
	[FieldOffset(Offset = "0x28")]
	private GearItem m_GearItem;

	[Token(Token = "0x60021E3")]
	[Address(RVA = "0x823170", Offset = "0x821F70", Length = "0x9C")]
	public void Start()
	{
	}

	[Token(Token = "0x60021E4")]
	[Address(RVA = "0x823210", Offset = "0x822010", Length = "0xA")]
	public void Update()
	{
	}

	[Token(Token = "0x60021E5")]
	[Address(RVA = "0x823220", Offset = "0x822020", Length = "0x3CB")]
	private void MaybeDespawnWhenRuined(bool ignorePosition)
	{
	}

	[Token(Token = "0x60021E6")]
	[Address(RVA = "0x4AF5E0", Offset = "0x4AE3E0", Length = "0x43")]
	public DespawnWhenRuined()
	{
	}
}
