using System;
using System.Collections.Generic;
using System.Diagnostics;
using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x20009FD")]
public class DebugUtils
{
	[Token(Token = "0x20009FE")]
	public enum TransformColor
	{
		[Token(Token = "0x4006595")]
		RGB,
		[Token(Token = "0x4006596")]
		CMY,
		[Token(Token = "0x4006597")]
		BGW
	}

	[Token(Token = "0x400658C")]
	private static Dictionary<string, bool> s_ErrorTrack;

	[Token(Token = "0x400658D")]
	private static bool s_PreviousPauseState;

	[Token(Token = "0x400658E")]
	private static int s_ErrorMessageCount;

	[Token(Token = "0x400658F")]
	private static string s_Filename;

	[Token(Token = "0x4006590")]
	private static string s_LineNumber;

	[Token(Token = "0x4006591")]
	private static float[,] s_HermitePatchCurveHeights;

	[Token(Token = "0x4006592")]
	private static Dictionary<LoggingFilter, string> s_LoggingFilterDisplayNames;

	[Token(Token = "0x4006593")]
	private static DateTime simpleTimerStartTime;

	[Token(Token = "0x60057D7")]
	[Address(RVA = "0xEDA570", Offset = "0xED9370", Length = "0x14C")]
	private static string GetLoggingFilterName(LoggingFilter filter)
	{
		return null;
	}

	[Token(Token = "0x60057D8")]
	[Address(RVA = "0xEDA6C0", Offset = "0xED94C0", Length = "0x7A")]
	private static string MaybeTruncateErrorMessage(string value, int maxLength)
	{
		return null;
	}

	[Token(Token = "0x60057D9")]
	[Address(RVA = "0xEDA740", Offset = "0xED9540", Length = "0x806")]
	private static void MaybeShowMessagePanel(string messageType, string message)
	{
	}

	[Token(Token = "0x60057DA")]
	[Address(RVA = "0xEDAF50", Offset = "0xED9D50", Length = "0x17A")]
	public static void ResumeGameAfterError()
	{
	}

