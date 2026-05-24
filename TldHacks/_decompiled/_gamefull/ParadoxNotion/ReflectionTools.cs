using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Reflection;
using Cpp2ILInjected;

namespace ParadoxNotion;

[Token(Token = "0x2000D5D")]
public static class ReflectionTools
{
	[Token(Token = "0x2000D5E")]
	public enum MethodType
	{
		[Token(Token = "0x40083AC")]
		Normal,
		[Token(Token = "0x40083AD")]
		PropertyAccessor,
		[Token(Token = "0x40083AE")]
		Event,
		[Token(Token = "0x40083AF")]
		Operator
	}

	[Token(Token = "0x4008393")]
	public const BindingFlags FLAGS_ALL = BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.FlattenHierarchy;

	[Token(Token = "0x4008394")]
	public const BindingFlags FLAGS_ALL_DECLARED = BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic;

	[Token(Token = "0x4008395")]
	private static Assembly[] _loadedAssemblies;

	[Token(Token = "0x4008396")]
	private static Dictionary<string, Type> typeMap;

	[Token(Token = "0x4008397")]
	private static Type[] _allTypes;

	[Token(Token = "0x4008398")]
	private static Dictionary<Type, Type[]> _subTypesMap;

	[Token(Token = "0x4008399")]
	private static object[] _tempArgs;

	[Token(Token = "0x400839A")]
	public static readonly Dictionary<string, string> op_FriendlyNamesLong;

	[Token(Token = "0x400839B")]
	public static readonly Dictionary<string, string> op_FriendlyNamesShort;

	[Token(Token = "0x400839C")]
	public static readonly Dictionary<string, string> op_CSharpAliases;

	[Token(Token = "0x400839D")]
	public const string METHOD_SPECIAL_NAME_GET = "get_";

	[Token(Token = "0x400839E")]
	public const string METHOD_SPECIAL_NAME_SET = "set_";

	[Token(Token = "0x400839F")]
	public const string METHOD_SPECIAL_NAME_ADD = "add_";

	[Token(Token = "0x40083A0")]
	public const string METHOD_SPECIAL_NAME_REMOVE = "remove_";

	[Token(Token = "0x40083A1")]
	public const string METHOD_SPECIAL_NAME_OP = "op_";

	[Token(Token = "0x40083A2")]
	private static Dictionary<MethodBase, string> cacheSignatures;

	[Token(Token = "0x40083A3")]
	private static Dictionary<Type, ConstructorInfo[]> _typeConstructors;

	[Token(Token = "0x40083A4")]
	private static Dictionary<Type, MethodInfo[]> _typeMethods;

	[Token(Token = "0x40083A5")]
	private static Dictionary<Type, FieldInfo[]> _typeFields;

	[Token(Token = "0x40083A6")]
	private static Dictionary<Type, PropertyInfo[]> _typeProperties;

	[Token(Token = "0x40083A7")]
	private static Dictionary<Type, EventInfo[]> _typeEvents;

	[Token(Token = "0x40083A8")]
	private static Dictionary<Type, object[]> _typeAttributes;

	[Token(Token = "0x40083A9")]
	private static Dictionary<MemberInfo, object[]> _memberAttributes;

	[Token(Token = "0x40083AA")]
	private static Dictionary<Type, MethodInfo[]> _typeExtensions;

