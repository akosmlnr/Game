using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Tiles;
using Il2CppSystem;

namespace Il2CppScheduleOne.Storage
{
	// Token: 0x020005A0 RID: 1440
	[System.Serializable]
	public sealed class CoordinateStorageFootprintTilePair : Il2CppSystem.ValueType
	{
		// Token: 0x06007DC1 RID: 32193 RVA: 0x0021F57C File Offset: 0x0021D77C
		// Note: this type is marked as 'beforefieldinit'.
		static CoordinateStorageFootprintTilePair()
		{
			Il2CppClassPointerStore<CoordinateStorageFootprintTilePair>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Storage", "CoordinateStorageFootprintTilePair");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CoordinateStorageFootprintTilePair>.NativeClassPtr);
			CoordinateStorageFootprintTilePair.NativeFieldInfoPtr_coord = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CoordinateStorageFootprintTilePair>.NativeClassPtr, "coord");
			CoordinateStorageFootprintTilePair.NativeFieldInfoPtr_tile = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CoordinateStorageFootprintTilePair>.NativeClassPtr, "tile");
		}

		// Token: 0x06007DC2 RID: 32194 RVA: 0x0003B6C4 File Offset: 0x000398C4
		public CoordinateStorageFootprintTilePair(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x06007DC3 RID: 32195 RVA: 0x0003B6CD File Offset: 0x000398CD
		public CoordinateStorageFootprintTilePair() : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CoordinateStorageFootprintTilePair>.NativeClassPtr))
		{
		}

		// Token: 0x170025C3 RID: 9667
		// (get) Token: 0x06007DC4 RID: 32196 RVA: 0x0021F5D4 File Offset: 0x0021D7D4
		// (set) Token: 0x06007DC5 RID: 32197 RVA: 0x0003B6DF File Offset: 0x000398DF
		public unsafe Coordinate coord
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CoordinateStorageFootprintTilePair.NativeFieldInfoPtr_coord);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coordinate>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CoordinateStorageFootprintTilePair.NativeFieldInfoPtr_coord), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170025C4 RID: 9668
		// (get) Token: 0x06007DC6 RID: 32198 RVA: 0x0021F604 File Offset: 0x0021D804
		// (set) Token: 0x06007DC7 RID: 32199 RVA: 0x0003B6FE File Offset: 0x000398FE
		public unsafe FootprintTile tile
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CoordinateStorageFootprintTilePair.NativeFieldInfoPtr_tile);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FootprintTile>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CoordinateStorageFootprintTilePair.NativeFieldInfoPtr_tile), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040055A8 RID: 21928
		private static readonly System.IntPtr NativeFieldInfoPtr_coord;

		// Token: 0x040055A9 RID: 21929
		private static readonly System.IntPtr NativeFieldInfoPtr_tile;
	}
}
