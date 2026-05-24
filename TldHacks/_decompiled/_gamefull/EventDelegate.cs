using System;
using System.Collections.Generic;
using System.Reflection;
using Cpp2ILInjected;
using UnityEngine;

[Serializable]
[Token(Token = "0x20000B0")]
public class EventDelegate
{
	[Serializable]
	[Token(Token = "0x20000B1")]
	public class Parameter
	{
		[Token(Token = "0x40005D5")]
		[FieldOffset(Offset = "0x10")]
		public UnityEngine.Object obj;

		[Token(Token = "0x40005D6")]
		[FieldOffset(Offset = "0x18")]
		public string field;

		[NonSerialized]
		[Token(Token = "0x40005D7")]
		[FieldOffset(Offset = "0x20")]
		private object mValue;

		[NonSerialized]
		[Token(Token = "0x40005D8")]
		[FieldOffset(Offset = "0x28")]
		public Type expectedType;

		[NonSerialized]
		[Token(Token = "0x40005D9")]
		[FieldOffset(Offset = "0x30")]
		public bool cached;

		[NonSerialized]
		[Token(Token = "0x40005DA")]
		[FieldOffset(Offset = "0x38")]
		public PropertyInfo propInfo;

		[NonSerialized]
		[Token(Token = "0x40005DB")]
		[FieldOffset(Offset = "0x40")]
		public FieldInfo fieldInfo;

		[Token(Token = "0x17000083")]
		public object value
		{
			[Token(Token = "0x60005F9")]
			[Address(RVA = "0xDE8020", Offset = "0xDE6E20", Length = "0x41D")]
			get
			{
				return null;
			}
			[Token(Token = "0x60005FA")]
			[Address(RVA = "0x40E120", Offset = "0x40CF20", Length = "0x52")]
			set
			{
			}
		}

