using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.EventSystems;

namespace Rewired.Integration.UnityUI;

[AddComponentMenu("Rewired/Rewired Event System")]
[Token(Token = "0x2000C2A")]
public class RewiredEventSystem : EventSystem
{
	[Tooltip("If enabled, the Event System will be updated every frame even if other Event Systems are enabled. Otherwise, only EventSystem.current will be updated.")]
	[SerializeField]
	[Token(Token = "0x4007C20")]
	[FieldOffset(Offset = "0x60")]
	private bool _alwaysUpdate;

	[Token(Token = "0x1700065E")]
	public bool alwaysUpdate
	{
		[Token(Token = "0x6006225")]
		[Address(RVA = "0x864050", Offset = "0x862E50", Length = "0x5")]
		get
		{
			return false;
		}
		[Token(Token = "0x6006226")]
		[Address(RVA = "0xFB3880", Offset = "0xFB2680", Length = "0x4")]
		set
		{
		}
	}

	[Token(Token = "0x6006227")]
	[Address(RVA = "0xFB3890", Offset = "0xFB2690", Length = "0x326")]
	protected override void Update()
	{
	}

	[Token(Token = "0x6006228")]
	[Address(RVA = "0xFB3BC0", Offset = "0xFB29C0", Length = "0x131")]
	public RewiredEventSystem()
	{
	}
}
