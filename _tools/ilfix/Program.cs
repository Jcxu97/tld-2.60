using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using AsmResolver.DotNet;
using AsmResolver.DotNet.Cloning;
using AsmResolver.PE.DotNet.Cil;

namespace TldIlFix;

// 用法: ilfix <输出目录> <mod.dll>...
// 把 mod 里调用已删除方法的指令改指到克隆进来的 TldFixCalls,其余字节不动
internal static class Program
{
    private static readonly Dictionary<string, string> Redirects = new()
    {
        ["Il2Cpp.GearItem Il2Cpp.GearItem::LoadGearItemPrefab(System.String)"] = nameof(TldFixCalls.LoadGearItemPrefab),
        ["System.Boolean Il2Cpp.GameManager::IsBootSceneActive()"] = nameof(TldFixCalls.IsBootSceneActive),
        ["UnityEngine.GameObject Il2Cpp.Panel_Inventory_Examine::get_m_SafehouseCustomizationRepairPanel()"] = nameof(TldFixCalls.get_m_SafehouseCustomizationRepairPanel),
        ["Il2CppTLD.Scenes.RegionSpecification Il2CppTLD.Gameplay.SandboxBaseConfig::GetRandomRegionFromAllAvailable()"] = nameof(TldFixCalls.GetRandomRegionFromAllAvailable),
        ["Il2Cpp.GearItem Il2Cpp.PlayerManager::InstantiateItemAtLocation(Il2Cpp.GearItem, System.Int32, UnityEngine.Vector3, System.Boolean)"] = nameof(TldFixCalls.InstantiateItemAtLocation),
        ["System.String Il2Cpp.GameManager::get_m_ActiveScene()"] = nameof(TldFixCalls.ActiveScene),
        ["System.Void Il2Cpp.ObjectAnim::Start()"] = nameof(TldFixCalls.ObjectAnimStart),
    };

    private static int Main(string[] args)
    {
        string outDir = args[0];
        Directory.CreateDirectory(outDir);
        ModuleDefinition helperModule = ModuleDefinition.FromFile(typeof(TldFixCalls).Assembly.Location);
        TypeDefinition helperType = helperModule.TopLevelTypes.First(t => t.Name == nameof(TldFixCalls));

        foreach (string path in args.Skip(1))
        {
            ModuleDefinition module = ModuleDefinition.FromFile(path);
            var sites = new List<(CilInstruction ins, string target)>();
            foreach (TypeDefinition type in module.GetAllTypes())
            foreach (MethodDefinition method in type.Methods)
            {
                if (method.CilMethodBody == null) continue;
                foreach (CilInstruction ins in method.CilMethodBody.Instructions)
                {
                    if (ins.Operand is IMethodDescriptor md && Redirects.TryGetValue(md.FullName, out string target))
                        sites.Add((ins, target));
                }
            }
            if (sites.Count == 0)
            {
                Console.WriteLine($"{Path.GetFileName(path)}: nothing to fix");
                continue;
            }

            var cloner = new MemberCloner(module);
            cloner.Include(helperType, true);
            MemberCloneResult result = cloner.Clone();
            foreach (TypeDefinition t in result.ClonedTopLevelTypes)
                module.TopLevelTypes.Add(t);
            TypeDefinition cloned = (TypeDefinition)result.ClonedTopLevelTypes.First();

            foreach (var (ins, target) in sites)
            {
                ins.OpCode = CilOpCodes.Call;
                ins.Operand = cloned.Methods.First(m => m.Name == target);
            }
            string outPath = Path.Combine(outDir, Path.GetFileName(path));
            module.Write(outPath);
            Console.WriteLine($"{Path.GetFileName(path)}: {sites.Count} call(s) -> {string.Join(", ", sites.Select(s => s.target).Distinct())}");
        }
        return 0;
    }
}
