using Cpp2ILInjected;
using UnityEngine;

[RequireComponent(typeof(vp_FPSWeapon))]
[Token(Token = "0x2000012")]
public class vp_FPSShooter : vp_Component
{
	[Token(Token = "0x4000104")]
	[FieldOffset(Offset = "0x48")]
	protected vp_FPSWeapon m_Weapon;

	[Token(Token = "0x4000105")]
	[FieldOffset(Offset = "0x50")]
	protected vp_FPSCamera m_Camera;

	[Token(Token = "0x4000106")]
	[FieldOffset(Offset = "0x58")]
	public Transform BulletEmissionLocator;

	[Token(Token = "0x4000107")]
	[FieldOffset(Offset = "0x60")]
	public GameObject ProjectilePrefab;

	[Token(Token = "0x4000108")]
	[FieldOffset(Offset = "0x68")]
	public bool ProjectileCustomPrefab;

	[Token(Token = "0x4000109")]
	[FieldOffset(Offset = "0x6C")]
	public float ProjectileScale;

	[Token(Token = "0x400010A")]
	[FieldOffset(Offset = "0x70")]
	public int ProjectileCount;

	[Token(Token = "0x400010B")]
	[FieldOffset(Offset = "0x74")]
	public float ProjectileSpread;

	[Token(Token = "0x400010C")]
	[FieldOffset(Offset = "0x78")]
	protected float m_NextAllowedFireTime;

	[Token(Token = "0x400010D")]
	[FieldOffset(Offset = "0x7C")]
	public Vector3 MotionPositionRecoil;

	[Token(Token = "0x400010E")]
	[FieldOffset(Offset = "0x88")]
	public Vector3 MotionRotationRecoil;

	[Token(Token = "0x400010F")]
	[FieldOffset(Offset = "0x94")]
	public float MotionPositionReset;

	[Token(Token = "0x4000110")]
	[FieldOffset(Offset = "0x98")]
	public float MotionRotationReset;

	[Token(Token = "0x4000111")]
	[FieldOffset(Offset = "0x9C")]
	public float MotionPositionPause;

	[Token(Token = "0x4000112")]
	[FieldOffset(Offset = "0xA0")]
	public float MotionRotationPause;

	[Token(Token = "0x4000113")]
	[FieldOffset(Offset = "0xA4")]
	public float MotionDryFireRecoil;

	[Token(Token = "0x4000114")]
	[FieldOffset(Offset = "0xA8")]
	public Vector3 MuzzleFlashPosition;

	[Token(Token = "0x4000115")]
	[FieldOffset(Offset = "0xB4")]
	public Vector3 MuzzleFlashScale;

	[Token(Token = "0x4000116")]
	[FieldOffset(Offset = "0xC0")]
	public float MuzzleFlashFadeSpeed;

	[Token(Token = "0x4000117")]
	[FieldOffset(Offset = "0xC8")]
	public GameObject MuzzleFlashPrefab;

	[Token(Token = "0x4000118")]
	[FieldOffset(Offset = "0xD0")]
	protected GameObject m_MuzzleFlash;

	[Token(Token = "0x4000119")]
	[FieldOffset(Offset = "0xD8")]
	protected vp_MuzzleFlash m_MuzzleFlashComponent;

	[Token(Token = "0x400011A")]
	[FieldOffset(Offset = "0xE0")]
	public GameObject ShellPrefab;

	[Token(Token = "0x400011B")]
	[FieldOffset(Offset = "0xE8")]
	public float ShellScale;

	[Token(Token = "0x400011C")]
	[FieldOffset(Offset = "0xEC")]
	public Vector3 ShellEjectDirection;

	[Token(Token = "0x400011D")]
	[FieldOffset(Offset = "0xF8")]
	public Vector3 ShellEjectPosition;

	[Token(Token = "0x400011E")]
	[FieldOffset(Offset = "0x104")]
	public float ShellEjectVelocity;

	[Token(Token = "0x400011F")]
	[FieldOffset(Offset = "0x108")]
	public float ShellEjectDelay;

	[Token(Token = "0x4000120")]
	[FieldOffset(Offset = "0x10C")]
	public float ShellEjectSpin;

	[Token(Token = "0x4000121")]
	[FieldOffset(Offset = "0x110")]
	public float JamConditionThreshold;

	[Token(Token = "0x4000122")]
	[FieldOffset(Offset = "0x114")]
	public float JamMinimumChance;

