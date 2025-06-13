using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Tiles;
using Il2CppSystem;

namespace Il2CppScheduleOne.Storage
{
	// Token: 0x0200059A RID: 1434
	[System.Serializable]
	public sealed class CoordinateStorageTilePair : Il2CppSystem.ValueType
	{
		// Token: 0x06007D4B RID: 32075 RVA: 0x0021DBFC File Offset: 0x0021BDFC
		// Note: this type is marked as 'beforefieldinit'.
		static CoordinateStorageTilePair()
		{
			Il2CppClassPointerStore<CoordinateStorageTilePair>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Storage", "CoordinateStorageTilePair");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CoordinateStorageTilePair>.NativeClassPtr);
			CoordinateStorageTilePair.NativeFieldInfoPtr_coord = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CoordinateStorageTilePair>.NativeClassPtr, "coord");
			CoordinateStorageTilePair.NativeFieldInfoPtr_tile = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CoordinateStorageTilePair>.NativeClassPtr, "tile");
		}

		// Token: 0x06007D4C RID: 32076 RVA: 0x0003B333 File Offset: 0x00039533
		public CoordinateStorageTilePair(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x06007D4D RID: 32077 RVA: 0x0003B33C File Offset: 0x0003953C
		public CoordinateStorageTilePair() : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CoordinateStorageTilePair>.NativeClassPtr))
		{
		}

		// Token: 0x1700259F RID: 9631
		// (get) Token: 0x06007D4E RID: 32078 RVA: 0x0021DC54 File Offset: 0x0021BE54
		// (set) Token: 0x06007D4F RID: 32079 RVA: 0x0003B34E File Offset: 0x0003954E
		public unsafe Coordinate coord
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CoordinateStorageTilePair.NativeFieldInfoPtr_coord);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coordinate>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CoordinateStorageTilePair.NativeFieldInfoPtr_coord), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170025A0 RID: 9632
		// (get) Token: 0x06007D50 RID: 32080 RVA: 0x0021DC84 File Offset: 0x0021BE84
		// (set) Token: 0x06007D51 RID: 32081 RVA: 0x0003B36D File Offset: 0x0003956D
		public unsafe StorageTile tile
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CoordinateStorageTilePair.NativeFieldInfoPtr_tile);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StorageTile>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CoordinateStorageTilePair.NativeFieldInfoPtr_tile), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400555A RID: 21850
		private static readonly System.IntPtr NativeFieldInfoPtr_coord;

		// Token: 0x0400555B RID: 21851
		private static readonly System.IntPtr NativeFieldInfoPtr_tile;
	}
}
