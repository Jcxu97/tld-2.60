using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;

namespace Atlas.Unity;

[Token(Token = "0x2000D15")]
public class AtlasScatterer : IDisposable
{
	[Token(Token = "0x2000D16")]
	public class ScatterInstance
	{
		[Token(Token = "0x400818B")]
		[FieldOffset(Offset = "0x10")]
		public Vector3 position;

		[Token(Token = "0x400818C")]
		[FieldOffset(Offset = "0x1C")]
		public int mode;

		[Token(Token = "0x400818D")]
		[FieldOffset(Offset = "0x20")]
		public float cullRadius;

		[Token(Token = "0x400818E")]
		[FieldOffset(Offset = "0x24")]
		public float detailCullRadius;

		[Token(Token = "0x400818F")]
		[FieldOffset(Offset = "0x28")]
		public int treePrototypeIndex;

		[Token(Token = "0x4008190")]
		[FieldOffset(Offset = "0x30")]
		public GameObject prefab;

		[Token(Token = "0x4008191")]
		[FieldOffset(Offset = "0x38")]
		public float heightScale;

		[Token(Token = "0x4008192")]
		[FieldOffset(Offset = "0x3C")]
		public float widthScale;

		[Token(Token = "0x4008193")]
		[FieldOffset(Offset = "0x40")]
		public float rotation;

		[Token(Token = "0x4008194")]
		[FieldOffset(Offset = "0x44")]
		public float alignment;

		[Token(Token = "0x4008195")]
		[FieldOffset(Offset = "0x48")]
		public float heightOffset;

		[Token(Token = "0x600676A")]
		[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
		public ScatterInstance()
		{
		}
	}

	[Token(Token = "0x4008183")]
	[FieldOffset(Offset = "0x20")]
	public List<ScatterRuleAsset> scatterRuleAssets;

	[Token(Token = "0x4008186")]
	[FieldOffset(Offset = "0x38")]
	private Texture2D tempMask;

	[Token(Token = "0x4008187")]
	[FieldOffset(Offset = "0x40")]
	private int tempMaskChannelIndex;

	[Token(Token = "0x4008188")]
	[FieldOffset(Offset = "0x48")]
	private List<ScatterInstance>[,] gridLookup;

	[Token(Token = "0x4008189")]
	[FieldOffset(Offset = "0x50")]
	private readonly Vector3 down;

	[Token(Token = "0x400818A")]
	[FieldOffset(Offset = "0x5C")]
	private RaycastHit hit;

	[Token(Token = "0x17000721")]
	[field: Token(Token = "0x4008181")]
	[field: FieldOffset(Offset = "0x10")]
	public AtlasStamper atlasStamper
	{
		[Token(Token = "0x6006751")]
		[Address(RVA = "0x49DED0", Offset = "0x49CCD0", Length = "0x5")]
		get;
		[Token(Token = "0x6006752")]
		[Address(RVA = "0x4094C0", Offset = "0x4082C0", Length = "0x52")]
		private set;
	}

	[Token(Token = "0x17000722")]
	[field: Token(Token = "0x4008182")]
	[field: FieldOffset(Offset = "0x18")]
	public Terrain terrain
	{
		[Token(Token = "0x6006753")]
		[Address(RVA = "0x4571D0", Offset = "0x455FD0", Length = "0x5")]
		get;
		[Token(Token = "0x6006754")]
		[Address(RVA = "0x49DEE0", Offset = "0x49CCE0", Length = "0x52")]
		private set;
	}

	[Token(Token = "0x17000723")]
	[field: Token(Token = "0x4008184")]
	[field: FieldOffset(Offset = "0x28")]
	public List<List<ScatterInstance>> nodes
	{
		[Token(Token = "0x6006755")]
		[Address(RVA = "0x413AB0", Offset = "0x4128B0", Length = "0x5")]
		get;
		[Token(Token = "0x6006756")]
		[Address(RVA = "0x4A9DB0", Offset = "0x4A8BB0", Length = "0x52")]
		private set;
	}

