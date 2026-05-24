using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;

[ExecuteInEditMode]
[AddComponentMenu("NGUI/UI/NGUI Event System (UICamera)")]
[RequireComponent(typeof(Camera))]
[Token(Token = "0x20000F7")]
public class UICamera : MonoBehaviour
{
	[Token(Token = "0x20000F8")]
	public enum ControlScheme
	{
		[Token(Token = "0x40007FE")]
		Mouse,
		[Token(Token = "0x40007FF")]
		Touch,
		[Token(Token = "0x4000800")]
		Controller
	}

	[Token(Token = "0x20000F9")]
	public enum ClickNotification
	{
		[Token(Token = "0x4000802")]
		None,
		[Token(Token = "0x4000803")]
		Always,
		[Token(Token = "0x4000804")]
		BasedOnDelta
	}

	[Token(Token = "0x20000FA")]
	public class MouseOrTouch
	{
		[Token(Token = "0x4000805")]
		[FieldOffset(Offset = "0x10")]
		public Vector2 pos;

		[Token(Token = "0x4000806")]
		[FieldOffset(Offset = "0x18")]
		public Vector2 lastPos;

		[Token(Token = "0x4000807")]
		[FieldOffset(Offset = "0x20")]
		public Vector2 delta;

		[Token(Token = "0x4000808")]
		[FieldOffset(Offset = "0x28")]
		public Vector2 totalDelta;

		[Token(Token = "0x4000809")]
		[FieldOffset(Offset = "0x30")]
		public Camera pressedCam;

		[Token(Token = "0x400080A")]
		[FieldOffset(Offset = "0x38")]
		public GameObject last;

		[Token(Token = "0x400080B")]
		[FieldOffset(Offset = "0x40")]
		private GameObject mCurrent;

		[Token(Token = "0x400080C")]
		[FieldOffset(Offset = "0x48")]
		private GameObject mPressed;

		[Token(Token = "0x400080D")]
		[FieldOffset(Offset = "0x50")]
		public GameObject dragged;

		[Token(Token = "0x400080E")]
		[FieldOffset(Offset = "0x58")]
		public float pressTime;

		[Token(Token = "0x400080F")]
		[FieldOffset(Offset = "0x5C")]
		public float clickTime;

		[Token(Token = "0x4000810")]
		[FieldOffset(Offset = "0x60")]
		public ClickNotification clickNotification;

		[Token(Token = "0x4000811")]
		[FieldOffset(Offset = "0x64")]
		public bool touchBegan;

		[Token(Token = "0x4000812")]
		[FieldOffset(Offset = "0x65")]
		public bool pressStarted;

		[Token(Token = "0x4000813")]
		[FieldOffset(Offset = "0x66")]
		public bool dragStarted;

		[Token(Token = "0x17000112")]
		public GameObject current
		{
			[Token(Token = "0x600090B")]
			[Address(RVA = "0x4A7D60", Offset = "0x4A6B60", Length = "0x5")]
			get
			{
				return null;
			}
			[Token(Token = "0x600090A")]
			[Address(RVA = "0x4D0B00", Offset = "0x4CF900", Length = "0x52")]
			set
			{
			}
		}

		[Token(Token = "0x17000113")]
		public GameObject pressed
		{
			[Token(Token = "0x600090D")]
			[Address(RVA = "0x4B2FE0", Offset = "0x4B1DE0", Length = "0x5")]
			get
			{
				return null;
			}
			[Token(Token = "0x600090C")]
			[Address(RVA = "0x4D0B60", Offset = "0x4CF960", Length = "0x52")]
			set
			{
			}
		}

		[Token(Token = "0x17000114")]
		public float deltaTime
		{
			[Token(Token = "0x600090E")]
			[Address(RVA = "0x1273F60", Offset = "0x1272D60", Length = "0x50")]
			get
			{
				return 0f;
			}
		}

		[Token(Token = "0x17000115")]
		public bool isOverUI
		{
			[Token(Token = "0x600090F")]
			[Address(RVA = "0x1273FC0", Offset = "0x1272DC0", Length = "0x2E9")]
			get
			{
				return false;
			}
		}

		[Token(Token = "0x6000910")]
		[Address(RVA = "0x12742B0", Offset = "0x12730B0", Length = "0xC")]
		public MouseOrTouch()
		{
		}
	}

