using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine.Scripting;

namespace UnityEngine.Rendering.PostProcessing;

[ExecuteAlways]
[DisallowMultipleComponent]
[ImageEffectAllowedInSceneView]
[AddComponentMenu("Rendering/Post-process Layer", 1000)]
[RequireComponent(typeof(Camera))]
[Token(Token = "0x2000CDB")]
public sealed class PostProcessLayer : MonoBehaviour
{
	[Token(Token = "0x2000CDC")]
	public enum Antialiasing
	{
		[Token(Token = "0x4007FB1")]
		None,
		[Token(Token = "0x4007FB2")]
		FastApproximateAntialiasing,
		[Token(Token = "0x4007FB3")]
		SubpixelMorphologicalAntialiasing,
		[Token(Token = "0x4007FB4")]
		TemporalAntialiasing
	}

	[Serializable]
	[Token(Token = "0x2000CDD")]
	public sealed class SerializedBundleRef
	{
		[Token(Token = "0x4007FB5")]
		[FieldOffset(Offset = "0x10")]
		public string assemblyQualifiedName;

		[Token(Token = "0x4007FB6")]
		[FieldOffset(Offset = "0x18")]
		public PostProcessBundle bundle;

		[Token(Token = "0x60065E0")]
		[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
		public SerializedBundleRef()
		{
		}
	}

	[Token(Token = "0x2000CDE")]
	public class VolumeInfo
	{
		[Token(Token = "0x4007FB7")]
		[FieldOffset(Offset = "0x10")]
		public PostProcessVolume m_Volume;

		[Token(Token = "0x4007FB8")]
		[FieldOffset(Offset = "0x18")]
		public float m_Weight;

		[Token(Token = "0x60065E1")]
		[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
		public VolumeInfo()
		{
		}
	}

	[Token(Token = "0x4007F87")]
	[FieldOffset(Offset = "0x20")]
	public Transform volumeTrigger;

	[Token(Token = "0x4007F88")]
	[FieldOffset(Offset = "0x28")]
	public LayerMask volumeLayer;

	[Token(Token = "0x4007F89")]
	[FieldOffset(Offset = "0x2C")]
	public bool stopNaNPropagation;

	[Token(Token = "0x4007F8A")]
	[FieldOffset(Offset = "0x2D")]
	public bool finalBlitToCameraTarget;

	[Token(Token = "0x4007F8B")]
	[FieldOffset(Offset = "0x30")]
	public Antialiasing antialiasingMode;

	[Token(Token = "0x4007F8C")]
	[FieldOffset(Offset = "0x38")]
	public TemporalAntialiasing temporalAntialiasing;

	[Token(Token = "0x4007F8D")]
	[FieldOffset(Offset = "0x40")]
	public SubpixelMorphologicalAntialiasing subpixelMorphologicalAntialiasing;

	[Token(Token = "0x4007F8E")]
	[FieldOffset(Offset = "0x48")]
	public FastApproximateAntialiasing fastApproximateAntialiasing;

	[Token(Token = "0x4007F8F")]
	[FieldOffset(Offset = "0x50")]
	public Fog fog;

	[Token(Token = "0x4007F90")]
	[FieldOffset(Offset = "0x58")]
	private Dithering dithering;

	[Token(Token = "0x4007F91")]
	[FieldOffset(Offset = "0x60")]
	public MotionBlur motionBlurSettings;

	[Token(Token = "0x4007F92")]
	[FieldOffset(Offset = "0x68")]
	private MotionBlurRenderer motionBlurRenderer;

	[Token(Token = "0x4007F93")]
	[FieldOffset(Offset = "0x70")]
	public PostProcessDebugLayer debugLayer;

	[SerializeField]
	[Token(Token = "0x4007F94")]
	[FieldOffset(Offset = "0x78")]
	private PostProcessResources m_Resources;

	[NonSerialized]
	[Token(Token = "0x4007F95")]
	[FieldOffset(Offset = "0x80")]
	private PostProcessResources m_OldResources;

	[Preserve]
	[SerializeField]
	[Token(Token = "0x4007F96")]
	[FieldOffset(Offset = "0x88")]
	private bool m_ShowToolkit;

	[Preserve]
	[SerializeField]
	[Token(Token = "0x4007F97")]
	[FieldOffset(Offset = "0x89")]
	private bool m_ShowCustomSorter;

	[Token(Token = "0x4007F98")]
	[FieldOffset(Offset = "0x8A")]
	public bool breakBeforeColorGrading;

	[Token(Token = "0x4007F99")]
	[FieldOffset(Offset = "0x8B")]
	public bool enableBuiltins;

	[SerializeField]
	[Token(Token = "0x4007F9A")]
	[FieldOffset(Offset = "0x90")]
	private List<SerializedBundleRef> m_BeforeTransparentBundles;

