using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x2000781")]
public class LightingManager : MonoBehaviour
{
	[Token(Token = "0x4005071")]
	private static List<LightTracking> m_Lights;

	[Token(Token = "0x4005072")]
	private static List<LightTracking> m_LightsForFp;

	[Token(Token = "0x4005073")]
	private static List<LightTracking> m_FpsLights;

	[Token(Token = "0x4005074")]
	private static List<LightTracking> m_SelectedWorldLightsForFp;

	[Token(Token = "0x4005075")]
	private static bool m_LevelLoadComplete;

	[Token(Token = "0x4005076")]
	private static string[] m_NonStaticComponentList;

	[Token(Token = "0x4005077")]
	public static float m_LightIntensityOnPlayer;

	[Token(Token = "0x4005078")]
	public static Color m_LightColorOnPlayer;

	[Token(Token = "0x4005079")]
	private static readonly int m_LightingStrengthShaderId;

	[Token(Token = "0x400507A")]
	private static readonly Color m_DefaultLightingStrength;

	[Token(Token = "0x400507B")]
	public static bool s_FilterWorldLightForFP;

	[Token(Token = "0x400507C")]
	public static bool s_DebugFPLights;

	[Token(Token = "0x400507D")]
	[FieldOffset(Offset = "0x20")]
	private Vector3 m_LastPlayerPos;

	[Token(Token = "0x400507E")]
	[FieldOffset(Offset = "0x2C")]
	private float m_SqrRefreshLightsForFpThreshold;

	[Token(Token = "0x400507F")]
	[FieldOffset(Offset = "0x30")]
	private float m_UpdateLightForFpDeltaTime;

	[Token(Token = "0x4005080")]
	[FieldOffset(Offset = "0x34")]
	private float m_UpdateLightForFpAccumulatedDeltaTime;

	[Token(Token = "0x4005081")]
	[FieldOffset(Offset = "0x38")]
	private float m_SqrPlayerWithItemRadius;

	[SerializeField]
	[Token(Token = "0x4005082")]
	[FieldOffset(Offset = "0x40")]
	private string[] m_NonStaticComponents;

	[Token(Token = "0x4005083")]
	private static int m_LightsForFpCount;

	[Token(Token = "0x4005084")]
	private static int m_LightCount;

	[Token(Token = "0x4005085")]
	private static int m_SelectedWorldLightsForFpCount;

	[Token(Token = "0x6004660")]
	[Address(RVA = "0xCA2FF0", Offset = "0xCA1DF0", Length = "0x54")]
	private void Start()
	{
	}

	[Token(Token = "0x6004661")]
	[Address(RVA = "0xCA3050", Offset = "0xCA1E50", Length = "0xB7")]
	private void Awake()
	{
	}

	[Token(Token = "0x6004662")]
	[Address(RVA = "0xCA3110", Offset = "0xCA1F10", Length = "0x6B1")]
	private void Update()
	{
	}

	[Token(Token = "0x6004663")]
	[Address(RVA = "0xCA37D0", Offset = "0xCA25D0", Length = "0x3F0")]
	private void UpdateLightsForFP_Part1(Vector3 playerPos)
	{
	}

	[Token(Token = "0x6004664")]
	[Address(RVA = "0xCA3BD0", Offset = "0xCA29D0", Length = "0x346")]
	private void UpdateLightsForFP_Part2(Vector3 playerPos)
	{
	}

	[Token(Token = "0x6004665")]
	[Address(RVA = "0xCA3F20", Offset = "0xCA2D20", Length = "0x4DE")]
	public static void Add(LightTracking light)
	{
	}

	[Token(Token = "0x6004666")]
	[Address(RVA = "0xCA4400", Offset = "0xCA3200", Length = "0x318")]
	public static void Remove(LightTracking light)
	{
	}

	[Token(Token = "0x6004667")]
	[Address(RVA = "0xCA4720", Offset = "0xCA3520", Length = "0x14C")]
	public static void RemoveAll()
	{
	}

	[Token(Token = "0x6004668")]
	[Address(RVA = "0xCA4870", Offset = "0xCA3670", Length = "0x347")]
	public static void OnLevelLoadComplete()
	{
	}

	[Token(Token = "0x6004669")]
	[Address(RVA = "0xCA4BC0", Offset = "0xCA39C0", Length = "0x307")]
	public static void TransformLightPositions(Transform t)
	{
	}

	[Token(Token = "0x600466A")]
	[Address(RVA = "0xCA4ED0", Offset = "0xCA3CD0", Length = "0x8EF")]
	public static void InverseTransformLightPositions(Transform t)
	{
	}

	[Token(Token = "0x600466B")]
	[Address(RVA = "0xCA57C0", Offset = "0xCA45C0", Length = "0x47F")]
	public static void TransformFpsLightPositions(Transform t)
	{
	}

	[Token(Token = "0x600466C")]
	[Address(RVA = "0xCA5C40", Offset = "0xCA4A40", Length = "0x1B5")]
	public static void InverseTransformFpsLightPositions(Transform t)
	{
	}

	[Token(Token = "0x600466D")]
	[Address(RVA = "0xCA5E00", Offset = "0xCA4C00", Length = "0xDA")]
	public static void SetLightingStrength(Color value)
	{
	}

	[Token(Token = "0x600466E")]
	[Address(RVA = "0xCA5EE0", Offset = "0xCA4CE0", Length = "0xF2")]
	public static void SetLightingStrengthDefault()
	{
	}

	[Token(Token = "0x600466F")]
	[Address(RVA = "0xCA5FE0", Offset = "0xCA4DE0", Length = "0x14B")]
	public static string GetDebugText()
	{
		return null;
	}

	[Token(Token = "0x6004670")]
	[Address(RVA = "0xCA6130", Offset = "0xCA4F30", Length = "0x58")]
	public LightingManager()
	{
	}
}
