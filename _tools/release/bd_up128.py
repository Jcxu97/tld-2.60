# V12.8 Baidu upload with a paged ls. Run: python bd_up128.py sb, then python bd_up128.py ul (two at a time is the limit)
# ponytail: same paged ls as bd_prep128.py; baidu_upload's size check lists the 183-file ultimate folder
import sys
sys.path.insert(0, r'D:\Github\tld--2.55\_tools\release')
import release as R, baidu_upload as B

B.HEAD += '''

def ls(d):
    out, page = [], 1
    while True:
        eval_js("window.__n=null;fetch('/api/list?dir='+encodeURIComponent(%s)+'&num=100&page=%d&order=name&web=1',{credentials:'include'}).then(r=>r.json()).then(j=>window.__n=JSON.stringify((j.list||[]).map(f=>[f.server_filename,f.size])))" % (json.dumps(d), page))
        v = None
        for _ in range(240):
            v = eval_js('window.__n')
            if v:
                break
            time.sleep(0.25)
        part = json.loads(v)
        out += [dict(name=n, size=s) for n, s in part]
        if len(part) < 100:
            return out
        page += 1
'''
o = R.upload_targets
R.upload_targets = lambda keys: o(sys.argv[1:])
B.main()
