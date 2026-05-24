using Cpp2ILInjected;
using TLD.UI.Generics;
using UnityEngine;

[Token(Token = "0x20004D1")]
public class ShowOnMapItem : MonoBehaviour
{
	[SerializeField]
	[Token(Token = "0x4002C27")]
	[FieldOffset(Offset = "0x20")]
	private PanelReference<Panel_Map> m_Map;

	[Header("When dropped during STRUGGLE, icon appears on map")]
	[Token(Token = "0x4002C28")]
	[FieldOffset(Offset = "0x28")]
	public string m_MapLocID;

	[Token(Token = "0x4002C29")]
	[FieldOffset(Offset = "0x30")]
	public string m_MapIconSpriteName;

	[Token(Token = "0x4002C2A")]
	[FieldOffset(Offset = "0x38")]
	public bool m_BigIconOnMap;

	[Token(Token = "0x60024C1")]
	[Address(RVA = "0x86DE10", Offset = "0x86CC10", Length = "0x176")]
	public void AddToMap(Vector3 worldPosition)
	{
	}

	[Token(Token = "0x60024C2")]
	[Address(RVA = "0x86DF90", Offset = "0x86CD90", Length = "0xBB")]
	public void RemoveFromMap(Vector3 worldPosition)
	{
	}

	[Token(Token = "0x60024C3")]
	[Address(RVA = "0x4AF5E0", Offset = "0x4AE3E0", Length = "0x43")]
	public ShowOnMapItem()
	{
	}
}
