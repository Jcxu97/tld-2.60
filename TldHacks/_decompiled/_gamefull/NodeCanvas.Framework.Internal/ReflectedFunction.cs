using System;
using Cpp2ILInjected;
using ParadoxNotion.Design;

namespace NodeCanvas.Framework.Internal;

[Serializable]
[SpoofAOT]
[Token(Token = "0x2001098")]
public class ReflectedFunction<TResult> : ReflectedFunctionWrapper
{
	[Token(Token = "0x4008608")]
	[FieldOffset(Offset = "0x0")]
	private FunctionCall<TResult> call;

	[BlackboardOnly]
	[Token(Token = "0x4008609")]
	[FieldOffset(Offset = "0x0")]
	public BBParameter<TResult> result;

	[Token(Token = "0x60070D8")]
	[Address(RVA = "0x1FBBEB0", Offset = "0x1FBACB0", Length = "0x94")]
	public override BBParameter[] GetVariables()
	{
		return null;
	}

	[Token(Token = "0x60070D9")]
	[Address(RVA = "0x1FBBF50", Offset = "0x1FBAD50", Length = "0xE6")]
	public override void Init(object instance)
	{
	}

	[Token(Token = "0x60070DA")]
	[Address(RVA = "0x1FBC040", Offset = "0x1FBAE40", Length = "0x73")]
	public override object Call()
	{
		return null;
	}

	[Token(Token = "0x60070DB")]
	[Address(RVA = "0x1FB6490", Offset = "0x1FB5290", Length = "0xBC")]
	public ReflectedFunction()
	{
	}
}
[Serializable]
[Token(Token = "0x2001099")]
public class ReflectedFunction<TResult, T1> : ReflectedFunctionWrapper
{
	[Token(Token = "0x400860A")]
	[FieldOffset(Offset = "0x0")]
	private FunctionCall<T1, TResult> call;

	[Token(Token = "0x400860B")]
	[FieldOffset(Offset = "0x0")]
	public BBParameter<T1> p1;

	[BlackboardOnly]
	[Token(Token = "0x400860C")]
	[FieldOffset(Offset = "0x0")]
	public BBParameter<TResult> result;

	[Token(Token = "0x60070DC")]
	[Address(RVA = "0x1FBE950", Offset = "0x1FBD750", Length = "0xDB")]
	public override BBParameter[] GetVariables()
	{
		return null;
	}

	[Token(Token = "0x60070DD")]
	[Address(RVA = "0x1FBEA30", Offset = "0x1FBD830", Length = "0x106")]
	public override void Init(object instance)
	{
	}

	[Token(Token = "0x60070DE")]
	[Address(RVA = "0x1FBEB40", Offset = "0x1FBD940", Length = "0x20B")]
	public override object Call()
	{
		return null;
	}

	[Token(Token = "0x60070DF")]
	[Address(RVA = "0x1FBED50", Offset = "0x1FBDB50", Length = "0x16E")]
	public ReflectedFunction()
	{
	}
}
[Serializable]
[Token(Token = "0x200109A")]
public class ReflectedFunction<TResult, T1, T2> : ReflectedFunctionWrapper
{
	[Token(Token = "0x400860D")]
	[FieldOffset(Offset = "0x0")]
	private FunctionCall<T1, T2, TResult> call;

	[Token(Token = "0x400860E")]
	[FieldOffset(Offset = "0x0")]
	public BBParameter<T1> p1;

	[Token(Token = "0x400860F")]
	[FieldOffset(Offset = "0x0")]
	public BBParameter<T2> p2;

	[BlackboardOnly]
	[Token(Token = "0x4008610")]
	[FieldOffset(Offset = "0x0")]
	public BBParameter<TResult> result;

	[Token(Token = "0x60070E0")]
	[Address(RVA = "0x1FBEEC0", Offset = "0x1FBDCC0", Length = "0x120")]
	public override BBParameter[] GetVariables()
	{
		return null;
	}

	[Token(Token = "0x60070E1")]
	[Address(RVA = "0x1FBEFF0", Offset = "0x1FBDDF0", Length = "0x106")]
	public override void Init(object instance)
	{
	}

