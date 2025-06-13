using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using Il2CppScheduleOne.Messaging;
using Il2CppScheduleOne.Product;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI.Phone
{
	// Token: 0x020006C2 RID: 1730
	public class CounterofferInterface : MonoBehaviour
	{
		// Token: 0x06009930 RID: 39216 RVA: 0x00275714 File Offset: 0x00273914
		// Note: this type is marked as 'beforefieldinit'.
		static CounterofferInterface()
		{
			Il2CppClassPointerStore<CounterofferInterface>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Phone", "CounterofferInterface");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CounterofferInterface>.NativeClassPtr);
			CounterofferInterface.NativeFieldInfoPtr_COUNTEROFFER_SUCCESS_XP = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CounterofferInterface>.NativeClassPtr, "COUNTEROFFER_SUCCESS_XP");
			CounterofferInterface.NativeFieldInfoPtr__IsOpen_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CounterofferInterface>.NativeClassPtr, "<IsOpen>k__BackingField");
			CounterofferInterface.NativeFieldInfoPtr_MinQuantity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CounterofferInterface>.NativeClassPtr, "MinQuantity");
			CounterofferInterface.NativeFieldInfoPtr_MaxQuantity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CounterofferInterface>.NativeClassPtr, "MaxQuantity");
			CounterofferInterface.NativeFieldInfoPtr_MinPrice = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CounterofferInterface>.NativeClassPtr, "MinPrice");
			CounterofferInterface.NativeFieldInfoPtr_MaxPrice = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CounterofferInterface>.NativeClassPtr, "MaxPrice");
			CounterofferInterface.NativeFieldInfoPtr_IconAlignment = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CounterofferInterface>.NativeClassPtr, "IconAlignment");
			CounterofferInterface.NativeFieldInfoPtr_ProductEntryPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CounterofferInterface>.NativeClassPtr, "ProductEntryPrefab");
			CounterofferInterface.NativeFieldInfoPtr_Container = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CounterofferInterface>.NativeClassPtr, "Container");
			CounterofferInterface.NativeFieldInfoPtr_TitleLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CounterofferInterface>.NativeClassPtr, "TitleLabel");
			CounterofferInterface.NativeFieldInfoPtr_ConfirmButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CounterofferInterface>.NativeClassPtr, "ConfirmButton");
			CounterofferInterface.NativeFieldInfoPtr_ProductIcon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CounterofferInterface>.NativeClassPtr, "ProductIcon");
			CounterofferInterface.NativeFieldInfoPtr_ProductLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CounterofferInterface>.NativeClassPtr, "ProductLabel");
			CounterofferInterface.NativeFieldInfoPtr_ProductLabelRect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CounterofferInterface>.NativeClassPtr, "ProductLabelRect");
			CounterofferInterface.NativeFieldInfoPtr_PriceInput = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CounterofferInterface>.NativeClassPtr, "PriceInput");
			CounterofferInterface.NativeFieldInfoPtr_FairPriceLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CounterofferInterface>.NativeClassPtr, "FairPriceLabel");
			CounterofferInterface.NativeFieldInfoPtr_ProductSelector = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CounterofferInterface>.NativeClassPtr, "ProductSelector");
			CounterofferInterface.NativeFieldInfoPtr_orderConfirmedCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CounterofferInterface>.NativeClassPtr, "orderConfirmedCallback");
			CounterofferInterface.NativeFieldInfoPtr_selectedProduct = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CounterofferInterface>.NativeClassPtr, "selectedProduct");
			CounterofferInterface.NativeFieldInfoPtr_quantity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CounterofferInterface>.NativeClassPtr, "quantity");
			CounterofferInterface.NativeFieldInfoPtr_price = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CounterofferInterface>.NativeClassPtr, "price");
			CounterofferInterface.NativeFieldInfoPtr_productEntries = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CounterofferInterface>.NativeClassPtr, "productEntries");
			CounterofferInterface.NativeFieldInfoPtr_mouseUp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CounterofferInterface>.NativeClassPtr, "mouseUp");
			CounterofferInterface.NativeFieldInfoPtr_conversation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CounterofferInterface>.NativeClassPtr, "conversation");
			CounterofferInterface.NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CounterofferInterface>.NativeClassPtr, 100682322);
			CounterofferInterface.NativeMethodInfoPtr_set_IsOpen_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CounterofferInterface>.NativeClassPtr, 100682323);
			CounterofferInterface.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CounterofferInterface>.NativeClassPtr, 100682324);
			CounterofferInterface.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CounterofferInterface>.NativeClassPtr, 100682325);
			CounterofferInterface.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CounterofferInterface>.NativeClassPtr, 100682326);
			CounterofferInterface.NativeMethodInfoPtr_Open_Public_Void_ProductDefinition_Int32_Single_MSGConversation_Action_3_ProductDefinition_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CounterofferInterface>.NativeClassPtr, 100682327);
			CounterofferInterface.NativeMethodInfoPtr_Close_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CounterofferInterface>.NativeClassPtr, 100682328);
			CounterofferInterface.NativeMethodInfoPtr_Exit_Public_Void_ExitAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CounterofferInterface>.NativeClassPtr, 100682329);
			CounterofferInterface.NativeMethodInfoPtr_Send_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CounterofferInterface>.NativeClassPtr, 100682330);
			CounterofferInterface.NativeMethodInfoPtr_UpdateFairPrice_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CounterofferInterface>.NativeClassPtr, 100682331);
			CounterofferInterface.NativeMethodInfoPtr_SetProduct_Private_Void_ProductDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CounterofferInterface>.NativeClassPtr, 100682332);
			CounterofferInterface.NativeMethodInfoPtr_DisplayProduct_Private_Void_ProductDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CounterofferInterface>.NativeClassPtr, 100682333);
			CounterofferInterface.NativeMethodInfoPtr_ChangeQuantity_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CounterofferInterface>.NativeClassPtr, 100682334);
			CounterofferInterface.NativeMethodInfoPtr_UpdatePriceQuantityLabel_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CounterofferInterface>.NativeClassPtr, 100682335);
			CounterofferInterface.NativeMethodInfoPtr_ChangePrice_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CounterofferInterface>.NativeClassPtr, 100682336);
			CounterofferInterface.NativeMethodInfoPtr_PriceSubmitted_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CounterofferInterface>.NativeClassPtr, 100682337);
			CounterofferInterface.NativeMethodInfoPtr_OpenProductSelector_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CounterofferInterface>.NativeClassPtr, 100682338);
			CounterofferInterface.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CounterofferInterface>.NativeClassPtr, 100682339);
		}

		// Token: 0x17002ED9 RID: 11993
		// (get) Token: 0x06009931 RID: 39217 RVA: 0x00275A8C File Offset: 0x00273C8C
		// (set) Token: 0x06009932 RID: 39218 RVA: 0x00275AC8 File Offset: 0x00273CC8
		public unsafe bool IsOpen
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 37513, RefRangeEnd = 37514, XrefRangeStart = 37513, XrefRangeEnd = 37514, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(CounterofferInterface.NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
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
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CounterofferInterface.NativeMethodInfoPtr_set_IsOpen_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x06009933 RID: 39219 RVA: 0x00275B08 File Offset: 0x00273D08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 274393, XrefRangeEnd = 274423, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CounterofferInterface.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009934 RID: 39220 RVA: 0x00275B3C File Offset: 0x00273D3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 274423, XrefRangeEnd = 274434, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CounterofferInterface.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009935 RID: 39221 RVA: 0x00275B70 File Offset: 0x00273D70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 274434, XrefRangeEnd = 274465, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CounterofferInterface.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009936 RID: 39222 RVA: 0x00275BA4 File Offset: 0x00273DA4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 274490, RefRangeEnd = 274491, XrefRangeStart = 274465, XrefRangeEnd = 274490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Open(ProductDefinition product, int quantity, float price, MSGConversation _conversation, Il2CppSystem.Action<ProductDefinition, int, float> _orderConfirmedCallback)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)5) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(product);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref quantity;
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref price;
			ptr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(_conversation);
			ptr[checked(unchecked((System.UIntPtr)4) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(_orderConfirmedCallback);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CounterofferInterface.NativeMethodInfoPtr_Open_Public_Void_ProductDefinition_Int32_Single_MSGConversation_Action_3_ProductDefinition_Int32_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009937 RID: 39223 RVA: 0x00275C28 File Offset: 0x00273E28
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 274509, RefRangeEnd = 274512, XrefRangeStart = 274491, XrefRangeEnd = 274509, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Close()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CounterofferInterface.NativeMethodInfoPtr_Close_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009938 RID: 39224 RVA: 0x00275C5C File Offset: 0x00273E5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 274512, XrefRangeEnd = 274514, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Exit(ExitAction action)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(action);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CounterofferInterface.NativeMethodInfoPtr_Exit_Public_Void_ExitAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009939 RID: 39225 RVA: 0x00275CA0 File Offset: 0x00273EA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 274514, XrefRangeEnd = 274518, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Send()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CounterofferInterface.NativeMethodInfoPtr_Send_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600993A RID: 39226 RVA: 0x00275CD4 File Offset: 0x00273ED4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 274523, RefRangeEnd = 274526, XrefRangeStart = 274518, XrefRangeEnd = 274523, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateFairPrice()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CounterofferInterface.NativeMethodInfoPtr_UpdateFairPrice_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600993B RID: 39227 RVA: 0x00275D08 File Offset: 0x00273F08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 274526, XrefRangeEnd = 274533, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetProduct(ProductDefinition newProduct)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(newProduct);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CounterofferInterface.NativeMethodInfoPtr_SetProduct_Private_Void_ProductDefinition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600993C RID: 39228 RVA: 0x00275D4C File Offset: 0x00273F4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 274533, XrefRangeEnd = 274536, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DisplayProduct(ProductDefinition tempProduct)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(tempProduct);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CounterofferInterface.NativeMethodInfoPtr_DisplayProduct_Private_Void_ProductDefinition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600993D RID: 39229 RVA: 0x00275D90 File Offset: 0x00273F90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 274536, XrefRangeEnd = 274540, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ChangeQuantity(int change)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref change;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CounterofferInterface.NativeMethodInfoPtr_ChangeQuantity_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600993E RID: 39230 RVA: 0x00275DD0 File Offset: 0x00273FD0
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 274547, RefRangeEnd = 274551, XrefRangeStart = 274540, XrefRangeEnd = 274547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdatePriceQuantityLabel(string productName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(productName);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CounterofferInterface.NativeMethodInfoPtr_UpdatePriceQuantityLabel_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600993F RID: 39231 RVA: 0x00275E14 File Offset: 0x00274014
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 274551, XrefRangeEnd = 274554, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ChangePrice(float change)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref change;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CounterofferInterface.NativeMethodInfoPtr_ChangePrice_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009940 RID: 39232 RVA: 0x00275E54 File Offset: 0x00274054
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 274554, XrefRangeEnd = 274558, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PriceSubmitted(string value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CounterofferInterface.NativeMethodInfoPtr_PriceSubmitted_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009941 RID: 39233 RVA: 0x00275E98 File Offset: 0x00274098
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 274558, XrefRangeEnd = 274576, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OpenProductSelector()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CounterofferInterface.NativeMethodInfoPtr_OpenProductSelector_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009942 RID: 39234 RVA: 0x00275ECC File Offset: 0x002740CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 274576, XrefRangeEnd = 274584, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CounterofferInterface() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CounterofferInterface>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CounterofferInterface.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009943 RID: 39235 RVA: 0x0004A282 File Offset: 0x00048482
		public CounterofferInterface(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002EC1 RID: 11969
		// (get) Token: 0x06009944 RID: 39236 RVA: 0x00275F08 File Offset: 0x00274108
		// (set) Token: 0x06009945 RID: 39237 RVA: 0x0004A28B File Offset: 0x0004848B
		public unsafe static int COUNTEROFFER_SUCCESS_XP
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(CounterofferInterface.NativeFieldInfoPtr_COUNTEROFFER_SUCCESS_XP, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CounterofferInterface.NativeFieldInfoPtr_COUNTEROFFER_SUCCESS_XP, (void*)(&value));
			}
		}

		// Token: 0x17002EC2 RID: 11970
		// (get) Token: 0x06009946 RID: 39238 RVA: 0x00275F24 File Offset: 0x00274124
		// (set) Token: 0x06009947 RID: 39239 RVA: 0x0004A299 File Offset: 0x00048499
		public unsafe bool _IsOpen_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CounterofferInterface.NativeFieldInfoPtr__IsOpen_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CounterofferInterface.NativeFieldInfoPtr__IsOpen_k__BackingField)) = value;
			}
		}

		// Token: 0x17002EC3 RID: 11971
		// (get) Token: 0x06009948 RID: 39240 RVA: 0x00275F4C File Offset: 0x0027414C
		// (set) Token: 0x06009949 RID: 39241 RVA: 0x0004A2B4 File Offset: 0x000484B4
		public unsafe static int MinQuantity
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(CounterofferInterface.NativeFieldInfoPtr_MinQuantity, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CounterofferInterface.NativeFieldInfoPtr_MinQuantity, (void*)(&value));
			}
		}

		// Token: 0x17002EC4 RID: 11972
		// (get) Token: 0x0600994A RID: 39242 RVA: 0x00275F68 File Offset: 0x00274168
		// (set) Token: 0x0600994B RID: 39243 RVA: 0x0004A2C2 File Offset: 0x000484C2
		public unsafe int MaxQuantity
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CounterofferInterface.NativeFieldInfoPtr_MaxQuantity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CounterofferInterface.NativeFieldInfoPtr_MaxQuantity)) = value;
			}
		}

		// Token: 0x17002EC5 RID: 11973
		// (get) Token: 0x0600994C RID: 39244 RVA: 0x00275F90 File Offset: 0x00274190
		// (set) Token: 0x0600994D RID: 39245 RVA: 0x0004A2DD File Offset: 0x000484DD
		public unsafe static float MinPrice
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(CounterofferInterface.NativeFieldInfoPtr_MinPrice, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CounterofferInterface.NativeFieldInfoPtr_MinPrice, (void*)(&value));
			}
		}

		// Token: 0x17002EC6 RID: 11974
		// (get) Token: 0x0600994E RID: 39246 RVA: 0x00275FAC File Offset: 0x002741AC
		// (set) Token: 0x0600994F RID: 39247 RVA: 0x0004A2EB File Offset: 0x000484EB
		public unsafe static float MaxPrice
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(CounterofferInterface.NativeFieldInfoPtr_MaxPrice, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CounterofferInterface.NativeFieldInfoPtr_MaxPrice, (void*)(&value));
			}
		}

		// Token: 0x17002EC7 RID: 11975
		// (get) Token: 0x06009950 RID: 39248 RVA: 0x00275FC8 File Offset: 0x002741C8
		// (set) Token: 0x06009951 RID: 39249 RVA: 0x0004A2F9 File Offset: 0x000484F9
		public unsafe float IconAlignment
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CounterofferInterface.NativeFieldInfoPtr_IconAlignment);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CounterofferInterface.NativeFieldInfoPtr_IconAlignment)) = value;
			}
		}

		// Token: 0x17002EC8 RID: 11976
		// (get) Token: 0x06009952 RID: 39250 RVA: 0x00275FF0 File Offset: 0x002741F0
		// (set) Token: 0x06009953 RID: 39251 RVA: 0x0004A314 File Offset: 0x00048514
		public unsafe GameObject ProductEntryPrefab
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CounterofferInterface.NativeFieldInfoPtr_ProductEntryPrefab);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CounterofferInterface.NativeFieldInfoPtr_ProductEntryPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002EC9 RID: 11977
		// (get) Token: 0x06009954 RID: 39252 RVA: 0x00276020 File Offset: 0x00274220
		// (set) Token: 0x06009955 RID: 39253 RVA: 0x0004A333 File Offset: 0x00048533
		public unsafe GameObject Container
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CounterofferInterface.NativeFieldInfoPtr_Container);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CounterofferInterface.NativeFieldInfoPtr_Container), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002ECA RID: 11978
		// (get) Token: 0x06009956 RID: 39254 RVA: 0x00276050 File Offset: 0x00274250
		// (set) Token: 0x06009957 RID: 39255 RVA: 0x0004A352 File Offset: 0x00048552
		public unsafe Text TitleLabel
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CounterofferInterface.NativeFieldInfoPtr_TitleLabel);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CounterofferInterface.NativeFieldInfoPtr_TitleLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002ECB RID: 11979
		// (get) Token: 0x06009958 RID: 39256 RVA: 0x00276080 File Offset: 0x00274280
		// (set) Token: 0x06009959 RID: 39257 RVA: 0x0004A371 File Offset: 0x00048571
		public unsafe Button ConfirmButton
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CounterofferInterface.NativeFieldInfoPtr_ConfirmButton);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CounterofferInterface.NativeFieldInfoPtr_ConfirmButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002ECC RID: 11980
		// (get) Token: 0x0600995A RID: 39258 RVA: 0x002760B0 File Offset: 0x002742B0
		// (set) Token: 0x0600995B RID: 39259 RVA: 0x0004A390 File Offset: 0x00048590
		public unsafe Image ProductIcon
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CounterofferInterface.NativeFieldInfoPtr_ProductIcon);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CounterofferInterface.NativeFieldInfoPtr_ProductIcon), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002ECD RID: 11981
		// (get) Token: 0x0600995C RID: 39260 RVA: 0x002760E0 File Offset: 0x002742E0
		// (set) Token: 0x0600995D RID: 39261 RVA: 0x0004A3AF File Offset: 0x000485AF
		public unsafe Text ProductLabel
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CounterofferInterface.NativeFieldInfoPtr_ProductLabel);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CounterofferInterface.NativeFieldInfoPtr_ProductLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002ECE RID: 11982
		// (get) Token: 0x0600995E RID: 39262 RVA: 0x00276110 File Offset: 0x00274310
		// (set) Token: 0x0600995F RID: 39263 RVA: 0x0004A3CE File Offset: 0x000485CE
		public unsafe RectTransform ProductLabelRect
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CounterofferInterface.NativeFieldInfoPtr_ProductLabelRect);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CounterofferInterface.NativeFieldInfoPtr_ProductLabelRect), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002ECF RID: 11983
		// (get) Token: 0x06009960 RID: 39264 RVA: 0x00276140 File Offset: 0x00274340
		// (set) Token: 0x06009961 RID: 39265 RVA: 0x0004A3ED File Offset: 0x000485ED
		public unsafe InputField PriceInput
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CounterofferInterface.NativeFieldInfoPtr_PriceInput);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<InputField>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CounterofferInterface.NativeFieldInfoPtr_PriceInput), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002ED0 RID: 11984
		// (get) Token: 0x06009962 RID: 39266 RVA: 0x00276170 File Offset: 0x00274370
		// (set) Token: 0x06009963 RID: 39267 RVA: 0x0004A40C File Offset: 0x0004860C
		public unsafe Text FairPriceLabel
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CounterofferInterface.NativeFieldInfoPtr_FairPriceLabel);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CounterofferInterface.NativeFieldInfoPtr_FairPriceLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002ED1 RID: 11985
		// (get) Token: 0x06009964 RID: 39268 RVA: 0x002761A0 File Offset: 0x002743A0
		// (set) Token: 0x06009965 RID: 39269 RVA: 0x0004A42B File Offset: 0x0004862B
		public unsafe CounterOfferProductSelector ProductSelector
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CounterofferInterface.NativeFieldInfoPtr_ProductSelector);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CounterOfferProductSelector>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CounterofferInterface.NativeFieldInfoPtr_ProductSelector), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002ED2 RID: 11986
		// (get) Token: 0x06009966 RID: 39270 RVA: 0x002761D0 File Offset: 0x002743D0
		// (set) Token: 0x06009967 RID: 39271 RVA: 0x0004A44A File Offset: 0x0004864A
		public unsafe Il2CppSystem.Action<ProductDefinition, int, float> orderConfirmedCallback
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CounterofferInterface.NativeFieldInfoPtr_orderConfirmedCallback);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Action<ProductDefinition, int, float>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CounterofferInterface.NativeFieldInfoPtr_orderConfirmedCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002ED3 RID: 11987
		// (get) Token: 0x06009968 RID: 39272 RVA: 0x00276200 File Offset: 0x00274400
		// (set) Token: 0x06009969 RID: 39273 RVA: 0x0004A469 File Offset: 0x00048669
		public unsafe ProductDefinition selectedProduct
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CounterofferInterface.NativeFieldInfoPtr_selectedProduct);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ProductDefinition>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CounterofferInterface.NativeFieldInfoPtr_selectedProduct), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002ED4 RID: 11988
		// (get) Token: 0x0600996A RID: 39274 RVA: 0x00276230 File Offset: 0x00274430
		// (set) Token: 0x0600996B RID: 39275 RVA: 0x0004A488 File Offset: 0x00048688
		public unsafe int quantity
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CounterofferInterface.NativeFieldInfoPtr_quantity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CounterofferInterface.NativeFieldInfoPtr_quantity)) = value;
			}
		}

		// Token: 0x17002ED5 RID: 11989
		// (get) Token: 0x0600996C RID: 39276 RVA: 0x00276258 File Offset: 0x00274458
		// (set) Token: 0x0600996D RID: 39277 RVA: 0x0004A4A3 File Offset: 0x000486A3
		public unsafe float price
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CounterofferInterface.NativeFieldInfoPtr_price);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CounterofferInterface.NativeFieldInfoPtr_price)) = value;
			}
		}

		// Token: 0x17002ED6 RID: 11990
		// (get) Token: 0x0600996E RID: 39278 RVA: 0x00276280 File Offset: 0x00274480
		// (set) Token: 0x0600996F RID: 39279 RVA: 0x0004A4BE File Offset: 0x000486BE
		public unsafe Dictionary<ProductDefinition, RectTransform> productEntries
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CounterofferInterface.NativeFieldInfoPtr_productEntries);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<ProductDefinition, RectTransform>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CounterofferInterface.NativeFieldInfoPtr_productEntries), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002ED7 RID: 11991
		// (get) Token: 0x06009970 RID: 39280 RVA: 0x002762B0 File Offset: 0x002744B0
		// (set) Token: 0x06009971 RID: 39281 RVA: 0x0004A4DD File Offset: 0x000486DD
		public unsafe bool mouseUp
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CounterofferInterface.NativeFieldInfoPtr_mouseUp);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CounterofferInterface.NativeFieldInfoPtr_mouseUp)) = value;
			}
		}

		// Token: 0x17002ED8 RID: 11992
		// (get) Token: 0x06009972 RID: 39282 RVA: 0x002762D8 File Offset: 0x002744D8
		// (set) Token: 0x06009973 RID: 39283 RVA: 0x0004A4F8 File Offset: 0x000486F8
		public unsafe MSGConversation conversation
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CounterofferInterface.NativeFieldInfoPtr_conversation);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MSGConversation>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CounterofferInterface.NativeFieldInfoPtr_conversation), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04006744 RID: 26436
		private static readonly System.IntPtr NativeFieldInfoPtr_COUNTEROFFER_SUCCESS_XP;

		// Token: 0x04006745 RID: 26437
		private static readonly System.IntPtr NativeFieldInfoPtr__IsOpen_k__BackingField;

		// Token: 0x04006746 RID: 26438
		private static readonly System.IntPtr NativeFieldInfoPtr_MinQuantity;

		// Token: 0x04006747 RID: 26439
		private static readonly System.IntPtr NativeFieldInfoPtr_MaxQuantity;

		// Token: 0x04006748 RID: 26440
		private static readonly System.IntPtr NativeFieldInfoPtr_MinPrice;

		// Token: 0x04006749 RID: 26441
		private static readonly System.IntPtr NativeFieldInfoPtr_MaxPrice;

		// Token: 0x0400674A RID: 26442
		private static readonly System.IntPtr NativeFieldInfoPtr_IconAlignment;

		// Token: 0x0400674B RID: 26443
		private static readonly System.IntPtr NativeFieldInfoPtr_ProductEntryPrefab;

		// Token: 0x0400674C RID: 26444
		private static readonly System.IntPtr NativeFieldInfoPtr_Container;

		// Token: 0x0400674D RID: 26445
		private static readonly System.IntPtr NativeFieldInfoPtr_TitleLabel;

		// Token: 0x0400674E RID: 26446
		private static readonly System.IntPtr NativeFieldInfoPtr_ConfirmButton;

		// Token: 0x0400674F RID: 26447
		private static readonly System.IntPtr NativeFieldInfoPtr_ProductIcon;

		// Token: 0x04006750 RID: 26448
		private static readonly System.IntPtr NativeFieldInfoPtr_ProductLabel;

		// Token: 0x04006751 RID: 26449
		private static readonly System.IntPtr NativeFieldInfoPtr_ProductLabelRect;

		// Token: 0x04006752 RID: 26450
		private static readonly System.IntPtr NativeFieldInfoPtr_PriceInput;

		// Token: 0x04006753 RID: 26451
		private static readonly System.IntPtr NativeFieldInfoPtr_FairPriceLabel;

		// Token: 0x04006754 RID: 26452
		private static readonly System.IntPtr NativeFieldInfoPtr_ProductSelector;

		// Token: 0x04006755 RID: 26453
		private static readonly System.IntPtr NativeFieldInfoPtr_orderConfirmedCallback;

		// Token: 0x04006756 RID: 26454
		private static readonly System.IntPtr NativeFieldInfoPtr_selectedProduct;

		// Token: 0x04006757 RID: 26455
		private static readonly System.IntPtr NativeFieldInfoPtr_quantity;

		// Token: 0x04006758 RID: 26456
		private static readonly System.IntPtr NativeFieldInfoPtr_price;

		// Token: 0x04006759 RID: 26457
		private static readonly System.IntPtr NativeFieldInfoPtr_productEntries;

		// Token: 0x0400675A RID: 26458
		private static readonly System.IntPtr NativeFieldInfoPtr_mouseUp;

		// Token: 0x0400675B RID: 26459
		private static readonly System.IntPtr NativeFieldInfoPtr_conversation;

		// Token: 0x0400675C RID: 26460
		private static readonly System.IntPtr NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0;

		// Token: 0x0400675D RID: 26461
		private static readonly System.IntPtr NativeMethodInfoPtr_set_IsOpen_Private_set_Void_Boolean_0;

		// Token: 0x0400675E RID: 26462
		private static readonly System.IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x0400675F RID: 26463
		private static readonly System.IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x04006760 RID: 26464
		private static readonly System.IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x04006761 RID: 26465
		private static readonly System.IntPtr NativeMethodInfoPtr_Open_Public_Void_ProductDefinition_Int32_Single_MSGConversation_Action_3_ProductDefinition_Int32_Single_0;

		// Token: 0x04006762 RID: 26466
		private static readonly System.IntPtr NativeMethodInfoPtr_Close_Public_Void_0;

		// Token: 0x04006763 RID: 26467
		private static readonly System.IntPtr NativeMethodInfoPtr_Exit_Public_Void_ExitAction_0;

		// Token: 0x04006764 RID: 26468
		private static readonly System.IntPtr NativeMethodInfoPtr_Send_Public_Void_0;

		// Token: 0x04006765 RID: 26469
		private static readonly System.IntPtr NativeMethodInfoPtr_UpdateFairPrice_Private_Void_0;

		// Token: 0x04006766 RID: 26470
		private static readonly System.IntPtr NativeMethodInfoPtr_SetProduct_Private_Void_ProductDefinition_0;

		// Token: 0x04006767 RID: 26471
		private static readonly System.IntPtr NativeMethodInfoPtr_DisplayProduct_Private_Void_ProductDefinition_0;

		// Token: 0x04006768 RID: 26472
		private static readonly System.IntPtr NativeMethodInfoPtr_ChangeQuantity_Public_Void_Int32_0;

		// Token: 0x04006769 RID: 26473
		private static readonly System.IntPtr NativeMethodInfoPtr_UpdatePriceQuantityLabel_Private_Void_String_0;

		// Token: 0x0400676A RID: 26474
		private static readonly System.IntPtr NativeMethodInfoPtr_ChangePrice_Public_Void_Single_0;

		// Token: 0x0400676B RID: 26475
		private static readonly System.IntPtr NativeMethodInfoPtr_PriceSubmitted_Public_Void_String_0;

		// Token: 0x0400676C RID: 26476
		private static readonly System.IntPtr NativeMethodInfoPtr_OpenProductSelector_Public_Void_0;

		// Token: 0x0400676D RID: 26477
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
