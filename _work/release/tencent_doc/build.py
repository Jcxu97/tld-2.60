# Turns doc.txt (small line markup) into doc.html, doc_plain.txt and chunks.json for pasting into Tencent Docs.
# Markup: "## " h2, "### " h3, "+ " numbered item, "| a | b |" table row (first row of a run is the header),
# "! " bold paragraph, any other line is a paragraph. [text](url) is a link.
import html, json, os, re, sys

HERE = os.path.dirname(os.path.abspath(__file__))
P = 'font-size:11pt;line-height:1.7;margin:4px 0;'
H2 = 'font-size:17pt;font-weight:bold;margin:22px 0 8px 0;'
H3 = 'font-size:13pt;font-weight:bold;margin:14px 0 6px 0;'
TD = 'font-size:10.5pt;border:1px solid #bfbfbf;padding:5px 8px;vertical-align:top;'
TH = TD + 'background:#e8f0fb;font-weight:bold;'
LINK = re.compile(r'\[([^\]]+)\]\((https?://[^)\s]+)\)')


def inline(s):
    out, pos = [], 0
    for m in LINK.finditer(s):
        out.append(html.escape(s[pos:m.start()], quote=False))
        out.append('<a href="%s">%s</a>' % (html.escape(m.group(2)), html.escape(m.group(1), quote=False)))
        pos = m.end()
    out.append(html.escape(s[pos:], quote=False))
    return ''.join(out)


def plain(s):
    return LINK.sub(lambda m: m.group(1) if m.group(1) == m.group(2) else '%s %s' % (m.group(1), m.group(2)), s)


lines = open(os.path.join(HERE, 'doc.txt'), encoding='utf-8').read().splitlines()
hs, ps = [], []
i = 0
while i < len(lines):
    l = lines[i].rstrip()
    if not l:
        i += 1
        continue
    if l.startswith('## '):
        hs.append('<h2 style="%s">%s</h2>' % (H2, inline(l[3:])))
        ps.append(plain(l[3:]))
    elif l.startswith('### '):
        hs.append('<h3 style="%s">%s</h3>' % (H3, inline(l[4:])))
        ps.append(plain(l[4:]))
    elif l.startswith('! '):
        hs.append('<p style="%s"><b>%s</b></p>' % (P, inline(l[2:])))
        ps.append(plain(l[2:]))
    elif l.startswith('+ '):
        items = []
        while i < len(lines) and lines[i].startswith('+ '):
            items.append(lines[i][2:].rstrip())
            i += 1
        hs.append('<ol>' + ''.join('<li style="%s">%s</li>' % (P, inline(t)) for t in items) + '</ol>')
        ps.extend('%d. %s' % (n + 1, plain(t)) for n, t in enumerate(items))
        continue
    elif l.startswith('|'):
        rows = []
        while i < len(lines) and lines[i].startswith('|'):
            rows.append([c.strip() for c in lines[i].strip().strip('|').split(' | ')])
            i += 1
        width = max(len(r) for r in rows)
        bad = [r for r in rows if len(r) != width]
        if bad:
            sys.exit('table row with wrong cell count: %r' % bad[0])
        t = ['<table style="border-collapse:collapse;width:100%;">']
        for n, r in enumerate(rows):
            tag, st = ('th', TH) if n == 0 else ('td', TD)
            t.append('<tr>' + ''.join('<%s style="%s">%s</%s>' % (tag, st, inline(c), tag) for c in r) + '</tr>')
        t.append('</table>')
        hs.append(''.join(t))
        ps.extend('\t'.join(plain(c) for c in r) for r in rows)
        continue
    else:
        hs.append('<p style="%s">%s</p>' % (P, inline(l)))
        ps.append(plain(l))
    i += 1

doc = '<html><body>' + ''.join(hs) + '</body></html>'
open(os.path.join(HERE, 'doc.html'), 'w', encoding='utf-8').write(doc)
open(os.path.join(HERE, 'doc_plain.txt'), 'w', encoding='utf-8').write('\n'.join(ps))
chunks = [doc[k:k + 4000] for k in range(0, len(doc), 4000)]
json.dump(chunks, open(os.path.join(HERE, 'chunks.json'), 'w', encoding='utf-8'), ensure_ascii=False)
print('html', len(doc), 'chars,', len(chunks), 'chunks; plain', sum(len(x) for x in ps), 'chars,', len(ps), 'lines')
