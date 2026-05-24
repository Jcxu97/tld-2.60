using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x2000358")]
public class AuroraBand_OneOff : MonoBehaviour
{
	[Tooltip("Animation speed of the mesh.")]
	[Range(-0.1f, 0.1f)]
	[Token(Token = "0x4001D88")]
	[FieldOffset(Offset = "0x20")]
	public float animSpeed;

	[Range(0f, 1f)]
	[Tooltip("Start point of the animation.")]
	[Token(Token = "0x4001D89")]
	[FieldOffset(Offset = "0x24")]
	public float animStart;

	[Tooltip("Main texture scroll rate.")]
	[Token(Token = "0x4001D8A")]
	[FieldOffset(Offset = "0x28")]
	public Vector2 mainTexSpinRate;

	[Tooltip("Alpha mask texture scroll rate.")]
	[Token(Token = "0x4001D8B")]
	[FieldOffset(Offset = "0x30")]
	public Vector2 alphaTexSpinRate;

	[Tooltip("RGB colour offset minimum values.")]
	[Token(Token = "0x4001D8C")]
	[FieldOffset(Offset = "0x38")]
	public Vector3 rgbMin;

	[Tooltip("RGB colour offset maximum values.")]
	[Token(Token = "0x4001D8D")]
	[FieldOffset(Offset = "0x44")]
	public Vector3 rgbMax;

	[Tooltip("RGB colour offset cycle speeds.")]
	[Token(Token = "0x4001D8E")]
	[FieldOffset(Offset = "0x50")]
	public Vector3 cycleRGBTime;

	[Range(0f, 100f)]
	[Tooltip("Global speed control.")]
	[Token(Token = "0x4001D8F")]
	[FieldOffset(Offset = "0x5C")]
	public float speedPercentage;

	[Token(Token = "0x4001D90")]
	[FieldOffset(Offset = "0x60")]
	private Vector2 uvOffsetMain;

	[Token(Token = "0x4001D91")]
	[FieldOffset(Offset = "0x68")]
	private Vector2 uvOffsetMask;

	[Token(Token = "0x4001D92")]
	[FieldOffset(Offset = "0x70")]
	private Vector3 colorTimers;

	[Token(Token = "0x4001D93")]
	[FieldOffset(Offset = "0x80")]
	private Renderer m_Renderer;

	[Token(Token = "0x4001D94")]
	[FieldOffset(Offset = "0x88")]
	private Animation m_Animation;

	[Token(Token = "0x6001B4C")]
	[Address(RVA = "0x75C320", Offset = "0x75B120", Length = "0x1E6")]
	private void Start()
	{
	}

	[Token(Token = "0x6001B4D")]
	[Address(RVA = "0x75C510", Offset = "0x75B310", Length = "0x524")]
	private void Update()
	{
	}

	[Token(Token = "0x6001B4E")]
	[Address(RVA = "0x75CA40", Offset = "0x75B840", Length = "0x194")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x6001B4F")]
	[Address(RVA = "0x75CBE0", Offset = "0x75B9E0", Length = "0x13A")]
	public void SetAlpha(float alpha)
	{
	}

	[Token(Token = "0x6001B50")]
	[Address(RVA = "0x75CD20", Offset = "0x75BB20", Length = "0x110")]
	private Color SetColor()
	{
		return default(Color);
	}

	[Token(Token = "0x6001B51")]
	[Address(RVA = "0x75CE30", Offset = "0x75BC30", Length = "0x1B1")]
	public AuroraBand_OneOff()
	{
	}
}
