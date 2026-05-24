using System;
using Cpp2ILInjected;

namespace Rewired;

[Token(Token = "0x2000C00")]
public sealed class SixDofControllerTemplate : ControllerTemplate, ISixDofControllerTemplate, IControllerTemplate
{
	[Token(Token = "0x4007B43")]
	public static readonly Guid typeGuid;

	[Token(Token = "0x4007B44")]
	public const int elementId_positionX = 1;

	[Token(Token = "0x4007B45")]
	public const int elementId_positionY = 2;

	[Token(Token = "0x4007B46")]
	public const int elementId_positionZ = 0;

	[Token(Token = "0x4007B47")]
	public const int elementId_rotationX = 3;

	[Token(Token = "0x4007B48")]
	public const int elementId_rotationY = 5;

	[Token(Token = "0x4007B49")]
	public const int elementId_rotationZ = 4;

	[Token(Token = "0x4007B4A")]
	public const int elementId_throttle1Axis = 6;

	[Token(Token = "0x4007B4B")]
	public const int elementId_throttle1MinDetent = 50;

	[Token(Token = "0x4007B4C")]
	public const int elementId_throttle2Axis = 7;

	[Token(Token = "0x4007B4D")]
	public const int elementId_throttle2MinDetent = 51;

	[Token(Token = "0x4007B4E")]
	public const int elementId_extraAxis1 = 8;

	[Token(Token = "0x4007B4F")]
	public const int elementId_extraAxis2 = 9;

	[Token(Token = "0x4007B50")]
	public const int elementId_extraAxis3 = 10;

	[Token(Token = "0x4007B51")]
	public const int elementId_extraAxis4 = 11;

	[Token(Token = "0x4007B52")]
	public const int elementId_button1 = 12;

	[Token(Token = "0x4007B53")]
	public const int elementId_button2 = 13;

	[Token(Token = "0x4007B54")]
	public const int elementId_button3 = 14;

	[Token(Token = "0x4007B55")]
	public const int elementId_button4 = 15;

	[Token(Token = "0x4007B56")]
	public const int elementId_button5 = 16;

	[Token(Token = "0x4007B57")]
	public const int elementId_button6 = 17;

	[Token(Token = "0x4007B58")]
	public const int elementId_button7 = 18;

	[Token(Token = "0x4007B59")]
	public const int elementId_button8 = 19;

	[Token(Token = "0x4007B5A")]
	public const int elementId_button9 = 20;

	[Token(Token = "0x4007B5B")]
	public const int elementId_button10 = 21;

	[Token(Token = "0x4007B5C")]
	public const int elementId_button11 = 22;

	[Token(Token = "0x4007B5D")]
	public const int elementId_button12 = 23;

	[Token(Token = "0x4007B5E")]
	public const int elementId_button13 = 24;

	[Token(Token = "0x4007B5F")]
	public const int elementId_button14 = 25;

	[Token(Token = "0x4007B60")]
	public const int elementId_button15 = 26;

	[Token(Token = "0x4007B61")]
	public const int elementId_button16 = 27;

	[Token(Token = "0x4007B62")]
	public const int elementId_button17 = 28;

	[Token(Token = "0x4007B63")]
	public const int elementId_button18 = 29;

	[Token(Token = "0x4007B64")]
	public const int elementId_button19 = 30;

	[Token(Token = "0x4007B65")]
	public const int elementId_button20 = 31;

	[Token(Token = "0x4007B66")]
	public const int elementId_button21 = 55;

	[Token(Token = "0x4007B67")]
	public const int elementId_button22 = 56;

	[Token(Token = "0x4007B68")]
	public const int elementId_button23 = 57;

	[Token(Token = "0x4007B69")]
	public const int elementId_button24 = 58;

	[Token(Token = "0x4007B6A")]
	public const int elementId_button25 = 59;

	[Token(Token = "0x4007B6B")]
	public const int elementId_button26 = 60;

	[Token(Token = "0x4007B6C")]
	public const int elementId_button27 = 61;

