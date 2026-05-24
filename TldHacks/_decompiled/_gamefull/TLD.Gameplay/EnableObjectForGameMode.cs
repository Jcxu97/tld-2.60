using Cpp2ILInjected;
using TLD.GameplayTags;
using UnityEngine;

namespace TLD.Gameplay;

[Token(Token = "0x20014A3")]
public class EnableObjectForGameMode : MonoBehaviour, IShouldDisableForCurrentMode
{
	[SerializeField]
	[Token(Token = "0x4009586")]
	[FieldOffset(Offset = "0x20")]
	private GameplayTag[] m_EnableIfAnyActive;

	[SerializeField]
	[Token(Token = "0x4009587")]
	[FieldOffset(Offset = "0x28")]
	private GameObject m_ObjectToEnable;

	[Token(Token = "0x60082DD")]
	[Address(RVA = "0x123F570", Offset = "0x123E370", Length = "0x159")]
	public void Update()
	{
	}

	[Token(Token = "0x60082DE")]
	[Address(RVA = "0x123F6D0", Offset = "0x123E4D0", Length = "0x3A3")]
	public bool ShouldDisableForCurrentMode()
	{
		return false;
	}

	[Token(Token = "0x60082DF")]
	[Address(RVA = "0x4AF5E0", Offset = "0x4AE3E0", Length = "0x43")]
	public EnableObjectForGameMode()
	{
	}
}
