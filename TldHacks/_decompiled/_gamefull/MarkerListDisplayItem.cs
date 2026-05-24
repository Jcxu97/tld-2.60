using System;
using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x200025F")]
public class MarkerListDisplayItem : MonoBehaviour
{
	[Token(Token = "0x2000260")]
	public delegate void OnItemClicked(int index);

	[Token(Token = "0x4001590")]
	[FieldOffset(Offset = "0x20")]
	public UISprite m_Background;

	[Token(Token = "0x4001591")]
	[FieldOffset(Offset = "0x28")]
	public UIButton m_Button;

	[Token(Token = "0x4001592")]
	[FieldOffset(Offset = "0x30")]
	public UILabel m_DisplayName;

	[Token(Token = "0x4001593")]
	[FieldOffset(Offset = "0x38")]
	public GameObject m_Root;

	[Token(Token = "0x4001594")]
	[FieldOffset(Offset = "0x40")]
	public Color m_Normal;

	[Token(Token = "0x4001595")]
	[FieldOffset(Offset = "0x50")]
	public Color m_Selected;

	[Token(Token = "0x4001596")]
	[FieldOffset(Offset = "0x60")]
	public UISprite m_Icon;

	[Token(Token = "0x4001597")]
	[FieldOffset(Offset = "0x68")]
	public GameObject m_MouseDeleteGroup;

	[Token(Token = "0x4001598")]
	[FieldOffset(Offset = "0x70")]
	public GameObject m_MouseOpenGroup;

	[Token(Token = "0x4001599")]
	[FieldOffset(Offset = "0x78")]
	public GameObject m_GamepadDeleteGroup;

	[Token(Token = "0x400159A")]
	[FieldOffset(Offset = "0x80")]
	public GameObject m_GamepadOpenGroup;

	[NonSerialized]
	[Token(Token = "0x400159B")]
	[FieldOffset(Offset = "0x88")]
	public int m_Index;

	[NonSerialized]
	[Token(Token = "0x400159C")]
	[FieldOffset(Offset = "0x90")]
	public OnItemClicked m_ClickedDelegate;

	[NonSerialized]
	[Token(Token = "0x400159D")]
	[FieldOffset(Offset = "0x98")]
	public OnItemClicked m_ClickedDeleteDelegate;

	[NonSerialized]
	[Token(Token = "0x400159E")]
	[FieldOffset(Offset = "0xA0")]
	public OnItemClicked m_ClickedOpenDelegate;

	[Token(Token = "0x400159F")]
	[FieldOffset(Offset = "0xA8")]
	private bool m_CanDeleteMarker;

	[Token(Token = "0x40015A0")]
	[FieldOffset(Offset = "0xA9")]
	private bool m_CanOpenMarker;

	[Token(Token = "0x60014D6")]
	[Address(RVA = "0x695E50", Offset = "0x694C50", Length = "0x158")]
	public void Clear()
	{
	}

	[Token(Token = "0x60014D7")]
	[Address(RVA = "0x676300", Offset = "0x675100", Length = "0x1F")]
	public void OnButtonClicked()
	{
	}

	[Token(Token = "0x60014D8")]
	[Address(RVA = "0x695FB0", Offset = "0x694DB0", Length = "0x1F")]
	public void OnClickedDelete()
	{
	}

	[Token(Token = "0x60014D9")]
	[Address(RVA = "0x695FD0", Offset = "0x694DD0", Length = "0x1F")]
	public void OnClickedOpen()
	{
	}

	[Token(Token = "0x60014DA")]
	[Address(RVA = "0x695FF0", Offset = "0x694DF0", Length = "0x13B")]
	public void SetSelected(bool selected)
	{
	}

	[Token(Token = "0x60014DB")]
	[Address(RVA = "0x696130", Offset = "0x694F30", Length = "0x1F2")]
	public void Setup(MapElementSaveData marker)
	{
	}

	[Token(Token = "0x60014DC")]
	[Address(RVA = "0x696330", Offset = "0x695130", Length = "0x1D")]
	public static bool CanDelete(MapElementSaveData marker)
	{
		return false;
	}

	[Token(Token = "0x60014DD")]
	[Address(RVA = "0x696350", Offset = "0x695150", Length = "0x7")]
	public static bool CanOpen(MapElementSaveData marker)
	{
		return false;
	}

	[Token(Token = "0x60014DE")]
	[Address(RVA = "0x696360", Offset = "0x695160", Length = "0x30D")]
	private void RefreshButtons(bool selected)
	{
	}

	[Token(Token = "0x60014DF")]
	[Address(RVA = "0x676860", Offset = "0x675660", Length = "0x4D")]
	public MarkerListDisplayItem()
	{
	}
}
