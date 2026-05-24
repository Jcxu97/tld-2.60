using System.Reflection;
using Cpp2ILInjected;
using ParadoxNotion.Serialization;
using UnityEngine;

namespace NodeCanvas.Framework.Internal;

[Token(Token = "0x200109F")]
public abstract class ReflectedWrapper
{
	[Token(Token = "0x20010A0")]
	protected delegate void ActionCall();

	[Token(Token = "0x20010A1")]
	protected delegate void ActionCall<T1>(T1 a);

	[Token(Token = "0x20010A2")]
	protected delegate void ActionCall<T1, T2>(T1 a, T2 b);

	[Token(Token = "0x20010A3")]
	protected delegate void ActionCall<T1, T2, T3>(T1 a, T2 b, T3 c);

	[Token(Token = "0x20010A4")]
	protected delegate void ActionCall<T1, T2, T3, T4>(T1 a, T2 b, T3 c, T4 d);

	[Token(Token = "0x20010A5")]
	protected delegate void ActionCall<T1, T2, T3, T4, T5>(T1 a, T2 b, T3 c, T4 d, T5 e);

	[Token(Token = "0x20010A6")]
	protected delegate void ActionCall<T1, T2, T3, T4, T5, T6>(T1 a, T2 b, T3 c, T4 d, T5 e, T6 f);

	[Token(Token = "0x20010A7")]
	protected delegate TResult FunctionCall<TResult>();

	[Token(Token = "0x20010A8")]
	protected delegate TResult FunctionCall<T1, TResult>(T1 a);

	[Token(Token = "0x20010A9")]
	protected delegate TResult FunctionCall<T1, T2, TResult>(T1 a, T2 b);

	[Token(Token = "0x20010AA")]
	protected delegate TResult FunctionCall<T1, T2, T3, TResult>(T1 a, T2 b, T3 c);

	[Token(Token = "0x20010AB")]
	protected delegate TResult FunctionCall<T1, T2, T3, T4, TResult>(T1 a, T2 b, T3 c, T4 d);

	[Token(Token = "0x20010AC")]
	protected delegate TResult FunctionCall<T1, T2, T3, T4, T5, TResult>(T1 a, T2 b, T3 c, T4 d, T5 e);

	[Token(Token = "0x20010AD")]
	protected delegate TResult FunctionCall<T1, T2, T3, T4, T5, T6, TResult>(T1 a, T2 b, T3 c, T4 d, T5 e, T6 f);

	[SerializeField]
	[Token(Token = "0x400862B")]
	[FieldOffset(Offset = "0x10")]
	protected SerializedMethodInfo _targetMethod;

	[Token(Token = "0x60070F4")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public ReflectedWrapper()
	{
	}

	[Token(Token = "0x60070F5")]
	[Address(RVA = "0x10D00C0", Offset = "0x10CEEC0", Length = "0xD0")]
	public static ReflectedWrapper Create(MethodInfo method, IBlackboard bb)
	{
		return null;
	}

	[Token(Token = "0x60070F6")]
	[Address(RVA = "0x10D0190", Offset = "0x10CEF90", Length = "0x17F")]
	public void SetVariablesBB(IBlackboard bb)
	{
	}

	[Token(Token = "0x60070F7")]
	[Address(RVA = "0x10D0310", Offset = "0x10CF110", Length = "0x20")]
	public bool HasChanged()
	{
		return false;
	}

	[Token(Token = "0x60070F8")]
	[Address(RVA = "0x10D0330", Offset = "0x10CF130", Length = "0xF")]
	public MethodInfo GetMethod()
	{
		return null;
	}

	[Token(Token = "0x60070F9")]
	[Address(RVA = "0x10D0340", Offset = "0x10CF140", Length = "0x20")]
	public string GetMethodString()
	{
		return null;
	}

	[Token(Token = "0x60070FA")]
	public abstract BBParameter[] GetVariables();

	[Token(Token = "0x60070FB")]
	public abstract void Init(object instance);
}
