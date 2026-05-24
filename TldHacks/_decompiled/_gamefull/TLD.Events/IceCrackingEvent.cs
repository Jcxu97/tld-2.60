using System;
using Cpp2ILInjected;
using UnityEngine;

namespace TLD.Events;

[CreateAssetMenu(menuName = "Events/Ice Cracking Event")]
[Token(Token = "0x20013DD")]
public class IceCrackingEvent : GameEvent
{
	[NonSerialized]
	[Token(Token = "0x400918A")]
	[FieldOffset(Offset = "0x20")]
	public Vector3 m_Position;

	[NonSerialized]
	[Token(Token = "0x400918B")]
	[FieldOffset(Offset = "0x2C")]
	public float m_SecondsBeforeIceCracks;

	[NonSerialized]
	[Token(Token = "0x400918C")]
	[FieldOffset(Offset = "0x30")]
	public bool m_FellIntoWater;

	[Token(Token = "0x6007EB9")]
	[Address(RVA = "0x11E5DD0", Offset = "0x11E4BD0", Length = "0x7")]
	public IceCrackingEvent()
	{
	}
}
