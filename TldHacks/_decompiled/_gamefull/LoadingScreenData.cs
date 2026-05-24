using Cpp2ILInjected;
using UnityEngine;

[CreateAssetMenu(menuName = "Interface/Loading Screen Data")]
[Token(Token = "0x20005F4")]
public class LoadingScreenData : ScriptableObject
{
	[Token(Token = "0x40036ED")]
	[FieldOffset(Offset = "0x18")]
	public string[] m_LoadingBackgrounds;

	[Token(Token = "0x40036EE")]
	[FieldOffset(Offset = "0x20")]
	public LocalizedString[] m_LoadingText;

	[Token(Token = "0x40036EF")]
	[FieldOffset(Offset = "0x28")]
	public float m_MinHoldTime;

	[Token(Token = "0x40036F0")]
	[FieldOffset(Offset = "0x2C")]
	private int m_LastLoadingBackground;

	[Token(Token = "0x40036F1")]
	[FieldOffset(Offset = "0x30")]
	private int m_LastLoadingText;

	[Token(Token = "0x6002E04")]
	[Address(RVA = "0x95D1A0", Offset = "0x95BFA0", Length = "0x68")]
	public string GetRandomLoadingBackground()
	{
		return null;
	}

	[Token(Token = "0x6002E05")]
	[Address(RVA = "0x95D210", Offset = "0x95C010", Length = "0x71")]
	public string GetRandomLoadingTextLocID()
	{
		return null;
	}

	[Token(Token = "0x6002E06")]
	[Address(RVA = "0x95D290", Offset = "0x95C090", Length = "0x79")]
	private int GetRandomNoRepeat(int length, int lastIndex)
	{
		return 0;
	}

	[Token(Token = "0x6002E07")]
	[Address(RVA = "0x95D310", Offset = "0x95C110", Length = "0xF")]
	public LoadingScreenData()
	{
	}
}
