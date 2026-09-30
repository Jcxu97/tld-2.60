# 把 diff_mod_items.py 查出的缺口生成 ItemDatabaseMod.cs 能直接贴的 ItemEntry 行。
# 取值来源:每个 mod 的 auto-mapped/*.json(重量、热量、游戏内分类)+ localizations/Localization.json
#   (英文名,以及 mod 自带的 "Simplified Chinese" 中文名)。
# 三类东西不收:
#   Random* / Undefined*(ModRandomItemComponent,拾取瞬间会解析成别的物品,Menu.cs 里本来就有黑名单)
#   尸体和采集阶段(ModBodyHarvestComponent,是世界物体不是库存物,它们的采集产物已经收了)
#   各种笔记(名字里带 Note,收集品,刷出来没用)
import json
import os
import re
import sys
import zipfile

sys.path.insert(0, os.path.dirname(os.path.abspath(__file__)))
from diff_mod_items import MODS, SRC, db_prefabs, loose_json, component_of, mod_items

SKIP_COMPONENT = ("ModRandomItemComponent", "ModRandomWeightedItemComponent", "ModBodyHarvestComponent")

# mod 文件名 → 显示名后面的方括号标签(沿用 ItemDatabaseMod.cs 现有写法)
TAG = {
    "FoodsByCalorieWaltz": "CW",
    "Bountiful_Foraging": "BF",
    "FoodPackByTKG": "FoodTKG",
    "CampingTools": "Camp",
    "Indoors_Greenery_DLC": "Greenery",
    "Ranger_Recipes": "Ranger",
    "NorthfolkClothingPack": "Northfolk",
    "NorthernLightsBroadcast": "TV",
    "PineNeedleTea": "Pine",
}

# 游戏内 InventoryCategory → 生成器的 9 个类别
CATEGORY = {
    "Food": "食物", "Drink": "饮料", "Tool": "工具", "Tools": "工具",
    "Clothing": "衣物", "FirstAid": "医疗", "Material": "材料", "Materials": "材料",
    "Firstaid": "医疗", "Weapon": "武器", "Ranged": "武器", "Decoration": "装饰",
}

# mod 没给中文名的,用这里的译名(英文名 → 中文)。译名跟着原版本地化的叫法走。
ZH = {
    "CRT TV": "显像管电视",
    "LCD TV": "液晶电视",
    "LCD TV to hang on walls": "壁挂液晶电视",
    "Carbon Filter": "活性炭滤芯",
    "Dried Herb Leaves": "晒干的草药叶",
    "Prepared Blueberries": "处理好的蓝莓",
    "Prepared Soapberries": "处理好的水牛果",
    "Raw Cattail Rhizome": "生香蒲根",
    "Uncooked Bear Stew": "生熊肉汤",
    "Uncooked Moose Stew": "生驼鹿肉汤",
    "Uncooked Wolf Stew": "生狼肉汤",
    "Prepared Pine Needles": "处理好的松针",
    "Dry Milk Packet": "奶粉袋",
    "Hot Cocoa Bag": "热可可包",
    "Hot Cocoa Box": "热可可盒",
    "Raw Rice": "生米",
    "Fir Seed Bunch": "冷杉种子串",
    "Fir Cone Seeds": "冷杉球果种子",
}


# 游戏内 InventoryCategory 给不出的类别,按原版清单的归法手动指定;
# 名字也在这里覆盖(卡片和蜡烛在 mod 里共用一个本地化键,不改会出现 16 对同名条目)
CATEGORY_FIX = [
    ("GEAR_TV_", "装饰"), ("GEAR_candle", "装饰"), ("GEAR_card", "装饰"),
    ("GEAR_Book10", "工具"), ("GEAR_CarbonFilter", "工具"),
]
NAME_FIX = {"GEAR_TV_WALL": "壁挂液晶电视"}


def localization(z):
    """{key: {语言: 文本}}"""
    for n in z.namelist():
        if n.lower().endswith(".json") and "local" in n.lower():
            try:
                return loose_json(z.read(n).decode("utf-8-sig"))
            except Exception:
                pass
    return {}


def main():
    known = db_prefabs("ItemDatabase.cs") | db_prefabs("ItemDatabaseMod.cs")
    known_lower = {k.lower() for k in known}
    items = mod_items()
    loc_cache = {}

    rows, unnamed, case_only = [], [], []
    for prefab, (mod, d) in sorted(items.items()):
        if prefab in known:
            continue
        # 只是大小写不一样的,不能当新物品加,否则清单里出现两条同一个东西
        if prefab.lower() in known_lower:
            case_only.append(prefab)
            continue
        comp_name = component_of(d)
        if comp_name in SKIP_COMPONENT or "note" in prefab.lower():
            continue
        comp = d.get(comp_name, {})

        modbase = mod[:-len(".modcomponent")]
        if modbase not in loc_cache:
            with zipfile.ZipFile(os.path.join(MODS, mod)) as z:
                loc_cache[modbase] = localization(z)
        loc = loc_cache[modbase]

        key = comp.get("DisplayNameLocalizationId", "")
        entry = loc.get(key, {})
        en = entry.get("English", "").strip()
        zh = entry.get("Simplified Chinese", "").strip()
        if not zh:
            zh = ZH.get(en, "")
        if not zh:
            unnamed.append((prefab, mod, en, key))
            continue

        zh = NAME_FIX.get(prefab, zh)
        if prefab.startswith("GEAR_card"):
            zh = "卡片-" + zh.replace("蜡烛熊-", "")
        cat = CATEGORY.get(comp.get("InventoryCategory", ""), "材料")
        for prefix, fixed in CATEGORY_FIX:
            if prefab.startswith(prefix):
                cat = fixed
                break
        # 能吃的一律进食物/饮料,游戏内分类经常写成 FirstAid 之类的怪值
        cal = comp.get("Calories", 0) or 0
        if comp_name in ("ModFoodComponent", "ModCookableComponent") and cat not in ("食物", "饮料"):
            cat = "食物"
        weight = comp.get("WeightKG", 0) or 0
        tag = TAG.get(modbase, modbase)
        rows.append((prefab, f"{zh} [{tag}]", cat, weight, int(cal)))

    print(f"// 共 {len(rows)} 条,由 tools/gen_missing_items.py 生成")
    for prefab, name, cat, weight, cal in rows:
        cal_part = f", {cal}" if cal else ""
        print(f'    new ItemEntry("{prefab}", "{name}", "{cat}", "", {weight}f{cal_part}),')

    if unnamed:
        print(f"\n// 缺中文名、没生成的 {len(unnamed)} 条(需要往 ZH 表里补译名):", file=sys.stderr)
        for prefab, mod, en, key in unnamed:
            print(f"//   {prefab:34} en={en!r:34} key={key} ({mod})", file=sys.stderr)
    if case_only:
        print(f"\n// 只是大小写和清单不一致的 {len(case_only)} 条(没当新物品加,要单独核对):", file=sys.stderr)
        for prefab in case_only:
            print(f"//   {prefab}", file=sys.stderr)


if __name__ == "__main__":
    main()
