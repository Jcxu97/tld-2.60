import json, re, os
T = r"C:\Users\82077\AppData\Local\Temp\tlddiff"
src = r"D:\Github\tld--2.55\TldHacks\src"
table = json.load(open(r"D:\Github\tld--2.55\ItemRaritiesFix\ItemRarities.Resources.ItemRarities.json", encoding="utf-8-sig"))
TIERS = ["Common", "Uncommon", "Rare", "Epic", "Legendary", "Mythic"]
old = {g: TIERS.index(r) + 1 for r, names in table.items() for g in names}

entry = re.compile(r'new ItemEntry\("(GEAR_[A-Za-z0-9_]+)", "([^"]*)", "([^"]*)", "([^"]*)", ([0-9.]+)f?(?:, (-?[0-9]+))?')
items = {}
for fn, kind in (("ItemDatabase.cs", "vanilla"), ("ItemDatabaseMod.cs", "mod")):
    for m in entry.finditer(open(os.path.join(src, fn), encoding="utf-8-sig").read()):
        items.setdefault(m.group(1), dict(zh=m.group(2), cat=m.group(3), w=float(m.group(5)), cal=int(m.group(6) or 0), kind=kind))

loc = json.load(open(T + r"\loc_all.json", encoding="utf-8"))
missing = [l.rstrip("\n").split("\t") for l in open(T + r"\rarity_missing.tsv", encoding="utf-8") if l.strip()]
universe = set(old) | set(items) | {r[1] for r in missing}
ironroad = ["GEAR_WhaleOilHeater", "GEAR_WhaleOilCan", "GEAR_TrainBrakePad", "GEAR_IronRoadTrainKey", "GEAR_IronRoadTrainMap",
            "GEAR_IronRoadAnnaIslandMap1", "GEAR_IronRoadAnnaIslandMap2", "GEAR_IronRoadChurchMap", "GEAR_IronRoadBoatMessagePlay",
            "GEAR_IronRoadHIddenTrainLoreMcLeod"] + ["GEAR_WaxCylinder%d" % i for i in range(1, 17)]
universe |= set(ironroad)
junk = re.compile(r"(_Dif|_Mat|_Spoiled_Dif)$|^GEAR_NULL$|_Dummy$|^GEAR_Travois_Inventory$")

rows = []
for g in sorted(universe):
    if junk.search(g):
        continue
    it = items.get(g, {})
    zh = it.get("zh", "")
    if not zh:
        base = g[5:]
        for k in ("GAMEPLAY_" + base, "GAMEPLAY_" + base.replace("_", "")):
            if k in loc:
                zh = loc[k]["zh"]
                break
    if not zh and g.startswith("GEAR_WaxCylinder"):
        zh = "蜡筒 %02d" % int(g[16:])
    if g == "GEAR_WhaleOilCan":
        zh = loc["GAMEPLAY_WhaleOil"]["zh"]
    m = re.search(r"\[([^\]]+)\]\s*$", zh)
    tag = m.group(1) if m else ""
    kind = it.get("kind") or ("ironroad" if g in ironroad else ("vanilla" if g in old else "catalog"))
    rows.append([g, zh, it.get("cat", ""), str(it.get("w", "")), str(it.get("cal", "")), kind, tag, str(old.get(g, ""))])

os.makedirs(T + r"\rr", exist_ok=True)
with open(T + r"\rr\master.tsv", "w", encoding="utf-8", newline="\n") as f:
    f.write("gear\tzh\tcat\tweight\tcal\tkind\ttag\told\n")
    for r in rows:
        f.write("\t".join(r) + "\n")
import collections
print(len(rows), collections.Counter(r[5] for r in rows), "no zh", sum(1 for r in rows if not r[1]))
print(collections.Counter(r[6] for r in rows if r[5] == "mod").most_common(40))
