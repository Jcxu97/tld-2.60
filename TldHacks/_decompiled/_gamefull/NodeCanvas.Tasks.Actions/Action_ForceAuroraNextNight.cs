using Cpp2ILInjected;
using NodeCanvas.Framework;
using ParadoxNotion.Design;

namespace NodeCanvas.Tasks.Actions;

[Name("Force Aurora Next Opportunity", 0)]
[Description("Forces Aurora to occur at the next opportunity. Leave duration override values at zero to use the existing min/max values for aurora duration. Early window is late afternoon to midnight, late window is midnight to ~4 AM.")]
[Category("TLD Actions/Environment")]
[Token(Token = "0x20011D9")]
public class Action_ForceAuroraNextNight : ActionTask
{
	[Token(Token = "0x400892B")]
	[FieldOffset(Offset = "0x68")]
	public BBParameter<bool> earlyWindowStartAllowed;

	[Token(Token = "0x400892C")]
	[FieldOffset(Offset = "0x70")]
	public BBParameter<bool> lateWindowStartAllowed;

	[Token(Token = "0x400892D")]
	[FieldOffset(Offset = "0x78")]
	public BBParameter<float> durationOverrideHoursMin;

	[Token(Token = "0x400892E")]
	[FieldOffset(Offset = "0x80")]
	public BBParameter<float> durationOverrideHoursMax;

	[Token(Token = "0x17000967")]
	protected override string info
	{
		[Token(Token = "0x6007667")]
		[Address(RVA = "0x1146DB0", Offset = "0x1145BB0", Length = "0x28A")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6007668")]
	[Address(RVA = "0x1147040", Offset = "0x1145E40", Length = "0x1FB")]
	protected override void OnExecute()
	{
	}

	[Token(Token = "0x6007669")]
	[Address(RVA = "0x1147240", Offset = "0x1146040", Length = "0x348")]
	public Action_ForceAuroraNextNight()
	{
	}
}
