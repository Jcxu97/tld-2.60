using System;
using Cpp2ILInjected;

namespace Rewired;

[Token(Token = "0x2000BFC")]
public sealed class RacingWheelTemplate : ControllerTemplate, IRacingWheelTemplate, IControllerTemplate
{
	[Token(Token = "0x4007A19")]
	public static readonly Guid typeGuid;

	[Token(Token = "0x4007A1A")]
	public const int elementId_wheel = 0;

	[Token(Token = "0x4007A1B")]
	public const int elementId_accelerator = 1;

	[Token(Token = "0x4007A1C")]
	public const int elementId_brake = 2;

	[Token(Token = "0x4007A1D")]
	public const int elementId_clutch = 3;

	[Token(Token = "0x4007A1E")]
	public const int elementId_shiftDown = 4;

	[Token(Token = "0x4007A1F")]
	public const int elementId_shiftUp = 5;

	[Token(Token = "0x4007A20")]
	public const int elementId_wheelButton1 = 6;

	[Token(Token = "0x4007A21")]
	public const int elementId_wheelButton2 = 7;

	[Token(Token = "0x4007A22")]
	public const int elementId_wheelButton3 = 8;

	[Token(Token = "0x4007A23")]
	public const int elementId_wheelButton4 = 9;

	[Token(Token = "0x4007A24")]
	public const int elementId_wheelButton5 = 10;

	[Token(Token = "0x4007A25")]
	public const int elementId_wheelButton6 = 11;

	[Token(Token = "0x4007A26")]
	public const int elementId_wheelButton7 = 12;

	[Token(Token = "0x4007A27")]
	public const int elementId_wheelButton8 = 13;

	[Token(Token = "0x4007A28")]
	public const int elementId_wheelButton9 = 14;

	[Token(Token = "0x4007A29")]
	public const int elementId_wheelButton10 = 15;

	[Token(Token = "0x4007A2A")]
	public const int elementId_consoleButton1 = 16;

	[Token(Token = "0x4007A2B")]
	public const int elementId_consoleButton2 = 17;

	[Token(Token = "0x4007A2C")]
	public const int elementId_consoleButton3 = 18;

	[Token(Token = "0x4007A2D")]
	public const int elementId_consoleButton4 = 19;

	[Token(Token = "0x4007A2E")]
	public const int elementId_consoleButton5 = 20;

	[Token(Token = "0x4007A2F")]
	public const int elementId_consoleButton6 = 21;

	[Token(Token = "0x4007A30")]
	public const int elementId_consoleButton7 = 22;

	[Token(Token = "0x4007A31")]
	public const int elementId_consoleButton8 = 23;

	[Token(Token = "0x4007A32")]
	public const int elementId_consoleButton9 = 24;

	[Token(Token = "0x4007A33")]
	public const int elementId_consoleButton10 = 25;

	[Token(Token = "0x4007A34")]
	public const int elementId_shifter1 = 26;

	[Token(Token = "0x4007A35")]
	public const int elementId_shifter2 = 27;

	[Token(Token = "0x4007A36")]
	public const int elementId_shifter3 = 28;

	[Token(Token = "0x4007A37")]
	public const int elementId_shifter4 = 29;

	[Token(Token = "0x4007A38")]
	public const int elementId_shifter5 = 30;

	[Token(Token = "0x4007A39")]
	public const int elementId_shifter6 = 31;

	[Token(Token = "0x4007A3A")]
	public const int elementId_shifter7 = 32;

	[Token(Token = "0x4007A3B")]
	public const int elementId_shifter8 = 33;

	[Token(Token = "0x4007A3C")]
	public const int elementId_shifter9 = 34;

	[Token(Token = "0x4007A3D")]
	public const int elementId_shifter10 = 35;

	[Token(Token = "0x4007A3E")]
	public const int elementId_reverseGear = 44;

	[Token(Token = "0x4007A3F")]
	public const int elementId_select = 36;

	[Token(Token = "0x4007A40")]
	public const int elementId_start = 37;

	[Token(Token = "0x4007A41")]
	public const int elementId_systemButton = 38;

	[Token(Token = "0x4007A42")]
	public const int elementId_horn = 43;

	[Token(Token = "0x4007A43")]
	public const int elementId_dPadUp = 39;

	[Token(Token = "0x4007A44")]
	public const int elementId_dPadRight = 40;

	[Token(Token = "0x4007A45")]
	public const int elementId_dPadDown = 41;

	[Token(Token = "0x4007A46")]
	public const int elementId_dPadLeft = 42;

	[Token(Token = "0x4007A47")]
	public const int elementId_dPad = 45;

