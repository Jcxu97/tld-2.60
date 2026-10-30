import json, os, subprocess, sys, time

HERE = r'D:\Github\tld--2.55\_tools\release'
SUB = '0a583d04bfed47cd9c7ce2235c20e7d5'
OLD = '6636f71049c9406fbe95a8b5c410763d'
OLD_NAME = '安装教程，进群必看.docx'
FLAG = r'C:\Users\82077\AppData\Local\Temp\si_tools\upload_docx.done'
NO_WINDOW = 0x08000000
head = open(os.path.join(HERE, 'bh_quark.py'), encoding='utf-8').read()
f = sys.argv[1]
name = os.path.basename(f)


def bh(code, timeout=120):
    src = head + "\ngoto('https://pan.quark.cn/list#/list/all')\ntime.sleep(2)\n" + code
    r = subprocess.run(['browser-harness'], input=src, capture_output=True, text=True,
                       encoding='utf-8', errors='replace', timeout=timeout, creationflags=NO_WINDOW)
    for line in r.stdout.splitlines():
        if line.startswith('RESULT:'):
            return json.loads(line[7:])
    raise RuntimeError(r.stdout[-2000:] + r.stderr[-2000:])


stamp = time.strftime('%m%d-%H%M') + ' 替换下来的'
prep = bh(f"""
items = ls({json.dumps(SUB)})
stale = [i for i in items if not i['dir'] and i['name'] == {json.dumps(OLD_NAME, ensure_ascii=False)}]
if stale:
    box = mkdir({json.dumps(OLD)}, {json.dumps(stamp, ensure_ascii=False)})
    mv([i['fid'] for i in stale], box)
url = url_for([('0a583d04bfed47cd9c7ce2235c20e7d5', 'TLD V2.58 Hack')])
close_tab()
done(dict(moved=[i['name'] for i in stale], url=url, names=[i['name'] for i in items]))
""")
print('moved to OLD:', prep['moved'], flush=True)
if os.path.exists(FLAG):
    os.remove(FLAG)
code = head + f"""
import os
goto({json.dumps(prep['url'], ensure_ascii=False)})
time.sleep(4)
upload('#ListHeader-file', {json.dumps([f], ensure_ascii=False)})
end = time.time() + 1800
while time.time() < end and not os.path.exists({json.dumps(FLAG)}):
    time.sleep(5)
close_tab()
"""
pr = subprocess.Popen(['browser-harness'], stdin=subprocess.PIPE, stdout=subprocess.DEVNULL,
                      stderr=subprocess.DEVNULL, text=True, encoding='utf-8', creationflags=NO_WINDOW)
pr.stdin.write(code)
pr.stdin.close()
want = os.path.getsize(f)
try:
    for _ in range(60):
        time.sleep(20)
        try:
            have = bh(f"have = {{i['name']: i['size'] for i in ls({json.dumps(SUB)})}}\nclose_tab()\ndone(have)")
        except Exception as e:
            print('size check failed:', str(e)[-300:], flush=True)
            continue
        if have.get(name) == want:
            print('upload done, size matches', want, sorted(have), flush=True)
            break
        print('waiting', flush=True)
    else:
        print('upload timeout', flush=True)
finally:
    open(FLAG, 'w').close()
    time.sleep(10)
