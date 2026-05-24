using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using TLD.UI.Generics;
using UnityEngine;

[Token(Token = "0x2000A0A")]
public class FPSCounter : MonoBehaviour
{
	[Token(Token = "0x40065CC")]
	[FieldOffset(Offset = "0x20")]
	public float m_updateInterval;

	[Header("Panel References")]
	[SerializeField]
	[Token(Token = "0x40065CD")]
	[FieldOffset(Offset = "0x28")]
	private PanelReference<Panel_HUD> m_HUD;

	[Token(Token = "0x40065CF")]
	[FieldOffset(Offset = "0x38")]
	private float m_Accum;

	[Token(Token = "0x40065D0")]
	[FieldOffset(Offset = "0x3C")]
	private int m_Frames;

	[Token(Token = "0x40065D1")]
	[FieldOffset(Offset = "0x40")]
	private float m_Timeleft;

	[Token(Token = "0x40065D2")]
	[FieldOffset(Offset = "0x44")]
	private float m_FPS;

	[Token(Token = "0x40065D3")]
	[FieldOffset(Offset = "0x48")]
	private long m_AllocatedMemory;

	[Token(Token = "0x40065D4")]
	[FieldOffset(Offset = "0x50")]
	private long m_ReservedMemory;

	[Token(Token = "0x40065D5")]
	[FieldOffset(Offset = "0x58")]
	private long m_GraphicsMemory;

	[Token(Token = "0x40065D6")]
	[FieldOffset(Offset = "0x60")]
	private ulong m_TextureMemory;

	[Token(Token = "0x40065D7")]
	[FieldOffset(Offset = "0x68")]
	private double m_GPUTimeMs;

	[Token(Token = "0x40065D8")]
	[FieldOffset(Offset = "0x70")]
	private double m_CPUTimeMs;

	[Token(Token = "0x14000019")]
	public event Action<FPSCounterEvent> FPSChanged
	{
		[CompilerGenerated]
		[Token(Token = "0x6005839")]
		[Address(RVA = "0xEE20C0", Offset = "0xEE0EC0", Length = "0x166")]
		add
		{
		}
		[CompilerGenerated]
		[Token(Token = "0x600583A")]
		[Address(RVA = "0xEE2230", Offset = "0xEE1030", Length = "0x166")]
		remove
		{
		}
	}

	[Token(Token = "0x600583B")]
	[Address(RVA = "0xEE23A0", Offset = "0xEE11A0", Length = "0xE")]
	public void Start()
	{
	}

	[Token(Token = "0x600583C")]
	[Address(RVA = "0xEE23B0", Offset = "0xEE11B0", Length = "0x47C")]
	public void Update()
	{
	}

	[Token(Token = "0x600583D")]
	[Address(RVA = "0xEE2830", Offset = "0xEE1630", Length = "0x86")]
	private void UpdateGUI()
	{
	}

	[Token(Token = "0x600583E")]
	[Address(RVA = "0x7AF8D0", Offset = "0x7AE6D0", Length = "0x4A")]
	public FPSCounter()
	{
	}
}
