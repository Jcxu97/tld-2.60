using System;
using Cpp2ILInjected;

namespace Rewired;

[Token(Token = "0x2000BFD")]
public sealed class HOTASTemplate : ControllerTemplate, IHOTASTemplate, IControllerTemplate
{
	[Token(Token = "0x4007A48")]
	public static readonly Guid typeGuid;

	[Token(Token = "0x4007A49")]
	public const int elementId_stickX = 0;

	[Token(Token = "0x4007A4A")]
	public const int elementId_stickY = 1;

	[Token(Token = "0x4007A4B")]
	public const int elementId_stickRotate = 2;

	[Token(Token = "0x4007A4C")]
	public const int elementId_stickMiniStick1X = 78;

	[Token(Token = "0x4007A4D")]
	public const int elementId_stickMiniStick1Y = 79;

	[Token(Token = "0x4007A4E")]
	public const int elementId_stickMiniStick1Press = 80;

	[Token(Token = "0x4007A4F")]
	public const int elementId_stickMiniStick2X = 81;

	[Token(Token = "0x4007A50")]
	public const int elementId_stickMiniStick2Y = 82;

	[Token(Token = "0x4007A51")]
	public const int elementId_stickMiniStick2Press = 83;

	[Token(Token = "0x4007A52")]
	public const int elementId_stickTrigger = 3;

	[Token(Token = "0x4007A53")]
	public const int elementId_stickTriggerStage2 = 4;

	[Token(Token = "0x4007A54")]
	public const int elementId_stickPinkyButton = 5;

	[Token(Token = "0x4007A55")]
	public const int elementId_stickPinkyTrigger = 154;

	[Token(Token = "0x4007A56")]
	public const int elementId_stickButton1 = 6;

	[Token(Token = "0x4007A57")]
	public const int elementId_stickButton2 = 7;

	[Token(Token = "0x4007A58")]
	public const int elementId_stickButton3 = 8;

	[Token(Token = "0x4007A59")]
	public const int elementId_stickButton4 = 9;

	[Token(Token = "0x4007A5A")]
	public const int elementId_stickButton5 = 10;

	[Token(Token = "0x4007A5B")]
	public const int elementId_stickButton6 = 11;

	[Token(Token = "0x4007A5C")]
	public const int elementId_stickButton7 = 12;

	[Token(Token = "0x4007A5D")]
	public const int elementId_stickButton8 = 13;

	[Token(Token = "0x4007A5E")]
	public const int elementId_stickButton9 = 14;

	[Token(Token = "0x4007A5F")]
	public const int elementId_stickButton10 = 15;

	[Token(Token = "0x4007A60")]
	public const int elementId_stickBaseButton1 = 18;

	[Token(Token = "0x4007A61")]
	public const int elementId_stickBaseButton2 = 19;

	[Token(Token = "0x4007A62")]
	public const int elementId_stickBaseButton3 = 20;

	[Token(Token = "0x4007A63")]
	public const int elementId_stickBaseButton4 = 21;

	[Token(Token = "0x4007A64")]
	public const int elementId_stickBaseButton5 = 22;

	[Token(Token = "0x4007A65")]
	public const int elementId_stickBaseButton6 = 23;

	[Token(Token = "0x4007A66")]
	public const int elementId_stickBaseButton7 = 24;

	[Token(Token = "0x4007A67")]
	public const int elementId_stickBaseButton8 = 25;

	[Token(Token = "0x4007A68")]
	public const int elementId_stickBaseButton9 = 26;

	[Token(Token = "0x4007A69")]
	public const int elementId_stickBaseButton10 = 27;

	[Token(Token = "0x4007A6A")]
	public const int elementId_stickBaseButton11 = 161;

	[Token(Token = "0x4007A6B")]
	public const int elementId_stickBaseButton12 = 162;

	[Token(Token = "0x4007A6C")]
	public const int elementId_stickHat1Up = 28;

	[Token(Token = "0x4007A6D")]
	public const int elementId_stickHat1UpRight = 29;

	[Token(Token = "0x4007A6E")]
	public const int elementId_stickHat1Right = 30;

	[Token(Token = "0x4007A6F")]
	public const int elementId_stickHat1DownRight = 31;

	[Token(Token = "0x4007A70")]
	public const int elementId_stickHat1Down = 32;

	[Token(Token = "0x4007A71")]
	public const int elementId_stickHat1DownLeft = 33;

	[Token(Token = "0x4007A72")]
	public const int elementId_stickHat1Left = 34;

	[Token(Token = "0x4007A73")]
	public const int elementId_stickHat1Up_Left = 35;

	[Token(Token = "0x4007A74")]
	public const int elementId_stickHat2Up = 36;

	[Token(Token = "0x4007A75")]
	public const int elementId_stickHat2Up_right = 37;

