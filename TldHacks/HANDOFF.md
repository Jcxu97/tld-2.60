# HANDOFF: TldHacks

> Last updated: 2026-10-12 21:40

## 当前目标
v9.8 已发布(夸克 + Nexus),等玩家反馈读档卡死是否还有。

## 已完成(本轮)
- 新功能"完成DLC任务"和"任务奖励"(`src/TalesComplete.cs`),用户实测三个外域传说都能做完;调研结论在 `_work/tales/README.md`
- 读档卡死的自动恢复补了两个漏洞(`src/ModMain.cs` 哨兵逻辑):卡在载入画面时帧照跑,以前 180 帧就清记号,现在载入画面不计数、要 600 帧;卡住后点叉关游戏以前会清记号,现在进过游戏场景但没稳定就不清
- `_tools/release/release.py` 的子进程加 CREATE_NO_WINDOW,打包上传不再弹黑窗
- 夸克:v9.8 最小包 + 完整版 4 卷已传,大小核对一致,v9.7 移进 OLD
- Nexus mod 119:主文件换成 TldHacks 9.8 (DLL only),旧文件归档,mod 版本 9.8

## 下一步
- 等卡死玩家的 `MelonLoader\Latest.log`,确认是哪一步卡、删的是哪个 json(完整包里还带了十几个别的 mod 的 json)
- 用户同意后 commit(10-07 起的改动都还没提交)

## 未决问题
- 卡死本身的根因没找到,这次只保证卡一次后下次启动能自动进安全模式
- Nexus 页面 Virus scan 显示 Some suspicious files,9.8 文件扫描结果待看

## 关键文件
- `src/TalesComplete.cs`:任务步骤表、调度、塔和地堡、SceneFix、奖励清单
- `src/ModMain.cs`:配置加载、崩溃哨兵、Tick 接入
- `../_tools/release/release.py`:打包和夸克上传
