using Cpp2ILInjected;
using NodeCanvas.Framework;
using UnityEngine;

namespace NodeCanvas.BehaviourTrees;

[AddComponentMenu("NodeCanvas/Behaviour Tree Owner")]
[Token(Token = "0x200101D")]
public class BehaviourTreeOwner : GraphOwner<BehaviourTree>
{
	[Token(Token = "0x17000762")]
	public bool repeat
	{
		[Token(Token = "0x6006D7C")]
		[Address(RVA = "0x10AE5D0", Offset = "0x10AD3D0", Length = "0xFD")]
		get
		{
			return false;
		}
		[Token(Token = "0x6006D7D")]
		[Address(RVA = "0x10AE6D0", Offset = "0x10AD4D0", Length = "0xFD")]
		set
		{
		}
	}

	[Token(Token = "0x17000763")]
	public float updateInterval
	{
		[Token(Token = "0x6006D7E")]
		[Address(RVA = "0x10AE7D0", Offset = "0x10AD5D0", Length = "0xFF")]
		get
		{
			return 0f;
		}
		[Token(Token = "0x6006D7F")]
		[Address(RVA = "0x10AE8D0", Offset = "0x10AD6D0", Length = "0xFE")]
		set
		{
		}
	}

	[Token(Token = "0x17000764")]
	public Status rootStatus
	{
		[Token(Token = "0x6006D80")]
		[Address(RVA = "0x10AE9D0", Offset = "0x10AD7D0", Length = "0xFF")]
		get
		{
			return default(Status);
		}
	}

	[Token(Token = "0x6006D81")]
	[Address(RVA = "0x10AEAD0", Offset = "0x10AD8D0", Length = "0x259")]
	public Status Tick()
	{
		return default(Status);
	}

	[Token(Token = "0x6006D82")]
	[Address(RVA = "0xD75890", Offset = "0xD74690", Length = "0x3E")]
	public BehaviourTreeOwner()
	{
	}
}
