using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x2000444")]
public class SpotlightAimer : MonoBehaviour
{
	[SerializeField]
	[Token(Token = "0x4002657")]
	[FieldOffset(Offset = "0x20")]
	private bool m_AimOnStart;

	[SerializeField]
	[Token(Token = "0x4002658")]
	[FieldOffset(Offset = "0x28")]
	private Transform m_AimTarget;

	[SerializeField]
	[Token(Token = "0x4002659")]
	[FieldOffset(Offset = "0x30")]
	private Transform m_PitchPivotControl;

	[SerializeField]
	[Token(Token = "0x400265A")]
	[FieldOffset(Offset = "0x38")]
	private Transform m_YawPivotControl;

	[SerializeField]
	[Token(Token = "0x400265B")]
	[FieldOffset(Offset = "0x40")]
	private Transform m_OverheadLight;

	[SerializeField]
	[Token(Token = "0x400265C")]
	[FieldOffset(Offset = "0x48")]
	private float m_OverheadLightDistance;

	[Token(Token = "0x6002011")]
	[Address(RVA = "0x7EA360", Offset = "0x7E9160", Length = "0x221")]
	public Vector3 GetLightSourceOrigin()
	{
		return default(Vector3);
	}

	[Token(Token = "0x6002012")]
	[Address(RVA = "0x7EA590", Offset = "0x7E9390", Length = "0x5A6")]
	public void AimAtPosition(Vector3 aimPosition)
	{
	}

	[Token(Token = "0x6002013")]
	[Address(RVA = "0x7EAB40", Offset = "0x7E9940", Length = "0x1A2")]
	private void Start()
	{
	}

	[Token(Token = "0x6002014")]
	[Address(RVA = "0x7EACF0", Offset = "0x7E9AF0", Length = "0x226")]
	private void OnDrawGizmos()
	{
	}

	[Token(Token = "0x6002015")]
	[Address(RVA = "0x4AF5E0", Offset = "0x4AE3E0", Length = "0x43")]
	public SpotlightAimer()
	{
	}
}
