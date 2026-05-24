using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x2000455")]
public class BearSpearItem : MonoBehaviour
{
	[Token(Token = "0x2000456")]
	public enum SpearState
	{
		[Token(Token = "0x400277B")]
		None,
		[Token(Token = "0x400277C")]
		Setting,
		[Token(Token = "0x400277D")]
		Raised,
		[Token(Token = "0x400277E")]
		Recovering
	}

	[Token(Token = "0x400275B")]
	[FieldOffset(Offset = "0x20")]
	public float m_SetSpearDurationSeconds;

	[Token(Token = "0x400275C")]
	[FieldOffset(Offset = "0x24")]
	public float m_RecoverSpearDurationSeconds;

	[Token(Token = "0x400275D")]
	[FieldOffset(Offset = "0x28")]
	public Vector2 m_PitchLimitDegrees;

	[Token(Token = "0x400275E")]
	[FieldOffset(Offset = "0x30")]
	public Vector2 m_YawLimitDegrees;

	[Token(Token = "0x400275F")]
	[FieldOffset(Offset = "0x38")]
	public GameObject m_BrokenSpearPrefab;

	[Header("Stamina")]
	[Tooltip("Sprint stamina drain while the spear is set, per second.")]
	[Token(Token = "0x4002760")]
	[FieldOffset(Offset = "0x40")]
	public float m_StaminaCost;

	[Header("Damage")]
	[Token(Token = "0x4002761")]
	[FieldOffset(Offset = "0x44")]
	public float m_DamageDealt;

	[Token(Token = "0x4002762")]
	[FieldOffset(Offset = "0x48")]
	public float m_BleedOutMinutes;

	[Token(Token = "0x4002763")]
	[FieldOffset(Offset = "0x4C")]
	public float m_DistanceForDamageMeters;

	[Token(Token = "0x4002764")]
	[FieldOffset(Offset = "0x50")]
	public float m_AngleForDamageDegrees;

	[Header("Animation")]
	[Token(Token = "0x4002765")]
	[FieldOffset(Offset = "0x54")]
	public float m_AnimationSetBaseDuration;

	[Token(Token = "0x4002766")]
	[FieldOffset(Offset = "0x58")]
	public float m_AnimationRecoverBaseDuration;

	[Token(Token = "0x4002767")]
	[FieldOffset(Offset = "0x60")]
	private GearItem m_GearItem;

	[Token(Token = "0x4002768")]
	[FieldOffset(Offset = "0x68")]
	private float m_ActionElapsedSeconds;

	[Token(Token = "0x4002769")]
	[FieldOffset(Offset = "0x6C")]
	private SpearState m_CurrentSpearState;

	[Token(Token = "0x400276B")]
	[FieldOffset(Offset = "0x74")]
	private Vector2 m_StartPitchLimit;

	[Token(Token = "0x400276C")]
	[FieldOffset(Offset = "0x7C")]
	private Vector2 m_StartYawLimit;

	[Token(Token = "0x400276D")]
	[FieldOffset(Offset = "0x88")]
	private BaseAi m_HitAi;

	[Token(Token = "0x400276E")]
	[FieldOffset(Offset = "0x90")]
	private LocalizedDamage m_LocalizedDamage;

	[Token(Token = "0x400276F")]
	[FieldOffset(Offset = "0x98")]
	private Vector3 m_HitPosition;

	[Token(Token = "0x4002770")]
	[FieldOffset(Offset = "0xA4")]
	private Vector3 m_HitSourcePosition;

	[Token(Token = "0x4002771")]
	[FieldOffset(Offset = "0xB0")]
	private float m_HitDamage;

	[Token(Token = "0x4002772")]
	[FieldOffset(Offset = "0xB4")]
	private float m_HitBleedOutMinutes;

	[Token(Token = "0x4002773")]
	[FieldOffset(Offset = "0xB8")]
	private SpearState m_PendingSpearState;

	[Token(Token = "0x4002774")]
	[FieldOffset(Offset = "0xBC")]
	private bool m_HasDisabledHipAndShoulderOffsetLayer;

	[Token(Token = "0x4002775")]
	[FieldOffset(Offset = "0xBD")]
	private bool m_HasTriggeredGenericAim;

	[Token(Token = "0x4002776")]
	[FieldOffset(Offset = "0xC0")]
	private float m_PreviousTimeScale;

