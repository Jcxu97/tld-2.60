using Cpp2ILInjected;
using TLD.UI.Generics;
using UnityEngine;

[Token(Token = "0x200029F")]
public class FlyMode : MonoBehaviour
{
	[SerializeField]
	[Token(Token = "0x4001788")]
	[FieldOffset(Offset = "0x20")]
	private PanelReference<Panel_Debug> m_Debug;

	[SerializeField]
	[Token(Token = "0x4001789")]
	[FieldOffset(Offset = "0x28")]
	private PanelReference<Panel_PauseMenu> m_PauseMenu;

	[Token(Token = "0x400178A")]
	[FieldOffset(Offset = "0x30")]
	public float m_MoveSpeedSlow;

	[Token(Token = "0x400178B")]
	[FieldOffset(Offset = "0x34")]
	public float m_MoveSpeedNormal;

	[Token(Token = "0x400178C")]
	[FieldOffset(Offset = "0x38")]
	public float m_MoveSpeedFast;

	[Token(Token = "0x400178D")]
	[FieldOffset(Offset = "0x3C")]
	public float m_RotationSpeedSlow;

	[Token(Token = "0x400178E")]
	[FieldOffset(Offset = "0x40")]
	public float m_RotationSpeedFast;

	[Token(Token = "0x400178F")]
	public static Vector3 m_RestoreCameraPos;

	[Token(Token = "0x4001790")]
	public static Quaternion m_RestoreCameraOrient;

	[Token(Token = "0x4001791")]
	public static float m_SetTimeOfDay;

	[Token(Token = "0x4001792")]
	private static Camera m_Camera;

	[Token(Token = "0x4001793")]
	private static bool m_IgnoreDownUntilDownIsUp;

	[Token(Token = "0x4001794")]
	private static vp_FPSCamera s_InputContext;

	[Token(Token = "0x4001795")]
	[FieldOffset(Offset = "0x44")]
	private readonly float TRIGGER_DEADZONE;

	[Token(Token = "0x600165F")]
	[Address(RVA = "0x6B75F0", Offset = "0x6B63F0", Length = "0x16B")]
	public void Start()
	{
	}

	[Token(Token = "0x6001660")]
	[Address(RVA = "0x6B7760", Offset = "0x6B6560", Length = "0x760")]
	public void LateUpdate()
	{
	}

	[Token(Token = "0x6001661")]
	[Address(RVA = "0x6B7ED0", Offset = "0x6B6CD0", Length = "0x22A")]
	private void Update()
	{
	}

	[Token(Token = "0x6001662")]
	[Address(RVA = "0x6B8100", Offset = "0x6B6F00", Length = "0x12D")]
	public float GetRotationModifier()
	{
		return 0f;
	}

	[Token(Token = "0x6001663")]
	[Address(RVA = "0x6B8230", Offset = "0x6B7030", Length = "0x307")]
	public static void Enter()
	{
	}

	[Token(Token = "0x6001664")]
	[Address(RVA = "0x6B8540", Offset = "0x6B7340", Length = "0x27C")]
	public static void Exit()
	{
	}

	[Token(Token = "0x6001665")]
	[Address(RVA = "0x6B87C0", Offset = "0x6B75C0", Length = "0x34D")]
	public static void TeleportPlayerAndExit()
	{
	}

	[Token(Token = "0x6001666")]
	[Address(RVA = "0x6B8B10", Offset = "0x6B7910", Length = "0x205")]
	public static void Warp(Vector3 pos, Quaternion rot, float setTOD = -1f)
	{
	}

	[Token(Token = "0x6001667")]
	[Address(RVA = "0x6B8D20", Offset = "0x6B7B20", Length = "0x17A")]
	public static void Warp(Transform transform, float setTOD = -1f)
	{
	}

	[Token(Token = "0x6001668")]
	[Address(RVA = "0x6B8EA0", Offset = "0x6B7CA0", Length = "0xC3")]
	private static void SetBoxSectors(bool activeSectors)
	{
	}

	[Token(Token = "0x6001669")]
	[Address(RVA = "0x6B8F70", Offset = "0x6B7D70", Length = "0x4A")]
	public FlyMode()
	{
	}
}
