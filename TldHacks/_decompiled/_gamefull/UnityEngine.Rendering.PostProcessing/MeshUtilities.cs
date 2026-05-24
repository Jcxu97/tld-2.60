using System;
using System.Collections.Generic;
using Cpp2ILInjected;

namespace UnityEngine.Rendering.PostProcessing;

[Token(Token = "0x2000CF6")]
internal static class MeshUtilities
{
	[Token(Token = "0x4008048")]
	private static Dictionary<PrimitiveType, Mesh> s_Primitives;

	[Token(Token = "0x4008049")]
	private static Dictionary<Type, PrimitiveType> s_ColliderPrimitives;

	[Token(Token = "0x6006683")]
	[Address(RVA = "0x1029580", Offset = "0x1028380", Length = "0x363")]
	static MeshUtilities()
	{
	}

	[Token(Token = "0x6006684")]
	[Address(RVA = "0x10298F0", Offset = "0x10286F0", Length = "0x305")]
	internal static Mesh GetColliderMesh(Collider collider)
	{
		return null;
	}

	[Token(Token = "0x6006685")]
	[Address(RVA = "0x1029C00", Offset = "0x1028A00", Length = "0x1AB")]
	internal static Mesh GetPrimitive(PrimitiveType primitiveType)
	{
		return null;
	}

	[Token(Token = "0x6006686")]
	[Address(RVA = "0x1029DB0", Offset = "0x1028BB0", Length = "0xA3")]
	private static Mesh GetBuiltinMesh(PrimitiveType primitiveType)
	{
		return null;
	}
}
