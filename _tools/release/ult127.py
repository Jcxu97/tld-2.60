# V12.7 ultimate: only TldHacks.dll changed (rebuilt and deployed by pack sb).
import os, shutil, sys
sys.path.insert(0, r'D:\Github\tld--2.55\_tools\release')
import release as R

M = os.path.join(R.STAGE, 'ultimate', 'Mods')
GM = os.path.join(R.GAME, 'Mods')
for f in ('TldHacks.dll',):
    shutil.copy2(os.path.join(GM, f), os.path.join(M, f))
print('synced')
