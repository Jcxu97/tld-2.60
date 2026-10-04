using Il2Cpp;
using Il2CppTLD.PDID;
using UnityEngine;

namespace SCPlus;

internal class CarryableSaveDataProxy
{
	public CarryableData.CarryableState state;

	public string name = "";

	public CarryableData.CarryableType type;

	public string nativeScene = "";

	public string currentScene = "";

	public Vector3 originalPos;

	public Vector3 currentPos;

	public Quaternion currentRot;

	public string dataToSave = "";

	public string guid = "";

	public string containerGuid = "";

	public int containerIndex;

	public bool IsInNativeScene()
	{
		if (string.IsNullOrEmpty(currentScene))
		{
			return false;
		}
		return nativeScene.Contains(currentScene);
	}

	public Container? TryGetContainer()
	{
		if (string.IsNullOrEmpty(containerGuid) || containerGuid == Utility.missingGuid)
		{
			return null;
		}
		if (containerIndex > 0)
		{
			GameObject gameObject = PdidTable.GetGameObject(containerGuid);
			if (!(gameObject != null))
			{
				return null;
			}
			Container[] array = gameObject.GetComponentsInChildren<Container>(includeInactive: false);
			if (array.Length >= containerIndex)
			{
				return array[containerIndex - 1];
			}
		}
		return PdidTable.GetGameObject(containerGuid)?.GetComponent<Container>();
	}
}
