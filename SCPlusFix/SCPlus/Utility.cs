using System;
using System.Collections;
using System.IO;
using System.IO.Compression;
using System.Text;
using System.Text.RegularExpressions;
using Il2Cpp;
using Il2CppTLD.Interactions;
using Il2CppTLD.Placement;
using MelonLoader;
using ModData;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace SCPlusPP;

internal static class Utility
{
	public enum LayerMask
	{
		Default = 1,
		PossibleDecoration = 787009
	}

	public const string modVersion = "1.9.4";

	public const string modName = "SafehouseCustomizationPlus";

	public const string modAuthor = "Waltz";

	public const string resourcesFolder = "SafehouseCustomizationPlus.Resources.";

	public const string resourcesFolderForAssumingPlayersUnableToRead = "DumbShield";

	public const string modFolder = "SCPlus/";

	public const string iconsFolder = "SCPlus/Icons/";

	public const string iconsCatalog = "catalog_SCPlusIcons";

	public const string placeholderIconName = "placeholder";

	public const string dataSeparator = "_|_";

	public static ModDataManager dataManager = new ModDataManager("SafehouseCustomizationPlus");

	public static readonly string fireSaveDataTag = "fireBarrels";

	public static readonly string movablesSaveDataTag = "carryables";

	public static PlaceMeshRules genericPlacementRules = PlaceMeshRules.Default | PlaceMeshRules.IgnoreCloseObjects | PlaceMeshRules.AllowFloorPlacement;

	public static PlaceMeshRules boxPlacementRules = PlaceMeshRules.Default | PlaceMeshRules.IgnoreCloseObjects | PlaceMeshRules.AllowFloorPlacement | PlaceMeshRules.AllowStacking;

	public static readonly string missingGuid = "MISSING GUID";

	public static int childrenLookupCoroutineRunning = 0;

	public static readonly Color outlineColor = new Color(0.25f, 0.5f, 1f);

	public static void Log(ConsoleColor color, string message)
	{
		if (Settings.options.debugLog)
		{
			Melon<SCPMain>.Logger.Msg(color, message);
		}
	}

	public static bool IsScenePlayable()
	{
		if (!string.IsNullOrEmpty(GameManager.m_ActiveScene) && !GameManager.m_ActiveScene.Contains("MainMenu") && !(GameManager.m_ActiveScene == "Boot"))
		{
			return !(GameManager.m_ActiveScene == "Empty");
		}
		return false;
	}

	public static bool IsScenePlayable(string scene)
	{
		if (!string.IsNullOrEmpty(scene) && !scene.Contains("MainMenu") && !(scene == "Boot"))
		{
			return !(scene == "Empty");
		}
		return false;
	}

	public static bool IsMainMenu(string scene)
	{
		if (!string.IsNullOrEmpty(scene))
		{
			return scene.Contains("MainMenu");
		}
		return false;
	}

	public static GameObject GetInteractiveGameObjectUnderCrosshair()
	{
		PlayerManager playerManagerComponent = GameManager.GetPlayerManagerComponent();
		float maxPickupRange = GameManager.GetGlobalParameters().m_MaxPickupRange;
		float maxRange = playerManagerComponent.ComputeModifiedPickupRange(maxPickupRange);
		if (playerManagerComponent.GetControlMode() == PlayerControlMode.InFPCinematic)
		{
			maxRange = 50f;
		}
		return GameManager.GetPlayerManagerComponent().GetInteractiveObjectUnderCrosshairs(maxRange);
	}

