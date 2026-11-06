using System;
using Il2Cpp;
using Il2CppTLD.AddressableAssets;
using Il2CppTLD.Trader;
using UnityEngine;
using SceneManager = UnityEngine.SceneManagement.SceneManager;

namespace TraderMoving;

// 场景里的实物:按记录隐藏原件、摆出自己造的无线电和交易箱。
//
// 原版带交互的无线电和交易箱都不是可加载资源,只作为实例存在于 *_DLC01 场景里,
// 所以跨场景没法把原件带过去。交易箱照 Fuar 的 ImprovedTrader(2.55 可用)从
// OBJ_TradeBoxA_Prefab 现造一个完整的 ExchangeBox;无线电的对话界面拆不出来,
// 离开原屋子就用美术模型 Survival_TraderRadio.prefab 做随身无线电,交易走 RemoteTrade。
internal static class World
{
    internal const string RadioName = "TraderMoving_Radio";
    internal const string BoxName = "TraderMoving_Box";
    internal const string PreviewName = "TraderMoving_Preview";
    private const string RadioArt = "Assets/ArtAssets/Characters/NPC/Props/Survival_TraderRadio.prefab";
    private const string BoxArt = "Assets/ArtAssets/Env/Objects/OBJ_TradeBox/OBJ_TradeBoxA_Prefab.prefab";

    private static GameObject _radioObj;
    private static GameObject _boxObj;

    internal static GameObject FindOwnRoot(Transform t)
    {
        for (var cur = t; cur != null; cur = cur.parent)
        {
            var n = cur.gameObject.name;
            if (n == RadioName || n == BoxName) return cur.gameObject;
        }
        return null;
    }

    internal static ExchangeBox MovedBoxInScene()
    {
        if (_boxObj == null) return null;
        return _boxObj.GetComponentInChildren<ExchangeBox>(true);
    }

    // ── 进场景后按记录摆好(可重复调用) ─────────────────────

    internal static void Apply()
    {
        string scene = GameManager.m_ActiveScene;
        if (string.IsNullOrEmpty(scene) || RadioClone.Harvesting) return;
        try { ApplyRadio(scene); } catch (Exception ex) { ModMain.Log?.Warning($"[TraderMoving] 摆放无线电异常: {ex.Message}"); }
        try { ApplyBox(scene); } catch (Exception ex) { ModMain.Log?.Warning($"[TraderMoving] 摆放交易箱异常: {ex.Message}"); }
    }

    private static void ApplyRadio(string scene)
    {
        var r = SaveData.Current.radio;
        var real = FindVanillaRadio(r);
        if (real != null)
        {
            RadioClone.MakeTemplate(real, r.originObjScene);
            bool showHere = r.placed && r.asReal && r.scene == scene;
            if (showHere)
            {
                real.SetActive(true);
                real.transform.SetPositionAndRotation(r.Pos, r.RadioRot);
            }
            else real.SetActive(false);
        }

        bool wantPortable = r.taken && r.placed && !r.asReal && r.scene == scene;
        if (wantPortable) PlaceRadio(r.Pos, r.RadioRot, r.originObjScene);
        else DestroyOwn(ref _radioObj);
    }

    private static void ApplyBox(string scene)
    {
        var r = SaveData.Current.box;
        bool wantBox = r.taken && r.placed && r.scene == scene;

        var trade = TradeGuard.ActiveTrade();
        bool tradeHere = trade != null && trade.m_ExchangeBoxScene == scene;
        bool keepOriginal = tradeHere && !wantBox;

        if (r.taken)
        {
            foreach (var b in Resources.FindObjectsOfTypeAll<ExchangeBox>())
            {
                if (!IsVanillaInLoadedScene(((Component)b).gameObject)) continue;
                var go = ((Component)b).gameObject;
                bool isOriginal = go.scene.name == r.originObjScene
                               && Vector3.Distance(go.transform.position, r.Origin) < 15f;
                // 自己的箱子在这个场景时,同场景别的原版箱也收起来,免得两个箱子对着同一笔交易
                if (keepOriginal)
                {
                    if (isOriginal && !go.activeSelf)
                    {
                        go.SetActive(true);
                        ModMain.Log?.Msg("[TraderMoving] 交易送到原件所在场景,原件先放出来");
                    }
                    continue;
                }
                if (isOriginal || wantBox)
                {
                    if (go.activeSelf) go.SetActive(false);
                    UnregisterBox(b);
                }
            }
        }

        if (wantBox) EnsureBox(r.Pos, r.Rot);
        else DestroyOwn(ref _boxObj);
    }

