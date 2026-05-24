using System.Collections.Generic;
using Cpp2ILInjected;
using TLD.ModularElectrolizer;
using UnityEngine;

[Token(Token = "0x200035C")]
public class AuroraElectrolizerControlVolume : MonoBehaviour
{
	[Token(Token = "0x200035D")]
	public enum LocalOverride
	{
		[Token(Token = "0x4001DA7")]
		UseAurora,
		[Token(Token = "0x4001DA8")]
		ForceOff
	}

	[Header("Control volume information")]
	[Token(Token = "0x4001D9D")]
	[FieldOffset(Offset = "0x20")]
	public string m_VolumeName;

	[Token(Token = "0x4001D9E")]
	[FieldOffset(Offset = "0x28")]
	public int m_VolumeID;

	[Header("Objects to control")]
	[Token(Token = "0x4001D9F")]
	[FieldOffset(Offset = "0x30")]
	public List<AuroraModularElectrolizer> m_ElectrolizerList;

	[Token(Token = "0x4001DA0")]
	[FieldOffset(Offset = "0x38")]
	public List<AuroraLightingSimple> m_SimpleLightList;

	[Token(Token = "0x4001DA1")]
	[FieldOffset(Offset = "0x40")]
	public List<Light> m_LooseLightList;

	[SerializeField]
	[Token(Token = "0x4001DA2")]
	[FieldOffset(Offset = "0x48")]
	private ElectrifiedWater[] m_ElectrifiedWater;

	[Header("Sandbox controls")]
	[Token(Token = "0x4001DA3")]
	[FieldOffset(Offset = "0x50")]
	public LocalOverride m_SandboxOverride;

	[Token(Token = "0x4001DA4")]
	[FieldOffset(Offset = "0x54")]
	private bool m_IsActivated;

	[Token(Token = "0x4001DA5")]
	[FieldOffset(Offset = "0x55")]
	private bool m_HasSetPowerState;

	[Token(Token = "0x6001B62")]
	[Address(RVA = "0x75F2D0", Offset = "0x75E0D0", Length = "0x6AA")]
	public void SetPowerState(bool isActive)
	{
	}

	[Token(Token = "0x6001B63")]
	[Address(RVA = "0x4B4490", Offset = "0x4B3290", Length = "0x5")]
	public bool IsActivated()
	{
		return false;
	}

	[Token(Token = "0x6001B64")]
	[Address(RVA = "0x75F980", Offset = "0x75E780", Length = "0x5")]
	public bool HasSetPowerState()
	{
		return false;
	}

	[Token(Token = "0x6001B65")]
	[Address(RVA = "0x75F990", Offset = "0x75E790", Length = "0x121")]
	public void Initialize()
	{
	}

	[Token(Token = "0x6001B66")]
	[Address(RVA = "0x4AF5E0", Offset = "0x4AE3E0", Length = "0x43")]
	public AuroraElectrolizerControlVolume()
	{
	}
}
