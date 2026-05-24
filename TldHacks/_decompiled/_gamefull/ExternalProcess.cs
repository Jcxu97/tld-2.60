using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected;

[Token(Token = "0x2000A04")]
public static class ExternalProcess
{
	[Token(Token = "0x2000A05")]
	private struct PROCESS_INFORMATION
	{
		[Token(Token = "0x40065A2")]
		[Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		internal IntPtr hProcess;

		[Token(Token = "0x40065A3")]
		[Cpp2ILInjected.FieldOffset(Offset = "0x8")]
		internal IntPtr hThread;

		[Token(Token = "0x40065A4")]
		[Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		internal uint dwProcessId;

		[Token(Token = "0x40065A5")]
		[Cpp2ILInjected.FieldOffset(Offset = "0x14")]
		internal uint dwThreadId;
	}

	[Token(Token = "0x2000A06")]
	private struct STARTUPINFO
	{
		[Token(Token = "0x40065A6")]
		[Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		internal uint cb;

		[Token(Token = "0x40065A7")]
		[Cpp2ILInjected.FieldOffset(Offset = "0x8")]
		internal IntPtr lpReserved;

		[Token(Token = "0x40065A8")]
		[Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		internal IntPtr lpDesktop;

		[Token(Token = "0x40065A9")]
		[Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		internal IntPtr lpTitle;

		[Token(Token = "0x40065AA")]
		[Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		internal uint dwX;

		[Token(Token = "0x40065AB")]
		[Cpp2ILInjected.FieldOffset(Offset = "0x24")]
		internal uint dwY;

		[Token(Token = "0x40065AC")]
		[Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		internal uint dwXSize;

		[Token(Token = "0x40065AD")]
		[Cpp2ILInjected.FieldOffset(Offset = "0x2C")]
		internal uint dwYSize;

		[Token(Token = "0x40065AE")]
		[Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		internal uint dwXCountChars;

		[Token(Token = "0x40065AF")]
		[Cpp2ILInjected.FieldOffset(Offset = "0x34")]
		internal uint dwYCountChars;

		[Token(Token = "0x40065B0")]
		[Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		internal uint dwFillAttribute;

		[Token(Token = "0x40065B1")]
		[Cpp2ILInjected.FieldOffset(Offset = "0x3C")]
		internal uint dwFlags;

		[Token(Token = "0x40065B2")]
		[Cpp2ILInjected.FieldOffset(Offset = "0x40")]
		internal ushort wShowWindow;

		[Token(Token = "0x40065B3")]
		[Cpp2ILInjected.FieldOffset(Offset = "0x42")]
		internal ushort cbReserved2;

		[Token(Token = "0x40065B4")]
		[Cpp2ILInjected.FieldOffset(Offset = "0x48")]
		internal IntPtr lpReserved2;

		[Token(Token = "0x40065B5")]
		[Cpp2ILInjected.FieldOffset(Offset = "0x50")]
		internal IntPtr hStdInput;

		[Token(Token = "0x40065B6")]
		[Cpp2ILInjected.FieldOffset(Offset = "0x58")]
		internal IntPtr hStdOutput;

		[Token(Token = "0x40065B7")]
		[Cpp2ILInjected.FieldOffset(Offset = "0x60")]
		internal IntPtr hStdError;
	}

	[Flags]
	[Token(Token = "0x2000A07")]
	private enum ProcessCreationFlags : uint
	{
		[Token(Token = "0x40065B9")]
		NONE = 0u,
		[Token(Token = "0x40065BA")]
		CREATE_BREAKAWAY_FROM_JOB = 0x1000000u,
		[Token(Token = "0x40065BB")]
		CREATE_DEFAULT_ERROR_MODE = 0x4000000u,
		[Token(Token = "0x40065BC")]
		CREATE_NEW_CONSOLE = 0x10u,
		[Token(Token = "0x40065BD")]
		CREATE_NEW_PROCESS_GROUP = 0x200u,
		[Token(Token = "0x40065BE")]
		CREATE_NO_WINDOW = 0x8000000u,
		[Token(Token = "0x40065BF")]
		CREATE_PROTECTED_PROCESS = 0x40000u,
		[Token(Token = "0x40065C0")]
		CREATE_PRESERVE_CODE_AUTHZ_LEVEL = 0x2000000u,
		[Token(Token = "0x40065C1")]
		CREATE_SECURE_PROCESS = 0x400000u,
		[Token(Token = "0x40065C2")]
		CREATE_SEPARATE_WOW_VDM = 0x800u,
		[Token(Token = "0x40065C3")]
		CREATE_SHARED_WOW_VDM = 0x1000u,
		[Token(Token = "0x40065C4")]
		CREATE_SUSPENDED = 4u,
		[Token(Token = "0x40065C5")]
		CREATE_UNICODE_ENVIRONMENT = 0x400u,
		[Token(Token = "0x40065C6")]
		DEBUG_ONLY_THIS_PROCESS = 2u,
		[Token(Token = "0x40065C7")]
		DEBUG_PROCESS = 1u,
		[Token(Token = "0x40065C8")]
		DETACHED_PROCESS = 8u,
		[Token(Token = "0x40065C9")]
		EXTENDED_STARTUPINFO_PRESENT = 0x80000u,
		[Token(Token = "0x40065CA")]
		INHERIT_PARENT_AFFINITY = 0x10000u
	}

	[PreserveSig]
	[Token(Token = "0x6005833")]
	[Address(RVA = "0xEE1820", Offset = "0xEE0620", Length = "0x131")]
	private static extern bool CreateProcessW(string lpApplicationName, [In] string lpCommandLine, IntPtr procSecAttrs, IntPtr threadSecAttrs, bool bInheritHandles, ProcessCreationFlags dwCreationFlags, IntPtr lpEnvironment, string lpCurrentDirectory, ref STARTUPINFO lpStartupInfo, ref PROCESS_INFORMATION lpProcessInformation);

	[Token(Token = "0x6005834")]
	[Address(RVA = "0xEE1960", Offset = "0xEE0760", Length = "0x229")]
	public static bool RunCommand(string command, string args, string workingDirectory)
	{
		return false;
	}

	[Token(Token = "0x6005835")]
	[Address(RVA = "0xEE1B90", Offset = "0xEE0990", Length = "0x1B7")]
	public static bool RunCommand(string command, string workingDirectory)
	{
		return false;
	}
}
