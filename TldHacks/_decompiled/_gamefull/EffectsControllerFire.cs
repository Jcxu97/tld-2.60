using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x2000384")]
public class EffectsControllerFire : MonoBehaviour
{
	[Token(Token = "0x4001F64")]
	[FieldOffset(Offset = "0x20")]
	public Transform stage00_Embers;

	[Token(Token = "0x4001F65")]
	[FieldOffset(Offset = "0x28")]
	public Transform stage01_Small;

	[Token(Token = "0x4001F66")]
	[FieldOffset(Offset = "0x30")]
	public Transform stage02_Medium;

	[Token(Token = "0x4001F67")]
	[FieldOffset(Offset = "0x38")]
	public Transform stage03_Large;

	[Token(Token = "0x4001F68")]
	[FieldOffset(Offset = "0x40")]
	public Transform stage04_Full;

	[Token(Token = "0x4001F69")]
	[FieldOffset(Offset = "0x48")]
	public Transform accelrant;

	[Token(Token = "0x4001F6A")]
	[FieldOffset(Offset = "0x50")]
	public Transform otherFX;

	[Token(Token = "0x4001F6B")]
	[FieldOffset(Offset = "0x58")]
	public Transform flareupSmallFX;

	[Token(Token = "0x4001F6C")]
	[FieldOffset(Offset = "0x60")]
	public Transform flareupLargeFX;

	[Token(Token = "0x4001F6D")]
	[FieldOffset(Offset = "0x68")]
	public Transform lighting;

	[Token(Token = "0x4001F6E")]
	[FieldOffset(Offset = "0x70")]
	private List<ParticleSystem> l_StartingEmbers;

	[Token(Token = "0x4001F6F")]
	[FieldOffset(Offset = "0x78")]
	private List<ParticleSystem> l_StartingSmall;

	[Token(Token = "0x4001F70")]
	[FieldOffset(Offset = "0x80")]
	private List<ParticleSystem> l_StartingMedium;

	[Token(Token = "0x4001F71")]
	[FieldOffset(Offset = "0x88")]
	private List<ParticleSystem> l_StartingLarge;

	[Token(Token = "0x4001F72")]
	[FieldOffset(Offset = "0x90")]
	private List<ParticleSystem> l_Fullburn;

	[Token(Token = "0x4001F73")]
	[FieldOffset(Offset = "0x98")]
	private List<ParticleSystem> l_Accelerant;

	[Token(Token = "0x4001F74")]
	[FieldOffset(Offset = "0xA0")]
	private List<ParticleSystem> l_OtherFX;

	[Token(Token = "0x4001F75")]
	[FieldOffset(Offset = "0xA8")]
	private List<ParticleSystem> l_FlareupSmallFX;

	[Token(Token = "0x4001F76")]
	[FieldOffset(Offset = "0xB0")]
	private List<ParticleSystem> l_FlareupLargeFX;

	[Token(Token = "0x4001F77")]
	[FieldOffset(Offset = "0xB8")]
	private List<Light> l_Lighting;

	[Token(Token = "0x4001F78")]
	[FieldOffset(Offset = "0xC0")]
	private bool isInitialized;

	[Token(Token = "0x4001F79")]
	[FieldOffset(Offset = "0xC1")]
	private bool usePrint;

	[Token(Token = "0x4001F7A")]
	[FieldOffset(Offset = "0xC8")]
	private Dictionary<ParticleSystem, bool> m_ParticlePlayStates;

	[Token(Token = "0x6001C37")]
	[Address(RVA = "0x77AB60", Offset = "0x779960", Length = "0x11")]
	private void Awake()
	{
	}

	[Token(Token = "0x6001C38")]
	[Address(RVA = "0x77AB60", Offset = "0x779960", Length = "0x11")]
	private void Start()
	{
	}

	[Token(Token = "0x6001C39")]
	[Address(RVA = "0x77AB80", Offset = "0x779980", Length = "0x24B")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6001C3A")]
	[Address(RVA = "0x77ADD0", Offset = "0x779BD0", Length = "0x43C")]
	public void TriggerStage(FireState curState, bool shouldPlay, bool stopOtherStages = false)
	{
	}

	[Token(Token = "0x6001C3B")]
	[Address(RVA = "0x77B230", Offset = "0x77A030", Length = "0xBE")]
	public void TriggerFlareupLarge()
	{
	}

	[Token(Token = "0x6001C3C")]
	[Address(RVA = "0x77B2F0", Offset = "0x77A0F0", Length = "0xCC")]
	public void StopAllStageFX()
	{
	}

	[Token(Token = "0x6001C3D")]
	[Address(RVA = "0x77B3C0", Offset = "0x77A1C0", Length = "0x2B5")]
	public void StopAllFX()
	{
	}

	[Token(Token = "0x6001C3E")]
	[Address(RVA = "0x77B680", Offset = "0x77A480", Length = "0x1CE")]
	public void DeactivateAllFX()
	{
	}

	[Token(Token = "0x6001C3F")]
	[Address(RVA = "0x77B850", Offset = "0x77A650", Length = "0x993")]
	private void Initialize()
	{
	}

	[Token(Token = "0x6001C40")]
	[Address(RVA = "0x77C1F0", Offset = "0x77AFF0", Length = "0xD6")]
	private void LocalPrint(string text)
	{
	}

	[Token(Token = "0x6001C41")]
	[Address(RVA = "0x77C2D0", Offset = "0x77B0D0", Length = "0x1DA")]
	private void TriggerParticleSystems(List<ParticleSystem> particleSystems, bool shouldPlay)
	{
	}

	[Token(Token = "0x6001C42")]
	[Address(RVA = "0x77C4B0", Offset = "0x77B2B0", Length = "0xF2")]
	public EffectsControllerFire()
	{
	}
}
