# V12.9 ultimate pack
import os, shutil, sys
sys.path.insert(0, r'D:\Github\tld--2.55\_tools\release')
import release as R

v = '12.9'
S = os.path.join(R.STAGE, 'ultimate')
desk_old = os.path.join(R.DESK, 'V12.8终极版_我自己在用的全部mods')
out = R.ul_dir(v)
items = ['MelonLoader', 'Mods', 'Plugins', 'UserData', 'UserLibs', 'winhttp.dll', '使用说明.txt']

if os.path.exists(desk_old):
    dst = os.path.join(R.DESK, 'OLD', 'v12.8')
    os.makedirs(dst, exist_ok=True)
    shutil.move(desk_old, dst)
    print('moved to OLD:', desk_old)
os.makedirs(out, exist_ok=True)

binp = os.path.join(R.REPO, '_work', 'release', '终极版材质包.bin')
if os.path.exists(binp):
    os.remove(binp)
R.run([R.BZ, 'c', '-fmt:7z', '-l:9', f'-p:{R.PW}', binp] + items, cwd=S)
vols = R.split(binp, out, '终极版材质包备份')
shutil.copy2(os.path.join(S, '使用说明.txt'), os.path.join(out, '终极版_安装说明.txt'))

# extract and compare with staging; volumes must join back to the archive
import tempfile, hashlib
with tempfile.TemporaryDirectory(dir=os.path.join(R.REPO, '_work', 'release')) as t:
    R.bz_x(binp, t)
    want = {}
    for it in items:
        p = os.path.join(S, it)
        if os.path.isdir(p):
            want.update({it + '/' + k: h for k, h in R.tree_hashes(p).items()})
        else:
            want[it] = R.md5(p)
    got = R.tree_hashes(t)
    assert got == want, f'differs: {len(got)} vs {len(want)}'
h = hashlib.md5()
for p in vols:
    h.update(open(p, 'rb').read())
assert h.hexdigest() == R.md5(binp), 'volumes do not join'
os.remove(binp)
print(f'ultimate v{v}: {len(vols)} volumes, {len(want)} files verified, in {out}')
