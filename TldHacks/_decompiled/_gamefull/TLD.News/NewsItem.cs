using Cpp2ILInjected;
using UnityEngine;

namespace TLD.News;

[Token(Token = "0x2001387")]
public class NewsItem
{
	[Token(Token = "0x4008F86")]
	[FieldOffset(Offset = "0x10")]
	public string m_Name;

	[Token(Token = "0x4008F87")]
	[FieldOffset(Offset = "0x18")]
	public NewsType m_NewsType;

	[Token(Token = "0x4008F88")]
	[FieldOffset(Offset = "0x20")]
	public string m_BackgroundImageUrl;

	[Token(Token = "0x4008F89")]
	[FieldOffset(Offset = "0x28")]
	public Texture2D m_CachedBackgroundImage;

	[Token(Token = "0x4008F8A")]
	[FieldOffset(Offset = "0x30")]
	public string m_StartDate;

	[Token(Token = "0x4008F8B")]
	[FieldOffset(Offset = "0x38")]
	public string m_EndDate;

	[Token(Token = "0x4008F8C")]
	[FieldOffset(Offset = "0x40")]
	public string m_LocalizedTitle;

	[Token(Token = "0x4008F8D")]
	[FieldOffset(Offset = "0x48")]
	public string m_LocalizedBody;

	[Token(Token = "0x4008F8E")]
	[FieldOffset(Offset = "0x50")]
	public string m_FallbackTitle;

	[Token(Token = "0x4008F8F")]
	[FieldOffset(Offset = "0x58")]
	public string m_FallbackBody;

	[Token(Token = "0x4008F90")]
	[FieldOffset(Offset = "0x60")]
	public string m_Url;

	[Token(Token = "0x6007CC7")]
	[Address(RVA = "0x11BF800", Offset = "0x11BE600", Length = "0x14")]
	public string GetTitle()
	{
		return null;
	}

	[Token(Token = "0x6007CC8")]
	[Address(RVA = "0x11BF820", Offset = "0x11BE620", Length = "0x14")]
	public string GetBody()
	{
		return null;
	}

	[Token(Token = "0x6007CC9")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public NewsItem()
	{
	}
}
