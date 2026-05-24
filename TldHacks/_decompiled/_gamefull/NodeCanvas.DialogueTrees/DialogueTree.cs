using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using NodeCanvas.Framework;
using UnityEngine;

namespace NodeCanvas.DialogueTrees;

[GraphInfo(packageName = "NodeCanvas", docsURL = "http://nodecanvas.paradoxnotion.com/documentation/", resourcesURL = "http://nodecanvas.paradoxnotion.com/downloads/", forumsURL = "http://nodecanvas.paradoxnotion.com/forums-page/")]
[CreateAssetMenu(menuName = "ParadoxNotion/NodeCanvas/Dialogue Tree Asset")]
[Token(Token = "0x20010EB")]
public class DialogueTree : Graph
{
	[Serializable]
	[Token(Token = "0x20010EC")]
	private struct DerivedSerializationData
	{
		[Token(Token = "0x40086E5")]
		[FieldOffset(Offset = "0x0")]
		public List<ActorParameter> actorParameters;
	}

	[Serializable]
	[Token(Token = "0x20010ED")]
	public class ActorParameter
	{
		[SerializeField]
		[Token(Token = "0x40086E6")]
		[FieldOffset(Offset = "0x10")]
		private string _keyName;

		[SerializeField]
		[Token(Token = "0x40086E7")]
		[FieldOffset(Offset = "0x18")]
		private string _id;

		[SerializeField]
		[Token(Token = "0x40086E8")]
		[FieldOffset(Offset = "0x20")]
		private UnityEngine.Object _actorObject;

		[NonSerialized]
		[Token(Token = "0x40086E9")]
		[FieldOffset(Offset = "0x28")]
		private IDialogueActor _actor;

		[Token(Token = "0x17000894")]
		public string name
		{
			[Token(Token = "0x60072DB")]
			[Address(RVA = "0x49DED0", Offset = "0x49CCD0", Length = "0x5")]
			get
			{
				return null;
			}
			[Token(Token = "0x60072DC")]
			[Address(RVA = "0x4094C0", Offset = "0x4082C0", Length = "0x52")]
			set
			{
			}
		}

