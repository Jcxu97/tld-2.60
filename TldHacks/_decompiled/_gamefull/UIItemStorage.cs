using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;

[AddComponentMenu("NGUI/Examples/UI Item Storage")]
[Token(Token = "0x200003F")]
public class UIItemStorage : MonoBehaviour
{
	[Token(Token = "0x4000302")]
	[FieldOffset(Offset = "0x20")]
	public int maxItemCount;

	[Token(Token = "0x4000303")]
	[FieldOffset(Offset = "0x24")]
	public int maxRows;

	[Token(Token = "0x4000304")]
	[FieldOffset(Offset = "0x28")]
	public int maxColumns;

	[Token(Token = "0x4000305")]
	[FieldOffset(Offset = "0x30")]
	public GameObject template;

	[Token(Token = "0x4000306")]
	[FieldOffset(Offset = "0x38")]
	public UIWidget background;

	[Token(Token = "0x4000307")]
	[FieldOffset(Offset = "0x40")]
	public int spacing;

	[Token(Token = "0x4000308")]
	[FieldOffset(Offset = "0x44")]
	public int padding;

	[Token(Token = "0x4000309")]
	[FieldOffset(Offset = "0x48")]
	private List<InvGameItem> mItems;

	[Token(Token = "0x17000028")]
	public List<InvGameItem> items
	{
		[Token(Token = "0x600032E")]
		[Address(RVA = "0xA195A0", Offset = "0xA183A0", Length = "0xBB")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600032F")]
	[Address(RVA = "0xA19660", Offset = "0xA18460", Length = "0xA2")]
	public InvGameItem GetItem(int slot)
	{
		return null;
	}

	[Token(Token = "0x6000330")]
	[Address(RVA = "0xA19710", Offset = "0xA18510", Length = "0xDE")]
	public InvGameItem Replace(int slot, InvGameItem item)
	{
		return null;
	}

	[Token(Token = "0x6000331")]
	[Address(RVA = "0xA197F0", Offset = "0xA185F0", Length = "0x70D")]
	private void Start()
	{
	}

	[Token(Token = "0x6000332")]
	[Address(RVA = "0xA19F00", Offset = "0xA18D00", Length = "0x112")]
	public UIItemStorage()
	{
	}
}
