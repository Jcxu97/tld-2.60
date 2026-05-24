using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2ILInjected;
using SuperSplines;
using TLD.Gear;
using TLD.Logging;
using TLD.SaveState;
using Unity.Collections;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.Networking;
using UnityEngine.Playables;
using UnityEngine.Rendering;
using UnityEngine.SceneManagement;

[Token(Token = "0x2000A43")]
public class Utils : MonoBehaviour
{
	[Flags]
	[Token(Token = "0x2000A44")]
	public enum ExecuteCmdOptions
	{
		[Token(Token = "0x40066F7")]
		None = 0,
		[Token(Token = "0x40066F8")]
		ReturnStandardOutput = 1,
		[Token(Token = "0x40066F9")]
		LogErrorOutput = 2
	}

	[Token(Token = "0x2000A45")]
	public delegate void ExecuteCmdCallback(string stdout);

	[Token(Token = "0x2000A46")]
	public enum SystemMetrics
	{
		[Token(Token = "0x40066FB")]
		MouseButtonsSwapped = 23
	}

	[Token(Token = "0x2000A47")]
	public struct Basis
	{
		[Token(Token = "0x40066FC")]
		[Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private Vector3 m_X;

		[Token(Token = "0x40066FD")]
		[Cpp2ILInjected.FieldOffset(Offset = "0xC")]
		private Vector3 m_Y;

		[Token(Token = "0x40066FE")]
		[Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private Vector3 m_Z;

		[Token(Token = "0x170003A1")]
		public Vector3 this[int index]
		{
			[Token(Token = "0x6005A5F")]
			[Address(RVA = "0xF15A80", Offset = "0xF14880", Length = "0xA3")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6005A60")]
			[Address(RVA = "0xF15B30", Offset = "0xF14930", Length = "0x95")]
			set
			{
			}
		}
	}

	[Token(Token = "0x2000A48")]
	public struct OBB
	{
		[Token(Token = "0x40066FF")]
		[Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		public Vector3 c;

		[Token(Token = "0x4006700")]
		[Cpp2ILInjected.FieldOffset(Offset = "0xC")]
		public Basis u;

		[Token(Token = "0x4006701")]
		[Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		public Vector3 e;
	}

	[Token(Token = "0x2000A49")]
	private struct Coords
	{
		[Token(Token = "0x4006702")]
		[Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		public int x;

		[Token(Token = "0x4006703")]
		[Cpp2ILInjected.FieldOffset(Offset = "0x4")]
		public int z;
	}

	[Token(Token = "0x2000A4A")]
	private enum PatchHeightCheckState
	{
		[Token(Token = "0x4006705")]
		NotChecked,
		[Token(Token = "0x4006706")]
		Queued,
		[Token(Token = "0x4006707")]
		Set
	}

	[Token(Token = "0x2000A4B")]
	private struct FastSplineNode
	{
		[Token(Token = "0x4006708")]
		[Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		public Vector3 m_Position;

		[Token(Token = "0x4006709")]
		[Cpp2ILInjected.FieldOffset(Offset = "0xC")]
		public Quaternion m_Rotation;

		[Token(Token = "0x400670A")]
		[Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		public double m_PosInSpline;

		[Token(Token = "0x400670B")]
		[Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		public double m_Length;

		[Token(Token = "0x6005A61")]
		[Address(RVA = "0xF15BD0", Offset = "0xF149D0", Length = "0x21")]
		public FastSplineNode(Vector3 pos, Quaternion rot)
		{
			m_Position = default(Vector3);
			m_Rotation = default(Quaternion);
			m_PosInSpline = 0.0;
			m_Length = 0.0;
		}

		[Token(Token = "0x6005A62")]
		[Address(RVA = "0xF15C00", Offset = "0xF14A00", Length = "0xB")]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x2000A4C")]
	public struct FastSpline
	{
		[Token(Token = "0x2000A4D")]
		public struct LengthData
		{
			[Token(Token = "0x4006718")]
			[Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			public NativeArray<double> m_SubSegmentLength;

			[Token(Token = "0x4006719")]
			[Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			public NativeArray<double> m_SubSegmentPosition;

			[Token(Token = "0x400671A")]
			[Cpp2ILInjected.FieldOffset(Offset = "0x20")]
			public double m_Length;

			[Token(Token = "0x6005A74")]
			[Address(RVA = "0xF17380", Offset = "0xF16180", Length = "0x72")]
			public void Dispose()
			{
			}

			[Token(Token = "0x6005A75")]
			[Address(RVA = "0xF17400", Offset = "0xF16200", Length = "0x340")]
			public void Calculate(ref FastSpline spline)
			{
			}

			[Token(Token = "0x6005A76")]
			[Address(RVA = "0xF17740", Offset = "0xF16540", Length = "0x592")]
			private void SetupSplinePositions(ref FastSpline spline)
			{
			}
		}

		[Token(Token = "0x2000A4E")]
		public enum TangentMode
		{
			[Token(Token = "0x400671C")]
			UseNormalizedTangents,
			[Token(Token = "0x400671D")]
			UseTangents,
			[Token(Token = "0x400671E")]
			UseNodeForwardVector
		}

		[Token(Token = "0x2000A4F")]
		public enum InterpolationMode
		{
			[Token(Token = "0x4006720")]
			Hermite,
			[Token(Token = "0x4006721")]
			Bezier,
			[Token(Token = "0x4006722")]
			BSpline,
			[Token(Token = "0x4006723")]
			Linear
		}

		[Token(Token = "0x400670C")]
		public static readonly double[] HermiteMatrix;

		[Token(Token = "0x400670D")]
		public static readonly double[] BezierMatrix;

		[Token(Token = "0x400670E")]
		public static readonly double[] BSplineMatrix;

		[Token(Token = "0x400670F")]
		public static readonly double[] LinearMatrix;

		[Token(Token = "0x4006710")]
		[Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		public InterpolationMode m_InterpolationMode;

		[Token(Token = "0x4006711")]
		[Cpp2ILInjected.FieldOffset(Offset = "0x4")]
		public TangentMode m_TangentMode;

		[Token(Token = "0x4006712")]
		[Cpp2ILInjected.FieldOffset(Offset = "0x8")]
		public float m_Tension;

		[Token(Token = "0x4006713")]
		[Cpp2ILInjected.FieldOffset(Offset = "0xC")]
		public bool m_AutoClose;

		[Token(Token = "0x4006714")]
		[Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		public int m_InterpolationAccuracy;

		[Token(Token = "0x4006715")]
		[Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private NativeArray<FastSplineNode> m_SplineNodesInternal;

		[Token(Token = "0x4006716")]
		[Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private NativeArray<double> m_SplineMatrix;

		[Token(Token = "0x4006717")]
		[Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		public LengthData m_LengthData;

		[Token(Token = "0x170003A2")]
		public bool AutoClose
		{
			[Token(Token = "0x6005A63")]
			[Address(RVA = "0xF15C10", Offset = "0xF14A10", Length = "0x59")]
			get
			{
				return false;
			}
		}

		[Token(Token = "0x170003A3")]
		public int Step
		{
			[Token(Token = "0x6005A64")]
			[Address(RVA = "0xF15C70", Offset = "0xF14A70", Length = "0x54")]
			get
			{
				return 0;
			}
		}

		[Token(Token = "0x170003A4")]
		public int ControlNodeCount
		{
			[Token(Token = "0x6005A65")]
			[Address(RVA = "0xF15CD0", Offset = "0xF14AD0", Length = "0x94")]
			get
			{
				return 0;
			}
		}

		[Token(Token = "0x170003A5")]
		public double InvertedAccuracy
		{
			[Token(Token = "0x6005A66")]
			[Address(RVA = "0xF15D70", Offset = "0xF14B70", Length = "0x16")]
			get
			{
				return 0.0;
			}
		}

		[Token(Token = "0x170003A6")]
		private bool IsBezier
		{
			[Token(Token = "0x6005A67")]
			[Address(RVA = "0xF15D90", Offset = "0xF14B90", Length = "0x7")]
			get
			{
				return false;
			}
		}

		[Token(Token = "0x170003A7")]
		public bool HasNodes
		{
			[Token(Token = "0x6005A68")]
			[Address(RVA = "0xED5560", Offset = "0xED4360", Length = "0x8")]
			get
			{
				return false;
			}
		}

		[Token(Token = "0x170003A8")]
		public int SegmentCount
		{
			[Token(Token = "0x6005A6A")]
			[Address(RVA = "0xF15EA0", Offset = "0xF14CA0", Length = "0xA5")]
			get
			{
				return 0;
			}
		}

		[Token(Token = "0x6005A69")]
		[Address(RVA = "0xF15DA0", Offset = "0xF14BA0", Length = "0xFE")]
		private FastSplineNode GetNode(int idxNode, int idxOffset)
		{
			return default(FastSplineNode);
		}

		[Token(Token = "0x6005A6B")]
		[Address(RVA = "0xF15F50", Offset = "0xF14D50", Length = "0xA4")]
		public int MaxNodeIndex()
		{
			return 0;
		}

		[Token(Token = "0x6005A6C")]
		[Address(RVA = "0xF16000", Offset = "0xF14E00", Length = "0x276")]
		private double GetSegmentLengthInternal(int idxFirstPoint, double startValue, double endValue, double step)
		{
			return 0.0;
		}

		[Token(Token = "0x6005A6D")]
		[Address(RVA = "0xF16280", Offset = "0xF15080", Length = "0x68")]
		public void Dispose()
		{
		}

		[Token(Token = "0x6005A6E")]
		[Address(RVA = "0xF162F0", Offset = "0xF150F0", Length = "0x347")]
		public Vector3 GetPositionInternal(SegmentParameter sParam)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6005A6F")]
		[Address(RVA = "0xF16640", Offset = "0xF15440", Length = "0x19C")]
		private Vector3 InterpolatePosition(double t, Vector3 v0, Vector3 v1, Vector3 v2, Vector3 v3)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6005A70")]
		[Address(RVA = "0xF167E0", Offset = "0xF155E0", Length = "0x29F")]
		private void GetAdjacentNodes(SegmentParameter sParam, out FastSplineNode node0, out FastSplineNode node1, out FastSplineNode node2, out FastSplineNode node3)
		{
			node0 = default(FastSplineNode);
			node1 = default(FastSplineNode);
			node2 = default(FastSplineNode);
			node3 = default(FastSplineNode);
		}

		[Token(Token = "0x6005A71")]
		[Address(RVA = "0xF16A80", Offset = "0xF15880", Length = "0x2F7")]
		private void RecalcVectors(FastSplineNode node0, FastSplineNode node1, ref Vector3 P2, ref Vector3 P3)
		{
		}

		[Token(Token = "0x6005A72")]
		[Address(RVA = "0xF16D80", Offset = "0xF15B80", Length = "0x312")]
		public void Allocate(Spline spline, NativeArray<double> matrix)
		{
		}
	}

	[Token(Token = "0x2000A50")]
	public struct SegmentParameter
	{
		[Token(Token = "0x4006724")]
		[Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		public double m_NormalizedParam;

		[Token(Token = "0x4006725")]
		[Cpp2ILInjected.FieldOffset(Offset = "0x8")]
		public int m_NormalizedIndex;

		[Token(Token = "0x6005A77")]
		[Address(RVA = "0xF17CE0", Offset = "0xF16AE0", Length = "0x8")]
		public SegmentParameter(int index, double param)
		{
			m_NormalizedParam = 0.0;
			m_NormalizedIndex = 0;
		}
	}

	[Token(Token = "0x2000A51")]
	public struct Subtitle
	{
		[Token(Token = "0x4006726")]
		[Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		public string m_LocId;

		[Token(Token = "0x4006727")]
		[Cpp2ILInjected.FieldOffset(Offset = "0x8")]
		public bool m_IsUnkownSpeaker;

		[Token(Token = "0x4006728")]
		[Cpp2ILInjected.FieldOffset(Offset = "0xC")]
		public uint m_StartFrame;

		[Token(Token = "0x4006729")]
		[Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		public uint m_EndFrame;

		[Token(Token = "0x400672A")]
		[Cpp2ILInjected.FieldOffset(Offset = "0x14")]
		public uint m_Framerate;
	}

	[CompilerGenerated]
	[Token(Token = "0x2000A52")]
	private sealed class _003CWebRequest_003Ed__340 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400672B")]
		[Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400672C")]
		[Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400672D")]
		[Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		public string url;

		[Token(Token = "0x400672E")]
		[Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		public Action<UnityWebRequest> onFailure;

		[Token(Token = "0x400672F")]
		[Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		public Action<UnityWebRequest> onSuccess;

		[Token(Token = "0x4006730")]
		[Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		private UnityWebRequest _003Cresponse_003E5__2;

		[Token(Token = "0x4006731")]
		[Cpp2ILInjected.FieldOffset(Offset = "0x40")]
		private float _003CtimeoutTime_003E5__3;

		[Token(Token = "0x170003A9")]
		object IEnumerator<object>.Current
		{
			[DebuggerHidden]
			[Token(Token = "0x6005A7C")]
			[Address(RVA = "0x4571D0", Offset = "0x455FD0", Length = "0x5")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170003AA")]
		object IEnumerator.Current
		{
			[DebuggerHidden]
			[Token(Token = "0x6005A7E")]
			[Address(RVA = "0x4571D0", Offset = "0x455FD0", Length = "0x5")]
			get
			{
				return null;
			}
		}

		[DebuggerHidden]
		[Token(Token = "0x6005A78")]
		[Address(RVA = "0x4096E0", Offset = "0x4084E0", Length = "0x4")]
		public _003CWebRequest_003Ed__340(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		[Token(Token = "0x6005A79")]
		[Address(RVA = "0xF17CF0", Offset = "0xF16AF0", Length = "0xC6")]
		void IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6005A7A")]
		[Address(RVA = "0xF17DC0", Offset = "0xF16BC0", Length = "0x51F")]
		private bool MoveNext()
		{
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		[Token(Token = "0x6005A7B")]
		[Address(RVA = "0xF182E0", Offset = "0xF170E0", Length = "0x53")]
		private void _003C_003Em__Finally1()
		{
		}

		[DebuggerHidden]
		[Token(Token = "0x6005A7D")]
		[Address(RVA = "0xF18340", Offset = "0xF17140", Length = "0x3E")]
		void IEnumerator.Reset()
		{
		}
	}

	[CompilerGenerated]
	[Token(Token = "0x2000A53")]
	private sealed class _003CWebRequest_003Ed__341 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4006732")]
		[Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4006733")]
		[Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4006734")]
		[Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		public string url;

		[Token(Token = "0x4006735")]
		[Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		public Action<UnityWebRequest> onFailure;

		[Token(Token = "0x4006736")]
		[Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		public WWWForm form;

		[Token(Token = "0x4006737")]
		[Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		public Action<UnityWebRequest> onSuccess;

		[Token(Token = "0x4006738")]
		[Cpp2ILInjected.FieldOffset(Offset = "0x40")]
		private UnityWebRequest _003Cresponse_003E5__2;

		[Token(Token = "0x4006739")]
		[Cpp2ILInjected.FieldOffset(Offset = "0x48")]
		private float _003CtimeoutTime_003E5__3;

		[Token(Token = "0x170003AB")]
		object IEnumerator<object>.Current
		{
			[DebuggerHidden]
			[Token(Token = "0x6005A83")]
			[Address(RVA = "0x4571D0", Offset = "0x455FD0", Length = "0x5")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170003AC")]
		object IEnumerator.Current
		{
			[DebuggerHidden]
			[Token(Token = "0x6005A85")]
			[Address(RVA = "0x4571D0", Offset = "0x455FD0", Length = "0x5")]
			get
			{
				return null;
			}
		}

		[DebuggerHidden]
		[Token(Token = "0x6005A7F")]
		[Address(RVA = "0x4096E0", Offset = "0x4084E0", Length = "0x4")]
		public _003CWebRequest_003Ed__341(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		[Token(Token = "0x6005A80")]
		[Address(RVA = "0xF18380", Offset = "0xF17180", Length = "0xC6")]
		void IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6005A81")]
		[Address(RVA = "0xF18450", Offset = "0xF17250", Length = "0x56F")]
		private bool MoveNext()
		{
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		[Token(Token = "0x6005A82")]
		[Address(RVA = "0xF189C0", Offset = "0xF177C0", Length = "0x53")]
		private void _003C_003Em__Finally1()
		{
		}

		[DebuggerHidden]
		[Token(Token = "0x6005A84")]
		[Address(RVA = "0xF18A20", Offset = "0xF17820", Length = "0x3E")]
		void IEnumerator.Reset()
		{
		}
	}

	[CompilerGenerated]
	[Token(Token = "0x2000A54")]
	private sealed class _003CWebRequestPut_003Ed__342 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400673A")]
		[Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400673B")]
		[Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400673C")]
		[Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		public string url;

		[Token(Token = "0x400673D")]
		[Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		public Action<UnityWebRequest> onFailure;

		[Token(Token = "0x400673E")]
		[Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		public byte[] data;

		[Token(Token = "0x400673F")]
		[Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		public Dictionary<string, string> httpHeaders;

		[Token(Token = "0x4006740")]
		[Cpp2ILInjected.FieldOffset(Offset = "0x40")]
		public Action<UnityWebRequest> onSuccess;

		[Token(Token = "0x4006741")]
		[Cpp2ILInjected.FieldOffset(Offset = "0x48")]
		private UnityWebRequest _003Cresponse_003E5__2;

		[Token(Token = "0x4006742")]
		[Cpp2ILInjected.FieldOffset(Offset = "0x50")]
		private float _003CtimeoutTime_003E5__3;

		[Token(Token = "0x170003AD")]
		object IEnumerator<object>.Current
		{
			[DebuggerHidden]
			[Token(Token = "0x6005A8A")]
			[Address(RVA = "0x4571D0", Offset = "0x455FD0", Length = "0x5")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170003AE")]
		object IEnumerator.Current
		{
			[DebuggerHidden]
			[Token(Token = "0x6005A8C")]
			[Address(RVA = "0x4571D0", Offset = "0x455FD0", Length = "0x5")]
			get
			{
				return null;
			}
		}

		[DebuggerHidden]
		[Token(Token = "0x6005A86")]
		[Address(RVA = "0x4096E0", Offset = "0x4084E0", Length = "0x4")]
		public _003CWebRequestPut_003Ed__342(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		[Token(Token = "0x6005A87")]
		[Address(RVA = "0xF18A60", Offset = "0xF17860", Length = "0xC6")]
		void IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6005A88")]
		[Address(RVA = "0xF18B30", Offset = "0xF17930", Length = "0x70F")]
		private bool MoveNext()
		{
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		[Token(Token = "0x6005A89")]
		[Address(RVA = "0xF19240", Offset = "0xF18040", Length = "0x53")]
		private void _003C_003Em__Finally1()
		{
		}

		[DebuggerHidden]
		[Token(Token = "0x6005A8B")]
		[Address(RVA = "0xF192A0", Offset = "0xF180A0", Length = "0x3E")]
		void IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x40066B8")]
	private static readonly LogFilter s_LoadingFilter;

	[Token(Token = "0x40066B9")]
	public static bool s_UseAudioStaticCheck;

	[Token(Token = "0x40066BA")]
	private const string ENCODED_SPACE_CHARACTER = "%20";

	[Token(Token = "0x40066BB")]
	private static readonly string[] s_WhitelistedSharedArguments;

	[Token(Token = "0x40066BC")]
	private static Dictionary<string, string> s_CommandLineArgs;

	[Token(Token = "0x40066BD")]
	public const float MENU_MOVEMENT_AFTER_FIFTEEN = 0.02f;

	[Token(Token = "0x40066BE")]
	public const float MENU_MOVEMENT_AFTER_FIVE = 0.1f;

	[Token(Token = "0x40066BF")]
	public const float MENU_MOVEMENT_DELAY = 0.2f;

	[Token(Token = "0x40066C0")]
	public const float MENU_MOVEMENT_FIRSTDELAY = 0.5f;

	[Token(Token = "0x40066C1")]
	public const float DOUBLECLICK_MaxTime = 0.5f;

	[Token(Token = "0x40066C2")]
	public const int m_PhysicalCollisionLayerMask = 269228865;

	[Token(Token = "0x40066C3")]
	public const int m_WeaponProjectileCollisionLayerMask = 269359937;

	[Token(Token = "0x40066C4")]
	public static bool m_InspectModeActive;

	[Token(Token = "0x40066C5")]
	public static Vector3[] EMPTY_VECTOR3_ARRAY;

	[Token(Token = "0x40066C6")]
	private static Vector3 m_InspectRestorePos;

	[Token(Token = "0x40066C7")]
	private static Quaternion m_InspectRestoreRot;

	[Token(Token = "0x40066C8")]
	private static Vector3 m_InspectOriginalLocalScale;

	[Token(Token = "0x40066C9")]
	private static Transform m_InspectCachedParent;

	[Token(Token = "0x40066CA")]
	private static ShadowCastingMode m_InspectRestoreCastsShadows;

	[Token(Token = "0x40066CB")]
	private static int m_MenuMoveHorizontalRepeatCount;

	[Token(Token = "0x40066CC")]
	private static int m_MenuMoveVerticalRepeatCount;

	[Token(Token = "0x40066CD")]
	private static int m_MenuMoveVerticalRightStickRepeatCount;

	[Token(Token = "0x40066CE")]
	private static int m_MenuMoveHorizontalRightStickRepeatCount;

	[Token(Token = "0x40066CF")]
	private static float m_MenuMoveHorizontalTimeAllowed;

	[Token(Token = "0x40066D0")]
	private static float m_MenuMoveVerticalTimeAllowed;

	[Token(Token = "0x40066D1")]
	private static float m_MenuMoveVerticalRightStickTimeAllowed;

	[Token(Token = "0x40066D2")]
	private static float m_MenuMoveHorizontalRightStickTimeAllowed;

	[Token(Token = "0x40066D3")]
	private static float m_MenuAxisDeadzone;

	[Token(Token = "0x40066D4")]
	private const float HIGHER_PRECISION_FIXED_PHYS_TIMESTEP = 0.03f;

	[Token(Token = "0x40066D5")]
	private const float NORNAL_PRECISION_FIXED_PHYS_TIMESTEP = 0.04f;

	[Token(Token = "0x40066D6")]
	private static float m_MenuMoveHorizontalRightStickAccumulated;

	[Token(Token = "0x40066D7")]
	private static float m_MenuMoveHorizontalRightStickThreshold;

	[Token(Token = "0x40066D8")]
	public static float m_SteamControllerMenuScrollSensitivity;

	[Token(Token = "0x40066D9")]
	public static bool s_DebugVerbose;

	[Token(Token = "0x40066DA")]
	private static string[] s_ByteFormatSuffixes;

	[Token(Token = "0x40066DB")]
	private static int[] s_SHAIds;

	[Token(Token = "0x40066DC")]
	private static int[] s_SHBIds;

	[Token(Token = "0x40066DD")]
	private static int s_SHCId;

	[Token(Token = "0x40066DE")]
	public const float PI2 = (float)Math.PI * 2f;

	[Token(Token = "0x40066DF")]
	public const float HALFPI = (float)Math.PI / 2f;

	[Token(Token = "0x40066E0")]
	public const string s_MissionMapMarkerLabel = "MissionMapMarker";

	[Token(Token = "0x40066E1")]
	private static HashSet<string> s_MissionMapMarkerIDs;

	[Token(Token = "0x40066E2")]
	private static HashSet<string> s_MissionIds;

	[Token(Token = "0x40066E3")]
	private static HashSet<string> s_MissionObjectiveIds;

	[Token(Token = "0x40066E4")]
	private const int MAX_RAYCAST_HITS = 32;

	[Token(Token = "0x40066E5")]
	private static RaycastHit[] s_RaycastHits;

	[Token(Token = "0x40066E6")]
	public static bool s_ShadowsEnabled;

	[Token(Token = "0x40066E7")]
	public static bool s_SpecularEnabled;

	[Token(Token = "0x40066E8")]
	private static ShadowQuality s_ShadowMode;

	[Token(Token = "0x40066E9")]
	private static bool s_ForceFlatLighting;

	[Token(Token = "0x40066EA")]
	private static RaycastHit[] m_PatchCoefficientRaycastResults;

	[Token(Token = "0x40066EB")]
	private static readonly int TINT_COLOR_ID;

	[Token(Token = "0x40066EC")]
	private static readonly int TINT_COLOR_GLOW_ID;

	[Token(Token = "0x40066ED")]
	private static readonly int OUTLINE_ENABLED_ID;

	[Token(Token = "0x40066EE")]
	private const int NUM_PATCH_HEIGHT_X_COORDS = 5;

	[Token(Token = "0x40066EF")]
	private const int NUM_PATCH_HEIGHT_Z_COORDS = 5;

	[Token(Token = "0x40066F0")]
	private static float[,] s_PatchHeights;

	[Token(Token = "0x40066F1")]
	private static PatchHeightCheckState[,] s_PatchHeightCheckStates;

	[Token(Token = "0x40066F2")]
	private static Queue<Coords> s_CoordsQueue;

	[Token(Token = "0x40066F3")]
	private static Material s_ClearBlitMaterial;

	[Token(Token = "0x40066F4")]
	public const int SUBTITLE_FRAMESPERSECOND = 24;

	[Token(Token = "0x40066F5")]
	public const int WEB_REQUEST_TIMEOUT = 30;

	[Token(Token = "0x600594A")]
	[Address(RVA = "0xEF52E0", Offset = "0xEF40E0", Length = "0x15C")]
	public static bool IsAnimationStatePlaying(Animator animator, AnimationStateRef animStateRef, int layerIndex = 0)
	{
		return false;
	}

	[Token(Token = "0x600594B")]
	[Address(RVA = "0xEF5440", Offset = "0xEF4240", Length = "0x119")]
	public static bool IsAnimationStatePlaying(Animator animator, string stateName, int layerIndex = 0)
	{
		return false;
	}

	[Token(Token = "0x600594C")]
	[Address(RVA = "0xEF5560", Offset = "0xEF4360", Length = "0x84")]
	public static Texture2D GetInventoryGridIconTexture(string name)
	{
		return null;
	}

	[Token(Token = "0x600594D")]
	[Address(RVA = "0xEF55F0", Offset = "0xEF43F0", Length = "0x12D")]
	public static Texture2D GetInventoryGridIconTextureNonNull(string name)
	{
		return null;
	}

	[Token(Token = "0x600594E")]
	[Address(RVA = "0xEF5720", Offset = "0xEF4520", Length = "0x84")]
	public static Texture2D GetLargeTexture(string name)
	{
		return null;
	}

	[Token(Token = "0x600594F")]
	[Address(RVA = "0xEF57B0", Offset = "0xEF45B0", Length = "0x84")]
	public static Texture2D GetLargeTexture(AssetReferenceTexture2D assetReference)
	{
		return null;
	}

	[Token(Token = "0x6005950")]
	[Address(RVA = "0xEF5840", Offset = "0xEF4640", Length = "0x84")]
	public static Texture2D GetLoadingBackgroundTexture(string name)
	{
		return null;
	}

	[Token(Token = "0x6005951")]
	[Address(RVA = "0xEF58D0", Offset = "0xEF46D0", Length = "0x4E")]
	private static Texture2D GetAddressableTexture(AssetReferenceTexture2D assetReference)
	{
		return null;
	}

	[Token(Token = "0x6005952")]
	[Address(RVA = "0xEF5920", Offset = "0xEF4720", Length = "0x4E")]
	private static Texture2D GetAddressableTexture(string name)
	{
		return null;
	}

	[Token(Token = "0x6005953")]
	[Address(RVA = "0xEF5970", Offset = "0xEF4770", Length = "0x207")]
	public static bool CheckIfAkGameObjIsStatic(AkGameObj akGameObj)
	{
		return false;
	}

	[Token(Token = "0x6005954")]
	[Address(RVA = "0xEF5B80", Offset = "0xEF4980", Length = "0x2C5")]
	private static bool IsDynamicObj(GameObject obj)
	{
		return false;
	}

	[Token(Token = "0x6005955")]
	[Address(RVA = "0xEF5E50", Offset = "0xEF4C50", Length = "0x160")]
	private static bool IsChildOfDynamicObj(AkGameObj obj)
	{
		return false;
	}

	[Token(Token = "0x6005956")]
	[Address(RVA = "0xEF5FC0", Offset = "0xEF4DC0", Length = "0x41")]
	public static string ExecuteCmd(string commandArguments, bool returnOutput)
	{
		return null;
	}

	[Token(Token = "0x6005957")]
	[Address(RVA = "0x4582A0", Offset = "0x4570A0", Length = "0x3")]
	public static string ExecuteCmdFromDir(string commandArguments, ExecuteCmdOptions options, string workingDirectory)
	{
		return null;
	}

	[Token(Token = "0x6005958")]
	[Address(RVA = "0x4582A0", Offset = "0x4570A0", Length = "0x3")]
	public static IEnumerator ExecuteCmd(string commandArguments, ExecuteCmdOptions options, ExecuteCmdCallback callback)
	{
		return null;
	}

	[Token(Token = "0x6005959")]
	[Address(RVA = "0xEF6010", Offset = "0xEF4E10", Length = "0xA9")]
	public static bool IsCommandLineArgumentPresent(string arg)
	{
		return false;
	}

	[Token(Token = "0x600595A")]
	[Address(RVA = "0xEF60C0", Offset = "0xEF4EC0", Length = "0x103")]
	public static bool GetCommandLineValue(string arg, out string value)
	{
		value = null;
		return false;
	}

	[Token(Token = "0x600595B")]
	[Address(RVA = "0xEF61D0", Offset = "0xEF4FD0", Length = "0x138")]
	public static bool GetCommandLineValue(string arg, out int value)
	{
		value = default(int);
		return false;
	}

	[Token(Token = "0x600595C")]
	[Address(RVA = "0x1A4B420", Offset = "0x1A4A220", Length = "0xDD")]
	public static bool GetCommandLineValue<TEnum>(string arg, out TEnum value) where TEnum : struct
	{
		value = default(TEnum);
		return false;
	}

	[Token(Token = "0x600595D")]
	[Address(RVA = "0xEF6310", Offset = "0xEF5110", Length = "0x15C")]
	public static void GetSharedArguments(List<string> arguments)
	{
	}

	[Token(Token = "0x600595E")]
	[Address(RVA = "0xEF6470", Offset = "0xEF5270", Length = "0x42C")]
	public static void QuitAndRunApplication(string applicationPath, List<string> commandArguments)
	{
	}

	[Token(Token = "0x600595F")]
	[Address(RVA = "0xEF68A0", Offset = "0xEF56A0", Length = "0x45")]
	private static void QuitOrStopPlayMode()
	{
	}

	[Token(Token = "0x6005960")]
	[Address(RVA = "0xEF68F0", Offset = "0xEF56F0", Length = "0x27D")]
	private static Process GetProcessForExecuteCmd(string commandArguments, string workingPath, ExecuteCmdOptions options)
	{
		return null;
	}

	[Token(Token = "0x6005961")]
	[Address(RVA = "0xEF6B70", Offset = "0xEF5970", Length = "0x12C")]
	public static void OverrideCommandLineWithTestArgs(string testCommandLine)
	{
	}

	[Token(Token = "0x6005962")]
	[Address(RVA = "0xEF6CA0", Offset = "0xEF5AA0", Length = "0xF6")]
	private static void EnsureCommandLineArgsAreLoaded()
	{
	}

	[Token(Token = "0x6005963")]
	[Address(RVA = "0xEF6DA0", Offset = "0xEF5BA0", Length = "0xDA")]
	private static string SanitizeCommandLineArgName(string keyName)
	{
		return null;
	}

	[Token(Token = "0x6005964")]
	[Address(RVA = "0xEF6E80", Offset = "0xEF5C80", Length = "0x297")]
	private static Dictionary<string, string> ParseCommandLineArgs(string[] args)
	{
		return null;
	}

	[Token(Token = "0x6005965")]
	[Address(RVA = "0xEF7120", Offset = "0xEF5F20", Length = "0x2B0")]
	public static string GenerateCommandLineArgs(Dictionary<string, string> args)
	{
		return null;
	}

	[Token(Token = "0x6005966")]
	[Address(RVA = "0xEF73E0", Offset = "0xEF61E0", Length = "0x21F")]
	public static void GenerateCommandLineArgs(Dictionary<string, string> args, List<string> arguments)
	{
	}

	[Token(Token = "0x6005967")]
	[Address(RVA = "0xEF7600", Offset = "0xEF6400", Length = "0x101")]
	public static void EncodeSpaceCharactersInArguments(List<string> args)
	{
	}

	[Token(Token = "0x6005968")]
	[Address(RVA = "0xEF7710", Offset = "0xEF6510", Length = "0x63")]
	public static string EncodeSpaceCharactersInArgument(string argument)
	{
		return null;
	}

	[Token(Token = "0x6005969")]
	[Address(RVA = "0xEF7780", Offset = "0xEF6580", Length = "0x63")]
	public static string DecodeSpaceCharactersInArgument(string argument)
	{
		return null;
	}

	[Token(Token = "0x600596A")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public static void Init()
	{
	}

	[Token(Token = "0x600596B")]
	[Address(RVA = "0xEF77F0", Offset = "0xEF65F0", Length = "0x8C")]
	public static string GetGuid()
	{
		return null;
	}

	[Token(Token = "0x600596C")]
	[Address(RVA = "0x1A4BB00", Offset = "0x1A4A900", Length = "0x1BC")]
	public static T GetRandomEnum<T>()
	{
		return default(T);
	}

	[Token(Token = "0x600596D")]
	[Address(RVA = "0xEF7880", Offset = "0xEF6680", Length = "0x19B")]
	public static string GetTimeSurvivedString()
	{
		return null;
	}

	[Token(Token = "0x600596E")]
	[Address(RVA = "0xEF7A20", Offset = "0xEF6820", Length = "0xCB")]
	public static string GetTimeSurvivedString(float time)
	{
		return null;
	}

	[Token(Token = "0x600596F")]
	[Address(RVA = "0xEF7AF0", Offset = "0xEF68F0", Length = "0x36B")]
	public static string GetDurationString(int durationMinutes)
	{
		return null;
	}

	[Token(Token = "0x6005970")]
	[Address(RVA = "0xEF7E60", Offset = "0xEF6C60", Length = "0x42C")]
	public static string GetExpandedDurationString(int durationMinutes)
	{
		return null;
	}

	[Token(Token = "0x6005971")]
	[Address(RVA = "0xEF8290", Offset = "0xEF7090", Length = "0x2B5")]
	public static string GetDurationStringRounded(int durationMinutes)
	{
		return null;
	}

	[Token(Token = "0x6005972")]
	[Address(RVA = "0xEF8550", Offset = "0xEF7350", Length = "0x27C")]
	public static bool TryParseTOD(string todString, out float normalizedTOD)
	{
		normalizedTOD = default(float);
		return false;
	}

	[Token(Token = "0x6005973")]
	[Address(RVA = "0xEF87D0", Offset = "0xEF75D0", Length = "0x4E")]
	public static string GetHardcodedRegionForLocation(string location)
	{
		return null;
	}

	[Token(Token = "0x6005974")]
	[Address(RVA = "0xEF8820", Offset = "0xEF7620", Length = "0x93")]
	public static string GetTitleString(string locID)
	{
		return null;
	}

	[Token(Token = "0x6005975")]
	[Address(RVA = "0xEF88C0", Offset = "0xEF76C0", Length = "0x331")]
	public static string InferOutdoorSceneName(bool considerForceNextSceneLoadTrigger = false)
	{
		return null;
	}

	[Token(Token = "0x6005976")]
	[Address(RVA = "0xEF8C00", Offset = "0xEF7A00", Length = "0x288")]
	public static string GetFullObjectName(GameObject go)
	{
		return null;
	}

	[Token(Token = "0x6005977")]
	[Address(RVA = "0xEF8E90", Offset = "0xEF7C90", Length = "0x1B9")]
	public static GameObject GetChildGameObject(GameObject fromGameObject, string withName, bool includeInactive = false)
	{
		return null;
	}

	[Token(Token = "0x6005978")]
	[Address(RVA = "0xEF9050", Offset = "0xEF7E50", Length = "0x1C9")]
	public static GameObject GetChildGameObjectWithNameContaining(GameObject fromGameObject, string withName, bool includeInactive = false)
	{
		return null;
	}

	[Token(Token = "0x6005979")]
	[Address(RVA = "0xEF9220", Offset = "0xEF8020", Length = "0x189")]
	public static GameObject GetChildGameObjectByTag(GameObject fromGameObject, string tag, bool includeInactive = false)
	{
		return null;
	}

	[Token(Token = "0x600597A")]
	[Address(RVA = "0xEF93B0", Offset = "0xEF81B0", Length = "0x356")]
	public static GameObject GetChildGameObject(GameObject fromGameObject, string withName1, string withName2, bool includeInactive = false)
	{
		return null;
	}

	[Token(Token = "0x600597B")]
	[Address(RVA = "0xEF9710", Offset = "0xEF8510", Length = "0x61")]
	public static GameObject ForceGetChildGameObject(GameObject fromGameObject, string withName)
	{
		return null;
	}

	[Token(Token = "0x600597C")]
	[Address(RVA = "0xEF9780", Offset = "0xEF8580", Length = "0x1DF")]
	public static bool IsChildOfParent(GameObject child, GameObject parent)
	{
		return false;
	}

	[Token(Token = "0x600597D")]
	[Address(RVA = "0xEF9960", Offset = "0xEF8760", Length = "0x464")]
	public static GameObject FindTopParentWithCollider(GameObject child)
	{
		return null;
	}

	[Token(Token = "0x600597E")]
	[Address(RVA = "0xEF9DD0", Offset = "0xEF8BD0", Length = "0x293")]
	public static GameObject GetTopParentWithLayer(GameObject child, int childLayer)
	{
		return null;
	}

	[Token(Token = "0x600597F")]
	[Address(RVA = "0x1A4B740", Offset = "0x1A4A540", Length = "0x3B4")]
	public static T GetComponentOnSelfOrParent<T>(GameObject obj) where T : Component
	{
		return null;
	}

	[Token(Token = "0x6005980")]
	[Address(RVA = "0x1A4B320", Offset = "0x1A4A120", Length = "0xF4")]
	public static List<T> FindObjectsOfTypeInScene<T>(Scene scene, bool includeInactive = false) where T : Component
	{
		return null;
	}

	[Token(Token = "0x6005981")]
	[Address(RVA = "0xEFA070", Offset = "0xEF8E70", Length = "0x203")]
	public static bool AreCollidersActiveAndEnabled(List<Collider> cs)
	{
		return false;
	}

	[Token(Token = "0x6005982")]
	[Address(RVA = "0xEFA280", Offset = "0xEF9080", Length = "0x16F")]
	public static Collider GetColliderUnderPosition(Vector3 pos)
	{
		return null;
	}

	[Token(Token = "0x6005983")]
	[Address(RVA = "0xEFA3F0", Offset = "0xEF91F0", Length = "0x1D3")]
	public static string GetMaterialTagUnderPosition(Vector3 pos)
	{
		return null;
	}

	[Token(Token = "0x6005984")]
	[Address(RVA = "0xEFA5D0", Offset = "0xEF93D0", Length = "0x75E")]
	public static string GetMaterialTagForObjectAtPosition(GameObject obj, Vector3 pos)
	{
		return null;
	}

	[Token(Token = "0x6005985")]
	[Address(RVA = "0xEFAD30", Offset = "0xEF9B30", Length = "0x2A5")]
	public static bool HasAnyActiveInteraction(GameObject go)
	{
		return false;
	}

	[Token(Token = "0x6005986")]
	[Address(RVA = "0xEFAFE0", Offset = "0xEF9DE0", Length = "0x13D")]
	public static void DisableRendering(GameObject go)
	{
	}

	[Token(Token = "0x6005987")]
	[Address(RVA = "0xEFB120", Offset = "0xEF9F20", Length = "0x13D")]
	public static void EnableRendering(GameObject go)
	{
	}

	[Token(Token = "0x6005988")]
	[Address(RVA = "0xEFB260", Offset = "0xEFA060", Length = "0x511")]
	public static void SaveView(string name)
	{
	}

	[Token(Token = "0x6005989")]
	[Address(RVA = "0xEFB780", Offset = "0xEFA580", Length = "0x432")]
	public static void RestoreView(string name)
	{
	}

	[Token(Token = "0x600598A")]
	[Address(RVA = "0xEFBBC0", Offset = "0xEFA9C0", Length = "0x19")]
	public static float CelsiusToFahrenheit(float celsius)
	{
		return 0f;
	}

	[Token(Token = "0x600598B")]
	[Address(RVA = "0xEFBBE0", Offset = "0xEFA9E0", Length = "0x19")]
	public static float FahrenheitToCelsius(float fahrenheit)
	{
		return 0f;
	}

	[Token(Token = "0x600598C")]
	[Address(RVA = "0xEFBC00", Offset = "0xEFAA00", Length = "0x9")]
	public static float KilogramsToPounds(float kg)
	{
		return 0f;
	}

	[Token(Token = "0x600598D")]
	[Address(RVA = "0xEFBC10", Offset = "0xEFAA10", Length = "0x9")]
	public static float LitersToGallons(float liters)
	{
		return 0f;
	}

	[Token(Token = "0x600598E")]
	[Address(RVA = "0xEFBC20", Offset = "0xEFAA20", Length = "0x64")]
	public static int GallonsToOunces(float gallons)
	{
		return 0;
	}

	[Token(Token = "0x600598F")]
	[Address(RVA = "0xEFBC90", Offset = "0xEFAA90", Length = "0x9")]
	public static float KmToMile(float km)
	{
		return 0f;
	}

	[Token(Token = "0x6005990")]
	[Address(RVA = "0xEFBCA0", Offset = "0xEFAAA0", Length = "0x9")]
	public static float MeterToFeet(float meter)
	{
		return 0f;
	}

	[Token(Token = "0x6005991")]
	[Address(RVA = "0xEFBCB0", Offset = "0xEFAAB0", Length = "0x2B1")]
	public static float DistanceToMainCamera(Vector3 pos)
	{
		return 0f;
	}

	[Token(Token = "0x6005992")]
	[Address(RVA = "0xEFBF70", Offset = "0xEFAD70", Length = "0x98")]
	public static string GetLiquidQualityString(LiquidQuality quality)
	{
		return null;
	}

	[Token(Token = "0x6005993")]
	[Address(RVA = "0xEFC010", Offset = "0xEFAE10", Length = "0x1A3")]
	public static string GetFormattedDistance(MeasurementUnits units, float meters)
	{
		return null;
	}

	[Token(Token = "0x6005994")]
	[Address(RVA = "0xEFC1C0", Offset = "0xEFAFC0", Length = "0x37D")]
	public static string GetCompassBearingAndDistance(Vector3 start, Vector3 end, out float angle, out float distance)
	{
		angle = default(float);
		distance = default(float);
		return null;
	}

	[Token(Token = "0x6005995")]
	[Address(RVA = "0xEFC540", Offset = "0xEFB340", Length = "0x317")]
	public static string GetTemperatureString(float temperatureCelsius, bool deltaTemperature, bool roundToNearestDegree, bool showPlusSign)
	{
		return null;
	}

	[Token(Token = "0x6005996")]
	[Address(RVA = "0xEFC860", Offset = "0xEFB660", Length = "0xD5")]
	public static bool RollChance(float percent)
	{
		return false;
	}

	[Token(Token = "0x6005997")]
	[Address(RVA = "0xEFC940", Offset = "0xEFB740", Length = "0x230")]
	public static void SetObjectAndChildrenLayer(GameObject go, int layer, int preserveLayer)
	{
	}

	[Token(Token = "0x6005998")]
	[Address(RVA = "0xEFCB80", Offset = "0xEFB980", Length = "0x1A9")]
	public static bool IsChild(GameObject parent, GameObject child)
	{
		return false;
	}

	[Token(Token = "0x6005999")]
	[Address(RVA = "0xEFCD30", Offset = "0xEFBB30", Length = "0x354")]
	public static void ChangeLayersForGearItem(GameObject gameObject, int newLayer)
	{
	}

	[Token(Token = "0x600599A")]
	[Address(RVA = "0xEFD090", Offset = "0xEFBE90", Length = "0x66")]
	public static bool PositionIsOnscreen(Vector3 pos)
	{
		return false;
	}

	[Token(Token = "0x600599B")]
	[Address(RVA = "0xEFD100", Offset = "0xEFBF00", Length = "0x171")]
	public static bool PositionIsOnscreen(Vector3 pos, float adjustViewport)
	{
		return false;
	}

	[Token(Token = "0x600599C")]
	[Address(RVA = "0xEFD280", Offset = "0xEFC080", Length = "0x9")]
	public static float GetPlayerEyeHeight()
	{
		return 0f;
	}

	[Token(Token = "0x600599D")]
	[Address(RVA = "0xEFD290", Offset = "0xEFC090", Length = "0x15E")]
	public static Vector3 GetPlayerEyePosition()
	{
		return default(Vector3);
	}

	[Token(Token = "0x600599E")]
	[Address(RVA = "0xEFD3F0", Offset = "0xEFC1F0", Length = "0x299")]
	public static bool PositionInFrustumOfPlayer(Vector3 pos)
	{
		return false;
	}

	[Token(Token = "0x600599F")]
	[Address(RVA = "0xEFD690", Offset = "0xEFC490", Length = "0x1B9")]
	public static bool PositionIsInLOSOfPlayer(Vector3 pos)
	{
		return false;
	}

	[Token(Token = "0x60059A0")]
	[Address(RVA = "0xEFD850", Offset = "0xEFC650", Length = "0x394")]
	public static string GetStringFromColor(Color col)
	{
		return null;
	}

	[Token(Token = "0x60059A1")]
	[Address(RVA = "0xEFDBF0", Offset = "0xEFC9F0", Length = "0xF")]
	public static Color GetColorWithAlpha(Color source, float alpha)
	{
		return default(Color);
	}

	[Token(Token = "0x60059A2")]
	[Address(RVA = "0xEFDC00", Offset = "0xEFCA00", Length = "0x2FF")]
	public static Texture2D GetGearCoverflowTexture(GearItem gi)
	{
		return null;
	}

	[Token(Token = "0x60059A3")]
	[Address(RVA = "0xEFDF00", Offset = "0xEFCD00", Length = "0xA1")]
	public static Texture2D GetGearCoverflowDamageTexture(GearItem gi)
	{
		return null;
	}

	[Token(Token = "0x60059A4")]
	[Address(RVA = "0xEFDFB0", Offset = "0xEFCDB0", Length = "0xA1")]
	public static Texture2D GetGearCoverflowBlendTexture(GearItem gi)
	{
		return null;
	}

	[Token(Token = "0x60059A5")]
	[Address(RVA = "0xEFE060", Offset = "0xEFCE60", Length = "0x558")]
	public static Texture2D GetInventoryIconTexture(GearItemData gearItemData, float conditionPercent = 100f)
	{
		return null;
	}

	[Token(Token = "0x60059A6")]
	[Address(RVA = "0xEFE5C0", Offset = "0xEFD3C0", Length = "0xA15")]
	public static Texture2D GetInventoryIconTexture(GearItem gi)
	{
		return null;
	}

	[Token(Token = "0x60059A7")]
	[Address(RVA = "0xEFEFE0", Offset = "0xEFDDE0", Length = "0x1E3")]
	public static Texture2D GetInventoryIconTexture(GearItem gi, float conditionPercent)
	{
		return null;
	}

	[Token(Token = "0x60059A8")]
	[Address(RVA = "0xEFF1D0", Offset = "0xEFDFD0", Length = "0x203")]
	public static Texture2D GetInventoryIconTextureFromPrefabName(string prefabName, bool opened = false)
	{
		return null;
	}

	[Token(Token = "0x60059A9")]
	[Address(RVA = "0x4582A0", Offset = "0x4570A0", Length = "0x3")]
	public static Texture2D GetInventoryBGTexture(GearItem gi)
	{
		return null;
	}

	[Token(Token = "0x60059AA")]
	[Address(RVA = "0x1A4B500", Offset = "0x1A4A300", Length = "0x234")]
	public static TType GetComponentInChildren<TType>(GameObject objRoot) where TType : Component
	{
		return null;
	}

	[Token(Token = "0x60059AB")]
	[Address(RVA = "0xEFF3E0", Offset = "0xEFE1E0", Length = "0x3C8")]
	public static Transform FindChildRecursive(Transform trans, string childName)
	{
		return null;
	}

	[Token(Token = "0x60059AC")]
	[Address(RVA = "0xEFF7B0", Offset = "0xEFE5B0", Length = "0x51")]
	public static GameObject CreateOrFindGameObjectFromPath(string path)
	{
		return null;
	}

	[Token(Token = "0x60059AD")]
	[Address(RVA = "0xEFF810", Offset = "0xEFE610", Length = "0x71B")]
	public static GameObject CreateOrFindGameObjectFromPath(string path, Transform root)
	{
		return null;
	}

	[Token(Token = "0x60059AE")]
	[Address(RVA = "0xEFFF30", Offset = "0xEFED30", Length = "0xB1")]
	public static string SanitizePrefabName(string prefabName)
	{
		return null;
	}

	[Token(Token = "0x60059AF")]
	[Address(RVA = "0xEFFFF0", Offset = "0xEFEDF0", Length = "0x6F6")]
	public static float StickItemToGroundAtLocation(GameObject go, Vector3 location, float randomRadius = 1f)
	{
		return 0f;
	}

	[Token(Token = "0x60059B0")]
	[Address(RVA = "0xF006F0", Offset = "0xEFF4F0", Length = "0xDB")]
	public static StreamWriter GetFileStream(string path)
	{
		return null;
	}

	[Token(Token = "0x60059B1")]
	[Address(RVA = "0xF007D0", Offset = "0xEFF5D0", Length = "0xF1")]
	public static void SetCameraFOVSafe(Camera cam, float fov)
	{
	}

	[Token(Token = "0x60059B2")]
	[Address(RVA = "0xF008D0", Offset = "0xEFF6D0", Length = "0x18E")]
	public static bool GetMovementPressed(MonoBehaviour context, bool useSecondary)
	{
		return false;
	}

	[Token(Token = "0x60059B3")]
	[Address(RVA = "0xF00A60", Offset = "0xEFF860", Length = "0x332")]
	public static float GetMenuMovementHorizontal(MonoBehaviour context, bool useSecondary = true, bool useTimer = true)
	{
		return 0f;
	}

	[Token(Token = "0x60059B4")]
	[Address(RVA = "0xF00DA0", Offset = "0xEFFBA0", Length = "0x2F9")]
	public static float GetMenuMovementVertical(MonoBehaviour context, bool useSecondary = true, bool useTimer = true)
	{
		return 0f;
	}

	[Token(Token = "0x60059B5")]
	[Address(RVA = "0xF010A0", Offset = "0xEFFEA0", Length = "0x28A")]
	public static float GetMenuMovementVerticalRightStick(MonoBehaviour context, bool useTimer = true, bool useTimerForCameraMouse = false)
	{
		return 0f;
	}

	[Token(Token = "0x60059B6")]
	[Address(RVA = "0xF01330", Offset = "0xF00130", Length = "0x1E9")]
	public static float AdjustVerticalMoveWithTimer(float movement)
	{
		return 0f;
	}

	[Token(Token = "0x60059B7")]
	[Address(RVA = "0xF01520", Offset = "0xF00320", Length = "0x48F")]
	public static float GetMenuMovementHorizontalRightStick(MonoBehaviour context, bool useTimer = true)
	{
		return 0f;
	}

	[Token(Token = "0x60059B8")]
	[Address(RVA = "0xF019B0", Offset = "0xF007B0", Length = "0x173")]
	public static bool GetMenuMovementFilterLeft(MonoBehaviour context)
	{
		return false;
	}

	[Token(Token = "0x60059B9")]
	[Address(RVA = "0xF01B30", Offset = "0xF00930", Length = "0x173")]
	public static bool GetMenuMovementFilterRight(MonoBehaviour context)
	{
		return false;
	}

	[Token(Token = "0x60059BA")]
	[Address(RVA = "0xF01CB0", Offset = "0xF00AB0", Length = "0xA4")]
	public static bool GetMenuMovementAllowed()
	{
		return false;
	}

	[Token(Token = "0x60059BB")]
	[Address(RVA = "0xF01D60", Offset = "0xF00B60", Length = "0xA6")]
	public static void UpdateMenuMovementDelay()
	{
	}

	[Token(Token = "0x60059BC")]
	[Address(RVA = "0xF01E10", Offset = "0xF00C10", Length = "0xF4")]
	public static string GetPressAnyKeyString()
	{
		return null;
	}

	[Token(Token = "0x60059BD")]
	[Address(RVA = "0x4A2140", Offset = "0x4A0F40", Length = "0x3")]
	public static bool ShouldDestroyWornOutGear(GearItem gi)
	{
		return false;
	}

	[Token(Token = "0x60059BE")]
	[Address(RVA = "0xF01F10", Offset = "0xF00D10", Length = "0x4A")]
	public static bool IsGamepadActive()
	{
		return false;
	}

	[Token(Token = "0x60059BF")]
	[Address(RVA = "0xF01F60", Offset = "0xF00D60", Length = "0x49")]
	public static bool IsMouseActive()
	{
		return false;
	}

	[Token(Token = "0x60059C0")]
	[Address(RVA = "0xF01FB0", Offset = "0xF00DB0", Length = "0x3BC")]
	public static float InputControlRotate(MonoBehaviour context, float rotationDegreesPerSecond, float mouseWheelRotationDegrees)
	{
		return 0f;
	}

	[Token(Token = "0x60059C1")]
	[Address(RVA = "0xF02370", Offset = "0xF01170", Length = "0x614")]
	public static void LightPositionFixUp(Transform lightT, float lightLift)
	{
	}

	[Token(Token = "0x60059C2")]
	[Address(RVA = "0xF02990", Offset = "0xF01790", Length = "0xA0")]
	public static void SetActive(GameObject go, bool active)
	{
	}

	[Token(Token = "0x60059C3")]
	[Address(RVA = "0xF02A40", Offset = "0xF01840", Length = "0x39C")]
	public static Collider GetLargestCollider(GameObject go)
	{
		return null;
	}

	[Token(Token = "0x60059C4")]
	[Address(RVA = "0xF02DE0", Offset = "0xF01BE0", Length = "0x226")]
	public static Renderer GetLargestBoundsRenderer(GameObject go)
	{
		return null;
	}

	[Token(Token = "0x60059C5")]
	[Address(RVA = "0xF03010", Offset = "0xF01E10", Length = "0x4E")]
	public static Vector2 GetVector2WithDeadzone(Vector2 input, float deadzone)
	{
		return default(Vector2);
	}

	[Token(Token = "0x60059C6")]
	[Address(RVA = "0xF03060", Offset = "0xF01E60", Length = "0x4D")]
	public static Vector2 GetVector2WithZerodSmallAxis(Vector2 input)
	{
		return default(Vector2);
	}

	[Token(Token = "0x60059C7")]
	[Address(RVA = "0xF030B0", Offset = "0xF01EB0", Length = "0x79A")]
	public static void ShowInspectForGearItem(GearItem gi)
	{
	}

	[Token(Token = "0x60059C8")]
	[Address(RVA = "0xF03850", Offset = "0xF02650", Length = "0x933")]
	public static void ExitInspectForGearItem(GearItem gi)
	{
	}

	[Token(Token = "0x60059C9")]
	[Address(RVA = "0xF04190", Offset = "0xF02F90", Length = "0x3A5")]
	public static bool GetInspectModePivot(Inspect inspect, out Vector3 pivot)
	{
		pivot = default(Vector3);
		return false;
	}

	[Token(Token = "0x60059CA")]
	[Address(RVA = "0xF04540", Offset = "0xF03340", Length = "0x64F")]
	public static string GetRegionSpriteNameFromSaveSlotInfo(string saveSlotLocation)
	{
		return null;
	}

	[Token(Token = "0x60059CB")]
	[Address(RVA = "0xF04B90", Offset = "0xF03990", Length = "0x2A9")]
	public static bool SceneIsTransition(string sceneName)
	{
		return false;
	}

	[Token(Token = "0x60059CC")]
	[Address(RVA = "0xF04E40", Offset = "0xF03C40", Length = "0xCE")]
	public static bool IsSceneTransition()
	{
		return false;
	}

	[Token(Token = "0x60059CD")]
	[Address(RVA = "0xF04F10", Offset = "0xF03D10", Length = "0x556")]
	public static GearItem[] GetGearItemsStoredInSceneByPlayer(bool includeContainers = true)
	{
		return null;
	}

	[Token(Token = "0x60059CE")]
	[Address(RVA = "0xF05470", Offset = "0xF04270", Length = "0x159")]
	public static float GetNumCaloriesInGearItems(GearItem[] gearItems)
	{
		return 0f;
	}

	[Token(Token = "0x60059CF")]
	[Address(RVA = "0xF055D0", Offset = "0xF043D0", Length = "0x35")]
	private static byte ToByte(float f)
	{
		return 0;
	}

	[Token(Token = "0x60059D0")]
	[Address(RVA = "0xF05610", Offset = "0xF04410", Length = "0x1B5")]
	public static string ColorToHex(Color color)
	{
		return null;
	}

	[Token(Token = "0x60059D1")]
	[Address(RVA = "0xF057D0", Offset = "0xF045D0", Length = "0x108")]
	public static float GetFirstDayLengthInHours()
	{
		return 0f;
	}

	[Token(Token = "0x60059D2")]
	[Address(RVA = "0xF058E0", Offset = "0xF046E0", Length = "0x5E")]
	public static bool DisableGUIPanCamera()
	{
		return false;
	}

	[Token(Token = "0x60059D3")]
	[Address(RVA = "0xF05940", Offset = "0xF04740", Length = "0x4FC")]
	public static void UpdateTransformFromInspectAndCamera(Transform transform, vp_FPSCamera camera, Inspect inspect, Vector3 originalScale)
	{
	}

	[Token(Token = "0x60059D4")]
	[Address(RVA = "0xF05E40", Offset = "0xF04C40", Length = "0x4D")]
	public static bool StringAllNullTerminators(string s)
	{
		return false;
	}

	[Token(Token = "0x60059D5")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	private static void CreateStreamWriter()
	{
	}

	[Token(Token = "0x60059D6")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	private static void CloseStreamWriter()
	{
	}

	[Token(Token = "0x60059D7")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public static void Log(string line)
	{
	}

	[Token(Token = "0x60059D8")]
	[Address(RVA = "0xF05E90", Offset = "0xF04C90", Length = "0x13F")]
	public static void SetIsKinematic(Rigidbody rb, bool enable)
	{
	}

	[Token(Token = "0x60059D9")]
	[Address(RVA = "0xF05FD0", Offset = "0xF04DD0", Length = "0x94")]
	public static void UseHigherPrecisionTimestep(bool enable)
	{
	}

	[Token(Token = "0x60059DA")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public static void DebugBulletHit(Vector3 p1, Vector3 p2)
	{
	}

	[Token(Token = "0x60059DB")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public static void EnableDebugProjectiles(bool enable)
	{
	}

	[Token(Token = "0x60059DC")]
	[Address(RVA = "0xF06070", Offset = "0xF04E70", Length = "0x52")]
	public static bool IsVector3NaN(Vector3 v)
	{
		return false;
	}

	[PreserveSig]
	[Token(Token = "0x60059DD")]
	[Address(RVA = "0xF060D0", Offset = "0xF04ED0", Length = "0x76")]
	public static extern int GetSystemMetrics(SystemMetrics smIndex);

	[Token(Token = "0x60059DE")]
	[Address(RVA = "0x4A2140", Offset = "0x4A0F40", Length = "0x3")]
	public static bool IsDevelopmentBuild()
	{
		return false;
	}

	[Token(Token = "0x60059DF")]
	[Address(RVA = "0xF06150", Offset = "0xF04F50", Length = "0xDD")]
	public static GearItem GetGearItemFromObject(GameObject go)
	{
		return null;
	}

	[Token(Token = "0x60059E0")]
	[Address(RVA = "0xF06230", Offset = "0xF05030", Length = "0x3AA")]
	public static string GetFormattedBytes(double bytes)
	{
		return null;
	}

	[Token(Token = "0x60059E1")]
	[Address(RVA = "0xF065E0", Offset = "0xF053E0", Length = "0x222")]
	public static UISlider GetSliderForScrollbar(GameObject scrollbar)
	{
		return null;
	}

	[Token(Token = "0x60059E2")]
	[Address(RVA = "0xF06810", Offset = "0xF05610", Length = "0x1E2")]
	public static string FormatDisplayTimeMinutes(int minutes, bool includeUnits)
	{
		return null;
	}

	[Token(Token = "0x60059E3")]
	[Address(RVA = "0xF06A00", Offset = "0xF05800", Length = "0xFC")]
	public static void OpenURL(string url)
	{
	}

	[Token(Token = "0x60059E4")]
	[Address(RVA = "0xF06B00", Offset = "0xF05900", Length = "0x4F")]
	public static float AdjustScalarForProgressBarSprites(float scalar)
	{
		return 0f;
	}

	[Token(Token = "0x60059E5")]
	[Address(RVA = "0xF06B50", Offset = "0xF05950", Length = "0x4DA")]
	public static void SetSHCoefficients(Vector3 position, CommandBuffer commandBuffer)
	{
	}

	[Token(Token = "0x60059E6")]
	[Address(RVA = "0xF07030", Offset = "0xF05E30", Length = "0x14")]
	public static int Modulo(int x, int m)
	{
		return 0;
	}

	[Token(Token = "0x60059E7")]
	[Address(RVA = "0xF07050", Offset = "0xF05E50", Length = "0x48")]
	public static float Ramp(float t)
	{
		return 0f;
	}

	[Token(Token = "0x60059E8")]
	[Address(RVA = "0xF070A0", Offset = "0xF05EA0", Length = "0x36")]
	public static float XZDistance(Vector3 a, Vector3 b)
	{
		return 0f;
	}

	[Token(Token = "0x60059E9")]
	[Address(RVA = "0xF070E0", Offset = "0xF05EE0", Length = "0x2D")]
	public static float XZMagnitude(Vector3 vec)
	{
		return 0f;
	}

	[Token(Token = "0x60059EA")]
	[Address(RVA = "0xF07110", Offset = "0xF05F10", Length = "0x7B")]
	public static bool Approximately(float a, float b, float epsilon = 0.0001f)
	{
		return false;
	}

	[Token(Token = "0x60059EB")]
	[Address(RVA = "0xF07190", Offset = "0xF05F90", Length = "0xE")]
	public static bool IsZero(float a, float epsilon = 0.0001f)
	{
		return false;
	}

	[Token(Token = "0x60059EC")]
	[Address(RVA = "0xF071A0", Offset = "0xF05FA0", Length = "0x7B")]
	public static bool Approximately(double a, double b, double epsilon = 0.0001)
	{
		return false;
	}

	[Token(Token = "0x60059ED")]
	[Address(RVA = "0xF07220", Offset = "0xF06020", Length = "0x67")]
	public static bool IsZero(double a, double epsilon = 0.0001)
	{
		return false;
	}

	[Token(Token = "0x60059EE")]
	[Address(RVA = "0xF07290", Offset = "0xF06090", Length = "0x67")]
	public static Vector3 GetDirectionVector(Vector3 from, Vector3 to)
	{
		return default(Vector3);
	}

	[Token(Token = "0x60059EF")]
	[Address(RVA = "0xF07300", Offset = "0xF06100", Length = "0xE6")]
	public static float AngleDir(Vector3 fwd, Vector3 targetDir, Vector3 up)
	{
		return 0f;
	}

	[Token(Token = "0x60059F0")]
	[Address(RVA = "0xF073F0", Offset = "0xF061F0", Length = "0x205")]
	public static float GetAngleDegrees(Vector3 v1, Vector3 v2)
	{
		return 0f;
	}

	[Token(Token = "0x60059F1")]
	[Address(RVA = "0xF07600", Offset = "0xF06400", Length = "0x28")]
	public static Vector3 GetFlatVector(Vector3 v1)
	{
		return default(Vector3);
	}

	[Token(Token = "0x60059F2")]
	[Address(RVA = "0xF07630", Offset = "0xF06430", Length = "0x65")]
	public static float CalculateSlopeUnderPosition(Vector3 pos)
	{
		return 0f;
	}

	[Token(Token = "0x60059F3")]
	[Address(RVA = "0xF076A0", Offset = "0xF064A0", Length = "0x1DA")]
	public static float CalculateSlopeUnderPosition(Vector3 pos, int ignoreMask)
	{
		return 0f;
	}

	[Token(Token = "0x60059F4")]
	[Address(RVA = "0xF07880", Offset = "0xF06680", Length = "0x2CA")]
	public static Quaternion GetOrientationOnSlope(Transform t, Vector3 groundNormal)
	{
		return default(Quaternion);
	}

	[Token(Token = "0x60059F5")]
	[Address(RVA = "0xF07B50", Offset = "0xF06950", Length = "0xBEC")]
	private static bool TestOBBOBB(OBB a, OBB b)
	{
		return false;
	}

	[Token(Token = "0x60059F6")]
	[Address(RVA = "0xF08740", Offset = "0xF07540", Length = "0xD79")]
	public static bool OrientedBoundingBoxesOverlap(GameObject a, GameObject b)
	{
		return false;
	}

	[Token(Token = "0x60059F7")]
	[Address(RVA = "0xF094C0", Offset = "0xF082C0", Length = "0x1EB")]
	public static Vector3 NearestPointInfinite(Vector3 lineStart, Vector3 lineEnd, Vector3 point)
	{
		return default(Vector3);
	}

	[Token(Token = "0x60059F8")]
	[Address(RVA = "0xF096B0", Offset = "0xF084B0", Length = "0x2F9")]
	public static Vector3 NearestPoint(Vector3 lineStart, Vector3 lineEnd, Vector3 point)
	{
		return default(Vector3);
	}

	[Token(Token = "0x60059F9")]
	[Address(RVA = "0xF099B0", Offset = "0xF087B0", Length = "0x2DD")]
	public static Vector3 Plane3Intersect(Plane p1, Plane p2, Plane p3)
	{
		return default(Vector3);
	}

	[Token(Token = "0x60059FA")]
	[Address(RVA = "0xF09C90", Offset = "0xF08A90", Length = "0x284")]
	public static bool SphereIntersectsCone(Vector3 sphereCentre, float sphereRadius, Vector3 conePoint, Vector3 coneUnitAxis, float coneAngle)
	{
		return false;
	}

	[Token(Token = "0x60059FB")]
	[Address(RVA = "0xF09F20", Offset = "0xF08D20", Length = "0xFC")]
	public static float Berp(float start, float end, float value)
	{
		return 0f;
	}

	[Token(Token = "0x60059FC")]
	[Address(RVA = "0xF0A020", Offset = "0xF08E20", Length = "0x5A")]
	public static float Bounce(float x, int num = 8)
	{
		return 0f;
	}

	[Token(Token = "0x60059FD")]
	[Address(RVA = "0xF0A080", Offset = "0xF08E80", Length = "0x53")]
	public static float Sway(float x, int num = 8)
	{
		return 0f;
	}

	[Token(Token = "0x60059FE")]
	[Address(RVA = "0xF0A0E0", Offset = "0xF08EE0", Length = "0x3B")]
	public static float AlmostIdentity(float val, float threshold, float thresholdVal)
	{
		return 0f;
	}

	[Token(Token = "0x60059FF")]
	[Address(RVA = "0xF0A120", Offset = "0xF08F20", Length = "0x2F")]
	public static float Impulse(float t, float span)
	{
		return 0f;
	}

	[Token(Token = "0x6005A00")]
	[Address(RVA = "0xF0A150", Offset = "0xF08F50", Length = "0x43")]
	public static float CubicPulse(float t, float centre, float falloffDist)
	{
		return 0f;
	}

	[Token(Token = "0x6005A01")]
	[Address(RVA = "0xF0A1A0", Offset = "0xF08FA0", Length = "0x2D")]
	public static float ExpStep(float t, float exp, float pow)
	{
		return 0f;
	}

	[Token(Token = "0x6005A02")]
	[Address(RVA = "0xF0A1D0", Offset = "0xF08FD0", Length = "0x20")]
	public static float Parabola(float t, float pow)
	{
		return 0f;
	}

	[Token(Token = "0x6005A03")]
	[Address(RVA = "0xF0A1F0", Offset = "0xF08FF0", Length = "0x6F")]
	public static float PowCurve(float t, float scale, float powA, float powB)
	{
		return 0f;
	}

	[Token(Token = "0x6005A04")]
	[Address(RVA = "0xF0A260", Offset = "0xF09060", Length = "0x7E")]
	public static float SmoothMinExp(float a, float b, float k)
	{
		return 0f;
	}

	[Token(Token = "0x6005A05")]
	[Address(RVA = "0xF0A2E0", Offset = "0xF090E0", Length = "0x8D")]
	public static float SmoothMinPoly(float a, float b, float k)
	{
		return 0f;
	}

	[Token(Token = "0x6005A06")]
	[Address(RVA = "0xF0A370", Offset = "0xF09170", Length = "0x6A")]
	public static float SmoothMinPow(float a, float b, float k)
	{
		return 0f;
	}

	[Token(Token = "0x6005A07")]
	[Address(RVA = "0xF0A3E0", Offset = "0xF091E0", Length = "0x2C")]
	public static float EaseInCubic(float t, float duration)
	{
		return 0f;
	}

	[Token(Token = "0x6005A08")]
	[Address(RVA = "0xF0A410", Offset = "0xF09210", Length = "0x3F")]
	public static float EaseOutCubic(float t, float duration)
	{
		return 0f;
	}

	[Token(Token = "0x6005A09")]
	[Address(RVA = "0xF0A450", Offset = "0xF09250", Length = "0x5A")]
	public static float EaseInOutCubic(float t, float duration)
	{
		return 0f;
	}

	[Token(Token = "0x6005A0A")]
	[Address(RVA = "0xF0A4B0", Offset = "0xF092B0", Length = "0xAD")]
	public static float EaseOutBounce(float t, float duration)
	{
		return 0f;
	}

	[Token(Token = "0x6005A0B")]
	[Address(RVA = "0xF0A560", Offset = "0xF09360", Length = "0x51")]
	public static float ExpFilterWeight(float deltaTime, float timeConstant)
	{
		return 0f;
	}

	[Token(Token = "0x6005A0C")]
	[Address(RVA = "0xF0A5C0", Offset = "0xF093C0", Length = "0xF3")]
	public static float ExpStep(float prevFilt, float next, float deltaTime, float timeConstant)
	{
		return 0f;
	}

	[Token(Token = "0x6005A0D")]
	[Address(RVA = "0xF0A6C0", Offset = "0xF094C0", Length = "0x119")]
	public static float ExpStep(float prevFilt, float next, float deltaTime, float timeConstant, float maxVel)
	{
		return 0f;
	}

	[Token(Token = "0x6005A0E")]
	[Address(RVA = "0xF0A7E0", Offset = "0xF095E0", Length = "0xD3")]
	public static float ExpStepAngle(float prevFilt, float next, float deltaTime, float timeConstant)
	{
		return 0f;
	}

	[Token(Token = "0x6005A0F")]
	[Address(RVA = "0xF0A8C0", Offset = "0xF096C0", Length = "0xFD")]
	public static Vector2 ExpStep(Vector2 prevFilt, Vector2 next, float deltaTime, float timeConstant)
	{
		return default(Vector2);
	}

	[Token(Token = "0x6005A10")]
	[Address(RVA = "0xF0A9C0", Offset = "0xF097C0", Length = "0x205")]
	public static Vector2 ExpStep(Vector2 prevFilt, Vector2 next, float deltaTime, float timeConstant, float maxVel)
	{
		return default(Vector2);
	}

	[Token(Token = "0x6005A11")]
	[Address(RVA = "0xF0ABD0", Offset = "0xF099D0", Length = "0x155")]
	public static Vector3 ExpStep(Vector3 prevFilt, Vector3 next, float deltaTime, float timeConstant)
	{
		return default(Vector3);
	}

	[Token(Token = "0x6005A12")]
	[Address(RVA = "0xF0AD30", Offset = "0xF09B30", Length = "0x29E")]
	public static Vector3 ExpStep(Vector3 prevFilt, Vector3 next, float deltaTime, float timeConstant, float maxVel)
	{
		return default(Vector3);
	}

	[Token(Token = "0x6005A13")]
	[Address(RVA = "0xF0AFD0", Offset = "0xF09DD0", Length = "0x143")]
	public static Quaternion ExpStep(Quaternion prevFilt, Quaternion next, float deltaTime, float timeConstant)
	{
		return default(Quaternion);
	}

	[Token(Token = "0x6005A14")]
	[Address(RVA = "0xF0B120", Offset = "0xF09F20", Length = "0x143")]
	public static Quaternion ExpStepSlerp(Quaternion prevFilt, Quaternion next, float deltaTime, float timeConstant)
	{
		return default(Quaternion);
	}

	[Token(Token = "0x6005A15")]
	[Address(RVA = "0xF0B270", Offset = "0xF0A070", Length = "0x3F")]
	public static float ShortestAngle(float targetAngle, float sourceAngle)
	{
		return 0f;
	}

	[Token(Token = "0x6005A16")]
	[Address(RVA = "0xF0B2B0", Offset = "0xF0A0B0", Length = "0xB7")]
	public static float CalcHermite(float p0, float m0, float p1, float m1, float t)
	{
		return 0f;
	}

	[Token(Token = "0x6005A17")]
	[Address(RVA = "0xF0B370", Offset = "0xF0A170", Length = "0xCC")]
	public static float CalcHermiteTangent(float p0, float m0, float p1, float m1, float t)
	{
		return 0f;
	}

	[Token(Token = "0x6005A18")]
	[Address(RVA = "0xF0B440", Offset = "0xF0A240", Length = "0x14C")]
	public static Vector2 GeneratePoissonSample(List<Vector2> samples, int maxCandidates)
	{
		return default(Vector2);
	}

	[Token(Token = "0x6005A19")]
	[Address(RVA = "0xF0B590", Offset = "0xF0A390", Length = "0x1BB")]
	public static float ComputeSqrDistanceToNearest(List<Vector2> samples, Vector2 candidate)
	{
		return 0f;
	}

	[Token(Token = "0x6005A1A")]
	[Address(RVA = "0xF0B750", Offset = "0xF0A550", Length = "0x35")]
	public static float DistanceSqr(Vector2 a, Vector2 b)
	{
		return 0f;
	}

	[Token(Token = "0x6005A1B")]
	[Address(RVA = "0xF0B790", Offset = "0xF0A590", Length = "0x59")]
	public static float DistanceSqr(Vector3 a, Vector3 b)
	{
		return 0f;
	}

	[Token(Token = "0x6005A1C")]
	[Address(RVA = "0xF0B7F0", Offset = "0xF0A5F0", Length = "0x5")]
	public static float Sqr(float a)
	{
		return 0f;
	}

	[Token(Token = "0x6005A1D")]
	[Address(RVA = "0x6ED510", Offset = "0x6EC310", Length = "0x1F")]
	public static float FastSqrDist2DJob(float4 a, float4 b)
	{
		return 0f;
	}

	[Token(Token = "0x6005A1E")]
	[Address(RVA = "0xF0B800", Offset = "0xF0A600", Length = "0x36B")]
	public static bool AabbOverlap(Bounds a, Bounds b, out Vector3 axis, out float distance)
	{
		axis = default(Vector3);
		distance = default(float);
		return false;
	}

	[Token(Token = "0x6005A1F")]
	[Address(RVA = "0xF0BB70", Offset = "0xF0A970", Length = "0x390")]
	public static bool TestAabbAxis(Vector3 axis, Bounds a, Bounds b, ref Vector3 minimumTranslationAxis, ref float minimumTranslationDistanceSqr)
	{
		return false;
	}

	[Token(Token = "0x6005A20")]
	[Address(RVA = "0xF0BF00", Offset = "0xF0AD00", Length = "0xF7")]
	public static float MoveToValue(float currentValue, float desiredValue, float speed)
	{
		return 0f;
	}

	[Token(Token = "0x6005A21")]
	[Address(RVA = "0x1A4BFA0", Offset = "0x1A4ADA0", Length = "0x7B")]
	public static void ShuffleList<T>(IList<T> list, Func<int, int, int> randomRange = null)
	{
	}

	[Token(Token = "0x6005A22")]
	[Address(RVA = "0x1A4C120", Offset = "0x1A4AF20", Length = "0x361")]
	public static void ShuffleList<T>(IList<T> list, int maxCount, Func<int, int, int> randomRange = null)
	{
	}

	[Token(Token = "0x6005A23")]
	[Address(RVA = "0xF0C000", Offset = "0xF0AE00", Length = "0x1F")]
	public static float Remap(float value, float fromLow, float fromHigh, float toLow, float toHigh)
	{
		return 0f;
	}

	[Token(Token = "0x6005A24")]
	[Address(RVA = "0xF0C020", Offset = "0xF0AE20", Length = "0x8A")]
	public static bool MissionIDExists(string missionID)
	{
		return false;
	}

	[Token(Token = "0x6005A25")]
	[Address(RVA = "0xF0C0B0", Offset = "0xF0AEB0", Length = "0x8A")]
	public static bool ObjectiveIDExists(string objectiveID)
	{
		return false;
	}

	[Token(Token = "0x6005A26")]
	[Address(RVA = "0xF0C140", Offset = "0xF0AF40", Length = "0x8A")]
	public static bool MissionMapMarkerIDExists(string markerID)
	{
		return false;
	}

	[Token(Token = "0x6005A27")]
	[Address(RVA = "0xF0C1D0", Offset = "0xF0AFD0", Length = "0x427")]
	private static void MaybePopulateMissionMapMarkerList()
	{
	}

	[Token(Token = "0x6005A28")]
	[Address(RVA = "0xF0C600", Offset = "0xF0B400", Length = "0x4C0")]
	private static void MaybePopulateMissionIds()
	{
	}

	[Token(Token = "0x6005A29")]
	[Address(RVA = "0xF0CAD0", Offset = "0xF0B8D0", Length = "0x364")]
	public static bool RaycastNearest(Vector3 origin, Vector3 direction, out RaycastHit hit, float maxDistance, int layerMask)
	{
		hit = default(RaycastHit);
		return false;
	}

	[Token(Token = "0x6005A2A")]
	[Address(RVA = "0xF0CE40", Offset = "0xF0BC40", Length = "0x1A4")]
	public static bool ColliderValidForClosestPoint(Collider collider)
	{
		return false;
	}

	[Token(Token = "0x6005A2B")]
	[Address(RVA = "0xF0CFF0", Offset = "0xF0BDF0", Length = "0x25F")]
	public static Texture2D GetBilinearScaledTexture(Texture2D source, int targetWidth, int targetHeight)
	{
		return null;
	}

	[Token(Token = "0x6005A2C")]
	[Address(RVA = "0xF0D250", Offset = "0xF0C050", Length = "0x120")]
	public static void DisableRenderers(GameObject parent)
	{
	}

	[Token(Token = "0x6005A2D")]
	[Address(RVA = "0xF0D380", Offset = "0xF0C180", Length = "0x149")]
	public static void EnableRenderers(GameObject parent)
	{
	}

	[Token(Token = "0x6005A2E")]
	[Address(RVA = "0xF0D4D0", Offset = "0xF0C2D0", Length = "0x62")]
	public static void SetAmbientLight(Color ambientColor)
	{
	}

	[Token(Token = "0x6005A2F")]
	[Address(RVA = "0xF0D540", Offset = "0xF0C340", Length = "0x34D")]
	public static void SetAmbientLightScaled(Color ambientColor, float probeScalar)
	{
	}

	[Token(Token = "0x6005A30")]
	[Address(RVA = "0xF0D890", Offset = "0xF0C690", Length = "0x1FB")]
	public static void ApplyPropertyBlockToRenderers(List<Renderer> renderers, MaterialPropertyBlock propertyBlock)
	{
	}

	[Token(Token = "0x6005A31")]
	[Address(RVA = "0xF0DA90", Offset = "0xF0C890", Length = "0x51")]
	public static void ResetPropertyBlockOnRenderers(List<Renderer> renderers)
	{
	}

	[Token(Token = "0x6005A32")]
	[Address(RVA = "0xF0DAF0", Offset = "0xF0C8F0", Length = "0x175")]
	public static void SetupMaterialBlockForTint(ref MaterialPropertyBlock block, Color color, float glowScalar)
	{
	}

	[Token(Token = "0x6005A33")]
	[Address(RVA = "0xF0DC70", Offset = "0xF0CA70", Length = "0xCB")]
	public static void SetupMaterialBlockForOutline(ref MaterialPropertyBlock block)
	{
	}

	[Token(Token = "0x6005A34")]
	[Address(RVA = "0xF0DD40", Offset = "0xF0CB40", Length = "0x602")]
	public static void ClearWithFullScreenQuad(RenderTexture target, Color clearColor)
	{
	}

	[Token(Token = "0x6005A35")]
	[Address(RVA = "0xF0E350", Offset = "0xF0D150", Length = "0xCC7")]
	public static void GeneratePatchCoefficients(Transform transform, Vector3 minPos, Vector3 maxPos, string tag, ref Vector3[] hermiteCoefficients, out Vector3 heightInfo)
	{
		heightInfo = default(Vector3);
	}

	[Token(Token = "0x6005A36")]
	[Address(RVA = "0xF0F020", Offset = "0xF0DE20", Length = "0x546")]
	public static float GetPatchHeightAtPosition(Vector3 p, Vector3[] hermiteCoefficients)
	{
		return 0f;
	}

	[Token(Token = "0x6005A37")]
	[Address(RVA = "0xF0F570", Offset = "0xF0E370", Length = "0x546")]
	public static float GetPatchHeightTangentAtPosition(Vector3 p, Vector3[] hermiteCoefficients)
	{
		return 0f;
	}

	[Token(Token = "0x6005A38")]
	[Address(RVA = "0xF0FAC0", Offset = "0xF0E8C0", Length = "0x5AA")]
	public static Mesh BuildGridMeshXZ(Vector2 dims, int vertsX, int vertsY, float uvMin = 0f, float uvMax = 1f)
	{
		return null;
	}

	[Token(Token = "0x6005A39")]
	[Address(RVA = "0xF10070", Offset = "0xF0EE70", Length = "0x48A")]
	public static Mesh[] GenerateGridMeshQuadrantSet(Vector3 dims, int edgeVerts, int textureRes, float boundsYSize)
	{
		return null;
	}

	[Token(Token = "0x6005A3A")]
	[Address(RVA = "0xF10500", Offset = "0xF0F300", Length = "0x1A6")]
	public static void EnableShadows(bool enabled)
	{
	}

	[Token(Token = "0x6005A3B")]
	[Address(RVA = "0xF106B0", Offset = "0xF0F4B0", Length = "0x11CF")]
	private static Mesh BuildMeshForGridQuadrantSubset(int mask, Mesh refMesh, float minUV)
	{
		return null;
	}

	[Token(Token = "0x6005A3C")]
	[Address(RVA = "0xF11880", Offset = "0xF10680", Length = "0x5AD")]
	private static bool RaycastForTag(string tag, Vector3 origin, Vector3 direction, out RaycastHit hitInfo, float maxDistance, int layerMask)
	{
		hitInfo = default(RaycastHit);
		return false;
	}

	[Token(Token = "0x6005A3D")]
	[Address(RVA = "0x4A2140", Offset = "0x4A0F40", Length = "0x3")]
	public static bool UseEnhancedRenderSettings()
	{
		return false;
	}

	[Token(Token = "0x6005A3E")]
	[Address(RVA = "0xF11E30", Offset = "0xF10C30", Length = "0x4EB")]
	private static void ClampPatchCoefficients(float centerY, float maxDelta)
	{
	}

	[Token(Token = "0x6005A3F")]
	[Address(RVA = "0xF12320", Offset = "0xF11120", Length = "0x1FF")]
	private static float CheckHeightAgainstCoords(float py, float maxDelta, int x, int z)
	{
		return 0f;
	}

	[Token(Token = "0x6005A40")]
	[Address(RVA = "0xF12520", Offset = "0xF11320", Length = "0x4E")]
	public static string SerializeObject(object obj)
	{
		return null;
	}

	[Token(Token = "0x6005A41")]
	[Address(RVA = "0x1A4AB90", Offset = "0x1A49990", Length = "0x90")]
	public static T DeserializeObject<T>(string text) where T : new()
	{
		return default(T);
	}

	[Token(Token = "0x6005A42")]
	[Address(RVA = "0xF12570", Offset = "0xF11370", Length = "0x96")]
	public static FastSpline CreateFastSpline(Spline spline, NativeArray<double> matrix)
	{
		return default(FastSpline);
	}

	[Token(Token = "0x6005A43")]
	[Address(RVA = "0xF12610", Offset = "0xF11410", Length = "0x21D")]
	public static float GetClosestPointParamOnSpline(Vector3 position, ref FastSpline spline)
	{
		return 0f;
	}

	[Token(Token = "0x6005A44")]
	[Address(RVA = "0xF12830", Offset = "0xF11630", Length = "0x19B")]
	private static float GetClosestPointParamOnSegmentIntern(Vector3 point, float start, float end, float step, ref FastSpline spline)
	{
		return 0f;
	}

	[Token(Token = "0x6005A45")]
	[Address(RVA = "0xF129D0", Offset = "0xF117D0", Length = "0x11D")]
	public static Vector3 GetPositionOnSpline(ref FastSpline spline, float param)
	{
		return default(Vector3);
	}

	[Token(Token = "0x6005A46")]
	[Address(RVA = "0xF12AF0", Offset = "0xF118F0", Length = "0x16F")]
	public static int GetValidNodesCount(Spline spline)
	{
		return 0;
	}

	[Token(Token = "0x6005A47")]
	[Address(RVA = "0xF12C60", Offset = "0xF11A60", Length = "0x21B")]
	private static SegmentParameter RecalculateParameter(double param, ref FastSpline spline)
	{
		return default(SegmentParameter);
	}

	[Token(Token = "0x6005A48")]
	[Address(RVA = "0xF12E80", Offset = "0xF11C80", Length = "0x6C")]
	public static uint ParseSubtitles(string filename, ref Subtitle[] subtitles)
	{
		return 0u;
	}

	[Token(Token = "0x6005A49")]
	[Address(RVA = "0xF12EF0", Offset = "0xF11CF0", Length = "0x128")]
	public static uint ParseSubtitles(string filename, ref Subtitle[] subtitles, ref uint frameRate)
	{
		return 0u;
	}

	[Token(Token = "0x6005A4A")]
	[Address(RVA = "0xF13020", Offset = "0xF11E20", Length = "0x6C")]
	public static uint ParseSubtitles(TextAsset asset, ref Subtitle[] subtitles)
	{
		return 0u;
	}

	[Token(Token = "0x6005A4B")]
	[Address(RVA = "0xF13090", Offset = "0xF11E90", Length = "0x20E")]
	public static uint ParseSubtitles(TextAsset asset, ref Subtitle[] subtitles, ref uint frameRate)
	{
		return 0u;
	}

	[Token(Token = "0x6005A4C")]
	[Address(RVA = "0xF132A0", Offset = "0xF120A0", Length = "0x498")]
	private static uint ParseSubtitles(TextReader reader, ref Subtitle[] subtitles, ref uint frameRate, string errorName)
	{
		return 0u;
	}

	[Token(Token = "0x6005A4D")]
	[Address(RVA = "0xF13740", Offset = "0xF12540", Length = "0xB8")]
	public static uint GetNextEndOrStartFrame(uint frame, Subtitle[] subtitles, uint numSubtitles)
	{
		return 0u;
	}

	[Token(Token = "0x6005A4E")]
	[Address(RVA = "0xF13800", Offset = "0xF12600", Length = "0x200")]
	public static void UpdateSubtitles(uint frame, Subtitle[] subtitles, uint numSubtitles, int encodingFrameRate = 0)
	{
	}

	[Token(Token = "0x6005A4F")]
	[Address(RVA = "0xF13A10", Offset = "0xF12810", Length = "0x14")]
	public static uint GetSubtitleFrame(float currentTimeSeconds, long frameRate = 24L)
	{
		return 0u;
	}

	[Token(Token = "0x6005A50")]
	[Address(RVA = "0xF13A30", Offset = "0xF12830", Length = "0x15B")]
	public static float GetNextSkipTime(float currentTimeSeconds, Subtitle[] subtitles, uint numSubtitles, long frameRate = 24L)
	{
		return 0f;
	}

	[Token(Token = "0x6005A51")]
	[Address(RVA = "0xF13B90", Offset = "0xF12990", Length = "0x554")]
	public static string GetTimeSinceText(TimeSpan timeSince)
	{
		return null;
	}

	[Token(Token = "0x6005A52")]
	[Address(RVA = "0xF140F0", Offset = "0xF12EF0", Length = "0xF3")]
	public static string LocKeyPreview(string myKey, bool stripLineBreaks, int clampLength)
	{
		return null;
	}

	[Token(Token = "0x6005A53")]
	[Address(RVA = "0xF141F0", Offset = "0xF12FF0", Length = "0x31C")]
	public static GameObject FindTimelineDynamicBinding(string trackName, PlayableDirector director, string missionObjectId, string childObjectName = "")
	{
		return null;
	}

	[Token(Token = "0x6005A54")]
	[Address(RVA = "0x430B50", Offset = "0x42F950", Length = "0x3")]
	public static bool IsAllowedToAccessNetwork()
	{
		return false;
	}

	[IteratorStateMachine(typeof(_003CWebRequest_003Ed__340))]
	[Token(Token = "0x6005A55")]
	[Address(RVA = "0xF14510", Offset = "0xF13310", Length = "0x15C")]
	public static IEnumerator WebRequest(string url, Action<UnityWebRequest> onSuccess, Action<UnityWebRequest> onFailure = null)
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CWebRequest_003Ed__341))]
	[Token(Token = "0x6005A56")]
	[Address(RVA = "0xF14670", Offset = "0xF13470", Length = "0x1B1")]
	public static IEnumerator WebRequest(string url, WWWForm form, Action<UnityWebRequest> onSuccess, Action<UnityWebRequest> onFailure = null)
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CWebRequestPut_003Ed__342))]
	[Token(Token = "0x6005A57")]
	[Address(RVA = "0xF14830", Offset = "0xF13630", Length = "0x201")]
	public static IEnumerator WebRequestPut(string url, byte[] data, Dictionary<string, string> httpHeaders, Action<UnityWebRequest> onSuccess, Action<UnityWebRequest> onFailure = null)
	{
		return null;
	}

	[Token(Token = "0x6005A58")]
	[Address(RVA = "0xF14A40", Offset = "0xF13840", Length = "0xC8")]
	private static bool PreValidatRequest(ref string url)
	{
		return false;
	}

	[Token(Token = "0x6005A59")]
	[Address(RVA = "0x4AF5E0", Offset = "0x4AE3E0", Length = "0x43")]
	public Utils()
	{
	}
}
