using Cpp2ILInjected;
using NodeCanvas.DialogueTrees;
using TMPro;
using UnityEngine;

[Token(Token = "0x20002CA")]
public class DialogueSequenceFP : MonoBehaviour
{
	[Token(Token = "0x40018F5")]
	private const int MAX_TEXT_SIZE = 255;

	[Token(Token = "0x40018F6")]
	[FieldOffset(Offset = "0x20")]
	public Color m_DefaultNormalColor;

	[Token(Token = "0x40018F7")]
	[FieldOffset(Offset = "0x30")]
	public Color m_DefaultHoveredColor;

	[Token(Token = "0x40018F8")]
	[FieldOffset(Offset = "0x40")]
	public UILabel m_UILabel;

	[Token(Token = "0x40018F9")]
	[FieldOffset(Offset = "0x48")]
	public Camera m_TextRenderingCamera;

	[Token(Token = "0x40018FA")]
	[FieldOffset(Offset = "0x50")]
	public Renderer m_Foreground;

	[Token(Token = "0x40018FB")]
	[FieldOffset(Offset = "0x58")]
	public Renderer m_Backround;

	[Token(Token = "0x40018FC")]
	[FieldOffset(Offset = "0x60")]
	private TextMeshPro m_TextMesh;

	[Token(Token = "0x40018FD")]
	[FieldOffset(Offset = "0x68")]
	private UIRoot m_UIRoot;

	[Token(Token = "0x40018FE")]
	[FieldOffset(Offset = "0x70")]
	private int m_ChoiceIndex;

	[Token(Token = "0x40018FF")]
	[FieldOffset(Offset = "0x78")]
	private DialogueModeRigFP m_DialogueModeRigFP;

	[Token(Token = "0x4001900")]
	[FieldOffset(Offset = "0x80")]
	private bool m_IsChoiceEnabled;

	[Token(Token = "0x4001901")]
	[FieldOffset(Offset = "0x81")]
	private bool m_IsChoiceAssigned;

	[Token(Token = "0x4001902")]
	[FieldOffset(Offset = "0x88")]
	private string m_StateName;

	[Token(Token = "0x4001903")]
	[FieldOffset(Offset = "0x90")]
	private float m_Duration;

	[Token(Token = "0x4001904")]
	[FieldOffset(Offset = "0x98")]
	private DialogueModeRigFP.DialogueChoiceCategoryConfiguration m_DialogueChoiceCategoryConfiguration;

	[Token(Token = "0x4001905")]
	[FieldOffset(Offset = "0xA0")]
	private Dialogue_MultipleChoiceNode.ChoiceCategory m_PreferredCategory;

	[Token(Token = "0x4001906")]
	[FieldOffset(Offset = "0xA8")]
	private string m_DisplayName;

	[Token(Token = "0x4001907")]
	[FieldOffset(Offset = "0xB0")]
	private bool m_IsHovered;

	[Token(Token = "0x4001908")]
	[FieldOffset(Offset = "0xB1")]
	private bool m_HasChanged;

	[Token(Token = "0x4001909")]
	[FieldOffset(Offset = "0xB8")]
	private RenderTextureGrabber m_QuadRenderTextureGrabber;

	[Token(Token = "0x400190A")]
	[FieldOffset(Offset = "0xC0")]
	private Renderer m_QuadRenderer;

	[Token(Token = "0x400190B")]
	[FieldOffset(Offset = "0xC8")]
	private Vector3 m_QuadOriginalScale;

	[Token(Token = "0x400190C")]
	[FieldOffset(Offset = "0xD4")]
	private bool m_HasRequestedTextUpdate;

	[Token(Token = "0x400190D")]
	[FieldOffset(Offset = "0xD8")]
	private int m_OriginalFontSize;

	[Token(Token = "0x400190E")]
	[FieldOffset(Offset = "0xDC")]
	private float m_MaxTextSizeFactor;

	[Token(Token = "0x60017C9")]
	[Address(RVA = "0x6E0740", Offset = "0x6DF540", Length = "0x84E")]
	private void Awake()
	{
	}

	[Token(Token = "0x60017CA")]
	[Address(RVA = "0x6E0F90", Offset = "0x6DFD90", Length = "0x5B5")]
	private void UpdateText()
	{
	}

	[Token(Token = "0x60017CB")]
	[Address(RVA = "0x6E1550", Offset = "0x6E0350", Length = "0xDA")]
	private void Update()
	{
	}

	[Token(Token = "0x60017CC")]
	[Address(RVA = "0x6E1630", Offset = "0x6E0430", Length = "0x7")]
	public void SetPreferredCategory(Dialogue_MultipleChoiceNode.ChoiceCategory category)
	{
	}

	[Token(Token = "0x60017CD")]
	[Address(RVA = "0x6E1640", Offset = "0x6E0440", Length = "0x8E")]
	public void SetChoiceCategoryConfiguration(DialogueModeRigFP.DialogueChoiceCategoryConfiguration categoryConfig)
	{
	}

