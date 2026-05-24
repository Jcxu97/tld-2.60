using System;
using System.Collections.Generic;
using System.Text;
using AK.Wwise;
using Cpp2ILInjected;
using TLD.Audio;
using TLD.GameplayTags;
using TLD.Logging;
using TLD.UI.Generics;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.PostProcessing;

[Token(Token = "0x20007D1")]
public class SafehouseManager : MonoBehaviour
{
	[Header("Audio")]
	[SerializeField]
	[Token(Token = "0x40053E0")]
	[FieldOffset(Offset = "0x20")]
	private AK.Wwise.Event m_DestroyEvent;

	[SerializeField]
	[Token(Token = "0x40053E1")]
	[FieldOffset(Offset = "0x28")]
	private AK.Wwise.Event m_DropEvent;

	[SerializeField]
	[Token(Token = "0x40053E2")]
	[FieldOffset(Offset = "0x30")]
	private AK.Wwise.Event m_PickUpEvent;

	[SerializeField]
	[Token(Token = "0x40053E3")]
	[FieldOffset(Offset = "0x38")]
	private AK.Wwise.Event m_PlaceEvent;

	[SerializeField]
	[Token(Token = "0x40053E4")]
	[FieldOffset(Offset = "0x40")]
	private AK.Wwise.Event m_StowEvent;

	[SerializeField]
	[Token(Token = "0x40053E5")]
	[FieldOffset(Offset = "0x48")]
	private AK.Wwise.Event m_ContainerAddEvent;

	[SerializeField]
	[Token(Token = "0x40053E6")]
	[FieldOffset(Offset = "0x50")]
	private AK.Wwise.Event m_ContainerCreateEvent;

	[SerializeField]
	[Token(Token = "0x40053E7")]
	[FieldOffset(Offset = "0x58")]
	private AK.Wwise.Event m_ContainerDestroyEvent;

	[SerializeField]
	[Token(Token = "0x40053E8")]
	[FieldOffset(Offset = "0x60")]
	private AudioMaterialTagMapping m_SurfaceTagMapping;

	[Token(Token = "0x40053E9")]
	public static bool s_ShowDebugInfo;

	[Token(Token = "0x40053EA")]
	private static bool s_FeatureEnabled;

	[Token(Token = "0x40053EB")]
	private static readonly LogFilter s_LogFilter;

	[Token(Token = "0x40053EC")]
	private static readonly string START_PROFILE_SAMPLE;

	[Token(Token = "0x40053ED")]
	private static readonly string STOP_PROFILE_SAMPLE;

	[SerializeField]
	[Token(Token = "0x40053EE")]
	[FieldOffset(Offset = "0x68")]
	private PanelReference<Panel_ActionsRadial> m_ActionsRadial;

	[Token(Token = "0x40053EF")]
	[FieldOffset(Offset = "0x70")]
	public Action OnStartCustomization;

	[Token(Token = "0x40053F0")]
	[FieldOffset(Offset = "0x78")]
	public Action OnStopCustomization;

	[SerializeField]
	[Token(Token = "0x40053F1")]
	[FieldOffset(Offset = "0x80")]
	private GameplayTag m_SafehouseSupportedTag;

	[SerializeField]
	[Token(Token = "0x40053F2")]
	[FieldOffset(Offset = "0x90")]
	private PlatformUnsignedIntegerValue m_DecorationLimit;

	[SerializeField]
	[Token(Token = "0x40053F3")]
	[FieldOffset(Offset = "0x98")]
	private uint m_AbsoluteDecorationLimit;

	[Header("Panel References")]
	[SerializeField]
	[Token(Token = "0x40053F4")]
	[FieldOffset(Offset = "0xA0")]
	private PanelReference<Panel_HUD> m_HUD;

	[Token(Token = "0x40053F5")]
	private static List<Collider> s_SafehouseIndoorSpaceTriggerColliders;

