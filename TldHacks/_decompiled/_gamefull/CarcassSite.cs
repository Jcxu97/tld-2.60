using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x2000167")]
public class CarcassSite : MonoBehaviour
{
	[Token(Token = "0x2000168")]
	public struct CarcassSiteDataProxy
	{
		[Token(Token = "0x4000D2E")]
		[FieldOffset(Offset = "0x0")]
		public string m_PrefabName;

		[Token(Token = "0x4000D2F")]
		[FieldOffset(Offset = "0x8")]
		public Vector3 m_Position;

		[Token(Token = "0x4000D30")]
		[FieldOffset(Offset = "0x14")]
		public float m_LastHarvestTimeHours;

		[Token(Token = "0x4000D31")]
		[FieldOffset(Offset = "0x18")]
		public bool m_HasSpawnPostHarvestFX;
	}

	[Token(Token = "0x2000169")]
	public class ManagerDataProxy
	{
		[Token(Token = "0x4000D32")]
		[FieldOffset(Offset = "0x10")]
		public List<CarcassSiteDataProxy> m_ProxyDataList;

		[Token(Token = "0x6000E06")]
		[Address(RVA = "0x5E4D60", Offset = "0x5E3B60", Length = "0xAD")]
		public ManagerDataProxy()
		{
		}
	}

	[Token(Token = "0x200016A")]
	public class Manager
	{
		[Token(Token = "0x4000D33")]
		private static List<CarcassSite> m_AllCarcassSiteList;

		[Token(Token = "0x4000D34")]
		private static ManagerDataProxy m_ManagerDataProxy;

		[Token(Token = "0x6000E07")]
		[Address(RVA = "0x5E4E10", Offset = "0x5E3C10", Length = "0x348")]
		public static string Serialize()
		{
			return null;
		}

		[Token(Token = "0x6000E08")]
		[Address(RVA = "0x5E5160", Offset = "0x5E3F60", Length = "0x2CB")]
		public static void Deserialize(string text)
		{
		}

		[Token(Token = "0x6000E09")]
		[Address(RVA = "0x5E5430", Offset = "0x5E4230", Length = "0x20D")]
		private static CarcassSite TryInstanciateCarcassSite(GameObject carcassSitePrefab, Vector3 position, GameObject originCorpse)
		{
			return null;
		}

		[Token(Token = "0x6000E0A")]
		[Address(RVA = "0x5E5640", Offset = "0x5E4440", Length = "0x189")]
		public static CarcassSite TrySpawnCarcassSite(GameObject carcassSitePrefab, Vector3 position, GameObject originCorpse, bool spawnPostHarvestFX, float timeHours)
		{
			return null;
		}

		[Token(Token = "0x6000E0B")]
		[Address(RVA = "0x5E57D0", Offset = "0x5E45D0", Length = "0x93")]
		public static void Reset()
		{
		}

		[Token(Token = "0x6000E0C")]
		[Address(RVA = "0x5E5870", Offset = "0x5E4670", Length = "0x24F")]
		public static bool IsCarcasseSiteNearby(Vector3 position, float radius)
		{
			return false;
		}

		[Token(Token = "0x6000E0D")]
		[Address(RVA = "0x5E5AC0", Offset = "0x5E48C0", Length = "0xBD")]
		public static void Add(CarcassSite site)
		{
		}

		[Token(Token = "0x6000E0E")]
		[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
		public Manager()
		{
		}
	}

	[Token(Token = "0x4000D26")]
	[FieldOffset(Offset = "0x20")]
	public float m_SiteRadius;

	[Token(Token = "0x4000D27")]
	[FieldOffset(Offset = "0x24")]
	public float m_PostHarvestMessDurationHours;

	[Token(Token = "0x4000D28")]
	[FieldOffset(Offset = "0x28")]
	public GameObject m_PostHarvestMessFXPrefab;

	[Token(Token = "0x4000D29")]
	[FieldOffset(Offset = "0x30")]
	private Carrion m_Carrion;

	[Token(Token = "0x4000D2A")]
	[FieldOffset(Offset = "0x38")]
	private GameObject m_PostHarvestMessFX;

	[Token(Token = "0x4000D2B")]
	[FieldOffset(Offset = "0x40")]
	private float m_LastHarvestTimeHours;

	[Token(Token = "0x4000D2C")]
	[FieldOffset(Offset = "0x48")]
	private List<BodyHarvest> m_BodyHarvestList;

