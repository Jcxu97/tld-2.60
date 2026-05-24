using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x20008D0")]
public class PlayerSwing : MonoBehaviour
{
	[Token(Token = "0x4005C45")]
	[FieldOffset(Offset = "0x20")]
	public string m_SwingVoiceOver;

	[Token(Token = "0x4005C46")]
	[FieldOffset(Offset = "0x28")]
	public string m_SwingToWardPredatorVoiceOver;

	[Token(Token = "0x4005C47")]
	[FieldOffset(Offset = "0x30")]
	public float m_DistanceForFleeCheckAfterSwing;

	[Token(Token = "0x4005C48")]
	[FieldOffset(Offset = "0x34")]
	private int m_AnimState_Swing;

	[Token(Token = "0x4005C49")]
	[FieldOffset(Offset = "0x38")]
	private float m_StaminaDrainPerSecond;

	[Token(Token = "0x4005C4A")]
	[FieldOffset(Offset = "0x40")]
	private FirstPersonItem m_FirstPersonItem;

	[Token(Token = "0x600510E")]
	[Address(RVA = "0xE1DAD0", Offset = "0xE1C8D0", Length = "0x41")]
	private void Start()
	{
	}

	[Token(Token = "0x600510F")]
	[Address(RVA = "0xE1DB20", Offset = "0xE1C920", Length = "0x104")]
	private void Update()
	{
	}

	[Token(Token = "0x6005110")]
	[Address(RVA = "0xE1DC30", Offset = "0xE1CA30", Length = "0x287")]
	public bool SwingIsPlaying()
	{
		return false;
	}

	[Token(Token = "0x6005111")]
	[Address(RVA = "0xE1DEC0", Offset = "0xE1CCC0", Length = "0x132")]
	public void Swing(FirstPersonItem fpi, PlayerAnimation.OnAnimationEvent midSwingEvent)
	{
	}

	[Token(Token = "0x6005112")]
	[Address(RVA = "0xE1E000", Offset = "0xE1CE00", Length = "0x2E9")]
	private void OnBrandishBegin()
	{
	}

	[Token(Token = "0x6005113")]
	[Address(RVA = "0xE1E2F0", Offset = "0xE1D0F0", Length = "0x564")]
	private bool WardPredatorsWithSwing()
	{
		return false;
	}

	[Token(Token = "0x6005114")]
	[Address(RVA = "0x4AF5E0", Offset = "0x4AE3E0", Length = "0x43")]
	public PlayerSwing()
	{
	}
}
