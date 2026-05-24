using System;
using System.Collections.Generic;
using Cpp2ILInjected;

namespace UnityEngine.Rendering.PostProcessing;

[Token(Token = "0x2000CE6")]
public sealed class PostProcessProfile : ScriptableObject
{
	[Tooltip("A list of all settings currently stored in this profile.")]
	[Token(Token = "0x4007FCE")]
	[FieldOffset(Offset = "0x18")]
	public List<PostProcessEffectSettings> settings;

	[NonSerialized]
	[Token(Token = "0x4007FCF")]
	[FieldOffset(Offset = "0x20")]
	public bool isDirty;

	[Token(Token = "0x6006608")]
	[Address(RVA = "0x10243F0", Offset = "0x10231F0", Length = "0x177")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6006609")]
	[Address(RVA = "0x1971FA0", Offset = "0x1970DA0", Length = "0xE0")]
	public T AddSettings<T>() where T : PostProcessEffectSettings
	{
		return null;
	}

	[Token(Token = "0x600660A")]
	[Address(RVA = "0x1024570", Offset = "0x1023370", Length = "0x260")]
	public PostProcessEffectSettings AddSettings(Type type)
	{
		return null;
	}

	[Token(Token = "0x600660B")]
	[Address(RVA = "0x10247E0", Offset = "0x10235E0", Length = "0xC9")]
	public PostProcessEffectSettings AddSettings(PostProcessEffectSettings effect)
	{
		return null;
	}

	[Token(Token = "0x600660C")]
	[Address(RVA = "0x19722D0", Offset = "0x19710D0", Length = "0x1DE")]
	public void RemoveSettings<T>() where T : PostProcessEffectSettings
	{
	}

	[Token(Token = "0x600660D")]
	[Address(RVA = "0x10248B0", Offset = "0x10236B0", Length = "0x17E")]
	public void RemoveSettings(Type type)
	{
	}

	[Token(Token = "0x600660E")]
	[Address(RVA = "0x1972240", Offset = "0x1971040", Length = "0x84")]
	public bool HasSettings<T>() where T : PostProcessEffectSettings
	{
		return false;
	}

	[Token(Token = "0x600660F")]
	[Address(RVA = "0x1024A30", Offset = "0x1023830", Length = "0x185")]
	public bool HasSettings(Type type)
	{
		return false;
	}

	[Token(Token = "0x6006610")]
	[Address(RVA = "0x1972090", Offset = "0x1970E90", Length = "0x1AB")]
	public T GetSetting<T>() where T : PostProcessEffectSettings
	{
		return null;
	}

	[Token(Token = "0x6006611")]
	[Address(RVA = "0x19724B0", Offset = "0x19712B0", Length = "0x296")]
	public bool TryGetSettings<T>(out T outSetting) where T : PostProcessEffectSettings
	{
		outSetting = null;
		return false;
	}

	[Token(Token = "0x6006612")]
	[Address(RVA = "0x1024BC0", Offset = "0x10239C0", Length = "0xBA")]
	public PostProcessProfile()
	{
	}
}
