using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x200022C")]
public abstract class CreditElement : MonoBehaviour
{
	[SerializeField]
	[Token(Token = "0x400135C")]
	[FieldOffset(Offset = "0x20")]
	private float m_PaddingAbove;

	[SerializeField]
	[Token(Token = "0x400135D")]
	[FieldOffset(Offset = "0x24")]
	private float m_PaddingBelow;

	[Token(Token = "0x600135E")]
	public abstract bool IsContentValid(string[] content, Panel_Credits panel);

	[Token(Token = "0x600135F")]
	public abstract void Populate(string[] content, Panel_Credits panel);

	[Token(Token = "0x6001360")]
	public abstract Vector2 GetSize();

	[Token(Token = "0x6001361")]
	[Address(RVA = "0x669850", Offset = "0x668650", Length = "0xDB")]
	public virtual void SetPosition(float yOffset)
	{
	}

	[Token(Token = "0x6001362")]
	[Address(RVA = "0x5042F0", Offset = "0x5030F0", Length = "0x6")]
	public float GetPaddingAbove()
	{
		return 0f;
	}

	[Token(Token = "0x6001363")]
	[Address(RVA = "0x504310", Offset = "0x503110", Length = "0x6")]
	public float GetPaddingBelow()
	{
		return 0f;
	}

	[Token(Token = "0x6001364")]
	[Address(RVA = "0x4AF5E0", Offset = "0x4AE3E0", Length = "0x43")]
	protected CreditElement()
	{
	}
}
