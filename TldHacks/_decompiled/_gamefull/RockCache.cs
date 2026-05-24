using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using TLD.UI.Generics;
using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(NavMeshObstacle))]
[RequireComponent(typeof(Container))]
[RequireComponent(typeof(MapDetail))]
[RequireComponent(typeof(MeshCollider))]
[RequireComponent(typeof(BoxCollider))]
[Token(Token = "0x20005A9")]
public class RockCache : MonoBehaviour
{
	[Token(Token = "0x400344A")]
	private const string VIS_POINT_NAME = "VisPoint";

	[AutoComponent(ComponentRequirement.Required)]
	[Token(Token = "0x400344B")]
	[FieldOffset(Offset = "0x20")]
	public NavMeshObstacle m_NavmeshCut;

	[AutoComponent(ComponentRequirement.Required)]
	[SerializeField]
	[Token(Token = "0x400344C")]
	[FieldOffset(Offset = "0x28")]
	protected Container m_Container;

	[AutoComponent(ComponentRequirement.Required)]
	[SerializeField]
	[Token(Token = "0x400344D")]
	[FieldOffset(Offset = "0x30")]
	protected MapDetail m_MapDetail;

	[Header("Display Names")]
	[Token(Token = "0x400344E")]
	[FieldOffset(Offset = "0x38")]
	public LocalizedString m_LocalizedDisplayName;

	[Header("Build")]
	[Token(Token = "0x400344F")]
	[FieldOffset(Offset = "0x40")]
	public int m_BuildRealSecondsElapsed;

	[Token(Token = "0x4003450")]
	[FieldOffset(Offset = "0x44")]
	public int m_MinutesToBuild;

	[Token(Token = "0x4003451")]
	[FieldOffset(Offset = "0x48")]
	public GearItem m_RocksPrefab;

	[Token(Token = "0x4003452")]
	[FieldOffset(Offset = "0x50")]
	public int m_NumRocksToBuild;

	[Token(Token = "0x4003453")]
	[FieldOffset(Offset = "0x58")]
	public GearItem m_SticksPrefab;

	[Token(Token = "0x4003454")]
	[FieldOffset(Offset = "0x60")]
	public int m_NumSticksToBuild;

	[Token(Token = "0x4003455")]
	[FieldOffset(Offset = "0x68")]
	public string m_BuildAudioName;

	[Token(Token = "0x4003456")]
	[FieldOffset(Offset = "0x70")]
	public string m_BuildIconName;

	[Header("Label")]
	[Token(Token = "0x4003457")]
	[FieldOffset(Offset = "0x78")]
	public string m_LabelIconName;

	[Token(Token = "0x4003458")]
	[FieldOffset(Offset = "0x80")]
	public LocalizedString m_InteractProgressDisplayName;

	[Header("Dismantle")]
	[Token(Token = "0x4003459")]
	[FieldOffset(Offset = "0x88")]
	public int m_DismantleRealSecondsElapsed;

	[Token(Token = "0x400345A")]
	[FieldOffset(Offset = "0x8C")]
	public int m_MinutesToDismantle;

	[Token(Token = "0x400345B")]
	[FieldOffset(Offset = "0x90")]
	public int m_NumRocksFromDismantle;

	[Token(Token = "0x400345C")]
	[FieldOffset(Offset = "0x94")]
	public int m_NumSticksFromDismantle;

	[Token(Token = "0x400345D")]
	[FieldOffset(Offset = "0x98")]
	public string m_DismantleAudioName;

	[Token(Token = "0x400345E")]
	[FieldOffset(Offset = "0xA0")]
	public string m_DismantleIconName;

	[Token(Token = "0x400345F")]
	[FieldOffset(Offset = "0xA8")]
	public bool m_OnlyAllowOpen;

	[Token(Token = "0x4003460")]
	[FieldOffset(Offset = "0xAC")]
	public float m_OpenTimeSeconds;

	[Header("Placement")]
	[SerializeField]
	[Token(Token = "0x4003461")]
	[FieldOffset(Offset = "0xB0")]
	private float m_VisCheckLength;

	[Header("Panel References")]
	[SerializeField]
	[Token(Token = "0x4003462")]
	[FieldOffset(Offset = "0xB8")]
	private PanelReference<Panel_Confirmation> m_Confirmation;

	[SerializeField]
	[Token(Token = "0x4003463")]
	[FieldOffset(Offset = "0xC0")]
	private PanelReference<Panel_GenericProgressBar> m_GenericProgressBar;

	[SerializeField]
	[Token(Token = "0x4003464")]
	[FieldOffset(Offset = "0xC8")]
	private PanelReference<Panel_Map> m_Map;

	[NonSerialized]
	[Token(Token = "0x4003465")]
	[FieldOffset(Offset = "0xD0")]
	public string m_RegionName;

