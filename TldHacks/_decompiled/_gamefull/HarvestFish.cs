using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.ResourceManagement.AsyncOperations;

[Token(Token = "0x20004AE")]
public class HarvestFish : HarvestBase
{
	[SerializeField]
	[Token(Token = "0x4002B4A")]
	[FieldOffset(Offset = "0x48")]
	private AssetReferenceGearItem m_BaitReference;

	[SerializeField]
	[Token(Token = "0x4002B4B")]
	[FieldOffset(Offset = "0x50")]
	private float m_BaitPerKG;

	[Token(Token = "0x4002B4C")]
	[FieldOffset(Offset = "0x58")]
	private GearItem m_GearItem;

	[Token(Token = "0x4002B4D")]
	[FieldOffset(Offset = "0x60")]
	private AsyncOperationHandle<GameObject> m_BaitHandle;

	[Token(Token = "0x4002B4E")]
	[FieldOffset(Offset = "0x78")]
	private GearItem m_BaitPrefab;

	[Token(Token = "0x1700023B")]
	public override int YieldCount
	{
		[Token(Token = "0x60023D7")]
		[Address(RVA = "0x85E4A0", Offset = "0x85D2A0", Length = "0x5D")]
		get
		{
			return 0;
		}
	}

	[Token(Token = "0x60023D8")]
	[Address(RVA = "0x85E500", Offset = "0x85D300", Length = "0x8C")]
	private void Awake()
	{
	}

	[Token(Token = "0x60023D9")]
	[Address(RVA = "0x85E590", Offset = "0x85D390", Length = "0x13D")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x60023DA")]
	[Address(RVA = "0x85E6D0", Offset = "0x85D4D0", Length = "0x2F2")]
	public override GearItem GetPrefab(int index)
	{
		return null;
	}

	[Token(Token = "0x60023DB")]
	[Address(RVA = "0x85E9D0", Offset = "0x85D7D0", Length = "0xA2")]
	public override int GetAmount(int index)
	{
		return 0;
	}

	[Token(Token = "0x60023DC")]
	[Address(RVA = "0x85E430", Offset = "0x85D230", Length = "0x4A")]
	public HarvestFish()
	{
	}
}
