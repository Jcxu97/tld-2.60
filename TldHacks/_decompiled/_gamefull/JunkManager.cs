using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x200077E")]
public class JunkManager : MonoBehaviour
{
	[Token(Token = "0x4005069")]
	[FieldOffset(Offset = "0x20")]
	private bool m_ClearedJunk;

	[Token(Token = "0x600464C")]
	[Address(RVA = "0xCA0F60", Offset = "0xC9FD60", Length = "0xC4")]
	public bool CanClearJunk()
	{
		return false;
	}

	[Token(Token = "0x600464D")]
	[Address(RVA = "0xCA1030", Offset = "0xC9FE30", Length = "0x1F")]
	public bool MaybeClearJunk()
	{
		return false;
	}

	[Token(Token = "0x600464E")]
	[Address(RVA = "0xCA1050", Offset = "0xC9FE50", Length = "0xC")]
	public void Deserialize(JunkManagerSaveData data)
	{
	}

	[Token(Token = "0x600464F")]
	[Address(RVA = "0x4D3E60", Offset = "0x4D2C60", Length = "0x5")]
	public JunkManagerSaveData Serialize()
	{
		return default(JunkManagerSaveData);
	}

	[Token(Token = "0x6004650")]
	[Address(RVA = "0xCA1060", Offset = "0xC9FE60", Length = "0x201")]
	private void ClearJunk()
	{
	}

	[Token(Token = "0x6004651")]
	[Address(RVA = "0x4AF5E0", Offset = "0x4AE3E0", Length = "0x43")]
	public JunkManager()
	{
	}
}
