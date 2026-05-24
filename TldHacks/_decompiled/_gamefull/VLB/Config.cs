using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.Serialization;

namespace VLB;

[HelpURL("http://saladgamer.com/vlb-doc/config/")]
[Token(Token = "0x2000BBA")]
public class Config : ScriptableObject
{
	[Token(Token = "0x4007853")]
	[FieldOffset(Offset = "0x18")]
	public bool geometryOverrideLayer;

	[Token(Token = "0x4007854")]
	[FieldOffset(Offset = "0x1C")]
	public int geometryLayerID;

	[Token(Token = "0x4007855")]
	[FieldOffset(Offset = "0x20")]
	public string geometryTag;

	[Token(Token = "0x4007856")]
	[FieldOffset(Offset = "0x28")]
	public int geometryRenderQueue;

	[FormerlySerializedAs("renderPipeline")]
	[SerializeField]
	[Token(Token = "0x4007857")]
	[FieldOffset(Offset = "0x2C")]
	private RenderPipeline _RenderPipeline;

	[FormerlySerializedAs("renderingMode")]
	[SerializeField]
	[Token(Token = "0x4007858")]
	[FieldOffset(Offset = "0x30")]
	private RenderingMode _RenderingMode;

	[Token(Token = "0x4007859")]
	[FieldOffset(Offset = "0x34")]
	public float ditheringFactor;

	[Token(Token = "0x400785A")]
	[FieldOffset(Offset = "0x38")]
	public int sharedMeshSides;

	[Token(Token = "0x400785B")]
	[FieldOffset(Offset = "0x3C")]
	public int sharedMeshSegments;

	[Range(0.01f, 2f)]
	[Token(Token = "0x400785C")]
	[FieldOffset(Offset = "0x40")]
	public float globalNoiseScale;

	[Token(Token = "0x400785D")]
	[FieldOffset(Offset = "0x44")]
	public Vector3 globalNoiseVelocity;

	[Token(Token = "0x400785E")]
	[FieldOffset(Offset = "0x50")]
	public string fadeOutCameraTag;

	[HighlightNull]
	[Token(Token = "0x400785F")]
	[FieldOffset(Offset = "0x58")]
	public TextAsset noise3DData;

	[Token(Token = "0x4007860")]
	[FieldOffset(Offset = "0x60")]
	public int noise3DSize;

	[HighlightNull]
	[Token(Token = "0x4007861")]
	[FieldOffset(Offset = "0x68")]
	public ParticleSystem dustParticlesPrefab;

	[Token(Token = "0x4007862")]
	[FieldOffset(Offset = "0x70")]
	public Texture2D ditheringNoiseTexture;

	[Token(Token = "0x4007863")]
	[FieldOffset(Offset = "0x78")]
	public FeatureEnabledColorGradient featureEnabledColorGradient;

	[Token(Token = "0x4007864")]
	[FieldOffset(Offset = "0x7C")]
	public bool featureEnabledDepthBlend;

	[Token(Token = "0x4007865")]
	[FieldOffset(Offset = "0x7D")]
	public bool featureEnabledNoise3D;

	[Token(Token = "0x4007866")]
	[FieldOffset(Offset = "0x7E")]
	public bool featureEnabledDynamicOcclusion;

	[Token(Token = "0x4007867")]
	[FieldOffset(Offset = "0x7F")]
	public bool featureEnabledMeshSkewing;

	[Token(Token = "0x4007868")]
	[FieldOffset(Offset = "0x80")]
	public bool featureEnabledShaderAccuracyHigh;

	[SerializeField]
	[Token(Token = "0x4007869")]
	[FieldOffset(Offset = "0x84")]
	private int pluginVersion;

	[SerializeField]
	[Token(Token = "0x400786A")]
	[FieldOffset(Offset = "0x88")]
	private Material _DummyMaterial;

	[SerializeField]
	[Token(Token = "0x400786B")]
	[FieldOffset(Offset = "0x90")]
	private Shader _BeamShader;

	[Token(Token = "0x400786C")]
	[FieldOffset(Offset = "0x98")]
	private Transform m_CachedFadeOutCamera;

	[Token(Token = "0x400786D")]
	private static Config ms_Instance;

	[Token(Token = "0x170003C8")]
	public RenderPipeline renderPipeline
	{
		[Token(Token = "0x6005D27")]
		[Address(RVA = "0x504230", Offset = "0x503030", Length = "0x4")]
		get
		{
			return default(RenderPipeline);
		}
		[Token(Token = "0x6005D28")]
		[Address(RVA = "0xF5F3A0", Offset = "0xF5E1A0", Length = "0x5D")]
		set
		{
		}
	}

