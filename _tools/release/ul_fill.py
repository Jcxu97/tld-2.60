# Upload only the ultimate files that are missing on Quark. Run: python ul_fill.py
# Prefixes are cleared, so upload() does not move the volumes that are already there into OLD.
import os, sys
sys.path.insert(0, r'D:\Github\tld--2.55\_tools\release')
import release as R

v = R.sb_version()
fid, want, _ = R.net_folders(v)['ul']
have = {i['name'] for i in R.bh(f"done(ls({fid!r}))")}
local = R.upload_targets(['ul'])[0][1]
missing = [p for p in local if os.path.basename(p) not in have]
print('missing:', [os.path.basename(p) for p in missing])
if not missing:
    sys.exit(0)
orig = R.net_folders
R.net_folders = lambda ver: {k: (f, w, []) for k, (f, w, _) in orig(ver).items()}
R.upload_targets = lambda keys: [('ul', missing)]
R.upload(['ul'])
