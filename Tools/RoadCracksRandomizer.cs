using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.Tools
{
	// Token: 0x0200056E RID: 1390
	public class RoadCracksRandomizer : MonoBehaviour
	{
		// Token: 0x060079BE RID: 31166 RVA: 0x00211B18 File Offset: 0x0020FD18
		// Note: this type is marked as 'beforefieldinit'.
		static RoadCracksRandomizer()
		{
			Il2CppClassPointerStore<RoadCracksRandomizer>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Tools", "RoadCracksRandomizer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RoadCracksRandomizer>.NativeClassPtr);
			RoadCracksRandomizer.NativeFieldInfoPtr_Cracks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoadCracksRandomizer>.NativeClassPtr, "Cracks");
			RoadCracksRandomizer.NativeFieldInfoPtr_MinCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoadCracksRandomizer>.NativeClassPtr, "MinCount");
			RoadCracksRandomizer.NativeFieldInfoPtr_MaxCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoadCracksRandomizer>.NativeClassPtr, "MaxCount");
			RoadCracksRandomizer.NativeMethodInfoPtr_Randomize_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RoadCracksRandomizer>.NativeClassPtr, 100678715);
			RoadCracksRandomizer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RoadCracksRandomizer>.NativeClassPtr, 100678716);
		}

		// Token: 0x060079BF RID: 31167 RVA: 0x00211BAC File Offset: 0x0020FDAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 235709, XrefRangeEnd = 235734, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Randomize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RoadCracksRandomizer.NativeMethodInfoPtr_Randomize_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060079C0 RID: 31168 RVA: 0x00211BE0 File Offset: 0x0020FDE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 235734, XrefRangeEnd = 235735, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RoadCracksRandomizer() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RoadCracksRandomizer>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RoadCracksRandomizer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060079C1 RID: 31169 RVA: 0x00039692 File Offset: 0x00037892
		public RoadCracksRandomizer(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002497 RID: 9367
		// (get) Token: 0x060079C2 RID: 31170 RVA: 0x00211C1C File Offset: 0x0020FE1C
		// (set) Token: 0x060079C3 RID: 31171 RVA: 0x0003969B File Offset: 0x0003789B
		public unsafe Il2CppReferenceArray<Transform> Cracks
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RoadCracksRandomizer.NativeFieldInfoPtr_Cracks);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Transform>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RoadCracksRandomizer.NativeFieldInfoPtr_Cracks), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002498 RID: 9368
		// (get) Token: 0x060079C4 RID: 31172 RVA: 0x00211C4C File Offset: 0x0020FE4C
		// (set) Token: 0x060079C5 RID: 31173 RVA: 0x000396BA File Offset: 0x000378BA
		public unsafe int MinCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RoadCracksRandomizer.NativeFieldInfoPtr_MinCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RoadCracksRandomizer.NativeFieldInfoPtr_MinCount)) = value;
			}
		}

		// Token: 0x17002499 RID: 9369
		// (get) Token: 0x060079C6 RID: 31174 RVA: 0x00211C74 File Offset: 0x0020FE74
		// (set) Token: 0x060079C7 RID: 31175 RVA: 0x000396D5 File Offset: 0x000378D5
		public unsafe int MaxCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RoadCracksRandomizer.NativeFieldInfoPtr_MaxCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RoadCracksRandomizer.NativeFieldInfoPtr_MaxCount)) = value;
			}
		}

		// Token: 0x04005312 RID: 21266
		private static readonly IntPtr NativeFieldInfoPtr_Cracks;

		// Token: 0x04005313 RID: 21267
		private static readonly IntPtr NativeFieldInfoPtr_MinCount;

		// Token: 0x04005314 RID: 21268
		private static readonly IntPtr NativeFieldInfoPtr_MaxCount;

		// Token: 0x04005315 RID: 21269
		private static readonly IntPtr NativeMethodInfoPtr_Randomize_Private_Void_0;

		// Token: 0x04005316 RID: 21270
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
