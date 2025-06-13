using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Packaging;
using Il2CppSystem.Collections.Generic;

namespace Il2CppScheduleOne.PlayerTasks
{
	// Token: 0x0200021B RID: 539
	public class PackageProductTaskMk2 : Task
	{
		// Token: 0x06002C45 RID: 11333 RVA: 0x000FF918 File Offset: 0x000FDB18
		// Note: this type is marked as 'beforefieldinit'.
		static PackageProductTaskMk2()
		{
			Il2CppClassPointerStore<PackageProductTaskMk2>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.PlayerTasks", "PackageProductTaskMk2");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PackageProductTaskMk2>.NativeClassPtr);
			PackageProductTaskMk2.NativeFieldInfoPtr__TaskName_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackageProductTaskMk2>.NativeClassPtr, "<TaskName>k__BackingField");
			PackageProductTaskMk2.NativeFieldInfoPtr_station = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackageProductTaskMk2>.NativeClassPtr, "station");
			PackageProductTaskMk2.NativeFieldInfoPtr_Packaging = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackageProductTaskMk2>.NativeClassPtr, "Packaging");
			PackageProductTaskMk2.NativeFieldInfoPtr_Products = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackageProductTaskMk2>.NativeClassPtr, "Products");
			PackageProductTaskMk2.NativeMethodInfoPtr_get_TaskName_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackageProductTaskMk2>.NativeClassPtr, 100668308);
			PackageProductTaskMk2.NativeMethodInfoPtr_set_TaskName_Protected_Virtual_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackageProductTaskMk2>.NativeClassPtr, 100668309);
			PackageProductTaskMk2.NativeMethodInfoPtr__ctor_Public_Void_PackagingStationMk2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackageProductTaskMk2>.NativeClassPtr, 100668310);
			PackageProductTaskMk2.NativeMethodInfoPtr_StopTask_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackageProductTaskMk2>.NativeClassPtr, 100668311);
		}

		// Token: 0x17000EA8 RID: 3752
		// (get) Token: 0x06002C46 RID: 11334 RVA: 0x000FF9E8 File Offset: 0x000FDBE8
		// (set) Token: 0x06002C47 RID: 11335 RVA: 0x000FFA2C File Offset: 0x000FDC2C
		public unsafe override string TaskName
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PackageProductTaskMk2.NativeMethodInfoPtr_get_TaskName_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return IL2CPP.Il2CppStringToManaged(il2CppString);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PackageProductTaskMk2.NativeMethodInfoPtr_set_TaskName_Protected_Virtual_set_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x06002C48 RID: 11336 RVA: 0x000FFA7C File Offset: 0x000FDC7C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 125901, RefRangeEnd = 125902, XrefRangeStart = 125837, XrefRangeEnd = 125901, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PackageProductTaskMk2(PackagingStationMk2 _station) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PackageProductTaskMk2>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(_station);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PackageProductTaskMk2.NativeMethodInfoPtr__ctor_Public_Void_PackagingStationMk2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06002C49 RID: 11337 RVA: 0x000FFAC8 File Offset: 0x000FDCC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 125902, XrefRangeEnd = 125929, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void StopTask()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PackageProductTaskMk2.NativeMethodInfoPtr_StopTask_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06002C4A RID: 11338 RVA: 0x00017D8E File Offset: 0x00015F8E
		public PackageProductTaskMk2(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000EA4 RID: 3748
		// (get) Token: 0x06002C4B RID: 11339 RVA: 0x000FFB04 File Offset: 0x000FDD04
		// (set) Token: 0x06002C4C RID: 11340 RVA: 0x00017D97 File Offset: 0x00015F97
		public new unsafe string _TaskName_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackageProductTaskMk2.NativeFieldInfoPtr__TaskName_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackageProductTaskMk2.NativeFieldInfoPtr__TaskName_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000EA5 RID: 3749
		// (get) Token: 0x06002C4D RID: 11341 RVA: 0x000FFB2C File Offset: 0x000FDD2C
		// (set) Token: 0x06002C4E RID: 11342 RVA: 0x00017DB6 File Offset: 0x00015FB6
		public unsafe PackagingStationMk2 station
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackageProductTaskMk2.NativeFieldInfoPtr_station);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PackagingStationMk2>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackageProductTaskMk2.NativeFieldInfoPtr_station), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000EA6 RID: 3750
		// (get) Token: 0x06002C4F RID: 11343 RVA: 0x000FFB5C File Offset: 0x000FDD5C
		// (set) Token: 0x06002C50 RID: 11344 RVA: 0x00017DD5 File Offset: 0x00015FD5
		public unsafe FunctionalPackaging Packaging
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackageProductTaskMk2.NativeFieldInfoPtr_Packaging);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FunctionalPackaging>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackageProductTaskMk2.NativeFieldInfoPtr_Packaging), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000EA7 RID: 3751
		// (get) Token: 0x06002C51 RID: 11345 RVA: 0x000FFB8C File Offset: 0x000FDD8C
		// (set) Token: 0x06002C52 RID: 11346 RVA: 0x00017DF4 File Offset: 0x00015FF4
		public unsafe List<FunctionalProduct> Products
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackageProductTaskMk2.NativeFieldInfoPtr_Products);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<FunctionalProduct>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackageProductTaskMk2.NativeFieldInfoPtr_Products), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001D59 RID: 7513
		private static readonly IntPtr NativeFieldInfoPtr__TaskName_k__BackingField;

		// Token: 0x04001D5A RID: 7514
		private static readonly IntPtr NativeFieldInfoPtr_station;

		// Token: 0x04001D5B RID: 7515
		private static readonly IntPtr NativeFieldInfoPtr_Packaging;

		// Token: 0x04001D5C RID: 7516
		private static readonly IntPtr NativeFieldInfoPtr_Products;

		// Token: 0x04001D5D RID: 7517
		private static readonly IntPtr NativeMethodInfoPtr_get_TaskName_Public_Virtual_get_String_0;

		// Token: 0x04001D5E RID: 7518
		private static readonly IntPtr NativeMethodInfoPtr_set_TaskName_Protected_Virtual_set_Void_String_0;

		// Token: 0x04001D5F RID: 7519
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_PackagingStationMk2_0;

		// Token: 0x04001D60 RID: 7520
		private static readonly IntPtr NativeMethodInfoPtr_StopTask_Public_Virtual_Void_0;
	}
}
