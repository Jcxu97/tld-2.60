# HANDOFF: TldHacks

> Last updated: 2026-11-14 19:50

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
