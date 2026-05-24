using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.ResourceManagement.AsyncOperations;
using UnityEngine.ResourceManagement.ResourceProviders;

namespace TLD.Scenes;

[CreateAssetMenu(menuName = "The Long Dark/Scenes/Scene Set")]
[Token(Token = "0x2001362")]
public class SceneSet : ScriptableObject
{
	[SerializeField]
	[Token(Token = "0x4008EA5")]
	[FieldOffset(Offset = "0x18")]
	private LocalizedString m_SceneName;

	[SerializeField]
	[Token(Token = "0x4008EA6")]
	[FieldOffset(Offset = "0x20")]
	private bool m_IsOutdoors;

	[SerializeField]
	[Token(Token = "0x4008EA7")]
	[FieldOffset(Offset = "0x21")]
	private bool m_IsSafehouse;

	[SerializeField]
	[Token(Token = "0x4008EA8")]
	[FieldOffset(Offset = "0x28")]
	private RegionGroupSpecification m_RegionGroup;

	[SerializeField]
	[Token(Token = "0x4008EA9")]
	[FieldOffset(Offset = "0x30")]
	private AssetReference m_BaseScene;

	[SerializeField]
	[Token(Token = "0x4008EAA")]
	[FieldOffset(Offset = "0x38")]
	private List<AssetReference> m_AdditiveScenes;

	[SerializeField]
	[Token(Token = "0x4008EAB")]
	[FieldOffset(Offset = "0x40")]
	private List<ConditionalScene> m_ConditionalScenes;

	[SerializeField]
	[Token(Token = "0x4008EAC")]
	[FieldOffset(Offset = "0x48")]
	private List<SceneResolutionOverride> m_ResolutionOverrides;

	[NonSerialized]
	[Token(Token = "0x4008EAD")]
	[FieldOffset(Offset = "0x50")]
	private List<SceneSetExtension> m_Extensions;

	[Token(Token = "0x4008EAE")]
	[FieldOffset(Offset = "0x58")]
	public SceneWeatherOverrideData m_SceneWeatherOverrides;

	[Token(Token = "0x4008EAF")]
	[FieldOffset(Offset = "0x60")]
	public SceneDistanceFieldSettings m_SceneDistanceFieldSettings;

	[Token(Token = "0x4008EB0")]
	[FieldOffset(Offset = "0x68")]
	private ICollection<AsyncOperationHandle<SceneInstance>> m_LoadOperations;

	[Token(Token = "0x4008EB1")]
	[FieldOffset(Offset = "0x70")]
	private ICollection<SceneLoadCondition> m_Conditions;

	[Token(Token = "0x4008EB2")]
	[FieldOffset(Offset = "0x78")]
	private Action<ICollection<AsyncOperationHandle<SceneInstance>>> m_OnAllLoadsStarted;

	[Token(Token = "0x17000A5D")]
	public bool IsOutdoors
	{
		[Token(Token = "0x6007BBA")]
		[Address(RVA = "0x4D3E60", Offset = "0x4D2C60", Length = "0x5")]
		get
		{
			return false;
		}
	}

	[Token(Token = "0x17000A5E")]
	public string NameLocId
	{
		[Token(Token = "0x6007BBB")]
		[Address(RVA = "0x11A8400", Offset = "0x11A7200", Length = "0x1B")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000A5F")]
	public string LocalizedName
	{
		[Token(Token = "0x6007BBC")]
		[Address(RVA = "0xD90180", Offset = "0xD8EF80", Length = "0x5D")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000A60")]
	public bool ValidSafehouse
	{
		[Token(Token = "0x6007BBD")]
		[Address(RVA = "0x11A8A60", Offset = "0x11A7860", Length = "0xE")]
		get
		{
			return false;
		}
	}

	[Token(Token = "0x17000A61")]
	public string RegionGroupName
	{
		[Token(Token = "0x6007BBE")]
		[Address(RVA = "0x11A8A70", Offset = "0x11A7870", Length = "0xFA")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000A62")]
	public string RegionGroupNameLocId
	{
		[Token(Token = "0x6007BBF")]
		[Address(RVA = "0x11A8B70", Offset = "0x11A7970", Length = "0x101")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000A63")]
	public string LocalizedRegionGroupName
	{
		[Token(Token = "0x6007BC0")]
		[Address(RVA = "0x11A8C80", Offset = "0x11A7A80", Length = "0x140")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000A64")]
	public int MaxSceneCount
	{
		[Token(Token = "0x6007BC1")]
		[Address(RVA = "0x11A8DD0", Offset = "0x11A7BD0", Length = "0x8F")]
		get
		{
			return 0;
		}
	}

	[Token(Token = "0x6007BC2")]
	[Address(RVA = "0x11A8E60", Offset = "0x11A7C60", Length = "0x48E")]
	public void LoadAsync(ICollection<AsyncOperationHandle<SceneInstance>> loadOperations, ICollection<SceneLoadCondition> conditions, Action<ICollection<AsyncOperationHandle<SceneInstance>>> onAllLoadsStarted = null)
	{
	}

	[Token(Token = "0x6007BC3")]
	[Address(RVA = "0x11A92F0", Offset = "0x11A80F0", Length = "0x2ED")]
	private void OnBaseSceneLoaded(AsyncOperationHandle<SceneInstance> sceneLoad)
	{
	}

	[Token(Token = "0x6007BC4")]
	[Address(RVA = "0x11A95E0", Offset = "0x11A83E0", Length = "0x555")]
	private void LoadAdditiveAndConditionalScenes(ICollection<AssetReference> additiveScenes, ICollection<ConditionalScene> conditionalScenes)
	{
	}

	[Token(Token = "0x6007BC5")]
	[Address(RVA = "0x11A9B40", Offset = "0x11A8940", Length = "0x17E")]
	public void RefreshDynamicConditionalScenes(List<AsyncOperationHandle<SceneInstance>> asyncOperations)
	{
	}

	[Token(Token = "0x6007BC6")]
	[Address(RVA = "0x11A9CC0", Offset = "0x11A8AC0", Length = "0x389")]
	private void RefreshDynamicConditionalScenes(List<ConditionalScene> conditionalScenes, List<AsyncOperationHandle<SceneInstance>> asyncOperations)
	{
	}

	[Token(Token = "0x6007BC7")]
	[Address(RVA = "0x11AA050", Offset = "0x11A8E50", Length = "0x43C")]
	public void UnloadAsync(ICollection<AsyncOperationHandle<SceneInstance>> unloadOperations)
	{
	}

	[Token(Token = "0x6007BC8")]
	[Address(RVA = "0x11AA490", Offset = "0x11A9290", Length = "0x40B")]
	private static bool IsSceneLoaded(AssetReference sceneReference)
	{
		return false;
	}

	[Token(Token = "0x6007BC9")]
	[Address(RVA = "0x11AA8A0", Offset = "0x11A96A0", Length = "0x104")]
	public void AddExtension(SceneSetExtension extension)
	{
	}

	[Token(Token = "0x6007BCA")]
	[Address(RVA = "0x11AA9B0", Offset = "0x11A97B0", Length = "0x109")]
	public int GetRuntimeSceneResolutionOverride()
	{
		return 0;
	}

	[Token(Token = "0x6007BCB")]
	[Address(RVA = "0x11AAAC0", Offset = "0x11A98C0", Length = "0x292")]
	public SceneSet()
	{
	}
}
