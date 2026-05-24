using Cpp2ILInjected;
using UnityEngine;
using UnityStandardAssets.ImageEffects;

[Token(Token = "0x20008CF")]
public class PlayerStunned : MonoBehaviour
{
	[Range(0f, 1f)]
	[Token(Token = "0x4005C19")]
	[FieldOffset(Offset = "0x20")]
	public float m_BlurFraction;

	[Header("Blurring Effect")]
	[Token(Token = "0x4005C1A")]
	[FieldOffset(Offset = "0x24")]
	public float m_BlurNoiseStepMin;

	[Token(Token = "0x4005C1B")]
	[FieldOffset(Offset = "0x28")]
	public float m_BlurNoiseStepMax;

	[Token(Token = "0x4005C1C")]
	[FieldOffset(Offset = "0x2C")]
	public float m_BlurMinOffsetRange;

	[Token(Token = "0x4005C1D")]
	[FieldOffset(Offset = "0x30")]
	public float m_BlurMaxOffsetRange;

	[Token(Token = "0x4005C1E")]
	[FieldOffset(Offset = "0x34")]
	public float m_MinScreenFadeAmount;

	[Token(Token = "0x4005C1F")]
	[FieldOffset(Offset = "0x38")]
	public float m_MaxScreenFadeAmount;

	[Token(Token = "0x4005C20")]
	[FieldOffset(Offset = "0x3C")]
	public float m_Blur2Min;

	[Token(Token = "0x4005C21")]
	[FieldOffset(Offset = "0x40")]
	public float m_Blur2Max;

	[Token(Token = "0x4005C22")]
	[FieldOffset(Offset = "0x44")]
	public float m_StaggerNoiseStepMin;

	[Token(Token = "0x4005C23")]
	[FieldOffset(Offset = "0x48")]
	public float m_StaggerNoiseStepMax;

	[Token(Token = "0x4005C24")]
	[FieldOffset(Offset = "0x4C")]
	public float m_StaggerForward;

	[Token(Token = "0x4005C25")]
	[FieldOffset(Offset = "0x50")]
	public float m_StaggerSide;

	[Token(Token = "0x4005C26")]
	[FieldOffset(Offset = "0x54")]
	public float m_StaggerRoll;

	[Range(0f, 1f)]
	[Token(Token = "0x4005C27")]
	[FieldOffset(Offset = "0x58")]
	public float m_StaggerForwardMotionFrac;

	[Range(0f, 1f)]
	[Token(Token = "0x4005C28")]
	[FieldOffset(Offset = "0x5C")]
	public float m_StaggerSideMotionFrac;

	[Range(0f, 1f)]
	[Token(Token = "0x4005C29")]
	[FieldOffset(Offset = "0x60")]
	public float m_StaggerRollMotionFrac;

	[Token(Token = "0x4005C2A")]
	[FieldOffset(Offset = "0x64")]
	public float m_RestingPitchMin;

	[Token(Token = "0x4005C2B")]
	[FieldOffset(Offset = "0x68")]
	public float m_RestingPitchMax;

	[Token(Token = "0x4005C2C")]
	[FieldOffset(Offset = "0x6C")]
	public float m_RestingRollMin;

	[Token(Token = "0x4005C2D")]
	[FieldOffset(Offset = "0x70")]
	public float m_RestingRollMax;

	[Token(Token = "0x4005C2E")]
	[FieldOffset(Offset = "0x74")]
	public float m_MaxVelocityForSpeedFracCalc;

	[Token(Token = "0x4005C2F")]
	[FieldOffset(Offset = "0x78")]
	public float m_StaggerForceScalar;

	[Tooltip("0.92 is the maximum possible motion blur as defined by the Unity script")]
	[Range(0f, 0.92f)]
	[Token(Token = "0x4005C30")]
	[FieldOffset(Offset = "0x7C")]
	public float m_BlurStartVal;

	[Tooltip("0.92 is the maximum possible motion blur as defined by the Unity script")]
	[Range(0f, 0.92f)]
	[Token(Token = "0x4005C31")]
	[FieldOffset(Offset = "0x80")]
	public float m_BlurMaxVal;

