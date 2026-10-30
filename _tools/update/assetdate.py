# For every catalog asset whose path matches a word, print the date of the bundle that holds it.
import json, sys, os, time, base64, struct
cat, word = sys.argv[1], sys.argv[2].lower()
root = os.path.dirname(cat)
d = json.load(open(cat, encoding='utf-8'))
ids = d['m_InternalIds']
eb = base64.b64decode(d['m_EntryDataString'])
ne = struct.unpack_from('<i', eb, 0)[0]
entries = [struct.unpack_from('<7i', eb, 4 + 28 * i) for i in range(ne)]
bb = base64.b64decode(d['m_BucketDataString'])
n = struct.unpack_from('<i', bb, 0)[0]; o = 4; buckets = []
for i in range(n):
    off, cnt = struct.unpack_from('<ii', bb, o); o += 8
    buckets.append(struct.unpack_from('<%di' % cnt, bb, o)); o += 4 * cnt
seen = set()
for e in entries:
    iid = ids[e[0]]
    if word not in iid.lower() or iid in seen or e[2] < 0 or not buckets[e[2]]:
        continue
    seen.add(iid)
    b = ids[entries[buckets[e[2]][0]][0]].replace(chr(92), '/').split('/')[-1]
    p = os.path.join(root, b)
    t = time.strftime('%Y-%m-%d', time.localtime(os.path.getmtime(p))) if os.path.exists(p) else 'missing'
    print(t, b[:10], iid.split('/')[-1])
