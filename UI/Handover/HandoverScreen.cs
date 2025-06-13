using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using Il2CppScheduleOne.Economy;
using Il2CppScheduleOne.ItemFramework;
using Il2CppScheduleOne.Quests;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppTMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI.Handover
{
	// Token: 0x0200071B RID: 1819
	public class HandoverScreen : Singleton<HandoverScreen>
	{
		// Token: 0x0600A1B6 RID: 41398 RVA: 0x0028EFE0 File Offset: 0x0028D1E0
		// Note: this type is marked as 'beforefieldinit'.
		static HandoverScreen()
		{
			Il2CppClassPointerStore<HandoverScreen>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Handover", "HandoverScreen");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HandoverScreen>.NativeClassPtr);
			HandoverScreen.NativeFieldInfoPtr_CUSTOMER_SLOT_COUNT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandoverScreen>.NativeClassPtr, "CUSTOMER_SLOT_COUNT");
			HandoverScreen.NativeFieldInfoPtr_VEHICLE_MAX_DIST = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandoverScreen>.NativeClassPtr, "VEHICLE_MAX_DIST");
			HandoverScreen.NativeFieldInfoPtr__CurrentContract_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandoverScreen>.NativeClassPtr, "<CurrentContract>k__BackingField");
			HandoverScreen.NativeFieldInfoPtr__IsOpen_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandoverScreen>.NativeClassPtr, "<IsOpen>k__BackingField");
			HandoverScreen.NativeFieldInfoPtr__TutorialOpen_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandoverScreen>.NativeClassPtr, "<TutorialOpen>k__BackingField");
			HandoverScreen.NativeFieldInfoPtr__Mode_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandoverScreen>.NativeClassPtr, "<Mode>k__BackingField");
			HandoverScreen.NativeFieldInfoPtr_SuccessColorMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandoverScreen>.NativeClassPtr, "SuccessColorMap");
			HandoverScreen.NativeFieldInfoPtr_Canvas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandoverScreen>.NativeClassPtr, "Canvas");
			HandoverScreen.NativeFieldInfoPtr_Container = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandoverScreen>.NativeClassPtr, "Container");
			HandoverScreen.NativeFieldInfoPtr_CanvasGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandoverScreen>.NativeClassPtr, "CanvasGroup");
			HandoverScreen.NativeFieldInfoPtr_DescriptionLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandoverScreen>.NativeClassPtr, "DescriptionLabel");
			HandoverScreen.NativeFieldInfoPtr_CustomerSubtitle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandoverScreen>.NativeClassPtr, "CustomerSubtitle");
			HandoverScreen.NativeFieldInfoPtr_FavouriteDrugLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandoverScreen>.NativeClassPtr, "FavouriteDrugLabel");
			HandoverScreen.NativeFieldInfoPtr_FavouritePropertiesLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandoverScreen>.NativeClassPtr, "FavouritePropertiesLabel");
			HandoverScreen.NativeFieldInfoPtr_PropertiesEntries = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandoverScreen>.NativeClassPtr, "PropertiesEntries");
			HandoverScreen.NativeFieldInfoPtr_ExpectationEntries = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandoverScreen>.NativeClassPtr, "ExpectationEntries");
			HandoverScreen.NativeFieldInfoPtr_NoVehicle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandoverScreen>.NativeClassPtr, "NoVehicle");
			HandoverScreen.NativeFieldInfoPtr_VehicleSlotContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandoverScreen>.NativeClassPtr, "VehicleSlotContainer");
			HandoverScreen.NativeFieldInfoPtr_CustomerSlotContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandoverScreen>.NativeClassPtr, "CustomerSlotContainer");
			HandoverScreen.NativeFieldInfoPtr_VehicleSubtitle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandoverScreen>.NativeClassPtr, "VehicleSubtitle");
			HandoverScreen.NativeFieldInfoPtr_SuccessLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandoverScreen>.NativeClassPtr, "SuccessLabel");
			HandoverScreen.NativeFieldInfoPtr_ErrorLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandoverScreen>.NativeClassPtr, "ErrorLabel");
			HandoverScreen.NativeFieldInfoPtr_WarningLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandoverScreen>.NativeClassPtr, "WarningLabel");
			HandoverScreen.NativeFieldInfoPtr_DoneButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandoverScreen>.NativeClassPtr, "DoneButton");
			HandoverScreen.NativeFieldInfoPtr_VehicleContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandoverScreen>.NativeClassPtr, "VehicleContainer");
			HandoverScreen.NativeFieldInfoPtr_TitleLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandoverScreen>.NativeClassPtr, "TitleLabel");
			HandoverScreen.NativeFieldInfoPtr_PriceSelector = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandoverScreen>.NativeClassPtr, "PriceSelector");
			HandoverScreen.NativeFieldInfoPtr_FairPriceLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandoverScreen>.NativeClassPtr, "FairPriceLabel");
			HandoverScreen.NativeFieldInfoPtr_TutorialAnimation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandoverScreen>.NativeClassPtr, "TutorialAnimation");
			HandoverScreen.NativeFieldInfoPtr_TutorialContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandoverScreen>.NativeClassPtr, "TutorialContainer");
			HandoverScreen.NativeFieldInfoPtr_DetailPanel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandoverScreen>.NativeClassPtr, "DetailPanel");
			HandoverScreen.NativeFieldInfoPtr_onHandoverComplete = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandoverScreen>.NativeClassPtr, "onHandoverComplete");
			HandoverScreen.NativeFieldInfoPtr_SuccessChanceMethod = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandoverScreen>.NativeClassPtr, "SuccessChanceMethod");
			HandoverScreen.NativeFieldInfoPtr_VehicleSlotUIs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandoverScreen>.NativeClassPtr, "VehicleSlotUIs");
			HandoverScreen.NativeFieldInfoPtr_CustomerSlotUIs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandoverScreen>.NativeClassPtr, "CustomerSlotUIs");
			HandoverScreen.NativeFieldInfoPtr_CustomerSlots = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandoverScreen>.NativeClassPtr, "CustomerSlots");
			HandoverScreen.NativeFieldInfoPtr_OriginalItemLocations = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandoverScreen>.NativeClassPtr, "OriginalItemLocations");
			HandoverScreen.NativeFieldInfoPtr_ignoreCustomerChangedEvents = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandoverScreen>.NativeClassPtr, "ignoreCustomerChangedEvents");
			HandoverScreen.NativeFieldInfoPtr__CurrentCustomer_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandoverScreen>.NativeClassPtr, "<CurrentCustomer>k__BackingField");
			HandoverScreen.NativeMethodInfoPtr_get_CurrentContract_Public_get_Contract_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandoverScreen>.NativeClassPtr, 100683216);
			HandoverScreen.NativeMethodInfoPtr_set_CurrentContract_Protected_set_Void_Contract_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandoverScreen>.NativeClassPtr, 100683217);
			HandoverScreen.NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandoverScreen>.NativeClassPtr, 100683218);
			HandoverScreen.NativeMethodInfoPtr_set_IsOpen_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandoverScreen>.NativeClassPtr, 100683219);
			HandoverScreen.NativeMethodInfoPtr_get_TutorialOpen_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandoverScreen>.NativeClassPtr, 100683220);
			HandoverScreen.NativeMethodInfoPtr_set_TutorialOpen_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandoverScreen>.NativeClassPtr, 100683221);
			HandoverScreen.NativeMethodInfoPtr_get_Mode_Public_get_EMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandoverScreen>.NativeClassPtr, 100683222);
			HandoverScreen.NativeMethodInfoPtr_set_Mode_Protected_set_Void_EMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandoverScreen>.NativeClassPtr, 100683223);
			HandoverScreen.NativeMethodInfoPtr_get_CurrentCustomer_Public_get_Customer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandoverScreen>.NativeClassPtr, 100683224);
			HandoverScreen.NativeMethodInfoPtr_set_CurrentCustomer_Private_set_Void_Customer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandoverScreen>.NativeClassPtr, 100683225);
			HandoverScreen.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandoverScreen>.NativeClassPtr, 100683226);
			HandoverScreen.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandoverScreen>.NativeClassPtr, 100683227);
			HandoverScreen.NativeMethodInfoPtr_OpenTutorial_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandoverScreen>.NativeClassPtr, 100683228);
			HandoverScreen.NativeMethodInfoPtr_CloseTutorial_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandoverScreen>.NativeClassPtr, 100683229);
			HandoverScreen.NativeMethodInfoPtr_Open_Public_Virtual_New_Void_Contract_Customer_EMode_Action_3_EHandoverOutcome_List_1_ItemInstance_Single_Func_3_List_1_ItemInstance_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandoverScreen>.NativeClassPtr, 100683230);
			HandoverScreen.NativeMethodInfoPtr_Close_Public_Virtual_New_Void_EHandoverOutcome_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandoverScreen>.NativeClassPtr, 100683231);
			HandoverScreen.NativeMethodInfoPtr_DonePressed_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandoverScreen>.NativeClassPtr, 100683232);
			HandoverScreen.NativeMethodInfoPtr_RecordOriginalLocations_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandoverScreen>.NativeClassPtr, 100683233);
			HandoverScreen.NativeMethodInfoPtr_Exit_Private_Void_ExitAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandoverScreen>.NativeClassPtr, 100683234);
			HandoverScreen.NativeMethodInfoPtr_ClearCustomerSlots_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandoverScreen>.NativeClassPtr, 100683235);
			HandoverScreen.NativeMethodInfoPtr_CustomerItemsChanged_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandoverScreen>.NativeClassPtr, 100683236);
			HandoverScreen.NativeMethodInfoPtr_UpdateDoneButton_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandoverScreen>.NativeClassPtr, 100683237);
			HandoverScreen.NativeMethodInfoPtr_UpdateSuccessChance_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandoverScreen>.NativeClassPtr, 100683238);
			HandoverScreen.NativeMethodInfoPtr_GetError_Private_Boolean_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandoverScreen>.NativeClassPtr, 100683239);
			HandoverScreen.NativeMethodInfoPtr_GetWarning_Private_Boolean_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandoverScreen>.NativeClassPtr, 100683240);
			HandoverScreen.NativeMethodInfoPtr_GetCustomerItems_Private_List_1_ItemInstance_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandoverScreen>.NativeClassPtr, 100683241);
			HandoverScreen.NativeMethodInfoPtr_GetCustomerItemsValue_Private_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandoverScreen>.NativeClassPtr, 100683242);
			HandoverScreen.NativeMethodInfoPtr_GetCustomerItemsCount_Private_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandoverScreen>.NativeClassPtr, 100683243);
			HandoverScreen.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandoverScreen>.NativeClassPtr, 100683244);
		}

		// Token: 0x170031B8 RID: 12728
		// (get) Token: 0x0600A1B7 RID: 41399 RVA: 0x0028F560 File Offset: 0x0028D760
		// (set) Token: 0x0600A1B8 RID: 41400 RVA: 0x0028F5A0 File Offset: 0x0028D7A0
		public unsafe Contract CurrentContract
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 20981, RefRangeEnd = 20984, XrefRangeStart = 20981, XrefRangeEnd = 20984, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HandoverScreen.NativeMethodInfoPtr_get_CurrentContract_Public_get_Contract_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Contract>(intPtr2) : null;
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 20985, RefRangeEnd = 20988, XrefRangeStart = 20985, XrefRangeEnd = 20988, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HandoverScreen.NativeMethodInfoPtr_set_CurrentContract_Protected_set_Void_Contract_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x170031B9 RID: 12729
		// (get) Token: 0x0600A1B9 RID: 41401 RVA: 0x0028F5E4 File Offset: 0x0028D7E4
		// (set) Token: 0x0600A1BA RID: 41402 RVA: 0x0028F620 File Offset: 0x0028D820
		public unsafe bool IsOpen
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(HandoverScreen.NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
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
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HandoverScreen.NativeMethodInfoPtr_set_IsOpen_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x170031BA RID: 12730
		// (get) Token: 0x0600A1BB RID: 41403 RVA: 0x0028F660 File Offset: 0x0028D860
		// (set) Token: 0x0600A1BC RID: 41404 RVA: 0x0028F69C File Offset: 0x0028D89C
		public unsafe bool TutorialOpen
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(HandoverScreen.NativeMethodInfoPtr_get_TutorialOpen_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 59906, RefRangeEnd = 59907, XrefRangeStart = 59906, XrefRangeEnd = 59907, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = ref value;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HandoverScreen.NativeMethodInfoPtr_set_TutorialOpen_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x170031BB RID: 12731
		// (get) Token: 0x0600A1BD RID: 41405 RVA: 0x0028F6DC File Offset: 0x0028D8DC
		// (set) Token: 0x0600A1BE RID: 41406 RVA: 0x0028F718 File Offset: 0x0028D918
		public unsafe HandoverScreen.EMode Mode
		{
			[CallerCount(123)]
			[CachedScanResults(RefRangeStart = 47877, RefRangeEnd = 48000, XrefRangeStart = 47877, XrefRangeEnd = 48000, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(HandoverScreen.NativeMethodInfoPtr_get_Mode_Public_get_EMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
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
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HandoverScreen.NativeMethodInfoPtr_set_Mode_Protected_set_Void_EMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x170031BC RID: 12732
		// (get) Token: 0x0600A1BF RID: 41407 RVA: 0x0028F758 File Offset: 0x0028D958
		// (set) Token: 0x0600A1C0 RID: 41408 RVA: 0x0028F798 File Offset: 0x0028D998
		public unsafe Customer CurrentCustomer
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HandoverScreen.NativeMethodInfoPtr_get_CurrentCustomer_Public_get_Customer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Customer>(intPtr2) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HandoverScreen.NativeMethodInfoPtr_set_CurrentCustomer_Private_set_Void_Customer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x0600A1C1 RID: 41409 RVA: 0x0028F7DC File Offset: 0x0028D9DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 285689, XrefRangeEnd = 285757, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HandoverScreen.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A1C2 RID: 41410 RVA: 0x0028F818 File Offset: 0x0028DA18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 285757, XrefRangeEnd = 285767, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HandoverScreen.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A1C3 RID: 41411 RVA: 0x0028F84C File Offset: 0x0028DA4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 285767, XrefRangeEnd = 285772, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OpenTutorial()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HandoverScreen.NativeMethodInfoPtr_OpenTutorial_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A1C4 RID: 41412 RVA: 0x0028F880 File Offset: 0x0028DA80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 285772, XrefRangeEnd = 285776, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CloseTutorial()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HandoverScreen.NativeMethodInfoPtr_CloseTutorial_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A1C5 RID: 41413 RVA: 0x0028F8B4 File Offset: 0x0028DAB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 285776, XrefRangeEnd = 285833, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Open(Contract contract, Customer customer, HandoverScreen.EMode mode, Il2CppSystem.Action<HandoverScreen.EHandoverOutcome, List<ItemInstance>, float> callback, Il2CppSystem.Func<List<ItemInstance>, float, float> successChanceMethod)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)5) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(contract);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(customer);
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref mode;
			ptr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
			ptr[checked(unchecked((System.UIntPtr)4) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(successChanceMethod);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HandoverScreen.NativeMethodInfoPtr_Open_Public_Virtual_New_Void_Contract_Customer_EMode_Action_3_EHandoverOutcome_List_1_ItemInstance_Single_Func_3_List_1_ItemInstance_Single_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A1C6 RID: 41414 RVA: 0x0028F948 File Offset: 0x0028DB48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 285833, XrefRangeEnd = 285897, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Close(HandoverScreen.EHandoverOutcome outcome)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref outcome;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HandoverScreen.NativeMethodInfoPtr_Close_Public_Virtual_New_Void_EHandoverOutcome_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A1C7 RID: 41415 RVA: 0x0028F994 File Offset: 0x0028DB94
		[CallerCount(0)]
		public unsafe void DonePressed()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HandoverScreen.NativeMethodInfoPtr_DonePressed_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A1C8 RID: 41416 RVA: 0x0028F9C8 File Offset: 0x0028DBC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 285897, XrefRangeEnd = 285928, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RecordOriginalLocations()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HandoverScreen.NativeMethodInfoPtr_RecordOriginalLocations_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A1C9 RID: 41417 RVA: 0x0028F9FC File Offset: 0x0028DBFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 285928, XrefRangeEnd = 285929, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Exit(ExitAction action)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(action);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HandoverScreen.NativeMethodInfoPtr_Exit_Private_Void_ExitAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A1CA RID: 41418 RVA: 0x0028FA40 File Offset: 0x0028DC40
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 285940, RefRangeEnd = 285948, XrefRangeStart = 285929, XrefRangeEnd = 285940, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ClearCustomerSlots(bool returnToOriginals)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref returnToOriginals;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HandoverScreen.NativeMethodInfoPtr_ClearCustomerSlots_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A1CB RID: 41419 RVA: 0x0028FA80 File Offset: 0x0028DC80
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 285964, RefRangeEnd = 285966, XrefRangeStart = 285948, XrefRangeEnd = 285964, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CustomerItemsChanged()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HandoverScreen.NativeMethodInfoPtr_CustomerItemsChanged_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A1CC RID: 41420 RVA: 0x0028FAB4 File Offset: 0x0028DCB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 285966, XrefRangeEnd = 285974, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateDoneButton()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HandoverScreen.NativeMethodInfoPtr_UpdateDoneButton_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A1CD RID: 41421 RVA: 0x0028FAE8 File Offset: 0x0028DCE8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 285989, RefRangeEnd = 285990, XrefRangeStart = 285974, XrefRangeEnd = 285989, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateSuccessChance()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HandoverScreen.NativeMethodInfoPtr_UpdateSuccessChance_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A1CE RID: 41422 RVA: 0x0028FB1C File Offset: 0x0028DD1C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 286011, RefRangeEnd = 286013, XrefRangeStart = 285990, XrefRangeEnd = 286011, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool GetError(out string err)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			ref System.IntPtr ptr2 = ref *ptr;
			System.IntPtr il2CppString = 0;
			ptr2 = &il2CppString;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(HandoverScreen.NativeMethodInfoPtr_GetError_Private_Boolean_byref_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			err = IL2CPP.Il2CppStringToManaged(il2CppString);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x0600A1CF RID: 41423 RVA: 0x0028FB74 File Offset: 0x0028DD74
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 286026, RefRangeEnd = 286028, XrefRangeStart = 286013, XrefRangeEnd = 286026, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool GetWarning(out string warning)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			ref System.IntPtr ptr2 = ref *ptr;
			System.IntPtr il2CppString = 0;
			ptr2 = &il2CppString;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(HandoverScreen.NativeMethodInfoPtr_GetWarning_Private_Boolean_byref_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			warning = IL2CPP.Il2CppStringToManaged(il2CppString);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x0600A1D0 RID: 41424 RVA: 0x0028FBCC File Offset: 0x0028DDCC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 286046, RefRangeEnd = 286049, XrefRangeStart = 286028, XrefRangeEnd = 286046, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<ItemInstance> GetCustomerItems(bool onlyPackagedProduct = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref onlyPackagedProduct;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HandoverScreen.NativeMethodInfoPtr_GetCustomerItems_Private_List_1_ItemInstance_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ItemInstance>>(intPtr2) : null;
		}

		// Token: 0x0600A1D1 RID: 41425 RVA: 0x0028FC18 File Offset: 0x0028DE18
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 286070, RefRangeEnd = 286071, XrefRangeStart = 286049, XrefRangeEnd = 286070, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float GetCustomerItemsValue()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(HandoverScreen.NativeMethodInfoPtr_GetCustomerItemsValue_Private_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x0600A1D2 RID: 41426 RVA: 0x0028FC54 File Offset: 0x0028DE54
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 286082, RefRangeEnd = 286085, XrefRangeStart = 286071, XrefRangeEnd = 286082, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetCustomerItemsCount(bool onlyPackagedProduct = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref onlyPackagedProduct;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(HandoverScreen.NativeMethodInfoPtr_GetCustomerItemsCount_Private_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x0600A1D3 RID: 41427 RVA: 0x0028FCA0 File Offset: 0x0028DEA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 286085, XrefRangeEnd = 286099, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe HandoverScreen() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HandoverScreen>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HandoverScreen.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A1D4 RID: 41428 RVA: 0x0004F1EC File Offset: 0x0004D3EC
		public HandoverScreen(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17003191 RID: 12689
		// (get) Token: 0x0600A1D5 RID: 41429 RVA: 0x0028FCDC File Offset: 0x0028DEDC
		// (set) Token: 0x0600A1D6 RID: 41430 RVA: 0x0004F1F5 File Offset: 0x0004D3F5
		public unsafe static int CUSTOMER_SLOT_COUNT
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(HandoverScreen.NativeFieldInfoPtr_CUSTOMER_SLOT_COUNT, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HandoverScreen.NativeFieldInfoPtr_CUSTOMER_SLOT_COUNT, (void*)(&value));
			}
		}

		// Token: 0x17003192 RID: 12690
		// (get) Token: 0x0600A1D7 RID: 41431 RVA: 0x0028FCF8 File Offset: 0x0028DEF8
		// (set) Token: 0x0600A1D8 RID: 41432 RVA: 0x0004F203 File Offset: 0x0004D403
		public unsafe static float VEHICLE_MAX_DIST
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(HandoverScreen.NativeFieldInfoPtr_VEHICLE_MAX_DIST, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HandoverScreen.NativeFieldInfoPtr_VEHICLE_MAX_DIST, (void*)(&value));
			}
		}

		// Token: 0x17003193 RID: 12691
		// (get) Token: 0x0600A1D9 RID: 41433 RVA: 0x0028FD14 File Offset: 0x0028DF14
		// (set) Token: 0x0600A1DA RID: 41434 RVA: 0x0004F211 File Offset: 0x0004D411
		public unsafe Contract _CurrentContract_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(HandoverScreen.NativeFieldInfoPtr__CurrentContract_k__BackingField);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Contract>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(HandoverScreen.NativeFieldInfoPtr__CurrentContract_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003194 RID: 12692
		// (get) Token: 0x0600A1DB RID: 41435 RVA: 0x0028FD44 File Offset: 0x0028DF44
		// (set) Token: 0x0600A1DC RID: 41436 RVA: 0x0004F230 File Offset: 0x0004D430
		public unsafe bool _IsOpen_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(HandoverScreen.NativeFieldInfoPtr__IsOpen_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(HandoverScreen.NativeFieldInfoPtr__IsOpen_k__BackingField)) = value;
			}
		}

		// Token: 0x17003195 RID: 12693
		// (get) Token: 0x0600A1DD RID: 41437 RVA: 0x0028FD6C File Offset: 0x0028DF6C
		// (set) Token: 0x0600A1DE RID: 41438 RVA: 0x0004F24B File Offset: 0x0004D44B
		public unsafe bool _TutorialOpen_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(HandoverScreen.NativeFieldInfoPtr__TutorialOpen_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(HandoverScreen.NativeFieldInfoPtr__TutorialOpen_k__BackingField)) = value;
			}
		}

		// Token: 0x17003196 RID: 12694
		// (get) Token: 0x0600A1DF RID: 41439 RVA: 0x0028FD94 File Offset: 0x0028DF94
		// (set) Token: 0x0600A1E0 RID: 41440 RVA: 0x0004F266 File Offset: 0x0004D466
		public unsafe HandoverScreen.EMode _Mode_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(HandoverScreen.NativeFieldInfoPtr__Mode_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(HandoverScreen.NativeFieldInfoPtr__Mode_k__BackingField)) = value;
			}
		}

		// Token: 0x17003197 RID: 12695
		// (get) Token: 0x0600A1E1 RID: 41441 RVA: 0x0028FDBC File Offset: 0x0028DFBC
		// (set) Token: 0x0600A1E2 RID: 41442 RVA: 0x0004F281 File Offset: 0x0004D481
		public unsafe Gradient SuccessColorMap
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(HandoverScreen.NativeFieldInfoPtr_SuccessColorMap);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Gradient>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(HandoverScreen.NativeFieldInfoPtr_SuccessColorMap), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003198 RID: 12696
		// (get) Token: 0x0600A1E3 RID: 41443 RVA: 0x0028FDEC File Offset: 0x0028DFEC
		// (set) Token: 0x0600A1E4 RID: 41444 RVA: 0x0004F2A0 File Offset: 0x0004D4A0
		public unsafe Canvas Canvas
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(HandoverScreen.NativeFieldInfoPtr_Canvas);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Canvas>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(HandoverScreen.NativeFieldInfoPtr_Canvas), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003199 RID: 12697
		// (get) Token: 0x0600A1E5 RID: 41445 RVA: 0x0028FE1C File Offset: 0x0028E01C
		// (set) Token: 0x0600A1E6 RID: 41446 RVA: 0x0004F2BF File Offset: 0x0004D4BF
		public unsafe GameObject Container
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(HandoverScreen.NativeFieldInfoPtr_Container);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(HandoverScreen.NativeFieldInfoPtr_Container), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700319A RID: 12698
		// (get) Token: 0x0600A1E7 RID: 41447 RVA: 0x0028FE4C File Offset: 0x0028E04C
		// (set) Token: 0x0600A1E8 RID: 41448 RVA: 0x0004F2DE File Offset: 0x0004D4DE
		public unsafe CanvasGroup CanvasGroup
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(HandoverScreen.NativeFieldInfoPtr_CanvasGroup);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CanvasGroup>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(HandoverScreen.NativeFieldInfoPtr_CanvasGroup), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700319B RID: 12699
		// (get) Token: 0x0600A1E9 RID: 41449 RVA: 0x0028FE7C File Offset: 0x0028E07C
		// (set) Token: 0x0600A1EA RID: 41450 RVA: 0x0004F2FD File Offset: 0x0004D4FD
		public unsafe TextMeshProUGUI DescriptionLabel
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(HandoverScreen.NativeFieldInfoPtr_DescriptionLabel);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(HandoverScreen.NativeFieldInfoPtr_DescriptionLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700319C RID: 12700
		// (get) Token: 0x0600A1EB RID: 41451 RVA: 0x0028FEAC File Offset: 0x0028E0AC
		// (set) Token: 0x0600A1EC RID: 41452 RVA: 0x0004F31C File Offset: 0x0004D51C
		public unsafe TextMeshProUGUI CustomerSubtitle
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(HandoverScreen.NativeFieldInfoPtr_CustomerSubtitle);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(HandoverScreen.NativeFieldInfoPtr_CustomerSubtitle), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700319D RID: 12701
		// (get) Token: 0x0600A1ED RID: 41453 RVA: 0x0028FEDC File Offset: 0x0028E0DC
		// (set) Token: 0x0600A1EE RID: 41454 RVA: 0x0004F33B File Offset: 0x0004D53B
		public unsafe TextMeshProUGUI FavouriteDrugLabel
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(HandoverScreen.NativeFieldInfoPtr_FavouriteDrugLabel);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(HandoverScreen.NativeFieldInfoPtr_FavouriteDrugLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700319E RID: 12702
		// (get) Token: 0x0600A1EF RID: 41455 RVA: 0x0028FF0C File Offset: 0x0028E10C
		// (set) Token: 0x0600A1F0 RID: 41456 RVA: 0x0004F35A File Offset: 0x0004D55A
		public unsafe TextMeshProUGUI FavouritePropertiesLabel
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(HandoverScreen.NativeFieldInfoPtr_FavouritePropertiesLabel);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(HandoverScreen.NativeFieldInfoPtr_FavouritePropertiesLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700319F RID: 12703
		// (get) Token: 0x0600A1F1 RID: 41457 RVA: 0x0028FF3C File Offset: 0x0028E13C
		// (set) Token: 0x0600A1F2 RID: 41458 RVA: 0x0004F379 File Offset: 0x0004D579
		public unsafe Il2CppReferenceArray<TextMeshProUGUI> PropertiesEntries
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(HandoverScreen.NativeFieldInfoPtr_PropertiesEntries);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<TextMeshProUGUI>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(HandoverScreen.NativeFieldInfoPtr_PropertiesEntries), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170031A0 RID: 12704
		// (get) Token: 0x0600A1F3 RID: 41459 RVA: 0x0028FF6C File Offset: 0x0028E16C
		// (set) Token: 0x0600A1F4 RID: 41460 RVA: 0x0004F398 File Offset: 0x0004D598
		public unsafe Il2CppReferenceArray<RectTransform> ExpectationEntries
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(HandoverScreen.NativeFieldInfoPtr_ExpectationEntries);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<RectTransform>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(HandoverScreen.NativeFieldInfoPtr_ExpectationEntries), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170031A1 RID: 12705
		// (get) Token: 0x0600A1F5 RID: 41461 RVA: 0x0028FF9C File Offset: 0x0028E19C
		// (set) Token: 0x0600A1F6 RID: 41462 RVA: 0x0004F3B7 File Offset: 0x0004D5B7
		public unsafe GameObject NoVehicle
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(HandoverScreen.NativeFieldInfoPtr_NoVehicle);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(HandoverScreen.NativeFieldInfoPtr_NoVehicle), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170031A2 RID: 12706
		// (get) Token: 0x0600A1F7 RID: 41463 RVA: 0x0028FFCC File Offset: 0x0028E1CC
		// (set) Token: 0x0600A1F8 RID: 41464 RVA: 0x0004F3D6 File Offset: 0x0004D5D6
		public unsafe RectTransform VehicleSlotContainer
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(HandoverScreen.NativeFieldInfoPtr_VehicleSlotContainer);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(HandoverScreen.NativeFieldInfoPtr_VehicleSlotContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170031A3 RID: 12707
		// (get) Token: 0x0600A1F9 RID: 41465 RVA: 0x0028FFFC File Offset: 0x0028E1FC
		// (set) Token: 0x0600A1FA RID: 41466 RVA: 0x0004F3F5 File Offset: 0x0004D5F5
		public unsafe RectTransform CustomerSlotContainer
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(HandoverScreen.NativeFieldInfoPtr_CustomerSlotContainer);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(HandoverScreen.NativeFieldInfoPtr_CustomerSlotContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170031A4 RID: 12708
		// (get) Token: 0x0600A1FB RID: 41467 RVA: 0x0029002C File Offset: 0x0028E22C
		// (set) Token: 0x0600A1FC RID: 41468 RVA: 0x0004F414 File Offset: 0x0004D614
		public unsafe TextMeshProUGUI VehicleSubtitle
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(HandoverScreen.NativeFieldInfoPtr_VehicleSubtitle);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(HandoverScreen.NativeFieldInfoPtr_VehicleSubtitle), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170031A5 RID: 12709
		// (get) Token: 0x0600A1FD RID: 41469 RVA: 0x0029005C File Offset: 0x0028E25C
		// (set) Token: 0x0600A1FE RID: 41470 RVA: 0x0004F433 File Offset: 0x0004D633
		public unsafe TextMeshProUGUI SuccessLabel
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(HandoverScreen.NativeFieldInfoPtr_SuccessLabel);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(HandoverScreen.NativeFieldInfoPtr_SuccessLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170031A6 RID: 12710
		// (get) Token: 0x0600A1FF RID: 41471 RVA: 0x0029008C File Offset: 0x0028E28C
		// (set) Token: 0x0600A200 RID: 41472 RVA: 0x0004F452 File Offset: 0x0004D652
		public unsafe TextMeshProUGUI ErrorLabel
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(HandoverScreen.NativeFieldInfoPtr_ErrorLabel);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(HandoverScreen.NativeFieldInfoPtr_ErrorLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170031A7 RID: 12711
		// (get) Token: 0x0600A201 RID: 41473 RVA: 0x002900BC File Offset: 0x0028E2BC
		// (set) Token: 0x0600A202 RID: 41474 RVA: 0x0004F471 File Offset: 0x0004D671
		public unsafe TextMeshProUGUI WarningLabel
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(HandoverScreen.NativeFieldInfoPtr_WarningLabel);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(HandoverScreen.NativeFieldInfoPtr_WarningLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170031A8 RID: 12712
		// (get) Token: 0x0600A203 RID: 41475 RVA: 0x002900EC File Offset: 0x0028E2EC
		// (set) Token: 0x0600A204 RID: 41476 RVA: 0x0004F490 File Offset: 0x0004D690
		public unsafe Button DoneButton
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(HandoverScreen.NativeFieldInfoPtr_DoneButton);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(HandoverScreen.NativeFieldInfoPtr_DoneButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170031A9 RID: 12713
		// (get) Token: 0x0600A205 RID: 41477 RVA: 0x0029011C File Offset: 0x0028E31C
		// (set) Token: 0x0600A206 RID: 41478 RVA: 0x0004F4AF File Offset: 0x0004D6AF
		public unsafe RectTransform VehicleContainer
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(HandoverScreen.NativeFieldInfoPtr_VehicleContainer);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(HandoverScreen.NativeFieldInfoPtr_VehicleContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170031AA RID: 12714
		// (get) Token: 0x0600A207 RID: 41479 RVA: 0x0029014C File Offset: 0x0028E34C
		// (set) Token: 0x0600A208 RID: 41480 RVA: 0x0004F4CE File Offset: 0x0004D6CE
		public unsafe TextMeshProUGUI TitleLabel
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(HandoverScreen.NativeFieldInfoPtr_TitleLabel);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(HandoverScreen.NativeFieldInfoPtr_TitleLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170031AB RID: 12715
		// (get) Token: 0x0600A209 RID: 41481 RVA: 0x0029017C File Offset: 0x0028E37C
		// (set) Token: 0x0600A20A RID: 41482 RVA: 0x0004F4ED File Offset: 0x0004D6ED
		public unsafe HandoverScreenPriceSelector PriceSelector
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(HandoverScreen.NativeFieldInfoPtr_PriceSelector);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<HandoverScreenPriceSelector>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(HandoverScreen.NativeFieldInfoPtr_PriceSelector), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170031AC RID: 12716
		// (get) Token: 0x0600A20B RID: 41483 RVA: 0x002901AC File Offset: 0x0028E3AC
		// (set) Token: 0x0600A20C RID: 41484 RVA: 0x0004F50C File Offset: 0x0004D70C
		public unsafe TextMeshProUGUI FairPriceLabel
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(HandoverScreen.NativeFieldInfoPtr_FairPriceLabel);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(HandoverScreen.NativeFieldInfoPtr_FairPriceLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170031AD RID: 12717
		// (get) Token: 0x0600A20D RID: 41485 RVA: 0x002901DC File Offset: 0x0028E3DC
		// (set) Token: 0x0600A20E RID: 41486 RVA: 0x0004F52B File Offset: 0x0004D72B
		public unsafe Animation TutorialAnimation
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(HandoverScreen.NativeFieldInfoPtr_TutorialAnimation);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Animation>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(HandoverScreen.NativeFieldInfoPtr_TutorialAnimation), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170031AE RID: 12718
		// (get) Token: 0x0600A20F RID: 41487 RVA: 0x0029020C File Offset: 0x0028E40C
		// (set) Token: 0x0600A210 RID: 41488 RVA: 0x0004F54A File Offset: 0x0004D74A
		public unsafe RectTransform TutorialContainer
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(HandoverScreen.NativeFieldInfoPtr_TutorialContainer);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(HandoverScreen.NativeFieldInfoPtr_TutorialContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170031AF RID: 12719
		// (get) Token: 0x0600A211 RID: 41489 RVA: 0x0029023C File Offset: 0x0028E43C
		// (set) Token: 0x0600A212 RID: 41490 RVA: 0x0004F569 File Offset: 0x0004D769
		public unsafe HandoverScreenDetailPanel DetailPanel
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(HandoverScreen.NativeFieldInfoPtr_DetailPanel);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<HandoverScreenDetailPanel>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(HandoverScreen.NativeFieldInfoPtr_DetailPanel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170031B0 RID: 12720
		// (get) Token: 0x0600A213 RID: 41491 RVA: 0x0029026C File Offset: 0x0028E46C
		// (set) Token: 0x0600A214 RID: 41492 RVA: 0x0004F588 File Offset: 0x0004D788
		public unsafe Il2CppSystem.Action<HandoverScreen.EHandoverOutcome, List<ItemInstance>, float> onHandoverComplete
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(HandoverScreen.NativeFieldInfoPtr_onHandoverComplete);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Action<HandoverScreen.EHandoverOutcome, List<ItemInstance>, float>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(HandoverScreen.NativeFieldInfoPtr_onHandoverComplete), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170031B1 RID: 12721
		// (get) Token: 0x0600A215 RID: 41493 RVA: 0x0029029C File Offset: 0x0028E49C
		// (set) Token: 0x0600A216 RID: 41494 RVA: 0x0004F5A7 File Offset: 0x0004D7A7
		public unsafe Il2CppSystem.Func<List<ItemInstance>, float, float> SuccessChanceMethod
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(HandoverScreen.NativeFieldInfoPtr_SuccessChanceMethod);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Func<List<ItemInstance>, float, float>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(HandoverScreen.NativeFieldInfoPtr_SuccessChanceMethod), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170031B2 RID: 12722
		// (get) Token: 0x0600A217 RID: 41495 RVA: 0x002902CC File Offset: 0x0028E4CC
		// (set) Token: 0x0600A218 RID: 41496 RVA: 0x0004F5C6 File Offset: 0x0004D7C6
		public unsafe Il2CppReferenceArray<ItemSlotUI> VehicleSlotUIs
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(HandoverScreen.NativeFieldInfoPtr_VehicleSlotUIs);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<ItemSlotUI>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(HandoverScreen.NativeFieldInfoPtr_VehicleSlotUIs), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170031B3 RID: 12723
		// (get) Token: 0x0600A219 RID: 41497 RVA: 0x002902FC File Offset: 0x0028E4FC
		// (set) Token: 0x0600A21A RID: 41498 RVA: 0x0004F5E5 File Offset: 0x0004D7E5
		public unsafe Il2CppReferenceArray<ItemSlotUI> CustomerSlotUIs
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(HandoverScreen.NativeFieldInfoPtr_CustomerSlotUIs);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<ItemSlotUI>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(HandoverScreen.NativeFieldInfoPtr_CustomerSlotUIs), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170031B4 RID: 12724
		// (get) Token: 0x0600A21B RID: 41499 RVA: 0x0029032C File Offset: 0x0028E52C
		// (set) Token: 0x0600A21C RID: 41500 RVA: 0x0004F604 File Offset: 0x0004D804
		public unsafe Il2CppReferenceArray<ItemSlot> CustomerSlots
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(HandoverScreen.NativeFieldInfoPtr_CustomerSlots);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<ItemSlot>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(HandoverScreen.NativeFieldInfoPtr_CustomerSlots), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170031B5 RID: 12725
		// (get) Token: 0x0600A21D RID: 41501 RVA: 0x0029035C File Offset: 0x0028E55C
		// (set) Token: 0x0600A21E RID: 41502 RVA: 0x0004F623 File Offset: 0x0004D823
		public unsafe Dictionary<ItemInstance, HandoverScreen.EItemSource> OriginalItemLocations
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(HandoverScreen.NativeFieldInfoPtr_OriginalItemLocations);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<ItemInstance, HandoverScreen.EItemSource>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(HandoverScreen.NativeFieldInfoPtr_OriginalItemLocations), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170031B6 RID: 12726
		// (get) Token: 0x0600A21F RID: 41503 RVA: 0x0029038C File Offset: 0x0028E58C
		// (set) Token: 0x0600A220 RID: 41504 RVA: 0x0004F642 File Offset: 0x0004D842
		public unsafe bool ignoreCustomerChangedEvents
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(HandoverScreen.NativeFieldInfoPtr_ignoreCustomerChangedEvents);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(HandoverScreen.NativeFieldInfoPtr_ignoreCustomerChangedEvents)) = value;
			}
		}

		// Token: 0x170031B7 RID: 12727
		// (get) Token: 0x0600A221 RID: 41505 RVA: 0x002903B4 File Offset: 0x0028E5B4
		// (set) Token: 0x0600A222 RID: 41506 RVA: 0x0004F65D File Offset: 0x0004D85D
		public unsafe Customer _CurrentCustomer_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(HandoverScreen.NativeFieldInfoPtr__CurrentCustomer_k__BackingField);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Customer>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(HandoverScreen.NativeFieldInfoPtr__CurrentCustomer_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04006C81 RID: 27777
		private static readonly System.IntPtr NativeFieldInfoPtr_CUSTOMER_SLOT_COUNT;

		// Token: 0x04006C82 RID: 27778
		private static readonly System.IntPtr NativeFieldInfoPtr_VEHICLE_MAX_DIST;

		// Token: 0x04006C83 RID: 27779
		private static readonly System.IntPtr NativeFieldInfoPtr__CurrentContract_k__BackingField;

		// Token: 0x04006C84 RID: 27780
		private static readonly System.IntPtr NativeFieldInfoPtr__IsOpen_k__BackingField;

		// Token: 0x04006C85 RID: 27781
		private static readonly System.IntPtr NativeFieldInfoPtr__TutorialOpen_k__BackingField;

		// Token: 0x04006C86 RID: 27782
		private static readonly System.IntPtr NativeFieldInfoPtr__Mode_k__BackingField;

		// Token: 0x04006C87 RID: 27783
		private static readonly System.IntPtr NativeFieldInfoPtr_SuccessColorMap;

		// Token: 0x04006C88 RID: 27784
		private static readonly System.IntPtr NativeFieldInfoPtr_Canvas;

		// Token: 0x04006C89 RID: 27785
		private static readonly System.IntPtr NativeFieldInfoPtr_Container;

		// Token: 0x04006C8A RID: 27786
		private static readonly System.IntPtr NativeFieldInfoPtr_CanvasGroup;

		// Token: 0x04006C8B RID: 27787
		private static readonly System.IntPtr NativeFieldInfoPtr_DescriptionLabel;

		// Token: 0x04006C8C RID: 27788
		private static readonly System.IntPtr NativeFieldInfoPtr_CustomerSubtitle;

		// Token: 0x04006C8D RID: 27789
		private static readonly System.IntPtr NativeFieldInfoPtr_FavouriteDrugLabel;

		// Token: 0x04006C8E RID: 27790
		private static readonly System.IntPtr NativeFieldInfoPtr_FavouritePropertiesLabel;

		// Token: 0x04006C8F RID: 27791
		private static readonly System.IntPtr NativeFieldInfoPtr_PropertiesEntries;

		// Token: 0x04006C90 RID: 27792
		private static readonly System.IntPtr NativeFieldInfoPtr_ExpectationEntries;

		// Token: 0x04006C91 RID: 27793
		private static readonly System.IntPtr NativeFieldInfoPtr_NoVehicle;

		// Token: 0x04006C92 RID: 27794
		private static readonly System.IntPtr NativeFieldInfoPtr_VehicleSlotContainer;

		// Token: 0x04006C93 RID: 27795
		private static readonly System.IntPtr NativeFieldInfoPtr_CustomerSlotContainer;

		// Token: 0x04006C94 RID: 27796
		private static readonly System.IntPtr NativeFieldInfoPtr_VehicleSubtitle;

		// Token: 0x04006C95 RID: 27797
		private static readonly System.IntPtr NativeFieldInfoPtr_SuccessLabel;

		// Token: 0x04006C96 RID: 27798
		private static readonly System.IntPtr NativeFieldInfoPtr_ErrorLabel;

		// Token: 0x04006C97 RID: 27799
		private static readonly System.IntPtr NativeFieldInfoPtr_WarningLabel;

		// Token: 0x04006C98 RID: 27800
		private static readonly System.IntPtr NativeFieldInfoPtr_DoneButton;

		// Token: 0x04006C99 RID: 27801
		private static readonly System.IntPtr NativeFieldInfoPtr_VehicleContainer;

		// Token: 0x04006C9A RID: 27802
		private static readonly System.IntPtr NativeFieldInfoPtr_TitleLabel;

		// Token: 0x04006C9B RID: 27803
		private static readonly System.IntPtr NativeFieldInfoPtr_PriceSelector;

		// Token: 0x04006C9C RID: 27804
		private static readonly System.IntPtr NativeFieldInfoPtr_FairPriceLabel;

		// Token: 0x04006C9D RID: 27805
		private static readonly System.IntPtr NativeFieldInfoPtr_TutorialAnimation;

		// Token: 0x04006C9E RID: 27806
		private static readonly System.IntPtr NativeFieldInfoPtr_TutorialContainer;

		// Token: 0x04006C9F RID: 27807
		private static readonly System.IntPtr NativeFieldInfoPtr_DetailPanel;

		// Token: 0x04006CA0 RID: 27808
		private static readonly System.IntPtr NativeFieldInfoPtr_onHandoverComplete;

		// Token: 0x04006CA1 RID: 27809
		private static readonly System.IntPtr NativeFieldInfoPtr_SuccessChanceMethod;

		// Token: 0x04006CA2 RID: 27810
		private static readonly System.IntPtr NativeFieldInfoPtr_VehicleSlotUIs;

		// Token: 0x04006CA3 RID: 27811
		private static readonly System.IntPtr NativeFieldInfoPtr_CustomerSlotUIs;

		// Token: 0x04006CA4 RID: 27812
		private static readonly System.IntPtr NativeFieldInfoPtr_CustomerSlots;

		// Token: 0x04006CA5 RID: 27813
		private static readonly System.IntPtr NativeFieldInfoPtr_OriginalItemLocations;

		// Token: 0x04006CA6 RID: 27814
		private static readonly System.IntPtr NativeFieldInfoPtr_ignoreCustomerChangedEvents;

		// Token: 0x04006CA7 RID: 27815
		private static readonly System.IntPtr NativeFieldInfoPtr__CurrentCustomer_k__BackingField;

		// Token: 0x04006CA8 RID: 27816
		private static readonly System.IntPtr NativeMethodInfoPtr_get_CurrentContract_Public_get_Contract_0;

		// Token: 0x04006CA9 RID: 27817
		private static readonly System.IntPtr NativeMethodInfoPtr_set_CurrentContract_Protected_set_Void_Contract_0;

		// Token: 0x04006CAA RID: 27818
		private static readonly System.IntPtr NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0;

		// Token: 0x04006CAB RID: 27819
		private static readonly System.IntPtr NativeMethodInfoPtr_set_IsOpen_Protected_set_Void_Boolean_0;

		// Token: 0x04006CAC RID: 27820
		private static readonly System.IntPtr NativeMethodInfoPtr_get_TutorialOpen_Public_get_Boolean_0;

		// Token: 0x04006CAD RID: 27821
		private static readonly System.IntPtr NativeMethodInfoPtr_set_TutorialOpen_Private_set_Void_Boolean_0;

		// Token: 0x04006CAE RID: 27822
		private static readonly System.IntPtr NativeMethodInfoPtr_get_Mode_Public_get_EMode_0;

		// Token: 0x04006CAF RID: 27823
		private static readonly System.IntPtr NativeMethodInfoPtr_set_Mode_Protected_set_Void_EMode_0;

		// Token: 0x04006CB0 RID: 27824
		private static readonly System.IntPtr NativeMethodInfoPtr_get_CurrentCustomer_Public_get_Customer_0;

		// Token: 0x04006CB1 RID: 27825
		private static readonly System.IntPtr NativeMethodInfoPtr_set_CurrentCustomer_Private_set_Void_Customer_0;

		// Token: 0x04006CB2 RID: 27826
		private static readonly System.IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x04006CB3 RID: 27827
		private static readonly System.IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x04006CB4 RID: 27828
		private static readonly System.IntPtr NativeMethodInfoPtr_OpenTutorial_Private_Void_0;

		// Token: 0x04006CB5 RID: 27829
		private static readonly System.IntPtr NativeMethodInfoPtr_CloseTutorial_Public_Void_0;

		// Token: 0x04006CB6 RID: 27830
		private static readonly System.IntPtr NativeMethodInfoPtr_Open_Public_Virtual_New_Void_Contract_Customer_EMode_Action_3_EHandoverOutcome_List_1_ItemInstance_Single_Func_3_List_1_ItemInstance_Single_Single_0;

		// Token: 0x04006CB7 RID: 27831
		private static readonly System.IntPtr NativeMethodInfoPtr_Close_Public_Virtual_New_Void_EHandoverOutcome_0;

		// Token: 0x04006CB8 RID: 27832
		private static readonly System.IntPtr NativeMethodInfoPtr_DonePressed_Public_Void_0;

		// Token: 0x04006CB9 RID: 27833
		private static readonly System.IntPtr NativeMethodInfoPtr_RecordOriginalLocations_Private_Void_0;

		// Token: 0x04006CBA RID: 27834
		private static readonly System.IntPtr NativeMethodInfoPtr_Exit_Private_Void_ExitAction_0;

		// Token: 0x04006CBB RID: 27835
		private static readonly System.IntPtr NativeMethodInfoPtr_ClearCustomerSlots_Public_Void_Boolean_0;

		// Token: 0x04006CBC RID: 27836
		private static readonly System.IntPtr NativeMethodInfoPtr_CustomerItemsChanged_Private_Void_0;

		// Token: 0x04006CBD RID: 27837
		private static readonly System.IntPtr NativeMethodInfoPtr_UpdateDoneButton_Private_Void_0;

		// Token: 0x04006CBE RID: 27838
		private static readonly System.IntPtr NativeMethodInfoPtr_UpdateSuccessChance_Private_Void_0;

		// Token: 0x04006CBF RID: 27839
		private static readonly System.IntPtr NativeMethodInfoPtr_GetError_Private_Boolean_byref_String_0;

		// Token: 0x04006CC0 RID: 27840
		private static readonly System.IntPtr NativeMethodInfoPtr_GetWarning_Private_Boolean_byref_String_0;

		// Token: 0x04006CC1 RID: 27841
		private static readonly System.IntPtr NativeMethodInfoPtr_GetCustomerItems_Private_List_1_ItemInstance_Boolean_0;

		// Token: 0x04006CC2 RID: 27842
		private static readonly System.IntPtr NativeMethodInfoPtr_GetCustomerItemsValue_Private_Single_0;

		// Token: 0x04006CC3 RID: 27843
		private static readonly System.IntPtr NativeMethodInfoPtr_GetCustomerItemsCount_Private_Int32_Boolean_0;

		// Token: 0x04006CC4 RID: 27844
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000BF2 RID: 3058
		[OriginalName("Assembly-CSharp.dll", "", "EMode")]
		public enum EMode
		{
			// Token: 0x0400975D RID: 38749
			Contract,
			// Token: 0x0400975E RID: 38750
			Sample,
			// Token: 0x0400975F RID: 38751
			Offer
		}

		// Token: 0x02000BF3 RID: 3059
		[OriginalName("Assembly-CSharp.dll", "", "EHandoverOutcome")]
		public enum EHandoverOutcome
		{
			// Token: 0x04009761 RID: 38753
			Cancelled,
			// Token: 0x04009762 RID: 38754
			Finalize
		}

		// Token: 0x02000BF4 RID: 3060
		[OriginalName("Assembly-CSharp.dll", "", "EItemSource")]
		public enum EItemSource
		{
			// Token: 0x04009764 RID: 38756
			Player,
			// Token: 0x04009765 RID: 38757
			Vehicle
		}
	}
}
