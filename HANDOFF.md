# HANDOFF — tld--2.55

> Last updated: 2026-11-08 01:30

## 当前目标

TldHacks V12.6 已发到夸克和百度,等群友反馈。

## 已完成(本轮)

- 新 mod BlueprintIconFix:制造列表里配方没图标时,用结果物品的背包图标补上。进完整版和终极版,release.py EXTRAS 里叫 bif
- TldHacks V12.6:物品生成器里 GEAR_FishingLine 名字后加(游戏废案);咖啡罐、茶包这类多份物品能堆叠(Stacking.cs,没进游戏测过)
- 终极版加了 HutDoorTorch(dll 和用户调过的 json),完整版和最小包不带
- 夸克根目录 OLD 换成新文件夹 fid 7c837ffc…,发版脚本都改了;夸克、百度三个包按文件夹核对一致;腾讯文档整篇覆盖并读回一致
- 群机器人资料库 00 01 06 07 10 24 同步到 server,rules.md 加第 28 条

## 下一步

- 有人开制造界面后看 Latest.log 有没有 `补图标` 行,确认 BlueprintIconFix 生效
- 咖啡罐堆叠改动没测过,群里报堆叠问题先看 Stacking.cs 的 Dedupe 和 LabelFix.RestoreUnits

## 未决问题

- 百度的 OLD 文件夹还是旧名字,夸克那边用户换成了 `OLD`,要不要统一没问过

## 关键文件

- BlueprintIconFix/src/BlueprintIconFix.cs — 补图标的 patch
- TldHacks/src/Menu.cs — ResolveDisplayNames 里给废案鱼线加后缀
- TldHacks/src/Stacking.cs — 多份物品的堆叠判断
- _tools/release/release.py — pack 和 upload,EXTRAS、NET_OLD
- _tools/release/ult126.py、ult126_pack.py、bd_prep126.py、bd_up126.py、kb126.py — 这一版的终极版、百度、资料库脚本
- _work/release/tencent_doc/ — 腾讯文档源稿和粘贴、读回、比对脚本
- TldHacks/HANDOFF.md — TldHacks 明细
