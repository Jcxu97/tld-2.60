# -*- coding: utf-8 -*-
"""
harvest_en.py — TldHacks Mod Options 面板英文化词条收割器

输入:
  src/Settings.cs          解析 [Section]/[Name]/[Description]/[Choice] 与字段名
  src/Menu.cs              这三个文件里 460 处 I18n.T("中文","English") 是现成的译文源,
  src/MenuTweaks.cs        按 *字段名* 锚定(同一行出现 s.FieldName 且出现 I18n.T)
  src/MenuTweaks.Gfx.cs

输出:
  src/ModSettingsEnData.cs 已解决的词条(编译进 mod)
  _tools/missing_en.tsv    未解决的词条清单(留给翻译 agent 填 en 列)

三级取值优先级:
  1. AUTO   — 原文本身混排了英文("No Fall Damage(无坠落伤害)" / "Language / 语言"),
              去掉中文即得完整英文,质量优于 Menu 里为窄列写的缩写
  2. HARVEST— 从 Menu*.cs 的 I18n.T 收割(纯中文 Name 的主要来源)
  3. MANUAL — 本文件底部 OVERRIDES 表(Section/Choice 全量手译 + 修正过简的收割结果)
所有源文件 UTF-8 with BOM,读写都用 utf-8-sig。
"""
import os
import re
import sys

ROOT = os.path.dirname(os.path.dirname(os.path.abspath(__file__)))
SRC = os.path.join(ROOT, "src")
TOOLS = os.path.join(ROOT, "_tools")
MENU_FILES = ["Menu.cs", "MenuTweaks.cs", "MenuTweaks.Gfx.cs"]

CJK = re.compile(r"[　-〿一-鿿＀-￯]")
ASCII_ALPHA = re.compile(r"[A-Za-z]")


def has_cjk(s):
    return bool(CJK.search(s))


# ─────────────────────────── C# 字符串字面量扫描 ───────────────────────────

def scan_strings(line):
    """返回该行所有字符串字面量的值(按出现顺序),正确处理 \\" \\\\ 与 @"..."。"""
    out = []
    i, n = 0, len(line)
    while i < n:
        c = line[i]
        if c == '/' and i + 1 < n and line[i + 1] == '/':
            break  # 行注释
        if c == '@' and i + 1 < n and line[i + 1] == '"':
            i += 2
            buf = []
            while i < n:
                if line[i] == '"':
                    if i + 1 < n and line[i + 1] == '"':
                        buf.append('"'); i += 2; continue
                    i += 1; break
                buf.append(line[i]); i += 1
            out.append("".join(buf))
            continue
        if c == '"':
            i += 1
            buf = []
            while i < n:
                if line[i] == '\\' and i + 1 < n:
                    buf.append(line[i]); buf.append(line[i + 1]); i += 2; continue
                if line[i] == '"':
                    i += 1; break
                buf.append(line[i]); i += 1
            out.append("".join(buf))
            continue
        i += 1
    return out


def cs_escape(s):
    return s.replace("\\", "\\\\").replace('"', '\\"')


def cs_unescape(s):
    # Settings.cs 里只有 \\ 和 \" 两种转义
    return s.replace('\\"', '"').replace("\\\\", "\\")


# ─────────────────────────── Settings.cs 解析 ───────────────────────────

FIELD_RE = re.compile(r"^\s*public\s+[A-Za-z_][\w<>\[\]\.]*\s+([A-Za-z_]\w*)\s*(=|;)")
ATTR_RE = re.compile(r"^\s*\[(Section|Name|Description|Choice)\s*\(")


def parse_settings():
    """→ [(field, {'Section':str|None,'Name':str,'Description':str|None,'Choice':[str]|None}), ...] 保持声明顺序"""
    path = os.path.join(SRC, "Settings.cs")
    with open(path, encoding="utf-8-sig", newline="") as fh:
        lines = fh.read().replace("\r\n", "\n").split("\n")
    fields, pending = [], {}
    for ln in lines:
        m = ATTR_RE.match(ln)
        if m:
            kind = m.group(1)
            vals = [cs_unescape(v) for v in scan_strings(ln)]
            if not vals:
                continue
            pending["Choice" if kind == "Choice" else kind] = vals if kind == "Choice" else vals[0]
            continue
        fm = FIELD_RE.match(ln)
        if fm:
            if "Name" in pending:
                fields.append((fm.group(1), dict(pending)))
            pending = {}
            continue
        # 空行/注释不清空 pending(attribute 之间常夹注释);遇到 `}` / 方法体则清空
        st = ln.strip()
        if st.startswith("}") or st.startswith("{") or st.startswith("private ") or st.startswith("internal "):
            pending = {}
    return fields


# ─────────────────────────── Menu*.cs 收割 ───────────────────────────