	[Token(Token = "0x4007B6D")]
	public const int elementId_button28 = 62;

	[Token(Token = "0x4007B6E")]
	public const int elementId_button29 = 63;

	[Token(Token = "0x4007B6F")]
	public const int elementId_button30 = 64;

	[Token(Token = "0x4007B70")]
	public const int elementId_button31 = 65;

	[Token(Token = "0x4007B71")]
	public const int elementId_button32 = 66;

	[Token(Token = "0x4007B72")]
	public const int elementId_hat1Up = 32;

	[Token(Token = "0x4007B73")]
	public const int elementId_hat1UpRight = 33;

	[Token(Token = "0x4007B74")]
	public const int elementId_hat1Right = 34;

	[Token(Token = "0x4007B75")]
	public const int elementId_hat1DownRight = 35;

	[Token(Token = "0x4007B76")]
	public const int elementId_hat1Down = 36;

	[Token(Token = "0x4007B77")]
	public const int elementId_hat1DownLeft = 37;

	[Token(Token = "0x4007B78")]
	public const int elementId_hat1Left = 38;

	[Token(Token = "0x4007B79")]
	public const int elementId_hat1UpLeft = 39;

	[Token(Token = "0x4007B7A")]
	public const int elementId_hat2Up = 40;

	[Token(Token = "0x4007B7B")]
	public const int elementId_hat2UpRight = 41;

	[Token(Token = "0x4007B7C")]
	public const int elementId_hat2Right = 42;

	[Token(Token = "0x4007B7D")]
	public const int elementId_hat2DownRight = 43;

	[Token(Token = "0x4007B7E")]
	public const int elementId_hat2Down = 44;

	[Token(Token = "0x4007B7F")]
	public const int elementId_hat2DownLeft = 45;

	[Token(Token = "0x4007B80")]
	public const int elementId_hat2Left = 46;

	[Token(Token = "0x4007B81")]
	public const int elementId_hat2UpLeft = 47;

	[Token(Token = "0x4007B82")]
	public const int elementId_hat1 = 48;

	[Token(Token = "0x4007B83")]
	public const int elementId_hat2 = 49;

	[Token(Token = "0x4007B84")]
	public const int elementId_throttle1 = 52;

	[Token(Token = "0x4007B85")]
	public const int elementId_throttle2 = 53;

	[Token(Token = "0x4007B86")]
	public const int elementId_stick = 54;

