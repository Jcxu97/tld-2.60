using System;
using Cpp2ILInjected;

namespace Rewired;

[Token(Token = "0x2000BFE")]
public sealed class FlightYokeTemplate : ControllerTemplate, IFlightYokeTemplate, IControllerTemplate
{
	[Token(Token = "0x4007AF1")]
	public static readonly Guid typeGuid;

	[Token(Token = "0x4007AF2")]
	public const int elementId_rotateYoke = 0;

	[Token(Token = "0x4007AF3")]
	public const int elementId_yokeZ = 1;

	[Token(Token = "0x4007AF4")]
	public const int elementId_leftPaddle = 59;

	[Token(Token = "0x4007AF5")]
	public const int elementId_rightPaddle = 60;

	[Token(Token = "0x4007AF6")]
	public const int elementId_lever1Axis = 2;

	[Token(Token = "0x4007AF7")]
	public const int elementId_lever1MinDetent = 64;

	[Token(Token = "0x4007AF8")]
	public const int elementId_lever2Axis = 3;

	[Token(Token = "0x4007AF9")]
	public const int elementId_lever2MinDetent = 65;

	[Token(Token = "0x4007AFA")]
	public const int elementId_lever3Axis = 4;

	[Token(Token = "0x4007AFB")]
	public const int elementId_lever3MinDetent = 66;

	[Token(Token = "0x4007AFC")]
	public const int elementId_lever4Axis = 5;

	[Token(Token = "0x4007AFD")]
	public const int elementId_lever4MinDetent = 67;

	[Token(Token = "0x4007AFE")]
	public const int elementId_lever5Axis = 6;

	[Token(Token = "0x4007AFF")]
	public const int elementId_lever5MinDetent = 68;

	[Token(Token = "0x4007B00")]
	public const int elementId_leftGripButton1 = 7;

	[Token(Token = "0x4007B01")]
	public const int elementId_leftGripButton2 = 8;

	[Token(Token = "0x4007B02")]
	public const int elementId_leftGripButton3 = 9;

	[Token(Token = "0x4007B03")]
	public const int elementId_leftGripButton4 = 10;

	[Token(Token = "0x4007B04")]
	public const int elementId_leftGripButton5 = 11;

	[Token(Token = "0x4007B05")]
	public const int elementId_leftGripButton6 = 12;

	[Token(Token = "0x4007B06")]
	public const int elementId_rightGripButton1 = 13;

	[Token(Token = "0x4007B07")]
	public const int elementId_rightGripButton2 = 14;

	[Token(Token = "0x4007B08")]
	public const int elementId_rightGripButton3 = 15;

	[Token(Token = "0x4007B09")]
	public const int elementId_rightGripButton4 = 16;

	[Token(Token = "0x4007B0A")]
	public const int elementId_rightGripButton5 = 17;

	[Token(Token = "0x4007B0B")]
	public const int elementId_rightGripButton6 = 18;

	[Token(Token = "0x4007B0C")]
	public const int elementId_centerButton1 = 19;

	[Token(Token = "0x4007B0D")]
	public const int elementId_centerButton2 = 20;

	[Token(Token = "0x4007B0E")]
	public const int elementId_centerButton3 = 21;

	[Token(Token = "0x4007B0F")]
	public const int elementId_centerButton4 = 22;

	[Token(Token = "0x4007B10")]
	public const int elementId_centerButton5 = 23;

	[Token(Token = "0x4007B11")]
	public const int elementId_centerButton6 = 24;

	[Token(Token = "0x4007B12")]
	public const int elementId_centerButton7 = 25;

	[Token(Token = "0x4007B13")]
	public const int elementId_centerButton8 = 26;

	[Token(Token = "0x4007B14")]
	public const int elementId_wheel1Up = 53;

	[Token(Token = "0x4007B15")]
	public const int elementId_wheel1Down = 54;

	[Token(Token = "0x4007B16")]
	public const int elementId_wheel1Press = 55;

