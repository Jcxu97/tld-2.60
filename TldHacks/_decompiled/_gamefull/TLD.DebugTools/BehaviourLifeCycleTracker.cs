using System;
using Cpp2ILInjected;
using TLD.Logging;
using UnityEngine;

namespace TLD.DebugTools;

[Token(Token = "0x20013E1")]
public class BehaviourLifeCycleTracker : MonoBehaviour
{
	[Flags]
	[Token(Token = "0x20013E2")]
	public enum CallsToTrack
	{
		[Token(Token = "0x400919B")]
		None = 0,
		[Token(Token = "0x400919C")]
		Awake = 1,
		[Token(Token = "0x400919D")]
		OnEnable = 2,
		[Token(Token = "0x400919E")]
		Start = 4,
		[Token(Token = "0x400919F")]
		OnDisable = 8,
		[Token(Token = "0x40091A0")]
		OnDestroy = 0x10
	}

	[Token(Token = "0x4009198")]
	private static readonly LogFilter s_LogFilter;

	[SerializeField]
	[Token(Token = "0x4009199")]
	[FieldOffset(Offset = "0x20")]
	private CallsToTrack m_CallsToTrack;

	[Token(Token = "0x6007ED2")]
	[Address(RVA = "0x11E7D70", Offset = "0x11E6B70", Length = "0x43")]
	private void Awake()
	{
	}

	[Token(Token = "0x6007ED3")]
	[Address(RVA = "0x11E7D70", Offset = "0x11E6B70", Length = "0x43")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6007ED4")]
	[Address(RVA = "0x11E7D70", Offset = "0x11E6B70", Length = "0x43")]
	private void Start()
	{
	}

	[Token(Token = "0x6007ED5")]
	[Address(RVA = "0x11E7D70", Offset = "0x11E6B70", Length = "0x43")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6007ED6")]
	[Address(RVA = "0x11E7D70", Offset = "0x11E6B70", Length = "0x43")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6007ED7")]
	[Address(RVA = "0x11E7D70", Offset = "0x11E6B70", Length = "0x43")]
	private void LogIfTracked(CallsToTrack mask)
	{
	}

	[Token(Token = "0x6007ED8")]
	[Address(RVA = "0x11E7DC0", Offset = "0x11E6BC0", Length = "0x6")]
	private static bool IsSet(CallsToTrack settings, CallsToTrack mask)
	{
		return false;
	}

	[Token(Token = "0x6007ED9")]
	[Address(RVA = "0x4AF5E0", Offset = "0x4AE3E0", Length = "0x43")]
	public BehaviourLifeCycleTracker()
	{
	}
}