def harvest_menu(valid_fields):
    """按字段名锚定收割 → {field: en}。同一字段多处出现时取最长(最完整)的英文。"""
    found = {}
    fld_re = re.compile(r"\bs\.([A-Za-z_]\w*)\b")
    for fn in MENU_FILES:
        path = os.path.join(SRC, fn)
        if not os.path.isfile(path):
            continue
        with open(path, encoding="utf-8-sig", newline="") as fh:
            text = fh.read().replace("\r\n", "\n")
        for ln in text.split("\n"):
            if "I18n.T" not in ln:
                continue
            names = [f for f in dict.fromkeys(fld_re.findall(ln)) if f in valid_fields]
            if len(names) != 1:
                continue          # 一行两个字段 → 无法确定归属,放弃
            strs = scan_strings(ln)
            # I18n.T 的实参对:取所有 (zh, en) 相邻对里 zh 含中文且 en 不含中文的
            pairs = [(cs_unescape(strs[i]).strip(), cs_unescape(strs[i + 1]).strip())
                     for i in range(len(strs) - 1)
                     if has_cjk(strs[i]) and not has_cjk(strs[i + 1]) and ASCII_ALPHA.search(strs[i + 1])]
            if len(pairs) != 1:
                continue          # 一行多个 I18n.T(如折叠按钮的展开/收起) → 放弃
            en = pairs[0][1]
            if not en:
                continue
            prev = found.get(names[0])
            if prev is None or len(en) > len(prev):
                found[names[0]] = en
    return found


# ─────────────────────────── AUTO:剥离中文得英文 ───────────────────────────

PAREN_GROUP = re.compile(r"[(（][^()（）]*[)）]")


def auto_en(text):
    """原文混排了英文时抽出英文。返回 (值, 是否形状干净)。拿不到返回 (None, False)。"""
    if not has_cjk(text) or not ASCII_ALPHA.search(text):
        return None, False
    # a) "Language / 语言" / "一键搜刮-半径(米) / Grab All radius"
    for sep in ("/", "／"):
        if sep in text:
            parts = [p.strip() for p in text.split(sep)]
            clean = [p for p in parts if p and not has_cjk(p) and ASCII_ALPHA.search(p)]
            if len(clean) == 1 and len(parts) == 2:
                return _tidy(clean[0]), True
    # b) 去掉含中文的括号组,再删残余中文
    t = PAREN_GROUP.sub(lambda m: "" if has_cjk(m.group(0)) else m.group(0), text)
    t = CJK.sub("", t)
    t = _tidy(t)
    if not t or not ASCII_ALPHA.search(t):
        return None, False
    # c) 剩下的整块被括号裹住("无限制跳跃(Jump King)" → "(Jump King)")→ 拆掉括号,但形状不算干净
    if re.fullmatch(r"[(（].*[)）]", t):
        return _tidy(t[1:-1]), False
    if not re.match(r"^[A-Za-z0-9]", t):
        return t, False
    return t, True


def _tidy(s):
    s = re.sub(r"\s{2,}", " ", s.replace("　", " ")).strip()
    s = s.strip(" \t-—–,:;")
    s = re.sub(r"\(\s*\)|（\s*）", "", s).strip()
    return s


# ─────────────────────────── 手工表 ───────────────────────────
# Section / Choice 全量手译(数量少、质量要求高);外加修正 AUTO/HARVEST 里过简或走形的条目。

SECTIONS = {
    "Diagnostic / 诊断": "Diagnostic",
    "Life / 生命": "Life",
    "Status / 状态": "Status",
    "Movement / 移动": "Movement",
    "Animals / 动物": "Animals",
    "World / 世界": "World",
    "Items / 物品": "Items",
    "Crafting / 制作": "Crafting",
    "Weapons / 武器": "Weapons",
    "Aiming / 瞄准": "Aiming",
    "Environment / 环境": "Environment",
    "Shortcuts / 快捷": "Shortcuts",
    "CT 复刻 / 参照 Cheat Engine 表": "CT Table Replica (Cheat Engine)",
    "商人 Trader": "Trader",
    "美洲狮": "Cougar",
    "与 ItemPicker mod 交互": "ItemPicker Mod Integration",
    "Weapon / 武器微调": "Weapon Tuning",
    "Movement Detail / 细分速度": "Movement Detail",
    "Time Scale / 时间加速": "Time Scale",
    "Decay / 衰减倍率": "Decay Rates",
    "Light Sources / 光源": "Light Sources",
    "House Lights / 室内灯光": "House Lights",
    "QoL / 生活品质": "QoL",
    "QoL: TinyTweaks / 小改动": "QoL: TinyTweaks",
    "QoL: Sleep Anywhere / 随地睡": "QoL: Sleep Anywhere",
    "QoL: AutoSurvey / 自动绘图": "QoL: AutoSurvey",
    "Craft Anywhere / 随意制作": "Craft Anywhere",
    "More Cooking Slots / 更多烹饪位": "More Cooking Slots",
    "Sprainkle / 扭伤系统": "Sprainkle (Sprain System)",
    "PlaceFromInv / 微操放置 v1.1.3": "Place From Inventory v1.1.3",
    "UT / 常用修改 v1.4.8": "UniversalTweaks / General v1.4.8",
    "UT / 食物修改": "UniversalTweaks / Food",
    "UT / 岩石贮藏处": "UniversalTweaks / Rock Cache",
    "UT / 喷漆": "UniversalTweaks / Decals",
    "UT / 雪橇": "UniversalTweaks / Travois",
    "UT / 手电筒": "UniversalTweaks / Flashlight",
    "StackManager / 堆叠管理 v1.0.6": "StackManager v1.0.6",
    "Bow Repair / 弓修复": "Bow Repair",
    "Caffeinated Sodas / 苏打提神": "Caffeinated Sodas",
    "RnStripped / 尸骸搬运&极光点火": "Carcass Moving & Aurora Torch",
    "TinyTweaks / 微调合集": "TinyTweaks",
}