	[Token(Token = "0x4007A76")]
	public const int elementId_stickHat2Right = 38;

	[Token(Token = "0x4007A77")]
	public const int elementId_stickHat2Down_Right = 39;

	[Token(Token = "0x4007A78")]
	public const int elementId_stickHat2Down = 40;

	[Token(Token = "0x4007A79")]
	public const int elementId_stickHat2Down_Left = 41;

	[Token(Token = "0x4007A7A")]
	public const int elementId_stickHat2Left = 42;

	[Token(Token = "0x4007A7B")]
	public const int elementId_stickHat2Up_Left = 43;

	[Token(Token = "0x4007A7C")]
	public const int elementId_stickHat3Up = 84;

	[Token(Token = "0x4007A7D")]
	public const int elementId_stickHat3Up_Right = 85;

	[Token(Token = "0x4007A7E")]
	public const int elementId_stickHat3Right = 86;

	[Token(Token = "0x4007A7F")]
	public const int elementId_stickHat3Down_Right = 87;

	[Token(Token = "0x4007A80")]
	public const int elementId_stickHat3Down = 88;

	[Token(Token = "0x4007A81")]
	public const int elementId_stickHat3Down_Left = 89;

	[Token(Token = "0x4007A82")]
	public const int elementId_stickHat3Left = 90;

	[Token(Token = "0x4007A83")]
	public const int elementId_stickHat3Up_Left = 91;

	[Token(Token = "0x4007A84")]
	public const int elementId_stickHat4Up = 92;

	[Token(Token = "0x4007A85")]
	public const int elementId_stickHat4Up_Right = 93;

	[Token(Token = "0x4007A86")]
	public const int elementId_stickHat4Right = 94;

	[Token(Token = "0x4007A87")]
	public const int elementId_stickHat4Down_Right = 95;

	[Token(Token = "0x4007A88")]
	public const int elementId_stickHat4Down = 96;

	[Token(Token = "0x4007A89")]
	public const int elementId_stickHat4Down_Left = 97;

	[Token(Token = "0x4007A8A")]
	public const int elementId_stickHat4Left = 98;

	[Token(Token = "0x4007A8B")]
	public const int elementId_stickHat4Up_Left = 99;

	[Token(Token = "0x4007A8C")]
	public const int elementId_mode1 = 44;

	[Token(Token = "0x4007A8D")]
	public const int elementId_mode2 = 45;

	[Token(Token = "0x4007A8E")]
	public const int elementId_mode3 = 46;

	[Token(Token = "0x4007A8F")]
	public const int elementId_throttle1Axis = 49;

	[Token(Token = "0x4007A90")]
	public const int elementId_throttle2Axis = 155;

	[Token(Token = "0x4007A91")]
	public const int elementId_throttle1MinDetent = 166;

	[Token(Token = "0x4007A92")]
	public const int elementId_throttle2MinDetent = 167;

	[Token(Token = "0x4007A93")]
	public const int elementId_throttleButton1 = 50;

	[Token(Token = "0x4007A94")]
	public const int elementId_throttleButton2 = 51;

	[Token(Token = "0x4007A95")]
	public const int elementId_throttleButton3 = 52;

	[Token(Token = "0x4007A96")]
	public const int elementId_throttleButton4 = 53;

	[Token(Token = "0x4007A97")]
	public const int elementId_throttleButton5 = 54;

	[Token(Token = "0x4007A98")]
	public const int elementId_throttleButton6 = 55;

	[Token(Token = "0x4007A99")]
	public const int elementId_throttleButton7 = 56;

	[Token(Token = "0x4007A9A")]
	public const int elementId_throttleButton8 = 57;

	[Token(Token = "0x4007A9B")]
	public const int elementId_throttleButton9 = 58;

	[Token(Token = "0x4007A9C")]
	public const int elementId_throttleButton10 = 59;

	[Token(Token = "0x4007A9D")]
	public const int elementId_throttleBaseButton1 = 60;

	[Token(Token = "0x4007A9E")]
	public const int elementId_throttleBaseButton2 = 61;

	[Token(Token = "0x4007A9F")]
	public const int elementId_throttleBaseButton3 = 62;

	[Token(Token = "0x4007AA0")]
	public const int elementId_throttleBaseButton4 = 63;

	[Token(Token = "0x4007AA1")]
	public const int elementId_throttleBaseButton5 = 64;

	[Token(Token = "0x4007AA2")]
	public const int elementId_throttleBaseButton6 = 65;

	[Token(Token = "0x4007AA3")]
	public const int elementId_throttleBaseButton7 = 66;

	[Token(Token = "0x4007AA4")]
	public const int elementId_throttleBaseButton8 = 67;

	[Token(Token = "0x4007AA5")]
	public const int elementId_throttleBaseButton9 = 68;

