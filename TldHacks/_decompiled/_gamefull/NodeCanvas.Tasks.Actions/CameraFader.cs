using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using UnityEngine;

namespace NodeCanvas.Tasks.Actions;

[Token(Token = "0x20012B3")]
public class CameraFader : MonoBehaviour
{
	[CompilerGenerated]
	[Token(Token = "0x20012B4")]
	private sealed class _003CCoroutineFadeIn_003Ed__9 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4008BAD")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4008BAE")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4008BAF")]
		[FieldOffset(Offset = "0x20")]
		public CameraFader _003C_003E4__this;

		[Token(Token = "0x4008BB0")]
		[FieldOffset(Offset = "0x28")]
		public float time;

		[Token(Token = "0x170009E3")]
		object IEnumerator<object>.Current
		{
			[DebuggerHidden]
			[Token(Token = "0x60078EF")]
			[Address(RVA = "0x4571D0", Offset = "0x455FD0", Length = "0x5")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170009E4")]
		object IEnumerator.Current
		{
			[DebuggerHidden]
			[Token(Token = "0x60078F1")]
			[Address(RVA = "0x4571D0", Offset = "0x455FD0", Length = "0x5")]
			get
			{
				return null;
			}
		}

		[DebuggerHidden]
		[Token(Token = "0x60078EC")]
		[Address(RVA = "0x4096E0", Offset = "0x4084E0", Length = "0x4")]
		public _003CCoroutineFadeIn_003Ed__9(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		[Token(Token = "0x60078ED")]
		[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
		void IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60078EE")]
		[Address(RVA = "0x1174440", Offset = "0x1173240", Length = "0x131")]
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
		[Token(Token = "0x60078F0")]
		[Address(RVA = "0x1174580", Offset = "0x1173380", Length = "0x3E")]
		void IEnumerator.Reset()
		{
		}
	}

	[CompilerGenerated]
	[Token(Token = "0x20012B5")]
	private sealed class _003CCoroutineFadeOut_003Ed__10 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4008BB1")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4008BB2")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4008BB3")]
		[FieldOffset(Offset = "0x20")]
		public CameraFader _003C_003E4__this;

		[Token(Token = "0x4008BB4")]
		[FieldOffset(Offset = "0x28")]
		public float time;

		[Token(Token = "0x170009E5")]
		object IEnumerator<object>.Current
		{
			[DebuggerHidden]
			[Token(Token = "0x60078F5")]
			[Address(RVA = "0x4571D0", Offset = "0x455FD0", Length = "0x5")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170009E6")]
		object IEnumerator.Current
		{
			[DebuggerHidden]
			[Token(Token = "0x60078F7")]
			[Address(RVA = "0x4571D0", Offset = "0x455FD0", Length = "0x5")]
			get
			{
				return null;
			}
		}

		[DebuggerHidden]
		[Token(Token = "0x60078F2")]
		[Address(RVA = "0x4096E0", Offset = "0x4084E0", Length = "0x4")]
		public _003CCoroutineFadeOut_003Ed__10(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		[Token(Token = "0x60078F3")]
		[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
		void IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60078F4")]
		[Address(RVA = "0x11745C0", Offset = "0x11733C0", Length = "0x13A")]
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
		[Token(Token = "0x60078F6")]
		[Address(RVA = "0x1174700", Offset = "0x1173500", Length = "0x3E")]
		void IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4008BAA")]
	private static CameraFader _current;

	[Token(Token = "0x4008BAB")]
	[FieldOffset(Offset = "0x20")]
	private float alpha;

	[Token(Token = "0x4008BAC")]
	[FieldOffset(Offset = "0x28")]
	private Texture2D _blackTexture;

	[Token(Token = "0x170009E1")]
	private Texture2D blackTexture
	{
		[Token(Token = "0x60078E4")]
		[Address(RVA = "0x11739D0", Offset = "0x11727D0", Length = "0x19E")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170009E2")]
	public static CameraFader current
	{
		[Token(Token = "0x60078E5")]
		[Address(RVA = "0x1173B70", Offset = "0x1172970", Length = "0x35A")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60078E6")]
	[Address(RVA = "0x1173ED0", Offset = "0x1172CD0", Length = "0xB1")]
	public void FadeIn(float time)
	{
	}

	[Token(Token = "0x60078E7")]
	[Address(RVA = "0x1173F90", Offset = "0x1172D90", Length = "0xB1")]
	public void FadeOut(float time)
	{
	}

	[IteratorStateMachine(typeof(_003CCoroutineFadeIn_003Ed__9))]
	[Token(Token = "0x60078E8")]
	[Address(RVA = "0x1174050", Offset = "0x1172E50", Length = "0xB7")]
	private IEnumerator CoroutineFadeIn(float time)
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CCoroutineFadeOut_003Ed__10))]
	[Token(Token = "0x60078E9")]
	[Address(RVA = "0x1174110", Offset = "0x1172F10", Length = "0xB7")]
	private IEnumerator CoroutineFadeOut(float time)
	{
		return null;
	}

	[Token(Token = "0x60078EA")]
	[Address(RVA = "0x11741D0", Offset = "0x1172FD0", Length = "0x26B")]
	private void OnGUI()
	{
	}

	[Token(Token = "0x60078EB")]
	[Address(RVA = "0x4AF5E0", Offset = "0x4AE3E0", Length = "0x43")]
	public CameraFader()
	{
	}
}
