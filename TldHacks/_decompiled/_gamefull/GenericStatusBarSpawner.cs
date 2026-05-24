using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x2000886")]
public class GenericStatusBarSpawner : MonoBehaviour
{
	[Token(Token = "0x40057FB")]
	[FieldOffset(Offset = "0x20")]
	public GameObject m_Prefab;

	[Token(Token = "0x40057FC")]
	[FieldOffset(Offset = "0x28")]
	public StatusBar.StatusBarType m_StatusBarType;

	[Tooltip("A rate of change above this value will be considered medium")]
	[Token(Token = "0x40057FD")]
	[FieldOffset(Offset = "0x2C")]
	public float m_MediumThreshold;

	[Tooltip("A rate of change above this value will be considered high")]
	[Token(Token = "0x40057FE")]
	[FieldOffset(Offset = "0x30")]
	public float m_HighThreshold;

	[Token(Token = "0x40057FF")]
	[FieldOffset(Offset = "0x38")]
	public string m_MainSpriteName;

	[Token(Token = "0x4005800")]
	[FieldOffset(Offset = "0x40")]
	public string m_EmptySpriteName;

	[Token(Token = "0x4005801")]
	[FieldOffset(Offset = "0x48")]
	public bool m_IsOnHUD;

	[HideInInspector]
	[Token(Token = "0x4005802")]
	[FieldOffset(Offset = "0x50")]
	public GameObject m_SpawnedObject;

	[HideInInspector]
	[Token(Token = "0x4005803")]
	[FieldOffset(Offset = "0x58")]
	public StatusBar m_SpawnedStatusBar;

	[Token(Token = "0x6004DD8")]
	[Address(RVA = "0xD953D0", Offset = "0xD941D0", Length = "0x1EC")]
	public void Awake()
	{
	}

	[Token(Token = "0x6004DD9")]
	[Address(RVA = "0xD955C0", Offset = "0xD943C0", Length = "0x2D9")]
	public void AssignValuesToSpawnedObject()
	{
	}

	[Token(Token = "0x6004DDA")]
	[Address(RVA = "0x4AF5E0", Offset = "0x4AE3E0", Length = "0x43")]
	public GenericStatusBarSpawner()
	{
	}
}