	[Token(Token = "0x170005F0")]
	IControllerTemplateAxis ISixDofControllerTemplate.extraAxis1
	{
		[Token(Token = "0x6006048")]
		[Address(RVA = "0xF78C20", Offset = "0xF77A20", Length = "0x43")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170005F1")]
	IControllerTemplateAxis ISixDofControllerTemplate.extraAxis2
	{
		[Token(Token = "0x6006049")]
		[Address(RVA = "0xF78C70", Offset = "0xF77A70", Length = "0x43")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170005F2")]
	IControllerTemplateAxis ISixDofControllerTemplate.extraAxis3
	{
		[Token(Token = "0x600604A")]
		[Address(RVA = "0xF78CC0", Offset = "0xF77AC0", Length = "0x43")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170005F3")]
	IControllerTemplateAxis ISixDofControllerTemplate.extraAxis4
	{
		[Token(Token = "0x600604B")]
		[Address(RVA = "0xF78D10", Offset = "0xF77B10", Length = "0x43")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170005F4")]
	IControllerTemplateButton ISixDofControllerTemplate.button1
	{
		[Token(Token = "0x600604C")]
		[Address(RVA = "0xF78D60", Offset = "0xF77B60", Length = "0x43")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170005F5")]
	IControllerTemplateButton ISixDofControllerTemplate.button2
	{
		[Token(Token = "0x600604D")]
		[Address(RVA = "0xF78DB0", Offset = "0xF77BB0", Length = "0x43")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170005F6")]
	IControllerTemplateButton ISixDofControllerTemplate.button3
	{
		[Token(Token = "0x600604E")]
		[Address(RVA = "0xF78E00", Offset = "0xF77C00", Length = "0x43")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170005F7")]
	IControllerTemplateButton ISixDofControllerTemplate.button4
	{
		[Token(Token = "0x600604F")]
		[Address(RVA = "0xF78E50", Offset = "0xF77C50", Length = "0x43")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170005F8")]
	IControllerTemplateButton ISixDofControllerTemplate.button5
	{
		[Token(Token = "0x6006050")]
		[Address(RVA = "0xF78EA0", Offset = "0xF77CA0", Length = "0x43")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170005F9")]
	IControllerTemplateButton ISixDofControllerTemplate.button6
	{
		[Token(Token = "0x6006051")]
		[Address(RVA = "0xF78EF0", Offset = "0xF77CF0", Length = "0x43")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170005FA")]
	IControllerTemplateButton ISixDofControllerTemplate.button7
	{
		[Token(Token = "0x6006052")]
		[Address(RVA = "0xF78F40", Offset = "0xF77D40", Length = "0x43")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170005FB")]
	IControllerTemplateButton ISixDofControllerTemplate.button8
	{
		[Token(Token = "0x6006053")]
		[Address(RVA = "0xF78F90", Offset = "0xF77D90", Length = "0x43")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170005FC")]
	IControllerTemplateButton ISixDofControllerTemplate.button9
	{
		[Token(Token = "0x6006054")]
		[Address(RVA = "0xF78FE0", Offset = "0xF77DE0", Length = "0x43")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170005FD")]
	IControllerTemplateButton ISixDofControllerTemplate.button10
	{
		[Token(Token = "0x6006055")]
		[Address(RVA = "0xF79030", Offset = "0xF77E30", Length = "0x43")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170005FE")]
	IControllerTemplateButton ISixDofControllerTemplate.button11
	{
		[Token(Token = "0x6006056")]
		[Address(RVA = "0xF79080", Offset = "0xF77E80", Length = "0x43")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170005FF")]
	IControllerTemplateButton ISixDofControllerTemplate.button12
	{
		[Token(Token = "0x6006057")]
		[Address(RVA = "0xF790D0", Offset = "0xF77ED0", Length = "0x43")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000600")]
	IControllerTemplateButton ISixDofControllerTemplate.button13
	{
		[Token(Token = "0x6006058")]
		[Address(RVA = "0xF79120", Offset = "0xF77F20", Length = "0x43")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000601")]
	IControllerTemplateButton ISixDofControllerTemplate.button14
	{
		[Token(Token = "0x6006059")]
		[Address(RVA = "0xF79170", Offset = "0xF77F70", Length = "0x43")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000602")]
	IControllerTemplateButton ISixDofControllerTemplate.button15
	{
		[Token(Token = "0x600605A")]
		[Address(RVA = "0xF791C0", Offset = "0xF77FC0", Length = "0x43")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000603")]
	IControllerTemplateButton ISixDofControllerTemplate.button16
	{
		[Token(Token = "0x600605B")]
		[Address(RVA = "0xF79210", Offset = "0xF78010", Length = "0x43")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000604")]
	IControllerTemplateButton ISixDofControllerTemplate.button17
	{
		[Token(Token = "0x600605C")]
		[Address(RVA = "0xF79260", Offset = "0xF78060", Length = "0x43")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000605")]
	IControllerTemplateButton ISixDofControllerTemplate.button18
	{
		[Token(Token = "0x600605D")]
		[Address(RVA = "0xF792B0", Offset = "0xF780B0", Length = "0x43")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000606")]
	IControllerTemplateButton ISixDofControllerTemplate.button19
	{
		[Token(Token = "0x600605E")]
		[Address(RVA = "0xF79300", Offset = "0xF78100", Length = "0x43")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000607")]
	IControllerTemplateButton ISixDofControllerTemplate.button20
	{
		[Token(Token = "0x600605F")]
		[Address(RVA = "0xF79350", Offset = "0xF78150", Length = "0x43")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000608")]
	IControllerTemplateButton ISixDofControllerTemplate.button21
	{
		[Token(Token = "0x6006060")]
		[Address(RVA = "0xF793A0", Offset = "0xF781A0", Length = "0x43")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000609")]
	IControllerTemplateButton ISixDofControllerTemplate.button22
	{
		[Token(Token = "0x6006061")]
		[Address(RVA = "0xF793F0", Offset = "0xF781F0", Length = "0x43")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700060A")]
	IControllerTemplateButton ISixDofControllerTemplate.button23
	{
		[Token(Token = "0x6006062")]
		[Address(RVA = "0xF79440", Offset = "0xF78240", Length = "0x43")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700060B")]
	IControllerTemplateButton ISixDofControllerTemplate.button24
	{
		[Token(Token = "0x6006063")]
		[Address(RVA = "0xF79490", Offset = "0xF78290", Length = "0x43")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700060C")]
	IControllerTemplateButton ISixDofControllerTemplate.button25
	{
		[Token(Token = "0x6006064")]
		[Address(RVA = "0xF794E0", Offset = "0xF782E0", Length = "0x43")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700060D")]
	IControllerTemplateButton ISixDofControllerTemplate.button26
	{
		[Token(Token = "0x6006065")]
		[Address(RVA = "0xF79530", Offset = "0xF78330", Length = "0x43")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700060E")]
	IControllerTemplateButton ISixDofControllerTemplate.button27
	{
		[Token(Token = "0x6006066")]
		[Address(RVA = "0xF79580", Offset = "0xF78380", Length = "0x43")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700060F")]
	IControllerTemplateButton ISixDofControllerTemplate.button28
	{
		[Token(Token = "0x6006067")]
		[Address(RVA = "0xF795D0", Offset = "0xF783D0", Length = "0x43")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000610")]
	IControllerTemplateButton ISixDofControllerTemplate.button29
	{
		[Token(Token = "0x6006068")]
		[Address(RVA = "0xF79620", Offset = "0xF78420", Length = "0x43")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000611")]
	IControllerTemplateButton ISixDofControllerTemplate.button30
	{
		[Token(Token = "0x6006069")]
		[Address(RVA = "0xF79670", Offset = "0xF78470", Length = "0x43")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000612")]
	IControllerTemplateButton ISixDofControllerTemplate.button31
	{
		[Token(Token = "0x600606A")]
		[Address(RVA = "0xF796C0", Offset = "0xF784C0", Length = "0x43")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000613")]
	IControllerTemplateButton ISixDofControllerTemplate.button32
	{
		[Token(Token = "0x600606B")]
		[Address(RVA = "0xF79710", Offset = "0xF78510", Length = "0x43")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000614")]
	IControllerTemplateHat ISixDofControllerTemplate.hat1
	{
		[Token(Token = "0x600606C")]
		[Address(RVA = "0xF79760", Offset = "0xF78560", Length = "0x43")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000615")]
	IControllerTemplateHat ISixDofControllerTemplate.hat2
	{
		[Token(Token = "0x600606D")]
		[Address(RVA = "0xF797B0", Offset = "0xF785B0", Length = "0x43")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000616")]
	IControllerTemplateThrottle ISixDofControllerTemplate.throttle1
	{
		[Token(Token = "0x600606E")]
		[Address(RVA = "0xF79800", Offset = "0xF78600", Length = "0x43")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000617")]
	IControllerTemplateThrottle ISixDofControllerTemplate.throttle2
	{
		[Token(Token = "0x600606F")]
		[Address(RVA = "0xF79850", Offset = "0xF78650", Length = "0x43")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000618")]
	IControllerTemplateStick6D ISixDofControllerTemplate.stick
	{
		[Token(Token = "0x6006070")]
		[Address(RVA = "0xF798A0", Offset = "0xF786A0", Length = "0x43")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6006071")]
	[Address(RVA = "0xF74C00", Offset = "0xF73A00", Length = "0x7D")]
	public SixDofControllerTemplate(object payload)
		: base(null)
	{
	}
}
