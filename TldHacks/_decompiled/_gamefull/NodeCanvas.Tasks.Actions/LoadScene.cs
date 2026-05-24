using Cpp2ILInjected;
using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine.SceneManagement;

namespace NodeCanvas.Tasks.Actions;

[Category("Application")]
[Token(Token = "0x200128C")]
public class LoadScene : ActionTask
{
	[RequiredField]
	[Token(Token = "0x4008B48")]
	[FieldOffset(Offset = "0x68")]
	public BBParameter<string> sceneName;

	[Token(Token = "0x4008B49")]
	[FieldOffset(Offset = "0x70")]
	public BBParameter<LoadSceneMode> mode;

	[Token(Token = "0x170009C0")]
	protected override string info
	{
		[Token(Token = "0x6007872")]
		[Address(RVA = "0x116F8C0", Offset = "0x116E6C0", Length = "0x84")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6007873")]
	[Address(RVA = "0x116F950", Offset = "0x116E750", Length = "0xC8")]
	protected override void OnExecute()
	{
	}

	[Token(Token = "0x6007874")]
	[Address(RVA = "0xD769F0", Offset = "0xD757F0", Length = "0x8")]
	public LoadScene()
	{
	}
}
