using Il2Cpp;
using MelonLoader;
using UnityEngine;

namespace ItemRarities.Components;

[RegisterTypeInIl2Cpp(false)]
internal class MythicGlowEffect : MonoBehaviour
{
	private UILabel? labelMythic;

	private Color originalColor;

	private float time;

	private const float glowMin = 0.9f;

	private const float glowMax = 1.3f;

	private const float glowSpeed = 2f;

	private static readonly Color shiftColor = new Color(1.1f, 1.1f, 0.9f);

	private void OnDisable()
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)labelMythic != (Object)null)
		{
			((UIWidget)labelMythic).color = originalColor;
		}
	}

	private void Start()
	{
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		labelMythic = ((Component)this).GetComponent<UILabel>();
		originalColor = ((UIWidget)labelMythic).color;
	}

	private void Update()
	{
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		if (labelMythic != null)
		{
			time += Time.deltaTime * 2f;
			float num = Mathf.Lerp(0.9f, 1.3f, (Mathf.Sin(time) + 1f) * 0.5f);
			Color color = default(Color);
			color = new Color(originalColor.r * num * shiftColor.r, originalColor.g * num * shiftColor.g, originalColor.b * num * shiftColor.b, originalColor.a);
			((UIWidget)labelMythic).color = color;
		}
	}
}
