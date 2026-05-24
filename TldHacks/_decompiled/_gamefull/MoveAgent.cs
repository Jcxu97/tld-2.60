using System.Collections.Generic;
using System.Diagnostics;
using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.AI;

[Token(Token = "0x2000176")]
public class MoveAgent : MonoBehaviour
{
	[Token(Token = "0x2000177")]
	public enum PathRequirement
	{
		[Token(Token = "0x4000DA9")]
		PartialPath,
		[Token(Token = "0x4000DAA")]
		FullPath
	}

	[HideInInspector]
	[Token(Token = "0x4000D8B")]
	[FieldOffset(Offset = "0x20")]
	public float m_RotationSpeed;

	[HideInInspector]
	[Token(Token = "0x4000D8C")]
	[FieldOffset(Offset = "0x24")]
	public float m_MaxSpeed;

	[HideInInspector]
	[Token(Token = "0x4000D8D")]
	[FieldOffset(Offset = "0x28")]
	public Transform m_Target;

	[Token(Token = "0x4000D8E")]
	[FieldOffset(Offset = "0x30")]
	public float m_RotationThreshold;

	[Token(Token = "0x4000D8F")]
	[FieldOffset(Offset = "0x34")]
	public float m_SpeedScalar;

	[Token(Token = "0x4000D90")]
	[FieldOffset(Offset = "0x38")]
	public bool m_AnimatedTurns;

	[Token(Token = "0x4000D91")]
	[FieldOffset(Offset = "0x3C")]
	public float m_AnimatedTurnAngleScalar;

	[Token(Token = "0x4000D92")]
	[FieldOffset(Offset = "0x40")]
	public bool m_AnimatedHeadTurns;

	[Tooltip("After warping the move capsule, ensure the visible model is somewhere above that slightly")]
	[Token(Token = "0x4000D93")]
	[FieldOffset(Offset = "0x44")]
	public float m_VerticalAdjustmentOnWarp;

	[Token(Token = "0x4000D94")]
	[FieldOffset(Offset = "0x48")]
	private float m_RotationSpeedScale;

	[Token(Token = "0x4000D95")]
	[FieldOffset(Offset = "0x50")]
	private BaseAi m_BaseAiOwner;

	[Token(Token = "0x4000D96")]
	[FieldOffset(Offset = "0x58")]
	private NavMeshAgent m_Agent;

	[Token(Token = "0x4000D97")]
	[FieldOffset(Offset = "0x60")]
	private Animator m_Animator;

	[Token(Token = "0x4000D98")]
	[FieldOffset(Offset = "0x68")]
	private int m_AnimParameter_Speed;

	[Token(Token = "0x4000D99")]
	[FieldOffset(Offset = "0x6C")]
	private int m_AnimParameter_AiState;

	[Token(Token = "0x4000D9A")]
	[FieldOffset(Offset = "0x70")]
	private int m_IdleState;

	[Token(Token = "0x4000D9B")]
	[FieldOffset(Offset = "0x74")]
	private int m_MoveState;

	[Token(Token = "0x4000D9C")]
	[FieldOffset(Offset = "0x78")]
	private bool m_DestinationReached;

	[Token(Token = "0x4000D9D")]
	[FieldOffset(Offset = "0x7C")]
	private Vector3 m_PreviousPosition;

	[Token(Token = "0x4000D9E")]
	[FieldOffset(Offset = "0x88")]
	private float m_DeltaAngleSmooth;

	[Token(Token = "0x4000D9F")]
	[FieldOffset(Offset = "0x8C")]
	private float m_DeltaHeadAngleSmooth;

	[Token(Token = "0x4000DA0")]
	[FieldOffset(Offset = "0x90")]
	private AiTarget m_OverrideAnimatedTurnTarget;

	[Token(Token = "0x4000DA1")]
	[FieldOffset(Offset = "0x98")]
	public List<RampRange> m_RampRanges;

	[Token(Token = "0x4000DA2")]
	[FieldOffset(Offset = "0xA0")]
	private float m_RampSpeed;

	[Token(Token = "0x4000DA3")]
	[FieldOffset(Offset = "0xA4")]
	private float m_Acceleration;

	[Token(Token = "0x4000DA4")]
	[FieldOffset(Offset = "0xA8")]
	private float m_DefaultAcceleration;

	[Token(Token = "0x4000DA5")]
	[FieldOffset(Offset = "0xAC")]
	private bool m_Enabled;