	[SerializeField]
	[Token(Token = "0x4007F9B")]
	[FieldOffset(Offset = "0x98")]
	private List<SerializedBundleRef> m_BeforeStackBundles;

	[SerializeField]
	[Token(Token = "0x4007F9C")]
	[FieldOffset(Offset = "0xA0")]
	private List<SerializedBundleRef> m_AfterStackBundles;

	[Token(Token = "0x4007FA0")]
	[FieldOffset(Offset = "0xB8")]
	private Dictionary<Type, PostProcessBundle> m_Bundles;

	[Token(Token = "0x4007FA1")]
	[FieldOffset(Offset = "0xC0")]
	private PropertySheetFactory m_PropertySheetFactory;

	[Token(Token = "0x4007FA2")]
	[FieldOffset(Offset = "0xC8")]
	private CommandBuffer m_LegacyCmdBufferBeforeReflections;

	[Token(Token = "0x4007FA3")]
	[FieldOffset(Offset = "0xD0")]
	private CommandBuffer m_LegacyCmdBufferBeforeLighting;

	[Token(Token = "0x4007FA4")]
	[FieldOffset(Offset = "0xD8")]
	private CommandBuffer m_LegacyCmdBufferOpaque;

	[Token(Token = "0x4007FA5")]
	[FieldOffset(Offset = "0xE0")]
	private CommandBuffer m_LegacyCmdBuffer;

	[Token(Token = "0x4007FA6")]
	[FieldOffset(Offset = "0xE8")]
	private Camera m_Camera;

	[Token(Token = "0x4007FA7")]
	[FieldOffset(Offset = "0xF0")]
	private PostProcessRenderContext m_CurrentContext;

	[Token(Token = "0x4007FA8")]
	[FieldOffset(Offset = "0xF8")]
	private LogHistogram m_LogHistogram;

	[Token(Token = "0x4007FA9")]
	[FieldOffset(Offset = "0x100")]
	private bool m_SettingsUpdateNeeded;

	[Token(Token = "0x4007FAA")]
	[FieldOffset(Offset = "0x101")]
	private bool m_IsRenderingInSceneView;

	[Token(Token = "0x4007FAB")]
	[FieldOffset(Offset = "0x108")]
	private TargetPool m_TargetPool;

	[Token(Token = "0x4007FAC")]
	[FieldOffset(Offset = "0x110")]
	private bool m_NaNKilled;

	[Token(Token = "0x4007FAD")]
	[FieldOffset(Offset = "0x118")]
	private readonly List<PostProcessEffectRenderer> m_ActiveEffects;

	[Token(Token = "0x4007FAE")]
	[FieldOffset(Offset = "0x120")]
	private readonly List<RenderTargetIdentifier> m_Targets;

	[Token(Token = "0x4007FAF")]
	[FieldOffset(Offset = "0x128")]
	private List<VolumeInfo> m_PreviousGlobalVolumeInfoList;

	[Token(Token = "0x170006CC")]
	[field: Token(Token = "0x4007F9D")]
	[field: FieldOffset(Offset = "0xA8")]
	public Dictionary<PostProcessEvent, List<SerializedBundleRef>> sortedBundles
	{
		[Token(Token = "0x60065B1")]
		[Address(RVA = "0x636F10", Offset = "0x635D10", Length = "0x8")]
		get;
		[Token(Token = "0x60065B2")]
		[Address(RVA = "0x6BCEA0", Offset = "0x6BBCA0", Length = "0x52")]
		private set;
	}

	[Token(Token = "0x170006CD")]
	[field: Token(Token = "0x4007F9E")]
	[field: FieldOffset(Offset = "0xB0")]
	public DepthTextureMode cameraDepthFlags
	{
		[Token(Token = "0x60065B3")]
		[Address(RVA = "0x5DEE90", Offset = "0x5DDC90", Length = "0x7")]
		get;
		[Token(Token = "0x60065B4")]
		[Address(RVA = "0x10165B0", Offset = "0x10153B0", Length = "0x7")]
		private set;
	}

	[Token(Token = "0x170006CE")]
	[field: Token(Token = "0x4007F9F")]
	[field: FieldOffset(Offset = "0xB4")]
	public bool haveBundlesBeenInited
	{
		[Token(Token = "0x60065B5")]
		[Address(RVA = "0x5DD360", Offset = "0x5DC160", Length = "0x8")]
		get;
		[Token(Token = "0x60065B6")]
		[Address(RVA = "0x5DD190", Offset = "0x5DBF90", Length = "0x7")]
		private set;
	}

