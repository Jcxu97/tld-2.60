using System.Diagnostics;
using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x20009FB")]
public class DebugText : MonoBehaviour
{
	[Conditional("__DEBUG")]
	[Token(Token = "0x60057D3")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public static void Add(string tag, string str)
	{
	}

	[Conditional("__DEBUG")]
	[Token(Token = "0x60057D4")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public static void ActivateTags(string activateTags)
	{
	}

	[Conditional("__DEBUG")]
	[Token(Token = "0x60057D5")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public static void DeactivateTags(string _tags)
	{
	}

	[Token(Token = "0x60057D6")]
	[Address(RVA = "0x4AF5E0", Offset = "0x4AE3E0", Length = "0x43")]
	public DebugText()
	{
	}
}
