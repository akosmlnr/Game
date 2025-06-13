using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2CppScheduleOne.Tiles
{
	// Token: 0x020001A4 RID: 420
	public class CoordinatePair : Il2CppSystem.Object
	{
		// Token: 0x06002229 RID: 8745 RVA: 0x000DE4B4 File Offset: 0x000DC6B4
		// Note: this type is marked as 'beforefieldinit'.
		static CoordinatePair()
		{
			Il2CppClassPointerStore<CoordinatePair>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Tiles", "CoordinatePair");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CoordinatePair>.NativeClassPtr);
			CoordinatePair.NativeFieldInfoPtr_coord1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CoordinatePair>.NativeClassPtr, "coord1");
			CoordinatePair.NativeFieldInfoPtr_coord2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CoordinatePair>.NativeClassPtr, "coord2");
			CoordinatePair.NativeMethodInfoPtr__ctor_Public_Void_Coordinate_Coordinate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CoordinatePair>.NativeClassPtr, 100667197);
		}

		// Token: 0x0600222A RID: 8746 RVA: 0x000DE520 File Offset: 0x000DC720
		[CallerCount(51)]
		[CachedScanResults(RefRangeStart = 114146, RefRangeEnd = 114197, XrefRangeStart = 114143, XrefRangeEnd = 114146, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CoordinatePair(Coordinate _c1, Coordinate _c2) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CoordinatePair>.NativeClassPtr))
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(_c1);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(_c2);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CoordinatePair.NativeMethodInfoPtr__ctor_Public_Void_Coordinate_Coordinate_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600222B RID: 8747 RVA: 0x00012F09 File Offset: 0x00011109
		public CoordinatePair(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000BA0 RID: 2976
		// (get) Token: 0x0600222C RID: 8748 RVA: 0x000DE580 File Offset: 0x000DC780
		// (set) Token: 0x0600222D RID: 8749 RVA: 0x00012F12 File Offset: 0x00011112
		public unsafe Coordinate coord1
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CoordinatePair.NativeFieldInfoPtr_coord1);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coordinate>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CoordinatePair.NativeFieldInfoPtr_coord1), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000BA1 RID: 2977
		// (get) Token: 0x0600222E RID: 8750 RVA: 0x000DE5B0 File Offset: 0x000DC7B0
		// (set) Token: 0x0600222F RID: 8751 RVA: 0x00012F31 File Offset: 0x00011131
		public unsafe Coordinate coord2
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CoordinatePair.NativeFieldInfoPtr_coord2);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coordinate>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CoordinatePair.NativeFieldInfoPtr_coord2), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040016BE RID: 5822
		private static readonly System.IntPtr NativeFieldInfoPtr_coord1;

		// Token: 0x040016BF RID: 5823
		private static readonly System.IntPtr NativeFieldInfoPtr_coord2;

		// Token: 0x040016C0 RID: 5824
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Coordinate_Coordinate_0;
	}
}
