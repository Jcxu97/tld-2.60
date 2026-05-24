using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x2000003")]
public class vp_Component : MonoBehaviour
{
	[Token(Token = "0x400000E")]
	[FieldOffset(Offset = "0x20")]
	public bool Persist;

	[Token(Token = "0x400000F")]
	[FieldOffset(Offset = "0x28")]
	protected vp_StateManager m_StateManager;

	[Token(Token = "0x4000010")]
	[FieldOffset(Offset = "0x30")]
	public List<vp_StateInfo> States;

	[Token(Token = "0x4000011")]
	[FieldOffset(Offset = "0x38")]
	protected vp_StateInfo m_DefaultState;

	[Token(Token = "0x4000012")]
	[FieldOffset(Offset = "0x40")]
	protected bool m_Initialized;

	[Token(Token = "0x17000001")]
	public vp_StateManager StateManager
	{
		[Token(Token = "0x6000006")]
		[Address(RVA = "0x413AB0", Offset = "0x4128B0", Length = "0x5")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000002")]
	public vp_StateInfo DefaultState
	{
		[Token(Token = "0x6000007")]
		[Address(RVA = "0x4A7D50", Offset = "0x4A6B50", Length = "0x5")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000003")]
	public float Delta
	{
		[Token(Token = "0x6000008")]
		[Address(RVA = "0x53DC80", Offset = "0x53CA80", Length = "0x1A9")]
		get
		{
			return 0f;
		}
	}

	[Token(Token = "0x6000009")]
	[Address(RVA = "0x53DE30", Offset = "0x53CC30", Length = "0x159")]
	protected virtual void Awake()
	{
	}

	[Token(Token = "0x600000A")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	protected virtual void Start()
	{
	}

	[Token(Token = "0x600000B")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	protected virtual void Init()
	{
	}

	[Token(Token = "0x600000C")]
	[Address(RVA = "0x53DF90", Offset = "0x53CD90", Length = "0x29")]
	protected virtual void Update()
	{
	}

	[Token(Token = "0x600000D")]
	[Address(RVA = "0x53DFC0", Offset = "0x53CDC0", Length = "0x38")]
	public void SetState(string state, bool enabled)
	{
	}

	[Token(Token = "0x600000E")]
	[Address(RVA = "0x53E000", Offset = "0x53CE00", Length = "0x37")]
	public void ResetState()
	{
	}

	[Token(Token = "0x600000F")]
	[Address(RVA = "0x53E040", Offset = "0x53CE40", Length = "0x38")]
	public virtual void AllowState(string state, bool isAllowed)
	{
	}

	[Token(Token = "0x6000010")]
	[Address(RVA = "0x53E080", Offset = "0x53CE80", Length = "0x118")]
	public void AllowStateRecursively(string state, bool isAllowed)
	{
	}

	[Token(Token = "0x6000011")]
	[Address(RVA = "0x53E1A0", Offset = "0x53CFA0", Length = "0x1E")]
	public bool StateEnabled(string stateName)
	{
		return false;
	}

	[Token(Token = "0x6000012")]
	[Address(RVA = "0x53E1C0", Offset = "0x53CFC0", Length = "0x527")]
	public void RefreshDefaultState()
	{
	}

	[Token(Token = "0x6000013")]
	[Address(RVA = "0x53E6F0", Offset = "0x53D4F0", Length = "0x7C")]
	public void ApplyPreset(vp_ComponentPreset preset)
	{
	}

	[Token(Token = "0x6000014")]
	[Address(RVA = "0x53E770", Offset = "0x53D570", Length = "0xF0")]
	public vp_ComponentPreset Load(string path)
	{
		return null;
	}

	[Token(Token = "0x6000015")]
	[Address(RVA = "0x53E870", Offset = "0x53D670", Length = "0xF0")]
	public vp_ComponentPreset Load(TextAsset asset)
	{
		return null;
	}

	[Token(Token = "0x6000016")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public virtual void Refresh()
	{
	}

	[Token(Token = "0x6000017")]
	[Address(RVA = "0x53E970", Offset = "0x53D770", Length = "0xE3")]
	public vp_Component()
	{
	}
}
