using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x2000367")]
public class BloodTrail : MonoBehaviour
{
	[Token(Token = "0x4001DEA")]
	[FieldOffset(Offset = "0x20")]
	public float m_BloodDropDistanceMin;

	[Token(Token = "0x4001DEB")]
	[FieldOffset(Offset = "0x24")]
	public float m_BloodDropDistanceMax;

	[Token(Token = "0x4001DEC")]
	[FieldOffset(Offset = "0x28")]
	public float m_BloodDropDistanceSlowMin;

	[Token(Token = "0x4001DED")]
	[FieldOffset(Offset = "0x2C")]
	public float m_BloodDropDistanceSlowMax;

	[Token(Token = "0x4001DEE")]
	[FieldOffset(Offset = "0x30")]
	public float m_MinutesToReachSlowBloodLoss;

	[Token(Token = "0x4001DEF")]
	[FieldOffset(Offset = "0x34")]
	public Vector3 m_DecalProjectorScale;

	[Token(Token = "0x4001DF0")]
	[FieldOffset(Offset = "0x40")]
	public Vector3 m_StainOffset;

	[HideInInspector]
	[Token(Token = "0x4001DF1")]
	[FieldOffset(Offset = "0x4C")]
	public bool m_FirstBleedingDrop;

	[Token(Token = "0x4001DF2")]
	[FieldOffset(Offset = "0x50")]
	private float m_DistanceForNextBloodDrop;

	[Token(Token = "0x4001DF3")]
	[FieldOffset(Offset = "0x54")]
	private Vector3 m_LastBloodDropPos;

	[Token(Token = "0x4001DF4")]
	[FieldOffset(Offset = "0x60")]
	private float m_DistanceMoved;

	[Token(Token = "0x4001DF5")]
	[FieldOffset(Offset = "0x64")]
	private int m_UvRectangleIndexBloodLarge;

	[Token(Token = "0x4001DF6")]
	[FieldOffset(Offset = "0x68")]
	private int m_UvRectangleIndexBloodSmall;

	[Token(Token = "0x4001DF7")]
	[FieldOffset(Offset = "0x6C")]
	private int m_UvRectangleIndexBloodStain;

	[Token(Token = "0x4001DF8")]
	[FieldOffset(Offset = "0x70")]
	private bool m_FirstHarvest;

	[Token(Token = "0x4001DF9")]
	[FieldOffset(Offset = "0x78")]
	private BaseAi m_BaseAi;

	[Token(Token = "0x4001DFA")]
	[FieldOffset(Offset = "0x80")]
	private int m_DropCount;

	[Token(Token = "0x6001B93")]
	[Address(RVA = "0x763140", Offset = "0x761F40", Length = "0x9")]
	public void Awake()
	{
	}

	[Token(Token = "0x6001B94")]
	[Address(RVA = "0x763150", Offset = "0x761F50", Length = "0xC3")]
	public void Start()
	{
	}

	[Token(Token = "0x6001B95")]
	[Address(RVA = "0x763220", Offset = "0x762020", Length = "0x178")]
	private void MaybeInitializeBloodDecalIndexes()
	{
	}

	[Token(Token = "0x6001B96")]
	[Address(RVA = "0x7633A0", Offset = "0x7621A0", Length = "0x4F8")]
	public void AddMoveDistance(float dist)
	{
	}

	[Token(Token = "0x6001B97")]
	[Address(RVA = "0x7638A0", Offset = "0x7626A0", Length = "0x69E")]
	private void LeaveBloodDrop(Vector3 pos)
	{
	}

	[Token(Token = "0x6001B98")]
	[Address(RVA = "0x763F40", Offset = "0x762D40", Length = "0x4EF")]
	public void LeaveBloodStain(Vector3 pos, float scaleMin, float scaleMax)
	{
	}

	[Token(Token = "0x6001B99")]
	[Address(RVA = "0x764430", Offset = "0x763230", Length = "0x6EF")]
	public void LeaveStruggleBloodStain()
	{
	}

	[Token(Token = "0x6001B9A")]
	[Address(RVA = "0x764B20", Offset = "0x763920", Length = "0x6FB")]
	public void LeaveHarvestBloodStain()
	{
	}

	[Token(Token = "0x6001B9B")]
	[Address(RVA = "0x765220", Offset = "0x764020", Length = "0x6D9")]
	private void LeaveBloodCluster(Vector3 pos, int dropCount)
	{
	}

	[Token(Token = "0x6001B9C")]
	[Address(RVA = "0x765900", Offset = "0x764700", Length = "0xEC")]
	private bool ShouldLeaveBloodDrop(Vector3 pos)
	{
		return false;
	}

	[Token(Token = "0x6001B9D")]
	[Address(RVA = "0x7659F0", Offset = "0x7647F0", Length = "0x163")]
	private DecalProjectorType GetDecalProjectorType()
	{
		return default(DecalProjectorType);
	}

	[Token(Token = "0x6001B9E")]
	[Address(RVA = "0x765B60", Offset = "0x764960", Length = "0x52")]
	public BloodTrail()
	{
	}
}
