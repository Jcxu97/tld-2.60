using System;
using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.AddressableAssets;

namespace TLD.Gear;

[CreateAssetMenu(menuName = "The Long Dark/Gear/Paper Doll Setup")]
[Token(Token = "0x200143C")]
public class PaperDollTextureData : ScriptableObject
{
	[Serializable]
	[Token(Token = "0x200143D")]
	public class PersonaConfig
	{
		[Token(Token = "0x400936D")]
		[FieldOffset(Offset = "0x10")]
		public AssetReferenceTexture2D m_Normal;

		[Token(Token = "0x400936E")]
		[FieldOffset(Offset = "0x18")]
		public AssetReferenceTexture2D m_Damaged;

		[Token(Token = "0x400936F")]
		[FieldOffset(Offset = "0x20")]
		public AssetReferenceTexture2D m_Blend;

		[Token(Token = "0x600811D")]
		[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
		public PersonaConfig()
		{
		}
	}

	[SerializeField]
	[Token(Token = "0x400936B")]
	[FieldOffset(Offset = "0x18")]
	private PersonaConfig m_Male;

	[SerializeField]
	[Token(Token = "0x400936C")]
	[FieldOffset(Offset = "0x20")]
	private PersonaConfig m_Female;

	[Token(Token = "0x600811B")]
	[Address(RVA = "0x1215740", Offset = "0x1214540", Length = "0xE")]
	public PersonaConfig GetSetup(VoicePersona persona)
	{
		return null;
	}

	[Token(Token = "0x600811C")]
	[Address(RVA = "0x4A22A0", Offset = "0x4A10A0", Length = "0x7")]
	public PaperDollTextureData()
	{
	}
}
