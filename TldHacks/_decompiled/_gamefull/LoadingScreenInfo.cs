using Cpp2ILInjected;
using TLD.Scenes;

[Token(Token = "0x2000677")]
public class LoadingScreenInfo
{
	[Token(Token = "0x40041C7")]
	[FieldOffset(Offset = "0x10")]
	public string m_MainScene;

	[Token(Token = "0x40041C8")]
	[FieldOffset(Offset = "0x18")]
	public SceneSet m_SceneSet;

	[Token(Token = "0x40041C9")]
	[FieldOffset(Offset = "0x20")]
	public string m_Region;

	[Token(Token = "0x40041CA")]
	[FieldOffset(Offset = "0x28")]
	public string m_Mission;

	[Token(Token = "0x600364D")]
	[Address(RVA = "0xAD9020", Offset = "0xAD7E20", Length = "0x1D4")]
	public string GetLocalizedSceneName()
	{
		return null;
	}

	[Token(Token = "0x600364E")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public LoadingScreenInfo()
	{
	}
}
