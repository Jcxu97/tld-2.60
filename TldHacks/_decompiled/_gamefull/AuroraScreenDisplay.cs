using Cpp2ILInjected;
using TLD.ModularElectrolizer;
using TLD.UI.Generics;
using UnityEngine;

[Token(Token = "0x20001C4")]
public class AuroraScreenDisplay : MonoBehaviour
{
	[Token(Token = "0x20001C5")]
	public enum State
	{
		[Token(Token = "0x4000F84")]
		Uninitialized,
		[Token(Token = "0x4000F85")]
		Off,
		[Token(Token = "0x4000F86")]
		Low,
		[Token(Token = "0x4000F87")]
		Stable
	}

	[SerializeField]
	[Token(Token = "0x4000F65")]
	[FieldOffset(Offset = "0x20")]
	private PanelReference<Panel_Loading> m_Loading;

	[Tooltip("This is a digital display. Alters how the unstable image is displayed.")]
	[SerializeField]
	[Token(Token = "0x4000F66")]
	[FieldOffset(Offset = "0x28")]
	private bool m_IsDigital;

	[SerializeField]
	[Token(Token = "0x4000F67")]
	[FieldOffset(Offset = "0x30")]
	private CustomCameraPosition m_InspectComponent;

	[Header("User Interface")]
	[SerializeField]
	[Token(Token = "0x4000F68")]
	[FieldOffset(Offset = "0x38")]
	private AuroraScreenPrefabPool m_DisplayInterfacePrefabPool;

	[SerializeField]
	[Token(Token = "0x4000F69")]
	[FieldOffset(Offset = "0x40")]
	private int m_RenderTextureWidth;

	[SerializeField]
	[Token(Token = "0x4000F6A")]
	[FieldOffset(Offset = "0x44")]
	private int m_RenderTextureHeight;

	[Header("Timing")]
	[SerializeField]
	[Token(Token = "0x4000F6B")]
	[FieldOffset(Offset = "0x48")]
	private float m_InspectionResolveSpeed;

	[SerializeField]
	[Token(Token = "0x4000F6C")]
	[FieldOffset(Offset = "0x50")]
	private MinMax m_DistortionToggleRate;

	[SerializeField]
	[Token(Token = "0x4000F6D")]
	[FieldOffset(Offset = "0x58")]
	private MinMax m_VSyncRate;

	[HideInInspector]
	[Token(Token = "0x4000F6E")]
	[FieldOffset(Offset = "0x60")]
	public ObjectGuid m_Guid;

	[Token(Token = "0x4000F6F")]
	[FieldOffset(Offset = "0x68")]
	private GameObject m_DisplayInterface;

	[Token(Token = "0x4000F70")]
	[FieldOffset(Offset = "0x70")]
	private Camera m_RenderTextureCamera;

	[Token(Token = "0x4000F71")]
	[FieldOffset(Offset = "0x78")]
	private RenderTexture m_InterfaceRenderTexture;

	[Token(Token = "0x4000F72")]
	[FieldOffset(Offset = "0x80")]
	private InteractiveScrollText m_InteractiveScrollText;

	[Token(Token = "0x4000F73")]
	[FieldOffset(Offset = "0x88")]
	private AuroraScreenAudio m_DisplayAudio;

	[Token(Token = "0x4000F74")]
	[FieldOffset(Offset = "0x90")]
	private State m_State;

	[Token(Token = "0x4000F75")]
	[FieldOffset(Offset = "0x98")]
	private AuroraModularElectrolizer m_LocalElectrolizer;

	[Token(Token = "0x4000F76")]
	[FieldOffset(Offset = "0xA0")]
	private float m_DistortionTime;

	[Token(Token = "0x4000F77")]
	[FieldOffset(Offset = "0xA4")]
	private float m_DistortionTimer;

	[Token(Token = "0x4000F78")]
	[FieldOffset(Offset = "0xA8")]
	private float m_VSyncTime;