	[Token(Token = "0x4002777")]
	[FieldOffset(Offset = "0xC4")]
	private AnimatorUpdateMode m_PreviousAnimatorUpdateMode;

	[Token(Token = "0x4002778")]
	[FieldOffset(Offset = "0xC8")]
	private BearSpearHead m_BearSpearHead;

	[Token(Token = "0x4002779")]
	private const float MAX_MULTIPLIER = 10000f;

	[Token(Token = "0x1700021C")]
	[field: Token(Token = "0x400276A")]
	[field: FieldOffset(Offset = "0x70")]
	public PlayerControlMode m_ControlModeToRestore
	{
		[Token(Token = "0x60020A5")]
		[Address(RVA = "0x658130", Offset = "0x656F30", Length = "0x4")]
		get;
		[Token(Token = "0x60020A6")]
		[Address(RVA = "0x802EB0", Offset = "0x801CB0", Length = "0x4")]
		private set;
	}

	[Token(Token = "0x60020A7")]
	[Address(RVA = "0x802EC0", Offset = "0x801CC0", Length = "0x8C")]
	private void Awake()
	{
	}

	[Token(Token = "0x60020A8")]
	[Address(RVA = "0x802F50", Offset = "0x801D50", Length = "0x137")]
	private float GetDamageDealt(BaseAi bai)
	{
		return 0f;
	}

	[Token(Token = "0x60020A9")]
	[Address(RVA = "0x803090", Offset = "0x801E90", Length = "0xF1")]
	private float GetBleedOutMinutes(BaseAi bai)
	{
		return 0f;
	}

	[Token(Token = "0x60020AA")]
	[Address(RVA = "0x803190", Offset = "0x801F90", Length = "0x123")]
	private bool IsDamageFatal(BaseAi bai, float damageDealt)
	{
		return false;
	}

	[Token(Token = "0x60020AB")]
	[Address(RVA = "0x8032C0", Offset = "0x8020C0", Length = "0x7EC")]
	private void OnAiCollidedWithSpear(BaseAi bai, Vector3 spearForward, LocalizedDamage localizedDamage)
	{
	}

	[Token(Token = "0x60020AC")]
	[Address(RVA = "0x803AB0", Offset = "0x8028B0", Length = "0x32A")]
	private void OnStruggleHitEnd()
	{
	}

	[Token(Token = "0x60020AD")]
	[Address(RVA = "0x803DE0", Offset = "0x802BE0", Length = "0x4C8")]
	private void Break()
	{
	}

	[Token(Token = "0x60020AE")]
	[Address(RVA = "0x4A2140", Offset = "0x4A0F40", Length = "0x3")]
	private bool IsSpearHitLethal()
	{
		return false;
	}

	[Token(Token = "0x60020AF")]
	[Address(RVA = "0x8042B0", Offset = "0x8030B0", Length = "0x2CC")]
	private float DistanceToNearestSpearable()
	{
		return 0f;
	}

	[Token(Token = "0x60020B0")]
	[Address(RVA = "0x804580", Offset = "0x803380", Length = "0x624")]
	public void UpdateCollision(BaseAi bai)
	{
	}

	[Token(Token = "0x60020B1")]
	[Address(RVA = "0x804BB0", Offset = "0x8039B0", Length = "0x18D")]
	private void Update_SpearRaised()
	{
	}

	[Token(Token = "0x60020B2")]
	[Address(RVA = "0x804D40", Offset = "0x803B40", Length = "0x3F1")]
	private void Update()
	{
	}

