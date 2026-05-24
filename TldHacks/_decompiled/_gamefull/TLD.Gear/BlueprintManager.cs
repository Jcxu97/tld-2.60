using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using TLD.Events;
using TLD.Logging;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.AddressableAssets.ResourceLocators;
using UnityEngine.ResourceManagement.AsyncOperations;

namespace TLD.Gear;

[CreateAssetMenu(menuName = "The Long Dark/Gear/Blueprint Manager")]
[Token(Token = "0x2001403")]
public class BlueprintManager : ScriptableObject
{
	[Token(Token = "0x4009254")]
	private static readonly LogFilter s_LogFilter;

	[Token(Token = "0x4009255")]
	private static BlueprintManager s_Instance;

	[SerializeField]
	[Token(Token = "0x4009256")]
	[FieldOffset(Offset = "0x18")]
	private AssetLabelReference m_BlueprintAddressableLabel;

	[Header("Debug")]
	[SerializeField]
	[Token(Token = "0x4009257")]
	[FieldOffset(Offset = "0x20")]
	private GameEvent m_UniumLoaded;

	[Token(Token = "0x4009259")]
	[FieldOffset(Offset = "0x30")]
	private List<string> m_UnlockedBlueprints;

	[Token(Token = "0x400925A")]
	[FieldOffset(Offset = "0x38")]
	private AsyncOperationHandle<IList<BlueprintData>> m_AddressableBlueprintOperation;

	[Token(Token = "0x400925B")]
	[FieldOffset(Offset = "0x50")]
	private List<BlueprintData> m_AddressableBlueprints;

	[Token(Token = "0x400925C")]
	[FieldOffset(Offset = "0x58")]
	private List<BlueprintData> m_UserBlueprints;

	[Token(Token = "0x400925D")]
	[FieldOffset(Offset = "0x60")]
	private List<BlueprintData> m_AllBlueprints;

	[Token(Token = "0x400925E")]
	[FieldOffset(Offset = "0x68")]
	private bool m_IsInitialized;

