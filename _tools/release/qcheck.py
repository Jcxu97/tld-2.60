# List the three Quark package folders and report duplicate uploads (names with a (1) suffix) and file counts.
import sys
sys.path.insert(0, r'D:\Github\tld--2.55\_tools\release')
import release as R

v = sys.argv[1] if len(sys.argv) > 1 else R.sb_version()
fids = {k: f for k, (f, _, _) in R.net_folders(v).items()}
code = 'out = {}\n'
for k, f in fids.items():
    code += f"out[{k!r}] = [i['name'] for i in ls({f!r})]\n"
code += 'done(out)\n'
res = R.bh(code)
for k, names in res.items():
    dup = [n for n in names if '(1)' in n or '(2)' in n]
    print(k, len(names), 'dup:', dup[:10], 'sample:', sorted(names)[:2], sorted(names)[-2:])
