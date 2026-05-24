using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using TLD.Gameplay;
using TLD.Logging;

[Token(Token = "0x2000779")]
public class JumpManager
{
	[Token(Token = "0x200077A")]
	public enum State
	{
		[Token(Token = "0x400505E")]
		Idle,
		[Token(Token = "0x400505F")]
		Loading,
		[Token(Token = "0x4005060")]
		Saving
	}

	[Token(Token = "0x200077B")]
	private enum SaveStage
	{
		[Token(Token = "0x4005062")]
		Prepare,
		[Token(Token = "0x4005063")]
		Start,
		[Token(Token = "0x4005064")]
		Write,
		[Token(Token = "0x4005065")]
		Complete
	}

	[CompilerGenerated]
	[Token(Token = "0x200077C")]
	private sealed class _003COnSavingCoroutine_003Ed__38 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4005066")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4005067")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x17000326")]
		object IEnumerator<object>.Current
		{
			[DebuggerHidden]
			[Token(Token = "0x6004649")]
			[Address(RVA = "0x4571D0", Offset = "0x455FD0", Length = "0x5")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000327")]
		object IEnumerator.Current
		{
			[DebuggerHidden]
			[Token(Token = "0x600464B")]
			[Address(RVA = "0x4571D0", Offset = "0x455FD0", Length = "0x5")]
			get
			{
				return null;
			}
		}

		[DebuggerHidden]
		[Token(Token = "0x6004646")]
		[Address(RVA = "0x4096E0", Offset = "0x4084E0", Length = "0x4")]
		public _003COnSavingCoroutine_003Ed__38(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		[Token(Token = "0x6004647")]
		[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
		void IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6004648")]
		[Address(RVA = "0xCA0B40", Offset = "0xC9F940", Length = "0x3DF")]
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
		[Token(Token = "0x600464A")]
		[Address(RVA = "0xCA0F20", Offset = "0xC9FD20", Length = "0x3E")]
		void IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4005050")]
	private static readonly LogFilter s_JumpLogFilter;

	[Token(Token = "0x4005051")]
	public static readonly uint SAVE_SLOT;

	[Token(Token = "0x4005052")]
	private static JumpManager s_Instance;

	[Token(Token = "0x4005053")]
	private static string s_DataPath;

	[Token(Token = "0x4005054")]
	[FieldOffset(Offset = "0x10")]
	private bool m_AllowCreation;

	[Token(Token = "0x4005055")]
	[FieldOffset(Offset = "0x18")]
	private string m_LastJumpFile;

	[Token(Token = "0x4005056")]
	[FieldOffset(Offset = "0x20")]
	private State m_State;

	[Token(Token = "0x4005057")]
	[FieldOffset(Offset = "0x28")]
	private JumpLoadThread m_JumpLoadThread;

	[Token(Token = "0x4005058")]
	[FieldOffset(Offset = "0x30")]
	private SlotData m_LoadSlotData;

	[Token(Token = "0x4005059")]
	[FieldOffset(Offset = "0x38")]
	private SaveSlotInfo m_LoadSlotInfo;

	[Token(Token = "0x400505A")]
	[FieldOffset(Offset = "0x40")]
	private SaveStage m_SaveStage;

	[Token(Token = "0x400505B")]
	[FieldOffset(Offset = "0x48")]
	private string m_SaveName;

	[Token(Token = "0x400505C")]
	[FieldOffset(Offset = "0x50")]
	private bool m_RestoreAsyncSave;

	[Token(Token = "0x600462B")]
	[Address(RVA = "0xC9E8B0", Offset = "0xC9D6B0", Length = "0x52")]
	protected JumpManager()
	{
	}

	[Token(Token = "0x600462C")]
	[Address(RVA = "0xC9E910", Offset = "0xC9D710", Length = "0x41")]
	public static bool CanReload()
	{
		return false;
	}

	[Token(Token = "0x600462D")]
	[Address(RVA = "0xC9E960", Offset = "0xC9D760", Length = "0x43")]
	public static void ClearLoadThread()
	{
	}

	[Token(Token = "0x600462E")]
	[Address(RVA = "0xC9E9B0", Offset = "0xC9D7B0", Length = "0x63")]
	public static bool Create(string name = null)
	{
		return false;
	}

	[Token(Token = "0x600462F")]
	[Address(RVA = "0xC9EA20", Offset = "0xC9D820", Length = "0x23A")]
	public static string GetDataPath()
	{
		return null;
	}

	[Token(Token = "0x6004630")]
	[Address(RVA = "0xC9EC60", Offset = "0xC9DA60", Length = "0x41")]
	public static State GetState()
	{
		return default(State);
	}

	[Token(Token = "0x6004631")]
	[Address(RVA = "0xC9ECB0", Offset = "0xC9DAB0", Length = "0xEB")]
	public static JumpData Import(string path)
	{
		return null;
	}

	[Conditional("__DEBUG")]
	[Token(Token = "0x6004632")]
	[Address(RVA = "0xC9EDA0", Offset = "0xC9DBA0", Length = "0x136")]
	public static void Instantiate()
	{
	}

	[Token(Token = "0x6004633")]
	[Address(RVA = "0x4582A0", Offset = "0x4570A0", Length = "0x3")]
	public static JumpManager Instance()
	{
		return null;
	}

	[Token(Token = "0x6004634")]
	[Address(RVA = "0xC9EEE0", Offset = "0xC9DCE0", Length = "0x41")]
	public static bool IsCreationAllowed()
	{
		return false;
	}

	[Token(Token = "0x6004635")]
	[Address(RVA = "0xC9EF30", Offset = "0xC9DD30", Length = "0x41")]
	public static bool IsAsyncLoading()
	{
		return false;
	}

	[Token(Token = "0x6004636")]
	[Address(RVA = "0xC9EF80", Offset = "0xC9DD80", Length = "0x100")]
	public static bool Load(JumpData jump)
	{
		return false;
	}

	[Token(Token = "0x6004637")]
	[Address(RVA = "0xC9F080", Offset = "0xC9DE80", Length = "0x79")]
	public static void Reload()
	{
	}

	[Token(Token = "0x6004638")]
	[Address(RVA = "0xC9F100", Offset = "0xC9DF00", Length = "0x2B4")]
	public static bool Rename(string path, string name)
	{
		return false;
	}

	[Token(Token = "0x6004639")]
	[Address(RVA = "0xC9F3C0", Offset = "0xC9E1C0", Length = "0x3F")]
	public static void SetCreationAllowed(bool allow)
	{
	}

	[Token(Token = "0x600463A")]
	[Address(RVA = "0xC9F400", Offset = "0xC9E200", Length = "0x54")]
	public static void StartJumpLoadAsync(JumpLoadCompleteDelegate onComplete)
	{
	}

	[Token(Token = "0x600463B")]
	[Address(RVA = "0xC9F460", Offset = "0xC9E260", Length = "0x75")]
	public static void StopJumpLoadAsync()
	{
	}

	[Token(Token = "0x600463C")]
	[Address(RVA = "0xC9F4E0", Offset = "0xC9E2E0", Length = "0x2DD")]
	private void OnLoadComplete()
	{
	}

	[Token(Token = "0x600463D")]
	[Address(RVA = "0xC9F7C0", Offset = "0xC9E5C0", Length = "0x381")]
	private void OnLoadSetup()
	{
	}

	[Token(Token = "0x600463E")]
	[Address(RVA = "0xC9FB50", Offset = "0xC9E950", Length = "0x241")]
	private static void CreateFromCurrentSave(string name)
	{
	}

	[Token(Token = "0x600463F")]
	[Address(RVA = "0xC9FDA0", Offset = "0xC9EBA0", Length = "0x553")]
	private static string CreateJumpFilePath(SaveSlotType mode, GameModeConfig xpmode, Episode episode = Episode.One)
	{
		return null;
	}

	[Token(Token = "0x6004640")]
	[Address(RVA = "0xCA0300", Offset = "0xC9F100", Length = "0xDD")]
	private static string GetEpisodeName(Episode episode)
	{
		return null;
	}

	[Token(Token = "0x6004641")]
	[Address(RVA = "0xCA03E0", Offset = "0xC9F1E0", Length = "0x12A")]
	private static string GetChallengeModeName(ChallengeConfig mode)
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003COnSavingCoroutine_003Ed__38))]
	[Token(Token = "0x6004642")]
	[Address(RVA = "0xCA0510", Offset = "0xC9F310", Length = "0x3D")]
	private static IEnumerator OnSavingCoroutine()
	{
		return null;
	}

	[Token(Token = "0x6004643")]
	[Address(RVA = "0xCA0550", Offset = "0xC9F350", Length = "0x45")]
	private static void Validate(string path)
	{
	}

	[Token(Token = "0x6004644")]
	[Address(RVA = "0xCA05A0", Offset = "0xC9F3A0", Length = "0x3F5")]
	private static SlotData WriteDataForJump(JumpData jump)
	{
		return null;
	}
}
