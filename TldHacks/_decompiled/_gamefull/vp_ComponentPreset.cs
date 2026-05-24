using System;
using System.Collections.Generic;
using System.Reflection;
using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x2000004")]
public sealed class vp_ComponentPreset
{
	[Token(Token = "0x2000005")]
	private enum ReadMode
	{
		[Token(Token = "0x400001B")]
		Normal,
		[Token(Token = "0x400001C")]
		LineComment,
		[Token(Token = "0x400001D")]
		BlockComment
	}

	[Token(Token = "0x2000006")]
	private class Field
	{
		[Token(Token = "0x400001E")]
		[FieldOffset(Offset = "0x10")]
		public FieldInfo m_FieldInfo;

		[Token(Token = "0x400001F")]
		[FieldOffset(Offset = "0x18")]
		public object Args;

		[Token(Token = "0x600003C")]
		[Address(RVA = "0x409520", Offset = "0x408320", Length = "0xAA")]
		public Field(FieldInfo fieldInfo, object args)
		{
		}
	}

	[Token(Token = "0x4000013")]
	private static string m_FullPath;

	[Token(Token = "0x4000014")]
	private static int m_LineNumber;

	[Token(Token = "0x4000015")]
	private static Type m_Type;

	[Token(Token = "0x4000016")]
	public static bool LogErrors;

	[Token(Token = "0x4000017")]
	private static ReadMode m_ReadMode;

	[Token(Token = "0x4000018")]
	[FieldOffset(Offset = "0x10")]
	private Type m_ComponentType;

	[Token(Token = "0x4000019")]
	[FieldOffset(Offset = "0x18")]
	private List<Field> m_Fields;

