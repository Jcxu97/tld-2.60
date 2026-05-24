using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;

namespace Rewired.Demos.GamepadTemplateUI;

[Token(Token = "0x2000C61")]
public class GamepadTemplateUI : MonoBehaviour
{
	[Token(Token = "0x2000C62")]
	private class Stick
	{
		[Token(Token = "0x4007D88")]
		[FieldOffset(Offset = "0x10")]
		private RectTransform _transform;

		[Token(Token = "0x4007D89")]
		[FieldOffset(Offset = "0x18")]
		private Vector2 _origPosition;

		[Token(Token = "0x4007D8A")]
		[FieldOffset(Offset = "0x20")]
		private int _xAxisElementId;

		[Token(Token = "0x4007D8B")]
		[FieldOffset(Offset = "0x24")]
		private int _yAxisElementId;

		[Token(Token = "0x170006B9")]
		public Vector2 position
		{
			[Token(Token = "0x6006428")]
			[Address(RVA = "0xFE2450", Offset = "0xFE1250", Length = "0x151")]
			get
			{
				return default(Vector2);
			}
			[Token(Token = "0x6006429")]
			[Address(RVA = "0xFE25B0", Offset = "0xFE13B0", Length = "0x10C")]
			set
			{
			}
		}

		[Token(Token = "0x600642A")]
		[Address(RVA = "0xFE26C0", Offset = "0xFE14C0", Length = "0x16C")]
		public Stick(RectTransform transform, int xAxisElementId, int yAxisElementId)
		{
		}

		[Token(Token = "0x600642B")]
		[Address(RVA = "0xFE2830", Offset = "0xFE1630", Length = "0xFB")]
		public void Reset()
		{
		}

		[Token(Token = "0x600642C")]
		[Address(RVA = "0xFE2930", Offset = "0xFE1730", Length = "0x105")]
		public bool ContainsElement(int elementId)
		{
			return false;
		}

		[Token(Token = "0x600642D")]
		[Address(RVA = "0xFE2A40", Offset = "0xFE1840", Length = "0x322")]
		public void SetAxisPosition(int elementId, float value)
		{
		}
	}

	[Token(Token = "0x2000C63")]
	private class UIElement
	{
		[Token(Token = "0x4007D8C")]
		[FieldOffset(Offset = "0x10")]
		public int id;

		[Token(Token = "0x4007D8D")]
		[FieldOffset(Offset = "0x18")]
		public ControllerUIElement element;

		[Token(Token = "0x600642E")]
		[Address(RVA = "0xFE2D70", Offset = "0xFE1B70", Length = "0x52")]
		public UIElement(int id, ControllerUIElement element)
		{
		}
	}

	[Token(Token = "0x4007D69")]
	private const float stickRadius = 20f;

	[Token(Token = "0x4007D6A")]
	[FieldOffset(Offset = "0x20")]
	public int playerId;

	[SerializeField]
	[Token(Token = "0x4007D6B")]
	[FieldOffset(Offset = "0x28")]
	private RectTransform leftStick;

	[SerializeField]
	[Token(Token = "0x4007D6C")]
	[FieldOffset(Offset = "0x30")]
	private RectTransform rightStick;

	[SerializeField]
	[Token(Token = "0x4007D6D")]
	[FieldOffset(Offset = "0x38")]
	private ControllerUIElement leftStickX;

	[SerializeField]
	[Token(Token = "0x4007D6E")]
	[FieldOffset(Offset = "0x40")]
	private ControllerUIElement leftStickY;

	[SerializeField]
	[Token(Token = "0x4007D6F")]
	[FieldOffset(Offset = "0x48")]
	private ControllerUIElement leftStickButton;

	[SerializeField]
	[Token(Token = "0x4007D70")]
	[FieldOffset(Offset = "0x50")]
	private ControllerUIElement rightStickX;

	[SerializeField]
	[Token(Token = "0x4007D71")]
	[FieldOffset(Offset = "0x58")]
	private ControllerUIElement rightStickY;

	[SerializeField]
	[Token(Token = "0x4007D72")]
	[FieldOffset(Offset = "0x60")]
	private ControllerUIElement rightStickButton;

	[SerializeField]
	[Token(Token = "0x4007D73")]
	[FieldOffset(Offset = "0x68")]
	private ControllerUIElement actionBottomRow1;

	[SerializeField]
	[Token(Token = "0x4007D74")]
	[FieldOffset(Offset = "0x70")]
	private ControllerUIElement actionBottomRow2;

	[SerializeField]
	[Token(Token = "0x4007D75")]
	[FieldOffset(Offset = "0x78")]
	private ControllerUIElement actionBottomRow3;

	[SerializeField]
	[Token(Token = "0x4007D76")]
	[FieldOffset(Offset = "0x80")]
	private ControllerUIElement actionTopRow1;

	[SerializeField]
	[Token(Token = "0x4007D77")]
	[FieldOffset(Offset = "0x88")]
	private ControllerUIElement actionTopRow2;

	[SerializeField]
	[Token(Token = "0x4007D78")]
	[FieldOffset(Offset = "0x90")]
	private ControllerUIElement actionTopRow3;

