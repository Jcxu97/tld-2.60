using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x200055F")]
public class ContainerSaveDataProxy
{
	[Token(Token = "0x4003182")]
	[FieldOffset(Offset = "0x10")]
	public Vector3 m_Position;

	[Token(Token = "0x4003183")]
	[FieldOffset(Offset = "0x1C")]
	public Quaternion m_Rotation;

	[Token(Token = "0x4003184")]
	[FieldOffset(Offset = "0x30")]
	public string m_ContainerFilterName;

	[Token(Token = "0x4003185")]
	[FieldOffset(Offset = "0x38")]
	public string m_ContainerSortName;

	[Token(Token = "0x4003186")]
	[FieldOffset(Offset = "0x40")]
	public bool m_InspectedProxy;

	[Token(Token = "0x4003187")]
	[FieldOffset(Offset = "0x41")]
	public bool m_CanNeverBeOpened;

	[Token(Token = "0x4003188")]
	[FieldOffset(Offset = "0x42")]
	public bool m_RolledSpawnChanceProxy;

	[Token(Token = "0x4003189")]
	[FieldOffset(Offset = "0x43")]
	public bool m_NotPopulated;

	[Token(Token = "0x400318A")]
	[FieldOffset(Offset = "0x48")]
	public string m_LockSerialized;

	[Token(Token = "0x400318B")]
	[FieldOffset(Offset = "0x50")]
	public string m_SafeCrackingSerialized;

	[Token(Token = "0x400318C")]
	[FieldOffset(Offset = "0x58")]
	public string m_MissionObjectSerialized;

	[Token(Token = "0x400318D")]
	[FieldOffset(Offset = "0x60")]
	public List<string> m_GearToInstantiateSerialized;

	[Token(Token = "0x400318E")]
	[FieldOffset(Offset = "0x68")]
	public List<ContainerItemSaveData> m_SerializedItems;

	[Token(Token = "0x400318F")]
	[FieldOffset(Offset = "0x70")]
	public List<ContainerDecorationItemSaveData> m_SerializedDecorationItems;

	[Token(Token = "0x6002929")]
	[Address(RVA = "0x8DF990", Offset = "0x8DE790", Length = "0x1E9")]
	public ContainerSaveDataProxy()
	{
	}
}
