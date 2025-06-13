using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using Il2CppScheduleOne.Equipping;
using Il2CppScheduleOne.ItemFramework;
using Il2CppScheduleOne.Money;
using Il2CppScheduleOne.Product.Packaging;
using Il2CppScheduleOne.UI;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace Il2CppScheduleOne.PlayerScripts
{
	// Token: 0x02000407 RID: 1031
	public class PlayerInventory : PlayerSingleton<PlayerInventory>
	{
		// Token: 0x0600525F RID: 21087 RVA: 0x00189E9C File Offset: 0x0018809C
		// Note: this type is marked as 'beforefieldinit'.
		static PlayerInventory()
		{
			Il2CppClassPointerStore<PlayerInventory>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.PlayerScripts", "PlayerInventory");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayerInventory>.NativeClassPtr);
			PlayerInventory.NativeFieldInfoPtr_LABEL_DISPLAY_TIME = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerInventory>.NativeClassPtr, "LABEL_DISPLAY_TIME");
			PlayerInventory.NativeFieldInfoPtr_LABEL_FADE_TIME = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerInventory>.NativeClassPtr, "LABEL_FADE_TIME");
			PlayerInventory.NativeFieldInfoPtr_DISCARD_TIME = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerInventory>.NativeClassPtr, "DISCARD_TIME");
			PlayerInventory.NativeFieldInfoPtr_INVENTORY_SLOT_COUNT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerInventory>.NativeClassPtr, "INVENTORY_SLOT_COUNT");
			PlayerInventory.NativeFieldInfoPtr_giveStartupItems = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerInventory>.NativeClassPtr, "giveStartupItems");
			PlayerInventory.NativeFieldInfoPtr_startupItems = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerInventory>.NativeClassPtr, "startupItems");
			PlayerInventory.NativeFieldInfoPtr_equipContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerInventory>.NativeClassPtr, "equipContainer");
			PlayerInventory.NativeFieldInfoPtr_hotbarSlots = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerInventory>.NativeClassPtr, "hotbarSlots");
			PlayerInventory.NativeFieldInfoPtr__cashSlot_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerInventory>.NativeClassPtr, "<cashSlot>k__BackingField");
			PlayerInventory.NativeFieldInfoPtr__cashInstance_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerInventory>.NativeClassPtr, "<cashInstance>k__BackingField");
			PlayerInventory.NativeFieldInfoPtr_clipboardSlot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerInventory>.NativeClassPtr, "clipboardSlot");
			PlayerInventory.NativeFieldInfoPtr_slotUIs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerInventory>.NativeClassPtr, "slotUIs");
			PlayerInventory.NativeFieldInfoPtr_discardSlot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerInventory>.NativeClassPtr, "discardSlot");
			PlayerInventory.NativeFieldInfoPtr_ItemVariables = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerInventory>.NativeClassPtr, "ItemVariables");
			PlayerInventory.NativeFieldInfoPtr__EquippedSlotIndex_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerInventory>.NativeClassPtr, "<EquippedSlotIndex>k__BackingField");
			PlayerInventory.NativeFieldInfoPtr__HotbarEnabled_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerInventory>.NativeClassPtr, "<HotbarEnabled>k__BackingField");
			PlayerInventory.NativeFieldInfoPtr__EquippingEnabled_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerInventory>.NativeClassPtr, "<EquippingEnabled>k__BackingField");
			PlayerInventory.NativeFieldInfoPtr__equippable_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerInventory>.NativeClassPtr, "<equippable>k__BackingField");
			PlayerInventory.NativeFieldInfoPtr_onInventoryStateChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerInventory>.NativeClassPtr, "onInventoryStateChanged");
			PlayerInventory.NativeFieldInfoPtr_PriorEquippedSlotIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerInventory>.NativeClassPtr, "PriorEquippedSlotIndex");
			PlayerInventory.NativeFieldInfoPtr_PreviousEquippedSlotIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerInventory>.NativeClassPtr, "PreviousEquippedSlotIndex");
			PlayerInventory.NativeFieldInfoPtr_onPreItemEquipped = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerInventory>.NativeClassPtr, "onPreItemEquipped");
			PlayerInventory.NativeFieldInfoPtr_onItemEquipped = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerInventory>.NativeClassPtr, "onItemEquipped");
			PlayerInventory.NativeFieldInfoPtr_ManagementSlotEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerInventory>.NativeClassPtr, "ManagementSlotEnabled");
			PlayerInventory.NativeFieldInfoPtr_currentEquipTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerInventory>.NativeClassPtr, "currentEquipTime");
			PlayerInventory.NativeFieldInfoPtr_currentDiscardTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerInventory>.NativeClassPtr, "currentDiscardTime");
			PlayerInventory.NativeMethodInfoPtr_get_TOTAL_SLOT_COUNT_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerInventory>.NativeClassPtr, 100673715);
			PlayerInventory.NativeMethodInfoPtr_get_cashSlot_Public_get_CashSlot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerInventory>.NativeClassPtr, 100673716);
			PlayerInventory.NativeMethodInfoPtr_set_cashSlot_Private_set_Void_CashSlot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerInventory>.NativeClassPtr, 100673717);
			PlayerInventory.NativeMethodInfoPtr_get_cashInstance_Public_get_CashInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerInventory>.NativeClassPtr, 100673718);
			PlayerInventory.NativeMethodInfoPtr_set_cashInstance_Protected_set_Void_CashInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerInventory>.NativeClassPtr, 100673719);
			PlayerInventory.NativeMethodInfoPtr_get_EquippedSlotIndex_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerInventory>.NativeClassPtr, 100673720);
			PlayerInventory.NativeMethodInfoPtr_set_EquippedSlotIndex_Protected_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerInventory>.NativeClassPtr, 100673721);
			PlayerInventory.NativeMethodInfoPtr_get_HotbarEnabled_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerInventory>.NativeClassPtr, 100673722);
			PlayerInventory.NativeMethodInfoPtr_set_HotbarEnabled_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerInventory>.NativeClassPtr, 100673723);
			PlayerInventory.NativeMethodInfoPtr_get_EquippingEnabled_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerInventory>.NativeClassPtr, 100673724);
			PlayerInventory.NativeMethodInfoPtr_set_EquippingEnabled_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerInventory>.NativeClassPtr, 100673725);
			PlayerInventory.NativeMethodInfoPtr_get_equippable_Public_get_Equippable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerInventory>.NativeClassPtr, 100673726);
			PlayerInventory.NativeMethodInfoPtr_set_equippable_Protected_set_Void_Equippable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerInventory>.NativeClassPtr, 100673727);
			PlayerInventory.NativeMethodInfoPtr_get_equippedSlot_Public_get_HotbarSlot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerInventory>.NativeClassPtr, 100673728);
			PlayerInventory.NativeMethodInfoPtr_get_isAnythingEquipped_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerInventory>.NativeClassPtr, 100673729);
			PlayerInventory.NativeMethodInfoPtr_IndexAllSlots_Public_HotbarSlot_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerInventory>.NativeClassPtr, 100673730);
			PlayerInventory.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerInventory>.NativeClassPtr, 100673731);
			PlayerInventory.NativeMethodInfoPtr_SetupInventoryUI_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerInventory>.NativeClassPtr, 100673732);
			PlayerInventory.NativeMethodInfoPtr_RepositionUI_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerInventory>.NativeClassPtr, 100673733);
			PlayerInventory.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerInventory>.NativeClassPtr, 100673734);
			PlayerInventory.NativeMethodInfoPtr_GiveStartupItems_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerInventory>.NativeClassPtr, 100673735);
			PlayerInventory.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerInventory>.NativeClassPtr, 100673736);
			PlayerInventory.NativeMethodInfoPtr_UpdateHotbarSelection_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerInventory>.NativeClassPtr, 100673737);
			PlayerInventory.NativeMethodInfoPtr_Equip_Public_Void_HotbarSlot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerInventory>.NativeClassPtr, 100673738);
			PlayerInventory.NativeMethodInfoPtr_SetInventoryEnabled_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerInventory>.NativeClassPtr, 100673739);
			PlayerInventory.NativeMethodInfoPtr_SetEquippingEnabled_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerInventory>.NativeClassPtr, 100673740);
			PlayerInventory.NativeMethodInfoPtr_ClipboardAcquiredVarChange_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerInventory>.NativeClassPtr, 100673741);
			PlayerInventory.NativeMethodInfoPtr_SetManagementClipboardEnabled_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerInventory>.NativeClassPtr, 100673742);
			PlayerInventory.NativeMethodInfoPtr_SetViewmodelVisible_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerInventory>.NativeClassPtr, 100673743);
			PlayerInventory.NativeMethodInfoPtr_CanItemFitInInventory_Public_Boolean_ItemInstance_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerInventory>.NativeClassPtr, 100673744);
			PlayerInventory.NativeMethodInfoPtr_AddItemToInventory_Public_Void_ItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerInventory>.NativeClassPtr, 100673745);
			PlayerInventory.NativeMethodInfoPtr_GetAmountOfItem_Public_UInt32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerInventory>.NativeClassPtr, 100673746);
			PlayerInventory.NativeMethodInfoPtr_RemoveAmountOfItem_Public_Void_String_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerInventory>.NativeClassPtr, 100673747);
			PlayerInventory.NativeMethodInfoPtr_ClearInventory_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerInventory>.NativeClassPtr, 100673748);
			PlayerInventory.NativeMethodInfoPtr_RemoveProductFromInventory_Public_Void_EStealthLevel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerInventory>.NativeClassPtr, 100673749);
			PlayerInventory.NativeMethodInfoPtr_RemoveRandomItemsFromInventory_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerInventory>.NativeClassPtr, 100673750);
			PlayerInventory.NativeMethodInfoPtr_SetEquippable_Public_Void_Equippable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerInventory>.NativeClassPtr, 100673751);
			PlayerInventory.NativeMethodInfoPtr_Reequip_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerInventory>.NativeClassPtr, 100673752);
			PlayerInventory.NativeMethodInfoPtr_GetAllInventorySlots_Public_List_1_ItemSlot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerInventory>.NativeClassPtr, 100673753);
			PlayerInventory.NativeMethodInfoPtr_UpdateInventoryVariables_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerInventory>.NativeClassPtr, 100673754);
			PlayerInventory.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerInventory>.NativeClassPtr, 100673755);
			PlayerInventory.NativeMethodInfoPtr__Start_b__56_1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerInventory>.NativeClassPtr, 100673756);
		}

		// Token: 0x1700189B RID: 6299
		// (get) Token: 0x06005260 RID: 21088 RVA: 0x0018A41C File Offset: 0x0018861C
		public unsafe int TOTAL_SLOT_COUNT
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(PlayerInventory.NativeMethodInfoPtr_get_TOTAL_SLOT_COUNT_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
		}

		// Token: 0x1700189C RID: 6300
		// (get) Token: 0x06005261 RID: 21089 RVA: 0x0018A458 File Offset: 0x00188658
		// (set) Token: 0x06005262 RID: 21090 RVA: 0x0018A498 File Offset: 0x00188698
		public unsafe CashSlot cashSlot
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 37506, RefRangeEnd = 37507, XrefRangeStart = 37506, XrefRangeEnd = 37507, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerInventory.NativeMethodInfoPtr_get_cashSlot_Public_get_CashSlot_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CashSlot>(intPtr2) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerInventory.NativeMethodInfoPtr_set_cashSlot_Private_set_Void_CashSlot_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x1700189D RID: 6301
		// (get) Token: 0x06005263 RID: 21091 RVA: 0x0018A4DC File Offset: 0x001886DC
		// (set) Token: 0x06005264 RID: 21092 RVA: 0x0018A51C File Offset: 0x0018871C
		public unsafe CashInstance cashInstance
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerInventory.NativeMethodInfoPtr_get_cashInstance_Public_get_CashInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CashInstance>(intPtr2) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerInventory.NativeMethodInfoPtr_set_cashInstance_Protected_set_Void_CashInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x1700189E RID: 6302
		// (get) Token: 0x06005265 RID: 21093 RVA: 0x0018A560 File Offset: 0x00188760
		// (set) Token: 0x06005266 RID: 21094 RVA: 0x0018A59C File Offset: 0x0018879C
		public unsafe int EquippedSlotIndex
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 58128, RefRangeEnd = 58129, XrefRangeStart = 58128, XrefRangeEnd = 58129, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(PlayerInventory.NativeMethodInfoPtr_get_EquippedSlotIndex_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
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
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerInventory.NativeMethodInfoPtr_set_EquippedSlotIndex_Protected_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x1700189F RID: 6303
		// (get) Token: 0x06005267 RID: 21095 RVA: 0x0018A5DC File Offset: 0x001887DC
		// (set) Token: 0x06005268 RID: 21096 RVA: 0x0018A618 File Offset: 0x00188818
		public unsafe bool HotbarEnabled
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(PlayerInventory.NativeMethodInfoPtr_get_HotbarEnabled_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
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
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerInventory.NativeMethodInfoPtr_set_HotbarEnabled_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x170018A0 RID: 6304
		// (get) Token: 0x06005269 RID: 21097 RVA: 0x0018A658 File Offset: 0x00188858
		// (set) Token: 0x0600526A RID: 21098 RVA: 0x0018A694 File Offset: 0x00188894
		public unsafe bool EquippingEnabled
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(PlayerInventory.NativeMethodInfoPtr_get_EquippingEnabled_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
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
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerInventory.NativeMethodInfoPtr_set_EquippingEnabled_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x170018A1 RID: 6305
		// (get) Token: 0x0600526B RID: 21099 RVA: 0x0018A6D4 File Offset: 0x001888D4
		// (set) Token: 0x0600526C RID: 21100 RVA: 0x0018A714 File Offset: 0x00188914
		public unsafe Equippable equippable
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 48163, RefRangeEnd = 48164, XrefRangeStart = 48163, XrefRangeEnd = 48164, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerInventory.NativeMethodInfoPtr_get_equippable_Public_get_Equippable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Equippable>(intPtr2) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerInventory.NativeMethodInfoPtr_set_equippable_Protected_set_Void_Equippable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x170018A2 RID: 6306
		// (get) Token: 0x0600526D RID: 21101 RVA: 0x0018A758 File Offset: 0x00188958
		public unsafe HotbarSlot equippedSlot
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 179628, RefRangeEnd = 179643, XrefRangeStart = 179627, XrefRangeEnd = 179628, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerInventory.NativeMethodInfoPtr_get_equippedSlot_Public_get_HotbarSlot_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<HotbarSlot>(intPtr2) : null;
			}
		}

		// Token: 0x170018A3 RID: 6307
		// (get) Token: 0x0600526E RID: 21102 RVA: 0x0018A798 File Offset: 0x00188998
		public unsafe bool isAnythingEquipped
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 179645, RefRangeEnd = 179655, XrefRangeStart = 179643, XrefRangeEnd = 179645, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(PlayerInventory.NativeMethodInfoPtr_get_isAnythingEquipped_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
		}

		// Token: 0x0600526F RID: 21103 RVA: 0x0018A7D4 File Offset: 0x001889D4
		[CallerCount(15)]
		[CachedScanResults(RefRangeStart = 179657, RefRangeEnd = 179672, XrefRangeStart = 179655, XrefRangeEnd = 179657, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe HotbarSlot IndexAllSlots(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref index;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerInventory.NativeMethodInfoPtr_IndexAllSlots_Public_HotbarSlot_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<HotbarSlot>(intPtr2) : null;
		}

		// Token: 0x06005270 RID: 21104 RVA: 0x0018A820 File Offset: 0x00188A20
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 179672, XrefRangeEnd = 179676, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PlayerInventory.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005271 RID: 21105 RVA: 0x0018A85C File Offset: 0x00188A5C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 179801, RefRangeEnd = 179802, XrefRangeStart = 179676, XrefRangeEnd = 179801, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetupInventoryUI()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerInventory.NativeMethodInfoPtr_SetupInventoryUI_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005272 RID: 21106 RVA: 0x0018A890 File Offset: 0x00188A90
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 179883, RefRangeEnd = 179886, XrefRangeStart = 179802, XrefRangeEnd = 179883, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RepositionUI()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerInventory.NativeMethodInfoPtr_RepositionUI_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005273 RID: 21107 RVA: 0x0018A8C4 File Offset: 0x00188AC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 179886, XrefRangeEnd = 179950, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PlayerInventory.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005274 RID: 21108 RVA: 0x0018A900 File Offset: 0x00188B00
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 179973, RefRangeEnd = 179974, XrefRangeStart = 179950, XrefRangeEnd = 179973, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GiveStartupItems()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerInventory.NativeMethodInfoPtr_GiveStartupItems_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005275 RID: 21109 RVA: 0x0018A934 File Offset: 0x00188B34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 179974, XrefRangeEnd = 180021, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PlayerInventory.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005276 RID: 21110 RVA: 0x0018A970 File Offset: 0x00188B70
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 180064, RefRangeEnd = 180065, XrefRangeStart = 180021, XrefRangeEnd = 180064, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateHotbarSelection()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerInventory.NativeMethodInfoPtr_UpdateHotbarSelection_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005277 RID: 21111 RVA: 0x0018A9A4 File Offset: 0x00188BA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 180065, XrefRangeEnd = 180066, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Equip(HotbarSlot slot)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(slot);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerInventory.NativeMethodInfoPtr_Equip_Public_Void_HotbarSlot_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005278 RID: 21112 RVA: 0x0018A9E8 File Offset: 0x00188BE8
		[CallerCount(81)]
		[CachedScanResults(RefRangeStart = 180074, RefRangeEnd = 180155, XrefRangeStart = 180066, XrefRangeEnd = 180074, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetInventoryEnabled(bool enabled)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref enabled;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerInventory.NativeMethodInfoPtr_SetInventoryEnabled_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005279 RID: 21113 RVA: 0x0018AA28 File Offset: 0x00188C28
		[CallerCount(49)]
		[CachedScanResults(RefRangeStart = 180179, RefRangeEnd = 180228, XrefRangeStart = 180155, XrefRangeEnd = 180179, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetEquippingEnabled(bool enabled)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref enabled;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerInventory.NativeMethodInfoPtr_SetEquippingEnabled_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600527A RID: 21114 RVA: 0x0018AA68 File Offset: 0x00188C68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 180228, XrefRangeEnd = 180230, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ClipboardAcquiredVarChange(bool newVal)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref newVal;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerInventory.NativeMethodInfoPtr_ClipboardAcquiredVarChange_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600527B RID: 21115 RVA: 0x0018AAA8 File Offset: 0x00188CA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetManagementClipboardEnabled(bool enabled)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref enabled;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerInventory.NativeMethodInfoPtr_SetManagementClipboardEnabled_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600527C RID: 21116 RVA: 0x0018AAE8 File Offset: 0x00188CE8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 180250, RefRangeEnd = 180252, XrefRangeStart = 180230, XrefRangeEnd = 180250, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetViewmodelVisible(bool visible)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref visible;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerInventory.NativeMethodInfoPtr_SetViewmodelVisible_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600527D RID: 21117 RVA: 0x0018AB28 File Offset: 0x00188D28
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 180264, RefRangeEnd = 180267, XrefRangeStart = 180252, XrefRangeEnd = 180264, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool CanItemFitInInventory(ItemInstance item, int quantity = 1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref quantity;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(PlayerInventory.NativeMethodInfoPtr_CanItemFitInInventory_Public_Boolean_ItemInstance_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x0600527E RID: 21118 RVA: 0x0018AB84 File Offset: 0x00188D84
		[CallerCount(16)]
		[CachedScanResults(RefRangeStart = 180300, RefRangeEnd = 180316, XrefRangeStart = 180267, XrefRangeEnd = 180300, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddItemToInventory(ItemInstance item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerInventory.NativeMethodInfoPtr_AddItemToInventory_Public_Void_ItemInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600527F RID: 21119 RVA: 0x0018ABC8 File Offset: 0x00188DC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 180316, XrefRangeEnd = 180329, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe uint GetAmountOfItem(string ID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(ID);
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(PlayerInventory.NativeMethodInfoPtr_GetAmountOfItem_Public_UInt32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06005280 RID: 21120 RVA: 0x0018AC18 File Offset: 0x00188E18
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 180358, RefRangeEnd = 180361, XrefRangeStart = 180329, XrefRangeEnd = 180358, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveAmountOfItem(string ID, uint amount = 1U)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(ID);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref amount;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerInventory.NativeMethodInfoPtr_RemoveAmountOfItem_Public_Void_String_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005281 RID: 21121 RVA: 0x0018AC68 File Offset: 0x00188E68
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 180368, RefRangeEnd = 180369, XrefRangeStart = 180361, XrefRangeEnd = 180368, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ClearInventory()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerInventory.NativeMethodInfoPtr_ClearInventory_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005282 RID: 21122 RVA: 0x0018AC9C File Offset: 0x00188E9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 180369, XrefRangeEnd = 180389, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveProductFromInventory(EStealthLevel maxStealth)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref maxStealth;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerInventory.NativeMethodInfoPtr_RemoveProductFromInventory_Public_Void_EStealthLevel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005283 RID: 21123 RVA: 0x0018ACDC File Offset: 0x00188EDC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 180389, XrefRangeEnd = 180401, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveRandomItemsFromInventory()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerInventory.NativeMethodInfoPtr_RemoveRandomItemsFromInventory_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005284 RID: 21124 RVA: 0x0018AD10 File Offset: 0x00188F10
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 180407, RefRangeEnd = 180411, XrefRangeStart = 180401, XrefRangeEnd = 180407, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetEquippable(Equippable eq)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(eq);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerInventory.NativeMethodInfoPtr_SetEquippable_Public_Void_Equippable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005285 RID: 21125 RVA: 0x0018AD54 File Offset: 0x00188F54
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 180412, RefRangeEnd = 180413, XrefRangeStart = 180411, XrefRangeEnd = 180412, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Reequip()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerInventory.NativeMethodInfoPtr_Reequip_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005286 RID: 21126 RVA: 0x0018AD88 File Offset: 0x00188F88
		[CallerCount(17)]
		[CachedScanResults(RefRangeStart = 180431, RefRangeEnd = 180448, XrefRangeStart = 180413, XrefRangeEnd = 180431, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<ItemSlot> GetAllInventorySlots()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerInventory.NativeMethodInfoPtr_GetAllInventorySlots_Public_List_1_ItemSlot_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ItemSlot>>(intPtr2) : null;
		}

		// Token: 0x06005287 RID: 21127 RVA: 0x0018ADC8 File Offset: 0x00188FC8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 180539, RefRangeEnd = 180541, XrefRangeStart = 180448, XrefRangeEnd = 180539, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateInventoryVariables()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerInventory.NativeMethodInfoPtr_UpdateInventoryVariables_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005288 RID: 21128 RVA: 0x0018ADFC File Offset: 0x00188FFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 180541, XrefRangeEnd = 180572, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PlayerInventory() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayerInventory>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerInventory.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005289 RID: 21129 RVA: 0x0018AE38 File Offset: 0x00189038
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 180572, XrefRangeEnd = 180579, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _Start_b__56_1()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerInventory.NativeMethodInfoPtr__Start_b__56_1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600528A RID: 21130 RVA: 0x00026F72 File Offset: 0x00025172
		public PlayerInventory(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001881 RID: 6273
		// (get) Token: 0x0600528B RID: 21131 RVA: 0x0018AE6C File Offset: 0x0018906C
		// (set) Token: 0x0600528C RID: 21132 RVA: 0x00026F7B File Offset: 0x0002517B
		public unsafe static float LABEL_DISPLAY_TIME
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(PlayerInventory.NativeFieldInfoPtr_LABEL_DISPLAY_TIME, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PlayerInventory.NativeFieldInfoPtr_LABEL_DISPLAY_TIME, (void*)(&value));
			}
		}

		// Token: 0x17001882 RID: 6274
		// (get) Token: 0x0600528D RID: 21133 RVA: 0x0018AE88 File Offset: 0x00189088
		// (set) Token: 0x0600528E RID: 21134 RVA: 0x00026F89 File Offset: 0x00025189
		public unsafe static float LABEL_FADE_TIME
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(PlayerInventory.NativeFieldInfoPtr_LABEL_FADE_TIME, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PlayerInventory.NativeFieldInfoPtr_LABEL_FADE_TIME, (void*)(&value));
			}
		}

		// Token: 0x17001883 RID: 6275
		// (get) Token: 0x0600528F RID: 21135 RVA: 0x0018AEA4 File Offset: 0x001890A4
		// (set) Token: 0x06005290 RID: 21136 RVA: 0x00026F97 File Offset: 0x00025197
		public unsafe static float DISCARD_TIME
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(PlayerInventory.NativeFieldInfoPtr_DISCARD_TIME, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PlayerInventory.NativeFieldInfoPtr_DISCARD_TIME, (void*)(&value));
			}
		}

		// Token: 0x17001884 RID: 6276
		// (get) Token: 0x06005291 RID: 21137 RVA: 0x0018AEC0 File Offset: 0x001890C0
		// (set) Token: 0x06005292 RID: 21138 RVA: 0x00026FA5 File Offset: 0x000251A5
		public unsafe static int INVENTORY_SLOT_COUNT
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(PlayerInventory.NativeFieldInfoPtr_INVENTORY_SLOT_COUNT, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PlayerInventory.NativeFieldInfoPtr_INVENTORY_SLOT_COUNT, (void*)(&value));
			}
		}

		// Token: 0x17001885 RID: 6277
		// (get) Token: 0x06005293 RID: 21139 RVA: 0x0018AEDC File Offset: 0x001890DC
		// (set) Token: 0x06005294 RID: 21140 RVA: 0x00026FB3 File Offset: 0x000251B3
		public unsafe bool giveStartupItems
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerInventory.NativeFieldInfoPtr_giveStartupItems);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerInventory.NativeFieldInfoPtr_giveStartupItems)) = value;
			}
		}

		// Token: 0x17001886 RID: 6278
		// (get) Token: 0x06005295 RID: 21141 RVA: 0x0018AF04 File Offset: 0x00189104
		// (set) Token: 0x06005296 RID: 21142 RVA: 0x00026FCE File Offset: 0x000251CE
		public unsafe List<PlayerInventory.ItemAmount> startupItems
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerInventory.NativeFieldInfoPtr_startupItems);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<PlayerInventory.ItemAmount>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerInventory.NativeFieldInfoPtr_startupItems), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001887 RID: 6279
		// (get) Token: 0x06005297 RID: 21143 RVA: 0x0018AF34 File Offset: 0x00189134
		// (set) Token: 0x06005298 RID: 21144 RVA: 0x00026FED File Offset: 0x000251ED
		public unsafe Transform equipContainer
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerInventory.NativeFieldInfoPtr_equipContainer);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerInventory.NativeFieldInfoPtr_equipContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001888 RID: 6280
		// (get) Token: 0x06005299 RID: 21145 RVA: 0x0018AF64 File Offset: 0x00189164
		// (set) Token: 0x0600529A RID: 21146 RVA: 0x0002700C File Offset: 0x0002520C
		public unsafe List<HotbarSlot> hotbarSlots
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerInventory.NativeFieldInfoPtr_hotbarSlots);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<HotbarSlot>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerInventory.NativeFieldInfoPtr_hotbarSlots), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001889 RID: 6281
		// (get) Token: 0x0600529B RID: 21147 RVA: 0x0018AF94 File Offset: 0x00189194
		// (set) Token: 0x0600529C RID: 21148 RVA: 0x0002702B File Offset: 0x0002522B
		public unsafe CashSlot _cashSlot_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerInventory.NativeFieldInfoPtr__cashSlot_k__BackingField);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CashSlot>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerInventory.NativeFieldInfoPtr__cashSlot_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700188A RID: 6282
		// (get) Token: 0x0600529D RID: 21149 RVA: 0x0018AFC4 File Offset: 0x001891C4
		// (set) Token: 0x0600529E RID: 21150 RVA: 0x0002704A File Offset: 0x0002524A
		public unsafe CashInstance _cashInstance_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerInventory.NativeFieldInfoPtr__cashInstance_k__BackingField);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CashInstance>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerInventory.NativeFieldInfoPtr__cashInstance_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700188B RID: 6283
		// (get) Token: 0x0600529F RID: 21151 RVA: 0x0018AFF4 File Offset: 0x001891F4
		// (set) Token: 0x060052A0 RID: 21152 RVA: 0x00027069 File Offset: 0x00025269
		public unsafe ClipboardSlot clipboardSlot
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerInventory.NativeFieldInfoPtr_clipboardSlot);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ClipboardSlot>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerInventory.NativeFieldInfoPtr_clipboardSlot), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700188C RID: 6284
		// (get) Token: 0x060052A1 RID: 21153 RVA: 0x0018B024 File Offset: 0x00189224
		// (set) Token: 0x060052A2 RID: 21154 RVA: 0x00027088 File Offset: 0x00025288
		public unsafe List<ItemSlotUI> slotUIs
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerInventory.NativeFieldInfoPtr_slotUIs);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ItemSlotUI>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerInventory.NativeFieldInfoPtr_slotUIs), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700188D RID: 6285
		// (get) Token: 0x060052A3 RID: 21155 RVA: 0x0018B054 File Offset: 0x00189254
		// (set) Token: 0x060052A4 RID: 21156 RVA: 0x000270A7 File Offset: 0x000252A7
		public unsafe ItemSlot discardSlot
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerInventory.NativeFieldInfoPtr_discardSlot);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemSlot>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerInventory.NativeFieldInfoPtr_discardSlot), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700188E RID: 6286
		// (get) Token: 0x060052A5 RID: 21157 RVA: 0x0018B084 File Offset: 0x00189284
		// (set) Token: 0x060052A6 RID: 21158 RVA: 0x000270C6 File Offset: 0x000252C6
		public unsafe List<PlayerInventory.ItemVariable> ItemVariables
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerInventory.NativeFieldInfoPtr_ItemVariables);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<PlayerInventory.ItemVariable>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerInventory.NativeFieldInfoPtr_ItemVariables), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700188F RID: 6287
		// (get) Token: 0x060052A7 RID: 21159 RVA: 0x0018B0B4 File Offset: 0x001892B4
		// (set) Token: 0x060052A8 RID: 21160 RVA: 0x000270E5 File Offset: 0x000252E5
		public unsafe int _EquippedSlotIndex_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerInventory.NativeFieldInfoPtr__EquippedSlotIndex_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerInventory.NativeFieldInfoPtr__EquippedSlotIndex_k__BackingField)) = value;
			}
		}

		// Token: 0x17001890 RID: 6288
		// (get) Token: 0x060052A9 RID: 21161 RVA: 0x0018B0DC File Offset: 0x001892DC
		// (set) Token: 0x060052AA RID: 21162 RVA: 0x00027100 File Offset: 0x00025300
		public unsafe bool _HotbarEnabled_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerInventory.NativeFieldInfoPtr__HotbarEnabled_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerInventory.NativeFieldInfoPtr__HotbarEnabled_k__BackingField)) = value;
			}
		}

		// Token: 0x17001891 RID: 6289
		// (get) Token: 0x060052AB RID: 21163 RVA: 0x0018B104 File Offset: 0x00189304
		// (set) Token: 0x060052AC RID: 21164 RVA: 0x0002711B File Offset: 0x0002531B
		public unsafe bool _EquippingEnabled_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerInventory.NativeFieldInfoPtr__EquippingEnabled_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerInventory.NativeFieldInfoPtr__EquippingEnabled_k__BackingField)) = value;
			}
		}

		// Token: 0x17001892 RID: 6290
		// (get) Token: 0x060052AD RID: 21165 RVA: 0x0018B12C File Offset: 0x0018932C
		// (set) Token: 0x060052AE RID: 21166 RVA: 0x00027136 File Offset: 0x00025336
		public unsafe Equippable _equippable_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerInventory.NativeFieldInfoPtr__equippable_k__BackingField);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Equippable>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerInventory.NativeFieldInfoPtr__equippable_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001893 RID: 6291
		// (get) Token: 0x060052AF RID: 21167 RVA: 0x0018B15C File Offset: 0x0018935C
		// (set) Token: 0x060052B0 RID: 21168 RVA: 0x00027155 File Offset: 0x00025355
		public unsafe Il2CppSystem.Action<bool> onInventoryStateChanged
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerInventory.NativeFieldInfoPtr_onInventoryStateChanged);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Action<bool>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerInventory.NativeFieldInfoPtr_onInventoryStateChanged), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001894 RID: 6292
		// (get) Token: 0x060052B1 RID: 21169 RVA: 0x0018B18C File Offset: 0x0018938C
		// (set) Token: 0x060052B2 RID: 21170 RVA: 0x00027174 File Offset: 0x00025374
		public unsafe int PriorEquippedSlotIndex
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerInventory.NativeFieldInfoPtr_PriorEquippedSlotIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerInventory.NativeFieldInfoPtr_PriorEquippedSlotIndex)) = value;
			}
		}

		// Token: 0x17001895 RID: 6293
		// (get) Token: 0x060052B3 RID: 21171 RVA: 0x0018B1B4 File Offset: 0x001893B4
		// (set) Token: 0x060052B4 RID: 21172 RVA: 0x0002718F File Offset: 0x0002538F
		public unsafe int PreviousEquippedSlotIndex
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerInventory.NativeFieldInfoPtr_PreviousEquippedSlotIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerInventory.NativeFieldInfoPtr_PreviousEquippedSlotIndex)) = value;
			}
		}

		// Token: 0x17001896 RID: 6294
		// (get) Token: 0x060052B5 RID: 21173 RVA: 0x0018B1DC File Offset: 0x001893DC
		// (set) Token: 0x060052B6 RID: 21174 RVA: 0x000271AA File Offset: 0x000253AA
		public unsafe UnityEvent onPreItemEquipped
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerInventory.NativeFieldInfoPtr_onPreItemEquipped);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerInventory.NativeFieldInfoPtr_onPreItemEquipped), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001897 RID: 6295
		// (get) Token: 0x060052B7 RID: 21175 RVA: 0x0018B20C File Offset: 0x0018940C
		// (set) Token: 0x060052B8 RID: 21176 RVA: 0x000271C9 File Offset: 0x000253C9
		public unsafe UnityEvent onItemEquipped
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerInventory.NativeFieldInfoPtr_onItemEquipped);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerInventory.NativeFieldInfoPtr_onItemEquipped), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001898 RID: 6296
		// (get) Token: 0x060052B9 RID: 21177 RVA: 0x0018B23C File Offset: 0x0018943C
		// (set) Token: 0x060052BA RID: 21178 RVA: 0x000271E8 File Offset: 0x000253E8
		public unsafe bool ManagementSlotEnabled
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerInventory.NativeFieldInfoPtr_ManagementSlotEnabled);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerInventory.NativeFieldInfoPtr_ManagementSlotEnabled)) = value;
			}
		}

		// Token: 0x17001899 RID: 6297
		// (get) Token: 0x060052BB RID: 21179 RVA: 0x0018B264 File Offset: 0x00189464
		// (set) Token: 0x060052BC RID: 21180 RVA: 0x00027203 File Offset: 0x00025403
		public unsafe float currentEquipTime
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerInventory.NativeFieldInfoPtr_currentEquipTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerInventory.NativeFieldInfoPtr_currentEquipTime)) = value;
			}
		}

		// Token: 0x1700189A RID: 6298
		// (get) Token: 0x060052BD RID: 21181 RVA: 0x0018B28C File Offset: 0x0018948C
		// (set) Token: 0x060052BE RID: 21182 RVA: 0x0002721E File Offset: 0x0002541E
		public unsafe float currentDiscardTime
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerInventory.NativeFieldInfoPtr_currentDiscardTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerInventory.NativeFieldInfoPtr_currentDiscardTime)) = value;
			}
		}

		// Token: 0x040037E1 RID: 14305
		private static readonly System.IntPtr NativeFieldInfoPtr_LABEL_DISPLAY_TIME;

		// Token: 0x040037E2 RID: 14306
		private static readonly System.IntPtr NativeFieldInfoPtr_LABEL_FADE_TIME;

		// Token: 0x040037E3 RID: 14307
		private static readonly System.IntPtr NativeFieldInfoPtr_DISCARD_TIME;

		// Token: 0x040037E4 RID: 14308
		private static readonly System.IntPtr NativeFieldInfoPtr_INVENTORY_SLOT_COUNT;

		// Token: 0x040037E5 RID: 14309
		private static readonly System.IntPtr NativeFieldInfoPtr_giveStartupItems;

		// Token: 0x040037E6 RID: 14310
		private static readonly System.IntPtr NativeFieldInfoPtr_startupItems;

		// Token: 0x040037E7 RID: 14311
		private static readonly System.IntPtr NativeFieldInfoPtr_equipContainer;

		// Token: 0x040037E8 RID: 14312
		private static readonly System.IntPtr NativeFieldInfoPtr_hotbarSlots;

		// Token: 0x040037E9 RID: 14313
		private static readonly System.IntPtr NativeFieldInfoPtr__cashSlot_k__BackingField;

		// Token: 0x040037EA RID: 14314
		private static readonly System.IntPtr NativeFieldInfoPtr__cashInstance_k__BackingField;

		// Token: 0x040037EB RID: 14315
		private static readonly System.IntPtr NativeFieldInfoPtr_clipboardSlot;

		// Token: 0x040037EC RID: 14316
		private static readonly System.IntPtr NativeFieldInfoPtr_slotUIs;

		// Token: 0x040037ED RID: 14317
		private static readonly System.IntPtr NativeFieldInfoPtr_discardSlot;

		// Token: 0x040037EE RID: 14318
		private static readonly System.IntPtr NativeFieldInfoPtr_ItemVariables;

		// Token: 0x040037EF RID: 14319
		private static readonly System.IntPtr NativeFieldInfoPtr__EquippedSlotIndex_k__BackingField;

		// Token: 0x040037F0 RID: 14320
		private static readonly System.IntPtr NativeFieldInfoPtr__HotbarEnabled_k__BackingField;

		// Token: 0x040037F1 RID: 14321
		private static readonly System.IntPtr NativeFieldInfoPtr__EquippingEnabled_k__BackingField;

		// Token: 0x040037F2 RID: 14322
		private static readonly System.IntPtr NativeFieldInfoPtr__equippable_k__BackingField;

		// Token: 0x040037F3 RID: 14323
		private static readonly System.IntPtr NativeFieldInfoPtr_onInventoryStateChanged;

		// Token: 0x040037F4 RID: 14324
		private static readonly System.IntPtr NativeFieldInfoPtr_PriorEquippedSlotIndex;

		// Token: 0x040037F5 RID: 14325
		private static readonly System.IntPtr NativeFieldInfoPtr_PreviousEquippedSlotIndex;

		// Token: 0x040037F6 RID: 14326
		private static readonly System.IntPtr NativeFieldInfoPtr_onPreItemEquipped;

		// Token: 0x040037F7 RID: 14327
		private static readonly System.IntPtr NativeFieldInfoPtr_onItemEquipped;

		// Token: 0x040037F8 RID: 14328
		private static readonly System.IntPtr NativeFieldInfoPtr_ManagementSlotEnabled;

		// Token: 0x040037F9 RID: 14329
		private static readonly System.IntPtr NativeFieldInfoPtr_currentEquipTime;

		// Token: 0x040037FA RID: 14330
		private static readonly System.IntPtr NativeFieldInfoPtr_currentDiscardTime;

		// Token: 0x040037FB RID: 14331
		private static readonly System.IntPtr NativeMethodInfoPtr_get_TOTAL_SLOT_COUNT_Public_get_Int32_0;

		// Token: 0x040037FC RID: 14332
		private static readonly System.IntPtr NativeMethodInfoPtr_get_cashSlot_Public_get_CashSlot_0;

		// Token: 0x040037FD RID: 14333
		private static readonly System.IntPtr NativeMethodInfoPtr_set_cashSlot_Private_set_Void_CashSlot_0;

		// Token: 0x040037FE RID: 14334
		private static readonly System.IntPtr NativeMethodInfoPtr_get_cashInstance_Public_get_CashInstance_0;

		// Token: 0x040037FF RID: 14335
		private static readonly System.IntPtr NativeMethodInfoPtr_set_cashInstance_Protected_set_Void_CashInstance_0;

		// Token: 0x04003800 RID: 14336
		private static readonly System.IntPtr NativeMethodInfoPtr_get_EquippedSlotIndex_Public_get_Int32_0;

		// Token: 0x04003801 RID: 14337
		private static readonly System.IntPtr NativeMethodInfoPtr_set_EquippedSlotIndex_Protected_set_Void_Int32_0;

		// Token: 0x04003802 RID: 14338
		private static readonly System.IntPtr NativeMethodInfoPtr_get_HotbarEnabled_Public_get_Boolean_0;

		// Token: 0x04003803 RID: 14339
		private static readonly System.IntPtr NativeMethodInfoPtr_set_HotbarEnabled_Protected_set_Void_Boolean_0;

		// Token: 0x04003804 RID: 14340
		private static readonly System.IntPtr NativeMethodInfoPtr_get_EquippingEnabled_Public_get_Boolean_0;

		// Token: 0x04003805 RID: 14341
		private static readonly System.IntPtr NativeMethodInfoPtr_set_EquippingEnabled_Protected_set_Void_Boolean_0;

		// Token: 0x04003806 RID: 14342
		private static readonly System.IntPtr NativeMethodInfoPtr_get_equippable_Public_get_Equippable_0;

		// Token: 0x04003807 RID: 14343
		private static readonly System.IntPtr NativeMethodInfoPtr_set_equippable_Protected_set_Void_Equippable_0;

		// Token: 0x04003808 RID: 14344
		private static readonly System.IntPtr NativeMethodInfoPtr_get_equippedSlot_Public_get_HotbarSlot_0;

		// Token: 0x04003809 RID: 14345
		private static readonly System.IntPtr NativeMethodInfoPtr_get_isAnythingEquipped_Public_get_Boolean_0;

		// Token: 0x0400380A RID: 14346
		private static readonly System.IntPtr NativeMethodInfoPtr_IndexAllSlots_Public_HotbarSlot_Int32_0;

		// Token: 0x0400380B RID: 14347
		private static readonly System.IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0;

		// Token: 0x0400380C RID: 14348
		private static readonly System.IntPtr NativeMethodInfoPtr_SetupInventoryUI_Private_Void_0;

		// Token: 0x0400380D RID: 14349
		private static readonly System.IntPtr NativeMethodInfoPtr_RepositionUI_Private_Void_0;

		// Token: 0x0400380E RID: 14350
		private static readonly System.IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x0400380F RID: 14351
		private static readonly System.IntPtr NativeMethodInfoPtr_GiveStartupItems_Private_Void_0;

		// Token: 0x04003810 RID: 14352
		private static readonly System.IntPtr NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0;

		// Token: 0x04003811 RID: 14353
		private static readonly System.IntPtr NativeMethodInfoPtr_UpdateHotbarSelection_Private_Void_0;

		// Token: 0x04003812 RID: 14354
		private static readonly System.IntPtr NativeMethodInfoPtr_Equip_Public_Void_HotbarSlot_0;

		// Token: 0x04003813 RID: 14355
		private static readonly System.IntPtr NativeMethodInfoPtr_SetInventoryEnabled_Public_Void_Boolean_0;

		// Token: 0x04003814 RID: 14356
		private static readonly System.IntPtr NativeMethodInfoPtr_SetEquippingEnabled_Public_Void_Boolean_0;

		// Token: 0x04003815 RID: 14357
		private static readonly System.IntPtr NativeMethodInfoPtr_ClipboardAcquiredVarChange_Private_Void_Boolean_0;

		// Token: 0x04003816 RID: 14358
		private static readonly System.IntPtr NativeMethodInfoPtr_SetManagementClipboardEnabled_Public_Void_Boolean_0;

		// Token: 0x04003817 RID: 14359
		private static readonly System.IntPtr NativeMethodInfoPtr_SetViewmodelVisible_Public_Void_Boolean_0;

		// Token: 0x04003818 RID: 14360
		private static readonly System.IntPtr NativeMethodInfoPtr_CanItemFitInInventory_Public_Boolean_ItemInstance_Int32_0;

		// Token: 0x04003819 RID: 14361
		private static readonly System.IntPtr NativeMethodInfoPtr_AddItemToInventory_Public_Void_ItemInstance_0;

		// Token: 0x0400381A RID: 14362
		private static readonly System.IntPtr NativeMethodInfoPtr_GetAmountOfItem_Public_UInt32_String_0;

		// Token: 0x0400381B RID: 14363
		private static readonly System.IntPtr NativeMethodInfoPtr_RemoveAmountOfItem_Public_Void_String_UInt32_0;

		// Token: 0x0400381C RID: 14364
		private static readonly System.IntPtr NativeMethodInfoPtr_ClearInventory_Public_Void_0;

		// Token: 0x0400381D RID: 14365
		private static readonly System.IntPtr NativeMethodInfoPtr_RemoveProductFromInventory_Public_Void_EStealthLevel_0;

		// Token: 0x0400381E RID: 14366
		private static readonly System.IntPtr NativeMethodInfoPtr_RemoveRandomItemsFromInventory_Public_Void_0;

		// Token: 0x0400381F RID: 14367
		private static readonly System.IntPtr NativeMethodInfoPtr_SetEquippable_Public_Void_Equippable_0;

		// Token: 0x04003820 RID: 14368
		private static readonly System.IntPtr NativeMethodInfoPtr_Reequip_Public_Void_0;

		// Token: 0x04003821 RID: 14369
		private static readonly System.IntPtr NativeMethodInfoPtr_GetAllInventorySlots_Public_List_1_ItemSlot_0;

		// Token: 0x04003822 RID: 14370
		private static readonly System.IntPtr NativeMethodInfoPtr_UpdateInventoryVariables_Private_Void_0;

		// Token: 0x04003823 RID: 14371
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04003824 RID: 14372
		private static readonly System.IntPtr NativeMethodInfoPtr__Start_b__56_1_Private_Void_0;

		// Token: 0x020009EC RID: 2540
		[System.Serializable]
		public class ItemVariable : Il2CppSystem.Object
		{
			// Token: 0x0600D04A RID: 53322 RVA: 0x00326E78 File Offset: 0x00325078
			// Note: this type is marked as 'beforefieldinit'.
			static ItemVariable()
			{
				Il2CppClassPointerStore<PlayerInventory.ItemVariable>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PlayerInventory>.NativeClassPtr, "ItemVariable");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayerInventory.ItemVariable>.NativeClassPtr);
				PlayerInventory.ItemVariable.NativeFieldInfoPtr_Definition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerInventory.ItemVariable>.NativeClassPtr, "Definition");
				PlayerInventory.ItemVariable.NativeFieldInfoPtr_VariableName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerInventory.ItemVariable>.NativeClassPtr, "VariableName");
				PlayerInventory.ItemVariable.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerInventory.ItemVariable>.NativeClassPtr, 100673757);
			}

			// Token: 0x0600D04B RID: 53323 RVA: 0x00326EE0 File Offset: 0x003250E0
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ItemVariable() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayerInventory.ItemVariable>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerInventory.ItemVariable.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600D04C RID: 53324 RVA: 0x00064FB8 File Offset: 0x000631B8
			public ItemVariable(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004094 RID: 16532
			// (get) Token: 0x0600D04D RID: 53325 RVA: 0x00326F1C File Offset: 0x0032511C
			// (set) Token: 0x0600D04E RID: 53326 RVA: 0x00064FC1 File Offset: 0x000631C1
			public unsafe ItemDefinition Definition
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerInventory.ItemVariable.NativeFieldInfoPtr_Definition);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemDefinition>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerInventory.ItemVariable.NativeFieldInfoPtr_Definition), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004095 RID: 16533
			// (get) Token: 0x0600D04F RID: 53327 RVA: 0x00326F4C File Offset: 0x0032514C
			// (set) Token: 0x0600D050 RID: 53328 RVA: 0x00064FE0 File Offset: 0x000631E0
			public unsafe string VariableName
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerInventory.ItemVariable.NativeFieldInfoPtr_VariableName);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerInventory.ItemVariable.NativeFieldInfoPtr_VariableName), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x04008CE3 RID: 36067
			private static readonly System.IntPtr NativeFieldInfoPtr_Definition;

			// Token: 0x04008CE4 RID: 36068
			private static readonly System.IntPtr NativeFieldInfoPtr_VariableName;

			// Token: 0x04008CE5 RID: 36069
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x020009ED RID: 2541
		[System.Serializable]
		public class ItemAmount : Il2CppSystem.Object
		{
			// Token: 0x0600D051 RID: 53329 RVA: 0x00326F74 File Offset: 0x00325174
			// Note: this type is marked as 'beforefieldinit'.
			static ItemAmount()
			{
				Il2CppClassPointerStore<PlayerInventory.ItemAmount>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PlayerInventory>.NativeClassPtr, "ItemAmount");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayerInventory.ItemAmount>.NativeClassPtr);
				PlayerInventory.ItemAmount.NativeFieldInfoPtr_Definition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerInventory.ItemAmount>.NativeClassPtr, "Definition");
				PlayerInventory.ItemAmount.NativeFieldInfoPtr_Amount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerInventory.ItemAmount>.NativeClassPtr, "Amount");
				PlayerInventory.ItemAmount.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerInventory.ItemAmount>.NativeClassPtr, 100673758);
			}

			// Token: 0x0600D052 RID: 53330 RVA: 0x00326FDC File Offset: 0x003251DC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 179612, XrefRangeEnd = 179613, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ItemAmount() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayerInventory.ItemAmount>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerInventory.ItemAmount.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600D053 RID: 53331 RVA: 0x00064FFF File Offset: 0x000631FF
			public ItemAmount(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004096 RID: 16534
			// (get) Token: 0x0600D054 RID: 53332 RVA: 0x00327018 File Offset: 0x00325218
			// (set) Token: 0x0600D055 RID: 53333 RVA: 0x00065008 File Offset: 0x00063208
			public unsafe ItemDefinition Definition
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerInventory.ItemAmount.NativeFieldInfoPtr_Definition);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemDefinition>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerInventory.ItemAmount.NativeFieldInfoPtr_Definition), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004097 RID: 16535
			// (get) Token: 0x0600D056 RID: 53334 RVA: 0x00327048 File Offset: 0x00325248
			// (set) Token: 0x0600D057 RID: 53335 RVA: 0x00065027 File Offset: 0x00063227
			public unsafe int Amount
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerInventory.ItemAmount.NativeFieldInfoPtr_Amount);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerInventory.ItemAmount.NativeFieldInfoPtr_Amount)) = value;
				}
			}

			// Token: 0x04008CE6 RID: 36070
			private static readonly System.IntPtr NativeFieldInfoPtr_Definition;

			// Token: 0x04008CE7 RID: 36071
			private static readonly System.IntPtr NativeFieldInfoPtr_Amount;

			// Token: 0x04008CE8 RID: 36072
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x020009EE RID: 2542
		[ObfuscatedName("ScheduleOne.PlayerScripts.PlayerInventory+<>c__DisplayClass56_0")]
		public sealed class __c__DisplayClass56_0 : Il2CppSystem.Object
		{
			// Token: 0x0600D058 RID: 53336 RVA: 0x00327070 File Offset: 0x00325270
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass56_0()
			{
				Il2CppClassPointerStore<PlayerInventory.__c__DisplayClass56_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PlayerInventory>.NativeClassPtr, "<>c__DisplayClass56_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayerInventory.__c__DisplayClass56_0>.NativeClassPtr);
				PlayerInventory.__c__DisplayClass56_0.NativeFieldInfoPtr_index = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerInventory.__c__DisplayClass56_0>.NativeClassPtr, "index");
				PlayerInventory.__c__DisplayClass56_0.NativeFieldInfoPtr_slot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerInventory.__c__DisplayClass56_0>.NativeClassPtr, "slot");
				PlayerInventory.__c__DisplayClass56_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerInventory.__c__DisplayClass56_0>.NativeClassPtr, "<>4__this");
				PlayerInventory.__c__DisplayClass56_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerInventory.__c__DisplayClass56_0>.NativeClassPtr, 100673759);
				PlayerInventory.__c__DisplayClass56_0.NativeMethodInfoPtr__Start_b__0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerInventory.__c__DisplayClass56_0>.NativeClassPtr, 100673760);
			}

			// Token: 0x0600D059 RID: 53337 RVA: 0x00327100 File Offset: 0x00325300
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass56_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayerInventory.__c__DisplayClass56_0>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerInventory.__c__DisplayClass56_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600D05A RID: 53338 RVA: 0x0032713C File Offset: 0x0032533C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 179613, XrefRangeEnd = 179627, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _Start_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerInventory.__c__DisplayClass56_0.NativeMethodInfoPtr__Start_b__0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600D05B RID: 53339 RVA: 0x00065042 File Offset: 0x00063242
			public __c__DisplayClass56_0(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004098 RID: 16536
			// (get) Token: 0x0600D05C RID: 53340 RVA: 0x00327170 File Offset: 0x00325370
			// (set) Token: 0x0600D05D RID: 53341 RVA: 0x0006504B File Offset: 0x0006324B
			public unsafe int index
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerInventory.__c__DisplayClass56_0.NativeFieldInfoPtr_index);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerInventory.__c__DisplayClass56_0.NativeFieldInfoPtr_index)) = value;
				}
			}

			// Token: 0x17004099 RID: 16537
			// (get) Token: 0x0600D05E RID: 53342 RVA: 0x00327198 File Offset: 0x00325398
			// (set) Token: 0x0600D05F RID: 53343 RVA: 0x00065066 File Offset: 0x00063266
			public unsafe HotbarSlot slot
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerInventory.__c__DisplayClass56_0.NativeFieldInfoPtr_slot);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<HotbarSlot>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerInventory.__c__DisplayClass56_0.NativeFieldInfoPtr_slot), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700409A RID: 16538
			// (get) Token: 0x0600D060 RID: 53344 RVA: 0x003271C8 File Offset: 0x003253C8
			// (set) Token: 0x0600D061 RID: 53345 RVA: 0x00065085 File Offset: 0x00063285
			public unsafe PlayerInventory __4__this
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerInventory.__c__DisplayClass56_0.NativeFieldInfoPtr___4__this);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlayerInventory>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerInventory.__c__DisplayClass56_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008CE9 RID: 36073
			private static readonly System.IntPtr NativeFieldInfoPtr_index;

			// Token: 0x04008CEA RID: 36074
			private static readonly System.IntPtr NativeFieldInfoPtr_slot;

			// Token: 0x04008CEB RID: 36075
			private static readonly System.IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04008CEC RID: 36076
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008CED RID: 36077
			private static readonly System.IntPtr NativeMethodInfoPtr__Start_b__0_Internal_Void_0;
		}
	}
}
