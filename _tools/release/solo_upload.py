# Upload Desktop\TLD\零散MODS\我们修好的mod_单独版_适配2.60 (zips, notes and three volume folders) into 3_功能mods 选装.
# Run: python solo_upload.py quark | baidu
import json, os, subprocess, sys, time, urllib.parse

HERE = os.path.dirname(os.path.abspath(__file__))
LOCAL = r'C:\Users\82077\Desktop\TLD\零散MODS\我们修好的mod_单独版_适配2.60'
TOP = os.path.basename(LOCAL)
NO_WINDOW = 0x08000000
FLAG = os.path.join(HERE, '..', '..', '_work', 'release', 'solo_upload.done')
Q_ROOT = ('0a583d04bfed47cd9c7ce2235c20e7d5', 'TLD V2.60 Hack')
Q_SUB = ('2a0f0b00d603426985a5f93326c2166d', '3_功能mods 选装')
B_SUB = '/TLD HACK V2.60/3_功能mods 选装'


def bh(head, code, timeout=180):
    r = subprocess.run(['browser-harness'], input=head + code, capture_output=True, text=True,
                       encoding='utf-8', errors='replace', timeout=timeout, creationflags=NO_WINDOW)
    for line in r.stdout.splitlines():
        if line.startswith('RESULT:'):
            return json.loads(line[7:])
    raise RuntimeError(r.stdout[-1500:] + r.stderr[-1500:])


def groups():
    # [(relative folder, [local files])]
    out = [('', sorted(os.path.join(LOCAL, f) for f in os.listdir(LOCAL) if os.path.isfile(os.path.join(LOCAL, f))))]
    for d in sorted(os.listdir(LOCAL)):
        p = os.path.join(LOCAL, d)
        if os.path.isdir(p):
            out.append((d, sorted(os.path.join(p, f) for f in os.listdir(p))))
    return out


def push(head, page_code, files, sel):
    code = page_code + f"""
import os
upload({json.dumps(sel)}, {json.dumps(files, ensure_ascii=False)})
end = time.time() + 7200
while time.time() < end and not os.path.exists({json.dumps(FLAG)}):
    time.sleep(5)
close_tab()
"""
    p = subprocess.Popen(['browser-harness'], stdin=subprocess.PIPE, stdout=subprocess.DEVNULL, stderr=subprocess.DEVNULL,
                         text=True, encoding='utf-8', creationflags=NO_WINDOW)
    p.stdin.write(head + code)
    p.stdin.close()
    return p


def wait_sizes(check, want):
    deadline = time.time() + 7200
    while time.time() < deadline:
        time.sleep(30)
        try:
            have = check()
        except Exception as e:
            print('size check failed:', str(e)[:200], flush=True)
            continue
        miss = [n for n, s in want.items() if have.get(n) != s]
        if not miss:
            return True
        print('waiting for', len(miss), 'files', miss[:3], flush=True)
    return False


