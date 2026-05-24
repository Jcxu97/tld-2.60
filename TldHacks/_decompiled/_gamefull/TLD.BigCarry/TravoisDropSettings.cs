using Cpp2ILInjected;
using UnityEngine;

namespace TLD.BigCarry;

[Token(Token = "0x20014E1")]
public class TravoisDropSettings : ScriptableObject
{
	[SerializeField]
	[Token(Token = "0x40096F7")]
	[FieldOffset(Offset = "0x18")]
	private float m_CarryOffset;

	[Header("Travois Size")]
	[SerializeField]
	[Token(Token = "0x40096F8")]
	[FieldOffset(Offset = "0x1C")]
	private float m_TravoisWidth;

	[SerializeField]
	[Token(Token = "0x40096F9")]
	[FieldOffset(Offset = "0x20")]
	private float m_TravoisLength;

	[Header("Physics")]
	[SerializeField]
	[Token(Token = "0x40096FA")]
	[FieldOffset(Offset = "0x24")]
	private float m_DropDistanceFudge;

	[SerializeField]
	[Token(Token = "0x40096FB")]
	[FieldOffset(Offset = "0x28")]
	private float m_DropMaxLength;

	[SerializeField]
	[Token(Token = "0x40096FC")]
	[FieldOffset(Offset = "0x2C")]
	private float m_TestCapsuleRadius;

	[Token(Token = "0x17000B72")]
	public float Width
	{
		[Token(Token = "0x60083F6")]
		[Address(RVA = "0x5042D0", Offset = "0x5030D0", Length = "0x6")]
		get
		{
			return 0f;
		}
	}

	[Token(Token = "0x17000B73")]
	public float Length
	{
		[Token(Token = "0x60083F7")]
		[Address(RVA = "0x5042F0", Offset = "0x5030F0", Length = "0x6")]
		get
		{
			return 0f;
		}
	}

	[Token(Token = "0x17000B74")]
	public float CarryOffset
	{
		[Token(Token = "0x60083F8")]
		[Address(RVA = "0x4A7A60", Offset = "0x4A6860", Length = "0x6")]
		get
		{
			return 0f;
		}
	}

	[Token(Token = "0x60083F9")]
	[Address(RVA = "0x1254DA0", Offset = "0x1253BA0", Length = "0x9B3")]
	public bool TryFindDropPositionAndAngle(Vector3 desiredPosition, Quaternion desiredRotation, out Vector3 dropPosition, out Quaternion dropRotation)
	{
		dropPosition = default(Vector3);
		dropRotation = default(Quaternion);
		return false;
	}

	[Token(Token = "0x60083FA")]
	[Address(RVA = "0x4A22A0", Offset = "0x4A10A0", Length = "0x7")]
	public TravoisDropSettings()
	{
	}
}
