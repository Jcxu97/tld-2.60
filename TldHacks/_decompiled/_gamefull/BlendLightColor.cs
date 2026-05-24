using Cpp2ILInjected;
using UnityEngine;

[RequireComponent(typeof(Light))]
[Token(Token = "0x2000363")]
public class BlendLightColor : MonoBehaviour
{
	[SerializeField]
	[Token(Token = "0x4001DDB")]
	[FieldOffset(Offset = "0x20")]
	private Color m_BaseColor;

	[SerializeField]
	[Range(0f, 1f)]
	[Token(Token = "0x4001DDC")]
	[FieldOffset(Offset = "0x30")]
	private float m_BlendBias;

	[HideInInspector]
	[SerializeField]
	[AutoComponent(ComponentRequirement.Required)]
	[Token(Token = "0x4001DDD")]
	[FieldOffset(Offset = "0x38")]
	private Light m_Light;

	[Token(Token = "0x6001B87")]
	[Address(RVA = "0x761DA0", Offset = "0x760BA0", Length = "0xF5")]
	public void SetLightColor(Color color)
	{
	}

	[Token(Token = "0x6001B88")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	private void OnValidate()
	{
	}

	[Token(Token = "0x6001B89")]
	[Address(RVA = "0x4AF5E0", Offset = "0x4AE3E0", Length = "0x43")]
	public BlendLightColor()
	{
	}
}
