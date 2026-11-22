# 离线检查布置:货架每层按游戏里同样的排法摆一遍,数量按上限算,看放不放得下、高度够不够
# 物品尺寸来自 _work/interiors/prefabs_shelfitems.json(prefab.py 导出)
import json, math, os, sys
sys.path.insert(0, os.path.dirname(os.path.abspath(__file__)))
from furniture import FURN
from layouts import LAYOUTS

ITEM_GAP, GROUP_GAP = 0.025, 0.08
R = json.load(open('D:/Github/tld--2.55/_work/interiors/prefabs_shelfitems.json'))
SKIP = ('_Old', 'LOD1', 'LOD2', 'Inspect', 'Shadow')


def box(g):
    rows = R.get('GEAR_' + g)
    if rows is None:
        return None
    rs = [r for r in rows if r[0] == 'R' and not any(s in r[1] for s in SKIP)] or [r for r in rows if r[0] == 'B']
    mn = [min(r[4 + i] for r in rs) for i in range(3)]
    mx = [max(r[7 + i] for r in rs) for i in range(3)]
    return mn, mx


STACK = {'ArrowManufactured', 'Tinder', 'RifleAmmoCasing', 'RevolverAmmoCasing', 'FlareGunAmmoSingle', 'Stick', 'BarkTinder'}


def check_level(lv, groups):
    top, x0, x1, z0, z1, clear = lv
    depth = z1 - z0
    total = 0.0
    msgs = []
    for k, t in enumerate(groups):
        g, a, b = t[:3]
        pile = t[3] if len(t) > 3 else 1
        if g.startswith('~'):
            total += float(g[1:]) + (GROUP_GAP if k else 0)
            continue
        boxes = [box(n) for n in g.split('|')]
        if any(x is None for x in boxes):
            msgs.append(f'{g}: no size data')
            continue
        mn = [min(x[0][i] for x in boxes) for i in range(3)]
        mx = [max(x[1][i] for x in boxes) for i in range(3)]
        sx, sy, sz = mx[0] - mn[0], mx[1] - mn[1], mx[2] - mn[2]
        n = math.ceil(b / 10) if g in STACK else b
        turn = (sx < sz) if sz > depth else (sx <= depth and sz < sx)
        wid, dep = (sz, sx) if turn else (sx, sz)
        tiers = max(1, min(pile, int((clear - 0.02) // max(0.01, sy)), 6))
        per = max(1, int((depth + ITEM_GAP) // (dep + ITEM_GAP)))
        cols = math.ceil(n / (per * tiers))
        gw = cols * wid + (cols - 1) * ITEM_GAP
        total += gw + (GROUP_GAP if k else 0)
        if dep > depth + 0.01:
            msgs.append(f'{g} {dep:.2f} deep > {depth:.2f}')
        if sy > clear + 0.01:
            msgs.append(f'{g} {sy:.2f} tall > {clear:.2f}')
        if pile > 1 and tiers < pile:
            msgs.append(f'{g} piles only {tiers} high')
    # 游戏里量出来的物品往往比导出的大一点,留 15% 余量
    if total > (x1 - x0) * 0.85 + 0.001:
        msgs.append(f'width {total:.2f} > {x1 - x0:.2f}')
    return total, msgs


bad = 0
for bid, L in LAYOUTS.items():
    for i, p in enumerate(L['pieces']):
        if 'levels' not in p:
            continue
        F = FURN[p['f']]
        for li, groups in enumerate(p['levels']):
            if li >= len(F['levels']):
                print(f'{bid}/{i} {p["f"]}: level {li} does not exist')
                bad += 1
                continue
            total, msgs = check_level(F['levels'][li], groups)
            tag = 'OK ' if not msgs else 'BAD'
            if msgs:
                bad += 1
            print(f'{tag} {bid}/{i} {p["f"]} L{li} {total:.2f}/{F["levels"][li][2] - F["levels"][li][1]:.2f} ' + '; '.join(msgs))
print('problems:', bad)