    // ── 原版物件 ──────────────────────────────────────────

    private static bool IsVanillaInLoadedScene(GameObject go)
    {
        if (go == null) return false;
        var s = go.scene;
        if (!s.IsValid() || !s.isLoaded) return false;
        if (RadioClone.Harvesting && s.name == RadioClone.HarvestScene) return false;
        return FindOwnRoot(go.transform) == null && go.name != RemoteTrade.DummyName;
    }

    // 已拿走的那台原版无线电(可能被我们藏起来了,所以要连未激活的一起找)
    internal static GameObject FindVanillaRadio(ItemRecord r)
    {
        if (r == null || !r.taken || string.IsNullOrEmpty(r.originObjScene)) return null;
        foreach (var tr in Resources.FindObjectsOfTypeAll<TraderRadio>())
        {
            var go = ((Component)tr).gameObject;
            if (!IsVanillaInLoadedScene(go)) continue;
            if (go.scene.name == r.originObjScene) return go;
        }
        return null;
    }

    internal static void HideVanilla(GameObject go)
    {
        if (go == null) return;
        var box = go.GetComponent<ExchangeBox>();
        if (box != null) UnregisterBox(box);
        go.SetActive(false);
    }

    private static void UnregisterBox(ExchangeBox b)
    {
        try
        {
            var tm = GameManager.GetTraderManager();
            if (tm != null && tm.m_ExchangeBoxInScene != null && tm.m_ExchangeBoxInScene.Pointer == b.Pointer)
                tm.m_ExchangeBoxInScene = null;
        }
        catch { }
    }

    // 真无线电放回原屋子后可能被 SCPlus 的装修模式拖动过,存档前按实际位置刷新
    internal static void RefreshRealRadioPosition()
    {
        try
        {
            var r = SaveData.Current.radio;
            if (!r.taken || !r.placed || !r.asReal || r.scene != GameManager.m_ActiveScene) return;
            var real = FindVanillaRadio(r);
            if (real == null || !real.activeInHierarchy) return;
            r.SetPlace(r.scene, real.transform.position, real.transform.eulerAngles.y);
        }
        catch { }
    }

    // ── 自己造的两样 ──────────────────────────────────────

    private static bool _radioIsClone;

    // 别的场景里的无线电:有模板就放完整的复制品;还没模板先去后台复制,复制不成才用美术模型
    // 返回 false 表示这次放不出来(模型也加载失败)
    internal static bool PlaceRadio(Vector3 pos, Quaternion rot, string origin)
    {
        if (_radioObj != null && !_radioIsClone && RadioClone.HasTemplate(origin)) DestroyOwn(ref _radioObj);
        if (_radioObj != null)
        {
            _radioObj.transform.SetPositionAndRotation(pos, rot);
            return true;
        }
        if (RadioClone.HasTemplate(origin))
        {
            _radioObj = RadioClone.Spawn(pos, rot);
            _radioIsClone = _radioObj != null;
            if (_radioIsClone)
            {
                ModMain.Log?.Msg("[TraderMoving] 无线电(完整复制品)已摆出");
                return true;
            }
        }
        if (!RadioClone.Failed(origin))
        {
            RadioClone.StartHarvest(origin);
            if (RadioClone.Busy) return true;
        }
        _radioIsClone = false;
        return EnsurePortableRadio(pos, rot) != null;
    }

    internal static bool RadioIsClone => _radioObj != null && _radioIsClone;

