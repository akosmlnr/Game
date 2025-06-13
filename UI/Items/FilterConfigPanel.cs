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
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI.Items
{
	// Token: 0x0200073D RID: 1853
	public class FilterConfigPanel : MonoBehaviour
	{
		// Token: 0x0600A5D1 RID: 42449 RVA: 0x0029C030 File Offset: 0x0029A230
		// Note: this type is marked as 'beforefieldinit'.
		static FilterConfigPanel()
		{
			Il2CppClassPointerStore<FilterConfigPanel>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Items", "FilterConfigPanel");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FilterConfigPanel>.NativeClassPtr);
			FilterConfigPanel.NativeFieldInfoPtr__IsOpen_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FilterConfigPanel>.NativeClassPtr, "<IsOpen>k__BackingField");
			FilterConfigPanel.NativeFieldInfoPtr__OpenSlot_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FilterConfigPanel>.NativeClassPtr, "<OpenSlot>k__BackingField");
			FilterConfigPanel.NativeFieldInfoPtr_ItemEntryPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FilterConfigPanel>.NativeClassPtr, "ItemEntryPrefab");
			FilterConfigPanel.NativeFieldInfoPtr_CategoryPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FilterConfigPanel>.NativeClassPtr, "CategoryPrefab");
			FilterConfigPanel.NativeFieldInfoPtr_SearchItemPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FilterConfigPanel>.NativeClassPtr, "SearchItemPrefab");
			FilterConfigPanel.NativeFieldInfoPtr_Rect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FilterConfigPanel>.NativeClassPtr, "Rect");
			FilterConfigPanel.NativeFieldInfoPtr_Container = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FilterConfigPanel>.NativeClassPtr, "Container");
			FilterConfigPanel.NativeFieldInfoPtr_TypeButton_None = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FilterConfigPanel>.NativeClassPtr, "TypeButton_None");
			FilterConfigPanel.NativeFieldInfoPtr_TypeButton_Whitelist = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FilterConfigPanel>.NativeClassPtr, "TypeButton_Whitelist");
			FilterConfigPanel.NativeFieldInfoPtr_TypeButton_Blacklist = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FilterConfigPanel>.NativeClassPtr, "TypeButton_Blacklist");
			FilterConfigPanel.NativeFieldInfoPtr_TypeLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FilterConfigPanel>.NativeClassPtr, "TypeLabel");
			FilterConfigPanel.NativeFieldInfoPtr_ListLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FilterConfigPanel>.NativeClassPtr, "ListLabel");
			FilterConfigPanel.NativeFieldInfoPtr_ListContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FilterConfigPanel>.NativeClassPtr, "ListContainer");
			FilterConfigPanel.NativeFieldInfoPtr_ListBlocker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FilterConfigPanel>.NativeClassPtr, "ListBlocker");
			FilterConfigPanel.NativeFieldInfoPtr_QualityButtons = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FilterConfigPanel>.NativeClassPtr, "QualityButtons");
			FilterConfigPanel.NativeFieldInfoPtr_ListScrollRect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FilterConfigPanel>.NativeClassPtr, "ListScrollRect");
			FilterConfigPanel.NativeFieldInfoPtr_Dropdown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FilterConfigPanel>.NativeClassPtr, "Dropdown");
			FilterConfigPanel.NativeFieldInfoPtr_CopyButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FilterConfigPanel>.NativeClassPtr, "CopyButton");
			FilterConfigPanel.NativeFieldInfoPtr_PasteButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FilterConfigPanel>.NativeClassPtr, "PasteButton");
			FilterConfigPanel.NativeFieldInfoPtr_ApplyToSiblingsButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FilterConfigPanel>.NativeClassPtr, "ApplyToSiblingsButton");
			FilterConfigPanel.NativeFieldInfoPtr_ClearButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FilterConfigPanel>.NativeClassPtr, "ClearButton");
			FilterConfigPanel.NativeFieldInfoPtr_SearchContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FilterConfigPanel>.NativeClassPtr, "SearchContainer");
			FilterConfigPanel.NativeFieldInfoPtr_SearchInput = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FilterConfigPanel>.NativeClassPtr, "SearchInput");
			FilterConfigPanel.NativeFieldInfoPtr_CategoryContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FilterConfigPanel>.NativeClassPtr, "CategoryContainer");
			FilterConfigPanel.NativeFieldInfoPtr_mouseUp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FilterConfigPanel>.NativeClassPtr, "mouseUp");
			FilterConfigPanel.NativeFieldInfoPtr_searchCategories = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FilterConfigPanel>.NativeClassPtr, "searchCategories");
			FilterConfigPanel.NativeFieldInfoPtr_itemEntries = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FilterConfigPanel>.NativeClassPtr, "itemEntries");
			FilterConfigPanel.NativeFieldInfoPtr_copiedFilter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FilterConfigPanel>.NativeClassPtr, "copiedFilter");
			FilterConfigPanel.NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilterConfigPanel>.NativeClassPtr, 100683684);
			FilterConfigPanel.NativeMethodInfoPtr_set_IsOpen_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilterConfigPanel>.NativeClassPtr, 100683685);
			FilterConfigPanel.NativeMethodInfoPtr_get_OpenSlot_Public_get_ItemSlot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilterConfigPanel>.NativeClassPtr, 100683686);
			FilterConfigPanel.NativeMethodInfoPtr_set_OpenSlot_Private_set_Void_ItemSlot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilterConfigPanel>.NativeClassPtr, 100683687);
			FilterConfigPanel.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilterConfigPanel>.NativeClassPtr, 100683688);
			FilterConfigPanel.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilterConfigPanel>.NativeClassPtr, 100683689);
			FilterConfigPanel.NativeMethodInfoPtr_Exit_Private_Void_ExitAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilterConfigPanel>.NativeClassPtr, 100683690);
			FilterConfigPanel.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilterConfigPanel>.NativeClassPtr, 100683691);
			FilterConfigPanel.NativeMethodInfoPtr_Open_Public_Void_ItemSlotUI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilterConfigPanel>.NativeClassPtr, 100683692);
			FilterConfigPanel.NativeMethodInfoPtr_Close_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilterConfigPanel>.NativeClassPtr, 100683693);
			FilterConfigPanel.NativeMethodInfoPtr_UpdateSearch_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilterConfigPanel>.NativeClassPtr, 100683694);
			FilterConfigPanel.NativeMethodInfoPtr_FilterModeSelected_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilterConfigPanel>.NativeClassPtr, 100683695);
			FilterConfigPanel.NativeMethodInfoPtr_FilterModeSelected_Public_Void_EType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilterConfigPanel>.NativeClassPtr, 100683696);
			FilterConfigPanel.NativeMethodInfoPtr_QualitySelected_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilterConfigPanel>.NativeClassPtr, 100683697);
			FilterConfigPanel.NativeMethodInfoPtr_QualitySelected_Public_Void_EQuality_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilterConfigPanel>.NativeClassPtr, 100683698);
			FilterConfigPanel.NativeMethodInfoPtr_AddClicked_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilterConfigPanel>.NativeClassPtr, 100683699);
			FilterConfigPanel.NativeMethodInfoPtr_CopyClicked_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilterConfigPanel>.NativeClassPtr, 100683700);
			FilterConfigPanel.NativeMethodInfoPtr_PasteClicked_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilterConfigPanel>.NativeClassPtr, 100683701);
			FilterConfigPanel.NativeMethodInfoPtr_ApplyToSiblingsClicked_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilterConfigPanel>.NativeClassPtr, 100683702);
			FilterConfigPanel.NativeMethodInfoPtr_ClearClicked_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilterConfigPanel>.NativeClassPtr, 100683703);
			FilterConfigPanel.NativeMethodInfoPtr_ToggleDropdown_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilterConfigPanel>.NativeClassPtr, 100683704);
			FilterConfigPanel.NativeMethodInfoPtr_OpenDropdown_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilterConfigPanel>.NativeClassPtr, 100683705);
			FilterConfigPanel.NativeMethodInfoPtr_CloseDropdown_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilterConfigPanel>.NativeClassPtr, 100683706);
			FilterConfigPanel.NativeMethodInfoPtr_ItemClicked_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilterConfigPanel>.NativeClassPtr, 100683707);
			FilterConfigPanel.NativeMethodInfoPtr_AddItem_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilterConfigPanel>.NativeClassPtr, 100683708);
			FilterConfigPanel.NativeMethodInfoPtr_RemoveItem_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilterConfigPanel>.NativeClassPtr, 100683709);
			FilterConfigPanel.NativeMethodInfoPtr_RefreshDisplay_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilterConfigPanel>.NativeClassPtr, 100683710);
			FilterConfigPanel.NativeMethodInfoPtr_IsMouseOverPanel_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilterConfigPanel>.NativeClassPtr, 100683711);
			FilterConfigPanel.NativeMethodInfoPtr_IsMouseOverSearch_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilterConfigPanel>.NativeClassPtr, 100683712);
			FilterConfigPanel.NativeMethodInfoPtr_IsMouseOverDropdown_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilterConfigPanel>.NativeClassPtr, 100683713);
			FilterConfigPanel.NativeMethodInfoPtr_GetSearchCategory_Private_SearchCategory_EItemCategory_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilterConfigPanel>.NativeClassPtr, 100683714);
			FilterConfigPanel.NativeMethodInfoPtr_OpenSearch_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilterConfigPanel>.NativeClassPtr, 100683715);
			FilterConfigPanel.NativeMethodInfoPtr_CloseSearch_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilterConfigPanel>.NativeClassPtr, 100683716);
			FilterConfigPanel.NativeMethodInfoPtr_SearchChanged_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilterConfigPanel>.NativeClassPtr, 100683717);
			FilterConfigPanel.NativeMethodInfoPtr_RefreshSearchResults_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilterConfigPanel>.NativeClassPtr, 100683718);
			FilterConfigPanel.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilterConfigPanel>.NativeClassPtr, 100683719);
			FilterConfigPanel.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilterConfigPanel>.NativeClassPtr, 100683720);
		}

		// Token: 0x1700330B RID: 13067
		// (get) Token: 0x0600A5D2 RID: 42450 RVA: 0x0029C574 File Offset: 0x0029A774
		// (set) Token: 0x0600A5D3 RID: 42451 RVA: 0x0029C5B0 File Offset: 0x0029A7B0
		public unsafe bool IsOpen
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 37513, RefRangeEnd = 37514, XrefRangeStart = 37513, XrefRangeEnd = 37514, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(FilterConfigPanel.NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 37514, RefRangeEnd = 37516, XrefRangeStart = 37514, XrefRangeEnd = 37516, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = ref value;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FilterConfigPanel.NativeMethodInfoPtr_set_IsOpen_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x1700330C RID: 13068
		// (get) Token: 0x0600A5D4 RID: 42452 RVA: 0x0029C5F0 File Offset: 0x0029A7F0
		// (set) Token: 0x0600A5D5 RID: 42453 RVA: 0x0029C630 File Offset: 0x0029A830
		public unsafe ItemSlot OpenSlot
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 20981, RefRangeEnd = 20984, XrefRangeStart = 20981, XrefRangeEnd = 20984, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FilterConfigPanel.NativeMethodInfoPtr_get_OpenSlot_Public_get_ItemSlot_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemSlot>(intPtr2) : null;
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 20985, RefRangeEnd = 20988, XrefRangeStart = 20985, XrefRangeEnd = 20988, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FilterConfigPanel.NativeMethodInfoPtr_set_OpenSlot_Private_set_Void_ItemSlot_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x0600A5D6 RID: 42454 RVA: 0x0029C674 File Offset: 0x0029A874
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 290374, XrefRangeEnd = 290395, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FilterConfigPanel.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A5D7 RID: 42455 RVA: 0x0029C6A8 File Offset: 0x0029A8A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 290395, XrefRangeEnd = 290396, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FilterConfigPanel.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A5D8 RID: 42456 RVA: 0x0029C6DC File Offset: 0x0029A8DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 290396, XrefRangeEnd = 290400, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Exit(ExitAction exit)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(exit);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FilterConfigPanel.NativeMethodInfoPtr_Exit_Private_Void_ExitAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A5D9 RID: 42457 RVA: 0x0029C720 File Offset: 0x0029A920
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 290400, XrefRangeEnd = 290401, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FilterConfigPanel.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A5DA RID: 42458 RVA: 0x0029C754 File Offset: 0x0029A954
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 290401, XrefRangeEnd = 290448, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Open(ItemSlotUI ui)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(ui);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FilterConfigPanel.NativeMethodInfoPtr_Open_Public_Void_ItemSlotUI_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A5DB RID: 42459 RVA: 0x0029C798 File Offset: 0x0029A998
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 290481, RefRangeEnd = 290485, XrefRangeStart = 290448, XrefRangeEnd = 290481, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Close()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FilterConfigPanel.NativeMethodInfoPtr_Close_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A5DC RID: 42460 RVA: 0x0029C7CC File Offset: 0x0029A9CC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 290580, RefRangeEnd = 290582, XrefRangeStart = 290485, XrefRangeEnd = 290580, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateSearch()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FilterConfigPanel.NativeMethodInfoPtr_UpdateSearch_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A5DD RID: 42461 RVA: 0x0029C800 File Offset: 0x0029AA00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 290582, XrefRangeEnd = 290584, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FilterModeSelected(int filterType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref filterType;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FilterConfigPanel.NativeMethodInfoPtr_FilterModeSelected_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A5DE RID: 42462 RVA: 0x0029C840 File Offset: 0x0029AA40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FilterModeSelected(SlotFilter.EType filterType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref filterType;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FilterConfigPanel.NativeMethodInfoPtr_FilterModeSelected_Public_Void_EType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A5DF RID: 42463 RVA: 0x0029C880 File Offset: 0x0029AA80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 290584, XrefRangeEnd = 290598, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void QualitySelected(int quality)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref quality;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FilterConfigPanel.NativeMethodInfoPtr_QualitySelected_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A5E0 RID: 42464 RVA: 0x0029C8C0 File Offset: 0x0029AAC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void QualitySelected(EQuality quality)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref quality;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FilterConfigPanel.NativeMethodInfoPtr_QualitySelected_Public_Void_EQuality_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A5E1 RID: 42465 RVA: 0x0029C900 File Offset: 0x0029AB00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 290598, XrefRangeEnd = 290607, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddClicked()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FilterConfigPanel.NativeMethodInfoPtr_AddClicked_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A5E2 RID: 42466 RVA: 0x0029C934 File Offset: 0x0029AB34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 290607, XrefRangeEnd = 290621, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CopyClicked()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FilterConfigPanel.NativeMethodInfoPtr_CopyClicked_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A5E3 RID: 42467 RVA: 0x0029C968 File Offset: 0x0029AB68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 290621, XrefRangeEnd = 290627, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PasteClicked()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FilterConfigPanel.NativeMethodInfoPtr_PasteClicked_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A5E4 RID: 42468 RVA: 0x0029C99C File Offset: 0x0029AB9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 290627, XrefRangeEnd = 290645, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ApplyToSiblingsClicked()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FilterConfigPanel.NativeMethodInfoPtr_ApplyToSiblingsClicked_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A5E5 RID: 42469 RVA: 0x0029C9D0 File Offset: 0x0029ABD0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 290645, XrefRangeEnd = 290653, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ClearClicked()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FilterConfigPanel.NativeMethodInfoPtr_ClearClicked_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A5E6 RID: 42470 RVA: 0x0029CA04 File Offset: 0x0029AC04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 290653, XrefRangeEnd = 290659, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ToggleDropdown()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FilterConfigPanel.NativeMethodInfoPtr_ToggleDropdown_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A5E7 RID: 42471 RVA: 0x0029CA38 File Offset: 0x0029AC38
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 290683, RefRangeEnd = 290684, XrefRangeStart = 290659, XrefRangeEnd = 290683, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OpenDropdown()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FilterConfigPanel.NativeMethodInfoPtr_OpenDropdown_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A5E8 RID: 42472 RVA: 0x0029CA6C File Offset: 0x0029AC6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 290684, XrefRangeEnd = 290687, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CloseDropdown()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FilterConfigPanel.NativeMethodInfoPtr_CloseDropdown_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A5E9 RID: 42473 RVA: 0x0029CAA0 File Offset: 0x0029ACA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 290687, XrefRangeEnd = 290701, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ItemClicked(string itemID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(itemID);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FilterConfigPanel.NativeMethodInfoPtr_ItemClicked_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A5EA RID: 42474 RVA: 0x0029CAE4 File Offset: 0x0029ACE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 290701, XrefRangeEnd = 290712, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddItem(string itemID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(itemID);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FilterConfigPanel.NativeMethodInfoPtr_AddItem_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A5EB RID: 42475 RVA: 0x0029CB28 File Offset: 0x0029AD28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 290712, XrefRangeEnd = 290717, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveItem(string itemID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(itemID);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FilterConfigPanel.NativeMethodInfoPtr_RemoveItem_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A5EC RID: 42476 RVA: 0x0029CB6C File Offset: 0x0029AD6C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 290826, RefRangeEnd = 290827, XrefRangeStart = 290717, XrefRangeEnd = 290826, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RefreshDisplay()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FilterConfigPanel.NativeMethodInfoPtr_RefreshDisplay_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A5ED RID: 42477 RVA: 0x0029CBA0 File Offset: 0x0029ADA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 290827, XrefRangeEnd = 290834, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsMouseOverPanel()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(FilterConfigPanel.NativeMethodInfoPtr_IsMouseOverPanel_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x0600A5EE RID: 42478 RVA: 0x0029CBDC File Offset: 0x0029ADDC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 290834, XrefRangeEnd = 290837, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsMouseOverSearch()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(FilterConfigPanel.NativeMethodInfoPtr_IsMouseOverSearch_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x0600A5EF RID: 42479 RVA: 0x0029CC18 File Offset: 0x0029AE18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 290837, XrefRangeEnd = 290840, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsMouseOverDropdown()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(FilterConfigPanel.NativeMethodInfoPtr_IsMouseOverDropdown_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x0600A5F0 RID: 42480 RVA: 0x0029CC54 File Offset: 0x0029AE54
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 290859, RefRangeEnd = 290860, XrefRangeStart = 290840, XrefRangeEnd = 290859, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FilterConfigPanel.SearchCategory GetSearchCategory(EItemCategory category)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref category;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FilterConfigPanel.NativeMethodInfoPtr_GetSearchCategory_Private_SearchCategory_EItemCategory_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<FilterConfigPanel.SearchCategory>(intPtr2) : null;
		}

		// Token: 0x0600A5F1 RID: 42481 RVA: 0x0029CCA0 File Offset: 0x0029AEA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 290860, XrefRangeEnd = 290869, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OpenSearch()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FilterConfigPanel.NativeMethodInfoPtr_OpenSearch_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A5F2 RID: 42482 RVA: 0x0029CCD4 File Offset: 0x0029AED4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 290869, XrefRangeEnd = 290872, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CloseSearch()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FilterConfigPanel.NativeMethodInfoPtr_CloseSearch_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A5F3 RID: 42483 RVA: 0x0029CD08 File Offset: 0x0029AF08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 290872, XrefRangeEnd = 290873, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SearchChanged(string search)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(search);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FilterConfigPanel.NativeMethodInfoPtr_SearchChanged_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A5F4 RID: 42484 RVA: 0x0029CD4C File Offset: 0x0029AF4C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 290888, RefRangeEnd = 290891, XrefRangeStart = 290873, XrefRangeEnd = 290888, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RefreshSearchResults()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FilterConfigPanel.NativeMethodInfoPtr_RefreshSearchResults_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A5F5 RID: 42485 RVA: 0x0029CD80 File Offset: 0x0029AF80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 290891, XrefRangeEnd = 290906, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FilterConfigPanel() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FilterConfigPanel>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FilterConfigPanel.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A5F6 RID: 42486 RVA: 0x0029CDBC File Offset: 0x0029AFBC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 290906, XrefRangeEnd = 290911, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator Method_Private_IEnumerator_PDM_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FilterConfigPanel.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr2) : null;
		}

		// Token: 0x0600A5F7 RID: 42487 RVA: 0x0005164E File Offset: 0x0004F84E
		public FilterConfigPanel(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170032EF RID: 13039
		// (get) Token: 0x0600A5F8 RID: 42488 RVA: 0x0029CDFC File Offset: 0x0029AFFC
		// (set) Token: 0x0600A5F9 RID: 42489 RVA: 0x00051657 File Offset: 0x0004F857
		public unsafe bool _IsOpen_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(FilterConfigPanel.NativeFieldInfoPtr__IsOpen_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(FilterConfigPanel.NativeFieldInfoPtr__IsOpen_k__BackingField)) = value;
			}
		}

		// Token: 0x170032F0 RID: 13040
		// (get) Token: 0x0600A5FA RID: 42490 RVA: 0x0029CE24 File Offset: 0x0029B024
		// (set) Token: 0x0600A5FB RID: 42491 RVA: 0x00051672 File Offset: 0x0004F872
		public unsafe ItemSlot _OpenSlot_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(FilterConfigPanel.NativeFieldInfoPtr__OpenSlot_k__BackingField);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemSlot>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(FilterConfigPanel.NativeFieldInfoPtr__OpenSlot_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170032F1 RID: 13041
		// (get) Token: 0x0600A5FC RID: 42492 RVA: 0x0029CE54 File Offset: 0x0029B054
		// (set) Token: 0x0600A5FD RID: 42493 RVA: 0x00051691 File Offset: 0x0004F891
		public unsafe GameObject ItemEntryPrefab
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(FilterConfigPanel.NativeFieldInfoPtr_ItemEntryPrefab);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(FilterConfigPanel.NativeFieldInfoPtr_ItemEntryPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170032F2 RID: 13042
		// (get) Token: 0x0600A5FE RID: 42494 RVA: 0x0029CE84 File Offset: 0x0029B084
		// (set) Token: 0x0600A5FF RID: 42495 RVA: 0x000516B0 File Offset: 0x0004F8B0
		public unsafe GameObject CategoryPrefab
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(FilterConfigPanel.NativeFieldInfoPtr_CategoryPrefab);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(FilterConfigPanel.NativeFieldInfoPtr_CategoryPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170032F3 RID: 13043
		// (get) Token: 0x0600A600 RID: 42496 RVA: 0x0029CEB4 File Offset: 0x0029B0B4
		// (set) Token: 0x0600A601 RID: 42497 RVA: 0x000516CF File Offset: 0x0004F8CF
		public unsafe GameObject SearchItemPrefab
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(FilterConfigPanel.NativeFieldInfoPtr_SearchItemPrefab);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(FilterConfigPanel.NativeFieldInfoPtr_SearchItemPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170032F4 RID: 13044
		// (get) Token: 0x0600A602 RID: 42498 RVA: 0x0029CEE4 File Offset: 0x0029B0E4
		// (set) Token: 0x0600A603 RID: 42499 RVA: 0x000516EE File Offset: 0x0004F8EE
		public unsafe RectTransform Rect
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(FilterConfigPanel.NativeFieldInfoPtr_Rect);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(FilterConfigPanel.NativeFieldInfoPtr_Rect), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170032F5 RID: 13045
		// (get) Token: 0x0600A604 RID: 42500 RVA: 0x0029CF14 File Offset: 0x0029B114
		// (set) Token: 0x0600A605 RID: 42501 RVA: 0x0005170D File Offset: 0x0004F90D
		public unsafe GameObject Container
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(FilterConfigPanel.NativeFieldInfoPtr_Container);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(FilterConfigPanel.NativeFieldInfoPtr_Container), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170032F6 RID: 13046
		// (get) Token: 0x0600A606 RID: 42502 RVA: 0x0029CF44 File Offset: 0x0029B144
		// (set) Token: 0x0600A607 RID: 42503 RVA: 0x0005172C File Offset: 0x0004F92C
		public unsafe Button TypeButton_None
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(FilterConfigPanel.NativeFieldInfoPtr_TypeButton_None);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(FilterConfigPanel.NativeFieldInfoPtr_TypeButton_None), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170032F7 RID: 13047
		// (get) Token: 0x0600A608 RID: 42504 RVA: 0x0029CF74 File Offset: 0x0029B174
		// (set) Token: 0x0600A609 RID: 42505 RVA: 0x0005174B File Offset: 0x0004F94B
		public unsafe Button TypeButton_Whitelist
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(FilterConfigPanel.NativeFieldInfoPtr_TypeButton_Whitelist);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(FilterConfigPanel.NativeFieldInfoPtr_TypeButton_Whitelist), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170032F8 RID: 13048
		// (get) Token: 0x0600A60A RID: 42506 RVA: 0x0029CFA4 File Offset: 0x0029B1A4
		// (set) Token: 0x0600A60B RID: 42507 RVA: 0x0005176A File Offset: 0x0004F96A
		public unsafe Button TypeButton_Blacklist
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(FilterConfigPanel.NativeFieldInfoPtr_TypeButton_Blacklist);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(FilterConfigPanel.NativeFieldInfoPtr_TypeButton_Blacklist), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170032F9 RID: 13049
		// (get) Token: 0x0600A60C RID: 42508 RVA: 0x0029CFD4 File Offset: 0x0029B1D4
		// (set) Token: 0x0600A60D RID: 42509 RVA: 0x00051789 File Offset: 0x0004F989
		public unsafe TextMeshProUGUI TypeLabel
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(FilterConfigPanel.NativeFieldInfoPtr_TypeLabel);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(FilterConfigPanel.NativeFieldInfoPtr_TypeLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170032FA RID: 13050
		// (get) Token: 0x0600A60E RID: 42510 RVA: 0x0029D004 File Offset: 0x0029B204
		// (set) Token: 0x0600A60F RID: 42511 RVA: 0x000517A8 File Offset: 0x0004F9A8
		public unsafe TextMeshProUGUI ListLabel
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(FilterConfigPanel.NativeFieldInfoPtr_ListLabel);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(FilterConfigPanel.NativeFieldInfoPtr_ListLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170032FB RID: 13051
		// (get) Token: 0x0600A610 RID: 42512 RVA: 0x0029D034 File Offset: 0x0029B234
		// (set) Token: 0x0600A611 RID: 42513 RVA: 0x000517C7 File Offset: 0x0004F9C7
		public unsafe RectTransform ListContainer
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(FilterConfigPanel.NativeFieldInfoPtr_ListContainer);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(FilterConfigPanel.NativeFieldInfoPtr_ListContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170032FC RID: 13052
		// (get) Token: 0x0600A612 RID: 42514 RVA: 0x0029D064 File Offset: 0x0029B264
		// (set) Token: 0x0600A613 RID: 42515 RVA: 0x000517E6 File Offset: 0x0004F9E6
		public unsafe GameObject ListBlocker
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(FilterConfigPanel.NativeFieldInfoPtr_ListBlocker);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(FilterConfigPanel.NativeFieldInfoPtr_ListBlocker), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170032FD RID: 13053
		// (get) Token: 0x0600A614 RID: 42516 RVA: 0x0029D094 File Offset: 0x0029B294
		// (set) Token: 0x0600A615 RID: 42517 RVA: 0x00051805 File Offset: 0x0004FA05
		public unsafe Il2CppReferenceArray<Button> QualityButtons
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(FilterConfigPanel.NativeFieldInfoPtr_QualityButtons);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Button>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(FilterConfigPanel.NativeFieldInfoPtr_QualityButtons), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170032FE RID: 13054
		// (get) Token: 0x0600A616 RID: 42518 RVA: 0x0029D0C4 File Offset: 0x0029B2C4
		// (set) Token: 0x0600A617 RID: 42519 RVA: 0x00051824 File Offset: 0x0004FA24
		public unsafe ScrollRect ListScrollRect
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(FilterConfigPanel.NativeFieldInfoPtr_ListScrollRect);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ScrollRect>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(FilterConfigPanel.NativeFieldInfoPtr_ListScrollRect), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170032FF RID: 13055
		// (get) Token: 0x0600A618 RID: 42520 RVA: 0x0029D0F4 File Offset: 0x0029B2F4
		// (set) Token: 0x0600A619 RID: 42521 RVA: 0x00051843 File Offset: 0x0004FA43
		public unsafe RectTransform Dropdown
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(FilterConfigPanel.NativeFieldInfoPtr_Dropdown);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(FilterConfigPanel.NativeFieldInfoPtr_Dropdown), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003300 RID: 13056
		// (get) Token: 0x0600A61A RID: 42522 RVA: 0x0029D124 File Offset: 0x0029B324
		// (set) Token: 0x0600A61B RID: 42523 RVA: 0x00051862 File Offset: 0x0004FA62
		public unsafe Button CopyButton
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(FilterConfigPanel.NativeFieldInfoPtr_CopyButton);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(FilterConfigPanel.NativeFieldInfoPtr_CopyButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003301 RID: 13057
		// (get) Token: 0x0600A61C RID: 42524 RVA: 0x0029D154 File Offset: 0x0029B354
		// (set) Token: 0x0600A61D RID: 42525 RVA: 0x00051881 File Offset: 0x0004FA81
		public unsafe Button PasteButton
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(FilterConfigPanel.NativeFieldInfoPtr_PasteButton);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(FilterConfigPanel.NativeFieldInfoPtr_PasteButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003302 RID: 13058
		// (get) Token: 0x0600A61E RID: 42526 RVA: 0x0029D184 File Offset: 0x0029B384
		// (set) Token: 0x0600A61F RID: 42527 RVA: 0x000518A0 File Offset: 0x0004FAA0
		public unsafe Button ApplyToSiblingsButton
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(FilterConfigPanel.NativeFieldInfoPtr_ApplyToSiblingsButton);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(FilterConfigPanel.NativeFieldInfoPtr_ApplyToSiblingsButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003303 RID: 13059
		// (get) Token: 0x0600A620 RID: 42528 RVA: 0x0029D1B4 File Offset: 0x0029B3B4
		// (set) Token: 0x0600A621 RID: 42529 RVA: 0x000518BF File Offset: 0x0004FABF
		public unsafe Button ClearButton
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(FilterConfigPanel.NativeFieldInfoPtr_ClearButton);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(FilterConfigPanel.NativeFieldInfoPtr_ClearButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003304 RID: 13060
		// (get) Token: 0x0600A622 RID: 42530 RVA: 0x0029D1E4 File Offset: 0x0029B3E4
		// (set) Token: 0x0600A623 RID: 42531 RVA: 0x000518DE File Offset: 0x0004FADE
		public unsafe RectTransform SearchContainer
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(FilterConfigPanel.NativeFieldInfoPtr_SearchContainer);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(FilterConfigPanel.NativeFieldInfoPtr_SearchContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003305 RID: 13061
		// (get) Token: 0x0600A624 RID: 42532 RVA: 0x0029D214 File Offset: 0x0029B414
		// (set) Token: 0x0600A625 RID: 42533 RVA: 0x000518FD File Offset: 0x0004FAFD
		public unsafe TMP_InputField SearchInput
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(FilterConfigPanel.NativeFieldInfoPtr_SearchInput);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_InputField>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(FilterConfigPanel.NativeFieldInfoPtr_SearchInput), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003306 RID: 13062
		// (get) Token: 0x0600A626 RID: 42534 RVA: 0x0029D244 File Offset: 0x0029B444
		// (set) Token: 0x0600A627 RID: 42535 RVA: 0x0005191C File Offset: 0x0004FB1C
		public unsafe RectTransform CategoryContainer
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(FilterConfigPanel.NativeFieldInfoPtr_CategoryContainer);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(FilterConfigPanel.NativeFieldInfoPtr_CategoryContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003307 RID: 13063
		// (get) Token: 0x0600A628 RID: 42536 RVA: 0x0029D274 File Offset: 0x0029B474
		// (set) Token: 0x0600A629 RID: 42537 RVA: 0x0005193B File Offset: 0x0004FB3B
		public unsafe bool mouseUp
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(FilterConfigPanel.NativeFieldInfoPtr_mouseUp);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(FilterConfigPanel.NativeFieldInfoPtr_mouseUp)) = value;
			}
		}

		// Token: 0x17003308 RID: 13064
		// (get) Token: 0x0600A62A RID: 42538 RVA: 0x0029D29C File Offset: 0x0029B49C
		// (set) Token: 0x0600A62B RID: 42539 RVA: 0x00051956 File Offset: 0x0004FB56
		public unsafe List<FilterConfigPanel.SearchCategory> searchCategories
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(FilterConfigPanel.NativeFieldInfoPtr_searchCategories);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<FilterConfigPanel.SearchCategory>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(FilterConfigPanel.NativeFieldInfoPtr_searchCategories), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003309 RID: 13065
		// (get) Token: 0x0600A62C RID: 42540 RVA: 0x0029D2CC File Offset: 0x0029B4CC
		// (set) Token: 0x0600A62D RID: 42541 RVA: 0x00051975 File Offset: 0x0004FB75
		public unsafe List<RectTransform> itemEntries
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(FilterConfigPanel.NativeFieldInfoPtr_itemEntries);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<RectTransform>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(FilterConfigPanel.NativeFieldInfoPtr_itemEntries), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700330A RID: 13066
		// (get) Token: 0x0600A62E RID: 42542 RVA: 0x0029D2FC File Offset: 0x0029B4FC
		// (set) Token: 0x0600A62F RID: 42543 RVA: 0x00051994 File Offset: 0x0004FB94
		public unsafe static SlotFilter copiedFilter
		{
			get
			{
				System.IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(FilterConfigPanel.NativeFieldInfoPtr_copiedFilter, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SlotFilter>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(FilterConfigPanel.NativeFieldInfoPtr_copiedFilter, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04006F3C RID: 28476
		private static readonly System.IntPtr NativeFieldInfoPtr__IsOpen_k__BackingField;

		// Token: 0x04006F3D RID: 28477
		private static readonly System.IntPtr NativeFieldInfoPtr__OpenSlot_k__BackingField;

		// Token: 0x04006F3E RID: 28478
		private static readonly System.IntPtr NativeFieldInfoPtr_ItemEntryPrefab;

		// Token: 0x04006F3F RID: 28479
		private static readonly System.IntPtr NativeFieldInfoPtr_CategoryPrefab;

		// Token: 0x04006F40 RID: 28480
		private static readonly System.IntPtr NativeFieldInfoPtr_SearchItemPrefab;

		// Token: 0x04006F41 RID: 28481
		private static readonly System.IntPtr NativeFieldInfoPtr_Rect;

		// Token: 0x04006F42 RID: 28482
		private static readonly System.IntPtr NativeFieldInfoPtr_Container;

		// Token: 0x04006F43 RID: 28483
		private static readonly System.IntPtr NativeFieldInfoPtr_TypeButton_None;

		// Token: 0x04006F44 RID: 28484
		private static readonly System.IntPtr NativeFieldInfoPtr_TypeButton_Whitelist;

		// Token: 0x04006F45 RID: 28485
		private static readonly System.IntPtr NativeFieldInfoPtr_TypeButton_Blacklist;

		// Token: 0x04006F46 RID: 28486
		private static readonly System.IntPtr NativeFieldInfoPtr_TypeLabel;

		// Token: 0x04006F47 RID: 28487
		private static readonly System.IntPtr NativeFieldInfoPtr_ListLabel;

		// Token: 0x04006F48 RID: 28488
		private static readonly System.IntPtr NativeFieldInfoPtr_ListContainer;

		// Token: 0x04006F49 RID: 28489
		private static readonly System.IntPtr NativeFieldInfoPtr_ListBlocker;

		// Token: 0x04006F4A RID: 28490
		private static readonly System.IntPtr NativeFieldInfoPtr_QualityButtons;

		// Token: 0x04006F4B RID: 28491
		private static readonly System.IntPtr NativeFieldInfoPtr_ListScrollRect;

		// Token: 0x04006F4C RID: 28492
		private static readonly System.IntPtr NativeFieldInfoPtr_Dropdown;

		// Token: 0x04006F4D RID: 28493
		private static readonly System.IntPtr NativeFieldInfoPtr_CopyButton;

		// Token: 0x04006F4E RID: 28494
		private static readonly System.IntPtr NativeFieldInfoPtr_PasteButton;

		// Token: 0x04006F4F RID: 28495
		private static readonly System.IntPtr NativeFieldInfoPtr_ApplyToSiblingsButton;

		// Token: 0x04006F50 RID: 28496
		private static readonly System.IntPtr NativeFieldInfoPtr_ClearButton;

		// Token: 0x04006F51 RID: 28497
		private static readonly System.IntPtr NativeFieldInfoPtr_SearchContainer;

		// Token: 0x04006F52 RID: 28498
		private static readonly System.IntPtr NativeFieldInfoPtr_SearchInput;

		// Token: 0x04006F53 RID: 28499
		private static readonly System.IntPtr NativeFieldInfoPtr_CategoryContainer;

		// Token: 0x04006F54 RID: 28500
		private static readonly System.IntPtr NativeFieldInfoPtr_mouseUp;

		// Token: 0x04006F55 RID: 28501
		private static readonly System.IntPtr NativeFieldInfoPtr_searchCategories;

		// Token: 0x04006F56 RID: 28502
		private static readonly System.IntPtr NativeFieldInfoPtr_itemEntries;

		// Token: 0x04006F57 RID: 28503
		private static readonly System.IntPtr NativeFieldInfoPtr_copiedFilter;

		// Token: 0x04006F58 RID: 28504
		private static readonly System.IntPtr NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0;

		// Token: 0x04006F59 RID: 28505
		private static readonly System.IntPtr NativeMethodInfoPtr_set_IsOpen_Private_set_Void_Boolean_0;

		// Token: 0x04006F5A RID: 28506
		private static readonly System.IntPtr NativeMethodInfoPtr_get_OpenSlot_Public_get_ItemSlot_0;

		// Token: 0x04006F5B RID: 28507
		private static readonly System.IntPtr NativeMethodInfoPtr_set_OpenSlot_Private_set_Void_ItemSlot_0;

		// Token: 0x04006F5C RID: 28508
		private static readonly System.IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x04006F5D RID: 28509
		private static readonly System.IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x04006F5E RID: 28510
		private static readonly System.IntPtr NativeMethodInfoPtr_Exit_Private_Void_ExitAction_0;

		// Token: 0x04006F5F RID: 28511
		private static readonly System.IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x04006F60 RID: 28512
		private static readonly System.IntPtr NativeMethodInfoPtr_Open_Public_Void_ItemSlotUI_0;

		// Token: 0x04006F61 RID: 28513
		private static readonly System.IntPtr NativeMethodInfoPtr_Close_Public_Void_0;

		// Token: 0x04006F62 RID: 28514
		private static readonly System.IntPtr NativeMethodInfoPtr_UpdateSearch_Private_Void_0;

		// Token: 0x04006F63 RID: 28515
		private static readonly System.IntPtr NativeMethodInfoPtr_FilterModeSelected_Public_Void_Int32_0;

		// Token: 0x04006F64 RID: 28516
		private static readonly System.IntPtr NativeMethodInfoPtr_FilterModeSelected_Public_Void_EType_0;

		// Token: 0x04006F65 RID: 28517
		private static readonly System.IntPtr NativeMethodInfoPtr_QualitySelected_Public_Void_Int32_0;

		// Token: 0x04006F66 RID: 28518
		private static readonly System.IntPtr NativeMethodInfoPtr_QualitySelected_Public_Void_EQuality_0;

		// Token: 0x04006F67 RID: 28519
		private static readonly System.IntPtr NativeMethodInfoPtr_AddClicked_Public_Void_0;

		// Token: 0x04006F68 RID: 28520
		private static readonly System.IntPtr NativeMethodInfoPtr_CopyClicked_Public_Void_0;

		// Token: 0x04006F69 RID: 28521
		private static readonly System.IntPtr NativeMethodInfoPtr_PasteClicked_Public_Void_0;

		// Token: 0x04006F6A RID: 28522
		private static readonly System.IntPtr NativeMethodInfoPtr_ApplyToSiblingsClicked_Public_Void_0;

		// Token: 0x04006F6B RID: 28523
		private static readonly System.IntPtr NativeMethodInfoPtr_ClearClicked_Public_Void_0;

		// Token: 0x04006F6C RID: 28524
		private static readonly System.IntPtr NativeMethodInfoPtr_ToggleDropdown_Public_Void_0;

		// Token: 0x04006F6D RID: 28525
		private static readonly System.IntPtr NativeMethodInfoPtr_OpenDropdown_Public_Void_0;

		// Token: 0x04006F6E RID: 28526
		private static readonly System.IntPtr NativeMethodInfoPtr_CloseDropdown_Public_Void_0;

		// Token: 0x04006F6F RID: 28527
		private static readonly System.IntPtr NativeMethodInfoPtr_ItemClicked_Private_Void_String_0;

		// Token: 0x04006F70 RID: 28528
		private static readonly System.IntPtr NativeMethodInfoPtr_AddItem_Private_Void_String_0;

		// Token: 0x04006F71 RID: 28529
		private static readonly System.IntPtr NativeMethodInfoPtr_RemoveItem_Private_Void_String_0;

		// Token: 0x04006F72 RID: 28530
		private static readonly System.IntPtr NativeMethodInfoPtr_RefreshDisplay_Private_Void_0;

		// Token: 0x04006F73 RID: 28531
		private static readonly System.IntPtr NativeMethodInfoPtr_IsMouseOverPanel_Private_Boolean_0;

		// Token: 0x04006F74 RID: 28532
		private static readonly System.IntPtr NativeMethodInfoPtr_IsMouseOverSearch_Private_Boolean_0;

		// Token: 0x04006F75 RID: 28533
		private static readonly System.IntPtr NativeMethodInfoPtr_IsMouseOverDropdown_Private_Boolean_0;

		// Token: 0x04006F76 RID: 28534
		private static readonly System.IntPtr NativeMethodInfoPtr_GetSearchCategory_Private_SearchCategory_EItemCategory_0;

		// Token: 0x04006F77 RID: 28535
		private static readonly System.IntPtr NativeMethodInfoPtr_OpenSearch_Private_Void_0;

		// Token: 0x04006F78 RID: 28536
		private static readonly System.IntPtr NativeMethodInfoPtr_CloseSearch_Private_Void_0;

		// Token: 0x04006F79 RID: 28537
		private static readonly System.IntPtr NativeMethodInfoPtr_SearchChanged_Private_Void_String_0;

		// Token: 0x04006F7A RID: 28538
		private static readonly System.IntPtr NativeMethodInfoPtr_RefreshSearchResults_Private_Void_0;

		// Token: 0x04006F7B RID: 28539
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04006F7C RID: 28540
		private static readonly System.IntPtr NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0;

		// Token: 0x02000C12 RID: 3090
		public class SearchCategory : Il2CppSystem.Object
		{
			// Token: 0x0600E2D4 RID: 58068 RVA: 0x0035B3B0 File Offset: 0x003595B0
			// Note: this type is marked as 'beforefieldinit'.
			static SearchCategory()
			{
				Il2CppClassPointerStore<FilterConfigPanel.SearchCategory>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<FilterConfigPanel>.NativeClassPtr, "SearchCategory");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FilterConfigPanel.SearchCategory>.NativeClassPtr);
				FilterConfigPanel.SearchCategory.NativeFieldInfoPtr_Category = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FilterConfigPanel.SearchCategory>.NativeClassPtr, "Category");
				FilterConfigPanel.SearchCategory.NativeFieldInfoPtr_Container = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FilterConfigPanel.SearchCategory>.NativeClassPtr, "Container");
				FilterConfigPanel.SearchCategory.NativeFieldInfoPtr_Items = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FilterConfigPanel.SearchCategory>.NativeClassPtr, "Items");
				FilterConfigPanel.SearchCategory.NativeMethodInfoPtr_AddItem_Public_Void_ItemDefinition_RectTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilterConfigPanel.SearchCategory>.NativeClassPtr, 100683721);
				FilterConfigPanel.SearchCategory.NativeMethodInfoPtr_SetSearch_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilterConfigPanel.SearchCategory>.NativeClassPtr, 100683722);
				FilterConfigPanel.SearchCategory.NativeMethodInfoPtr_GetItem_Public_Item_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilterConfigPanel.SearchCategory>.NativeClassPtr, 100683723);
				FilterConfigPanel.SearchCategory.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilterConfigPanel.SearchCategory>.NativeClassPtr, 100683724);
			}

			// Token: 0x0600E2D5 RID: 58069 RVA: 0x0035B468 File Offset: 0x00359668
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 290291, RefRangeEnd = 290292, XrefRangeStart = 290282, XrefRangeEnd = 290291, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void AddItem(ItemDefinition item, RectTransform entry)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
				ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(entry);
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FilterConfigPanel.SearchCategory.NativeMethodInfoPtr_AddItem_Public_Void_ItemDefinition_RectTransform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600E2D6 RID: 58070 RVA: 0x0035B4BC File Offset: 0x003596BC
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 290318, RefRangeEnd = 290319, XrefRangeStart = 290292, XrefRangeEnd = 290318, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetSearch(string search)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(search);
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FilterConfigPanel.SearchCategory.NativeMethodInfoPtr_SetSearch_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600E2D7 RID: 58071 RVA: 0x0035B500 File Offset: 0x00359700
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 290327, RefRangeEnd = 290328, XrefRangeStart = 290319, XrefRangeEnd = 290327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe FilterConfigPanel.SearchCategory.Item GetItem(string itemID)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(itemID);
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FilterConfigPanel.SearchCategory.NativeMethodInfoPtr_GetItem_Public_Item_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FilterConfigPanel.SearchCategory.Item>(intPtr2) : null;
			}

			// Token: 0x0600E2D8 RID: 58072 RVA: 0x0035B550 File Offset: 0x00359750
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 290328, XrefRangeEnd = 290336, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe SearchCategory() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FilterConfigPanel.SearchCategory>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FilterConfigPanel.SearchCategory.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600E2D9 RID: 58073 RVA: 0x0006E347 File Offset: 0x0006C547
			public SearchCategory(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170045F7 RID: 17911
			// (get) Token: 0x0600E2DA RID: 58074 RVA: 0x0035B58C File Offset: 0x0035978C
			// (set) Token: 0x0600E2DB RID: 58075 RVA: 0x0006E350 File Offset: 0x0006C550
			public unsafe EItemCategory Category
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(FilterConfigPanel.SearchCategory.NativeFieldInfoPtr_Category);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(FilterConfigPanel.SearchCategory.NativeFieldInfoPtr_Category)) = value;
				}
			}

			// Token: 0x170045F8 RID: 17912
			// (get) Token: 0x0600E2DC RID: 58076 RVA: 0x0035B5B4 File Offset: 0x003597B4
			// (set) Token: 0x0600E2DD RID: 58077 RVA: 0x0006E36B File Offset: 0x0006C56B
			public unsafe RectTransform Container
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(FilterConfigPanel.SearchCategory.NativeFieldInfoPtr_Container);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(FilterConfigPanel.SearchCategory.NativeFieldInfoPtr_Container), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170045F9 RID: 17913
			// (get) Token: 0x0600E2DE RID: 58078 RVA: 0x0035B5E4 File Offset: 0x003597E4
			// (set) Token: 0x0600E2DF RID: 58079 RVA: 0x0006E38A File Offset: 0x0006C58A
			public unsafe List<FilterConfigPanel.SearchCategory.Item> Items
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(FilterConfigPanel.SearchCategory.NativeFieldInfoPtr_Items);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<FilterConfigPanel.SearchCategory.Item>>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(FilterConfigPanel.SearchCategory.NativeFieldInfoPtr_Items), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009806 RID: 38918
			private static readonly System.IntPtr NativeFieldInfoPtr_Category;

			// Token: 0x04009807 RID: 38919
			private static readonly System.IntPtr NativeFieldInfoPtr_Container;

			// Token: 0x04009808 RID: 38920
			private static readonly System.IntPtr NativeFieldInfoPtr_Items;

			// Token: 0x04009809 RID: 38921
			private static readonly System.IntPtr NativeMethodInfoPtr_AddItem_Public_Void_ItemDefinition_RectTransform_0;

			// Token: 0x0400980A RID: 38922
			private static readonly System.IntPtr NativeMethodInfoPtr_SetSearch_Public_Void_String_0;

			// Token: 0x0400980B RID: 38923
			private static readonly System.IntPtr NativeMethodInfoPtr_GetItem_Public_Item_String_0;

			// Token: 0x0400980C RID: 38924
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x02000CE1 RID: 3297
			public class Item : Il2CppSystem.Object
			{
				// Token: 0x0600EC70 RID: 60528 RVA: 0x00376F68 File Offset: 0x00375168
				// Note: this type is marked as 'beforefieldinit'.
				static Item()
				{
					Il2CppClassPointerStore<FilterConfigPanel.SearchCategory.Item>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<FilterConfigPanel.SearchCategory>.NativeClassPtr, "Item");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FilterConfigPanel.SearchCategory.Item>.NativeClassPtr);
					FilterConfigPanel.SearchCategory.Item.NativeFieldInfoPtr_ItemDefinition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FilterConfigPanel.SearchCategory.Item>.NativeClassPtr, "ItemDefinition");
					FilterConfigPanel.SearchCategory.Item.NativeFieldInfoPtr_Entry = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FilterConfigPanel.SearchCategory.Item>.NativeClassPtr, "Entry");
					FilterConfigPanel.SearchCategory.Item.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilterConfigPanel.SearchCategory.Item>.NativeClassPtr, 100683725);
				}

				// Token: 0x0600EC71 RID: 60529 RVA: 0x00376FD0 File Offset: 0x003751D0
				[CallerCount(2576)]
				[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe Item() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FilterConfigPanel.SearchCategory.Item>.NativeClassPtr))
				{
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FilterConfigPanel.SearchCategory.Item.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				}

				// Token: 0x0600EC72 RID: 60530 RVA: 0x000731E5 File Offset: 0x000713E5
				public Item(System.IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x17004950 RID: 18768
				// (get) Token: 0x0600EC73 RID: 60531 RVA: 0x0037700C File Offset: 0x0037520C
				// (set) Token: 0x0600EC74 RID: 60532 RVA: 0x000731EE File Offset: 0x000713EE
				public unsafe ItemDefinition ItemDefinition
				{
					get
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(FilterConfigPanel.SearchCategory.Item.NativeFieldInfoPtr_ItemDefinition);
						System.IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemDefinition>(intPtr2) : null;
					}
					set
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(FilterConfigPanel.SearchCategory.Item.NativeFieldInfoPtr_ItemDefinition), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17004951 RID: 18769
				// (get) Token: 0x0600EC75 RID: 60533 RVA: 0x0037703C File Offset: 0x0037523C
				// (set) Token: 0x0600EC76 RID: 60534 RVA: 0x0007320D File Offset: 0x0007140D
				public unsafe RectTransform Entry
				{
					get
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(FilterConfigPanel.SearchCategory.Item.NativeFieldInfoPtr_Entry);
						System.IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
					}
					set
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(FilterConfigPanel.SearchCategory.Item.NativeFieldInfoPtr_Entry), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x04009E0C RID: 40460
				private static readonly System.IntPtr NativeFieldInfoPtr_ItemDefinition;

				// Token: 0x04009E0D RID: 40461
				private static readonly System.IntPtr NativeFieldInfoPtr_Entry;

				// Token: 0x04009E0E RID: 40462
				private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
			}
		}

		// Token: 0x02000C13 RID: 3091
		[ObfuscatedName("ScheduleOne.UI.Items.FilterConfigPanel+<<Open>g__Open|39_0>d")]
		public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFiObObUnique : Il2CppSystem.Object
		{
			// Token: 0x0600E2E0 RID: 58080 RVA: 0x0035B614 File Offset: 0x00359814
			// Note: this type is marked as 'beforefieldinit'.
			static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFiObObUnique()
			{
				Il2CppClassPointerStore<FilterConfigPanel.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFiObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<FilterConfigPanel>.NativeClassPtr, "<<Open>g__Open|39_0>d");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FilterConfigPanel.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFiObObUnique>.NativeClassPtr);
				FilterConfigPanel.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFiObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FilterConfigPanel.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFiObObUnique>.NativeClassPtr, "<>1__state");
				FilterConfigPanel.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFiObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FilterConfigPanel.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFiObObUnique>.NativeClassPtr, "<>2__current");
				FilterConfigPanel.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFiObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FilterConfigPanel.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFiObObUnique>.NativeClassPtr, "<>4__this");
				FilterConfigPanel.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFiObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilterConfigPanel.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFiObObUnique>.NativeClassPtr, 100683726);
				FilterConfigPanel.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFiObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilterConfigPanel.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFiObObUnique>.NativeClassPtr, 100683727);
				FilterConfigPanel.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFiObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilterConfigPanel.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFiObObUnique>.NativeClassPtr, 100683728);
				FilterConfigPanel.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFiObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilterConfigPanel.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFiObObUnique>.NativeClassPtr, 100683729);
				FilterConfigPanel.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilterConfigPanel.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFiObObUnique>.NativeClassPtr, 100683730);
				FilterConfigPanel.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilterConfigPanel.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFiObObUnique>.NativeClassPtr, 100683731);
			}

			// Token: 0x0600E2E1 RID: 58081 RVA: 0x0035B6F4 File Offset: 0x003598F4
			[CallerCount(54)]
			[CachedScanResults(RefRangeStart = 2646, RefRangeEnd = 2700, XrefRangeStart = 2646, XrefRangeEnd = 2700, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFiObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FilterConfigPanel.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFiObObUnique>.NativeClassPtr))
			{
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = ref <>1__state;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FilterConfigPanel.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFiObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600E2E2 RID: 58082 RVA: 0x0035B73C File Offset: 0x0035993C
			[CallerCount(14558)]
			[CachedScanResults(RefRangeStart = 2769, RefRangeEnd = 17327, XrefRangeStart = 2769, XrefRangeEnd = 17327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FilterConfigPanel.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFiObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600E2E3 RID: 58083 RVA: 0x0035B770 File Offset: 0x00359970
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 290336, XrefRangeEnd = 290342, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(FilterConfigPanel.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFiObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x170045FD RID: 17917
			// (get) Token: 0x0600E2E4 RID: 58084 RVA: 0x0035B7AC File Offset: 0x003599AC
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 2740, RefRangeEnd = 2764, XrefRangeStart = 2740, XrefRangeEnd = 2764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FilterConfigPanel.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFiObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
			}

			// Token: 0x0600E2E5 RID: 58085 RVA: 0x0035B7EC File Offset: 0x003599EC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 290342, XrefRangeEnd = 290347, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FilterConfigPanel.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x170045FE RID: 17918
			// (get) Token: 0x0600E2E6 RID: 58086 RVA: 0x0035B820 File Offset: 0x00359A20
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 2740, RefRangeEnd = 2764, XrefRangeStart = 2740, XrefRangeEnd = 2764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FilterConfigPanel.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
			}

			// Token: 0x0600E2E7 RID: 58087 RVA: 0x0006E3A9 File Offset: 0x0006C5A9
			public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFiObObUnique(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170045FA RID: 17914
			// (get) Token: 0x0600E2E8 RID: 58088 RVA: 0x0035B860 File Offset: 0x00359A60
			// (set) Token: 0x0600E2E9 RID: 58089 RVA: 0x0006E3B2 File Offset: 0x0006C5B2
			public unsafe int __1__state
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(FilterConfigPanel.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFiObObUnique.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(FilterConfigPanel.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFiObObUnique.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170045FB RID: 17915
			// (get) Token: 0x0600E2EA RID: 58090 RVA: 0x0035B888 File Offset: 0x00359A88
			// (set) Token: 0x0600E2EB RID: 58091 RVA: 0x0006E3CD File Offset: 0x0006C5CD
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(FilterConfigPanel.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFiObObUnique.NativeFieldInfoPtr___2__current);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(FilterConfigPanel.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFiObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170045FC RID: 17916
			// (get) Token: 0x0600E2EC RID: 58092 RVA: 0x0035B8B8 File Offset: 0x00359AB8
			// (set) Token: 0x0600E2ED RID: 58093 RVA: 0x0006E3EC File Offset: 0x0006C5EC
			public unsafe FilterConfigPanel __4__this
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(FilterConfigPanel.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFiObObUnique.NativeFieldInfoPtr___4__this);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<FilterConfigPanel>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(FilterConfigPanel.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFiObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400980D RID: 38925
			private static readonly System.IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400980E RID: 38926
			private static readonly System.IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x0400980F RID: 38927
			private static readonly System.IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04009810 RID: 38928
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04009811 RID: 38929
			private static readonly System.IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04009812 RID: 38930
			private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04009813 RID: 38931
			private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04009814 RID: 38932
			private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04009815 RID: 38933
			private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x02000C14 RID: 3092
		[ObfuscatedName("ScheduleOne.UI.Items.FilterConfigPanel+<>c")]
		[System.Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x0600E2EE RID: 58094 RVA: 0x0035B8E8 File Offset: 0x00359AE8
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<FilterConfigPanel.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<FilterConfigPanel>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FilterConfigPanel.__c>.NativeClassPtr);
				FilterConfigPanel.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FilterConfigPanel.__c>.NativeClassPtr, "<>9");
				FilterConfigPanel.__c.NativeFieldInfoPtr___9__41_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FilterConfigPanel.__c>.NativeClassPtr, "<>9__41_1");
				FilterConfigPanel.__c.NativeFieldInfoPtr___9__61_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FilterConfigPanel.__c>.NativeClassPtr, "<>9__61_0");
				FilterConfigPanel.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilterConfigPanel.__c>.NativeClassPtr, 100683733);
				FilterConfigPanel.__c.NativeMethodInfoPtr__UpdateSearch_b__41_1_Internal_Int32_Item_Item_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilterConfigPanel.__c>.NativeClassPtr, 100683734);
				FilterConfigPanel.__c.NativeMethodInfoPtr__GetSearchCategory_b__61_0_Internal_Int32_SearchCategory_SearchCategory_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilterConfigPanel.__c>.NativeClassPtr, 100683735);
			}

			// Token: 0x0600E2EF RID: 58095 RVA: 0x0035B98C File Offset: 0x00359B8C
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FilterConfigPanel.__c>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FilterConfigPanel.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600E2F0 RID: 58096 RVA: 0x0035B9C8 File Offset: 0x00359BC8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 290347, XrefRangeEnd = 290349, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _UpdateSearch_b__41_1(FilterConfigPanel.SearchCategory.Item a, FilterConfigPanel.SearchCategory.Item b)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(a);
				ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(b);
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(FilterConfigPanel.__c.NativeMethodInfoPtr__UpdateSearch_b__41_1_Internal_Int32_Item_Item_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x0600E2F1 RID: 58097 RVA: 0x0035BA28 File Offset: 0x00359C28
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 290349, XrefRangeEnd = 290355, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _GetSearchCategory_b__61_0(FilterConfigPanel.SearchCategory a, FilterConfigPanel.SearchCategory b)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(a);
				ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(b);
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(FilterConfigPanel.__c.NativeMethodInfoPtr__GetSearchCategory_b__61_0_Internal_Int32_SearchCategory_SearchCategory_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x0600E2F2 RID: 58098 RVA: 0x0006E40B File Offset: 0x0006C60B
			public __c(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170045FF RID: 17919
			// (get) Token: 0x0600E2F3 RID: 58099 RVA: 0x0035BA88 File Offset: 0x00359C88
			// (set) Token: 0x0600E2F4 RID: 58100 RVA: 0x0006E414 File Offset: 0x0006C614
			public unsafe static FilterConfigPanel.__c __9
			{
				get
				{
					System.IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(FilterConfigPanel.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<FilterConfigPanel.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(FilterConfigPanel.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004600 RID: 17920
			// (get) Token: 0x0600E2F5 RID: 58101 RVA: 0x0035BAB0 File Offset: 0x00359CB0
			// (set) Token: 0x0600E2F6 RID: 58102 RVA: 0x0006E426 File Offset: 0x0006C626
			public unsafe static Il2CppSystem.Comparison<FilterConfigPanel.SearchCategory.Item> __9__41_1
			{
				get
				{
					System.IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(FilterConfigPanel.__c.NativeFieldInfoPtr___9__41_1, (void*)(&intPtr));
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Comparison<FilterConfigPanel.SearchCategory.Item>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(FilterConfigPanel.__c.NativeFieldInfoPtr___9__41_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004601 RID: 17921
			// (get) Token: 0x0600E2F7 RID: 58103 RVA: 0x0035BAD8 File Offset: 0x00359CD8
			// (set) Token: 0x0600E2F8 RID: 58104 RVA: 0x0006E438 File Offset: 0x0006C638
			public unsafe static Il2CppSystem.Comparison<FilterConfigPanel.SearchCategory> __9__61_0
			{
				get
				{
					System.IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(FilterConfigPanel.__c.NativeFieldInfoPtr___9__61_0, (void*)(&intPtr));
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Comparison<FilterConfigPanel.SearchCategory>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(FilterConfigPanel.__c.NativeFieldInfoPtr___9__61_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009816 RID: 38934
			private static readonly System.IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04009817 RID: 38935
			private static readonly System.IntPtr NativeFieldInfoPtr___9__41_1;

			// Token: 0x04009818 RID: 38936
			private static readonly System.IntPtr NativeFieldInfoPtr___9__61_0;

			// Token: 0x04009819 RID: 38937
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400981A RID: 38938
			private static readonly System.IntPtr NativeMethodInfoPtr__UpdateSearch_b__41_1_Internal_Int32_Item_Item_0;

			// Token: 0x0400981B RID: 38939
			private static readonly System.IntPtr NativeMethodInfoPtr__GetSearchCategory_b__61_0_Internal_Int32_SearchCategory_SearchCategory_0;
		}

		// Token: 0x02000C15 RID: 3093
		[ObfuscatedName("ScheduleOne.UI.Items.FilterConfigPanel+<>c__DisplayClass41_0")]
		public sealed class __c__DisplayClass41_0 : Il2CppSystem.Object
		{
			// Token: 0x0600E2F9 RID: 58105 RVA: 0x0035BB00 File Offset: 0x00359D00
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass41_0()
			{
				Il2CppClassPointerStore<FilterConfigPanel.__c__DisplayClass41_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<FilterConfigPanel>.NativeClassPtr, "<>c__DisplayClass41_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FilterConfigPanel.__c__DisplayClass41_0>.NativeClassPtr);
				FilterConfigPanel.__c__DisplayClass41_0.NativeFieldInfoPtr_item = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FilterConfigPanel.__c__DisplayClass41_0>.NativeClassPtr, "item");
				FilterConfigPanel.__c__DisplayClass41_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FilterConfigPanel.__c__DisplayClass41_0>.NativeClassPtr, "<>4__this");
				FilterConfigPanel.__c__DisplayClass41_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilterConfigPanel.__c__DisplayClass41_0>.NativeClassPtr, 100683736);
				FilterConfigPanel.__c__DisplayClass41_0.NativeMethodInfoPtr__UpdateSearch_b__0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilterConfigPanel.__c__DisplayClass41_0>.NativeClassPtr, 100683737);
			}

			// Token: 0x0600E2FA RID: 58106 RVA: 0x0035BB7C File Offset: 0x00359D7C
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass41_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FilterConfigPanel.__c__DisplayClass41_0>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FilterConfigPanel.__c__DisplayClass41_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600E2FB RID: 58107 RVA: 0x0035BBB8 File Offset: 0x00359DB8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 290355, XrefRangeEnd = 290369, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _UpdateSearch_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FilterConfigPanel.__c__DisplayClass41_0.NativeMethodInfoPtr__UpdateSearch_b__0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600E2FC RID: 58108 RVA: 0x0006E44A File Offset: 0x0006C64A
			public __c__DisplayClass41_0(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004602 RID: 17922
			// (get) Token: 0x0600E2FD RID: 58109 RVA: 0x0035BBEC File Offset: 0x00359DEC
			// (set) Token: 0x0600E2FE RID: 58110 RVA: 0x0006E453 File Offset: 0x0006C653
			public unsafe ItemDefinition item
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(FilterConfigPanel.__c__DisplayClass41_0.NativeFieldInfoPtr_item);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemDefinition>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(FilterConfigPanel.__c__DisplayClass41_0.NativeFieldInfoPtr_item), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004603 RID: 17923
			// (get) Token: 0x0600E2FF RID: 58111 RVA: 0x0035BC1C File Offset: 0x00359E1C
			// (set) Token: 0x0600E300 RID: 58112 RVA: 0x0006E472 File Offset: 0x0006C672
			public unsafe FilterConfigPanel __4__this
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(FilterConfigPanel.__c__DisplayClass41_0.NativeFieldInfoPtr___4__this);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<FilterConfigPanel>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(FilterConfigPanel.__c__DisplayClass41_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400981C RID: 38940
			private static readonly System.IntPtr NativeFieldInfoPtr_item;

			// Token: 0x0400981D RID: 38941
			private static readonly System.IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400981E RID: 38942
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400981F RID: 38943
			private static readonly System.IntPtr NativeMethodInfoPtr__UpdateSearch_b__0_Internal_Void_0;
		}

		// Token: 0x02000C16 RID: 3094
		[ObfuscatedName("ScheduleOne.UI.Items.FilterConfigPanel+<>c__DisplayClass57_0")]
		public sealed class __c__DisplayClass57_0 : Il2CppSystem.Object
		{
			// Token: 0x0600E301 RID: 58113 RVA: 0x0035BC4C File Offset: 0x00359E4C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass57_0()
			{
				Il2CppClassPointerStore<FilterConfigPanel.__c__DisplayClass57_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<FilterConfigPanel>.NativeClassPtr, "<>c__DisplayClass57_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FilterConfigPanel.__c__DisplayClass57_0>.NativeClassPtr);
				FilterConfigPanel.__c__DisplayClass57_0.NativeFieldInfoPtr_item = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FilterConfigPanel.__c__DisplayClass57_0>.NativeClassPtr, "item");
				FilterConfigPanel.__c__DisplayClass57_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FilterConfigPanel.__c__DisplayClass57_0>.NativeClassPtr, "<>4__this");
				FilterConfigPanel.__c__DisplayClass57_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilterConfigPanel.__c__DisplayClass57_0>.NativeClassPtr, 100683738);
				FilterConfigPanel.__c__DisplayClass57_0.NativeMethodInfoPtr__RefreshDisplay_b__0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilterConfigPanel.__c__DisplayClass57_0>.NativeClassPtr, 100683739);
			}

			// Token: 0x0600E302 RID: 58114 RVA: 0x0035BCC8 File Offset: 0x00359EC8
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass57_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FilterConfigPanel.__c__DisplayClass57_0>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FilterConfigPanel.__c__DisplayClass57_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600E303 RID: 58115 RVA: 0x0035BD04 File Offset: 0x00359F04
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 290369, XrefRangeEnd = 290374, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _RefreshDisplay_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FilterConfigPanel.__c__DisplayClass57_0.NativeMethodInfoPtr__RefreshDisplay_b__0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600E304 RID: 58116 RVA: 0x0006E491 File Offset: 0x0006C691
			public __c__DisplayClass57_0(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004604 RID: 17924
			// (get) Token: 0x0600E305 RID: 58117 RVA: 0x0035BD38 File Offset: 0x00359F38
			// (set) Token: 0x0600E306 RID: 58118 RVA: 0x0006E49A File Offset: 0x0006C69A
			public unsafe ItemDefinition item
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(FilterConfigPanel.__c__DisplayClass57_0.NativeFieldInfoPtr_item);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemDefinition>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(FilterConfigPanel.__c__DisplayClass57_0.NativeFieldInfoPtr_item), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004605 RID: 17925
			// (get) Token: 0x0600E307 RID: 58119 RVA: 0x0035BD68 File Offset: 0x00359F68
			// (set) Token: 0x0600E308 RID: 58120 RVA: 0x0006E4B9 File Offset: 0x0006C6B9
			public unsafe FilterConfigPanel __4__this
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(FilterConfigPanel.__c__DisplayClass57_0.NativeFieldInfoPtr___4__this);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<FilterConfigPanel>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(FilterConfigPanel.__c__DisplayClass57_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009820 RID: 38944
			private static readonly System.IntPtr NativeFieldInfoPtr_item;

			// Token: 0x04009821 RID: 38945
			private static readonly System.IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04009822 RID: 38946
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009823 RID: 38947
			private static readonly System.IntPtr NativeMethodInfoPtr__RefreshDisplay_b__0_Internal_Void_0;
		}
	}
}
