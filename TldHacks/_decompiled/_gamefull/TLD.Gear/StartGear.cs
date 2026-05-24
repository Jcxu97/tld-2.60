using Cpp2ILInjected;
using UnityEngine;

namespace TLD.Gear;

[Token(Token = "0x2001445")]
public class StartGear : MonoBehaviour
{
	[Token(Token = "0x4009397")]
	[FieldOffset(Offset = "0x20")]
	public StartGearData m_DefaultStartGear;

	[Token(Token = "0x6008133")]
	[Address(RVA = "0x1218AB0", Offset = "0x12178B0", Length = "0x36F")]
	public void AddAllToInventory()
	{
	}

	[Token(Token = "0x6008134")]
	[Address(RVA = "0x4AF5E0", Offset = "0x4AE3E0", Length = "0x43")]
	public StartGear()
	{
	}
}
