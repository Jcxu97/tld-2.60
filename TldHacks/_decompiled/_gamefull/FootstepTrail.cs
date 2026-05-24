using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x20003A6")]
public class FootstepTrail
{
	[Token(Token = "0x400207E")]
	private const float MIN_FADED_DEPTH_SCALAR = 0.025f;

	[Token(Token = "0x400207F")]
	[FieldOffset(Offset = "0x10")]
	public bool m_IsOpen;

	[Token(Token = "0x4002080")]
	[FieldOffset(Offset = "0x14")]
	public FootstepTrailType m_TrailType;

	[Token(Token = "0x4002081")]
	[FieldOffset(Offset = "0x18")]
	public SnowImprintType m_ImprintType;

	[Token(Token = "0x4002082")]
	[FieldOffset(Offset = "0x20")]
	public SnowImprintDef m_ImprintDef;

	[Token(Token = "0x4002083")]
	[FieldOffset(Offset = "0x28")]
	public SnowImprintQualitySettings m_ImprintQualityDef;

	[Token(Token = "0x4002084")]
	[FieldOffset(Offset = "0x30")]
	private Stack<int> m_FootstepFreeBlocks;

	[Token(Token = "0x4002085")]
	[FieldOffset(Offset = "0x38")]
	private List<FootstepGroup> m_FootstepGroups;

	[Token(Token = "0x4002086")]
	[FieldOffset(Offset = "0x40")]
	private List<SnowImprint> m_Footsteps;

	[Token(Token = "0x4002087")]
	[FieldOffset(Offset = "0x48")]
	private bool m_RequireFadeIn;

	[Token(Token = "0x4002088")]
	[FieldOffset(Offset = "0x4C")]
	private Vector3 m_FadingInBasePos;

	[Token(Token = "0x4002089")]
	[FieldOffset(Offset = "0x58")]
	private bool m_FadingIn;

	[HideInInspector]
	[Token(Token = "0x400208A")]
	[FieldOffset(Offset = "0x60")]
	public List<SnowDepthTriggerRecord> m_SnowDepthTriggerRecords;

	[HideInInspector]
	[Token(Token = "0x400208B")]
	[FieldOffset(Offset = "0x68")]
	public float m_LastFootprintDepthFrac;

	[HideInInspector]
	[Token(Token = "0x400208C")]
	[FieldOffset(Offset = "0x6C")]
	public float m_LastFootprintDepth;

	[Token(Token = "0x400208D")]
	private static FootstepTrailSaveDataProxy m_FootstepTrailSaveDataProxy;

	[Token(Token = "0x400208E")]
	private static FootstepGroupSaveDataProxy m_FootstepGroupSaveDataProxy;

