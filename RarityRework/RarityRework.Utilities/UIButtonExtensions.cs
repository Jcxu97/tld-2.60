using System;
using System.Collections.Generic;
using HarmonyLib;
using Il2Cpp;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using UnityEngine;

namespace RarityRework.Utilities;

internal static class UIButtonExtensions
{
	private static UIButton Instantiate(this UIButton original)
	{
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		UIButton component = UnityEngine.Object.Instantiate<GameObject>(((Component)original).gameObject).GetComponent<UIButton>();
		((Component)component).transform.parent = ((Component)original).transform.parent;
		((Component)component).transform.localPosition = ((Component)original).transform.localPosition;
		((Component)component).transform.localScale = Vector3.one;
		return component;
	}

	internal static void NewSortButton(Il2CppReferenceArray<UIButton> uiButtonsArray, string buttonName, string spriteName, Action<UIButton> uiButtonMethod, float posX = 0f, float posY = 0f, float posZ = 0f)
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Expected O, but got Unknown
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		UIButton original = new UIButton();
		foreach (UIButton item in (Il2CppArrayBase<UIButton>)(object)uiButtonsArray)
		{
			original = item;
		}
		UIButton newButton = original.Instantiate();
		((UnityEngine.Object)newButton).name = buttonName;
		newButton.SetSpriteName(spriteName);
		EventDelegate.Set(newButton.onClick, (EventDelegate.Callback)((Action)delegate
		{
			uiButtonMethod(newButton);
		}));
		((Component)newButton).transform.localPosition = new Vector3(posX, posY, posZ);
		HarmonyLib.CollectionExtensions.AddItem<UIButton>((IEnumerable<UIButton>)uiButtonsArray, newButton);
	}

	private static void SetSpriteName(this UIButton btn, string newSpriteName)
	{
		UISprite component = ((Component)btn).GetComponent<UISprite>();
		component.spriteName = newSpriteName;
		((UIRect)component).OnInit();
	}
}
