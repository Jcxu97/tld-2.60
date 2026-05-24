using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x200042B")]
public class Knowledge : MonoBehaviour
{
	[Token(Token = "0x4002582")]
	[FieldOffset(Offset = "0x20")]
	public KnowledgeCateogry m_KnowledgeCategory;

	[Token(Token = "0x4002583")]
	[FieldOffset(Offset = "0x28")]
	public LocalizedString m_LocalizedName;

	[Token(Token = "0x4002584")]
	[FieldOffset(Offset = "0x30")]
	public LocalizedString m_LocalizedDescription;

	[Token(Token = "0x17000210")]
	public string m_Description
	{
		[Token(Token = "0x6001F57")]
		[Address(RVA = "0x74FF70", Offset = "0x74ED70", Length = "0x5D")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6001F58")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public void Start()
	{
	}

	[Token(Token = "0x6001F59")]
	[Address(RVA = "0x7D9D20", Offset = "0x7D8B20", Length = "0x1B")]
	public string GetLocID()
	{
		return null;
	}

	[Token(Token = "0x6001F5A")]
	[Address(RVA = "0x7D9D40", Offset = "0x7D8B40", Length = "0x42")]
	public void UnlockWithNotification(string subTitle)
	{
	}

	[Token(Token = "0x6001F5B")]
	[Address(RVA = "0x7D9D90", Offset = "0x7D8B90", Length = "0xC8")]
	public void UnlockSilent()
	{
	}

	[Token(Token = "0x6001F5C")]
	[Address(RVA = "0x7D9E60", Offset = "0x7D8C60", Length = "0x117")]
	public static void Unlock(string nameLocID, string descLocID, KnowledgeCateogry category, string subTitle, bool showNotificationFlag = true)
	{
	}

	[Token(Token = "0x6001F5D")]
	[Address(RVA = "0x7D9F80", Offset = "0x7D8D80", Length = "0xF2")]
	public static void UnlockSilent(string nameLocID, string descLocID, KnowledgeCateogry category)
	{
	}

	[Token(Token = "0x6001F5E")]
	[Address(RVA = "0x7DA080", Offset = "0x7D8E80", Length = "0x21C")]
	public static KnowledgeCateogry GetKnowledgeCategoryFromName(string name)
	{
		return default(KnowledgeCateogry);
	}

	[Token(Token = "0x6001F5F")]
	[Address(RVA = "0x7DA2A0", Offset = "0x7D90A0", Length = "0x1F8")]
	public static string GetLocalizedKnowledgeCategoryName(KnowledgeCateogry category)
	{
		return null;
	}

	[Token(Token = "0x6001F60")]
	[Address(RVA = "0x4AF5E0", Offset = "0x4AE3E0", Length = "0x43")]
	public Knowledge()
	{
	}
}
