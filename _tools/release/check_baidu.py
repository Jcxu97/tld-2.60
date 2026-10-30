import os, sys, json
sys.path.insert(0, r'D:\Github\tld--2.55\_tools\release')
import release as R, baidu_upload as B
v = R.sb_version()
folders = {k: n for k, (_, n, _) in R.net_folders(v).items()}
want = {k: {os.path.basename(p): os.path.getsize(p) for p in fs} for k, fs in R.upload_targets(['sb', 'ul'])}
code = "goto('https://pan.baidu.com/disk/main')\ntime.sleep(3)\nout={}\n"
for k, n in folders.items():
    code += f"out[{k!r}]=ls(ROOT+'/'+{n!r})\n"
code += "out['root']=[i['name'] for i in ls(ROOT)]\ndone(out)\n"
got = B.bh(code, timeout=300)
print('root', got['root'])
for k, files in want.items():
    have = {i['name']: i['size'] for i in got[k]}
    bad = [n for n, s in files.items() if have.get(n) != s]
    extra = [n for n in have if n not in files]
    print(k, folders[k], 'want', len(files), 'have', len(have), 'bad', bad, 'extra', extra)
