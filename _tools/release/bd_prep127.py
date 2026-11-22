# V12.7 Baidu prep: move the V12.6 packages into OLD and rename the three folders. Run: browser-harness < bd_prep127.py
# ponytail: list folders page by page (100 per page); one /api/list call on the 183-file ultimate folder is too long for eval_js
exec(open(r'D:\Github\tld--2.55\_tools\release\bh_baidu.py', encoding='utf-8').read())
goto('https://pan.baidu.com/disk/main')
time.sleep(5)
V_OLD, V_NEW = '12.6', '12.7'
pats = {
    'min': '1_TldHacks-v{}最小安装包_只有修改器',
    'full': '1_TldHacks-v{}完整版_带其他mods例如地图',
    'ul': '2_TldHacks-v{}终极版_更多MOD食物衣服_适配最新铁路DLC',
}
retire = {'min': ['TldHacks-v'], 'full': ['材质包备份.'], 'ul': ['终极版材质包备份.', '终极版_安装说明.txt']}


def names(d):
    out, page = [], 1
    while True:
        eval_js("window.__n=null;fetch('/api/list?dir='+encodeURIComponent(%s)+'&num=100&page=%d&order=name&web=1',{credentials:'include'}).then(r=>r.json()).then(j=>window.__n=JSON.stringify((j.list||[]).map(f=>[f.server_filename,f.isdir,f.size])))" % (json.dumps(d), page))
        v = None
        for _ in range(240):
            v = eval_js('window.__n')
            if v:
                break
            time.sleep(0.25)
        part = json.loads(v)
        out += part
        if len(part) < 100:
            return out
        page += 1


bd = token()
root = {n for n, isdir, _ in names(ROOT) if isdir}
box = OLD + '/' + time.strftime('%m%d-%H%M') + ' v12.6 替换下来的'
log, made = [], False
for k, pat in pats.items():
    cur = pat.format(V_NEW) if pat.format(V_NEW) in root else pat.format(V_OLD)
    path = ROOT + '/' + cur
    stale = [path + '/' + n for n, isdir, _ in names(path) if not isdir and any(n.startswith(p) for p in retire[k])]
    if stale:
        if not made:
            mkdir(bd, box)
            made = True
        for i in range(0, len(stale), 40):
            mv(bd, stale[i:i + 40], box)
        log.append((k, 'moved', len(stale)))
    if cur != pat.format(V_NEW):
        rename(bd, path, pat.format(V_NEW))
        log.append((k, 'renamed', pat.format(V_NEW)))
time.sleep(2)
after = {k: len(names(ROOT + '/' + p.format(V_NEW))) for k, p in pats.items()}
close_tab()
done(dict(log=log, box=box if made else None, after=after))