	public static GameObject? GetRealGameObjectUnderCrosshair()
	{
		PlayerManager playerManagerComponent = GameManager.GetPlayerManagerComponent();
		float maxPickupRange = GameManager.GetGlobalParameters().m_MaxPickupRange;
		float maxDistance = playerManagerComponent.ComputeModifiedPickupRange(maxPickupRange);
		if (playerManagerComponent.GetControlMode() == PlayerControlMode.InFPCinematic)
		{
			maxDistance = 50f;
		}
		if (Physics.Raycast(GameManager.GetMainCamera().ScreenPointToRay(Input.mousePosition), out var hitInfo, maxDistance, 787009))
		{
			GameObject realParent = GetRealParent(hitInfo.transform);
			if (realParent.name.StartsWith("ARC_"))
			{
				HUDMessage.AddMessage(Localization.Get("SCP_Action_NoValidObject"));
				return null;
			}
			{
				foreach (Renderer componentsInChild in realParent.transform.GetComponentsInChildren<Renderer>())
				{
					if ((bool)componentsInChild && componentsInChild.isPartOfStaticBatch)
					{
						HUDMessage.AddMessage(Localization.Get("SCP_Action_IsPartOfStaticBatch"));
						return null;
					}
				}
				return realParent;
			}
		}
		HUDMessage.AddMessage(Localization.Get("SCP_Action_NoValidObject"));
		return null;
	}

	public static Guid GenerateSeededGuid(int seed)
	{
		System.Random random = new System.Random(seed);
		byte[] array = new byte[16];
		random.NextBytes(array);
		return new Guid(array);
	}

	public static int SeedFromCoords(Vector3 v)
	{
		return Mathf.CeilToInt(v.x * v.z + v.y * 10000f);
	}

	public static IEnumerator DelayedHUDMessage(string text, float delay)
	{
		float n = 0f;
		while (n <= delay)
		{
			n += Time.deltaTime;
			yield return new WaitForEndOfFrame();
		}
		HUDMessage.AddMessage(text, highPriority: false, ignoreOverlayActive: true);
	}

	public static bool WithinDistance(Vector3 A, Vector3 B, float distance = 0.01f)
	{
		if (Mathf.Abs(A.x - B.x) > distance)
		{
			return false;
		}
		if (Mathf.Abs(A.y - B.y) > distance)
		{
			return false;
		}
		if (Mathf.Abs(A.z - B.z) > distance)
		{
			return false;
		}
		return true;
	}

	public static GameObject GetRealParent(Transform t)
	{
		while ((bool)t.parent && !WithinDistance(t.parent.position, Vector3.zero) && t.parent.name.Contains("_") && !t.parent.GetComponent<RadialObjectSpawner>())
		{
			t = t.parent;
		}
		return t.gameObject;
	}

	public static bool TryGetCarryableRoot(Transform t, out GameObject? go)
	{
		while ((bool)t.parent && !CarryableData.carryablePrefabDefinition.ContainsKey(SanitizeObjectName(t.name)))
		{
			t = t.parent;
		}
		if (CarryableData.carryablePrefabDefinition.ContainsKey(SanitizeObjectName(t.name)))
		{
			go = t.gameObject;
			return true;
		}
		go = null;
		return false;
	}

	public static LocalizedString TryGetLocalizedName(GameObject go)
	{
		string text = SanitizeObjectName(go.name);
		if (CarryableData.decorationOverrideData.ContainsKey(text))
		{
			string nameLocID = CarryableData.decorationOverrideData[text].nameLocID;
			if (!string.IsNullOrEmpty(nameLocID))
			{
				return new LocalizedString
				{
					m_LocalizationID = nameLocID
				};
			}
		}
		BaseInteraction componentInChildren = go.GetComponentInChildren<BaseInteraction>();
		if ((bool)componentInChildren && !string.IsNullOrEmpty(componentInChildren.m_DefaultHoverText.m_LocalizationID))
		{
			return componentInChildren.m_DefaultHoverText;
		}
		BreakDown componentInChildren2 = go.GetComponentInChildren<BreakDown>();
		if ((bool)componentInChildren2 && !string.IsNullOrEmpty(componentInChildren2.m_LocalizedDisplayName.m_LocalizationID))
		{
			return componentInChildren2.m_LocalizedDisplayName;
		}
		if (Localization.Get(text) == text)
		{
			text = text.Split('_')[1];
			text = Regex.Replace(text, "(?<!^)([A-Z])", " $1");
			if (text.Split(" ")[^1].Length < 2)
			{
				string text2 = text;
				text = text2.Substring(0, text2.Length - 2);
			}
		}
		return new LocalizedString
		{
			m_LocalizationID = text
		};
	}

