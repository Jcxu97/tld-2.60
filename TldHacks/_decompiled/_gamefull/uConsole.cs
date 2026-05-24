using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x2000A91")]
public class uConsole : MonoBehaviour
{
	[Token(Token = "0x2000A92")]
	public delegate void DebugCommand();

	[Token(Token = "0x2000A93")]
	public delegate object DebugCommandReturn();

	[Token(Token = "0x2000A94")]
	public struct CommandDelegate
	{
		[Token(Token = "0x400683D")]
		[FieldOffset(Offset = "0x0")]
		private DebugCommand m_Command;

		[Token(Token = "0x400683E")]
		[FieldOffset(Offset = "0x8")]
		private DebugCommandReturn m_CommandReturn;

		[Token(Token = "0x6005BE6")]
		[Address(RVA = "0xF34360", Offset = "0xF33160", Length = "0xAA")]
		public CommandDelegate(DebugCommand cmd)
		{
			m_Command = null;
			m_CommandReturn = null;
		}

		[Token(Token = "0x6005BE7")]
		[Address(RVA = "0xF34410", Offset = "0xF33210", Length = "0xAA")]
		public CommandDelegate(DebugCommandReturn cmd)
		{
			m_Command = null;
			m_CommandReturn = null;
		}

		[Token(Token = "0x6005BE8")]
		[Address(RVA = "0xF344C0", Offset = "0xF332C0", Length = "0x12")]
		public bool IsValid()
		{
			return false;
		}

		[Token(Token = "0x6005BE9")]
		[Address(RVA = "0xF344E0", Offset = "0xF332E0", Length = "0x42")]
		public object Call()
		{
			return null;
		}
	}

	[Range(0f, 1f)]
	[Token(Token = "0x4006818")]
	[FieldOffset(Offset = "0x20")]
	public float m_ConsoleHeightNormalized;

	[Token(Token = "0x4006819")]
	[FieldOffset(Offset = "0x24")]
	public float m_SecondsToAnimateDown;

	[Token(Token = "0x400681A")]
	[FieldOffset(Offset = "0x28")]
	public float m_SecondsToAnimateUp;

	[Token(Token = "0x400681B")]
	[FieldOffset(Offset = "0x2C")]
	public int m_MaxHistoryLines;

	[Token(Token = "0x400681C")]
	[FieldOffset(Offset = "0x30")]
	public int m_MaxLogLines;

	[Token(Token = "0x400681D")]
	[FieldOffset(Offset = "0x34")]
	public bool m_DoNotDestroy;

	[Token(Token = "0x400681E")]
	[FieldOffset(Offset = "0x35")]
	public bool m_LogUnityMessages;

	[Token(Token = "0x400681F")]
	[FieldOffset(Offset = "0x36")]
	public bool m_ForceUnityLegacyGUI;

	[Token(Token = "0x4006820")]
	[FieldOffset(Offset = "0x38")]
	public Font m_LogFont;

	[Token(Token = "0x4006821")]
	[FieldOffset(Offset = "0x40")]
	public int m_LogFontSize;

	[Token(Token = "0x4006822")]
	[FieldOffset(Offset = "0x44")]
	public Color m_LogBackGroundColor;

	[Token(Token = "0x4006823")]
	[FieldOffset(Offset = "0x54")]
	public Color m_LogFontColor;

	[Token(Token = "0x4006824")]
	[FieldOffset(Offset = "0x64")]
	public int m_LogXOffset;

	[Token(Token = "0x4006825")]
	[FieldOffset(Offset = "0x68")]
	public int m_LogYOffsetFromTopOfInputField;

	[Token(Token = "0x4006826")]
	[FieldOffset(Offset = "0x70")]
	public Font m_InputFieldFont;

	[Token(Token = "0x4006827")]
	[FieldOffset(Offset = "0x78")]
	public int m_InputFieldFontSize;

	[Token(Token = "0x4006828")]
	[FieldOffset(Offset = "0x7C")]
	public Color m_InputFieldBackGroundColor;

	[Token(Token = "0x4006829")]
	[FieldOffset(Offset = "0x8C")]
	public Color m_InputFieldFontColor;

	[Token(Token = "0x400682A")]
	[FieldOffset(Offset = "0x9C")]
	public int m_InputFieldXOffset;

	[Token(Token = "0x400682B")]
	[FieldOffset(Offset = "0xA0")]
	public int m_InputFieldPaddedPixelsTop;

	[Token(Token = "0x400682C")]
	[FieldOffset(Offset = "0xA4")]
	public int m_InputFieldPaddedPixelsBottom;

	[Token(Token = "0x400682D")]
	[FieldOffset(Offset = "0xA8")]
	public KeyCode m_Activate;

