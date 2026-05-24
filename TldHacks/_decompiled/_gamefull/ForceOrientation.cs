using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x2000897")]
public class ForceOrientation : MonoBehaviour
{
	[Token(Token = "0x4005891")]
	[FieldOffset(Offset = "0x20")]
	public bool m_ResetLocalRotationOnDisable;

	[Token(Token = "0x4005892")]
	[FieldOffset(Offset = "0x21")]
	public bool m_AlwaysOrientToPlayer;

	[Token(Token = "0x4005893")]
	[FieldOffset(Offset = "0x28")]
	private Camera m_WeaponCamera;

	[Token(Token = "0x4005894")]
	[FieldOffset(Offset = "0x30")]
	public Vector3 m_RotationOffset;

	[Token(Token = "0x6004E5F")]
	[Address(RVA = "0xDA5430", Offset = "0xDA4230", Length = "0x97")]
	public void Start()
	{
	}

	[Token(Token = "0x6004E60")]
	[Address(RVA = "0xDA54D0", Offset = "0xDA42D0", Length = "0x1CA")]
	public void OnDisable()
	{
	}

	[Token(Token = "0x6004E61")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public void FixedUpdate()
	{
	}

	[Token(Token = "0x6004E62")]
	[Address(RVA = "0xDA56A0", Offset = "0xDA44A0", Length = "0x32F")]
	public void Update()
	{
	}

	[Token(Token = "0x6004E63")]
	[Address(RVA = "0x4AF5E0", Offset = "0x4AE3E0", Length = "0x43")]
	public ForceOrientation()
	{
	}
}
