using Cpp2ILInjected;

namespace MissionTypes;

[Token(Token = "0x2000D44")]
public enum MissionEvent
{
	[Token(Token = "0x40082CC")]
	GearItem_Flare_Brandish,
	[Token(Token = "0x40082CD")]
	GearItem_Flare_Ignite,
	[Token(Token = "0x40082CE")]
	Inventory_ItemAdded,
	[Token(Token = "0x40082CF")]
	Inventory_ItemRemoved,
	[Token(Token = "0x40082D0")]
	Mission_Added,
	[Token(Token = "0x40082D1")]
	Mission_Removed,
	[Token(Token = "0x40082D2")]
	Mission_Completed,
	[Token(Token = "0x40082D3")]
	Weather_Changed,
	[Token(Token = "0x40082D4")]
	PlayerStruggle_GetUpComplete
}
