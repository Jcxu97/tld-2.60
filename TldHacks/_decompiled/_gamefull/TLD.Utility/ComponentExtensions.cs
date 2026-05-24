using Cpp2ILInjected;
using UnityEngine;

namespace TLD.Utility;

[Token(Token = "0x2001345")]
public static class ComponentExtensions
{
	[Token(Token = "0x6007B6C")]
	[Address(RVA = "0x1893940", Offset = "0x1892740", Length = "0x10D")]
	public static bool TryGetComponentInParent<T>(this Component obj, out T component) where T : Component
	{
		component = null;
		return false;
	}

	[Token(Token = "0x6007B6D")]
	[Address(RVA = "0x1893A50", Offset = "0x1892850", Length = "0x10D")]
	public static bool TryGetComponentInParent<T>(this GameObject obj, out T component) where T : Component
	{
		component = null;
		return false;
	}

	[Token(Token = "0x6007B6E")]
	[Address(RVA = "0x1893B60", Offset = "0x1892960", Length = "0x1BD")]
	public static bool TryGetComponentInParent<T>(this Transform t, out T component) where T : Component
	{
		component = null;
		return false;
	}
}
