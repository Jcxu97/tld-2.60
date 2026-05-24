using System.Collections.Generic;
using Cpp2ILInjected;
using NodeCanvas.Framework;
using ParadoxNotion.Design;

namespace NodeCanvas.Tasks.Actions;

[Name("Add Mission Layer", 0)]
[Description("Adds one or more mission layers to the scene loading.")]
[Category("TLD Actions/Mission Layer")]
[Token(Token = "0x20011E6")]
public class Action_AddMissionLayer : ActionTask
{
	[Token(Token = "0x4008947")]
	[FieldOffset(Offset = "0x68")]
	public List<string> m_Layers;

	[Token(Token = "0x1700096C")]
	protected override string info
	{
		[Token(Token = "0x600768D")]
		[Address(RVA = "0x1149B50", Offset = "0x1148950", Length = "0x1BA")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600768E")]
	[Address(RVA = "0x1149D10", Offset = "0x1148B10", Length = "0x195")]
	protected override void OnExecute()
	{
	}

	[Token(Token = "0x600768F")]
	[Address(RVA = "0x1149EB0", Offset = "0x1148CB0", Length = "0xB4")]
	public Action_AddMissionLayer()
	{
	}
}
