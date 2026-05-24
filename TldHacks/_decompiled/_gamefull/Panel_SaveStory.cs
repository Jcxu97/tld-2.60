using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using TLD.UI;
using UnityEngine;

[Token(Token = "0x20006BD")]
public class Panel_SaveStory : Panel_AutoReferenced
{
	[Serializable]
	[Token(Token = "0x20006BE")]
	public class AnimMenuItems
	{
		[Token(Token = "0x40047F9")]
		[FieldOffset(Offset = "0x10")]
		public GameObject m_Display;

		[Token(Token = "0x40047FA")]
		[FieldOffset(Offset = "0x18")]
		public Episode m_Type;

		[Token(Token = "0x40047FB")]
		[FieldOffset(Offset = "0x20")]
		public AnimationStateRef m_PlayOnSelect;

		[Token(Token = "0x40047FC")]
		[FieldOffset(Offset = "0x28")]
		public AnimationStateRef m_PlayOnDeselect;

		[NonSerialized]
		[Token(Token = "0x40047FD")]
		[FieldOffset(Offset = "0x30")]
		public int m_PlayOnSelectHash;

		[NonSerialized]
		[Token(Token = "0x40047FE")]
		[FieldOffset(Offset = "0x34")]
		public int m_PlayOnDeselectHash;

		[Token(Token = "0x6003B33")]
		[Address(RVA = "0xB59D50", Offset = "0xB58B50", Length = "0x109")]
		public AnimMenuItems()
		{
		}
	}

	[Token(Token = "0x20006BF")]
	private enum AnimationState
	{
		[Token(Token = "0x4004800")]
		None,
		[Token(Token = "0x4004801")]
		Select,
		[Token(Token = "0x4004802")]
		Deselect
	}