	[Token(Token = "0x60070E2")]
	[Address(RVA = "0x1FBF100", Offset = "0x1FBDF00", Length = "0x28A")]
	public override object Call()
	{
		return null;
	}

	[Token(Token = "0x60070E3")]
	[Address(RVA = "0x1FBF390", Offset = "0x1FBE190", Length = "0x20E")]
	public ReflectedFunction()
	{
	}
}
[Serializable]
[Token(Token = "0x200109B")]
public class ReflectedFunction<TResult, T1, T2, T3> : ReflectedFunctionWrapper
{
	[Token(Token = "0x4008611")]
	[FieldOffset(Offset = "0x0")]
	private FunctionCall<T1, T2, T3, TResult> call;

	[Token(Token = "0x4008612")]
	[FieldOffset(Offset = "0x0")]
	public BBParameter<T1> p1;

	[Token(Token = "0x4008613")]
	[FieldOffset(Offset = "0x0")]
	public BBParameter<T2> p2;

	[Token(Token = "0x4008614")]
	[FieldOffset(Offset = "0x0")]
	public BBParameter<T3> p3;

	[BlackboardOnly]
	[Token(Token = "0x4008615")]
	[FieldOffset(Offset = "0x0")]
	public BBParameter<TResult> result;

	[Token(Token = "0x60070E4")]
	[Address(RVA = "0x1FBF5A0", Offset = "0x1FBE3A0", Length = "0x161")]
	public override BBParameter[] GetVariables()
	{
		return null;
	}

	[Token(Token = "0x60070E5")]
	[Address(RVA = "0x1FBF710", Offset = "0x1FBE510", Length = "0x106")]
	public override void Init(object instance)
	{
	}

	[Token(Token = "0x60070E6")]
	[Address(RVA = "0x1FBF820", Offset = "0x1FBE620", Length = "0x320")]
	public override object Call()
	{
		return null;
	}

	[Token(Token = "0x60070E7")]
	[Address(RVA = "0x1FBFB50", Offset = "0x1FBE950", Length = "0x2AE")]
	public ReflectedFunction()
	{
	}
}
[Serializable]
[Token(Token = "0x200109C")]
public class ReflectedFunction<TResult, T1, T2, T3, T4> : ReflectedFunctionWrapper
{
	[Token(Token = "0x4008616")]
	[FieldOffset(Offset = "0x0")]
	private FunctionCall<T1, T2, T3, T4, TResult> call;

	[Token(Token = "0x4008617")]
	[FieldOffset(Offset = "0x0")]
	public BBParameter<T1> p1;

	[Token(Token = "0x4008618")]
	[FieldOffset(Offset = "0x0")]
	public BBParameter<T2> p2;

	[Token(Token = "0x4008619")]
	[FieldOffset(Offset = "0x0")]
	public BBParameter<T3> p3;

	[Token(Token = "0x400861A")]
	[FieldOffset(Offset = "0x0")]
	public BBParameter<T4> p4;

	[BlackboardOnly]
	[Token(Token = "0x400861B")]
	[FieldOffset(Offset = "0x0")]
	public BBParameter<TResult> result;

	[Token(Token = "0x60070E8")]
	[Address(RVA = "0x1FBFE00", Offset = "0x1FBEC00", Length = "0x1A6")]
	public override BBParameter[] GetVariables()
	{
		return null;
	}

	[Token(Token = "0x60070E9")]
	[Address(RVA = "0x1FBFFB0", Offset = "0x1FBEDB0", Length = "0x106")]
	public override void Init(object instance)
	{
	}

	[Token(Token = "0x60070EA")]
	[Address(RVA = "0x1FC00C0", Offset = "0x1FBEEC0", Length = "0x3C0")]
	public override object Call()
	{
		return null;
	}

