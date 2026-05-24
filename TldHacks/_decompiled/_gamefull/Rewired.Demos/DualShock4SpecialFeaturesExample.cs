using System.Collections.Generic;
using Cpp2ILInjected;
using Rewired.ControllerExtensions;
using UnityEngine;

namespace Rewired.Demos;

[AddComponentMenu(null)]
[Token(Token = "0x2000C48")]
public class DualShock4SpecialFeaturesExample : MonoBehaviour
{
	[Token(Token = "0x2000C49")]
	private class Touch
	{
		[Token(Token = "0x4007CE3")]
		[FieldOffset(Offset = "0x10")]
		public GameObject go;

		[Token(Token = "0x4007CE4")]
		[FieldOffset(Offset = "0x18")]
		public int touchId;

		[Token(Token = "0x6006395")]
		[Address(RVA = "0xFD1C60", Offset = "0xFD0A60", Length = "0x8")]
		public Touch()
		{
		}
	}

	[Token(Token = "0x4007CDA")]
	private const int maxTouches = 2;

	[Token(Token = "0x4007CDB")]
	[FieldOffset(Offset = "0x20")]
	public int playerId;

	[Token(Token = "0x4007CDC")]
	[FieldOffset(Offset = "0x28")]
	public Transform touchpadTransform;

	[Token(Token = "0x4007CDD")]
	[FieldOffset(Offset = "0x30")]
	public GameObject lightObject;

	[Token(Token = "0x4007CDE")]
	[FieldOffset(Offset = "0x38")]
	public Transform accelerometerTransform;

	[Token(Token = "0x4007CDF")]
	[FieldOffset(Offset = "0x40")]
	private List<Touch> touches;

	[Token(Token = "0x4007CE0")]
	[FieldOffset(Offset = "0x48")]
	private Queue<Touch> unusedTouches;

	[Token(Token = "0x4007CE1")]
	[FieldOffset(Offset = "0x50")]
	private bool isFlashing;

	[Token(Token = "0x4007CE2")]
	[FieldOffset(Offset = "0x58")]
	private GUIStyle textStyle;

	[Token(Token = "0x170006AB")]
	private Player player
	{
		[Token(Token = "0x6006389")]
		[Address(RVA = "0xFCF7E0", Offset = "0xFCE5E0", Length = "0x63")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600638A")]
	[Address(RVA = "0xFCF850", Offset = "0xFCE650", Length = "0x7")]
	private void Awake()
	{
	}

	[Token(Token = "0x600638B")]
	[Address(RVA = "0xFCF860", Offset = "0xFCE660", Length = "0x69F")]
	private void Update()
	{
	}

	[Token(Token = "0x600638C")]
	[Address(RVA = "0xFCFF00", Offset = "0xFCED00", Length = "0x698")]
	private void OnGUI()
	{
	}

	[Token(Token = "0x600638D")]
	[Address(RVA = "0xFD05A0", Offset = "0xFCF3A0", Length = "0xB1")]
	private void ResetOrientation()
	{
	}

	[Token(Token = "0x600638E")]
	[Address(RVA = "0xFD0660", Offset = "0xFCF460", Length = "0x2D0")]
	private void SetRandomLightColor()
	{
	}

	[Token(Token = "0x600638F")]
	[Address(RVA = "0xFD0940", Offset = "0xFCF740", Length = "0x1B5")]
	private void StartLightFlash()
	{
	}

	[Token(Token = "0x6006390")]
	[Address(RVA = "0xFD0B00", Offset = "0xFCF900", Length = "0x182")]
	private void StopLightFlash()
	{
	}

	[Token(Token = "0x6006391")]
	[Address(RVA = "0xFD0C90", Offset = "0xFCFA90", Length = "0x254")]
	private IDualShock4Extension GetFirstDS4(Player player)
	{
		return null;
	}

	[Token(Token = "0x6006392")]
	[Address(RVA = "0xFD0EF0", Offset = "0xFCFCF0", Length = "0x72B")]
	private void InitializeTouchObjects()
	{
	}

	[Token(Token = "0x6006393")]
	[Address(RVA = "0xFD1620", Offset = "0xFD0420", Length = "0x631")]
	private void HandleTouchpad(IDualShock4Extension ds4)
	{
	}

	[Token(Token = "0x6006394")]
	[Address(RVA = "0x4AF5E0", Offset = "0x4AE3E0", Length = "0x43")]
	public DualShock4SpecialFeaturesExample()
	{
	}
}
