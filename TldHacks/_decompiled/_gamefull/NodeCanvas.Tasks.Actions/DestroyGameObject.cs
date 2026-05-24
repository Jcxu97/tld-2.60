using Cpp2ILInjected;
using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;

namespace NodeCanvas.Tasks.Actions;

[Category("GameObject")]
[Token(Token = "0x20012BD")]
public class DestroyGameObject : ActionTask<Transform>
{
	[Tooltip("DestroyImmediately is recomended if you are destroying objects in use of the framework.")]
	[Token(Token = "0x4008BC4")]
	[FieldOffset(Offset = "0x68")]
	public bool immediately;

	[Token(Token = "0x170009E9")]
	protected override string info
	{
		[Token(Token = "0x600790A")]
		[Address(RVA = "0x1175670", Offset = "0x1174470", Length = "0xC0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600790B")]
	[Address(RVA = "0x1175730", Offset = "0x1174530", Length = "0x1C3")]
	protected override void OnUpdate()
	{
	}

	[Token(Token = "0x600790C")]
	[Address(RVA = "0x1175900", Offset = "0x1174700", Length = "0x44")]
	public DestroyGameObject()
	{
	}
}
