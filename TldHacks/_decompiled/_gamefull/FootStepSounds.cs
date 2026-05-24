using AK.Wwise;
using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x2000895")]
public class FootStepSounds : MonoBehaviour
{
	[Token(Token = "0x2000896")]
	private enum State
	{
		[Token(Token = "0x400588F")]
		Normal,
		[Token(Token = "0x4005890")]
		Limp
	}

	[Token(Token = "0x400587C")]
	[FieldOffset(Offset = "0x20")]
	public float m_CrouchWalkStepDistance;

	[Token(Token = "0x400587D")]
	[FieldOffset(Offset = "0x24")]
	public float m_WalkStepDistance;

	[Token(Token = "0x400587E")]
	[FieldOffset(Offset = "0x28")]
	public float m_StrideStepDistance;

	[Token(Token = "0x400587F")]
	[FieldOffset(Offset = "0x2C")]
	public float m_SprintStepDistance;

	[Token(Token = "0x4005880")]
	[FieldOffset(Offset = "0x30")]
	public float m_EncumberedMultiplier;

	[Token(Token = "0x4005881")]
	[FieldOffset(Offset = "0x34")]
	public float m_FootPrintSideOffset;

	[Token(Token = "0x4005882")]
	[FieldOffset(Offset = "0x38")]
	public float m_FootPrintBackOffset;

	[Token(Token = "0x4005883")]
	[FieldOffset(Offset = "0x3C")]
	public Vector3 m_DecalProjectorScale;

	[Token(Token = "0x4005884")]
	[FieldOffset(Offset = "0x48")]
	public bool m_SupressFoostepAudio;

	[SerializeField]
	[Token(Token = "0x4005885")]
	[FieldOffset(Offset = "0x50")]
	private RTPC m_PlayerTrueVelocityRTPC;

	[Token(Token = "0x4005886")]
	[FieldOffset(Offset = "0x58")]
	private float m_MovedDistance;

	[Token(Token = "0x4005887")]
	[FieldOffset(Offset = "0x60")]
	private string m_MaterialTagLastFootstep;

	[Token(Token = "0x4005888")]
	[FieldOffset(Offset = "0x68")]
	private bool m_LeftFootStep;

	[Token(Token = "0x4005889")]
	[FieldOffset(Offset = "0x69")]
	private bool m_IgnoreNextFootStep;

	[Token(Token = "0x400588A")]
	[FieldOffset(Offset = "0x6C")]
	private float m_LastPlayerSpeedRTPC;

	[Token(Token = "0x400588B")]
	[FieldOffset(Offset = "0x70")]
	private float m_LastPlayerTrueVelocityRTPC;

	[Token(Token = "0x400588C")]
	[FieldOffset(Offset = "0x74")]
	private float m_LastPlayerInclineRTPC;

	[Token(Token = "0x400588D")]
	[FieldOffset(Offset = "0x78")]
	private float m_NextUpdateTimeforPlayerInclineRTPC;

	[Token(Token = "0x6004E53")]
	[Address(RVA = "0xDA3D70", Offset = "0xDA2B70", Length = "0x14")]
	private void Start()
	{
	}

	[Token(Token = "0x6004E54")]
	[Address(RVA = "0xDA3D90", Offset = "0xDA2B90", Length = "0x108")]
	private void Update()
	{
	}

	[Token(Token = "0x6004E55")]
	[Address(RVA = "0xDA3EA0", Offset = "0xDA2CA0", Length = "0x485")]
	public void AddMoveDistance(float dist, float stepDistanceMultiplier, bool wasStopped, bool isSprinting, bool isCrouched, bool isEncumbered, Vector3 footPos)
	{
	}

	[Token(Token = "0x6004E56")]
	[Address(RVA = "0x6E2FE0", Offset = "0x6E1DE0", Length = "0x5")]
	public string GetMaterialTagForLastFootstep()
	{
		return null;
	}

	[Token(Token = "0x6004E57")]
	[Address(RVA = "0xDA4330", Offset = "0xDA3130", Length = "0x14E")]
	private void PlayWaterSplashVFX(Vector3 footPos)
	{
	}

	[Token(Token = "0x6004E58")]
	[Address(RVA = "0xDA4480", Offset = "0xDA3280", Length = "0x30")]
	public void PlayFootStepSound(Vector3 footPos, string tag)
	{
	}

	[Token(Token = "0x6004E59")]
	[Address(RVA = "0xDA44B0", Offset = "0xDA32B0", Length = "0x1FB")]
	private void PlayFootStepSound(Vector3 footPos, string tag, State state)
	{
	}

	[Token(Token = "0x6004E5A")]
	[Address(RVA = "0xDA46B0", Offset = "0xDA34B0", Length = "0x3B")]
	public void LeaveFootPrint(Vector3 footPos, bool isLeft, bool bothFeet = false, float forceDeepFrac = 0f)
	{
	}

	[Token(Token = "0x6004E5B")]
	[Address(RVA = "0xDA46F0", Offset = "0xDA34F0", Length = "0x5AA")]
	private void MaybeLeaveFootPrint(Vector3 footPos, bool bothFeet = false, float forceDeepFrac = 0f)
	{
	}

	[Token(Token = "0x6004E5C")]
	[Address(RVA = "0xDA4CA0", Offset = "0xDA3AA0", Length = "0x2E5")]
	private void SetPlayerVelocityRTPC()
	{
	}

	[Token(Token = "0x6004E5D")]
	[Address(RVA = "0xDA4F90", Offset = "0xDA3D90", Length = "0x49E")]
	private void SetPlayerInclineRTPC()
	{
	}

	[Token(Token = "0x6004E5E")]
	[Address(RVA = "0x4AF5E0", Offset = "0x4AE3E0", Length = "0x43")]
	public FootStepSounds()
	{
	}
}
