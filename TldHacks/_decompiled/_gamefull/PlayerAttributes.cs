using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x20008AC")]
public class PlayerAttributes : MonoBehaviour
{
	[Token(Token = "0x4005A2A")]
	[FieldOffset(Offset = "0x20")]
	public PlayerAttributesSaveData m_SaveData;

	[Token(Token = "0x6004FD8")]
	[Address(RVA = "0xDD3650", Offset = "0xDD2450", Length = "0x1D")]
	public void Start()
	{
	}

	[Token(Token = "0x6004FD9")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public void Update()
	{
	}

	[Token(Token = "0x6004FDA")]
	[Address(RVA = "0x4AF5E0", Offset = "0x4AE3E0", Length = "0x43")]
	public PlayerAttributes()
	{
	}
}
