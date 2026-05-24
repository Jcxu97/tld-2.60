using System.Collections.Generic;
using Cpp2ILInjected;
using TLD.UI.Generics;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.PostProcessing;

[Token(Token = "0x20008DD")]
public class CameraGlobalRT : MonoBehaviour
{
	[Header("Cameras")]
	[Token(Token = "0x4005CBE")]
	[FieldOffset(Offset = "0x20")]
	public Camera m_WorldCamera;

	[Token(Token = "0x4005CBF")]
	[FieldOffset(Offset = "0x28")]
	public Camera m_WeaponCamera;

	[Token(Token = "0x4005CC0")]
	[FieldOffset(Offset = "0x30")]
	public Camera m_InspectCamera;

	[Token(Token = "0x4005CC1")]
	[FieldOffset(Offset = "0x38")]
	public Camera m_ImageEffectCamera;

	[SerializeField]
	[Token(Token = "0x4005CC2")]
	[FieldOffset(Offset = "0x40")]
	private PostProcessLayer m_WorldPostProcessLayer;

	[SerializeField]
	[Token(Token = "0x4005CC3")]
	[FieldOffset(Offset = "0x48")]
	private PostProcessLayer m_WeaponPostProcessLayer;

	[SerializeField]
	[Token(Token = "0x4005CC4")]
	[FieldOffset(Offset = "0x50")]
	private PostProcessLayer m_ImageEffectsPostProcessLayer;

	[Header("FOV Padding for SSAO")]
	[Range(0f, 64f)]
	[SerializeField]
	[Token(Token = "0x4005CC5")]
	[FieldOffset(Offset = "0x58")]
	private int m_RenderTextureSizePadding;

	[Range(1f, 3f)]
	[SerializeField]
	[Token(Token = "0x4005CC6")]
	[FieldOffset(Offset = "0x5C")]
	private float m_SsaoFieldOfViewScalar;

	[HideInInspector]
	[Token(Token = "0x4005CC7")]
	[FieldOffset(Offset = "0x60")]
	public Camera m_OverrideCamera;

	[HideInInspector]
	[Token(Token = "0x4005CC8")]
	[FieldOffset(Offset = "0x68")]
	public bool m_OverrideCameraParamsOnly;

	[Header("Panel References")]
	[SerializeField]
	[Token(Token = "0x4005CC9")]
	[FieldOffset(Offset = "0x70")]
	private PanelReference<Panel_BodyHarvest> m_BodyHarvest;

	[SerializeField]
	[Token(Token = "0x4005CCA")]
	[FieldOffset(Offset = "0x78")]
	private PanelReference<Panel_FeedFire> m_FeedFire;

	[SerializeField]
	[Token(Token = "0x4005CCB")]
	[FieldOffset(Offset = "0x80")]
	private PanelReference<Panel_HUD> m_HUD;

	[SerializeField]
	[Token(Token = "0x4005CCC")]
	[FieldOffset(Offset = "0x88")]
	private PanelReference<Panel_Inventory_Examine> m_InventoryExamine;

	[SerializeField]
	[Token(Token = "0x4005CCD")]
	[FieldOffset(Offset = "0x90")]
	private PanelReference<Panel_Loading> m_Loading;

	[SerializeField]
	[Token(Token = "0x4005CCE")]
	[FieldOffset(Offset = "0x98")]
	private PanelReference<Panel_Log> m_LogPanel;

	[Token(Token = "0x4005CCF")]
	public const string COMMAND_LINE_ARG_DISABLE_POSTPROCESS = "-disable-postprocess";

	[Token(Token = "0x4005CD0")]
	[FieldOffset(Offset = "0xA0")]
	private bool m_PostProcessDisabled;

	[Token(Token = "0x4005CD1")]
	[FieldOffset(Offset = "0xA8")]
	private Camera m_Camera;

	[Token(Token = "0x4005CD2")]
	[FieldOffset(Offset = "0xB0")]
	private RenderTexture m_MainRenderTexture;

	[Token(Token = "0x4005CD3")]
	[FieldOffset(Offset = "0xB8")]
	private RenderTexture m_InspectRenderTexture;

	[Token(Token = "0x4005CD4")]
	[FieldOffset(Offset = "0xC0")]
	private RenderTexture m_WorldMotionVectorRenderTexture;

	[Token(Token = "0x4005CD5")]
	[FieldOffset(Offset = "0xC8")]
	private RenderTexture m_WeaponMotionVectorsRenderTexture;

