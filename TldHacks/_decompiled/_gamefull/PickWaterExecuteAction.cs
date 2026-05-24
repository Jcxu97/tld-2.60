using Cpp2ILInjected;

[Token(Token = "0x20006B2")]
public enum PickWaterExecuteAction
{
	[Token(Token = "0x4004723")]
	DropWaterSupply,
	[Token(Token = "0x4004724")]
	TakeFromWaterSource,
	[Token(Token = "0x4004725")]
	TransferInventoryToContainer,
	[Token(Token = "0x4004726")]
	TransferContainerToInventory,
	[Token(Token = "0x4004727")]
	GenericTransfer
}
