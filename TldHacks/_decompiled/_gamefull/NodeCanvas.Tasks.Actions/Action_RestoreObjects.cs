using System.Collections.Generic;
using Cpp2ILInjected;
using NodeCanvas.Framework;
using ParadoxNotion.Design;

namespace NodeCanvas.Tasks.Actions;

[Name("Restore Objects", 0)]
[Description("Use this to restore initial activity state for objects previously referenced by an 'Enable Objects' action that was NOT scoped to state. Objects will be restored to their initial activity state.")]
[Category("TLD Actions/Utils")]
[Token(Token = "0x2001263")]
public class Action_RestoreObjects : ActionTask
{
	[Token(Token = "0x4008AD2")]
	[FieldOffset(Offset = "0x68")]
	public List<string> objectList;

	[Token(Token = "0x170009A6")]
	protected override string info
	{
		[Token(Token = "0x60077EE")]
		[Address(RVA = "0x1166F90", Offset = "0x1165D90", Length = "0xF3")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60077EF")]
	[Address(RVA = "0x1167090", Offset = "0x1165E90", Length = "0x1E1")]
	protected override void OnExecute()
	{
	}

	[Token(Token = "0x60077F0")]
	[Address(RVA = "0x1167280", Offset = "0x1166080", Length = "0xB4")]
	public Action_RestoreObjects()
	{
	}
}
