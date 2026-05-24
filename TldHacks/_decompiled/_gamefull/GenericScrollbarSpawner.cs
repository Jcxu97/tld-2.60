using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x2000883")]
public class GenericScrollbarSpawner : MonoBehaviour
{
	[Token(Token = "0x40057E2")]
	[FieldOffset(Offset = "0x20")]
	public GameObject m_Prefab;

	[Token(Token = "0x40057E3")]
	[FieldOffset(Offset = "0x28")]
	public Vector3 m_UpButtonPos;

	[Token(Token = "0x40057E4")]
	[FieldOffset(Offset = "0x34")]
	public Vector3 m_DownButtonPos;

	[Token(Token = "0x40057E5")]
	[FieldOffset(Offset = "0x40")]
	public Vector3 m_ColliderSize;

	[Token(Token = "0x40057E6")]
	[FieldOffset(Offset = "0x4C")]
	public Vector2 m_SliderSize;

	[Token(Token = "0x40057E7")]
	[FieldOffset(Offset = "0x54")]
	public Vector2 m_GlowSize;

	[Token(Token = "0x40057E8")]
	[FieldOffset(Offset = "0x60")]
	public List<EventDelegate> onClickUp;

	[Token(Token = "0x40057E9")]
	[FieldOffset(Offset = "0x68")]
	public List<EventDelegate> onClickDown;

	[Token(Token = "0x40057EA")]
	[FieldOffset(Offset = "0x70")]
	public List<EventDelegate> onChange;

	[Token(Token = "0x40057EB")]
	[FieldOffset(Offset = "0x78")]
	public List<EventDelegate> onDragFinished;

	[Token(Token = "0x40057EC")]
	[FieldOffset(Offset = "0x80")]
	public Color m_ButtonColorNormal;

	[Token(Token = "0x40057ED")]
	[FieldOffset(Offset = "0x90")]
	public Color m_ButtonColorHover;

	[Token(Token = "0x40057EE")]
	[FieldOffset(Offset = "0xA0")]
	public Color m_ButtonColorPressed;

	[Token(Token = "0x40057EF")]
	[FieldOffset(Offset = "0xB0")]
	public Color m_ScrollbarColor;

	[Token(Token = "0x40057F0")]
	[FieldOffset(Offset = "0xC0")]
	public Color m_ScrollbarBGColor;

	[Token(Token = "0x40057F1")]
	[FieldOffset(Offset = "0xD0")]
	public Color m_ScrollbarGlowColor;

	[HideInInspector]
	[Token(Token = "0x40057F2")]
	[FieldOffset(Offset = "0xE0")]
	public GameObject m_SpawnedObject;

	[Token(Token = "0x6004DCC")]
	[Address(RVA = "0xD93430", Offset = "0xD92230", Length = "0xCA")]
	public void Awake()
	{
	}

	[Token(Token = "0x6004DCD")]
	[Address(RVA = "0xD93500", Offset = "0xD92300", Length = "0x1016")]
	public void AssignValuesToSpawnedObject()
	{
	}

	[Token(Token = "0x6004DCE")]
	[Address(RVA = "0xD94520", Offset = "0xD93320", Length = "0x45")]
	private void OnDragFinished()
	{
	}

	[Token(Token = "0x6004DCF")]
	[Address(RVA = "0xD94570", Offset = "0xD93370", Length = "0x24F")]
	public GenericScrollbarSpawner()
	{
	}
}
