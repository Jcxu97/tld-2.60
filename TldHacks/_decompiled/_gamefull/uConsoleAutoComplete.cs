using System.Collections.Generic;
using Cpp2ILInjected;

[Token(Token = "0x2000A96")]
public class uConsoleAutoComplete
{
	[Token(Token = "0x4006841")]
	public static List<uConsoleCommandParameterSet> m_CommandParameterSets;

	[Token(Token = "0x6005BEB")]
	[Address(RVA = "0xF34530", Offset = "0xF33330", Length = "0x109")]
	public static void CreateCommandParameterSet(string command, List<string> parameters)
	{
	}

	[Token(Token = "0x6005BEC")]
	[Address(RVA = "0xF34640", Offset = "0xF33440", Length = "0x1AF")]
	public static void CreateCommandParameterSet(List<string> commands, List<string> parameters)
	{
	}

	[Token(Token = "0x6005BED")]
	[Address(RVA = "0xF347F0", Offset = "0xF335F0", Length = "0x1D1")]
	public static string GetBestCompletion(string partialCommand)
	{
		return null;
	}

	[Token(Token = "0x6005BEE")]
	[Address(RVA = "0xF349D0", Offset = "0xF337D0", Length = "0x1C4")]
	public static void DisplayPossibleMatches(string command)
	{
	}

	[Token(Token = "0x6005BEF")]
	[Address(RVA = "0xF34BA0", Offset = "0xF339A0", Length = "0x1D5")]
	public static void DisplayStringsStartingWithMatch(string match, List<string> list)
	{
	}

	[Token(Token = "0x6005BF0")]
	[Address(RVA = "0xF34D80", Offset = "0xF33B80", Length = "0x1D3")]
	private static void DisplayParametersStartingWithMatch(string command, string parameter)
	{
	}

	[Token(Token = "0x6005BF1")]
	[Address(RVA = "0xF34F60", Offset = "0xF33D60", Length = "0x15A")]
	private static bool CommonCharacterAtIndex(int index, List<string> strings)
	{
		return false;
	}

	[Token(Token = "0x6005BF2")]
	[Address(RVA = "0xF350C0", Offset = "0xF33EC0", Length = "0x2F1")]
	private static string GetBestMatchFromList(string pattern, List<string> list)
	{
		return null;
	}

	[Token(Token = "0x6005BF3")]
	[Address(RVA = "0xF353C0", Offset = "0xF341C0", Length = "0x1FD")]
	private static string GetBestCommandWithParameterCompletion(string command, string partialParameter)
	{
		return null;
	}

	[Token(Token = "0x6005BF4")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public uConsoleAutoComplete()
	{
	}
}
