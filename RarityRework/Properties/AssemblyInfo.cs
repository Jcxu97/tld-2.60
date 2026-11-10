using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.Versioning;
using RarityRework;
using MelonLoader;

[assembly: MelonInfo(typeof(Mod), "Rarity Rework", "1.1.0", "Deadman", null)]
[assembly: MelonGame("Hinterland", "TheLongDark")]
[assembly: MelonPriority(0)]
[assembly: MelonIncompatibleAssemblies(new string[] { "ItemRarities", "DisableBreathEffect", "NonPotableToiletWater", "UnlimitedRockCaches", "ContainerTweaks" })]
[assembly: VerifyLoaderVersion("0.7.2-ci.2388", true)]
[assembly: AssemblyCompany("Deadman")]
[assembly: AssemblyConfiguration("Release")]
[assembly: AssemblyCopyright("Copyright (c) 2026 Deadman")]
[assembly: AssemblyDescription("Shows an item tier that is based on survival value.")]
[assembly: AssemblyFileVersion("1.1.0.0")]
[assembly: AssemblyInformationalVersion("1.1.0")]
[assembly: AssemblyProduct("Rarity Rework")]
[assembly: AssemblyTitle("RarityRework")]
[assembly: AssemblyMetadata("RepositoryUrl", "https://github.com/Deaadman/item-rarities")]
[assembly: AssemblyVersion("1.1.0.0")]
