using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;

namespace TLD.Electrostatic;

[Token(Token = "0x20013DF")]
public static class ElectrostaticForce
{
	[Token(Token = "0x400918E")]
	private const float FULLY_ACTIVE_THRESHOLD = 0.95f;

	[Token(Token = "0x4009193")]
	private static List<IElectrostaticSource> m_Sources;

	[Token(Token = "0x17000AD1")]
	[field: Token(Token = "0x400918F")]
	public static bool IsActive
	{
		[Token(Token = "0x6007EBB")]
		[Address(RVA = "0x11E5DF0", Offset = "0x11E4BF0", Length = "0x53")]
		get;
		[Token(Token = "0x6007EBC")]
		[Address(RVA = "0x11E5E50", Offset = "0x11E4C50", Length = "0x58")]
		private set;
	}

	[Token(Token = "0x17000AD2")]
	[field: Token(Token = "0x4009190")]
	public static bool IsFullyActive
	{
		[Token(Token = "0x6007EBD")]
		[Address(RVA = "0x11E5EB0", Offset = "0x11E4CB0", Length = "0x54")]
		get;
		[Token(Token = "0x6007EBE")]
		[Address(RVA = "0x11E5F10", Offset = "0x11E4D10", Length = "0x59")]
		private set;
	}

	[Token(Token = "0x17000AD3")]
	[field: Token(Token = "0x4009191")]
	public static float NormalizedActive
	{
		[Token(Token = "0x6007EBF")]
		[Address(RVA = "0x11E5F70", Offset = "0x11E4D70", Length = "0x55")]
		get;
		[Token(Token = "0x6007EC0")]
		[Address(RVA = "0x11E5FD0", Offset = "0x11E4DD0", Length = "0x62")]
		private set;
	}

	[Token(Token = "0x17000AD4")]
	[field: Token(Token = "0x4009192")]
	public static float Strength
	{
		[Token(Token = "0x6007EC1")]
		[Address(RVA = "0x11E6040", Offset = "0x11E4E40", Length = "0x55")]
		get;
		[Token(Token = "0x6007EC2")]
		[Address(RVA = "0x11E60A0", Offset = "0x11E4EA0", Length = "0x62")]
		private set;
	}

	[Token(Token = "0x14000041")]
	public static event Action<bool> m_IsActiveChanged
	{
		[CompilerGenerated]
		[Token(Token = "0x6007EC3")]
		[Address(RVA = "0x11E6110", Offset = "0x11E4F10", Length = "0x1C6")]
		add
		{
		}
		[CompilerGenerated]
		[Token(Token = "0x6007EC4")]
		[Address(RVA = "0x11E62E0", Offset = "0x11E50E0", Length = "0x1C6")]
		remove
		{
		}
	}

	[Token(Token = "0x14000042")]
	public static event Action<bool> m_IsFullyActiveChanged
	{
		[CompilerGenerated]
		[Token(Token = "0x6007EC5")]
		[Address(RVA = "0x11E64B0", Offset = "0x11E52B0", Length = "0x1C6")]
		add
		{
		}
		[CompilerGenerated]
		[Token(Token = "0x6007EC6")]
		[Address(RVA = "0x11E6680", Offset = "0x11E5480", Length = "0x1C6")]
		remove
		{
		}
	}

	[Token(Token = "0x14000043")]
	public static event Action<float> m_NormalizedActiveChanged
	{
		[CompilerGenerated]
		[Token(Token = "0x6007EC7")]
		[Address(RVA = "0x11E6850", Offset = "0x11E5650", Length = "0x1C6")]
		add
		{
		}
		[CompilerGenerated]
		[Token(Token = "0x6007EC8")]
		[Address(RVA = "0x11E6A20", Offset = "0x11E5820", Length = "0x1C6")]
		remove
		{
		}
	}

	[Token(Token = "0x14000044")]
	public static event Action<float> m_StrengthChanged
	{
		[CompilerGenerated]
		[Token(Token = "0x6007EC9")]
		[Address(RVA = "0x11E6BF0", Offset = "0x11E59F0", Length = "0x1C6")]
		add
		{
		}
		[CompilerGenerated]
		[Token(Token = "0x6007ECA")]
		[Address(RVA = "0x11E6DC0", Offset = "0x11E5BC0", Length = "0x1C6")]
		remove
		{
		}
	}

	[Token(Token = "0x6007ECB")]
	[Address(RVA = "0x11E6F90", Offset = "0x11E5D90", Length = "0xBE")]
	public static void Add(IElectrostaticSource source)
	{
	}

	[Token(Token = "0x6007ECC")]
	[Address(RVA = "0x11E7050", Offset = "0x11E5E50", Length = "0x83")]
	public static void Remove(IElectrostaticSource source)
	{
	}

	[Token(Token = "0x6007ECD")]
	[Address(RVA = "0x11E70E0", Offset = "0x11E5EE0", Length = "0x45")]
	public static void Evaluate()
	{
	}

	[Token(Token = "0x6007ECE")]
	[Address(RVA = "0x11E7130", Offset = "0x11E5F30", Length = "0xB53")]
	private static void UpdateValueAndStrength()
	{
	}
}
