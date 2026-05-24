using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;

namespace ParadoxNotion.Services;

[Token(Token = "0x2000D6B")]
public static class Logger
{
	[Token(Token = "0x2000D6C")]
	public struct Message
	{
		[Token(Token = "0x40083D1")]
		[FieldOffset(Offset = "0x0")]
		public LogType type;

		[Token(Token = "0x40083D2")]
		[FieldOffset(Offset = "0x8")]
		public string text;

		[Token(Token = "0x40083D3")]
		[FieldOffset(Offset = "0x10")]
		public string tag;

		[Token(Token = "0x40083D4")]
		[FieldOffset(Offset = "0x18")]
		public object context;

		[Token(Token = "0x60068D0")]
		[Address(RVA = "0x106EDF0", Offset = "0x106DBF0", Length = "0xC8")]
		public bool IsSameAs(Message b)
		{
			return false;
		}

		[Token(Token = "0x60068D1")]
		[Address(RVA = "0x106EEC0", Offset = "0x106DCC0", Length = "0x15")]
		public bool IsValid()
		{
			return false;
		}
	}

	[Token(Token = "0x2000D6D")]
	public delegate bool LogHandler(Message message);

	[Token(Token = "0x40083D0")]
	private static List<LogHandler> subscribers;

	[Token(Token = "0x60068C3")]
	[Address(RVA = "0x106DF00", Offset = "0x106CD00", Length = "0xBD")]
	public static void AddListener(LogHandler callback)
	{
	}

	[Token(Token = "0x60068C4")]
	[Address(RVA = "0x106DFC0", Offset = "0x106CDC0", Length = "0x82")]
	public static void RemoveListener(LogHandler callback)
	{
	}

	[Token(Token = "0x60068C5")]
	[Address(RVA = "0x106E050", Offset = "0x106CE50", Length = "0x9D")]
	public static void Log(object message, Enum tag = null, object context = null)
	{
	}

	[Token(Token = "0x60068C6")]
	[Address(RVA = "0x106E0F0", Offset = "0x106CEF0", Length = "0x7A")]
	public static void Log(object message, string tag = null, object context = null)
	{
	}

	[Token(Token = "0x60068C7")]
	[Address(RVA = "0x106E170", Offset = "0x106CF70", Length = "0x9D")]
	public static void LogWarning(object message, Enum tag = null, object context = null)
	{
	}

	[Token(Token = "0x60068C8")]
	[Address(RVA = "0x106E210", Offset = "0x106D010", Length = "0x7A")]
	public static void LogWarning(object message, string tag = null, object context = null)
	{
	}

	[Token(Token = "0x60068C9")]
	[Address(RVA = "0x106E290", Offset = "0x106D090", Length = "0x9A")]
	public static void LogError(object message, Enum tag = null, object context = null)
	{
	}

	[Token(Token = "0x60068CA")]
	[Address(RVA = "0x106E330", Offset = "0x106D130", Length = "0x77")]
	public static void LogError(object message, string tag = null, object context = null)
	{
	}

	[Token(Token = "0x60068CB")]
	[Address(RVA = "0x106E3B0", Offset = "0x106D1B0", Length = "0x9D")]
	public static void LogException(Exception exception, Enum tag = null, object context = null)
	{
	}

	[Token(Token = "0x60068CC")]
	[Address(RVA = "0x106E450", Offset = "0x106D250", Length = "0x7A")]
	public static void LogException(Exception exception, string tag = null, object context = null)
	{
	}

	[Token(Token = "0x60068CD")]
	[Address(RVA = "0x106E4D0", Offset = "0x106D2D0", Length = "0x606")]
	private static void Internal_Log(LogType type, object message, string tag, object context)
	{
	}

	[Token(Token = "0x60068CE")]
	[Address(RVA = "0x106EAE0", Offset = "0x106D8E0", Length = "0x22B")]
	private static void ForwardToUnity(LogType type, object message, string tag, object context)
	{
	}
}
