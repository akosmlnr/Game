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
	// Token: 0x0200026F RID: 623
	public class DeserializedItemSet : Il2CppSystem.Object
	{
		// Token: 0x06002FBD RID: 12221 RVA: 0x0010C4E0 File Offset: 0x0010A6E0
		// Note: this type is marked as 'beforefieldinit'.
		static DeserializedItemSet()
		{
			Il2CppClassPointerStore<DeserializedItemSet>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Datas", "DeserializedItemSet");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DeserializedItemSet>.NativeClassPtr);
			DeserializedItemSet.NativeFieldInfoPtr_Items = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeserializedItemSet>.NativeClassPtr, "Items");
			DeserializedItemSet.NativeFieldInfoPtr_SlotFilters = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeserializedItemSet>.NativeClassPtr, "SlotFilters");
			DeserializedItemSet.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeserializedItemSet>.NativeClassPtr, 100668943);
			DeserializedItemSet.NativeMethodInfoPtr_GetItemAt_Public_ItemInstance_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeserializedItemSet>.NativeClassPtr, 100668944);
			DeserializedItemSet.NativeMethodInfoPtr_GetSlotFilterAt_Public_SlotFilter_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeserializedItemSet>.NativeClassPtr, 100668945);
			DeserializedItemSet.NativeMethodInfoPtr_LoadTo_Public_Void_List_1_ItemSlot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeserializedItemSet>.NativeClassPtr, 100668946);
		}

		// Token: 0x06002FBE RID: 12222 RVA: 0x0010C588 File Offset: 0x0010A788
		[CallerCount(2576)]
		[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DeserializedItemSet() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DeserializedItemSet>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeserializedItemSet.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06002FBF RID: 12223 RVA: 0x0010C5C4 File Offset: 0x0010A7C4
		[CallerCount(0)]
		public unsafe ItemInstance GetItemAt(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref index;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeserializedItemSet.NativeMethodInfoPtr_GetItemAt_Public_ItemInstance_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemInstance>(intPtr2) : null;
		}

		// Token: 0x06002FC0 RID: 12224 RVA: 0x0010C610 File Offset: 0x0010A810
		[CallerCount(0)]
		public unsafe SlotFilter GetSlotFilterAt(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref index;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeserializedItemSet.NativeMethodInfoPtr_GetSlotFilterAt_Public_SlotFilter_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<SlotFilter>(intPtr2) : null;
		}

		// Token: 0x06002FC1 RID: 12225 RVA: 0x0010C65C File Offset: 0x0010A85C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 136018, RefRangeEnd = 136021, XrefRangeStart = 136010, XrefRangeEnd = 136018, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LoadTo(List<ItemSlot> slots)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(slots);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeserializedItemSet.NativeMethodInfoPtr_LoadTo_Public_Void_List_1_ItemSlot_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06002FC2 RID: 12226 RVA: 0x00018F7E File Offset: 0x0001717E
		public DeserializedItemSet(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000F7F RID: 3967
		// (get) Token: 0x06002FC3 RID: 12227 RVA: 0x0010C6A0 File Offset: 0x0010A8A0
		// (set) Token: 0x06002FC4 RID: 12228 RVA: 0x00018F87 File Offset: 0x00017187
		public unsafe Il2CppReferenceArray<ItemInstance> Items
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DeserializedItemSet.NativeFieldInfoPtr_Items);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<ItemInstance>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DeserializedItemSet.NativeFieldInfoPtr_Items), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000F80 RID: 3968
		// (get) Token: 0x06002FC5 RID: 12229 RVA: 0x0010C6D0 File Offset: 0x0010A8D0
		// (set) Token: 0x06002FC6 RID: 12230 RVA: 0x00018FA6 File Offset: 0x000171A6
		public unsafe Il2CppReferenceArray<SlotFilter> SlotFilters
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DeserializedItemSet.NativeFieldInfoPtr_SlotFilters);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<SlotFilter>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DeserializedItemSet.NativeFieldInfoPtr_SlotFilters), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001FA0 RID: 8096
		private static readonly System.IntPtr NativeFieldInfoPtr_Items;

		// Token: 0x04001FA1 RID: 8097
		private static readonly System.IntPtr NativeFieldInfoPtr_SlotFilters;

		// Token: 0x04001FA2 RID: 8098
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04001FA3 RID: 8099
		private static readonly System.IntPtr NativeMethodInfoPtr_GetItemAt_Public_ItemInstance_Int32_0;

		// Token: 0x04001FA4 RID: 8100
		private static readonly System.IntPtr NativeMethodInfoPtr_GetSlotFilterAt_Public_SlotFilter_Int32_0;

		// Token: 0x04001FA5 RID: 8101
		private static readonly System.IntPtr NativeMethodInfoPtr_LoadTo_Public_Void_List_1_ItemSlot_0;
	}
}
