using System;
using System.Collections.ObjectModel;
using Cpp2ILInjected;
using UnityEngine.Serialization;

namespace UnityEngine.Rendering.PostProcessing;

[Serializable]
[Token(Token = "0x2000CD7")]
public class PostProcessEffectSettings : ScriptableObject
{
	[FormerlySerializedAs("active")]
	[SerializeField]
	[Token(Token = "0x4007F7D")]
	[FieldOffset(Offset = "0x18")]
	private bool m_Active;

	[Token(Token = "0x4007F7E")]
	[FieldOffset(Offset = "0x20")]
	public BoolParameter enabled;

	[Token(Token = "0x4007F7F")]
	[FieldOffset(Offset = "0x28")]
	internal ReadOnlyCollection<ParameterOverride> parameters;

	[Token(Token = "0x170006CB")]
	public bool active
	{
		[Token(Token = "0x60065A2")]
		[Address(RVA = "0xC880B0", Offset = "0xC86EB0", Length = "0x5")]
		get
		{
			return false;
		}
		[Token(Token = "0x60065A3")]
		[Address(RVA = "0x1015530", Offset = "0x1014330", Length = "0x60")]
		set
		{
		}
	}

	[Token(Token = "0x60065A4")]
	[Address(RVA = "0x1015590", Offset = "0x1014390", Length = "0x692")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x60065A5")]
	[Address(RVA = "0x1015C30", Offset = "0x1014A30", Length = "0x1FC")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x60065A6")]
	[Address(RVA = "0x1015E30", Offset = "0x1014C30", Length = "0x21C")]
	public void SetAllOverridesTo(bool state, bool excludeEnabled = true)
	{
	}

	[Token(Token = "0x60065A7")]
	[Address(RVA = "0x1016050", Offset = "0x1014E50", Length = "0x1B")]
	public virtual bool IsEnabledAndSupported(PostProcessRenderContext context)
	{
		return false;
	}

	[Token(Token = "0x60065A8")]
	[Address(RVA = "0x1016070", Offset = "0x1014E70", Length = "0x216")]
	public int GetHash()
	{
		return 0;
	}

	[Token(Token = "0x60065A9")]
	[Address(RVA = "0x1016290", Offset = "0x1015090", Length = "0xC5")]
	public PostProcessEffectSettings()
	{
	}
}
