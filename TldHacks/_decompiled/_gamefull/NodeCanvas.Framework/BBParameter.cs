using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using ParadoxNotion.Design;
using UnityEngine;

namespace NodeCanvas.Framework;

[Serializable]
[SpoofAOT]
[Token(Token = "0x200107A")]
public abstract class BBParameter
{
	[Token(Token = "0x200107B")]
	protected struct VariableBBInfo
	{
		[Token(Token = "0x40085AF")]
		[FieldOffset(Offset = "0x0")]
		public string m_VarName;

		[Token(Token = "0x40085B0")]
		[FieldOffset(Offset = "0x8")]
		public IBlackboard m_Blackboard;
	}

	[SerializeField]
	[Token(Token = "0x40085AA")]
	[FieldOffset(Offset = "0x10")]
	private string _name;

	[SerializeField]
	[Token(Token = "0x40085AB")]
	[FieldOffset(Offset = "0x18")]
	private string _targetVariableID;

	[NonSerialized]
	[Token(Token = "0x40085AC")]
	[FieldOffset(Offset = "0x20")]
	private IBlackboard _bb;

	[NonSerialized]
	[Token(Token = "0x40085AD")]
	[FieldOffset(Offset = "0x28")]
	private Variable _varRef;

	[Token(Token = "0x40085AE")]
	protected static Dictionary<string, VariableBBInfo> s_VariableBBInfoCache;

	[Token(Token = "0x170007F8")]
	private string targetVariableID
	{
		[Token(Token = "0x6006FF5")]
		[Address(RVA = "0x4571D0", Offset = "0x455FD0", Length = "0x5")]
		get
		{
			return null;
		}
		[Token(Token = "0x6006FF6")]
		[Address(RVA = "0x49DEE0", Offset = "0x49CCE0", Length = "0x52")]
		set
		{
		}
	}

	[Token(Token = "0x170007F9")]
	public Variable varRef
	{
		[Token(Token = "0x6006FF7")]
		[Address(RVA = "0x413AB0", Offset = "0x4128B0", Length = "0x5")]
		get
		{
			return null;
		}
		[Token(Token = "0x6006FF8")]
		[Address(RVA = "0x10CA580", Offset = "0x10C9380", Length = "0x69")]
		set
		{
		}
	}

	[Token(Token = "0x170007FA")]
	public IBlackboard bb
	{
		[Token(Token = "0x6006FF9")]
		[Address(RVA = "0x40E110", Offset = "0x40CF10", Length = "0x5")]
		get
		{
			return null;
		}
		[Token(Token = "0x6006FFA")]
		[Address(RVA = "0x10CA5F0", Offset = "0x10C93F0", Length = "0x95")]
		set
		{
		}
	}

	[Token(Token = "0x170007FB")]
	public string name
	{
		[Token(Token = "0x6006FFB")]
		[Address(RVA = "0x49DED0", Offset = "0x49CCD0", Length = "0x5")]
		get
		{
			return null;
		}
		[Token(Token = "0x6006FFC")]
		[Address(RVA = "0x10CA690", Offset = "0x10C9490", Length = "0xCA")]
		set
		{
		}
	}

	[Token(Token = "0x170007FC")]
	public bool useBlackboard
	{
		[Token(Token = "0x6006FFD")]
		[Address(RVA = "0x10CA760", Offset = "0x10C9560", Length = "0x9")]
		get
		{
			return false;
		}
		[Token(Token = "0x6006FFE")]
		[Address(RVA = "0x10CA770", Offset = "0x10C9570", Length = "0x8E")]
		set
		{
		}
	}

	[Token(Token = "0x170007FD")]
	public bool isNone
	{
		[Token(Token = "0x6006FFF")]
		[Address(RVA = "0x10CA800", Offset = "0x10C9600", Length = "0x49")]
		get
		{
			return false;
		}
	}

	[Token(Token = "0x170007FE")]
	public bool isDefined
	{
		[Token(Token = "0x6007000")]
		[Address(RVA = "0xEEA2A0", Offset = "0xEE90A0", Length = "0x15")]
		get
		{
			return false;
		}
	}

	[Token(Token = "0x170007FF")]
	public bool isNull
	{
		[Token(Token = "0x6007001")]
		[Address(RVA = "0x10CA850", Offset = "0x10C9650", Length = "0x170")]
		get
		{
			return false;
		}
	}

