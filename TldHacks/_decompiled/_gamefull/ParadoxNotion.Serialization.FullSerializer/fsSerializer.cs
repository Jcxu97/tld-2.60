using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using ParadoxNotion.Serialization.FullSerializer.Internal;

namespace ParadoxNotion.Serialization.FullSerializer;

[Token(Token = "0x2000D9F")]
public class fsSerializer
{
	[Token(Token = "0x2000DA0")]
	internal class fsLazyCycleDefinitionWriter
	{
		[Token(Token = "0x4008461")]
		[FieldOffset(Offset = "0x10")]
		private Dictionary<int, fsData> _pendingDefinitions;

		[Token(Token = "0x4008462")]
		[FieldOffset(Offset = "0x18")]
		private HashSet<int> _references;

		[Token(Token = "0x6006A40")]
		[Address(RVA = "0x1085140", Offset = "0x1083F40", Length = "0x20E")]
		public void WriteDefinition(int id, fsData data)
		{
		}

		[Token(Token = "0x6006A41")]
		[Address(RVA = "0x1085350", Offset = "0x1084150", Length = "0x34E")]
		public void WriteReference(int id, Dictionary<string, fsData> dict)
		{
		}

		[Token(Token = "0x6006A42")]
		[Address(RVA = "0x10856A0", Offset = "0x10844A0", Length = "0xA2")]
		public void Clear()
		{
		}

		[Token(Token = "0x6006A43")]
		[Address(RVA = "0x1085750", Offset = "0x1084550", Length = "0x14A")]
		public fsLazyCycleDefinitionWriter()
		{
		}
	}

	[Token(Token = "0x4008451")]
	public const string KEY_OBJECT_REFERENCE = "$ref";

	[Token(Token = "0x4008452")]
	public const string KEY_OBJECT_DEFINITION = "$id";

	[Token(Token = "0x4008453")]
	public const string KEY_INSTANCE_TYPE = "$type";

	[Token(Token = "0x4008454")]
	public const string KEY_VERSION = "$version";

	[Token(Token = "0x4008455")]
	public const string KEY_CONTENT = "$content";

	[Token(Token = "0x4008456")]
	[FieldOffset(Offset = "0x10")]
	private Dictionary<Type, fsBaseConverter> _cachedOverrideConverterInstances;

	[Token(Token = "0x4008457")]
	[FieldOffset(Offset = "0x18")]
	private Dictionary<Type, fsBaseConverter> _cachedConverters;

	[Token(Token = "0x4008458")]
	[FieldOffset(Offset = "0x20")]
	private readonly List<fsConverter> _availableConverters;

	[Token(Token = "0x4008459")]
	[FieldOffset(Offset = "0x28")]
	private readonly Dictionary<Type, fsDirectConverter> _availableDirectConverters;

	[Token(Token = "0x400845A")]
	private static readonly Type[] _directConverterTypes;

	[Token(Token = "0x400845B")]
	[FieldOffset(Offset = "0x30")]
	private readonly List<fsObjectProcessor> _processors;

	[Token(Token = "0x400845C")]
	[FieldOffset(Offset = "0x38")]
	private Dictionary<Type, List<fsObjectProcessor>> _cachedProcessors;

	[Token(Token = "0x400845D")]
	[FieldOffset(Offset = "0x40")]
	private readonly fsCyclicReferenceManager _references;

	[Token(Token = "0x400845E")]
	[FieldOffset(Offset = "0x48")]
	private readonly fsLazyCycleDefinitionWriter _lazyReferenceWriter;

	[Token(Token = "0x400845F")]
	[FieldOffset(Offset = "0x50")]
	public fsContext Context;

	[Token(Token = "0x4008460")]
	[FieldOffset(Offset = "0x58")]
	public fsConfig Config;

	[Token(Token = "0x6006A27")]
	[Address(RVA = "0x1080780", Offset = "0x107F580", Length = "0x1AF")]
	public static bool IsReservedKeyword(string key)
	{
		return false;
	}

	[Token(Token = "0x6006A28")]
	[Address(RVA = "0x1080930", Offset = "0x107F730", Length = "0xC3")]
	private static bool IsObjectReference(fsData data)
	{
		return false;
	}

	[Token(Token = "0x6006A29")]
	[Address(RVA = "0x1080A00", Offset = "0x107F800", Length = "0xC3")]
	private static bool IsObjectDefinition(fsData data)
	{
		return false;
	}

	[Token(Token = "0x6006A2A")]
	[Address(RVA = "0x1080AD0", Offset = "0x107F8D0", Length = "0xC3")]
	private static bool IsVersioned(fsData data)
	{
		return false;
	}

	[Token(Token = "0x6006A2B")]
	[Address(RVA = "0x1080BA0", Offset = "0x107F9A0", Length = "0xC3")]
	private static bool IsTypeSpecified(fsData data)
	{
		return false;
	}

	[Token(Token = "0x6006A2C")]
	[Address(RVA = "0x1080C70", Offset = "0x107FA70", Length = "0xC3")]
	private static bool IsWrappedData(fsData data)
	{
		return false;
	}

