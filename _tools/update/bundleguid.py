import sys, struct, re
import UnityPy
path = sys.argv[1]; want = sys.argv[2]
env = UnityPy.load(path)
for obj in env.objects:
    if obj.type.name != 'MonoBehaviour': continue
    raw = obj.get_raw_data()
    # MonoBehaviour 头: m_GameObject(12) m_Enabled(4,对齐) m_Script(12) m_Name(字符串)
    o = 28
    l = struct.unpack_from('<i', raw, o)[0]
    if l < 0 or l > 200: continue
    name = raw[o+4:o+4+l].decode('utf-8', 'replace')
    if want not in name: continue
    o += 4 + l; o = (o + 3) & ~3
    strs = []
    for _ in range(3):
        l = struct.unpack_from('<i', raw, o)[0]
        if l < 0 or l > 200: break
        strs.append(raw[o+4:o+4+l].decode('utf-8', 'replace')); o += 4 + l; o = (o + 3) & ~3
    print(name, strs)
