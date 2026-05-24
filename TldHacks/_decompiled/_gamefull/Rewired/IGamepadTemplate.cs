using Cpp2ILInjected;

namespace Rewired;

[Token(Token = "0x2000BF5")]
public interface IGamepadTemplate : IControllerTemplate
{
	[Token(Token = "0x17000421")]
	IControllerTemplateButton actionBottomRow1
	{
		[Token(Token = "0x6005E6F")]
		get;
	}

	[Token(Token = "0x17000422")]
	IControllerTemplateButton a
	{
		[Token(Token = "0x6005E70")]
		get;
	}

	[Token(Token = "0x17000423")]
	IControllerTemplateButton actionBottomRow2
	{
		[Token(Token = "0x6005E71")]
		get;
	}

	[Token(Token = "0x17000424")]
	IControllerTemplateButton b
	{
		[Token(Token = "0x6005E72")]
		get;
	}

	[Token(Token = "0x17000425")]
	IControllerTemplateButton actionBottomRow3
	{
		[Token(Token = "0x6005E73")]
		get;
	}

	[Token(Token = "0x17000426")]
	IControllerTemplateButton c
	{
		[Token(Token = "0x6005E74")]
		get;
	}

	[Token(Token = "0x17000427")]
	IControllerTemplateButton actionTopRow1
	{
		[Token(Token = "0x6005E75")]
		get;
	}

	[Token(Token = "0x17000428")]
	IControllerTemplateButton x
	{
		[Token(Token = "0x6005E76")]
		get;
	}

	[Token(Token = "0x17000429")]
	IControllerTemplateButton actionTopRow2
	{
		[Token(Token = "0x6005E77")]
		get;
	}

	[Token(Token = "0x1700042A")]
	IControllerTemplateButton y
	{
		[Token(Token = "0x6005E78")]
		get;
	}

	[Token(Token = "0x1700042B")]
	IControllerTemplateButton actionTopRow3
	{
		[Token(Token = "0x6005E79")]
		get;
	}

	[Token(Token = "0x1700042C")]
	IControllerTemplateButton z
	{
		[Token(Token = "0x6005E7A")]
		get;
	}

	[Token(Token = "0x1700042D")]
	IControllerTemplateButton leftShoulder1
	{
		[Token(Token = "0x6005E7B")]
		get;
	}

	[Token(Token = "0x1700042E")]
	IControllerTemplateButton leftBumper
	{
		[Token(Token = "0x6005E7C")]
		get;
	}

	[Token(Token = "0x1700042F")]
	IControllerTemplateAxis leftShoulder2
	{
		[Token(Token = "0x6005E7D")]
		get;
	}

	[Token(Token = "0x17000430")]
	IControllerTemplateAxis leftTrigger
	{
		[Token(Token = "0x6005E7E")]
		get;
	}

	[Token(Token = "0x17000431")]
	IControllerTemplateButton rightShoulder1
	{
		[Token(Token = "0x6005E7F")]
		get;
	}

	[Token(Token = "0x17000432")]
	IControllerTemplateButton rightBumper
	{
		[Token(Token = "0x6005E80")]
		get;
	}

	[Token(Token = "0x17000433")]
	IControllerTemplateAxis rightShoulder2
	{
		[Token(Token = "0x6005E81")]
		get;
	}

	[Token(Token = "0x17000434")]
	IControllerTemplateAxis rightTrigger
	{
		[Token(Token = "0x6005E82")]
		get;
	}

	[Token(Token = "0x17000435")]
	IControllerTemplateButton center1
	{
		[Token(Token = "0x6005E83")]
		get;
	}

	[Token(Token = "0x17000436")]
	IControllerTemplateButton back
	{
		[Token(Token = "0x6005E84")]
		get;
	}

	[Token(Token = "0x17000437")]
	IControllerTemplateButton center2
	{
		[Token(Token = "0x6005E85")]
		get;
	}

	[Token(Token = "0x17000438")]
	IControllerTemplateButton start
	{
		[Token(Token = "0x6005E86")]
		get;
	}

	[Token(Token = "0x17000439")]
	IControllerTemplateButton center3
	{
		[Token(Token = "0x6005E87")]
		get;
	}

	[Token(Token = "0x1700043A")]
	IControllerTemplateButton guide
	{
		[Token(Token = "0x6005E88")]
		get;
	}

	[Token(Token = "0x1700043B")]
	IControllerTemplateThumbStick leftStick
	{
		[Token(Token = "0x6005E89")]
		get;
	}

	[Token(Token = "0x1700043C")]
	IControllerTemplateThumbStick rightStick
	{
		[Token(Token = "0x6005E8A")]
		get;
	}

	[Token(Token = "0x1700043D")]
	IControllerTemplateDPad dPad
	{
		[Token(Token = "0x6005E8B")]
		get;
	}
}