	[Token(Token = "0x60020B3")]
	[Address(RVA = "0x805140", Offset = "0x803F40", Length = "0x43")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x60020B4")]
	[Address(RVA = "0x805190", Offset = "0x803F90", Length = "0x8")]
	public bool IsRaised()
	{
		return false;
	}

	[Token(Token = "0x60020B5")]
	[Address(RVA = "0x8051A0", Offset = "0x803FA0", Length = "0x8")]
	public bool IsRaisedOrRaisingOrLowering()
	{
		return false;
	}

	[Token(Token = "0x60020B6")]
	[Address(RVA = "0x502590", Offset = "0x501390", Length = "0x6")]
	public float GetActionElapsedInSeconds()
	{
		return 0f;
	}

	[Token(Token = "0x60020B7")]
	[Address(RVA = "0x8051B0", Offset = "0x803FB0", Length = "0x8")]
	public bool CanStartZoom()
	{
		return false;
	}

	[Token(Token = "0x60020B8")]
	[Address(RVA = "0x8051C0", Offset = "0x803FC0", Length = "0x13D")]
	public bool CheckStaminaForRaising()
	{
		return false;
	}

	[Token(Token = "0x60020B9")]
	[Address(RVA = "0x805300", Offset = "0x804100", Length = "0x11")]
	public bool CanEndZoom()
	{
		return false;
	}

	[Token(Token = "0x60020BA")]
	[Address(RVA = "0x805320", Offset = "0x804120", Length = "0x132")]
	public void ZoomStart()
	{
	}

	[Token(Token = "0x60020BB")]
	[Address(RVA = "0x5025C0", Offset = "0x5013C0", Length = "0x4")]
	public SpearState GetCurrentSpearState()
	{
		return default(SpearState);
	}

	[Token(Token = "0x60020BC")]
	[Address(RVA = "0x805460", Offset = "0x804260", Length = "0x102")]
	public float GetAngleBetweenSpearAndBearHeadings(BaseAi bai, Vector3 spearForward)
	{
		return 0f;
	}

	[Token(Token = "0x60020BD")]
	[Address(RVA = "0x805570", Offset = "0x804370", Length = "0xA8")]
	private void RestoreYawPitchLimits()
	{
	}

	[Token(Token = "0x60020BE")]
	[Address(RVA = "0x805620", Offset = "0x804420", Length = "0x72")]
	public void ZoomEnd()
	{
	}

	[Token(Token = "0x60020BF")]
	[Address(RVA = "0x8056A0", Offset = "0x8044A0", Length = "0x12B")]
	public void CancelAction()
	{
	}

	[Token(Token = "0x60020C0")]
	[Address(RVA = "0x8057D0", Offset = "0x8045D0", Length = "0x12B")]
	public void HitAction()
	{
	}

	[Token(Token = "0x60020C1")]
	[Address(RVA = "0x805900", Offset = "0x804700", Length = "0x1AF")]
	public string GetStateDebugString()
	{
		return null;
	}

	[Token(Token = "0x60020C2")]
	[Address(RVA = "0x805AB0", Offset = "0x8048B0", Length = "0x7")]
	public void OnDestroy()
	{
	}

	[Token(Token = "0x60020C3")]
	[Address(RVA = "0x805AC0", Offset = "0x8048C0", Length = "0x1D7")]
	private void SetCurrentState(SpearState state)
	{
	}

	[Token(Token = "0x60020C4")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	private void OnRaised()
	{
	}

	[Token(Token = "0x60020C5")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	private void OnRaisedCancelled()
	{
	}

	[Token(Token = "0x60020C6")]
	[Address(RVA = "0x805CA0", Offset = "0x804AA0", Length = "0x1D5")]
	private void OnEnter_None()
	{
	}

	[Token(Token = "0x60020C7")]
	[Address(RVA = "0x805E80", Offset = "0x804C80", Length = "0x377")]
	private void OnEnter_Setting()
	{
	}

	[Token(Token = "0x60020C8")]
	[Address(RVA = "0x806200", Offset = "0x805000", Length = "0x480")]
	private void OnEnter_Raised()
	{
	}

	[Token(Token = "0x60020C9")]
	[Address(RVA = "0x806690", Offset = "0x805490", Length = "0x174")]
	private void OnEnter_Recovering()
	{
	}

	[Token(Token = "0x60020CA")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	private void OnExit_None()
	{
	}

	[Token(Token = "0x60020CB")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	private void OnExit_Setting()
	{
	}

	[Token(Token = "0x60020CC")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	private void OnExit_Raised()
	{
	}

	[Token(Token = "0x60020CD")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	private void OnExit_Recovering()
	{
	}

	[Token(Token = "0x60020CE")]
	[Address(RVA = "0x806810", Offset = "0x805610", Length = "0x13F")]
	private void MaybeDisableStaminaRecharge()
	{
	}

	[Token(Token = "0x60020CF")]
	[Address(RVA = "0x806950", Offset = "0x805750", Length = "0x13F")]
	private void MaybeEnableStaminaRecharge()
	{
	}

	[Token(Token = "0x60020D0")]
	[Address(RVA = "0x806A90", Offset = "0x805890", Length = "0x2E9")]
	private bool IsEquipped()
	{
		return false;
	}

	[Token(Token = "0x60020D1")]
	[Address(RVA = "0x806D80", Offset = "0x805B80", Length = "0x4A")]
	public BearSpearItem()
	{
	}
}
