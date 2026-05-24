using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.AddressableAssets;

[CreateAssetMenu(fileName = "DecorationItemVerificationList", menuName = "Decoration Item Verification List")]
[Token(Token = "0x20002B0")]
public class DecorationItemVerificationList : ScriptableObject
{
	[Token(Token = "0x40017EA")]
	public const int INVALID_INDEX = -1;

	[Token(Token = "0x40017EB")]
	public static DecorationItemVerificationList s_Instance;

	[SerializeField]
	[Token(Token = "0x40017EC")]
	[FieldOffset(Offset = "0x18")]
	private List<AssetReference> m_DecorationPrefabs;

	[Token(Token = "0x40017ED")]
	[FieldOffset(Offset = "0x20")]
	private int m_LastSpawnIndex;

	[Token(Token = "0x170001EF")]
	public int Count
	{
		[Token(Token = "0x60016E6")]
		[Address(RVA = "0x6C38E0", Offset = "0x6C26E0", Length = "0x41")]
		get
		{
			return 0;
		}
	}

	[Token(Token = "0x60016E7")]
	[Address(RVA = "0x6C3930", Offset = "0x6C2730", Length = "0x1C8")]
	public static DecorationItemVerificationList Load()
	{
		return null;
	}

	[Token(Token = "0x60016E8")]
	[Address(RVA = "0x6C3B00", Offset = "0x6C2900", Length = "0x908")]
	public void SpawnDecorationItem(int spawnIndex)
	{
	}

	[Token(Token = "0x60016E9")]
	[Address(RVA = "0x6C4410", Offset = "0x6C3210", Length = "0xD")]
	public void SpawnNextDecorationItem()
	{
	}

	[Token(Token = "0x60016EA")]
	[Address(RVA = "0x6C4420", Offset = "0x6C3220", Length = "0x501")]
	public void ExportDecorationItemCsv()
	{
	}

	[Token(Token = "0x60016EB")]
	[Address(RVA = "0x6C4930", Offset = "0x6C3730", Length = "0xB6")]
	public DecorationItemVerificationList()
	{
	}
}
