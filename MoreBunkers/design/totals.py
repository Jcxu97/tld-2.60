# 算每个地堡朝圣者下的总量(架子 + 箱子),和目标对一遍
# 热量、单位、升数来自 gear_stats.json(_work/interiors/gearstats.py 从游戏文件读出,_work 不进仓库)
# 用法: python totals.py [merc|stock|craft]   不带参数三个都算
import json, os, sys
sys.path.insert(0, os.path.dirname(os.path.abspath(__file__)))
from layouts import LAYOUTS

STATS = json.load(open(os.path.join(os.path.dirname(os.path.abspath(__file__)), 'gear_stats.json')))
DAYS, KCAL_DAY, WATER_DAY = 180, 2500, 1.7

# 每个地堡朝圣者下至少要有的量;None 表示不查
TARGET = {
    'stock': dict(kcal=DAYS * KCAL_DAY, Water1000ml=300, Coal=290, wood=300, MRE=115, CoffeeTin=36, GreenTeaPackage=36, HeavyBandage=55),
    'merc': dict(Water1000ml=48, MRE=(11, 13), EnergyBar=30, GranolaBar=30, wood=48, RifleAmmoBox=55),
    'craft': dict(Water1000ml=95, MRE=(55, 65), EnergyBar=30, GranolaBar=30, Coal=290, wood=240),
}
WOOD = ('Softwood', 'Hardwood', 'ReclaimedWoodB')


def groups(pieces):
    for p in pieces:
        for g in p.get('theme', []):
            yield g
        for lv in p.get('levels', []):
            for g in lv:
                yield g


def totals(bid):
    lo, hi = {}, {}
    for g in groups(LAYOUTS[bid]['pieces']):
        name, a, b = g[:3]
        if name.startswith('~'):
            continue
        kinds = name.split('|')
        for k in kinds:
            lo[k] = lo.get(k, 0) + a / len(kinds)
            hi[k] = hi.get(k, 0) + b / len(kinds)
    return lo, hi


def report(bid):
    lo, hi = totals(bid)
    kcal = [sum(STATS.get(k, {}).get('kcal', 0) * v for k, v in m.items()) for m in (lo, hi)]
    water = [sum(STATS.get(k, {}).get('liters', 0) * v for k, v in m.items() if k == 'Water1000ml') for m in (lo, hi)]
    wood = [sum(m.get(k, 0) for k in WOOD) for m in (lo, hi)]
    print(f'== {bid}: {kcal[0]:.0f}~{kcal[1]:.0f} kcal ({kcal[0] / KCAL_DAY:.0f}~{kcal[1] / KCAL_DAY:.0f} days), '
          f'water {water[0]:.0f}~{water[1]:.0f} L ({water[0] / WATER_DAY:.0f} days), wood {wood[0]:.0f}~{wood[1]:.0f}')
    bad = 0
    for key, want in TARGET.get(bid, {}).items():
        got = {'kcal': kcal[0], 'wood': wood[0]}.get(key, lo.get(key, 0))
        top = {'kcal': kcal[1], 'wood': wood[1]}.get(key, hi.get(key, 0))
        mn, mx = want if isinstance(want, tuple) else (want, None)
        ok = got >= mn and (mx is None or top <= mx)
        bad += not ok
        print(f'  {"OK " if ok else "BAD"} {key}: {got:.0f}~{top:.0f} (want {mn}{"~" + str(mx) if mx else "+"})')
    for k in sorted(lo):
        units = STATS.get(k, {}).get('units', 1)
        extra = f' x{units}' if units and units > 1 else ''
        print(f'    {k}: {lo[k]:.0f}~{hi[k]:.0f}{extra}')
    return bad


bad = sum(report(b) for b in (sys.argv[1:] or LAYOUTS))
print('problems:', bad)
