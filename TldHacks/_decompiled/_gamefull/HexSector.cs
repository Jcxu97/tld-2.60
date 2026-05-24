using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x20009B5")]
public class HexSector : MonoBehaviour
{
	[Token(Token = "0x20009B6")]
	public enum SectorLOD
	{
		[Token(Token = "0x4006333")]
		Unininitialized = -2,
		[Token(Token = "0x4006334")]
		Empty,
		[Token(Token = "0x4006335")]
		LOD0,
		[Token(Token = "0x4006336")]
		LOD1,
		[Token(Token = "0x4006337")]
		LOD2,
		[Token(Token = "0x4006338")]
		Vista,
		[Token(Token = "0x4006339")]
		Culled
	}

	[Header("Local objects")]
	[Token(Token = "0x400632A")]
	[FieldOffset(Offset = "0x20")]
	public List<GameObject> m_GameObjects;

	[Token(Token = "0x400632B")]
	[FieldOffset(Offset = "0x28")]
	public GameObject m_VistaObject;

	[Header("Other sectors")]
	[Token(Token = "0x400632C")]
	[FieldOffset(Offset = "0x30")]
	public List<HexSectorDef> m_SectorDefinitionList;

	[Header("Manual exclusion")]
	[Token(Token = "0x400632D")]
	[FieldOffset(Offset = "0x38")]
	public List<HexSector> m_ExclusionList;

	[Header("Scene links")]
	[Token(Token = "0x400632E")]
	[FieldOffset(Offset = "0x40")]
	public string m_SectorScene;

	[Token(Token = "0x400632F")]
	[FieldOffset(Offset = "0x48")]
	public string m_SectorVista;

	[Header("Performance")]
	[Token(Token = "0x4006330")]
	[FieldOffset(Offset = "0x50")]
	public int m_MaxSectorsPerFrame;

	[Token(Token = "0x4006331")]
	[FieldOffset(Offset = "0x54")]
	private SectorLOD m_CurLod;

	[Token(Token = "0x600563D")]
	[Address(RVA = "0xEB4120", Offset = "0xEB2F20", Length = "0x147")]
	private void Start()
	{
	}

	[Token(Token = "0x600563E")]
	[Address(RVA = "0xEB4270", Offset = "0xEB3070", Length = "0x2E1")]
	public void ProcessExclusionList()
	{
	}

	[Token(Token = "0x600563F")]
	[Address(RVA = "0xEB4560", Offset = "0xEB3360", Length = "0x3E6")]
	public void SetOnlyLOD(SectorLOD newLOD)
	{
	}

	[Token(Token = "0x6005640")]
	[Address(RVA = "0xEB4950", Offset = "0xEB3750", Length = "0x7BB")]
	public void SetSectorLOD(SectorLOD newLOD)
	{
	}

	[Token(Token = "0x6005641")]
	[Address(RVA = "0xEB5110", Offset = "0xEB3F10", Length = "0x1EB")]
	public void SetScene(SectorLOD newLOD)
	{
	}

	[Token(Token = "0x6005642")]
	[Address(RVA = "0xEB5300", Offset = "0xEB4100", Length = "0x103")]
	private bool IsScene_CurrentlyLoaded(string sceneName_no_extention)
	{
		return false;
	}

	[Token(Token = "0x6005643")]
	[Address(RVA = "0xEB5410", Offset = "0xEB4210", Length = "0x13B")]
	private void SectorError(string sectorName, int objIndex)
	{
	}

	[Token(Token = "0x6005644")]
	[Address(RVA = "0xEB5550", Offset = "0xEB4350", Length = "0x51")]
	public HexSector()
	{
	}
}
