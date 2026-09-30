# 对比「已装 mod 实际注册的物品」和「ItemDatabaseMod.cs 里写死的清单」,列出缺口。
# 背景:ItemDatabaseMod.cs 是快照,原来的生成脚本已经丢了,mod 一更新清单就落后。
# .modcomponent 是 ZIP;里面 auto-mapped/*.json 一个文件 = 一个注册进游戏的物品,
# blueprints/(配方)、gear-spawns/(刷新点)、recipes/ 都不新增物品。
import json
import os
import re
import sys
import zipfile

MODS = r"D:\Steam\steamapps\common\TheLongDark\Mods"
SRC = r"D:\Github\tld--2.55\TldHacks\src"


def db_prefabs(name):
    src = open(os.path.join(SRC, name), encoding="utf-8-sig").read()
    return set(re.findall(r'new ItemEntry\("([^"]+)"', src))


def mod_items():
    """{prefab: (mod文件名, json内容)} —— 只收 auto-mapped 下真正注册的物品。
    auto-mapped 的文件名是全小写,prefab 的正确大小写要去 bundle/catalog 里对。"""
    out = {}
    for f in sorted(os.listdir(MODS)):
        if not f.lower().endswith(".modcomponent"):
            continue
        try:
            z = zipfile.ZipFile(os.path.join(MODS, f))
        except zipfile.BadZipFile:
            print(f"[跳过] {f} 不是 ZIP", file=sys.stderr)
            continue
        with z:
            # 这个包里出现过的 GEAR_ 名(带正确大小写)
            canon = {}
            for n in z.namelist():
                if "catalog" not in n.lower() or not n.lower().endswith(".json"):
                    continue
                for name in re.findall(r"GEAR_[A-Za-z0-9_]+", z.read(n).decode("utf-8", "ignore")):
                    canon.setdefault(name.lower(), name)

            for n in z.namelist():
                if not n.startswith("auto-mapped/") or not n.endswith(".json"):
                    continue
                try:
                    d = loose_json(z.read(n).decode("utf-8-sig"))
                except Exception as ex:
                    print(f"[跳过] {f}:{n} {ex}", file=sys.stderr)
                    continue
                prefab = d.get("GearName") or os.path.splitext(os.path.basename(n))[0]
                if not prefab.startswith("GEAR_"):
                    prefab = "GEAR_" + prefab
                prefab = canon.get(prefab.lower(), prefab)
                out[prefab] = (f, d)
    return out


def loose_json(text):
    """ModComponent 的 json 不是严格 json:结尾多逗号,偶尔带 // 注释"""
    text = re.sub(r"//[^\n\r]*", "", text)
    text = re.sub(r",(\s*[}\]])", r"\1", text)
    return json.loads(text)


def component_of(d):
    for k in d:
        if k.startswith("Mod") and isinstance(d[k], dict):
            return k
    return "?"


def main():
    vanilla = db_prefabs("ItemDatabase.cs")
    modded = db_prefabs("ItemDatabaseMod.cs")
    known = vanilla | modded
    items = mod_items()

    print(f"原版清单 {len(vanilla)} 条,mod 清单 {len(modded)} 条,重复 {len(vanilla & modded)} 条")
    print(f"已装 mod 注册的物品 {len(items)} 个")

    known_lower = {k.lower(): k for k in known}
    missing, wrong_case = {}, []
    for p, v in items.items():
        if p in known:
            continue
        if p.lower() in known_lower:
            wrong_case.append((known_lower[p.lower()], p))   # 清单里大小写写错了 → 运行时静默失效
        else:
            missing[p] = v
    print(f"缺口 {len(missing)} 个,大小写写错 {len(wrong_case)} 个\n")

    by_mod = {}
    for p, (mod, d) in missing.items():
        by_mod.setdefault(mod, []).append((p, d))
    for mod in sorted(by_mod, key=lambda m: -len(by_mod[m])):
        rows = sorted(by_mod[mod])
        print(f"== {mod}  缺 {len(rows)} 个 ==")
        for p, d in rows:
            c = d.get(component_of(d), {})
            print("   {:38} {:28} w={:<6} cal={}".format(
                p, component_of(d), c.get("WeightKG", d.get("WeightKG", "?")),
                c.get("Calories", d.get("Calories", "-"))))
        print()

    if wrong_case:
        print("== 清单里大小写和 mod 里不一致(运行时会被 IsValid 静默隐藏)==")
        for db_name, real in sorted(wrong_case):
            print(f"   清单:{db_name:38} mod 里实际:{real}")
        print()

    # 反向:清单里有、但已装 mod 里找不到的(禁用或改名的僵尸条目)
    zombie = sorted(modded - set(items) - vanilla)
    print(f"== 清单里的僵尸条目(当前 mod 里找不到,运行时会被 IsValid 隐藏):{len(zombie)} 个 ==")
    print("   " + ", ".join(zombie[:20]) + (" ..." if len(zombie) > 20 else ""))


if __name__ == "__main__":
    main()
