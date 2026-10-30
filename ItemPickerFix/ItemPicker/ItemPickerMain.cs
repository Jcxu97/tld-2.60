using System.Collections.Generic;
using System.IO;
using Il2Cpp;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using MelonLoader;
using UnityEngine;

namespace ItemPicker;

public class ItemPickerMain : MelonMod
{
	public static GameObject playerObject;

	public static int layerMask = 0;

	public static int stoneCounter = 0;

	public static int stickCounter = 0;

	public static int customCounter = 0;

	public static List<string> customItems = new List<string>();

	public override void OnInitializeMelon()
	{
		layerMask |= 131072;
		Settings.OnLoad();
		loadCustomItemList();
	}

	public override void OnUpdate()
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		if (!InputManager.GetKeyDown(InputManager.m_CurrentContext, Settings.options.buttonPickSticks))
		{
			return;
		}
		RaycastHit[] array = (RaycastHit[])Physics.SphereCastAll(((Component)GameManager.GetVpFPSPlayer()).transform.position, Settings.options.pickupRadius, ((Component)GameManager.GetVpFPSPlayer()).transform.TransformDirection(Vector3.down), GameManager.GetVpFPSPlayer().Controller.m_Controller.height * 0.8f, layerMask);
		for (int i = 0; i < array.Length; i++)
		{
			RaycastHit val = array[i];
			GearItem component = ((Component)val.transform).gameObject.GetComponent<GearItem>();
			if ((Object)(object)component != (Object)null && ((Behaviour)component).enabled)
			{
				if (((Object)component).name.Contains("GEAR_Stick") && !component.m_InPlayerInventory && (Settings.options.pickupChoice == 0 || Settings.options.pickupChoice == 2))
				{
					GameManager.GetPlayerManagerComponent().ProcessPickupItemInteraction(component, false, false, false);
					stickCounter++;
				}
				if (((Object)component).name.Contains("GEAR_Stone") && !component.m_InPlayerInventory && (Settings.options.pickupChoice == 1 || Settings.options.pickupChoice == 2))
				{
					GameManager.GetPlayerManagerComponent().ProcessPickupItemInteraction(component, false, false, false);
					stoneCounter++;
				}
				if (customItems.Contains(((Object)component).name) && !component.m_InPlayerInventory && Settings.options.pickUpAdditionalItems)
				{
					GameManager.GetPlayerManagerComponent().ProcessPickupItemInteraction(component, false, false, false);
					customCounter++;
				}
			}
		}
		int num = 0;
		int num2 = stickCounter + stoneCounter + customCounter;
		if (num2 != 0 && Settings.options.calorieCost != 0)
		{
			num = num2 * Settings.options.calorieCost;
			GameManager.GetHungerComponent().RemoveReserveCalories((float)num);
		}
		MelonLogger.Msg("Picked up " + stickCounter + " sticks and " + stoneCounter + " stones in radius of " + Settings.options.pickupRadius + " meter and spent " + num + " calories.");
		if (Settings.options.pickUpAdditionalItems)
		{
			MelonLogger.Msg("Oh and " + customCounter + " items from your custom list also!");
		}
		customCounter = 0;
		stoneCounter = 0;
		stickCounter = 0;
	}

	public static void loadCustomItemList()
	{
		customItems.Clear();
		if (!File.Exists("Mods\\ItemPickerCustomList.txt") || !Settings.options.pickUpAdditionalItems)
		{
			return;
		}
		using (StreamReader streamReader = File.OpenText("Mods\\ItemPickerCustomList.txt"))
		{
			while (!streamReader.EndOfStream)
			{
				customItems.Add(streamReader.ReadLine());
			}
			streamReader.Close();
		}
		MelonLogger.Msg("Loaded custom list with " + customItems.Count + " items");
	}
}
