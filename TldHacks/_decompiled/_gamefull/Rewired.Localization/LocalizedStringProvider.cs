using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;

namespace Rewired.Localization;

[AddComponentMenu("Rewired/Localization/Localized String Provider")]
[Token(Token = "0x2000C33")]
public class LocalizedStringProvider : LocalizedStringProviderBase
{
	[SerializeField]
	[Tooltip("A JSON file containing localizied string key value pairs.")]
	[Token(Token = "0x4007C5D")]
	[FieldOffset(Offset = "0x28")]
	private TextAsset _localizedStringsFile;

	[NonSerialized]
	[Token(Token = "0x4007C5E")]
	[FieldOffset(Offset = "0x30")]
	private Dictionary<string, string> _dictionary;

	[NonSerialized]
	[Token(Token = "0x4007C5F")]
	[FieldOffset(Offset = "0x38")]
	private bool _initialized;

	[Token(Token = "0x1700068A")]
	protected virtual Dictionary<string, string> dictionary
	{
		[Token(Token = "0x60062C3")]
		[Address(RVA = "0x457420", Offset = "0x456220", Length = "0x5")]
		get
		{
			return null;
		}
		[Token(Token = "0x60062C4")]
		[Address(RVA = "0x4B1CB0", Offset = "0x4B0AB0", Length = "0x52")]
		set
		{
		}
	}

	[Token(Token = "0x1700068B")]
	public virtual TextAsset localizedStringsFile
	{
		[Token(Token = "0x60062C5")]
		[Address(RVA = "0x413AB0", Offset = "0x4128B0", Length = "0x5")]
		get
		{
			return null;
		}
		[Token(Token = "0x60062C6")]
		[Address(RVA = "0xFBF4F0", Offset = "0xFBE2F0", Length = "0x65")]
		set
		{
		}
	}

	[Token(Token = "0x1700068C")]
	protected override bool initialized
	{
		[Token(Token = "0x60062C7")]
		[Address(RVA = "0x8BE400", Offset = "0x8BD200", Length = "0x5")]
		get
		{
			return false;
		}
	}

	[Token(Token = "0x60062C8")]
	[Address(RVA = "0xFBF560", Offset = "0xFBE360", Length = "0x25")]
	protected override bool Initialize()
	{
		return false;
	}

	[Token(Token = "0x60062C9")]
	[Address(RVA = "0xFBF590", Offset = "0xFBE390", Length = "0x211")]
	protected virtual bool TryLoadLocalizedStringData()
	{
		return false;
	}

	[Token(Token = "0x60062CA")]
	[Address(RVA = "0xFBF7B0", Offset = "0xFBE5B0", Length = "0xC8")]
	protected override bool TryGetLocalizedString(string key, out string result)
	{
		result = null;
		return false;
	}

	[Token(Token = "0x60062CB")]
	[Address(RVA = "0xFBF880", Offset = "0xFBE680", Length = "0xE3")]
	public LocalizedStringProvider()
	{
	}
}