	[Token(Token = "0x4000D2D")]
	[FieldOffset(Offset = "0x50")]
	private bool m_HasSpawnPostHarvestFX;

	[Token(Token = "0x6000DF3")]
	[Address(RVA = "0x5E2F80", Offset = "0x5E1D80", Length = "0x162")]
	public void Awake()
	{
	}

	[Token(Token = "0x6000DF4")]
	[Address(RVA = "0x5E30F0", Offset = "0x5E1EF0", Length = "0x237")]
	public void Update()
	{
	}

	[Token(Token = "0x6000DF5")]
	[Address(RVA = "0x5E3330", Offset = "0x5E2130", Length = "0x20C")]
	public void Refresh(float hoursAtRefresh)
	{
	}

	[Token(Token = "0x6000DF6")]
	[Address(RVA = "0x5E3540", Offset = "0x5E2340", Length = "0x1AE")]
	private void RefreshPostHarvestMessFX(float hoursAtRefresh)
	{
	}

	[Token(Token = "0x6000DF7")]
	[Address(RVA = "0x5E36F0", Offset = "0x5E24F0", Length = "0x157")]
	private CarcassSiteDataProxy Serialize()
	{
		return default(CarcassSiteDataProxy);
	}

	[Token(Token = "0x6000DF8")]
	[Address(RVA = "0x5E3850", Offset = "0x5E2650", Length = "0x41")]
	private void Deserialize(CarcassSiteDataProxy dataProxy)
	{
	}

	[Token(Token = "0x6000DF9")]
	[Address(RVA = "0x5E38A0", Offset = "0x5E26A0", Length = "0x260")]
	private void Initialize(Vector3 position, string name, bool spawnPostHarvestFX, float timeHours)
	{
	}

	[Token(Token = "0x6000DFA")]
	[Address(RVA = "0x5E3B10", Offset = "0x5E2910", Length = "0x224")]
	private void AddPostHarvestMessFx(Vector3 position)
	{
	}

	[Token(Token = "0x6000DFB")]
	[Address(RVA = "0x5E3D40", Offset = "0x5E2B40", Length = "0x7C")]
	private bool HasPostHarvestMessFxExpired()
	{
		return false;
	}

	[Token(Token = "0x6000DFC")]
	[Address(RVA = "0x5E3DC0", Offset = "0x5E2BC0", Length = "0x193")]
	private void UpdatePostHarvestMess()
	{
	}

	[Token(Token = "0x6000DFD")]
	[Address(RVA = "0x5E3F60", Offset = "0x5E2D60", Length = "0x394")]
	private BodyHarvest TryGetBodyHarvestFromCollider(Collider collider)
	{
		return null;
	}

	[Token(Token = "0x6000DFE")]
	[Address(RVA = "0x5E4300", Offset = "0x5E3100", Length = "0x73")]
	private void SetCarrionActive(bool enabled)
	{
	}

	[Token(Token = "0x6000DFF")]
	[Address(RVA = "0x5E4380", Offset = "0x5E3180", Length = "0xF2")]
	private bool IsCarrionActive()
	{
		return false;
	}

	[Token(Token = "0x6000E00")]
	[Address(RVA = "0x5E4480", Offset = "0x5E3280", Length = "0xB9")]
	private void AddBodyHarvest(BodyHarvest bodyHarvest)
	{
	}

	[Token(Token = "0x6000E01")]
	[Address(RVA = "0x5E4540", Offset = "0x5E3340", Length = "0x64")]
	private void ResetBodyHarvestOnSite()
	{
	}

	[Token(Token = "0x6000E02")]
	[Address(RVA = "0x5E45B0", Offset = "0x5E33B0", Length = "0x275")]
	private void AddBodyHarvestOnSite()
	{
	}

	[Token(Token = "0x6000E03")]
	[Address(RVA = "0x5E4830", Offset = "0x5E3630", Length = "0x384")]
	private int GetNumberOfNonDepletedItemsOnSite()
	{
		return 0;
	}

	[Token(Token = "0x6000E04")]
	[Address(RVA = "0x5E4BC0", Offset = "0x5E39C0", Length = "0xA9")]
	private void UpdateCarrion()
	{
	}

	[Token(Token = "0x6000E05")]
	[Address(RVA = "0x5E4C70", Offset = "0x5E3A70", Length = "0xE3")]
	public CarcassSite()
	{
	}
}
