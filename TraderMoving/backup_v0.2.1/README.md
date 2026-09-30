# TraderMoving

搬运交易者无线电和交易箱。The Long Dark 2.55 + MelonLoader。

**前置:SafehouseCustomizationPlus**(用它的背包收纳体系)。没装也能跑,会降级成抱着走。

## 做什么

把无线电收进背包带到别处放下,放下后仍能召唤商人、正常交易。交易箱同样可以搬(默认关闭,原因见下)。

## 操作

对着无线电按 `Y`(可改)选中,再点**右键**收进背包。放出来和放壁炉一样,从背包里选、进摆放模式。

选中状态 8 秒无操作自动解除,视线移开也解除。

装修模式下不接右键(那时右键归 SCPlus 的拆解功能),直接拖动物件即可。

降级模式(SCPlus 不在场时)是抱着走:按 `Y` 选中、右键抱起,再按 `Y` 或右键放下。抱着时不能冲刺、不能装备物品,体力和热量按重量多耗,攀绳自动放下。

## 为什么单独做一个 mod

`SafehouseCustomizationPlus` 能搬壁炉炉子,但搬不了无线电。它其实已经写了一半:有 `CarryableType.TraderRadio` 枚举、有注册表条目、甚至有个 `ReconstructTraderRadio()` 函数,但条目上写死 `pickupable = false`。

原因是硬的。SCPlus 的搬运架构靠从资源路径重建物体,而游戏没把"带交互逻辑的无线电"发布成可加载资源:

| 资源 | 主 catalog | DLC01.json |
|---|---|---|
| 带交互的无线电 prefab | 无 | 无 |
| `Survival_TraderRadio.prefab`(纯美术) | 无 | 有 |
| 带交互的交易箱 prefab | 无 | 无 |

它们只作为实例埋在 `*_DLC01` 场景里。SCPlus 那个重建函数只 instantiate 美术模型加个碰撞盒,不带 `TraderRadio` 组件,呼不出商人 —— 所以作者干脆禁用了。

本 mod 的做法是**不重建,搬原版实例本身**。可行的依据:

1. `TraderRadio` 和 `ExchangeBox` 自身没有存档(两个类都没有 `Serialize`/`Deserialize`)
2. 所有交易进度在 `TraderManager`,这是挂在 `GameManager` 上的全局单例,不随场景走
3. 全量反编译里引用 `TraderRadio` 的只有 `Panel_TradeSelection`,而且是无线电主动把自己推过去的。没有任何代码按场景校验无线电位置

换句话说,无线电只是个电话机,商人不在里面。

## 怎么在不改 SCPlus 的前提下用它的背包

关键手法是**分时段翻转 `pickupable` 标记**(`ScPlusBridge.cs`):

- 平时保持 `false` → SCPlus 走"原地移动原件"分支,**不会尝试重建**
- 只在你按右键确认的那一瞬间改成 `true`,让它的 `OnPickup` 放行
- 收完立刻在 `finally` 里还原成 `false`

这样借到它的背包 UI、图标、重量、摆放手感,躲开它那条会把电台变空壳的重建路径。位置和"在不在背包里"由本 mod 自己的 ModData 记,不动它的存档。

全程反射,不编译期依赖 SCPlus。带版本守卫(它的 `Utility.modVersion` 是 `const string`,读它不触发静态构造),任何一步失败就降级为抱着走并在日志里说明原因,不崩、不静默坏掉。

## 已知限制和风险

### 交易进行中不能搬(默认拦截)

**这条最重要。** 玩家提交进交易箱的实物被序列化进全局存档,取回必须靠 `ActiveTradeState.m_ExchangeBoxScene` 指向的那个场景里的 `ExchangeBox` 实例。而无线电和交易箱**都没有 GUID/PDID**,跨场景后没有任何句柄能找回它们,只能靠"当前加载的场景里存在这个组件"被发现。

所以一笔进行中的交易,如果指向的场景去不了或者箱子被搬走了,已提交的装备会**永久卡在存档里**,`CloseTrade()` 和 `CompleteTrade()` 都进不去。

默认行为是交易进行中直接拒绝搬运。设置里可以关掉这道守卫(改成只警告),但**不建议**。

### 交易箱默认关闭

同上。交易箱是取回已提交物品的唯一入口,搬它的风险比搬无线电高。想用就自己在设置里开。

### 无线电搬走后原地就没了

搬的是本体,所以原来那间屋子里不会再有一台。和 SCPlus 搬壁炉的行为一致。

### 依赖 SCPlus 的私有实现

背包收纳靠反射改它的 `internal` 类里的字典条目。**SCPlus 升级改了结构就可能失效**,届时自动降级为抱着走(不会崩)。已验证兼容 1.9.4。

日志里如果出现 `pickupable 还原失败`,那是严重状态:立刻退出游戏不要存档,否则读档后电台可能失效。

### 待实测确认的三点

- 跨场景搬运后,拿起/放下的过场动画可能失效。`m_PickupRadioTimeline` 里含 `m_BindingAnimator`(`Animator` 场景引用),跨场景后为 null。如果卡住,后续版本会跳过这段动画
- 交易箱搬走后,新一轮交易会不会在原场景又投一个,尚未验证
- 无线电收进背包再放出来后,`TraderRadio` 组件的交互是否仍然完整(SCPlus 的 `MakeIntoDecoration` 会改层级和 collider)

## 兼容性

- **与 SCPlus 共存**:启动时自动探测。不改它任何文件、不碰它的数据结构、存档 tag 用自己的(`TraderMoving` / `placement`),和它的 `carryables` 物理隔离。所有存档相关 patch 都带 `[HarmonyPriority(Priority.Last)]`,跑在它之后
- **与 TldHacks 共存**:TldHacks 已有的信任度显示、商人随时可联系、免费交易三个功能不受影响。因为本 mod 搬的是原版实例(对象引用没变),TldHacks 缓存的 `_radio` 仍然有效
- 不改 TldHacks 主体代码

## 启动自检

启动时会验证 16 个 patch 目标能否解析,日志里看 `[TraderMoving.SelfCheck]`。游戏更新改了方法签名时会直接报错,而不是功能默默失效。

已离线验证:16 个 patch 目标 + 10 个调用的 API 全部命中 2.55 的真实签名。

## 构建

```
dotnet build TraderMoving/src/TraderMoving.csproj                    # 编译并部署到 Mods
dotnet build TraderMoving/src/TraderMoving.csproj -p:NoDeploy=true   # 只编译不部署
```
