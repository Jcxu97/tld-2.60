import hashlib, os, shutil, sys, zipfile

src, out, old, oldbox = sys.argv[1:5]
shutil.copy2(r"D:\Github\tld--2.55\MoreBunkers\src\bin\Release\MoreBunkers.dll", os.path.join(src, "Mods", "MoreBunkers.dll"))
files = ["Mods/MoreBunkers.dll", "Mods/ModSettings.dll", "Mods/ModData.dll", "MoreBunkers使用说明.txt"]
with zipfile.ZipFile(out, "w", zipfile.ZIP_DEFLATED, compresslevel=9) as z:
    for f in files:
        z.write(os.path.join(src, f), f)
with zipfile.ZipFile(out) as z:
    assert z.testzip() is None
    for f in files:
        assert hashlib.md5(z.read(f)).hexdigest() == hashlib.md5(open(os.path.join(src, f), "rb").read()).hexdigest(), f
os.makedirs(oldbox, exist_ok=True)
shutil.move(old, oldbox)
print("ok", os.path.getsize(out))