# 每个中文 Choice 数组的英文版(长度必须一致)
CHOICES = {
    ("Auto", "中文 / Chinese", "English"): ["Auto", "Chinese", "English"],
    # 描边 = outline,不是背景色;"Black on White" 会被理解成白底黑字(实际没有底色)。
    # 且中文标签与 IntegratedPatches3.cs:525-549 的 case 实际颜色是错位的(case 0 描边是棕
    # 0.581/0.551/0.495、case 1 才是纯白),英文按代码实况写,中文侧的错位单独修。
    ("黑字棕描边", "黑字白描边", "米白字黑描边", "白字黑描边"):
        ["Dark text, tan outline", "Dark text, white outline",
         "Cream text, dark outline", "White text, dark outline"],
    ("任意", "工作台", "锻造台", "弹药台", "火堆"):
        ["Anywhere", "Workbench", "Forge", "Ammo Bench", "Fire"],
    ("原版", "自定义", "增强(高难)"): ["Vanilla", "Custom", "Hardcore"],
    ("手修", "磨坊", "都可"): ["By Hand", "Milling Machine", "Both"],
    ("低", "中", "高"): ["Low", "Medium", "High"],
    ("5分钟", "10分钟", "15分钟", "30分钟"): ["5 min", "10 min", "15 min", "30 min"],
}

