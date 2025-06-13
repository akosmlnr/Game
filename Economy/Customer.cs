using System;
using Il2CppFishNet.Connection;
using Il2CppFishNet.Object;
using Il2CppFishNet.Object.Synchronizing;
using Il2CppFishNet.Serializing;
using Il2CppFishNet.Transporting;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Dialogue;
using Il2CppScheduleOne.GameTime;
using Il2CppScheduleOne.ItemFramework;
using Il2CppScheduleOne.Map;
using Il2CppScheduleOne.NPCs;
using Il2CppScheduleOne.NPCs.Relation;
using Il2CppScheduleOne.NPCs.Schedules;
using Il2CppScheduleOne.Persistence.Datas;
using Il2CppScheduleOne.Persistence.Loaders;
using Il2CppScheduleOne.PlayerScripts;
using Il2CppScheduleOne.Product;
using Il2CppScheduleOne.Properties;
using Il2CppScheduleOne.Quests;
using Il2CppScheduleOne.UI.Handover;
using Il2CppScheduleOne.UI.Phone.Messages;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace Il2CppScheduleOne.Economy
{
	// Token: 0x0200042E RID: 1070
	public class Customer : NetworkBehaviour
	{
		// Token: 0x06005A8F RID: 23183 RVA: 0x001A75E8 File Offset: 0x001A57E8
		// Note: this type is marked as 'beforefieldinit'.
		static Customer()
		{
			Il2CppClassPointerStore<Customer>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Economy", "Customer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Customer>.NativeClassPtr);
			Customer.NativeFieldInfoPtr_onCustomerUnlocked = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Customer>.NativeClassPtr, "onCustomerUnlocked");
			Customer.NativeFieldInfoPtr_UnlockedCustomers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Customer>.NativeClassPtr, "UnlockedCustomers");
			Customer.NativeFieldInfoPtr_AFFINITY_MAX_EFFECT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Customer>.NativeClassPtr, "AFFINITY_MAX_EFFECT");
			Customer.NativeFieldInfoPtr_PROPERTY_MAX_EFFECT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Customer>.NativeClassPtr, "PROPERTY_MAX_EFFECT");
			Customer.NativeFieldInfoPtr_QUALITY_MAX_EFFECT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Customer>.NativeClassPtr, "QUALITY_MAX_EFFECT");
			Customer.NativeFieldInfoPtr_DEAL_REJECTED_RELATIONSHIP_CHANGE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Customer>.NativeClassPtr, "DEAL_REJECTED_RELATIONSHIP_CHANGE");
			Customer.NativeFieldInfoPtr_DEBUG = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Customer>.NativeClassPtr, "DEBUG");
			Customer.NativeFieldInfoPtr_APPROACH_MIN_ADDICTION = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Customer>.NativeClassPtr, "APPROACH_MIN_ADDICTION");
			Customer.NativeFieldInfoPtr_APPROACH_CHANCE_PER_DAY_MAX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Customer>.NativeClassPtr, "APPROACH_CHANCE_PER_DAY_MAX");
			Customer.NativeFieldInfoPtr_APPROACH_MIN_COOLDOWN = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Customer>.NativeClassPtr, "APPROACH_MIN_COOLDOWN");
			Customer.NativeFieldInfoPtr_APPROACH_MAX_COOLDOWN = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Customer>.NativeClassPtr, "APPROACH_MAX_COOLDOWN");
			Customer.NativeFieldInfoPtr_DEAL_COOLDOWN = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Customer>.NativeClassPtr, "DEAL_COOLDOWN");
			Customer.NativeFieldInfoPtr_PlayerAcceptMessages = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Customer>.NativeClassPtr, "PlayerAcceptMessages");
			Customer.NativeFieldInfoPtr_PlayerRejectMessages = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Customer>.NativeClassPtr, "PlayerRejectMessages");
			Customer.NativeFieldInfoPtr_DEAL_ATTENDANCE_TOLERANCE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Customer>.NativeClassPtr, "DEAL_ATTENDANCE_TOLERANCE");
			Customer.NativeFieldInfoPtr_MIN_TRAVEL_TIME = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Customer>.NativeClassPtr, "MIN_TRAVEL_TIME");
			Customer.NativeFieldInfoPtr_MAX_TRAVEL_TIME = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Customer>.NativeClassPtr, "MAX_TRAVEL_TIME");
			Customer.NativeFieldInfoPtr_OFFER_EXPIRY_TIME_MINS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Customer>.NativeClassPtr, "OFFER_EXPIRY_TIME_MINS");
			Customer.NativeFieldInfoPtr_MIN_ORDER_APPEAL = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Customer>.NativeClassPtr, "MIN_ORDER_APPEAL");
			Customer.NativeFieldInfoPtr_ADDICTION_DRAIN_PER_DAY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Customer>.NativeClassPtr, "ADDICTION_DRAIN_PER_DAY");
			Customer.NativeFieldInfoPtr_SAMPLE_REQUIRES_RECOMMENDATION = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Customer>.NativeClassPtr, "SAMPLE_REQUIRES_RECOMMENDATION");
			Customer.NativeFieldInfoPtr_MIN_NORMALIZED_RELATIONSHIP_FOR_RECOMMENDATION = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Customer>.NativeClassPtr, "MIN_NORMALIZED_RELATIONSHIP_FOR_RECOMMENDATION");
			Customer.NativeFieldInfoPtr_RELATIONSHIP_FOR_GUARANTEED_DEALER_RECOMMENDATION = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Customer>.NativeClassPtr, "RELATIONSHIP_FOR_GUARANTEED_DEALER_RECOMMENDATION");
			Customer.NativeFieldInfoPtr_RELATIONSHIP_FOR_GUARANTEED_SUPPLIER_RECOMMENDATION = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Customer>.NativeClassPtr, "RELATIONSHIP_FOR_GUARANTEED_SUPPLIER_RECOMMENDATION");
			Customer.NativeFieldInfoPtr__CurrentAddiction_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Customer>.NativeClassPtr, "<CurrentAddiction>k__BackingField");
			Customer.NativeFieldInfoPtr_offeredContractInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Customer>.NativeClassPtr, "offeredContractInfo");
			Customer.NativeFieldInfoPtr__OfferedContractTime_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Customer>.NativeClassPtr, "<OfferedContractTime>k__BackingField");
			Customer.NativeFieldInfoPtr__CurrentContract_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Customer>.NativeClassPtr, "<CurrentContract>k__BackingField");
			Customer.NativeFieldInfoPtr__IsAwaitingDelivery_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Customer>.NativeClassPtr, "<IsAwaitingDelivery>k__BackingField");
			Customer.NativeFieldInfoPtr__TimeSinceLastDealCompleted_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Customer>.NativeClassPtr, "<TimeSinceLastDealCompleted>k__BackingField");
			Customer.NativeFieldInfoPtr__TimeSinceLastDealOffered_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Customer>.NativeClassPtr, "<TimeSinceLastDealOffered>k__BackingField");
			Customer.NativeFieldInfoPtr__TimeSincePlayerApproached_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Customer>.NativeClassPtr, "<TimeSincePlayerApproached>k__BackingField");
			Customer.NativeFieldInfoPtr__TimeSinceInstantDealOffered_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Customer>.NativeClassPtr, "<TimeSinceInstantDealOffered>k__BackingField");
			Customer.NativeFieldInfoPtr__OfferedDeals_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Customer>.NativeClassPtr, "<OfferedDeals>k__BackingField");
			Customer.NativeFieldInfoPtr__CompletedDeliveries_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Customer>.NativeClassPtr, "<CompletedDeliveries>k__BackingField");
			Customer.NativeFieldInfoPtr__HasBeenRecommended_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Customer>.NativeClassPtr, "<HasBeenRecommended>k__BackingField");
			Customer.NativeFieldInfoPtr__NPC_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Customer>.NativeClassPtr, "<NPC>k__BackingField");
			Customer.NativeFieldInfoPtr__AssignedDealer_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Customer>.NativeClassPtr, "<AssignedDealer>k__BackingField");
			Customer.NativeFieldInfoPtr_DealSignal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Customer>.NativeClassPtr, "DealSignal");
			Customer.NativeFieldInfoPtr_AvailableInDemo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Customer>.NativeClassPtr, "AvailableInDemo");
			Customer.NativeFieldInfoPtr_customerData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Customer>.NativeClassPtr, "customerData");
			Customer.NativeFieldInfoPtr_DefaultDeliveryLocation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Customer>.NativeClassPtr, "DefaultDeliveryLocation");
			Customer.NativeFieldInfoPtr_CanRecommendFriends = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Customer>.NativeClassPtr, "CanRecommendFriends");
			Customer.NativeFieldInfoPtr_onUnlocked = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Customer>.NativeClassPtr, "onUnlocked");
			Customer.NativeFieldInfoPtr_onDealCompleted = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Customer>.NativeClassPtr, "onDealCompleted");
			Customer.NativeFieldInfoPtr_onContractAssigned = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Customer>.NativeClassPtr, "onContractAssigned");
			Customer.NativeFieldInfoPtr_awaitingSample = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Customer>.NativeClassPtr, "awaitingSample");
			Customer.NativeFieldInfoPtr_sampleChoice = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Customer>.NativeClassPtr, "sampleChoice");
			Customer.NativeFieldInfoPtr_completeContractChoice = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Customer>.NativeClassPtr, "completeContractChoice");
			Customer.NativeFieldInfoPtr_offerDealChoice = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Customer>.NativeClassPtr, "offerDealChoice");
			Customer.NativeFieldInfoPtr_awaitingDealGreeting = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Customer>.NativeClassPtr, "awaitingDealGreeting");
			Customer.NativeFieldInfoPtr_minsSinceUnlocked = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Customer>.NativeClassPtr, "minsSinceUnlocked");
			Customer.NativeFieldInfoPtr_sampleOfferedToday = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Customer>.NativeClassPtr, "sampleOfferedToday");
			Customer.NativeFieldInfoPtr__potentialCustomerPoI_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Customer>.NativeClassPtr, "<potentialCustomerPoI>k__BackingField");
			Customer.NativeFieldInfoPtr_currentAffinityData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Customer>.NativeClassPtr, "currentAffinityData");
			Customer.NativeFieldInfoPtr_pendingInstantDeal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Customer>.NativeClassPtr, "pendingInstantDeal");
			Customer.NativeFieldInfoPtr__LocalExtraFiles_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Customer>.NativeClassPtr, "<LocalExtraFiles>k__BackingField");
			Customer.NativeFieldInfoPtr__LocalExtraFolders_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Customer>.NativeClassPtr, "<LocalExtraFolders>k__BackingField");
			Customer.NativeFieldInfoPtr__HasChanged_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Customer>.NativeClassPtr, "<HasChanged>k__BackingField");
			Customer.NativeFieldInfoPtr_consumedSample = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Customer>.NativeClassPtr, "consumedSample");
			Customer.NativeFieldInfoPtr_syncVar____CurrentAddiction_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Customer>.NativeClassPtr, "syncVar___<CurrentAddiction>k__BackingField");
			Customer.NativeFieldInfoPtr_syncVar____HasBeenRecommended_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Customer>.NativeClassPtr, "syncVar___<HasBeenRecommended>k__BackingField");
			Customer.NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Customer>.NativeClassPtr, "NetworkInitialize___EarlyScheduleOne.Economy.CustomerAssembly-CSharp.dll_Excuted");
			Customer.NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Customer>.NativeClassPtr, "NetworkInitialize__LateScheduleOne.Economy.CustomerAssembly-CSharp.dll_Excuted");
			Customer.NativeMethodInfoPtr_get_CurrentAddiction_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674817);
			Customer.NativeMethodInfoPtr_set_CurrentAddiction_Protected_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674818);
			Customer.NativeMethodInfoPtr_get_OfferedContractInfo_Public_get_ContractInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674819);
			Customer.NativeMethodInfoPtr_set_OfferedContractInfo_Protected_set_Void_ContractInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674820);
			Customer.NativeMethodInfoPtr_get_OfferedContractTime_Public_get_GameDateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674821);
			Customer.NativeMethodInfoPtr_set_OfferedContractTime_Protected_set_Void_GameDateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674822);
			Customer.NativeMethodInfoPtr_get_CurrentContract_Public_get_Contract_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674823);
			Customer.NativeMethodInfoPtr_set_CurrentContract_Protected_set_Void_Contract_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674824);
			Customer.NativeMethodInfoPtr_get_IsAwaitingDelivery_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674825);
			Customer.NativeMethodInfoPtr_set_IsAwaitingDelivery_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674826);
			Customer.NativeMethodInfoPtr_get_TimeSinceLastDealCompleted_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674827);
			Customer.NativeMethodInfoPtr_set_TimeSinceLastDealCompleted_Protected_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674828);
			Customer.NativeMethodInfoPtr_get_TimeSinceLastDealOffered_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674829);
			Customer.NativeMethodInfoPtr_set_TimeSinceLastDealOffered_Protected_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674830);
			Customer.NativeMethodInfoPtr_get_TimeSincePlayerApproached_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674831);
			Customer.NativeMethodInfoPtr_set_TimeSincePlayerApproached_Protected_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674832);
			Customer.NativeMethodInfoPtr_get_TimeSinceInstantDealOffered_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674833);
			Customer.NativeMethodInfoPtr_set_TimeSinceInstantDealOffered_Protected_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674834);
			Customer.NativeMethodInfoPtr_get_OfferedDeals_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674835);
			Customer.NativeMethodInfoPtr_set_OfferedDeals_Protected_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674836);
			Customer.NativeMethodInfoPtr_get_CompletedDeliveries_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674837);
			Customer.NativeMethodInfoPtr_set_CompletedDeliveries_Protected_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674838);
			Customer.NativeMethodInfoPtr_get_HasBeenRecommended_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674839);
			Customer.NativeMethodInfoPtr_set_HasBeenRecommended_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674840);
			Customer.NativeMethodInfoPtr_get_NPC_Public_get_NPC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674841);
			Customer.NativeMethodInfoPtr_set_NPC_Protected_set_Void_NPC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674842);
			Customer.NativeMethodInfoPtr_get_AssignedDealer_Public_get_Dealer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674843);
			Customer.NativeMethodInfoPtr_set_AssignedDealer_Protected_set_Void_Dealer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674844);
			Customer.NativeMethodInfoPtr_get_CustomerData_Public_get_CustomerData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674845);
			Customer.NativeMethodInfoPtr_get_OrderableProducts_Public_get_List_1_ProductDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674846);
			Customer.NativeMethodInfoPtr_get_dialogueDatabase_Private_get_DialogueDatabase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674847);
			Customer.NativeMethodInfoPtr_get_potentialCustomerPoI_Public_get_NPCPoI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674848);
			Customer.NativeMethodInfoPtr_set_potentialCustomerPoI_Private_set_Void_NPCPoI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674849);
			Customer.NativeMethodInfoPtr_get_SaveFolderName_Public_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674850);
			Customer.NativeMethodInfoPtr_get_SaveFileName_Public_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674851);
			Customer.NativeMethodInfoPtr_get_Loader_Public_Virtual_Final_New_get_Loader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674852);
			Customer.NativeMethodInfoPtr_get_ShouldSaveUnderFolder_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674853);
			Customer.NativeMethodInfoPtr_get_LocalExtraFiles_Public_Virtual_Final_New_get_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674854);
			Customer.NativeMethodInfoPtr_set_LocalExtraFiles_Public_Virtual_Final_New_set_Void_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674855);
			Customer.NativeMethodInfoPtr_get_LocalExtraFolders_Public_Virtual_Final_New_get_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674856);
			Customer.NativeMethodInfoPtr_set_LocalExtraFolders_Public_Virtual_Final_New_set_Void_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674857);
			Customer.NativeMethodInfoPtr_get_HasChanged_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674858);
			Customer.NativeMethodInfoPtr_set_HasChanged_Public_Virtual_Final_New_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674859);
			Customer.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674860);
			Customer.NativeMethodInfoPtr_OnValidate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674861);
			Customer.NativeMethodInfoPtr_Start_Private_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674862);
			Customer.NativeMethodInfoPtr_OnStartClient_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674863);
			Customer.NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674864);
			Customer.NativeMethodInfoPtr_OnDestroy_Private_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674865);
			Customer.NativeMethodInfoPtr_SetUpDialogue_Private_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674866);
			Customer.NativeMethodInfoPtr_SetupPoI_Private_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674867);
			Customer.NativeMethodInfoPtr_InitializeSaveable_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674868);
			Customer.NativeMethodInfoPtr_MinPass_Protected_Virtual_New_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674869);
			Customer.NativeMethodInfoPtr_DayPass_Protected_Virtual_New_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674870);
			Customer.NativeMethodInfoPtr_UpdateDealAttendance_Private_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674871);
			Customer.NativeMethodInfoPtr_ConfigureDealSignal_Private_Void_NetworkConnection_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674872);
			Customer.NativeMethodInfoPtr_UpdateOfferExpiry_Private_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674873);
			Customer.NativeMethodInfoPtr_CheckContractGeneration_Private_ContractInfo_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674874);
			Customer.NativeMethodInfoPtr_GetWeightedRandomProduct_Private_ProductDefinition_byref_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674875);
			Customer.NativeMethodInfoPtr_OnCustomerUnlocked_Protected_Virtual_New_Void_EUnlockType_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674876);
			Customer.NativeMethodInfoPtr_SetHasBeenRecommended_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674877);
			Customer.NativeMethodInfoPtr_OfferContract_Public_Virtual_New_Void_ContractInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674878);
			Customer.NativeMethodInfoPtr_SetOfferedContract_Private_Void_ContractInfo_GameDateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674879);
			Customer.NativeMethodInfoPtr_ExpireOffer_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674880);
			Customer.NativeMethodInfoPtr_AssignContract_Public_Virtual_New_Void_Contract_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674881);
			Customer.NativeMethodInfoPtr_NotifyPlayerOfContract_Protected_Virtual_New_Void_ContractInfo_MessageChain_Boolean_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674882);
			Customer.NativeMethodInfoPtr_SendSetUpResponseCallbacks_Private_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674883);
			Customer.NativeMethodInfoPtr_SetUpResponseCallbacks_Private_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674884);
			Customer.NativeMethodInfoPtr_AcceptContractClicked_Protected_Virtual_New_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674885);
			Customer.NativeMethodInfoPtr_CounterOfferClicked_Protected_Virtual_New_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674886);
			Customer.NativeMethodInfoPtr_SendCounteroffer_Protected_Virtual_New_Void_ProductDefinition_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674887);
			Customer.NativeMethodInfoPtr_ProcessCounterOfferServerSide_Private_Void_String_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674888);
			Customer.NativeMethodInfoPtr_SetContractIsCounterOffer_Private_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674889);
			Customer.NativeMethodInfoPtr_PlayerAcceptedContract_Protected_Virtual_New_Void_EDealWindow_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674890);
			Customer.NativeMethodInfoPtr_SendContractAccepted_Private_Void_EDealWindow_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674891);
			Customer.NativeMethodInfoPtr_ContractAccepted_Public_Virtual_New_String_EDealWindow_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674892);
			Customer.NativeMethodInfoPtr_ReceiveContractAccepted_Private_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674893);
			Customer.NativeMethodInfoPtr_PlayContractAcceptedReaction_Protected_Virtual_New_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674894);
			Customer.NativeMethodInfoPtr_EvaluateCounteroffer_Protected_Virtual_New_Boolean_ProductDefinition_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674895);
			Customer.NativeMethodInfoPtr_GetValueProposition_Public_Static_Single_ProductDefinition_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674896);
			Customer.NativeMethodInfoPtr_ContractRejected_Protected_Virtual_New_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674897);
			Customer.NativeMethodInfoPtr_ReceiveContractRejected_Private_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674898);
			Customer.NativeMethodInfoPtr_PlayContractRejectedReaction_Protected_Virtual_New_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674899);
			Customer.NativeMethodInfoPtr_SetIsAwaitingDelivery_Public_Virtual_New_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674900);
			Customer.NativeMethodInfoPtr_IsAtDealLocation_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674901);
			Customer.NativeMethodInfoPtr_UpdatePotentialCustomerPoI_Private_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674902);
			Customer.NativeMethodInfoPtr_SetPotentialCustomerPoIEnabled_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674903);
			Customer.NativeMethodInfoPtr_ShouldTryGenerateDeal_Protected_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674904);
			Customer.NativeMethodInfoPtr_OfferDealItems_Public_Virtual_New_Void_List_1_ItemInstance_Boolean_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674905);
			Customer.NativeMethodInfoPtr_CustomerRejectedDeal_Public_Virtual_New_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674906);
			Customer.NativeMethodInfoPtr_ProcessHandover_Public_Virtual_New_Void_EHandoverOutcome_Contract_List_1_ItemInstance_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674907);
			Customer.NativeMethodInfoPtr_ProcessHandoverServerSide_Private_Void_EHandoverOutcome_List_1_ItemInstance_Boolean_Single_ProductList_Single_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674908);
			Customer.NativeMethodInfoPtr_ProcessHandoverClient_Private_Void_Single_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674909);
			Customer.NativeMethodInfoPtr_ContractWellReceived_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674910);
			Customer.NativeMethodInfoPtr_RecommendDealer_Private_Void_Dealer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674911);
			Customer.NativeMethodInfoPtr_RecommendSupplier_Private_Void_Supplier_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674912);
			Customer.NativeMethodInfoPtr_RecommendCustomer_Private_Void_Customer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674913);
			Customer.NativeMethodInfoPtr_CurrentContractEnded_Public_Virtual_New_Void_EQuestState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674914);
			Customer.NativeMethodInfoPtr_EvaluateDelivery_Public_Virtual_New_Single_Contract_List_1_ItemInstance_byref_Single_byref_EDrugType_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674915);
			Customer.NativeMethodInfoPtr_ChangeAddiction_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674916);
			Customer.NativeMethodInfoPtr_ConsumeProduct_Private_Void_ItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674917);
			Customer.NativeMethodInfoPtr_ShowOfferDealOption_Protected_Virtual_New_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674918);
			Customer.NativeMethodInfoPtr_OfferDealValid_Protected_Virtual_New_Boolean_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674919);
			Customer.NativeMethodInfoPtr_InstantDealOffered_Protected_Virtual_New_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674920);
			Customer.NativeMethodInfoPtr_GetOfferSuccessChance_Public_Single_List_1_ItemInstance_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674921);
			Customer.NativeMethodInfoPtr_ShouldTryApproachPlayer_Protected_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674922);
			Customer.NativeMethodInfoPtr_RequestProduct_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674923);
			Customer.NativeMethodInfoPtr_RequestProduct_Public_Void_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674924);
			Customer.NativeMethodInfoPtr_PlayerRejectedProductRequest_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674925);
			Customer.NativeMethodInfoPtr_RejectProductRequestOffer_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674926);
			Customer.NativeMethodInfoPtr_RejectProductRequestOffer_Local_Private_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674927);
			Customer.NativeMethodInfoPtr_AssignDealer_Public_Void_Dealer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674928);
			Customer.NativeMethodInfoPtr_GetSaveString_Public_Virtual_New_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674929);
			Customer.NativeMethodInfoPtr_GetCustomerData_Public_CustomerData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674930);
			Customer.NativeMethodInfoPtr_WriteData_Public_Virtual_New_List_1_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674931);
			Customer.NativeMethodInfoPtr_ReceiveCustomerData_Private_Void_NetworkConnection_CustomerData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674932);
			Customer.NativeMethodInfoPtr_Load_Public_Virtual_New_Void_CustomerData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674933);
			Customer.NativeMethodInfoPtr_IsReadyForHandover_Protected_Virtual_New_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674934);
			Customer.NativeMethodInfoPtr_IsHandoverChoiceValid_Protected_Virtual_New_Boolean_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674935);
			Customer.NativeMethodInfoPtr_HandoverChosen_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674936);
			Customer.NativeMethodInfoPtr_ShowDirectApproachOption_Protected_Virtual_New_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674937);
			Customer.NativeMethodInfoPtr_IsUnlockable_Public_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674938);
			Customer.NativeMethodInfoPtr_SampleOptionValid_Protected_Virtual_New_Boolean_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674939);
			Customer.NativeMethodInfoPtr_KnownAndRecommended_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674940);
			Customer.NativeMethodInfoPtr_SampleOffered_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674941);
			Customer.NativeMethodInfoPtr_GetSampleRequestSuccessChance_Protected_Virtual_New_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674942);
			Customer.NativeMethodInfoPtr_SampleAccepted_Protected_Virtual_New_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674943);
			Customer.NativeMethodInfoPtr_GetSampleSuccess_Private_Single_List_1_ItemInstance_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674944);
			Customer.NativeMethodInfoPtr_ProcessSample_Private_Void_EHandoverOutcome_List_1_ItemInstance_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674945);
			Customer.NativeMethodInfoPtr_ProcessSampleServerSide_Private_Void_List_1_ItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674946);
			Customer.NativeMethodInfoPtr_ProcessSampleClient_Private_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674947);
			Customer.NativeMethodInfoPtr_SampleConsumed_Private_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674948);
			Customer.NativeMethodInfoPtr_EndWait_Private_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674949);
			Customer.NativeMethodInfoPtr_DirectApproachRejected_Protected_Virtual_New_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674950);
			Customer.NativeMethodInfoPtr_SampleWasSufficient_Private_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674951);
			Customer.NativeMethodInfoPtr_SampleWasInsufficient_Private_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674952);
			Customer.NativeMethodInfoPtr_GetProductEnjoyment_Public_Single_ProductDefinition_EQuality_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674953);
			Customer.NativeMethodInfoPtr_GetOrderedDrugTypes_Public_List_1_EDrugType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674954);
			Customer.NativeMethodInfoPtr_AdjustAffinity_Public_Void_EDrugType_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674955);
			Customer.NativeMethodInfoPtr_AutocreateCustomerSettings_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674956);
			Customer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674957);
			Customer.NativeMethodInfoPtr__Awake_b__131_0_Private_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674959);
			Customer.NativeMethodInfoPtr__Start_b__133_1_Private_Void_EUnlockType_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674960);
			Customer.NativeMethodInfoPtr_Method_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674961);
			Customer.NativeMethodInfoPtr_Method_Private_Void_EHandoverOutcome_List_1_ItemInstance_Single_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674962);
			Customer.NativeMethodInfoPtr__HandoverChosen_b__207_0_Private_Void_EHandoverOutcome_List_1_ItemInstance_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674963);
			Customer.NativeMethodInfoPtr__GetOrderedDrugTypes_b__225_0_Private_Single_EDrugType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674964);
			Customer.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674965);
			Customer.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674966);
			Customer.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674967);
			Customer.NativeMethodInfoPtr_RpcWriter___Observers_ConfigureDealSignal_338960014_Private_Void_NetworkConnection_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674968);
			Customer.NativeMethodInfoPtr_RpcLogic___ConfigureDealSignal_338960014_Private_Void_NetworkConnection_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674969);
			Customer.NativeMethodInfoPtr_RpcReader___Observers_ConfigureDealSignal_338960014_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674970);
			Customer.NativeMethodInfoPtr_RpcWriter___Target_ConfigureDealSignal_338960014_Private_Void_NetworkConnection_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674971);
			Customer.NativeMethodInfoPtr_RpcReader___Target_ConfigureDealSignal_338960014_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674972);
			Customer.NativeMethodInfoPtr_RpcWriter___Observers_SetOfferedContract_4277245194_Private_Void_ContractInfo_GameDateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674973);
			Customer.NativeMethodInfoPtr_RpcLogic___SetOfferedContract_4277245194_Private_Void_ContractInfo_GameDateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674974);
			Customer.NativeMethodInfoPtr_RpcReader___Observers_SetOfferedContract_4277245194_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674975);
			Customer.NativeMethodInfoPtr_RpcWriter___Server_ExpireOffer_2166136261_Private_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674976);
			Customer.NativeMethodInfoPtr_RpcLogic___ExpireOffer_2166136261_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674977);
			Customer.NativeMethodInfoPtr_RpcReader___Server_ExpireOffer_2166136261_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674978);
			Customer.NativeMethodInfoPtr_RpcWriter___Server_SendSetUpResponseCallbacks_2166136261_Private_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674979);
			Customer.NativeMethodInfoPtr_RpcLogic___SendSetUpResponseCallbacks_2166136261_Private_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674980);
			Customer.NativeMethodInfoPtr_RpcReader___Server_SendSetUpResponseCallbacks_2166136261_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674981);
			Customer.NativeMethodInfoPtr_RpcWriter___Observers_SetUpResponseCallbacks_2166136261_Private_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674982);
			Customer.NativeMethodInfoPtr_RpcLogic___SetUpResponseCallbacks_2166136261_Private_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674983);
			Customer.NativeMethodInfoPtr_RpcReader___Observers_SetUpResponseCallbacks_2166136261_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674984);
			Customer.NativeMethodInfoPtr_RpcWriter___Server_ProcessCounterOfferServerSide_900355577_Private_Void_String_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674985);
			Customer.NativeMethodInfoPtr_RpcLogic___ProcessCounterOfferServerSide_900355577_Private_Void_String_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674986);
			Customer.NativeMethodInfoPtr_RpcReader___Server_ProcessCounterOfferServerSide_900355577_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674987);
			Customer.NativeMethodInfoPtr_RpcWriter___Observers_SetContractIsCounterOffer_2166136261_Private_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674988);
			Customer.NativeMethodInfoPtr_RpcLogic___SetContractIsCounterOffer_2166136261_Private_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674989);
			Customer.NativeMethodInfoPtr_RpcReader___Observers_SetContractIsCounterOffer_2166136261_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674990);
			Customer.NativeMethodInfoPtr_RpcWriter___Server_SendContractAccepted_507093020_Private_Void_EDealWindow_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674991);
			Customer.NativeMethodInfoPtr_RpcLogic___SendContractAccepted_507093020_Private_Void_EDealWindow_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674992);
			Customer.NativeMethodInfoPtr_RpcReader___Server_SendContractAccepted_507093020_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674993);
			Customer.NativeMethodInfoPtr_RpcWriter___Observers_ReceiveContractAccepted_2166136261_Private_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674994);
			Customer.NativeMethodInfoPtr_RpcLogic___ReceiveContractAccepted_2166136261_Private_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674995);
			Customer.NativeMethodInfoPtr_RpcReader___Observers_ReceiveContractAccepted_2166136261_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674996);
			Customer.NativeMethodInfoPtr_RpcWriter___Observers_ReceiveContractRejected_2166136261_Private_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674997);
			Customer.NativeMethodInfoPtr_RpcLogic___ReceiveContractRejected_2166136261_Private_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674998);
			Customer.NativeMethodInfoPtr_RpcReader___Observers_ReceiveContractRejected_2166136261_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100674999);
			Customer.NativeMethodInfoPtr_RpcWriter___Server_ProcessHandoverServerSide_3760244802_Private_Void_EHandoverOutcome_List_1_ItemInstance_Boolean_Single_ProductList_Single_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100675000);
			Customer.NativeMethodInfoPtr_RpcLogic___ProcessHandoverServerSide_3760244802_Private_Void_EHandoverOutcome_List_1_ItemInstance_Boolean_Single_ProductList_Single_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100675001);
			Customer.NativeMethodInfoPtr_RpcReader___Server_ProcessHandoverServerSide_3760244802_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100675002);
			Customer.NativeMethodInfoPtr_RpcWriter___Observers_ProcessHandoverClient_537707335_Private_Void_Single_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100675003);
			Customer.NativeMethodInfoPtr_RpcLogic___ProcessHandoverClient_537707335_Private_Void_Single_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100675004);
			Customer.NativeMethodInfoPtr_RpcReader___Observers_ProcessHandoverClient_537707335_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100675005);
			Customer.NativeMethodInfoPtr_RpcWriter___Server_ChangeAddiction_431000436_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100675006);
			Customer.NativeMethodInfoPtr_RpcLogic___ChangeAddiction_431000436_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100675007);
			Customer.NativeMethodInfoPtr_RpcReader___Server_ChangeAddiction_431000436_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100675008);
			Customer.NativeMethodInfoPtr_RpcWriter___Server_RejectProductRequestOffer_2166136261_Private_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100675009);
			Customer.NativeMethodInfoPtr_RpcLogic___RejectProductRequestOffer_2166136261_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100675010);
			Customer.NativeMethodInfoPtr_RpcReader___Server_RejectProductRequestOffer_2166136261_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100675011);
			Customer.NativeMethodInfoPtr_RpcWriter___Observers_RejectProductRequestOffer_Local_2166136261_Private_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100675012);
			Customer.NativeMethodInfoPtr_RpcLogic___RejectProductRequestOffer_Local_2166136261_Private_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100675013);
			Customer.NativeMethodInfoPtr_RpcReader___Observers_RejectProductRequestOffer_Local_2166136261_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100675014);
			Customer.NativeMethodInfoPtr_RpcWriter___Target_ReceiveCustomerData_2280244125_Private_Void_NetworkConnection_CustomerData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100675015);
			Customer.NativeMethodInfoPtr_RpcLogic___ReceiveCustomerData_2280244125_Private_Void_NetworkConnection_CustomerData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100675016);
			Customer.NativeMethodInfoPtr_RpcReader___Target_ReceiveCustomerData_2280244125_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100675017);
			Customer.NativeMethodInfoPtr_RpcWriter___Server_ProcessSampleServerSide_3704012609_Private_Void_List_1_ItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100675018);
			Customer.NativeMethodInfoPtr_RpcLogic___ProcessSampleServerSide_3704012609_Private_Void_List_1_ItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100675019);
			Customer.NativeMethodInfoPtr_RpcReader___Server_ProcessSampleServerSide_3704012609_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100675020);
			Customer.NativeMethodInfoPtr_RpcWriter___Observers_ProcessSampleClient_2166136261_Private_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100675021);
			Customer.NativeMethodInfoPtr_RpcLogic___ProcessSampleClient_2166136261_Private_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100675022);
			Customer.NativeMethodInfoPtr_RpcReader___Observers_ProcessSampleClient_2166136261_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100675023);
			Customer.NativeMethodInfoPtr_RpcWriter___Observers_SampleWasSufficient_2166136261_Private_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100675024);
			Customer.NativeMethodInfoPtr_RpcLogic___SampleWasSufficient_2166136261_Private_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100675025);
			Customer.NativeMethodInfoPtr_RpcReader___Observers_SampleWasSufficient_2166136261_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100675026);
			Customer.NativeMethodInfoPtr_RpcWriter___Observers_SampleWasInsufficient_2166136261_Private_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100675027);
			Customer.NativeMethodInfoPtr_RpcLogic___SampleWasInsufficient_2166136261_Private_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100675028);
			Customer.NativeMethodInfoPtr_RpcReader___Observers_SampleWasInsufficient_2166136261_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100675029);
			Customer.NativeMethodInfoPtr_RpcWriter___Server_AdjustAffinity_3036964899_Private_Void_EDrugType_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100675030);
			Customer.NativeMethodInfoPtr_RpcLogic___AdjustAffinity_3036964899_Public_Void_EDrugType_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100675031);
			Customer.NativeMethodInfoPtr_RpcReader___Server_AdjustAffinity_3036964899_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100675032);
			Customer.NativeMethodInfoPtr_sync___get_value__CurrentAddiction_k__BackingField_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100675033);
			Customer.NativeMethodInfoPtr_sync___set_value__CurrentAddiction_k__BackingField_Public_set_Void_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100675034);
			Customer.NativeMethodInfoPtr_ReadSyncVar___ScheduleOne_Economy_Customer_Public_Virtual_Boolean_PooledReader_UInt32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100675035);
			Customer.NativeMethodInfoPtr_sync___get_value__HasBeenRecommended_k__BackingField_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100675036);
			Customer.NativeMethodInfoPtr_sync___set_value__HasBeenRecommended_k__BackingField_Public_set_Void_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100675037);
			Customer.NativeMethodInfoPtr_Method_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100675038);
		}

		// Token: 0x17001B6B RID: 7019
		// (get) Token: 0x06005A90 RID: 23184 RVA: 0x001A8C5C File Offset: 0x001A6E5C
		// (set) Token: 0x06005A91 RID: 23185 RVA: 0x001A8C98 File Offset: 0x001A6E98
		public unsafe float CurrentAddiction
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 89901, RefRangeEnd = 89903, XrefRangeStart = 89901, XrefRangeEnd = 89903, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_get_CurrentAddiction_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 191037, RefRangeEnd = 191041, XrefRangeStart = 191030, XrefRangeEnd = 191037, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = ref value;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_set_CurrentAddiction_Protected_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x17001B6C RID: 7020
		// (get) Token: 0x06005A92 RID: 23186 RVA: 0x001A8CD8 File Offset: 0x001A6ED8
		// (set) Token: 0x06005A93 RID: 23187 RVA: 0x001A8D18 File Offset: 0x001A6F18
		public unsafe ContractInfo OfferedContractInfo
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_get_OfferedContractInfo_Public_get_ContractInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ContractInfo>(intPtr2) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_set_OfferedContractInfo_Protected_set_Void_ContractInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x17001B6D RID: 7021
		// (get) Token: 0x06005A94 RID: 23188 RVA: 0x001A8D5C File Offset: 0x001A6F5C
		// (set) Token: 0x06005A95 RID: 23189 RVA: 0x001A8D98 File Offset: 0x001A6F98
		public unsafe GameDateTime OfferedContractTime
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_get_OfferedContractTime_Public_get_GameDateTime_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
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
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_set_OfferedContractTime_Protected_set_Void_GameDateTime_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x17001B6E RID: 7022
		// (get) Token: 0x06005A96 RID: 23190 RVA: 0x001A8DD8 File Offset: 0x001A6FD8
		// (set) Token: 0x06005A97 RID: 23191 RVA: 0x001A8E18 File Offset: 0x001A7018
		public unsafe Contract CurrentContract
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_get_CurrentContract_Public_get_Contract_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Contract>(intPtr2) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_set_CurrentContract_Protected_set_Void_Contract_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x17001B6F RID: 7023
		// (get) Token: 0x06005A98 RID: 23192 RVA: 0x001A8E5C File Offset: 0x001A705C
		// (set) Token: 0x06005A99 RID: 23193 RVA: 0x001A8E98 File Offset: 0x001A7098
		public unsafe bool IsAwaitingDelivery
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_get_IsAwaitingDelivery_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
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
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_set_IsAwaitingDelivery_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x17001B70 RID: 7024
		// (get) Token: 0x06005A9A RID: 23194 RVA: 0x001A8ED8 File Offset: 0x001A70D8
		// (set) Token: 0x06005A9B RID: 23195 RVA: 0x001A8F14 File Offset: 0x001A7114
		public unsafe int TimeSinceLastDealCompleted
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_get_TimeSinceLastDealCompleted_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
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
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_set_TimeSinceLastDealCompleted_Protected_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x17001B71 RID: 7025
		// (get) Token: 0x06005A9C RID: 23196 RVA: 0x001A8F54 File Offset: 0x001A7154
		// (set) Token: 0x06005A9D RID: 23197 RVA: 0x001A8F90 File Offset: 0x001A7190
		public unsafe int TimeSinceLastDealOffered
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_get_TimeSinceLastDealOffered_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
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
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_set_TimeSinceLastDealOffered_Protected_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x17001B72 RID: 7026
		// (get) Token: 0x06005A9E RID: 23198 RVA: 0x001A8FD0 File Offset: 0x001A71D0
		// (set) Token: 0x06005A9F RID: 23199 RVA: 0x001A900C File Offset: 0x001A720C
		public unsafe int TimeSincePlayerApproached
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_get_TimeSincePlayerApproached_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
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
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_set_TimeSincePlayerApproached_Protected_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x17001B73 RID: 7027
		// (get) Token: 0x06005AA0 RID: 23200 RVA: 0x001A904C File Offset: 0x001A724C
		// (set) Token: 0x06005AA1 RID: 23201 RVA: 0x001A9088 File Offset: 0x001A7288
		public unsafe int TimeSinceInstantDealOffered
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_get_TimeSinceInstantDealOffered_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
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
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_set_TimeSinceInstantDealOffered_Protected_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x17001B74 RID: 7028
		// (get) Token: 0x06005AA2 RID: 23202 RVA: 0x001A90C8 File Offset: 0x001A72C8
		// (set) Token: 0x06005AA3 RID: 23203 RVA: 0x001A9104 File Offset: 0x001A7304
		public unsafe int OfferedDeals
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_get_OfferedDeals_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
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
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_set_OfferedDeals_Protected_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x17001B75 RID: 7029
		// (get) Token: 0x06005AA4 RID: 23204 RVA: 0x001A9144 File Offset: 0x001A7344
		// (set) Token: 0x06005AA5 RID: 23205 RVA: 0x001A9180 File Offset: 0x001A7380
		public unsafe int CompletedDeliveries
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_get_CompletedDeliveries_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
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
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_set_CompletedDeliveries_Protected_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x17001B76 RID: 7030
		// (get) Token: 0x06005AA6 RID: 23206 RVA: 0x001A91C0 File Offset: 0x001A73C0
		// (set) Token: 0x06005AA7 RID: 23207 RVA: 0x001A91FC File Offset: 0x001A73FC
		public unsafe bool HasBeenRecommended
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_get_HasBeenRecommended_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 191048, RefRangeEnd = 191051, XrefRangeStart = 191041, XrefRangeEnd = 191048, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = ref value;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_set_HasBeenRecommended_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x17001B77 RID: 7031
		// (get) Token: 0x06005AA8 RID: 23208 RVA: 0x001A923C File Offset: 0x001A743C
		// (set) Token: 0x06005AA9 RID: 23209 RVA: 0x001A927C File Offset: 0x001A747C
		public unsafe NPC NPC
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_get_NPC_Public_get_NPC_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NPC>(intPtr2) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_set_NPC_Protected_set_Void_NPC_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x17001B78 RID: 7032
		// (get) Token: 0x06005AAA RID: 23210 RVA: 0x001A92C0 File Offset: 0x001A74C0
		// (set) Token: 0x06005AAB RID: 23211 RVA: 0x001A9300 File Offset: 0x001A7500
		public unsafe Dealer AssignedDealer
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_get_AssignedDealer_Public_get_Dealer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dealer>(intPtr2) : null;
			}
			[CallerCount(8)]
			[CachedScanResults(RefRangeStart = 118576, RefRangeEnd = 118584, XrefRangeStart = 118576, XrefRangeEnd = 118584, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_set_AssignedDealer_Protected_set_Void_Dealer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x17001B79 RID: 7033
		// (get) Token: 0x06005AAC RID: 23212 RVA: 0x001A9344 File Offset: 0x001A7544
		public unsafe CustomerData CustomerData
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_get_CustomerData_Public_get_CustomerData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CustomerData>(intPtr2) : null;
			}
		}

		// Token: 0x17001B7A RID: 7034
		// (get) Token: 0x06005AAD RID: 23213 RVA: 0x001A9384 File Offset: 0x001A7584
		public unsafe List<ProductDefinition> OrderableProducts
		{
			[CallerCount(24)]
			[CachedScanResults(RefRangeStart = 191060, RefRangeEnd = 191084, XrefRangeStart = 191051, XrefRangeEnd = 191060, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_get_OrderableProducts_Public_get_List_1_ProductDefinition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ProductDefinition>>(intPtr2) : null;
			}
		}

		// Token: 0x17001B7B RID: 7035
		// (get) Token: 0x06005AAE RID: 23214 RVA: 0x001A93C4 File Offset: 0x001A75C4
		public unsafe DialogueDatabase dialogueDatabase
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_get_dialogueDatabase_Private_get_DialogueDatabase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DialogueDatabase>(intPtr2) : null;
			}
		}

		// Token: 0x17001B7C RID: 7036
		// (get) Token: 0x06005AAF RID: 23215 RVA: 0x001A9404 File Offset: 0x001A7604
		// (set) Token: 0x06005AB0 RID: 23216 RVA: 0x001A9444 File Offset: 0x001A7644
		public unsafe NPCPoI potentialCustomerPoI
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_get_potentialCustomerPoI_Public_get_NPCPoI_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NPCPoI>(intPtr2) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_set_potentialCustomerPoI_Private_set_Void_NPCPoI_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x17001B7D RID: 7037
		// (get) Token: 0x06005AB1 RID: 23217 RVA: 0x001A9488 File Offset: 0x001A7688
		public unsafe virtual string SaveFolderName
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 191084, XrefRangeEnd = 191086, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_get_SaveFolderName_Public_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return IL2CPP.Il2CppStringToManaged(il2CppString);
			}
		}

		// Token: 0x17001B7E RID: 7038
		// (get) Token: 0x06005AB2 RID: 23218 RVA: 0x001A94C0 File Offset: 0x001A76C0
		public unsafe virtual string SaveFileName
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 191086, XrefRangeEnd = 191088, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_get_SaveFileName_Public_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return IL2CPP.Il2CppStringToManaged(il2CppString);
			}
		}

		// Token: 0x17001B7F RID: 7039
		// (get) Token: 0x06005AB3 RID: 23219 RVA: 0x001A94F8 File Offset: 0x001A76F8
		public unsafe virtual Loader Loader
		{
			[CallerCount(70)]
			[CachedScanResults(RefRangeStart = 32673, RefRangeEnd = 32743, XrefRangeStart = 32673, XrefRangeEnd = 32743, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_get_Loader_Public_Virtual_Final_New_get_Loader_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Loader>(intPtr2) : null;
			}
		}

		// Token: 0x17001B80 RID: 7040
		// (get) Token: 0x06005AB4 RID: 23220 RVA: 0x001A9538 File Offset: 0x001A7738
		public unsafe virtual bool ShouldSaveUnderFolder
		{
			[CallerCount(176)]
			[CachedScanResults(RefRangeStart = 38110, RefRangeEnd = 38286, XrefRangeStart = 38110, XrefRangeEnd = 38286, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_get_ShouldSaveUnderFolder_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
		}

		// Token: 0x17001B81 RID: 7041
		// (get) Token: 0x06005AB5 RID: 23221 RVA: 0x001A9574 File Offset: 0x001A7774
		// (set) Token: 0x06005AB6 RID: 23222 RVA: 0x001A95B4 File Offset: 0x001A77B4
		public unsafe virtual List<string> LocalExtraFiles
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 171044, RefRangeEnd = 171059, XrefRangeStart = 171044, XrefRangeEnd = 171059, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_get_LocalExtraFiles_Public_Virtual_Final_New_get_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 191088, XrefRangeEnd = 191089, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_set_LocalExtraFiles_Public_Virtual_Final_New_set_Void_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x17001B82 RID: 7042
		// (get) Token: 0x06005AB7 RID: 23223 RVA: 0x001A95F8 File Offset: 0x001A77F8
		// (set) Token: 0x06005AB8 RID: 23224 RVA: 0x001A9638 File Offset: 0x001A7838
		public unsafe virtual List<string> LocalExtraFolders
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_get_LocalExtraFolders_Public_Virtual_Final_New_get_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 191089, XrefRangeEnd = 191090, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_set_LocalExtraFolders_Public_Virtual_Final_New_set_Void_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x17001B83 RID: 7043
		// (get) Token: 0x06005AB9 RID: 23225 RVA: 0x001A967C File Offset: 0x001A787C
		// (set) Token: 0x06005ABA RID: 23226 RVA: 0x001A96B8 File Offset: 0x001A78B8
		public unsafe virtual bool HasChanged
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_get_HasChanged_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
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
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_set_HasChanged_Public_Virtual_Final_New_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x06005ABB RID: 23227 RVA: 0x001A96F8 File Offset: 0x001A78F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 191090, XrefRangeEnd = 191091, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Customer.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005ABC RID: 23228 RVA: 0x001A9734 File Offset: 0x001A7934
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 191091, XrefRangeEnd = 191144, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnValidate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Customer.NativeMethodInfoPtr_OnValidate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005ABD RID: 23229 RVA: 0x001A9770 File Offset: 0x001A7970
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 191144, XrefRangeEnd = 191225, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_Start_Private_Void_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005ABE RID: 23230 RVA: 0x001A97A4 File Offset: 0x001A79A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 191225, XrefRangeEnd = 191227, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnStartClient()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Customer.NativeMethodInfoPtr_OnStartClient_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005ABF RID: 23231 RVA: 0x001A97E0 File Offset: 0x001A79E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 191227, XrefRangeEnd = 191251, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnSpawnServer(NetworkConnection connection)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(connection);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Customer.NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005AC0 RID: 23232 RVA: 0x001A9830 File Offset: 0x001A7A30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 191251, XrefRangeEnd = 191259, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_OnDestroy_Private_Void_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005AC1 RID: 23233 RVA: 0x001A9864 File Offset: 0x001A7A64
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 191362, RefRangeEnd = 191363, XrefRangeStart = 191259, XrefRangeEnd = 191362, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetUpDialogue()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_SetUpDialogue_Private_Void_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005AC2 RID: 23234 RVA: 0x001A9898 File Offset: 0x001A7A98
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 191393, RefRangeEnd = 191394, XrefRangeStart = 191363, XrefRangeEnd = 191393, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetupPoI()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_SetupPoI_Private_Void_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005AC3 RID: 23235 RVA: 0x001A98CC File Offset: 0x001A7ACC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 191394, XrefRangeEnd = 191400, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void InitializeSaveable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Customer.NativeMethodInfoPtr_InitializeSaveable_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005AC4 RID: 23236 RVA: 0x001A9908 File Offset: 0x001A7B08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 191400, XrefRangeEnd = 191477, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void MinPass()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Customer.NativeMethodInfoPtr_MinPass_Protected_Virtual_New_Void_1), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005AC5 RID: 23237 RVA: 0x001A9944 File Offset: 0x001A7B44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 191477, XrefRangeEnd = 191479, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void DayPass()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Customer.NativeMethodInfoPtr_DayPass_Protected_Virtual_New_Void_1), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005AC6 RID: 23238 RVA: 0x001A9980 File Offset: 0x001A7B80
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 191536, RefRangeEnd = 191537, XrefRangeStart = 191479, XrefRangeEnd = 191536, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateDealAttendance()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_UpdateDealAttendance_Private_Void_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005AC7 RID: 23239 RVA: 0x001A99B4 File Offset: 0x001A7BB4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 191549, RefRangeEnd = 191552, XrefRangeStart = 191537, XrefRangeEnd = 191549, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ConfigureDealSignal(NetworkConnection conn, int startTime, bool active)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref startTime;
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref active;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_ConfigureDealSignal_Private_Void_NetworkConnection_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005AC8 RID: 23240 RVA: 0x001A9A14 File Offset: 0x001A7C14
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 191571, RefRangeEnd = 191572, XrefRangeStart = 191552, XrefRangeEnd = 191571, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateOfferExpiry()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_UpdateOfferExpiry_Private_Void_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005AC9 RID: 23241 RVA: 0x001A9A48 File Offset: 0x001A7C48
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 191691, RefRangeEnd = 191692, XrefRangeStart = 191572, XrefRangeEnd = 191691, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ContractInfo CheckContractGeneration(bool force = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref force;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_CheckContractGeneration_Private_ContractInfo_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<ContractInfo>(intPtr2) : null;
		}

		// Token: 0x06005ACA RID: 23242 RVA: 0x001A9A94 File Offset: 0x001A7C94
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 191778, RefRangeEnd = 191779, XrefRangeStart = 191692, XrefRangeEnd = 191778, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ProductDefinition GetWeightedRandomProduct(out float appeal)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = &appeal;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_GetWeightedRandomProduct_Private_ProductDefinition_byref_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<ProductDefinition>(intPtr2) : null;
		}

		// Token: 0x06005ACB RID: 23243 RVA: 0x001A9AE0 File Offset: 0x001A7CE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 191779, XrefRangeEnd = 191808, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnCustomerUnlocked(NPCRelationData.EUnlockType unlockType, bool notify)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref unlockType;
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref notify;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Customer.NativeMethodInfoPtr_OnCustomerUnlocked_Protected_Virtual_New_Void_EUnlockType_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005ACC RID: 23244 RVA: 0x001A9B38 File Offset: 0x001A7D38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 191808, XrefRangeEnd = 191809, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetHasBeenRecommended()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_SetHasBeenRecommended_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005ACD RID: 23245 RVA: 0x001A9B6C File Offset: 0x001A7D6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 191809, XrefRangeEnd = 191851, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OfferContract(ContractInfo info)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Customer.NativeMethodInfoPtr_OfferContract_Public_Virtual_New_Void_ContractInfo_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005ACE RID: 23246 RVA: 0x001A9BBC File Offset: 0x001A7DBC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 191851, XrefRangeEnd = 191862, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetOfferedContract(ContractInfo info, GameDateTime offerTime)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref offerTime;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_SetOfferedContract_Private_Void_ContractInfo_GameDateTime_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005ACF RID: 23247 RVA: 0x001A9C0C File Offset: 0x001A7E0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 191862, XrefRangeEnd = 191883, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void ExpireOffer()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Customer.NativeMethodInfoPtr_ExpireOffer_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005AD0 RID: 23248 RVA: 0x001A9C48 File Offset: 0x001A7E48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 191883, XrefRangeEnd = 191895, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void AssignContract(Contract contract)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(contract);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Customer.NativeMethodInfoPtr_AssignContract_Public_Virtual_New_Void_Contract_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005AD1 RID: 23249 RVA: 0x001A9C98 File Offset: 0x001A7E98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 191895, XrefRangeEnd = 191949, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void NotifyPlayerOfContract(ContractInfo contract, MessageChain offerMessage, bool canAccept, bool canReject, bool canCounterOffer = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)5) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(contract);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(offerMessage);
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref canAccept;
			ptr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref canReject;
			ptr[checked(unchecked((System.UIntPtr)4) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref canCounterOffer;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Customer.NativeMethodInfoPtr_NotifyPlayerOfContract_Protected_Virtual_New_Void_ContractInfo_MessageChain_Boolean_Boolean_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005AD2 RID: 23250 RVA: 0x001A9D24 File Offset: 0x001A7F24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 191949, XrefRangeEnd = 191970, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendSetUpResponseCallbacks()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_SendSetUpResponseCallbacks_Private_Void_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005AD3 RID: 23251 RVA: 0x001A9D58 File Offset: 0x001A7F58
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 191991, RefRangeEnd = 191996, XrefRangeStart = 191970, XrefRangeEnd = 191991, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetUpResponseCallbacks()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_SetUpResponseCallbacks_Private_Void_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005AD4 RID: 23252 RVA: 0x001A9D8C File Offset: 0x001A7F8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 191996, XrefRangeEnd = 192007, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void AcceptContractClicked()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Customer.NativeMethodInfoPtr_AcceptContractClicked_Protected_Virtual_New_Void_1), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005AD5 RID: 23253 RVA: 0x001A9DC8 File Offset: 0x001A7FC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 192007, XrefRangeEnd = 192026, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void CounterOfferClicked()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Customer.NativeMethodInfoPtr_CounterOfferClicked_Protected_Virtual_New_Void_1), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005AD6 RID: 23254 RVA: 0x001A9E04 File Offset: 0x001A8004
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 192026, XrefRangeEnd = 192069, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SendCounteroffer(ProductDefinition product, int quantity, float price)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(product);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref quantity;
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref price;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Customer.NativeMethodInfoPtr_SendCounteroffer_Protected_Virtual_New_Void_ProductDefinition_Int32_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005AD7 RID: 23255 RVA: 0x001A9E70 File Offset: 0x001A8070
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 192069, XrefRangeEnd = 192082, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ProcessCounterOfferServerSide(string productID, int quantity, float price)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(productID);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref quantity;
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref price;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_ProcessCounterOfferServerSide_Private_Void_String_Int32_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005AD8 RID: 23256 RVA: 0x001A9ED0 File Offset: 0x001A80D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 192082, XrefRangeEnd = 192101, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetContractIsCounterOffer()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_SetContractIsCounterOffer_Private_Void_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005AD9 RID: 23257 RVA: 0x001A9F04 File Offset: 0x001A8104
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 192101, XrefRangeEnd = 192170, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void PlayerAcceptedContract(EDealWindow window)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref window;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Customer.NativeMethodInfoPtr_PlayerAcceptedContract_Protected_Virtual_New_Void_EDealWindow_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005ADA RID: 23258 RVA: 0x001A9F50 File Offset: 0x001A8150
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 192170, XrefRangeEnd = 192181, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendContractAccepted(EDealWindow window, bool trackContract)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref window;
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref trackContract;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_SendContractAccepted_Private_Void_EDealWindow_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005ADB RID: 23259 RVA: 0x001A9F9C File Offset: 0x001A819C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 192181, XrefRangeEnd = 192217, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual string ContractAccepted(EDealWindow window, bool trackContract)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref window;
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref trackContract;
			System.IntPtr returnedException;
			System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Customer.NativeMethodInfoPtr_ContractAccepted_Public_Virtual_New_String_EDealWindow_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return IL2CPP.Il2CppStringToManaged(il2CppString);
		}

		// Token: 0x06005ADC RID: 23260 RVA: 0x001A9FFC File Offset: 0x001A81FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 192217, XrefRangeEnd = 192238, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReceiveContractAccepted()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_ReceiveContractAccepted_Private_Void_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005ADD RID: 23261 RVA: 0x001AA030 File Offset: 0x001A8230
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 192238, XrefRangeEnd = 192244, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void PlayContractAcceptedReaction()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Customer.NativeMethodInfoPtr_PlayContractAcceptedReaction_Protected_Virtual_New_Void_1), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005ADE RID: 23262 RVA: 0x001AA06C File Offset: 0x001A826C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 192244, XrefRangeEnd = 192274, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool EvaluateCounteroffer(ProductDefinition product, int quantity, float price)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(product);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref quantity;
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref price;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Customer.NativeMethodInfoPtr_EvaluateCounteroffer_Protected_Virtual_New_Boolean_ProductDefinition_Int32_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06005ADF RID: 23263 RVA: 0x001AA0E0 File Offset: 0x001A82E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 192274, XrefRangeEnd = 192275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float GetValueProposition(ProductDefinition product, float price)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(product);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref price;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_GetValueProposition_Public_Static_Single_ProductDefinition_Single_0, 0, (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06005AE0 RID: 23264 RVA: 0x001AA130 File Offset: 0x001A8330
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 192275, XrefRangeEnd = 192304, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void ContractRejected()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Customer.NativeMethodInfoPtr_ContractRejected_Protected_Virtual_New_Void_1), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005AE1 RID: 23265 RVA: 0x001AA16C File Offset: 0x001A836C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 192304, XrefRangeEnd = 192325, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReceiveContractRejected()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_ReceiveContractRejected_Private_Void_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005AE2 RID: 23266 RVA: 0x001AA1A0 File Offset: 0x001A83A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 192325, XrefRangeEnd = 192331, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void PlayContractRejectedReaction()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Customer.NativeMethodInfoPtr_PlayContractRejectedReaction_Protected_Virtual_New_Void_1), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005AE3 RID: 23267 RVA: 0x001AA1DC File Offset: 0x001A83DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 192331, XrefRangeEnd = 192352, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetIsAwaitingDelivery(bool awaiting)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref awaiting;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Customer.NativeMethodInfoPtr_SetIsAwaitingDelivery_Public_Virtual_New_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005AE4 RID: 23268 RVA: 0x001AA228 File Offset: 0x001A8428
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 192361, RefRangeEnd = 192363, XrefRangeStart = 192352, XrefRangeEnd = 192361, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsAtDealLocation()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_IsAtDealLocation_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06005AE5 RID: 23269 RVA: 0x001AA264 File Offset: 0x001A8464
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 192369, RefRangeEnd = 192372, XrefRangeStart = 192363, XrefRangeEnd = 192369, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdatePotentialCustomerPoI()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_UpdatePotentialCustomerPoI_Private_Void_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005AE6 RID: 23270 RVA: 0x001AA298 File Offset: 0x001A8498
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 192372, XrefRangeEnd = 192377, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetPotentialCustomerPoIEnabled(bool enabled)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref enabled;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_SetPotentialCustomerPoIEnabled_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005AE7 RID: 23271 RVA: 0x001AA2D8 File Offset: 0x001A84D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 192377, XrefRangeEnd = 192392, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool ShouldTryGenerateDeal()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Customer.NativeMethodInfoPtr_ShouldTryGenerateDeal_Protected_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06005AE8 RID: 23272 RVA: 0x001AA320 File Offset: 0x001A8520
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 192392, XrefRangeEnd = 192400, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OfferDealItems(List<ItemInstance> items, bool offeredByPlayer, out bool accepted)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(items);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref offeredByPlayer;
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = &accepted;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Customer.NativeMethodInfoPtr_OfferDealItems_Public_Virtual_New_Void_List_1_ItemInstance_Boolean_byref_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005AE9 RID: 23273 RVA: 0x001AA38C File Offset: 0x001A858C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 192400, XrefRangeEnd = 192433, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void CustomerRejectedDeal(bool offeredByPlayer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref offeredByPlayer;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Customer.NativeMethodInfoPtr_CustomerRejectedDeal_Public_Virtual_New_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005AEA RID: 23274 RVA: 0x001AA3D8 File Offset: 0x001A85D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 192433, XrefRangeEnd = 192588, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void ProcessHandover(HandoverScreen.EHandoverOutcome outcome, Contract contract, List<ItemInstance> items, bool handoverByPlayer, bool giveBonuses = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)5) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref outcome;
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(contract);
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(items);
			ptr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref handoverByPlayer;
			ptr[checked(unchecked((System.UIntPtr)4) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref giveBonuses;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Customer.NativeMethodInfoPtr_ProcessHandover_Public_Virtual_New_Void_EHandoverOutcome_Contract_List_1_ItemInstance_Boolean_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005AEB RID: 23275 RVA: 0x001AA464 File Offset: 0x001A8664
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 192588, XrefRangeEnd = 192604, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ProcessHandoverServerSide(HandoverScreen.EHandoverOutcome outcome, List<ItemInstance> items, bool handoverByPlayer, float totalPayment, ProductList productList, float satisfaction, NetworkObject dealer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)7) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref outcome;
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(items);
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref handoverByPlayer;
			ptr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref totalPayment;
			ptr[checked(unchecked((System.UIntPtr)4) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(productList);
			ptr[checked(unchecked((System.UIntPtr)5) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref satisfaction;
			ptr[checked(unchecked((System.UIntPtr)6) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(dealer);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_ProcessHandoverServerSide_Private_Void_EHandoverOutcome_List_1_ItemInstance_Boolean_Single_ProductList_Single_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005AEC RID: 23276 RVA: 0x001AA504 File Offset: 0x001A8704
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 192604, XrefRangeEnd = 192616, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ProcessHandoverClient(float satisfaction, bool handoverByPlayer, string npcToRecommend)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref satisfaction;
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref handoverByPlayer;
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(npcToRecommend);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_ProcessHandoverClient_Private_Void_Single_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005AED RID: 23277 RVA: 0x001AA564 File Offset: 0x001A8764
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 192636, RefRangeEnd = 192638, XrefRangeStart = 192616, XrefRangeEnd = 192636, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ContractWellReceived(string npcToRecommend)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(npcToRecommend);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_ContractWellReceived_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005AEE RID: 23278 RVA: 0x001AA5A8 File Offset: 0x001A87A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 192638, XrefRangeEnd = 192719, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RecommendDealer(Dealer dealer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(dealer);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_RecommendDealer_Private_Void_Dealer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005AEF RID: 23279 RVA: 0x001AA5EC File Offset: 0x001A87EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 192719, XrefRangeEnd = 192788, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RecommendSupplier(Supplier supplier)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(supplier);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_RecommendSupplier_Private_Void_Supplier_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005AF0 RID: 23280 RVA: 0x001AA630 File Offset: 0x001A8830
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 192788, XrefRangeEnd = 192871, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RecommendCustomer(Customer friend)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(friend);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_RecommendCustomer_Private_Void_Customer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005AF1 RID: 23281 RVA: 0x001AA674 File Offset: 0x001A8874
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 192871, XrefRangeEnd = 192878, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void CurrentContractEnded(EQuestState outcome)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref outcome;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Customer.NativeMethodInfoPtr_CurrentContractEnded_Public_Virtual_New_Void_EQuestState_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005AF2 RID: 23282 RVA: 0x001AA6C0 File Offset: 0x001A88C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 192878, XrefRangeEnd = 192965, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual float EvaluateDelivery(Contract contract, List<ItemInstance> providedItems, out float highestAddiction, out EDrugType mainTypeType, out int matchedProductCount)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)5) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(contract);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(providedItems);
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = &highestAddiction;
			ptr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = &mainTypeType;
			ptr[checked(unchecked((System.UIntPtr)4) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = &matchedProductCount;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Customer.NativeMethodInfoPtr_EvaluateDelivery_Public_Virtual_New_Single_Contract_List_1_ItemInstance_byref_Single_byref_EDrugType_byref_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06005AF3 RID: 23283 RVA: 0x001AA758 File Offset: 0x001A8958
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 192975, RefRangeEnd = 192977, XrefRangeStart = 192965, XrefRangeEnd = 192975, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ChangeAddiction(float change)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref change;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_ChangeAddiction_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005AF4 RID: 23284 RVA: 0x001AA798 File Offset: 0x001A8998
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 192977, XrefRangeEnd = 192990, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ConsumeProduct(ItemInstance item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_ConsumeProduct_Private_Void_ItemInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005AF5 RID: 23285 RVA: 0x001AA7DC File Offset: 0x001A89DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 192990, XrefRangeEnd = 193002, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool ShowOfferDealOption(bool enabled)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref enabled;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Customer.NativeMethodInfoPtr_ShowOfferDealOption_Protected_Virtual_New_Boolean_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06005AF6 RID: 23286 RVA: 0x001AA830 File Offset: 0x001A8A30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 193002, XrefRangeEnd = 193011, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool OfferDealValid(out string invalidReason)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			ref System.IntPtr ptr2 = ref *ptr;
			System.IntPtr il2CppString = 0;
			ptr2 = &il2CppString;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Customer.NativeMethodInfoPtr_OfferDealValid_Protected_Virtual_New_Boolean_byref_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			invalidReason = IL2CPP.Il2CppStringToManaged(il2CppString);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06005AF7 RID: 23287 RVA: 0x001AA894 File Offset: 0x001A8A94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 193011, XrefRangeEnd = 193023, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void InstantDealOffered()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Customer.NativeMethodInfoPtr_InstantDealOffered_Protected_Virtual_New_Void_1), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005AF8 RID: 23288 RVA: 0x001AA8D0 File Offset: 0x001A8AD0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 193102, RefRangeEnd = 193104, XrefRangeStart = 193023, XrefRangeEnd = 193102, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float GetOfferSuccessChance(List<ItemInstance> items, float askingPrice)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(items);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref askingPrice;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_GetOfferSuccessChance_Public_Single_List_1_ItemInstance_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06005AF9 RID: 23289 RVA: 0x001AA92C File Offset: 0x001A8B2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 193104, XrefRangeEnd = 193135, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool ShouldTryApproachPlayer()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Customer.NativeMethodInfoPtr_ShouldTryApproachPlayer_Protected_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06005AFA RID: 23290 RVA: 0x001AA974 File Offset: 0x001A8B74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 193135, XrefRangeEnd = 193140, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RequestProduct()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_RequestProduct_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005AFB RID: 23291 RVA: 0x001AA9A8 File Offset: 0x001A8BA8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 193152, RefRangeEnd = 193154, XrefRangeStart = 193140, XrefRangeEnd = 193152, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RequestProduct(Player target)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_RequestProduct_Public_Void_Player_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005AFC RID: 23292 RVA: 0x001AA9EC File Offset: 0x001A8BEC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 193174, RefRangeEnd = 193175, XrefRangeStart = 193154, XrefRangeEnd = 193174, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PlayerRejectedProductRequest()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_PlayerRejectedProductRequest_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005AFD RID: 23293 RVA: 0x001AAA20 File Offset: 0x001A8C20
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 193184, RefRangeEnd = 193185, XrefRangeStart = 193175, XrefRangeEnd = 193184, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RejectProductRequestOffer()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_RejectProductRequestOffer_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005AFE RID: 23294 RVA: 0x001AAA54 File Offset: 0x001A8C54
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 193185, XrefRangeEnd = 193206, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RejectProductRequestOffer_Local()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_RejectProductRequestOffer_Local_Private_Void_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005AFF RID: 23295 RVA: 0x001AAA88 File Offset: 0x001A8C88
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 118576, RefRangeEnd = 118584, XrefRangeStart = 118576, XrefRangeEnd = 118584, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AssignDealer(Dealer dealer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(dealer);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_AssignDealer_Public_Void_Dealer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005B00 RID: 23296 RVA: 0x001AAACC File Offset: 0x001A8CCC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 193206, XrefRangeEnd = 193208, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual string GetSaveString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Customer.NativeMethodInfoPtr_GetSaveString_Public_Virtual_New_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return IL2CPP.Il2CppStringToManaged(il2CppString);
		}

		// Token: 0x06005B01 RID: 23297 RVA: 0x001AAB10 File Offset: 0x001A8D10
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 193233, RefRangeEnd = 193235, XrefRangeStart = 193208, XrefRangeEnd = 193233, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CustomerData GetCustomerData()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_GetCustomerData_Public_CustomerData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<CustomerData>(intPtr2) : null;
		}

		// Token: 0x06005B02 RID: 23298 RVA: 0x001AAB50 File Offset: 0x001A8D50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 193235, XrefRangeEnd = 193241, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual List<string> WriteData(string parentFolderPath)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(parentFolderPath);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Customer.NativeMethodInfoPtr_WriteData_Public_Virtual_New_List_1_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
		}

		// Token: 0x06005B03 RID: 23299 RVA: 0x001AABAC File Offset: 0x001A8DAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 193241, XrefRangeEnd = 193251, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReceiveCustomerData(NetworkConnection conn, CustomerData data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(data);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_ReceiveCustomerData_Private_Void_NetworkConnection_CustomerData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005B04 RID: 23300 RVA: 0x001AAC00 File Offset: 0x001A8E00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 193251, XrefRangeEnd = 193272, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Load(CustomerData data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Customer.NativeMethodInfoPtr_Load_Public_Virtual_New_Void_CustomerData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005B05 RID: 23301 RVA: 0x001AAC50 File Offset: 0x001A8E50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 193272, XrefRangeEnd = 193280, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool IsReadyForHandover(bool enabled)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref enabled;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Customer.NativeMethodInfoPtr_IsReadyForHandover_Protected_Virtual_New_Boolean_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06005B06 RID: 23302 RVA: 0x001AACA4 File Offset: 0x001A8EA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 193280, XrefRangeEnd = 193300, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool IsHandoverChoiceValid(out string invalidReason)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			ref System.IntPtr ptr2 = ref *ptr;
			System.IntPtr il2CppString = 0;
			ptr2 = &il2CppString;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Customer.NativeMethodInfoPtr_IsHandoverChoiceValid_Protected_Virtual_New_Boolean_byref_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			invalidReason = IL2CPP.Il2CppStringToManaged(il2CppString);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06005B07 RID: 23303 RVA: 0x001AAD08 File Offset: 0x001A8F08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 193300, XrefRangeEnd = 193311, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void HandoverChosen()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_HandoverChosen_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005B08 RID: 23304 RVA: 0x001AAD3C File Offset: 0x001A8F3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 193311, XrefRangeEnd = 193319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool ShowDirectApproachOption(bool enabled)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref enabled;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Customer.NativeMethodInfoPtr_ShowDirectApproachOption_Protected_Virtual_New_Boolean_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06005B09 RID: 23305 RVA: 0x001AAD90 File Offset: 0x001A8F90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 193319, XrefRangeEnd = 193326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool IsUnlockable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Customer.NativeMethodInfoPtr_IsUnlockable_Public_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06005B0A RID: 23306 RVA: 0x001AADD8 File Offset: 0x001A8FD8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 193326, XrefRangeEnd = 193344, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool SampleOptionValid(out string invalidReason)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			ref System.IntPtr ptr2 = ref *ptr;
			System.IntPtr il2CppString = 0;
			ptr2 = &il2CppString;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Customer.NativeMethodInfoPtr_SampleOptionValid_Protected_Virtual_New_Boolean_byref_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			invalidReason = IL2CPP.Il2CppStringToManaged(il2CppString);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06005B0B RID: 23307 RVA: 0x001AAE3C File Offset: 0x001A903C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 193344, XrefRangeEnd = 193352, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool KnownAndRecommended()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_KnownAndRecommended_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06005B0C RID: 23308 RVA: 0x001AAE78 File Offset: 0x001A9078
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 193352, XrefRangeEnd = 193353, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SampleOffered()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_SampleOffered_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005B0D RID: 23309 RVA: 0x001AAEAC File Offset: 0x001A90AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 193353, XrefRangeEnd = 193359, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual float GetSampleRequestSuccessChance()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Customer.NativeMethodInfoPtr_GetSampleRequestSuccessChance_Protected_Virtual_New_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06005B0E RID: 23310 RVA: 0x001AAEF4 File Offset: 0x001A90F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 193359, XrefRangeEnd = 193377, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SampleAccepted()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Customer.NativeMethodInfoPtr_SampleAccepted_Protected_Virtual_New_Void_1), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005B0F RID: 23311 RVA: 0x001AAF30 File Offset: 0x001A9130
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 193405, RefRangeEnd = 193406, XrefRangeStart = 193377, XrefRangeEnd = 193405, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float GetSampleSuccess(List<ItemInstance> items, float price)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(items);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref price;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_GetSampleSuccess_Private_Single_List_1_ItemInstance_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06005B10 RID: 23312 RVA: 0x001AAF8C File Offset: 0x001A918C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 193406, XrefRangeEnd = 193436, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ProcessSample(HandoverScreen.EHandoverOutcome outcome, List<ItemInstance> items, float price)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref outcome;
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(items);
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref price;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_ProcessSample_Private_Void_EHandoverOutcome_List_1_ItemInstance_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005B11 RID: 23313 RVA: 0x001AAFEC File Offset: 0x001A91EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 193436, XrefRangeEnd = 193458, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ProcessSampleServerSide(List<ItemInstance> items)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(items);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_ProcessSampleServerSide_Private_Void_List_1_ItemInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005B12 RID: 23314 RVA: 0x001AB030 File Offset: 0x001A9230
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 193458, XrefRangeEnd = 193479, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ProcessSampleClient()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_ProcessSampleClient_Private_Void_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005B13 RID: 23315 RVA: 0x001AB064 File Offset: 0x001A9264
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 193479, XrefRangeEnd = 193580, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SampleConsumed()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_SampleConsumed_Private_Void_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005B14 RID: 23316 RVA: 0x001AB098 File Offset: 0x001A9298
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 193589, RefRangeEnd = 193592, XrefRangeStart = 193580, XrefRangeEnd = 193589, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EndWait()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_EndWait_Private_Void_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005B15 RID: 23317 RVA: 0x001AB0CC File Offset: 0x001A92CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 193592, XrefRangeEnd = 193612, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void DirectApproachRejected()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Customer.NativeMethodInfoPtr_DirectApproachRejected_Protected_Virtual_New_Void_1), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005B16 RID: 23318 RVA: 0x001AB108 File Offset: 0x001A9308
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 193612, XrefRangeEnd = 193621, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SampleWasSufficient()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_SampleWasSufficient_Private_Void_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005B17 RID: 23319 RVA: 0x001AB13C File Offset: 0x001A933C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 193621, XrefRangeEnd = 193630, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SampleWasInsufficient()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_SampleWasInsufficient_Private_Void_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005B18 RID: 23320 RVA: 0x001AB170 File Offset: 0x001A9370
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 193663, RefRangeEnd = 193668, XrefRangeStart = 193630, XrefRangeEnd = 193663, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float GetProductEnjoyment(ProductDefinition product, EQuality quality)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(product);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref quality;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_GetProductEnjoyment_Public_Single_ProductDefinition_EQuality_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06005B19 RID: 23321 RVA: 0x001AB1CC File Offset: 0x001A93CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 193668, XrefRangeEnd = 193697, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<EDrugType> GetOrderedDrugTypes()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_GetOrderedDrugTypes_Public_List_1_EDrugType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<EDrugType>>(intPtr2) : null;
		}

		// Token: 0x06005B1A RID: 23322 RVA: 0x001AB20C File Offset: 0x001A940C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 193697, XrefRangeEnd = 193708, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AdjustAffinity(EDrugType drugType, float change)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref drugType;
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref change;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_AdjustAffinity_Public_Void_EDrugType_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005B1B RID: 23323 RVA: 0x001AB258 File Offset: 0x001A9458
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 193708, XrefRangeEnd = 193718, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AutocreateCustomerSettings()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_AutocreateCustomerSettings_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005B1C RID: 23324 RVA: 0x001AB28C File Offset: 0x001A948C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 193718, XrefRangeEnd = 193731, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Customer() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Customer>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005B1D RID: 23325 RVA: 0x001AB2C8 File Offset: 0x001A94C8
		[CallerCount(0)]
		public unsafe void _Awake_b__131_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr__Awake_b__131_0_Private_Void_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005B1E RID: 23326 RVA: 0x001AB2FC File Offset: 0x001A94FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 193731, XrefRangeEnd = 193732, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _Start_b__133_1(NPCRelationData.EUnlockType <p0>, bool <p1>)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref <p0>;
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref <p1>;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr__Start_b__133_1_Private_Void_EUnlockType_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005B1F RID: 23327 RVA: 0x001AB348 File Offset: 0x001A9548
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 193758, RefRangeEnd = 193759, XrefRangeStart = 193732, XrefRangeEnd = 193758, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Method_Private_Void_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_Method_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005B20 RID: 23328 RVA: 0x001AB37C File Offset: 0x001A957C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 193759, XrefRangeEnd = 193818, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Method_Private_Void_EHandoverOutcome_List_1_ItemInstance_Single_PDM_0(HandoverScreen.EHandoverOutcome outcome, List<ItemInstance> items, float askingPrice)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref outcome;
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(items);
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref askingPrice;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_Method_Private_Void_EHandoverOutcome_List_1_ItemInstance_Single_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005B21 RID: 23329 RVA: 0x001AB3DC File Offset: 0x001A95DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 193818, XrefRangeEnd = 193819, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _HandoverChosen_b__207_0(HandoverScreen.EHandoverOutcome outcome, List<ItemInstance> items, float price)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref outcome;
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(items);
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref price;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr__HandoverChosen_b__207_0_Private_Void_EHandoverOutcome_List_1_ItemInstance_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005B22 RID: 23330 RVA: 0x001AB43C File Offset: 0x001A963C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 193819, XrefRangeEnd = 193832, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float _GetOrderedDrugTypes_b__225_0(EDrugType x)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref x;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr__GetOrderedDrugTypes_b__225_0_Private_Single_EDrugType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06005B23 RID: 23331 RVA: 0x001AB488 File Offset: 0x001A9688
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 193832, XrefRangeEnd = 193991, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void NetworkInitialize___Early()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Customer.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005B24 RID: 23332 RVA: 0x001AB4C4 File Offset: 0x001A96C4
		[CallerCount(0)]
		public unsafe virtual void NetworkInitialize__Late()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Customer.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005B25 RID: 23333 RVA: 0x001AB500 File Offset: 0x001A9700
		[CallerCount(0)]
		public unsafe override void NetworkInitializeIfDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Customer.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005B26 RID: 23334 RVA: 0x001AB53C File Offset: 0x001A973C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 193991, XrefRangeEnd = 194003, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_ConfigureDealSignal_338960014(NetworkConnection conn, int startTime, bool active)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref startTime;
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref active;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_RpcWriter___Observers_ConfigureDealSignal_338960014_Private_Void_NetworkConnection_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005B27 RID: 23335 RVA: 0x001AB59C File Offset: 0x001A979C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 194006, RefRangeEnd = 194007, XrefRangeStart = 194003, XrefRangeEnd = 194006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___ConfigureDealSignal_338960014(NetworkConnection conn, int startTime, bool active)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref startTime;
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref active;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_RpcLogic___ConfigureDealSignal_338960014_Private_Void_NetworkConnection_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005B28 RID: 23336 RVA: 0x001AB5FC File Offset: 0x001A97FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 194007, XrefRangeEnd = 194012, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_ConfigureDealSignal_338960014(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref channel;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_RpcReader___Observers_ConfigureDealSignal_338960014_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005B29 RID: 23337 RVA: 0x001AB64C File Offset: 0x001A984C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 194012, XrefRangeEnd = 194024, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Target_ConfigureDealSignal_338960014(NetworkConnection conn, int startTime, bool active)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref startTime;
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref active;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_RpcWriter___Target_ConfigureDealSignal_338960014_Private_Void_NetworkConnection_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005B2A RID: 23338 RVA: 0x001AB6AC File Offset: 0x001A98AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 194024, XrefRangeEnd = 194030, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Target_ConfigureDealSignal_338960014(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref channel;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_RpcReader___Target_ConfigureDealSignal_338960014_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005B2B RID: 23339 RVA: 0x001AB6FC File Offset: 0x001A98FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_SetOfferedContract_4277245194(ContractInfo info, GameDateTime offerTime)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref offerTime;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_RpcWriter___Observers_SetOfferedContract_4277245194_Private_Void_ContractInfo_GameDateTime_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005B2C RID: 23340 RVA: 0x001AB74C File Offset: 0x001A994C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 194030, XrefRangeEnd = 194031, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SetOfferedContract_4277245194(ContractInfo info, GameDateTime offerTime)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref offerTime;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_RpcLogic___SetOfferedContract_4277245194_Private_Void_ContractInfo_GameDateTime_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005B2D RID: 23341 RVA: 0x001AB79C File Offset: 0x001A999C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 194031, XrefRangeEnd = 194035, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_SetOfferedContract_4277245194(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref channel;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_RpcReader___Observers_SetOfferedContract_4277245194_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005B2E RID: 23342 RVA: 0x001AB7EC File Offset: 0x001A99EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 194035, XrefRangeEnd = 194044, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_ExpireOffer_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_RpcWriter___Server_ExpireOffer_2166136261_Private_Void_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005B2F RID: 23343 RVA: 0x001AB820 File Offset: 0x001A9A20
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 194051, RefRangeEnd = 194053, XrefRangeStart = 194044, XrefRangeEnd = 194051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void RpcLogic___ExpireOffer_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Customer.NativeMethodInfoPtr_RpcLogic___ExpireOffer_2166136261_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005B30 RID: 23344 RVA: 0x001AB85C File Offset: 0x001A9A5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 194053, XrefRangeEnd = 194056, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_ExpireOffer_2166136261(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref channel;
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_RpcReader___Server_ExpireOffer_2166136261_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005B31 RID: 23345 RVA: 0x001AB8C0 File Offset: 0x001A9AC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 194056, XrefRangeEnd = 194065, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_SendSetUpResponseCallbacks_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_RpcWriter___Server_SendSetUpResponseCallbacks_2166136261_Private_Void_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005B32 RID: 23346 RVA: 0x001AB8F4 File Offset: 0x001A9AF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 194065, XrefRangeEnd = 194066, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SendSetUpResponseCallbacks_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_RpcLogic___SendSetUpResponseCallbacks_2166136261_Private_Void_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005B33 RID: 23347 RVA: 0x001AB928 File Offset: 0x001A9B28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 194066, XrefRangeEnd = 194069, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_SendSetUpResponseCallbacks_2166136261(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref channel;
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_RpcReader___Server_SendSetUpResponseCallbacks_2166136261_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005B34 RID: 23348 RVA: 0x001AB98C File Offset: 0x001A9B8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 194069, XrefRangeEnd = 194078, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_SetUpResponseCallbacks_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_RpcWriter___Observers_SetUpResponseCallbacks_2166136261_Private_Void_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005B35 RID: 23349 RVA: 0x001AB9C0 File Offset: 0x001A9BC0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 194119, RefRangeEnd = 194121, XrefRangeStart = 194078, XrefRangeEnd = 194119, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SetUpResponseCallbacks_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_RpcLogic___SetUpResponseCallbacks_2166136261_Private_Void_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005B36 RID: 23350 RVA: 0x001AB9F4 File Offset: 0x001A9BF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 194121, XrefRangeEnd = 194124, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_SetUpResponseCallbacks_2166136261(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref channel;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_RpcReader___Observers_SetUpResponseCallbacks_2166136261_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005B37 RID: 23351 RVA: 0x001ABA44 File Offset: 0x001A9C44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_ProcessCounterOfferServerSide_900355577(string productID, int quantity, float price)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(productID);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref quantity;
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref price;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_RpcWriter___Server_ProcessCounterOfferServerSide_900355577_Private_Void_String_Int32_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005B38 RID: 23352 RVA: 0x001ABAA4 File Offset: 0x001A9CA4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 194209, RefRangeEnd = 194210, XrefRangeStart = 194124, XrefRangeEnd = 194209, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___ProcessCounterOfferServerSide_900355577(string productID, int quantity, float price)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(productID);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref quantity;
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref price;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_RpcLogic___ProcessCounterOfferServerSide_900355577_Private_Void_String_Int32_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005B39 RID: 23353 RVA: 0x001ABB04 File Offset: 0x001A9D04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 194210, XrefRangeEnd = 194216, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_ProcessCounterOfferServerSide_900355577(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref channel;
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_RpcReader___Server_ProcessCounterOfferServerSide_900355577_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005B3A RID: 23354 RVA: 0x001ABB68 File Offset: 0x001A9D68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 194216, XrefRangeEnd = 194225, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_SetContractIsCounterOffer_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_RpcWriter___Observers_SetContractIsCounterOffer_2166136261_Private_Void_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005B3B RID: 23355 RVA: 0x001ABB9C File Offset: 0x001A9D9C
		[CallerCount(0)]
		public unsafe void RpcLogic___SetContractIsCounterOffer_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_RpcLogic___SetContractIsCounterOffer_2166136261_Private_Void_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005B3C RID: 23356 RVA: 0x001ABBD0 File Offset: 0x001A9DD0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 194225, XrefRangeEnd = 194227, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_SetContractIsCounterOffer_2166136261(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref channel;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_RpcReader___Observers_SetContractIsCounterOffer_2166136261_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005B3D RID: 23357 RVA: 0x001ABC20 File Offset: 0x001A9E20
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_SendContractAccepted_507093020(EDealWindow window, bool trackContract)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref window;
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref trackContract;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_RpcWriter___Server_SendContractAccepted_507093020_Private_Void_EDealWindow_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005B3E RID: 23358 RVA: 0x001ABC6C File Offset: 0x001A9E6C
		[CallerCount(0)]
		public unsafe void RpcLogic___SendContractAccepted_507093020(EDealWindow window, bool trackContract)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref window;
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref trackContract;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_RpcLogic___SendContractAccepted_507093020_Private_Void_EDealWindow_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005B3F RID: 23359 RVA: 0x001ABCB8 File Offset: 0x001A9EB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 194227, XrefRangeEnd = 194229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_SendContractAccepted_507093020(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref channel;
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_RpcReader___Server_SendContractAccepted_507093020_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005B40 RID: 23360 RVA: 0x001ABD1C File Offset: 0x001A9F1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 194229, XrefRangeEnd = 194238, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_ReceiveContractAccepted_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_RpcWriter___Observers_ReceiveContractAccepted_2166136261_Private_Void_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005B41 RID: 23361 RVA: 0x001ABD50 File Offset: 0x001A9F50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 194238, XrefRangeEnd = 194239, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___ReceiveContractAccepted_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_RpcLogic___ReceiveContractAccepted_2166136261_Private_Void_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005B42 RID: 23362 RVA: 0x001ABD84 File Offset: 0x001A9F84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 194239, XrefRangeEnd = 194242, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_ReceiveContractAccepted_2166136261(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref channel;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_RpcReader___Observers_ReceiveContractAccepted_2166136261_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005B43 RID: 23363 RVA: 0x001ABDD4 File Offset: 0x001A9FD4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 194242, XrefRangeEnd = 194251, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_ReceiveContractRejected_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_RpcWriter___Observers_ReceiveContractRejected_2166136261_Private_Void_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005B44 RID: 23364 RVA: 0x001ABE08 File Offset: 0x001AA008
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___ReceiveContractRejected_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_RpcLogic___ReceiveContractRejected_2166136261_Private_Void_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005B45 RID: 23365 RVA: 0x001ABE3C File Offset: 0x001AA03C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_ReceiveContractRejected_2166136261(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref channel;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_RpcReader___Observers_ReceiveContractRejected_2166136261_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005B46 RID: 23366 RVA: 0x001ABE8C File Offset: 0x001AA08C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_ProcessHandoverServerSide_3760244802(HandoverScreen.EHandoverOutcome outcome, List<ItemInstance> items, bool handoverByPlayer, float totalPayment, ProductList productList, float satisfaction, NetworkObject dealer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)7) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref outcome;
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(items);
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref handoverByPlayer;
			ptr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref totalPayment;
			ptr[checked(unchecked((System.UIntPtr)4) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(productList);
			ptr[checked(unchecked((System.UIntPtr)5) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref satisfaction;
			ptr[checked(unchecked((System.UIntPtr)6) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(dealer);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_RpcWriter___Server_ProcessHandoverServerSide_3760244802_Private_Void_EHandoverOutcome_List_1_ItemInstance_Boolean_Single_ProductList_Single_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005B47 RID: 23367 RVA: 0x001ABF2C File Offset: 0x001AA12C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 194413, RefRangeEnd = 194414, XrefRangeStart = 194251, XrefRangeEnd = 194413, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___ProcessHandoverServerSide_3760244802(HandoverScreen.EHandoverOutcome outcome, List<ItemInstance> items, bool handoverByPlayer, float totalPayment, ProductList productList, float satisfaction, NetworkObject dealer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)7) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref outcome;
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(items);
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref handoverByPlayer;
			ptr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref totalPayment;
			ptr[checked(unchecked((System.UIntPtr)4) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(productList);
			ptr[checked(unchecked((System.UIntPtr)5) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref satisfaction;
			ptr[checked(unchecked((System.UIntPtr)6) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(dealer);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_RpcLogic___ProcessHandoverServerSide_3760244802_Private_Void_EHandoverOutcome_List_1_ItemInstance_Boolean_Single_ProductList_Single_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005B48 RID: 23368 RVA: 0x001ABFCC File Offset: 0x001AA1CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 194414, XrefRangeEnd = 194422, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_ProcessHandoverServerSide_3760244802(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref channel;
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_RpcReader___Server_ProcessHandoverServerSide_3760244802_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005B49 RID: 23369 RVA: 0x001AC030 File Offset: 0x001AA230
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_ProcessHandoverClient_537707335(float satisfaction, bool handoverByPlayer, string npcToRecommend)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref satisfaction;
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref handoverByPlayer;
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(npcToRecommend);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_RpcWriter___Observers_ProcessHandoverClient_537707335_Private_Void_Single_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005B4A RID: 23370 RVA: 0x001AC090 File Offset: 0x001AA290
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 194422, XrefRangeEnd = 194428, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___ProcessHandoverClient_537707335(float satisfaction, bool handoverByPlayer, string npcToRecommend)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref satisfaction;
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref handoverByPlayer;
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(npcToRecommend);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_RpcLogic___ProcessHandoverClient_537707335_Private_Void_Single_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005B4B RID: 23371 RVA: 0x001AC0F0 File Offset: 0x001AA2F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 194428, XrefRangeEnd = 194436, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_ProcessHandoverClient_537707335(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref channel;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_RpcReader___Observers_ProcessHandoverClient_537707335_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005B4C RID: 23372 RVA: 0x001AC140 File Offset: 0x001AA340
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 192975, RefRangeEnd = 192977, XrefRangeStart = 192975, XrefRangeEnd = 192977, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_ChangeAddiction_431000436(float change)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref change;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_RpcWriter___Server_ChangeAddiction_431000436_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005B4D RID: 23373 RVA: 0x001AC180 File Offset: 0x001AA380
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 194436, XrefRangeEnd = 194437, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___ChangeAddiction_431000436(float change)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref change;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_RpcLogic___ChangeAddiction_431000436_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005B4E RID: 23374 RVA: 0x001AC1C0 File Offset: 0x001AA3C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 194437, XrefRangeEnd = 194440, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_ChangeAddiction_431000436(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref channel;
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_RpcReader___Server_ChangeAddiction_431000436_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005B4F RID: 23375 RVA: 0x001AC224 File Offset: 0x001AA424
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 193184, RefRangeEnd = 193185, XrefRangeStart = 193184, XrefRangeEnd = 193185, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_RejectProductRequestOffer_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_RpcWriter___Server_RejectProductRequestOffer_2166136261_Private_Void_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005B50 RID: 23376 RVA: 0x001AC258 File Offset: 0x001AA458
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 194472, RefRangeEnd = 194473, XrefRangeStart = 194440, XrefRangeEnd = 194472, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___RejectProductRequestOffer_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_RpcLogic___RejectProductRequestOffer_2166136261_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005B51 RID: 23377 RVA: 0x001AC28C File Offset: 0x001AA48C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 194473, XrefRangeEnd = 194475, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_RejectProductRequestOffer_2166136261(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref channel;
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_RpcReader___Server_RejectProductRequestOffer_2166136261_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005B52 RID: 23378 RVA: 0x001AC2F0 File Offset: 0x001AA4F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 194475, XrefRangeEnd = 194484, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_RejectProductRequestOffer_Local_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_RpcWriter___Observers_RejectProductRequestOffer_Local_2166136261_Private_Void_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005B53 RID: 23379 RVA: 0x001AC324 File Offset: 0x001AA524
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 194493, RefRangeEnd = 194496, XrefRangeStart = 194484, XrefRangeEnd = 194493, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___RejectProductRequestOffer_Local_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_RpcLogic___RejectProductRequestOffer_Local_2166136261_Private_Void_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005B54 RID: 23380 RVA: 0x001AC358 File Offset: 0x001AA558
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 194496, XrefRangeEnd = 194499, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_RejectProductRequestOffer_Local_2166136261(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref channel;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_RpcReader___Observers_RejectProductRequestOffer_Local_2166136261_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005B55 RID: 23381 RVA: 0x001AC3A8 File Offset: 0x001AA5A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Target_ReceiveCustomerData_2280244125(NetworkConnection conn, CustomerData data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(data);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_RpcWriter___Target_ReceiveCustomerData_2280244125_Private_Void_NetworkConnection_CustomerData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005B56 RID: 23382 RVA: 0x001AC3FC File Offset: 0x001AA5FC
		[CallerCount(0)]
		public unsafe void RpcLogic___ReceiveCustomerData_2280244125(NetworkConnection conn, CustomerData data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(data);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_RpcLogic___ReceiveCustomerData_2280244125_Private_Void_NetworkConnection_CustomerData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005B57 RID: 23383 RVA: 0x001AC450 File Offset: 0x001AA650
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 194499, XrefRangeEnd = 194502, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Target_ReceiveCustomerData_2280244125(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref channel;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_RpcReader___Target_ReceiveCustomerData_2280244125_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005B58 RID: 23384 RVA: 0x001AC4A0 File Offset: 0x001AA6A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 194502, XrefRangeEnd = 194512, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_ProcessSampleServerSide_3704012609(List<ItemInstance> items)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(items);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_RpcWriter___Server_ProcessSampleServerSide_3704012609_Private_Void_List_1_ItemInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005B59 RID: 23385 RVA: 0x001AC4E4 File Offset: 0x001AA6E4
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 194550, RefRangeEnd = 194555, XrefRangeStart = 194512, XrefRangeEnd = 194550, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___ProcessSampleServerSide_3704012609(List<ItemInstance> items)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(items);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_RpcLogic___ProcessSampleServerSide_3704012609_Private_Void_List_1_ItemInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005B5A RID: 23386 RVA: 0x001AC528 File Offset: 0x001AA728
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 194555, XrefRangeEnd = 194559, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_ProcessSampleServerSide_3704012609(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref channel;
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_RpcReader___Server_ProcessSampleServerSide_3704012609_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005B5B RID: 23387 RVA: 0x001AC58C File Offset: 0x001AA78C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 194559, XrefRangeEnd = 194568, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_ProcessSampleClient_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_RpcWriter___Observers_ProcessSampleClient_2166136261_Private_Void_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005B5C RID: 23388 RVA: 0x001AC5C0 File Offset: 0x001AA7C0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 194575, RefRangeEnd = 194578, XrefRangeStart = 194568, XrefRangeEnd = 194575, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___ProcessSampleClient_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_RpcLogic___ProcessSampleClient_2166136261_Private_Void_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005B5D RID: 23389 RVA: 0x001AC5F4 File Offset: 0x001AA7F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 194578, XrefRangeEnd = 194581, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_ProcessSampleClient_2166136261(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref channel;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_RpcReader___Observers_ProcessSampleClient_2166136261_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005B5E RID: 23390 RVA: 0x001AC644 File Offset: 0x001AA844
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_SampleWasSufficient_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_RpcWriter___Observers_SampleWasSufficient_2166136261_Private_Void_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005B5F RID: 23391 RVA: 0x001AC678 File Offset: 0x001AA878
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 194581, XrefRangeEnd = 194589, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SampleWasSufficient_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_RpcLogic___SampleWasSufficient_2166136261_Private_Void_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005B60 RID: 23392 RVA: 0x001AC6AC File Offset: 0x001AA8AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 194589, XrefRangeEnd = 194598, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_SampleWasSufficient_2166136261(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref channel;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_RpcReader___Observers_SampleWasSufficient_2166136261_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005B61 RID: 23393 RVA: 0x001AC6FC File Offset: 0x001AA8FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_SampleWasInsufficient_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_RpcWriter___Observers_SampleWasInsufficient_2166136261_Private_Void_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005B62 RID: 23394 RVA: 0x001AC730 File Offset: 0x001AA930
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 194621, RefRangeEnd = 194622, XrefRangeStart = 194598, XrefRangeEnd = 194621, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SampleWasInsufficient_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_RpcLogic___SampleWasInsufficient_2166136261_Private_Void_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005B63 RID: 23395 RVA: 0x001AC764 File Offset: 0x001AA964
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 194622, XrefRangeEnd = 194624, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_SampleWasInsufficient_2166136261(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref channel;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_RpcReader___Observers_SampleWasInsufficient_2166136261_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005B64 RID: 23396 RVA: 0x001AC7B4 File Offset: 0x001AA9B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_AdjustAffinity_3036964899(EDrugType drugType, float change)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref drugType;
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref change;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_RpcWriter___Server_AdjustAffinity_3036964899_Private_Void_EDrugType_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005B65 RID: 23397 RVA: 0x001AC800 File Offset: 0x001AAA00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 194624, XrefRangeEnd = 194637, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___AdjustAffinity_3036964899(EDrugType drugType, float change)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref drugType;
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref change;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_RpcLogic___AdjustAffinity_3036964899_Public_Void_EDrugType_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005B66 RID: 23398 RVA: 0x001AC84C File Offset: 0x001AAA4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 194637, XrefRangeEnd = 194653, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_AdjustAffinity_3036964899(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref channel;
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_RpcReader___Server_AdjustAffinity_3036964899_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x17001B84 RID: 7044
		// (get) Token: 0x06005B67 RID: 23399 RVA: 0x001AC8B0 File Offset: 0x001AAAB0
		// (set) Token: 0x06005B68 RID: 23400 RVA: 0x001AC8EC File Offset: 0x001AAAEC
		public unsafe float SyncAccessor_<CurrentAddiction>k__BackingField
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 89901, RefRangeEnd = 89903, XrefRangeStart = 89901, XrefRangeEnd = 89903, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_sync___get_value__CurrentAddiction_k__BackingField_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 194661, RefRangeEnd = 194662, XrefRangeStart = 194653, XrefRangeEnd = 194661, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = ref value;
				ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref value;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_sync___set_value__CurrentAddiction_k__BackingField_Public_set_Void_Single_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x06005B69 RID: 23401 RVA: 0x001AC938 File Offset: 0x001AAB38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 194662, XrefRangeEnd = 194667, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool ReadSyncVar___ScheduleOne_Economy_Customer(PooledReader PooledReader0, uint UInt321, bool Boolean2)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref UInt321;
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref Boolean2;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Customer.NativeMethodInfoPtr_ReadSyncVar___ScheduleOne_Economy_Customer_Public_Virtual_Boolean_PooledReader_UInt32_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x17001B85 RID: 7045
		// (get) Token: 0x06005B6A RID: 23402 RVA: 0x001AC9AC File Offset: 0x001AABAC
		// (set) Token: 0x06005B6B RID: 23403 RVA: 0x001AC9E8 File Offset: 0x001AABE8
		public unsafe bool SyncAccessor_<HasBeenRecommended>k__BackingField
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_sync___get_value__HasBeenRecommended_k__BackingField_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 194667, XrefRangeEnd = 194675, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = ref value;
				ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref value;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_sync___set_value__HasBeenRecommended_k__BackingField_Public_set_Void_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x06005B6C RID: 23404 RVA: 0x001ACA34 File Offset: 0x001AAC34
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 194705, RefRangeEnd = 194706, XrefRangeStart = 194675, XrefRangeEnd = 194705, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Method_Protected_Virtual_New_Void_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Customer.NativeMethodInfoPtr_Method_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005B6D RID: 23405 RVA: 0x0002AD5E File Offset: 0x00028F5E
		public Customer(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001B2B RID: 6955
		// (get) Token: 0x06005B6E RID: 23406 RVA: 0x001ACA70 File Offset: 0x001AAC70
		// (set) Token: 0x06005B6F RID: 23407 RVA: 0x0002AD67 File Offset: 0x00028F67
		public unsafe static Il2CppSystem.Action<Customer> onCustomerUnlocked
		{
			get
			{
				System.IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Customer.NativeFieldInfoPtr_onCustomerUnlocked, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Action<Customer>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Customer.NativeFieldInfoPtr_onCustomerUnlocked, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001B2C RID: 6956
		// (get) Token: 0x06005B70 RID: 23408 RVA: 0x001ACA98 File Offset: 0x001AAC98
		// (set) Token: 0x06005B71 RID: 23409 RVA: 0x0002AD79 File Offset: 0x00028F79
		public unsafe static List<Customer> UnlockedCustomers
		{
			get
			{
				System.IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Customer.NativeFieldInfoPtr_UnlockedCustomers, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Customer>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Customer.NativeFieldInfoPtr_UnlockedCustomers, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001B2D RID: 6957
		// (get) Token: 0x06005B72 RID: 23410 RVA: 0x001ACAC0 File Offset: 0x001AACC0
		// (set) Token: 0x06005B73 RID: 23411 RVA: 0x0002AD8B File Offset: 0x00028F8B
		public unsafe static float AFFINITY_MAX_EFFECT
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(Customer.NativeFieldInfoPtr_AFFINITY_MAX_EFFECT, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Customer.NativeFieldInfoPtr_AFFINITY_MAX_EFFECT, (void*)(&value));
			}
		}

		// Token: 0x17001B2E RID: 6958
		// (get) Token: 0x06005B74 RID: 23412 RVA: 0x001ACADC File Offset: 0x001AACDC
		// (set) Token: 0x06005B75 RID: 23413 RVA: 0x0002AD99 File Offset: 0x00028F99
		public unsafe static float PROPERTY_MAX_EFFECT
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(Customer.NativeFieldInfoPtr_PROPERTY_MAX_EFFECT, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Customer.NativeFieldInfoPtr_PROPERTY_MAX_EFFECT, (void*)(&value));
			}
		}

		// Token: 0x17001B2F RID: 6959
		// (get) Token: 0x06005B76 RID: 23414 RVA: 0x001ACAF8 File Offset: 0x001AACF8
		// (set) Token: 0x06005B77 RID: 23415 RVA: 0x0002ADA7 File Offset: 0x00028FA7
		public unsafe static float QUALITY_MAX_EFFECT
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(Customer.NativeFieldInfoPtr_QUALITY_MAX_EFFECT, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Customer.NativeFieldInfoPtr_QUALITY_MAX_EFFECT, (void*)(&value));
			}
		}

		// Token: 0x17001B30 RID: 6960
		// (get) Token: 0x06005B78 RID: 23416 RVA: 0x001ACB14 File Offset: 0x001AAD14
		// (set) Token: 0x06005B79 RID: 23417 RVA: 0x0002ADB5 File Offset: 0x00028FB5
		public unsafe static float DEAL_REJECTED_RELATIONSHIP_CHANGE
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(Customer.NativeFieldInfoPtr_DEAL_REJECTED_RELATIONSHIP_CHANGE, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Customer.NativeFieldInfoPtr_DEAL_REJECTED_RELATIONSHIP_CHANGE, (void*)(&value));
			}
		}

		// Token: 0x17001B31 RID: 6961
		// (get) Token: 0x06005B7A RID: 23418 RVA: 0x001ACB30 File Offset: 0x001AAD30
		// (set) Token: 0x06005B7B RID: 23419 RVA: 0x0002ADC3 File Offset: 0x00028FC3
		public unsafe bool DEBUG
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.NativeFieldInfoPtr_DEBUG);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.NativeFieldInfoPtr_DEBUG)) = value;
			}
		}

		// Token: 0x17001B32 RID: 6962
		// (get) Token: 0x06005B7C RID: 23420 RVA: 0x001ACB58 File Offset: 0x001AAD58
		// (set) Token: 0x06005B7D RID: 23421 RVA: 0x0002ADDE File Offset: 0x00028FDE
		public unsafe static float APPROACH_MIN_ADDICTION
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(Customer.NativeFieldInfoPtr_APPROACH_MIN_ADDICTION, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Customer.NativeFieldInfoPtr_APPROACH_MIN_ADDICTION, (void*)(&value));
			}
		}

		// Token: 0x17001B33 RID: 6963
		// (get) Token: 0x06005B7E RID: 23422 RVA: 0x001ACB74 File Offset: 0x001AAD74
		// (set) Token: 0x06005B7F RID: 23423 RVA: 0x0002ADEC File Offset: 0x00028FEC
		public unsafe static float APPROACH_CHANCE_PER_DAY_MAX
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(Customer.NativeFieldInfoPtr_APPROACH_CHANCE_PER_DAY_MAX, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Customer.NativeFieldInfoPtr_APPROACH_CHANCE_PER_DAY_MAX, (void*)(&value));
			}
		}

		// Token: 0x17001B34 RID: 6964
		// (get) Token: 0x06005B80 RID: 23424 RVA: 0x001ACB90 File Offset: 0x001AAD90
		// (set) Token: 0x06005B81 RID: 23425 RVA: 0x0002ADFA File Offset: 0x00028FFA
		public unsafe static float APPROACH_MIN_COOLDOWN
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(Customer.NativeFieldInfoPtr_APPROACH_MIN_COOLDOWN, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Customer.NativeFieldInfoPtr_APPROACH_MIN_COOLDOWN, (void*)(&value));
			}
		}

		// Token: 0x17001B35 RID: 6965
		// (get) Token: 0x06005B82 RID: 23426 RVA: 0x001ACBAC File Offset: 0x001AADAC
		// (set) Token: 0x06005B83 RID: 23427 RVA: 0x0002AE08 File Offset: 0x00029008
		public unsafe static float APPROACH_MAX_COOLDOWN
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(Customer.NativeFieldInfoPtr_APPROACH_MAX_COOLDOWN, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Customer.NativeFieldInfoPtr_APPROACH_MAX_COOLDOWN, (void*)(&value));
			}
		}

		// Token: 0x17001B36 RID: 6966
		// (get) Token: 0x06005B84 RID: 23428 RVA: 0x001ACBC8 File Offset: 0x001AADC8
		// (set) Token: 0x06005B85 RID: 23429 RVA: 0x0002AE16 File Offset: 0x00029016
		public unsafe static int DEAL_COOLDOWN
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(Customer.NativeFieldInfoPtr_DEAL_COOLDOWN, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Customer.NativeFieldInfoPtr_DEAL_COOLDOWN, (void*)(&value));
			}
		}

		// Token: 0x17001B37 RID: 6967
		// (get) Token: 0x06005B86 RID: 23430 RVA: 0x001ACBE4 File Offset: 0x001AADE4
		// (set) Token: 0x06005B87 RID: 23431 RVA: 0x0002AE24 File Offset: 0x00029024
		public unsafe static Il2CppStringArray PlayerAcceptMessages
		{
			get
			{
				System.IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Customer.NativeFieldInfoPtr_PlayerAcceptMessages, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Customer.NativeFieldInfoPtr_PlayerAcceptMessages, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001B38 RID: 6968
		// (get) Token: 0x06005B88 RID: 23432 RVA: 0x001ACC0C File Offset: 0x001AAE0C
		// (set) Token: 0x06005B89 RID: 23433 RVA: 0x0002AE36 File Offset: 0x00029036
		public unsafe static Il2CppStringArray PlayerRejectMessages
		{
			get
			{
				System.IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Customer.NativeFieldInfoPtr_PlayerRejectMessages, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Customer.NativeFieldInfoPtr_PlayerRejectMessages, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001B39 RID: 6969
		// (get) Token: 0x06005B8A RID: 23434 RVA: 0x001ACC34 File Offset: 0x001AAE34
		// (set) Token: 0x06005B8B RID: 23435 RVA: 0x0002AE48 File Offset: 0x00029048
		public unsafe static int DEAL_ATTENDANCE_TOLERANCE
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(Customer.NativeFieldInfoPtr_DEAL_ATTENDANCE_TOLERANCE, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Customer.NativeFieldInfoPtr_DEAL_ATTENDANCE_TOLERANCE, (void*)(&value));
			}
		}

		// Token: 0x17001B3A RID: 6970
		// (get) Token: 0x06005B8C RID: 23436 RVA: 0x001ACC50 File Offset: 0x001AAE50
		// (set) Token: 0x06005B8D RID: 23437 RVA: 0x0002AE56 File Offset: 0x00029056
		public unsafe static int MIN_TRAVEL_TIME
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(Customer.NativeFieldInfoPtr_MIN_TRAVEL_TIME, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Customer.NativeFieldInfoPtr_MIN_TRAVEL_TIME, (void*)(&value));
			}
		}

		// Token: 0x17001B3B RID: 6971
		// (get) Token: 0x06005B8E RID: 23438 RVA: 0x001ACC6C File Offset: 0x001AAE6C
		// (set) Token: 0x06005B8F RID: 23439 RVA: 0x0002AE64 File Offset: 0x00029064
		public unsafe static int MAX_TRAVEL_TIME
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(Customer.NativeFieldInfoPtr_MAX_TRAVEL_TIME, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Customer.NativeFieldInfoPtr_MAX_TRAVEL_TIME, (void*)(&value));
			}
		}

		// Token: 0x17001B3C RID: 6972
		// (get) Token: 0x06005B90 RID: 23440 RVA: 0x001ACC88 File Offset: 0x001AAE88
		// (set) Token: 0x06005B91 RID: 23441 RVA: 0x0002AE72 File Offset: 0x00029072
		public unsafe static int OFFER_EXPIRY_TIME_MINS
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(Customer.NativeFieldInfoPtr_OFFER_EXPIRY_TIME_MINS, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Customer.NativeFieldInfoPtr_OFFER_EXPIRY_TIME_MINS, (void*)(&value));
			}
		}

		// Token: 0x17001B3D RID: 6973
		// (get) Token: 0x06005B92 RID: 23442 RVA: 0x001ACCA4 File Offset: 0x001AAEA4
		// (set) Token: 0x06005B93 RID: 23443 RVA: 0x0002AE80 File Offset: 0x00029080
		public unsafe static float MIN_ORDER_APPEAL
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(Customer.NativeFieldInfoPtr_MIN_ORDER_APPEAL, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Customer.NativeFieldInfoPtr_MIN_ORDER_APPEAL, (void*)(&value));
			}
		}

		// Token: 0x17001B3E RID: 6974
		// (get) Token: 0x06005B94 RID: 23444 RVA: 0x001ACCC0 File Offset: 0x001AAEC0
		// (set) Token: 0x06005B95 RID: 23445 RVA: 0x0002AE8E File Offset: 0x0002908E
		public unsafe static float ADDICTION_DRAIN_PER_DAY
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(Customer.NativeFieldInfoPtr_ADDICTION_DRAIN_PER_DAY, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Customer.NativeFieldInfoPtr_ADDICTION_DRAIN_PER_DAY, (void*)(&value));
			}
		}

		// Token: 0x17001B3F RID: 6975
		// (get) Token: 0x06005B96 RID: 23446 RVA: 0x001ACCDC File Offset: 0x001AAEDC
		// (set) Token: 0x06005B97 RID: 23447 RVA: 0x0002AE9C File Offset: 0x0002909C
		public unsafe static bool SAMPLE_REQUIRES_RECOMMENDATION
		{
			get
			{
				bool result;
				IL2CPP.il2cpp_field_static_get_value(Customer.NativeFieldInfoPtr_SAMPLE_REQUIRES_RECOMMENDATION, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Customer.NativeFieldInfoPtr_SAMPLE_REQUIRES_RECOMMENDATION, (void*)(&value));
			}
		}

		// Token: 0x17001B40 RID: 6976
		// (get) Token: 0x06005B98 RID: 23448 RVA: 0x001ACCF8 File Offset: 0x001AAEF8
		// (set) Token: 0x06005B99 RID: 23449 RVA: 0x0002AEAA File Offset: 0x000290AA
		public unsafe static float MIN_NORMALIZED_RELATIONSHIP_FOR_RECOMMENDATION
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(Customer.NativeFieldInfoPtr_MIN_NORMALIZED_RELATIONSHIP_FOR_RECOMMENDATION, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Customer.NativeFieldInfoPtr_MIN_NORMALIZED_RELATIONSHIP_FOR_RECOMMENDATION, (void*)(&value));
			}
		}

		// Token: 0x17001B41 RID: 6977
		// (get) Token: 0x06005B9A RID: 23450 RVA: 0x001ACD14 File Offset: 0x001AAF14
		// (set) Token: 0x06005B9B RID: 23451 RVA: 0x0002AEB8 File Offset: 0x000290B8
		public unsafe static float RELATIONSHIP_FOR_GUARANTEED_DEALER_RECOMMENDATION
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(Customer.NativeFieldInfoPtr_RELATIONSHIP_FOR_GUARANTEED_DEALER_RECOMMENDATION, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Customer.NativeFieldInfoPtr_RELATIONSHIP_FOR_GUARANTEED_DEALER_RECOMMENDATION, (void*)(&value));
			}
		}

		// Token: 0x17001B42 RID: 6978
		// (get) Token: 0x06005B9C RID: 23452 RVA: 0x001ACD30 File Offset: 0x001AAF30
		// (set) Token: 0x06005B9D RID: 23453 RVA: 0x0002AEC6 File Offset: 0x000290C6
		public unsafe static float RELATIONSHIP_FOR_GUARANTEED_SUPPLIER_RECOMMENDATION
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(Customer.NativeFieldInfoPtr_RELATIONSHIP_FOR_GUARANTEED_SUPPLIER_RECOMMENDATION, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Customer.NativeFieldInfoPtr_RELATIONSHIP_FOR_GUARANTEED_SUPPLIER_RECOMMENDATION, (void*)(&value));
			}
		}

		// Token: 0x17001B43 RID: 6979
		// (get) Token: 0x06005B9E RID: 23454 RVA: 0x001ACD4C File Offset: 0x001AAF4C
		// (set) Token: 0x06005B9F RID: 23455 RVA: 0x0002AED4 File Offset: 0x000290D4
		public unsafe float _CurrentAddiction_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.NativeFieldInfoPtr__CurrentAddiction_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.NativeFieldInfoPtr__CurrentAddiction_k__BackingField)) = value;
			}
		}

		// Token: 0x17001B44 RID: 6980
		// (get) Token: 0x06005BA0 RID: 23456 RVA: 0x001ACD74 File Offset: 0x001AAF74
		// (set) Token: 0x06005BA1 RID: 23457 RVA: 0x0002AEEF File Offset: 0x000290EF
		public unsafe ContractInfo offeredContractInfo
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.NativeFieldInfoPtr_offeredContractInfo);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ContractInfo>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.NativeFieldInfoPtr_offeredContractInfo), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001B45 RID: 6981
		// (get) Token: 0x06005BA2 RID: 23458 RVA: 0x001ACDA4 File Offset: 0x001AAFA4
		// (set) Token: 0x06005BA3 RID: 23459 RVA: 0x0002AF0E File Offset: 0x0002910E
		public unsafe GameDateTime _OfferedContractTime_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.NativeFieldInfoPtr__OfferedContractTime_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.NativeFieldInfoPtr__OfferedContractTime_k__BackingField)) = value;
			}
		}

		// Token: 0x17001B46 RID: 6982
		// (get) Token: 0x06005BA4 RID: 23460 RVA: 0x001ACDCC File Offset: 0x001AAFCC
		// (set) Token: 0x06005BA5 RID: 23461 RVA: 0x0002AF29 File Offset: 0x00029129
		public unsafe Contract _CurrentContract_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.NativeFieldInfoPtr__CurrentContract_k__BackingField);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Contract>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.NativeFieldInfoPtr__CurrentContract_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001B47 RID: 6983
		// (get) Token: 0x06005BA6 RID: 23462 RVA: 0x001ACDFC File Offset: 0x001AAFFC
		// (set) Token: 0x06005BA7 RID: 23463 RVA: 0x0002AF48 File Offset: 0x00029148
		public unsafe bool _IsAwaitingDelivery_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.NativeFieldInfoPtr__IsAwaitingDelivery_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.NativeFieldInfoPtr__IsAwaitingDelivery_k__BackingField)) = value;
			}
		}

		// Token: 0x17001B48 RID: 6984
		// (get) Token: 0x06005BA8 RID: 23464 RVA: 0x001ACE24 File Offset: 0x001AB024
		// (set) Token: 0x06005BA9 RID: 23465 RVA: 0x0002AF63 File Offset: 0x00029163
		public unsafe int _TimeSinceLastDealCompleted_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.NativeFieldInfoPtr__TimeSinceLastDealCompleted_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.NativeFieldInfoPtr__TimeSinceLastDealCompleted_k__BackingField)) = value;
			}
		}

		// Token: 0x17001B49 RID: 6985
		// (get) Token: 0x06005BAA RID: 23466 RVA: 0x001ACE4C File Offset: 0x001AB04C
		// (set) Token: 0x06005BAB RID: 23467 RVA: 0x0002AF7E File Offset: 0x0002917E
		public unsafe int _TimeSinceLastDealOffered_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.NativeFieldInfoPtr__TimeSinceLastDealOffered_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.NativeFieldInfoPtr__TimeSinceLastDealOffered_k__BackingField)) = value;
			}
		}

		// Token: 0x17001B4A RID: 6986
		// (get) Token: 0x06005BAC RID: 23468 RVA: 0x001ACE74 File Offset: 0x001AB074
		// (set) Token: 0x06005BAD RID: 23469 RVA: 0x0002AF99 File Offset: 0x00029199
		public unsafe int _TimeSincePlayerApproached_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.NativeFieldInfoPtr__TimeSincePlayerApproached_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.NativeFieldInfoPtr__TimeSincePlayerApproached_k__BackingField)) = value;
			}
		}

		// Token: 0x17001B4B RID: 6987
		// (get) Token: 0x06005BAE RID: 23470 RVA: 0x001ACE9C File Offset: 0x001AB09C
		// (set) Token: 0x06005BAF RID: 23471 RVA: 0x0002AFB4 File Offset: 0x000291B4
		public unsafe int _TimeSinceInstantDealOffered_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.NativeFieldInfoPtr__TimeSinceInstantDealOffered_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.NativeFieldInfoPtr__TimeSinceInstantDealOffered_k__BackingField)) = value;
			}
		}

		// Token: 0x17001B4C RID: 6988
		// (get) Token: 0x06005BB0 RID: 23472 RVA: 0x001ACEC4 File Offset: 0x001AB0C4
		// (set) Token: 0x06005BB1 RID: 23473 RVA: 0x0002AFCF File Offset: 0x000291CF
		public unsafe int _OfferedDeals_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.NativeFieldInfoPtr__OfferedDeals_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.NativeFieldInfoPtr__OfferedDeals_k__BackingField)) = value;
			}
		}

		// Token: 0x17001B4D RID: 6989
		// (get) Token: 0x06005BB2 RID: 23474 RVA: 0x001ACEEC File Offset: 0x001AB0EC
		// (set) Token: 0x06005BB3 RID: 23475 RVA: 0x0002AFEA File Offset: 0x000291EA
		public unsafe int _CompletedDeliveries_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.NativeFieldInfoPtr__CompletedDeliveries_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.NativeFieldInfoPtr__CompletedDeliveries_k__BackingField)) = value;
			}
		}

		// Token: 0x17001B4E RID: 6990
		// (get) Token: 0x06005BB4 RID: 23476 RVA: 0x001ACF14 File Offset: 0x001AB114
		// (set) Token: 0x06005BB5 RID: 23477 RVA: 0x0002B005 File Offset: 0x00029205
		public unsafe bool _HasBeenRecommended_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.NativeFieldInfoPtr__HasBeenRecommended_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.NativeFieldInfoPtr__HasBeenRecommended_k__BackingField)) = value;
			}
		}

		// Token: 0x17001B4F RID: 6991
		// (get) Token: 0x06005BB6 RID: 23478 RVA: 0x001ACF3C File Offset: 0x001AB13C
		// (set) Token: 0x06005BB7 RID: 23479 RVA: 0x0002B020 File Offset: 0x00029220
		public unsafe NPC _NPC_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.NativeFieldInfoPtr__NPC_k__BackingField);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NPC>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.NativeFieldInfoPtr__NPC_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001B50 RID: 6992
		// (get) Token: 0x06005BB8 RID: 23480 RVA: 0x001ACF6C File Offset: 0x001AB16C
		// (set) Token: 0x06005BB9 RID: 23481 RVA: 0x0002B03F File Offset: 0x0002923F
		public unsafe Dealer _AssignedDealer_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.NativeFieldInfoPtr__AssignedDealer_k__BackingField);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dealer>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.NativeFieldInfoPtr__AssignedDealer_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001B51 RID: 6993
		// (get) Token: 0x06005BBA RID: 23482 RVA: 0x001ACF9C File Offset: 0x001AB19C
		// (set) Token: 0x06005BBB RID: 23483 RVA: 0x0002B05E File Offset: 0x0002925E
		public unsafe NPCSignal_WaitForDelivery DealSignal
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.NativeFieldInfoPtr_DealSignal);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NPCSignal_WaitForDelivery>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.NativeFieldInfoPtr_DealSignal), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001B52 RID: 6994
		// (get) Token: 0x06005BBC RID: 23484 RVA: 0x001ACFCC File Offset: 0x001AB1CC
		// (set) Token: 0x06005BBD RID: 23485 RVA: 0x0002B07D File Offset: 0x0002927D
		public unsafe bool AvailableInDemo
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.NativeFieldInfoPtr_AvailableInDemo);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.NativeFieldInfoPtr_AvailableInDemo)) = value;
			}
		}

		// Token: 0x17001B53 RID: 6995
		// (get) Token: 0x06005BBE RID: 23486 RVA: 0x001ACFF4 File Offset: 0x001AB1F4
		// (set) Token: 0x06005BBF RID: 23487 RVA: 0x0002B098 File Offset: 0x00029298
		public unsafe CustomerData customerData
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.NativeFieldInfoPtr_customerData);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CustomerData>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.NativeFieldInfoPtr_customerData), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001B54 RID: 6996
		// (get) Token: 0x06005BC0 RID: 23488 RVA: 0x001AD024 File Offset: 0x001AB224
		// (set) Token: 0x06005BC1 RID: 23489 RVA: 0x0002B0B7 File Offset: 0x000292B7
		public unsafe DeliveryLocation DefaultDeliveryLocation
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.NativeFieldInfoPtr_DefaultDeliveryLocation);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DeliveryLocation>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.NativeFieldInfoPtr_DefaultDeliveryLocation), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001B55 RID: 6997
		// (get) Token: 0x06005BC2 RID: 23490 RVA: 0x001AD054 File Offset: 0x001AB254
		// (set) Token: 0x06005BC3 RID: 23491 RVA: 0x0002B0D6 File Offset: 0x000292D6
		public unsafe bool CanRecommendFriends
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.NativeFieldInfoPtr_CanRecommendFriends);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.NativeFieldInfoPtr_CanRecommendFriends)) = value;
			}
		}

		// Token: 0x17001B56 RID: 6998
		// (get) Token: 0x06005BC4 RID: 23492 RVA: 0x001AD07C File Offset: 0x001AB27C
		// (set) Token: 0x06005BC5 RID: 23493 RVA: 0x0002B0F1 File Offset: 0x000292F1
		public unsafe UnityEvent onUnlocked
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.NativeFieldInfoPtr_onUnlocked);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.NativeFieldInfoPtr_onUnlocked), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001B57 RID: 6999
		// (get) Token: 0x06005BC6 RID: 23494 RVA: 0x001AD0AC File Offset: 0x001AB2AC
		// (set) Token: 0x06005BC7 RID: 23495 RVA: 0x0002B110 File Offset: 0x00029310
		public unsafe UnityEvent onDealCompleted
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.NativeFieldInfoPtr_onDealCompleted);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.NativeFieldInfoPtr_onDealCompleted), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001B58 RID: 7000
		// (get) Token: 0x06005BC8 RID: 23496 RVA: 0x001AD0DC File Offset: 0x001AB2DC
		// (set) Token: 0x06005BC9 RID: 23497 RVA: 0x0002B12F File Offset: 0x0002932F
		public unsafe UnityEvent<Contract> onContractAssigned
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.NativeFieldInfoPtr_onContractAssigned);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent<Contract>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.NativeFieldInfoPtr_onContractAssigned), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001B59 RID: 7001
		// (get) Token: 0x06005BCA RID: 23498 RVA: 0x001AD10C File Offset: 0x001AB30C
		// (set) Token: 0x06005BCB RID: 23499 RVA: 0x0002B14E File Offset: 0x0002934E
		public unsafe bool awaitingSample
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.NativeFieldInfoPtr_awaitingSample);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.NativeFieldInfoPtr_awaitingSample)) = value;
			}
		}

		// Token: 0x17001B5A RID: 7002
		// (get) Token: 0x06005BCC RID: 23500 RVA: 0x001AD134 File Offset: 0x001AB334
		// (set) Token: 0x06005BCD RID: 23501 RVA: 0x0002B169 File Offset: 0x00029369
		public unsafe DialogueController.DialogueChoice sampleChoice
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.NativeFieldInfoPtr_sampleChoice);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DialogueController.DialogueChoice>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.NativeFieldInfoPtr_sampleChoice), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001B5B RID: 7003
		// (get) Token: 0x06005BCE RID: 23502 RVA: 0x001AD164 File Offset: 0x001AB364
		// (set) Token: 0x06005BCF RID: 23503 RVA: 0x0002B188 File Offset: 0x00029388
		public unsafe DialogueController.DialogueChoice completeContractChoice
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.NativeFieldInfoPtr_completeContractChoice);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DialogueController.DialogueChoice>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.NativeFieldInfoPtr_completeContractChoice), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001B5C RID: 7004
		// (get) Token: 0x06005BD0 RID: 23504 RVA: 0x001AD194 File Offset: 0x001AB394
		// (set) Token: 0x06005BD1 RID: 23505 RVA: 0x0002B1A7 File Offset: 0x000293A7
		public unsafe DialogueController.DialogueChoice offerDealChoice
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.NativeFieldInfoPtr_offerDealChoice);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DialogueController.DialogueChoice>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.NativeFieldInfoPtr_offerDealChoice), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001B5D RID: 7005
		// (get) Token: 0x06005BD2 RID: 23506 RVA: 0x001AD1C4 File Offset: 0x001AB3C4
		// (set) Token: 0x06005BD3 RID: 23507 RVA: 0x0002B1C6 File Offset: 0x000293C6
		public unsafe DialogueController.GreetingOverride awaitingDealGreeting
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.NativeFieldInfoPtr_awaitingDealGreeting);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DialogueController.GreetingOverride>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.NativeFieldInfoPtr_awaitingDealGreeting), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001B5E RID: 7006
		// (get) Token: 0x06005BD4 RID: 23508 RVA: 0x001AD1F4 File Offset: 0x001AB3F4
		// (set) Token: 0x06005BD5 RID: 23509 RVA: 0x0002B1E5 File Offset: 0x000293E5
		public unsafe int minsSinceUnlocked
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.NativeFieldInfoPtr_minsSinceUnlocked);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.NativeFieldInfoPtr_minsSinceUnlocked)) = value;
			}
		}

		// Token: 0x17001B5F RID: 7007
		// (get) Token: 0x06005BD6 RID: 23510 RVA: 0x001AD21C File Offset: 0x001AB41C
		// (set) Token: 0x06005BD7 RID: 23511 RVA: 0x0002B200 File Offset: 0x00029400
		public unsafe bool sampleOfferedToday
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.NativeFieldInfoPtr_sampleOfferedToday);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.NativeFieldInfoPtr_sampleOfferedToday)) = value;
			}
		}

		// Token: 0x17001B60 RID: 7008
		// (get) Token: 0x06005BD8 RID: 23512 RVA: 0x001AD244 File Offset: 0x001AB444
		// (set) Token: 0x06005BD9 RID: 23513 RVA: 0x0002B21B File Offset: 0x0002941B
		public unsafe NPCPoI _potentialCustomerPoI_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.NativeFieldInfoPtr__potentialCustomerPoI_k__BackingField);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NPCPoI>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.NativeFieldInfoPtr__potentialCustomerPoI_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001B61 RID: 7009
		// (get) Token: 0x06005BDA RID: 23514 RVA: 0x001AD274 File Offset: 0x001AB474
		// (set) Token: 0x06005BDB RID: 23515 RVA: 0x0002B23A File Offset: 0x0002943A
		public unsafe CustomerAffinityData currentAffinityData
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.NativeFieldInfoPtr_currentAffinityData);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CustomerAffinityData>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.NativeFieldInfoPtr_currentAffinityData), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001B62 RID: 7010
		// (get) Token: 0x06005BDC RID: 23516 RVA: 0x001AD2A4 File Offset: 0x001AB4A4
		// (set) Token: 0x06005BDD RID: 23517 RVA: 0x0002B259 File Offset: 0x00029459
		public unsafe bool pendingInstantDeal
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.NativeFieldInfoPtr_pendingInstantDeal);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.NativeFieldInfoPtr_pendingInstantDeal)) = value;
			}
		}

		// Token: 0x17001B63 RID: 7011
		// (get) Token: 0x06005BDE RID: 23518 RVA: 0x001AD2CC File Offset: 0x001AB4CC
		// (set) Token: 0x06005BDF RID: 23519 RVA: 0x0002B274 File Offset: 0x00029474
		public unsafe List<string> _LocalExtraFiles_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.NativeFieldInfoPtr__LocalExtraFiles_k__BackingField);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.NativeFieldInfoPtr__LocalExtraFiles_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001B64 RID: 7012
		// (get) Token: 0x06005BE0 RID: 23520 RVA: 0x001AD2FC File Offset: 0x001AB4FC
		// (set) Token: 0x06005BE1 RID: 23521 RVA: 0x0002B293 File Offset: 0x00029493
		public unsafe List<string> _LocalExtraFolders_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.NativeFieldInfoPtr__LocalExtraFolders_k__BackingField);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.NativeFieldInfoPtr__LocalExtraFolders_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001B65 RID: 7013
		// (get) Token: 0x06005BE2 RID: 23522 RVA: 0x001AD32C File Offset: 0x001AB52C
		// (set) Token: 0x06005BE3 RID: 23523 RVA: 0x0002B2B2 File Offset: 0x000294B2
		public unsafe bool _HasChanged_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.NativeFieldInfoPtr__HasChanged_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.NativeFieldInfoPtr__HasChanged_k__BackingField)) = value;
			}
		}

		// Token: 0x17001B66 RID: 7014
		// (get) Token: 0x06005BE4 RID: 23524 RVA: 0x001AD354 File Offset: 0x001AB554
		// (set) Token: 0x06005BE5 RID: 23525 RVA: 0x0002B2CD File Offset: 0x000294CD
		public unsafe ProductItemInstance consumedSample
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.NativeFieldInfoPtr_consumedSample);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ProductItemInstance>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.NativeFieldInfoPtr_consumedSample), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001B67 RID: 7015
		// (get) Token: 0x06005BE6 RID: 23526 RVA: 0x001AD384 File Offset: 0x001AB584
		// (set) Token: 0x06005BE7 RID: 23527 RVA: 0x0002B2EC File Offset: 0x000294EC
		public unsafe SyncVar<float> syncVar____CurrentAddiction_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.NativeFieldInfoPtr_syncVar____CurrentAddiction_k__BackingField);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SyncVar<float>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.NativeFieldInfoPtr_syncVar____CurrentAddiction_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001B68 RID: 7016
		// (get) Token: 0x06005BE8 RID: 23528 RVA: 0x001AD3B4 File Offset: 0x001AB5B4
		// (set) Token: 0x06005BE9 RID: 23529 RVA: 0x0002B30B File Offset: 0x0002950B
		public unsafe SyncVar<bool> syncVar____HasBeenRecommended_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.NativeFieldInfoPtr_syncVar____HasBeenRecommended_k__BackingField);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SyncVar<bool>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.NativeFieldInfoPtr_syncVar____HasBeenRecommended_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001B69 RID: 7017
		// (get) Token: 0x06005BEA RID: 23530 RVA: 0x001AD3E4 File Offset: 0x001AB5E4
		// (set) Token: 0x06005BEB RID: 23531 RVA: 0x0002B32A File Offset: 0x0002952A
		public unsafe bool field_Private_Boolean_0
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.NativeFieldInfoPtr_field_Private_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.NativeFieldInfoPtr_field_Private_Boolean_0)) = value;
			}
		}

		// Token: 0x17001B6A RID: 7018
		// (get) Token: 0x06005BEC RID: 23532 RVA: 0x001AD40C File Offset: 0x001AB60C
		// (set) Token: 0x06005BED RID: 23533 RVA: 0x0002B345 File Offset: 0x00029545
		public unsafe bool field_Private_Boolean_1
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.NativeFieldInfoPtr_field_Private_Boolean_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.NativeFieldInfoPtr_field_Private_Boolean_1)) = value;
			}
		}

		// Token: 0x04003DAA RID: 15786
		private static readonly System.IntPtr NativeFieldInfoPtr_onCustomerUnlocked;

		// Token: 0x04003DAB RID: 15787
		private static readonly System.IntPtr NativeFieldInfoPtr_UnlockedCustomers;

		// Token: 0x04003DAC RID: 15788
		private static readonly System.IntPtr NativeFieldInfoPtr_AFFINITY_MAX_EFFECT;

		// Token: 0x04003DAD RID: 15789
		private static readonly System.IntPtr NativeFieldInfoPtr_PROPERTY_MAX_EFFECT;

		// Token: 0x04003DAE RID: 15790
		private static readonly System.IntPtr NativeFieldInfoPtr_QUALITY_MAX_EFFECT;

		// Token: 0x04003DAF RID: 15791
		private static readonly System.IntPtr NativeFieldInfoPtr_DEAL_REJECTED_RELATIONSHIP_CHANGE;

		// Token: 0x04003DB0 RID: 15792
		private static readonly System.IntPtr NativeFieldInfoPtr_DEBUG;

		// Token: 0x04003DB1 RID: 15793
		private static readonly System.IntPtr NativeFieldInfoPtr_APPROACH_MIN_ADDICTION;

		// Token: 0x04003DB2 RID: 15794
		private static readonly System.IntPtr NativeFieldInfoPtr_APPROACH_CHANCE_PER_DAY_MAX;

		// Token: 0x04003DB3 RID: 15795
		private static readonly System.IntPtr NativeFieldInfoPtr_APPROACH_MIN_COOLDOWN;

		// Token: 0x04003DB4 RID: 15796
		private static readonly System.IntPtr NativeFieldInfoPtr_APPROACH_MAX_COOLDOWN;

		// Token: 0x04003DB5 RID: 15797
		private static readonly System.IntPtr NativeFieldInfoPtr_DEAL_COOLDOWN;

		// Token: 0x04003DB6 RID: 15798
		private static readonly System.IntPtr NativeFieldInfoPtr_PlayerAcceptMessages;

		// Token: 0x04003DB7 RID: 15799
		private static readonly System.IntPtr NativeFieldInfoPtr_PlayerRejectMessages;

		// Token: 0x04003DB8 RID: 15800
		private static readonly System.IntPtr NativeFieldInfoPtr_DEAL_ATTENDANCE_TOLERANCE;

		// Token: 0x04003DB9 RID: 15801
		private static readonly System.IntPtr NativeFieldInfoPtr_MIN_TRAVEL_TIME;

		// Token: 0x04003DBA RID: 15802
		private static readonly System.IntPtr NativeFieldInfoPtr_MAX_TRAVEL_TIME;

		// Token: 0x04003DBB RID: 15803
		private static readonly System.IntPtr NativeFieldInfoPtr_OFFER_EXPIRY_TIME_MINS;

		// Token: 0x04003DBC RID: 15804
		private static readonly System.IntPtr NativeFieldInfoPtr_MIN_ORDER_APPEAL;

		// Token: 0x04003DBD RID: 15805
		private static readonly System.IntPtr NativeFieldInfoPtr_ADDICTION_DRAIN_PER_DAY;

		// Token: 0x04003DBE RID: 15806
		private static readonly System.IntPtr NativeFieldInfoPtr_SAMPLE_REQUIRES_RECOMMENDATION;

		// Token: 0x04003DBF RID: 15807
		private static readonly System.IntPtr NativeFieldInfoPtr_MIN_NORMALIZED_RELATIONSHIP_FOR_RECOMMENDATION;

		// Token: 0x04003DC0 RID: 15808
		private static readonly System.IntPtr NativeFieldInfoPtr_RELATIONSHIP_FOR_GUARANTEED_DEALER_RECOMMENDATION;

		// Token: 0x04003DC1 RID: 15809
		private static readonly System.IntPtr NativeFieldInfoPtr_RELATIONSHIP_FOR_GUARANTEED_SUPPLIER_RECOMMENDATION;

		// Token: 0x04003DC2 RID: 15810
		private static readonly System.IntPtr NativeFieldInfoPtr__CurrentAddiction_k__BackingField;

		// Token: 0x04003DC3 RID: 15811
		private static readonly System.IntPtr NativeFieldInfoPtr_offeredContractInfo;

		// Token: 0x04003DC4 RID: 15812
		private static readonly System.IntPtr NativeFieldInfoPtr__OfferedContractTime_k__BackingField;

		// Token: 0x04003DC5 RID: 15813
		private static readonly System.IntPtr NativeFieldInfoPtr__CurrentContract_k__BackingField;

		// Token: 0x04003DC6 RID: 15814
		private static readonly System.IntPtr NativeFieldInfoPtr__IsAwaitingDelivery_k__BackingField;

		// Token: 0x04003DC7 RID: 15815
		private static readonly System.IntPtr NativeFieldInfoPtr__TimeSinceLastDealCompleted_k__BackingField;

		// Token: 0x04003DC8 RID: 15816
		private static readonly System.IntPtr NativeFieldInfoPtr__TimeSinceLastDealOffered_k__BackingField;

		// Token: 0x04003DC9 RID: 15817
		private static readonly System.IntPtr NativeFieldInfoPtr__TimeSincePlayerApproached_k__BackingField;

		// Token: 0x04003DCA RID: 15818
		private static readonly System.IntPtr NativeFieldInfoPtr__TimeSinceInstantDealOffered_k__BackingField;

		// Token: 0x04003DCB RID: 15819
		private static readonly System.IntPtr NativeFieldInfoPtr__OfferedDeals_k__BackingField;

		// Token: 0x04003DCC RID: 15820
		private static readonly System.IntPtr NativeFieldInfoPtr__CompletedDeliveries_k__BackingField;

		// Token: 0x04003DCD RID: 15821
		private static readonly System.IntPtr NativeFieldInfoPtr__HasBeenRecommended_k__BackingField;

		// Token: 0x04003DCE RID: 15822
		private static readonly System.IntPtr NativeFieldInfoPtr__NPC_k__BackingField;

		// Token: 0x04003DCF RID: 15823
		private static readonly System.IntPtr NativeFieldInfoPtr__AssignedDealer_k__BackingField;

		// Token: 0x04003DD0 RID: 15824
		private static readonly System.IntPtr NativeFieldInfoPtr_DealSignal;

		// Token: 0x04003DD1 RID: 15825
		private static readonly System.IntPtr NativeFieldInfoPtr_AvailableInDemo;

		// Token: 0x04003DD2 RID: 15826
		private static readonly System.IntPtr NativeFieldInfoPtr_customerData;

		// Token: 0x04003DD3 RID: 15827
		private static readonly System.IntPtr NativeFieldInfoPtr_DefaultDeliveryLocation;

		// Token: 0x04003DD4 RID: 15828
		private static readonly System.IntPtr NativeFieldInfoPtr_CanRecommendFriends;

		// Token: 0x04003DD5 RID: 15829
		private static readonly System.IntPtr NativeFieldInfoPtr_onUnlocked;

		// Token: 0x04003DD6 RID: 15830
		private static readonly System.IntPtr NativeFieldInfoPtr_onDealCompleted;

		// Token: 0x04003DD7 RID: 15831
		private static readonly System.IntPtr NativeFieldInfoPtr_onContractAssigned;

		// Token: 0x04003DD8 RID: 15832
		private static readonly System.IntPtr NativeFieldInfoPtr_awaitingSample;

		// Token: 0x04003DD9 RID: 15833
		private static readonly System.IntPtr NativeFieldInfoPtr_sampleChoice;

		// Token: 0x04003DDA RID: 15834
		private static readonly System.IntPtr NativeFieldInfoPtr_completeContractChoice;

		// Token: 0x04003DDB RID: 15835
		private static readonly System.IntPtr NativeFieldInfoPtr_offerDealChoice;

		// Token: 0x04003DDC RID: 15836
		private static readonly System.IntPtr NativeFieldInfoPtr_awaitingDealGreeting;

		// Token: 0x04003DDD RID: 15837
		private static readonly System.IntPtr NativeFieldInfoPtr_minsSinceUnlocked;

		// Token: 0x04003DDE RID: 15838
		private static readonly System.IntPtr NativeFieldInfoPtr_sampleOfferedToday;

		// Token: 0x04003DDF RID: 15839
		private static readonly System.IntPtr NativeFieldInfoPtr__potentialCustomerPoI_k__BackingField;

		// Token: 0x04003DE0 RID: 15840
		private static readonly System.IntPtr NativeFieldInfoPtr_currentAffinityData;

		// Token: 0x04003DE1 RID: 15841
		private static readonly System.IntPtr NativeFieldInfoPtr_pendingInstantDeal;

		// Token: 0x04003DE2 RID: 15842
		private static readonly System.IntPtr NativeFieldInfoPtr__LocalExtraFiles_k__BackingField;

		// Token: 0x04003DE3 RID: 15843
		private static readonly System.IntPtr NativeFieldInfoPtr__LocalExtraFolders_k__BackingField;

		// Token: 0x04003DE4 RID: 15844
		private static readonly System.IntPtr NativeFieldInfoPtr__HasChanged_k__BackingField;

		// Token: 0x04003DE5 RID: 15845
		private static readonly System.IntPtr NativeFieldInfoPtr_consumedSample;

		// Token: 0x04003DE6 RID: 15846
		private static readonly System.IntPtr NativeFieldInfoPtr_syncVar____CurrentAddiction_k__BackingField;

		// Token: 0x04003DE7 RID: 15847
		private static readonly System.IntPtr NativeFieldInfoPtr_syncVar____HasBeenRecommended_k__BackingField;

		// Token: 0x04003DE8 RID: 15848
		private static readonly System.IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

		// Token: 0x04003DE9 RID: 15849
		private static readonly System.IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

		// Token: 0x04003DEA RID: 15850
		private static readonly System.IntPtr NativeMethodInfoPtr_get_CurrentAddiction_Public_get_Single_0;

		// Token: 0x04003DEB RID: 15851
		private static readonly System.IntPtr NativeMethodInfoPtr_set_CurrentAddiction_Protected_set_Void_Single_0;

		// Token: 0x04003DEC RID: 15852
		private static readonly System.IntPtr NativeMethodInfoPtr_get_OfferedContractInfo_Public_get_ContractInfo_0;

		// Token: 0x04003DED RID: 15853
		private static readonly System.IntPtr NativeMethodInfoPtr_set_OfferedContractInfo_Protected_set_Void_ContractInfo_0;

		// Token: 0x04003DEE RID: 15854
		private static readonly System.IntPtr NativeMethodInfoPtr_get_OfferedContractTime_Public_get_GameDateTime_0;

		// Token: 0x04003DEF RID: 15855
		private static readonly System.IntPtr NativeMethodInfoPtr_set_OfferedContractTime_Protected_set_Void_GameDateTime_0;

		// Token: 0x04003DF0 RID: 15856
		private static readonly System.IntPtr NativeMethodInfoPtr_get_CurrentContract_Public_get_Contract_0;

		// Token: 0x04003DF1 RID: 15857
		private static readonly System.IntPtr NativeMethodInfoPtr_set_CurrentContract_Protected_set_Void_Contract_0;

		// Token: 0x04003DF2 RID: 15858
		private static readonly System.IntPtr NativeMethodInfoPtr_get_IsAwaitingDelivery_Public_get_Boolean_0;

		// Token: 0x04003DF3 RID: 15859
		private static readonly System.IntPtr NativeMethodInfoPtr_set_IsAwaitingDelivery_Protected_set_Void_Boolean_0;

		// Token: 0x04003DF4 RID: 15860
		private static readonly System.IntPtr NativeMethodInfoPtr_get_TimeSinceLastDealCompleted_Public_get_Int32_0;

		// Token: 0x04003DF5 RID: 15861
		private static readonly System.IntPtr NativeMethodInfoPtr_set_TimeSinceLastDealCompleted_Protected_set_Void_Int32_0;

		// Token: 0x04003DF6 RID: 15862
		private static readonly System.IntPtr NativeMethodInfoPtr_get_TimeSinceLastDealOffered_Public_get_Int32_0;

		// Token: 0x04003DF7 RID: 15863
		private static readonly System.IntPtr NativeMethodInfoPtr_set_TimeSinceLastDealOffered_Protected_set_Void_Int32_0;

		// Token: 0x04003DF8 RID: 15864
		private static readonly System.IntPtr NativeMethodInfoPtr_get_TimeSincePlayerApproached_Public_get_Int32_0;

		// Token: 0x04003DF9 RID: 15865
		private static readonly System.IntPtr NativeMethodInfoPtr_set_TimeSincePlayerApproached_Protected_set_Void_Int32_0;

		// Token: 0x04003DFA RID: 15866
		private static readonly System.IntPtr NativeMethodInfoPtr_get_TimeSinceInstantDealOffered_Public_get_Int32_0;

		// Token: 0x04003DFB RID: 15867
		private static readonly System.IntPtr NativeMethodInfoPtr_set_TimeSinceInstantDealOffered_Protected_set_Void_Int32_0;

		// Token: 0x04003DFC RID: 15868
		private static readonly System.IntPtr NativeMethodInfoPtr_get_OfferedDeals_Public_get_Int32_0;

		// Token: 0x04003DFD RID: 15869
		private static readonly System.IntPtr NativeMethodInfoPtr_set_OfferedDeals_Protected_set_Void_Int32_0;

		// Token: 0x04003DFE RID: 15870
		private static readonly System.IntPtr NativeMethodInfoPtr_get_CompletedDeliveries_Public_get_Int32_0;

		// Token: 0x04003DFF RID: 15871
		private static readonly System.IntPtr NativeMethodInfoPtr_set_CompletedDeliveries_Protected_set_Void_Int32_0;

		// Token: 0x04003E00 RID: 15872
		private static readonly System.IntPtr NativeMethodInfoPtr_get_HasBeenRecommended_Public_get_Boolean_0;

		// Token: 0x04003E01 RID: 15873
		private static readonly System.IntPtr NativeMethodInfoPtr_set_HasBeenRecommended_Protected_set_Void_Boolean_0;

		// Token: 0x04003E02 RID: 15874
		private static readonly System.IntPtr NativeMethodInfoPtr_get_NPC_Public_get_NPC_0;

		// Token: 0x04003E03 RID: 15875
		private static readonly System.IntPtr NativeMethodInfoPtr_set_NPC_Protected_set_Void_NPC_0;

		// Token: 0x04003E04 RID: 15876
		private static readonly System.IntPtr NativeMethodInfoPtr_get_AssignedDealer_Public_get_Dealer_0;

		// Token: 0x04003E05 RID: 15877
		private static readonly System.IntPtr NativeMethodInfoPtr_set_AssignedDealer_Protected_set_Void_Dealer_0;

		// Token: 0x04003E06 RID: 15878
		private static readonly System.IntPtr NativeMethodInfoPtr_get_CustomerData_Public_get_CustomerData_0;

		// Token: 0x04003E07 RID: 15879
		private static readonly System.IntPtr NativeMethodInfoPtr_get_OrderableProducts_Public_get_List_1_ProductDefinition_0;

		// Token: 0x04003E08 RID: 15880
		private static readonly System.IntPtr NativeMethodInfoPtr_get_dialogueDatabase_Private_get_DialogueDatabase_0;

		// Token: 0x04003E09 RID: 15881
		private static readonly System.IntPtr NativeMethodInfoPtr_get_potentialCustomerPoI_Public_get_NPCPoI_0;

		// Token: 0x04003E0A RID: 15882
		private static readonly System.IntPtr NativeMethodInfoPtr_set_potentialCustomerPoI_Private_set_Void_NPCPoI_0;

		// Token: 0x04003E0B RID: 15883
		private static readonly System.IntPtr NativeMethodInfoPtr_get_SaveFolderName_Public_Virtual_Final_New_get_String_0;

		// Token: 0x04003E0C RID: 15884
		private static readonly System.IntPtr NativeMethodInfoPtr_get_SaveFileName_Public_Virtual_Final_New_get_String_0;

		// Token: 0x04003E0D RID: 15885
		private static readonly System.IntPtr NativeMethodInfoPtr_get_Loader_Public_Virtual_Final_New_get_Loader_0;

		// Token: 0x04003E0E RID: 15886
		private static readonly System.IntPtr NativeMethodInfoPtr_get_ShouldSaveUnderFolder_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x04003E0F RID: 15887
		private static readonly System.IntPtr NativeMethodInfoPtr_get_LocalExtraFiles_Public_Virtual_Final_New_get_List_1_String_0;

		// Token: 0x04003E10 RID: 15888
		private static readonly System.IntPtr NativeMethodInfoPtr_set_LocalExtraFiles_Public_Virtual_Final_New_set_Void_List_1_String_0;

		// Token: 0x04003E11 RID: 15889
		private static readonly System.IntPtr NativeMethodInfoPtr_get_LocalExtraFolders_Public_Virtual_Final_New_get_List_1_String_0;

		// Token: 0x04003E12 RID: 15890
		private static readonly System.IntPtr NativeMethodInfoPtr_set_LocalExtraFolders_Public_Virtual_Final_New_set_Void_List_1_String_0;

		// Token: 0x04003E13 RID: 15891
		private static readonly System.IntPtr NativeMethodInfoPtr_get_HasChanged_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x04003E14 RID: 15892
		private static readonly System.IntPtr NativeMethodInfoPtr_set_HasChanged_Public_Virtual_Final_New_set_Void_Boolean_0;

		// Token: 0x04003E15 RID: 15893
		private static readonly System.IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;

		// Token: 0x04003E16 RID: 15894
		private static readonly System.IntPtr NativeMethodInfoPtr_OnValidate_Protected_Virtual_Void_0;

		// Token: 0x04003E17 RID: 15895
		private static readonly System.IntPtr NativeMethodInfoPtr_Start_Private_Void_1;

		// Token: 0x04003E18 RID: 15896
		private static readonly System.IntPtr NativeMethodInfoPtr_OnStartClient_Public_Virtual_Void_0;

		// Token: 0x04003E19 RID: 15897
		private static readonly System.IntPtr NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0;

		// Token: 0x04003E1A RID: 15898
		private static readonly System.IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_1;

		// Token: 0x04003E1B RID: 15899
		private static readonly System.IntPtr NativeMethodInfoPtr_SetUpDialogue_Private_Void_1;

		// Token: 0x04003E1C RID: 15900
		private static readonly System.IntPtr NativeMethodInfoPtr_SetupPoI_Private_Void_1;

		// Token: 0x04003E1D RID: 15901
		private static readonly System.IntPtr NativeMethodInfoPtr_InitializeSaveable_Public_Virtual_New_Void_0;

		// Token: 0x04003E1E RID: 15902
		private static readonly System.IntPtr NativeMethodInfoPtr_MinPass_Protected_Virtual_New_Void_1;

		// Token: 0x04003E1F RID: 15903
		private static readonly System.IntPtr NativeMethodInfoPtr_DayPass_Protected_Virtual_New_Void_1;

		// Token: 0x04003E20 RID: 15904
		private static readonly System.IntPtr NativeMethodInfoPtr_UpdateDealAttendance_Private_Void_1;

		// Token: 0x04003E21 RID: 15905
		private static readonly System.IntPtr NativeMethodInfoPtr_ConfigureDealSignal_Private_Void_NetworkConnection_Int32_Boolean_0;

		// Token: 0x04003E22 RID: 15906
		private static readonly System.IntPtr NativeMethodInfoPtr_UpdateOfferExpiry_Private_Void_1;

		// Token: 0x04003E23 RID: 15907
		private static readonly System.IntPtr NativeMethodInfoPtr_CheckContractGeneration_Private_ContractInfo_Boolean_0;

		// Token: 0x04003E24 RID: 15908
		private static readonly System.IntPtr NativeMethodInfoPtr_GetWeightedRandomProduct_Private_ProductDefinition_byref_Single_0;

		// Token: 0x04003E25 RID: 15909
		private static readonly System.IntPtr NativeMethodInfoPtr_OnCustomerUnlocked_Protected_Virtual_New_Void_EUnlockType_Boolean_0;

		// Token: 0x04003E26 RID: 15910
		private static readonly System.IntPtr NativeMethodInfoPtr_SetHasBeenRecommended_Public_Void_0;

		// Token: 0x04003E27 RID: 15911
		private static readonly System.IntPtr NativeMethodInfoPtr_OfferContract_Public_Virtual_New_Void_ContractInfo_0;

		// Token: 0x04003E28 RID: 15912
		private static readonly System.IntPtr NativeMethodInfoPtr_SetOfferedContract_Private_Void_ContractInfo_GameDateTime_0;

		// Token: 0x04003E29 RID: 15913
		private static readonly System.IntPtr NativeMethodInfoPtr_ExpireOffer_Public_Virtual_New_Void_0;

		// Token: 0x04003E2A RID: 15914
		private static readonly System.IntPtr NativeMethodInfoPtr_AssignContract_Public_Virtual_New_Void_Contract_0;

		// Token: 0x04003E2B RID: 15915
		private static readonly System.IntPtr NativeMethodInfoPtr_NotifyPlayerOfContract_Protected_Virtual_New_Void_ContractInfo_MessageChain_Boolean_Boolean_Boolean_0;

		// Token: 0x04003E2C RID: 15916
		private static readonly System.IntPtr NativeMethodInfoPtr_SendSetUpResponseCallbacks_Private_Void_1;

		// Token: 0x04003E2D RID: 15917
		private static readonly System.IntPtr NativeMethodInfoPtr_SetUpResponseCallbacks_Private_Void_1;

		// Token: 0x04003E2E RID: 15918
		private static readonly System.IntPtr NativeMethodInfoPtr_AcceptContractClicked_Protected_Virtual_New_Void_1;

		// Token: 0x04003E2F RID: 15919
		private static readonly System.IntPtr NativeMethodInfoPtr_CounterOfferClicked_Protected_Virtual_New_Void_1;

		// Token: 0x04003E30 RID: 15920
		private static readonly System.IntPtr NativeMethodInfoPtr_SendCounteroffer_Protected_Virtual_New_Void_ProductDefinition_Int32_Single_0;

		// Token: 0x04003E31 RID: 15921
		private static readonly System.IntPtr NativeMethodInfoPtr_ProcessCounterOfferServerSide_Private_Void_String_Int32_Single_0;

		// Token: 0x04003E32 RID: 15922
		private static readonly System.IntPtr NativeMethodInfoPtr_SetContractIsCounterOffer_Private_Void_1;

		// Token: 0x04003E33 RID: 15923
		private static readonly System.IntPtr NativeMethodInfoPtr_PlayerAcceptedContract_Protected_Virtual_New_Void_EDealWindow_0;

		// Token: 0x04003E34 RID: 15924
		private static readonly System.IntPtr NativeMethodInfoPtr_SendContractAccepted_Private_Void_EDealWindow_Boolean_0;

		// Token: 0x04003E35 RID: 15925
		private static readonly System.IntPtr NativeMethodInfoPtr_ContractAccepted_Public_Virtual_New_String_EDealWindow_Boolean_0;

		// Token: 0x04003E36 RID: 15926
		private static readonly System.IntPtr NativeMethodInfoPtr_ReceiveContractAccepted_Private_Void_1;

		// Token: 0x04003E37 RID: 15927
		private static readonly System.IntPtr NativeMethodInfoPtr_PlayContractAcceptedReaction_Protected_Virtual_New_Void_1;

		// Token: 0x04003E38 RID: 15928
		private static readonly System.IntPtr NativeMethodInfoPtr_EvaluateCounteroffer_Protected_Virtual_New_Boolean_ProductDefinition_Int32_Single_0;

		// Token: 0x04003E39 RID: 15929
		private static readonly System.IntPtr NativeMethodInfoPtr_GetValueProposition_Public_Static_Single_ProductDefinition_Single_0;

		// Token: 0x04003E3A RID: 15930
		private static readonly System.IntPtr NativeMethodInfoPtr_ContractRejected_Protected_Virtual_New_Void_1;

		// Token: 0x04003E3B RID: 15931
		private static readonly System.IntPtr NativeMethodInfoPtr_ReceiveContractRejected_Private_Void_1;

		// Token: 0x04003E3C RID: 15932
		private static readonly System.IntPtr NativeMethodInfoPtr_PlayContractRejectedReaction_Protected_Virtual_New_Void_1;

		// Token: 0x04003E3D RID: 15933
		private static readonly System.IntPtr NativeMethodInfoPtr_SetIsAwaitingDelivery_Public_Virtual_New_Void_Boolean_0;

		// Token: 0x04003E3E RID: 15934
		private static readonly System.IntPtr NativeMethodInfoPtr_IsAtDealLocation_Public_Boolean_0;

		// Token: 0x04003E3F RID: 15935
		private static readonly System.IntPtr NativeMethodInfoPtr_UpdatePotentialCustomerPoI_Private_Void_1;

		// Token: 0x04003E40 RID: 15936
		private static readonly System.IntPtr NativeMethodInfoPtr_SetPotentialCustomerPoIEnabled_Public_Void_Boolean_0;

		// Token: 0x04003E41 RID: 15937
		private static readonly System.IntPtr NativeMethodInfoPtr_ShouldTryGenerateDeal_Protected_Virtual_New_Boolean_0;

		// Token: 0x04003E42 RID: 15938
		private static readonly System.IntPtr NativeMethodInfoPtr_OfferDealItems_Public_Virtual_New_Void_List_1_ItemInstance_Boolean_byref_Boolean_0;

		// Token: 0x04003E43 RID: 15939
		private static readonly System.IntPtr NativeMethodInfoPtr_CustomerRejectedDeal_Public_Virtual_New_Void_Boolean_0;

		// Token: 0x04003E44 RID: 15940
		private static readonly System.IntPtr NativeMethodInfoPtr_ProcessHandover_Public_Virtual_New_Void_EHandoverOutcome_Contract_List_1_ItemInstance_Boolean_Boolean_0;

		// Token: 0x04003E45 RID: 15941
		private static readonly System.IntPtr NativeMethodInfoPtr_ProcessHandoverServerSide_Private_Void_EHandoverOutcome_List_1_ItemInstance_Boolean_Single_ProductList_Single_NetworkObject_0;

		// Token: 0x04003E46 RID: 15942
		private static readonly System.IntPtr NativeMethodInfoPtr_ProcessHandoverClient_Private_Void_Single_Boolean_String_0;

		// Token: 0x04003E47 RID: 15943
		private static readonly System.IntPtr NativeMethodInfoPtr_ContractWellReceived_Public_Void_String_0;

		// Token: 0x04003E48 RID: 15944
		private static readonly System.IntPtr NativeMethodInfoPtr_RecommendDealer_Private_Void_Dealer_0;

		// Token: 0x04003E49 RID: 15945
		private static readonly System.IntPtr NativeMethodInfoPtr_RecommendSupplier_Private_Void_Supplier_0;

		// Token: 0x04003E4A RID: 15946
		private static readonly System.IntPtr NativeMethodInfoPtr_RecommendCustomer_Private_Void_Customer_0;

		// Token: 0x04003E4B RID: 15947
		private static readonly System.IntPtr NativeMethodInfoPtr_CurrentContractEnded_Public_Virtual_New_Void_EQuestState_0;

		// Token: 0x04003E4C RID: 15948
		private static readonly System.IntPtr NativeMethodInfoPtr_EvaluateDelivery_Public_Virtual_New_Single_Contract_List_1_ItemInstance_byref_Single_byref_EDrugType_byref_Int32_0;

		// Token: 0x04003E4D RID: 15949
		private static readonly System.IntPtr NativeMethodInfoPtr_ChangeAddiction_Public_Void_Single_0;

		// Token: 0x04003E4E RID: 15950
		private static readonly System.IntPtr NativeMethodInfoPtr_ConsumeProduct_Private_Void_ItemInstance_0;

		// Token: 0x04003E4F RID: 15951
		private static readonly System.IntPtr NativeMethodInfoPtr_ShowOfferDealOption_Protected_Virtual_New_Boolean_Boolean_0;

		// Token: 0x04003E50 RID: 15952
		private static readonly System.IntPtr NativeMethodInfoPtr_OfferDealValid_Protected_Virtual_New_Boolean_byref_String_0;

		// Token: 0x04003E51 RID: 15953
		private static readonly System.IntPtr NativeMethodInfoPtr_InstantDealOffered_Protected_Virtual_New_Void_1;

		// Token: 0x04003E52 RID: 15954
		private static readonly System.IntPtr NativeMethodInfoPtr_GetOfferSuccessChance_Public_Single_List_1_ItemInstance_Single_0;

		// Token: 0x04003E53 RID: 15955
		private static readonly System.IntPtr NativeMethodInfoPtr_ShouldTryApproachPlayer_Protected_Virtual_New_Boolean_0;

		// Token: 0x04003E54 RID: 15956
		private static readonly System.IntPtr NativeMethodInfoPtr_RequestProduct_Public_Void_0;

		// Token: 0x04003E55 RID: 15957
		private static readonly System.IntPtr NativeMethodInfoPtr_RequestProduct_Public_Void_Player_0;

		// Token: 0x04003E56 RID: 15958
		private static readonly System.IntPtr NativeMethodInfoPtr_PlayerRejectedProductRequest_Public_Void_0;

		// Token: 0x04003E57 RID: 15959
		private static readonly System.IntPtr NativeMethodInfoPtr_RejectProductRequestOffer_Public_Void_0;

		// Token: 0x04003E58 RID: 15960
		private static readonly System.IntPtr NativeMethodInfoPtr_RejectProductRequestOffer_Local_Private_Void_1;

		// Token: 0x04003E59 RID: 15961
		private static readonly System.IntPtr NativeMethodInfoPtr_AssignDealer_Public_Void_Dealer_0;

		// Token: 0x04003E5A RID: 15962
		private static readonly System.IntPtr NativeMethodInfoPtr_GetSaveString_Public_Virtual_New_String_0;

		// Token: 0x04003E5B RID: 15963
		private static readonly System.IntPtr NativeMethodInfoPtr_GetCustomerData_Public_CustomerData_0;

		// Token: 0x04003E5C RID: 15964
		private static readonly System.IntPtr NativeMethodInfoPtr_WriteData_Public_Virtual_New_List_1_String_String_0;

		// Token: 0x04003E5D RID: 15965
		private static readonly System.IntPtr NativeMethodInfoPtr_ReceiveCustomerData_Private_Void_NetworkConnection_CustomerData_0;

		// Token: 0x04003E5E RID: 15966
		private static readonly System.IntPtr NativeMethodInfoPtr_Load_Public_Virtual_New_Void_CustomerData_0;

		// Token: 0x04003E5F RID: 15967
		private static readonly System.IntPtr NativeMethodInfoPtr_IsReadyForHandover_Protected_Virtual_New_Boolean_Boolean_0;

		// Token: 0x04003E60 RID: 15968
		private static readonly System.IntPtr NativeMethodInfoPtr_IsHandoverChoiceValid_Protected_Virtual_New_Boolean_byref_String_0;

		// Token: 0x04003E61 RID: 15969
		private static readonly System.IntPtr NativeMethodInfoPtr_HandoverChosen_Public_Void_0;

		// Token: 0x04003E62 RID: 15970
		private static readonly System.IntPtr NativeMethodInfoPtr_ShowDirectApproachOption_Protected_Virtual_New_Boolean_Boolean_0;

		// Token: 0x04003E63 RID: 15971
		private static readonly System.IntPtr NativeMethodInfoPtr_IsUnlockable_Public_Virtual_New_Boolean_0;

		// Token: 0x04003E64 RID: 15972
		private static readonly System.IntPtr NativeMethodInfoPtr_SampleOptionValid_Protected_Virtual_New_Boolean_byref_String_0;

		// Token: 0x04003E65 RID: 15973
		private static readonly System.IntPtr NativeMethodInfoPtr_KnownAndRecommended_Public_Boolean_0;

		// Token: 0x04003E66 RID: 15974
		private static readonly System.IntPtr NativeMethodInfoPtr_SampleOffered_Public_Void_0;

		// Token: 0x04003E67 RID: 15975
		private static readonly System.IntPtr NativeMethodInfoPtr_GetSampleRequestSuccessChance_Protected_Virtual_New_Single_0;

		// Token: 0x04003E68 RID: 15976
		private static readonly System.IntPtr NativeMethodInfoPtr_SampleAccepted_Protected_Virtual_New_Void_1;

		// Token: 0x04003E69 RID: 15977
		private static readonly System.IntPtr NativeMethodInfoPtr_GetSampleSuccess_Private_Single_List_1_ItemInstance_Single_0;

		// Token: 0x04003E6A RID: 15978
		private static readonly System.IntPtr NativeMethodInfoPtr_ProcessSample_Private_Void_EHandoverOutcome_List_1_ItemInstance_Single_0;

		// Token: 0x04003E6B RID: 15979
		private static readonly System.IntPtr NativeMethodInfoPtr_ProcessSampleServerSide_Private_Void_List_1_ItemInstance_0;

		// Token: 0x04003E6C RID: 15980
		private static readonly System.IntPtr NativeMethodInfoPtr_ProcessSampleClient_Private_Void_1;

		// Token: 0x04003E6D RID: 15981
		private static readonly System.IntPtr NativeMethodInfoPtr_SampleConsumed_Private_Void_1;

		// Token: 0x04003E6E RID: 15982
		private static readonly System.IntPtr NativeMethodInfoPtr_EndWait_Private_Void_1;

		// Token: 0x04003E6F RID: 15983
		private static readonly System.IntPtr NativeMethodInfoPtr_DirectApproachRejected_Protected_Virtual_New_Void_1;

		// Token: 0x04003E70 RID: 15984
		private static readonly System.IntPtr NativeMethodInfoPtr_SampleWasSufficient_Private_Void_1;

		// Token: 0x04003E71 RID: 15985
		private static readonly System.IntPtr NativeMethodInfoPtr_SampleWasInsufficient_Private_Void_1;

		// Token: 0x04003E72 RID: 15986
		private static readonly System.IntPtr NativeMethodInfoPtr_GetProductEnjoyment_Public_Single_ProductDefinition_EQuality_0;

		// Token: 0x04003E73 RID: 15987
		private static readonly System.IntPtr NativeMethodInfoPtr_GetOrderedDrugTypes_Public_List_1_EDrugType_0;

		// Token: 0x04003E74 RID: 15988
		private static readonly System.IntPtr NativeMethodInfoPtr_AdjustAffinity_Public_Void_EDrugType_Single_0;

		// Token: 0x04003E75 RID: 15989
		private static readonly System.IntPtr NativeMethodInfoPtr_AutocreateCustomerSettings_Public_Void_0;

		// Token: 0x04003E76 RID: 15990
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04003E77 RID: 15991
		private static readonly System.IntPtr NativeMethodInfoPtr__Awake_b__131_0_Private_Void_1;

		// Token: 0x04003E78 RID: 15992
		private static readonly System.IntPtr NativeMethodInfoPtr__Start_b__133_1_Private_Void_EUnlockType_Boolean_0;

		// Token: 0x04003E79 RID: 15993
		private static readonly System.IntPtr NativeMethodInfoPtr_Method_Private_Void_0;

		// Token: 0x04003E7A RID: 15994
		private static readonly System.IntPtr NativeMethodInfoPtr_Method_Private_Void_EHandoverOutcome_List_1_ItemInstance_Single_PDM_0;

		// Token: 0x04003E7B RID: 15995
		private static readonly System.IntPtr NativeMethodInfoPtr__HandoverChosen_b__207_0_Private_Void_EHandoverOutcome_List_1_ItemInstance_Single_0;

		// Token: 0x04003E7C RID: 15996
		private static readonly System.IntPtr NativeMethodInfoPtr__GetOrderedDrugTypes_b__225_0_Private_Single_EDrugType_0;

		// Token: 0x04003E7D RID: 15997
		private static readonly System.IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

		// Token: 0x04003E7E RID: 15998
		private static readonly System.IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

		// Token: 0x04003E7F RID: 15999
		private static readonly System.IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

		// Token: 0x04003E80 RID: 16000
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcWriter___Observers_ConfigureDealSignal_338960014_Private_Void_NetworkConnection_Int32_Boolean_0;

		// Token: 0x04003E81 RID: 16001
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcLogic___ConfigureDealSignal_338960014_Private_Void_NetworkConnection_Int32_Boolean_0;

		// Token: 0x04003E82 RID: 16002
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcReader___Observers_ConfigureDealSignal_338960014_Private_Void_PooledReader_Channel_0;

		// Token: 0x04003E83 RID: 16003
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcWriter___Target_ConfigureDealSignal_338960014_Private_Void_NetworkConnection_Int32_Boolean_0;

		// Token: 0x04003E84 RID: 16004
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcReader___Target_ConfigureDealSignal_338960014_Private_Void_PooledReader_Channel_0;

		// Token: 0x04003E85 RID: 16005
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcWriter___Observers_SetOfferedContract_4277245194_Private_Void_ContractInfo_GameDateTime_0;

		// Token: 0x04003E86 RID: 16006
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcLogic___SetOfferedContract_4277245194_Private_Void_ContractInfo_GameDateTime_0;

		// Token: 0x04003E87 RID: 16007
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcReader___Observers_SetOfferedContract_4277245194_Private_Void_PooledReader_Channel_0;

		// Token: 0x04003E88 RID: 16008
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcWriter___Server_ExpireOffer_2166136261_Private_Void_1;

		// Token: 0x04003E89 RID: 16009
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcLogic___ExpireOffer_2166136261_Public_Virtual_New_Void_0;

		// Token: 0x04003E8A RID: 16010
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcReader___Server_ExpireOffer_2166136261_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x04003E8B RID: 16011
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcWriter___Server_SendSetUpResponseCallbacks_2166136261_Private_Void_1;

		// Token: 0x04003E8C RID: 16012
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcLogic___SendSetUpResponseCallbacks_2166136261_Private_Void_1;

		// Token: 0x04003E8D RID: 16013
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcReader___Server_SendSetUpResponseCallbacks_2166136261_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x04003E8E RID: 16014
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcWriter___Observers_SetUpResponseCallbacks_2166136261_Private_Void_1;

		// Token: 0x04003E8F RID: 16015
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcLogic___SetUpResponseCallbacks_2166136261_Private_Void_1;

		// Token: 0x04003E90 RID: 16016
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcReader___Observers_SetUpResponseCallbacks_2166136261_Private_Void_PooledReader_Channel_0;

		// Token: 0x04003E91 RID: 16017
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcWriter___Server_ProcessCounterOfferServerSide_900355577_Private_Void_String_Int32_Single_0;

		// Token: 0x04003E92 RID: 16018
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcLogic___ProcessCounterOfferServerSide_900355577_Private_Void_String_Int32_Single_0;

		// Token: 0x04003E93 RID: 16019
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcReader___Server_ProcessCounterOfferServerSide_900355577_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x04003E94 RID: 16020
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcWriter___Observers_SetContractIsCounterOffer_2166136261_Private_Void_1;

		// Token: 0x04003E95 RID: 16021
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcLogic___SetContractIsCounterOffer_2166136261_Private_Void_1;

		// Token: 0x04003E96 RID: 16022
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcReader___Observers_SetContractIsCounterOffer_2166136261_Private_Void_PooledReader_Channel_0;

		// Token: 0x04003E97 RID: 16023
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcWriter___Server_SendContractAccepted_507093020_Private_Void_EDealWindow_Boolean_0;

		// Token: 0x04003E98 RID: 16024
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcLogic___SendContractAccepted_507093020_Private_Void_EDealWindow_Boolean_0;

		// Token: 0x04003E99 RID: 16025
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcReader___Server_SendContractAccepted_507093020_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x04003E9A RID: 16026
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcWriter___Observers_ReceiveContractAccepted_2166136261_Private_Void_1;

		// Token: 0x04003E9B RID: 16027
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcLogic___ReceiveContractAccepted_2166136261_Private_Void_1;

		// Token: 0x04003E9C RID: 16028
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcReader___Observers_ReceiveContractAccepted_2166136261_Private_Void_PooledReader_Channel_0;

		// Token: 0x04003E9D RID: 16029
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcWriter___Observers_ReceiveContractRejected_2166136261_Private_Void_1;

		// Token: 0x04003E9E RID: 16030
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcLogic___ReceiveContractRejected_2166136261_Private_Void_1;

		// Token: 0x04003E9F RID: 16031
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcReader___Observers_ReceiveContractRejected_2166136261_Private_Void_PooledReader_Channel_0;

		// Token: 0x04003EA0 RID: 16032
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcWriter___Server_ProcessHandoverServerSide_3760244802_Private_Void_EHandoverOutcome_List_1_ItemInstance_Boolean_Single_ProductList_Single_NetworkObject_0;

		// Token: 0x04003EA1 RID: 16033
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcLogic___ProcessHandoverServerSide_3760244802_Private_Void_EHandoverOutcome_List_1_ItemInstance_Boolean_Single_ProductList_Single_NetworkObject_0;

		// Token: 0x04003EA2 RID: 16034
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcReader___Server_ProcessHandoverServerSide_3760244802_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x04003EA3 RID: 16035
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcWriter___Observers_ProcessHandoverClient_537707335_Private_Void_Single_Boolean_String_0;

		// Token: 0x04003EA4 RID: 16036
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcLogic___ProcessHandoverClient_537707335_Private_Void_Single_Boolean_String_0;

		// Token: 0x04003EA5 RID: 16037
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcReader___Observers_ProcessHandoverClient_537707335_Private_Void_PooledReader_Channel_0;

		// Token: 0x04003EA6 RID: 16038
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcWriter___Server_ChangeAddiction_431000436_Private_Void_Single_0;

		// Token: 0x04003EA7 RID: 16039
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcLogic___ChangeAddiction_431000436_Public_Void_Single_0;

		// Token: 0x04003EA8 RID: 16040
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcReader___Server_ChangeAddiction_431000436_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x04003EA9 RID: 16041
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcWriter___Server_RejectProductRequestOffer_2166136261_Private_Void_1;

		// Token: 0x04003EAA RID: 16042
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcLogic___RejectProductRequestOffer_2166136261_Public_Void_0;

		// Token: 0x04003EAB RID: 16043
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcReader___Server_RejectProductRequestOffer_2166136261_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x04003EAC RID: 16044
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcWriter___Observers_RejectProductRequestOffer_Local_2166136261_Private_Void_1;

		// Token: 0x04003EAD RID: 16045
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcLogic___RejectProductRequestOffer_Local_2166136261_Private_Void_1;

		// Token: 0x04003EAE RID: 16046
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcReader___Observers_RejectProductRequestOffer_Local_2166136261_Private_Void_PooledReader_Channel_0;

		// Token: 0x04003EAF RID: 16047
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcWriter___Target_ReceiveCustomerData_2280244125_Private_Void_NetworkConnection_CustomerData_0;

		// Token: 0x04003EB0 RID: 16048
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcLogic___ReceiveCustomerData_2280244125_Private_Void_NetworkConnection_CustomerData_0;

		// Token: 0x04003EB1 RID: 16049
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcReader___Target_ReceiveCustomerData_2280244125_Private_Void_PooledReader_Channel_0;

		// Token: 0x04003EB2 RID: 16050
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcWriter___Server_ProcessSampleServerSide_3704012609_Private_Void_List_1_ItemInstance_0;

		// Token: 0x04003EB3 RID: 16051
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcLogic___ProcessSampleServerSide_3704012609_Private_Void_List_1_ItemInstance_0;

		// Token: 0x04003EB4 RID: 16052
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcReader___Server_ProcessSampleServerSide_3704012609_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x04003EB5 RID: 16053
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcWriter___Observers_ProcessSampleClient_2166136261_Private_Void_1;

		// Token: 0x04003EB6 RID: 16054
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcLogic___ProcessSampleClient_2166136261_Private_Void_1;

		// Token: 0x04003EB7 RID: 16055
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcReader___Observers_ProcessSampleClient_2166136261_Private_Void_PooledReader_Channel_0;

		// Token: 0x04003EB8 RID: 16056
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcWriter___Observers_SampleWasSufficient_2166136261_Private_Void_1;

		// Token: 0x04003EB9 RID: 16057
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcLogic___SampleWasSufficient_2166136261_Private_Void_1;

		// Token: 0x04003EBA RID: 16058
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcReader___Observers_SampleWasSufficient_2166136261_Private_Void_PooledReader_Channel_0;

		// Token: 0x04003EBB RID: 16059
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcWriter___Observers_SampleWasInsufficient_2166136261_Private_Void_1;

		// Token: 0x04003EBC RID: 16060
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcLogic___SampleWasInsufficient_2166136261_Private_Void_1;

		// Token: 0x04003EBD RID: 16061
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcReader___Observers_SampleWasInsufficient_2166136261_Private_Void_PooledReader_Channel_0;

		// Token: 0x04003EBE RID: 16062
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcWriter___Server_AdjustAffinity_3036964899_Private_Void_EDrugType_Single_0;

		// Token: 0x04003EBF RID: 16063
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcLogic___AdjustAffinity_3036964899_Public_Void_EDrugType_Single_0;

		// Token: 0x04003EC0 RID: 16064
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcReader___Server_AdjustAffinity_3036964899_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x04003EC1 RID: 16065
		private static readonly System.IntPtr NativeMethodInfoPtr_sync___get_value__CurrentAddiction_k__BackingField_Public_get_Single_0;

		// Token: 0x04003EC2 RID: 16066
		private static readonly System.IntPtr NativeMethodInfoPtr_sync___set_value__CurrentAddiction_k__BackingField_Public_set_Void_Single_Boolean_0;

		// Token: 0x04003EC3 RID: 16067
		private static readonly System.IntPtr NativeMethodInfoPtr_ReadSyncVar___ScheduleOne_Economy_Customer_Public_Virtual_Boolean_PooledReader_UInt32_Boolean_0;

		// Token: 0x04003EC4 RID: 16068
		private static readonly System.IntPtr NativeMethodInfoPtr_sync___get_value__HasBeenRecommended_k__BackingField_Public_get_Boolean_0;

		// Token: 0x04003EC5 RID: 16069
		private static readonly System.IntPtr NativeMethodInfoPtr_sync___set_value__HasBeenRecommended_k__BackingField_Public_set_Void_Boolean_Boolean_0;

		// Token: 0x04003EC6 RID: 16070
		private static readonly System.IntPtr NativeMethodInfoPtr_Method_Protected_Virtual_New_Void_0;

		// Token: 0x02000A1F RID: 2591
		[System.Serializable]
		public class ScheduleGroupPair : Il2CppSystem.Object
		{
			// Token: 0x0600D1ED RID: 53741 RVA: 0x0032BA14 File Offset: 0x00329C14
			// Note: this type is marked as 'beforefieldinit'.
			static ScheduleGroupPair()
			{
				Il2CppClassPointerStore<Customer.ScheduleGroupPair>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Customer>.NativeClassPtr, "ScheduleGroupPair");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Customer.ScheduleGroupPair>.NativeClassPtr);
				Customer.ScheduleGroupPair.NativeFieldInfoPtr_NormalScheduleGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Customer.ScheduleGroupPair>.NativeClassPtr, "NormalScheduleGroup");
				Customer.ScheduleGroupPair.NativeFieldInfoPtr_CurfewScheduleGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Customer.ScheduleGroupPair>.NativeClassPtr, "CurfewScheduleGroup");
				Customer.ScheduleGroupPair.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer.ScheduleGroupPair>.NativeClassPtr, 100675039);
			}

			// Token: 0x0600D1EE RID: 53742 RVA: 0x0032BA7C File Offset: 0x00329C7C
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ScheduleGroupPair() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Customer.ScheduleGroupPair>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.ScheduleGroupPair.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600D1EF RID: 53743 RVA: 0x00065C6C File Offset: 0x00063E6C
			public ScheduleGroupPair(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004111 RID: 16657
			// (get) Token: 0x0600D1F0 RID: 53744 RVA: 0x0032BAB8 File Offset: 0x00329CB8
			// (set) Token: 0x0600D1F1 RID: 53745 RVA: 0x00065C75 File Offset: 0x00063E75
			public unsafe GameObject NormalScheduleGroup
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.ScheduleGroupPair.NativeFieldInfoPtr_NormalScheduleGroup);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.ScheduleGroupPair.NativeFieldInfoPtr_NormalScheduleGroup), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004112 RID: 16658
			// (get) Token: 0x0600D1F2 RID: 53746 RVA: 0x0032BAE8 File Offset: 0x00329CE8
			// (set) Token: 0x0600D1F3 RID: 53747 RVA: 0x00065C94 File Offset: 0x00063E94
			public unsafe GameObject CurfewScheduleGroup
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.ScheduleGroupPair.NativeFieldInfoPtr_CurfewScheduleGroup);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.ScheduleGroupPair.NativeFieldInfoPtr_CurfewScheduleGroup), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008DF3 RID: 36339
			private static readonly System.IntPtr NativeFieldInfoPtr_NormalScheduleGroup;

			// Token: 0x04008DF4 RID: 36340
			private static readonly System.IntPtr NativeFieldInfoPtr_CurfewScheduleGroup;

			// Token: 0x04008DF5 RID: 36341
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000A20 RID: 2592
		[System.Serializable]
		public class CustomerPreference : Il2CppSystem.Object
		{
			// Token: 0x0600D1F4 RID: 53748 RVA: 0x0032BB18 File Offset: 0x00329D18
			// Note: this type is marked as 'beforefieldinit'.
			static CustomerPreference()
			{
				Il2CppClassPointerStore<Customer.CustomerPreference>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Customer>.NativeClassPtr, "CustomerPreference");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Customer.CustomerPreference>.NativeClassPtr);
				Customer.CustomerPreference.NativeFieldInfoPtr_DrugType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Customer.CustomerPreference>.NativeClassPtr, "DrugType");
				Customer.CustomerPreference.NativeFieldInfoPtr_Definition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Customer.CustomerPreference>.NativeClassPtr, "Definition");
				Customer.CustomerPreference.NativeFieldInfoPtr_MinimumQuality = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Customer.CustomerPreference>.NativeClassPtr, "MinimumQuality");
				Customer.CustomerPreference.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer.CustomerPreference>.NativeClassPtr, 100675040);
			}

			// Token: 0x0600D1F5 RID: 53749 RVA: 0x0032BB94 File Offset: 0x00329D94
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe CustomerPreference() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Customer.CustomerPreference>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.CustomerPreference.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600D1F6 RID: 53750 RVA: 0x00065CB3 File Offset: 0x00063EB3
			public CustomerPreference(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004113 RID: 16659
			// (get) Token: 0x0600D1F7 RID: 53751 RVA: 0x0032BBD0 File Offset: 0x00329DD0
			// (set) Token: 0x0600D1F8 RID: 53752 RVA: 0x00065CBC File Offset: 0x00063EBC
			public unsafe EDrugType DrugType
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.CustomerPreference.NativeFieldInfoPtr_DrugType);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.CustomerPreference.NativeFieldInfoPtr_DrugType)) = value;
				}
			}

			// Token: 0x17004114 RID: 16660
			// (get) Token: 0x0600D1F9 RID: 53753 RVA: 0x0032BBF8 File Offset: 0x00329DF8
			// (set) Token: 0x0600D1FA RID: 53754 RVA: 0x00065CD7 File Offset: 0x00063ED7
			public unsafe ProductDefinition Definition
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.CustomerPreference.NativeFieldInfoPtr_Definition);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ProductDefinition>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.CustomerPreference.NativeFieldInfoPtr_Definition), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004115 RID: 16661
			// (get) Token: 0x0600D1FB RID: 53755 RVA: 0x0032BC28 File Offset: 0x00329E28
			// (set) Token: 0x0600D1FC RID: 53756 RVA: 0x00065CF6 File Offset: 0x00063EF6
			public unsafe EQuality MinimumQuality
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.CustomerPreference.NativeFieldInfoPtr_MinimumQuality);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.CustomerPreference.NativeFieldInfoPtr_MinimumQuality)) = value;
				}
			}

			// Token: 0x04008DF6 RID: 36342
			private static readonly System.IntPtr NativeFieldInfoPtr_DrugType;

			// Token: 0x04008DF7 RID: 36343
			private static readonly System.IntPtr NativeFieldInfoPtr_Definition;

			// Token: 0x04008DF8 RID: 36344
			private static readonly System.IntPtr NativeFieldInfoPtr_MinimumQuality;

			// Token: 0x04008DF9 RID: 36345
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000A21 RID: 2593
		[OriginalName("Assembly-CSharp.dll", "", "ESampleFeedback")]
		public enum ESampleFeedback
		{
			// Token: 0x04008DFB RID: 36347
			WrongProduct,
			// Token: 0x04008DFC RID: 36348
			WrongQuality,
			// Token: 0x04008DFD RID: 36349
			Correct
		}

		// Token: 0x02000A22 RID: 2594
		[ObfuscatedName("ScheduleOne.Economy.Customer+<>c")]
		[System.Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x0600D1FD RID: 53757 RVA: 0x0032BC50 File Offset: 0x00329E50
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<Customer.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Customer>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Customer.__c>.NativeClassPtr);
				Customer.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Customer.__c>.NativeClassPtr, "<>9");
				Customer.__c.NativeFieldInfoPtr___9__132_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Customer.__c>.NativeClassPtr, "<>9__132_0");
				Customer.__c.NativeFieldInfoPtr___9__186_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Customer.__c>.NativeClassPtr, "<>9__186_1");
				Customer.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer.__c>.NativeClassPtr, 100675042);
				Customer.__c.NativeMethodInfoPtr__OnValidate_b__132_0_Internal_Boolean_NPCAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer.__c>.NativeClassPtr, 100675043);
				Customer.__c.NativeMethodInfoPtr__EvaluateDelivery_b__186_1_Internal_EQuality_ProductItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer.__c>.NativeClassPtr, 100675044);
			}

			// Token: 0x0600D1FE RID: 53758 RVA: 0x0032BCF4 File Offset: 0x00329EF4
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Customer.__c>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600D1FF RID: 53759 RVA: 0x0032BD30 File Offset: 0x00329F30
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 190934, XrefRangeEnd = 190940, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _OnValidate_b__132_0(NPCAction x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Customer.__c.NativeMethodInfoPtr__OnValidate_b__132_0_Internal_Boolean_NPCAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x0600D200 RID: 53760 RVA: 0x0032BD80 File Offset: 0x00329F80
			[CallerCount(0)]
			public unsafe EQuality _EvaluateDelivery_b__186_1(ProductItemInstance x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Customer.__c.NativeMethodInfoPtr__EvaluateDelivery_b__186_1_Internal_EQuality_ProductItemInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x0600D201 RID: 53761 RVA: 0x00065D11 File Offset: 0x00063F11
			public __c(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004116 RID: 16662
			// (get) Token: 0x0600D202 RID: 53762 RVA: 0x0032BDD0 File Offset: 0x00329FD0
			// (set) Token: 0x0600D203 RID: 53763 RVA: 0x00065D1A File Offset: 0x00063F1A
			public unsafe static Customer.__c __9
			{
				get
				{
					System.IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Customer.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Customer.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Customer.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004117 RID: 16663
			// (get) Token: 0x0600D204 RID: 53764 RVA: 0x0032BDF8 File Offset: 0x00329FF8
			// (set) Token: 0x0600D205 RID: 53765 RVA: 0x00065D2C File Offset: 0x00063F2C
			public unsafe static Il2CppSystem.Predicate<NPCAction> __9__132_0
			{
				get
				{
					System.IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Customer.__c.NativeFieldInfoPtr___9__132_0, (void*)(&intPtr));
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Predicate<NPCAction>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Customer.__c.NativeFieldInfoPtr___9__132_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004118 RID: 16664
			// (get) Token: 0x0600D206 RID: 53766 RVA: 0x0032BE20 File Offset: 0x0032A020
			// (set) Token: 0x0600D207 RID: 53767 RVA: 0x00065D3E File Offset: 0x00063F3E
			public unsafe static Il2CppSystem.Func<ProductItemInstance, EQuality> __9__186_1
			{
				get
				{
					System.IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Customer.__c.NativeFieldInfoPtr___9__186_1, (void*)(&intPtr));
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Func<ProductItemInstance, EQuality>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Customer.__c.NativeFieldInfoPtr___9__186_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008DFE RID: 36350
			private static readonly System.IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04008DFF RID: 36351
			private static readonly System.IntPtr NativeFieldInfoPtr___9__132_0;

			// Token: 0x04008E00 RID: 36352
			private static readonly System.IntPtr NativeFieldInfoPtr___9__186_1;

			// Token: 0x04008E01 RID: 36353
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008E02 RID: 36354
			private static readonly System.IntPtr NativeMethodInfoPtr__OnValidate_b__132_0_Internal_Boolean_NPCAction_0;

			// Token: 0x04008E03 RID: 36355
			private static readonly System.IntPtr NativeMethodInfoPtr__EvaluateDelivery_b__186_1_Internal_EQuality_ProductItemInstance_0;
		}

		// Token: 0x02000A23 RID: 2595
		[ObfuscatedName("ScheduleOne.Economy.Customer+<>c__DisplayClass146_0")]
		public sealed class __c__DisplayClass146_0 : Il2CppSystem.Object
		{
			// Token: 0x0600D208 RID: 53768 RVA: 0x0032BE48 File Offset: 0x0032A048
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass146_0()
			{
				Il2CppClassPointerStore<Customer.__c__DisplayClass146_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Customer>.NativeClassPtr, "<>c__DisplayClass146_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Customer.__c__DisplayClass146_0>.NativeClassPtr);
				Customer.__c__DisplayClass146_0.NativeFieldInfoPtr_productAppeal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Customer.__c__DisplayClass146_0>.NativeClassPtr, "productAppeal");
				Customer.__c__DisplayClass146_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer.__c__DisplayClass146_0>.NativeClassPtr, 100675045);
				Customer.__c__DisplayClass146_0.NativeMethodInfoPtr__GetWeightedRandomProduct_b__0_Internal_Single_ProductDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer.__c__DisplayClass146_0>.NativeClassPtr, 100675046);
			}

			// Token: 0x0600D209 RID: 53769 RVA: 0x0032BEB0 File Offset: 0x0032A0B0
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass146_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Customer.__c__DisplayClass146_0>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.__c__DisplayClass146_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600D20A RID: 53770 RVA: 0x0032BEEC File Offset: 0x0032A0EC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 190940, XrefRangeEnd = 190944, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe float _GetWeightedRandomProduct_b__0(ProductDefinition x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Customer.__c__DisplayClass146_0.NativeMethodInfoPtr__GetWeightedRandomProduct_b__0_Internal_Single_ProductDefinition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x0600D20B RID: 53771 RVA: 0x00065D50 File Offset: 0x00063F50
			public __c__DisplayClass146_0(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004119 RID: 16665
			// (get) Token: 0x0600D20C RID: 53772 RVA: 0x0032BF3C File Offset: 0x0032A13C
			// (set) Token: 0x0600D20D RID: 53773 RVA: 0x00065D59 File Offset: 0x00063F59
			public unsafe Dictionary<ProductDefinition, float> productAppeal
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.__c__DisplayClass146_0.NativeFieldInfoPtr_productAppeal);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<ProductDefinition, float>>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.__c__DisplayClass146_0.NativeFieldInfoPtr_productAppeal), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008E04 RID: 36356
			private static readonly System.IntPtr NativeFieldInfoPtr_productAppeal;

			// Token: 0x04008E05 RID: 36357
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008E06 RID: 36358
			private static readonly System.IntPtr NativeMethodInfoPtr__GetWeightedRandomProduct_b__0_Internal_Single_ProductDefinition_0;
		}

		// Token: 0x02000A24 RID: 2596
		[ObfuscatedName("ScheduleOne.Economy.Customer+<>c__DisplayClass182_0")]
		public sealed class __c__DisplayClass182_0 : Il2CppSystem.Object
		{
			// Token: 0x0600D20E RID: 53774 RVA: 0x0032BF6C File Offset: 0x0032A16C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass182_0()
			{
				Il2CppClassPointerStore<Customer.__c__DisplayClass182_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Customer>.NativeClassPtr, "<>c__DisplayClass182_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Customer.__c__DisplayClass182_0>.NativeClassPtr);
				Customer.__c__DisplayClass182_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Customer.__c__DisplayClass182_0>.NativeClassPtr, "<>4__this");
				Customer.__c__DisplayClass182_0.NativeFieldInfoPtr_alreadyRecommended = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Customer.__c__DisplayClass182_0>.NativeClassPtr, "alreadyRecommended");
				Customer.__c__DisplayClass182_0.NativeFieldInfoPtr_dealer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Customer.__c__DisplayClass182_0>.NativeClassPtr, "dealer");
				Customer.__c__DisplayClass182_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer.__c__DisplayClass182_0>.NativeClassPtr, 100675047);
				Customer.__c__DisplayClass182_0.NativeMethodInfoPtr__RecommendDealer_b__1_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer.__c__DisplayClass182_0>.NativeClassPtr, 100675048);
			}

			// Token: 0x0600D20F RID: 53775 RVA: 0x0032BFFC File Offset: 0x0032A1FC
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass182_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Customer.__c__DisplayClass182_0>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.__c__DisplayClass182_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600D210 RID: 53776 RVA: 0x0032C038 File Offset: 0x0032A238
			[CallerCount(0)]
			public unsafe bool _RecommendDealer_b__1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Customer.__c__DisplayClass182_0.NativeMethodInfoPtr__RecommendDealer_b__1_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x0600D211 RID: 53777 RVA: 0x00065D78 File Offset: 0x00063F78
			public __c__DisplayClass182_0(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700411A RID: 16666
			// (get) Token: 0x0600D212 RID: 53778 RVA: 0x0032C074 File Offset: 0x0032A274
			// (set) Token: 0x0600D213 RID: 53779 RVA: 0x00065D81 File Offset: 0x00063F81
			public unsafe Customer __4__this
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.__c__DisplayClass182_0.NativeFieldInfoPtr___4__this);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Customer>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.__c__DisplayClass182_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700411B RID: 16667
			// (get) Token: 0x0600D214 RID: 53780 RVA: 0x0032C0A4 File Offset: 0x0032A2A4
			// (set) Token: 0x0600D215 RID: 53781 RVA: 0x00065DA0 File Offset: 0x00063FA0
			public unsafe bool alreadyRecommended
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.__c__DisplayClass182_0.NativeFieldInfoPtr_alreadyRecommended);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.__c__DisplayClass182_0.NativeFieldInfoPtr_alreadyRecommended)) = value;
				}
			}

			// Token: 0x1700411C RID: 16668
			// (get) Token: 0x0600D216 RID: 53782 RVA: 0x0032C0CC File Offset: 0x0032A2CC
			// (set) Token: 0x0600D217 RID: 53783 RVA: 0x00065DBB File Offset: 0x00063FBB
			public unsafe Dealer dealer
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.__c__DisplayClass182_0.NativeFieldInfoPtr_dealer);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dealer>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.__c__DisplayClass182_0.NativeFieldInfoPtr_dealer), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008E07 RID: 36359
			private static readonly System.IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04008E08 RID: 36360
			private static readonly System.IntPtr NativeFieldInfoPtr_alreadyRecommended;

			// Token: 0x04008E09 RID: 36361
			private static readonly System.IntPtr NativeFieldInfoPtr_dealer;

			// Token: 0x04008E0A RID: 36362
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008E0B RID: 36363
			private static readonly System.IntPtr NativeMethodInfoPtr__RecommendDealer_b__1_Internal_Boolean_0;
		}

		// Token: 0x02000A25 RID: 2597
		[ObfuscatedName("ScheduleOne.Economy.Customer+<>c__DisplayClass182_1")]
		public sealed class __c__DisplayClass182_1 : Il2CppSystem.Object
		{
			// Token: 0x0600D218 RID: 53784 RVA: 0x0032C0FC File Offset: 0x0032A2FC
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass182_1()
			{
				Il2CppClassPointerStore<Customer.__c__DisplayClass182_1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Customer>.NativeClassPtr, "<>c__DisplayClass182_1");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Customer.__c__DisplayClass182_1>.NativeClassPtr);
				Customer.__c__DisplayClass182_1.NativeFieldInfoPtr_container = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Customer.__c__DisplayClass182_1>.NativeClassPtr, "container");
				Customer.__c__DisplayClass182_1.NativeFieldInfoPtr_field_Public___c__DisplayClass182_0_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Customer.__c__DisplayClass182_1>.NativeClassPtr, "CS$<>8__locals1");
				Customer.__c__DisplayClass182_1.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer.__c__DisplayClass182_1>.NativeClassPtr, 100675049);
				Customer.__c__DisplayClass182_1.NativeMethodInfoPtr_Method_Internal_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer.__c__DisplayClass182_1>.NativeClassPtr, 100675050);
			}

			// Token: 0x0600D219 RID: 53785 RVA: 0x0032C178 File Offset: 0x0032A378
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass182_1() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Customer.__c__DisplayClass182_1>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.__c__DisplayClass182_1.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600D21A RID: 53786 RVA: 0x0032C1B4 File Offset: 0x0032A3B4
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 190968, RefRangeEnd = 190969, XrefRangeStart = 190963, XrefRangeEnd = 190968, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator Method_Internal_IEnumerator_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.__c__DisplayClass182_1.NativeMethodInfoPtr_Method_Internal_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr2) : null;
			}

			// Token: 0x0600D21B RID: 53787 RVA: 0x00065DDA File Offset: 0x00063FDA
			public __c__DisplayClass182_1(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700411D RID: 16669
			// (get) Token: 0x0600D21C RID: 53788 RVA: 0x0032C1F4 File Offset: 0x0032A3F4
			// (set) Token: 0x0600D21D RID: 53789 RVA: 0x00065DE3 File Offset: 0x00063FE3
			public unsafe DialogueContainer container
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.__c__DisplayClass182_1.NativeFieldInfoPtr_container);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DialogueContainer>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.__c__DisplayClass182_1.NativeFieldInfoPtr_container), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700411E RID: 16670
			// (get) Token: 0x0600D21E RID: 53790 RVA: 0x0032C224 File Offset: 0x0032A424
			// (set) Token: 0x0600D21F RID: 53791 RVA: 0x00065E02 File Offset: 0x00064002
			public unsafe Customer.__c__DisplayClass182_0 field_Public___c__DisplayClass182_0_0
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.__c__DisplayClass182_1.NativeFieldInfoPtr_field_Public___c__DisplayClass182_0_0);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Customer.__c__DisplayClass182_0>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.__c__DisplayClass182_1.NativeFieldInfoPtr_field_Public___c__DisplayClass182_0_0), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008E0C RID: 36364
			private static readonly System.IntPtr NativeFieldInfoPtr_container;

			// Token: 0x04008E0D RID: 36365
			private static readonly System.IntPtr NativeFieldInfoPtr_field_Public___c__DisplayClass182_0_0;

			// Token: 0x04008E0E RID: 36366
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008E0F RID: 36367
			private static readonly System.IntPtr NativeMethodInfoPtr_Method_Internal_IEnumerator_0;

			// Token: 0x02000CAA RID: 3242
			[ObfuscatedName("ScheduleOne.Economy.Customer+<>c__DisplayClass182_1+<<RecommendDealer>g__Wait|0>d")]
			public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique : Il2CppSystem.Object
			{
				// Token: 0x0600E8A7 RID: 59559 RVA: 0x0036BD3C File Offset: 0x00369F3C
				// Note: this type is marked as 'beforefieldinit'.
				static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique()
				{
					Il2CppClassPointerStore<Customer.__c__DisplayClass182_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Customer.__c__DisplayClass182_1>.NativeClassPtr, "<<RecommendDealer>g__Wait|0>d");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Customer.__c__DisplayClass182_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr);
					Customer.__c__DisplayClass182_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Customer.__c__DisplayClass182_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>1__state");
					Customer.__c__DisplayClass182_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Customer.__c__DisplayClass182_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>2__current");
					Customer.__c__DisplayClass182_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Customer.__c__DisplayClass182_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>4__this");
					Customer.__c__DisplayClass182_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer.__c__DisplayClass182_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100675051);
					Customer.__c__DisplayClass182_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer.__c__DisplayClass182_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100675052);
					Customer.__c__DisplayClass182_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer.__c__DisplayClass182_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100675053);
					Customer.__c__DisplayClass182_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer.__c__DisplayClass182_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100675054);
					Customer.__c__DisplayClass182_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer.__c__DisplayClass182_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100675055);
					Customer.__c__DisplayClass182_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer.__c__DisplayClass182_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100675056);
				}

				// Token: 0x0600E8A8 RID: 59560 RVA: 0x0036BE1C File Offset: 0x0036A01C
				[CallerCount(54)]
				[CachedScanResults(RefRangeStart = 2646, RefRangeEnd = 2700, XrefRangeStart = 2646, XrefRangeEnd = 2700, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Customer.__c__DisplayClass182_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr))
				{
					System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
					*ptr = ref <>1__state;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.__c__DisplayClass182_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				}

				// Token: 0x0600E8A9 RID: 59561 RVA: 0x0036BE64 File Offset: 0x0036A064
				[CallerCount(14558)]
				[CachedScanResults(RefRangeStart = 2769, RefRangeEnd = 17327, XrefRangeStart = 2769, XrefRangeEnd = 17327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.__c__DisplayClass182_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				}

				// Token: 0x0600E8AA RID: 59562 RVA: 0x0036BE98 File Offset: 0x0036A098
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 190944, XrefRangeEnd = 190958, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Customer.__c__DisplayClass182_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
					return *IL2CPP.il2cpp_object_unbox(obj);
				}

				// Token: 0x170047E0 RID: 18400
				// (get) Token: 0x0600E8AB RID: 59563 RVA: 0x0036BED4 File Offset: 0x0036A0D4
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(24)]
					[CachedScanResults(RefRangeStart = 2740, RefRangeEnd = 2764, XrefRangeStart = 2740, XrefRangeEnd = 2764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						System.IntPtr* param = null;
						System.IntPtr returnedException;
						System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.__c__DisplayClass182_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
						Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
						System.IntPtr intPtr2 = intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
				}

				// Token: 0x0600E8AC RID: 59564 RVA: 0x0036BF14 File Offset: 0x0036A114
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 190958, XrefRangeEnd = 190963, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.__c__DisplayClass182_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				}

				// Token: 0x170047E1 RID: 18401
				// (get) Token: 0x0600E8AD RID: 59565 RVA: 0x0036BF48 File Offset: 0x0036A148
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(24)]
					[CachedScanResults(RefRangeStart = 2740, RefRangeEnd = 2764, XrefRangeStart = 2740, XrefRangeEnd = 2764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						System.IntPtr* param = null;
						System.IntPtr returnedException;
						System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.__c__DisplayClass182_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
						Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
						System.IntPtr intPtr2 = intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
				}

				// Token: 0x0600E8AE RID: 59566 RVA: 0x000711BF File Offset: 0x0006F3BF
				public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique(System.IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x170047DD RID: 18397
				// (get) Token: 0x0600E8AF RID: 59567 RVA: 0x0036BF88 File Offset: 0x0036A188
				// (set) Token: 0x0600E8B0 RID: 59568 RVA: 0x000711C8 File Offset: 0x0006F3C8
				public unsafe int __1__state
				{
					get
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.__c__DisplayClass182_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.__c__DisplayClass182_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x170047DE RID: 18398
				// (get) Token: 0x0600E8B1 RID: 59569 RVA: 0x0036BFB0 File Offset: 0x0036A1B0
				// (set) Token: 0x0600E8B2 RID: 59570 RVA: 0x000711E3 File Offset: 0x0006F3E3
				public unsafe Il2CppSystem.Object __2__current
				{
					get
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.__c__DisplayClass182_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current);
						System.IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
					set
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.__c__DisplayClass182_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x170047DF RID: 18399
				// (get) Token: 0x0600E8B3 RID: 59571 RVA: 0x0036BFE0 File Offset: 0x0036A1E0
				// (set) Token: 0x0600E8B4 RID: 59572 RVA: 0x00071202 File Offset: 0x0006F402
				public unsafe Customer.__c__DisplayClass182_1 __4__this
				{
					get
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.__c__DisplayClass182_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this);
						System.IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Customer.__c__DisplayClass182_1>(intPtr2) : null;
					}
					set
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.__c__DisplayClass182_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x04009BBF RID: 39871
				private static readonly System.IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x04009BC0 RID: 39872
				private static readonly System.IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x04009BC1 RID: 39873
				private static readonly System.IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x04009BC2 RID: 39874
				private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x04009BC3 RID: 39875
				private static readonly System.IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x04009BC4 RID: 39876
				private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x04009BC5 RID: 39877
				private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x04009BC6 RID: 39878
				private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x04009BC7 RID: 39879
				private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
			}
		}

		// Token: 0x02000A26 RID: 2598
		[ObfuscatedName("ScheduleOne.Economy.Customer+<>c__DisplayClass183_0")]
		public sealed class __c__DisplayClass183_0 : Il2CppSystem.Object
		{
			// Token: 0x0600D220 RID: 53792 RVA: 0x0032C254 File Offset: 0x0032A454
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass183_0()
			{
				Il2CppClassPointerStore<Customer.__c__DisplayClass183_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Customer>.NativeClassPtr, "<>c__DisplayClass183_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Customer.__c__DisplayClass183_0>.NativeClassPtr);
				Customer.__c__DisplayClass183_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Customer.__c__DisplayClass183_0>.NativeClassPtr, "<>4__this");
				Customer.__c__DisplayClass183_0.NativeFieldInfoPtr_alreadyRecommended = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Customer.__c__DisplayClass183_0>.NativeClassPtr, "alreadyRecommended");
				Customer.__c__DisplayClass183_0.NativeFieldInfoPtr_supplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Customer.__c__DisplayClass183_0>.NativeClassPtr, "supplier");
				Customer.__c__DisplayClass183_0.NativeFieldInfoPtr_container = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Customer.__c__DisplayClass183_0>.NativeClassPtr, "container");
				Customer.__c__DisplayClass183_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer.__c__DisplayClass183_0>.NativeClassPtr, 100675057);
				Customer.__c__DisplayClass183_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer.__c__DisplayClass183_0>.NativeClassPtr, 100675058);
			}

			// Token: 0x0600D221 RID: 53793 RVA: 0x0032C2F8 File Offset: 0x0032A4F8
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass183_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Customer.__c__DisplayClass183_0>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.__c__DisplayClass183_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600D222 RID: 53794 RVA: 0x0032C334 File Offset: 0x0032A534
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 190985, RefRangeEnd = 190986, XrefRangeStart = 190980, XrefRangeEnd = 190985, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator Method_Internal_IEnumerator_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.__c__DisplayClass183_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr2) : null;
			}

			// Token: 0x0600D223 RID: 53795 RVA: 0x00065E21 File Offset: 0x00064021
			public __c__DisplayClass183_0(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700411F RID: 16671
			// (get) Token: 0x0600D224 RID: 53796 RVA: 0x0032C374 File Offset: 0x0032A574
			// (set) Token: 0x0600D225 RID: 53797 RVA: 0x00065E2A File Offset: 0x0006402A
			public unsafe Customer __4__this
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.__c__DisplayClass183_0.NativeFieldInfoPtr___4__this);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Customer>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.__c__DisplayClass183_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004120 RID: 16672
			// (get) Token: 0x0600D226 RID: 53798 RVA: 0x0032C3A4 File Offset: 0x0032A5A4
			// (set) Token: 0x0600D227 RID: 53799 RVA: 0x00065E49 File Offset: 0x00064049
			public unsafe bool alreadyRecommended
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.__c__DisplayClass183_0.NativeFieldInfoPtr_alreadyRecommended);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.__c__DisplayClass183_0.NativeFieldInfoPtr_alreadyRecommended)) = value;
				}
			}

			// Token: 0x17004121 RID: 16673
			// (get) Token: 0x0600D228 RID: 53800 RVA: 0x0032C3CC File Offset: 0x0032A5CC
			// (set) Token: 0x0600D229 RID: 53801 RVA: 0x00065E64 File Offset: 0x00064064
			public unsafe Supplier supplier
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.__c__DisplayClass183_0.NativeFieldInfoPtr_supplier);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Supplier>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.__c__DisplayClass183_0.NativeFieldInfoPtr_supplier), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004122 RID: 16674
			// (get) Token: 0x0600D22A RID: 53802 RVA: 0x0032C3FC File Offset: 0x0032A5FC
			// (set) Token: 0x0600D22B RID: 53803 RVA: 0x00065E83 File Offset: 0x00064083
			public unsafe DialogueContainer container
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.__c__DisplayClass183_0.NativeFieldInfoPtr_container);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DialogueContainer>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.__c__DisplayClass183_0.NativeFieldInfoPtr_container), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008E10 RID: 36368
			private static readonly System.IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04008E11 RID: 36369
			private static readonly System.IntPtr NativeFieldInfoPtr_alreadyRecommended;

			// Token: 0x04008E12 RID: 36370
			private static readonly System.IntPtr NativeFieldInfoPtr_supplier;

			// Token: 0x04008E13 RID: 36371
			private static readonly System.IntPtr NativeFieldInfoPtr_container;

			// Token: 0x04008E14 RID: 36372
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008E15 RID: 36373
			private static readonly System.IntPtr NativeMethodInfoPtr_Method_Internal_IEnumerator_0;

			// Token: 0x02000CAB RID: 3243
			[ObfuscatedName("ScheduleOne.Economy.Customer+<>c__DisplayClass183_0+<<RecommendSupplier>g__Wait|0>d")]
			public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique : Il2CppSystem.Object
			{
				// Token: 0x0600E8B5 RID: 59573 RVA: 0x0036C010 File Offset: 0x0036A210
				// Note: this type is marked as 'beforefieldinit'.
				static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique()
				{
					Il2CppClassPointerStore<Customer.__c__DisplayClass183_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Customer.__c__DisplayClass183_0>.NativeClassPtr, "<<RecommendSupplier>g__Wait|0>d");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Customer.__c__DisplayClass183_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr);
					Customer.__c__DisplayClass183_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Customer.__c__DisplayClass183_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>1__state");
					Customer.__c__DisplayClass183_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Customer.__c__DisplayClass183_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>2__current");
					Customer.__c__DisplayClass183_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Customer.__c__DisplayClass183_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>4__this");
					Customer.__c__DisplayClass183_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer.__c__DisplayClass183_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100675059);
					Customer.__c__DisplayClass183_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer.__c__DisplayClass183_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100675060);
					Customer.__c__DisplayClass183_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer.__c__DisplayClass183_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100675061);
					Customer.__c__DisplayClass183_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer.__c__DisplayClass183_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100675062);
					Customer.__c__DisplayClass183_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer.__c__DisplayClass183_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100675063);
					Customer.__c__DisplayClass183_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer.__c__DisplayClass183_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100675064);
				}

				// Token: 0x0600E8B6 RID: 59574 RVA: 0x0036C0F0 File Offset: 0x0036A2F0
				[CallerCount(54)]
				[CachedScanResults(RefRangeStart = 2646, RefRangeEnd = 2700, XrefRangeStart = 2646, XrefRangeEnd = 2700, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Customer.__c__DisplayClass183_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr))
				{
					System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
					*ptr = ref <>1__state;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.__c__DisplayClass183_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				}

				// Token: 0x0600E8B7 RID: 59575 RVA: 0x0036C138 File Offset: 0x0036A338
				[CallerCount(14558)]
				[CachedScanResults(RefRangeStart = 2769, RefRangeEnd = 17327, XrefRangeStart = 2769, XrefRangeEnd = 17327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.__c__DisplayClass183_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				}

				// Token: 0x0600E8B8 RID: 59576 RVA: 0x0036C16C File Offset: 0x0036A36C
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 190969, XrefRangeEnd = 190975, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Customer.__c__DisplayClass183_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
					return *IL2CPP.il2cpp_object_unbox(obj);
				}

				// Token: 0x170047E5 RID: 18405
				// (get) Token: 0x0600E8B9 RID: 59577 RVA: 0x0036C1A8 File Offset: 0x0036A3A8
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(24)]
					[CachedScanResults(RefRangeStart = 2740, RefRangeEnd = 2764, XrefRangeStart = 2740, XrefRangeEnd = 2764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						System.IntPtr* param = null;
						System.IntPtr returnedException;
						System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.__c__DisplayClass183_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
						Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
						System.IntPtr intPtr2 = intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
				}

				// Token: 0x0600E8BA RID: 59578 RVA: 0x0036C1E8 File Offset: 0x0036A3E8
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 190975, XrefRangeEnd = 190980, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.__c__DisplayClass183_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				}

				// Token: 0x170047E6 RID: 18406
				// (get) Token: 0x0600E8BB RID: 59579 RVA: 0x0036C21C File Offset: 0x0036A41C
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(24)]
					[CachedScanResults(RefRangeStart = 2740, RefRangeEnd = 2764, XrefRangeStart = 2740, XrefRangeEnd = 2764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						System.IntPtr* param = null;
						System.IntPtr returnedException;
						System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.__c__DisplayClass183_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
						Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
						System.IntPtr intPtr2 = intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
				}

				// Token: 0x0600E8BC RID: 59580 RVA: 0x00071221 File Offset: 0x0006F421
				public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique(System.IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x170047E2 RID: 18402
				// (get) Token: 0x0600E8BD RID: 59581 RVA: 0x0036C25C File Offset: 0x0036A45C
				// (set) Token: 0x0600E8BE RID: 59582 RVA: 0x0007122A File Offset: 0x0006F42A
				public unsafe int __1__state
				{
					get
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.__c__DisplayClass183_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.__c__DisplayClass183_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x170047E3 RID: 18403
				// (get) Token: 0x0600E8BF RID: 59583 RVA: 0x0036C284 File Offset: 0x0036A484
				// (set) Token: 0x0600E8C0 RID: 59584 RVA: 0x00071245 File Offset: 0x0006F445
				public unsafe Il2CppSystem.Object __2__current
				{
					get
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.__c__DisplayClass183_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current);
						System.IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
					set
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.__c__DisplayClass183_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x170047E4 RID: 18404
				// (get) Token: 0x0600E8C1 RID: 59585 RVA: 0x0036C2B4 File Offset: 0x0036A4B4
				// (set) Token: 0x0600E8C2 RID: 59586 RVA: 0x00071264 File Offset: 0x0006F464
				public unsafe Customer.__c__DisplayClass183_0 __4__this
				{
					get
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.__c__DisplayClass183_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this);
						System.IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Customer.__c__DisplayClass183_0>(intPtr2) : null;
					}
					set
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.__c__DisplayClass183_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x04009BC8 RID: 39880
				private static readonly System.IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x04009BC9 RID: 39881
				private static readonly System.IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x04009BCA RID: 39882
				private static readonly System.IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x04009BCB RID: 39883
				private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x04009BCC RID: 39884
				private static readonly System.IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x04009BCD RID: 39885
				private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x04009BCE RID: 39886
				private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x04009BCF RID: 39887
				private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x04009BD0 RID: 39888
				private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
			}
		}

		// Token: 0x02000A27 RID: 2599
		[ObfuscatedName("ScheduleOne.Economy.Customer+<>c__DisplayClass184_0")]
		public sealed class __c__DisplayClass184_0 : Il2CppSystem.Object
		{
			// Token: 0x0600D22C RID: 53804 RVA: 0x0032C42C File Offset: 0x0032A62C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass184_0()
			{
				Il2CppClassPointerStore<Customer.__c__DisplayClass184_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Customer>.NativeClassPtr, "<>c__DisplayClass184_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Customer.__c__DisplayClass184_0>.NativeClassPtr);
				Customer.__c__DisplayClass184_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Customer.__c__DisplayClass184_0>.NativeClassPtr, "<>4__this");
				Customer.__c__DisplayClass184_0.NativeFieldInfoPtr_container = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Customer.__c__DisplayClass184_0>.NativeClassPtr, "container");
				Customer.__c__DisplayClass184_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer.__c__DisplayClass184_0>.NativeClassPtr, 100675065);
				Customer.__c__DisplayClass184_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer.__c__DisplayClass184_0>.NativeClassPtr, 100675066);
			}

			// Token: 0x0600D22D RID: 53805 RVA: 0x0032C4A8 File Offset: 0x0032A6A8
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass184_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Customer.__c__DisplayClass184_0>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.__c__DisplayClass184_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600D22E RID: 53806 RVA: 0x0032C4E4 File Offset: 0x0032A6E4
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 191001, RefRangeEnd = 191002, XrefRangeStart = 190996, XrefRangeEnd = 191001, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator Method_Internal_IEnumerator_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.__c__DisplayClass184_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr2) : null;
			}

			// Token: 0x0600D22F RID: 53807 RVA: 0x00065EA2 File Offset: 0x000640A2
			public __c__DisplayClass184_0(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004123 RID: 16675
			// (get) Token: 0x0600D230 RID: 53808 RVA: 0x0032C524 File Offset: 0x0032A724
			// (set) Token: 0x0600D231 RID: 53809 RVA: 0x00065EAB File Offset: 0x000640AB
			public unsafe Customer __4__this
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.__c__DisplayClass184_0.NativeFieldInfoPtr___4__this);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Customer>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.__c__DisplayClass184_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004124 RID: 16676
			// (get) Token: 0x0600D232 RID: 53810 RVA: 0x0032C554 File Offset: 0x0032A754
			// (set) Token: 0x0600D233 RID: 53811 RVA: 0x00065ECA File Offset: 0x000640CA
			public unsafe DialogueContainer container
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.__c__DisplayClass184_0.NativeFieldInfoPtr_container);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DialogueContainer>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.__c__DisplayClass184_0.NativeFieldInfoPtr_container), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008E16 RID: 36374
			private static readonly System.IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04008E17 RID: 36375
			private static readonly System.IntPtr NativeFieldInfoPtr_container;

			// Token: 0x04008E18 RID: 36376
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008E19 RID: 36377
			private static readonly System.IntPtr NativeMethodInfoPtr_Method_Internal_IEnumerator_0;

			// Token: 0x02000CAC RID: 3244
			[ObfuscatedName("ScheduleOne.Economy.Customer+<>c__DisplayClass184_0+<<RecommendCustomer>g__Wait|0>d")]
			public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique : Il2CppSystem.Object
			{
				// Token: 0x0600E8C3 RID: 59587 RVA: 0x0036C2E4 File Offset: 0x0036A4E4
				// Note: this type is marked as 'beforefieldinit'.
				static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique()
				{
					Il2CppClassPointerStore<Customer.__c__DisplayClass184_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Customer.__c__DisplayClass184_0>.NativeClassPtr, "<<RecommendCustomer>g__Wait|0>d");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Customer.__c__DisplayClass184_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr);
					Customer.__c__DisplayClass184_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Customer.__c__DisplayClass184_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>1__state");
					Customer.__c__DisplayClass184_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Customer.__c__DisplayClass184_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>2__current");
					Customer.__c__DisplayClass184_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Customer.__c__DisplayClass184_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>4__this");
					Customer.__c__DisplayClass184_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer.__c__DisplayClass184_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100675067);
					Customer.__c__DisplayClass184_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer.__c__DisplayClass184_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100675068);
					Customer.__c__DisplayClass184_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer.__c__DisplayClass184_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100675069);
					Customer.__c__DisplayClass184_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer.__c__DisplayClass184_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100675070);
					Customer.__c__DisplayClass184_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer.__c__DisplayClass184_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100675071);
					Customer.__c__DisplayClass184_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer.__c__DisplayClass184_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100675072);
				}

				// Token: 0x0600E8C4 RID: 59588 RVA: 0x0036C3C4 File Offset: 0x0036A5C4
				[CallerCount(54)]
				[CachedScanResults(RefRangeStart = 2646, RefRangeEnd = 2700, XrefRangeStart = 2646, XrefRangeEnd = 2700, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Customer.__c__DisplayClass184_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr))
				{
					System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
					*ptr = ref <>1__state;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.__c__DisplayClass184_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				}

				// Token: 0x0600E8C5 RID: 59589 RVA: 0x0036C40C File Offset: 0x0036A60C
				[CallerCount(14558)]
				[CachedScanResults(RefRangeStart = 2769, RefRangeEnd = 17327, XrefRangeStart = 2769, XrefRangeEnd = 17327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.__c__DisplayClass184_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				}

				// Token: 0x0600E8C6 RID: 59590 RVA: 0x0036C440 File Offset: 0x0036A640
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 190986, XrefRangeEnd = 190991, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Customer.__c__DisplayClass184_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
					return *IL2CPP.il2cpp_object_unbox(obj);
				}

				// Token: 0x170047EA RID: 18410
				// (get) Token: 0x0600E8C7 RID: 59591 RVA: 0x0036C47C File Offset: 0x0036A67C
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(24)]
					[CachedScanResults(RefRangeStart = 2740, RefRangeEnd = 2764, XrefRangeStart = 2740, XrefRangeEnd = 2764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						System.IntPtr* param = null;
						System.IntPtr returnedException;
						System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.__c__DisplayClass184_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
						Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
						System.IntPtr intPtr2 = intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
				}

				// Token: 0x0600E8C8 RID: 59592 RVA: 0x0036C4BC File Offset: 0x0036A6BC
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 190991, XrefRangeEnd = 190996, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.__c__DisplayClass184_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				}

				// Token: 0x170047EB RID: 18411
				// (get) Token: 0x0600E8C9 RID: 59593 RVA: 0x0036C4F0 File Offset: 0x0036A6F0
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(24)]
					[CachedScanResults(RefRangeStart = 2740, RefRangeEnd = 2764, XrefRangeStart = 2740, XrefRangeEnd = 2764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						System.IntPtr* param = null;
						System.IntPtr returnedException;
						System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.__c__DisplayClass184_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
						Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
						System.IntPtr intPtr2 = intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
				}

				// Token: 0x0600E8CA RID: 59594 RVA: 0x00071283 File Offset: 0x0006F483
				public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique(System.IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x170047E7 RID: 18407
				// (get) Token: 0x0600E8CB RID: 59595 RVA: 0x0036C530 File Offset: 0x0036A730
				// (set) Token: 0x0600E8CC RID: 59596 RVA: 0x0007128C File Offset: 0x0006F48C
				public unsafe int __1__state
				{
					get
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.__c__DisplayClass184_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.__c__DisplayClass184_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x170047E8 RID: 18408
				// (get) Token: 0x0600E8CD RID: 59597 RVA: 0x0036C558 File Offset: 0x0036A758
				// (set) Token: 0x0600E8CE RID: 59598 RVA: 0x000712A7 File Offset: 0x0006F4A7
				public unsafe Il2CppSystem.Object __2__current
				{
					get
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.__c__DisplayClass184_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current);
						System.IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
					set
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.__c__DisplayClass184_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x170047E9 RID: 18409
				// (get) Token: 0x0600E8CF RID: 59599 RVA: 0x0036C588 File Offset: 0x0036A788
				// (set) Token: 0x0600E8D0 RID: 59600 RVA: 0x000712C6 File Offset: 0x0006F4C6
				public unsafe Customer.__c__DisplayClass184_0 __4__this
				{
					get
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.__c__DisplayClass184_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this);
						System.IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Customer.__c__DisplayClass184_0>(intPtr2) : null;
					}
					set
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.__c__DisplayClass184_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x04009BD1 RID: 39889
				private static readonly System.IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x04009BD2 RID: 39890
				private static readonly System.IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x04009BD3 RID: 39891
				private static readonly System.IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x04009BD4 RID: 39892
				private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x04009BD5 RID: 39893
				private static readonly System.IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x04009BD6 RID: 39894
				private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x04009BD7 RID: 39895
				private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x04009BD8 RID: 39896
				private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x04009BD9 RID: 39897
				private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
			}
		}

		// Token: 0x02000A28 RID: 2600
		[ObfuscatedName("ScheduleOne.Economy.Customer+<>c__DisplayClass186_0")]
		public sealed class __c__DisplayClass186_0 : Il2CppSystem.Object
		{
			// Token: 0x0600D234 RID: 53812 RVA: 0x0032C584 File Offset: 0x0032A784
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass186_0()
			{
				Il2CppClassPointerStore<Customer.__c__DisplayClass186_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Customer>.NativeClassPtr, "<>c__DisplayClass186_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Customer.__c__DisplayClass186_0>.NativeClassPtr);
				Customer.__c__DisplayClass186_0.NativeFieldInfoPtr_entry = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Customer.__c__DisplayClass186_0>.NativeClassPtr, "entry");
				Customer.__c__DisplayClass186_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer.__c__DisplayClass186_0>.NativeClassPtr, 100675073);
				Customer.__c__DisplayClass186_0.NativeMethodInfoPtr__EvaluateDelivery_b__0_Internal_Boolean_ItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer.__c__DisplayClass186_0>.NativeClassPtr, 100675074);
			}

			// Token: 0x0600D235 RID: 53813 RVA: 0x0032C5EC File Offset: 0x0032A7EC
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass186_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Customer.__c__DisplayClass186_0>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.__c__DisplayClass186_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600D236 RID: 53814 RVA: 0x0032C628 File Offset: 0x0032A828
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _EvaluateDelivery_b__0(ItemInstance x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Customer.__c__DisplayClass186_0.NativeMethodInfoPtr__EvaluateDelivery_b__0_Internal_Boolean_ItemInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x0600D237 RID: 53815 RVA: 0x00065EE9 File Offset: 0x000640E9
			public __c__DisplayClass186_0(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004125 RID: 16677
			// (get) Token: 0x0600D238 RID: 53816 RVA: 0x0032C678 File Offset: 0x0032A878
			// (set) Token: 0x0600D239 RID: 53817 RVA: 0x00065EF2 File Offset: 0x000640F2
			public unsafe ProductList.Entry entry
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.__c__DisplayClass186_0.NativeFieldInfoPtr_entry);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ProductList.Entry>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.__c__DisplayClass186_0.NativeFieldInfoPtr_entry), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008E1A RID: 36378
			private static readonly System.IntPtr NativeFieldInfoPtr_entry;

			// Token: 0x04008E1B RID: 36379
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008E1C RID: 36380
			private static readonly System.IntPtr NativeMethodInfoPtr__EvaluateDelivery_b__0_Internal_Boolean_ItemInstance_0;
		}

		// Token: 0x02000A29 RID: 2601
		[ObfuscatedName("ScheduleOne.Economy.Customer+<>c__DisplayClass188_0")]
		public sealed class __c__DisplayClass188_0 : Il2CppSystem.Object
		{
			// Token: 0x0600D23A RID: 53818 RVA: 0x0032C6A8 File Offset: 0x0032A8A8
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass188_0()
			{
				Il2CppClassPointerStore<Customer.__c__DisplayClass188_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Customer>.NativeClassPtr, "<>c__DisplayClass188_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Customer.__c__DisplayClass188_0>.NativeClassPtr);
				Customer.__c__DisplayClass188_0.NativeFieldInfoPtr_item = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Customer.__c__DisplayClass188_0>.NativeClassPtr, "item");
				Customer.__c__DisplayClass188_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Customer.__c__DisplayClass188_0>.NativeClassPtr, "<>4__this");
				Customer.__c__DisplayClass188_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer.__c__DisplayClass188_0>.NativeClassPtr, 100675075);
				Customer.__c__DisplayClass188_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer.__c__DisplayClass188_0>.NativeClassPtr, 100675076);
			}

			// Token: 0x0600D23B RID: 53819 RVA: 0x0032C724 File Offset: 0x0032A924
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass188_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Customer.__c__DisplayClass188_0>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.__c__DisplayClass188_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600D23C RID: 53820 RVA: 0x0032C760 File Offset: 0x0032A960
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 191020, RefRangeEnd = 191022, XrefRangeStart = 191015, XrefRangeEnd = 191020, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator Method_Internal_IEnumerator_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.__c__DisplayClass188_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr2) : null;
			}

			// Token: 0x0600D23D RID: 53821 RVA: 0x00065F11 File Offset: 0x00064111
			public __c__DisplayClass188_0(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004126 RID: 16678
			// (get) Token: 0x0600D23E RID: 53822 RVA: 0x0032C7A0 File Offset: 0x0032A9A0
			// (set) Token: 0x0600D23F RID: 53823 RVA: 0x00065F1A File Offset: 0x0006411A
			public unsafe ItemInstance item
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.__c__DisplayClass188_0.NativeFieldInfoPtr_item);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemInstance>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.__c__DisplayClass188_0.NativeFieldInfoPtr_item), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004127 RID: 16679
			// (get) Token: 0x0600D240 RID: 53824 RVA: 0x0032C7D0 File Offset: 0x0032A9D0
			// (set) Token: 0x0600D241 RID: 53825 RVA: 0x00065F39 File Offset: 0x00064139
			public unsafe Customer __4__this
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.__c__DisplayClass188_0.NativeFieldInfoPtr___4__this);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Customer>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.__c__DisplayClass188_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008E1D RID: 36381
			private static readonly System.IntPtr NativeFieldInfoPtr_item;

			// Token: 0x04008E1E RID: 36382
			private static readonly System.IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04008E1F RID: 36383
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008E20 RID: 36384
			private static readonly System.IntPtr NativeMethodInfoPtr_Method_Internal_IEnumerator_0;

			// Token: 0x02000CAD RID: 3245
			[ObfuscatedName("ScheduleOne.Economy.Customer+<>c__DisplayClass188_0+<<ConsumeProduct>g__Wait|0>d")]
			public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique : Il2CppSystem.Object
			{
				// Token: 0x0600E8D1 RID: 59601 RVA: 0x0036C5B8 File Offset: 0x0036A7B8
				// Note: this type is marked as 'beforefieldinit'.
				static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique()
				{
					Il2CppClassPointerStore<Customer.__c__DisplayClass188_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Customer.__c__DisplayClass188_0>.NativeClassPtr, "<<ConsumeProduct>g__Wait|0>d");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Customer.__c__DisplayClass188_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr);
					Customer.__c__DisplayClass188_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Customer.__c__DisplayClass188_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>1__state");
					Customer.__c__DisplayClass188_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Customer.__c__DisplayClass188_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>2__current");
					Customer.__c__DisplayClass188_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Customer.__c__DisplayClass188_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>4__this");
					Customer.__c__DisplayClass188_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer.__c__DisplayClass188_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100675077);
					Customer.__c__DisplayClass188_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer.__c__DisplayClass188_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100675078);
					Customer.__c__DisplayClass188_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer.__c__DisplayClass188_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100675079);
					Customer.__c__DisplayClass188_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer.__c__DisplayClass188_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100675080);
					Customer.__c__DisplayClass188_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer.__c__DisplayClass188_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100675081);
					Customer.__c__DisplayClass188_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer.__c__DisplayClass188_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100675082);
				}

				// Token: 0x0600E8D2 RID: 59602 RVA: 0x0036C698 File Offset: 0x0036A898
				[CallerCount(54)]
				[CachedScanResults(RefRangeStart = 2646, RefRangeEnd = 2700, XrefRangeStart = 2646, XrefRangeEnd = 2700, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Customer.__c__DisplayClass188_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr))
				{
					System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
					*ptr = ref <>1__state;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.__c__DisplayClass188_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				}

				// Token: 0x0600E8D3 RID: 59603 RVA: 0x0036C6E0 File Offset: 0x0036A8E0
				[CallerCount(14558)]
				[CachedScanResults(RefRangeStart = 2769, RefRangeEnd = 17327, XrefRangeStart = 2769, XrefRangeEnd = 17327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.__c__DisplayClass188_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				}

				// Token: 0x0600E8D4 RID: 59604 RVA: 0x0036C714 File Offset: 0x0036A914
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 191002, XrefRangeEnd = 191010, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Customer.__c__DisplayClass188_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
					return *IL2CPP.il2cpp_object_unbox(obj);
				}

				// Token: 0x170047EF RID: 18415
				// (get) Token: 0x0600E8D5 RID: 59605 RVA: 0x0036C750 File Offset: 0x0036A950
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(24)]
					[CachedScanResults(RefRangeStart = 2740, RefRangeEnd = 2764, XrefRangeStart = 2740, XrefRangeEnd = 2764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						System.IntPtr* param = null;
						System.IntPtr returnedException;
						System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.__c__DisplayClass188_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
						Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
						System.IntPtr intPtr2 = intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
				}

				// Token: 0x0600E8D6 RID: 59606 RVA: 0x0036C790 File Offset: 0x0036A990
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 191010, XrefRangeEnd = 191015, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.__c__DisplayClass188_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				}

				// Token: 0x170047F0 RID: 18416
				// (get) Token: 0x0600E8D7 RID: 59607 RVA: 0x0036C7C4 File Offset: 0x0036A9C4
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(24)]
					[CachedScanResults(RefRangeStart = 2740, RefRangeEnd = 2764, XrefRangeStart = 2740, XrefRangeEnd = 2764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						System.IntPtr* param = null;
						System.IntPtr returnedException;
						System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.__c__DisplayClass188_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
						Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
						System.IntPtr intPtr2 = intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
				}

				// Token: 0x0600E8D8 RID: 59608 RVA: 0x000712E5 File Offset: 0x0006F4E5
				public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique(System.IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x170047EC RID: 18412
				// (get) Token: 0x0600E8D9 RID: 59609 RVA: 0x0036C804 File Offset: 0x0036AA04
				// (set) Token: 0x0600E8DA RID: 59610 RVA: 0x000712EE File Offset: 0x0006F4EE
				public unsafe int __1__state
				{
					get
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.__c__DisplayClass188_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.__c__DisplayClass188_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x170047ED RID: 18413
				// (get) Token: 0x0600E8DB RID: 59611 RVA: 0x0036C82C File Offset: 0x0036AA2C
				// (set) Token: 0x0600E8DC RID: 59612 RVA: 0x00071309 File Offset: 0x0006F509
				public unsafe Il2CppSystem.Object __2__current
				{
					get
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.__c__DisplayClass188_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current);
						System.IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
					set
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.__c__DisplayClass188_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x170047EE RID: 18414
				// (get) Token: 0x0600E8DD RID: 59613 RVA: 0x0036C85C File Offset: 0x0036AA5C
				// (set) Token: 0x0600E8DE RID: 59614 RVA: 0x00071328 File Offset: 0x0006F528
				public unsafe Customer.__c__DisplayClass188_0 __4__this
				{
					get
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.__c__DisplayClass188_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this);
						System.IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Customer.__c__DisplayClass188_0>(intPtr2) : null;
					}
					set
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.__c__DisplayClass188_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x04009BDA RID: 39898
				private static readonly System.IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x04009BDB RID: 39899
				private static readonly System.IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x04009BDC RID: 39900
				private static readonly System.IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x04009BDD RID: 39901
				private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x04009BDE RID: 39902
				private static readonly System.IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x04009BDF RID: 39903
				private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x04009BE0 RID: 39904
				private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x04009BE1 RID: 39905
				private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x04009BE2 RID: 39906
				private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
			}
		}

		// Token: 0x02000A2A RID: 2602
		[ObfuscatedName("ScheduleOne.Economy.Customer+<>c__DisplayClass224_0")]
		public sealed class __c__DisplayClass224_0 : Il2CppSystem.Object
		{
			// Token: 0x0600D242 RID: 53826 RVA: 0x0032C800 File Offset: 0x0032AA00
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass224_0()
			{
				Il2CppClassPointerStore<Customer.__c__DisplayClass224_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Customer>.NativeClassPtr, "<>c__DisplayClass224_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Customer.__c__DisplayClass224_0>.NativeClassPtr);
				Customer.__c__DisplayClass224_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Customer.__c__DisplayClass224_0>.NativeClassPtr, "<>4__this");
				Customer.__c__DisplayClass224_0.NativeFieldInfoPtr_i = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Customer.__c__DisplayClass224_0>.NativeClassPtr, "i");
				Customer.__c__DisplayClass224_0.NativeFieldInfoPtr___9__0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Customer.__c__DisplayClass224_0>.NativeClassPtr, "<>9__0");
				Customer.__c__DisplayClass224_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer.__c__DisplayClass224_0>.NativeClassPtr, 100675083);
				Customer.__c__DisplayClass224_0.NativeMethodInfoPtr__GetProductEnjoyment_b__0_Internal_Boolean_Property_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer.__c__DisplayClass224_0>.NativeClassPtr, 100675084);
			}

			// Token: 0x0600D243 RID: 53827 RVA: 0x0032C890 File Offset: 0x0032AA90
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass224_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Customer.__c__DisplayClass224_0>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.__c__DisplayClass224_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600D244 RID: 53828 RVA: 0x0032C8CC File Offset: 0x0032AACC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 191022, XrefRangeEnd = 191030, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GetProductEnjoyment_b__0(Property x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Customer.__c__DisplayClass224_0.NativeMethodInfoPtr__GetProductEnjoyment_b__0_Internal_Boolean_Property_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x0600D245 RID: 53829 RVA: 0x00065F58 File Offset: 0x00064158
			public __c__DisplayClass224_0(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004128 RID: 16680
			// (get) Token: 0x0600D246 RID: 53830 RVA: 0x0032C91C File Offset: 0x0032AB1C
			// (set) Token: 0x0600D247 RID: 53831 RVA: 0x00065F61 File Offset: 0x00064161
			public unsafe Customer __4__this
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.__c__DisplayClass224_0.NativeFieldInfoPtr___4__this);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Customer>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.__c__DisplayClass224_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004129 RID: 16681
			// (get) Token: 0x0600D248 RID: 53832 RVA: 0x0032C94C File Offset: 0x0032AB4C
			// (set) Token: 0x0600D249 RID: 53833 RVA: 0x00065F80 File Offset: 0x00064180
			public unsafe int i
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.__c__DisplayClass224_0.NativeFieldInfoPtr_i);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.__c__DisplayClass224_0.NativeFieldInfoPtr_i)) = value;
				}
			}

			// Token: 0x1700412A RID: 16682
			// (get) Token: 0x0600D24A RID: 53834 RVA: 0x0032C974 File Offset: 0x0032AB74
			// (set) Token: 0x0600D24B RID: 53835 RVA: 0x00065F9B File Offset: 0x0006419B
			public unsafe Il2CppSystem.Predicate<Property> __9__0
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.__c__DisplayClass224_0.NativeFieldInfoPtr___9__0);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Predicate<Property>>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.__c__DisplayClass224_0.NativeFieldInfoPtr___9__0), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008E21 RID: 36385
			private static readonly System.IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04008E22 RID: 36386
			private static readonly System.IntPtr NativeFieldInfoPtr_i;

			// Token: 0x04008E23 RID: 36387
			private static readonly System.IntPtr NativeFieldInfoPtr___9__0;

			// Token: 0x04008E24 RID: 36388
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008E25 RID: 36389
			private static readonly System.IntPtr NativeMethodInfoPtr__GetProductEnjoyment_b__0_Internal_Boolean_Property_0;
		}

		// Token: 0x02000A2B RID: 2603
		[ObfuscatedName("ScheduleOne.Economy.Customer+<>c__DisplayClass225_0")]
		public sealed class __c__DisplayClass225_0 : Il2CppSystem.Object
		{
			// Token: 0x0600D24C RID: 53836 RVA: 0x0032C9A4 File Offset: 0x0032ABA4
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass225_0()
			{
				Il2CppClassPointerStore<Customer.__c__DisplayClass225_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Customer>.NativeClassPtr, "<>c__DisplayClass225_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Customer.__c__DisplayClass225_0>.NativeClassPtr);
				Customer.__c__DisplayClass225_0.NativeFieldInfoPtr_x = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Customer.__c__DisplayClass225_0>.NativeClassPtr, "x");
				Customer.__c__DisplayClass225_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer.__c__DisplayClass225_0>.NativeClassPtr, 100675085);
				Customer.__c__DisplayClass225_0.NativeMethodInfoPtr__GetOrderedDrugTypes_b__1_Internal_Boolean_ProductTypeAffinity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer.__c__DisplayClass225_0>.NativeClassPtr, 100675086);
			}

			// Token: 0x0600D24D RID: 53837 RVA: 0x0032CA0C File Offset: 0x0032AC0C
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass225_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Customer.__c__DisplayClass225_0>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.__c__DisplayClass225_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600D24E RID: 53838 RVA: 0x0032CA48 File Offset: 0x0032AC48
			[CallerCount(0)]
			public unsafe bool _GetOrderedDrugTypes_b__1(ProductTypeAffinity y)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(y);
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Customer.__c__DisplayClass225_0.NativeMethodInfoPtr__GetOrderedDrugTypes_b__1_Internal_Boolean_ProductTypeAffinity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x0600D24F RID: 53839 RVA: 0x00065FBA File Offset: 0x000641BA
			public __c__DisplayClass225_0(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700412B RID: 16683
			// (get) Token: 0x0600D250 RID: 53840 RVA: 0x0032CA98 File Offset: 0x0032AC98
			// (set) Token: 0x0600D251 RID: 53841 RVA: 0x00065FC3 File Offset: 0x000641C3
			public unsafe EDrugType x
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.__c__DisplayClass225_0.NativeFieldInfoPtr_x);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.__c__DisplayClass225_0.NativeFieldInfoPtr_x)) = value;
				}
			}

			// Token: 0x04008E26 RID: 36390
			private static readonly System.IntPtr NativeFieldInfoPtr_x;

			// Token: 0x04008E27 RID: 36391
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008E28 RID: 36392
			private static readonly System.IntPtr NativeMethodInfoPtr__GetOrderedDrugTypes_b__1_Internal_Boolean_ProductTypeAffinity_0;
		}

		// Token: 0x02000A2C RID: 2604
		[ObfuscatedName("ScheduleOne.Economy.Customer+<>c__DisplayClass226_0")]
		public sealed class __c__DisplayClass226_0 : Il2CppSystem.Object
		{
			// Token: 0x0600D252 RID: 53842 RVA: 0x0032CAC0 File Offset: 0x0032ACC0
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass226_0()
			{
				Il2CppClassPointerStore<Customer.__c__DisplayClass226_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Customer>.NativeClassPtr, "<>c__DisplayClass226_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Customer.__c__DisplayClass226_0>.NativeClassPtr);
				Customer.__c__DisplayClass226_0.NativeFieldInfoPtr_drugType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Customer.__c__DisplayClass226_0>.NativeClassPtr, "drugType");
				Customer.__c__DisplayClass226_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer.__c__DisplayClass226_0>.NativeClassPtr, 100675087);
				Customer.__c__DisplayClass226_0.NativeMethodInfoPtr__AdjustAffinity_b__0_Internal_Boolean_ProductTypeAffinity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer.__c__DisplayClass226_0>.NativeClassPtr, 100675088);
			}

			// Token: 0x0600D253 RID: 53843 RVA: 0x0032CB28 File Offset: 0x0032AD28
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass226_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Customer.__c__DisplayClass226_0>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.__c__DisplayClass226_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600D254 RID: 53844 RVA: 0x0032CB64 File Offset: 0x0032AD64
			[CallerCount(0)]
			public unsafe bool _AdjustAffinity_b__0(ProductTypeAffinity x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Customer.__c__DisplayClass226_0.NativeMethodInfoPtr__AdjustAffinity_b__0_Internal_Boolean_ProductTypeAffinity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x0600D255 RID: 53845 RVA: 0x00065FDE File Offset: 0x000641DE
			public __c__DisplayClass226_0(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700412C RID: 16684
			// (get) Token: 0x0600D256 RID: 53846 RVA: 0x0032CBB4 File Offset: 0x0032ADB4
			// (set) Token: 0x0600D257 RID: 53847 RVA: 0x00065FE7 File Offset: 0x000641E7
			public unsafe EDrugType drugType
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.__c__DisplayClass226_0.NativeFieldInfoPtr_drugType);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.__c__DisplayClass226_0.NativeFieldInfoPtr_drugType)) = value;
				}
			}

			// Token: 0x04008E29 RID: 36393
			private static readonly System.IntPtr NativeFieldInfoPtr_drugType;

			// Token: 0x04008E2A RID: 36394
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008E2B RID: 36395
			private static readonly System.IntPtr NativeMethodInfoPtr__AdjustAffinity_b__0_Internal_Boolean_ProductTypeAffinity_0;
		}
	}
}
