using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x20003D8")]
public class MechanicalClock : MonoBehaviour
{
	[Token(Token = "0x40022AC")]
	[FieldOffset(Offset = "0x20")]
	public GameObject m_HourHand;

	[Token(Token = "0x40022AD")]
	[FieldOffset(Offset = "0x28")]
	public GameObject m_MinuteHand;

	[Token(Token = "0x40022AE")]
	[FieldOffset(Offset = "0x30")]
	public GameObject m_Pendulum;

	[Token(Token = "0x40022AF")]
	[FieldOffset(Offset = "0x38")]
	public GameObject m_Weight1;

	[Token(Token = "0x40022B0")]
	[FieldOffset(Offset = "0x40")]
	public GameObject m_Weight2;

	[Tooltip("How long does the clock run for when it's fully wound? Grandfather clocks are typically 8 days, alarm clocks 1.5 days.")]
	[Token(Token = "0x40022B1")]
	[FieldOffset(Offset = "0x48")]
	public float m_ClockWindTimeDays;

	[Tooltip("How long does one full swing take? Grandfather clocks are 1 second per half swing, or 2 seconds there and back.")]
	[Token(Token = "0x40022B2")]
	[FieldOffset(Offset = "0x4C")]
	public float m_PendulumPeriod;

	[Tooltip("How far does the pendulum swing? Grandfather clocks are between 4 and 6 degrees total.")]
	[Token(Token = "0x40022B3")]
	[FieldOffset(Offset = "0x50")]
	public float m_PendulumHalfAngle;

	[Tooltip("How far does the weight move in the Y direction? This is an offset from it's original starting position.")]
	[Token(Token = "0x40022B4")]
	[FieldOffset(Offset = "0x54")]
	public float m_WeightMoveDistance;

	[Token(Token = "0x40022B5")]
	[FieldOffset(Offset = "0x58")]
	public bool m_IsActive;

	[Token(Token = "0x40022B6")]
	[FieldOffset(Offset = "0x5C")]
	private float m_CurWindTimeSeconds;

	[Token(Token = "0x40022B7")]
	[FieldOffset(Offset = "0x60")]
	private float m_TimerPendulum;

	[Token(Token = "0x40022B8")]
	[FieldOffset(Offset = "0x64")]
	private float m_TimerLerp;

	[Token(Token = "0x40022B9")]
	[FieldOffset(Offset = "0x68")]
	private Vector3 m_Weight1StartPos;

	[Token(Token = "0x40022BA")]
	[FieldOffset(Offset = "0x74")]
	private Vector3 m_Weight2StartPos;

	[Token(Token = "0x40022BB")]
	[FieldOffset(Offset = "0x80")]
	private Vector3 m_Weight1EndPos;

	[Token(Token = "0x40022BC")]
	[FieldOffset(Offset = "0x8C")]
	private Vector3 m_Weight2EndPos;

	[Token(Token = "0x40022BD")]
	[FieldOffset(Offset = "0x98")]
	private int m_CurDaySeconds;

	[Token(Token = "0x6001DE8")]
	[Address(RVA = "0x7AE470", Offset = "0x7AD270", Length = "0x374")]
	private void Start()
	{
	}

	[Token(Token = "0x6001DE9")]
	[Address(RVA = "0x7AE7F0", Offset = "0x7AD5F0", Length = "0x1F7")]
	private void Update()
	{
	}

	[Token(Token = "0x6001DEA")]
	[Address(RVA = "0x7AE9F0", Offset = "0x7AD7F0", Length = "0x10A")]
	private void UpdatePendulum()
	{
	}

	[Token(Token = "0x6001DEB")]
	[Address(RVA = "0x7AEB00", Offset = "0x7AD900", Length = "0x304")]
	private void UpdateWeights()
	{
	}

	[Token(Token = "0x6001DEC")]
	[Address(RVA = "0x7AEE10", Offset = "0x7ADC10", Length = "0x1EB")]
	private void UpdateHands()
	{
	}

	[Token(Token = "0x6001DED")]
	[Address(RVA = "0x7AF000", Offset = "0x7ADE00", Length = "0x5F")]
	public MechanicalClock()
	{
	}
}