	[Token(Token = "0x4007B17")]
	public const int elementId_wheel2Up = 56;

	[Token(Token = "0x4007B18")]
	public const int elementId_wheel2Down = 57;

	[Token(Token = "0x4007B19")]
	public const int elementId_wheel2Press = 58;

	[Token(Token = "0x4007B1A")]
	public const int elementId_leftGripHatUp = 27;

	[Token(Token = "0x4007B1B")]
	public const int elementId_leftGripHatUpRight = 28;

	[Token(Token = "0x4007B1C")]
	public const int elementId_leftGripHatRight = 29;

	[Token(Token = "0x4007B1D")]
	public const int elementId_leftGripHatDownRight = 30;

	[Token(Token = "0x4007B1E")]
	public const int elementId_leftGripHatDown = 31;

	[Token(Token = "0x4007B1F")]
	public const int elementId_leftGripHatDownLeft = 32;

	[Token(Token = "0x4007B20")]
	public const int elementId_leftGripHatLeft = 33;

	[Token(Token = "0x4007B21")]
	public const int elementId_leftGripHatUpLeft = 34;

	[Token(Token = "0x4007B22")]
	public const int elementId_rightGripHatUp = 35;

	[Token(Token = "0x4007B23")]
	public const int elementId_rightGripHatUpRight = 36;

	[Token(Token = "0x4007B24")]
	public const int elementId_rightGripHatRight = 37;

	[Token(Token = "0x4007B25")]
	public const int elementId_rightGripHatDownRight = 38;

	[Token(Token = "0x4007B26")]
	public const int elementId_rightGripHatDown = 39;

	[Token(Token = "0x4007B27")]
	public const int elementId_rightGripHatDownLeft = 40;

	[Token(Token = "0x4007B28")]
	public const int elementId_rightGripHatLeft = 41;

	[Token(Token = "0x4007B29")]
	public const int elementId_rightGripHatUpLeft = 42;

	[Token(Token = "0x4007B2A")]
	public const int elementId_consoleButton1 = 43;

	[Token(Token = "0x4007B2B")]
	public const int elementId_consoleButton2 = 44;

	[Token(Token = "0x4007B2C")]
	public const int elementId_consoleButton3 = 45;

	[Token(Token = "0x4007B2D")]
	public const int elementId_consoleButton4 = 46;

	[Token(Token = "0x4007B2E")]
	public const int elementId_consoleButton5 = 47;

	[Token(Token = "0x4007B2F")]
	public const int elementId_consoleButton6 = 48;

	[Token(Token = "0x4007B30")]
	public const int elementId_consoleButton7 = 49;

	[Token(Token = "0x4007B31")]
	public const int elementId_consoleButton8 = 50;

	[Token(Token = "0x4007B32")]
	public const int elementId_consoleButton9 = 51;

	[Token(Token = "0x4007B33")]
	public const int elementId_consoleButton10 = 52;

	[Token(Token = "0x4007B34")]
	public const int elementId_mode1 = 61;

	[Token(Token = "0x4007B35")]
	public const int elementId_mode2 = 62;

	[Token(Token = "0x4007B36")]
	public const int elementId_mode3 = 63;

	[Token(Token = "0x4007B37")]
	public const int elementId_yoke = 69;

	[Token(Token = "0x4007B38")]
	public const int elementId_lever1 = 70;

	[Token(Token = "0x4007B39")]
	public const int elementId_lever2 = 71;

	[Token(Token = "0x4007B3A")]
	public const int elementId_lever3 = 72;

	[Token(Token = "0x4007B3B")]
	public const int elementId_lever4 = 73;

	[Token(Token = "0x4007B3C")]
	public const int elementId_lever5 = 74;

	[Token(Token = "0x4007B3D")]
	public const int elementId_leftGripHat = 75;

	[Token(Token = "0x4007B3E")]
	public const int elementId_rightGripHat = 76;

