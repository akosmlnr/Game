using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using Il2CppScheduleOne.ItemFramework;
using Il2CppScheduleOne.Messaging;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI.Phone
{
	// Token: 0x020006C4 RID: 1732
	public class PhoneShopInterface : MonoBehaviour
	{
		// Token: 0x060099A7 RID: 39335 RVA: 0x00276CA4 File Offset: 0x00274EA4
		// Note: this type is marked as 'beforefieldinit'.
		static PhoneShopInterface()
		{
			Il2CppClassPointerStore<PhoneShopInterface>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Phone", "PhoneShopInterface");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PhoneShopInterface>.NativeClassPtr);
			PhoneShopInterface.NativeFieldInfoPtr__IsOpen_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PhoneShopInterface>.NativeClassPtr, "<IsOpen>k__BackingField");
			PhoneShopInterface.NativeFieldInfoPtr_EntryPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PhoneShopInterface>.NativeClassPtr, "EntryPrefab");
			PhoneShopInterface.NativeFieldInfoPtr_ValidAmountColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PhoneShopInterface>.NativeClassPtr, "ValidAmountColor");
			PhoneShopInterface.NativeFieldInfoPtr_InvalidAmountColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PhoneShopInterface>.NativeClassPtr, "InvalidAmountColor");
			PhoneShopInterface.NativeFieldInfoPtr_Container = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PhoneShopInterface>.NativeClassPtr, "Container");
			PhoneShopInterface.NativeFieldInfoPtr_TitleLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PhoneShopInterface>.NativeClassPtr, "TitleLabel");
			PhoneShopInterface.NativeFieldInfoPtr_SubtitleLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PhoneShopInterface>.NativeClassPtr, "SubtitleLabel");
			PhoneShopInterface.NativeFieldInfoPtr_EntryContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PhoneShopInterface>.NativeClassPtr, "EntryContainer");
			PhoneShopInterface.NativeFieldInfoPtr_OrderTotalLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PhoneShopInterface>.NativeClassPtr, "OrderTotalLabel");
			PhoneShopInterface.NativeFieldInfoPtr_OrderLimitLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PhoneShopInterface>.NativeClassPtr, "OrderLimitLabel");
			PhoneShopInterface.NativeFieldInfoPtr_DebtLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PhoneShopInterface>.NativeClassPtr, "DebtLabel");
			PhoneShopInterface.NativeFieldInfoPtr_ConfirmButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PhoneShopInterface>.NativeClassPtr, "ConfirmButton");
			PhoneShopInterface.NativeFieldInfoPtr_ItemLimitContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PhoneShopInterface>.NativeClassPtr, "ItemLimitContainer");
			PhoneShopInterface.NativeFieldInfoPtr_ItemLimitLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PhoneShopInterface>.NativeClassPtr, "ItemLimitLabel");
			PhoneShopInterface.NativeFieldInfoPtr__entries = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PhoneShopInterface>.NativeClassPtr, "_entries");
			PhoneShopInterface.NativeFieldInfoPtr__items = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PhoneShopInterface>.NativeClassPtr, "_items");
			PhoneShopInterface.NativeFieldInfoPtr__cart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PhoneShopInterface>.NativeClassPtr, "_cart");
			PhoneShopInterface.NativeFieldInfoPtr_orderLimit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PhoneShopInterface>.NativeClassPtr, "orderLimit");
			PhoneShopInterface.NativeFieldInfoPtr_orderConfirmedCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PhoneShopInterface>.NativeClassPtr, "orderConfirmedCallback");
			PhoneShopInterface.NativeFieldInfoPtr_conversation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PhoneShopInterface>.NativeClassPtr, "conversation");
			PhoneShopInterface.NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhoneShopInterface>.NativeClassPtr, 100682363);
			PhoneShopInterface.NativeMethodInfoPtr_set_IsOpen_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhoneShopInterface>.NativeClassPtr, 100682364);
			PhoneShopInterface.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhoneShopInterface>.NativeClassPtr, 100682365);
			PhoneShopInterface.NativeMethodInfoPtr_Open_Public_Void_String_String_MSGConversation_List_1_Listing_Single_Single_Action_2_List_1_CartEntry_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhoneShopInterface>.NativeClassPtr, 100682366);
			PhoneShopInterface.NativeMethodInfoPtr_Close_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhoneShopInterface>.NativeClassPtr, 100682367);
			PhoneShopInterface.NativeMethodInfoPtr_Exit_Public_Void_ExitAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhoneShopInterface>.NativeClassPtr, 100682368);
			PhoneShopInterface.NativeMethodInfoPtr_ChangeListingQuantity_Private_Void_Listing_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhoneShopInterface>.NativeClassPtr, 100682369);
			PhoneShopInterface.NativeMethodInfoPtr_CartChanged_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhoneShopInterface>.NativeClassPtr, 100682370);
			PhoneShopInterface.NativeMethodInfoPtr_ConfirmOrderPressed_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhoneShopInterface>.NativeClassPtr, 100682371);
			PhoneShopInterface.NativeMethodInfoPtr_CanConfirmOrder_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhoneShopInterface>.NativeClassPtr, 100682372);
			PhoneShopInterface.NativeMethodInfoPtr_UpdateOrderTotal_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhoneShopInterface>.NativeClassPtr, 100682373);
			PhoneShopInterface.NativeMethodInfoPtr_GetOrderTotal_Private_Single_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhoneShopInterface>.NativeClassPtr, 100682374);
			PhoneShopInterface.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhoneShopInterface>.NativeClassPtr, 100682375);
		}

		// Token: 0x17002EFF RID: 12031
		// (get) Token: 0x060099A8 RID: 39336 RVA: 0x00276F68 File Offset: 0x00275168
		// (set) Token: 0x060099A9 RID: 39337 RVA: 0x00276FA4 File Offset: 0x002751A4
		public unsafe bool IsOpen
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 37513, RefRangeEnd = 37514, XrefRangeStart = 37513, XrefRangeEnd = 37514, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(PhoneShopInterface.NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
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
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PhoneShopInterface.NativeMethodInfoPtr_set_IsOpen_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x060099AA RID: 39338 RVA: 0x00276FE4 File Offset: 0x002751E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 275001, XrefRangeEnd = 275022, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PhoneShopInterface.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060099AB RID: 39339 RVA: 0x00277018 File Offset: 0x00275218
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 275150, RefRangeEnd = 275151, XrefRangeStart = 275022, XrefRangeEnd = 275150, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Open(string title, string subtitle, MSGConversation _conversation, List<PhoneShopInterface.Listing> listings, float _orderLimit, float debt, Il2CppSystem.Action<List<PhoneShopInterface.CartEntry>, float> _orderConfirmedCallback)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)7) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(title);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(subtitle);
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(_conversation);
			ptr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(listings);
			ptr[checked(unchecked((System.UIntPtr)4) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref _orderLimit;
			ptr[checked(unchecked((System.UIntPtr)5) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref debt;
			ptr[checked(unchecked((System.UIntPtr)6) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(_orderConfirmedCallback);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PhoneShopInterface.NativeMethodInfoPtr_Open_Public_Void_String_String_MSGConversation_List_1_Listing_Single_Single_Action_2_List_1_CartEntry_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060099AC RID: 39340 RVA: 0x002770C0 File Offset: 0x002752C0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 275189, RefRangeEnd = 275192, XrefRangeStart = 275151, XrefRangeEnd = 275189, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Close()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PhoneShopInterface.NativeMethodInfoPtr_Close_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060099AD RID: 39341 RVA: 0x002770F4 File Offset: 0x002752F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 275192, XrefRangeEnd = 275194, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Exit(ExitAction action)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(action);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PhoneShopInterface.NativeMethodInfoPtr_Exit_Public_Void_ExitAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060099AE RID: 39342 RVA: 0x00277138 File Offset: 0x00275338
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 275235, RefRangeEnd = 275237, XrefRangeStart = 275194, XrefRangeEnd = 275235, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ChangeListingQuantity(PhoneShopInterface.Listing listing, int change)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(listing);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref change;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PhoneShopInterface.NativeMethodInfoPtr_ChangeListingQuantity_Private_Void_Listing_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060099AF RID: 39343 RVA: 0x00277188 File Offset: 0x00275388
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 275251, RefRangeEnd = 275253, XrefRangeStart = 275237, XrefRangeEnd = 275251, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CartChanged()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PhoneShopInterface.NativeMethodInfoPtr_CartChanged_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060099B0 RID: 39344 RVA: 0x002771BC File Offset: 0x002753BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 275253, XrefRangeEnd = 275256, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ConfirmOrderPressed()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PhoneShopInterface.NativeMethodInfoPtr_ConfirmOrderPressed_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060099B1 RID: 39345 RVA: 0x002771F0 File Offset: 0x002753F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 275256, XrefRangeEnd = 275257, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool CanConfirmOrder()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(PhoneShopInterface.NativeMethodInfoPtr_CanConfirmOrder_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x060099B2 RID: 39346 RVA: 0x0027722C File Offset: 0x0027542C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 275257, XrefRangeEnd = 275266, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateOrderTotal()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PhoneShopInterface.NativeMethodInfoPtr_UpdateOrderTotal_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060099B3 RID: 39347 RVA: 0x00277260 File Offset: 0x00275460
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 275280, RefRangeEnd = 275285, XrefRangeStart = 275266, XrefRangeEnd = 275280, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float GetOrderTotal(out int itemCount)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = &itemCount;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(PhoneShopInterface.NativeMethodInfoPtr_GetOrderTotal_Private_Single_byref_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x060099B4 RID: 39348 RVA: 0x002772AC File Offset: 0x002754AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 275285, XrefRangeEnd = 275307, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PhoneShopInterface() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PhoneShopInterface>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PhoneShopInterface.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060099B5 RID: 39349 RVA: 0x0004A6F3 File Offset: 0x000488F3
		public PhoneShopInterface(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002EEB RID: 12011
		// (get) Token: 0x060099B6 RID: 39350 RVA: 0x002772E8 File Offset: 0x002754E8
		// (set) Token: 0x060099B7 RID: 39351 RVA: 0x0004A6FC File Offset: 0x000488FC
		public unsafe bool _IsOpen_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PhoneShopInterface.NativeFieldInfoPtr__IsOpen_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PhoneShopInterface.NativeFieldInfoPtr__IsOpen_k__BackingField)) = value;
			}
		}

		// Token: 0x17002EEC RID: 12012
		// (get) Token: 0x060099B8 RID: 39352 RVA: 0x00277310 File Offset: 0x00275510
		// (set) Token: 0x060099B9 RID: 39353 RVA: 0x0004A717 File Offset: 0x00048917
		public unsafe RectTransform EntryPrefab
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PhoneShopInterface.NativeFieldInfoPtr_EntryPrefab);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PhoneShopInterface.NativeFieldInfoPtr_EntryPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002EED RID: 12013
		// (get) Token: 0x060099BA RID: 39354 RVA: 0x00277340 File Offset: 0x00275540
		// (set) Token: 0x060099BB RID: 39355 RVA: 0x0004A736 File Offset: 0x00048936
		public unsafe Color ValidAmountColor
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PhoneShopInterface.NativeFieldInfoPtr_ValidAmountColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PhoneShopInterface.NativeFieldInfoPtr_ValidAmountColor)) = value;
			}
		}

		// Token: 0x17002EEE RID: 12014
		// (get) Token: 0x060099BC RID: 39356 RVA: 0x00277368 File Offset: 0x00275568
		// (set) Token: 0x060099BD RID: 39357 RVA: 0x0004A751 File Offset: 0x00048951
		public unsafe Color InvalidAmountColor
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PhoneShopInterface.NativeFieldInfoPtr_InvalidAmountColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PhoneShopInterface.NativeFieldInfoPtr_InvalidAmountColor)) = value;
			}
		}

		// Token: 0x17002EEF RID: 12015
		// (get) Token: 0x060099BE RID: 39358 RVA: 0x00277390 File Offset: 0x00275590
		// (set) Token: 0x060099BF RID: 39359 RVA: 0x0004A76C File Offset: 0x0004896C
		public unsafe GameObject Container
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PhoneShopInterface.NativeFieldInfoPtr_Container);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PhoneShopInterface.NativeFieldInfoPtr_Container), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002EF0 RID: 12016
		// (get) Token: 0x060099C0 RID: 39360 RVA: 0x002773C0 File Offset: 0x002755C0
		// (set) Token: 0x060099C1 RID: 39361 RVA: 0x0004A78B File Offset: 0x0004898B
		public unsafe Text TitleLabel
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PhoneShopInterface.NativeFieldInfoPtr_TitleLabel);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PhoneShopInterface.NativeFieldInfoPtr_TitleLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002EF1 RID: 12017
		// (get) Token: 0x060099C2 RID: 39362 RVA: 0x002773F0 File Offset: 0x002755F0
		// (set) Token: 0x060099C3 RID: 39363 RVA: 0x0004A7AA File Offset: 0x000489AA
		public unsafe Text SubtitleLabel
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PhoneShopInterface.NativeFieldInfoPtr_SubtitleLabel);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PhoneShopInterface.NativeFieldInfoPtr_SubtitleLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002EF2 RID: 12018
		// (get) Token: 0x060099C4 RID: 39364 RVA: 0x00277420 File Offset: 0x00275620
		// (set) Token: 0x060099C5 RID: 39365 RVA: 0x0004A7C9 File Offset: 0x000489C9
		public unsafe RectTransform EntryContainer
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PhoneShopInterface.NativeFieldInfoPtr_EntryContainer);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PhoneShopInterface.NativeFieldInfoPtr_EntryContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002EF3 RID: 12019
		// (get) Token: 0x060099C6 RID: 39366 RVA: 0x00277450 File Offset: 0x00275650
		// (set) Token: 0x060099C7 RID: 39367 RVA: 0x0004A7E8 File Offset: 0x000489E8
		public unsafe Text OrderTotalLabel
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PhoneShopInterface.NativeFieldInfoPtr_OrderTotalLabel);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PhoneShopInterface.NativeFieldInfoPtr_OrderTotalLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002EF4 RID: 12020
		// (get) Token: 0x060099C8 RID: 39368 RVA: 0x00277480 File Offset: 0x00275680
		// (set) Token: 0x060099C9 RID: 39369 RVA: 0x0004A807 File Offset: 0x00048A07
		public unsafe Text OrderLimitLabel
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PhoneShopInterface.NativeFieldInfoPtr_OrderLimitLabel);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PhoneShopInterface.NativeFieldInfoPtr_OrderLimitLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002EF5 RID: 12021
		// (get) Token: 0x060099CA RID: 39370 RVA: 0x002774B0 File Offset: 0x002756B0
		// (set) Token: 0x060099CB RID: 39371 RVA: 0x0004A826 File Offset: 0x00048A26
		public unsafe Text DebtLabel
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PhoneShopInterface.NativeFieldInfoPtr_DebtLabel);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PhoneShopInterface.NativeFieldInfoPtr_DebtLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002EF6 RID: 12022
		// (get) Token: 0x060099CC RID: 39372 RVA: 0x002774E0 File Offset: 0x002756E0
		// (set) Token: 0x060099CD RID: 39373 RVA: 0x0004A845 File Offset: 0x00048A45
		public unsafe Button ConfirmButton
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PhoneShopInterface.NativeFieldInfoPtr_ConfirmButton);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PhoneShopInterface.NativeFieldInfoPtr_ConfirmButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002EF7 RID: 12023
		// (get) Token: 0x060099CE RID: 39374 RVA: 0x00277510 File Offset: 0x00275710
		// (set) Token: 0x060099CF RID: 39375 RVA: 0x0004A864 File Offset: 0x00048A64
		public unsafe GameObject ItemLimitContainer
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PhoneShopInterface.NativeFieldInfoPtr_ItemLimitContainer);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PhoneShopInterface.NativeFieldInfoPtr_ItemLimitContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002EF8 RID: 12024
		// (get) Token: 0x060099D0 RID: 39376 RVA: 0x00277540 File Offset: 0x00275740
		// (set) Token: 0x060099D1 RID: 39377 RVA: 0x0004A883 File Offset: 0x00048A83
		public unsafe Text ItemLimitLabel
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PhoneShopInterface.NativeFieldInfoPtr_ItemLimitLabel);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PhoneShopInterface.NativeFieldInfoPtr_ItemLimitLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002EF9 RID: 12025
		// (get) Token: 0x060099D2 RID: 39378 RVA: 0x00277570 File Offset: 0x00275770
		// (set) Token: 0x060099D3 RID: 39379 RVA: 0x0004A8A2 File Offset: 0x00048AA2
		public unsafe List<RectTransform> _entries
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PhoneShopInterface.NativeFieldInfoPtr__entries);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<RectTransform>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PhoneShopInterface.NativeFieldInfoPtr__entries), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002EFA RID: 12026
		// (get) Token: 0x060099D4 RID: 39380 RVA: 0x002775A0 File Offset: 0x002757A0
		// (set) Token: 0x060099D5 RID: 39381 RVA: 0x0004A8C1 File Offset: 0x00048AC1
		public unsafe List<PhoneShopInterface.Listing> _items
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PhoneShopInterface.NativeFieldInfoPtr__items);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<PhoneShopInterface.Listing>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PhoneShopInterface.NativeFieldInfoPtr__items), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002EFB RID: 12027
		// (get) Token: 0x060099D6 RID: 39382 RVA: 0x002775D0 File Offset: 0x002757D0
		// (set) Token: 0x060099D7 RID: 39383 RVA: 0x0004A8E0 File Offset: 0x00048AE0
		public unsafe List<PhoneShopInterface.CartEntry> _cart
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PhoneShopInterface.NativeFieldInfoPtr__cart);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<PhoneShopInterface.CartEntry>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PhoneShopInterface.NativeFieldInfoPtr__cart), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002EFC RID: 12028
		// (get) Token: 0x060099D8 RID: 39384 RVA: 0x00277600 File Offset: 0x00275800
		// (set) Token: 0x060099D9 RID: 39385 RVA: 0x0004A8FF File Offset: 0x00048AFF
		public unsafe float orderLimit
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PhoneShopInterface.NativeFieldInfoPtr_orderLimit);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PhoneShopInterface.NativeFieldInfoPtr_orderLimit)) = value;
			}
		}

		// Token: 0x17002EFD RID: 12029
		// (get) Token: 0x060099DA RID: 39386 RVA: 0x00277628 File Offset: 0x00275828
		// (set) Token: 0x060099DB RID: 39387 RVA: 0x0004A91A File Offset: 0x00048B1A
		public unsafe Il2CppSystem.Action<List<PhoneShopInterface.CartEntry>, float> orderConfirmedCallback
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PhoneShopInterface.NativeFieldInfoPtr_orderConfirmedCallback);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Action<List<PhoneShopInterface.CartEntry>, float>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PhoneShopInterface.NativeFieldInfoPtr_orderConfirmedCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002EFE RID: 12030
		// (get) Token: 0x060099DC RID: 39388 RVA: 0x00277658 File Offset: 0x00275858
		// (set) Token: 0x060099DD RID: 39389 RVA: 0x0004A939 File Offset: 0x00048B39
		public unsafe MSGConversation conversation
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PhoneShopInterface.NativeFieldInfoPtr_conversation);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MSGConversation>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PhoneShopInterface.NativeFieldInfoPtr_conversation), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400678F RID: 26511
		private static readonly System.IntPtr NativeFieldInfoPtr__IsOpen_k__BackingField;

		// Token: 0x04006790 RID: 26512
		private static readonly System.IntPtr NativeFieldInfoPtr_EntryPrefab;

		// Token: 0x04006791 RID: 26513
		private static readonly System.IntPtr NativeFieldInfoPtr_ValidAmountColor;

		// Token: 0x04006792 RID: 26514
		private static readonly System.IntPtr NativeFieldInfoPtr_InvalidAmountColor;

		// Token: 0x04006793 RID: 26515
		private static readonly System.IntPtr NativeFieldInfoPtr_Container;

		// Token: 0x04006794 RID: 26516
		private static readonly System.IntPtr NativeFieldInfoPtr_TitleLabel;

		// Token: 0x04006795 RID: 26517
		private static readonly System.IntPtr NativeFieldInfoPtr_SubtitleLabel;

		// Token: 0x04006796 RID: 26518
		private static readonly System.IntPtr NativeFieldInfoPtr_EntryContainer;

		// Token: 0x04006797 RID: 26519
		private static readonly System.IntPtr NativeFieldInfoPtr_OrderTotalLabel;

		// Token: 0x04006798 RID: 26520
		private static readonly System.IntPtr NativeFieldInfoPtr_OrderLimitLabel;

		// Token: 0x04006799 RID: 26521
		private static readonly System.IntPtr NativeFieldInfoPtr_DebtLabel;

		// Token: 0x0400679A RID: 26522
		private static readonly System.IntPtr NativeFieldInfoPtr_ConfirmButton;

		// Token: 0x0400679B RID: 26523
		private static readonly System.IntPtr NativeFieldInfoPtr_ItemLimitContainer;

		// Token: 0x0400679C RID: 26524
		private static readonly System.IntPtr NativeFieldInfoPtr_ItemLimitLabel;

		// Token: 0x0400679D RID: 26525
		private static readonly System.IntPtr NativeFieldInfoPtr__entries;

		// Token: 0x0400679E RID: 26526
		private static readonly System.IntPtr NativeFieldInfoPtr__items;

		// Token: 0x0400679F RID: 26527
		private static readonly System.IntPtr NativeFieldInfoPtr__cart;

		// Token: 0x040067A0 RID: 26528
		private static readonly System.IntPtr NativeFieldInfoPtr_orderLimit;

		// Token: 0x040067A1 RID: 26529
		private static readonly System.IntPtr NativeFieldInfoPtr_orderConfirmedCallback;

		// Token: 0x040067A2 RID: 26530
		private static readonly System.IntPtr NativeFieldInfoPtr_conversation;

		// Token: 0x040067A3 RID: 26531
		private static readonly System.IntPtr NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0;

		// Token: 0x040067A4 RID: 26532
		private static readonly System.IntPtr NativeMethodInfoPtr_set_IsOpen_Private_set_Void_Boolean_0;

		// Token: 0x040067A5 RID: 26533
		private static readonly System.IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x040067A6 RID: 26534
		private static readonly System.IntPtr NativeMethodInfoPtr_Open_Public_Void_String_String_MSGConversation_List_1_Listing_Single_Single_Action_2_List_1_CartEntry_Single_0;

		// Token: 0x040067A7 RID: 26535
		private static readonly System.IntPtr NativeMethodInfoPtr_Close_Public_Void_0;

		// Token: 0x040067A8 RID: 26536
		private static readonly System.IntPtr NativeMethodInfoPtr_Exit_Public_Void_ExitAction_0;

		// Token: 0x040067A9 RID: 26537
		private static readonly System.IntPtr NativeMethodInfoPtr_ChangeListingQuantity_Private_Void_Listing_Int32_0;

		// Token: 0x040067AA RID: 26538
		private static readonly System.IntPtr NativeMethodInfoPtr_CartChanged_Private_Void_0;

		// Token: 0x040067AB RID: 26539
		private static readonly System.IntPtr NativeMethodInfoPtr_ConfirmOrderPressed_Private_Void_0;

		// Token: 0x040067AC RID: 26540
		private static readonly System.IntPtr NativeMethodInfoPtr_CanConfirmOrder_Private_Boolean_0;

		// Token: 0x040067AD RID: 26541
		private static readonly System.IntPtr NativeMethodInfoPtr_UpdateOrderTotal_Private_Void_0;

		// Token: 0x040067AE RID: 26542
		private static readonly System.IntPtr NativeMethodInfoPtr_GetOrderTotal_Private_Single_byref_Int32_0;

		// Token: 0x040067AF RID: 26543
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000BB4 RID: 2996
		[System.Serializable]
		public class Listing : Il2CppSystem.Object
		{
			// Token: 0x0600DFA4 RID: 57252 RVA: 0x00352564 File Offset: 0x00350764
			// Note: this type is marked as 'beforefieldinit'.
			static Listing()
			{
				Il2CppClassPointerStore<PhoneShopInterface.Listing>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PhoneShopInterface>.NativeClassPtr, "Listing");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PhoneShopInterface.Listing>.NativeClassPtr);
				PhoneShopInterface.Listing.NativeFieldInfoPtr_Item = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PhoneShopInterface.Listing>.NativeClassPtr, "Item");
				PhoneShopInterface.Listing.NativeFieldInfoPtr_Price = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PhoneShopInterface.Listing>.NativeClassPtr, "Price");
				PhoneShopInterface.Listing.NativeMethodInfoPtr__ctor_Public_Void_ItemDefinition_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhoneShopInterface.Listing>.NativeClassPtr, 100682376);
			}

			// Token: 0x0600DFA5 RID: 57253 RVA: 0x003525CC File Offset: 0x003507CC
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 72740, RefRangeEnd = 72741, XrefRangeStart = 72740, XrefRangeEnd = 72741, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Listing(ItemDefinition item, float price) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PhoneShopInterface.Listing>.NativeClassPtr))
			{
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
				ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref price;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PhoneShopInterface.Listing.NativeMethodInfoPtr__ctor_Public_Void_ItemDefinition_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600DFA6 RID: 57254 RVA: 0x0006C913 File Offset: 0x0006AB13
			public Listing(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700450D RID: 17677
			// (get) Token: 0x0600DFA7 RID: 57255 RVA: 0x00352628 File Offset: 0x00350828
			// (set) Token: 0x0600DFA8 RID: 57256 RVA: 0x0006C91C File Offset: 0x0006AB1C
			public unsafe ItemDefinition Item
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PhoneShopInterface.Listing.NativeFieldInfoPtr_Item);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemDefinition>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PhoneShopInterface.Listing.NativeFieldInfoPtr_Item), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700450E RID: 17678
			// (get) Token: 0x0600DFA9 RID: 57257 RVA: 0x00352658 File Offset: 0x00350858
			// (set) Token: 0x0600DFAA RID: 57258 RVA: 0x0006C93B File Offset: 0x0006AB3B
			public unsafe float Price
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PhoneShopInterface.Listing.NativeFieldInfoPtr_Price);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PhoneShopInterface.Listing.NativeFieldInfoPtr_Price)) = value;
				}
			}

			// Token: 0x04009632 RID: 38450
			private static readonly System.IntPtr NativeFieldInfoPtr_Item;

			// Token: 0x04009633 RID: 38451
			private static readonly System.IntPtr NativeFieldInfoPtr_Price;

			// Token: 0x04009634 RID: 38452
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_ItemDefinition_Single_0;
		}

		// Token: 0x02000BB5 RID: 2997
		[System.Serializable]
		public class CartEntry : Il2CppSystem.Object
		{
			// Token: 0x0600DFAB RID: 57259 RVA: 0x00352680 File Offset: 0x00350880
			// Note: this type is marked as 'beforefieldinit'.
			static CartEntry()
			{
				Il2CppClassPointerStore<PhoneShopInterface.CartEntry>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PhoneShopInterface>.NativeClassPtr, "CartEntry");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PhoneShopInterface.CartEntry>.NativeClassPtr);
				PhoneShopInterface.CartEntry.NativeFieldInfoPtr_Listing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PhoneShopInterface.CartEntry>.NativeClassPtr, "Listing");
				PhoneShopInterface.CartEntry.NativeFieldInfoPtr_Quantity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PhoneShopInterface.CartEntry>.NativeClassPtr, "Quantity");
				PhoneShopInterface.CartEntry.NativeMethodInfoPtr__ctor_Public_Void_Listing_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhoneShopInterface.CartEntry>.NativeClassPtr, 100682377);
			}

			// Token: 0x0600DFAC RID: 57260 RVA: 0x003526E8 File Offset: 0x003508E8
			[CallerCount(9)]
			[CachedScanResults(RefRangeStart = 110827, RefRangeEnd = 110836, XrefRangeStart = 110827, XrefRangeEnd = 110836, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe CartEntry(PhoneShopInterface.Listing listing, int quantity) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PhoneShopInterface.CartEntry>.NativeClassPtr))
			{
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(listing);
				ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref quantity;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PhoneShopInterface.CartEntry.NativeMethodInfoPtr__ctor_Public_Void_Listing_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600DFAD RID: 57261 RVA: 0x0006C956 File Offset: 0x0006AB56
			public CartEntry(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700450F RID: 17679
			// (get) Token: 0x0600DFAE RID: 57262 RVA: 0x00352744 File Offset: 0x00350944
			// (set) Token: 0x0600DFAF RID: 57263 RVA: 0x0006C95F File Offset: 0x0006AB5F
			public unsafe PhoneShopInterface.Listing Listing
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PhoneShopInterface.CartEntry.NativeFieldInfoPtr_Listing);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PhoneShopInterface.Listing>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PhoneShopInterface.CartEntry.NativeFieldInfoPtr_Listing), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004510 RID: 17680
			// (get) Token: 0x0600DFB0 RID: 57264 RVA: 0x00352774 File Offset: 0x00350974
			// (set) Token: 0x0600DFB1 RID: 57265 RVA: 0x0006C97E File Offset: 0x0006AB7E
			public unsafe int Quantity
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PhoneShopInterface.CartEntry.NativeFieldInfoPtr_Quantity);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PhoneShopInterface.CartEntry.NativeFieldInfoPtr_Quantity)) = value;
				}
			}

			// Token: 0x04009635 RID: 38453
			private static readonly System.IntPtr NativeFieldInfoPtr_Listing;

			// Token: 0x04009636 RID: 38454
			private static readonly System.IntPtr NativeFieldInfoPtr_Quantity;

			// Token: 0x04009637 RID: 38455
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Listing_Int32_0;
		}

		// Token: 0x02000BB6 RID: 2998
		[ObfuscatedName("ScheduleOne.UI.Phone.PhoneShopInterface+<>c__DisplayClass26_0")]
		public sealed class __c__DisplayClass26_0 : Il2CppSystem.Object
		{
			// Token: 0x0600DFB2 RID: 57266 RVA: 0x0035279C File Offset: 0x0035099C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass26_0()
			{
				Il2CppClassPointerStore<PhoneShopInterface.__c__DisplayClass26_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PhoneShopInterface>.NativeClassPtr, "<>c__DisplayClass26_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PhoneShopInterface.__c__DisplayClass26_0>.NativeClassPtr);
				PhoneShopInterface.__c__DisplayClass26_0.NativeFieldInfoPtr_entry = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PhoneShopInterface.__c__DisplayClass26_0>.NativeClassPtr, "entry");
				PhoneShopInterface.__c__DisplayClass26_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PhoneShopInterface.__c__DisplayClass26_0>.NativeClassPtr, "<>4__this");
				PhoneShopInterface.__c__DisplayClass26_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhoneShopInterface.__c__DisplayClass26_0>.NativeClassPtr, 100682378);
				PhoneShopInterface.__c__DisplayClass26_0.NativeMethodInfoPtr__Open_b__0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhoneShopInterface.__c__DisplayClass26_0>.NativeClassPtr, 100682379);
				PhoneShopInterface.__c__DisplayClass26_0.NativeMethodInfoPtr__Open_b__1_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhoneShopInterface.__c__DisplayClass26_0>.NativeClassPtr, 100682380);
			}

			// Token: 0x0600DFB3 RID: 57267 RVA: 0x0035282C File Offset: 0x00350A2C
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass26_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PhoneShopInterface.__c__DisplayClass26_0>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PhoneShopInterface.__c__DisplayClass26_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600DFB4 RID: 57268 RVA: 0x00352868 File Offset: 0x00350A68
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 274995, XrefRangeEnd = 274997, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _Open_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PhoneShopInterface.__c__DisplayClass26_0.NativeMethodInfoPtr__Open_b__0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600DFB5 RID: 57269 RVA: 0x0035289C File Offset: 0x00350A9C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 274997, XrefRangeEnd = 274999, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _Open_b__1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PhoneShopInterface.__c__DisplayClass26_0.NativeMethodInfoPtr__Open_b__1_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600DFB6 RID: 57270 RVA: 0x0006C999 File Offset: 0x0006AB99
			public __c__DisplayClass26_0(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004511 RID: 17681
			// (get) Token: 0x0600DFB7 RID: 57271 RVA: 0x003528D0 File Offset: 0x00350AD0
			// (set) Token: 0x0600DFB8 RID: 57272 RVA: 0x0006C9A2 File Offset: 0x0006ABA2
			public unsafe PhoneShopInterface.Listing entry
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PhoneShopInterface.__c__DisplayClass26_0.NativeFieldInfoPtr_entry);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PhoneShopInterface.Listing>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PhoneShopInterface.__c__DisplayClass26_0.NativeFieldInfoPtr_entry), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004512 RID: 17682
			// (get) Token: 0x0600DFB9 RID: 57273 RVA: 0x00352900 File Offset: 0x00350B00
			// (set) Token: 0x0600DFBA RID: 57274 RVA: 0x0006C9C1 File Offset: 0x0006ABC1
			public unsafe PhoneShopInterface __4__this
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PhoneShopInterface.__c__DisplayClass26_0.NativeFieldInfoPtr___4__this);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PhoneShopInterface>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PhoneShopInterface.__c__DisplayClass26_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009638 RID: 38456
			private static readonly System.IntPtr NativeFieldInfoPtr_entry;

			// Token: 0x04009639 RID: 38457
			private static readonly System.IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400963A RID: 38458
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400963B RID: 38459
			private static readonly System.IntPtr NativeMethodInfoPtr__Open_b__0_Internal_Void_0;

			// Token: 0x0400963C RID: 38460
			private static readonly System.IntPtr NativeMethodInfoPtr__Open_b__1_Internal_Void_0;
		}

		// Token: 0x02000BB7 RID: 2999
		[ObfuscatedName("ScheduleOne.UI.Phone.PhoneShopInterface+<>c__DisplayClass29_0")]
		public sealed class __c__DisplayClass29_0 : Il2CppSystem.Object
		{
			// Token: 0x0600DFBB RID: 57275 RVA: 0x00352930 File Offset: 0x00350B30
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass29_0()
			{
				Il2CppClassPointerStore<PhoneShopInterface.__c__DisplayClass29_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PhoneShopInterface>.NativeClassPtr, "<>c__DisplayClass29_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PhoneShopInterface.__c__DisplayClass29_0>.NativeClassPtr);
				PhoneShopInterface.__c__DisplayClass29_0.NativeFieldInfoPtr_listing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PhoneShopInterface.__c__DisplayClass29_0>.NativeClassPtr, "listing");
				PhoneShopInterface.__c__DisplayClass29_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhoneShopInterface.__c__DisplayClass29_0>.NativeClassPtr, 100682381);
				PhoneShopInterface.__c__DisplayClass29_0.NativeMethodInfoPtr__ChangeListingQuantity_b__0_Internal_Boolean_CartEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhoneShopInterface.__c__DisplayClass29_0>.NativeClassPtr, 100682382);
			}

			// Token: 0x0600DFBC RID: 57276 RVA: 0x00352998 File Offset: 0x00350B98
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass29_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PhoneShopInterface.__c__DisplayClass29_0>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PhoneShopInterface.__c__DisplayClass29_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600DFBD RID: 57277 RVA: 0x003529D4 File Offset: 0x00350BD4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 274999, XrefRangeEnd = 275001, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _ChangeListingQuantity_b__0(PhoneShopInterface.CartEntry e)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(PhoneShopInterface.__c__DisplayClass29_0.NativeMethodInfoPtr__ChangeListingQuantity_b__0_Internal_Boolean_CartEntry_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x0600DFBE RID: 57278 RVA: 0x0006C9E0 File Offset: 0x0006ABE0
			public __c__DisplayClass29_0(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004513 RID: 17683
			// (get) Token: 0x0600DFBF RID: 57279 RVA: 0x00352A24 File Offset: 0x00350C24
			// (set) Token: 0x0600DFC0 RID: 57280 RVA: 0x0006C9E9 File Offset: 0x0006ABE9
			public unsafe PhoneShopInterface.Listing listing
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PhoneShopInterface.__c__DisplayClass29_0.NativeFieldInfoPtr_listing);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PhoneShopInterface.Listing>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PhoneShopInterface.__c__DisplayClass29_0.NativeFieldInfoPtr_listing), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400963D RID: 38461
			private static readonly System.IntPtr NativeFieldInfoPtr_listing;

			// Token: 0x0400963E RID: 38462
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400963F RID: 38463
			private static readonly System.IntPtr NativeMethodInfoPtr__ChangeListingQuantity_b__0_Internal_Boolean_CartEntry_0;
		}
	}
}
