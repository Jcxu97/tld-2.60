# V13.0 Quark check: per folder, list missing / wrong-size / extra files against the local upload targets.
import json, os, sys
sys.path.insert(0, os.path.dirname(os.path.abspath(__file__)))
import release as R

keys = sys.argv[1:] or ['sb', 'e5', 'st', 'ul']
targets = R.upload_targets(keys)
fids = {k: v[0] for k, v in R.net_folders(R.sb_version()).items()}
fids.update(R.NET_SUB)
want = {fids[k]: {os.path.basename(f): os.path.getsize(f) for f in fs} for k, fs in targets}
got = R.bh(f"""
want = {json.dumps(want, ensure_ascii=False)}
out = {{}}
for fid, files in want.items():
    have = {{}}
    for i in ls(fid):
        if not i['dir']:
            have.setdefault(i['name'], []).append(i['size'])
    miss = [n for n, s in files.items() if s not in have.get(n, [])]
    extra = [n for n in have if n not in files] + [n for n, v in have.items() if len(v) > 1]
    out[fid] = dict(miss=miss, extra=extra, n=len(have))
close_tab()
done(out)
""", timeout=300)
for k, fs in targets:
    r = got[fids[k]]
    print(k, 'files', r['n'], 'missing', len(r['miss']), r['miss'][:8], 'extra', r['extra'][:8])