	[Token(Token = "0x17000800")]
	public Type refType
	{
		[Token(Token = "0x6007002")]
		[Address(RVA = "0x10CA9C0", Offset = "0x10C97C0", Length = "0x20")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000801")]
	public object value
	{
		[Token(Token = "0x6007003")]
		[Address(RVA = "0x105EE30", Offset = "0x105DC30", Length = "0x14")]
		get
		{
			return null;
		}
		[Token(Token = "0x6007004")]
		[Address(RVA = "0x10CA9E0", Offset = "0x10C97E0", Length = "0x11")]
		set
		{
		}
	}

	[Token(Token = "0x17000802")]
	protected abstract object objectValue
	{
		[Token(Token = "0x6007005")]
		get;
		[Token(Token = "0x6007006")]
		set;
	}

	[Token(Token = "0x17000803")]
	public abstract Type varType
	{
		[Token(Token = "0x6007007")]
		get;
	}

	[Token(Token = "0x6006FF0")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public BBParameter()
	{
	}

	[Token(Token = "0x6006FF1")]
	[Address(RVA = "0x10C9A20", Offset = "0x10C8820", Length = "0x1F4")]
	public static BBParameter CreateInstance(Type t, IBlackboard bb)
	{
		return null;
	}

	[Token(Token = "0x6006FF2")]
	[Address(RVA = "0x10C9C20", Offset = "0x10C8A20", Length = "0xBC")]
	public static void ResetVariableNamesCache()
	{
	}

	[Token(Token = "0x6006FF3")]
	[Address(RVA = "0x10C9CE0", Offset = "0x10C8AE0", Length = "0xE0")]
	public static void SetBBFields(object o, IBlackboard bb)
	{
	}

	[Token(Token = "0x6006FF4")]
	[Address(RVA = "0x10C9DD0", Offset = "0x10C8BD0", Length = "0x7AF")]
	public static List<BBParameter> GetObjectBBParameters(object o)
	{
		return null;
	}

	[Token(Token = "0x6007008")]
	protected abstract void Bind(Variable data);

	[Token(Token = "0x6007009")]
	[Address(RVA = "0x10CAA00", Offset = "0x10C9800", Length = "0x151")]
	private Variable ResolveReference(IBlackboard targetBlackboard, bool useID)
	{
		return null;
	}

	[Token(Token = "0x600700A")]
	[Address(RVA = "0x10CAB60", Offset = "0x10C9960", Length = "0x32B")]
	public Variable PromoteToVariable(IBlackboard targetBB)
	{
		return null;
	}

	[Token(Token = "0x600700B")]
	[Address(RVA = "0x10CAE90", Offset = "0x10C9C90", Length = "0x271")]
	public sealed override string ToString()
	{
		return null;
	}
}
[Serializable]
[Token(Token = "0x200107C")]
public class BBParameter<T> : BBParameter
{
	[Token(Token = "0x40085B1")]
	[FieldOffset(Offset = "0x0")]
	private Func<T> getter;

	[Token(Token = "0x40085B2")]
	[FieldOffset(Offset = "0x0")]
	private Action<T> setter;

	[SerializeField]
	[Token(Token = "0x40085B3")]
	[FieldOffset(Offset = "0x0")]
	protected T _value;

	[Token(Token = "0x17000804")]
	public new T value
	{
		[Token(Token = "0x600700F")]
		[Address(RVA = "0x1F73C50", Offset = "0x1F72A50", Length = "0x1B4")]
		get
		{
			return default(T);
		}
		[Token(Token = "0x6007010")]
		[Address(RVA = "0x1F73E10", Offset = "0x1F72C10", Length = "0xEF")]
		set
		{
		}
	}

	[Token(Token = "0x17000805")]
	protected override object objectValue
	{
		[Token(Token = "0x6007012")]
		[Address(RVA = "0x1F74210", Offset = "0x1F73010", Length = "0x3F")]
		get
		{
			return null;
		}
		[Token(Token = "0x6007013")]
		[Address(RVA = "0x1F74250", Offset = "0x1F73050", Length = "0x68")]
		set
		{
		}
	}

	[Token(Token = "0x17000806")]
	public override Type varType
	{
		[Token(Token = "0x6007014")]
		[Address(RVA = "0x1F742C0", Offset = "0x1F730C0", Length = "0x64")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600700D")]
	[Address(RVA = "0x1F73BA0", Offset = "0x1F729A0", Length = "0x43")]
	public BBParameter()
	{
	}

	[Token(Token = "0x600700E")]
	[Address(RVA = "0x1F73BF0", Offset = "0x1F729F0", Length = "0x54")]
	public BBParameter(T value)
	{
	}

	[Token(Token = "0x6007011")]
	[Address(RVA = "0x1F73F00", Offset = "0x1F72D00", Length = "0x306")]
	protected void CheckForPromotedVariable(string name)
	{
	}

	[Token(Token = "0x6007015")]
	[Address(RVA = "0x1F74330", Offset = "0x1F73130", Length = "0x11E")]
	protected override void Bind(Variable variable)
	{
	}

	[Token(Token = "0x6007016")]
	[Address(RVA = "0x1F74450", Offset = "0x1F73250", Length = "0x2F5")]
	private bool BindGetter(Variable variable)
	{
		return false;
	}

	[Token(Token = "0x6007017")]
	[Address(RVA = "0x1F74750", Offset = "0x1F73550", Length = "0x415")]
	private bool BindSetter(Variable variable)
	{
		return false;
	}

	[Token(Token = "0x6007018")]
	[Address(RVA = "0x1F74B70", Offset = "0x1F73970", Length = "0xD4")]
	public static implicit operator BBParameter<T>(T value)
	{
		return null;
	}
}
