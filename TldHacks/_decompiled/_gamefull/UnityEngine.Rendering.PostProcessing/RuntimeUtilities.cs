using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;

namespace UnityEngine.Rendering.PostProcessing;

[Token(Token = "0x2000CFA")]
public static class RuntimeUtilities
{
	[CompilerGenerated]
	[Token(Token = "0x2000CFD")]
	private sealed class _003CGetAllSceneObjects_003Ed__87<T> : IEnumerable<T>, IEnumerable, IEnumerator<T>, IEnumerator, IDisposable where T : Component
	{
		[Token(Token = "0x4008061")]
		[FieldOffset(Offset = "0x0")]
		private int _003C_003E1__state;

		[Token(Token = "0x4008062")]
		[FieldOffset(Offset = "0x0")]
		private T _003C_003E2__current;

		[Token(Token = "0x4008063")]
		[FieldOffset(Offset = "0x0")]
		private int _003C_003El__initialThreadId;

		[Token(Token = "0x4008064")]
		[FieldOffset(Offset = "0x0")]
		private Queue<Transform> _003Cqueue_003E5__2;

		[Token(Token = "0x4008065")]
		[FieldOffset(Offset = "0x0")]
		private GameObject[] _003C_003E7__wrap2;

		[Token(Token = "0x4008066")]
		[FieldOffset(Offset = "0x0")]
		private int _003C_003E7__wrap3;

		[Token(Token = "0x4008067")]
		[FieldOffset(Offset = "0x0")]
		private IEnumerator _003C_003E7__wrap4;

