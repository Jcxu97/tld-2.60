using Cpp2ILInjected;
using TLD.GameplayTags;
using UnityEngine;

namespace TLD.Gameplay;

[Token(Token = "0x20014A2")]
public class DisableObjectForGameMode : MonoBehaviour, IShouldDisableForCurrentMode
{
	[SerializeField]
	[Token(Token = "0x4009585")]
	[FieldOffset(Offset = "0x20")]
	private GameplayTag[] m_DisableIfAnyActive;

	[Token(Token = "0x60082DA")]
	[Address(RVA = "0x123F110", Offset = "0x123DF10", Length = "0x9D")]
	public void Update()
	{
	}

	[Token(Token = "0x60082DB")]
	[Address(RVA = "0x123F1B0", Offset = "0x123DFB0", Length = "0x3B8")]
	public bool ShouldDisableForCurrentMode()
	{
		return false;
	}

	[Token(Token = "0x60082DC")]
	[Address(RVA = "0x4AF5E0", Offset = "0x4AE3E0", Length = "0x43")]
	public DisableObjectForGameMode()
	{
	}
}
