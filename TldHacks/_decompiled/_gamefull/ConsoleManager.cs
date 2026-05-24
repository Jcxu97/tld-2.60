using System.Collections.Generic;
using Cpp2ILInjected;
using TLD.Gameplay;
using TLD.Gear;
using TLD.Logging;
using TLD.Scenes;
using UnityEngine;

[Token(Token = "0x200071A")]
public class ConsoleManager
{
	[Token(Token = "0x4004B77")]
	public static Dictionary<string, List<string>> m_ComponentNameToGearNames;

	[Token(Token = "0x4004B78")]
	private static Dictionary<string, string> m_SearchStringToGearNames;

	[Token(Token = "0x4004B79")]
	public static LogFilter s_LogFilter;

	[Token(Token = "0x4004B7A")]
	private static bool m_Initialized;

	[Token(Token = "0x6003E57")]
	[Address(RVA = "0xBA2300", Offset = "0xBA1100", Length = "0xD78")]
	public static void Initialize()
	{
	}

	[Token(Token = "0x6003E58")]
	[Address(RVA = "0xBA3080", Offset = "0xBA1E80", Length = "0xADA5")]
	public static void RegisterCommands()
	{
	}

	[Token(Token = "0x6003E59")]
	[Address(RVA = "0xBADE30", Offset = "0xBACC30", Length = "0x1B0")]
	private static void CONSOLE_reload_weather_override()
	{
	}

	[Token(Token = "0x6003E5A")]
	[Address(RVA = "0xBADFF0", Offset = "0xBACDF0", Length = "0x2C9")]
	public static void CONSOLE_add_all_gear()
	{
	}

	[Token(Token = "0x6003E5B")]
	[Address(RVA = "0xBAE2C0", Offset = "0xBAD0C0", Length = "0x127")]
	public static void CONSOLE_add_decoration()
	{
	}

	[Token(Token = "0x6003E5C")]
	[Address(RVA = "0xBAE3F0", Offset = "0xBAD1F0", Length = "0x53F")]
	public static void CONSOLE_gear_add_lostandfound()
	{
	}

	[Token(Token = "0x6003E5D")]
	[Address(RVA = "0xBAE930", Offset = "0xBAD730", Length = "0x425")]
	public static void CONSOLE_ai_feeding_test()
	{
	}

	[Token(Token = "0x6003E5E")]
	[Address(RVA = "0xBAED60", Offset = "0xBADB60", Length = "0xDC")]
	public static void CONSOLE_ai_batchgroundraycast()
	{
	}

	[Token(Token = "0x6003E5F")]
	[Address(RVA = "0xBAEE40", Offset = "0xBADC40", Length = "0x116")]
	public static void CONSOLE_ai_continuouscollision()
	{
	}

	[Token(Token = "0x6003E60")]
	[Address(RVA = "0xBAEF60", Offset = "0xBADD60", Length = "0xDC")]
	public static void CONSOLE_audiospline_usejobsystem()
	{
	}

	[Token(Token = "0x6003E61")]
	[Address(RVA = "0xBAF040", Offset = "0xBADE40", Length = "0x380")]
	public static void CONSOLE_afflictions()
	{
	}

	[Token(Token = "0x6003E62")]
	[Address(RVA = "0xBAF3D0", Offset = "0xBAE1D0", Length = "0x450")]
	public static void CONSOLE_afflictions_cure()
	{
	}

	[Token(Token = "0x6003E63")]
	[Address(RVA = "0xBAF830", Offset = "0xBAE630", Length = "0xED")]
	public static void CONSOLE_afflictions_nofx()
	{
	}

	[Token(Token = "0x6003E64")]
	[Address(RVA = "0xBAF920", Offset = "0xBAE720", Length = "0xA2")]
	public static void CONSOLE_almanac_debug()
	{
	}

	[Token(Token = "0x6003E65")]
	[Address(RVA = "0xBAF9D0", Offset = "0xBAE7D0", Length = "0x175")]
	public static void CONSOLE_atlas_sd()
	{
	}

	[Token(Token = "0x6003E66")]
	[Address(RVA = "0xBAFB50", Offset = "0xBAE950", Length = "0xF7")]
	public static void CONSOLE_aurora()
	{
	}

	[Token(Token = "0x6003E67")]
	[Address(RVA = "0xBAFC50", Offset = "0xBAEA50", Length = "0x14A")]
	public static void CONSOLE_autosave()
	{
	}

	[Token(Token = "0x6003E68")]
	[Address(RVA = "0xBAFDA0", Offset = "0xBAEBA0", Length = "0xC9")]
	public static void CONSOLE_beachcombing_force_blizzard()
	{
	}

	[Token(Token = "0x6003E69")]
	[Address(RVA = "0xBAFE70", Offset = "0xBAEC70", Length = "0xBD")]
	public static void CONSOLE_bearhuntredux_encounter_activate()
	{
	}

	[Token(Token = "0x6003E6A")]
	[Address(RVA = "0xBAFF30", Offset = "0xBAED30", Length = "0xBD")]
	public static void CONSOLE_bearhuntredux_encounter_last()
	{
	}

	[Token(Token = "0x6003E6B")]
	[Address(RVA = "0xBAFFF0", Offset = "0xBAEDF0", Length = "0x243")]
	public static void CONSOLE_bearhuntredux_encounter_poststrugglemode()
	{
	}

	[Token(Token = "0x6003E6C")]
	[Address(RVA = "0xBB0240", Offset = "0xBAF040", Length = "0xBC")]
	public static void CONSOLE_bear_hunt_redux()
	{
	}

	[Token(Token = "0x6003E6D")]
	[Address(RVA = "0xBB0300", Offset = "0xBAF100", Length = "0x16D")]
	public static void CONSOLE_bearspear()
	{
	}

	[Token(Token = "0x6003E6E")]
	[Address(RVA = "0xBB0470", Offset = "0xBAF270", Length = "0x42A")]
	public static void CONSOLE_blood_loss()
	{
	}

	[Token(Token = "0x6003E6F")]
	[Address(RVA = "0xBB08A0", Offset = "0xBAF6A0", Length = "0x57")]
	public static void CONSOLE_blood_loss_cure()
	{
	}

	[Token(Token = "0x6003E70")]
	[Address(RVA = "0xBB0900", Offset = "0xBAF700", Length = "0xD7")]
	public static void CONSOLE_blood_loss_no_damage()
	{
	}

	[Token(Token = "0x6003E71")]
	[Address(RVA = "0xBB09E0", Offset = "0xBAF7E0", Length = "0x422")]
	public static void CONSOLE_blood_loss_nofx()
	{
	}

	[Token(Token = "0x6003E72")]
	[Address(RVA = "0xBB0E10", Offset = "0xBAFC10", Length = "0x5A")]
	public static void CONSOLE_insomnia()
	{
	}

	[Token(Token = "0x6003E73")]
	[Address(RVA = "0xBB0E70", Offset = "0xBAFC70", Length = "0x5D")]
	public static void CONSOLE_insomnia_risk()
	{
	}

	[Token(Token = "0x6003E74")]
	[Address(RVA = "0xBB0ED0", Offset = "0xBAFCD0", Length = "0x5C")]
	public static void CONSOLE_brokenbody()
	{
	}

	[Token(Token = "0x6003E75")]
	[Address(RVA = "0xBB0F30", Offset = "0xBAFD30", Length = "0x5C")]
	public static void CONSOLE_brokenbody_cure()
	{
	}

	[Token(Token = "0x6003E76")]
	[Address(RVA = "0xBB0F90", Offset = "0xBAFD90", Length = "0xCA")]
	public static void CONSOLE_brokenrib()
	{
	}

	[Token(Token = "0x6003E77")]
	[Address(RVA = "0xBB1060", Offset = "0xBAFE60", Length = "0x9D")]
	public static void CONSOLE_brokenrib_cure()
	{
	}

	[Token(Token = "0x6003E78")]
	[Address(RVA = "0xBB1100", Offset = "0xBAFF00", Length = "0xCA")]
	public static void CONSOLE_brokenrib_minor()
	{
	}

	[Token(Token = "0x6003E79")]
	[Address(RVA = "0xBB11D0", Offset = "0xBAFFD0", Length = "0xCA")]
	public static void CONSOLE_brokenrib_nofx()
	{
	}

	[Token(Token = "0x6003E7A")]
	[Address(RVA = "0xBB12A0", Offset = "0xBB00A0", Length = "0xCA")]
	public static void CONSOLE_brokenrib_minor_nofx()
	{
	}

	[Token(Token = "0x6003E7B")]
	[Address(RVA = "0xBB1370", Offset = "0xBB0170", Length = "0x24F")]
	public static void CONSOLE_blueprint_unlock()
	{
	}

