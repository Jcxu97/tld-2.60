using Cpp2ILInjected;
using NodeCanvas.Framework;
using NodeCanvas.StateMachines;
using ParadoxNotion;

[Token(Token = "0x2000829")]
public class FSMHierarchy
{
	[Token(Token = "0x200082A")]
	public enum Rank
	{
		[Token(Token = "0x40055BA")]
		Episode,
		[Token(Token = "0x40055BB")]
		Stage,
		[Token(Token = "0x40055BC")]
		SubStage,
		[Token(Token = "0x40055BD")]
		Worker1,
		[Token(Token = "0x40055BE")]
		Worker2,
		[Token(Token = "0x40055BF")]
		Worker3,
		[Token(Token = "0x40055C0")]
		Max
	}

	[Token(Token = "0x40055B6")]
	[FieldOffset(Offset = "0x10")]
	internal readonly string[] m_RankIds;

	[Token(Token = "0x40055B7")]
	[FieldOffset(Offset = "0x18")]
	internal readonly FSM[] m_FSMs;

	[Token(Token = "0x40055B8")]
	[FieldOffset(Offset = "0x20")]
	internal readonly GraphOwner[] m_ChildGraphs;

	[Token(Token = "0x17000346")]
	public string Episode
	{
		[Token(Token = "0x6004BBB")]
		[Address(RVA = "0xD5B040", Offset = "0xD59E40", Length = "0x27")]
		get
		{
			return null;
		}
		[Token(Token = "0x6004BBC")]
		[Address(RVA = "0xD5B070", Offset = "0xD59E70", Length = "0x20")]
		set
		{
		}
	}

	[Token(Token = "0x17000347")]
	public string Stage
	{
		[Token(Token = "0x6004BBD")]
		[Address(RVA = "0xD5B0A0", Offset = "0xD59EA0", Length = "0x27")]
		get
		{
			return null;
		}
		[Token(Token = "0x6004BBE")]
		[Address(RVA = "0xD5B0D0", Offset = "0xD59ED0", Length = "0x23")]
		set
		{
		}
	}

	[Token(Token = "0x17000348")]
	public string SubStage
	{
		[Token(Token = "0x6004BBF")]
		[Address(RVA = "0xD5B100", Offset = "0xD59F00", Length = "0x27")]
		get
		{
			return null;
		}
		[Token(Token = "0x6004BC0")]
		[Address(RVA = "0xD5B130", Offset = "0xD59F30", Length = "0x23")]
		set
		{
		}
	}

	[Token(Token = "0x17000349")]
	public string Worker1
	{
		[Token(Token = "0x6004BC1")]
		[Address(RVA = "0xD5B160", Offset = "0xD59F60", Length = "0x27")]
		get
		{
			return null;
		}
		[Token(Token = "0x6004BC2")]
		[Address(RVA = "0xD5B190", Offset = "0xD59F90", Length = "0x23")]
		set
		{
		}
	}

	[Token(Token = "0x1700034A")]
	public string Worker2
	{
		[Token(Token = "0x6004BC3")]
		[Address(RVA = "0xD5B1C0", Offset = "0xD59FC0", Length = "0x27")]
		get
		{
			return null;
		}
		[Token(Token = "0x6004BC4")]
		[Address(RVA = "0xD5B1F0", Offset = "0xD59FF0", Length = "0x23")]
		set
		{
		}
	}

	[Token(Token = "0x1700034B")]
	public string Worker3
	{
		[Token(Token = "0x6004BC5")]
		[Address(RVA = "0xD5B220", Offset = "0xD5A020", Length = "0x27")]
		get
		{
			return null;
		}
		[Token(Token = "0x6004BC6")]
		[Address(RVA = "0xD5B250", Offset = "0xD5A050", Length = "0x23")]
		set
		{
		}
	}

	[Token(Token = "0x6004BC7")]
	[Address(RVA = "0xD5B280", Offset = "0xD5A080", Length = "0x17E")]
	public void Reset()
	{
	}

	[Token(Token = "0x6004BC8")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	private void ValidateTag(FSM fsm)
	{
	}

	[Token(Token = "0x6004BC9")]
	[Address(RVA = "0xD5B400", Offset = "0xD5A200", Length = "0x9C")]
	public void SetFSMForRank(Rank rank, FSM fsm)
	{
	}

	[Token(Token = "0x6004BCA")]
	[Address(RVA = "0xD5B4A0", Offset = "0xD5A2A0", Length = "0x168")]
	public void SetChildGraphForRank(Rank rank, GraphOwner graphOwner)
	{
	}

	[Token(Token = "0x6004BCB")]
	[Address(RVA = "0xD5B610", Offset = "0xD5A410", Length = "0xC8")]
	public string GetJumpString()
	{
		return null;
	}

	[Token(Token = "0x6004BCC")]
	[Address(RVA = "0xD5B6E0", Offset = "0xD5A4E0", Length = "0x237")]
	public void RefreshIds()
	{
	}

	[Token(Token = "0x6004BCD")]
	[Address(RVA = "0xD5B920", Offset = "0xD5A720", Length = "0x147")]
	public void Stop()
	{
	}

	[Token(Token = "0x6004BCE")]
	[Address(RVA = "0xD5BA70", Offset = "0xD5A870", Length = "0x14C")]
	public void SendEvent(EventData ev)
	{
	}

	[Token(Token = "0x6004BCF")]
	[Address(RVA = "0xD5BBC0", Offset = "0xD5A9C0", Length = "0x146")]
	public void SendEvent(string eventString)
	{
	}

	[Token(Token = "0x6004BD0")]
	[Address(RVA = "0x18DE540", Offset = "0x18DD340", Length = "0x1EE")]
	public void SendEvent<T>(string eventString, T value)
	{
	}

	[Token(Token = "0x6004BD1")]
	[Address(RVA = "0xD5BD10", Offset = "0xD5AB10", Length = "0x189")]
	public FSMHierarchy()
	{
	}
}
