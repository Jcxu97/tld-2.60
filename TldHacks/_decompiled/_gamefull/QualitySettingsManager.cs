using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x20007C1")]
public class QualitySettingsManager : MonoBehaviour
{
	[Header("Presets")]
	[Token(Token = "0x400536F")]
	[FieldOffset(Offset = "0x20")]
	public QualityLevelSettings m_QualityPresetLow;

	[Token(Token = "0x4005370")]
	[FieldOffset(Offset = "0x28")]
	public QualityLevelSettings m_QualityPresetMedium;

	[Token(Token = "0x4005371")]
	[FieldOffset(Offset = "0x30")]
	public QualityLevelSettings m_QualityPresetHigh;

	[Token(Token = "0x4005372")]
	[FieldOffset(Offset = "0x38")]
	public QualityLevelSettings m_QualityPresetUltra;

	[Token(Token = "0x4005373")]
	[FieldOffset(Offset = "0x40")]
	public QualityLevelSettings m_QualityPresetFancy;

	[Token(Token = "0x4005374")]
	[FieldOffset(Offset = "0x48")]
	public QualityLevelSettings m_QualityPresetXboxOne;

	[Token(Token = "0x4005375")]
	[FieldOffset(Offset = "0x50")]
	public QualityLevelSettings m_QualityPresetPS4;

	[Token(Token = "0x4005376")]
	[FieldOffset(Offset = "0x58")]
	public QualityLevelSettings m_QualityPresetXboxOneX;

	[Token(Token = "0x4005377")]
	[FieldOffset(Offset = "0x60")]
	public QualityLevelSettings m_QualityPresetPS4Pro;

	[Token(Token = "0x4005378")]
	[FieldOffset(Offset = "0x68")]
	public QualityLevelSettings m_QualityPresetSwitch;

	[Token(Token = "0x4005379")]
	[FieldOffset(Offset = "0x70")]
	public QualityLevelSettings m_QualityPresetSwitchBoost;

	[Token(Token = "0x400537A")]
	[FieldOffset(Offset = "0x78")]
	public QualityLevelSettings m_QualityPresetXboxSeries;

	[Token(Token = "0x400537B")]
	[FieldOffset(Offset = "0x80")]
	public QualityLevelSettings m_QualityPresetXboxSeriesS;

	[Token(Token = "0x400537C")]
	[FieldOffset(Offset = "0x88")]
	public QualityLevelSettings m_QualityPresetPS5;

	[Token(Token = "0x400537D")]
	public const float m_RockDrawDistanceMin = 0.5f;

	[Token(Token = "0x400537E")]
	public const float m_RockDrawDistanceMax = 2f;

	[Token(Token = "0x400537F")]
	public const float m_SceneDrawDistanceMin = 0.5f;

	[Token(Token = "0x4005380")]
	public const float m_SceneDrawDistanceMax = 2f;

	[Token(Token = "0x4005381")]
	public const float m_ShadowDrawDistanceMin = 20f;

	[Token(Token = "0x4005382")]
	public const float m_ShadowDrawDistanceMax = 250f;

	[Token(Token = "0x4005383")]
	public const float m_TreeDrawDistanceMin = 0.5f;

	[Token(Token = "0x4005384")]
	public const float m_TreeDrawDistanceMax = 2f;

	[Token(Token = "0x4005385")]
	public const float m_GroundDetailsDrawDistanceMin = 20f;

	[Token(Token = "0x4005386")]
	public const float m_GroundDetailsDrawDistanceMax = 250f;

	[Token(Token = "0x4005387")]
	public const float m_GroundDetailsDensityMin = 0f;

	[Token(Token = "0x4005388")]
	public const float m_GroundDetailsDensityMax = 100f;

	[Token(Token = "0x4005389")]
	public const int MIN_SYSTEM_RAM_FOR_FULLRES_TEXTURES_MB = 4096;

	[Token(Token = "0x400538A")]
	public const int MAX_HEIGHTMAP_PIXEL_ERROR = 200;