    internal static GameObject EnsurePortableRadio(Vector3 pos, Quaternion rot)
    {
        if (_radioObj == null)
        {
            var root = NewRoot(RadioName);
            var art = AssetHelper.SafeInstantiateAssetAsync(RadioArt, root.transform, false, false).WaitForCompletion();
            if (art == null)
            {
                ModMain.Log?.Error("[TraderMoving] 无线电模型加载失败(没装 DLC?)");
                UnityEngine.Object.Destroy(root);
                return null;
            }
            art.transform.localPosition = Vector3.zero;
            art.transform.localRotation = Quaternion.identity;
            FitCollider(root);
            _radioObj = root;
            ModMain.Log?.Msg("[TraderMoving] 随身无线电已摆出");
        }
        _radioObj.transform.SetPositionAndRotation(pos, rot);
        return _radioObj;
    }

    // 照 ImprovedTrader 的 TraderBoxHelper:箱子本体挂 ExchangeBox,父物体挂开门动画
    internal static GameObject EnsureBox(Vector3 pos, Quaternion rot)
    {
        if (_boxObj == null)
        {
            var parent = NewRoot(BoxName);
            parent.SetActive(false);

            var box = AssetHelper.SafeInstantiateAssetAsync(BoxArt, parent.transform, false, false).WaitForCompletion();
            if (box == null)
            {
                ModMain.Log?.Error("[TraderMoving] 交易箱模型加载失败");
                UnityEngine.Object.Destroy(parent);
                return null;
            }
            box.transform.localPosition = Vector3.zero;
            box.transform.localRotation = Quaternion.identity;
            box.SetActive(false);

            var ex = box.AddComponent<ExchangeBox>();
            var oa = parent.AddComponent<ObjectAnim>();
            oa.m_Target = box.transform.GetChild(2).gameObject;
            oa.Initialize();

            ex.m_ObjectAnim = oa;
            ex.m_Lock = box.transform.GetChild(1).gameObject;
            ex.m_DefaultHoverText = new LocalizedString { m_LocalizationID = "GAMEPLAY_ExchangeBox" };
            ex.m_DefaultHoldText = new LocalizedString { m_LocalizationID = "GAMEPLAY_OpeningProgress" };
            ex.m_LockedPostFix = new LocalizedString { m_LocalizationID = "GAMEPLAY_LockedPostfix" };
            ex.m_DefaultHoldTime = 0.5f;
            ex.m_BoxLockedEvent = WwiseEvent(1359875401, "80CFEA83-388C-45FD-B898-8552EB3E798F", "play_Trader_Interaction_ExchangeBox_Locked");
            ex.m_BoxOpenEvent = WwiseEvent(1041331915, "19EA54D7-E211-48C7-9D17-E39C26C6BDB0", "play_Trader_Interaction_ExchangeBox_Open");
            ex.m_BoxCloseEvent = WwiseEvent(4238822553, "4293A7A6-54A9-4CB0-8816-3850ED5E8752", "play_Trader_Interaction_ExchangeBox_Close");

            var potable = UnityEngine.AddressableAssets.Addressables.LoadAssetAsync<GameObject>((Il2CppSystem.Object)"GEAR_WaterSupplyPotable").WaitForCompletion()?.GetComponent<GearItem>();
            var nonPotable = UnityEngine.AddressableAssets.Addressables.LoadAssetAsync<GameObject>((Il2CppSystem.Object)"GEAR_WaterSupplyNotPotable").WaitForCompletion()?.GetComponent<GearItem>();
            if (potable != null) ex.m_PotableWaterSupply = potable.m_GearItemData;
            if (nonPotable != null) ex.m_NonPotableWaterSupply = nonPotable.m_GearItemData;

            // 室内不要箱顶的积雪
            try
            {
                if (box.transform.childCount > 3 && GameManager.GetWeatherComponent().IsIndoorScene())
                    box.transform.GetChild(3).gameObject.SetActive(false);
            }
            catch { }

            // 和预览一样在原点对齐底面,再挪到落点
            box.SetActive(true);
            parent.SetActive(true);
            AlignBottom(parent, box);
            parent.transform.SetPositionAndRotation(pos, rot);
            ((Behaviour)ex).enabled = true;
            _boxObj = parent;
            ModMain.Log?.Msg("[TraderMoving] 交易箱已摆出");
        }
        else _boxObj.transform.SetPositionAndRotation(pos, rot);

        HookUpTrade();
        return _boxObj;
    }

