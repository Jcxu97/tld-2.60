using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using ParadoxNotion.Design;
using UnityEngine;

namespace NodeCanvas.Framework;

[Serializable]
[SpoofAOT]
[Token(Token = "0x2001084")]
public abstract class Variable
{
	[SerializeField]
	[Token(Token = "0x40085C4")]
	[FieldOffset(Offset = "0x10")]
	private string _name;

	[SerializeField]
	[Token(Token = "0x40085C5")]
	[FieldOffset(Offset = "0x18")]
	private string _id;

	[SerializeField]
	[Token(Token = "0x40085C6")]
	[FieldOffset(Offset = "0x20")]
	private bool _protected;

	[Token(Token = "0x1700080F")]
	public string name
	{
		[Token(Token = "0x6007069")]
		[Address(RVA = "0x49DED0", Offset = "0x49CCD0", Length = "0x5")]
		get
		{
			return null;
		}
		[Token(Token = "0x600706A")]
		[Address(RVA = "0x10CE7A0", Offset = "0x10CD5A0", Length = "0xB8")]
		set
		{
		}
	}

	[Token(Token = "0x17000810")]
	public string ID
	{
		[Token(Token = "0x600706B")]
		[Address(RVA = "0x10CE860", Offset = "0x10CD660", Length = "0xFA")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000811")]
	public object value
	{
		[Token(Token = "0x600706C")]
		[Address(RVA = "0x105EE30", Offset = "0x105DC30", Length = "0x14")]
		get
		{
			return null;
		}
		[Token(Token = "0x600706D")]
		[Address(RVA = "0x10CA9E0", Offset = "0x10C97E0", Length = "0x11")]
		set
		{
		}
	}

	[Token(Token = "0x17000812")]
	public bool isProtected
	{
		[Token(Token = "0x600706E")]
		[Address(RVA = "0x4D3E60", Offset = "0x4D2C60", Length = "0x5")]
		get
		{
			return false;
		}
		[Token(Token = "0x600706F")]
		[Address(RVA = "0x4D3E50", Offset = "0x4D2C50", Length = "0x4")]
		set
		{
		}
	}

	[Token(Token = "0x17000813")]
	protected abstract object objectValue
	{
		[Token(Token = "0x6007073")]
		get;
		[Token(Token = "0x6007074")]
		set;
	}

	[Token(Token = "0x17000814")]
	public abstract Type varType
	{
		[Token(Token = "0x6007075")]
		get;
	}

	[Token(Token = "0x17000815")]
	public abstract bool hasBinding
	{
		[Token(Token = "0x6007076")]
		get;
	}

	[Token(Token = "0x17000816")]
	public abstract string propertyPath
	{
		[Token(Token = "0x6007077")]
		get;
		[Token(Token = "0x6007078")]
		set;
	}

	[Token(Token = "0x1400002B")]
	public event Action<string> onNameChanged
	{
		[CompilerGenerated]
		[Token(Token = "0x6007065")]
		[Address(RVA = "0x10CE1E0", Offset = "0x10CCFE0", Length = "0x166")]
		add
		{
		}
		[CompilerGenerated]
		[Token(Token = "0x6007066")]
		[Address(RVA = "0x10CE350", Offset = "0x10CD150", Length = "0x166")]
		remove
		{
		}
	}

	[Token(Token = "0x1400002C")]
	public event Action<string, object> onValueChanged
	{
		[CompilerGenerated]
		[Token(Token = "0x6007067")]
		[Address(RVA = "0x10CE4C0", Offset = "0x10CD2C0", Length = "0x166")]
		add
		{
		}
		[CompilerGenerated]
		[Token(Token = "0x6007068")]
		[Address(RVA = "0x10CE630", Offset = "0x10CD430", Length = "0x166")]
		remove
		{
		}
	}

	[Token(Token = "0x6007070")]
	[Address(RVA = "0x10CE960", Offset = "0x10CD760", Length = "0x9")]
	protected bool HasValueChangeEvent()
	{
		return false;
	}

	[Token(Token = "0x6007071")]
	[Address(RVA = "0x10CE970", Offset = "0x10CD770", Length = "0x16")]
	protected void OnValueChanged(string name, object value)
	{
	}

	[Token(Token = "0x6007072")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public Variable()
	{
	}

	[Token(Token = "0x6007079")]
	public abstract void BindProperty(MemberInfo prop, GameObject target = null);

	[Token(Token = "0x600707A")]
	public abstract void UnBindProperty();

	[Token(Token = "0x600707B")]
	public abstract void InitializePropertyBinding(GameObject go, bool callSetter = false);

	[Token(Token = "0x600707C")]
	[Address(RVA = "0x10CE990", Offset = "0x10CD790", Length = "0x17")]
	public bool CanConvertTo(Type toType)
	{
		return false;
	}

	[Token(Token = "0x600707D")]
	[Address(RVA = "0x10CE9B0", Offset = "0x10CD7B0", Length = "0x235")]
	public Func<object> GetGetConverter(Type toType)
	{
		return null;
	}

	[Token(Token = "0x600707E")]
	[Address(RVA = "0x10CEBF0", Offset = "0x10CD9F0", Length = "0x17")]
	public bool CanConvertFrom(Type fromType)
	{
		return false;
	}

	[Token(Token = "0x600707F")]
	[Address(RVA = "0x10CEC10", Offset = "0x10CDA10", Length = "0x235")]
	public Action<object> GetSetConverter(Type fromType)
	{
		return null;
	}

	[Token(Token = "0x6007080")]
	[Address(RVA = "0x49DED0", Offset = "0x49CCD0", Length = "0x5")]
	public override string ToString()
	{
		return null;
	}
}
[Serializable]
[Token(Token = "0x2001087")]
public class Variable<T> : Variable
{
	[SerializeField]
	[Token(Token = "0x40085CD")]
	[FieldOffset(Offset = "0x0")]
	private T _value;

	[SerializeField]
	[Token(Token = "0x40085CE")]
	[FieldOffset(Offset = "0x0")]
	private string _propertyPath;

	[Token(Token = "0x40085CF")]
	[FieldOffset(Offset = "0x0")]
	private Func<T> getter;

	[Token(Token = "0x40085D0")]
	[FieldOffset(Offset = "0x0")]
	private Action<T> setter;

	[Token(Token = "0x17000817")]
	public override string propertyPath
	{
		[Token(Token = "0x6007088")]
		[Address(RVA = "0x4A7D60", Offset = "0x4A6B60", Length = "0x5")]
		get
		{
			return null;
		}
		[Token(Token = "0x6007089")]
		[Address(RVA = "0x4D0B00", Offset = "0x4CF900", Length = "0x52")]
		set
		{
		}
	}

	[Token(Token = "0x17000818")]
	public override bool hasBinding
	{
		[Token(Token = "0x600708A")]
		[Address(RVA = "0x22AAF90", Offset = "0x22A9D90", Length = "0x15")]
		get
		{
			return false;
		}
	}

	[Token(Token = "0x17000819")]
	protected override object objectValue
	{
		[Token(Token = "0x600708B")]
		[Address(RVA = "0x22AAFB0", Offset = "0x22A9DB0", Length = "0x4C")]
		get
		{
			return null;
		}
		[Token(Token = "0x600708C")]
		[Address(RVA = "0x22AB000", Offset = "0x22A9E00", Length = "0x7A")]
		set
		{
		}
	}

	[Token(Token = "0x1700081A")]
	public override Type varType
	{
		[Token(Token = "0x600708D")]
		[Address(RVA = "0x1F742C0", Offset = "0x1F730C0", Length = "0x64")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700081B")]
	public new T value
	{
		[Token(Token = "0x600708E")]
		[Address(RVA = "0x22AB080", Offset = "0x22A9E80", Length = "0x20")]
		get
		{
			return default(T);
		}
		[Token(Token = "0x600708F")]
		[Address(RVA = "0x22AB0A0", Offset = "0x22A9EA0", Length = "0x139")]
		set
		{
		}
	}

	[Token(Token = "0x6007087")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public Variable()
	{
	}

	[Token(Token = "0x6007090")]
	[Address(RVA = "0x22AB080", Offset = "0x22A9E80", Length = "0x20")]
	public T GetValue()
	{
		return default(T);
	}

	[Token(Token = "0x6007091")]
	[Address(RVA = "0x22AB1E0", Offset = "0x22A9FE0", Length = "0x14")]
	public void SetValue(T newValue)
	{
	}

	[Token(Token = "0x6007092")]
	[Address(RVA = "0x22AB200", Offset = "0x22AA000", Length = "0x2E5")]
	public override void BindProperty(MemberInfo prop, GameObject target = null)
	{
	}

	[Token(Token = "0x6007093")]
	[Address(RVA = "0x22AB4F0", Offset = "0x22AA2F0", Length = "0xFA")]
	public override void UnBindProperty()
	{
	}

	[Token(Token = "0x6007094")]
	[Address(RVA = "0x22AB5F0", Offset = "0x22AA3F0", Length = "0xCC5")]
	public override void InitializePropertyBinding(GameObject go, bool callSetter = false)
	{
	}
}
