using System;
using Cpp2ILInjected;

namespace Rewired;

[Token(Token = "0x2000BFB")]
public sealed class GamepadTemplate : ControllerTemplate, IGamepadTemplate, IControllerTemplate
{
	[Token(Token = "0x40079F1")]
	public static readonly Guid typeGuid;

	[Token(Token = "0x40079F2")]
	public const int elementId_leftStickX = 0;

	[Token(Token = "0x40079F3")]
	public const int elementId_leftStickY = 1;

	[Token(Token = "0x40079F4")]
	public const int elementId_rightStickX = 2;

	[Token(Token = "0x40079F5")]
	public const int elementId_rightStickY = 3;

	[Token(Token = "0x40079F6")]
	public const int elementId_actionBottomRow1 = 4;

	[Token(Token = "0x40079F7")]
	public const int elementId_a = 4;

	[Token(Token = "0x40079F8")]
	public const int elementId_actionBottomRow2 = 5;

	[Token(Token = "0x40079F9")]
	public const int elementId_b = 5;

	[Token(Token = "0x40079FA")]
	public const int elementId_actionBottomRow3 = 6;

	[Token(Token = "0x40079FB")]
	public const int elementId_c = 6;

	[Token(Token = "0x40079FC")]
	public const int elementId_actionTopRow1 = 7;

	[Token(Token = "0x40079FD")]
	public const int elementId_x = 7;

	[Token(Token = "0x40079FE")]
	public const int elementId_actionTopRow2 = 8;

	[Token(Token = "0x40079FF")]
	public const int elementId_y = 8;

	[Token(Token = "0x4007A00")]
	public const int elementId_actionTopRow3 = 9;

	[Token(Token = "0x4007A01")]
	public const int elementId_z = 9;

	[Token(Token = "0x4007A02")]
	public const int elementId_leftShoulder1 = 10;

	[Token(Token = "0x4007A03")]
	public const int elementId_leftBumper = 10;

	[Token(Token = "0x4007A04")]
	public const int elementId_leftShoulder2 = 11;

	[Token(Token = "0x4007A05")]
	public const int elementId_leftTrigger = 11;

	[Token(Token = "0x4007A06")]
	public const int elementId_rightShoulder1 = 12;

	[Token(Token = "0x4007A07")]
	public const int elementId_rightBumper = 12;

	[Token(Token = "0x4007A08")]
	public const int elementId_rightShoulder2 = 13;

	[Token(Token = "0x4007A09")]
	public const int elementId_rightTrigger = 13;

	[Token(Token = "0x4007A0A")]
	public const int elementId_center1 = 14;

	[Token(Token = "0x4007A0B")]
	public const int elementId_back = 14;

	[Token(Token = "0x4007A0C")]
	public const int elementId_center2 = 15;

	[Token(Token = "0x4007A0D")]
	public const int elementId_start = 15;

	[Token(Token = "0x4007A0E")]
	public const int elementId_center3 = 16;

	[Token(Token = "0x4007A0F")]
	public const int elementId_guide = 16;

	[Token(Token = "0x4007A10")]
	public const int elementId_leftStickButton = 17;

	[Token(Token = "0x4007A11")]
	public const int elementId_rightStickButton = 18;

	[Token(Token = "0x4007A12")]
	public const int elementId_dPadUp = 19;

	[Token(Token = "0x4007A13")]
	public const int elementId_dPadRight = 20;

	[Token(Token = "0x4007A14")]
	public const int elementId_dPadDown = 21;

	[Token(Token = "0x4007A15")]
	public const int elementId_dPadLeft = 22;

	[Token(Token = "0x4007A16")]
	public const int elementId_leftStick = 23;

	[Token(Token = "0x4007A17")]
	public const int elementId_rightStick = 24;

	[Token(Token = "0x4007A18")]
	public const int elementId_dPad = 25;