	[Conditional("__DEBUG")]
	[HideInCallstack]
	[Token(Token = "0x60057DB")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public static void Unimplemented()
	{
	}

	[Conditional("__DEBUG")]
	[HideInCallstack]
	[Token(Token = "0x60057DC")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public static void Unimplemented(LoggingFilter filter)
	{
	}

	[Conditional("__DEBUG")]
	[HideInCallstack]
	[Token(Token = "0x60057DD")]
	[Address(RVA = "0xEDB0D0", Offset = "0xED9ED0", Length = "0x86")]
	public static void Assert(bool condition)
	{
	}

	[Conditional("__DEBUG")]
	[HideInCallstack]
	[Token(Token = "0x60057DE")]
	[Address(RVA = "0xEDB160", Offset = "0xED9F60", Length = "0x86")]
	public static void Assert(bool condition, UnityEngine.Object context)
	{
	}

	[Conditional("__DEBUG")]
	[HideInCallstack]
	[Token(Token = "0x60057DF")]
	[Address(RVA = "0xEDB1F0", Offset = "0xED9FF0", Length = "0x78")]
	public static void Assert(bool condition, string output)
	{
	}

	[Conditional("__DEBUG")]
	[HideInCallstack]
	[Token(Token = "0x60057E0")]
	[Address(RVA = "0xEDB270", Offset = "0xEDA070", Length = "0x78")]
	public static void Assert(bool condition, string output, UnityEngine.Object context)
	{
	}

	[Conditional("__DEBUG")]
	[HideInCallstack]
	[Token(Token = "0x60057E1")]
	[Address(RVA = "0xEDB2F0", Offset = "0xEDA0F0", Length = "0x12A")]
	public static void AssertFormat(bool condition, string output, params object[] args)
	{
	}

	[Conditional("__DEBUG")]
	[HideInCallstack]
	[Token(Token = "0x60057E2")]
	[Address(RVA = "0xEDB420", Offset = "0xEDA220", Length = "0x12A")]
	public static void AssertFormat(bool condition, UnityEngine.Object context, string output, params object[] args)
	{
	}

	[Conditional("__DEBUG")]
	[HideInCallstack]
	[Token(Token = "0x60057E3")]
	[Address(RVA = "0xEDB550", Offset = "0xEDA350", Length = "0x4E")]
	public static void Log(string message)
	{
	}

	[Conditional("__DEBUG")]
	[HideInCallstack]
	[Token(Token = "0x60057E4")]
	[Address(RVA = "0xEDB5A0", Offset = "0xEDA3A0", Length = "0x150")]
	public static void Log(LoggingFilter filter, string message)
	{
	}

	[Conditional("__DEBUG")]
	[HideInCallstack]
	[Token(Token = "0x60057E5")]
	[Address(RVA = "0xEDB700", Offset = "0xEDA500", Length = "0x5E")]
	public static void Log(string message, UnityEngine.Object context)
	{
	}

	[Conditional("__DEBUG")]
	[HideInCallstack]
	[Token(Token = "0x60057E6")]
	[Address(RVA = "0xEDB760", Offset = "0xEDA560", Length = "0x19E")]
	public static void Log(LoggingFilter filter, string message, UnityEngine.Object context)
	{
	}

	[Conditional("__DEBUG")]
	[HideInCallstack]
	[Token(Token = "0x60057E7")]
	[Address(RVA = "0xEDB900", Offset = "0xEDA700", Length = "0x5E")]
	public static void LogFormat(string message, params object[] args)
	{
	}

	[Conditional("__DEBUG")]
	[HideInCallstack]
	[Token(Token = "0x60057E8")]
	[Address(RVA = "0xEDB960", Offset = "0xEDA760", Length = "0xFB")]
	public static void LogFormat(LoggingFilter filter, string message, params object[] args)
	{
	}

	[Conditional("__DEBUG")]
	[HideInCallstack]
	[Token(Token = "0x60057E9")]
	[Address(RVA = "0xEDBA60", Offset = "0xEDA860", Length = "0x6E")]
	public static void LogFormat(UnityEngine.Object context, string message, params object[] args)
	{
	}

	[Conditional("__DEBUG")]
	[HideInCallstack]
	[Token(Token = "0x60057EA")]
	[Address(RVA = "0xEDBAD0", Offset = "0xEDA8D0", Length = "0x10E")]
	public static void LogFormat(LoggingFilter filter, UnityEngine.Object context, string message, params object[] args)
	{
	}

	[Conditional("__DEBUG")]
	[HideInCallstack]
	[Token(Token = "0x60057EB")]
	[Address(RVA = "0xEDBBE0", Offset = "0xEDA9E0", Length = "0x4E")]
	public static void LogWarning(string message)
	{
	}

	[Conditional("__DEBUG")]
	[HideInCallstack]
	[Token(Token = "0x60057EC")]
	[Address(RVA = "0xEDBC30", Offset = "0xEDAA30", Length = "0x150")]
	public static void LogWarning(LoggingFilter filter, string message)
	{
	}

	[Conditional("__DEBUG")]
	[HideInCallstack]
	[Token(Token = "0x60057ED")]
	[Address(RVA = "0xEDBD90", Offset = "0xEDAB90", Length = "0x5E")]
	public static void LogWarning(string message, UnityEngine.Object context)
	{
	}

	[Conditional("__DEBUG")]
	[HideInCallstack]
	[Token(Token = "0x60057EE")]
	[Address(RVA = "0xEDBDF0", Offset = "0xEDABF0", Length = "0x160")]
	public static void LogWarning(LoggingFilter filter, UnityEngine.Object context, string message)
	{
	}

	[Conditional("__DEBUG")]
	[HideInCallstack]
	[Token(Token = "0x60057EF")]
	[Address(RVA = "0xEDBF60", Offset = "0xEDAD60", Length = "0x5E")]
	public static void LogWarningFormat(string message, params object[] args)
	{
	}

	[Conditional("__DEBUG")]
	[HideInCallstack]
	[Token(Token = "0x60057F0")]
	[Address(RVA = "0xEDBFC0", Offset = "0xEDADC0", Length = "0xFB")]
	public static void LogWarningFormat(LoggingFilter filter, string message, params object[] args)
	{
	}

	[Conditional("__DEBUG")]
	[HideInCallstack]
	[Token(Token = "0x60057F1")]
	[Address(RVA = "0xEDC0C0", Offset = "0xEDAEC0", Length = "0x6E")]
	public static void LogWarningFormat(UnityEngine.Object context, string message, params object[] args)
	{
	}

	[Conditional("__DEBUG")]
	[HideInCallstack]
	[Token(Token = "0x60057F2")]
	[Address(RVA = "0xEDC130", Offset = "0xEDAF30", Length = "0x10E")]
	public static void LogWarningFormat(LoggingFilter filter, UnityEngine.Object context, string message, params object[] args)
	{
	}

	[Conditional("__DEBUG")]
	[HideInCallstack]
	[Token(Token = "0x60057F3")]
	[Address(RVA = "0xEDC240", Offset = "0xEDB040", Length = "0x97")]
	public static void LogError(string message)
	{
	}

	[Conditional("__DEBUG")]
	[HideInCallstack]
	[Token(Token = "0x60057F4")]
	[Address(RVA = "0xEDC2E0", Offset = "0xEDB0E0", Length = "0x173")]
	public static void LogError(LoggingFilter filter, string message)
	{
	}

	[Conditional("__DEBUG")]
	[HideInCallstack]
	[Token(Token = "0x60057F5")]
	[Address(RVA = "0xEDC460", Offset = "0xEDB260", Length = "0xA7")]
	public static void LogError(string message, UnityEngine.Object context)
	{
	}

	[Conditional("__DEBUG")]
	[HideInCallstack]
	[Token(Token = "0x60057F6")]
	[Address(RVA = "0xEDC510", Offset = "0xEDB310", Length = "0x183")]
	public static void LogError(LoggingFilter filter, string message, UnityEngine.Object context)
	{
	}

	[Conditional("__DEBUG")]
	[HideInCallstack]
	[Token(Token = "0x60057F7")]
	[Address(RVA = "0xEDC6A0", Offset = "0xEDB4A0", Length = "0x159")]
	public static void LogErrorFormat(string message, params object[] args)
	{
	}

	[Conditional("__DEBUG")]
	[HideInCallstack]
	[Token(Token = "0x60057F8")]
	[Address(RVA = "0xEDC800", Offset = "0xEDB600", Length = "0x1E7")]
	public static void LogErrorFormat(LoggingFilter filter, string message, params object[] args)
	{
	}

	[Conditional("__DEBUG")]
	[HideInCallstack]
	[Token(Token = "0x60057F9")]
	[Address(RVA = "0xEDC9F0", Offset = "0xEDB7F0", Length = "0x16C")]
	public static void LogErrorFormat(UnityEngine.Object context, string message, params object[] args)
	{
	}

	[Conditional("__DEBUG")]
	[HideInCallstack]
	[Token(Token = "0x60057FA")]
	[Address(RVA = "0xEDCB60", Offset = "0xEDB960", Length = "0x1F6")]
	public static void LogErrorFormat(LoggingFilter filter, UnityEngine.Object context, string message, params object[] args)
	{
	}

	[Conditional("__DEBUG")]
	[HideInCallstack]
	[Token(Token = "0x60057FB")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public static void Watch(LoggingFilter filter, string name, string value)
	{
	}

	[Conditional("__DEBUG")]
	[HideInCallstack]
	[Token(Token = "0x60057FC")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public static void Watch(LoggingFilter filter, string name, float value, string format = "N3")
	{
	}

	[Conditional("__DEBUG")]
	[HideInCallstack]
	[Token(Token = "0x60057FD")]
	[Address(RVA = "0xEDCD60", Offset = "0xEDBB60", Length = "0x83")]
	public static void Watch(LoggingFilter filter, string name, Vector3 value, string format = "N3")
	{
	}

	[Conditional("__DEBUG")]
	[Token(Token = "0x60057FE")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public static void ShowPoint(Vector3 pos)
	{
	}

	[Conditional("__DEBUG")]
	[Token(Token = "0x60057FF")]
	[Address(RVA = "0xEDCDF0", Offset = "0xEDBBF0", Length = "0x618")]
	public static void ShowPoint(Vector3 pos, Color colour, float duration = 0f)
	{
	}

	[Conditional("__DEBUG")]
	[Token(Token = "0x6005800")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public static void ShowTransform(Transform trans)
	{
	}

	[Conditional("__DEBUG")]
	[Token(Token = "0x6005801")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public static void ShowTransform(Transform trans, TransformColor colourSet, float duration = 0f)
	{
	}

	[Conditional("__DEBUG")]
	[Token(Token = "0x6005802")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public static void ShowTransform(Matrix4x4 mat, float duration = 0f)
	{
	}

	[Conditional("__DEBUG")]
	[Token(Token = "0x6005803")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public static void ShowTransform(Matrix4x4 mat, TransformColor colourSet, float duration = 0f)
	{
	}

	[Conditional("__DEBUG")]
	[Token(Token = "0x6005804")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public static void ShowTransform(Vector3 pos, Quaternion rot, float duration = 0f)
	{
	}

	[Conditional("__DEBUG")]
	[Token(Token = "0x6005805")]
	[Address(RVA = "0xEDD410", Offset = "0xEDC210", Length = "0x8D")]
	public static void ShowTransform(Vector3 pos, Quaternion rot, TransformColor colourSet, float duration = 0f)
	{
	}

	[Conditional("__DEBUG")]
	[Token(Token = "0x6005806")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public static void ShowTransform(Vector3 pos, Matrix4x4 mat, float duration = 0f)
	{
	}

	[Conditional("__DEBUG")]
	[Token(Token = "0x6005807")]
	[Address(RVA = "0xEDD4A0", Offset = "0xEDC2A0", Length = "0x6A9")]
	public static void ShowTransform(Vector3 pos, Matrix4x4 mat, TransformColor colourSet, float duration = 0f)
	{
	}

	[Conditional("__DEBUG")]
	[Token(Token = "0x6005808")]
	[Address(RVA = "0xEDDB50", Offset = "0xEDC950", Length = "0x119")]
	public static void ShowBounds(Bounds bounds, Color colour, float duration = 0f)
	{
	}

	[Conditional("__DEBUG")]
	[Token(Token = "0x6005809")]
	[Address(RVA = "0xEDDC70", Offset = "0xEDCA70", Length = "0x1CB")]
	public static void ShowBounds(Transform transform, Vector3 size, Color colour, float duration = 0f)
	{
	}

	[Conditional("__DEBUG")]
	[Token(Token = "0x600580A")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public static void ShowBox(Transform transform, Vector3 size, Color colour, float duration = 0f)
	{
	}

	[Conditional("__DEBUG")]
	[Token(Token = "0x600580B")]
	[Address(RVA = "0xEDDE40", Offset = "0xEDCC40", Length = "0x1629")]
	public static void ShowBox(Matrix4x4 mat, Vector3 size, Color colour, float duration = 0f)
	{
	}

	[Conditional("__DEBUG")]
	[Token(Token = "0x600580C")]
	[Address(RVA = "0xEDF470", Offset = "0xEDE270", Length = "0x119")]
	public static void ShowSphere(Vector3 pos, Quaternion rot, float radius, Color colour, float duration = 0f)
	{
	}

	[Conditional("__DEBUG")]
	[Token(Token = "0x600580D")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public static void ShowSphere(Transform t, float radius, Color colour, float duration = 0f)
	{
	}

	[Conditional("__DEBUG")]
	[Token(Token = "0x600580E")]
	[Address(RVA = "0xEDF590", Offset = "0xEDE390", Length = "0x46A")]
	public static void ShowSphere(Matrix4x4 mat, float radius, Color colour, float duration = 0f)
	{
	}

	[Conditional("__DEBUG")]
	[Token(Token = "0x600580F")]
	[Address(RVA = "0xEDFA00", Offset = "0xEDE800", Length = "0x678")]
	public static void ShowFrustum(Plane[] planes, Color col)
	{
	}

	[Conditional("__DEBUG")]
	[Token(Token = "0x6005810")]
	[Address(RVA = "0xEE0080", Offset = "0xEDEE80", Length = "0xD11")]
	public static void ShowHermitePatch(Transform transform, Vector3[] hermiteCoefficients, Vector3 minPos, Vector3 maxPos, int subDivs, float yOffset, float duration = 0f)
	{
	}

	[Token(Token = "0x6005811")]
	[Address(RVA = "0xEE0DA0", Offset = "0xEDFBA0", Length = "0x95")]
	public static void SimpleTimerStart()
	{
	}

	[Token(Token = "0x6005812")]
	[Address(RVA = "0xEE0E40", Offset = "0xEDFC40", Length = "0x113")]
	public static float SimpleTimerGetElapsed()
	{
		return 0f;
	}

	[Token(Token = "0x6005813")]
	[Address(RVA = "0xEE0F60", Offset = "0xEDFD60", Length = "0x47D")]
	public static string GetGameObjectPath(GameObject go)
	{
		return null;
	}

	[Token(Token = "0x6005814")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public DebugUtils()
	{
	}
}
