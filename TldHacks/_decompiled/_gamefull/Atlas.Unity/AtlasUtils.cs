using Cpp2ILInjected;
using UnityEngine;

namespace Atlas.Unity;

[Token(Token = "0x2000D14")]
public static class AtlasUtils
{
	[Token(Token = "0x400817C")]
	public static bool previewColor;

	[Token(Token = "0x400817D")]
	public static StampBase previewColorStamp;

	[Token(Token = "0x400817E")]
	public static bool previewMask;

	[Token(Token = "0x400817F")]
	public static StampBase previewMaskStamp;

	[Token(Token = "0x4008180")]
	public static int previewMaskStampIndex;

	[Token(Token = "0x6006742")]
	[Address(RVA = "0x103CFE0", Offset = "0x103BDE0", Length = "0x163")]
	public static void ClearPreview()
	{
	}

	[Token(Token = "0x6006743")]
	[Address(RVA = "0x103D150", Offset = "0x103BF50", Length = "0x31")]
	public static int SimpleResolutionToInt(SimpleResolution resolution)
	{
		return 0;
	}

	[Token(Token = "0x6006744")]
	[Address(RVA = "0x103D190", Offset = "0x103BF90", Length = "0xCC")]
	public static int WResolutionToInt(WResolution resolution, bool plusone = false)
	{
		return 0;
	}

	[Token(Token = "0x6006745")]
	[Address(RVA = "0x103D2A0", Offset = "0x103C0A0", Length = "0x4B7")]
	public static Vector3 LocalPointToTerrainRelativePoint(StampBase stampBase, Vector3 point, AtlasStamper atlasStamper)
	{
		return default(Vector3);
	}

	[Token(Token = "0x6006746")]
	[Address(RVA = "0x103D760", Offset = "0x103C560", Length = "0x20")]
	public static Color GetRenderTextureClearColor(AtlasStamper.RenderPool.RenderTextureType renderTextureType)
	{
		return default(Color);
	}

	[Token(Token = "0x6006747")]
	[Address(RVA = "0x103D7F0", Offset = "0x103C5F0", Length = "0x48")]
	public static int GetRenderTextureResolution(AtlasStamper.RenderPool.RenderTextureType renderTextureType, int resolution, int splatResolution, bool forUnityTerrain)
	{
		return 0;
	}

	[Token(Token = "0x6006748")]
	[Address(RVA = "0x103D860", Offset = "0x103C660", Length = "0x1B")]
	public static RenderTextureFormat GetRenderTextureFormat(AtlasStamper.RenderPool.RenderTextureType renderTextureType)
	{
		return default(RenderTextureFormat);
	}

	[Token(Token = "0x6006749")]
	[Address(RVA = "0x103D880", Offset = "0x103C680", Length = "0xB9")]
	public static void CenterAndSizeFromIndex(int index1, int index2, int count1, int count2, Vector3 center, Vector3 size, out Vector3 outCenter, out Vector3 outSize)
	{
		outCenter = default(Vector3);
		outSize = default(Vector3);
	}

	[Token(Token = "0x600674A")]
	[Address(RVA = "0x103D940", Offset = "0x103C740", Length = "0x8")]
	public static int XYToIndex(int x, int y, int county)
	{
		return 0;
	}

	[Token(Token = "0x600674B")]
	[Address(RVA = "0x103D950", Offset = "0x103C750", Length = "0x50")]
	public static void StampTargetTypeToRenderTextureTypeAndChannel(StampBase.StampMap.StampTargetType stampTargetType, out AtlasStamper.RenderPool.RenderTextureType renderTextureType, out int channelIndex)
	{
		renderTextureType = default(AtlasStamper.RenderPool.RenderTextureType);
		channelIndex = default(int);
	}

	[Token(Token = "0x600674C")]
	[Address(RVA = "0x103DA30", Offset = "0x103C830", Length = "0x5E")]
	public static Color IndexToColor(int index)
	{
		return default(Color);
	}

	[Token(Token = "0x600674D")]
	[Address(RVA = "0x103DA90", Offset = "0x103C890", Length = "0x172")]
	public static bool IsHDRP()
	{
		return false;
	}

	[Token(Token = "0x600674E")]
	[Address(RVA = "0x103DC10", Offset = "0x103CA10", Length = "0x172")]
	public static bool IsURP()
	{
		return false;
	}

	[Token(Token = "0x600674F")]
	[Address(RVA = "0x103DD90", Offset = "0x103CB90", Length = "0x3D2")]
	public static bool IsValidPath(string path, out string error)
	{
		error = null;
		return false;
	}
}
