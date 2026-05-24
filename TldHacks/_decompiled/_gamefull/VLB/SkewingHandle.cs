using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using UnityEngine;

namespace VLB;

[ExecuteInEditMode]
[HelpURL("http://saladgamer.com/vlb-doc/comp-skewinghandle/")]
[Token(Token = "0x2000BE5")]
public class SkewingHandle : MonoBehaviour
{
	[CompilerGenerated]
	[Token(Token = "0x2000BE6")]
	private sealed class _003CCoUpdate_003Ed__8 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400798B")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400798C")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400798D")]
		[FieldOffset(Offset = "0x20")]
		public SkewingHandle _003C_003E4__this;

		[Token(Token = "0x170003E6")]
		object IEnumerator<object>.Current
		{
			[DebuggerHidden]
			[Token(Token = "0x6005DC2")]
			[Address(RVA = "0x4571D0", Offset = "0x455FD0", Length = "0x5")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170003E7")]
		object IEnumerator.Current
		{
			[DebuggerHidden]
			[Token(Token = "0x6005DC4")]
			[Address(RVA = "0x4571D0", Offset = "0x455FD0", Length = "0x5")]
			get
			{
				return null;
			}
		}

		[DebuggerHidden]
		[Token(Token = "0x6005DBF")]
		[Address(RVA = "0x4096E0", Offset = "0x4084E0", Length = "0x4")]
		public _003CCoUpdate_003Ed__8(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		[Token(Token = "0x6005DC0")]
		[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
		void IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6005DC1")]
		[Address(RVA = "0xF6A5C0", Offset = "0xF693C0", Length = "0xD7")]
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
		[Token(Token = "0x6005DC3")]
		[Address(RVA = "0xF6A6A0", Offset = "0xF694A0", Length = "0x3E")]
		void IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4007989")]
	[FieldOffset(Offset = "0x20")]
	public VolumetricLightBeam volumetricLightBeam;

	[Token(Token = "0x400798A")]
	[FieldOffset(Offset = "0x28")]
	public bool shouldUpdateEachFrame;

	[Token(Token = "0x6005DB6")]
	[Address(RVA = "0xF69E50", Offset = "0xF68C50", Length = "0x1F9")]
	public bool IsAttachedToSelf()
	{
		return false;
	}

	[Token(Token = "0x6005DB7")]
	[Address(RVA = "0xF6A050", Offset = "0xF68E50", Length = "0xEC")]
	public bool CanSetSkewingVector()
	{
		return false;
	}

	[Token(Token = "0x6005DB8")]
	[Address(RVA = "0xF6A140", Offset = "0xF68F40", Length = "0x35")]
	public bool CanUpdateEachFrame()
	{
		return false;
	}

	[Token(Token = "0x6005DB9")]
	[Address(RVA = "0xF6A180", Offset = "0xF68F80", Length = "0x3D")]
	private bool ShouldUpdateEachFrame()
	{
		return false;
	}

	[Token(Token = "0x6005DBA")]
	[Address(RVA = "0xF6A1C0", Offset = "0xF68FC0", Length = "0x29")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6005DBB")]
	[Address(RVA = "0xF6A1F0", Offset = "0xF68FF0", Length = "0x166")]
	private void Start()
	{
	}

	[IteratorStateMachine(typeof(_003CCoUpdate_003Ed__8))]
	[Token(Token = "0x6005DBC")]
	[Address(RVA = "0xF6A360", Offset = "0xF69160", Length = "0x9A")]
	private IEnumerator CoUpdate()
	{
		return null;
	}

	[Token(Token = "0x6005DBD")]
	[Address(RVA = "0xF6A400", Offset = "0xF69200", Length = "0x1B1")]
	private void SetSkewingVector()
	{
	}

	[Token(Token = "0x6005DBE")]
	[Address(RVA = "0x4AF5E0", Offset = "0x4AE3E0", Length = "0x43")]
	public SkewingHandle()
	{
	}
}
