using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x200046D")]
public class CanOpeningItem : MonoBehaviour
{
	[Token(Token = "0x200046E")]
	public enum CanOpeningType
	{
		[Token(Token = "0x40027EB")]
		CanOpener,
		[Token(Token = "0x40027EC")]
		Knife,
		[Token(Token = "0x40027ED")]
		Hatchet,
		[Token(Token = "0x40027EE")]
		KnifeImprovised,
		[Token(Token = "0x40027EF")]
		HatchetImprovised
	}

	[Token(Token = "0x40027E7")]
	[FieldOffset(Offset = "0x20")]
	public CanOpeningType m_Type;

	[Token(Token = "0x40027E8")]
	[FieldOffset(Offset = "0x28")]
	public string m_CanOpeningAudio;

	[Token(Token = "0x40027E9")]
	[FieldOffset(Offset = "0x30")]
	public float m_CanOpeningLengthSeconds;

	[Token(Token = "0x600213C")]
	[Address(RVA = "0x4AF5E0", Offset = "0x4AE3E0", Length = "0x43")]
	public CanOpeningItem()
	{
	}
}
