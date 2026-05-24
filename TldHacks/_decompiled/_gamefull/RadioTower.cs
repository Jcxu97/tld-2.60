using Cpp2ILInjected;
using TLD.Interactions;

[Token(Token = "0x20005A5")]
public class RadioTower : TimedHoldInteraction
{
	[Token(Token = "0x4003428")]
	[FieldOffset(Offset = "0x68")]
	public LocalizedString m_LocalizedDisplayName;

	[Token(Token = "0x4003429")]
	[FieldOffset(Offset = "0x70")]
	public LocalizedString m_ProgressDisplayName;

	[Token(Token = "0x400342A")]
	[FieldOffset(Offset = "0x78")]
	public string m_InteractAudio;

	[Token(Token = "0x400342B")]
	[FieldOffset(Offset = "0x80")]
	private bool m_IsBeingInteractedWith;

	[Token(Token = "0x400342C")]
	[FieldOffset(Offset = "0x84")]
	private float m_InteractTimer;

	[Token(Token = "0x400342D")]
	[FieldOffset(Offset = "0x88")]
	private PlayerControlMode m_RestoreControlMode;

	[Token(Token = "0x400342E")]
	[FieldOffset(Offset = "0x8C")]
	private uint m_InteractAudioID;

	[Token(Token = "0x6002BB7")]
	[Address(RVA = "0x922F30", Offset = "0x921D30", Length = "0x1CD")]
	public override void InitializeInteraction()
	{
	}

	[Token(Token = "0x6002BB8")]
	[Address(RVA = "0x923100", Offset = "0x921F00", Length = "0x109")]
	protected override void BeginHold()
	{
	}

	[Token(Token = "0x6002BB9")]
	[Address(RVA = "0x923210", Offset = "0x922010", Length = "0x36")]
	public override bool PerformInteraction()
	{
		return false;
	}

	[Token(Token = "0x6002BBA")]
	[Address(RVA = "0x923250", Offset = "0x922050", Length = "0xDF")]
	public override void CancelHold()
	{
	}

	[Token(Token = "0x6002BBB")]
	[Address(RVA = "0x923330", Offset = "0x922130", Length = "0xAB")]
	private void PlayAudio()
	{
	}

	[Token(Token = "0x6002BBC")]
	[Address(RVA = "0x9233E0", Offset = "0x9221E0", Length = "0x57")]
	private void StopAudio()
	{
	}

	[Token(Token = "0x6002BBD")]
	[Address(RVA = "0x8F4D40", Offset = "0x8F3B40", Length = "0x7")]
	public RadioTower()
	{
	}
}
