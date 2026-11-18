# HANDOFF: TldHacks

> Last updated: 2026-11-19 01:30

## 当前目标
V12.9 已发版,等用户实测和群友反馈。

## 已完成(本轮)
1. V12.9 打包:最小包、完整版 4 卷、终极版 182 卷(终极版换了 TldHacks.dll、HomeMadeBrewery.modcomponent、Forager.s.Delight.dll、TldHacks_Transitions.txt),夸克和百度都核过(1 / 4 / 183 个,无重复)。V12.8 旧件挪进两边 OLD。夸克终极版第一次只传上 176 个,用 ul_fill.py 补齐
2. 内容:火把烧完自动换新、轮盘喝保温杯、保温杯火边加热、取暖器进轮盘(`src/QuickRadial.cs`,都默认关);丢地烹饪跨场景计时和烤焦(`src/DropCook.cs`);快速制作补满家具分段工时;一键恢复清 m_WornOut;终极版酿酒原料按个数、配饰负重上限 30 公斤
3. 腾讯文档整篇覆盖,读回 joined equal True(第一次读回链接为空,再读一致),剪贴板已还原
4. 群知识库 00/01/02/06/08/10、两个 28 和配置字段表已传 server,md5 一致;鲸鲸 rules.md 加第 17 条(V12.9)和第 18 条(没加载弹窗先查 version.dll 位置,优先改名 winhttp.dll),08 故障排查同样改成先改名

## 下一步
1. 用户实测 V12.9 新功能。取暖器加在营地轮盘最后一个空位,没空位时 Latest.log 有 `[QuickHeater] 营地轮盘没有空位`,那就改放工具轮盘
2. Nexus mod 162 还是 12.8,换主文件要先问用户(脚本 bili-game-pipeline/tools/nexus/update_file.py)

## 未决问题
1. 丢地烹饪计时只在内存,读档重来;烤焦时长用肉自带的 m_ReadyTimeMinutes,没乘锅的倍率和技能,快慢没验证
2. 启动偶发闪退(coreclr 0xc0000005,HarmonyInit 读补丁类特性,在 TldHacks 之后的 mod),继续观察
3. 剧情版编译报错在 `src/ItemPreview.cs`(Il2CppTLD.Gear 命名空间不存在),剧情包本轮没打
4. MoreBunkers 零散选装 zip 还是 v1.4 旧 dll(位置提示键 F10),没重打

## 关键文件
1. `src/QuickRadial.cs`、`src/DropCook.cs`
2. `../_tools/release/bump129.py`、`ult129_pack.py`、`kb129.py`、`bd_prep129.py`、`bd_check129.py`、`bd_up128.py`(不带版本号,直接复用)、`ul_fill.py`(补传缺的终极版分卷)
3. `../_work/release/tencent_doc/bump129_doc.py`、`doc.txt`
