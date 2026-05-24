"""Stream-rebuild v6.8 ZIPs into v6.8.1 by swapping Mods/TldHacks.dll only."""
import os, sys, zipfile, shutil

DESKTOP = r"C:\Users\82077\Desktop\TLD"
NEW_DLL = r"D:\Github\tld--2.55\TldHacks\src\bin\Release\TldHacks.dll"

PAIRS = [
    ("TldHacks-v6.8-完整版_解压到游戏根目录即可！按键在设置-Modseting里改！.zip",
     "TldHacks-v6.8.1-完整版_解压到游戏根目录即可！按键在设置-Modseting里改！.zip"),
    ("TldHacks-v6.8-最小安装包_只带修改mod！解压到游戏根目录.zip",
     "TldHacks-v6.8.1-最小安装包_只带修改mod！解压到游戏根目录.zip"),
]

TARGET_NAMES = ("Mods/TldHacks.dll", "Mods\\TldHacks.dll")

def rebuild(src_path, dst_path, new_dll):
    with open(new_dll, "rb") as f:
        new_dll_bytes = f.read()
    replaced = False
    with zipfile.ZipFile(src_path, "r") as zin, \
         zipfile.ZipFile(dst_path, "w", zipfile.ZIP_DEFLATED, compresslevel=6) as zout:
        for item in zin.infolist():
            name = item.filename
            norm = name.replace("\\", "/")
            if norm == "Mods/TldHacks.dll":
                zi = zipfile.ZipInfo(filename=name, date_time=item.date_time)
                zi.compress_type = zipfile.ZIP_DEFLATED
                zi.external_attr = item.external_attr
                zout.writestr(zi, new_dll_bytes)
                replaced = True
                print(f"  [REPLACE] {name}  ({len(new_dll_bytes)} bytes)")
            else:
                with zin.open(item, "r") as src:
                    zout.writestr(item, src.read())
    return replaced

def main():
    if not os.path.isfile(NEW_DLL):
        print(f"ERROR: new dll missing: {NEW_DLL}")
        sys.exit(1)
    for old_name, new_name in PAIRS:
        src = os.path.join(DESKTOP, old_name)
        dst = os.path.join(DESKTOP, new_name)
        if not os.path.isfile(src):
            print(f"ERROR: missing source ZIP: {src}")
            sys.exit(2)
        print(f"==> {old_name} -> {new_name}")
        ok = rebuild(src, dst, NEW_DLL)
        if not ok:
            print(f"  WARNING: Mods/TldHacks.dll not found inside {old_name}")
        # delete old
        os.remove(src)
        sz = os.path.getsize(dst)
        print(f"  done: {dst}  ({sz:,} bytes); old removed.")
    print("ALL OK")

if __name__ == "__main__":
    main()
