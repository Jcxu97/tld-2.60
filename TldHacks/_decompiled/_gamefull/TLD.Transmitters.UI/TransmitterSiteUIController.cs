using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using InteractiveObjects;
using TLD.Scenes;
using UnityEngine;
using UnityEngine.Pool;
using UnityEngine.ResourceManagement.AsyncOperations;

namespace TLD.Transmitters.UI;

[Token(Token = "0x20013EB")]
public class TransmitterSiteUIController : MonoBehaviour
{
	[CompilerGenerated]
	[Token(Token = "0x20013ED")]
	private sealed class _003CResetSliderWhenAvailable_003Ed__35 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40091D7")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x40091D8")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x40091D9")]
		[FieldOffset(Offset = "0x20")]
		public TransmitterSiteUIController _003C_003E4__this;

		[Token(Token = "0x40091DA")]
		[FieldOffset(Offset = "0x28")]
		public int numberOfSteps;

		[Token(Token = "0x17000AD6")]
		object IEnumerator<object>.Current
		{
			[DebuggerHidden]
			[Token(Token = "0x6007F10")]
			[Address(RVA = "0x4571D0", Offset = "0x455FD0", Length = "0x5")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000AD7")]
		object IEnumerator.Current
		{
			[DebuggerHidden]
			[Token(Token = "0x6007F12")]
			[Address(RVA = "0x4571D0", Offset = "0x455FD0", Length = "0x5")]
			get
			{
				return null;
			}
		}

		[DebuggerHidden]
		[Token(Token = "0x6007F0D")]
		[Address(RVA = "0x4096E0", Offset = "0x4084E0", Length = "0x4")]
		public _003CResetSliderWhenAvailable_003Ed__35(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		[Token(Token = "0x6007F0E")]
		[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
		void IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6007F0F")]
		[Address(RVA = "0x11ED980", Offset = "0x11EC780", Length = "0x21B")]
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
		[Token(Token = "0x6007F11")]
		[Address(RVA = "0x11EDBA0", Offset = "0x11EC9A0", Length = "0x3E")]
		void IEnumerator.Reset()
		{
		}
	}

	[SerializeField]
	[Token(Token = "0x40091C8")]
	[FieldOffset(Offset = "0x20")]
	private WorldMapChangedEvent m_WorldMapChanged;

	[SerializeField]
	[Token(Token = "0x40091C9")]
	[FieldOffset(Offset = "0x28")]
	private GameObject m_ListParent;

	[SerializeField]
	[Token(Token = "0x40091CA")]
	[FieldOffset(Offset = "0x30")]
	private GameObject m_ListScrollbar;

	[SerializeField]
	[Token(Token = "0x40091CB")]
	[FieldOffset(Offset = "0x38")]
	private GameObject m_MapsParent;

	[SerializeField]
	[Token(Token = "0x40091CC")]
	[FieldOffset(Offset = "0x40")]
	private TransmitterSiteListItem m_ListItemPrefab;

	[SerializeField]
	[Token(Token = "0x40091CD")]
	[FieldOffset(Offset = "0x48")]
	private UIGrid m_ListGrid;

	[SerializeField]
	[Token(Token = "0x40091CE")]
	[FieldOffset(Offset = "0x50")]
	private UIPanel m_ListPanel;

	[SerializeField]
	[Token(Token = "0x40091CF")]
	[FieldOffset(Offset = "0x58")]
	private UIScrollView m_ListScroll;

	[Token(Token = "0x40091D0")]
	[FieldOffset(Offset = "0x60")]
	private UISlider m_ListSlider;

	[Token(Token = "0x40091D1")]
	[FieldOffset(Offset = "0x68")]
	private int m_LastListIndex;

	[Token(Token = "0x40091D2")]
	[FieldOffset(Offset = "0x70")]
	private ObjectPool<TransmitterSiteListItem> m_ListItemPool;

	[Token(Token = "0x40091D3")]
	[FieldOffset(Offset = "0x78")]
	private readonly List<TransmitterSiteListItem> m_ActiveListItems;

	[Token(Token = "0x40091D4")]
	[FieldOffset(Offset = "0x80")]
	private readonly List<TransmitterSiteWorldMap> m_WorldMaps;

	[Token(Token = "0x40091D5")]
	[FieldOffset(Offset = "0x88")]
	private readonly Dictionary<TransmitterData, AsyncOperationHandle<GameObject>> m_MapItems;

	[Token(Token = "0x6007EF4")]
	[Address(RVA = "0x11EA280", Offset = "0x11E9080", Length = "0x369")]
	private void Awake()
	{
	}

	[Token(Token = "0x6007EF5")]
	[Address(RVA = "0x11EA5F0", Offset = "0x11E93F0", Length = "0x2D3")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6007EF6")]
	[Address(RVA = "0x11EA8D0", Offset = "0x11E96D0", Length = "0x3AF")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6007EF7")]
	[Address(RVA = "0x11EAC80", Offset = "0x11E9A80", Length = "0x296")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6007EF8")]
	[Address(RVA = "0x11EAF20", Offset = "0x11E9D20", Length = "0x1FC")]
	public void HandleControlInputs(Panel_Log owner)
	{
	}

	[Token(Token = "0x6007EF9")]
	[Address(RVA = "0x11EB120", Offset = "0x11E9F20", Length = "0x1DB")]
	public void OnScrollbarChanged()
	{
	}

	[Token(Token = "0x6007EFA")]
	[Address(RVA = "0x11EB300", Offset = "0x11EA100", Length = "0x26B")]
	public void SelectNextAvailableWorldMap()
	{
	}

	[Token(Token = "0x6007EFB")]
	[Address(RVA = "0x11EB570", Offset = "0x11EA370", Length = "0x2B4")]
	private void SetupTransmitterSites()
	{
	}

	[Token(Token = "0x6007EFC")]
	[Address(RVA = "0x11EB830", Offset = "0x11EA630", Length = "0x210")]
	private Transform GetWorldMapParent(WorldMapSpecification worldMap)
	{
		return null;
	}

	[Token(Token = "0x6007EFD")]
	[Address(RVA = "0x11EBA50", Offset = "0x11EA850", Length = "0x59B")]
	private void MaybeSetupTransmitterMapItem(TransmitterData transmitter)
	{
	}

	[Token(Token = "0x6007EFE")]
	[Address(RVA = "0x11EBFF0", Offset = "0x11EADF0", Length = "0x37F")]
	private void SetupSliderSettings()
	{
	}

	[Token(Token = "0x6007EFF")]
	[Address(RVA = "0x11EC370", Offset = "0x11EB170", Length = "0x1AB")]
	private void ResetListPanelClipping()
	{
	}

	[Token(Token = "0x6007F00")]
	[Address(RVA = "0x11EC520", Offset = "0x11EB320", Length = "0x21C")]
	private void UpdateScrollFromSmallMovement(float amount)
	{
	}

	[Token(Token = "0x6007F01")]
	[Address(RVA = "0x11EC740", Offset = "0x11EB540", Length = "0x408")]
	private static int SortListItems(Transform x, Transform y)
	{
		return 0;
	}

	[Token(Token = "0x6007F02")]
	[Address(RVA = "0x11ECB50", Offset = "0x11EB950", Length = "0x2B8")]
	private void SetWorldMapBasedOnCurrentRegionAsync()
	{
	}

	[Token(Token = "0x6007F03")]
	[Address(RVA = "0x11ECE10", Offset = "0x11EBC10", Length = "0x160")]
	private void OnCurrentZoneLoaded(AsyncOperationHandle<ZoneSpecification> zoneOp)
	{
	}

	[Token(Token = "0x6007F04")]
	[Address(RVA = "0x11ECF80", Offset = "0x11EBD80", Length = "0x39C")]
	private void OnWorldMapChanged()
	{
	}

	[Token(Token = "0x6007F05")]
	[Address(RVA = "0x11ED320", Offset = "0x11EC120", Length = "0xBF")]
	private TransmitterSiteListItem CreateListItem()
	{
		return null;
	}

	[Token(Token = "0x6007F06")]
	[Address(RVA = "0x11ED3E0", Offset = "0x11EC1E0", Length = "0xEB")]
	private void OnGetListItem(TransmitterSiteListItem obj)
	{
	}

	[Token(Token = "0x6007F07")]
	[Address(RVA = "0x11ED4D0", Offset = "0x11EC2D0", Length = "0x68")]
	private void OnReleaseItem(TransmitterSiteListItem obj)
	{
	}

	[Token(Token = "0x6007F08")]
	[Address(RVA = "0x11ED540", Offset = "0x11EC340", Length = "0x9F")]
	private void OnDestroyItem(TransmitterSiteListItem obj)
	{
	}

	[IteratorStateMachine(typeof(_003CResetSliderWhenAvailable_003Ed__35))]
	[Token(Token = "0x6007F09")]
	[Address(RVA = "0x11ED5E0", Offset = "0x11EC3E0", Length = "0xB0")]
	private IEnumerator ResetSliderWhenAvailable(int numberOfSteps)
	{
		return null;
	}

	[Token(Token = "0x6007F0A")]
	[Address(RVA = "0x11ED690", Offset = "0x11EC490", Length = "0x21F")]
	public TransmitterSiteUIController()
	{
	}
}
