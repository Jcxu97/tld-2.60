using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x2000291")]
public class TextInputField : MonoBehaviour
{
	[Token(Token = "0x400172F")]
	public static bool m_IsShowingVirtualKeyboard;

	[Token(Token = "0x4001730")]
	public static bool m_VirtualKeyboardDismissed;

	[Token(Token = "0x4001731")]
	[FieldOffset(Offset = "0x20")]
	public string m_VirtualKeyboardDescriptionLocID;

	[Token(Token = "0x4001732")]
	[FieldOffset(Offset = "0x28")]
	public uint m_MaxLength;

	[Token(Token = "0x4001733")]
	[FieldOffset(Offset = "0x2C")]
	public bool m_AllowBlankText;

	[Token(Token = "0x4001734")]
	[FieldOffset(Offset = "0x2D")]
	public bool m_AllowMultiLine;

	[Token(Token = "0x4001735")]
	[FieldOffset(Offset = "0x30")]
	private BoxCollider m_Collider;

	[Token(Token = "0x4001736")]
	[FieldOffset(Offset = "0x38")]
	private UILabel m_Label;

	[Token(Token = "0x4001737")]
	[FieldOffset(Offset = "0x40")]
	private UIInput m_Input;

	[Token(Token = "0x6001611")]
	[Address(RVA = "0x6AF190", Offset = "0x6ADF90", Length = "0x19D")]
	private void Start()
	{
	}

	[Token(Token = "0x6001612")]
	[Address(RVA = "0x6AF330", Offset = "0x6AE130", Length = "0x97F")]
	private void Update()
	{
	}

	[Token(Token = "0x6001613")]
	[Address(RVA = "0x6AFCB0", Offset = "0x6AEAB0", Length = "0x5A")]
	public void SetMaxLength(uint length)
	{
	}

	[Token(Token = "0x6001614")]
	[Address(RVA = "0x6AFD10", Offset = "0x6AEB10", Length = "0x10D")]
	public void SetText(string textToSet)
	{
	}

	[Token(Token = "0x6001615")]
	[Address(RVA = "0x6AFE20", Offset = "0x6AEC20", Length = "0xFC")]
	public string GetText()
	{
		return null;
	}

	[Token(Token = "0x6001616")]
	[Address(RVA = "0x6AFF20", Offset = "0x6AED20", Length = "0x16B")]
	public bool IsLockedIn()
	{
		return false;
	}

	[Token(Token = "0x6001617")]
	[Address(RVA = "0x6B0090", Offset = "0x6AEE90", Length = "0x59C")]
	public void Select()
	{
	}

	[Token(Token = "0x6001618")]
	[Address(RVA = "0x6B0630", Offset = "0x6AF430", Length = "0x4D3")]
	public Vector3 GetCursorLocation()
	{
		return default(Vector3);
	}

	[Token(Token = "0x6001619")]
	[Address(RVA = "0x6B0B10", Offset = "0x6AF910", Length = "0xCF")]
	private void ConsoleKeyboardCallback(bool success, string desiredString)
	{
	}

	[Token(Token = "0x600161A")]
	[Address(RVA = "0x6B0BE0", Offset = "0x6AF9E0", Length = "0x65")]
	private void UpdateInputString(string desiredString)
	{
	}

	[Token(Token = "0x600161B")]
	[Address(RVA = "0x6B0C50", Offset = "0x6AFA50", Length = "0x1C7")]
	public TextInputField()
	{
	}
}
