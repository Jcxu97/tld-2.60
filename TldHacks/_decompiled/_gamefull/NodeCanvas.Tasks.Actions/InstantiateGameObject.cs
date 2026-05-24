using Cpp2ILInjected;
using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;

namespace NodeCanvas.Tasks.Actions;

[Category("GameObject")]
[Token(Token = "0x20012CC")]
public class InstantiateGameObject : ActionTask<Transform>
{
	[Token(Token = "0x4008BE1")]
	[FieldOffset(Offset = "0x68")]
	public BBParameter<Transform> parent;

	[Token(Token = "0x4008BE2")]
	[FieldOffset(Offset = "0x70")]
	public BBParameter<Vector3> clonePosition;

	[Token(Token = "0x4008BE3")]
	[FieldOffset(Offset = "0x78")]
	public BBParameter<Vector3> cloneRotation;

	[BlackboardOnly]
	[Token(Token = "0x4008BE4")]
	[FieldOffset(Offset = "0x80")]
	public BBParameter<GameObject> saveCloneAs;

	[Token(Token = "0x170009F3")]
	protected override string info
	{
		[Token(Token = "0x6007935")]
		[Address(RVA = "0x1177DE0", Offset = "0x1176BE0", Length = "0x2D3")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6007936")]
	[Address(RVA = "0x11780C0", Offset = "0x1176EC0", Length = "0x29B")]
	protected override void OnExecute()
	{
	}

	[Token(Token = "0x6007937")]
	[Address(RVA = "0x1178360", Offset = "0x1177160", Length = "0x44")]
	public InstantiateGameObject()
	{
	}
}