	[Token(Token = "0x170005BC")]
	IControllerTemplateButton IFlightYokeTemplate.leftPaddle
	{
		[Token(Token = "0x6006010")]
		[Address(RVA = "0xF77930", Offset = "0xF76730", Length = "0x43")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170005BD")]
	IControllerTemplateButton IFlightYokeTemplate.rightPaddle
	{
		[Token(Token = "0x6006011")]
		[Address(RVA = "0xF77980", Offset = "0xF76780", Length = "0x43")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170005BE")]
	IControllerTemplateButton IFlightYokeTemplate.leftGripButton1
	{
		[Token(Token = "0x6006012")]
		[Address(RVA = "0xF779D0", Offset = "0xF767D0", Length = "0x43")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170005BF")]
	IControllerTemplateButton IFlightYokeTemplate.leftGripButton2
	{
		[Token(Token = "0x6006013")]
		[Address(RVA = "0xF77A20", Offset = "0xF76820", Length = "0x43")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170005C0")]
	IControllerTemplateButton IFlightYokeTemplate.leftGripButton3
	{
		[Token(Token = "0x6006014")]
		[Address(RVA = "0xF77A70", Offset = "0xF76870", Length = "0x43")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170005C1")]
	IControllerTemplateButton IFlightYokeTemplate.leftGripButton4
	{
		[Token(Token = "0x6006015")]
		[Address(RVA = "0xF77AC0", Offset = "0xF768C0", Length = "0x43")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170005C2")]
	IControllerTemplateButton IFlightYokeTemplate.leftGripButton5
	{
		[Token(Token = "0x6006016")]
		[Address(RVA = "0xF77B10", Offset = "0xF76910", Length = "0x43")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170005C3")]
	IControllerTemplateButton IFlightYokeTemplate.leftGripButton6
	{
		[Token(Token = "0x6006017")]
		[Address(RVA = "0xF77B60", Offset = "0xF76960", Length = "0x43")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170005C4")]
	IControllerTemplateButton IFlightYokeTemplate.rightGripButton1
	{
		[Token(Token = "0x6006018")]
		[Address(RVA = "0xF77BB0", Offset = "0xF769B0", Length = "0x43")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170005C5")]
	IControllerTemplateButton IFlightYokeTemplate.rightGripButton2
	{
		[Token(Token = "0x6006019")]
		[Address(RVA = "0xF77C00", Offset = "0xF76A00", Length = "0x43")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170005C6")]
	IControllerTemplateButton IFlightYokeTemplate.rightGripButton3
	{
		[Token(Token = "0x600601A")]
		[Address(RVA = "0xF77C50", Offset = "0xF76A50", Length = "0x43")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170005C7")]
	IControllerTemplateButton IFlightYokeTemplate.rightGripButton4
	{
		[Token(Token = "0x600601B")]
		[Address(RVA = "0xF77CA0", Offset = "0xF76AA0", Length = "0x43")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170005C8")]
	IControllerTemplateButton IFlightYokeTemplate.rightGripButton5
	{
		[Token(Token = "0x600601C")]
		[Address(RVA = "0xF77CF0", Offset = "0xF76AF0", Length = "0x43")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170005C9")]
	IControllerTemplateButton IFlightYokeTemplate.rightGripButton6
	{
		[Token(Token = "0x600601D")]
		[Address(RVA = "0xF77D40", Offset = "0xF76B40", Length = "0x43")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170005CA")]
	IControllerTemplateButton IFlightYokeTemplate.centerButton1
	{
		[Token(Token = "0x600601E")]
		[Address(RVA = "0xF77D90", Offset = "0xF76B90", Length = "0x43")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170005CB")]
	IControllerTemplateButton IFlightYokeTemplate.centerButton2
	{
		[Token(Token = "0x600601F")]
		[Address(RVA = "0xF77DE0", Offset = "0xF76BE0", Length = "0x43")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170005CC")]
	IControllerTemplateButton IFlightYokeTemplate.centerButton3
	{
		[Token(Token = "0x6006020")]
		[Address(RVA = "0xF77E30", Offset = "0xF76C30", Length = "0x43")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170005CD")]
	IControllerTemplateButton IFlightYokeTemplate.centerButton4
	{
		[Token(Token = "0x6006021")]
		[Address(RVA = "0xF77E80", Offset = "0xF76C80", Length = "0x43")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170005CE")]
	IControllerTemplateButton IFlightYokeTemplate.centerButton5
	{
		[Token(Token = "0x6006022")]
		[Address(RVA = "0xF77ED0", Offset = "0xF76CD0", Length = "0x43")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170005CF")]
	IControllerTemplateButton IFlightYokeTemplate.centerButton6
	{
		[Token(Token = "0x6006023")]
		[Address(RVA = "0xF77F20", Offset = "0xF76D20", Length = "0x43")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170005D0")]
	IControllerTemplateButton IFlightYokeTemplate.centerButton7
	{
		[Token(Token = "0x6006024")]
		[Address(RVA = "0xF77F70", Offset = "0xF76D70", Length = "0x43")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170005D1")]
	IControllerTemplateButton IFlightYokeTemplate.centerButton8
	{
		[Token(Token = "0x6006025")]
		[Address(RVA = "0xF77FC0", Offset = "0xF76DC0", Length = "0x43")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170005D2")]
	IControllerTemplateButton IFlightYokeTemplate.wheel1Up
	{
		[Token(Token = "0x6006026")]
		[Address(RVA = "0xF78010", Offset = "0xF76E10", Length = "0x43")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170005D3")]
	IControllerTemplateButton IFlightYokeTemplate.wheel1Down
	{
		[Token(Token = "0x6006027")]
		[Address(RVA = "0xF78060", Offset = "0xF76E60", Length = "0x43")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170005D4")]
	IControllerTemplateButton IFlightYokeTemplate.wheel1Press
	{
		[Token(Token = "0x6006028")]
		[Address(RVA = "0xF780B0", Offset = "0xF76EB0", Length = "0x43")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170005D5")]
	IControllerTemplateButton IFlightYokeTemplate.wheel2Up
	{
		[Token(Token = "0x6006029")]
		[Address(RVA = "0xF78100", Offset = "0xF76F00", Length = "0x43")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170005D6")]
	IControllerTemplateButton IFlightYokeTemplate.wheel2Down
	{
		[Token(Token = "0x600602A")]
		[Address(RVA = "0xF78150", Offset = "0xF76F50", Length = "0x43")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170005D7")]
	IControllerTemplateButton IFlightYokeTemplate.wheel2Press
	{
		[Token(Token = "0x600602B")]
		[Address(RVA = "0xF781A0", Offset = "0xF76FA0", Length = "0x43")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170005D8")]
	IControllerTemplateButton IFlightYokeTemplate.consoleButton1
	{
		[Token(Token = "0x600602C")]
		[Address(RVA = "0xF781F0", Offset = "0xF76FF0", Length = "0x43")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170005D9")]
	IControllerTemplateButton IFlightYokeTemplate.consoleButton2
	{
		[Token(Token = "0x600602D")]
		[Address(RVA = "0xF78240", Offset = "0xF77040", Length = "0x43")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170005DA")]
	IControllerTemplateButton IFlightYokeTemplate.consoleButton3
	{
		[Token(Token = "0x600602E")]
		[Address(RVA = "0xF78290", Offset = "0xF77090", Length = "0x43")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170005DB")]
	IControllerTemplateButton IFlightYokeTemplate.consoleButton4
	{
		[Token(Token = "0x600602F")]
		[Address(RVA = "0xF782E0", Offset = "0xF770E0", Length = "0x43")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170005DC")]
	IControllerTemplateButton IFlightYokeTemplate.consoleButton5
	{
		[Token(Token = "0x6006030")]
		[Address(RVA = "0xF78330", Offset = "0xF77130", Length = "0x43")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170005DD")]
	IControllerTemplateButton IFlightYokeTemplate.consoleButton6
	{
		[Token(Token = "0x6006031")]
		[Address(RVA = "0xF78380", Offset = "0xF77180", Length = "0x43")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170005DE")]
	IControllerTemplateButton IFlightYokeTemplate.consoleButton7
	{
		[Token(Token = "0x6006032")]
		[Address(RVA = "0xF783D0", Offset = "0xF771D0", Length = "0x43")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170005DF")]
	IControllerTemplateButton IFlightYokeTemplate.consoleButton8
	{
		[Token(Token = "0x6006033")]
		[Address(RVA = "0xF78420", Offset = "0xF77220", Length = "0x43")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170005E0")]
	IControllerTemplateButton IFlightYokeTemplate.consoleButton9
	{
		[Token(Token = "0x6006034")]
		[Address(RVA = "0xF78470", Offset = "0xF77270", Length = "0x43")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170005E1")]
	IControllerTemplateButton IFlightYokeTemplate.consoleButton10
	{
		[Token(Token = "0x6006035")]
		[Address(RVA = "0xF784C0", Offset = "0xF772C0", Length = "0x43")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170005E2")]
	IControllerTemplateButton IFlightYokeTemplate.mode1
	{
		[Token(Token = "0x6006036")]
		[Address(RVA = "0xF78510", Offset = "0xF77310", Length = "0x43")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170005E3")]
	IControllerTemplateButton IFlightYokeTemplate.mode2
	{
		[Token(Token = "0x6006037")]
		[Address(RVA = "0xF78560", Offset = "0xF77360", Length = "0x43")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170005E4")]
	IControllerTemplateButton IFlightYokeTemplate.mode3
	{
		[Token(Token = "0x6006038")]
		[Address(RVA = "0xF785B0", Offset = "0xF773B0", Length = "0x43")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170005E5")]
	IControllerTemplateYoke IFlightYokeTemplate.yoke
	{
		[Token(Token = "0x6006039")]
		[Address(RVA = "0xF78600", Offset = "0xF77400", Length = "0x43")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170005E6")]
	IControllerTemplateThrottle IFlightYokeTemplate.lever1
	{
		[Token(Token = "0x600603A")]
		[Address(RVA = "0xF78650", Offset = "0xF77450", Length = "0x43")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170005E7")]
	IControllerTemplateThrottle IFlightYokeTemplate.lever2
	{
		[Token(Token = "0x600603B")]
		[Address(RVA = "0xF786A0", Offset = "0xF774A0", Length = "0x43")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170005E8")]
	IControllerTemplateThrottle IFlightYokeTemplate.lever3
	{
		[Token(Token = "0x600603C")]
		[Address(RVA = "0xF786F0", Offset = "0xF774F0", Length = "0x43")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170005E9")]
	IControllerTemplateThrottle IFlightYokeTemplate.lever4
	{
		[Token(Token = "0x600603D")]
		[Address(RVA = "0xF78740", Offset = "0xF77540", Length = "0x43")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170005EA")]
	IControllerTemplateThrottle IFlightYokeTemplate.lever5
	{
		[Token(Token = "0x600603E")]
		[Address(RVA = "0xF78790", Offset = "0xF77590", Length = "0x43")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170005EB")]
	IControllerTemplateHat IFlightYokeTemplate.leftGripHat
	{
		[Token(Token = "0x600603F")]
		[Address(RVA = "0xF787E0", Offset = "0xF775E0", Length = "0x43")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170005EC")]
	IControllerTemplateHat IFlightYokeTemplate.rightGripHat
	{
		[Token(Token = "0x6006040")]
		[Address(RVA = "0xF78830", Offset = "0xF77630", Length = "0x43")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6006041")]
	[Address(RVA = "0xF74C00", Offset = "0xF73A00", Length = "0x7D")]
	public FlightYokeTemplate(object payload)
		: base(null)
	{
	}
}
