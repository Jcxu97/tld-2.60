using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using UnityEngine;

namespace NodeCanvas.Framework.Internal;

[Serializable]
[Token(Token = "0x20010B6")]
public sealed class BlackboardSource : IBlackboard
{
	[SerializeField]
	[Token(Token = "0x4008637")]
	[FieldOffset(Offset = "0x20")]
	private string _name;

	[SerializeField]
	[Token(Token = "0x4008638")]
	[FieldOffset(Offset = "0x28")]
	private Dictionary<string, Variable> _variables;

	[Token(Token = "0x17000833")]
	public string name
	{
		[Token(Token = "0x6007159")]
		[Address(RVA = "0x40E110", Offset = "0x40CF10", Length = "0x5")]
		get
		{
			return null;
		}
		[Token(Token = "0x600715A")]
		[Address(RVA = "0x40E120", Offset = "0x40CF20", Length = "0x52")]
		set
		{
		}
	}

	[Token(Token = "0x17000834")]
	public Dictionary<string, Variable> variables
	{
		[Token(Token = "0x600715B")]
		[Address(RVA = "0x413AB0", Offset = "0x4128B0", Length = "0x5")]
		get
		{
			return null;
		}
		[Token(Token = "0x600715C")]
		[Address(RVA = "0x4A9DB0", Offset = "0x4A8BB0", Length = "0x52")]
		set
		{
		}
	}

	[Token(Token = "0x17000835")]
	public GameObject propertiesBindTarget
	{
		[Token(Token = "0x600715D")]
		[Address(RVA = "0x4582A0", Offset = "0x4570A0", Length = "0x3")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000836")]
	public object this[string varName]
	{
		[Token(Token = "0x600715E")]
		[Address(RVA = "0x10D2260", Offset = "0x10D1060", Length = "0x7F")]
		get
		{
			return null;
		}
		[Token(Token = "0x600715F")]
		[Address(RVA = "0x10D22F0", Offset = "0x10D10F0", Length = "0x8")]
		set
		{
		}
	}

	[Token(Token = "0x1400002D")]
	public event Action<Variable> onVariableAdded
	{
		[CompilerGenerated]
		[Token(Token = "0x6007155")]
		[Address(RVA = "0x10D1CA0", Offset = "0x10D0AA0", Length = "0x166")]
		add
		{
		}
		[CompilerGenerated]
		[Token(Token = "0x6007156")]
		[Address(RVA = "0x10D1E10", Offset = "0x10D0C10", Length = "0x166")]
		remove
		{
		}
	}

	[Token(Token = "0x1400002E")]
	public event Action<Variable> onVariableRemoved
	{
		[CompilerGenerated]
		[Token(Token = "0x6007157")]
		[Address(RVA = "0x10D1F80", Offset = "0x10D0D80", Length = "0x166")]
		add
		{
		}
		[CompilerGenerated]
		[Token(Token = "0x6007158")]
		[Address(RVA = "0x10D20F0", Offset = "0x10D0EF0", Length = "0x166")]
		remove
		{
		}
	}

	[Token(Token = "0x6007160")]
	[Address(RVA = "0x10D2300", Offset = "0x10D1100", Length = "0x131")]
	public BlackboardSource()
	{
	}

	[Token(Token = "0x6007161")]
	[Address(RVA = "0x10D2440", Offset = "0x10D1240", Length = "0x238")]
	public void InitializePropertiesBinding(GameObject targetGO, bool callSetter)
	{
	}

	[Token(Token = "0x6007162")]
	[Address(RVA = "0x10D2680", Offset = "0x10D1480", Length = "0xD3")]
	public Variable AddVariable(string varName, object value)
	{
		return null;
	}

	[Token(Token = "0x6007163")]
	[Address(RVA = "0x10D2760", Offset = "0x10D1560", Length = "0x44E")]
	public Variable AddVariable(string varName, Type type)
	{
		return null;
	}

	[Token(Token = "0x6007164")]
	[Address(RVA = "0x10D2BB0", Offset = "0x10D19B0", Length = "0xB2")]
	public Variable RemoveVariable(string varName)
	{
		return null;
	}

	[Token(Token = "0x6007165")]
	[Address(RVA = "0x1872200", Offset = "0x1871000", Length = "0x3D6")]
	public T GetValue<T>(string varName)
	{
		return default(T);
	}

	[Token(Token = "0x6007166")]
	[Address(RVA = "0x10D2C70", Offset = "0x10D1A70", Length = "0x2D1")]
	public Variable SetValue(string varName, object value)
	{
		return null;
	}

	[Token(Token = "0x6007167")]
	[Address(RVA = "0x1876290", Offset = "0x1875090", Length = "0x16C")]
	public Variable<T> GetVariable<T>(string varName)
	{
		return null;
	}

	[Token(Token = "0x6007168")]
	[Address(RVA = "0x10D2F50", Offset = "0x10D1D50", Length = "0xC8")]
	public Variable GetVariable(string varName, Type ofType = null)
	{
		return null;
	}

	[Token(Token = "0x6007169")]
	[Address(RVA = "0x10D3020", Offset = "0x10D1E20", Length = "0x317")]
	public Variable GetVariableByID(string ID)
	{
		return null;
	}

	[Token(Token = "0x600716A")]
	[Address(RVA = "0x10D3340", Offset = "0x10D2140", Length = "0xDF")]
	public string[] GetVariableNames()
	{
		return null;
	}

	[Token(Token = "0x600716B")]
	[Address(RVA = "0x10D3420", Offset = "0x10D2220", Length = "0x32F")]
	public string[] GetVariableNames(Type ofType)
	{
		return null;
	}

	[Token(Token = "0x600716C")]
	[Address(RVA = "0x1872100", Offset = "0x1870F00", Length = "0xF2")]
	public Variable<T> AddVariable<T>(string varName, T value)
	{
		return null;
	}

	[Token(Token = "0x600716D")]
	[Address(RVA = "0x1872000", Offset = "0x1870E00", Length = "0xFF")]
	public Variable<T> AddVariable<T>(string varName)
	{
		return null;
	}
}
