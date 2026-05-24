using Cpp2ILInjected;
using UnityEngine;

namespace ParadoxNotion;

[Token(Token = "0x2000D5C")]
public static class OperationTools
{
	[Token(Token = "0x6006820")]
	[Address(RVA = "0x105F180", Offset = "0x105DF80", Length = "0xDD")]
	public static string GetOperationString(OperationMethod om)
	{
		return null;
	}

	[Token(Token = "0x6006821")]
	[Address(RVA = "0x105F260", Offset = "0x105E060", Length = "0x47")]
	public static float Operate(float a, float b, OperationMethod om, float delta = 1f)
	{
		return 0f;
	}

	[Token(Token = "0x6006822")]
	[Address(RVA = "0x105F2B0", Offset = "0x105E0B0", Length = "0x3C")]
	public static int Operate(int a, int b, OperationMethod om)
	{
		return 0;
	}

	[Token(Token = "0x6006823")]
	[Address(RVA = "0x105F2F0", Offset = "0x105E0F0", Length = "0x20D")]
	public static Vector3 Operate(Vector3 a, Vector3 b, OperationMethod om, float delta = 1f)
	{
		return default(Vector3);
	}

	[Token(Token = "0x6006824")]
	[Address(RVA = "0x105F500", Offset = "0x105E300", Length = "0xDD")]
	public static string GetCompareString(CompareMethod cm)
	{
		return null;
	}

	[Token(Token = "0x6006825")]
	[Address(RVA = "0x105F5E0", Offset = "0x105E3E0", Length = "0x4E")]
	public static bool Compare(float a, float b, CompareMethod cm, float floatingPoint)
	{
		return false;
	}

	[Token(Token = "0x6006826")]
	[Address(RVA = "0x105F630", Offset = "0x105E430", Length = "0x3E")]
	public static bool Compare(int a, int b, CompareMethod cm)
	{
		return false;
	}
}