	[Token(Token = "0x6003E7C")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public static void CONSOLE_blueprint_grant()
	{
	}

	[Token(Token = "0x6003E7D")]
	[Address(RVA = "0xBB15C0", Offset = "0xBB03C0", Length = "0x1A5")]
	public static void CONSOLE_bow()
	{
	}

	[Token(Token = "0x6003E7E")]
	[Address(RVA = "0xBB1770", Offset = "0xBB0570", Length = "0x23E")]
	public static void CONSOLE_breakdown_all()
	{
	}

	[Token(Token = "0x6003E7F")]
	[Address(RVA = "0xBB19B0", Offset = "0xBB07B0", Length = "0x1CC")]
	public static void CONSOLE_buffs_add_all()
	{
	}

	[Token(Token = "0x6003E80")]
	[Address(RVA = "0xBB1B80", Offset = "0xBB0980", Length = "0x80")]
	public static void CONSOLE_buffs_lose_all()
	{
	}

	[Token(Token = "0x6003E81")]
	[Address(RVA = "0xBB1C10", Offset = "0xBB0A10", Length = "0xB9")]
	public static void CONSOLE_burns()
	{
	}

	[Token(Token = "0x6003E82")]
	[Address(RVA = "0xBB1CD0", Offset = "0xBB0AD0", Length = "0x5A")]
	public static void CONSOLE_burns_cure()
	{
	}

	[Token(Token = "0x6003E83")]
	[Address(RVA = "0xBB1D30", Offset = "0xBB0B30", Length = "0xBA")]
	public static void CONSOLE_burns_nofx()
	{
	}

	[Token(Token = "0x6003E84")]
	[Address(RVA = "0xBB1DF0", Offset = "0xBB0BF0", Length = "0x5D")]
	public static void CONSOLE_burns_electric()
	{
	}

	[Token(Token = "0x6003E85")]
	[Address(RVA = "0xBB1E50", Offset = "0xBB0C50", Length = "0x5A")]
	public static void CONSOLE_burns_electric_cure()
	{
	}

	[Token(Token = "0x6003E86")]
	[Address(RVA = "0xBB1EB0", Offset = "0xBB0CB0", Length = "0x5F")]
	public static void CONSOLE_burns_electric_nofx()
	{
	}

	[Token(Token = "0x6003E87")]
	[Address(RVA = "0xBB1F10", Offset = "0xBB0D10", Length = "0x124")]
	public static void CONSOLE_cabinfever()
	{
	}

	[Token(Token = "0x6003E88")]
	[Address(RVA = "0xBB2040", Offset = "0xBB0E40", Length = "0xA0")]
	public static void CONSOLE_cabinfever_cure()
	{
	}

	[Token(Token = "0x6003E89")]
	[Address(RVA = "0xBB20F0", Offset = "0xBB0EF0", Length = "0x126")]
	public static void CONSOLE_cabinfever_nofx()
	{
	}

	[Token(Token = "0x6003E8A")]
	[Address(RVA = "0xBB2220", Offset = "0xBB1020", Length = "0x224")]
	public static void CONSOLE_camera()
	{
	}

	[Token(Token = "0x6003E8B")]
	[Address(RVA = "0xBB2450", Offset = "0xBB1250", Length = "0xE7")]
	public static void CONSOLE_capture()
	{
	}

	[Token(Token = "0x6003E8C")]
	[Address(RVA = "0xBB2540", Offset = "0xBB1340", Length = "0xE6")]
	public static void CONSOLE_capture_anim()
	{
	}

	[Token(Token = "0x6003E8D")]
	[Address(RVA = "0xBB2630", Offset = "0xBB1430", Length = "0xDF")]
	public static void CONSOLE_capture_farclip()
	{
	}

	[Token(Token = "0x6003E8E")]
	[Address(RVA = "0xBB2710", Offset = "0xBB1510", Length = "0xF2")]
	public static void CONSOLE_carrion_stagger()
	{
	}

	[Token(Token = "0x6003E8F")]
	[Address(RVA = "0xBB2810", Offset = "0xBB1610", Length = "0x288")]
	public static void CONSOLE_flaregun()
	{
	}

	[Token(Token = "0x6003E90")]
	[Address(RVA = "0xBB2AA0", Offset = "0xBB18A0", Length = "0xE3")]
	public static void CONSOLE_capture_framerate()
	{
	}

	[Token(Token = "0x6003E91")]
	[Address(RVA = "0xBB2B90", Offset = "0xBB1990", Length = "0xE9")]
	public static void CONSOLE_capture_mode()
	{
	}

	[Token(Token = "0x6003E92")]
	[Address(RVA = "0xBB2C80", Offset = "0xBB1A80", Length = "0x7")]
	public static void CONSOLE_capture_toggle()
	{
	}

	[Token(Token = "0x6003E93")]
	[Address(RVA = "0xBB2C90", Offset = "0xBB1A90", Length = "0xB6")]
	public static void CONSOLE_capture_lighting()
	{
	}

	[Token(Token = "0x6003E94")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public static void CONSOLE_capture_lighting_all()
	{
	}

	[Token(Token = "0x6003E95")]
	[Address(RVA = "0xBB2D50", Offset = "0xBB1B50", Length = "0x142")]
	public static void CONSOLE_challenge_complete()
	{
	}

	[Token(Token = "0x6003E96")]
	[Address(RVA = "0xBB2EA0", Offset = "0xBB1CA0", Length = "0x581")]
	public static void CONSOLE_challenge_complete_all()
	{
	}

	[Token(Token = "0x6003E97")]
	[Address(RVA = "0xBB3430", Offset = "0xBB2230", Length = "0x1DE")]
	public static void CONSOLE_badges_list()
	{
	}

	[Token(Token = "0x6003E98")]
	[Address(RVA = "0xBB3610", Offset = "0xBB2410", Length = "0x165")]
	public static void CONSOLE_badges_lock()
	{
	}

	[Token(Token = "0x6003E99")]
	[Address(RVA = "0xBB3780", Offset = "0xBB2580", Length = "0xCC")]
	public static void CONSOLE_badge_lock_all()
	{
	}

	[Token(Token = "0x6003E9A")]
	[Address(RVA = "0xBB3850", Offset = "0xBB2650", Length = "0xD9")]
	public static void CONSOLE_character_splitstep_optimization()
	{
	}

	[Token(Token = "0x6003E9B")]
	[Address(RVA = "0xBB3930", Offset = "0xBB2730", Length = "0xE2")]
	public static void CONSOLE_cheat_death()
	{
	}

	[Token(Token = "0x6003E9C")]
	[Address(RVA = "0xBB3A20", Offset = "0xBB2820", Length = "0x5C")]
	public static void CONSOLE_cheat_death_cure()
	{
	}

	[Token(Token = "0x6003E9D")]
	[Address(RVA = "0xBB3A80", Offset = "0xBB2880", Length = "0x57")]
	public static void CONSOLE_chemhazard_add_affliction()
	{
	}

	[Token(Token = "0x6003E9E")]
	[Address(RVA = "0xBB3AE0", Offset = "0xBB28E0", Length = "0x95")]
	public static void CONSOLE_chemhazard_cure_all()
	{
	}

	[Token(Token = "0x6003E9F")]
	[Address(RVA = "0xBB3B80", Offset = "0xBB2980", Length = "0x57")]
	public static void CONSOLE_chemhazard_remove_affliction()
	{
	}

	[Token(Token = "0x6003EA0")]
	[Address(RVA = "0xBB3BE0", Offset = "0xBB29E0", Length = "0x61")]
	public static void CONSOLE_chemhazard_skip_delay()
	{
	}

	[Token(Token = "0x6003EA1")]
	[Address(RVA = "0xBB3C50", Offset = "0xBB2A50", Length = "0x3D8")]
	public static void CONSOLE_chroma_key_mode()
	{
	}

	[Token(Token = "0x6003EA2")]
	[Address(RVA = "0xBB4030", Offset = "0xBB2E30", Length = "0x7A")]
	public static void CONSOLE_clear_force_sleep_length()
	{
	}

	[Token(Token = "0x6003EA3")]
	[Address(RVA = "0xBB40B0", Offset = "0xBB2EB0", Length = "0x62")]
	public static void CONSOLE_clear_junk()
	{
	}

	[Token(Token = "0x6003EA4")]
	[Address(RVA = "0xBB4120", Offset = "0xBB2F20", Length = "0xCB")]
	public static void CONSOLE_close_ui()
	{
	}

	[Token(Token = "0x6003EA5")]
	[Address(RVA = "0xBB41F0", Offset = "0xBB2FF0", Length = "0x265")]
	public static void CONSOLE_container_test()
	{
	}

	[Token(Token = "0x6003EA6")]
	[Address(RVA = "0xBB4460", Offset = "0xBB3260", Length = "0xA8")]
	public static void CONSOLE_create_jump()
	{
	}

	[Token(Token = "0x6003EA7")]
	[Address(RVA = "0xBB4510", Offset = "0xBB3310", Length = "0x24F")]
	public static void CONSOLE_crow_flyover_test()
	{
	}

	[Token(Token = "0x6003EA8")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public static void CONSOLE_damage_multiplier()
	{
	}

	[Token(Token = "0x6003EA9")]
	[Address(RVA = "0xBB4760", Offset = "0xBB3560", Length = "0xD9")]
	public static void CONSOLE_debug_ai()
	{
	}

	[Token(Token = "0x6003EAA")]
	[Address(RVA = "0xBB4840", Offset = "0xBB3640", Length = "0xDC")]
	public static void CONSOLE_disable_ai()
	{
	}

	[Token(Token = "0x6003EAB")]
	[Address(RVA = "0xBB4920", Offset = "0xBB3720", Length = "0x45")]
	public static void CONSOLE_disable_invalid_ai()
	{
	}

	[Token(Token = "0x6003EAC")]
	[Address(RVA = "0xBB4970", Offset = "0xBB3770", Length = "0x1A4")]
	public static void CONSOLE_distance_field_shadows()
	{
	}

	[Token(Token = "0x6003EAD")]
	[Address(RVA = "0xBB4B20", Offset = "0xBB3920", Length = "0xDC")]
	public static void CONSOLE_debug_ai_states()
	{
	}

	[Token(Token = "0x6003EAE")]
	[Address(RVA = "0xBB4C00", Offset = "0xBB3A00", Length = "0xDC")]
	public static void CONSOLE_debug_ai_spawn()
	{
	}

	[Token(Token = "0x6003EAF")]
	[Address(RVA = "0xBB4CE0", Offset = "0xBB3AE0", Length = "0xE5")]
	public static void CONSOLE_debug_ats_verbose()
	{
	}

	[Token(Token = "0x6003EB0")]
	[Address(RVA = "0xBB4DD0", Offset = "0xBB3BD0", Length = "0xD9")]
	public static void Console_debug_allow_invalid_saves()
	{
	}

	[Token(Token = "0x6003EB1")]
	[Address(RVA = "0xBB4EB0", Offset = "0xBB3CB0", Length = "0xDC")]
	public static void CONSOLE_debug_bedroll_placement()
	{
	}

	[Token(Token = "0x6003EB2")]
	[Address(RVA = "0xBB4F90", Offset = "0xBB3D90", Length = "0xDC")]
	public static void CONSOLE_debug_navmesh()
	{
	}

	[Token(Token = "0x6003EB3")]
	[Address(RVA = "0xBB5070", Offset = "0xBB3E70", Length = "0xDC")]
	public static void CONSOLE_debug_ai_closestonly()
	{
	}

	[Token(Token = "0x6003EB4")]
	[Address(RVA = "0xBB5150", Offset = "0xBB3F50", Length = "0x1DF")]
	public static void CONSOLE_debug_asset_bundles()
	{
	}

	[Token(Token = "0x6003EB5")]
	[Address(RVA = "0xBB5330", Offset = "0xBB4130", Length = "0x169")]
	public static void CONSOLE_debug_ai_lite()
	{
	}

	[Token(Token = "0x6003EB6")]
	[Address(RVA = "0xBB54A0", Offset = "0xBB42A0", Length = "0xDC")]
	public static void CONSOLE_debug_spotlights()
	{
	}

	[Token(Token = "0x6003EB7")]
	[Address(RVA = "0xBB5580", Offset = "0xBB4380", Length = "0xA2")]
	public static void CONSOLE_debug_steampipes()
	{
	}

	[Token(Token = "0x6003EB8")]
	[Address(RVA = "0xBB5630", Offset = "0xBB4430", Length = "0x194")]
	public static void CONSOLE_debug_steampipebyname()
	{
	}

	[Token(Token = "0x6003EB9")]
	[Address(RVA = "0xBB57D0", Offset = "0xBB45D0", Length = "0xDC")]
	public static void CONSOLE_debug_bearhuntredux()
	{
	}

	[Token(Token = "0x6003EBA")]
	[Address(RVA = "0xBB58B0", Offset = "0xBB46B0", Length = "0xDC")]
	public static void CONSOLE_debug_camera()
	{
	}

	[Token(Token = "0x6003EBB")]
	[Address(RVA = "0xBB5990", Offset = "0xBB4790", Length = "0x57")]
	public static void CONSOLE_debug_clothing()
	{
	}

	[Token(Token = "0x6003EBC")]
	[Address(RVA = "0xBB59F0", Offset = "0xBB47F0", Length = "0x194")]
	public static void CONSOLE_debug_damage()
	{
	}

	[Token(Token = "0x6003EBD")]
	[Address(RVA = "0xBB5B90", Offset = "0xBB4990", Length = "0x88")]
	public static void CONSOLE_debug_decoration_item()
	{
	}

	[Token(Token = "0x6003EBE")]
	[Address(RVA = "0xBB5C20", Offset = "0xBB4A20", Length = "0x23")]
	public static void CONSOLE_debug_decoration_item_export()
	{
	}

	[Token(Token = "0x6003EBF")]
	[Address(RVA = "0xBB5C50", Offset = "0xBB4A50", Length = "0x29")]
	public static void CONSOLE_debug_decoration_item_next()
	{
	}

	[Token(Token = "0x6003EC0")]
	[Address(RVA = "0xBB5C80", Offset = "0xBB4A80", Length = "0xF2")]
	public static void CONSOLE_debug_dialogue()
	{
	}

	[Token(Token = "0x6003EC1")]
	[Address(RVA = "0xBB5D80", Offset = "0xBB4B80", Length = "0xEF")]
	public static void CONSOLE_debug_elevator()
	{
	}

	[Token(Token = "0x6003EC2")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public static void CONSOLE_debug_font_rendering()
	{
	}

	[Token(Token = "0x6003EC3")]
	[Address(RVA = "0xBB5E70", Offset = "0xBB4C70", Length = "0x25")]
	private static void OnFontRenderingPanelLoaded(Panel_Base panel)
	{
	}

	[Token(Token = "0x6003EC4")]
	[Address(RVA = "0xBB5EA0", Offset = "0xBB4CA0", Length = "0xF2")]
	public static void CONSOLE_debug_keyboard_shortcuts()
	{
	}

	[Token(Token = "0x6003EC5")]
	[Address(RVA = "0xBB5FA0", Offset = "0xBB4DA0", Length = "0xDC")]
	public static void CONSOLE_debug_loading_screen()
	{
	}

	[Token(Token = "0x6003EC6")]
	[Address(RVA = "0xBB6080", Offset = "0xBB4E80", Length = "0xDC")]
	public static void CONSOLE_debug_heavy_breathing()
	{
	}

	[Token(Token = "0x6003EC7")]
	[Address(RVA = "0xBB6160", Offset = "0xBB4F60", Length = "0xE5")]
	public static void CONSOLE_debug_panel_loading()
	{
	}

	[Token(Token = "0x6003EC8")]
	[Address(RVA = "0xBB6250", Offset = "0xBB5050", Length = "0xD9")]
	public static void CONSOLE_debug_phone()
	{
	}

	[Token(Token = "0x6003EC9")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public static void CONSOLE_debug_photo()
	{
	}

	[Token(Token = "0x6003ECA")]
	[Address(RVA = "0xBB6330", Offset = "0xBB5130", Length = "0xD9")]
	public static void CONSOLE_debug_placeable()
	{
	}

	[Token(Token = "0x6003ECB")]
	[Address(RVA = "0xBB6410", Offset = "0xBB5210", Length = "0xDC")]
	public static void CONSOLE_debug_player()
	{
	}

	[Token(Token = "0x6003ECC")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public static void CONSOLE_debug_player_interaction()
	{
	}

	[Token(Token = "0x6003ECD")]
	[Address(RVA = "0xBB64F0", Offset = "0xBB52F0", Length = "0x170")]
	public static void CONSOLE_debug_position()
	{
	}

	[Token(Token = "0x6003ECE")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public static void CONSOLE_debug_mission()
	{
	}

	[Token(Token = "0x6003ECF")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public static void CONSOLE_debug_noisemaker_radius()
	{
	}

	[Token(Token = "0x6003ED0")]
	[Address(RVA = "0xBB6670", Offset = "0xBB5470", Length = "0xA2")]
	public static void CONSOLE_debug_nowheretohide()
	{
	}

	[Token(Token = "0x6003ED1")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public static void CONSOLE_debug_npc()
	{
	}

	[Token(Token = "0x6003ED2")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public static void CONSOLE_debug_projectile()
	{
	}

	[Token(Token = "0x6003ED3")]
	[Address(RVA = "0xBB6720", Offset = "0xBB5520", Length = "0x165")]
	public static void CONSOLE_debug_radial_spawning()
	{
	}

	[Token(Token = "0x6003ED4")]
	[Address(RVA = "0xBB6890", Offset = "0xBB5690", Length = "0xA2")]
	public static void CONSOLE_debug_rockcache_placement()
	{
	}

	[Token(Token = "0x6003ED5")]
	[Address(RVA = "0xBB6940", Offset = "0xBB5740", Length = "0xD9")]
	public static void CONSOLE_debug_roi_lods()
	{
	}

	[Token(Token = "0x6003ED6")]
	[Address(RVA = "0xBB6A20", Offset = "0xBB5820", Length = "0x7B")]
	public static void CONSOLE_debug_raycast_jobs()
	{
	}

	[Token(Token = "0x6003ED7")]
	[Address(RVA = "0xBB6AA0", Offset = "0xBB58A0", Length = "0xE4")]
	private static void CONSOLE_debug_respirator()
	{
	}

	[Token(Token = "0x6003ED8")]
	[Address(RVA = "0xBB6B90", Offset = "0xBB5990", Length = "0xD9")]
	public static void CONSOLE_debug_safehouse()
	{
	}

	[Token(Token = "0x6003ED9")]
	[Address(RVA = "0xBB6C70", Offset = "0xBB5A70", Length = "0xDC")]
	public static void CONSOLE_debug_story_hud()
	{
	}

	[Token(Token = "0x6003EDA")]
	[Address(RVA = "0xBB6D50", Offset = "0xBB5B50", Length = "0x104")]
	public static void CONSOLE_debug_struggle()
	{
	}

	[Token(Token = "0x6003EDB")]
	[Address(RVA = "0xBB6E60", Offset = "0xBB5C60", Length = "0x45")]
	public static void CONSOLE_debug_text_hide()
	{
	}

	[Token(Token = "0x6003EDC")]
	[Address(RVA = "0xBB6EB0", Offset = "0xBB5CB0", Length = "0x45")]
	public static void CONSOLE_debug_text_show()
	{
	}

	[Token(Token = "0x6003EDD")]
	[Address(RVA = "0xBB6F00", Offset = "0xBB5D00", Length = "0xDC")]
	public static void CONSOLE_debug_timer()
	{
	}

	[Token(Token = "0x6003EDE")]
	[Address(RVA = "0xBB6FE0", Offset = "0xBB5DE0", Length = "0xDC")]
	public static void CONSOLE_debug_high_resolution_timer()
	{
	}

	[Token(Token = "0x6003EDF")]
	[Address(RVA = "0xBB70C0", Offset = "0xBB5EC0", Length = "0x246")]
	public static void CONSOLE_debug_view_mode()
	{
	}

	[Token(Token = "0x6003EE0")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public static void CONSOLE_debug_voice_ui()
	{
	}

	[Token(Token = "0x6003EE1")]
	[Address(RVA = "0xBB7310", Offset = "0xBB6110", Length = "0xDC")]
	public static void CONSOLE_debug_voice_verbose()
	{
	}

	[Token(Token = "0x6003EE2")]
	[Address(RVA = "0xBB73F0", Offset = "0xBB61F0", Length = "0xF2")]
	public static void CONSOLE_debug_weather()
	{
	}

	[Token(Token = "0x6003EE3")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public static void CONSOLE_debug_wolfhowl()
	{
	}

	[Token(Token = "0x6003EE4")]
	[Address(RVA = "0xBB74F0", Offset = "0xBB62F0", Length = "0xAF")]
	public static void CONSOLE_decayscale()
	{
	}

	[Token(Token = "0x6003EE5")]
	[Address(RVA = "0xBB75A0", Offset = "0xBB63A0", Length = "0xF2")]
	public static void CONSOLE_deferred_rendering()
	{
	}

	[Token(Token = "0x6003EE6")]
	[Address(RVA = "0xBB76A0", Offset = "0xBB64A0", Length = "0x2AB")]
	public static void CONSOLE_dialogue_assign()
	{
	}

	[Token(Token = "0x6003EE7")]
	[Address(RVA = "0xBB7950", Offset = "0xBB6750", Length = "0x1D8")]
	public static void CONSOLE_dialogue_logchoices()
	{
	}

	[Token(Token = "0x6003EE8")]
	[Address(RVA = "0xBB7B30", Offset = "0xBB6930", Length = "0x1EA")]
	public static void CONSOLE_dialogue_setanimationstate()
	{
	}

	[Token(Token = "0x6003EE9")]
	[Address(RVA = "0xBB7D20", Offset = "0xBB6B20", Length = "0x30D")]
	public static void CONSOLE_dialogue_setanimationparameter()
	{
	}

	[Token(Token = "0x6003EEA")]
	[Address(RVA = "0xBB8030", Offset = "0xBB6E30", Length = "0x1BE")]
	public static void CONSOLE_dialogue_setframing()
	{
	}

	[Token(Token = "0x6003EEB")]
	[Address(RVA = "0xBB81F0", Offset = "0xBB6FF0", Length = "0xA6")]
	public static void CONSOLE_diminished_state()
	{
	}

	[Token(Token = "0x6003EEC")]
	[Address(RVA = "0xBB82A0", Offset = "0xBB70A0", Length = "0x5C")]
	public static void CONSOLE_diminished_state_cure()
	{
	}

	[Token(Token = "0x6003EED")]
	[Address(RVA = "0xBB8300", Offset = "0xBB7100", Length = "0xB5C")]
	public static void CONSOLE_dump_mission_objects()
	{
	}

	[Token(Token = "0x6003EEE")]
	[Address(RVA = "0xBB8E60", Offset = "0xBB7C60", Length = "0xF7")]
	public static void CONSOLE_dump_weapon_ids()
	{
	}

	[Token(Token = "0x6003EEF")]
	[Address(RVA = "0xBB8F60", Offset = "0xBB7D60", Length = "0xA3")]
	public static void CONSOLE_dynamic_resolution_set_scale()
	{
	}

	[Token(Token = "0x6003EF0")]
	[Address(RVA = "0xBB9010", Offset = "0xBB7E10", Length = "0xAA")]
	public static void CONSOLE_dynamic_resolution_set_framerate_target()
	{
	}

	[Token(Token = "0x6003EF1")]
	[Address(RVA = "0xBB90C0", Offset = "0xBB7EC0", Length = "0x5D")]
	public static void CONSOLE_dysentery()
	{
	}

	[Token(Token = "0x6003EF2")]
	[Address(RVA = "0xBB9120", Offset = "0xBB7F20", Length = "0x5A")]
	public static void CONSOLE_dysentery_cure()
	{
	}

	[Token(Token = "0x6003EF3")]
	[Address(RVA = "0xBB9180", Offset = "0xBB7F80", Length = "0x5F")]
	public static void CONSOLE_dysentery_nofx()
	{
	}

	[Token(Token = "0x6003EF4")]
	[Address(RVA = "0xBB91E0", Offset = "0xBB7FE0", Length = "0xB2")]
	public static void CONSOLE_fade_in()
	{
	}

	[Token(Token = "0x6003EF5")]
	[Address(RVA = "0xBB92A0", Offset = "0xBB80A0", Length = "0x97")]
	public static void CONSOLE_fade_out_immediate()
	{
	}

	[Token(Token = "0x6003EF6")]
	[Address(RVA = "0xBB9340", Offset = "0xBB8140", Length = "0xB2")]
	public static void CONSOLE_fade_out()
	{
	}

	[Token(Token = "0x6003EF7")]
	[Address(RVA = "0xBB9400", Offset = "0xBB8200", Length = "0x91")]
	public static void CONSOLE_cinematic_fade_blackout()
	{
	}

	[Token(Token = "0x6003EF8")]
	[Address(RVA = "0xBB94A0", Offset = "0xBB82A0", Length = "0x10B")]
	public static void CONSOLE_fancy()
	{
	}

	[Token(Token = "0x6003EF9")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public static void CONSOLE_fatigue_locked()
	{
	}

	[Token(Token = "0x6003EFA")]
	[Address(RVA = "0xBB95B0", Offset = "0xBB83B0", Length = "0xB6")]
	public static void CONSOLE_farclip()
	{
	}

	[Token(Token = "0x6003EFB")]
	[Address(RVA = "0xBB9670", Offset = "0xBB8470", Length = "0x60")]
	public static void CONSOLE_feat_booksmarts()
	{
	}

	[Token(Token = "0x6003EFC")]
	[Address(RVA = "0xBB96D0", Offset = "0xBB84D0", Length = "0x62")]
	public static void CONSOLE_feat_coldfusion()
	{
	}

	[Token(Token = "0x6003EFD")]
	[Address(RVA = "0xBB9740", Offset = "0xBB8540", Length = "0x62")]
	public static void CONSOLE_feat_efficientmachine()
	{
	}

	[Token(Token = "0x6003EFE")]
	[Address(RVA = "0xBB97B0", Offset = "0xBB85B0", Length = "0x62")]
	public static void CONSOLE_feat_firemaster()
	{
	}

	[Token(Token = "0x6003EFF")]
	[Address(RVA = "0xBB9820", Offset = "0xBB8620", Length = "0x62")]
	public static void CONSOLE_feat_freerunner()
	{
	}

	[Token(Token = "0x6003F00")]
	[Address(RVA = "0xBB9890", Offset = "0xBB8690", Length = "0x62")]
	public static void CONSOLE_feat_snowwalker()
	{
	}

	[Token(Token = "0x6003F01")]
	[Address(RVA = "0xBB9900", Offset = "0xBB8700", Length = "0x62")]
	public static void CONSOLE_feat_experttrapper()
	{
	}

	[Token(Token = "0x6003F02")]
	[Address(RVA = "0xBB9970", Offset = "0xBB8770", Length = "0x62")]
	public static void CONSOLE_feat_straighttoheart()
	{
	}

	[Token(Token = "0x6003F03")]
	[Address(RVA = "0xBB99E0", Offset = "0xBB87E0", Length = "0x62")]
	public static void CONSOLE_feat_blizzardwalker()
	{
	}

	[Token(Token = "0x6003F04")]
	[Address(RVA = "0xBB9A50", Offset = "0xBB8850", Length = "0x62")]
	public static void CONSOLE_feat_nightwalker()
	{
	}

	[Token(Token = "0x6003F05")]
	[Address(RVA = "0xBB9AC0", Offset = "0xBB88C0", Length = "0x62")]
	public static void CONSOLE_feat_masterhunter()
	{
	}

	[Token(Token = "0x6003F06")]
	[Address(RVA = "0xBB9B30", Offset = "0xBB8930", Length = "0x62")]
	public static void CONSOLE_feat_settledmind()
	{
	}

	[Token(Token = "0x6003F07")]
	[Address(RVA = "0xBB9BA0", Offset = "0xBB89A0", Length = "0x62")]
	public static void CONSOLE_feat_celestialnavigator()
	{
	}

	[Token(Token = "0x6003F08")]
	[Address(RVA = "0xBB9C10", Offset = "0xBB8A10", Length = "0x649")]
	public static void CONSOLE_feat_set_enabled()
	{
	}

	[Token(Token = "0x6003F09")]
	[Address(RVA = "0xBBA260", Offset = "0xBB9060", Length = "0x3F4")]
	public static void CONSOLE_feat_unlock_all()
	{
	}

	[Token(Token = "0x6003F0A")]
	[Address(RVA = "0xBBA660", Offset = "0xBB9460", Length = "0x7D")]
	public static void CONSOLE_food_poison()
	{
	}

	[Token(Token = "0x6003F0B")]
	[Address(RVA = "0xBBA6E0", Offset = "0xBB94E0", Length = "0xFA")]
	public static void CONSOLE_force_electrostatic_fog()
	{
	}

	[Token(Token = "0x6003F0C")]
	[Address(RVA = "0xBBA7E0", Offset = "0xBB95E0", Length = "0x121")]
	public static void CONSOLE_force_aurora()
	{
	}

	[Token(Token = "0x6003F0D")]
	[Address(RVA = "0xBBA910", Offset = "0xBB9710", Length = "0xEC")]
	public static void CONSOLE_force_aurora_immediate()
	{
	}

	[Token(Token = "0x6003F0E")]
	[Address(RVA = "0xBBAA00", Offset = "0xBB9800", Length = "0x153")]
	public static void CONSOLE_force_aurora_duration()
	{
	}

	[Token(Token = "0x6003F0F")]
	[Address(RVA = "0xBBAB60", Offset = "0xBB9960", Length = "0x1A9")]
	public static void CONSOLE_enable_aurorafields()
	{
	}

	[Token(Token = "0x6003F10")]
	[Address(RVA = "0xBBAD10", Offset = "0xBB9B10", Length = "0x1B8")]
	public static void CONSOLE_enable_customizing()
	{
	}

	[Token(Token = "0x6003F11")]
	[Address(RVA = "0xBBAED0", Offset = "0xBB9CD0", Length = "0xAD")]
	public static void CONSOLE_enable_saveload()
	{
	}

	[Token(Token = "0x6003F12")]
	[Address(RVA = "0xBBAF80", Offset = "0xBB9D80", Length = "0x14D")]
	public static void CONSOLE_episode_complete()
	{
	}

	[Token(Token = "0x6003F13")]
	[Address(RVA = "0xBBB0D0", Offset = "0xBB9ED0", Length = "0xF5")]
	public static void CONSOLE_episode_unlock()
	{
	}

	[Token(Token = "0x6003F14")]
	[Address(RVA = "0xBBB1D0", Offset = "0xBB9FD0", Length = "0x163")]
	public static void CONSOLE_force_crouch()
	{
	}

	[Token(Token = "0x6003F15")]
	[Address(RVA = "0xBBB340", Offset = "0xBBA140", Length = "0xED")]
	public static void CONSOLE_force_limp()
	{
	}

	[Token(Token = "0x6003F16")]
	[Address(RVA = "0xBBB430", Offset = "0xBBA230", Length = "0xEC")]
	public static void CONSOLE_force_limp_slow()
	{
	}

	[Token(Token = "0x6003F17")]
	[Address(RVA = "0xBBB520", Offset = "0xBBA320", Length = "0xD4")]
	public static void CONSOLE_disable_procedural_instancing()
	{
	}

	[Token(Token = "0x6003F18")]
	[Address(RVA = "0xBBB600", Offset = "0xBBA400", Length = "0x123")]
	public static void CONSOLE_dlc_can_use_content()
	{
	}

	[Token(Token = "0x6003F19")]
	[Address(RVA = "0xBBB730", Offset = "0xBBA530", Length = "0x393")]
	public static void CONSOLE_dlc_list_known_content()
	{
	}

	[Token(Token = "0x6003F1A")]
	[Address(RVA = "0xBBBAD0", Offset = "0xBBA8D0", Length = "0x3CE")]
	public static void CONSOLE_dlc_list_available_content()
	{
	}

	[Token(Token = "0x6003F1B")]
	[Address(RVA = "0xBBBEA0", Offset = "0xBBACA0", Length = "0xC2")]
	public static void CONSOLE_dlc_open_content_in_store()
	{
	}

	[Token(Token = "0x6003F1C")]
	[Address(RVA = "0xBBBF70", Offset = "0xBBAD70", Length = "0xD9")]
	public static void CONSOLE_force_no_random_sprain()
	{
	}

	[Token(Token = "0x6003F1D")]
	[Address(RVA = "0xBBC050", Offset = "0xBBAE50", Length = "0xFD")]
	public static void CONSOLE_force_jam()
	{
	}

	[Token(Token = "0x6003F1E")]
	[Address(RVA = "0xBBC150", Offset = "0xBBAF50", Length = "0xFD")]
	public static void CONSOLE_force_no_jam()
	{
	}

	[Token(Token = "0x6003F1F")]
	[Address(RVA = "0xBBC250", Offset = "0xBBB050", Length = "0xD9")]
	public static void CONSOLE_force_no_sprainwrist()
	{
	}

	[Token(Token = "0x6003F20")]
	[Address(RVA = "0xBBC330", Offset = "0xBBB130", Length = "0xEB")]
	public static void CONSOLE_force_walk()
	{
	}

	[Token(Token = "0x6003F21")]
	[Address(RVA = "0xBBC420", Offset = "0xBBB220", Length = "0xF8")]
	public static void CONSOLE_force_gear_weight()
	{
	}

	[Token(Token = "0x6003F22")]
	[Address(RVA = "0xBBC520", Offset = "0xBBB320", Length = "0x12F")]
	public static void CONSOLE_force_howl()
	{
	}

	[Token(Token = "0x6003F23")]
	[Address(RVA = "0xBBC650", Offset = "0xBBB450", Length = "0xAC")]
	public static void CONSOLE_reset_forced_gear_weight()
	{
	}

	[Token(Token = "0x6003F24")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public static void CONSOLE_reset_steam_achievements()
	{
	}

	[Token(Token = "0x6003F25")]
	[Address(RVA = "0xBBC700", Offset = "0xBBB500", Length = "0x45")]
	public static void CONSOLE_respirator_canister_expire()
	{
	}

	[Token(Token = "0x6003F26")]
	[Address(RVA = "0xBBC750", Offset = "0xBBB550", Length = "0xD7")]
	public static void CONSOLE_force_fire_starting_success()
	{
	}

	[Token(Token = "0x6003F27")]
	[Address(RVA = "0xBBC830", Offset = "0xBBB630", Length = "0xE5")]
	public static void CONSOLE_force_gc()
	{
	}

	[Token(Token = "0x6003F28")]
	[Address(RVA = "0xBBC920", Offset = "0xBBB720", Length = "0xE5")]
	public static void CONSOLE_force_gc_verbose()
	{
	}

	[Token(Token = "0x6003F29")]
	[Address(RVA = "0xBBCA10", Offset = "0xBBB810", Length = "0xA2")]
	public static void CONSOLE_force_skip_enabled()
	{
	}

	[Token(Token = "0x6003F2A")]
	[Address(RVA = "0xBBCAC0", Offset = "0xBBB8C0", Length = "0xD4")]
	public static void CONSOLE_force_mobility_reduction()
	{
	}

	[Token(Token = "0x6003F2B")]
	[Address(RVA = "0xBBCBA0", Offset = "0xBBB9A0", Length = "0x1D9")]
	public static void CONSOLE_force_sleep_length()
	{
	}

	[Token(Token = "0x6003F2C")]
	[Address(RVA = "0xBBCD80", Offset = "0xBBBB80", Length = "0xB0")]
	public static void CONSOLE_fog_scale()
	{
	}

	[Token(Token = "0x6003F2D")]
	[Address(RVA = "0xBBCE30", Offset = "0xBBBC30", Length = "0x5A")]
	public static void CONSOLE_food_poison_cure()
	{
	}

	[Token(Token = "0x6003F2E")]
	[Address(RVA = "0xBBCE90", Offset = "0xBBBC90", Length = "0x7E")]
	public static void CONSOLE_food_poison_nofx()
	{
	}

	[Token(Token = "0x6003F2F")]
	[Address(RVA = "0xBBCF10", Offset = "0xBBBD10", Length = "0xF2")]
	public static void CONSOLE_forward_rendering()
	{
	}

	[Token(Token = "0x6003F30")]
	[Address(RVA = "0xBBD010", Offset = "0xBBBE10", Length = "0x7E")]
	public static void CONSOLE_fphands()
	{
	}

	[Token(Token = "0x6003F31")]
	[Address(RVA = "0xBBD090", Offset = "0xBBBE90", Length = "0xBF")]
	public static void CONSOLE_fphands_mesh()
	{
	}

	[Token(Token = "0x6003F32")]
	[Address(RVA = "0xBBD150", Offset = "0xBBBF50", Length = "0xE0")]
	public static void CONSOLE_framerate_cap()
	{
	}

	[Token(Token = "0x6003F33")]
	[Address(RVA = "0xBBD240", Offset = "0xBBC040", Length = "0xA4")]
	public static void CONSOLE_frostbite()
	{
	}

	[Token(Token = "0x6003F34")]
	[Address(RVA = "0xBBD2F0", Offset = "0xBBC0F0", Length = "0x57")]
	public static void CONSOLE_frostbite_cure()
	{
	}

	[Token(Token = "0x6003F35")]
	[Address(RVA = "0xBBD350", Offset = "0xBBC150", Length = "0xA5")]
	public static void CONSOLE_frostbite_nofx()
	{
	}

	[Token(Token = "0x6003F36")]
	[Address(RVA = "0xBBD400", Offset = "0xBBC200", Length = "0x348")]
	public static void CONSOLE_achievement_unlock()
	{
	}

	[Token(Token = "0x6003F37")]
	[Address(RVA = "0xBBD750", Offset = "0xBBC550", Length = "0x115")]
	public static void CONSOLE_achievement_list()
	{
	}

	[Token(Token = "0x6003F38")]
	[Address(RVA = "0xBBD870", Offset = "0xBBC670", Length = "0xDC")]
	public static void CONSOLE_achievement_verbose_log()
	{
	}

	[Token(Token = "0x6003F39")]
	[Address(RVA = "0xBBD950", Offset = "0xBBC750", Length = "0x469")]
	public static void CONSOLE_gear_add()
	{
	}

	[Token(Token = "0x6003F3A")]
	[Address(RVA = "0xBBDDC0", Offset = "0xBBCBC0", Length = "0x5B1")]
	public static void CONSOLE_gear_add_type()
	{
	}

	[Token(Token = "0x6003F3B")]
	[Address(RVA = "0xBBE380", Offset = "0xBBD180", Length = "0x83")]
	public static object CONSOLE_get_cold()
	{
		return null;
	}

	[Token(Token = "0x6003F3C")]
	[Address(RVA = "0xBBE410", Offset = "0xBBD210", Length = "0x6A")]
	public static object CONSOLE_get_condition()
	{
		return null;
	}

	[Token(Token = "0x6003F3D")]
	[Address(RVA = "0xBBE480", Offset = "0xBBD280", Length = "0x83")]
	public static object CONSOLE_get_fatigue()
	{
		return null;
	}

	[Token(Token = "0x6003F3E")]
	[Address(RVA = "0xBBE510", Offset = "0xBBD310", Length = "0x8B")]
	public static object CONSOLE_get_hunger()
	{
		return null;
	}

	[Token(Token = "0x6003F3F")]
	[Address(RVA = "0xBBE5A0", Offset = "0xBBD3A0", Length = "0x6D")]
	public static object CONSOLE_get_stamina()
	{
		return null;
	}

	[Token(Token = "0x6003F40")]
	[Address(RVA = "0xBBE610", Offset = "0xBBD410", Length = "0x83")]
	public static object CONSOLE_get_thirst()
	{
		return null;
	}

	[Token(Token = "0x6003F41")]
	[Address(RVA = "0xBBE6A0", Offset = "0xBBD4A0", Length = "0x34C")]
	public static object CONSOLE_get_game_state()
	{
		return null;
	}

	[Token(Token = "0x6003F42")]
	[Address(RVA = "0xBBE9F0", Offset = "0xBBD7F0", Length = "0x104")]
	public static void CONSOLE_ghost()
	{
	}

	[Token(Token = "0x6003F43")]
	[Address(RVA = "0xBBEB00", Offset = "0xBBD900", Length = "0x303")]
	public static void CONSOLE_god()
	{
	}

	[Token(Token = "0x6003F44")]
	[Address(RVA = "0xBBEE10", Offset = "0xBBDC10", Length = "0xC4")]
	public static void CONSOLE_fly()
	{
	}

	[Token(Token = "0x6003F45")]
	[Address(RVA = "0xBBEEE0", Offset = "0xBBDCE0", Length = "0x332")]
	public static void CONSOLE_lock_camera()
	{
	}

	[Token(Token = "0x6003F46")]
	[Address(RVA = "0xBBF220", Offset = "0xBBE020", Length = "0x7F")]
	public static void CONSOLE_exception_test()
	{
	}

	[Token(Token = "0x6003F47")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public static void CONSOLE_graphics_version()
	{
	}

	[Token(Token = "0x6003F48")]
	[Address(RVA = "0xBBF2A0", Offset = "0xBBE0A0", Length = "0xF2")]
	public static void CONSOLE_hide_testbuild_watermark()
	{
	}

	[Token(Token = "0x6003F49")]
	[Address(RVA = "0xBBF3A0", Offset = "0xBBE1A0", Length = "0x2DC")]
	public static void CONSOLE_hunted2_endgame()
	{
	}

	[Token(Token = "0x6003F4A")]
	[Address(RVA = "0xBBF680", Offset = "0xBBE480", Length = "0xB7")]
	public static void CONSOLE_hypothermia()
	{
	}

	[Token(Token = "0x6003F4B")]
	[Address(RVA = "0xBBF740", Offset = "0xBBE540", Length = "0x5A")]
	public static void CONSOLE_hypothermia_cure()
	{
	}

	[Token(Token = "0x6003F4C")]
	[Address(RVA = "0xBBF7A0", Offset = "0xBBE5A0", Length = "0xB8")]
	public static void CONSOLE_hypothermia_nofx()
	{
	}

	[Token(Token = "0x6003F4D")]
	[Address(RVA = "0xBBF860", Offset = "0xBBE660", Length = "0xB0")]
	public static void CONSOLE_invisibleentity_countdown()
	{
	}

	[Token(Token = "0x6003F4E")]
	[Address(RVA = "0xBBF920", Offset = "0xBBE720", Length = "0xD9")]
	public static void CONSOLE_invisibleentity_pause()
	{
	}

	[Token(Token = "0x6003F4F")]
	[Address(RVA = "0xBBFA00", Offset = "0xBBE800", Length = "0x92")]
	public static void CONSOLE_invisibleentity_spawn()
	{
	}

	[Token(Token = "0x6003F50")]
	[Address(RVA = "0xBBFAA0", Offset = "0xBBE8A0", Length = "0x19D")]
	public static void CONSOLE_invisibleentity_addspace()
	{
	}

	[Token(Token = "0x6003F51")]
	[Address(RVA = "0xBBFC40", Offset = "0xBBEA40", Length = "0x5A")]
	public static void CONSOLE_invisibleentity_near()
	{
	}

	[Token(Token = "0x6003F52")]
	[Address(RVA = "0xBBFCA0", Offset = "0xBBEAA0", Length = "0x5A")]
	public static void CONSOLE_invisibleentity_far()
	{
	}

	[Token(Token = "0x6003F53")]
	[Address(RVA = "0xBBFD00", Offset = "0xBBEB00", Length = "0xB3")]
	public static void CONSOLE_invisibleentity_speed()
	{
	}

	[Token(Token = "0x6003F54")]
	[Address(RVA = "0xBBFDC0", Offset = "0xBBEBC0", Length = "0xBF")]
	public static void CONSOLE_infection()
	{
	}

	[Token(Token = "0x6003F55")]
	[Address(RVA = "0xBBFE80", Offset = "0xBBEC80", Length = "0x57")]
	public static void CONSOLE_infection_cure()
	{
	}

	[Token(Token = "0x6003F56")]
	[Address(RVA = "0xBBFEE0", Offset = "0xBBECE0", Length = "0xBF")]
	public static void CONSOLE_infection_nofx()
	{
	}

	[Token(Token = "0x6003F57")]
	[Address(RVA = "0xBBFFA0", Offset = "0xBBEDA0", Length = "0xBF")]
	public static void CONSOLE_infection_risk()
	{
	}

	[Token(Token = "0x6003F58")]
	[Address(RVA = "0xBC0060", Offset = "0xBBEE60", Length = "0xBF")]
	public static void CONSOLE_infection_risk_constant()
	{
	}

	[Token(Token = "0x6003F59")]
	[Address(RVA = "0xBC0120", Offset = "0xBBEF20", Length = "0x57")]
	public static void CONSOLE_infection_risk_cure()
	{
	}

	[Token(Token = "0x6003F5A")]
	[Address(RVA = "0xBC0180", Offset = "0xBBEF80", Length = "0xBF")]
	public static void CONSOLE_infection_risk_nofx()
	{
	}

	[Token(Token = "0x6003F5B")]
	[Address(RVA = "0xBC0240", Offset = "0xBBF040", Length = "0xF8")]
	public static void CONSOLE_inhibit_toxicfog_headache()
	{
	}

	[Token(Token = "0x6003F5C")]
	[Address(RVA = "0xBC0340", Offset = "0xBBF140", Length = "0xD9")]
	public static void CONSOLE_input_lock_controlscheme()
	{
	}

	[Token(Token = "0x6003F5D")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public static void CONSOLE_input_force_platform_ui()
	{
	}

	[Token(Token = "0x6003F5E")]
	[Address(RVA = "0xBC0420", Offset = "0xBBF220", Length = "0x104")]
	public static void CONSOLE_invulnerable()
	{
	}

	[Token(Token = "0x6003F5F")]
	[Address(RVA = "0xBC0530", Offset = "0xBBF330", Length = "0xD9")]
	public static void CONSOLE_json_net_serialization()
	{
	}

	[Token(Token = "0x6003F60")]
	[Address(RVA = "0xBC0610", Offset = "0xBBF410", Length = "0x45")]
	public static void CONSOLE_knowledge_dump()
	{
	}

	[Token(Token = "0x6003F61")]
	[Address(RVA = "0xBC0660", Offset = "0xBBF460", Length = "0xD8")]
	public static void CONSOLE_knowledge_unlock()
	{
	}

	[Token(Token = "0x6003F62")]
	[Address(RVA = "0xBC0740", Offset = "0xBBF540", Length = "0xD6")]
	public static void CONSOLE_lampinfinite()
	{
	}

	[Token(Token = "0x6003F63")]
	[Address(RVA = "0xBC0820", Offset = "0xBBF620", Length = "0x365")]
	public static void CONSOLE_lang()
	{
	}

	[Token(Token = "0x6003F64")]
	[Address(RVA = "0xBC0B90", Offset = "0xBBF990", Length = "0x43")]
	public static void CONSOLE_life_after_death()
	{
	}

	[Token(Token = "0x6003F65")]
	[Address(RVA = "0xBC0BE0", Offset = "0xBBF9E0", Length = "0x1B3")]
	public static void CONSOLE_lighting_preview()
	{
	}

	[Token(Token = "0x6003F66")]
	[Address(RVA = "0xBC0DA0", Offset = "0xBBFBA0", Length = "0x34D")]
	public static void CONSOLE_list_unexplored_interiors()
	{
	}

	[Token(Token = "0x6003F67")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public static void CONSOLE_list_photos()
	{
	}

	[Token(Token = "0x6003F68")]
	[Address(RVA = "0xBC10F0", Offset = "0xBBFEF0", Length = "0xD6")]
	public static void CONSOLE_loadfadeout()
	{
	}

	[Token(Token = "0x6003F69")]
	[Address(RVA = "0xBC11D0", Offset = "0xBBFFD0", Length = "0xC1")]
	public static void CONSOLE_loadpriority()
	{
	}

	[Token(Token = "0x6003F6A")]
	[Address(RVA = "0xBC12A0", Offset = "0xBC00A0", Length = "0xED")]
	public static void CONSOLE_lock_player()
	{
	}

	[Token(Token = "0x6003F6B")]
	[Address(RVA = "0xBC1390", Offset = "0xBC0190", Length = "0x2D0")]
	private static void CONSOLE_lock_region()
	{
	}

	[Token(Token = "0x6003F6C")]
	[Address(RVA = "0xBC1670", Offset = "0xBC0470", Length = "0x2F4")]
	private static void CONSOLE_unlock_region()
	{
	}

	[Token(Token = "0x6003F6D")]
	[Address(RVA = "0xBC1970", Offset = "0xBC0770", Length = "0xB1")]
	public static void CONSOLE_lock_temperature()
	{
	}

	[Token(Token = "0x6003F6E")]
	[Address(RVA = "0xBC1A30", Offset = "0xBC0830", Length = "0x159")]
	public static void CONSOLE_lock_weather()
	{
	}

	[Token(Token = "0x6003F6F")]
	[Address(RVA = "0xBC1B90", Offset = "0xBC0990", Length = "0x10C")]
	public static void CONSOLE_lock_weather_instant()
	{
	}

	[Token(Token = "0x6003F70")]
	[Address(RVA = "0xBC1CA0", Offset = "0xBC0AA0", Length = "0xB1")]
	public static void CONSOLE_lock_wind_instant()
	{
	}

	[Token(Token = "0x6003F71")]
	[Address(RVA = "0xBC1D60", Offset = "0xBC0B60", Length = "0xB3")]
	public static void CONSOLE_lod_bias()
	{
	}

	[Token(Token = "0x6003F72")]
	[Address(RVA = "0xBC1E20", Offset = "0xBC0C20", Length = "0x52A")]
	public static void CONSOLE_log_all_faithful_cartographer()
	{
	}

	[Token(Token = "0x6003F73")]
	[Address(RVA = "0xBC2350", Offset = "0xBC1150", Length = "0xF7")]
	public static void CONSOLE_log_faithful_cartographer()
	{
	}

	[Token(Token = "0x6003F74")]
	[Address(RVA = "0xBC2450", Offset = "0xBC1250", Length = "0xA2")]
	public static void CONSOLE_menublur()
	{
	}

	[Token(Token = "0x6003F75")]
	[Address(RVA = "0xBC2500", Offset = "0xBC1300", Length = "0x1AB")]
	public static void CONSOLE_makestrugglepartnerflee()
	{
	}

	[Token(Token = "0x6003F76")]
	[Address(RVA = "0xBC26B0", Offset = "0xBC14B0", Length = "0x114")]
	public static void CONSOLE_mission_jump()
	{
	}

	[Token(Token = "0x6003F77")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public static void CONSOLE_misery_debug()
	{
	}

	[Token(Token = "0x6003F78")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public static void CONSOLE_misery_force_stage()
	{
	}

	[Token(Token = "0x6003F79")]
	[Address(RVA = "0xBC27D0", Offset = "0xBC15D0", Length = "0xDA")]
	public static void CONSOLE_mission_add()
	{
	}

	[Token(Token = "0x6003F7A")]
	[Address(RVA = "0xBC28B0", Offset = "0xBC16B0", Length = "0x12B")]
	public static void CONSOLE_mission_complete()
	{
	}

	[Token(Token = "0x6003F7B")]
	[Address(RVA = "0xBC29E0", Offset = "0xBC17E0", Length = "0xE4")]
	public static void CONSOLE_mission_objective_complete()
	{
	}

	[Token(Token = "0x6003F7C")]
	[Address(RVA = "0xBC2AD0", Offset = "0xBC18D0", Length = "0x9E")]
	public static void CONSOLE_mission_remove()
	{
	}

	[Token(Token = "0x6003F7D")]
	[Address(RVA = "0xBC2B70", Offset = "0xBC1970", Length = "0x174")]
	public static object CONSOLE_is_mission_active()
	{
		return null;
	}

	[Token(Token = "0x6003F7E")]
	[Address(RVA = "0xBC2CF0", Offset = "0xBC1AF0", Length = "0x9B")]
	public static void CONSOLE_mission_add_filter_tags()
	{
	}

	[Token(Token = "0x6003F7F")]
	[Address(RVA = "0xBC2D90", Offset = "0xBC1B90", Length = "0x9B")]
	public static void CONSOLE_mission_remove_filter_tags()
	{
	}

	[Token(Token = "0x6003F80")]
	[Address(RVA = "0xBC2E30", Offset = "0xBC1C30", Length = "0x1B5")]
	public static void CONSOLE_next_weather()
	{
	}

	[Token(Token = "0x6003F81")]
	[Address(RVA = "0xBC2FF0", Offset = "0xBC1DF0", Length = "0x67")]
	public static void CONSOLE_next_weatherset()
	{
	}

	[Token(Token = "0x6003F82")]
	[Address(RVA = "0xBC3060", Offset = "0xBC1E60", Length = "0x104")]
	public static void CONSOLE_neverdie()
	{
	}

	[Token(Token = "0x6003F83")]
	[Address(RVA = "0xBC3170", Offset = "0xBC1F70", Length = "0x267")]
	public static void CONSOLE_npc_conditionupdate()
	{
	}

	[Token(Token = "0x6003F84")]
	[Address(RVA = "0xBC33E0", Offset = "0xBC21E0", Length = "0x21B")]
	public static void CONSOLE_npc_bloodloss()
	{
	}

	[Token(Token = "0x6003F85")]
	[Address(RVA = "0xBC3600", Offset = "0xBC2400", Length = "0xD9")]
	public static void CONSOLE_npc_disable_conditions()
	{
	}

	[Token(Token = "0x6003F86")]
	[Address(RVA = "0xBC36E0", Offset = "0xBC24E0", Length = "0x349")]
	public static void CONSOLE_npc_goto()
	{
	}

	[Token(Token = "0x6003F87")]
	[Address(RVA = "0xBC3A30", Offset = "0xBC2830", Length = "0x37D")]
	public static void CONSOLE_NPC_GoTo_Marker()
	{
	}

	[Token(Token = "0x6003F88")]
	[Address(RVA = "0xBC3DB0", Offset = "0xBC2BB0", Length = "0xDC")]
	public static void CONSOLE_npc_invulnerable()
	{
	}

	[Token(Token = "0x6003F89")]
	[Address(RVA = "0xBC3E90", Offset = "0xBC2C90", Length = "0x1E5")]
	public static void CONSOLE_nutrient_vitaminc()
	{
	}

	[Token(Token = "0x6003F8A")]
	[Address(RVA = "0xBC4080", Offset = "0xBC2E80", Length = "0x156")]
	public static void CONSOLE_scurvy_enable()
	{
	}

	[Token(Token = "0x6003F8B")]
	[Address(RVA = "0xBC41E0", Offset = "0xBC2FE0", Length = "0xD4")]
	private static void CONSOLE_outdoorsceneroot_cache()
	{
	}

	[Token(Token = "0x6003F8C")]
	[Address(RVA = "0xBC42C0", Offset = "0xBC30C0", Length = "0xBA")]
	public static void CONSOLE_pass_time()
	{
	}

	[Token(Token = "0x6003F8D")]
	[Address(RVA = "0xBC4380", Offset = "0xBC3180", Length = "0xAC")]
	public static void CONSOLE_parasites()
	{
	}

	[Token(Token = "0x6003F8E")]
	[Address(RVA = "0xBC4430", Offset = "0xBC3230", Length = "0x9E")]
	public static void CONSOLE_parasites_risk()
	{
	}

	[Token(Token = "0x6003F8F")]
	[Address(RVA = "0xBC44D0", Offset = "0xBC32D0", Length = "0x9E")]
	public static void CONSOLE_parasites_risk_nofx()
	{
	}

	[Token(Token = "0x6003F90")]
	[Address(RVA = "0xBC4570", Offset = "0xBC3370", Length = "0x5A")]
	public static void CONSOLE_parasites_cure()
	{
	}

	[Token(Token = "0x6003F91")]
	[Address(RVA = "0xBC45D0", Offset = "0xBC33D0", Length = "0xBF")]
	public static void CONSOLE_player_stunned()
	{
	}

	[Token(Token = "0x6003F92")]
	[Address(RVA = "0xBC4690", Offset = "0xBC3490", Length = "0xAC")]
	public static void CONSOLE_parasites_nofx()
	{
	}

	[Token(Token = "0x6003F93")]
	[Address(RVA = "0xBC4740", Offset = "0xBC3540", Length = "0x59")]
	public static void CONSOLE_phone_startringing()
	{
	}

	[Token(Token = "0x6003F94")]
	[Address(RVA = "0xBC47A0", Offset = "0xBC35A0", Length = "0x59")]
	public static void CONSOLE_phone_stopringing()
	{
	}

	[Token(Token = "0x6003F95")]
	[Address(RVA = "0xBC4800", Offset = "0xBC3600", Length = "0x1C9")]
	public static void CONSOLE_physics_autosync()
	{
	}

	[Token(Token = "0x6003F96")]
	[Address(RVA = "0xBC49D0", Offset = "0xBC37D0", Length = "0xEE")]
	public static void CONSOLE_play_movie()
	{
	}

	[Token(Token = "0x6003F97")]
	[Address(RVA = "0xBC4AC0", Offset = "0xBC38C0", Length = "0xEE")]
	public static void CONSOLE_play_movie_alpha()
	{
	}

	[Token(Token = "0x6003F98")]
	[Address(RVA = "0xBC4BB0", Offset = "0xBC39B0", Length = "0xEE")]
	public static void CONSOLE_play_movie_alpha_ext()
	{
	}

	[Token(Token = "0x6003F99")]
	[Address(RVA = "0xBC4CA0", Offset = "0xBC3AA0", Length = "0xBF")]
	public static void CONSOLE_play_dd()
	{
	}

	[Token(Token = "0x6003F9A")]
	[Address(RVA = "0xBC4D60", Offset = "0xBC3B60", Length = "0x12D")]
	public static void CONSOLE_play_exploremusic()
	{
	}

	[Token(Token = "0x6003F9B")]
	[Address(RVA = "0xBC4E90", Offset = "0xBC3C90", Length = "0x259")]
	public static void CONSOLE_play_timeline()
	{
	}

	[Token(Token = "0x6003F9C")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public static void CONSOLE_play_timeline_on()
	{
	}

	[Token(Token = "0x6003F9D")]
	[Address(RVA = "0xBC50F0", Offset = "0xBC3EF0", Length = "0xDC")]
	public static void CONSOLE_printlookat()
	{
	}

	[Token(Token = "0x6003F9E")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public static void CONSOLE_stop_timeline_on()
	{
	}

	[Token(Token = "0x6003F9F")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public static void CONSOLE_play_fp_cinematic()
	{
	}

	[Token(Token = "0x6003FA0")]
	[Address(RVA = "0xBC51D0", Offset = "0xBC3FD0", Length = "0x174")]
	public static void CONSOLE_play_sorrowmusic()
	{
	}

	[Token(Token = "0x6003FA1")]
	[Address(RVA = "0xBC5350", Offset = "0xBC4150", Length = "0xBF")]
	public static void CONSOLE_play_sound()
	{
	}

	[Token(Token = "0x6003FA2")]
	[Address(RVA = "0xBC5410", Offset = "0xBC4210", Length = "0x106")]
	public static void CONSOLE_play_soundlogduration()
	{
	}

	[Token(Token = "0x6003FA3")]
	[Address(RVA = "0xBC5520", Offset = "0xBC4320", Length = "0xFE")]
	public static void CONSOLE_play_unistorm_anim()
	{
	}

	[Token(Token = "0x6003FA4")]
	[Address(RVA = "0xBC5620", Offset = "0xBC4420", Length = "0xA4")]
	public static void CONSOLE_play_voice()
	{
	}

	[Token(Token = "0x6003FA5")]
	[Address(RVA = "0xBC56D0", Offset = "0xBC44D0", Length = "0x5C")]
	public static void CONSOLE_poorcirculation()
	{
	}

	[Token(Token = "0x6003FA6")]
	[Address(RVA = "0xBC5730", Offset = "0xBC4530", Length = "0x5C")]
	public static void CONSOLE_poorcirculation_cure()
	{
	}

	[Token(Token = "0x6003FA7")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public static void CONSOLE_popup()
	{
	}

	[Token(Token = "0x6003FA8")]
	[Address(RVA = "0xBC5790", Offset = "0xBC4590", Length = "0xDC")]
	public static void CONSOLE_postprocess_globaloptim()
	{
	}

	[Token(Token = "0x6003FA9")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public static void CONSOLE_collect_materialsets_stats()
	{
	}

	[Token(Token = "0x6003FAA")]
	[Address(RVA = "0xBC5870", Offset = "0xBC4670", Length = "0xE0")]
	public static void CONSOLE_pulse_pain()
	{
	}

	[Token(Token = "0x6003FAB")]
	[Address(RVA = "0xBC5960", Offset = "0xBC4760", Length = "0xE0")]
	public static void CONSOLE_pulse_stim()
	{
	}

	[Token(Token = "0x6003FAC")]
	[Address(RVA = "0xBC5A50", Offset = "0xBC4850", Length = "0xEA")]
	public static void CONSOLE_pulse_electrocution()
	{
	}

	[Token(Token = "0x6003FAD")]
	[Address(RVA = "0xBC5B40", Offset = "0xBC4940", Length = "0xD9")]
	private static void CONSOLE_radialspawn_enablevischecks()
	{
	}

	[Token(Token = "0x6003FAE")]
	[Address(RVA = "0xBC5C20", Offset = "0xBC4A20", Length = "0x141")]
	public static void CONSOLE_random_voice()
	{
	}

	[Token(Token = "0x6003FAF")]
	[Address(RVA = "0xBC5D70", Offset = "0xBC4B70", Length = "0x11E")]
	public static void CONSOLE_random_weather()
	{
	}

	[Token(Token = "0x6003FB0")]
	[Address(RVA = "0xBC5E90", Offset = "0xBC4C90", Length = "0x391")]
	public static void CONSOLE_recipe_unlock()
	{
	}

	[Token(Token = "0x6003FB1")]
	[Address(RVA = "0xBC6230", Offset = "0xBC5030", Length = "0x1C1")]
	public static void CONSOLE_recipe_unlock_all()
	{
	}

	[Token(Token = "0x6003FB2")]
	[Address(RVA = "0xBC6400", Offset = "0xBC5200", Length = "0x182")]
	public static void CONSOLE_record_fps()
	{
	}

	[Token(Token = "0x6003FB3")]
	[Address(RVA = "0xBC6590", Offset = "0xBC5390", Length = "0x79")]
	public static void CONSOLE_rejump()
	{
	}

	[Token(Token = "0x6003FB4")]
	[Address(RVA = "0xBC6610", Offset = "0xBC5410", Length = "0x86")]
	public static void CONSOLE_restore_view()
	{
	}

	[Token(Token = "0x6003FB5")]
	[Address(RVA = "0xBC66A0", Offset = "0xBC54A0", Length = "0x288")]
	public static void CONSOLE_revolver()
	{
	}

	[Token(Token = "0x6003FB6")]
	[Address(RVA = "0xBC6930", Offset = "0xBC5730", Length = "0x288")]
	public static void CONSOLE_rifle()
	{
	}

	[Token(Token = "0x6003FB7")]
	[Address(RVA = "0xBC6BC0", Offset = "0xBC59C0", Length = "0x390")]
	public static void CONSOLE_toughclothes()
	{
	}

	[Token(Token = "0x6003FB8")]
	[Address(RVA = "0xBC6F60", Offset = "0xBC5D60", Length = "0x110")]
	public static void CONSOLE_toxicfog_full()
	{
	}

	[Token(Token = "0x6003FB9")]
	[Address(RVA = "0xBC7070", Offset = "0xBC5E70", Length = "0xD9")]
	public static void CONSOLE_toxicfog_pause()
	{
	}

	[Token(Token = "0x6003FBA")]
	[Address(RVA = "0xBC7150", Offset = "0xBC5F50", Length = "0xFA")]
	public static void CONSOLE_toxicfog_reset()
	{
	}

	[Token(Token = "0x6003FBB")]
	[Address(RVA = "0xBC7250", Offset = "0xBC6050", Length = "0x144")]
	public static void CONSOLE_toxicfog_reset_all()
	{
	}

	[Token(Token = "0x6003FBC")]
	[Address(RVA = "0xBC73A0", Offset = "0xBC61A0", Length = "0x165")]
	public static void CONSOLE_toxicfog_set()
	{
	}

	[Token(Token = "0x6003FBD")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public static void CONSOLE_trader_debug()
	{
	}

	[Token(Token = "0x6003FBE")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public static void CONSOLE_trader_reset_drawn_exchanges()
	{
	}

	[Token(Token = "0x6003FBF")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public static void CONSOLE_trader_set_special_request()
	{
	}

	[Token(Token = "0x6003FC0")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public static void CONSOLE_trader_trust()
	{
	}

	[Token(Token = "0x6003FC1")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public static void CONSOLE_trader_trust_add()
	{
	}

	[Token(Token = "0x6003FC2")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public static void CONSOLE_trader_unlock_conversation()
	{
	}

	[Token(Token = "0x6003FC3")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public static void CONSOLE_trader_unlock_conversation_all()
	{
	}

	[Token(Token = "0x6003FC4")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public static void CONSOLE_trader_unlock_exchange()
	{
	}

	[Token(Token = "0x6003FC5")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public static void CONSOLE_trader_unlock_exchange_all()
	{
	}

	[Token(Token = "0x6003FC6")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public static void CONSOLE_trader_unlock_improvement()
	{
	}

	[Token(Token = "0x6003FC7")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public static void CONSOLE_trader_unlock_improvement_all()
	{
	}

	[Token(Token = "0x6003FC8")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public static void CONSOLE_trader_trade_force_completed()
	{
	}

	[Token(Token = "0x6003FC9")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public static void CONSOLE_trader_trade_force_completed_perfectly()
	{
	}

	[Token(Token = "0x6003FCA")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public static void CONSOLE_trader_trade_set_hours_since_last_complete()
	{
	}

	[Token(Token = "0x6003FCB")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public static void CONSOLE_trader_trade_cancel()
	{
	}

	[Token(Token = "0x6003FCC")]
	[Address(RVA = "0xBC7510", Offset = "0xBC6310", Length = "0xF4")]
	public static void CONSOLE_rumble()
	{
	}

	[Token(Token = "0x6003FCD")]
	[Address(RVA = "0xBC7610", Offset = "0xBC6410", Length = "0xA2")]
	public static void CONSOLE_safezone()
	{
	}

	[Token(Token = "0x6003FCE")]
	[Address(RVA = "0xBC76C0", Offset = "0xBC64C0", Length = "0x103")]
	public static void CONSOLE_save()
	{
	}

	[Token(Token = "0x6003FCF")]
	[Address(RVA = "0xBC77D0", Offset = "0xBC65D0", Length = "0x86")]
	public static void CONSOLE_save_view()
	{
	}

	[Token(Token = "0x6003FD0")]
	[Address(RVA = "0xBC7860", Offset = "0xBC6660", Length = "0x1B7")]
	public static void CONSOLE_scene()
	{
	}

	[Token(Token = "0x6003FD1")]
	[Address(RVA = "0xBC7A20", Offset = "0xBC6820", Length = "0x10C")]
	public static void CONSOLE_scene_addlayer()
	{
	}

	[Token(Token = "0x6003FD2")]
	[Address(RVA = "0xBC7B30", Offset = "0xBC6930", Length = "0x10C")]
	public static void CONSOLE_scene_removelayer()
	{
	}

	[Token(Token = "0x6003FD3")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public static void CONSOLE_validate_time()
	{
	}

	[Token(Token = "0x6003FD4")]
	[Address(RVA = "0xBC7C40", Offset = "0xBC6A40", Length = "0xAB")]
	public static void CONSOLE_set_aurora_cine_colours()
	{
	}

	[Token(Token = "0x6003FD5")]
	[Address(RVA = "0xBC7CF0", Offset = "0xBC6AF0", Length = "0xAE")]
	public static void CONSOLE_set_blur_level()
	{
	}

	[Token(Token = "0x6003FD6")]
	[Address(RVA = "0xBC7DA0", Offset = "0xBC6BA0", Length = "0x1DF")]
	public static void CONSOLE_set_cinematicproperty()
	{
	}

	[Token(Token = "0x6003FD7")]
	[Address(RVA = "0xBC7F90", Offset = "0xBC6D90", Length = "0xD8")]
	public static void CONSOLE_set_cold()
	{
	}

	[Token(Token = "0x6003FD8")]
	[Address(RVA = "0xBC8070", Offset = "0xBC6E70", Length = "0xED")]
	public static void CONSOLE_set_condition()
	{
	}

	[Token(Token = "0x6003FD9")]
	[Address(RVA = "0xBC8160", Offset = "0xBC6F60", Length = "0xB8")]
	public static void CONSOLE_set_elapsed_hours()
	{
	}

	[Token(Token = "0x6003FDA")]
	[Address(RVA = "0xBC8220", Offset = "0xBC7020", Length = "0xD8")]
	public static void CONSOLE_set_fatigue()
	{
	}

	[Token(Token = "0x6003FDB")]
	[Address(RVA = "0xBC8300", Offset = "0xBC7100", Length = "0xB3")]
	public static void CONSOLE_fixedDeltaTime()
	{
	}

	[Token(Token = "0x6003FDC")]
	[Address(RVA = "0xBC83C0", Offset = "0xBC71C0", Length = "0xC9")]
	public static void CONSOLE_set_hours_played()
	{
	}

	[Token(Token = "0x6003FDD")]
	[Address(RVA = "0xBC8490", Offset = "0xBC7290", Length = "0xF3")]
	public static void CONSOLE_set_hunger()
	{
	}

	[Token(Token = "0x6003FDE")]
	[Address(RVA = "0xBC8590", Offset = "0xBC7390", Length = "0x265")]
	public static void CONSOLE_set_hud_display_mode()
	{
	}

	[Token(Token = "0x6003FDF")]
	[Address(RVA = "0xBC8800", Offset = "0xBC7600", Length = "0x287")]
	public static void CONSOLE_set_image_filter()
	{
	}

	[Token(Token = "0x6003FE0")]
	[Address(RVA = "0xBC8A90", Offset = "0xBC7890", Length = "0xC6")]
	public static void CONSOLE_set_jump_creation()
	{
	}

	[Token(Token = "0x6003FE1")]
	[Address(RVA = "0xBC8B60", Offset = "0xBC7960", Length = "0xAF")]
	public static void CONSOLE_set_min_airtemp()
	{
	}

	[Token(Token = "0x6003FE2")]
	[Address(RVA = "0xBC8C10", Offset = "0xBC7A10", Length = "0x10D")]
	public static void CONSOLE_set_nowhere_to_hide_banishment_ready()
	{
	}

	[Token(Token = "0x6003FE3")]
	[Address(RVA = "0xBC8D20", Offset = "0xBC7B20", Length = "0x21A")]
	public static void CONSOLE_set_object_calories()
	{
	}

	[Token(Token = "0x6003FE4")]
	[Address(RVA = "0xBC8F40", Offset = "0xBC7D40", Length = "0x24A")]
	public static void CONSOLE_set_object_calories_percent()
	{
	}

	[Token(Token = "0x6003FE5")]
	[Address(RVA = "0xBC9190", Offset = "0xBC7F90", Length = "0x256")]
	public static void CONSOLE_set_object_evolve_percent()
	{
	}

	[Token(Token = "0x6003FE6")]
	[Address(RVA = "0xBC93F0", Offset = "0xBC81F0", Length = "0x1E4")]
	public static void CONSOLE_set_object_hp_percent()
	{
	}

	[Token(Token = "0x6003FE7")]
	[Address(RVA = "0xBC95E0", Offset = "0xBC83E0", Length = "0x1A1")]
	public static void CONSOLE_set_quality()
	{
	}

	[Token(Token = "0x6003FE8")]
	[Address(RVA = "0xBC9790", Offset = "0xBC8590", Length = "0xE7")]
	public static void CONSOLE_set_spawn()
	{
	}

	[Token(Token = "0x6003FE9")]
	[Address(RVA = "0xBC9880", Offset = "0xBC8680", Length = "0xD8")]
	public static void CONSOLE_set_thirst()
	{
	}

	[Token(Token = "0x6003FEA")]
	[Address(RVA = "0xBC9960", Offset = "0xBC8760", Length = "0x10E")]
	public static void CONSOLE_set_time()
	{
	}

	[Token(Token = "0x6003FEB")]
	[Address(RVA = "0xBC9A70", Offset = "0xBC8870", Length = "0x3EB")]
	public static void CONSOLE_set_weather()
	{
	}

	[Token(Token = "0x6003FEC")]
	[Address(RVA = "0xBC9E60", Offset = "0xBC8C60", Length = "0xE0")]
	public static void CONSOLE_set_wind()
	{
	}

	[Token(Token = "0x6003FED")]
	[Address(RVA = "0xBC9F40", Offset = "0xBC8D40", Length = "0xE0")]
	public static void CONSOLE_set_wind_immediate()
	{
	}

	[Token(Token = "0x6003FEE")]
	[Address(RVA = "0xBCA020", Offset = "0xBC8E20", Length = "0xD6")]
	public static void CONSOLE_set_slowdown_hold()
	{
	}

	[Token(Token = "0x6003FEF")]
	[Address(RVA = "0xBCA100", Offset = "0xBC8F00", Length = "0xAE")]
	public static void CONSOLE_severe_lacerations()
	{
	}

	[Token(Token = "0x6003FF0")]
	[Address(RVA = "0xBCA1B0", Offset = "0xBC8FB0", Length = "0x5C")]
	public static void CONSOLE_severe_lacerations_cure()
	{
	}

	[Token(Token = "0x6003FF1")]
	[Address(RVA = "0xBCA210", Offset = "0xBC9010", Length = "0xAA")]
	public static void CONSOLE_suppress_blizzards()
	{
	}

	[Token(Token = "0x6003FF2")]
	[Address(RVA = "0xBCA2C0", Offset = "0xBC90C0", Length = "0xBA")]
	public static void CONSOLE_shadow_cascades()
	{
	}

	[Token(Token = "0x6003FF3")]
	[Address(RVA = "0xBCA380", Offset = "0xBC9180", Length = "0x74")]
	public static void CONSOLE_shader_toggle()
	{
	}

	[Token(Token = "0x6003FF4")]
	[Address(RVA = "0xBCA400", Offset = "0xBC9200", Length = "0x33C")]
	public static void CONSOLE_shake_camera()
	{
	}

	[Token(Token = "0x6003FF5")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public static void CONSOLE_show_audiobuckets()
	{
	}

	[Token(Token = "0x6003FF6")]
	[Address(RVA = "0xBCA740", Offset = "0xBC9540", Length = "0xDC")]
	public static void CONSOLE_show_calories()
	{
	}

	[Token(Token = "0x6003FF7")]
	[Address(RVA = "0xBCA820", Offset = "0xBC9620", Length = "0xDC")]
	public static void CONSOLE_show_coords()
	{
	}

	[Token(Token = "0x6003FF8")]
	[Address(RVA = "0xBCA900", Offset = "0xBC9700", Length = "0x6E")]
	public static void CONSOLE_show_decal_debug()
	{
	}

	[Token(Token = "0x6003FF9")]
	[Address(RVA = "0xBCA970", Offset = "0xBC9770", Length = "0x148")]
	public static void CONSOLE_show_location_reveal()
	{
	}

	[Token(Token = "0x6003FFA")]
	[Address(RVA = "0xBCAAC0", Offset = "0xBC98C0", Length = "0xEC")]
	public static void CONSOLE_show_lookat()
	{
	}

	[Token(Token = "0x6003FFB")]
	[Address(RVA = "0xBCABB0", Offset = "0xBC99B0", Length = "0x169")]
	public static void CONSOLE_show_days_survived()
	{
	}

	[Token(Token = "0x6003FFC")]
	[Address(RVA = "0xBCAD20", Offset = "0xBC9B20", Length = "0x12E")]
	public static void CONSOLE_show_fps()
	{
	}

	[Token(Token = "0x6003FFD")]
	[Address(RVA = "0xBCAE50", Offset = "0xBC9C50", Length = "0xA2")]
	public static void CONSOLE_show_placeholders()
	{
	}

	[Token(Token = "0x6003FFE")]
	[Address(RVA = "0xBCAF00", Offset = "0xBC9D00", Length = "0xA2")]
	public static void CONSOLE_show_terraindebug()
	{
	}

	[Token(Token = "0x6003FFF")]
	[Address(RVA = "0xBCAFB0", Offset = "0xBC9DB0", Length = "0x12E")]
	public static void CONSOLE_show_tod_slider()
	{
	}

	[Token(Token = "0x6004000")]
	[Address(RVA = "0xBCB0E0", Offset = "0xBC9EE0", Length = "0x165")]
	public static void CONSOLE_show_running_temp_bonus()
	{
	}

	[Token(Token = "0x6004001")]
	[Address(RVA = "0xBCB250", Offset = "0xBCA050", Length = "0xDC")]
	public static void CONSOLE_show_temperature()
	{
	}

	[Token(Token = "0x6004002")]
	[Address(RVA = "0xBCB330", Offset = "0xBCA130", Length = "0xD7")]
	public static void CONSOLE_show_unknown_timeofday()
	{
	}

	[Token(Token = "0x6004003")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public static void CONSOLE_show_timeline_debug()
	{
	}

	[Token(Token = "0x6004004")]
	[Address(RVA = "0xBCB410", Offset = "0xBCA210", Length = "0x66")]
	public static void CONSOLE_skill_archery()
	{
	}

	[Token(Token = "0x6004005")]
	[Address(RVA = "0xBCB480", Offset = "0xBCA280", Length = "0x66")]
	public static void CONSOLE_skill_archery_level()
	{
	}

	[Token(Token = "0x6004006")]
	[Address(RVA = "0xBCB4F0", Offset = "0xBCA2F0", Length = "0x64")]
	public static void CONSOLE_skill_firestarting()
	{
	}

	[Token(Token = "0x6004007")]
	[Address(RVA = "0xBCB560", Offset = "0xBCA360", Length = "0x64")]
	public static void CONSOLE_skill_firestarting_level()
	{
	}

	[Token(Token = "0x6004008")]
	[Address(RVA = "0xBCB5D0", Offset = "0xBCA3D0", Length = "0x66")]
	public static void CONSOLE_skill_gunsmithing()
	{
	}

	[Token(Token = "0x6004009")]
	[Address(RVA = "0xBCB640", Offset = "0xBCA440", Length = "0x66")]
	public static void CONSOLE_skill_gunsmithing_level()
	{
	}

	[Token(Token = "0x600400A")]
	[Address(RVA = "0xBCB6B0", Offset = "0xBCA4B0", Length = "0x66")]
	public static void CONSOLE_skill_carcassharvesting()
	{
	}

	[Token(Token = "0x600400B")]
	[Address(RVA = "0xBCB720", Offset = "0xBCA520", Length = "0x66")]
	public static void CONSOLE_skill_carcassharvesting_level()
	{
	}

	[Token(Token = "0x600400C")]
	[Address(RVA = "0xBCB790", Offset = "0xBCA590", Length = "0x66")]
	public static void CONSOLE_skill_clothingrepair()
	{
	}

	[Token(Token = "0x600400D")]
	[Address(RVA = "0xBCB800", Offset = "0xBCA600", Length = "0x66")]
	public static void CONSOLE_skill_clothingrepair_level()
	{
	}

	[Token(Token = "0x600400E")]
	[Address(RVA = "0xBCB870", Offset = "0xBCA670", Length = "0x66")]
	public static void CONSOLE_skill_cooking()
	{
	}

	[Token(Token = "0x600400F")]
	[Address(RVA = "0xBCB8E0", Offset = "0xBCA6E0", Length = "0x66")]
	public static void CONSOLE_skill_cooking_level()
	{
	}

	[Token(Token = "0x6004010")]
	[Address(RVA = "0xBCB950", Offset = "0xBCA750", Length = "0x66")]
	public static void CONSOLE_skill_icefishing()
	{
	}

	[Token(Token = "0x6004011")]
	[Address(RVA = "0xBCB9C0", Offset = "0xBCA7C0", Length = "0x66")]
	public static void CONSOLE_skill_icefishing_level()
	{
	}

	[Token(Token = "0x6004012")]
	[Address(RVA = "0xBCBA30", Offset = "0xBCA830", Length = "0x66")]
	public static void CONSOLE_skill_rifle()
	{
	}

	[Token(Token = "0x6004013")]
	[Address(RVA = "0xBCBAA0", Offset = "0xBCA8A0", Length = "0x66")]
	public static void CONSOLE_skill_rifle_level()
	{
	}

	[Token(Token = "0x6004014")]
	[Address(RVA = "0xBCBB10", Offset = "0xBCA910", Length = "0x66")]
	public static void CONSOLE_skill_toolrepair()
	{
	}

	[Token(Token = "0x6004015")]
	[Address(RVA = "0xBCBB80", Offset = "0xBCA980", Length = "0x66")]
	public static void CONSOLE_skill_toolrepair_level()
	{
	}

	[Token(Token = "0x6004016")]
	[Address(RVA = "0xBCBBF0", Offset = "0xBCA9F0", Length = "0x66")]
	public static void CONSOLE_skill_revolver()
	{
	}

	[Token(Token = "0x6004017")]
	[Address(RVA = "0xBCBC60", Offset = "0xBCAA60", Length = "0x66")]
	public static void CONSOLE_skill_revolver_level()
	{
	}

	[Token(Token = "0x6004018")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public static void CONSOLE_skip_next_conversation()
	{
	}

	[Token(Token = "0x6004019")]
	[Address(RVA = "0xBCBCD0", Offset = "0xBCAAD0", Length = "0xDC")]
	public static void CONSOLE_skip_fade_on_load()
	{
	}

	[Token(Token = "0x600401A")]
	[Address(RVA = "0xBCBDB0", Offset = "0xBCABB0", Length = "0xBF")]
	public static void CONSOLE_skip_delay_spawn_audio()
	{
	}

	[Token(Token = "0x600401B")]
	[Address(RVA = "0xBCBE70", Offset = "0xBCAC70", Length = "0x5C")]
	public static void CONSOLE_sourstomach()
	{
	}

	[Token(Token = "0x600401C")]
	[Address(RVA = "0xBCBED0", Offset = "0xBCACD0", Length = "0x5C")]
	public static void CONSOLE_sourstomach_cure()
	{
	}

	[Token(Token = "0x600401D")]
	[Address(RVA = "0xBCBF30", Offset = "0xBCAD30", Length = "0xA2")]
	public static void CONSOLE_snowpatch()
	{
	}

	[Token(Token = "0x600401E")]
	[Address(RVA = "0xBCBFE0", Offset = "0xBCADE0", Length = "0xD9")]
	public static void CONSOLE_snowshelter()
	{
	}

	[Token(Token = "0x600401F")]
	[Address(RVA = "0xBCC0C0", Offset = "0xBCAEC0", Length = "0x11C")]
	public static void CONSOLE_survey()
	{
	}

	[Token(Token = "0x6004020")]
	[Address(RVA = "0xBCC1E0", Offset = "0xBCAFE0", Length = "0xDA")]
	public static void CONSOLE_survey_clear()
	{
	}

	[Token(Token = "0x6004021")]
	[Address(RVA = "0xBCC2C0", Offset = "0xBCB0C0", Length = "0xC3")]
	public static void CONSOLE_spawn_aurorawolf()
	{
	}

	[Token(Token = "0x6004022")]
	[Address(RVA = "0xBCC390", Offset = "0xBCB190", Length = "0xC3")]
	public static void CONSOLE_spawn_aurorabear()
	{
	}

	[Token(Token = "0x6004023")]
	[Address(RVA = "0xBCC460", Offset = "0xBCB260", Length = "0xC3")]
	public static void CONSOLE_spawn_bear()
	{
	}

	[Token(Token = "0x6004024")]
	[Address(RVA = "0xBCC530", Offset = "0xBCB330", Length = "0xC3")]
	public static void CONSOLE_spawn_bear_challenge()
	{
	}

	[Token(Token = "0x6004025")]
	[Address(RVA = "0xBCC600", Offset = "0xBCB400", Length = "0xC3")]
	public static void CONSOLE_spawn_bear_old()
	{
	}

	[Token(Token = "0x6004026")]
	[Address(RVA = "0xBCC6D0", Offset = "0xBCB4D0", Length = "0xC3")]
	public static void CONSOLE_spawn_doe()
	{
	}

	[Token(Token = "0x6004027")]
	[Address(RVA = "0xBCC7A0", Offset = "0xBCB5A0", Length = "0xC3")]
	public static void CONSOLE_spawn_moose()
	{
	}

	[Token(Token = "0x6004028")]
	[Address(RVA = "0xBCC870", Offset = "0xBCB670", Length = "0xC3")]
	public static void CONSOLE_spawn_rabbit()
	{
	}

	[Token(Token = "0x6004029")]
	[Address(RVA = "0xBCC940", Offset = "0xBCB740", Length = "0xC3")]
	public static void CONSOLE_spawn_stag()
	{
	}

	[Token(Token = "0x600402A")]
	[Address(RVA = "0xBCCA10", Offset = "0xBCB810", Length = "0xC3")]
	public static void CONSOLE_spawn_ptarmigan()
	{
	}

	[Token(Token = "0x600402B")]
	[Address(RVA = "0xBCCAE0", Offset = "0xBCB8E0", Length = "0x1CA")]
	public static void CONSOLE_spawn_travois()
	{
	}

	[Token(Token = "0x600402C")]
	[Address(RVA = "0xBCCCB0", Offset = "0xBCBAB0", Length = "0xC3")]
	public static void CONSOLE_spawn_wolf()
	{
	}

	[Token(Token = "0x600402D")]
	[Address(RVA = "0xBCCD80", Offset = "0xBCBB80", Length = "0xC3")]
	public static void CONSOLE_spawn_wolf_starving()
	{
	}

	[Token(Token = "0x600402E")]
	[Address(RVA = "0xBCCE50", Offset = "0xBCBC50", Length = "0xC3")]
	public static void CONSOLE_spawn_wolf_grey()
	{
	}

	[Token(Token = "0x600402F")]
	[Address(RVA = "0xBCCF20", Offset = "0xBCBD20", Length = "0xC3")]
	public static void CONSOLE_spawn_grey_wolf_aurora()
	{
	}

	[Token(Token = "0x6004030")]
	[Address(RVA = "0xBCCFF0", Offset = "0xBCBDF0", Length = "0xC3")]
	public static void CONSOLE_spawn_cougar()
	{
	}

	[Token(Token = "0x6004031")]
	[Address(RVA = "0xBCD0C0", Offset = "0xBCBEC0", Length = "0xC3")]
	public static void CONSOLE_spawn_auroracougar()
	{
	}

	[Token(Token = "0x6004032")]
	[Address(RVA = "0xBCD190", Offset = "0xBCBF90", Length = "0xAE")]
	public static void CONSOLE_sprain_ankle()
	{
	}

	[Token(Token = "0x6004033")]
	[Address(RVA = "0xBCD240", Offset = "0xBCC040", Length = "0x57")]
	public static void CONSOLE_sprain_ankle_cure()
	{
	}

	[Token(Token = "0x6004034")]
	[Address(RVA = "0xBCD2A0", Offset = "0xBCC0A0", Length = "0xAE")]
	public static void CONSOLE_sprain_ankle_nofx()
	{
	}

	[Token(Token = "0x6004035")]
	[Address(RVA = "0xBCD350", Offset = "0xBCC150", Length = "0x187")]
	public static void CONSOLE_sprain_ankle_nofx_unique()
	{
	}

	[Token(Token = "0x6004036")]
	[Address(RVA = "0xBCD4E0", Offset = "0xBCC2E0", Length = "0xAE")]
	public static void CONSOLE_sprain_wrist()
	{
	}

	[Token(Token = "0x6004037")]
	[Address(RVA = "0xBCD590", Offset = "0xBCC390", Length = "0x57")]
	public static void CONSOLE_sprain_wrist_cure()
	{
	}

	[Token(Token = "0x6004038")]
	[Address(RVA = "0xBCD5F0", Offset = "0xBCC3F0", Length = "0xAE")]
	public static void CONSOLE_sprain_wrist_nofx()
	{
	}

	[Token(Token = "0x6004039")]
	[Address(RVA = "0xBCD6A0", Offset = "0xBCC4A0", Length = "0x909")]
	public static void CONSOLE_sandbox()
	{
	}

	[Token(Token = "0x600403A")]
	[Address(RVA = "0xBCDFB0", Offset = "0xBCCDB0", Length = "0x13D")]
	private static SceneSet GetSceneSetFromLoadedScenes()
	{
		return null;
	}

	[Token(Token = "0x600403B")]
	[Address(RVA = "0xBCE0F0", Offset = "0xBCCEF0", Length = "0x128")]
	public static void CONSOLE_story()
	{
	}

	[Token(Token = "0x600403C")]
	[Address(RVA = "0xBCE220", Offset = "0xBCD020", Length = "0xF2")]
	public static void CONSOLE_stagger_nodecanvasupdate()
	{
	}

	[Token(Token = "0x600403D")]
	[Address(RVA = "0xBCE320", Offset = "0xBCD120", Length = "0xFC")]
	public static void CONSOLE_suffocating()
	{
	}

	[Token(Token = "0x600403E")]
	[Address(RVA = "0xBCE420", Offset = "0xBCD220", Length = "0xD9")]
	public static void CONSOLE_suppress_breath_fx()
	{
	}

	[Token(Token = "0x600403F")]
	[Address(RVA = "0xBCE500", Offset = "0xBCD300", Length = "0x151")]
	public static void CONSOLE_suppress_hypothermia()
	{
	}

	[Token(Token = "0x6004040")]
	[Address(RVA = "0xBCE660", Offset = "0xBCD460", Length = "0x154")]
	public static void CONSOLE_suppress_frostbite()
	{
	}

	[Token(Token = "0x6004041")]
	[Address(RVA = "0xBCE7C0", Offset = "0xBCD5C0", Length = "0x36D")]
	public static void CONSOLE_teleport()
	{
	}

	[Token(Token = "0x6004042")]
	[Address(RVA = "0xBCEB30", Offset = "0xBCD930", Length = "0xB2")]
	public static void CONSOLE_terrain_disabletrees()
	{
	}

	[Token(Token = "0x6004043")]
	[Address(RVA = "0xBCEBF0", Offset = "0xBCD9F0", Length = "0xEE")]
	public static void CONSOLE_terrain_disableinstancedtrees()
	{
	}

	[Token(Token = "0x6004044")]
	[Address(RVA = "0xBCECE0", Offset = "0xBCDAE0", Length = "0xD1")]
	public static void CONSOLE_terrain_setpixelerror()
	{
	}

	[Token(Token = "0x6004045")]
	[Address(RVA = "0xBCEDC0", Offset = "0xBCDBC0", Length = "0xDD")]
	public static void CONSOLE_toggle_customizing()
	{
	}

	[Token(Token = "0x6004046")]
	[Address(RVA = "0xBCEEA0", Offset = "0xBCDCA0", Length = "0xDC")]
	public static void CONSOLE_enable_audio_use_static_check()
	{
	}

	[Token(Token = "0x6004047")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public static void CONSOLE_audio_logbuckets()
	{
	}

	[Token(Token = "0x6004048")]
	[Address(RVA = "0xBCEF80", Offset = "0xBCDD80", Length = "0xDC")]
	public static void CONSOLE_enable_filterworldlightsforfp()
	{
	}

	[Token(Token = "0x6004049")]
	[Address(RVA = "0xBCF060", Offset = "0xBCDE60", Length = "0xDF")]
	public static void CONSOLE_enable_renderobjectinstances()
	{
	}

	[Token(Token = "0x600404A")]
	[Address(RVA = "0xBCF140", Offset = "0xBCDF40", Length = "0xDD")]
	public static void CONSOLE_enable_renderobjectinstances_norenderers()
	{
	}

	[Token(Token = "0x600404B")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public static void CONSOLE_enable_renderobjectinstances_debugtext()
	{
	}

	[Token(Token = "0x600404C")]
	[Address(RVA = "0xBCF220", Offset = "0xBCE020", Length = "0x157")]
	public static void CONSOLE_enable_renderobjectinstances_frustumtest()
	{
	}

	[Token(Token = "0x600404D")]
	[Address(RVA = "0xBCF380", Offset = "0xBCE180", Length = "0xDA")]
	public static void CONSOLE_enable_shadows()
	{
	}

	[Token(Token = "0x600404E")]
	[Address(RVA = "0xBCF460", Offset = "0xBCE260", Length = "0xE5")]
	public static void CONSOLE_enable_specular()
	{
	}

	[Token(Token = "0x600404F")]
	[Address(RVA = "0xBCF550", Offset = "0xBCE350", Length = "0xD9")]
	public static void CONSOLE_enable_ai_frustum_culling()
	{
	}

	[Token(Token = "0x6004050")]
	[Address(RVA = "0xBCF630", Offset = "0xBCE430", Length = "0x10F")]
	public static void CONSOLE_texture_streaming_budget()
	{
	}

	[Token(Token = "0x6004051")]
	[Address(RVA = "0xBCF740", Offset = "0xBCE540", Length = "0x147")]
	public static void CONSOLE_texel_density()
	{
	}

	[Token(Token = "0x6004052")]
	[Address(RVA = "0xBCF890", Offset = "0xBCE690", Length = "0x181")]
	public static void CONSOLE_texture_streaming_caching()
	{
	}

	[Token(Token = "0x6004053")]
	[Address(RVA = "0xBCFA20", Offset = "0xBCE820", Length = "0x115")]
	public static void CONSOLE_disable_aim_breath()
	{
	}

	[Token(Token = "0x6004054")]
	[Address(RVA = "0xBCFB40", Offset = "0xBCE940", Length = "0xF0")]
	public static void CONSOLE_disable_aim_sway()
	{
	}

	[Token(Token = "0x6004055")]
	[Address(RVA = "0xBCFC30", Offset = "0xBCEA30", Length = "0x118")]
	public static void CONSOLE_disable_aim_stamina()
	{
	}

	[Token(Token = "0x6004056")]
	[Address(RVA = "0xBCFD50", Offset = "0xBCEB50", Length = "0x118")]
	public static void CONSOLE_disable_aim_shake()
	{
	}

	[Token(Token = "0x6004057")]
	[Address(RVA = "0xBCFE70", Offset = "0xBCEC70", Length = "0xCA")]
	public static void CONSOLE_disable_ambient_sway()
	{
	}

	[Token(Token = "0x6004058")]
	[Address(RVA = "0xBCFF40", Offset = "0xBCED40", Length = "0x55")]
	public static void CONSOLE_disable_probe_updates()
	{
	}

	[Token(Token = "0x6004059")]
	[Address(RVA = "0xBCFFA0", Offset = "0xBCEDA0", Length = "0xB7")]
	public static void CONSOLE_drop_lit_item_in_hands()
	{
	}

	[Token(Token = "0x600405A")]
	[Address(RVA = "0xBD0060", Offset = "0xBCEE60", Length = "0x230")]
	public static void CONSOLE_drop_scatter_item_in_hands()
	{
	}

	[Token(Token = "0x600405B")]
	[Address(RVA = "0xBD02A0", Offset = "0xBCF0A0", Length = "0x118")]
	public static void CONSOLE_disable_aim_depth_of_field()
	{
	}

	[Token(Token = "0x600405C")]
	[Address(RVA = "0xBD03C0", Offset = "0xBCF1C0", Length = "0x57")]
	public static void CONSOLE_stow_item()
	{
	}

	[Token(Token = "0x600405D")]
	[Address(RVA = "0xBD0420", Offset = "0xBCF220", Length = "0xBE")]
	public static void CONSOLE_timeaccelerate()
	{
	}

	[Token(Token = "0x600405E")]
	[Address(RVA = "0xBD04E0", Offset = "0xBCF2E0", Length = "0x226")]
	public static void CONSOLE_timeofday_display()
	{
	}

	[Token(Token = "0x600405F")]
	[Address(RVA = "0xBD0710", Offset = "0xBCF510", Length = "0xF5")]
	public static void CONSOLE_timescale()
	{
	}

	[Token(Token = "0x6004060")]
	[Address(RVA = "0xBD0810", Offset = "0xBCF610", Length = "0x93")]
	public static void CONSOLE_trialmode()
	{
	}

	[Token(Token = "0x6004061")]
	[Address(RVA = "0xBD08B0", Offset = "0xBCF6B0", Length = "0xB6")]
	public static void CONSOLE_turbo_weather()
	{
	}

	[Token(Token = "0x6004062")]
	[Address(RVA = "0xBD0970", Offset = "0xBCF770", Length = "0xB8")]
	public static void CONSOLE_ui_height()
	{
	}

	[Token(Token = "0x6004063")]
	[Address(RVA = "0xBD0A30", Offset = "0xBCF830", Length = "0xB9")]
	public static void CONSOLE_ui_width()
	{
	}

	[Token(Token = "0x6004064")]
	[Address(RVA = "0xBD0AF0", Offset = "0xBCF8F0", Length = "0xCB")]
	public static void CONSOLE_ui_size()
	{
	}

	[Token(Token = "0x6004065")]
	[Address(RVA = "0xBD0BC0", Offset = "0xBCF9C0", Length = "0xE7")]
	public static void CONSOLE_ultimatecamera_fixedstep()
	{
	}

	[Token(Token = "0x6004066")]
	[Address(RVA = "0xBD0CB0", Offset = "0xBCFAB0", Length = "0xFA")]
	public static void CONSOLE_unequip_immediate()
	{
	}

	[Token(Token = "0x6004067")]
	[Address(RVA = "0xBD0DB0", Offset = "0xBCFBB0", Length = "0xEF")]
	public static void CONSOLE_unlimited_sprint()
	{
	}

	[Token(Token = "0x6004068")]
	[Address(RVA = "0xBD0EA0", Offset = "0xBCFCA0", Length = "0x5C")]
	public static void CONSOLE_unsettledsleep()
	{
	}

	[Token(Token = "0x6004069")]
	[Address(RVA = "0xBD0F00", Offset = "0xBCFD00", Length = "0x5C")]
	public static void CONSOLE_unsettledsleep_cure()
	{
	}

	[Token(Token = "0x600406A")]
	[Address(RVA = "0xBD0F60", Offset = "0xBCFD60", Length = "0x19A")]
	public static void CONSOLE_use_best_gearitem()
	{
	}

	[Token(Token = "0x600406B")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public static void CONSOLE_use_legacyloading()
	{
	}

	[Token(Token = "0x600406C")]
	[Address(RVA = "0xBD1100", Offset = "0xBCFF00", Length = "0x94")]
	public static void CONSOLE_voice_female()
	{
	}

	[Token(Token = "0x600406D")]
	[Address(RVA = "0xBD11A0", Offset = "0xBCFFA0", Length = "0x94")]
	public static void CONSOLE_voice_male()
	{
	}

	[Token(Token = "0x600406E")]
	[Address(RVA = "0xBD1240", Offset = "0xBD0040", Length = "0xF5")]
	public static void CONSOLE_vsync()
	{
	}

	[Token(Token = "0x600406F")]
	[Address(RVA = "0xBD1340", Offset = "0xBD0140", Length = "0x67E")]
	public static void CONSOLE_warp()
	{
	}

	[Token(Token = "0x6004070")]
	[Address(RVA = "0xBD19C0", Offset = "0xBD07C0", Length = "0x126")]
	private static void SaveToken(string token)
	{
	}

	[Token(Token = "0x6004071")]
	[Address(RVA = "0xBD1AF0", Offset = "0xBD08F0", Length = "0x237")]
	private static bool TryGetWarpToPosition(out Vector3 pos, out Quaternion rot)
	{
		pos = default(Vector3);
		rot = default(Quaternion);
		return false;
	}

	[Token(Token = "0x6004072")]
	[Address(RVA = "0xBD1D30", Offset = "0xBD0B30", Length = "0x5C")]
	public static void CONSOLE_weakconstitution()
	{
	}

	[Token(Token = "0x6004073")]
	[Address(RVA = "0xBD1D90", Offset = "0xBD0B90", Length = "0x5C")]
	public static void CONSOLE_weakconstitution_cure()
	{
	}

	[Token(Token = "0x6004074")]
	[Address(RVA = "0xBD1DF0", Offset = "0xBD0BF0", Length = "0x5C")]
	public static void CONSOLE_weakjoints()
	{
	}

	[Token(Token = "0x6004075")]
	[Address(RVA = "0xBD1E50", Offset = "0xBD0C50", Length = "0x5C")]
	public static void CONSOLE_weakjoints_cure()
	{
	}

	[Token(Token = "0x6004076")]
	[Address(RVA = "0xBD1EB0", Offset = "0xBD0CB0", Length = "0xA2")]
	public static void CONSOLE_well_fed()
	{
	}

	[Token(Token = "0x6004077")]
	[Address(RVA = "0xBD1F60", Offset = "0xBD0D60", Length = "0x59C")]
	private static GameModeConfig GetGameModeConfig(string name)
	{
		return null;
	}

	[Token(Token = "0x6004078")]
	[Address(RVA = "0xBD2500", Offset = "0xBD1300", Length = "0x3E8")]
	public static void CONSOLE_xpmode(bool resetInventory)
	{
	}

	[Token(Token = "0x6004079")]
	[Address(RVA = "0xBD28F0", Offset = "0xBD16F0", Length = "0x47")]
	public static void CONSOLE_xpmode()
	{
	}

	[Token(Token = "0x600407A")]
	[Address(RVA = "0xBD2940", Offset = "0xBD1740", Length = "0x47")]
	public static void CONSOLE_xpmode_keep_inventory()
	{
	}

	[Token(Token = "0x600407B")]
	[Address(RVA = "0xBD2990", Offset = "0xBD1790", Length = "0x170")]
	public static void CONSOLE_jump_to_loadingzone()
	{
	}

	[Token(Token = "0x600407C")]
	[Address(RVA = "0xBD2B10", Offset = "0xBD1910", Length = "0x168")]
	public static void CONSOLE_jump_to_interior()
	{
	}

	[Token(Token = "0x600407D")]
	[Address(RVA = "0xBD2C80", Offset = "0xBD1A80", Length = "0x1CC")]
	private static void CONSOLE_kill_all_animals()
	{
	}

	[Token(Token = "0x600407E")]
	[Address(RVA = "0xBD2E50", Offset = "0xBD1C50", Length = "0x4E")]
	private static WeatherStage WeatherNameToEnum(string weatherName)
	{
		return default(WeatherStage);
	}

	[Token(Token = "0x600407F")]
	[Address(RVA = "0xBD2EA0", Offset = "0xBD1CA0", Length = "0xCD")]
	private static void spawn_common(string prefabName, float dist)
	{
	}

	[Token(Token = "0x6004080")]
	[Address(RVA = "0xBD2F70", Offset = "0xBD1D70", Length = "0x703")]
	private static void set_spawn_position(BaseAi bai, float dist)
	{
	}

	[Token(Token = "0x6004081")]
	[Address(RVA = "0xBD3680", Offset = "0xBD2480", Length = "0xC3F")]
	private static void StoreAutoCompleteGearNames()
	{
	}

	[Token(Token = "0x6004082")]
	[Address(RVA = "0x4D7770", Offset = "0x4D6570", Length = "0x19")]
	private static string GetGearName(GearItemData asset)
	{
		return null;
	}

	[Token(Token = "0x6004083")]
	[Address(RVA = "0xBD42C0", Offset = "0xBD30C0", Length = "0xC3")]
	private static void CONSOLE_mapmarker_add()
	{
	}

	[Token(Token = "0x6004084")]
	[Address(RVA = "0xBD4390", Offset = "0xBD3190", Length = "0xC0")]
	private static void CONSOLE_mapmarker_remove()
	{
	}

	[Token(Token = "0x6004085")]
	[Address(RVA = "0xBD4460", Offset = "0xBD3260", Length = "0xA2")]
	private static void CONSOLE_map_enablegps()
	{
	}

	[Token(Token = "0x6004086")]
	[Address(RVA = "0xBD4510", Offset = "0xBD3310", Length = "0x84")]
	private static void CONSOLE_map_reveal()
	{
	}

	[Token(Token = "0x6004087")]
	[Address(RVA = "0xBD45A0", Offset = "0xBD33A0", Length = "0xF8")]
	private static void CONSOLE_map_unlock_region()
	{
	}

	[Token(Token = "0x6004088")]
	[Address(RVA = "0xBD46A0", Offset = "0xBD34A0", Length = "0xE2")]
	private static void CONSOLE_map_screenshot()
	{
	}

	[Token(Token = "0x6004089")]
	[Address(RVA = "0xBD4790", Offset = "0xBD3590", Length = "0x118")]
	private static void CONSOLE_show_hands()
	{
	}

	[Token(Token = "0x600408A")]
	[Address(RVA = "0xBD48B0", Offset = "0xBD36B0", Length = "0x2AF")]
	private static void SetSkillPoints(string command, SkillType skillType, SkillsManager.PointAssignmentMode mode)
	{
	}

	[Token(Token = "0x600408B")]
	[Address(RVA = "0xBD4B60", Offset = "0xBD3960", Length = "0x276")]
	private static void SetSkillLevel(string command, SkillType skillType, SkillsManager.PointAssignmentMode mode)
	{
	}

	[Token(Token = "0x600408C")]
	[Address(RVA = "0xBD4DE0", Offset = "0xBD3BE0", Length = "0x1B4")]
	private static void SetFeat(string command, FeatType featType)
	{
	}

	[Token(Token = "0x600408D")]
	[Address(RVA = "0xBD4FA0", Offset = "0xBD3DA0", Length = "0x790")]
	public static void SetWind(string windName, string windDir, bool immediate)
	{
	}

	[Token(Token = "0x600408E")]
	[Address(RVA = "0xBD5740", Offset = "0xBD4540", Length = "0x84")]
	private static void AudioCallback(object cookie, AkCallbackType type, object callbackInfo)
	{
	}

	[Token(Token = "0x600408F")]
	[Address(RVA = "0xBD57D0", Offset = "0xBD45D0", Length = "0xA2")]
	private static void CONSOLE_debug_transponder()
	{
	}

	[Token(Token = "0x6004090")]
	[Address(RVA = "0xBD5880", Offset = "0xBD4680", Length = "0xA5")]
	private static void CONSOLE_debug_transmitter()
	{
	}

	[Token(Token = "0x6004091")]
	[Address(RVA = "0xBD5930", Offset = "0xBD4730", Length = "0x10E")]
	private static void CONSOLE_debug_cougar()
	{
	}

	[Token(Token = "0x6004092")]
	[Address(RVA = "0xBD5A40", Offset = "0xBD4840", Length = "0x10E")]
	private static void CONSOLE_debug_cougarpassingattack()
	{
	}

	[Token(Token = "0x6004093")]
	[Address(RVA = "0xBD5B50", Offset = "0xBD4950", Length = "0x11E")]
	private static void CONSOLE_debug_cougarsetthreatlevel()
	{
	}

	[Token(Token = "0x6004094")]
	[Address(RVA = "0xBD5C70", Offset = "0xBD4A70", Length = "0x160")]
	private static void CONSOLE_debug_cougarforceallcarcass()
	{
	}

	[Token(Token = "0x6004095")]
	[Address(RVA = "0xBD5DE0", Offset = "0xBD4BE0", Length = "0x221")]
	private static void CONSOLE_debug_cougarforcearrival()
	{
	}

	[Token(Token = "0x6004096")]
	[Address(RVA = "0xBD6010", Offset = "0xBD4E10", Length = "0xA2")]
	private static void CONSOLE_debug_liquidcontainers()
	{
	}

	[Token(Token = "0x6004097")]
	[Address(RVA = "0xBD60C0", Offset = "0xBD4EC0", Length = "0xA2")]
	private static void CONSOLE_debug_chemhazard()
	{
	}

	[Token(Token = "0x6004098")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public static void CONSOLE_repair_transmitters()
	{
	}

	[Token(Token = "0x6004099")]
	[Address(RVA = "0xBD6170", Offset = "0xBD4F70", Length = "0x52")]
	private static string EnabledOrDisabled(bool enabled)
	{
		return null;
	}

	[Token(Token = "0x600409A")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public ConsoleManager()
	{
	}
}
