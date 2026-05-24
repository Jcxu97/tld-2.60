using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x200044D")]
public class Willpower : MonoBehaviour
{
	[Token(Token = "0x40026FD")]
	[FieldOffset(Offset = "0x20")]
	public float m_TimeRemainingSeconds;

	[Token(Token = "0x40026FE")]
	[FieldOffset(Offset = "0x24")]
	public float m_ConditionBonusPerSecond;

	[Token(Token = "0x40026FF")]
	[FieldOffset(Offset = "0x28")]
	public float m_ConditionBonusCap;

	[Token(Token = "0x4002700")]
	[FieldOffset(Offset = "0x2C")]
	public float m_ConditionDamageScale;

	[Token(Token = "0x4002701")]
	[FieldOffset(Offset = "0x30")]
	private bool m_StartHasBeenCalled;

	[Token(Token = "0x4002702")]
	private static WillpowerSaveDataProxy m_WillpowerSaveDataProxy;

	[Token(Token = "0x600206B")]
	[Address(RVA = "0x7F8500", Offset = "0x7F7300", Length = "0xB")]
	public void Start()
	{
	}

	[Token(Token = "0x600206C")]
	[Address(RVA = "0x7F8510", Offset = "0x7F7310", Length = "0x8E")]
	public void Update()
	{
	}

	[Token(Token = "0x600206D")]
	[Address(RVA = "0x7F85A0", Offset = "0x7F73A0", Length = "0xDF")]
	public string Serialize()
	{
		return null;
	}

	[Token(Token = "0x600206E")]
	[Address(RVA = "0x7F8680", Offset = "0x7F7480", Length = "0x96")]
	public void Deserialize(string text)
	{
	}

	[Token(Token = "0x600206F")]
	[Address(RVA = "0x7F8720", Offset = "0x7F7520", Length = "0x69")]
	public bool GetActive()
	{
		return false;
	}

	[Token(Token = "0x6002070")]
	[Address(RVA = "0x504300", Offset = "0x503100", Length = "0x6")]
	public void SetActive(float timeSeconds)
	{
	}

	[Token(Token = "0x6002071")]
	[Address(RVA = "0x504310", Offset = "0x503110", Length = "0x6")]
	public float GetConditionBonusPerSecond()
	{
		return 0f;
	}

	[Token(Token = "0x6002072")]
	[Address(RVA = "0x504290", Offset = "0x503090", Length = "0x6")]
	public float GetConditionBonusCap()
	{
		return 0f;
	}

	[Token(Token = "0x6002073")]
	[Address(RVA = "0x5093C0", Offset = "0x5081C0", Length = "0x6")]
	public float GetConditionDamageScale()
	{
		return 0f;
	}

	[Token(Token = "0x6002074")]
	[Address(RVA = "0x4AF5E0", Offset = "0x4AE3E0", Length = "0x43")]
	public Willpower()
	{
	}
}
