using Cpp2ILInjected;
using TLD.UI.Generics;
using UnityEngine;

[Token(Token = "0x20002A4")]
public class LockCameraMode : MonoBehaviour
{
	[SerializeField]
	[Token(Token = "0x40017A6")]
	[FieldOffset(Offset = "0x20")]
	private PanelReference<Panel_Debug> m_Debug;

	[SerializeField]
	[Token(Token = "0x40017A7")]
	[FieldOffset(Offset = "0x28")]
	private PanelReference<Panel_PauseMenu> m_PauseMenu;

	[Token(Token = "0x40017A8")]
	public static float s_StartingDistance;

	[Token(Token = "0x40017A9")]
	public static float s_StartingHeight;

	[Token(Token = "0x40017AA")]
	public static float s_HeightInputSpeed;

	[Token(Token = "0x40017AB")]
	private static vp_FPSCamera s_InputContext;

	[Token(Token = "0x40017AC")]
	private static Camera s_Camera;

	[Token(Token = "0x40017AD")]
	private static Quaternion s_RestoreCameraOrient;

	[Token(Token = "0x40017AE")]
	private static GameObject s_Target;

	[Token(Token = "0x40017AF")]
	private static float s_CurrentAngle;

	[Token(Token = "0x40017B0")]
	private static float s_CurrentHeight;

	[Token(Token = "0x600168A")]
	[Address(RVA = "0x6BAC20", Offset = "0x6B9A20", Length = "0x174")]
	private void Start()
	{
	}

	[Token(Token = "0x600168B")]
	[Address(RVA = "0x6BADA0", Offset = "0x6B9BA0", Length = "0x838")]
	public static void Enter(GameObject target)
	{
	}

	[Token(Token = "0x600168C")]
	[Address(RVA = "0x6BB5E0", Offset = "0x6BA3E0", Length = "0x260")]
	public static void Exit()
	{
	}

	[Token(Token = "0x600168D")]
	[Address(RVA = "0x6BB850", Offset = "0x6BA650", Length = "0x192")]
	private void Update()
	{
	}

	[Token(Token = "0x600168E")]
	[Address(RVA = "0x6BB9F0", Offset = "0x6BA7F0", Length = "0x5D7")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x600168F")]
	[Address(RVA = "0x6BBFD0", Offset = "0x6BADD0", Length = "0xC3")]
	private static void SetBoxSectors(bool activeSectors)
	{
	}

	[Token(Token = "0x6001690")]
	[Address(RVA = "0x4AF5E0", Offset = "0x4AE3E0", Length = "0x43")]
	public LockCameraMode()
	{
	}
}
