using Cpp2ILInjected;
using UnityEngine;

[CreateAssetMenu(order = 10000)]
[Token(Token = "0x20008C5")]
public class PlayerStateTransitions : ScriptableObject
{
	[SerializeField]
	[Token(Token = "0x4005B65")]
	[FieldOffset(Offset = "0x18")]
	private PlayerAnimation.StateFlags[] m_ValidTransitions;

	[SerializeField]
	[Token(Token = "0x4005B66")]
	[FieldOffset(Offset = "0x20")]
	private PlayerAnimation.StateFlags[] m_InvalidTransitions;

	[Token(Token = "0x6005081")]
	[Address(RVA = "0xE07B10", Offset = "0xE06910", Length = "0x3D")]
	public bool IsValidTransition(PlayerAnimation.State from, PlayerAnimation.State to)
	{
		return false;
	}

	[Token(Token = "0x6005082")]
	[Address(RVA = "0xE07B50", Offset = "0xE06950", Length = "0x3D")]
	public bool IsInvalidTransition(PlayerAnimation.State from, PlayerAnimation.State to)
	{
		return false;
	}

	[Token(Token = "0x6005083")]
	[Address(RVA = "0xE07B90", Offset = "0xE06990", Length = "0x152")]
	public PlayerStateTransitions()
	{
	}
}
