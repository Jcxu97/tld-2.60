using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x2000264")]
public class MissionObjectiveEntry : MonoBehaviour
{
	[Token(Token = "0x40015B8")]
	[FieldOffset(Offset = "0x20")]
	public UIWidget m_Widget;

	[Token(Token = "0x40015B9")]
	[FieldOffset(Offset = "0x28")]
	public UISprite m_CheckboxEntrySprite;

	[Token(Token = "0x40015BA")]
	[FieldOffset(Offset = "0x30")]
	public UILabel m_ObjectiveDescLabel;

	[Token(Token = "0x40015BB")]
	[FieldOffset(Offset = "0x38")]
	public Transform m_ObjectiveDescOffset;

	[Token(Token = "0x40015BC")]
	[FieldOffset(Offset = "0x40")]
	public float m_DescOffestFromCountOrTimer;

	[Token(Token = "0x40015BD")]
	[FieldOffset(Offset = "0x48")]
	public UISprite m_BGSprite;

	[Token(Token = "0x40015BE")]
	[FieldOffset(Offset = "0x50")]
	public float m_BGSpriteBaseHeight;

	[Token(Token = "0x40015BF")]
	[FieldOffset(Offset = "0x58")]
	public UISprite m_ActiveSprite;

	[Token(Token = "0x40015C0")]
	[FieldOffset(Offset = "0x60")]
	public UISprite m_SuccessSprite;

	[Token(Token = "0x40015C1")]
	[FieldOffset(Offset = "0x68")]
	public UISprite m_FailSprite;

	[Token(Token = "0x40015C2")]
	[FieldOffset(Offset = "0x70")]
	public UISprite m_TimerSprite;

	[Token(Token = "0x40015C3")]
	[FieldOffset(Offset = "0x78")]
	public GameObject m_CountObject;

	[Token(Token = "0x40015C4")]
	[FieldOffset(Offset = "0x80")]
	public UILabel m_CountLabel;

	[Token(Token = "0x40015C5")]
	[FieldOffset(Offset = "0x88")]
	public UISprite m_CountFillSprite;

	[Token(Token = "0x40015C6")]
	[FieldOffset(Offset = "0x90")]
	public float m_FillSpriteOffset;

	[Token(Token = "0x40015C7")]
	[FieldOffset(Offset = "0x98")]
	public GameObject m_TimerObject;

	[Token(Token = "0x40015C8")]
	[FieldOffset(Offset = "0xA0")]
	public UILabel m_TimerLabel;

	[Token(Token = "0x40015C9")]
	[FieldOffset(Offset = "0xA8")]
	public Transform m_SubobjectivesParent;

	[Token(Token = "0x40015CA")]
	[FieldOffset(Offset = "0xB0")]
	public MissionSubobjectiveEntry[] m_Subobjectives;

	[Token(Token = "0x40015CB")]
	[FieldOffset(Offset = "0xB8")]
	public int m_ObjectiveSpacing;

	[Token(Token = "0x40015CC")]
	[FieldOffset(Offset = "0xBC")]
	public int m_OffsetPerIndent;

	[Token(Token = "0x40015CD")]
	[FieldOffset(Offset = "0xC0")]
	public float m_AlphaValWhenActive;

	[Token(Token = "0x40015CE")]
	[FieldOffset(Offset = "0xC4")]
	public float m_AlphaValWhenCompleted;

	[Token(Token = "0x40015CF")]
	[FieldOffset(Offset = "0xC8")]
	public Color m_TimerColorNormal;

	[Token(Token = "0x40015D0")]
	[FieldOffset(Offset = "0xD8")]
	public Color m_TimerColorLowTime;

	[Token(Token = "0x60014EB")]
	[Address(RVA = "0x696F70", Offset = "0x695D70", Length = "0xC65")]
	public void SetObjectiveInfo(StoryMissionObjective objective, MissionObjectiveEntry prevEntry, bool skipSubobjectives = false)
	{
	}

	[Token(Token = "0x60014EC")]
	[Address(RVA = "0x697BE0", Offset = "0x6969E0", Length = "0x208")]
	private static bool MaybeUpdateTimerObjectiveUI(StoryMissionObjective objective, UILabel timerlabel, Color timerColorLowTime, Color timerColorNormal, UISprite timerSprite)
	{
		return false;
	}

	[Token(Token = "0x60014ED")]
	[Address(RVA = "0x697DF0", Offset = "0x696BF0", Length = "0x58D")]
	private static bool MaybeUpdateCounterUI(StoryMissionObjective objective, UIWidget widget, float alphaValueWhenCompleted, UILabel countLabel, UISprite countFillSprite, float fillSpriteOffset)
	{
		return false;
	}

	[Token(Token = "0x60014EE")]
	[Address(RVA = "0x698380", Offset = "0x697180", Length = "0xAF")]
	public static void UpdateObjectiveUI(StoryMissionObjective objective, UILabel timerlabel, UISprite timerSprite, Color timerColorLowTime, Color timerColorNormal, UIWidget widget, float alphaValueWhenCompleted, UILabel countLabel, UISprite countFillSprite, float fillSpriteOffset, ref bool hasTimer, ref bool hasCounter)
	{
	}

	[Token(Token = "0x60014EF")]
	[Address(RVA = "0x4AF5E0", Offset = "0x4AE3E0", Length = "0x43")]
	public MissionObjectiveEntry()
	{
	}
}
