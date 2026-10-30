# Prepended to browser-harness scripts for the Baidu netdisk web API. Uses the user's logged-in Chrome.
import json, time

ROOT = '/TLD HACK V2.59'
OLD = ROOT + '/OLD文件，不用管，V2.55老版本的东西在里面'


def _fetch(js_promise, wait=60):
    eval_js("window.__b=null;(%s).then(r=>r.json()).then(j=>window.__b=JSON.stringify(j)).catch(e=>window.__b=JSON.stringify({err:String(e)}))" % js_promise)
    for _ in range(wait * 4):
        v = eval_js('window.__b')
        if v:
            j = json.loads(v)
            if j.get('err') or j.get('errno') not in (None, 0):
                raise RuntimeError(v[:300])
            return j
        time.sleep(0.25)
    raise RuntimeError('no answer')


def token():
    j = _fetch("fetch('/api/gettemplatevariable?clienttype=0&app_id=250528&web=1&fields=%5B%22bdstoken%22%5D',{credentials:'include'})")
    return j['result']['bdstoken']


def ls(d):
    j = _fetch("fetch('/api/list?dir='+encodeURIComponent(%s)+'&num=1000&order=name&web=1',{credentials:'include'})" % json.dumps(d))
    return [dict(name=f['server_filename'], size=f.get('size', 0), dir=bool(f['isdir']), path=f['path']) for f in j.get('list', [])]


def _post(url, form):
    return _fetch("fetch(%s,{method:'POST',credentials:'include',body:new URLSearchParams(%s)})"
                  % (json.dumps(url), json.dumps(form, ensure_ascii=False)))


def mkdir(bd, path):
    return _post('/api/create?a=commit&bdstoken=' + bd, dict(path=path, isdir='1', block_list='[]'))


def mv(bd, paths, dest):
    if paths:
        fl = json.dumps([dict(path=p, dest=dest, newname=p.rsplit('/', 1)[1]) for p in paths], ensure_ascii=False)
        _post('/api/filemanager?opera=move&async=0&onnest=fail&bdstoken=' + bd, dict(filelist=fl))


def rename(bd, path, newname):
    fl = json.dumps([dict(path=path, newname=newname)], ensure_ascii=False)
    _post('/api/filemanager?opera=rename&async=0&onnest=fail&bdstoken=' + bd, dict(filelist=fl))


def done(obj):
    print('RESULT:' + json.dumps(obj, ensure_ascii=False))
