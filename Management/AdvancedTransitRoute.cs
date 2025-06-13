using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.ItemFramework;
using Il2CppScheduleOne.Persistence.Datas;

namespace Il2CppScheduleOne.Management
{
	// Token: 0x020003A1 RID: 929
	public class AdvancedTransitRoute : TransitRoute
	{
		// Token: 0x0600477E RID: 18302 RVA: 0x001608FC File Offset: 0x0015EAFC
		// Note: this type is marked as 'beforefieldinit'.
		static AdvancedTransitRoute()
		{
			Il2CppClassPointerStore<AdvancedTransitRoute>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Management", "AdvancedTransitRoute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AdvancedTransitRoute>.NativeClassPtr);
			AdvancedTransitRoute.NativeFieldInfoPtr__Filter_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AdvancedTransitRoute>.NativeClassPtr, "<Filter>k__BackingField");
			AdvancedTransitRoute.NativeMethodInfoPtr_get_Filter_Public_get_ManagementItemFilter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AdvancedTransitRoute>.NativeClassPtr, 100672160);
			AdvancedTransitRoute.NativeMethodInfoPtr_set_Filter_Private_set_Void_ManagementItemFilter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AdvancedTransitRoute>.NativeClassPtr, 100672161);
			AdvancedTransitRoute.NativeMethodInfoPtr__ctor_Public_Void_ITransitEntity_ITransitEntity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AdvancedTransitRoute>.NativeClassPtr, 100672162);
			AdvancedTransitRoute.NativeMethodInfoPtr__ctor_Public_Void_AdvancedTransitRouteData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AdvancedTransitRoute>.NativeClassPtr, 100672163);
			AdvancedTransitRoute.NativeMethodInfoPtr_GetItemReadyToMove_Public_ItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AdvancedTransitRoute>.NativeClassPtr, 100672164);
			AdvancedTransitRoute.NativeMethodInfoPtr_GetData_Public_AdvancedTransitRouteData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AdvancedTransitRoute>.NativeClassPtr, 100672165);
		}

		// Token: 0x1700156A RID: 5482
		// (get) Token: 0x0600477F RID: 18303 RVA: 0x001609B8 File Offset: 0x0015EBB8
		// (set) Token: 0x06004780 RID: 18304 RVA: 0x001609F8 File Offset: 0x0015EBF8
		public unsafe ManagementItemFilter Filter
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 21004, RefRangeEnd = 21011, XrefRangeStart = 21004, XrefRangeEnd = 21011, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AdvancedTransitRoute.NativeMethodInfoPtr_get_Filter_Public_get_ManagementItemFilter_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ManagementItemFilter>(intPtr2) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AdvancedTransitRoute.NativeMethodInfoPtr_set_Filter_Private_set_Void_ManagementItemFilter_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x06004781 RID: 18305 RVA: 0x00160A3C File Offset: 0x0015EC3C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 162701, RefRangeEnd = 162703, XrefRangeStart = 162695, XrefRangeEnd = 162701, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AdvancedTransitRoute(ITransitEntity source, ITransitEntity destination) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AdvancedTransitRoute>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(destination);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AdvancedTransitRoute.NativeMethodInfoPtr__ctor_Public_Void_ITransitEntity_ITransitEntity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004782 RID: 18306 RVA: 0x00160A9C File Offset: 0x0015EC9C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 162737, RefRangeEnd = 162738, XrefRangeStart = 162703, XrefRangeEnd = 162737, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AdvancedTransitRoute(AdvancedTransitRouteData data) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AdvancedTransitRoute>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AdvancedTransitRoute.NativeMethodInfoPtr__ctor_Public_Void_AdvancedTransitRouteData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004783 RID: 18307 RVA: 0x00160AE8 File Offset: 0x0015ECE8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 162761, RefRangeEnd = 162762, XrefRangeStart = 162738, XrefRangeEnd = 162761, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ItemInstance GetItemReadyToMove()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AdvancedTransitRoute.NativeMethodInfoPtr_GetItemReadyToMove_Public_ItemInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemInstance>(intPtr2) : null;
		}

		// Token: 0x06004784 RID: 18308 RVA: 0x00160B28 File Offset: 0x0015ED28
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 162800, RefRangeEnd = 162802, XrefRangeStart = 162762, XrefRangeEnd = 162800, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AdvancedTransitRouteData GetData()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AdvancedTransitRoute.NativeMethodInfoPtr_GetData_Public_AdvancedTransitRouteData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<AdvancedTransitRouteData>(intPtr2) : null;
		}

		// Token: 0x06004785 RID: 18309 RVA: 0x00022A4C File Offset: 0x00020C4C
		public AdvancedTransitRoute(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001569 RID: 5481
		// (get) Token: 0x06004786 RID: 18310 RVA: 0x00160B68 File Offset: 0x0015ED68
		// (set) Token: 0x06004787 RID: 18311 RVA: 0x00022A55 File Offset: 0x00020C55
		public unsafe ManagementItemFilter _Filter_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AdvancedTransitRoute.NativeFieldInfoPtr__Filter_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ManagementItemFilter>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AdvancedTransitRoute.NativeFieldInfoPtr__Filter_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002FF4 RID: 12276
		private static readonly IntPtr NativeFieldInfoPtr__Filter_k__BackingField;

		// Token: 0x04002FF5 RID: 12277
		private static readonly IntPtr NativeMethodInfoPtr_get_Filter_Public_get_ManagementItemFilter_0;

		// Token: 0x04002FF6 RID: 12278
		private static readonly IntPtr NativeMethodInfoPtr_set_Filter_Private_set_Void_ManagementItemFilter_0;

		// Token: 0x04002FF7 RID: 12279
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ITransitEntity_ITransitEntity_0;

		// Token: 0x04002FF8 RID: 12280
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_AdvancedTransitRouteData_0;

		// Token: 0x04002FF9 RID: 12281
		private static readonly IntPtr NativeMethodInfoPtr_GetItemReadyToMove_Public_ItemInstance_0;

		// Token: 0x04002FFA RID: 12282
		private static readonly IntPtr NativeMethodInfoPtr_GetData_Public_AdvancedTransitRouteData_0;
	}
}