	[Token(Token = "0x6006A2D")]
	[Address(RVA = "0x1080D40", Offset = "0x107FB40", Length = "0x2B3")]
	private static void Invoke_OnBeforeSerialize(List<fsObjectProcessor> processors, Type storageType, object instance)
	{
	}

	[Token(Token = "0x6006A2E")]
	[Address(RVA = "0x1081000", Offset = "0x107FE00", Length = "0xD7")]
	private static void Invoke_OnAfterSerialize(List<fsObjectProcessor> processors, Type storageType, object instance, ref fsData data)
	{
	}

	[Token(Token = "0x6006A2F")]
	[Address(RVA = "0x10810E0", Offset = "0x107FEE0", Length = "0xC2")]
	private static void Invoke_OnBeforeDeserialize(List<fsObjectProcessor> processors, Type storageType, ref fsData data)
	{
	}

	[Token(Token = "0x6006A30")]
	[Address(RVA = "0x10811B0", Offset = "0x107FFB0", Length = "0xDA")]
	private static void Invoke_OnBeforeDeserializeAfterInstanceCreation(List<fsObjectProcessor> processors, Type storageType, object instance, ref fsData data)
	{
	}

	[Token(Token = "0x6006A31")]
	[Address(RVA = "0x1081290", Offset = "0x1080090", Length = "0x2A7")]
	private static void Invoke_OnAfterDeserialize(List<fsObjectProcessor> processors, Type storageType, object instance)
	{
	}

	[Token(Token = "0x6006A32")]
	[Address(RVA = "0x1081540", Offset = "0x1080340", Length = "0x2DB")]
	private static void EnsureDictionary(fsData data)
	{
	}

	[Token(Token = "0x6006A33")]
	[Address(RVA = "0x1081820", Offset = "0x1080620", Length = "0x117")]
	static fsSerializer()
	{
	}

	[Token(Token = "0x6006A34")]
	[Address(RVA = "0x1081940", Offset = "0x1080740", Length = "0xFD1")]
	public fsSerializer()
	{
	}

	[Token(Token = "0x6006A35")]
	[Address(RVA = "0x1082920", Offset = "0x1081720", Length = "0x311")]
	private List<fsObjectProcessor> GetProcessors(Type type)
	{
		return null;
	}

	[Token(Token = "0x6006A36")]
	[Address(RVA = "0x1082C40", Offset = "0x1081A40", Length = "0x3AE")]
	public void AddConverter(fsBaseConverter converter)
	{
	}

	[Token(Token = "0x6006A37")]
	[Address(RVA = "0x1082FF0", Offset = "0x1081DF0", Length = "0x56C")]
	private fsBaseConverter GetConverter(Type type, Type overrideConverterType)
	{
		return null;
	}

	[Token(Token = "0x6006A38")]
	[Address(RVA = "0x1A61A10", Offset = "0x1A60810", Length = "0x130")]
	public fsResult TrySerialize<T>(T instance, out fsData data)
	{
		data = null;
		return default(fsResult);
	}

	[Token(Token = "0x6006A39")]
	[Address(RVA = "0x1083560", Offset = "0x1082360", Length = "0x40")]
	public fsResult TrySerialize(Type storageType, object instance, out fsData data)
	{
		data = null;
		return default(fsResult);
	}

	[Token(Token = "0x6006A3A")]
	[Address(RVA = "0x10835A0", Offset = "0x10823A0", Length = "0x356")]
	public fsResult TrySerialize(Type storageType, Type overrideConverterType, object instance, out fsData data)
	{
		data = null;
		return default(fsResult);
	}

	[Token(Token = "0x6006A3B")]
	[Address(RVA = "0x1083900", Offset = "0x1082700", Length = "0x69C")]
	private fsResult Internal_Serialize(Type storageType, Type overrideConverterType, object instance, out fsData data)
	{
		data = null;
		return default(fsResult);
	}

	[Token(Token = "0x6006A3C")]
	[Address(RVA = "0x1A61740", Offset = "0x1A60540", Length = "0x2C6")]
	public fsResult TryDeserialize<T>(fsData data, ref T instance)
	{
		return default(fsResult);
	}

	[Token(Token = "0x6006A3D")]
	[Address(RVA = "0x1083FA0", Offset = "0x1082DA0", Length = "0x3B")]
	public fsResult TryDeserialize(fsData data, Type storageType, ref object result)
	{
		return default(fsResult);
	}

	[Token(Token = "0x6006A3E")]
	[Address(RVA = "0x1083FE0", Offset = "0x1082DE0", Length = "0x592")]
	public fsResult TryDeserialize(fsData data, Type storageType, Type overrideConverterType, ref object result)
	{
		return default(fsResult);
	}

	[Token(Token = "0x6006A3F")]
	[Address(RVA = "0x1084580", Offset = "0x1083380", Length = "0xBB9")]
	private fsResult Internal_Deserialize(Type overrideConverterType, fsData data, Type storageType, ref object result, out List<fsObjectProcessor> processors)
	{
		processors = null;
		return default(fsResult);
	}
}
