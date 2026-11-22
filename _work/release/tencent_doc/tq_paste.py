# Pastes doc.html into the Tencent doc through a one-time copy listener, then waits for the word count to settle.
import json, os, re, subprocess, time

D = r'D:\Github\tld--2.55\_work\release\tencent_doc'
chunks = json.load(open(D + r'\chunks.json', encoding='utf-8'))
plain = open(D + r'\doc_plain.txt', encoding='utf-8').read()


def words():
    t = eval_js("document.body.innerText") or ''
    m = re.findall(r'(\d+)\s*个字', t)
    return (int(m[0]) if m else -1), re.findall(r'上次修改[^\n]{0,30}', t)


def clip():
    r = subprocess.run(['pwsh', '-NoProfile', '-sta', '-Command', 'Get-Clipboard -Raw'], capture_output=True, text=True, encoding='utf-8')
    return r.stdout or ''


goto('https://docs.qq.com/doc/DVFFIbWxpcUttcGh2')
time.sleep(6)
n, last = words()
print('before', n, last)
# An update overwrites the whole body. Set FORCE=1 only after tq_verify + compare show no hand edits online.
if n != 0 and os.environ.get('FORCE') != '1':
    raise SystemExit('ABORT: the doc body is not empty')

eval_js("window.__h=[];window.__t='';'ok'")
for c in chunks:
    eval_js("window.__h.push(%s);'ok'" % json.dumps(c, ensure_ascii=False))
for k in range(0, len(plain), 4000):
    eval_js("window.__t+=%s;'ok'" % json.dumps(plain[k:k + 4000], ensure_ascii=False))
print('injected', eval_js("window.__h.join('').length"), eval_js("window.__t.length"))
eval_js("""document.addEventListener('copy', function h(e){e.clipboardData.setData('text/html', window.__h.join(''));e.clipboardData.setData('text/plain', window.__t);e.preventDefault();e.stopImmediatePropagation();document.removeEventListener('copy', h, true);window.__copied=1;}, true);'ok'""")

click_at(960, 300)
time.sleep(0.5)
hotkey("Control+C")
time.sleep(1.5)
got = clip()
print('copied flag', eval_js("window.__copied||0"), 'clipboard starts', repr(got[:40]), 'len', len(got))
if not got.startswith(plain[:20]):
    raise SystemExit('ABORT: clipboard does not hold the new text')

click_at(960, 300)
time.sleep(0.5)
hotkey("Control+Home")
time.sleep(0.4)
hotkey("Control+A")
time.sleep(0.4)
hotkey("Control+V")
prev, stable = -2, 0
for i in range(40):
    time.sleep(2)
    n, last = words()
    stable = stable + 1 if n == prev and n > 0 else 0
    prev = n
    if stable >= 3:
        break
print('after', n, last, 'waited', (i + 1) * 2, 's')
