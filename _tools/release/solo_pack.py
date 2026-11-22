import json, os, shutil, subprocess, sys, zipfile

ST = r'D:\Github\tld--2.55\_work\release\staging'
SRCS = [os.path.join(ST, 'sb_full'), os.path.join(ST, 'ultimate')]
OUT = r'C:\Users\82077\Desktop\TLD\零散MODS\我们修好的mod_单独版_适配2.60'
BZ = r'C:\Program Files (x86)\Bandizip\bz.exe'
PW = 'tld2026'
VOL = 20971520
GV = '2.60'

CN = {
    'Architect': '建筑_自由建造',
    'Bountiful_Foraging': '丰饶采集',
    'CampingTools': '露营工具',
    'ClothingExpanded': '服装拓展',
    'ClothingTweaker2': '衣物调整2',
    'ComplexLogger': '日志前置库',
    'ExamineActionsAPI': '检查动作前置库',
    'FoodPackByTKG': 'TKG食物包',
    'FoodsByCalorieWaltz': '卡路里华尔兹食物包',
    'GearInfo': '物品信息',
    'IndoorsGreenery': '室内绿植',
    'PickWaterFromFishingHoles': '冰洞取水',
    'PineNeedleTea': '松针茶',
    'ResearchBookTweaker': '研究书调整',
    'StalkerAidsAndSupplements': '潜行者药品补剂',
    'BlueprintCleaner': '蓝图清理',
    'MiseryModePlus': '厄难模式加强',
    'PerfectPlacement': '完美摆放',
    'FiligranisSkills': '新技能前置库',
    'PrepperCache': '地堡标记',
    'ItemPicker': '自动拾取',
    'TheLongDevelopment': '材质包',
    'PredatorSpawnSelector': '掠食者刷新调整',
    'SCPlusFix++': '自定义安全屋修复版',
    'MotionTrackerLite': '动物雷达',
    'ObjectSinkFix': '家具下沉修复',
    'RarityRework': '物品稀有度重制',
    'Episode5ShotgunPrototype': '第五章霰弹枪移植',
    'Episode5SurvivalItems': '第五章生存物品',
}
BIG = {'Episode5ShotgunPrototype', 'Episode5SurvivalItems', 'TheLongDevelopment'}


def find(rel):
    for s in SRCS:
        p = os.path.join(s, rel)
        if os.path.exists(p):
            return p
    raise FileNotFoundError(rel)


def files_of(rel):
    p = find(rel)
    if os.path.isfile(p):
        return [(p, rel)]
    out = []
    for root, _, fs in os.walk(p):
        for f in fs:
            full = os.path.join(root, f)
            out.append((full, os.path.join(rel, os.path.relpath(full, p)).replace('\\', '/')))
    return out


def entries(mod, info, scan):
    rels = list(info['own']) + list(info['deps'])
    if any(r.endswith('.modcomponent') for r in info['own']) and 'Mods/ModComponent.dll' not in rels:
        rels.append('Mods/ModComponent.dll')
        rels += [d for d in scan_deps('Mods/ModComponent.dll', scan) if d not in rels]
    out = []
    for r in rels:
        out += files_of(r)
    return out


def scan_deps(rel, scan):
    # ModComponent's own deps, taken from any mod that already pulled it in
    for v in scan.values():
        if rel in v['deps']:
            return [d for d in v['deps'] if d != rel and d in ('Mods/ModSettings.dll', 'Mods/ModData.dll')]
    return ['Mods/ModSettings.dll']


def main():
    scan = json.load(open(sys.argv[1], encoding='utf-8'))
    os.makedirs(OUT, exist_ok=True)
    only = set(sys.argv[2:])
    for mod, info in scan.items():
        if only and mod not in only:
            continue
        ents = entries(mod, info, scan)
        name = f'{mod}_{CN[mod]}_适配{GV}_解压到游戏根目录'
        if mod in BIG:
            tmp = os.path.join(os.environ['TEMP'], 'solo_' + mod)
            shutil.rmtree(tmp, ignore_errors=True)
            for src, rel in ents:
                dst = os.path.join(tmp, rel)
                os.makedirs(os.path.dirname(dst), exist_ok=True)
                shutil.copy2(src, dst)
            folder = os.path.join(OUT, name)
            shutil.rmtree(folder, ignore_errors=True)
            os.makedirs(folder)
            binp = os.path.join(os.environ['TEMP'], f'solo_{mod}.7z')
            if os.path.exists(binp):
                os.remove(binp)
            subprocess.run([BZ, 'c', '-y', '-fmt:7z', '-l:5', f'-p:{PW}', binp] + [os.path.join(tmp, d) for d in os.listdir(tmp)], check=True, stdout=subprocess.DEVNULL)
            i = 1
            with open(binp, 'rb') as f:
                while True:
                    b = f.read(VOL)
                    if not b:
                        break
                    open(os.path.join(folder, f'{mod}_分卷.{i:03d}'), 'wb').write(b)
                    i += 1
            os.remove(binp)
            shutil.rmtree(tmp)
            print(f'{mod}: {i - 1} volumes, {len(ents)} files')
        else:
            zp = os.path.join(OUT, name + '.zip')
            with zipfile.ZipFile(zp, 'w', zipfile.ZIP_DEFLATED) as z:
                for src, rel in ents:
                    z.write(src, rel)
            print(f'{mod}: {os.path.getsize(zp)} bytes, {len(ents)} files')


main()
