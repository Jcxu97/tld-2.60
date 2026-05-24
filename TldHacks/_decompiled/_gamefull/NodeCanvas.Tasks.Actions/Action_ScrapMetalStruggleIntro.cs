using Cpp2ILInjected;
using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;

namespace NodeCanvas.Tasks.Actions;

[Name("ScrapMetalStruggleIntro", 0)]
[Description("Used to spawn object, and tap to trigger animation")]
[Category("TLD Actions/Objects")]
[Token(Token = "0x2001229")]
public class Action_ScrapMetalStruggleIntro : ActionTask
{
	[Token(Token = "0x4008A17")]
	[FieldOffset(Offset = "0x68")]
	public GameObject m_PropPrefab;

	[Token(Token = "0x4008A18")]
	[FieldOffset(Offset = "0x70")]
	private GameObject m_SpawnedProp;

	[Token(Token = "0x6007743")]
	[Address(RVA = "0x1159CB0", Offset = "0x1158AB0", Length = "0x7E")]
	protected override void OnExecute()
	{
	}

	[Token(Token = "0x6007744")]
	[Address(RVA = "0x1159D30", Offset = "0x1158B30", Length = "0x692")]
	private void MaybeSpawnProp()
	{
	}

	[Token(Token = "0x6007745")]
	[Address(RVA = "0xD769F0", Offset = "0xD757F0", Length = "0x8")]
	public Action_ScrapMetalStruggleIntro()
	{
	}
}
