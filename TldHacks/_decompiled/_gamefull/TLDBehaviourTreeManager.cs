using System.Collections.Generic;
using Cpp2ILInjected;

[Token(Token = "0x200084B")]
public class TLDBehaviourTreeManager
{
	[Token(Token = "0x400567E")]
	private static List<TLDBehaviourTreeOwner> m_BehaviourTreeOwnerList;

	[Token(Token = "0x400567F")]
	private static TLDBehaviourTreeManagerProxy m_TLDBehaviourTreeManagerProxy;

	[Token(Token = "0x4005680")]
	private const int TREE_OWNER_PROXY_POOL_LEN = 128;

	[Token(Token = "0x4005681")]
	private static TLDBehaviourTreeOwnerProxy[] m_TreeOwnerProxyPool;

	[Token(Token = "0x6004CB4")]
	[Address(RVA = "0xD75980", Offset = "0xD74780", Length = "0x1F5")]
	public static void Init()
	{
	}

	[Token(Token = "0x6004CB5")]
	[Address(RVA = "0xD75B80", Offset = "0xD74980", Length = "0xBD")]
	public static void RegisterBehaviourTreeOwner(TLDBehaviourTreeOwner behaviourTreeOwner)
	{
	}

	[Token(Token = "0x6004CB6")]
	[Address(RVA = "0xD75C40", Offset = "0xD74A40", Length = "0x82")]
	public static void UnregisterBehaviourTreeOwner(TLDBehaviourTreeOwner behaviourTreeOwner)
	{
	}

	[Token(Token = "0x6004CB7")]
	[Address(RVA = "0xD75CD0", Offset = "0xD74AD0", Length = "0x4C3")]
	public static string Serialize()
	{
		return null;
	}

	[Token(Token = "0x6004CB8")]
	[Address(RVA = "0xD761A0", Offset = "0xD74FA0", Length = "0x20E")]
	public static TLDBehaviourTreeOwner FindBehaviourTreeOwner(string name)
	{
		return null;
	}

	[Token(Token = "0x6004CB9")]
	[Address(RVA = "0xD763B0", Offset = "0xD751B0", Length = "0x323")]
	public static void Deserialize(string buffer)
	{
	}

	[Token(Token = "0x6004CBA")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public TLDBehaviourTreeManager()
	{
	}
}
