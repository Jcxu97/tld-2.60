using System;
using UnityEngine;

namespace SCPlusPP;

internal class ObjectToModify
{
	public CarryableData.CarryableType type;

	public string assetPath = "";

	public bool needsReconstruction;

	public Func<GameObject> reconstructAction;

	public bool existingDecoration;

	public bool pickupable = true;
}
