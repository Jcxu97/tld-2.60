using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x2000882")]
public class GenericClothingSlotSpawner : MonoBehaviour
{
	[Token(Token = "0x40057D5")]
	[FieldOffset(Offset = "0x20")]
	public GameObject m_Prefab;

	[Token(Token = "0x40057D6")]
	[FieldOffset(Offset = "0x28")]
	public string m_EmptySlotSpriteName;

	[Token(Token = "0x40057D7")]
	[FieldOffset(Offset = "0x30")]
	public ClothingRegion m_ClothingRegion;

	[Token(Token = "0x40057D8")]
	[FieldOffset(Offset = "0x34")]
	public ClothingLayer m_ClothingLayer;

	[Token(Token = "0x40057D9")]
	[FieldOffset(Offset = "0x38")]
	public int m_LayoutColumnIndex;

	[Token(Token = "0x40057DA")]
	[FieldOffset(Offset = "0x3C")]
	public int m_LayoutRowIndex;

	[Token(Token = "0x40057DB")]
	[FieldOffset(Offset = "0x40")]
	public bool m_HasAltLayoutIndex;

	[Token(Token = "0x40057DC")]
	[FieldOffset(Offset = "0x44")]
	public int m_AltLayoutColumnIndex;

	[Token(Token = "0x40057DD")]
	[FieldOffset(Offset = "0x48")]
	public int m_AltLayoutRowIndex;

	[Token(Token = "0x40057DE")]
	[FieldOffset(Offset = "0x50")]
	public UITexture[] m_PaperDollSlots;

	[Token(Token = "0x40057DF")]
	[FieldOffset(Offset = "0x58")]
	public string m_LayerLocID;

	[HideInInspector]
	[Token(Token = "0x40057E0")]
	[FieldOffset(Offset = "0x60")]
	public GameObject m_SpawnedObject;

	[HideInInspector]
	[Token(Token = "0x40057E1")]
	[FieldOffset(Offset = "0x68")]
	public ClothingSlot m_ClothingSlot;

	[Token(Token = "0x6004DC8")]
	[Address(RVA = "0xD92C80", Offset = "0xD91A80", Length = "0x15B")]
	public void Awake()
	{
	}

	[Token(Token = "0x6004DC9")]
	[Address(RVA = "0xD92DE0", Offset = "0xD91BE0", Length = "0x420")]
	public void AssignValuesToSpawnedObject()
	{
	}

	[Token(Token = "0x6004DCA")]
	[Address(RVA = "0xD93210", Offset = "0xD92010", Length = "0x21B")]
	public void InstantiateObjectIfNoneExists()
	{
	}

	[Token(Token = "0x6004DCB")]
	[Address(RVA = "0x4AF5E0", Offset = "0x4AE3E0", Length = "0x43")]
	public GenericClothingSlotSpawner()
	{
	}
}
