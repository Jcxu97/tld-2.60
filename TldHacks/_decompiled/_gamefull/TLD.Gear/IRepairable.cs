using Cpp2ILInjected;
using UnityEngine;

namespace TLD.Gear;

[Token(Token = "0x2001426")]
public interface IRepairable
{
	[Token(Token = "0x600807C")]
	GameObject GetGameObject();

	[Token(Token = "0x600807D")]
	int GetNumMaterialsRequired();

	[Token(Token = "0x600807E")]
	GearItem GetMaterialRequired(int Materialindex);

	[Token(Token = "0x600807F")]
	int GetRequiredGearUnits(int Materialindex);

	[Token(Token = "0x6008080")]
	int GetDurationMinutes();

	[Token(Token = "0x6008081")]
	string GetRepairAudio();

	[Token(Token = "0x6008082")]
	int GetNumRepairToolChoices();

	[Token(Token = "0x6008083")]
	ToolsItem GetRepairToolChoice(int i);

	[Token(Token = "0x6008084")]
	bool RequiresToolToRepair();

	[Token(Token = "0x6008085")]
	string GetDisplayName();

	[Token(Token = "0x6008086")]
	void OnRepairSuccessful();

	[Token(Token = "0x6008087")]
	float GetChanceSuccessfullRepair();

	[Token(Token = "0x6008088")]
	string GetSkillStringValue();

	[Token(Token = "0x6008089")]
	float GetConditionIncreaseFromRepair();

	[Token(Token = "0x600808A")]
	bool AffectsCondition();

	[Token(Token = "0x600808B")]
	float GetChanceActionSuccess(ToolsItem tool);

	[Token(Token = "0x600808C")]
	float GetRepairConditionCap();

	[Token(Token = "0x600808D")]
	bool AlwaysSucceeds();
}
