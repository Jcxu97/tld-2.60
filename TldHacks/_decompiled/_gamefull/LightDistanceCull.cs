using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x20003C0")]
public class LightDistanceCull : MonoBehaviour
{
	[Token(Token = "0x20003C1")]
	private struct LightDef
	{
		[Token(Token = "0x40021D5")]
		[FieldOffset(Offset = "0x0")]
		public List<Light> m_Light;

		[Token(Token = "0x40021D6")]
		[FieldOffset(Offset = "0x8")]
		public List<Vector3> m_Position;

		[Token(Token = "0x40021D7")]
		[FieldOffset(Offset = "0x10")]
		public List<bool> m_PrevState;

		[Token(Token = "0x40021D8")]
		[FieldOffset(Offset = "0x18")]
		public List<float> m_StartIntensity;

		[Token(Token = "0x6001D78")]
		[Address(RVA = "0x7A3EE0", Offset = "0x7A2CE0", Length = "0x2AE")]
		public void Initialize(int size)
		{
		}

		[Token(Token = "0x6001D79")]
		[Address(RVA = "0x7A4190", Offset = "0x7A2F90", Length = "0x34C")]
		public void AddFX(Light light)
		{
		}

		[Token(Token = "0x6001D7A")]
		[Address(RVA = "0x7A44E0", Offset = "0x7A32E0", Length = "0x1BF")]
		public void RemoveFX(Light light)
		{
		}

		[Token(Token = "0x6001D7B")]
		[Address(RVA = "0x7A46A0", Offset = "0x7A34A0", Length = "0x2EB")]
		public void UpdateLight(Vector3 camPos, float maxDistSqr, float fadeDistSqr, bool useCurrentLightIntensity)
		{
		}
	}

	[Header("PC values")]
	[Token(Token = "0x40021C8")]
	[FieldOffset(Offset = "0x20")]
	public float m_LowDistance;

	[Token(Token = "0x40021C9")]
	[FieldOffset(Offset = "0x24")]
	public float m_MediumDistance;

	[Token(Token = "0x40021CA")]
	[FieldOffset(Offset = "0x28")]
	public float m_HighDistance;

	[Token(Token = "0x40021CB")]
	[FieldOffset(Offset = "0x2C")]
	public float m_UltraDistance;

	[Header("Fade particles n% from maximum distance.")]
	[Token(Token = "0x40021CC")]
	[FieldOffset(Offset = "0x30")]
	public float m_FadePercentage;

	[Header("Whether another system is controlling the light intensity every frame")]
	[Tooltip("Enable this setting when we should be fading from the current light intensity and not the original intensity")]
	[Token(Token = "0x40021CD")]
	[FieldOffset(Offset = "0x34")]
	public bool m_UseCurrentLightIntensity;

	[Header("Timing, in seconds")]
	[Token(Token = "0x40021CE")]
	[FieldOffset(Offset = "0x38")]
	public float m_UpdateFrequency;

	[Header("Light list")]
	[Token(Token = "0x40021CF")]
	[FieldOffset(Offset = "0x40")]
	public List<Light> m_LightList;

	[Token(Token = "0x40021D0")]
	[FieldOffset(Offset = "0x48")]
	private LightDef m_LightDef;

	[Token(Token = "0x40021D1")]
	[FieldOffset(Offset = "0x68")]
	private float m_UpdateTime;

	[Token(Token = "0x40021D2")]
	[FieldOffset(Offset = "0x6C")]
	private float m_MaxDistSqr;

	[Token(Token = "0x40021D3")]
	[FieldOffset(Offset = "0x70")]
	private float m_FadeDistSqr;

	[Token(Token = "0x40021D4")]
	[FieldOffset(Offset = "0x74")]
	private QualityLodBias m_CachedQuality;

	[Token(Token = "0x6001D73")]
	[Address(RVA = "0x7A3740", Offset = "0x7A2540", Length = "0x31B")]
	private void Start()
	{
	}

	[Token(Token = "0x6001D74")]
	[Address(RVA = "0x7A3A60", Offset = "0x7A2860", Length = "0x25D")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x6001D75")]
	[Address(RVA = "0x7A3CC0", Offset = "0x7A2AC0", Length = "0x5E")]
	private void UpdateQualityValues()
	{
	}

	[Token(Token = "0x6001D76")]
	[Address(RVA = "0x7A3D20", Offset = "0x7A2B20", Length = "0x148")]
	private void UpdateLights()
	{
	}

	[Token(Token = "0x6001D77")]
	[Address(RVA = "0x7A3E70", Offset = "0x7A2C70", Length = "0x6D")]
	public LightDistanceCull()
	{
	}
}
