using Cpp2ILInjected;
using UnityEngine;

namespace NodeCanvas.DialogueTrees;

[AddComponentMenu("NodeCanvas/Dialogue Actor")]
[Token(Token = "0x20010E8")]
public class DialogueActor : MonoBehaviour, IDialogueActor
{
	[SerializeField]
	[Token(Token = "0x40086CE")]
	[FieldOffset(Offset = "0x20")]
	protected string _name;

	[SerializeField]
	[Token(Token = "0x40086CF")]
	[FieldOffset(Offset = "0x28")]
	protected Texture2D _portrait;

	[SerializeField]
	[Token(Token = "0x40086D0")]
	[FieldOffset(Offset = "0x30")]
	protected Color _dialogueColor;

	[SerializeField]
	[Token(Token = "0x40086D1")]
	[FieldOffset(Offset = "0x40")]
	protected Vector3 _dialogueOffset;

	[Token(Token = "0x40086D2")]
	[FieldOffset(Offset = "0x50")]
	private Sprite _portraitSprite;

	[Token(Token = "0x17000885")]
	public new string name
	{
		[Token(Token = "0x60072AA")]
		[Address(RVA = "0x40E110", Offset = "0x40CF10", Length = "0x5")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000886")]
	public Texture2D portrait
	{
		[Token(Token = "0x60072AB")]
		[Address(RVA = "0x413AB0", Offset = "0x4128B0", Length = "0x5")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000887")]
	public Sprite portraitSprite
	{
		[Token(Token = "0x60072AC")]
		[Address(RVA = "0x10E4AA0", Offset = "0x10E38A0", Length = "0x25C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000888")]
	public Color dialogueColor
	{
		[Token(Token = "0x60072AD")]
		[Address(RVA = "0x10E4D00", Offset = "0x10E3B00", Length = "0xB")]
		get
		{
			return default(Color);
		}
	}

	[Token(Token = "0x17000889")]
	public Vector3 dialoguePosition
	{
		[Token(Token = "0x60072AE")]
		[Address(RVA = "0x10E4D10", Offset = "0x10E3B10", Length = "0xF0")]
		get
		{
			return default(Vector3);
		}
	}

	Transform IDialogueActor.transform
	{
		[Token(Token = "0x60072B0")]
		[Address(RVA = "0x935C80", Offset = "0x934A80", Length = "0x7")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60072AF")]
	[Address(RVA = "0x10E4E10", Offset = "0x10E3C10", Length = "0x53")]
	public DialogueActor()
	{
	}
}
