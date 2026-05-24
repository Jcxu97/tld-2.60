using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using NodeCanvas.Framework;
using ParadoxNotion;
using UnityEngine;

namespace NodeCanvas;

[AddComponentMenu("NodeCanvas/Standalone Action List (Bonus)")]
[Token(Token = "0x200101A")]
public class ActionListPlayer : MonoBehaviour, ITaskSystem, ISerializationCallbackReceiver
{
	[Token(Token = "0x400848F")]
	[FieldOffset(Offset = "0x20")]
	public bool playOnAwake;

	[SerializeField]
	[Token(Token = "0x4008490")]
	[FieldOffset(Offset = "0x28")]
	private string _serializedList;

	[SerializeField]
	[Token(Token = "0x4008491")]
	[FieldOffset(Offset = "0x30")]
	private List<UnityEngine.Object> _objectReferences;

	[SerializeField]
	[Token(Token = "0x4008492")]
	[FieldOffset(Offset = "0x38")]
	private Blackboard _blackboard;

	[NonSerialized]
	[Token(Token = "0x4008493")]
	[FieldOffset(Offset = "0x40")]
	private ActionList _actionList;

	[Token(Token = "0x17000756")]
	public ActionList actionList
	{
		[Token(Token = "0x6006D5B")]
		[Address(RVA = "0x4A7D60", Offset = "0x4A6B60", Length = "0x5")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000757")]
	Component ITaskSystem.agent
	{
		[Token(Token = "0x6006D5C")]
		[Address(RVA = "0x10AD7C0", Offset = "0x10AC5C0", Length = "0x4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000758")]
	public IBlackboard blackboard
	{
		[Token(Token = "0x6006D5D")]
		[Address(RVA = "0x4A7D50", Offset = "0x4A6B50", Length = "0x5")]
		get
		{
			return null;
		}
		[Token(Token = "0x6006D5E")]
		[Address(RVA = "0x10AD7D0", Offset = "0x10AC5D0", Length = "0x107")]
		set
		{
		}
	}

	[Token(Token = "0x17000759")]
	public float elapsedTime
	{
		[Token(Token = "0x6006D5F")]
		[Address(RVA = "0x10AD8E0", Offset = "0x10AC6E0", Length = "0x1D")]
		get
		{
			return 0f;
		}
	}

	[Token(Token = "0x1700075A")]
	UnityEngine.Object ITaskSystem.contextObject
	{
		[Token(Token = "0x6006D60")]
		[Address(RVA = "0x10AD7C0", Offset = "0x10AC5C0", Length = "0x4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6006D59")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	void ISerializationCallbackReceiver.OnBeforeSerialize()
	{
	}

	[Token(Token = "0x6006D5A")]
	[Address(RVA = "0x10AD580", Offset = "0x10AC380", Length = "0x235")]
	void ISerializationCallbackReceiver.OnAfterDeserialize()
	{
	}

	[Token(Token = "0x6006D61")]
	[Address(RVA = "0x10AD900", Offset = "0x10AC700", Length = "0xCA")]
	public static ActionListPlayer Create()
	{
		return null;
	}

	[Token(Token = "0x6006D62")]
	[Address(RVA = "0x10AD9D0", Offset = "0x10AC7D0", Length = "0x16F")]
	public void SendTaskOwnerDefaults()
	{
	}

	[Token(Token = "0x6006D63")]
	[Address(RVA = "0x10ADB40", Offset = "0x10AC940", Length = "0x5D")]
	void ITaskSystem.SendEvent(EventData eventData, object sender)
	{
	}

	[Token(Token = "0x6006D64")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	void ITaskSystem.RecordUndo(string name)
	{
	}

	[Token(Token = "0x6006D65")]
	[Address(RVA = "0x10ADBA0", Offset = "0x10AC9A0", Length = "0x37")]
	private void Awake()
	{
	}

	[ContextMenu("Play")]
	[Token(Token = "0x6006D66")]
	[Address(RVA = "0x10ADBE0", Offset = "0x10AC9E0", Length = "0x21")]
	public void Play()
	{
	}

	[Token(Token = "0x6006D67")]
	[Address(RVA = "0x10ADC10", Offset = "0x10ACA10", Length = "0x21")]
	public void Play(Action<bool> OnFinish)
	{
	}

	[Token(Token = "0x6006D68")]
	[Address(RVA = "0x10ADC40", Offset = "0x10ACA40", Length = "0x145")]
	public void Play(Component agent, IBlackboard blackboard, Action<bool> OnFinish)
	{
	}

	[Token(Token = "0x6006D69")]
	[Address(RVA = "0x10ADD90", Offset = "0x10ACB90", Length = "0x28")]
	public Status ExecuteAction()
	{
		return default(Status);
	}

	[Token(Token = "0x6006D6A")]
	[Address(RVA = "0x10ADDC0", Offset = "0x10ACBC0", Length = "0x25")]
	public Status ExecuteAction(Component agent)
	{
		return default(Status);
	}

	[Token(Token = "0x6006D6B")]
	[Address(RVA = "0x4AF5E0", Offset = "0x4AE3E0", Length = "0x43")]
	public ActionListPlayer()
	{
	}
}
