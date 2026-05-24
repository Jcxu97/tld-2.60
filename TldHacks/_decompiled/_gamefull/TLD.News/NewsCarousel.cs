using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using TLD.Logging;
using TLD.OptionalContent;
using UnityEngine;

namespace TLD.News;

[Token(Token = "0x2001381")]
public class NewsCarousel : MonoBehaviour
{
	[Token(Token = "0x2001382")]
	private enum NewsState
	{
		[Token(Token = "0x4008F76")]
		Uninitialized,
		[Token(Token = "0x4008F77")]
		FetchingNews,
		[Token(Token = "0x4008F78")]
		LoadingItems,
		[Token(Token = "0x4008F79")]
		Ready,
		[Token(Token = "0x4008F7A")]
		Destroyed
	}

	[CompilerGenerated]
	[Token(Token = "0x2001385")]
	private sealed class _003CDownloadAllBackgrounds_003Ed__40 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4008F80")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4008F81")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4008F82")]
		[FieldOffset(Offset = "0x20")]
		public NewsCarousel _003C_003E4__this;

		[Token(Token = "0x17000A90")]
		object IEnumerator<object>.Current
		{
			[DebuggerHidden]
			[Token(Token = "0x6007CC4")]
			[Address(RVA = "0x4571D0", Offset = "0x455FD0", Length = "0x5")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000A91")]
		object IEnumerator.Current
		{
			[DebuggerHidden]
			[Token(Token = "0x6007CC6")]
			[Address(RVA = "0x4571D0", Offset = "0x455FD0", Length = "0x5")]
			get
			{
				return null;
			}
		}

		[DebuggerHidden]
		[Token(Token = "0x6007CC1")]
		[Address(RVA = "0x4096E0", Offset = "0x4084E0", Length = "0x4")]
		public _003CDownloadAllBackgrounds_003Ed__40(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		[Token(Token = "0x6007CC2")]
		[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
		void IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6007CC3")]
		[Address(RVA = "0x11BF470", Offset = "0x11BE270", Length = "0x346")]
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
		[Token(Token = "0x6007CC5")]
		[Address(RVA = "0x11BF7C0", Offset = "0x11BE5C0", Length = "0x3E")]
		void IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4008F58")]
	private const string SURVIVAL_SKU = "tld_survival";

	[Token(Token = "0x4008F59")]
	private const string TFTFT_SKU = "tld_tftft";

	[Token(Token = "0x4008F5A")]
	private const string COMPLETE_SKU = "tld_complete";

	[Token(Token = "0x4008F5B")]
	private static readonly LogFilter s_LogFilter;

	[Header("Configuration")]
	[SerializeField]
	[Token(Token = "0x4008F5C")]
	[FieldOffset(Offset = "0x20")]
	private float m_TimeBetweenItems;

	[Header("Item Roots")]
	[SerializeField]
	[Token(Token = "0x4008F5D")]
	[FieldOffset(Offset = "0x28")]
	private GameObject m_LoadingRoot;

	[SerializeField]
	[Token(Token = "0x4008F5E")]
	[FieldOffset(Offset = "0x30")]
	private GameObject m_FallbackRoot;

	[SerializeField]
	[Token(Token = "0x4008F5F")]
	[FieldOffset(Offset = "0x38")]
	private GameObject m_ItemRoot;

	[Header("Item Elements")]
	[SerializeField]
	[Token(Token = "0x4008F60")]
	[FieldOffset(Offset = "0x40")]
	private GameObject m_ItemTypeHeader;

	[SerializeField]
	[Token(Token = "0x4008F61")]
	[FieldOffset(Offset = "0x48")]
	private UITexture m_ItemBackground;

	[SerializeField]
	[Token(Token = "0x4008F62")]
	[FieldOffset(Offset = "0x50")]
	private UILabel m_ItemTitle;

	[SerializeField]
	[Token(Token = "0x4008F63")]
	[FieldOffset(Offset = "0x58")]
	private UILabel m_ItemBody;

	[SerializeField]
	[Token(Token = "0x4008F64")]
	[FieldOffset(Offset = "0x60")]
	private GameObject m_ItemSeeMoreButton;

	[SerializeField]
	[Token(Token = "0x4008F65")]
	[FieldOffset(Offset = "0x68")]
	private GameObject m_ItemStoreButton;

	[Header("Pips")]
	[SerializeField]
	[Token(Token = "0x4008F66")]
	[FieldOffset(Offset = "0x70")]
	private GameObject m_PipRoot;

	[SerializeField]
	[Token(Token = "0x4008F67")]
	[FieldOffset(Offset = "0x78")]
	private List<UIButton> m_Pips;

	[SerializeField]
	[Token(Token = "0x4008F68")]
	[FieldOffset(Offset = "0x80")]
	private Color m_ActivePipColor;

	[SerializeField]
	[Token(Token = "0x4008F69")]
	[FieldOffset(Offset = "0x90")]
	private Color m_InactivePipColor;

	[SerializeField]
	[Token(Token = "0x4008F6A")]
	[FieldOffset(Offset = "0xA0")]
	private float m_PipSpacing;

	[SerializeField]
	[Token(Token = "0x4008F6B")]
	[FieldOffset(Offset = "0xA8")]
	private Transform m_LeftControllerButton;

	[SerializeField]
	[Token(Token = "0x4008F6C")]
	[FieldOffset(Offset = "0xB0")]
	private Transform m_RightControllerButton;

	[Header("Optional Content Configs")]
	[SerializeField]
	[Token(Token = "0x4008F6D")]
	[FieldOffset(Offset = "0xB8")]
	private OptionalContentConfig m_ExpansionPassConfig;

	[SerializeField]
	[Token(Token = "0x4008F6E")]
	[FieldOffset(Offset = "0xC0")]
	private OptionalContentConfig m_WintermuteConfig;

	[Token(Token = "0x4008F6F")]
	[FieldOffset(Offset = "0xC8")]
	private NewsProvider m_News;

	[Token(Token = "0x4008F70")]
	[FieldOffset(Offset = "0xD0")]
	private NewsState m_NewsState;

	[Token(Token = "0x4008F71")]
	[FieldOffset(Offset = "0xD8")]
	private List<string> m_ActiveBackgroundDownloads;

	[Token(Token = "0x4008F72")]
	[FieldOffset(Offset = "0xE0")]
	private bool m_IsActive;

	[Token(Token = "0x4008F73")]
	[FieldOffset(Offset = "0xE4")]
	private float m_NextItemTimer;

	[Token(Token = "0x4008F74")]
	[FieldOffset(Offset = "0xE8")]
	private int m_CurrentItemIndex;

	[Token(Token = "0x6007CA1")]
	[Address(RVA = "0x11BC810", Offset = "0x11BB610", Length = "0x76")]
	private void Awake()
	{
	}

	[Token(Token = "0x6007CA2")]
	[Address(RVA = "0x11BC890", Offset = "0x11BB690", Length = "0x1C7")]
	private void SetupPipClick(int index)
	{
	}

	[Token(Token = "0x6007CA3")]
	[Address(RVA = "0x11BCA60", Offset = "0x11BB860", Length = "0x20")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6007CA4")]
	[Address(RVA = "0x11BCA80", Offset = "0x11BB880", Length = "0x7")]
	public void SetActive(bool isActive)
	{
	}

	[Token(Token = "0x6007CA5")]
	[Address(RVA = "0x11BCA90", Offset = "0x11BB890", Length = "0x199")]
	public void UpdateCarousel()
	{
	}

	[Token(Token = "0x6007CA6")]
	[Address(RVA = "0x11BCC30", Offset = "0x11BBA30", Length = "0x7")]
	private void SetNewsState(NewsState state)
	{
	}

	[Token(Token = "0x6007CA7")]
	[Address(RVA = "0x11BCC40", Offset = "0x11BBA40", Length = "0x17B")]
	private void WaitForInitialization()
	{
	}

	[Token(Token = "0x6007CA8")]
	[Address(RVA = "0x11BCDC0", Offset = "0x11BBBC0", Length = "0x3CC")]
	private void RetrieveNewsFromServer()
	{
	}

	[Token(Token = "0x6007CA9")]
	[Address(RVA = "0x11BD190", Offset = "0x11BBF90", Length = "0xF3")]
	private string GetSKU()
	{
		return null;
	}

	[Token(Token = "0x6007CAA")]
	[Address(RVA = "0x11BD290", Offset = "0x11BC090", Length = "0x18F")]
	private void FinishNewsFetching(string newsJson)
	{
	}

	[IteratorStateMachine(typeof(_003CDownloadAllBackgrounds_003Ed__40))]
	[Token(Token = "0x6007CAB")]
	[Address(RVA = "0x11BD420", Offset = "0x11BC220", Length = "0x9A")]
	private IEnumerator DownloadAllBackgrounds()
	{
		return null;
	}

	[Token(Token = "0x6007CAC")]
	[Address(RVA = "0x11BD4C0", Offset = "0x11BC2C0", Length = "0x2DD")]
	private void DownloadTexture(NewsItem newsItem, string url)
	{
	}

	[Token(Token = "0x6007CAD")]
	[Address(RVA = "0x11BD7A0", Offset = "0x11BC5A0", Length = "0xA3")]
	private void FinishSettingUpNews()
	{
	}

	[Token(Token = "0x6007CAE")]
	[Address(RVA = "0x11BD850", Offset = "0x11BC650", Length = "0x58B")]
	private void SetupPips(int count)
	{
	}

	[Token(Token = "0x6007CAF")]
	[Address(RVA = "0x11BDDE0", Offset = "0x11BCBE0", Length = "0x400")]
	private void UpdateActiveCarousel()
	{
	}

	[Token(Token = "0x6007CB0")]
	[Address(RVA = "0x11BE1F0", Offset = "0x11BCFF0", Length = "0x63")]
	private void OnPipButtonClicked(int index)
	{
	}

	[Token(Token = "0x6007CB1")]
	[Address(RVA = "0x11BE260", Offset = "0x11BD060", Length = "0x122")]
	public void OnItemButtonClicked()
	{
	}

	[Token(Token = "0x6007CB2")]
	[Address(RVA = "0x11BE390", Offset = "0x11BD190", Length = "0x8B")]
	private void MoveToNextItem()
	{
	}

	[Token(Token = "0x6007CB3")]
	[Address(RVA = "0x11BE420", Offset = "0x11BD220", Length = "0x85")]
	private void MoveToPreviousItem()
	{
	}

	[Token(Token = "0x6007CB4")]
	[Address(RVA = "0x11BE4B0", Offset = "0x11BD2B0", Length = "0x2AC")]
	private void SetActiveItem(int index)
	{
	}

	[Token(Token = "0x6007CB5")]
	[Address(RVA = "0x11BE760", Offset = "0x11BD560", Length = "0x11E")]
	private void UpdateNewsItem(NewsItem item, bool isNew)
	{
	}

	[Token(Token = "0x6007CB6")]
	[Address(RVA = "0x11BE880", Offset = "0x11BD680", Length = "0x521")]
	private void ResetNews()
	{
	}

	[Token(Token = "0x6007CB7")]
	[Address(RVA = "0x11BEDB0", Offset = "0x11BDBB0", Length = "0x22D")]
	public NewsCarousel()
	{
	}
}