# 收割/AUTO 结果不理想时按字段名直接覆盖(Mod Options 横向空间大,不必用窄列缩写)
NAME_OVERRIDES = {
    "DiagPauseRuntime": "Emergency: Pause Runtime (all ticks/updates)",
    "DiagUnpatchAll": "Emergency: Unpatch All Harmony",
    "LanguageMode": "Language",
    "MenuScale": "Menu UI Scale (2-3 for 4K)",
    "MenuWidth": "Menu Width (drag right edge)",
    "MenuHeight": "Menu Height (drag bottom edge)",
    "MenuX": "Menu X Position (auto-saved on drag)",
    "MenuY": "Menu Y Position (auto-saved on drag)",
    "MenuAutoScaled": "Menu auto-scaled once",
    "FlyHotkey": "Fly toggle hotkey",
    "JumpKey": "Jump hotkey",
    "SpeedMultiplier": "Game Speed Multiplier",
    "TrueInvisible": "True Invisible (animals cannot detect you)",
    "NoAimSway": "Steady Aim (no sway / jitter / breathing)",
    "SuperAccuracy": "Super Accuracy (deprecated, kept for compatibility)",
    "QuickAction": "Quick Action (auto speed-up harvest / repair / break down)",
    "GrabAllKey": "Grab All hotkey",
    "GrabAllRadius": "Grab All radius (m)",
    "GrabAllNotify": "Grab All pickup popups",
    "QuickCook": "Instant Cooking (cooking pot, never burns)",
    "NoBurn": "No Burning (food stays at Ready, no instant cook)",
    "QuickSearch": "Instant Search (containers / bodies)",
    "QuickHarvest": "Instant Harvest (Panel_BodyHarvest)",
    "QuickBreakDown": "Instant Break Down (Panel_BreakDown)",
    "SpaceFinish_BreakDown": "Space to finish - Break Down",
    "SpaceFinish_Harvest": "Space to finish - Harvest",
    "SpaceFinish_Craft": "Space to finish - Craft",
    "SpaceFinish_Repair": "Space to finish - Repair",
    "QoL_HotkeysEnabled": "QoL Hotkeys - master switch",
    "QoL_DropKey": "QoL - Drop key",
    "QoL_BulkKey": "QoL - Bulk modifier key",
    "QoL_BackKey": "QoL - Back key",
    "UnlockSafes": "Unlock safes / locked doors / lockers",
    "FireMaxBurnHours": "Campfire max burn time (hours)",
    "WellFedBuff": "Well Fed buff (always active)",
    "FreezingBuff": "Warming buff (always active)",
    "FatigueBuff": "Fatigue buff (always active)",
    "TechBackpack": "Custom carry weight limit",
    "TechBackpackKg": "Carry weight limit (kg)",
    "FreeSprint": "Free Sprint (incl. travois)",
    "InfiniteStamina": "Infinite Stamina",
    "MapClickTP": "Map double-click teleport",
    "TraderUnlimitedList": "Unlimited trade list (cap -> 64)",
    "BlockAutoPickupOwnDrops": "Skip own drops when auto-picking up (W key)",
    "RecoilScaleESP": "Recoil strength (0=none 1=vanilla)",
    "MagicBullet": "Magic Bullet (shots auto-hit target)",
    "SpeedTweaksEnabled": "Enable detailed speed tuning (off = vanilla)",
    "CrouchSpeed": "Crouch speed multiplier",
    "WalkSpeed": "Walk speed multiplier",
    "SprintSpeed": "Sprint speed multiplier",
    "StaminaRecharge": "Stamina recharge rate",
    "StaminaDrain": "Stamina drain rate",
    "StaminaRecoveryDelay": "Stamina recovery delay multiplier",
    "PickupRange": "Interaction range multiplier",
    "SilentFootsteps": "Fully silent footsteps",
    "InvWeightMetalVol": "Metal item volume (%)",
    "InvWeightWoodVol": "Wood item volume (%)",
    "InvWeightWaterVol": "Water item volume (%)",
    "InvWeightGeneralVol": "Other item volume (%)",
    "JumpEnabled": "Enable jumping",
    "JumpHeight": "Jump height",
    "JumpKing": "Unrestricted jumping (Jump King)",
    "JumpWeightLimit": "Weight limit (kg)",
    "JumpCalorieCost": "Calorie cost per jump",
    "JumpStaminaCost": "Stamina cost per jump",
    "JumpFatigueCost": "Fatigue cost per jump",
    "GunZoomEnabled": "Scroll-wheel aim zoom",
    "RunWithLantern": "Run while holding lantern",
    "NoAutoEquipCharcoal": "Don't auto-equip charcoal",
    "AutoExtinguishOnRest": "Auto-extinguish lights when resting",
    "DoorSwingAngle": "Door swing angle",
    "DoorSwingSpeed": "Door swing speed",
    "TimeScaleInfo": "How to use",
    "TimeScaleKey1": "Time scale hotkey 1",
    "TimeScaleKey2": "Time scale hotkey 2",
    "TimeScale1": "Time scale 1 (hotkey multiplier)",
    "TimeScale2": "Time scale 2 (hotkey multiplier)",
    "GeneralDecay": "General decay rate",
    "DecayBeforePickup": "Decay before pickup",
    "OnUseDecay": "Decay on use",
    "FoodDecay": "Food decay",
    "RawMeatDecay": "Raw meat decay",
    "CookedMeatDecay": "Cooked meat decay",
    "DrinksDecay": "Drinks decay",
    "ClothingDecayRate": "Clothing decay",
    "GunDecay": "Firearm decay",
    "BowDecay": "Bow decay",
    "ToolsDecay": "Tool decay",
    "BedrollDecay": "Bedroll decay",
    "TravoisDecay": "Travois decay",
    "ArrowDecay": "Arrow decay",
    "SnareDecay": "Snare decay",
    "FirestartingDecay": "Fire-starting tool decay",
    "CuredMeatDecay": "Cured meat decay",
    "RawFishDecay": "Raw fish decay",
    "CookedFishDecay": "Cooked fish decay",
    "CannedFoodDecay": "Canned food decay",
    "CoffeeTeaDecay": "Coffee / tea decay",
    "PackagedFoodDecay": "Packaged food decay",
    "OtherFoodDecay": "Other food decay",
    "FatDecay": "Fat decay",
    "CuredFishDecay": "Cured fish decay",
    "IngredientsDecay": "Ingredient decay",
    "HideDecay": "Hide / carcass decay",
    "FirstAidDecay": "First aid decay",
    "WaterPurifierDecay": "Water purification tablet decay",
    "CookingPotDecay": "Cookware decay",
    "FlareGunAmmoDecay": "Flare gun ammo decay",
    "WhetstoneDecay": "Whetstone use decay",
    "CanOpenerDecay": "Can opener use decay",
    "PrybarDecay": "Prybar use decay",
    "BodyHarvestDecay": "Harvesting tool decay",
    "TorchBurnMinutes": "Torch burn time (minutes)",
    "TorchMinCondition": "Torch minimum condition",
    "TorchMaxCondition": "Torch maximum condition",
    "LampBurnMultiplier": "Lamp fuel multiplier (legacy / 0=infinite)",
    "LampPlacedBurnMult": "Lamp fuel burn rate when placed",
    "LampHeldBurnMult": "Lamp fuel burn rate when held",
    "LampTurnOnDecay": "Lamp condition loss per turn-on (%)",
    "LampOverTimeDecay": "Lamp condition loss per hour (%)",
    "LampConditionThreshold": "Lamp fuel penalty threshold (%)",
    "LampMaxPenalty": "Lamp max fuel penalty (%)",
    "LampMute": "Mute lamp (when placed)",
    "LampRangeMultiplier": "Lamp light range multiplier",
    "DisableTorchLeftClick": "Disable left-click to extinguish torch",
    "DisableLampLeftClick": "Disable left-click to extinguish lamp",
    "LampFuelNoDrain": "Storm lantern fuel never drains",
    "FlaskNoHeatLoss": "Thermos never loses heat",
    "FlaskInfiniteVol": "Thermos infinite capacity",
    "FlaskAnyItem": "Thermos holds any liquid",
    "QuickEvolve": "Instant processing (drying / curing)",
    "InfiniteContainer": "Infinite container capacity",
    "FireTemp300": "Campfire temperature 300°C",
    "FireNeverDie": "Campfire never goes out",
    "NoFrostbiteRisk": "No frostbite risk",
    "ClearDeathPenalty": "Clear death penalty",
    "QuickFishing": "Fishing 100% success",
    "FireAnywhere": "Start fires anywhere (incl. indoors)",
    "FreeFireFuel": "Free fire fuel",
    "TorchFullValue": "Full-value torches",
    "TraderMaxTrust": "Max trader trust",
    "TraderInstantExchange": "Instant trader exchange",
    "TraderAlwaysAvailable": "Trader always reachable (radio)",
    "CougarInstantActivate": "Activate cougar immediately on new save",
    "HL_Enabled": "Enable house lights",
    "HL_EnableOutside": "Enable in outdoor scenes",
    "HL_WhiteLights": "White lights",
    "HL_NoFlicker": "No flicker",
    "HL_CastShadows": "Cast shadows",
    "HL_LightAudio": "Light hum audio",
    "HL_Intensity": "Brightness",
    "HL_RangeMultiplier": "Range multiplier",
    "HL_CullDistance": "Cull distance (m)",
    "HL_InteractDistance": "Switch interaction distance (m)",
    "PauseInJournal": "Pause game in journal",
    "SkipIntro": "Skip intro",
    "MuteCougarMenuSound": "Mute main-menu cougar sound",
    "VehicleKeepFov": "Keep player FOV in vehicles",
    "DroppableUndroppables": "Allow dropping undroppable items",
    "ImportantWeight": "Keep weight on key items",
    "AllNote": "Notes and keys droppable",
    # 这三条原文的括号注释是中文,auto_en 会把括号整组删掉 → 关键数值/语义丢失,手工补回
    "Stealth": "Stealth (animals flee on sight)",
    "QuickFire": "Quick Fire Start (100% success)",
    "QuickClimb": "Quick Rope Climb (5x speed)",
    "RememberBreakdownTool": "Remember break-down tool",
    "VehicleFreeLook": "Free look in vehicles",
    "VehicleFreeLookYaw": "Max horizontal angle in vehicle",
    "VehicleFreeLookPitch": "Max vertical angle in vehicle",
    "CrosshairEnabled": "Enable custom aim crosshair",
    "CrosshairAlpha": "Crosshair opacity",
    "CrosshairStone": "Stone crosshair",
    "CrosshairRifle": "Rifle crosshair",
    "CrosshairBow": "Bow crosshair",
    "QoL_Enabled": "QoL master switch",
    "QoL_NoSaveOnSprain": "No autosave on sprain",
    "QoL_NoSaveOnSprainFalls": "No autosave on fall sprains",
    "QoL_WakeUpCall": "Can wake up during sleep",
    "QoL_AuroraSense": "Aurora sense (wake up on aurora)",
    "QoL_ShowTimeSleep": "Show time while sleeping",
    "QoL_NoPitchBlack": "No pitch black while sleeping",
    "QoL_MapTextOutline": "Map text style",
    "QoL_MapTextOutlineEnabled": "Enable map text style override",
    "QoL_BuryCorpses": "Bury corpses",
    "QoL_SleepAnywhere": "Sleep without a bedroll",
    "QoL_SleepFatigueRecovery": "Fatigue recovery penalty",
    "QoL_SleepConditionRecovery": "Condition recovery multiplier",
    "QoL_SleepFreezingScale": "Freezing rate multiplier",
    "QoL_SleepFreezingHealthLoss": "Freezing Condition loss multiplier",
    "QoL_SleepHypothermicHealthLoss": "Hypothermia Condition loss multiplier",
    "QoL_SleepPassTimeExposure": "Pass-time exposure penalty",
    "QoL_SleepInterrupt": "Interrupt sleep at low Condition",
    "QoL_SleepInterruptThreshold": "Interrupt Condition threshold (%)",
    "QoL_SleepInterruptCooldown": "Interrupt cooldown (s)",
    "QoL_SleepInterruptHudMsg": "Show HUD message on interrupt",
    "QoL_SleepInterruptAllBeds": "Enable interrupt for all beds",
    "QoL_SleepSensitivityScale": "Exposure sensitivity scale",
    "QoL_SleepAdjustedSensitivity": "Adjusted sensitivity",
    "QoL_AutoSurvey": "Auto-survey map",
    "QoL_AutoSurveyDelay": "Survey interval (s)",
    "QoL_AutoSurveyRange": "Survey range multiplier",
    "QoL_AutoSurveyUnlock": "Ignore weather restrictions",
    "QoL_AutoOpenMapOnExit": "Auto-open minimap when going outside (MotionTrackerLite)",
    "Craft_Anywhere": "Enable Craft Anywhere",
    "Craft_DefaultLocation": "Default location (new blueprints)",
    "Craft_MoreCookingSlots": "Enable extra cooking slots",
    "Craft_MoreSlots_Fireplace": "Fireplace (2 -> 3)",
    "Craft_MoreSlots_Barrel": "Fire barrel (2 -> 4)",
    "Craft_MoreSlots_Grill": "Grill (2 -> 4)",
    "World_Sprainkle": "Enable sprain tuning",
    "World_SprainklePreset": "Preset",
    "World_SprainkleSlopeMin": "Minimum slope (deg)",
    "World_SprainkleSlopeIncrease": "Slope scaling factor",
    "World_SprainkleBaseChanceMoving": "Base chance while moving (%)",
    "World_SprainkleEncumberChance": "Added chance from encumbrance",
    "World_SprainkleExhaustionChance": "Added chance from exhaustion",
    "World_SprainkleSprintChance": "Added chance from sprinting",
    "World_SprainkleCrouchChance": "Crouch reduction (%)",
    "World_SprainkleMinSecondsRisk": "Minimum risk interval (s)",
    "World_SprainkleWristMovementChance": "Wrist sprain from movement (%)",
    "World_SprainkleSprintUIOn": "Sprint UI threshold (show)",
    "World_SprainkleSprintUIOff": "Sprint UI threshold (hide)",
    "World_SprainkleAnkleEnabled": "Enable ankle sprains",
    "World_SprainkleAnkleDurMin": "Ankle min duration (h)",
    "World_SprainkleAnkleDurMax": "Ankle max duration (h)",
    "World_SprainkleAnkleRestHours": "Ankle rest recovery (h)",
    "World_SprainkleAnkleFallChance": "Ankle sprain from falls (%)",
    "World_SprainkleWristEnabled": "Enable wrist sprains",
    "World_SprainkleWristDurMin": "Wrist min duration (h)",
    "World_SprainkleWristDurMax": "Wrist max duration (h)",
    "World_SprainkleWristRestHours": "Wrist rest recovery (h)",
    "World_SprainkleWristFallChance": "Wrist sprain from falls (%)",
    "PlaceFromInv_Enabled": "Enable right-click place from inventory",
    "PlaceFromInv_AllowClose": "Allow placing items very close to other objects",
    "PlaceFromInv_StackDrop": "Ctrl drops whole stack",
    "UT_BreathVisibility": "Enable breath visibility",
    "UT_ConsistantDressingWeight": "Uniform wound dressing weight (0.03 kg)",
    "UT_FeatProgressInCustom": "Feat progress in custom mode",
    "UT_RandomizedItemRotation": "Randomized item rotation on drop",
    "UT_RevolverImprovements": "Revolver improvements",
    "UT_NoisemakerBurnLength": "Noisemaker fuse burn time (min)",
    "UT_NoisemakerThrowForce": "Noisemaker throw force",
    "UT_RespiratorCanisterDuration": "Respirator canister duration (s)",
    "UT_SnowShelterDecay": "Snow shelter daily condition loss",
    "UT_ToiletWaterPotable": "Toilet water is potable",
    "UT_RemoveHeadacheDebuff": "Remove dessert headache debuff",
    "UT_StewFatigueLoss": "Stew fatigue reduction",
    "UT_RockCacheIndoors": "Allow indoor placement",
    "UT_RockCacheMaxPerRegion": "Max per region",
    "UT_RockCacheMinDistance": "Minimum spacing (m)",
    "UT_DecalOverlap": "Decal overlap ratio",
    "UT_GlowingDecals": "Enable glowing decals",
    "UT_GlowingDecalMult": "Glow multiplier",
    "UT_TravoisDecayBlizzard": "Blizzard condition loss (HP/h)",
    "UT_TravoisDecayHourly": "Normal condition loss (HP/h, value / 1000)",
    "UT_TravoisDecayMovement": "Movement loss per item (/100)",
    "UT_TravoisMaxSlope": "Max slope angle",
    "UT_TravoisTurnSpeed": "Turn speed",
    "UT_TravoisOverrideMovement": "Remove movement zone restrictions",
    "UT_TravoisOverrideInteraction": "Remove interaction restrictions",
    "UT_FlashInfiniteBattery": "Infinite battery",
    "Stack_AddComponent": "Add stackable component",
    "Stack_UseMaxHP": "Merge using best condition",
    "World_BowRepair": "Allow bow repair",
    "World_BowRepairDLC": "Enable for DLC bows",
    "World_BowRepairMode": "Survival bow repair mode",
    "World_BowMaterialNeed": "Survival bow material cost",
    "World_SportBowRepairMode": "Sport bow repair mode",
    "World_SportBowMaterialNeed": "Sport bow material cost",
    "World_WoodBowRepairMode": "Wood bow repair mode",
    "World_WoodBowMaterialNeed": "Wood bow material cost",
    "World_BushBowRepairMode": "Bush bow repair mode",
    "World_BushBowMaterialNeed": "Bush bow material cost",
    "World_CaffeinatedSodas": "Sodas reduce fatigue",
    "World_SodaOrangeEnabled": "Enable orange soda",
    "World_SodaOrangeInitial": "Orange fatigue reduction (%)",
    "World_SodaOrangeDuration": "Orange duration",
    "World_SodaSummitEnabled": "Enable Summit soda",
    "World_SodaSummitInitial": "Summit fatigue reduction (%)",
    "World_SodaSummitDuration": "Summit duration",
    "World_SodaGrapeEnabled": "Enable grape soda",
    "World_SodaGrapeInitial": "Grape fatigue reduction (%)",
    "World_SodaGrapeDuration": "Grape duration",
    "World_CarcassMoving": "Move animal carcasses",
    "World_CarcassMovingAll": "Move all animal carcasses",
    "World_ElectricTorch": "Light torch from aurora power",
    "DeerMeatMultMin": "Deer meat multiplier - min",
    "DeerMeatMultMax": "Deer meat multiplier - max",
    "TT_CapFeelsHigh": "Feels-like temperature cap (°C)",
    "TT_CapFeelsLow": "Feels-like temperature floor (°C)",
    "TT_CapFeelsEnabled": "Enable feels-like temperature limits",
    "TT_FallDeathGoat": "Ignore instant-death fall volumes",
    "TT_FallDamageMult": "Fall damage per meter",
    "TT_DroppedOrientation": "Rifles land upright",
    "TT_ExtendedFOV": "Extended FOV slider (30-150)",
    "TT_PauseOnRadial": "Radial menu slow motion (0.1x)",
    "TT_GlobalSpeedMult": "Interaction speed - general",
    "TT_InteractionSpeedMult": "Interaction speed - containers",
    "TT_EatingSpeedMult": "Interaction speed - eating",
    "TT_BreakdownSpeedMult": "Interaction speed - break down",
    "TT_ReadingSpeedMult": "Interaction speed - reading",
    "TT_PlantRespawnDays": "Plant respawn (days)",
    "TT_RespawnPlants": "Enable plant respawn",
    "TT_ShowTraderTrust": "Show trader trust",
    "TraderArrivalDays": "Trader arrival day",
}


