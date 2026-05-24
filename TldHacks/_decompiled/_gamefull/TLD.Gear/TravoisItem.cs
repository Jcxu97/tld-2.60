using Cpp2ILInjected;
using TLD.BigCarry;
using UnityEngine;

namespace TLD.Gear;

[Token(Token = "0x2001436")]
public class TravoisItem : MonoBehaviour
{
	[SerializeField]
	[Token(Token = "0x4009358")]
	[FieldOffset(Offset = "0x20")]
	private AssetReferenceBigCarryItem m_TravoisReference;

	[Header("Drop")]
	[SerializeField]
	[Token(Token = "0x4009359")]
	[FieldOffset(Offset = "0x28")]
	private TravoisDropSettings m_TravoisDropSettings;

	[SerializeField]
	[Token(Token = "0x400935A")]
	[FieldOffset(Offset = "0x30")]
	private float m_DropBoxHeight;

	[SerializeField]
	[Token(Token = "0x400935B")]
	[FieldOffset(Offset = "0x34")]
	private float m_DropSideOffset;

	[SerializeField]
	[Token(Token = "0x400935C")]
	[FieldOffset(Offset = "0x38")]
	private float m_DropGroundCheckLength;

	[Token(Token = "0x400935D")]
	[FieldOffset(Offset = "0x40")]
	private readonly Collider[] m_DropColliders;

	[Token(Token = "0x400935F")]
	[FieldOffset(Offset = "0x50")]
	private Vector3 m_LastDropPlayerPosition;

	[Token(Token = "0x4009360")]
	[FieldOffset(Offset = "0x5C")]
	private Quaternion m_LastDropPlayerRotation;

	[Token(Token = "0x4009361")]
	[FieldOffset(Offset = "0x6C")]
	private Vector3 m_LastValidDropPosition;

	[Token(Token = "0x4009362")]
	[FieldOffset(Offset = "0x78")]
	private Quaternion m_LastValidDropRotation;

	[Token(Token = "0x17000B2A")]
	[field: Token(Token = "0x400935E")]
	[field: FieldOffset(Offset = "0x48")]
	public TravoisBigCarryItem BigCarryItem
	{
		[Token(Token = "0x6008106")]
		[Address(RVA = "0x4B2FE0", Offset = "0x4B1DE0", Length = "0x5")]
		get;
		[Token(Token = "0x6008107")]
		[Address(RVA = "0x4D0B60", Offset = "0x4CF960", Length = "0x52")]
		set;
	}

	[Token(Token = "0x6008108")]
	[Address(RVA = "0x12138F0", Offset = "0x12126F0", Length = "0x578")]
	public bool CanDropTravois()
	{
		return false;
	}

	[Token(Token = "0x6008109")]
	[Address(RVA = "0x1213E70", Offset = "0x1212C70", Length = "0x150")]
	private bool IsIndoors()
	{
		return false;
	}

	[Token(Token = "0x600810A")]
	[Address(RVA = "0x1213FD0", Offset = "0x1212DD0", Length = "0x50A")]
	private bool TryFindValidTravoisDropPosition(Transform playerTransform)
	{
		return false;
	}

	[Token(Token = "0x600810B")]
	[Address(RVA = "0x12144E0", Offset = "0x12132E0", Length = "0x7F4")]
	private bool CanDropTravoisAtPosition(Vector3 desiredPosition, Quaternion desiredRotation)
	{
		return false;
	}

	[Token(Token = "0x600810C")]
	[Address(RVA = "0x1214CE0", Offset = "0x1213AE0", Length = "0x327")]
	public void DropTravois()
	{
	}

	[Token(Token = "0x600810D")]
	[Address(RVA = "0x1215010", Offset = "0x1213E10", Length = "0xC2")]
	public TravoisItem()
	{
	}
}
