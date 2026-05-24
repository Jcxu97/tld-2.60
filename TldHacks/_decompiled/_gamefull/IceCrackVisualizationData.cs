using Cpp2ILInjected;
using UnityEngine;

[CreateAssetMenu(menuName = "The Long Dark/Vfx/Ice Crack Visualization Data")]
[Token(Token = "0x20003B4")]
public class IceCrackVisualizationData : ScriptableObject
{
	[SerializeField]
	[Token(Token = "0x4002111")]
	[FieldOffset(Offset = "0x18")]
	private float m_CrackDecalLifetime;

	[SerializeField]
	[Token(Token = "0x4002112")]
	[FieldOffset(Offset = "0x1C")]
	private float m_FallInDecalLifetime;

	[SerializeField]
	[Token(Token = "0x4002113")]
	[FieldOffset(Offset = "0x20")]
	private float m_RecrackBlendRate;

	[SerializeField]
	[Token(Token = "0x4002114")]
	[FieldOffset(Offset = "0x24")]
	private float m_AffectedRadius;

	[SerializeField]
	[Token(Token = "0x4002115")]
	[FieldOffset(Offset = "0x28")]
	private float m_SpacingRadius;

	[SerializeField]
	[Token(Token = "0x4002116")]
	[FieldOffset(Offset = "0x30")]
	private Material m_CrackDecalMaterial;

	[SerializeField]
	[Token(Token = "0x4002117")]
	[FieldOffset(Offset = "0x38")]
	private Material m_FallInDecalMaterial;

	[SerializeField]
	[Token(Token = "0x4002118")]
	[FieldOffset(Offset = "0x40")]
	private Vector3 m_DecalMinSize;

	[SerializeField]
	[Token(Token = "0x4002119")]
	[FieldOffset(Offset = "0x4C")]
	private Vector3 m_DecalMaxSize;

	[SerializeField]
	[Range(0f, 360f)]
	[Token(Token = "0x400211A")]
	[FieldOffset(Offset = "0x58")]
	private float m_DecalRotationRandomization;

	[SerializeField]
	[Token(Token = "0x400211B")]
	[FieldOffset(Offset = "0x60")]
	private AnimationCurve m_CrackRateDecalRChannel;

	[SerializeField]
	[Token(Token = "0x400211C")]
	[FieldOffset(Offset = "0x68")]
	private AnimationCurve m_CrackRateDecalGChannel;

	[SerializeField]
	[Token(Token = "0x400211D")]
	[FieldOffset(Offset = "0x70")]
	private AnimationCurve m_CrackRateDecalBChannel;

	[SerializeField]
	[Range(0f, 1f)]
	[Token(Token = "0x400211E")]
	[FieldOffset(Offset = "0x78")]
	private float m_CrackDecalStartRatio;

	[SerializeField]
	[Range(0f, 1f)]
	[Token(Token = "0x400211F")]
	[FieldOffset(Offset = "0x7C")]
	private float m_FallInDecalStartRatio;

	[Token(Token = "0x6001D30")]
	[Address(RVA = "0x7979E0", Offset = "0x7967E0", Length = "0x64")]
	public bool IsInSpacingRadius(Vector3 pos1, Vector3 pos2)
	{
		return false;
	}

	[Token(Token = "0x6001D31")]
	[Address(RVA = "0x797A50", Offset = "0x796850", Length = "0x64")]
	public bool IsInAffectedRadius(Vector3 pos1, Vector3 pos2)
	{
		return false;
	}

	[Token(Token = "0x6001D32")]
	[Address(RVA = "0x797AC0", Offset = "0x7968C0", Length = "0x62")]
	private bool IsInRange(Vector3 pos1, Vector3 pos2, float radius)
	{
		return false;
	}

	[Token(Token = "0x6001D33")]
	[Address(RVA = "0x797B30", Offset = "0x796930", Length = "0xE")]
	public Material GetMaterial(bool fellIntoWater)
	{
		return null;
	}

	[Token(Token = "0x6001D34")]
	[Address(RVA = "0x797B40", Offset = "0x796940", Length = "0x10")]
	public float GetLifetime(bool fellIntoWater)
	{
		return 0f;
	}

	[Token(Token = "0x6001D35")]
	[Address(RVA = "0x797B50", Offset = "0x796950", Length = "0x10")]
	public float GetStartingCrackRatio(bool fellIntoWater)
	{
		return 0f;
	}

	[Token(Token = "0x6001D36")]
	[Address(RVA = "0x797B60", Offset = "0x796960", Length = "0xEC")]
	public Vector3 GetRandomSize()
	{
		return default(Vector3);
	}

	[Token(Token = "0x6001D37")]
	[Address(RVA = "0x797C50", Offset = "0x796A50", Length = "0x119")]
	public Quaternion GetRandomRotation()
	{
		return default(Quaternion);
	}

	[Token(Token = "0x6001D38")]
	[Address(RVA = "0x797D70", Offset = "0x796B70", Length = "0x1AD")]
	public Vector3 GetCrackAmountByColorChannel(float normalizedTime)
	{
		return default(Vector3);
	}

	[Token(Token = "0x6001D39")]
	[Address(RVA = "0x797F20", Offset = "0x796D20", Length = "0xD3")]
	public float BlendRecrack(float currentUpdateTime)
	{
		return 0f;
	}

	[Token(Token = "0x6001D3A")]
	[Address(RVA = "0x4A22A0", Offset = "0x4A10A0", Length = "0x7")]
	public IceCrackVisualizationData()
	{
	}
}
