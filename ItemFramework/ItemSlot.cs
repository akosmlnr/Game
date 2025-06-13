using System;
using Il2CppFishNet.Object;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Il2CppScheduleOne.ItemFramework
{
	// Token: 0x0200060D RID: 1549
	[System.Serializable]
	public class ItemSlot : Il2CppSystem.Object
	{
		// Token: 0x06008658 RID: 34392 RVA: 0x0023CF0C File Offset: 0x0023B10C
		// Note: this type is marked as 'beforefieldinit'.
		static ItemSlot()
		{
			Il2CppClassPointerStore<ItemSlot>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.ItemFramework", "ItemSlot");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ItemSlot>.NativeClassPtr);
			ItemSlot.NativeFieldInfoPtr__ItemInstance_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemSlot>.NativeClassPtr, "<ItemInstance>k__BackingField");
			ItemSlot.NativeFieldInfoPtr__SlotOwner_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemSlot>.NativeClassPtr, "<SlotOwner>k__BackingField");
			ItemSlot.NativeFieldInfoPtr_onItemDataChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemSlot>.NativeClassPtr, "onItemDataChanged");
			ItemSlot.NativeFieldInfoPtr_onItemInstanceChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemSlot>.NativeClassPtr, "onItemInstanceChanged");
			ItemSlot.NativeFieldInfoPtr__ActiveLock_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemSlot>.NativeClassPtr, "<ActiveLock>k__BackingField");
			ItemSlot.NativeFieldInfoPtr_onLocked = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemSlot>.NativeClassPtr, "onLocked");
			ItemSlot.NativeFieldInfoPtr_onUnlocked = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemSlot>.NativeClassPtr, "onUnlocked");
			ItemSlot.NativeFieldInfoPtr__IsRemovalLocked_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemSlot>.NativeClassPtr, "<IsRemovalLocked>k__BackingField");
			ItemSlot.NativeFieldInfoPtr__IsAddLocked_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemSlot>.NativeClassPtr, "<IsAddLocked>k__BackingField");
			ItemSlot.NativeFieldInfoPtr__HardFilters_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemSlot>.NativeClassPtr, "<HardFilters>k__BackingField");
			ItemSlot.NativeFieldInfoPtr__CanPlayerSetFilter_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemSlot>.NativeClassPtr, "<CanPlayerSetFilter>k__BackingField");
			ItemSlot.NativeFieldInfoPtr__PlayerFilter_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemSlot>.NativeClassPtr, "<PlayerFilter>k__BackingField");
			ItemSlot.NativeFieldInfoPtr_onFilterChange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemSlot>.NativeClassPtr, "onFilterChange");
			ItemSlot.NativeFieldInfoPtr__SiblingSet_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemSlot>.NativeClassPtr, "<SiblingSet>k__BackingField");
			ItemSlot.NativeMethodInfoPtr_get_ItemInstance_Public_get_ItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSlot>.NativeClassPtr, 100680206);
			ItemSlot.NativeMethodInfoPtr_set_ItemInstance_Protected_set_Void_ItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSlot>.NativeClassPtr, 100680207);
			ItemSlot.NativeMethodInfoPtr_get_SlotOwner_Public_get_IItemSlotOwner_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSlot>.NativeClassPtr, 100680208);
			ItemSlot.NativeMethodInfoPtr_set_SlotOwner_Protected_set_Void_IItemSlotOwner_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSlot>.NativeClassPtr, 100680209);
			ItemSlot.NativeMethodInfoPtr_get_SlotIndex_Private_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSlot>.NativeClassPtr, 100680210);
			ItemSlot.NativeMethodInfoPtr_get_Quantity_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSlot>.NativeClassPtr, 100680211);
			ItemSlot.NativeMethodInfoPtr_get_IsAtCapacity_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSlot>.NativeClassPtr, 100680212);
			ItemSlot.NativeMethodInfoPtr_get_IsLocked_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSlot>.NativeClassPtr, 100680213);
			ItemSlot.NativeMethodInfoPtr_get_ActiveLock_Public_get_ItemSlotLock_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSlot>.NativeClassPtr, 100680214);
			ItemSlot.NativeMethodInfoPtr_set_ActiveLock_Protected_set_Void_ItemSlotLock_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSlot>.NativeClassPtr, 100680215);
			ItemSlot.NativeMethodInfoPtr_get_IsRemovalLocked_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSlot>.NativeClassPtr, 100680216);
			ItemSlot.NativeMethodInfoPtr_set_IsRemovalLocked_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSlot>.NativeClassPtr, 100680217);
			ItemSlot.NativeMethodInfoPtr_get_IsAddLocked_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSlot>.NativeClassPtr, 100680218);
			ItemSlot.NativeMethodInfoPtr_set_IsAddLocked_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSlot>.NativeClassPtr, 100680219);
			ItemSlot.NativeMethodInfoPtr_get_HardFilters_Protected_get_List_1_ItemFilter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSlot>.NativeClassPtr, 100680220);
			ItemSlot.NativeMethodInfoPtr_set_HardFilters_Protected_set_Void_List_1_ItemFilter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSlot>.NativeClassPtr, 100680221);
			ItemSlot.NativeMethodInfoPtr_get_CanPlayerSetFilter_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSlot>.NativeClassPtr, 100680222);
			ItemSlot.NativeMethodInfoPtr_set_CanPlayerSetFilter_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSlot>.NativeClassPtr, 100680223);
			ItemSlot.NativeMethodInfoPtr_get_PlayerFilter_Public_get_SlotFilter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSlot>.NativeClassPtr, 100680224);
			ItemSlot.NativeMethodInfoPtr_set_PlayerFilter_Public_set_Void_SlotFilter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSlot>.NativeClassPtr, 100680225);
			ItemSlot.NativeMethodInfoPtr_get_SiblingSet_Public_get_ItemSlotSiblingSet_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSlot>.NativeClassPtr, 100680226);
			ItemSlot.NativeMethodInfoPtr_set_SiblingSet_Public_set_Void_ItemSlotSiblingSet_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSlot>.NativeClassPtr, 100680227);
			ItemSlot.NativeMethodInfoPtr_SetSlotOwner_Public_Void_IItemSlotOwner_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSlot>.NativeClassPtr, 100680228);
			ItemSlot.NativeMethodInfoPtr_SetSiblingSet_Public_Void_ItemSlotSiblingSet_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSlot>.NativeClassPtr, 100680229);
			ItemSlot.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSlot>.NativeClassPtr, 100680230);
			ItemSlot.NativeMethodInfoPtr__ctor_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSlot>.NativeClassPtr, 100680231);
			ItemSlot.NativeMethodInfoPtr_ReplicateStoredInstance_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSlot>.NativeClassPtr, 100680232);
			ItemSlot.NativeMethodInfoPtr_SetStoredItem_Public_Virtual_New_Void_ItemInstance_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSlot>.NativeClassPtr, 100680233);
			ItemSlot.NativeMethodInfoPtr_InsertItem_Public_Virtual_New_Void_ItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSlot>.NativeClassPtr, 100680234);
			ItemSlot.NativeMethodInfoPtr_AddItem_Public_Virtual_New_Void_ItemInstance_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSlot>.NativeClassPtr, 100680235);
			ItemSlot.NativeMethodInfoPtr_ClearStoredInstance_Public_Virtual_New_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSlot>.NativeClassPtr, 100680236);
			ItemSlot.NativeMethodInfoPtr_SetQuantity_Public_Void_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSlot>.NativeClassPtr, 100680237);
			ItemSlot.NativeMethodInfoPtr_ChangeQuantity_Public_Void_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSlot>.NativeClassPtr, 100680238);
			ItemSlot.NativeMethodInfoPtr_ItemDataChanged_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSlot>.NativeClassPtr, 100680239);
			ItemSlot.NativeMethodInfoPtr_ClearItemInstanceRequested_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSlot>.NativeClassPtr, 100680240);
			ItemSlot.NativeMethodInfoPtr_AddFilter_Public_Void_ItemFilter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSlot>.NativeClassPtr, 100680241);
			ItemSlot.NativeMethodInfoPtr_ApplyLock_Public_Void_NetworkObject_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSlot>.NativeClassPtr, 100680242);
			ItemSlot.NativeMethodInfoPtr_RemoveLock_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSlot>.NativeClassPtr, 100680243);
			ItemSlot.NativeMethodInfoPtr_SetIsRemovalLocked_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSlot>.NativeClassPtr, 100680244);
			ItemSlot.NativeMethodInfoPtr_SetIsAddLocked_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSlot>.NativeClassPtr, 100680245);
			ItemSlot.NativeMethodInfoPtr_DoesItemMatchHardFilters_Public_Virtual_New_Boolean_ItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSlot>.NativeClassPtr, 100680246);
			ItemSlot.NativeMethodInfoPtr_DoesItemMatchPlayerFilters_Public_Virtual_New_Boolean_ItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSlot>.NativeClassPtr, 100680247);
			ItemSlot.NativeMethodInfoPtr_SetFilterable_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSlot>.NativeClassPtr, 100680248);
			ItemSlot.NativeMethodInfoPtr_SetPlayerFilter_Public_Void_SlotFilter_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSlot>.NativeClassPtr, 100680249);
			ItemSlot.NativeMethodInfoPtr_GetCapacityForItem_Public_Virtual_New_Int32_ItemInstance_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSlot>.NativeClassPtr, 100680250);
			ItemSlot.NativeMethodInfoPtr_CanSlotAcceptCash_Public_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSlot>.NativeClassPtr, 100680251);
			ItemSlot.NativeMethodInfoPtr_TryInsertItemIntoSet_Public_Static_Boolean_List_1_ItemSlot_ItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSlot>.NativeClassPtr, 100680252);
		}

		// Token: 0x17002870 RID: 10352
		// (get) Token: 0x06008659 RID: 34393 RVA: 0x0023D400 File Offset: 0x0023B600
		// (set) Token: 0x0600865A RID: 34394 RVA: 0x0023D440 File Offset: 0x0023B640
		public unsafe ItemInstance ItemInstance
		{
			[CallerCount(12)]
			[CachedScanResults(RefRangeStart = 18697, RefRangeEnd = 18709, XrefRangeStart = 18697, XrefRangeEnd = 18709, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSlot.NativeMethodInfoPtr_get_ItemInstance_Public_get_ItemInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemInstance>(intPtr2) : null;
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 31460, RefRangeEnd = 31462, XrefRangeStart = 31460, XrefRangeEnd = 31462, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSlot.NativeMethodInfoPtr_set_ItemInstance_Protected_set_Void_ItemInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x17002871 RID: 10353
		// (get) Token: 0x0600865B RID: 34395 RVA: 0x0023D484 File Offset: 0x0023B684
		// (set) Token: 0x0600865C RID: 34396 RVA: 0x0023D4C4 File Offset: 0x0023B6C4
		public unsafe IItemSlotOwner SlotOwner
		{
			[CallerCount(24)]
			[CachedScanResults(RefRangeStart = 2740, RefRangeEnd = 2764, XrefRangeStart = 2740, XrefRangeEnd = 2764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSlot.NativeMethodInfoPtr_get_SlotOwner_Public_get_IItemSlotOwner_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IItemSlotOwner>(intPtr2) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSlot.NativeMethodInfoPtr_set_SlotOwner_Protected_set_Void_IItemSlotOwner_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x17002872 RID: 10354
		// (get) Token: 0x0600865D RID: 34397 RVA: 0x0023D508 File Offset: 0x0023B708
		public unsafe int SlotIndex
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 252188, XrefRangeEnd = 252195, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(ItemSlot.NativeMethodInfoPtr_get_SlotIndex_Private_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
		}

		// Token: 0x17002873 RID: 10355
		// (get) Token: 0x0600865E RID: 34398 RVA: 0x0023D544 File Offset: 0x0023B744
		public unsafe int Quantity
		{
			[CallerCount(87)]
			[CachedScanResults(RefRangeStart = 252195, RefRangeEnd = 252282, XrefRangeStart = 252195, XrefRangeEnd = 252195, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(ItemSlot.NativeMethodInfoPtr_get_Quantity_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
		}

		// Token: 0x17002874 RID: 10356
		// (get) Token: 0x0600865F RID: 34399 RVA: 0x0023D580 File Offset: 0x0023B780
		public unsafe bool IsAtCapacity
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(ItemSlot.NativeMethodInfoPtr_get_IsAtCapacity_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
		}

		// Token: 0x17002875 RID: 10357
		// (get) Token: 0x06008660 RID: 34400 RVA: 0x0023D5BC File Offset: 0x0023B7BC
		public unsafe bool IsLocked
		{
			[CallerCount(35)]
			[CachedScanResults(RefRangeStart = 159873, RefRangeEnd = 159908, XrefRangeStart = 159873, XrefRangeEnd = 159908, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(ItemSlot.NativeMethodInfoPtr_get_IsLocked_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
		}

		// Token: 0x17002876 RID: 10358
		// (get) Token: 0x06008661 RID: 34401 RVA: 0x0023D5F8 File Offset: 0x0023B7F8
		// (set) Token: 0x06008662 RID: 34402 RVA: 0x0023D638 File Offset: 0x0023B838
		public unsafe ItemSlotLock ActiveLock
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 20988, RefRangeEnd = 21002, XrefRangeStart = 20988, XrefRangeEnd = 21002, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSlot.NativeMethodInfoPtr_get_ActiveLock_Public_get_ItemSlotLock_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemSlotLock>(intPtr2) : null;
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 21003, RefRangeEnd = 21004, XrefRangeStart = 21003, XrefRangeEnd = 21004, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSlot.NativeMethodInfoPtr_set_ActiveLock_Protected_set_Void_ItemSlotLock_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x17002877 RID: 10359
		// (get) Token: 0x06008663 RID: 34403 RVA: 0x0023D67C File Offset: 0x0023B87C
		// (set) Token: 0x06008664 RID: 34404 RVA: 0x0023D6B8 File Offset: 0x0023B8B8
		public unsafe bool IsRemovalLocked
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(ItemSlot.NativeMethodInfoPtr_get_IsRemovalLocked_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 53388, RefRangeEnd = 53391, XrefRangeStart = 53388, XrefRangeEnd = 53391, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = ref value;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSlot.NativeMethodInfoPtr_set_IsRemovalLocked_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x17002878 RID: 10360
		// (get) Token: 0x06008665 RID: 34405 RVA: 0x0023D6F8 File Offset: 0x0023B8F8
		// (set) Token: 0x06008666 RID: 34406 RVA: 0x0023D734 File Offset: 0x0023B934
		public unsafe bool IsAddLocked
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(ItemSlot.NativeMethodInfoPtr_get_IsAddLocked_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 53375, RefRangeEnd = 53385, XrefRangeStart = 53375, XrefRangeEnd = 53385, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = ref value;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSlot.NativeMethodInfoPtr_set_IsAddLocked_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x17002879 RID: 10361
		// (get) Token: 0x06008667 RID: 34407 RVA: 0x0023D774 File Offset: 0x0023B974
		// (set) Token: 0x06008668 RID: 34408 RVA: 0x0023D7B4 File Offset: 0x0023B9B4
		public unsafe List<ItemFilter> HardFilters
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 17870, RefRangeEnd = 17871, XrefRangeStart = 17870, XrefRangeEnd = 17871, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSlot.NativeMethodInfoPtr_get_HardFilters_Protected_get_List_1_ItemFilter_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ItemFilter>>(intPtr2) : null;
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 40500, RefRangeEnd = 40502, XrefRangeStart = 40500, XrefRangeEnd = 40502, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSlot.NativeMethodInfoPtr_set_HardFilters_Protected_set_Void_List_1_ItemFilter_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x1700287A RID: 10362
		// (get) Token: 0x06008669 RID: 34409 RVA: 0x0023D7F8 File Offset: 0x0023B9F8
		// (set) Token: 0x0600866A RID: 34410 RVA: 0x0023D834 File Offset: 0x0023BA34
		public unsafe bool CanPlayerSetFilter
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(ItemSlot.NativeMethodInfoPtr_get_CanPlayerSetFilter_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = ref value;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSlot.NativeMethodInfoPtr_set_CanPlayerSetFilter_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x1700287B RID: 10363
		// (get) Token: 0x0600866B RID: 34411 RVA: 0x0023D874 File Offset: 0x0023BA74
		// (set) Token: 0x0600866C RID: 34412 RVA: 0x0023D8B4 File Offset: 0x0023BAB4
		public unsafe SlotFilter PlayerFilter
		{
			[CallerCount(40)]
			[CachedScanResults(RefRangeStart = 49659, RefRangeEnd = 49699, XrefRangeStart = 49659, XrefRangeEnd = 49699, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSlot.NativeMethodInfoPtr_get_PlayerFilter_Public_get_SlotFilter_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SlotFilter>(intPtr2) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSlot.NativeMethodInfoPtr_set_PlayerFilter_Public_set_Void_SlotFilter_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x1700287C RID: 10364
		// (get) Token: 0x0600866D RID: 34413 RVA: 0x0023D8F8 File Offset: 0x0023BAF8
		// (set) Token: 0x0600866E RID: 34414 RVA: 0x0023D938 File Offset: 0x0023BB38
		public unsafe ItemSlotSiblingSet SiblingSet
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 24376, RefRangeEnd = 24377, XrefRangeStart = 24376, XrefRangeEnd = 24377, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSlot.NativeMethodInfoPtr_get_SiblingSet_Public_get_ItemSlotSiblingSet_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemSlotSiblingSet>(intPtr2) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSlot.NativeMethodInfoPtr_set_SiblingSet_Public_set_Void_ItemSlotSiblingSet_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x0600866F RID: 34415 RVA: 0x0023D97C File Offset: 0x0023BB7C
		[CallerCount(25)]
		[CachedScanResults(RefRangeStart = 252292, RefRangeEnd = 252317, XrefRangeStart = 252282, XrefRangeEnd = 252292, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetSlotOwner(IItemSlotOwner owner)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(owner);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSlot.NativeMethodInfoPtr_SetSlotOwner_Public_Void_IItemSlotOwner_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008670 RID: 34416 RVA: 0x0023D9C0 File Offset: 0x0023BBC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 252317, XrefRangeEnd = 252328, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetSiblingSet(ItemSlotSiblingSet set)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(set);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSlot.NativeMethodInfoPtr_SetSiblingSet_Public_Void_ItemSlotSiblingSet_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008671 RID: 34417 RVA: 0x0023DA04 File Offset: 0x0023BC04
		[CallerCount(13)]
		[CachedScanResults(RefRangeStart = 252350, RefRangeEnd = 252363, XrefRangeStart = 252328, XrefRangeEnd = 252350, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ItemSlot() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ItemSlot>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSlot.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008672 RID: 34418 RVA: 0x0023DA40 File Offset: 0x0023BC40
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 252385, RefRangeEnd = 252397, XrefRangeStart = 252363, XrefRangeEnd = 252385, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ItemSlot(bool canPlayerSetFilter = false) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ItemSlot>.NativeClassPtr))
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref canPlayerSetFilter;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSlot.NativeMethodInfoPtr__ctor_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008673 RID: 34419 RVA: 0x0023DA88 File Offset: 0x0023BC88
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 252406, RefRangeEnd = 252412, XrefRangeStart = 252397, XrefRangeEnd = 252406, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReplicateStoredInstance()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSlot.NativeMethodInfoPtr_ReplicateStoredInstance_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008674 RID: 34420 RVA: 0x0023DABC File Offset: 0x0023BCBC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 252429, RefRangeEnd = 252430, XrefRangeStart = 252412, XrefRangeEnd = 252429, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetStoredItem(ItemInstance instance, bool _internal = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(instance);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref _internal;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ItemSlot.NativeMethodInfoPtr_SetStoredItem_Public_Virtual_New_Void_ItemInstance_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008675 RID: 34421 RVA: 0x0023DB18 File Offset: 0x0023BD18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 252430, XrefRangeEnd = 252438, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void InsertItem(ItemInstance item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ItemSlot.NativeMethodInfoPtr_InsertItem_Public_Virtual_New_Void_ItemInstance_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008676 RID: 34422 RVA: 0x0023DB68 File Offset: 0x0023BD68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 252438, XrefRangeEnd = 252446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void AddItem(ItemInstance item, bool _internal = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref _internal;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ItemSlot.NativeMethodInfoPtr_AddItem_Public_Virtual_New_Void_ItemInstance_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008677 RID: 34423 RVA: 0x0023DBC4 File Offset: 0x0023BDC4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 252459, RefRangeEnd = 252460, XrefRangeStart = 252446, XrefRangeEnd = 252459, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void ClearStoredInstance(bool _internal = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref _internal;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ItemSlot.NativeMethodInfoPtr_ClearStoredInstance_Public_Virtual_New_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008678 RID: 34424 RVA: 0x0023DC10 File Offset: 0x0023BE10
		[CallerCount(25)]
		[CachedScanResults(RefRangeStart = 252477, RefRangeEnd = 252502, XrefRangeStart = 252460, XrefRangeEnd = 252477, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetQuantity(int amount, bool _internal = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref amount;
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref _internal;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSlot.NativeMethodInfoPtr_SetQuantity_Public_Void_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008679 RID: 34425 RVA: 0x0023DC5C File Offset: 0x0023BE5C
		[CallerCount(41)]
		[CachedScanResults(RefRangeStart = 252520, RefRangeEnd = 252561, XrefRangeStart = 252502, XrefRangeEnd = 252520, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ChangeQuantity(int change, bool _internal = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref change;
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref _internal;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSlot.NativeMethodInfoPtr_ChangeQuantity_Public_Void_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600867A RID: 34426 RVA: 0x0023DCA8 File Offset: 0x0023BEA8
		[CallerCount(0)]
		public unsafe virtual void ItemDataChanged()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ItemSlot.NativeMethodInfoPtr_ItemDataChanged_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600867B RID: 34427 RVA: 0x0023DCE4 File Offset: 0x0023BEE4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 252561, RefRangeEnd = 252564, XrefRangeStart = 252561, XrefRangeEnd = 252561, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void ClearItemInstanceRequested()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ItemSlot.NativeMethodInfoPtr_ClearItemInstanceRequested_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600867C RID: 34428 RVA: 0x0023DD20 File Offset: 0x0023BF20
		[CallerCount(19)]
		[CachedScanResults(RefRangeStart = 252577, RefRangeEnd = 252596, XrefRangeStart = 252564, XrefRangeEnd = 252577, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddFilter(ItemFilter filter)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(filter);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSlot.NativeMethodInfoPtr_AddFilter_Public_Void_ItemFilter_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600867D RID: 34429 RVA: 0x0023DD64 File Offset: 0x0023BF64
		[CallerCount(13)]
		[CachedScanResults(RefRangeStart = 252618, RefRangeEnd = 252631, XrefRangeStart = 252596, XrefRangeEnd = 252618, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ApplyLock(NetworkObject lockOwner, string lockReason, bool _internal = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(lockOwner);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(lockReason);
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref _internal;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSlot.NativeMethodInfoPtr_ApplyLock_Public_Void_NetworkObject_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600867E RID: 34430 RVA: 0x0023DDC8 File Offset: 0x0023BFC8
		[CallerCount(13)]
		[CachedScanResults(RefRangeStart = 252642, RefRangeEnd = 252655, XrefRangeStart = 252631, XrefRangeEnd = 252642, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveLock(bool _internal = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref _internal;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSlot.NativeMethodInfoPtr_RemoveLock_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600867F RID: 34431 RVA: 0x0023DE08 File Offset: 0x0023C008
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 53388, RefRangeEnd = 53391, XrefRangeStart = 53388, XrefRangeEnd = 53391, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetIsRemovalLocked(bool locked)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref locked;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSlot.NativeMethodInfoPtr_SetIsRemovalLocked_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008680 RID: 34432 RVA: 0x0023DE48 File Offset: 0x0023C048
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 53375, RefRangeEnd = 53385, XrefRangeStart = 53375, XrefRangeEnd = 53385, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetIsAddLocked(bool locked)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref locked;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSlot.NativeMethodInfoPtr_SetIsAddLocked_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008681 RID: 34433 RVA: 0x0023DE88 File Offset: 0x0023C088
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 252655, XrefRangeEnd = 252666, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool DoesItemMatchHardFilters(ItemInstance item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ItemSlot.NativeMethodInfoPtr_DoesItemMatchHardFilters_Public_Virtual_New_Boolean_ItemInstance_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06008682 RID: 34434 RVA: 0x0023DEE0 File Offset: 0x0023C0E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 252666, XrefRangeEnd = 252676, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool DoesItemMatchPlayerFilters(ItemInstance item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ItemSlot.NativeMethodInfoPtr_DoesItemMatchPlayerFilters_Public_Virtual_New_Boolean_ItemInstance_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06008683 RID: 34435 RVA: 0x0023DF38 File Offset: 0x0023C138
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 252681, RefRangeEnd = 252682, XrefRangeStart = 252676, XrefRangeEnd = 252681, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetFilterable(bool filterable)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref filterable;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSlot.NativeMethodInfoPtr_SetFilterable_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008684 RID: 34436 RVA: 0x0023DF78 File Offset: 0x0023C178
		[CallerCount(45)]
		[CachedScanResults(RefRangeStart = 252691, RefRangeEnd = 252736, XrefRangeStart = 252682, XrefRangeEnd = 252691, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetPlayerFilter(SlotFilter filter, bool _internal = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(filter);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref _internal;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSlot.NativeMethodInfoPtr_SetPlayerFilter_Public_Void_SlotFilter_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008685 RID: 34437 RVA: 0x0023DFC8 File Offset: 0x0023C1C8
		[CallerCount(0)]
		public unsafe virtual int GetCapacityForItem(ItemInstance item, bool checkPlayerFilters = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref checkPlayerFilters;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ItemSlot.NativeMethodInfoPtr_GetCapacityForItem_Public_Virtual_New_Int32_ItemInstance_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06008686 RID: 34438 RVA: 0x0023E030 File Offset: 0x0023C230
		[CallerCount(21)]
		[CachedScanResults(RefRangeStart = 31612, RefRangeEnd = 31633, XrefRangeStart = 31612, XrefRangeEnd = 31633, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool CanSlotAcceptCash()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ItemSlot.NativeMethodInfoPtr_CanSlotAcceptCash_Public_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06008687 RID: 34439 RVA: 0x0023E078 File Offset: 0x0023C278
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 252761, RefRangeEnd = 252762, XrefRangeStart = 252736, XrefRangeEnd = 252761, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool TryInsertItemIntoSet(List<ItemSlot> ItemSlots, ItemInstance item)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(ItemSlots);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(item);
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(ItemSlot.NativeMethodInfoPtr_TryInsertItemIntoSet_Public_Static_Boolean_List_1_ItemSlot_ItemInstance_0, 0, (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06008688 RID: 34440 RVA: 0x0003F76F File Offset: 0x0003D96F
		public ItemSlot(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002862 RID: 10338
		// (get) Token: 0x06008689 RID: 34441 RVA: 0x0023E0CC File Offset: 0x0023C2CC
		// (set) Token: 0x0600868A RID: 34442 RVA: 0x0003F778 File Offset: 0x0003D978
		public unsafe ItemInstance _ItemInstance_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ItemSlot.NativeFieldInfoPtr__ItemInstance_k__BackingField);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemInstance>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ItemSlot.NativeFieldInfoPtr__ItemInstance_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002863 RID: 10339
		// (get) Token: 0x0600868B RID: 34443 RVA: 0x0023E0FC File Offset: 0x0023C2FC
		// (set) Token: 0x0600868C RID: 34444 RVA: 0x0003F797 File Offset: 0x0003D997
		public unsafe IItemSlotOwner _SlotOwner_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ItemSlot.NativeFieldInfoPtr__SlotOwner_k__BackingField);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IItemSlotOwner>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ItemSlot.NativeFieldInfoPtr__SlotOwner_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002864 RID: 10340
		// (get) Token: 0x0600868D RID: 34445 RVA: 0x0023E12C File Offset: 0x0023C32C
		// (set) Token: 0x0600868E RID: 34446 RVA: 0x0003F7B6 File Offset: 0x0003D9B6
		public unsafe Il2CppSystem.Action onItemDataChanged
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ItemSlot.NativeFieldInfoPtr_onItemDataChanged);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Action>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ItemSlot.NativeFieldInfoPtr_onItemDataChanged), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002865 RID: 10341
		// (get) Token: 0x0600868F RID: 34447 RVA: 0x0023E15C File Offset: 0x0023C35C
		// (set) Token: 0x06008690 RID: 34448 RVA: 0x0003F7D5 File Offset: 0x0003D9D5
		public unsafe Il2CppSystem.Action onItemInstanceChanged
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ItemSlot.NativeFieldInfoPtr_onItemInstanceChanged);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Action>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ItemSlot.NativeFieldInfoPtr_onItemInstanceChanged), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002866 RID: 10342
		// (get) Token: 0x06008691 RID: 34449 RVA: 0x0023E18C File Offset: 0x0023C38C
		// (set) Token: 0x06008692 RID: 34450 RVA: 0x0003F7F4 File Offset: 0x0003D9F4
		public unsafe ItemSlotLock _ActiveLock_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ItemSlot.NativeFieldInfoPtr__ActiveLock_k__BackingField);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemSlotLock>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ItemSlot.NativeFieldInfoPtr__ActiveLock_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002867 RID: 10343
		// (get) Token: 0x06008693 RID: 34451 RVA: 0x0023E1BC File Offset: 0x0023C3BC
		// (set) Token: 0x06008694 RID: 34452 RVA: 0x0003F813 File Offset: 0x0003DA13
		public unsafe Il2CppSystem.Action onLocked
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ItemSlot.NativeFieldInfoPtr_onLocked);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Action>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ItemSlot.NativeFieldInfoPtr_onLocked), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002868 RID: 10344
		// (get) Token: 0x06008695 RID: 34453 RVA: 0x0023E1EC File Offset: 0x0023C3EC
		// (set) Token: 0x06008696 RID: 34454 RVA: 0x0003F832 File Offset: 0x0003DA32
		public unsafe Il2CppSystem.Action onUnlocked
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ItemSlot.NativeFieldInfoPtr_onUnlocked);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Action>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ItemSlot.NativeFieldInfoPtr_onUnlocked), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002869 RID: 10345
		// (get) Token: 0x06008697 RID: 34455 RVA: 0x0023E21C File Offset: 0x0023C41C
		// (set) Token: 0x06008698 RID: 34456 RVA: 0x0003F851 File Offset: 0x0003DA51
		public unsafe bool _IsRemovalLocked_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ItemSlot.NativeFieldInfoPtr__IsRemovalLocked_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ItemSlot.NativeFieldInfoPtr__IsRemovalLocked_k__BackingField)) = value;
			}
		}

		// Token: 0x1700286A RID: 10346
		// (get) Token: 0x06008699 RID: 34457 RVA: 0x0023E244 File Offset: 0x0023C444
		// (set) Token: 0x0600869A RID: 34458 RVA: 0x0003F86C File Offset: 0x0003DA6C
		public unsafe bool _IsAddLocked_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ItemSlot.NativeFieldInfoPtr__IsAddLocked_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ItemSlot.NativeFieldInfoPtr__IsAddLocked_k__BackingField)) = value;
			}
		}

		// Token: 0x1700286B RID: 10347
		// (get) Token: 0x0600869B RID: 34459 RVA: 0x0023E26C File Offset: 0x0023C46C
		// (set) Token: 0x0600869C RID: 34460 RVA: 0x0003F887 File Offset: 0x0003DA87
		public unsafe List<ItemFilter> _HardFilters_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ItemSlot.NativeFieldInfoPtr__HardFilters_k__BackingField);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ItemFilter>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ItemSlot.NativeFieldInfoPtr__HardFilters_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700286C RID: 10348
		// (get) Token: 0x0600869D RID: 34461 RVA: 0x0023E29C File Offset: 0x0023C49C
		// (set) Token: 0x0600869E RID: 34462 RVA: 0x0003F8A6 File Offset: 0x0003DAA6
		public unsafe bool _CanPlayerSetFilter_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ItemSlot.NativeFieldInfoPtr__CanPlayerSetFilter_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ItemSlot.NativeFieldInfoPtr__CanPlayerSetFilter_k__BackingField)) = value;
			}
		}

		// Token: 0x1700286D RID: 10349
		// (get) Token: 0x0600869F RID: 34463 RVA: 0x0023E2C4 File Offset: 0x0023C4C4
		// (set) Token: 0x060086A0 RID: 34464 RVA: 0x0003F8C1 File Offset: 0x0003DAC1
		public unsafe SlotFilter _PlayerFilter_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ItemSlot.NativeFieldInfoPtr__PlayerFilter_k__BackingField);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SlotFilter>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ItemSlot.NativeFieldInfoPtr__PlayerFilter_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700286E RID: 10350
		// (get) Token: 0x060086A1 RID: 34465 RVA: 0x0023E2F4 File Offset: 0x0023C4F4
		// (set) Token: 0x060086A2 RID: 34466 RVA: 0x0003F8E0 File Offset: 0x0003DAE0
		public unsafe Il2CppSystem.Action onFilterChange
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ItemSlot.NativeFieldInfoPtr_onFilterChange);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Action>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ItemSlot.NativeFieldInfoPtr_onFilterChange), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700286F RID: 10351
		// (get) Token: 0x060086A3 RID: 34467 RVA: 0x0023E324 File Offset: 0x0023C524
		// (set) Token: 0x060086A4 RID: 34468 RVA: 0x0003F8FF File Offset: 0x0003DAFF
		public unsafe ItemSlotSiblingSet _SiblingSet_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ItemSlot.NativeFieldInfoPtr__SiblingSet_k__BackingField);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemSlotSiblingSet>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ItemSlot.NativeFieldInfoPtr__SiblingSet_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04005B82 RID: 23426
		private static readonly System.IntPtr NativeFieldInfoPtr__ItemInstance_k__BackingField;

		// Token: 0x04005B83 RID: 23427
		private static readonly System.IntPtr NativeFieldInfoPtr__SlotOwner_k__BackingField;

		// Token: 0x04005B84 RID: 23428
		private static readonly System.IntPtr NativeFieldInfoPtr_onItemDataChanged;

		// Token: 0x04005B85 RID: 23429
		private static readonly System.IntPtr NativeFieldInfoPtr_onItemInstanceChanged;

		// Token: 0x04005B86 RID: 23430
		private static readonly System.IntPtr NativeFieldInfoPtr__ActiveLock_k__BackingField;

		// Token: 0x04005B87 RID: 23431
		private static readonly System.IntPtr NativeFieldInfoPtr_onLocked;

		// Token: 0x04005B88 RID: 23432
		private static readonly System.IntPtr NativeFieldInfoPtr_onUnlocked;

		// Token: 0x04005B89 RID: 23433
		private static readonly System.IntPtr NativeFieldInfoPtr__IsRemovalLocked_k__BackingField;

		// Token: 0x04005B8A RID: 23434
		private static readonly System.IntPtr NativeFieldInfoPtr__IsAddLocked_k__BackingField;

		// Token: 0x04005B8B RID: 23435
		private static readonly System.IntPtr NativeFieldInfoPtr__HardFilters_k__BackingField;

		// Token: 0x04005B8C RID: 23436
		private static readonly System.IntPtr NativeFieldInfoPtr__CanPlayerSetFilter_k__BackingField;

		// Token: 0x04005B8D RID: 23437
		private static readonly System.IntPtr NativeFieldInfoPtr__PlayerFilter_k__BackingField;

		// Token: 0x04005B8E RID: 23438
		private static readonly System.IntPtr NativeFieldInfoPtr_onFilterChange;

		// Token: 0x04005B8F RID: 23439
		private static readonly System.IntPtr NativeFieldInfoPtr__SiblingSet_k__BackingField;

		// Token: 0x04005B90 RID: 23440
		private static readonly System.IntPtr NativeMethodInfoPtr_get_ItemInstance_Public_get_ItemInstance_0;

		// Token: 0x04005B91 RID: 23441
		private static readonly System.IntPtr NativeMethodInfoPtr_set_ItemInstance_Protected_set_Void_ItemInstance_0;

		// Token: 0x04005B92 RID: 23442
		private static readonly System.IntPtr NativeMethodInfoPtr_get_SlotOwner_Public_get_IItemSlotOwner_0;

		// Token: 0x04005B93 RID: 23443
		private static readonly System.IntPtr NativeMethodInfoPtr_set_SlotOwner_Protected_set_Void_IItemSlotOwner_0;

		// Token: 0x04005B94 RID: 23444
		private static readonly System.IntPtr NativeMethodInfoPtr_get_SlotIndex_Private_get_Int32_0;

		// Token: 0x04005B95 RID: 23445
		private static readonly System.IntPtr NativeMethodInfoPtr_get_Quantity_Public_get_Int32_0;

		// Token: 0x04005B96 RID: 23446
		private static readonly System.IntPtr NativeMethodInfoPtr_get_IsAtCapacity_Public_get_Boolean_0;

		// Token: 0x04005B97 RID: 23447
		private static readonly System.IntPtr NativeMethodInfoPtr_get_IsLocked_Public_get_Boolean_0;

		// Token: 0x04005B98 RID: 23448
		private static readonly System.IntPtr NativeMethodInfoPtr_get_ActiveLock_Public_get_ItemSlotLock_0;

		// Token: 0x04005B99 RID: 23449
		private static readonly System.IntPtr NativeMethodInfoPtr_set_ActiveLock_Protected_set_Void_ItemSlotLock_0;

		// Token: 0x04005B9A RID: 23450
		private static readonly System.IntPtr NativeMethodInfoPtr_get_IsRemovalLocked_Public_get_Boolean_0;

		// Token: 0x04005B9B RID: 23451
		private static readonly System.IntPtr NativeMethodInfoPtr_set_IsRemovalLocked_Protected_set_Void_Boolean_0;

		// Token: 0x04005B9C RID: 23452
		private static readonly System.IntPtr NativeMethodInfoPtr_get_IsAddLocked_Public_get_Boolean_0;

		// Token: 0x04005B9D RID: 23453
		private static readonly System.IntPtr NativeMethodInfoPtr_set_IsAddLocked_Protected_set_Void_Boolean_0;

		// Token: 0x04005B9E RID: 23454
		private static readonly System.IntPtr NativeMethodInfoPtr_get_HardFilters_Protected_get_List_1_ItemFilter_0;

		// Token: 0x04005B9F RID: 23455
		private static readonly System.IntPtr NativeMethodInfoPtr_set_HardFilters_Protected_set_Void_List_1_ItemFilter_0;

		// Token: 0x04005BA0 RID: 23456
		private static readonly System.IntPtr NativeMethodInfoPtr_get_CanPlayerSetFilter_Public_get_Boolean_0;

		// Token: 0x04005BA1 RID: 23457
		private static readonly System.IntPtr NativeMethodInfoPtr_set_CanPlayerSetFilter_Public_set_Void_Boolean_0;

		// Token: 0x04005BA2 RID: 23458
		private static readonly System.IntPtr NativeMethodInfoPtr_get_PlayerFilter_Public_get_SlotFilter_0;

		// Token: 0x04005BA3 RID: 23459
		private static readonly System.IntPtr NativeMethodInfoPtr_set_PlayerFilter_Public_set_Void_SlotFilter_0;

		// Token: 0x04005BA4 RID: 23460
		private static readonly System.IntPtr NativeMethodInfoPtr_get_SiblingSet_Public_get_ItemSlotSiblingSet_0;

		// Token: 0x04005BA5 RID: 23461
		private static readonly System.IntPtr NativeMethodInfoPtr_set_SiblingSet_Public_set_Void_ItemSlotSiblingSet_0;

		// Token: 0x04005BA6 RID: 23462
		private static readonly System.IntPtr NativeMethodInfoPtr_SetSlotOwner_Public_Void_IItemSlotOwner_0;

		// Token: 0x04005BA7 RID: 23463
		private static readonly System.IntPtr NativeMethodInfoPtr_SetSiblingSet_Public_Void_ItemSlotSiblingSet_0;

		// Token: 0x04005BA8 RID: 23464
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04005BA9 RID: 23465
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Boolean_0;

		// Token: 0x04005BAA RID: 23466
		private static readonly System.IntPtr NativeMethodInfoPtr_ReplicateStoredInstance_Public_Void_0;

		// Token: 0x04005BAB RID: 23467
		private static readonly System.IntPtr NativeMethodInfoPtr_SetStoredItem_Public_Virtual_New_Void_ItemInstance_Boolean_0;

		// Token: 0x04005BAC RID: 23468
		private static readonly System.IntPtr NativeMethodInfoPtr_InsertItem_Public_Virtual_New_Void_ItemInstance_0;

		// Token: 0x04005BAD RID: 23469
		private static readonly System.IntPtr NativeMethodInfoPtr_AddItem_Public_Virtual_New_Void_ItemInstance_Boolean_0;

		// Token: 0x04005BAE RID: 23470
		private static readonly System.IntPtr NativeMethodInfoPtr_ClearStoredInstance_Public_Virtual_New_Void_Boolean_0;

		// Token: 0x04005BAF RID: 23471
		private static readonly System.IntPtr NativeMethodInfoPtr_SetQuantity_Public_Void_Int32_Boolean_0;

		// Token: 0x04005BB0 RID: 23472
		private static readonly System.IntPtr NativeMethodInfoPtr_ChangeQuantity_Public_Void_Int32_Boolean_0;

		// Token: 0x04005BB1 RID: 23473
		private static readonly System.IntPtr NativeMethodInfoPtr_ItemDataChanged_Protected_Virtual_New_Void_0;

		// Token: 0x04005BB2 RID: 23474
		private static readonly System.IntPtr NativeMethodInfoPtr_ClearItemInstanceRequested_Protected_Virtual_New_Void_0;

		// Token: 0x04005BB3 RID: 23475
		private static readonly System.IntPtr NativeMethodInfoPtr_AddFilter_Public_Void_ItemFilter_0;

		// Token: 0x04005BB4 RID: 23476
		private static readonly System.IntPtr NativeMethodInfoPtr_ApplyLock_Public_Void_NetworkObject_String_Boolean_0;

		// Token: 0x04005BB5 RID: 23477
		private static readonly System.IntPtr NativeMethodInfoPtr_RemoveLock_Public_Void_Boolean_0;

		// Token: 0x04005BB6 RID: 23478
		private static readonly System.IntPtr NativeMethodInfoPtr_SetIsRemovalLocked_Public_Void_Boolean_0;

		// Token: 0x04005BB7 RID: 23479
		private static readonly System.IntPtr NativeMethodInfoPtr_SetIsAddLocked_Public_Void_Boolean_0;

		// Token: 0x04005BB8 RID: 23480
		private static readonly System.IntPtr NativeMethodInfoPtr_DoesItemMatchHardFilters_Public_Virtual_New_Boolean_ItemInstance_0;

		// Token: 0x04005BB9 RID: 23481
		private static readonly System.IntPtr NativeMethodInfoPtr_DoesItemMatchPlayerFilters_Public_Virtual_New_Boolean_ItemInstance_0;

		// Token: 0x04005BBA RID: 23482
		private static readonly System.IntPtr NativeMethodInfoPtr_SetFilterable_Public_Void_Boolean_0;

		// Token: 0x04005BBB RID: 23483
		private static readonly System.IntPtr NativeMethodInfoPtr_SetPlayerFilter_Public_Void_SlotFilter_Boolean_0;

		// Token: 0x04005BBC RID: 23484
		private static readonly System.IntPtr NativeMethodInfoPtr_GetCapacityForItem_Public_Virtual_New_Int32_ItemInstance_Boolean_0;

		// Token: 0x04005BBD RID: 23485
		private static readonly System.IntPtr NativeMethodInfoPtr_CanSlotAcceptCash_Public_Virtual_New_Boolean_0;

		// Token: 0x04005BBE RID: 23486
		private static readonly System.IntPtr NativeMethodInfoPtr_TryInsertItemIntoSet_Public_Static_Boolean_List_1_ItemSlot_ItemInstance_0;
	}
}
