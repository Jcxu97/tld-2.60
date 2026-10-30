# Upload the current sandbox and ultimate packages to Baidu netdisk TLD HACK V2.59 through the logged-in web page.
#   Run bd prep first (bh_baidu.py: retire old files, rename folders). This script only uploads and checks sizes.
import json, os, subprocess, sys, time, urllib.parse

sys.path.insert(0, os.path.dirname(os.path.abspath(__file__)))
import release as R

HERE = os.path.dirname(os.path.abspath(__file__))
HEAD = open(os.path.join(HERE, 'bh_baidu.py'), encoding='utf-8').read()
FLAG = os.path.join(R.REPO, '_work', 'release', 'bd_upload.done')


def bh(code, timeout=180):
    r = subprocess.run(['browser-harness'], input=HEAD + code, capture_output=True, text=True,
                       encoding='utf-8', errors='replace', timeout=timeout, creationflags=R.NO_WINDOW)
    for line in r.stdout.splitlines():
        if line.startswith('RESULT:'):
            return json.loads(line[7:])
    raise RuntimeError(r.stdout[-2000:] + r.stderr[-2000:])


def main():
    v = R.sb_version()
    folders = {k: n for k, (_, n, _) in R.net_folders(v).items()}
    targets = R.upload_targets(['sb', 'ul'])
    if os.path.exists(FLAG):
        os.remove(FLAG)
    procs = []
    for key, files in targets:
        path = '/TLD HACK V2.59/' + folders[key]
        code = f"""
import os
goto('https://pan.baidu.com/disk/main#/index?category=all&path=' + {json.dumps(urllib.parse.quote(path))})
time.sleep(7)
upload('input[name=html5uploader]', {json.dumps(files, ensure_ascii=False)})
end = time.time() + 5400
while time.time() < end and not os.path.exists({json.dumps(FLAG)}):
    time.sleep(5)
close_tab()
"""
        p = subprocess.Popen(['browser-harness'], stdin=subprocess.PIPE, stdout=subprocess.DEVNULL, stderr=subprocess.DEVNULL,
                             text=True, encoding='utf-8', creationflags=R.NO_WINDOW)
        p.stdin.write(HEAD + code)
        p.stdin.close()
        procs.append(p)
        print('uploading', len(files), 'files to', key, flush=True)
        time.sleep(10)
    want = {'/TLD HACK V2.59/' + folders[k]: {os.path.basename(f): os.path.getsize(f) for f in fs} for k, fs in targets}
    deadline = time.time() + 5400
    try:
        while time.time() < deadline:
            time.sleep(30)
            try:
                got = bh(f"""
want = {json.dumps(want, ensure_ascii=False)}
goto('https://pan.baidu.com/disk/main')
time.sleep(4)
miss = []
for d, files in want.items():
    have = {{i['name']: i['size'] for i in ls(d)}}
    miss += [n for n, s in files.items() if have.get(n) != s]
close_tab()
done(dict(miss=miss))
""")
            except Exception as e:
                print('size check failed:', str(e)[:200], flush=True)
                continue
            if not got['miss']:
                print('upload done, sizes match:', sum(len(x) for x in want.values()), 'files', flush=True)
                return
            print('waiting for', len(got['miss']), 'files:', got['miss'][:5], flush=True)
        sys.exit('upload timeout')
    finally:
        open(FLAG, 'w').close()
        for p in procs:
            try:
                p.wait(timeout=60)
            except subprocess.TimeoutExpired:
                p.kill()
        os.remove(FLAG)


if __name__ == '__main__':
    main()
