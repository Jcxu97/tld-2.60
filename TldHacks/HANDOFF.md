# HANDOFF: TldHacks

> Last updated: 2026-10-31

## 当前目标
TldHacks v10.6 打包完成,上传夸克 TLD V2.59 Hack 和百度 TLD HACK V2.59(最小包、完整版 4 分卷、终极版 64 分卷)。腾讯文档和群资料库这次用户自己改,我没动。

## 已完成(10-31 v10.6)
1. 勋章加成数值重进游戏就重置:16 个 `FeatV_*` 是 internal,TinyJSON 只存 public 或带 `[Include]` 的字段,所以从没写进 TldHacks.json。加了 `[Include]`(Diag 两个字段同理);ModMain 的预检清理、rescue、Newtonsoft 重写三处原来把非 public 键当孤儿删掉,改用 `PersistedSettingFields()` 统一判断
2. 勋章启用列表读档后丢:FeatsSandbox 在 SaveSceneData 后把启用列表写进 ModData(键 `featsEnabled`,格式 `v1:` + 逗号分隔 FeatType 名),LoadSceneData 和进场景时按存档槽恢复;DynamicPatch 加两条 Spec(只沙盒版)。旧档要先存一次才有备份
3. 打包:MoreBunkers 工作区有一半的改动(调 2.59 已删的 API,编译不过),这次用 `release.EXTRAS = {'scp': release.SCP}` 跳过它重编,包里 MoreBunkers.dll 还是 10.5 那份。三个 staging 的 MelonLoader Il2CppAssemblies、cpp2il_out、Config.cfg 已从 2.59 游戏同步
4. 终极版 release.py 不管:把新 TldHacks.dll 拷进 `staging\ultimate\Mods`,在 staging\ultimate 里对全部条目 `bz c -fmt:7z -l:9 -p:tld2026`(包根目录无顶层文件夹),切 20MB 分卷进 `Desktop\TLD\V10.6终极版_我自己在用的全部mods\`,解压比对 + 分卷拼回比 MD5;旧 V10.5 文件夹挪 `OLD\v10.5`

## 已完成(10-29 v10.3)
1. 物品生成器删掉 29 种原版食谱未烹饪半成品(`GEAR_Uncooked*`,刷出来用不了,显示名又和熟的一样)
2. 免甜点疼真正生效:`CausesHeadacheDebuff.Apply` 前缀跳过(以前只有开关没有补丁)
3. 物品 & 传送页:传送列表进内层滚动区,和物品生成器中间加可拖分割栏,高度存 `SpawnerTeleportH`
4. 开修改器时自动开 ESC 暂停菜单(`MenuPauseGame`,默认开),关修改器时只关自己开的那个
5. release.py 改成按 fid 传夸克三个编号文件夹(min / full / ul),换版自动改文件夹名;bh_quark.py 加 rename

## 下一步
1. v10.6 两个勋章修复等用户实测:改加成数值重启游戏还在;启用几个勋章、存档、回主菜单再读档还在
2. MoreBunkers 工作区改动没做完(m_Guid、LoadGearItemPrefab、InstantiateItemAtLocation 参数类型),修好前 `release.py pack sb` 会编译失败,要么修完要么照上面跳过
3. 火车加注加不进去,还在等用户日志
2. 百度分享链接拿到后补进腾讯文档和资料库(现在两边都没写百度链接)
3. 不捡丢物改成按 ObjectGuid 存进 ModData(键 ownDrops),等用户实测:摆火把、存档重进、一键搜刮不收;改前放的要重摆一次
3. 不捡丢物改成按 ObjectGuid 存进 ModData(键 ownDrops),等用户实测:摆火把、存档重进、一键搜刮不收;改前放的要重摆一次

## 未决问题
1. 钢锯和重锤新档不刷:10-30 拆场景包定了是原版设计。入侵者和悲惨藏常规点,入侵者专用那组按开局抽的研究方案刷(林狼雪岭钢锯 1/2/4 号,重锤 1/3/4 号),抽错方案整图没有;不用修
2. 修改器窗口盖在暂停菜单上,点按钮会不会点穿到后面的暂停菜单按钮,还没收到反馈
3. 剧情模式两个包的 MelonLoader 可能还是更新前的程序集,没查

## 关键文件
1. `src/Menu.cs`(暂停菜单、分割栏)、`src/CheatsPatches.cs`(免甜点疼)、`src/ItemDatabase.cs`
2. `src/Settings.cs`、`src/ModSettingsEnData.cs`、`src/MenuUi.cs`(说明文字)
3. `../_tools/release/release.py`(`net_folders`、`ul_dir`)、`bh_quark.py`、`bh_baidu.py`、`baidu_upload.py`
4. `../_work/release/staging/sb_full/使用说明.txt`、`staging/ultimate/使用说明.txt`
