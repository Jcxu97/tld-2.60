import struct, sys, re

# 本地化表每条是 key(对齐字符串) + 数量 + 各语言值;直接在 resources.assets 原始字节里按 key 找
path = r"D:\Steam\steamapps\common\TheLongDark\tld_Data\resources.assets"
data = open(path, "rb").read()
ZH = 7


def rstr(off):
    n = struct.unpack_from("<i", data, off)[0]
    s = data[off + 4:off + 4 + n].decode("utf-8", "replace")
    off += 4 + n
    return s, off + (-off % 4)


pattern = re.compile(sys.argv[1].encode())
seen = set()
for m in pattern.finditer(data):
    key = m.group(0).decode()
    start = m.start() - 4
    if key in seen or start < 0 or struct.unpack_from("<i", data, start)[0] != len(key):
        continue
    if (start % 4) != 0:
        pass
    _, off = rstr(start)
    count = struct.unpack_from("<i", data, off)[0]
    if not 1 <= count <= 40:
        continue
    off += 4
    vals = []
    for _ in range(count):
        v, off = rstr(off)
        vals.append(v)
    seen.add(key)
    print(f"{key}\t{vals[0]}\t{vals[ZH] if len(vals) > ZH else ''}")
