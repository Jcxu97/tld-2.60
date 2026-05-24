using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;

namespace TLD.Gameplay;

[CreateAssetMenu(menuName = "The Long Dark/Gameplay/Sandbox Game Config")]
[Token(Token = "0x2001496")]
public class SandboxConfig : SandboxBaseConfig
{
	[Token(Token = "0x2001497")]
	public class SandboxSaveGameFormat
	{
		[Token(Token = "0x4009550")]
		public const int CURRENT_VERSION = 1;

		[Token(Token = "0x4009551")]
		[FieldOffset(Offset = "0x10")]
		public int m_Version;

		[Token(Token = "0x4009552")]
		[FieldOffset(Offset = "0x18")]
		public List<BunkerLocationSaveData> m_BunkerSetup;

		[Token(Token = "0x60082B8")]
		[Address(RVA = "0x123B960", Offset = "0x123A760", Length = "0x8")]
		public SandboxSaveGameFormat()
		{
		}
	}

	[Token(Token = "0x400954C")]
	public const string SANDBOX_GLOBAL_SAVE_KEY = "sandbox_global";

	[Header("Sandbox Properties")]
	[Token(Token = "0x400954D")]
	[FieldOffset(Offset = "0xA0")]
	public int m_NumFeats;

	[SerializeField]
	[Token(Token = "0x400954E")]
	[FieldOffset(Offset = "0xA8")]
	private BunkerDistributor m_BunkerSetup;

	[Token(Token = "0x400954F")]
	[FieldOffset(Offset = "0xB0")]
	private readonly SandboxSaveGameFormat m_SaveData;

	[Token(Token = "0x60082B3")]
	[Address(RVA = "0x123CBD0", Offset = "0x123B9D0", Length = "0xEF")]
	public override void StartGame()
	{
	}

	[Token(Token = "0x60082B4")]
	[Address(RVA = "0x123CCC0", Offset = "0x123BAC0", Length = "0x1AB")]
	public override void SaveGame(SlotData slotData)
	{
	}

	[Token(Token = "0x60082B5")]
	[Address(RVA = "0x123CE70", Offset = "0x123BC70", Length = "0x1F1")]
	public override void LoadGame(string slotName)
	{
	}

	[Token(Token = "0x60082B6")]
	[Address(RVA = "0x123D070", Offset = "0x123BE70", Length = "0xEE")]
	public override void EndGame()
	{
	}

	[Token(Token = "0x60082B7")]
	[Address(RVA = "0x123D160", Offset = "0x123BF60", Length = "0xA0")]
	public SandboxConfig()
	{
	}
}
