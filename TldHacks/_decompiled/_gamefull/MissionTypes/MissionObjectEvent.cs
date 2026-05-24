using Cpp2ILInjected;

namespace MissionTypes;

[Token(Token = "0x2000D45")]
public enum MissionObjectEvent
{
	[Token(Token = "0x40082D6")]
	GenericInteraction,
	[Token(Token = "0x40082D7")]
	ObjectInspected,
	[Token(Token = "0x40082D8")]
	ObjectBrokenDown,
	[Token(Token = "0x40082D9")]
	Fire_Off,
	[Token(Token = "0x40082DA")]
	Fire_Starting_FireStarterUse,
	[Token(Token = "0x40082DB")]
	Fire_Starting_TinderSmolder,
	[Token(Token = "0x40082DC")]
	Fire_Starting_TinderSmallFlame,
	[Token(Token = "0x40082DD")]
	Fire_Starting_MediumBurn,
	[Token(Token = "0x40082DE")]
	Fire_Starting_FullBurn,
	[Token(Token = "0x40082DF")]
	Fire_FullBurn,
	[Token(Token = "0x40082E0")]
	Fire_BlownOut,
	[Token(Token = "0x40082E1")]
	Object_Theft,
	[Token(Token = "0x40082E2")]
	TrustInteraction,
	[Token(Token = "0x40082E3")]
	BearEncounterWon,
	[Token(Token = "0x40082E4")]
	BearEncounterFailed,
	[Token(Token = "0x40082E5")]
	InteractionComplete,
	[Token(Token = "0x40082E6")]
	HuntedBearDetectedPlayer,
	[Token(Token = "0x40082E7")]
	AnimatedInteractionComplete,
	[Token(Token = "0x40082E8")]
	PlayerStunnedEnd,
	[Token(Token = "0x40082E9")]
	BearEncounterBearDead,
	[Token(Token = "0x40082EA")]
	BearEncounterAbandoned,
	[Token(Token = "0x40082EB")]
	ActivateLoadingZone,
	[Token(Token = "0x40082EC")]
	PhoneHangupComplete,
	[Token(Token = "0x40082ED")]
	NPC_Diagnosed,
	[Token(Token = "0x40082EE")]
	NPC_Healed,
	[Token(Token = "0x40082EF")]
	RescueZone_TargetFound,
	[Token(Token = "0x40082F0")]
	RescueZone_ShotSpotted,
	[Token(Token = "0x40082F1")]
	RescueZone_PlayerEntered,
	[Token(Token = "0x40082F2")]
	RescueZone_PlayerLeft,
	[Token(Token = "0x40082F3")]
	NPC_ReturnedToHall,
	[Token(Token = "0x40082F4")]
	Darkwalker_Countdown_Complete,
	[Token(Token = "0x40082F5")]
	Darkwalker_Banish_Placed
}