	[Token(Token = "0x1700020C")]
	public List<SnowImprint> Footsteps
	{
		[Token(Token = "0x6001CCC")]
		[Address(RVA = "0x4A7D60", Offset = "0x4A6B60", Length = "0x5")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700020D")]
	public int NumGroups
	{
		[Token(Token = "0x6001CCD")]
		[Address(RVA = "0x78A560", Offset = "0x789360", Length = "0x41")]
		get
		{
			return 0;
		}
	}

	[Token(Token = "0x6001CCE")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public FootstepTrail()
	{
	}

	[Token(Token = "0x6001CCF")]
	[Address(RVA = "0x78A5B0", Offset = "0x7893B0", Length = "0x8")]
	public FootstepTrail(FootstepTrailType trailType, SnowImprintType imprintType)
	{
	}

	[Token(Token = "0x6001CD0")]
	[Address(RVA = "0x78A5C0", Offset = "0x7893C0", Length = "0x33E")]
	public void Initialize(FootstepTrailType trailType, SnowImprintType imprintType)
	{
	}

	[Token(Token = "0x6001CD1")]
	[Address(RVA = "0x4AD480", Offset = "0x4AC280", Length = "0x5")]
	public FootstepTrail(FootstepTrailSaveDataProxy sdp)
	{
	}

	[Token(Token = "0x6001CD2")]
	[Address(RVA = "0x78A900", Offset = "0x789700", Length = "0xBE")]
	public void Reset()
	{
	}

	[Token(Token = "0x6001CD3")]
	[Address(RVA = "0x78A9C0", Offset = "0x7897C0", Length = "0x7")]
	public void Destroy()
	{
	}

	[Token(Token = "0x6001CD4")]
	[Address(RVA = "0x78A9D0", Offset = "0x7897D0", Length = "0x9D")]
	public void Close()
	{
	}

	[Token(Token = "0x6001CD5")]
	[Address(RVA = "0x78AA70", Offset = "0x789870", Length = "0x274")]
	public void OnQualityChange(QualityFootprints quality)
	{
	}

	[Token(Token = "0x6001CD6")]
	[Address(RVA = "0x78AD00", Offset = "0x789B00", Length = "0xE8")]
	public bool ProcessPurge(int currCaptureTick, float currSnowDepth)
	{
		return false;
	}

	[Token(Token = "0x6001CD7")]
	[Address(RVA = "0x78ADF0", Offset = "0x789BF0", Length = "0x65B")]
	public void OnOwnerEnterSnowDepthTrigger(SnowDepth sd)
	{
	}

	[Token(Token = "0x6001CD8")]
	[Address(RVA = "0x78B450", Offset = "0x78A250", Length = "0x1E9")]
	public void OnOwnerExitSnowDepthTrigger(SnowDepth sd)
	{
	}

	[Token(Token = "0x6001CD9")]
	[Address(RVA = "0x78B640", Offset = "0x78A440", Length = "0x660")]
	public void AddFootstep(Vector3 ownerPos, Vector3 pos, Vector3 groundNormal, float yRotation, bool flip, int variantIndex, float forceDeepFrac = 0f)
	{
	}

	[Token(Token = "0x6001CDA")]
	[Address(RVA = "0x78BCB0", Offset = "0x78AAB0", Length = "0x696")]
	public void FadeFootprintsAtTrailEnd(bool atStart)
	{
	}

	[Token(Token = "0x6001CDB")]
	[Address(RVA = "0x78C350", Offset = "0x78B150", Length = "0x348")]
	public float GetFootprintDepth(Vector3 pos, Vector3 groundNormal, float forceDeepFrac)
	{
		return 0f;
	}

	[Token(Token = "0x6001CDC")]
	[Address(RVA = "0x78C6A0", Offset = "0x78B4A0", Length = "0x95")]
	public FootstepGroup GetOpenFootstepGroup()
	{
		return null;
	}

	[Token(Token = "0x6001CDD")]
	[Address(RVA = "0x78C740", Offset = "0x78B540", Length = "0x12E")]
	public int ReserveFootstepBlock()
	{
		return 0;
	}

	[Token(Token = "0x6001CDE")]
	[Address(RVA = "0x78C870", Offset = "0x78B670", Length = "0x92")]
	public void ReturnFootstepBlock(int baseIndex)
	{
	}

	[Token(Token = "0x6001CDF")]
	[Address(RVA = "0x78C910", Offset = "0x78B710", Length = "0x58")]
	public void RemoveFootstepGroup(FootstepGroup fg)
	{
	}

	[Token(Token = "0x6001CE0")]
	[Address(RVA = "0x78C970", Offset = "0x78B770", Length = "0x5D4")]
	public string Serialize()
	{
		return null;
	}

	[Token(Token = "0x6001CE1")]
	[Address(RVA = "0x78CF50", Offset = "0x78BD50", Length = "0x33C")]
	public void Deserialize(string text)
	{
	}

	[Token(Token = "0x6001CE2")]
	[Address(RVA = "0x78D290", Offset = "0x78C090", Length = "0xC1")]
	public void AdjustSnowDepthRecords(float baseDepth)
	{
	}

	[Token(Token = "0x6001CE3")]
	[Address(RVA = "0x78D360", Offset = "0x78C160", Length = "0x9C")]
	public int GetNumFootsteps()
	{
		return 0;
	}

	[Token(Token = "0x6001CE4")]
	[Address(RVA = "0x78D400", Offset = "0x78C200", Length = "0xA5")]
	public bool IsVisible()
	{
		return false;
	}
}