		[Token(Token = "0x1700070C")]
		T IEnumerator<T>.Current
		{
			[DebuggerHidden]
			[Token(Token = "0x60066DD")]
			[Address(RVA = "0x4571D0", Offset = "0x455FD0", Length = "0x5")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700070D")]
		object IEnumerator.Current
		{
			[DebuggerHidden]
			[Token(Token = "0x60066DF")]
			[Address(RVA = "0x4571D0", Offset = "0x455FD0", Length = "0x5")]
			get
			{
				return null;
			}
		}

		[DebuggerHidden]
		[Token(Token = "0x60066D9")]
		[Address(RVA = "0x61AD60", Offset = "0x619B60", Length = "0x1C")]
		public _003CGetAllSceneObjects_003Ed__87(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		[Token(Token = "0x60066DA")]
		[Address(RVA = "0x1AAE080", Offset = "0x1AACE80", Length = "0x3B")]
		void IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60066DB")]
		[Address(RVA = "0x1AAE0C0", Offset = "0x1AACEC0", Length = "0x7C3")]
		private bool MoveNext()
		{
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		[Token(Token = "0x60066DC")]
		[Address(RVA = "0x1AAE890", Offset = "0x1AAD690", Length = "0x62")]
		private void _003C_003Em__Finally1()
		{
		}

		[DebuggerHidden]
		[Token(Token = "0x60066DE")]
		[Address(RVA = "0x1AA27E0", Offset = "0x1AA15E0", Length = "0x39")]
		void IEnumerator.Reset()
		{
		}

		[DebuggerHidden]
		[Token(Token = "0x60066E0")]
		[Address(RVA = "0x1AAE900", Offset = "0x1AAD700", Length = "0x91")]
		IEnumerator<T> IEnumerable<T>.GetEnumerator()
		{
			return null;
		}

		[DebuggerHidden]
		[Token(Token = "0x60066E1")]
		[Address(RVA = "0x1AAE9A0", Offset = "0x1AAD7A0", Length = "0x9D")]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Token(Token = "0x400804D")]
	private static Texture2D m_WhiteTexture;

	[Token(Token = "0x400804E")]
	private static Texture3D m_WhiteTexture3D;

	[Token(Token = "0x400804F")]
	private static Texture2D m_BlackTexture;

	[Token(Token = "0x4008050")]
	private static Texture3D m_BlackTexture3D;

	[Token(Token = "0x4008051")]
	private static Texture2D m_TransparentTexture;

	[Token(Token = "0x4008052")]
	private static Texture3D m_TransparentTexture3D;

	[Token(Token = "0x4008053")]
	private static Dictionary<int, Texture2D> m_LutStrips;

	[Token(Token = "0x4008054")]
	private static PostProcessResources s_Resources;

	[Token(Token = "0x4008055")]
	private static Mesh s_FullscreenTriangle;

	[Token(Token = "0x4008056")]
	private static Material s_CopyStdMaterial;

	[Token(Token = "0x4008057")]
	private static Material s_CopyStdFromDoubleWideMaterial;

	[Token(Token = "0x4008058")]
	private static Material s_CopyMaterial;

	[Token(Token = "0x4008059")]
	private static Material s_CopyFromTexArrayMaterial;

	[Token(Token = "0x400805A")]
	private static PropertySheet s_CopySheet;

	[Token(Token = "0x400805B")]
	private static PropertySheet s_CopyFromTexArraySheet;

	[Token(Token = "0x400805C")]
	private static IEnumerable<Type> m_AssemblyTypes;

	[Token(Token = "0x170006F6")]
	public static Texture2D whiteTexture
	{
		[Token(Token = "0x6006695")]
		[Address(RVA = "0x102A8E0", Offset = "0x10296E0", Length = "0x2B6")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170006F7")]
	public static Texture3D whiteTexture3D
	{
		[Token(Token = "0x6006696")]
		[Address(RVA = "0x102ABA0", Offset = "0x10299A0", Length = "0x2CE")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170006F8")]
	public static Texture2D blackTexture
	{
		[Token(Token = "0x6006697")]
		[Address(RVA = "0x102AE70", Offset = "0x1029C70", Length = "0x2C8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170006F9")]
	public static Texture3D blackTexture3D
	{
		[Token(Token = "0x6006698")]
		[Address(RVA = "0x102B140", Offset = "0x1029F40", Length = "0x2CE")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170006FA")]
	public static Texture2D transparentTexture
	{
		[Token(Token = "0x6006699")]
		[Address(RVA = "0x102B410", Offset = "0x102A210", Length = "0x2C4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170006FB")]
	public static Texture3D transparentTexture3D
	{
		[Token(Token = "0x600669A")]
		[Address(RVA = "0x102B6E0", Offset = "0x102A4E0", Length = "0x2CA")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170006FC")]
	public static Mesh fullscreenTriangle
	{
		[Token(Token = "0x600669C")]
		[Address(RVA = "0x102BE40", Offset = "0x102AC40", Length = "0x6E1")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170006FD")]
	public static Material copyStdMaterial
	{
		[Token(Token = "0x600669D")]
		[Address(RVA = "0x102C530", Offset = "0x102B330", Length = "0x253")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170006FE")]
	public static Material copyStdFromDoubleWideMaterial
	{
		[Token(Token = "0x600669E")]
		[Address(RVA = "0x102C790", Offset = "0x102B590", Length = "0x253")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170006FF")]
	public static Material copyMaterial
	{
		[Token(Token = "0x600669F")]
		[Address(RVA = "0x102C9F0", Offset = "0x102B7F0", Length = "0x253")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000700")]
	public static Material copyFromTexArrayMaterial
	{
		[Token(Token = "0x60066A0")]
		[Address(RVA = "0x102CC50", Offset = "0x102BA50", Length = "0x253")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000701")]
	public static PropertySheet copySheet
	{
		[Token(Token = "0x60066A1")]
		[Address(RVA = "0x102CEB0", Offset = "0x102BCB0", Length = "0x14D")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000702")]
	public static PropertySheet copyFromTexArraySheet
	{
		[Token(Token = "0x60066A2")]
		[Address(RVA = "0x102D000", Offset = "0x102BE00", Length = "0x14D")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000703")]
	public static bool scriptableRenderPipelineActive
	{
		[Token(Token = "0x60066B5")]
		[Address(RVA = "0x102FD30", Offset = "0x102EB30", Length = "0xF3")]
		get
		{
			return false;
		}
	}

	[Token(Token = "0x17000704")]
	public static bool supportsDeferredShading
	{
		[Token(Token = "0x60066B6")]
		[Address(RVA = "0x102FE30", Offset = "0x102EC30", Length = "0xBA")]
		get
		{
			return false;
		}
	}

	[Token(Token = "0x17000705")]
	public static bool supportsDepthNormals
	{
		[Token(Token = "0x60066B7")]
		[Address(RVA = "0x102FEF0", Offset = "0x102ECF0", Length = "0xBD")]
		get
		{
			return false;
		}
	}

	[Token(Token = "0x17000706")]
	public static bool isSinglePassStereoEnabled
	{
		[Token(Token = "0x60066B8")]
		[Address(RVA = "0x4A2140", Offset = "0x4A0F40", Length = "0x3")]
		get
		{
			return false;
		}
	}

	[Token(Token = "0x17000707")]
	public static bool isVREnabled
	{
		[Token(Token = "0x60066B9")]
		[Address(RVA = "0x4A2140", Offset = "0x4A0F40", Length = "0x3")]
		get
		{
			return false;
		}
	}

	[Token(Token = "0x17000708")]
	public static bool isAndroidOpenGL
	{
		[Token(Token = "0x60066BA")]
		[Address(RVA = "0x102FFB0", Offset = "0x102EDB0", Length = "0xCA")]
		get
		{
			return false;
		}
	}

	[Token(Token = "0x17000709")]
	public static bool isWebNonWebGPU
	{
		[Token(Token = "0x60066BB")]
		[Address(RVA = "0x1030080", Offset = "0x102EE80", Length = "0xCA")]
		get
		{
			return false;
		}
	}

	[Token(Token = "0x1700070A")]
	public static RenderTextureFormat defaultHDRRenderTextureFormat
	{
		[Token(Token = "0x60066BC")]
		[Address(RVA = "0x457400", Offset = "0x456200", Length = "0x6")]
		get
		{
			return default(RenderTextureFormat);
		}
	}

	[Token(Token = "0x1700070B")]
	public static bool isLinearColorSpace
	{
		[Token(Token = "0x60066C0")]
		[Address(RVA = "0x1030330", Offset = "0x102F130", Length = "0x4B")]
		get
		{
			return false;
		}
	}

	[Token(Token = "0x600669B")]
	[Address(RVA = "0x102B9B0", Offset = "0x102A7B0", Length = "0x489")]
	public static Texture2D GetLutStrip(int size)
	{
		return null;
	}

	[Token(Token = "0x60066A3")]
	[Address(RVA = "0x102D150", Offset = "0x102BF50", Length = "0xFE")]
	internal static bool isValidResources()
	{
		return false;
	}

	[Token(Token = "0x60066A4")]
	[Address(RVA = "0x102D250", Offset = "0x102C050", Length = "0x3BF")]
	internal static void UpdateResources(PostProcessResources resources)
	{
	}

	[Token(Token = "0x60066A5")]
	[Address(RVA = "0x102D610", Offset = "0x102C410", Length = "0x42")]
	public static void SetRenderTargetWithLoadStoreAction(this CommandBuffer cmd, RenderTargetIdentifier rt, RenderBufferLoadAction loadAction, RenderBufferStoreAction storeAction)
	{
	}

	[Token(Token = "0x60066A6")]
	[Address(RVA = "0x102D660", Offset = "0x102C460", Length = "0x58")]
	public static void SetRenderTargetWithLoadStoreAction(this CommandBuffer cmd, RenderTargetIdentifier rt, RenderBufferLoadAction loadAction, RenderBufferStoreAction storeAction, RenderBufferLoadAction depthLoadAction, RenderBufferStoreAction depthStoreAction)
	{
	}

	[Token(Token = "0x60066A7")]
	[Address(RVA = "0x102D6C0", Offset = "0x102C4C0", Length = "0x8C")]
	public static void SetRenderTargetWithLoadStoreAction(this CommandBuffer cmd, RenderTargetIdentifier color, RenderBufferLoadAction colorLoadAction, RenderBufferStoreAction colorStoreAction, RenderTargetIdentifier depth, RenderBufferLoadAction depthLoadAction, RenderBufferStoreAction depthStoreAction)
	{
	}

	[Token(Token = "0x60066A8")]
	[Address(RVA = "0x102D750", Offset = "0x102C550", Length = "0x427")]
	public static void BlitFullscreenTriangle(this CommandBuffer cmd, RenderTargetIdentifier source, RenderTargetIdentifier destination, bool clear = false, Rect? viewport = null, bool preserveDepth = false)
	{
	}

	[Token(Token = "0x60066A9")]
	[Address(RVA = "0x102DB80", Offset = "0x102C980", Length = "0x414")]
	public static void BlitFullscreenTriangle(this CommandBuffer cmd, RenderTargetIdentifier source, RenderTargetIdentifier destination, PropertySheet propertySheet, int pass, RenderBufferLoadAction loadAction, Rect? viewport = null, bool preserveDepth = false)
	{
	}

	[Token(Token = "0x60066AA")]
	[Address(RVA = "0x102DFA0", Offset = "0x102CDA0", Length = "0x12E")]
	public static void BlitFullscreenTriangle(this CommandBuffer cmd, RenderTargetIdentifier source, RenderTargetIdentifier destination, PropertySheet propertySheet, int pass, bool clear = false, Rect? viewport = null, bool preserveDepth = false)
	{
	}

	[Token(Token = "0x60066AB")]
	[Address(RVA = "0x102E0D0", Offset = "0x102CED0", Length = "0x24E")]
	public static void BlitFullscreenTriangleFromDoubleWide(this CommandBuffer cmd, RenderTargetIdentifier source, RenderTargetIdentifier destination, Material material, int pass, int eye)
	{
	}

	[Token(Token = "0x60066AC")]
	[Address(RVA = "0x102E320", Offset = "0x102D120", Length = "0x2B0")]
	public static void BlitFullscreenTriangleToDoubleWide(this CommandBuffer cmd, RenderTargetIdentifier source, RenderTargetIdentifier destination, PropertySheet propertySheet, int pass, int eye)
	{
	}

	[Token(Token = "0x60066AD")]
	[Address(RVA = "0x102E5E0", Offset = "0x102D3E0", Length = "0x3B2")]
	public static void BlitFullscreenTriangleFromTexArray(this CommandBuffer cmd, RenderTargetIdentifier source, RenderTargetIdentifier destination, PropertySheet propertySheet, int pass, bool clear = false, int depthSlice = -1)
	{
	}

	[Token(Token = "0x60066AE")]
	[Address(RVA = "0x102E9A0", Offset = "0x102D7A0", Length = "0x3A7")]
	public static void BlitFullscreenTriangleToTexArray(this CommandBuffer cmd, RenderTargetIdentifier source, RenderTargetIdentifier destination, PropertySheet propertySheet, int pass, bool clear = false, int depthSlice = -1)
	{
	}

	[Token(Token = "0x60066AF")]
	[Address(RVA = "0x102ED50", Offset = "0x102DB50", Length = "0x477")]
	public static void BlitFullscreenTriangle(this CommandBuffer cmd, RenderTargetIdentifier source, RenderTargetIdentifier destination, RenderTargetIdentifier depth, PropertySheet propertySheet, int pass, bool clear = false, Rect? viewport = null)
	{
	}

	[Token(Token = "0x60066B0")]
	[Address(RVA = "0x102F1D0", Offset = "0x102DFD0", Length = "0x3B9")]
	public static void BlitFullscreenTriangle(this CommandBuffer cmd, RenderTargetIdentifier source, RenderTargetIdentifier[] destinations, RenderTargetIdentifier depth, PropertySheet propertySheet, int pass, bool clear = false, Rect? viewport = null)
	{
	}

	[Token(Token = "0x60066B1")]
	[Address(RVA = "0x102F590", Offset = "0x102E390", Length = "0xE8")]
	public static void BuiltinBlit(this CommandBuffer cmd, RenderTargetIdentifier source, RenderTargetIdentifier destination)
	{
	}

	[Token(Token = "0x60066B2")]
	[Address(RVA = "0x102F680", Offset = "0x102E480", Length = "0x101")]
	public static void BuiltinBlit(this CommandBuffer cmd, RenderTargetIdentifier source, RenderTargetIdentifier destination, Material mat, int pass = 0)
	{
	}

	[Token(Token = "0x60066B3")]
	[Address(RVA = "0x102F790", Offset = "0x102E590", Length = "0x323")]
	public static void BlitFullscreenTriangle(this CommandBuffer cmd, RenderTargetIdentifier source, RenderTargetIdentifier destination, PropertySheet propertySheet, MaterialPropertyBlock properties, int pass, bool clear = false)
	{
	}

	[Token(Token = "0x60066B4")]
	[Address(RVA = "0x102FAC0", Offset = "0x102E8C0", Length = "0x26A")]
	public static void CopyTexture(CommandBuffer cmd, RenderTargetIdentifier source, RenderTargetIdentifier destination)
	{
	}

	[Token(Token = "0x60066BD")]
	[Address(RVA = "0x1030150", Offset = "0x102EF50", Length = "0x19")]
	public static bool isFloatingPointFormat(RenderTextureFormat format)
	{
		return false;
	}

	[Token(Token = "0x60066BE")]
	[Address(RVA = "0x1030170", Offset = "0x102EF70", Length = "0x90")]
	internal static bool hasAlpha(RenderTextureFormat format)
	{
		return false;
	}

	[Token(Token = "0x60066BF")]
	[Address(RVA = "0x1030210", Offset = "0x102F010", Length = "0x11B")]
	public static void Destroy(Object obj)
	{
	}

	[Token(Token = "0x60066C1")]
	[Address(RVA = "0x1030380", Offset = "0x102F180", Length = "0x12B")]
	public static bool IsResolvedDepthAvailable(Camera camera)
	{
		return false;
	}

	[Token(Token = "0x60066C2")]
	[Address(RVA = "0x10304B0", Offset = "0x102F2B0", Length = "0x1C7")]
	public static void DestroyProfile(PostProcessProfile profile, bool destroyEffects)
	{
	}

	[Token(Token = "0x60066C3")]
	[Address(RVA = "0x1030680", Offset = "0x102F480", Length = "0xDC")]
	public static void DestroyVolume(PostProcessVolume volume, bool destroyProfile, bool destroyGameObject = false)
	{
	}

	[Token(Token = "0x60066C4")]
	[Address(RVA = "0x1030760", Offset = "0x102F560", Length = "0xCE")]
	public static bool IsPostProcessingActive(PostProcessLayer layer)
	{
		return false;
	}

	[Token(Token = "0x60066C5")]
	[Address(RVA = "0x1030830", Offset = "0x102F630", Length = "0x123")]
	public static bool IsTemporalAntialiasingActive(PostProcessLayer layer)
	{
		return false;
	}

	[Token(Token = "0x60066C6")]
	[Address(RVA = "0x1030960", Offset = "0x102F760", Length = "0x195")]
	public static bool IsDynamicResolutionEnabled(Camera camera)
	{
		return false;
	}

	[IteratorStateMachine(typeof(_003CGetAllSceneObjects_003Ed__87<>))]
	[Token(Token = "0x60066C7")]
	[Address(RVA = "0x19E8560", Offset = "0x19E7360", Length = "0x52")]
	public static IEnumerable<T> GetAllSceneObjects<T>() where T : Component
	{
		return null;
	}

	[Token(Token = "0x60066C8")]
	[Address(RVA = "0x19E84E0", Offset = "0x19E72E0", Length = "0x7C")]
	public static void CreateIfNull<T>(ref T obj) where T : class, new()
	{
	}

	[Token(Token = "0x60066C9")]
	[Address(RVA = "0x1030B00", Offset = "0x102F900", Length = "0xD")]
	public static float Exp2(float x)
	{
		return 0f;
	}

	[Token(Token = "0x60066CA")]
	[Address(RVA = "0x1030B10", Offset = "0x102F910", Length = "0x487")]
	public static Matrix4x4 GetJitteredPerspectiveProjectionMatrix(Camera camera, Vector2 offset)
	{
		return default(Matrix4x4);
	}

	[Token(Token = "0x60066CB")]
	[Address(RVA = "0x1030FA0", Offset = "0x102FDA0", Length = "0x476")]
	public static Matrix4x4 GetJitteredOrthographicProjectionMatrix(Camera camera, Vector2 offset)
	{
		return default(Matrix4x4);
	}

	[Token(Token = "0x60066CC")]
	[Address(RVA = "0x1031420", Offset = "0x1030220", Length = "0x1D1")]
	public static Matrix4x4 GenerateJitteredProjectionMatrixFromOriginal(PostProcessRenderContext context, Matrix4x4 origProj, Vector2 jitter)
	{
		return default(Matrix4x4);
	}

	[Token(Token = "0x60066CD")]
	[Address(RVA = "0x1031600", Offset = "0x1030400", Length = "0x2B6")]
	public static IEnumerable<Type> GetAllAssemblyTypes()
	{
		return null;
	}

	[Token(Token = "0x60066CE")]
	[Address(RVA = "0x19E85C0", Offset = "0x19E73C0", Length = "0x202")]
	public static IEnumerable<Type> GetAllTypesDerivedFrom<T>()
	{
		return null;
	}

	[Token(Token = "0x60066CF")]
	[Address(RVA = "0x19E87D0", Offset = "0x19E75D0", Length = "0x116")]
	public static T GetAttribute<T>(this Type type) where T : Attribute
	{
		return null;
	}

	[Token(Token = "0x60066D0")]
	[Address(RVA = "0x19E8C20", Offset = "0x19E7A20", Length = "0x290")]
	public static Attribute[] GetMemberAttributes<TType, TValue>(Expression<Func<TType, TValue>> expr)
	{
		return null;
	}

	[Token(Token = "0x60066D1")]
	[Address(RVA = "0x19E88F0", Offset = "0x19E76F0", Length = "0x32C")]
	public static string GetFieldPath<TType, TValue>(Expression<Func<TType, TValue>> expr)
	{
		return null;
	}
}
