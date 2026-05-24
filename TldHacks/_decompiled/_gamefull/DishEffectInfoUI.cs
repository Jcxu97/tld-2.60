using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using TLD.Utility;
using UnityEngine;

[Token(Token = "0x2000233")]
public class DishEffectInfoUI : ScriptableObject
{
	[Serializable]
	[Token(Token = "0x2000234")]
	public struct DishEffectUIMapping
	{
		[Token(Token = "0x4001374")]
		[FieldOffset(Offset = "0x0")]
		public IFoodEffect.EffectType m_EffectType;

		[SpriteAtlasIconName]
		[Token(Token = "0x4001375")]
		[FieldOffset(Offset = "0x8")]
		public string m_SpriteName;

		[Token(Token = "0x4001376")]
		[FieldOffset(Offset = "0x10")]
		public LocalizedString m_EffectText;
	}

	[Token(Token = "0x4001373")]
	[FieldOffset(Offset = "0x18")]
	public List<DishEffectUIMapping> m_Mappings;

	[Token(Token = "0x600137D")]
	[Address(RVA = "0x4A22A0", Offset = "0x4A10A0", Length = "0x7")]
	public DishEffectInfoUI()
	{
	}
}
