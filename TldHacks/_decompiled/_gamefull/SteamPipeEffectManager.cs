using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x20007EA")]
public class SteamPipeEffectManager : MonoBehaviour
{
	[Token(Token = "0x400549B")]
	[FieldOffset(Offset = "0x20")]
	private List<SteamPipeEffect> m_Effects;

	[Token(Token = "0x6004A9B")]
	[Address(RVA = "0xD3F320", Offset = "0xD3E120", Length = "0xBF")]
	public void Add(SteamPipeEffect effect)
	{
	}

	[Token(Token = "0x6004A9C")]
	[Address(RVA = "0xD3F3E0", Offset = "0xD3E1E0", Length = "0x7F")]
	public void Remove(SteamPipeEffect effect)
	{
	}

	[Token(Token = "0x6004A9D")]
	[Address(RVA = "0xD3F460", Offset = "0xD3E260", Length = "0x28B")]
	private void Update()
	{
	}

	[Token(Token = "0x6004A9E")]
	[Address(RVA = "0xD3F6F0", Offset = "0xD3E4F0", Length = "0xE3")]
	public SteamPipeEffectManager()
	{
	}
}
