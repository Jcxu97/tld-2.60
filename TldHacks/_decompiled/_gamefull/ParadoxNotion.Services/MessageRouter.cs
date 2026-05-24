using System;
using System.Collections.Generic;
using System.Reflection;
using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.EventSystems;

namespace ParadoxNotion.Services;

[Token(Token = "0x2000D6E")]
public class MessageRouter : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler, IPointerDownHandler, IPointerUpHandler, IPointerClickHandler, IDragHandler, IScrollHandler, IUpdateSelectedHandler, ISelectHandler, IDeselectHandler, IMoveHandler, ISubmitHandler
{
	[Token(Token = "0x2000D6F")]
	public class MessageData
	{
		[Token(Token = "0x1700072C")]
		[field: Token(Token = "0x40083D8")]
		[field: FieldOffset(Offset = "0x10")]
		public GameObject receiver
		{
			[Token(Token = "0x600690A")]
			[Address(RVA = "0x49DED0", Offset = "0x49CCD0", Length = "0x5")]
			get;
			[Token(Token = "0x600690B")]
			[Address(RVA = "0x4094C0", Offset = "0x4082C0", Length = "0x52")]
			private set;
		}

		[Token(Token = "0x1700072D")]
		[field: Token(Token = "0x40083D9")]
		[field: FieldOffset(Offset = "0x18")]
		public object sender
		{
			[Token(Token = "0x600690C")]
			[Address(RVA = "0x4571D0", Offset = "0x455FD0", Length = "0x5")]
			get;
			[Token(Token = "0x600690D")]
			[Address(RVA = "0x49DEE0", Offset = "0x49CCE0", Length = "0x52")]
			private set;
		}

		[Token(Token = "0x600690E")]
		[Address(RVA = "0x409520", Offset = "0x408320", Length = "0xAA")]
		public MessageData(GameObject receiver, object sender)
		{
		}
	}

	[Token(Token = "0x2000D70")]
	public class MessageData<T> : MessageData
	{
		[Token(Token = "0x1700072E")]
		public T value
		{
			[Token(Token = "0x600690F")]
			[Address(RVA = "0x4571E0", Offset = "0x455FE0", Length = "0x4")]
			get;
			[Token(Token = "0x6006910")]
			[Address(RVA = "0x509350", Offset = "0x508150", Length = "0x4")]
			private set;
		}

		[Token(Token = "0x6006911")]
		[Address(RVA = "0x1DC5490", Offset = "0x1DC4290", Length = "0x31")]
		public MessageData(T value, GameObject receiver, object sender)
			: base(null, null)
		{
		}
	}

	[Token(Token = "0x40083D5")]
	private const BindingFlags METHOD_FLAGS = BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic;

	[Token(Token = "0x40083D6")]
	[FieldOffset(Offset = "0x20")]
	private Dictionary<string, List<object>> listeners;

	[Token(Token = "0x40083D7")]
	[FieldOffset(Offset = "0x28")]
	private object _animator;

