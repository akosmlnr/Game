using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Management;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Il2CppScheduleOne.Persistence.Datas
{
	// Token: 0x0200028B RID: 651
	[System.Serializable]
	public class AdvancedTransitRouteData : Il2CppSystem.Object
	{
		// Token: 0x060030A4 RID: 12452 RVA: 0x0010F13C File Offset: 0x0010D33C
		// Note: this type is marked as 'beforefieldinit'.
		static AdvancedTransitRouteData()
		{
			Il2CppClassPointerStore<AdvancedTransitRouteData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Datas", "AdvancedTransitRouteData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AdvancedTransitRouteData>.NativeClassPtr);
			AdvancedTransitRouteData.NativeFieldInfoPtr_SourceGUID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AdvancedTransitRouteData>.NativeClassPtr, "SourceGUID");
			AdvancedTransitRouteData.NativeFieldInfoPtr_DestinationGUID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AdvancedTransitRouteData>.NativeClassPtr, "DestinationGUID");
			AdvancedTransitRouteData.NativeFieldInfoPtr_FilterMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AdvancedTransitRouteData>.NativeClassPtr, "FilterMode");
			AdvancedTransitRouteData.NativeFieldInfoPtr_FilterItemIDs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AdvancedTransitRouteData>.NativeClassPtr, "FilterItemIDs");
			AdvancedTransitRouteData.NativeMethodInfoPtr__ctor_Public_Void_String_String_EMode_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AdvancedTransitRouteData>.NativeClassPtr, 100669015);
			AdvancedTransitRouteData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AdvancedTransitRouteData>.NativeClassPtr, 100669016);
		}

		// Token: 0x060030A5 RID: 12453 RVA: 0x0010F1E4 File Offset: 0x0010D3E4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 136663, RefRangeEnd = 136664, XrefRangeStart = 136659, XrefRangeEnd = 136663, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AdvancedTransitRouteData(string sourceGUID, string destinationGUID, ManagementItemFilter.EMode filtermode, List<string> filterGUIDs) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AdvancedTransitRouteData>.NativeClassPtr))
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)4) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(sourceGUID);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(destinationGUID);
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref filtermode;
			ptr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(filterGUIDs);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AdvancedTransitRouteData.NativeMethodInfoPtr__ctor_Public_Void_String_String_EMode_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060030A6 RID: 12454 RVA: 0x0010F264 File Offset: 0x0010D464
		[CallerCount(2576)]
		[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AdvancedTransitRouteData() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AdvancedTransitRouteData>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AdvancedTransitRouteData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060030A7 RID: 12455 RVA: 0x000197E4 File Offset: 0x000179E4
		public AdvancedTransitRouteData(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000FB9 RID: 4025
		// (get) Token: 0x060030A8 RID: 12456 RVA: 0x0010F2A0 File Offset: 0x0010D4A0
		// (set) Token: 0x060030A9 RID: 12457 RVA: 0x000197ED File Offset: 0x000179ED
		public unsafe string SourceGUID
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AdvancedTransitRouteData.NativeFieldInfoPtr_SourceGUID);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AdvancedTransitRouteData.NativeFieldInfoPtr_SourceGUID), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000FBA RID: 4026
		// (get) Token: 0x060030AA RID: 12458 RVA: 0x0010F2C8 File Offset: 0x0010D4C8
		// (set) Token: 0x060030AB RID: 12459 RVA: 0x0001980C File Offset: 0x00017A0C
		public unsafe string DestinationGUID
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AdvancedTransitRouteData.NativeFieldInfoPtr_DestinationGUID);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AdvancedTransitRouteData.NativeFieldInfoPtr_DestinationGUID), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000FBB RID: 4027
		// (get) Token: 0x060030AC RID: 12460 RVA: 0x0010F2F0 File Offset: 0x0010D4F0
		// (set) Token: 0x060030AD RID: 12461 RVA: 0x0001982B File Offset: 0x00017A2B
		public unsafe ManagementItemFilter.EMode FilterMode
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AdvancedTransitRouteData.NativeFieldInfoPtr_FilterMode);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AdvancedTransitRouteData.NativeFieldInfoPtr_FilterMode)) = value;
			}
		}

		// Token: 0x17000FBC RID: 4028
		// (get) Token: 0x060030AE RID: 12462 RVA: 0x0010F318 File Offset: 0x0010D518
		// (set) Token: 0x060030AF RID: 12463 RVA: 0x00019846 File Offset: 0x00017A46
		public unsafe List<string> FilterItemIDs
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AdvancedTransitRouteData.NativeFieldInfoPtr_FilterItemIDs);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AdvancedTransitRouteData.NativeFieldInfoPtr_FilterItemIDs), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002015 RID: 8213
		private static readonly System.IntPtr NativeFieldInfoPtr_SourceGUID;

		// Token: 0x04002016 RID: 8214
		private static readonly System.IntPtr NativeFieldInfoPtr_DestinationGUID;

		// Token: 0x04002017 RID: 8215
		private static readonly System.IntPtr NativeFieldInfoPtr_FilterMode;

		// Token: 0x04002018 RID: 8216
		private static readonly System.IntPtr NativeFieldInfoPtr_FilterItemIDs;

		// Token: 0x04002019 RID: 8217
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_String_EMode_List_1_String_0;

		// Token: 0x0400201A RID: 8218
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
