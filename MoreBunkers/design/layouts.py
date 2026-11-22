# 三个地堡的布置数据。坐标是房间坐标(米),x 东 z 北
# face 是正面朝向:S=0 朝 +z(贴南墙),W=90 朝 +x(贴西墙),N=180 朝 -z(贴北墙),E=270 朝 -x(贴东墙)
# levels 从下往上,每层一组 (物品, 最少, 最多[, 叠几层]);theme 是箱子里装什么
# 数量是朝圣者下的件数:能叠的按"件"写(一盒子弹、一瓶药、一盒火柴、一罐咖啡),一件多少单位照游戏默认;
#   箭、火绒、树枝、弹壳、信号弹壳按根写,架上十根一捆。架子上摆的也算在总量里,其他难度按比例减
# 总量对照 totals.py:囤货地堡按一个人在里面过半年备,雇佣兵和工匠照用户定的比例
# on=-1 叠在上一件上面,mount 是离地(或离下面那件)的高度;free=True 不贴墙,落在下面的桌面或地面上
N, S, E, W = 180, 0, 270, 90
BOX_H = 0.32


def stack(x, z, face, *themes):
    """一摞铁箱,从下往上每个一个主题"""
    out = [dict(f='MetalBox', x=x, z=z, face=face, theme=themes[0])]
    for t in themes[1:]:
        out.append(dict(f='MetalBox', on=-1, mount=BOX_H, theme=t))
    return out


def books(x, z, face, mount, items):
    return dict(f='WallShelf', x=x, z=z, face=face, mount=mount, levels=[items])


