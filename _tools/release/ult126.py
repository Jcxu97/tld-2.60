# V12.6 ultimate: TldHacks, MoreBunkers rebuilt by pack sb; BlueprintIconFix staged by pack sb; HutDoorTorch (ultimate only) and drifted jsons from the game.
import os, shutil, sys
sys.path.insert(0, r'D:\Github\tld--2.55\_tools\release')
import release as R

M = os.path.join(R.STAGE, 'ultimate', 'Mods')
GM = os.path.join(R.GAME, 'Mods')
for f in ('TldHacks.dll', 'MoreBunkers.dll', 'HutDoorTorch.dll', 'HutDoorTorch.json', 'PerfectPlacement.json', 'TldHacks_Transitions.txt'):
    shutil.copy2(os.path.join(GM, f), os.path.join(M, f))
print('synced')