	[Token(Token = "0x60065B7")]
	[Address(RVA = "0x10165C0", Offset = "0x10153C0", Length = "0x37D")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x60065B8")]
	[Address(RVA = "0x1016940", Offset = "0x1015740", Length = "0x4FC")]
	private void InitLegacy()
	{
	}

	[Token(Token = "0x60065B9")]
	[Address(RVA = "0x1016E40", Offset = "0x1015C40", Length = "0xF3")]
	private bool DynamicResolutionAllowsFinalBlitToCameraTarget()
	{
		return false;
	}

	[ImageEffectUsesCommandBuffer]
	[Token(Token = "0x60065BA")]
	[Address(RVA = "0x1016F40", Offset = "0x1015D40", Length = "0xB2")]
	private void OnRenderImage(RenderTexture src, RenderTexture dst)
	{
	}

	[Token(Token = "0x60065BB")]
	[Address(RVA = "0x1017000", Offset = "0x1015E00", Length = "0x360")]
	public void Init(PostProcessResources resources)
	{
	}

	[Token(Token = "0x60065BC")]
	[Address(RVA = "0x1017370", Offset = "0x1016170", Length = "0x729")]
	public void InitBundles()
	{
	}

	[Token(Token = "0x60065BD")]
	[Address(RVA = "0x1017AA0", Offset = "0x10168A0", Length = "0x9CC")]
	private void UpdateBundleSortList(List<SerializedBundleRef> sortedList, PostProcessEvent evt)
	{
	}

	[Token(Token = "0x60065BE")]
	[Address(RVA = "0x1018470", Offset = "0x1017270", Length = "0x64D")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x60065BF")]
	[Address(RVA = "0x1018AC0", Offset = "0x10178C0", Length = "0x57")]
	private void Reset()
	{
	}

	[Token(Token = "0x60065C0")]
	[Address(RVA = "0x1018B20", Offset = "0x1017920", Length = "0x5F7")]
	private void OnPreCull()
	{
	}

	[Token(Token = "0x60065C1")]
	[Address(RVA = "0x1019120", Offset = "0x1017F20", Length = "0xFC")]
	private void OnPreRender()
	{
	}

	[Token(Token = "0x60065C2")]
	[Address(RVA = "0x430B50", Offset = "0x42F950", Length = "0x3")]
	private static bool RequiresInitialBlit(Camera camera, PostProcessRenderContext context)
	{
		return false;
	}

	[Token(Token = "0x60065C3")]
	[Address(RVA = "0x1019220", Offset = "0x1018020", Length = "0x255")]
	private void UpdateSrcDstForOpaqueOnly(ref int src, ref int dst, PostProcessRenderContext context, RenderTargetIdentifier cameraTarget, int opaqueOnlyEffectsRemaining)
	{
	}

	[Token(Token = "0x60065C4")]
	[Address(RVA = "0x1019480", Offset = "0x1018280", Length = "0x1412")]
	private void BuildCommandBuffers()
	{
	}

	[Token(Token = "0x60065C5")]
	[Address(RVA = "0x101A8A0", Offset = "0x10196A0", Length = "0x15C")]
	private void OnPostRender()
	{
	}

	[Token(Token = "0x60065C6")]
	[Address(RVA = "0x1971BC0", Offset = "0x19709C0", Length = "0xB6")]
	public PostProcessBundle GetBundle<T>() where T : PostProcessEffectSettings
	{
		return null;
	}

	[Token(Token = "0x60065C7")]
	[Address(RVA = "0x101AA00", Offset = "0x1019800", Length = "0x5B")]
	public PostProcessBundle GetBundle(Type settingsType)
	{
		return null;
	}

	[Token(Token = "0x60065C8")]
	[Address(RVA = "0x1971C80", Offset = "0x1970A80", Length = "0x52")]
	public T GetSettings<T>() where T : PostProcessEffectSettings
	{
		return null;
	}

	[Token(Token = "0x60065C9")]
	[Address(RVA = "0x101AA60", Offset = "0x1019860", Length = "0x1E7")]
	public void BakeMSVOMap(CommandBuffer cmd, Camera camera, RenderTargetIdentifier destination, RenderTargetIdentifier? depthMap, bool invert, bool isMSAA = false)
	{
	}

	[Token(Token = "0x60065CA")]
	[Address(RVA = "0x101AC50", Offset = "0x1019A50", Length = "0x282")]
	internal void OverrideSettings(List<PostProcessEffectSettings> baseSettings, float interpFactor)
	{
	}

	[Token(Token = "0x60065CB")]
	[Address(RVA = "0x101AEE0", Offset = "0x1019CE0", Length = "0x3F1")]
	private void SetLegacyCameraFlags(PostProcessRenderContext context)
	{
	}

	[Token(Token = "0x60065CC")]
	[Address(RVA = "0x101B2E0", Offset = "0x101A0E0", Length = "0x1A8")]
	public void ResetHistory()
	{
	}

	[Token(Token = "0x60065CD")]
	[Address(RVA = "0x101B490", Offset = "0x101A290", Length = "0xD")]
	public bool HasOpaqueOnlyEffects(PostProcessRenderContext context)
	{
		return false;
	}

	[Token(Token = "0x60065CE")]
	[Address(RVA = "0x101B4A0", Offset = "0x101A2A0", Length = "0x228")]
	public bool HasActiveEffects(PostProcessEvent evt, PostProcessRenderContext context)
	{
		return false;
	}

	[Token(Token = "0x60065CF")]
	[Address(RVA = "0x101B6D0", Offset = "0x101A4D0", Length = "0x64B")]
	private void SetupContext(PostProcessRenderContext context)
	{
	}

	[Token(Token = "0x60065D0")]
	[Address(RVA = "0x101BD20", Offset = "0x101AB20", Length = "0x167")]
	public void UpdateVolumeSystem(Camera cam, CommandBuffer cmd)
	{
	}

	[Token(Token = "0x60065D1")]
	[Address(RVA = "0x101BE90", Offset = "0x101AC90", Length = "0xFB")]
	public void RenderOpaqueOnly(PostProcessRenderContext context)
	{
	}

	[Token(Token = "0x60065D2")]
	[Address(RVA = "0x101BF90", Offset = "0x101AD90", Length = "0x301")]
	public VolumeInfo GetPreviousVolumeInfo(PostProcessVolume volume)
	{
		return null;
	}

	[Token(Token = "0x60065D3")]
	[Address(RVA = "0x101C2A0", Offset = "0x101B0A0", Length = "0x1A8")]
	public bool HaveGlobalVolumesChanged(List<PostProcessVolume> volumes)
	{
		return false;
	}

	[Token(Token = "0x60065D4")]
	[Address(RVA = "0x101C450", Offset = "0x101B250", Length = "0x164")]
	public bool AreAllVolumesGlobal(List<PostProcessVolume> volumes)
	{
		return false;
	}

	[Token(Token = "0x60065D5")]
	[Address(RVA = "0x101C5C0", Offset = "0x101B3C0", Length = "0x252")]
	public void UpdateGlobalVolumeInfoList(List<PostProcessVolume> volumes)
	{
	}

	[Token(Token = "0x60065D6")]
	[Address(RVA = "0x101C820", Offset = "0x101B620", Length = "0xD14")]
	public void Render(PostProcessRenderContext context)
	{
	}

	[Token(Token = "0x60065D7")]
	[Address(RVA = "0x101D540", Offset = "0x101C340", Length = "0x2DC")]
	private int RenderInjectionPoint(PostProcessEvent evt, PostProcessRenderContext context, string marker, int releaseTargetAfterUse = -1)
	{
		return 0;
	}

	[Token(Token = "0x60065D8")]
	[Address(RVA = "0x101D820", Offset = "0x101C620", Length = "0xC03")]
	private void RenderList(List<SerializedBundleRef> list, PostProcessRenderContext context, string marker)
	{
	}

	[Token(Token = "0x60065D9")]
	[Address(RVA = "0x101E430", Offset = "0x101D230", Length = "0x12C")]
	private void ApplyFlip(PostProcessRenderContext context, MaterialPropertyBlock properties)
	{
	}

	[Token(Token = "0x60065DA")]
	[Address(RVA = "0x101E560", Offset = "0x101D360", Length = "0x12E")]
	private void ApplyDefaultFlip(MaterialPropertyBlock properties)
	{
	}

	[Token(Token = "0x60065DB")]
	[Address(RVA = "0x101E690", Offset = "0x101D490", Length = "0xEC0")]
	private int RenderBuiltins(PostProcessRenderContext context, bool isFinalPass, int releaseTargetAfterUse = -1, int eye = -1)
	{
		return 0;
	}

	[Token(Token = "0x60065DC")]
	[Address(RVA = "0x101F560", Offset = "0x101E360", Length = "0xB35")]
	private void RenderFinalPass(PostProcessRenderContext context, int releaseTargetAfterUse = -1, int eye = -1)
	{
	}

	[Token(Token = "0x60065DD")]
	[Address(RVA = "0x1971CE0", Offset = "0x1970AE0", Length = "0x2BA")]
	private int RenderEffect<T>(PostProcessRenderContext context, bool useTempTarget = false) where T : PostProcessEffectSettings
	{
		return 0;
	}

	[Token(Token = "0x60065DE")]
	[Address(RVA = "0x10200A0", Offset = "0x101EEA0", Length = "0xA4")]
	private bool ShouldGenerateLogHistogram(PostProcessRenderContext context)
	{
		return false;
	}

	[Token(Token = "0x60065DF")]
	[Address(RVA = "0x1020150", Offset = "0x101EF50", Length = "0x2CF")]
	public PostProcessLayer()
	{
	}
}