	[NonSerialized]
	[Token(Token = "0x4003466")]
	[FieldOffset(Offset = "0xD8")]
	public string m_SceneName;

	[Token(Token = "0x4003468")]
	[FieldOffset(Offset = "0xE8")]
	private string m_Guid;

	[Token(Token = "0x4003469")]
	[FieldOffset(Offset = "0xF0")]
	private bool m_UserPlaced;

	[Token(Token = "0x400346A")]
	public static bool s_DebugPlacement;

	[Token(Token = "0x170002CE")]
	[field: Token(Token = "0x4003467")]
	[field: FieldOffset(Offset = "0xE0")]
	public List<Transform> VisPoints
	{
		[Token(Token = "0x6002BD9")]
		[Address(RVA = "0x502660", Offset = "0x501460", Length = "0x8")]
		get;
		[Token(Token = "0x6002BDA")]
		[Address(RVA = "0x926B10", Offset = "0x925910", Length = "0x52")]
		private set;
	}

	[Token(Token = "0x170002CF")]
	public float VisCheckLength
	{
		[Token(Token = "0x6002BDB")]
		[Address(RVA = "0x63BFF0", Offset = "0x63ADF0", Length = "0x9")]
		get
		{
			return 0f;
		}
	}

	[Token(Token = "0x6002BD8")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	private void OnValidate()
	{
	}

	[Token(Token = "0x6002BDC")]
	[Address(RVA = "0x926B70", Offset = "0x925970", Length = "0x790")]
	private void Awake()
	{
	}

	[Token(Token = "0x6002BDD")]
	[Address(RVA = "0x927310", Offset = "0x926110", Length = "0xD1")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6002BDE")]
	[Address(RVA = "0x9273F0", Offset = "0x9261F0", Length = "0x8")]
	public bool IsUserPlaced()
	{
		return false;
	}

	[Token(Token = "0x6002BDF")]
	[Address(RVA = "0x927400", Offset = "0x926200", Length = "0x61")]
	public bool CanPlaceInWorld()
	{
		return false;
	}

	[Token(Token = "0x6002BE0")]
	[Address(RVA = "0x927470", Offset = "0x926270", Length = "0x111")]
	public void Activate(string guid)
	{
	}

	[Token(Token = "0x6002BE1")]
	[Address(RVA = "0x927590", Offset = "0x926390", Length = "0xF8")]
	public void SetMapDetailName(string name)
	{
	}

	[Token(Token = "0x6002BE2")]
	[Address(RVA = "0x502630", Offset = "0x501430", Length = "0x8")]
	public string GetGuid()
	{
		return null;
	}

	[Token(Token = "0x6002BE3")]
	[Address(RVA = "0x927690", Offset = "0x926490", Length = "0x1D7")]
	public string Serialize()
	{
		return null;
	}

	[Token(Token = "0x6002BE4")]
	[Address(RVA = "0x927870", Offset = "0x926670", Length = "0x27B")]
	public void Deserialize(string text)
	{
	}

	[Token(Token = "0x6002BE5")]
	[Address(RVA = "0x927AF0", Offset = "0x9268F0", Length = "0x25C")]
	public void OnBuild()
	{
	}

	[Token(Token = "0x6002BE6")]
	[Address(RVA = "0x927D50", Offset = "0x926B50", Length = "0x4C9")]
	private void SetupInWorld()
	{
	}

	[Token(Token = "0x6002BE7")]
	[Address(RVA = "0x928220", Offset = "0x927020", Length = "0xCC")]
	public void BuildFinished()
	{
	}

	[Token(Token = "0x6002BE8")]
	[Address(RVA = "0x9282F0", Offset = "0x9270F0", Length = "0x1B6")]
	public void BuildCallback(bool success, bool playerCancel, float progress)
	{
	}

	[Token(Token = "0x6002BE9")]
	[Address(RVA = "0x9284B0", Offset = "0x9272B0", Length = "0x270")]
	public void OnLabel()
	{
	}

	[Token(Token = "0x6002BEA")]
	[Address(RVA = "0x928730", Offset = "0x927530", Length = "0x118")]
	private void OnRenameRockCacheConfirmed()
	{
	}

	[Token(Token = "0x6002BEB")]
	[Address(RVA = "0x928850", Offset = "0x927650", Length = "0x319")]
	public void OnDismantle()
	{
	}

	[Token(Token = "0x6002BEC")]
	[Address(RVA = "0x928B70", Offset = "0x927970", Length = "0x280")]
	private void DismantleFinished()
	{
	}

	[Token(Token = "0x6002BED")]
	[Address(RVA = "0x928E00", Offset = "0x927C00", Length = "0xEE")]
	public void DismantleCallback(bool success, bool playerCancel, float progress)
	{
	}

	[Token(Token = "0x6002BEE")]
	[Address(RVA = "0x928EF0", Offset = "0x927CF0", Length = "0x2D5")]
	public RockCache()
	{
	}
}
