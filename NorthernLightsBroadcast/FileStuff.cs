using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using MelonLoader;
using UnityEngine;

namespace NorthernLightsBroadcast;

public static class FileStuff
{
	public static string settingsFile = Application.dataPath + "/../Mods/NorthernLightsBroadcast_ResumeAtFrame.ini";

	public static Dictionary<string, double> clipFrames = new Dictionary<string, double>();

	public static FileStream frameFile;

	public static List<string> videoFileExtensions = new List<string>
	{
		".asf", ".avi", ".dv", ".m4v", ".mov", ".mp4", ".mpg", ".mpeg", ".ogv", ".vp8",
		".webm", ".wmv"
	};

	public static void OpenFrameFile()
	{
		// v2.1.1: 这个方法在 OnInitializeMelon 里跑,以前任何一行坏数据都会抛,
		// 抛了整个 mod 起不来(一台电视都没有)。三个坑:
		//   1) Split 完直接取 [1],没有 | 的行下标越界
		//   2) float.Parse 跟系统区域走,德语/法语系统上小数点是逗号,解析失败
		//   3) 同一个路径出现两次,Dictionary.Add 抛重复键
		// 现在逐行 try,坏行跳过。
		try
		{
			if (!File.Exists(settingsFile))
			{
				frameFile = File.Create(settingsFile);
				frameFile.Close();
			}
			string[] array = File.ReadAllLines(settingsFile);
			foreach (string obj in array)
			{
				try
				{
					if (string.IsNullOrWhiteSpace(obj)) continue;
					int cut = obj.LastIndexOf('|');
					if (cut <= 0 || cut == obj.Length - 1) continue;
					string key = obj.Substring(0, cut);
					if (!float.TryParse(obj.Substring(cut + 1), NumberStyles.Float, CultureInfo.InvariantCulture, out float seconds))
						continue;
					if (seconds < 0f) seconds = 0f;
					clipFrames[key] = (long)seconds;
				}
				catch { }
			}
		}
		catch (Exception ex)
		{
			MelonLogger.Warning("[NLB] 读取播放进度文件失败,从空进度开始: " + ex.Message);
		}
	}

	public static void AddFrameValueToFile(string clipName, double frameValue)
	{
		double num = frameValue;
		if (num < 0.0)
		{
			num = 0.0;
		}
		if (clipFrames.ContainsKey(clipName))
		{
			clipFrames[clipName] = num;
		}
		else
		{
			clipFrames.Add(clipName, num);
		}
	}

	public static double GetFrameValueFromFile(string clipName)
	{
		if (clipFrames.ContainsKey(clipName))
		{
			return clipFrames[clipName];
		}
		AddFrameValueToFile(clipName, 0.0);
		return 0.0;
	}

	public static void SaveFrameFile()
	{
		// v2.1.1: 数字按固定区域写,否则德语系统写出 "12,5" 而读的时候按小数点解析,进度全丢
		try
		{
			using StreamWriter streamWriter = new StreamWriter(settingsFile);
			foreach (KeyValuePair<string, double> clipFrame in clipFrames)
			{
				double num = clipFrame.Value;
				if (num < 0.0)
				{
					num = 0.0;
				}
				streamWriter.WriteLine(clipFrame.Key + "|" + num.ToString(CultureInfo.InvariantCulture));
			}
			streamWriter.Close();
		}
		catch (Exception ex)
		{
			MelonLogger.Warning("[NLB] 保存播放进度失败: " + ex.Message);
		}
	}

	public static string[] GetFilesInPath(string path)
	{
		List<string> list = new List<string>();
		try
		{
			string[] files = Directory.GetFiles(path, "*", SearchOption.TopDirectoryOnly);
			foreach (string text in files)
			{
				if (videoFileExtensions.Contains(Path.GetExtension(text).ToLowerInvariant()))
				{
					list.Add(text);
				}
			}
		}
		catch { /* permission denied / IO error — return whatever we got */ }
		return list.ToArray();
	}

	public static string[] GetFoldersInPath(string path)
	{
		// v2.0.6.1: 逐项处理,跳过无权限/junction(如 C:\Documents and Settings)
		List<string> list = new List<string>();
		try
		{
			foreach (string dir in Directory.EnumerateDirectories(path, "*", SearchOption.TopDirectoryOnly))
			{
				try
				{
					DirectoryInfo info = new DirectoryInfo(dir);
					if ((info.Attributes & FileAttributes.ReparsePoint) != 0) continue; // skip junctions
					list.Add(dir);
				}
				catch { /* skip individual unreachable dirs */ }
			}
		}
		catch { /* parent path itself unreadable */ }
		return list.ToArray();
	}
}