	[Token(Token = "0x40053F7")]
	[FieldOffset(Offset = "0xB4")]
	private bool m_IsCustomizing;

	[Token(Token = "0x40053F8")]
	[FieldOffset(Offset = "0xB8")]
	private StringBuilder m_DebugStringBuilder;

	[Token(Token = "0x40053F9")]
	[FieldOffset(Offset = "0xC0")]
	private Vector3 m_LastPlayerVelocity;

	[Token(Token = "0x40053FA")]
	[FieldOffset(Offset = "0xCC")]
	private Vector3 m_LastPlayerPosition;

	[Header("Rendering")]
	[SerializeField]
	[Token(Token = "0x40053FB")]
	[FieldOffset(Offset = "0xD8")]
	private Color m_OutlineColor;

	[SerializeField]
	[Token(Token = "0x40053FC")]
	[FieldOffset(Offset = "0xE8")]
	private float m_OutlineThickness;

	[SerializeField]
	[Token(Token = "0x40053FD")]
	[FieldOffset(Offset = "0xEC")]
	private Color m_OnHoverColor;

	[SerializeField]
	[Range(0f, 1f)]
	[Token(Token = "0x40053FE")]
	[FieldOffset(Offset = "0xFC")]
	private float m_OnHoverGlowScalar;

	[Token(Token = "0x40053FF")]
	[FieldOffset(Offset = "0x100")]
	private MaterialPropertyBlock m_OnHoverPropertyBlock;

	[Token(Token = "0x4005400")]
	[FieldOffset(Offset = "0x108")]
	private MaterialPropertyBlock m_OutlinePropertyBlock;

	[Token(Token = "0x4005401")]
	[FieldOffset(Offset = "0x110")]
	private PropertySheet m_PropertySheet;

	[Token(Token = "0x4005402")]
	[FieldOffset(Offset = "0x118")]
	private CommandBuffer m_CommandBuffer;

	[Token(Token = "0x4005403")]
	private static readonly int s_OutlineColorID;

	[Token(Token = "0x4005404")]
	private static readonly int s_OutlineThicknessID;

	[Token(Token = "0x4005405")]
	private static readonly int s_GBuffer2ID;

	[Token(Token = "0x4005406")]
	private static readonly int s_TransferTextureID;

	[Token(Token = "0x17000340")]
	public static bool FeatureEnabled
	{
		[Token(Token = "0x60049DD")]
		[Address(RVA = "0xD28490", Offset = "0xD27290", Length = "0x54")]
		get
		{
			return false;
		}
	}

	[Token(Token = "0x17000341")]
	public Vector3 LastPlayerVelocity
	{
		[Token(Token = "0x60049DE")]
		[Address(RVA = "0xD284F0", Offset = "0xD272F0", Length = "0x19")]
		get
		{
			return default(Vector3);
		}
	}

	[Token(Token = "0x17000342")]
	public Vector3 LastPlayerPosition
	{
		[Token(Token = "0x60049DF")]
		[Address(RVA = "0xD28510", Offset = "0xD27310", Length = "0x19")]
		get
		{
			return default(Vector3);
		}
	}

	[Token(Token = "0x17000343")]
	[field: Token(Token = "0x40053F6")]
	[field: FieldOffset(Offset = "0xA8")]
	public Vector3 LastPositionInsideInterior
	{
		[Token(Token = "0x60049E0")]
		[Address(RVA = "0xD28530", Offset = "0xD27330", Length = "0x19")]
		get;
		[Token(Token = "0x60049E1")]
		[Address(RVA = "0xD28550", Offset = "0xD27350", Length = "0x16")]
		private set;
	}

	[Token(Token = "0x60049D4")]
	[Address(RVA = "0xD27B90", Offset = "0xD26990", Length = "0x8F")]
	public void PlayContainerAddAudio()
	{
	}

	[Token(Token = "0x60049D5")]
	[Address(RVA = "0xD27C20", Offset = "0xD26A20", Length = "0x8F")]
	public void PlayContainerCreateAudio()
	{
	}

