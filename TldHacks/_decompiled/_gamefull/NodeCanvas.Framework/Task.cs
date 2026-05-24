using System;
using System.Collections;
using Cpp2ILInjected;
using NodeCanvas.Framework.Internal;
using ParadoxNotion;
using ParadoxNotion.Design;
using UnityEngine;

namespace NodeCanvas.Framework;

[Serializable]
[SpoofAOT]
[Token(Token = "0x2001077")]
public abstract class Task : ISubParametersContainer
{
	[AttributeUsage(AttributeTargets.Class)]
	[Token(Token = "0x2001078")]
	protected class EventReceiverAttribute : Attribute
	{
		[Token(Token = "0x40085A9")]
		[FieldOffset(Offset = "0x10")]
		public readonly string[] eventMessages;

		[Token(Token = "0x6006FEE")]
		[Address(RVA = "0x4094C0", Offset = "0x4082C0", Length = "0x52")]
		public EventReceiverAttribute(params string[] args)
		{
		}
	}

	[AttributeUsage(AttributeTargets.Field)]
	[Token(Token = "0x2001079")]
	protected class GetFromAgentAttribute : Attribute
	{
		[Token(Token = "0x6006FEF")]
		[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
		public GetFromAgentAttribute()
		{
		}
	}

	[SerializeField]
	[Token(Token = "0x40085A0")]
	[FieldOffset(Offset = "0x10")]
	private bool _isDisabled;

	[SerializeField]
	[Token(Token = "0x40085A1")]
	[FieldOffset(Offset = "0x18")]
	private TaskAgentParameter overrideAgent;

	[NonSerialized]
	[Token(Token = "0x40085A2")]
	[FieldOffset(Offset = "0x20")]
	private IBlackboard _blackboard;

	[NonSerialized]
	[Token(Token = "0x40085A3")]
	[FieldOffset(Offset = "0x28")]
	private ITaskSystem _ownerSystem;

	[NonSerialized]
	[Token(Token = "0x40085A4")]
	[FieldOffset(Offset = "0x30")]
	private Component current;

	[NonSerialized]
	[Token(Token = "0x40085A5")]
	[FieldOffset(Offset = "0x38")]
	private string _taskName;

	[NonSerialized]
	[Token(Token = "0x40085A6")]
	[FieldOffset(Offset = "0x40")]
	private string _taskDescription;

	[NonSerialized]
	[Token(Token = "0x40085A7")]
	[FieldOffset(Offset = "0x48")]
	private string _obsoleteInfo;

	[Token(Token = "0x170007E7")]
	public ITaskSystem ownerSystem
	{
		[Token(Token = "0x6006FC5")]
		[Address(RVA = "0x413AB0", Offset = "0x4128B0", Length = "0x5")]
		get
		{
			return null;
		}
		[Token(Token = "0x6006FC6")]
		[Address(RVA = "0x4A9DB0", Offset = "0x4A8BB0", Length = "0x52")]
		private set
		{
		}
	}

