import sys, json
sys.path.insert(0, r'D:\Github\tld--2.55\_tools\release')
import release as R
fid = R.net_folders(R.sb_version())['ul'][0]
move = len(sys.argv) > 1
code = f"""
items = ls({fid!r})
by = {{i['name']: i for i in items}}
dups = [i for i in items if '(1)' in i['name']]
rows = [dict(n=i['name'], s=i['size'], orig=by.get(i['name'].replace('(1)', ''), {{}}).get('size'), fid=i['fid']) for i in dups]
moved = None
if {move!r}:
    old = '6636f71049c9406fbe95a8b5c410763d'
    sub = [i for i in ls(old) if i['name'] == '1031-终极版重复上传的' and i['dir']]
    to = sub[0]['fid'] if sub else mkdir(old, '1031-终极版重复上传的')
    mv([r['fid'] for r in rows], to)
    time.sleep(5)
    moved = len(ls(to))
done(dict(rows=rows, moved=moved))
"""
r = R.bh(code, timeout=300)
for x in r['rows']:
    print(x['n'], x['s'], x['orig'], 'SAME' if x['s'] == x['orig'] else 'DIFF')
print('moved', r['moved'])
