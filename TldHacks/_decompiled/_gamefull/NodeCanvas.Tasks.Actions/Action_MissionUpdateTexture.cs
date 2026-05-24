using Cpp2ILInjected;
using NodeCanvas.Framework;
using ParadoxNotion.Design;

namespace NodeCanvas.Tasks.Actions;

[Name("Mission - Update Texture", 0)]
[Description("Update the texture of an existing Mission Info entry on the mission journal")]
[Category("TLD Mission UI/Mission Journal")]
[Token(Token = "0x2001256")]
public class Action_MissionUpdateTexture : ActionTask
{
	[Token(Token = "0x4008AB0")]
	[FieldOffset(Offset = "0x68")]
	public BBParameter<string> missionID;

	[Token(Token = "0x4008AB1")]
	[FieldOffset(Offset = "0x70")]
	public BBParameter<string> textureName;

	[Token(Token = "0x4008AB2")]
	[FieldOffset(Offset = "0x78")]
	public BBParameter<bool> suppressUIPopup;

	[Token(Token = "0x1700099C")]
	protected override string info
	{
		[Token(Token = "0x60077C7")]
		[Address(RVA = "0x11637A0", Offset = "0x11625A0", Length = "0xC7")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60077C8")]
	[Address(RVA = "0x1163870", Offset = "0x1162670", Length = "0x141")]
	protected override void OnExecute()
	{
	}

	[Token(Token = "0x60077C9")]
	[Address(RVA = "0x11639C0", Offset = "0x11627C0", Length = "0x2C5")]
	public Action_MissionUpdateTexture()
	{
	}
}
