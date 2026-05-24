using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x2000016")]
public class vp_MuzzleFlash : MonoBehaviour
{
	[Token(Token = "0x40001D0")]
	[FieldOffset(Offset = "0x20")]
	public ParticleSystem muzzleFlashFX;

	[Token(Token = "0x40001D1")]
	[FieldOffset(Offset = "0x28")]
	public ParticleSystem muzzleSmokeFX;

	[Token(Token = "0x40001D2")]
	[FieldOffset(Offset = "0x30")]
	public ParticleSystem breachPuffFX;

	[Token(Token = "0x40001D3")]
	[FieldOffset(Offset = "0x38")]
	public ParticleSystem m_MisfireFX;

	[Token(Token = "0x40001D4")]
	[FieldOffset(Offset = "0x40")]
	public float m_FlashDelay;

	[Token(Token = "0x40001D5")]
	[FieldOffset(Offset = "0x44")]
	public float m_SmokeDelay;

	[Token(Token = "0x40001D6")]
	[FieldOffset(Offset = "0x48")]
	protected float m_FadeSpeed;

	[Token(Token = "0x40001D7")]
	[FieldOffset(Offset = "0x4C")]
	protected bool m_ForceShow;

	[Token(Token = "0x40001D8")]
	[FieldOffset(Offset = "0x50")]
	protected Color m_Color;

	[Token(Token = "0x40001D9")]
	[FieldOffset(Offset = "0x60")]
	private Transform m_RenderTransform;

	[Token(Token = "0x40001DA")]
	[FieldOffset(Offset = "0x68")]
	private ParticleSystem inst_MuzzleFlash;

	[Token(Token = "0x40001DB")]
	[FieldOffset(Offset = "0x70")]
	private ParticleSystem inst_MuzzleSmoke;

	[Token(Token = "0x40001DC")]
	[FieldOffset(Offset = "0x78")]
	private ParticleSystem inst_BreachPuff;

	[Token(Token = "0x40001DD")]
	[FieldOffset(Offset = "0x80")]
	private ParticleSystem m_MisfireFXInstance;

	[Token(Token = "0x40001DE")]
	[FieldOffset(Offset = "0x88")]
	private Material m_FlashMaterial;

	[Token(Token = "0x40001DF")]
	[FieldOffset(Offset = "0x90")]
	private float m_FlashDelayBeforeShow;

	[Token(Token = "0x40001E0")]
	[FieldOffset(Offset = "0x94")]
	private float m_SmokeDelayBeforeShow;

	[Token(Token = "0x40001E1")]
	[FieldOffset(Offset = "0x98")]
	private bool m_HasMisfired;

	[Token(Token = "0x40001E2")]
	private const float DEFAULT_FLASH_ALPHA = 0.5f;

	[Token(Token = "0x40001E3")]
	private static readonly int s_TintColorShaderID;

	[Token(Token = "0x40001E4")]
	[FieldOffset(Offset = "0xA0")]
	private SmokeTrail m_SmokeTrail;

	[Token(Token = "0x1700001A")]
	public float FadeSpeed
	{
		[Token(Token = "0x600017B")]
		[Address(RVA = "0x5737C0", Offset = "0x5725C0", Length = "0x6")]
		get
		{
			return 0f;
		}
		[Token(Token = "0x600017C")]
		[Address(RVA = "0x5737D0", Offset = "0x5725D0", Length = "0x6")]
		set
		{
		}
	}

	[Token(Token = "0x1700001B")]
	public bool ForceShow
	{
		[Token(Token = "0x600017D")]
		[Address(RVA = "0x5737E0", Offset = "0x5725E0", Length = "0x5")]
		get
		{
			return false;
		}
		[Token(Token = "0x600017E")]
		[Address(RVA = "0x5737F0", Offset = "0x5725F0", Length = "0x4")]
		set
		{
		}
	}

	[Token(Token = "0x600017F")]
	[Address(RVA = "0x573800", Offset = "0x572600", Length = "0x256")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000180")]
	[Address(RVA = "0x573A60", Offset = "0x572860", Length = "0xD25")]
	private void Start()
	{
	}

	[Token(Token = "0x6000181")]
	[Address(RVA = "0x574790", Offset = "0x573590", Length = "0x3C0")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6000182")]
	[Address(RVA = "0x574B60", Offset = "0x573960", Length = "0x968")]
	private void Update()
	{
	}

	[Token(Token = "0x6000183")]
	[Address(RVA = "0x5754D0", Offset = "0x5742D0", Length = "0x8")]
	public void Show()
	{
	}

	[Token(Token = "0x6000184")]
	[Address(RVA = "0x5754E0", Offset = "0x5742E0", Length = "0x23C")]
	public void Shoot(Transform tr, bool hasMisfired)
	{
	}

	[Token(Token = "0x6000185")]
	[Address(RVA = "0x575720", Offset = "0x574520", Length = "0x454")]
	private void ShowFlash()
	{
	}

	[Token(Token = "0x6000186")]
	[Address(RVA = "0x575B80", Offset = "0x574980", Length = "0x10A")]
	private void ShowSmoke()
	{
	}

	[Token(Token = "0x6000187")]
	[Address(RVA = "0x575C90", Offset = "0x574A90", Length = "0x5A")]
	public vp_MuzzleFlash()
	{
	}
}
