using Cpp2ILInjected;
using NodeCanvas.Framework;
using ParadoxNotion.Design;
using TLD.Gear;
using UnityEngine.AddressableAssets;

namespace NodeCanvas.Tasks.Actions;

[Name("Add Bearkiller Rifle", 0)]
[Description("Adds a fully loaded, perfect condition rifle and equips it in the player's hands.")]
[Category("TLD Actions/Challenge/Hunted2")]
[Token(Token = "0x20011CE")]
public class Action_AddBearkillerRifle : ActionTask
{
	[Token(Token = "0x40088FD")]
	[FieldOffset(Offset = "0x68")]
	public AssetReferenceT<GearItemData> m_RifleAsset;

	[Token(Token = "0x600763F")]
	[Address(RVA = "0x1119990", Offset = "0x1118790", Length = "0x3EC")]
	protected override void OnExecute()
	{
	}

	[Token(Token = "0x6007640")]
	[Address(RVA = "0xD769F0", Offset = "0xD757F0", Length = "0x8")]
	public Action_AddBearkillerRifle()
	{
	}
}
