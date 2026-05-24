using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x20008AD")]
public class PlayerCameraAnim : MonoBehaviour
{
	[Token(Token = "0x20008AE")]
	public enum CameraAnimationState
	{
		[Token(Token = "0x4005A3F")]
		Idle,
		[Token(Token = "0x4005A40")]
		Animating,
		[Token(Token = "0x4005A41")]
		Teleporting
	}

	[Token(Token = "0x4005A2B")]
	[FieldOffset(Offset = "0x20")]
	public bool m_DebugOverrideCameraPosition;

	[Token(Token = "0x4005A2C")]
	[FieldOffset(Offset = "0x24")]
	public Vector3 m_DebugCameraPositionOverride;

	[Token(Token = "0x4005A2D")]
	[FieldOffset(Offset = "0x30")]
	public bool m_DebugDisableRotation;

	[Token(Token = "0x4005A2E")]
	[FieldOffset(Offset = "0x38")]
	public Animator m_Animator;

	[Token(Token = "0x4005A2F")]
	[FieldOffset(Offset = "0x40")]
	private GameObject m_CameraBone;

	[Token(Token = "0x4005A30")]
	[FieldOffset(Offset = "0x48")]
	private int m_MainLayer_AnimState_Idle;

	[Token(Token = "0x4005A31")]
	[FieldOffset(Offset = "0x4C")]
	private int m_HipLayer_AnimState_Idle;

	[Token(Token = "0x4005A32")]
	[FieldOffset(Offset = "0x50")]
	private vp_FPSCamera m_FpsCamera;

	[Token(Token = "0x4005A33")]
	[FieldOffset(Offset = "0x58")]
	private Vector3 m_LastPositionOffset;

	[Token(Token = "0x4005A34")]
	[FieldOffset(Offset = "0x64")]
	private Vector2 m_SavedCameraAngles;

	[Token(Token = "0x4005A35")]
	[FieldOffset(Offset = "0x6C")]
	private Quaternion m_SavedCameraRotaiton;

	[Token(Token = "0x4005A36")]
	[FieldOffset(Offset = "0x7C")]
	private bool m_SavedCameraTransform;

	[Token(Token = "0x4005A37")]
	[FieldOffset(Offset = "0x80")]
	private Vector3 m_LastCameraPosition;

	[Token(Token = "0x4005A38")]
	[FieldOffset(Offset = "0x8C")]
	private Quaternion m_LastCameraRotation;

	[Token(Token = "0x4005A39")]
	[FieldOffset(Offset = "0x9C")]
	private Vector3 m_TeleportPosition;

	[Token(Token = "0x4005A3A")]
	[FieldOffset(Offset = "0xA8")]
	private Quaternion m_TeleportRotation;

	[Token(Token = "0x4005A3B")]
	[FieldOffset(Offset = "0xB8")]
	private float m_BlendTime;

	[Token(Token = "0x4005A3C")]
	[FieldOffset(Offset = "0xBC")]
	private float m_BlendTimeRemaining;

	[Token(Token = "0x4005A3D")]
	[FieldOffset(Offset = "0xC0")]
	private CameraAnimationState m_State;

	[Token(Token = "0x6004FDB")]
	[Address(RVA = "0xDD3670", Offset = "0xDD2470", Length = "0x1AE")]
	public void Start()
	{
	}

	[Token(Token = "0x6004FDC")]
	[Address(RVA = "0xDD3820", Offset = "0xDD2620", Length = "0x5F")]
	public void Update()
	{
	}

	[Token(Token = "0x6004FDD")]
	[Address(RVA = "0xDD3880", Offset = "0xDD2680", Length = "0xDD")]
	private bool PlayingIdle()
	{
		return false;
	}

	[Token(Token = "0x6004FDE")]
	[Address(RVA = "0xDD3960", Offset = "0xDD2760", Length = "0x3A")]
	public bool AnimIsPlaying(int id, int layerIndex)
	{
		return false;
	}

	[Token(Token = "0x6004FDF")]
	[Address(RVA = "0xDD39A0", Offset = "0xDD27A0", Length = "0x6FE")]
	public void UpdateMainCamera()
	{
	}

	[Token(Token = "0x6004FE0")]
	[Address(RVA = "0xDD40A0", Offset = "0xDD2EA0", Length = "0x1DE")]
	public void RestoreMainCameraPos()
	{
	}

	[Token(Token = "0x6004FE1")]
	[Address(RVA = "0xDD4280", Offset = "0xDD3080", Length = "0x7")]
	public CameraAnimationState GetState()
	{
		return default(CameraAnimationState);
	}

	[Token(Token = "0x6004FE2")]
	[Address(RVA = "0xDD4290", Offset = "0xDD3090", Length = "0x12A")]
	public void TeleportPlayerToCameraNow(float blendTime)
	{
	}

	[Token(Token = "0x6004FE3")]
	[Address(RVA = "0xDD43C0", Offset = "0xDD31C0", Length = "0x374")]
	private void UpdateTeleport()
	{
	}

	[Token(Token = "0x6004FE4")]
	[Address(RVA = "0x4AF5E0", Offset = "0x4AE3E0", Length = "0x43")]
	public PlayerCameraAnim()
	{
	}
}