	[Token(Token = "0x60049D6")]
	[Address(RVA = "0xD27CB0", Offset = "0xD26AB0", Length = "0x8F")]
	public void PlayContainerDestroyAudio()
	{
	}

	[Token(Token = "0x60049D7")]
	[Address(RVA = "0xD27D40", Offset = "0xD26B40", Length = "0xE8")]
	public void PlayDestroyAudio(DecorationItem di)
	{
	}

	[Token(Token = "0x60049D8")]
	[Address(RVA = "0xD27E30", Offset = "0xD26C30", Length = "0xEB")]
	public void PlayDropAudio(DecorationItem di)
	{
	}

	[Token(Token = "0x60049D9")]
	[Address(RVA = "0xD27F20", Offset = "0xD26D20", Length = "0xEB")]
	public void PlayPickupAudio(DecorationItem di)
	{
	}

	[Token(Token = "0x60049DA")]
	[Address(RVA = "0xD28010", Offset = "0xD26E10", Length = "0xFA")]
	public void PlayPlaceAudio(DecorationItem di, string surfaceTag)
	{
	}

	[Token(Token = "0x60049DB")]
	[Address(RVA = "0xD28110", Offset = "0xD26F10", Length = "0xEB")]
	public void PlayStowAudio(DecorationItem di)
	{
	}

	[Token(Token = "0x60049DC")]
	[Address(RVA = "0xD28200", Offset = "0xD27000", Length = "0x289")]
	private void PlayAudioEvent(AK.Wwise.Event commonEvent, AK.Wwise.Event overrideEvent, DecorationItem di, string surfaceTag = null)
	{
	}

	[Token(Token = "0x60049E2")]
	[Address(RVA = "0xD28570", Offset = "0xD27370", Length = "0x1BB")]
	public uint GetDecorationMaximum()
	{
		return 0u;
	}

	[Token(Token = "0x60049E3")]
	[Address(RVA = "0xD28730", Offset = "0xD27530", Length = "0x7")]
	private void Awake()
	{
	}

