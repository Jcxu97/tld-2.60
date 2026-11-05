# V12.2 ultimate: only TldHacks, MoreBunkers and SCPlusFix++ changed since V12.1 (checked against the game Mods).
# Swap those in staging\ultimate, then pack like ult105.py.
import os, shutil, sys
sys.path.insert(0, r'D:\Github\tld--2.55\_tools\release')
import release as R

M = os.path.join(R.STAGE, 'ultimate', 'Mods')
GM = os.path.join(R.GAME, 'Mods')
for f in ('TldHacks.dll', 'MoreBunkers.dll', 'SCPlusFix++.dll'):
    shutil.copy2(os.path.join(GM, f), os.path.join(M, f))
old = os.path.join(M, 'SafehouseCustomizationPlus.dll')
if os.path.exists(old):
    os.remove(old)
oj = os.path.join(M, 'SafehouseCustomizationPlus.json')
if os.path.exists(oj):
    os.replace(oj, os.path.join(M, 'SCPlusFix++.json'))
print(sorted(f for f in os.listdir(M) if 'SCPlus' in f or 'Safehouse' in f))
