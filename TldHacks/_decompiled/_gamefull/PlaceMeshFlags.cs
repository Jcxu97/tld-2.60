using System;
using Cpp2ILInjected;

[Flags]
[Token(Token = "0x20007B3")]
public enum PlaceMeshFlags
{
	[Token(Token = "0x4005304")]
	None = 0,
	[Token(Token = "0x4005305")]
	UseMeshVariant = 1,
	[Token(Token = "0x4005306")]
	UpdateInventoryOnSuccess = 2,
	[Token(Token = "0x4005307")]
	DestroyOnCancel = 4
}
