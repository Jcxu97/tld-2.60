using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x2000034")]
public class iTweenEvent : MonoBehaviour
{
	[Token(Token = "0x2000035")]
	public enum TweenType
	{
		[Token(Token = "0x40002B9")]
		AudioFrom,
		[Token(Token = "0x40002BA")]
		AudioTo,
		[Token(Token = "0x40002BB")]
		AudioUpdate,
		[Token(Token = "0x40002BC")]
		CameraFadeFrom,
		[Token(Token = "0x40002BD")]
		CameraFadeTo,
		[Token(Token = "0x40002BE")]
		ColorFrom,
		[Token(Token = "0x40002BF")]
		ColorTo,
		[Token(Token = "0x40002C0")]
		ColorUpdate,
		[Token(Token = "0x40002C1")]
		FadeFrom,
		[Token(Token = "0x40002C2")]
		FadeTo,
		[Token(Token = "0x40002C3")]
		FadeUpdate,
		[Token(Token = "0x40002C4")]
		LookFrom,
		[Token(Token = "0x40002C5")]
		LookTo,
		[Token(Token = "0x40002C6")]
		LookUpdate,
		[Token(Token = "0x40002C7")]
		MoveAdd,
		[Token(Token = "0x40002C8")]
		MoveBy,
		[Token(Token = "0x40002C9")]
		MoveFrom,
		[Token(Token = "0x40002CA")]
		MoveTo,
		[Token(Token = "0x40002CB")]
		MoveUpdate,
		[Token(Token = "0x40002CC")]
		PunchPosition,
		[Token(Token = "0x40002CD")]
		PunchRotation,
		[Token(Token = "0x40002CE")]
		PunchScale,
		[Token(Token = "0x40002CF")]
		RotateAdd,
		[Token(Token = "0x40002D0")]
		RotateBy,
		[Token(Token = "0x40002D1")]
		RotateFrom,
		[Token(Token = "0x40002D2")]
		RotateTo,
		[Token(Token = "0x40002D3")]
		RotateUpdate,
		[Token(Token = "0x40002D4")]
		ScaleAdd,
		[Token(Token = "0x40002D5")]
		ScaleBy,
		[Token(Token = "0x40002D6")]
		ScaleFrom,
		[Token(Token = "0x40002D7")]
		ScaleTo,
		[Token(Token = "0x40002D8")]
		ScaleUpdate,
		[Token(Token = "0x40002D9")]
		ShakePosition,
		[Token(Token = "0x40002DA")]
		ShakeRotation,
		[Token(Token = "0x40002DB")]
		ShakeScale,
		[Token(Token = "0x40002DC")]
		Stab
	}