	[Token(Token = "0x20000FB")]
	public enum EventType
	{
		[Token(Token = "0x4000815")]
		World_3D,
		[Token(Token = "0x4000816")]
		UI_3D,
		[Token(Token = "0x4000817")]
		World_2D,
		[Token(Token = "0x4000818")]
		UI_2D
	}

	[Token(Token = "0x20000FC")]
	public delegate bool GetKeyStateFunc(KeyCode key);

	[Token(Token = "0x20000FD")]
	public delegate float GetAxisFunc(string name);

	[Token(Token = "0x20000FE")]
	public delegate void OnScreenResize();

	[Token(Token = "0x20000FF")]
	public delegate void OnCustomInput();

	[Token(Token = "0x2000100")]
	public delegate void MoveDelegate(Vector2 delta);

	[Token(Token = "0x2000101")]
	public delegate void VoidDelegate(GameObject go);

	[Token(Token = "0x2000102")]
	public delegate void BoolDelegate(GameObject go, bool state);

	[Token(Token = "0x2000103")]
	public delegate void FloatDelegate(GameObject go, float delta);

	[Token(Token = "0x2000104")]
	public delegate void VectorDelegate(GameObject go, Vector2 delta);

	[Token(Token = "0x2000105")]
	public delegate void ObjectDelegate(GameObject go, GameObject obj);

	[Token(Token = "0x2000106")]
	public delegate void KeyCodeDelegate(GameObject go, KeyCode key);

	[Token(Token = "0x2000107")]
	private struct DepthEntry
	{
		[Token(Token = "0x4000819")]
		[FieldOffset(Offset = "0x0")]
		public int depth;

		[Token(Token = "0x400081A")]
		[FieldOffset(Offset = "0x4")]
		public RaycastHit hit;

		[Token(Token = "0x400081B")]
		[FieldOffset(Offset = "0x30")]
		public Vector3 point;

		[Token(Token = "0x400081C")]
		[FieldOffset(Offset = "0x40")]
		public GameObject go;
	}

	[Token(Token = "0x2000108")]
	public class Touch
	{
		[Token(Token = "0x400081D")]
		[FieldOffset(Offset = "0x10")]
		public int fingerId;

		[Token(Token = "0x400081E")]
		[FieldOffset(Offset = "0x14")]
		public TouchPhase phase;

		[Token(Token = "0x400081F")]
		[FieldOffset(Offset = "0x18")]
		public Vector2 position;

		[Token(Token = "0x4000820")]
		[FieldOffset(Offset = "0x20")]
		public int tapCount;

		[Token(Token = "0x600093D")]
		[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
		public Touch()
		{
		}
	}

	[Token(Token = "0x2000109")]
	public delegate int GetTouchCountCallback();

	[Token(Token = "0x200010A")]
	public delegate Touch GetTouchCallback(int index);

	[Token(Token = "0x40007A6")]
	public static bool s_LockControlScheme;

	[Token(Token = "0x40007A7")]
	public static BetterList<UICamera> list;

	[Token(Token = "0x40007A8")]
	public static GetKeyStateFunc GetKeyDown;

	[Token(Token = "0x40007A9")]
	public static GetKeyStateFunc GetKeyUp;

	[Token(Token = "0x40007AA")]
	public static GetKeyStateFunc GetKey;

	[Token(Token = "0x40007AB")]
	public static GetAxisFunc GetAxis;

	[Token(Token = "0x40007AC")]
	public static OnScreenResize onScreenResize;

	[Token(Token = "0x40007AD")]
	[FieldOffset(Offset = "0x20")]
	public EventType eventType;

	[Token(Token = "0x40007AE")]
	[FieldOffset(Offset = "0x24")]
	public bool eventsGoToColliders;

	[Token(Token = "0x40007AF")]
	[FieldOffset(Offset = "0x28")]
	public LayerMask eventReceiverMask;

	[Token(Token = "0x40007B0")]
	[FieldOffset(Offset = "0x2C")]
	public bool debug;

	[Token(Token = "0x40007B1")]
	[FieldOffset(Offset = "0x2D")]
	public bool useMouse;

	[Token(Token = "0x40007B2")]
	[FieldOffset(Offset = "0x2E")]
	public bool useTouch;

	[Token(Token = "0x40007B3")]
	[FieldOffset(Offset = "0x2F")]
	public bool allowMultiTouch;

	[Token(Token = "0x40007B4")]
	[FieldOffset(Offset = "0x30")]
	public bool useKeyboard;

	[Token(Token = "0x40007B5")]
	[FieldOffset(Offset = "0x31")]
	public bool useController;

