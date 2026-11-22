import json, sys, base64, struct, re, os
cat = sys.argv[1]; want = sys.argv[2]
d = json.load(open(cat, encoding='utf-8'))
ids = d['m_InternalIds']

def keys_of(b64):
    b = base64.b64decode(b64); n = struct.unpack_from('<i', b, 0)[0]
    return b

kb = base64.b64decode(d['m_KeyDataString'])
def key_at(off):
    t = kb[off]; o = off + 1
    if t in (0, 1):
        l = struct.unpack_from('<i', kb, o)[0]; o += 4
        return kb[o:o+l].decode('ascii' if t == 0 else 'utf-16-le', 'replace')
    return '<t%d>' % t

bb = base64.b64decode(d['m_BucketDataString'])
n = struct.unpack_from('<i', bb, 0)[0]; o = 4; buckets = []
for i in range(n):
    off, cnt = struct.unpack_from('<ii', bb, o); o += 8
    ents = struct.unpack_from('<%di' % cnt, bb, o); o += 4 * cnt
    buckets.append((off, ents))

eb = base64.b64decode(d['m_EntryDataString'])
ne = struct.unpack_from('<i', eb, 0)[0]
entries = [struct.unpack_from('<7i', eb, 4 + 28 * i) for i in range(ne)]

keyset = set(key_at(off) for off, _ in buckets)
for ei, e in enumerate(entries):
    iid = ids[e[0]]
    if not iid.endswith(want) and not (want.startswith("KEY:") and False): continue
    print('entry', ei, iid, 'depKey', e[2])
    if e[2] >= 0:
        for de in buckets[e[2]][1]:
            print('  dep bundle', ids[entries[de][0]])
    break

if len(sys.argv) > 3:
    for g in sys.argv[3:]:
        print(g, 'in catalog keys:', g in keyset)
