using Cpp2ILInjected;
using UnityEngine;

[RequireComponent(typeof(UISprite))]
[Token(Token = "0x20005DA")]
public class GamepadButtonSprite : MonoBehaviour
{
	[SerializeField]
	[Token(Token = "0x4003627")]
	[FieldOffset(Offset = "0x20")]
	private string m_GamepadAction;

	[Token(Token = "0x4003628")]
	[FieldOffset(Offset = "0x28")]
	private UISprite m_ButtonSprite;

	[Token(Token = "0x6002D66")]
	[Address(RVA = "0x94AB60", Offset = "0x949960", Length = "0x1CD")]
	public void UpdateSpriteForActiveController(ButtonLegend legend)
	{
	}

	[Token(Token = "0x6002D67")]
	[Address(RVA = "0x94AD30", Offset = "0x949B30", Length = "0x160")]
	public void EnableSprite(bool enable)
	{
	}

	[Token(Token = "0x6002D68")]
	[Address(RVA = "0x94AEA0", Offset = "0x949CA0", Length = "0x1C0")]
	public void EnableSpriteIfActionIs(string action, bool enable)
	{
	}

	[Token(Token = "0x6002D69")]
	[Address(RVA = "0x4AF5E0", Offset = "0x4AE3E0", Length = "0x43")]
	public GamepadButtonSprite()
	{
	}
}
