using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.Rendering;

[RequireComponent(typeof(UITexture))]
[Token(Token = "0x20005D8")]
public class FogOfWar : MonoBehaviour
{
	[SerializeField]
	[Token(Token = "0x40035ED")]
	[FieldOffset(Offset = "0x20")]
	private Panel_Map m_Map;

	[Token(Token = "0x40035EE")]
	[FieldOffset(Offset = "0x28")]
	public UITexture m_ZoomDetailsUITexture;

	[Header("Resources")]
	[SerializeField]
	[Token(Token = "0x40035EF")]
	[FieldOffset(Offset = "0x30")]
	private Shader m_Shader;

	[SerializeField]
	[Token(Token = "0x40035F0")]
	[FieldOffset(Offset = "0x38")]
	private string m_MapBackgroundFilename;

	[SerializeField]
	[Token(Token = "0x40035F1")]
	[FieldOffset(Offset = "0x40")]
	private string m_MapDetailsFilename;

	[SerializeField]
	[Token(Token = "0x40035F2")]
	[FieldOffset(Offset = "0x48")]
	private string m_HeightmapFilename;

	[Header("Details")]
	[SerializeField]
	[Token(Token = "0x40035F3")]
	[FieldOffset(Offset = "0x50")]
	private Vector2 m_DetailScale;

	[SerializeField]
	[Range(0f, 256f)]
	[Token(Token = "0x40035F4")]
	[FieldOffset(Offset = "0x58")]
	private int m_FadeDistance;

	[Header("Heightmap")]
	[SerializeField]
	[Token(Token = "0x40035F5")]
	[FieldOffset(Offset = "0x5C")]
	private Vector2 m_HeightmapOffset;

	[SerializeField]
	[Token(Token = "0x40035F6")]
	[FieldOffset(Offset = "0x64")]
	private Vector2 m_HeightmapScale;

	[SerializeField]
	[Token(Token = "0x40035F7")]
	[FieldOffset(Offset = "0x6C")]
	private float m_TerrainPositionY;

	[SerializeField]
	[Token(Token = "0x40035F8")]
	[FieldOffset(Offset = "0x70")]
	private float m_TerrainMaxHeight;

	[SerializeField]
	[Range(0.001f, 5f)]
	[Token(Token = "0x40035F9")]
	[FieldOffset(Offset = "0x74")]
	private float m_VisibleHeightScalar;

	[Tooltip("Min/Max height difference of evaluated terrain heightmap from the player to determine if the survey range is extended. Height difference smaller than Min will have no increased range. Range increases linearly between Min and Max. Past Max, there is no additional range increase.")]
	[Token(Token = "0x40035FA")]
	[FieldOffset(Offset = "0x78")]
	public Vector2 m_RangeBoostMinMaxHeight;

	[Tooltip("The percentage to boost the normal survey range at the maximum height difference. A value of 0.5 would meant that at max, the survey range would be boosted to 1.5x the original survey range.")]
	[Token(Token = "0x40035FB")]
	[FieldOffset(Offset = "0x80")]
	public float m_RangeBoostMaxAmount;

	[Header("Reveal")]
	[SerializeField]
	[Token(Token = "0x40035FC")]
	[FieldOffset(Offset = "0x84")]
	private Color m_RevealColor;

	[SerializeField]
	[Token(Token = "0x40035FD")]
	[FieldOffset(Offset = "0x94")]
	private float m_RevealColorFadeTime;

	[Header("Debugging")]
	[SerializeField]
	[Token(Token = "0x40035FE")]
	[FieldOffset(Offset = "0x98")]
	private bool m_RedrawEveryFrame;

	[SerializeField]
	[Token(Token = "0x40035FF")]
	[FieldOffset(Offset = "0x99")]
	private bool m_ViewHeightmap;

	[Token(Token = "0x4003600")]
	[FieldOffset(Offset = "0xA0")]
	private Material m_Material;

	[Token(Token = "0x4003601")]
	[FieldOffset(Offset = "0xA8")]
	private RenderTexture m_RevealedMapTex;

	[Token(Token = "0x4003602")]
	[FieldOffset(Offset = "0xB0")]
	private RenderTargetIdentifier m_RevealedMapTargetId;

	[Token(Token = "0x4003603")]
	[FieldOffset(Offset = "0xD8")]
	private RenderTexture m_RevealedMapZoomDetailsTex;

	[Token(Token = "0x4003604")]
	[FieldOffset(Offset = "0xE0")]
	private RenderTargetIdentifier m_RevealedMapZoomDetailsTargetId;

	[Token(Token = "0x4003605")]
	[FieldOffset(Offset = "0x108")]
	private Texture2D m_MapBackground;

	[Token(Token = "0x4003606")]
	[FieldOffset(Offset = "0x110")]
	private Texture2D m_MapDetails;

	[Token(Token = "0x4003607")]
	[FieldOffset(Offset = "0x118")]
	private Texture2D m_Heightmap;

