# HANDOFF: TldHacks

> Last updated: 2026-11-14 19:00

## 当前目标
下一版(V12.8)发丢地烹饪新功能。

## 已完成(本轮)
1. 丢地烹饪(02c8dee,`src/DropCook.cs`):主页快速操作栏新开关,默认关。生肉生鱼丢在燃着的火堆或炉子 2 米内,按原版烹饪时长计游戏时间,到点原地换成热熟肉,不烤焦。关着不挂 patch
2. 用户 11-13 实测说 good,要下版本发
3. 腾讯文档源 `_work/release/tencent_doc/doc.txt` 按功能找表已加一行"烤肉不用守着",还没贴到线上

## 下一步
1. 用户说打包上传时按 `bili-game-pipeline/docs/07-mod-release.md` 发 V12.8,四处版本号一起 bump
2. 腾讯文档:tq_verify + compare 确认线上没手改,build.py,FORCE=1 tq_paste.py,再回读比对
3. 核对夸克和百度 V12.7 终极版 182 卷是否传齐(上轮遗留)

## 未决问题
1. 丢地烹饪没验证存档重进后熟肉是否保留,发版前用户若没测过要提一句
2. 启动偶发闪退(coreclr 0xc0000005,HarmonyInit 读补丁类特性,在 TldHacks 之后的 mod),继续观察
3. 用户 11-13 定了 MoreBunkers(10-31)和鲸油取暖器卡片挪第三列(11-09)都进 V12.8,打包前提交。RarityRework 1.2.0(11-14,词条加强和显示改版,已部署本机,用户未实测)也随 V12.8 完整版发。PerfProbe 是自用测帧工具,不进任何包
4. 剧情版编译报错在 `src/ItemPreview.cs`(Il2CppTLD.Gear 命名空间不存在),不是丢地烹饪引起的

## 关键文件
1. `src/DropCook.cs`(丢地烹饪)、`src/Menu.cs` 快速操作栏
2. `../_tools/release/bump127.py`、`ult127.py`、`ult127_pack.py`、`kb127.py`、`bd_prep127.py`、`bd_up127.py`(下版复制成 128)
3. `../_work/release/tencent_doc/doc.txt`、`bump127_doc.py`
