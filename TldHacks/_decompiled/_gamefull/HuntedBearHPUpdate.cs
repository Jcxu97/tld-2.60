using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x2000816")]
public class HuntedBearHPUpdate : MonoBehaviour
{
	[Token(Token = "0x4005555")]
	[FieldOffset(Offset = "0x20")]
	private BaseAi m_BaseAi;

	[Token(Token = "0x4005556")]
	[FieldOffset(Offset = "0x28")]
	private MissionManagerBase m_MissionManager;

	[Token(Token = "0x6004B58")]
	[Address(RVA = "0xD51D40", Offset = "0xD50B40", Length = "0x246")]
	private void Start()
	{
	}

	[Token(Token = "0x6004B59")]
	[Address(RVA = "0xD51F90", Offset = "0xD50D90", Length = "0x216")]
	private void Update()
	{
	}

	[Token(Token = "0x6004B5A")]
	[Address(RVA = "0x4AF5E0", Offset = "0x4AE3E0", Length = "0x43")]
	public HuntedBearHPUpdate()
	{
	}
}