	[Token(Token = "0x4000123")]
	[FieldOffset(Offset = "0x118")]
	public float JamMaximumChance;

	[Token(Token = "0x4000124")]
	[FieldOffset(Offset = "0x11C")]
	protected float m_NextAllowedReloadTime;

	[Token(Token = "0x4000125")]
	[FieldOffset(Offset = "0x120")]
	private float m_LastFiredTime;

	[Token(Token = "0x4000126")]
	[FieldOffset(Offset = "0x124")]
	private bool m_WeaponRotatedForShot;

	[Token(Token = "0x4000127")]
	[FieldOffset(Offset = "0x128")]
	private GameObject m_MuzzleFlashTagObject;

	[Token(Token = "0x4000128")]
	[FieldOffset(Offset = "0x130")]
	private float m_SendGunShotAudioEventTimer;

	[Token(Token = "0x17000012")]
	public GameObject MuzzleFlash
	{
		[Token(Token = "0x6000113")]
		[Address(RVA = "0x502680", Offset = "0x501480", Length = "0x8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000013")]
	public float NextAllowedReloadTime
	{
		[Token(Token = "0x6000114")]
		[Address(RVA = "0x562C10", Offset = "0x561A10", Length = "0x9")]
		get
		{
			return 0f;
		}
		[Token(Token = "0x6000115")]
		[Address(RVA = "0x562C20", Offset = "0x561A20", Length = "0x9")]
		set
		{
		}
	}

	[Token(Token = "0x17000014")]
	public float NextAllowedFireTime
	{
		[Token(Token = "0x6000116")]
		[Address(RVA = "0x562C30", Offset = "0x561A30", Length = "0x6")]
		get
		{
			return 0f;
		}
		[Token(Token = "0x6000117")]
		[Address(RVA = "0x562C40", Offset = "0x561A40", Length = "0x6")]
		set
		{
		}
	}

	[Token(Token = "0x17000015")]
	public bool IsReloadCooldownActive
	{
		[Token(Token = "0x6000118")]
		[Address(RVA = "0x562C50", Offset = "0x561A50", Length = "0x59")]
		get
		{
			return false;
		}
	}

	[Token(Token = "0x6000119")]
	[Address(RVA = "0x562CB0", Offset = "0x561AB0", Length = "0x240")]
	protected override void Awake()
	{
	}

	[Token(Token = "0x600011A")]
	[Address(RVA = "0x562F00", Offset = "0x561D00", Length = "0x500")]
	protected override void Start()
	{
	}

	[Token(Token = "0x600011B")]
	[Address(RVA = "0x563410", Offset = "0x562210", Length = "0x46D")]
	protected override void Update()
	{
	}

	[Token(Token = "0x600011C")]
	[Address(RVA = "0x563880", Offset = "0x562680", Length = "0x1F35")]
	public void Fire()
	{
	}

	[Token(Token = "0x600011D")]
	[Address(RVA = "0x5657C0", Offset = "0x5645C0", Length = "0x201")]
	public void DryFire()
	{
	}

	[Token(Token = "0x600011E")]
	[Address(RVA = "0x5659D0", Offset = "0x5647D0", Length = "0x1F8")]
	public bool Reload(int ammoCount)
	{
		return false;
	}

	[Token(Token = "0x600011F")]
	[Address(RVA = "0x565BD0", Offset = "0x5649D0", Length = "0x61")]
	public void PreventFiring(float seconds)
	{
	}

	[Token(Token = "0x6000120")]
	[Address(RVA = "0x565C40", Offset = "0x564A40", Length = "0x52D")]
	public override void Refresh()
	{
	}

	[Token(Token = "0x6000121")]
	[Address(RVA = "0x566170", Offset = "0x564F70", Length = "0x443")]
	public void OnBulletLoaded()
	{
	}

	[Token(Token = "0x6000122")]
	[Address(RVA = "0x5665C0", Offset = "0x5653C0", Length = "0x564")]
	public void OnClipLoaded()
	{
	}

	[Token(Token = "0x6000123")]
	[Address(RVA = "0x566B30", Offset = "0x565930", Length = "0x1AC")]
	private void ShowMuzzleFlash(bool hasMisfired)
	{
	}

	[Token(Token = "0x6000124")]
	[Address(RVA = "0x566CE0", Offset = "0x565AE0", Length = "0x1A8")]
	public vp_FPSShooter()
	{
	}
}