	[Token(Token = "0x17000004")]
	public Type ComponentType
	{
		[Token(Token = "0x6000018")]
		[Address(RVA = "0x49DED0", Offset = "0x49CCD0", Length = "0x5")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6000019")]
	[Address(RVA = "0x53EA60", Offset = "0x53D860", Length = "0x9C")]
	public static string Save(Component component, string fullPath)
	{
		return null;
	}

	[Token(Token = "0x600001A")]
	[Address(RVA = "0x53EB00", Offset = "0x53D900", Length = "0x1040")]
	public static string Save(vp_ComponentPreset savePreset, string fullPath, bool isDifference = false)
	{
		return null;
	}

	[Token(Token = "0x600001B")]
	[Address(RVA = "0x53FB50", Offset = "0x53E950", Length = "0x81F")]
	public static string SaveDifference(vp_ComponentPreset initialStatePreset, Component modifiedComponent, string fullPath, vp_ComponentPreset diskPreset)
	{
		return null;
	}

	[Token(Token = "0x600001C")]
	[Address(RVA = "0x540370", Offset = "0x53F170", Length = "0x435")]
	public void InitFromComponent(Component component)
	{
	}

	[Token(Token = "0x600001D")]
	[Address(RVA = "0x5407B0", Offset = "0x53F5B0", Length = "0x42B")]
	public static vp_ComponentPreset CreateFromComponent(Component component)
	{
		return null;
	}

	[Token(Token = "0x600001E")]
	[Address(RVA = "0x540BE0", Offset = "0x53F9E0", Length = "0x3C8")]
	public bool LoadTextStream(string fullPath)
	{
		return false;
	}

	[Token(Token = "0x600001F")]
	[Address(RVA = "0x540FB0", Offset = "0x53FDB0", Length = "0x99")]
	public static bool Load(Component component, string fullPath)
	{
		return false;
	}

	[Token(Token = "0x6000020")]
	[Address(RVA = "0x541050", Offset = "0x53FE50", Length = "0x5A1")]
	public bool LoadFromResources(string resourcePath)
	{
		return false;
	}

	[Token(Token = "0x6000021")]
	[Address(RVA = "0x541600", Offset = "0x540400", Length = "0x9D")]
	public static vp_ComponentPreset LoadFromResources(Component component, string resourcePath)
	{
		return null;
	}

	[Token(Token = "0x6000022")]
	[Address(RVA = "0x5416A0", Offset = "0x5404A0", Length = "0x2DB")]
	public bool LoadFromTextAsset(TextAsset file)
	{
		return false;
	}

	[Token(Token = "0x6000023")]
	[Address(RVA = "0x541980", Offset = "0x540780", Length = "0x9D")]
	public static vp_ComponentPreset LoadFromTextAsset(Component component, TextAsset file)
	{
		return null;
	}

	[Token(Token = "0x6000024")]
	[Address(RVA = "0x541A20", Offset = "0x540820", Length = "0x1B1")]
	private static void Append(string str)
	{
	}

	[Token(Token = "0x6000025")]
	[Address(RVA = "0x541BE0", Offset = "0x5409E0", Length = "0x142")]
	private static void ClearTextFile()
	{
	}

	[Token(Token = "0x6000026")]
	[Address(RVA = "0x541D30", Offset = "0x540B30", Length = "0x1FE")]
	private void ParseLines(List<string> lines)
	{
	}

	[Token(Token = "0x6000027")]
	[Address(RVA = "0x541F30", Offset = "0x540D30", Length = "0x7ED")]
	private bool Parse(string line)
	{
		return false;
	}

	[Token(Token = "0x6000028")]
	[Address(RVA = "0x542720", Offset = "0x541520", Length = "0x639")]
	public static bool Apply(Component component, vp_ComponentPreset preset)
	{
		return false;
	}

	[Token(Token = "0x6000029")]
	[Address(RVA = "0x542D60", Offset = "0x541B60", Length = "0xE8")]
	public static Type GetFileType(string fullPath)
	{
		return null;
	}

	[Token(Token = "0x600002A")]
	[Address(RVA = "0x542E50", Offset = "0x541C50", Length = "0xE8")]
	public static Type GetFileTypeFromAsset(TextAsset asset)
	{
		return null;
	}

	[Token(Token = "0x600002B")]
	[Address(RVA = "0x542F40", Offset = "0x541D40", Length = "0x539")]
	private static object TokensToObject(FieldInfo field, string[] tokens)
	{
		return null;
	}

	[Token(Token = "0x600002C")]
	[Address(RVA = "0x543480", Offset = "0x542280", Length = "0x2E6")]
	private static string RemoveComments(string str)
	{
		return null;
	}

	[Token(Token = "0x600002D")]
	[Address(RVA = "0x543770", Offset = "0x542570", Length = "0x433")]
	private static Vector4 ArgsToVector4(string[] args)
	{
		return default(Vector4);
	}

	[Token(Token = "0x600002E")]
	[Address(RVA = "0x543BB0", Offset = "0x5429B0", Length = "0x3C3")]
	private static Vector3 ArgsToVector3(string[] args)
	{
		return default(Vector3);
	}

	[Token(Token = "0x600002F")]
	[Address(RVA = "0x543F80", Offset = "0x542D80", Length = "0x2EA")]
	private static Vector2 ArgsToVector2(string[] args)
	{
		return default(Vector2);
	}

	[Token(Token = "0x6000030")]
	[Address(RVA = "0x544270", Offset = "0x543070", Length = "0x1B1")]
	private static float ArgsToFloat(string[] args)
	{
		return 0f;
	}

	[Token(Token = "0x6000031")]
	[Address(RVA = "0x544430", Offset = "0x543230", Length = "0x16E")]
	private static int ArgsToInt(string[] args)
	{
		return 0;
	}

	[Token(Token = "0x6000032")]
	[Address(RVA = "0x5445A0", Offset = "0x5433A0", Length = "0x1AE")]
	private static bool ArgsToBool(string[] args)
	{
		return false;
	}

	[Token(Token = "0x6000033")]
	[Address(RVA = "0x544750", Offset = "0x543550", Length = "0xAA")]
	private static string ArgsToString(string[] args)
	{
		return null;
	}

	[Token(Token = "0x6000034")]
	[Address(RVA = "0x544800", Offset = "0x543600", Length = "0x1F0")]
	public Type GetFieldType(string fieldName)
	{
		return null;
	}

	[Token(Token = "0x6000035")]
	[Address(RVA = "0x544A00", Offset = "0x543800", Length = "0x1D4")]
	public object GetFieldValue(string fieldName)
	{
		return null;
	}

	[Token(Token = "0x6000036")]
	[Address(RVA = "0x544BE0", Offset = "0x5439E0", Length = "0xEF")]
	public static string ExtractFilenameFromPath(string path)
	{
		return null;
	}

	[Token(Token = "0x6000037")]
	[Address(RVA = "0x544CD0", Offset = "0x543AD0", Length = "0x1B6")]
	private static void PresetError(string message)
	{
	}

	[Token(Token = "0x6000038")]
	[Address(RVA = "0x544E90", Offset = "0x543C90", Length = "0xB7")]
	private static void Error(string message)
	{
	}

	[Token(Token = "0x6000039")]
	[Address(RVA = "0x544F50", Offset = "0x543D50", Length = "0x2E7")]
	private static string GetErrorLocation()
	{
		return null;
	}

	[Token(Token = "0x600003A")]
	[Address(RVA = "0x545240", Offset = "0x544040", Length = "0xAD")]
	public vp_ComponentPreset()
	{
	}
}
