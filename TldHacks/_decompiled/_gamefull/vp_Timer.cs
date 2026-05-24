using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x2000021")]
public class vp_Timer : MonoBehaviour
{
	[Token(Token = "0x2000022")]
	public delegate void Callback();

	[Token(Token = "0x2000023")]
	public delegate void ArgCallback(object args);

	[Token(Token = "0x400021B")]
	private static GameObject m_GameObject;

	[Token(Token = "0x400021C")]
	[FieldOffset(Offset = "0x20")]
	private Callback m_Function;

	[Token(Token = "0x400021D")]
	[FieldOffset(Offset = "0x28")]
	private ArgCallback m_ArgFunction;

	[Token(Token = "0x400021E")]
	[FieldOffset(Offset = "0x30")]
	private object m_Arguments;

	[Token(Token = "0x400021F")]
	[FieldOffset(Offset = "0x38")]
	private List<vp_Timer> m_Iterations;

	[Token(Token = "0x60001C8")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	private void Awake()
	{
	}

	[Token(Token = "0x60001C9")]
	[Address(RVA = "0x882D70", Offset = "0x881B70", Length = "0x28")]
	public static vp_Timer In(float time, Callback function, int iterations = 1, float interval = 0f)
	{
		return null;
	}

	[Token(Token = "0x60001CA")]
	[Address(RVA = "0x882DA0", Offset = "0x881BA0", Length = "0x30")]
	public static vp_Timer In(float time, ArgCallback function, object args, int iterations = 1, float interval = 0f)
	{
		return null;
	}

	[Token(Token = "0x60001CB")]
	[Address(RVA = "0x882DD0", Offset = "0x881BD0", Length = "0x3B9")]
	private static vp_Timer In(float time, Callback func, ArgCallback argFunc, object args, int iterations, float interval)
	{
		return null;
	}

	[Token(Token = "0x60001CC")]
	[Address(RVA = "0x883190", Offset = "0x881F90", Length = "0xCC")]
	public static void Cancel(vp_Timer timer)
	{
	}

	[Token(Token = "0x60001CD")]
	[Address(RVA = "0x883260", Offset = "0x882060", Length = "0x1DA")]
	public void Cancel()
	{
	}

	[Token(Token = "0x60001CE")]
	[Address(RVA = "0x883440", Offset = "0x882240", Length = "0x7")]
	public new void CancelInvoke(string methodName)
	{
	}

	[Token(Token = "0x60001CF")]
	[Address(RVA = "0x883440", Offset = "0x882240", Length = "0x7")]
	public new void CancelInvoke()
	{
	}

	[Token(Token = "0x60001D0")]
	[Address(RVA = "0x883450", Offset = "0x882250", Length = "0x1E0")]
	private void CancelInstance()
	{
	}

	[Token(Token = "0x60001D1")]
	[Address(RVA = "0x883630", Offset = "0x882430", Length = "0xB1")]
	private void Schedule(float time, Callback function)
	{
	}

	[Token(Token = "0x60001D2")]
	[Address(RVA = "0x8836F0", Offset = "0x8824F0", Length = "0x11D")]
	private void Schedule(float time, ArgCallback function, object args)
	{
	}

	[Token(Token = "0x60001D3")]
	[Address(RVA = "0x883810", Offset = "0x882610", Length = "0x9C")]
	private void Execute()
	{
	}

	[Token(Token = "0x60001D4")]
	[Address(RVA = "0x8838B0", Offset = "0x8826B0", Length = "0xA0")]
	private void ArgExecute()
	{
	}

	[Token(Token = "0x60001D5")]
	[Address(RVA = "0x883950", Offset = "0x882750", Length = "0xE3")]
	public vp_Timer()
	{
	}
}
