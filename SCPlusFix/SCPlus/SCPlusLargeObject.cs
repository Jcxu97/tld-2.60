using System;
using System.Collections.Generic;
using MelonLoader;
using UnityEngine;

namespace SCPlus;

[RegisterTypeInIl2Cpp]
internal class SCPlusLargeObject : MonoBehaviour
{
	public bool isDismantled;

	public List<GameObject> allowedTools;

	public SCPlusLargeObject(IntPtr intPtr)
		: base(intPtr)
	{
	}
}
