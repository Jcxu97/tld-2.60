using Cpp2ILInjected;
using Rewired.Interfaces;
using UnityEngine;

namespace Rewired.Localization;

[Token(Token = "0x2000C34")]
public abstract class LocalizedStringProviderBase : MonoBehaviour, ILocalizedStringProvider
{
	[SerializeField]
	[Tooltip("Determines if localized strings should be fetched immediately in bulk when available. If false, strings will be fetched when queried.")]
	[Token(Token = "0x4007C60")]
	[FieldOffset(Offset = "0x20")]
	private bool _prefetch;

	[Token(Token = "0x1700068D")]
	public virtual bool prefetch
	{
		[Token(Token = "0x60062CC")]
		[Address(RVA = "0x4D3E60", Offset = "0x4D2C60", Length = "0x5")]
		get
		{
			return false;
		}
		[Token(Token = "0x60062CD")]
		[Address(RVA = "0xFBF970", Offset = "0xFBE770", Length = "0x180")]
		set
		{
		}
	}

	[Token(Token = "0x1700068E")]
	protected abstract bool initialized
	{
		[Token(Token = "0x60062CE")]
		get;
	}

	[Token(Token = "0x60062CF")]
	[Address(RVA = "0xFBFB00", Offset = "0xFBE900", Length = "0x4C")]
	protected virtual void OnEnable()
	{
	}

	[Token(Token = "0x60062D0")]
	[Address(RVA = "0xFBFB50", Offset = "0xFBE950", Length = "0x15B")]
	protected virtual void OnDisable()
	{
	}

	[Token(Token = "0x60062D1")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	protected virtual void Update()
	{
	}

	[Token(Token = "0x60062D2")]
	[Address(RVA = "0xFBFCB0", Offset = "0xFBEAB0", Length = "0x22B")]
	protected virtual void TrySetLocalizedStringProvider()
	{
	}

	[Token(Token = "0x60062D3")]
	protected abstract bool Initialize();

	[Token(Token = "0x60062D4")]
	[Address(RVA = "0xFBFEE0", Offset = "0xFBECE0", Length = "0x284")]
	public virtual void Reload()
	{
	}

	[Token(Token = "0x60062D5")]
	protected abstract bool TryGetLocalizedString(string key, out string result);

	[Token(Token = "0x60062D6")]
	[Address(RVA = "0xFC0170", Offset = "0xFBEF70", Length = "0x14")]
	bool ILocalizedStringProvider.TryGetLocalizedString(string key, out string result)
	{
		result = null;
		return false;
	}

	[Token(Token = "0x60062D7")]
	[Address(RVA = "0x4AF5E0", Offset = "0x4AE3E0", Length = "0x43")]
	protected LocalizedStringProviderBase()
	{
	}
}
