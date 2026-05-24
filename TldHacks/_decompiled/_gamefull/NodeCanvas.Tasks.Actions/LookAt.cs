using Cpp2ILInjected;
using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;

namespace NodeCanvas.Tasks.Actions;

[Category("GameObject")]
[Token(Token = "0x20012CD")]
public class LookAt : ActionTask<Transform>
{
	[RequiredField]
	[Token(Token = "0x4008BE5")]
	[FieldOffset(Offset = "0x68")]
	public BBParameter<GameObject> lookTarget;

	[Token(Token = "0x4008BE6")]
	[FieldOffset(Offset = "0x70")]
	public bool repeat;

	[Token(Token = "0x170009F4")]
	protected override string info
	{
		[Token(Token = "0x6007938")]
		[Address(RVA = "0x11783B0", Offset = "0x11771B0", Length = "0x64")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6007939")]
	[Address(RVA = "0x1178420", Offset = "0x1177220", Length = "0x7")]
	protected override void OnExecute()
	{
	}

	[Token(Token = "0x600793A")]
	[Address(RVA = "0x1178420", Offset = "0x1177220", Length = "0x7")]
	protected override void OnUpdate()
	{
	}

	[Token(Token = "0x600793B")]
	[Address(RVA = "0x1178430", Offset = "0x1177230", Length = "0x2A2")]
	private void DoLook()
	{
	}

	[Token(Token = "0x600793C")]
	[Address(RVA = "0x11786E0", Offset = "0x11774E0", Length = "0x44")]
	public LookAt()
	{
	}
}
