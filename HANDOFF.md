# HANDOFF — TldHacks
> Last updated: 2026-06-04 03:31

## 当前目标
v7.0 已编译+打包:全模组审计修 bug + 火把还原原版 + 便利功能默认开 + 排查不生效功能

## 已完成(本轮)
- v7.0 验证3睡眠QoL默认开功能全链路OK:WakeUpCall(__4/__5位置参数)/ShowTimeSleep(SetTimeWidgetActive bool active 名匹配dump)/NoPitchBlack(Panel_Rest.Enable bool enable 名匹配)→ 均正常工作
- v7.0 **修"存档进不去需手删json"根因**:库JsonModSettings构造函数即eager-load+rethrow,旧SafeLoad跑太晚+用相对路径→对部分人无效。新增 PreflightSanitizeJson() 在构造前用绝对路径净化磁盘JSON
- v7.0 可维护性自检 DynamicPatch.SelfCheck():启动遍历所有Spec解析目标方法,游戏更新破坏签名时启动日志即报,零运行时开销;死bool toggle源码审计=0
- (前轮)火把还原90+BloodLossEnd __0+PlaceFromInv_StackDrop补回
- v7.0 重打包两 zip(完整版92.5MB/最小64.7MB):TldHacks.dll md5=ee54b577,integrity OK,DLL md5 match=True

## 下一步
- 用户验证 v7.0:旧玩家直接覆盖更新不再需手删 TldHacks.json 即可进存档;启动日志看 [DynPatch.SelfCheck] OK

## 未决问题
- 无(Safehouse DLL 用户已确认用实时文件夹版本覆盖,即便比 zip 旧)

## 关键文件
- TldHacks/src/ModMain.cs (PreflightSanitizeJson 构造前净化 + JsonConfigPath 绝对路径 + SelfCheck 调用)
- TldHacks/src/DynamicPatch.cs (SelfCheck + PatchSpec.TargetResolves)
- TldHacks/src/Settings.cs (TorchBurnMinutes=90 + 3个QoL默认true)
- TldHacks/src/Cheats.cs:1196 / IntegratedPatches5.cs:140+ (前轮修复)
- C:\Users\82077\Desktop\TLD\_workspace\repack_v70.py (打包脚本)
