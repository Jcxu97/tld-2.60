using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;

namespace Atlas.Unity;

[Token(Token = "0x2000D0C")]
public class AtlasStamper : IDisposable
{
	[Token(Token = "0x2000D0D")]
	public class StampSorter : IComparer<StampBase>
	{
		[Token(Token = "0x600671C")]
		[Address(RVA = "0x103AA50", Offset = "0x1039850", Length = "0x36F")]
		public int Compare(StampBase x, StampBase y)
		{
			return 0;
		}

		[Token(Token = "0x600671D")]
		[Address(RVA = "0x103ADC0", Offset = "0x1039BC0", Length = "0x3AA")]
		private List<Transform> GetParents(Transform t)
		{
			return null;
		}

		[Token(Token = "0x600671E")]
		[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
		public StampSorter()
		{
		}
	}

	[Token(Token = "0x2000D0E")]
	public class RenderPool : IDisposable
	{
		[Token(Token = "0x2000D0F")]
		public enum MaterialType
		{
			[Token(Token = "0x4008149")]
			AtlasHeight,
			[Token(Token = "0x400814A")]
			AtlasColor,
			[Token(Token = "0x400814B")]
			AtlasMask,
			[Token(Token = "0x400814C")]
			AtlasOtherMask,
			[Token(Token = "0x400814D")]
			AtlasRoadMask,
			[Token(Token = "0x400814E")]
			AtlasHeightMerge,
			[Token(Token = "0x400814F")]
			AtlasColorMerge,
			[Token(Token = "0x4008150")]
			AtlasOtherMaskMerge,
			[Token(Token = "0x4008151")]
			AtlasRoadMaskMerge,
			[Token(Token = "0x4008152")]
			AtlasNormal,
			[Token(Token = "0x4008153")]
			AtlasHeightBasedAlteration,
			[Token(Token = "0x4008154")]
			AtlasSplatSum,
			[Token(Token = "0x4008155")]
			AtlasSplatNormalize
		}

		[Token(Token = "0x2000D10")]
		public enum RenderTextureType
		{
			[Token(Token = "0x4008157")]
			PreHeight,
			[Token(Token = "0x4008158")]
			Height,
			[Token(Token = "0x4008159")]
			Mask,
			[Token(Token = "0x400815A")]
			PreSplat1,
			[Token(Token = "0x400815B")]
			PreSplat2,
			[Token(Token = "0x400815C")]
			PreSplat3,
			[Token(Token = "0x400815D")]
			PreSplat4,
			[Token(Token = "0x400815E")]
			Other,
			[Token(Token = "0x400815F")]
			PreColor,
			[Token(Token = "0x4008160")]
			Color,
			[Token(Token = "0x4008161")]
			FinalHeight,
			[Token(Token = "0x4008162")]
			FinalSplat1,
			[Token(Token = "0x4008163")]
			FinalSplat2,
			[Token(Token = "0x4008164")]
			FinalSplat3,
			[Token(Token = "0x4008165")]
			FinalSplat4,
			[Token(Token = "0x4008166")]
			FinalColor,
			[Token(Token = "0x4008167")]
			FinalNormal,
			[Token(Token = "0x4008168")]
			RoadMask,
			[Token(Token = "0x4008169")]
			PreRoadMask,
			[Token(Token = "0x400816A")]
			FinalRoadMask,
			[Token(Token = "0x400816B")]
			SplatSum
		}

		[Token(Token = "0x17000719")]
		[field: Token(Token = "0x4008146")]
		[field: FieldOffset(Offset = "0x10")]
		public List<RenderTexture> renderTextures
		{
			[Token(Token = "0x600671F")]
			[Address(RVA = "0x49DED0", Offset = "0x49CCD0", Length = "0x5")]
			get;
			[Token(Token = "0x6006720")]
			[Address(RVA = "0x4094C0", Offset = "0x4082C0", Length = "0x52")]
			private set;
		}

		[Token(Token = "0x1700071A")]
		[field: Token(Token = "0x4008147")]
		[field: FieldOffset(Offset = "0x18")]
		public List<Material> materials
		{
			[Token(Token = "0x6006721")]
			[Address(RVA = "0x4571D0", Offset = "0x455FD0", Length = "0x5")]
			get;
			[Token(Token = "0x6006722")]
			[Address(RVA = "0x49DEE0", Offset = "0x49CCE0", Length = "0x52")]
			private set;
		}

		[Token(Token = "0x6006723")]
		[Address(RVA = "0x103B170", Offset = "0x1039F70", Length = "0x9EC")]
		public RenderPool(int resolution, int splatResolution, bool forUnityTerrain)
		{
		}

		[Token(Token = "0x6006724")]
		[Address(RVA = "0x103BBB0", Offset = "0x103A9B0", Length = "0x340")]
		public List<RenderTexture> CloneResult()
		{
			return null;
		}

		[Token(Token = "0x6006725")]
		[Address(RVA = "0x103BF00", Offset = "0x103AD00", Length = "0x70")]
		public Material GetMaterial(MaterialType materialType)
		{
			return null;
		}

		[Token(Token = "0x6006726")]
		[Address(RVA = "0x103BF80", Offset = "0x103AD80", Length = "0x70")]
		public RenderTexture GetRenderTexture(RenderTextureType renderTextureType)
		{
			return null;
		}

		[Token(Token = "0x6006727")]
		[Address(RVA = "0x103C000", Offset = "0x103AE00", Length = "0x9F")]
		public RenderTexture GetRenderTextureClone(RenderTextureType renderTextureType)
		{
			return null;
		}

		[Token(Token = "0x6006728")]
		[Address(RVA = "0x103C0A0", Offset = "0x103AEA0", Length = "0x43")]
		public RenderTexture ClearAndGetRenderTexture(RenderTextureType renderTextureType)
		{
			return null;
		}

