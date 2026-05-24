using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.SceneManagement;

[Token(Token = "0x20006FC")]
public class OutdoorSceneRoot : MonoBehaviour
{
	[CompilerGenerated]
	[Token(Token = "0x20006FD")]
	private sealed class _003CStart_003Ed__10 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4004A32")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4004A33")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4004A34")]
		[FieldOffset(Offset = "0x20")]
		public OutdoorSceneRoot _003C_003E4__this;

		[Token(Token = "0x4004A35")]
		[FieldOffset(Offset = "0x28")]
		private int _003CitemCount_003E5__2;

		[Token(Token = "0x4004A36")]
		[FieldOffset(Offset = "0x2C")]
		private int _003CcurrentIndex_003E5__3;

		[Token(Token = "0x17000318")]
		object IEnumerator<object>.Current
		{
			[DebuggerHidden]
			[Token(Token = "0x6003D55")]
			[Address(RVA = "0x4571D0", Offset = "0x455FD0", Length = "0x5")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000319")]
		object IEnumerator.Current
		{
			[DebuggerHidden]
			[Token(Token = "0x6003D57")]
			[Address(RVA = "0x4571D0", Offset = "0x455FD0", Length = "0x5")]
			get
			{
				return null;
			}
		}

		[DebuggerHidden]
		[Token(Token = "0x6003D52")]
		[Address(RVA = "0x4096E0", Offset = "0x4084E0", Length = "0x4")]
		public _003CStart_003Ed__10(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		[Token(Token = "0x6003D53")]
		[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
		void IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6003D54")]
		[Address(RVA = "0xB937F0", Offset = "0xB925F0", Length = "0x1C4")]
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
		[Token(Token = "0x6003D56")]
		[Address(RVA = "0xB939C0", Offset = "0xB927C0", Length = "0x3E")]
		void IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4004A29")]
	[FieldOffset(Offset = "0x20")]
	public List<PrefabInstantiateData> m_CachedPrefabs;

	[Token(Token = "0x4004A2A")]
	public static bool m_CacheEnabled;

	[Token(Token = "0x4004A2B")]
	public static bool m_SpawnCompleted;

	[Token(Token = "0x4004A2C")]
	[FieldOffset(Offset = "0x28")]
	private bool m_InCache;

	[Token(Token = "0x4004A2D")]
	[FieldOffset(Offset = "0x30")]
	private GameObject m_MasterObject;

	[Token(Token = "0x4004A2E")]
	private static int m_NumProcessPerFrame;

	[Token(Token = "0x4004A2F")]
	private static bool m_StaggeredSpawnAtStart;

	[Token(Token = "0x4004A30")]
	private static Dictionary<string, GameObject> m_MasterObjectDict;

	[Token(Token = "0x4004A31")]
	private const string m_MasterObjectPrefix = "Master_";

	[Token(Token = "0x6003D43")]
	[Address(RVA = "0xB91490", Offset = "0xB90290", Length = "0x48A")]
	public void Awake()
	{
	}

	[IteratorStateMachine(typeof(_003CStart_003Ed__10))]
	[Token(Token = "0x6003D44")]
	[Address(RVA = "0xB91920", Offset = "0xB90720", Length = "0x9A")]
	public IEnumerator Start()
	{
		return null;
	}

	[Token(Token = "0x6003D45")]
	[Address(RVA = "0xB919C0", Offset = "0xB907C0", Length = "0x3DA")]
	private static void DeActivate(GameObject masterObject)
	{
	}

	[Token(Token = "0x6003D46")]
	[Address(RVA = "0xB91DA0", Offset = "0xB90BA0", Length = "0x376")]
	private void TrySetGroundLayerRecursive(GameObject go)
	{
	}

	[Token(Token = "0x6003D47")]
	[Address(RVA = "0xB92120", Offset = "0xB90F20", Length = "0x3B1")]
	private void SpawnPrefabs(int start, int endExclusive)
	{
	}

	[Token(Token = "0x6003D48")]
	[Address(RVA = "0xB924E0", Offset = "0xB912E0", Length = "0x457")]
	private void DecachePrefabs(int start, int endExclusive)
	{
	}

	[Token(Token = "0x6003D49")]
	[Address(RVA = "0xB92940", Offset = "0xB91740", Length = "0x14")]
	private void SpawnOrDecachePrefabs(int start, int endExclusive)
	{
	}

	[Token(Token = "0x6003D4A")]
	[Address(RVA = "0xB92960", Offset = "0xB91760", Length = "0xD3")]
	private void LevelLoadedCallback(Scene s, LoadSceneMode mode)
	{
	}

	[Token(Token = "0x6003D4B")]
	[Address(RVA = "0xB92A40", Offset = "0xB91840", Length = "0x8F")]
	private void MoveToCache(Transform prefab)
	{
	}

	[Token(Token = "0x6003D4C")]
	[Address(RVA = "0xB92AD0", Offset = "0xB918D0", Length = "0xE9")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6003D4D")]
	[Address(RVA = "0xB92BC0", Offset = "0xB919C0", Length = "0x4E")]
	private static string GetSceneName()
	{
		return null;
	}

	[Token(Token = "0x6003D4E")]
	[Address(RVA = "0xB92C10", Offset = "0xB91A10", Length = "0x380")]
	private static void MaybeClearCache(string nextScene)
	{
	}

	[Token(Token = "0x6003D4F")]
	[Address(RVA = "0xB92FA0", Offset = "0xB91DA0", Length = "0x626")]
	public static void OnSceneUnload(string nextScene)
	{
	}

	[Token(Token = "0x6003D50")]
	[Address(RVA = "0xB935D0", Offset = "0xB923D0", Length = "0xE3")]
	public OutdoorSceneRoot()
	{
	}
}