	[Token(Token = "0x4000DA6")]
	[FieldOffset(Offset = "0xB0")]
	private float m_LastTimeScale;

	[Token(Token = "0x4000DA7")]
	[FieldOffset(Offset = "0xB4")]
	private int m_CurrentAnimState;

	[Token(Token = "0x6000E4B")]
	[Address(RVA = "0x5ECC00", Offset = "0x5EBA00", Length = "0x32D")]
	public void Initialize(BaseAi owner, Vector3 position)
	{
	}

	[Token(Token = "0x6000E4C")]
	[Address(RVA = "0x5ECF30", Offset = "0x5EBD30", Length = "0x8")]
	public bool IsEnabled()
	{
		return false;
	}

	[Token(Token = "0x6000E4D")]
	[Address(RVA = "0x5ECF40", Offset = "0x5EBD40", Length = "0x37")]
	public void Enable(bool enable)
	{
	}

	[Token(Token = "0x6000E4E")]
	[Address(RVA = "0x504310", Offset = "0x503110", Length = "0x6")]
	public float GetMaxSpeed()
	{
		return 0f;
	}

	[Token(Token = "0x6000E4F")]
	[Address(RVA = "0x507A50", Offset = "0x506850", Length = "0x9")]
	public float GetRampSpeed()
	{
		return 0f;
	}

	[Token(Token = "0x6000E50")]
	[Address(RVA = "0x5ECF80", Offset = "0x5EBD80", Length = "0x99")]
	public float GetDesiredSpeed()
	{
		return 0f;
	}

	[Token(Token = "0x6000E51")]
	[Address(RVA = "0x5ED020", Offset = "0x5EBE20", Length = "0xCD")]
	public Vector3 GetVelocity()
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000E52")]
	[Address(RVA = "0x5ED0F0", Offset = "0x5EBEF0", Length = "0x99")]
	public float GetAcceleration()
	{
		return 0f;
	}

	[Token(Token = "0x6000E53")]
	[Address(RVA = "0x5ED190", Offset = "0x5EBF90", Length = "0xCB")]
	public float GetCurrentSpeed()
	{
		return 0f;
	}

	[Token(Token = "0x6000E54")]
	[Address(RVA = "0x5ED260", Offset = "0x5EC060", Length = "0x99")]
	public bool IsOnNavMesh()
	{
		return false;
	}

	[Token(Token = "0x6000E55")]
	[Address(RVA = "0x5ED300", Offset = "0x5EC100", Length = "0xCE")]
	public bool HasPath()
	{
		return false;
	}

	[Token(Token = "0x6000E56")]
	[Address(RVA = "0x5ED3D0", Offset = "0x5EC1D0", Length = "0xCF")]
	public float GetRemainingDistance()
	{
		return 0f;
	}

	[Token(Token = "0x6000E57")]
	[Address(RVA = "0x5ED4A0", Offset = "0x5EC2A0", Length = "0x99")]
	public NavMeshPathStatus GetPathState()
	{
		return default(NavMeshPathStatus);
	}

	[Token(Token = "0x6000E58")]
	[Address(RVA = "0x5ED540", Offset = "0x5EC340", Length = "0xCD")]
	public Vector3 GetDestination()
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000E59")]
	[Address(RVA = "0x5ED610", Offset = "0x5EC410", Length = "0x99")]
	public float GetRadius()
	{
		return 0f;
	}

	[Token(Token = "0x6000E5A")]
	[Address(RVA = "0x5ED6B0", Offset = "0x5EC4B0", Length = "0x48")]
	public void SetAnimState(MoveState moveState, int animState)
	{
	}

	[Token(Token = "0x6000E5B")]
	[Address(RVA = "0x5ED700", Offset = "0x5EC500", Length = "0x1D4")]
	public static bool FindRandomPointWithinRadius(Vector3 center, float radius, out Vector3 result, int areaMask)
	{
		result = default(Vector3);
		return false;
	}

	[Token(Token = "0x6000E5C")]
	[Address(RVA = "0x5ED8E0", Offset = "0x5EC6E0", Length = "0x40D")]
	public bool RotateTowards(Vector3 direction)
	{
		return false;
	}

	[Token(Token = "0x6000E5D")]
	[Address(RVA = "0x5EDCF0", Offset = "0x5ECAF0", Length = "0x3EA")]
	public void PointTowardsDirection(Vector3 dir)
	{
	}