	[Token(Token = "0x1700053A")]
	IControllerTemplateAxis IRacingWheelTemplate.wheel
	{
		[Token(Token = "0x6005F8A")]
		[Address(RVA = "0xF74DE0", Offset = "0xF73BE0", Length = "0x40")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700053B")]
	IControllerTemplateAxis IRacingWheelTemplate.accelerator
	{
		[Token(Token = "0x6005F8B")]
		[Address(RVA = "0xF74E20", Offset = "0xF73C20", Length = "0x43")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700053C")]
	IControllerTemplateAxis IRacingWheelTemplate.brake
	{
		[Token(Token = "0x6005F8C")]
		[Address(RVA = "0xF74E70", Offset = "0xF73C70", Length = "0x43")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700053D")]
	IControllerTemplateAxis IRacingWheelTemplate.clutch
	{
		[Token(Token = "0x6005F8D")]
		[Address(RVA = "0xF74EC0", Offset = "0xF73CC0", Length = "0x43")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700053E")]
	IControllerTemplateButton IRacingWheelTemplate.shiftDown
	{
		[Token(Token = "0x6005F8E")]
		[Address(RVA = "0xF74F10", Offset = "0xF73D10", Length = "0x43")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700053F")]
	IControllerTemplateButton IRacingWheelTemplate.shiftUp
	{
		[Token(Token = "0x6005F8F")]
		[Address(RVA = "0xF74F60", Offset = "0xF73D60", Length = "0x43")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000540")]
	IControllerTemplateButton IRacingWheelTemplate.wheelButton1
	{
		[Token(Token = "0x6005F90")]
		[Address(RVA = "0xF74FB0", Offset = "0xF73DB0", Length = "0x43")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000541")]
	IControllerTemplateButton IRacingWheelTemplate.wheelButton2
	{
		[Token(Token = "0x6005F91")]
		[Address(RVA = "0xF75000", Offset = "0xF73E00", Length = "0x43")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000542")]
	IControllerTemplateButton IRacingWheelTemplate.wheelButton3
	{
		[Token(Token = "0x6005F92")]
		[Address(RVA = "0xF75050", Offset = "0xF73E50", Length = "0x43")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000543")]
	IControllerTemplateButton IRacingWheelTemplate.wheelButton4
	{
		[Token(Token = "0x6005F93")]
		[Address(RVA = "0xF750A0", Offset = "0xF73EA0", Length = "0x43")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000544")]
	IControllerTemplateButton IRacingWheelTemplate.wheelButton5
	{
		[Token(Token = "0x6005F94")]
		[Address(RVA = "0xF750F0", Offset = "0xF73EF0", Length = "0x43")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000545")]
	IControllerTemplateButton IRacingWheelTemplate.wheelButton6
	{
		[Token(Token = "0x6005F95")]
		[Address(RVA = "0xF75140", Offset = "0xF73F40", Length = "0x43")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000546")]
	IControllerTemplateButton IRacingWheelTemplate.wheelButton7
	{
		[Token(Token = "0x6005F96")]
		[Address(RVA = "0xF75190", Offset = "0xF73F90", Length = "0x43")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000547")]
	IControllerTemplateButton IRacingWheelTemplate.wheelButton8
	{
		[Token(Token = "0x6005F97")]
		[Address(RVA = "0xF751E0", Offset = "0xF73FE0", Length = "0x43")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000548")]
	IControllerTemplateButton IRacingWheelTemplate.wheelButton9
	{
		[Token(Token = "0x6005F98")]
		[Address(RVA = "0xF75230", Offset = "0xF74030", Length = "0x43")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000549")]
	IControllerTemplateButton IRacingWheelTemplate.wheelButton10
	{
		[Token(Token = "0x6005F99")]
		[Address(RVA = "0xF75280", Offset = "0xF74080", Length = "0x43")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700054A")]
	IControllerTemplateButton IRacingWheelTemplate.consoleButton1
	{
		[Token(Token = "0x6005F9A")]
		[Address(RVA = "0xF752D0", Offset = "0xF740D0", Length = "0x43")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700054B")]
	IControllerTemplateButton IRacingWheelTemplate.consoleButton2
	{
		[Token(Token = "0x6005F9B")]
		[Address(RVA = "0xF75320", Offset = "0xF74120", Length = "0x43")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700054C")]
	IControllerTemplateButton IRacingWheelTemplate.consoleButton3
	{
		[Token(Token = "0x6005F9C")]
		[Address(RVA = "0xF75370", Offset = "0xF74170", Length = "0x43")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700054D")]
	IControllerTemplateButton IRacingWheelTemplate.consoleButton4
	{
		[Token(Token = "0x6005F9D")]
		[Address(RVA = "0xF753C0", Offset = "0xF741C0", Length = "0x43")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700054E")]
	IControllerTemplateButton IRacingWheelTemplate.consoleButton5
	{
		[Token(Token = "0x6005F9E")]
		[Address(RVA = "0xF75410", Offset = "0xF74210", Length = "0x43")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700054F")]
	IControllerTemplateButton IRacingWheelTemplate.consoleButton6
	{
		[Token(Token = "0x6005F9F")]
		[Address(RVA = "0xF75460", Offset = "0xF74260", Length = "0x43")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000550")]
	IControllerTemplateButton IRacingWheelTemplate.consoleButton7
	{
		[Token(Token = "0x6005FA0")]
		[Address(RVA = "0xF754B0", Offset = "0xF742B0", Length = "0x43")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000551")]
	IControllerTemplateButton IRacingWheelTemplate.consoleButton8
	{
		[Token(Token = "0x6005FA1")]
		[Address(RVA = "0xF75500", Offset = "0xF74300", Length = "0x43")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000552")]
	IControllerTemplateButton IRacingWheelTemplate.consoleButton9
	{
		[Token(Token = "0x6005FA2")]
		[Address(RVA = "0xF75550", Offset = "0xF74350", Length = "0x43")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000553")]
	IControllerTemplateButton IRacingWheelTemplate.consoleButton10
	{
		[Token(Token = "0x6005FA3")]
		[Address(RVA = "0xF755A0", Offset = "0xF743A0", Length = "0x43")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000554")]
	IControllerTemplateButton IRacingWheelTemplate.shifter1
	{
		[Token(Token = "0x6005FA4")]
		[Address(RVA = "0xF755F0", Offset = "0xF743F0", Length = "0x43")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000555")]
	IControllerTemplateButton IRacingWheelTemplate.shifter2
	{
		[Token(Token = "0x6005FA5")]
		[Address(RVA = "0xF75640", Offset = "0xF74440", Length = "0x43")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000556")]
	IControllerTemplateButton IRacingWheelTemplate.shifter3
	{
		[Token(Token = "0x6005FA6")]
		[Address(RVA = "0xF75690", Offset = "0xF74490", Length = "0x43")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000557")]
	IControllerTemplateButton IRacingWheelTemplate.shifter4
	{
		[Token(Token = "0x6005FA7")]
		[Address(RVA = "0xF756E0", Offset = "0xF744E0", Length = "0x43")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000558")]
	IControllerTemplateButton IRacingWheelTemplate.shifter5
	{
		[Token(Token = "0x6005FA8")]
		[Address(RVA = "0xF75730", Offset = "0xF74530", Length = "0x43")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000559")]
	IControllerTemplateButton IRacingWheelTemplate.shifter6
	{
		[Token(Token = "0x6005FA9")]
		[Address(RVA = "0xF75780", Offset = "0xF74580", Length = "0x43")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700055A")]
	IControllerTemplateButton IRacingWheelTemplate.shifter7
	{
		[Token(Token = "0x6005FAA")]
		[Address(RVA = "0xF757D0", Offset = "0xF745D0", Length = "0x43")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700055B")]
	IControllerTemplateButton IRacingWheelTemplate.shifter8
	{
		[Token(Token = "0x6005FAB")]
		[Address(RVA = "0xF75820", Offset = "0xF74620", Length = "0x43")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700055C")]
	IControllerTemplateButton IRacingWheelTemplate.shifter9
	{
		[Token(Token = "0x6005FAC")]
		[Address(RVA = "0xF75870", Offset = "0xF74670", Length = "0x43")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700055D")]
	IControllerTemplateButton IRacingWheelTemplate.shifter10
	{
		[Token(Token = "0x6005FAD")]
		[Address(RVA = "0xF758C0", Offset = "0xF746C0", Length = "0x43")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700055E")]
	IControllerTemplateButton IRacingWheelTemplate.reverseGear
	{
		[Token(Token = "0x6005FAE")]
		[Address(RVA = "0xF75910", Offset = "0xF74710", Length = "0x43")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700055F")]
	IControllerTemplateButton IRacingWheelTemplate.select
	{
		[Token(Token = "0x6005FAF")]
		[Address(RVA = "0xF75960", Offset = "0xF74760", Length = "0x43")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000560")]
	IControllerTemplateButton IRacingWheelTemplate.start
	{
		[Token(Token = "0x6005FB0")]
		[Address(RVA = "0xF759B0", Offset = "0xF747B0", Length = "0x43")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000561")]
	IControllerTemplateButton IRacingWheelTemplate.systemButton
	{
		[Token(Token = "0x6005FB1")]
		[Address(RVA = "0xF75A00", Offset = "0xF74800", Length = "0x43")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000562")]
	IControllerTemplateButton IRacingWheelTemplate.horn
	{
		[Token(Token = "0x6005FB2")]
		[Address(RVA = "0xF75A50", Offset = "0xF74850", Length = "0x43")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000563")]
	IControllerTemplateDPad IRacingWheelTemplate.dPad
	{
		[Token(Token = "0x6005FB3")]
		[Address(RVA = "0xF75AA0", Offset = "0xF748A0", Length = "0x43")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6005FB4")]
	[Address(RVA = "0xF74C00", Offset = "0xF73A00", Length = "0x7D")]
	public RacingWheelTemplate(object payload)
		: base(null)
	{
	}
}
