using System.Collections.Generic;
using Cpp2ILInjected;
using NodeCanvas.Framework;
using ParadoxNotion.Design;

namespace NodeCanvas.Tasks.Actions;

[Name("Remove Mission Layer", 0)]
[Description("Removes one or more mission layers from the scene loading.")]
[Category("TLD Actions/Mission Layer")]
[Token(Token = "0x20011E7")]
public class Action_RemoveMissionLayer : ActionTask
{
	[Token(Token = "0x4008948")]
	[FieldOffset(Offset = "0x68")]
	public List<string> m_Layers;

	[Token(Token = "0x1700096D")]
	protected override string info
	{
		[Token(Token = "0x6007690")]
		[Address(RVA = "0x1149F70", Offset = "0x1148D70", Length = "0x1BA")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6007691")]
	[Address(RVA = "0x114A130", Offset = "0x1148F30", Length = "0x195")]
	protected override void OnExecute()
	{
	}

	[Token(Token = "0x6007692")]
	[Address(RVA = "0x114A2D0", Offset = "0x11490D0", Length = "0xB4")]
	public Action_RemoveMissionLayer()
	{
	}
}
