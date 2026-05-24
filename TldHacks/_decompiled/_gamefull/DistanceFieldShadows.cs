using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.ResourceManagement.AsyncOperations;

[RequireComponent(typeof(Camera))]
[Token(Token = "0x20008F6")]
public class DistanceFieldShadows : MonoBehaviour
{
	[AutoComponent(ComponentRequirement.Required)]
	[SerializeField]
	[Token(Token = "0x4005DCB")]
	[FieldOffset(Offset = "0x20")]
	private Camera m_Camera;

	[Header("Ambient Occlusion")]
	[SerializeField]
	[Token(Token = "0x4005DCC")]
	[FieldOffset(Offset = "0x28")]
	private float m_AOPenumbra;

	[SerializeField]
	[Range(0f, 1f)]
	[Token(Token = "0x4005DCD")]
	[FieldOffset(Offset = "0x2C")]
	private float m_AOIntensity;

	[Header("Directional")]
	[SerializeField]
	[Token(Token = "0x4005DCE")]
	[FieldOffset(Offset = "0x30")]
	private float m_ShadowPenumbra;

	[SerializeField]
	[Range(0f, 1f)]
	[Token(Token = "0x4005DCF")]
	[FieldOffset(Offset = "0x34")]
	private float m_ShadowIntensity;

	[Header("Terrain")]
	[SerializeField]
	[Token(Token = "0x4005DD0")]
	[FieldOffset(Offset = "0x38")]
	private float m_TerrainPenumbra;

	[SerializeField]
	[Range(0f, 1f)]
	[Token(Token = "0x4005DD1")]
	[FieldOffset(Offset = "0x3C")]
	private float m_TerrainShadowIntensity;

	[SerializeField]
	[Token(Token = "0x4005DD2")]
	[FieldOffset(Offset = "0x40")]
	private float m_TerrainSampleScale;

	[SerializeField]
	[Token(Token = "0x4005DD3")]
	[FieldOffset(Offset = "0x44")]
	private float m_TerrainFadeStart;

	[SerializeField]
	[Token(Token = "0x4005DD4")]
	[FieldOffset(Offset = "0x48")]
	private float m_TerrainFadeEnd;

	[Header("Common Settings")]
	[SerializeField]
	[Token(Token = "0x4005DD5")]
	[FieldOffset(Offset = "0x4C")]
	private float m_SampleOffset;

	[SerializeField]
	[Token(Token = "0x4005DD6")]
	[FieldOffset(Offset = "0x50")]
	private float m_ResultPower;

	[SerializeField]
	[Token(Token = "0x4005DD7")]
	[FieldOffset(Offset = "0x54")]
	private float m_ResultMultiplier;

	[Tooltip("Reduces strength on snow/ice from the ambient and directional shadows")]
	[SerializeField]
	[Token(Token = "0x4005DD8")]
	[FieldOffset(Offset = "0x58")]
	private float m_SnowIceMultiplier;

	[Token(Token = "0x4005DD9")]
	[FieldOffset(Offset = "0x5C")]
	private bool m_Initialized;

	[Token(Token = "0x4005DDA")]
	[FieldOffset(Offset = "0x60")]
	private GlobalKeyword m_SDFShadowsKeyword;

	[Token(Token = "0x4005DDB")]
	[FieldOffset(Offset = "0x70")]
	private Material m_RenderMaterial;

	[Token(Token = "0x4005DDC")]
	[FieldOffset(Offset = "0x78")]
	private Light m_DirectionalLight;

	[Token(Token = "0x4005DDD")]
	[FieldOffset(Offset = "0x80")]
	private CommandBuffer m_CommandBuffer;

	[Token(Token = "0x4005DDE")]
	[FieldOffset(Offset = "0x88")]
	private SceneDistanceFieldSettings m_SceneSettings;

	[Token(Token = "0x4005DDF")]
	[FieldOffset(Offset = "0x90")]
	private AsyncOperationHandle<Texture2D> m_HeightmapLoadOpHandle;

	[Token(Token = "0x4005DE0")]
	[FieldOffset(Offset = "0xA8")]
	private Texture2D m_Heightmap;

	[Token(Token = "0x4005DE1")]
	private const CameraEvent COMMAND_BUFFER_CAMERA_EVENT = CameraEvent.BeforeImageEffectsOpaque;