def quark():
    head = open(os.path.join(HERE, 'bh_quark.py'), encoding='utf-8').read()
    gs = groups()
    fids = bh(head, f"""
goto('https://pan.quark.cn/list#/list/all')
time.sleep(3)
sub = {json.dumps(Q_SUB[0])}
top = [i for i in ls(sub) if i['dir'] and i['name'] == {json.dumps(TOP, ensure_ascii=False)}]
top = top[0]['fid'] if top else mkdir(sub, {json.dumps(TOP, ensure_ascii=False)})
have = {{i['name']: i['fid'] for i in ls(top) if i['dir']}}
res = {{'': top}}
for d in {json.dumps([d for d, _ in gs if d], ensure_ascii=False)}:
    res[d] = have.get(d) or mkdir(top, d)
close_tab()
done(res)
""")
    for d, files in gs:
        fid = fids[d]
        chain = [Q_ROOT, Q_SUB, (fids[''], TOP)] + ([(fid, d)] if d else [])
        url = 'https://pan.quark.cn/list#/list/all/' + '/'.join(f'{f}-{n}' for f, n in chain)
        have0 = bh(head, f"goto('https://pan.quark.cn/list#/list/all')\ntime.sleep(2)\nh={{i['name']: i['size'] for i in ls({json.dumps(fid)})}}\nclose_tab()\ndone(h)")
        want = {os.path.basename(f): os.path.getsize(f) for f in files}
        todo = [f for f in files if have0.get(os.path.basename(f)) != os.path.getsize(f)]
        print(f'quark {d or TOP}: {len(todo)} of {len(files)} to upload', flush=True)
        if not todo:
            continue
        if os.path.exists(FLAG):
            os.remove(FLAG)
        p = push(head, f"goto({json.dumps(url, ensure_ascii=False)})\ntime.sleep(5)\n", todo, '#ListHeader-file')
        ok = wait_sizes(lambda: bh(head, f"goto('https://pan.quark.cn/list#/list/all')\ntime.sleep(2)\nh={{i['name']: i['size'] for i in ls({json.dumps(fid)})}}\nclose_tab()\ndone(h)"), want)
        open(FLAG, 'w').close()
        p.wait(timeout=120)
        os.remove(FLAG)
        print(f'quark {d or TOP}:', 'sizes match' if ok else 'TIMEOUT', flush=True)
        if not ok:
            sys.exit(1)


def baidu():
    head = open(os.path.join(HERE, 'bh_baidu.py'), encoding='utf-8').read()
    paged = '''
def lsall(d):
    out, page = [], 1
    while True:
        eval_js("window.__n=null;fetch('/api/list?dir='+encodeURIComponent(%s)+'&num=100&page=%d&order=name&web=1',{credentials:'include'}).then(r=>r.json()).then(j=>window.__n=JSON.stringify((j.list||[]).map(f=>[f.server_filename,f.size])))" % (json.dumps(d), page))
        v = None
        for _ in range(240):
            v = eval_js('window.__n')
            if v:
                break
            time.sleep(0.25)
        part = json.loads(v)
        out += part
        if len(part) < 100:
            return {n: s for n, s in out}
        page += 1
'''
    head = head + paged
    gs = groups()
    top = B_SUB + '/' + TOP
    bh(head, f"""
goto('https://pan.baidu.com/disk/main')
time.sleep(4)
bd = token()
names = [i['name'] for i in ls({json.dumps(B_SUB, ensure_ascii=False)})]
if {json.dumps(TOP, ensure_ascii=False)} not in names:
    mkdir(bd, {json.dumps(top, ensure_ascii=False)})
sub = [i['name'] for i in ls({json.dumps(top, ensure_ascii=False)})]
for d in {json.dumps([d for d, _ in gs if d], ensure_ascii=False)}:
    if d not in sub:
        mkdir(bd, {json.dumps(top, ensure_ascii=False)} + '/' + d)
close_tab()
done(1)
""")
    for d, files in gs:
        path = top + ('/' + d if d else '')
        chk = lambda: bh(head, f"goto('https://pan.baidu.com/disk/main')\ntime.sleep(4)\nh=lsall({json.dumps(path, ensure_ascii=False)})\nclose_tab()\ndone(h)")
        have0 = chk()
        want = {os.path.basename(f): os.path.getsize(f) for f in files}
        todo = [f for f in files if have0.get(os.path.basename(f)) != os.path.getsize(f)]
        print(f'baidu {d or TOP}: {len(todo)} of {len(files)} to upload', flush=True)
        if not todo:
            continue
        if os.path.exists(FLAG):
            os.remove(FLAG)
        p = push(head, f"goto('https://pan.baidu.com/disk/main#/index?category=all&path=' + {json.dumps(urllib.parse.quote(path))})\ntime.sleep(7)\n", todo, 'input[name=html5uploader]')
        ok = wait_sizes(chk, want)
        open(FLAG, 'w').close()
        p.wait(timeout=120)
        os.remove(FLAG)
        print(f'baidu {d or TOP}:', 'sizes match' if ok else 'TIMEOUT', flush=True)
        if not ok:
            sys.exit(1)


{'quark': quark, 'baidu': baidu}[sys.argv[1]]()