MERC = [
    # 北墙:两张桌子(墙上有树根和立柱,不挂东西);东头两个双门衣柜
    dict(f='MetalTable', x=-2.15, z=1.80, face=N, levels=[
        [('RifleCleaningKit', 3, 3), ('SharpeningStone', 2, 2), ('SurvivalKnife', 2, 2), ('Knife', 1, 1), ('Hatchet', 1, 1)],
        [('RifleAmmoBox', 12, 12, 2), ('RevolverAmmoBox', 12, 12, 2), ('GunpowderCan', 2, 2)],
        [('RevolverFancy', 1, 1), ('RevolverGreen', 1, 1), ('RevolverStubNosed', 1, 1), ('Revolver', 2, 2)]]),
    # 台面最右(西头)留出收音机的位置,油灯挨着收音机
    dict(f='MetalTable', x=0.65, z=1.80, face=N, levels=[
        [('Rope', 2, 2), ('SewingKit', 2, 2)],
        [('FlareA', 5, 6), ('BlueFlare', 3, 4), ('Firestriker', 2, 2), ('MRE', 4, 4, 3), ('HeavyBandage', 3, 3), ('EmergencyStim', 2, 2)],
        [('FlareGun', 2, 2), ('Flashlight_LongLasting', 2, 2), ('Flashlight', 1, 1), ('KeroseneLampB', 1, 1), ('~0.34', 0, 0)]]),
    dict(f='Radio', x=0.15, z=1.57, face=N, free=True),
    dict(f='Chair', x=0.45, z=0.80, face=S, free=True),
    dict(f='LockerB', x=2.35, z=1.95, face=N, theme=[('MilitaryParka', 1, 2), ('TacticalJacket', 1, 1), ('BallisticVest', 1, 1), ('CombatPants', 1, 2), ('FleeceSweater', 1, 1)]),
    dict(f='LockerB', x=3.60, z=1.95, face=N, theme=[('CombatBoots', 1, 1), ('TacticalGloves', 1, 2), ('Balaclava', 1, 2), ('Toque', 1, 1), ('FleeceMittens', 1, 1), ('BedRoll', 1, 1)]),
    # 东墙(楼梯边,墙面平):两摞铁箱,一箱一类;上面挂两个枪架;南头一个小铁炉,上方挂钟
    dict(f='GunRack', x=4.13, z=1.00, face=E, mount=1.30, rack=['Rifle_Barbs', 'Rifle_Vaughns']),
    dict(f='GunRack', x=4.13, z=-0.20, face=E, mount=1.30, rack=['Rifle_Curators', 'Rifle_Trader']),
    *stack(3.95, 1.15, E, [('RifleAmmoBox', 38, 42)], [('RevolverAmmoBox', 13, 15)], [('FlareGunAmmoSingle', 36, 44), ('FlareA', 8, 10), ('GunpowderCan', 4, 6), ('Snare', 2, 2), ('Crampons', 1, 1), ('MagnifyingLens', 1, 1), ('Torch', 6, 8), ('SprayPaintCan', 3, 4), ('Charcoal', 12, 16)]),
    *stack(3.95, 0.37, E, [('ArrowManufactured', 90, 110)], [('ArrowManufacturedHead', 36, 44), ('ArrowManufacturedShaft', 36, 44)], [('BeefJerky', 12, 15), ('CoffeeTin', 8, 10), ('GreenTeaPackage', 8, 10), ('Crackers', 5, 6), ('PeanutButter', 3, 4)]),
    dict(f='Clock', x=4.20, z=-1.20, face=E, mount=1.95),
    dict(f='StoveBelly', x=3.88, z=-1.10, face=E, station='stove'),
    # 西墙:一排弓,弓上方挂日历;北角一摞铁箱(箭和煤柴、水和能量棒、罐头灯油和日用)
    dict(f=None, x=-4.05, z=-0.55, face=W, line=dict(dir=0, gap=0.22), items=[
        'Bow_Woodwrights', 'Bow', 'Bow', 'Bow_Manufactured', 'Bow_Manufactured', 'Bow_Bushcraft', 'Bow_Bushcraft']),
    dict(f='Calendar', x=-4.05, z=0.15, face=W, mount=1.65),
    *stack(-3.80, 1.45, W, [('ArrowManufactured', 55, 65), ('Coal', 55, 65), ('Softwood', 24, 26), ('Hardwood', 24, 26)], [('Water1000ml', 20, 22), ('EnergyBar', 33, 36), ('GranolaBar', 33, 36)], [('CannedBeans', 44, 48), ('CannedHam', 18, 22), ('CannedSardines', 28, 32), ('LampFuelFull', 5, 6), ('JerrycanRusty', 2, 2), ('CookingPot', 1, 1), ('CanOpener', 1, 1), ('WoodMatches', 5, 6)]),
    # 南墙:水架、豪华床(上方两块墙板:书,枪械书和灯、灯油)、药品架、枪柜(两把步枪)、医药柜
    dict(f='MetalShelfA', x=-2.80, z=-1.88, face=S, levels=[
        [('Water1000ml', 10, 10)],
        [('Water1000ml', 10, 10)],
        [('Water1000ml', 8, 8), ('WaterPurificationTablets', 3, 3)]]),
    dict(f='Bed', x=-0.65, z=-1.65, face=S, station='bed'),
    books(-0.65, -2.10, S, 1.25, [('BookA|BookB|BookC|BookD|BookE|BookF|BookG', 7, 7, 3)]),
    books(-0.65, -2.10, S, 1.70, [('BookRifleFirearm|BookRifleFirearmAdvanced|BookRevolverFirearm|BookArchery|BookGunsmithing', 5, 5, 3), ('KeroseneLampB', 1, 1), ('LampFuelFull', 2, 2)]),
    dict(f='MetalShelfA', x=1.55, z=-1.88, face=S, levels=[
        [('MRE', 8, 8, 3), ('CannedBeans', 4, 4, 2)],
        [('EmergencyStim', 3, 3), ('HeavyBandage', 5, 5), ('BottleAntibiotics', 2, 2), ('BottlePainKillers', 2, 2)],
        [('ArrowManufactured', 40, 40)]]),
    dict(f='GunLocker', x=2.95, z=-1.85, face=S, theme=[('Rifle', 2, 2), ('RifleAmmoBox', 8, 8), ('RevolverAmmoBox', 4, 4), ('RifleCleaningKit', 1, 2), ('EmergencyStim', 2, 2), ('Knife', 1, 1), ('Hatchet', 1, 1)]),
    dict(f='MedLocker', x=3.85, z=-1.85, face=S, theme=[('RosehipsPrepared', 8, 10), ('BirchbarkPrepared', 8, 10), ('ReishiPrepared', 8, 10), ('OldMansBeardDressing', 8, 10), ('EmergencyStim', 10, 12), ('HeavyBandage', 30, 34), ('BottleAntibiotics', 5, 6), ('BottlePainKillers', 5, 6), ('BottleHydrogenPeroxide', 4, 5), ('WaterPurificationTablets', 6, 8)]),
    # 中间:地毯
    dict(f='Rug', x=-1.20, z=0.20, face=E, free=True),
]

