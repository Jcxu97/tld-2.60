using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x2000171")]
public class FlyOver : MonoBehaviour
{
	[Token(Token = "0x4000D62")]
	[FieldOffset(Offset = "0x20")]
	public GameObject[] m_FormationPrefabs;

	[Tooltip("Minimum height above player flock will spawn")]
	[Token(Token = "0x4000D63")]
	[FieldOffset(Offset = "0x28")]
	public float m_FormationHeightMin;

	[Tooltip("Maximum height above player flock will spawn")]
	[Token(Token = "0x4000D64")]
	[FieldOffset(Offset = "0x2C")]
	public float m_FormationHeightMax;

	[Tooltip("How far from player flock will spawn")]
	[Token(Token = "0x4000D65")]
	[FieldOffset(Offset = "0x30")]
	public float m_XZDistanceSpawn;

	[Tooltip("Distance from player flock will de-spawn (only when not facing player)")]
	[Token(Token = "0x4000D66")]
	[FieldOffset(Offset = "0x34")]
	public float m_XZDistanceRemove;

	[Tooltip("Minimum speed of flock in meters per second")]
	[Token(Token = "0x4000D67")]
	[FieldOffset(Offset = "0x38")]
	public float m_SpeedMin;

	[Tooltip("Maximum speed of flock in meters per second")]
	[Token(Token = "0x4000D68")]
	[FieldOffset(Offset = "0x3C")]
	public float m_SpeedMax;

	[Token(Token = "0x4000D69")]
	[FieldOffset(Offset = "0x40")]
	public float m_SecondsBetweenFlyoversMin;

	[Token(Token = "0x4000D6A")]
	[FieldOffset(Offset = "0x44")]
	public float m_SecondsBetweenFlyoversMax;

	[Tooltip("Flock clear flight radius for height")]
	[Token(Token = "0x4000D6B")]
	[FieldOffset(Offset = "0x48")]
	public float m_ClearFlightRadius;

	[Tooltip("Clear flight limit ratio before next check")]
	[Range(0f, 1f)]
	[Token(Token = "0x4000D6C")]
	[FieldOffset(Offset = "0x4C")]
	public float m_ClearFlightLimitRatio;

	[Tooltip("Clear flight height transition speed")]
	[Token(Token = "0x4000D6D")]
	[FieldOffset(Offset = "0x50")]
	public float m_HeightTransitionSpeedFactor;

	[Token(Token = "0x4000D6E")]
	[FieldOffset(Offset = "0x58")]
	private GameObject m_FormationInstance;

	[Token(Token = "0x4000D6F")]
	[FieldOffset(Offset = "0x60")]
	private float m_Speed;

	[Token(Token = "0x4000D70")]
	[FieldOffset(Offset = "0x64")]
	private float m_FormationHeight;

	[Token(Token = "0x4000D71")]
	[FieldOffset(Offset = "0x68")]
	private float m_CurrentFlightRadius;

	[Token(Token = "0x4000D72")]
	[FieldOffset(Offset = "0x6C")]
	private uint m_LoopAudioID;

	[Token(Token = "0x4000D73")]
	[FieldOffset(Offset = "0x70")]
	private float m_SecondsBetweenFlyovers;

	[Token(Token = "0x4000D74")]
	[FieldOffset(Offset = "0x74")]
	private float m_SecondsSinceLastFlyover;

	[Token(Token = "0x4000D75")]
	[FieldOffset(Offset = "0x78")]
	private float m_InitialRandomFlockHeight;

	[Token(Token = "0x4000D76")]
	[FieldOffset(Offset = "0x7C")]
	private bool m_DirectionLocked;

	[Token(Token = "0x4000D77")]
	[FieldOffset(Offset = "0x7D")]
	private bool m_StartHasBeenCalled;

	[Token(Token = "0x4000D78")]
	public static bool m_AlwaysSelectFrontPosition;

	[Token(Token = "0x4000D79")]
	public static float m_DebugAngle;

