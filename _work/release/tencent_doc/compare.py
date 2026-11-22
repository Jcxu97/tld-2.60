# Compares the text copied back from Tencent Docs with doc_plain.txt, ignoring blank lines and spacing.
import difflib, os, re

D = os.path.dirname(os.path.abspath(__file__))


def norm(path):
    out = []
    for l in open(os.path.join(D, path), encoding='utf-8').read().splitlines():
        l = re.sub(r'\s+', '', l)
        l = re.sub(r'^\d+\.', '', l)
        if l:
            out.append(l)
    return out


a, b = norm('doc_plain.txt'), norm('readback.txt')
print('source lines', len(a), 'readback lines', len(b))
print('joined equal:', ''.join(a) == ''.join(b))
diff = list(difflib.unified_diff(a, b, 'source', 'readback', n=0, lineterm=''))
print(len(diff), 'diff lines')
for l in diff[:60]:
    print(l[:160])
