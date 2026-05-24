using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x2000457")]
public class BlueprintItemUnlock : MonoBehaviour
{
	[Token(Token = "0x400277F")]
	[FieldOffset(Offset = "0x20")]
	public bool m_UnlockInStoryMode;

	[Token(Token = "0x4002780")]
	[FieldOffset(Offset = "0x21")]
	public bool m_UnlockInSurvival;

	[Token(Token = "0x60020D2")]
	[Address(RVA = "0x806DD0", Offset = "0x805BD0", Length = "0xA")]
	public void Unlock()
	{
	}

	[Token(Token = "0x60020D3")]
	[Address(RVA = "0x806DE0", Offset = "0x805BE0", Length = "0xA")]
	public void UnlockSilent()
	{
	}

	[Token(Token = "0x60020D4")]
	[Address(RVA = "0x806DF0", Offset = "0x805BF0", Length = "0x257")]
	private void Unlock(bool silent)
	{
	}

	[Token(Token = "0x60020D5")]
	[Address(RVA = "0x807050", Offset = "0x805E50", Length = "0x49")]
	public bool ShouldUnlock()
	{
		return false;
	}

	[Token(Token = "0x60020D6")]
	[Address(RVA = "0x4AF5E0", Offset = "0x4AE3E0", Length = "0x43")]
	public BlueprintItemUnlock()
	{
	}
}
