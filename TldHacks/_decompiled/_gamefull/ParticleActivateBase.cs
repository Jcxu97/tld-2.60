using Cpp2ILInjected;
using UnityEngine;

[RequireComponent(typeof(ParticleSystem))]
[Token(Token = "0x20003E0")]
public abstract class ParticleActivateBase : MonoBehaviour
{
	[AutoComponent(ComponentRequirement.Required)]
	[HideInInspector]
	[Token(Token = "0x40022E6")]
	[FieldOffset(Offset = "0x20")]
	public ParticleSystem m_ParticleSystem;

	[Tooltip("When this is enabled, particle systems will not deactivate immediate when considered to be outside of the player's view")]
	[SerializeField]
	[Token(Token = "0x40022E7")]
	[FieldOffset(Offset = "0x28")]
	private bool m_AlwaysConsideredInView;

	[Token(Token = "0x40022E8")]
	[FieldOffset(Offset = "0x29")]
	private bool m_IsManaged;

	[Token(Token = "0x40022E9")]
	[FieldOffset(Offset = "0x2A")]
	private bool m_IsVisible;

	[Token(Token = "0x6001E0D")]
	public abstract bool CanBeActive();

	[Token(Token = "0x6001E0E")]
	[Address(RVA = "0x7B2EB0", Offset = "0x7B1CB0", Length = "0xAC")]
	public void SetManaged(bool isManaged)
	{
	}

	[Token(Token = "0x6001E0F")]
	[Address(RVA = "0x7B2F60", Offset = "0x7B1D60", Length = "0xD")]
	public bool IsVisible()
	{
		return false;
	}

	[Token(Token = "0x6001E10")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	private void OnValidate()
	{
	}

	[Token(Token = "0x6001E11")]
	[Address(RVA = "0x7B2F70", Offset = "0x7B1D70", Length = "0xC")]
	private void Awake()
	{
	}

	[Token(Token = "0x6001E12")]
	[Address(RVA = "0x7B2F80", Offset = "0x7B1D80", Length = "0x66")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6001E13")]
	[Address(RVA = "0x7B2FF0", Offset = "0x7B1DF0", Length = "0x5")]
	private void OnBecameVisible()
	{
	}

	[Token(Token = "0x6001E14")]
	[Address(RVA = "0x7B3000", Offset = "0x7B1E00", Length = "0x5")]
	private void OnBecameInvisible()
	{
	}

	[Token(Token = "0x6001E15")]
	[Address(RVA = "0x7B2E60", Offset = "0x7B1C60", Length = "0x47")]
	protected ParticleActivateBase()
	{
	}
}
