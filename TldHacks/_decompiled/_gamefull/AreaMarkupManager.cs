using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x2000709")]
public class AreaMarkupManager : MonoBehaviour
{
	[Token(Token = "0x4004AEF")]
	public static float DefaultSearchRadius;

	[Token(Token = "0x4004AF0")]
	[FieldOffset(Offset = "0x20")]
	private List<AreaMarkup> m_AreaMarkupList;

	[Token(Token = "0x4004AF1")]
	[FieldOffset(Offset = "0x28")]
	private Dictionary<MarkupPointGenerator, List<AreaMarkup>> m_AreaMarkupByGenerator;

	[Token(Token = "0x4004AF2")]
	[FieldOffset(Offset = "0x30")]
	private List<AreaMarkup> m_TestAreaMarkupList;

	[Token(Token = "0x4004AF3")]
	[FieldOffset(Offset = "0x38")]
	private List<AreaMarkup> m_TmpRandomAreaMarkupList;

	[Token(Token = "0x4004AF4")]
	[FieldOffset(Offset = "0x40")]
	private List<AreaMarkup> m_RemoveList;

	[Token(Token = "0x4004AF5")]
	[FieldOffset(Offset = "0x48")]
	private Dictionary<AreaMarkup, BaseAi> m_BaseAiReserveByAreaMarkup;

	[Token(Token = "0x4004AF6")]
	[FieldOffset(Offset = "0x50")]
	private Dictionary<BaseAi, AreaMarkup> m_AreaMarkupReserveByBaseAi;

	[Token(Token = "0x6003DB7")]
	[Address(RVA = "0xBF59B0", Offset = "0xBF47B0", Length = "0xC9")]
	private void ReserveAreaMarkup(AreaMarkup am, BaseAi bai)
	{
	}

	[Token(Token = "0x6003DB8")]
	[Address(RVA = "0xBF5A80", Offset = "0xBF4880", Length = "0xB7")]
	private void UnreserveAreaMarkup(AreaMarkup am)
	{
	}

	[Token(Token = "0x6003DB9")]
	[Address(RVA = "0xBF5B40", Offset = "0xBF4940", Length = "0x70")]
	private bool IsAreaMarkupReserved(AreaMarkup am)
	{
		return false;
	}

	[Token(Token = "0x6003DBA")]
	[Address(RVA = "0xBF5BC0", Offset = "0xBF49C0", Length = "0x694")]
	private void MaybeUnreserveAreaMarkups()
	{
	}

	[Token(Token = "0x6003DBB")]
	[Address(RVA = "0xBF6260", Offset = "0xBF5060", Length = "0xD30")]
	private void FindAllAreaMarkupsWithinRadius(MoveAgent agent, Vector3 target, AreaMarkupType amt, float radius, bool ignorePathTest = false)
	{
	}

	[Token(Token = "0x6003DBC")]
	[Address(RVA = "0xBF6FA0", Offset = "0xBF5DA0", Length = "0x2D3")]
	public bool MaybeReserveAreaMarkup(AreaMarkup am, BaseAi bai)
	{
		return false;
	}

	[Token(Token = "0x6003DBD")]
	[Address(RVA = "0xBF7280", Offset = "0xBF6080", Length = "0x2DA")]
	public AreaMarkup GetRandomSpawnAreaMarkupGivenMarkupGenerator(MarkupPointGenerator mpg, string regionName)
	{
		return null;
	}

	[Token(Token = "0x6003DBE")]
	[Address(RVA = "0xBF7560", Offset = "0xBF6360", Length = "0x130")]
	public AreaMarkup GetRandomSpawnAreaMarkupGivenWanderRegion(WanderRegion wanderRegion)
	{
		return null;
	}

	[Token(Token = "0x6003DBF")]
	[Address(RVA = "0xBF76A0", Offset = "0xBF64A0", Length = "0x130")]
	public AreaMarkup GetRandomSpawnAreaMarkupGivenSpawnRegion(SpawnRegion spawnRegion)
	{
		return null;
	}

	[Token(Token = "0x6003DC0")]
	[Address(RVA = "0xBF77E0", Offset = "0xBF65E0", Length = "0x461")]
	public void FindAreaMarkupsOfTypeWithinRadius(MoveAgent agent, Vector3 target, AreaMarkupType amt, float radius, ref List<AreaMarkup> areaMarkupList, bool ignorePathTest = false)
	{
	}

	[Token(Token = "0x6003DC1")]
	[Address(RVA = "0xBF7C50", Offset = "0xBF6A50", Length = "0x556")]
	public AreaMarkup FindRandomAreaMarkupOfTypeWithinRadius(MoveAgent agent, Vector3 target, AreaMarkupType amt, float radius)
	{
		return null;
	}

	[Token(Token = "0x6003DC2")]
	[Address(RVA = "0xBF81B0", Offset = "0xBF6FB0", Length = "0x670")]
	public AreaMarkup FindFarthestAreaMarkupOfTypeWithinRadius(MoveAgent agent, Vector3 target, AreaMarkupType amt, float radius, Vector3 pathDirection)
	{
		return null;
	}

	[Token(Token = "0x6003DC3")]
	[Address(RVA = "0xBF8830", Offset = "0xBF7630", Length = "0x1E2")]
	public void RegisterArea(AreaMarkup am)
	{
	}

	[Token(Token = "0x6003DC4")]
	[Address(RVA = "0xBF8A20", Offset = "0xBF7820", Length = "0x151")]
	public void UnregisterArea(AreaMarkup am)
	{
	}

	[Token(Token = "0x6003DC5")]
	[Address(RVA = "0xBF8B80", Offset = "0xBF7980", Length = "0x7")]
	public void Update()
	{
	}

	[Token(Token = "0x6003DC6")]
	[Address(RVA = "0xBF8B90", Offset = "0xBF7990", Length = "0x40F")]
	public AreaMarkupManager()
	{
	}
}