		[Token(Token = "0x17000084")]
		public Type type
		{
			[Token(Token = "0x60005FB")]
			[Address(RVA = "0xDE8440", Offset = "0xDE7240", Length = "0x16A")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60005F6")]
		[Address(RVA = "0xDE7CD0", Offset = "0xDE6AD0", Length = "0xAC")]
		public Parameter()
		{
		}

		[Token(Token = "0x60005F7")]
		[Address(RVA = "0xDE7D80", Offset = "0xDE6B80", Length = "0x17E")]
		public Parameter(UnityEngine.Object obj, string field)
		{
		}

		[Token(Token = "0x60005F8")]
		[Address(RVA = "0xDE7F00", Offset = "0xDE6D00", Length = "0x119")]
		public Parameter(object val)
		{
		}
	}

	[Token(Token = "0x20000B2")]
	public delegate void Callback();

	[SerializeField]
	[Token(Token = "0x40005CA")]
	[FieldOffset(Offset = "0x10")]
	private MonoBehaviour mTarget;

	[SerializeField]
	[Token(Token = "0x40005CB")]
	[FieldOffset(Offset = "0x18")]
	private string mMethodName;

	[SerializeField]
	[Token(Token = "0x40005CC")]
	[FieldOffset(Offset = "0x20")]
	private Parameter[] mParameters;

	[Token(Token = "0x40005CD")]
	[FieldOffset(Offset = "0x28")]
	public bool oneShot;

	[NonSerialized]
	[Token(Token = "0x40005CE")]
	[FieldOffset(Offset = "0x30")]
	private Callback mCachedCallback;

	[NonSerialized]
	[Token(Token = "0x40005CF")]
	[FieldOffset(Offset = "0x38")]
	private bool mRawDelegate;

	[NonSerialized]
	[Token(Token = "0x40005D0")]
	[FieldOffset(Offset = "0x39")]
	private bool mCached;

	[NonSerialized]
	[Token(Token = "0x40005D1")]
	[FieldOffset(Offset = "0x40")]
	private MethodInfo mMethod;

	[NonSerialized]
	[Token(Token = "0x40005D2")]
	[FieldOffset(Offset = "0x48")]
	private ParameterInfo[] mParameterInfos;

	[NonSerialized]
	[Token(Token = "0x40005D3")]
	[FieldOffset(Offset = "0x50")]
	private object[] mArgs;

	[Token(Token = "0x40005D4")]
	private static int s_Hash;

	[Token(Token = "0x1700007E")]
	public MonoBehaviour target
	{
		[Token(Token = "0x60005D7")]
		[Address(RVA = "0x49DED0", Offset = "0x49CCD0", Length = "0x5")]
		get
		{
			return null;
		}
		[Token(Token = "0x60005D8")]
		[Address(RVA = "0xDE4D10", Offset = "0xDE3B10", Length = "0x19A")]
		set
		{
		}
	}

	[Token(Token = "0x1700007F")]
	public string methodName
	{
		[Token(Token = "0x60005D9")]
		[Address(RVA = "0x4571D0", Offset = "0x455FD0", Length = "0x5")]
		get
		{
			return null;
		}
		[Token(Token = "0x60005DA")]
		[Address(RVA = "0xDE4EB0", Offset = "0xDE3CB0", Length = "0x19A")]
		set
		{
		}
	}

	[Token(Token = "0x17000080")]
	public Parameter[] parameters
	{
		[Token(Token = "0x60005DB")]
		[Address(RVA = "0xDE5050", Offset = "0xDE3E50", Length = "0x2A")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000081")]
	public bool isValid
	{
		[Token(Token = "0x60005DC")]
		[Address(RVA = "0xDE5080", Offset = "0xDE3E80", Length = "0x10E")]
		get
		{
			return false;
		}
	}

	[Token(Token = "0x17000082")]
	public bool isEnabled
	{
		[Token(Token = "0x60005DD")]
		[Address(RVA = "0xDE5190", Offset = "0xDE3F90", Length = "0x1AC")]
		get
		{
			return false;
		}
	}

	[Token(Token = "0x60005DE")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public EventDelegate()
	{
	}

	[Token(Token = "0x60005DF")]
	[Address(RVA = "0xDE5340", Offset = "0xDE4140", Length = "0x8")]
	public EventDelegate(Callback call)
	{
	}

	[Token(Token = "0x60005E0")]
	[Address(RVA = "0xDE5350", Offset = "0xDE4150", Length = "0xD9")]
	public EventDelegate(MonoBehaviour target, string methodName)
	{
	}

	[Token(Token = "0x60005E1")]
	[Address(RVA = "0xDE5430", Offset = "0xDE4230", Length = "0x41")]
	private static string GetMethodName(Callback callback)
	{
		return null;
	}

	[Token(Token = "0x60005E2")]
	[Address(RVA = "0xDE5480", Offset = "0xDE4280", Length = "0x2E")]
	private static bool IsValid(Callback callback)
	{
		return false;
	}

	[Token(Token = "0x60005E3")]
	[Address(RVA = "0xDE54B0", Offset = "0xDE42B0", Length = "0x3CF")]
	public override bool Equals(object obj)
	{
		return false;
	}

	[Token(Token = "0x60005E4")]
	[Address(RVA = "0xDE5880", Offset = "0xDE4680", Length = "0x52")]
	public override int GetHashCode()
	{
		return 0;
	}

	[Token(Token = "0x60005E5")]
	[Address(RVA = "0xDE58E0", Offset = "0xDE46E0", Length = "0x263")]
	private void Set(Callback call)
	{
	}

	[Token(Token = "0x60005E6")]
	[Address(RVA = "0xDE5350", Offset = "0xDE4150", Length = "0xD9")]
	public void Set(MonoBehaviour target, string methodName)
	{
	}

	[Token(Token = "0x60005E7")]
	[Address(RVA = "0xDE5B50", Offset = "0xDE4950", Length = "0x996")]
	private void Cache()
	{
	}

	[Token(Token = "0x60005E8")]
	[Address(RVA = "0xDE64F0", Offset = "0xDE52F0", Length = "0x800")]
	public bool Execute()
	{
		return false;
	}

	[Token(Token = "0x60005E9")]
	[Address(RVA = "0xDE6D00", Offset = "0xDE5B00", Length = "0x23A")]
	public void Clear()
	{
	}

	[Token(Token = "0x60005EA")]
	[Address(RVA = "0xDE6F40", Offset = "0xDE5D40", Length = "0x1D5")]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x60005EB")]
	[Address(RVA = "0xDE7120", Offset = "0xDE5F20", Length = "0x17A")]
	public static void Execute(List<EventDelegate> list)
	{
	}

	[Token(Token = "0x60005EC")]
	[Address(RVA = "0xDE72A0", Offset = "0xDE60A0", Length = "0xBB")]
	public static bool IsValid(List<EventDelegate> list)
	{
		return false;
	}

	[Token(Token = "0x60005ED")]
	[Address(RVA = "0xDE7360", Offset = "0xDE6160", Length = "0xC6")]
	public static EventDelegate Set(List<EventDelegate> list, Callback callback)
	{
		return null;
	}

	[Token(Token = "0x60005EE")]
	[Address(RVA = "0xDE7430", Offset = "0xDE6230", Length = "0x7E")]
	public static void Set(List<EventDelegate> list, EventDelegate del)
	{
	}

	[Token(Token = "0x60005EF")]
	[Address(RVA = "0xDE74B0", Offset = "0xDE62B0", Length = "0x61")]
	public static EventDelegate Add(List<EventDelegate> list, Callback callback)
	{
		return null;
	}

	[Token(Token = "0x60005F0")]
	[Address(RVA = "0xDE7520", Offset = "0xDE6320", Length = "0x189")]
	public static EventDelegate Add(List<EventDelegate> list, Callback callback, bool oneShot)
	{
		return null;
	}

	[Token(Token = "0x60005F1")]
	[Address(RVA = "0xDE76B0", Offset = "0xDE64B0", Length = "0x7A")]
	public static void Add(List<EventDelegate> list, EventDelegate ev)
	{
	}

	[Token(Token = "0x60005F2")]
	[Address(RVA = "0xDE7730", Offset = "0xDE6530", Length = "0x34D")]
	public static void Add(List<EventDelegate> list, EventDelegate ev, bool oneShot)
	{
	}

	[Token(Token = "0x60005F3")]
	[Address(RVA = "0xDE7A80", Offset = "0xDE6880", Length = "0xEF")]
	public static bool Remove(List<EventDelegate> list, Callback callback)
	{
		return false;
	}

	[Token(Token = "0x60005F4")]
	[Address(RVA = "0xDE7B70", Offset = "0xDE6970", Length = "0xEF")]
	public static bool Remove(List<EventDelegate> list, EventDelegate ev)
	{
		return false;
	}
}
