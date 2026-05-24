using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x2000425")]
public class HeatSource : MonoBehaviour
{
	[Token(Token = "0x400256A")]
	[FieldOffset(Offset = "0x20")]
	public float m_MaxTempIncrease;

	[Token(Token = "0x400256B")]
	[FieldOffset(Offset = "0x24")]
	public float m_MaxTempIncreaseInnerRadius;

	[Token(Token = "0x400256C")]
	[FieldOffset(Offset = "0x28")]
	public float m_MaxTempIncreaseOuterRadius;

	[Token(Token = "0x400256D")]
	[FieldOffset(Offset = "0x2C")]
	public float m_TimeToReachMaxTempMinutes;

	[Token(Token = "0x400256E")]
	[FieldOffset(Offset = "0x30")]
	public float m_StartingTemp;

	[Token(Token = "0x400256F")]
	[FieldOffset(Offset = "0x34")]
	public bool m_StartOn;

	[HideInInspector]
	[Token(Token = "0x4002570")]
	[FieldOffset(Offset = "0x35")]
	public bool m_MaskTempIncrease;

	[Token(Token = "0x4002571")]
	[FieldOffset(Offset = "0x38")]
	private float m_TempIncrease;

	[Token(Token = "0x4002572")]
	[FieldOffset(Offset = "0x3C")]
	private bool m_TurnedOn;

	[Token(Token = "0x4002573")]
	private static HeatSourceSaveDataProxy m_HeatSourceSaveDataProxy;

	[Token(Token = "0x6001F43")]
	[Address(RVA = "0x7D8F40", Offset = "0x7D7D40", Length = "0xC")]
	public void Awake()
	{
	}

	[Token(Token = "0x6001F44")]
	[Address(RVA = "0x7D8F50", Offset = "0x7D7D50", Length = "0xE")]
	public void Start()
	{
	}

	[Token(Token = "0x6001F45")]
	[Address(RVA = "0x7D8F60", Offset = "0x7D7D60", Length = "0x1AD")]
	public void Update()
	{
	}

	[Token(Token = "0x6001F46")]
	[Address(RVA = "0x7D9110", Offset = "0x7D7F10", Length = "0x180")]
	public string Serialize()
	{
		return null;
	}

	[Token(Token = "0x6001F47")]
	[Address(RVA = "0x7D92A0", Offset = "0x7D80A0", Length = "0xC0")]
	public void Deserialize(string text)
	{
	}

	[Token(Token = "0x6001F48")]
	[Address(RVA = "0x7D9370", Offset = "0x7D8170", Length = "0x24D")]
	public float GetTempIncrease(Vector3 pos)
	{
		return 0f;
	}

	[Token(Token = "0x6001F49")]
	[Address(RVA = "0x4C38C0", Offset = "0x4C26C0", Length = "0x5")]
	public bool IsTurnedOn()
	{
		return false;
	}

	[Token(Token = "0x6001F4A")]
	[Address(RVA = "0x7D95C0", Offset = "0x7D83C0", Length = "0x65")]
	public void TurnOffImmediate()
	{
	}

	[Token(Token = "0x6001F4B")]
	[Address(RVA = "0x6208B0", Offset = "0x61F6B0", Length = "0x6")]
	public float GetCurrentTempIncrease()
	{
		return 0f;
	}

	[Token(Token = "0x6001F4C")]
	[Address(RVA = "0x7D9630", Offset = "0x7D8430", Length = "0x1E6")]
	public void TurnOn()
	{
	}

	[Token(Token = "0x6001F4D")]
	[Address(RVA = "0x7D9820", Offset = "0x7D8620", Length = "0x5")]
	public void TurnOff()
	{
	}

	[Token(Token = "0x6001F4E")]
	[Address(RVA = "0x7D9830", Offset = "0x7D8630", Length = "0x61")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6001F4F")]
	[Address(RVA = "0x4AF5E0", Offset = "0x4AE3E0", Length = "0x43")]
	public HeatSource()
	{
	}
}
