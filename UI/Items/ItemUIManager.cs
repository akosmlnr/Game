using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using Il2CppScheduleOne.ItemFramework;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using Il2CppTMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI.Items
{
	// Token: 0x02000744 RID: 1860
	public class ItemUIManager : Singleton<ItemUIManager>
	{
		// Token: 0x0600A697 RID: 42647 RVA: 0x0029E674 File Offset: 0x0029C874
		// Note: this type is marked as 'beforefieldinit'.
		static ItemUIManager()
		{
			Il2CppClassPointerStore<ItemUIManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Items", "ItemUIManager");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ItemUIManager>.NativeClassPtr);
			ItemUIManager.NativeFieldInfoPtr__DraggingEnabled_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemUIManager>.NativeClassPtr, "<DraggingEnabled>k__BackingField");
			ItemUIManager.NativeFieldInfoPtr__HoveredSlot_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemUIManager>.NativeClassPtr, "<HoveredSlot>k__BackingField");
			ItemUIManager.NativeFieldInfoPtr__QuickMoveEnabled_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemUIManager>.NativeClassPtr, "<QuickMoveEnabled>k__BackingField");
			ItemUIManager.NativeFieldInfoPtr_Canvas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemUIManager>.NativeClassPtr, "Canvas");
			ItemUIManager.NativeFieldInfoPtr_Raycasters = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemUIManager>.NativeClassPtr, "Raycasters");
			ItemUIManager.NativeFieldInfoPtr_CashDragAmountContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemUIManager>.NativeClassPtr, "CashDragAmountContainer");
			ItemUIManager.NativeFieldInfoPtr_InputsContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemUIManager>.NativeClassPtr, "InputsContainer");
			ItemUIManager.NativeFieldInfoPtr_InfoPanel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemUIManager>.NativeClassPtr, "InfoPanel");
			ItemUIManager.NativeFieldInfoPtr_ItemQuantityPrompt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemUIManager>.NativeClassPtr, "ItemQuantityPrompt");
			ItemUIManager.NativeFieldInfoPtr_CashSlotHintAnim = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemUIManager>.NativeClassPtr, "CashSlotHintAnim");
			ItemUIManager.NativeFieldInfoPtr_CashSlotHintAnimCanvasGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemUIManager>.NativeClassPtr, "CashSlotHintAnimCanvasGroup");
			ItemUIManager.NativeFieldInfoPtr_FilterConfigPanel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemUIManager>.NativeClassPtr, "FilterConfigPanel");
			ItemUIManager.NativeFieldInfoPtr_ItemSlotUIPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemUIManager>.NativeClassPtr, "ItemSlotUIPrefab");
			ItemUIManager.NativeFieldInfoPtr_DefaultItemUIPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemUIManager>.NativeClassPtr, "DefaultItemUIPrefab");
			ItemUIManager.NativeFieldInfoPtr_HotbarSlotUIPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemUIManager>.NativeClassPtr, "HotbarSlotUIPrefab");
			ItemUIManager.NativeFieldInfoPtr_draggedSlot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemUIManager>.NativeClassPtr, "draggedSlot");
			ItemUIManager.NativeFieldInfoPtr_mouseOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemUIManager>.NativeClassPtr, "mouseOffset");
			ItemUIManager.NativeFieldInfoPtr_draggedAmount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemUIManager>.NativeClassPtr, "draggedAmount");
			ItemUIManager.NativeFieldInfoPtr_tempIcon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemUIManager>.NativeClassPtr, "tempIcon");
			ItemUIManager.NativeFieldInfoPtr_isDraggingCash = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemUIManager>.NativeClassPtr, "isDraggingCash");
			ItemUIManager.NativeFieldInfoPtr_draggedCashAmount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemUIManager>.NativeClassPtr, "draggedCashAmount");
			ItemUIManager.NativeFieldInfoPtr_PrimarySlots = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemUIManager>.NativeClassPtr, "PrimarySlots");
			ItemUIManager.NativeFieldInfoPtr_SecondarySlots = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemUIManager>.NativeClassPtr, "SecondarySlots");
			ItemUIManager.NativeFieldInfoPtr_customDragAmount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemUIManager>.NativeClassPtr, "customDragAmount");
			ItemUIManager.NativeFieldInfoPtr_quantityChangePopRoutine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemUIManager>.NativeClassPtr, "quantityChangePopRoutine");
			ItemUIManager.NativeFieldInfoPtr_onDragStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemUIManager>.NativeClassPtr, "onDragStart");
			ItemUIManager.NativeFieldInfoPtr_onItemMoved = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemUIManager>.NativeClassPtr, "onItemMoved");
			ItemUIManager.NativeMethodInfoPtr_get_DraggingEnabled_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemUIManager>.NativeClassPtr, 100683771);
			ItemUIManager.NativeMethodInfoPtr_set_DraggingEnabled_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemUIManager>.NativeClassPtr, 100683772);
			ItemUIManager.NativeMethodInfoPtr_get_HoveredSlot_Public_get_ItemSlotUI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemUIManager>.NativeClassPtr, 100683773);
			ItemUIManager.NativeMethodInfoPtr_set_HoveredSlot_Protected_set_Void_ItemSlotUI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemUIManager>.NativeClassPtr, 100683774);
			ItemUIManager.NativeMethodInfoPtr_get_QuickMoveEnabled_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemUIManager>.NativeClassPtr, 100683775);
			ItemUIManager.NativeMethodInfoPtr_set_QuickMoveEnabled_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemUIManager>.NativeClassPtr, 100683776);
			ItemUIManager.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemUIManager>.NativeClassPtr, 100683777);
			ItemUIManager.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemUIManager>.NativeClassPtr, 100683778);
			ItemUIManager.NativeMethodInfoPtr_LateUpdate_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemUIManager>.NativeClassPtr, 100683779);
			ItemUIManager.NativeMethodInfoPtr_UpdateCashDragSelectorUI_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemUIManager>.NativeClassPtr, 100683780);
			ItemUIManager.NativeMethodInfoPtr_UpdateCashDragAmount_Private_Void_CashInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemUIManager>.NativeClassPtr, 100683781);
			ItemUIManager.NativeMethodInfoPtr_SetDraggingEnabled_Public_Void_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemUIManager>.NativeClassPtr, 100683782);
			ItemUIManager.NativeMethodInfoPtr_EnableQuickMove_Public_Void_List_1_ItemSlot_List_1_ItemSlot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemUIManager>.NativeClassPtr, 100683783);
			ItemUIManager.NativeMethodInfoPtr_GetQuickMoveSlots_Private_List_1_ItemSlot_ItemSlot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemUIManager>.NativeClassPtr, 100683784);
			ItemUIManager.NativeMethodInfoPtr_DisableQuickMove_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemUIManager>.NativeClassPtr, 100683785);
			ItemUIManager.NativeMethodInfoPtr_GetHoveredItemSlot_Private_ItemSlotUI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemUIManager>.NativeClassPtr, 100683786);
			ItemUIManager.NativeMethodInfoPtr_GetHoveredItemInfo_Private_ItemDefinitionInfoHoverable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemUIManager>.NativeClassPtr, 100683787);
			ItemUIManager.NativeMethodInfoPtr_SlotClicked_Private_Void_ItemSlotUI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemUIManager>.NativeClassPtr, 100683788);
			ItemUIManager.NativeMethodInfoPtr_StartDragCash_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemUIManager>.NativeClassPtr, 100683789);
			ItemUIManager.NativeMethodInfoPtr_EndDrag_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemUIManager>.NativeClassPtr, 100683790);
			ItemUIManager.NativeMethodInfoPtr_SetDraggedAmount_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemUIManager>.NativeClassPtr, 100683791);
			ItemUIManager.NativeMethodInfoPtr_EndCashDrag_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemUIManager>.NativeClassPtr, 100683792);
			ItemUIManager.NativeMethodInfoPtr_CanDragFromSlot_Public_Boolean_ItemSlotUI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemUIManager>.NativeClassPtr, 100683793);
			ItemUIManager.NativeMethodInfoPtr_CanCashBeDraggedIntoSlot_Public_Boolean_ItemSlotUI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemUIManager>.NativeClassPtr, 100683794);
			ItemUIManager.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemUIManager>.NativeClassPtr, 100683795);
		}

		// Token: 0x17003349 RID: 13129
		// (get) Token: 0x0600A698 RID: 42648 RVA: 0x0029EAB4 File Offset: 0x0029CCB4
		// (set) Token: 0x0600A699 RID: 42649 RVA: 0x0029EAF0 File Offset: 0x0029CCF0
		public unsafe bool DraggingEnabled
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(ItemUIManager.NativeMethodInfoPtr_get_DraggingEnabled_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
			[CallerCount(19)]
			[CachedScanResults(RefRangeStart = 40119, RefRangeEnd = 40138, XrefRangeStart = 40119, XrefRangeEnd = 40138, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = ref value;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemUIManager.NativeMethodInfoPtr_set_DraggingEnabled_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x1700334A RID: 13130
		// (get) Token: 0x0600A69A RID: 42650 RVA: 0x0029EB30 File Offset: 0x0029CD30
		// (set) Token: 0x0600A69B RID: 42651 RVA: 0x0029EB70 File Offset: 0x0029CD70
		public unsafe ItemSlotUI HoveredSlot
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 20988, RefRangeEnd = 21002, XrefRangeStart = 20988, XrefRangeEnd = 21002, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemUIManager.NativeMethodInfoPtr_get_HoveredSlot_Public_get_ItemSlotUI_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemSlotUI>(intPtr2) : null;
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 21003, RefRangeEnd = 21004, XrefRangeStart = 21003, XrefRangeEnd = 21004, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemUIManager.NativeMethodInfoPtr_set_HoveredSlot_Protected_set_Void_ItemSlotUI_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x1700334B RID: 13131
		// (get) Token: 0x0600A69C RID: 42652 RVA: 0x0029EBB4 File Offset: 0x0029CDB4
		// (set) Token: 0x0600A69D RID: 42653 RVA: 0x0029EBF0 File Offset: 0x0029CDF0
		public unsafe bool QuickMoveEnabled
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(ItemUIManager.NativeMethodInfoPtr_get_QuickMoveEnabled_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
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
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemUIManager.NativeMethodInfoPtr_set_QuickMoveEnabled_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x0600A69E RID: 42654 RVA: 0x0029EC30 File Offset: 0x0029CE30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 291218, XrefRangeEnd = 291226, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ItemUIManager.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A69F RID: 42655 RVA: 0x0029EC6C File Offset: 0x0029CE6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 291226, XrefRangeEnd = 291298, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ItemUIManager.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A6A0 RID: 42656 RVA: 0x0029ECA8 File Offset: 0x0029CEA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 291298, XrefRangeEnd = 291310, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void LateUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ItemUIManager.NativeMethodInfoPtr_LateUpdate_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A6A1 RID: 42657 RVA: 0x0029ECE4 File Offset: 0x0029CEE4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 291331, RefRangeEnd = 291332, XrefRangeStart = 291310, XrefRangeEnd = 291331, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateCashDragSelectorUI()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemUIManager.NativeMethodInfoPtr_UpdateCashDragSelectorUI_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A6A2 RID: 42658 RVA: 0x0029ED18 File Offset: 0x0029CF18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 291332, XrefRangeEnd = 291354, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateCashDragAmount(CashInstance instance)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(instance);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemUIManager.NativeMethodInfoPtr_UpdateCashDragAmount_Private_Void_CashInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A6A3 RID: 42659 RVA: 0x0029ED5C File Offset: 0x0029CF5C
		[CallerCount(21)]
		[CachedScanResults(RefRangeStart = 291370, RefRangeEnd = 291391, XrefRangeStart = 291354, XrefRangeEnd = 291370, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetDraggingEnabled(bool enabled, bool modifierPromptsVisible = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref enabled;
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref modifierPromptsVisible;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemUIManager.NativeMethodInfoPtr_SetDraggingEnabled_Public_Void_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A6A4 RID: 42660 RVA: 0x0029EDA8 File Offset: 0x0029CFA8
		[CallerCount(13)]
		[CachedScanResults(RefRangeStart = 291411, RefRangeEnd = 291424, XrefRangeStart = 291391, XrefRangeEnd = 291411, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EnableQuickMove(List<ItemSlot> primarySlots, List<ItemSlot> secondarySlots)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(primarySlots);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(secondarySlots);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemUIManager.NativeMethodInfoPtr_EnableQuickMove_Public_Void_List_1_ItemSlot_List_1_ItemSlot_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A6A5 RID: 42661 RVA: 0x0029EDFC File Offset: 0x0029CFFC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 291458, RefRangeEnd = 291460, XrefRangeStart = 291424, XrefRangeEnd = 291458, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<ItemSlot> GetQuickMoveSlots(ItemSlot sourceSlot)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(sourceSlot);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemUIManager.NativeMethodInfoPtr_GetQuickMoveSlots_Private_List_1_ItemSlot_ItemSlot_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ItemSlot>>(intPtr2) : null;
		}

		// Token: 0x0600A6A6 RID: 42662 RVA: 0x0029EE4C File Offset: 0x0029D04C
		[CallerCount(0)]
		public unsafe void DisableQuickMove()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemUIManager.NativeMethodInfoPtr_DisableQuickMove_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A6A7 RID: 42663 RVA: 0x0029EE80 File Offset: 0x0029D080
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 291497, RefRangeEnd = 291498, XrefRangeStart = 291460, XrefRangeEnd = 291497, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ItemSlotUI GetHoveredItemSlot()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemUIManager.NativeMethodInfoPtr_GetHoveredItemSlot_Private_ItemSlotUI_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemSlotUI>(intPtr2) : null;
		}

		// Token: 0x0600A6A8 RID: 42664 RVA: 0x0029EEC0 File Offset: 0x0029D0C0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 291527, RefRangeEnd = 291528, XrefRangeStart = 291498, XrefRangeEnd = 291527, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ItemDefinitionInfoHoverable GetHoveredItemInfo()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemUIManager.NativeMethodInfoPtr_GetHoveredItemInfo_Private_ItemDefinitionInfoHoverable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemDefinitionInfoHoverable>(intPtr2) : null;
		}

		// Token: 0x0600A6A9 RID: 42665 RVA: 0x0029EF00 File Offset: 0x0029D100
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 291576, RefRangeEnd = 291577, XrefRangeStart = 291528, XrefRangeEnd = 291576, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SlotClicked(ItemSlotUI ui)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(ui);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemUIManager.NativeMethodInfoPtr_SlotClicked_Private_Void_ItemSlotUI_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A6AA RID: 42666 RVA: 0x0029EF44 File Offset: 0x0029D144
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 291577, XrefRangeEnd = 291624, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StartDragCash()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemUIManager.NativeMethodInfoPtr_StartDragCash_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A6AB RID: 42667 RVA: 0x0029EF78 File Offset: 0x0029D178
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 291668, RefRangeEnd = 291670, XrefRangeStart = 291624, XrefRangeEnd = 291668, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EndDrag()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemUIManager.NativeMethodInfoPtr_EndDrag_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A6AC RID: 42668 RVA: 0x0029EFAC File Offset: 0x0029D1AC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 291711, RefRangeEnd = 291712, XrefRangeStart = 291670, XrefRangeEnd = 291711, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetDraggedAmount(int amount)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref amount;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemUIManager.NativeMethodInfoPtr_SetDraggedAmount_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A6AD RID: 42669 RVA: 0x0029EFEC File Offset: 0x0029D1EC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 291774, RefRangeEnd = 291775, XrefRangeStart = 291712, XrefRangeEnd = 291774, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EndCashDrag()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemUIManager.NativeMethodInfoPtr_EndCashDrag_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A6AE RID: 42670 RVA: 0x0029F020 File Offset: 0x0029D220
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 291780, RefRangeEnd = 291782, XrefRangeStart = 291775, XrefRangeEnd = 291780, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool CanDragFromSlot(ItemSlotUI slotUI)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(slotUI);
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(ItemUIManager.NativeMethodInfoPtr_CanDragFromSlot_Public_Boolean_ItemSlotUI_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x0600A6AF RID: 42671 RVA: 0x0029F070 File Offset: 0x0029D270
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 291782, XrefRangeEnd = 291788, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool CanCashBeDraggedIntoSlot(ItemSlotUI ui)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(ui);
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(ItemUIManager.NativeMethodInfoPtr_CanCashBeDraggedIntoSlot_Public_Boolean_ItemSlotUI_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x0600A6B0 RID: 42672 RVA: 0x0029F0C0 File Offset: 0x0029D2C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 291788, XrefRangeEnd = 291805, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ItemUIManager() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ItemUIManager>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemUIManager.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A6B1 RID: 42673 RVA: 0x00051D59 File Offset: 0x0004FF59
		public ItemUIManager(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700332E RID: 13102
		// (get) Token: 0x0600A6B2 RID: 42674 RVA: 0x0029F0FC File Offset: 0x0029D2FC
		// (set) Token: 0x0600A6B3 RID: 42675 RVA: 0x00051D62 File Offset: 0x0004FF62
		public unsafe bool _DraggingEnabled_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ItemUIManager.NativeFieldInfoPtr__DraggingEnabled_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ItemUIManager.NativeFieldInfoPtr__DraggingEnabled_k__BackingField)) = value;
			}
		}

		// Token: 0x1700332F RID: 13103
		// (get) Token: 0x0600A6B4 RID: 42676 RVA: 0x0029F124 File Offset: 0x0029D324
		// (set) Token: 0x0600A6B5 RID: 42677 RVA: 0x00051D7D File Offset: 0x0004FF7D
		public unsafe ItemSlotUI _HoveredSlot_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ItemUIManager.NativeFieldInfoPtr__HoveredSlot_k__BackingField);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemSlotUI>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ItemUIManager.NativeFieldInfoPtr__HoveredSlot_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003330 RID: 13104
		// (get) Token: 0x0600A6B6 RID: 42678 RVA: 0x0029F154 File Offset: 0x0029D354
		// (set) Token: 0x0600A6B7 RID: 42679 RVA: 0x00051D9C File Offset: 0x0004FF9C
		public unsafe bool _QuickMoveEnabled_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ItemUIManager.NativeFieldInfoPtr__QuickMoveEnabled_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ItemUIManager.NativeFieldInfoPtr__QuickMoveEnabled_k__BackingField)) = value;
			}
		}

		// Token: 0x17003331 RID: 13105
		// (get) Token: 0x0600A6B8 RID: 42680 RVA: 0x0029F17C File Offset: 0x0029D37C
		// (set) Token: 0x0600A6B9 RID: 42681 RVA: 0x00051DB7 File Offset: 0x0004FFB7
		public unsafe Canvas Canvas
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ItemUIManager.NativeFieldInfoPtr_Canvas);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Canvas>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ItemUIManager.NativeFieldInfoPtr_Canvas), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003332 RID: 13106
		// (get) Token: 0x0600A6BA RID: 42682 RVA: 0x0029F1AC File Offset: 0x0029D3AC
		// (set) Token: 0x0600A6BB RID: 42683 RVA: 0x00051DD6 File Offset: 0x0004FFD6
		public unsafe Il2CppReferenceArray<GraphicRaycaster> Raycasters
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ItemUIManager.NativeFieldInfoPtr_Raycasters);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<GraphicRaycaster>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ItemUIManager.NativeFieldInfoPtr_Raycasters), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003333 RID: 13107
		// (get) Token: 0x0600A6BC RID: 42684 RVA: 0x0029F1DC File Offset: 0x0029D3DC
		// (set) Token: 0x0600A6BD RID: 42685 RVA: 0x00051DF5 File Offset: 0x0004FFF5
		public unsafe RectTransform CashDragAmountContainer
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ItemUIManager.NativeFieldInfoPtr_CashDragAmountContainer);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ItemUIManager.NativeFieldInfoPtr_CashDragAmountContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003334 RID: 13108
		// (get) Token: 0x0600A6BE RID: 42686 RVA: 0x0029F20C File Offset: 0x0029D40C
		// (set) Token: 0x0600A6BF RID: 42687 RVA: 0x00051E14 File Offset: 0x00050014
		public unsafe RectTransform InputsContainer
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ItemUIManager.NativeFieldInfoPtr_InputsContainer);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ItemUIManager.NativeFieldInfoPtr_InputsContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003335 RID: 13109
		// (get) Token: 0x0600A6C0 RID: 42688 RVA: 0x0029F23C File Offset: 0x0029D43C
		// (set) Token: 0x0600A6C1 RID: 42689 RVA: 0x00051E33 File Offset: 0x00050033
		public unsafe ItemInfoPanel InfoPanel
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ItemUIManager.NativeFieldInfoPtr_InfoPanel);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemInfoPanel>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ItemUIManager.NativeFieldInfoPtr_InfoPanel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003336 RID: 13110
		// (get) Token: 0x0600A6C2 RID: 42690 RVA: 0x0029F26C File Offset: 0x0029D46C
		// (set) Token: 0x0600A6C3 RID: 42691 RVA: 0x00051E52 File Offset: 0x00050052
		public unsafe RectTransform ItemQuantityPrompt
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ItemUIManager.NativeFieldInfoPtr_ItemQuantityPrompt);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ItemUIManager.NativeFieldInfoPtr_ItemQuantityPrompt), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003337 RID: 13111
		// (get) Token: 0x0600A6C4 RID: 42692 RVA: 0x0029F29C File Offset: 0x0029D49C
		// (set) Token: 0x0600A6C5 RID: 42693 RVA: 0x00051E71 File Offset: 0x00050071
		public unsafe Animation CashSlotHintAnim
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ItemUIManager.NativeFieldInfoPtr_CashSlotHintAnim);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Animation>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ItemUIManager.NativeFieldInfoPtr_CashSlotHintAnim), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003338 RID: 13112
		// (get) Token: 0x0600A6C6 RID: 42694 RVA: 0x0029F2CC File Offset: 0x0029D4CC
		// (set) Token: 0x0600A6C7 RID: 42695 RVA: 0x00051E90 File Offset: 0x00050090
		public unsafe CanvasGroup CashSlotHintAnimCanvasGroup
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ItemUIManager.NativeFieldInfoPtr_CashSlotHintAnimCanvasGroup);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CanvasGroup>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ItemUIManager.NativeFieldInfoPtr_CashSlotHintAnimCanvasGroup), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003339 RID: 13113
		// (get) Token: 0x0600A6C8 RID: 42696 RVA: 0x0029F2FC File Offset: 0x0029D4FC
		// (set) Token: 0x0600A6C9 RID: 42697 RVA: 0x00051EAF File Offset: 0x000500AF
		public unsafe FilterConfigPanel FilterConfigPanel
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ItemUIManager.NativeFieldInfoPtr_FilterConfigPanel);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FilterConfigPanel>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ItemUIManager.NativeFieldInfoPtr_FilterConfigPanel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700333A RID: 13114
		// (get) Token: 0x0600A6CA RID: 42698 RVA: 0x0029F32C File Offset: 0x0029D52C
		// (set) Token: 0x0600A6CB RID: 42699 RVA: 0x00051ECE File Offset: 0x000500CE
		public unsafe ItemSlotUI ItemSlotUIPrefab
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ItemUIManager.NativeFieldInfoPtr_ItemSlotUIPrefab);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemSlotUI>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ItemUIManager.NativeFieldInfoPtr_ItemSlotUIPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700333B RID: 13115
		// (get) Token: 0x0600A6CC RID: 42700 RVA: 0x0029F35C File Offset: 0x0029D55C
		// (set) Token: 0x0600A6CD RID: 42701 RVA: 0x00051EED File Offset: 0x000500ED
		public unsafe ItemUI DefaultItemUIPrefab
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ItemUIManager.NativeFieldInfoPtr_DefaultItemUIPrefab);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemUI>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ItemUIManager.NativeFieldInfoPtr_DefaultItemUIPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700333C RID: 13116
		// (get) Token: 0x0600A6CE RID: 42702 RVA: 0x0029F38C File Offset: 0x0029D58C
		// (set) Token: 0x0600A6CF RID: 42703 RVA: 0x00051F0C File Offset: 0x0005010C
		public unsafe ItemSlotUI HotbarSlotUIPrefab
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ItemUIManager.NativeFieldInfoPtr_HotbarSlotUIPrefab);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemSlotUI>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ItemUIManager.NativeFieldInfoPtr_HotbarSlotUIPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700333D RID: 13117
		// (get) Token: 0x0600A6D0 RID: 42704 RVA: 0x0029F3BC File Offset: 0x0029D5BC
		// (set) Token: 0x0600A6D1 RID: 42705 RVA: 0x00051F2B File Offset: 0x0005012B
		public unsafe ItemSlotUI draggedSlot
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ItemUIManager.NativeFieldInfoPtr_draggedSlot);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemSlotUI>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ItemUIManager.NativeFieldInfoPtr_draggedSlot), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700333E RID: 13118
		// (get) Token: 0x0600A6D2 RID: 42706 RVA: 0x0029F3EC File Offset: 0x0029D5EC
		// (set) Token: 0x0600A6D3 RID: 42707 RVA: 0x00051F4A File Offset: 0x0005014A
		public unsafe Vector2 mouseOffset
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ItemUIManager.NativeFieldInfoPtr_mouseOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ItemUIManager.NativeFieldInfoPtr_mouseOffset)) = value;
			}
		}

		// Token: 0x1700333F RID: 13119
		// (get) Token: 0x0600A6D4 RID: 42708 RVA: 0x0029F414 File Offset: 0x0029D614
		// (set) Token: 0x0600A6D5 RID: 42709 RVA: 0x00051F65 File Offset: 0x00050165
		public unsafe int draggedAmount
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ItemUIManager.NativeFieldInfoPtr_draggedAmount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ItemUIManager.NativeFieldInfoPtr_draggedAmount)) = value;
			}
		}

		// Token: 0x17003340 RID: 13120
		// (get) Token: 0x0600A6D6 RID: 42710 RVA: 0x0029F43C File Offset: 0x0029D63C
		// (set) Token: 0x0600A6D7 RID: 42711 RVA: 0x00051F80 File Offset: 0x00050180
		public unsafe RectTransform tempIcon
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ItemUIManager.NativeFieldInfoPtr_tempIcon);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ItemUIManager.NativeFieldInfoPtr_tempIcon), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003341 RID: 13121
		// (get) Token: 0x0600A6D8 RID: 42712 RVA: 0x0029F46C File Offset: 0x0029D66C
		// (set) Token: 0x0600A6D9 RID: 42713 RVA: 0x00051F9F File Offset: 0x0005019F
		public unsafe bool isDraggingCash
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ItemUIManager.NativeFieldInfoPtr_isDraggingCash);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ItemUIManager.NativeFieldInfoPtr_isDraggingCash)) = value;
			}
		}

		// Token: 0x17003342 RID: 13122
		// (get) Token: 0x0600A6DA RID: 42714 RVA: 0x0029F494 File Offset: 0x0029D694
		// (set) Token: 0x0600A6DB RID: 42715 RVA: 0x00051FBA File Offset: 0x000501BA
		public unsafe float draggedCashAmount
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ItemUIManager.NativeFieldInfoPtr_draggedCashAmount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ItemUIManager.NativeFieldInfoPtr_draggedCashAmount)) = value;
			}
		}

		// Token: 0x17003343 RID: 13123
		// (get) Token: 0x0600A6DC RID: 42716 RVA: 0x0029F4BC File Offset: 0x0029D6BC
		// (set) Token: 0x0600A6DD RID: 42717 RVA: 0x00051FD5 File Offset: 0x000501D5
		public unsafe List<ItemSlot> PrimarySlots
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ItemUIManager.NativeFieldInfoPtr_PrimarySlots);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ItemSlot>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ItemUIManager.NativeFieldInfoPtr_PrimarySlots), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003344 RID: 13124
		// (get) Token: 0x0600A6DE RID: 42718 RVA: 0x0029F4EC File Offset: 0x0029D6EC
		// (set) Token: 0x0600A6DF RID: 42719 RVA: 0x00051FF4 File Offset: 0x000501F4
		public unsafe List<ItemSlot> SecondarySlots
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ItemUIManager.NativeFieldInfoPtr_SecondarySlots);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ItemSlot>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ItemUIManager.NativeFieldInfoPtr_SecondarySlots), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003345 RID: 13125
		// (get) Token: 0x0600A6E0 RID: 42720 RVA: 0x0029F51C File Offset: 0x0029D71C
		// (set) Token: 0x0600A6E1 RID: 42721 RVA: 0x00052013 File Offset: 0x00050213
		public unsafe bool customDragAmount
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ItemUIManager.NativeFieldInfoPtr_customDragAmount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ItemUIManager.NativeFieldInfoPtr_customDragAmount)) = value;
			}
		}

		// Token: 0x17003346 RID: 13126
		// (get) Token: 0x0600A6E2 RID: 42722 RVA: 0x0029F544 File Offset: 0x0029D744
		// (set) Token: 0x0600A6E3 RID: 42723 RVA: 0x0005202E File Offset: 0x0005022E
		public unsafe Coroutine quantityChangePopRoutine
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ItemUIManager.NativeFieldInfoPtr_quantityChangePopRoutine);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ItemUIManager.NativeFieldInfoPtr_quantityChangePopRoutine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003347 RID: 13127
		// (get) Token: 0x0600A6E4 RID: 42724 RVA: 0x0029F574 File Offset: 0x0029D774
		// (set) Token: 0x0600A6E5 RID: 42725 RVA: 0x0005204D File Offset: 0x0005024D
		public unsafe UnityEvent onDragStart
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ItemUIManager.NativeFieldInfoPtr_onDragStart);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ItemUIManager.NativeFieldInfoPtr_onDragStart), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003348 RID: 13128
		// (get) Token: 0x0600A6E6 RID: 42726 RVA: 0x0029F5A4 File Offset: 0x0029D7A4
		// (set) Token: 0x0600A6E7 RID: 42727 RVA: 0x0005206C File Offset: 0x0005026C
		public unsafe UnityEvent onItemMoved
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ItemUIManager.NativeFieldInfoPtr_onItemMoved);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ItemUIManager.NativeFieldInfoPtr_onItemMoved), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04006FBA RID: 28602
		private static readonly System.IntPtr NativeFieldInfoPtr__DraggingEnabled_k__BackingField;

		// Token: 0x04006FBB RID: 28603
		private static readonly System.IntPtr NativeFieldInfoPtr__HoveredSlot_k__BackingField;

		// Token: 0x04006FBC RID: 28604
		private static readonly System.IntPtr NativeFieldInfoPtr__QuickMoveEnabled_k__BackingField;

		// Token: 0x04006FBD RID: 28605
		private static readonly System.IntPtr NativeFieldInfoPtr_Canvas;

		// Token: 0x04006FBE RID: 28606
		private static readonly System.IntPtr NativeFieldInfoPtr_Raycasters;

		// Token: 0x04006FBF RID: 28607
		private static readonly System.IntPtr NativeFieldInfoPtr_CashDragAmountContainer;

		// Token: 0x04006FC0 RID: 28608
		private static readonly System.IntPtr NativeFieldInfoPtr_InputsContainer;

		// Token: 0x04006FC1 RID: 28609
		private static readonly System.IntPtr NativeFieldInfoPtr_InfoPanel;

		// Token: 0x04006FC2 RID: 28610
		private static readonly System.IntPtr NativeFieldInfoPtr_ItemQuantityPrompt;

		// Token: 0x04006FC3 RID: 28611
		private static readonly System.IntPtr NativeFieldInfoPtr_CashSlotHintAnim;

		// Token: 0x04006FC4 RID: 28612
		private static readonly System.IntPtr NativeFieldInfoPtr_CashSlotHintAnimCanvasGroup;

		// Token: 0x04006FC5 RID: 28613
		private static readonly System.IntPtr NativeFieldInfoPtr_FilterConfigPanel;

		// Token: 0x04006FC6 RID: 28614
		private static readonly System.IntPtr NativeFieldInfoPtr_ItemSlotUIPrefab;

		// Token: 0x04006FC7 RID: 28615
		private static readonly System.IntPtr NativeFieldInfoPtr_DefaultItemUIPrefab;

		// Token: 0x04006FC8 RID: 28616
		private static readonly System.IntPtr NativeFieldInfoPtr_HotbarSlotUIPrefab;

		// Token: 0x04006FC9 RID: 28617
		private static readonly System.IntPtr NativeFieldInfoPtr_draggedSlot;

		// Token: 0x04006FCA RID: 28618
		private static readonly System.IntPtr NativeFieldInfoPtr_mouseOffset;

		// Token: 0x04006FCB RID: 28619
		private static readonly System.IntPtr NativeFieldInfoPtr_draggedAmount;

		// Token: 0x04006FCC RID: 28620
		private static readonly System.IntPtr NativeFieldInfoPtr_tempIcon;

		// Token: 0x04006FCD RID: 28621
		private static readonly System.IntPtr NativeFieldInfoPtr_isDraggingCash;

		// Token: 0x04006FCE RID: 28622
		private static readonly System.IntPtr NativeFieldInfoPtr_draggedCashAmount;

		// Token: 0x04006FCF RID: 28623
		private static readonly System.IntPtr NativeFieldInfoPtr_PrimarySlots;

		// Token: 0x04006FD0 RID: 28624
		private static readonly System.IntPtr NativeFieldInfoPtr_SecondarySlots;

		// Token: 0x04006FD1 RID: 28625
		private static readonly System.IntPtr NativeFieldInfoPtr_customDragAmount;

		// Token: 0x04006FD2 RID: 28626
		private static readonly System.IntPtr NativeFieldInfoPtr_quantityChangePopRoutine;

		// Token: 0x04006FD3 RID: 28627
		private static readonly System.IntPtr NativeFieldInfoPtr_onDragStart;

		// Token: 0x04006FD4 RID: 28628
		private static readonly System.IntPtr NativeFieldInfoPtr_onItemMoved;

		// Token: 0x04006FD5 RID: 28629
		private static readonly System.IntPtr NativeMethodInfoPtr_get_DraggingEnabled_Public_get_Boolean_0;

		// Token: 0x04006FD6 RID: 28630
		private static readonly System.IntPtr NativeMethodInfoPtr_set_DraggingEnabled_Protected_set_Void_Boolean_0;

		// Token: 0x04006FD7 RID: 28631
		private static readonly System.IntPtr NativeMethodInfoPtr_get_HoveredSlot_Public_get_ItemSlotUI_0;

		// Token: 0x04006FD8 RID: 28632
		private static readonly System.IntPtr NativeMethodInfoPtr_set_HoveredSlot_Protected_set_Void_ItemSlotUI_0;

		// Token: 0x04006FD9 RID: 28633
		private static readonly System.IntPtr NativeMethodInfoPtr_get_QuickMoveEnabled_Public_get_Boolean_0;

		// Token: 0x04006FDA RID: 28634
		private static readonly System.IntPtr NativeMethodInfoPtr_set_QuickMoveEnabled_Protected_set_Void_Boolean_0;

		// Token: 0x04006FDB RID: 28635
		private static readonly System.IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0;

		// Token: 0x04006FDC RID: 28636
		private static readonly System.IntPtr NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0;

		// Token: 0x04006FDD RID: 28637
		private static readonly System.IntPtr NativeMethodInfoPtr_LateUpdate_Protected_Virtual_New_Void_0;

		// Token: 0x04006FDE RID: 28638
		private static readonly System.IntPtr NativeMethodInfoPtr_UpdateCashDragSelectorUI_Private_Void_0;

		// Token: 0x04006FDF RID: 28639
		private static readonly System.IntPtr NativeMethodInfoPtr_UpdateCashDragAmount_Private_Void_CashInstance_0;

		// Token: 0x04006FE0 RID: 28640
		private static readonly System.IntPtr NativeMethodInfoPtr_SetDraggingEnabled_Public_Void_Boolean_Boolean_0;

		// Token: 0x04006FE1 RID: 28641
		private static readonly System.IntPtr NativeMethodInfoPtr_EnableQuickMove_Public_Void_List_1_ItemSlot_List_1_ItemSlot_0;

		// Token: 0x04006FE2 RID: 28642
		private static readonly System.IntPtr NativeMethodInfoPtr_GetQuickMoveSlots_Private_List_1_ItemSlot_ItemSlot_0;

		// Token: 0x04006FE3 RID: 28643
		private static readonly System.IntPtr NativeMethodInfoPtr_DisableQuickMove_Public_Void_0;

		// Token: 0x04006FE4 RID: 28644
		private static readonly System.IntPtr NativeMethodInfoPtr_GetHoveredItemSlot_Private_ItemSlotUI_0;

		// Token: 0x04006FE5 RID: 28645
		private static readonly System.IntPtr NativeMethodInfoPtr_GetHoveredItemInfo_Private_ItemDefinitionInfoHoverable_0;

		// Token: 0x04006FE6 RID: 28646
		private static readonly System.IntPtr NativeMethodInfoPtr_SlotClicked_Private_Void_ItemSlotUI_0;

		// Token: 0x04006FE7 RID: 28647
		private static readonly System.IntPtr NativeMethodInfoPtr_StartDragCash_Private_Void_0;

		// Token: 0x04006FE8 RID: 28648
		private static readonly System.IntPtr NativeMethodInfoPtr_EndDrag_Private_Void_0;

		// Token: 0x04006FE9 RID: 28649
		private static readonly System.IntPtr NativeMethodInfoPtr_SetDraggedAmount_Private_Void_Int32_0;

		// Token: 0x04006FEA RID: 28650
		private static readonly System.IntPtr NativeMethodInfoPtr_EndCashDrag_Private_Void_0;

		// Token: 0x04006FEB RID: 28651
		private static readonly System.IntPtr NativeMethodInfoPtr_CanDragFromSlot_Public_Boolean_ItemSlotUI_0;

		// Token: 0x04006FEC RID: 28652
		private static readonly System.IntPtr NativeMethodInfoPtr_CanCashBeDraggedIntoSlot_Public_Boolean_ItemSlotUI_0;

		// Token: 0x04006FED RID: 28653
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000C17 RID: 3095
		[ObfuscatedName("ScheduleOne.UI.Items.ItemUIManager+<>c__DisplayClass50_0")]
		public sealed class __c__DisplayClass50_0 : Il2CppSystem.Object
		{
			// Token: 0x0600E309 RID: 58121 RVA: 0x0035BD98 File Offset: 0x00359F98
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass50_0()
			{
				Il2CppClassPointerStore<ItemUIManager.__c__DisplayClass50_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ItemUIManager>.NativeClassPtr, "<>c__DisplayClass50_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ItemUIManager.__c__DisplayClass50_0>.NativeClassPtr);
				ItemUIManager.__c__DisplayClass50_0.NativeFieldInfoPtr_quantityText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemUIManager.__c__DisplayClass50_0>.NativeClassPtr, "quantityText");
				ItemUIManager.__c__DisplayClass50_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemUIManager.__c__DisplayClass50_0>.NativeClassPtr, "<>4__this");
				ItemUIManager.__c__DisplayClass50_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemUIManager.__c__DisplayClass50_0>.NativeClassPtr, 100683796);
				ItemUIManager.__c__DisplayClass50_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemUIManager.__c__DisplayClass50_0>.NativeClassPtr, 100683797);
			}

			// Token: 0x0600E30A RID: 58122 RVA: 0x0035BE14 File Offset: 0x0035A014
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass50_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ItemUIManager.__c__DisplayClass50_0>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemUIManager.__c__DisplayClass50_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600E30B RID: 58123 RVA: 0x0035BE50 File Offset: 0x0035A050
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 291213, XrefRangeEnd = 291218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator Method_Internal_IEnumerator_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemUIManager.__c__DisplayClass50_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr2) : null;
			}

			// Token: 0x0600E30C RID: 58124 RVA: 0x0006E4D8 File Offset: 0x0006C6D8
			public __c__DisplayClass50_0(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004606 RID: 17926
			// (get) Token: 0x0600E30D RID: 58125 RVA: 0x0035BE90 File Offset: 0x0035A090
			// (set) Token: 0x0600E30E RID: 58126 RVA: 0x0006E4E1 File Offset: 0x0006C6E1
			public unsafe TextMeshProUGUI quantityText
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ItemUIManager.__c__DisplayClass50_0.NativeFieldInfoPtr_quantityText);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ItemUIManager.__c__DisplayClass50_0.NativeFieldInfoPtr_quantityText), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004607 RID: 17927
			// (get) Token: 0x0600E30F RID: 58127 RVA: 0x0035BEC0 File Offset: 0x0035A0C0
			// (set) Token: 0x0600E310 RID: 58128 RVA: 0x0006E500 File Offset: 0x0006C700
			public unsafe ItemUIManager __4__this
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ItemUIManager.__c__DisplayClass50_0.NativeFieldInfoPtr___4__this);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemUIManager>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ItemUIManager.__c__DisplayClass50_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009824 RID: 38948
			private static readonly System.IntPtr NativeFieldInfoPtr_quantityText;

			// Token: 0x04009825 RID: 38949
			private static readonly System.IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04009826 RID: 38950
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009827 RID: 38951
			private static readonly System.IntPtr NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0;

			// Token: 0x02000CE2 RID: 3298
			[ObfuscatedName("ScheduleOne.UI.Items.ItemUIManager+<>c__DisplayClass50_0+<<SetDraggedAmount>g__LerpQuantityTextSize|0>d")]
			public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReObObUnique : Il2CppSystem.Object
			{
				// Token: 0x0600EC77 RID: 60535 RVA: 0x0037706C File Offset: 0x0037526C
				// Note: this type is marked as 'beforefieldinit'.
				static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReObObUnique()
				{
					Il2CppClassPointerStore<ItemUIManager.__c__DisplayClass50_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ItemUIManager.__c__DisplayClass50_0>.NativeClassPtr, "<<SetDraggedAmount>g__LerpQuantityTextSize|0>d");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ItemUIManager.__c__DisplayClass50_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReObObUnique>.NativeClassPtr);
					ItemUIManager.__c__DisplayClass50_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemUIManager.__c__DisplayClass50_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReObObUnique>.NativeClassPtr, "<>1__state");
					ItemUIManager.__c__DisplayClass50_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemUIManager.__c__DisplayClass50_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReObObUnique>.NativeClassPtr, "<>2__current");
					ItemUIManager.__c__DisplayClass50_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemUIManager.__c__DisplayClass50_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReObObUnique>.NativeClassPtr, "<>4__this");
					ItemUIManager.__c__DisplayClass50_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReObObUnique.NativeFieldInfoPtr__quantityTransform_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemUIManager.__c__DisplayClass50_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReObObUnique>.NativeClassPtr, "<quantityTransform>5__2");
					ItemUIManager.__c__DisplayClass50_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemUIManager.__c__DisplayClass50_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReObObUnique>.NativeClassPtr, 100683798);
					ItemUIManager.__c__DisplayClass50_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemUIManager.__c__DisplayClass50_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReObObUnique>.NativeClassPtr, 100683799);
					ItemUIManager.__c__DisplayClass50_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemUIManager.__c__DisplayClass50_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReObObUnique>.NativeClassPtr, 100683800);
					ItemUIManager.__c__DisplayClass50_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemUIManager.__c__DisplayClass50_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReObObUnique>.NativeClassPtr, 100683801);
					ItemUIManager.__c__DisplayClass50_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemUIManager.__c__DisplayClass50_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReObObUnique>.NativeClassPtr, 100683802);
					ItemUIManager.__c__DisplayClass50_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemUIManager.__c__DisplayClass50_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReObObUnique>.NativeClassPtr, 100683803);
				}

				// Token: 0x0600EC78 RID: 60536 RVA: 0x00377160 File Offset: 0x00375360
				[CallerCount(54)]
				[CachedScanResults(RefRangeStart = 2646, RefRangeEnd = 2700, XrefRangeStart = 2646, XrefRangeEnd = 2700, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ItemUIManager.__c__DisplayClass50_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReObObUnique>.NativeClassPtr))
				{
					System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
					*ptr = ref <>1__state;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemUIManager.__c__DisplayClass50_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				}

				// Token: 0x0600EC79 RID: 60537 RVA: 0x003771A8 File Offset: 0x003753A8
				[CallerCount(14558)]
				[CachedScanResults(RefRangeStart = 2769, RefRangeEnd = 17327, XrefRangeStart = 2769, XrefRangeEnd = 17327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemUIManager.__c__DisplayClass50_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				}

				// Token: 0x0600EC7A RID: 60538 RVA: 0x003771DC File Offset: 0x003753DC
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 291192, XrefRangeEnd = 291208, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(ItemUIManager.__c__DisplayClass50_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
					return *IL2CPP.il2cpp_object_unbox(obj);
				}

				// Token: 0x17004956 RID: 18774
				// (get) Token: 0x0600EC7B RID: 60539 RVA: 0x00377218 File Offset: 0x00375418
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(24)]
					[CachedScanResults(RefRangeStart = 2740, RefRangeEnd = 2764, XrefRangeStart = 2740, XrefRangeEnd = 2764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						System.IntPtr* param = null;
						System.IntPtr returnedException;
						System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemUIManager.__c__DisplayClass50_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
						Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
						System.IntPtr intPtr2 = intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
				}

				// Token: 0x0600EC7C RID: 60540 RVA: 0x00377258 File Offset: 0x00375458
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 291208, XrefRangeEnd = 291213, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemUIManager.__c__DisplayClass50_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				}

				// Token: 0x17004957 RID: 18775
				// (get) Token: 0x0600EC7D RID: 60541 RVA: 0x0037728C File Offset: 0x0037548C
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(24)]
					[CachedScanResults(RefRangeStart = 2740, RefRangeEnd = 2764, XrefRangeStart = 2740, XrefRangeEnd = 2764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						System.IntPtr* param = null;
						System.IntPtr returnedException;
						System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemUIManager.__c__DisplayClass50_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
						Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
						System.IntPtr intPtr2 = intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
				}

				// Token: 0x0600EC7E RID: 60542 RVA: 0x0007322C File Offset: 0x0007142C
				public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReObObUnique(System.IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x17004952 RID: 18770
				// (get) Token: 0x0600EC7F RID: 60543 RVA: 0x003772CC File Offset: 0x003754CC
				// (set) Token: 0x0600EC80 RID: 60544 RVA: 0x00073235 File Offset: 0x00071435
				public unsafe int __1__state
				{
					get
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ItemUIManager.__c__DisplayClass50_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReObObUnique.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ItemUIManager.__c__DisplayClass50_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReObObUnique.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x17004953 RID: 18771
				// (get) Token: 0x0600EC81 RID: 60545 RVA: 0x003772F4 File Offset: 0x003754F4
				// (set) Token: 0x0600EC82 RID: 60546 RVA: 0x00073250 File Offset: 0x00071450
				public unsafe Il2CppSystem.Object __2__current
				{
					get
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ItemUIManager.__c__DisplayClass50_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReObObUnique.NativeFieldInfoPtr___2__current);
						System.IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
					set
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ItemUIManager.__c__DisplayClass50_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17004954 RID: 18772
				// (get) Token: 0x0600EC83 RID: 60547 RVA: 0x00377324 File Offset: 0x00375524
				// (set) Token: 0x0600EC84 RID: 60548 RVA: 0x0007326F File Offset: 0x0007146F
				public unsafe ItemUIManager.__c__DisplayClass50_0 __4__this
				{
					get
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ItemUIManager.__c__DisplayClass50_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReObObUnique.NativeFieldInfoPtr___4__this);
						System.IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemUIManager.__c__DisplayClass50_0>(intPtr2) : null;
					}
					set
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ItemUIManager.__c__DisplayClass50_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17004955 RID: 18773
				// (get) Token: 0x0600EC85 RID: 60549 RVA: 0x00377354 File Offset: 0x00375554
				// (set) Token: 0x0600EC86 RID: 60550 RVA: 0x0007328E File Offset: 0x0007148E
				public unsafe RectTransform _quantityTransform_5__2
				{
					get
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ItemUIManager.__c__DisplayClass50_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReObObUnique.NativeFieldInfoPtr__quantityTransform_5__2);
						System.IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
					}
					set
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ItemUIManager.__c__DisplayClass50_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReObObUnique.NativeFieldInfoPtr__quantityTransform_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x04009E0F RID: 40463
				private static readonly System.IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x04009E10 RID: 40464
				private static readonly System.IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x04009E11 RID: 40465
				private static readonly System.IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x04009E12 RID: 40466
				private static readonly System.IntPtr NativeFieldInfoPtr__quantityTransform_5__2;

				// Token: 0x04009E13 RID: 40467
				private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x04009E14 RID: 40468
				private static readonly System.IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x04009E15 RID: 40469
				private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x04009E16 RID: 40470
				private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x04009E17 RID: 40471
				private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x04009E18 RID: 40472
				private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
			}
		}
	}
}
