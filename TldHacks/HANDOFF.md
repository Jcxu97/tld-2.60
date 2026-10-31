# HANDOFF: TldHacks

> Last updated: 2026-10-31 (V11)

## 当前目标
TldHacks V11(版本号不带小数点,v10.9 + 魔法子弹改读 BaseAiManager.m_BaseAis 不再每 0.5 秒扫全场景 c4b9737 + 沿海公路囤货地堡传送点挪到 883.94,152.39,968.58)已打包,传夸克 TLD V2.59 Hack 和百度 TLD HACK V2.59(最小包、完整版 4 分卷、终极版 64 分卷、选装 MoreBunkers v1.4 zip),两边核对一致;腾讯文档、群资料库、鲸鲸 rules.md 已改。MoreBunkers 1.4.0 舱口挪到 882.44,152.09,968.58,工作区的 2.59 适配改动现在能编,pack 默认 EXTRAS 带上它了(那几处改动仍未提交,不是我的)。终极版带回 ItemPicker.dll 和 ItemPickerCustomList.txt,不带 ItemPicker.json(用默认设置),仍不带 TldHacks.json 和 PerfFix。舱口新位置没在游戏里实测。

## 已完成(10-31 v10.6)
1. 勋章加成数值重进游戏就重置:16 个 `FeatV_*` 是 internal,TinyJSON 只存 public 或带 `[Include]` 的字段,所以从没写进 TldHacks.json。加了 `[Include]`(Diag 两个字段同理);ModMain 的预检清理、rescue、Newtonsoft 重写三处原来把非 public 键当孤儿删掉,改用 `PersistedSettingFields()` 统一判断
2. 勋章启用列表读档后丢:FeatsSandbox 在 SaveSceneData 后把启用列表写进 ModData(键 `featsEnabled`,格式 `v1:` + 逗号分隔 FeatType 名),LoadSceneData 和进场景时按存档槽恢复;DynamicPatch 加两条 Spec(只沙盒版)。旧档要先存一次才有备份
3. 打包:MoreBunkers 工作区有一半的改动(调 2.59 已删的 API,编译不过),这次用 `release.EXTRAS = {'scp': release.SCP}` 跳过它重编,包里 MoreBunkers.dll 还是 10.5 那份。三个 staging 的 MelonLoader Il2CppAssemblies、cpp2il_out、Config.cfg 已从 2.59 游戏同步
4. 终极版 release.py 不管:把新 TldHacks.dll 拷进 `staging\ultimate\Mods`,在 staging\ultimate 里对全部条目 `bz c -fmt:7z -l:9 -p:<_tools/release/release.py 第 15 行的 PW>`(包根目录无顶层文件夹),切 20MB 分卷进 `Desktop\TLD\V10.6终极版_我自己在用的全部mods\`,解压比对 + 分卷拼回比 MD5;旧 V10.5 文件夹挪 `OLD\v10.5`
5. 上传:夸克 `release.py upload sb ul` 同时起三个 browser-harness,第三个(ul)没连上,标签页根本没开,核对一直卡在 65 个缺;停掉后单独 `upload ul` 传完。百度先挪旧文件(v10.3 的 70 个进 OLD 下 10-31 新建的 `替换下来的` 文件夹)、三个文件夹改名 v10.6,再按 sb、ul 两次跑 baidu_upload.py。两边都按大小核对一致(5 + 65)

## 已完成(10-31 v10.7:跨场景传送回档)
1. 原因(反汇编 2.59 GameAssembly 确认):原版 `GameManager.LoadScene` 里只有 `AllowedToSave(SaveState.InMemory)` 通过才 `SaveGame("autosave", 场景存档名)` + `ConfigureRestoreFromSlot("autosave")`;不通过(玩家在移动/下落、控制模式不对等)两件都不做,`m_SlotToLoadOnStart` 为空,新场景不走 `LoadSlotOnStart → RestoreGame`,玩家/全局状态是旧数据 → 回档。偶发,和传送时状态有关
2. 第二个参数也传错了:原版 `Action_LoadScene` 传 `m_SceneTransitionData.m_SceneSaveFilenameCurrent`,我们(照抄 FastTravel)传 `GetCurrentSaveName()` = 存档槽名(sandbox4),场景数据和我们的 SaveSceneData 补丁都存到错 key。v9.7 只改了手动存档的场景名,两处都没碰
3. 改法(`CheatsExtra.TravelTo`):先算 curSave(transition 数据 → TransitionRecorder → 场景名)并建好 SceneTransitionData;`AllowedToSave(InMemory)` 通过就交给原版 LoadScene 存(不再存两遍),不通过就自己 `SaveGame(autosave, curSave)` + `ConfigureRestoreFromSlot(autosave)`;LoadScene 第二参数改成 curSave。全走反射,剧情版两个工程也编过
4. 发版 v10.7(先打了一半 10.6.1,用户改主意要 10.7):ModMain VERSION、两个 staging 使用说明.txt(完整版加了【v10.7 有哪些变化】一节)改版本号;`pack(['sb'])` 同样带 `EXTRAS={'scp':SCP}`;终极版照 v10.6 手工流程(64 分卷),旧 V10.6 终极版文件夹挪 `OLD\v10.6`
5. 坑:pack 中途被停,sb_full 会留在 `staging\_named\<完整版名>` 下,下次 pack 找不到 sb_full。要挪回 `staging\sb_full` 并删掉空的 `_named`
6. 上传:夸克 sb、ul 分开跑。ul 头两次报 browser-harness `Runtime.evaluate timed out ... waiting for the daemon`(同时有另一个会话在用浏览器),第三次正常,中途没传完的旧文件已被挪进 OLD,不影响。百度先 goto pan.baidu.com 再拿 token(不然 fetch 相对路径报 Failed to parse URL),v10.6 的 70 个文件挪进 OLD 下新的 `替换下来的` 文件夹,三个文件夹改名 v10.7,再分 sb、ul 两次跑 baidu_upload.py。两边都 5 + 65 按大小核对一致

## 已完成(10-31 v10.8:搬运猎物按钮)
1. 玩家反馈:搬运按钮点了没反应、过一会和采集按钮重叠、切到拆块 tab 拆不了
2. 原因:prefab 里 Mouse_Button_Harvest 和 Mouse_Button_Quarter 是同一父节点下的兄弟、同一坐标 (329,-242);原版 `Panel_BodyHarvest.Refresh`(反汇编 0x9b9b20)每帧按 tab 对两个按钮 SetActive。我们的克隆按钮是兄弟节点(原 mod 是挂在采集按钮下面),切到拆块 tab 不会被隐藏,碰撞框正好盖住拆块按钮。另外用 `_harvestBtnShifted` 加 `+=` 做相对偏移,关面板没走 4 参 Enable(false) 或者面板被重建时就会漂,搬运按钮最终和采集按钮重叠,点到的是采集按钮
3. 改法(`IntegratedPatches4.cs` CarcassMovingState):按采集按钮的 InstanceID 记住原点,采集按钮放到原点 -100、搬运按钮放到原点 +100,都是绝对坐标;新增 `Panel_BodyHarvest.Refresh` Postfix(`Patch_Carcass_PanelRefresh`,只在 World_CarcassMoving 开着时挂上),每帧在原版之后同步:只在采集 tab 且没在采集/拆块时显示,并强制 UIButton.isEnabled 和 Collider 开着。克隆出来的 3 个 UIButton 的 onClick 全部清空;父节点变了就重建。三个工程都编过,已部署到游戏 Mods,**还没进游戏实测**

## 已完成(10-31 v10.9:恢复火堆 + 三个 bug,commit 72ae881)
1. Shift+Q 整堆丢弃对部分物品只丢一个:反汇编 2.59 `Panel_Inventory.OnDrop`,原版只在 `m_StackableItem.m_Units > 4` 时才弹 Panel_PickUnits,我们的整堆逻辑挂在 PickUnits 上,2~4 个的小堆不弹框就只丢一个。`QoLHotkeys.cs` Patch_QoL_Inventory_DropKey:按住整堆键且 1 < units ≤ 4 时逐个调 `OnDrop()`(选中物变了或 PickUnits 弹出就停),原版会把连续丢的合成一堆。丢弃路径全都走 `GearItem.Drop`,AutoPickupGuard 没漏,没改
2. 技能"工具修理"加不上(日志 `skill ToolRepair not found`):2.59 的 SkillsManager 已删掉 ToolRepair(枚举还在,GetSkill 返回 null)。`CheatsExtra.cs` Skills.All 里 ToolRepair 只留剧情版。**坑**:2.59 里 Shotgun 的 enum、Skill_Shotgun 类、`m_Skill_Shotgun_Prefab` 字段都有,我第一版据此加了"霰弹枪",用户一点就是 `skill Shotgun not found`(GEAR_Shotgun 也加载不到,是没上线的代码)。已删(commit 2261aad)。判断技能/物品在不在要看运行时日志,不能只看反编译出来的类型
3. 传送点 y 太高摔死:`TeleportFallGuard` 原来按 180 帧算,高帧率下 1 秒多就过期,人还在半空。改成真实时间 8 秒。`Teleport.MovePlayerTo` 加 `SnapToGround`:从目标点上方 1.2m 往下 RaycastAll 200m(忽略 trigger 和玩家自己的碰撞体),取最高的命中面(楼里就是脚下楼板),按 CharacterController 算出的脚底偏移放上去 +0.1m;打不到就用原坐标,日志 `[TP] TeleportPlayer(...) 原 y=...`。同场景、跨场景、地图点击传送都走这里
4. 发版:ModMain VERSION 10.9,完整版使用说明加【v10.9 有哪些变化】,终极版说明只改版本号。打包时游戏开着,pack 时把 `game_running`/`deploy` 换掉、build 加 `-p:NoDeploy=true`,打包和三种验证照常。终极版照手工流程 64 分卷,旧 V10.8 挪 `OLD\v10.8`
5. 上传:百度先挪 70 个旧文件进 OLD 下 `1031-1331 替换下来的`、三个文件夹改 v10.9;夸克 sb、ul 分开跑,百度 sb、ul 分开跑。两边都 1 + 4 + 65 按大小核对一致,列过没有多余或带 (1) 的重复件
6. 同日删掉霰弹枪行后原名 v10.9 重打重传(DLL 38251d07,游戏 Mods 里也是这个):夸克 upload 自动把旧的挪 OLD,核过文件时间都是重打之后;百度手动把 70 个挪进 OLD 下 `<MMDD-HHMM> 替换下来的(v10.9带霰弹枪行)` 再传。两边 1 + 4 + 65 一致,无重复件
6. 三个修复和恢复火堆**都没在游戏里实测**

## 已完成(10-31,恢复火堆,随 v10.9 发)
1. 新功能"恢复火堆"(一次性操作区,`Cheats.RestoreLives`,剧情版 2.24 没有这套系统,用 `#if !STORY_EDITION` 排除)
2. 原理(反汇编 2.59 确认):死后余生的火堆数 = `LifeAfterDeathManager.TotalLives`(= `m_Tunables.m_AvailableLives`,一般是 3)- `LivesUsed`;`LivesUsed` 只有 getter,读的是 `m_LifeAfterDeathState.m_LivesUsed`,这个 state 由 Serialize 存进存档。所以把 `m_LivesUsed` 置 0 即恢复满,存档后保留。`IsSystemEnabled`(= state.m_SystemEnabled && AvailableLives > 0)为假的模式直接提示没有火堆机制
3. 编译过;当时游戏开着,DLL 没能部署到 Mods,**未实测**

## 已完成(10-29 v10.3)
1. 物品生成器删掉 29 种原版食谱未烹饪半成品(`GEAR_Uncooked*`,刷出来用不了,显示名又和熟的一样)
2. 免甜点疼真正生效:`CausesHeadacheDebuff.Apply` 前缀跳过(以前只有开关没有补丁)
3. 物品 & 传送页:传送列表进内层滚动区,和物品生成器中间加可拖分割栏,高度存 `SpawnerTeleportH`
4. 开修改器时自动开 ESC 暂停菜单(`MenuPauseGame`,默认开),关修改器时只关自己开的那个
5. release.py 改成按 fid 传夸克三个编号文件夹(min / full / ul),换版自动改文件夹名;bh_quark.py 加 rename

## 下一步
0. v10.9 等实测:Shift+Q 丢 2~4 个的小堆、恢复火堆、传送到原来会摔死的点(看日志 `原 y=` 改了多少)
1. v10.6 两个勋章修复等用户实测:改加成数值重启游戏还在;启用几个勋章、存档、回主菜单再读档还在
2. v10.7 传送回档修复等玩家反馈(飞行/下落中传送、跑动中传送、进 MoreBunkers 地堡),有问题看日志 `[TP.Save]`
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
