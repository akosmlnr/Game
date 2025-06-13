using System;
using Il2CppFishNet.Connection;
using Il2CppFishNet.Object.Synchronizing;
using Il2CppFishNet.Serializing;
using Il2CppFishNet.Transporting;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using Il2CppScheduleOne.Dialogue;
using Il2CppScheduleOne.Messaging;
using Il2CppScheduleOne.NPCs;
using Il2CppScheduleOne.NPCs.Relation;
using Il2CppScheduleOne.Persistence.Datas;
using Il2CppScheduleOne.UI.Phone;
using Il2CppScheduleOne.UI.Shop;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace Il2CppScheduleOne.Economy
{
	// Token: 0x0200043B RID: 1083
	public class Supplier : NPC
	{
		// Token: 0x06005D97 RID: 23959 RVA: 0x001B375C File Offset: 0x001B195C
		// Note: this type is marked as 'beforefieldinit'.
		static Supplier()
		{
			Il2CppClassPointerStore<Supplier>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Economy", "Supplier");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Supplier>.NativeClassPtr);
			Supplier.NativeFieldInfoPtr_MEETUP_RELATIONSHIP_REQUIREMENT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Supplier>.NativeClassPtr, "MEETUP_RELATIONSHIP_REQUIREMENT");
			Supplier.NativeFieldInfoPtr_MEETUP_DURATION_MINS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Supplier>.NativeClassPtr, "MEETUP_DURATION_MINS");
			Supplier.NativeFieldInfoPtr_MEETING_COOLDOWN_MINS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Supplier>.NativeClassPtr, "MEETING_COOLDOWN_MINS");
			Supplier.NativeFieldInfoPtr_DEADDROP_WAIT_PER_ITEM = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Supplier>.NativeClassPtr, "DEADDROP_WAIT_PER_ITEM");
			Supplier.NativeFieldInfoPtr_DEADDROP_MAX_WAIT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Supplier>.NativeClassPtr, "DEADDROP_MAX_WAIT");
			Supplier.NativeFieldInfoPtr_DEADDROP_ITEM_LIMIT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Supplier>.NativeClassPtr, "DEADDROP_ITEM_LIMIT");
			Supplier.NativeFieldInfoPtr_DELIVERY_RELATIONSHIP_REQUIREMENT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Supplier>.NativeClassPtr, "DELIVERY_RELATIONSHIP_REQUIREMENT");
			Supplier.NativeFieldInfoPtr_SupplierLabelColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Supplier>.NativeClassPtr, "SupplierLabelColor");
			Supplier.NativeFieldInfoPtr__Status_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Supplier>.NativeClassPtr, "<Status>k__BackingField");
			Supplier.NativeFieldInfoPtr__DeliveriesEnabled_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Supplier>.NativeClassPtr, "<DeliveriesEnabled>k__BackingField");
			Supplier.NativeFieldInfoPtr_MinOrderLimit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Supplier>.NativeClassPtr, "MinOrderLimit");
			Supplier.NativeFieldInfoPtr_MaxOrderLimit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Supplier>.NativeClassPtr, "MaxOrderLimit");
			Supplier.NativeFieldInfoPtr_OnlineShopItems = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Supplier>.NativeClassPtr, "OnlineShopItems");
			Supplier.NativeFieldInfoPtr_SupplierRecommendMessage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Supplier>.NativeClassPtr, "SupplierRecommendMessage");
			Supplier.NativeFieldInfoPtr_SupplierUnlockHint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Supplier>.NativeClassPtr, "SupplierUnlockHint");
			Supplier.NativeFieldInfoPtr_Shop = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Supplier>.NativeClassPtr, "Shop");
			Supplier.NativeFieldInfoPtr_Stash = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Supplier>.NativeClassPtr, "Stash");
			Supplier.NativeFieldInfoPtr_onDeaddropReady = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Supplier>.NativeClassPtr, "onDeaddropReady");
			Supplier.NativeFieldInfoPtr_minsSinceMeetingStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Supplier>.NativeClassPtr, "minsSinceMeetingStart");
			Supplier.NativeFieldInfoPtr_minsSinceLastMeetingEnd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Supplier>.NativeClassPtr, "minsSinceLastMeetingEnd");
			Supplier.NativeFieldInfoPtr_currentLocation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Supplier>.NativeClassPtr, "currentLocation");
			Supplier.NativeFieldInfoPtr_dialogueController = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Supplier>.NativeClassPtr, "dialogueController");
			Supplier.NativeFieldInfoPtr_meetingGreeting = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Supplier>.NativeClassPtr, "meetingGreeting");
			Supplier.NativeFieldInfoPtr_meetingChoice = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Supplier>.NativeClassPtr, "meetingChoice");
			Supplier.NativeFieldInfoPtr_debt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Supplier>.NativeClassPtr, "debt");
			Supplier.NativeFieldInfoPtr_deadDropPreparing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Supplier>.NativeClassPtr, "deadDropPreparing");
			Supplier.NativeFieldInfoPtr__minsUntilDeaddropReady_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Supplier>.NativeClassPtr, "<minsUntilDeaddropReady>k__BackingField");
			Supplier.NativeFieldInfoPtr_deaddropItems = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Supplier>.NativeClassPtr, "deaddropItems");
			Supplier.NativeFieldInfoPtr_minsSinceDeaddropOrder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Supplier>.NativeClassPtr, "minsSinceDeaddropOrder");
			Supplier.NativeFieldInfoPtr_repaymentReminderSent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Supplier>.NativeClassPtr, "repaymentReminderSent");
			Supplier.NativeFieldInfoPtr_syncVar___debt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Supplier>.NativeClassPtr, "syncVar___debt");
			Supplier.NativeFieldInfoPtr_syncVar___deadDropPreparing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Supplier>.NativeClassPtr, "syncVar___deadDropPreparing");
			Supplier.NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Supplier>.NativeClassPtr, "NetworkInitialize___EarlyScheduleOne.Economy.SupplierAssembly-CSharp.dll_Excuted");
			Supplier.NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Supplier>.NativeClassPtr, "NetworkInitialize__LateScheduleOne.Economy.SupplierAssembly-CSharp.dll_Excuted");
			Supplier.NativeMethodInfoPtr_get_Status_Public_get_ESupplierStatus_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Supplier>.NativeClassPtr, 100675312);
			Supplier.NativeMethodInfoPtr_set_Status_Private_set_Void_ESupplierStatus_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Supplier>.NativeClassPtr, 100675313);
			Supplier.NativeMethodInfoPtr_get_DeliveriesEnabled_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Supplier>.NativeClassPtr, 100675314);
			Supplier.NativeMethodInfoPtr_set_DeliveriesEnabled_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Supplier>.NativeClassPtr, 100675315);
			Supplier.NativeMethodInfoPtr_get_Debt_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Supplier>.NativeClassPtr, 100675316);
			Supplier.NativeMethodInfoPtr_get_minsUntilDeaddropReady_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Supplier>.NativeClassPtr, 100675317);
			Supplier.NativeMethodInfoPtr_set_minsUntilDeaddropReady_Private_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Supplier>.NativeClassPtr, 100675318);
			Supplier.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Supplier>.NativeClassPtr, 100675319);
			Supplier.NativeMethodInfoPtr_Start_Protected_Virtual_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Supplier>.NativeClassPtr, 100675320);
			Supplier.NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Supplier>.NativeClassPtr, 100675321);
			Supplier.NativeMethodInfoPtr_SendUnlocked_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Supplier>.NativeClassPtr, 100675322);
			Supplier.NativeMethodInfoPtr_SetUnlocked_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Supplier>.NativeClassPtr, 100675323);
			Supplier.NativeMethodInfoPtr_MinPass_Protected_Virtual_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Supplier>.NativeClassPtr, 100675324);
			Supplier.NativeMethodInfoPtr_HourPass_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Supplier>.NativeClassPtr, 100675325);
			Supplier.NativeMethodInfoPtr_OnTimeSkip_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Supplier>.NativeClassPtr, 100675326);
			Supplier.NativeMethodInfoPtr_MeetAtLocation_Public_Void_NetworkConnection_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Supplier>.NativeClassPtr, 100675327);
			Supplier.NativeMethodInfoPtr_EndMeeting_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Supplier>.NativeClassPtr, 100675328);
			Supplier.NativeMethodInfoPtr_SupplierUnlocked_Protected_Virtual_New_Void_EUnlockType_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Supplier>.NativeClassPtr, 100675329);
			Supplier.NativeMethodInfoPtr_RelationshipChange_Protected_Virtual_New_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Supplier>.NativeClassPtr, 100675330);
			Supplier.NativeMethodInfoPtr_EnableDeliveries_Private_Void_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Supplier>.NativeClassPtr, 100675331);
			Supplier.NativeMethodInfoPtr_SetUnlockMessage_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Supplier>.NativeClassPtr, 100675332);
			Supplier.NativeMethodInfoPtr_CreateMessageConversation_Protected_Virtual_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Supplier>.NativeClassPtr, 100675333);
			Supplier.NativeMethodInfoPtr_DeaddropRequested_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Supplier>.NativeClassPtr, 100675334);
			Supplier.NativeMethodInfoPtr_DeaddropConfirmed_Protected_Virtual_New_Void_List_1_CartEntry_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Supplier>.NativeClassPtr, 100675335);
			Supplier.NativeMethodInfoPtr_SetDeaddrop_Private_Void_Il2CppReferenceArray_1_StringIntPair_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Supplier>.NativeClassPtr, 100675336);
			Supplier.NativeMethodInfoPtr_ChangeDebt_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Supplier>.NativeClassPtr, 100675337);
			Supplier.NativeMethodInfoPtr_TryRecoverDebt_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Supplier>.NativeClassPtr, 100675338);
			Supplier.NativeMethodInfoPtr_CompleteDeaddrop_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Supplier>.NativeClassPtr, 100675339);
			Supplier.NativeMethodInfoPtr_SendDebtReminder_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Supplier>.NativeClassPtr, 100675340);
			Supplier.NativeMethodInfoPtr_MeetupRequested_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Supplier>.NativeClassPtr, 100675341);
			Supplier.NativeMethodInfoPtr_PayDebtRequested_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Supplier>.NativeClassPtr, 100675342);
			Supplier.NativeMethodInfoPtr_GetAppropriateLocation_Protected_SupplierLocation_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Supplier>.NativeClassPtr, 100675343);
			Supplier.NativeMethodInfoPtr_IsDeadDropValid_Private_Boolean_SendableMessage_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Supplier>.NativeClassPtr, 100675344);
			Supplier.NativeMethodInfoPtr_IsMeetupValid_Private_Boolean_SendableMessage_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Supplier>.NativeClassPtr, 100675345);
			Supplier.NativeMethodInfoPtr_GetDeadDropLimit_Public_Virtual_New_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Supplier>.NativeClassPtr, 100675346);
			Supplier.NativeMethodInfoPtr_GetNPCData_Public_Virtual_NPCData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Supplier>.NativeClassPtr, 100675347);
			Supplier.NativeMethodInfoPtr_Load_Public_Virtual_Void_NPCData_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Supplier>.NativeClassPtr, 100675348);
			Supplier.NativeMethodInfoPtr_Load_Public_Virtual_Void_DynamicSaveData_NPCData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Supplier>.NativeClassPtr, 100675349);
			Supplier.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Supplier>.NativeClassPtr, 100675350);
			Supplier.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Supplier>.NativeClassPtr, 100675352);
			Supplier.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Supplier>.NativeClassPtr, 100675353);
			Supplier.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Supplier>.NativeClassPtr, 100675354);
			Supplier.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Supplier>.NativeClassPtr, 100675355);
			Supplier.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Supplier>.NativeClassPtr, 100675356);
			Supplier.NativeMethodInfoPtr_RpcWriter___Server_SendUnlocked_2166136261_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Supplier>.NativeClassPtr, 100675357);
			Supplier.NativeMethodInfoPtr_RpcLogic___SendUnlocked_2166136261_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Supplier>.NativeClassPtr, 100675358);
			Supplier.NativeMethodInfoPtr_RpcReader___Server_SendUnlocked_2166136261_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Supplier>.NativeClassPtr, 100675359);
			Supplier.NativeMethodInfoPtr_RpcWriter___Observers_SetUnlocked_2166136261_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Supplier>.NativeClassPtr, 100675360);
			Supplier.NativeMethodInfoPtr_RpcLogic___SetUnlocked_2166136261_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Supplier>.NativeClassPtr, 100675361);
			Supplier.NativeMethodInfoPtr_RpcReader___Observers_SetUnlocked_2166136261_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Supplier>.NativeClassPtr, 100675362);
			Supplier.NativeMethodInfoPtr_RpcWriter___Observers_MeetAtLocation_3470796954_Private_Void_NetworkConnection_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Supplier>.NativeClassPtr, 100675363);
			Supplier.NativeMethodInfoPtr_RpcLogic___MeetAtLocation_3470796954_Public_Void_NetworkConnection_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Supplier>.NativeClassPtr, 100675364);
			Supplier.NativeMethodInfoPtr_RpcReader___Observers_MeetAtLocation_3470796954_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Supplier>.NativeClassPtr, 100675365);
			Supplier.NativeMethodInfoPtr_RpcWriter___Observers_EnableDeliveries_328543758_Private_Void_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Supplier>.NativeClassPtr, 100675366);
			Supplier.NativeMethodInfoPtr_RpcLogic___EnableDeliveries_328543758_Private_Void_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Supplier>.NativeClassPtr, 100675367);
			Supplier.NativeMethodInfoPtr_RpcReader___Observers_EnableDeliveries_328543758_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Supplier>.NativeClassPtr, 100675368);
			Supplier.NativeMethodInfoPtr_RpcWriter___Target_EnableDeliveries_328543758_Private_Void_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Supplier>.NativeClassPtr, 100675369);
			Supplier.NativeMethodInfoPtr_RpcReader___Target_EnableDeliveries_328543758_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Supplier>.NativeClassPtr, 100675370);
			Supplier.NativeMethodInfoPtr_RpcWriter___Server_SetDeaddrop_3971994486_Private_Void_Il2CppReferenceArray_1_StringIntPair_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Supplier>.NativeClassPtr, 100675371);
			Supplier.NativeMethodInfoPtr_RpcLogic___SetDeaddrop_3971994486_Private_Void_Il2CppReferenceArray_1_StringIntPair_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Supplier>.NativeClassPtr, 100675372);
			Supplier.NativeMethodInfoPtr_RpcReader___Server_SetDeaddrop_3971994486_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Supplier>.NativeClassPtr, 100675373);
			Supplier.NativeMethodInfoPtr_RpcWriter___Server_ChangeDebt_431000436_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Supplier>.NativeClassPtr, 100675374);
			Supplier.NativeMethodInfoPtr_RpcLogic___ChangeDebt_431000436_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Supplier>.NativeClassPtr, 100675375);
			Supplier.NativeMethodInfoPtr_RpcReader___Server_ChangeDebt_431000436_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Supplier>.NativeClassPtr, 100675376);
			Supplier.NativeMethodInfoPtr_sync___get_value_debt_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Supplier>.NativeClassPtr, 100675377);
			Supplier.NativeMethodInfoPtr_sync___set_value_debt_Public_set_Void_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Supplier>.NativeClassPtr, 100675378);
			Supplier.NativeMethodInfoPtr_ReadSyncVar___ScheduleOne_Economy_Supplier_Public_Virtual_Boolean_PooledReader_UInt32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Supplier>.NativeClassPtr, 100675379);
			Supplier.NativeMethodInfoPtr_sync___get_value_deadDropPreparing_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Supplier>.NativeClassPtr, 100675380);
			Supplier.NativeMethodInfoPtr_sync___set_value_deadDropPreparing_Public_set_Void_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Supplier>.NativeClassPtr, 100675381);
			Supplier.NativeMethodInfoPtr_Method_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Supplier>.NativeClassPtr, 100675382);
		}

		// Token: 0x17001C1B RID: 7195
		// (get) Token: 0x06005D98 RID: 23960 RVA: 0x001B3FAC File Offset: 0x001B21AC
		// (set) Token: 0x06005D99 RID: 23961 RVA: 0x001B3FE8 File Offset: 0x001B21E8
		public unsafe Supplier.ESupplierStatus Status
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Supplier.NativeMethodInfoPtr_get_Status_Public_get_ESupplierStatus_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
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
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Supplier.NativeMethodInfoPtr_set_Status_Private_set_Void_ESupplierStatus_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x17001C1C RID: 7196
		// (get) Token: 0x06005D9A RID: 23962 RVA: 0x001B4028 File Offset: 0x001B2228
		// (set) Token: 0x06005D9B RID: 23963 RVA: 0x001B4064 File Offset: 0x001B2264
		public unsafe bool DeliveriesEnabled
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Supplier.NativeMethodInfoPtr_get_DeliveriesEnabled_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
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
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Supplier.NativeMethodInfoPtr_set_DeliveriesEnabled_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x17001C1D RID: 7197
		// (get) Token: 0x06005D9C RID: 23964 RVA: 0x001B40A4 File Offset: 0x001B22A4
		public unsafe float Debt
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 197911, RefRangeEnd = 197913, XrefRangeStart = 197911, XrefRangeEnd = 197911, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Supplier.NativeMethodInfoPtr_get_Debt_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
		}

		// Token: 0x17001C1E RID: 7198
		// (get) Token: 0x06005D9D RID: 23965 RVA: 0x001B40E0 File Offset: 0x001B22E0
		// (set) Token: 0x06005D9E RID: 23966 RVA: 0x001B411C File Offset: 0x001B231C
		public unsafe int minsUntilDeaddropReady
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Supplier.NativeMethodInfoPtr_get_minsUntilDeaddropReady_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
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
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Supplier.NativeMethodInfoPtr_set_minsUntilDeaddropReady_Private_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x06005D9F RID: 23967 RVA: 0x001B415C File Offset: 0x001B235C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 147536, RefRangeEnd = 147540, XrefRangeStart = 147536, XrefRangeEnd = 147540, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Supplier.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005DA0 RID: 23968 RVA: 0x001B4198 File Offset: 0x001B2398
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 197913, XrefRangeEnd = 198049, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Supplier.NativeMethodInfoPtr_Start_Protected_Virtual_Void_1), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005DA1 RID: 23969 RVA: 0x001B41D4 File Offset: 0x001B23D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 198049, XrefRangeEnd = 198060, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnSpawnServer(NetworkConnection connection)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(connection);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Supplier.NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005DA2 RID: 23970 RVA: 0x001B4224 File Offset: 0x001B2424
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 198069, RefRangeEnd = 198070, XrefRangeStart = 198060, XrefRangeEnd = 198069, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendUnlocked()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Supplier.NativeMethodInfoPtr_SendUnlocked_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005DA3 RID: 23971 RVA: 0x001B4258 File Offset: 0x001B2458
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 198070, XrefRangeEnd = 198079, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetUnlocked()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Supplier.NativeMethodInfoPtr_SetUnlocked_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005DA4 RID: 23972 RVA: 0x001B428C File Offset: 0x001B248C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 198079, XrefRangeEnd = 198092, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void MinPass()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Supplier.NativeMethodInfoPtr_MinPass_Protected_Virtual_Void_1), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005DA5 RID: 23973 RVA: 0x001B42C8 File Offset: 0x001B24C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 198092, XrefRangeEnd = 198109, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void HourPass()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Supplier.NativeMethodInfoPtr_HourPass_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005DA6 RID: 23974 RVA: 0x001B42FC File Offset: 0x001B24FC
		[CallerCount(0)]
		public unsafe void OnTimeSkip(int minsSlept)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref minsSlept;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Supplier.NativeMethodInfoPtr_OnTimeSkip_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005DA7 RID: 23975 RVA: 0x001B433C File Offset: 0x001B253C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 198135, RefRangeEnd = 198137, XrefRangeStart = 198109, XrefRangeEnd = 198135, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MeetAtLocation(NetworkConnection conn, int locationIndex, int expireIn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref locationIndex;
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref expireIn;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Supplier.NativeMethodInfoPtr_MeetAtLocation_Public_Void_NetworkConnection_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005DA8 RID: 23976 RVA: 0x001B439C File Offset: 0x001B259C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 198137, XrefRangeEnd = 198145, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EndMeeting()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Supplier.NativeMethodInfoPtr_EndMeeting_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005DA9 RID: 23977 RVA: 0x001B43D0 File Offset: 0x001B25D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 198145, XrefRangeEnd = 198158, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SupplierUnlocked(NPCRelationData.EUnlockType type, bool notify)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref type;
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref notify;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Supplier.NativeMethodInfoPtr_SupplierUnlocked_Protected_Virtual_New_Void_EUnlockType_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005DAA RID: 23978 RVA: 0x001B4428 File Offset: 0x001B2628
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 198158, XrefRangeEnd = 198185, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void RelationshipChange(float change)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref change;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Supplier.NativeMethodInfoPtr_RelationshipChange_Protected_Virtual_New_Void_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005DAB RID: 23979 RVA: 0x001B4474 File Offset: 0x001B2674
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 198222, RefRangeEnd = 198224, XrefRangeStart = 198185, XrefRangeEnd = 198222, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EnableDeliveries(NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Supplier.NativeMethodInfoPtr_EnableDeliveries_Private_Void_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005DAC RID: 23980 RVA: 0x001B44B8 File Offset: 0x001B26B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 198224, XrefRangeEnd = 198230, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetUnlockMessage()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Supplier.NativeMethodInfoPtr_SetUnlockMessage_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005DAD RID: 23981 RVA: 0x001B44EC File Offset: 0x001B26EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 198230, XrefRangeEnd = 198285, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void CreateMessageConversation()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Supplier.NativeMethodInfoPtr_CreateMessageConversation_Protected_Virtual_Void_1), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005DAE RID: 23982 RVA: 0x001B4528 File Offset: 0x001B2728
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 198285, XrefRangeEnd = 198302, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void DeaddropRequested()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Supplier.NativeMethodInfoPtr_DeaddropRequested_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005DAF RID: 23983 RVA: 0x001B4564 File Offset: 0x001B2764
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 198424, RefRangeEnd = 198425, XrefRangeStart = 198302, XrefRangeEnd = 198424, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void DeaddropConfirmed(List<PhoneShopInterface.CartEntry> cart, float totalPrice)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(cart);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref totalPrice;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Supplier.NativeMethodInfoPtr_DeaddropConfirmed_Protected_Virtual_New_Void_List_1_CartEntry_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005DB0 RID: 23984 RVA: 0x001B45C0 File Offset: 0x001B27C0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 198437, RefRangeEnd = 198439, XrefRangeStart = 198425, XrefRangeEnd = 198437, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetDeaddrop(Il2CppReferenceArray<StringIntPair> items, int minsUntilReady)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(items);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref minsUntilReady;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Supplier.NativeMethodInfoPtr_SetDeaddrop_Private_Void_Il2CppReferenceArray_1_StringIntPair_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005DB1 RID: 23985 RVA: 0x001B4610 File Offset: 0x001B2810
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 198461, RefRangeEnd = 198463, XrefRangeStart = 198439, XrefRangeEnd = 198461, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ChangeDebt(float amount)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref amount;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Supplier.NativeMethodInfoPtr_ChangeDebt_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005DB2 RID: 23986 RVA: 0x001B4650 File Offset: 0x001B2850
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 198503, RefRangeEnd = 198504, XrefRangeStart = 198463, XrefRangeEnd = 198503, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void TryRecoverDebt()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Supplier.NativeMethodInfoPtr_TryRecoverDebt_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005DB3 RID: 23987 RVA: 0x001B4684 File Offset: 0x001B2884
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 198581, RefRangeEnd = 198582, XrefRangeStart = 198504, XrefRangeEnd = 198581, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CompleteDeaddrop()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Supplier.NativeMethodInfoPtr_CompleteDeaddrop_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005DB4 RID: 23988 RVA: 0x001B46B8 File Offset: 0x001B28B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 198582, XrefRangeEnd = 198597, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendDebtReminder()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Supplier.NativeMethodInfoPtr_SendDebtReminder_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005DB5 RID: 23989 RVA: 0x001B46EC File Offset: 0x001B28EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 198597, XrefRangeEnd = 198615, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void MeetupRequested()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Supplier.NativeMethodInfoPtr_MeetupRequested_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005DB6 RID: 23990 RVA: 0x001B4728 File Offset: 0x001B2928
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 198615, XrefRangeEnd = 198630, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void PayDebtRequested()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Supplier.NativeMethodInfoPtr_PayDebtRequested_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005DB7 RID: 23991 RVA: 0x001B4764 File Offset: 0x001B2964
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 198715, RefRangeEnd = 198716, XrefRangeStart = 198630, XrefRangeEnd = 198715, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SupplierLocation GetAppropriateLocation(out int locationIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = &locationIndex;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Supplier.NativeMethodInfoPtr_GetAppropriateLocation_Protected_SupplierLocation_byref_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<SupplierLocation>(intPtr2) : null;
		}

		// Token: 0x06005DB8 RID: 23992 RVA: 0x001B47B0 File Offset: 0x001B29B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 198716, XrefRangeEnd = 198720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsDeadDropValid(SendableMessage message, out string invalidReason)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(message);
			ref System.IntPtr ptr2 = ref ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)];
			System.IntPtr il2CppString = 0;
			ptr2 = &il2CppString;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Supplier.NativeMethodInfoPtr_IsDeadDropValid_Private_Boolean_SendableMessage_byref_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			invalidReason = IL2CPP.Il2CppStringToManaged(il2CppString);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06005DB9 RID: 23993 RVA: 0x001B4818 File Offset: 0x001B2A18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 198720, XrefRangeEnd = 198726, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsMeetupValid(SendableMessage message, out string invalidReason)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(message);
			ref System.IntPtr ptr2 = ref ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)];
			System.IntPtr il2CppString = 0;
			ptr2 = &il2CppString;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Supplier.NativeMethodInfoPtr_IsMeetupValid_Private_Boolean_SendableMessage_byref_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			invalidReason = IL2CPP.Il2CppStringToManaged(il2CppString);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06005DBA RID: 23994 RVA: 0x001B4880 File Offset: 0x001B2A80
		[CallerCount(0)]
		public unsafe virtual float GetDeadDropLimit()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Supplier.NativeMethodInfoPtr_GetDeadDropLimit_Public_Virtual_New_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06005DBB RID: 23995 RVA: 0x001B48C8 File Offset: 0x001B2AC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 198726, XrefRangeEnd = 198730, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override NPCData GetNPCData()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Supplier.NativeMethodInfoPtr_GetNPCData_Public_Virtual_NPCData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<NPCData>(intPtr2) : null;
		}

		// Token: 0x06005DBC RID: 23996 RVA: 0x001B4914 File Offset: 0x001B2B14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 198730, XrefRangeEnd = 198757, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Load(NPCData data, string containerPath)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(containerPath);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Supplier.NativeMethodInfoPtr_Load_Public_Virtual_Void_NPCData_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005DBD RID: 23997 RVA: 0x001B4974 File Offset: 0x001B2B74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 198757, XrefRangeEnd = 198779, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Load(DynamicSaveData dynamicData, NPCData npcData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(dynamicData);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(npcData);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Supplier.NativeMethodInfoPtr_Load_Public_Virtual_Void_DynamicSaveData_NPCData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005DBE RID: 23998 RVA: 0x001B49D4 File Offset: 0x001B2BD4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 198788, RefRangeEnd = 198791, XrefRangeStart = 198779, XrefRangeEnd = 198788, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Supplier() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Supplier>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Supplier.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005DBF RID: 23999 RVA: 0x001B4A10 File Offset: 0x001B2C10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 198791, XrefRangeEnd = 198796, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator Method_Private_IEnumerator_PDM_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Supplier.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr2) : null;
		}

		// Token: 0x06005DC0 RID: 24000 RVA: 0x001B4A50 File Offset: 0x001B2C50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 198796, XrefRangeEnd = 198801, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator Method_Private_IEnumerator_PDM_1()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Supplier.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr2) : null;
		}

		// Token: 0x06005DC1 RID: 24001 RVA: 0x001B4A90 File Offset: 0x001B2C90
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 198871, RefRangeEnd = 198874, XrefRangeStart = 198801, XrefRangeEnd = 198871, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize___Early()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Supplier.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005DC2 RID: 24002 RVA: 0x001B4ACC File Offset: 0x001B2CCC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 198875, RefRangeEnd = 198878, XrefRangeStart = 198874, XrefRangeEnd = 198875, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize__Late()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Supplier.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005DC3 RID: 24003 RVA: 0x001B4B08 File Offset: 0x001B2D08
		[CallerCount(0)]
		public unsafe override void NetworkInitializeIfDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Supplier.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005DC4 RID: 24004 RVA: 0x001B4B44 File Offset: 0x001B2D44
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 198069, RefRangeEnd = 198070, XrefRangeStart = 198069, XrefRangeEnd = 198070, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_SendUnlocked_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Supplier.NativeMethodInfoPtr_RpcWriter___Server_SendUnlocked_2166136261_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005DC5 RID: 24005 RVA: 0x001B4B78 File Offset: 0x001B2D78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SendUnlocked_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Supplier.NativeMethodInfoPtr_RpcLogic___SendUnlocked_2166136261_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005DC6 RID: 24006 RVA: 0x001B4BAC File Offset: 0x001B2DAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 198878, XrefRangeEnd = 198888, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_SendUnlocked_2166136261(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref channel;
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Supplier.NativeMethodInfoPtr_RpcReader___Server_SendUnlocked_2166136261_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005DC7 RID: 24007 RVA: 0x001B4C10 File Offset: 0x001B2E10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_SetUnlocked_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Supplier.NativeMethodInfoPtr_RpcWriter___Observers_SetUnlocked_2166136261_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005DC8 RID: 24008 RVA: 0x001B4C44 File Offset: 0x001B2E44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 198888, XrefRangeEnd = 198889, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SetUnlocked_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Supplier.NativeMethodInfoPtr_RpcLogic___SetUnlocked_2166136261_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005DC9 RID: 24009 RVA: 0x001B4C78 File Offset: 0x001B2E78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 198889, XrefRangeEnd = 198890, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_SetUnlocked_2166136261(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref channel;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Supplier.NativeMethodInfoPtr_RpcReader___Observers_SetUnlocked_2166136261_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005DCA RID: 24010 RVA: 0x001B4CC8 File Offset: 0x001B2EC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 198890, XrefRangeEnd = 198904, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_MeetAtLocation_3470796954(NetworkConnection conn, int locationIndex, int expireIn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref locationIndex;
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref expireIn;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Supplier.NativeMethodInfoPtr_RpcWriter___Observers_MeetAtLocation_3470796954_Private_Void_NetworkConnection_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005DCB RID: 24011 RVA: 0x001B4D28 File Offset: 0x001B2F28
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 198951, RefRangeEnd = 198953, XrefRangeStart = 198904, XrefRangeEnd = 198951, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___MeetAtLocation_3470796954(NetworkConnection conn, int locationIndex, int expireIn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref locationIndex;
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref expireIn;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Supplier.NativeMethodInfoPtr_RpcLogic___MeetAtLocation_3470796954_Public_Void_NetworkConnection_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005DCC RID: 24012 RVA: 0x001B4D88 File Offset: 0x001B2F88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 198953, XrefRangeEnd = 198961, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_MeetAtLocation_3470796954(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref channel;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Supplier.NativeMethodInfoPtr_RpcReader___Observers_MeetAtLocation_3470796954_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005DCD RID: 24013 RVA: 0x001B4DD8 File Offset: 0x001B2FD8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 198961, XrefRangeEnd = 198970, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_EnableDeliveries_328543758(NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Supplier.NativeMethodInfoPtr_RpcWriter___Observers_EnableDeliveries_328543758_Private_Void_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005DCE RID: 24014 RVA: 0x001B4E1C File Offset: 0x001B301C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 198981, RefRangeEnd = 198984, XrefRangeStart = 198970, XrefRangeEnd = 198981, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___EnableDeliveries_328543758(NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Supplier.NativeMethodInfoPtr_RpcLogic___EnableDeliveries_328543758_Private_Void_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005DCF RID: 24015 RVA: 0x001B4E60 File Offset: 0x001B3060
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 198984, XrefRangeEnd = 198987, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_EnableDeliveries_328543758(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref channel;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Supplier.NativeMethodInfoPtr_RpcReader___Observers_EnableDeliveries_328543758_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005DD0 RID: 24016 RVA: 0x001B4EB0 File Offset: 0x001B30B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 198987, XrefRangeEnd = 198996, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Target_EnableDeliveries_328543758(NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Supplier.NativeMethodInfoPtr_RpcWriter___Target_EnableDeliveries_328543758_Private_Void_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005DD1 RID: 24017 RVA: 0x001B4EF4 File Offset: 0x001B30F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 198996, XrefRangeEnd = 198999, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Target_EnableDeliveries_328543758(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref channel;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Supplier.NativeMethodInfoPtr_RpcReader___Target_EnableDeliveries_328543758_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005DD2 RID: 24018 RVA: 0x001B4F44 File Offset: 0x001B3144
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 198437, RefRangeEnd = 198439, XrefRangeStart = 198437, XrefRangeEnd = 198439, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_SetDeaddrop_3971994486(Il2CppReferenceArray<StringIntPair> items, int minsUntilReady)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(items);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref minsUntilReady;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Supplier.NativeMethodInfoPtr_RpcWriter___Server_SetDeaddrop_3971994486_Private_Void_Il2CppReferenceArray_1_StringIntPair_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005DD3 RID: 24019 RVA: 0x001B4F94 File Offset: 0x001B3194
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 198999, XrefRangeEnd = 199015, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SetDeaddrop_3971994486(Il2CppReferenceArray<StringIntPair> items, int minsUntilReady)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(items);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref minsUntilReady;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Supplier.NativeMethodInfoPtr_RpcLogic___SetDeaddrop_3971994486_Private_Void_Il2CppReferenceArray_1_StringIntPair_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005DD4 RID: 24020 RVA: 0x001B4FE4 File Offset: 0x001B31E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 199015, XrefRangeEnd = 199033, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_SetDeaddrop_3971994486(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref channel;
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Supplier.NativeMethodInfoPtr_RpcReader___Server_SetDeaddrop_3971994486_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005DD5 RID: 24021 RVA: 0x001B5048 File Offset: 0x001B3248
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 199033, XrefRangeEnd = 199043, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_ChangeDebt_431000436(float amount)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref amount;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Supplier.NativeMethodInfoPtr_RpcWriter___Server_ChangeDebt_431000436_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005DD6 RID: 24022 RVA: 0x001B5088 File Offset: 0x001B3288
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 199051, RefRangeEnd = 199053, XrefRangeStart = 199043, XrefRangeEnd = 199051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___ChangeDebt_431000436(float amount)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref amount;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Supplier.NativeMethodInfoPtr_RpcLogic___ChangeDebt_431000436_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005DD7 RID: 24023 RVA: 0x001B50C8 File Offset: 0x001B32C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 199053, XrefRangeEnd = 199057, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_ChangeDebt_431000436(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref channel;
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Supplier.NativeMethodInfoPtr_RpcReader___Server_ChangeDebt_431000436_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x17001C1F RID: 7199
		// (get) Token: 0x06005DD8 RID: 24024 RVA: 0x001B512C File Offset: 0x001B332C
		// (set) Token: 0x06005DD9 RID: 24025 RVA: 0x001B5168 File Offset: 0x001B3368
		public unsafe float SyncAccessor_debt
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 197911, RefRangeEnd = 197913, XrefRangeStart = 197911, XrefRangeEnd = 197913, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Supplier.NativeMethodInfoPtr_sync___get_value_debt_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 199065, RefRangeEnd = 199066, XrefRangeStart = 199057, XrefRangeEnd = 199065, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = ref value;
				ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref value;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Supplier.NativeMethodInfoPtr_sync___set_value_debt_Public_set_Void_Single_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x06005DDA RID: 24026 RVA: 0x001B51B4 File Offset: 0x001B33B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 199066, XrefRangeEnd = 199071, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool ReadSyncVar___ScheduleOne_Economy_Supplier(PooledReader PooledReader0, uint UInt321, bool Boolean2)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref UInt321;
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref Boolean2;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Supplier.NativeMethodInfoPtr_ReadSyncVar___ScheduleOne_Economy_Supplier_Public_Virtual_Boolean_PooledReader_UInt32_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x17001C20 RID: 7200
		// (get) Token: 0x06005DDB RID: 24027 RVA: 0x001B5228 File Offset: 0x001B3428
		// (set) Token: 0x06005DDC RID: 24028 RVA: 0x001B5264 File Offset: 0x001B3464
		public unsafe bool SyncAccessor_deadDropPreparing
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Supplier.NativeMethodInfoPtr_sync___get_value_deadDropPreparing_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 199071, XrefRangeEnd = 199079, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = ref value;
				ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref value;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Supplier.NativeMethodInfoPtr_sync___set_value_deadDropPreparing_Public_set_Void_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x06005DDD RID: 24029 RVA: 0x001B52B0 File Offset: 0x001B34B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 199079, XrefRangeEnd = 199080, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Method_Protected_Virtual_Void_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Supplier.NativeMethodInfoPtr_Method_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005DDE RID: 24030 RVA: 0x0002BECD File Offset: 0x0002A0CD
		public Supplier(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001BF9 RID: 7161
		// (get) Token: 0x06005DDF RID: 24031 RVA: 0x001B52EC File Offset: 0x001B34EC
		// (set) Token: 0x06005DE0 RID: 24032 RVA: 0x0002BED6 File Offset: 0x0002A0D6
		public unsafe static float MEETUP_RELATIONSHIP_REQUIREMENT
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(Supplier.NativeFieldInfoPtr_MEETUP_RELATIONSHIP_REQUIREMENT, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Supplier.NativeFieldInfoPtr_MEETUP_RELATIONSHIP_REQUIREMENT, (void*)(&value));
			}
		}

		// Token: 0x17001BFA RID: 7162
		// (get) Token: 0x06005DE1 RID: 24033 RVA: 0x001B5308 File Offset: 0x001B3508
		// (set) Token: 0x06005DE2 RID: 24034 RVA: 0x0002BEE4 File Offset: 0x0002A0E4
		public unsafe static int MEETUP_DURATION_MINS
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(Supplier.NativeFieldInfoPtr_MEETUP_DURATION_MINS, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Supplier.NativeFieldInfoPtr_MEETUP_DURATION_MINS, (void*)(&value));
			}
		}

		// Token: 0x17001BFB RID: 7163
		// (get) Token: 0x06005DE3 RID: 24035 RVA: 0x001B5324 File Offset: 0x001B3524
		// (set) Token: 0x06005DE4 RID: 24036 RVA: 0x0002BEF2 File Offset: 0x0002A0F2
		public unsafe static int MEETING_COOLDOWN_MINS
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(Supplier.NativeFieldInfoPtr_MEETING_COOLDOWN_MINS, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Supplier.NativeFieldInfoPtr_MEETING_COOLDOWN_MINS, (void*)(&value));
			}
		}

		// Token: 0x17001BFC RID: 7164
		// (get) Token: 0x06005DE5 RID: 24037 RVA: 0x001B5340 File Offset: 0x001B3540
		// (set) Token: 0x06005DE6 RID: 24038 RVA: 0x0002BF00 File Offset: 0x0002A100
		public unsafe static int DEADDROP_WAIT_PER_ITEM
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(Supplier.NativeFieldInfoPtr_DEADDROP_WAIT_PER_ITEM, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Supplier.NativeFieldInfoPtr_DEADDROP_WAIT_PER_ITEM, (void*)(&value));
			}
		}

		// Token: 0x17001BFD RID: 7165
		// (get) Token: 0x06005DE7 RID: 24039 RVA: 0x001B535C File Offset: 0x001B355C
		// (set) Token: 0x06005DE8 RID: 24040 RVA: 0x0002BF0E File Offset: 0x0002A10E
		public unsafe static int DEADDROP_MAX_WAIT
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(Supplier.NativeFieldInfoPtr_DEADDROP_MAX_WAIT, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Supplier.NativeFieldInfoPtr_DEADDROP_MAX_WAIT, (void*)(&value));
			}
		}

		// Token: 0x17001BFE RID: 7166
		// (get) Token: 0x06005DE9 RID: 24041 RVA: 0x001B5378 File Offset: 0x001B3578
		// (set) Token: 0x06005DEA RID: 24042 RVA: 0x0002BF1C File Offset: 0x0002A11C
		public unsafe static int DEADDROP_ITEM_LIMIT
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(Supplier.NativeFieldInfoPtr_DEADDROP_ITEM_LIMIT, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Supplier.NativeFieldInfoPtr_DEADDROP_ITEM_LIMIT, (void*)(&value));
			}
		}

		// Token: 0x17001BFF RID: 7167
		// (get) Token: 0x06005DEB RID: 24043 RVA: 0x001B5394 File Offset: 0x001B3594
		// (set) Token: 0x06005DEC RID: 24044 RVA: 0x0002BF2A File Offset: 0x0002A12A
		public unsafe static float DELIVERY_RELATIONSHIP_REQUIREMENT
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(Supplier.NativeFieldInfoPtr_DELIVERY_RELATIONSHIP_REQUIREMENT, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Supplier.NativeFieldInfoPtr_DELIVERY_RELATIONSHIP_REQUIREMENT, (void*)(&value));
			}
		}

		// Token: 0x17001C00 RID: 7168
		// (get) Token: 0x06005DED RID: 24045 RVA: 0x001B53B0 File Offset: 0x001B35B0
		// (set) Token: 0x06005DEE RID: 24046 RVA: 0x0002BF38 File Offset: 0x0002A138
		public unsafe static Color32 SupplierLabelColor
		{
			get
			{
				Color32 result;
				IL2CPP.il2cpp_field_static_get_value(Supplier.NativeFieldInfoPtr_SupplierLabelColor, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Supplier.NativeFieldInfoPtr_SupplierLabelColor, (void*)(&value));
			}
		}

		// Token: 0x17001C01 RID: 7169
		// (get) Token: 0x06005DEF RID: 24047 RVA: 0x001B53CC File Offset: 0x001B35CC
		// (set) Token: 0x06005DF0 RID: 24048 RVA: 0x0002BF46 File Offset: 0x0002A146
		public unsafe Supplier.ESupplierStatus _Status_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Supplier.NativeFieldInfoPtr__Status_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Supplier.NativeFieldInfoPtr__Status_k__BackingField)) = value;
			}
		}

		// Token: 0x17001C02 RID: 7170
		// (get) Token: 0x06005DF1 RID: 24049 RVA: 0x001B53F4 File Offset: 0x001B35F4
		// (set) Token: 0x06005DF2 RID: 24050 RVA: 0x0002BF61 File Offset: 0x0002A161
		public unsafe bool _DeliveriesEnabled_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Supplier.NativeFieldInfoPtr__DeliveriesEnabled_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Supplier.NativeFieldInfoPtr__DeliveriesEnabled_k__BackingField)) = value;
			}
		}

		// Token: 0x17001C03 RID: 7171
		// (get) Token: 0x06005DF3 RID: 24051 RVA: 0x001B541C File Offset: 0x001B361C
		// (set) Token: 0x06005DF4 RID: 24052 RVA: 0x0002BF7C File Offset: 0x0002A17C
		public unsafe float MinOrderLimit
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Supplier.NativeFieldInfoPtr_MinOrderLimit);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Supplier.NativeFieldInfoPtr_MinOrderLimit)) = value;
			}
		}

		// Token: 0x17001C04 RID: 7172
		// (get) Token: 0x06005DF5 RID: 24053 RVA: 0x001B5444 File Offset: 0x001B3644
		// (set) Token: 0x06005DF6 RID: 24054 RVA: 0x0002BF97 File Offset: 0x0002A197
		public unsafe float MaxOrderLimit
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Supplier.NativeFieldInfoPtr_MaxOrderLimit);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Supplier.NativeFieldInfoPtr_MaxOrderLimit)) = value;
			}
		}

		// Token: 0x17001C05 RID: 7173
		// (get) Token: 0x06005DF7 RID: 24055 RVA: 0x001B546C File Offset: 0x001B366C
		// (set) Token: 0x06005DF8 RID: 24056 RVA: 0x0002BFB2 File Offset: 0x0002A1B2
		public unsafe Il2CppReferenceArray<PhoneShopInterface.Listing> OnlineShopItems
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Supplier.NativeFieldInfoPtr_OnlineShopItems);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<PhoneShopInterface.Listing>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Supplier.NativeFieldInfoPtr_OnlineShopItems), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001C06 RID: 7174
		// (get) Token: 0x06005DF9 RID: 24057 RVA: 0x001B549C File Offset: 0x001B369C
		// (set) Token: 0x06005DFA RID: 24058 RVA: 0x0002BFD1 File Offset: 0x0002A1D1
		public unsafe string SupplierRecommendMessage
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Supplier.NativeFieldInfoPtr_SupplierRecommendMessage);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Supplier.NativeFieldInfoPtr_SupplierRecommendMessage), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001C07 RID: 7175
		// (get) Token: 0x06005DFB RID: 24059 RVA: 0x001B54C4 File Offset: 0x001B36C4
		// (set) Token: 0x06005DFC RID: 24060 RVA: 0x0002BFF0 File Offset: 0x0002A1F0
		public unsafe string SupplierUnlockHint
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Supplier.NativeFieldInfoPtr_SupplierUnlockHint);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Supplier.NativeFieldInfoPtr_SupplierUnlockHint), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001C08 RID: 7176
		// (get) Token: 0x06005DFD RID: 24061 RVA: 0x001B54EC File Offset: 0x001B36EC
		// (set) Token: 0x06005DFE RID: 24062 RVA: 0x0002C00F File Offset: 0x0002A20F
		public unsafe ShopInterface Shop
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Supplier.NativeFieldInfoPtr_Shop);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ShopInterface>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Supplier.NativeFieldInfoPtr_Shop), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001C09 RID: 7177
		// (get) Token: 0x06005DFF RID: 24063 RVA: 0x001B551C File Offset: 0x001B371C
		// (set) Token: 0x06005E00 RID: 24064 RVA: 0x0002C02E File Offset: 0x0002A22E
		public unsafe SupplierStash Stash
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Supplier.NativeFieldInfoPtr_Stash);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SupplierStash>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Supplier.NativeFieldInfoPtr_Stash), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001C0A RID: 7178
		// (get) Token: 0x06005E01 RID: 24065 RVA: 0x001B554C File Offset: 0x001B374C
		// (set) Token: 0x06005E02 RID: 24066 RVA: 0x0002C04D File Offset: 0x0002A24D
		public unsafe UnityEvent onDeaddropReady
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Supplier.NativeFieldInfoPtr_onDeaddropReady);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Supplier.NativeFieldInfoPtr_onDeaddropReady), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001C0B RID: 7179
		// (get) Token: 0x06005E03 RID: 24067 RVA: 0x001B557C File Offset: 0x001B377C
		// (set) Token: 0x06005E04 RID: 24068 RVA: 0x0002C06C File Offset: 0x0002A26C
		public unsafe int minsSinceMeetingStart
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Supplier.NativeFieldInfoPtr_minsSinceMeetingStart);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Supplier.NativeFieldInfoPtr_minsSinceMeetingStart)) = value;
			}
		}

		// Token: 0x17001C0C RID: 7180
		// (get) Token: 0x06005E05 RID: 24069 RVA: 0x001B55A4 File Offset: 0x001B37A4
		// (set) Token: 0x06005E06 RID: 24070 RVA: 0x0002C087 File Offset: 0x0002A287
		public unsafe int minsSinceLastMeetingEnd
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Supplier.NativeFieldInfoPtr_minsSinceLastMeetingEnd);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Supplier.NativeFieldInfoPtr_minsSinceLastMeetingEnd)) = value;
			}
		}

		// Token: 0x17001C0D RID: 7181
		// (get) Token: 0x06005E07 RID: 24071 RVA: 0x001B55CC File Offset: 0x001B37CC
		// (set) Token: 0x06005E08 RID: 24072 RVA: 0x0002C0A2 File Offset: 0x0002A2A2
		public unsafe SupplierLocation currentLocation
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Supplier.NativeFieldInfoPtr_currentLocation);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SupplierLocation>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Supplier.NativeFieldInfoPtr_currentLocation), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001C0E RID: 7182
		// (get) Token: 0x06005E09 RID: 24073 RVA: 0x001B55FC File Offset: 0x001B37FC
		// (set) Token: 0x06005E0A RID: 24074 RVA: 0x0002C0C1 File Offset: 0x0002A2C1
		public unsafe DialogueController dialogueController
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Supplier.NativeFieldInfoPtr_dialogueController);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DialogueController>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Supplier.NativeFieldInfoPtr_dialogueController), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001C0F RID: 7183
		// (get) Token: 0x06005E0B RID: 24075 RVA: 0x001B562C File Offset: 0x001B382C
		// (set) Token: 0x06005E0C RID: 24076 RVA: 0x0002C0E0 File Offset: 0x0002A2E0
		public unsafe DialogueController.GreetingOverride meetingGreeting
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Supplier.NativeFieldInfoPtr_meetingGreeting);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DialogueController.GreetingOverride>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Supplier.NativeFieldInfoPtr_meetingGreeting), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001C10 RID: 7184
		// (get) Token: 0x06005E0D RID: 24077 RVA: 0x001B565C File Offset: 0x001B385C
		// (set) Token: 0x06005E0E RID: 24078 RVA: 0x0002C0FF File Offset: 0x0002A2FF
		public unsafe DialogueController.DialogueChoice meetingChoice
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Supplier.NativeFieldInfoPtr_meetingChoice);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DialogueController.DialogueChoice>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Supplier.NativeFieldInfoPtr_meetingChoice), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001C11 RID: 7185
		// (get) Token: 0x06005E0F RID: 24079 RVA: 0x001B568C File Offset: 0x001B388C
		// (set) Token: 0x06005E10 RID: 24080 RVA: 0x0002C11E File Offset: 0x0002A31E
		public unsafe float debt
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Supplier.NativeFieldInfoPtr_debt);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Supplier.NativeFieldInfoPtr_debt)) = value;
			}
		}

		// Token: 0x17001C12 RID: 7186
		// (get) Token: 0x06005E11 RID: 24081 RVA: 0x001B56B4 File Offset: 0x001B38B4
		// (set) Token: 0x06005E12 RID: 24082 RVA: 0x0002C139 File Offset: 0x0002A339
		public unsafe bool deadDropPreparing
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Supplier.NativeFieldInfoPtr_deadDropPreparing);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Supplier.NativeFieldInfoPtr_deadDropPreparing)) = value;
			}
		}

		// Token: 0x17001C13 RID: 7187
		// (get) Token: 0x06005E13 RID: 24083 RVA: 0x001B56DC File Offset: 0x001B38DC
		// (set) Token: 0x06005E14 RID: 24084 RVA: 0x0002C154 File Offset: 0x0002A354
		public unsafe int _minsUntilDeaddropReady_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Supplier.NativeFieldInfoPtr__minsUntilDeaddropReady_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Supplier.NativeFieldInfoPtr__minsUntilDeaddropReady_k__BackingField)) = value;
			}
		}

		// Token: 0x17001C14 RID: 7188
		// (get) Token: 0x06005E15 RID: 24085 RVA: 0x001B5704 File Offset: 0x001B3904
		// (set) Token: 0x06005E16 RID: 24086 RVA: 0x0002C16F File Offset: 0x0002A36F
		public unsafe Il2CppReferenceArray<StringIntPair> deaddropItems
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Supplier.NativeFieldInfoPtr_deaddropItems);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<StringIntPair>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Supplier.NativeFieldInfoPtr_deaddropItems), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001C15 RID: 7189
		// (get) Token: 0x06005E17 RID: 24087 RVA: 0x001B5734 File Offset: 0x001B3934
		// (set) Token: 0x06005E18 RID: 24088 RVA: 0x0002C18E File Offset: 0x0002A38E
		public unsafe int minsSinceDeaddropOrder
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Supplier.NativeFieldInfoPtr_minsSinceDeaddropOrder);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Supplier.NativeFieldInfoPtr_minsSinceDeaddropOrder)) = value;
			}
		}

		// Token: 0x17001C16 RID: 7190
		// (get) Token: 0x06005E19 RID: 24089 RVA: 0x001B575C File Offset: 0x001B395C
		// (set) Token: 0x06005E1A RID: 24090 RVA: 0x0002C1A9 File Offset: 0x0002A3A9
		public unsafe bool repaymentReminderSent
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Supplier.NativeFieldInfoPtr_repaymentReminderSent);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Supplier.NativeFieldInfoPtr_repaymentReminderSent)) = value;
			}
		}

		// Token: 0x17001C17 RID: 7191
		// (get) Token: 0x06005E1B RID: 24091 RVA: 0x001B5784 File Offset: 0x001B3984
		// (set) Token: 0x06005E1C RID: 24092 RVA: 0x0002C1C4 File Offset: 0x0002A3C4
		public unsafe SyncVar<float> syncVar___debt
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Supplier.NativeFieldInfoPtr_syncVar___debt);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SyncVar<float>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Supplier.NativeFieldInfoPtr_syncVar___debt), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001C18 RID: 7192
		// (get) Token: 0x06005E1D RID: 24093 RVA: 0x001B57B4 File Offset: 0x001B39B4
		// (set) Token: 0x06005E1E RID: 24094 RVA: 0x0002C1E3 File Offset: 0x0002A3E3
		public unsafe SyncVar<bool> syncVar___deadDropPreparing
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Supplier.NativeFieldInfoPtr_syncVar___deadDropPreparing);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SyncVar<bool>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Supplier.NativeFieldInfoPtr_syncVar___deadDropPreparing), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001C19 RID: 7193
		// (get) Token: 0x06005E1F RID: 24095 RVA: 0x001B57E4 File Offset: 0x001B39E4
		// (set) Token: 0x06005E20 RID: 24096 RVA: 0x0002C202 File Offset: 0x0002A402
		public new unsafe bool field_Private_Boolean_0
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Supplier.NativeFieldInfoPtr_field_Private_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Supplier.NativeFieldInfoPtr_field_Private_Boolean_0)) = value;
			}
		}

		// Token: 0x17001C1A RID: 7194
		// (get) Token: 0x06005E21 RID: 24097 RVA: 0x001B580C File Offset: 0x001B3A0C
		// (set) Token: 0x06005E22 RID: 24098 RVA: 0x0002C21D File Offset: 0x0002A41D
		public new unsafe bool field_Private_Boolean_1
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Supplier.NativeFieldInfoPtr_field_Private_Boolean_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Supplier.NativeFieldInfoPtr_field_Private_Boolean_1)) = value;
			}
		}

		// Token: 0x04004002 RID: 16386
		private static readonly System.IntPtr NativeFieldInfoPtr_MEETUP_RELATIONSHIP_REQUIREMENT;

		// Token: 0x04004003 RID: 16387
		private static readonly System.IntPtr NativeFieldInfoPtr_MEETUP_DURATION_MINS;

		// Token: 0x04004004 RID: 16388
		private static readonly System.IntPtr NativeFieldInfoPtr_MEETING_COOLDOWN_MINS;

		// Token: 0x04004005 RID: 16389
		private static readonly System.IntPtr NativeFieldInfoPtr_DEADDROP_WAIT_PER_ITEM;

		// Token: 0x04004006 RID: 16390
		private static readonly System.IntPtr NativeFieldInfoPtr_DEADDROP_MAX_WAIT;

		// Token: 0x04004007 RID: 16391
		private static readonly System.IntPtr NativeFieldInfoPtr_DEADDROP_ITEM_LIMIT;

		// Token: 0x04004008 RID: 16392
		private static readonly System.IntPtr NativeFieldInfoPtr_DELIVERY_RELATIONSHIP_REQUIREMENT;

		// Token: 0x04004009 RID: 16393
		private static readonly System.IntPtr NativeFieldInfoPtr_SupplierLabelColor;

		// Token: 0x0400400A RID: 16394
		private static readonly System.IntPtr NativeFieldInfoPtr__Status_k__BackingField;

		// Token: 0x0400400B RID: 16395
		private static readonly System.IntPtr NativeFieldInfoPtr__DeliveriesEnabled_k__BackingField;

		// Token: 0x0400400C RID: 16396
		private static readonly System.IntPtr NativeFieldInfoPtr_MinOrderLimit;

		// Token: 0x0400400D RID: 16397
		private static readonly System.IntPtr NativeFieldInfoPtr_MaxOrderLimit;

		// Token: 0x0400400E RID: 16398
		private static readonly System.IntPtr NativeFieldInfoPtr_OnlineShopItems;

		// Token: 0x0400400F RID: 16399
		private static readonly System.IntPtr NativeFieldInfoPtr_SupplierRecommendMessage;

		// Token: 0x04004010 RID: 16400
		private static readonly System.IntPtr NativeFieldInfoPtr_SupplierUnlockHint;

		// Token: 0x04004011 RID: 16401
		private static readonly System.IntPtr NativeFieldInfoPtr_Shop;

		// Token: 0x04004012 RID: 16402
		private static readonly System.IntPtr NativeFieldInfoPtr_Stash;

		// Token: 0x04004013 RID: 16403
		private static readonly System.IntPtr NativeFieldInfoPtr_onDeaddropReady;

		// Token: 0x04004014 RID: 16404
		private static readonly System.IntPtr NativeFieldInfoPtr_minsSinceMeetingStart;

		// Token: 0x04004015 RID: 16405
		private static readonly System.IntPtr NativeFieldInfoPtr_minsSinceLastMeetingEnd;

		// Token: 0x04004016 RID: 16406
		private static readonly System.IntPtr NativeFieldInfoPtr_currentLocation;

		// Token: 0x04004017 RID: 16407
		private static readonly System.IntPtr NativeFieldInfoPtr_dialogueController;

		// Token: 0x04004018 RID: 16408
		private static readonly System.IntPtr NativeFieldInfoPtr_meetingGreeting;

		// Token: 0x04004019 RID: 16409
		private static readonly System.IntPtr NativeFieldInfoPtr_meetingChoice;

		// Token: 0x0400401A RID: 16410
		private static readonly System.IntPtr NativeFieldInfoPtr_debt;

		// Token: 0x0400401B RID: 16411
		private static readonly System.IntPtr NativeFieldInfoPtr_deadDropPreparing;

		// Token: 0x0400401C RID: 16412
		private static readonly System.IntPtr NativeFieldInfoPtr__minsUntilDeaddropReady_k__BackingField;

		// Token: 0x0400401D RID: 16413
		private static readonly System.IntPtr NativeFieldInfoPtr_deaddropItems;

		// Token: 0x0400401E RID: 16414
		private static readonly System.IntPtr NativeFieldInfoPtr_minsSinceDeaddropOrder;

		// Token: 0x0400401F RID: 16415
		private static readonly System.IntPtr NativeFieldInfoPtr_repaymentReminderSent;

		// Token: 0x04004020 RID: 16416
		private static readonly System.IntPtr NativeFieldInfoPtr_syncVar___debt;

		// Token: 0x04004021 RID: 16417
		private static readonly System.IntPtr NativeFieldInfoPtr_syncVar___deadDropPreparing;

		// Token: 0x04004022 RID: 16418
		private static readonly System.IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

		// Token: 0x04004023 RID: 16419
		private static readonly System.IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

		// Token: 0x04004024 RID: 16420
		private static readonly System.IntPtr NativeMethodInfoPtr_get_Status_Public_get_ESupplierStatus_0;

		// Token: 0x04004025 RID: 16421
		private static readonly System.IntPtr NativeMethodInfoPtr_set_Status_Private_set_Void_ESupplierStatus_0;

		// Token: 0x04004026 RID: 16422
		private static readonly System.IntPtr NativeMethodInfoPtr_get_DeliveriesEnabled_Public_get_Boolean_0;

		// Token: 0x04004027 RID: 16423
		private static readonly System.IntPtr NativeMethodInfoPtr_set_DeliveriesEnabled_Private_set_Void_Boolean_0;

		// Token: 0x04004028 RID: 16424
		private static readonly System.IntPtr NativeMethodInfoPtr_get_Debt_Public_get_Single_0;

		// Token: 0x04004029 RID: 16425
		private static readonly System.IntPtr NativeMethodInfoPtr_get_minsUntilDeaddropReady_Public_get_Int32_0;

		// Token: 0x0400402A RID: 16426
		private static readonly System.IntPtr NativeMethodInfoPtr_set_minsUntilDeaddropReady_Private_set_Void_Int32_0;

		// Token: 0x0400402B RID: 16427
		private static readonly System.IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;

		// Token: 0x0400402C RID: 16428
		private static readonly System.IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_1;

		// Token: 0x0400402D RID: 16429
		private static readonly System.IntPtr NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0;

		// Token: 0x0400402E RID: 16430
		private static readonly System.IntPtr NativeMethodInfoPtr_SendUnlocked_Public_Void_0;

		// Token: 0x0400402F RID: 16431
		private static readonly System.IntPtr NativeMethodInfoPtr_SetUnlocked_Private_Void_0;

		// Token: 0x04004030 RID: 16432
		private static readonly System.IntPtr NativeMethodInfoPtr_MinPass_Protected_Virtual_Void_1;

		// Token: 0x04004031 RID: 16433
		private static readonly System.IntPtr NativeMethodInfoPtr_HourPass_Protected_Void_0;

		// Token: 0x04004032 RID: 16434
		private static readonly System.IntPtr NativeMethodInfoPtr_OnTimeSkip_Private_Void_Int32_0;

		// Token: 0x04004033 RID: 16435
		private static readonly System.IntPtr NativeMethodInfoPtr_MeetAtLocation_Public_Void_NetworkConnection_Int32_Int32_0;

		// Token: 0x04004034 RID: 16436
		private static readonly System.IntPtr NativeMethodInfoPtr_EndMeeting_Public_Void_0;

		// Token: 0x04004035 RID: 16437
		private static readonly System.IntPtr NativeMethodInfoPtr_SupplierUnlocked_Protected_Virtual_New_Void_EUnlockType_Boolean_0;

		// Token: 0x04004036 RID: 16438
		private static readonly System.IntPtr NativeMethodInfoPtr_RelationshipChange_Protected_Virtual_New_Void_Single_0;

		// Token: 0x04004037 RID: 16439
		private static readonly System.IntPtr NativeMethodInfoPtr_EnableDeliveries_Private_Void_NetworkConnection_0;

		// Token: 0x04004038 RID: 16440
		private static readonly System.IntPtr NativeMethodInfoPtr_SetUnlockMessage_Public_Void_0;

		// Token: 0x04004039 RID: 16441
		private static readonly System.IntPtr NativeMethodInfoPtr_CreateMessageConversation_Protected_Virtual_Void_1;

		// Token: 0x0400403A RID: 16442
		private static readonly System.IntPtr NativeMethodInfoPtr_DeaddropRequested_Protected_Virtual_New_Void_0;

		// Token: 0x0400403B RID: 16443
		private static readonly System.IntPtr NativeMethodInfoPtr_DeaddropConfirmed_Protected_Virtual_New_Void_List_1_CartEntry_Single_0;

		// Token: 0x0400403C RID: 16444
		private static readonly System.IntPtr NativeMethodInfoPtr_SetDeaddrop_Private_Void_Il2CppReferenceArray_1_StringIntPair_Int32_0;

		// Token: 0x0400403D RID: 16445
		private static readonly System.IntPtr NativeMethodInfoPtr_ChangeDebt_Private_Void_Single_0;

		// Token: 0x0400403E RID: 16446
		private static readonly System.IntPtr NativeMethodInfoPtr_TryRecoverDebt_Private_Void_0;

		// Token: 0x0400403F RID: 16447
		private static readonly System.IntPtr NativeMethodInfoPtr_CompleteDeaddrop_Private_Void_0;

		// Token: 0x04004040 RID: 16448
		private static readonly System.IntPtr NativeMethodInfoPtr_SendDebtReminder_Private_Void_0;

		// Token: 0x04004041 RID: 16449
		private static readonly System.IntPtr NativeMethodInfoPtr_MeetupRequested_Protected_Virtual_New_Void_0;

		// Token: 0x04004042 RID: 16450
		private static readonly System.IntPtr NativeMethodInfoPtr_PayDebtRequested_Protected_Virtual_New_Void_0;

		// Token: 0x04004043 RID: 16451
		private static readonly System.IntPtr NativeMethodInfoPtr_GetAppropriateLocation_Protected_SupplierLocation_byref_Int32_0;

		// Token: 0x04004044 RID: 16452
		private static readonly System.IntPtr NativeMethodInfoPtr_IsDeadDropValid_Private_Boolean_SendableMessage_byref_String_0;

		// Token: 0x04004045 RID: 16453
		private static readonly System.IntPtr NativeMethodInfoPtr_IsMeetupValid_Private_Boolean_SendableMessage_byref_String_0;

		// Token: 0x04004046 RID: 16454
		private static readonly System.IntPtr NativeMethodInfoPtr_GetDeadDropLimit_Public_Virtual_New_Single_0;

		// Token: 0x04004047 RID: 16455
		private static readonly System.IntPtr NativeMethodInfoPtr_GetNPCData_Public_Virtual_NPCData_0;

		// Token: 0x04004048 RID: 16456
		private static readonly System.IntPtr NativeMethodInfoPtr_Load_Public_Virtual_Void_NPCData_String_0;

		// Token: 0x04004049 RID: 16457
		private static readonly System.IntPtr NativeMethodInfoPtr_Load_Public_Virtual_Void_DynamicSaveData_NPCData_0;

		// Token: 0x0400404A RID: 16458
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400404B RID: 16459
		private static readonly System.IntPtr NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0;

		// Token: 0x0400404C RID: 16460
		private static readonly System.IntPtr NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_1;

		// Token: 0x0400404D RID: 16461
		private static readonly System.IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

		// Token: 0x0400404E RID: 16462
		private static readonly System.IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

		// Token: 0x0400404F RID: 16463
		private static readonly System.IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

		// Token: 0x04004050 RID: 16464
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcWriter___Server_SendUnlocked_2166136261_Private_Void_0;

		// Token: 0x04004051 RID: 16465
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcLogic___SendUnlocked_2166136261_Public_Void_0;

		// Token: 0x04004052 RID: 16466
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcReader___Server_SendUnlocked_2166136261_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x04004053 RID: 16467
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcWriter___Observers_SetUnlocked_2166136261_Private_Void_0;

		// Token: 0x04004054 RID: 16468
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcLogic___SetUnlocked_2166136261_Private_Void_0;

		// Token: 0x04004055 RID: 16469
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcReader___Observers_SetUnlocked_2166136261_Private_Void_PooledReader_Channel_0;

		// Token: 0x04004056 RID: 16470
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcWriter___Observers_MeetAtLocation_3470796954_Private_Void_NetworkConnection_Int32_Int32_0;

		// Token: 0x04004057 RID: 16471
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcLogic___MeetAtLocation_3470796954_Public_Void_NetworkConnection_Int32_Int32_0;

		// Token: 0x04004058 RID: 16472
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcReader___Observers_MeetAtLocation_3470796954_Private_Void_PooledReader_Channel_0;

		// Token: 0x04004059 RID: 16473
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcWriter___Observers_EnableDeliveries_328543758_Private_Void_NetworkConnection_0;

		// Token: 0x0400405A RID: 16474
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcLogic___EnableDeliveries_328543758_Private_Void_NetworkConnection_0;

		// Token: 0x0400405B RID: 16475
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcReader___Observers_EnableDeliveries_328543758_Private_Void_PooledReader_Channel_0;

		// Token: 0x0400405C RID: 16476
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcWriter___Target_EnableDeliveries_328543758_Private_Void_NetworkConnection_0;

		// Token: 0x0400405D RID: 16477
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcReader___Target_EnableDeliveries_328543758_Private_Void_PooledReader_Channel_0;

		// Token: 0x0400405E RID: 16478
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcWriter___Server_SetDeaddrop_3971994486_Private_Void_Il2CppReferenceArray_1_StringIntPair_Int32_0;

		// Token: 0x0400405F RID: 16479
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcLogic___SetDeaddrop_3971994486_Private_Void_Il2CppReferenceArray_1_StringIntPair_Int32_0;

		// Token: 0x04004060 RID: 16480
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcReader___Server_SetDeaddrop_3971994486_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x04004061 RID: 16481
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcWriter___Server_ChangeDebt_431000436_Private_Void_Single_0;

		// Token: 0x04004062 RID: 16482
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcLogic___ChangeDebt_431000436_Private_Void_Single_0;

		// Token: 0x04004063 RID: 16483
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcReader___Server_ChangeDebt_431000436_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x04004064 RID: 16484
		private static readonly System.IntPtr NativeMethodInfoPtr_sync___get_value_debt_Public_get_Single_0;

		// Token: 0x04004065 RID: 16485
		private static readonly System.IntPtr NativeMethodInfoPtr_sync___set_value_debt_Public_set_Void_Single_Boolean_0;

		// Token: 0x04004066 RID: 16486
		private static readonly System.IntPtr NativeMethodInfoPtr_ReadSyncVar___ScheduleOne_Economy_Supplier_Public_Virtual_Boolean_PooledReader_UInt32_Boolean_0;

		// Token: 0x04004067 RID: 16487
		private static readonly System.IntPtr NativeMethodInfoPtr_sync___get_value_deadDropPreparing_Public_get_Boolean_0;

		// Token: 0x04004068 RID: 16488
		private static readonly System.IntPtr NativeMethodInfoPtr_sync___set_value_deadDropPreparing_Public_set_Void_Boolean_Boolean_0;

		// Token: 0x04004069 RID: 16489
		private static readonly System.IntPtr NativeMethodInfoPtr_Method_Protected_Virtual_Void_0;

		// Token: 0x02000A37 RID: 2615
		[OriginalName("Assembly-CSharp.dll", "", "ESupplierStatus")]
		public enum ESupplierStatus
		{
			// Token: 0x04008E54 RID: 36436
			Idle,
			// Token: 0x04008E55 RID: 36437
			PreppingDeadDrop,
			// Token: 0x04008E56 RID: 36438
			Meeting
		}

		// Token: 0x02000A38 RID: 2616
		[ObfuscatedName("ScheduleOne.Economy.Supplier+<<EnableDeliveries>g__Wait|54_0>d")]
		public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSuVoObMoInVoBoOb0 : Il2CppSystem.Object
		{
			// Token: 0x0600D2A4 RID: 53924 RVA: 0x0032D998 File Offset: 0x0032BB98
			// Note: this type is marked as 'beforefieldinit'.
			static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSuVoObMoInVoBoOb0()
			{
				Il2CppClassPointerStore<Supplier.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSuVoObMoInVoBoOb0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Supplier>.NativeClassPtr, "<<EnableDeliveries>g__Wait|54_0>d");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Supplier.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSuVoObMoInVoBoOb0>.NativeClassPtr);
				Supplier.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSuVoObMoInVoBoOb0.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Supplier.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSuVoObMoInVoBoOb0>.NativeClassPtr, "<>1__state");
				Supplier.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSuVoObMoInVoBoOb0.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Supplier.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSuVoObMoInVoBoOb0>.NativeClassPtr, "<>2__current");
				Supplier.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSuVoObMoInVoBoOb0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Supplier.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSuVoObMoInVoBoOb0>.NativeClassPtr, "<>4__this");
				Supplier.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSuVoObMoInVoBoOb0.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Supplier.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSuVoObMoInVoBoOb0>.NativeClassPtr, 100675383);
				Supplier.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSuVoObMoInVoBoOb0.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Supplier.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSuVoObMoInVoBoOb0>.NativeClassPtr, 100675384);
				Supplier.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSuVoObMoInVoBoOb0.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Supplier.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSuVoObMoInVoBoOb0>.NativeClassPtr, 100675385);
				Supplier.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSuVoObMoInVoBoOb0.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Supplier.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSuVoObMoInVoBoOb0>.NativeClassPtr, 100675386);
				Supplier.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSuVoObMoInVoBoOb0.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Supplier.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSuVoObMoInVoBoOb0>.NativeClassPtr, 100675387);
				Supplier.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSuVoObMoInVoBoOb0.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Supplier.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSuVoObMoInVoBoOb0>.NativeClassPtr, 100675388);
			}

			// Token: 0x0600D2A5 RID: 53925 RVA: 0x0032DA78 File Offset: 0x0032BC78
			[CallerCount(54)]
			[CachedScanResults(RefRangeStart = 2646, RefRangeEnd = 2700, XrefRangeStart = 2646, XrefRangeEnd = 2700, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSuVoObMoInVoBoOb0(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Supplier.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSuVoObMoInVoBoOb0>.NativeClassPtr))
			{
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = ref <>1__state;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Supplier.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSuVoObMoInVoBoOb0.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600D2A6 RID: 53926 RVA: 0x0032DAC0 File Offset: 0x0032BCC0
			[CallerCount(14558)]
			[CachedScanResults(RefRangeStart = 2769, RefRangeEnd = 17327, XrefRangeStart = 2769, XrefRangeEnd = 17327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Supplier.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSuVoObMoInVoBoOb0.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600D2A7 RID: 53927 RVA: 0x0032DAF4 File Offset: 0x0032BCF4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 197847, XrefRangeEnd = 197868, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Supplier.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSuVoObMoInVoBoOb0.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x17004141 RID: 16705
			// (get) Token: 0x0600D2A8 RID: 53928 RVA: 0x0032DB30 File Offset: 0x0032BD30
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 2740, RefRangeEnd = 2764, XrefRangeStart = 2740, XrefRangeEnd = 2764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Supplier.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSuVoObMoInVoBoOb0.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
			}

			// Token: 0x0600D2A9 RID: 53929 RVA: 0x0032DB70 File Offset: 0x0032BD70
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 197868, XrefRangeEnd = 197873, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Supplier.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSuVoObMoInVoBoOb0.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x17004142 RID: 16706
			// (get) Token: 0x0600D2AA RID: 53930 RVA: 0x0032DBA4 File Offset: 0x0032BDA4
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 2740, RefRangeEnd = 2764, XrefRangeStart = 2740, XrefRangeEnd = 2764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Supplier.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSuVoObMoInVoBoOb0.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
			}

			// Token: 0x0600D2AB RID: 53931 RVA: 0x000661F3 File Offset: 0x000643F3
			public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSuVoObMoInVoBoOb0(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700413E RID: 16702
			// (get) Token: 0x0600D2AC RID: 53932 RVA: 0x0032DBE4 File Offset: 0x0032BDE4
			// (set) Token: 0x0600D2AD RID: 53933 RVA: 0x000661FC File Offset: 0x000643FC
			public unsafe int __1__state
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Supplier.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSuVoObMoInVoBoOb0.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Supplier.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSuVoObMoInVoBoOb0.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700413F RID: 16703
			// (get) Token: 0x0600D2AE RID: 53934 RVA: 0x0032DC0C File Offset: 0x0032BE0C
			// (set) Token: 0x0600D2AF RID: 53935 RVA: 0x00066217 File Offset: 0x00064417
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Supplier.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSuVoObMoInVoBoOb0.NativeFieldInfoPtr___2__current);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Supplier.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSuVoObMoInVoBoOb0.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004140 RID: 16704
			// (get) Token: 0x0600D2B0 RID: 53936 RVA: 0x0032DC3C File Offset: 0x0032BE3C
			// (set) Token: 0x0600D2B1 RID: 53937 RVA: 0x00066236 File Offset: 0x00064436
			public unsafe Supplier __4__this
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Supplier.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSuVoObMoInVoBoOb0.NativeFieldInfoPtr___4__this);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Supplier>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Supplier.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSuVoObMoInVoBoOb0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008E57 RID: 36439
			private static readonly System.IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04008E58 RID: 36440
			private static readonly System.IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04008E59 RID: 36441
			private static readonly System.IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04008E5A RID: 36442
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04008E5B RID: 36443
			private static readonly System.IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008E5C RID: 36444
			private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04008E5D RID: 36445
			private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04008E5E RID: 36446
			private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008E5F RID: 36447
			private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x02000A39 RID: 2617
		[ObfuscatedName("ScheduleOne.Economy.Supplier+<<SupplierUnlocked>g__WaitForPlayer|52_0>d")]
		public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSuVoObMoInVoBoOb1 : Il2CppSystem.Object
		{
			// Token: 0x0600D2B2 RID: 53938 RVA: 0x0032DC6C File Offset: 0x0032BE6C
			// Note: this type is marked as 'beforefieldinit'.
			static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSuVoObMoInVoBoOb1()
			{
				Il2CppClassPointerStore<Supplier.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSuVoObMoInVoBoOb1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Supplier>.NativeClassPtr, "<<SupplierUnlocked>g__WaitForPlayer|52_0>d");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Supplier.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSuVoObMoInVoBoOb1>.NativeClassPtr);
				Supplier.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSuVoObMoInVoBoOb1.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Supplier.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSuVoObMoInVoBoOb1>.NativeClassPtr, "<>1__state");
				Supplier.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSuVoObMoInVoBoOb1.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Supplier.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSuVoObMoInVoBoOb1>.NativeClassPtr, "<>2__current");
				Supplier.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSuVoObMoInVoBoOb1.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Supplier.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSuVoObMoInVoBoOb1>.NativeClassPtr, "<>4__this");
				Supplier.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSuVoObMoInVoBoOb1.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Supplier.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSuVoObMoInVoBoOb1>.NativeClassPtr, 100675389);
				Supplier.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSuVoObMoInVoBoOb1.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Supplier.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSuVoObMoInVoBoOb1>.NativeClassPtr, 100675390);
				Supplier.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSuVoObMoInVoBoOb1.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Supplier.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSuVoObMoInVoBoOb1>.NativeClassPtr, 100675391);
				Supplier.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSuVoObMoInVoBoOb1.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Supplier.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSuVoObMoInVoBoOb1>.NativeClassPtr, 100675392);
				Supplier.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSuVoObMoInVoBoOb1.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Supplier.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSuVoObMoInVoBoOb1>.NativeClassPtr, 100675393);
				Supplier.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSuVoObMoInVoBoOb1.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Supplier.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSuVoObMoInVoBoOb1>.NativeClassPtr, 100675394);
			}

			// Token: 0x0600D2B3 RID: 53939 RVA: 0x0032DD4C File Offset: 0x0032BF4C
			[CallerCount(54)]
			[CachedScanResults(RefRangeStart = 2646, RefRangeEnd = 2700, XrefRangeStart = 2646, XrefRangeEnd = 2700, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSuVoObMoInVoBoOb1(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Supplier.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSuVoObMoInVoBoOb1>.NativeClassPtr))
			{
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = ref <>1__state;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Supplier.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSuVoObMoInVoBoOb1.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600D2B4 RID: 53940 RVA: 0x0032DD94 File Offset: 0x0032BF94
			[CallerCount(14558)]
			[CachedScanResults(RefRangeStart = 2769, RefRangeEnd = 17327, XrefRangeStart = 2769, XrefRangeEnd = 17327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Supplier.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSuVoObMoInVoBoOb1.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600D2B5 RID: 53941 RVA: 0x0032DDC8 File Offset: 0x0032BFC8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 197873, XrefRangeEnd = 197893, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Supplier.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSuVoObMoInVoBoOb1.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x17004146 RID: 16710
			// (get) Token: 0x0600D2B6 RID: 53942 RVA: 0x0032DE04 File Offset: 0x0032C004
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 2740, RefRangeEnd = 2764, XrefRangeStart = 2740, XrefRangeEnd = 2764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Supplier.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSuVoObMoInVoBoOb1.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
			}

			// Token: 0x0600D2B7 RID: 53943 RVA: 0x0032DE44 File Offset: 0x0032C044
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 197893, XrefRangeEnd = 197898, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Supplier.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSuVoObMoInVoBoOb1.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x17004147 RID: 16711
			// (get) Token: 0x0600D2B8 RID: 53944 RVA: 0x0032DE78 File Offset: 0x0032C078
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 2740, RefRangeEnd = 2764, XrefRangeStart = 2740, XrefRangeEnd = 2764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Supplier.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSuVoObMoInVoBoOb1.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
			}

			// Token: 0x0600D2B9 RID: 53945 RVA: 0x00066255 File Offset: 0x00064455
			public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSuVoObMoInVoBoOb1(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004143 RID: 16707
			// (get) Token: 0x0600D2BA RID: 53946 RVA: 0x0032DEB8 File Offset: 0x0032C0B8
			// (set) Token: 0x0600D2BB RID: 53947 RVA: 0x0006625E File Offset: 0x0006445E
			public unsafe int __1__state
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Supplier.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSuVoObMoInVoBoOb1.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Supplier.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSuVoObMoInVoBoOb1.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17004144 RID: 16708
			// (get) Token: 0x0600D2BC RID: 53948 RVA: 0x0032DEE0 File Offset: 0x0032C0E0
			// (set) Token: 0x0600D2BD RID: 53949 RVA: 0x00066279 File Offset: 0x00064479
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Supplier.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSuVoObMoInVoBoOb1.NativeFieldInfoPtr___2__current);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Supplier.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSuVoObMoInVoBoOb1.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004145 RID: 16709
			// (get) Token: 0x0600D2BE RID: 53950 RVA: 0x0032DF10 File Offset: 0x0032C110
			// (set) Token: 0x0600D2BF RID: 53951 RVA: 0x00066298 File Offset: 0x00064498
			public unsafe Supplier __4__this
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Supplier.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSuVoObMoInVoBoOb1.NativeFieldInfoPtr___4__this);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Supplier>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Supplier.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSuVoObMoInVoBoOb1.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008E60 RID: 36448
			private static readonly System.IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04008E61 RID: 36449
			private static readonly System.IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04008E62 RID: 36450
			private static readonly System.IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04008E63 RID: 36451
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04008E64 RID: 36452
			private static readonly System.IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008E65 RID: 36453
			private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04008E66 RID: 36454
			private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04008E67 RID: 36455
			private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008E68 RID: 36456
			private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x02000A3A RID: 2618
		[ObfuscatedName("ScheduleOne.Economy.Supplier+<>c")]
		[System.Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x0600D2C0 RID: 53952 RVA: 0x0032DF40 File Offset: 0x0032C140
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<Supplier.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Supplier>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Supplier.__c>.NativeClassPtr);
				Supplier.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Supplier.__c>.NativeClassPtr, "<>9");
				Supplier.__c.NativeFieldInfoPtr___9__52_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Supplier.__c>.NativeClassPtr, "<>9__52_1");
				Supplier.__c.NativeFieldInfoPtr___9__54_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Supplier.__c>.NativeClassPtr, "<>9__54_1");
				Supplier.__c.NativeFieldInfoPtr___9__58_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Supplier.__c>.NativeClassPtr, "<>9__58_0");
				Supplier.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Supplier.__c>.NativeClassPtr, 100675396);
				Supplier.__c.NativeMethodInfoPtr__SupplierUnlocked_b__52_1_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Supplier.__c>.NativeClassPtr, 100675397);
				Supplier.__c.NativeMethodInfoPtr__EnableDeliveries_b__54_1_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Supplier.__c>.NativeClassPtr, 100675398);
				Supplier.__c.NativeMethodInfoPtr__DeaddropConfirmed_b__58_0_Internal_Int32_CartEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Supplier.__c>.NativeClassPtr, 100675399);
			}

			// Token: 0x0600D2C1 RID: 53953 RVA: 0x0032E00C File Offset: 0x0032C20C
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Supplier.__c>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Supplier.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600D2C2 RID: 53954 RVA: 0x0032E048 File Offset: 0x0032C248
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 197898, XrefRangeEnd = 197906, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _SupplierUnlocked_b__52_1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Supplier.__c.NativeMethodInfoPtr__SupplierUnlocked_b__52_1_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x0600D2C3 RID: 53955 RVA: 0x0032E084 File Offset: 0x0032C284
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 197906, XrefRangeEnd = 197909, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _EnableDeliveries_b__54_1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Supplier.__c.NativeMethodInfoPtr__EnableDeliveries_b__54_1_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x0600D2C4 RID: 53956 RVA: 0x0032E0C0 File Offset: 0x0032C2C0
			[CallerCount(0)]
			public unsafe int _DeaddropConfirmed_b__58_0(PhoneShopInterface.CartEntry x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Supplier.__c.NativeMethodInfoPtr__DeaddropConfirmed_b__58_0_Internal_Int32_CartEntry_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x0600D2C5 RID: 53957 RVA: 0x000662B7 File Offset: 0x000644B7
			public __c(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004148 RID: 16712
			// (get) Token: 0x0600D2C6 RID: 53958 RVA: 0x0032E110 File Offset: 0x0032C310
			// (set) Token: 0x0600D2C7 RID: 53959 RVA: 0x000662C0 File Offset: 0x000644C0
			public unsafe static Supplier.__c __9
			{
				get
				{
					System.IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Supplier.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Supplier.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Supplier.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004149 RID: 16713
			// (get) Token: 0x0600D2C8 RID: 53960 RVA: 0x0032E138 File Offset: 0x0032C338
			// (set) Token: 0x0600D2C9 RID: 53961 RVA: 0x000662D2 File Offset: 0x000644D2
			public unsafe static Il2CppSystem.Func<bool> __9__52_1
			{
				get
				{
					System.IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Supplier.__c.NativeFieldInfoPtr___9__52_1, (void*)(&intPtr));
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Func<bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Supplier.__c.NativeFieldInfoPtr___9__52_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700414A RID: 16714
			// (get) Token: 0x0600D2CA RID: 53962 RVA: 0x0032E160 File Offset: 0x0032C360
			// (set) Token: 0x0600D2CB RID: 53963 RVA: 0x000662E4 File Offset: 0x000644E4
			public unsafe static Il2CppSystem.Func<bool> __9__54_1
			{
				get
				{
					System.IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Supplier.__c.NativeFieldInfoPtr___9__54_1, (void*)(&intPtr));
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Func<bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Supplier.__c.NativeFieldInfoPtr___9__54_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700414B RID: 16715
			// (get) Token: 0x0600D2CC RID: 53964 RVA: 0x0032E188 File Offset: 0x0032C388
			// (set) Token: 0x0600D2CD RID: 53965 RVA: 0x000662F6 File Offset: 0x000644F6
			public unsafe static Il2CppSystem.Func<PhoneShopInterface.CartEntry, int> __9__58_0
			{
				get
				{
					System.IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Supplier.__c.NativeFieldInfoPtr___9__58_0, (void*)(&intPtr));
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Func<PhoneShopInterface.CartEntry, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Supplier.__c.NativeFieldInfoPtr___9__58_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008E69 RID: 36457
			private static readonly System.IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04008E6A RID: 36458
			private static readonly System.IntPtr NativeFieldInfoPtr___9__52_1;

			// Token: 0x04008E6B RID: 36459
			private static readonly System.IntPtr NativeFieldInfoPtr___9__54_1;

			// Token: 0x04008E6C RID: 36460
			private static readonly System.IntPtr NativeFieldInfoPtr___9__58_0;

			// Token: 0x04008E6D RID: 36461
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008E6E RID: 36462
			private static readonly System.IntPtr NativeMethodInfoPtr__SupplierUnlocked_b__52_1_Internal_Boolean_0;

			// Token: 0x04008E6F RID: 36463
			private static readonly System.IntPtr NativeMethodInfoPtr__EnableDeliveries_b__54_1_Internal_Boolean_0;

			// Token: 0x04008E70 RID: 36464
			private static readonly System.IntPtr NativeMethodInfoPtr__DeaddropConfirmed_b__58_0_Internal_Int32_CartEntry_0;
		}

		// Token: 0x02000A3B RID: 2619
		[ObfuscatedName("ScheduleOne.Economy.Supplier+<>c__DisplayClass43_0")]
		public sealed class __c__DisplayClass43_0 : Il2CppSystem.Object
		{
			// Token: 0x0600D2CE RID: 53966 RVA: 0x0032E1B0 File Offset: 0x0032C3B0
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass43_0()
			{
				Il2CppClassPointerStore<Supplier.__c__DisplayClass43_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Supplier>.NativeClassPtr, "<>c__DisplayClass43_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Supplier.__c__DisplayClass43_0>.NativeClassPtr);
				Supplier.__c__DisplayClass43_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Supplier.__c__DisplayClass43_0>.NativeClassPtr, "<>4__this");
				Supplier.__c__DisplayClass43_0.NativeFieldInfoPtr_orderCompleteDialogue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Supplier.__c__DisplayClass43_0>.NativeClassPtr, "orderCompleteDialogue");
				Supplier.__c__DisplayClass43_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Supplier.__c__DisplayClass43_0>.NativeClassPtr, 100675400);
				Supplier.__c__DisplayClass43_0.NativeMethodInfoPtr__Start_b__0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Supplier.__c__DisplayClass43_0>.NativeClassPtr, 100675401);
				Supplier.__c__DisplayClass43_0.NativeMethodInfoPtr__Start_b__1_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Supplier.__c__DisplayClass43_0>.NativeClassPtr, 100675402);
			}

			// Token: 0x0600D2CF RID: 53967 RVA: 0x0032E240 File Offset: 0x0032C440
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass43_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Supplier.__c__DisplayClass43_0>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Supplier.__c__DisplayClass43_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600D2D0 RID: 53968 RVA: 0x0032E27C File Offset: 0x0032C47C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 197909, XrefRangeEnd = 197910, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _Start_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Supplier.__c__DisplayClass43_0.NativeMethodInfoPtr__Start_b__0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600D2D1 RID: 53969 RVA: 0x0032E2B0 File Offset: 0x0032C4B0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 197910, XrefRangeEnd = 197911, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _Start_b__1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Supplier.__c__DisplayClass43_0.NativeMethodInfoPtr__Start_b__1_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600D2D2 RID: 53970 RVA: 0x00066308 File Offset: 0x00064508
			public __c__DisplayClass43_0(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700414C RID: 16716
			// (get) Token: 0x0600D2D3 RID: 53971 RVA: 0x0032E2E4 File Offset: 0x0032C4E4
			// (set) Token: 0x0600D2D4 RID: 53972 RVA: 0x00066311 File Offset: 0x00064511
			public unsafe Supplier __4__this
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Supplier.__c__DisplayClass43_0.NativeFieldInfoPtr___4__this);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Supplier>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Supplier.__c__DisplayClass43_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700414D RID: 16717
			// (get) Token: 0x0600D2D5 RID: 53973 RVA: 0x0032E314 File Offset: 0x0032C514
			// (set) Token: 0x0600D2D6 RID: 53974 RVA: 0x00066330 File Offset: 0x00064530
			public unsafe string orderCompleteDialogue
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Supplier.__c__DisplayClass43_0.NativeFieldInfoPtr_orderCompleteDialogue);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Supplier.__c__DisplayClass43_0.NativeFieldInfoPtr_orderCompleteDialogue), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x04008E71 RID: 36465
			private static readonly System.IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04008E72 RID: 36466
			private static readonly System.IntPtr NativeFieldInfoPtr_orderCompleteDialogue;

			// Token: 0x04008E73 RID: 36467
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008E74 RID: 36468
			private static readonly System.IntPtr NativeMethodInfoPtr__Start_b__0_Internal_Void_0;

			// Token: 0x04008E75 RID: 36469
			private static readonly System.IntPtr NativeMethodInfoPtr__Start_b__1_Internal_Void_0;
		}
	}
}
