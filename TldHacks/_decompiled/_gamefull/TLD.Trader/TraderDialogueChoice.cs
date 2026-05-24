using Cpp2ILInjected;
using UnityEngine;

namespace TLD.Trader;

[Token(Token = "0x20013B6")]
public class TraderDialogueChoice : MonoBehaviour
{
	[Header("Text")]
	[SerializeField]
	[Token(Token = "0x400904B")]
	[FieldOffset(Offset = "0x20")]
	private UILabel m_UILabel;

	[SerializeField]
	[Token(Token = "0x400904C")]
	[FieldOffset(Offset = "0x28")]
	private Color m_DefaultNormalColor;

	[SerializeField]
	[Token(Token = "0x400904D")]
	[FieldOffset(Offset = "0x38")]
	private Color m_DefaultHoveredColor;

	[SerializeField]
	[Token(Token = "0x400904E")]
	[FieldOffset(Offset = "0x48")]
	private Color m_SpecialNormalColor;

	[SerializeField]
	[Token(Token = "0x400904F")]
	[FieldOffset(Offset = "0x58")]
	private Color m_SpecialHoveredColor;

	[Header("Rendering")]
	[SerializeField]
	[Token(Token = "0x4009050")]
	[FieldOffset(Offset = "0x68")]
	private GameObject m_DisplayInterface;

	[SerializeField]
	[Token(Token = "0x4009051")]
	[FieldOffset(Offset = "0x70")]
	private Renderer m_QuadRenderer;

	[SerializeField]
	[Token(Token = "0x4009052")]
	[FieldOffset(Offset = "0x78")]
	private RenderTextureGrabber m_QuadRenderTextureGrabber;

	[Header("Movement")]
	[SerializeField]
	[Token(Token = "0x4009053")]
	[FieldOffset(Offset = "0x80")]
	private Vector3 m_Magnitude;

	[SerializeField]
	[Token(Token = "0x4009054")]
	[FieldOffset(Offset = "0x8C")]
	private int m_PointsToGenerate;

	[SerializeField]
	[Token(Token = "0x4009055")]
	[FieldOffset(Offset = "0x90")]
	private float m_SwayTimePerPoint;

	[Token(Token = "0x4009056")]
	private static readonly int s_TintColorPropertyID;

	[Token(Token = "0x4009058")]
	[FieldOffset(Offset = "0x95")]
	private bool m_IsSpecialRequest;

	[Token(Token = "0x4009059")]
	[FieldOffset(Offset = "0x96")]
	private bool m_IsDirty;

	[Token(Token = "0x400905A")]
	[FieldOffset(Offset = "0x98")]
	private CatmullRomSpline m_Spline;

	[Token(Token = "0x400905B")]
	[FieldOffset(Offset = "0xA0")]
	private Vector3 m_InitialPosition;

	[Token(Token = "0x400905C")]
	[FieldOffset(Offset = "0xAC")]
	private float m_SwayTimer;

	[Token(Token = "0x400905D")]
	[FieldOffset(Offset = "0xB0")]
	private float m_TotalSwayTime;

	[Token(Token = "0x17000AB7")]
	[field: Token(Token = "0x4009057")]
	[field: FieldOffset(Offset = "0x94")]
	public bool IsHovered
	{
		[Token(Token = "0x6007DE6")]
		[Address(RVA = "0xB69660", Offset = "0xB68460", Length = "0x8")]
		get;
		[Token(Token = "0x6007DE7")]
		[Address(RVA = "0x11D1690", Offset = "0x11D0490", Length = "0x7")]
		private set;
	}

	[Token(Token = "0x6007DE8")]
	[Address(RVA = "0x11D16A0", Offset = "0x11D04A0", Length = "0x2C7")]
	private void Awake()
	{
	}

	[ContextMenu("Initialize Spline")]
	[Token(Token = "0x6007DE9")]
	[Address(RVA = "0x11D1970", Offset = "0x11D0770", Length = "0x406")]
	private void InitializeSpline()
	{
	}

	[Token(Token = "0x6007DEA")]
	[Address(RVA = "0x11D1D80", Offset = "0x11D0B80", Length = "0x130")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6007DEB")]
	[Address(RVA = "0x11D1EC0", Offset = "0x11D0CC0", Length = "0xC5")]
	public void SetText(string text, bool isSpecialRequest)
	{
	}

	[Token(Token = "0x6007DEC")]
	[Address(RVA = "0x11D1F90", Offset = "0x11D0D90", Length = "0x192")]
	public void SetHovered(bool hovered)
	{
	}

	[Token(Token = "0x6007DED")]
	[Address(RVA = "0x11D2130", Offset = "0x11D0F30", Length = "0x20")]
	private void OnRenderComplete()
	{
	}

	[Token(Token = "0x6007DEE")]
	[Address(RVA = "0x11D2160", Offset = "0x11D0F60", Length = "0x1DA")]
	private void Update()
	{
	}

	[Token(Token = "0x6007DEF")]
	[Address(RVA = "0x11D2340", Offset = "0x11D1140", Length = "0x75")]
	public TraderDialogueChoice()
	{
	}
}
