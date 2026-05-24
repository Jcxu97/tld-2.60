using Cpp2ILInjected;

namespace NodeCanvas.StateMachines;

[Token(Token = "0x20010BD")]
public interface ITLDCustomManagedObjectOwner
{
	[Token(Token = "0x6007181")]
	void AddCustomManagedObject(string name, bool reqState);

	[Token(Token = "0x6007182")]
	void RemoveCustomManagedObject(string name);
}