	[Token(Token = "0x17000724")]
	[field: Token(Token = "0x4008185")]
	[field: FieldOffset(Offset = "0x30")]
	public List<int[,]> details
	{
		[Token(Token = "0x6006757")]
		[Address(RVA = "0x457420", Offset = "0x456220", Length = "0x5")]
		get;
		[Token(Token = "0x6006758")]
		[Address(RVA = "0x4B1CB0", Offset = "0x4B0AB0", Length = "0x52")]
		private set;
	}

	[Token(Token = "0x6006759")]
	[Address(RVA = "0x103E2C0", Offset = "0x103D0C0", Length = "0x1A0")]
	public AtlasScatterer(AtlasStamper atlasStamper, Terrain terrain, List<ScatterRuleAsset> scatterRuleAssets)
	{
	}

	[Token(Token = "0x600675A")]
	[Address(RVA = "0x103E460", Offset = "0x103D260", Length = "0x62A")]
	public void Render()
	{
	}

	[Token(Token = "0x600675B")]
	[Address(RVA = "0x103EA90", Offset = "0x103D890", Length = "0xAE0")]
	private void InitTreePrototypes()
	{
	}

	[Token(Token = "0x600675C")]
	[Address(RVA = "0x103F580", Offset = "0x103E380", Length = "0x1595")]
	private void InitDetailPrototypes()
	{
	}

	[Token(Token = "0x600675D")]
	[Address(RVA = "0x1040B20", Offset = "0x103F920", Length = "0x12C4")]
	private void RenderScatterRuleAsset(ScatterRuleAsset scatterRuleAsset)
	{
	}

	[Token(Token = "0x600675E")]
	[Address(RVA = "0x1041DF0", Offset = "0x1040BF0", Length = "0x13AC")]
	public void Apply()
	{
	}

	[Token(Token = "0x600675F")]
	[Address(RVA = "0x10431A0", Offset = "0x1041FA0", Length = "0x46C")]
	public List<int> GetTreePrototypeIndexesToScatter()
	{
		return null;
	}

	[Token(Token = "0x6006760")]
	[Address(RVA = "0x1043610", Offset = "0x1042410", Length = "0x46A")]
	public List<int> GetDetailPrototypeIndexesToScatter()
	{
		return null;
	}

	[Token(Token = "0x6006761")]
	[Address(RVA = "0x1043A80", Offset = "0x1042880", Length = "0x2E8")]
	public void ClearTreeInstances(List<int> treePrototypeIndexes)
	{
	}

	[Token(Token = "0x6006762")]
	[Address(RVA = "0x1043D70", Offset = "0x1042B70", Length = "0x306")]
	public void ClearDetails(List<int> detailPrototypeIndexes)
	{
	}

	[Token(Token = "0x6006763")]
	[Address(RVA = "0x1044080", Offset = "0x1042E80", Length = "0xB12")]
	private bool ValidPosition(ScatterRuleAsset scatterRuleAsset, Terrain terrain, Vector3 position, List<ScatterInstance>[,] gridLookup = null, bool forDetail = false, bool selfCulling = false)
	{
		return false;
	}

	[Token(Token = "0x6006764")]
	[Address(RVA = "0x1044BA0", Offset = "0x10439A0", Length = "0x18B")]
	private float GetMaskFactor(Vector3 position)
	{
		return 0f;
	}

	[Token(Token = "0x6006765")]
	[Address(RVA = "0x1044D30", Offset = "0x1043B30", Length = "0x2D2")]
	private Vector3 ToWorldPosition(Terrain terrain, Vector3 position)
	{
		return default(Vector3);
	}

	[Token(Token = "0x6006766")]
	[Address(RVA = "0x1045010", Offset = "0x1043E10", Length = "0xB4")]
	private void RenderTempMask(ScatterRuleAsset scatterRuleAsset)
	{
	}

	[Token(Token = "0x6006767")]
	[Address(RVA = "0x1045430", Offset = "0x1044230", Length = "0x443")]
	private void InitGridLookup()
	{
	}

	[Token(Token = "0x6006768")]
	[Address(RVA = "0x1045880", Offset = "0x1044680", Length = "0x97")]
	public void Dispose()
	{
	}

	[Token(Token = "0x6006769")]
	[Address(RVA = "0x1045920", Offset = "0x1044720", Length = "0x66")]
	protected virtual void Dispose(bool disposing)
	{
	}
}