	[Token(Token = "0x400538B")]
	public const int TERRAIN_BLENDING_SHADER_LOD = 1100;

	[Token(Token = "0x400538C")]
	[FieldOffset(Offset = "0x90")]
	private LodBias m_SceneLodBias;

	[Token(Token = "0x400538D")]
	private static QualitySettingsManagerSaveData m_QualitySettingsManagerSaveData;

	[Token(Token = "0x400538E")]
	private static Quality m_CurrentQuality;

	[Token(Token = "0x400538F")]
	private static QualityLevelSettings m_QualityCustom;

	[Token(Token = "0x4005390")]
	private static bool s_RestartPending;

	[Token(Token = "0x4005391")]
	private static int s_PendingMasterTextureLimit;

	[Token(Token = "0x4005392")]
	private static int s_CurrentAnisoLevel;

	[Token(Token = "0x600493C")]
	[Address(RVA = "0xD16840", Offset = "0xD15640", Length = "0x8FB")]
	private void Awake()
	{
	}

	[Token(Token = "0x600493D")]
	[Address(RVA = "0xD17140", Offset = "0xD15F40", Length = "0x181")]
	private void Start()
	{
	}

	[Token(Token = "0x600493E")]
	[Address(RVA = "0xD172D0", Offset = "0xD160D0", Length = "0x155")]
	public string Serialize()
	{
		return null;
	}