	[Token(Token = "0x1700072B")]
	private Animator animator
	{
		[Token(Token = "0x60068D6")]
		[Address(RVA = "0x106F070", Offset = "0x106DE70", Length = "0x17F")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60068D7")]
	[Address(RVA = "0x106F1F0", Offset = "0x106DFF0", Length = "0x6E")]
	public void OnPointerEnter(PointerEventData eventData)
	{
	}

	[Token(Token = "0x60068D8")]
	[Address(RVA = "0x106F260", Offset = "0x106E060", Length = "0x6E")]
	public void OnPointerExit(PointerEventData eventData)
	{
	}

	[Token(Token = "0x60068D9")]
	[Address(RVA = "0x106F2D0", Offset = "0x106E0D0", Length = "0x6E")]
	public void OnPointerDown(PointerEventData eventData)
	{
	}

	[Token(Token = "0x60068DA")]
	[Address(RVA = "0x106F340", Offset = "0x106E140", Length = "0x6E")]
	public void OnPointerUp(PointerEventData eventData)
	{
	}

	[Token(Token = "0x60068DB")]
	[Address(RVA = "0x106F3B0", Offset = "0x106E1B0", Length = "0x6E")]
	public void OnPointerClick(PointerEventData eventData)
	{
	}

	[Token(Token = "0x60068DC")]
	[Address(RVA = "0x106F420", Offset = "0x106E220", Length = "0x6E")]
	public void OnDrag(PointerEventData eventData)
	{
	}

	[Token(Token = "0x60068DD")]
	[Address(RVA = "0x106F490", Offset = "0x106E290", Length = "0x6E")]
	public void OnDrop(BaseEventData eventData)
	{
	}

	[Token(Token = "0x60068DE")]
	[Address(RVA = "0x106F500", Offset = "0x106E300", Length = "0x6E")]
	public void OnScroll(PointerEventData eventData)
	{
	}

	[Token(Token = "0x60068DF")]
	[Address(RVA = "0x106F570", Offset = "0x106E370", Length = "0x6E")]
	public void OnUpdateSelected(BaseEventData eventData)
	{
	}

	[Token(Token = "0x60068E0")]
	[Address(RVA = "0x106F5E0", Offset = "0x106E3E0", Length = "0x6E")]
	public void OnSelect(BaseEventData eventData)
	{
	}

	[Token(Token = "0x60068E1")]
	[Address(RVA = "0x106F650", Offset = "0x106E450", Length = "0x6E")]
	public void OnDeselect(BaseEventData eventData)
	{
	}

	[Token(Token = "0x60068E2")]
	[Address(RVA = "0x106F6C0", Offset = "0x106E4C0", Length = "0x6E")]
	public void OnMove(AxisEventData eventData)
	{
	}

	[Token(Token = "0x60068E3")]
	[Address(RVA = "0x106F730", Offset = "0x106E530", Length = "0x6E")]
	public void OnSubmit(BaseEventData eventData)
	{
	}

	[Token(Token = "0x60068E4")]
	[Address(RVA = "0x106F7A0", Offset = "0x106E5A0", Length = "0x6D")]
	private void OnAnimatorIK(int layerIndex)
	{
	}

	[Token(Token = "0x60068E5")]
	[Address(RVA = "0x106F810", Offset = "0x106E610", Length = "0x1B3")]
	private void OnAnimatorMove()
	{
	}

	[Token(Token = "0x60068E6")]
	[Address(RVA = "0x106F9D0", Offset = "0x106E7D0", Length = "0x7E")]
	private void OnBecameInvisible()
	{
	}

	[Token(Token = "0x60068E7")]
	[Address(RVA = "0x106FA50", Offset = "0x106E850", Length = "0x7E")]
	private void OnBecameVisible()
	{
	}

	[Token(Token = "0x60068E8")]
	[Address(RVA = "0x106FAD0", Offset = "0x106E8D0", Length = "0x6E")]
	private void OnCollisionEnter(Collision collisionInfo)
	{
	}

	[Token(Token = "0x60068E9")]
	[Address(RVA = "0x106FB40", Offset = "0x106E940", Length = "0x6E")]
	private void OnCollisionExit(Collision collisionInfo)
	{
	}

	[Token(Token = "0x60068EA")]
	[Address(RVA = "0x106FBB0", Offset = "0x106E9B0", Length = "0x6E")]
	private void OnCollisionStay(Collision collisionInfo)
	{
	}

	[Token(Token = "0x60068EB")]
	[Address(RVA = "0x106FC20", Offset = "0x106EA20", Length = "0x6E")]
	private void OnCollisionEnter2D(Collision2D collisionInfo)
	{
	}

	[Token(Token = "0x60068EC")]
	[Address(RVA = "0x106FC90", Offset = "0x106EA90", Length = "0x6E")]
	private void OnCollisionExit2D(Collision2D collisionInfo)
	{
	}

	[Token(Token = "0x60068ED")]
	[Address(RVA = "0x106FD00", Offset = "0x106EB00", Length = "0x6E")]
	private void OnCollisionStay2D(Collision2D collisionInfo)
	{
	}

	[Token(Token = "0x60068EE")]
	[Address(RVA = "0x106FD70", Offset = "0x106EB70", Length = "0x6E")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x60068EF")]
	[Address(RVA = "0x106FDE0", Offset = "0x106EBE0", Length = "0x6E")]
	private void OnTriggerExit(Collider other)
	{
	}

	[Token(Token = "0x60068F0")]
	[Address(RVA = "0x106FE50", Offset = "0x106EC50", Length = "0x6E")]
	private void OnTriggerStay(Collider other)
	{
	}

	[Token(Token = "0x60068F1")]
	[Address(RVA = "0x106FEC0", Offset = "0x106ECC0", Length = "0x6E")]
	private void OnTriggerEnter2D(Collider2D other)
	{
	}

	[Token(Token = "0x60068F2")]
	[Address(RVA = "0x106FF30", Offset = "0x106ED30", Length = "0x6E")]
	private void OnTriggerExit2D(Collider2D other)
	{
	}

	[Token(Token = "0x60068F3")]
	[Address(RVA = "0x106FFA0", Offset = "0x106EDA0", Length = "0x6E")]
	private void OnTriggerStay2D(Collider2D other)
	{
	}

	[Token(Token = "0x60068F4")]
	[Address(RVA = "0x1070010", Offset = "0x106EE10", Length = "0x7E")]
	private void OnMouseDown()
	{
	}

	[Token(Token = "0x60068F5")]
	[Address(RVA = "0x1070090", Offset = "0x106EE90", Length = "0x7E")]
	private void OnMouseDrag()
	{
	}

	[Token(Token = "0x60068F6")]
	[Address(RVA = "0x1070110", Offset = "0x106EF10", Length = "0x7E")]
	private void OnMouseEnter()
	{
	}

	[Token(Token = "0x60068F7")]
	[Address(RVA = "0x1070190", Offset = "0x106EF90", Length = "0x7E")]
	private void OnMouseExit()
	{
	}

	[Token(Token = "0x60068F8")]
	[Address(RVA = "0x1070210", Offset = "0x106F010", Length = "0x7E")]
	private void OnMouseOver()
	{
	}

	[Token(Token = "0x60068F9")]
	[Address(RVA = "0x1070290", Offset = "0x106F090", Length = "0x7E")]
	private void OnMouseUp()
	{
	}

	[Token(Token = "0x60068FA")]
	[Address(RVA = "0x1070310", Offset = "0x106F110", Length = "0x6E")]
	private void OnControllerColliderHit(ControllerColliderHit hit)
	{
	}

	[Token(Token = "0x60068FB")]
	[Address(RVA = "0x1070380", Offset = "0x106F180", Length = "0x6E")]
	private void OnParticleCollision(GameObject other)
	{
	}

	[Token(Token = "0x60068FC")]
	[Address(RVA = "0x10703F0", Offset = "0x106F1F0", Length = "0x7E")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x60068FD")]
	[Address(RVA = "0x1070470", Offset = "0x106F270", Length = "0x7E")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x60068FE")]
	[Address(RVA = "0x10704F0", Offset = "0x106F2F0", Length = "0x7E")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x60068FF")]
	[Address(RVA = "0x1070570", Offset = "0x106F370", Length = "0x7E")]
	private void OnTransformChildrenChanged()
	{
	}

	[Token(Token = "0x6006900")]
	[Address(RVA = "0x10705F0", Offset = "0x106F3F0", Length = "0x7E")]
	private void OnTransformParentChanged()
	{
	}

	[Token(Token = "0x6006901")]
	[Address(RVA = "0x1070670", Offset = "0x106F470", Length = "0x35D")]
	public void Register(object target, params string[] messages)
	{
	}

	[Token(Token = "0x6006902")]
	[Address(RVA = "0x10709D0", Offset = "0x106F7D0", Length = "0x8")]
	public void RegisterCallback(string message, Action callback)
	{
	}

	[Token(Token = "0x6006903")]
	[Address(RVA = "0x10709D0", Offset = "0x106F7D0", Length = "0x8")]
	public void RegisterCallback<T>(string message, Action<T> callback)
	{
	}

	[Token(Token = "0x6006904")]
	[Address(RVA = "0x10709E0", Offset = "0x106F7E0", Length = "0x1E3")]
	private void Internal_RegisterCallback(string message, Delegate callback)
	{
	}

	[Token(Token = "0x6006905")]
	[Address(RVA = "0x1070BD0", Offset = "0x106F9D0", Length = "0x3CC")]
	public void UnRegister(object target)
	{
	}

	[Token(Token = "0x6006906")]
	[Address(RVA = "0x1070FA0", Offset = "0x106FDA0", Length = "0x240")]
	public void UnRegister(object target, params string[] messages)
	{
	}

	[Token(Token = "0x6006907")]
	[Address(RVA = "0x10711F0", Offset = "0x106FFF0", Length = "0x66")]
	public bool Dispatch(string message, object sender = null)
	{
		return false;
	}

	[Token(Token = "0x6006908")]
	[Address(RVA = "0x1951600", Offset = "0x1950400", Length = "0x6E0")]
	public bool Dispatch<T>(string message, T arg, object sender = null)
	{
		return false;
	}

	[Token(Token = "0x6006909")]
	[Address(RVA = "0x1071260", Offset = "0x1070060", Length = "0x167")]
	public MessageRouter()
	{
	}
}
