using System;
using Il2Cpp;
using Il2CppSystem.Collections.Generic;
using Il2CppTLD.Utility;
using Il2CppVLB;
using MelonLoader;
using UnityEngine;

namespace SCPlusPP;

[RegisterTypeInIl2Cpp]
internal class SCPlusDecorationDetector : MonoBehaviour
{
	public CapsuleCollider? cc;

	public Rigidbody? rb;

	public SCPlusDecorationDetector(IntPtr intPtr)
		: base(intPtr)
	{
	}

	public void Awake()
	{
		cc = this.GetOrAddComponent<CapsuleCollider>();
		rb = this.GetOrAddComponent<Rigidbody>();
		cc.isTrigger = true;
		cc.radius = Settings.options.outlineDistance;
		cc.height = 2f;
		rb.isKinematic = true;
	}

	public void OnDestroy()
	{
		if (cc != null)
		{
			UnityEngine.Object.Destroy(cc);
			cc = null;
		}
		if (rb != null)
		{
			UnityEngine.Object.Destroy(rb);
			rb = null;
		}
	}

	private void OnTriggerEnter(Collider other)
	{
		if (((1 << other.gameObject.layer) & 0xC0241) == 0 || !other.gameObject.TryGetComponentInParent<DecorationItem>(out var component))
		{
			return;
		}
		List<Renderer> renderers = component.GetRenderers();
		if (renderers.Count > 0)
		{
			int instanceID = renderers[0].GetInstanceID();
			if (!MiscPatches.SkipOutline.inProximity.Contains(instanceID))
			{
				MiscPatches.SkipOutline.inProximity.Add(instanceID);
			}
			Il2Cpp.Utils.ApplyPropertyBlockToRenderers(renderers, GameManager.GetSafehouseManager().m_OutlinePropertyBlock);
		}
	}

	private void OnTriggerExit(Collider other)
	{
		if (((1 << other.gameObject.layer) & 0xC0241) == 0 || !other.gameObject.TryGetComponentInParent<DecorationItem>(out var component))
		{
			return;
		}
		List<Renderer> renderers = component.GetRenderers();
		if (renderers.Count > 0)
		{
			int instanceID = renderers[0].GetInstanceID();
			if (MiscPatches.SkipOutline.inProximity.Contains(instanceID))
			{
				MiscPatches.SkipOutline.inProximity.Remove(instanceID);
			}
			Il2Cpp.Utils.ResetPropertyBlockOnRenderers(component.GetRenderers());
		}
	}
}
