using Cpp2ILInjected;
using UnityEngine;

namespace Atlas.Unity;

[Token(Token = "0x2000D1D")]
public static class AtlasPainter
{
	[Token(Token = "0x40081B5")]
	public static bool editing;

	[Token(Token = "0x40081B6")]
	public static Stamp currentStamp;

	[Token(Token = "0x40081B7")]
	public static RenderTexture currentRenderTexture;

	[Token(Token = "0x40081B8")]
	public static bool previewMask;

	[Token(Token = "0x40081B9")]
	public static Texture2D brush;

	[Token(Token = "0x40081BA")]
	public static Material brushMaterial;

	[Token(Token = "0x40081BB")]
	public static float size;

	[Token(Token = "0x40081BC")]
	public static float opacity;

	[Token(Token = "0x40081BD")]
	private static Texture pre;

	[Token(Token = "0x40081BE")]
	private static Collider[] colliders;

	[Token(Token = "0x40081BF")]
	private static bool leftMouseButtonDown;

	[Token(Token = "0x40081C0")]
	public static float m_BrushSizeAdjust;

	[Token(Token = "0x40081C1")]
	public static string m_MouseTransformName;

	[Token(Token = "0x40081C2")]
	private static Vector3 m_MousePos;

	[Token(Token = "0x40081C3")]
	private static Vector3 m_MouseNrm;

	[Token(Token = "0x40081C4")]
	private static float m_MouseSz;

	[Token(Token = "0x40081C5")]
	private static GameObject m_MouseTransform;

	[Token(Token = "0x40081C6")]
	public static float m_ConversionPower;

	[Token(Token = "0x40081C7")]
	public static bool m_GammaToLinear;

	[Token(Token = "0x40081C8")]
	private static readonly Color m_BrushPaintingOuterActive;

	[Token(Token = "0x40081C9")]
	private static readonly Color m_BrushPaintingInnerActive;

	[Token(Token = "0x6006771")]
	[Address(RVA = "0x1045D80", Offset = "0x1044B80", Length = "0x2FE")]
	public static void OnEnable()
	{
	}

	[Token(Token = "0x6006772")]
	[Address(RVA = "0x1046080", Offset = "0x1044E80", Length = "0x45")]
	public static void OnDisable()
	{
	}

	[Token(Token = "0x6006773")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public static void EditorUpdate()
	{
	}

	[Token(Token = "0x6006774")]
	[Address(RVA = "0x10460D0", Offset = "0x1044ED0", Length = "0x868")]
	public static void EditStampMask(Stamp stamp)
	{
	}

	[Token(Token = "0x6006775")]
	[Address(RVA = "0x1046940", Offset = "0x1045740", Length = "0x9E3")]
	public static void ApplyChange(string dir)
	{
	}

	[Token(Token = "0x6006776")]
	[Address(RVA = "0x1047330", Offset = "0x1046130", Length = "0x153")]
	public static void Reset()
	{
	}

	[Token(Token = "0x6006777")]
	[Address(RVA = "0x1047490", Offset = "0x1046290", Length = "0x203")]
	public static void Clear()
	{
	}

	[Token(Token = "0x6006778")]
	[Address(RVA = "0x10476A0", Offset = "0x10464A0", Length = "0x4D9")]
	public static void StopEditStampMask()
	{
	}

	[Token(Token = "0x6006779")]
	[Address(RVA = "0x1047B80", Offset = "0x1046980", Length = "0x2F5")]
	public static void Paint(Vector2 mousePosition, RenderTexture renderTexture, Collider[] colliders, Texture2D brush, Transform localTransform, Vector3 stampCenter, Vector3 stampSize, Color color, float size, float opacity)
	{
	}

	[Token(Token = "0x600677A")]
	[Address(RVA = "0x1047E80", Offset = "0x1046C80", Length = "0xA2")]
	private static bool RaycastColliders(Collider[] colliders, Vector2 mousePosition, out Vector3 point, out Vector3 scale)
	{
		point = default(Vector3);
		scale = default(Vector3);
		return false;
	}

	[Token(Token = "0x600677B")]
	[Address(RVA = "0x1047F30", Offset = "0x1046D30", Length = "0x214")]
	private static Vector2 PointToUV(Vector3 point, Transform localTransform, Vector3 center, Vector3 size)
	{
		return default(Vector2);
	}

	[Token(Token = "0x600677C")]
	[Address(RVA = "0x1048150", Offset = "0x1046F50", Length = "0x751")]
	private static void Draw(Vector2 uv, RenderTexture renderTexture, Texture2D brush, Material brushMaterial, Color color, float size, float opacity)
	{
	}

	[Token(Token = "0x600677D")]
	[Address(RVA = "0x10488B0", Offset = "0x10476B0", Length = "0x17A")]
	private static Collider[] GetPaintColliders()
	{
		return null;
	}

	[Token(Token = "0x600677E")]
	[Address(RVA = "0x1048A30", Offset = "0x1047830", Length = "0x78")]
	private static Material CreatePaintMaterialEditor()
	{
		return null;
	}

	[Token(Token = "0x600677F")]
	[Address(RVA = "0x4582A0", Offset = "0x4570A0", Length = "0x3")]
	private static Texture2D LoadPaintBrushEditor()
	{
		return null;
	}

	[Token(Token = "0x6006780")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	private static void RepaintInspector()
	{
	}
}
