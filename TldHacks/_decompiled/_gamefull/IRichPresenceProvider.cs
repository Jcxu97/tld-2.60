using Cpp2ILInjected;

[Token(Token = "0x2000907")]
public interface IRichPresenceProvider
{
	[Token(Token = "0x600526D")]
	void Initialize();

	[Token(Token = "0x600526E")]
	void Shutdown();

	[Token(Token = "0x600526F")]
	void Update();

	[Token(Token = "0x6005270")]
	void SetLocalizationKeys(RichPresenceLocInfo[] locKeys);

	[Token(Token = "0x6005271")]
	void SetPresence(PresenceType presenceType);
}
