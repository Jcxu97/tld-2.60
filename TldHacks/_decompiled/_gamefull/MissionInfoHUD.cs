using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x2000263")]
public class MissionInfoHUD : MonoBehaviour
{
	[Token(Token = "0x40015A8")]
	[FieldOffset(Offset = "0x20")]
	public GameObject m_MissionObjectivePrefab;

	[Token(Token = "0x40015A9")]
	[FieldOffset(Offset = "0x28")]
	public Transform m_MissionObjetivePoolParent;

	[Token(Token = "0x40015AA")]
	[FieldOffset(Offset = "0x30")]
	public Transform m_MissionObjetiveActiveObjects;

	[Token(Token = "0x40015AB")]
	[FieldOffset(Offset = "0x38")]
	public UILabel m_SelectedMissionName;

	[Token(Token = "0x40015AC")]
	[FieldOffset(Offset = "0x40")]
	public UISprite m_BorderSprite;

	[Token(Token = "0x40015AD")]
	[FieldOffset(Offset = "0x48")]
	public UILabel m_TimerLabel;

	[Token(Token = "0x40015AE")]
	[FieldOffset(Offset = "0x50")]
	public UISprite m_TimerBGSprite;

	[Token(Token = "0x40015AF")]
	[FieldOffset(Offset = "0x58")]
	public GameObject m_TimerObject;

	[Token(Token = "0x40015B0")]
	[FieldOffset(Offset = "0x60")]
	public Color m_TimerColorNormal;

	[Token(Token = "0x40015B1")]
	[FieldOffset(Offset = "0x70")]
	public Color m_TimerColorLowTime;

	[Token(Token = "0x40015B2")]
	[FieldOffset(Offset = "0x80")]
	public float m_SecondsToShow;

	[Token(Token = "0x40015B3")]
	[FieldOffset(Offset = "0x84")]
	public float m_SecondsToFadeOut;

	[Token(Token = "0x40015B4")]
	[FieldOffset(Offset = "0x88")]
	public float m_BorderSizeNameOnly;

	[Token(Token = "0x40015B5")]
	[FieldOffset(Offset = "0x8C")]
	public float m_NameOffsetFromTimer;

	[Token(Token = "0x40015B6")]
	[FieldOffset(Offset = "0x90")]
	public float m_ObjectivesOffsetFromName;

	[Token(Token = "0x40015B7")]
	[FieldOffset(Offset = "0x98")]
	private UIWidget m_Widget;

	[Token(Token = "0x60014E9")]
	[Address(RVA = "0x696EA0", Offset = "0x695CA0", Length = "0xC2")]
	private void Start()
	{
	}

	[Token(Token = "0x60014EA")]
	[Address(RVA = "0x4AF5E0", Offset = "0x4AE3E0", Length = "0x43")]
	public MissionInfoHUD()
	{
	}
}
