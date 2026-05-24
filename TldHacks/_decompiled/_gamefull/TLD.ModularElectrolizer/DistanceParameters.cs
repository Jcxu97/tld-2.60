using Cpp2ILInjected;
using UnityEngine;

namespace TLD.ModularElectrolizer;

[CreateAssetMenu(menuName = "Aurora/Distance Parameters")]
[Token(Token = "0x20013CD")]
public class DistanceParameters : ScriptableObject
{
	[Token(Token = "0x400912E")]
	[FieldOffset(Offset = "0x18")]
	public float m_Fancy;

	[Token(Token = "0x400912F")]
	[FieldOffset(Offset = "0x1C")]
	public float m_Ultra;

	[Token(Token = "0x4009130")]
	[FieldOffset(Offset = "0x20")]
	public float m_High;

	[Token(Token = "0x4009131")]
	[FieldOffset(Offset = "0x24")]
	public float m_Medium;

	[Token(Token = "0x4009132")]
	[FieldOffset(Offset = "0x28")]
	public float m_Low;

	[Token(Token = "0x4009133")]
	[FieldOffset(Offset = "0x2C")]
	public float m_FadePercent;

	[Token(Token = "0x6007E8D")]
	[Address(RVA = "0x11E1DD0", Offset = "0x11E0BD0", Length = "0x36")]
	public float GetCutoffDistance(QualityLodBias quality)
	{
		return 0f;
	}

	[Token(Token = "0x6007E8E")]
	[Address(RVA = "0x11E1E10", Offset = "0x11E0C10", Length = "0x4F")]
	public float GetFadeDistance(QualityLodBias quality)
	{
		return 0f;
	}

	[Token(Token = "0x6007E8F")]
	[Address(RVA = "0x11E1E60", Offset = "0x11E0C60", Length = "0x31")]
	public DistanceParameters()
	{
	}
}
