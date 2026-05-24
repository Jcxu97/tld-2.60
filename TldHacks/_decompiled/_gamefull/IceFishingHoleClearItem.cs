using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x20004B1")]
public class IceFishingHoleClearItem : MonoBehaviour
{
	[Tooltip("HP cost to item to clear a 100% frozen fishing hole.  Cost interpolates when not fully frozen.")]
	[Range(0f, 100f)]
	[Token(Token = "0x4002B5A")]
	[FieldOffset(Offset = "0x20")]
	public float m_HPDecreaseToClear;

	[Tooltip("Number of game minutes to clear 100% frozen hole.  Cost interpolates when not fully frozen.")]
	[Range(0f, 100f)]
	[Token(Token = "0x4002B5B")]
	[FieldOffset(Offset = "0x24")]
	public float m_NumGameMinutesToClear;

	[Token(Token = "0x4002B5C")]
	[FieldOffset(Offset = "0x28")]
	public string m_BreakIceAudio;

	[Token(Token = "0x60023EE")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	private void Start()
	{
	}

	[Token(Token = "0x60023EF")]
	[Address(RVA = "0x4AF5E0", Offset = "0x4AE3E0", Length = "0x43")]
	public IceFishingHoleClearItem()
	{
	}
}
