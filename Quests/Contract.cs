using System;
using Il2CppFishNet.Object;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Economy;
using Il2CppScheduleOne.GameTime;
using Il2CppScheduleOne.ItemFramework;
using Il2CppScheduleOne.Persistence.Datas;
using Il2CppScheduleOne.Product;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Il2CppScheduleOne.Quests
{
	// Token: 0x020001B6 RID: 438
	public class Contract : Quest
	{
		// Token: 0x060024C1 RID: 9409 RVA: 0x000E5664 File Offset: 0x000E3864
		// Note: this type is marked as 'beforefieldinit'.
		static Contract()
		{
			Il2CppClassPointerStore<Contract>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Quests", "Contract");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Contract>.NativeClassPtr);
			Contract.NativeFieldInfoPtr_DefaultExpiryTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Contract>.NativeClassPtr, "DefaultExpiryTime");
			Contract.NativeFieldInfoPtr_Contracts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Contract>.NativeClassPtr, "Contracts");
			Contract.NativeFieldInfoPtr__Customer_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Contract>.NativeClassPtr, "<Customer>k__BackingField");
			Contract.NativeFieldInfoPtr__Dealer_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Contract>.NativeClassPtr, "<Dealer>k__BackingField");
			Contract.NativeFieldInfoPtr__Payment_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Contract>.NativeClassPtr, "<Payment>k__BackingField");
			Contract.NativeFieldInfoPtr_ProductList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Contract>.NativeClassPtr, "ProductList");
			Contract.NativeFieldInfoPtr_DeliveryLocation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Contract>.NativeClassPtr, "DeliveryLocation");
			Contract.NativeFieldInfoPtr_DeliveryWindow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Contract>.NativeClassPtr, "DeliveryWindow");
			Contract.NativeFieldInfoPtr__PickupScheduleIndex_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Contract>.NativeClassPtr, "<PickupScheduleIndex>k__BackingField");
			Contract.NativeFieldInfoPtr__AcceptTime_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Contract>.NativeClassPtr, "<AcceptTime>k__BackingField");
			Contract.NativeFieldInfoPtr_completedContractsIncremented = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Contract>.NativeClassPtr, "completedContractsIncremented");
			Contract.NativeMethodInfoPtr_get_Customer_Public_get_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Contract>.NativeClassPtr, 100667397);
			Contract.NativeMethodInfoPtr_set_Customer_Protected_set_Void_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Contract>.NativeClassPtr, 100667398);
			Contract.NativeMethodInfoPtr_get_Dealer_Public_get_Dealer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Contract>.NativeClassPtr, 100667399);
			Contract.NativeMethodInfoPtr_set_Dealer_Protected_set_Void_Dealer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Contract>.NativeClassPtr, 100667400);
			Contract.NativeMethodInfoPtr_get_Payment_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Contract>.NativeClassPtr, 100667401);
			Contract.NativeMethodInfoPtr_set_Payment_Protected_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Contract>.NativeClassPtr, 100667402);
			Contract.NativeMethodInfoPtr_get_PickupScheduleIndex_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Contract>.NativeClassPtr, 100667403);
			Contract.NativeMethodInfoPtr_set_PickupScheduleIndex_Protected_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Contract>.NativeClassPtr, 100667404);
			Contract.NativeMethodInfoPtr_get_AcceptTime_Public_get_GameDateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Contract>.NativeClassPtr, 100667405);
			Contract.NativeMethodInfoPtr_set_AcceptTime_Protected_set_Void_GameDateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Contract>.NativeClassPtr, 100667406);
			Contract.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Contract>.NativeClassPtr, 100667407);
			Contract.NativeMethodInfoPtr_InitializeContract_Public_Virtual_New_Void_String_String_Il2CppReferenceArray_1_QuestEntryData_String_NetworkObject_Single_ProductList_String_QuestWindowConfig_Int32_GameDateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Contract>.NativeClassPtr, 100667408);
			Contract.NativeMethodInfoPtr_SilentlyInitializeContract_Public_Virtual_New_Void_String_String_Il2CppReferenceArray_1_QuestEntryData_String_NetworkObject_Single_ProductList_String_QuestWindowConfig_Int32_GameDateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Contract>.NativeClassPtr, 100667409);
			Contract.NativeMethodInfoPtr_MinPass_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Contract>.NativeClassPtr, 100667410);
			Contract.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Contract>.NativeClassPtr, 100667411);
			Contract.NativeMethodInfoPtr_UpdateTiming_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Contract>.NativeClassPtr, 100667412);
			Contract.NativeMethodInfoPtr_End_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Contract>.NativeClassPtr, 100667413);
			Contract.NativeMethodInfoPtr_Complete_Public_Virtual_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Contract>.NativeClassPtr, 100667414);
			Contract.NativeMethodInfoPtr_SetDealer_Public_Void_Dealer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Contract>.NativeClassPtr, 100667415);
			Contract.NativeMethodInfoPtr_SubmitPayment_Public_Virtual_New_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Contract>.NativeClassPtr, 100667416);
			Contract.NativeMethodInfoPtr_SendExpiryReminder_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Contract>.NativeClassPtr, 100667417);
			Contract.NativeMethodInfoPtr_SendExpiredNotification_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Contract>.NativeClassPtr, 100667418);
			Contract.NativeMethodInfoPtr_ShouldShowJournalEntry_Protected_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Contract>.NativeClassPtr, 100667419);
			Contract.NativeMethodInfoPtr_CanExpire_Protected_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Contract>.NativeClassPtr, 100667420);
			Contract.NativeMethodInfoPtr_DoesProductListMatchSpecified_Public_Boolean_List_1_ItemInstance_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Contract>.NativeClassPtr, 100667421);
			Contract.NativeMethodInfoPtr_GetProductListMatch_Public_Single_List_1_ItemInstance_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Contract>.NativeClassPtr, 100667422);
			Contract.NativeMethodInfoPtr_GetSaveData_Public_Virtual_SaveData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Contract>.NativeClassPtr, 100667423);
			Contract.NativeMethodInfoPtr_ShouldSave_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Contract>.NativeClassPtr, 100667424);
			Contract.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Contract>.NativeClassPtr, 100667425);
		}

		// Token: 0x17000CA4 RID: 3236
		// (get) Token: 0x060024C2 RID: 9410 RVA: 0x000E59B4 File Offset: 0x000E3BB4
		// (set) Token: 0x060024C3 RID: 9411 RVA: 0x000E59F4 File Offset: 0x000E3BF4
		public unsafe NetworkObject Customer
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Contract.NativeMethodInfoPtr_get_Customer_Public_get_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NetworkObject>(intPtr2) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 116569, XrefRangeEnd = 116570, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Contract.NativeMethodInfoPtr_set_Customer_Protected_set_Void_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x17000CA5 RID: 3237
		// (get) Token: 0x060024C4 RID: 9412 RVA: 0x000E5A38 File Offset: 0x000E3C38
		// (set) Token: 0x060024C5 RID: 9413 RVA: 0x000E5A78 File Offset: 0x000E3C78
		public unsafe Dealer Dealer
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Contract.NativeMethodInfoPtr_get_Dealer_Public_get_Dealer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dealer>(intPtr2) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 116570, XrefRangeEnd = 116571, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Contract.NativeMethodInfoPtr_set_Dealer_Protected_set_Void_Dealer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x17000CA6 RID: 3238
		// (get) Token: 0x060024C6 RID: 9414 RVA: 0x000E5ABC File Offset: 0x000E3CBC
		// (set) Token: 0x060024C7 RID: 9415 RVA: 0x000E5AF8 File Offset: 0x000E3CF8
		public unsafe float Payment
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Contract.NativeMethodInfoPtr_get_Payment_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
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
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Contract.NativeMethodInfoPtr_set_Payment_Protected_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x17000CA7 RID: 3239
		// (get) Token: 0x060024C8 RID: 9416 RVA: 0x000E5B38 File Offset: 0x000E3D38
		// (set) Token: 0x060024C9 RID: 9417 RVA: 0x000E5B74 File Offset: 0x000E3D74
		public unsafe int PickupScheduleIndex
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Contract.NativeMethodInfoPtr_get_PickupScheduleIndex_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
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
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Contract.NativeMethodInfoPtr_set_PickupScheduleIndex_Protected_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x17000CA8 RID: 3240
		// (get) Token: 0x060024CA RID: 9418 RVA: 0x000E5BB4 File Offset: 0x000E3DB4
		// (set) Token: 0x060024CB RID: 9419 RVA: 0x000E5BF0 File Offset: 0x000E3DF0
		public unsafe GameDateTime AcceptTime
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Contract.NativeMethodInfoPtr_get_AcceptTime_Public_get_GameDateTime_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
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
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Contract.NativeMethodInfoPtr_set_AcceptTime_Protected_set_Void_GameDateTime_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x060024CC RID: 9420 RVA: 0x000E5C30 File Offset: 0x000E3E30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 116571, XrefRangeEnd = 116572, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Contract.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060024CD RID: 9421 RVA: 0x000E5C6C File Offset: 0x000E3E6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 116572, XrefRangeEnd = 116601, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void InitializeContract(string title, string description, Il2CppReferenceArray<QuestEntryData> entries, string guid, NetworkObject customer, float payment, ProductList products, string deliveryLocationGUID, QuestWindowConfig deliveryWindow, int pickupScheduleIndex, GameDateTime acceptTime)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)11) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(title);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(description);
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(entries);
			ptr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(guid);
			ptr[checked(unchecked((System.UIntPtr)4) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(customer);
			ptr[checked(unchecked((System.UIntPtr)5) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref payment;
			ptr[checked(unchecked((System.UIntPtr)6) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(products);
			ptr[checked(unchecked((System.UIntPtr)7) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(deliveryLocationGUID);
			ptr[checked(unchecked((System.UIntPtr)8) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(deliveryWindow);
			ptr[checked(unchecked((System.UIntPtr)9) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref pickupScheduleIndex;
			ptr[checked(unchecked((System.UIntPtr)10) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref acceptTime;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Contract.NativeMethodInfoPtr_InitializeContract_Public_Virtual_New_Void_String_String_Il2CppReferenceArray_1_QuestEntryData_String_NetworkObject_Single_ProductList_String_QuestWindowConfig_Int32_GameDateTime_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060024CE RID: 9422 RVA: 0x000E5D6C File Offset: 0x000E3F6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 116601, XrefRangeEnd = 116616, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SilentlyInitializeContract(string title, string description, Il2CppReferenceArray<QuestEntryData> entries, string guid, NetworkObject customer, float payment, ProductList products, string deliveryLocationGUID, QuestWindowConfig deliveryWindow, int pickupScheduleIndex, GameDateTime acceptTime)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)11) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(title);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(description);
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(entries);
			ptr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(guid);
			ptr[checked(unchecked((System.UIntPtr)4) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(customer);
			ptr[checked(unchecked((System.UIntPtr)5) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref payment;
			ptr[checked(unchecked((System.UIntPtr)6) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(products);
			ptr[checked(unchecked((System.UIntPtr)7) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(deliveryLocationGUID);
			ptr[checked(unchecked((System.UIntPtr)8) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(deliveryWindow);
			ptr[checked(unchecked((System.UIntPtr)9) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref pickupScheduleIndex;
			ptr[checked(unchecked((System.UIntPtr)10) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref acceptTime;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Contract.NativeMethodInfoPtr_SilentlyInitializeContract_Public_Virtual_New_Void_String_String_Il2CppReferenceArray_1_QuestEntryData_String_NetworkObject_Single_ProductList_String_QuestWindowConfig_Int32_GameDateTime_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060024CF RID: 9423 RVA: 0x000E5E6C File Offset: 0x000E406C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 116616, XrefRangeEnd = 116629, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void MinPass()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Contract.NativeMethodInfoPtr_MinPass_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060024D0 RID: 9424 RVA: 0x000E5EA8 File Offset: 0x000E40A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 116629, XrefRangeEnd = 116637, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Contract.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060024D1 RID: 9425 RVA: 0x000E5EDC File Offset: 0x000E40DC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 116690, RefRangeEnd = 116691, XrefRangeStart = 116637, XrefRangeEnd = 116690, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateTiming()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Contract.NativeMethodInfoPtr_UpdateTiming_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060024D2 RID: 9426 RVA: 0x000E5F10 File Offset: 0x000E4110
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 116691, XrefRangeEnd = 116706, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void End()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Contract.NativeMethodInfoPtr_End_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060024D3 RID: 9427 RVA: 0x000E5F4C File Offset: 0x000E414C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 116706, XrefRangeEnd = 116721, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Complete(bool network = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref network;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Contract.NativeMethodInfoPtr_Complete_Public_Virtual_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060024D4 RID: 9428 RVA: 0x000E5F98 File Offset: 0x000E4198
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 116728, RefRangeEnd = 116733, XrefRangeStart = 116721, XrefRangeEnd = 116728, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetDealer(Dealer dealer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(dealer);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Contract.NativeMethodInfoPtr_SetDealer_Public_Void_Dealer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060024D5 RID: 9429 RVA: 0x000E5FDC File Offset: 0x000E41DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 116733, XrefRangeEnd = 116738, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SubmitPayment(float bonusTotal)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref bonusTotal;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Contract.NativeMethodInfoPtr_SubmitPayment_Public_Virtual_New_Void_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060024D6 RID: 9430 RVA: 0x000E6028 File Offset: 0x000E4228
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 116738, XrefRangeEnd = 116749, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void SendExpiryReminder()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Contract.NativeMethodInfoPtr_SendExpiryReminder_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060024D7 RID: 9431 RVA: 0x000E6064 File Offset: 0x000E4264
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 116749, XrefRangeEnd = 116760, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void SendExpiredNotification()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Contract.NativeMethodInfoPtr_SendExpiredNotification_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060024D8 RID: 9432 RVA: 0x000E60A0 File Offset: 0x000E42A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 116760, XrefRangeEnd = 116764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool ShouldShowJournalEntry()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Contract.NativeMethodInfoPtr_ShouldShowJournalEntry_Protected_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x060024D9 RID: 9433 RVA: 0x000E60E8 File Offset: 0x000E42E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 116764, XrefRangeEnd = 116775, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool CanExpire()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Contract.NativeMethodInfoPtr_CanExpire_Protected_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x060024DA RID: 9434 RVA: 0x000E6130 File Offset: 0x000E4330
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 116775, XrefRangeEnd = 116847, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool DoesProductListMatchSpecified(List<ItemInstance> items, bool enforceQuality)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(items);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref enforceQuality;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Contract.NativeMethodInfoPtr_DoesProductListMatchSpecified_Public_Boolean_List_1_ItemInstance_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x060024DB RID: 9435 RVA: 0x000E618C File Offset: 0x000E438C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 116950, RefRangeEnd = 116952, XrefRangeStart = 116847, XrefRangeEnd = 116950, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float GetProductListMatch(List<ItemInstance> items, out int matchedProductCount)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(items);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = &matchedProductCount;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Contract.NativeMethodInfoPtr_GetProductListMatch_Public_Single_List_1_ItemInstance_byref_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x060024DC RID: 9436 RVA: 0x000E61E8 File Offset: 0x000E43E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 116952, XrefRangeEnd = 116992, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override SaveData GetSaveData()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Contract.NativeMethodInfoPtr_GetSaveData_Public_Virtual_SaveData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<SaveData>(intPtr2) : null;
		}

		// Token: 0x060024DD RID: 9437 RVA: 0x000E6234 File Offset: 0x000E4434
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 116992, XrefRangeEnd = 116997, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe bool ShouldSave()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Contract.NativeMethodInfoPtr_ShouldSave_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x060024DE RID: 9438 RVA: 0x000E6270 File Offset: 0x000E4470
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 117029, RefRangeEnd = 117031, XrefRangeStart = 116997, XrefRangeEnd = 117029, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Contract() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Contract>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Contract.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060024DF RID: 9439 RVA: 0x000148A3 File Offset: 0x00012AA3
		public Contract(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000C99 RID: 3225
		// (get) Token: 0x060024E0 RID: 9440 RVA: 0x000E62AC File Offset: 0x000E44AC
		// (set) Token: 0x060024E1 RID: 9441 RVA: 0x000148AC File Offset: 0x00012AAC
		public unsafe static int DefaultExpiryTime
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(Contract.NativeFieldInfoPtr_DefaultExpiryTime, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Contract.NativeFieldInfoPtr_DefaultExpiryTime, (void*)(&value));
			}
		}

		// Token: 0x17000C9A RID: 3226
		// (get) Token: 0x060024E2 RID: 9442 RVA: 0x000E62C8 File Offset: 0x000E44C8
		// (set) Token: 0x060024E3 RID: 9443 RVA: 0x000148BA File Offset: 0x00012ABA
		public unsafe static List<Contract> Contracts
		{
			get
			{
				System.IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Contract.NativeFieldInfoPtr_Contracts, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Contract>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Contract.NativeFieldInfoPtr_Contracts, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C9B RID: 3227
		// (get) Token: 0x060024E4 RID: 9444 RVA: 0x000E62F0 File Offset: 0x000E44F0
		// (set) Token: 0x060024E5 RID: 9445 RVA: 0x000148CC File Offset: 0x00012ACC
		public unsafe NetworkObject _Customer_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Contract.NativeFieldInfoPtr__Customer_k__BackingField);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NetworkObject>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Contract.NativeFieldInfoPtr__Customer_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C9C RID: 3228
		// (get) Token: 0x060024E6 RID: 9446 RVA: 0x000E6320 File Offset: 0x000E4520
		// (set) Token: 0x060024E7 RID: 9447 RVA: 0x000148EB File Offset: 0x00012AEB
		public unsafe Dealer _Dealer_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Contract.NativeFieldInfoPtr__Dealer_k__BackingField);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dealer>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Contract.NativeFieldInfoPtr__Dealer_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C9D RID: 3229
		// (get) Token: 0x060024E8 RID: 9448 RVA: 0x000E6350 File Offset: 0x000E4550
		// (set) Token: 0x060024E9 RID: 9449 RVA: 0x0001490A File Offset: 0x00012B0A
		public unsafe float _Payment_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Contract.NativeFieldInfoPtr__Payment_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Contract.NativeFieldInfoPtr__Payment_k__BackingField)) = value;
			}
		}

		// Token: 0x17000C9E RID: 3230
		// (get) Token: 0x060024EA RID: 9450 RVA: 0x000E6378 File Offset: 0x000E4578
		// (set) Token: 0x060024EB RID: 9451 RVA: 0x00014925 File Offset: 0x00012B25
		public unsafe ProductList ProductList
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Contract.NativeFieldInfoPtr_ProductList);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ProductList>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Contract.NativeFieldInfoPtr_ProductList), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C9F RID: 3231
		// (get) Token: 0x060024EC RID: 9452 RVA: 0x000E63A8 File Offset: 0x000E45A8
		// (set) Token: 0x060024ED RID: 9453 RVA: 0x00014944 File Offset: 0x00012B44
		public unsafe DeliveryLocation DeliveryLocation
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Contract.NativeFieldInfoPtr_DeliveryLocation);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DeliveryLocation>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Contract.NativeFieldInfoPtr_DeliveryLocation), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CA0 RID: 3232
		// (get) Token: 0x060024EE RID: 9454 RVA: 0x000E63D8 File Offset: 0x000E45D8
		// (set) Token: 0x060024EF RID: 9455 RVA: 0x00014963 File Offset: 0x00012B63
		public unsafe QuestWindowConfig DeliveryWindow
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Contract.NativeFieldInfoPtr_DeliveryWindow);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<QuestWindowConfig>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Contract.NativeFieldInfoPtr_DeliveryWindow), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CA1 RID: 3233
		// (get) Token: 0x060024F0 RID: 9456 RVA: 0x000E6408 File Offset: 0x000E4608
		// (set) Token: 0x060024F1 RID: 9457 RVA: 0x00014982 File Offset: 0x00012B82
		public unsafe int _PickupScheduleIndex_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Contract.NativeFieldInfoPtr__PickupScheduleIndex_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Contract.NativeFieldInfoPtr__PickupScheduleIndex_k__BackingField)) = value;
			}
		}

		// Token: 0x17000CA2 RID: 3234
		// (get) Token: 0x060024F2 RID: 9458 RVA: 0x000E6430 File Offset: 0x000E4630
		// (set) Token: 0x060024F3 RID: 9459 RVA: 0x0001499D File Offset: 0x00012B9D
		public unsafe GameDateTime _AcceptTime_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Contract.NativeFieldInfoPtr__AcceptTime_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Contract.NativeFieldInfoPtr__AcceptTime_k__BackingField)) = value;
			}
		}

		// Token: 0x17000CA3 RID: 3235
		// (get) Token: 0x060024F4 RID: 9460 RVA: 0x000E6458 File Offset: 0x000E4658
		// (set) Token: 0x060024F5 RID: 9461 RVA: 0x000149B8 File Offset: 0x00012BB8
		public unsafe bool completedContractsIncremented
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Contract.NativeFieldInfoPtr_completedContractsIncremented);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Contract.NativeFieldInfoPtr_completedContractsIncremented)) = value;
			}
		}

		// Token: 0x04001857 RID: 6231
		private static readonly System.IntPtr NativeFieldInfoPtr_DefaultExpiryTime;

		// Token: 0x04001858 RID: 6232
		private static readonly System.IntPtr NativeFieldInfoPtr_Contracts;

		// Token: 0x04001859 RID: 6233
		private static readonly System.IntPtr NativeFieldInfoPtr__Customer_k__BackingField;

		// Token: 0x0400185A RID: 6234
		private static readonly System.IntPtr NativeFieldInfoPtr__Dealer_k__BackingField;

		// Token: 0x0400185B RID: 6235
		private static readonly System.IntPtr NativeFieldInfoPtr__Payment_k__BackingField;

		// Token: 0x0400185C RID: 6236
		private static readonly System.IntPtr NativeFieldInfoPtr_ProductList;

		// Token: 0x0400185D RID: 6237
		private static readonly System.IntPtr NativeFieldInfoPtr_DeliveryLocation;

		// Token: 0x0400185E RID: 6238
		private static readonly System.IntPtr NativeFieldInfoPtr_DeliveryWindow;

		// Token: 0x0400185F RID: 6239
		private static readonly System.IntPtr NativeFieldInfoPtr__PickupScheduleIndex_k__BackingField;

		// Token: 0x04001860 RID: 6240
		private static readonly System.IntPtr NativeFieldInfoPtr__AcceptTime_k__BackingField;

		// Token: 0x04001861 RID: 6241
		private static readonly System.IntPtr NativeFieldInfoPtr_completedContractsIncremented;

		// Token: 0x04001862 RID: 6242
		private static readonly System.IntPtr NativeMethodInfoPtr_get_Customer_Public_get_NetworkObject_0;

		// Token: 0x04001863 RID: 6243
		private static readonly System.IntPtr NativeMethodInfoPtr_set_Customer_Protected_set_Void_NetworkObject_0;

		// Token: 0x04001864 RID: 6244
		private static readonly System.IntPtr NativeMethodInfoPtr_get_Dealer_Public_get_Dealer_0;

		// Token: 0x04001865 RID: 6245
		private static readonly System.IntPtr NativeMethodInfoPtr_set_Dealer_Protected_set_Void_Dealer_0;

		// Token: 0x04001866 RID: 6246
		private static readonly System.IntPtr NativeMethodInfoPtr_get_Payment_Public_get_Single_0;

		// Token: 0x04001867 RID: 6247
		private static readonly System.IntPtr NativeMethodInfoPtr_set_Payment_Protected_set_Void_Single_0;

		// Token: 0x04001868 RID: 6248
		private static readonly System.IntPtr NativeMethodInfoPtr_get_PickupScheduleIndex_Public_get_Int32_0;

		// Token: 0x04001869 RID: 6249
		private static readonly System.IntPtr NativeMethodInfoPtr_set_PickupScheduleIndex_Protected_set_Void_Int32_0;

		// Token: 0x0400186A RID: 6250
		private static readonly System.IntPtr NativeMethodInfoPtr_get_AcceptTime_Public_get_GameDateTime_0;

		// Token: 0x0400186B RID: 6251
		private static readonly System.IntPtr NativeMethodInfoPtr_set_AcceptTime_Protected_set_Void_GameDateTime_0;

		// Token: 0x0400186C RID: 6252
		private static readonly System.IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x0400186D RID: 6253
		private static readonly System.IntPtr NativeMethodInfoPtr_InitializeContract_Public_Virtual_New_Void_String_String_Il2CppReferenceArray_1_QuestEntryData_String_NetworkObject_Single_ProductList_String_QuestWindowConfig_Int32_GameDateTime_0;

		// Token: 0x0400186E RID: 6254
		private static readonly System.IntPtr NativeMethodInfoPtr_SilentlyInitializeContract_Public_Virtual_New_Void_String_String_Il2CppReferenceArray_1_QuestEntryData_String_NetworkObject_Single_ProductList_String_QuestWindowConfig_Int32_GameDateTime_0;

		// Token: 0x0400186F RID: 6255
		private static readonly System.IntPtr NativeMethodInfoPtr_MinPass_Protected_Virtual_Void_0;

		// Token: 0x04001870 RID: 6256
		private static readonly System.IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

		// Token: 0x04001871 RID: 6257
		private static readonly System.IntPtr NativeMethodInfoPtr_UpdateTiming_Private_Void_0;

		// Token: 0x04001872 RID: 6258
		private static readonly System.IntPtr NativeMethodInfoPtr_End_Public_Virtual_Void_0;

		// Token: 0x04001873 RID: 6259
		private static readonly System.IntPtr NativeMethodInfoPtr_Complete_Public_Virtual_Void_Boolean_0;

		// Token: 0x04001874 RID: 6260
		private static readonly System.IntPtr NativeMethodInfoPtr_SetDealer_Public_Void_Dealer_0;

		// Token: 0x04001875 RID: 6261
		private static readonly System.IntPtr NativeMethodInfoPtr_SubmitPayment_Public_Virtual_New_Void_Single_0;

		// Token: 0x04001876 RID: 6262
		private static readonly System.IntPtr NativeMethodInfoPtr_SendExpiryReminder_Protected_Virtual_Void_0;

		// Token: 0x04001877 RID: 6263
		private static readonly System.IntPtr NativeMethodInfoPtr_SendExpiredNotification_Protected_Virtual_Void_0;

		// Token: 0x04001878 RID: 6264
		private static readonly System.IntPtr NativeMethodInfoPtr_ShouldShowJournalEntry_Protected_Virtual_Boolean_0;

		// Token: 0x04001879 RID: 6265
		private static readonly System.IntPtr NativeMethodInfoPtr_CanExpire_Protected_Virtual_Boolean_0;

		// Token: 0x0400187A RID: 6266
		private static readonly System.IntPtr NativeMethodInfoPtr_DoesProductListMatchSpecified_Public_Boolean_List_1_ItemInstance_Boolean_0;

		// Token: 0x0400187B RID: 6267
		private static readonly System.IntPtr NativeMethodInfoPtr_GetProductListMatch_Public_Single_List_1_ItemInstance_byref_Int32_0;

		// Token: 0x0400187C RID: 6268
		private static readonly System.IntPtr NativeMethodInfoPtr_GetSaveData_Public_Virtual_SaveData_0;

		// Token: 0x0400187D RID: 6269
		private static readonly System.IntPtr NativeMethodInfoPtr_ShouldSave_Public_Boolean_0;

		// Token: 0x0400187E RID: 6270
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020008FB RID: 2299
		public class BonusPayment : Il2CppSystem.Object
		{
			// Token: 0x0600C842 RID: 51266 RVA: 0x0030F8D4 File Offset: 0x0030DAD4
			// Note: this type is marked as 'beforefieldinit'.
			static BonusPayment()
			{
				Il2CppClassPointerStore<Contract.BonusPayment>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Contract>.NativeClassPtr, "BonusPayment");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Contract.BonusPayment>.NativeClassPtr);
				Contract.BonusPayment.NativeFieldInfoPtr_Title = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Contract.BonusPayment>.NativeClassPtr, "Title");
				Contract.BonusPayment.NativeFieldInfoPtr_Amount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Contract.BonusPayment>.NativeClassPtr, "Amount");
				Contract.BonusPayment.NativeMethodInfoPtr__ctor_Public_Void_String_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Contract.BonusPayment>.NativeClassPtr, 100667427);
			}

			// Token: 0x0600C843 RID: 51267 RVA: 0x0030F93C File Offset: 0x0030DB3C
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 116558, RefRangeEnd = 116561, XrefRangeStart = 116556, XrefRangeEnd = 116558, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe BonusPayment(string title, float amount) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Contract.BonusPayment>.NativeClassPtr))
			{
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(title);
				ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref amount;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Contract.BonusPayment.NativeMethodInfoPtr__ctor_Public_Void_String_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600C844 RID: 51268 RVA: 0x000611EA File Offset: 0x0005F3EA
			public BonusPayment(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003E3C RID: 15932
			// (get) Token: 0x0600C845 RID: 51269 RVA: 0x0030F998 File Offset: 0x0030DB98
			// (set) Token: 0x0600C846 RID: 51270 RVA: 0x000611F3 File Offset: 0x0005F3F3
			public unsafe string Title
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Contract.BonusPayment.NativeFieldInfoPtr_Title);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Contract.BonusPayment.NativeFieldInfoPtr_Title), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17003E3D RID: 15933
			// (get) Token: 0x0600C847 RID: 51271 RVA: 0x0030F9C0 File Offset: 0x0030DBC0
			// (set) Token: 0x0600C848 RID: 51272 RVA: 0x00061212 File Offset: 0x0005F412
			public unsafe float Amount
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Contract.BonusPayment.NativeFieldInfoPtr_Amount);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Contract.BonusPayment.NativeFieldInfoPtr_Amount)) = value;
				}
			}

			// Token: 0x040087DA RID: 34778
			private static readonly System.IntPtr NativeFieldInfoPtr_Title;

			// Token: 0x040087DB RID: 34779
			private static readonly System.IntPtr NativeFieldInfoPtr_Amount;

			// Token: 0x040087DC RID: 34780
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Single_0;
		}

		// Token: 0x020008FC RID: 2300
		[ObfuscatedName("ScheduleOne.Quests.Contract+<>c__DisplayClass41_0")]
		public sealed class __c__DisplayClass41_0 : Il2CppSystem.Object
		{
			// Token: 0x0600C849 RID: 51273 RVA: 0x0030F9E8 File Offset: 0x0030DBE8
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass41_0()
			{
				Il2CppClassPointerStore<Contract.__c__DisplayClass41_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Contract>.NativeClassPtr, "<>c__DisplayClass41_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Contract.__c__DisplayClass41_0>.NativeClassPtr);
				Contract.__c__DisplayClass41_0.NativeFieldInfoPtr_entry = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Contract.__c__DisplayClass41_0>.NativeClassPtr, "entry");
				Contract.__c__DisplayClass41_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Contract.__c__DisplayClass41_0>.NativeClassPtr, 100667428);
				Contract.__c__DisplayClass41_0.NativeMethodInfoPtr__DoesProductListMatchSpecified_b__0_Internal_Boolean_ItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Contract.__c__DisplayClass41_0>.NativeClassPtr, 100667429);
			}

			// Token: 0x0600C84A RID: 51274 RVA: 0x0030FA50 File Offset: 0x0030DC50
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass41_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Contract.__c__DisplayClass41_0>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Contract.__c__DisplayClass41_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600C84B RID: 51275 RVA: 0x0030FA8C File Offset: 0x0030DC8C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 116561, XrefRangeEnd = 116563, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _DoesProductListMatchSpecified_b__0(ItemInstance x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Contract.__c__DisplayClass41_0.NativeMethodInfoPtr__DoesProductListMatchSpecified_b__0_Internal_Boolean_ItemInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x0600C84C RID: 51276 RVA: 0x0006122D File Offset: 0x0005F42D
			public __c__DisplayClass41_0(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003E3E RID: 15934
			// (get) Token: 0x0600C84D RID: 51277 RVA: 0x0030FADC File Offset: 0x0030DCDC
			// (set) Token: 0x0600C84E RID: 51278 RVA: 0x00061236 File Offset: 0x0005F436
			public unsafe ProductList.Entry entry
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Contract.__c__DisplayClass41_0.NativeFieldInfoPtr_entry);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ProductList.Entry>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Contract.__c__DisplayClass41_0.NativeFieldInfoPtr_entry), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040087DD RID: 34781
			private static readonly System.IntPtr NativeFieldInfoPtr_entry;

			// Token: 0x040087DE RID: 34782
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040087DF RID: 34783
			private static readonly System.IntPtr NativeMethodInfoPtr__DoesProductListMatchSpecified_b__0_Internal_Boolean_ItemInstance_0;
		}

		// Token: 0x020008FD RID: 2301
		[ObfuscatedName("ScheduleOne.Quests.Contract+<>c__DisplayClass42_0")]
		public sealed class __c__DisplayClass42_0 : Il2CppSystem.Object
		{
			// Token: 0x0600C84F RID: 51279 RVA: 0x0030FB0C File Offset: 0x0030DD0C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass42_0()
			{
				Il2CppClassPointerStore<Contract.__c__DisplayClass42_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Contract>.NativeClassPtr, "<>c__DisplayClass42_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Contract.__c__DisplayClass42_0>.NativeClassPtr);
				Contract.__c__DisplayClass42_0.NativeFieldInfoPtr_matchRatings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Contract.__c__DisplayClass42_0>.NativeClassPtr, "matchRatings");
				Contract.__c__DisplayClass42_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Contract.__c__DisplayClass42_0>.NativeClassPtr, 100667430);
				Contract.__c__DisplayClass42_0.NativeMethodInfoPtr__GetProductListMatch_b__0_Internal_Int32_ProductItemInstance_ProductItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Contract.__c__DisplayClass42_0>.NativeClassPtr, 100667431);
			}

			// Token: 0x0600C850 RID: 51280 RVA: 0x0030FB74 File Offset: 0x0030DD74
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass42_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Contract.__c__DisplayClass42_0>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Contract.__c__DisplayClass42_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600C851 RID: 51281 RVA: 0x0030FBB0 File Offset: 0x0030DDB0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 116563, XrefRangeEnd = 116569, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _GetProductListMatch_b__0(ProductItemInstance x, ProductItemInstance y)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(y);
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Contract.__c__DisplayClass42_0.NativeMethodInfoPtr__GetProductListMatch_b__0_Internal_Int32_ProductItemInstance_ProductItemInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x0600C852 RID: 51282 RVA: 0x00061255 File Offset: 0x0005F455
			public __c__DisplayClass42_0(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003E3F RID: 15935
			// (get) Token: 0x0600C853 RID: 51283 RVA: 0x0030FC10 File Offset: 0x0030DE10
			// (set) Token: 0x0600C854 RID: 51284 RVA: 0x0006125E File Offset: 0x0005F45E
			public unsafe Dictionary<ProductItemInstance, float> matchRatings
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Contract.__c__DisplayClass42_0.NativeFieldInfoPtr_matchRatings);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<ProductItemInstance, float>>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Contract.__c__DisplayClass42_0.NativeFieldInfoPtr_matchRatings), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040087E0 RID: 34784
			private static readonly System.IntPtr NativeFieldInfoPtr_matchRatings;

			// Token: 0x040087E1 RID: 34785
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040087E2 RID: 34786
			private static readonly System.IntPtr NativeMethodInfoPtr__GetProductListMatch_b__0_Internal_Int32_ProductItemInstance_ProductItemInstance_0;
		}
	}
}
