using Cpp2ILInjected;
using NodeCanvas.Framework;
using ParadoxNotion.Design;

namespace NodeCanvas.Tasks.Actions;

[Name("Add Mission Marker To Map", 0)]
[Category("TLD Mission UI/Map")]
[Token(Token = "0x200123D")]
public class Action_AddMissionMarkerToMap : ActionTask
{
	[Token(Token = "0x4008A6A")]
	[FieldOffset(Offset = "0x68")]
	public BBParameter<string> markerID;

	[Token(Token = "0x4008A6B")]
	[FieldOffset(Offset = "0x70")]
	private int retryCounter;

	[Token(Token = "0x1700098F")]
	protected override string info
	{
		[Token(Token = "0x6007787")]
		[Address(RVA = "0x115DB30", Offset = "0x115C930", Length = "0xC7")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6007788")]
	[Address(RVA = "0x115DC00", Offset = "0x115CA00", Length = "0x162")]
	protected override void OnUpdate()
	{
	}

	[Token(Token = "0x6007789")]
	[Address(RVA = "0x115DD70", Offset = "0x115CB70", Length = "0xDC")]
	protected override void OnExecute()
	{
	}

	[Token(Token = "0x600778A")]
	[Address(RVA = "0x115DE50", Offset = "0x115CC50", Length = "0x12F")]
	public Action_AddMissionMarkerToMap()
	{
	}
}