	[CompilerGenerated]
	[Token(Token = "0x2000037")]
	private sealed class _003CStartEvent_003Ed__41 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40002DE")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x40002DF")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x40002E0")]
		[FieldOffset(Offset = "0x20")]
		public iTweenEvent _003C_003E4__this;

		[Token(Token = "0x17000024")]
		object IEnumerator<object>.Current
		{
			[DebuggerHidden]
			[Token(Token = "0x600030E")]
			[Address(RVA = "0x4571D0", Offset = "0x455FD0", Length = "0x5")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000025")]
		object IEnumerator.Current
		{
			[DebuggerHidden]
			[Token(Token = "0x6000310")]
			[Address(RVA = "0x4571D0", Offset = "0x455FD0", Length = "0x5")]
			get
			{
				return null;
			}
		}

		[DebuggerHidden]
		[Token(Token = "0x600030B")]
		[Address(RVA = "0x4096E0", Offset = "0x4084E0", Length = "0x4")]
		public _003CStartEvent_003Ed__41(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		[Token(Token = "0x600030C")]
		[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
		void IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600030D")]
		[Address(RVA = "0x897800", Offset = "0x896600", Length = "0xFE8")]
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
		[Token(Token = "0x600030F")]
		[Address(RVA = "0x898880", Offset = "0x897680", Length = "0x3E")]
		void IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x400029A")]
	public const string VERSION = "0.6.1";

	[Token(Token = "0x400029B")]
	[FieldOffset(Offset = "0x20")]
	public string tweenName;

	[Token(Token = "0x400029C")]
	[FieldOffset(Offset = "0x28")]
	public bool playAutomatically;

	[Token(Token = "0x400029D")]
	[FieldOffset(Offset = "0x2C")]
	public float delay;

	[Token(Token = "0x400029E")]
	[FieldOffset(Offset = "0x30")]
	public TweenType type;

	[Token(Token = "0x400029F")]
	[FieldOffset(Offset = "0x34")]
	public bool showIconInInspector;

	[SerializeField]
	[Token(Token = "0x40002A0")]
	[FieldOffset(Offset = "0x38")]
	private string[] keys;

	[SerializeField]
	[Token(Token = "0x40002A1")]
	[FieldOffset(Offset = "0x40")]
	private int[] indexes;

	[SerializeField]
	[Token(Token = "0x40002A2")]
	[FieldOffset(Offset = "0x48")]
	private string[] metadatas;

	[SerializeField]
	[Token(Token = "0x40002A3")]
	[FieldOffset(Offset = "0x50")]
	private int[] ints;

	[SerializeField]
	[Token(Token = "0x40002A4")]
	[FieldOffset(Offset = "0x58")]
	private float[] floats;

	[SerializeField]
	[Token(Token = "0x40002A5")]
	[FieldOffset(Offset = "0x60")]
	private bool[] bools;

	[SerializeField]
	[Token(Token = "0x40002A6")]
	[FieldOffset(Offset = "0x68")]
	private string[] strings;

	[SerializeField]
	[Token(Token = "0x40002A7")]
	[FieldOffset(Offset = "0x70")]
	private Vector3[] vector3s;

	[SerializeField]
	[Token(Token = "0x40002A8")]
	[FieldOffset(Offset = "0x78")]
	private Color[] colors;

	[SerializeField]
	[Token(Token = "0x40002A9")]
	[FieldOffset(Offset = "0x80")]
	private Space[] spaces;

	[SerializeField]
	[Token(Token = "0x40002AA")]
	[FieldOffset(Offset = "0x88")]
	private iTween.EaseType[] easeTypes;

	[SerializeField]
	[Token(Token = "0x40002AB")]
	[FieldOffset(Offset = "0x90")]
	private iTween.LoopType[] loopTypes;

	[SerializeField]
	[Token(Token = "0x40002AC")]
	[FieldOffset(Offset = "0x98")]
	private GameObject[] gameObjects;

	[SerializeField]
	[Token(Token = "0x40002AD")]
	[FieldOffset(Offset = "0xA0")]
	private Transform[] transforms;

	[SerializeField]
	[Token(Token = "0x40002AE")]
	[FieldOffset(Offset = "0xA8")]
	private AudioClip[] audioClips;

	[SerializeField]
	[Token(Token = "0x40002AF")]
	[FieldOffset(Offset = "0xB0")]
	private AudioSource[] audioSources;

	[SerializeField]
	[Token(Token = "0x40002B0")]
	[FieldOffset(Offset = "0xB8")]
	private ArrayIndexes[] vector3Arrays;

	[SerializeField]
	[Token(Token = "0x40002B1")]
	[FieldOffset(Offset = "0xC0")]
	private ArrayIndexes[] transformArrays;

	[SerializeField]
	[Token(Token = "0x40002B2")]
	[FieldOffset(Offset = "0xC8")]
	private iTweenPath[] paths;

	[Token(Token = "0x40002B3")]
	[FieldOffset(Offset = "0xD0")]
	private Dictionary<string, object> values;

	[Token(Token = "0x40002B4")]
	[FieldOffset(Offset = "0xD8")]
	private bool stopped;

	[Token(Token = "0x40002B5")]
	[FieldOffset(Offset = "0xD9")]
	private bool animating;

	[Token(Token = "0x40002B6")]
	[FieldOffset(Offset = "0xE0")]
	private iTween instantiatedTween;

	[Token(Token = "0x40002B7")]
	[FieldOffset(Offset = "0xE8")]
	private string internalName;

	[Token(Token = "0x17000023")]
	public Dictionary<string, object> Values
	{
		[Token(Token = "0x60002F9")]
		[Address(RVA = "0x8944D0", Offset = "0x8932D0", Length = "0x34")]
		get
		{
			return null;
		}
		[Token(Token = "0x60002FA")]
		[Address(RVA = "0x894510", Offset = "0x893310", Length = "0x5B")]
		set
		{
		}
	}

	[Token(Token = "0x60002F8")]
	[Address(RVA = "0x8941A0", Offset = "0x892FA0", Length = "0x32A")]
	public static iTweenEvent GetEvent(GameObject obj, string name)
	{
		return null;
	}

	[Token(Token = "0x60002FB")]
	[Address(RVA = "0x894570", Offset = "0x893370", Length = "0xE")]
	public void Start()
	{
	}

	[Token(Token = "0x60002FC")]
	[Address(RVA = "0x894580", Offset = "0x893380", Length = "0xC4")]
	public void Play()
	{
	}

	[Token(Token = "0x60002FD")]
	[Address(RVA = "0x894650", Offset = "0x893450", Length = "0xEF")]
	public void Stop()
	{
	}

	[Token(Token = "0x60002FE")]
	[Address(RVA = "0x894740", Offset = "0x893540", Length = "0x36")]
	public void OnAnimComplete(string name)
	{
	}

	[Token(Token = "0x60002FF")]
	[Address(RVA = "0x894780", Offset = "0x893580", Length = "0x8")]
	public bool IsAnimating()
	{
		return false;
	}

	[Token(Token = "0x6000300")]
	[Address(RVA = "0x894790", Offset = "0x893590", Length = "0x12A")]
	public void OnDrawGizmos()
	{
	}

	[IteratorStateMachine(typeof(_003CStartEvent_003Ed__41))]
	[Token(Token = "0x6000301")]
	[Address(RVA = "0x8948C0", Offset = "0x8936C0", Length = "0x9A")]
	private IEnumerator StartEvent()
	{
		return null;
	}

	[Token(Token = "0x6000302")]
	[Address(RVA = "0x894960", Offset = "0x893760", Length = "0x1DFE")]
	private void SerializeValues()
	{
	}

	[Token(Token = "0x6000303")]
	[Address(RVA = "0x1A61C90", Offset = "0x1A60A90", Length = "0xED")]
	private void AddToList<T>(List<string> keyList, List<int> indexList, IList<T> valueList, List<string> metadataList, KeyValuePair<string, object> pair)
	{
	}

	[Token(Token = "0x6000304")]
	[Address(RVA = "0x1A62710", Offset = "0x1A61510", Length = "0xD0")]
	private void AddToList<T>(List<string> keyList, List<int> indexList, IList<T> valueList, List<string> metadataList, KeyValuePair<string, object> pair, string metadata)
	{
	}

	[Token(Token = "0x6000305")]
	[Address(RVA = "0x1A622F0", Offset = "0x1A610F0", Length = "0xA6")]
	private void AddToList<T>(List<string> keyList, List<int> indexList, IList<T> valueList, List<string> metadataList, string key, object value)
	{
	}

	[Token(Token = "0x6000306")]
	[Address(RVA = "0x1A62890", Offset = "0x1A61690", Length = "0x222")]
	private void AddToList<T>(List<string> keyList, List<int> indexList, IList<T> valueList, List<string> metadataList, string key, object value, string metadata)
	{
	}

	[Token(Token = "0x6000307")]
	[Address(RVA = "0x896760", Offset = "0x895560", Length = "0xF54")]
	private void DeserializeValues()
	{
	}

	[Token(Token = "0x6000308")]
	[Address(RVA = "0x8976C0", Offset = "0x8964C0", Length = "0xD1")]
	public iTweenEvent()
	{
	}
}
