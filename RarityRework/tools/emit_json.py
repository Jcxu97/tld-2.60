import json, collections
T = r"C:\Users\82077\AppData\Local\Temp\tlddiff\rr"
P = r"D:\Github\tld--2.55\RarityRework"
KEYS = ["Common", "Uncommon", "Rare", "Epic", "Legendary", "Mythic"]
ZH = ["普通", "优秀", "精良", "史诗", "传说", "神话"]
ZHT = ["普通", "優秀", "精良", "史詩", "傳說", "神話"]

table = collections.OrderedDict((k, []) for k in KEYS)
for line in list(open(T + r"\tiers.tsv", encoding="utf-8"))[1:]:
    g, zh, tier = line.rstrip("\n").split("\t")[:3]
    table[KEYS[ZH.index(tier)]].append(g)
for k in table:
    table[k].sort()
json.dump(table, open(P + r"\RarityRework.Resources.RarityRework.json", "w", encoding="utf-8", newline="\n"), indent=2)

locp = P + r"\RarityRework.Resources.Localization.json"
loc = json.load(open(locp, encoding="utf-8-sig"))
for i, k in enumerate(KEYS):
    loc["GAMEPLAY_Rarity" + k]["Simplified Chinese"] = ZH[i]
    loc["GAMEPLAY_Rarity" + k]["Traditional Chinese"] = ZHT[i]
json.dump(loc, open(locp, "w", encoding="utf-8", newline="\n"), ensure_ascii=False, indent=2)
print({k: len(v) for k, v in table.items()}, sum(len(v) for v in table.values()))
