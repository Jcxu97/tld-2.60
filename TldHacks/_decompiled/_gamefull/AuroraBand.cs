using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x2000357")]
public class AuroraBand : MonoBehaviour
{
	[Tooltip("The speed of the animation.")]
	[Range(-0.1f, 0.1f)]
	[Token(Token = "0x4001D77")]
	[FieldOffset(Offset = "0x20")]
	public float m_AnimSpeed;

	[Tooltip("The start point of the animation.")]
	[Range(0f, 1f)]
	[Token(Token = "0x4001D78")]
	[FieldOffset(Offset = "0x24")]
	public float m_AnimStart;

	[Tooltip("UV scroll rate of the main texture.")]
	[Token(Token = "0x4001D79")]
	[FieldOffset(Offset = "0x28")]
	public Vector2 m_MainTexScrollRate;

	[Tooltip("UV scroll rate of the alpha texture.")]
	[Token(Token = "0x4001D7A")]
	[FieldOffset(Offset = "0x30")]
	public Vector2 m_AlphaTexScrollRate;

	[Tooltip("Primary speed control for all systems.")]
	[Range(0f, 100f)]
	[Token(Token = "0x4001D7B")]
	[FieldOffset(Offset = "0x38")]
	public float m_SpeedPercentage;

	[Token(Token = "0x4001D7C")]
	[FieldOffset(Offset = "0x3C")]
	private Color m_CurColour;

	[Token(Token = "0x4001D7D")]
	[FieldOffset(Offset = "0x4C")]
	private Vector2 uvOffsetMain;

	[Token(Token = "0x4001D7E")]
	[FieldOffset(Offset = "0x54")]
	private Vector2 uvOffsetMask;

	[Token(Token = "0x4001D7F")]
	[FieldOffset(Offset = "0x60")]
	private Renderer m_Renderer;

	[Token(Token = "0x4001D80")]
	[FieldOffset(Offset = "0x68")]
	private Material m_Material;

	[Token(Token = "0x4001D81")]
	[FieldOffset(Offset = "0x70")]
	private Animation m_Animation;

	[Token(Token = "0x4001D82")]
	[FieldOffset(Offset = "0x78")]
	private float m_LastAlpha;

	[Token(Token = "0x4001D83")]
	[FieldOffset(Offset = "0x7C")]
	private float curLerp;

	[Token(Token = "0x4001D84")]
	[FieldOffset(Offset = "0x80")]
	private bool m_IsTriggeredColour;

	[Token(Token = "0x4001D85")]
	[FieldOffset(Offset = "0x84")]
	private Color m_TriggeredColour;

	[Token(Token = "0x4001D86")]
	[FieldOffset(Offset = "0x94")]
	private float m_TriggeredColourTime;

	[Token(Token = "0x4001D87")]
	[FieldOffset(Offset = "0x98")]
	private float m_TriggeredColourLerp;

	[Token(Token = "0x6001B43")]
	[Address(RVA = "0x75B0B0", Offset = "0x759EB0", Length = "0x518")]
	private void Start()
	{
	}

	[Token(Token = "0x6001B44")]
	[Address(RVA = "0x75B5D0", Offset = "0x75A3D0", Length = "0x133")]
	public void OnDestroy()
	{
	}

	[Token(Token = "0x6001B45")]
	[Address(RVA = "0x75B710", Offset = "0x75A510", Length = "0x424")]
	private void Update()
	{
	}

	[Token(Token = "0x6001B46")]
	[Address(RVA = "0x75BB40", Offset = "0x75A940", Length = "0x199")]
	private void UpdateColour()
	{
	}

	[Token(Token = "0x6001B47")]
	[Address(RVA = "0x75BCE0", Offset = "0x75AAE0", Length = "0x453")]
	private void UpdateUV()
	{
	}

	[Token(Token = "0x6001B48")]
	[Address(RVA = "0x75C140", Offset = "0x75AF40", Length = "0x88")]
	public void SetAlpha(float alpha)
	{
	}

	[Token(Token = "0x6001B49")]
	[Address(RVA = "0x75C1D0", Offset = "0x75AFD0", Length = "0x24")]
	public void TriggerColour(Color newColour, float lerpTime)
	{
	}

	[Token(Token = "0x6001B4A")]
	[Address(RVA = "0x75C200", Offset = "0x75B000", Length = "0x18")]
	public void ReturnColour(float lerpTime)
	{
	}

	[Token(Token = "0x6001B4B")]
	[Address(RVA = "0x75C220", Offset = "0x75B020", Length = "0xF5")]
	public AuroraBand()
	{
	}
}