STOCK = [
    # 主房间北墙:豪华床(上方两块书板)、罐头架、外衣柜、干粮架;东北角冷藏箱
    dict(f='Bed', x=-2.75, z=1.68, face=N, station='bed'),
    books(-2.75, 2.10, N, 1.25, [('BookCooking|BookIceFishing|BookCarcassHarvesting|BookFireStarting|BookMending|BookA|BookB|BookC', 8, 8, 3)]),
    books(-2.75, 2.10, N, 1.70, [('BookF|BookG|BookH|BookI', 4, 4, 3), ('KeroseneLampB', 1, 1)]),
    dict(f='MetalShelfB', x=-0.35, z=1.93, face=N, levels=[
        [('CannedBeans', 18, 18, 2), ('TomatoSoupCan', 14, 14, 2)],
        [('PinnacleCanPeaches', 10, 10, 2), ('CannedCorn', 6, 6, 2), ('CondensedMilk', 6, 6, 2)],
        [('CannedSardines', 10, 10, 3), ('CannedHam', 6, 6, 3), ('CannedPineapple', 6, 6, 2)]]),
    dict(f='LockerB', x=1.12, z=1.95, face=N, theme=[('MackinawJacket', 2, 2), ('DownParka', 2, 2), ('HeavyWoolSweater', 2, 2), ('CowichanSweater', 2, 2), ('Jeans', 2, 2), ('CargoPants', 2, 2), ('InsulatedPants', 2, 2), ('Toque', 2, 4), ('WoolWrap', 2, 2), ('Mittens', 2, 2), ('WorkBoots', 2, 2)]),
    dict(f='MetalShelfB', x=2.60, z=1.93, face=N, levels=[
        [('Flour', 4, 4), ('OatsTin', 4, 4), ('Salt', 4, 4), ('CookingOil', 4, 4)],
        [('BeefJerky', 10, 10, 3), ('GranolaBar', 10, 10, 3), ('EnergyBar', 10, 10, 3)],
        [('Crackers', 6, 6), ('DriedApples', 5, 5), ('PeanutButter', 5, 5)]]),
    dict(f='Cooler', x=3.90, z=1.30, face=E, theme=[('Water1000ml', 50, 52), ('CondensedMilk', 24, 26), ('CoffeeTin', 30, 34), ('GreenTeaPackage', 30, 34), ('Soda', 28, 32), ('SodaOrange', 18, 22), ('SodaGrape', 18, 22), ('SodaEnergy', 14, 16), ('MapleSyrup', 9, 11)]),
    # 东墙:武器桌(上方一块墙板),南角一摞箱子(锅具、纸和引火、备用药)
    dict(f='MetalTable', x=3.85, z=-0.30, face=E, levels=[
        [('RevolverAmmoBox', 6, 6, 2), ('RifleAmmoBox', 6, 6, 2), ('FlareA', 3, 3), ('BlueFlare', 2, 2)],
        [('Hatchet', 1, 1), ('Prybar', 1, 1), ('SharpeningStone', 2, 2)],
        [('Revolver', 1, 1), ('RevolverAmmoBox', 2, 2), ('Knife', 1, 1), ('SurvivalKnife', 1, 1), ('CougarClawKnife', 1, 1), ('Flashlight', 1, 1), ('PackMatches', 2, 2, 3)]]),
    books(4.10, -0.30, E, 1.55, [('Flashlight', 1, 1), ('Firestriker', 1, 1), ('WoodMatches', 3, 3), ('PackMatches', 3, 3)]),
    *stack(3.95, -1.75, E, [('CookingPot', 2, 2), ('Skillet', 1, 1), ('RecycledCan', 6, 8), ('CanOpener', 1, 1)], [('NewsprintRoll', 10, 12), ('PaperStack', 12, 16), ('Accelerant', 6, 8), ('WoodMatches', 8, 10)], [('HeavyBandage', 42, 46), ('BottleAntibiotics', 6, 7), ('BottlePainKillers', 6, 7), ('HeatPad', 10, 12), ('BottleVitaminC', 6, 8), ('RifleAmmoBox', 10, 12), ('RevolverAmmoBox', 4, 5), ('RosehipsPrepared', 18, 20), ('BirchbarkPrepared', 18, 20), ('ReishiPrepared', 18, 20), ('RoseHipTea', 10, 12), ('ReishiTea', 10, 12), ('OldMansBeardDressing', 14, 16)]),
    # 主房间南墙:饮料架、药品架、内衣柜、生活用品架
    dict(f='MetalShelfB', x=-2.90, z=-1.93, face=S, levels=[
        [('Water1000ml', 24, 24)],
        [('Water1000ml', 20, 20)],
        [('CoffeeTin', 5, 5), ('GreenTeaPackage', 5, 5), ('CondensedMilk', 5, 5)]]),
    dict(f='MetalShelfB', x=-0.40, z=-1.93, face=S, levels=[
        [('HeavyBandage', 10, 10), ('HeatPad', 5, 5)],
        [('BottleAntibiotics', 5, 5), ('BottlePainKillers', 5, 5), ('BottleHydrogenPeroxide', 5, 5), ('BottleVitaminC', 3, 3)],
        [('WaterPurificationTablets', 4, 4), ('EmergencyStim', 3, 3), ('SewingKit', 2, 2)]]),
    dict(f='LockerB', x=1.08, z=-1.95, face=S, theme=[('LongUnderwear', 2, 4), ('LongUnderwearWool', 2, 2), ('WoolSocks', 4, 6), ('CottonSocks', 2, 4), ('WoolShirt', 2, 2), ('PlaidShirt', 2, 2), ('TeeShirt', 2, 4), ('BasicGloves', 2, 2), ('SkiGloves', 2, 2), ('BedRoll', 1, 1), ('Rope', 2, 2)]),
    dict(f='MetalShelfB', x=2.55, z=-1.93, face=S, levels=[
        [('CookingPot', 2, 2), ('CanOpener', 2, 2)],
        [('KeroseneLampB', 1, 1), ('LampFuelFull', 4, 4), ('Flashlight', 1, 1), ('Firestriker', 1, 1)],
        [('WoodMatches', 6, 6, 3), ('PackMatches', 5, 5, 3)]]),
    # 主房间中间:地毯、餐桌、一把椅子(收在桌边,两边过道留够)
    dict(f='Rug', x=0.60, z=0.00, face=E, free=True),
    dict(f='MetalTable', x=0.60, z=0.00, face=S, free=True, levels=[
        [('Tinder', 10, 10), ('CookingPot', 1, 1), ('WoodMatches', 3, 3, 3), ('PackMatches', 4, 4, 3), ('Firestriker', 1, 1), ('TomatoSoupCan', 3, 3)],
        [('BookD|BookE|BookF', 3, 3, 3), ('HeavyBandage', 4, 4), ('CoffeeTin', 3, 3), ('GreenTeaPackage', 3, 3), ('CondensedMilk', 3, 3), ('Crackers', 2, 2)],
        [('KeroseneLampB', 1, 1), ('Skillet', 1, 1), ('CannedBeans', 2, 2), ('BeefJerky', 2, 2, 2), ('GranolaBar', 2, 2)]]),
    dict(f='Chair', x=0.60, z=-0.78, face=S, free=True),
    # 入口平台:西墙做饭的炉子;北墙煤箱、柴火箱(上方一块墙板);南墙三摞箱子
    dict(f='Cookstove', x=-8.30, z=0.10, face=W, station='stove'),
    dict(f='CoalBin', x=-8.20, z=1.55, face=N, theme=[('Coal', 290, 310)]),
    dict(f='FirewoodBin', x=-6.20, z=1.55, face=N, theme=[('Softwood', 100, 106), ('Hardwood', 58, 64), ('Firelog', 28, 32), ('Stick', 90, 110), ('BarkTinder', 36, 44)]),
    books(-6.20, 2.10, N, 1.60, [('Tinder', 20, 20), ('WoodMatches', 3, 3, 3), ('PackMatches', 3, 3, 3), ('Firestriker', 1, 1)]),
    *stack(-7.15, -1.85, S, [('ReclaimedWoodB', 48, 52)], [('Softwood', 58, 62)], [('Hardwood', 38, 42)]),
    *stack(-6.35, -1.85, S, [('CannedBeans', 58, 62), ('TomatoSoupCan', 14, 16), ('PinnacleCanPeaches', 28, 32), ('CannedSardines', 28, 32)], [('Water1000ml', 150, 155)], [('MRE', 118, 125), ('BeefJerky', 16, 20), ('CandyBar', 23, 27), ('KetchupChips', 14, 16), ('AirlineFoodChick', 7, 9), ('AirlineFoodVeg', 7, 9), ('CannedHam', 17, 21), ('CannedCorn', 13, 15), ('CannedPineapple', 13, 15)]),
    *stack(-5.55, -1.85, S, [('Firelog', 28, 32), ('Water1000ml', 57, 60)], [('Tinder', 80, 100), ('Stick', 50, 70)], [('LampFuelFull', 14, 16), ('JerrycanRusty', 6, 8), ('Flashlight', 1, 1), ('MagnifyingLens', 1, 1), ('Torch', 10, 12), ('SprayPaintCan', 4, 6), ('Charcoal', 20, 24), ('Snare', 4, 4), ('HookAndLine', 4, 4), ('Hook', 15, 20), ('FishingLine', 15, 20), ('FishingLureA', 1, 1), ('FishingLureB', 1, 1), ('FishingLureC', 1, 1), ('FishingBaitA', 15, 20), ('GranolaBar', 18, 22), ('EnergyBar', 13, 17), ('Crackers', 15, 19), ('PeanutButter', 13, 17), ('DriedApples', 6, 8), ('Flour', 4, 4), ('OatsTin', 4, 4), ('Salt', 4, 4), ('CookingOil', 4, 4), ('WaterPurificationTablets', 30, 36)]),
]

