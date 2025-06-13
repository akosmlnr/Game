using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.ItemFramework;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Il2CppScheduleOne.Management
{
	// Token: 0x020003C5 RID: 965
	public class ManagementItemFilter : Il2CppSystem.Object
	{
		// Token: 0x06004A90 RID: 19088 RVA: 0x0016D0B0 File Offset: 0x0016B2B0
		// Note: this type is marked as 'beforefieldinit'.
		static ManagementItemFilter()
		{
			Il2CppClassPointerStore<ManagementItemFilter>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Management", "ManagementItemFilter");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ManagementItemFilter>.NativeClassPtr);
			ManagementItemFilter.NativeFieldInfoPtr__Mode_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManagementItemFilter>.NativeClassPtr, "<Mode>k__BackingField");
			ManagementItemFilter.NativeFieldInfoPtr__Items_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManagementItemFilter>.NativeClassPtr, "<Items>k__BackingField");
			ManagementItemFilter.NativeMethodInfoPtr_get_Mode_Public_get_EMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagementItemFilter>.NativeClassPtr, 100672617);
			ManagementItemFilter.NativeMethodInfoPtr_set_Mode_Private_set_Void_EMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagementItemFilter>.NativeClassPtr, 100672618);
			ManagementItemFilter.NativeMethodInfoPtr_get_Items_Public_get_List_1_ItemDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagementItemFilter>.NativeClassPtr, 100672619);
			ManagementItemFilter.NativeMethodInfoPtr_set_Items_Private_set_Void_List_1_ItemDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagementItemFilter>.NativeClassPtr, 100672620);
			ManagementItemFilter.NativeMethodInfoPtr__ctor_Public_Void_EMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagementItemFilter>.NativeClassPtr, 100672621);
			ManagementItemFilter.NativeMethodInfoPtr_SetMode_Public_Void_EMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagementItemFilter>.NativeClassPtr, 100672622);
			ManagementItemFilter.NativeMethodInfoPtr_AddItem_Public_Void_ItemDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagementItemFilter>.NativeClassPtr, 100672623);
			ManagementItemFilter.NativeMethodInfoPtr_RemoveItem_Public_Void_ItemDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagementItemFilter>.NativeClassPtr, 100672624);
			ManagementItemFilter.NativeMethodInfoPtr_Contains_Public_Boolean_ItemDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagementItemFilter>.NativeClassPtr, 100672625);
			ManagementItemFilter.NativeMethodInfoPtr_DoesItemMeetFilter_Public_Boolean_ItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagementItemFilter>.NativeClassPtr, 100672626);
			ManagementItemFilter.NativeMethodInfoPtr_GetDescription_Public_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagementItemFilter>.NativeClassPtr, 100672627);
		}

		// Token: 0x1700163E RID: 5694
		// (get) Token: 0x06004A91 RID: 19089 RVA: 0x0016D1E4 File Offset: 0x0016B3E4
		// (set) Token: 0x06004A92 RID: 19090 RVA: 0x0016D220 File Offset: 0x0016B420
		public unsafe ManagementItemFilter.EMode Mode
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 31404, RefRangeEnd = 31405, XrefRangeStart = 31404, XrefRangeEnd = 31405, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(ManagementItemFilter.NativeMethodInfoPtr_get_Mode_Public_get_EMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 31405, RefRangeEnd = 31411, XrefRangeStart = 31405, XrefRangeEnd = 31411, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = ref value;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManagementItemFilter.NativeMethodInfoPtr_set_Mode_Private_set_Void_EMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x1700163F RID: 5695
		// (get) Token: 0x06004A93 RID: 19091 RVA: 0x0016D260 File Offset: 0x0016B460
		// (set) Token: 0x06004A94 RID: 19092 RVA: 0x0016D2A0 File Offset: 0x0016B4A0
		public unsafe List<ItemDefinition> Items
		{
			[CallerCount(24)]
			[CachedScanResults(RefRangeStart = 2740, RefRangeEnd = 2764, XrefRangeStart = 2740, XrefRangeEnd = 2764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManagementItemFilter.NativeMethodInfoPtr_get_Items_Public_get_List_1_ItemDefinition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ItemDefinition>>(intPtr2) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManagementItemFilter.NativeMethodInfoPtr_set_Items_Private_set_Void_List_1_ItemDefinition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x06004A95 RID: 19093 RVA: 0x0016D2E4 File Offset: 0x0016B4E4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 167563, RefRangeEnd = 167565, XrefRangeStart = 167550, XrefRangeEnd = 167563, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ManagementItemFilter(ManagementItemFilter.EMode mode) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ManagementItemFilter>.NativeClassPtr))
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref mode;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManagementItemFilter.NativeMethodInfoPtr__ctor_Public_Void_EMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004A96 RID: 19094 RVA: 0x0016D32C File Offset: 0x0016B52C
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 31405, RefRangeEnd = 31411, XrefRangeStart = 31405, XrefRangeEnd = 31411, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetMode(ManagementItemFilter.EMode mode)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref mode;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManagementItemFilter.NativeMethodInfoPtr_SetMode_Public_Void_EMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004A97 RID: 19095 RVA: 0x0016D36C File Offset: 0x0016B56C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 167571, RefRangeEnd = 167573, XrefRangeStart = 167565, XrefRangeEnd = 167571, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddItem(ItemDefinition item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManagementItemFilter.NativeMethodInfoPtr_AddItem_Public_Void_ItemDefinition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004A98 RID: 19096 RVA: 0x0016D3B0 File Offset: 0x0016B5B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 167573, XrefRangeEnd = 167577, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveItem(ItemDefinition item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManagementItemFilter.NativeMethodInfoPtr_RemoveItem_Public_Void_ItemDefinition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004A99 RID: 19097 RVA: 0x0016D3F4 File Offset: 0x0016B5F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 167577, XrefRangeEnd = 167581, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Contains(ItemDefinition item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(ManagementItemFilter.NativeMethodInfoPtr_Contains_Public_Boolean_ItemDefinition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06004A9A RID: 19098 RVA: 0x0016D444 File Offset: 0x0016B644
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 167588, RefRangeEnd = 167589, XrefRangeStart = 167581, XrefRangeEnd = 167588, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool DoesItemMeetFilter(ItemInstance item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(ManagementItemFilter.NativeMethodInfoPtr_DoesItemMeetFilter_Public_Boolean_ItemInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06004A9B RID: 19099 RVA: 0x0016D494 File Offset: 0x0016B694
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 167589, XrefRangeEnd = 167597, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetDescription()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(ManagementItemFilter.NativeMethodInfoPtr_GetDescription_Public_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return IL2CPP.Il2CppStringToManaged(il2CppString);
		}

		// Token: 0x06004A9C RID: 19100 RVA: 0x00023C81 File Offset: 0x00021E81
		public ManagementItemFilter(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700163C RID: 5692
		// (get) Token: 0x06004A9D RID: 19101 RVA: 0x0016D4CC File Offset: 0x0016B6CC
		// (set) Token: 0x06004A9E RID: 19102 RVA: 0x00023C8A File Offset: 0x00021E8A
		public unsafe ManagementItemFilter.EMode _Mode_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementItemFilter.NativeFieldInfoPtr__Mode_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementItemFilter.NativeFieldInfoPtr__Mode_k__BackingField)) = value;
			}
		}

		// Token: 0x1700163D RID: 5693
		// (get) Token: 0x06004A9F RID: 19103 RVA: 0x0016D4F4 File Offset: 0x0016B6F4
		// (set) Token: 0x06004AA0 RID: 19104 RVA: 0x00023CA5 File Offset: 0x00021EA5
		public unsafe List<ItemDefinition> _Items_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementItemFilter.NativeFieldInfoPtr__Items_k__BackingField);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ItemDefinition>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementItemFilter.NativeFieldInfoPtr__Items_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04003244 RID: 12868
		private static readonly System.IntPtr NativeFieldInfoPtr__Mode_k__BackingField;

		// Token: 0x04003245 RID: 12869
		private static readonly System.IntPtr NativeFieldInfoPtr__Items_k__BackingField;

		// Token: 0x04003246 RID: 12870
		private static readonly System.IntPtr NativeMethodInfoPtr_get_Mode_Public_get_EMode_0;

		// Token: 0x04003247 RID: 12871
		private static readonly System.IntPtr NativeMethodInfoPtr_set_Mode_Private_set_Void_EMode_0;

		// Token: 0x04003248 RID: 12872
		private static readonly System.IntPtr NativeMethodInfoPtr_get_Items_Public_get_List_1_ItemDefinition_0;

		// Token: 0x04003249 RID: 12873
		private static readonly System.IntPtr NativeMethodInfoPtr_set_Items_Private_set_Void_List_1_ItemDefinition_0;

		// Token: 0x0400324A RID: 12874
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_EMode_0;

		// Token: 0x0400324B RID: 12875
		private static readonly System.IntPtr NativeMethodInfoPtr_SetMode_Public_Void_EMode_0;

		// Token: 0x0400324C RID: 12876
		private static readonly System.IntPtr NativeMethodInfoPtr_AddItem_Public_Void_ItemDefinition_0;

		// Token: 0x0400324D RID: 12877
		private static readonly System.IntPtr NativeMethodInfoPtr_RemoveItem_Public_Void_ItemDefinition_0;

		// Token: 0x0400324E RID: 12878
		private static readonly System.IntPtr NativeMethodInfoPtr_Contains_Public_Boolean_ItemDefinition_0;

		// Token: 0x0400324F RID: 12879
		private static readonly System.IntPtr NativeMethodInfoPtr_DoesItemMeetFilter_Public_Boolean_ItemInstance_0;

		// Token: 0x04003250 RID: 12880
		private static readonly System.IntPtr NativeMethodInfoPtr_GetDescription_Public_String_0;

		// Token: 0x020009CA RID: 2506
		[OriginalName("Assembly-CSharp.dll", "", "EMode")]
		public enum EMode
		{
			// Token: 0x04008C1F RID: 35871
			Whitelist,
			// Token: 0x04008C20 RID: 35872
			Blacklist
		}
	}
}