	public static string SanitizeObjectName(string s)
	{
		if (string.IsNullOrEmpty(s))
		{
			return string.Empty;
		}
		s = Regex.Replace(s, "\\s|\\(.*?\\)", "");
		s = s.Trim();
		s = Regex.Replace(s, "\\d+$", "");
		return s;
	}

	public static string TryGetGuid(GameObject go)
	{
		ObjectGuid componentInChildren = GetRealParent(go.transform).GetComponentInChildren<ObjectGuid>();
		if (!componentInChildren)
		{
			return "";
		}
		return componentInChildren.GetPDID();
	}

	public static Scene[] GetLoadedScenes()
	{
		int sceneCount = UnityEngine.SceneManagement.SceneManager.sceneCount;
		Scene[] array = new Scene[sceneCount];
		for (int i = 0; i < sceneCount; i++)
		{
			array[i] = UnityEngine.SceneManagement.SceneManager.GetSceneAt(i);
		}
		return array;
	}

	public static string CompressDeflate(string text)
	{
		byte[] bytes = Encoding.UTF8.GetBytes(text);
		using MemoryStream memoryStream = new MemoryStream();
		using (DeflateStream deflateStream = new DeflateStream(memoryStream, CompressionMode.Compress))
		{
			deflateStream.Write(bytes, 0, bytes.Length);
		}
		return Convert.ToBase64String(memoryStream.ToArray());
	}

	public static string DecompressDeflate(string compressedText)
	{
		using MemoryStream stream = new MemoryStream(Convert.FromBase64String(compressedText));
		using DeflateStream stream2 = new DeflateStream(stream, CompressionMode.Decompress);
		using StreamReader streamReader = new StreamReader(stream2, Encoding.UTF8);
		return streamReader.ReadToEnd();
	}

	public static bool CurrentlyInNativeScene(SCPlusCarryable sc)
	{
		return UnityEngine.SceneManagement.SceneManager.GetAllScenes().Contains(UnityEngine.SceneManagement.SceneManager.GetSceneByName(sc.nativeScene));
	}

	public static bool CurrentlyInNativeScene(string native)
	{
		return UnityEngine.SceneManagement.SceneManager.GetAllScenes().Contains(UnityEngine.SceneManagement.SceneManager.GetSceneByName(native));
	}

	public static iTweenEvent Initialize(this iTweenEvent ite, string name, float rotation, float speed = 1f)
	{
		ite.animating = false;
		ite.playAutomatically = false;
		ite.tweenName = name;
		ite.type = iTweenEvent.TweenType.RotateBy;
		ite.vector3s = new Vector3[1]
		{
			new Vector3(0f, rotation, 0f)
		};
		ite.floats = new float[1] { speed };
		ite.keys = new string[2] { "time", "amount" };
		ite.indexes = new int[2];
		return ite;
	}

	public static ObjectAnim Initialize(this ObjectAnim oa, GameObject target)
	{
		oa.m_Target = target;
		oa.Initialize();
		return oa;
	}

	public static bool FindCarryableAtPosition(string targetName, Vector3 position, float radius, out GameObject? go)
	{
		Collider[] array = Physics.OverlapSphere(position, radius, 787009);
		for (int i = 0; i < array.Length; i++)
		{
			if (TryGetCarryableRoot(array[i].transform, out GameObject go2) && SanitizeObjectName(go2.name).ToLower().Contains(targetName.ToLower()))
			{
				go = go2;
				return true;
			}
		}
		go = null;
		return false;
	}
}
