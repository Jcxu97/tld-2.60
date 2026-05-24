using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x20009D2")]
public class RescueZone : MonoBehaviour
{
	[Token(Token = "0x40063B8")]
	[FieldOffset(Offset = "0x20")]
	public float m_ZoneRadius;

	[Token(Token = "0x40063B9")]
	[FieldOffset(Offset = "0x24")]
	public float m_DelayReplyMinSeconds;

	[Token(Token = "0x40063BA")]
	[FieldOffset(Offset = "0x28")]
	public float m_DelayReplyMaxSeconds;

	[Token(Token = "0x40063BB")]
	[FieldOffset(Offset = "0x30")]
	public GameObject m_FlareGunRound;

	[Token(Token = "0x40063BC")]
	[FieldOffset(Offset = "0x38")]
	public GameObject m_RescueTarget;

	[Token(Token = "0x40063BD")]
	[FieldOffset(Offset = "0x40")]
	public bool m_AutoReplyShot;

	[Token(Token = "0x40063BE")]
	[FieldOffset(Offset = "0x44")]
	public float m_TargetFoundRadius;

	[Token(Token = "0x40063BF")]
	[FieldOffset(Offset = "0x48")]
	public float m_NoReply_Radius;

	[Header("Player shot detection")]
	[Token(Token = "0x40063C0")]
	[FieldOffset(Offset = "0x4C")]
	public float m_MinAltitudeSight;

	[Header("Reply shot")]
	[Token(Token = "0x40063C1")]
	[FieldOffset(Offset = "0x50")]
	public float m_ShotHeightStartMeters;

	[Token(Token = "0x40063C2")]
	[FieldOffset(Offset = "0x54")]
	public float m_MaxShotPitchBiasDegrees;

	[Token(Token = "0x40063C3")]
	[FieldOffset(Offset = "0x58")]
	public float m_MinShotYawBiasDegrees;

	[Token(Token = "0x40063C4")]
	[FieldOffset(Offset = "0x5C")]
	public float m_MaxShotYawBiasDegrees;

	[Token(Token = "0x40063C5")]
	[FieldOffset(Offset = "0x60")]
	private bool m_HasFoundTarget;

	[Token(Token = "0x40063C6")]
	[FieldOffset(Offset = "0x64")]
	private float m_NextReplyTime;

	[Token(Token = "0x40063C7")]
	private static List<RescueZone> s_RescueZoneList;

	[Token(Token = "0x40063C8")]
	[FieldOffset(Offset = "0x68")]
	private GameObject m_TrackedProjectile;

	[Token(Token = "0x40063C9")]
	[FieldOffset(Offset = "0x70")]
	private float m_CurrentProjectileAltitude;

	[Token(Token = "0x40063CA")]
	[FieldOffset(Offset = "0x74")]
	private float m_ReplyShotTimeHours;

	[Token(Token = "0x40063CB")]
	[FieldOffset(Offset = "0x78")]
	private Rigidbody m_TrackedProjectileRigidBody;

	[Token(Token = "0x40063CC")]
	[FieldOffset(Offset = "0x80")]
	private Vector3 m_ProjectileInitialPosition;

	[Token(Token = "0x40063CD")]
	[FieldOffset(Offset = "0x8C")]
	private bool m_ReplyShotRequested;

	[Token(Token = "0x40063CE")]
	[FieldOffset(Offset = "0x8D")]
	private bool m_HasPlayerEntered;

	[Token(Token = "0x40063CF")]
	[FieldOffset(Offset = "0x8E")]
	private bool m_HasSpottedProjectile;

	[Token(Token = "0x60056B3")]
	[Address(RVA = "0xEBE290", Offset = "0xEBD090", Length = "0x13C")]
	public void Awake()
	{
	}

	[Token(Token = "0x60056B4")]
	[Address(RVA = "0xEBE3D0", Offset = "0xEBD1D0", Length = "0x105")]
	public void OnDestroy()
	{
	}

	[Token(Token = "0x60056B5")]
	[Address(RVA = "0xEBE4E0", Offset = "0xEBD2E0", Length = "0x136")]
	public void Update()
	{
	}

	[Token(Token = "0x60056B6")]
	[Address(RVA = "0xEBE620", Offset = "0xEBD420", Length = "0x14C")]
	public void FireFlareGun(Vector3 targetPosition)
	{
	}

	[Token(Token = "0x60056B7")]
	[Address(RVA = "0xEBE770", Offset = "0xEBD570", Length = "0x682")]
	private Quaternion GetShotOrientation(Vector3 targetPosition)
	{
		return default(Quaternion);
	}

	[Token(Token = "0x60056B8")]
	[Address(RVA = "0xEBEE00", Offset = "0xEBDC00", Length = "0xD1")]
	private void UpdateReplyShot()
	{
	}

	[Token(Token = "0x60056B9")]
	[Address(RVA = "0xEBEEE0", Offset = "0xEBDCE0", Length = "0x615")]
	private void UpdateTrackProjectile()
	{
	}

	[Token(Token = "0x60056BA")]
	[Address(RVA = "0xEBF500", Offset = "0xEBE300", Length = "0x105")]
	private void HandleProjectileSpotted()
	{
	}

	[Token(Token = "0x60056BB")]
	[Address(RVA = "0xEBF610", Offset = "0xEBE410", Length = "0xE5")]
	private void RequestReplyShot()
	{
	}

	[Token(Token = "0x60056BC")]
	[Address(RVA = "0xEBF700", Offset = "0xEBE500", Length = "0x2F5")]
	private void UpdatePlayerCheck()
	{
	}

	[Token(Token = "0x60056BD")]
	[Address(RVA = "0xEBFA00", Offset = "0xEBE800", Length = "0x239")]
	private Vector3 GetRescueTargetPosition()
	{
		return default(Vector3);
	}

	[Token(Token = "0x60056BE")]
	[Address(RVA = "0xEBFC40", Offset = "0xEBEA40", Length = "0x2AB")]
	private bool CanReplyToPlayerShot()
	{
		return false;
	}

	[Token(Token = "0x60056BF")]
	[Address(RVA = "0xEBFEF0", Offset = "0xEBECF0", Length = "0x2A4")]
	private void StartTrackingProjectile(GameObject projectile)
	{
	}

	[Token(Token = "0x60056C0")]
	[Address(RVA = "0xEC01A0", Offset = "0xEBEFA0", Length = "0x3A3")]
	private static RescueZone GetActiveRescueZone()
	{
		return null;
	}

	[Token(Token = "0x60056C1")]
	[Address(RVA = "0xEC0550", Offset = "0xEBF350", Length = "0x112")]
	private static void OnFlareGunShot(GameObject projectile)
	{
	}

	[Token(Token = "0x60056C2")]
	[Address(RVA = "0xEC0670", Offset = "0xEBF470", Length = "0x8D")]
	public RescueZone()
	{
	}
}
