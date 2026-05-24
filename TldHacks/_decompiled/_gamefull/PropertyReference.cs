using System;
using System.Diagnostics;
using System.Reflection;
using Cpp2ILInjected;
using UnityEngine;

[Serializable]
[Token(Token = "0x20000BE")]
public class PropertyReference
{
	[SerializeField]
	[Token(Token = "0x4000637")]
	[FieldOffset(Offset = "0x10")]
	private Component mTarget;

	[SerializeField]
	[Token(Token = "0x4000638")]
	[FieldOffset(Offset = "0x18")]
	private string mName;

	[Token(Token = "0x4000639")]
	[FieldOffset(Offset = "0x20")]
	private FieldInfo mField;

	[Token(Token = "0x400063A")]
	[FieldOffset(Offset = "0x28")]
	private PropertyInfo mProperty;

	[Token(Token = "0x400063B")]
	private static int s_Hash;

	[Token(Token = "0x1700008B")]
	public Component target
	{
		[Token(Token = "0x60006D5")]
		[Address(RVA = "0x49DED0", Offset = "0x49CCD0", Length = "0x5")]
		get
		{
			return null;
		}
		[Token(Token = "0x60006D6")]
		[Address(RVA = "0xF93B10", Offset = "0xF92910", Length = "0xFA")]
		set
		{
		}
	}

	[Token(Token = "0x1700008C")]
	public string name
	{
		[Token(Token = "0x60006D7")]
		[Address(RVA = "0x4571D0", Offset = "0x455FD0", Length = "0x5")]
		get
		{
			return null;
		}
		[Token(Token = "0x60006D8")]
		[Address(RVA = "0xF93C10", Offset = "0xF92A10", Length = "0xFA")]
		set
		{
		}
	}

	[Token(Token = "0x1700008D")]
	public bool isValid
	{
		[Token(Token = "0x60006D9")]
		[Address(RVA = "0xF93D10", Offset = "0xF92B10", Length = "0xE8")]
		get
		{
			return false;
		}
	}

	[Token(Token = "0x1700008E")]
	public bool isEnabled
	{
		[Token(Token = "0x60006DA")]
		[Address(RVA = "0xF93E00", Offset = "0xF92C00", Length = "0x241")]
		get
		{
			return false;
		}
	}

	[Token(Token = "0x60006DB")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public PropertyReference()
	{
	}

	[Token(Token = "0x60006DC")]
	[Address(RVA = "0x409520", Offset = "0x408320", Length = "0xAA")]
	public PropertyReference(Component target, string fieldName)
	{
	}

	[Token(Token = "0x60006DD")]
	[Address(RVA = "0xF94050", Offset = "0xF92E50", Length = "0xCA")]
	public Type GetPropertyType()
	{
		return null;
	}

	[Token(Token = "0x60006DE")]
	[Address(RVA = "0xF94120", Offset = "0xF92F20", Length = "0x1DE")]
	public override bool Equals(object obj)
	{
		return false;
	}

	[Token(Token = "0x60006DF")]
	[Address(RVA = "0xF94300", Offset = "0xF93100", Length = "0x52")]
	public override int GetHashCode()
	{
		return 0;
	}

	[Token(Token = "0x60006E0")]
	[Address(RVA = "0x409520", Offset = "0x408320", Length = "0xAA")]
	public void Set(Component target, string methodName)
	{
	}

	[Token(Token = "0x60006E1")]
	[Address(RVA = "0x507DD0", Offset = "0x506BD0", Length = "0xAA")]
	public void Clear()
	{
	}

	[Token(Token = "0x60006E2")]
	[Address(RVA = "0xF94360", Offset = "0xF93160", Length = "0xAA")]
	public void Reset()
	{
	}

	[Token(Token = "0x60006E3")]
	[Address(RVA = "0xF94410", Offset = "0xF93210", Length = "0x63")]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x60006E4")]
	[Address(RVA = "0xF94480", Offset = "0xF93280", Length = "0x1A9")]
	public static string ToString(Component comp, string property)
	{
		return null;
	}

	[DebuggerHidden]
	[DebuggerStepThrough]
	[Token(Token = "0x60006E5")]
	[Address(RVA = "0xF94630", Offset = "0xF93430", Length = "0xA8")]
	public object Get()
	{
		return null;
	}

	[DebuggerHidden]
	[DebuggerStepThrough]
	[Token(Token = "0x60006E6")]
	[Address(RVA = "0xF946E0", Offset = "0xF934E0", Length = "0x451")]
	public bool Set(object value)
	{
		return false;
	}

	[DebuggerHidden]
	[DebuggerStepThrough]
	[Token(Token = "0x60006E7")]
	[Address(RVA = "0xF94B40", Offset = "0xF93940", Length = "0x36D")]
	private bool Cache()
	{
		return false;
	}

	[Token(Token = "0x60006E8")]
	[Address(RVA = "0xF94EB0", Offset = "0xF93CB0", Length = "0x18E")]
	private bool Convert(ref object value)
	{
		return false;
	}

	[Token(Token = "0x60006E9")]
	[Address(RVA = "0xF95040", Offset = "0xF93E40", Length = "0x6D")]
	public static bool Convert(Type from, Type to)
	{
		return false;
	}

	[Token(Token = "0x60006EA")]
	[Address(RVA = "0xF950B0", Offset = "0xF93EB0", Length = "0xB6")]
	public static bool Convert(object value, Type to)
	{
		return false;
	}

	[Token(Token = "0x60006EB")]
	[Address(RVA = "0xF95170", Offset = "0xF93F70", Length = "0x497")]
	public static bool Convert(ref object value, Type from, Type to)
	{
		return false;
	}
}
