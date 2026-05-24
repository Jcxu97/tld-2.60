using System;
using Cpp2ILInjected;
using ParadoxNotion.Design;

namespace NodeCanvas.Framework.Internal;

[Serializable]
[Token(Token = "0x2001091")]
public class ReflectedAction : ReflectedActionWrapper
{
	[Token(Token = "0x40085EC")]
	[FieldOffset(Offset = "0x18")]
	private ActionCall call;

	[Token(Token = "0x60070BC")]
	[Address(RVA = "0x10CFFA0", Offset = "0x10CEDA0", Length = "0x37")]
	public override BBParameter[] GetVariables()
	{
		return null;
	}

	[Token(Token = "0x60070BD")]
	[Address(RVA = "0x10CFFE0", Offset = "0x10CEDE0", Length = "0xD1")]
	public override void Init(object instance)
	{
	}

	[Token(Token = "0x60070BE")]
	[Address(RVA = "0xD16020", Offset = "0xD14E20", Length = "0x22")]
	public override void Call()
	{
	}

	[Token(Token = "0x60070BF")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public ReflectedAction()
	{
	}
}
[Serializable]
[SpoofAOT]
[Token(Token = "0x2001092")]
public class ReflectedAction<T1> : ReflectedActionWrapper
{
	[Token(Token = "0x40085ED")]
	[FieldOffset(Offset = "0x0")]
	private ActionCall<T1> call;

	[Token(Token = "0x40085EE")]
	[FieldOffset(Offset = "0x0")]
	public BBParameter<T1> p1;

	[Token(Token = "0x60070C0")]
	[Address(RVA = "0x1FB62B0", Offset = "0x1FB50B0", Length = "0x94")]
	public override BBParameter[] GetVariables()
	{
		return null;
	}

	[Token(Token = "0x60070C1")]
	[Address(RVA = "0x1FB6350", Offset = "0x1FB5150", Length = "0xE6")]
	public override void Init(object instance)
	{
	}

	[Token(Token = "0x60070C2")]
	[Address(RVA = "0x1FB6440", Offset = "0x1FB5240", Length = "0x48")]
	public override void Call()
	{
	}

	[Token(Token = "0x60070C3")]
	[Address(RVA = "0x1FB6490", Offset = "0x1FB5290", Length = "0xBC")]
	public ReflectedAction()
	{
	}
}
[Serializable]
[Token(Token = "0x2001093")]
public class ReflectedAction<T1, T2> : ReflectedActionWrapper
{
	[Token(Token = "0x40085EF")]
	[FieldOffset(Offset = "0x0")]
	private ActionCall<T1, T2> call;

	[Token(Token = "0x40085F0")]
	[FieldOffset(Offset = "0x0")]
	public BBParameter<T1> p1;

	[Token(Token = "0x40085F1")]
	[FieldOffset(Offset = "0x0")]
	public BBParameter<T2> p2;

	[Token(Token = "0x60070C4")]
	[Address(RVA = "0x1FB9960", Offset = "0x1FB8760", Length = "0xDB")]
	public override BBParameter[] GetVariables()
	{
		return null;
	}

	[Token(Token = "0x60070C5")]
	[Address(RVA = "0x1FB9A40", Offset = "0x1FB8840", Length = "0x106")]
	public override void Init(object instance)
	{
	}

	[Token(Token = "0x60070C6")]
	[Address(RVA = "0x1FB9B50", Offset = "0x1FB8950", Length = "0x150")]
	public override void Call()
	{
	}

	[Token(Token = "0x60070C7")]
	[Address(RVA = "0x1FB9CB0", Offset = "0x1FB8AB0", Length = "0x16E")]
	public ReflectedAction()
	{
	}
}
[Serializable]
[Token(Token = "0x2001094")]
public class ReflectedAction<T1, T2, T3> : ReflectedActionWrapper
{
	[Token(Token = "0x40085F2")]
	[FieldOffset(Offset = "0x0")]
	private ActionCall<T1, T2, T3> call;

	[Token(Token = "0x40085F3")]
	[FieldOffset(Offset = "0x0")]
	public BBParameter<T1> p1;

	[Token(Token = "0x40085F4")]
	[FieldOffset(Offset = "0x0")]
	public BBParameter<T2> p2;

	[Token(Token = "0x40085F5")]
	[FieldOffset(Offset = "0x0")]
	public BBParameter<T3> p3;

	[Token(Token = "0x60070C8")]
	[Address(RVA = "0x1FB9E20", Offset = "0x1FB8C20", Length = "0x120")]
	public override BBParameter[] GetVariables()
	{
		return null;
	}

	[Token(Token = "0x60070C9")]
	[Address(RVA = "0x1FB9F50", Offset = "0x1FB8D50", Length = "0x106")]
	public override void Init(object instance)
	{
	}

	[Token(Token = "0x60070CA")]
	[Address(RVA = "0x1FBA060", Offset = "0x1FB8E60", Length = "0x1BC")]
	public override void Call()
	{
	}

	[Token(Token = "0x60070CB")]
	[Address(RVA = "0x1FBA220", Offset = "0x1FB9020", Length = "0x20E")]
	public ReflectedAction()
	{
	}
}
[Serializable]
[Token(Token = "0x2001095")]
public class ReflectedAction<T1, T2, T3, T4> : ReflectedActionWrapper
{
	[Token(Token = "0x40085F6")]
	[FieldOffset(Offset = "0x0")]
	private ActionCall<T1, T2, T3, T4> call;

