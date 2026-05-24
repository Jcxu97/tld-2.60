using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using UnityEngine.Build.Pipeline;

[Token(Token = "0x20001AE")]
public class AssetBundleManager
{
	[CompilerGenerated]
	[Token(Token = "0x20001AF")]
	private sealed class _003CGetAllBundles_003Ed__6 : IEnumerable<AssetBundleRef>, IEnumerable, IEnumerator<AssetBundleRef>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000F1D")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4000F1E")]
		[FieldOffset(Offset = "0x18")]
		private AssetBundleRef _003C_003E2__current;

		[Token(Token = "0x4000F1F")]
		[FieldOffset(Offset = "0x20")]
		private int _003C_003El__initialThreadId;

		[Token(Token = "0x4000F20")]
		[FieldOffset(Offset = "0x28")]
		private Dictionary<int, AssetBundleRef>.ValueCollection.Enumerator _003Cenumerator_003E5__2;

		[Token(Token = "0x170001B7")]
		AssetBundleRef IEnumerator<AssetBundleRef>.Current
		{
			[DebuggerHidden]
			[Token(Token = "0x6000FBA")]
			[Address(RVA = "0x4571D0", Offset = "0x455FD0", Length = "0x5")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001B8")]
		object IEnumerator.Current
		{
			[DebuggerHidden]
			[Token(Token = "0x6000FBC")]
			[Address(RVA = "0x4571D0", Offset = "0x455FD0", Length = "0x5")]
			get
			{
				return null;
			}
		}

		[DebuggerHidden]
		[Token(Token = "0x6000FB7")]
		[Address(RVA = "0x61AD60", Offset = "0x619B60", Length = "0x1C")]
		public _003CGetAllBundles_003Ed__6(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		[Token(Token = "0x6000FB8")]
		[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
		void IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000FB9")]
		[Address(RVA = "0x61AD80", Offset = "0x619B80", Length = "0x265")]
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
		[Token(Token = "0x6000FBB")]
		[Address(RVA = "0x61AFF0", Offset = "0x619DF0", Length = "0x3E")]
		void IEnumerator.Reset()
		{
		}

		[DebuggerHidden]
		[Token(Token = "0x6000FBD")]
		[Address(RVA = "0x61B030", Offset = "0x619E30", Length = "0x86")]
		IEnumerator<AssetBundleRef> IEnumerable<AssetBundleRef>.GetEnumerator()
		{
			return null;
		}

		[DebuggerHidden]
		[Token(Token = "0x6000FBE")]
		[Address(RVA = "0x61B030", Offset = "0x619E30", Length = "0x86")]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Token(Token = "0x4000F17")]
	private static CompatibilityAssetBundleManifest s_Manifest;

	[Token(Token = "0x4000F18")]
	private static string s_BundlePath;

	[Token(Token = "0x4000F19")]
	private static List<AssetBundleRef> s_AsyncLoads;

	[Token(Token = "0x4000F1A")]
	private static List<AssetBundleRef> s_CompletedLoads;

	[Token(Token = "0x4000F1B")]
	private static Dictionary<int, AssetBundleRef> s_Bundles;

	[Token(Token = "0x4000F1C")]
	private static bool s_Verbose;

	[IteratorStateMachine(typeof(_003CGetAllBundles_003Ed__6))]
	[Token(Token = "0x6000FA1")]
	[Address(RVA = "0x619280", Offset = "0x618080", Length = "0x50")]
	public static IEnumerable<AssetBundleRef> GetAllBundles()
	{
		return null;
	}

	[Token(Token = "0x6000FA2")]
	[Address(RVA = "0x6192D0", Offset = "0x6180D0", Length = "0x54")]
	public static string GetBundlePath()
	{
		return null;
	}

	[Token(Token = "0x6000FA3")]
	[Address(RVA = "0x619330", Offset = "0x618130", Length = "0x144")]
	public static IEnumerable<string> GetDependencies(string bundle)
	{
		return null;
	}

	[Token(Token = "0x6000FA4")]
	[Address(RVA = "0x619480", Offset = "0x618280", Length = "0x76")]
	public static bool IsLoading()
	{
		return false;
	}

	[Token(Token = "0x6000FA5")]
	[Address(RVA = "0x619500", Offset = "0x618300", Length = "0x54")]
	public static bool IsVerbose()
	{
		return false;
	}

	[Token(Token = "0x6000FA6")]
	[Address(RVA = "0x4A2140", Offset = "0x4A0F40", Length = "0x3")]
	public static bool IsSimulating()
	{
		return false;
	}

	[Token(Token = "0x6000FA7")]
	[Address(RVA = "0x619560", Offset = "0x618360", Length = "0x312")]
	public static void Init()
	{
	}

	[Token(Token = "0x6000FA8")]
	[Address(RVA = "0x619880", Offset = "0x618680", Length = "0x4CC")]
	public static void Update()
	{
	}

	[Token(Token = "0x6000FA9")]
	[Address(RVA = "0x619D50", Offset = "0x618B50", Length = "0x31")]
	internal static string GetPlatformName()
	{
		return null;
	}

	[Token(Token = "0x6000FAA")]
	[Address(RVA = "0x619D90", Offset = "0x618B90", Length = "0xC9")]
	private static AssetBundleRef CreateReference(string name)
	{
		return null;
	}

	[Token(Token = "0x6000FAB")]
	[Address(RVA = "0x619E60", Offset = "0x618C60", Length = "0xCE")]
	private static AssetBundleRef FindBundleByName(string name)
	{
		return null;
	}

	[Token(Token = "0x6000FAC")]
	[Address(RVA = "0x619F30", Offset = "0x618D30", Length = "0x19")]
	public static bool BundleExists(string bundleName, string fileName = "")
	{
		return false;
	}

	[Token(Token = "0x6000FAD")]
	[Address(RVA = "0x619F50", Offset = "0x618D50", Length = "0x12C")]
	public static AssetBundleRef LoadBundle(string name)
	{
		return null;
	}

	[Token(Token = "0x6000FAE")]
	[Address(RVA = "0x61A080", Offset = "0x618E80", Length = "0x15C")]
	public static AssetBundleRef LoadBundleAsync(string name)
	{
		return null;
	}

	[Token(Token = "0x6000FAF")]
	[Address(RVA = "0x61A1E0", Offset = "0x618FE0", Length = "0x219")]
	private static void LoadManifest()
	{
	}

	[Token(Token = "0x6000FB0")]
	[Address(RVA = "0x61A400", Offset = "0x619200", Length = "0x221")]
	public static void UnloadBundle(AssetBundleRef bundle, bool unloadAllLoadedObjects)
	{
	}

	[Token(Token = "0x6000FB1")]
	[Address(RVA = "0x61A630", Offset = "0x619430", Length = "0x2FC")]
	public static void UnloadBundle(string name, bool unloadAllLoadedObjects)
	{
	}

	[Conditional("__DEBUG")]
	[Token(Token = "0x6000FB2")]
	[Address(RVA = "0x61A930", Offset = "0x619730", Length = "0x43")]
	public static void VerboseLog(string message)
	{
	}

	[Conditional("__DEBUG")]
	[Token(Token = "0x6000FB3")]
	[Address(RVA = "0x61A980", Offset = "0x619780", Length = "0x43")]
	public static void VerboseLogWarning(string message)
	{
	}

	[Conditional("__DEBUG")]
	[Token(Token = "0x6000FB4")]
	[Address(RVA = "0x61A9D0", Offset = "0x6197D0", Length = "0x43")]
	public static void VerboseLogError(string message)
	{
	}

	[Token(Token = "0x6000FB5")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public AssetBundleManager()
	{
	}
}
