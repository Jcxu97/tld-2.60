# V12.5 ultimate: TldHacks and MoreBunkers rebuilt by pack sb; Architect, PerfectPlacement,
# MotionTrackerLite, SCPlusFix++ and the two Episode 5 ports were already swapped in by hand.
import os, shutil, sys
sys.path.insert(0, r'D:\Github\tld--2.55\_tools\release')
import release as R

M = os.path.join(R.STAGE, 'ultimate', 'Mods')
GM = os.path.join(R.GAME, 'Mods')
for f in ('TldHacks.dll', 'MoreBunkers.dll'):
    shutil.copy2(os.path.join(GM, f), os.path.join(M, f))
print('synced')
