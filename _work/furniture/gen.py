# 用法: python -I gen.py deco.json ../../TldHacks/src/FurnitureDatabase.cs
# deco.json 由同目录 scan.py 扫游戏资源包得到(根物体带 DecorationItem 的预制体)
import json, re, sys

d = json.load(open(sys.argv[1], encoding='utf-8'))
skip_dir = re.compile(r'Sign|Corpses|OBJ_Bones|BuildingDebris|RubblePile', re.I)
skip_name = re.compile(r'^CORPSE_|_Cin_|Debris', re.I)
rows = []
for p, v in d.items():
    name = p.split('/')[-1][:-7]
    if not v['loc'] or ' ' in name or skip_name.search(name): continue
    if any(skip_dir.search(x) for x in p.split('/')[:-1]): continue
    rank = 0 if name.startswith('INTERACTIVE_') else 1 if name.startswith('CONTAINER_') else 2
    rows.append((rank, name.lower(), p, v['loc']))
rows.sort()

CARRY = [
    ('INTERACTIVE_AmmoWorkBench', '弹药工作台', 'Ammo Workbench'),
    ('INTERACTIVE_IndustrialMillingMachine', '铣床', 'Milling Machine'),
    ('INTERACTIVE_Forge', '锻炉', 'Forge'),
    ('INTERACTIVE_PotBellyStove', '大肚炉', 'Pot Belly Stove'),
    ('INTERACTIVE_StoveMetalA', '铁灶', 'Metal Stove'),
    ('INTERACTIVE_StoveWoodC', '双灶炉', 'Double Wood Stove'),
    ('CONTAINER_CoalBin', '煤箱', 'Coal Bin'),
    ('CONTAINER_FirewoodBin', '柴火箱', 'Firewood Bin'),
    ('CONTAINER_ForestryCrate', '林业箱', 'Forestry Crate'),
    ('CONTAINER_ForestryCrateB', '林业箱 B', 'Forestry Crate B'),
    ('CONTAINER_FlareGun', '信号枪箱', 'Flare Gun Case'),
]

out = [
    '// 由 _work/furniture/gen.py 生成,别手改。',
    'using System.Collections.Generic;',
    '',
    'namespace TldHacks;',
    '',
    'internal static class FurnitureDatabase',
    '{',
    '    // 原版收不进背包、靠 SCPlusFix++ 自己存档的器械,生成走它的 Spawner',
    '    public static readonly List<ItemEntry> Carryables = new List<ItemEntry>',
    '    {',
]
for key, zh, en in CARRY:
    out.append(f'    new ItemEntry("{key}", "{zh}", "家具", "", 0f) {{ NameEn = "{en}" }},')
out += [
    '    };',
    '',
    '    // 游戏自带装饰品组件的家具。PrefabName 是资源路径,Remark 放显示名的 locId',
    '    public static readonly List<ItemEntry> Native = new List<ItemEntry>',
    '    {',
]
for _, _, p, loc in rows:
    out.append(f'    new ItemEntry("{p}", "{p.split("/")[-1][:-7]}", "家具", "", 0f, 0, "{loc}"),')
out += ['    };', '}', '']
with open(sys.argv[2], 'w', encoding='utf-8-sig', newline='') as f:
    f.write(''.join(x + chr(13) + chr(10) for x in out))
print(len(rows))
