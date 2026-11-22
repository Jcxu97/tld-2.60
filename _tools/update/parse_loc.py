import struct, re, json
import UnityPy

D = r"C:\Users\82077\AppData\Local\Temp\tlddiff"
ZH = 7


def parse(raw, out):
    def rd_str(pos):
        n = struct.unpack_from("<i", raw, pos)[0]
        if n < 0 or n > 200000:
            raise ValueError
        s = raw[pos + 4:pos + 4 + n].decode("utf-8")
        return s, (pos + 4 + n + 3) & ~3

    for m in re.finditer(rb"([A-Za-z][A-Za-z0-9_\-\.]{2,120})\x00", raw):
        k = m.group(1)
        s = m.start() - 4
        if s < 0 or struct.unpack_from("<i", raw, s)[0] != len(k):
            continue
        try:
            pos = (m.start() + len(k) + 3) & ~3
            cnt = struct.unpack_from("<i", raw, pos)[0]
            if cnt != 21:
                continue
            pos += 4
            vals = []
            for _ in range(cnt):
                v, pos = rd_str(pos)
                vals.append(v)
            out[k.decode()] = {"en": vals[0], "zh": vals[ZH]}
        except Exception:
            continue


env = UnityPy.load(r"D:\Steam\steamapps\common\TheLongDark\tld_Data\resources.assets")
out = {}
mbs = 0
for obj in env.objects:
    if obj.type.name != "MonoBehaviour":
        continue
    raw = obj.get_raw_data()
    if b"GAMEPLAY_" not in raw:
        continue
    mbs += 1
    parse(raw, out)
json.dump(out, open(D + r"\loc_all.json", "w", encoding="utf-8"), ensure_ascii=False, indent=0)
print("mbs", mbs, "keys", len(out))
for k in ("GAMEPLAY_WhaleOilHeater", "GAMEPLAY_WhaleOilCan", "GAMEPLAY_TrainBrakePad", "GAMEPLAY_Hatchet", "GAMEPLAY_DeerSkinCoat", "GAMEPLAY_InsulatedFlask", "GAMEPLAY_WaxCylinder", "GAMEPLAY_RifleHuntingLodge"):
    print(k, out.get(k))
