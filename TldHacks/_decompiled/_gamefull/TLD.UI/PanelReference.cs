using System;
using System.Diagnostics;
using Cpp2ILInjected;
using UnityEngine;

namespace TLD.UI;

[Token(Token = "0x2001390")]
public class PanelReference : ScriptableObject
{
	[Token(Token = "0x17000A93")]
	[field: Token(Token = "0x4008FB4")]
	[field: FieldOffset(Offset = "0x18")]
	public Panel_Base Panel
	{
		[Token(Token = "0x6007CF1")]
		[Address(RVA = "0x4571D0", Offset = "0x455FD0", Length = "0x5")]
		get;
		[Token(Token = "0x6007CF2")]
		[Address(RVA = "0x49DEE0", Offset = "0x49CCE0", Length = "0x52")]
		set;
	}

	[Token(Token = "0x6007CF3")]
	[Address(RVA = "0x195E6B0", Offset = "0x195D4B0", Length = "0x7D")]
	public static PanelReference Get<T>() where T : Panel_Base
	{
		return null;
	}

	[Token(Token = "0x6007CF4")]
	[Address(RVA = "0x11C2610", Offset = "0x11C1410", Length = "0x293")]
	public static PanelReference Get(Type type)
	{
		return null;
	}

	[Token(Token = "0x6007CF5")]
	[Address(RVA = "0x195E730", Offset = "0x195D530", Length = "0x184")]
	public bool TryGetPanel<T>(out T panel) where T : Panel_Base
	{
		panel = null;
		return false;
	}

	[Token(Token = "0x6007CF6")]
	[Address(RVA = "0x49DEE0", Offset = "0x49CCE0", Length = "0x52")]
	public void SetPanelReference<T>(T panel) where T : Panel_Base
	{
	}

	[Token(Token = "0x6007CF7")]
	[Address(RVA = "0x11C28B0", Offset = "0x11C16B0", Length = "0x181")]
	public void TryEnablePanelWithAudio(bool enable)
	{
	}

	[Token(Token = "0x6007CF8")]
	[Address(RVA = "0x11C2A40", Offset = "0x11C1840", Length = "0x61")]
	public static string GetAssetName(Type type)
	{
		return null;
	}

	[Token(Token = "0x6007CF9")]
	[Address(RVA = "0x11C2AB0", Offset = "0x11C18B0", Length = "0xD1")]
	private static PanelReference FindExistingInstance(string assetKey)
	{
		return null;
	}

	[Token(Token = "0x6007CFA")]
	[Address(RVA = "0x11C2B90", Offset = "0x11C1990", Length = "0x85")]
	public static void PreloadPanelReferences()
	{
	}

	[Token(Token = "0x6007CFB")]
	[Address(RVA = "0x11C2C20", Offset = "0x11C1A20", Length = "0x63")]
	private static PanelReference CreateReference(string assetKey)
	{
		return null;
	}

	[Conditional("__DEBUG")]
	[Token(Token = "0x6007CFC")]
	[Address(RVA = "0x195E8C0", Offset = "0x195D6C0", Length = "0xCC")]
	private void VerifyPanelTypes<T>() where T : Panel_Base
	{
	}

	[Token(Token = "0x6007CFD")]
	[Address(RVA = "0x4A22A0", Offset = "0x4A10A0", Length = "0x7")]
	public PanelReference()
	{
	}
}
