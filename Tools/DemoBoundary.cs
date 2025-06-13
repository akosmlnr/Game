using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.Tools
{
	// Token: 0x02000557 RID: 1367
	public class DemoBoundary : MonoBehaviour
	{
		// Token: 0x060078C0 RID: 30912 RVA: 0x0020EAA8 File Offset: 0x0020CCA8
		// Note: this type is marked as 'beforefieldinit'.
		static DemoBoundary()
		{
			Il2CppClassPointerStore<DemoBoundary>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Tools", "DemoBoundary");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DemoBoundary>.NativeClassPtr);
			DemoBoundary.NativeFieldInfoPtr_Collider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DemoBoundary>.NativeClassPtr, "Collider");
			DemoBoundary.NativeMethodInfoPtr_OnValidate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DemoBoundary>.NativeClassPtr, 100678597);
			DemoBoundary.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DemoBoundary>.NativeClassPtr, 100678598);
			DemoBoundary.NativeMethodInfoPtr_UpdateBoundary_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DemoBoundary>.NativeClassPtr, 100678599);
			DemoBoundary.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DemoBoundary>.NativeClassPtr, 100678600);
		}

		// Token: 0x060078C1 RID: 30913 RVA: 0x0020EB3C File Offset: 0x0020CD3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 234784, XrefRangeEnd = 234792, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnValidate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DemoBoundary.NativeMethodInfoPtr_OnValidate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060078C2 RID: 30914 RVA: 0x0020EB70 File Offset: 0x0020CD70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 234792, XrefRangeEnd = 234795, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DemoBoundary.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060078C3 RID: 30915 RVA: 0x0020EBA4 File Offset: 0x0020CDA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 234795, XrefRangeEnd = 234811, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateBoundary()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DemoBoundary.NativeMethodInfoPtr_UpdateBoundary_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060078C4 RID: 30916 RVA: 0x0020EBD8 File Offset: 0x0020CDD8
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 17651, RefRangeEnd = 17869, XrefRangeStart = 17651, XrefRangeEnd = 17869, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DemoBoundary() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DemoBoundary>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DemoBoundary.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060078C5 RID: 30917 RVA: 0x00038FCC File Offset: 0x000371CC
		public DemoBoundary(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700245C RID: 9308
		// (get) Token: 0x060078C6 RID: 30918 RVA: 0x0020EC14 File Offset: 0x0020CE14
		// (set) Token: 0x060078C7 RID: 30919 RVA: 0x00038FD5 File Offset: 0x000371D5
		public unsafe Collider Collider
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DemoBoundary.NativeFieldInfoPtr_Collider);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Collider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DemoBoundary.NativeFieldInfoPtr_Collider), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04005278 RID: 21112
		private static readonly IntPtr NativeFieldInfoPtr_Collider;

		// Token: 0x04005279 RID: 21113
		private static readonly IntPtr NativeMethodInfoPtr_OnValidate_Private_Void_0;

		// Token: 0x0400527A RID: 21114
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x0400527B RID: 21115
		private static readonly IntPtr NativeMethodInfoPtr_UpdateBoundary_Private_Void_0;

		// Token: 0x0400527C RID: 21116
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
