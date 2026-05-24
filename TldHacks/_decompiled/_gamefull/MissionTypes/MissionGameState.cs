using Cpp2ILInjected;

namespace MissionTypes;

[Token(Token = "0x2000D46")]
public enum MissionGameState
{
	[Token(Token = "0x40082F7")]
	Undefined,
	[Token(Token = "0x40082F8")]
	Misc_TimeIsAccelerated,
	[Token(Token = "0x40082F9")]
	Player_IsIndoors,
	[Token(Token = "0x40082FA")]
	Player_IsInVehicle,
	[Token(Token = "0x40082FB")]
	Player_IsSheltered,
	[Token(Token = "0x40082FC")]
	Player_IsRopeClimbing,
	[Token(Token = "0x40082FD")]
	Player_IsStarving,
	[Token(Token = "0x40082FE")]
	Player_IsDehydrated,
	[Token(Token = "0x40082FF")]
	Player_IsVeryThirsty,
	[Token(Token = "0x4008300")]
	Player_IsFreezing,
	[Token(Token = "0x4008301")]
	Player_IsEncumbered,
	[Token(Token = "0x4008302")]
	Player_IsLowStamina,
	[Token(Token = "0x4008303")]
	Player_IsExhausted,
	[Token(Token = "0x4008304")]
	Player_IsSleeping,
	[Token(Token = "0x4008305")]
	PlayerAffliction_HasInfection,
	[Token(Token = "0x4008306")]
	PlayerAffliction_HasInfectionRisk,
	[Token(Token = "0x4008307")]
	PlayerAffliction_HasBloodLoss,
	[Token(Token = "0x4008308")]
	PlayerAffliction_HasFoodPoisoning,
	[Token(Token = "0x4008309")]
	PlayerAffliction_HasSprainedAnkle,
	[Token(Token = "0x400830A")]
	PlayerAffliction_HasSprainedWrist,
	[Token(Token = "0x400830B")]
	PlayerAffliction_HasSprainedWristMajor,
	[Token(Token = "0x400830C")]
	PlayerAffliction_HasBurns,
	[Token(Token = "0x400830D")]
	PlayerAffliction_HasDysentery,
	[Token(Token = "0x400830E")]
	PlayerAffliction_HasHypothermia,
	[Token(Token = "0x400830F")]
	PlayerAffliction_HasHypothermiaRisk,
	[Token(Token = "0x4008310")]
	PlayerAffliction_HasCabinFever,
	[Token(Token = "0x4008311")]
	PlayerAffliction_HasCabinFeverRisk,
	[Token(Token = "0x4008312")]
	PlayerAffliction_HasIntestinalParasites,
	[Token(Token = "0x4008313")]
	PlayerAffliction_HasIntestinalParasitesRisk,
	[Token(Token = "0x4008314")]
	PlayerCondition_IsDegrading,
	[Token(Token = "0x4008315")]
	PlayerCondition_HasNonRiskAffliction,
	[Token(Token = "0x4008316")]
	PlayerCondition_HasAffliction,
	[Token(Token = "0x4008317")]
	PlayerCondition_IsVulnerable,
	[Token(Token = "0x4008318")]
	TimeOfDay_IsDawn,
	[Token(Token = "0x4008319")]
	TimeOfDay_IsMidDay,
	[Token(Token = "0x400831A")]
	TimeOfDay_IsDayMorning,
	[Token(Token = "0x400831B")]
	TimeOfDay_IsDayAfternoon,
	[Token(Token = "0x400831C")]
	TimeOfDay_IsDusk,
	[Token(Token = "0x400831D")]
	TimeOfDay_IsDay,
	[Token(Token = "0x400831E")]
	TimeOfDay_IsNight,
	[Token(Token = "0x400831F")]
	TimeOfDay_IsNightPreMidnight,
	[Token(Token = "0x4008320")]
	TimeOfDay_IsNightPostMidnight,
	[Token(Token = "0x4008321")]
	Weather_IsDenseFog,
	[Token(Token = "0x4008322")]
	Weather_IsLightFog,
	[Token(Token = "0x4008323")]
	Weather_IsClear,
	[Token(Token = "0x4008324")]
	Weather_IsPartlyCloudy,
	[Token(Token = "0x4008325")]
	Weather_IsCloudy,
	[Token(Token = "0x4008326")]
	Weather_IsLightSnow,
	[Token(Token = "0x4008327")]
	Weather_IsHeavySnow,
	[Token(Token = "0x4008328")]
	Weather_IsBlizzard,
	[Token(Token = "0x4008329")]
	Weather_IsAnyCloudy,
	[Token(Token = "0x400832A")]
	Weather_IsAnySnowing,
	[Token(Token = "0x400832B")]
	Weather_IsAnyFoggy,
	[Token(Token = "0x400832C")]
	Weather_IsBadWeather,
	[Token(Token = "0x400832D")]
	Weather_IsAuroraActive,
	[Token(Token = "0x400832E")]
	Weather_IsWindy,
	[Token(Token = "0x400832F")]
	Weather_IsVeryWindy,
	[Token(Token = "0x4008330")]
	PlayerHasConsumedRosehipTea,
	[Token(Token = "0x4008331")]
	PlayerHasConsumedReishiTea,
	[Token(Token = "0x4008332")]
	PlayerHasConsumedOldMansBeardDressing,
	[Token(Token = "0x4008333")]
	PlayerAffliction_HasBurnsElectric,
	[Token(Token = "0x4008334")]
	PlayerAffliction_HasBrokenRibs,
	[Token(Token = "0x4008335")]
	PlayerHasConsumedCoffee,
	[Token(Token = "0x4008336")]
	PlayerAffliction_HasSprainPain,
	[Token(Token = "0x4008337")]
	Weather_IsAuroraFullyActive,
	[Token(Token = "0x4008338")]
	PlayerAffliction_HasAnxiety,
	[Token(Token = "0x4008339")]
	PlayerAffliction_HasFear,
	[Token(Token = "0x400833A")]
	PlayerAffliction_HasToxicFog
}
