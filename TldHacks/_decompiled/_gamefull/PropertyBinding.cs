using Cpp2ILInjected;
using UnityEngine;

[ExecuteInEditMode]
[AddComponentMenu("NGUI/Internal/Property Binding")]
[Token(Token = "0x20000BB")]
public class PropertyBinding : MonoBehaviour
{
	[Token(Token = "0x20000BC")]
	public enum UpdateCondition
	{
		[Token(Token = "0x400062F")]
		OnStart,
		[Token(Token = "0x4000630")]
		OnUpdate,
		[Token(Token = "0x4000631")]
		OnLateUpdate,
		[Token(Token = "0x4000632")]
		OnFixedUpdate
	}

	[Token(Token = "0x20000BD")]
	public enum Direction
	{
		[Token(Token = "0x4000634")]
		SourceUpdatesTarget,
		[Token(Token = "0x4000635")]
		TargetUpdatesSource,
		[Token(Token = "0x4000636")]
		BiDirectional
	}

	[Token(Token = "0x4000628")]
	[FieldOffset(Offset = "0x20")]
	public PropertyReference source;

	[Token(Token = "0x4000629")]
	[FieldOffset(Offset = "0x28")]
	public PropertyReference target;

	[Token(Token = "0x400062A")]
	[FieldOffset(Offset = "0x30")]
	public Direction direction;

	[Token(Token = "0x400062B")]
	[FieldOffset(Offset = "0x34")]
	public UpdateCondition update;

	[Token(Token = "0x400062C")]
	[FieldOffset(Offset = "0x38")]
	public bool editMode;

	[Token(Token = "0x400062D")]
	[FieldOffset(Offset = "0x40")]
	private object mLastValue;

	[Token(Token = "0x60006CE")]
	[Address(RVA = "0xF938B0", Offset = "0xF926B0", Length = "0x2E")]
	private void Start()
	{
	}

	[Token(Token = "0x60006CF")]
	[Address(RVA = "0xF938E0", Offset = "0xF926E0", Length = "0xE")]
	private void Update()
	{
	}

	[Token(Token = "0x60006D0")]
	[Address(RVA = "0xF938F0", Offset = "0xF926F0", Length = "0xE")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x60006D1")]
	[Address(RVA = "0xF93900", Offset = "0xF92700", Length = "0xE")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x60006D2")]
	[Address(RVA = "0xF93910", Offset = "0xF92710", Length = "0x34")]
	private void OnValidate()
	{
	}

	[ContextMenu("Update Now")]
	[Token(Token = "0x60006D3")]
	[Address(RVA = "0xF93950", Offset = "0xF92750", Length = "0x1BD")]
	public void UpdateTarget()
	{
	}

	[Token(Token = "0x60006D4")]
	[Address(RVA = "0x865D70", Offset = "0x864B70", Length = "0x4E")]
	public PropertyBinding()
	{
	}
}