	[Token(Token = "0x4003608")]
	[FieldOffset(Offset = "0x120")]
	private Dictionary<string, Texture2D> m_VistaRevealMasks;

	[Token(Token = "0x4003609")]
	[FieldOffset(Offset = "0x128")]
	private Camera m_Camera;

	[Token(Token = "0x400360A")]
	[FieldOffset(Offset = "0x130")]
	private CommandBuffer m_CommandBuffer;

	[Token(Token = "0x400360B")]
	[FieldOffset(Offset = "0x138")]
	private CommandBuffer m_CommandBufferZoomDetails;

	[Token(Token = "0x400360C")]
	[FieldOffset(Offset = "0x140")]
	private int m_FrameIdForLastPositionAdded;

	[Token(Token = "0x400360D")]
	[FieldOffset(Offset = "0x144")]
	private int m_FrameId;

	[Token(Token = "0x400360E")]
	[FieldOffset(Offset = "0x148")]
	private bool m_Redraw;

	[Token(Token = "0x400360F")]
	[FieldOffset(Offset = "0x150")]
	private List<DetailSurveyPosition> m_LastKnownSurveyPositions;

	[Token(Token = "0x4003610")]
	[FieldOffset(Offset = "0x158")]
	private List<VistaLocationData> m_LastKnownVistaLocations;

	[Token(Token = "0x4003611")]
	[FieldOffset(Offset = "0x160")]
	private float m_SceneRadius;

	[Token(Token = "0x4003612")]
	[FieldOffset(Offset = "0x164")]
	private float m_MapRadius;

	[Token(Token = "0x4003613")]
	public static readonly int s_HeightMapParamsID;

	[Token(Token = "0x4003614")]
	public static readonly int s_VistaMaskID;

	[Token(Token = "0x4003615")]
	public static readonly int s_VistaOffsetsID;

	[Token(Token = "0x4003616")]
	public static readonly int s_RevealRatioID;

	[Token(Token = "0x4003617")]
	private static readonly int s_DetailSurveyPositionID;

	[Token(Token = "0x4003618")]
	private static readonly int s_HeightMapID;

	[Token(Token = "0x4003619")]
	private static readonly int s_HeightMapScaleOffsetID;

	[Token(Token = "0x400361A")]
	private static readonly int s_FadeDistanceID;

	[Token(Token = "0x400361B")]
	private static readonly int s_RangeBoostParamsID;

	[Token(Token = "0x400361C")]
	private static readonly int s_RevealColorID;

	[Token(Token = "0x400361D")]
	private const int SURVEY_POSITION_PASS = 0;

	[Token(Token = "0x400361E")]
	private const int VISTA_PASS = 1;

	[Token(Token = "0x6002D53")]
	[Address(RVA = "0x40E120", Offset = "0x40CF20", Length = "0x52")]
	public void SetOwner(Panel_Map map)
	{
	}

	[Token(Token = "0x6002D54")]
	[Address(RVA = "0x946920", Offset = "0x945720", Length = "0x1D7")]
	private bool MaybeLoadTextureAsset(string filename, ref Texture2D texture)
	{
		return false;
	}

	[Token(Token = "0x6002D55")]
	[Address(RVA = "0x946B00", Offset = "0x945900", Length = "0xB51")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6002D56")]
	[Address(RVA = "0x947660", Offset = "0x946460", Length = "0xB1D")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6002D57")]
	[Address(RVA = "0x948180", Offset = "0x946F80", Length = "0x10E")]
	private void Start()
	{
	}

	[Token(Token = "0x6002D58")]
	[Address(RVA = "0x948290", Offset = "0x947090", Length = "0x55A")]
	private void Update()
	{
	}

	[Token(Token = "0x6002D59")]
	[Address(RVA = "0x9487F0", Offset = "0x9475F0", Length = "0xFE")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x6002D5A")]
	[Address(RVA = "0x9488F0", Offset = "0x9476F0", Length = "0x5D")]
	public void ClearLastKnownPositionsList()
	{
	}

	[Token(Token = "0x6002D5B")]
	[Address(RVA = "0x948950", Offset = "0x947750", Length = "0x525")]
	public void ProcessList(List<DetailSurveyPosition> dsps, List<VistaLocationData> vistaLocations, float sceneRadius, float mapRadius)
	{
	}

	[Token(Token = "0x6002D5C")]
	[Address(RVA = "0x948E80", Offset = "0x947C80", Length = "0xB8B")]
	private void RefreshCommandBuffer(CommandBuffer commandBuffer, RenderTargetIdentifier renderTargetId, Texture2D map)
	{
	}

	[Token(Token = "0x6002D5D")]
	[Address(RVA = "0x949A10", Offset = "0x948810", Length = "0x200")]
	private void UpdateShaderConstants()
	{
	}

	[Token(Token = "0x6002D5E")]
	[Address(RVA = "0x949C20", Offset = "0x948A20", Length = "0x168")]
	public FogOfWar()
	{
	}
}
