using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x200013C")]
public class UnlockAchievementTrigger : MonoBehaviour
{
	[SerializeField]
	[Token(Token = "0x40009EB")]
	[FieldOffset(Offset = "0x20")]
	private Achievement m_Achievement;

	[Token(Token = "0x6000B58")]
	[Address(RVA = "0x5D3B30", Offset = "0x5D2930", Length = "0x177")]
	private void OnTriggerEnter(Collider c)
	{
	}

	[Token(Token = "0x6000B59")]
	[Address(RVA = "0x4AF5E0", Offset = "0x4AE3E0", Length = "0x43")]
	public UnlockAchievementTrigger()
	{
	}
}
