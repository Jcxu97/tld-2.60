using System;
using System.Collections.Generic;
using AK.Wwise;
using Cpp2ILInjected;
using UnityEngine;

namespace TLD.Audio;

[Token(Token = "0x20014EB")]
public class SoundbankLoader : MonoBehaviour
{
	[Serializable]
	[Token(Token = "0x20014EC")]
	public struct EpisodeBankInfo
	{
		[Token(Token = "0x4009750")]
		[FieldOffset(Offset = "0x0")]
		public Episode m_Episode;

		[Token(Token = "0x4009751")]
		[FieldOffset(Offset = "0x8")]
		public List<Bank> m_Banks;
	}

	[Token(Token = "0x4009749")]
	[FieldOffset(Offset = "0x20")]
	public List<Bank> m_CommonBanks;

	[Token(Token = "0x400974A")]
	[FieldOffset(Offset = "0x28")]
	public List<EpisodeBankInfo> m_EpisodeBankInfo;

	[Tooltip("Until we can ensure all episode banks are properly separate, force load all episode banks")]
	[Token(Token = "0x400974B")]
	[FieldOffset(Offset = "0x30")]
	public bool m_LoadAllEpisodeBanksTEMP;

	[Token(Token = "0x400974C")]
	[FieldOffset(Offset = "0x31")]
	private bool m_BanksLoaded;

	[Token(Token = "0x400974D")]
	[FieldOffset(Offset = "0x32")]
	private bool m_HasLoadedEpisode;

	[Token(Token = "0x400974E")]
	[FieldOffset(Offset = "0x38")]
	private List<Bank> m_LoadedEpisodeBanks;

	[Token(Token = "0x400974F")]
	[FieldOffset(Offset = "0x40")]
	private Episode m_LoadedEpisode;

	[Token(Token = "0x600841D")]
	[Address(RVA = "0x12594B0", Offset = "0x12582B0", Length = "0x25")]
	public void Awake()
	{
	}

	[Token(Token = "0x600841E")]
	[Address(RVA = "0x12594E0", Offset = "0x12582E0", Length = "0x300")]
	public void LoadEpisodeBanks(Episode episode)
	{
	}

	[Token(Token = "0x600841F")]
	[Address(RVA = "0x12597F0", Offset = "0x12585F0", Length = "0x147")]
	public void DebugLoadAllEpisodeBanks()
	{
	}

	[Token(Token = "0x6008420")]
	[Address(RVA = "0x1259940", Offset = "0x1258740", Length = "0x191")]
	public void UnloadAllEpisodeBanks()
	{
	}

	[Token(Token = "0x6008421")]
	[Address(RVA = "0x1259AE0", Offset = "0x12588E0", Length = "0x25D")]
	public void MaybeLoadEpisodeBanks(List<Bank> loadSoundBankList)
	{
	}

	[Token(Token = "0x6008422")]
	[Address(RVA = "0x1259D40", Offset = "0x1258B40", Length = "0x17C")]
	private void MaybeUnloadOtherEpisodeBanks(List<Bank> loadSoundBankList)
	{
	}

	[Token(Token = "0x6008423")]
	[Address(RVA = "0x1259EC0", Offset = "0x1258CC0", Length = "0x1C3")]
	private void LoadSoundBanks(IEnumerable<Bank> list)
	{
	}

	[Token(Token = "0x6008424")]
	[Address(RVA = "0x125A090", Offset = "0x1258E90", Length = "0x8A")]
	private uint TryLoadSoundbank(Bank bank)
	{
		return 0u;
	}

	[Token(Token = "0x6008425")]
	[Address(RVA = "0x125A120", Offset = "0x1258F20", Length = "0x1FF")]
	public SoundbankLoader()
	{
	}
}
