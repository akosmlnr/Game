using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.ConstructableScripts;
using UnityEngine;

namespace Il2CppScheduleOne.Construction.ConstructionMethods
{
	// Token: 0x020004AE RID: 1198
	public class ConstructUpdate_Base : MonoBehaviour
	{
		// Token: 0x060066AC RID: 26284 RVA: 0x001D1E44 File Offset: 0x001D0044
		// Note: this type is marked as 'beforefieldinit'.
		static ConstructUpdate_Base()
		{
			Il2CppClassPointerStore<ConstructUpdate_Base>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Construction.ConstructionMethods", "ConstructUpdate_Base");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ConstructUpdate_Base>.NativeClassPtr);
			ConstructUpdate_Base.NativeFieldInfoPtr_MovedConstructable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConstructUpdate_Base>.NativeClassPtr, "MovedConstructable");
			ConstructUpdate_Base.NativeMethodInfoPtr_get_isMoving_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstructUpdate_Base>.NativeClassPtr, 100676397);
			ConstructUpdate_Base.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstructUpdate_Base>.NativeClassPtr, 100676398);
			ConstructUpdate_Base.NativeMethodInfoPtr_LateUpdate_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstructUpdate_Base>.NativeClassPtr, 100676399);
			ConstructUpdate_Base.NativeMethodInfoPtr_ConstructionStop_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstructUpdate_Base>.NativeClassPtr, 100676400);
			ConstructUpdate_Base.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstructUpdate_Base>.NativeClassPtr, 100676401);
		}

		// Token: 0x17001EBA RID: 7866
		// (get) Token: 0x060066AD RID: 26285 RVA: 0x001D1EEC File Offset: 0x001D00EC
		public unsafe bool isMoving
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 209085, RefRangeEnd = 209088, XrefRangeStart = 209081, XrefRangeEnd = 209085, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr obj = IL2CPP.il2cpp_runtime_invoke(ConstructUpdate_Base.NativeMethodInfoPtr_get_isMoving_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
		}

		// Token: 0x060066AE RID: 26286 RVA: 0x001D1F28 File Offset: 0x001D0128
		[CallerCount(14558)]
		[CachedScanResults(RefRangeStart = 2769, RefRangeEnd = 17327, XrefRangeStart = 2769, XrefRangeEnd = 17327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ConstructUpdate_Base.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060066AF RID: 26287 RVA: 0x001D1F64 File Offset: 0x001D0164
		[CallerCount(14558)]
		[CachedScanResults(RefRangeStart = 2769, RefRangeEnd = 17327, XrefRangeStart = 2769, XrefRangeEnd = 17327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void LateUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ConstructUpdate_Base.NativeMethodInfoPtr_LateUpdate_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060066B0 RID: 26288 RVA: 0x001D1FA0 File Offset: 0x001D01A0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 209092, RefRangeEnd = 209094, XrefRangeStart = 209088, XrefRangeEnd = 209092, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void ConstructionStop()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ConstructUpdate_Base.NativeMethodInfoPtr_ConstructionStop_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060066B1 RID: 26289 RVA: 0x001D1FDC File Offset: 0x001D01DC
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 17651, RefRangeEnd = 17869, XrefRangeStart = 17651, XrefRangeEnd = 17869, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ConstructUpdate_Base() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ConstructUpdate_Base>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConstructUpdate_Base.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060066B2 RID: 26290 RVA: 0x00030504 File Offset: 0x0002E704
		public ConstructUpdate_Base(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001EB9 RID: 7865
		// (get) Token: 0x060066B3 RID: 26291 RVA: 0x001D2018 File Offset: 0x001D0218
		// (set) Token: 0x060066B4 RID: 26292 RVA: 0x0003050D File Offset: 0x0002E70D
		public unsafe Constructable_GridBased MovedConstructable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructUpdate_Base.NativeFieldInfoPtr_MovedConstructable);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Constructable_GridBased>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructUpdate_Base.NativeFieldInfoPtr_MovedConstructable), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400460F RID: 17935
		private static readonly IntPtr NativeFieldInfoPtr_MovedConstructable;

		// Token: 0x04004610 RID: 17936
		private static readonly IntPtr NativeMethodInfoPtr_get_isMoving_Public_get_Boolean_0;

		// Token: 0x04004611 RID: 17937
		private static readonly IntPtr NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0;

		// Token: 0x04004612 RID: 17938
		private static readonly IntPtr NativeMethodInfoPtr_LateUpdate_Protected_Virtual_New_Void_0;

		// Token: 0x04004613 RID: 17939
		private static readonly IntPtr NativeMethodInfoPtr_ConstructionStop_Public_Virtual_New_Void_0;

		// Token: 0x04004614 RID: 17940
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