	[Token(Token = "0x170003C9")]
	public RenderingMode renderingMode
	{
		[Token(Token = "0x6005D29")]
		[Address(RVA = "0x677F80", Offset = "0x676D80", Length = "0x4")]
		get
		{
			return default(RenderingMode);
		}
		[Token(Token = "0x6005D2A")]
		[Address(RVA = "0xF5F400", Offset = "0xF5E200", Length = "0x5D")]
		set
		{
		}
	}

	[Token(Token = "0x170003CA")]
	public RenderingMode actualRenderingMode
	{
		[Token(Token = "0x6005D2C")]
		[Address(RVA = "0xF5F490", Offset = "0xF5E290", Length = "0x4B")]
		get
		{
			return default(RenderingMode);
		}
	}

	[Token(Token = "0x170003CB")]
	public bool useSinglePassShader
	{
		[Token(Token = "0x6005D2D")]
		[Address(RVA = "0xF5F4E0", Offset = "0xF5E2E0", Length = "0x5A")]
		get
		{
			return false;
		}
	}

	[Token(Token = "0x170003CC")]
	public bool requiresDoubleSidedMesh
	{
		[Token(Token = "0x6005D2E")]
		[Address(RVA = "0xF5F4E0", Offset = "0xF5E2E0", Length = "0x5A")]
		get
		{
			return false;
		}
	}

	[Token(Token = "0x170003CD")]
	public Shader beamShader
	{
		[Token(Token = "0x6005D2F")]
		[Address(RVA = "0x40DA00", Offset = "0x40C800", Length = "0x8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170003CE")]
	public Transform fadeOutCameraTransform
	{
		[Token(Token = "0x6005D30")]
		[Address(RVA = "0xF5F540", Offset = "0xF5E340", Length = "0x1F8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170003CF")]
	public bool hasRenderPipelineMismatch
	{
		[Token(Token = "0x6005D32")]
		[Address(RVA = "0xF5F870", Offset = "0xF5E670", Length = "0x25")]
		get
		{
			return false;
		}
	}

	[Token(Token = "0x170003D0")]
	public static Config Instance
	{
		[Token(Token = "0x6005D3A")]
		[Address(RVA = "0xF60460", Offset = "0xF5F260", Length = "0x9")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6005D2B")]
	[Address(RVA = "0xF5F460", Offset = "0xF5E260", Length = "0x2F")]
	public bool IsSRPBatcherSupported()
	{
		return false;
	}

	[Token(Token = "0x6005D31")]
	[Address(RVA = "0xF5F740", Offset = "0xF5E540", Length = "0x12C")]
	public void ForceUpdateFadeOutCamera()
	{
	}

	[RuntimeInitializeOnLoadMethod]
	[Token(Token = "0x6005D33")]
	[Address(RVA = "0xF5F8A0", Offset = "0xF5E6A0", Length = "0x267")]
	private static void OnStartup()
	{
	}

	[Token(Token = "0x6005D34")]
	[Address(RVA = "0xF5FB10", Offset = "0xF5E910", Length = "0x244")]
	public void Reset()
	{
	}

	[Token(Token = "0x6005D35")]
	[Address(RVA = "0xF5FD60", Offset = "0xF5EB60", Length = "0x150")]
	private void RefreshGlobalShaderProperties()
	{
	}

	[Token(Token = "0x6005D36")]
	[Address(RVA = "0xF5FEC0", Offset = "0xF5ECC0", Length = "0x30E")]
	public void ResetInternalData()
	{
	}

	[Token(Token = "0x6005D37")]
	[Address(RVA = "0xF601D0", Offset = "0xF5EFD0", Length = "0x278")]
	public ParticleSystem NewVolumetricDustParticles()
	{
		return null;
	}

	[Token(Token = "0x6005D38")]
	[Address(RVA = "0xF60450", Offset = "0xF5F250", Length = "0xD")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6005D39")]
	[Address(RVA = "0x60BBE0", Offset = "0x60A9E0", Length = "0x3")]
	private void HandleBackwardCompatibility(int serializedVersion, int newVersion)
	{
	}

	[Token(Token = "0x6005D3B")]
	[Address(RVA = "0xF60470", Offset = "0xF5F270", Length = "0x395")]
	private static Config GetInstance(bool assertIfNotFound)
	{
		return null;
	}

	[Token(Token = "0x6005D3C")]
	[Address(RVA = "0xF60810", Offset = "0xF5F610", Length = "0x1A5")]
	public Config()
	{
	}
}
