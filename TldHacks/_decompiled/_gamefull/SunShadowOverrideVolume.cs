using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x20009E0")]
public class SunShadowOverrideVolume : MonoBehaviour
{
	[SerializeField]
	[Token(Token = "0x400643B")]
	[FieldOffset(Offset = "0x20")]
	private BoxCollider m_InnerCollider;

	[SerializeField]
	[Token(Token = "0x400643C")]
	[FieldOffset(Offset = "0x28")]
	private BoxCollider m_OuterCollider;

	[SerializeField]
	[Token(Token = "0x400643D")]
	[FieldOffset(Offset = "0x30")]
	private int m_Priority;

	[SerializeField]
	[Token(Token = "0x400643E")]
	[FieldOffset(Offset = "0x34")]
	private float m_ShadowStrength;

	[SerializeField]
	[Token(Token = "0x400643F")]
	[FieldOffset(Offset = "0x38")]
	private TODStateData m_TODStateData;

	[SerializeField]
	[Token(Token = "0x4006440")]
	[FieldOffset(Offset = "0x40")]
	private AnimationCurve m_StrengthBlendCurve;

	[SerializeField]
	[Token(Token = "0x4006441")]
	[FieldOffset(Offset = "0x48")]
	private AnimationCurve m_ColorBlendCurve;

	[Token(Token = "0x4006442")]
	private const string PLAYER_TRIGGER_TAG = "Player";

	[Token(Token = "0x6005701")]
	[Address(RVA = "0x677F80", Offset = "0x676D80", Length = "0x4")]
	public int GetPriority()
	{
		return 0;
	}

	[Token(Token = "0x6005702")]
	[Address(RVA = "0xEC7A10", Offset = "0xEC6810", Length = "0x11B")]
	public void BlendShadowStrength(ref float sunShadow, ref float moonShadow)
	{
	}

	[Token(Token = "0x6005703")]
	[Address(RVA = "0xEC7B30", Offset = "0xEC6930", Length = "0x143")]
	public void BlendShadowColor(ref Color shadowColor)
	{
	}

	[Token(Token = "0x6005704")]
	[Address(RVA = "0xEC7C80", Offset = "0xEC6A80", Length = "0x199")]
	public void BlendTODState(TODStateData sourceStateData)
	{
	}

	[Token(Token = "0x6005705")]
	[Address(RVA = "0xEC7E20", Offset = "0xEC6C20", Length = "0xAC")]
	private void Start()
	{
	}

	[Token(Token = "0x6005706")]
	[Address(RVA = "0xEC7ED0", Offset = "0xEC6CD0", Length = "0xAB")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x6005707")]
	[Address(RVA = "0xEC7F80", Offset = "0xEC6D80", Length = "0xAB")]
	private void OnTriggerExit(Collider other)
	{
	}

	[Token(Token = "0x6005708")]
	[Address(RVA = "0xEC8030", Offset = "0xEC6E30", Length = "0x63")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6005709")]
	[Address(RVA = "0xEC80A0", Offset = "0xEC6EA0", Length = "0x171")]
	private bool IsValid()
	{
		return false;
	}

	[Token(Token = "0x600570A")]
	[Address(RVA = "0xEC8220", Offset = "0xEC7020", Length = "0x76C")]
	private float GetBlendFactor()
	{
		return 0f;
	}

	[Token(Token = "0x600570B")]
	[Address(RVA = "0xEC8990", Offset = "0xEC7790", Length = "0x146")]
	public SunShadowOverrideVolume()
	{
	}
}
