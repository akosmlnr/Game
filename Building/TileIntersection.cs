using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Tiles;
using Il2CppSystem;

namespace Il2CppScheduleOne.Building
{
	// Token: 0x020004DF RID: 1247
	public class TileIntersection : Il2CppSystem.Object
	{
		// Token: 0x06006C21 RID: 27681 RVA: 0x001E5588 File Offset: 0x001E3788
		// Note: this type is marked as 'beforefieldinit'.
		static TileIntersection()
		{
			Il2CppClassPointerStore<TileIntersection>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Building", "TileIntersection");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TileIntersection>.NativeClassPtr);
			TileIntersection.NativeFieldInfoPtr_footprint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileIntersection>.NativeClassPtr, "footprint");
			TileIntersection.NativeFieldInfoPtr_tile = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileIntersection>.NativeClassPtr, "tile");
			TileIntersection.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileIntersection>.NativeClassPtr, 100677124);
		}

		// Token: 0x06006C22 RID: 27682 RVA: 0x001E55F4 File Offset: 0x001E37F4
		[CallerCount(2576)]
		[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TileIntersection() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TileIntersection>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TileIntersection.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006C23 RID: 27683 RVA: 0x00032D22 File Offset: 0x00030F22
		public TileIntersection(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700203F RID: 8255
		// (get) Token: 0x06006C24 RID: 27684 RVA: 0x001E5630 File Offset: 0x001E3830
		// (set) Token: 0x06006C25 RID: 27685 RVA: 0x00032D2B File Offset: 0x00030F2B
		public unsafe FootprintTile footprint
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(TileIntersection.NativeFieldInfoPtr_footprint);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FootprintTile>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(TileIntersection.NativeFieldInfoPtr_footprint), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002040 RID: 8256
		// (get) Token: 0x06006C26 RID: 27686 RVA: 0x001E5660 File Offset: 0x001E3860
		// (set) Token: 0x06006C27 RID: 27687 RVA: 0x00032D4A File Offset: 0x00030F4A
		public unsafe Tile tile
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(TileIntersection.NativeFieldInfoPtr_tile);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Tile>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(TileIntersection.NativeFieldInfoPtr_tile), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04004A0D RID: 18957
		private static readonly System.IntPtr NativeFieldInfoPtr_footprint;

		// Token: 0x04004A0E RID: 18958
		private static readonly System.IntPtr NativeFieldInfoPtr_tile;

		// Token: 0x04004A0F RID: 18959
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