	[Token(Token = "0x400682E")]
	[FieldOffset(Offset = "0xAC")]
	public KeyCode m_Submit;

	[Token(Token = "0x400682F")]
	[FieldOffset(Offset = "0xB0")]
	public KeyCode m_AutoComplete;

	[Token(Token = "0x4006830")]
	[FieldOffset(Offset = "0xB4")]
	public KeyCode m_HistoryUp;

	[Token(Token = "0x4006831")]
	[FieldOffset(Offset = "0xB8")]
	public KeyCode m_HistoryDown;

	[Token(Token = "0x4006832")]
	[FieldOffset(Offset = "0xBC")]
	public KeyCode m_ScrollLogUp;

	[Token(Token = "0x4006833")]
	[FieldOffset(Offset = "0xC0")]
	public KeyCode m_ScrollLogDown;

	[Token(Token = "0x4006834")]
	public static uConsole m_Instance;

	[Token(Token = "0x4006835")]
	public static uConsoleGUI m_GUI;

	[Token(Token = "0x4006836")]
	public static Dictionary<string, CommandDelegate> m_CommandsDict;

	[Token(Token = "0x4006837")]
	public static List<string> m_CommandsList;

	[Token(Token = "0x4006838")]
	public static Dictionary<string, string> m_CommandsHelp;

	[Token(Token = "0x4006839")]
	public static string m_Version;

	[Token(Token = "0x400683A")]
	private static List<string> m_Argv;

	[Token(Token = "0x400683B")]
	private static int m_IndexOfNextArgToProcess;

	[Token(Token = "0x400683C")]
	private static bool m_On;

	[Token(Token = "0x6005BB9")]
	[Address(RVA = "0xF2FD80", Offset = "0xF2EB80", Length = "0x241")]
	private void Awake()
	{
	}

	[Token(Token = "0x6005BBA")]
	[Address(RVA = "0xF2FFD0", Offset = "0xF2EDD0", Length = "0x39B")]
	private void Start()
	{
	}

	[Token(Token = "0x6005BBB")]
	[Address(RVA = "0xF30370", Offset = "0xF2F170", Length = "0x45")]
	private void Update()
	{
	}

	[Token(Token = "0x6005BBC")]
	[Address(RVA = "0xF303C0", Offset = "0xF2F1C0", Length = "0x212")]
	public static void RegisterCommand(string command, DebugCommand commandCallback)
	{
	}

	[Token(Token = "0x6005BBD")]
	[Address(RVA = "0xF305E0", Offset = "0xF2F3E0", Length = "0x279")]
	public static void RegisterCommand(string command, string help, DebugCommand commandCallback)
	{
	}

	[Token(Token = "0x6005BBE")]
	[Address(RVA = "0xF30860", Offset = "0xF2F660", Length = "0x212")]
	public static void RegisterCommandReturn(string command, DebugCommandReturn commandCallback)
	{
	}

	[Token(Token = "0x6005BBF")]
	[Address(RVA = "0xF30A80", Offset = "0xF2F880", Length = "0x279")]
	public static void RegisterCommandReturn(string command, string help, DebugCommandReturn commandCallback)
	{
	}

	[Token(Token = "0x6005BC0")]
	[Address(RVA = "0xF30D00", Offset = "0xF2FB00", Length = "0x2A8")]
	public static void UnRegisterCommand(string command)
	{
	}

	[Token(Token = "0x6005BC1")]
	[Address(RVA = "0xF30FB0", Offset = "0xF2FDB0", Length = "0x535")]
	public static object RunCommand(string commandWithArgs)
	{
		return null;
	}

	[Token(Token = "0x6005BC2")]
	[Address(RVA = "0xF314F0", Offset = "0xF302F0", Length = "0x3CA")]
	public static object RunCommandSilent(string commandWithArgs)
	{
		return null;
	}

	[Token(Token = "0x6005BC3")]
	[Address(RVA = "0xF318C0", Offset = "0xF306C0", Length = "0x4E")]
	public static void Log(string text)
	{
	}

	[Token(Token = "0x6005BC4")]
	[Address(RVA = "0xF31910", Offset = "0xF30710", Length = "0x54")]
	public static void TurnOn()
	{
	}

	[Token(Token = "0x6005BC5")]
	[Address(RVA = "0xF31970", Offset = "0xF30770", Length = "0x54")]
	public static void TurnOff()
	{
	}

	[Token(Token = "0x6005BC6")]
	[Address(RVA = "0xF319D0", Offset = "0xF307D0", Length = "0x54")]
	public static bool IsOn()
	{
		return false;
	}

