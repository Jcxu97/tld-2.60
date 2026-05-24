using Cpp2ILInjected;
using TLD.Gear;
using UnityEngine;

[Token(Token = "0x20004B4")]
public class Inspect : MonoBehaviour
{
	[Token(Token = "0x20004B5")]
	private class InspectSaveData
	{
		[Token(Token = "0x4002B70")]
		[FieldOffset(Offset = "0x10")]
		public bool m_SkipInspectVO;

		[Token(Token = "0x6002406")]
		[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
		public InspectSaveData()
		{
		}
	}

	[Token(Token = "0x4002B62")]
	[FieldOffset(Offset = "0x20")]
	public GameObject m_InspectModeMesh;

	[Token(Token = "0x4002B63")]
	[FieldOffset(Offset = "0x28")]
	public GameObject m_NormalMesh;

	[Token(Token = "0x4002B64")]
	[FieldOffset(Offset = "0x30")]
	public bool m_IgnoreMouse;

	[Token(Token = "0x4002B65")]
	[FieldOffset(Offset = "0x34")]
	public float m_DistanceFromCamera;

	[Token(Token = "0x4002B66")]
	[FieldOffset(Offset = "0x38")]
	public bool m_OverrideDepthOfFieldFocalDistance;

	[Token(Token = "0x4002B67")]
	[FieldOffset(Offset = "0x3C")]
	public float m_DepthOfFieldFocalDistance;

	[Token(Token = "0x4002B68")]
	[FieldOffset(Offset = "0x40")]
	public Vector3 m_Offset;

	[Token(Token = "0x4002B69")]
	[FieldOffset(Offset = "0x4C")]
	public Vector3 m_Angles;

	[Token(Token = "0x4002B6A")]
	[FieldOffset(Offset = "0x58")]
	public Vector3 m_Scale;

	[Tooltip("Maximum random angle +//- from the default to apply.")]
	[Token(Token = "0x4002B6B")]
	[FieldOffset(Offset = "0x64")]
	public Vector3 m_RndAngles;

	[Tooltip("Leave blank to use the general VO for item inspect")]
	[Token(Token = "0x4002B6C")]
	[FieldOffset(Offset = "0x70")]
	public string m_OverrideInspectVO;

	[Token(Token = "0x4002B6D")]
	[FieldOffset(Offset = "0x78")]
	public bool m_SkipInspectVO;

	[Token(Token = "0x4002B6E")]
	[FieldOffset(Offset = "0x7C")]
	private uint m_Urgency;

	[Token(Token = "0x4002B6F")]
	[FieldOffset(Offset = "0x80")]
	private bool m_DidSetUrgency;

	[Token(Token = "0x6002400")]
	[Address(RVA = "0x85F6F0", Offset = "0x85E4F0", Length = "0xEFB")]
	public uint GetUrgency()
	{
		return 0u;
	}

	[Token(Token = "0x6002401")]
	[Address(RVA = "0x8605F0", Offset = "0x85F3F0", Length = "0x88")]
	public void Deserialize(string serialized)
	{
	}

	[Token(Token = "0x6002402")]
	[Address(RVA = "0x860680", Offset = "0x85F480", Length = "0xBE")]
	public string Serialize()
	{
		return null;
	}

	[Token(Token = "0x6002403")]
	[Address(RVA = "0x860740", Offset = "0x85F540", Length = "0x1C")]
	private void SetUrgencyIfHigher(uint newUrgency)
	{
	}

	[Token(Token = "0x6002404")]
	[Address(RVA = "0x860760", Offset = "0x85F560", Length = "0x287")]
	private static bool IsWater(LiquidType liquidType)
	{
		return false;
	}

	[Token(Token = "0x6002405")]
	[Address(RVA = "0x8609F0", Offset = "0x85F7F0", Length = "0x9F")]
	public Inspect()
	{
	}
}
