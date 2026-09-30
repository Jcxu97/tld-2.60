# HANDOFF — tld--2.55

> Last updated: 2026-10-01 00:20

## 当前目标

TldHacks v9.5 和剧情版 V1.3 已发版并部署。每次改完都要部署到游戏,再重打桌面 `TLD\` 下的最小包和完整版。细节见 `TldHacks/HANDOFF.md`。

## 已完成（本轮）

- 商人、室内灯光、QoL 总开关、版本号 9.5,见 `TldHacks/HANDOFF.md`
- 逐件确认跳过树枝和石块;Mod Settings 删掉一键关闭全部,名字和游戏内菜单对齐
- 两版都已部署(沙盒 d258d36f,剧情 bb3ae457),桌面三类包都重打过
- 知识库同步到 v9.5 / V1.3
- 代码提交在分支 `tldhacks-v9.5`

## 下一步

- 用户进游戏看 Mod Settings 名字和逐件确认

## 未决问题

- 见 `TldHacks/HANDOFF.md`

## 关键文件

- TldHacks/HANDOFF.md — 本轮改动明细和未决问题
- TldHacks/src/Settings.cs — Mod Settings 字段和名字
- TldHacks/src/GrabAll.cs — 一键搜刮
- TldHacks/src/CheatsPatches.cs — 商人补丁
