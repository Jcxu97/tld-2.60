import os, glob
# The diff files live in the work folder that run.ps1 writes to, not next to this script.
HERE = os.path.join(os.environ['TEMP'], 'tlddiff')
os.chdir(HERE)


def rd(p, strip=True):
    t = open(p, encoding="utf-8-sig", errors="replace", newline="").read()
    ls = t.split("\n")
    return [l.rstrip("\r") if strip else l for l in ls if l.strip()]


for old in sorted(glob.glob("*.old.txt")):
    base = old[:-len(".old.txt")]
    new = base + ".new.txt"
    if not os.path.exists(new):
        continue
    o, n = set(rd(old)), set(rd(new))
    o = {l for l in o if "Cpp2ILInjected." not in l}
    n = {l for l in n if "Cpp2ILInjected." not in l}
    add, rem = n - o, o - n
    res = []
    for suf, calc in ((".added", add), (".removed", rem)):
        p = base + suf
        if not os.path.exists(p):
            res.append("%s missing" % suf)
            continue
        have = set(rd(p))
        if have != calc:
            res.append("%s differs: file %d vs recomputed %d (only in file %d, only recomputed %d)" % (
                suf, len(have), len(calc), len(have - calc), len(calc - have)))
    print(base, "OK" if not res else "; ".join(res))
