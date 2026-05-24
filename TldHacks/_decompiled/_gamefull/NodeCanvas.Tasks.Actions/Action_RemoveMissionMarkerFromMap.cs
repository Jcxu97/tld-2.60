using Cpp2ILInjected;
using NodeCanvas.Framework;
using ParadoxNotion.Design;

namespace NodeCanvas.Tasks.Actions;

[Name("Remove Mission Marker From Map", 0)]
[Category("TLD Mission UI/Map")]
[Token(Token = "0x200123E")]
public class Action_RemoveMissionMarkerFromMap : ActionTask
{
	[Token(Token = "0x4008A6C")]
	[FieldOffset(Offset = "0x68")]
	public BBParameter<string> markerID;

	[Token(Token = "0x17000990")]
	protected override string info
	{
		[Token(Token = "0x600778B")]
		[Address(RVA = "0x115DF80", Offset = "0x115CD80", Length = "0xC7")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600778C")]
	[Address(RVA = "0x115E050", Offset = "0x115CE50", Length = "0xCE")]
	protected override void OnExecute()
	{
	}

	[Token(Token = "0x600778D")]
	[Address(RVA = "0x115E120", Offset = "0x115CF20", Length = "0x128")]
	public Action_RemoveMissionMarkerFromMap()
	{
	}
}
