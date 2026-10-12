# TldHacks release: build, deploy, pack, verify, upload.
#   python release.py init            extract the current desktop packages into staging (one time)
#   python release.py pack [sb e5 st] build + deploy + pack + verify (no args = packages whose DLL changed)
#   python release.py upload [sb e5 st] move old network files to OLD, upload, check sizes
# Readme text stays manual: desktop outer readmes, and the readmes inside staging.
# SCPlusFix (fixed SafehouseCustomizationPlus) is built and packed with sb automatically.
import glob, hashlib, json, os, re, shutil, subprocess, sys, tempfile, time, zipfile

REPO = r'D:\Github\tld--2.55'
GAME = r'D:\Steam\steamapps\common\TheLongDark'
DESK = r'C:\Users\82077\Desktop\TLD'
STAGE = os.path.join(REPO, r'_work\release\staging')
MANIFEST = os.path.join(REPO, r'_work\release\manifest.json')
BZ = r'C:\Program Files (x86)\Bandizip\bz.exe'
PW = 'tld2026'
VOL = 20971520
STORY_DIR = os.path.join(DESK, 'The Long dark 故事剧情模式_可能有bug没测试')

PKGS = {
    'sb': dict(csproj=r'TldHacks\src\TldHacks.csproj', out=r'TldHacks\src\bin\Release\TldHacks.dll',
               game=r'Mods\TldHacks.dll'),
    'e5': dict(csproj=r'TldHacksEp5\TldHacksEp5.csproj', out=r'TldHacksEp5\bin\TldHacksEp5.dll',
               game=r'tld_dlc\episode5\Mods\TldHacksEp5.dll',
               dir=os.path.join(STORY_DIR, '剧情模式第五章'), bin='第五章剧情材质包.bin',
               vol='第五章剧情材质包备份', readme='第五章_解压说明.txt', root='episode5'),
    'st': dict(csproj=r'TldHacksStory\TldHacksStory.csproj', out=r'TldHacksStory\bin\TldHacksStory.dll',
               game=r'tld_dlc\wintermute\Mods\TldHacksStory.dll',
               dir=os.path.join(STORY_DIR, '剧情模式第一章到第四章'), bin='剧情材质包.bin',
               vol='剧情材质包备份', readme='剧情模式_解压说明.txt', root='wintermute'),
}

# Fixed Chinese build of SafehouseCustomizationPlus 1.9.4. It ships only inside the sandbox full package.
SCP = dict(csproj=r'SCPlusFix\SafehouseCustomizationPlus.csproj', out=r'SCPlusFix\bin\Release\SafehouseCustomizationPlus.dll',
           game=r'Mods\SafehouseCustomizationPlus.dll', stage=os.path.join('sb_full', 'Mods', 'SafehouseCustomizationPlus.dll'))


def sb_names(v):
    full = f'v{v}完整版_自己改后缀解压并把里面文件脱出到游戏根目录即可！按键在设置-Modseting里改！'
    return dict(
        min_cn=f'TldHacks-v{v}-最小安装包_只带修改mod！解压到游戏根目录.zip',
        min_en=f'TldHacks-v{v}-Minimal-Install-Extract-to-Game-Root.zip',
        dll_zip=f'TldHacksv{v}.zip',
        full_dir=os.path.join(DESK, f'V{v}完整版_带其他mods例如地图'),
        full=full, net_full=f'TldHacks-v{v}完整版_带其他mods例如地图')


def sb_version():
    s = open(os.path.join(REPO, r'TldHacks\src\ModMain.cs'), encoding='utf-8-sig').read()
    return re.search(r'VERSION\s*=\s*"([^"]+)"', s).group(1)


def md5(p):
    h = hashlib.md5()
    with open(p, 'rb') as f:
        for b in iter(lambda: f.read(1 << 20), b''):
            h.update(b)
    return h.hexdigest()


def tree_hashes(root):
    out = {}
    for d, _, fs in os.walk(root):
        for f in fs:
            p = os.path.join(d, f)
            out[os.path.relpath(p, root).replace('\\', '/')] = md5(p)
    return out


