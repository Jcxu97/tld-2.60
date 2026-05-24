using System;
using Cpp2ILInjected;

namespace Rewired;

[Token(Token = "0x2000BFF")]
public sealed class FlightPedalsTemplate : ControllerTemplate, IFlightPedalsTemplate, IControllerTemplate
{
	[Token(Token = "0x4007B3F")]
	public static readonly Guid typeGuid;

	[Token(Token = "0x4007B40")]
	public const int elementId_leftPedal = 0;

	[Token(Token = "0x4007B41")]
	public const int elementId_rightPedal = 1;

	[Token(Token = "0x4007B42")]
	public const int elementId_slide = 2;

	[Token(Token = "0x170005ED")]
	IControllerTemplateAxis IFlightPedalsTemplate.leftPedal
	{
		[Token(Token = "0x6006043")]
		[Address(RVA = "0xF789E0", Offset = "0xF777E0", Length = "0x40")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170005EE")]
	IControllerTemplateAxis IFlightPedalsTemplate.rightPedal
	{
		[Token(Token = "0x6006044")]
		[Address(RVA = "0xF78A20", Offset = "0xF77820", Length = "0x43")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170005EF")]
	IControllerTemplateAxis IFlightPedalsTemplate.slide
	{
		[Token(Token = "0x6006045")]
		[Address(RVA = "0xF78A70", Offset = "0xF77870", Length = "0x43")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6006046")]
	[Address(RVA = "0xF74C00", Offset = "0xF73A00", Length = "0x7D")]
	public FlightPedalsTemplate(object payload)
		: base(null)
	{
	}
}
