using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x2000265")]
public class MissionSubobjectiveEntry : MonoBehaviour
{
	[Token(Token = "0x40015D1")]
	[FieldOffset(Offset = "0x20")]
	public UIWidget m_Widget;

	[Token(Token = "0x40015D2")]
	[FieldOffset(Offset = "0x28")]
	public UILabel m_ObjectiveDescLabel;

	[Token(Token = "0x40015D3")]
	[FieldOffset(Offset = "0x30")]
	public UISprite m_ActiveSprite;

	[Token(Token = "0x40015D4")]
	[FieldOffset(Offset = "0x38")]
	public UISprite m_SuccessSprite;

	[Token(Token = "0x40015D5")]
	[FieldOffset(Offset = "0x40")]
	public UISprite m_FailSprite;

	[Token(Token = "0x40015D6")]
	[FieldOffset(Offset = "0x48")]
	public UISprite m_TimerSprite;

	[Token(Token = "0x40015D7")]
	[FieldOffset(Offset = "0x50")]
	public GameObject m_CountObject;

	[Token(Token = "0x40015D8")]
	[FieldOffset(Offset = "0x58")]
	public UILabel m_CountLabel;

	[Token(Token = "0x40015D9")]
	[FieldOffset(Offset = "0x60")]
	public GameObject m_TimerObject;

	[Token(Token = "0x40015DA")]
	[FieldOffset(Offset = "0x68")]
	public UILabel m_TimerLabel;

	[Token(Token = "0x40015DB")]
	[FieldOffset(Offset = "0x70")]
	public int m_ObjectiveSpacing;

	[Token(Token = "0x40015DC")]
	[FieldOffset(Offset = "0x74")]
	public int m_NumSpacesForIndent;

	[Token(Token = "0x40015DD")]
	[FieldOffset(Offset = "0x78")]
	public float m_AlphaValWhenActive;

	[Token(Token = "0x40015DE")]
	[FieldOffset(Offset = "0x7C")]
	public float m_AlphaValWhenCompleted;

	[Token(Token = "0x40015DF")]
	[FieldOffset(Offset = "0x80")]
	public Color m_TimerColorNormal;

	[Token(Token = "0x40015E0")]
	[FieldOffset(Offset = "0x90")]
	public Color m_TimerColorLowTime;

	[Token(Token = "0x60014F0")]
	[Address(RVA = "0x698430", Offset = "0x697230", Length = "0x73A")]
	public void SetObjectiveInfo(StoryMissionObjective objective, MissionSubobjectiveEntry prevEntry)
	{
	}

	[Token(Token = "0x60014F1")]
	[Address(RVA = "0x698B70", Offset = "0x697970", Length = "0x4F")]
	public float GetHeight()
	{
		return 0f;
	}

	[Token(Token = "0x60014F2")]
	[Address(RVA = "0x4AF5E0", Offset = "0x4AE3E0", Length = "0x43")]
	public MissionSubobjectiveEntry()
	{
	}
}