# 从没有控制台的父进程起 dotnet/7z/browser-harness 时,每个子进程都会弹一个黑窗
NO_WINDOW = getattr(subprocess, 'CREATE_NO_WINDOW', 0)


def run(cmd, **kw):
    r = subprocess.run(cmd, capture_output=True, text=True, encoding='utf-8', errors='replace', creationflags=NO_WINDOW, **kw)
    if r.returncode != 0:
        sys.exit(f'FAILED: {cmd}\n{r.stdout[-2000:]}\n{r.stderr[-2000:]}')
    return r.stdout


def load_manifest():
    return json.load(open(MANIFEST, encoding='utf-8')) if os.path.exists(MANIFEST) else {}


def save_manifest(m):
    json.dump(m, open(MANIFEST, 'w', encoding='utf-8'), ensure_ascii=False, indent=1)


def game_running():
    return 'tld.exe' in run(['tasklist', '/FI', 'IMAGENAME eq tld.exe']).lower()


def bz_x(archive, dest):
    os.makedirs(dest, exist_ok=True)
    run([BZ, 'x', '-y', f'-p:{PW}', f'-o:{dest}', archive])


def bz_c(archive, src_dir):
    if os.path.exists(archive):
        os.remove(archive)
    run([BZ, 'c', '-fmt:7z', '-l:9', f'-p:{PW}', archive, src_dir])


def split(binp, folder, base):
    for old in glob.glob(os.path.join(folder, base + '.0*')):
        os.remove(old)
    out = []
    with open(binp, 'rb') as f:
        i = 1
        while True:
            b = f.read(VOL)
            if not b:
                break
            p = os.path.join(folder, f'{base}.{i:03d}')
            open(p, 'wb').write(b)
            out.append(p)
            i += 1
    return out


def stage_dll(k):
    p = PKGS[k]
    name = os.path.basename(p['out'])
    if k == 'sb':
        return [os.path.join(STAGE, 'sb_min', 'Mods', name), os.path.join(STAGE, 'sb_full', 'Mods', name)]
    return [os.path.join(STAGE, k, p['root'], 'Mods', name)]


def init():
    if os.path.exists(STAGE):
        sys.exit(f'staging already exists: {STAGE}')
    n = sb_names(sb_version())
    with zipfile.ZipFile(os.path.join(DESK, n['min_cn'])) as z:
        z.extractall(os.path.join(STAGE, 'sb_min'))
    shutil.copytree(os.path.join(n['full_dir'], n['full']), os.path.join(STAGE, 'sb_full'))
    for k in ('e5', 'st'):
        bz_x(os.path.join(PKGS[k]['dir'], PKGS[k]['bin']), os.path.join(STAGE, k))
    save_manifest({k: md5(stage_dll(k)[0]) for k in PKGS})
    print('staging ready:', STAGE)


def build(k):
    run(['dotnet', 'build', os.path.join(REPO, PKGS[k]['csproj']), '-c', 'Release', '-nologo', '-v', 'q'])
    return os.path.join(REPO, PKGS[k]['out'])


def deploy(k, dll, spec=None):
    dst = os.path.join(GAME, (spec or PKGS[k])['game'])
    if os.path.exists(dst) and md5(dst) == md5(dll):
        return
    if os.path.exists(dst):
        shutil.copy2(dst, dst + '.backup-release')
    shutil.copy2(dll, dst)


def zip_dir(zpath, src, prefix=''):
    tmp = zpath + '.tmp'
    with zipfile.ZipFile(tmp, 'w', zipfile.ZIP_DEFLATED, compresslevel=9) as z:
        for d, ds, fs in os.walk(src):
            ds.sort()
            rel = os.path.relpath(d, src).replace(os.sep, '/')
            arcd = prefix + ('' if rel == '.' else rel + '/')
            if arcd:
                z.write(d, arcd)
            for f in sorted(fs):
                z.write(os.path.join(d, f), arcd + f)
    os.replace(tmp, zpath)