	[Token(Token = "0x1700051D")]
	IControllerTemplateButton IGamepadTemplate.actionBottomRow1
	{
		[Token(Token = "0x6005F6B")]
		[Address(RVA = "0xF742F0", Offset = "0xF730F0", Length = "0x43")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700051E")]
	IControllerTemplateButton IGamepadTemplate.a
	{
		[Token(Token = "0x6005F6C")]
		[Address(RVA = "0xF74340", Offset = "0xF73140", Length = "0x43")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700051F")]
	IControllerTemplateButton IGamepadTemplate.actionBottomRow2
	{
		[Token(Token = "0x6005F6D")]
		[Address(RVA = "0xF74390", Offset = "0xF73190", Length = "0x43")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000520")]
	IControllerTemplateButton IGamepadTemplate.b
	{
		[Token(Token = "0x6005F6E")]
		[Address(RVA = "0xF743E0", Offset = "0xF731E0", Length = "0x43")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000521")]
	IControllerTemplateButton IGamepadTemplate.actionBottomRow3
	{
		[Token(Token = "0x6005F6F")]
		[Address(RVA = "0xF74430", Offset = "0xF73230", Length = "0x43")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000522")]
	IControllerTemplateButton IGamepadTemplate.c
	{
		[Token(Token = "0x6005F70")]
		[Address(RVA = "0xF74480", Offset = "0xF73280", Length = "0x43")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000523")]
	IControllerTemplateButton IGamepadTemplate.actionTopRow1
	{
		[Token(Token = "0x6005F71")]
		[Address(RVA = "0xF744D0", Offset = "0xF732D0", Length = "0x43")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000524")]
	IControllerTemplateButton IGamepadTemplate.x
	{
		[Token(Token = "0x6005F72")]
		[Address(RVA = "0xF74520", Offset = "0xF73320", Length = "0x43")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000525")]
	IControllerTemplateButton IGamepadTemplate.actionTopRow2
	{
		[Token(Token = "0x6005F73")]
		[Address(RVA = "0xF74570", Offset = "0xF73370", Length = "0x43")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000526")]
	IControllerTemplateButton IGamepadTemplate.y
	{
		[Token(Token = "0x6005F74")]
		[Address(RVA = "0xF745C0", Offset = "0xF733C0", Length = "0x43")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000527")]
	IControllerTemplateButton IGamepadTemplate.actionTopRow3
	{
		[Token(Token = "0x6005F75")]
		[Address(RVA = "0xF74610", Offset = "0xF73410", Length = "0x43")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000528")]
	IControllerTemplateButton IGamepadTemplate.z
	{
		[Token(Token = "0x6005F76")]
		[Address(RVA = "0xF74660", Offset = "0xF73460", Length = "0x43")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000529")]
	IControllerTemplateButton IGamepadTemplate.leftShoulder1
	{
		[Token(Token = "0x6005F77")]
		[Address(RVA = "0xF746B0", Offset = "0xF734B0", Length = "0x43")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700052A")]
	IControllerTemplateButton IGamepadTemplate.leftBumper
	{
		[Token(Token = "0x6005F78")]
		[Address(RVA = "0xF74700", Offset = "0xF73500", Length = "0x43")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700052B")]
	IControllerTemplateAxis IGamepadTemplate.leftShoulder2
	{
		[Token(Token = "0x6005F79")]
		[Address(RVA = "0xF74750", Offset = "0xF73550", Length = "0x43")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700052C")]
	IControllerTemplateAxis IGamepadTemplate.leftTrigger
	{
		[Token(Token = "0x6005F7A")]
		[Address(RVA = "0xF747A0", Offset = "0xF735A0", Length = "0x43")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700052D")]
	IControllerTemplateButton IGamepadTemplate.rightShoulder1
	{
		[Token(Token = "0x6005F7B")]
		[Address(RVA = "0xF747F0", Offset = "0xF735F0", Length = "0x43")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700052E")]
	IControllerTemplateButton IGamepadTemplate.rightBumper
	{
		[Token(Token = "0x6005F7C")]
		[Address(RVA = "0xF74840", Offset = "0xF73640", Length = "0x43")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700052F")]
	IControllerTemplateAxis IGamepadTemplate.rightShoulder2
	{
		[Token(Token = "0x6005F7D")]
		[Address(RVA = "0xF74890", Offset = "0xF73690", Length = "0x43")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000530")]
	IControllerTemplateAxis IGamepadTemplate.rightTrigger
	{
		[Token(Token = "0x6005F7E")]
		[Address(RVA = "0xF748E0", Offset = "0xF736E0", Length = "0x43")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000531")]
	IControllerTemplateButton IGamepadTemplate.center1
	{
		[Token(Token = "0x6005F7F")]
		[Address(RVA = "0xF74930", Offset = "0xF73730", Length = "0x43")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000532")]
	IControllerTemplateButton IGamepadTemplate.back
	{
		[Token(Token = "0x6005F80")]
		[Address(RVA = "0xF74980", Offset = "0xF73780", Length = "0x43")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000533")]
	IControllerTemplateButton IGamepadTemplate.center2
	{
		[Token(Token = "0x6005F81")]
		[Address(RVA = "0xF749D0", Offset = "0xF737D0", Length = "0x43")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000534")]
	IControllerTemplateButton IGamepadTemplate.start
	{
		[Token(Token = "0x6005F82")]
		[Address(RVA = "0xF74A20", Offset = "0xF73820", Length = "0x43")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000535")]
	IControllerTemplateButton IGamepadTemplate.center3
	{
		[Token(Token = "0x6005F83")]
		[Address(RVA = "0xF74A70", Offset = "0xF73870", Length = "0x43")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000536")]
	IControllerTemplateButton IGamepadTemplate.guide
	{
		[Token(Token = "0x6005F84")]
		[Address(RVA = "0xF74AC0", Offset = "0xF738C0", Length = "0x43")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000537")]
	IControllerTemplateThumbStick IGamepadTemplate.leftStick
	{
		[Token(Token = "0x6005F85")]
		[Address(RVA = "0xF74B10", Offset = "0xF73910", Length = "0x43")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000538")]
	IControllerTemplateThumbStick IGamepadTemplate.rightStick
	{
		[Token(Token = "0x6005F86")]
		[Address(RVA = "0xF74B60", Offset = "0xF73960", Length = "0x43")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000539")]
	IControllerTemplateDPad IGamepadTemplate.dPad
	{
		[Token(Token = "0x6005F87")]
		[Address(RVA = "0xF74BB0", Offset = "0xF739B0", Length = "0x43")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6005F88")]
	[Address(RVA = "0xF74C00", Offset = "0xF73A00", Length = "0x7D")]
	public GamepadTemplate(object payload)
		: base(null)
	{
	}
}
