import re, json, collections
T = r"C:\Users\82077\AppData\Local\Temp\tlddiff\rr"
NAMES = ["", "普通", "优秀", "精良", "史诗", "传说", "神话"]

SKIP = re.compile(r"Note|Diary|Journal|Logbook|Log\d|Transcript|PostCard|ClipBoard|Papers\d|Schematic|Poster|Pamphlet|Memo|SurvivalPath"
                  r"|Key\d*$|_Key|ID$|IDcard|WaxCylinder|IronRoad|HiddenWallCache|Bones$|BonesNote|Placeholder|Dummy|Story$"
                  r"|Rudiger_Watch|TrainBrake|TrainThrottle|HatchWheel|WaterBottleLabel|FlyerBingo|ScribbledMap|SurvivalElevatorCrank")
NAMED = {"GEAR_WhaleOilCan", "GEAR_IronRoadTrainKey"}
FORCE_SKIP = {"GEAR_IronRoadTrainKey"}

OVERRIDES = """
6: BearSkinCoat CougarWrap Bow_Woodwrights Rifle_Barbs Rifle_Curators Rifle_Vaughns Hatchet_Crafted Knife_Hunter
5: WhaleOilHeater Travois Crampons BearSkinBedRoll MooseHideBag MuklukBoots WolfSkinCape WolfSkinPant WolfskinParka ExpeditionCoat ExpeditionParka SurvivorParka ColdFusionSuit TechnicalBackpack BallisticVest
   Rifle HuntingRifle RifleB RifleC Rifle_Trader Shotgun Revolver44Mag RevolverFancy RevolverGreen RevolverStubNosed FlareGun Bow_Bushcraft Bow_Manufactured CougarClawKnife CougarHideDried
   EmergencyStim MilitaryStim Tent TentBear BearskinLeggings_MOD WolfskinBoots_MOD WolfskinCap_MOD GreyWolfSkinCoat MooseBagPlusScabbard
4: Hatchet Knife SewingKit Firestriker MagnifyingLens HighQualityTools Flashlight_LongLasting KeroseneLamp_Spelunkers Respirator ImprovisedCrampons BedRoll_Down BoltCutters ToolBelt Vice JeremiahKnife StitchingKit
   Revolver RevolverB RevolverFlat Bow BowB BowC SurvivalBow SurvivalKnife BearSpear ArrowManufactured BlueFlare FlareGunAmmoSingle RifleAmmoBox RevolverAmmoBox
   ShotgunAmmoBox ShotgunAmmoBoxBirdshot ShotgunAmmoBoxBuckshot ShotgunAmmoBoxSlug WhaleOilCan FuelOrca
   BearHide BearHideDried MooseHide MooseHideDried CaribouHideDried CougarHide CougarClaw WolfPeltDried GreyWolfPeltDried
   ClimbingSocks CombatBoots CombatPants CowichanSweater DeerSkinBoots DeerSkinPants Deerskin_pants DeerSkinCoat DeerSkinGloves DeerSkinHat HatLeatherAviatorA InsulatedBoots InsulatedPants
   JacketLeatherFlightA MilitaryParka MooseHideCloak PremiumWinterCoat RabbitSkinMittens RabbitskinHat RifleScabbardA WolfSkinHat
   BookArchery BookRifleFirearm BookRevolverFirearm BookGunsmithing BookRifleFirearmAdvanced
   BackPackForestTalker_A BackPackForestTalker_A01 BackPack_A GunParts BowDrill FlintNSteel WolfScarf MetalLighter SatchelM DeerskinCoat_MOD DeerskinGloves_MOD
   CryptidHeadWear GreyWolfSkinBraces Anabiotics FirstAidKitPainkiller PainkillerMorphineVial LichRosehipWineAge3 MRE
3: BedRoll BedRoll_Blend Canister CarBattery CookingPot FishingTackleBox Flashlight Flashlight_CrankLamp Flashlight_DIf Hacksaw Hammer HandheldShortwave HatchetImprovised
   InsulatedFlask InsulatedFlask_A InsulatedFlask_B InsulatedFlask_C InsulatedFlask_D InsulatedFlask_E InsulatedFlask_F InsulatedFlask_G JerrycanRusty KeroseneLampB KnifeImprovised KnifeScrapMetal
   NoiseMaker Prybar RevolverCleaningKit RifleCleaningKit Rope SafeCrackingStethoscope SharpeningStone SimpleTools Skillet Snare SpearFishing Toolbox_Simple WaterPurificationTablets WoodworkingTools
   Arrow ArrowHardened ArrowHead ArrowManufacturedHead ArrowSurvival Bullet FlareA RevolverAmmoSingle RifleAmmoSingle ShotgunAmmoSingle ShotgunAmmoSingleBirdshot ShotgunAmmoSingleBuckshot ShotgunAmmoSingleSlug
   BearQuarter CaribouHide CougarCarcass CougarQuarter CuredLeather GutDried LeatherDried LeatherHideDried Leather_Dried_Shoes MooseQuarter RabbitPeltDried WolfPelt GreyWolfPelt
   AntiInfectionWipes AntibioticPillBottle BottleAntibiotics BottleHydrogenPeroxide BottlePainKillers BottleVitaminC HeatPad OldMansBeardDressing
   Balaclava CargoPants DownParka DownSkiJacket FishermanSweater Gauntlets HatGatorBalaclavaA HeavyParka HeavyWoolSweater LongUnderwearWool MackinawJacket MinersBoots MinersJacket MinersPants
   QualityWinterCoat SkiBoots SkiGloves TacticalGloves TacticalJacket WoolWrap
   Accelerant AccelerantGunpowder AccelerantKerosene ForgedHatchetHead ForgedKnifeBladeA ForgedKnifeBladeB Fuse GunpowderCan SpearHead
   BirchbarkTea ReishiTea ReishiPrepared BeefJerky CondensedMilk PeanutButter MapleSyrup CannedHam AirlineFoodChick AirlineFoodVeg EnergyBar SaltBag CuredFish CuredMeat CuredMeatA CuredMeatPtarmigan SaltedMeatPtarmigan
   CookedCohoSalmon RawCohoSalmon CookedMeatCougar RawMeatCougar CookedMeatMoose RawMeatMoose CookedMeatBear RawMeatBear CookedPtarmiganWhole
   BookCarcassHarvesting BookCooking BookFireStarting BookIceFishing BookMending BookPlantsGuide
   ElectronicParts NutsNBoltsBox StringDurable TapeRoll TarpSheet Jerrycan_A ActiveEmberBox EmberBox SatchelExplosive ARC_nailbox
   Book1011 Book1012 Book1013 Book1014 Book1015 Book1016 MakeshiftBedroll PrisonCoat SkiGoggles Skimask AnalogWatch DigitalWatch
   HoneyJar BeeHarvestedHoney SPAM WhiskyFlask glintweinCup hematogen OrcaFat CarbonFilter HumidKit GardeningTools PainkillerIbuprofen SleepingPills LichRosehipWineAge2
   BirchbarkTeaJam BirchbarkTeaSugar ReishiTeaJam ReishiTeaSugar LichStackWater LichStackFlareRed
2: Camera CanOpener Compass FishingBaitA FishingLine FishingLureA FishingLureB FishingLureC FishingLureD HookAndLine LampFuelFull PackMatches WoodMatches Torch TipUp TipUp_Flag
   ArrowManufacturedShaft ArrowShaft BearSpearBroken BrokenArrowManufactured RevolverAmmoCasing RifleAmmoCasing ShotgunAmmoCasing RifleBroken ScrapLead SpearFishingHead SprayPaintCanGlyphA
   CrowFeather Gut Leather LeatherHide Leather_Shoes PtarmiganCarcass PtarmiganFeathers PtarmiganPelt RabbitCarcass RabbitPelt StagQuarter TimberwolfQuarter WolfCarcass WolfCarcassMoose WolfQuarter
   Bandage HeavyBandage BottleOfWater CaffeineBox BottleCaffeine OldMansBeardHarvested
   ArmWrap BasicWinterCoat BasicWoolHat BasicWoolScarf DownVest EarMuffs FleeceMittens FleeceSweater ImprovisedDownInsulation InsulatedVest JerseyHockeyA LeatherBindings LightParka LongUnderwear
   MinersHelmet MittenBlueStripe MittenBrownStripe MittenBurgundyPattern Mittens PrisonerVest SkiJacket SockDots SockMoose SockPlaid SweaterChristmasA Toque WoolShirt WoolSocks WoolSweater WoolWrapCap WorkBoots WorkGloves WorkPants
   AnimalFat BirchSaplingDried BirchbarkPrepared BirchbarkTeaDried Coal DustingSulfur Firelog LampFuel MapleSaplingDried ScrapMetal StumpRemover WireBundle
   Crackers CookedBurbot RawBurbot CookedSmallMouthBass RawSmallMouthBass CookedRainbowTrout RawRainbowTrout CookedMeatPtarmigan RawMeatPtarmigan CookedMeatWolf RawMeatWolf RawPtarmiganWhole
   CookedMeatCaribou RawMeatCaribou CookedCopperFish CookedLakeBurbot CookedLakeGoldeye RawLakeBurbot
   CannedBeans CannedBeansB CannedCorn CannedSardines CannedPineapple CannedPeasAndCarrots PinnacleCanPeaches TomatoSoupCan DogFood CandyBar GranolaBar Salt Flour OatsTin CookingOil UncookedOil UncookedCookingOil
   MilkPowder OatmealPacket Pickles Pickled_Eggs Pickled_Onions DriedApples DriedMangos MeatFat AcornShelled AcornShelledBig AcornShelled_Bbig AcornCooked AcornCookedBig BurdockPrepared RosehipsPrepared ReishiMushroom
   CookedBurdock CookedCatTailStalk PotatoCooked
   AcornCoffeeCup AcornCoffeeTin BurdockTea CoffeeCup CoffeeTin GreenTeaCup GreenTeaPackage RoseHipTea SodaEnergy Water1000ml Water500ml WaterBottle WaterSupplyPotable
   Battery9V Flint MetalBoxForge NutsNBolts RecycledGlass RecycledPlastic StringBundle Cereal_A Cereal_B GoldNugget Goldnuggeta ARC_log ARC_logbundle ARC_nails ARC_plank ARC_plankbundle
   PineNeedleTea OakFireWood OakFireWoodPile5 MakeshiftBlanket OldBlanket1 OldBlanket2 BeanieCap FarmBoots MedicalFaceMask Candle FatRaw Wax Stopwatch Sundial StrongFishingLine
   BeeHive BirdEggRaw BirdEggBoiled BirdMeatRaw BirdMeatCooked CoalChunk CrushedHalite Halite NestFull1 NestFull2 NestFull3 OrcaBones1 OrcaBones2 Largemouthbass ScrapPile010 CoalPile004
   NaturalBandage SugarA RosehipJam UncookedRosehipJam LichStackCloth Yeast PotatoSack Barrel EmptyPackage
1: CattailPlant CattailStalk CattailTinder Hook Line RockCacheA BrokenArrow BrokenArrowHardened SprayPaintCan Stone
   BaseballCap BasicBoots BasicGloves BasicShoes CottonHoodie CottonScarf CottonShirt CottonSocks ImprovisedHat ImprovisedMittens Jeans LeatherShoes NewsprintBootStuffing PlaidShirt TShirtCM TShirtGBI TShirtSnappy TeeShirt
   BarkTinder BirchSapling Charcoal Cloth Hardwood MapleSapling Newsprint NewsprintInsulation NewsprintRoll OldWoolScarf PaperStack ReclaimedWoodB RecycledCan Softwood Stick Tinder
   Acorn AcornGrounds Broth UncookedBroth Burdock Carrot Potato RoseHip CatTailStalk KetchupChips MeatFat_Spoiled Soda SodaGrape SodaOrange WaterSupplyNotPotable
   BookA BookB BookBopen BookC BookD BookE BookEopen BookF BookFopen BookG BookH BookHopen BookI BookLabE_01 BookLabE_02 BookLabE_03 BookLabE_Open_01 BookManual
   Film_Box_BW Film_Box_Colour Film_Box_Sepia FilmBoxBW FilmBoxColour FilmBoxSepia
   Bones CeramicShards CrumpledPaper GlassShards Rock ScrapPlastic GoldCross RosaryA PineNeedle PineNeedleDried PineNeedlePrepared BirchWood BirchWoodPile5
   ImprovisedFaceMask PrisonPants PrisonShirt Wick HaliteSmall NestEmpty SkullBear SkullStag SignL
   BookBigOne BookGhostStag BookLostCave BookSasquatch DeadMatter SoilBag PlantWater
   LichStackNewspaper1 LichStackNewspaper2 LichStackNewspaper3 LichStackSpraypaint LichStackRecycledcan
"""

