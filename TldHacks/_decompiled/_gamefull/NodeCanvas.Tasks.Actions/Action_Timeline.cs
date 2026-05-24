using Cpp2ILInjected;
using NodeCanvas.Framework;
using TLD.AddressableAssets;

namespace NodeCanvas.Tasks.Actions;

[Token(Token = "0x200122D")]
public abstract class Action_Timeline : ActionTask
{
	[Token(Token = "0x4008A22")]
	[FieldOffset(Offset = "0x68")]
	public AssetReferenceTimeline m_TimelineReference;

	[Token(Token = "0x17000981")]
	protected override string info
	{
		[Token(Token = "0x600774F")]
		[Address(RVA = "0x115AD30", Offset = "0x1159B30", Length = "0xA6")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000982")]
	protected abstract string TimelineActionName
	{
		[Token(Token = "0x6007750")]
		get;
	}

	[Token(Token = "0x6007751")]
	[Address(RVA = "0x115ADE0", Offset = "0x1159BE0", Length = "0x56")]
	protected override void OnExecute()
	{
	}

	[Token(Token = "0x6007752")]
	protected abstract void ExecuteTimelineAction();

	[Token(Token = "0x6007753")]
	[Address(RVA = "0xD769F0", Offset = "0xD757F0", Length = "0x8")]
	protected Action_Timeline()
	{
	}
}
