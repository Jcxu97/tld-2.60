using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x2000409")]
public class TravoisTrailManager : MonoBehaviour
{
	[Token(Token = "0x40024A7")]
	[FieldOffset(Offset = "0x20")]
	public float m_RayCastHitDepth;

	[Token(Token = "0x40024A8")]
	[FieldOffset(Offset = "0x24")]
	public float m_RayCastVerticalOffset;

	[Token(Token = "0x40024A9")]
	[FieldOffset(Offset = "0x28")]
	public int m_MaxRaycastHits;

	[Token(Token = "0x40024AA")]
	[FieldOffset(Offset = "0x30")]
	private Transform m_Player;

	[Token(Token = "0x40024AB")]
	[FieldOffset(Offset = "0x38")]
	private Vector3 m_PrevPlayerPos;

	[Token(Token = "0x40024AC")]
	[FieldOffset(Offset = "0x48")]
	private RaycastHit[] m_SnowRaycastHits;

	[Token(Token = "0x6001EB9")]
	[Address(RVA = "0x7CA950", Offset = "0x7C9750", Length = "0x129")]
	private void Start()
	{
	}

	[Token(Token = "0x6001EBA")]
	[Address(RVA = "0x7CAA80", Offset = "0x7C9880", Length = "0x574")]
	private void Update()
	{
	}

	[Token(Token = "0x6001EBB")]
	[Address(RVA = "0x7CB000", Offset = "0x7C9E00", Length = "0x105")]
	public bool IsCarryingTravois()
	{
		return false;
	}

	[Token(Token = "0x6001EBC")]
	[Address(RVA = "0x7CB110", Offset = "0x7C9F10", Length = "0x21F")]
	public bool IsOnSnow(Vector3 worldPosition)
	{
		return false;
	}

	[Token(Token = "0x6001EBD")]
	[Address(RVA = "0x7CB330", Offset = "0x7CA130", Length = "0x58")]
	public TravoisTrailManager()
	{
	}
}