	[Token(Token = "0x40007B6")]
	[FieldOffset(Offset = "0x32")]
	public bool stickyTooltip;

	[Token(Token = "0x40007B7")]
	[FieldOffset(Offset = "0x34")]
	public float tooltipDelay;

	[Token(Token = "0x40007B8")]
	[FieldOffset(Offset = "0x38")]
	public bool longPressTooltip;

	[Token(Token = "0x40007B9")]
	[FieldOffset(Offset = "0x3C")]
	public float mouseDragThreshold;

	[Token(Token = "0x40007BA")]
	[FieldOffset(Offset = "0x40")]
	public float mouseClickThreshold;

	[Token(Token = "0x40007BB")]
	[FieldOffset(Offset = "0x44")]
	public float touchDragThreshold;

	[Token(Token = "0x40007BC")]
	[FieldOffset(Offset = "0x48")]
	public float touchClickThreshold;

	[Token(Token = "0x40007BD")]
	[FieldOffset(Offset = "0x4C")]
	public float rangeDistance;

	[Token(Token = "0x40007BE")]
	[FieldOffset(Offset = "0x50")]
	public string scrollAxisName;

	[Token(Token = "0x40007BF")]
	[FieldOffset(Offset = "0x58")]
	public string verticalAxisName;

	[Token(Token = "0x40007C0")]
	[FieldOffset(Offset = "0x60")]
	public string secondaryVerticalAxisName;

	[Token(Token = "0x40007C1")]
	[FieldOffset(Offset = "0x68")]
	public string horizontalAxisName;

	[Token(Token = "0x40007C2")]
	[FieldOffset(Offset = "0x70")]
	public string secondaryHorizontalAxisName;

	[Token(Token = "0x40007C3")]
	[FieldOffset(Offset = "0x78")]
	public bool commandClick;

	[Token(Token = "0x40007C4")]
	[FieldOffset(Offset = "0x7C")]
	public KeyCode submitKey0;

	[Token(Token = "0x40007C5")]
	[FieldOffset(Offset = "0x80")]
	public KeyCode submitKey1;

	[Token(Token = "0x40007C6")]
	[FieldOffset(Offset = "0x84")]
	public KeyCode cancelKey0;

	[Token(Token = "0x40007C7")]
	[FieldOffset(Offset = "0x88")]
	public KeyCode cancelKey1;

	[Token(Token = "0x40007C8")]
	[FieldOffset(Offset = "0x90")]
	public string submitKey;

	[Token(Token = "0x40007C9")]
	[FieldOffset(Offset = "0x98")]
	public string cancelKey;

	[Token(Token = "0x40007CA")]
	public static OnCustomInput onCustomInput;

	[Token(Token = "0x40007CB")]
	public static bool showTooltips;

	[Token(Token = "0x40007CC")]
	public static Vector2 lastTouchPosition;

	[Token(Token = "0x40007CD")]
	public static Vector3 lastWorldPosition;

	[Token(Token = "0x40007CE")]
	public static RaycastHit lastHit;

	[Token(Token = "0x40007CF")]
	public static UICamera current;

	[Token(Token = "0x40007D0")]
	public static Camera currentCamera;

	[Token(Token = "0x40007D1")]
	private static ControlScheme mCurrentScheme;

	[Token(Token = "0x40007D2")]
	public static int currentTouchID;

	[Token(Token = "0x40007D3")]
	public static KeyCode currentKey;

	[Token(Token = "0x40007D4")]
	public static MouseOrTouch currentTouch;

	[Token(Token = "0x40007D5")]
	public static bool inputHasFocus;

	[Token(Token = "0x40007D6")]
	private static GameObject mGenericHandler;

	[Token(Token = "0x40007D7")]
	public static GameObject fallThrough;

	[Token(Token = "0x40007D8")]
	public static VoidDelegate onClick;

	[Token(Token = "0x40007D9")]
	public static VoidDelegate onDoubleClick;

	[Token(Token = "0x40007DA")]
	public static BoolDelegate onHover;

	[Token(Token = "0x40007DB")]
	public static BoolDelegate onPress;

	[Token(Token = "0x40007DC")]
	public static BoolDelegate onSelect;

	[Token(Token = "0x40007DD")]
	public static FloatDelegate onScroll;

	[Token(Token = "0x40007DE")]
	public static VectorDelegate onDrag;

	[Token(Token = "0x40007DF")]
	public static VoidDelegate onDragStart;

