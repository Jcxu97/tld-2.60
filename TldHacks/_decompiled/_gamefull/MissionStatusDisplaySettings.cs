using System;
using Cpp2ILInjected;
using UnityEngine;

[Serializable]
[Token(Token = "0x20005E8")]
public struct MissionStatusDisplaySettings
{
	[Header("Completed")]
	[Token(Token = "0x400368A")]
	[FieldOffset(Offset = "0x0")]
	public LocalizedString CompletedStatus;

	[Token(Token = "0x400368B")]
	[FieldOffset(Offset = "0x8")]
	public Color CompletedColor;

	[Token(Token = "0x400368C")]
	[FieldOffset(Offset = "0x18")]
	public string CompletedWwiseEvent;

	[Header("Failed")]
	[Token(Token = "0x400368D")]
	[FieldOffset(Offset = "0x20")]
	public LocalizedString FailedStatus;

	[Token(Token = "0x400368E")]
	[FieldOffset(Offset = "0x28")]
	public Color FailedColor;

	[Token(Token = "0x400368F")]
	[FieldOffset(Offset = "0x38")]
	public string FailedWwiseEvent;

	[Header("New")]
	[Token(Token = "0x4003690")]
	[FieldOffset(Offset = "0x40")]
	public LocalizedString NewStatus;

	[Token(Token = "0x4003691")]
	[FieldOffset(Offset = "0x48")]
	public Color NewColor;

	[Token(Token = "0x4003692")]
	[FieldOffset(Offset = "0x58")]
	public string NewWwiseEvent;

	[Header("Updated")]
	[Token(Token = "0x4003693")]
	[FieldOffset(Offset = "0x60")]
	public LocalizedString UpdatedStatus;

	[Token(Token = "0x4003694")]
	[FieldOffset(Offset = "0x68")]
	public Color UpdatedColor;

	[Token(Token = "0x4003695")]
	[FieldOffset(Offset = "0x78")]
	public string UpdatedWwiseEvent;

	[Token(Token = "0x6002DBB")]
	[Address(RVA = "0x954100", Offset = "0x952F00", Length = "0x4E")]
	public Color GetColor(MissionStatusType type)
	{
		return default(Color);
	}

	[Token(Token = "0x6002DBC")]
	[Address(RVA = "0x954150", Offset = "0x952F50", Length = "0x55")]
	public string GetLocID(MissionStatusType type)
	{
		return null;
	}

	[Token(Token = "0x6002DBD")]
	[Address(RVA = "0x9541B0", Offset = "0x952FB0", Length = "0x39")]
	public string GetWwiseEvent(MissionStatusType type)
	{
		return null;
	}
}