	[Token(Token = "0x4005CD6")]
	[FieldOffset(Offset = "0xD0")]
	private RenderTexture m_MergedDepthRenderTexture;

	[Token(Token = "0x4005CD7")]
	[FieldOffset(Offset = "0xD8")]
	private RenderTexture m_CurrentMergedDepthRenderTexture;

	[Token(Token = "0x4005CD8")]
	[FieldOffset(Offset = "0xE0")]
	private RenderTexture m_CachedRenderTexture;

	[Token(Token = "0x4005CD9")]
	[FieldOffset(Offset = "0xE8")]
	private GlobalKeyword m_ShaderKeyword_GlobalCamera;

	[Token(Token = "0x4005CDA")]
	private static readonly int s_WorldMotionVectorsTexID;

	[Token(Token = "0x4005CDB")]
	private static readonly int s_WeaponMotionVectorsTexID;

	[Token(Token = "0x4005CDC")]
	private static readonly int s_DepthTexID;

	[Token(Token = "0x4005CDD")]
	private static readonly int s_WorldDepthTexID;

	[Token(Token = "0x4005CDE")]
	private static readonly int s_WeaponDepthTexID;

	[Token(Token = "0x4005CDF")]
	private static readonly int s_MergedMotionVectorsTextureID;

	[Token(Token = "0x4005CE0")]
	private static readonly int s_MergedDepthTextureID;

	[Token(Token = "0x4005CE1")]
	private static readonly int s_TLD_CurrentVPID;

	[Token(Token = "0x4005CE2")]
	private static readonly int s_TLD_CurrentVPInverseID;

	[Token(Token = "0x4005CE3")]
	private static readonly int s_TLD_PreviousVPID;

	[Token(Token = "0x4005CE4")]
	[FieldOffset(Offset = "0xF8")]
	private PropertySheet m_MergeWorldDepthPropertySheet;

	[Token(Token = "0x4005CE5")]
	[FieldOffset(Offset = "0x100")]
	private PropertySheet m_MotionVectorsPropertySheet;

	[Token(Token = "0x4005CE6")]
	[FieldOffset(Offset = "0x108")]
	private Material m_MotionVectorsMaterial;

	[Token(Token = "0x4005CE7")]
	[FieldOffset(Offset = "0x110")]
	private CommandBuffer m_MergeWorldDepthCommandBuffer;

	[Token(Token = "0x4005CE8")]
	[FieldOffset(Offset = "0x118")]
	private CommandBuffer m_SetShaderParameters_WorldCamera;

	[Token(Token = "0x4005CE9")]
	[FieldOffset(Offset = "0x120")]
	private CommandBuffer m_SetShaderParameters_WeaponCamera;

	[Token(Token = "0x4005CEA")]
	[FieldOffset(Offset = "0x128")]
	private CommandBuffer m_MotionVectors_WorldCamera;

	[Token(Token = "0x4005CEB")]
	[FieldOffset(Offset = "0x130")]
	private CommandBuffer m_MotionVectors_WeaponCamera;

	[Token(Token = "0x4005CEC")]
	[FieldOffset(Offset = "0x138")]
	private List<MeshRenderer> m_MeshRenderers_WeaponCamera;

	[Token(Token = "0x4005CED")]
	[FieldOffset(Offset = "0x140")]
	private List<SkinnedMeshRenderer> m_SkinnedMeshRenderers_WeaponCamera;

	[Token(Token = "0x4005CEE")]
	[FieldOffset(Offset = "0x148")]
	private Matrix4x4 m_PreviousViewProjection_World;

	[Token(Token = "0x4005CEF")]
	[FieldOffset(Offset = "0x188")]
	private Matrix4x4 m_PreviousViewProjection_Weapon;

	[Token(Token = "0x4005CF0")]
	[FieldOffset(Offset = "0x1C8")]
	private Matrix4x4 m_PreviousViewProjection_Image;

	[Token(Token = "0x4005CF1")]
	[FieldOffset(Offset = "0x208")]
	private int m_LastWidth;

	[Token(Token = "0x4005CF2")]
	[FieldOffset(Offset = "0x20C")]
	private int m_LastHeight;

	[Token(Token = "0x4005CF3")]
	[FieldOffset(Offset = "0x210")]
	private CameraClearFlags m_OriginalClearFlags;

	[Token(Token = "0x4005CF4")]
	[FieldOffset(Offset = "0x214")]
	private bool m_Rendered;