CRAFT = [
    # 走廊西墙:工具柜、一摞箱子、弹药工作台(上方墙板)、一摞箱子、锻炉
    dict(f='ToolCabinet', x=-0.65, z=-8.70, face=W, theme=[('SharpeningStone', 6, 8), ('SewingKit', 4, 5), ('SimpleTools', 1, 2), ('RifleCleaningKit', 4, 5), ('Hammer', 1, 1), ('Hatchet', 1, 1), ('Knife', 1, 1), ('Firestriker', 1, 1)]),
    *stack(-0.70, -7.55, W, [('ScrapMetal', 70, 90)], [('ScrapMetal', 60, 70)], [('ScrapLead', 48, 60)]),
    dict(f='AmmoBench', x=-0.20, z=-5.90, face=W, station='ammo'),
    books(-0.95, -5.90, W, 1.90, [('GunpowderCan', 3, 3), ('RifleAmmoCasing', 20, 20), ('RevolverAmmoCasing', 20, 20)]),
    *stack(-0.70, -4.32, W, [('RifleAmmoCasing', 200, 240)], [('RevolverAmmoCasing', 200, 240)], [('GunpowderCan', 18, 24), ('ScrapLead', 36, 48), ('RifleAmmoBox', 12, 14), ('RevolverAmmoBox', 6, 7)]),
    dict(f='Forge', x=-0.25, z=-3.25, face=W, station='forge'),
    # 走廊东墙:一摞箱子、中号工具柜、铣床、工作台(上方墙板)
    *stack(3.05, -9.30, E, [('Coal', 78, 82)], [('Coal', 78, 82)], [('Hardwood', 38, 42)]),
    dict(f='ToolCabinetMedium', x=3.05, z=-7.60, face=E, theme=[('Hacksaw', 1, 1), ('Prybar', 1, 1), ('HighQualityTools', 1, 1), ('SimpleTools', 1, 1), ('WireBundle', 18, 24), ('Rope', 4, 4), ('Snare', 4, 4), ('Crampons', 1, 1), ('MagnifyingLens', 1, 1), ('SprayPaintCan', 4, 6)]),
    dict(f='Mill', x=2.60, z=-5.90, face=E, station='mill'),
    dict(f='WorkBench', x=2.60, z=-3.30, face=E, station='bench'),
    books(3.30, -3.30, E, 1.65, [('SharpeningStone', 3, 3), ('SewingKit', 2, 2, 3)]),
    # 主房间北墙:豪华床(上方两块书板)、材料架、柴火箱
    dict(f='Bed', x=-2.90, z=1.68, face=N, station='bed'),
    books(-2.90, 2.10, N, 1.25, [('BookMending|BookGunsmithing|BookFireStarting|BookCarcassHarvesting|BookRifleFirearm|BookA|BookB', 7, 7, 3)]),
    books(-2.90, 2.10, N, 1.70, [('BookD|BookE|BookF', 3, 3, 3), ('KeroseneLampB', 1, 1), ('LampFuelFull', 3, 3)]),
    dict(f='MetalShelfB', x=0.20, z=1.93, face=N, levels=[
        [('ScrapMetal', 12, 12, 3)],
        [('ScrapLead', 8, 8, 3), ('GunpowderCan', 5, 5, 2)],
        [('LeatherDried', 6, 6, 3), ('SewingKit', 3, 3)]]),
    dict(f='FirewoodBin', x=2.20, z=1.60, face=N, theme=[('Softwood', 98, 105), ('Hardwood', 58, 62), ('ReclaimedWoodB', 48, 52), ('Firelog', 28, 32), ('Stick', 90, 110)]),
    # 主房间西墙:一摞箱子、工具桌
    *stack(-3.80, 0.45, W, [('Cloth', 70, 90), ('Leather', 24, 36), ('RabbitPeltDried', 24, 30), ('WolfPeltDried', 12, 18)], [('LeatherDried', 36, 48), ('Gut', 36, 48), ('MooseHideDried', 3, 4), ('BearHideDried', 2, 2)], [('Line', 36, 48), ('FishingLine', 12, 18), ('HookAndLine', 4, 4), ('Hook', 18, 24), ('FishingLureA', 1, 1), ('FishingLureB', 1, 1), ('Torch', 6, 8), ('Charcoal', 18, 24)]),
    dict(f='MetalTable', x=-3.65, z=-1.15, face=W, levels=[
        [('ScrapMetal', 6, 6, 2)],
        [('SharpeningStone', 3, 3), ('SewingKit', 2, 2, 3), ('RifleCleaningKit', 2, 2), ('GunpowderCan', 2, 2)],
        [('HighQualityTools', 1, 1), ('Hammer', 1, 1), ('Hacksaw', 1, 1), ('Knife', 1, 1), ('Hatchet', 1, 1)]]),
    # 主房间东墙:煤箱、铁炉(取暖)
    dict(f='CoalBin', x=3.55, z=0.10, face=E, theme=[('Coal', 138, 142)]),
    dict(f='StoveBelly', x=3.80, z=-1.70, face=E, station='stove'),
    # 主房间南墙:工作服柜、一摞箱子(水、吃的、锅具)
    dict(f='LockerB', x=-2.45, z=-1.95, face=S, theme=[('WorkGloves', 1, 2), ('WorkPants', 1, 1), ('WorkBoots', 1, 1), ('MackinawJacket', 1, 1), ('PlaidShirt', 1, 1), ('WoolSocks', 1, 2), ('LongUnderwear', 1, 1), ('Toque', 1, 1), ('BedRoll', 1, 1)]),
    *stack(-1.55, -1.85, S, [('Water1000ml', 96, 100)], [('MRE', 58, 62), ('CannedBeans', 55, 60), ('TomatoSoupCan', 40, 45), ('EnergyBar', 33, 36), ('GranolaBar', 33, 36), ('BeefJerky', 10, 12), ('CoffeeTin', 6, 8), ('GreenTeaPackage', 6, 8)], [('CookingPot', 1, 1), ('RecycledCan', 6, 8), ('CanOpener', 1, 1), ('WoodMatches', 10, 12), ('JerrycanRusty', 3, 4), ('LampFuelFull', 6, 8), ('HeavyBandage', 36, 42), ('BottleAntibiotics', 6, 8), ('BottlePainKillers', 6, 8), ('BottleHydrogenPeroxide', 5, 6), ('WaterPurificationTablets', 10, 12), ('RosehipsPrepared', 10, 12), ('BirchbarkPrepared', 10, 12), ('ReishiPrepared', 10, 12), ('OldMansBeardDressing', 10, 12)]),
    # 主房间中间:地毯、绘图桌、椅子
    dict(f='Rug', x=0.70, z=-0.02, face=E, free=True),
    dict(f='MetalTable', x=0.70, z=-0.02, face=S, free=True, levels=[
        [('ScrapMetal', 4, 4, 2), ('LeatherDried', 3, 3, 3)],
        [('BookGunsmithing|BookMending|BookA', 3, 3, 3), ('ScrapLead', 3, 3, 3), ('RifleAmmoCasing', 20, 20), ('RevolverAmmoCasing', 20, 20)],
        [('KeroseneLampB', 1, 1), ('SewingKit', 1, 1), ('SharpeningStone', 2, 2), ('Firestriker', 1, 1), ('GunpowderCan', 2, 2)]]),
    dict(f='DeskLamp', x=1.50, z=0.23, face=S, free=True),
    dict(f='Chair', x=0.70, z=-0.82, face=S, free=True),
]

LAYOUTS = {
    'merc': dict(interior='PrepperCacheAEmpty', pieces=MERC),
    'stock': dict(interior='PrepperCacheBEmpty', pieces=STOCK),
    'craft': dict(interior='PrepperCacheCEmpty', pieces=CRAFT),
}
