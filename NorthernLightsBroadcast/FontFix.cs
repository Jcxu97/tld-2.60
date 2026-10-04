using Il2CppTMPro;
using MelonLoader;
using UnityEngine;

namespace NorthernLightsBroadcast;

// v2.1.1 修「电视界面一个字都不显示」
//
// mod 的界面包是 Unity 2021.3.6f1 打的,游戏是 Unity 6000.0.60f1。TMP_FontAsset 在两个版本里
// 存材质的字段名不一样(2021 是 material,U6 读 m_Material),名字对不上就填不进去 → 反序列化
// 出来的字体没材质,TMP 画不出任何字形,整片空白。包里 105 个文字组件全中招。
//
// 顺带:包里两个字体(LiberationSans / Arcade)都是 Static 模式且不含汉字,中文文件名本来也出不来。
//
// 所以运行时全部改指向游戏自带的 NotoSansCJKsc-Regular SDF —— Dynamic 模式、允许自动开新图集、
// 带完整字库文件,任何汉字现场烤。不碰那个字体资产的任何字段(它是全局共享的)。
internal static class FontFix
{
	private static TMP_FontAsset _font;
	private static Material _material;
	private static bool _resolved;
	private static int _attempts;

	// 场景切换时调用:新场景的字体对象是新的,缓存要作废
	public static void Invalidate()
	{
		_font = null;
		_material = null;
		_resolved = false;
		_attempts = 0;
	}

	private static bool Usable(TMP_FontAsset f)
	{
		if (f == null) return false;
		try { return f.name != null && f.material != null && f.atlasTexture != null; }
		catch { return false; }
	}

	private static TMP_FontAsset Resolve()
	{
		if (_resolved) return _font;
		// FindObjectsOfTypeAll 是全托管堆扫描,别让它无限期反复跑。
		// 20 次(每次开菜单一次)还找不到字体就放弃,切场景时重新给额度。
		if (_attempts > 20) return null;
		_attempts++;
		_resolved = true;

		var all = Resources.FindObjectsOfTypeAll<TMP_FontAsset>();
		if (all == null || all.Count == 0) { _resolved = false; return null; }

		// 1) 游戏自带的中文字体(唯一一个真带汉字的)
		foreach (var f in all)
			if (Usable(f) && f.name.Contains("NotoSansCJK")) { _font = f; break; }

		// 2) 任何 Dynamic 字体:装了汉化包之类的情况下名字可能不一样,但 Dynamic 能现场补字形
		if (_font == null)
			foreach (var f in all)
			{
				if (!Usable(f)) continue;
				try { if (f.atlasPopulationMode == AtlasPopulationMode.Dynamic) { _font = f; break; } }
				catch { }
			}

		// 3) 兜底:任何能用的。中文可能还是缺,但至少英文界面能看见
		if (_font == null)
			foreach (var f in all)
				if (Usable(f)) { _font = f; break; }

		if (_font == null) { _resolved = false; return null; }

		try { _material = _font.material; } catch { }
		MelonLogger.Msg("[NLB] Font resolved -> " + _font.name);
		return _font;
	}

	// 把 root 底下所有文字改指向解析到的字体。成功返回 true,没解析到字体返回 false(下次再试)。
	public static bool Apply(GameObject root)
	{
		if (root == null) return false;
		var font = Resolve();
		if (font == null) return false;

		var texts = root.GetComponentsInChildren<TextMeshProUGUI>(true);
		if (texts == null) return true;

		int n = 0;
		foreach (var t in texts)
		{
			if (t == null) continue;
			try
			{
				((TMP_Text)t).font = font;
				// 只换字体不换材质还是空白:材质里带图集贴图和 SDF 采样参数
				if (_material != null) ((TMP_Text)t).fontSharedMaterial = _material;
				((TMP_Text)t).ForceMeshUpdate(true, true);
				n++;
			}
			catch { }
		}
		MelonLogger.Msg("[NLB] Font applied to " + n + " texts");
		return true;
	}
}