		[Token(Token = "0x6006729")]
		[Address(RVA = "0x103C0F0", Offset = "0x103AEF0", Length = "0xB3")]
		public void ResetRenderTextures()
		{
		}

		[Token(Token = "0x600672A")]
		[Address(RVA = "0x103C1B0", Offset = "0x103AFB0", Length = "0x97")]
		public void Dispose()
		{
		}

		[Token(Token = "0x600672B")]
		[Address(RVA = "0x103C250", Offset = "0x103B050", Length = "0x42E")]
		protected virtual void Dispose(bool disposing)
		{
		}

		[Token(Token = "0x600672C")]
		[Address(RVA = "0x103C680", Offset = "0x103B480", Length = "0xD0")]
		private void ClearRenderTexture(RenderTexture renderTexture, RenderTextureType renderTextureType)
		{
		}
	}

	[Token(Token = "0x4008142")]
	[FieldOffset(Offset = "0x30")]
	public List<StampBase> ignoreList;

	[Token(Token = "0x4008143")]
	[FieldOffset(Offset = "0x38")]
	public List<StampBase> renderAtEndList;

	[Token(Token = "0x4008144")]
	[FieldOffset(Offset = "0x40")]
	public bool dirty;

	[Token(Token = "0x4008145")]
	public static List<AtlasStamper> atlasStampers;

	[Token(Token = "0x17000714")]
	[field: Token(Token = "0x400813D")]
	[field: FieldOffset(Offset = "0x10")]
	public AtlasTerrainData atlasTerrainData
	{
		[Token(Token = "0x6006709")]
		[Address(RVA = "0x49DED0", Offset = "0x49CCD0", Length = "0x5")]
		get;
		[Token(Token = "0x600670A")]
		[Address(RVA = "0x4094C0", Offset = "0x4082C0", Length = "0x52")]
		private set;
	}

	[Token(Token = "0x17000715")]
	[field: Token(Token = "0x400813E")]
	[field: FieldOffset(Offset = "0x18")]
	public RenderPool renderPool
	{
		[Token(Token = "0x600670B")]
		[Address(RVA = "0x4571D0", Offset = "0x455FD0", Length = "0x5")]
		get;
		[Token(Token = "0x600670C")]
		[Address(RVA = "0x49DEE0", Offset = "0x49CCE0", Length = "0x52")]
		private set;
	}

	[Token(Token = "0x17000716")]
	[field: Token(Token = "0x400813F")]
	[field: FieldOffset(Offset = "0x20")]
	public int resolution
	{
		[Token(Token = "0x600670D")]
		[Address(RVA = "0x4571E0", Offset = "0x455FE0", Length = "0x4")]
		get;
		[Token(Token = "0x600670E")]
		[Address(RVA = "0x509350", Offset = "0x508150", Length = "0x4")]
		private set;
	}

	[Token(Token = "0x17000717")]
	[field: Token(Token = "0x4008140")]
	[field: FieldOffset(Offset = "0x24")]
	public int splatResolution
	{
		[Token(Token = "0x600670F")]
		[Address(RVA = "0x4AA8A0", Offset = "0x4A96A0", Length = "0x4")]
		get;
		[Token(Token = "0x6006710")]
		[Address(RVA = "0x4AA8B0", Offset = "0x4A96B0", Length = "0x4")]
		private set;
	}

	[Token(Token = "0x17000718")]
	[field: Token(Token = "0x4008141")]
	[field: FieldOffset(Offset = "0x28")]
	public bool forUnityTerrain
	{
		[Token(Token = "0x6006711")]
		[Address(RVA = "0xB97C80", Offset = "0xB96A80", Length = "0x5")]
		get;
		[Token(Token = "0x6006712")]
		[Address(RVA = "0xE3CD40", Offset = "0xE3BB40", Length = "0x4")]
		private set;
	}

	[Token(Token = "0x6006713")]
	[Address(RVA = "0x1037E90", Offset = "0x1036C90", Length = "0x36D")]
	public AtlasStamper(AtlasTerrainData atlasTerrainData, int resolution, int splatResolution, bool forUnityTerrain, bool registerForTriggeredRendering, List<StampBase> ignoreList = null, List<StampBase> renderAtEndList = null)
	{
	}

	[Token(Token = "0x6006714")]
	[Address(RVA = "0x1038200", Offset = "0x1037000", Length = "0x1630")]
	public void Render(bool forExport = false)
	{
	}

	[Token(Token = "0x6006715")]
	[Address(RVA = "0x1039840", Offset = "0x1038640", Length = "0x20A")]
	public void Dispose()
	{
	}

	[Token(Token = "0x6006716")]
	[Address(RVA = "0x1039A50", Offset = "0x1038850", Length = "0xBF")]
	protected virtual void Dispose(bool disposing)
	{
	}

	[Token(Token = "0x6006717")]
	[Address(RVA = "0x1039B10", Offset = "0x1038910", Length = "0xACF")]
	private List<StampBase> FindStamps()
	{
		return null;
	}

	[Token(Token = "0x6006718")]
	[Address(RVA = "0x103A5E0", Offset = "0x10393E0", Length = "0xBD")]
	private static void RegisterForTriggeredRendering(AtlasStamper atlasStamper)
	{
	}

	[Token(Token = "0x6006719")]
	[Address(RVA = "0x103A6A0", Offset = "0x10394A0", Length = "0x14A")]
	private static void UnRegisterForTriggeredRendering(AtlasStamper atlasStamper)
	{
	}

	[Token(Token = "0x600671A")]
	[Address(RVA = "0x103A7F0", Offset = "0x10395F0", Length = "0x177")]
	public static void QueRender()
	{
	}
}
