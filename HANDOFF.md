# HANDOFF — tld--2.55

> Last updated: 2026-10-04 10:00

## 当前目标

TldHacks v9.7、剧情第 5 章 V1.2、1~4 章 V1.5、MoreBunkers v1.1 发版,等用户进游戏测。

## 已完成(本轮)

- MoreBunkers 数量按"朝圣者下一个人过半年"重算,架子也算进总量:`design/totals.py` 对目标(囤货 450000 千卡、300 升水、300 柴),热量单位数从 `design/gear_stats.json` 读;`check.py` 和 `totals.py` 都是 problems: 0。难度比例 朝圣者 1、旅行者 1/2、潜行者 1/3、入侵者 0.65/3、厄难 0.25/3
- 能叠的一件一件摆(Stock.IsBundled 只有箭、火绒、树枝、弹壳、信号弹壳十根一捆),一件里的单位数取预制件默认值(Stock.Pack)
- 签名(Layouts.Sig)只算摆件不算数量,前缀 v2|;1.0 存档进地堡走 Stock.FromV1,按序号把 station / handed / moved / boxes 改名,不重摆(三个地堡 1.0 和现在摆件顺序核过一致)
- 出舱口挪位改成看 Bunkers.LeftAt(门钩子记时间),不看出生点名字:日志证明正常出舱口时户外已经清空,TldHacks 传送反倒带着舱口名字
- 回主菜单清 JustEntered;进原版地堡、改设置(OnSettingsChanged)、剧情模式都处理了;ModData 存失败报一次,读坏了另存 `_broken`

## 下一步

- 用户新档和 1.0 老档各进一次地堡,看日志 `[MoreBunkers]`:`stocked`、`kept the 1.0 layout as it is`、`cleared N loose items (kept M)`(M 很大说明刷出来的东西也带了玩家标记,重摆会重复)、`went in`(箱子装不下)
- 从地堡正常走出去应被挪到门口;在地堡里用 TldHacks 传送到同一张图别的点,不应被拉回门口

## 未决问题

- 游戏里没有军用兴奋剂和霰弹枪,雇佣兵地堡用强心针代替
- 同一存档不回主菜单直接读档时,ModData 不重读,摆没摆过的记录可能和场景对不上

## 关键文件

- MoreBunkers/design/layouts.py — 三个地堡的布置和数量(唯一来源),改完跑 check.py、totals.py、design.py
- MoreBunkers/src/Stock.cs — 摆家具、排物品、装箱子、1.0 迁移
- MoreBunkers/src/Bunkers.cs — 地堡定义、舱口、出口挪位
- MoreBunkers/src/ModMain.cs — 场景切换时的状态
- _work/release/morebunkers/ — MoreBunkers 包的说明和 Mods(打包手动,见 memory 发版流程)
- TldHacks/HANDOFF.md — TldHacks 明细
