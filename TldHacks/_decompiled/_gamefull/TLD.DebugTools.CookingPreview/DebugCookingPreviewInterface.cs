using Cpp2ILInjected;
using TLD.Cooking;
using TMPro;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.Events;
using UnityEngine.UI;

namespace TLD.DebugTools.CookingPreview;

[Token(Token = "0x20013E6")]
public class DebugCookingPreviewInterface : MonoBehaviour
{
	[Token(Token = "0x20013E7")]
	public class RecipeButton
	{
		[Token(Token = "0x40091B8")]
		[FieldOffset(Offset = "0x10")]
		private Button m_Button;

		[Token(Token = "0x40091B9")]
		[FieldOffset(Offset = "0x18")]
		private TMP_Text m_Label;

		[Token(Token = "0x40091BA")]
		[FieldOffset(Offset = "0x20")]
		private RawImage m_Icon;

		[Token(Token = "0x6007EE6")]
		[Address(RVA = "0x11E9110", Offset = "0x11E7F10", Length = "0x193")]
		public RecipeButton(Button button)
		{
		}

		[Token(Token = "0x6007EE7")]
		[Address(RVA = "0x11E92B0", Offset = "0x11E80B0", Length = "0xAC")]
		public RecipeButton Clone(Transform parent)
		{
			return null;
		}

		[Token(Token = "0x6007EE8")]
		[Address(RVA = "0x11E9360", Offset = "0x11E8160", Length = "0x4A1")]
		public void UpdateFromRecipe(RecipeData recipe, UnityEvent<RecipeData> onClickCallback)
		{
		}
	}

	[SerializeField]
	[Token(Token = "0x40091A9")]
	[FieldOffset(Offset = "0x20")]
	private AssetLabelReference m_RecipeAssetLabel;

	[SerializeField]
	[Token(Token = "0x40091AA")]
	[FieldOffset(Offset = "0x28")]
	private Button m_RecipeButtonTemplateReference;

	[SerializeField]
	[Token(Token = "0x40091AB")]
	[FieldOffset(Offset = "0x30")]
	private Transform m_RecipeButtonRoot;

	[Header("Scene Camera Control")]
	[SerializeField]
	[Token(Token = "0x40091AC")]
	[FieldOffset(Offset = "0x38")]
	private Transform m_CameraPivot;

	[SerializeField]
	[Token(Token = "0x40091AD")]
	[FieldOffset(Offset = "0x40")]
	private Camera m_Camera;

	[SerializeField]
	[Token(Token = "0x40091AE")]
	[FieldOffset(Offset = "0x48")]
	private Vector2 m_OrbitSpeed;

	[SerializeField]
	[Token(Token = "0x40091AF")]
	[FieldOffset(Offset = "0x50")]
	private float m_ZoomSpeed;

	[Header("Background Color Control")]
	[SerializeField]
	[Token(Token = "0x40091B0")]
	[FieldOffset(Offset = "0x58")]
	private Slider m_BgSliderRed;

	[SerializeField]
	[Token(Token = "0x40091B1")]
	[FieldOffset(Offset = "0x60")]
	private Slider m_BgSliderGreen;

	[SerializeField]
	[Token(Token = "0x40091B2")]
	[FieldOffset(Offset = "0x68")]
	private Slider m_BgSliderBlue;

	[Token(Token = "0x40091B3")]
	[FieldOffset(Offset = "0x70")]
	public UnityEvent<RecipeData> m_RecipeChanged;

	[Token(Token = "0x40091B4")]
	[FieldOffset(Offset = "0x78")]
	public UnityEvent<CookingPotItem.CookingState> m_CookingStateChanged;

	[Token(Token = "0x40091B5")]
	[FieldOffset(Offset = "0x80")]
	private RecipeButton m_RecipeButtonTemplate;

	[Token(Token = "0x40091B6")]
	[FieldOffset(Offset = "0x88")]
	private Vector3 m_LastMousePos;

	[Token(Token = "0x40091B7")]
	private static readonly int s_AmbientLightColorShaderID;

	[Token(Token = "0x6007EE1")]
	[Address(RVA = "0x11E8580", Offset = "0x11E7380", Length = "0x4CD")]
	private void Start()
	{
	}

	[Token(Token = "0x6007EE2")]
	[Address(RVA = "0x11E8A50", Offset = "0x11E7850", Length = "0x5F8")]
	private void OnGUI()
	{
	}

	[Token(Token = "0x6007EE3")]
	[Address(RVA = "0x11E9050", Offset = "0x11E7E50", Length = "0x56")]
	public void ChangeCookingStateByIndex(int cookingStateIndex)
	{
	}

	[Token(Token = "0x6007EE4")]
	[Address(RVA = "0x4AF5E0", Offset = "0x4AE3E0", Length = "0x43")]
	public DebugCookingPreviewInterface()
	{
	}
}