	[Token(Token = "0x60017CE")]
	[Address(RVA = "0x6E16D0", Offset = "0x6E04D0", Length = "0xF2")]
	public bool ProcessInteraction()
	{
		return false;
	}

	[Token(Token = "0x60017CF")]
	[Address(RVA = "0x6E17D0", Offset = "0x6E05D0", Length = "0x52")]
	public void Reset(DialogueModeRigFP dialogueModeRigFP)
	{
	}

	[Token(Token = "0x60017D0")]
	[Address(RVA = "0x636F10", Offset = "0x635D10", Length = "0x8")]
	public string GetHoverText()
	{
		return null;
	}

	[Token(Token = "0x60017D1")]
	[Address(RVA = "0x6E1830", Offset = "0x6E0630", Length = "0x7")]
	public Dialogue_MultipleChoiceNode.ChoiceCategory GetPreferredCategory()
	{
		return default(Dialogue_MultipleChoiceNode.ChoiceCategory);
	}

	[Token(Token = "0x60017D2")]
	[Address(RVA = "0x658130", Offset = "0x656F30", Length = "0x4")]
	public int GetChoiceIndex()
	{
		return 0;
	}

	[Token(Token = "0x60017D3")]
	[Address(RVA = "0x6E1840", Offset = "0x6E0640", Length = "0x176")]
	public void Setup(string text, int choiceIndex, float textSize)
	{
	}

	[Token(Token = "0x60017D4")]
	[Address(RVA = "0x6E19C0", Offset = "0x6E07C0", Length = "0x1B5")]
	public void SetupImages(Texture2D fg, Texture2D bg)
	{
	}

	[Token(Token = "0x60017D5")]
	[Address(RVA = "0x6E1B80", Offset = "0x6E0980", Length = "0x1E5")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x60017D6")]
	[Address(RVA = "0x6E1D70", Offset = "0x6E0B70", Length = "0x22A")]
	private void EnableImage(Renderer renderer, Texture2D image)
	{
	}

	[Token(Token = "0x60017D7")]
	[Address(RVA = "0x6E1FA0", Offset = "0x6E0DA0", Length = "0x100")]
	private void DisableImage(Renderer renderer)
	{
	}

	[Token(Token = "0x60017D8")]
	[Address(RVA = "0x6E20B0", Offset = "0x6E0EB0", Length = "0xB4")]
	private void OnRenderComplete()
	{
	}

	[Token(Token = "0x60017D9")]
	[Address(RVA = "0x6E2170", Offset = "0x6E0F70", Length = "0xF")]
	public void EnableForeground(Texture2D image)
	{
	}

	[Token(Token = "0x60017DA")]
	[Address(RVA = "0x6E2180", Offset = "0x6E0F80", Length = "0xF")]
	public void EnableBackground(Texture2D image)
	{
	}

	[Token(Token = "0x60017DB")]
	[Address(RVA = "0x6E2190", Offset = "0x6E0F90", Length = "0xC")]
	public void DisableBackground()
	{
	}

	[Token(Token = "0x60017DC")]
	[Address(RVA = "0x6E21A0", Offset = "0x6E0FA0", Length = "0xC")]
	public void DisableForeground()
	{
	}

	[Token(Token = "0x60017DD")]
	[Address(RVA = "0x6E21B0", Offset = "0x6E0FB0", Length = "0x1CF")]
	public void SetChoiceEnabled(bool isEnabled)
	{
	}

	[Token(Token = "0x60017DE")]
	[Address(RVA = "0x6E2380", Offset = "0x6E1180", Length = "0x7")]
	public void SetChoiceAssigned(bool isAssigned)
	{
	}

	[Token(Token = "0x60017DF")]
	[Address(RVA = "0x644520", Offset = "0x643320", Length = "0x8")]
	public bool IsChoiceEnabled()
	{
		return false;
	}

	[Token(Token = "0x60017E0")]
	[Address(RVA = "0x6E2390", Offset = "0x6E1190", Length = "0x8")]
	public bool IsChoiceAssigned()
	{
		return false;
	}

	[Token(Token = "0x60017E1")]
	[Address(RVA = "0x6E23A0", Offset = "0x6E11A0", Length = "0x7")]
	public void SetHovered(bool isHovered)
	{
	}

	[Token(Token = "0x60017E2")]
	[Address(RVA = "0x6E23B0", Offset = "0x6E11B0", Length = "0x8")]
	public bool IsHovered()
	{
		return false;
	}

	[Token(Token = "0x60017E3")]
	[Address(RVA = "0x6E23C0", Offset = "0x6E11C0", Length = "0x209")]
	private void SetupNormalUILabelText(string text, float textSize)
	{
	}

	[Token(Token = "0x60017E4")]
	[Address(RVA = "0x6E25D0", Offset = "0x6E13D0", Length = "0x6A")]
	public DialogueSequenceFP()
	{
	}
}
