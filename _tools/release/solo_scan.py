import json, os, sys
import dnfile

ST = r'D:\Github\tld--2.55\_work\release\staging'
SRCS = [os.path.join(ST, 'sb_full'), os.path.join(ST, 'ultimate')]

# own files per mod, relative to the game root
MODS = {
    'Architect': ['Mods/Architect.dll', 'Mods/Architect.json', 'Mods/Architect.modcomponent'],
    'Bountiful_Foraging': ['Mods/Bountiful_Foraging.dll', 'Mods/Bountiful_Foraging.json', 'Mods/Bountiful_Foraging.modcomponent'],
    'CampingTools': ['Mods/CampingTools.dll', 'Mods/CampingTools.json', 'Mods/CampingTools.modcomponent'],
    'ClothingExpanded': ['Mods/ClothingExpanded.dll', 'Mods/ClothingExpanded.modcomponent'],
    'ClothingTweaker2': ['Mods/ClothingTweaker2.dll', 'Mods/ClothingTweaker2.json'],
    'ComplexLogger': ['Mods/ComplexLogger.dll', 'Mods/ComplexLogger.json'],
    'ExamineActionsAPI': ['Mods/ExamineActionsAPI.dll'],
    'FoodPackByTKG': ['Mods/FoodPackByTKG.dll', 'Mods/FoodPackByTKG.modcomponent'],
    'FoodsByCalorieWaltz': ['Mods/FoodsByCalorieWaltz.dll', 'Mods/FoodsByCalorieWaltz.json', 'Mods/FoodsByCalorieWaltz.modcomponent', 'Mods/FoodsByCalorieWaltz'],
    'GearInfo': ['Mods/GearInfo.dll', 'Mods/GearInfo.json'],
    'IndoorsGreenery': ['Mods/IndoorsGreenery.dll', 'Mods/IndoorsGreenery.json', 'Mods/Indoors_Greenery_DLC.modcomponent'],
    'PickWaterFromFishingHoles': ['Mods/PickWaterFromFishingHoles.dll', 'Mods/PickWaterFromFishingHoles.json'],
    'PineNeedleTea': ['Mods/PineNeedleTea.dll', 'Mods/PineNeedleTea.json', 'Mods/PineNeedleTea.modcomponent'],
    'ResearchBookTweaker': ['Mods/ResearchBookTweaker.dll', 'Mods/ResearchBookTweaker.json'],
    'StalkerAidsAndSupplements': ['Mods/StalkerAidsAndSupplements.dll', 'Mods/StalkerAidsAndSupplements.json', 'Mods/StalkerAidsAndSupplements.modcomponent'],
    'BlueprintCleaner': ['Mods/BlueprintCleaner.dll', 'Mods/BlueprintCleaner.json'],
    'MiseryModePlus': ['Mods/MiseryModePlus.dll'],
    'PerfectPlacement': ['Mods/PerfectPlacement.dll', 'Mods/PerfectPlacement.json', 'Mods/PerfectPlacement.poses.txt'],
    'FiligranisSkills': ['Mods/FiligranisSkills.dll'],
    'PrepperCache': ['Mods/PrepperCache.dll', 'Mods/PrepperCache.json'],
    'ItemPicker': ['Mods/ItemPicker.dll', 'Mods/ItemPicker.json', 'Mods/ItemPickerCustomList.txt'],
    'TheLongDevelopment': ['Mods/TheLongDevelopment.dll', 'Mods/TLDev'],
    'PredatorSpawnSelector': ['Mods/PredatorSpawnSelector.dll', 'Mods/PredatorSpawnSelector.json'],
    'SCPlusFix++': ['Mods/SCPlusFix++.dll', 'Mods/SCPlusFix++.json', 'Mods/SCPlus'],
    'MotionTrackerLite': ['Mods/MotionTrackerLite.dll', 'Mods/MotionTrackerLite.json', 'Mods/MotionTrackerLite_icons'],
    'ObjectSinkFix': ['Mods/ObjectSinkFix.dll', 'Mods/ObjectSinkFix.json'],
    'RarityRework': ['Mods/RarityRework.dll', 'Mods/RarityRework.json'],
    'Episode5ShotgunPrototype': ['Mods/Episode5ShotgunPrototype.dll', 'UserData/Episode5ShotgunPrototype'],
    'Episode5SurvivalItems': ['Mods/Episode5SurvivalItems.dll', 'UserData/Episode5SurvivalItems'],
}


def find(rel):
    for s in SRCS:
        p = os.path.join(s, rel)
        if os.path.exists(p):
            return s, p
    return None, None


def mod_dlls():
    out = {}
    for s in reversed(SRCS):
        for sub in ('Mods', 'UserLibs'):
            d = os.path.join(s, sub)
            if os.path.isdir(d):
                for f in os.listdir(d):
                    if f.lower().endswith('.dll'):
                        out[f[:-4]] = sub + '/' + f
    return out


def refs(path):
    pe = dnfile.dnPE(path)
    names = []
    t = pe.net.mdtables.AssemblyRef
    if t:
        for r in t:
            names.append(str(r.Name))
    pe.close()
    return names


def main():
    lib = mod_dlls()
    result = {}
    for mod, files in MODS.items():
        own, missing, src = [], [], set()
        for rel in files:
            s, p = find(rel)
            if p:
                own.append(rel)
                src.add(os.path.basename(s))
            else:
                missing.append(rel)
        deps, todo = [], [f for f in own if f.endswith('.dll')]
        seen = set(todo)
        while todo:
            rel = todo.pop()
            _, p = find(rel)
            for n in refs(p):
                if n in lib and lib[n] not in seen:
                    seen.add(lib[n])
                    deps.append(lib[n])
                    todo.append(lib[n])
        result[mod] = {'own': own, 'missing': missing, 'deps': sorted(deps), 'src': sorted(src)}
        print(f"{mod} src={','.join(sorted(src))} missing={missing} deps={[os.path.basename(d)[:-4] for d in sorted(deps)]}")
    json.dump(result, open(sys.argv[1], 'w', encoding='utf-8'), ensure_ascii=False, indent=1)


main()
