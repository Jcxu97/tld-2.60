using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using NodeCanvas.Framework.Internal;
using ParadoxNotion.Design;
using UnityEngine;

namespace NodeCanvas.Framework;

[SpoofAOT]
[Token(Token = "0x200107F")]
public class Blackboard : MonoBehaviour, ISerializationCallbackReceiver, IBlackboard
{
	[Token(Token = "0x2001080")]
	private class BBKeyVar
	{
		[Token(Token = "0x40085BF")]
		[FieldOffset(Offset = "0x10")]
		public string key;

		[Token(Token = "0x40085C0")]
		[FieldOffset(Offset = "0x18")]
		public Variable variable;

		[Token(Token = "0x6007043")]
		[Address(RVA = "0x409520", Offset = "0x408320", Length = "0xAA")]
		public BBKeyVar(string _key, Variable _variable)
		{
		}
	}

	[SerializeField]
	[Token(Token = "0x40085BA")]
	[FieldOffset(Offset = "0x30")]
	private string _serializedBlackboard;

	[SerializeField]
	[Token(Token = "0x40085BB")]
	[FieldOffset(Offset = "0x38")]
	private List<UnityEngine.Object> _objectReferences;

	[NonSerialized]
	[Token(Token = "0x40085BC")]
	[FieldOffset(Offset = "0x40")]
	private BlackboardSource _blackboard;

	[NonSerialized]
	[Token(Token = "0x40085BD")]
	[FieldOffset(Offset = "0x48")]
	private bool hasDeserialized;

	[Token(Token = "0x40085BE")]
	private static List<BBKeyVar> internalVarsTempList;

	[Token(Token = "0x17000807")]
	public new string name
	{
		[Token(Token = "0x6007025")]
		[Address(RVA = "0x10CB9E0", Offset = "0x10CA7E0", Length = "0x80")]
		get
		{
			return null;
		}
		[Token(Token = "0x6007026")]
		[Address(RVA = "0x10CBA70", Offset = "0x10CA870", Length = "0xD1")]
		set
		{
		}
	}

	[Token(Token = "0x17000808")]
	public object this[string varName]
	{
		[Token(Token = "0x6007027")]
		[Address(RVA = "0x10CBB50", Offset = "0x10CA950", Length = "0x1E")]
		get
		{
			return null;
		}
		[Token(Token = "0x6007028")]
		[Address(RVA = "0x10CBB70", Offset = "0x10CA970", Length = "0x1E")]
		set
		{
		}
	}

	[Token(Token = "0x17000809")]
	public Dictionary<string, Variable> variables
	{
		[Token(Token = "0x6007029")]
		[Address(RVA = "0x10CBB90", Offset = "0x10CA990", Length = "0x1B")]
		get
		{
			return null;
		}
		[Token(Token = "0x600702A")]
		[Address(RVA = "0x10CBBB0", Offset = "0x10CA9B0", Length = "0x5C")]
		set
		{
		}
	}

