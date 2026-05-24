using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x2000028")]
public class iTween : MonoBehaviour
{
	[Token(Token = "0x2000029")]
	private delegate float EasingFunction(float start, float end, float value);

	[Token(Token = "0x200002A")]
	private delegate void ApplyTween();

	[Token(Token = "0x200002B")]
	public enum EaseType
	{
		[Token(Token = "0x4000255")]
		easeInQuad,
		[Token(Token = "0x4000256")]
		easeOutQuad,
		[Token(Token = "0x4000257")]
		easeInOutQuad,
		[Token(Token = "0x4000258")]
		easeInCubic,
		[Token(Token = "0x4000259")]
		easeOutCubic,
		[Token(Token = "0x400025A")]
		easeInOutCubic,
		[Token(Token = "0x400025B")]
		easeInQuart,
		[Token(Token = "0x400025C")]
		easeOutQuart,
		[Token(Token = "0x400025D")]
		easeInOutQuart,
		[Token(Token = "0x400025E")]
		easeInQuint,
		[Token(Token = "0x400025F")]
		easeOutQuint,
		[Token(Token = "0x4000260")]
		easeInOutQuint,
		[Token(Token = "0x4000261")]
		easeInSine,
		[Token(Token = "0x4000262")]
		easeOutSine,
		[Token(Token = "0x4000263")]
		easeInOutSine,
		[Token(Token = "0x4000264")]
		easeInExpo,
		[Token(Token = "0x4000265")]
		easeOutExpo,
		[Token(Token = "0x4000266")]
		easeInOutExpo,
		[Token(Token = "0x4000267")]
		easeInCirc,
		[Token(Token = "0x4000268")]
		easeOutCirc,
		[Token(Token = "0x4000269")]
		easeInOutCirc,
		[Token(Token = "0x400026A")]
		linear,
		[Token(Token = "0x400026B")]
		spring,
		[Token(Token = "0x400026C")]
		easeInBounce,
		[Token(Token = "0x400026D")]
		easeOutBounce,
		[Token(Token = "0x400026E")]
		easeInOutBounce,
		[Token(Token = "0x400026F")]
		easeInBack,
		[Token(Token = "0x4000270")]
		easeOutBack,
		[Token(Token = "0x4000271")]
		easeInOutBack,
		[Token(Token = "0x4000272")]
		easeInElastic,
		[Token(Token = "0x4000273")]
		easeOutElastic,
		[Token(Token = "0x4000274")]
		easeInOutElastic,
		[Token(Token = "0x4000275")]
		punch
	}

	[Token(Token = "0x200002C")]
	public enum LoopType
	{
		[Token(Token = "0x4000277")]
		none,
		[Token(Token = "0x4000278")]
		loop,
		[Token(Token = "0x4000279")]
		pingPong
	}

	[Token(Token = "0x200002D")]
	public enum NamedValueColor
	{
		[Token(Token = "0x400027B")]
		_Color,
		[Token(Token = "0x400027C")]
		_SpecColor,
		[Token(Token = "0x400027D")]
		_Emission,
		[Token(Token = "0x400027E")]
		_ReflectColor
	}

	[Token(Token = "0x200002E")]
	public static class Defaults
	{
		[Token(Token = "0x400027F")]
		public static float time;

		[Token(Token = "0x4000280")]
		public static float delay;

		[Token(Token = "0x4000281")]
		public static NamedValueColor namedColorValue;

		[Token(Token = "0x4000282")]
		public static LoopType loopType;

		[Token(Token = "0x4000283")]
		public static EaseType easeType;

		[Token(Token = "0x4000284")]
		public static float lookSpeed;

		[Token(Token = "0x4000285")]
		public static bool isLocal;

		[Token(Token = "0x4000286")]
		public static Space space;

		[Token(Token = "0x4000287")]
		public static bool orientToPath;

		[Token(Token = "0x4000288")]
		public static Color color;

		[Token(Token = "0x4000289")]
		public static float updateTimePercentage;

		[Token(Token = "0x400028A")]
		public static float updateTime;

		[Token(Token = "0x400028B")]
		public static int cameraFadeDepth;

		[Token(Token = "0x400028C")]
		public static float lookAhead;

		[Token(Token = "0x400028D")]
		public static bool useRealTime;

		[Token(Token = "0x400028E")]
		public static Vector3 up;
	}

	[Token(Token = "0x200002F")]
	private class CRSpline
	{
		[Token(Token = "0x400028F")]
		[FieldOffset(Offset = "0x10")]
		public Vector3[] pts;

		[Token(Token = "0x60002E3")]
		[Address(RVA = "0x8937D0", Offset = "0x8925D0", Length = "0x169")]
		public CRSpline(params Vector3[] pts)
		{
		}

		[Token(Token = "0x60002E4")]
		[Address(RVA = "0x893940", Offset = "0x892740", Length = "0x408")]
		public Vector3 Interp(float t)
		{
			return default(Vector3);
		}
	}

