using Cpp2ILInjected;
using UnityEngine;

[RequireComponent(typeof(UISlider))]
[Token(Token = "0x2000275")]
public class ScrollbarThumbResizer : MonoBehaviour
{
	[Token(Token = "0x4001676")]
	[FieldOffset(Offset = "0x20")]
	public bool m_AlwaysSmoothScroll;

	[Token(Token = "0x4001677")]
	[FieldOffset(Offset = "0x28")]
	private UISlider m_Slider;

	[Token(Token = "0x4001678")]
	[FieldOffset(Offset = "0x30")]
	private UISprite m_ThumbSprite;

	[Token(Token = "0x4001679")]
	[FieldOffset(Offset = "0x38")]
	private UIWidget m_SliderFGWidget;

	[Token(Token = "0x400167A")]
	[FieldOffset(Offset = "0x40")]
	private UIWidget m_SliderBGWidget;

	[Token(Token = "0x400167B")]
	[FieldOffset(Offset = "0x48")]
	private int m_NumStepsVisible;

	[Token(Token = "0x400167C")]
	[FieldOffset(Offset = "0x4C")]
	private int m_NumStepsTotal;

	[Token(Token = "0x600157B")]
	[Address(RVA = "0x6A1650", Offset = "0x6A0450", Length = "0x308")]
	private void Start()
	{
	}

	[Token(Token = "0x600157C")]
	[Address(RVA = "0x6A1960", Offset = "0x6A0760", Length = "0xF4")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x600157D")]
	[Address(RVA = "0x6A1A60", Offset = "0x6A0860", Length = "0x68")]
	private void OnDragFinished()
	{
	}

	[Token(Token = "0x600157E")]
	[Address(RVA = "0x6A1AD0", Offset = "0x6A08D0", Length = "0x1A7")]
	private void CalculateAndSetThumbSize()
	{
	}

	[Token(Token = "0x600157F")]
	[Address(RVA = "0x6A1C80", Offset = "0x6A0A80", Length = "0xC7")]
	private float CalculateThumbValue()
	{
		return 0f;
	}

	[Token(Token = "0x6001580")]
	[Address(RVA = "0x6A1D50", Offset = "0x6A0B50", Length = "0xA77")]
	private void SetThumbPositionFromValue(float val)
	{
	}

	[Token(Token = "0x6001581")]
	[Address(RVA = "0x6A27D0", Offset = "0x6A15D0", Length = "0x91")]
	private Vector3 LerpWithoutClamp(Vector3 A, Vector3 B, float t)
	{
		return default(Vector3);
	}

	[Token(Token = "0x6001582")]
	[Address(RVA = "0x6A2870", Offset = "0x6A1670", Length = "0x8")]
	public void SetNumSteps(int visibleSteps, int totalSteps)
	{
	}

	[Token(Token = "0x6001583")]
	[Address(RVA = "0x6A2880", Offset = "0x6A1680", Length = "0x47")]
	public ScrollbarThumbResizer()
	{
	}
}