	[Token(Token = "0x4007AA6")]
	public const int elementId_throttleBaseButton10 = 69;

	[Token(Token = "0x4007AA7")]
	public const int elementId_throttleBaseButton11 = 132;

	[Token(Token = "0x4007AA8")]
	public const int elementId_throttleBaseButton12 = 133;

	[Token(Token = "0x4007AA9")]
	public const int elementId_throttleBaseButton13 = 134;

	[Token(Token = "0x4007AAA")]
	public const int elementId_throttleBaseButton14 = 135;

	[Token(Token = "0x4007AAB")]
	public const int elementId_throttleBaseButton15 = 136;

	[Token(Token = "0x4007AAC")]
	public const int elementId_throttleSlider1 = 70;

	[Token(Token = "0x4007AAD")]
	public const int elementId_throttleSlider2 = 71;

	[Token(Token = "0x4007AAE")]
	public const int elementId_throttleSlider3 = 72;

	[Token(Token = "0x4007AAF")]
	public const int elementId_throttleSlider4 = 73;

	[Token(Token = "0x4007AB0")]
	public const int elementId_throttleDial1 = 74;

	[Token(Token = "0x4007AB1")]
	public const int elementId_throttleDial2 = 142;

	[Token(Token = "0x4007AB2")]
	public const int elementId_throttleDial3 = 143;

	[Token(Token = "0x4007AB3")]
	public const int elementId_throttleDial4 = 144;

	[Token(Token = "0x4007AB4")]
	public const int elementId_throttleMiniStickX = 75;

	[Token(Token = "0x4007AB5")]
	public const int elementId_throttleMiniStickY = 76;

	[Token(Token = "0x4007AB6")]
	public const int elementId_throttleMiniStickPress = 77;

	[Token(Token = "0x4007AB7")]
	public const int elementId_throttleWheel1Forward = 145;

	[Token(Token = "0x4007AB8")]
	public const int elementId_throttleWheel1Back = 146;

	[Token(Token = "0x4007AB9")]
	public const int elementId_throttleWheel1Press = 147;

	[Token(Token = "0x4007ABA")]
	public const int elementId_throttleWheel2Forward = 148;

	[Token(Token = "0x4007ABB")]
	public const int elementId_throttleWheel2Back = 149;

	[Token(Token = "0x4007ABC")]
	public const int elementId_throttleWheel2Press = 150;

	[Token(Token = "0x4007ABD")]
	public const int elementId_throttleWheel3Forward = 151;

	[Token(Token = "0x4007ABE")]
	public const int elementId_throttleWheel3Back = 152;

	[Token(Token = "0x4007ABF")]
	public const int elementId_throttleWheel3Press = 153;

	[Token(Token = "0x4007AC0")]
	public const int elementId_throttleHat1Up = 100;

	[Token(Token = "0x4007AC1")]
	public const int elementId_throttleHat1Up_Right = 101;

	[Token(Token = "0x4007AC2")]
	public const int elementId_throttleHat1Right = 102;

	[Token(Token = "0x4007AC3")]
	public const int elementId_throttleHat1Down_Right = 103;

	[Token(Token = "0x4007AC4")]
	public const int elementId_throttleHat1Down = 104;

	[Token(Token = "0x4007AC5")]
	public const int elementId_throttleHat1Down_Left = 105;

	[Token(Token = "0x4007AC6")]
	public const int elementId_throttleHat1Left = 106;

	[Token(Token = "0x4007AC7")]
	public const int elementId_throttleHat1Up_Left = 107;

	[Token(Token = "0x4007AC8")]
	public const int elementId_throttleHat2Up = 108;

	[Token(Token = "0x4007AC9")]
	public const int elementId_throttleHat2Up_Right = 109;

	[Token(Token = "0x4007ACA")]
	public const int elementId_throttleHat2Right = 110;

	[Token(Token = "0x4007ACB")]
	public const int elementId_throttleHat2Down_Right = 111;

	[Token(Token = "0x4007ACC")]
	public const int elementId_throttleHat2Down = 112;

	[Token(Token = "0x4007ACD")]
	public const int elementId_throttleHat2Down_Left = 113;

	[Token(Token = "0x4007ACE")]
	public const int elementId_throttleHat2Left = 114;

	[Token(Token = "0x4007ACF")]
	public const int elementId_throttleHat2Up_Left = 115;

	[Token(Token = "0x4007AD0")]
	public const int elementId_throttleHat3Up = 116;

	[Token(Token = "0x4007AD1")]
	public const int elementId_throttleHat3Up_Right = 117;

	[Token(Token = "0x4007AD2")]
	public const int elementId_throttleHat3Right = 118;

	[Token(Token = "0x4007AD3")]
	public const int elementId_throttleHat3Down_Right = 119;

