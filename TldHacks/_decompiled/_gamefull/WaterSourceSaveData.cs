using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x20007F4")]
public class WaterSourceSaveData
{
	[Token(Token = "0x40054BB")]
	[FieldOffset(Offset = "0x10")]
	public Vector3 m_Position;

	[Token(Token = "0x40054BC")]
	[FieldOffset(Offset = "0x1C")]
	public Quaternion m_Rotation;

	[Token(Token = "0x40054BD")]
	[FieldOffset(Offset = "0x30")]
	public string m_PrefabName;

	[Token(Token = "0x40054BE")]
	[FieldOffset(Offset = "0x38")]
	public string m_SearializedWaterSource;

	[Token(Token = "0x40054BF")]
	[FieldOffset(Offset = "0x40")]
	public string m_Guid;

	[Token(Token = "0x40054C0")]
	[FieldOffset(Offset = "0x48")]
	public bool m_NotActive;

	[Token(Token = "0x6004AE2")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public WaterSourceSaveData()
	{
	}
}
