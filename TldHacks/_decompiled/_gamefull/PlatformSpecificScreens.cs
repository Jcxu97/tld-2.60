using Cpp2ILInjected;
using UnityEngine;

[CreateAssetMenu(fileName = "PlatformSpecificScreens", menuName = "Interface/Platform Specific Screens", order = 10003)]
[Token(Token = "0x20006DF")]
public class PlatformSpecificScreens : ScriptableObject
{
	[Tooltip("The platform name is used to suffix onto panel names. \ne.g. 'Switch' would result in 'Panel_MainMenu_Switch'.")]
	[Token(Token = "0x4004958")]
	[FieldOffset(Offset = "0x18")]
	public string m_PlatformName;

	[Tooltip("List screen names (without the suffix specified) to be replaced by platform-specific variants.")]
	[SerializeField]
	[Token(Token = "0x4004959")]
	[FieldOffset(Offset = "0x20")]
	private string[] m_Screens;

	[Token(Token = "0x6003C9A")]
	[Address(RVA = "0xB82050", Offset = "0xB80E50", Length = "0x95")]
	public bool Contains(string screenName)
	{
		return false;
	}

	[Token(Token = "0x6003C9B")]
	[Address(RVA = "0x4A22A0", Offset = "0x4A10A0", Length = "0x7")]
	public PlatformSpecificScreens()
	{
	}
}