	[Token(Token = "0x4007AD4")]
	public const int elementId_throttleHat3Down = 120;

	[Token(Token = "0x4007AD5")]
	public const int elementId_throttleHat3Down_Left = 121;

	[Token(Token = "0x4007AD6")]
	public const int elementId_throttleHat3Left = 122;

	[Token(Token = "0x4007AD7")]
	public const int elementId_throttleHat3Up_Left = 123;

	[Token(Token = "0x4007AD8")]
	public const int elementId_throttleHat4Up = 124;

	[Token(Token = "0x4007AD9")]
	public const int elementId_throttleHat4Up_Right = 125;

	[Token(Token = "0x4007ADA")]
	public const int elementId_throttleHat4Right = 126;

	[Token(Token = "0x4007ADB")]
	public const int elementId_throttleHat4Down_Right = 127;

	[Token(Token = "0x4007ADC")]
	public const int elementId_throttleHat4Down = 128;

	[Token(Token = "0x4007ADD")]
	public const int elementId_throttleHat4Down_Left = 129;

	[Token(Token = "0x4007ADE")]
	public const int elementId_throttleHat4Left = 130;

	[Token(Token = "0x4007ADF")]
	public const int elementId_throttleHat4Up_Left = 131;

	[Token(Token = "0x4007AE0")]
	public const int elementId_leftPedal = 168;

	[Token(Token = "0x4007AE1")]
	public const int elementId_rightPedal = 169;

	[Token(Token = "0x4007AE2")]
	public const int elementId_slidePedals = 170;

	[Token(Token = "0x4007AE3")]
	public const int elementId_stick = 171;

	[Token(Token = "0x4007AE4")]
	public const int elementId_stickMiniStick1 = 172;

	[Token(Token = "0x4007AE5")]
	public const int elementId_stickMiniStick2 = 173;

	[Token(Token = "0x4007AE6")]
	public const int elementId_stickHat1 = 174;

	[Token(Token = "0x4007AE7")]
	public const int elementId_stickHat2 = 175;

	[Token(Token = "0x4007AE8")]
	public const int elementId_stickHat3 = 176;

	[Token(Token = "0x4007AE9")]
	public const int elementId_stickHat4 = 177;

	[Token(Token = "0x4007AEA")]
	public const int elementId_throttle1 = 178;

	[Token(Token = "0x4007AEB")]
	public const int elementId_throttle2 = 179;

	[Token(Token = "0x4007AEC")]
	public const int elementId_throttleMiniStick = 180;

	[Token(Token = "0x4007AED")]
	public const int elementId_throttleHat1 = 181;

	[Token(Token = "0x4007AEE")]
	public const int elementId_throttleHat2 = 182;

	[Token(Token = "0x4007AEF")]
	public const int elementId_throttleHat3 = 183;

	[Token(Token = "0x4007AF0")]
	public const int elementId_throttleHat4 = 184;

