using System.Collections.Generic;
using System.Linq;
using System.Text;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using UnityEngine.SceneManagement;

namespace SCPlus;

internal class CarryableManager
{
	public static List<SCPlusCarryable> carryables = new List<SCPlusCarryable>();

	public static void Reset()
	{
		carryables.Clear();
	}

	public static void Add(SCPlusCarryable s)
	{
		if (!carryables.Contains(s))
		{
			carryables.Add(s);
		}
	}

	public static void Remove(SCPlusCarryable s)
	{
		if (carryables.Contains(s))
		{
			carryables.Remove(s);
		}
	}

	public static string SerializeAll(bool carried)
	{
		List<CarryableSaveDataProxy> list = new List<CarryableSaveDataProxy>();
		List<CarryableSaveDataProxy> list2 = new List<CarryableSaveDataProxy>();
		Il2CppStructArray<Scene> allScenes = SceneManager.GetAllScenes();
		foreach (SCPlusCarryable carryable in carryables)
		{
			if (!(carryable?.gameObject))
			{
				continue;
			}
			CarryableSaveDataProxy carryableSaveDataProxy = ((!CarryableData.carryablePrefabDefinition.ContainsKey(carryable.objectName) || !CarryableData.carryablePrefabDefinition[carryable.objectName].existingDecoration) ? carryable.ToProxy() : carryable.ToProxy(shorten: true));
			bool flag = (carryableSaveDataProxy.state & CarryableData.CarryableState.OnPlayer) != 0;
			if (!carried && (!flag || (flag && allScenes.Contains(SceneManager.GetSceneByName(carryableSaveDataProxy.nativeScene)) && !carryable.isInstance)))
			{
				if (flag)
				{
					carryableSaveDataProxy.state &= ~CarryableData.CarryableState.OnPlayer;
					carryableSaveDataProxy.state |= CarryableData.CarryableState.Removed;
				}
				if ((carryableSaveDataProxy.state & CarryableData.CarryableState.Removed) != CarryableData.CarryableState.None)
				{
					carryableSaveDataProxy.dataToSave = "";
				}
				bool flag2 = false;
				if ((carryableSaveDataProxy.state & CarryableData.CarryableState.Surplus) == 0)
				{
					for (int i = 0; i < list.Count; i++)
					{
						if (carryableSaveDataProxy.name == list[i].name && Utility.WithinDistance(carryableSaveDataProxy.originalPos, list[i].originalPos))
						{
							if ((list[i].state & CarryableData.CarryableState.Removed) != CarryableData.CarryableState.None)
							{
								list[i] = carryableSaveDataProxy;
							}
							flag2 = true;
							break;
						}
					}
				}
				if (!flag2)
				{
					list.Add(carryableSaveDataProxy);
				}
			}
			if (carried && flag)
			{
				carryableSaveDataProxy.state &= ~CarryableData.CarryableState.Removed;
				list2.Add(carryableSaveDataProxy);
			}
		}
		StringBuilder stringBuilder = new StringBuilder();
		List<CarryableSaveDataProxy> relevantData = (carried ? list2 : list);
		stringBuilder.Append('[');
		if (relevantData.Count > 0)
		{
			foreach (CarryableSaveDataProxy item in relevantData.Where((CarryableSaveDataProxy carryableSaveDataProxy2) => carryableSaveDataProxy2 != relevantData.Last()))
			{
				stringBuilder.Append(item.JsonDumpSkipDefaults() + ",");
			}
			stringBuilder.Append(relevantData.Last().JsonDumpSkipDefaults());
		}
		stringBuilder.Append(']');
		return stringBuilder.ToString();
	}
}
