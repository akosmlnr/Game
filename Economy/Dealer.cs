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
using Il2CppScheduleOne.ItemFramework;
using Il2CppScheduleOne.Map;
using Il2CppScheduleOne.NPCs;
using Il2CppScheduleOne.NPCs.Relation;
using Il2CppScheduleOne.NPCs.Schedules;
using Il2CppScheduleOne.Persistence.Datas;
using Il2CppScheduleOne.Product;
using Il2CppScheduleOne.Quests;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace Il2CppScheduleOne.Economy
{
	// Token: 0x02000433 RID: 1075
	public class Dealer : NPC
	{
		// Token: 0x06005C47 RID: 23623 RVA: 0x001AE340 File Offset: 0x001AC540
		// Note: this type is marked as 'beforefieldinit'.
		static Dealer()
		{
			Il2CppClassPointerStore<Dealer>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Economy", "Dealer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Dealer>.NativeClassPtr);
			Dealer.NativeFieldInfoPtr_MAX_CUSTOMERS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dealer>.NativeClassPtr, "MAX_CUSTOMERS");
			Dealer.NativeFieldInfoPtr_DEAL_ARRIVAL_DELAY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dealer>.NativeClassPtr, "DEAL_ARRIVAL_DELAY");
			Dealer.NativeFieldInfoPtr_MIN_TRAVEL_TIME = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dealer>.NativeClassPtr, "MIN_TRAVEL_TIME");
			Dealer.NativeFieldInfoPtr_MAX_TRAVEL_TIME = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dealer>.NativeClassPtr, "MAX_TRAVEL_TIME");
			Dealer.NativeFieldInfoPtr_OVERFLOW_SLOT_COUNT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dealer>.NativeClassPtr, "OVERFLOW_SLOT_COUNT");
			Dealer.NativeFieldInfoPtr_CASH_REMINDER_THRESHOLD = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dealer>.NativeClassPtr, "CASH_REMINDER_THRESHOLD");
			Dealer.NativeFieldInfoPtr_RELATIONSHIP_CHANGE_PER_DEAL = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dealer>.NativeClassPtr, "RELATIONSHIP_CHANGE_PER_DEAL");
			Dealer.NativeFieldInfoPtr_onDealerRecruited = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dealer>.NativeClassPtr, "onDealerRecruited");
			Dealer.NativeFieldInfoPtr_DealerLabelColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dealer>.NativeClassPtr, "DealerLabelColor");
			Dealer.NativeFieldInfoPtr_AllDealers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dealer>.NativeClassPtr, "AllDealers");
			Dealer.NativeFieldInfoPtr__IsRecruited_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dealer>.NativeClassPtr, "<IsRecruited>k__BackingField");
			Dealer.NativeFieldInfoPtr__ItemSlots_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dealer>.NativeClassPtr, "<ItemSlots>k__BackingField");
			Dealer.NativeFieldInfoPtr_InitialCustomers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dealer>.NativeClassPtr, "InitialCustomers");
			Dealer.NativeFieldInfoPtr_InitialItems = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dealer>.NativeClassPtr, "InitialItems");
			Dealer.NativeFieldInfoPtr_Home = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dealer>.NativeClassPtr, "Home");
			Dealer.NativeFieldInfoPtr_DealSignal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dealer>.NativeClassPtr, "DealSignal");
			Dealer.NativeFieldInfoPtr_HomeEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dealer>.NativeClassPtr, "HomeEvent");
			Dealer.NativeFieldInfoPtr_DialogueController = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dealer>.NativeClassPtr, "DialogueController");
			Dealer.NativeFieldInfoPtr_RecruitDialogue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dealer>.NativeClassPtr, "RecruitDialogue");
			Dealer.NativeFieldInfoPtr_CollectCashDialogue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dealer>.NativeClassPtr, "CollectCashDialogue");
			Dealer.NativeFieldInfoPtr_AssignCustomersDialogue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dealer>.NativeClassPtr, "AssignCustomersDialogue");
			Dealer.NativeFieldInfoPtr_HomeName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dealer>.NativeClassPtr, "HomeName");
			Dealer.NativeFieldInfoPtr_SigningFee = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dealer>.NativeClassPtr, "SigningFee");
			Dealer.NativeFieldInfoPtr_Cut = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dealer>.NativeClassPtr, "Cut");
			Dealer.NativeFieldInfoPtr_SellInsufficientQualityItems = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dealer>.NativeClassPtr, "SellInsufficientQualityItems");
			Dealer.NativeFieldInfoPtr_SellExcessQualityItems = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dealer>.NativeClassPtr, "SellExcessQualityItems");
			Dealer.NativeFieldInfoPtr_CompletedDealsVariable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dealer>.NativeClassPtr, "CompletedDealsVariable");
			Dealer.NativeFieldInfoPtr__Cash_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dealer>.NativeClassPtr, "<Cash>k__BackingField");
			Dealer.NativeFieldInfoPtr_AssignedCustomers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dealer>.NativeClassPtr, "AssignedCustomers");
			Dealer.NativeFieldInfoPtr_ActiveContracts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dealer>.NativeClassPtr, "ActiveContracts");
			Dealer.NativeFieldInfoPtr__HasBeenRecommended_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dealer>.NativeClassPtr, "<HasBeenRecommended>k__BackingField");
			Dealer.NativeFieldInfoPtr_onRecommended = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dealer>.NativeClassPtr, "onRecommended");
			Dealer.NativeFieldInfoPtr_OverflowSlots = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dealer>.NativeClassPtr, "OverflowSlots");
			Dealer.NativeFieldInfoPtr_currentContract = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dealer>.NativeClassPtr, "currentContract");
			Dealer.NativeFieldInfoPtr_recruitChoice = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dealer>.NativeClassPtr, "recruitChoice");
			Dealer.NativeFieldInfoPtr_collectCashChoice = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dealer>.NativeClassPtr, "collectCashChoice");
			Dealer.NativeFieldInfoPtr_assignCustomersChoice = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dealer>.NativeClassPtr, "assignCustomersChoice");
			Dealer.NativeFieldInfoPtr__potentialDealerPoI_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dealer>.NativeClassPtr, "<potentialDealerPoI>k__BackingField");
			Dealer.NativeFieldInfoPtr__dealerPoI_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dealer>.NativeClassPtr, "<dealerPoI>k__BackingField");
			Dealer.NativeFieldInfoPtr_acceptedContractGUIDs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dealer>.NativeClassPtr, "acceptedContractGUIDs");
			Dealer.NativeFieldInfoPtr_itemCountOnTradeStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dealer>.NativeClassPtr, "itemCountOnTradeStart");
			Dealer.NativeFieldInfoPtr_syncVar____Cash_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dealer>.NativeClassPtr, "syncVar___<Cash>k__BackingField");
			Dealer.NativeFieldInfoPtr_syncVar___acceptedContractGUIDs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dealer>.NativeClassPtr, "syncVar___acceptedContractGUIDs");
			Dealer.NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dealer>.NativeClassPtr, "NetworkInitialize___EarlyScheduleOne.Economy.DealerAssembly-CSharp.dll_Excuted");
			Dealer.NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dealer>.NativeClassPtr, "NetworkInitialize__LateScheduleOne.Economy.DealerAssembly-CSharp.dll_Excuted");
			Dealer.NativeMethodInfoPtr_get_IsRecruited_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100675123);
			Dealer.NativeMethodInfoPtr_set_IsRecruited_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100675124);
			Dealer.NativeMethodInfoPtr_get_ItemSlots_Public_Virtual_Final_New_get_List_1_ItemSlot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100675125);
			Dealer.NativeMethodInfoPtr_set_ItemSlots_Public_Virtual_Final_New_set_Void_List_1_ItemSlot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100675126);
			Dealer.NativeMethodInfoPtr_get_Cash_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100675127);
			Dealer.NativeMethodInfoPtr_set_Cash_Private_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100675128);
			Dealer.NativeMethodInfoPtr_get_HasBeenRecommended_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100675129);
			Dealer.NativeMethodInfoPtr_set_HasBeenRecommended_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100675130);
			Dealer.NativeMethodInfoPtr_get_potentialDealerPoI_Public_get_NPCPoI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100675131);
			Dealer.NativeMethodInfoPtr_set_potentialDealerPoI_Protected_set_Void_NPCPoI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100675132);
			Dealer.NativeMethodInfoPtr_get_dealerPoI_Public_get_NPCPoI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100675133);
			Dealer.NativeMethodInfoPtr_set_dealerPoI_Protected_set_Void_NPCPoI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100675134);
			Dealer.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100675135);
			Dealer.NativeMethodInfoPtr_OnValidate_Protected_Virtual_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100675136);
			Dealer.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100675137);
			Dealer.NativeMethodInfoPtr_Start_Protected_Virtual_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100675138);
			Dealer.NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100675139);
			Dealer.NativeMethodInfoPtr_SetupPoI_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100675140);
			Dealer.NativeMethodInfoPtr_SetUpDialogue_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100675141);
			Dealer.NativeMethodInfoPtr_MinPass_Protected_Virtual_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100675142);
			Dealer.NativeMethodInfoPtr_MarkAsRecommended_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100675143);
			Dealer.NativeMethodInfoPtr_SetRecommended_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100675144);
			Dealer.NativeMethodInfoPtr_InitialRecruitment_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100675145);
			Dealer.NativeMethodInfoPtr_SetIsRecruited_Public_Virtual_New_Void_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100675146);
			Dealer.NativeMethodInfoPtr_OnDealerUnlocked_Protected_Virtual_New_Void_EUnlockType_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100675147);
			Dealer.NativeMethodInfoPtr_UpdatePotentialDealerPoI_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100675148);
			Dealer.NativeMethodInfoPtr_TradeItems_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100675149);
			Dealer.NativeMethodInfoPtr_TradeItemsDone_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100675150);
			Dealer.NativeMethodInfoPtr_CanCollectCash_Private_Boolean_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100675151);
			Dealer.NativeMethodInfoPtr_UpdateCollectCashChoice_Private_Void_Single_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100675152);
			Dealer.NativeMethodInfoPtr_CollectCash_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100675153);
			Dealer.NativeMethodInfoPtr_UpdateCurrentDeal_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100675154);
			Dealer.NativeMethodInfoPtr_CanOfferRecruitment_Private_Boolean_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100675155);
			Dealer.NativeMethodInfoPtr_CheckAttendStart_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100675156);
			Dealer.NativeMethodInfoPtr_ShouldAcceptContract_Public_Virtual_New_Boolean_ContractInfo_Customer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100675157);
			Dealer.NativeMethodInfoPtr_ContractedOffered_Public_Virtual_New_Void_ContractInfo_Customer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100675158);
			Dealer.NativeMethodInfoPtr_SendAddCustomer_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100675159);
			Dealer.NativeMethodInfoPtr_AddCustomer_Private_Void_NetworkConnection_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100675160);
			Dealer.NativeMethodInfoPtr_AddCustomer_Protected_Virtual_New_Void_Customer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100675161);
			Dealer.NativeMethodInfoPtr_SendRemoveCustomer_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100675162);
			Dealer.NativeMethodInfoPtr_RemoveCustomer_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100675163);
			Dealer.NativeMethodInfoPtr_RemoveCustomer_Public_Virtual_New_Void_Customer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100675164);
			Dealer.NativeMethodInfoPtr_ChangeCash_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100675165);
			Dealer.NativeMethodInfoPtr_SetCash_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100675166);
			Dealer.NativeMethodInfoPtr_CompletedDeal_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100675167);
			Dealer.NativeMethodInfoPtr_SubmitPayment_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100675168);
			Dealer.NativeMethodInfoPtr_GetOrderableProducts_Public_List_1_ProductDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100675169);
			Dealer.NativeMethodInfoPtr_GetProductCount_Public_Int32_String_EQuality_EQuality_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100675170);
			Dealer.NativeMethodInfoPtr_GetDealWindow_Private_EDealWindow_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100675171);
			Dealer.NativeMethodInfoPtr_GetContractCountInWindow_Private_Int32_EDealWindow_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100675172);
			Dealer.NativeMethodInfoPtr_CustomerContractStarted_Private_Void_Contract_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100675173);
			Dealer.NativeMethodInfoPtr_CustomerContractEnded_Private_Void_Contract_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100675174);
			Dealer.NativeMethodInfoPtr_SortContracts_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100675175);
			Dealer.NativeMethodInfoPtr_RecruitmentRequested_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100675176);
			Dealer.NativeMethodInfoPtr_RemoveContractItems_Public_Boolean_Contract_EQuality_byref_List_1_ItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100675177);
			Dealer.NativeMethodInfoPtr_GetItems_Private_List_1_ItemInstance_String_Int32_Func_2_ProductItemInstance_Boolean_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100675178);
			Dealer.NativeMethodInfoPtr_GetAllSlots_Public_List_1_ItemSlot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100675179);
			Dealer.NativeMethodInfoPtr_AddItemToInventory_Public_Void_ItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100675180);
			Dealer.NativeMethodInfoPtr_TryMoveOverflowItems_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100675181);
			Dealer.NativeMethodInfoPtr_GetTotalInventoryItemCount_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100675182);
			Dealer.NativeMethodInfoPtr_SetStoredInstance_Public_Virtual_Final_New_Void_NetworkConnection_Int32_ItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100675183);
			Dealer.NativeMethodInfoPtr_SetStoredInstance_Internal_Private_Void_NetworkConnection_Int32_ItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100675184);
			Dealer.NativeMethodInfoPtr_SetItemSlotQuantity_Public_Virtual_Final_New_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100675185);
			Dealer.NativeMethodInfoPtr_SetItemSlotQuantity_Internal_Private_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100675186);
			Dealer.NativeMethodInfoPtr_SetSlotLocked_Public_Virtual_Final_New_Void_NetworkConnection_Int32_Boolean_NetworkObject_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100675187);
			Dealer.NativeMethodInfoPtr_SetSlotLocked_Internal_Private_Void_NetworkConnection_Int32_Boolean_NetworkObject_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100675188);
			Dealer.NativeMethodInfoPtr_SetSlotFilter_Public_Virtual_Final_New_Void_NetworkConnection_Int32_SlotFilter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100675189);
			Dealer.NativeMethodInfoPtr_SetSlotFilter_Internal_Private_Void_NetworkConnection_Int32_SlotFilter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100675190);
			Dealer.NativeMethodInfoPtr_GetNPCData_Public_Virtual_NPCData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100675191);
			Dealer.NativeMethodInfoPtr_Load_Public_Virtual_Void_DynamicSaveData_NPCData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100675192);
			Dealer.NativeMethodInfoPtr_Load_Public_Virtual_Void_NPCData_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100675193);
			Dealer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100675194);
			Dealer.NativeMethodInfoPtr__Awake_b__59_0_Private_Void_EUnlockType_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100675196);
			Dealer.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100675197);
			Dealer.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100675198);
			Dealer.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100675199);
			Dealer.NativeMethodInfoPtr_RpcWriter___Server_MarkAsRecommended_2166136261_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100675200);
			Dealer.NativeMethodInfoPtr_RpcLogic___MarkAsRecommended_2166136261_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100675201);
			Dealer.NativeMethodInfoPtr_RpcReader___Server_MarkAsRecommended_2166136261_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100675202);
			Dealer.NativeMethodInfoPtr_RpcWriter___Observers_SetRecommended_2166136261_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100675203);
			Dealer.NativeMethodInfoPtr_RpcLogic___SetRecommended_2166136261_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100675204);
			Dealer.NativeMethodInfoPtr_RpcReader___Observers_SetRecommended_2166136261_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100675205);
			Dealer.NativeMethodInfoPtr_RpcWriter___Server_InitialRecruitment_2166136261_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100675206);
			Dealer.NativeMethodInfoPtr_RpcLogic___InitialRecruitment_2166136261_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100675207);
			Dealer.NativeMethodInfoPtr_RpcReader___Server_InitialRecruitment_2166136261_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100675208);
			Dealer.NativeMethodInfoPtr_RpcWriter___Observers_SetIsRecruited_328543758_Private_Void_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100675209);
			Dealer.NativeMethodInfoPtr_RpcLogic___SetIsRecruited_328543758_Public_Virtual_New_Void_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100675210);
			Dealer.NativeMethodInfoPtr_RpcReader___Observers_SetIsRecruited_328543758_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100675211);
			Dealer.NativeMethodInfoPtr_RpcWriter___Target_SetIsRecruited_328543758_Private_Void_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100675212);
			Dealer.NativeMethodInfoPtr_RpcReader___Target_SetIsRecruited_328543758_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100675213);
			Dealer.NativeMethodInfoPtr_RpcWriter___Server_SendAddCustomer_3615296227_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100675214);
			Dealer.NativeMethodInfoPtr_RpcLogic___SendAddCustomer_3615296227_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100675215);
			Dealer.NativeMethodInfoPtr_RpcReader___Server_SendAddCustomer_3615296227_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100675216);
			Dealer.NativeMethodInfoPtr_RpcWriter___Observers_AddCustomer_2971853958_Private_Void_NetworkConnection_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100675217);
			Dealer.NativeMethodInfoPtr_RpcLogic___AddCustomer_2971853958_Private_Void_NetworkConnection_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100675218);
			Dealer.NativeMethodInfoPtr_RpcReader___Observers_AddCustomer_2971853958_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100675219);
			Dealer.NativeMethodInfoPtr_RpcWriter___Target_AddCustomer_2971853958_Private_Void_NetworkConnection_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100675220);
			Dealer.NativeMethodInfoPtr_RpcReader___Target_AddCustomer_2971853958_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100675221);
			Dealer.NativeMethodInfoPtr_RpcWriter___Server_SendRemoveCustomer_3615296227_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100675222);
			Dealer.NativeMethodInfoPtr_RpcLogic___SendRemoveCustomer_3615296227_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100675223);
			Dealer.NativeMethodInfoPtr_RpcReader___Server_SendRemoveCustomer_3615296227_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100675224);
			Dealer.NativeMethodInfoPtr_RpcWriter___Observers_RemoveCustomer_3615296227_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100675225);
			Dealer.NativeMethodInfoPtr_RpcLogic___RemoveCustomer_3615296227_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100675226);
			Dealer.NativeMethodInfoPtr_RpcReader___Observers_RemoveCustomer_3615296227_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100675227);
			Dealer.NativeMethodInfoPtr_RpcWriter___Server_SetCash_431000436_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100675228);
			Dealer.NativeMethodInfoPtr_RpcLogic___SetCash_431000436_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100675229);
			Dealer.NativeMethodInfoPtr_RpcReader___Server_SetCash_431000436_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100675230);
			Dealer.NativeMethodInfoPtr_RpcWriter___Server_CompletedDeal_2166136261_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100675231);
			Dealer.NativeMethodInfoPtr_RpcLogic___CompletedDeal_2166136261_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100675232);
			Dealer.NativeMethodInfoPtr_RpcReader___Server_CompletedDeal_2166136261_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100675233);
			Dealer.NativeMethodInfoPtr_RpcWriter___Server_SubmitPayment_431000436_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100675234);
			Dealer.NativeMethodInfoPtr_RpcLogic___SubmitPayment_431000436_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100675235);
			Dealer.NativeMethodInfoPtr_RpcReader___Server_SubmitPayment_431000436_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100675236);
			Dealer.NativeMethodInfoPtr_RpcWriter___Server_SetStoredInstance_2652194801_Private_Void_NetworkConnection_Int32_ItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100675237);
			Dealer.NativeMethodInfoPtr_RpcLogic___SetStoredInstance_2652194801_Public_Virtual_Final_New_Void_NetworkConnection_Int32_ItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100675238);
			Dealer.NativeMethodInfoPtr_RpcReader___Server_SetStoredInstance_2652194801_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100675239);
			Dealer.NativeMethodInfoPtr_RpcWriter___Observers_SetStoredInstance_Internal_2652194801_Private_Void_NetworkConnection_Int32_ItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100675240);
			Dealer.NativeMethodInfoPtr_RpcLogic___SetStoredInstance_Internal_2652194801_Private_Void_NetworkConnection_Int32_ItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100675241);
			Dealer.NativeMethodInfoPtr_RpcReader___Observers_SetStoredInstance_Internal_2652194801_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100675242);
			Dealer.NativeMethodInfoPtr_RpcWriter___Target_SetStoredInstance_Internal_2652194801_Private_Void_NetworkConnection_Int32_ItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100675243);
			Dealer.NativeMethodInfoPtr_RpcReader___Target_SetStoredInstance_Internal_2652194801_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100675244);
			Dealer.NativeMethodInfoPtr_RpcWriter___Server_SetItemSlotQuantity_1692629761_Private_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100675245);
			Dealer.NativeMethodInfoPtr_RpcLogic___SetItemSlotQuantity_1692629761_Public_Virtual_Final_New_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100675246);
			Dealer.NativeMethodInfoPtr_RpcReader___Server_SetItemSlotQuantity_1692629761_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100675247);
			Dealer.NativeMethodInfoPtr_RpcWriter___Observers_SetItemSlotQuantity_Internal_1692629761_Private_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100675248);
			Dealer.NativeMethodInfoPtr_RpcLogic___SetItemSlotQuantity_Internal_1692629761_Private_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100675249);
			Dealer.NativeMethodInfoPtr_RpcReader___Observers_SetItemSlotQuantity_Internal_1692629761_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100675250);
			Dealer.NativeMethodInfoPtr_RpcWriter___Server_SetSlotLocked_3170825843_Private_Void_NetworkConnection_Int32_Boolean_NetworkObject_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100675251);
			Dealer.NativeMethodInfoPtr_RpcLogic___SetSlotLocked_3170825843_Public_Virtual_Final_New_Void_NetworkConnection_Int32_Boolean_NetworkObject_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100675252);
			Dealer.NativeMethodInfoPtr_RpcReader___Server_SetSlotLocked_3170825843_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100675253);
			Dealer.NativeMethodInfoPtr_RpcWriter___Target_SetSlotLocked_Internal_3170825843_Private_Void_NetworkConnection_Int32_Boolean_NetworkObject_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100675254);
			Dealer.NativeMethodInfoPtr_RpcLogic___SetSlotLocked_Internal_3170825843_Private_Void_NetworkConnection_Int32_Boolean_NetworkObject_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100675255);
			Dealer.NativeMethodInfoPtr_RpcReader___Target_SetSlotLocked_Internal_3170825843_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100675256);
			Dealer.NativeMethodInfoPtr_RpcWriter___Observers_SetSlotLocked_Internal_3170825843_Private_Void_NetworkConnection_Int32_Boolean_NetworkObject_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100675257);
			Dealer.NativeMethodInfoPtr_RpcReader___Observers_SetSlotLocked_Internal_3170825843_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100675258);
			Dealer.NativeMethodInfoPtr_RpcWriter___Server_SetSlotFilter_527532783_Private_Void_NetworkConnection_Int32_SlotFilter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100675259);
			Dealer.NativeMethodInfoPtr_RpcLogic___SetSlotFilter_527532783_Public_Virtual_Final_New_Void_NetworkConnection_Int32_SlotFilter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100675260);
			Dealer.NativeMethodInfoPtr_RpcReader___Server_SetSlotFilter_527532783_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100675261);
			Dealer.NativeMethodInfoPtr_RpcWriter___Observers_SetSlotFilter_Internal_527532783_Private_Void_NetworkConnection_Int32_SlotFilter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100675262);
			Dealer.NativeMethodInfoPtr_RpcLogic___SetSlotFilter_Internal_527532783_Private_Void_NetworkConnection_Int32_SlotFilter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100675263);
			Dealer.NativeMethodInfoPtr_RpcReader___Observers_SetSlotFilter_Internal_527532783_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100675264);
			Dealer.NativeMethodInfoPtr_RpcWriter___Target_SetSlotFilter_Internal_527532783_Private_Void_NetworkConnection_Int32_SlotFilter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100675265);
			Dealer.NativeMethodInfoPtr_RpcReader___Target_SetSlotFilter_Internal_527532783_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100675266);
			Dealer.NativeMethodInfoPtr_sync___get_value__Cash_k__BackingField_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100675267);
			Dealer.NativeMethodInfoPtr_sync___set_value__Cash_k__BackingField_Public_set_Void_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100675268);
			Dealer.NativeMethodInfoPtr_ReadSyncVar___ScheduleOne_Economy_Dealer_Public_Virtual_Boolean_PooledReader_UInt32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100675269);
			Dealer.NativeMethodInfoPtr_sync___get_value_acceptedContractGUIDs_Public_get_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100675270);
			Dealer.NativeMethodInfoPtr_sync___set_value_acceptedContractGUIDs_Public_set_Void_List_1_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100675271);
			Dealer.NativeMethodInfoPtr_Method_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100675272);
		}

		// Token: 0x17001BD1 RID: 7121
		// (get) Token: 0x06005C48 RID: 23624 RVA: 0x001AF298 File Offset: 0x001AD498
		// (set) Token: 0x06005C49 RID: 23625 RVA: 0x001AF2D4 File Offset: 0x001AD4D4
		public unsafe bool IsRecruited
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_get_IsRecruited_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
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
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_set_IsRecruited_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x17001BD2 RID: 7122
		// (get) Token: 0x06005C4A RID: 23626 RVA: 0x001AF314 File Offset: 0x001AD514
		// (set) Token: 0x06005C4B RID: 23627 RVA: 0x001AF354 File Offset: 0x001AD554
		public unsafe virtual List<ItemSlot> ItemSlots
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_get_ItemSlots_Public_Virtual_Final_New_get_List_1_ItemSlot_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ItemSlot>>(intPtr2) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_set_ItemSlots_Public_Virtual_Final_New_set_Void_List_1_ItemSlot_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x17001BD3 RID: 7123
		// (get) Token: 0x06005C4C RID: 23628 RVA: 0x001AF398 File Offset: 0x001AD598
		// (set) Token: 0x06005C4D RID: 23629 RVA: 0x001AF3D4 File Offset: 0x001AD5D4
		public unsafe float Cash
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 195088, RefRangeEnd = 195090, XrefRangeStart = 195088, XrefRangeEnd = 195088, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_get_Cash_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 195090, XrefRangeEnd = 195097, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = ref value;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_set_Cash_Private_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x17001BD4 RID: 7124
		// (get) Token: 0x06005C4E RID: 23630 RVA: 0x001AF414 File Offset: 0x001AD614
		// (set) Token: 0x06005C4F RID: 23631 RVA: 0x001AF450 File Offset: 0x001AD650
		public unsafe bool HasBeenRecommended
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_get_HasBeenRecommended_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
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
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_set_HasBeenRecommended_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x17001BD5 RID: 7125
		// (get) Token: 0x06005C50 RID: 23632 RVA: 0x001AF490 File Offset: 0x001AD690
		// (set) Token: 0x06005C51 RID: 23633 RVA: 0x001AF4D0 File Offset: 0x001AD6D0
		public unsafe NPCPoI potentialDealerPoI
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 97310, RefRangeEnd = 97315, XrefRangeStart = 97310, XrefRangeEnd = 97315, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_get_potentialDealerPoI_Public_get_NPCPoI_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
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
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_set_potentialDealerPoI_Protected_set_Void_NPCPoI_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x17001BD6 RID: 7126
		// (get) Token: 0x06005C52 RID: 23634 RVA: 0x001AF514 File Offset: 0x001AD714
		// (set) Token: 0x06005C53 RID: 23635 RVA: 0x001AF554 File Offset: 0x001AD754
		public unsafe NPCPoI dealerPoI
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_get_dealerPoI_Public_get_NPCPoI_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
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
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_set_dealerPoI_Protected_set_Void_NPCPoI_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x06005C54 RID: 23636 RVA: 0x001AF598 File Offset: 0x001AD798
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 195098, RefRangeEnd = 195104, XrefRangeStart = 195097, XrefRangeEnd = 195098, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Dealer.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005C55 RID: 23637 RVA: 0x001AF5D4 File Offset: 0x001AD7D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 195104, XrefRangeEnd = 195107, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnValidate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Dealer.NativeMethodInfoPtr_OnValidate_Protected_Virtual_Void_1), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005C56 RID: 23638 RVA: 0x001AF610 File Offset: 0x001AD810
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 195107, XrefRangeEnd = 195116, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Dealer.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_1), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005C57 RID: 23639 RVA: 0x001AF64C File Offset: 0x001AD84C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 195116, XrefRangeEnd = 195174, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Dealer.NativeMethodInfoPtr_Start_Protected_Virtual_Void_1), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005C58 RID: 23640 RVA: 0x001AF688 File Offset: 0x001AD888
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 195174, XrefRangeEnd = 195191, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnSpawnServer(NetworkConnection connection)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(connection);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Dealer.NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005C59 RID: 23641 RVA: 0x001AF6D8 File Offset: 0x001AD8D8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 195244, RefRangeEnd = 195245, XrefRangeStart = 195191, XrefRangeEnd = 195244, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetupPoI()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_SetupPoI_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005C5A RID: 23642 RVA: 0x001AF70C File Offset: 0x001AD90C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 195275, RefRangeEnd = 195276, XrefRangeStart = 195245, XrefRangeEnd = 195275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetUpDialogue()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_SetUpDialogue_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005C5B RID: 23643 RVA: 0x001AF740 File Offset: 0x001AD940
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 195294, RefRangeEnd = 195295, XrefRangeStart = 195276, XrefRangeEnd = 195294, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void MinPass()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Dealer.NativeMethodInfoPtr_MinPass_Protected_Virtual_Void_1), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005C5C RID: 23644 RVA: 0x001AF77C File Offset: 0x001AD97C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 195316, RefRangeEnd = 195319, XrefRangeStart = 195295, XrefRangeEnd = 195316, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MarkAsRecommended()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_MarkAsRecommended_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005C5D RID: 23645 RVA: 0x001AF7B0 File Offset: 0x001AD9B0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 195339, RefRangeEnd = 195341, XrefRangeStart = 195319, XrefRangeEnd = 195339, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetRecommended()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_SetRecommended_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005C5E RID: 23646 RVA: 0x001AF7E4 File Offset: 0x001AD9E4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 195361, RefRangeEnd = 195362, XrefRangeStart = 195341, XrefRangeEnd = 195361, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InitialRecruitment()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_InitialRecruitment_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005C5F RID: 23647 RVA: 0x001AF818 File Offset: 0x001ADA18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 195362, XrefRangeEnd = 195399, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetIsRecruited(NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Dealer.NativeMethodInfoPtr_SetIsRecruited_Public_Virtual_New_Void_NetworkConnection_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005C60 RID: 23648 RVA: 0x001AF868 File Offset: 0x001ADA68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 195399, XrefRangeEnd = 195404, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnDealerUnlocked(NPCRelationData.EUnlockType unlockType, bool b)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref unlockType;
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref b;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Dealer.NativeMethodInfoPtr_OnDealerUnlocked_Protected_Virtual_New_Void_EUnlockType_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005C61 RID: 23649 RVA: 0x001AF8C0 File Offset: 0x001ADAC0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 195419, RefRangeEnd = 195420, XrefRangeStart = 195404, XrefRangeEnd = 195419, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void UpdatePotentialDealerPoI()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Dealer.NativeMethodInfoPtr_UpdatePotentialDealerPoI_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005C62 RID: 23650 RVA: 0x001AF8FC File Offset: 0x001ADAFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 195420, XrefRangeEnd = 195443, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void TradeItems()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_TradeItems_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005C63 RID: 23651 RVA: 0x001AF930 File Offset: 0x001ADB30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 195443, XrefRangeEnd = 195462, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void TradeItemsDone()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_TradeItemsDone_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005C64 RID: 23652 RVA: 0x001AF964 File Offset: 0x001ADB64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 195462, XrefRangeEnd = 195465, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool CanCollectCash(out string reason)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			ref System.IntPtr ptr2 = ref *ptr;
			System.IntPtr il2CppString = 0;
			ptr2 = &il2CppString;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_CanCollectCash_Private_Boolean_byref_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			reason = IL2CPP.Il2CppStringToManaged(il2CppString);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06005C65 RID: 23653 RVA: 0x001AF9BC File Offset: 0x001ADBBC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 195472, RefRangeEnd = 195475, XrefRangeStart = 195465, XrefRangeEnd = 195472, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateCollectCashChoice(float oldCash, float newCash, bool asServer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref oldCash;
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref newCash;
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref asServer;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_UpdateCollectCashChoice_Private_Void_Single_Single_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005C66 RID: 23654 RVA: 0x001AFA18 File Offset: 0x001ADC18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 195475, XrefRangeEnd = 195482, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CollectCash()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_CollectCash_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005C67 RID: 23655 RVA: 0x001AFA4C File Offset: 0x001ADC4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 195482, XrefRangeEnd = 195486, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateCurrentDeal()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_UpdateCurrentDeal_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005C68 RID: 23656 RVA: 0x001AFA80 File Offset: 0x001ADC80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 195486, XrefRangeEnd = 195494, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool CanOfferRecruitment(out string reason)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			ref System.IntPtr ptr2 = ref *ptr;
			System.IntPtr il2CppString = 0;
			ptr2 = &il2CppString;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_CanOfferRecruitment_Private_Boolean_byref_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			reason = IL2CPP.Il2CppStringToManaged(il2CppString);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06005C69 RID: 23657 RVA: 0x001AFAD8 File Offset: 0x001ADCD8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 195536, RefRangeEnd = 195537, XrefRangeStart = 195494, XrefRangeEnd = 195536, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CheckAttendStart()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_CheckAttendStart_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005C6A RID: 23658 RVA: 0x001AFB0C File Offset: 0x001ADD0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 195537, XrefRangeEnd = 195579, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool ShouldAcceptContract(ContractInfo contractInfo, Customer customer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(contractInfo);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(customer);
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Dealer.NativeMethodInfoPtr_ShouldAcceptContract_Public_Virtual_New_Boolean_ContractInfo_Customer_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06005C6B RID: 23659 RVA: 0x001AFB78 File Offset: 0x001ADD78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 195579, XrefRangeEnd = 195596, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void ContractedOffered(ContractInfo contractInfo, Customer customer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(contractInfo);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(customer);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Dealer.NativeMethodInfoPtr_ContractedOffered_Public_Virtual_New_Void_ContractInfo_Customer_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005C6C RID: 23660 RVA: 0x001AFBD8 File Offset: 0x001ADDD8
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 195618, RefRangeEnd = 195622, XrefRangeStart = 195596, XrefRangeEnd = 195618, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendAddCustomer(string npcID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(npcID);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_SendAddCustomer_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005C6D RID: 23661 RVA: 0x001AFC1C File Offset: 0x001ADE1C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 195664, RefRangeEnd = 195668, XrefRangeStart = 195622, XrefRangeEnd = 195664, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddCustomer(NetworkConnection conn, string npcID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(npcID);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_AddCustomer_Private_Void_NetworkConnection_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005C6E RID: 23662 RVA: 0x001AFC70 File Offset: 0x001ADE70
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 195686, RefRangeEnd = 195687, XrefRangeStart = 195668, XrefRangeEnd = 195686, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void AddCustomer(Customer customer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(customer);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Dealer.NativeMethodInfoPtr_AddCustomer_Protected_Virtual_New_Void_Customer_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005C6F RID: 23663 RVA: 0x001AFCC0 File Offset: 0x001ADEC0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 195709, RefRangeEnd = 195711, XrefRangeStart = 195687, XrefRangeEnd = 195709, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendRemoveCustomer(string npcID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(npcID);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_SendRemoveCustomer_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005C70 RID: 23664 RVA: 0x001AFD04 File Offset: 0x001ADF04
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 195733, RefRangeEnd = 195735, XrefRangeStart = 195711, XrefRangeEnd = 195733, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveCustomer(string npcID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(npcID);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_RemoveCustomer_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005C71 RID: 23665 RVA: 0x001AFD48 File Offset: 0x001ADF48
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 195751, RefRangeEnd = 195752, XrefRangeStart = 195735, XrefRangeEnd = 195751, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void RemoveCustomer(Customer customer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(customer);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Dealer.NativeMethodInfoPtr_RemoveCustomer_Public_Virtual_New_Void_Customer_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005C72 RID: 23666 RVA: 0x001AFD98 File Offset: 0x001ADF98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 195752, XrefRangeEnd = 195753, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ChangeCash(float change)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref change;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_ChangeCash_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005C73 RID: 23667 RVA: 0x001AFDD8 File Offset: 0x001ADFD8
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 195763, RefRangeEnd = 195769, XrefRangeStart = 195753, XrefRangeEnd = 195763, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetCash(float cash)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref cash;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_SetCash_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005C74 RID: 23668 RVA: 0x001AFE18 File Offset: 0x001AE018
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 195769, XrefRangeEnd = 195778, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void CompletedDeal()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Dealer.NativeMethodInfoPtr_CompletedDeal_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005C75 RID: 23669 RVA: 0x001AFE54 File Offset: 0x001AE054
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 195788, RefRangeEnd = 195789, XrefRangeStart = 195778, XrefRangeEnd = 195788, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SubmitPayment(float payment)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref payment;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_SubmitPayment_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005C76 RID: 23670 RVA: 0x001AFE94 File Offset: 0x001AE094
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 195840, RefRangeEnd = 195841, XrefRangeStart = 195789, XrefRangeEnd = 195840, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<ProductDefinition> GetOrderableProducts()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_GetOrderableProducts_Public_List_1_ProductDefinition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ProductDefinition>>(intPtr2) : null;
		}

		// Token: 0x06005C77 RID: 23671 RVA: 0x001AFED4 File Offset: 0x001AE0D4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 195860, RefRangeEnd = 195862, XrefRangeStart = 195841, XrefRangeEnd = 195860, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetProductCount(string productID, EQuality minQuality, EQuality maxQuality)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(productID);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref minQuality;
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref maxQuality;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_GetProductCount_Public_Int32_String_EQuality_EQuality_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06005C78 RID: 23672 RVA: 0x001AFF40 File Offset: 0x001AE140
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 195912, RefRangeEnd = 195913, XrefRangeStart = 195862, XrefRangeEnd = 195912, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EDealWindow GetDealWindow()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_GetDealWindow_Private_EDealWindow_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06005C79 RID: 23673 RVA: 0x001AFF7C File Offset: 0x001AE17C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 195932, RefRangeEnd = 195933, XrefRangeStart = 195913, XrefRangeEnd = 195932, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetContractCountInWindow(EDealWindow window)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref window;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_GetContractCountInWindow_Private_Int32_EDealWindow_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06005C7A RID: 23674 RVA: 0x001AFFC8 File Offset: 0x001AE1C8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 195961, RefRangeEnd = 195963, XrefRangeStart = 195933, XrefRangeEnd = 195961, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CustomerContractStarted(Contract contract)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(contract);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_CustomerContractStarted_Private_Void_Contract_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005C7B RID: 23675 RVA: 0x001B000C File Offset: 0x001AE20C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 195963, XrefRangeEnd = 195980, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CustomerContractEnded(Contract contract)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(contract);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_CustomerContractEnded_Private_Void_Contract_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005C7C RID: 23676 RVA: 0x001B0050 File Offset: 0x001AE250
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 195980, XrefRangeEnd = 196002, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SortContracts()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_SortContracts_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005C7D RID: 23677 RVA: 0x001B0084 File Offset: 0x001AE284
		[CallerCount(14558)]
		[CachedScanResults(RefRangeStart = 2769, RefRangeEnd = 17327, XrefRangeStart = 2769, XrefRangeEnd = 17327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void RecruitmentRequested()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Dealer.NativeMethodInfoPtr_RecruitmentRequested_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005C7E RID: 23678 RVA: 0x001B00C0 File Offset: 0x001AE2C0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 196046, RefRangeEnd = 196047, XrefRangeStart = 196002, XrefRangeEnd = 196046, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool RemoveContractItems(Contract contract, EQuality targetQuality, out List<ItemInstance> items)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(contract);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref targetQuality;
			ref System.IntPtr ptr2 = ref ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)];
			System.IntPtr intPtr = 0;
			ptr2 = &intPtr;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_RemoveContractItems_Public_Boolean_Contract_EQuality_byref_List_1_ItemInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			items = ((intPtr2 == 0) ? null : new List<ItemInstance>(intPtr2));
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06005C7F RID: 23679 RVA: 0x001B0140 File Offset: 0x001AE340
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 196222, RefRangeEnd = 196223, XrefRangeStart = 196047, XrefRangeEnd = 196222, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<ItemInstance> GetItems(string ID, int requiredQuantity, Il2CppSystem.Func<ProductItemInstance, bool> qualityCheck, out int returnedQuantity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)4) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(ID);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref requiredQuantity;
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(qualityCheck);
			ptr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = &returnedQuantity;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_GetItems_Private_List_1_ItemInstance_String_Int32_Func_2_ProductItemInstance_Boolean_byref_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ItemInstance>>(intPtr2) : null;
		}

		// Token: 0x06005C80 RID: 23680 RVA: 0x001B01C0 File Offset: 0x001AE3C0
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 196232, RefRangeEnd = 196238, XrefRangeStart = 196223, XrefRangeEnd = 196232, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<ItemSlot> GetAllSlots()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_GetAllSlots_Public_List_1_ItemSlot_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ItemSlot>>(intPtr2) : null;
		}

		// Token: 0x06005C81 RID: 23681 RVA: 0x001B0200 File Offset: 0x001AE400
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 196256, RefRangeEnd = 196257, XrefRangeStart = 196238, XrefRangeEnd = 196256, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddItemToInventory(ItemInstance item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_AddItemToInventory_Public_Void_ItemInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005C82 RID: 23682 RVA: 0x001B0244 File Offset: 0x001AE444
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 196262, RefRangeEnd = 196264, XrefRangeStart = 196257, XrefRangeEnd = 196262, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void TryMoveOverflowItems()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_TryMoveOverflowItems_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005C83 RID: 23683 RVA: 0x001B0278 File Offset: 0x001AE478
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 196279, RefRangeEnd = 196281, XrefRangeStart = 196264, XrefRangeEnd = 196279, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetTotalInventoryItemCount()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_GetTotalInventoryItemCount_Public_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06005C84 RID: 23684 RVA: 0x001B02B4 File Offset: 0x001AE4B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 196281, XrefRangeEnd = 196308, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetStoredInstance(NetworkConnection conn, int itemSlotIndex, ItemInstance instance)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref itemSlotIndex;
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(instance);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_SetStoredInstance_Public_Virtual_Final_New_Void_NetworkConnection_Int32_ItemInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005C85 RID: 23685 RVA: 0x001B0318 File Offset: 0x001AE518
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 196354, RefRangeEnd = 196357, XrefRangeStart = 196308, XrefRangeEnd = 196354, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetStoredInstance_Internal(NetworkConnection conn, int itemSlotIndex, ItemInstance instance)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref itemSlotIndex;
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(instance);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_SetStoredInstance_Internal_Private_Void_NetworkConnection_Int32_ItemInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005C86 RID: 23686 RVA: 0x001B037C File Offset: 0x001AE57C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 196357, XrefRangeEnd = 196382, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetItemSlotQuantity(int itemSlotIndex, int quantity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref itemSlotIndex;
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref quantity;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_SetItemSlotQuantity_Public_Virtual_Final_New_Void_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005C87 RID: 23687 RVA: 0x001B03C8 File Offset: 0x001AE5C8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 196410, RefRangeEnd = 196413, XrefRangeStart = 196382, XrefRangeEnd = 196410, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetItemSlotQuantity_Internal(int itemSlotIndex, int quantity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref itemSlotIndex;
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref quantity;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_SetItemSlotQuantity_Internal_Private_Void_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005C88 RID: 23688 RVA: 0x001B0414 File Offset: 0x001AE614
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 196413, XrefRangeEnd = 196442, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetSlotLocked(NetworkConnection conn, int itemSlotIndex, bool locked, NetworkObject lockOwner, string lockReason)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)5) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref itemSlotIndex;
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref locked;
			ptr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(lockOwner);
			ptr[checked(unchecked((System.UIntPtr)4) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(lockReason);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_SetSlotLocked_Public_Virtual_Final_New_Void_NetworkConnection_Int32_Boolean_NetworkObject_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005C89 RID: 23689 RVA: 0x001B0498 File Offset: 0x001AE698
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 196492, RefRangeEnd = 196495, XrefRangeStart = 196442, XrefRangeEnd = 196492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetSlotLocked_Internal(NetworkConnection conn, int itemSlotIndex, bool locked, NetworkObject lockOwner, string lockReason)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)5) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref itemSlotIndex;
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref locked;
			ptr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(lockOwner);
			ptr[checked(unchecked((System.UIntPtr)4) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(lockReason);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_SetSlotLocked_Internal_Private_Void_NetworkConnection_Int32_Boolean_NetworkObject_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005C8A RID: 23690 RVA: 0x001B051C File Offset: 0x001AE71C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 196495, XrefRangeEnd = 196522, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetSlotFilter(NetworkConnection conn, int itemSlotIndex, SlotFilter filter)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref itemSlotIndex;
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(filter);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_SetSlotFilter_Public_Virtual_Final_New_Void_NetworkConnection_Int32_SlotFilter_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005C8B RID: 23691 RVA: 0x001B0580 File Offset: 0x001AE780
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 196568, RefRangeEnd = 196571, XrefRangeStart = 196522, XrefRangeEnd = 196568, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetSlotFilter_Internal(NetworkConnection conn, int itemSlotIndex, SlotFilter filter)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref itemSlotIndex;
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(filter);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_SetSlotFilter_Internal_Private_Void_NetworkConnection_Int32_SlotFilter_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005C8C RID: 23692 RVA: 0x001B05E4 File Offset: 0x001AE7E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 196571, XrefRangeEnd = 196597, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override NPCData GetNPCData()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Dealer.NativeMethodInfoPtr_GetNPCData_Public_Virtual_NPCData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<NPCData>(intPtr2) : null;
		}

		// Token: 0x06005C8D RID: 23693 RVA: 0x001B0630 File Offset: 0x001AE830
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 196597, XrefRangeEnd = 196658, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Load(DynamicSaveData dynamicData, NPCData npcData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(dynamicData);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(npcData);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Dealer.NativeMethodInfoPtr_Load_Public_Virtual_Void_DynamicSaveData_NPCData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005C8E RID: 23694 RVA: 0x001B0690 File Offset: 0x001AE890
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 196658, XrefRangeEnd = 196725, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Load(NPCData data, string containerPath)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(containerPath);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Dealer.NativeMethodInfoPtr_Load_Public_Virtual_Void_NPCData_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005C8F RID: 23695 RVA: 0x001B06F0 File Offset: 0x001AE8F0
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 196778, RefRangeEnd = 196784, XrefRangeStart = 196725, XrefRangeEnd = 196778, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Dealer() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Dealer>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005C90 RID: 23696 RVA: 0x001B072C File Offset: 0x001AE92C
		[CallerCount(0)]
		public unsafe void _Awake_b__59_0(NPCRelationData.EUnlockType <p0>, bool <p1>)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref <p0>;
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref <p1>;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr__Awake_b__59_0_Private_Void_EUnlockType_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005C91 RID: 23697 RVA: 0x001B0778 File Offset: 0x001AE978
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 196965, RefRangeEnd = 196971, XrefRangeStart = 196784, XrefRangeEnd = 196965, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize___Early()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Dealer.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005C92 RID: 23698 RVA: 0x001B07B4 File Offset: 0x001AE9B4
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 196972, RefRangeEnd = 196978, XrefRangeStart = 196971, XrefRangeEnd = 196972, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize__Late()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Dealer.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005C93 RID: 23699 RVA: 0x001B07F0 File Offset: 0x001AE9F0
		[CallerCount(0)]
		public unsafe override void NetworkInitializeIfDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Dealer.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005C94 RID: 23700 RVA: 0x001B082C File Offset: 0x001AEA2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 196978, XrefRangeEnd = 196987, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_MarkAsRecommended_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_RpcWriter___Server_MarkAsRecommended_2166136261_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005C95 RID: 23701 RVA: 0x001B0860 File Offset: 0x001AEA60
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 195339, RefRangeEnd = 195341, XrefRangeStart = 195339, XrefRangeEnd = 195341, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___MarkAsRecommended_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_RpcLogic___MarkAsRecommended_2166136261_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005C96 RID: 23702 RVA: 0x001B0894 File Offset: 0x001AEA94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 196987, XrefRangeEnd = 196990, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_MarkAsRecommended_2166136261(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref channel;
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_RpcReader___Server_MarkAsRecommended_2166136261_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005C97 RID: 23703 RVA: 0x001B08F8 File Offset: 0x001AEAF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 196990, XrefRangeEnd = 196999, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_SetRecommended_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_RpcWriter___Observers_SetRecommended_2166136261_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005C98 RID: 23704 RVA: 0x001B092C File Offset: 0x001AEB2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 196999, XrefRangeEnd = 197000, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SetRecommended_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_RpcLogic___SetRecommended_2166136261_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005C99 RID: 23705 RVA: 0x001B0960 File Offset: 0x001AEB60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 197000, XrefRangeEnd = 197003, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_SetRecommended_2166136261(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref channel;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_RpcReader___Observers_SetRecommended_2166136261_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005C9A RID: 23706 RVA: 0x001B09B0 File Offset: 0x001AEBB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 197003, XrefRangeEnd = 197012, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_InitialRecruitment_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_RpcWriter___Server_InitialRecruitment_2166136261_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005C9B RID: 23707 RVA: 0x001B09E4 File Offset: 0x001AEBE4
		[CallerCount(0)]
		public unsafe void RpcLogic___InitialRecruitment_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_RpcLogic___InitialRecruitment_2166136261_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005C9C RID: 23708 RVA: 0x001B0A18 File Offset: 0x001AEC18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 197012, XrefRangeEnd = 197014, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_InitialRecruitment_2166136261(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref channel;
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_RpcReader___Server_InitialRecruitment_2166136261_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005C9D RID: 23709 RVA: 0x001B0A7C File Offset: 0x001AEC7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 197014, XrefRangeEnd = 197023, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_SetIsRecruited_328543758(NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_RpcWriter___Observers_SetIsRecruited_328543758_Private_Void_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005C9E RID: 23710 RVA: 0x001B0AC0 File Offset: 0x001AECC0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 197085, RefRangeEnd = 197088, XrefRangeStart = 197023, XrefRangeEnd = 197085, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void RpcLogic___SetIsRecruited_328543758(NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Dealer.NativeMethodInfoPtr_RpcLogic___SetIsRecruited_328543758_Public_Virtual_New_Void_NetworkConnection_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005C9F RID: 23711 RVA: 0x001B0B10 File Offset: 0x001AED10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 197088, XrefRangeEnd = 197091, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_SetIsRecruited_328543758(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref channel;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_RpcReader___Observers_SetIsRecruited_328543758_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005CA0 RID: 23712 RVA: 0x001B0B60 File Offset: 0x001AED60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 197091, XrefRangeEnd = 197100, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Target_SetIsRecruited_328543758(NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_RpcWriter___Target_SetIsRecruited_328543758_Private_Void_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005CA1 RID: 23713 RVA: 0x001B0BA4 File Offset: 0x001AEDA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 197100, XrefRangeEnd = 197103, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Target_SetIsRecruited_328543758(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref channel;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_RpcReader___Target_SetIsRecruited_328543758_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005CA2 RID: 23714 RVA: 0x001B0BF4 File Offset: 0x001AEDF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 197103, XrefRangeEnd = 197113, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_SendAddCustomer_3615296227(string npcID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(npcID);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_RpcWriter___Server_SendAddCustomer_3615296227_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005CA3 RID: 23715 RVA: 0x001B0C38 File Offset: 0x001AEE38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 197113, XrefRangeEnd = 197114, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SendAddCustomer_3615296227(string npcID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(npcID);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_RpcLogic___SendAddCustomer_3615296227_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005CA4 RID: 23716 RVA: 0x001B0C7C File Offset: 0x001AEE7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 197114, XrefRangeEnd = 197118, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_SendAddCustomer_3615296227(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref channel;
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_RpcReader___Server_SendAddCustomer_3615296227_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005CA5 RID: 23717 RVA: 0x001B0CE0 File Offset: 0x001AEEE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 197118, XrefRangeEnd = 197128, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_AddCustomer_2971853958(NetworkConnection conn, string npcID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(npcID);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_RpcWriter___Observers_AddCustomer_2971853958_Private_Void_NetworkConnection_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005CA6 RID: 23718 RVA: 0x001B0D34 File Offset: 0x001AEF34
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 197156, RefRangeEnd = 197159, XrefRangeStart = 197128, XrefRangeEnd = 197156, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___AddCustomer_2971853958(NetworkConnection conn, string npcID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(npcID);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_RpcLogic___AddCustomer_2971853958_Private_Void_NetworkConnection_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005CA7 RID: 23719 RVA: 0x001B0D88 File Offset: 0x001AEF88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 197159, XrefRangeEnd = 197163, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_AddCustomer_2971853958(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref channel;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_RpcReader___Observers_AddCustomer_2971853958_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005CA8 RID: 23720 RVA: 0x001B0DD8 File Offset: 0x001AEFD8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 197163, XrefRangeEnd = 197173, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Target_AddCustomer_2971853958(NetworkConnection conn, string npcID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(npcID);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_RpcWriter___Target_AddCustomer_2971853958_Private_Void_NetworkConnection_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005CA9 RID: 23721 RVA: 0x001B0E2C File Offset: 0x001AF02C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 197173, XrefRangeEnd = 197177, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Target_AddCustomer_2971853958(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref channel;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_RpcReader___Target_AddCustomer_2971853958_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005CAA RID: 23722 RVA: 0x001B0E7C File Offset: 0x001AF07C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 197177, XrefRangeEnd = 197187, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_SendRemoveCustomer_3615296227(string npcID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(npcID);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_RpcWriter___Server_SendRemoveCustomer_3615296227_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005CAB RID: 23723 RVA: 0x001B0EC0 File Offset: 0x001AF0C0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 195733, RefRangeEnd = 195735, XrefRangeStart = 195733, XrefRangeEnd = 195735, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SendRemoveCustomer_3615296227(string npcID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(npcID);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_RpcLogic___SendRemoveCustomer_3615296227_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005CAC RID: 23724 RVA: 0x001B0F04 File Offset: 0x001AF104
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 197187, XrefRangeEnd = 197191, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_SendRemoveCustomer_3615296227(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref channel;
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_RpcReader___Server_SendRemoveCustomer_3615296227_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005CAD RID: 23725 RVA: 0x001B0F68 File Offset: 0x001AF168
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 197191, XrefRangeEnd = 197201, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_RemoveCustomer_3615296227(string npcID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(npcID);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_RpcWriter___Observers_RemoveCustomer_3615296227_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005CAE RID: 23726 RVA: 0x001B0FAC File Offset: 0x001AF1AC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 197229, RefRangeEnd = 197232, XrefRangeStart = 197201, XrefRangeEnd = 197229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___RemoveCustomer_3615296227(string npcID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(npcID);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_RpcLogic___RemoveCustomer_3615296227_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005CAF RID: 23727 RVA: 0x001B0FF0 File Offset: 0x001AF1F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 197232, XrefRangeEnd = 197236, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_RemoveCustomer_3615296227(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref channel;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_RpcReader___Observers_RemoveCustomer_3615296227_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005CB0 RID: 23728 RVA: 0x001B1040 File Offset: 0x001AF240
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 195763, RefRangeEnd = 195769, XrefRangeStart = 195763, XrefRangeEnd = 195769, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_SetCash_431000436(float cash)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref cash;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_RpcWriter___Server_SetCash_431000436_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005CB1 RID: 23729 RVA: 0x001B1080 File Offset: 0x001AF280
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 197236, XrefRangeEnd = 197245, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SetCash_431000436(float cash)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref cash;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_RpcLogic___SetCash_431000436_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005CB2 RID: 23730 RVA: 0x001B10C0 File Offset: 0x001AF2C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 197245, XrefRangeEnd = 197256, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_SetCash_431000436(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref channel;
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_RpcReader___Server_SetCash_431000436_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005CB3 RID: 23731 RVA: 0x001B1124 File Offset: 0x001AF324
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_CompletedDeal_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_RpcWriter___Server_CompletedDeal_2166136261_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005CB4 RID: 23732 RVA: 0x001B1158 File Offset: 0x001AF358
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 197271, RefRangeEnd = 197272, XrefRangeStart = 197256, XrefRangeEnd = 197271, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void RpcLogic___CompletedDeal_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Dealer.NativeMethodInfoPtr_RpcLogic___CompletedDeal_2166136261_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005CB5 RID: 23733 RVA: 0x001B1194 File Offset: 0x001AF394
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 197272, XrefRangeEnd = 197274, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_CompletedDeal_2166136261(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref channel;
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_RpcReader___Server_CompletedDeal_2166136261_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005CB6 RID: 23734 RVA: 0x001B11F8 File Offset: 0x001AF3F8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 195788, RefRangeEnd = 195789, XrefRangeStart = 195788, XrefRangeEnd = 195789, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_SubmitPayment_431000436(float payment)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref payment;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_RpcWriter___Server_SubmitPayment_431000436_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005CB7 RID: 23735 RVA: 0x001B1238 File Offset: 0x001AF438
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 197274, XrefRangeEnd = 197298, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SubmitPayment_431000436(float payment)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref payment;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_RpcLogic___SubmitPayment_431000436_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005CB8 RID: 23736 RVA: 0x001B1278 File Offset: 0x001AF478
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 197298, XrefRangeEnd = 197324, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_SubmitPayment_431000436(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref channel;
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_RpcReader___Server_SubmitPayment_431000436_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005CB9 RID: 23737 RVA: 0x001B12DC File Offset: 0x001AF4DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 197324, XrefRangeEnd = 197337, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_SetStoredInstance_2652194801(NetworkConnection conn, int itemSlotIndex, ItemInstance instance)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref itemSlotIndex;
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(instance);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_RpcWriter___Server_SetStoredInstance_2652194801_Private_Void_NetworkConnection_Int32_ItemInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005CBA RID: 23738 RVA: 0x001B1340 File Offset: 0x001AF540
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 197337, XrefRangeEnd = 197341, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void RpcLogic___SetStoredInstance_2652194801(NetworkConnection conn, int itemSlotIndex, ItemInstance instance)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref itemSlotIndex;
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(instance);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_RpcLogic___SetStoredInstance_2652194801_Public_Virtual_Final_New_Void_NetworkConnection_Int32_ItemInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005CBB RID: 23739 RVA: 0x001B13A4 File Offset: 0x001AF5A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 197341, XrefRangeEnd = 197349, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_SetStoredInstance_2652194801(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref channel;
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_RpcReader___Server_SetStoredInstance_2652194801_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005CBC RID: 23740 RVA: 0x001B1408 File Offset: 0x001AF608
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 197349, XrefRangeEnd = 197361, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_SetStoredInstance_Internal_2652194801(NetworkConnection conn, int itemSlotIndex, ItemInstance instance)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref itemSlotIndex;
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(instance);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_RpcWriter___Observers_SetStoredInstance_Internal_2652194801_Private_Void_NetworkConnection_Int32_ItemInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005CBD RID: 23741 RVA: 0x001B146C File Offset: 0x001AF66C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 197365, RefRangeEnd = 197368, XrefRangeStart = 197361, XrefRangeEnd = 197365, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SetStoredInstance_Internal_2652194801(NetworkConnection conn, int itemSlotIndex, ItemInstance instance)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref itemSlotIndex;
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(instance);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_RpcLogic___SetStoredInstance_Internal_2652194801_Private_Void_NetworkConnection_Int32_ItemInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005CBE RID: 23742 RVA: 0x001B14D0 File Offset: 0x001AF6D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 197368, XrefRangeEnd = 197374, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_SetStoredInstance_Internal_2652194801(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref channel;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_RpcReader___Observers_SetStoredInstance_Internal_2652194801_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005CBF RID: 23743 RVA: 0x001B1520 File Offset: 0x001AF720
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 197374, XrefRangeEnd = 197386, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Target_SetStoredInstance_Internal_2652194801(NetworkConnection conn, int itemSlotIndex, ItemInstance instance)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref itemSlotIndex;
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(instance);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_RpcWriter___Target_SetStoredInstance_Internal_2652194801_Private_Void_NetworkConnection_Int32_ItemInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005CC0 RID: 23744 RVA: 0x001B1584 File Offset: 0x001AF784
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 197386, XrefRangeEnd = 197393, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Target_SetStoredInstance_Internal_2652194801(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref channel;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_RpcReader___Target_SetStoredInstance_Internal_2652194801_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005CC1 RID: 23745 RVA: 0x001B15D4 File Offset: 0x001AF7D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 197393, XrefRangeEnd = 197406, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_SetItemSlotQuantity_1692629761(int itemSlotIndex, int quantity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref itemSlotIndex;
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref quantity;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_RpcWriter___Server_SetItemSlotQuantity_1692629761_Private_Void_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005CC2 RID: 23746 RVA: 0x001B1620 File Offset: 0x001AF820
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 197406, XrefRangeEnd = 197407, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void RpcLogic___SetItemSlotQuantity_1692629761(int itemSlotIndex, int quantity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref itemSlotIndex;
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref quantity;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_RpcLogic___SetItemSlotQuantity_1692629761_Public_Virtual_Final_New_Void_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005CC3 RID: 23747 RVA: 0x001B166C File Offset: 0x001AF86C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 197407, XrefRangeEnd = 197414, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_SetItemSlotQuantity_1692629761(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref channel;
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_RpcReader___Server_SetItemSlotQuantity_1692629761_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005CC4 RID: 23748 RVA: 0x001B16D0 File Offset: 0x001AF8D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 197414, XrefRangeEnd = 197427, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_SetItemSlotQuantity_Internal_1692629761(int itemSlotIndex, int quantity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref itemSlotIndex;
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref quantity;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_RpcWriter___Observers_SetItemSlotQuantity_Internal_1692629761_Private_Void_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005CC5 RID: 23749 RVA: 0x001B171C File Offset: 0x001AF91C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 197432, RefRangeEnd = 197433, XrefRangeStart = 197427, XrefRangeEnd = 197432, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SetItemSlotQuantity_Internal_1692629761(int itemSlotIndex, int quantity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref itemSlotIndex;
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref quantity;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_RpcLogic___SetItemSlotQuantity_Internal_1692629761_Private_Void_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005CC6 RID: 23750 RVA: 0x001B1768 File Offset: 0x001AF968
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 197433, XrefRangeEnd = 197440, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_SetItemSlotQuantity_Internal_1692629761(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref channel;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_RpcReader___Observers_SetItemSlotQuantity_Internal_1692629761_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005CC7 RID: 23751 RVA: 0x001B17B8 File Offset: 0x001AF9B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 197440, XrefRangeEnd = 197455, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_SetSlotLocked_3170825843(NetworkConnection conn, int itemSlotIndex, bool locked, NetworkObject lockOwner, string lockReason)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)5) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref itemSlotIndex;
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref locked;
			ptr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(lockOwner);
			ptr[checked(unchecked((System.UIntPtr)4) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(lockReason);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_RpcWriter___Server_SetSlotLocked_3170825843_Private_Void_NetworkConnection_Int32_Boolean_NetworkObject_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005CC8 RID: 23752 RVA: 0x001B183C File Offset: 0x001AFA3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 197455, XrefRangeEnd = 197459, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void RpcLogic___SetSlotLocked_3170825843(NetworkConnection conn, int itemSlotIndex, bool locked, NetworkObject lockOwner, string lockReason)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)5) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref itemSlotIndex;
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref locked;
			ptr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(lockOwner);
			ptr[checked(unchecked((System.UIntPtr)4) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(lockReason);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_RpcLogic___SetSlotLocked_3170825843_Public_Virtual_Final_New_Void_NetworkConnection_Int32_Boolean_NetworkObject_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005CC9 RID: 23753 RVA: 0x001B18C0 File Offset: 0x001AFAC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 197459, XrefRangeEnd = 197468, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_SetSlotLocked_3170825843(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref channel;
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_RpcReader___Server_SetSlotLocked_3170825843_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005CCA RID: 23754 RVA: 0x001B1924 File Offset: 0x001AFB24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 197468, XrefRangeEnd = 197482, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Target_SetSlotLocked_Internal_3170825843(NetworkConnection conn, int itemSlotIndex, bool locked, NetworkObject lockOwner, string lockReason)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)5) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref itemSlotIndex;
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref locked;
			ptr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(lockOwner);
			ptr[checked(unchecked((System.UIntPtr)4) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(lockReason);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_RpcWriter___Target_SetSlotLocked_Internal_3170825843_Private_Void_NetworkConnection_Int32_Boolean_NetworkObject_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005CCB RID: 23755 RVA: 0x001B19A8 File Offset: 0x001AFBA8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 197488, RefRangeEnd = 197491, XrefRangeStart = 197482, XrefRangeEnd = 197488, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SetSlotLocked_Internal_3170825843(NetworkConnection conn, int itemSlotIndex, bool locked, NetworkObject lockOwner, string lockReason)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)5) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref itemSlotIndex;
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref locked;
			ptr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(lockOwner);
			ptr[checked(unchecked((System.UIntPtr)4) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(lockReason);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_RpcLogic___SetSlotLocked_Internal_3170825843_Private_Void_NetworkConnection_Int32_Boolean_NetworkObject_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005CCC RID: 23756 RVA: 0x001B1A2C File Offset: 0x001AFC2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 197491, XrefRangeEnd = 197499, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Target_SetSlotLocked_Internal_3170825843(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref channel;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_RpcReader___Target_SetSlotLocked_Internal_3170825843_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005CCD RID: 23757 RVA: 0x001B1A7C File Offset: 0x001AFC7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 197499, XrefRangeEnd = 197513, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_SetSlotLocked_Internal_3170825843(NetworkConnection conn, int itemSlotIndex, bool locked, NetworkObject lockOwner, string lockReason)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)5) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref itemSlotIndex;
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref locked;
			ptr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(lockOwner);
			ptr[checked(unchecked((System.UIntPtr)4) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(lockReason);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_RpcWriter___Observers_SetSlotLocked_Internal_3170825843_Private_Void_NetworkConnection_Int32_Boolean_NetworkObject_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005CCE RID: 23758 RVA: 0x001B1B00 File Offset: 0x001AFD00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 197513, XrefRangeEnd = 197520, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_SetSlotLocked_Internal_3170825843(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref channel;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_RpcReader___Observers_SetSlotLocked_Internal_3170825843_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005CCF RID: 23759 RVA: 0x001B1B50 File Offset: 0x001AFD50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 197520, XrefRangeEnd = 197533, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_SetSlotFilter_527532783(NetworkConnection conn, int itemSlotIndex, SlotFilter filter)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref itemSlotIndex;
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(filter);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_RpcWriter___Server_SetSlotFilter_527532783_Private_Void_NetworkConnection_Int32_SlotFilter_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005CD0 RID: 23760 RVA: 0x001B1BB4 File Offset: 0x001AFDB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 197533, XrefRangeEnd = 197537, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void RpcLogic___SetSlotFilter_527532783(NetworkConnection conn, int itemSlotIndex, SlotFilter filter)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref itemSlotIndex;
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(filter);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_RpcLogic___SetSlotFilter_527532783_Public_Virtual_Final_New_Void_NetworkConnection_Int32_SlotFilter_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005CD1 RID: 23761 RVA: 0x001B1C18 File Offset: 0x001AFE18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 197537, XrefRangeEnd = 197545, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_SetSlotFilter_527532783(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref channel;
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_RpcReader___Server_SetSlotFilter_527532783_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005CD2 RID: 23762 RVA: 0x001B1C7C File Offset: 0x001AFE7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 197545, XrefRangeEnd = 197557, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_SetSlotFilter_Internal_527532783(NetworkConnection conn, int itemSlotIndex, SlotFilter filter)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref itemSlotIndex;
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(filter);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_RpcWriter___Observers_SetSlotFilter_Internal_527532783_Private_Void_NetworkConnection_Int32_SlotFilter_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005CD3 RID: 23763 RVA: 0x001B1CE0 File Offset: 0x001AFEE0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 197562, RefRangeEnd = 197565, XrefRangeStart = 197557, XrefRangeEnd = 197562, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SetSlotFilter_Internal_527532783(NetworkConnection conn, int itemSlotIndex, SlotFilter filter)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref itemSlotIndex;
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(filter);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_RpcLogic___SetSlotFilter_Internal_527532783_Private_Void_NetworkConnection_Int32_SlotFilter_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005CD4 RID: 23764 RVA: 0x001B1D44 File Offset: 0x001AFF44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 197565, XrefRangeEnd = 197571, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_SetSlotFilter_Internal_527532783(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref channel;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_RpcReader___Observers_SetSlotFilter_Internal_527532783_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005CD5 RID: 23765 RVA: 0x001B1D94 File Offset: 0x001AFF94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 197571, XrefRangeEnd = 197583, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Target_SetSlotFilter_Internal_527532783(NetworkConnection conn, int itemSlotIndex, SlotFilter filter)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref itemSlotIndex;
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(filter);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_RpcWriter___Target_SetSlotFilter_Internal_527532783_Private_Void_NetworkConnection_Int32_SlotFilter_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005CD6 RID: 23766 RVA: 0x001B1DF8 File Offset: 0x001AFFF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 197583, XrefRangeEnd = 197590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Target_SetSlotFilter_Internal_527532783(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref channel;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_RpcReader___Target_SetSlotFilter_Internal_527532783_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x17001BD7 RID: 7127
		// (get) Token: 0x06005CD7 RID: 23767 RVA: 0x001B1E48 File Offset: 0x001B0048
		// (set) Token: 0x06005CD8 RID: 23768 RVA: 0x001B1E84 File Offset: 0x001B0084
		public unsafe float SyncAccessor_<Cash>k__BackingField
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 195088, RefRangeEnd = 195090, XrefRangeStart = 195088, XrefRangeEnd = 195090, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_sync___get_value__Cash_k__BackingField_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 197598, RefRangeEnd = 197600, XrefRangeStart = 197590, XrefRangeEnd = 197598, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = ref value;
				ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref value;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_sync___set_value__Cash_k__BackingField_Public_set_Void_Single_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x06005CD9 RID: 23769 RVA: 0x001B1ED0 File Offset: 0x001B00D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 197600, XrefRangeEnd = 197612, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool ReadSyncVar___ScheduleOne_Economy_Dealer(PooledReader PooledReader0, uint UInt321, bool Boolean2)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref UInt321;
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref Boolean2;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Dealer.NativeMethodInfoPtr_ReadSyncVar___ScheduleOne_Economy_Dealer_Public_Virtual_Boolean_PooledReader_UInt32_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x17001BD8 RID: 7128
		// (get) Token: 0x06005CDA RID: 23770 RVA: 0x001B1F44 File Offset: 0x001B0144
		// (set) Token: 0x06005CDB RID: 23771 RVA: 0x001B1F84 File Offset: 0x001B0184
		public unsafe List<string> SyncAccessor_acceptedContractGUIDs
		{
			[CallerCount(8)]
			[CachedScanResults(RefRangeStart = 188282, RefRangeEnd = 188290, XrefRangeStart = 188282, XrefRangeEnd = 188290, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_sync___get_value_acceptedContractGUIDs_Public_get_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 197621, RefRangeEnd = 197622, XrefRangeStart = 197612, XrefRangeEnd = 197621, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref value;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_sync___set_value_acceptedContractGUIDs_Public_set_Void_List_1_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x06005CDC RID: 23772 RVA: 0x001B1FD4 File Offset: 0x001B01D4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 197663, RefRangeEnd = 197664, XrefRangeStart = 197622, XrefRangeEnd = 197663, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Method_Protected_Virtual_Void_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Dealer.NativeMethodInfoPtr_Method_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005CDD RID: 23773 RVA: 0x0002B6B6 File Offset: 0x000298B6
		public Dealer(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001BA4 RID: 7076
		// (get) Token: 0x06005CDE RID: 23774 RVA: 0x001B2010 File Offset: 0x001B0210
		// (set) Token: 0x06005CDF RID: 23775 RVA: 0x0002B6BF File Offset: 0x000298BF
		public unsafe static int MAX_CUSTOMERS
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(Dealer.NativeFieldInfoPtr_MAX_CUSTOMERS, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Dealer.NativeFieldInfoPtr_MAX_CUSTOMERS, (void*)(&value));
			}
		}

		// Token: 0x17001BA5 RID: 7077
		// (get) Token: 0x06005CE0 RID: 23776 RVA: 0x001B202C File Offset: 0x001B022C
		// (set) Token: 0x06005CE1 RID: 23777 RVA: 0x0002B6CD File Offset: 0x000298CD
		public unsafe static int DEAL_ARRIVAL_DELAY
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(Dealer.NativeFieldInfoPtr_DEAL_ARRIVAL_DELAY, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Dealer.NativeFieldInfoPtr_DEAL_ARRIVAL_DELAY, (void*)(&value));
			}
		}

		// Token: 0x17001BA6 RID: 7078
		// (get) Token: 0x06005CE2 RID: 23778 RVA: 0x001B2048 File Offset: 0x001B0248
		// (set) Token: 0x06005CE3 RID: 23779 RVA: 0x0002B6DB File Offset: 0x000298DB
		public unsafe static int MIN_TRAVEL_TIME
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(Dealer.NativeFieldInfoPtr_MIN_TRAVEL_TIME, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Dealer.NativeFieldInfoPtr_MIN_TRAVEL_TIME, (void*)(&value));
			}
		}

		// Token: 0x17001BA7 RID: 7079
		// (get) Token: 0x06005CE4 RID: 23780 RVA: 0x001B2064 File Offset: 0x001B0264
		// (set) Token: 0x06005CE5 RID: 23781 RVA: 0x0002B6E9 File Offset: 0x000298E9
		public unsafe static int MAX_TRAVEL_TIME
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(Dealer.NativeFieldInfoPtr_MAX_TRAVEL_TIME, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Dealer.NativeFieldInfoPtr_MAX_TRAVEL_TIME, (void*)(&value));
			}
		}

		// Token: 0x17001BA8 RID: 7080
		// (get) Token: 0x06005CE6 RID: 23782 RVA: 0x001B2080 File Offset: 0x001B0280
		// (set) Token: 0x06005CE7 RID: 23783 RVA: 0x0002B6F7 File Offset: 0x000298F7
		public unsafe static int OVERFLOW_SLOT_COUNT
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(Dealer.NativeFieldInfoPtr_OVERFLOW_SLOT_COUNT, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Dealer.NativeFieldInfoPtr_OVERFLOW_SLOT_COUNT, (void*)(&value));
			}
		}

		// Token: 0x17001BA9 RID: 7081
		// (get) Token: 0x06005CE8 RID: 23784 RVA: 0x001B209C File Offset: 0x001B029C
		// (set) Token: 0x06005CE9 RID: 23785 RVA: 0x0002B705 File Offset: 0x00029905
		public unsafe static float CASH_REMINDER_THRESHOLD
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(Dealer.NativeFieldInfoPtr_CASH_REMINDER_THRESHOLD, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Dealer.NativeFieldInfoPtr_CASH_REMINDER_THRESHOLD, (void*)(&value));
			}
		}

		// Token: 0x17001BAA RID: 7082
		// (get) Token: 0x06005CEA RID: 23786 RVA: 0x001B20B8 File Offset: 0x001B02B8
		// (set) Token: 0x06005CEB RID: 23787 RVA: 0x0002B713 File Offset: 0x00029913
		public unsafe static float RELATIONSHIP_CHANGE_PER_DEAL
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(Dealer.NativeFieldInfoPtr_RELATIONSHIP_CHANGE_PER_DEAL, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Dealer.NativeFieldInfoPtr_RELATIONSHIP_CHANGE_PER_DEAL, (void*)(&value));
			}
		}

		// Token: 0x17001BAB RID: 7083
		// (get) Token: 0x06005CEC RID: 23788 RVA: 0x001B20D4 File Offset: 0x001B02D4
		// (set) Token: 0x06005CED RID: 23789 RVA: 0x0002B721 File Offset: 0x00029921
		public unsafe static Il2CppSystem.Action<Dealer> onDealerRecruited
		{
			get
			{
				System.IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Dealer.NativeFieldInfoPtr_onDealerRecruited, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Action<Dealer>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Dealer.NativeFieldInfoPtr_onDealerRecruited, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001BAC RID: 7084
		// (get) Token: 0x06005CEE RID: 23790 RVA: 0x001B20FC File Offset: 0x001B02FC
		// (set) Token: 0x06005CEF RID: 23791 RVA: 0x0002B733 File Offset: 0x00029933
		public unsafe static Color32 DealerLabelColor
		{
			get
			{
				Color32 result;
				IL2CPP.il2cpp_field_static_get_value(Dealer.NativeFieldInfoPtr_DealerLabelColor, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Dealer.NativeFieldInfoPtr_DealerLabelColor, (void*)(&value));
			}
		}

		// Token: 0x17001BAD RID: 7085
		// (get) Token: 0x06005CF0 RID: 23792 RVA: 0x001B2118 File Offset: 0x001B0318
		// (set) Token: 0x06005CF1 RID: 23793 RVA: 0x0002B741 File Offset: 0x00029941
		public unsafe static List<Dealer> AllDealers
		{
			get
			{
				System.IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Dealer.NativeFieldInfoPtr_AllDealers, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Dealer>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Dealer.NativeFieldInfoPtr_AllDealers, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001BAE RID: 7086
		// (get) Token: 0x06005CF2 RID: 23794 RVA: 0x001B2140 File Offset: 0x001B0340
		// (set) Token: 0x06005CF3 RID: 23795 RVA: 0x0002B753 File Offset: 0x00029953
		public unsafe bool _IsRecruited_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Dealer.NativeFieldInfoPtr__IsRecruited_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Dealer.NativeFieldInfoPtr__IsRecruited_k__BackingField)) = value;
			}
		}

		// Token: 0x17001BAF RID: 7087
		// (get) Token: 0x06005CF4 RID: 23796 RVA: 0x001B2168 File Offset: 0x001B0368
		// (set) Token: 0x06005CF5 RID: 23797 RVA: 0x0002B76E File Offset: 0x0002996E
		public unsafe List<ItemSlot> _ItemSlots_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Dealer.NativeFieldInfoPtr__ItemSlots_k__BackingField);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ItemSlot>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Dealer.NativeFieldInfoPtr__ItemSlots_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001BB0 RID: 7088
		// (get) Token: 0x06005CF6 RID: 23798 RVA: 0x001B2198 File Offset: 0x001B0398
		// (set) Token: 0x06005CF7 RID: 23799 RVA: 0x0002B78D File Offset: 0x0002998D
		public unsafe List<Customer> InitialCustomers
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Dealer.NativeFieldInfoPtr_InitialCustomers);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Customer>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Dealer.NativeFieldInfoPtr_InitialCustomers), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001BB1 RID: 7089
		// (get) Token: 0x06005CF8 RID: 23800 RVA: 0x001B21C8 File Offset: 0x001B03C8
		// (set) Token: 0x06005CF9 RID: 23801 RVA: 0x0002B7AC File Offset: 0x000299AC
		public unsafe List<ProductDefinition> InitialItems
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Dealer.NativeFieldInfoPtr_InitialItems);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ProductDefinition>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Dealer.NativeFieldInfoPtr_InitialItems), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001BB2 RID: 7090
		// (get) Token: 0x06005CFA RID: 23802 RVA: 0x001B21F8 File Offset: 0x001B03F8
		// (set) Token: 0x06005CFB RID: 23803 RVA: 0x0002B7CB File Offset: 0x000299CB
		public unsafe NPCEnterableBuilding Home
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Dealer.NativeFieldInfoPtr_Home);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NPCEnterableBuilding>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Dealer.NativeFieldInfoPtr_Home), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001BB3 RID: 7091
		// (get) Token: 0x06005CFC RID: 23804 RVA: 0x001B2228 File Offset: 0x001B0428
		// (set) Token: 0x06005CFD RID: 23805 RVA: 0x0002B7EA File Offset: 0x000299EA
		public unsafe NPCSignal_HandleDeal DealSignal
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Dealer.NativeFieldInfoPtr_DealSignal);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NPCSignal_HandleDeal>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Dealer.NativeFieldInfoPtr_DealSignal), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001BB4 RID: 7092
		// (get) Token: 0x06005CFE RID: 23806 RVA: 0x001B2258 File Offset: 0x001B0458
		// (set) Token: 0x06005CFF RID: 23807 RVA: 0x0002B809 File Offset: 0x00029A09
		public unsafe NPCEvent_StayInBuilding HomeEvent
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Dealer.NativeFieldInfoPtr_HomeEvent);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NPCEvent_StayInBuilding>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Dealer.NativeFieldInfoPtr_HomeEvent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001BB5 RID: 7093
		// (get) Token: 0x06005D00 RID: 23808 RVA: 0x001B2288 File Offset: 0x001B0488
		// (set) Token: 0x06005D01 RID: 23809 RVA: 0x0002B828 File Offset: 0x00029A28
		public unsafe DialogueController_Dealer DialogueController
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Dealer.NativeFieldInfoPtr_DialogueController);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DialogueController_Dealer>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Dealer.NativeFieldInfoPtr_DialogueController), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001BB6 RID: 7094
		// (get) Token: 0x06005D02 RID: 23810 RVA: 0x001B22B8 File Offset: 0x001B04B8
		// (set) Token: 0x06005D03 RID: 23811 RVA: 0x0002B847 File Offset: 0x00029A47
		public unsafe DialogueContainer RecruitDialogue
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Dealer.NativeFieldInfoPtr_RecruitDialogue);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DialogueContainer>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Dealer.NativeFieldInfoPtr_RecruitDialogue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001BB7 RID: 7095
		// (get) Token: 0x06005D04 RID: 23812 RVA: 0x001B22E8 File Offset: 0x001B04E8
		// (set) Token: 0x06005D05 RID: 23813 RVA: 0x0002B866 File Offset: 0x00029A66
		public unsafe DialogueContainer CollectCashDialogue
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Dealer.NativeFieldInfoPtr_CollectCashDialogue);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DialogueContainer>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Dealer.NativeFieldInfoPtr_CollectCashDialogue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001BB8 RID: 7096
		// (get) Token: 0x06005D06 RID: 23814 RVA: 0x001B2318 File Offset: 0x001B0518
		// (set) Token: 0x06005D07 RID: 23815 RVA: 0x0002B885 File Offset: 0x00029A85
		public unsafe DialogueContainer AssignCustomersDialogue
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Dealer.NativeFieldInfoPtr_AssignCustomersDialogue);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DialogueContainer>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Dealer.NativeFieldInfoPtr_AssignCustomersDialogue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001BB9 RID: 7097
		// (get) Token: 0x06005D08 RID: 23816 RVA: 0x001B2348 File Offset: 0x001B0548
		// (set) Token: 0x06005D09 RID: 23817 RVA: 0x0002B8A4 File Offset: 0x00029AA4
		public unsafe string HomeName
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Dealer.NativeFieldInfoPtr_HomeName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Dealer.NativeFieldInfoPtr_HomeName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001BBA RID: 7098
		// (get) Token: 0x06005D0A RID: 23818 RVA: 0x001B2370 File Offset: 0x001B0570
		// (set) Token: 0x06005D0B RID: 23819 RVA: 0x0002B8C3 File Offset: 0x00029AC3
		public unsafe float SigningFee
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Dealer.NativeFieldInfoPtr_SigningFee);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Dealer.NativeFieldInfoPtr_SigningFee)) = value;
			}
		}

		// Token: 0x17001BBB RID: 7099
		// (get) Token: 0x06005D0C RID: 23820 RVA: 0x001B2398 File Offset: 0x001B0598
		// (set) Token: 0x06005D0D RID: 23821 RVA: 0x0002B8DE File Offset: 0x00029ADE
		public unsafe float Cut
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Dealer.NativeFieldInfoPtr_Cut);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Dealer.NativeFieldInfoPtr_Cut)) = value;
			}
		}

		// Token: 0x17001BBC RID: 7100
		// (get) Token: 0x06005D0E RID: 23822 RVA: 0x001B23C0 File Offset: 0x001B05C0
		// (set) Token: 0x06005D0F RID: 23823 RVA: 0x0002B8F9 File Offset: 0x00029AF9
		public unsafe bool SellInsufficientQualityItems
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Dealer.NativeFieldInfoPtr_SellInsufficientQualityItems);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Dealer.NativeFieldInfoPtr_SellInsufficientQualityItems)) = value;
			}
		}

		// Token: 0x17001BBD RID: 7101
		// (get) Token: 0x06005D10 RID: 23824 RVA: 0x001B23E8 File Offset: 0x001B05E8
		// (set) Token: 0x06005D11 RID: 23825 RVA: 0x0002B914 File Offset: 0x00029B14
		public unsafe bool SellExcessQualityItems
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Dealer.NativeFieldInfoPtr_SellExcessQualityItems);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Dealer.NativeFieldInfoPtr_SellExcessQualityItems)) = value;
			}
		}

		// Token: 0x17001BBE RID: 7102
		// (get) Token: 0x06005D12 RID: 23826 RVA: 0x001B2410 File Offset: 0x001B0610
		// (set) Token: 0x06005D13 RID: 23827 RVA: 0x0002B92F File Offset: 0x00029B2F
		public unsafe string CompletedDealsVariable
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Dealer.NativeFieldInfoPtr_CompletedDealsVariable);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Dealer.NativeFieldInfoPtr_CompletedDealsVariable), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001BBF RID: 7103
		// (get) Token: 0x06005D14 RID: 23828 RVA: 0x001B2438 File Offset: 0x001B0638
		// (set) Token: 0x06005D15 RID: 23829 RVA: 0x0002B94E File Offset: 0x00029B4E
		public unsafe float _Cash_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Dealer.NativeFieldInfoPtr__Cash_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Dealer.NativeFieldInfoPtr__Cash_k__BackingField)) = value;
			}
		}

		// Token: 0x17001BC0 RID: 7104
		// (get) Token: 0x06005D16 RID: 23830 RVA: 0x001B2460 File Offset: 0x001B0660
		// (set) Token: 0x06005D17 RID: 23831 RVA: 0x0002B969 File Offset: 0x00029B69
		public unsafe List<Customer> AssignedCustomers
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Dealer.NativeFieldInfoPtr_AssignedCustomers);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Customer>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Dealer.NativeFieldInfoPtr_AssignedCustomers), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001BC1 RID: 7105
		// (get) Token: 0x06005D18 RID: 23832 RVA: 0x001B2490 File Offset: 0x001B0690
		// (set) Token: 0x06005D19 RID: 23833 RVA: 0x0002B988 File Offset: 0x00029B88
		public unsafe List<Contract> ActiveContracts
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Dealer.NativeFieldInfoPtr_ActiveContracts);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Contract>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Dealer.NativeFieldInfoPtr_ActiveContracts), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001BC2 RID: 7106
		// (get) Token: 0x06005D1A RID: 23834 RVA: 0x001B24C0 File Offset: 0x001B06C0
		// (set) Token: 0x06005D1B RID: 23835 RVA: 0x0002B9A7 File Offset: 0x00029BA7
		public unsafe bool _HasBeenRecommended_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Dealer.NativeFieldInfoPtr__HasBeenRecommended_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Dealer.NativeFieldInfoPtr__HasBeenRecommended_k__BackingField)) = value;
			}
		}

		// Token: 0x17001BC3 RID: 7107
		// (get) Token: 0x06005D1C RID: 23836 RVA: 0x001B24E8 File Offset: 0x001B06E8
		// (set) Token: 0x06005D1D RID: 23837 RVA: 0x0002B9C2 File Offset: 0x00029BC2
		public unsafe UnityEvent onRecommended
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Dealer.NativeFieldInfoPtr_onRecommended);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Dealer.NativeFieldInfoPtr_onRecommended), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001BC4 RID: 7108
		// (get) Token: 0x06005D1E RID: 23838 RVA: 0x001B2518 File Offset: 0x001B0718
		// (set) Token: 0x06005D1F RID: 23839 RVA: 0x0002B9E1 File Offset: 0x00029BE1
		public unsafe Il2CppReferenceArray<ItemSlot> OverflowSlots
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Dealer.NativeFieldInfoPtr_OverflowSlots);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<ItemSlot>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Dealer.NativeFieldInfoPtr_OverflowSlots), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001BC5 RID: 7109
		// (get) Token: 0x06005D20 RID: 23840 RVA: 0x001B2548 File Offset: 0x001B0748
		// (set) Token: 0x06005D21 RID: 23841 RVA: 0x0002BA00 File Offset: 0x00029C00
		public unsafe Contract currentContract
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Dealer.NativeFieldInfoPtr_currentContract);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Contract>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Dealer.NativeFieldInfoPtr_currentContract), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001BC6 RID: 7110
		// (get) Token: 0x06005D22 RID: 23842 RVA: 0x001B2578 File Offset: 0x001B0778
		// (set) Token: 0x06005D23 RID: 23843 RVA: 0x0002BA1F File Offset: 0x00029C1F
		public unsafe DialogueController.DialogueChoice recruitChoice
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Dealer.NativeFieldInfoPtr_recruitChoice);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DialogueController.DialogueChoice>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Dealer.NativeFieldInfoPtr_recruitChoice), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001BC7 RID: 7111
		// (get) Token: 0x06005D24 RID: 23844 RVA: 0x001B25A8 File Offset: 0x001B07A8
		// (set) Token: 0x06005D25 RID: 23845 RVA: 0x0002BA3E File Offset: 0x00029C3E
		public unsafe DialogueController.DialogueChoice collectCashChoice
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Dealer.NativeFieldInfoPtr_collectCashChoice);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DialogueController.DialogueChoice>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Dealer.NativeFieldInfoPtr_collectCashChoice), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001BC8 RID: 7112
		// (get) Token: 0x06005D26 RID: 23846 RVA: 0x001B25D8 File Offset: 0x001B07D8
		// (set) Token: 0x06005D27 RID: 23847 RVA: 0x0002BA5D File Offset: 0x00029C5D
		public unsafe DialogueController.DialogueChoice assignCustomersChoice
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Dealer.NativeFieldInfoPtr_assignCustomersChoice);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DialogueController.DialogueChoice>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Dealer.NativeFieldInfoPtr_assignCustomersChoice), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001BC9 RID: 7113
		// (get) Token: 0x06005D28 RID: 23848 RVA: 0x001B2608 File Offset: 0x001B0808
		// (set) Token: 0x06005D29 RID: 23849 RVA: 0x0002BA7C File Offset: 0x00029C7C
		public unsafe NPCPoI _potentialDealerPoI_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Dealer.NativeFieldInfoPtr__potentialDealerPoI_k__BackingField);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NPCPoI>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Dealer.NativeFieldInfoPtr__potentialDealerPoI_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001BCA RID: 7114
		// (get) Token: 0x06005D2A RID: 23850 RVA: 0x001B2638 File Offset: 0x001B0838
		// (set) Token: 0x06005D2B RID: 23851 RVA: 0x0002BA9B File Offset: 0x00029C9B
		public unsafe NPCPoI _dealerPoI_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Dealer.NativeFieldInfoPtr__dealerPoI_k__BackingField);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NPCPoI>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Dealer.NativeFieldInfoPtr__dealerPoI_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001BCB RID: 7115
		// (get) Token: 0x06005D2C RID: 23852 RVA: 0x001B2668 File Offset: 0x001B0868
		// (set) Token: 0x06005D2D RID: 23853 RVA: 0x0002BABA File Offset: 0x00029CBA
		public unsafe List<string> acceptedContractGUIDs
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Dealer.NativeFieldInfoPtr_acceptedContractGUIDs);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Dealer.NativeFieldInfoPtr_acceptedContractGUIDs), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001BCC RID: 7116
		// (get) Token: 0x06005D2E RID: 23854 RVA: 0x001B2698 File Offset: 0x001B0898
		// (set) Token: 0x06005D2F RID: 23855 RVA: 0x0002BAD9 File Offset: 0x00029CD9
		public unsafe int itemCountOnTradeStart
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Dealer.NativeFieldInfoPtr_itemCountOnTradeStart);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Dealer.NativeFieldInfoPtr_itemCountOnTradeStart)) = value;
			}
		}

		// Token: 0x17001BCD RID: 7117
		// (get) Token: 0x06005D30 RID: 23856 RVA: 0x001B26C0 File Offset: 0x001B08C0
		// (set) Token: 0x06005D31 RID: 23857 RVA: 0x0002BAF4 File Offset: 0x00029CF4
		public unsafe SyncVar<float> syncVar____Cash_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Dealer.NativeFieldInfoPtr_syncVar____Cash_k__BackingField);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SyncVar<float>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Dealer.NativeFieldInfoPtr_syncVar____Cash_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001BCE RID: 7118
		// (get) Token: 0x06005D32 RID: 23858 RVA: 0x001B26F0 File Offset: 0x001B08F0
		// (set) Token: 0x06005D33 RID: 23859 RVA: 0x0002BB13 File Offset: 0x00029D13
		public unsafe SyncVar<List<string>> syncVar___acceptedContractGUIDs
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Dealer.NativeFieldInfoPtr_syncVar___acceptedContractGUIDs);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SyncVar<List<string>>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Dealer.NativeFieldInfoPtr_syncVar___acceptedContractGUIDs), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001BCF RID: 7119
		// (get) Token: 0x06005D34 RID: 23860 RVA: 0x001B2720 File Offset: 0x001B0920
		// (set) Token: 0x06005D35 RID: 23861 RVA: 0x0002BB32 File Offset: 0x00029D32
		public new unsafe bool field_Private_Boolean_0
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Dealer.NativeFieldInfoPtr_field_Private_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Dealer.NativeFieldInfoPtr_field_Private_Boolean_0)) = value;
			}
		}

		// Token: 0x17001BD0 RID: 7120
		// (get) Token: 0x06005D36 RID: 23862 RVA: 0x001B2748 File Offset: 0x001B0948
		// (set) Token: 0x06005D37 RID: 23863 RVA: 0x0002BB4D File Offset: 0x00029D4D
		public new unsafe bool field_Private_Boolean_1
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Dealer.NativeFieldInfoPtr_field_Private_Boolean_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Dealer.NativeFieldInfoPtr_field_Private_Boolean_1)) = value;
			}
		}

		// Token: 0x04003EFB RID: 16123
		private static readonly System.IntPtr NativeFieldInfoPtr_MAX_CUSTOMERS;

		// Token: 0x04003EFC RID: 16124
		private static readonly System.IntPtr NativeFieldInfoPtr_DEAL_ARRIVAL_DELAY;

		// Token: 0x04003EFD RID: 16125
		private static readonly System.IntPtr NativeFieldInfoPtr_MIN_TRAVEL_TIME;

		// Token: 0x04003EFE RID: 16126
		private static readonly System.IntPtr NativeFieldInfoPtr_MAX_TRAVEL_TIME;

		// Token: 0x04003EFF RID: 16127
		private static readonly System.IntPtr NativeFieldInfoPtr_OVERFLOW_SLOT_COUNT;

		// Token: 0x04003F00 RID: 16128
		private static readonly System.IntPtr NativeFieldInfoPtr_CASH_REMINDER_THRESHOLD;

		// Token: 0x04003F01 RID: 16129
		private static readonly System.IntPtr NativeFieldInfoPtr_RELATIONSHIP_CHANGE_PER_DEAL;

		// Token: 0x04003F02 RID: 16130
		private static readonly System.IntPtr NativeFieldInfoPtr_onDealerRecruited;

		// Token: 0x04003F03 RID: 16131
		private static readonly System.IntPtr NativeFieldInfoPtr_DealerLabelColor;

		// Token: 0x04003F04 RID: 16132
		private static readonly System.IntPtr NativeFieldInfoPtr_AllDealers;

		// Token: 0x04003F05 RID: 16133
		private static readonly System.IntPtr NativeFieldInfoPtr__IsRecruited_k__BackingField;

		// Token: 0x04003F06 RID: 16134
		private static readonly System.IntPtr NativeFieldInfoPtr__ItemSlots_k__BackingField;

		// Token: 0x04003F07 RID: 16135
		private static readonly System.IntPtr NativeFieldInfoPtr_InitialCustomers;

		// Token: 0x04003F08 RID: 16136
		private static readonly System.IntPtr NativeFieldInfoPtr_InitialItems;

		// Token: 0x04003F09 RID: 16137
		private static readonly System.IntPtr NativeFieldInfoPtr_Home;

		// Token: 0x04003F0A RID: 16138
		private static readonly System.IntPtr NativeFieldInfoPtr_DealSignal;

		// Token: 0x04003F0B RID: 16139
		private static readonly System.IntPtr NativeFieldInfoPtr_HomeEvent;

		// Token: 0x04003F0C RID: 16140
		private static readonly System.IntPtr NativeFieldInfoPtr_DialogueController;

		// Token: 0x04003F0D RID: 16141
		private static readonly System.IntPtr NativeFieldInfoPtr_RecruitDialogue;

		// Token: 0x04003F0E RID: 16142
		private static readonly System.IntPtr NativeFieldInfoPtr_CollectCashDialogue;

		// Token: 0x04003F0F RID: 16143
		private static readonly System.IntPtr NativeFieldInfoPtr_AssignCustomersDialogue;

		// Token: 0x04003F10 RID: 16144
		private static readonly System.IntPtr NativeFieldInfoPtr_HomeName;

		// Token: 0x04003F11 RID: 16145
		private static readonly System.IntPtr NativeFieldInfoPtr_SigningFee;

		// Token: 0x04003F12 RID: 16146
		private static readonly System.IntPtr NativeFieldInfoPtr_Cut;

		// Token: 0x04003F13 RID: 16147
		private static readonly System.IntPtr NativeFieldInfoPtr_SellInsufficientQualityItems;

		// Token: 0x04003F14 RID: 16148
		private static readonly System.IntPtr NativeFieldInfoPtr_SellExcessQualityItems;

		// Token: 0x04003F15 RID: 16149
		private static readonly System.IntPtr NativeFieldInfoPtr_CompletedDealsVariable;

		// Token: 0x04003F16 RID: 16150
		private static readonly System.IntPtr NativeFieldInfoPtr__Cash_k__BackingField;

		// Token: 0x04003F17 RID: 16151
		private static readonly System.IntPtr NativeFieldInfoPtr_AssignedCustomers;

		// Token: 0x04003F18 RID: 16152
		private static readonly System.IntPtr NativeFieldInfoPtr_ActiveContracts;

		// Token: 0x04003F19 RID: 16153
		private static readonly System.IntPtr NativeFieldInfoPtr__HasBeenRecommended_k__BackingField;

		// Token: 0x04003F1A RID: 16154
		private static readonly System.IntPtr NativeFieldInfoPtr_onRecommended;

		// Token: 0x04003F1B RID: 16155
		private static readonly System.IntPtr NativeFieldInfoPtr_OverflowSlots;

		// Token: 0x04003F1C RID: 16156
		private static readonly System.IntPtr NativeFieldInfoPtr_currentContract;

		// Token: 0x04003F1D RID: 16157
		private static readonly System.IntPtr NativeFieldInfoPtr_recruitChoice;

		// Token: 0x04003F1E RID: 16158
		private static readonly System.IntPtr NativeFieldInfoPtr_collectCashChoice;

		// Token: 0x04003F1F RID: 16159
		private static readonly System.IntPtr NativeFieldInfoPtr_assignCustomersChoice;

		// Token: 0x04003F20 RID: 16160
		private static readonly System.IntPtr NativeFieldInfoPtr__potentialDealerPoI_k__BackingField;

		// Token: 0x04003F21 RID: 16161
		private static readonly System.IntPtr NativeFieldInfoPtr__dealerPoI_k__BackingField;

		// Token: 0x04003F22 RID: 16162
		private static readonly System.IntPtr NativeFieldInfoPtr_acceptedContractGUIDs;

		// Token: 0x04003F23 RID: 16163
		private static readonly System.IntPtr NativeFieldInfoPtr_itemCountOnTradeStart;

		// Token: 0x04003F24 RID: 16164
		private static readonly System.IntPtr NativeFieldInfoPtr_syncVar____Cash_k__BackingField;

		// Token: 0x04003F25 RID: 16165
		private static readonly System.IntPtr NativeFieldInfoPtr_syncVar___acceptedContractGUIDs;

		// Token: 0x04003F26 RID: 16166
		private static readonly System.IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

		// Token: 0x04003F27 RID: 16167
		private static readonly System.IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

		// Token: 0x04003F28 RID: 16168
		private static readonly System.IntPtr NativeMethodInfoPtr_get_IsRecruited_Public_get_Boolean_0;

		// Token: 0x04003F29 RID: 16169
		private static readonly System.IntPtr NativeMethodInfoPtr_set_IsRecruited_Private_set_Void_Boolean_0;

		// Token: 0x04003F2A RID: 16170
		private static readonly System.IntPtr NativeMethodInfoPtr_get_ItemSlots_Public_Virtual_Final_New_get_List_1_ItemSlot_0;

		// Token: 0x04003F2B RID: 16171
		private static readonly System.IntPtr NativeMethodInfoPtr_set_ItemSlots_Public_Virtual_Final_New_set_Void_List_1_ItemSlot_0;

		// Token: 0x04003F2C RID: 16172
		private static readonly System.IntPtr NativeMethodInfoPtr_get_Cash_Public_get_Single_0;

		// Token: 0x04003F2D RID: 16173
		private static readonly System.IntPtr NativeMethodInfoPtr_set_Cash_Private_set_Void_Single_0;

		// Token: 0x04003F2E RID: 16174
		private static readonly System.IntPtr NativeMethodInfoPtr_get_HasBeenRecommended_Public_get_Boolean_0;

		// Token: 0x04003F2F RID: 16175
		private static readonly System.IntPtr NativeMethodInfoPtr_set_HasBeenRecommended_Private_set_Void_Boolean_0;

		// Token: 0x04003F30 RID: 16176
		private static readonly System.IntPtr NativeMethodInfoPtr_get_potentialDealerPoI_Public_get_NPCPoI_0;

		// Token: 0x04003F31 RID: 16177
		private static readonly System.IntPtr NativeMethodInfoPtr_set_potentialDealerPoI_Protected_set_Void_NPCPoI_0;

		// Token: 0x04003F32 RID: 16178
		private static readonly System.IntPtr NativeMethodInfoPtr_get_dealerPoI_Public_get_NPCPoI_0;

		// Token: 0x04003F33 RID: 16179
		private static readonly System.IntPtr NativeMethodInfoPtr_set_dealerPoI_Protected_set_Void_NPCPoI_0;

		// Token: 0x04003F34 RID: 16180
		private static readonly System.IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;

		// Token: 0x04003F35 RID: 16181
		private static readonly System.IntPtr NativeMethodInfoPtr_OnValidate_Protected_Virtual_Void_1;

		// Token: 0x04003F36 RID: 16182
		private static readonly System.IntPtr NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_1;

		// Token: 0x04003F37 RID: 16183
		private static readonly System.IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_1;

		// Token: 0x04003F38 RID: 16184
		private static readonly System.IntPtr NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0;

		// Token: 0x04003F39 RID: 16185
		private static readonly System.IntPtr NativeMethodInfoPtr_SetupPoI_Private_Void_0;

		// Token: 0x04003F3A RID: 16186
		private static readonly System.IntPtr NativeMethodInfoPtr_SetUpDialogue_Private_Void_0;

		// Token: 0x04003F3B RID: 16187
		private static readonly System.IntPtr NativeMethodInfoPtr_MinPass_Protected_Virtual_Void_1;

		// Token: 0x04003F3C RID: 16188
		private static readonly System.IntPtr NativeMethodInfoPtr_MarkAsRecommended_Public_Void_0;

		// Token: 0x04003F3D RID: 16189
		private static readonly System.IntPtr NativeMethodInfoPtr_SetRecommended_Private_Void_0;

		// Token: 0x04003F3E RID: 16190
		private static readonly System.IntPtr NativeMethodInfoPtr_InitialRecruitment_Public_Void_0;

		// Token: 0x04003F3F RID: 16191
		private static readonly System.IntPtr NativeMethodInfoPtr_SetIsRecruited_Public_Virtual_New_Void_NetworkConnection_0;

		// Token: 0x04003F40 RID: 16192
		private static readonly System.IntPtr NativeMethodInfoPtr_OnDealerUnlocked_Protected_Virtual_New_Void_EUnlockType_Boolean_0;

		// Token: 0x04003F41 RID: 16193
		private static readonly System.IntPtr NativeMethodInfoPtr_UpdatePotentialDealerPoI_Protected_Virtual_New_Void_0;

		// Token: 0x04003F42 RID: 16194
		private static readonly System.IntPtr NativeMethodInfoPtr_TradeItems_Private_Void_0;

		// Token: 0x04003F43 RID: 16195
		private static readonly System.IntPtr NativeMethodInfoPtr_TradeItemsDone_Private_Void_0;

		// Token: 0x04003F44 RID: 16196
		private static readonly System.IntPtr NativeMethodInfoPtr_CanCollectCash_Private_Boolean_byref_String_0;

		// Token: 0x04003F45 RID: 16197
		private static readonly System.IntPtr NativeMethodInfoPtr_UpdateCollectCashChoice_Private_Void_Single_Single_Boolean_0;

		// Token: 0x04003F46 RID: 16198
		private static readonly System.IntPtr NativeMethodInfoPtr_CollectCash_Private_Void_0;

		// Token: 0x04003F47 RID: 16199
		private static readonly System.IntPtr NativeMethodInfoPtr_UpdateCurrentDeal_Private_Void_0;

		// Token: 0x04003F48 RID: 16200
		private static readonly System.IntPtr NativeMethodInfoPtr_CanOfferRecruitment_Private_Boolean_byref_String_0;

		// Token: 0x04003F49 RID: 16201
		private static readonly System.IntPtr NativeMethodInfoPtr_CheckAttendStart_Private_Void_0;

		// Token: 0x04003F4A RID: 16202
		private static readonly System.IntPtr NativeMethodInfoPtr_ShouldAcceptContract_Public_Virtual_New_Boolean_ContractInfo_Customer_0;

		// Token: 0x04003F4B RID: 16203
		private static readonly System.IntPtr NativeMethodInfoPtr_ContractedOffered_Public_Virtual_New_Void_ContractInfo_Customer_0;

		// Token: 0x04003F4C RID: 16204
		private static readonly System.IntPtr NativeMethodInfoPtr_SendAddCustomer_Public_Void_String_0;

		// Token: 0x04003F4D RID: 16205
		private static readonly System.IntPtr NativeMethodInfoPtr_AddCustomer_Private_Void_NetworkConnection_String_0;

		// Token: 0x04003F4E RID: 16206
		private static readonly System.IntPtr NativeMethodInfoPtr_AddCustomer_Protected_Virtual_New_Void_Customer_0;

		// Token: 0x04003F4F RID: 16207
		private static readonly System.IntPtr NativeMethodInfoPtr_SendRemoveCustomer_Public_Void_String_0;

		// Token: 0x04003F50 RID: 16208
		private static readonly System.IntPtr NativeMethodInfoPtr_RemoveCustomer_Private_Void_String_0;

		// Token: 0x04003F51 RID: 16209
		private static readonly System.IntPtr NativeMethodInfoPtr_RemoveCustomer_Public_Virtual_New_Void_Customer_0;

		// Token: 0x04003F52 RID: 16210
		private static readonly System.IntPtr NativeMethodInfoPtr_ChangeCash_Public_Void_Single_0;

		// Token: 0x04003F53 RID: 16211
		private static readonly System.IntPtr NativeMethodInfoPtr_SetCash_Public_Void_Single_0;

		// Token: 0x04003F54 RID: 16212
		private static readonly System.IntPtr NativeMethodInfoPtr_CompletedDeal_Public_Virtual_New_Void_0;

		// Token: 0x04003F55 RID: 16213
		private static readonly System.IntPtr NativeMethodInfoPtr_SubmitPayment_Public_Void_Single_0;

		// Token: 0x04003F56 RID: 16214
		private static readonly System.IntPtr NativeMethodInfoPtr_GetOrderableProducts_Public_List_1_ProductDefinition_0;

		// Token: 0x04003F57 RID: 16215
		private static readonly System.IntPtr NativeMethodInfoPtr_GetProductCount_Public_Int32_String_EQuality_EQuality_0;

		// Token: 0x04003F58 RID: 16216
		private static readonly System.IntPtr NativeMethodInfoPtr_GetDealWindow_Private_EDealWindow_0;

		// Token: 0x04003F59 RID: 16217
		private static readonly System.IntPtr NativeMethodInfoPtr_GetContractCountInWindow_Private_Int32_EDealWindow_0;

		// Token: 0x04003F5A RID: 16218
		private static readonly System.IntPtr NativeMethodInfoPtr_CustomerContractStarted_Private_Void_Contract_0;

		// Token: 0x04003F5B RID: 16219
		private static readonly System.IntPtr NativeMethodInfoPtr_CustomerContractEnded_Private_Void_Contract_0;

		// Token: 0x04003F5C RID: 16220
		private static readonly System.IntPtr NativeMethodInfoPtr_SortContracts_Private_Void_0;

		// Token: 0x04003F5D RID: 16221
		private static readonly System.IntPtr NativeMethodInfoPtr_RecruitmentRequested_Protected_Virtual_New_Void_0;

		// Token: 0x04003F5E RID: 16222
		private static readonly System.IntPtr NativeMethodInfoPtr_RemoveContractItems_Public_Boolean_Contract_EQuality_byref_List_1_ItemInstance_0;

		// Token: 0x04003F5F RID: 16223
		private static readonly System.IntPtr NativeMethodInfoPtr_GetItems_Private_List_1_ItemInstance_String_Int32_Func_2_ProductItemInstance_Boolean_byref_Int32_0;

		// Token: 0x04003F60 RID: 16224
		private static readonly System.IntPtr NativeMethodInfoPtr_GetAllSlots_Public_List_1_ItemSlot_0;

		// Token: 0x04003F61 RID: 16225
		private static readonly System.IntPtr NativeMethodInfoPtr_AddItemToInventory_Public_Void_ItemInstance_0;

		// Token: 0x04003F62 RID: 16226
		private static readonly System.IntPtr NativeMethodInfoPtr_TryMoveOverflowItems_Public_Void_0;

		// Token: 0x04003F63 RID: 16227
		private static readonly System.IntPtr NativeMethodInfoPtr_GetTotalInventoryItemCount_Public_Int32_0;

		// Token: 0x04003F64 RID: 16228
		private static readonly System.IntPtr NativeMethodInfoPtr_SetStoredInstance_Public_Virtual_Final_New_Void_NetworkConnection_Int32_ItemInstance_0;

		// Token: 0x04003F65 RID: 16229
		private static readonly System.IntPtr NativeMethodInfoPtr_SetStoredInstance_Internal_Private_Void_NetworkConnection_Int32_ItemInstance_0;

		// Token: 0x04003F66 RID: 16230
		private static readonly System.IntPtr NativeMethodInfoPtr_SetItemSlotQuantity_Public_Virtual_Final_New_Void_Int32_Int32_0;

		// Token: 0x04003F67 RID: 16231
		private static readonly System.IntPtr NativeMethodInfoPtr_SetItemSlotQuantity_Internal_Private_Void_Int32_Int32_0;

		// Token: 0x04003F68 RID: 16232
		private static readonly System.IntPtr NativeMethodInfoPtr_SetSlotLocked_Public_Virtual_Final_New_Void_NetworkConnection_Int32_Boolean_NetworkObject_String_0;

		// Token: 0x04003F69 RID: 16233
		private static readonly System.IntPtr NativeMethodInfoPtr_SetSlotLocked_Internal_Private_Void_NetworkConnection_Int32_Boolean_NetworkObject_String_0;

		// Token: 0x04003F6A RID: 16234
		private static readonly System.IntPtr NativeMethodInfoPtr_SetSlotFilter_Public_Virtual_Final_New_Void_NetworkConnection_Int32_SlotFilter_0;

		// Token: 0x04003F6B RID: 16235
		private static readonly System.IntPtr NativeMethodInfoPtr_SetSlotFilter_Internal_Private_Void_NetworkConnection_Int32_SlotFilter_0;

		// Token: 0x04003F6C RID: 16236
		private static readonly System.IntPtr NativeMethodInfoPtr_GetNPCData_Public_Virtual_NPCData_0;

		// Token: 0x04003F6D RID: 16237
		private static readonly System.IntPtr NativeMethodInfoPtr_Load_Public_Virtual_Void_DynamicSaveData_NPCData_0;

		// Token: 0x04003F6E RID: 16238
		private static readonly System.IntPtr NativeMethodInfoPtr_Load_Public_Virtual_Void_NPCData_String_0;

		// Token: 0x04003F6F RID: 16239
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04003F70 RID: 16240
		private static readonly System.IntPtr NativeMethodInfoPtr__Awake_b__59_0_Private_Void_EUnlockType_Boolean_0;

		// Token: 0x04003F71 RID: 16241
		private static readonly System.IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

		// Token: 0x04003F72 RID: 16242
		private static readonly System.IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

		// Token: 0x04003F73 RID: 16243
		private static readonly System.IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

		// Token: 0x04003F74 RID: 16244
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcWriter___Server_MarkAsRecommended_2166136261_Private_Void_0;

		// Token: 0x04003F75 RID: 16245
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcLogic___MarkAsRecommended_2166136261_Public_Void_0;

		// Token: 0x04003F76 RID: 16246
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcReader___Server_MarkAsRecommended_2166136261_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x04003F77 RID: 16247
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcWriter___Observers_SetRecommended_2166136261_Private_Void_0;

		// Token: 0x04003F78 RID: 16248
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcLogic___SetRecommended_2166136261_Private_Void_0;

		// Token: 0x04003F79 RID: 16249
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcReader___Observers_SetRecommended_2166136261_Private_Void_PooledReader_Channel_0;

		// Token: 0x04003F7A RID: 16250
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcWriter___Server_InitialRecruitment_2166136261_Private_Void_0;

		// Token: 0x04003F7B RID: 16251
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcLogic___InitialRecruitment_2166136261_Public_Void_0;

		// Token: 0x04003F7C RID: 16252
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcReader___Server_InitialRecruitment_2166136261_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x04003F7D RID: 16253
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcWriter___Observers_SetIsRecruited_328543758_Private_Void_NetworkConnection_0;

		// Token: 0x04003F7E RID: 16254
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcLogic___SetIsRecruited_328543758_Public_Virtual_New_Void_NetworkConnection_0;

		// Token: 0x04003F7F RID: 16255
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcReader___Observers_SetIsRecruited_328543758_Private_Void_PooledReader_Channel_0;

		// Token: 0x04003F80 RID: 16256
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcWriter___Target_SetIsRecruited_328543758_Private_Void_NetworkConnection_0;

		// Token: 0x04003F81 RID: 16257
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcReader___Target_SetIsRecruited_328543758_Private_Void_PooledReader_Channel_0;

		// Token: 0x04003F82 RID: 16258
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcWriter___Server_SendAddCustomer_3615296227_Private_Void_String_0;

		// Token: 0x04003F83 RID: 16259
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcLogic___SendAddCustomer_3615296227_Public_Void_String_0;

		// Token: 0x04003F84 RID: 16260
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcReader___Server_SendAddCustomer_3615296227_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x04003F85 RID: 16261
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcWriter___Observers_AddCustomer_2971853958_Private_Void_NetworkConnection_String_0;

		// Token: 0x04003F86 RID: 16262
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcLogic___AddCustomer_2971853958_Private_Void_NetworkConnection_String_0;

		// Token: 0x04003F87 RID: 16263
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcReader___Observers_AddCustomer_2971853958_Private_Void_PooledReader_Channel_0;

		// Token: 0x04003F88 RID: 16264
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcWriter___Target_AddCustomer_2971853958_Private_Void_NetworkConnection_String_0;

		// Token: 0x04003F89 RID: 16265
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcReader___Target_AddCustomer_2971853958_Private_Void_PooledReader_Channel_0;

		// Token: 0x04003F8A RID: 16266
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcWriter___Server_SendRemoveCustomer_3615296227_Private_Void_String_0;

		// Token: 0x04003F8B RID: 16267
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcLogic___SendRemoveCustomer_3615296227_Public_Void_String_0;

		// Token: 0x04003F8C RID: 16268
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcReader___Server_SendRemoveCustomer_3615296227_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x04003F8D RID: 16269
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcWriter___Observers_RemoveCustomer_3615296227_Private_Void_String_0;

		// Token: 0x04003F8E RID: 16270
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcLogic___RemoveCustomer_3615296227_Private_Void_String_0;

		// Token: 0x04003F8F RID: 16271
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcReader___Observers_RemoveCustomer_3615296227_Private_Void_PooledReader_Channel_0;

		// Token: 0x04003F90 RID: 16272
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcWriter___Server_SetCash_431000436_Private_Void_Single_0;

		// Token: 0x04003F91 RID: 16273
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcLogic___SetCash_431000436_Public_Void_Single_0;

		// Token: 0x04003F92 RID: 16274
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcReader___Server_SetCash_431000436_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x04003F93 RID: 16275
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcWriter___Server_CompletedDeal_2166136261_Private_Void_0;

		// Token: 0x04003F94 RID: 16276
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcLogic___CompletedDeal_2166136261_Public_Virtual_New_Void_0;

		// Token: 0x04003F95 RID: 16277
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcReader___Server_CompletedDeal_2166136261_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x04003F96 RID: 16278
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcWriter___Server_SubmitPayment_431000436_Private_Void_Single_0;

		// Token: 0x04003F97 RID: 16279
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcLogic___SubmitPayment_431000436_Public_Void_Single_0;

		// Token: 0x04003F98 RID: 16280
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcReader___Server_SubmitPayment_431000436_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x04003F99 RID: 16281
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcWriter___Server_SetStoredInstance_2652194801_Private_Void_NetworkConnection_Int32_ItemInstance_0;

		// Token: 0x04003F9A RID: 16282
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcLogic___SetStoredInstance_2652194801_Public_Virtual_Final_New_Void_NetworkConnection_Int32_ItemInstance_0;

		// Token: 0x04003F9B RID: 16283
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcReader___Server_SetStoredInstance_2652194801_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x04003F9C RID: 16284
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcWriter___Observers_SetStoredInstance_Internal_2652194801_Private_Void_NetworkConnection_Int32_ItemInstance_0;

		// Token: 0x04003F9D RID: 16285
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcLogic___SetStoredInstance_Internal_2652194801_Private_Void_NetworkConnection_Int32_ItemInstance_0;

		// Token: 0x04003F9E RID: 16286
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcReader___Observers_SetStoredInstance_Internal_2652194801_Private_Void_PooledReader_Channel_0;

		// Token: 0x04003F9F RID: 16287
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcWriter___Target_SetStoredInstance_Internal_2652194801_Private_Void_NetworkConnection_Int32_ItemInstance_0;

		// Token: 0x04003FA0 RID: 16288
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcReader___Target_SetStoredInstance_Internal_2652194801_Private_Void_PooledReader_Channel_0;

		// Token: 0x04003FA1 RID: 16289
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcWriter___Server_SetItemSlotQuantity_1692629761_Private_Void_Int32_Int32_0;

		// Token: 0x04003FA2 RID: 16290
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcLogic___SetItemSlotQuantity_1692629761_Public_Virtual_Final_New_Void_Int32_Int32_0;

		// Token: 0x04003FA3 RID: 16291
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcReader___Server_SetItemSlotQuantity_1692629761_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x04003FA4 RID: 16292
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcWriter___Observers_SetItemSlotQuantity_Internal_1692629761_Private_Void_Int32_Int32_0;

		// Token: 0x04003FA5 RID: 16293
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcLogic___SetItemSlotQuantity_Internal_1692629761_Private_Void_Int32_Int32_0;

		// Token: 0x04003FA6 RID: 16294
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcReader___Observers_SetItemSlotQuantity_Internal_1692629761_Private_Void_PooledReader_Channel_0;

		// Token: 0x04003FA7 RID: 16295
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcWriter___Server_SetSlotLocked_3170825843_Private_Void_NetworkConnection_Int32_Boolean_NetworkObject_String_0;

		// Token: 0x04003FA8 RID: 16296
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcLogic___SetSlotLocked_3170825843_Public_Virtual_Final_New_Void_NetworkConnection_Int32_Boolean_NetworkObject_String_0;

		// Token: 0x04003FA9 RID: 16297
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcReader___Server_SetSlotLocked_3170825843_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x04003FAA RID: 16298
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcWriter___Target_SetSlotLocked_Internal_3170825843_Private_Void_NetworkConnection_Int32_Boolean_NetworkObject_String_0;

		// Token: 0x04003FAB RID: 16299
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcLogic___SetSlotLocked_Internal_3170825843_Private_Void_NetworkConnection_Int32_Boolean_NetworkObject_String_0;

		// Token: 0x04003FAC RID: 16300
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcReader___Target_SetSlotLocked_Internal_3170825843_Private_Void_PooledReader_Channel_0;

		// Token: 0x04003FAD RID: 16301
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcWriter___Observers_SetSlotLocked_Internal_3170825843_Private_Void_NetworkConnection_Int32_Boolean_NetworkObject_String_0;

		// Token: 0x04003FAE RID: 16302
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcReader___Observers_SetSlotLocked_Internal_3170825843_Private_Void_PooledReader_Channel_0;

		// Token: 0x04003FAF RID: 16303
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcWriter___Server_SetSlotFilter_527532783_Private_Void_NetworkConnection_Int32_SlotFilter_0;

		// Token: 0x04003FB0 RID: 16304
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcLogic___SetSlotFilter_527532783_Public_Virtual_Final_New_Void_NetworkConnection_Int32_SlotFilter_0;

		// Token: 0x04003FB1 RID: 16305
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcReader___Server_SetSlotFilter_527532783_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x04003FB2 RID: 16306
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcWriter___Observers_SetSlotFilter_Internal_527532783_Private_Void_NetworkConnection_Int32_SlotFilter_0;

		// Token: 0x04003FB3 RID: 16307
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcLogic___SetSlotFilter_Internal_527532783_Private_Void_NetworkConnection_Int32_SlotFilter_0;

		// Token: 0x04003FB4 RID: 16308
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcReader___Observers_SetSlotFilter_Internal_527532783_Private_Void_PooledReader_Channel_0;

		// Token: 0x04003FB5 RID: 16309
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcWriter___Target_SetSlotFilter_Internal_527532783_Private_Void_NetworkConnection_Int32_SlotFilter_0;

		// Token: 0x04003FB6 RID: 16310
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcReader___Target_SetSlotFilter_Internal_527532783_Private_Void_PooledReader_Channel_0;

		// Token: 0x04003FB7 RID: 16311
		private static readonly System.IntPtr NativeMethodInfoPtr_sync___get_value__Cash_k__BackingField_Public_get_Single_0;

		// Token: 0x04003FB8 RID: 16312
		private static readonly System.IntPtr NativeMethodInfoPtr_sync___set_value__Cash_k__BackingField_Public_set_Void_Single_Boolean_0;

		// Token: 0x04003FB9 RID: 16313
		private static readonly System.IntPtr NativeMethodInfoPtr_ReadSyncVar___ScheduleOne_Economy_Dealer_Public_Virtual_Boolean_PooledReader_UInt32_Boolean_0;

		// Token: 0x04003FBA RID: 16314
		private static readonly System.IntPtr NativeMethodInfoPtr_sync___get_value_acceptedContractGUIDs_Public_get_List_1_String_0;

		// Token: 0x04003FBB RID: 16315
		private static readonly System.IntPtr NativeMethodInfoPtr_sync___set_value_acceptedContractGUIDs_Public_set_Void_List_1_String_Boolean_0;

		// Token: 0x04003FBC RID: 16316
		private static readonly System.IntPtr NativeMethodInfoPtr_Method_Protected_Virtual_Void_0;

		// Token: 0x02000A31 RID: 2609
		[ObfuscatedName("ScheduleOne.Economy.Dealer+<>c")]
		[System.Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x0600D273 RID: 53875 RVA: 0x0032D0F4 File Offset: 0x0032B2F4
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<Dealer.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Dealer>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Dealer.__c>.NativeClassPtr);
				Dealer.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dealer.__c>.NativeClassPtr, "<>9");
				Dealer.__c.NativeFieldInfoPtr___9__99_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dealer.__c>.NativeClassPtr, "<>9__99_0");
				Dealer.__c.NativeFieldInfoPtr___9__102_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dealer.__c>.NativeClassPtr, "<>9__102_0");
				Dealer.__c.NativeFieldInfoPtr___9__102_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dealer.__c>.NativeClassPtr, "<>9__102_1");
				Dealer.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer.__c>.NativeClassPtr, 100675274);
				Dealer.__c.NativeMethodInfoPtr__SortContracts_b__99_0_Internal_Int32_Contract_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer.__c>.NativeClassPtr, 100675275);
				Dealer.__c.NativeMethodInfoPtr__GetItems_b__102_0_Internal_Int32_ItemSlot_ItemSlot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer.__c>.NativeClassPtr, 100675276);
				Dealer.__c.NativeMethodInfoPtr__GetItems_b__102_1_Internal_Int32_ItemSlot_ItemSlot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer.__c>.NativeClassPtr, 100675277);
			}

			// Token: 0x0600D274 RID: 53876 RVA: 0x0032D1C0 File Offset: 0x0032B3C0
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Dealer.__c>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600D275 RID: 53877 RVA: 0x0032D1FC File Offset: 0x0032B3FC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 195055, XrefRangeEnd = 195057, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _SortContracts_b__99_0(Contract x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Dealer.__c.NativeMethodInfoPtr__SortContracts_b__99_0_Internal_Int32_Contract_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x0600D276 RID: 53878 RVA: 0x0032D24C File Offset: 0x0032B44C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 195057, XrefRangeEnd = 195063, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _GetItems_b__102_0(ItemSlot x, ItemSlot y)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(y);
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Dealer.__c.NativeMethodInfoPtr__GetItems_b__102_0_Internal_Int32_ItemSlot_ItemSlot_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x0600D277 RID: 53879 RVA: 0x0032D2AC File Offset: 0x0032B4AC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 195063, XrefRangeEnd = 195069, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _GetItems_b__102_1(ItemSlot x, ItemSlot y)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(y);
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Dealer.__c.NativeMethodInfoPtr__GetItems_b__102_1_Internal_Int32_ItemSlot_ItemSlot_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x0600D278 RID: 53880 RVA: 0x0006609F File Offset: 0x0006429F
			public __c(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004132 RID: 16690
			// (get) Token: 0x0600D279 RID: 53881 RVA: 0x0032D30C File Offset: 0x0032B50C
			// (set) Token: 0x0600D27A RID: 53882 RVA: 0x000660A8 File Offset: 0x000642A8
			public unsafe static Dealer.__c __9
			{
				get
				{
					System.IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Dealer.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dealer.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Dealer.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004133 RID: 16691
			// (get) Token: 0x0600D27B RID: 53883 RVA: 0x0032D334 File Offset: 0x0032B534
			// (set) Token: 0x0600D27C RID: 53884 RVA: 0x000660BA File Offset: 0x000642BA
			public unsafe static Il2CppSystem.Func<Contract, int> __9__99_0
			{
				get
				{
					System.IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Dealer.__c.NativeFieldInfoPtr___9__99_0, (void*)(&intPtr));
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Func<Contract, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Dealer.__c.NativeFieldInfoPtr___9__99_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004134 RID: 16692
			// (get) Token: 0x0600D27D RID: 53885 RVA: 0x0032D35C File Offset: 0x0032B55C
			// (set) Token: 0x0600D27E RID: 53886 RVA: 0x000660CC File Offset: 0x000642CC
			public unsafe static Il2CppSystem.Comparison<ItemSlot> __9__102_0
			{
				get
				{
					System.IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Dealer.__c.NativeFieldInfoPtr___9__102_0, (void*)(&intPtr));
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Comparison<ItemSlot>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Dealer.__c.NativeFieldInfoPtr___9__102_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004135 RID: 16693
			// (get) Token: 0x0600D27F RID: 53887 RVA: 0x0032D384 File Offset: 0x0032B584
			// (set) Token: 0x0600D280 RID: 53888 RVA: 0x000660DE File Offset: 0x000642DE
			public unsafe static Il2CppSystem.Comparison<ItemSlot> __9__102_1
			{
				get
				{
					System.IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Dealer.__c.NativeFieldInfoPtr___9__102_1, (void*)(&intPtr));
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Comparison<ItemSlot>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Dealer.__c.NativeFieldInfoPtr___9__102_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008E3A RID: 36410
			private static readonly System.IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04008E3B RID: 36411
			private static readonly System.IntPtr NativeFieldInfoPtr___9__99_0;

			// Token: 0x04008E3C RID: 36412
			private static readonly System.IntPtr NativeFieldInfoPtr___9__102_0;

			// Token: 0x04008E3D RID: 36413
			private static readonly System.IntPtr NativeFieldInfoPtr___9__102_1;

			// Token: 0x04008E3E RID: 36414
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008E3F RID: 36415
			private static readonly System.IntPtr NativeMethodInfoPtr__SortContracts_b__99_0_Internal_Int32_Contract_0;

			// Token: 0x04008E40 RID: 36416
			private static readonly System.IntPtr NativeMethodInfoPtr__GetItems_b__102_0_Internal_Int32_ItemSlot_ItemSlot_0;

			// Token: 0x04008E41 RID: 36417
			private static readonly System.IntPtr NativeMethodInfoPtr__GetItems_b__102_1_Internal_Int32_ItemSlot_ItemSlot_0;
		}

		// Token: 0x02000A32 RID: 2610
		[ObfuscatedName("ScheduleOne.Economy.Dealer+<>c__DisplayClass101_0")]
		public sealed class __c__DisplayClass101_0 : Il2CppSystem.Object
		{
			// Token: 0x0600D281 RID: 53889 RVA: 0x0032D3AC File Offset: 0x0032B5AC
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass101_0()
			{
				Il2CppClassPointerStore<Dealer.__c__DisplayClass101_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Dealer>.NativeClassPtr, "<>c__DisplayClass101_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Dealer.__c__DisplayClass101_0>.NativeClassPtr);
				Dealer.__c__DisplayClass101_0.NativeFieldInfoPtr_targetQuality = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dealer.__c__DisplayClass101_0>.NativeClassPtr, "targetQuality");
				Dealer.__c__DisplayClass101_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dealer.__c__DisplayClass101_0>.NativeClassPtr, "<>4__this");
				Dealer.__c__DisplayClass101_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer.__c__DisplayClass101_0>.NativeClassPtr, 100675278);
				Dealer.__c__DisplayClass101_0.NativeMethodInfoPtr_Method_Internal_Boolean_ProductItemInstance_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer.__c__DisplayClass101_0>.NativeClassPtr, 100675279);
			}

			// Token: 0x0600D282 RID: 53890 RVA: 0x0032D428 File Offset: 0x0032B628
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass101_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Dealer.__c__DisplayClass101_0>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.__c__DisplayClass101_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600D283 RID: 53891 RVA: 0x0032D464 File Offset: 0x0032B664
			[CallerCount(0)]
			public unsafe bool Method_Internal_Boolean_ProductItemInstance_PDM_0(ProductItemInstance product)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(product);
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Dealer.__c__DisplayClass101_0.NativeMethodInfoPtr_Method_Internal_Boolean_ProductItemInstance_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x0600D284 RID: 53892 RVA: 0x000660F0 File Offset: 0x000642F0
			public __c__DisplayClass101_0(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004136 RID: 16694
			// (get) Token: 0x0600D285 RID: 53893 RVA: 0x0032D4B4 File Offset: 0x0032B6B4
			// (set) Token: 0x0600D286 RID: 53894 RVA: 0x000660F9 File Offset: 0x000642F9
			public unsafe EQuality targetQuality
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Dealer.__c__DisplayClass101_0.NativeFieldInfoPtr_targetQuality);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Dealer.__c__DisplayClass101_0.NativeFieldInfoPtr_targetQuality)) = value;
				}
			}

			// Token: 0x17004137 RID: 16695
			// (get) Token: 0x0600D287 RID: 53895 RVA: 0x0032D4DC File Offset: 0x0032B6DC
			// (set) Token: 0x0600D288 RID: 53896 RVA: 0x00066114 File Offset: 0x00064314
			public unsafe Dealer __4__this
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Dealer.__c__DisplayClass101_0.NativeFieldInfoPtr___4__this);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dealer>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Dealer.__c__DisplayClass101_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008E42 RID: 36418
			private static readonly System.IntPtr NativeFieldInfoPtr_targetQuality;

			// Token: 0x04008E43 RID: 36419
			private static readonly System.IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04008E44 RID: 36420
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008E45 RID: 36421
			private static readonly System.IntPtr NativeMethodInfoPtr_Method_Internal_Boolean_ProductItemInstance_PDM_0;
		}

		// Token: 0x02000A33 RID: 2611
		[ObfuscatedName("ScheduleOne.Economy.Dealer+<>c__DisplayClass93_0")]
		public sealed class __c__DisplayClass93_0 : Il2CppSystem.Object
		{
			// Token: 0x0600D289 RID: 53897 RVA: 0x0032D50C File Offset: 0x0032B70C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass93_0()
			{
				Il2CppClassPointerStore<Dealer.__c__DisplayClass93_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Dealer>.NativeClassPtr, "<>c__DisplayClass93_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Dealer.__c__DisplayClass93_0>.NativeClassPtr);
				Dealer.__c__DisplayClass93_0.NativeFieldInfoPtr_product = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dealer.__c__DisplayClass93_0>.NativeClassPtr, "product");
				Dealer.__c__DisplayClass93_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer.__c__DisplayClass93_0>.NativeClassPtr, 100675280);
				Dealer.__c__DisplayClass93_0.NativeMethodInfoPtr__GetOrderableProducts_b__0_Internal_Boolean_ProductDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer.__c__DisplayClass93_0>.NativeClassPtr, 100675281);
			}

			// Token: 0x0600D28A RID: 53898 RVA: 0x0032D574 File Offset: 0x0032B774
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass93_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Dealer.__c__DisplayClass93_0>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.__c__DisplayClass93_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600D28B RID: 53899 RVA: 0x0032D5B0 File Offset: 0x0032B7B0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 195069, XrefRangeEnd = 195071, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GetOrderableProducts_b__0(ProductDefinition x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Dealer.__c__DisplayClass93_0.NativeMethodInfoPtr__GetOrderableProducts_b__0_Internal_Boolean_ProductDefinition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x0600D28C RID: 53900 RVA: 0x00066133 File Offset: 0x00064333
			public __c__DisplayClass93_0(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004138 RID: 16696
			// (get) Token: 0x0600D28D RID: 53901 RVA: 0x0032D600 File Offset: 0x0032B800
			// (set) Token: 0x0600D28E RID: 53902 RVA: 0x0006613C File Offset: 0x0006433C
			public unsafe ProductItemInstance product
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Dealer.__c__DisplayClass93_0.NativeFieldInfoPtr_product);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ProductItemInstance>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Dealer.__c__DisplayClass93_0.NativeFieldInfoPtr_product), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008E46 RID: 36422
			private static readonly System.IntPtr NativeFieldInfoPtr_product;

			// Token: 0x04008E47 RID: 36423
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008E48 RID: 36424
			private static readonly System.IntPtr NativeMethodInfoPtr__GetOrderableProducts_b__0_Internal_Boolean_ProductDefinition_0;
		}

		// Token: 0x02000A34 RID: 2612
		[ObfuscatedName("ScheduleOne.Economy.Dealer+<>c__DisplayClass97_0")]
		public sealed class __c__DisplayClass97_0 : Il2CppSystem.Object
		{
			// Token: 0x0600D28F RID: 53903 RVA: 0x0032D630 File Offset: 0x0032B830
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass97_0()
			{
				Il2CppClassPointerStore<Dealer.__c__DisplayClass97_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Dealer>.NativeClassPtr, "<>c__DisplayClass97_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Dealer.__c__DisplayClass97_0>.NativeClassPtr);
				Dealer.__c__DisplayClass97_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dealer.__c__DisplayClass97_0>.NativeClassPtr, "<>4__this");
				Dealer.__c__DisplayClass97_0.NativeFieldInfoPtr_contract = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dealer.__c__DisplayClass97_0>.NativeClassPtr, "contract");
				Dealer.__c__DisplayClass97_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer.__c__DisplayClass97_0>.NativeClassPtr, 100675282);
				Dealer.__c__DisplayClass97_0.NativeMethodInfoPtr__CustomerContractStarted_b__0_Internal_Void_EQuestState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer.__c__DisplayClass97_0>.NativeClassPtr, 100675283);
			}

			// Token: 0x0600D290 RID: 53904 RVA: 0x0032D6AC File Offset: 0x0032B8AC
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass97_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Dealer.__c__DisplayClass97_0>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.__c__DisplayClass97_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600D291 RID: 53905 RVA: 0x0032D6E8 File Offset: 0x0032B8E8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 195071, XrefRangeEnd = 195088, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _CustomerContractStarted_b__0(EQuestState <p0>)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = ref <p0>;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.__c__DisplayClass97_0.NativeMethodInfoPtr__CustomerContractStarted_b__0_Internal_Void_EQuestState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600D292 RID: 53906 RVA: 0x0006615B File Offset: 0x0006435B
			public __c__DisplayClass97_0(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004139 RID: 16697
			// (get) Token: 0x0600D293 RID: 53907 RVA: 0x0032D728 File Offset: 0x0032B928
			// (set) Token: 0x0600D294 RID: 53908 RVA: 0x00066164 File Offset: 0x00064364
			public unsafe Dealer __4__this
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Dealer.__c__DisplayClass97_0.NativeFieldInfoPtr___4__this);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dealer>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Dealer.__c__DisplayClass97_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700413A RID: 16698
			// (get) Token: 0x0600D295 RID: 53909 RVA: 0x0032D758 File Offset: 0x0032B958
			// (set) Token: 0x0600D296 RID: 53910 RVA: 0x00066183 File Offset: 0x00064383
			public unsafe Contract contract
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Dealer.__c__DisplayClass97_0.NativeFieldInfoPtr_contract);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Contract>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Dealer.__c__DisplayClass97_0.NativeFieldInfoPtr_contract), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008E49 RID: 36425
			private static readonly System.IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04008E4A RID: 36426
			private static readonly System.IntPtr NativeFieldInfoPtr_contract;

			// Token: 0x04008E4B RID: 36427
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008E4C RID: 36428
			private static readonly System.IntPtr NativeMethodInfoPtr__CustomerContractStarted_b__0_Internal_Void_EQuestState_0;
		}
	}
}
