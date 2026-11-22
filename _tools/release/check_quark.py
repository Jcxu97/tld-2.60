import os, sys, json
sys.path.insert(0, r'D:\Github\tld--2.55\_tools\release')
import release as R
v = R.sb_version()
nf = R.net_folders(v)
want = {}
for key, files in R.upload_targets(['sb', 'ul']):
    want[key] = {os.path.basename(p): os.path.getsize(p) for p in files}
code = 'out={}\n'
for key, (fid, name, _) in nf.items():
    code += f"out[{key!r}]=[{{'n':i['name'],'s':i['size']}} for i in ls({fid!r})]\n"
code += "done(out)\n"
got = R.bh(code, timeout=300)
print('version', v)
for key, files in want.items():
    have = {i['n']: i['s'] for i in got[key]}
    miss = [n for n, s in files.items() if have.get(n) != s]
    extra = [n for n in have if n not in files]
    print(key, nf[key][1], 'want', len(files), 'have', len(have), 'bad', miss, 'extra', extra)
