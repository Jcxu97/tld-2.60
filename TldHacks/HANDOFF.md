# HANDOFF: TldHacks

> Last updated: 2026-10-17 04:20

## 当前目标
v9.8.1 已发布(夸克三种包 + Nexus),修好 9.8 进不去游戏的问题。

## 已完成(本轮)
- 根因:9.8 的 `ModSettingsEn.GetAttributesPostfix` 在 OnInitializeMelon 里就读 `Localization.Language`,早于 `GameManager.Awake` 设 bundle 根路径,游戏用空路径加载 `ui/localization` 失败,语言表为空,进不去。剧情两版(10-10 发布)也带这个 bug
- 修:删掉那次提前读取和 `MarkGameReady`;用户实机进游戏,`Localization.Get` 报错从 99 条变 0 条
- 版本号拼接改成 `VERSION + ".0"`,三段版本号(9.8.1)才能编译;csproj `<Version>` 跟到 9.8.1
- Nexus mod 119:主文件换成 TldHacks 9.8.1 (DLL only),介绍重写(补整合 mod 清单、新功能;删掉无效的 DiagPauseRuntime 排错建议)
- 夸克:sb 最小包 + 9.8.1 完整版 4 卷、剧情 1~4 章 V1.6、第五章 V1.3 重传

## 下一步
- 等玩家反馈 9.8.1 和剧情包能否正常进游戏

## 未决问题
- 读档卡死的根因仍没找到(9.8 只做了卡一次后自动进安全模式)
- Nexus 页面 Virus scan 显示 Some suspicious files

## 关键文件
- `src/ModSettingsEn.cs`:Mod Settings 面板英文化,启动阶段禁止读 `Localization.Language`
- `src/I18n.cs`:语言判断,`GameReady` 之前只看 PlayerPrefs 和 Windows 界面语言
- `src/ModMain.cs`:版本号、配置加载、崩溃哨兵
- `../_tools/release/release.py`:打包和夸克上传
