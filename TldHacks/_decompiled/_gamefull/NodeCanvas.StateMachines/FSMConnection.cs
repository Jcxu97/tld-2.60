using Cpp2ILInjected;
using NodeCanvas.Framework;
using UnityEngine;

namespace NodeCanvas.StateMachines;

[Token(Token = "0x20010CD")]
public class FSMConnection : Connection, ITaskAssignable<ConditionTask>, ITaskAssignable
{
	[SerializeField]
	[Token(Token = "0x4008673")]
	[FieldOffset(Offset = "0x28")]
	private ConditionTask _condition;

	[Token(Token = "0x17000855")]
	public ConditionTask condition
	{
		[Token(Token = "0x60071FE")]
		[Address(RVA = "0x413AB0", Offset = "0x4128B0", Length = "0x5")]
		get
		{
			return null;
		}
		[Token(Token = "0x60071FF")]
		[Address(RVA = "0x4A9DB0", Offset = "0x4A8BB0", Length = "0x52")]
		set
		{
		}
	}

	[Token(Token = "0x17000856")]
	public Task task
	{
		[Token(Token = "0x6007200")]
		[Address(RVA = "0x413AB0", Offset = "0x4128B0", Length = "0x5")]
		get
		{
			return null;
		}
		[Token(Token = "0x6007201")]
		[Address(RVA = "0x10DBAB0", Offset = "0x10DA8B0", Length = "0xB4")]
		set
		{
		}
	}

	[Token(Token = "0x6007202")]
	[Address(RVA = "0x10DBB70", Offset = "0x10DA970", Length = "0xFE")]
	public void PerformTransition()
	{
	}

	[Token(Token = "0x6007203")]
	[Address(RVA = "0x10AED30", Offset = "0x10ADB30", Length = "0x8")]
	public FSMConnection()
	{
	}
}