    // 进行中的交易指向这个场景,就把它交给我们的箱子;否则上锁
    internal static void HookUpTrade()
    {
        var ex = MovedBoxInScene();
        if (ex == null) return;
        try
        {
            var tm = GameManager.GetTraderManager();
            var trade = tm?.GetActiveTrade();
            bool here = trade != null && trade.m_ExchangeBoxScene == GameManager.m_ActiveScene;
            if (here)
            {
                if (ex.m_ActiveTrade == null || ex.m_ActiveTrade.Pointer != trade.Pointer) ex.SetActiveTrade(trade);
                ex.SetLocked(false);
                tm.m_ExchangeBoxInScene = ex;
            }
            else ex.SetLocked(true);
        }
        catch (Exception e) { ModMain.Log?.Warning($"[TraderMoving] 交易箱接交易异常: {e.Message}"); }
    }

    private static Il2CppAK.Wwise.Event WwiseEvent(uint id, string guid, string name)
    {
        var reference = ScriptableObject.CreateInstance<WwiseEventReference>();
        reference.id = id;
        reference.guid = guid;
        reference.objectName = name;
        return new Il2CppAK.Wwise.Event { WwiseObjectReference = reference };
    }

    private static GameObject NewRoot(string name)
    {
        var go = new GameObject(name);
        go.layer = vp_Layer.InteractiveProp;
        try
        {
            var s = SceneManager.GetSceneByName(GameManager.m_ActiveScene);
            if (s.IsValid() && s.isLoaded && go.scene != s) SceneManager.MoveGameObjectToScene(go, s);
        }
        catch { }
        return go;
    }

    // 摆放用的预览:只有外形,和最后摆出来的东西外形、原点都一样
    internal static GameObject MakePreview(CarryKind kind, ItemRecord rec)
    {
        try
        {
            if (kind == CarryKind.ExchangeBox)
            {
                var root = NewRoot(PreviewName);
                var art = AssetHelper.SafeInstantiateAssetAsync(BoxArt, root.transform, false, false).WaitForCompletion();
                if (art == null) { UnityEngine.Object.Destroy(root); return null; }
                art.transform.localPosition = Vector3.zero;
                art.transform.localRotation = Quaternion.identity;
                try
                {
                    if (art.transform.childCount > 3 && GameManager.GetWeatherComponent().IsIndoorScene())
                        art.transform.GetChild(3).gameObject.SetActive(false);
                }
                catch { }
                AlignBottom(root, art);
                EnsureCollider(root);
                return root;
            }

            // 原屋子里的原件就在场景里(藏着),先拿它做模板
            var real = FindVanillaRadio(rec);
            if (real != null) RadioClone.MakeTemplate(real, rec.originObjScene);
            if (RadioClone.HasTemplate(rec.originObjScene))
            {
                var p = RadioClone.MakePreview();
                if (p != null) return p;
            }
            var r = NewRoot(PreviewName);
            var ra = AssetHelper.SafeInstantiateAssetAsync(RadioArt, r.transform, false, false).WaitForCompletion();
            if (ra == null) { UnityEngine.Object.Destroy(r); return null; }
            ra.transform.localPosition = Vector3.zero;
            ra.transform.localRotation = Quaternion.identity;
            EnsureCollider(r);
            return r;
        }
        catch (Exception ex)
        {
            ModMain.Log?.Warning($"[TraderMoving] 做预览失败: {ex.Message}");
            return null;
        }
    }

    // 游戏的摆放要从碰撞体算占地,没有就按外形补一个
    private static void EnsureCollider(GameObject root)
    {
        if (root.GetComponentsInChildren<Collider>(true).Length == 0) FitCollider(root);
    }