	[Token(Token = "0x40007E0")]
	public static ObjectDelegate onDragOver;

	[Token(Token = "0x40007E1")]
	public static ObjectDelegate onDragOut;

	[Token(Token = "0x40007E2")]
	public static VoidDelegate onDragEnd;

	[Token(Token = "0x40007E3")]
	public static ObjectDelegate onDrop;

	[Token(Token = "0x40007E4")]
	public static KeyCodeDelegate onKey;

	[Token(Token = "0x40007E5")]
	public static BoolDelegate onTooltip;

	[Token(Token = "0x40007E6")]
	public static MoveDelegate onMouseMove;

	[Token(Token = "0x40007E7")]
	private static GameObject mCurrentSelection;

	[Token(Token = "0x40007E8")]
	private static MouseOrTouch[] mMouse;

	[Token(Token = "0x40007E9")]
	private static GameObject mHover;

	[Token(Token = "0x40007EA")]
	public static MouseOrTouch controller;

	[Token(Token = "0x40007EB")]
	public static List<MouseOrTouch> activeTouches;

	[Token(Token = "0x40007EC")]
	private static List<int> mTouchIDs;

	[Token(Token = "0x40007ED")]
	private static int mWidth;

	[Token(Token = "0x40007EE")]
	private static int mHeight;

	[Token(Token = "0x40007EF")]
	[FieldOffset(Offset = "0xA0")]
	private GameObject mTooltip;

	[Token(Token = "0x40007F0")]
	[FieldOffset(Offset = "0xA8")]
	private Camera mCam;

	[Token(Token = "0x40007F1")]
	[FieldOffset(Offset = "0xB0")]
	private float mTooltipTime;

	[Token(Token = "0x40007F2")]
	[FieldOffset(Offset = "0xB4")]
	private float mNextRaycast;

	[Token(Token = "0x40007F3")]
	public static bool isDragging;

	[Token(Token = "0x40007F4")]
	public static GameObject lastHoveredObject;

	[Token(Token = "0x40007F5")]
	private static GameObject _hoveredObject;

	[Token(Token = "0x40007F6")]
	private static DepthEntry mHit;

	[Token(Token = "0x40007F7")]
	private static BetterList<DepthEntry> mHits;

	[Token(Token = "0x40007F8")]
	private static Plane m2DPlane;

	[Token(Token = "0x40007F9")]
	private static int mNotifying;

	[Token(Token = "0x40007FA")]
	private static bool mUsingTouchEvents;

	[Token(Token = "0x40007FB")]
	public static GetTouchCountCallback GetInputTouchCount;

	[Token(Token = "0x40007FC")]
	public static GetTouchCallback GetInputTouch;

	[Obsolete("Use new OnDragStart / OnDragOver / OnDragOut / OnDragEnd events instead")]
	[Token(Token = "0x17000105")]
	public bool stickyPress
	{
		[Token(Token = "0x60008D8")]
		[Address(RVA = "0x430B50", Offset = "0x42F950", Length = "0x3")]
		get
		{
			return false;
		}
	}

