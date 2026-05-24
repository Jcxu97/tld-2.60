using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x20004DD")]
public class StoneItem : MonoBehaviour
{
	[Header("Audio")]
	[Token(Token = "0x4002C64")]
	[FieldOffset(Offset = "0x20")]
	public string m_CollideAudio;

	[Range(0f, 40f)]
	[Token(Token = "0x4002C65")]
	[FieldOffset(Offset = "0x28")]
	public float m_AudioVelocityThreshold;

	[Header("Physics")]
	[Token(Token = "0x4002C66")]
	[FieldOffset(Offset = "0x2C")]
	public float m_ThrowForce;

	[Token(Token = "0x4002C67")]
	[FieldOffset(Offset = "0x30")]
	public float m_ThrowTorque;

	[Token(Token = "0x4002C68")]
	[FieldOffset(Offset = "0x34")]
	public Vector3 m_AdditionalGravity;

	[Range(0f, 30f)]
	[Token(Token = "0x4002C69")]
	[FieldOffset(Offset = "0x40")]
	public float m_ThrowSpeedThreshold;

	[Header("Collision")]
	[Range(0f, 1f)]
	[Token(Token = "0x4002C6A")]
	[FieldOffset(Offset = "0x44")]
	public float m_CollisionDamping;

	[Range(1f, 4f)]
	[Token(Token = "0x4002C6B")]
	[FieldOffset(Offset = "0x48")]
	public float m_ColliderScaleWhenThrown;

	[HideInInspector]
	[Token(Token = "0x4002C6C")]
	[FieldOffset(Offset = "0x4C")]
	public bool m_CanThrow;

	[Token(Token = "0x4002C6D")]
	[FieldOffset(Offset = "0x50")]
	private GearItem m_GearItem;

	[Token(Token = "0x4002C6E")]
	[FieldOffset(Offset = "0x58")]
	private Rigidbody m_RigidBody;

	[Token(Token = "0x4002C6F")]
	[FieldOffset(Offset = "0x60")]
	private BoxCollider m_Collider;

	[Token(Token = "0x4002C70")]
	[FieldOffset(Offset = "0x68")]
	private bool m_Thrown;

	[Token(Token = "0x4002C71")]
	[FieldOffset(Offset = "0x6C")]
	private Vector3 m_DefaultColliderSize;

	[Token(Token = "0x6002500")]
	[Address(RVA = "0x871D40", Offset = "0x870B40", Length = "0x287")]
	private void Awake()
	{
	}

	[Token(Token = "0x6002501")]
	[Address(RVA = "0x871FD0", Offset = "0x870DD0", Length = "0x10B")]
	public void Update()
	{
	}

	[Token(Token = "0x6002502")]
	[Address(RVA = "0x8720E0", Offset = "0x870EE0", Length = "0x247")]
	public void FixedUpdate()
	{
	}

	[Token(Token = "0x6002503")]
	[Address(RVA = "0x872330", Offset = "0x871130", Length = "0x277")]
	private void PlayImpactEffects(string surfaceTag, Vector3 collisionPoint, Vector3 normal)
	{
	}

	[Token(Token = "0x6002504")]
	[Address(RVA = "0x8725B0", Offset = "0x8713B0", Length = "0x3F9")]
	public void OnCollisionEnter(Collision collisionInfo)
	{
	}

	[Token(Token = "0x6002505")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public void PrepareForThrow()
	{
	}

	[Token(Token = "0x6002506")]
	[Address(RVA = "0x8729B0", Offset = "0x8717B0", Length = "0x18E")]
	public void PickedUp()
	{
	}

	[Token(Token = "0x6002507")]
	[Address(RVA = "0x872B40", Offset = "0x871940", Length = "0xCE")]
	public void Throw()
	{
	}

	[Token(Token = "0x6002508")]
	[Address(RVA = "0x872C10", Offset = "0x871A10", Length = "0xBD")]
	public void ZoomStart()
	{
	}

	[Token(Token = "0x6002509")]
	[Address(RVA = "0x872CD0", Offset = "0x871AD0", Length = "0xD4")]
	public void ZoomEnd()
	{
	}

	[Token(Token = "0x600250A")]
	[Address(RVA = "0x872DB0", Offset = "0x871BB0", Length = "0x1A8")]
	public void SetThrown(bool thrown)
	{
	}

	[Token(Token = "0x600250B")]
	[Address(RVA = "0x4C3B90", Offset = "0x4C2990", Length = "0x5")]
	public bool IsThrown()
	{
		return false;
	}

	[Token(Token = "0x600250C")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	private void OnAiming()
	{
	}

	[Token(Token = "0x600250D")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	private void OnAimingCancelled()
	{
	}

	[Token(Token = "0x600250E")]
	[Address(RVA = "0x872F60", Offset = "0x871D60", Length = "0x2BC")]
	private void OnThrowComplete()
	{
	}

	[Token(Token = "0x600250F")]
	[Address(RVA = "0x873220", Offset = "0x872020", Length = "0xA4")]
	public StoneItem()
	{
	}
}
