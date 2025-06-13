using System;
using Il2CppFishNet.Connection;
using Il2CppFishNet.Object;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Il2CppScheduleOne.ItemFramework
{
	// Token: 0x02000601 RID: 1537
	public class IItemSlotOwner : Il2CppObjectBase
	{
		// Token: 0x06008588 RID: 34184 RVA: 0x0023A014 File Offset: 0x00238214
		// Note: this type is marked as 'beforefieldinit'.
		static IItemSlotOwner()
		{
			Il2CppClassPointerStore<IItemSlotOwner>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.ItemFramework", "IItemSlotOwner");
			IItemSlotOwner.NativeMethodInfoPtr_get_ItemSlots_Public_Abstract_Virtual_New_get_List_1_ItemSlot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IItemSlotOwner>.NativeClassPtr, 100680095);
			IItemSlotOwner.NativeMethodInfoPtr_set_ItemSlots_Public_Abstract_Virtual_New_set_Void_List_1_ItemSlot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IItemSlotOwner>.NativeClassPtr, 100680096);
			IItemSlotOwner.NativeMethodInfoPtr_SetStoredInstance_Public_Abstract_Virtual_New_Void_NetworkConnection_Int32_ItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IItemSlotOwner>.NativeClassPtr, 100680097);
			IItemSlotOwner.NativeMethodInfoPtr_SetItemSlotQuantity_Public_Abstract_Virtual_New_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IItemSlotOwner>.NativeClassPtr, 100680098);
			IItemSlotOwner.NativeMethodInfoPtr_SetSlotLocked_Public_Abstract_Virtual_New_Void_NetworkConnection_Int32_Boolean_NetworkObject_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IItemSlotOwner>.NativeClassPtr, 100680099);
			IItemSlotOwner.NativeMethodInfoPtr_SetSlotFilter_Public_Abstract_Virtual_New_Void_NetworkConnection_Int32_SlotFilter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IItemSlotOwner>.NativeClassPtr, 100680100);
			IItemSlotOwner.NativeMethodInfoPtr_SendItemSlotDataToClient_Public_Virtual_New_Void_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IItemSlotOwner>.NativeClassPtr, 100680101);
			IItemSlotOwner.NativeMethodInfoPtr_GetTotalItemCount_Public_Virtual_New_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IItemSlotOwner>.NativeClassPtr, 100680102);
			IItemSlotOwner.NativeMethodInfoPtr_GetItemCount_Public_Virtual_New_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IItemSlotOwner>.NativeClassPtr, 100680103);
		}

		// Token: 0x1700282C RID: 10284
		// (get) Token: 0x06008589 RID: 34185 RVA: 0x0023A0F0 File Offset: 0x002382F0
		// (set) Token: 0x0600858A RID: 34186 RVA: 0x0023A13C File Offset: 0x0023833C
		public unsafe virtual List<ItemSlot> ItemSlots
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IItemSlotOwner.NativeMethodInfoPtr_get_ItemSlots_Public_Abstract_Virtual_New_get_List_1_ItemSlot_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ItemSlot>>(intPtr2) : null;
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IItemSlotOwner.NativeMethodInfoPtr_set_ItemSlots_Public_Abstract_Virtual_New_set_Void_List_1_ItemSlot_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x0600858B RID: 34187 RVA: 0x0023A18C File Offset: 0x0023838C
		[CallerCount(0)]
		public unsafe virtual void SetStoredInstance(NetworkConnection conn, int itemSlotIndex, ItemInstance instance)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref itemSlotIndex;
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(instance);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IItemSlotOwner.NativeMethodInfoPtr_SetStoredInstance_Public_Abstract_Virtual_New_Void_NetworkConnection_Int32_ItemInstance_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600858C RID: 34188 RVA: 0x0023A1FC File Offset: 0x002383FC
		[CallerCount(0)]
		public unsafe virtual void SetItemSlotQuantity(int itemSlotIndex, int quantity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref itemSlotIndex;
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref quantity;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IItemSlotOwner.NativeMethodInfoPtr_SetItemSlotQuantity_Public_Abstract_Virtual_New_Void_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600858D RID: 34189 RVA: 0x0023A254 File Offset: 0x00238454
		[CallerCount(0)]
		public unsafe virtual void SetSlotLocked(NetworkConnection conn, int itemSlotIndex, bool locked, NetworkObject lockOwner, string lockReason)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)5) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref itemSlotIndex;
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref locked;
			ptr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(lockOwner);
			ptr[checked(unchecked((System.UIntPtr)4) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(lockReason);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IItemSlotOwner.NativeMethodInfoPtr_SetSlotLocked_Public_Abstract_Virtual_New_Void_NetworkConnection_Int32_Boolean_NetworkObject_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600858E RID: 34190 RVA: 0x0023A2E4 File Offset: 0x002384E4
		[CallerCount(0)]
		public unsafe virtual void SetSlotFilter(NetworkConnection conn, int itemSlotIndex, SlotFilter filter)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref itemSlotIndex;
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(filter);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IItemSlotOwner.NativeMethodInfoPtr_SetSlotFilter_Public_Abstract_Virtual_New_Void_NetworkConnection_Int32_SlotFilter_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600858F RID: 34191 RVA: 0x0023A354 File Offset: 0x00238554
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 250966, XrefRangeEnd = 251010, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SendItemSlotDataToClient(NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IItemSlotOwner.NativeMethodInfoPtr_SendItemSlotDataToClient_Public_Virtual_New_Void_NetworkConnection_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008590 RID: 34192 RVA: 0x0023A3A4 File Offset: 0x002385A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 251010, XrefRangeEnd = 251031, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual int GetTotalItemCount()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IItemSlotOwner.NativeMethodInfoPtr_GetTotalItemCount_Public_Virtual_New_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06008591 RID: 34193 RVA: 0x0023A3EC File Offset: 0x002385EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 251031, XrefRangeEnd = 251053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual int GetItemCount(string id)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(id);
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IItemSlotOwner.NativeMethodInfoPtr_GetItemCount_Public_Virtual_New_Int32_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06008592 RID: 34194 RVA: 0x0003F29D File Offset: 0x0003D49D
		public IItemSlotOwner(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04005AE7 RID: 23271
		private static readonly System.IntPtr NativeMethodInfoPtr_get_ItemSlots_Public_Abstract_Virtual_New_get_List_1_ItemSlot_0;

		// Token: 0x04005AE8 RID: 23272
		private static readonly System.IntPtr NativeMethodInfoPtr_set_ItemSlots_Public_Abstract_Virtual_New_set_Void_List_1_ItemSlot_0;

		// Token: 0x04005AE9 RID: 23273
		private static readonly System.IntPtr NativeMethodInfoPtr_SetStoredInstance_Public_Abstract_Virtual_New_Void_NetworkConnection_Int32_ItemInstance_0;

		// Token: 0x04005AEA RID: 23274
		private static readonly System.IntPtr NativeMethodInfoPtr_SetItemSlotQuantity_Public_Abstract_Virtual_New_Void_Int32_Int32_0;

		// Token: 0x04005AEB RID: 23275
		private static readonly System.IntPtr NativeMethodInfoPtr_SetSlotLocked_Public_Abstract_Virtual_New_Void_NetworkConnection_Int32_Boolean_NetworkObject_String_0;

		// Token: 0x04005AEC RID: 23276
		private static readonly System.IntPtr NativeMethodInfoPtr_SetSlotFilter_Public_Abstract_Virtual_New_Void_NetworkConnection_Int32_SlotFilter_0;

		// Token: 0x04005AED RID: 23277
		private static readonly System.IntPtr NativeMethodInfoPtr_SendItemSlotDataToClient_Public_Virtual_New_Void_NetworkConnection_0;

		// Token: 0x04005AEE RID: 23278
		private static readonly System.IntPtr NativeMethodInfoPtr_GetTotalItemCount_Public_Virtual_New_Int32_0;

		// Token: 0x04005AEF RID: 23279
		private static readonly System.IntPtr NativeMethodInfoPtr_GetItemCount_Public_Virtual_New_Int32_String_0;

		// Token: 0x02000B34 RID: 2868
		[ObfuscatedName("ScheduleOne.ItemFramework.IItemSlotOwner+<>c")]
		[System.Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x0600DA69 RID: 55913 RVA: 0x003433E0 File Offset: 0x003415E0
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<IItemSlotOwner.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<IItemSlotOwner>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IItemSlotOwner.__c>.NativeClassPtr);
				IItemSlotOwner.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IItemSlotOwner.__c>.NativeClassPtr, "<>9");
				IItemSlotOwner.__c.NativeFieldInfoPtr___9__8_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IItemSlotOwner.__c>.NativeClassPtr, "<>9__8_0");
				IItemSlotOwner.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IItemSlotOwner.__c>.NativeClassPtr, 100680105);
				IItemSlotOwner.__c.NativeMethodInfoPtr__GetTotalItemCount_b__8_0_Internal_Int32_ItemSlot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IItemSlotOwner.__c>.NativeClassPtr, 100680106);
			}

			// Token: 0x0600DA6A RID: 55914 RVA: 0x0034345C File Offset: 0x0034165C
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IItemSlotOwner.__c>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IItemSlotOwner.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600DA6B RID: 55915 RVA: 0x00343498 File Offset: 0x00341698
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 250964, XrefRangeEnd = 250966, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _GetTotalItemCount_b__8_0(ItemSlot x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(IItemSlotOwner.__c.NativeMethodInfoPtr__GetTotalItemCount_b__8_0_Internal_Int32_ItemSlot_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x0600DA6C RID: 55916 RVA: 0x00069F28 File Offset: 0x00068128
			public __c(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700435F RID: 17247
			// (get) Token: 0x0600DA6D RID: 55917 RVA: 0x003434E8 File Offset: 0x003416E8
			// (set) Token: 0x0600DA6E RID: 55918 RVA: 0x00069F31 File Offset: 0x00068131
			public unsafe static IItemSlotOwner.__c __9
			{
				get
				{
					System.IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(IItemSlotOwner.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IItemSlotOwner.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(IItemSlotOwner.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004360 RID: 17248
			// (get) Token: 0x0600DA6F RID: 55919 RVA: 0x00343510 File Offset: 0x00341710
			// (set) Token: 0x0600DA70 RID: 55920 RVA: 0x00069F43 File Offset: 0x00068143
			public unsafe static Il2CppSystem.Func<ItemSlot, int> __9__8_0
			{
				get
				{
					System.IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(IItemSlotOwner.__c.NativeFieldInfoPtr___9__8_0, (void*)(&intPtr));
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Func<ItemSlot, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(IItemSlotOwner.__c.NativeFieldInfoPtr___9__8_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009301 RID: 37633
			private static readonly System.IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04009302 RID: 37634
			private static readonly System.IntPtr NativeFieldInfoPtr___9__8_0;

			// Token: 0x04009303 RID: 37635
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009304 RID: 37636
			private static readonly System.IntPtr NativeMethodInfoPtr__GetTotalItemCount_b__8_0_Internal_Int32_ItemSlot_0;
		}
	}
}