# (kind, field) → 中文原文。main() 里填,write_missing 回写保留行时用。
ZH_BY_KEY = {}


def read_filled_tsv():
    """
    回读 missing_en.tsv 里已填好的 en 列 → {(kind, field): en}。
    这让脚本幂等:翻译 agent 填完 TSV 后直接重跑本脚本,译文进 ModSettingsEnData.cs,
    仍空着的行重新写回 TSV,不会丢工。
    """
    path = os.path.join(TOOLS, "missing_en.tsv")
    filled = {}
    if not os.path.isfile(path):
        return filled
    with open(path, encoding="utf-8-sig", newline="") as fh:
        raw = fh.read().replace("\r\n", "\n")
    for ln in raw.split("\n")[1:]:
        if not ln.strip():
            continue
        cols = ln.split("\t")
        if len(cols) < 4:
            continue
        kind, field, _zh, en = cols[0].strip(), cols[1].strip(), cols[2], cols[3].strip()
        if en:
            filled[(kind, field)] = en
    return filled


def main():
    fields = parse_settings()
    valid = set(f for f, _ in fields)
    harvested = harvest_menu(valid)
    filled = read_filled_tsv()

    # write_missing 保留"已填但本轮不缺"的行时要能回填 zh 原文 → 先按 (kind, field) 建索引
    ZH_BY_KEY.clear()
    for field, a in fields:
        if a.get("Name"):
            ZH_BY_KEY[("NAME", field)] = a["Name"]
        if a.get("Description"):
            ZH_BY_KEY[("DESC", field)] = a["Description"]
        if a.get("Section"):
            ZH_BY_KEY[("SECTION", field)] = a["Section"]
        if a.get("Choice"):
            ZH_BY_KEY[("CHOICE", field)] = "|".join(a["Choice"])

    names, descs, sections, choices = [], [], [], []
    missing = []
    stats = dict(total=len(fields), name_auto=0, name_harvest=0, name_manual=0,
                 name_skip=0, name_missing=0, desc=0, desc_missing=0,
                 sec=0, sec_missing=0, cho=0, cho_missing=0)
    seen_sections = set()

    for field, a in fields:
        zh = a["Name"]
        # ── Name ──
        if not has_cjk(zh):
            stats["name_skip"] += 1
        else:
            en = filled.get(("NAME", field)) or NAME_OVERRIDES.get(field)
            if en:
                stats["name_manual"] += 1
            else:
                auto, clean = auto_en(zh)
                hv = harvested.get(field)
                if auto and clean:
                    en, = (auto,); stats["name_auto"] += 1
                elif hv:
                    en = hv; stats["name_harvest"] += 1
                elif auto:
                    en = auto; stats["name_auto"] += 1
            if en:
                names.append((field, zh, en))
            else:
                stats["name_missing"] += 1
                missing.append(("NAME", field, zh))

        # ── Description ──
        zhd = a.get("Description")
        if zhd and has_cjk(zhd):
            # Description 是整句中文散文,auto_en 的「剥中文」启发式只适用于 "English(中文)"
            # 这种结构化 Name,套到散文上会剩下一堆碎片(实测 "Auto = ;Chinese = ;English =")。
            # 所以 DESC 一律走 TSV 人工翻译,不做自动推断。
            en = filled.get(("DESC", field))
            if en:
                descs.append((field, zhd, en)); stats["desc"] += 1
            else:
                stats["desc_missing"] += 1
                missing.append(("DESC", field, zhd))
        # ── Section(同一 Section 只需一条:GetAttributes 按字段查,首个带该 Section 的字段即锚点)──
        zhs = a.get("Section")
        if zhs and has_cjk(zhs):
            en = filled.get(("SECTION", field)) or SECTIONS.get(zhs)
            if not en:
                auto, clean = auto_en(zhs)
                en = auto if clean else None
            if en:
                sections.append((field, zhs, en)); stats["sec"] += 1
            elif zhs not in seen_sections:
                stats["sec_missing"] += 1
                missing.append(("SECTION", field, zhs))
            seen_sections.add(zhs)
        # ── Choice ──
        ch = a.get("Choice")
        if ch and any(has_cjk(x) for x in ch):
            en = CHOICES.get(tuple(ch))
            f_en = filled.get(("CHOICE", field))
            if f_en:
                parts = f_en.split("|")
                if len(parts) == len(ch):
                    en = parts
            if en and len(en) == len(ch):
                choices.append((field, ch, en)); stats["cho"] += 1
            else:
                stats["cho_missing"] += 1
                missing.append(("CHOICE", field, "|".join(ch)))

    write_data(names, descs, sections, choices)
    write_missing(missing)
    write_review(names, sections, choices)

    print("fields with [Name]        : %d" % stats["total"])
    print("Name already English      : %d" % stats["name_skip"])
    print("Name resolved  manual     : %d" % stats["name_manual"])
    print("Name resolved  auto-strip : %d" % stats["name_auto"])
    print("Name resolved  harvested  : %d" % stats["name_harvest"])
    print("Name MISSING              : %d" % stats["name_missing"])
    print("Section resolved / missing: %d / %d" % (stats["sec"], stats["sec_missing"]))
    print("Choice  resolved / missing: %d / %d" % (stats["cho"], stats["cho_missing"]))
    print("Desc    MISSING           : %d" % stats["desc_missing"])
    print("missing_en.tsv rows       : %d" % len(missing))
    print("harvest hits usable       : %d" % len(harvested))


