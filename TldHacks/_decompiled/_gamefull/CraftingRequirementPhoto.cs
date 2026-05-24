using Cpp2ILInjected;
using TLD.Gear;
using UnityEngine;

[Token(Token = "0x2000226")]
public class CraftingRequirementPhoto : MonoBehaviour
{
	[Token(Token = "0x4001335")]
	[FieldOffset(Offset = "0x20")]
	public GameObject m_ControllerButtonRoot;

	[Token(Token = "0x4001336")]
	[FieldOffset(Offset = "0x28")]
	public UITexture m_PhotoTexture;

	[Token(Token = "0x4001337")]
	[FieldOffset(Offset = "0x30")]
	public UITexture m_PhotoFrameTexture;

	[Token(Token = "0x4001338")]
	[FieldOffset(Offset = "0x38")]
	public UITexture m_MissingPhotoTexture;

	[Header("Alignment")]
	[Tooltip("Offset for this element")]
	[Token(Token = "0x4001339")]
	[FieldOffset(Offset = "0x40")]
	public float m_OffsetY;

	[Tooltip("Offset for elements below this one")]
	[Token(Token = "0x400133A")]
	[FieldOffset(Offset = "0x44")]
	public float m_NextOffsetY;

	[Token(Token = "0x400133B")]
	[FieldOffset(Offset = "0x48")]
	private bool m_IsSelected;

	[Token(Token = "0x400133C")]
	[FieldOffset(Offset = "0x4C")]
	private int m_SelectedIndex;

	[Token(Token = "0x400133D")]
	[FieldOffset(Offset = "0x50")]
	private CraftingOperation m_CraftingOperation;

	[Token(Token = "0x600132A")]
	[Address(RVA = "0x666000", Offset = "0x664E00", Length = "0xF6")]
	public void Start()
	{
	}

	[Token(Token = "0x600132B")]
	[Address(RVA = "0x666100", Offset = "0x664F00", Length = "0xB0")]
	public void OnDestroy()
	{
	}

	[Token(Token = "0x600132C")]
	[Address(RVA = "0x6661C0", Offset = "0x664FC0", Length = "0x97")]
	public void Disable()
	{
	}

	[Token(Token = "0x600132D")]
	[Address(RVA = "0x666260", Offset = "0x665060", Length = "0xAA")]
	public void Enable()
	{
	}

	[Token(Token = "0x600132E")]
	[Address(RVA = "0x666310", Offset = "0x665110", Length = "0xDC")]
	public void RegisterCraftingOperationHandlers(CraftingOperation craftingOperation)
	{
	}

	[Token(Token = "0x600132F")]
	[Address(RVA = "0x6663F0", Offset = "0x6651F0", Length = "0x105")]
	public string GetSelectedPhotoID()
	{
		return null;
	}

	[Token(Token = "0x6001330")]
	[Address(RVA = "0x649950", Offset = "0x648750", Length = "0x9F")]
	public bool IsEnabled()
	{
		return false;
	}

	[Token(Token = "0x6001331")]
	[Address(RVA = "0x5C6C80", Offset = "0x5C5A80", Length = "0x5")]
	public bool IsSelected()
	{
		return false;
	}

	[Token(Token = "0x6001332")]
	[Address(RVA = "0x666500", Offset = "0x665300", Length = "0x157")]
	public void OnNextPhoto()
	{
	}

	[Token(Token = "0x6001333")]
	[Address(RVA = "0x666660", Offset = "0x665460", Length = "0x152")]
	public void OnPreviousPhoto()
	{
	}

	[Token(Token = "0x6001334")]
	[Address(RVA = "0x6667C0", Offset = "0x6655C0", Length = "0xAB")]
	public void SetSelected(bool selected)
	{
	}

	[Token(Token = "0x6001335")]
	[Address(RVA = "0x666870", Offset = "0x665670", Length = "0x265")]
	private void RefreshDisplayed()
	{
	}

	[Token(Token = "0x6001336")]
	[Address(RVA = "0x666AE0", Offset = "0x6658E0", Length = "0x309")]
	private void OnCraftingSuccess()
	{
	}

	[Token(Token = "0x6001337")]
	[Address(RVA = "0x4AF5E0", Offset = "0x4AE3E0", Length = "0x43")]
	public CraftingRequirementPhoto()
	{
	}
}
