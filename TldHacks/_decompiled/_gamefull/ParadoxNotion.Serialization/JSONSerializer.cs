using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using ParadoxNotion.Serialization.FullSerializer;
using UnityEngine;

namespace ParadoxNotion.Serialization;

[Token(Token = "0x2000D82")]
public static class JSONSerializer
{
	[Token(Token = "0x400840E")]
	private static Dictionary<string, fsData> cache;

	[Token(Token = "0x400840F")]
	private static object serializerLock;

	[Token(Token = "0x4008410")]
	private static fsSerializer serializer;

	[Token(Token = "0x17000735")]
	[field: Token(Token = "0x400840D")]
	public static bool applicationPlaying
	{
		[Token(Token = "0x6006966")]
		[Address(RVA = "0x1073D60", Offset = "0x1072B60", Length = "0x53")]
		get;
		[Token(Token = "0x6006967")]
		[Address(RVA = "0x1073DC0", Offset = "0x1072BC0", Length = "0x58")]
		private set;
	}

	[Token(Token = "0x6006968")]
	[Address(RVA = "0x1073E20", Offset = "0x1072C20", Length = "0x254")]
	static JSONSerializer()
	{
	}

	[Token(Token = "0x6006969")]
	[Address(RVA = "0x1074080", Offset = "0x1072E80", Length = "0x4B4")]
	public static string Serialize(Type type, object instance, bool pretyJson = false, List<UnityEngine.Object> objectReferences = null)
	{
		return null;
	}

	[Token(Token = "0x600696A")]
	[Address(RVA = "0x192C800", Offset = "0x192B600", Length = "0x126")]
	public static T Deserialize<T>(string json, List<UnityEngine.Object> objectReferences = null)
	{
		return default(T);
	}

	[Token(Token = "0x600696B")]
	[Address(RVA = "0x1074540", Offset = "0x1073340", Length = "0x78")]
	public static object Deserialize(Type type, string json, List<UnityEngine.Object> objectReferences = null)
	{
		return null;
	}

	[Token(Token = "0x600696C")]
	[Address(RVA = "0x192CB50", Offset = "0x192B950", Length = "0x266")]
	public static T DeserializeOverwrite<T>(T instance, string json, List<UnityEngine.Object> objectReferences = null)
	{
		return default(T);
	}

	[Token(Token = "0x600696D")]
	[Address(RVA = "0x10745C0", Offset = "0x10733C0", Length = "0x9B")]
	public static object DeserializeOverwrite(object instance, string json, List<UnityEngine.Object> objectReferences = null)
	{
		return null;
	}

	[Token(Token = "0x600696E")]
	[Address(RVA = "0x1074660", Offset = "0x1073460", Length = "0x5A6")]
	public static object Internal_Deserialize(Type type, string json, List<UnityEngine.Object> objectReferences, object instance)
	{
		return null;
	}

	[Token(Token = "0x600696F")]
	[Address(RVA = "0x192C540", Offset = "0x192B340", Length = "0xB2")]
	public static T Clone<T>(T original, List<UnityEngine.Object> objectReferences = null)
	{
		return default(T);
	}

	[Token(Token = "0x6006970")]
	[Address(RVA = "0x1074C10", Offset = "0x1073A10", Length = "0xE5")]
	public static object Clone(object original, List<UnityEngine.Object> objectReferences = null)
	{
		return null;
	}

	[Token(Token = "0x6006971")]
	[Address(RVA = "0x1074D00", Offset = "0x1073B00", Length = "0x1FB")]
	public static void ShowData(string json, string fileName = "")
	{
	}

	[Token(Token = "0x6006972")]
	[Address(RVA = "0x1074F00", Offset = "0x1073D00", Length = "0x19")]
	public static string PrettifyJson(string json)
	{
		return null;
	}
}
