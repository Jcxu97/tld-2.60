using Cpp2ILInjected;

[Token(Token = "0x200099D")]
public interface TLD_ITrack : TLD_IDynamicBindableTrack
{
	[Token(Token = "0x60055CB")]
	void Play();

	[Token(Token = "0x60055CC")]
	void Stop();

	[Token(Token = "0x60055CD")]
	void UpdatePlay();

	[Token(Token = "0x60055CE")]
	void LateUpdatePlay();
}
