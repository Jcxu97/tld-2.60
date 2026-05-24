using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x2000AE5")]
public class MB_DynamicAddDeleteExample : MonoBehaviour
{
	[CompilerGenerated]
	[Token(Token = "0x2000AE6")]
	private sealed class _003ClargeNumber_003Ed__6 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4006957")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4006958")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4006959")]
		[FieldOffset(Offset = "0x20")]
		public MB_DynamicAddDeleteExample _003C_003E4__this;

		[Token(Token = "0x170003B8")]
		object IEnumerator<object>.Current
		{
			[DebuggerHidden]
			[Token(Token = "0x6005CD0")]
			[Address(RVA = "0x4571D0", Offset = "0x455FD0", Length = "0x5")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170003B9")]
		object IEnumerator.Current
		{
			[DebuggerHidden]
			[Token(Token = "0x6005CD2")]
			[Address(RVA = "0x4571D0", Offset = "0x455FD0", Length = "0x5")]
			get
			{
				return null;
			}
		}

		[DebuggerHidden]
		[Token(Token = "0x6005CCD")]
		[Address(RVA = "0x4096E0", Offset = "0x4084E0", Length = "0x4")]
		public _003ClargeNumber_003Ed__6(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		[Token(Token = "0x6005CCE")]
		[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
		void IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6005CCF")]
		[Address(RVA = "0xF57170", Offset = "0xF55F70", Length = "0x214")]
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
		[Token(Token = "0x6005CD1")]
		[Address(RVA = "0xF57390", Offset = "0xF56190", Length = "0x3E")]
		void IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4006953")]
	[FieldOffset(Offset = "0x20")]
	public GameObject prefab;

	[Token(Token = "0x4006954")]
	[FieldOffset(Offset = "0x28")]
	private List<GameObject> objsInCombined;

	[Token(Token = "0x4006955")]
	[FieldOffset(Offset = "0x30")]
	private MB3_MultiMeshBaker mbd;

	[Token(Token = "0x4006956")]
	[FieldOffset(Offset = "0x38")]
	private GameObject[] objs;

	[Token(Token = "0x6005CC8")]
	[Address(RVA = "0xF56730", Offset = "0xF55530", Length = "0x129")]
	private float GaussianValue()
	{
		return 0f;
	}

	[Token(Token = "0x6005CC9")]
	[Address(RVA = "0xF56860", Offset = "0xF55660", Length = "0x713")]
	private void Start()
	{
	}

	[IteratorStateMachine(typeof(_003ClargeNumber_003Ed__6))]
	[Token(Token = "0x6005CCA")]
	[Address(RVA = "0xF56F80", Offset = "0xF55D80", Length = "0x9A")]
	private IEnumerator largeNumber()
	{
		return null;
	}

	[Token(Token = "0x6005CCB")]
	[Address(RVA = "0xF57020", Offset = "0xF55E20", Length = "0x58")]
	private void OnGUI()
	{
	}

	[Token(Token = "0x6005CCC")]
	[Address(RVA = "0xF57080", Offset = "0xF55E80", Length = "0xE3")]
	public MB_DynamicAddDeleteExample()
	{
	}
}
