using System;
using System.Collections.Generic;
using Cpp2ILInjected;

namespace UnityEngine.Rendering.PostProcessing;

[Token(Token = "0x2000CF9")]
public sealed class PropertySheetFactory
{
	[Token(Token = "0x400804C")]
	[FieldOffset(Offset = "0x10")]
	private readonly Dictionary<Shader, PropertySheet> m_Sheets;

	[Token(Token = "0x6006691")]
	[Address(RVA = "0x102A130", Offset = "0x1028F30", Length = "0xAD")]
	public PropertySheetFactory()
	{
	}

	[Obsolete("Use PropertySheet.Get(Shader) with a direct reference to the Shader instead.")]
	[Token(Token = "0x6006692")]
	[Address(RVA = "0x102A1E0", Offset = "0x1028FE0", Length = "0x146")]
	public PropertySheet Get(string shaderName)
	{
		return null;
	}

	[Token(Token = "0x6006693")]
	[Address(RVA = "0x102A330", Offset = "0x1029130", Length = "0x313")]
	public PropertySheet Get(Shader shader)
	{
		return null;
	}

	[Token(Token = "0x6006694")]
	[Address(RVA = "0x102A650", Offset = "0x1029450", Length = "0x282")]
	public void Release()
	{
	}
}
