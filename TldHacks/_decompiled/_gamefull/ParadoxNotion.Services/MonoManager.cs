using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using UnityEngine;

namespace ParadoxNotion.Services;

[Token(Token = "0x2000D71")]
public class MonoManager : MonoBehaviour
{
	[Token(Token = "0x2000D72")]
	private class UpdateGraphInfo
	{
		[Token(Token = "0x40083E4")]
		[FieldOffset(Offset = "0x10")]
		public Action m_OnUpdate;

		[Token(Token = "0x40083E5")]
		[FieldOffset(Offset = "0x18")]
		public Action<float> m_SetAccumulatedDeltaTime;

		[Token(Token = "0x40083E6")]
		[FieldOffset(Offset = "0x20")]
		public float m_AccumulatedDeltaTime;

		[Token(Token = "0x600692D")]
		[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
		public UpdateGraphInfo()
		{
		}
	}

	[Token(Token = "0x40083E0")]
	private static MonoManager _current;

	[Token(Token = "0x40083E1")]
	[FieldOffset(Offset = "0x40")]
	private int m_CurrentGraphUpdated;

	[Token(Token = "0x40083E2")]
	[FieldOffset(Offset = "0x48")]
	private List<UpdateGraphInfo> m_UpdateGraphInfoList;

	[Token(Token = "0x40083E3")]
	public static bool s_StaggeredUpdateEnabled;

	[Token(Token = "0x1700072F")]
	[field: Token(Token = "0x40083DF")]
	public static bool isQuiting
	{
		[Token(Token = "0x600691A")]
		[Address(RVA = "0x1071C50", Offset = "0x1070A50", Length = "0x53")]
		get;
		[Token(Token = "0x600691B")]
		[Address(RVA = "0x1071CB0", Offset = "0x1070AB0", Length = "0x58")]
		private set;
	}

	[Token(Token = "0x17000730")]
	public static MonoManager current
	{
		[Token(Token = "0x600691C")]
		[Address(RVA = "0x1071D10", Offset = "0x1070B10", Length = "0x367")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1400001F")]
	public event Action onLateUpdate
	{
		[CompilerGenerated]
		[Token(Token = "0x6006912")]
		[Address(RVA = "0x10713D0", Offset = "0x10701D0", Length = "0xEB")]
		add
		{
		}
		[CompilerGenerated]
		[Token(Token = "0x6006913")]
		[Address(RVA = "0x10714C0", Offset = "0x10702C0", Length = "0xEB")]
		remove
		{
		}
	}

	[Token(Token = "0x14000020")]
	public event Action onFixedUpdate
	{
		[CompilerGenerated]
		[Token(Token = "0x6006914")]
		[Address(RVA = "0x10715B0", Offset = "0x10703B0", Length = "0xEB")]
		add
		{
		}
		[CompilerGenerated]
		[Token(Token = "0x6006915")]
		[Address(RVA = "0x10716A0", Offset = "0x10704A0", Length = "0xEB")]
		remove
		{
		}
	}

	[Token(Token = "0x14000021")]
	public event Action onApplicationQuit
	{
		[CompilerGenerated]
		[Token(Token = "0x6006916")]
		[Address(RVA = "0x1071790", Offset = "0x1070590", Length = "0xEB")]
		add
		{
		}
		[CompilerGenerated]
		[Token(Token = "0x6006917")]
		[Address(RVA = "0x1071880", Offset = "0x1070680", Length = "0xEB")]
		remove
		{
		}
	}

	[Token(Token = "0x14000022")]
	public event Action<bool> onApplicationPause
	{
		[CompilerGenerated]
		[Token(Token = "0x6006918")]
		[Address(RVA = "0x1071970", Offset = "0x1070770", Length = "0x166")]
		add
		{
		}
		[CompilerGenerated]
		[Token(Token = "0x6006919")]
		[Address(RVA = "0x1071AE0", Offset = "0x10708E0", Length = "0x166")]
		remove
		{
		}
	}

	[Token(Token = "0x600691D")]
	[Address(RVA = "0x1072080", Offset = "0x1070E80", Length = "0xB6")]
	public static void Create()
	{
	}

	[Token(Token = "0x600691E")]
	[Address(RVA = "0x1072140", Offset = "0x1070F40", Length = "0x15E")]
	public bool StaggeredUpdatedEnabled()
	{
		return false;
	}

	[Token(Token = "0x600691F")]
	[Address(RVA = "0x10722A0", Offset = "0x10710A0", Length = "0x5A")]
	public int GetYeldReturnFrameCount()
	{
		return 0;
	}

	[Token(Token = "0x6006920")]
	[Address(RVA = "0x1072300", Offset = "0x1071100", Length = "0xA6")]
	protected void OnApplicationQuit()
	{
	}

	[Token(Token = "0x6006921")]
	[Address(RVA = "0x10723B0", Offset = "0x10711B0", Length = "0x16")]
	protected void OnApplicationPause(bool isPause)
	{
	}

	[Token(Token = "0x6006922")]
	[Address(RVA = "0x10723D0", Offset = "0x10711D0", Length = "0x321")]
	protected void Awake()
	{
	}

	[Token(Token = "0x6006923")]
	[Address(RVA = "0x1072700", Offset = "0x1071500", Length = "0x1C2")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6006924")]
	[Address(RVA = "0x10728D0", Offset = "0x10716D0", Length = "0xCE")]
	public bool CanUpdateGraph()
	{
		return false;
	}

	[Token(Token = "0x6006925")]
	[Address(RVA = "0x10729A0", Offset = "0x10717A0", Length = "0x17A")]
	public void RegisterForUpdate(Action update, Action<float> setAccumulatedDeltaTime)
	{
	}

	[Token(Token = "0x6006926")]
	[Address(RVA = "0x1072B20", Offset = "0x1071920", Length = "0x178")]
	public void UnRegisterForUpdate(Action update, Action<float> setAccumulatedDeltaTime)
	{
	}

	[Token(Token = "0x6006927")]
	[Address(RVA = "0x1072CA0", Offset = "0x1071AA0", Length = "0xEF")]
	public void UpdateAll()
	{
	}

	[Token(Token = "0x6006928")]
	[Address(RVA = "0x1072D90", Offset = "0x1071B90", Length = "0x2A4")]
	protected void Update()
	{
	}

	[Token(Token = "0x6006929")]
	[Address(RVA = "0x1073040", Offset = "0x1071E40", Length = "0x34")]
	protected void LateUpdate()
	{
	}

	[Token(Token = "0x600692A")]
	[Address(RVA = "0x1073080", Offset = "0x1071E80", Length = "0x34")]
	protected void FixedUpdate()
	{
	}

	[Token(Token = "0x600692B")]
	[Address(RVA = "0x10730C0", Offset = "0x1071EC0", Length = "0xE3")]
	public MonoManager()
	{
	}
}