	[Token(Token = "0x4000D7A")]
	private static FlyoverDataProxy m_FlyoverDataProxy;

	[Token(Token = "0x4000D7B")]
	private const float MAX_FLOCK_HEIGHT = 1000f;

	[Token(Token = "0x4000D7C")]
	private const float FLOCK_HEIGHT = 6f;

	[Token(Token = "0x4000D7D")]
	[FieldOffset(Offset = "0x80")]
	private Vector3 m_LastCheckedPoint;

	[Token(Token = "0x4000D7E")]
	[FieldOffset(Offset = "0x8C")]
	private float m_CurrentHeightTransitionSpeedFactor;

	[Token(Token = "0x4000D7F")]
	[FieldOffset(Offset = "0x90")]
	private float m_CurrentHeightTransitionSpeedDamping;

	[Token(Token = "0x4000D80")]
	[FieldOffset(Offset = "0x94")]
	private Quaternion m_TowardPlayerHorizontalOrientation;

	[Token(Token = "0x6000E2D")]
	[Address(RVA = "0x5E9070", Offset = "0x5E7E70", Length = "0x19")]
	public void Start()
	{
	}

	[Token(Token = "0x6000E2E")]
	[Address(RVA = "0x5E9090", Offset = "0x5E7E90", Length = "0xCE")]
	public void Update()
	{
	}

	[Token(Token = "0x6000E2F")]
	[Address(RVA = "0x5E9160", Offset = "0x5E7F60", Length = "0x102")]
	public string Serialize()
	{
		return null;
	}

	[Token(Token = "0x6000E30")]
	[Address(RVA = "0x5E9270", Offset = "0x5E8070", Length = "0xAD")]
	public void Deserialize(string text)
	{
	}

	[Token(Token = "0x6000E31")]
	[Address(RVA = "0x5E9320", Offset = "0x5E8120", Length = "0x7")]
	public void SetFlyoverTimeToMax()
	{
	}

	[Token(Token = "0x6000E32")]
	[Address(RVA = "0x5E9330", Offset = "0x5E8130", Length = "0x136")]
	private bool HasClearFlightPath(Vector3 start, Vector3 dir)
	{
		return false;
	}

	[Token(Token = "0x6000E33")]
	[Address(RVA = "0x5E9470", Offset = "0x5E8270", Length = "0x2E3")]
	public static bool TryGetClearFlightHeight(Vector3 center, float radius, out float height, out float updatedRadius)
	{
		height = default(float);
		updatedRadius = default(float);
		return false;
	}

	[Token(Token = "0x6000E34")]
	[Address(RVA = "0x5E9760", Offset = "0x5E8560", Length = "0x52")]
	public static GameObject GetCurrentFormation()
	{
		return null;
	}

	[Token(Token = "0x6000E35")]
	[Address(RVA = "0x5E97C0", Offset = "0x5E85C0", Length = "0xB16")]
	private void MaybeSpawnFlyover()
	{
	}

	[Token(Token = "0x6000E36")]
	[Address(RVA = "0x5EA2E0", Offset = "0x5E90E0", Length = "0x11DD")]
	private void MoveFlyover()
	{
	}

	[Token(Token = "0x6000E37")]
	[Address(RVA = "0x5EB4C0", Offset = "0x5EA2C0", Length = "0x54C")]
	private void MaybeDestroyFlyover()
	{
	}

	[Token(Token = "0x6000E38")]
	[Address(RVA = "0x5EBA10", Offset = "0x5EA810", Length = "0x206")]
	private bool CanSpawnFlyover()
	{
		return false;
	}

	[Token(Token = "0x6000E39")]
	[Address(RVA = "0x5EBC20", Offset = "0x5EAA20", Length = "0xB1")]
	private void ResetFlyoverTimer()
	{
	}

	[Token(Token = "0x6000E3A")]
	[Address(RVA = "0x5EBCE0", Offset = "0x5EAAE0", Length = "0x4D")]
	public FlyOver()
	{
	}
}