	[Token(Token = "0x4005CF5")]
	[FieldOffset(Offset = "0x218")]
	private Material m_MainBlitMaterial;

	[Token(Token = "0x4005CF6")]
	[FieldOffset(Offset = "0x220")]
	private UITexture m_UITextureForInspect;

	[Token(Token = "0x4005CF7")]
	[FieldOffset(Offset = "0x228")]
	private bool m_IsRendering;

	[Token(Token = "0x4005CF8")]
	[FieldOffset(Offset = "0x229")]
	private bool m_HighResRender;

	[Token(Token = "0x4005CF9")]
	[FieldOffset(Offset = "0x22C")]
	public int m_HighResCanvasX;

	[Token(Token = "0x4005CFA")]
	[FieldOffset(Offset = "0x230")]
	public int m_HighResCanvasY;

	[Token(Token = "0x4005CFB")]
	[FieldOffset(Offset = "0x234")]
	private CameraClearFlags m_LastWeaponCameraClearFlags;

	[Token(Token = "0x4005CFC")]
	[FieldOffset(Offset = "0x238")]
	private Color m_LastWeaponCameraBackgroundColor;

	[Token(Token = "0x4005CFD")]
	[FieldOffset(Offset = "0x248")]
	private bool m_IsChromaKeyModeActive;

	[Token(Token = "0x4005CFE")]
	private static readonly Color s_DefaultChromaKeyColor;

	[Token(Token = "0x1700036C")]
	[field: Token(Token = "0x4005CFF")]
	[field: FieldOffset(Offset = "0x249")]
	public bool TakePhotoNextFrame
	{
		[Token(Token = "0x6005174")]
		[Address(RVA = "0xCC0950", Offset = "0xCBF750", Length = "0x8")]
		get;
		[Token(Token = "0x6005175")]
		[Address(RVA = "0xE28500", Offset = "0xE27300", Length = "0x7")]
		private set;
	}