	[Token(Token = "0x600493F")]
	[Address(RVA = "0xD17430", Offset = "0xD16230", Length = "0xD3")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6004940")]
	[Address(RVA = "0xD17510", Offset = "0xD16310", Length = "0x390")]
	public void Deserialize(string text)
	{
	}

	[Token(Token = "0x6004941")]
	[Address(RVA = "0xD178B0", Offset = "0xD166B0", Length = "0x5A")]
	public Quality SetCurrentQualityLevel(Quality quality)
	{
		return default(Quality);
	}

	[Token(Token = "0x6004942")]
	[Address(RVA = "0xD17910", Offset = "0xD16710", Length = "0x53")]
	public Quality GetCurrentQualityLevel()
	{
		return default(Quality);
	}

	[Token(Token = "0x6004943")]
	[Address(RVA = "0xD17970", Offset = "0xD16770", Length = "0x1F4")]
	public QualityLevelSettings GetQualitySettings(Quality quality)
	{
		return null;
	}

	[Token(Token = "0x6004944")]
	[Address(RVA = "0xD17BA0", Offset = "0xD169A0", Length = "0x63")]
	public QualityLevelSettings GetCurrentQualitySettings()
	{
		return null;
	}

	[Token(Token = "0x6004945")]
	[Address(RVA = "0xD17C10", Offset = "0xD16A10", Length = "0x63")]
	public void ApplyCurrentQualitySettings()
	{
	}

	[Token(Token = "0x6004946")]
	[Address(RVA = "0xD17C80", Offset = "0xD16A80", Length = "0x5E2")]
	public bool SetAndMaybeApplyQuality(Quality quality, bool force)
	{
		return false;
	}

	[Token(Token = "0x6004947")]
	[Address(RVA = "0xD18270", Offset = "0xD17070", Length = "0x16")]
	private bool IsConsoleQualitySetting(Quality quality)
	{
		return false;
	}

	[Token(Token = "0x6004948")]
	[Address(RVA = "0xD18290", Offset = "0xD17090", Length = "0xBA")]
	private int GetAnisoLevelInt(QualityLevelSettings settings)
	{
		return 0;
	}

	[Token(Token = "0x6004949")]
	[Address(RVA = "0xD18350", Offset = "0xD17150", Length = "0x349")]
	private void ChangeAnisoLevelOnLoadedAsset(Object loadedAsset)
	{
	}

	[Token(Token = "0x600494A")]
	[Address(RVA = "0xD186A0", Offset = "0xD174A0", Length = "0x175")]
	private void ChangeAnisoLevelOnTerrains()
	{
	}

	[Token(Token = "0x600494B")]
	[Address(RVA = "0xD18820", Offset = "0xD17620", Length = "0x4DC")]
	private void ChangeAnisoLevelOnRenderers(List<Renderer> renderers)
	{
	}

	[Token(Token = "0x600494C")]
	[Address(RVA = "0xD18D00", Offset = "0xD17B00", Length = "0x13B0")]
	public void ApplyQualitySettings(Quality quality)
	{
	}

	[Token(Token = "0x600494D")]
	[Address(RVA = "0xD1A0F0", Offset = "0xD18EF0", Length = "0x114")]
	public void SetDefaultQualityLevel()
	{
	}

	[Token(Token = "0x600494E")]
	[Address(RVA = "0xD1A210", Offset = "0xD19010", Length = "0x4D")]
	public static bool SystemShouldUseLowGraphicsQuality()
	{
		return false;
	}

	[Token(Token = "0x600494F")]
	[Address(RVA = "0xD1A260", Offset = "0xD19060", Length = "0x70")]
	private void SetPostFx(QualityPostFx quality)
	{
	}

	[Token(Token = "0x6004950")]
	[Address(RVA = "0xD1A4C0", Offset = "0xD192C0", Length = "0x259")]
	public void SetSSAO(QualitySSAO quality)
	{
	}

	[Token(Token = "0x6004951")]
	[Address(RVA = "0xD1A720", Offset = "0xD19520", Length = "0xCE")]
	public void CopyQualitySettings(QualityLevelSettings dest, QualityLevelSettings source)
	{
	}

	[Token(Token = "0x6004952")]
	[Address(RVA = "0xD1A7F0", Offset = "0xD195F0", Length = "0x2A7")]
	public bool Match(QualityLevelSettings A, QualityLevelSettings B)
	{
		return false;
	}

	[Token(Token = "0x6004953")]
	[Address(RVA = "0xD1AAA0", Offset = "0xD198A0", Length = "0xF2")]
	private void ClampSliderValuesToRange(QualityLevelSettings settings)
	{
	}

	[Token(Token = "0x6004954")]
	[Address(RVA = "0xD1ABA0", Offset = "0xD199A0", Length = "0x6D")]
	private void ClampMasterTextureLimit(QualityLevelSettings settings)
	{
	}

	[Token(Token = "0x6004955")]
	[Address(RVA = "0xD1AC10", Offset = "0xD19A10", Length = "0x486")]
	private float GetLodBias(QualityLodBias quality)
	{
		return 0f;
	}

	[Token(Token = "0x6004956")]
	[Address(RVA = "0xD1B0A0", Offset = "0xD19EA0", Length = "0x3D7")]
	private float GetHeightmapPixelError(Terrain t, QualityTerrainLod quality)
	{
		return 0f;
	}

	[Token(Token = "0x6004957")]
	[Address(RVA = "0xD1B480", Offset = "0xD1A280", Length = "0x123")]
	public void OverrideTerrainPixelError(int value)
	{
	}

	[Token(Token = "0x6004958")]
	[Address(RVA = "0xD1B5B0", Offset = "0xD1A3B0", Length = "0x1E4")]
	private void SetTextureStreaming(QualityLevelSettings settings)
	{
	}

	[Token(Token = "0x6004959")]
	[Address(RVA = "0xD1B7A0", Offset = "0xD1A5A0", Length = "0x4C")]
	private static bool UsingOpenGL()
	{
		return false;
	}

	[Token(Token = "0x600495A")]
	[Address(RVA = "0xD1B7F0", Offset = "0xD1A5F0", Length = "0x102")]
	private bool DoesQualityRequireRestart(Quality quality)
	{
		return false;
	}

	[Token(Token = "0x600495B")]
	[Address(RVA = "0x4AF5E0", Offset = "0x4AE3E0", Length = "0x43")]
	public QualitySettingsManager()
	{
	}
}
