# V13.0 Quark extras: MoreBunkers v1.5 zip into 3_功能mods 选装, then retire the two old solo zips that get replaced.
import json, os, sys, time
sys.path.insert(0, os.path.dirname(os.path.abspath(__file__)))
import release as R

SUB = '2a0f0b00d603426985a5f93326c2166d'
MB = r'C:\Users\82077\Desktop\TLD\零散MODS\MoreBunkers-v1.5_更多地堡三个新地堡_适配2.60_解压到游戏根目录.zip'
OLD_MB = 'MoreBunkers-v1.4_更多地堡三个新地堡_适配2.59_解压到游戏根目录.zip'
SOLO_TOP = '我们修好的mod_单独版_适配2.60'
SOLO_OLD = ['RarityRework_物品稀有度重制_适配2.60_解压到游戏根目录.zip', 'SCPlusFix++_自定义安全屋修复版_适配2.60_解压到游戏根目录.zip']

R.net_folders = lambda v: {'xz': (SUB, '3_功能mods 选装', [OLD_MB])}
R.upload_targets = lambda keys: [('xz', [MB])]
R.upload(['xz'])

stamp = time.strftime('%m%d-%H%M') + ' 单独版替换下来的'
r = R.bh(f"""
top = [i for i in ls({json.dumps(SUB)}) if i['dir'] and i['name'] == {json.dumps(SOLO_TOP, ensure_ascii=False)}][0]['fid']
stale = [i for i in ls(top) if not i['dir'] and i['name'] in {json.dumps(SOLO_OLD, ensure_ascii=False)}]
if stale:
    box = mkdir({json.dumps(R.NET_OLD)}, {json.dumps(stamp, ensure_ascii=False)})
    mv([i['fid'] for i in stale], box)
close_tab()
done([i['name'] for i in stale])
""")
print('solo moved to OLD:', r)
