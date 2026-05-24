using Cpp2ILInjected;
using ParadoxNotion.Design;
using TLD.AddressableAssets;

namespace NodeCanvas.Tasks.Actions;

[Name("Load Timeline", 0)]
[Category("TLD Actions/Timeline")]
[Token(Token = "0x200122F")]
public class Action_LoadTimeline : Action_Timeline
{
	[Token(Token = "0x17000984")]
	protected override string TimelineActionName
	{
		[Token(Token = "0x6007757")]
		[Address(RVA = "0x115AEB0", Offset = "0x1159CB0", Length = "0x31")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6007758")]
	[Address(RVA = "0x115AEF0", Offset = "0x1159CF0", Length = "0x93")]
	protected override void ExecuteTimelineAction()
	{
	}

	[Token(Token = "0x6007759")]
	[Address(RVA = "0x115AF90", Offset = "0x1159D90", Length = "0x32")]
	private void OnDoneLoading(AssetReferenceTimeline timeline)
	{
	}

	[Token(Token = "0x600775A")]
	[Address(RVA = "0xD769F0", Offset = "0xD757F0", Length = "0x8")]
	public Action_LoadTimeline()
	{
	}
}
