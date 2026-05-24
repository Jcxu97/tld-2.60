using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x2000703")]
public class StringTableData : ScriptableObject
{
	[Flags]
	[Token(Token = "0x2000704")]
	public enum EntryFlags
	{
		[Token(Token = "0x4004A59")]
		None = 0,
		[Token(Token = "0x4004A5A")]
		NeedsTranslation = 1
	}

	[Serializable]
	[Token(Token = "0x2000705")]
	public class Entry
	{
		[Token(Token = "0x4004A5B")]
		[FieldOffset(Offset = "0x10")]
		public string m_Key;

		[Token(Token = "0x4004A5C")]
		[FieldOffset(Offset = "0x18")]
		public List<string> m_Languages;

		[Token(Token = "0x6003D7F")]
		[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
		public Entry()
		{
		}
	}

	[HideInInspector]
	[Token(Token = "0x4004A57")]
	[FieldOffset(Offset = "0x18")]
	public List<Entry> m_Entries;

	[Token(Token = "0x6003D7E")]
	[Address(RVA = "0xB99E10", Offset = "0xB98C10", Length = "0xB6")]
	public StringTableData()
	{
	}
}