	[Token(Token = "0x60049E4")]
	[Address(RVA = "0xD28740", Offset = "0xD27540", Length = "0x1B9")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x60049E5")]
	[Address(RVA = "0xD28900", Offset = "0xD27700", Length = "0xCC")]
	public void ShowSafehouseExit(Panel_Confirmation.CallbackDelegate confirmCallback)
	{
	}

	[Token(Token = "0x60049E6")]
	[Address(RVA = "0xD289D0", Offset = "0xD277D0", Length = "0x2AF")]
	public void ConfirmSafehouseExit(Panel_Confirmation.CallbackDelegate confirmCallback, Panel_Confirmation.EnableDelegate cancelCallback = null)
	{
	}

	[Token(Token = "0x60049E7")]
	[Address(RVA = "0xD28C80", Offset = "0xD27A80", Length = "0x35E")]
	public bool InCustomizableSafehouse()
	{
		return false;
	}

	[Token(Token = "0x60049E8")]
	[Address(RVA = "0x5DD360", Offset = "0x5DC160", Length = "0x8")]
	public bool IsCustomizing()
	{
		return false;
	}

	[Token(Token = "0x60049E9")]
	[Address(RVA = "0xD28FE0", Offset = "0xD27DE0", Length = "0x16F")]
	public void MaybeToggleCustomizing()
	{
	}

	[Token(Token = "0x60049EA")]
	[Address(RVA = "0xD29150", Offset = "0xD27F50", Length = "0x1CD")]
	public bool TryStartCustomizing()
	{
		return false;
	}

	[Token(Token = "0x60049EB")]
	[Address(RVA = "0xD29320", Offset = "0xD28120", Length = "0x79")]
	public bool TryStopCustomizing()
	{
		return false;
	}

	[Token(Token = "0x60049EC")]
	[Address(RVA = "0xD293A0", Offset = "0xD281A0", Length = "0x96")]
	private bool IsWildlifeThreatening()
	{
		return false;
	}

	[Token(Token = "0x60049ED")]
	[Address(RVA = "0xD29440", Offset = "0xD28240", Length = "0x196")]
	private void Update()
	{
	}

	[Token(Token = "0x60049EE")]
	[Address(RVA = "0xD295E0", Offset = "0xD283E0", Length = "0x74B")]
	private void MaybeUpdateLastSafePosition()
	{
	}

	[Token(Token = "0x60049EF")]
	[Address(RVA = "0xD29D30", Offset = "0xD28B30", Length = "0x358")]
	private void StartCustomizing()
	{
	}

	[Token(Token = "0x60049F0")]
	[Address(RVA = "0xD2A090", Offset = "0xD28E90", Length = "0x111")]
	private void StopCustomizing()
	{
	}

	[Token(Token = "0x60049F1")]
	[Address(RVA = "0x4A2140", Offset = "0x4A0F40", Length = "0x3")]
	public static bool IsLimitSupported()
	{
		return false;
	}

	[Token(Token = "0x60049F2")]
	[Address(RVA = "0xD2A1B0", Offset = "0xD28FB0", Length = "0xD1")]
	public static void SetFeatureEnabled(bool enabled)
	{
	}

	[Token(Token = "0x60049F3")]
	[Address(RVA = "0xD2A290", Offset = "0xD29090", Length = "0x828")]
	public static bool IsDecorationItemInsideSafehouse(DecorationItem item)
	{
		return false;
	}

	[Token(Token = "0x60049F4")]
	[Address(RVA = "0xD2AAC0", Offset = "0xD298C0", Length = "0x26D")]
	public string GetDebugText()
	{
		return null;
	}

	[Token(Token = "0x60049F5")]
	[Address(RVA = "0xD2AD30", Offset = "0xD29B30", Length = "0x65")]
	public void ApplyOnHoverPropertyBlock(List<Renderer> renderers)
	{
	}

	[Token(Token = "0x60049F6")]
	[Address(RVA = "0xD2ADA0", Offset = "0xD29BA0", Length = "0x65")]
	public void ApplyOutlinePropertyBlock(List<Renderer> renderers)
	{
	}

	[Token(Token = "0x60049F7")]
	[Address(RVA = "0xD2AE10", Offset = "0xD29C10", Length = "0x87")]
	public void DisableOutlinePropertyBlock(List<Renderer> renderers)
	{
	}

	[Token(Token = "0x60049F8")]
	[Address(RVA = "0xD2AEA0", Offset = "0xD29CA0", Length = "0x442")]
	private void InitializeRendering()
	{
	}

	[Token(Token = "0x60049F9")]
	[Address(RVA = "0xD2B2F0", Offset = "0xD2A0F0", Length = "0x109")]
	private void CleanupRendering()
	{
	}

	[Token(Token = "0x60049FA")]
	[Address(RVA = "0xD2B400", Offset = "0xD2A200", Length = "0x711")]
	private void EnableOutlineRendering()
	{
	}

	[Token(Token = "0x60049FB")]
	[Address(RVA = "0xD2BB20", Offset = "0xD2A920", Length = "0x79")]
	private void DisableOutlineRendering()
	{
	}

	[Token(Token = "0x60049FC")]
	[Address(RVA = "0xD2BBA0", Offset = "0xD2A9A0", Length = "0x30E")]
	private void MaybeInitializeCommandBuffer()
	{
	}

	[Token(Token = "0x60049FD")]
	[Address(RVA = "0xD2BEB0", Offset = "0xD2ACB0", Length = "0x19")]
	private bool IsInitializedForRendering()
	{
		return false;
	}

	[Token(Token = "0x60049FE")]
	[Address(RVA = "0xD2BED0", Offset = "0xD2ACD0", Length = "0x168")]
	public SafehouseManager()
	{
	}
}
