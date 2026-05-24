using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;

[ExecuteInEditMode]
[AddComponentMenu("NGUI/Examples/Item Database")]
[Token(Token = "0x2000044")]
public class InvDatabase : MonoBehaviour
{
	[Token(Token = "0x4000324")]
	private static InvDatabase[] mList;

	[Token(Token = "0x4000325")]
	private static bool mIsDirty;

	[Token(Token = "0x4000326")]
	[FieldOffset(Offset = "0x20")]
	public int databaseID;

	[Token(Token = "0x4000327")]
	[FieldOffset(Offset = "0x28")]
	public List<InvBaseItem> items;

	[Token(Token = "0x4000328")]
	[FieldOffset(Offset = "0x30")]
	public UIAtlas iconAtlas;

	[Token(Token = "0x1700002A")]
	public static InvDatabase[] list
	{
		[Token(Token = "0x6000339")]
		[Address(RVA = "0xA1AC10", Offset = "0xA19A10", Length = "0x14C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600033A")]
	[Address(RVA = "0xA1AD60", Offset = "0xA19B60", Length = "0x54")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x600033B")]
	[Address(RVA = "0xA1ADC0", Offset = "0xA19BC0", Length = "0x54")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x600033C")]
	[Address(RVA = "0xA1AE20", Offset = "0xA19C20", Length = "0xA1")]
	private InvBaseItem GetItem(int id16)
	{
		return null;
	}

	[Token(Token = "0x600033D")]
	[Address(RVA = "0xA1AED0", Offset = "0xA19CD0", Length = "0xBB")]
	private static InvDatabase GetDatabase(int dbID)
	{
		return null;
	}

	[Token(Token = "0x600033E")]
	[Address(RVA = "0xA1AF90", Offset = "0xA19D90", Length = "0x242")]
	public static InvBaseItem FindByID(int id32)
	{
		return null;
	}

	[Token(Token = "0x600033F")]
	[Address(RVA = "0xA1B1E0", Offset = "0xA19FE0", Length = "0x198")]
	public static InvBaseItem FindByName(string exact)
	{
		return null;
	}

	[Token(Token = "0x6000340")]
	[Address(RVA = "0xA1B380", Offset = "0xA1A180", Length = "0x158")]
	public static int FindItemID(InvBaseItem item)
	{
		return 0;
	}

	[Token(Token = "0x6000341")]
	[Address(RVA = "0xA1B4E0", Offset = "0xA1A2E0", Length = "0xE3")]
	public InvDatabase()
	{
	}
}
