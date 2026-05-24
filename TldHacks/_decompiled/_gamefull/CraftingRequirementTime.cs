using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x2000229")]
public class CraftingRequirementTime : MonoBehaviour
{
	[Token(Token = "0x400134D")]
	[FieldOffset(Offset = "0x20")]
	public UILabel m_Display;

	[Token(Token = "0x6001349")]
	[Address(RVA = "0x667AA0", Offset = "0x6668A0", Length = "0x97")]
	public void Disable()
	{
	}

	[Token(Token = "0x600134A")]
	[Address(RVA = "0x667B40", Offset = "0x666940", Length = "0x100")]
	public void Enable(int craftingTimeMinutes)
	{
	}

	[Token(Token = "0x600134B")]
	[Address(RVA = "0x4AF5E0", Offset = "0x4AE3E0", Length = "0x43")]
	public CraftingRequirementTime()
	{
	}
}
