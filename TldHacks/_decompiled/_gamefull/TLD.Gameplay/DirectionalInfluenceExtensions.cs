using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;

namespace TLD.Gameplay;

[Token(Token = "0x2001474")]
public static class DirectionalInfluenceExtensions
{
	[Token(Token = "0x400945E")]
	private const float NULL_INFLUENCE = 0.001f;

	[Token(Token = "0x600821E")]
	[Address(RVA = "0x18B8060", Offset = "0x18B6E60", Length = "0x2CF")]
	public static bool TryFindHighestInfluenceMapping<T>(this List<DirectionalInfluenceMapping<T>> mappings, Vector3 position, out DirectionalInfluenceMapping<T> bestMapping)
	{
		bestMapping = null;
		return false;
	}
}
