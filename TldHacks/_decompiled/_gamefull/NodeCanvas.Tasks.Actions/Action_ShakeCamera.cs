using Cpp2ILInjected;
using NodeCanvas.Framework;
using ParadoxNotion.Design;

namespace NodeCanvas.Tasks.Actions;

[Name("Shake Camera", 0)]
[Description("Shakes the camera to simulate an earthquake effect")]
[Category("TLD Actions/Player")]
[Token(Token = "0x2001220")]
public class Action_ShakeCamera : ActionTask
{
	[Token(Token = "0x40089F2")]
	[FieldOffset(Offset = "0x68")]
	public float m_HorizontalShake;

	[Token(Token = "0x40089F3")]
	[FieldOffset(Offset = "0x6C")]
	public float m_VerticalShake;

	[Token(Token = "0x40089F4")]
	[FieldOffset(Offset = "0x70")]
	public float m_DurationSeconds;

	[Token(Token = "0x40089F5")]
	[FieldOffset(Offset = "0x74")]
	public float m_WeaponShakeMultiplier;

	[Token(Token = "0x40089F6")]
	[FieldOffset(Offset = "0x78")]
	public float m_CameraRollMultiplier;

	[Token(Token = "0x6007720")]
	[Address(RVA = "0x1156C00", Offset = "0x1155A00", Length = "0x18A")]
	protected override void OnExecute()
	{
	}

	[Token(Token = "0x6007721")]
	[Address(RVA = "0x1156D90", Offset = "0x1155B90", Length = "0x24")]
	public Action_ShakeCamera()
	{
	}
}
