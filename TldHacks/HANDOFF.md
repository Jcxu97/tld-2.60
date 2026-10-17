# HANDOFF: TldHacks

> Last updated: 2026-10-17 10:30

## 当前目标
发 v9.9(剧情版 V1.7、第五章版 V1.4):无后坐力真正压住开枪镜头上跳,加上菜单三处配色。改动还没提交。

## 已完成(本轮)
1. 无后坐力只看无后坐力开关和后坐力强度滑条,不再被超级精准顶掉
2. 开枪镜头上跳的来源是开枪动画甩镜头骨骼,`PlayerCameraAnim.UpdateMainCamera` 每帧把骨骼转角和位移加到镜头上。新补丁 `Patch_CameraAnim_NoRecoil` 在它读骨骼前压掉偏移、读完还原,实测猎枪和巴布的步枪开枪镜头不动
3. 拿油灯切枪右键瞄不了是强力投掷(ThrowPower,不是我们的 mod)的"禁用投掷冷却"吞了装备完成事件;关掉后重启实测正常
4. 临时日志全部删除,版本号改 9.9,五份说明文件加了更新内容
5. 打包并上传夸克完成(9 个文件大小一致),旧版挪进网盘 OLD

## 下一步
1. 用户点头后提交(菜单配色、MapClear/TalesComplete 的 IsArmed、无后坐力、版本号)

## 未决问题
1. 一键清图漏收 mod 物品:按代码没排除 mod 物品,用户还没给出具体哪件
2. 读档卡死的根因仍没找到(9.8 只做了卡一次后自动进安全模式)
3. Nexus 页面 Virus scan 显示 Some suspicious files
4. 回退用 `_work/release/staging/sb_min/Mods/TldHacks.dll` 的上一版(打包后已被覆盖,要回退从 git 9.8.1 重编)

## 关键文件
1. `src/CheatsPatches.cs`:无后坐力、镜头骨骼补丁、超级精准
2. `src/DynamicPatch.cs`:补丁挂载条件
3. `src/MapClear.cs`:一键清图
4. `src/Menu.cs`、`src/MenuUi.cs`:菜单配色和样式
5. `../_tools/release/release.py`:编译、部署、打包和夸克上传
6. 说明文件:`_work/release/staging` 下三份,桌面 `TLD\解压说明.txt` 和剧情两份
7. 反汇编脚本 `%TEMP%\aim\gadis.py`、`rc5.py`(查 icall 名)、`rc10.py`(按类名标字段)
