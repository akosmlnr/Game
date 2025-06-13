using System;
using Il2CppFishNet.Object;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2CppScheduleOne.Tiles
{
	// Token: 0x020001A2 RID: 418
	[System.Serializable]
	public sealed class CoordinateProceduralTilePair : Il2CppSystem.ValueType
	{
		// Token: 0x06002218 RID: 8728 RVA: 0x000DE2B0 File Offset: 0x000DC4B0
		// Note: this type is marked as 'beforefieldinit'.
		static CoordinateProceduralTilePair()
		{
			Il2CppClassPointerStore<CoordinateProceduralTilePair>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Tiles", "CoordinateProceduralTilePair");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CoordinateProceduralTilePair>.NativeClassPtr);
			CoordinateProceduralTilePair.NativeFieldInfoPtr_coord = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CoordinateProceduralTilePair>.NativeClassPtr, "coord");
			CoordinateProceduralTilePair.NativeFieldInfoPtr_tileParent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CoordinateProceduralTilePair>.NativeClassPtr, "tileParent");
			CoordinateProceduralTilePair.NativeFieldInfoPtr_tileIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CoordinateProceduralTilePair>.NativeClassPtr, "tileIndex");
			CoordinateProceduralTilePair.NativeMethodInfoPtr_get_tile_Public_get_ProceduralTile_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CoordinateProceduralTilePair>.NativeClassPtr, 100667196);
		}

		// Token: 0x17000B9D RID: 2973
		// (get) Token: 0x06002219 RID: 8729 RVA: 0x000DE330 File Offset: 0x000DC530
		public unsafe ProceduralTile tile
		{
			[CallerCount(8)]
			[CachedScanResults(RefRangeStart = 114135, RefRangeEnd = 114143, XrefRangeStart = 114124, XrefRangeEnd = 114135, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CoordinateProceduralTilePair.NativeMethodInfoPtr_get_tile_Public_get_ProceduralTile_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ProceduralTile>(intPtr2) : null;
			}
		}

		// Token: 0x0600221A RID: 8730 RVA: 0x00012E3C File Offset: 0x0001103C
		public CoordinateProceduralTilePair(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x0600221B RID: 8731 RVA: 0x00012E45 File Offset: 0x00011045
		public CoordinateProceduralTilePair() : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CoordinateProceduralTilePair>.NativeClassPtr))
		{
		}

		// Token: 0x17000B9A RID: 2970
		// (get) Token: 0x0600221C RID: 8732 RVA: 0x000DE374 File Offset: 0x000DC574
		// (set) Token: 0x0600221D RID: 8733 RVA: 0x00012E57 File Offset: 0x00011057
		public unsafe Coordinate coord
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CoordinateProceduralTilePair.NativeFieldInfoPtr_coord);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coordinate>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CoordinateProceduralTilePair.NativeFieldInfoPtr_coord), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B9B RID: 2971
		// (get) Token: 0x0600221E RID: 8734 RVA: 0x000DE3A4 File Offset: 0x000DC5A4
		// (set) Token: 0x0600221F RID: 8735 RVA: 0x00012E76 File Offset: 0x00011076
		public unsafe NetworkObject tileParent
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CoordinateProceduralTilePair.NativeFieldInfoPtr_tileParent);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NetworkObject>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CoordinateProceduralTilePair.NativeFieldInfoPtr_tileParent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B9C RID: 2972
		// (get) Token: 0x06002220 RID: 8736 RVA: 0x000DE3D4 File Offset: 0x000DC5D4
		// (set) Token: 0x06002221 RID: 8737 RVA: 0x00012E95 File Offset: 0x00011095
		public unsafe int tileIndex
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CoordinateProceduralTilePair.NativeFieldInfoPtr_tileIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CoordinateProceduralTilePair.NativeFieldInfoPtr_tileIndex)) = value;
			}
		}

		// Token: 0x040016B8 RID: 5816
		private static readonly System.IntPtr NativeFieldInfoPtr_coord;

		// Token: 0x040016B9 RID: 5817
		private static readonly System.IntPtr NativeFieldInfoPtr_tileParent;

		// Token: 0x040016BA RID: 5818
		private static readonly System.IntPtr NativeFieldInfoPtr_tileIndex;

		// Token: 0x040016BB RID: 5819
		private static readonly System.IntPtr NativeMethodInfoPtr_get_tile_Public_get_ProceduralTile_0;
	}
}
