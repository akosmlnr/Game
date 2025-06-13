using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2CppScheduleOne.Tiles
{
	// Token: 0x020001A3 RID: 419
	[System.Serializable]
	public sealed class CoordinateFootprintTilePair : Il2CppSystem.ValueType
	{
		// Token: 0x06002222 RID: 8738 RVA: 0x000DE3FC File Offset: 0x000DC5FC
		// Note: this type is marked as 'beforefieldinit'.
		static CoordinateFootprintTilePair()
		{
			Il2CppClassPointerStore<CoordinateFootprintTilePair>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Tiles", "CoordinateFootprintTilePair");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CoordinateFootprintTilePair>.NativeClassPtr);
			CoordinateFootprintTilePair.NativeFieldInfoPtr_coord = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CoordinateFootprintTilePair>.NativeClassPtr, "coord");
			CoordinateFootprintTilePair.NativeFieldInfoPtr_footprintTile = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CoordinateFootprintTilePair>.NativeClassPtr, "footprintTile");
		}

		// Token: 0x06002223 RID: 8739 RVA: 0x00012EB0 File Offset: 0x000110B0
		public CoordinateFootprintTilePair(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x06002224 RID: 8740 RVA: 0x00012EB9 File Offset: 0x000110B9
		public CoordinateFootprintTilePair() : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CoordinateFootprintTilePair>.NativeClassPtr))
		{
		}

		// Token: 0x17000B9E RID: 2974
		// (get) Token: 0x06002225 RID: 8741 RVA: 0x000DE454 File Offset: 0x000DC654
		// (set) Token: 0x06002226 RID: 8742 RVA: 0x00012ECB File Offset: 0x000110CB
		public unsafe Coordinate coord
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CoordinateFootprintTilePair.NativeFieldInfoPtr_coord);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coordinate>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CoordinateFootprintTilePair.NativeFieldInfoPtr_coord), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B9F RID: 2975
		// (get) Token: 0x06002227 RID: 8743 RVA: 0x000DE484 File Offset: 0x000DC684
		// (set) Token: 0x06002228 RID: 8744 RVA: 0x00012EEA File Offset: 0x000110EA
		public unsafe FootprintTile footprintTile
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CoordinateFootprintTilePair.NativeFieldInfoPtr_footprintTile);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FootprintTile>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CoordinateFootprintTilePair.NativeFieldInfoPtr_footprintTile), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040016BC RID: 5820
		private static readonly System.IntPtr NativeFieldInfoPtr_coord;

		// Token: 0x040016BD RID: 5821
		private static readonly System.IntPtr NativeFieldInfoPtr_footprintTile;
	}
}
