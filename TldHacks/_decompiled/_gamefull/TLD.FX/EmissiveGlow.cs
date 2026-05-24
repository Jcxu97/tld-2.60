using System;
using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.Events;

namespace TLD.FX;

[Token(Token = "0x20013D7")]
public class EmissiveGlow : MonoBehaviour
{
	[Flags]
	[Token(Token = "0x20013D8")]
	public enum Channel
	{
		[Token(Token = "0x4009170")]
		Red = 1,
		[Token(Token = "0x4009171")]
		Green = 2,
		[Token(Token = "0x4009172")]
		Blue = 4
	}

	[SerializeField]
	[Token(Token = "0x4009162")]
	[FieldOffset(Offset = "0x20")]
	private Renderer[] m_AffectedRenderers;

	[SerializeField]
	[Token(Token = "0x4009163")]
	[FieldOffset(Offset = "0x28")]
	private bool m_NormalizeToCurve;

	[SerializeField]
	[Token(Token = "0x4009164")]
	[FieldOffset(Offset = "0x30")]
	private AnimationCurve m_StrengthCurve;

	[SerializeField]
	[Token(Token = "0x4009165")]
	[FieldOffset(Offset = "0x38")]
	private UnityEvent<Color> m_ColorChanged;

	[SerializeField]
	[Token(Token = "0x4009166")]
	[FieldOffset(Offset = "0x40")]
	private UnityEvent<float> m_StrengthChanged;

	[SerializeField]
	[Token(Token = "0x4009167")]
	[FieldOffset(Offset = "0x48")]
	private UnityEvent<float> m_RedChannelStrengthChanged;

	[SerializeField]
	[Token(Token = "0x4009168")]
	[FieldOffset(Offset = "0x50")]
	private UnityEvent<float> m_GreenChannelStrengthChanged;

	[SerializeField]
	[Token(Token = "0x4009169")]
	[FieldOffset(Offset = "0x58")]
	private UnityEvent<float> m_BlueChannelStrengthChanged;

	[Token(Token = "0x400916A")]
	[FieldOffset(Offset = "0x60")]
	private MaterialPropertyBlock m_PropertyBlock;

	[Token(Token = "0x400916B")]
	[FieldOffset(Offset = "0x68")]
	private Vector4 m_EmissiveStrengths;

	[Token(Token = "0x400916C")]
	private static readonly int s_EmissiveColorID;

	[Token(Token = "0x400916D")]
	private static readonly int s_EmissiveStrengthID;

	[Token(Token = "0x400916E")]
	private static readonly int s_EmissiveStrengthByChannelID;

	[Token(Token = "0x6007EA8")]
	[Address(RVA = "0x11E3810", Offset = "0x11E2610", Length = "0xD2")]
	private void Awake()
	{
	}

	[Token(Token = "0x6007EA9")]
	[Address(RVA = "0x11E38F0", Offset = "0x11E26F0", Length = "0x226")]
	private void OnValidate()
	{
	}

	[Token(Token = "0x6007EAA")]
	[Address(RVA = "0x11E3B20", Offset = "0x11E2920", Length = "0x11C")]
	public void UpdateEmissiveColor(Color color)
	{
	}

	[Token(Token = "0x6007EAB")]
	[Address(RVA = "0x11E3C40", Offset = "0x11E2A40", Length = "0x138")]
	public void UpdateEmissiveStrength(float strength)
	{
	}

	[Token(Token = "0x6007EAC")]
	[Address(RVA = "0x11E3D80", Offset = "0x11E2B80", Length = "0x1F1")]
	public void UpdateEmissiveStrengthByChannel(float strength, Channel maskChannel)
	{
	}

	[Token(Token = "0x6007EAD")]
	[Address(RVA = "0x11E3F80", Offset = "0x11E2D80", Length = "0x83")]
	private void UpdateChannel(float strength, Channel maskChannel, Channel comparison, int colorIndex, UnityEvent<float> callback)
	{
	}

	[Token(Token = "0x6007EAE")]
	[Address(RVA = "0x11E4010", Offset = "0x11E2E10", Length = "0x9E")]
	private float MaybeNormalizeStrengthToCurve(float strength)
	{
		return 0f;
	}

	[Token(Token = "0x6007EAF")]
	[Address(RVA = "0x11E40B0", Offset = "0x11E2EB0", Length = "0x10C")]
	private void UpdateRenderers()
	{
	}

	[Token(Token = "0x6007EB0")]
	[Address(RVA = "0x4AF5E0", Offset = "0x4AE3E0", Length = "0x43")]
	public EmissiveGlow()
	{
	}
}
