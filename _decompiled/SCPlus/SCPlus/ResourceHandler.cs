using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography;

namespace SCPlus;

internal class ResourceHandler
{
	public static string? LoadEmbeddedJSON(string name)
	{
		name = "SafehouseCustomizationPlus.Resources." + name;
		string result = null;
		Stream manifestResourceStream = Assembly.GetExecutingAssembly().GetManifestResourceStream(name);
		if (manifestResourceStream != null)
		{
			result = new StreamReader(manifestResourceStream).ReadToEnd();
		}
		return result;
	}

	public static void ExtractFolderFromResources(string targetFolder, string resourceFolder, bool overwrite = false)
	{
		Stopwatch stopwatch = new Stopwatch();
		stopwatch.Start();
		if (Directory.Exists(targetFolder) && !overwrite)
		{
			return;
		}
		Directory.CreateDirectory(targetFolder);
		Assembly executingAssembly = Assembly.GetExecutingAssembly();
		string[] manifestResourceNames = executingAssembly.GetManifestResourceNames();
		foreach (string text in manifestResourceNames)
		{
			if (!text.Contains(resourceFolder + "."))
			{
				continue;
			}
			string text2 = text.Substring(text.IndexOf(resourceFolder + ".") + resourceFolder.Length + 1);
			int num = text2.LastIndexOf('.');
			if (num == -1)
			{
				continue;
			}
			string text3 = text2.Substring(0, num);
			string text4 = text2.Substring(num + 1);
			string text5 = Path.Combine(targetFolder, text3.Replace('.', Path.DirectorySeparatorChar) + "." + text4);
			string directoryName = Path.GetDirectoryName(text5);
			if (!Directory.Exists(directoryName))
			{
				Directory.CreateDirectory(directoryName);
			}
			using Stream stream = executingAssembly.GetManifestResourceStream(text);
			if (!File.Exists(text5) || !AreFilesIdentical(stream, text5))
			{
				stream.Position = 0L;
				using FileStream destination = new FileStream(text5, FileMode.Create, FileAccess.Write);
				stream.CopyTo(destination);
			}
		}
		stopwatch.Stop();
		Utility.Log(ConsoleColor.Blue, $"SC+ Data extraction pass: {stopwatch.ElapsedMilliseconds} ms ({stopwatch.ElapsedTicks} ticks)");
	}

	private static bool AreFilesIdentical(Stream resourceStream, string filePath)
	{
		using SHA256 sHA = SHA256.Create();
		byte[] first = sHA.ComputeHash(resourceStream);
		resourceStream.Position = 0L;
		byte[] second;
		using (FileStream inputStream = File.OpenRead(filePath))
		{
			second = sHA.ComputeHash(inputStream);
		}
		return first.SequenceEqual(second);
	}
}
