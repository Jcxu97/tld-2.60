using Cpp2ILInjected;
using InteractiveObjects;
using TLD.FX;
using UnityEngine;

[Token(Token = "0x2000390")]
public class FirstPersonHandheldShortwave : MonoBehaviour
{
	[Header("Signal Strength Meter")]
	[Token(Token = "0x4001FD6")]
	[FieldOffset(Offset = "0x20")]
	public Transform m_SignalStrengthMeterTransform;

	[SerializeField]
	[Token(Token = "0x4001FD7")]
	[FieldOffset(Offset = "0x28")]
	private AnimationCurve m_NeedleAngleCurve;

	[SerializeField]
	[Token(Token = "0x4001FD8")]
	[FieldOffset(Offset = "0x30")]
	private Vector2 m_NeedleNoiseSpeed;

	[SerializeField]
	[Token(Token = "0x4001FD9")]
	[FieldOffset(Offset = "0x38")]
	private float m_NeedleNoiseAmplitude;

	[SerializeField]
	[Token(Token = "0x4001FDA")]
	[FieldOffset(Offset = "0x3C")]
	private float m_NeedleMovementSmoothingRate;

	[Header("VFX")]
	[SerializeField]
	[Token(Token = "0x4001FDB")]
	[FieldOffset(Offset = "0x40")]
	private EmissiveGlow m_EmissiveGlow;

	[SerializeField]
	[Token(Token = "0x4001FDC")]
	[FieldOffset(Offset = "0x48")]
	private EmissiveGlow.Channel m_GaugeGlowMaskChannel;

	[SerializeField]
	[Token(Token = "0x4001FDD")]
	[FieldOffset(Offset = "0x4C")]
	private EmissiveGlow.Channel m_BlinkingLightGlowMaskChannel;

	[Token(Token = "0x4001FDE")]
	[FieldOffset(Offset = "0x50")]
	private float m_LedBlinkTimer;

	[Token(Token = "0x4001FDF")]
	[FieldOffset(Offset = "0x54")]
	private bool m_LastElectrostaticForceActive;

	[Token(Token = "0x4001FE0")]
	[FieldOffset(Offset = "0x58")]
	private float m_NeedleIntensity;

	[Token(Token = "0x4001FE1")]
	[FieldOffset(Offset = "0x5C")]
	private float m_NeedleVelocity;

	[Token(Token = "0x4001FE2")]
	[FieldOffset(Offset = "0x60")]
	private HandheldShortwaveItem m_Lasthhsw;

	[Token(Token = "0x6001C75")]
	[Address(RVA = "0x781FD0", Offset = "0x780DD0", Length = "0x732")]
	private void Update()
	{
	}

	[Token(Token = "0x6001C76")]
	[Address(RVA = "0x782710", Offset = "0x781510", Length = "0x190")]
	private void OnTrackingModeChanged(TrackableItemType trackingMode)
	{
	}

	[Token(Token = "0x6001C77")]
	[Address(RVA = "0x7828B0", Offset = "0x7816B0", Length = "0x4F6")]
	private void UpdateIntensityNeedle(HandheldShortwaveItem hhsw)
	{
	}

	[Token(Token = "0x6001C78")]
	[Address(RVA = "0x782DB0", Offset = "0x781BB0", Length = "0x1C7")]
	private void UpdateBlinkingLight(HandheldShortwaveItem hhsw)
	{
	}

	[Token(Token = "0x6001C79")]
	[Address(RVA = "0x4AF5E0", Offset = "0x4AE3E0", Length = "0x43")]
	public FirstPersonHandheldShortwave()
	{
	}
}
