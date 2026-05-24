using Cpp2ILInjected;
using UnityEngine;

[CreateAssetMenu(order = 10002)]
[Token(Token = "0x200052B")]
public class RemedyDefinition : ScriptableObject
{
	[Token(Token = "0x4002F97")]
	[FieldOffset(Offset = "0x18")]
	public GameObject m_GearItemPrefab;

	[Token(Token = "0x4002F98")]
	[FieldOffset(Offset = "0x20")]
	private FirstAidItem m_FirstAidItem;

	[Token(Token = "0x6002779")]
	[Address(RVA = "0x8B3880", Offset = "0x8B2680", Length = "0x19F")]
	public bool IsWaterSupply()
	{
		return false;
	}

	[Token(Token = "0x600277A")]
	[Address(RVA = "0x8B3A20", Offset = "0x8B2820", Length = "0x1BD")]
	public string GetDisplayName()
	{
		return null;
	}

	[Token(Token = "0x600277B")]
	[Address(RVA = "0x8B3BE0", Offset = "0x8B29E0", Length = "0x260")]
	public FirstAidItem GetFirstAidItem()
	{
		return null;
	}

	[Token(Token = "0x600277C")]
	[Address(RVA = "0x4A22A0", Offset = "0x4A10A0", Length = "0x7")]
	public RemedyDefinition()
	{
	}
}
