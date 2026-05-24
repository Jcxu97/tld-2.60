using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x2000281")]
public class StoryMissionListEntry : MonoBehaviour
{
	[Token(Token = "0x2000282")]
	public enum CompletionDisplayMode
	{
		[Token(Token = "0x4001701")]
		Percentage,
		[Token(Token = "0x4001702")]
		Fraction
	}

	[Token(Token = "0x40016EB")]
	[FieldOffset(Offset = "0x20")]
	public UIWidget m_FadeOnDeselectWidget;

	[Token(Token = "0x40016EC")]
	[FieldOffset(Offset = "0x28")]
	public UISprite m_CheckboxSprite;

	[Token(Token = "0x40016ED")]
	[FieldOffset(Offset = "0x30")]
	public UISprite m_MissionSuccessSprite;

	[Token(Token = "0x40016EE")]
	[FieldOffset(Offset = "0x38")]
	public UISprite m_MissionFailedSprite;

	[Token(Token = "0x40016EF")]
	[FieldOffset(Offset = "0x40")]
	public UISprite m_MissionTimerSprite;

	[Token(Token = "0x40016F0")]
	[FieldOffset(Offset = "0x48")]
	public UISprite m_HighlightSprite;

	[Token(Token = "0x40016F1")]
	[FieldOffset(Offset = "0x50")]
	public UILabel m_EpisodeNameLabel;

	[Token(Token = "0x40016F2")]
	[FieldOffset(Offset = "0x58")]
	public UILabel m_MissionNameLabel;

	[Token(Token = "0x40016F3")]
	[FieldOffset(Offset = "0x60")]
	public UILabel m_MissionDescLabel;

	[Token(Token = "0x40016F4")]
	[FieldOffset(Offset = "0x68")]
	public UILabel m_MissionType;

	[Token(Token = "0x40016F5")]
	[FieldOffset(Offset = "0x70")]
	public UISprite m_MissionIcon;

	[Token(Token = "0x40016F6")]
	[FieldOffset(Offset = "0x78")]
	public UILabel m_CompletionPercentageLabel;

	[Token(Token = "0x40016F7")]
	[FieldOffset(Offset = "0x80")]
	public UISprite m_CompletionPercentageFillSprite;

	[Token(Token = "0x40016F8")]
	[FieldOffset(Offset = "0x88")]
	public float m_CompletionPercentageFillSpriteOffset;

	[Token(Token = "0x40016F9")]
	[FieldOffset(Offset = "0x8C")]
	public CompletionDisplayMode m_CompletionDisplayMode;

	[Token(Token = "0x40016FA")]
	[FieldOffset(Offset = "0x90")]
	public float m_DeslectedAlphaValue;

	[Token(Token = "0x40016FB")]
	[FieldOffset(Offset = "0x94")]
	public Color m_CheckboxColorNormal;

	[Token(Token = "0x40016FC")]
	[FieldOffset(Offset = "0xA4")]
	public Color m_CheckboxColorLowTime;

	[HideInInspector]
	[Token(Token = "0x40016FD")]
	[FieldOffset(Offset = "0xB8")]
	public StoryMissionInfo m_MissionInfo;

	[Token(Token = "0x40016FE")]
	[FieldOffset(Offset = "0xC0")]
	public GameObject m_NotificationFlag;

	[Token(Token = "0x40016FF")]
	[FieldOffset(Offset = "0xC8")]
	public bool m_IsSelected;

	[Token(Token = "0x60015D9")]
	[Address(RVA = "0x6ABFD0", Offset = "0x6AADD0", Length = "0x95C")]
	public void Refresh(float lowTimeValue, StoryMissionInfo missionInfo, int numCompletedObjectives, int numObjectives)
	{
	}

	[Token(Token = "0x60015DA")]
	[Address(RVA = "0x6AC930", Offset = "0x6AB730", Length = "0x12D")]
	public void SetSelected(bool isSelected)
	{
	}

	[Token(Token = "0x60015DB")]
	[Address(RVA = "0x6ACA60", Offset = "0x6AB860", Length = "0x490")]
	private void SetActiveCheckboxEntry(UISprite activeSprite)
	{
	}

	[Token(Token = "0x60015DC")]
	[Address(RVA = "0x4AF5E0", Offset = "0x4AE3E0", Length = "0x43")]
	public StoryMissionListEntry()
	{
	}
}