HEADER = """// <auto-generated by _tools/harvest_en.py — 手工补译请直接改本文件,重跑脚本会覆盖>
// TldHacks Mod Options 面板英文词条表。仅 I18n.IsEnglish == true 时被 ModSettingsEn 读取。
// 格式:扁平数组,偶数下标 = Settings.cs 字段名,奇数下标 = 英文文本。
// Choice 用 '|' 分隔;分段数必须与原 [Choice] 数组长度一致,单段留空 = 保留该项中文。
// ReSharper disable All

namespace TldHacks;

internal static class ModSettingsEnData
{
"""


def _emit(fh, arr_name, rows, comment_index=1):
    fh.write("    internal static readonly string[] %s =\n    {\n" % arr_name)
    for row in rows:
        field, zh, en = row
        fh.write('        "%s", "%s",' % (field, cs_escape(en)))
        fh.write("   // %s\n" % zh.replace("\n", " "))
    fh.write("    };\n\n")


def write_data(names, descs, sections, choices):
    path = os.path.join(SRC, "ModSettingsEnData.cs")
    lines = [HEADER]
    out = []
    out.append("    // ─── Name(字段标题) ───\n")
    body = []
    for field, zh, en in names:
        body.append('        "%s", "%s",   // %s\n' % (field, cs_escape(en), zh))
    out.append("    internal static readonly string[] Names =\n    {\n" + "".join(body) + "    };\n\n")

    out.append("    // ─── Description(悬停说明)。翻译 agent 从 _tools/missing_en.tsv 的 DESC 行填这里 ───\n")
    body = []
    for field, zh, en in descs:
        body.append('        "%s", "%s",   // %s\n' % (field, cs_escape(en), zh))
    out.append("    internal static readonly string[] Descriptions =\n    {\n" + "".join(body) + "    };\n\n")

    out.append("    // ─── Section(分组标题) ───\n")
    body = []
    for field, zh, en in sections:
        body.append('        "%s", "%s",   // %s\n' % (field, cs_escape(en), zh))
    out.append("    internal static readonly string[] Sections =\n    {\n" + "".join(body) + "    };\n\n")

    out.append("    // ─── Choice(下拉项,'|' 分隔,段数必须与原数组一致) ───\n")
    body = []
    for field, zh, en in choices:
        body.append('        "%s", "%s",   // %s\n' % (field, cs_escape("|".join(en)), "|".join(zh)))
    out.append("    internal static readonly string[] Choices =\n    {\n" + "".join(body) + "    };\n")

    out.append("}\n")
    with open(path, "w", encoding="utf-8-sig", newline="") as fh:
        fh.write("".join(lines + out).replace("\n", "\r\n"))


