using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;

[CreateAssetMenu(fileName = "DialogueStatesTable", menuName = "Dialogue/State Table", order = 10003)]
[Token(Token = "0x20002CB")]
public class DialogueStatesTable : ScriptableObject
{
	[Serializable]
	[Token(Token = "0x20002CC")]
	public class DialogueStatesTableEntry
	{
		[Token(Token = "0x4001910")]
		[FieldOffset(Offset = "0x10")]
		public string m_AnimatorType;

		[Token(Token = "0x4001911")]
		[FieldOffset(Offset = "0x18")]
		public string m_BundlePath;

		[Token(Token = "0x4001912")]
		[FieldOffset(Offset = "0x20")]
		public string m_PrefabPath;

		[Token(Token = "0x4001913")]
		[FieldOffset(Offset = "0x28")]
		public string m_LayerName;

		[Token(Token = "0x4001914")]
		[FieldOffset(Offset = "0x30")]
		public int m_LayerIndex;

		[Token(Token = "0x4001915")]
		[FieldOffset(Offset = "0x38")]
		public string m_State;

		[Token(Token = "0x4001916")]
		[FieldOffset(Offset = "0x40")]
		public string m_TriggeredBy;

		[Token(Token = "0x4001917")]
		[FieldOffset(Offset = "0x48")]
		public string m_TriggerIdle;

		[Token(Token = "0x4001918")]
		[FieldOffset(Offset = "0x50")]
		public string m_StateIdle;

		[Token(Token = "0x60017F2")]
		[Address(RVA = "0x6E2CC0", Offset = "0x6E1AC0", Length = "0x278")]
		public string GetKey()
		{
			return null;
		}

		[Token(Token = "0x60017F3")]
		[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
		public DialogueStatesTableEntry()
		{
		}
	}

	[Token(Token = "0x400190F")]
	[FieldOffset(Offset = "0x18")]
	public List<DialogueStatesTableEntry> m_DialogueStatesTableEntries;

	[Token(Token = "0x60017E5")]
	[Address(RVA = "0x6E2640", Offset = "0x6E1440", Length = "0x1F")]
	public string GetLayer(string stateKey)
	{
		return null;
	}

	[Token(Token = "0x60017E6")]
	[Address(RVA = "0x6E2660", Offset = "0x6E1460", Length = "0x1F")]
	public string GetTriggeredBy(string stateKey)
	{
		return null;
	}

	[Token(Token = "0x60017E7")]
	[Address(RVA = "0x6E2680", Offset = "0x6E1480", Length = "0x1F")]
	public string GetTriggerIdle(string stateKey)
	{
		return null;
	}

	[Token(Token = "0x60017E8")]
	[Address(RVA = "0x6E26A0", Offset = "0x6E14A0", Length = "0x1F")]
	public string GetStateIdle(string stateKey)
	{
		return null;
	}

	[Token(Token = "0x60017E9")]
	[Address(RVA = "0x6E26C0", Offset = "0x6E14C0", Length = "0x23")]
	public int GetLayerIndex(string stateKey)
	{
		return 0;
	}

	[Token(Token = "0x60017EA")]
	[Address(RVA = "0x6E26F0", Offset = "0x6E14F0", Length = "0x1F")]
	public string GetBundleFilename(string stateKey)
	{
		return null;
	}

	[Token(Token = "0x60017EB")]
	[Address(RVA = "0x6E2710", Offset = "0x6E1510", Length = "0x1F")]
	public string GetPrefabPath(string stateKey)
	{
		return null;
	}

	[Token(Token = "0x60017EC")]
	[Address(RVA = "0x6E2730", Offset = "0x6E1530", Length = "0x1F")]
	public string GetAnimationState(string stateKey)
	{
		return null;
	}

	[Token(Token = "0x60017ED")]
	[Address(RVA = "0x6E2750", Offset = "0x6E1550", Length = "0x19B")]
	public string GetFirstStateKeyForState(string stateName)
	{
		return null;
	}

	[Token(Token = "0x60017EE")]
	[Address(RVA = "0x6E28F0", Offset = "0x6E16F0", Length = "0x204")]
	public string GetFaceStateKeyForState(string stateName)
	{
		return null;
	}

	[Token(Token = "0x60017EF")]
	[Address(RVA = "0x6E2B00", Offset = "0x6E1900", Length = "0x17")]
	public bool HasKey(string stateKey)
	{
		return false;
	}

	[Token(Token = "0x60017F0")]
	[Address(RVA = "0x6E2B20", Offset = "0x6E1920", Length = "0x197")]
	private DialogueStatesTableEntry GetListEntryFromStateKey(string stateKey)
	{
		return null;
	}

	[Token(Token = "0x60017F1")]
	[Address(RVA = "0x4A22A0", Offset = "0x4A10A0", Length = "0x7")]
	public DialogueStatesTable()
	{
	}
}