	[Token(Token = "0x17000564")]
	IControllerTemplateButton IHOTASTemplate.stickTrigger
	{
		[Token(Token = "0x6005FB6")]
		[Address(RVA = "0xF75C50", Offset = "0xF74A50", Length = "0x43")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000565")]
	IControllerTemplateButton IHOTASTemplate.stickTriggerStage2
	{
		[Token(Token = "0x6005FB7")]
		[Address(RVA = "0xF75CA0", Offset = "0xF74AA0", Length = "0x43")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000566")]
	IControllerTemplateButton IHOTASTemplate.stickPinkyButton
	{
		[Token(Token = "0x6005FB8")]
		[Address(RVA = "0xF75CF0", Offset = "0xF74AF0", Length = "0x43")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000567")]
	IControllerTemplateButton IHOTASTemplate.stickPinkyTrigger
	{
		[Token(Token = "0x6005FB9")]
		[Address(RVA = "0xF75D40", Offset = "0xF74B40", Length = "0x43")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000568")]
	IControllerTemplateButton IHOTASTemplate.stickButton1
	{
		[Token(Token = "0x6005FBA")]
		[Address(RVA = "0xF75D90", Offset = "0xF74B90", Length = "0x43")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000569")]
	IControllerTemplateButton IHOTASTemplate.stickButton2
	{
		[Token(Token = "0x6005FBB")]
		[Address(RVA = "0xF75DE0", Offset = "0xF74BE0", Length = "0x43")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700056A")]
	IControllerTemplateButton IHOTASTemplate.stickButton3
	{
		[Token(Token = "0x6005FBC")]
		[Address(RVA = "0xF75E30", Offset = "0xF74C30", Length = "0x43")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700056B")]
	IControllerTemplateButton IHOTASTemplate.stickButton4
	{
		[Token(Token = "0x6005FBD")]
		[Address(RVA = "0xF75E80", Offset = "0xF74C80", Length = "0x43")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700056C")]
	IControllerTemplateButton IHOTASTemplate.stickButton5
	{
		[Token(Token = "0x6005FBE")]
		[Address(RVA = "0xF75ED0", Offset = "0xF74CD0", Length = "0x43")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700056D")]
	IControllerTemplateButton IHOTASTemplate.stickButton6
	{
		[Token(Token = "0x6005FBF")]
		[Address(RVA = "0xF75F20", Offset = "0xF74D20", Length = "0x43")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700056E")]
	IControllerTemplateButton IHOTASTemplate.stickButton7
	{
		[Token(Token = "0x6005FC0")]
		[Address(RVA = "0xF75F70", Offset = "0xF74D70", Length = "0x43")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700056F")]
	IControllerTemplateButton IHOTASTemplate.stickButton8
	{
		[Token(Token = "0x6005FC1")]
		[Address(RVA = "0xF75FC0", Offset = "0xF74DC0", Length = "0x43")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000570")]
	IControllerTemplateButton IHOTASTemplate.stickButton9
	{
		[Token(Token = "0x6005FC2")]
		[Address(RVA = "0xF76010", Offset = "0xF74E10", Length = "0x43")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000571")]
	IControllerTemplateButton IHOTASTemplate.stickButton10
	{
		[Token(Token = "0x6005FC3")]
		[Address(RVA = "0xF76060", Offset = "0xF74E60", Length = "0x43")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000572")]
	IControllerTemplateButton IHOTASTemplate.stickBaseButton1
	{
		[Token(Token = "0x6005FC4")]
		[Address(RVA = "0xF760B0", Offset = "0xF74EB0", Length = "0x43")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000573")]
	IControllerTemplateButton IHOTASTemplate.stickBaseButton2
	{
		[Token(Token = "0x6005FC5")]
		[Address(RVA = "0xF76100", Offset = "0xF74F00", Length = "0x43")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000574")]
	IControllerTemplateButton IHOTASTemplate.stickBaseButton3
	{
		[Token(Token = "0x6005FC6")]
		[Address(RVA = "0xF76150", Offset = "0xF74F50", Length = "0x43")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000575")]
	IControllerTemplateButton IHOTASTemplate.stickBaseButton4
	{
		[Token(Token = "0x6005FC7")]
		[Address(RVA = "0xF761A0", Offset = "0xF74FA0", Length = "0x43")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000576")]
	IControllerTemplateButton IHOTASTemplate.stickBaseButton5
	{
		[Token(Token = "0x6005FC8")]
		[Address(RVA = "0xF761F0", Offset = "0xF74FF0", Length = "0x43")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000577")]
	IControllerTemplateButton IHOTASTemplate.stickBaseButton6
	{
		[Token(Token = "0x6005FC9")]
		[Address(RVA = "0xF76240", Offset = "0xF75040", Length = "0x43")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000578")]
	IControllerTemplateButton IHOTASTemplate.stickBaseButton7
	{
		[Token(Token = "0x6005FCA")]
		[Address(RVA = "0xF76290", Offset = "0xF75090", Length = "0x43")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000579")]
	IControllerTemplateButton IHOTASTemplate.stickBaseButton8
	{
		[Token(Token = "0x6005FCB")]
		[Address(RVA = "0xF762E0", Offset = "0xF750E0", Length = "0x43")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700057A")]
	IControllerTemplateButton IHOTASTemplate.stickBaseButton9
	{
		[Token(Token = "0x6005FCC")]
		[Address(RVA = "0xF76330", Offset = "0xF75130", Length = "0x43")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700057B")]
	IControllerTemplateButton IHOTASTemplate.stickBaseButton10
	{
		[Token(Token = "0x6005FCD")]
		[Address(RVA = "0xF76380", Offset = "0xF75180", Length = "0x43")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700057C")]
	IControllerTemplateButton IHOTASTemplate.stickBaseButton11
	{
		[Token(Token = "0x6005FCE")]
		[Address(RVA = "0xF763D0", Offset = "0xF751D0", Length = "0x43")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700057D")]
	IControllerTemplateButton IHOTASTemplate.stickBaseButton12
	{
		[Token(Token = "0x6005FCF")]
		[Address(RVA = "0xF76420", Offset = "0xF75220", Length = "0x43")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700057E")]
	IControllerTemplateButton IHOTASTemplate.mode1
	{
		[Token(Token = "0x6005FD0")]
		[Address(RVA = "0xF76470", Offset = "0xF75270", Length = "0x43")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700057F")]
	IControllerTemplateButton IHOTASTemplate.mode2
	{
		[Token(Token = "0x6005FD1")]
		[Address(RVA = "0xF764C0", Offset = "0xF752C0", Length = "0x43")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000580")]
	IControllerTemplateButton IHOTASTemplate.mode3
	{
		[Token(Token = "0x6005FD2")]
		[Address(RVA = "0xF76510", Offset = "0xF75310", Length = "0x43")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000581")]
	IControllerTemplateButton IHOTASTemplate.throttleButton1
	{
		[Token(Token = "0x6005FD3")]
		[Address(RVA = "0xF76560", Offset = "0xF75360", Length = "0x43")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000582")]
	IControllerTemplateButton IHOTASTemplate.throttleButton2
	{
		[Token(Token = "0x6005FD4")]
		[Address(RVA = "0xF765B0", Offset = "0xF753B0", Length = "0x43")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000583")]
	IControllerTemplateButton IHOTASTemplate.throttleButton3
	{
		[Token(Token = "0x6005FD5")]
		[Address(RVA = "0xF76600", Offset = "0xF75400", Length = "0x43")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000584")]
	IControllerTemplateButton IHOTASTemplate.throttleButton4
	{
		[Token(Token = "0x6005FD6")]
		[Address(RVA = "0xF76650", Offset = "0xF75450", Length = "0x43")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000585")]
	IControllerTemplateButton IHOTASTemplate.throttleButton5
	{
		[Token(Token = "0x6005FD7")]
		[Address(RVA = "0xF766A0", Offset = "0xF754A0", Length = "0x43")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000586")]
	IControllerTemplateButton IHOTASTemplate.throttleButton6
	{
		[Token(Token = "0x6005FD8")]
		[Address(RVA = "0xF766F0", Offset = "0xF754F0", Length = "0x43")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000587")]
	IControllerTemplateButton IHOTASTemplate.throttleButton7
	{
		[Token(Token = "0x6005FD9")]
		[Address(RVA = "0xF76740", Offset = "0xF75540", Length = "0x43")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000588")]
	IControllerTemplateButton IHOTASTemplate.throttleButton8
	{
		[Token(Token = "0x6005FDA")]
		[Address(RVA = "0xF76790", Offset = "0xF75590", Length = "0x43")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000589")]
	IControllerTemplateButton IHOTASTemplate.throttleButton9
	{
		[Token(Token = "0x6005FDB")]
		[Address(RVA = "0xF767E0", Offset = "0xF755E0", Length = "0x43")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700058A")]
	IControllerTemplateButton IHOTASTemplate.throttleButton10
	{
		[Token(Token = "0x6005FDC")]
		[Address(RVA = "0xF76830", Offset = "0xF75630", Length = "0x43")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700058B")]
	IControllerTemplateButton IHOTASTemplate.throttleBaseButton1
	{
		[Token(Token = "0x6005FDD")]
		[Address(RVA = "0xF76880", Offset = "0xF75680", Length = "0x43")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700058C")]
	IControllerTemplateButton IHOTASTemplate.throttleBaseButton2
	{
		[Token(Token = "0x6005FDE")]
		[Address(RVA = "0xF768D0", Offset = "0xF756D0", Length = "0x43")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700058D")]
	IControllerTemplateButton IHOTASTemplate.throttleBaseButton3
	{
		[Token(Token = "0x6005FDF")]
		[Address(RVA = "0xF76920", Offset = "0xF75720", Length = "0x43")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700058E")]
	IControllerTemplateButton IHOTASTemplate.throttleBaseButton4
	{
		[Token(Token = "0x6005FE0")]
		[Address(RVA = "0xF76970", Offset = "0xF75770", Length = "0x43")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700058F")]
	IControllerTemplateButton IHOTASTemplate.throttleBaseButton5
	{
		[Token(Token = "0x6005FE1")]
		[Address(RVA = "0xF769C0", Offset = "0xF757C0", Length = "0x43")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000590")]
	IControllerTemplateButton IHOTASTemplate.throttleBaseButton6
	{
		[Token(Token = "0x6005FE2")]
		[Address(RVA = "0xF76A10", Offset = "0xF75810", Length = "0x43")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000591")]
	IControllerTemplateButton IHOTASTemplate.throttleBaseButton7
	{
		[Token(Token = "0x6005FE3")]
		[Address(RVA = "0xF76A60", Offset = "0xF75860", Length = "0x43")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000592")]
	IControllerTemplateButton IHOTASTemplate.throttleBaseButton8
	{
		[Token(Token = "0x6005FE4")]
		[Address(RVA = "0xF76AB0", Offset = "0xF758B0", Length = "0x43")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000593")]
	IControllerTemplateButton IHOTASTemplate.throttleBaseButton9
	{
		[Token(Token = "0x6005FE5")]
		[Address(RVA = "0xF76B00", Offset = "0xF75900", Length = "0x43")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000594")]
	IControllerTemplateButton IHOTASTemplate.throttleBaseButton10
	{
		[Token(Token = "0x6005FE6")]
		[Address(RVA = "0xF76B50", Offset = "0xF75950", Length = "0x43")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000595")]
	IControllerTemplateButton IHOTASTemplate.throttleBaseButton11
	{
		[Token(Token = "0x6005FE7")]
		[Address(RVA = "0xF76BA0", Offset = "0xF759A0", Length = "0x43")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000596")]
	IControllerTemplateButton IHOTASTemplate.throttleBaseButton12
	{
		[Token(Token = "0x6005FE8")]
		[Address(RVA = "0xF76BF0", Offset = "0xF759F0", Length = "0x43")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000597")]
	IControllerTemplateButton IHOTASTemplate.throttleBaseButton13
	{
		[Token(Token = "0x6005FE9")]
		[Address(RVA = "0xF76C40", Offset = "0xF75A40", Length = "0x43")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000598")]
	IControllerTemplateButton IHOTASTemplate.throttleBaseButton14
	{
		[Token(Token = "0x6005FEA")]
		[Address(RVA = "0xF76C90", Offset = "0xF75A90", Length = "0x43")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000599")]
	IControllerTemplateButton IHOTASTemplate.throttleBaseButton15
	{
		[Token(Token = "0x6005FEB")]
		[Address(RVA = "0xF76CE0", Offset = "0xF75AE0", Length = "0x43")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700059A")]
	IControllerTemplateAxis IHOTASTemplate.throttleSlider1
	{
		[Token(Token = "0x6005FEC")]
		[Address(RVA = "0xF76D30", Offset = "0xF75B30", Length = "0x43")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700059B")]
	IControllerTemplateAxis IHOTASTemplate.throttleSlider2
	{
		[Token(Token = "0x6005FED")]
		[Address(RVA = "0xF76D80", Offset = "0xF75B80", Length = "0x43")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700059C")]
	IControllerTemplateAxis IHOTASTemplate.throttleSlider3
	{
		[Token(Token = "0x6005FEE")]
		[Address(RVA = "0xF76DD0", Offset = "0xF75BD0", Length = "0x43")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700059D")]
	IControllerTemplateAxis IHOTASTemplate.throttleSlider4
	{
		[Token(Token = "0x6005FEF")]
		[Address(RVA = "0xF76E20", Offset = "0xF75C20", Length = "0x43")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700059E")]
	IControllerTemplateAxis IHOTASTemplate.throttleDial1
	{
		[Token(Token = "0x6005FF0")]
		[Address(RVA = "0xF76E70", Offset = "0xF75C70", Length = "0x43")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700059F")]
	IControllerTemplateAxis IHOTASTemplate.throttleDial2
	{
		[Token(Token = "0x6005FF1")]
		[Address(RVA = "0xF76EC0", Offset = "0xF75CC0", Length = "0x43")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170005A0")]
	IControllerTemplateAxis IHOTASTemplate.throttleDial3
	{
		[Token(Token = "0x6005FF2")]
		[Address(RVA = "0xF76F10", Offset = "0xF75D10", Length = "0x43")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170005A1")]
	IControllerTemplateAxis IHOTASTemplate.throttleDial4
	{
		[Token(Token = "0x6005FF3")]
		[Address(RVA = "0xF76F60", Offset = "0xF75D60", Length = "0x43")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170005A2")]
	IControllerTemplateButton IHOTASTemplate.throttleWheel1Forward
	{
		[Token(Token = "0x6005FF4")]
		[Address(RVA = "0xF76FB0", Offset = "0xF75DB0", Length = "0x43")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170005A3")]
	IControllerTemplateButton IHOTASTemplate.throttleWheel1Back
	{
		[Token(Token = "0x6005FF5")]
		[Address(RVA = "0xF77000", Offset = "0xF75E00", Length = "0x43")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170005A4")]
	IControllerTemplateButton IHOTASTemplate.throttleWheel1Press
	{
		[Token(Token = "0x6005FF6")]
		[Address(RVA = "0xF77050", Offset = "0xF75E50", Length = "0x43")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170005A5")]
	IControllerTemplateButton IHOTASTemplate.throttleWheel2Forward
	{
		[Token(Token = "0x6005FF7")]
		[Address(RVA = "0xF770A0", Offset = "0xF75EA0", Length = "0x43")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170005A6")]
	IControllerTemplateButton IHOTASTemplate.throttleWheel2Back
	{
		[Token(Token = "0x6005FF8")]
		[Address(RVA = "0xF770F0", Offset = "0xF75EF0", Length = "0x43")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170005A7")]
	IControllerTemplateButton IHOTASTemplate.throttleWheel2Press
	{
		[Token(Token = "0x6005FF9")]
		[Address(RVA = "0xF77140", Offset = "0xF75F40", Length = "0x43")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170005A8")]
	IControllerTemplateButton IHOTASTemplate.throttleWheel3Forward
	{
		[Token(Token = "0x6005FFA")]
		[Address(RVA = "0xF77190", Offset = "0xF75F90", Length = "0x43")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170005A9")]
	IControllerTemplateButton IHOTASTemplate.throttleWheel3Back
	{
		[Token(Token = "0x6005FFB")]
		[Address(RVA = "0xF771E0", Offset = "0xF75FE0", Length = "0x43")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170005AA")]
	IControllerTemplateButton IHOTASTemplate.throttleWheel3Press
	{
		[Token(Token = "0x6005FFC")]
		[Address(RVA = "0xF77230", Offset = "0xF76030", Length = "0x43")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170005AB")]
	IControllerTemplateAxis IHOTASTemplate.leftPedal
	{
		[Token(Token = "0x6005FFD")]
		[Address(RVA = "0xF77280", Offset = "0xF76080", Length = "0x43")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170005AC")]
	IControllerTemplateAxis IHOTASTemplate.rightPedal
	{
		[Token(Token = "0x6005FFE")]
		[Address(RVA = "0xF772D0", Offset = "0xF760D0", Length = "0x43")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170005AD")]
	IControllerTemplateAxis IHOTASTemplate.slidePedals
	{
		[Token(Token = "0x6005FFF")]
		[Address(RVA = "0xF77320", Offset = "0xF76120", Length = "0x43")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170005AE")]
	IControllerTemplateStick IHOTASTemplate.stick
	{
		[Token(Token = "0x6006000")]
		[Address(RVA = "0xF77370", Offset = "0xF76170", Length = "0x43")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170005AF")]
	IControllerTemplateThumbStick IHOTASTemplate.stickMiniStick1
	{
		[Token(Token = "0x6006001")]
		[Address(RVA = "0xF773C0", Offset = "0xF761C0", Length = "0x43")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170005B0")]
	IControllerTemplateThumbStick IHOTASTemplate.stickMiniStick2
	{
		[Token(Token = "0x6006002")]
		[Address(RVA = "0xF77410", Offset = "0xF76210", Length = "0x43")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170005B1")]
	IControllerTemplateHat IHOTASTemplate.stickHat1
	{
		[Token(Token = "0x6006003")]
		[Address(RVA = "0xF77460", Offset = "0xF76260", Length = "0x43")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170005B2")]
	IControllerTemplateHat IHOTASTemplate.stickHat2
	{
		[Token(Token = "0x6006004")]
		[Address(RVA = "0xF774B0", Offset = "0xF762B0", Length = "0x43")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170005B3")]
	IControllerTemplateHat IHOTASTemplate.stickHat3
	{
		[Token(Token = "0x6006005")]
		[Address(RVA = "0xF77500", Offset = "0xF76300", Length = "0x43")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170005B4")]
	IControllerTemplateHat IHOTASTemplate.stickHat4
	{
		[Token(Token = "0x6006006")]
		[Address(RVA = "0xF77550", Offset = "0xF76350", Length = "0x43")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170005B5")]
	IControllerTemplateThrottle IHOTASTemplate.throttle1
	{
		[Token(Token = "0x6006007")]
		[Address(RVA = "0xF775A0", Offset = "0xF763A0", Length = "0x43")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170005B6")]
	IControllerTemplateThrottle IHOTASTemplate.throttle2
	{
		[Token(Token = "0x6006008")]
		[Address(RVA = "0xF775F0", Offset = "0xF763F0", Length = "0x43")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170005B7")]
	IControllerTemplateThumbStick IHOTASTemplate.throttleMiniStick
	{
		[Token(Token = "0x6006009")]
		[Address(RVA = "0xF77640", Offset = "0xF76440", Length = "0x43")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170005B8")]
	IControllerTemplateHat IHOTASTemplate.throttleHat1
	{
		[Token(Token = "0x600600A")]
		[Address(RVA = "0xF77690", Offset = "0xF76490", Length = "0x43")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170005B9")]
	IControllerTemplateHat IHOTASTemplate.throttleHat2
	{
		[Token(Token = "0x600600B")]
		[Address(RVA = "0xF776E0", Offset = "0xF764E0", Length = "0x43")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170005BA")]
	IControllerTemplateHat IHOTASTemplate.throttleHat3
	{
		[Token(Token = "0x600600C")]
		[Address(RVA = "0xF77730", Offset = "0xF76530", Length = "0x43")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170005BB")]
	IControllerTemplateHat IHOTASTemplate.throttleHat4
	{
		[Token(Token = "0x600600D")]
		[Address(RVA = "0xF77780", Offset = "0xF76580", Length = "0x43")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600600E")]
	[Address(RVA = "0xF74C00", Offset = "0xF73A00", Length = "0x7D")]
	public HOTASTemplate(object payload)
		: base(null)
	{
	}
}