def verify_zip(zpath, src, prefix=''):
    want = tree_hashes(src)
    with zipfile.ZipFile(zpath) as z:
        bad = z.testzip()
        assert bad is None, f'{zpath}: bad entry {bad}'
        got = {}
        for i in z.infolist():
            if not i.is_dir():
                got[i.filename[len(prefix):]] = hashlib.md5(z.read(i)).hexdigest()
    assert got == want, f'{zpath}: content differs from staging'


def verify_7z(binp, src, top, vols):
    with tempfile.TemporaryDirectory(dir=os.path.join(REPO, '_work', 'release')) as t:
        bz_x(binp, t)
        assert tree_hashes(os.path.join(t, top)) == tree_hashes(src), f'{binp}: content differs from staging'
    h = hashlib.md5()
    for v in vols:
        h.update(open(v, 'rb').read())
    assert h.hexdigest() == md5(binp), f'{binp}: volumes do not join to the archive'


def retire_old_sb(v):
    for p in glob.glob(os.path.join(DESK, 'TldHacks-v*.zip')) + glob.glob(os.path.join(DESK, 'TldHacksv*.zip')) \
            + glob.glob(os.path.join(DESK, 'V*完整版_带其他mods例如地图')):
        m = re.search(r'[vV](\d+(?:\.\d+)+)', os.path.basename(p))
        if m and m.group(1) != v:
            dst = os.path.join(DESK, 'OLD', 'v' + m.group(1))
            os.makedirs(dst, exist_ok=True)
            shutil.move(p, dst)
            print('moved to OLD:', p)


def pack_sb(dll):
    v = sb_version()
    n = sb_names(v)
    retire_old_sb(v)
    os.makedirs(n['full_dir'], exist_ok=True)
    smin, sfull = os.path.join(STAGE, 'sb_min'), os.path.join(STAGE, 'sb_full')
    cn, en = os.path.join(DESK, n['min_cn']), os.path.join(DESK, n['min_en'])
    zip_dir(cn, smin)
    verify_zip(cn, smin)
    shutil.copy2(cn, en)
    shutil.copy2(dll, os.path.join(DESK, 'TldHacks.dll'))
    with zipfile.ZipFile(os.path.join(DESK, n['dll_zip']), 'w', zipfile.ZIP_DEFLATED) as z:
        z.write(dll, 'TldHacks.dll')

    named_parent = os.path.join(STAGE, '_named')
    named = os.path.join(named_parent, n['full'])
    os.makedirs(named_parent, exist_ok=True)
    os.rename(sfull, named)
    try:
        binp = os.path.join(DESK, '游戏材质包_backup.bin')
        bz_c(binp, named)
        fz = os.path.join(n['full_dir'], n['full'] + '.zip')
        zip_dir(fz, named, n['full'] + '/')
        verify_zip(fz, named, n['full'] + '/')
        vols = split(binp, n['full_dir'], '材质包备份')
        verify_7z(binp, named, n['full'], vols)
        unpacked = os.path.join(n['full_dir'], n['full'])
        if os.path.exists(unpacked):
            shutil.rmtree(unpacked)
        shutil.copytree(named, unpacked)
    finally:
        os.rename(named, sfull)
    print(f'sb v{v}: {n["min_cn"]}, {len(vols)} volumes in {n["full_dir"]}')


def pack_story(k):
    p = PKGS[k]
    src = os.path.join(STAGE, k, p['root'])
    binp = os.path.join(p['dir'], p['bin'])
    bz_c(binp, src)
    vols = split(binp, p['dir'], p['vol'])
    verify_7z(binp, src, p['root'], vols)
    print(f'{k}: {p["bin"]} + {len(vols)} volumes')