	[Token(Token = "0x1700080A")]
	public GameObject propertiesBindTarget
	{
		[Token(Token = "0x600702B")]
		[Address(RVA = "0x86AC30", Offset = "0x869A30", Length = "0x7")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x14000027")]
	public event Action<Variable> onVariableAdded
	{
		[CompilerGenerated]
		[Token(Token = "0x600701E")]
		[Address(RVA = "0x10CB260", Offset = "0x10CA060", Length = "0x166")]
		add
		{
		}
		[CompilerGenerated]
		[Token(Token = "0x600701F")]
		[Address(RVA = "0x10CB3D0", Offset = "0x10CA1D0", Length = "0x166")]
		remove
		{
		}
	}

	[Token(Token = "0x14000028")]
	public event Action<Variable> onVariableRemoved
	{
		[CompilerGenerated]
		[Token(Token = "0x6007020")]
		[Address(RVA = "0x10CB540", Offset = "0x10CA340", Length = "0x166")]
		add
		{
		}
		[CompilerGenerated]
		[Token(Token = "0x6007021")]
		[Address(RVA = "0x10CB6B0", Offset = "0x10CA4B0", Length = "0x166")]
		remove
		{
		}
	}

	[Token(Token = "0x6007022")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	void ISerializationCallbackReceiver.OnBeforeSerialize()
	{
	}

	[Token(Token = "0x6007023")]
	[Address(RVA = "0x10CB820", Offset = "0x10CA620", Length = "0x17B")]
	void ISerializationCallbackReceiver.OnAfterDeserialize()
	{
	}

	[Token(Token = "0x6007024")]
	[Address(RVA = "0x10CB9A0", Offset = "0x10CA7A0", Length = "0x31")]
	protected virtual void Awake()
	{
	}

	[Token(Token = "0x600702C")]
	[Address(RVA = "0x10CBC10", Offset = "0x10CAA10", Length = "0x4D")]
	public Variable AddVariable(string name, Type type)
	{
		return null;
	}

	[Token(Token = "0x600702D")]
	[Address(RVA = "0x10CBC60", Offset = "0x10CAA60", Length = "0x4D")]
	public Variable AddVariable(string name, object value)
	{
		return null;
	}

	[Token(Token = "0x600702E")]
	[Address(RVA = "0x10CBCB0", Offset = "0x10CAAB0", Length = "0xEA")]
	public Variable RemoveVariable(string name)
	{
		return null;
	}

	[Token(Token = "0x600702F")]
	[Address(RVA = "0x10CBDA0", Offset = "0x10CABA0", Length = "0xD0")]
	public Variable GetVariable(string name, Type ofType = null)
	{
		return null;
	}

	[Token(Token = "0x6007030")]
	[Address(RVA = "0x10CBE80", Offset = "0x10CAC80", Length = "0x1E")]
	public Variable GetVariableByID(string ID)
	{
		return null;
	}

	[Token(Token = "0x6007031")]
	[Address(RVA = "0x1871F40", Offset = "0x1870D40", Length = "0x53")]
	public Variable<T> GetVariable<T>(string name)
	{
		return null;
	}

	[Token(Token = "0x6007032")]
	[Address(RVA = "0x18717F0", Offset = "0x18705F0", Length = "0x53")]
	public T GetValue<T>(string name)
	{
		return default(T);
	}

	[Token(Token = "0x6007033")]
	[Address(RVA = "0x10CBB70", Offset = "0x10CA970", Length = "0x1E")]
	public Variable SetValue(string name, object value)
	{
		return null;
	}

	[Token(Token = "0x6007034")]
	[Address(RVA = "0x10CBEA0", Offset = "0x10CACA0", Length = "0xE9")]
	public string[] GetVariableNames()
	{
		return null;
	}

	[Token(Token = "0x6007035")]
	[Address(RVA = "0x10CBF90", Offset = "0x10CAD90", Length = "0x1E")]
	public string[] GetVariableNames(Type ofType)
	{
		return null;
	}

	[Token(Token = "0x6007036")]
	[Address(RVA = "0x10CBFB0", Offset = "0x10CADB0", Length = "0x40")]
	public string Save()
	{
		return null;
	}

	[Token(Token = "0x6007037")]
	[Address(RVA = "0x10CBFF0", Offset = "0x10CADF0", Length = "0x33")]
	public string Save(string saveKey)
	{
		return null;
	}

	[Token(Token = "0x6007038")]
	[Address(RVA = "0x10CC030", Offset = "0x10CAE30", Length = "0x23")]
	public bool Load()
	{
		return false;
	}

	[Token(Token = "0x6007039")]
	[Address(RVA = "0x10CC060", Offset = "0x10CAE60", Length = "0xE7")]
	public bool Load(string saveKey)
	{
		return false;
	}

	[Token(Token = "0x600703A")]
	[Address(RVA = "0x10CC150", Offset = "0x10CAF50", Length = "0x7")]
	public void TLD_PreSerialize()
	{
	}

	[Token(Token = "0x600703B")]
	[Address(RVA = "0x10CC160", Offset = "0x10CAF60", Length = "0x7")]
	public void TLD_PostSerialize()
	{
	}

	[Token(Token = "0x600703C")]
	[Address(RVA = "0x10CC170", Offset = "0x10CAF70", Length = "0x43B")]
	public void ExtractInternalVars()
	{
	}

	[Token(Token = "0x600703D")]
	[Address(RVA = "0x10CC5B0", Offset = "0x10CB3B0", Length = "0x1BF")]
	public void RestoreInternalVars()
	{
	}

	[Token(Token = "0x600703E")]
	[Address(RVA = "0x10CC770", Offset = "0x10CB570", Length = "0xD7")]
	public string Serialize()
	{
		return null;
	}

	[Token(Token = "0x600703F")]
	[Address(RVA = "0x10CC850", Offset = "0x10CB650", Length = "0xD6")]
	public string Serialize(List<UnityEngine.Object> storedObjectReferences)
	{
		return null;
	}

	[Token(Token = "0x6007040")]
	[Address(RVA = "0x10CC930", Offset = "0x10CB730", Length = "0x1E")]
	public bool Deserialize(string json)
	{
		return false;
	}

	[Token(Token = "0x6007041")]
	[Address(RVA = "0x10CC950", Offset = "0x10CB750", Length = "0x69E")]
	public bool Deserialize(string json, List<UnityEngine.Object> storedObjectReferences, bool removeMissing = true)
	{
		return false;
	}

	[Token(Token = "0x6007042")]
	[Address(RVA = "0x10CCFF0", Offset = "0x10CBDF0", Length = "0xD2")]
	public Blackboard()
	{
	}
}