    // 交易箱模型的原点不在底面,整体挪到底面正好落在父物体的高度上
    private static void AlignBottom(GameObject root, GameObject art)
    {
        bool any = false;
        var b = new Bounds();
        foreach (var r in root.GetComponentsInChildren<Renderer>(false))
        {
            if (r == null || !r.enabled || r.GetIl2CppType().Name == "ParticleSystemRenderer") continue;
            if (!any) { b = r.bounds; any = true; } else b.Encapsulate(r.bounds);
        }
        if (!any) return;
        float dy = root.transform.position.y - b.min.y;
        if (Mathf.Abs(dy) > 0.001f && Mathf.Abs(dy) < 2f) art.transform.position += Vector3.up * dy;
    }

    // 美术模型没有碰撞体,按渲染包围盒补一个,准星才能指到它
    private static void FitCollider(GameObject root)
    {
        var rs = root.GetComponentsInChildren<Renderer>(true);
        if (rs.Length == 0) return;
        var b = rs[0].bounds;
        for (int i = 1; i < rs.Length; i++) b.Encapsulate(rs[i].bounds);
        var col = root.AddComponent<BoxCollider>();
        col.center = root.transform.InverseTransformPoint(b.center);
        col.size = b.size;
    }

    private static void DestroyOwn(ref GameObject go)
    {
        if (go == null) return;
        UnityEngine.Object.Destroy(go);
        go = null;
    }

    // ── 拿起 / 放下 ───────────────────────────────────────

    internal static void RemovePortableRadio() => DestroyOwn(ref _radioObj);

    internal static void RemoveMovedBox()
    {
        var ex = MovedBoxInScene();
        if (ex != null) UnregisterBox(ex);
        DestroyOwn(ref _boxObj);
    }

    internal static void OnSceneUnloading()
    {
        _radioObj = null;
        _boxObj = null;
    }

    // ── 放回原处 ──────────────────────────────────────────

    internal static void ResetAll()
    {
        try
        {
            var real = FindVanillaRadio(SaveData.Current.radio);
            var boxRec = SaveData.Current.box;
            if (real != null)
            {
                real.SetActive(true);
                real.transform.SetPositionAndRotation(SaveData.Current.radio.Origin, SaveData.Current.radio.OriginRot);
            }
            if (boxRec.taken)
            {
                // 交易正指向搬过的箱子:没放货就改回原件场景,否则不让还原
                var t = TradeGuard.ActiveTrade();
                if (t != null && boxRec.placed && t.m_ExchangeBoxScene == boxRec.scene)
                {
                    bool empty = t.m_TradeState == Il2CppTLD.Trader.ActiveTradeState.State.Open && !t.HasAnyFilled();
                    if (!empty || string.IsNullOrEmpty(boxRec.originActiveScene))
                    {
                        CarryState.Refuse("交易箱里有交易中的货,先完成交易再放回原处");
                        return;
                    }
                    t.m_ExchangeBoxScene = boxRec.originActiveScene;
                    ModMain.Log?.Msg($"[TraderMoving] 放回原处:交易改回 {boxRec.originActiveScene}");
                }
                foreach (var b in Resources.FindObjectsOfTypeAll<ExchangeBox>())
                {
                    var go = ((Component)b).gameObject;
                    if (!IsVanillaInLoadedScene(go) || go.activeSelf) continue;
                    if (go.scene.name == boxRec.originObjScene && Vector3.Distance(go.transform.position, boxRec.Origin) < 15f)
                        go.SetActive(true);
                }
            }
            RemovePortableRadio();
            RemoveMovedBox();
            CarryState.Reset();
            SaveData.Current.radio.Clear();
            SaveData.Current.box.Clear();
            HUDMessage.AddMessage("无线电和交易箱已放回原处,存档后生效", false, false);
            ModMain.Log?.Msg("[TraderMoving] 已放回原处");
        }
        catch (Exception ex) { ModMain.Log?.Warning($"[TraderMoving] 放回原处异常: {ex.Message}"); }
    }
}
