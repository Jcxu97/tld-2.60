using Cpp2ILInjected;
using UnityEngine;

namespace TLD.Gameplay;

[CreateAssetMenu(menuName = "The Long Dark/Gameplay/Scriptable Actions/Disable Game Object")]
[Token(Token = "0x2001475")]
public class DisableGameObjectByName : ScriptableAction
{
	[SerializeField]
	[Token(Token = "0x400945F")]
	[FieldOffset(Offset = "0x18")]
	private string m_SearchString;

	[Token(Token = "0x600821F")]
	[Address(RVA = "0x122C550", Offset = "0x122B350", Length = "0x111")]
	public override void ExecuteAction()
	{
	}

	[Token(Token = "0x6008220")]
	[Address(RVA = "0x4A22A0", Offset = "0x4A10A0", Length = "0x7")]
	public DisableGameObjectByName()
	{
	}
}