	[Token(Token = "0x4005DE2")]
	private const string SHADER_NAME = "TLD/Post Processing/Distance Field Shadows";

	[Token(Token = "0x4005DE3")]
	private const string ENABLE_SDF_SHADOWS_KEYWORD = "TLD_ENABLE_SDF_SHADOWS";

	[Token(Token = "0x4005DE4")]
	private const string USE_NEAR_SDF = "TLD_USE_NEAR_SDF";

	[Token(Token = "0x4005DE5")]
	private const string USE_AMBIENT_OCCLUSION_KEYWORD = "TLD_USE_AMBIENT_OCCLUSION";

	[Token(Token = "0x4005DE6")]
	private const string USE_DIRECTIONAL_SHADOWS_KEYWORD = "TLD_USE_DIRECTIONAL_SHADOWS";

	[Token(Token = "0x4005DE7")]
	private const string USE_TERRAIN_SHADOWS_KEYWORD = "TLD_USE_TERRAIN_SHADOWS";

	[Token(Token = "0x4005DE8")]
	private static readonly int s_RenderTextureNameID;

	[Token(Token = "0x4005DE9")]
	private static readonly int s_CamToWorldID;

	[Token(Token = "0x4005DEA")]
	private static readonly int s_LightDirID;

	[Token(Token = "0x4005DEB")]
	private static readonly int s_AOPenumbraID;

	[Token(Token = "0x4005DEC")]
	private static readonly int s_AOIntensityID;

	[Token(Token = "0x4005DED")]
	private static readonly int s_ShadowPenumbraID;

	[Token(Token = "0x4005DEE")]
	private static readonly int s_ShadowIntensityID;

	[Token(Token = "0x4005DEF")]
	private static readonly int s_TerrainPenumbraID;

	[Token(Token = "0x4005DF0")]
	private static readonly int s_TerrainShadowIntensityID;

	[Token(Token = "0x4005DF1")]
	private static readonly int s_TerrainSampleScaleID;

	[Token(Token = "0x4005DF2")]
	private static readonly int s_TerrainFadeStartID;

	[Token(Token = "0x4005DF3")]
	private static readonly int s_TerrainFadeEndID;

	[Token(Token = "0x4005DF4")]
	private static readonly int s_TerrainTexID;

	[Token(Token = "0x4005DF5")]
	private static readonly int s_TerrainCoordsMinID;

	[Token(Token = "0x4005DF6")]
	private static readonly int s_TerrainCoordsMaxID;

	[Token(Token = "0x4005DF7")]
	private static readonly int s_ResultPowerID;

	[Token(Token = "0x4005DF8")]
	private static readonly int s_ResultMultiplierID;

	[Token(Token = "0x4005DF9")]
	private static readonly int s_SampleOffsetID;

	[Token(Token = "0x4005DFA")]
	private static readonly int s_SnowIceMultiplierID;

	[Token(Token = "0x600522C")]
	[Address(RVA = "0xE3D9F0", Offset = "0xE3C7F0", Length = "0xA")]
	private void Start()
	{
	}

	[Token(Token = "0x600522D")]
	[Address(RVA = "0xE3DA00", Offset = "0xE3C800", Length = "0x23C")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x600522E")]
	[Address(RVA = "0xE3DC40", Offset = "0xE3CA40", Length = "0x478")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x600522F")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	private void OnValidate()
	{
	}

	[Token(Token = "0x6005230")]
	[Address(RVA = "0xE3E0C0", Offset = "0xE3CEC0", Length = "0xBC")]
	private void OnHeightmapLoaded(AsyncOperationHandle<Texture2D> op)
	{
	}

	[Token(Token = "0x6005231")]
	[Address(RVA = "0xE3E180", Offset = "0xE3CF80", Length = "0x10CF")]
	private void OnPreRender()
	{
	}

	[Token(Token = "0x6005232")]
	[Address(RVA = "0xE3F250", Offset = "0xE3E050", Length = "0x436")]
	private bool TryGetSceneSettingsAndLoadHeightmap()
	{
		return false;
	}

	[Token(Token = "0x6005233")]
	[Address(RVA = "0xE3F690", Offset = "0xE3E490", Length = "0x9E")]
	public DistanceFieldShadows()
	{
	}
}
