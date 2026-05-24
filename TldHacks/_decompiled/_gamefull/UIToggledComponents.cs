using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;

[ExecuteInEditMode]
[RequireComponent(typeof(UIToggle))]
[AddComponentMenu("NGUI/Interaction/Toggled Components")]
[Token(Token = "0x20000A3")]
public class UIToggledComponents : MonoBehaviour
{
	[Token(Token = "0x4000584")]
	[FieldOffset(Offset = "0x20")]
	public List<MonoBehaviour> activate;

	[Token(Token = "0x4000585")]
	[FieldOffset(Offset = "0x28")]
	public List<MonoBehaviour> deactivate;

	[HideInInspector]
	[SerializeField]
	[Token(Token = "0x4000586")]
	[FieldOffset(Offset = "0x30")]
	private MonoBehaviour target;

	[HideInInspector]
	[SerializeField]
	[Token(Token = "0x4000587")]
	[FieldOffset(Offset = "0x38")]
	private bool inverse;

	[Token(Token = "0x600056D")]
	[Address(RVA = "0xBF3090", Offset = "0xBF1E90", Length = "0x271")]
	private void Awake()
	{
	}

	[Token(Token = "0x600056E")]
	[Address(RVA = "0xBF3310", Offset = "0xBF2110", Length = "0x39E")]
	public void Toggle()
	{
	}

	[Token(Token = "0x600056F")]
	[Address(RVA = "0x4AF5E0", Offset = "0x4AE3E0", Length = "0x43")]
	public UIToggledComponents()
	{
	}
}
