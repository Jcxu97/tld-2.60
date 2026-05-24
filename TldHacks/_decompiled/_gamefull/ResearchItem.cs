using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x20004CC")]
public class ResearchItem : MonoBehaviour
{
	[Token(Token = "0x4002C11")]
	[FieldOffset(Offset = "0x20")]
	public SkillType m_SkillType;

	[Range(1f, 100f)]
	[Token(Token = "0x4002C12")]
	[FieldOffset(Offset = "0x24")]
	public int m_TimeRequirementHours;

	[Range(1f, 1000f)]
	[Token(Token = "0x4002C13")]
	[FieldOffset(Offset = "0x28")]
	public int m_SkillPoints;

	[Range(1f, 5f)]
	[Token(Token = "0x4002C14")]
	[FieldOffset(Offset = "0x2C")]
	public int m_NoBenefitAtSkillLevel;

	[Token(Token = "0x4002C15")]
	[FieldOffset(Offset = "0x30")]
	public string m_ReadAudio;

	[Token(Token = "0x4002C16")]
	[FieldOffset(Offset = "0x38")]
	private float m_ElapsedHours;

	[Token(Token = "0x4002C17")]
	[FieldOffset(Offset = "0x3C")]
	private bool m_CheckProgress;

	[Token(Token = "0x4002C18")]
	private static ResearchItemSaveData m_ResearchItemSaveData;

	[Token(Token = "0x60024A5")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	private void Start()
	{
	}

	[Token(Token = "0x60024A6")]
	[Address(RVA = "0x86BD80", Offset = "0x86AB80", Length = "0xDF")]
	public string Serialize()
	{
		return null;
	}

	[Token(Token = "0x60024A7")]
	[Address(RVA = "0x86BE60", Offset = "0x86AC60", Length = "0x90")]
	public void Deserialize(string text)
	{
	}

	[Token(Token = "0x60024A8")]
	[Address(RVA = "0x86BF00", Offset = "0x86AD00", Length = "0x4B")]
	public void ManualUpdate()
	{
	}

	[Token(Token = "0x60024A9")]
	[Address(RVA = "0x86BF50", Offset = "0x86AD50", Length = "0x238")]
	public void Read(float timeOfDayHours)
	{
	}

	[Token(Token = "0x60024AA")]
	[Address(RVA = "0x86C190", Offset = "0x86AF90", Length = "0xFA")]
	public bool NoBenefitAtCurrentSkillLevel()
	{
		return false;
	}

	[Token(Token = "0x60024AB")]
	[Address(RVA = "0x86C290", Offset = "0x86B090", Length = "0x1A8")]
	public void OnResearchComplete()
	{
	}

	[Token(Token = "0x60024AC")]
	[Address(RVA = "0x86C440", Offset = "0x86B240", Length = "0x25")]
	public bool IsResearchComplete()
	{
		return false;
	}

	[Token(Token = "0x60024AD")]
	[Address(RVA = "0x86C470", Offset = "0x86B270", Length = "0xE")]
	public void MarkAsRead()
	{
	}

	[Token(Token = "0x60024AE")]
	[Address(RVA = "0x86C480", Offset = "0x86B280", Length = "0x59")]
	public int GetMinutesResearchRemaining()
	{
		return 0;
	}

	[Token(Token = "0x60024AF")]
	[Address(RVA = "0x86C4E0", Offset = "0x86B2E0", Length = "0x79")]
	public int GetHoursResearchRemaining()
	{
		return 0;
	}

	[Token(Token = "0x60024B0")]
	[Address(RVA = "0x86C560", Offset = "0x86B360", Length = "0xBC")]
	public int GetTimeRequirementHours()
	{
		return 0;
	}

	[Token(Token = "0x60024B1")]
	[Address(RVA = "0x6208B0", Offset = "0x61F6B0", Length = "0x6")]
	public float GetElapsedHours()
	{
		return 0f;
	}

	[Token(Token = "0x60024B2")]
	[Address(RVA = "0x86C620", Offset = "0x86B420", Length = "0x171")]
	public string GetSkillNameLocalized()
	{
		return null;
	}

	[Token(Token = "0x60024B3")]
	[Address(RVA = "0x86C7A0", Offset = "0x86B5A0", Length = "0x129")]
	public string GetSkillIconName()
	{
		return null;
	}

	[Token(Token = "0x60024B4")]
	[Address(RVA = "0x86C8D0", Offset = "0x86B6D0", Length = "0x134")]
	private float GetTimeRequirementHoursPrecise()
	{
		return 0f;
	}

	[Token(Token = "0x60024B5")]
	[Address(RVA = "0x4AF5E0", Offset = "0x4AE3E0", Length = "0x43")]
	public ResearchItem()
	{
	}
}