	[CompilerGenerated]
	[Token(Token = "0x2000030")]
	private sealed class _003CStart_003Ed__228 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000290")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4000291")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4000292")]
		[FieldOffset(Offset = "0x20")]
		public iTween _003C_003E4__this;

		[Token(Token = "0x1700001D")]
		object IEnumerator<object>.Current
		{
			[DebuggerHidden]
			[Token(Token = "0x60002E8")]
			[Address(RVA = "0x4571D0", Offset = "0x455FD0", Length = "0x5")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700001E")]
		object IEnumerator.Current
		{
			[DebuggerHidden]
			[Token(Token = "0x60002EA")]
			[Address(RVA = "0x4571D0", Offset = "0x455FD0", Length = "0x5")]
			get
			{
				return null;
			}
		}

		[DebuggerHidden]
		[Token(Token = "0x60002E5")]
		[Address(RVA = "0x4096E0", Offset = "0x4084E0", Length = "0x4")]
		public _003CStart_003Ed__228(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		[Token(Token = "0x60002E6")]
		[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
		void IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60002E7")]
		[Address(RVA = "0x893D50", Offset = "0x892B50", Length = "0xEC")]
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
		[Token(Token = "0x60002E9")]
		[Address(RVA = "0x893E40", Offset = "0x892C40", Length = "0x3E")]
		void IEnumerator.Reset()
		{
		}
	}

	[CompilerGenerated]
	[Token(Token = "0x2000031")]
	private sealed class _003CTweenDelay_003Ed__144 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000293")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4000294")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4000295")]
		[FieldOffset(Offset = "0x20")]
		public iTween _003C_003E4__this;

		[Token(Token = "0x1700001F")]
		object IEnumerator<object>.Current
		{
			[DebuggerHidden]
			[Token(Token = "0x60002EE")]
			[Address(RVA = "0x4571D0", Offset = "0x455FD0", Length = "0x5")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000020")]
		object IEnumerator.Current
		{
			[DebuggerHidden]
			[Token(Token = "0x60002F0")]
			[Address(RVA = "0x4571D0", Offset = "0x455FD0", Length = "0x5")]
			get
			{
				return null;
			}
		}

		[DebuggerHidden]
		[Token(Token = "0x60002EB")]
		[Address(RVA = "0x4096E0", Offset = "0x4084E0", Length = "0x4")]
		public _003CTweenDelay_003Ed__144(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		[Token(Token = "0x60002EC")]
		[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
		void IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60002ED")]
		[Address(RVA = "0x893E80", Offset = "0x892C80", Length = "0x145")]
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
		[Token(Token = "0x60002EF")]
		[Address(RVA = "0x893FD0", Offset = "0x892DD0", Length = "0x3E")]
		void IEnumerator.Reset()
		{
		}
	}

	[CompilerGenerated]
	[Token(Token = "0x2000032")]
	private sealed class _003CTweenRestart_003Ed__146 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000296")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4000297")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4000298")]
		[FieldOffset(Offset = "0x20")]
		public iTween _003C_003E4__this;

		[Token(Token = "0x17000021")]
		object IEnumerator<object>.Current
		{
			[DebuggerHidden]
			[Token(Token = "0x60002F4")]
			[Address(RVA = "0x4571D0", Offset = "0x455FD0", Length = "0x5")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000022")]
		object IEnumerator.Current
		{
			[DebuggerHidden]
			[Token(Token = "0x60002F6")]
			[Address(RVA = "0x4571D0", Offset = "0x455FD0", Length = "0x5")]
			get
			{
				return null;
			}
		}

		[DebuggerHidden]
		[Token(Token = "0x60002F1")]
		[Address(RVA = "0x4096E0", Offset = "0x4084E0", Length = "0x4")]
		public _003CTweenRestart_003Ed__146(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		[Token(Token = "0x60002F2")]
		[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
		void IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60002F3")]
		[Address(RVA = "0x894010", Offset = "0x892E10", Length = "0x14F")]
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
		[Token(Token = "0x60002F5")]
		[Address(RVA = "0x894160", Offset = "0x892F60", Length = "0x3E")]
		void IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000230")]
	public static ArrayList tweens;

	[Token(Token = "0x4000231")]
	[FieldOffset(Offset = "0x20")]
	public string id;

	[Token(Token = "0x4000232")]
	[FieldOffset(Offset = "0x28")]
	public string type;

	[Token(Token = "0x4000233")]
	[FieldOffset(Offset = "0x30")]
	public string method;

	[Token(Token = "0x4000234")]
	[FieldOffset(Offset = "0x38")]
	public EaseType easeType;

	[Token(Token = "0x4000235")]
	[FieldOffset(Offset = "0x3C")]
	public float time;

	[Token(Token = "0x4000236")]
	[FieldOffset(Offset = "0x40")]
	public float delay;

	[Token(Token = "0x4000237")]
	[FieldOffset(Offset = "0x44")]
	public LoopType loopType;

	[Token(Token = "0x4000238")]
	[FieldOffset(Offset = "0x48")]
	public bool isRunning;

	[Token(Token = "0x4000239")]
	[FieldOffset(Offset = "0x49")]
	public bool isPaused;

	[Token(Token = "0x400023A")]
	[FieldOffset(Offset = "0x50")]
	public string _name;

	[Token(Token = "0x400023B")]
	[FieldOffset(Offset = "0x58")]
	private float runningTime;

	[Token(Token = "0x400023C")]
	[FieldOffset(Offset = "0x5C")]
	private float percentage;

	[Token(Token = "0x400023D")]
	[FieldOffset(Offset = "0x60")]
	private float delayStarted;

	[Token(Token = "0x400023E")]
	[FieldOffset(Offset = "0x64")]
	private bool kinematic;

	[Token(Token = "0x400023F")]
	[FieldOffset(Offset = "0x65")]
	private bool isLocal;

	[Token(Token = "0x4000240")]
	[FieldOffset(Offset = "0x66")]
	private bool loop;

	[Token(Token = "0x4000241")]
	[FieldOffset(Offset = "0x67")]
	private bool reverse;

	[Token(Token = "0x4000242")]
	[FieldOffset(Offset = "0x68")]
	private bool wasPaused;

	[Token(Token = "0x4000243")]
	[FieldOffset(Offset = "0x69")]
	private bool physics;

	[Token(Token = "0x4000244")]
	[FieldOffset(Offset = "0x70")]
	private Hashtable tweenArguments;

	[Token(Token = "0x4000245")]
	[FieldOffset(Offset = "0x78")]
	private Space space;

	[Token(Token = "0x4000246")]
	[FieldOffset(Offset = "0x80")]
	private EasingFunction ease;

	[Token(Token = "0x4000247")]
	[FieldOffset(Offset = "0x88")]
	private ApplyTween apply;

	[Token(Token = "0x4000248")]
	[FieldOffset(Offset = "0x90")]
	private AudioSource audioSource;

	[Token(Token = "0x4000249")]
	[FieldOffset(Offset = "0x98")]
	private Vector3[] vector3s;

	[Token(Token = "0x400024A")]
	[FieldOffset(Offset = "0xA0")]
	private Vector2[] vector2s;

	[Token(Token = "0x400024B")]
	[FieldOffset(Offset = "0xA8")]
	private Color[,] colors;

	[Token(Token = "0x400024C")]
	[FieldOffset(Offset = "0xB0")]
	private float[] floats;

	[Token(Token = "0x400024D")]
	[FieldOffset(Offset = "0xB8")]
	private Rect[] rects;

	[Token(Token = "0x400024E")]
	[FieldOffset(Offset = "0xC0")]
	private CRSpline path;

	[Token(Token = "0x400024F")]
	[FieldOffset(Offset = "0xC8")]
	private Vector3 preUpdate;

	[Token(Token = "0x4000250")]
	[FieldOffset(Offset = "0xD4")]
	private Vector3 postUpdate;

	[Token(Token = "0x4000251")]
	[FieldOffset(Offset = "0xE0")]
	private NamedValueColor namedcolorvalue;

	[Token(Token = "0x4000252")]
	[FieldOffset(Offset = "0xE4")]
	private float lastRealTime;

	[Token(Token = "0x4000253")]
	[FieldOffset(Offset = "0xE8")]
	private bool useRealTime;

	[Token(Token = "0x60001E6")]
	[Address(RVA = "0x6FF020", Offset = "0x6FDE20", Length = "0xAB")]
	public static void Init(GameObject target)
	{
	}

	[Token(Token = "0x60001E7")]
	[Address(RVA = "0x6FF0D0", Offset = "0x6FDED0", Length = "0x565")]
	public static void ValueTo(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x60001E8")]
	[Address(RVA = "0x6FF640", Offset = "0x6FE440", Length = "0x252")]
	public static void FadeFrom(GameObject target, float alpha, float time)
	{
	}

	[Token(Token = "0x60001E9")]
	[Address(RVA = "0x6FF8A0", Offset = "0x6FE6A0", Length = "0x5E")]
	public static void FadeFrom(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x60001EA")]
	[Address(RVA = "0x6FF900", Offset = "0x6FE700", Length = "0x252")]
	public static void FadeTo(GameObject target, float alpha, float time)
	{
	}

	[Token(Token = "0x60001EB")]
	[Address(RVA = "0x6FFB60", Offset = "0x6FE960", Length = "0x5E")]
	public static void FadeTo(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x60001EC")]
	[Address(RVA = "0x6FFBC0", Offset = "0x6FE9C0", Length = "0x222")]
	public static void ColorFrom(GameObject target, Color color, float time)
	{
	}

	[Token(Token = "0x60001ED")]
	[Address(RVA = "0x6FFDF0", Offset = "0x6FEBF0", Length = "0xFBB")]
	public static void ColorFrom(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x60001EE")]
	[Address(RVA = "0x700DB0", Offset = "0x6FFBB0", Length = "0x222")]
	public static void ColorTo(GameObject target, Color color, float time)
	{
	}

	[Token(Token = "0x60001EF")]
	[Address(RVA = "0x700FE0", Offset = "0x6FFDE0", Length = "0x5E6")]
	public static void ColorTo(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x60001F0")]
	[Address(RVA = "0x7015D0", Offset = "0x7003D0", Length = "0x2DA")]
	public static void AudioFrom(GameObject target, float volume, float pitch, float time)
	{
	}

	[Token(Token = "0x60001F1")]
	[Address(RVA = "0x7018B0", Offset = "0x7006B0", Length = "0x614")]
	public static void AudioFrom(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x60001F2")]
	[Address(RVA = "0x701ED0", Offset = "0x700CD0", Length = "0x2DA")]
	public static void AudioTo(GameObject target, float volume, float pitch, float time)
	{
	}

	[Token(Token = "0x60001F3")]
	[Address(RVA = "0x7021B0", Offset = "0x700FB0", Length = "0x18F")]
	public static void AudioTo(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x60001F4")]
	[Address(RVA = "0x702340", Offset = "0x701140", Length = "0x1F5")]
	public static void Stab(GameObject target, AudioClip audioclip, float delay)
	{
	}

	[Token(Token = "0x60001F5")]
	[Address(RVA = "0x702540", Offset = "0x701340", Length = "0xB9")]
	public static void Stab(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x60001F6")]
	[Address(RVA = "0x702600", Offset = "0x701400", Length = "0x22B")]
	public static void LookFrom(GameObject target, Vector3 looktarget, float time)
	{
	}

	[Token(Token = "0x60001F7")]
	[Address(RVA = "0x702830", Offset = "0x701630", Length = "0x9E2")]
	public static void LookFrom(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x60001F8")]
	[Address(RVA = "0x703220", Offset = "0x702020", Length = "0x22B")]
	public static void LookTo(GameObject target, Vector3 looktarget, float time)
	{
	}

	[Token(Token = "0x60001F9")]
	[Address(RVA = "0x703450", Offset = "0x702250", Length = "0x71D")]
	public static void LookTo(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x60001FA")]
	[Address(RVA = "0x703B70", Offset = "0x702970", Length = "0x22B")]
	public static void MoveTo(GameObject target, Vector3 position, float time)
	{
	}

	[Token(Token = "0x60001FB")]
	[Address(RVA = "0x703DA0", Offset = "0x702BA0", Length = "0x925")]
	public static void MoveTo(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x60001FC")]
	[Address(RVA = "0x7046D0", Offset = "0x7034D0", Length = "0x22B")]
	public static void MoveFrom(GameObject target, Vector3 position, float time)
	{
	}

	[Token(Token = "0x60001FD")]
	[Address(RVA = "0x704900", Offset = "0x703700", Length = "0x1438")]
	public static void MoveFrom(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x60001FE")]
	[Address(RVA = "0x705D40", Offset = "0x704B40", Length = "0x22B")]
	public static void MoveAdd(GameObject target, Vector3 amount, float time)
	{
	}

	[Token(Token = "0x60001FF")]
	[Address(RVA = "0x705F70", Offset = "0x704D70", Length = "0xFD")]
	public static void MoveAdd(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x6000200")]
	[Address(RVA = "0x706070", Offset = "0x704E70", Length = "0x22B")]
	public static void MoveBy(GameObject target, Vector3 amount, float time)
	{
	}

	[Token(Token = "0x6000201")]
	[Address(RVA = "0x7062A0", Offset = "0x7050A0", Length = "0xFD")]
	public static void MoveBy(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x6000202")]
	[Address(RVA = "0x7063A0", Offset = "0x7051A0", Length = "0x22B")]
	public static void ScaleTo(GameObject target, Vector3 scale, float time)
	{
	}

	[Token(Token = "0x6000203")]
	[Address(RVA = "0x7065D0", Offset = "0x7053D0", Length = "0x914")]
	public static void ScaleTo(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x6000204")]
	[Address(RVA = "0x706EF0", Offset = "0x705CF0", Length = "0x22B")]
	public static void ScaleFrom(GameObject target, Vector3 scale, float time)
	{
	}

	[Token(Token = "0x6000205")]
	[Address(RVA = "0x707120", Offset = "0x705F20", Length = "0x73E")]
	public static void ScaleFrom(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x6000206")]
	[Address(RVA = "0x707860", Offset = "0x706660", Length = "0x22B")]
	public static void ScaleAdd(GameObject target, Vector3 amount, float time)
	{
	}

	[Token(Token = "0x6000207")]
	[Address(RVA = "0x707A90", Offset = "0x706890", Length = "0xFD")]
	public static void ScaleAdd(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x6000208")]
	[Address(RVA = "0x707B90", Offset = "0x706990", Length = "0x22B")]
	public static void ScaleBy(GameObject target, Vector3 amount, float time)
	{
	}

	[Token(Token = "0x6000209")]
	[Address(RVA = "0x707DC0", Offset = "0x706BC0", Length = "0xFD")]
	public static void ScaleBy(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x600020A")]
	[Address(RVA = "0x707EC0", Offset = "0x706CC0", Length = "0x22B")]
	public static void RotateTo(GameObject target, Vector3 rotation, float time)
	{
	}

	[Token(Token = "0x600020B")]
	[Address(RVA = "0x7080F0", Offset = "0x706EF0", Length = "0x925")]
	public static void RotateTo(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x600020C")]
	[Address(RVA = "0x708A20", Offset = "0x707820", Length = "0x22B")]
	public static void RotateFrom(GameObject target, Vector3 rotation, float time)
	{
	}

	[Token(Token = "0x600020D")]
	[Address(RVA = "0x708C50", Offset = "0x707A50", Length = "0x718")]
	public static void RotateFrom(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x600020E")]
	[Address(RVA = "0x709370", Offset = "0x708170", Length = "0x22B")]
	public static void RotateAdd(GameObject target, Vector3 amount, float time)
	{
	}

	[Token(Token = "0x600020F")]
	[Address(RVA = "0x7095A0", Offset = "0x7083A0", Length = "0xFD")]
	public static void RotateAdd(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x6000210")]
	[Address(RVA = "0x7096A0", Offset = "0x7084A0", Length = "0x22B")]
	public static void RotateBy(GameObject target, Vector3 amount, float time)
	{
	}

	[Token(Token = "0x6000211")]
	[Address(RVA = "0x7098D0", Offset = "0x7086D0", Length = "0xFD")]
	public static void RotateBy(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x6000212")]
	[Address(RVA = "0x7099D0", Offset = "0x7087D0", Length = "0x22B")]
	public static void ShakePosition(GameObject target, Vector3 amount, float time)
	{
	}

	[Token(Token = "0x6000213")]
	[Address(RVA = "0x709C00", Offset = "0x708A00", Length = "0xFD")]
	public static void ShakePosition(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x6000214")]
	[Address(RVA = "0x709D00", Offset = "0x708B00", Length = "0x22B")]
	public static void ShakeScale(GameObject target, Vector3 amount, float time)
	{
	}

	[Token(Token = "0x6000215")]
	[Address(RVA = "0x709F30", Offset = "0x708D30", Length = "0xFD")]
	public static void ShakeScale(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x6000216")]
	[Address(RVA = "0x70A030", Offset = "0x708E30", Length = "0x22B")]
	public static void ShakeRotation(GameObject target, Vector3 amount, float time)
	{
	}

	[Token(Token = "0x6000217")]
	[Address(RVA = "0x70A260", Offset = "0x709060", Length = "0xFD")]
	public static void ShakeRotation(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x6000218")]
	[Address(RVA = "0x70A360", Offset = "0x709160", Length = "0x22B")]
	public static void PunchPosition(GameObject target, Vector3 amount, float time)
	{
	}

	[Token(Token = "0x6000219")]
	[Address(RVA = "0x70A590", Offset = "0x709390", Length = "0x15A")]
	public static void PunchPosition(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x600021A")]
	[Address(RVA = "0x70A6F0", Offset = "0x7094F0", Length = "0x22B")]
	public static void PunchRotation(GameObject target, Vector3 amount, float time)
	{
	}

	[Token(Token = "0x600021B")]
	[Address(RVA = "0x70A920", Offset = "0x709720", Length = "0x15A")]
	public static void PunchRotation(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x600021C")]
	[Address(RVA = "0x70AA80", Offset = "0x709880", Length = "0x22B")]
	public static void PunchScale(GameObject target, Vector3 amount, float time)
	{
	}

	[Token(Token = "0x600021D")]
	[Address(RVA = "0x70ACB0", Offset = "0x709AB0", Length = "0x15A")]
	public static void PunchScale(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x600021E")]
	[Address(RVA = "0x70AE10", Offset = "0x709C10", Length = "0xFD9")]
	private void GenerateTargets()
	{
	}

	[Token(Token = "0x600021F")]
	[Address(RVA = "0x70BDF0", Offset = "0x70ABF0", Length = "0x1C4")]
	private void GenerateRectTargets()
	{
	}

	[Token(Token = "0x6000220")]
	[Address(RVA = "0x70BFC0", Offset = "0x70ADC0", Length = "0x1EA")]
	private void GenerateColorTargets()
	{
	}

	[Token(Token = "0x6000221")]
	[Address(RVA = "0x70C1B0", Offset = "0x70AFB0", Length = "0x39C")]
	private void GenerateVector3Targets()
	{
	}

	[Token(Token = "0x6000222")]
	[Address(RVA = "0x70C550", Offset = "0x70B350", Length = "0x37E")]
	private void GenerateVector2Targets()
	{
	}

	[Token(Token = "0x6000223")]
	[Address(RVA = "0x70C8D0", Offset = "0x70B6D0", Length = "0x2C2")]
	private void GenerateFloatTargets()
	{
	}

	[Token(Token = "0x6000224")]
	[Address(RVA = "0x70CBA0", Offset = "0x70B9A0", Length = "0x11AD")]
	private void GenerateColorToTargets()
	{
	}

	[Token(Token = "0x6000225")]
	[Address(RVA = "0x70DD50", Offset = "0x70CB50", Length = "0x619")]
	private void GenerateAudioToTargets()
	{
	}

	[Token(Token = "0x6000226")]
	[Address(RVA = "0x70E370", Offset = "0x70D170", Length = "0x6B5")]
	private void GenerateStabTargets()
	{
	}

	[Token(Token = "0x6000227")]
	[Address(RVA = "0x70EA30", Offset = "0x70D830", Length = "0xE19")]
	private void GenerateLookToTargets()
	{
	}

	[Token(Token = "0x6000228")]
	[Address(RVA = "0x70F850", Offset = "0x70E650", Length = "0x10D8")]
	private void GenerateMoveToPathTargets()
	{
	}

	[Token(Token = "0x6000229")]
	[Address(RVA = "0x710930", Offset = "0x70F730", Length = "0xA9E")]
	private void GenerateMoveToTargets()
	{
	}

	[Token(Token = "0x600022A")]
	[Address(RVA = "0x7113D0", Offset = "0x7101D0", Length = "0xA1C")]
	private void GenerateMoveByTargets()
	{
	}

	[Token(Token = "0x600022B")]
	[Address(RVA = "0x711DF0", Offset = "0x710BF0", Length = "0x8CF")]
	private void GenerateScaleToTargets()
	{
	}

	[Token(Token = "0x600022C")]
	[Address(RVA = "0x7126C0", Offset = "0x7114C0", Length = "0x6B0")]
	private void GenerateScaleByTargets()
	{
	}

	[Token(Token = "0x600022D")]
	[Address(RVA = "0x712D80", Offset = "0x711B80", Length = "0x6A2")]
	private void GenerateScaleAddTargets()
	{
	}

	[Token(Token = "0x600022E")]
	[Address(RVA = "0x713430", Offset = "0x712230", Length = "0xA1A")]
	private void GenerateRotateToTargets()
	{
	}

	[Token(Token = "0x600022F")]
	[Address(RVA = "0x713E50", Offset = "0x712C50", Length = "0x639")]
	private void GenerateRotateAddTargets()
	{
	}

	[Token(Token = "0x6000230")]
	[Address(RVA = "0x714490", Offset = "0x713290", Length = "0x674")]
	private void GenerateRotateByTargets()
	{
	}

	[Token(Token = "0x6000231")]
	[Address(RVA = "0x714B10", Offset = "0x713910", Length = "0x496")]
	private void GenerateShakePositionTargets()
	{
	}

	[Token(Token = "0x6000232")]
	[Address(RVA = "0x714FB0", Offset = "0x713DB0", Length = "0x458")]
	private void GenerateShakeScaleTargets()
	{
	}

	[Token(Token = "0x6000233")]
	[Address(RVA = "0x715410", Offset = "0x714210", Length = "0x3C5")]
	private void GenerateShakeRotationTargets()
	{
	}

	[Token(Token = "0x6000234")]
	[Address(RVA = "0x7157E0", Offset = "0x7145E0", Length = "0x4FF")]
	private void GeneratePunchPositionTargets()
	{
	}

	[Token(Token = "0x6000235")]
	[Address(RVA = "0x715CE0", Offset = "0x714AE0", Length = "0x42E")]
	private void GeneratePunchRotationTargets()
	{
	}

	[Token(Token = "0x6000236")]
	[Address(RVA = "0x716110", Offset = "0x714F10", Length = "0x4AC")]
	private void GeneratePunchScaleTargets()
	{
	}

	[Token(Token = "0x6000237")]
	[Address(RVA = "0x7165C0", Offset = "0x7153C0", Length = "0x2AB")]
	private void ApplyRectTargets()
	{
	}

	[Token(Token = "0x6000238")]
	[Address(RVA = "0x716870", Offset = "0x715670", Length = "0x33D")]
	private void ApplyColorTargets()
	{
	}

	[Token(Token = "0x6000239")]
	[Address(RVA = "0x716BB0", Offset = "0x7159B0", Length = "0x258")]
	private void ApplyVector3Targets()
	{
	}

	[Token(Token = "0x600023A")]
	[Address(RVA = "0x716E10", Offset = "0x715C10", Length = "0x1E5")]
	private void ApplyVector2Targets()
	{
	}

	[Token(Token = "0x600023B")]
	[Address(RVA = "0x717000", Offset = "0x715E00", Length = "0x16F")]
	private void ApplyFloatTargets()
	{
	}

	[Token(Token = "0x600023C")]
	[Address(RVA = "0x717170", Offset = "0x715F70", Length = "0xC28")]
	private void ApplyColorToTargets()
	{
	}

	[Token(Token = "0x600023D")]
	[Address(RVA = "0x717DA0", Offset = "0x716BA0", Length = "0x1BD")]
	private void ApplyAudioToTargets()
	{
	}

	[Token(Token = "0x600023E")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	private void ApplyStabTargets()
	{
	}

	[Token(Token = "0x600023F")]
	[Address(RVA = "0x717F60", Offset = "0x716D60", Length = "0x862")]
	private void ApplyMoveToPathTargets()
	{
	}

	[Token(Token = "0x6000240")]
	[Address(RVA = "0x7187D0", Offset = "0x7175D0", Length = "0x85D")]
	private void ApplyMoveToTargets()
	{
	}

	[Token(Token = "0x6000241")]
	[Address(RVA = "0x719030", Offset = "0x717E30", Length = "0x739")]
	private void ApplyMoveByTargets()
	{
	}

	[Token(Token = "0x6000242")]
	[Address(RVA = "0x719770", Offset = "0x718570", Length = "0x2F0")]
	private void ApplyScaleToTargets()
	{
	}

	[Token(Token = "0x6000243")]
	[Address(RVA = "0x719A70", Offset = "0x718870", Length = "0x40D")]
	private void ApplyLookToTargets()
	{
	}

	[Token(Token = "0x6000244")]
	[Address(RVA = "0x719E80", Offset = "0x718C80", Length = "0x9C5")]
	private void ApplyRotateToTargets()
	{
	}

	[Token(Token = "0x6000245")]
	[Address(RVA = "0x71A850", Offset = "0x719650", Length = "0x526")]
	private void ApplyRotateAddTargets()
	{
	}

	[Token(Token = "0x6000246")]
	[Address(RVA = "0x71AD80", Offset = "0x719B80", Length = "0xBF4")]
	private void ApplyShakePositionTargets()
	{
	}

	[Token(Token = "0x6000247")]
	[Address(RVA = "0x71B980", Offset = "0x71A780", Length = "0x457")]
	private void ApplyShakeScaleTargets()
	{
	}

	[Token(Token = "0x6000248")]
	[Address(RVA = "0x71BDE0", Offset = "0x71ABE0", Length = "0x521")]
	private void ApplyShakeRotationTargets()
	{
	}

	[Token(Token = "0x6000249")]
	[Address(RVA = "0x71C310", Offset = "0x71B110", Length = "0x7EA")]
	private void ApplyPunchPositionTargets()
	{
	}

	[Token(Token = "0x600024A")]
	[Address(RVA = "0x71CB00", Offset = "0x71B900", Length = "0x5D0")]
	private void ApplyPunchRotationTargets()
	{
	}

	[Token(Token = "0x600024B")]
	[Address(RVA = "0x71D0E0", Offset = "0x71BEE0", Length = "0x30E")]
	private void ApplyPunchScaleTargets()
	{
	}

	[IteratorStateMachine(typeof(_003CTweenDelay_003Ed__144))]
	[Token(Token = "0x600024C")]
	[Address(RVA = "0x71D3F0", Offset = "0x71C1F0", Length = "0x9A")]
	private IEnumerator TweenDelay()
	{
		return null;
	}

	[Token(Token = "0x600024D")]
	[Address(RVA = "0x71D490", Offset = "0x71C290", Length = "0x164")]
	private void TweenStart()
	{
	}

	[IteratorStateMachine(typeof(_003CTweenRestart_003Ed__146))]
	[Token(Token = "0x600024E")]
	[Address(RVA = "0x71D600", Offset = "0x71C400", Length = "0x9A")]
	private IEnumerator TweenRestart()
	{
		return null;
	}

	[Token(Token = "0x600024F")]
	[Address(RVA = "0x71D6A0", Offset = "0x71C4A0", Length = "0x18B")]
	private void TweenUpdate()
	{
	}

	[Token(Token = "0x6000250")]
	[Address(RVA = "0x71D830", Offset = "0x71C630", Length = "0x176")]
	private void TweenComplete()
	{
	}

	[Token(Token = "0x6000251")]
	[Address(RVA = "0x71D9B0", Offset = "0x71C7B0", Length = "0x87")]
	private void TweenLoop()
	{
	}

	[Token(Token = "0x6000252")]
	[Address(RVA = "0x71DA40", Offset = "0x71C840", Length = "0x105")]
	public static Rect RectUpdate(Rect currentValue, Rect targetValue, float speed)
	{
		return default(Rect);
	}

	[Token(Token = "0x6000253")]
	[Address(RVA = "0x71DB50", Offset = "0x71C950", Length = "0x10C")]
	public static Vector3 Vector3Update(Vector3 currentValue, Vector3 targetValue, float speed)
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000254")]
	[Address(RVA = "0x71DC60", Offset = "0x71CA60", Length = "0xC6")]
	public static Vector2 Vector2Update(Vector2 currentValue, Vector2 targetValue, float speed)
	{
		return default(Vector2);
	}

	[Token(Token = "0x6000255")]
	[Address(RVA = "0x71DD30", Offset = "0x71CB30", Length = "0x80")]
	public static float FloatUpdate(float currentValue, float targetValue, float speed)
	{
		return 0f;
	}

	[Token(Token = "0x6000256")]
	[Address(RVA = "0x71DDC0", Offset = "0x71CBC0", Length = "0xC5")]
	public static void FadeUpdate(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x6000257")]
	[Address(RVA = "0x71DE90", Offset = "0x71CC90", Length = "0x219")]
	public static void FadeUpdate(GameObject target, float alpha, float time)
	{
	}

	[Token(Token = "0x6000258")]
	[Address(RVA = "0x71E0B0", Offset = "0x71CEB0", Length = "0xEC8")]
	public static void ColorUpdate(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x6000259")]
	[Address(RVA = "0x71EF80", Offset = "0x71DD80", Length = "0x222")]
	public static void ColorUpdate(GameObject target, Color color, float time)
	{
	}

	[Token(Token = "0x600025A")]
	[Address(RVA = "0x71F1B0", Offset = "0x71DFB0", Length = "0x64B")]
	public static void AudioUpdate(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x600025B")]
	[Address(RVA = "0x71F800", Offset = "0x71E600", Length = "0x2DA")]
	public static void AudioUpdate(GameObject target, float volume, float pitch, float time)
	{
	}

	[Token(Token = "0x600025C")]
	[Address(RVA = "0x71FAE0", Offset = "0x71E8E0", Length = "0xA90")]
	public static void RotateUpdate(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x600025D")]
	[Address(RVA = "0x720580", Offset = "0x71F380", Length = "0x22B")]
	public static void RotateUpdate(GameObject target, Vector3 rotation, float time)
	{
	}

	[Token(Token = "0x600025E")]
	[Address(RVA = "0x7207B0", Offset = "0x71F5B0", Length = "0x8B2")]
	public static void ScaleUpdate(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x600025F")]
	[Address(RVA = "0x721070", Offset = "0x71FE70", Length = "0x22B")]
	public static void ScaleUpdate(GameObject target, Vector3 scale, float time)
	{
	}

	[Token(Token = "0x6000260")]
	[Address(RVA = "0x7212A0", Offset = "0x7200A0", Length = "0x101B")]
	public static void MoveUpdate(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x6000261")]
	[Address(RVA = "0x7222C0", Offset = "0x7210C0", Length = "0x22B")]
	public static void MoveUpdate(GameObject target, Vector3 position, float time)
	{
	}

	[Token(Token = "0x6000262")]
	[Address(RVA = "0x7224F0", Offset = "0x7212F0", Length = "0xCEF")]
	public static void LookUpdate(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x6000263")]
	[Address(RVA = "0x7231E0", Offset = "0x721FE0", Length = "0x22B")]
	public static void LookUpdate(GameObject target, Vector3 looktarget, float time)
	{
	}

	[Token(Token = "0x6000264")]
	[Address(RVA = "0x723410", Offset = "0x722210", Length = "0x391")]
	public static float PathLength(Transform[] path)
	{
		return 0f;
	}

	[Token(Token = "0x6000265")]
	[Address(RVA = "0x7237B0", Offset = "0x7225B0", Length = "0x251")]
	public static float PathLength(Vector3[] path)
	{
		return 0f;
	}

	[Token(Token = "0x6000266")]
	[Address(RVA = "0x723A10", Offset = "0x722810", Length = "0x2B6")]
	public static Texture2D CameraTexture(Color color)
	{
		return null;
	}

	[Token(Token = "0x6000267")]
	[Address(RVA = "0x723CD0", Offset = "0x722AD0", Length = "0x130")]
	public static void PutOnPath(GameObject target, Vector3[] path, float percent)
	{
	}

	[Token(Token = "0x6000268")]
	[Address(RVA = "0x723E10", Offset = "0x722C10", Length = "0x110")]
	public static void PutOnPath(Transform target, Vector3[] path, float percent)
	{
	}

	[Token(Token = "0x6000269")]
	[Address(RVA = "0x723F30", Offset = "0x722D30", Length = "0x32B")]
	public static void PutOnPath(GameObject target, Transform[] path, float percent)
	{
	}

	[Token(Token = "0x600026A")]
	[Address(RVA = "0x724260", Offset = "0x723060", Length = "0x27E")]
	public static void PutOnPath(Transform target, Transform[] path, float percent)
	{
	}

	[Token(Token = "0x600026B")]
	[Address(RVA = "0x7244E0", Offset = "0x7232E0", Length = "0x1F1")]
	public static Vector3 PointOnPath(Transform[] path, float percent)
	{
		return default(Vector3);
	}

	[Token(Token = "0x600026C")]
	[Address(RVA = "0x7246E0", Offset = "0x7234E0", Length = "0xC9")]
	public static void DrawLine(Vector3[] line)
	{
	}

	[Token(Token = "0x600026D")]
	[Address(RVA = "0x7247B0", Offset = "0x7235B0", Length = "0x92")]
	public static void DrawLine(Vector3[] line, Color color)
	{
	}

	[Token(Token = "0x600026E")]
	[Address(RVA = "0x724850", Offset = "0x723650", Length = "0x21B")]
	public static void DrawLine(Transform[] line)
	{
	}

	[Token(Token = "0x600026F")]
	[Address(RVA = "0x724A70", Offset = "0x723870", Length = "0x1DB")]
	public static void DrawLine(Transform[] line, Color color)
	{
	}

	[Token(Token = "0x6000270")]
	[Address(RVA = "0x724C50", Offset = "0x723A50", Length = "0xC9")]
	public static void DrawLineGizmos(Vector3[] line)
	{
	}

	[Token(Token = "0x6000271")]
	[Address(RVA = "0x724D20", Offset = "0x723B20", Length = "0x92")]
	public static void DrawLineGizmos(Vector3[] line, Color color)
	{
	}

	[Token(Token = "0x6000272")]
	[Address(RVA = "0x724DC0", Offset = "0x723BC0", Length = "0x21B")]
	public static void DrawLineGizmos(Transform[] line)
	{
	}

	[Token(Token = "0x6000273")]
	[Address(RVA = "0x724FE0", Offset = "0x723DE0", Length = "0x1DB")]
	public static void DrawLineGizmos(Transform[] line, Color color)
	{
	}

	[Token(Token = "0x6000274")]
	[Address(RVA = "0x7251C0", Offset = "0x723FC0", Length = "0xC9")]
	public static void DrawLineHandles(Vector3[] line)
	{
	}

	[Token(Token = "0x6000275")]
	[Address(RVA = "0x725290", Offset = "0x724090", Length = "0x92")]
	public static void DrawLineHandles(Vector3[] line, Color color)
	{
	}

	[Token(Token = "0x6000276")]
	[Address(RVA = "0x725330", Offset = "0x724130", Length = "0x21B")]
	public static void DrawLineHandles(Transform[] line)
	{
	}

	[Token(Token = "0x6000277")]
	[Address(RVA = "0x725550", Offset = "0x724350", Length = "0x1DB")]
	public static void DrawLineHandles(Transform[] line, Color color)
	{
	}

	[Token(Token = "0x6000278")]
	[Address(RVA = "0x725730", Offset = "0x724530", Length = "0x8C")]
	public static Vector3 PointOnPath(Vector3[] path, float percent)
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000279")]
	[Address(RVA = "0x7257C0", Offset = "0x7245C0", Length = "0xC9")]
	public static void DrawPath(Vector3[] path)
	{
	}

	[Token(Token = "0x600027A")]
	[Address(RVA = "0x725890", Offset = "0x724690", Length = "0x92")]
	public static void DrawPath(Vector3[] path, Color color)
	{
	}

	[Token(Token = "0x600027B")]
	[Address(RVA = "0x725930", Offset = "0x724730", Length = "0x21B")]
	public static void DrawPath(Transform[] path)
	{
	}

	[Token(Token = "0x600027C")]
	[Address(RVA = "0x725B50", Offset = "0x724950", Length = "0x1DB")]
	public static void DrawPath(Transform[] path, Color color)
	{
	}

	[Token(Token = "0x600027D")]
	[Address(RVA = "0x725D30", Offset = "0x724B30", Length = "0xC9")]
	public static void DrawPathGizmos(Vector3[] path)
	{
	}

	[Token(Token = "0x600027E")]
	[Address(RVA = "0x725E00", Offset = "0x724C00", Length = "0x92")]
	public static void DrawPathGizmos(Vector3[] path, Color color)
	{
	}

	[Token(Token = "0x600027F")]
	[Address(RVA = "0x725EA0", Offset = "0x724CA0", Length = "0x21B")]
	public static void DrawPathGizmos(Transform[] path)
	{
	}

	[Token(Token = "0x6000280")]
	[Address(RVA = "0x7260C0", Offset = "0x724EC0", Length = "0x1DB")]
	public static void DrawPathGizmos(Transform[] path, Color color)
	{
	}

	[Token(Token = "0x6000281")]
	[Address(RVA = "0x7262A0", Offset = "0x7250A0", Length = "0xC9")]
	public static void DrawPathHandles(Vector3[] path)
	{
	}

	[Token(Token = "0x6000282")]
	[Address(RVA = "0x726370", Offset = "0x725170", Length = "0x92")]
	public static void DrawPathHandles(Vector3[] path, Color color)
	{
	}

	[Token(Token = "0x6000283")]
	[Address(RVA = "0x726410", Offset = "0x725210", Length = "0x21B")]
	public static void DrawPathHandles(Transform[] path)
	{
	}

	[Token(Token = "0x6000284")]
	[Address(RVA = "0x726630", Offset = "0x725430", Length = "0x1DB")]
	public static void DrawPathHandles(Transform[] path, Color color)
	{
	}

	[Token(Token = "0x6000285")]
	[Address(RVA = "0x726810", Offset = "0x725610", Length = "0x1BC")]
	public static void Resume(GameObject target)
	{
	}

	[Token(Token = "0x6000286")]
	[Address(RVA = "0x7269D0", Offset = "0x7257D0", Length = "0x290")]
	public static void Resume(GameObject target, bool includechildren)
	{
	}

	[Token(Token = "0x6000287")]
	[Address(RVA = "0x726C70", Offset = "0x725A70", Length = "0x2D6")]
	public static void Resume(GameObject target, string type)
	{
	}

	[Token(Token = "0x6000288")]
	[Address(RVA = "0x726F50", Offset = "0x725D50", Length = "0x62F")]
	public static void Resume(GameObject target, string type, bool includechildren)
	{
	}

	[Token(Token = "0x6000289")]
	[Address(RVA = "0x727580", Offset = "0x726380", Length = "0x19E")]
	public static void Resume()
	{
	}

	[Token(Token = "0x600028A")]
	[Address(RVA = "0x727720", Offset = "0x726520", Length = "0x2C4")]
	public static void Resume(string type)
	{
	}

	[Token(Token = "0x600028B")]
	[Address(RVA = "0x7279F0", Offset = "0x7267F0", Length = "0x21B")]
	public static void Pause(GameObject target)
	{
	}

	[Token(Token = "0x600028C")]
	[Address(RVA = "0x727C10", Offset = "0x726A10", Length = "0x290")]
	public static void Pause(GameObject target, bool includechildren)
	{
	}

	[Token(Token = "0x600028D")]
	[Address(RVA = "0x727EB0", Offset = "0x726CB0", Length = "0x32D")]
	public static void Pause(GameObject target, string type)
	{
	}

	[Token(Token = "0x600028E")]
	[Address(RVA = "0x7281E0", Offset = "0x726FE0", Length = "0x6A0")]
	public static void Pause(GameObject target, string type, bool includechildren)
	{
	}

	[Token(Token = "0x600028F")]
	[Address(RVA = "0x728890", Offset = "0x727690", Length = "0x19E")]
	public static void Pause()
	{
	}

	[Token(Token = "0x6000290")]
	[Address(RVA = "0x728A30", Offset = "0x727830", Length = "0x2C4")]
	public static void Pause(string type)
	{
	}

	[Token(Token = "0x6000291")]
	[Address(RVA = "0x728D00", Offset = "0x727B00", Length = "0x70")]
	public static int Count()
	{
		return 0;
	}

	[Token(Token = "0x6000292")]
	[Address(RVA = "0x728D80", Offset = "0x727B80", Length = "0x32B")]
	public static int Count(string type)
	{
		return 0;
	}

	[Token(Token = "0x6000293")]
	[Address(RVA = "0x7290B0", Offset = "0x727EB0", Length = "0xA6")]
	public static int Count(GameObject target)
	{
		return 0;
	}

	[Token(Token = "0x6000294")]
	[Address(RVA = "0x729160", Offset = "0x727F60", Length = "0x27C")]
	public static int Count(GameObject target, string type)
	{
		return 0;
	}

	[Token(Token = "0x6000295")]
	[Address(RVA = "0x7293E0", Offset = "0x7281E0", Length = "0x1DC")]
	public static void Stop()
	{
	}

	[Token(Token = "0x6000296")]
	[Address(RVA = "0x7295C0", Offset = "0x7283C0", Length = "0x2C4")]
	public static void Stop(string type)
	{
	}

	[Token(Token = "0x6000297")]
	[Address(RVA = "0x729890", Offset = "0x728690", Length = "0x2C4")]
	public static void StopByName(string name)
	{
	}

	[Token(Token = "0x6000298")]
	[Address(RVA = "0x729B60", Offset = "0x728960", Length = "0x127")]
	public static void Stop(GameObject target)
	{
	}

	[Token(Token = "0x6000299")]
	[Address(RVA = "0x729C90", Offset = "0x728A90", Length = "0x290")]
	public static void Stop(GameObject target, bool includechildren)
	{
	}

	[Token(Token = "0x600029A")]
	[Address(RVA = "0x729F30", Offset = "0x728D30", Length = "0x28A")]
	public static void Stop(GameObject target, string type)
	{
	}

	[Token(Token = "0x600029B")]
	[Address(RVA = "0x72A1C0", Offset = "0x728FC0", Length = "0x224")]
	public static void StopByName(GameObject target, string name)
	{
	}

	[Token(Token = "0x600029C")]
	[Address(RVA = "0x72A3F0", Offset = "0x7291F0", Length = "0x5B9")]
	public static void Stop(GameObject target, string type, bool includechildren)
	{
	}

	[Token(Token = "0x600029D")]
	[Address(RVA = "0x72A9B0", Offset = "0x7297B0", Length = "0x559")]
	public static void StopByName(GameObject target, string name, bool includechildren)
	{
	}

	[Token(Token = "0x600029E")]
	[Address(RVA = "0x72AF10", Offset = "0x729D10", Length = "0x12D")]
	public static Hashtable Hash(params object[] args)
	{
		return null;
	}

	[Token(Token = "0x600029F")]
	[Address(RVA = "0x72B040", Offset = "0x729E40", Length = "0x5A")]
	private void Awake()
	{
	}

	[IteratorStateMachine(typeof(_003CStart_003Ed__228))]
	[Token(Token = "0x60002A0")]
	[Address(RVA = "0x72B0A0", Offset = "0x729EA0", Length = "0x9A")]
	private IEnumerator Start()
	{
		return null;
	}

	[Token(Token = "0x60002A1")]
	[Address(RVA = "0x72B140", Offset = "0x729F40", Length = "0x42")]
	private void Update()
	{
	}

	[Token(Token = "0x60002A2")]
	[Address(RVA = "0x72B190", Offset = "0x729F90", Length = "0x42")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x60002A3")]
	[Address(RVA = "0x72B1E0", Offset = "0x729FE0", Length = "0x1A3")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x60002A4")]
	[Address(RVA = "0x72B390", Offset = "0x72A190", Length = "0x62")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x60002A5")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x60002A6")]
	[Address(RVA = "0x72B400", Offset = "0x72A200", Length = "0x298")]
	private static void DrawLineHelper(Vector3[] line, Color color, string method)
	{
	}

	[Token(Token = "0x60002A7")]
	[Address(RVA = "0x72B6A0", Offset = "0x72A4A0", Length = "0x350")]
	private static void DrawPathHelper(Vector3[] path, Color color, string method)
	{
	}

	[Token(Token = "0x60002A8")]
	[Address(RVA = "0x72BA00", Offset = "0x72A800", Length = "0x476")]
	private static Vector3[] PathControlPointGenerator(Vector3[] path)
	{
		return null;
	}

	[Token(Token = "0x60002A9")]
	[Address(RVA = "0x72BE80", Offset = "0x72AC80", Length = "0x3FE")]
	private static Vector3 Interp(Vector3[] pts, float t)
	{
		return default(Vector3);
	}

	[Token(Token = "0x60002AA")]
	[Address(RVA = "0x72C280", Offset = "0x72B080", Length = "0x16C")]
	private static void Launch(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x60002AB")]
	[Address(RVA = "0x72C3F0", Offset = "0x72B1F0", Length = "0xA7B")]
	private static Hashtable CleanArgs(Hashtable args)
	{
		return null;
	}

	[Token(Token = "0x60002AC")]
	[Address(RVA = "0x72CE70", Offset = "0x72BC70", Length = "0x3DE")]
	private static string GenerateID()
	{
		return null;
	}

	[Token(Token = "0x60002AD")]
	[Address(RVA = "0x72D250", Offset = "0x72C050", Length = "0x162D")]
	private void RetrieveArgs()
	{
	}

	[Token(Token = "0x60002AE")]
	[Address(RVA = "0x72E880", Offset = "0x72D680", Length = "0x588")]
	private void GetEasingFunction()
	{
	}

	[Token(Token = "0x60002AF")]
	[Address(RVA = "0x72EE90", Offset = "0x72DC90", Length = "0x137")]
	private void UpdatePercentage()
	{
	}

	[Token(Token = "0x60002B0")]
	[Address(RVA = "0x72EFD0", Offset = "0x72DDD0", Length = "0x48F")]
	private void CallBack(string callbackType)
	{
	}

	[Token(Token = "0x60002B1")]
	[Address(RVA = "0x72F460", Offset = "0x72E260", Length = "0x275")]
	private void Dispose()
	{
	}

	[Token(Token = "0x60002B2")]
	[Address(RVA = "0x72F6E0", Offset = "0x72E4E0", Length = "0x60C")]
	private void ConflictCheck()
	{
	}

	[Token(Token = "0x60002B3")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	private void EnableKinematic()
	{
	}

	[Token(Token = "0x60002B4")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	private void DisableKinematic()
	{
	}

	[Token(Token = "0x60002B5")]
	[Address(RVA = "0x72FCF0", Offset = "0x72EAF0", Length = "0x41")]
	private void ResumeDelay()
	{
	}

	[Token(Token = "0x60002B6")]
	[Address(RVA = "0x72FD40", Offset = "0x72EB40", Length = "0x3B")]
	private float linear(float start, float end, float value)
	{
		return 0f;
	}

	[Token(Token = "0x60002B7")]
	[Address(RVA = "0x72FD80", Offset = "0x72EB80", Length = "0x69")]
	private float clerp(float start, float end, float value)
	{
		return 0f;
	}

	[Token(Token = "0x60002B8")]
	[Address(RVA = "0x72FDF0", Offset = "0x72EBF0", Length = "0xFB")]
	private float spring(float start, float end, float value)
	{
		return 0f;
	}

	[Token(Token = "0x60002B9")]
	[Address(RVA = "0x72FEF0", Offset = "0x72ECF0", Length = "0x14")]
	private float easeInQuad(float start, float end, float value)
	{
		return 0f;
	}

	[Token(Token = "0x60002BA")]
	[Address(RVA = "0x72FF10", Offset = "0x72ED10", Length = "0x23")]
	private float easeOutQuad(float start, float end, float value)
	{
		return 0f;
	}

	[Token(Token = "0x60002BB")]
	[Address(RVA = "0x72FF40", Offset = "0x72ED40", Length = "0x60")]
	private float easeInOutQuad(float start, float end, float value)
	{
		return 0f;
	}

	[Token(Token = "0x60002BC")]
	[Address(RVA = "0x72FFA0", Offset = "0x72EDA0", Length = "0x18")]
	private float easeInCubic(float start, float end, float value)
	{
		return 0f;
	}

	[Token(Token = "0x60002BD")]
	[Address(RVA = "0x72FFC0", Offset = "0x72EDC0", Length = "0x28")]
	private float easeOutCubic(float start, float end, float value)
	{
		return 0f;
	}

	[Token(Token = "0x60002BE")]
	[Address(RVA = "0x72FFF0", Offset = "0x72EDF0", Length = "0x55")]
	private float easeInOutCubic(float start, float end, float value)
	{
		return 0f;
	}

	[Token(Token = "0x60002BF")]
	[Address(RVA = "0x730050", Offset = "0x72EE50", Length = "0x1C")]
	private float easeInQuart(float start, float end, float value)
	{
		return 0f;
	}

	[Token(Token = "0x60002C0")]
	[Address(RVA = "0x730070", Offset = "0x72EE70", Length = "0x33")]
	private float easeOutQuart(float start, float end, float value)
	{
		return 0f;
	}

	[Token(Token = "0x60002C1")]
	[Address(RVA = "0x7300B0", Offset = "0x72EEB0", Length = "0x6C")]
	private float easeInOutQuart(float start, float end, float value)
	{
		return 0f;
	}

	[Token(Token = "0x60002C2")]
	[Address(RVA = "0x730120", Offset = "0x72EF20", Length = "0x20")]
	private float easeInQuint(float start, float end, float value)
	{
		return 0f;
	}

	[Token(Token = "0x60002C3")]
	[Address(RVA = "0x730140", Offset = "0x72EF40", Length = "0x30")]
	private float easeOutQuint(float start, float end, float value)
	{
		return 0f;
	}

	[Token(Token = "0x60002C4")]
	[Address(RVA = "0x730170", Offset = "0x72EF70", Length = "0x65")]
	private float easeInOutQuint(float start, float end, float value)
	{
		return 0f;
	}

	[Token(Token = "0x60002C5")]
	[Address(RVA = "0x7301E0", Offset = "0x72EFE0", Length = "0x4D")]
	private float easeInSine(float start, float end, float value)
	{
		return 0f;
	}

	[Token(Token = "0x60002C6")]
	[Address(RVA = "0x730230", Offset = "0x72F030", Length = "0x3F")]
	private float easeOutSine(float start, float end, float value)
	{
		return 0f;
	}

	[Token(Token = "0x60002C7")]
	[Address(RVA = "0x730270", Offset = "0x72F070", Length = "0x56")]
	private float easeInOutSine(float start, float end, float value)
	{
		return 0f;
	}

	[Token(Token = "0x60002C8")]
	[Address(RVA = "0x7302D0", Offset = "0x72F0D0", Length = "0x4F")]
	private float easeInExpo(float start, float end, float value)
	{
		return 0f;
	}

	[Token(Token = "0x60002C9")]
	[Address(RVA = "0x730320", Offset = "0x72F120", Length = "0x56")]
	private float easeOutExpo(float start, float end, float value)
	{
		return 0f;
	}

	[Token(Token = "0x60002CA")]
	[Address(RVA = "0x730380", Offset = "0x72F180", Length = "0x87")]
	private float easeInOutExpo(float start, float end, float value)
	{
		return 0f;
	}

	[Token(Token = "0x60002CB")]
	[Address(RVA = "0x730410", Offset = "0x72F210", Length = "0x67")]
	private float easeInCirc(float start, float end, float value)
	{
		return 0f;
	}

	[Token(Token = "0x60002CC")]
	[Address(RVA = "0x730480", Offset = "0x72F280", Length = "0x60")]
	private float easeOutCirc(float start, float end, float value)
	{
		return 0f;
	}

	[Token(Token = "0x60002CD")]
	[Address(RVA = "0x7304E0", Offset = "0x72F2E0", Length = "0xB6")]
	private float easeInOutCirc(float start, float end, float value)
	{
		return 0f;
	}

	[Token(Token = "0x60002CE")]
	[Address(RVA = "0x7305A0", Offset = "0x72F3A0", Length = "0x55")]
	private float easeInBounce(float start, float end, float value)
	{
		return 0f;
	}

	[Token(Token = "0x60002CF")]
	[Address(RVA = "0x730600", Offset = "0x72F400", Length = "0xCA")]
	private float easeOutBounce(float start, float end, float value)
	{
		return 0f;
	}

	[Token(Token = "0x60002D0")]
	[Address(RVA = "0x7306D0", Offset = "0x72F4D0", Length = "0xBB")]
	private float easeInOutBounce(float start, float end, float value)
	{
		return 0f;
	}

	[Token(Token = "0x60002D1")]
	[Address(RVA = "0x730790", Offset = "0x72F590", Length = "0x28")]
	private float easeInBack(float start, float end, float value)
	{
		return 0f;
	}

	[Token(Token = "0x60002D2")]
	[Address(RVA = "0x7307C0", Offset = "0x72F5C0", Length = "0x38")]
	private float easeOutBack(float start, float end, float value)
	{
		return 0f;
	}

	[Token(Token = "0x60002D3")]
	[Address(RVA = "0x730800", Offset = "0x72F600", Length = "0x75")]
	private float easeInOutBack(float start, float end, float value)
	{
		return 0f;
	}

	[Token(Token = "0x60002D4")]
	[Address(RVA = "0x730880", Offset = "0x72F680", Length = "0x98")]
	private float punch(float amplitude, float value)
	{
		return 0f;
	}

	[Token(Token = "0x60002D5")]
	[Address(RVA = "0x730920", Offset = "0x72F720", Length = "0xC6")]
	private float easeInElastic(float start, float end, float value)
	{
		return 0f;
	}

	[Token(Token = "0x60002D6")]
	[Address(RVA = "0x7309F0", Offset = "0x72F7F0", Length = "0xBB")]
	private float easeOutElastic(float start, float end, float value)
	{
		return 0f;
	}

	[Token(Token = "0x60002D7")]
	[Address(RVA = "0x730AB0", Offset = "0x72F8B0", Length = "0x121")]
	private float easeInOutElastic(float start, float end, float value)
	{
		return 0f;
	}

	[Token(Token = "0x60002D8")]
	[Address(RVA = "0x4AF5E0", Offset = "0x4AE3E0", Length = "0x43")]
	public iTween()
	{
	}
}