RULES = [
    (r"Package$", 3),
    (r"Package2$", 2),
    (r"^Cooked(ApplePie|BearStew|MooseStew|WolfStew|BlueberryPie|SoapberryPie|ForagerOmelette|ForagerStew|Omelette|SpanishOmelette|Poutine|SkilletPizza|ToastedSandwich|Pierogi)$|^Cookedperogi$|^(MacCheese|MashedPotatoes|PremiumPasta)Cooked$|^OrcaMeat", 3),
    (r"^CigarettePack", 1),
    (r"^(BariumCarbonate|CalciumChloride|CopperCarbonate|IronFilings|MagnesiumPowder|Rubidium|DistilledWater|PlantNutrients|PlantNutrientsCrafted|GardeningMesh|GardeningToolsImprovised)$", 2),
    (r"^(Burdock|RoseHip)Tea(Jam|Sugar)$|^(ForsakenSpirits|ForsakenSpiritsPlastic|VodkaBottle)$", 2),
    (r"^cc[A-Z]|^LichPlush|^Pillow|^TV_|^Snow(Dog|Men|Mister)|^candle(Blue|Green|Purple|Red)|^card(Blue|Green|Purple|Red)", 1),
    (r"^(1FirConeFuel|4FirCone|1FirSeedBunchRoasted|2FirConeSeedsRoasted|2FirSeedBunch|3FirConeSeeds)$", 1),
    (r"Pile0\d\d|Pile0\d\dF", 1),
    (r"^(Chemical|Combat|Deerskin|Dressing|Insulated|Mukluk|Running|Ski|Trail|Work)NCrampons$", 5),
    (r"^(Chemical|Combat|Deerskin|Dressing|Insulated|Mukluk|Running|Ski|Trail|Work)ICrampons$", 4),
    (r"^(Cargo|Combat|Deerskin|Insulated|Jeans|Miner|Work)Toolbelt$", 4),
    (r"^TanningRack", 4),
    (r"^Map(BI|CH|ML|MT|PV)Deco$", 1),
    (r"^Map(BI|CH|ML|MT|PV)$", 2),
    (r"^(RecipeCard|BlueprintCard)", 3),
    (r"^(Cured|Salted)(Fish|Meat)", 3),
    (r"^LichStack(Meat|Hide|CanOf|Energybar|Granolabar|Chocolatebar)", 3),
    (r"^(AcornBrandy|BirchBarkBeer|BurdockMoonshine|CatTailRum|ReishiWhisky|RosehipWine|Vodka)Barrel$", 2),
    (r"^(AcornBrandy|BirchBarkBeer|BurdockMoonshine|CatTailRum|ReishiWhisky|RosehipWine|Vodka)BarrelReady", 3),
    (r"^Lich(AcornBrandy|BirchBarkBeer|BurdockMoonshine|CatTailRum|ReishiWhisky|Vodka|RosehipWineAge1)$", 2),
    (r"^Planter|^DeadPlanter", 1),
    (r"^Seeds", 2),
    (r"^Dirt(Box|Can|Humid|Pot)$", 1),
    (r"^Cooked(Pie|Stew|Soup|Pancake|Bannock|Porridge|Fishcakes|BarPemmican)|^Uncooked(Pie|Stew|Soup|Pancake|Bannock|Porridge|Fishcakes|BarPemmican)", "recipe"),
    (r"^(Cooked|Raw)(Goldeye|LakeWhiteFish|LakeGoldeye|RedIrishLord|Rockfish|MeatDeer|MeatRabbit)$", 2),
]

