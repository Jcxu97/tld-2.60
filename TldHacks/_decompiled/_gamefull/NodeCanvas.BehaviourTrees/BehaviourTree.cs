using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using NodeCanvas.Framework;
using UnityEngine;

namespace NodeCanvas.BehaviourTrees;

[GraphInfo(packageName = "NodeCanvas", docsURL = "http://nodecanvas.paradoxnotion.com/documentation/", resourcesURL = "http://nodecanvas.paradoxnotion.com/downloads/", forumsURL = "http://nodecanvas.paradoxnotion.com/forums-page/")]
[CreateAssetMenu(menuName = "ParadoxNotion/NodeCanvas/Behaviour Tree Asset")]
[Token(Token = "0x200101B")]
public class BehaviourTree : Graph
{
	[Serializable]
	[Token(Token = "0x200101C")]
	private struct DerivedSerializationData
	{
		[Token(Token = "0x4008499")]
		[FieldOffset(Offset = "0x0")]
		public bool repeat;

		[Token(Token = "0x400849A")]
		[FieldOffset(Offset = "0x4")]
		public float updateInterval;
	}

	[SerializeField]
	[Token(Token = "0x4008494")]
	[FieldOffset(Offset = "0x90")]
	public bool repeat;

	[SerializeField]
	[Token(Token = "0x4008495")]
	[FieldOffset(Offset = "0x94")]
	public float updateInterval;

	[Token(Token = "0x4008497")]
	[FieldOffset(Offset = "0x98")]
	private float intervalCounter;

	[Token(Token = "0x4008498")]
	[FieldOffset(Offset = "0x9C")]
	private Status _rootStatus;

	[Token(Token = "0x1700075B")]
	public Status rootStatus
	{
		[Token(Token = "0x6006D70")]
		[Address(RVA = "0x40DA90", Offset = "0x40C890", Length = "0x7")]
		get
		{
			return default(Status);
		}
		[Token(Token = "0x6006D71")]
		[Address(RVA = "0x10AE220", Offset = "0x10AD020", Length = "0x70")]
		private set
		{
		}
	}

	[Token(Token = "0x1700075C")]
	public override Type baseNodeType
	{
		[Token(Token = "0x6006D72")]
		[Address(RVA = "0x10AE290", Offset = "0x10AD090", Length = "0x7D")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700075D")]
	public override bool requiresAgent
	{
		[Token(Token = "0x6006D73")]
		[Address(RVA = "0x430B50", Offset = "0x42F950", Length = "0x3")]
		get
		{
			return false;
		}
	}

	[Token(Token = "0x1700075E")]
	public override bool requiresPrimeNode
	{
		[Token(Token = "0x6006D74")]
		[Address(RVA = "0x430B50", Offset = "0x42F950", Length = "0x3")]
		get
		{
			return false;
		}
	}

	[Token(Token = "0x1700075F")]
	public override bool isTree
	{
		[Token(Token = "0x6006D75")]
		[Address(RVA = "0x430B50", Offset = "0x42F950", Length = "0x3")]
		get
		{
			return false;
		}
	}

	[Token(Token = "0x17000760")]
	public override bool useLocalBlackboard
	{
		[Token(Token = "0x6006D76")]
		[Address(RVA = "0x4A2140", Offset = "0x4A0F40", Length = "0x3")]
		get
		{
			return false;
		}
	}

	[Token(Token = "0x17000761")]
	public sealed override bool canAcceptVariableDrops
	{
		[Token(Token = "0x6006D77")]
		[Address(RVA = "0x4A2140", Offset = "0x4A0F40", Length = "0x3")]
		get
		{
			return false;
		}
	}

	[Token(Token = "0x14000023")]
	public static event Action<BehaviourTree, Status> onRootStatusChanged
	{
		[CompilerGenerated]
		[Token(Token = "0x6006D6E")]
		[Address(RVA = "0x10ADF00", Offset = "0x10ACD00", Length = "0x187")]
		add
		{
		}
		[CompilerGenerated]
		[Token(Token = "0x6006D6F")]
		[Address(RVA = "0x10AE090", Offset = "0x10ACE90", Length = "0x187")]
		remove
		{
		}
	}

	[Token(Token = "0x6006D6C")]
	[Address(RVA = "0x10ADDF0", Offset = "0x10ACBF0", Length = "0x6D")]
	public override object OnDerivedDataSerialization()
	{
		return null;
	}

	[Token(Token = "0x6006D6D")]
	[Address(RVA = "0x10ADE60", Offset = "0x10ACC60", Length = "0x9B")]
	public override void OnDerivedDataDeserialization(object data)
	{
	}

	[Token(Token = "0x6006D78")]
	[Address(RVA = "0x10AE310", Offset = "0x10AD110", Length = "0x39")]
	protected override void OnGraphStarted()
	{
	}

	[Token(Token = "0x6006D79")]
	[Address(RVA = "0x10AE350", Offset = "0x10AD150", Length = "0x17A")]
	protected override void OnGraphUpdate()
	{
	}

	[Token(Token = "0x6006D7A")]
	[Address(RVA = "0x10AE4D0", Offset = "0x10AD2D0", Length = "0x9E")]
	private Status Tick(Component agent, IBlackboard blackboard)
	{
		return default(Status);
	}

	[Token(Token = "0x6006D7B")]
	[Address(RVA = "0x10AE570", Offset = "0x10AD370", Length = "0x5F")]
	public BehaviourTree()
	{
	}
}
