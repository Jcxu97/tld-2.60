import sys
exec(open(r'D:\Github\tld--2.55\_tools\release\bh_baidu.py', encoding='utf-8').read())
goto('https://pan.baidu.com/disk/main')
time.sleep(5)
V_OLD, V_NEW = '12.1', '12.2'
names = {
    'min': '1_TldHacks-v{}最小安装包_只有修改器',
    'full': '1_TldHacks-v{}完整版_带其他mods例如地图',
    'ul': '2_TldHacks-v{}终极版_更多MOD食物衣服_适配最新铁路DLC',
}
# 一次只处理要传的包:先 min 和 full,终极版打好再改成 ['ul'] 跑一遍
ONLY = ['min', 'full']
names = {k: v for k, v in names.items() if k in ONLY}
retire = {'min': ['TldHacks-v'], 'full': ['材质包备份.'], 'ul': ['TldHacks-v', '终极版材质包备份.', '终极版_安装说明.txt']}
bd = token()
root = {i['name']: i for i in ls(ROOT)}
box = OLD + '/' + time.strftime('%m%d-%H%M') + ' 替换下来的'
log = []
made = False
for k, pat in names.items():
    cur = pat.format(V_NEW) if pat.format(V_NEW) in root else pat.format(V_OLD)
    path = ROOT + '/' + cur
    stale = [i['path'] for i in ls(path) if not i['dir'] and any(i['name'].startswith(p) for p in retire[k])]
    if stale:
        if not made:
            mkdir(bd, box); made = True
        mv(bd, stale, box)
        log.append((k, 'moved', [s.rsplit('/', 1)[1] for s in stale]))
    if cur != pat.format(V_NEW):
        rename(bd, path, pat.format(V_NEW))
        log.append((k, 'renamed', pat.format(V_NEW)))
time.sleep(2)
after = {}
for k, pat in names.items():
    after[k] = [i['name'] for i in ls(ROOT + '/' + pat.format(V_NEW))]
close_tab()
done(dict(log=log, box=box if made else None, after=after))
