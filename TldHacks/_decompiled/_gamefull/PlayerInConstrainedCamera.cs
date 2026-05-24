using System;
using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x20008B8")]
public class PlayerInConstrainedCamera : MonoBehaviour
{
	[Serializable]
	[Token(Token = "0x20008B9")]
	public class ConstrainedCameraInfo
	{
		[Token(Token = "0x4005B0B")]
		[FieldOffset(Offset = "0x10")]
		public float m_TransitionTime;

		[Token(Token = "0x4005B0C")]
		[FieldOffset(Offset = "0x18")]
		public Transform m_PlayerEntryPoint;

		[Token(Token = "0x4005B0D")]
		[FieldOffset(Offset = "0x20")]
		public bool m_PlayerExitPointIsEnterPoint;

		[Token(Token = "0x4005B0E")]
		[FieldOffset(Offset = "0x28")]
		public Transform m_PlayerExitPoint;

		[Token(Token = "0x4005B0F")]
		[FieldOffset(Offset = "0x30")]
		public float m_EnterCameraPitch;

		[Token(Token = "0x4005B10")]
		[FieldOffset(Offset = "0x34")]
		public float m_ExitCameraPitch;

		[Token(Token = "0x600502B")]
		[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
		public ConstrainedCameraInfo()
		{
		}
	}

	[Token(Token = "0x20008BA")]
	public enum ConstrainedState
	{
		[Token(Token = "0x4005B12")]
		Unconstrained,
		[Token(Token = "0x4005B13")]
		TransitionIn,
		[Token(Token = "0x4005B14")]
		Constrained,
		[Token(Token = "0x4005B15")]
		TransitionOut
	}

	[Token(Token = "0x4005AF5")]
	[FieldOffset(Offset = "0x20")]
	public bool m_UseFOV;

	[Token(Token = "0x4005AF6")]
	[FieldOffset(Offset = "0x24")]
	public float m_FOV;

	[Token(Token = "0x4005AF7")]
	[FieldOffset(Offset = "0x28")]
	public Vector2 m_PitchLimitDegrees;

	[Token(Token = "0x4005AF8")]
	[FieldOffset(Offset = "0x30")]
	public Vector2 m_YawLimitDegrees;

	[Token(Token = "0x4005AF9")]
	[FieldOffset(Offset = "0x38")]
	public float m_FadeOutSeconds;

	[Token(Token = "0x4005AFA")]
	[FieldOffset(Offset = "0x3C")]
	public float m_FadeInSeconds;

	[Token(Token = "0x4005AFB")]
	[FieldOffset(Offset = "0x40")]
	private float m_StartCameraFOV;

	[Token(Token = "0x4005AFC")]
	[FieldOffset(Offset = "0x44")]
	private Vector2 m_StartPitchLimit;

	[Token(Token = "0x4005AFD")]
	[FieldOffset(Offset = "0x4C")]
	private Vector2 m_StartYawLimit;

	[Token(Token = "0x4005AFE")]
	[FieldOffset(Offset = "0x54")]
	public float m_PanViewSeconds;

	[Range(1f, 5f)]
	[Token(Token = "0x4005AFF")]
	[FieldOffset(Offset = "0x58")]
	public int m_EasingLevel;

	[Token(Token = "0x4005B00")]
	[FieldOffset(Offset = "0x5C")]
	private Vector3 m_TargetPos;

	[Token(Token = "0x4005B01")]
	[FieldOffset(Offset = "0x68")]
	private Quaternion m_TargetRot;

	[Token(Token = "0x4005B02")]
	[FieldOffset(Offset = "0x78")]
	private Vector3 m_LerpStartPos;

	[Token(Token = "0x4005B03")]
	[FieldOffset(Offset = "0x84")]
	private Quaternion m_LerpStartRot;

	[Token(Token = "0x4005B04")]
	[FieldOffset(Offset = "0x94")]
	private float m_PanStartTime;

	[Token(Token = "0x4005B05")]
	[FieldOffset(Offset = "0x98")]
	private float m_LerpStartCameraPitch;

	[Token(Token = "0x4005B06")]
	[FieldOffset(Offset = "0x9C")]
	private float m_TargetCameraPitch;

	[Token(Token = "0x4005B07")]
	[FieldOffset(Offset = "0xA0")]
	private float m_LerpStartCameraYaw;

	[Token(Token = "0x4005B08")]
	[FieldOffset(Offset = "0xA4")]
	private float m_TargetCameraYaw;

	[Token(Token = "0x4005B09")]
	[FieldOffset(Offset = "0xA8")]
	private ConstrainedCameraInfo m_ConstrainedCameraInfo;

	[Token(Token = "0x4005B0A")]
	[FieldOffset(Offset = "0xB0")]
	public ConstrainedState m_ConstrainedState;

	[Token(Token = "0x6005020")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	private void Start()
	{
	}

	[Token(Token = "0x6005021")]
	[Address(RVA = "0xDFEBE0", Offset = "0xDFD9E0", Length = "0x67")]
	public void Update()
	{
	}

	[Token(Token = "0x6005022")]
	[Address(RVA = "0xDFEC50", Offset = "0xDFDA50", Length = "0x4F5")]
	public void Enter(ConstrainedCameraInfo constrainedCameraInfo)
	{
	}

	[Token(Token = "0x6005023")]
	[Address(RVA = "0xDFF150", Offset = "0xDFDF50", Length = "0x179")]
	public void Exit()
	{
	}

	[Token(Token = "0x6005024")]
	[Address(RVA = "0x5DEE90", Offset = "0x5DDC90", Length = "0x7")]
	public ConstrainedState GetConstrainedState()
	{
		return default(ConstrainedState);
	}

	[Token(Token = "0x6005025")]
	[Address(RVA = "0xDFF2D0", Offset = "0xDFE0D0", Length = "0x13")]
	public bool InTransition()
	{
		return false;
	}

	[Token(Token = "0x6005026")]
	[Address(RVA = "0xDFF2F0", Offset = "0xDFE0F0", Length = "0x3A4")]
	private void PanToLocation(Transform target)
	{
	}

	[Token(Token = "0x6005027")]
	[Address(RVA = "0xDFF6A0", Offset = "0xDFE4A0", Length = "0x56B")]
	private bool TransitionCamera()
	{
		return false;
	}

	[Token(Token = "0x6005028")]
	[Address(RVA = "0xDFFC10", Offset = "0xDFEA10", Length = "0x708")]
	private void OnEnterConstrainedState()
	{
	}

	[Token(Token = "0x6005029")]
	[Address(RVA = "0xE00320", Offset = "0xDFF120", Length = "0x49B")]
	private void OnExitConstrainedState()
	{
	}

	[Token(Token = "0x600502A")]
	[Address(RVA = "0xE007C0", Offset = "0xDFF5C0", Length = "0x51")]
	public PlayerInConstrainedCamera()
	{
	}
}
