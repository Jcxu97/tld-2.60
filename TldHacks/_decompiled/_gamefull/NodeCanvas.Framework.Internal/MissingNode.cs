using System;
using Cpp2ILInjected;
using ParadoxNotion;
using ParadoxNotion.Design;
using ParadoxNotion.Serialization;
using UnityEngine;

namespace NodeCanvas.Framework.Internal;

[DoNotList]
[Description("Please resolve the MissingNode issue by either replacing the node or importing the missing node type in the project.")]
[Token(Token = "0x2001090")]
public sealed class MissingNode : Node, IMissingRecoverable
{
	[SerializeField]
	[Token(Token = "0x40085EA")]
	[FieldOffset(Offset = "0x78")]
	private string _missingType;

	[SerializeField]
	[Token(Token = "0x40085EB")]
	[FieldOffset(Offset = "0x80")]
	private string _recoveryState;

	[Token(Token = "0x17000821")]
	string IMissingRecoverable.missingType
	{
		[Token(Token = "0x60070B0")]
		[Address(RVA = "0x664E10", Offset = "0x663C10", Length = "0x5")]
		get
		{
			return null;
		}
		[Token(Token = "0x60070B1")]
		[Address(RVA = "0x6E17D0", Offset = "0x6E05D0", Length = "0x52")]
		set
		{
		}
	}

	[Token(Token = "0x17000822")]
	string IMissingRecoverable.recoveryState
	{
		[Token(Token = "0x60070B2")]
		[Address(RVA = "0x502330", Offset = "0x501130", Length = "0x8")]
		get
		{
			return null;
		}
		[Token(Token = "0x60070B3")]
		[Address(RVA = "0xB51E90", Offset = "0xB50C90", Length = "0x52")]
		set
		{
		}
	}

	[Token(Token = "0x17000823")]
	public override string name
	{
		[Token(Token = "0x60070B4")]
		[Address(RVA = "0x10CFF60", Offset = "0x10CED60", Length = "0x31")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000824")]
	public override Type outConnectionType
	{
		[Token(Token = "0x60070B5")]
		[Address(RVA = "0x4582A0", Offset = "0x4570A0", Length = "0x3")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000825")]
	public override int maxInConnections
	{
		[Token(Token = "0x60070B6")]
		[Address(RVA = "0x4582A0", Offset = "0x4570A0", Length = "0x3")]
		get
		{
			return 0;
		}
	}

	[Token(Token = "0x17000826")]
	public override int maxOutConnections
	{
		[Token(Token = "0x60070B7")]
		[Address(RVA = "0x4582A0", Offset = "0x4570A0", Length = "0x3")]
		get
		{
			return 0;
		}
	}

	[Token(Token = "0x17000827")]
	public override bool allowAsPrime
	{
		[Token(Token = "0x60070B8")]
		[Address(RVA = "0x4A2140", Offset = "0x4A0F40", Length = "0x3")]
		get
		{
			return false;
		}
	}

	[Token(Token = "0x17000828")]
	public override Alignment2x2 commentsAlignment
	{
		[Token(Token = "0x60070B9")]
		[Address(RVA = "0x901E60", Offset = "0x900C60", Length = "0x6")]
		get
		{
			return default(Alignment2x2);
		}
	}

	[Token(Token = "0x17000829")]
	public override Alignment2x2 iconAlignment
	{
		[Token(Token = "0x60070BA")]
		[Address(RVA = "0x4582A0", Offset = "0x4570A0", Length = "0x3")]
		get
		{
			return default(Alignment2x2);
		}
	}

	[Token(Token = "0x60070BB")]
	[Address(RVA = "0x10AEDC0", Offset = "0x10ADBC0", Length = "0x7")]
	public MissingNode()
	{
	}
}
