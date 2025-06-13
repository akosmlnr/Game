using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Audio;
using Il2CppScheduleOne.Delivery;
using Il2CppScheduleOne.DevUtilities;
using Il2CppScheduleOne.ItemFramework;
using Il2CppScheduleOne.Persistence.Datas;
using Il2CppScheduleOne.Persistence.Loaders;
using Il2CppScheduleOne.Storage;
using Il2CppScheduleOne.Vehicles;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using Il2CppTMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI.Shop
{
	// Token: 0x02000737 RID: 1847
	public class ShopInterface : MonoBehaviour
	{
		// Token: 0x0600A4F6 RID: 42230 RVA: 0x0029937C File Offset: 0x0029757C
		// Note: this type is marked as 'beforefieldinit'.
		static ShopInterface()
		{
			Il2CppClassPointerStore<ShopInterface>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Shop", "ShopInterface");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShopInterface>.NativeClassPtr);
			ShopInterface.NativeFieldInfoPtr_AllShops = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopInterface>.NativeClassPtr, "AllShops");
			ShopInterface.NativeFieldInfoPtr_MAX_ITEM_QUANTITY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopInterface>.NativeClassPtr, "MAX_ITEM_QUANTITY");
			ShopInterface.NativeFieldInfoPtr__IsOpen_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopInterface>.NativeClassPtr, "<IsOpen>k__BackingField");
			ShopInterface.NativeFieldInfoPtr_ShopName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopInterface>.NativeClassPtr, "ShopName");
			ShopInterface.NativeFieldInfoPtr_ShopCode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopInterface>.NativeClassPtr, "ShopCode");
			ShopInterface.NativeFieldInfoPtr_PaymentType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopInterface>.NativeClassPtr, "PaymentType");
			ShopInterface.NativeFieldInfoPtr_ShowCurrencyHint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopInterface>.NativeClassPtr, "ShowCurrencyHint");
			ShopInterface.NativeFieldInfoPtr_Listings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopInterface>.NativeClassPtr, "Listings");
			ShopInterface.NativeFieldInfoPtr_Canvas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopInterface>.NativeClassPtr, "Canvas");
			ShopInterface.NativeFieldInfoPtr_Container = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopInterface>.NativeClassPtr, "Container");
			ShopInterface.NativeFieldInfoPtr_ListingContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopInterface>.NativeClassPtr, "ListingContainer");
			ShopInterface.NativeFieldInfoPtr_StoreNameLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopInterface>.NativeClassPtr, "StoreNameLabel");
			ShopInterface.NativeFieldInfoPtr_Cart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopInterface>.NativeClassPtr, "Cart");
			ShopInterface.NativeFieldInfoPtr_DeliveryBays = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopInterface>.NativeClassPtr, "DeliveryBays");
			ShopInterface.NativeFieldInfoPtr_LoadingBayDetector = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopInterface>.NativeClassPtr, "LoadingBayDetector");
			ShopInterface.NativeFieldInfoPtr_DetailPanel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopInterface>.NativeClassPtr, "DetailPanel");
			ShopInterface.NativeFieldInfoPtr_ListingScrollRect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopInterface>.NativeClassPtr, "ListingScrollRect");
			ShopInterface.NativeFieldInfoPtr_AmountSelector = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopInterface>.NativeClassPtr, "AmountSelector");
			ShopInterface.NativeFieldInfoPtr_DeliveryVehicle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopInterface>.NativeClassPtr, "DeliveryVehicle");
			ShopInterface.NativeFieldInfoPtr_AddItemSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopInterface>.NativeClassPtr, "AddItemSound");
			ShopInterface.NativeFieldInfoPtr_RemoveItemSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopInterface>.NativeClassPtr, "RemoveItemSound");
			ShopInterface.NativeFieldInfoPtr_CheckoutSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopInterface>.NativeClassPtr, "CheckoutSound");
			ShopInterface.NativeFieldInfoPtr_ListingUIPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopInterface>.NativeClassPtr, "ListingUIPrefab");
			ShopInterface.NativeFieldInfoPtr_onOrderCompleted = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopInterface>.NativeClassPtr, "onOrderCompleted");
			ShopInterface.NativeFieldInfoPtr_categoryButtons = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopInterface>.NativeClassPtr, "categoryButtons");
			ShopInterface.NativeFieldInfoPtr_categoryFilter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopInterface>.NativeClassPtr, "categoryFilter");
			ShopInterface.NativeFieldInfoPtr_searchTerm = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopInterface>.NativeClassPtr, "searchTerm");
			ShopInterface.NativeFieldInfoPtr_listingUI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopInterface>.NativeClassPtr, "listingUI");
			ShopInterface.NativeFieldInfoPtr_selectedListing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopInterface>.NativeClassPtr, "selectedListing");
			ShopInterface.NativeFieldInfoPtr_dropdownMouseUp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopInterface>.NativeClassPtr, "dropdownMouseUp");
			ShopInterface.NativeFieldInfoPtr_loader = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopInterface>.NativeClassPtr, "loader");
			ShopInterface.NativeFieldInfoPtr__LocalExtraFiles_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopInterface>.NativeClassPtr, "<LocalExtraFiles>k__BackingField");
			ShopInterface.NativeFieldInfoPtr__LocalExtraFolders_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopInterface>.NativeClassPtr, "<LocalExtraFolders>k__BackingField");
			ShopInterface.NativeFieldInfoPtr__HasChanged_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopInterface>.NativeClassPtr, "<HasChanged>k__BackingField");
			ShopInterface.NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopInterface>.NativeClassPtr, 100683564);
			ShopInterface.NativeMethodInfoPtr_set_IsOpen_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopInterface>.NativeClassPtr, 100683565);
			ShopInterface.NativeMethodInfoPtr_get_SaveFolderName_Public_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopInterface>.NativeClassPtr, 100683566);
			ShopInterface.NativeMethodInfoPtr_get_SaveFileName_Public_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopInterface>.NativeClassPtr, 100683567);
			ShopInterface.NativeMethodInfoPtr_get_Loader_Public_Virtual_Final_New_get_Loader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopInterface>.NativeClassPtr, 100683568);
			ShopInterface.NativeMethodInfoPtr_get_ShouldSaveUnderFolder_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopInterface>.NativeClassPtr, 100683569);
			ShopInterface.NativeMethodInfoPtr_get_LocalExtraFiles_Public_Virtual_Final_New_get_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopInterface>.NativeClassPtr, 100683570);
			ShopInterface.NativeMethodInfoPtr_set_LocalExtraFiles_Public_Virtual_Final_New_set_Void_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopInterface>.NativeClassPtr, 100683571);
			ShopInterface.NativeMethodInfoPtr_get_LocalExtraFolders_Public_Virtual_Final_New_get_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopInterface>.NativeClassPtr, 100683572);
			ShopInterface.NativeMethodInfoPtr_set_LocalExtraFolders_Public_Virtual_Final_New_set_Void_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopInterface>.NativeClassPtr, 100683573);
			ShopInterface.NativeMethodInfoPtr_get_HasChanged_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopInterface>.NativeClassPtr, 100683574);
			ShopInterface.NativeMethodInfoPtr_set_HasChanged_Public_Virtual_Final_New_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopInterface>.NativeClassPtr, 100683575);
			ShopInterface.NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopInterface>.NativeClassPtr, 100683576);
			ShopInterface.NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopInterface>.NativeClassPtr, 100683577);
			ShopInterface.NativeMethodInfoPtr_InitializeSaveable_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopInterface>.NativeClassPtr, 100683578);
			ShopInterface.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopInterface>.NativeClassPtr, 100683579);
			ShopInterface.NativeMethodInfoPtr_OnValidate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopInterface>.NativeClassPtr, 100683580);
			ShopInterface.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopInterface>.NativeClassPtr, 100683581);
			ShopInterface.NativeMethodInfoPtr_OnDayPass_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopInterface>.NativeClassPtr, 100683582);
			ShopInterface.NativeMethodInfoPtr_OnWeekPass_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopInterface>.NativeClassPtr, 100683583);
			ShopInterface.NativeMethodInfoPtr_Open_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopInterface>.NativeClassPtr, 100683584);
			ShopInterface.NativeMethodInfoPtr_SetIsOpen_Public_Virtual_New_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopInterface>.NativeClassPtr, 100683585);
			ShopInterface.NativeMethodInfoPtr_Hint_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopInterface>.NativeClassPtr, 100683586);
			ShopInterface.NativeMethodInfoPtr_Exit_Protected_Virtual_New_Void_ExitAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopInterface>.NativeClassPtr, 100683587);
			ShopInterface.NativeMethodInfoPtr_CreateListingUI_Private_Void_ShopListing_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopInterface>.NativeClassPtr, 100683588);
			ShopInterface.NativeMethodInfoPtr_SelectCategory_Public_Void_EShopCategory_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopInterface>.NativeClassPtr, 100683589);
			ShopInterface.NativeMethodInfoPtr_ListingClicked_Public_Virtual_New_Void_ListingUI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopInterface>.NativeClassPtr, 100683590);
			ShopInterface.NativeMethodInfoPtr_ShowCartAnimation_Private_Void_ListingUI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopInterface>.NativeClassPtr, 100683591);
			ShopInterface.NativeMethodInfoPtr_CategorySelected_Public_Void_EShopCategory_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopInterface>.NativeClassPtr, 100683592);
			ShopInterface.NativeMethodInfoPtr_DeselectCurrentCategory_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopInterface>.NativeClassPtr, 100683593);
			ShopInterface.NativeMethodInfoPtr_RefreshShownItems_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopInterface>.NativeClassPtr, 100683594);
			ShopInterface.NativeMethodInfoPtr_RefreshUnlockStatus_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopInterface>.NativeClassPtr, 100683595);
			ShopInterface.NativeMethodInfoPtr_RestockAllListings_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopInterface>.NativeClassPtr, 100683596);
			ShopInterface.NativeMethodInfoPtr_CanCartFitItem_Public_Boolean_ShopListing_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopInterface>.NativeClassPtr, 100683597);
			ShopInterface.NativeMethodInfoPtr_WillCartFit_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopInterface>.NativeClassPtr, 100683598);
			ShopInterface.NativeMethodInfoPtr_WillCartFit_Public_Boolean_List_1_ItemSlot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopInterface>.NativeClassPtr, 100683599);
			ShopInterface.NativeMethodInfoPtr_HandoverItems_Public_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopInterface>.NativeClassPtr, 100683600);
			ShopInterface.NativeMethodInfoPtr_GetAvailableSlots_Public_List_1_ItemSlot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopInterface>.NativeClassPtr, 100683601);
			ShopInterface.NativeMethodInfoPtr_GetLoadingBayVehicle_Public_LandVehicle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopInterface>.NativeClassPtr, 100683602);
			ShopInterface.NativeMethodInfoPtr_PlaceItemInDeliveryBay_Public_Void_ItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopInterface>.NativeClassPtr, 100683603);
			ShopInterface.NativeMethodInfoPtr_QuantitySelected_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopInterface>.NativeClassPtr, 100683604);
			ShopInterface.NativeMethodInfoPtr_OpenAmountSelector_Public_Void_ListingUI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopInterface>.NativeClassPtr, 100683605);
			ShopInterface.NativeMethodInfoPtr_DropdownClicked_Private_Void_ListingUI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopInterface>.NativeClassPtr, 100683606);
			ShopInterface.NativeMethodInfoPtr_EntryHovered_Private_Void_ListingUI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopInterface>.NativeClassPtr, 100683607);
			ShopInterface.NativeMethodInfoPtr_EntryUnhovered_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopInterface>.NativeClassPtr, 100683608);
			ShopInterface.NativeMethodInfoPtr_Load_Public_Void_ShopData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopInterface>.NativeClassPtr, 100683609);
			ShopInterface.NativeMethodInfoPtr_ShouldSave_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopInterface>.NativeClassPtr, 100683610);
			ShopInterface.NativeMethodInfoPtr_GetListing_Public_ShopListing_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopInterface>.NativeClassPtr, 100683611);
			ShopInterface.NativeMethodInfoPtr_GetSaveData_Public_Virtual_New_ShopData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopInterface>.NativeClassPtr, 100683612);
			ShopInterface.NativeMethodInfoPtr_GetSaveString_Public_Virtual_Final_New_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopInterface>.NativeClassPtr, 100683613);
			ShopInterface.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopInterface>.NativeClassPtr, 100683614);
			ShopInterface.NativeMethodInfoPtr__DeselectCurrentCategory_b__72_0_Private_Boolean_CategoryButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopInterface>.NativeClassPtr, 100683616);
		}

		// Token: 0x170032C6 RID: 12998
		// (get) Token: 0x0600A4F7 RID: 42231 RVA: 0x00299A64 File Offset: 0x00297C64
		// (set) Token: 0x0600A4F8 RID: 42232 RVA: 0x00299AA0 File Offset: 0x00297CA0
		public unsafe bool IsOpen
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 37513, RefRangeEnd = 37514, XrefRangeStart = 37513, XrefRangeEnd = 37514, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(ShopInterface.NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
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
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShopInterface.NativeMethodInfoPtr_set_IsOpen_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x170032C7 RID: 12999
		// (get) Token: 0x0600A4F9 RID: 42233 RVA: 0x00299AE0 File Offset: 0x00297CE0
		public unsafe virtual string SaveFolderName
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 289194, XrefRangeEnd = 289195, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(ShopInterface.NativeMethodInfoPtr_get_SaveFolderName_Public_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return IL2CPP.Il2CppStringToManaged(il2CppString);
			}
		}

		// Token: 0x170032C8 RID: 13000
		// (get) Token: 0x0600A4FA RID: 42234 RVA: 0x00299B18 File Offset: 0x00297D18
		public unsafe virtual string SaveFileName
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(ShopInterface.NativeMethodInfoPtr_get_SaveFileName_Public_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return IL2CPP.Il2CppStringToManaged(il2CppString);
			}
		}

		// Token: 0x170032C9 RID: 13001
		// (get) Token: 0x0600A4FB RID: 42235 RVA: 0x00299B50 File Offset: 0x00297D50
		public unsafe virtual Loader Loader
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShopInterface.NativeMethodInfoPtr_get_Loader_Public_Virtual_Final_New_get_Loader_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Loader>(intPtr2) : null;
			}
		}

		// Token: 0x170032CA RID: 13002
		// (get) Token: 0x0600A4FC RID: 42236 RVA: 0x00299B90 File Offset: 0x00297D90
		public unsafe virtual bool ShouldSaveUnderFolder
		{
			[CallerCount(176)]
			[CachedScanResults(RefRangeStart = 38110, RefRangeEnd = 38286, XrefRangeStart = 38110, XrefRangeEnd = 38286, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(ShopInterface.NativeMethodInfoPtr_get_ShouldSaveUnderFolder_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
		}

		// Token: 0x170032CB RID: 13003
		// (get) Token: 0x0600A4FD RID: 42237 RVA: 0x00299BCC File Offset: 0x00297DCC
		// (set) Token: 0x0600A4FE RID: 42238 RVA: 0x00299C0C File Offset: 0x00297E0C
		public unsafe virtual List<string> LocalExtraFiles
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShopInterface.NativeMethodInfoPtr_get_LocalExtraFiles_Public_Virtual_Final_New_get_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShopInterface.NativeMethodInfoPtr_set_LocalExtraFiles_Public_Virtual_Final_New_set_Void_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x170032CC RID: 13004
		// (get) Token: 0x0600A4FF RID: 42239 RVA: 0x00299C50 File Offset: 0x00297E50
		// (set) Token: 0x0600A500 RID: 42240 RVA: 0x00299C90 File Offset: 0x00297E90
		public unsafe virtual List<string> LocalExtraFolders
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShopInterface.NativeMethodInfoPtr_get_LocalExtraFolders_Public_Virtual_Final_New_get_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShopInterface.NativeMethodInfoPtr_set_LocalExtraFolders_Public_Virtual_Final_New_set_Void_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x170032CD RID: 13005
		// (get) Token: 0x0600A501 RID: 42241 RVA: 0x00299CD4 File Offset: 0x00297ED4
		// (set) Token: 0x0600A502 RID: 42242 RVA: 0x00299D10 File Offset: 0x00297F10
		public unsafe virtual bool HasChanged
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(ShopInterface.NativeMethodInfoPtr_get_HasChanged_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
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
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShopInterface.NativeMethodInfoPtr_set_HasChanged_Public_Virtual_Final_New_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x0600A503 RID: 42243 RVA: 0x00299D50 File Offset: 0x00297F50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 289195, XrefRangeEnd = 289259, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ShopInterface.NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A504 RID: 42244 RVA: 0x00299D8C File Offset: 0x00297F8C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 289340, RefRangeEnd = 289341, XrefRangeStart = 289259, XrefRangeEnd = 289340, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ShopInterface.NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A505 RID: 42245 RVA: 0x00299DC8 File Offset: 0x00297FC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 289341, XrefRangeEnd = 289347, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void InitializeSaveable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ShopInterface.NativeMethodInfoPtr_InitializeSaveable_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A506 RID: 42246 RVA: 0x00299E04 File Offset: 0x00298004
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 289347, XrefRangeEnd = 289355, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShopInterface.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A507 RID: 42247 RVA: 0x00299E38 File Offset: 0x00298038
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 289355, XrefRangeEnd = 289419, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnValidate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShopInterface.NativeMethodInfoPtr_OnValidate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A508 RID: 42248 RVA: 0x00299E6C File Offset: 0x0029806C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 289419, XrefRangeEnd = 289420, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ShopInterface.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A509 RID: 42249 RVA: 0x00299EA8 File Offset: 0x002980A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 289420, XrefRangeEnd = 289431, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDayPass()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShopInterface.NativeMethodInfoPtr_OnDayPass_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A50A RID: 42250 RVA: 0x00299EDC File Offset: 0x002980DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 289431, XrefRangeEnd = 289442, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnWeekPass()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShopInterface.NativeMethodInfoPtr_OnWeekPass_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A50B RID: 42251 RVA: 0x00299F10 File Offset: 0x00298110
		[CallerCount(0)]
		public unsafe void Open()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShopInterface.NativeMethodInfoPtr_Open_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A50C RID: 42252 RVA: 0x00299F44 File Offset: 0x00298144
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 289442, XrefRangeEnd = 289555, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetIsOpen(bool isOpen)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref isOpen;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ShopInterface.NativeMethodInfoPtr_SetIsOpen_Public_Virtual_New_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A50D RID: 42253 RVA: 0x00299F90 File Offset: 0x00298190
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 289555, XrefRangeEnd = 289563, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Hint()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShopInterface.NativeMethodInfoPtr_Hint_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A50E RID: 42254 RVA: 0x00299FC4 File Offset: 0x002981C4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 289564, RefRangeEnd = 289565, XrefRangeStart = 289563, XrefRangeEnd = 289564, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Exit(ExitAction action)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(action);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ShopInterface.NativeMethodInfoPtr_Exit_Protected_Virtual_New_Void_ExitAction_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A50F RID: 42255 RVA: 0x0029A014 File Offset: 0x00298214
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 289625, RefRangeEnd = 289626, XrefRangeStart = 289565, XrefRangeEnd = 289625, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CreateListingUI(ShopListing listing)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(listing);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShopInterface.NativeMethodInfoPtr_CreateListingUI_Private_Void_ShopListing_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A510 RID: 42256 RVA: 0x0029A058 File Offset: 0x00298258
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 289626, XrefRangeEnd = 289654, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SelectCategory(EShopCategory category)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref category;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShopInterface.NativeMethodInfoPtr_SelectCategory_Public_Void_EShopCategory_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A511 RID: 42257 RVA: 0x0029A098 File Offset: 0x00298298
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 289657, RefRangeEnd = 289658, XrefRangeStart = 289654, XrefRangeEnd = 289657, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void ListingClicked(ListingUI listingUI)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(listingUI);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ShopInterface.NativeMethodInfoPtr_ListingClicked_Public_Virtual_New_Void_ListingUI_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A512 RID: 42258 RVA: 0x0029A0E8 File Offset: 0x002982E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 289658, XrefRangeEnd = 289671, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ShowCartAnimation(ListingUI listing)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(listing);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShopInterface.NativeMethodInfoPtr_ShowCartAnimation_Private_Void_ListingUI_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A513 RID: 42259 RVA: 0x0029A12C File Offset: 0x0029832C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 289682, RefRangeEnd = 289684, XrefRangeStart = 289671, XrefRangeEnd = 289682, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CategorySelected(EShopCategory category)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref category;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShopInterface.NativeMethodInfoPtr_CategorySelected_Public_Void_EShopCategory_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A514 RID: 42260 RVA: 0x0029A16C File Offset: 0x0029836C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 289684, XrefRangeEnd = 289695, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DeselectCurrentCategory()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShopInterface.NativeMethodInfoPtr_DeselectCurrentCategory_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A515 RID: 42261 RVA: 0x0029A1A0 File Offset: 0x002983A0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 289760, RefRangeEnd = 289763, XrefRangeStart = 289695, XrefRangeEnd = 289760, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RefreshShownItems()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShopInterface.NativeMethodInfoPtr_RefreshShownItems_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A516 RID: 42262 RVA: 0x0029A1D4 File Offset: 0x002983D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 289763, XrefRangeEnd = 289769, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RefreshUnlockStatus()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShopInterface.NativeMethodInfoPtr_RefreshUnlockStatus_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A517 RID: 42263 RVA: 0x0029A208 File Offset: 0x00298408
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 289784, RefRangeEnd = 289785, XrefRangeStart = 289769, XrefRangeEnd = 289784, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RestockAllListings()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShopInterface.NativeMethodInfoPtr_RestockAllListings_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A518 RID: 42264 RVA: 0x0029A23C File Offset: 0x0029843C
		[CallerCount(21)]
		[CachedScanResults(RefRangeStart = 31612, RefRangeEnd = 31633, XrefRangeStart = 31612, XrefRangeEnd = 31633, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool CanCartFitItem(ShopListing listing)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(listing);
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(ShopInterface.NativeMethodInfoPtr_CanCartFitItem_Public_Boolean_ShopListing_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x0600A519 RID: 42265 RVA: 0x0029A28C File Offset: 0x0029848C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 289797, RefRangeEnd = 289798, XrefRangeStart = 289785, XrefRangeEnd = 289797, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool WillCartFit()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(ShopInterface.NativeMethodInfoPtr_WillCartFit_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x0600A51A RID: 42266 RVA: 0x0029A2C8 File Offset: 0x002984C8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 289835, RefRangeEnd = 289837, XrefRangeStart = 289798, XrefRangeEnd = 289835, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool WillCartFit(List<ItemSlot> availableSlots)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(availableSlots);
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(ShopInterface.NativeMethodInfoPtr_WillCartFit_Public_Boolean_List_1_ItemSlot_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x0600A51B RID: 42267 RVA: 0x0029A318 File Offset: 0x00298518
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 289837, XrefRangeEnd = 289880, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool HandoverItems()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ShopInterface.NativeMethodInfoPtr_HandoverItems_Public_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x0600A51C RID: 42268 RVA: 0x0029A360 File Offset: 0x00298560
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 289908, RefRangeEnd = 289911, XrefRangeStart = 289880, XrefRangeEnd = 289908, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<ItemSlot> GetAvailableSlots()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShopInterface.NativeMethodInfoPtr_GetAvailableSlots_Public_List_1_ItemSlot_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ItemSlot>>(intPtr2) : null;
		}

		// Token: 0x0600A51D RID: 42269 RVA: 0x0029A3A0 File Offset: 0x002985A0
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 289918, RefRangeEnd = 289922, XrefRangeStart = 289911, XrefRangeEnd = 289918, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LandVehicle GetLoadingBayVehicle()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShopInterface.NativeMethodInfoPtr_GetLoadingBayVehicle_Public_LandVehicle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<LandVehicle>(intPtr2) : null;
		}

		// Token: 0x0600A51E RID: 42270 RVA: 0x0029A3E0 File Offset: 0x002985E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 289922, XrefRangeEnd = 289931, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PlaceItemInDeliveryBay(ItemInstance item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShopInterface.NativeMethodInfoPtr_PlaceItemInDeliveryBay_Public_Void_ItemInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A51F RID: 42271 RVA: 0x0029A424 File Offset: 0x00298624
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 289931, XrefRangeEnd = 289941, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void QuantitySelected(int amount)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref amount;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShopInterface.NativeMethodInfoPtr_QuantitySelected_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A520 RID: 42272 RVA: 0x0029A464 File Offset: 0x00298664
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 289941, XrefRangeEnd = 289948, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OpenAmountSelector(ListingUI listing)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(listing);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShopInterface.NativeMethodInfoPtr_OpenAmountSelector_Public_Void_ListingUI_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A521 RID: 42273 RVA: 0x0029A4A8 File Offset: 0x002986A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 289948, XrefRangeEnd = 289959, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DropdownClicked(ListingUI listing)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(listing);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShopInterface.NativeMethodInfoPtr_DropdownClicked_Private_Void_ListingUI_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A522 RID: 42274 RVA: 0x0029A4EC File Offset: 0x002986EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 289959, XrefRangeEnd = 289961, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EntryHovered(ListingUI listing)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(listing);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShopInterface.NativeMethodInfoPtr_EntryHovered_Private_Void_ListingUI_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A523 RID: 42275 RVA: 0x0029A530 File Offset: 0x00298730
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 289961, XrefRangeEnd = 289965, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EntryUnhovered()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShopInterface.NativeMethodInfoPtr_EntryUnhovered_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A524 RID: 42276 RVA: 0x0029A564 File Offset: 0x00298764
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 289995, RefRangeEnd = 289996, XrefRangeStart = 289965, XrefRangeEnd = 289995, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Load(ShopData data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShopInterface.NativeMethodInfoPtr_Load_Public_Void_ShopData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A525 RID: 42277 RVA: 0x0029A5A8 File Offset: 0x002987A8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 290012, RefRangeEnd = 290013, XrefRangeStart = 289996, XrefRangeEnd = 290012, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool ShouldSave()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(ShopInterface.NativeMethodInfoPtr_ShouldSave_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x0600A526 RID: 42278 RVA: 0x0029A5E4 File Offset: 0x002987E4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 290028, RefRangeEnd = 290029, XrefRangeStart = 290013, XrefRangeEnd = 290028, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ShopListing GetListing(string itemID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(itemID);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShopInterface.NativeMethodInfoPtr_GetListing_Public_ShopListing_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<ShopListing>(intPtr2) : null;
		}

		// Token: 0x0600A527 RID: 42279 RVA: 0x0029A634 File Offset: 0x00298834
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 290029, XrefRangeEnd = 290063, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual ShopData GetSaveData()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ShopInterface.NativeMethodInfoPtr_GetSaveData_Public_Virtual_New_ShopData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<ShopData>(intPtr2) : null;
		}

		// Token: 0x0600A528 RID: 42280 RVA: 0x0029A680 File Offset: 0x00298880
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 290063, XrefRangeEnd = 290064, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual string GetSaveString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(ShopInterface.NativeMethodInfoPtr_GetSaveString_Public_Virtual_Final_New_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return IL2CPP.Il2CppStringToManaged(il2CppString);
		}

		// Token: 0x0600A529 RID: 42281 RVA: 0x0029A6B8 File Offset: 0x002988B8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 290114, RefRangeEnd = 290115, XrefRangeStart = 290064, XrefRangeEnd = 290114, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ShopInterface() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ShopInterface>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShopInterface.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A52A RID: 42282 RVA: 0x0029A6F4 File Offset: 0x002988F4
		[CallerCount(0)]
		public unsafe bool _DeselectCurrentCategory_b__72_0(CategoryButton x)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(ShopInterface.NativeMethodInfoPtr__DeselectCurrentCategory_b__72_0_Private_Boolean_CategoryButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x0600A52B RID: 42283 RVA: 0x00050F3A File Offset: 0x0004F13A
		public ShopInterface(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170032A4 RID: 12964
		// (get) Token: 0x0600A52C RID: 42284 RVA: 0x0029A744 File Offset: 0x00298944
		// (set) Token: 0x0600A52D RID: 42285 RVA: 0x00050F43 File Offset: 0x0004F143
		public unsafe static List<ShopInterface> AllShops
		{
			get
			{
				System.IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ShopInterface.NativeFieldInfoPtr_AllShops, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ShopInterface>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShopInterface.NativeFieldInfoPtr_AllShops, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170032A5 RID: 12965
		// (get) Token: 0x0600A52E RID: 42286 RVA: 0x0029A76C File Offset: 0x0029896C
		// (set) Token: 0x0600A52F RID: 42287 RVA: 0x00050F55 File Offset: 0x0004F155
		public unsafe static int MAX_ITEM_QUANTITY
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(ShopInterface.NativeFieldInfoPtr_MAX_ITEM_QUANTITY, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShopInterface.NativeFieldInfoPtr_MAX_ITEM_QUANTITY, (void*)(&value));
			}
		}

		// Token: 0x170032A6 RID: 12966
		// (get) Token: 0x0600A530 RID: 42288 RVA: 0x0029A788 File Offset: 0x00298988
		// (set) Token: 0x0600A531 RID: 42289 RVA: 0x00050F63 File Offset: 0x0004F163
		public unsafe bool _IsOpen_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ShopInterface.NativeFieldInfoPtr__IsOpen_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ShopInterface.NativeFieldInfoPtr__IsOpen_k__BackingField)) = value;
			}
		}

		// Token: 0x170032A7 RID: 12967
		// (get) Token: 0x0600A532 RID: 42290 RVA: 0x0029A7B0 File Offset: 0x002989B0
		// (set) Token: 0x0600A533 RID: 42291 RVA: 0x00050F7E File Offset: 0x0004F17E
		public unsafe string ShopName
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ShopInterface.NativeFieldInfoPtr_ShopName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ShopInterface.NativeFieldInfoPtr_ShopName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170032A8 RID: 12968
		// (get) Token: 0x0600A534 RID: 42292 RVA: 0x0029A7D8 File Offset: 0x002989D8
		// (set) Token: 0x0600A535 RID: 42293 RVA: 0x00050F9D File Offset: 0x0004F19D
		public unsafe string ShopCode
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ShopInterface.NativeFieldInfoPtr_ShopCode);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ShopInterface.NativeFieldInfoPtr_ShopCode), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170032A9 RID: 12969
		// (get) Token: 0x0600A536 RID: 42294 RVA: 0x0029A800 File Offset: 0x00298A00
		// (set) Token: 0x0600A537 RID: 42295 RVA: 0x00050FBC File Offset: 0x0004F1BC
		public unsafe ShopInterface.EPaymentType PaymentType
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ShopInterface.NativeFieldInfoPtr_PaymentType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ShopInterface.NativeFieldInfoPtr_PaymentType)) = value;
			}
		}

		// Token: 0x170032AA RID: 12970
		// (get) Token: 0x0600A538 RID: 42296 RVA: 0x0029A828 File Offset: 0x00298A28
		// (set) Token: 0x0600A539 RID: 42297 RVA: 0x00050FD7 File Offset: 0x0004F1D7
		public unsafe bool ShowCurrencyHint
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ShopInterface.NativeFieldInfoPtr_ShowCurrencyHint);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ShopInterface.NativeFieldInfoPtr_ShowCurrencyHint)) = value;
			}
		}

		// Token: 0x170032AB RID: 12971
		// (get) Token: 0x0600A53A RID: 42298 RVA: 0x0029A850 File Offset: 0x00298A50
		// (set) Token: 0x0600A53B RID: 42299 RVA: 0x00050FF2 File Offset: 0x0004F1F2
		public unsafe List<ShopListing> Listings
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ShopInterface.NativeFieldInfoPtr_Listings);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ShopListing>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ShopInterface.NativeFieldInfoPtr_Listings), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170032AC RID: 12972
		// (get) Token: 0x0600A53C RID: 42300 RVA: 0x0029A880 File Offset: 0x00298A80
		// (set) Token: 0x0600A53D RID: 42301 RVA: 0x00051011 File Offset: 0x0004F211
		public unsafe Canvas Canvas
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ShopInterface.NativeFieldInfoPtr_Canvas);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Canvas>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ShopInterface.NativeFieldInfoPtr_Canvas), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170032AD RID: 12973
		// (get) Token: 0x0600A53E RID: 42302 RVA: 0x0029A8B0 File Offset: 0x00298AB0
		// (set) Token: 0x0600A53F RID: 42303 RVA: 0x00051030 File Offset: 0x0004F230
		public unsafe RectTransform Container
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ShopInterface.NativeFieldInfoPtr_Container);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ShopInterface.NativeFieldInfoPtr_Container), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170032AE RID: 12974
		// (get) Token: 0x0600A540 RID: 42304 RVA: 0x0029A8E0 File Offset: 0x00298AE0
		// (set) Token: 0x0600A541 RID: 42305 RVA: 0x0005104F File Offset: 0x0004F24F
		public unsafe RectTransform ListingContainer
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ShopInterface.NativeFieldInfoPtr_ListingContainer);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ShopInterface.NativeFieldInfoPtr_ListingContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170032AF RID: 12975
		// (get) Token: 0x0600A542 RID: 42306 RVA: 0x0029A910 File Offset: 0x00298B10
		// (set) Token: 0x0600A543 RID: 42307 RVA: 0x0005106E File Offset: 0x0004F26E
		public unsafe TextMeshProUGUI StoreNameLabel
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ShopInterface.NativeFieldInfoPtr_StoreNameLabel);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ShopInterface.NativeFieldInfoPtr_StoreNameLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170032B0 RID: 12976
		// (get) Token: 0x0600A544 RID: 42308 RVA: 0x0029A940 File Offset: 0x00298B40
		// (set) Token: 0x0600A545 RID: 42309 RVA: 0x0005108D File Offset: 0x0004F28D
		public unsafe Cart Cart
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ShopInterface.NativeFieldInfoPtr_Cart);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Cart>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ShopInterface.NativeFieldInfoPtr_Cart), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170032B1 RID: 12977
		// (get) Token: 0x0600A546 RID: 42310 RVA: 0x0029A970 File Offset: 0x00298B70
		// (set) Token: 0x0600A547 RID: 42311 RVA: 0x000510AC File Offset: 0x0004F2AC
		public unsafe Il2CppReferenceArray<StorageEntity> DeliveryBays
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ShopInterface.NativeFieldInfoPtr_DeliveryBays);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<StorageEntity>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ShopInterface.NativeFieldInfoPtr_DeliveryBays), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170032B2 RID: 12978
		// (get) Token: 0x0600A548 RID: 42312 RVA: 0x0029A9A0 File Offset: 0x00298BA0
		// (set) Token: 0x0600A549 RID: 42313 RVA: 0x000510CB File Offset: 0x0004F2CB
		public unsafe VehicleDetector LoadingBayDetector
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ShopInterface.NativeFieldInfoPtr_LoadingBayDetector);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<VehicleDetector>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ShopInterface.NativeFieldInfoPtr_LoadingBayDetector), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170032B3 RID: 12979
		// (get) Token: 0x0600A54A RID: 42314 RVA: 0x0029A9D0 File Offset: 0x00298BD0
		// (set) Token: 0x0600A54B RID: 42315 RVA: 0x000510EA File Offset: 0x0004F2EA
		public unsafe ShopInterfaceDetailPanel DetailPanel
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ShopInterface.NativeFieldInfoPtr_DetailPanel);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ShopInterfaceDetailPanel>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ShopInterface.NativeFieldInfoPtr_DetailPanel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170032B4 RID: 12980
		// (get) Token: 0x0600A54C RID: 42316 RVA: 0x0029AA00 File Offset: 0x00298C00
		// (set) Token: 0x0600A54D RID: 42317 RVA: 0x00051109 File Offset: 0x0004F309
		public unsafe ScrollRect ListingScrollRect
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ShopInterface.NativeFieldInfoPtr_ListingScrollRect);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ScrollRect>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ShopInterface.NativeFieldInfoPtr_ListingScrollRect), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170032B5 RID: 12981
		// (get) Token: 0x0600A54E RID: 42318 RVA: 0x0029AA30 File Offset: 0x00298C30
		// (set) Token: 0x0600A54F RID: 42319 RVA: 0x00051128 File Offset: 0x0004F328
		public unsafe ShopAmountSelector AmountSelector
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ShopInterface.NativeFieldInfoPtr_AmountSelector);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ShopAmountSelector>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ShopInterface.NativeFieldInfoPtr_AmountSelector), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170032B6 RID: 12982
		// (get) Token: 0x0600A550 RID: 42320 RVA: 0x0029AA60 File Offset: 0x00298C60
		// (set) Token: 0x0600A551 RID: 42321 RVA: 0x00051147 File Offset: 0x0004F347
		public unsafe DeliveryVehicle DeliveryVehicle
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ShopInterface.NativeFieldInfoPtr_DeliveryVehicle);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DeliveryVehicle>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ShopInterface.NativeFieldInfoPtr_DeliveryVehicle), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170032B7 RID: 12983
		// (get) Token: 0x0600A552 RID: 42322 RVA: 0x0029AA90 File Offset: 0x00298C90
		// (set) Token: 0x0600A553 RID: 42323 RVA: 0x00051166 File Offset: 0x0004F366
		public unsafe AudioSourceController AddItemSound
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ShopInterface.NativeFieldInfoPtr_AddItemSound);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ShopInterface.NativeFieldInfoPtr_AddItemSound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170032B8 RID: 12984
		// (get) Token: 0x0600A554 RID: 42324 RVA: 0x0029AAC0 File Offset: 0x00298CC0
		// (set) Token: 0x0600A555 RID: 42325 RVA: 0x00051185 File Offset: 0x0004F385
		public unsafe AudioSourceController RemoveItemSound
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ShopInterface.NativeFieldInfoPtr_RemoveItemSound);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ShopInterface.NativeFieldInfoPtr_RemoveItemSound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170032B9 RID: 12985
		// (get) Token: 0x0600A556 RID: 42326 RVA: 0x0029AAF0 File Offset: 0x00298CF0
		// (set) Token: 0x0600A557 RID: 42327 RVA: 0x000511A4 File Offset: 0x0004F3A4
		public unsafe AudioSourceController CheckoutSound
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ShopInterface.NativeFieldInfoPtr_CheckoutSound);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ShopInterface.NativeFieldInfoPtr_CheckoutSound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170032BA RID: 12986
		// (get) Token: 0x0600A558 RID: 42328 RVA: 0x0029AB20 File Offset: 0x00298D20
		// (set) Token: 0x0600A559 RID: 42329 RVA: 0x000511C3 File Offset: 0x0004F3C3
		public unsafe ListingUI ListingUIPrefab
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ShopInterface.NativeFieldInfoPtr_ListingUIPrefab);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ListingUI>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ShopInterface.NativeFieldInfoPtr_ListingUIPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170032BB RID: 12987
		// (get) Token: 0x0600A55A RID: 42330 RVA: 0x0029AB50 File Offset: 0x00298D50
		// (set) Token: 0x0600A55B RID: 42331 RVA: 0x000511E2 File Offset: 0x0004F3E2
		public unsafe UnityEvent onOrderCompleted
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ShopInterface.NativeFieldInfoPtr_onOrderCompleted);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ShopInterface.NativeFieldInfoPtr_onOrderCompleted), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170032BC RID: 12988
		// (get) Token: 0x0600A55C RID: 42332 RVA: 0x0029AB80 File Offset: 0x00298D80
		// (set) Token: 0x0600A55D RID: 42333 RVA: 0x00051201 File Offset: 0x0004F401
		public unsafe List<CategoryButton> categoryButtons
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ShopInterface.NativeFieldInfoPtr_categoryButtons);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<CategoryButton>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ShopInterface.NativeFieldInfoPtr_categoryButtons), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170032BD RID: 12989
		// (get) Token: 0x0600A55E RID: 42334 RVA: 0x0029ABB0 File Offset: 0x00298DB0
		// (set) Token: 0x0600A55F RID: 42335 RVA: 0x00051220 File Offset: 0x0004F420
		public unsafe EShopCategory categoryFilter
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ShopInterface.NativeFieldInfoPtr_categoryFilter);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ShopInterface.NativeFieldInfoPtr_categoryFilter)) = value;
			}
		}

		// Token: 0x170032BE RID: 12990
		// (get) Token: 0x0600A560 RID: 42336 RVA: 0x0029ABD8 File Offset: 0x00298DD8
		// (set) Token: 0x0600A561 RID: 42337 RVA: 0x0005123B File Offset: 0x0004F43B
		public unsafe string searchTerm
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ShopInterface.NativeFieldInfoPtr_searchTerm);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ShopInterface.NativeFieldInfoPtr_searchTerm), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170032BF RID: 12991
		// (get) Token: 0x0600A562 RID: 42338 RVA: 0x0029AC00 File Offset: 0x00298E00
		// (set) Token: 0x0600A563 RID: 42339 RVA: 0x0005125A File Offset: 0x0004F45A
		public unsafe List<ListingUI> listingUI
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ShopInterface.NativeFieldInfoPtr_listingUI);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ListingUI>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ShopInterface.NativeFieldInfoPtr_listingUI), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170032C0 RID: 12992
		// (get) Token: 0x0600A564 RID: 42340 RVA: 0x0029AC30 File Offset: 0x00298E30
		// (set) Token: 0x0600A565 RID: 42341 RVA: 0x00051279 File Offset: 0x0004F479
		public unsafe ListingUI selectedListing
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ShopInterface.NativeFieldInfoPtr_selectedListing);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ListingUI>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ShopInterface.NativeFieldInfoPtr_selectedListing), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170032C1 RID: 12993
		// (get) Token: 0x0600A566 RID: 42342 RVA: 0x0029AC60 File Offset: 0x00298E60
		// (set) Token: 0x0600A567 RID: 42343 RVA: 0x00051298 File Offset: 0x0004F498
		public unsafe bool dropdownMouseUp
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ShopInterface.NativeFieldInfoPtr_dropdownMouseUp);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ShopInterface.NativeFieldInfoPtr_dropdownMouseUp)) = value;
			}
		}

		// Token: 0x170032C2 RID: 12994
		// (get) Token: 0x0600A568 RID: 42344 RVA: 0x0029AC88 File Offset: 0x00298E88
		// (set) Token: 0x0600A569 RID: 42345 RVA: 0x000512B3 File Offset: 0x0004F4B3
		public unsafe ShopLoader loader
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ShopInterface.NativeFieldInfoPtr_loader);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ShopLoader>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ShopInterface.NativeFieldInfoPtr_loader), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170032C3 RID: 12995
		// (get) Token: 0x0600A56A RID: 42346 RVA: 0x0029ACB8 File Offset: 0x00298EB8
		// (set) Token: 0x0600A56B RID: 42347 RVA: 0x000512D2 File Offset: 0x0004F4D2
		public unsafe List<string> _LocalExtraFiles_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ShopInterface.NativeFieldInfoPtr__LocalExtraFiles_k__BackingField);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ShopInterface.NativeFieldInfoPtr__LocalExtraFiles_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170032C4 RID: 12996
		// (get) Token: 0x0600A56C RID: 42348 RVA: 0x0029ACE8 File Offset: 0x00298EE8
		// (set) Token: 0x0600A56D RID: 42349 RVA: 0x000512F1 File Offset: 0x0004F4F1
		public unsafe List<string> _LocalExtraFolders_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ShopInterface.NativeFieldInfoPtr__LocalExtraFolders_k__BackingField);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ShopInterface.NativeFieldInfoPtr__LocalExtraFolders_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170032C5 RID: 12997
		// (get) Token: 0x0600A56E RID: 42350 RVA: 0x0029AD18 File Offset: 0x00298F18
		// (set) Token: 0x0600A56F RID: 42351 RVA: 0x00051310 File Offset: 0x0004F510
		public unsafe bool _HasChanged_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ShopInterface.NativeFieldInfoPtr__HasChanged_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ShopInterface.NativeFieldInfoPtr__HasChanged_k__BackingField)) = value;
			}
		}

		// Token: 0x04006EA9 RID: 28329
		private static readonly System.IntPtr NativeFieldInfoPtr_AllShops;

		// Token: 0x04006EAA RID: 28330
		private static readonly System.IntPtr NativeFieldInfoPtr_MAX_ITEM_QUANTITY;

		// Token: 0x04006EAB RID: 28331
		private static readonly System.IntPtr NativeFieldInfoPtr__IsOpen_k__BackingField;

		// Token: 0x04006EAC RID: 28332
		private static readonly System.IntPtr NativeFieldInfoPtr_ShopName;

		// Token: 0x04006EAD RID: 28333
		private static readonly System.IntPtr NativeFieldInfoPtr_ShopCode;

		// Token: 0x04006EAE RID: 28334
		private static readonly System.IntPtr NativeFieldInfoPtr_PaymentType;

		// Token: 0x04006EAF RID: 28335
		private static readonly System.IntPtr NativeFieldInfoPtr_ShowCurrencyHint;

		// Token: 0x04006EB0 RID: 28336
		private static readonly System.IntPtr NativeFieldInfoPtr_Listings;

		// Token: 0x04006EB1 RID: 28337
		private static readonly System.IntPtr NativeFieldInfoPtr_Canvas;

		// Token: 0x04006EB2 RID: 28338
		private static readonly System.IntPtr NativeFieldInfoPtr_Container;

		// Token: 0x04006EB3 RID: 28339
		private static readonly System.IntPtr NativeFieldInfoPtr_ListingContainer;

		// Token: 0x04006EB4 RID: 28340
		private static readonly System.IntPtr NativeFieldInfoPtr_StoreNameLabel;

		// Token: 0x04006EB5 RID: 28341
		private static readonly System.IntPtr NativeFieldInfoPtr_Cart;

		// Token: 0x04006EB6 RID: 28342
		private static readonly System.IntPtr NativeFieldInfoPtr_DeliveryBays;

		// Token: 0x04006EB7 RID: 28343
		private static readonly System.IntPtr NativeFieldInfoPtr_LoadingBayDetector;

		// Token: 0x04006EB8 RID: 28344
		private static readonly System.IntPtr NativeFieldInfoPtr_DetailPanel;

		// Token: 0x04006EB9 RID: 28345
		private static readonly System.IntPtr NativeFieldInfoPtr_ListingScrollRect;

		// Token: 0x04006EBA RID: 28346
		private static readonly System.IntPtr NativeFieldInfoPtr_AmountSelector;

		// Token: 0x04006EBB RID: 28347
		private static readonly System.IntPtr NativeFieldInfoPtr_DeliveryVehicle;

		// Token: 0x04006EBC RID: 28348
		private static readonly System.IntPtr NativeFieldInfoPtr_AddItemSound;

		// Token: 0x04006EBD RID: 28349
		private static readonly System.IntPtr NativeFieldInfoPtr_RemoveItemSound;

		// Token: 0x04006EBE RID: 28350
		private static readonly System.IntPtr NativeFieldInfoPtr_CheckoutSound;

		// Token: 0x04006EBF RID: 28351
		private static readonly System.IntPtr NativeFieldInfoPtr_ListingUIPrefab;

		// Token: 0x04006EC0 RID: 28352
		private static readonly System.IntPtr NativeFieldInfoPtr_onOrderCompleted;

		// Token: 0x04006EC1 RID: 28353
		private static readonly System.IntPtr NativeFieldInfoPtr_categoryButtons;

		// Token: 0x04006EC2 RID: 28354
		private static readonly System.IntPtr NativeFieldInfoPtr_categoryFilter;

		// Token: 0x04006EC3 RID: 28355
		private static readonly System.IntPtr NativeFieldInfoPtr_searchTerm;

		// Token: 0x04006EC4 RID: 28356
		private static readonly System.IntPtr NativeFieldInfoPtr_listingUI;

		// Token: 0x04006EC5 RID: 28357
		private static readonly System.IntPtr NativeFieldInfoPtr_selectedListing;

		// Token: 0x04006EC6 RID: 28358
		private static readonly System.IntPtr NativeFieldInfoPtr_dropdownMouseUp;

		// Token: 0x04006EC7 RID: 28359
		private static readonly System.IntPtr NativeFieldInfoPtr_loader;

		// Token: 0x04006EC8 RID: 28360
		private static readonly System.IntPtr NativeFieldInfoPtr__LocalExtraFiles_k__BackingField;

		// Token: 0x04006EC9 RID: 28361
		private static readonly System.IntPtr NativeFieldInfoPtr__LocalExtraFolders_k__BackingField;

		// Token: 0x04006ECA RID: 28362
		private static readonly System.IntPtr NativeFieldInfoPtr__HasChanged_k__BackingField;

		// Token: 0x04006ECB RID: 28363
		private static readonly System.IntPtr NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0;

		// Token: 0x04006ECC RID: 28364
		private static readonly System.IntPtr NativeMethodInfoPtr_set_IsOpen_Protected_set_Void_Boolean_0;

		// Token: 0x04006ECD RID: 28365
		private static readonly System.IntPtr NativeMethodInfoPtr_get_SaveFolderName_Public_Virtual_Final_New_get_String_0;

		// Token: 0x04006ECE RID: 28366
		private static readonly System.IntPtr NativeMethodInfoPtr_get_SaveFileName_Public_Virtual_Final_New_get_String_0;

		// Token: 0x04006ECF RID: 28367
		private static readonly System.IntPtr NativeMethodInfoPtr_get_Loader_Public_Virtual_Final_New_get_Loader_0;

		// Token: 0x04006ED0 RID: 28368
		private static readonly System.IntPtr NativeMethodInfoPtr_get_ShouldSaveUnderFolder_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x04006ED1 RID: 28369
		private static readonly System.IntPtr NativeMethodInfoPtr_get_LocalExtraFiles_Public_Virtual_Final_New_get_List_1_String_0;

		// Token: 0x04006ED2 RID: 28370
		private static readonly System.IntPtr NativeMethodInfoPtr_set_LocalExtraFiles_Public_Virtual_Final_New_set_Void_List_1_String_0;

		// Token: 0x04006ED3 RID: 28371
		private static readonly System.IntPtr NativeMethodInfoPtr_get_LocalExtraFolders_Public_Virtual_Final_New_get_List_1_String_0;

		// Token: 0x04006ED4 RID: 28372
		private static readonly System.IntPtr NativeMethodInfoPtr_set_LocalExtraFolders_Public_Virtual_Final_New_set_Void_List_1_String_0;

		// Token: 0x04006ED5 RID: 28373
		private static readonly System.IntPtr NativeMethodInfoPtr_get_HasChanged_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x04006ED6 RID: 28374
		private static readonly System.IntPtr NativeMethodInfoPtr_set_HasChanged_Public_Virtual_Final_New_set_Void_Boolean_0;

		// Token: 0x04006ED7 RID: 28375
		private static readonly System.IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0;

		// Token: 0x04006ED8 RID: 28376
		private static readonly System.IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0;

		// Token: 0x04006ED9 RID: 28377
		private static readonly System.IntPtr NativeMethodInfoPtr_InitializeSaveable_Public_Virtual_New_Void_0;

		// Token: 0x04006EDA RID: 28378
		private static readonly System.IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

		// Token: 0x04006EDB RID: 28379
		private static readonly System.IntPtr NativeMethodInfoPtr_OnValidate_Private_Void_0;

		// Token: 0x04006EDC RID: 28380
		private static readonly System.IntPtr NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0;

		// Token: 0x04006EDD RID: 28381
		private static readonly System.IntPtr NativeMethodInfoPtr_OnDayPass_Protected_Void_0;

		// Token: 0x04006EDE RID: 28382
		private static readonly System.IntPtr NativeMethodInfoPtr_OnWeekPass_Protected_Void_0;

		// Token: 0x04006EDF RID: 28383
		private static readonly System.IntPtr NativeMethodInfoPtr_Open_Public_Void_0;

		// Token: 0x04006EE0 RID: 28384
		private static readonly System.IntPtr NativeMethodInfoPtr_SetIsOpen_Public_Virtual_New_Void_Boolean_0;

		// Token: 0x04006EE1 RID: 28385
		private static readonly System.IntPtr NativeMethodInfoPtr_Hint_Private_Void_0;

		// Token: 0x04006EE2 RID: 28386
		private static readonly System.IntPtr NativeMethodInfoPtr_Exit_Protected_Virtual_New_Void_ExitAction_0;

		// Token: 0x04006EE3 RID: 28387
		private static readonly System.IntPtr NativeMethodInfoPtr_CreateListingUI_Private_Void_ShopListing_0;

		// Token: 0x04006EE4 RID: 28388
		private static readonly System.IntPtr NativeMethodInfoPtr_SelectCategory_Public_Void_EShopCategory_0;

		// Token: 0x04006EE5 RID: 28389
		private static readonly System.IntPtr NativeMethodInfoPtr_ListingClicked_Public_Virtual_New_Void_ListingUI_0;

		// Token: 0x04006EE6 RID: 28390
		private static readonly System.IntPtr NativeMethodInfoPtr_ShowCartAnimation_Private_Void_ListingUI_0;

		// Token: 0x04006EE7 RID: 28391
		private static readonly System.IntPtr NativeMethodInfoPtr_CategorySelected_Public_Void_EShopCategory_0;

		// Token: 0x04006EE8 RID: 28392
		private static readonly System.IntPtr NativeMethodInfoPtr_DeselectCurrentCategory_Private_Void_0;

		// Token: 0x04006EE9 RID: 28393
		private static readonly System.IntPtr NativeMethodInfoPtr_RefreshShownItems_Private_Void_0;

		// Token: 0x04006EEA RID: 28394
		private static readonly System.IntPtr NativeMethodInfoPtr_RefreshUnlockStatus_Private_Void_0;

		// Token: 0x04006EEB RID: 28395
		private static readonly System.IntPtr NativeMethodInfoPtr_RestockAllListings_Private_Void_0;

		// Token: 0x04006EEC RID: 28396
		private static readonly System.IntPtr NativeMethodInfoPtr_CanCartFitItem_Public_Boolean_ShopListing_0;

		// Token: 0x04006EED RID: 28397
		private static readonly System.IntPtr NativeMethodInfoPtr_WillCartFit_Public_Boolean_0;

		// Token: 0x04006EEE RID: 28398
		private static readonly System.IntPtr NativeMethodInfoPtr_WillCartFit_Public_Boolean_List_1_ItemSlot_0;

		// Token: 0x04006EEF RID: 28399
		private static readonly System.IntPtr NativeMethodInfoPtr_HandoverItems_Public_Virtual_New_Boolean_0;

		// Token: 0x04006EF0 RID: 28400
		private static readonly System.IntPtr NativeMethodInfoPtr_GetAvailableSlots_Public_List_1_ItemSlot_0;

		// Token: 0x04006EF1 RID: 28401
		private static readonly System.IntPtr NativeMethodInfoPtr_GetLoadingBayVehicle_Public_LandVehicle_0;

		// Token: 0x04006EF2 RID: 28402
		private static readonly System.IntPtr NativeMethodInfoPtr_PlaceItemInDeliveryBay_Public_Void_ItemInstance_0;

		// Token: 0x04006EF3 RID: 28403
		private static readonly System.IntPtr NativeMethodInfoPtr_QuantitySelected_Public_Void_Int32_0;

		// Token: 0x04006EF4 RID: 28404
		private static readonly System.IntPtr NativeMethodInfoPtr_OpenAmountSelector_Public_Void_ListingUI_0;

		// Token: 0x04006EF5 RID: 28405
		private static readonly System.IntPtr NativeMethodInfoPtr_DropdownClicked_Private_Void_ListingUI_0;

		// Token: 0x04006EF6 RID: 28406
		private static readonly System.IntPtr NativeMethodInfoPtr_EntryHovered_Private_Void_ListingUI_0;

		// Token: 0x04006EF7 RID: 28407
		private static readonly System.IntPtr NativeMethodInfoPtr_EntryUnhovered_Private_Void_0;

		// Token: 0x04006EF8 RID: 28408
		private static readonly System.IntPtr NativeMethodInfoPtr_Load_Public_Void_ShopData_0;

		// Token: 0x04006EF9 RID: 28409
		private static readonly System.IntPtr NativeMethodInfoPtr_ShouldSave_Public_Boolean_0;

		// Token: 0x04006EFA RID: 28410
		private static readonly System.IntPtr NativeMethodInfoPtr_GetListing_Public_ShopListing_String_0;

		// Token: 0x04006EFB RID: 28411
		private static readonly System.IntPtr NativeMethodInfoPtr_GetSaveData_Public_Virtual_New_ShopData_0;

		// Token: 0x04006EFC RID: 28412
		private static readonly System.IntPtr NativeMethodInfoPtr_GetSaveString_Public_Virtual_Final_New_String_0;

		// Token: 0x04006EFD RID: 28413
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04006EFE RID: 28414
		private static readonly System.IntPtr NativeMethodInfoPtr__DeselectCurrentCategory_b__72_0_Private_Boolean_CategoryButton_0;

		// Token: 0x02000C07 RID: 3079
		[OriginalName("Assembly-CSharp.dll", "", "EPaymentType")]
		public enum EPaymentType
		{
			// Token: 0x040097D5 RID: 38869
			Cash,
			// Token: 0x040097D6 RID: 38870
			Online,
			// Token: 0x040097D7 RID: 38871
			PreferCash,
			// Token: 0x040097D8 RID: 38872
			PreferOnline
		}

		// Token: 0x02000C08 RID: 3080
		[ObfuscatedName("ScheduleOne.UI.Shop.ShopInterface+<>c")]
		[System.Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x0600E289 RID: 57993 RVA: 0x0035A5D8 File Offset: 0x003587D8
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<ShopInterface.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ShopInterface>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShopInterface.__c>.NativeClassPtr);
				ShopInterface.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopInterface.__c>.NativeClassPtr, "<>9");
				ShopInterface.__c.NativeFieldInfoPtr___9__55_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopInterface.__c>.NativeClassPtr, "<>9__55_0");
				ShopInterface.__c.NativeFieldInfoPtr___9__73_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopInterface.__c>.NativeClassPtr, "<>9__73_0");
				ShopInterface.__c.NativeFieldInfoPtr___9__73_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopInterface.__c>.NativeClassPtr, "<>9__73_1");
				ShopInterface.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopInterface.__c>.NativeClassPtr, 100683618);
				ShopInterface.__c.NativeMethodInfoPtr__Awake_b__55_0_Internal_String_ShopListing_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopInterface.__c>.NativeClassPtr, 100683619);
				ShopInterface.__c.NativeMethodInfoPtr__RefreshShownItems_b__73_0_Internal_Boolean_ListingUI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopInterface.__c>.NativeClassPtr, 100683620);
				ShopInterface.__c.NativeMethodInfoPtr__RefreshShownItems_b__73_1_Internal_Int32_ListingUI_ListingUI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopInterface.__c>.NativeClassPtr, 100683621);
			}

			// Token: 0x0600E28A RID: 57994 RVA: 0x0035A6A4 File Offset: 0x003588A4
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ShopInterface.__c>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShopInterface.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600E28B RID: 57995 RVA: 0x0035A6E0 File Offset: 0x003588E0
			[CallerCount(0)]
			public unsafe string _Awake_b__55_0(ShopListing x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				System.IntPtr returnedException;
				System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(ShopInterface.__c.NativeMethodInfoPtr__Awake_b__55_0_Internal_String_ShopListing_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return IL2CPP.Il2CppStringToManaged(il2CppString);
			}

			// Token: 0x0600E28C RID: 57996 RVA: 0x0035A728 File Offset: 0x00358928
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 289118, XrefRangeEnd = 289119, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _RefreshShownItems_b__73_0(ListingUI x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(ShopInterface.__c.NativeMethodInfoPtr__RefreshShownItems_b__73_0_Internal_Boolean_ListingUI_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x0600E28D RID: 57997 RVA: 0x0035A778 File Offset: 0x00358978
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 289119, XrefRangeEnd = 289121, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _RefreshShownItems_b__73_1(ListingUI x, ListingUI y)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(y);
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(ShopInterface.__c.NativeMethodInfoPtr__RefreshShownItems_b__73_1_Internal_Int32_ListingUI_ListingUI_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x0600E28E RID: 57998 RVA: 0x0006E14A File Offset: 0x0006C34A
			public __c(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170045E5 RID: 17893
			// (get) Token: 0x0600E28F RID: 57999 RVA: 0x0035A7D8 File Offset: 0x003589D8
			// (set) Token: 0x0600E290 RID: 58000 RVA: 0x0006E153 File Offset: 0x0006C353
			public unsafe static ShopInterface.__c __9
			{
				get
				{
					System.IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ShopInterface.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ShopInterface.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ShopInterface.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170045E6 RID: 17894
			// (get) Token: 0x0600E291 RID: 58001 RVA: 0x0035A800 File Offset: 0x00358A00
			// (set) Token: 0x0600E292 RID: 58002 RVA: 0x0006E165 File Offset: 0x0006C365
			public unsafe static Il2CppSystem.Func<ShopListing, string> __9__55_0
			{
				get
				{
					System.IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ShopInterface.__c.NativeFieldInfoPtr___9__55_0, (void*)(&intPtr));
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Func<ShopListing, string>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ShopInterface.__c.NativeFieldInfoPtr___9__55_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170045E7 RID: 17895
			// (get) Token: 0x0600E293 RID: 58003 RVA: 0x0035A828 File Offset: 0x00358A28
			// (set) Token: 0x0600E294 RID: 58004 RVA: 0x0006E177 File Offset: 0x0006C377
			public unsafe static Il2CppSystem.Predicate<ListingUI> __9__73_0
			{
				get
				{
					System.IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ShopInterface.__c.NativeFieldInfoPtr___9__73_0, (void*)(&intPtr));
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Predicate<ListingUI>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ShopInterface.__c.NativeFieldInfoPtr___9__73_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170045E8 RID: 17896
			// (get) Token: 0x0600E295 RID: 58005 RVA: 0x0035A850 File Offset: 0x00358A50
			// (set) Token: 0x0600E296 RID: 58006 RVA: 0x0006E189 File Offset: 0x0006C389
			public unsafe static Il2CppSystem.Comparison<ListingUI> __9__73_1
			{
				get
				{
					System.IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ShopInterface.__c.NativeFieldInfoPtr___9__73_1, (void*)(&intPtr));
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Comparison<ListingUI>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ShopInterface.__c.NativeFieldInfoPtr___9__73_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040097D9 RID: 38873
			private static readonly System.IntPtr NativeFieldInfoPtr___9;

			// Token: 0x040097DA RID: 38874
			private static readonly System.IntPtr NativeFieldInfoPtr___9__55_0;

			// Token: 0x040097DB RID: 38875
			private static readonly System.IntPtr NativeFieldInfoPtr___9__73_0;

			// Token: 0x040097DC RID: 38876
			private static readonly System.IntPtr NativeFieldInfoPtr___9__73_1;

			// Token: 0x040097DD RID: 38877
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040097DE RID: 38878
			private static readonly System.IntPtr NativeMethodInfoPtr__Awake_b__55_0_Internal_String_ShopListing_0;

			// Token: 0x040097DF RID: 38879
			private static readonly System.IntPtr NativeMethodInfoPtr__RefreshShownItems_b__73_0_Internal_Boolean_ListingUI_0;

			// Token: 0x040097E0 RID: 38880
			private static readonly System.IntPtr NativeMethodInfoPtr__RefreshShownItems_b__73_1_Internal_Int32_ListingUI_ListingUI_0;
		}

		// Token: 0x02000C09 RID: 3081
		[ObfuscatedName("ScheduleOne.UI.Shop.ShopInterface+<>c__DisplayClass67_0")]
		public sealed class __c__DisplayClass67_0 : Il2CppSystem.Object
		{
			// Token: 0x0600E297 RID: 58007 RVA: 0x0035A878 File Offset: 0x00358A78
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass67_0()
			{
				Il2CppClassPointerStore<ShopInterface.__c__DisplayClass67_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ShopInterface>.NativeClassPtr, "<>c__DisplayClass67_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShopInterface.__c__DisplayClass67_0>.NativeClassPtr);
				ShopInterface.__c__DisplayClass67_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopInterface.__c__DisplayClass67_0>.NativeClassPtr, "<>4__this");
				ShopInterface.__c__DisplayClass67_0.NativeFieldInfoPtr_ui = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopInterface.__c__DisplayClass67_0>.NativeClassPtr, "ui");
				ShopInterface.__c__DisplayClass67_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopInterface.__c__DisplayClass67_0>.NativeClassPtr, 100683622);
				ShopInterface.__c__DisplayClass67_0.NativeMethodInfoPtr__CreateListingUI_b__0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopInterface.__c__DisplayClass67_0>.NativeClassPtr, 100683623);
				ShopInterface.__c__DisplayClass67_0.NativeMethodInfoPtr__CreateListingUI_b__1_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopInterface.__c__DisplayClass67_0>.NativeClassPtr, 100683624);
				ShopInterface.__c__DisplayClass67_0.NativeMethodInfoPtr__CreateListingUI_b__2_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopInterface.__c__DisplayClass67_0>.NativeClassPtr, 100683625);
			}

			// Token: 0x0600E298 RID: 58008 RVA: 0x0035A91C File Offset: 0x00358B1C
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass67_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ShopInterface.__c__DisplayClass67_0>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShopInterface.__c__DisplayClass67_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600E299 RID: 58009 RVA: 0x0035A958 File Offset: 0x00358B58
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 289121, XrefRangeEnd = 289122, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _CreateListingUI_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShopInterface.__c__DisplayClass67_0.NativeMethodInfoPtr__CreateListingUI_b__0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600E29A RID: 58010 RVA: 0x0035A98C File Offset: 0x00358B8C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 289122, XrefRangeEnd = 289133, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _CreateListingUI_b__1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShopInterface.__c__DisplayClass67_0.NativeMethodInfoPtr__CreateListingUI_b__1_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600E29B RID: 58011 RVA: 0x0035A9C0 File Offset: 0x00358BC0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 289133, XrefRangeEnd = 289135, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _CreateListingUI_b__2()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShopInterface.__c__DisplayClass67_0.NativeMethodInfoPtr__CreateListingUI_b__2_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600E29C RID: 58012 RVA: 0x0006E19B File Offset: 0x0006C39B
			public __c__DisplayClass67_0(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170045E9 RID: 17897
			// (get) Token: 0x0600E29D RID: 58013 RVA: 0x0035A9F4 File Offset: 0x00358BF4
			// (set) Token: 0x0600E29E RID: 58014 RVA: 0x0006E1A4 File Offset: 0x0006C3A4
			public unsafe ShopInterface __4__this
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ShopInterface.__c__DisplayClass67_0.NativeFieldInfoPtr___4__this);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ShopInterface>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ShopInterface.__c__DisplayClass67_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170045EA RID: 17898
			// (get) Token: 0x0600E29F RID: 58015 RVA: 0x0035AA24 File Offset: 0x00358C24
			// (set) Token: 0x0600E2A0 RID: 58016 RVA: 0x0006E1C3 File Offset: 0x0006C3C3
			public unsafe ListingUI ui
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ShopInterface.__c__DisplayClass67_0.NativeFieldInfoPtr_ui);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ListingUI>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ShopInterface.__c__DisplayClass67_0.NativeFieldInfoPtr_ui), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040097E1 RID: 38881
			private static readonly System.IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040097E2 RID: 38882
			private static readonly System.IntPtr NativeFieldInfoPtr_ui;

			// Token: 0x040097E3 RID: 38883
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040097E4 RID: 38884
			private static readonly System.IntPtr NativeMethodInfoPtr__CreateListingUI_b__0_Internal_Void_0;

			// Token: 0x040097E5 RID: 38885
			private static readonly System.IntPtr NativeMethodInfoPtr__CreateListingUI_b__1_Internal_Void_0;

			// Token: 0x040097E6 RID: 38886
			private static readonly System.IntPtr NativeMethodInfoPtr__CreateListingUI_b__2_Internal_Void_0;
		}

		// Token: 0x02000C0A RID: 3082
		[ObfuscatedName("ScheduleOne.UI.Shop.ShopInterface+<>c__DisplayClass68_0")]
		public sealed class __c__DisplayClass68_0 : Il2CppSystem.Object
		{
			// Token: 0x0600E2A1 RID: 58017 RVA: 0x0035AA54 File Offset: 0x00358C54
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass68_0()
			{
				Il2CppClassPointerStore<ShopInterface.__c__DisplayClass68_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ShopInterface>.NativeClassPtr, "<>c__DisplayClass68_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShopInterface.__c__DisplayClass68_0>.NativeClassPtr);
				ShopInterface.__c__DisplayClass68_0.NativeFieldInfoPtr_category = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopInterface.__c__DisplayClass68_0>.NativeClassPtr, "category");
				ShopInterface.__c__DisplayClass68_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopInterface.__c__DisplayClass68_0>.NativeClassPtr, 100683626);
				ShopInterface.__c__DisplayClass68_0.NativeMethodInfoPtr__SelectCategory_b__0_Internal_Boolean_CategoryButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopInterface.__c__DisplayClass68_0>.NativeClassPtr, 100683627);
			}

			// Token: 0x0600E2A2 RID: 58018 RVA: 0x0035AABC File Offset: 0x00358CBC
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass68_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ShopInterface.__c__DisplayClass68_0>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShopInterface.__c__DisplayClass68_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600E2A3 RID: 58019 RVA: 0x0035AAF8 File Offset: 0x00358CF8
			[CallerCount(0)]
			public unsafe bool _SelectCategory_b__0(CategoryButton x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(ShopInterface.__c__DisplayClass68_0.NativeMethodInfoPtr__SelectCategory_b__0_Internal_Boolean_CategoryButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x0600E2A4 RID: 58020 RVA: 0x0006E1E2 File Offset: 0x0006C3E2
			public __c__DisplayClass68_0(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170045EB RID: 17899
			// (get) Token: 0x0600E2A5 RID: 58021 RVA: 0x0035AB48 File Offset: 0x00358D48
			// (set) Token: 0x0600E2A6 RID: 58022 RVA: 0x0006E1EB File Offset: 0x0006C3EB
			public unsafe EShopCategory category
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ShopInterface.__c__DisplayClass68_0.NativeFieldInfoPtr_category);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ShopInterface.__c__DisplayClass68_0.NativeFieldInfoPtr_category)) = value;
				}
			}

			// Token: 0x040097E7 RID: 38887
			private static readonly System.IntPtr NativeFieldInfoPtr_category;

			// Token: 0x040097E8 RID: 38888
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040097E9 RID: 38889
			private static readonly System.IntPtr NativeMethodInfoPtr__SelectCategory_b__0_Internal_Boolean_CategoryButton_0;
		}

		// Token: 0x02000C0B RID: 3083
		[ObfuscatedName("ScheduleOne.UI.Shop.ShopInterface+<>c__DisplayClass70_0")]
		public sealed class __c__DisplayClass70_0 : Il2CppSystem.Object
		{
			// Token: 0x0600E2A7 RID: 58023 RVA: 0x0035AB70 File Offset: 0x00358D70
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass70_0()
			{
				Il2CppClassPointerStore<ShopInterface.__c__DisplayClass70_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ShopInterface>.NativeClassPtr, "<>c__DisplayClass70_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShopInterface.__c__DisplayClass70_0>.NativeClassPtr);
				ShopInterface.__c__DisplayClass70_0.NativeFieldInfoPtr_listing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopInterface.__c__DisplayClass70_0>.NativeClassPtr, "listing");
				ShopInterface.__c__DisplayClass70_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopInterface.__c__DisplayClass70_0>.NativeClassPtr, "<>4__this");
				ShopInterface.__c__DisplayClass70_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopInterface.__c__DisplayClass70_0>.NativeClassPtr, 100683628);
				ShopInterface.__c__DisplayClass70_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopInterface.__c__DisplayClass70_0>.NativeClassPtr, 100683629);
			}

			// Token: 0x0600E2A8 RID: 58024 RVA: 0x0035ABEC File Offset: 0x00358DEC
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass70_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ShopInterface.__c__DisplayClass70_0>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShopInterface.__c__DisplayClass70_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600E2A9 RID: 58025 RVA: 0x0035AC28 File Offset: 0x00358E28
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 289171, XrefRangeEnd = 289176, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator Method_Internal_IEnumerator_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShopInterface.__c__DisplayClass70_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr2) : null;
			}

			// Token: 0x0600E2AA RID: 58026 RVA: 0x0006E206 File Offset: 0x0006C406
			public __c__DisplayClass70_0(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170045EC RID: 17900
			// (get) Token: 0x0600E2AB RID: 58027 RVA: 0x0035AC68 File Offset: 0x00358E68
			// (set) Token: 0x0600E2AC RID: 58028 RVA: 0x0006E20F File Offset: 0x0006C40F
			public unsafe ListingUI listing
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ShopInterface.__c__DisplayClass70_0.NativeFieldInfoPtr_listing);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ListingUI>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ShopInterface.__c__DisplayClass70_0.NativeFieldInfoPtr_listing), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170045ED RID: 17901
			// (get) Token: 0x0600E2AD RID: 58029 RVA: 0x0035AC98 File Offset: 0x00358E98
			// (set) Token: 0x0600E2AE RID: 58030 RVA: 0x0006E22E File Offset: 0x0006C42E
			public unsafe ShopInterface __4__this
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ShopInterface.__c__DisplayClass70_0.NativeFieldInfoPtr___4__this);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ShopInterface>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ShopInterface.__c__DisplayClass70_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040097EA RID: 38890
			private static readonly System.IntPtr NativeFieldInfoPtr_listing;

			// Token: 0x040097EB RID: 38891
			private static readonly System.IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040097EC RID: 38892
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040097ED RID: 38893
			private static readonly System.IntPtr NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0;

			// Token: 0x02000CE0 RID: 3296
			[ObfuscatedName("ScheduleOne.UI.Shop.ShopInterface+<>c__DisplayClass70_0+<<ShowCartAnimation>g__Routine|0>d")]
			public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReVeSiVeSiObVeObUnique : Il2CppSystem.Object
			{
				// Token: 0x0600EC54 RID: 60500 RVA: 0x00376AE8 File Offset: 0x00374CE8
				// Note: this type is marked as 'beforefieldinit'.
				static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReVeSiVeSiObVeObUnique()
				{
					Il2CppClassPointerStore<ShopInterface.__c__DisplayClass70_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReVeSiVeSiObVeObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ShopInterface.__c__DisplayClass70_0>.NativeClassPtr, "<<ShowCartAnimation>g__Routine|0>d");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShopInterface.__c__DisplayClass70_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReVeSiVeSiObVeObUnique>.NativeClassPtr);
					ShopInterface.__c__DisplayClass70_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReVeSiVeSiObVeObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopInterface.__c__DisplayClass70_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReVeSiVeSiObVeObUnique>.NativeClassPtr, "<>1__state");
					ShopInterface.__c__DisplayClass70_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReVeSiVeSiObVeObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopInterface.__c__DisplayClass70_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReVeSiVeSiObVeObUnique>.NativeClassPtr, "<>2__current");
					ShopInterface.__c__DisplayClass70_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReVeSiVeSiObVeObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopInterface.__c__DisplayClass70_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReVeSiVeSiObVeObUnique>.NativeClassPtr, "<>4__this");
					ShopInterface.__c__DisplayClass70_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReVeSiVeSiObVeObUnique.NativeFieldInfoPtr__iconRect_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopInterface.__c__DisplayClass70_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReVeSiVeSiObVeObUnique>.NativeClassPtr, "<iconRect>5__2");
					ShopInterface.__c__DisplayClass70_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReVeSiVeSiObVeObUnique.NativeFieldInfoPtr__startPos_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopInterface.__c__DisplayClass70_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReVeSiVeSiObVeObUnique>.NativeClassPtr, "<startPos>5__3");
					ShopInterface.__c__DisplayClass70_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReVeSiVeSiObVeObUnique.NativeFieldInfoPtr__endPos_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopInterface.__c__DisplayClass70_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReVeSiVeSiObVeObUnique>.NativeClassPtr, "<endPos>5__4");
					ShopInterface.__c__DisplayClass70_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReVeSiVeSiObVeObUnique.NativeFieldInfoPtr__startScale_5__5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopInterface.__c__DisplayClass70_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReVeSiVeSiObVeObUnique>.NativeClassPtr, "<startScale>5__5");
					ShopInterface.__c__DisplayClass70_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReVeSiVeSiObVeObUnique.NativeFieldInfoPtr__endScale_5__6 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopInterface.__c__DisplayClass70_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReVeSiVeSiObVeObUnique>.NativeClassPtr, "<endScale>5__6");
					ShopInterface.__c__DisplayClass70_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReVeSiVeSiObVeObUnique.NativeFieldInfoPtr__lerpTime_5__7 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopInterface.__c__DisplayClass70_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReVeSiVeSiObVeObUnique>.NativeClassPtr, "<lerpTime>5__7");
					ShopInterface.__c__DisplayClass70_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReVeSiVeSiObVeObUnique.NativeFieldInfoPtr__i_5__8 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopInterface.__c__DisplayClass70_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReVeSiVeSiObVeObUnique>.NativeClassPtr, "<i>5__8");
					ShopInterface.__c__DisplayClass70_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReVeSiVeSiObVeObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopInterface.__c__DisplayClass70_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReVeSiVeSiObVeObUnique>.NativeClassPtr, 100683630);
					ShopInterface.__c__DisplayClass70_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReVeSiVeSiObVeObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopInterface.__c__DisplayClass70_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReVeSiVeSiObVeObUnique>.NativeClassPtr, 100683631);
					ShopInterface.__c__DisplayClass70_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReVeSiVeSiObVeObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopInterface.__c__DisplayClass70_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReVeSiVeSiObVeObUnique>.NativeClassPtr, 100683632);
					ShopInterface.__c__DisplayClass70_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReVeSiVeSiObVeObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopInterface.__c__DisplayClass70_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReVeSiVeSiObVeObUnique>.NativeClassPtr, 100683633);
					ShopInterface.__c__DisplayClass70_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReVeSiVeSiObVeObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopInterface.__c__DisplayClass70_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReVeSiVeSiObVeObUnique>.NativeClassPtr, 100683634);
					ShopInterface.__c__DisplayClass70_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReVeSiVeSiObVeObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopInterface.__c__DisplayClass70_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReVeSiVeSiObVeObUnique>.NativeClassPtr, 100683635);
				}

				// Token: 0x0600EC55 RID: 60501 RVA: 0x00376C54 File Offset: 0x00374E54
				[CallerCount(54)]
				[CachedScanResults(RefRangeStart = 2646, RefRangeEnd = 2700, XrefRangeStart = 2646, XrefRangeEnd = 2700, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReVeSiVeSiObVeObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ShopInterface.__c__DisplayClass70_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReVeSiVeSiObVeObUnique>.NativeClassPtr))
				{
					System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
					*ptr = ref <>1__state;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShopInterface.__c__DisplayClass70_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReVeSiVeSiObVeObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				}

				// Token: 0x0600EC56 RID: 60502 RVA: 0x00376C9C File Offset: 0x00374E9C
				[CallerCount(14558)]
				[CachedScanResults(RefRangeStart = 2769, RefRangeEnd = 17327, XrefRangeStart = 2769, XrefRangeEnd = 17327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShopInterface.__c__DisplayClass70_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReVeSiVeSiObVeObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				}

				// Token: 0x0600EC57 RID: 60503 RVA: 0x00376CD0 File Offset: 0x00374ED0
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 289135, XrefRangeEnd = 289166, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(ShopInterface.__c__DisplayClass70_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReVeSiVeSiObVeObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
					return *IL2CPP.il2cpp_object_unbox(obj);
				}

				// Token: 0x1700494E RID: 18766
				// (get) Token: 0x0600EC58 RID: 60504 RVA: 0x00376D0C File Offset: 0x00374F0C
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(24)]
					[CachedScanResults(RefRangeStart = 2740, RefRangeEnd = 2764, XrefRangeStart = 2740, XrefRangeEnd = 2764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						System.IntPtr* param = null;
						System.IntPtr returnedException;
						System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShopInterface.__c__DisplayClass70_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReVeSiVeSiObVeObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
						Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
						System.IntPtr intPtr2 = intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
				}

				// Token: 0x0600EC59 RID: 60505 RVA: 0x00376D4C File Offset: 0x00374F4C
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 289166, XrefRangeEnd = 289171, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShopInterface.__c__DisplayClass70_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReVeSiVeSiObVeObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				}

				// Token: 0x1700494F RID: 18767
				// (get) Token: 0x0600EC5A RID: 60506 RVA: 0x00376D80 File Offset: 0x00374F80
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(24)]
					[CachedScanResults(RefRangeStart = 2740, RefRangeEnd = 2764, XrefRangeStart = 2740, XrefRangeEnd = 2764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						System.IntPtr* param = null;
						System.IntPtr returnedException;
						System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShopInterface.__c__DisplayClass70_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReVeSiVeSiObVeObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
						Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
						System.IntPtr intPtr2 = intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
				}

				// Token: 0x0600EC5B RID: 60507 RVA: 0x000730C2 File Offset: 0x000712C2
				public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReVeSiVeSiObVeObUnique(System.IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x17004944 RID: 18756
				// (get) Token: 0x0600EC5C RID: 60508 RVA: 0x00376DC0 File Offset: 0x00374FC0
				// (set) Token: 0x0600EC5D RID: 60509 RVA: 0x000730CB File Offset: 0x000712CB
				public unsafe int __1__state
				{
					get
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ShopInterface.__c__DisplayClass70_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReVeSiVeSiObVeObUnique.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ShopInterface.__c__DisplayClass70_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReVeSiVeSiObVeObUnique.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x17004945 RID: 18757
				// (get) Token: 0x0600EC5E RID: 60510 RVA: 0x00376DE8 File Offset: 0x00374FE8
				// (set) Token: 0x0600EC5F RID: 60511 RVA: 0x000730E6 File Offset: 0x000712E6
				public unsafe Il2CppSystem.Object __2__current
				{
					get
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ShopInterface.__c__DisplayClass70_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReVeSiVeSiObVeObUnique.NativeFieldInfoPtr___2__current);
						System.IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
					set
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ShopInterface.__c__DisplayClass70_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReVeSiVeSiObVeObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17004946 RID: 18758
				// (get) Token: 0x0600EC60 RID: 60512 RVA: 0x00376E18 File Offset: 0x00375018
				// (set) Token: 0x0600EC61 RID: 60513 RVA: 0x00073105 File Offset: 0x00071305
				public unsafe ShopInterface.__c__DisplayClass70_0 __4__this
				{
					get
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ShopInterface.__c__DisplayClass70_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReVeSiVeSiObVeObUnique.NativeFieldInfoPtr___4__this);
						System.IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<ShopInterface.__c__DisplayClass70_0>(intPtr2) : null;
					}
					set
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ShopInterface.__c__DisplayClass70_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReVeSiVeSiObVeObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17004947 RID: 18759
				// (get) Token: 0x0600EC62 RID: 60514 RVA: 0x00376E48 File Offset: 0x00375048
				// (set) Token: 0x0600EC63 RID: 60515 RVA: 0x00073124 File Offset: 0x00071324
				public unsafe RectTransform _iconRect_5__2
				{
					get
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ShopInterface.__c__DisplayClass70_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReVeSiVeSiObVeObUnique.NativeFieldInfoPtr__iconRect_5__2);
						System.IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
					}
					set
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ShopInterface.__c__DisplayClass70_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReVeSiVeSiObVeObUnique.NativeFieldInfoPtr__iconRect_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17004948 RID: 18760
				// (get) Token: 0x0600EC64 RID: 60516 RVA: 0x00376E78 File Offset: 0x00375078
				// (set) Token: 0x0600EC65 RID: 60517 RVA: 0x00073143 File Offset: 0x00071343
				public unsafe Vector3 _startPos_5__3
				{
					get
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ShopInterface.__c__DisplayClass70_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReVeSiVeSiObVeObUnique.NativeFieldInfoPtr__startPos_5__3);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ShopInterface.__c__DisplayClass70_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReVeSiVeSiObVeObUnique.NativeFieldInfoPtr__startPos_5__3)) = value;
					}
				}

				// Token: 0x17004949 RID: 18761
				// (get) Token: 0x0600EC66 RID: 60518 RVA: 0x00376EA0 File Offset: 0x003750A0
				// (set) Token: 0x0600EC67 RID: 60519 RVA: 0x0007315E File Offset: 0x0007135E
				public unsafe Vector2 _endPos_5__4
				{
					get
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ShopInterface.__c__DisplayClass70_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReVeSiVeSiObVeObUnique.NativeFieldInfoPtr__endPos_5__4);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ShopInterface.__c__DisplayClass70_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReVeSiVeSiObVeObUnique.NativeFieldInfoPtr__endPos_5__4)) = value;
					}
				}

				// Token: 0x1700494A RID: 18762
				// (get) Token: 0x0600EC68 RID: 60520 RVA: 0x00376EC8 File Offset: 0x003750C8
				// (set) Token: 0x0600EC69 RID: 60521 RVA: 0x00073179 File Offset: 0x00071379
				public unsafe Vector3 _startScale_5__5
				{
					get
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ShopInterface.__c__DisplayClass70_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReVeSiVeSiObVeObUnique.NativeFieldInfoPtr__startScale_5__5);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ShopInterface.__c__DisplayClass70_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReVeSiVeSiObVeObUnique.NativeFieldInfoPtr__startScale_5__5)) = value;
					}
				}

				// Token: 0x1700494B RID: 18763
				// (get) Token: 0x0600EC6A RID: 60522 RVA: 0x00376EF0 File Offset: 0x003750F0
				// (set) Token: 0x0600EC6B RID: 60523 RVA: 0x00073194 File Offset: 0x00071394
				public unsafe Vector3 _endScale_5__6
				{
					get
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ShopInterface.__c__DisplayClass70_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReVeSiVeSiObVeObUnique.NativeFieldInfoPtr__endScale_5__6);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ShopInterface.__c__DisplayClass70_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReVeSiVeSiObVeObUnique.NativeFieldInfoPtr__endScale_5__6)) = value;
					}
				}

				// Token: 0x1700494C RID: 18764
				// (get) Token: 0x0600EC6C RID: 60524 RVA: 0x00376F18 File Offset: 0x00375118
				// (set) Token: 0x0600EC6D RID: 60525 RVA: 0x000731AF File Offset: 0x000713AF
				public unsafe float _lerpTime_5__7
				{
					get
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ShopInterface.__c__DisplayClass70_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReVeSiVeSiObVeObUnique.NativeFieldInfoPtr__lerpTime_5__7);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ShopInterface.__c__DisplayClass70_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReVeSiVeSiObVeObUnique.NativeFieldInfoPtr__lerpTime_5__7)) = value;
					}
				}

				// Token: 0x1700494D RID: 18765
				// (get) Token: 0x0600EC6E RID: 60526 RVA: 0x00376F40 File Offset: 0x00375140
				// (set) Token: 0x0600EC6F RID: 60527 RVA: 0x000731CA File Offset: 0x000713CA
				public unsafe float _i_5__8
				{
					get
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ShopInterface.__c__DisplayClass70_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReVeSiVeSiObVeObUnique.NativeFieldInfoPtr__i_5__8);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ShopInterface.__c__DisplayClass70_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReVeSiVeSiObVeObUnique.NativeFieldInfoPtr__i_5__8)) = value;
					}
				}

				// Token: 0x04009DFC RID: 40444
				private static readonly System.IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x04009DFD RID: 40445
				private static readonly System.IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x04009DFE RID: 40446
				private static readonly System.IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x04009DFF RID: 40447
				private static readonly System.IntPtr NativeFieldInfoPtr__iconRect_5__2;

				// Token: 0x04009E00 RID: 40448
				private static readonly System.IntPtr NativeFieldInfoPtr__startPos_5__3;

				// Token: 0x04009E01 RID: 40449
				private static readonly System.IntPtr NativeFieldInfoPtr__endPos_5__4;

				// Token: 0x04009E02 RID: 40450
				private static readonly System.IntPtr NativeFieldInfoPtr__startScale_5__5;

				// Token: 0x04009E03 RID: 40451
				private static readonly System.IntPtr NativeFieldInfoPtr__endScale_5__6;

				// Token: 0x04009E04 RID: 40452
				private static readonly System.IntPtr NativeFieldInfoPtr__lerpTime_5__7;

				// Token: 0x04009E05 RID: 40453
				private static readonly System.IntPtr NativeFieldInfoPtr__i_5__8;

				// Token: 0x04009E06 RID: 40454
				private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x04009E07 RID: 40455
				private static readonly System.IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x04009E08 RID: 40456
				private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x04009E09 RID: 40457
				private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x04009E0A RID: 40458
				private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x04009E0B RID: 40459
				private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
			}
		}

		// Token: 0x02000C0C RID: 3084
		[ObfuscatedName("ScheduleOne.UI.Shop.ShopInterface+<>c__DisplayClass88_0")]
		public sealed class __c__DisplayClass88_0 : Il2CppSystem.Object
		{
			// Token: 0x0600E2AF RID: 58031 RVA: 0x0035ACC8 File Offset: 0x00358EC8
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass88_0()
			{
				Il2CppClassPointerStore<ShopInterface.__c__DisplayClass88_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ShopInterface>.NativeClassPtr, "<>c__DisplayClass88_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShopInterface.__c__DisplayClass88_0>.NativeClassPtr);
				ShopInterface.__c__DisplayClass88_0.NativeFieldInfoPtr_stockQuantity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopInterface.__c__DisplayClass88_0>.NativeClassPtr, "stockQuantity");
				ShopInterface.__c__DisplayClass88_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopInterface.__c__DisplayClass88_0>.NativeClassPtr, 100683636);
				ShopInterface.__c__DisplayClass88_0.NativeMethodInfoPtr__Load_b__0_Internal_Boolean_ShopListing_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopInterface.__c__DisplayClass88_0>.NativeClassPtr, 100683637);
			}

			// Token: 0x0600E2B0 RID: 58032 RVA: 0x0035AD30 File Offset: 0x00358F30
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass88_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ShopInterface.__c__DisplayClass88_0>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShopInterface.__c__DisplayClass88_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600E2B1 RID: 58033 RVA: 0x0035AD6C File Offset: 0x00358F6C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 289176, XrefRangeEnd = 289178, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _Load_b__0(ShopListing x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(ShopInterface.__c__DisplayClass88_0.NativeMethodInfoPtr__Load_b__0_Internal_Boolean_ShopListing_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x0600E2B2 RID: 58034 RVA: 0x0006E24D File Offset: 0x0006C44D
			public __c__DisplayClass88_0(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170045EE RID: 17902
			// (get) Token: 0x0600E2B3 RID: 58035 RVA: 0x0035ADBC File Offset: 0x00358FBC
			// (set) Token: 0x0600E2B4 RID: 58036 RVA: 0x0006E256 File Offset: 0x0006C456
			public unsafe StringIntPair stockQuantity
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ShopInterface.__c__DisplayClass88_0.NativeFieldInfoPtr_stockQuantity);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<StringIntPair>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ShopInterface.__c__DisplayClass88_0.NativeFieldInfoPtr_stockQuantity), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040097EE RID: 38894
			private static readonly System.IntPtr NativeFieldInfoPtr_stockQuantity;

			// Token: 0x040097EF RID: 38895
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040097F0 RID: 38896
			private static readonly System.IntPtr NativeMethodInfoPtr__Load_b__0_Internal_Boolean_ShopListing_0;
		}

		// Token: 0x02000C0D RID: 3085
		[ObfuscatedName("ScheduleOne.UI.Shop.ShopInterface+<>c__DisplayClass90_0")]
		public sealed class __c__DisplayClass90_0 : Il2CppSystem.Object
		{
			// Token: 0x0600E2B5 RID: 58037 RVA: 0x0035ADEC File Offset: 0x00358FEC
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass90_0()
			{
				Il2CppClassPointerStore<ShopInterface.__c__DisplayClass90_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ShopInterface>.NativeClassPtr, "<>c__DisplayClass90_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShopInterface.__c__DisplayClass90_0>.NativeClassPtr);
				ShopInterface.__c__DisplayClass90_0.NativeFieldInfoPtr_itemID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopInterface.__c__DisplayClass90_0>.NativeClassPtr, "itemID");
				ShopInterface.__c__DisplayClass90_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopInterface.__c__DisplayClass90_0>.NativeClassPtr, 100683638);
				ShopInterface.__c__DisplayClass90_0.NativeMethodInfoPtr__GetListing_b__0_Internal_Boolean_ShopListing_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopInterface.__c__DisplayClass90_0>.NativeClassPtr, 100683639);
			}

			// Token: 0x0600E2B6 RID: 58038 RVA: 0x0035AE54 File Offset: 0x00359054
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass90_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ShopInterface.__c__DisplayClass90_0>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShopInterface.__c__DisplayClass90_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600E2B7 RID: 58039 RVA: 0x0035AE90 File Offset: 0x00359090
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 289178, XrefRangeEnd = 289194, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GetListing_b__0(ShopListing x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(ShopInterface.__c__DisplayClass90_0.NativeMethodInfoPtr__GetListing_b__0_Internal_Boolean_ShopListing_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x0600E2B8 RID: 58040 RVA: 0x0006E275 File Offset: 0x0006C475
			public __c__DisplayClass90_0(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170045EF RID: 17903
			// (get) Token: 0x0600E2B9 RID: 58041 RVA: 0x0035AEE0 File Offset: 0x003590E0
			// (set) Token: 0x0600E2BA RID: 58042 RVA: 0x0006E27E File Offset: 0x0006C47E
			public unsafe string itemID
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ShopInterface.__c__DisplayClass90_0.NativeFieldInfoPtr_itemID);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ShopInterface.__c__DisplayClass90_0.NativeFieldInfoPtr_itemID), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x040097F1 RID: 38897
			private static readonly System.IntPtr NativeFieldInfoPtr_itemID;

			// Token: 0x040097F2 RID: 38898
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040097F3 RID: 38899
			private static readonly System.IntPtr NativeMethodInfoPtr__GetListing_b__0_Internal_Boolean_ShopListing_0;
		}
	}
}