	[Token(Token = "0x6000E5E")]
	[Address(RVA = "0x5EE0E0", Offset = "0x5ECEE0", Length = "0x19F")]
	private void AdjustModelVerticalOnWarp()
	{
	}

	[Token(Token = "0x6000E5F")]
	[Address(RVA = "0x5EE280", Offset = "0x5ED080", Length = "0x4AB")]
	public bool Warp(Vector3 position, float radius, bool findClosestPoint, int areaMask)
	{
		return false;
	}

	[Token(Token = "0x6000E60")]
	[Address(RVA = "0x5EE730", Offset = "0x5ED530", Length = "0x247")]
	public bool CanFindPath(Vector3 destination, PathRequirement minPathRequirement = PathRequirement.PartialPath)
	{
		return false;
	}

	[Token(Token = "0x6000E61")]
	[Address(RVA = "0x5EE980", Offset = "0x5ED780", Length = "0x279")]
	public NavMeshPathStatus CanFindPathStatus(Vector3 destination)
	{
		return default(NavMeshPathStatus);
	}

	[Token(Token = "0x6000E62")]
	[Address(RVA = "0x5EEC00", Offset = "0x5EDA00", Length = "0x4FF")]
	private bool IsDestinationSafe(Vector3 destination)
	{
		return false;
	}

	[Token(Token = "0x6000E63")]
	[Address(RVA = "0x5EF100", Offset = "0x5EDF00", Length = "0x2AF")]
	private bool ProcessDestination(Vector3 destination, bool processImmediate)
	{
		return false;
	}

	[Token(Token = "0x6000E64")]
	[Address(RVA = "0x5EF3B0", Offset = "0x5EE1B0", Length = "0x351")]
	public bool SetDestination(Vector3 destination, float radius, bool findClosestPoint, int areaMask, bool processImmediate, AiTarget overrideTarget)
	{
		return false;
	}

	[Token(Token = "0x6000E65")]
	[Address(RVA = "0x5EF710", Offset = "0x5EE510", Length = "0x1A9")]
	public void SetMoveSpeed(float speed)
	{
	}

	[Token(Token = "0x6000E66")]
	[Address(RVA = "0x5EF8C0", Offset = "0x5EE6C0", Length = "0x44E")]
	public void Stop()
	{
	}

	[Token(Token = "0x6000E67")]
	[Address(RVA = "0x5EFD10", Offset = "0x5EEB10", Length = "0xE")]
	private void SwitchToIdleAnim()
	{
	}

	[Conditional("__DEBUG")]
	[Token(Token = "0x6000E68")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	private void SetDebugSphere(Vector3 position, float radius, Color color)
	{
	}

	[Token(Token = "0x6000E69")]
	[Address(RVA = "0x5EFD20", Offset = "0x5EEB20", Length = "0x7")]
	public int GetAnimState()
	{
		return 0;
	}

	[Token(Token = "0x6000E6A")]
	[Address(RVA = "0x502700", Offset = "0x501500", Length = "0x5")]
	public bool HasReachedDestination()
	{
		return false;
	}

	[Token(Token = "0x6000E6B")]
	[Address(RVA = "0x5EFD30", Offset = "0x5EEB30", Length = "0x11C")]
	private void SetAnimationParameters(int animState, float speed)
	{
	}

	[Token(Token = "0x6000E6C")]
	[Address(RVA = "0x5EFE50", Offset = "0x5EEC50", Length = "0x20C")]
	private void UpdateAnimatedTurns()
	{
	}

	[Token(Token = "0x6000E6D")]
	[Address(RVA = "0x5F0060", Offset = "0x5EEE60", Length = "0x3D9")]
	private void UpdateAnimatedHeadTurns()
	{
	}

	[Token(Token = "0x6000E6E")]
	[Address(RVA = "0x5F0440", Offset = "0x5EF240", Length = "0xC31")]
	private void Update()
	{
	}

	[Token(Token = "0x6000E6F")]
	[Address(RVA = "0x5F1080", Offset = "0x5EFE80", Length = "0xD4")]
	public void ResetPreviousPosition()
	{
	}

	[Token(Token = "0x6000E70")]
	[Address(RVA = "0x5F1160", Offset = "0x5EFF60", Length = "0x8B")]
	public MoveAgent()
	{
	}
}
