# V12.9 Baidu check: count files and duplicates in the three package folders. Run: browser-harness < bd_check129.py
exec(open(r'D:\Github\tld--2.55\_tools\release\bh_baidu.py', encoding='utf-8').read())
goto('https://pan.baidu.com/disk/main')
time.sleep(5)
pats = {
    'min': '1_TldHacks-v{}最小安装包_只有修改器',
    'full': '1_TldHacks-v{}完整版_带其他mods例如地图',
    'ul': '2_TldHacks-v{}终极版_更多MOD食物衣服_适配最新铁路DLC',
}


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


out = {}
for k, pat in pats.items():
    ns = [n for n, isdir, _ in names(ROOT + '/' + pat.format('12.9')) if not isdir]
    out[k] = [len(ns), [n for n in ns if '(1)' in n or '(2)' in n][:10]]
close_tab()
done(out)
