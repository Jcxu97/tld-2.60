using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x20002EC")]
public class AuroraObjectActivator : MonoBehaviour
{
	[Tooltip("How sensitive is the object to the aurora.")]
	[Range(0.01f, 1f)]
	[Token(Token = "0x40019A4")]
	[FieldOffset(Offset = "0x20")]
	public float m_AuroraThreshold;

	[Token(Token = "0x40019A5")]
	[FieldOffset(Offset = "0x24")]
	private bool m_ChildrenDisabled;

	[Token(Token = "0x6001852")]
	[Address(RVA = "0x6E5740", Offset = "0x6E4540", Length = "0xA7")]
	private void Start()
	{
	}

	[Token(Token = "0x6001853")]
	[Address(RVA = "0x6E57F0", Offset = "0x6E45F0", Length = "0xA6")]
	private void Update()
	{
	}

	[Token(Token = "0x6001854")]
	[Address(RVA = "0x6E58A0", Offset = "0x6E46A0", Length = "0x3E8")]
	private void EnableChildren()
	{
	}

	[Token(Token = "0x6001855")]
	[Address(RVA = "0x6E5C90", Offset = "0x6E4A90", Length = "0x3E8")]
	private void DisableChildren()
	{
	}

	[Token(Token = "0x6001856")]
	[Address(RVA = "0x6E6080", Offset = "0x6E4E80", Length = "0x4A")]
	public AuroraObjectActivator()
	{
	}
}