	[Token(Token = "0x60070EB")]
	[Address(RVA = "0x1FC0490", Offset = "0x1FBF290", Length = "0x34E")]
	public ReflectedFunction()
	{
	}
}
[Serializable]
[Token(Token = "0x200109D")]
public class ReflectedFunction<TResult, T1, T2, T3, T4, T5> : ReflectedFunctionWrapper
{
	[Token(Token = "0x400861C")]
	[FieldOffset(Offset = "0x0")]
	private FunctionCall<T1, T2, T3, T4, T5, TResult> call;

	[Token(Token = "0x400861D")]
	[FieldOffset(Offset = "0x0")]
	public BBParameter<T1> p1;

	[Token(Token = "0x400861E")]
	[FieldOffset(Offset = "0x0")]
	public BBParameter<T2> p2;

	[Token(Token = "0x400861F")]
	[FieldOffset(Offset = "0x0")]
	public BBParameter<T3> p3;

	[Token(Token = "0x4008620")]
	[FieldOffset(Offset = "0x0")]
	public BBParameter<T4> p4;

	[Token(Token = "0x4008621")]
	[FieldOffset(Offset = "0x0")]
	public BBParameter<T5> p5;

	[BlackboardOnly]
	[Token(Token = "0x4008622")]
	[FieldOffset(Offset = "0x0")]
	public BBParameter<TResult> result;

	[Token(Token = "0x60070EC")]
	[Address(RVA = "0x1FC07E0", Offset = "0x1FBF5E0", Length = "0x1E7")]
	public override BBParameter[] GetVariables()
	{
		return null;
	}

	[Token(Token = "0x60070ED")]
	[Address(RVA = "0x1FC09D0", Offset = "0x1FBF7D0", Length = "0x106")]
	public override void Init(object instance)
	{
	}

	[Token(Token = "0x60070EE")]
	[Address(RVA = "0x1FC0AE0", Offset = "0x1FBF8E0", Length = "0x458")]
	public override object Call()
	{
		return null;
	}

	[Token(Token = "0x60070EF")]
	[Address(RVA = "0x1FC0F40", Offset = "0x1FBFD40", Length = "0x3EE")]
	public ReflectedFunction()
	{
	}
}
[Serializable]
[Token(Token = "0x200109E")]
public class ReflectedFunction<TResult, T1, T2, T3, T4, T5, T6> : ReflectedFunctionWrapper
{
	[Token(Token = "0x4008623")]
	[FieldOffset(Offset = "0x0")]
	private FunctionCall<T1, T2, T3, T4, T5, T6, TResult> call;

	[Token(Token = "0x4008624")]
	[FieldOffset(Offset = "0x0")]
	public BBParameter<T1> p1;

	[Token(Token = "0x4008625")]
	[FieldOffset(Offset = "0x0")]
	public BBParameter<T2> p2;

	[Token(Token = "0x4008626")]
	[FieldOffset(Offset = "0x0")]
	public BBParameter<T3> p3;

	[Token(Token = "0x4008627")]
	[FieldOffset(Offset = "0x0")]
	public BBParameter<T4> p4;

	[Token(Token = "0x4008628")]
	[FieldOffset(Offset = "0x0")]
	public BBParameter<T5> p5;

	[Token(Token = "0x4008629")]
	[FieldOffset(Offset = "0x0")]
	public BBParameter<T6> p6;

	[BlackboardOnly]
	[Token(Token = "0x400862A")]
	[FieldOffset(Offset = "0x0")]
	public BBParameter<TResult> result;

	[Token(Token = "0x60070F0")]
	[Address(RVA = "0x1FC1330", Offset = "0x1FC0130", Length = "0x22C")]
	public override BBParameter[] GetVariables()
	{
		return null;
	}

	[Token(Token = "0x60070F1")]
	[Address(RVA = "0x1FC1560", Offset = "0x1FC0360", Length = "0x106")]
	public override void Init(object instance)
	{
	}

	[Token(Token = "0x60070F2")]
	[Address(RVA = "0x1FC1670", Offset = "0x1FC0470", Length = "0x4E7")]
	public override object Call()
	{
		return null;
	}

	[Token(Token = "0x60070F3")]
	[Address(RVA = "0x1FC1B60", Offset = "0x1FC0960", Length = "0x48E")]
	public ReflectedFunction()
	{
	}
}
