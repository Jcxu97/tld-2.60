using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x200053D")]
public class WeakJoints : MonoBehaviour
{
	[SerializeField]
	[Token(Token = "0x4003039")]
	[FieldOffset(Offset = "0x20")]
	private LocalizedString m_DisplayName;

	[SerializeField]
	[Range(0f, 1f)]
	[Token(Token = "0x400303A")]
	[FieldOffset(Offset = "0x28")]
	private float m_SprintSpeedMultiplier;

	[SerializeField]
	[Token(Token = "0x400303B")]
	[FieldOffset(Offset = "0x2C")]
	private float m_SprainChanceModifier;

	[SerializeField]
	[Range(0f, 100f)]
	[Token(Token = "0x400303C")]
	[FieldOffset(Offset = "0x30")]
	private float m_SprainDamage;

	[SerializeField]
	[Range(1f, 3f)]
	[Token(Token = "0x400303D")]
	[FieldOffset(Offset = "0x34")]
	private float m_WeaponAimTimeReductionMultiplier;

	[Token(Token = "0x17000293")]
	public float SprintSpeedModifier
	{
		[Token(Token = "0x6002811")]
		[Address(RVA = "0x504290", Offset = "0x503090", Length = "0x6")]
		get
		{
			return 0f;
		}
	}

	[Token(Token = "0x17000294")]
	public float SprainChanceModifier
	{
		[Token(Token = "0x6002812")]
		[Address(RVA = "0x5093C0", Offset = "0x5081C0", Length = "0x6")]
		get
		{
			return 0f;
		}
	}

	[Token(Token = "0x17000295")]
	public float WeaponAimTimeReductionModifier
	{
		[Token(Token = "0x6002813")]
		[Address(RVA = "0x509500", Offset = "0x508300", Length = "0x6")]
		get
		{
			return 0f;
		}
	}

	[Token(Token = "0x17000296")]
	[field: Token(Token = "0x400303E")]
	[field: FieldOffset(Offset = "0x38")]
	public bool HasAffliction
	{
		[Token(Token = "0x6002814")]
		[Address(RVA = "0x8BE400", Offset = "0x8BD200", Length = "0x5")]
		get;
		[Token(Token = "0x6002815")]
		[Address(RVA = "0x8BE410", Offset = "0x8BD210", Length = "0x4")]
		private set;
	}

	[Token(Token = "0x17000297")]
	private string IconSpriteName
	{
		[Token(Token = "0x6002816")]
		[Address(RVA = "0x8BE420", Offset = "0x8BD220", Length = "0x48")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6002817")]
	[Address(RVA = "0x8BE470", Offset = "0x8BD270", Length = "0x1AB")]
	public void ApplyWeakJoints(AfflictionOptions options = AfflictionOptions.DoAutoSave | AfflictionOptions.DisplayIcon)
	{
	}

	[Token(Token = "0x6002818")]
	[Address(RVA = "0x8BE620", Offset = "0x8BD420", Length = "0x10C")]
	public void Cure(AfflictionOptions options = AfflictionOptions.DisplayIcon)
	{
	}

	[Token(Token = "0x6002819")]
	[Address(RVA = "0x8BE730", Offset = "0x8BD530", Length = "0x80")]
	public void MaybeApplySprainDamage()
	{
	}

	[Token(Token = "0x600281A")]
	[Address(RVA = "0x8BE7C0", Offset = "0x8BD5C0", Length = "0x51")]
	public WeakJoints()
	{
	}
}