def pack(keys):
    if not os.path.exists(STAGE):
        sys.exit('run init first')
    if game_running():
        sys.exit('game is running: close it first (DLLs are locked)')
    man = load_manifest()
    built = {k: build(k) for k in (keys or PKGS)}
    run(['dotnet', 'build', os.path.join(REPO, SCP['csproj']), '-c', 'Release', '-nologo', '-v', 'q'])
    scp_dll = os.path.join(REPO, SCP['out'])
    if not keys:
        keys = [k for k, d in built.items() if md5(d) != man.get(k)]
        if 'sb' not in keys and md5(scp_dll) != man.get('scp'):
            keys.append('sb')
        if not keys:
            print('no DLL changed since last pack')
            return
    for k in keys:
        dll = built[k] if k in built else build(k)
        deploy(k, dll)
        if k == 'sb':
            deploy('sb', scp_dll, SCP)
            shutil.copy2(scp_dll, os.path.join(STAGE, SCP['stage']))
            man['scp'] = md5(scp_dll)
        for s in stage_dll(k):
            shutil.copy2(dll, s)
        pack_sb(dll) if k == 'sb' else pack_story(k)
        man[k] = md5(dll)
        save_manifest(man)
    print('packed + verified:', ' '.join(keys), '| DLL', {k: man[k][:8] for k in keys})


HERE = os.path.dirname(os.path.abspath(__file__))
NET_ROOT = '1811aa2992d54afb9febfd56dd12a301'
NET_OLD = '6636f71049c9406fbe95a8b5c410763d'
NET_STORY = 'c4a2c414862a42e08adf5b8fdef57596'
NET_SUB = {'e5': 'e5a5e3c68b584e298da17a8799830a94', 'st': '1cef7e23cdcd45a9b6a6b6f1c3a25a89'}


def bh(code, timeout=600):
    src = open(os.path.join(HERE, 'bh_quark.py'), encoding='utf-8').read()
    src += "\ngoto('https://pan.quark.cn/list#/list/all')\ntime.sleep(2)\n" + code
    r = subprocess.run(['browser-harness'], input=src, capture_output=True, text=True,
                       encoding='utf-8', errors='replace', timeout=timeout, creationflags=NO_WINDOW)
    for line in r.stdout.splitlines():
        if line.startswith('RESULT:'):
            return json.loads(line[7:])
    sys.exit(f'browser-harness failed:\n{r.stdout[-3000:]}\n{r.stderr[-3000:]}')


def upload_targets(keys):
    # [(folder key, [local files]), ...]; folder key is resolved to a fid inside the browser
    out = []
    for k in keys:
        if k == 'sb':
            n = sb_names(sb_version())
            out.append(('root', [os.path.join(DESK, n['min_cn'])]))
            out.append(('full:' + n['net_full'], sorted(glob.glob(os.path.join(n['full_dir'], '材质包备份.0*')))))
        else:
            p = PKGS[k]
            out.append((k, [os.path.join(p['dir'], p['bin']), os.path.join(p['dir'], p['readme'])]))
    return out


