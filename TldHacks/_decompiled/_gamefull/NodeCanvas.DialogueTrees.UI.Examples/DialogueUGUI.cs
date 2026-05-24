using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.UI;

namespace NodeCanvas.DialogueTrees.UI.Examples;

[Token(Token = "0x200110C")]
public class DialogueUGUI : MonoBehaviour
{
	[Serializable]
	[Token(Token = "0x200110D")]
	public class SubtitleDelays
	{
		[Token(Token = "0x400872B")]
		[FieldOffset(Offset = "0x10")]
		public float characterDelay;

		[Token(Token = "0x400872C")]
		[FieldOffset(Offset = "0x14")]
		public float sentenceDelay;

		[Token(Token = "0x400872D")]
		[FieldOffset(Offset = "0x18")]
		public float commaDelay;

		[Token(Token = "0x400872E")]
		[FieldOffset(Offset = "0x1C")]
		public float finalDelay;

		[Token(Token = "0x60073A2")]
		[Address(RVA = "0x10F0790", Offset = "0x10EF590", Length = "0x1D")]
		public SubtitleDelays()
		{
		}
	}

	[CompilerGenerated]
	[Token(Token = "0x200110E")]
	private sealed class _003C_003Ec__DisplayClass25_0
	{
		[Token(Token = "0x400872F")]
		[FieldOffset(Offset = "0x10")]
		public bool inputDown;

		[Token(Token = "0x60073A3")]
		[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
		public _003C_003Ec__DisplayClass25_0()
		{
		}

		[Token(Token = "0x60073A4")]
		[Address(RVA = "0x4A1DD0", Offset = "0x4A0BD0", Length = "0x5")]
		internal void _003CInternal_OnSubtitlesRequestInfo_003Eb__0()
		{
		}
	}

	[CompilerGenerated]
	[Token(Token = "0x2001111")]
	private sealed class _003CCheckInput_003Ed__27 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4008734")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4008735")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4008736")]
		[FieldOffset(Offset = "0x20")]
		public Action Do;

