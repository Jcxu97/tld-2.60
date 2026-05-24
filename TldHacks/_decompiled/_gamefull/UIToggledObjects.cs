using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;

[AddComponentMenu("NGUI/Interaction/Toggled Objects")]
[Token(Token = "0x20000A4")]
public class UIToggledObjects : MonoBehaviour
{
	[Token(Token = "0x4000588")]
	[FieldOffset(Offset = "0x20")]
	public List<GameObject> activate;

	[Token(Token = "0x4000589")]
	[FieldOffset(Offset = "0x28")]
	public List<GameObject> deactivate;

	[HideInInspector]
	[SerializeField]
	[Token(Token = "0x400058A")]
	[FieldOffset(Offset = "0x30")]
	private GameObject target;

	[HideInInspector]
	[SerializeField]
	[Token(Token = "0x400058B")]
	[FieldOffset(Offset = "0x38")]
	private bool inverse;

	[Token(Token = "0x6000570")]
	[Address(RVA = "0xBF36B0", Offset = "0xBF24B0", Length = "0x271")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000571")]
	[Address(RVA = "0xBF3930", Offset = "0xBF2730", Length = "0x223")]
	public void Toggle()
	{
	}

	[Token(Token = "0x6000572")]
	[Address(RVA = "0xBF3B60", Offset = "0xBF2960", Length = "0xFF")]
	private void Set(GameObject go, bool state)
	{
	}

	[Token(Token = "0x6000573")]
	[Address(RVA = "0x4AF5E0", Offset = "0x4AE3E0", Length = "0x43")]
	public UIToggledObjects()
	{
	}
}
