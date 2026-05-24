using Cpp2ILInjected;
using NodeCanvas.Framework;
using ParadoxNotion.Design;

namespace NodeCanvas.Tasks.Actions;

[Name("Reveal Map Icon", 0)]
[Description("Reveal a location on the map. Location Name refers to the scene name of the LoadScene, or the trigger ID of the IndoorSpaceTrigger.")]
[Category("TLD Mission UI/Map")]
[Token(Token = "0x200123F")]
public class Action_RevealMapLocation : ActionTask
{
	[Token(Token = "0x4008A6D")]
	[FieldOffset(Offset = "0x68")]
	public BBParameter<string> markerID;

	[Token(Token = "0x4008A6E")]
	[FieldOffset(Offset = "0x70")]
	public BBParameter<bool> revealLocationNameBB;

	[Token(Token = "0x17000991")]
	protected override string info
	{
		[Token(Token = "0x600778E")]
		[Address(RVA = "0x115E250", Offset = "0x115D050", Length = "0xC7")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600778F")]
	[Address(RVA = "0x115E320", Offset = "0x115D120", Length = "0x105")]
	protected override void OnExecute()
	{
	}

	[Token(Token = "0x6007790")]
	[Address(RVA = "0x115E430", Offset = "0x115D230", Length = "0x215")]
	public Action_RevealMapLocation()
	{
	}
}
