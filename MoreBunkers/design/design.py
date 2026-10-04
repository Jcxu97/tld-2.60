# 三个地堡的布置。改这里,再跑 python design.py 生成 ../src/Layouts.g.cs 和俯视图用的 overlay.json
# 坐标是房间坐标(米),x 东 z 北。face 是正面朝向,0 朝 +z,90 朝 +x,180 朝 -z,270 朝 -x
# 摆件中心 (x,z) 是占地中心;程序会沿背面方向把它推到墙上
# levels 从下往上,每层一组 (物品, 最少, 最多);theme 是箱子里装什么;on=-1 叠在上一件上面,mount 是叠的高度
import json, math, os, sys
sys.path.insert(0, os.path.dirname(os.path.abspath(__file__)))
from furniture import FURN

from layouts import LAYOUTS


def rot_y(p):
    if p['f'] is None:
        return p['face']
    return p['face']


def overlay():
    out = {}
    for bid, L in LAYOUTS.items():
        rows = out.setdefault(L['interior'], [])
        for i, p in enumerate(L['pieces']):
            if 'on' in p:
                continue
            if p['f'] is None:
                n = len(p['items'])
                g = p['line']['gap']
                a = math.radians(p['line']['dir'])
                cx = p['x'] + math.sin(a) * g * (n - 1) / 2
                cz = p['z'] + math.cos(a) * g * (n - 1) / 2
                rows.append([cx, cz, 0.5, g * n, p['line']['dir'], 'bows'])
                continue
            F = FURN[p['f']]
            # 占地中心就是设计坐标,这里只画占地框
            rows.append([p['x'], p['z'], F['w'], F['d'], rot_y(p), f"{i}{p['f'][:6]}"])
    return out


def q(s):
    return '"' + s + '"'


def grp(g):
    return 'new G[] { ' + ', '.join(f'new G({q(t[0])}, {t[1]}, {t[2]}' + (f', {t[3]})' if len(t) > 3 else ')') for t in g) + ' }'


def gen_cs():
    o = ['// 由 design/design.py 生成,改布置去改那边', 'namespace MoreBunkers;', '',
         'internal static partial class Layouts', '{',
         '    internal static readonly System.Collections.Generic.Dictionary<string, Furn> Furniture = new()', '    {']
    for k, F in FURN.items():
        lv = ', '.join(f'new Level({a}f, {b}f, {c}f, {d}f, {e}f, {h}f)' for a, b, c, d, e, h in F['levels'])
        o.append(f'        [{q(k)}] = new Furn({q(F["path"])}, {F["w"]}f, {F["d"]}f, {F["cx"]}f, {F["cz"]}f, {F["h"]}f, {F["root_y"]}f, {F["yaw0"]}f, new Level[] {{ {lv} }}),')
    o += ['    };', '',
          '    internal static readonly System.Collections.Generic.Dictionary<string, Layout> All = new()', '    {']
    for bid, L in LAYOUTS.items():
        o.append(f'        [{q(bid)}] = new Layout({q(L["interior"])}, new Piece[]')
        o.append('        {')
        for p in L['pieces']:
            a = [f'F = {q(p["f"]) if p["f"] else "null"}', f'X = {p.get("x", 0)}f', f'Z = {p.get("z", 0)}f', f'Face = {p.get("face", 0)}f']
            if 'on' in p:
                a.append(f'On = {p["on"]}')
            if p.get('free'):
                a.append('Free = true')
            if 'mount' in p:
                a.append(f'Mount = {p["mount"]}f')
            if 'rack' in p:
                a.append('Rack = new[] { ' + ', '.join(q(r) for r in p['rack']) + ' }')
            if 'levels' in p:
                a.append('Levels = new[] { ' + ', '.join(grp(g) for g in p['levels']) + ' }')
            if 'theme' in p:
                a.append('Theme = ' + grp(p['theme']))
            if 'station' in p:
                a.append(f'Station = {q(p["station"])}')
            if 'line' in p:
                a += [f'LineDir = {p["line"]["dir"]}f', f'LineGap = {p["line"]["gap"]}f',
                      'Items = new[] { ' + ', '.join(q(r) for r in p['items']) + ' }']
            o.append('            new Piece { ' + ', '.join(a) + ' },')
        o.append('        }),')
    o += ['    };', '}']
    return '\n'.join(o) + '\n'


if __name__ == '__main__':
    here = os.path.dirname(os.path.abspath(__file__))
    open(os.path.join(here, '..', 'src', 'Layouts.g.cs'), 'w', encoding='utf-8').write(gen_cs())
    json.dump(overlay(), open(os.path.join(here, 'overlay.json'), 'w'))
    print('ok')
