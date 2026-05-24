using System;
using System.Collections.Generic;
using Cpp2ILInjected;

namespace UnityEngine.Rendering.PostProcessing;

[Token(Token = "0x2000CE4")]
public sealed class PostProcessManager
{
	[Token(Token = "0x4007FC0")]
	private static PostProcessManager s_Instance;

	[Token(Token = "0x4007FC1")]
	public static bool s_GlobalVolumesOptimizationEnabled;

	[Token(Token = "0x4007FC2")]
	private static int s_SettingsHasChangedFrameCount;

	[Token(Token = "0x4007FC3")]
	private static bool s_SettingsHasChanged;

	[Token(Token = "0x4007FC4")]
	private static int s_LastUpdatedFrameCount;

	[Token(Token = "0x4007FC5")]
	private const int k_MaxLayerCount = 32;

	[Token(Token = "0x4007FC6")]
	[FieldOffset(Offset = "0x10")]
	private readonly Dictionary<int, List<PostProcessVolume>> m_SortedVolumes;

	[Token(Token = "0x4007FC7")]
	[FieldOffset(Offset = "0x18")]
	private readonly List<PostProcessVolume> m_Volumes;

	[Token(Token = "0x4007FC8")]
	[FieldOffset(Offset = "0x20")]
	private readonly Dictionary<int, bool> m_SortNeeded;

	[Token(Token = "0x4007FC9")]
	[FieldOffset(Offset = "0x28")]
	private readonly List<PostProcessEffectSettings> m_BaseSettings;

	[Token(Token = "0x4007FCA")]
	[FieldOffset(Offset = "0x30")]
	private readonly List<Collider> m_TempColliders;

	[Token(Token = "0x4007FCB")]
	[FieldOffset(Offset = "0x38")]
	public readonly Dictionary<Type, PostProcessAttribute> settingsTypes;

	[Token(Token = "0x170006CF")]
	public static PostProcessManager instance
	{
		[Token(Token = "0x60065EE")]
		[Address(RVA = "0x1020730", Offset = "0x101F530", Length = "0x11B")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60065EF")]
	[Address(RVA = "0x1020850", Offset = "0x101F650", Length = "0xEA")]
	public static void MarkSettingsChanged()
	{
	}

	[Token(Token = "0x60065F0")]
	[Address(RVA = "0x1020940", Offset = "0x101F740", Length = "0x97")]
	public static void PostLateUpdate()
	{
	}

	[Token(Token = "0x60065F1")]
	[Address(RVA = "0x10209E0", Offset = "0x101F7E0", Length = "0x447")]
	private PostProcessManager()
	{
	}

	[Token(Token = "0x60065F2")]
	[Address(RVA = "0x1020E30", Offset = "0x101FC30", Length = "0x1E2")]
	private void CleanBaseTypes()
	{
	}

	[Token(Token = "0x60065F3")]
	[Address(RVA = "0x1021020", Offset = "0x101FE20", Length = "0x62D")]
	private void ReloadBaseTypes()
	{
	}

	[Token(Token = "0x60065F4")]
	[Address(RVA = "0x1021650", Offset = "0x1020450", Length = "0x844")]
	public void GetActiveVolumes(PostProcessLayer layer, List<PostProcessVolume> results, bool skipDisabled = true, bool skipZeroWeight = true)
	{
	}

	[Token(Token = "0x60065F5")]
	[Address(RVA = "0x1021EA0", Offset = "0x1020CA0", Length = "0x11E")]
	public PostProcessVolume GetHighestPriorityVolume(PostProcessLayer layer)
	{
		return null;
	}

	[Token(Token = "0x60065F6")]
	[Address(RVA = "0x1021FC0", Offset = "0x1020DC0", Length = "0x1DB")]
	public PostProcessVolume GetHighestPriorityVolume(LayerMask mask)
	{
		return null;
	}

	[Token(Token = "0x60065F7")]
	[Address(RVA = "0x10221A0", Offset = "0x1020FA0", Length = "0x28A")]
	public PostProcessVolume QuickVolume(int layer, float priority, params PostProcessEffectSettings[] settings)
	{
		return null;
	}

	[Token(Token = "0x60065F8")]
	[Address(RVA = "0x1022430", Offset = "0x1021230", Length = "0x1C9")]
	internal void SetLayerDirty(int layer)
	{
	}

	[Token(Token = "0x60065F9")]
	[Address(RVA = "0x1022600", Offset = "0x1021400", Length = "0x51")]
	internal void UpdateVolumeLayer(PostProcessVolume volume, int prevLayer, int newLayer)
	{
	}

	[Token(Token = "0x60065FA")]
	[Address(RVA = "0x1022660", Offset = "0x1021460", Length = "0x245")]
	private void Register(PostProcessVolume volume, int layer)
	{
	}

	[Token(Token = "0x60065FB")]
	[Address(RVA = "0x10228B0", Offset = "0x10216B0", Length = "0xD4")]
	internal void Register(PostProcessVolume volume)
	{
	}

	[Token(Token = "0x60065FC")]
	[Address(RVA = "0x1022990", Offset = "0x1021790", Length = "0x1F0")]
	private void Unregister(PostProcessVolume volume, int layer)
	{
	}

	[Token(Token = "0x60065FD")]
	[Address(RVA = "0x1022B90", Offset = "0x1021990", Length = "0xE0")]
	internal void Unregister(PostProcessVolume volume)
	{
	}

	[Token(Token = "0x60065FE")]
	[Address(RVA = "0x1022C80", Offset = "0x1021A80", Length = "0x2DA")]
	private void ReplaceData(PostProcessLayer postProcessLayer)
	{
	}

	[Token(Token = "0x60065FF")]
	[Address(RVA = "0x1022F60", Offset = "0x1021D60", Length = "0x1B5")]
	public void EnableAO(bool enabled)
	{
	}

	[Token(Token = "0x6006600")]
	[Address(RVA = "0x1023120", Offset = "0x1021F20", Length = "0xA0A")]
	internal void UpdateSettings(PostProcessLayer postProcessLayer, Camera camera)
	{
	}

	[Token(Token = "0x6006601")]
	[Address(RVA = "0x1023B30", Offset = "0x1022930", Length = "0x593")]
	private List<PostProcessVolume> GrabVolumes(LayerMask mask)
	{
		return null;
	}

	[Token(Token = "0x6006602")]
	[Address(RVA = "0x10240D0", Offset = "0x1022ED0", Length = "0x15B")]
	private static void SortByPriority(List<PostProcessVolume> volumes)
	{
	}

	[Token(Token = "0x6006603")]
	[Address(RVA = "0x430B50", Offset = "0x42F950", Length = "0x3")]
	private static bool IsVolumeRenderedByCamera(PostProcessVolume volume, Camera camera)
	{
		return false;
	}
}
