using Cpp2ILInjected;
using TLD.OptionalContent;
using UnityEngine;

[CreateAssetMenu(fileName = "MainMenuDataSet", menuName = "The Long Dark/Interface/Main Menu Data Set")]
[Token(Token = "0x20005F6")]
public class MainMenuDataSet : ScriptableObject
{
	[Token(Token = "0x40036FE")]
	[FieldOffset(Offset = "0x18")]
	public OptionalContentConfig m_ContentConfig;

	[Token(Token = "0x40036FF")]
	[FieldOffset(Offset = "0x20")]
	public string m_AlternateMainMenuAddress;

	[Token(Token = "0x6002E18")]
	[Address(RVA = "0x95E560", Offset = "0x95D360", Length = "0x12B")]
	public bool UseAlternateMainMenu()
	{
		return false;
	}

	[Token(Token = "0x6002E19")]
	[Address(RVA = "0x4A22A0", Offset = "0x4A10A0", Length = "0x7")]
	public MainMenuDataSet()
	{
	}
}