def write_missing(missing):
    """
    missing_en.tsv 是**译文的持久来源**,不是一次性待办清单。

    v8.0 血的教训:早先这里无条件截断重写,合并进 ModSettingsEnData.cs 之后 tsv 就空了,
      于是 125 条译文的唯一副本变成生成物 .cs;后来因为改了 Settings.cs 的 Choice 标签
      重跑 harvest,空 tsv → 覆盖掉 .cs → 译文全丢且无法恢复(agent transcript 是空文件)。
    现在:已填的行永远保留,新缺口追加。生成物可以随便重建,译文只住在这里。
    """
    path = os.path.join(TOOLS, "missing_en.tsv")
    kept = read_filled_tsv()          # {(kind, field): en},只含 en 非空的行
    rows = []
    seen = set()
    for kind, field, zh in missing:
        rows.append((kind, field, zh, kept.get((kind, field), "")))
        seen.add((kind, field))
    # 已填但本轮不再"缺"的(说明已合并进生成物)也留着,否则下次重建就没源了
    for (kind, field), en in sorted(kept.items()):
        if (kind, field) not in seen:
            rows.append((kind, field, ZH_BY_KEY.get((kind, field), ""), en))
    with open(path, "w", encoding="utf-8-sig", newline="") as fh:
        fh.write("kind\tfield\tzh\ten\r\n")
        for kind, field, zh, en in rows:
            fh.write("%s\t%s\t%s\t%s\r\n" % (
                kind, field,
                zh.replace("\t", " ").replace("\n", " "),
                en.replace("\t", " ").replace("\n", " ")))


def write_review(names, sections, choices):
    """
    已解决的 Name/Section/Choice 全量导出给翻译 agent 复核。
    改法:把 en 列改掉,再把行 kind 前缀改成 NAME/SECTION/CHOICE 粘进 missing_en.tsv 即生效
    (read_filled_tsv 优先级高于 NAME_OVERRIDES),或直接改 harvest_en.py 的手工表。
    """
    path = os.path.join(TOOLS, "review_en.tsv")
    with open(path, "w", encoding="utf-8-sig", newline="") as fh:
        fh.write("kind\tfield\tzh\ten\r\n")
        for kind, rows in (("NAME", names), ("SECTION", sections), ("CHOICE", choices)):
            for field, zh, en in rows:
                if isinstance(zh, list):
                    zh, en = "|".join(zh), "|".join(en)
                fh.write("%s\t%s\t%s\t%s\r\n" % (kind, field,
                                                 zh.replace("\t", " "), en.replace("\t", " ")))


if __name__ == "__main__":
    main()
