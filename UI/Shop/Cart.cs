using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using Il2CppTMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI.Shop
{
	// Token: 0x0200072D RID: 1837
	public class Cart : MonoBehaviour
	{
		// Token: 0x0600A411 RID: 42001 RVA: 0x00296550 File Offset: 0x00294750
		// Note: this type is marked as 'beforefieldinit'.
		static Cart()
		{
			Il2CppClassPointerStore<Cart>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Shop", "Cart");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Cart>.NativeClassPtr);
			Cart.NativeFieldInfoPtr_Shop = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cart>.NativeClassPtr, "Shop");
			Cart.NativeFieldInfoPtr_CartIcon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cart>.NativeClassPtr, "CartIcon");
			Cart.NativeFieldInfoPtr_ViewCartText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cart>.NativeClassPtr, "ViewCartText");
			Cart.NativeFieldInfoPtr_CartEntryContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cart>.NativeClassPtr, "CartEntryContainer");
			Cart.NativeFieldInfoPtr_ProblemText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cart>.NativeClassPtr, "ProblemText");
			Cart.NativeFieldInfoPtr_WarningText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cart>.NativeClassPtr, "WarningText");
			Cart.NativeFieldInfoPtr_BuyButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cart>.NativeClassPtr, "BuyButton");
			Cart.NativeFieldInfoPtr_CartContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cart>.NativeClassPtr, "CartContainer");
			Cart.NativeFieldInfoPtr_CartArea = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cart>.NativeClassPtr, "CartArea");
			Cart.NativeFieldInfoPtr_TotalText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cart>.NativeClassPtr, "TotalText");
			Cart.NativeFieldInfoPtr_LoadVehicleToggle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cart>.NativeClassPtr, "LoadVehicleToggle");
			Cart.NativeFieldInfoPtr_EntryPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cart>.NativeClassPtr, "EntryPrefab");
			Cart.NativeFieldInfoPtr_cartDictionary = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cart>.NativeClassPtr, "cartDictionary");
			Cart.NativeFieldInfoPtr_cartIconBop = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cart>.NativeClassPtr, "cartIconBop");
			Cart.NativeFieldInfoPtr_cartEntries = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cart>.NativeClassPtr, "cartEntries");
			Cart.NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cart>.NativeClassPtr, 100683461);
			Cart.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cart>.NativeClassPtr, 100683462);
			Cart.NativeMethodInfoPtr_AddItem_Public_Void_ShopListing_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cart>.NativeClassPtr, 100683463);
			Cart.NativeMethodInfoPtr_RemoveItem_Public_Void_ShopListing_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cart>.NativeClassPtr, 100683464);
			Cart.NativeMethodInfoPtr_ClearCart_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cart>.NativeClassPtr, 100683465);
			Cart.NativeMethodInfoPtr_GetCartCount_Public_Int32_ShopListing_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cart>.NativeClassPtr, 100683466);
			Cart.NativeMethodInfoPtr_BopCartIcon_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cart>.NativeClassPtr, 100683467);
			Cart.NativeMethodInfoPtr_CanPlayerAffordCart_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cart>.NativeClassPtr, 100683468);
			Cart.NativeMethodInfoPtr_Buy_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cart>.NativeClassPtr, 100683469);
			Cart.NativeMethodInfoPtr_UpdateEntries_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cart>.NativeClassPtr, 100683470);
			Cart.NativeMethodInfoPtr_UpdateTotal_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cart>.NativeClassPtr, 100683471);
			Cart.NativeMethodInfoPtr_UpdateProblem_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cart>.NativeClassPtr, 100683472);
			Cart.NativeMethodInfoPtr_CanCheckout_Private_Boolean_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cart>.NativeClassPtr, 100683473);
			Cart.NativeMethodInfoPtr_GetWarning_Private_Boolean_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cart>.NativeClassPtr, 100683474);
			Cart.NativeMethodInfoPtr_UpdateViewCartText_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cart>.NativeClassPtr, 100683475);
			Cart.NativeMethodInfoPtr_UpdateLoadVehicleToggle_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cart>.NativeClassPtr, 100683476);
			Cart.NativeMethodInfoPtr_GetItemSum_Private_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cart>.NativeClassPtr, 100683477);
			Cart.NativeMethodInfoPtr_GetPriceSum_Private_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cart>.NativeClassPtr, 100683478);
			Cart.NativeMethodInfoPtr_GetEntry_Private_CartEntry_ShopListing_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cart>.NativeClassPtr, 100683479);
			Cart.NativeMethodInfoPtr_IsMouseOverMenuArea_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cart>.NativeClassPtr, 100683480);
			Cart.NativeMethodInfoPtr_GetTotalSlotRequirement_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cart>.NativeClassPtr, 100683481);
			Cart.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cart>.NativeClassPtr, 100683482);
			Cart.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cart>.NativeClassPtr, 100683483);
		}

		// Token: 0x0600A412 RID: 42002 RVA: 0x00296878 File Offset: 0x00294A78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 288166, XrefRangeEnd = 288175, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Cart.NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A413 RID: 42003 RVA: 0x002968B4 File Offset: 0x00294AB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 288175, XrefRangeEnd = 288185, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Cart.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A414 RID: 42004 RVA: 0x002968F0 File Offset: 0x00294AF0
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 288222, RefRangeEnd = 288226, XrefRangeStart = 288185, XrefRangeEnd = 288222, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddItem(ShopListing listing, int quantity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(listing);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref quantity;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Cart.NativeMethodInfoPtr_AddItem_Public_Void_ShopListing_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A415 RID: 42005 RVA: 0x00296940 File Offset: 0x00294B40
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 288249, RefRangeEnd = 288252, XrefRangeStart = 288226, XrefRangeEnd = 288249, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveItem(ShopListing listing, int quantity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(listing);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref quantity;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Cart.NativeMethodInfoPtr_RemoveItem_Public_Void_ShopListing_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A416 RID: 42006 RVA: 0x00296990 File Offset: 0x00294B90
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 288274, RefRangeEnd = 288275, XrefRangeStart = 288252, XrefRangeEnd = 288274, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ClearCart()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Cart.NativeMethodInfoPtr_ClearCart_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A417 RID: 42007 RVA: 0x002969C4 File Offset: 0x00294BC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 288275, XrefRangeEnd = 288279, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetCartCount(ShopListing listing)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(listing);
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Cart.NativeMethodInfoPtr_GetCartCount_Public_Int32_ShopListing_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x0600A418 RID: 42008 RVA: 0x00296A14 File Offset: 0x00294C14
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 288287, RefRangeEnd = 288288, XrefRangeStart = 288279, XrefRangeEnd = 288287, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void BopCartIcon()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Cart.NativeMethodInfoPtr_BopCartIcon_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A419 RID: 42009 RVA: 0x00296A48 File Offset: 0x00294C48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 288288, XrefRangeEnd = 288290, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool CanPlayerAffordCart()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Cart.NativeMethodInfoPtr_CanPlayerAffordCart_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x0600A41A RID: 42010 RVA: 0x00296A84 File Offset: 0x00294C84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 288290, XrefRangeEnd = 288347, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Buy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Cart.NativeMethodInfoPtr_Buy_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A41B RID: 42011 RVA: 0x00296AB8 File Offset: 0x00294CB8
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 288419, RefRangeEnd = 288423, XrefRangeStart = 288347, XrefRangeEnd = 288419, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateEntries()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Cart.NativeMethodInfoPtr_UpdateEntries_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A41C RID: 42012 RVA: 0x00296AEC File Offset: 0x00294CEC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 288447, RefRangeEnd = 288450, XrefRangeStart = 288423, XrefRangeEnd = 288447, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateTotal()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Cart.NativeMethodInfoPtr_UpdateTotal_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A41D RID: 42013 RVA: 0x00296B20 File Offset: 0x00294D20
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 288460, RefRangeEnd = 288462, XrefRangeStart = 288450, XrefRangeEnd = 288460, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateProblem()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Cart.NativeMethodInfoPtr_UpdateProblem_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A41E RID: 42014 RVA: 0x00296B54 File Offset: 0x00294D54
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 288478, RefRangeEnd = 288480, XrefRangeStart = 288462, XrefRangeEnd = 288478, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool CanCheckout(out string reason)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			ref System.IntPtr ptr2 = ref *ptr;
			System.IntPtr il2CppString = 0;
			ptr2 = &il2CppString;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Cart.NativeMethodInfoPtr_CanCheckout_Private_Boolean_byref_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			reason = IL2CPP.Il2CppStringToManaged(il2CppString);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x0600A41F RID: 42015 RVA: 0x00296BAC File Offset: 0x00294DAC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 288498, RefRangeEnd = 288499, XrefRangeStart = 288480, XrefRangeEnd = 288498, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool GetWarning(out string warning)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			ref System.IntPtr ptr2 = ref *ptr;
			System.IntPtr il2CppString = 0;
			ptr2 = &il2CppString;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Cart.NativeMethodInfoPtr_GetWarning_Private_Boolean_byref_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			warning = IL2CPP.Il2CppStringToManaged(il2CppString);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x0600A420 RID: 42016 RVA: 0x00296C04 File Offset: 0x00294E04
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 288521, RefRangeEnd = 288525, XrefRangeStart = 288499, XrefRangeEnd = 288521, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateViewCartText()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Cart.NativeMethodInfoPtr_UpdateViewCartText_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A421 RID: 42017 RVA: 0x00296C38 File Offset: 0x00294E38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 288525, XrefRangeEnd = 288533, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateLoadVehicleToggle()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Cart.NativeMethodInfoPtr_UpdateLoadVehicleToggle_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A422 RID: 42018 RVA: 0x00296C6C File Offset: 0x00294E6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 288533, XrefRangeEnd = 288547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetItemSum()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Cart.NativeMethodInfoPtr_GetItemSum_Private_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x0600A423 RID: 42019 RVA: 0x00296CA8 File Offset: 0x00294EA8
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 288564, RefRangeEnd = 288572, XrefRangeStart = 288547, XrefRangeEnd = 288564, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float GetPriceSum()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Cart.NativeMethodInfoPtr_GetPriceSum_Private_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x0600A424 RID: 42020 RVA: 0x00296CE4 File Offset: 0x00294EE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 288572, XrefRangeEnd = 288587, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CartEntry GetEntry(ShopListing listing)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(listing);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Cart.NativeMethodInfoPtr_GetEntry_Private_CartEntry_ShopListing_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<CartEntry>(intPtr2) : null;
		}

		// Token: 0x0600A425 RID: 42021 RVA: 0x00296D34 File Offset: 0x00294F34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 288587, XrefRangeEnd = 288594, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsMouseOverMenuArea()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Cart.NativeMethodInfoPtr_IsMouseOverMenuArea_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x0600A426 RID: 42022 RVA: 0x00296D70 File Offset: 0x00294F70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 288594, XrefRangeEnd = 288608, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetTotalSlotRequirement()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Cart.NativeMethodInfoPtr_GetTotalSlotRequirement_Public_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x0600A427 RID: 42023 RVA: 0x00296DAC File Offset: 0x00294FAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 288608, XrefRangeEnd = 288623, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Cart() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Cart>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Cart.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A428 RID: 42024 RVA: 0x00296DE8 File Offset: 0x00294FE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 288623, XrefRangeEnd = 288628, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator Method_Private_IEnumerator_PDM_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Cart.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr2) : null;
		}

		// Token: 0x0600A429 RID: 42025 RVA: 0x000507E7 File Offset: 0x0004E9E7
		public Cart(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17003260 RID: 12896
		// (get) Token: 0x0600A42A RID: 42026 RVA: 0x00296E28 File Offset: 0x00295028
		// (set) Token: 0x0600A42B RID: 42027 RVA: 0x000507F0 File Offset: 0x0004E9F0
		public unsafe ShopInterface Shop
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Cart.NativeFieldInfoPtr_Shop);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ShopInterface>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Cart.NativeFieldInfoPtr_Shop), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003261 RID: 12897
		// (get) Token: 0x0600A42C RID: 42028 RVA: 0x00296E58 File Offset: 0x00295058
		// (set) Token: 0x0600A42D RID: 42029 RVA: 0x0005080F File Offset: 0x0004EA0F
		public unsafe Image CartIcon
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Cart.NativeFieldInfoPtr_CartIcon);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Cart.NativeFieldInfoPtr_CartIcon), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003262 RID: 12898
		// (get) Token: 0x0600A42E RID: 42030 RVA: 0x00296E88 File Offset: 0x00295088
		// (set) Token: 0x0600A42F RID: 42031 RVA: 0x0005082E File Offset: 0x0004EA2E
		public unsafe TextMeshProUGUI ViewCartText
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Cart.NativeFieldInfoPtr_ViewCartText);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Cart.NativeFieldInfoPtr_ViewCartText), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003263 RID: 12899
		// (get) Token: 0x0600A430 RID: 42032 RVA: 0x00296EB8 File Offset: 0x002950B8
		// (set) Token: 0x0600A431 RID: 42033 RVA: 0x0005084D File Offset: 0x0004EA4D
		public unsafe RectTransform CartEntryContainer
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Cart.NativeFieldInfoPtr_CartEntryContainer);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Cart.NativeFieldInfoPtr_CartEntryContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003264 RID: 12900
		// (get) Token: 0x0600A432 RID: 42034 RVA: 0x00296EE8 File Offset: 0x002950E8
		// (set) Token: 0x0600A433 RID: 42035 RVA: 0x0005086C File Offset: 0x0004EA6C
		public unsafe TextMeshProUGUI ProblemText
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Cart.NativeFieldInfoPtr_ProblemText);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Cart.NativeFieldInfoPtr_ProblemText), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003265 RID: 12901
		// (get) Token: 0x0600A434 RID: 42036 RVA: 0x00296F18 File Offset: 0x00295118
		// (set) Token: 0x0600A435 RID: 42037 RVA: 0x0005088B File Offset: 0x0004EA8B
		public unsafe TextMeshProUGUI WarningText
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Cart.NativeFieldInfoPtr_WarningText);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Cart.NativeFieldInfoPtr_WarningText), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003266 RID: 12902
		// (get) Token: 0x0600A436 RID: 42038 RVA: 0x00296F48 File Offset: 0x00295148
		// (set) Token: 0x0600A437 RID: 42039 RVA: 0x000508AA File Offset: 0x0004EAAA
		public unsafe Button BuyButton
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Cart.NativeFieldInfoPtr_BuyButton);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Cart.NativeFieldInfoPtr_BuyButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003267 RID: 12903
		// (get) Token: 0x0600A438 RID: 42040 RVA: 0x00296F78 File Offset: 0x00295178
		// (set) Token: 0x0600A439 RID: 42041 RVA: 0x000508C9 File Offset: 0x0004EAC9
		public unsafe RectTransform CartContainer
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Cart.NativeFieldInfoPtr_CartContainer);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Cart.NativeFieldInfoPtr_CartContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003268 RID: 12904
		// (get) Token: 0x0600A43A RID: 42042 RVA: 0x00296FA8 File Offset: 0x002951A8
		// (set) Token: 0x0600A43B RID: 42043 RVA: 0x000508E8 File Offset: 0x0004EAE8
		public unsafe Image CartArea
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Cart.NativeFieldInfoPtr_CartArea);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Cart.NativeFieldInfoPtr_CartArea), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003269 RID: 12905
		// (get) Token: 0x0600A43C RID: 42044 RVA: 0x00296FD8 File Offset: 0x002951D8
		// (set) Token: 0x0600A43D RID: 42045 RVA: 0x00050907 File Offset: 0x0004EB07
		public unsafe TextMeshProUGUI TotalText
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Cart.NativeFieldInfoPtr_TotalText);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Cart.NativeFieldInfoPtr_TotalText), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700326A RID: 12906
		// (get) Token: 0x0600A43E RID: 42046 RVA: 0x00297008 File Offset: 0x00295208
		// (set) Token: 0x0600A43F RID: 42047 RVA: 0x00050926 File Offset: 0x0004EB26
		public unsafe Toggle LoadVehicleToggle
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Cart.NativeFieldInfoPtr_LoadVehicleToggle);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Toggle>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Cart.NativeFieldInfoPtr_LoadVehicleToggle), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700326B RID: 12907
		// (get) Token: 0x0600A440 RID: 42048 RVA: 0x00297038 File Offset: 0x00295238
		// (set) Token: 0x0600A441 RID: 42049 RVA: 0x00050945 File Offset: 0x0004EB45
		public unsafe CartEntry EntryPrefab
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Cart.NativeFieldInfoPtr_EntryPrefab);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CartEntry>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Cart.NativeFieldInfoPtr_EntryPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700326C RID: 12908
		// (get) Token: 0x0600A442 RID: 42050 RVA: 0x00297068 File Offset: 0x00295268
		// (set) Token: 0x0600A443 RID: 42051 RVA: 0x00050964 File Offset: 0x0004EB64
		public unsafe Dictionary<ShopListing, int> cartDictionary
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Cart.NativeFieldInfoPtr_cartDictionary);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<ShopListing, int>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Cart.NativeFieldInfoPtr_cartDictionary), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700326D RID: 12909
		// (get) Token: 0x0600A444 RID: 42052 RVA: 0x00297098 File Offset: 0x00295298
		// (set) Token: 0x0600A445 RID: 42053 RVA: 0x00050983 File Offset: 0x0004EB83
		public unsafe Coroutine cartIconBop
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Cart.NativeFieldInfoPtr_cartIconBop);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Cart.NativeFieldInfoPtr_cartIconBop), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700326E RID: 12910
		// (get) Token: 0x0600A446 RID: 42054 RVA: 0x002970C8 File Offset: 0x002952C8
		// (set) Token: 0x0600A447 RID: 42055 RVA: 0x000509A2 File Offset: 0x0004EBA2
		public unsafe List<CartEntry> cartEntries
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Cart.NativeFieldInfoPtr_cartEntries);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<CartEntry>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Cart.NativeFieldInfoPtr_cartEntries), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04006DFF RID: 28159
		private static readonly System.IntPtr NativeFieldInfoPtr_Shop;

		// Token: 0x04006E00 RID: 28160
		private static readonly System.IntPtr NativeFieldInfoPtr_CartIcon;

		// Token: 0x04006E01 RID: 28161
		private static readonly System.IntPtr NativeFieldInfoPtr_ViewCartText;

		// Token: 0x04006E02 RID: 28162
		private static readonly System.IntPtr NativeFieldInfoPtr_CartEntryContainer;

		// Token: 0x04006E03 RID: 28163
		private static readonly System.IntPtr NativeFieldInfoPtr_ProblemText;

		// Token: 0x04006E04 RID: 28164
		private static readonly System.IntPtr NativeFieldInfoPtr_WarningText;

		// Token: 0x04006E05 RID: 28165
		private static readonly System.IntPtr NativeFieldInfoPtr_BuyButton;

		// Token: 0x04006E06 RID: 28166
		private static readonly System.IntPtr NativeFieldInfoPtr_CartContainer;

		// Token: 0x04006E07 RID: 28167
		private static readonly System.IntPtr NativeFieldInfoPtr_CartArea;

		// Token: 0x04006E08 RID: 28168
		private static readonly System.IntPtr NativeFieldInfoPtr_TotalText;

		// Token: 0x04006E09 RID: 28169
		private static readonly System.IntPtr NativeFieldInfoPtr_LoadVehicleToggle;

		// Token: 0x04006E0A RID: 28170
		private static readonly System.IntPtr NativeFieldInfoPtr_EntryPrefab;

		// Token: 0x04006E0B RID: 28171
		private static readonly System.IntPtr NativeFieldInfoPtr_cartDictionary;

		// Token: 0x04006E0C RID: 28172
		private static readonly System.IntPtr NativeFieldInfoPtr_cartIconBop;

		// Token: 0x04006E0D RID: 28173
		private static readonly System.IntPtr NativeFieldInfoPtr_cartEntries;

		// Token: 0x04006E0E RID: 28174
		private static readonly System.IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0;

		// Token: 0x04006E0F RID: 28175
		private static readonly System.IntPtr NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0;

		// Token: 0x04006E10 RID: 28176
		private static readonly System.IntPtr NativeMethodInfoPtr_AddItem_Public_Void_ShopListing_Int32_0;

		// Token: 0x04006E11 RID: 28177
		private static readonly System.IntPtr NativeMethodInfoPtr_RemoveItem_Public_Void_ShopListing_Int32_0;

		// Token: 0x04006E12 RID: 28178
		private static readonly System.IntPtr NativeMethodInfoPtr_ClearCart_Public_Void_0;

		// Token: 0x04006E13 RID: 28179
		private static readonly System.IntPtr NativeMethodInfoPtr_GetCartCount_Public_Int32_ShopListing_0;

		// Token: 0x04006E14 RID: 28180
		private static readonly System.IntPtr NativeMethodInfoPtr_BopCartIcon_Public_Void_0;

		// Token: 0x04006E15 RID: 28181
		private static readonly System.IntPtr NativeMethodInfoPtr_CanPlayerAffordCart_Public_Boolean_0;

		// Token: 0x04006E16 RID: 28182
		private static readonly System.IntPtr NativeMethodInfoPtr_Buy_Public_Void_0;

		// Token: 0x04006E17 RID: 28183
		private static readonly System.IntPtr NativeMethodInfoPtr_UpdateEntries_Private_Void_0;

		// Token: 0x04006E18 RID: 28184
		private static readonly System.IntPtr NativeMethodInfoPtr_UpdateTotal_Private_Void_0;

		// Token: 0x04006E19 RID: 28185
		private static readonly System.IntPtr NativeMethodInfoPtr_UpdateProblem_Private_Void_0;

		// Token: 0x04006E1A RID: 28186
		private static readonly System.IntPtr NativeMethodInfoPtr_CanCheckout_Private_Boolean_byref_String_0;

		// Token: 0x04006E1B RID: 28187
		private static readonly System.IntPtr NativeMethodInfoPtr_GetWarning_Private_Boolean_byref_String_0;

		// Token: 0x04006E1C RID: 28188
		private static readonly System.IntPtr NativeMethodInfoPtr_UpdateViewCartText_Private_Void_0;

		// Token: 0x04006E1D RID: 28189
		private static readonly System.IntPtr NativeMethodInfoPtr_UpdateLoadVehicleToggle_Private_Void_0;

		// Token: 0x04006E1E RID: 28190
		private static readonly System.IntPtr NativeMethodInfoPtr_GetItemSum_Private_Int32_0;

		// Token: 0x04006E1F RID: 28191
		private static readonly System.IntPtr NativeMethodInfoPtr_GetPriceSum_Private_Single_0;

		// Token: 0x04006E20 RID: 28192
		private static readonly System.IntPtr NativeMethodInfoPtr_GetEntry_Private_CartEntry_ShopListing_0;

		// Token: 0x04006E21 RID: 28193
		private static readonly System.IntPtr NativeMethodInfoPtr_IsMouseOverMenuArea_Private_Boolean_0;

		// Token: 0x04006E22 RID: 28194
		private static readonly System.IntPtr NativeMethodInfoPtr_GetTotalSlotRequirement_Public_Int32_0;

		// Token: 0x04006E23 RID: 28195
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04006E24 RID: 28196
		private static readonly System.IntPtr NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0;

		// Token: 0x02000C04 RID: 3076
		[ObfuscatedName("ScheduleOne.UI.Shop.Cart+<<BopCartIcon>g__Routine|21_0>d")]
		public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCaVeSiVeSiObObUnique : Il2CppSystem.Object
		{
			// Token: 0x0600E264 RID: 57956 RVA: 0x00359F54 File Offset: 0x00358154
			// Note: this type is marked as 'beforefieldinit'.
			static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCaVeSiVeSiObObUnique()
			{
				Il2CppClassPointerStore<Cart.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCaVeSiVeSiObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Cart>.NativeClassPtr, "<<BopCartIcon>g__Routine|21_0>d");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Cart.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCaVeSiVeSiObObUnique>.NativeClassPtr);
				Cart.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCaVeSiVeSiObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cart.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCaVeSiVeSiObObUnique>.NativeClassPtr, "<>1__state");
				Cart.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCaVeSiVeSiObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cart.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCaVeSiVeSiObObUnique>.NativeClassPtr, "<>2__current");
				Cart.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCaVeSiVeSiObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cart.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCaVeSiVeSiObObUnique>.NativeClassPtr, "<>4__this");
				Cart.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCaVeSiVeSiObObUnique.NativeFieldInfoPtr__startScale_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cart.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCaVeSiVeSiObObUnique>.NativeClassPtr, "<startScale>5__2");
				Cart.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCaVeSiVeSiObObUnique.NativeFieldInfoPtr__endScale_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cart.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCaVeSiVeSiObObUnique>.NativeClassPtr, "<endScale>5__3");
				Cart.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCaVeSiVeSiObObUnique.NativeFieldInfoPtr__lerpTime_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cart.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCaVeSiVeSiObObUnique>.NativeClassPtr, "<lerpTime>5__4");
				Cart.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCaVeSiVeSiObObUnique.NativeFieldInfoPtr__i_5__5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cart.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCaVeSiVeSiObObUnique>.NativeClassPtr, "<i>5__5");
				Cart.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCaVeSiVeSiObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cart.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCaVeSiVeSiObObUnique>.NativeClassPtr, 100683484);
				Cart.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCaVeSiVeSiObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cart.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCaVeSiVeSiObObUnique>.NativeClassPtr, 100683485);
				Cart.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCaVeSiVeSiObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cart.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCaVeSiVeSiObObUnique>.NativeClassPtr, 100683486);
				Cart.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCaVeSiVeSiObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cart.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCaVeSiVeSiObObUnique>.NativeClassPtr, 100683487);
				Cart.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCaVeSiVeSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cart.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCaVeSiVeSiObObUnique>.NativeClassPtr, 100683488);
				Cart.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCaVeSiVeSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cart.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCaVeSiVeSiObObUnique>.NativeClassPtr, 100683489);
			}

			// Token: 0x0600E265 RID: 57957 RVA: 0x0035A084 File Offset: 0x00358284
			[CallerCount(54)]
			[CachedScanResults(RefRangeStart = 2646, RefRangeEnd = 2700, XrefRangeStart = 2646, XrefRangeEnd = 2700, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCaVeSiVeSiObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Cart.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCaVeSiVeSiObObUnique>.NativeClassPtr))
			{
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = ref <>1__state;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Cart.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCaVeSiVeSiObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600E266 RID: 57958 RVA: 0x0035A0CC File Offset: 0x003582CC
			[CallerCount(14558)]
			[CachedScanResults(RefRangeStart = 2769, RefRangeEnd = 17327, XrefRangeStart = 2769, XrefRangeEnd = 17327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Cart.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCaVeSiVeSiObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600E267 RID: 57959 RVA: 0x0035A100 File Offset: 0x00358300
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 288145, XrefRangeEnd = 288161, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Cart.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCaVeSiVeSiObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x170045E0 RID: 17888
			// (get) Token: 0x0600E268 RID: 57960 RVA: 0x0035A13C File Offset: 0x0035833C
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 2740, RefRangeEnd = 2764, XrefRangeStart = 2740, XrefRangeEnd = 2764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Cart.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCaVeSiVeSiObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
			}

			// Token: 0x0600E269 RID: 57961 RVA: 0x0035A17C File Offset: 0x0035837C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 288161, XrefRangeEnd = 288166, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Cart.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCaVeSiVeSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x170045E1 RID: 17889
			// (get) Token: 0x0600E26A RID: 57962 RVA: 0x0035A1B0 File Offset: 0x003583B0
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 2740, RefRangeEnd = 2764, XrefRangeStart = 2740, XrefRangeEnd = 2764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Cart.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCaVeSiVeSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
			}

			// Token: 0x0600E26B RID: 57963 RVA: 0x0006E011 File Offset: 0x0006C211
			public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCaVeSiVeSiObObUnique(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170045D9 RID: 17881
			// (get) Token: 0x0600E26C RID: 57964 RVA: 0x0035A1F0 File Offset: 0x003583F0
			// (set) Token: 0x0600E26D RID: 57965 RVA: 0x0006E01A File Offset: 0x0006C21A
			public unsafe int __1__state
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Cart.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCaVeSiVeSiObObUnique.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Cart.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCaVeSiVeSiObObUnique.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170045DA RID: 17882
			// (get) Token: 0x0600E26E RID: 57966 RVA: 0x0035A218 File Offset: 0x00358418
			// (set) Token: 0x0600E26F RID: 57967 RVA: 0x0006E035 File Offset: 0x0006C235
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Cart.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCaVeSiVeSiObObUnique.NativeFieldInfoPtr___2__current);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Cart.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCaVeSiVeSiObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170045DB RID: 17883
			// (get) Token: 0x0600E270 RID: 57968 RVA: 0x0035A248 File Offset: 0x00358448
			// (set) Token: 0x0600E271 RID: 57969 RVA: 0x0006E054 File Offset: 0x0006C254
			public unsafe Cart __4__this
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Cart.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCaVeSiVeSiObObUnique.NativeFieldInfoPtr___4__this);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Cart>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Cart.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCaVeSiVeSiObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170045DC RID: 17884
			// (get) Token: 0x0600E272 RID: 57970 RVA: 0x0035A278 File Offset: 0x00358478
			// (set) Token: 0x0600E273 RID: 57971 RVA: 0x0006E073 File Offset: 0x0006C273
			public unsafe Vector3 _startScale_5__2
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Cart.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCaVeSiVeSiObObUnique.NativeFieldInfoPtr__startScale_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Cart.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCaVeSiVeSiObObUnique.NativeFieldInfoPtr__startScale_5__2)) = value;
				}
			}

			// Token: 0x170045DD RID: 17885
			// (get) Token: 0x0600E274 RID: 57972 RVA: 0x0035A2A0 File Offset: 0x003584A0
			// (set) Token: 0x0600E275 RID: 57973 RVA: 0x0006E08E File Offset: 0x0006C28E
			public unsafe Vector3 _endScale_5__3
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Cart.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCaVeSiVeSiObObUnique.NativeFieldInfoPtr__endScale_5__3);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Cart.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCaVeSiVeSiObObUnique.NativeFieldInfoPtr__endScale_5__3)) = value;
				}
			}

			// Token: 0x170045DE RID: 17886
			// (get) Token: 0x0600E276 RID: 57974 RVA: 0x0035A2C8 File Offset: 0x003584C8
			// (set) Token: 0x0600E277 RID: 57975 RVA: 0x0006E0A9 File Offset: 0x0006C2A9
			public unsafe float _lerpTime_5__4
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Cart.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCaVeSiVeSiObObUnique.NativeFieldInfoPtr__lerpTime_5__4);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Cart.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCaVeSiVeSiObObUnique.NativeFieldInfoPtr__lerpTime_5__4)) = value;
				}
			}

			// Token: 0x170045DF RID: 17887
			// (get) Token: 0x0600E278 RID: 57976 RVA: 0x0035A2F0 File Offset: 0x003584F0
			// (set) Token: 0x0600E279 RID: 57977 RVA: 0x0006E0C4 File Offset: 0x0006C2C4
			public unsafe float _i_5__5
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Cart.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCaVeSiVeSiObObUnique.NativeFieldInfoPtr__i_5__5);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Cart.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCaVeSiVeSiObObUnique.NativeFieldInfoPtr__i_5__5)) = value;
				}
			}

			// Token: 0x040097BF RID: 38847
			private static readonly System.IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040097C0 RID: 38848
			private static readonly System.IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040097C1 RID: 38849
			private static readonly System.IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040097C2 RID: 38850
			private static readonly System.IntPtr NativeFieldInfoPtr__startScale_5__2;

			// Token: 0x040097C3 RID: 38851
			private static readonly System.IntPtr NativeFieldInfoPtr__endScale_5__3;

			// Token: 0x040097C4 RID: 38852
			private static readonly System.IntPtr NativeFieldInfoPtr__lerpTime_5__4;

			// Token: 0x040097C5 RID: 38853
			private static readonly System.IntPtr NativeFieldInfoPtr__i_5__5;

			// Token: 0x040097C6 RID: 38854
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040097C7 RID: 38855
			private static readonly System.IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040097C8 RID: 38856
			private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040097C9 RID: 38857
			private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040097CA RID: 38858
			private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040097CB RID: 38859
			private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x02000C05 RID: 3077
		[ObfuscatedName("ScheduleOne.UI.Shop.Cart+<>c__DisplayClass33_0")]
		public sealed class __c__DisplayClass33_0 : Il2CppSystem.Object
		{
			// Token: 0x0600E27A RID: 57978 RVA: 0x0035A318 File Offset: 0x00358518
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass33_0()
			{
				Il2CppClassPointerStore<Cart.__c__DisplayClass33_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Cart>.NativeClassPtr, "<>c__DisplayClass33_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Cart.__c__DisplayClass33_0>.NativeClassPtr);
				Cart.__c__DisplayClass33_0.NativeFieldInfoPtr_listing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cart.__c__DisplayClass33_0>.NativeClassPtr, "listing");
				Cart.__c__DisplayClass33_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cart.__c__DisplayClass33_0>.NativeClassPtr, 100683490);
				Cart.__c__DisplayClass33_0.NativeMethodInfoPtr__GetEntry_b__0_Internal_Boolean_CartEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cart.__c__DisplayClass33_0>.NativeClassPtr, 100683491);
			}

			// Token: 0x0600E27B RID: 57979 RVA: 0x0035A380 File Offset: 0x00358580
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass33_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Cart.__c__DisplayClass33_0>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Cart.__c__DisplayClass33_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600E27C RID: 57980 RVA: 0x0035A3BC File Offset: 0x003585BC
			[CallerCount(0)]
			public unsafe bool _GetEntry_b__0(CartEntry x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Cart.__c__DisplayClass33_0.NativeMethodInfoPtr__GetEntry_b__0_Internal_Boolean_CartEntry_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x0600E27D RID: 57981 RVA: 0x0006E0DF File Offset: 0x0006C2DF
			public __c__DisplayClass33_0(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170045E2 RID: 17890
			// (get) Token: 0x0600E27E RID: 57982 RVA: 0x0035A40C File Offset: 0x0035860C
			// (set) Token: 0x0600E27F RID: 57983 RVA: 0x0006E0E8 File Offset: 0x0006C2E8
			public unsafe ShopListing listing
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Cart.__c__DisplayClass33_0.NativeFieldInfoPtr_listing);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ShopListing>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Cart.__c__DisplayClass33_0.NativeFieldInfoPtr_listing), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040097CC RID: 38860
			private static readonly System.IntPtr NativeFieldInfoPtr_listing;

			// Token: 0x040097CD RID: 38861
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040097CE RID: 38862
			private static readonly System.IntPtr NativeMethodInfoPtr__GetEntry_b__0_Internal_Boolean_CartEntry_0;
		}
	}
}
