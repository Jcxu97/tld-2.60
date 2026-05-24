using Cpp2ILInjected;
using NodeCanvas.Framework;
using UnityEngine;

[Token(Token = "0x2000A40")]
public class TriggerVolumeSetBBValue : MonoBehaviour
{
	[Token(Token = "0x40066B2")]
	[FieldOffset(Offset = "0x20")]
	public Blackboard m_BlackBoard;

	[HideInInspector]
	[Token(Token = "0x40066B3")]
	[FieldOffset(Offset = "0x28")]
	public string m_VariableName;

	[Token(Token = "0x6005941")]
	[Address(RVA = "0xEF4760", Offset = "0xEF3560", Length = "0x156")]
	private void Start()
	{
	}

	[Token(Token = "0x6005942")]
	[Address(RVA = "0xEF48C0", Offset = "0xEF36C0", Length = "0x38F")]
	private void OnTriggerEnter(Collider collider)
	{
	}

	[Token(Token = "0x6005943")]
	[Address(RVA = "0x4AF5E0", Offset = "0x4AE3E0", Length = "0x43")]
	public TriggerVolumeSetBBValue()
	{
	}
}
