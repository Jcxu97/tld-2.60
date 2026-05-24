using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;

namespace TLD.UI.Scroll;

[Token(Token = "0x2001399")]
public static class ScrollBehaviourItemPool
{
	[Token(Token = "0x4008FDC")]
	private static readonly Dictionary<Type, Stack<ScrollBehaviourItem>> s_Pool;

	[Token(Token = "0x4008FDD")]
	private static Transform s_PoolTransform;

	[Token(Token = "0x6007D2A")]
	[Address(RVA = "0x19E9D40", Offset = "0x19E8B40", Length = "0x1A4")]
	public static T GetFromPool<T>(T prefab) where T : ScrollBehaviourItem
	{
		return null;
	}

	[Token(Token = "0x6007D2B")]
	[Address(RVA = "0x11C5A00", Offset = "0x11C4800", Length = "0x440")]
	public static void ReturnToPool(ScrollBehaviourItem item)
	{
	}
}
