using System.Collections.Generic;
using Cpp2ILInjected;
using TLD.Scenes;
using UnityEngine;
using UnityEngine.ResourceManagement.AsyncOperations;

[Token(Token = "0x20006E7")]
public class SelectRegionItem : MonoBehaviour
{
	[AutoComponent(ComponentRequirement.Required)]
	[SerializeField]
	[Token(Token = "0x400499B")]
	[FieldOffset(Offset = "0x20")]
	private Animator m_Animator;

	[Token(Token = "0x400499C")]
	[FieldOffset(Offset = "0x28")]
	public GameObject m_Highlight;

	[SerializeField]
	[Token(Token = "0x400499D")]
	[FieldOffset(Offset = "0x30")]
	private Transform m_MapTransform;

	[SerializeField]
	[Token(Token = "0x400499E")]
	[FieldOffset(Offset = "0x38")]
	private AnimationCurve m_MapTransitionCurve;

	[SerializeField]
	[Token(Token = "0x400499F")]
	[FieldOffset(Offset = "0x40")]
	private AnimationStateRef m_ShowAnimation;

	[SerializeField]
	[Token(Token = "0x40049A0")]
	[FieldOffset(Offset = "0x48")]
	private AnimationStateRef m_HideAnimation;

	[SerializeField]
	[Token(Token = "0x40049A1")]
	[FieldOffset(Offset = "0x50")]
	private AnimationStateRef m_SelectAnimation;

	[SerializeField]
	[Token(Token = "0x40049A2")]
	[FieldOffset(Offset = "0x58")]
	private AnimationStateRef m_DeselectAnimation;

	[Token(Token = "0x40049A3")]
	[FieldOffset(Offset = "0x60")]
	public SelectRegionItem m_OnLeftItem;

	[Token(Token = "0x40049A4")]
	[FieldOffset(Offset = "0x68")]
	public SelectRegionItem m_OnRightItem;

	[Token(Token = "0x40049A5")]
	[FieldOffset(Offset = "0x70")]
	public SelectRegionItem m_OnUpItem;

	[Token(Token = "0x40049A6")]
	[FieldOffset(Offset = "0x78")]
	public SelectRegionItem m_OnDownItem;

	[SerializeField]
	[Token(Token = "0x40049A7")]
	[FieldOffset(Offset = "0x80")]
	private RegionSpecification m_RegionSpec;

	[SerializeField]
	[Token(Token = "0x40049A8")]
	[FieldOffset(Offset = "0x88")]
	private UIButton m_Button;

	[SerializeField]
	[Token(Token = "0x40049A9")]
	[FieldOffset(Offset = "0x90")]
	private RegionSpecification m_OnLeftRegion;

	[SerializeField]
	[Token(Token = "0x40049AA")]
	[FieldOffset(Offset = "0x98")]
	private RegionSpecification m_OnRightRegion;

	[SerializeField]
	[Token(Token = "0x40049AB")]
	[FieldOffset(Offset = "0xA0")]
	private RegionSpecification m_OnUpRegion;

	[SerializeField]
	[Token(Token = "0x40049AC")]
	[FieldOffset(Offset = "0xA8")]
	private RegionSpecification m_OnDownRegion;

	[Token(Token = "0x40049AD")]
	[FieldOffset(Offset = "0xB0")]
	private AsyncOperationHandle<Texture2D> m_miniMapOperation;

	[Token(Token = "0x40049AE")]
	[FieldOffset(Offset = "0xC8")]
	private Vector3 m_MapStartPosition;

	[Token(Token = "0x40049AF")]
	[FieldOffset(Offset = "0xD4")]
	private Vector3 m_MapEndPosition;

	[Token(Token = "0x40049B0")]
	[FieldOffset(Offset = "0xE0")]
	private float m_MapTransitionTime;

	[Token(Token = "0x17000311")]
	public RegionSpecification Region
	{
		[Token(Token = "0x6003CBB")]
		[Address(RVA = "0x502330", Offset = "0x501130", Length = "0x8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6003CBC")]
	[Address(RVA = "0xB836A0", Offset = "0xB824A0", Length = "0xE0")]
	public Texture2D GetMiniMap()
	{
		return null;
	}

	[Token(Token = "0x6003CBD")]
	[Address(RVA = "0xB83780", Offset = "0xB82580", Length = "0x50A")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6003CBE")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	private void OnValidate()
	{
	}

	[Token(Token = "0x6003CBF")]
	[Address(RVA = "0xB83C90", Offset = "0xB82A90", Length = "0x3F")]
	private void OnMiniMapLoaded(AsyncOperationHandle<Texture2D> obj)
	{
	}

	[Token(Token = "0x6003CC0")]
	[Address(RVA = "0xB83CD0", Offset = "0xB82AD0", Length = "0xFC")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6003CC1")]
	[Address(RVA = "0xB83DD0", Offset = "0xB82BD0", Length = "0x2FD")]
	private void Update()
	{
	}

	[Token(Token = "0x6003CC2")]
	[Address(RVA = "0xB840D0", Offset = "0xB82ED0", Length = "0x22")]
	public void Show()
	{
	}

	[Token(Token = "0x6003CC3")]
	[Address(RVA = "0xB84100", Offset = "0xB82F00", Length = "0x22")]
	public void Hide()
	{
	}

	[Token(Token = "0x6003CC4")]
	[Address(RVA = "0xB84130", Offset = "0xB82F30", Length = "0x51")]
	public void Select(bool isSelected)
	{
	}

	[Token(Token = "0x6003CC5")]
	[Address(RVA = "0xB84190", Offset = "0xB82F90", Length = "0x11C")]
	public bool IsAnyAnimationInProgress()
	{
		return false;
	}

	[Token(Token = "0x6003CC6")]
	[Address(RVA = "0xB842B0", Offset = "0xB830B0", Length = "0x8D")]
	public void PatchUpReferences(List<SelectRegionItem> items)
	{
	}

	[Token(Token = "0x6003CC7")]
	[Address(RVA = "0xB84340", Offset = "0xB83140", Length = "0x145")]
	public void AttachEventHandler(EventDelegate.Callback callback)
	{
	}

	[Token(Token = "0x6003CC8")]
	[Address(RVA = "0xB84490", Offset = "0xB83290", Length = "0x12F")]
	private void PlayAnimation(string stateName)
	{
	}

	[Token(Token = "0x6003CC9")]
	[Address(RVA = "0xB845C0", Offset = "0xB833C0", Length = "0x281")]
	private void PatchUpReference(List<SelectRegionItem> items, RegionSpecification target, out SelectRegionItem memberReference)
	{
		memberReference = null;
	}

	[Token(Token = "0x6003CCA")]
	[Address(RVA = "0xB84850", Offset = "0xB83650", Length = "0x1FF")]
	public SelectRegionItem()
	{
	}
}
