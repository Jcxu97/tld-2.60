using System;
using System.Reflection;
using System.Text;
using Il2Cpp;
using TLD.TinyJSON;
using UnityEngine;

namespace SCPlus;

public static class Extensions
{
	public static bool TryGetGuid(this Container c, out string guid)
	{
		if ((bool)c.GetComponent<ObjectGuid>())
		{
			guid = c.GetComponent<ObjectGuid>().PDID;
			return true;
		}
		guid = Utility.missingGuid;
		return false;
	}

	public static string JsonDumpSkipDefaults<T>(this T obj)
	{
		if (obj == null)
		{
			return "null";
		}
		Type typeFromHandle = typeof(T);
		FieldInfo[] fields = typeFromHandle.GetFields(BindingFlags.Instance | BindingFlags.Public);
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.Append('{');
		bool flag = true;
		StringBuilder stringBuilder2 = stringBuilder;
		StringBuilder stringBuilder3 = stringBuilder2;
		StringBuilder.AppendInterpolatedStringHandler handler = new StringBuilder.AppendInterpolatedStringHandler(9, 1, stringBuilder2);
		handler.AppendLiteral("\"@type\":");
		handler.AppendFormatted(JSON.Dump(typeFromHandle.FullName));
		handler.AppendLiteral(",");
		stringBuilder3.Append(ref handler);
		FieldInfo[] array = fields;
		foreach (FieldInfo fieldInfo in array)
		{
			object value = fieldInfo.GetValue(obj);
			object defaultValue = fieldInfo.FieldType.GetDefaultValue();
			if (value != null && !value.Equals(defaultValue) && (!(fieldInfo.FieldType == typeof(string)) || value == null || !value.Equals(string.Empty)))
			{
				if (!flag)
				{
					stringBuilder.Append(',');
				}
				flag = false;
				stringBuilder2 = stringBuilder;
				StringBuilder stringBuilder4 = stringBuilder2;
				handler = new StringBuilder.AppendInterpolatedStringHandler(3, 2, stringBuilder2);
				handler.AppendLiteral("\"");
				handler.AppendFormatted(fieldInfo.Name);
				handler.AppendLiteral("\":");
				handler.AppendFormatted(JSON.Dump(value));
				stringBuilder4.Append(ref handler);
			}
		}
		stringBuilder.Append('}');
		return stringBuilder.ToString();
	}

	private static object GetDefaultValue(this Type t)
	{
		if (!t.IsValueType)
		{
			return null;
		}
		return Activator.CreateInstance(t);
	}

	public static Color HueAdjust(this Color c, float hue)
	{
		Color.RGBToHSV(c, out var _, out var S, out var V);
		return Color.HSVToRGB(hue, S, V);
	}

	public static Color AlphaAdjust(this Color c, float alpha)
	{
		return new Color(c.r, c.g, c.b, alpha);
	}

	public static void MakeEmpty(this Container c)
	{
		c.m_Inspected = true;
		c.m_DisableSerialization = false;
		c.m_RolledSpawnChance = true;
		c.m_NotPopulated = false;
		c.m_StartHasBeenCalled = true;
		c.m_StartInspected = true;
		c.m_GearToInstantiate.Clear();
		if (c.TryGetComponent<Lock>(out var component))
		{
			component.SetLockState(LockState.Unlocked);
			component.m_LockStateRolled = true;
		}
	}
}
