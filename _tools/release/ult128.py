# V12.8 ultimate: TldHacks.dll (rebuilt and deployed by pack sb) and RarityRework.dll 1.2.0 changed.
import os, shutil, sys
sys.path.insert(0, r'D:\Github\tld--2.55\_tools\release')
import release as R

M = os.path.join(R.STAGE, 'ultimate', 'Mods')
GM = os.path.join(R.GAME, 'Mods')
for f in ('TldHacks.dll', 'RarityRework.dll'):
    shutil.copy2(os.path.join(GM, f), os.path.join(M, f))
print('synced')
