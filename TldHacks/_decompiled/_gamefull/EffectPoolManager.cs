using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x20002D6")]
public class EffectPoolManager : MonoBehaviour
{
	[CompilerGenerated]
	[Token(Token = "0x20002D7")]
	private sealed class _003CStart_003Ed__16 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4001950")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4001951")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4001952")]
		[FieldOffset(Offset = "0x20")]
		public EffectPoolManager _003C_003E4__this;

		[Token(Token = "0x170001F3")]
		object IEnumerator<object>.Current
		{
			[DebuggerHidden]
			[Token(Token = "0x600182A")]
			[Address(RVA = "0x4571D0", Offset = "0x455FD0", Length = "0x5")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001F4")]
		object IEnumerator.Current
		{
			[DebuggerHidden]
			[Token(Token = "0x600182C")]
			[Address(RVA = "0x4571D0", Offset = "0x455FD0", Length = "0x5")]
			get
			{
				return null;
			}
		}

		[DebuggerHidden]
		[Token(Token = "0x6001827")]
		[Address(RVA = "0x4096E0", Offset = "0x4084E0", Length = "0x4")]
		public _003CStart_003Ed__16(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		[Token(Token = "0x6001828")]
		[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
		void IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6001829")]
		[Address(RVA = "0x6E3090", Offset = "0x6E1E90", Length = "0xFC")]
		private bool MoveNext()
		{
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		[DebuggerHidden]
		[Token(Token = "0x600182B")]
		[Address(RVA = "0x6E34D0", Offset = "0x6E22D0", Length = "0x3E")]
		void IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4001946")]
	[FieldOffset(Offset = "0x20")]
	public GameObject m_ArrowImpactEffectPoolPrefab;

	[Token(Token = "0x4001947")]
	[FieldOffset(Offset = "0x28")]
	public GameObject m_BulletImpactEffectPoolPrefab;

	[Token(Token = "0x4001948")]
	[FieldOffset(Offset = "0x30")]
	public GameObject m_SplashEffectPoolPrefab;

	[Token(Token = "0x4001949")]
	[FieldOffset(Offset = "0x38")]
	public GameObject m_HeavyFootstepEffectPoolPrefab;

	[Token(Token = "0x400194A")]
	[FieldOffset(Offset = "0x40")]
	public GameObject m_ScorchImpactEffectPoolPrefab;

	[Token(Token = "0x400194B")]
	[FieldOffset(Offset = "0x48")]
	private ArrowImpactEffectPool m_ArrowImpactEffectPool;

	[Token(Token = "0x400194C")]
	[FieldOffset(Offset = "0x50")]
	private BulletImpactEffectPool m_BulletImpactEffectPool;

	[Token(Token = "0x400194D")]
	[FieldOffset(Offset = "0x58")]
	private SplashEffectPool m_SplashEffectPool;

	[Token(Token = "0x400194E")]
	[FieldOffset(Offset = "0x60")]
	private HeavyFootstepEffectPool m_HeavyFootstepEffectPool;

	[Token(Token = "0x400194F")]
	[FieldOffset(Offset = "0x68")]
	private ScorchImpactEffectPool m_ScorchImpactEffectPool;

	[Token(Token = "0x600181F")]
	[Address(RVA = "0x4B2FE0", Offset = "0x4B1DE0", Length = "0x5")]
	public ArrowImpactEffectPool GetArrowImpactEffectPool()
	{
		return null;
	}

	[Token(Token = "0x6001820")]
	[Address(RVA = "0x669640", Offset = "0x668440", Length = "0x5")]
	public BulletImpactEffectPool GetBulletImpactEffectPool()
	{
		return null;
	}

	[Token(Token = "0x6001821")]
	[Address(RVA = "0x6BCD40", Offset = "0x6BBB40", Length = "0x5")]
	public SplashEffectPool GetSplashEffectPool()
	{
		return null;
	}

	[Token(Token = "0x6001822")]
	[Address(RVA = "0x6E2FE0", Offset = "0x6E1DE0", Length = "0x5")]
	public HeavyFootstepEffectPool GetHeavyFootstepEffectPool()
	{
		return null;
	}

	[Token(Token = "0x6001823")]
	[Address(RVA = "0x65D9D0", Offset = "0x65C7D0", Length = "0x5")]
	public ScorchImpactEffectPool GetScorchImpactEffectPool()
	{
		return null;
	}

	[Token(Token = "0x6001824")]
	[Address(RVA = "0x18BA810", Offset = "0x18B9610", Length = "0x197")]
	private T CreatePool<T>(GameObject effectPoolPrefab)
	{
		return default(T);
	}

	[IteratorStateMachine(typeof(_003CStart_003Ed__16))]
	[Token(Token = "0x6001825")]
	[Address(RVA = "0x6E2FF0", Offset = "0x6E1DF0", Length = "0x9A")]
	public IEnumerator Start()
	{
		return null;
	}

	[Token(Token = "0x6001826")]
	[Address(RVA = "0x4AF5E0", Offset = "0x4AE3E0", Length = "0x43")]
	public EffectPoolManager()
	{
	}
}
