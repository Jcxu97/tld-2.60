using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x2000563")]
public class ContainerMissionHoverText : MonoBehaviour
{
	[Token(Token = "0x40031D9")]
	[FieldOffset(Offset = "0x20")]
	public string m_ObjectiveID;

	[Token(Token = "0x6002973")]
	[Address(RVA = "0x8EBCB0", Offset = "0x8EAAB0", Length = "0x552")]
	public string GetHoverText()
	{
		return null;
	}

	[Token(Token = "0x6002974")]
	[Address(RVA = "0x4AF5E0", Offset = "0x4AE3E0", Length = "0x43")]
	public ContainerMissionHoverText()
	{
	}
}
