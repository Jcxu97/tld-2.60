# V13.0 Baidu extras prep: move the old MoreBunkers zip and the two replaced solo zips into OLD.
# Run: browser-harness < bdxz130_prep.py
# ponytail: list before token(); calling token() first made the next fetch fail on this page
exec(open(r'D:\Github\tld--2.55\_tools\release\bh_baidu.py', encoding='utf-8').read())
goto('https://pan.baidu.com/disk/main')
time.sleep(5)
XZ = ROOT + '/3_功能mods 选装'
SOLO = XZ + '/我们修好的mod_单独版_适配2.60'
old = [XZ + '/MoreBunkers-v1.4_更多地堡三个新地堡_适配2.59_解压到游戏根目录.zip',
       SOLO + '/RarityRework_物品稀有度重制_适配2.60_解压到游戏根目录.zip',
       SOLO + '/SCPlusFix++_自定义安全屋修复版_适配2.60_解压到游戏根目录.zip']


def names(d):
    eval_js("window.__n=null;fetch('/api/list?dir='+encodeURIComponent(%s)+'&num=100&order=name&web=1',{credentials:'include'}).then(r=>r.json()).then(j=>window.__n=JSON.stringify((j.list||[]).map(f=>[f.server_filename,f.isdir])))" % json.dumps(d))
    for _ in range(240):
        v = eval_js('window.__n')
        if v:
            return json.loads(v)
        time.sleep(0.25)
    raise RuntimeError('list timeout ' + d)


have = {XZ + '/' + n for n, _ in names(XZ)} | {SOLO + '/' + n for n, _ in names(SOLO)}
stale = [p for p in old if p in have]
box = None
if stale:
    bd = token()
    box = OLD + '/' + time.strftime('%m%d-%H%M') + ' v13.0 选装替换下来的'
    mkdir(bd, box)
    mv(bd, stale, box)
time.sleep(2)
left = [n for n, _ in names(SOLO)]
close_tab()
done(dict(moved=stale, box=box, solo_left=len(left), still=[p for p in old if p.rsplit('/', 1)[1] in left]))