	[Token(Token = "0x6005176")]
	[Address(RVA = "0xE28510", Offset = "0xE27310", Length = "0x113")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6005177")]
	[Address(RVA = "0xE28630", Offset = "0xE27430", Length = "0x35D")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6005178")]
	[Address(RVA = "0xE28990", Offset = "0xE27790", Length = "0x7E4")]
	private void Start()
	{
	}

	[Token(Token = "0x6005179")]
	[Address(RVA = "0xE29180", Offset = "0xE27F80", Length = "0x2E1D")]
	private void OnPreCull()
	{
	}

	[Token(Token = "0x600517A")]
	[Address(RVA = "0xE2BFA0", Offset = "0xE2ADA0", Length = "0x2F0")]
	private void RenderScene(RenderTexture targetRenderTexture, int width, int height, bool motionVectorsEnabled, bool renderWeaponCamera)
	{
	}

	[Token(Token = "0x600517B")]
	[Address(RVA = "0xE2C290", Offset = "0xE2B090", Length = "0x161")]
	private void InspectCameraToUITexture(UITexture texture, int paddedWidth, int paddedHeight, int width, int height)
	{
	}

	[Token(Token = "0x600517C")]
	[Address(RVA = "0xE2C400", Offset = "0xE2B200", Length = "0x2E3")]
	private void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
	}

	[Token(Token = "0x600517D")]
	[Address(RVA = "0xE2C6F0", Offset = "0xE2B4F0", Length = "0x380")]
	private void MaybeReassignRenderTexture(ref RenderTexture texture, int width, int height, RenderTextureFormat format)
	{
	}

	[Token(Token = "0x600517E")]
	[Address(RVA = "0xE2CA80", Offset = "0xE2B880", Length = "0x205")]
	private RenderTexture GetRenderTexture(int width, int height, RenderTextureFormat format)
	{
		return null;
	}

	[Token(Token = "0x600517F")]
	[Address(RVA = "0xE2CC90", Offset = "0xE2BA90", Length = "0x3D")]
	private RenderTexture GetTemporaryRenderTexture(int width, int height, RenderTextureFormat format)
	{
		return null;
	}

	[Token(Token = "0x6005180")]
	[Address(RVA = "0xE2CCD0", Offset = "0xE2BAD0", Length = "0xAB6")]
	private void RenderCamera(Camera camera, RenderTexture target, int width, int height, bool motionVectorsEnabled, CommandBuffer setGlobalParams, ref Matrix4x4 previousViewProjectionMatrix)
	{
	}

	[Token(Token = "0x6005181")]
	[Address(RVA = "0xE2D790", Offset = "0xE2C590", Length = "0x211")]
	private void MaybeRenderInspectCamera(UITexture texture, int paddedWidth, int paddedHeight, int width, int height)
	{
	}

	[Token(Token = "0x6005182")]
	[Address(RVA = "0xE2D9B0", Offset = "0xE2C7B0", Length = "0x3C0")]
	private UITexture GetInspectCameraUITexture()
	{
		return null;
	}

	[Token(Token = "0x6005183")]
	[Address(RVA = "0xE2DD80", Offset = "0xE2CB80", Length = "0x4E7")]
	private void ScaledBlit(RenderTexture source, RenderTexture destination)
	{
	}

	[Token(Token = "0x6005184")]
	[Address(RVA = "0xE2E270", Offset = "0xE2D070", Length = "0x121")]
	private void ReleaseRenderTarget(ref RenderTexture target)
	{
	}

	[Token(Token = "0x6005185")]
	[Address(RVA = "0xE2E3A0", Offset = "0xE2D1A0", Length = "0x254")]
	private void ReleaseInspectRenderTargets()
	{
	}

	[Token(Token = "0x6005186")]
	[Address(RVA = "0xE2E600", Offset = "0xE2D400", Length = "0x448")]
	private void MatchWorldCamera()
	{
	}

	[Token(Token = "0x6005187")]
	[Address(RVA = "0xE2EA50", Offset = "0xE2D850", Length = "0x8")]
	public void StopRendering()
	{
	}

	[Token(Token = "0x6005188")]
	[Address(RVA = "0xE2EA60", Offset = "0xE2D860", Length = "0x8")]
	public void StartRendering()
	{
	}

	[Token(Token = "0x6005189")]
	[Address(RVA = "0x502310", Offset = "0x501110", Length = "0x8")]
	public RenderTexture GetRenderTexture()
	{
		return null;
	}

	[Token(Token = "0x600518A")]
	[Address(RVA = "0xE2EA70", Offset = "0xE2D870", Length = "0x7")]
	public void HighResRender(bool isHighRes)
	{
	}

	[Token(Token = "0x600518B")]
	[Address(RVA = "0xE1E900", Offset = "0xE1D700", Length = "0x4")]
	public int GetRenderTextureSizePadding()
	{
		return 0;
	}

	[Token(Token = "0x600518C")]
	[Address(RVA = "0xE2EA80", Offset = "0xE2D880", Length = "0x1B8")]
	private static void OnResourceAvailabilityChanged(bool amConstrained)
	{
	}

	[Token(Token = "0x600518D")]
	[Address(RVA = "0xE2EC40", Offset = "0xE2DA40", Length = "0x27")]
	private bool IsMotionVectorsPassEnabled(QualityLevelSettings quality)
	{
		return false;
	}

	[Token(Token = "0x600518E")]
	[Address(RVA = "0xE2EC70", Offset = "0xE2DA70", Length = "0x2D")]
	private bool IsMergedWorldDepthEnabled(QualityLevelSettings quality)
	{
		return false;
	}

	[Token(Token = "0x600518F")]
	[Address(RVA = "0xE2ECA0", Offset = "0xE2DAA0", Length = "0xC9")]
	public bool IsMergedWorldDepthEnabled()
	{
		return false;
	}

	[Token(Token = "0x6005190")]
	[Address(RVA = "0xE2ED70", Offset = "0xE2DB70", Length = "0xB9")]
	public void BindMergedDepthToPropertyBlock(MaterialPropertyBlock propertyBlock)
	{
	}

	[Token(Token = "0x6005191")]
	[Address(RVA = "0xE2EE30", Offset = "0xE2DC30", Length = "0x8")]
	public bool IsChromaKeyModeActive()
	{
		return false;
	}

	[Token(Token = "0x6005192")]
	[Address(RVA = "0xE2EE40", Offset = "0xE2DC40", Length = "0x3A7")]
	public void EnableChromaKeyMode(bool isEnabled, Color? color = null)
	{
	}

	[Token(Token = "0x6005193")]
	[Address(RVA = "0xE2F1F0", Offset = "0xE2DFF0", Length = "0xD3")]
	private void OnTakePhoto(GameObject projectile)
	{
	}

	[Token(Token = "0x6005194")]
	[Address(RVA = "0xE2F2D0", Offset = "0xE2E0D0", Length = "0x3B4")]
	public CameraGlobalRT()
	{
	}
}