	[Token(Token = "0x1700072A")]
	private static Assembly[] loadedAssemblies
	{
		[Token(Token = "0x6006827")]
		[Address(RVA = "0x105F670", Offset = "0x105E470", Length = "0x136")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6006828")]
	[Address(RVA = "0x105F7B0", Offset = "0x105E5B0", Length = "0x54")]
	public static Type GetType(string typeFullName)
	{
		return null;
	}

	[Token(Token = "0x6006829")]
	[Address(RVA = "0x105F810", Offset = "0x105E610", Length = "0x60")]
	public static Type GetType(string typeFullName, Type fallbackAssignable)
	{
		return null;
	}

	[Token(Token = "0x600682A")]
	[Address(RVA = "0x105F870", Offset = "0x105E670", Length = "0x417")]
	public static Type GetType(string typeFullName, bool fallbackNoNamespace = false, Type fallbackAssignable = null)
	{
		return null;
	}

	[Token(Token = "0x600682B")]
	[Address(RVA = "0x105FC90", Offset = "0x105EA90", Length = "0x16B")]
	private static Type GetTypeDirect(string typeFullName)
	{
		return null;
	}

	[Token(Token = "0x600682C")]
	[Address(RVA = "0x105FE00", Offset = "0x105EC00", Length = "0x55E")]
	private static Type TryResolveGenericType(string typeFullName, bool fallbackNoNamespace = false, Type fallbackAssignable = null)
	{
		return null;
	}

	[Token(Token = "0x600682D")]
	[Address(RVA = "0x1060360", Offset = "0x105F160", Length = "0x209")]
	private static Type TryResolveDeserializeFromAttribute(string typeName)
	{
		return null;
	}

	[Token(Token = "0x600682E")]
	[Address(RVA = "0x1060570", Offset = "0x105F370", Length = "0x234")]
	private static Type TryResolveWithoutNamespace(string typeName, Type fallbackAssignable = null)
	{
		return null;
	}

	[Token(Token = "0x600682F")]
	[Address(RVA = "0x10607B0", Offset = "0x105F5B0", Length = "0x56F")]
	public static Type[] GetAllTypes(bool includeObsolete)
	{
		return null;
	}

	[Token(Token = "0x6006830")]
	[Address(RVA = "0x1060D20", Offset = "0x105FB20", Length = "0x28F")]
	public static Type[] GetImplementationsOf(Type baseType)
	{
		return null;
	}

	[Token(Token = "0x6006831")]
	[Address(RVA = "0x1060FB0", Offset = "0x105FDB0", Length = "0xB5")]
	public static object[] SingleTempArgsArray(object arg)
	{
		return null;
	}

	[Token(Token = "0x6006832")]
	[Address(RVA = "0x1061070", Offset = "0x105FE70", Length = "0x170")]
	public static MethodType GetMethodSpecialType(this MethodBase method)
	{
		return default(MethodType);
	}

	[Token(Token = "0x6006833")]
	[Address(RVA = "0x10611F0", Offset = "0x105FFF0", Length = "0x5C0")]
	public static string FriendlyName(this Type t, bool compileSafe = false)
	{
		return null;
	}

	[Token(Token = "0x6006834")]
	[Address(RVA = "0x10617C0", Offset = "0x10605C0", Length = "0x19E")]
	public static string FriendlyName(this MemberInfo info)
	{
		return null;
	}

	[Token(Token = "0x6006835")]
	[Address(RVA = "0x1061960", Offset = "0x1060760", Length = "0x5D")]
	public static string FriendlyName(this MethodBase method)
	{
		return null;
	}

	[Token(Token = "0x6006836")]
	[Address(RVA = "0x10619C0", Offset = "0x10607C0", Length = "0x3C8")]
	public static string FriendlyName(this MethodBase method, out MethodType specialNameType)
	{
		specialNameType = default(MethodType);
		return null;
	}

	[Token(Token = "0x6006837")]
	[Address(RVA = "0x1061D90", Offset = "0x1060B90", Length = "0x663")]
	public static string SignatureName(this MethodBase method)
	{
		return null;
	}

	[Token(Token = "0x6006838")]
	[Address(RVA = "0x1062400", Offset = "0x1061200", Length = "0x7F")]
	public static Type RTReflectedOrDeclaredType(this MemberInfo member)
	{
		return null;
	}

	[Token(Token = "0x6006839")]
	[Address(RVA = "0x1062480", Offset = "0x1061280", Length = "0x26")]
	public static bool RTIsAssignableFrom(this Type type, Type other)
	{
		return false;
	}

	[Token(Token = "0x600683A")]
	[Address(RVA = "0x10624B0", Offset = "0x10612B0", Length = "0x74")]
	public static bool RTIsAssignableTo(this Type type, Type other)
	{
		return false;
	}

	[Token(Token = "0x600683B")]
	[Address(RVA = "0x1062530", Offset = "0x1061330", Length = "0x2E")]
	public static bool RTIsAbstract(this Type type)
	{
		return false;
	}

	[Token(Token = "0x600683C")]
	[Address(RVA = "0x1062560", Offset = "0x1061360", Length = "0x26")]
	public static bool RTIsValueType(this Type type)
	{
		return false;
	}

	[Token(Token = "0x600683D")]
	[Address(RVA = "0x1062590", Offset = "0x1061390", Length = "0x26")]
	public static bool RTIsArray(this Type type)
	{
		return false;
	}

	[Token(Token = "0x600683E")]
	[Address(RVA = "0x10625C0", Offset = "0x10613C0", Length = "0x19")]
	public static bool RTIsInterface(this Type type)
	{
		return false;
	}

	[Token(Token = "0x600683F")]
	[Address(RVA = "0x10625E0", Offset = "0x10613E0", Length = "0x26")]
	public static bool RTIsSubclassOf(this Type type, Type other)
	{
		return false;
	}

	[Token(Token = "0x6006840")]
	[Address(RVA = "0x1062610", Offset = "0x1061410", Length = "0x26")]
	public static bool RTIsGenericParameter(this Type type)
	{
		return false;
	}

	[Token(Token = "0x6006841")]
	[Address(RVA = "0x1062640", Offset = "0x1061440", Length = "0x26")]
	public static bool RTIsGenericType(this Type type)
	{
		return false;
	}

	[Token(Token = "0x6006842")]
	[Address(RVA = "0x1062670", Offset = "0x1061470", Length = "0x28")]
	public static MethodInfo RTGetGetMethod(this PropertyInfo prop)
	{
		return null;
	}

	[Token(Token = "0x6006843")]
	[Address(RVA = "0x10626A0", Offset = "0x10614A0", Length = "0x28")]
	public static MethodInfo RTGetSetMethod(this PropertyInfo prop)
	{
		return null;
	}

	[Token(Token = "0x6006844")]
	[Address(RVA = "0x10626D0", Offset = "0x10614D0", Length = "0x26")]
	public static MethodInfo RTGetDelegateMethodInfo(this Delegate del)
	{
		return null;
	}

	[Token(Token = "0x6006845")]
	[Address(RVA = "0x1062700", Offset = "0x1061500", Length = "0x26")]
	public static Type RTMakeGenericType(this Type type, params Type[] typeArgs)
	{
		return null;
	}

	[Token(Token = "0x6006846")]
	[Address(RVA = "0x1062730", Offset = "0x1061530", Length = "0x26")]
	public static Type[] RTGetGenericArguments(this Type type)
	{
		return null;
	}

	[Token(Token = "0x6006847")]
	[Address(RVA = "0x1062760", Offset = "0x1061560", Length = "0x33")]
	public static Type[] RTGetEmptyTypes()
	{
		return null;
	}

	[Token(Token = "0x6006848")]
	[Address(RVA = "0x10627A0", Offset = "0x10615A0", Length = "0x47")]
	public static Type RTGetElementType(this Type type)
	{
		return null;
	}

	[Token(Token = "0x6006849")]
	[Address(RVA = "0x10627F0", Offset = "0x10615F0", Length = "0x47")]
	public static bool RTIsByRef(this Type type)
	{
		return false;
	}

	[Token(Token = "0x600684A")]
	[Address(RVA = "0x1062840", Offset = "0x1061640", Length = "0x40")]
	public static object CreateObject(this Type type)
	{
		return null;
	}

	[Token(Token = "0x600684B")]
	[Address(RVA = "0x1062880", Offset = "0x1061680", Length = "0x70")]
	public static object CreateObjectUninitialized(this Type type)
	{
		return null;
	}

	[Token(Token = "0x600684C")]
	[Address(RVA = "0x10628F0", Offset = "0x10616F0", Length = "0xCD")]
	public static ConstructorInfo RTGetDefaultConstructor(this Type type)
	{
		return null;
	}

	[Token(Token = "0x600684D")]
	[Address(RVA = "0x10629C0", Offset = "0x10617C0", Length = "0x17A")]
	public static ConstructorInfo RTGetConstructor(this Type type, Type[] paramTypes)
	{
		return null;
	}

	[Token(Token = "0x600684E")]
	[Address(RVA = "0x1062B40", Offset = "0x1061940", Length = "0x106")]
	public static MethodInfo RTGetMethod(this Type type, string name)
	{
		return null;
	}

	[Token(Token = "0x600684F")]
	[Address(RVA = "0x1062C50", Offset = "0x1061A50", Length = "0x1D6")]
	public static MethodInfo RTGetMethod(this Type type, string name, Type[] paramTypes)
	{
		return null;
	}

	[Token(Token = "0x6006850")]
	[Address(RVA = "0x1062E30", Offset = "0x1061C30", Length = "0x106")]
	public static FieldInfo RTGetField(this Type type, string name)
	{
		return null;
	}

	[Token(Token = "0x6006851")]
	[Address(RVA = "0x1062F40", Offset = "0x1061D40", Length = "0x22F")]
	public static PropertyInfo RTGetProperty(this Type type, string name)
	{
		return null;
	}

	[Token(Token = "0x6006852")]
	[Address(RVA = "0x1063170", Offset = "0x1061F70", Length = "0x22F")]
	public static EventInfo RTGetEvent(this Type type, string name)
	{
		return null;
	}

	[Token(Token = "0x6006853")]
	[Address(RVA = "0x10633A0", Offset = "0x10621A0", Length = "0x13D")]
	public static ConstructorInfo[] RTGetConstructors(this Type type)
	{
		return null;
	}

	[Token(Token = "0x6006854")]
	[Address(RVA = "0x10634E0", Offset = "0x10622E0", Length = "0x13D")]
	public static MethodInfo[] RTGetMethods(this Type type)
	{
		return null;
	}

	[Token(Token = "0x6006855")]
	[Address(RVA = "0x1063620", Offset = "0x1062420", Length = "0x13D")]
	public static FieldInfo[] RTGetFields(this Type type)
	{
		return null;
	}

	[Token(Token = "0x6006856")]
	[Address(RVA = "0x1063760", Offset = "0x1062560", Length = "0x13D")]
	public static PropertyInfo[] RTGetProperties(this Type type)
	{
		return null;
	}

	[Token(Token = "0x6006857")]
	[Address(RVA = "0x10638A0", Offset = "0x10626A0", Length = "0x13D")]
	public static EventInfo[] RTGetEvents(this Type type)
	{
		return null;
	}

	[Token(Token = "0x6006858")]
	[Address(RVA = "0x19DC4C0", Offset = "0x19DB2C0", Length = "0xD7")]
	public static bool RTIsDefined<T>(this Type type, bool inherited) where T : Attribute
	{
		return false;
	}

	[Token(Token = "0x6006859")]
	[Address(RVA = "0x10639E0", Offset = "0x10627E0", Length = "0x26")]
	public static bool RTIsDefined(this Type type, Type attributeType, bool inherited)
	{
		return false;
	}

	[Token(Token = "0x600685A")]
	[Address(RVA = "0x19DC4C0", Offset = "0x19DB2C0", Length = "0xD7")]
	public static bool RTIsDefined<T>(this MemberInfo member, bool inherited) where T : Attribute
	{
		return false;
	}

	[Token(Token = "0x600685B")]
	[Address(RVA = "0x10639E0", Offset = "0x10627E0", Length = "0x26")]
	public static bool RTIsDefined(this MemberInfo member, Type attributeType, bool inherited)
	{
		return false;
	}

	[Token(Token = "0x600685C")]
	[Address(RVA = "0x19DBFE0", Offset = "0x19DADE0", Length = "0x3B3")]
	public static T RTGetAttribute<T>(this Type type, bool inherited) where T : Attribute
	{
		return null;
	}

	[Token(Token = "0x600685D")]
	[Address(RVA = "0x19DBC20", Offset = "0x19DAA20", Length = "0x3B3")]
	public static T RTGetAttribute<T>(this MemberInfo member, bool inherited) where T : Attribute
	{
		return null;
	}

	[Token(Token = "0x600685E")]
	[Address(RVA = "0x19DC3A0", Offset = "0x19DB1A0", Length = "0x112")]
	public static T[] RTGetAttributesRecursive<T>(this Type type) where T : Attribute
	{
		return null;
	}

	[Token(Token = "0x600685F")]
	[Address(RVA = "0x1063A10", Offset = "0x1062810", Length = "0x163")]
	public static ParameterInfo[] RTGetDelegateTypeParameters(this Type delegateType)
	{
		return null;
	}

	[Token(Token = "0x6006860")]
	[Address(RVA = "0x19DB8E0", Offset = "0x19DA6E0", Length = "0x121")]
	public static T RTCreateDelegate<T>(this MethodInfo method, object instance)
	{
		return default(T);
	}

	[Token(Token = "0x6006861")]
	[Address(RVA = "0x1063B80", Offset = "0x1062980", Length = "0x2CE")]
	public static Delegate RTCreateDelegate(this MethodInfo method, Type type, object instance)
	{
		return null;
	}

	[Token(Token = "0x6006862")]
	[Address(RVA = "0x1063E50", Offset = "0x1062C50", Length = "0x59")]
	public static Delegate ConvertDelegate(Delegate originalDelegate, Type targetDelegateType)
	{
		return null;
	}

	[Token(Token = "0x6006863")]
	[Address(RVA = "0x1063EB0", Offset = "0x1062CB0", Length = "0x53")]
	public static bool IsReadOnly(this FieldInfo field)
	{
		return false;
	}

	[Token(Token = "0x6006864")]
	[Address(RVA = "0x1063F10", Offset = "0x1062D10", Length = "0xA6")]
	public static bool IsConstant(this FieldInfo field)
	{
		return false;
	}

	[Token(Token = "0x6006865")]
	[Address(RVA = "0x1063FC0", Offset = "0x1062DC0", Length = "0x4E")]
	public static bool IsStatic(this EventInfo info)
	{
		return false;
	}

	[Token(Token = "0x6006866")]
	[Address(RVA = "0x1064010", Offset = "0x1062E10", Length = "0xE8")]
	public static bool IsParams(this ParameterInfo parameter, ParameterInfo[] parameters)
	{
		return false;
	}

	[Token(Token = "0x6006867")]
	[Address(RVA = "0x1064100", Offset = "0x1062F00", Length = "0x237")]
	public static bool IsObsolete(this MemberInfo member, bool inherited = true)
	{
		return false;
	}

	[Token(Token = "0x6006868")]
	[Address(RVA = "0x1064340", Offset = "0x1063140", Length = "0x3B2")]
	public static PropertyInfo GetBaseDefinition(this PropertyInfo propertyInfo)
	{
		return null;
	}

	[Token(Token = "0x6006869")]
	[Address(RVA = "0x1064700", Offset = "0x1063500", Length = "0x99")]
	public static FieldInfo GetBaseDefinition(this FieldInfo fieldInfo)
	{
		return null;
	}

	[Token(Token = "0x600686A")]
	[Address(RVA = "0x10647A0", Offset = "0x10635A0", Length = "0x3DB")]
	public static MethodInfo[] GetExtensionMethods(this Type targetType)
	{
		return null;
	}

	[Token(Token = "0x600686B")]
	[Address(RVA = "0x1064B80", Offset = "0x1063980", Length = "0x66")]
	public static bool IsExtensionMethod(this MethodInfo method)
	{
		return false;
	}

	[Token(Token = "0x600686C")]
	[Address(RVA = "0x1064BF0", Offset = "0x10639F0", Length = "0x1C1")]
	public static bool IsPropertyAccessor(this MethodInfo method)
	{
		return false;
	}

	[Token(Token = "0x600686D")]
	[Address(RVA = "0x1064DC0", Offset = "0x1063BC0", Length = "0x32")]
	public static bool IsIndexerProperty(this PropertyInfo property)
	{
		return false;
	}

	[Token(Token = "0x600686E")]
	[Address(RVA = "0x1064E00", Offset = "0x1063C00", Length = "0x123")]
	public static bool IsAutoProperty(this PropertyInfo property)
	{
		return false;
	}

	[Token(Token = "0x600686F")]
	[Address(RVA = "0x1064F30", Offset = "0x1063D30", Length = "0x123")]
	public static PropertyInfo GetAccessorProperty(this MethodInfo method)
	{
		return null;
	}

	[Token(Token = "0x6006870")]
	[Address(RVA = "0x1065060", Offset = "0x1063E60", Length = "0x16F")]
	public static bool IsEnumerableCollection(this Type type)
	{
		return false;
	}

	[Token(Token = "0x6006871")]
	[Address(RVA = "0x10651D0", Offset = "0x1063FD0", Length = "0x1F7")]
	public static Type GetEnumerableElementType(this Type type)
	{
		return null;
	}

	[Token(Token = "0x6006872")]
	[Address(RVA = "0x10653D0", Offset = "0x10641D0", Length = "0x170")]
	public static Type GetFirstGenericParameterConstraintType(this Type type)
	{
		return null;
	}

	[Token(Token = "0x6006873")]
	[Address(RVA = "0x1065550", Offset = "0x1064350", Length = "0x135")]
	public static Type GetFirstGenericParameterConstraintType(this MethodInfo method)
	{
		return null;
	}

	[Token(Token = "0x6006874")]
	[Address(RVA = "0x1065690", Offset = "0x1064490", Length = "0x112")]
	public static bool CanBeMadeGenericWith(this Type def, Type type)
	{
		return false;
	}

	[Token(Token = "0x6006875")]
	[Address(RVA = "0x10657B0", Offset = "0x10645B0", Length = "0xE8")]
	public static bool CanBeMadeGenericWith(this MethodInfo def, Type type)
	{
		return false;
	}

	[Token(Token = "0x6006876")]
	[Address(RVA = "0x10658A0", Offset = "0x10646A0", Length = "0x3A9")]
	public static bool IsAllowedByGenericArgument(this Type type, Type genericArgument)
	{
		return false;
	}

	[Token(Token = "0x6006877")]
	[Address(RVA = "0x1065C50", Offset = "0x1064A50", Length = "0x197")]
	public static Array Resize(this Array array, int newSize)
	{
		return null;
	}

	[Token(Token = "0x6006878")]
	[Address(RVA = "0x1065DF0", Offset = "0x1064BF0", Length = "0x118")]
	public static bool CanConvert(Type fromType, Type toType, out UnaryExpression exp)
	{
		exp = null;
		return false;
	}
}
