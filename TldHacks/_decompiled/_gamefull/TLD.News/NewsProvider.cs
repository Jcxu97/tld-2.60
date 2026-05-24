using System;
using System.Collections.Generic;
using Cpp2ILInjected;

namespace TLD.News;

[Token(Token = "0x2001388")]
public class NewsProvider
{
	[Token(Token = "0x2001389")]
	private class NewsResult
	{
		[Token(Token = "0x4008F99")]
		[FieldOffset(Offset = "0x10")]
		public NewsItem[] result;

		[Token(Token = "0x6007CD3")]
		[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
		public NewsResult()
		{
		}
	}

	[Token(Token = "0x4008F91")]
	private const string SERVER_URL = "https://hza1e5qt.apicdn.sanity.io/v2022-10-25/data/query/production?query=";

	[Token(Token = "0x4008F92")]
	private const string CHANNEL = "live";

	[Token(Token = "0x4008F93")]
	private const string QUERY_FORMAT = "*[_type == 'sku' && sku_reference_name == '{sku}'][0] {\n\t\t\t\t\t\t\t\t\t\t\t\t\tposts[@->channel == '{channel}' && @->platform.{platform} == true && dateTime(@->startDate) <= dateTime(now()) && dateTime(@->endDate) >= dateTime(now())]-> {\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t'm_Name': post_reference_name,\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t'm_NewsType': customNotificationType,\n\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t'm_BackgroundImageUrl': imageUrl,\n\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t'm_StartDate': startDate,\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t'm_EndDate': endDate,\n\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t'm_LocalizedTitle': language.{lang}.title,\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t'm_LocalizedBody': language.{lang}.body,\n\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t'm_FallbackTitle': language.en.title,\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t'm_FallbackBody': language.en.body,\n\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t'm_Url': tellMeMoreUrl,\n\t\t\t\t\t\t\t\t\t\t\t\t\t}\n\t\t\t\t\t\t\t\t\t\t\t\t}.posts";

	[Token(Token = "0x4008F94")]
	private const int REFRESH_TIME_MIN = 360;

	[Token(Token = "0x4008F95")]
	private const int FAIL_REFRESH_TIME_MIN = 10;

	[Token(Token = "0x4008F97")]
	[FieldOffset(Offset = "0x18")]
	private DateTime m_NextRefreshTime;

	[Token(Token = "0x4008F98")]
	[FieldOffset(Offset = "0x20")]
	private string m_LastLanguage;

	[Token(Token = "0x17000A92")]
	[field: Token(Token = "0x4008F96")]
	[field: FieldOffset(Offset = "0x10")]
	public List<NewsItem> Items
	{
		[Token(Token = "0x6007CCA")]
		[Address(RVA = "0x49DED0", Offset = "0x49CCD0", Length = "0x5")]
		get;
		[Token(Token = "0x6007CCB")]
		[Address(RVA = "0x4094C0", Offset = "0x4082C0", Length = "0x52")]
		private set;
	}

	[Token(Token = "0x6007CCC")]
	[Address(RVA = "0x11BF840", Offset = "0x11BE640", Length = "0x116")]
	public bool NeedsRefresh()
	{
		return false;
	}

	[Token(Token = "0x6007CCD")]
	[Address(RVA = "0x11BF960", Offset = "0x11BE760", Length = "0x18F")]
	public string GenerateNewsURL(string sku)
	{
		return null;
	}

	[Token(Token = "0x6007CCE")]
	[Address(RVA = "0x11BFAF0", Offset = "0x11BE8F0", Length = "0x22E")]
	private string GenerateQuery(string sku)
	{
		return null;
	}

	[Token(Token = "0x6007CCF")]
	[Address(RVA = "0x11BFD20", Offset = "0x11BEB20", Length = "0xC1")]
	private string TrimQuery(string query)
	{
		return null;
	}

	[Token(Token = "0x6007CD0")]
	[Address(RVA = "0x11BFDF0", Offset = "0x11BEBF0", Length = "0x31")]
	private string GetPlatformCode()
	{
		return null;
	}

	[Token(Token = "0x6007CD1")]
	[Address(RVA = "0x11BFE30", Offset = "0x11BEC30", Length = "0x2C2")]
	public void ParseJson(string newsJson)
	{
	}

	[Token(Token = "0x6007CD2")]
	[Address(RVA = "0x11C0100", Offset = "0x11BEF00", Length = "0xAD")]
	public NewsProvider()
	{
	}
}