	[CompilerGenerated]
	[Token(Token = "0x20006C0")]
	private sealed class _003COnOverwriteConfirmedCoroutine_003Ed__56 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4004803")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4004804")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4004805")]
		[FieldOffset(Offset = "0x20")]
		public Panel_SaveStory _003C_003E4__this;

		[Token(Token = "0x1700030A")]
		object IEnumerator<object>.Current
		{
			[DebuggerHidden]
			[Token(Token = "0x6003B37")]
			[Address(RVA = "0x4571D0", Offset = "0x455FD0", Length = "0x5")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700030B")]
		object IEnumerator.Current
		{
			[DebuggerHidden]
			[Token(Token = "0x6003B39")]
			[Address(RVA = "0x4571D0", Offset = "0x455FD0", Length = "0x5")]
			get
			{
				return null;
			}
		}

		[DebuggerHidden]
		[Token(Token = "0x6003B34")]
		[Address(RVA = "0x4096E0", Offset = "0x4084E0", Length = "0x4")]
		public _003COnOverwriteConfirmedCoroutine_003Ed__56(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		[Token(Token = "0x6003B35")]
		[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
		void IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6003B36")]
		[Address(RVA = "0xB59E60", Offset = "0xB58C60", Length = "0x297")]
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
		[Token(Token = "0x6003B38")]
		[Address(RVA = "0xB5A100", Offset = "0xB58F00", Length = "0x3E")]
		void IEnumerator.Reset()
		{
		}
	}

	[CompilerGenerated]
	[Token(Token = "0x20006C1")]
	private sealed class _003COnQuicksaveCoroutine_003Ed__58 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4004806")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4004807")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4004808")]
		[FieldOffset(Offset = "0x20")]
		public Panel_SaveStory _003C_003E4__this;

		[Token(Token = "0x1700030C")]
		object IEnumerator<object>.Current
		{
			[DebuggerHidden]
			[Token(Token = "0x6003B3D")]
			[Address(RVA = "0x4571D0", Offset = "0x455FD0", Length = "0x5")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700030D")]
		object IEnumerator.Current
		{
			[DebuggerHidden]
			[Token(Token = "0x6003B3F")]
			[Address(RVA = "0x4571D0", Offset = "0x455FD0", Length = "0x5")]
			get
			{
				return null;
			}
		}

		[DebuggerHidden]
		[Token(Token = "0x6003B3A")]
		[Address(RVA = "0x4096E0", Offset = "0x4084E0", Length = "0x4")]
		public _003COnQuicksaveCoroutine_003Ed__58(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		[Token(Token = "0x6003B3B")]
		[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
		void IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6003B3C")]
		[Address(RVA = "0xB5A140", Offset = "0xB58F40", Length = "0x232")]
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
		[Token(Token = "0x6003B3E")]
		[Address(RVA = "0xB5A380", Offset = "0xB59180", Length = "0x3E")]
		void IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x40047DB")]
	private static string[] SPECIAL_SLOT_PREFIXES;

	[Token(Token = "0x40047DC")]
	private static string[] SPECIAL_SLOT_LOCIDS;

	[Token(Token = "0x40047DD")]
	private static int[] SPECIAL_SLOT_LIMITS;

	[Token(Token = "0x40047DE")]
	private static string[] STORY_SLOT_PREFIXES;

	[Token(Token = "0x40047DF")]
	[FieldOffset(Offset = "0x30")]
	public ButtonLegendContainer m_ButtonLegendContainer;

	[Token(Token = "0x40047E0")]
	[FieldOffset(Offset = "0x38")]
	public UtilsPanelChoose.DetailsObjets m_DetailObjects;

	[Token(Token = "0x40047E1")]
	[FieldOffset(Offset = "0x40")]
	public UILabel m_EpisodeValue;

	[Token(Token = "0x40047E2")]
	[FieldOffset(Offset = "0x48")]
	public UILabel m_ProgressValue;

	[Token(Token = "0x40047E3")]
	[FieldOffset(Offset = "0x50")]
	public List<AnimMenuItems> m_AnimMenuItems;

	[Token(Token = "0x40047E4")]
	[FieldOffset(Offset = "0x58")]
	public Animator m_Animator;

	[Header("Menu")]
	[Token(Token = "0x40047E5")]
	[FieldOffset(Offset = "0x60")]
	public string m_TitleLocalizationId;

	[Token(Token = "0x40047E6")]
	[FieldOffset(Offset = "0x68")]
	public string m_TitleHeaderLocalizationId;

	[Token(Token = "0x40047E7")]
	[FieldOffset(Offset = "0x70")]
	public Vector3 m_TitleHeaderOffset;

	[Token(Token = "0x40047E8")]
	[FieldOffset(Offset = "0x80")]
	public GameObject m_BasicMenuRoot;

	[Header("Slots In Use")]
	[Token(Token = "0x40047E9")]
	[FieldOffset(Offset = "0x88")]
	public UILabel m_SlotsUsedLabel;

	[Token(Token = "0x40047EA")]
	[FieldOffset(Offset = "0x90")]
	public Color m_SlotsUsedColorNormal;

	[Token(Token = "0x40047EB")]
	[FieldOffset(Offset = "0xA0")]
	public Color m_SlotsUsedColorFull;

	[Header("Mouse button")]
	[Token(Token = "0x40047EC")]
	[FieldOffset(Offset = "0xB0")]
	public GameObject m_MouseButtonDelete;

	[Token(Token = "0x40047ED")]
	[FieldOffset(Offset = "0xB8")]
	public GameObject m_MouseButtonRename;

	[Header("Steam Cloud")]
	[Token(Token = "0x40047EE")]
	[FieldOffset(Offset = "0xC0")]
	public UILabel m_CloudMessageLabel;

	[Token(Token = "0x40047EF")]
	[FieldOffset(Offset = "0xC8")]
	private SaveSlotInfo m_SlotToRename;

	[Token(Token = "0x40047F0")]
	[FieldOffset(Offset = "0xD0")]
	private SaveSlotInfo m_SlotToDelete;

	[Token(Token = "0x40047F1")]
	[FieldOffset(Offset = "0xD8")]
	private SaveSlotInfo m_SlotToOverwrite;

	[Token(Token = "0x40047F2")]
	[FieldOffset(Offset = "0xE0")]
	private BasicMenu m_BasicMenu;

	[Token(Token = "0x40047F3")]
	[FieldOffset(Offset = "0xE8")]
	private CloudSaveMenuExtension m_CloudSaveMenuExtension;

	[Token(Token = "0x40047F4")]
	[FieldOffset(Offset = "0xF0")]
	private AnimationState m_CurrentEpisodeAnimationState;

	[Token(Token = "0x40047F5")]
	private const int INVALID_INDEX = -1;

	[Token(Token = "0x40047F6")]
	private const int ANIMATION_BASE_LAYER = 0;

	[Token(Token = "0x40047F7")]
	[FieldOffset(Offset = "0xF4")]
	private int m_PreviousAnimIndex;

	[Token(Token = "0x40047F8")]
	[FieldOffset(Offset = "0xF8")]
	private int m_TargetAnimIndex;

	[Token(Token = "0x6003B0E")]
	[Address(RVA = "0xB55650", Offset = "0xB54450", Length = "0x2AC")]
	public override void Initialize()
	{
	}

	[Token(Token = "0x6003B0F")]
	[Address(RVA = "0xB55900", Offset = "0xB54700", Length = "0x1E")]
	protected override void OnDestroy()
	{
	}

	[Token(Token = "0x6003B10")]
	[Address(RVA = "0xB55920", Offset = "0xB54720", Length = "0x8A2")]
	private void ConfigureMenu()
	{
	}

	[Token(Token = "0x6003B11")]
	[Address(RVA = "0xB561D0", Offset = "0xB54FD0", Length = "0x4C9")]
	private void AddSavesOfTypeToMenu(string[] slotPrefixes, string[] displayLocIds = null, int[] limits = null, bool showTimeSinceSave = false)
	{
	}

	[Token(Token = "0x6003B12")]
	[Address(RVA = "0xB566A0", Offset = "0xB554A0", Length = "0x1B8")]
	private void Update()
	{
	}

	[Token(Token = "0x6003B13")]
	[Address(RVA = "0xB56860", Offset = "0xB55660", Length = "0x1DB")]
	public override void Enable(bool enable)
	{
	}

	[Token(Token = "0x6003B14")]
	[Address(RVA = "0xB56A40", Offset = "0xB55840", Length = "0xFE")]
	public void OnClickBack()
	{
	}

	[Token(Token = "0x6003B15")]
	[Address(RVA = "0xB56B40", Offset = "0xB55940", Length = "0x78")]
	public void BackWithouSFX()
	{
	}

	[Token(Token = "0x6003B16")]
	[Address(RVA = "0xB56BC0", Offset = "0xB559C0", Length = "0x4F3")]
	private void ProcessMenu()
	{
	}

	[Token(Token = "0x6003B17")]
	[Address(RVA = "0xB570C0", Offset = "0xB55EC0", Length = "0x51")]
	private SaveSlotInfo GetSaveSlotInfo(int index)
	{
		return null;
	}

	[Token(Token = "0x6003B18")]
	[Address(RVA = "0xB57120", Offset = "0xB55F20", Length = "0x70")]
	private SaveSlotInfo GetSelectedSaveSlotInfo()
	{
		return null;
	}

	[Token(Token = "0x6003B19")]
	[Address(RVA = "0xB571A0", Offset = "0xB55FA0", Length = "0x2B0")]
	public void OnRename()
	{
	}

	[Token(Token = "0x6003B1A")]
	[Address(RVA = "0x9ABA50", Offset = "0x9AA850", Length = "0x52")]
	public void OnRenameExistingStoryCancelled(bool wasCancelled)
	{
	}

	[Token(Token = "0x6003B1B")]
	[Address(RVA = "0xB57460", Offset = "0xB56260", Length = "0x200")]
	private void OnRenameExistingStoryConfirmed()
	{
	}

	[Token(Token = "0x6003B1C")]
	[Address(RVA = "0xB57670", Offset = "0xB56470", Length = "0x1ED")]
	public void OnDelete()
	{
	}

	[Token(Token = "0x6003B1D")]
	[Address(RVA = "0xB57860", Offset = "0xB56660", Length = "0xD6")]
	private void DeleteSaveSlot()
	{
	}

	[Token(Token = "0x6003B1E")]
	[Address(RVA = "0x9ABFC0", Offset = "0x9AADC0", Length = "0x52")]
	private void OnDeleteCancelled(bool wasCancelled)
	{
	}

	[Token(Token = "0x6003B1F")]
	[Address(RVA = "0xB57940", Offset = "0xB56740", Length = "0x216")]
	private void RefreshDetails(SaveSlotInfo slotInfo)
	{
	}

	[Token(Token = "0x6003B20")]
	[Address(RVA = "0xB57B60", Offset = "0xB56960", Length = "0x17F")]
	private void OnSelectionUpdate(string name, int value, int itemIndex)
	{
	}

	[Token(Token = "0x6003B21")]
	[Address(RVA = "0xB57CE0", Offset = "0xB56AE0", Length = "0x2DA")]
	private void OnSlotClicked()
	{
	}

	[Token(Token = "0x6003B22")]
	[Address(RVA = "0xB57FC0", Offset = "0xB56DC0", Length = "0x6EE")]
	private void OnNewSave()
	{
	}

	[Token(Token = "0x6003B23")]
	[Address(RVA = "0x9ADD00", Offset = "0x9ACB00", Length = "0x52")]
	public void OnCancelled(bool wasCancelled)
	{
	}

	[Token(Token = "0x6003B24")]
	[Address(RVA = "0xB586B0", Offset = "0xB574B0", Length = "0x19F")]
	private void OnNewSaveNamed()
	{
	}

	[Token(Token = "0x6003B25")]
	[Address(RVA = "0xB58850", Offset = "0xB57650", Length = "0x1C4")]
	private void OnOverwriteConfirmed()
	{
	}

	[IteratorStateMachine(typeof(_003COnOverwriteConfirmedCoroutine_003Ed__56))]
	[Token(Token = "0x6003B26")]
	[Address(RVA = "0xB58A20", Offset = "0xB57820", Length = "0x9A")]
	private IEnumerator OnOverwriteConfirmedCoroutine()
	{
		return null;
	}

	[Token(Token = "0x6003B27")]
	[Address(RVA = "0xB58AC0", Offset = "0xB578C0", Length = "0x1DC")]
	private void OnOverwriteSaveNamed()
	{
	}

	[IteratorStateMachine(typeof(_003COnQuicksaveCoroutine_003Ed__58))]
	[Token(Token = "0x6003B28")]
	[Address(RVA = "0xB58CA0", Offset = "0xB57AA0", Length = "0x9A")]
	private IEnumerator OnQuicksaveCoroutine()
	{
		return null;
	}

	[Token(Token = "0x6003B29")]
	[Address(RVA = "0xB58D40", Offset = "0xB57B40", Length = "0x17A")]
	private void EnableSingleAnimItem(int targetIndex)
	{
	}

	[Token(Token = "0x6003B2A")]
	[Address(RVA = "0xB58EC0", Offset = "0xB57CC0", Length = "0x94")]
	private AnimMenuItems GetAnimMenuItem(int index)
	{
		return null;
	}

	[Token(Token = "0x6003B2B")]
	[Address(RVA = "0xB58F60", Offset = "0xB57D60", Length = "0x15E")]
	private bool IsPlayingAnySelectionAnimation()
	{
		return false;
	}

	[Token(Token = "0x6003B2C")]
	[Address(RVA = "0xB590C0", Offset = "0xB57EC0", Length = "0x15E")]
	private bool IsPlayingAnyDeselectionAnimation()
	{
		return false;
	}

	[Token(Token = "0x6003B2D")]
	[Address(RVA = "0xB59220", Offset = "0xB58020", Length = "0x111")]
	private bool IsPlayingAnimation(int stateHash)
	{
		return false;
	}

	[Token(Token = "0x6003B2E")]
	[Address(RVA = "0xB59340", Offset = "0xB58140", Length = "0x12A")]
	private void PlaySelectedAnimation(AnimMenuItems menuItem)
	{
	}

	[Token(Token = "0x6003B2F")]
	[Address(RVA = "0xB59470", Offset = "0xB58270", Length = "0x12A")]
	private void PlayDeselectedAnimation(AnimMenuItems menuItem)
	{
	}

	[Token(Token = "0x6003B30")]
	[Address(RVA = "0xB595A0", Offset = "0xB583A0", Length = "0x32A")]
	private void UpdateAnimation()
	{
	}

	[Token(Token = "0x6003B31")]
	[Address(RVA = "0xB598D0", Offset = "0xB586D0", Length = "0x15A")]
	public Panel_SaveStory()
	{
	}
}
