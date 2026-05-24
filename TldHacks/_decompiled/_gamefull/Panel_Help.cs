using Cpp2ILInjected;
using TLD.UI;
using UnityEngine;

[Token(Token = "0x200065D")]
public class Panel_Help : Panel_AutoReferenced
{
	[HideInInspector]
	[Token(Token = "0x4003E28")]
	[FieldOffset(Offset = "0x30")]
	public bool m_EnablePauseMenuOnExit;

	[Token(Token = "0x6003439")]
	[Address(RVA = "0xA59A70", Offset = "0xA58870", Length = "0x1A")]
	public override void Initialize()
	{
	}

	[Token(Token = "0x600343A")]
	[Address(RVA = "0xA59A90", Offset = "0xA58890", Length = "0xEE")]
	private void Update()
	{
	}

	[Token(Token = "0x600343B")]
	[Address(RVA = "0xA59B80", Offset = "0xA58980", Length = "0x55")]
	public void OnDone()
	{
	}

	[Token(Token = "0x600343C")]
	[Address(RVA = "0xA59BE0", Offset = "0xA589E0", Length = "0x83")]
	private void ExitInterface()
	{
	}

	[Token(Token = "0x600343D")]
	[Address(RVA = "0x4AF5E0", Offset = "0x4AE3E0", Length = "0x43")]
	public Panel_Help()
	{
	}
}
