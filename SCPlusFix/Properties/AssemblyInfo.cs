using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.Versioning;
using MelonLoader;
using SCPlusPP;

[assembly: AssemblyTitle("SCPlusFix++")]
[assembly: AssemblyCopyright("Created by Waltz")]
[assembly: AssemblyFileVersion("2.0.0")]
[assembly: MelonInfo(typeof(SCPMain), "SCPlusFix++", "2.0.0", "AKUL", null)]
[assembly: MelonGame("Hinterland", "TheLongDark")]
// 要比 Mods 里可能还留着的原版 SafehouseCustomizationPlus 先注册,SCPMain.OnEarlyInitializeMelon 才拦得住它
[assembly: MelonPriority(-1000)]
[assembly: AssemblyVersion("2.0.0.0")]
