using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.Events;

namespace Atlas.Unity;

[RequireComponent(typeof(Terrain))]
[Token(Token = "0x2000D1F")]
public class AtlasUnityTerrainRenderer : MonoBehaviour
{
	[Tooltip("When enabled objects will be scattered based on the assigned scattering rules.")]
	[Token(Token = "0x40081CA")]
	[FieldOffset(Offset = "0x20")]
	public bool useScattering;

	[Token(Token = "0x40081CB")]
	[FieldOffset(Offset = "0x28")]
	public List<ScatterRuleAsset> scatterRuleAssets;

	[Tooltip("When enabled the color map will be exported.")]
	[Token(Token = "0x40081CC")]
	[FieldOffset(Offset = "0x30")]
	public bool exportColorMap;

	[Tooltip("When enabled the heightmap will be exported.")]
	[Token(Token = "0x40081CD")]
	[FieldOffset(Offset = "0x31")]
	public bool exportHeightMap;

	[Tooltip("When enabled the normal map will be exported.")]
	[Token(Token = "0x40081CE")]
	[FieldOffset(Offset = "0x32")]
	public bool exportNormalMap;

	[Tooltip("When enabled the splat map will be exported.")]
	[Token(Token = "0x40081CF")]
	[FieldOffset(Offset = "0x33")]
	public bool exportSplatMaps;

	[Tooltip("When enabled events can be triggered whenever this terrain renders again")]
	[Token(Token = "0x40081D0")]
	[FieldOffset(Offset = "0x34")]
	public bool useEventTrigger;

	[Tooltip("Event triggered whenever we stop editing o when manually pressing the render button")]
	[Token(Token = "0x40081D1")]
	[FieldOffset(Offset = "0x38")]
	public UnityEvent onRender;

	[Token(Token = "0x40081D2")]
	[FieldOffset(Offset = "0x40")]
	public List<int> preTreePrototypeIndexes;

	[Token(Token = "0x40081D3")]
	[FieldOffset(Offset = "0x48")]
	public List<int> preDetailPrototypeIndexes;

	[Token(Token = "0x40081D4")]
	[FieldOffset(Offset = "0x50")]
	public bool firstRender;

	[Token(Token = "0x6006785")]
	[Address(RVA = "0x1048D00", Offset = "0x1047B00", Length = "0x3A3")]
	public void Render(string directoryPath = "")
	{
	}

	[ContextMenu("Scatter")]
	[Token(Token = "0x6006786")]
	[Address(RVA = "0x10490B0", Offset = "0x1047EB0", Length = "0x36A")]
	public void Scattering()
	{
	}

	[ContextMenu("Clear Scattering")]
	[Token(Token = "0x6006787")]
	[Address(RVA = "0x1049420", Offset = "0x1048220", Length = "0x12C")]
	public void ClearScattering()
	{
	}

	[ContextMenu("Clear Detail")]
	[Token(Token = "0x6006788")]
	[Address(RVA = "0x1049550", Offset = "0x1048350", Length = "0x566")]
	public void ClearDetail()
	{
	}

	[Token(Token = "0x6006789")]
	[Address(RVA = "0x1049AC0", Offset = "0x10488C0", Length = "0x62C")]
	private void ApplyTerrain(Terrain terrain, AtlasStamper stamper)
	{
	}

	[Token(Token = "0x600678A")]
	[Address(RVA = "0x104A0F0", Offset = "0x1048EF0", Length = "0x393")]
	private void Scatter(Terrain terrain, AtlasStamper stamper)
	{
	}

	[Token(Token = "0x600678B")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	private void ExportTextures(AtlasStamper stamper, string exportDirectoryPath)
	{
	}

	[Token(Token = "0x600678C")]
	[Address(RVA = "0x104A490", Offset = "0x1049290", Length = "0x123")]
	public void SetEventToRuntimeAndEditor()
	{
	}

	[Token(Token = "0x600678D")]
	[Address(RVA = "0x104A5C0", Offset = "0x10493C0", Length = "0x47")]
	public AtlasUnityTerrainRenderer()
	{
	}
}
