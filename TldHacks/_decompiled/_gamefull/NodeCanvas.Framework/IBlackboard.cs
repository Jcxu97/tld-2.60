using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using ParadoxNotion.Design;
using UnityEngine;

namespace NodeCanvas.Framework;

[SpoofAOT]
[Token(Token = "0x2001083")]
public interface IBlackboard
{
	[Token(Token = "0x1700080C")]
	string name
	{
		[Token(Token = "0x6007056")]
		get;
		[Token(Token = "0x6007057")]
		set;
	}

	[Token(Token = "0x1700080D")]
	Dictionary<string, Variable> variables
	{
		[Token(Token = "0x6007058")]
		get;
		[Token(Token = "0x6007059")]
		set;
	}

	[Token(Token = "0x1700080E")]
	GameObject propertiesBindTarget
	{
		[Token(Token = "0x600705A")]
		get;
	}

	[Token(Token = "0x14000029")]
	event Action<Variable> onVariableAdded;

	[Token(Token = "0x1400002A")]
	event Action<Variable> onVariableRemoved;

	[Token(Token = "0x600705B")]
	Variable AddVariable(string varName, Type type);

	[Token(Token = "0x600705C")]
	Variable AddVariable(string varName, object value);

	[Token(Token = "0x600705D")]
	Variable RemoveVariable(string varName);

	[Token(Token = "0x600705E")]
	Variable GetVariable(string varName, Type ofType = null);

	[Token(Token = "0x600705F")]
	Variable GetVariableByID(string ID);

	[Token(Token = "0x6007060")]
	Variable<T> GetVariable<T>(string varName);

	[Token(Token = "0x6007061")]
	T GetValue<T>(string varName);

	[Token(Token = "0x6007062")]
	Variable SetValue(string varName, object value);

	[Token(Token = "0x6007063")]
	string[] GetVariableNames();

	[Token(Token = "0x6007064")]
	string[] GetVariableNames(Type ofType);
}
