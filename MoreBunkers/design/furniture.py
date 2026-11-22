# 家具和器械的尺寸,从游戏文件读出(_work/interiors/prefab.py)。
# w 沿墙宽, d 离墙深(朝向坐标);cx, cz 是占地中心在预制件坐标里的偏移
# yaw0 是预制件正面相对 +z 要转多少度(正面朝 -z 填 180,朝 +x 填 -90,朝 -x 填 90);root_y 是挂点离地高度
# levels: (顶面相对挂点的高度, x0, x1, z0, z1, 上方净空)
P = 'Assets/ArtAssets/Env/Objects/'
FURN = {
 'MetalShelfB': dict(path='Assets/ArtAssets/Env/Objects/OBJ_MetalShelves/OBJ_MetalShelfB_Prefab.prefab', w=1.84, d=0.54, cx=0, cz=0, h=2.30, root_y=1.149, yaw0=0,
                     levels=[(-0.813,-0.84,0.84,-0.24,0.24,0.60),(-0.162,-0.84,0.84,-0.24,0.24,0.58),(0.479,-0.84,0.84,-0.24,0.24,0.58)]),
 'MetalShelfA': dict(path='Assets/ArtAssets/Env/Objects/OBJ_MetalShelves/OBJ_MetalShelfA_Prefab.prefab', w=1.84, d=0.54, cx=0, cz=0, h=1.63, root_y=0.813, yaw0=0,
                     levels=[(-0.478,-0.84,0.84,-0.24,0.24,0.60),(0.173,-0.84,0.84,-0.24,0.24,0.58),(0.818,-0.84,0.84,-0.24,0.24,0.90)]),
 'MetalTable': dict(path='Assets/ArtAssets/Env/Objects/OBJ_IndustrialDeco/OBJ_MetalTable_A_Prefab.prefab', w=1.80, d=0.78, cx=0.05, cz=0, h=1.15, root_y=0, yaw0=0,
                     levels=[(0.191,-0.68,0.76,-0.30,0.30,0.33),(0.613,-0.68,0.76,-0.30,0.30,0.42),(1.150,-0.78,0.88,-0.34,0.34,0.90)]),
 'GunRack': dict(path='Assets/ArtAssets/Env/Objects/OBJ_GunRack/OBJ_GunRackDouble_Prefab.prefab', w=1.02, d=0.14, cx=0, cz=0.07, h=0.71, root_y=0, yaw0=0, levels=[]),
 'MetalBox': dict(path='CONTAINER_MetalBox', w=0.73, d=0.55, cx=0, cz=0, h=0.32, root_y=0, yaw0=0, levels=[]),
 'ToolCabinet': dict(path='Assets/Prefabs/Containers/CONTAINER_ToolCabinet.prefab', w=1.29, d=0.62, cx=0, cz=0, h=2.2, root_y=0, yaw0=0, levels=[]),
 'CoalBin': dict(path='Assets/Prefabs/Containers/CONTAINER_CoalBin.prefab', w=1.14, d=1.19, cx=0, cz=0, h=1.41, root_y=0, yaw0=0, levels=[]),
 'FirewoodBin': dict(path='Assets/Prefabs/Containers/CONTAINER_FirewoodBin.prefab', w=1.97, d=1.18, cx=0, cz=0, h=1.27, root_y=0, yaw0=0, levels=[]),
 'GunLocker': dict(path='Assets/Prefabs/Containers/CONTAINER_StorageGunLocker_A.prefab', w=0.82, d=0.56, cx=0.02, cz=0.03, h=1.74, root_y=0, yaw0=180, levels=[]),
 'LockerB': dict(path='CONTAINER_MetalLockerB', w=1.04, d=0.51, cx=0, cz=-0.015, h=2.4, root_y=1.2, yaw0=180, levels=[]),
 'MedLocker': dict(path='CONTAINER_MedicalLocker', w=0.5, d=0.57, cx=0, cz=-0.045, h=2.4, root_y=1.2, yaw0=180, levels=[]),
 'Bed': dict(path='Assets/Prefabs/Interactive/INTERACTIVE_BedMattressA.prefab', w=2.09, d=1.03, cx=0.005, cz=0.005, h=0.78, root_y=0, yaw0=90, levels=[]),
 'StoveBelly': dict(path='Assets/Prefabs/Interactive/INTERACTIVE_PotBellyStove.prefab', w=0.68, d=0.68, cx=0, cz=0, h=1.24, root_y=0, yaw0=180, levels=[]),
 'Cookstove': dict(path='Assets/Prefabs/Interactive/INTERACTIVE_StoveMetalA.prefab', w=1.6, d=1.13, cx=0, cz=0.045, h=1.25, root_y=0, yaw0=180, levels=[]),
 'WallShelf': dict(path='Assets/ArtAssets/Env/Structures/STR_Bunker/OBJ_Bunker_Shelf_A_Prefab.prefab', w=1.48, d=0.34, cx=0, cz=0, h=0.32, root_y=0.16, yaw0=0,
                   levels=[(0.16,-0.68,0.68,-0.13,0.13,0.45)]),
 'Chair': dict(path='Assets/ArtAssets/Env/Objects/OBJ_IndustrialDeco/OBJ_MetalChairA_Prefab.prefab', w=0.82, d=0.78, cx=0, cz=0, h=1.32, root_y=0, yaw0=0, levels=[]),
 'Rug': dict(path='Assets/ArtAssets/Env/Objects/OBJ_Rugs/OBJ_RugC_Prefab.prefab', w=1.69, d=2.5, cx=0.005, cz=0, h=0.05, root_y=0, yaw0=0, levels=[]),
 'Cooler': dict(path='CONTAINER_Cooler', w=1.32, d=0.7, cx=0, cz=0, h=0.76, root_y=0, yaw0=0, levels=[]),
 'Calendar': dict(path='Assets/ArtAssets/Env/Objects/OBJ_InteriorDeco/OBJ_CalendarDeco_Prefab.prefab', w=0.94, d=0.08, cx=0, cz=0, h=1.24, root_y=0.62, yaw0=0, levels=[]),
 'Clock': dict(path='Assets/ArtAssets/Env/Objects/OBJ_InteriorAppliances/OBJ_WallClock_Prefab.prefab', w=0.56, d=0.03, cx=-0.015, cz=0, h=0.56, root_y=0.28, yaw0=90, levels=[]),
 'Radio': dict(path='Assets/ArtAssets/Env/Objects/OBJ_RadioB/OBJ_RadioB_Prefab.prefab', w=0.32, d=0.28, cx=0, cz=0, h=0.15, root_y=0, yaw0=0, levels=[]),
 'DeskLamp': dict(path='Assets/ArtAssets/Env/Objects/OBJ_InteriorAppliances/OBJ_Lab_DeskLamp_A_Prefab.prefab', w=0.42, d=0.12, cx=0.1, cz=0, h=0.56, root_y=0, yaw0=0, levels=[]),
 'ToolCabinetMedium': dict(path='Assets/Prefabs/Containers/CONTAINER_ToolCabinetMedium.prefab', w=1.29, d=0.62, cx=0.005, cz=0.02, h=1.63, root_y=0.05, yaw0=0, levels=[]),
 'Forge': dict(path='Assets/Prefabs/Interactive/INTERACTIVE_Forge.prefab', w=1.10, d=0.80, cx=-0.02, cz=-0.02, h=2.5, root_y=0, yaw0=0, levels=[]),
 'AmmoBench': dict(path='Assets/Prefabs/Interactive/INTERACTIVE_AmmoWorkBench.prefab', w=2.32, d=1.56, cx=0, cz=0, h=1.62, root_y=0.81, yaw0=0, levels=[]),
 'WorkBench': dict(path='Assets/Prefabs/Interactive/INTERACTIVE_WorkBench.prefab', w=2.16, d=1.47, cx=0, cz=0, h=1.24, root_y=0.636, yaw0=0, levels=[]),
 'Mill': dict(path='Assets/ArtAssets/Env/Objects/OBJ_IndustrialMillingMachine/OBJ_IndustrialMillingMachine_Prefab.prefab', w=1.74, d=1.44, cx=0, cz=0, h=2.42, root_y=1.21, yaw0=0, levels=[]),
}
