using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x20004FB")]
public class BrokenBody : MonoBehaviour
{
	[SerializeField]
	[Token(Token = "0x4002DA7")]
	[FieldOffset(Offset = "0x20")]
	private LocalizedString m_DisplayName;

	[SerializeField]
	[Range(1f, 3f)]
	[Token(Token = "0x4002DA8")]
	[FieldOffset(Offset = "0x28")]
	private float m_DamageMultiplier;

	[Token(Token = "0x17000256")]
	public float DamageMultiplier
	{
		[Token(Token = "0x60025B7")]
		[Address(RVA = "0x504290", Offset = "0x503090", Length = "0x6")]
		get
		{
			return 0f;
		}
	}

	[Token(Token = "0x17000257")]
	[field: Token(Token = "0x4002DA9")]
	[field: FieldOffset(Offset = "0x2C")]
	public bool HasAffliction
	{
		[Token(Token = "0x60025B8")]
		[Address(RVA = "0x620CB0", Offset = "0x61FAB0", Length = "0x5")]
		get;
		[Token(Token = "0x60025B9")]
		[Address(RVA = "0x880620", Offset = "0x87F420", Length = "0x4")]
		private set;
	}

	[Token(Token = "0x17000258")]
	private string IconSpriteName
	{
		[Token(Token = "0x60025BA")]
		[Address(RVA = "0x880630", Offset = "0x87F430", Length = "0x48")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60025BB")]
	[Address(RVA = "0x880680", Offset = "0x87F480", Length = "0x1AB")]
	public void ApplyBrokenBody(AfflictionOptions options = AfflictionOptions.DoAutoSave | AfflictionOptions.DisplayIcon)
	{
	}

	[Token(Token = "0x60025BC")]
	[Address(RVA = "0x880830", Offset = "0x87F630", Length = "0x10C")]
	public void Cure(AfflictionOptions options = AfflictionOptions.DisplayIcon)
	{
	}

	[Token(Token = "0x60025BD")]
	[Address(RVA = "0x880940", Offset = "0x87F740", Length = "0x4A")]
	public BrokenBody()
	{
	}
}
