# Copies the whole Tencent doc body back to the clipboard and saves it, then lists the outline entries.
import json, re, subprocess, time

D = r'D:\Github\tld--2.55\_work\release\tencent_doc'
goto('https://docs.qq.com/doc/DVFFIbWxpcUttcGh2')
time.sleep(7)
t = eval_js("document.body.innerText") or ''
print(re.findall(r'上次修改[^\n]{0,30}', t), re.findall(r'\d+\s*个字', t))
click_at(960, 300)
time.sleep(0.5)
hotkey("Control+Home")
time.sleep(0.4)
hotkey("Control+A")
time.sleep(0.6)
hotkey("Control+C")
time.sleep(2.5)
r = subprocess.run(['pwsh', '-NoProfile', '-sta', '-Command', '[Console]::OutputEncoding=[Text.Encoding]::UTF8; Get-Clipboard -Raw'], capture_output=True, text=True, encoding='utf-8')
open(D + r'\readback.txt', 'w', encoding='utf-8').write(r.stdout or '')
print('readback chars', len(r.stdout or ''))
click_at(960, 300)
time.sleep(0.3)
click_at(17, 464)
time.sleep(2)
print(eval_js("""JSON.stringify([...document.querySelectorAll('*')].filter(e=>e.children.length===0 && /^(目录|[一二三四五六七八九十]+、)/.test((e.textContent||'').trim())).map(e=>{const r=e.getBoundingClientRect();return [e.textContent.trim().slice(0,14), Math.round(r.x), Math.round(r.y)]}).filter(a=>a[1]<500).slice(0,30))"""))