	[Token(Token = "0x170007E8")]
	public Component ownerAgent
	{
		[Token(Token = "0x6006FC7")]
		[Address(RVA = "0x10C6F90", Offset = "0x10C5D90", Length = "0xC8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170007E9")]
	public IBlackboard ownerBlackboard
	{
		[Token(Token = "0x6006FC8")]
		[Address(RVA = "0x10C7060", Offset = "0x10C5E60", Length = "0x51")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170007EA")]
	protected float ownerElapsedTime
	{
		[Token(Token = "0x6006FC9")]
		[Address(RVA = "0x10C70C0", Offset = "0x10C5EC0", Length = "0x52")]
		get
		{
			return 0f;
		}
	}

	[Token(Token = "0x170007EB")]
	public bool isActive
	{
		[Token(Token = "0x6006FCA")]
		[Address(RVA = "0x10C7120", Offset = "0x10C5F20", Length = "0x8")]
		get
		{
			return false;
		}
		[Token(Token = "0x6006FCB")]
		[Address(RVA = "0x10C7130", Offset = "0x10C5F30", Length = "0x7")]
		set
		{
		}
	}

	[Token(Token = "0x170007EC")]
	public string obsolete
	{
		[Token(Token = "0x6006FCC")]
		[Address(RVA = "0x10C7140", Offset = "0x10C5F40", Length = "0xFF")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170007ED")]
	public string name
	{
		[Token(Token = "0x6006FCD")]
		[Address(RVA = "0x10C7240", Offset = "0x10C6040", Length = "0x14F")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170007EE")]
	public string description
	{
		[Token(Token = "0x6006FCE")]
		[Address(RVA = "0x10C7390", Offset = "0x10C6190", Length = "0xFF")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170007EF")]
	public virtual Type agentType
	{
		[Token(Token = "0x6006FCF")]
		[Address(RVA = "0x4582A0", Offset = "0x4570A0", Length = "0x3")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170007F0")]
	public string summaryInfo
	{
		[Token(Token = "0x6006FD0")]
		[Address(RVA = "0x10C7490", Offset = "0x10C6290", Length = "0x1C2")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170007F1")]
	protected virtual string info
	{
		[Token(Token = "0x6006FD1")]
		[Address(RVA = "0x10C7660", Offset = "0x10C6460", Length = "0x7")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170007F2")]
	public string agentInfo
	{
		[Token(Token = "0x6006FD2")]
		[Address(RVA = "0x10C7670", Offset = "0x10C6470", Length = "0x59")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170007F3")]
	public bool agentIsOverride
	{
		[Token(Token = "0x6006FD3")]
		[Address(RVA = "0x10C76D0", Offset = "0x10C64D0", Length = "0x9")]
		get
		{
			return false;
		}
		[Token(Token = "0x6006FD4")]
		[Address(RVA = "0x10C76E0", Offset = "0x10C64E0", Length = "0x191")]
		set
		{
		}
	}

	[Token(Token = "0x170007F4")]
	public string overrideAgentParameterName
	{
		[Token(Token = "0x6006FD5")]
		[Address(RVA = "0x10C7880", Offset = "0x10C6680", Length = "0xF")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170007F5")]
	public Component agent
	{
		[Token(Token = "0x6006FD6")]
		[Address(RVA = "0x10C7890", Offset = "0x10C6690", Length = "0x169")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170007F6")]
	public IBlackboard blackboard
	{
		[Token(Token = "0x6006FD7")]
		[Address(RVA = "0x40E110", Offset = "0x40CF10", Length = "0x5")]
		get
		{
			return null;
		}
		[Token(Token = "0x6006FD8")]
		[Address(RVA = "0x10C7A00", Offset = "0x10C6800", Length = "0xC3")]
		private set
		{
		}
	}

	[Token(Token = "0x170007F7")]
	[field: Token(Token = "0x40085A8")]
	[field: FieldOffset(Offset = "0x50")]
	public string firstWarningMessage
	{
		[Token(Token = "0x6006FD9")]
		[Address(RVA = "0x669640", Offset = "0x668440", Length = "0x5")]
		get;
		[Token(Token = "0x6006FDA")]
		[Address(RVA = "0x6339B0", Offset = "0x6327B0", Length = "0xED7")]
		private set;
	}

	[Token(Token = "0x6006FBD")]
	[Address(RVA = "0x10C6B20", Offset = "0x10C5920", Length = "0xA4")]
	BBParameter[] ISubParametersContainer.GetSubParameters()
	{
		return null;
	}

	[Token(Token = "0x6006FBE")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public Task()
	{
	}

	[Token(Token = "0x6006FBF")]
	[Address(RVA = "0x19FC410", Offset = "0x19FB210", Length = "0xE0")]
	public static T Create<T>(ITaskSystem newOwnerSystem) where T : Task
	{
		return null;
	}

	[Token(Token = "0x6006FC0")]
	[Address(RVA = "0x10C6BD0", Offset = "0x10C59D0", Length = "0x172")]
	public static Task Create(Type type, ITaskSystem newOwnerSystem)
	{
		return null;
	}

	[Token(Token = "0x6006FC1")]
	[Address(RVA = "0x10C6D50", Offset = "0x10C5B50", Length = "0x142")]
	public virtual Task Duplicate(ITaskSystem newOwnerSystem)
	{
		return null;
	}

	[Token(Token = "0x6006FC2")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public virtual void OnCreate(ITaskSystem ownerSystem)
	{
	}

	[Token(Token = "0x6006FC3")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public virtual void OnValidate(ITaskSystem ownerSystem)
	{
	}

	[Token(Token = "0x6006FC4")]
	[Address(RVA = "0x10C6EA0", Offset = "0x10C5CA0", Length = "0xE5")]
	public void SetOwnerSystem(ITaskSystem newOwnerSystem)
	{
	}

	[Token(Token = "0x6006FDB")]
	[Address(RVA = "0x10C7AD0", Offset = "0x10C68D0", Length = "0x63")]
	protected Coroutine StartCoroutine(IEnumerator routine)
	{
		return null;
	}

	[Token(Token = "0x6006FDC")]
	[Address(RVA = "0x10C7B40", Offset = "0x10C6940", Length = "0x63")]
	protected void StopCoroutine(Coroutine routine)
	{
	}

	[Token(Token = "0x6006FDD")]
	[Address(RVA = "0x10C7BB0", Offset = "0x10C69B0", Length = "0xC3")]
	protected void SendEvent(EventData eventData)
	{
	}

	[Token(Token = "0x6006FDE")]
	[Address(RVA = "0x4582A0", Offset = "0x4570A0", Length = "0x3")]
	protected virtual string OnInit()
	{
		return null;
	}

	[Token(Token = "0x6006FDF")]
	[Address(RVA = "0x10C7C80", Offset = "0x10C6A80", Length = "0x3B9")]
	protected bool Set(Component newAgent, IBlackboard newBB)
	{
		return false;
	}

	[Token(Token = "0x6006FE0")]
	[Address(RVA = "0x10C8040", Offset = "0x10C6E40", Length = "0x208")]
	private static Component TransformAgent(Component input, Type type)
	{
		return null;
	}

	[Token(Token = "0x6006FE1")]
	[Address(RVA = "0x10C8250", Offset = "0x10C7050", Length = "0x44F")]
	private bool Initialize(Component newAgent)
	{
		return false;
	}

	[Token(Token = "0x6006FE2")]
	[Address(RVA = "0x10C86A0", Offset = "0x10C74A0", Length = "0x340")]
	private bool InitializeAttributes(Component newAgent)
	{
		return false;
	}

	[Token(Token = "0x6006FE3")]
	[Address(RVA = "0x10C89F0", Offset = "0x10C77F0", Length = "0x107")]
	protected bool Error(string error)
	{
		return false;
	}

	[Token(Token = "0x6006FE4")]
	[Address(RVA = "0x10C8B00", Offset = "0x10C7900", Length = "0x7E")]
	public void RegisterEvent(string eventName)
	{
	}

	[Token(Token = "0x6006FE5")]
	[Address(RVA = "0x10C8B80", Offset = "0x10C7980", Length = "0x207")]
	public void RegisterEvents(params string[] eventNames)
	{
	}

	[Token(Token = "0x6006FE6")]
	[Address(RVA = "0x10C8D90", Offset = "0x10C7B90", Length = "0x20C")]
	public void UnRegisterEvent(string eventName)
	{
	}

	[Token(Token = "0x6006FE7")]
	[Address(RVA = "0x10C8FA0", Offset = "0x10C7DA0", Length = "0x1C1")]
	public void UnRegisterEvents(params string[] eventNames)
	{
	}

	[Token(Token = "0x6006FE8")]
	[Address(RVA = "0x10C9170", Offset = "0x10C7F70", Length = "0x1B1")]
	public void UnRegisterAllEvents()
	{
	}

	[Token(Token = "0x6006FE9")]
	[Address(RVA = "0x10C9330", Offset = "0x10C8130", Length = "0x6A")]
	public string GetWarning()
	{
		return null;
	}

	[Token(Token = "0x6006FEA")]
	[Address(RVA = "0x10C93A0", Offset = "0x10C81A0", Length = "0x66A")]
	private string Internal_GetWarning()
	{
		return null;
	}

	[Token(Token = "0x6006FEB")]
	[Address(RVA = "0x10C9A10", Offset = "0x10C8810", Length = "0x7")]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6006FEC")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public virtual void OnDrawGizmos()
	{
	}

	[Token(Token = "0x6006FED")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public virtual void OnDrawGizmosSelected()
	{
	}
}