	[Token(Token = "0x6005BC7")]
	[Address(RVA = "0xF31A30", Offset = "0xF30830", Length = "0x232")]
	public static bool CommandIsUnabmiguousAutoComplete(string command)
	{
		return false;
	}

	[Token(Token = "0x6005BC8")]
	[Address(RVA = "0xF31C70", Offset = "0xF30A70", Length = "0x1E2")]
	public static void ShowHelp(string command)
	{
	}

	[Token(Token = "0x6005BC9")]
	[Address(RVA = "0xF31E60", Offset = "0xF30C60", Length = "0x74")]
	public static int GetNumParameters()
	{
		return 0;
	}

	[Token(Token = "0x6005BCA")]
	[Address(RVA = "0xF31EE0", Offset = "0xF30CE0", Length = "0x1AE")]
	public static List<string> GetAllParameters()
	{
		return null;
	}

	[Token(Token = "0x6005BCB")]
	[Address(RVA = "0xF32090", Offset = "0xF30E90", Length = "0x1F8")]
	public static bool NextParameterIsBool()
	{
		return false;
	}

	[Token(Token = "0x6005BCC")]
	[Address(RVA = "0xF32290", Offset = "0xF31090", Length = "0x1DB")]
	public static bool GetBool()
	{
		return false;
	}

	[Token(Token = "0x6005BCD")]
	[Address(RVA = "0xF32470", Offset = "0xF31270", Length = "0x1C4")]
	public static bool NextParameterIsInt()
	{
		return false;
	}

	[Token(Token = "0x6005BCE")]
	[Address(RVA = "0xF32640", Offset = "0xF31440", Length = "0x1E4")]
	public static int GetInt()
	{
		return 0;
	}

	[Token(Token = "0x6005BCF")]
	[Address(RVA = "0xF32830", Offset = "0xF31630", Length = "0x188")]
	public static bool NextParameterIsFloat()
	{
		return false;
	}

	[Token(Token = "0x6005BD0")]
	[Address(RVA = "0xF329C0", Offset = "0xF317C0", Length = "0x1B0")]
	public static float GetFloat()
	{
		return 0f;
	}

	[Token(Token = "0x6005BD1")]
	[Address(RVA = "0xF32B80", Offset = "0xF31980", Length = "0x1AB")]
	public static bool TryGetFloat(out float f)
	{
		f = default(float);
		return false;
	}

	[Token(Token = "0x6005BD2")]
	[Address(RVA = "0xF32D30", Offset = "0xF31B30", Length = "0xEC")]
	public static bool TryGetVector3(out Vector3 v)
	{
		v = default(Vector3);
		return false;
	}

	[Token(Token = "0x6005BD3")]
	[Address(RVA = "0xF32E20", Offset = "0xF31C20", Length = "0x78")]
	public static bool NextParameterExists()
	{
		return false;
	}

	[Token(Token = "0x6005BD4")]
	[Address(RVA = "0xF32EA0", Offset = "0xF31CA0", Length = "0xF3")]
	public static string GetString()
	{
		return null;
	}

	[Token(Token = "0x6005BD5")]
	[Address(RVA = "0xF32FA0", Offset = "0xF31DA0", Length = "0x72")]
	private void OnApplicationQuit()
	{
	}

	[Token(Token = "0x6005BD6")]
	[Address(RVA = "0xF33020", Offset = "0xF31E20", Length = "0x3CA")]
	private static void BuildArgListFromTokens(string[] tokens)
	{
	}

	[Token(Token = "0x6005BD7")]
	[Address(RVA = "0xF333F0", Offset = "0xF321F0", Length = "0x185")]
	private static bool CommandAlreadyRegistered(string command)
	{
		return false;
	}

	[Token(Token = "0x6005BD8")]
	[Address(RVA = "0xF33580", Offset = "0xF32380", Length = "0x2B3")]
	private void InstantiateGUIPrefab()
	{
	}

	[Token(Token = "0x6005BD9")]
	[Address(RVA = "0xF33840", Offset = "0xF32640", Length = "0x95")]
	private static bool CommandAndParameterRegistered(string command, string parameter)
	{
		return false;
	}

	[Token(Token = "0x6005BDA")]
	[Address(RVA = "0xF338E0", Offset = "0xF326E0", Length = "0x329")]
	private static bool CommandIsRegistered(string command)
	{
		return false;
	}

	[Token(Token = "0x6005BDB")]
	[Address(RVA = "0xF33C10", Offset = "0xF32A10", Length = "0x271")]
	private static bool ParameterIsRegistered(string command, string parameter)
	{
		return false;
	}

	[Token(Token = "0x6005BDC")]
	[Address(RVA = "0xF33E90", Offset = "0xF32C90", Length = "0xEE")]
	public uConsole()
	{
	}
}
