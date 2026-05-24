using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x2000510")]
public class DiminishedState : MonoBehaviour
{
	[SerializeField]
	[Range(0f, 3f)]
	[Token(Token = "0x4002E60")]
	[FieldOffset(Offset = "0x20")]
	private float m_ConditionRecoveryMultplier;

	[SerializeField]
	[Range(0f, 3f)]
	[Token(Token = "0x4002E61")]
	[FieldOffset(Offset = "0x24")]
	private float m_StaminaDrainMultiplier;

	[Token(Token = "0x4002E62")]
	[FieldOffset(Offset = "0x28")]
	private DiminishedStateAfflictionState m_State;

	[Token(Token = "0x17000266")]
	public bool HasAffliction
	{
		[Token(Token = "0x600266A")]
		[Address(RVA = "0x8A0A90", Offset = "0x89F890", Length = "0x25")]
		get
		{
			return false;
		}
	}

	[Token(Token = "0x17000267")]
	public float HoursRemaining
	{
		[Token(Token = "0x600266B")]
		[Address(RVA = "0x8A0AC0", Offset = "0x89F8C0", Length = "0x1C")]
		get
		{
			return 0f;
		}
	}

	[Token(Token = "0x17000268")]
	public float ConditionRecoveryMultiplier
	{
		[Token(Token = "0x600266C")]
		[Address(RVA = "0x5042F0", Offset = "0x5030F0", Length = "0x6")]
		get
		{
			return 0f;
		}
	}

	[Token(Token = "0x17000269")]
	public float StaminaDrainMultiplier
	{
		[Token(Token = "0x600266D")]
		[Address(RVA = "0x504310", Offset = "0x503110", Length = "0x6")]
		get
		{
			return 0f;
		}
	}

	[Token(Token = "0x1700026A")]
	private string DisplayNameLocID
	{
		[Token(Token = "0x600266E")]
		[Address(RVA = "0x8A0AE0", Offset = "0x89F8E0", Length = "0x48")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700026B")]
	private string IconSpriteName
	{
		[Token(Token = "0x600266F")]
		[Address(RVA = "0x8A0B30", Offset = "0x89F930", Length = "0x48")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6002670")]
	[Address(RVA = "0x8A0B80", Offset = "0x89F980", Length = "0x1B7")]
	public void Apply(float timeActive, AfflictionOptions options = AfflictionOptions.DisplayIcon)
	{
	}

	[Token(Token = "0x6002671")]
	[Address(RVA = "0x8A0D40", Offset = "0x89FB40", Length = "0x17A")]
	public void Cure(AfflictionOptions options = AfflictionOptions.DisplayIcon)
	{
	}

	[Token(Token = "0x6002672")]
	[Address(RVA = "0x413AB0", Offset = "0x4128B0", Length = "0x5")]
	public DiminishedStateAfflictionState Serialize()
	{
		return null;
	}

	[Token(Token = "0x6002673")]
	[Address(RVA = "0x8A0EC0", Offset = "0x89FCC0", Length = "0xBA")]
	public void Deserialize(DiminishedStateAfflictionState afflictionState)
	{
	}

	[Token(Token = "0x6002674")]
	[Address(RVA = "0x8A0F80", Offset = "0x89FD80", Length = "0x133")]
	private void Update()
	{
	}

	[Token(Token = "0x6002675")]
	[Address(RVA = "0x8A10C0", Offset = "0x89FEC0", Length = "0xC7")]
	public DiminishedState()
	{
	}
}