	[Token(Token = "0x17000AE5")]
	public static BlueprintManager Instance
	{
		[Token(Token = "0x6007F93")]
		[Address(RVA = "0x11F9640", Offset = "0x11F8440", Length = "0x54")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x14000045")]
	public event Action<BlueprintData> BlueprintUnlocked
	{
		[CompilerGenerated]
		[Token(Token = "0x6007F94")]
		[Address(RVA = "0x11F96A0", Offset = "0x11F84A0", Length = "0x166")]
		add
		{
		}
		[CompilerGenerated]
		[Token(Token = "0x6007F95")]
		[Address(RVA = "0x11F9810", Offset = "0x11F8610", Length = "0x166")]
		remove
		{
		}
	}

	[Token(Token = "0x6007F96")]
	[Address(RVA = "0x11F9980", Offset = "0x11F8780", Length = "0xB7")]
	private void Awake()
	{
	}

	[Token(Token = "0x6007F97")]
	[Address(RVA = "0x11F9A40", Offset = "0x11F8840", Length = "0x1C2")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6007F98")]
	[Address(RVA = "0x11F9C10", Offset = "0x11F8A10", Length = "0x252")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6007F99")]
	[Address(RVA = "0x11F9E70", Offset = "0x11F8C70", Length = "0xB6")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6007F9A")]
	[Address(RVA = "0x11F9F30", Offset = "0x11F8D30", Length = "0xD5")]
	public void InitializeBlueprints()
	{
	}

	[Token(Token = "0x6007F9B")]
	[Address(RVA = "0x11FA010", Offset = "0x11F8E10", Length = "0x2A4")]
	public void GetFilteredBlueprints(List<BlueprintData> blueprints, Predicate<BlueprintData> predicate)
	{
	}

	[Token(Token = "0x6007F9C")]
	[Address(RVA = "0x11FA2C0", Offset = "0x11F90C0", Length = "0xD9")]
	private List<BlueprintData> GetAllBlueprints()
	{
		return null;
	}

	[Token(Token = "0x6007F9D")]
	[Address(RVA = "0x11FA3A0", Offset = "0x11F91A0", Length = "0x19C")]
	public static string Serialize()
	{
		return null;
	}

	[Token(Token = "0x6007F9E")]
	[Address(RVA = "0x11FA540", Offset = "0x11F9340", Length = "0x2F0")]
	public static void Deserialize(string text)
	{
	}

	[Token(Token = "0x6007F9F")]
	[Address(RVA = "0x11FA840", Offset = "0x11F9640", Length = "0x251")]
	public static List<BlueprintData> FindBlueprintsForGear(string gearName)
	{
		return null;
	}

	[Token(Token = "0x6007FA0")]
	[Address(RVA = "0x11FAAA0", Offset = "0x11F98A0", Length = "0x315")]
	public static bool HasBlueprintsForLocation(CraftingLocation location)
	{
		return false;
	}

	[Token(Token = "0x6007FA1")]
	[Address(RVA = "0x11FADC0", Offset = "0x11F9BC0", Length = "0x19E")]
	public void ClearUnlockedBlueprints()
	{
	}

	[Token(Token = "0x6007FA2")]
	[Address(RVA = "0x11FAF60", Offset = "0x11F9D60", Length = "0x75")]
	public bool IsBlueprintUnlocked(string name, bool isStoryMode = false)
	{
		return false;
	}

	[Token(Token = "0x6007FA3")]
	[Address(RVA = "0x11FAFE0", Offset = "0x11F9DE0", Length = "0x119")]
	public void UnlockSilent(BlueprintData bp)
	{
	}

	[Token(Token = "0x6007FA4")]
	[Address(RVA = "0x11FB100", Offset = "0x11F9F00", Length = "0x134")]
	public void UnlockWithNotification(BlueprintData bp)
	{
	}

	[Token(Token = "0x6007FA5")]
	[Address(RVA = "0x11FB240", Offset = "0x11FA040", Length = "0x176")]
	private void HandleOnOptionalContentLoaded(IResourceLocator obj)
	{
	}

	[Token(Token = "0x6007FA6")]
	[Address(RVA = "0x11FB3C0", Offset = "0x11FA1C0", Length = "0x2A5")]
	private void LoadAddressableBlueprints()
	{
	}

	[Token(Token = "0x6007FA7")]
	[Address(RVA = "0x11FB670", Offset = "0x11FA470", Length = "0xC4")]
	public void LoadAllUserBlueprints()
	{
	}

	[Token(Token = "0x6007FA8")]
	[Address(RVA = "0x11FB740", Offset = "0x11FA540", Length = "0x151")]
	public bool LoadUserBlueprint(string jsonText)
	{
		return false;
	}

	[Token(Token = "0x6007FA9")]
	[Address(RVA = "0x11FB8A0", Offset = "0x11FA6A0", Length = "0x224")]
	private void RemoveUserBlueprints()
	{
	}

	[Token(Token = "0x6007FAA")]
	[Address(RVA = "0x11FBAD0", Offset = "0x11FA8D0", Length = "0x2EF")]
	private static bool PerformUserBlueprintSanityChecks(BlueprintData blueprint)
	{
		return false;
	}

	[Token(Token = "0x6007FAB")]
	[Address(RVA = "0x11FBDC0", Offset = "0x11FABC0", Length = "0x284")]
	private void MarkBlueprintUnlocked(string craftedResultName)
	{
	}

	[Token(Token = "0x6007FAC")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	private void MaybeRegisterUniumNodes()
	{
	}

	[Token(Token = "0x6007FAD")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	private void MaybeUnregisterUniumNodes()
	{
	}

	[Token(Token = "0x6007FAE")]
	[Address(RVA = "0x11FC050", Offset = "0x11FAE50", Length = "0x242")]
	public BlueprintManager()
	{
	}
}
