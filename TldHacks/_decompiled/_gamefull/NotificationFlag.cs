using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x20005FE")]
public class NotificationFlag : MonoBehaviour
{
	[Token(Token = "0x4003745")]
	[FieldOffset(Offset = "0x20")]
	public GameObject m_MiniTopNavBarNotifications;

	[Token(Token = "0x4003746")]
	private static readonly int IsDestroyed;

	[Token(Token = "0x6002E57")]
	[Address(RVA = "0x964890", Offset = "0x963690", Length = "0x62")]
	public GameObject GetNotificationFlags(PanelType panelType)
	{
		return null;
	}

	[Token(Token = "0x6002E58")]
	[Address(RVA = "0x964900", Offset = "0x963700", Length = "0x1CC")]
	public void ShowNotificationIcon(GameObject notificationPrefab, bool enable)
	{
	}

	[Token(Token = "0x6002E59")]
	[Address(RVA = "0x4AF5E0", Offset = "0x4AE3E0", Length = "0x43")]
	public NotificationFlag()
	{
	}
}
