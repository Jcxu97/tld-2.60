using Cpp2ILInjected;
using UnityEngine;

[RequireComponent(typeof(BaseAi))]
[RequireComponent(typeof(Inspect))]
[Token(Token = "0x20004EB")]
public class WildlifeItem : MonoBehaviour
{
	[Header("Audio")]
	[SerializeField]
	[Token(Token = "0x4002CEA")]
	[FieldOffset(Offset = "0x20")]
	private string m_KillAudio;

	[SerializeField]
	[Token(Token = "0x4002CEB")]
	[FieldOffset(Offset = "0x28")]
	private string m_PickUpAudio;

	[SerializeField]
	[Token(Token = "0x4002CEC")]
	[FieldOffset(Offset = "0x30")]
	private string m_ReleaseAudio;

	[Header("Objects")]
	[SerializeField]
	[Token(Token = "0x4002CED")]
	[FieldOffset(Offset = "0x38")]
	private GearItem m_GearItem;

	[Token(Token = "0x4002CEE")]
	[FieldOffset(Offset = "0x40")]
	private BaseAi m_BaseAi;

	[Token(Token = "0x4002CEF")]
	[FieldOffset(Offset = "0x48")]
	private bool m_PickedUp;

	[Token(Token = "0x4002CF0")]
	[FieldOffset(Offset = "0x4C")]
	private PlayerControlMode m_ControlModeAtTimeOfPickup;

	[Token(Token = "0x6002553")]
	[Address(RVA = "0x878FE0", Offset = "0x877DE0", Length = "0x12A")]
	public void Awake()
	{
	}

	[Token(Token = "0x6002554")]
	[Address(RVA = "0x879110", Offset = "0x877F10", Length = "0x25A")]
	public void Update()
	{
	}

	[Token(Token = "0x6002555")]
	[Address(RVA = "0x879370", Offset = "0x878170", Length = "0x22E")]
	public void PickupWildlifeItem()
	{
	}

	[Token(Token = "0x6002556")]
	[Address(RVA = "0x8795A0", Offset = "0x8783A0", Length = "0x115")]
	public GearItem SpawnCarcass()
	{
		return null;
	}

	[Token(Token = "0x6002557")]
	[Address(RVA = "0x8796C0", Offset = "0x8784C0", Length = "0x1A7")]
	public void StartKillAnimation()
	{
	}

	[Token(Token = "0x6002558")]
	[Address(RVA = "0x879870", Offset = "0x878670", Length = "0x113")]
	public void StartReleaseAnimation()
	{
	}

	[Token(Token = "0x6002559")]
	[Address(RVA = "0x879990", Offset = "0x878790", Length = "0x104")]
	public void DoImmediateRelease()
	{
	}

	[Token(Token = "0x600255A")]
	[Address(RVA = "0x879AA0", Offset = "0x8788A0", Length = "0x2B9")]
	private void DisableAI()
	{
	}

	[Token(Token = "0x600255B")]
	[Address(RVA = "0x879D60", Offset = "0x878B60", Length = "0xF2")]
	private void DisablePhysics()
	{
	}

	[Token(Token = "0x600255C")]
	[Address(RVA = "0x879E60", Offset = "0x878C60", Length = "0x2D9")]
	private void DisableRendering()
	{
	}

	[Token(Token = "0x600255D")]
	[Address(RVA = "0x87A140", Offset = "0x878F40", Length = "0x2B9")]
	private void EnableAI()
	{
	}

	[Token(Token = "0x600255E")]
	[Address(RVA = "0x87A400", Offset = "0x879200", Length = "0xF2")]
	private void EnablePhysics()
	{
	}

	[Token(Token = "0x600255F")]
	[Address(RVA = "0x87A500", Offset = "0x879300", Length = "0x2D9")]
	private void EnableRendering()
	{
	}

	[Token(Token = "0x6002560")]
	[Address(RVA = "0x87A7E0", Offset = "0x8795E0", Length = "0x191")]
	private bool IsActionAllowed()
	{
		return false;
	}

	[Token(Token = "0x6002561")]
	[Address(RVA = "0x87A980", Offset = "0x879780", Length = "0x14E")]
	private void OnKilled()
	{
	}

	[Token(Token = "0x6002562")]
	[Address(RVA = "0x87AAD0", Offset = "0x8798D0", Length = "0x290")]
	private void OnReleased()
	{
	}

	[Token(Token = "0x6002563")]
	[Address(RVA = "0x87AD70", Offset = "0x879B70", Length = "0x9D")]
	private void ResetControls()
	{
	}

	[Token(Token = "0x6002564")]
	[Address(RVA = "0x4AF5E0", Offset = "0x4AE3E0", Length = "0x43")]
	public WildlifeItem()
	{
	}
}
