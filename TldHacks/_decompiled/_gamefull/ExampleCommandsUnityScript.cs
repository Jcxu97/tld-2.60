using System;
using Cpp2ILInjected;
using UnityEngine;

[Serializable]
[Token(Token = "0x2000A90")]
public class ExampleCommandsUnityScript : MonoBehaviour
{
	[Token(Token = "0x6005BB6")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public virtual void Start()
	{
	}

	[Token(Token = "0x6005BB7")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public virtual void EchoNothing()
	{
	}

	[Token(Token = "0x6005BB8")]
	[Address(RVA = "0x4AF5E0", Offset = "0x4AE3E0", Length = "0x43")]
	public ExampleCommandsUnityScript()
	{
	}
}
