using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x2000881")]
public class GenericButtonMouseSpawner : MonoBehaviour
{
	[Token(Token = "0x40057CC")]
	[FieldOffset(Offset = "0x20")]
	public GameObject m_Prefab;

	[Token(Token = "0x40057CD")]
	[FieldOffset(Offset = "0x28")]
	public string m_LocID;

	[Tooltip("If left at zero, the base prefab width will be used")]
	[Token(Token = "0x40057CE")]
	[FieldOffset(Offset = "0x30")]
	public int m_BackgroundWidthOverride;

	[Tooltip("If left at zero, the base prefab width will be used")]
	[Token(Token = "0x40057CF")]
	[FieldOffset(Offset = "0x34")]
	public int m_BackgroundHeightOverride;

	[Tooltip("If left at zero, the base prefab width will be used")]
	[Token(Token = "0x40057D0")]
	[FieldOffset(Offset = "0x38")]
	public int m_InnerGlowWidthOverride;

	[Tooltip("If left at zero, the base prefab width will be used")]
	[Token(Token = "0x40057D1")]
	[FieldOffset(Offset = "0x3C")]
	public int m_BackGlowWidthOverride;

	[Token(Token = "0x40057D2")]
	[FieldOffset(Offset = "0x40")]
	public List<EventDelegate> onClick;

	[HideInInspector]
	[Token(Token = "0x40057D3")]
	[FieldOffset(Offset = "0x48")]
	public GameObject m_SpawnedObject;

	[Token(Token = "0x40057D4")]
	[FieldOffset(Offset = "0x50")]
	private UIButton[] m_UIButtonArray;

	[Token(Token = "0x6004DC0")]
	[Address(RVA = "0xD91540", Offset = "0xD90340", Length = "0x15B")]
	public void Awake()
	{
	}

	[Token(Token = "0x6004DC1")]
	[Address(RVA = "0xD916A0", Offset = "0xD904A0", Length = "0xE67")]
	public void AssignValuesToSpawnedObject()
	{
	}

	[Token(Token = "0x6004DC2")]
	[Address(RVA = "0xD92510", Offset = "0xD91310", Length = "0x291")]
	public void SetLocID(string locID)
	{
	}

	[Token(Token = "0x6004DC3")]
	[Address(RVA = "0xD927B0", Offset = "0xD915B0", Length = "0x13A")]
	public void SetText(string text)
	{
	}

	[Token(Token = "0x6004DC4")]
	[Address(RVA = "0xD928F0", Offset = "0xD916F0", Length = "0x1B6")]
	public void EnableMouseButton(bool isEnabled)
	{
	}

	[Token(Token = "0x6004DC5")]
	[Address(RVA = "0x6A6BE0", Offset = "0x6A59E0", Length = "0x1E")]
	public void ShowMouseButton(bool show)
	{
	}

	[Token(Token = "0x6004DC6")]
	[Address(RVA = "0xD92AB0", Offset = "0xD918B0", Length = "0xD4")]
	private void InstantiateObjectIfNoneExists()
	{
	}

	[Token(Token = "0x6004DC7")]
	[Address(RVA = "0xD92B90", Offset = "0xD91990", Length = "0xE3")]
	public GenericButtonMouseSpawner()
	{
	}
}
