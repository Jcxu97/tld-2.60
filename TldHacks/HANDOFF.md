# HANDOFF: TldHacks

> Last updated: 2026-11-18 11:40

## 当前目标
V12.8 已发版,等用户实测和群友反馈。

## 已完成(本轮)
1. V12.8 打包:最小包、完整版 4 卷、终极版 182 卷,夸克和百度都核过(1 / 4 / 183 个,无重复)。V12.7 旧件挪进两边 OLD
2. 内容:丢地烹饪、植物长回来地图图标恢复、鲸油取暖器和油罐单独成块放第三列、RarityRework 1.2.0(词条加强,神话 x2,显示原值和新值)
3. 腾讯文档整篇覆盖,读回 joined equal True;群知识库 00/01/06/07/10 和配置字段表已传 server,md5 一致;鲸鲸 rules.md 加第 15 条
4. MoreBunkers 10-31 的改动 V12.7 就已带上,本轮只补提交源码
5. Nexus mod 162 主文件换成 12.8(旧文件进 File archive),脚本 bili-game-pipeline/tools/nexus/update_file.py

## 下一步
1. 用户实测 RarityRework 1.2.0:物品说明里的 → 箭头能不能显示,神话词条数值
2. 11-16 未发版,用户定跟下次更新一起发,已部署本机没进游戏测:快速制作补满工作台家具的分段工时(CheatsPatches.cs FillRemainingHours,Latest.log 有 `[QuickCraft] ... 工时` 行);无限耐久和一键恢复顺手清 m_WornOut(Cheats.cs RestoreDurability),修 0% 后拉回 100% 仍显示腐坏红叉
3. 11-17 未发版,下次只进终极版,已换进游戏 Mods 没进游戏测:HomeMadeBrewery.modcomponent 五种酒的原料从按公斤改成按个数(玫瑰果、桦树皮、灵芝各 10,牛蒡 7,香蒲茎 20,总重不变),两对同名配方改名 BBMB / BRHWB;Forager.s.Delight.dll 配饰四个滑条上限改 30 公斤(直接改特性字节)。原版在 %TEMP%\hmb_backup_20261117、fd_backup_20261117。发版时知识库 28 两节和版本历史要补
4. 11-18 未发版,用户定跟下个版本一起发(发版时腾讯文档、群知识库、版本历史补这四个开关),已部署本机没进游戏测,四个新开关默认关(`src/QuickRadial.cs`):火把烧完自动换新(火把卡)、轮盘喝保温杯和保温杯火边加热(保温杯卡)、取暖器进轮盘(取暖器卡,和不耗油并一行)。取暖器加在营地轮盘最后一个空位,没空位时 Latest.log 有 `[QuickHeater] 营地轮盘没有空位`。同批还有丢地烹饪改动(`src/DropCook.cs`):计时按场景加物品名加位置记,离开场景回来不丢、火燃着时把离开时间算进去;熟了再放超过 Cookable.m_ReadyTimeMinutes 就耐久归 0 算烤焦(日志 `[DropCook] ... 烤焦`)。计时只在内存,读档重来

## 未决问题
1. 丢地烹饪没验证存档重进后熟肉是否保留
2. 启动偶发闪退(coreclr 0xc0000005,HarmonyInit 读补丁类特性,在 TldHacks 之后的 mod),继续观察
3. 剧情版编译报错在 `src/ItemPreview.cs`(Il2CppTLD.Gear 命名空间不存在),剧情包本轮没打
4. MoreBunkers 零散选装 zip 还是 v1.4 旧 dll(位置提示键 F10),没重打

## 关键文件
1. `src/DropCook.cs`、`src/MenuTweaks.Cards.cs`(CardHeaterOil)
2. `../_tools/release/bump128.py`、`ult128.py`、`ult128_pack.py`、`kb128.py`、`bd_prep128.py`、`bd_up128.py`、`bd_check128.py`(下版复制成 129)
3. `../_work/release/tencent_doc/bump128_doc.py`、`doc.txt`
4. `../RarityRework/RarityRework.Affixes/AffixCatalog.cs`(Boost 倍率、LowerCap)