KNOWN_ZH = {
    "GEAR_DeerSkinCoat": "鹿皮外套", "GEAR_DeerSkinGloves": "鹿皮手套", "GEAR_DeerSkinHat": "鹿皮帽",
    "GEAR_BottleCaffeine": "咖啡因片", "GEAR_UncookedCookingOil": "食用油(未烹饪)",
    "GEAR_FilmBoxBW": "FastFilm-500BW 黑白胶片", "GEAR_FilmBoxColour": "FastFilm-500 彩色胶片", "GEAR_FilmBoxSepia": "FastFilm-500SPA 棕褐胶片",
    "GEAR_BlueprintCard_BushcraftBow": "图纸卡(丛林生存弓)", "GEAR_BlueprintCard_WolfSkinHat": "图纸卡(狼皮帽)", "GEAR_BlueprintCard_WolfSkinPants": "图纸卡(狼皮裤)",
}

ov = {}
for line in OVERRIDES.strip().splitlines():
    line = line.strip()
    if ":" in line:
        tier, line = line.split(":", 1)
        tier = int(tier)
    for g in line.split():
        if "GEAR_" + g in ov:
            print("dup override", g)
        ov["GEAR_" + g] = tier

DEFAULT = {"食物": 2, "材料": 1, "工具": 3, "衣物": 2, "装饰": 1, "武器": 3, "其他": 2, "饮料": 2, "狩猎": 2, "医疗": 3, "": 2}
rows = [l.rstrip("\n").split("\t") for l in open(T + r"\master.tsv", encoding="utf-8")][1:]
out, skipped, fallback, used = [], [], [], set()
for g, zh, cat, w, cal, kind, tag, old in rows:
    zh = KNOWN_ZH.get(g, zh)
    zh_clean = re.sub(r"\s*\[[^\]]*\]\s*$", "", zh)
    base = g[5:]
    if g in FORCE_SKIP or (g not in ov and g not in NAMED and SKIP.search(base)):
        skipped.append((g, zh_clean))
        continue
    src = ""
    if g in ov:
        t, src = ov[g], "override"
        used.add(g)
    else:
        for pat, t in RULES:
            if re.search(pat, base):
                if t == "recipe":
                    t = min(int(old), 4) if old else 3
                src = "rule"
                break
        else:
            if old:
                t, src = int(old), "old"
            elif tag == "CW" and cat in ("食物", "饮料"):
                t, src = 2, "rule"
            else:
                t, src = DEFAULT.get(cat, 2), "default"
                fallback.append((g, zh_clean, cat, tag, t))
    out.append((g, zh_clean, cat, kind, tag, old, t, src))

for g in ov:
    if g not in used:
        print("override unused", g)
with open(T + r"\tiers.tsv", "w", encoding="utf-8", newline="\n") as f:
    f.write("GEAR\t中文名\t档位\t分类\t来源\t原档\n")
    for g, zh, cat, kind, tag, old, t, src in sorted(out, key=lambda r: (-r[6], r[2], r[0])):
        f.write(f"{g}\t{zh}\t{NAMES[t]}\t{cat}\t{('原版' if kind in ('vanilla', 'catalog', 'ironroad') else 'mod ' + tag)}\t{('Lv' + old) if old else ''}\n")
with open(T + r"\skipped.tsv", "w", encoding="utf-8", newline="\n") as f:
    for g, zh in skipped:
        f.write(f"{g}\t{zh}\n")
print("rated", len(out), "skipped", len(skipped), collections.Counter(NAMES[r[6]] for r in out))
print("by src", collections.Counter(r[7] for r in out))
print("fallback", len(fallback))
for r in fallback:
    print(" ", *r)
