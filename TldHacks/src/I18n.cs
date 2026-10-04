using System;

namespace TldHacks;

internal static class I18n
{
    public const int MODE_AUTO = 0;
    public const int MODE_ZH   = 1;
    public const int MODE_EN   = 2;

    private static bool _autoIsEn;
    private static int _autoAt = int.MinValue;
    // 主菜单加载过以后才能读 Localization.Language
    internal static bool GameReady;

    public static bool IsEnglish
    {
        get
        {
            int mode = ModMain.Settings != null ? ModMain.Settings.LanguageMode : MODE_AUTO;
            if (mode == MODE_ZH) return false;
            if (mode == MODE_EN) return true;
            // 游戏里改了语言也能跟上:最多两秒读一次。菜单每帧调几百次,计时用托管的 TickCount,不走 Unity
            int now = Environment.TickCount;
            if (unchecked(now - _autoAt) > 2000 || _autoAt == int.MinValue) { _autoIsEn = GameIsEnglish(); _autoAt = now; }
            return _autoIsEn;
        }
    }

    // Auto 只看游戏的语言设置。游戏存在 PlayerPrefs 的 "Language" 里(如 "Simplified Chinese"),什么时候读都安全;
    // 别在启动时读 Localization.Language,它会提前加载语言表,游戏自己的语言表就加载失败
    internal static bool GameIsEnglish()
    {
        try
        {
            string l = UnityEngine.PlayerPrefs.GetString("Language", "");
            // 从没在游戏里选过语言时 PlayerPrefs 是空的,等游戏进了主菜单再问它当前用的语言
            if (string.IsNullOrEmpty(l) && GameReady) { try { l = Il2Cpp.Localization.Language; } catch { } }
            return !string.IsNullOrEmpty(l) && !l.ToLowerInvariant().Contains("chinese");
        }
        catch { return false; }
    }

    public static string T(string zh, string en) => IsEnglish ? en : zh;
}
