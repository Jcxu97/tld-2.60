using System;
using Cpp2ILInjected;
using UnityEngine.Events;

namespace TLD.Interactions;

[Serializable]
[Token(Token = "0x20013A3")]
public class InteractionEvent : UnityEvent<BaseInteraction>
{
	[Token(Token = "0x6007D67")]
	[Address(RVA = "0x11C6FA0", Offset = "0x11C5DA0", Length = "0x80")]
	public InteractionEvent()
	{
	}
}
