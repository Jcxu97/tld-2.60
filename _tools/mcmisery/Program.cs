using System;
using System.Linq;
using AsmResolver.DotNet;
using AsmResolver.DotNet.Code.Cil;
using AsmResolver.DotNet.Signatures;
using AsmResolver.PE.DotNet.Cil;
using AsmResolver.PE.DotNet.Metadata.Tables;

namespace McMisery;

// 用法: mcmisery <原版 ModComponent.dll> <输出 dll> [默认倍率]
// ModComponent 7.0.0 的 GearSpawner 难度表没有厄难(ExperienceModeType 18),厄难落进 Other,散落倍率写死 1。
// 这里只加四处:DifficultyLevel.Misery=7、18 映射到 Misery、厄难倍率滑条、概率函数的 Misery 分支,其余字节不动
internal static class Program
{
    private const int MiseryMode = 18;
    private const int MiseryLevel = 7;
    private const string Field = "miserySpawnProbabilityMultiplier";

    private static int Main(string[] args)
    {
        float def = args.Length > 2 ? float.Parse(args[2], System.Globalization.CultureInfo.InvariantCulture) : 0.1f;
        ModuleDefinition module = ModuleDefinition.FromFile(args[0]);
        TypeDefinition level = Find(module, "GearSpawner.DifficultyLevel");
        TypeDefinition settings = Find(module, "GearSpawner.Settings");
        if (level.Fields.Any(f => f.Name == "Misery"))
        {
            Console.Error.WriteLine("already patched");
            return 1;
        }

        var misery = new FieldDefinition("Misery",
            FieldAttributes.Public | FieldAttributes.Static | FieldAttributes.Literal | FieldAttributes.HasDefault,
            new FieldSignature(level.ToTypeSignature()));
        misery.Constant = Constant.FromValue(MiseryLevel);
        level.Fields.Add(misery);

        FieldDefinition interloper = settings.Fields.First(f => f.Name == "interloperSpawnProbabilityMultiplier");
        var mf = new FieldDefinition(Field, interloper.Attributes, new FieldSignature(module.CorLibTypeFactory.Single));
        foreach (CustomAttribute a in interloper.CustomAttributes)
        {
            CustomAttributeSignature sig = a.Constructor.DeclaringType.Name == "NameAttribute"
                ? new CustomAttributeSignature(new CustomAttributeArgument(module.CorLibTypeFactory.String, "厄难/极低概率"))
                : a.Signature;
            mf.CustomAttributes.Add(new CustomAttribute(a.Constructor, sig));
        }
        settings.Fields.Insert(settings.Fields.IndexOf(interloper) + 1, mf);

        MethodDefinition ctor = settings.Methods.First(m => m.IsConstructor && !m.IsStatic);
        var ci = ctor.CilMethodBody.Instructions;
        int at = ci.IndexOf(ci.First(i => i.OpCode.Code == CilCode.Stfld && ((IFieldDescriptor)i.Operand).Name == interloper.Name)) + 1;
        ci.InsertRange(at, new[]
        {
            new CilInstruction(CilOpCodes.Ldarg_0),
            new CilInstruction(CilOpCodes.Ldc_R4, def),
            new CilInstruction(CilOpCodes.Stfld, mf),
        });

        PatchGetDifficultyLevel(Find(module, "GearSpawner.GameModes").Methods.First(m => m.Name == "GetDifficultyLevel"));
        PatchGetAdjustedProbability(Find(module, "GearSpawner.DefaultGearSpawnHandler").Methods.First(m => m.Name == "GetAdjustedProbability"), mf);

        module.Write(args[1]);
        Console.WriteLine($"patched -> {args[1]} (misery default {def})");
        return 0;
    }

    private static CilInstruction Target(object label) => ((CilInstructionLabel)label).Instruction;

    private static TypeDefinition Find(ModuleDefinition m, string name) => m.GetAllTypes().First(t => t.FullName == name);

    // switch 表原本到 17,在表尾补 18 指向新块 "ldc.i4 7; stloc.0; br <合流点>",新块插在 default 块前面
    private static void PatchGetDifficultyLevel(MethodDefinition method)
    {
        var ins = method.CilMethodBody.Instructions;
        ins.ExpandMacros();
        CilInstruction sw = ins.First(i => i.OpCode.Code == CilCode.Switch);
        var labels = (System.Collections.Generic.IList<ICilLabel>)sw.Operand;
        if (labels.Count != MiseryMode)
            throw new InvalidOperationException($"GetDifficultyLevel switch has {labels.Count} cases, expected {MiseryMode}");
        CilInstruction dflt = ins[ins.IndexOf(sw) + 1];
        CilInstruction defaultBlock = Target(dflt.Operand);
        CilInstruction join = ins[ins.IndexOf(defaultBlock) + 2];
        var block = new[]
        {
            new CilInstruction(CilOpCodes.Ldc_I4, MiseryLevel),
            new CilInstruction(CilOpCodes.Stloc_0),
            new CilInstruction(CilOpCodes.Br, join.CreateLabel()),
        };
        ins.InsertRange(ins.IndexOf(defaultBlock), block);
        labels.Add(block[0].CreateLabel());
        ins.OptimizeMacros();
    }

    // switch 表原本 0..4,补 5、6 指向 default,7 指向新块,新块照入侵者那段抄,只换字段
    private static void PatchGetAdjustedProbability(MethodDefinition method, FieldDefinition mf)
    {
        var ins = method.CilMethodBody.Instructions;
        ins.ExpandMacros();
        CilInstruction sw = ins.First(i => i.OpCode.Code == CilCode.Switch);
        var labels = (System.Collections.Generic.IList<ICilLabel>)sw.Operand;
        if (labels.Count != 5)
            throw new InvalidOperationException($"GetAdjustedProbability switch has {labels.Count} cases, expected 5");
        CilInstruction dflt = ins[ins.IndexOf(sw) + 1];
        CilInstruction defaultBlock = Target(dflt.Operand);
        int k = ins.IndexOf(Target(labels[3]));
        // ldc.r4 0; call get_instance; ldfld interloper; call Math.Max; stloc.2; br join
        var block = new[]
        {
            new CilInstruction(CilOpCodes.Ldc_R4, 0f),
            new CilInstruction(CilOpCodes.Call, ins[k + 1].Operand),
            new CilInstruction(CilOpCodes.Ldfld, mf),
            new CilInstruction(CilOpCodes.Call, ins[k + 3].Operand),
            new CilInstruction(ins[k + 4].OpCode, ins[k + 4].Operand),
            new CilInstruction(CilOpCodes.Br, ins[k + 5].Operand),
        };
        if (ins[k + 2].OpCode.Code != CilCode.Ldfld || ins[k + 5].OpCode.Code != CilCode.Br)
            throw new InvalidOperationException("unexpected interloper block layout");
        ins.InsertRange(ins.IndexOf(defaultBlock), block);
        ICilLabel defaultLabel = defaultBlock.CreateLabel();
        labels.Add(defaultLabel);
        labels.Add(defaultLabel);
        labels.Add(block[0].CreateLabel());
        ins.OptimizeMacros();
    }
}