	[SerializeField]
	[Token(Token = "0x4007D79")]
	[FieldOffset(Offset = "0x98")]
	private ControllerUIElement leftShoulder;

	[SerializeField]
	[Token(Token = "0x4007D7A")]
	[FieldOffset(Offset = "0xA0")]
	private ControllerUIElement leftTrigger;

	[SerializeField]
	[Token(Token = "0x4007D7B")]
	[FieldOffset(Offset = "0xA8")]
	private ControllerUIElement rightShoulder;

	[SerializeField]
	[Token(Token = "0x4007D7C")]
	[FieldOffset(Offset = "0xB0")]
	private ControllerUIElement rightTrigger;

	[SerializeField]
	[Token(Token = "0x4007D7D")]
	[FieldOffset(Offset = "0xB8")]
	private ControllerUIElement center1;

	[SerializeField]
	[Token(Token = "0x4007D7E")]
	[FieldOffset(Offset = "0xC0")]
	private ControllerUIElement center2;

	[SerializeField]
	[Token(Token = "0x4007D7F")]
	[FieldOffset(Offset = "0xC8")]
	private ControllerUIElement center3;

	[SerializeField]
	[Token(Token = "0x4007D80")]
	[FieldOffset(Offset = "0xD0")]
	private ControllerUIElement dPadUp;

	[SerializeField]
	[Token(Token = "0x4007D81")]
	[FieldOffset(Offset = "0xD8")]
	private ControllerUIElement dPadRight;

	[SerializeField]
	[Token(Token = "0x4007D82")]
	[FieldOffset(Offset = "0xE0")]
	private ControllerUIElement dPadDown;

	[SerializeField]
	[Token(Token = "0x4007D83")]
	[FieldOffset(Offset = "0xE8")]
	private ControllerUIElement dPadLeft;

	[Token(Token = "0x4007D84")]
	[FieldOffset(Offset = "0xF0")]
	private UIElement[] _uiElementsArray;

	[Token(Token = "0x4007D85")]
	[FieldOffset(Offset = "0xF8")]
	private Dictionary<int, ControllerUIElement> _uiElements;

	[Token(Token = "0x4007D86")]
	[FieldOffset(Offset = "0x100")]
	private IList<ControllerTemplateElementTarget> _tempTargetList;

	[Token(Token = "0x4007D87")]
	[FieldOffset(Offset = "0x108")]
	private Stick[] _sticks;

	[Token(Token = "0x170006B8")]
	private Player player
	{
		[Token(Token = "0x600641A")]
		[Address(RVA = "0xFDF780", Offset = "0xFDE580", Length = "0x63")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600641B")]
	[Address(RVA = "0xFDF7F0", Offset = "0xFDE5F0", Length = "0x12D3")]
	private void Awake()
	{
	}

	[Token(Token = "0x600641C")]
	[Address(RVA = "0xFE0AD0", Offset = "0xFDF8D0", Length = "0x9E")]
	private void Start()
	{
	}

	[Token(Token = "0x600641D")]
	[Address(RVA = "0xFE0B70", Offset = "0xFDF970", Length = "0xDC")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x600641E")]
	[Address(RVA = "0xFE0C50", Offset = "0xFDFA50", Length = "0x9E")]
	private void Update()
	{
	}

	[Token(Token = "0x600641F")]
	[Address(RVA = "0xFE0CF0", Offset = "0xFDFAF0", Length = "0x47B")]
	private void DrawActiveElements()
	{
	}

	[Token(Token = "0x6006420")]
	[Address(RVA = "0xFE1170", Offset = "0xFDFF70", Length = "0x5C7")]
	private void ActivateElements(Player player, int actionId)
	{
	}

	[Token(Token = "0x6006421")]
	[Address(RVA = "0xFE1740", Offset = "0xFE0540", Length = "0x2BB")]
	private void DrawLabels()
	{
	}

	[Token(Token = "0x6006422")]
	[Address(RVA = "0xFE1A00", Offset = "0xFE0800", Length = "0x2B6")]
	private void DrawLabels(Player player, InputAction action)
	{
	}

	[Token(Token = "0x6006423")]
	[Address(RVA = "0xFE1CC0", Offset = "0xFE0AC0", Length = "0x3BB")]
	private void DrawLabel(ControllerUIElement uiElement, InputAction action, ControllerMap controllerMap, IControllerTemplate template, IControllerTemplateElement element)
	{
	}

	[Token(Token = "0x6006424")]
	[Address(RVA = "0xFE2080", Offset = "0xFE0E80", Length = "0x186")]
	private Stick GetStick(int elementId)
	{
		return null;
	}

	[Token(Token = "0x6006425")]
	[Address(RVA = "0xFE2210", Offset = "0xFE1010", Length = "0x7")]
	private void OnControllerConnected(ControllerStatusChangedEventArgs args)
	{
	}

	[Token(Token = "0x6006426")]
	[Address(RVA = "0xFE2210", Offset = "0xFE1010", Length = "0x7")]
	private void OnControllerDisconnected(ControllerStatusChangedEventArgs args)
	{
	}

	[Token(Token = "0x6006427")]
	[Address(RVA = "0xFE2220", Offset = "0xFE1020", Length = "0x224")]
	public GamepadTemplateUI()
	{
	}
}
