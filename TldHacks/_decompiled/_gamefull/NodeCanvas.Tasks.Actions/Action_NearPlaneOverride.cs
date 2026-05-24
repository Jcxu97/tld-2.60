using Cpp2ILInjected;
using NodeCanvas.Framework;
using ParadoxNotion.Design;

namespace NodeCanvas.Tasks.Actions;

[Name("Near Plane Override", 0)]
[Description("Allow the camera near plane to be overridden. Resets on completion")]
[Category("TLD Actions/Player")]
[Token(Token = "0x2001207")]
public class Action_NearPlaneOverride : ActionTask
{
	[Token(Token = "0x4008990")]
	[FieldOffset(Offset = "0x68")]
	public BBParameter<float> m_NearPlane;

	[Token(Token = "0x60076E4")]
	[Address(RVA = "0x11505E0", Offset = "0x114F3E0", Length = "0x127")]
	protected override void OnExecute()
	{
	}

	[Token(Token = "0x60076E5")]
	[Address(RVA = "0x1150710", Offset = "0x114F510", Length = "0xF7")]
	protected override void OnStop()
	{
	}

	[Token(Token = "0x60076E6")]
	[Address(RVA = "0x11505E0", Offset = "0x114F3E0", Length = "0x127")]
	private void MaybeOverrideNearPlane()
	{
	}

	[Token(Token = "0x60076E7")]
	[Address(RVA = "0x1150710", Offset = "0x114F510", Length = "0xF7")]
	private void MaybeResetNearPlane()
	{
	}

	[Token(Token = "0x60076E8")]
	[Address(RVA = "0xD769F0", Offset = "0xD757F0", Length = "0x8")]
	public Action_NearPlaneOverride()
	{
	}
}
