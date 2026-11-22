using ModSettings;

namespace ObjectSinkFix;

internal static class ModSettingsIntegration
{
    internal static void Register()
    {
        var settings = Settings.Instance;
        settings.AddToModSettings("Object Sink Fix / 家具下沉修复");
        settings.Apply();
    }
}

internal sealed class Settings : JsonModSettings
{
    internal static Settings Instance { get; } = new Settings();

    [Section("Recovery / 找回")]
    [Name("Also restore objects you may have destroyed / 连可能是自己拆的也找回")]
    [Description("Also brings back searched and emptied containers, containers with no saved contents, and furniture lost from a difficulty variant pair, all empty. This will likely restore intentionally destroyed objects from a scene's authored layout.\n关着的时候只找回没翻过或者里面还有东西的容器。打开后,翻空了的容器、没有存档记录的容器,以及同样原因丢的几件家具也会找回来,里面都是空的。你自己拆掉的东西也可能被找回来,再拆一次就行。")]
    public bool RestoreDestroyable = false;

    protected override void OnConfirm()
    {
        base.OnConfirm();
        Apply();
    }

    internal void Apply()
    {
        ObjectSinkFixMod.RecoverDestroyable = RestoreDestroyable;
    }
}
