using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x2000963")]
public class SteamPipeGauge : MonoBehaviour
{
	[Tooltip("The steam pipe this gauge is connected to and will gather flow value from.")]
	[Token(Token = "0x40061A6")]
	[FieldOffset(Offset = "0x20")]
	public SteamPipe m_SteamPipe;

	[Tooltip("The physical needle to be adjusted based on steam pipe flow.")]
	[Token(Token = "0x40061A7")]
	[FieldOffset(Offset = "0x28")]
	public Transform m_GaugeNeedle;

	[Tooltip("The maximum amount of flow this gauge needle can detect.")]
	[Token(Token = "0x40061A8")]
	[FieldOffset(Offset = "0x30")]
	public float m_GaugeNeedleMaxFlow;

	[Tooltip("The minimum amount of flow this gauge needle can detect.")]
	[Token(Token = "0x40061A9")]
	[FieldOffset(Offset = "0x34")]
	public float m_GaugeNeedleMinFlow;

	[Tooltip("The maximum rotation angle when the steam pipe is at maximum flow.")]
	[Token(Token = "0x40061AA")]
	[FieldOffset(Offset = "0x38")]
	public float m_GaugeNeedleMaxAngle;

	[Tooltip("The minimum rotation angle when the steam pipe is at minimum flow.")]
	[Token(Token = "0x40061AB")]
	[FieldOffset(Offset = "0x3C")]
	public float m_GaugeNeedleMinAngle;

	[Tooltip("How much in percent to rotate over pitch, yaw and roll. Can be negative if rotation is in opposite direction. From -1 to 1.")]
	[Token(Token = "0x40061AC")]
	[FieldOffset(Offset = "0x40")]
	public Vector3 m_GaugeNeedleRotationAngleFactors;

	[Tooltip("Default is the internal pressure registered. When enabled, measure how much pressure is escaping when the valve is open.")]
	[Token(Token = "0x40061AD")]
	[FieldOffset(Offset = "0x4C")]
	public bool m_MeasureOutput;

	[Tooltip("How smoothly to animate the needle towards the target value (lower value = slower/smoother)")]
	[Token(Token = "0x40061AE")]
	[FieldOffset(Offset = "0x50")]
	public float m_AnimationSmoothing;

	[Tooltip("The amount of random movement in the needle when at max flow (in degrees)")]
	[Token(Token = "0x40061AF")]
	[FieldOffset(Offset = "0x54")]
	public float m_MaxFlowRandomness;

	[Token(Token = "0x40061B0")]
	[FieldOffset(Offset = "0x58")]
	private Renderer m_NeedleRenderer;

	[Token(Token = "0x40061B1")]
	[FieldOffset(Offset = "0x60")]
	private float m_GaugeNeedleCurrentAngle;

	[Token(Token = "0x40061B2")]
	[FieldOffset(Offset = "0x64")]
	private float m_GaugeNeedleTargetAngle;

	[Token(Token = "0x40061B3")]
	[FieldOffset(Offset = "0x68")]
	private float m_GaugeNeedleFlowRange;

	[Token(Token = "0x60054DA")]
	[Address(RVA = "0xE905C0", Offset = "0xE8F3C0", Length = "0x1C1")]
	public void Start()
	{
	}

	[Token(Token = "0x60054DB")]
	[Address(RVA = "0xE90790", Offset = "0xE8F590", Length = "0x7")]
	public void Update()
	{
	}

	[Token(Token = "0x60054DC")]
	[Address(RVA = "0xE907A0", Offset = "0xE8F5A0", Length = "0x2E0")]
	private void UpdateGaugeNeedle()
	{
	}

	[Token(Token = "0x60054DD")]
	[Address(RVA = "0xE90A90", Offset = "0xE8F890", Length = "0x87")]
	public SteamPipeGauge()
	{
	}
}