	[Token(Token = "0x17000106")]
	public static ControlScheme currentScheme
	{
		[Token(Token = "0x60008D9")]
		[Address(RVA = "0x1135900", Offset = "0x1134700", Length = "0x56")]
		get
		{
			return default(ControlScheme);
		}
		[Token(Token = "0x60008DA")]
		[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
		set
		{
		}
	}

	[Token(Token = "0x17000107")]
	public static Ray currentRay
	{
		[Token(Token = "0x60008DB")]
		[Address(RVA = "0x1135960", Offset = "0x1134760", Length = "0x26C")]
		get
		{
			return default(Ray);
		}
	}

	[Obsolete("Use delegates instead such as UICamera.onClick, UICamera.onHover, etc.")]
	[Token(Token = "0x17000108")]
	public static GameObject genericEventHandler
	{
		[Token(Token = "0x60008DC")]
		[Address(RVA = "0x1135BD0", Offset = "0x11349D0", Length = "0x57")]
		get
		{
			return null;
		}
		[Token(Token = "0x60008DD")]
		[Address(RVA = "0x1135C30", Offset = "0x1134A30", Length = "0xB7")]
		set
		{
		}
	}

	[Token(Token = "0x17000109")]
	private bool handlesEvents
	{
		[Token(Token = "0x60008DE")]
		[Address(RVA = "0x1135CF0", Offset = "0x1134AF0", Length = "0x15B")]
		get
		{
			return false;
		}
	}

	[Token(Token = "0x1700010A")]
	public Camera cachedCamera
	{
		[Token(Token = "0x60008DF")]
		[Address(RVA = "0x1135E50", Offset = "0x1134C50", Length = "0x158")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700010B")]
	public static GameObject hoveredObject
	{
		[Token(Token = "0x60008E0")]
		[Address(RVA = "0x1135FB0", Offset = "0x1134DB0", Length = "0x57")]
		get
		{
			return null;
		}
		[Token(Token = "0x60008E1")]
		[Address(RVA = "0x1136010", Offset = "0x1134E10", Length = "0x12F")]
		set
		{
		}
	}

	[Token(Token = "0x1700010C")]
	public static bool isOverUI
	{
		[Token(Token = "0x60008E2")]
		[Address(RVA = "0x1136140", Offset = "0x1134F40", Length = "0x37C")]
		get
		{
			return false;
		}
	}

	[Token(Token = "0x1700010D")]
	public static GameObject selectedObject
	{
		[Token(Token = "0x60008E3")]
		[Address(RVA = "0x11364C0", Offset = "0x11352C0", Length = "0x127")]
		get
		{
			return null;
		}
		[Token(Token = "0x60008E4")]
		[Address(RVA = "0x11365F0", Offset = "0x11353F0", Length = "0xADF")]
		set
		{
		}
	}

	[Obsolete("Use either 'CountInputSources()' or 'activeTouches.Count'")]
	[Token(Token = "0x1700010E")]
	public static int touchCount
	{
		[Token(Token = "0x60008E6")]
		[Address(RVA = "0x1137540", Offset = "0x1136340", Length = "0x45")]
		get
		{
			return 0;
		}
	}

	[Token(Token = "0x1700010F")]
	public static int dragCount
	{
		[Token(Token = "0x60008E8")]
		[Address(RVA = "0x1137970", Offset = "0x1136770", Length = "0x3D1")]
		get
		{
			return 0;
		}
	}

	[Token(Token = "0x17000110")]
	public static Camera mainCamera
	{
		[Token(Token = "0x60008E9")]
		[Address(RVA = "0x1137D50", Offset = "0x1136B50", Length = "0xFB")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000111")]
	public static UICamera eventHandler
	{
		[Token(Token = "0x60008EA")]
		[Address(RVA = "0x1137E50", Offset = "0x1136C50", Length = "0x1E2")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60008E5")]
	[Address(RVA = "0x11370D0", Offset = "0x1135ED0", Length = "0x46A")]
	public static bool IsPressed(GameObject go)
	{
		return false;
	}

	[Token(Token = "0x60008E7")]
	[Address(RVA = "0x1137590", Offset = "0x1136390", Length = "0x3D1")]
	public static int CountInputSources()
	{
		return 0;
	}

	[Token(Token = "0x60008EB")]
	[Address(RVA = "0x1138040", Offset = "0x1136E40", Length = "0x1C1")]
	private static int CompareFunc(UICamera a, UICamera b)
	{
		return 0;
	}

	[Token(Token = "0x60008EC")]
	[Address(RVA = "0x1138210", Offset = "0x1137010", Length = "0x264")]
	private static Rigidbody FindRootRigidbody(Transform trans)
	{
		return null;
	}

	[Token(Token = "0x60008ED")]
	[Address(RVA = "0x1138480", Offset = "0x1137280", Length = "0x264")]
	private static Rigidbody2D FindRootRigidbody2D(Transform trans)
	{
		return null;
	}

	[Token(Token = "0x60008EE")]
	[Address(RVA = "0x11386F0", Offset = "0x11374F0", Length = "0x1B8C")]
	public static bool Raycast(Vector3 inPos)
	{
		return false;
	}

	[Token(Token = "0x60008EF")]
	[Address(RVA = "0x113A280", Offset = "0x1139080", Length = "0x158")]
	private static bool IsVisible(Vector3 worldPoint, GameObject go)
	{
		return false;
	}

	[Token(Token = "0x60008F0")]
	[Address(RVA = "0x113A3E0", Offset = "0x11391E0", Length = "0x159")]
	private static bool IsVisible(ref DepthEntry de)
	{
		return false;
	}

	[Token(Token = "0x60008F1")]
	[Address(RVA = "0x113A540", Offset = "0x1139340", Length = "0x286")]
	public static bool IsHighlighted(GameObject go)
	{
		return false;
	}

	[Token(Token = "0x60008F2")]
	[Address(RVA = "0x113A7D0", Offset = "0x11395D0", Length = "0x1BF")]
	public static UICamera FindCameraForLayer(int layer)
	{
		return null;
	}

	[Token(Token = "0x60008F3")]
	[Address(RVA = "0x113A990", Offset = "0x1139790", Length = "0xD5")]
	private static int GetDirection(KeyCode up, KeyCode down)
	{
		return 0;
	}

	[Token(Token = "0x60008F4")]
	[Address(RVA = "0x113AA70", Offset = "0x1139870", Length = "0x185")]
	private static int GetDirection(KeyCode up0, KeyCode up1, KeyCode down0, KeyCode down1)
	{
		return 0;
	}

	[Token(Token = "0x60008F5")]
	[Address(RVA = "0x113AC00", Offset = "0x1139A00", Length = "0x303")]
	public static void Notify(GameObject go, string funcName, object obj)
	{
	}

	[Token(Token = "0x60008F6")]
	[Address(RVA = "0x113AF10", Offset = "0x1139D10", Length = "0x77")]
	public static MouseOrTouch GetMouse(int button)
	{
		return null;
	}

	[Token(Token = "0x60008F7")]
	[Address(RVA = "0x113AF90", Offset = "0x1139D90", Length = "0x331")]
	public static MouseOrTouch GetTouch(int id)
	{
		return null;
	}

	[Token(Token = "0x60008F8")]
	[Address(RVA = "0x113B2D0", Offset = "0x113A0D0", Length = "0x196")]
	public static void RemoveTouch(int id)
	{
	}

	[Token(Token = "0x60008F9")]
	[Address(RVA = "0x113B470", Offset = "0x113A270", Length = "0x3CF")]
	private void Awake()
	{
	}

	[Token(Token = "0x60008FA")]
	[Address(RVA = "0x113B840", Offset = "0x113A640", Length = "0x213")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x60008FB")]
	[Address(RVA = "0x113BA60", Offset = "0x113A860", Length = "0x83")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x60008FC")]
	[Address(RVA = "0x113BAF0", Offset = "0x113A8F0", Length = "0x60A")]
	private void Start()
	{
	}

	[Token(Token = "0x60008FD")]
	[Address(RVA = "0x113C100", Offset = "0x113AF00", Length = "0xA88")]
	private void Update()
	{
	}

	[Token(Token = "0x60008FE")]
	[Address(RVA = "0x113CB90", Offset = "0x113B990", Length = "0x1F4")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x60008FF")]
	[Address(RVA = "0x113CD90", Offset = "0x113BB90", Length = "0x1474")]
	public void ProcessMouse()
	{
	}

	[Token(Token = "0x6000900")]
	[Address(RVA = "0x113E210", Offset = "0x113D010", Length = "0xC0F")]
	public void ProcessTouches()
	{
	}

	[Token(Token = "0x6000901")]
	[Address(RVA = "0x113EE20", Offset = "0x113DC20", Length = "0xA46")]
	private void ProcessFakeTouches()
	{
	}

	[Token(Token = "0x6000902")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public void ProcessOthers()
	{
	}

	[Token(Token = "0x6000903")]
	[Address(RVA = "0x113F870", Offset = "0x113E670", Length = "0x1404")]
	private void ProcessPress(bool pressed, float click, float drag)
	{
	}

	[Token(Token = "0x6000904")]
	[Address(RVA = "0x1140C80", Offset = "0x113FA80", Length = "0xDAA")]
	private void ProcessRelease(bool isMouse, float drag)
	{
	}

	[Token(Token = "0x6000905")]
	[Address(RVA = "0x1141A30", Offset = "0x1140830", Length = "0x506")]
	public void ProcessTouch(bool pressed, bool released)
	{
	}

	[Token(Token = "0x6000906")]
	[Address(RVA = "0x1141F40", Offset = "0x1140D40", Length = "0x174")]
	public void ShowTooltip(bool val)
	{
	}

	[Token(Token = "0x6000907")]
	[Address(RVA = "0x11420C0", Offset = "0x1140EC0", Length = "0x35B")]
	public static void SetSchemeOverride(ControlScheme newScheme)
	{
	}

	[Token(Token = "0x6000908")]
	[Address(RVA = "0x1142420", Offset = "0x1141220", Length = "0x3DC")]
	public UICamera()
	{
	}
}
