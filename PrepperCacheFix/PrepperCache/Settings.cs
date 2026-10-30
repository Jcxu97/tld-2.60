namespace PrepperCache;

internal static class Settings
{
	public static PrepperCacheSettings options;

	public static int waitTime;

	public static bool enablePrepperCacheDataCapture;

	public static bool enablePrepperCacheHUDDisplay;

	public static int hudDisplayDuration;

	public static bool enablePrepperCacheWorldMapDisplay;

	public static void OnLoad()
	{
		options = new PrepperCacheSettings();
		options.AddToModSettings("地堡位置查看器v1.2");
		enablePrepperCacheDataCapture = options.enablePrepperCacheDataCapture;
		enablePrepperCacheHUDDisplay = options.enablePrepperCacheHUDDisplay;
		hudDisplayDuration = options.hudDisplayDuration;
		enablePrepperCacheWorldMapDisplay = options.enablePrepperCacheWorldMapDisplay;
	}

	static Settings()
	{
		waitTime = 60;
		enablePrepperCacheDataCapture = false;
		enablePrepperCacheHUDDisplay = true;
		hudDisplayDuration = 10;
		enablePrepperCacheWorldMapDisplay = true;
	}
}
