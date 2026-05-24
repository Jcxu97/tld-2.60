using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x20003A7")]
public class FootstepTrailManager : MonoBehaviour
{
	[Token(Token = "0x400208F")]
	[FieldOffset(Offset = "0x20")]
	public bool m_DebugShowBounds;

	[Token(Token = "0x4002090")]
	[FieldOffset(Offset = "0x24")]
	public float m_CameraCaptureBoundsSize;

	[Token(Token = "0x4002091")]
	[FieldOffset(Offset = "0x28")]
	public float m_CameraCaptureHideDistance;

	[Token(Token = "0x4002092")]
	[FieldOffset(Offset = "0x2C")]
	public float m_DepthNoiseScalar;

	[Range(0f, 3f)]
	[Token(Token = "0x4002093")]
	[FieldOffset(Offset = "0x30")]
	public float m_GlobalDepthScalar;

	[Range(0f, 1f)]
	[Token(Token = "0x4002094")]
	[FieldOffset(Offset = "0x34")]
	public float m_MinGroundNormalYForPlacement;

	[Token(Token = "0x4002095")]
	[FieldOffset(Offset = "0x38")]
	public SnowImprintDef[] m_ImprintDefs;

	[HideInInspector]
	[Token(Token = "0x4002096")]
	[FieldOffset(Offset = "0x40")]
	public FootstepTrail m_ActivePlayerTrail;

	[HideInInspector]
	[Token(Token = "0x4002097")]
	[FieldOffset(Offset = "0x48")]
	public float m_MinInitialSnowDepthOnDeserialize;

	[Token(Token = "0x4002098")]
	[FieldOffset(Offset = "0x50")]
	private OctreeBounds<FootstepGroup> m_FootstepGroupOctree;

	[Token(Token = "0x4002099")]
	[FieldOffset(Offset = "0x58")]
	private List<FootstepTrail> m_Trails;

	[Token(Token = "0x400209A")]
	[FieldOffset(Offset = "0x60")]
	private List<FootstepGroup>[] m_CaptureLists;

	[Token(Token = "0x400209B")]
	[FieldOffset(Offset = "0x68")]
	private List<FootstepGroup> m_OpenFootstepGroups;

	[Token(Token = "0x400209C")]
	[FieldOffset(Offset = "0x70")]
	private int m_CaptureTick;

	[Token(Token = "0x400209D")]
	[FieldOffset(Offset = "0x78")]
	private FootStepGroupDistanceComparer m_DistanceComparer;

	[Token(Token = "0x400209E")]
	[FieldOffset(Offset = "0x80")]
	private int m_TrailPurgeIndex;

	[Token(Token = "0x400209F")]
	[FieldOffset(Offset = "0x84")]
	private bool m_AwakeHasBeenCalled;

	[Token(Token = "0x40020A0")]
	public static FootstepTrailManager m_Instance;

	[Token(Token = "0x40020A1")]
	private const string SNOW_TAG = "Snow";

	[Token(Token = "0x40020A2")]
	private static FootstepTrailManagerSaveDataProxy m_FootstepTrailManagerSaveDataProxy;

	[Token(Token = "0x6001CE6")]
	[Address(RVA = "0x78DA50", Offset = "0x78C850", Length = "0x4F9")]
	public void Awake()
	{
	}

	[Token(Token = "0x6001CE7")]
	[Address(RVA = "0x78DF50", Offset = "0x78CD50", Length = "0x2B")]
	public SnowImprintDef GetImprintDef(SnowImprintType type)
	{
		return null;
	}

	[Token(Token = "0x6001CE8")]
	[Address(RVA = "0x78DF80", Offset = "0x78CD80", Length = "0x15F")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6001CE9")]
	[Address(RVA = "0x78E0E0", Offset = "0x78CEE0", Length = "0xB1")]
	public void AddFootstepTrail(FootstepTrail fst, bool isPlayerTrail = false)
	{
	}

	[Token(Token = "0x6001CEA")]
	[Address(RVA = "0x78E1A0", Offset = "0x78CFA0", Length = "0xA9")]
	public void OnAddFootstepGroup(FootstepGroup group)
	{
	}

	[Token(Token = "0x6001CEB")]
	[Address(RVA = "0x78E250", Offset = "0x78D050", Length = "0xA0")]
	public void OnCloseFootstepGroup(FootstepGroup group)
	{
	}

	[Token(Token = "0x6001CEC")]
	[Address(RVA = "0x78E300", Offset = "0x78D100", Length = "0x96")]
	public void OnRemoveFootstepGroup(FootstepGroup group)
	{
	}

	[Token(Token = "0x6001CED")]
	[Address(RVA = "0x78E3A0", Offset = "0x78D1A0", Length = "0x26E")]
	public string Serialize()
	{
		return null;
	}

	[Token(Token = "0x6001CEE")]
	[Address(RVA = "0x78E610", Offset = "0x78D410", Length = "0x38B")]
	public void Deserialize(string text)
	{
	}

	[Token(Token = "0x6001CEF")]
	[Address(RVA = "0x78E9A0", Offset = "0x78D7A0", Length = "0x9C")]
	public void AddPlayerFootstep(Vector3 ownerPos, Vector3 pos, Vector3 groundNormal, float yRotation, bool flip, float forceDeepFrac)
	{
	}

	[Token(Token = "0x6001CF0")]
	[Address(RVA = "0x78EA40", Offset = "0x78D840", Length = "0x12")]
	public void OnPlayerEnterSnowDepthTrigger(SnowDepth sd)
	{
	}

	[Token(Token = "0x6001CF1")]
	[Address(RVA = "0x78EA60", Offset = "0x78D860", Length = "0x12")]
	public void OnPlayerExitSnowDepthTrigger(SnowDepth sd)
	{
	}

	[Token(Token = "0x6001CF2")]
	[Address(RVA = "0x78EA80", Offset = "0x78D880", Length = "0x5FB")]
	public bool IsFootprintPositionValid(Vector3 heelPos, Vector3 offset, float footLen, out Vector3 point, out Vector3 normal, string tag)
	{
		point = default(Vector3);
		normal = default(Vector3);
		return false;
	}

	[Token(Token = "0x6001CF3")]
	[Address(RVA = "0x78F080", Offset = "0x78DE80", Length = "0xBE")]
	public bool IsFootprintPositionValid(Vector3 heelPos, Vector3 offset, float footLen, out Vector3 point, out Vector3 normal)
	{
		point = default(Vector3);
		normal = default(Vector3);
		return false;
	}

	[Token(Token = "0x6001CF4")]
	[Address(RVA = "0x78F140", Offset = "0x78DF40", Length = "0xBF")]
	public void OnQualityChange(QualityFootprints quality)
	{
	}

	[Token(Token = "0x6001CF5")]
	[Address(RVA = "0x78F200", Offset = "0x78E000", Length = "0xD09")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x6001CF6")]
	[Address(RVA = "0x4AF5E0", Offset = "0x4AE3E0", Length = "0x43")]
	public FootstepTrailManager()
	{
	}
}
