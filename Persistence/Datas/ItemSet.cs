using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.ItemFramework;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Il2CppScheduleOne.Persistence.Datas
{
	// Token: 0x02000270 RID: 624
	[System.Serializable]
	public class ItemSet : Il2CppSystem.Object
	{
		// Token: 0x06002FC7 RID: 12231 RVA: 0x0010C700 File Offset: 0x0010A900
		// Note: this type is marked as 'beforefieldinit'.
		static ItemSet()
		{
			Il2CppClassPointerStore<ItemSet>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Datas", "ItemSet");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ItemSet>.NativeClassPtr);
			ItemSet.NativeFieldInfoPtr_Items = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemSet>.NativeClassPtr, "Items");
			ItemSet.NativeFieldInfoPtr_SlotFilters = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemSet>.NativeClassPtr, "SlotFilters");
			ItemSet.NativeMethodInfoPtr__ctor_Public_Void_List_1_ItemData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSet>.NativeClassPtr, 100668947);
			ItemSet.NativeMethodInfoPtr_GetJSON_Public_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSet>.NativeClassPtr, 100668948);
			ItemSet.NativeMethodInfoPtr__ctor_Public_Void_List_1_ItemSlot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSet>.NativeClassPtr, 100668949);
			ItemSet.NativeMethodInfoPtr__ctor_Public_Void_Il2CppReferenceArray_1_ItemSlot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSet>.NativeClassPtr, 100668950);
			ItemSet.NativeMethodInfoPtr_LoadTo_Public_Void_List_1_ItemSlot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSet>.NativeClassPtr, 100668951);
			ItemSet.NativeMethodInfoPtr_LoadTo_Public_Void_Il2CppReferenceArray_1_ItemSlot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSet>.NativeClassPtr, 100668952);
			ItemSet.NativeMethodInfoPtr_LoadTo_Public_Void_ItemSlot_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSet>.NativeClassPtr, 100668953);
			ItemSet.NativeMethodInfoPtr_TryDeserialize_Public_Static_Boolean_String_byref_DeserializedItemSet_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSet>.NativeClassPtr, 100668954);
			ItemSet.NativeMethodInfoPtr_TryDeserialize_Public_Static_Boolean_ItemSet_byref_DeserializedItemSet_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSet>.NativeClassPtr, 100668955);
		}

		// Token: 0x06002FC8 RID: 12232 RVA: 0x0010C80C File Offset: 0x0010AA0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 136021, XrefRangeEnd = 136032, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ItemSet(List<ItemData> items) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ItemSet>.NativeClassPtr))
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(items);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSet.NativeMethodInfoPtr__ctor_Public_Void_List_1_ItemData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06002FC9 RID: 12233 RVA: 0x0010C858 File Offset: 0x0010AA58
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 136033, RefRangeEnd = 136036, XrefRangeStart = 136032, XrefRangeEnd = 136033, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetJSON()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(ItemSet.NativeMethodInfoPtr_GetJSON_Public_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return IL2CPP.Il2CppStringToManaged(il2CppString);
		}

		// Token: 0x06002FCA RID: 12234 RVA: 0x0010C890 File Offset: 0x0010AA90
		[CallerCount(25)]
		[CachedScanResults(RefRangeStart = 136069, RefRangeEnd = 136094, XrefRangeStart = 136036, XrefRangeEnd = 136069, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ItemSet(List<ItemSlot> itemSlots) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ItemSet>.NativeClassPtr))
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(itemSlots);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSet.NativeMethodInfoPtr__ctor_Public_Void_List_1_ItemSlot_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06002FCB RID: 12235 RVA: 0x0010C8DC File Offset: 0x0010AADC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 136117, RefRangeEnd = 136119, XrefRangeStart = 136094, XrefRangeEnd = 136117, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ItemSet(Il2CppReferenceArray<ItemSlot> itemSlots) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ItemSet>.NativeClassPtr))
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(itemSlots);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSet.NativeMethodInfoPtr__ctor_Public_Void_Il2CppReferenceArray_1_ItemSlot_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06002FCC RID: 12236 RVA: 0x0010C928 File Offset: 0x0010AB28
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 136128, RefRangeEnd = 136142, XrefRangeStart = 136119, XrefRangeEnd = 136128, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LoadTo(List<ItemSlot> slots)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(slots);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSet.NativeMethodInfoPtr_LoadTo_Public_Void_List_1_ItemSlot_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06002FCD RID: 12237 RVA: 0x0010C96C File Offset: 0x0010AB6C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 136146, RefRangeEnd = 136150, XrefRangeStart = 136142, XrefRangeEnd = 136146, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LoadTo(Il2CppReferenceArray<ItemSlot> slots)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(slots);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSet.NativeMethodInfoPtr_LoadTo_Public_Void_Il2CppReferenceArray_1_ItemSlot_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06002FCE RID: 12238 RVA: 0x0010C9B0 File Offset: 0x0010ABB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 136150, XrefRangeEnd = 136152, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LoadTo(ItemSlot slot, int index = 0)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(slot);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref index;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSet.NativeMethodInfoPtr_LoadTo_Public_Void_ItemSlot_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06002FCF RID: 12239 RVA: 0x0010CA00 File Offset: 0x0010AC00
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 136170, RefRangeEnd = 136175, XrefRangeStart = 136152, XrefRangeEnd = 136170, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool TryDeserialize(string json, out DeserializedItemSet itemSet)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(json);
			ref System.IntPtr ptr2 = ref ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)];
			System.IntPtr intPtr = 0;
			ptr2 = &intPtr;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(ItemSet.NativeMethodInfoPtr_TryDeserialize_Public_Static_Boolean_String_byref_DeserializedItemSet_0, 0, (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			itemSet = ((intPtr2 == 0) ? null : new DeserializedItemSet(intPtr2));
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06002FD0 RID: 12240 RVA: 0x0010CA64 File Offset: 0x0010AC64
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 136197, RefRangeEnd = 136199, XrefRangeStart = 136175, XrefRangeEnd = 136197, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool TryDeserialize(ItemSet set, out DeserializedItemSet itemSet)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(set);
			ref System.IntPtr ptr2 = ref ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)];
			System.IntPtr intPtr = 0;
			ptr2 = &intPtr;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(ItemSet.NativeMethodInfoPtr_TryDeserialize_Public_Static_Boolean_ItemSet_byref_DeserializedItemSet_0, 0, (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			itemSet = ((intPtr2 == 0) ? null : new DeserializedItemSet(intPtr2));
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06002FD1 RID: 12241 RVA: 0x00018FC5 File Offset: 0x000171C5
		public ItemSet(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000F81 RID: 3969
		// (get) Token: 0x06002FD2 RID: 12242 RVA: 0x0010CAC8 File Offset: 0x0010ACC8
		// (set) Token: 0x06002FD3 RID: 12243 RVA: 0x00018FCE File Offset: 0x000171CE
		public unsafe Il2CppStringArray Items
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ItemSet.NativeFieldInfoPtr_Items);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ItemSet.NativeFieldInfoPtr_Items), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000F82 RID: 3970
		// (get) Token: 0x06002FD4 RID: 12244 RVA: 0x0010CAF8 File Offset: 0x0010ACF8
		// (set) Token: 0x06002FD5 RID: 12245 RVA: 0x00018FED File Offset: 0x000171ED
		public unsafe Il2CppReferenceArray<SlotFilter> SlotFilters
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ItemSet.NativeFieldInfoPtr_SlotFilters);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<SlotFilter>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ItemSet.NativeFieldInfoPtr_SlotFilters), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001FA6 RID: 8102
		private static readonly System.IntPtr NativeFieldInfoPtr_Items;

		// Token: 0x04001FA7 RID: 8103
		private static readonly System.IntPtr NativeFieldInfoPtr_SlotFilters;

		// Token: 0x04001FA8 RID: 8104
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_List_1_ItemData_0;

		// Token: 0x04001FA9 RID: 8105
		private static readonly System.IntPtr NativeMethodInfoPtr_GetJSON_Public_String_0;

		// Token: 0x04001FAA RID: 8106
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_List_1_ItemSlot_0;

		// Token: 0x04001FAB RID: 8107
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Il2CppReferenceArray_1_ItemSlot_0;

		// Token: 0x04001FAC RID: 8108
		private static readonly System.IntPtr NativeMethodInfoPtr_LoadTo_Public_Void_List_1_ItemSlot_0;

		// Token: 0x04001FAD RID: 8109
		private static readonly System.IntPtr NativeMethodInfoPtr_LoadTo_Public_Void_Il2CppReferenceArray_1_ItemSlot_0;

		// Token: 0x04001FAE RID: 8110
		private static readonly System.IntPtr NativeMethodInfoPtr_LoadTo_Public_Void_ItemSlot_Int32_0;

		// Token: 0x04001FAF RID: 8111
		private static readonly System.IntPtr NativeMethodInfoPtr_TryDeserialize_Public_Static_Boolean_String_byref_DeserializedItemSet_0;

		// Token: 0x04001FB0 RID: 8112
		private static readonly System.IntPtr NativeMethodInfoPtr_TryDeserialize_Public_Static_Boolean_ItemSet_byref_DeserializedItemSet_0;
	}
}