		[Token(Token = "0x170008D7")]
		object IEnumerator<object>.Current
		{
			[DebuggerHidden]
			[Token(Token = "0x60073AB")]
			[Address(RVA = "0x4571D0", Offset = "0x455FD0", Length = "0x5")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170008D8")]
		object IEnumerator.Current
		{
			[DebuggerHidden]
			[Token(Token = "0x60073AD")]
			[Address(RVA = "0x4571D0", Offset = "0x455FD0", Length = "0x5")]
			get
			{
				return null;
			}
		}

		[DebuggerHidden]
		[Token(Token = "0x60073A8")]
		[Address(RVA = "0x4096E0", Offset = "0x4084E0", Length = "0x4")]
		public _003CCheckInput_003Ed__27(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		[Token(Token = "0x60073A9")]
		[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
		void IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60073AA")]
		[Address(RVA = "0x10F0840", Offset = "0x10EF640", Length = "0xD8")]
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
		[Token(Token = "0x60073AC")]
		[Address(RVA = "0x10F0920", Offset = "0x10EF720", Length = "0x3E")]
		void IEnumerator.Reset()
		{
		}
	}

	[CompilerGenerated]
	[Token(Token = "0x2001112")]
	private sealed class _003CCountDown_003Ed__30 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4008737")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4008738")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4008739")]
		[FieldOffset(Offset = "0x20")]
		public DialogueUGUI _003C_003E4__this;

		[Token(Token = "0x400873A")]
		[FieldOffset(Offset = "0x28")]
		public MultipleChoiceRequestInfo info;

		[Token(Token = "0x400873B")]
		[FieldOffset(Offset = "0x30")]
		private float _003Ctimer_003E5__2;

		[Token(Token = "0x170008D9")]
		object IEnumerator<object>.Current
		{
			[DebuggerHidden]
			[Token(Token = "0x60073B1")]
			[Address(RVA = "0x4571D0", Offset = "0x455FD0", Length = "0x5")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170008DA")]
		object IEnumerator.Current
		{
			[DebuggerHidden]
			[Token(Token = "0x60073B3")]
			[Address(RVA = "0x4571D0", Offset = "0x455FD0", Length = "0x5")]
			get
			{
				return null;
			}
		}

		[DebuggerHidden]
		[Token(Token = "0x60073AE")]
		[Address(RVA = "0x4096E0", Offset = "0x4084E0", Length = "0x4")]
		public _003CCountDown_003Ed__30(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		[Token(Token = "0x60073AF")]
		[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
		void IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60073B0")]
		[Address(RVA = "0x10F0960", Offset = "0x10EF760", Length = "0x1C8")]
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
		[Token(Token = "0x60073B2")]
		[Address(RVA = "0x10F0B30", Offset = "0x10EF930", Length = "0x3E")]
		void IEnumerator.Reset()
		{
		}
	}

	[CompilerGenerated]
	[Token(Token = "0x2001113")]
	private sealed class _003CDelayPrint_003Ed__28 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400873C")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400873D")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400873E")]
		[FieldOffset(Offset = "0x20")]
		public float time;

		[Token(Token = "0x400873F")]
		[FieldOffset(Offset = "0x24")]
		private float _003Ctimer_003E5__2;

		[Token(Token = "0x170008DB")]
		object IEnumerator<object>.Current
		{
			[DebuggerHidden]
			[Token(Token = "0x60073B7")]
			[Address(RVA = "0x4571D0", Offset = "0x455FD0", Length = "0x5")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170008DC")]
		object IEnumerator.Current
		{
			[DebuggerHidden]
			[Token(Token = "0x60073B9")]
			[Address(RVA = "0x4571D0", Offset = "0x455FD0", Length = "0x5")]
			get
			{
				return null;
			}
		}

		[DebuggerHidden]
		[Token(Token = "0x60073B4")]
		[Address(RVA = "0x4096E0", Offset = "0x4084E0", Length = "0x4")]
		public _003CDelayPrint_003Ed__28(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		[Token(Token = "0x60073B5")]
		[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
		void IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60073B6")]
		[Address(RVA = "0x10F0B70", Offset = "0x10EF970", Length = "0xFA")]
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
		[Token(Token = "0x60073B8")]
		[Address(RVA = "0x10F0C70", Offset = "0x10EFA70", Length = "0x3E")]
		void IEnumerator.Reset()
		{
		}
	}

	[CompilerGenerated]
	[Token(Token = "0x2001114")]
	private sealed class _003CInternal_OnSubtitlesRequestInfo_003Ed__25 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4008740")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4008741")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4008742")]
		[FieldOffset(Offset = "0x20")]
		public SubtitlesRequestInfo info;

		[Token(Token = "0x4008743")]
		[FieldOffset(Offset = "0x28")]
		public DialogueUGUI _003C_003E4__this;

		[Token(Token = "0x4008744")]
		[FieldOffset(Offset = "0x30")]
		private _003C_003Ec__DisplayClass25_0 _003C_003E8__1;

		[Token(Token = "0x4008745")]
		[FieldOffset(Offset = "0x38")]
		private string _003Ctext_003E5__2;

		[Token(Token = "0x4008746")]
		[FieldOffset(Offset = "0x40")]
		private AudioClip _003Caudio_003E5__3;

		[Token(Token = "0x4008747")]
		[FieldOffset(Offset = "0x48")]
		private AudioSource _003CplaySource_003E5__4;

		[Token(Token = "0x4008748")]
		[FieldOffset(Offset = "0x50")]
		private float _003Ctimer_003E5__5;

		[Token(Token = "0x4008749")]
		[FieldOffset(Offset = "0x58")]
		private string _003CtempText_003E5__6;

		[Token(Token = "0x400874A")]
		[FieldOffset(Offset = "0x60")]
		private int _003Ci_003E5__7;

		[Token(Token = "0x400874B")]
		[FieldOffset(Offset = "0x64")]
		private char _003Cc_003E5__8;

		[Token(Token = "0x170008DD")]
		object IEnumerator<object>.Current
		{
			[DebuggerHidden]
			[Token(Token = "0x60073BD")]
			[Address(RVA = "0x4571D0", Offset = "0x455FD0", Length = "0x5")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170008DE")]
		object IEnumerator.Current
		{
			[DebuggerHidden]
			[Token(Token = "0x60073BF")]
			[Address(RVA = "0x4571D0", Offset = "0x455FD0", Length = "0x5")]
			get
			{
				return null;
			}
		}

		[DebuggerHidden]
		[Token(Token = "0x60073BA")]
		[Address(RVA = "0x4096E0", Offset = "0x4084E0", Length = "0x4")]
		public _003CInternal_OnSubtitlesRequestInfo_003Ed__25(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		[Token(Token = "0x60073BB")]
		[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
		void IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60073BC")]
		[Address(RVA = "0x10F0CB0", Offset = "0x10EFAB0", Length = "0xD48")]
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
		[Token(Token = "0x60073BE")]
		[Address(RVA = "0x10F1A20", Offset = "0x10F0820", Length = "0x3E")]
		void IEnumerator.Reset()
		{
		}
	}

	[Header("Input Options")]
	[Token(Token = "0x400871C")]
	[FieldOffset(Offset = "0x20")]
	public bool skipOnInput;

	[Token(Token = "0x400871D")]
	[FieldOffset(Offset = "0x21")]
	public bool waitForInput;

	[Header("Subtitles")]
	[Token(Token = "0x400871E")]
	[FieldOffset(Offset = "0x28")]
	public RectTransform subtitlesGroup;

	[Token(Token = "0x400871F")]
	[FieldOffset(Offset = "0x30")]
	public Text actorSpeech;

	[Token(Token = "0x4008720")]
	[FieldOffset(Offset = "0x38")]
	public Text actorName;

	[Token(Token = "0x4008721")]
	[FieldOffset(Offset = "0x40")]
	public Image actorPortrait;

	[Token(Token = "0x4008722")]
	[FieldOffset(Offset = "0x48")]
	public RectTransform waitInputIndicator;

	[Token(Token = "0x4008723")]
	[FieldOffset(Offset = "0x50")]
	public SubtitleDelays subtitleDelays;

	[Token(Token = "0x4008724")]
	[FieldOffset(Offset = "0x58")]
	public List<AudioClip> typingSounds;

	[Header("Multiple Choice")]
	[Token(Token = "0x4008725")]
	[FieldOffset(Offset = "0x60")]
	public RectTransform optionsGroup;

	[Token(Token = "0x4008726")]
	[FieldOffset(Offset = "0x68")]
	public Button optionButton;

	[Token(Token = "0x4008727")]
	[FieldOffset(Offset = "0x70")]
	private Dictionary<Button, int> cachedButtons;

	[Token(Token = "0x4008728")]
	[FieldOffset(Offset = "0x78")]
	private Vector2 originalSubsPosition;

	[Token(Token = "0x4008729")]
	[FieldOffset(Offset = "0x80")]
	private bool isWaitingChoice;

	[Token(Token = "0x400872A")]
	[FieldOffset(Offset = "0x88")]
	private AudioSource _localSource;

	[Token(Token = "0x170008D6")]
	private AudioSource localSource
	{
		[Token(Token = "0x6007391")]
		[Address(RVA = "0x10EDBE0", Offset = "0x10EC9E0", Length = "0x169")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6007392")]
	[Address(RVA = "0x10EDD50", Offset = "0x10ECB50", Length = "0x199")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6007393")]
	[Address(RVA = "0x10EDEF0", Offset = "0x10ECCF0", Length = "0x199")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6007394")]
	[Address(RVA = "0x10EE090", Offset = "0x10ECE90", Length = "0x18A")]
	private void Start()
	{
	}

	[Token(Token = "0x6007395")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	private void OnDialogueStarted(DialogueTree dlg)
	{
	}

	[Token(Token = "0x6007396")]
	[Address(RVA = "0x10EE220", Offset = "0x10ED020", Length = "0x57")]
	private void OnDialoguePaused(DialogueTree dlg)
	{
	}

	[Token(Token = "0x6007397")]
	[Address(RVA = "0x10EE280", Offset = "0x10ED080", Length = "0x3A5")]
	private void OnDialogueFinished(DialogueTree dlg)
	{
	}

	[Token(Token = "0x6007398")]
	[Address(RVA = "0x10EE630", Offset = "0x10ED430", Length = "0x101")]
	private void OnSubtitlesRequest(SubtitlesRequestInfo info)
	{
	}

	[IteratorStateMachine(typeof(_003CInternal_OnSubtitlesRequestInfo_003Ed__25))]
	[Token(Token = "0x6007399")]
	[Address(RVA = "0x10EE740", Offset = "0x10ED540", Length = "0xF7")]
	private IEnumerator Internal_OnSubtitlesRequestInfo(SubtitlesRequestInfo info)
	{
		return null;
	}

	[Token(Token = "0x600739A")]
	[Address(RVA = "0x10EE840", Offset = "0x10ED640", Length = "0x1C6")]
	private void PlayTypeSound()
	{
	}

	[IteratorStateMachine(typeof(_003CCheckInput_003Ed__27))]
	[Token(Token = "0x600739B")]
	[Address(RVA = "0x10EEA10", Offset = "0x10ED810", Length = "0x9A")]
	private IEnumerator CheckInput(Action Do)
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CDelayPrint_003Ed__28))]
	[Token(Token = "0x600739C")]
	[Address(RVA = "0x10EEAB0", Offset = "0x10ED8B0", Length = "0x4F")]
	private IEnumerator DelayPrint(float time)
	{
		return null;
	}

	[Token(Token = "0x600739D")]
	[Address(RVA = "0x10EEB00", Offset = "0x10ED900", Length = "0x13CD")]
	private void OnMultipleChoiceRequest(MultipleChoiceRequestInfo info)
	{
	}

	[IteratorStateMachine(typeof(_003CCountDown_003Ed__30))]
	[Token(Token = "0x600739E")]
	[Address(RVA = "0x10EFED0", Offset = "0x10EECD0", Length = "0xF7")]
	private IEnumerator CountDown(MultipleChoiceRequestInfo info)
	{
		return null;
	}

	[Token(Token = "0x600739F")]
	[Address(RVA = "0x10EFFD0", Offset = "0x10EEDD0", Length = "0x4D9")]
	private void Finalize(MultipleChoiceRequestInfo info, int index)
	{
	}

	[Token(Token = "0x60073A0")]
	[Address(RVA = "0x10F04B0", Offset = "0x10EF2B0", Length = "0x1F0")]
	private void SetMassAlpha(RectTransform root, float alpha)
	{
	}

	[Token(Token = "0x60073A1")]
	[Address(RVA = "0x10F06B0", Offset = "0x10EF4B0", Length = "0xD8")]
	public DialogueUGUI()
	{
	}
}
