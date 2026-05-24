using System;
using Cpp2ILInjected;

namespace UnityEngine.Rendering.PostProcessing;

[Token(Token = "0x2000CC3")]
public abstract class ParameterOverride
{
	[Token(Token = "0x4007F46")]
	[FieldOffset(Offset = "0x10")]
	public bool overrideState;

	[Token(Token = "0x6006540")]
	internal abstract void Interp(ParameterOverride from, ParameterOverride to, float t);

	[Token(Token = "0x6006541")]
	public abstract int GetHash();

	[Token(Token = "0x6006542")]
	[Address(RVA = "0x195EAB0", Offset = "0x195D8B0", Length = "0xC0")]
	public T GetValue<T>()
	{
		return default(T);
	}

	[Token(Token = "0x6006543")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	protected internal virtual void OnEnable()
	{
	}

	[Token(Token = "0x6006544")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	protected internal virtual void OnDisable()
	{
	}

	[Token(Token = "0x6006545")]
	internal abstract void SetValue(ParameterOverride parameter);

	[Token(Token = "0x6006546")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	protected ParameterOverride()
	{
	}
}
[Serializable]
[Token(Token = "0x2000CC4")]
public class ParameterOverride<T> : ParameterOverride
{
	[Token(Token = "0x4007F47")]
	[FieldOffset(Offset = "0x0")]
	public T value;

	[Token(Token = "0x6006547")]
	[Address(RVA = "0x1E65D40", Offset = "0x1E64B40", Length = "0x9")]
	public ParameterOverride()
	{
	}

	[Token(Token = "0x6006548")]
	[Address(RVA = "0x1E65D50", Offset = "0x1E64B50", Length = "0x8")]
	public ParameterOverride(T value)
	{
	}

	[Token(Token = "0x6006549")]
	[Address(RVA = "0x1E65D60", Offset = "0x1E64B60", Length = "0x8")]
	public ParameterOverride(T value, bool overrideState)
	{
	}

	[Token(Token = "0x600654A")]
	[Address(RVA = "0x1E65D70", Offset = "0x1E64B70", Length = "0xA7")]
	internal override void Interp(ParameterOverride from, ParameterOverride to, float t)
	{
	}

	[Token(Token = "0x600654B")]
	[Address(RVA = "0x1E65E20", Offset = "0x1E64C20", Length = "0x28")]
	public virtual void Interp(T from, T to, float t)
	{
	}

	[Token(Token = "0x600654C")]
	[Address(RVA = "0x1E65E50", Offset = "0x1E64C50", Length = "0x83")]
	public void Override(T x)
	{
	}

	[Token(Token = "0x600654D")]
	[Address(RVA = "0x1E65EE0", Offset = "0x1E64CE0", Length = "0x68")]
	public virtual bool Equals(T valueA, T valueB)
	{
		return false;
	}

	[Token(Token = "0x600654E")]
	[Address(RVA = "0x1E65F50", Offset = "0x1E64D50", Length = "0x36")]
	internal override void SetValue(ParameterOverride parameter)
	{
	}

	[Token(Token = "0x600654F")]
	[Address(RVA = "0x1E65F90", Offset = "0x1E64D90", Length = "0x3F")]
	public override int GetHash()
	{
		return 0;
	}

	[Token(Token = "0x6006550")]
	[Address(RVA = "0x1E65FD0", Offset = "0x1E64DD0", Length = "0x17")]
	public static implicit operator T(ParameterOverride<T> prop)
	{
		return default(T);
	}
}
