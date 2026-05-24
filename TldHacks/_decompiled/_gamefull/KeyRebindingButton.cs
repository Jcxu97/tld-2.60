using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x2000255")]
public class KeyRebindingButton : MonoBehaviour
{
	[Token(Token = "0x4001516")]
	[FieldOffset(Offset = "0x20")]
	public UISprite m_SelectedSprite;

	[Token(Token = "0x4001517")]
	[FieldOffset(Offset = "0x28")]
	public UILabel m_ValueLabel;

	[Token(Token = "0x4001518")]
	[FieldOffset(Offset = "0x30")]
	public string m_ActionIDString;

	[Token(Token = "0x600149F")]
	[Address(RVA = "0x690220", Offset = "0x68F020", Length = "0x77")]
	public void Start()
	{
	}

	[Token(Token = "0x60014A0")]
	[Address(RVA = "0x6902A0", Offset = "0x68F0A0", Length = "0x73")]
	public void SetValueLabel(string keycode)
	{
	}

	[Token(Token = "0x60014A1")]
	[Address(RVA = "0x6816B0", Offset = "0x6804B0", Length = "0x1E")]
	public void SetSelected(bool selected)
	{
	}

	[Token(Token = "0x60014A2")]
	[Address(RVA = "0x4AF5E0", Offset = "0x4AE3E0", Length = "0x43")]
	public KeyRebindingButton()
	{
	}
}
