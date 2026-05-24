using Cpp2ILInjected;
using UnityEngine;

namespace TLD.UI;

[Token(Token = "0x2001393")]
public class SaveSpaceInfo : MonoBehaviour
{
	[SerializeField]
	[Token(Token = "0x4008FB6")]
	[FieldOffset(Offset = "0x20")]
	private UILabel m_LabelSaveSpace;

	[SerializeField]
	[Token(Token = "0x4008FB7")]
	[FieldOffset(Offset = "0x28")]
	private Color m_LabelSaveSpaceColorNormal;

	[SerializeField]
	[Token(Token = "0x4008FB8")]
	[FieldOffset(Offset = "0x38")]
	private Color m_LabelSaveSpaceColorFull;

	[SerializeField]
	[Token(Token = "0x4008FB9")]
	[FieldOffset(Offset = "0x48")]
	private UISprite m_BarOutline;

	[SerializeField]
	[Token(Token = "0x4008FBA")]
	[FieldOffset(Offset = "0x50")]
	private UISprite m_BarFillAllSaves;

	[SerializeField]
	[Token(Token = "0x4008FBB")]
	[FieldOffset(Offset = "0x58")]
	private UISprite m_BarFillMissingSelected;

	[SerializeField]
	[Token(Token = "0x4008FBC")]
	[FieldOffset(Offset = "0x60")]
	private float m_BarFillOffset;

	[Token(Token = "0x6007D03")]
	[Address(RVA = "0x11C2ED0", Offset = "0x11C1CD0", Length = "0x5EF")]
	public void Refresh(string selectedSaveName)
	{
	}

	[Token(Token = "0x6007D04")]
	[Address(RVA = "0x11C34C0", Offset = "0x11C22C0", Length = "0x4A")]
	public SaveSpaceInfo()
	{
	}
}