def upload(keys):
    keys = keys or [k for k in PKGS]
    targets = upload_targets(keys)
    stamp = time.strftime('%m%d-%H%M') + ' 替换下来的'
    plan = [(t, [os.path.basename(f) for f in fs]) for t, fs in targets]
    # 1. resolve folders, move same-name old files (and old full-version folders) into OLD\<stamp>
    prep = bh(f'''
plan = {json.dumps(plan, ensure_ascii=False)}
root = ls('{NET_ROOT}')
story = ls('{NET_STORY}')
names = {{'{NET_ROOT}': 'TLD V2.55 HACK'}}
for i in root + story: names[i['fid']] = i['name']
oldbox, moved, res = None, [], {{}}
def box():
    global oldbox
    if oldbox is None: oldbox = mkdir('{NET_OLD}', {json.dumps(stamp, ensure_ascii=False)})
    return oldbox
for key, files in plan:
    if key == 'root':
        chain = ['{NET_ROOT}']
        stale = [i for i in root if not i['dir'] and (i['name'] in files or '最小安装包' in i['name'])]
    elif key.startswith('full:'):
        want = key[5:]
        hit = [i for i in root if i['dir'] and i['name'] == want]
        fid = hit[0]['fid'] if hit else mkdir('{NET_ROOT}', want)
        names[fid] = want
        olddirs = [i for i in root if i['dir'] and '完整版' in i['name'] and i['name'] != want]
        mv([i['fid'] for i in olddirs], box()); moved += [i['name'] for i in olddirs]
        chain = ['{NET_ROOT}', fid]
        # 分卷数可能变少,同名的之外旧分卷也挪走,免得新旧分卷混在一起
        stale = [i for i in ls(fid) if not i['dir'] and (i['name'] in files or i['name'].startswith('材质包备份.'))]
    else:
        sub = {json.dumps(NET_SUB)}[key]
        chain = ['{NET_ROOT}', '{NET_STORY}', sub]
        stale = [i for i in ls(sub) if not i['dir'] and i['name'] in files]
    mv([i['fid'] for i in stale], box() if stale else None); moved += [i['name'] for i in stale]
    res[key] = dict(fid=chain[-1], url=url_for([(f, names[f]) for f in chain]))
close_tab()
done(dict(res=res, moved=moved))
''')
    print('moved to OLD:', prep['moved'])
    # 2. one browser-harness call per folder. The agent tab closes when its call ends, and that kills an
    #    unfinished upload, so each call holds its tab open until step 3 writes the flag file.
    flag = os.path.join(REPO, '_work', 'release', 'upload.done')
    if os.path.exists(flag):
        os.remove(flag)
    head = open(os.path.join(HERE, 'bh_quark.py'), encoding='utf-8').read()
    procs = []
    for key, files in targets:
        code = head + f"""
import os
goto({json.dumps(prep['res'][key]['url'], ensure_ascii=False)})
time.sleep(4)
upload('#ListHeader-file', {json.dumps(files, ensure_ascii=False)})
end = time.time() + 3600
while time.time() < end and not os.path.exists({json.dumps(flag)}):
    time.sleep(5)
close_tab()
"""
        pr = subprocess.Popen(['browser-harness'], stdin=subprocess.PIPE, stdout=subprocess.DEVNULL,
                              stderr=subprocess.DEVNULL, text=True, encoding='utf-8', creationflags=NO_WINDOW)
        pr.stdin.write(code)
        pr.stdin.close()
        procs.append(pr)
        print('uploading', len(files), 'files to', key)
        time.sleep(8)
    # 3. poll sizes in a separate tab; never eval_js in an uploading tab (it times out while hashing)
    want = {prep['res'][key]['fid']: {os.path.basename(f): os.path.getsize(f) for f in fs} for key, fs in targets}
    deadline = time.time() + 3600
    try:
        while True:
            time.sleep(30)
            if time.time() > deadline:
                sys.exit('upload timeout')
            # 核对超时别退出:finally 会写结束标记,把还在传的标签页关掉。多半是 Chrome 又在问允许远程调试
            try:
                got = bh(f"""
want = {json.dumps(want, ensure_ascii=False)}
miss = []
for fid, files in want.items():
    have = {{i['name']: i['size'] for i in ls(fid)}}
    miss += [n for n, s in files.items() if have.get(n) != s]
close_tab()
done(dict(miss=miss))
""", timeout=120)
            except subprocess.TimeoutExpired:
                print('size check timed out; if Chrome asks "Allow remote debugging", click Allow')
                continue
            if not got['miss']:
                print('upload done, sizes match:', sum(len(v) for v in want.values()), 'files')
                return
            print('waiting for:', got['miss'])
    finally:
        open(flag, 'w').close()
        for pr in procs:
            try:
                pr.wait(timeout=60)
            except subprocess.TimeoutExpired:
                pr.kill()
        os.remove(flag)


if __name__ == '__main__':
    cmd, args = (sys.argv[1] if len(sys.argv) > 1 else ''), sys.argv[2:]
    if cmd == 'init':
        init()
    elif cmd == 'pack':
        pack(args)
    elif cmd == 'upload':
        upload(args)
    else:
        print(__doc__ or open(__file__, encoding='utf-8').read().split('\nimport')[0])