		[Token(Token = "0x17000895")]
		public string ID
		{
			[Token(Token = "0x60072DD")]
			[Address(RVA = "0x10C0840", Offset = "0x10BF640", Length = "0xEA")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000896")]
		public IDialogueActor actor
		{
			[Token(Token = "0x60072DE")]
			[Address(RVA = "0x10E7CC0", Offset = "0x10E6AC0", Length = "0xAF")]
			get
			{
				return null;
			}
			[Token(Token = "0x60072DF")]
			[Address(RVA = "0x10E7D70", Offset = "0x10E6B70", Length = "0x124")]
			set
			{
			}
		}

		[Token(Token = "0x60072E0")]
		[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
		public ActorParameter()
		{
		}

		[Token(Token = "0x60072E1")]
		[Address(RVA = "0x4094C0", Offset = "0x4082C0", Length = "0x52")]
		public ActorParameter(string name)
		{
		}

		[Token(Token = "0x60072E2")]
		[Address(RVA = "0x10E7EA0", Offset = "0x10E6CA0", Length = "0x5F")]
		public ActorParameter(string name, IDialogueActor actor)
		{
		}

		[Token(Token = "0x60072E3")]
		[Address(RVA = "0x49DED0", Offset = "0x49CCD0", Length = "0x5")]
		public override string ToString()
		{
			return null;
		}
	}

	[Token(Token = "0x40086DB")]
	public const string INSTIGATOR_NAME = "INSTIGATOR";

	[SerializeField]
	[Token(Token = "0x40086DC")]
	[FieldOffset(Offset = "0x90")]
	private List<ActorParameter> _actorParameters;

	[Token(Token = "0x40086DD")]
	[FieldOffset(Offset = "0x98")]
	private DTNode currentNode;

	[Token(Token = "0x1700088A")]
	[field: Token(Token = "0x40086E3")]
	public static DialogueTree currentDialogue
	{
		[Token(Token = "0x60072C0")]
		[Address(RVA = "0x10E61D0", Offset = "0x10E4FD0", Length = "0x3C")]
		get;
		[Token(Token = "0x60072C1")]
		[Address(RVA = "0x10E6210", Offset = "0x10E5010", Length = "0x97")]
		private set;
	}

	[Token(Token = "0x1700088B")]
	[field: Token(Token = "0x40086E4")]
	public static DialogueTree previousDialogue
	{
		[Token(Token = "0x60072C2")]
		[Address(RVA = "0x10E62B0", Offset = "0x10E50B0", Length = "0x3C")]
		get;
		[Token(Token = "0x60072C3")]
		[Address(RVA = "0x10E62F0", Offset = "0x10E50F0", Length = "0x97")]
		private set;
	}

	[Token(Token = "0x1700088C")]
	public override Type baseNodeType
	{
		[Token(Token = "0x60072C4")]
		[Address(RVA = "0x10E6390", Offset = "0x10E5190", Length = "0x7D")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700088D")]
	public override bool requiresAgent
	{
		[Token(Token = "0x60072C5")]
		[Address(RVA = "0x4A2140", Offset = "0x4A0F40", Length = "0x3")]
		get
		{
			return false;
		}
	}

	[Token(Token = "0x1700088E")]
	public override bool requiresPrimeNode
	{
		[Token(Token = "0x60072C6")]
		[Address(RVA = "0x430B50", Offset = "0x42F950", Length = "0x3")]
		get
		{
			return false;
		}
	}

	[Token(Token = "0x1700088F")]
	public override bool isTree
	{
		[Token(Token = "0x60072C7")]
		[Address(RVA = "0x430B50", Offset = "0x42F950", Length = "0x3")]
		get
		{
			return false;
		}
	}

	[Token(Token = "0x17000890")]
	public override bool useLocalBlackboard
	{
		[Token(Token = "0x60072C8")]
		[Address(RVA = "0x4A2140", Offset = "0x4A0F40", Length = "0x3")]
		get
		{
			return false;
		}
	}

	[Token(Token = "0x17000891")]
	public sealed override bool canAcceptVariableDrops
	{
		[Token(Token = "0x60072C9")]
		[Address(RVA = "0x4A2140", Offset = "0x4A0F40", Length = "0x3")]
		get
		{
			return false;
		}
	}

	[Token(Token = "0x17000892")]
	public List<ActorParameter> actorParameters
	{
		[Token(Token = "0x60072CA")]
		[Address(RVA = "0x40DA00", Offset = "0x40C800", Length = "0x8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000893")]
	public List<string> definedActorParameterNames
	{
		[Token(Token = "0x60072CB")]
		[Address(RVA = "0x10E6410", Offset = "0x10E5210", Length = "0x23F")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x14000033")]
	public static event Action<DialogueTree> OnDialogueStarted
	{
		[CompilerGenerated]
		[Token(Token = "0x60072B6")]
		[Address(RVA = "0x10E5230", Offset = "0x10E4030", Length = "0x187")]
		add
		{
		}
		[CompilerGenerated]
		[Token(Token = "0x60072B7")]
		[Address(RVA = "0x10E53C0", Offset = "0x10E41C0", Length = "0x187")]
		remove
		{
		}
	}

	[Token(Token = "0x14000034")]
	public static event Action<DialogueTree> OnDialoguePaused
	{
		[CompilerGenerated]
		[Token(Token = "0x60072B8")]
		[Address(RVA = "0x10E5550", Offset = "0x10E4350", Length = "0x18B")]
		add
		{
		}
		[CompilerGenerated]
		[Token(Token = "0x60072B9")]
		[Address(RVA = "0x10E56E0", Offset = "0x10E44E0", Length = "0x18B")]
		remove
		{
		}
	}

	[Token(Token = "0x14000035")]
	public static event Action<DialogueTree> OnDialogueFinished
	{
		[CompilerGenerated]
		[Token(Token = "0x60072BA")]
		[Address(RVA = "0x10E5870", Offset = "0x10E4670", Length = "0x18B")]
		add
		{
		}
		[CompilerGenerated]
		[Token(Token = "0x60072BB")]
		[Address(RVA = "0x10E5A00", Offset = "0x10E4800", Length = "0x18B")]
		remove
		{
		}
	}

	[Token(Token = "0x14000036")]
	public static event Action<SubtitlesRequestInfo> OnSubtitlesRequest
	{
		[CompilerGenerated]
		[Token(Token = "0x60072BC")]
		[Address(RVA = "0x10E5B90", Offset = "0x10E4990", Length = "0x18B")]
		add
		{
		}
		[CompilerGenerated]
		[Token(Token = "0x60072BD")]
		[Address(RVA = "0x10E5D20", Offset = "0x10E4B20", Length = "0x18B")]
		remove
		{
		}
	}

	[Token(Token = "0x14000037")]
	public static event Action<MultipleChoiceRequestInfo> OnMultipleChoiceRequest
	{
		[CompilerGenerated]
		[Token(Token = "0x60072BE")]
		[Address(RVA = "0x10E5EB0", Offset = "0x10E4CB0", Length = "0x18B")]
		add
		{
		}
		[CompilerGenerated]
		[Token(Token = "0x60072BF")]
		[Address(RVA = "0x10E6040", Offset = "0x10E4E40", Length = "0x18B")]
		remove
		{
		}
	}

	[Token(Token = "0x60072B4")]
	[Address(RVA = "0x10E50B0", Offset = "0x10E3EB0", Length = "0xA2")]
	public override object OnDerivedDataSerialization()
	{
		return null;
	}

	[Token(Token = "0x60072B5")]
	[Address(RVA = "0x10E5160", Offset = "0x10E3F60", Length = "0xC4")]
	public override void OnDerivedDataDeserialization(object data)
	{
	}

	[Token(Token = "0x60072CC")]
	[Address(RVA = "0x10E6650", Offset = "0x10E5450", Length = "0x127")]
	public ActorParameter GetParameterByID(string id)
	{
		return null;
	}

	[Token(Token = "0x60072CD")]
	[Address(RVA = "0x10E6780", Offset = "0x10E5580", Length = "0x127")]
	public ActorParameter GetParameterByName(string paramName)
	{
		return null;
	}

	[Token(Token = "0x60072CE")]
	[Address(RVA = "0x10E68B0", Offset = "0x10E56B0", Length = "0x30")]
	public IDialogueActor GetActorReferenceByID(string id)
	{
		return null;
	}

	[Token(Token = "0x60072CF")]
	[Address(RVA = "0x10E68E0", Offset = "0x10E56E0", Length = "0x38E")]
	public IDialogueActor GetActorReferenceByName(string paramName)
	{
		return null;
	}

	[Token(Token = "0x60072D0")]
	[Address(RVA = "0x10E6C70", Offset = "0x10E5A70", Length = "0x1E9")]
	public void SetActorReference(string paramName, IDialogueActor actor)
	{
	}

	[Token(Token = "0x60072D1")]
	[Address(RVA = "0x10E6E60", Offset = "0x10E5C60", Length = "0x39E")]
	public void SetActorReferences(Dictionary<string, IDialogueActor> actors)
	{
	}

	[Token(Token = "0x60072D2")]
	[Address(RVA = "0x10E7200", Offset = "0x10E6000", Length = "0x157")]
	public void Continue(int index = 0)
	{
	}

	[Token(Token = "0x60072D3")]
	[Address(RVA = "0x10E7360", Offset = "0x10E6160", Length = "0x101")]
	public void EnterNode(DTNode node)
	{
	}

	[Token(Token = "0x60072D4")]
	[Address(RVA = "0x10E7470", Offset = "0x10E6270", Length = "0x9E")]
	public static void RequestSubtitles(SubtitlesRequestInfo info)
	{
	}

	[Token(Token = "0x60072D5")]
	[Address(RVA = "0x10E7510", Offset = "0x10E6310", Length = "0x9E")]
	public static void RequestMultipleChoices(MultipleChoiceRequestInfo info)
	{
	}

	[Token(Token = "0x60072D6")]
	[Address(RVA = "0x10E75B0", Offset = "0x10E63B0", Length = "0x1C6")]
	protected override void OnGraphStarted()
	{
	}

	[Token(Token = "0x60072D7")]
	[Address(RVA = "0x10E7780", Offset = "0x10E6580", Length = "0x1C0")]
	protected override void OnGraphUnpaused()
	{
	}

	[Token(Token = "0x60072D8")]
	[Address(RVA = "0x10E7950", Offset = "0x10E6750", Length = "0x17A")]
	protected override void OnGraphStoped()
	{
	}

	[Token(Token = "0x60072D9")]
	[Address(RVA = "0x10E7AD0", Offset = "0x10E68D0", Length = "0xF6")]
	protected override void OnGraphPaused()
	{
	}

	[Token(Token = "0x60072DA")]
	[Address(RVA = "0x10E7BD0", Offset = "0x10E69D0", Length = "0xEA")]
	public DialogueTree()
	{
	}
}