	[Token(Token = "0x4000F79")]
	[FieldOffset(Offset = "0xAC")]
	private float m_VSyncTimer;

	[Token(Token = "0x4000F7A")]
	[FieldOffset(Offset = "0xB0")]
	private float m_VSyncPrev;

	[Token(Token = "0x4000F7B")]
	[FieldOffset(Offset = "0xB4")]
	private float m_VSyncNext;

	[Token(Token = "0x4000F7C")]
	[FieldOffset(Offset = "0xB8")]
	private float m_DefaultDistortion;

	[Token(Token = "0x4000F7D")]
	[FieldOffset(Offset = "0xBC")]
	private float m_InspectDistortion;

	[Token(Token = "0x4000F7E")]
	[FieldOffset(Offset = "0xC0")]
	private float m_InspectDistortionTarget;

	[Token(Token = "0x4000F7F")]
	[FieldOffset(Offset = "0xC8")]
	private Renderer m_LocalDisplay;

	[Token(Token = "0x4000F80")]
	[FieldOffset(Offset = "0xD0")]
	private Color m_OriginalColor;

	[Token(Token = "0x4000F81")]
	[FieldOffset(Offset = "0xE0")]
	private Color m_NewColor;

	[Token(Token = "0x4000F82")]
	[FieldOffset(Offset = "0xF0")]
	private string m_LanguageUsedForLocalize;

	[Token(Token = "0x6001044")]
	[Address(RVA = "0x6230F0", Offset = "0x621EF0", Length = "0x7A9")]
	private void Start()
	{
	}

	[Token(Token = "0x6001045")]
	[Address(RVA = "0x6238A0", Offset = "0x6226A0", Length = "0x2D5")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6001046")]
	[Address(RVA = "0x623B80", Offset = "0x622980", Length = "0x51C")]
	private void Update()
	{
	}

	[Token(Token = "0x6001047")]
	[Address(RVA = "0x6240A0", Offset = "0x622EA0", Length = "0x5A0")]
	private void InitializeDisplayInterface()
	{
	}

	[Token(Token = "0x6001048")]
	[Address(RVA = "0x624650", Offset = "0x623450", Length = "0x24E")]
	private void UpdateDigitalEffect()
	{
	}

	[Token(Token = "0x6001049")]
	[Address(RVA = "0x6248A0", Offset = "0x6236A0", Length = "0x246")]
	private void UpdateAnalogEffect()
	{
	}

	[Token(Token = "0x600104A")]
	[Address(RVA = "0x624AF0", Offset = "0x6238F0", Length = "0x190")]
	private void UpdateInteractiveScrolling()
	{
	}

	[Token(Token = "0x600104B")]
	[Address(RVA = "0x624C90", Offset = "0x623A90", Length = "0x2C1")]
	private void SetDisplayActive(bool enable)
	{
	}

	[Token(Token = "0x600104C")]
	[Address(RVA = "0x624F60", Offset = "0x623D60", Length = "0x326")]
	private void SetState(State state)
	{
	}

	[Token(Token = "0x600104D")]
	[Address(RVA = "0x625290", Offset = "0x624090", Length = "0xEB")]
	public string GetPrefabName()
	{
		return null;
	}

	[Token(Token = "0x600104E")]
	[Address(RVA = "0x625380", Offset = "0x624180", Length = "0x300")]
	private void OnCameraPositionStateChange(CustomCameraPosition.State newCameraState)
	{
	}

	[Token(Token = "0x600104F")]
	[Address(RVA = "0x625690", Offset = "0x624490", Length = "0x70")]
	private void OnTextScrolled()
	{
	}

	[Token(Token = "0x6001050")]
	[Address(RVA = "0x625710", Offset = "0x624510", Length = "0x2A7")]
	private void RefreshLocalization()
	{
	}

	[Token(Token = "0x6001051")]
	[Address(RVA = "0x6259C0", Offset = "0x6247C0", Length = "0x180")]
	public AuroraScreenDisplay()
	{
	}
}
