using System.Collections.Generic;
using Cpp2ILInjected;

[Token(Token = "0x2000582")]
public class GearItemInteractabilityControlSaveData
{
	[Token(Token = "0x40032BF")]
	[FieldOffset(Offset = "0x10")]
	public string m_Guid;

	[Token(Token = "0x40032C0")]
	[FieldOffset(Offset = "0x18")]
	public GearSaveList m_GearSaveList;

	[Token(Token = "0x40032C1")]
	[FieldOffset(Offset = "0x20")]
	public List<string> m_CollectedItems;

	[Token(Token = "0x40032C2")]
	[FieldOffset(Offset = "0x28")]
	public List<GearItemInteractabilityControlSpawnTransformSaveData> m_SpawnTransforms;

	[Token(Token = "0x6002A77")]
	[Address(RVA = "0x9024E0", Offset = "0x9012E0", Length = "0x1D9")]
	public GearItemInteractabilityControlSaveData()
	{
	}
}
