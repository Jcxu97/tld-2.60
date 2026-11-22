p = r'D:\Github\tld--2.55\_work\release\tencent_doc\doc.txt'
raw = open(p, 'rb').read()
bom = raw.startswith(b'\xef\xbb\xbf')
s = raw.decode('utf-8-sig')

TABLE = '''终极版有完整版的所有 mod，ItemPicker 直接启用，用它自己的默认设置（按一下左 Alt 把身边 2 米内的树枝和石块一次捡起来）。下面是多出来的（按字母排），每个的设置都能在 Mod Settings 里改。
| mod | 是什么 |
| AfflictionsAndBuffs | 加了一些新的增益和伤病状态，比如坚持（Determination）这类增益，冷、累、饿、渴时会触发 |
| AlcoholMod | 喝酒会醉，有酒精浓度 |
| Better-Night-Sky | 夜空更好看 |
| BetterCamera | 调第一人称镜头 |
| BiggerTrappers | 猎人小屋（Trapper's Homestead）扩建，屋里多了空间和家具 |
| Bountiful_Foraging | 多了能采集的东西，比如乌鸦、蜂巢、鸟窝、松果、盐块，还能处理逆戟鲸尸体 |
| CampingTools | 加了折刀、求生刀、书、地图、打火机、挎包这些野营用品，每样都能单独关 |
| Candlelight | 能做蜡烛、点蜡烛照明。鼠标中键对着蜡烛点灯 |
| ClothingExpanded | 加了很多新衣服 |
| ClothingTweaker2 | 改衣服的保暖、防风、重量这些属性 |
| CoastalFulmar | 沿海公路港口多了一艘能上去的 Fulmar 号船，船上有货舱物资 |
| CookWhileFishingReborn | 冰钓的时候能顺便在炉子上做饭 |
| CougarSoundBegone | 去掉美洲狮一直响的环境音 |
| CozyBlankets | 毯子，能做、能披、能铺 |
| CozyCushions | 坐垫和椅子能坐下。鼠标中键对着坐垫或椅子坐下 |
| DoubleBarrel | 双管霰弹枪 |
| Episode5ShotgunPrototype | 剧情第五章的霰弹枪放进沙盒模式，商人能换、弹药工作台能做子弹、海边能捡到 |
| Episode5SurvivalItems | 剧情第五章的三样东西放进沙盒模式，手摇灯、军用兴奋剂、自制汤，找商人换 |
| ExtremeTempDrop | 天数越往后气温降得越多，降多少、从第几天开始都能调 |
| FPSBooster | 提高帧数 |
| FiligranisSkills | 加新技能（别的 mod 要用它，比如 AlcoholMod） |
| FoodPackByTKG | 加新食物 |
| FoodsByCalorieWaltz | 加新食物和做法 |
| Forager.s.Delight | 加能采集的植物和用它们做的东西 |
| IndoorCampfires | 室内也能生篝火 |
| IndoorsGreenery | 室内摆放的盆栽装饰 |
| InterloperHudPro | 屏幕上显示气温、风寒、体感温度、负重、移动速度、昼夜、手上物品耐久、冰面多久会裂 |
| InterloperRegionSelection | 入侵者难度开局可以自己选地区 |
| ItemScanner | 扫描身边的物品和容器，在屏幕上标出来 |
| LitharsRidge | 地图上多了一个新地点 Lithar's Ridge，有家具和舱口 |
| MapIconTracker | 地图上显示更多图标和标记 |
| MehToolBox | 前置库，别的 mod 要用，别删 |
| Minor_Miseries | 加一些小毛病，比如木刺、水泡、擦伤、小伤口、腰酸、落枕、做噩梦，每样都能单独关 |
| MiseryModePlus | 悲惨模式加强，随机出生点、伤病分阶段随机出现 |
| ModSettingsQuickNav | Mod Settings 里快速跳到某个 mod 的设置页 |
| MoreCameraSpawns | 相机在更多地方刷出来 |
| MoreWood | 多了桦木和橡木，各自的出现几率、燃烧温度和时长能调 |
| NorthernLightsBroadcast | 游戏里的电视能放自己电脑上的视频。鼠标中键对着电视开关 |
| PauseInJournal | 打开日志时游戏暂停 |
| PickWaterFromFishingHoles | 能从冰钓洞里打水 |
| PineNeedleTea | 能用松针泡茶 |
| PredatorSpawnSelector | 按地区调狼、熊、美洲狮刷多少，也能整类关掉 |
| PrepperCache | 地堡相关。F9 看地堡分布 |
| Ranger_Recipes | 加新菜谱 |
| RecipeRequirements | 改各道菜谱做的时候要哪些材料 |
| ResearchBookTweaker | 改研究书读完要多少小时、加多少技能 |
| RestandReadMod | 休息的时候也能看书 |
| ScaledFishMod | 鱼的大小按重量变，大鱼看着就大 |
| SeasonedInterloping | 选难度界面里加了入侵者相关的难度选项 |
| Shortcuts | 地图上加了一些近路，比如监狱大门、码头坡道、绳子、冰面，每条都能单独关 |
| SillyMod | 搞笑用的，能把人物放大缩小、开物理碰撞 |
| StalkerAidsAndSupplements | 加药品和补剂，维生素、助眠、咖啡因、果酱这些 |
| SurvivorsLegacy | 尸体旁边会有前一个幸存者留下的字条和物资 |
| TheLongDevelopment | 材质和画面改动 |
| ThrowPower | 石头、诱饵、信号棒、火把能扔得更远，石头扔出去有轨迹线 |
| TraderMoving | 把远疆 DLC 商人的无线电和交易箱搬到你想要的地方，可以跨场景搬 |
| WildFire | 火焰和火星的颜色、大小、持续时间能调 |
物品包是 .modcomponent 文件，加新物品、衣服、装饰、配方。
| 物品包 | 是什么 |
| ClothingPackByTKG、NorthfolkClothingPack、WolfskinScarf | 新衣服，WolfskinScarf 是狼皮围巾 |
| Collector.Cards | 能收集的卡片 |
| FishingLine | 钓鱼线 |
| HomeMadeBrewery | 自己酿酒 |
| ItemPiles | 物品成堆摆放 |
| Lich.s.Decorations.Plushie、Lich.s.Decorations.Stack | 装饰品，毛绒玩具和成堆的摆件 |
| Rare-ExclusiveLoot | 稀有物品 |
| SnowmensTales | 雪人 |
| StorymodeCollectibles | 剧情模式里的收集品放进沙盒 |
| Watches | 手表 |
| ZC8787 开头的七个 | 配方包，现金、衣服、做饭、急救、肉干和薯片、武器、商人的配方 |'''

start = s.index('### 终极版多出来的 mod\n') + len('### 终极版多出来的 mod\n')
end = s.index('\n', s.index('物品包（.modcomponent 文件', start))
s = s[:start] + TABLE + s[end:]

pairs = [
    ('当前网盘上是 TldHacks V12，', '当前网盘上是 TldHacks V12.1，'),
    ('| 时间加速 | 人物 & 操作的时间加速 | 两个热键各绑一个倍率，按住就加速 |',
     '| 时间加速 | 人物 & 操作的时间加速 | 两个热键各绑一个倍率（0.1 到 50），按住就生效，调到 1 以下就是变慢 |'),
]
for a, b in pairs:
    assert s.count(a) == 1, (a, s.count(a))
    s = s.replace(a, b)
n = s.count('v12')
s = s.replace('TldHacks-v12', 'TldHacks-v12.1')
open(p, 'wb').write((b'\xef\xbb\xbf' if bom else b'') + s.encode('utf-8'))
print('ok, v12 count before', n)