	[Token(Token = "0x40085F7")]
	[FieldOffset(Offset = "0x0")]
	public BBParameter<T1> p1;

	[Token(Token = "0x40085F8")]
	[FieldOffset(Offset = "0x0")]
	public BBParameter<T2> p2;

	[Token(Token = "0x40085F9")]
	[FieldOffset(Offset = "0x0")]
	public BBParameter<T3> p3;

	[Token(Token = "0x40085FA")]
	[FieldOffset(Offset = "0x0")]
	public BBParameter<T4> p4;

	[Token(Token = "0x60070CC")]
	[Address(RVA = "0x1FBA430", Offset = "0x1FB9230", Length = "0x161")]
	public override BBParameter[] GetVariables()
	{
		return null;
	}

	[Token(Token = "0x60070CD")]
	[Address(RVA = "0x1FBA5A0", Offset = "0x1FB93A0", Length = "0x106")]
	public override void Init(object instance)
	{
	}

	[Token(Token = "0x60070CE")]
	[Address(RVA = "0x1FBA6B0", Offset = "0x1FB94B0", Length = "0x238")]
	public override void Call()
	{
	}

	[Token(Token = "0x60070CF")]
	[Address(RVA = "0x1FBA8F0", Offset = "0x1FB96F0", Length = "0x2AE")]
	public ReflectedAction()
	{
	}
}
[Serializable]
[Token(Token = "0x2001096")]
public class ReflectedAction<T1, T2, T3, T4, T5> : ReflectedActionWrapper
{
	[Token(Token = "0x40085FB")]
	[FieldOffset(Offset = "0x0")]
	private ActionCall<T1, T2, T3, T4, T5> call;

	[Token(Token = "0x40085FC")]
	[FieldOffset(Offset = "0x0")]
	public BBParameter<T1> p1;

	[Token(Token = "0x40085FD")]
	[FieldOffset(Offset = "0x0")]
	public BBParameter<T2> p2;

	[Token(Token = "0x40085FE")]
	[FieldOffset(Offset = "0x0")]
	public BBParameter<T3> p3;

	[Token(Token = "0x40085FF")]
	[FieldOffset(Offset = "0x0")]
	public BBParameter<T4> p4;

	[Token(Token = "0x4008600")]
	[FieldOffset(Offset = "0x0")]
	public BBParameter<T5> p5;

	[Token(Token = "0x60070D0")]
	[Address(RVA = "0x1FBABA0", Offset = "0x1FB99A0", Length = "0x1A6")]
	public override BBParameter[] GetVariables()
	{
		return null;
	}

	[Token(Token = "0x60070D1")]
	[Address(RVA = "0x1FBAD50", Offset = "0x1FB9B50", Length = "0x106")]
	public override void Init(object instance)
	{
	}

	[Token(Token = "0x60070D2")]
	[Address(RVA = "0x1FBAE60", Offset = "0x1FB9C60", Length = "0x2B3")]
	public override void Call()
	{
	}

	[Token(Token = "0x60070D3")]
	[Address(RVA = "0x1FBB120", Offset = "0x1FB9F20", Length = "0x34E")]
	public ReflectedAction()
	{
	}
}
[Serializable]
[Token(Token = "0x2001097")]
public class ReflectedAction<T1, T2, T3, T4, T5, T6> : ReflectedActionWrapper
{
	[Token(Token = "0x4008601")]
	[FieldOffset(Offset = "0x0")]
	private ActionCall<T1, T2, T3, T4, T5, T6> call;

	[Token(Token = "0x4008602")]
	[FieldOffset(Offset = "0x0")]
	public BBParameter<T1> p1;

	[Token(Token = "0x4008603")]
	[FieldOffset(Offset = "0x0")]
	public BBParameter<T2> p2;

	[Token(Token = "0x4008604")]
	[FieldOffset(Offset = "0x0")]
	public BBParameter<T3> p3;

	[Token(Token = "0x4008605")]
	[FieldOffset(Offset = "0x0")]
	public BBParameter<T4> p4;

	[Token(Token = "0x4008606")]
	[FieldOffset(Offset = "0x0")]
	public BBParameter<T5> p5;

	[Token(Token = "0x4008607")]
	[FieldOffset(Offset = "0x0")]
	public BBParameter<T6> p6;

	[Token(Token = "0x60070D4")]
	[Address(RVA = "0x1FBB470", Offset = "0x1FBA270", Length = "0x1E7")]
	public override BBParameter[] GetVariables()
	{
		return null;
	}

	[Token(Token = "0x60070D5")]
	[Address(RVA = "0x1FBB660", Offset = "0x1FBA460", Length = "0x106")]
	public override void Init(object instance)
	{
	}

	[Token(Token = "0x60070D6")]
	[Address(RVA = "0x1FBB770", Offset = "0x1FBA570", Length = "0x345")]
	public override void Call()
	{
	}

	[Token(Token = "0x60070D7")]
	[Address(RVA = "0x1FBBAC0", Offset = "0x1FBA8C0", Length = "0x3EE")]
	public ReflectedAction()
	{
	}
}
