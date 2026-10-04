# Prepended to every browser-harness script that release.py runs. Uses the user's logged-in Chrome.
import json, time

API = 'https://drive-pc.quark.cn/1/clouddrive/'


def q(path, body=None, wait=30):
    # eval_js does not wait for a Promise, so park the result on window and poll it
    sep = '&' if '?' in path else '?'
    url = API + path + sep + 'pr=ucpro&fr=pc'
    opts = ("{method:'POST',credentials:'include',headers:{'content-type':'application/json'},body:%s}"
            % json.dumps(json.dumps(body))) if body is not None else "{credentials:'include'}"
    eval_js("window.__r=null;fetch(%s,%s).then(r=>r.json()).then(j=>window.__r=JSON.stringify(j))"
            ".catch(e=>window.__r=JSON.stringify({err:String(e)}))" % (json.dumps(url), opts))
    for _ in range(wait * 4):
        r = eval_js('window.__r')
        if r:
            j = json.loads(r)
            if j.get('err') or j.get('status') not in (None, 200) or j.get('code') not in (None, 0):
                raise RuntimeError(f'{path}: {r[:300]}')
            return j
        time.sleep(0.25)
    raise RuntimeError(f'{path}: no answer')


def ls(fid):
    out, page = [], 1
    while True:
        j = q(f'file/sort?pdir_fid={fid}&_page={page}&_size=100&_fetch_total=1')
        items = j['data']['list']
        out += [dict(fid=i['fid'], name=i['file_name'], size=i.get('size', 0),
                     dir=bool(i.get('dir')) or i.get('file_type') == 0) for i in items]
        if len(items) < 100:
            return out
        page += 1


def mkdir(pfid, name):
    return q('file', dict(pdir_fid=pfid, file_name=name, dir_path='', dir_init_lock=False))['data']['fid']


def mv(fids, to):
    if fids:
        q('file/move', dict(action_type=1, to_pdir_fid=to, filelist=fids, exclude_fids=[]))


def url_for(chain):
    # chain: [(fid, name), ...] from the top HACK folder down
    return 'https://pan.quark.cn/list#/list/all/' + '/'.join(f'{f}-{n}' for f, n in chain)


def done(obj):
    print('RESULT:' + json.dumps(obj, ensure_ascii=False))