	[Header("Audio")]
	[Token(Token = "0x4005C32")]
	[FieldOffset(Offset = "0x88")]
	public string m_PlayStunnedAudioId;

	[Token(Token = "0x4005C33")]
	[FieldOffset(Offset = "0x90")]
	public string m_StopStunnedAudioId;

	[Token(Token = "0x4005C34")]
	[FieldOffset(Offset = "0x98")]
	private Vector2 m_BlurNoisePos;

	[Token(Token = "0x4005C35")]
	[FieldOffset(Offset = "0xA0")]
	private Vector2 m_StaggerNoisePos;

	[Token(Token = "0x4005C36")]
	[FieldOffset(Offset = "0xA8")]
	private float m_BasePitch;

	[Token(Token = "0x4005C37")]
	[FieldOffset(Offset = "0xAC")]
	private float m_BaseRoll;

	[Token(Token = "0x4005C38")]
	[FieldOffset(Offset = "0xB0")]
	private float m_LastBasePitch;

	[Token(Token = "0x4005C39")]
	[FieldOffset(Offset = "0xB4")]
	private float m_LastBaseRoll;

	[Token(Token = "0x4005C3A")]
	[FieldOffset(Offset = "0xB8")]
	private float m_LastFade;

	[Token(Token = "0x4005C3B")]
	[FieldOffset(Offset = "0xBC")]
	private float m_LastBlurAmount;

	[Token(Token = "0x4005C3C")]
	[FieldOffset(Offset = "0xC0")]
	private float m_RestingRollDirection;

	[Token(Token = "0x4005C3D")]
	[FieldOffset(Offset = "0xC4")]
	private float m_StunnedTransitionSeconds;

	[Token(Token = "0x4005C3E")]
	[FieldOffset(Offset = "0xC8")]
	private bool m_IsStunned;

	[Token(Token = "0x4005C3F")]
	[FieldOffset(Offset = "0xCC")]
	private float m_EndStunnedTime;

	[Token(Token = "0x4005C40")]
	[FieldOffset(Offset = "0xD0")]
	private float m_StartTransitionTime;

	[Token(Token = "0x4005C41")]
	[FieldOffset(Offset = "0xD4")]
	private float m_EndInitialTransitionTime;

	[Token(Token = "0x4005C42")]
	[FieldOffset(Offset = "0xD8")]
	private float m_StunnedDurationSeconds;

	[Token(Token = "0x4005C43")]
	[FieldOffset(Offset = "0xE0")]
	private MotionBlur[] m_BlurEffects;

	[Token(Token = "0x4005C44")]
	private static Vector2 m_NoiseStep;

	[Token(Token = "0x6005105")]
	[Address(RVA = "0xE1C010", Offset = "0xE1AE10", Length = "0xBC")]
	public void Start()
	{
	}

	[Token(Token = "0x6005106")]
	[Address(RVA = "0xE1C0D0", Offset = "0xE1AED0", Length = "0x1CE")]
	public void Update()
	{
	}

	[Token(Token = "0x6005107")]
	[Address(RVA = "0xA724D0", Offset = "0xA712D0", Length = "0x8")]
	public bool IsStunned()
	{
		return false;
	}

	[Token(Token = "0x6005108")]
	[Address(RVA = "0xE1C2A0", Offset = "0xE1B0A0", Length = "0x1BA")]
	public void Begin(float stunnedDurationSeconds, float stunnedTransitionSeconds = 1f)
	{
	}

	[Token(Token = "0x6005109")]
	[Address(RVA = "0xE1C460", Offset = "0xE1B260", Length = "0x283")]
	public void End()
	{
	}

	[Token(Token = "0x600510A")]
	[Address(RVA = "0xE1C6F0", Offset = "0xE1B4F0", Length = "0xB49")]
	private void UpdateBlurEffect()
	{
	}

	[Token(Token = "0x600510B")]
	[Address(RVA = "0xE1D240", Offset = "0xE1C040", Length = "0x6EF")]
	private void UpdateLowHealthStagger(float blurFrac, float speedFrac)
	{
	}

	[Token(Token = "0x600510C")]
	[Address(RVA = "0xE1D930", Offset = "0xE1C730", Length = "0x14C")]
	public PlayerStunned()
	{
	}
}
