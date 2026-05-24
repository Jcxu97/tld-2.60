using Cpp2ILInjected;
using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;

namespace NodeCanvas.Tasks.Actions;

[Category("GameObject")]
[Token(Token = "0x20012CE")]
public class RemoveComponent<T> : ActionTask<Transform> where T : Component
{
	[Tooltip("DestroyImmediately is recomended if you are destroying objects in use of the framework.")]
	[Token(Token = "0x4008BE7")]
	[FieldOffset(Offset = "0x0")]
	public bool immediately;

	[Token(Token = "0x170009F5")]
	protected override string info
	{
		[Token(Token = "0x600793D")]
		[Address(RVA = "0x1FC3180", Offset = "0x1FC1F80", Length = "0xEF")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600793E")]
	[Address(RVA = "0x1FC3270", Offset = "0x1FC2070", Length = "0x22B")]
	protected override void OnExecute()
	{
	}

	[Token(Token = "0x600793F")]
	[Address(RVA = "0x1FC34A0", Offset = "0x1FC22A0", Length = "0x44")]
	public RemoveComponent()
	{
	}
}
