using System;
using Il2CppFishNet.Connection;
using Il2CppFishNet.Object.Synchronizing;
using Il2CppFishNet.Serializing;
using Il2CppFishNet.Transporting;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Dialogue;
using Il2CppScheduleOne.Management;
using Il2CppScheduleOne.NPCs;
using Il2CppScheduleOne.NPCs.Behaviour;
using Il2CppScheduleOne.Persistence.Datas;
using Il2CppScheduleOne.PlayerScripts;
using Il2CppScheduleOne.Property;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.Employees
{
	// Token: 0x02000429 RID: 1065
	public class Employee : NPC
	{
		// Token: 0x06005945 RID: 22853 RVA: 0x001A20E4 File Offset: 0x001A02E4
		// Note: this type is marked as 'beforefieldinit'.
		static Employee()
		{
			Il2CppClassPointerStore<Employee>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Employees", "Employee");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Employee>.NativeClassPtr);
			Employee.NativeFieldInfoPtr_MAX_CONSECUTIVE_PATHING_FAILURES = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Employee>.NativeClassPtr, "MAX_CONSECUTIVE_PATHING_FAILURES");
			Employee.NativeFieldInfoPtr_DEBUG = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Employee>.NativeClassPtr, "DEBUG");
			Employee.NativeFieldInfoPtr__AssignedProperty_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Employee>.NativeClassPtr, "<AssignedProperty>k__BackingField");
			Employee.NativeFieldInfoPtr__EmployeeIndex_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Employee>.NativeClassPtr, "<EmployeeIndex>k__BackingField");
			Employee.NativeFieldInfoPtr__PaidForToday_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Employee>.NativeClassPtr, "<PaidForToday>k__BackingField");
			Employee.NativeFieldInfoPtr__Fired_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Employee>.NativeClassPtr, "<Fired>k__BackingField");
			Employee.NativeFieldInfoPtr__IsMale_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Employee>.NativeClassPtr, "<IsMale>k__BackingField");
			Employee.NativeFieldInfoPtr__AppearanceIndex_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Employee>.NativeClassPtr, "<AppearanceIndex>k__BackingField");
			Employee.NativeFieldInfoPtr_Type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Employee>.NativeClassPtr, "Type");
			Employee.NativeFieldInfoPtr_SigningFee = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Employee>.NativeClassPtr, "SigningFee");
			Employee.NativeFieldInfoPtr_DailyWage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Employee>.NativeClassPtr, "DailyWage");
			Employee.NativeFieldInfoPtr_WaitOutside = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Employee>.NativeClassPtr, "WaitOutside");
			Employee.NativeFieldInfoPtr_MoveItemBehaviour = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Employee>.NativeClassPtr, "MoveItemBehaviour");
			Employee.NativeFieldInfoPtr_BedNotAssignedDialogue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Employee>.NativeClassPtr, "BedNotAssignedDialogue");
			Employee.NativeFieldInfoPtr_NotPaidDialogue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Employee>.NativeClassPtr, "NotPaidDialogue");
			Employee.NativeFieldInfoPtr_WorkIssueDialogueTemplate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Employee>.NativeClassPtr, "WorkIssueDialogueTemplate");
			Employee.NativeFieldInfoPtr_FireDialogue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Employee>.NativeClassPtr, "FireDialogue");
			Employee.NativeFieldInfoPtr_TransferDialogue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Employee>.NativeClassPtr, "TransferDialogue");
			Employee.NativeFieldInfoPtr_WorkIssues = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Employee>.NativeClassPtr, "WorkIssues");
			Employee.NativeFieldInfoPtr__TimeSinceLastWorked_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Employee>.NativeClassPtr, "<TimeSinceLastWorked>k__BackingField");
			Employee.NativeFieldInfoPtr_initialized = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Employee>.NativeClassPtr, "initialized");
			Employee.NativeFieldInfoPtr_consecutivePathingFailures = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Employee>.NativeClassPtr, "consecutivePathingFailures");
			Employee.NativeFieldInfoPtr_timeOnLastPathingFailure = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Employee>.NativeClassPtr, "timeOnLastPathingFailure");
			Employee.NativeFieldInfoPtr_cachedNPCSpawnPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Employee>.NativeClassPtr, "cachedNPCSpawnPoint");
			Employee.NativeFieldInfoPtr_syncVar____PaidForToday_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Employee>.NativeClassPtr, "syncVar___<PaidForToday>k__BackingField");
			Employee.NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Employee>.NativeClassPtr, "NetworkInitialize___EarlyScheduleOne.Employees.EmployeeAssembly-CSharp.dll_Excuted");
			Employee.NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Employee>.NativeClassPtr, "NetworkInitialize__LateScheduleOne.Employees.EmployeeAssembly-CSharp.dll_Excuted");
			Employee.NativeMethodInfoPtr_get_AssignedProperty_Public_get_Property_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Employee>.NativeClassPtr, 100674630);
			Employee.NativeMethodInfoPtr_set_AssignedProperty_Protected_set_Void_Property_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Employee>.NativeClassPtr, 100674631);
			Employee.NativeMethodInfoPtr_get_EmployeeIndex_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Employee>.NativeClassPtr, 100674632);
			Employee.NativeMethodInfoPtr_set_EmployeeIndex_Protected_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Employee>.NativeClassPtr, 100674633);
			Employee.NativeMethodInfoPtr_get_PaidForToday_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Employee>.NativeClassPtr, 100674634);
			Employee.NativeMethodInfoPtr_set_PaidForToday_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Employee>.NativeClassPtr, 100674635);
			Employee.NativeMethodInfoPtr_get_Fired_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Employee>.NativeClassPtr, 100674636);
			Employee.NativeMethodInfoPtr_set_Fired_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Employee>.NativeClassPtr, 100674637);
			Employee.NativeMethodInfoPtr_get_IsWaitingOutside_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Employee>.NativeClassPtr, 100674638);
			Employee.NativeMethodInfoPtr_get_IsMale_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Employee>.NativeClassPtr, 100674639);
			Employee.NativeMethodInfoPtr_set_IsMale_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Employee>.NativeClassPtr, 100674640);
			Employee.NativeMethodInfoPtr_get_AppearanceIndex_Protected_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Employee>.NativeClassPtr, 100674641);
			Employee.NativeMethodInfoPtr_set_AppearanceIndex_Private_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Employee>.NativeClassPtr, 100674642);
			Employee.NativeMethodInfoPtr_get_EmployeeType_Public_get_EEmployeeType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Employee>.NativeClassPtr, 100674643);
			Employee.NativeMethodInfoPtr_get_TimeSinceLastWorked_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Employee>.NativeClassPtr, 100674644);
			Employee.NativeMethodInfoPtr_set_TimeSinceLastWorked_Private_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Employee>.NativeClassPtr, 100674645);
			Employee.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Employee>.NativeClassPtr, 100674646);
			Employee.NativeMethodInfoPtr_OnStartServer_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Employee>.NativeClassPtr, 100674647);
			Employee.NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Employee>.NativeClassPtr, 100674648);
			Employee.NativeMethodInfoPtr_Initialize_Public_Virtual_New_Void_NetworkConnection_String_String_String_String_String_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Employee>.NativeClassPtr, 100674649);
			Employee.NativeMethodInfoPtr_AssignProperty_Protected_Virtual_New_Void_Property_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Employee>.NativeClassPtr, 100674650);
			Employee.NativeMethodInfoPtr_UnassignProperty_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Employee>.NativeClassPtr, 100674651);
			Employee.NativeMethodInfoPtr_SendTransfer_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Employee>.NativeClassPtr, 100674652);
			Employee.NativeMethodInfoPtr_TransferToProperty_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Employee>.NativeClassPtr, 100674653);
			Employee.NativeMethodInfoPtr_TransferToProperty_Protected_Virtual_New_Void_Property_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Employee>.NativeClassPtr, 100674654);
			Employee.NativeMethodInfoPtr_InitializeInfo_Protected_Virtual_New_Void_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Employee>.NativeClassPtr, 100674655);
			Employee.NativeMethodInfoPtr_InitializeAppearance_Protected_Virtual_New_Void_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Employee>.NativeClassPtr, 100674656);
			Employee.NativeMethodInfoPtr_CheckDialogueChoice_Protected_Virtual_New_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Employee>.NativeClassPtr, 100674657);
			Employee.NativeMethodInfoPtr_SendFire_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Employee>.NativeClassPtr, 100674658);
			Employee.NativeMethodInfoPtr_ReceiveFire_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Employee>.NativeClassPtr, 100674659);
			Employee.NativeMethodInfoPtr_ResetConfiguration_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Employee>.NativeClassPtr, 100674660);
			Employee.NativeMethodInfoPtr_Fire_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Employee>.NativeClassPtr, 100674661);
			Employee.NativeMethodInfoPtr_CanWork_Protected_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Employee>.NativeClassPtr, 100674662);
			Employee.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Employee>.NativeClassPtr, 100674663);
			Employee.NativeMethodInfoPtr_UpdateBehaviour_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Employee>.NativeClassPtr, 100674664);
			Employee.NativeMethodInfoPtr_MarkIsWorking_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Employee>.NativeClassPtr, 100674665);
			Employee.NativeMethodInfoPtr_SetWaitOutside_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Employee>.NativeClassPtr, 100674666);
			Employee.NativeMethodInfoPtr_ShouldIdle_Protected_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Employee>.NativeClassPtr, 100674667);
			Employee.NativeMethodInfoPtr_ShouldNoticeGeneralCrime_Protected_Virtual_Boolean_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Employee>.NativeClassPtr, 100674668);
			Employee.NativeMethodInfoPtr_MinPass_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Employee>.NativeClassPtr, 100674669);
			Employee.NativeMethodInfoPtr_OnSleepEnd_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Employee>.NativeClassPtr, 100674670);
			Employee.NativeMethodInfoPtr_SetIsPaid_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Employee>.NativeClassPtr, 100674671);
			Employee.NativeMethodInfoPtr_ShouldSave_Public_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Employee>.NativeClassPtr, 100674672);
			Employee.NativeMethodInfoPtr_GetNPCData_Public_Virtual_NPCData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Employee>.NativeClassPtr, 100674673);
			Employee.NativeMethodInfoPtr_GetHome_Public_Virtual_New_EmployeeHome_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Employee>.NativeClassPtr, 100674674);
			Employee.NativeMethodInfoPtr_IsPayAvailable_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Employee>.NativeClassPtr, 100674675);
			Employee.NativeMethodInfoPtr_RemoveDailyWage_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Employee>.NativeClassPtr, 100674676);
			Employee.NativeMethodInfoPtr_GetWorkIssue_Public_Virtual_New_Boolean_byref_DialogueContainer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Employee>.NativeClassPtr, 100674677);
			Employee.NativeMethodInfoPtr_SetIdle_Public_Virtual_New_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Employee>.NativeClassPtr, 100674678);
			Employee.NativeMethodInfoPtr_LeavePropertyAndDespawn_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Employee>.NativeClassPtr, 100674679);
			Employee.NativeMethodInfoPtr_SubmitNoWorkReason_Public_Void_String_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Employee>.NativeClassPtr, 100674680);
			Employee.NativeMethodInfoPtr_ShouldShowNoWorkDialogue_Private_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Employee>.NativeClassPtr, 100674681);
			Employee.NativeMethodInfoPtr_OnNotWorkingDialogue_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Employee>.NativeClassPtr, 100674682);
			Employee.NativeMethodInfoPtr_ShouldShowFireDialogue_Private_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Employee>.NativeClassPtr, 100674683);
			Employee.NativeMethodInfoPtr_TradeItems_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Employee>.NativeClassPtr, 100674684);
			Employee.NativeMethodInfoPtr_TradeItemsDone_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Employee>.NativeClassPtr, 100674685);
			Employee.NativeMethodInfoPtr_SetDestination_Protected_Void_ITransitEntity_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Employee>.NativeClassPtr, 100674686);
			Employee.NativeMethodInfoPtr_SetDestination_Protected_Void_Vector3_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Employee>.NativeClassPtr, 100674687);
			Employee.NativeMethodInfoPtr_WalkCallback_Protected_Virtual_New_Void_WalkResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Employee>.NativeClassPtr, 100674688);
			Employee.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Employee>.NativeClassPtr, 100674689);
			Employee.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Employee>.NativeClassPtr, 100674690);
			Employee.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Employee>.NativeClassPtr, 100674691);
			Employee.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Employee>.NativeClassPtr, 100674692);
			Employee.NativeMethodInfoPtr_RpcWriter___Observers_Initialize_2260823878_Private_Void_NetworkConnection_String_String_String_String_String_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Employee>.NativeClassPtr, 100674693);
			Employee.NativeMethodInfoPtr_RpcLogic___Initialize_2260823878_Public_Virtual_New_Void_NetworkConnection_String_String_String_String_String_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Employee>.NativeClassPtr, 100674694);
			Employee.NativeMethodInfoPtr_RpcReader___Observers_Initialize_2260823878_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Employee>.NativeClassPtr, 100674695);
			Employee.NativeMethodInfoPtr_RpcWriter___Target_Initialize_2260823878_Private_Void_NetworkConnection_String_String_String_String_String_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Employee>.NativeClassPtr, 100674696);
			Employee.NativeMethodInfoPtr_RpcReader___Target_Initialize_2260823878_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Employee>.NativeClassPtr, 100674697);
			Employee.NativeMethodInfoPtr_RpcWriter___Server_SendTransfer_3615296227_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Employee>.NativeClassPtr, 100674698);
			Employee.NativeMethodInfoPtr_RpcLogic___SendTransfer_3615296227_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Employee>.NativeClassPtr, 100674699);
			Employee.NativeMethodInfoPtr_RpcReader___Server_SendTransfer_3615296227_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Employee>.NativeClassPtr, 100674700);
			Employee.NativeMethodInfoPtr_RpcWriter___Observers_TransferToProperty_3615296227_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Employee>.NativeClassPtr, 100674701);
			Employee.NativeMethodInfoPtr_RpcLogic___TransferToProperty_3615296227_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Employee>.NativeClassPtr, 100674702);
			Employee.NativeMethodInfoPtr_RpcReader___Observers_TransferToProperty_3615296227_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Employee>.NativeClassPtr, 100674703);
			Employee.NativeMethodInfoPtr_RpcWriter___Server_SendFire_2166136261_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Employee>.NativeClassPtr, 100674704);
			Employee.NativeMethodInfoPtr_RpcLogic___SendFire_2166136261_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Employee>.NativeClassPtr, 100674705);
			Employee.NativeMethodInfoPtr_RpcReader___Server_SendFire_2166136261_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Employee>.NativeClassPtr, 100674706);
			Employee.NativeMethodInfoPtr_RpcWriter___Observers_ReceiveFire_2166136261_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Employee>.NativeClassPtr, 100674707);
			Employee.NativeMethodInfoPtr_RpcLogic___ReceiveFire_2166136261_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Employee>.NativeClassPtr, 100674708);
			Employee.NativeMethodInfoPtr_RpcReader___Observers_ReceiveFire_2166136261_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Employee>.NativeClassPtr, 100674709);
			Employee.NativeMethodInfoPtr_RpcWriter___Observers_SubmitNoWorkReason_15643032_Private_Void_String_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Employee>.NativeClassPtr, 100674710);
			Employee.NativeMethodInfoPtr_RpcLogic___SubmitNoWorkReason_15643032_Public_Void_String_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Employee>.NativeClassPtr, 100674711);
			Employee.NativeMethodInfoPtr_RpcReader___Observers_SubmitNoWorkReason_15643032_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Employee>.NativeClassPtr, 100674712);
			Employee.NativeMethodInfoPtr_sync___get_value__PaidForToday_k__BackingField_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Employee>.NativeClassPtr, 100674713);
			Employee.NativeMethodInfoPtr_sync___set_value__PaidForToday_k__BackingField_Public_set_Void_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Employee>.NativeClassPtr, 100674714);
			Employee.NativeMethodInfoPtr_ReadSyncVar___ScheduleOne_Employees_Employee_Public_Virtual_Boolean_PooledReader_UInt32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Employee>.NativeClassPtr, 100674715);
			Employee.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Employee>.NativeClassPtr, 100674716);
		}

		// Token: 0x17001AE6 RID: 6886
		// (get) Token: 0x06005946 RID: 22854 RVA: 0x001A29FC File Offset: 0x001A0BFC
		// (set) Token: 0x06005947 RID: 22855 RVA: 0x001A2A3C File Offset: 0x001A0C3C
		public unsafe Property AssignedProperty
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Employee.NativeMethodInfoPtr_get_AssignedProperty_Public_get_Property_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Property>(intPtr2) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Employee.NativeMethodInfoPtr_set_AssignedProperty_Protected_set_Void_Property_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x17001AE7 RID: 6887
		// (get) Token: 0x06005948 RID: 22856 RVA: 0x001A2A80 File Offset: 0x001A0C80
		// (set) Token: 0x06005949 RID: 22857 RVA: 0x001A2ABC File Offset: 0x001A0CBC
		public unsafe int EmployeeIndex
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Employee.NativeMethodInfoPtr_get_EmployeeIndex_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
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
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Employee.NativeMethodInfoPtr_set_EmployeeIndex_Protected_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x17001AE8 RID: 6888
		// (get) Token: 0x0600594A RID: 22858 RVA: 0x001A2AFC File Offset: 0x001A0CFC
		// (set) Token: 0x0600594B RID: 22859 RVA: 0x001A2B38 File Offset: 0x001A0D38
		public unsafe bool PaidForToday
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 189240, RefRangeEnd = 189242, XrefRangeStart = 189240, XrefRangeEnd = 189240, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Employee.NativeMethodInfoPtr_get_PaidForToday_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 189249, RefRangeEnd = 189252, XrefRangeStart = 189242, XrefRangeEnd = 189249, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = ref value;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Employee.NativeMethodInfoPtr_set_PaidForToday_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x17001AE9 RID: 6889
		// (get) Token: 0x0600594C RID: 22860 RVA: 0x001A2B78 File Offset: 0x001A0D78
		// (set) Token: 0x0600594D RID: 22861 RVA: 0x001A2BB4 File Offset: 0x001A0DB4
		public unsafe bool Fired
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Employee.NativeMethodInfoPtr_get_Fired_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
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
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Employee.NativeMethodInfoPtr_set_Fired_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x17001AEA RID: 6890
		// (get) Token: 0x0600594E RID: 22862 RVA: 0x001A2BF4 File Offset: 0x001A0DF4
		public unsafe bool IsWaitingOutside
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Employee.NativeMethodInfoPtr_get_IsWaitingOutside_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
		}

		// Token: 0x17001AEB RID: 6891
		// (get) Token: 0x0600594F RID: 22863 RVA: 0x001A2C30 File Offset: 0x001A0E30
		// (set) Token: 0x06005950 RID: 22864 RVA: 0x001A2C6C File Offset: 0x001A0E6C
		public unsafe bool IsMale
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Employee.NativeMethodInfoPtr_get_IsMale_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
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
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Employee.NativeMethodInfoPtr_set_IsMale_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x17001AEC RID: 6892
		// (get) Token: 0x06005951 RID: 22865 RVA: 0x001A2CAC File Offset: 0x001A0EAC
		// (set) Token: 0x06005952 RID: 22866 RVA: 0x001A2CE8 File Offset: 0x001A0EE8
		public unsafe int AppearanceIndex
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Employee.NativeMethodInfoPtr_get_AppearanceIndex_Protected_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
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
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Employee.NativeMethodInfoPtr_set_AppearanceIndex_Private_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x17001AED RID: 6893
		// (get) Token: 0x06005953 RID: 22867 RVA: 0x001A2D28 File Offset: 0x001A0F28
		public unsafe EEmployeeType EmployeeType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Employee.NativeMethodInfoPtr_get_EmployeeType_Public_get_EEmployeeType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
		}

		// Token: 0x17001AEE RID: 6894
		// (get) Token: 0x06005954 RID: 22868 RVA: 0x001A2D64 File Offset: 0x001A0F64
		// (set) Token: 0x06005955 RID: 22869 RVA: 0x001A2DA0 File Offset: 0x001A0FA0
		public unsafe int TimeSinceLastWorked
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Employee.NativeMethodInfoPtr_get_TimeSinceLastWorked_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
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
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Employee.NativeMethodInfoPtr_set_TimeSinceLastWorked_Private_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x06005956 RID: 22870 RVA: 0x001A2DE0 File Offset: 0x001A0FE0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 189327, RefRangeEnd = 189328, XrefRangeStart = 189252, XrefRangeEnd = 189327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Employee.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005957 RID: 22871 RVA: 0x001A2E1C File Offset: 0x001A101C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 189328, XrefRangeEnd = 189337, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnStartServer()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Employee.NativeMethodInfoPtr_OnStartServer_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005958 RID: 22872 RVA: 0x001A2E58 File Offset: 0x001A1058
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 189341, RefRangeEnd = 189345, XrefRangeStart = 189337, XrefRangeEnd = 189341, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnSpawnServer(NetworkConnection connection)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(connection);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Employee.NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005959 RID: 22873 RVA: 0x001A2EA8 File Offset: 0x001A10A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 189345, XrefRangeEnd = 189401, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Initialize(NetworkConnection conn, string firstName, string lastName, string id, string guid, string propertyID, bool male, int appearanceIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)8) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(firstName);
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(lastName);
			ptr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(id);
			ptr[checked(unchecked((System.UIntPtr)4) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(guid);
			ptr[checked(unchecked((System.UIntPtr)5) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(propertyID);
			ptr[checked(unchecked((System.UIntPtr)6) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref male;
			ptr[checked(unchecked((System.UIntPtr)7) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref appearanceIndex;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Employee.NativeMethodInfoPtr_Initialize_Public_Virtual_New_Void_NetworkConnection_String_String_String_String_String_Boolean_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600595A RID: 22874 RVA: 0x001A2F70 File Offset: 0x001A1170
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 189410, RefRangeEnd = 189414, XrefRangeStart = 189401, XrefRangeEnd = 189410, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void AssignProperty(Property prop, bool warp)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(prop);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref warp;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Employee.NativeMethodInfoPtr_AssignProperty_Protected_Virtual_New_Void_Property_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600595B RID: 22875 RVA: 0x001A2FCC File Offset: 0x001A11CC
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 189420, RefRangeEnd = 189424, XrefRangeStart = 189414, XrefRangeEnd = 189420, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void UnassignProperty()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Employee.NativeMethodInfoPtr_UnassignProperty_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600595C RID: 22876 RVA: 0x001A3008 File Offset: 0x001A1208
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 189434, RefRangeEnd = 189435, XrefRangeStart = 189424, XrefRangeEnd = 189434, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendTransfer(string propertyCode)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(propertyCode);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Employee.NativeMethodInfoPtr_SendTransfer_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600595D RID: 22877 RVA: 0x001A304C File Offset: 0x001A124C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 189435, XrefRangeEnd = 189445, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void TransferToProperty(string code)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(code);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Employee.NativeMethodInfoPtr_TransferToProperty_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600595E RID: 22878 RVA: 0x001A3090 File Offset: 0x001A1290
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 189445, XrefRangeEnd = 189469, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void TransferToProperty(Property prop)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(prop);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Employee.NativeMethodInfoPtr_TransferToProperty_Protected_Virtual_New_Void_Property_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600595F RID: 22879 RVA: 0x001A30E0 File Offset: 0x001A12E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 189469, XrefRangeEnd = 189482, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void InitializeInfo(string firstName, string lastName, string id)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(firstName);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(lastName);
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(id);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Employee.NativeMethodInfoPtr_InitializeInfo_Protected_Virtual_New_Void_String_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005960 RID: 22880 RVA: 0x001A3154 File Offset: 0x001A1354
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 189482, XrefRangeEnd = 189512, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void InitializeAppearance(bool male, int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref male;
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref index;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Employee.NativeMethodInfoPtr_InitializeAppearance_Protected_Virtual_New_Void_Boolean_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005961 RID: 22881 RVA: 0x001A31AC File Offset: 0x001A13AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 189512, XrefRangeEnd = 189532, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void CheckDialogueChoice(string choiceLabel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(choiceLabel);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Employee.NativeMethodInfoPtr_CheckDialogueChoice_Protected_Virtual_New_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005962 RID: 22882 RVA: 0x001A31FC File Offset: 0x001A13FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 189532, XrefRangeEnd = 189541, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendFire()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Employee.NativeMethodInfoPtr_SendFire_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005963 RID: 22883 RVA: 0x001A3230 File Offset: 0x001A1430
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 189541, XrefRangeEnd = 189550, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReceiveFire()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Employee.NativeMethodInfoPtr_ReceiveFire_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005964 RID: 22884 RVA: 0x001A3264 File Offset: 0x001A1464
		[CallerCount(14558)]
		[CachedScanResults(RefRangeStart = 2769, RefRangeEnd = 17327, XrefRangeStart = 2769, XrefRangeEnd = 17327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void ResetConfiguration()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Employee.NativeMethodInfoPtr_ResetConfiguration_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005965 RID: 22885 RVA: 0x001A32A0 File Offset: 0x001A14A0
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 189564, RefRangeEnd = 189568, XrefRangeStart = 189550, XrefRangeEnd = 189564, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Fire()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Employee.NativeMethodInfoPtr_Fire_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005966 RID: 22886 RVA: 0x001A32DC File Offset: 0x001A14DC
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 189576, RefRangeEnd = 189580, XrefRangeStart = 189568, XrefRangeEnd = 189576, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool CanWork()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Employee.NativeMethodInfoPtr_CanWork_Protected_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06005967 RID: 22887 RVA: 0x001A3318 File Offset: 0x001A1518
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 189580, XrefRangeEnd = 189609, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe virtual void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Employee.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005968 RID: 22888 RVA: 0x001A3354 File Offset: 0x001A1554
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 189642, RefRangeEnd = 189645, XrefRangeStart = 189609, XrefRangeEnd = 189642, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void UpdateBehaviour()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Employee.NativeMethodInfoPtr_UpdateBehaviour_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005969 RID: 22889 RVA: 0x001A3390 File Offset: 0x001A1590
		[CallerCount(0)]
		public unsafe void MarkIsWorking()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Employee.NativeMethodInfoPtr_MarkIsWorking_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600596A RID: 22890 RVA: 0x001A33C4 File Offset: 0x001A15C4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 189647, RefRangeEnd = 189650, XrefRangeStart = 189645, XrefRangeEnd = 189647, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetWaitOutside(bool wait)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref wait;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Employee.NativeMethodInfoPtr_SetWaitOutside_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600596B RID: 22891 RVA: 0x001A3404 File Offset: 0x001A1604
		[CallerCount(176)]
		[CachedScanResults(RefRangeStart = 38110, RefRangeEnd = 38286, XrefRangeStart = 38110, XrefRangeEnd = 38286, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool ShouldIdle()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Employee.NativeMethodInfoPtr_ShouldIdle_Protected_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x0600596C RID: 22892 RVA: 0x001A344C File Offset: 0x001A164C
		[CallerCount(176)]
		[CachedScanResults(RefRangeStart = 38110, RefRangeEnd = 38286, XrefRangeStart = 38110, XrefRangeEnd = 38286, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool ShouldNoticeGeneralCrime(Player player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Employee.NativeMethodInfoPtr_ShouldNoticeGeneralCrime_Protected_Virtual_Boolean_Player_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x0600596D RID: 22893 RVA: 0x001A34A4 File Offset: 0x001A16A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 189650, XrefRangeEnd = 189654, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void MinPass()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Employee.NativeMethodInfoPtr_MinPass_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600596E RID: 22894 RVA: 0x001A34E0 File Offset: 0x001A16E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 189654, XrefRangeEnd = 189655, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnSleepEnd(int sleepTime)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref sleepTime;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Employee.NativeMethodInfoPtr_OnSleepEnd_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600596F RID: 22895 RVA: 0x001A3520 File Offset: 0x001A1720
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 189656, RefRangeEnd = 189657, XrefRangeStart = 189655, XrefRangeEnd = 189656, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetIsPaid()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Employee.NativeMethodInfoPtr_SetIsPaid_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005970 RID: 22896 RVA: 0x001A3554 File Offset: 0x001A1754
		[CallerCount(176)]
		[CachedScanResults(RefRangeStart = 38110, RefRangeEnd = 38286, XrefRangeStart = 38110, XrefRangeEnd = 38286, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool ShouldSave()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Employee.NativeMethodInfoPtr_ShouldSave_Public_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06005971 RID: 22897 RVA: 0x001A359C File Offset: 0x001A179C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 189657, XrefRangeEnd = 189665, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override NPCData GetNPCData()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Employee.NativeMethodInfoPtr_GetNPCData_Public_Virtual_NPCData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<NPCData>(intPtr2) : null;
		}

		// Token: 0x06005972 RID: 22898 RVA: 0x001A35E8 File Offset: 0x001A17E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 189665, XrefRangeEnd = 189671, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual EmployeeHome GetHome()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Employee.NativeMethodInfoPtr_GetHome_Public_Virtual_New_EmployeeHome_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<EmployeeHome>(intPtr2) : null;
		}

		// Token: 0x06005973 RID: 22899 RVA: 0x001A3634 File Offset: 0x001A1834
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 189676, RefRangeEnd = 189678, XrefRangeStart = 189671, XrefRangeEnd = 189676, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsPayAvailable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Employee.NativeMethodInfoPtr_IsPayAvailable_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06005974 RID: 22900 RVA: 0x001A3670 File Offset: 0x001A1870
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 189678, XrefRangeEnd = 189684, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveDailyWage()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Employee.NativeMethodInfoPtr_RemoveDailyWage_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005975 RID: 22901 RVA: 0x001A36A4 File Offset: 0x001A18A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 189684, XrefRangeEnd = 189718, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool GetWorkIssue(out DialogueContainer notWorkingReason)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			ref System.IntPtr ptr2 = ref *ptr;
			System.IntPtr intPtr = 0;
			ptr2 = &intPtr;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Employee.NativeMethodInfoPtr_GetWorkIssue_Public_Virtual_New_Boolean_byref_DialogueContainer_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			notWorkingReason = ((intPtr2 == 0) ? null : new DialogueContainer(intPtr2));
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06005976 RID: 22902 RVA: 0x001A3710 File Offset: 0x001A1910
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 189718, XrefRangeEnd = 189719, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetIdle(bool idle)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref idle;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Employee.NativeMethodInfoPtr_SetIdle_Public_Virtual_New_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005977 RID: 22903 RVA: 0x001A375C File Offset: 0x001A195C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 189719, XrefRangeEnd = 189725, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LeavePropertyAndDespawn()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Employee.NativeMethodInfoPtr_LeavePropertyAndDespawn_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005978 RID: 22904 RVA: 0x001A3790 File Offset: 0x001A1990
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 189750, RefRangeEnd = 189751, XrefRangeStart = 189725, XrefRangeEnd = 189750, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SubmitNoWorkReason(string reason, string fix, int priority = 0)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(reason);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(fix);
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref priority;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Employee.NativeMethodInfoPtr_SubmitNoWorkReason_Public_Void_String_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005979 RID: 22905 RVA: 0x001A37F4 File Offset: 0x001A19F4
		[CallerCount(0)]
		public unsafe bool ShouldShowNoWorkDialogue(bool enabled)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref enabled;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Employee.NativeMethodInfoPtr_ShouldShowNoWorkDialogue_Private_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x0600597A RID: 22906 RVA: 0x001A3840 File Offset: 0x001A1A40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 189751, XrefRangeEnd = 189752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnNotWorkingDialogue()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Employee.NativeMethodInfoPtr_OnNotWorkingDialogue_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600597B RID: 22907 RVA: 0x001A3874 File Offset: 0x001A1A74
		[CallerCount(0)]
		public unsafe bool ShouldShowFireDialogue(bool enabled)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref enabled;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Employee.NativeMethodInfoPtr_ShouldShowFireDialogue_Private_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x0600597C RID: 22908 RVA: 0x001A38C0 File Offset: 0x001A1AC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 189752, XrefRangeEnd = 189774, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void TradeItems()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Employee.NativeMethodInfoPtr_TradeItems_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600597D RID: 22909 RVA: 0x001A38F4 File Offset: 0x001A1AF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 189774, XrefRangeEnd = 189787, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void TradeItemsDone()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Employee.NativeMethodInfoPtr_TradeItemsDone_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600597E RID: 22910 RVA: 0x001A3928 File Offset: 0x001A1B28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 189787, XrefRangeEnd = 189793, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetDestination(ITransitEntity transitEntity, bool teleportIfFail = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(transitEntity);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref teleportIfFail;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Employee.NativeMethodInfoPtr_SetDestination_Protected_Void_ITransitEntity_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600597F RID: 22911 RVA: 0x001A3978 File Offset: 0x001A1B78
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 189810, RefRangeEnd = 189812, XrefRangeStart = 189793, XrefRangeEnd = 189810, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetDestination(Vector3 position, bool teleportIfFail = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref position;
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref teleportIfFail;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Employee.NativeMethodInfoPtr_SetDestination_Protected_Void_Vector3_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005980 RID: 22912 RVA: 0x001A39C4 File Offset: 0x001A1BC4
		[CallerCount(0)]
		public unsafe virtual void WalkCallback(NPCMovement.WalkResult result)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref result;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Employee.NativeMethodInfoPtr_WalkCallback_Protected_Virtual_New_Void_WalkResult_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005981 RID: 22913 RVA: 0x001A3A10 File Offset: 0x001A1C10
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 189820, RefRangeEnd = 189824, XrefRangeStart = 189812, XrefRangeEnd = 189820, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Employee() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Employee>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Employee.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005982 RID: 22914 RVA: 0x001A3A4C File Offset: 0x001A1C4C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 189885, RefRangeEnd = 189889, XrefRangeStart = 189824, XrefRangeEnd = 189885, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize___Early()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Employee.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005983 RID: 22915 RVA: 0x001A3A88 File Offset: 0x001A1C88
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 189890, RefRangeEnd = 189891, XrefRangeStart = 189889, XrefRangeEnd = 189890, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize__Late()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Employee.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005984 RID: 22916 RVA: 0x001A3AC4 File Offset: 0x001A1CC4
		[CallerCount(0)]
		public unsafe override void NetworkInitializeIfDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Employee.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005985 RID: 22917 RVA: 0x001A3B00 File Offset: 0x001A1D00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 189891, XrefRangeEnd = 189908, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_Initialize_2260823878(NetworkConnection conn, string firstName, string lastName, string id, string guid, string propertyID, bool male, int appearanceIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)8) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(firstName);
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(lastName);
			ptr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(id);
			ptr[checked(unchecked((System.UIntPtr)4) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(guid);
			ptr[checked(unchecked((System.UIntPtr)5) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(propertyID);
			ptr[checked(unchecked((System.UIntPtr)6) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref male;
			ptr[checked(unchecked((System.UIntPtr)7) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref appearanceIndex;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Employee.NativeMethodInfoPtr_RpcWriter___Observers_Initialize_2260823878_Private_Void_NetworkConnection_String_String_String_String_String_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005986 RID: 22918 RVA: 0x001A3BBC File Offset: 0x001A1DBC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 189959, RefRangeEnd = 189962, XrefRangeStart = 189908, XrefRangeEnd = 189959, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void RpcLogic___Initialize_2260823878(NetworkConnection conn, string firstName, string lastName, string id, string guid, string propertyID, bool male, int appearanceIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)8) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(firstName);
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(lastName);
			ptr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(id);
			ptr[checked(unchecked((System.UIntPtr)4) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(guid);
			ptr[checked(unchecked((System.UIntPtr)5) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(propertyID);
			ptr[checked(unchecked((System.UIntPtr)6) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref male;
			ptr[checked(unchecked((System.UIntPtr)7) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref appearanceIndex;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Employee.NativeMethodInfoPtr_RpcLogic___Initialize_2260823878_Public_Virtual_New_Void_NetworkConnection_String_String_String_String_String_Boolean_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005987 RID: 22919 RVA: 0x001A3C84 File Offset: 0x001A1E84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 189962, XrefRangeEnd = 189972, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_Initialize_2260823878(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref channel;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Employee.NativeMethodInfoPtr_RpcReader___Observers_Initialize_2260823878_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005988 RID: 22920 RVA: 0x001A3CD4 File Offset: 0x001A1ED4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 189972, XrefRangeEnd = 189989, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Target_Initialize_2260823878(NetworkConnection conn, string firstName, string lastName, string id, string guid, string propertyID, bool male, int appearanceIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)8) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(firstName);
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(lastName);
			ptr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(id);
			ptr[checked(unchecked((System.UIntPtr)4) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(guid);
			ptr[checked(unchecked((System.UIntPtr)5) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(propertyID);
			ptr[checked(unchecked((System.UIntPtr)6) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref male;
			ptr[checked(unchecked((System.UIntPtr)7) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref appearanceIndex;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Employee.NativeMethodInfoPtr_RpcWriter___Target_Initialize_2260823878_Private_Void_NetworkConnection_String_String_String_String_String_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005989 RID: 22921 RVA: 0x001A3D90 File Offset: 0x001A1F90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 189989, XrefRangeEnd = 189999, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Target_Initialize_2260823878(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref channel;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Employee.NativeMethodInfoPtr_RpcReader___Target_Initialize_2260823878_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600598A RID: 22922 RVA: 0x001A3DE0 File Offset: 0x001A1FE0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 189434, RefRangeEnd = 189435, XrefRangeStart = 189434, XrefRangeEnd = 189435, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_SendTransfer_3615296227(string propertyCode)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(propertyCode);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Employee.NativeMethodInfoPtr_RpcWriter___Server_SendTransfer_3615296227_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600598B RID: 22923 RVA: 0x001A3E24 File Offset: 0x001A2024
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SendTransfer_3615296227(string propertyCode)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(propertyCode);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Employee.NativeMethodInfoPtr_RpcLogic___SendTransfer_3615296227_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600598C RID: 22924 RVA: 0x001A3E68 File Offset: 0x001A2068
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 189999, XrefRangeEnd = 190011, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_SendTransfer_3615296227(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref channel;
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Employee.NativeMethodInfoPtr_RpcReader___Server_SendTransfer_3615296227_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600598D RID: 22925 RVA: 0x001A3ECC File Offset: 0x001A20CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_TransferToProperty_3615296227(string code)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(code);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Employee.NativeMethodInfoPtr_RpcWriter___Observers_TransferToProperty_3615296227_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600598E RID: 22926 RVA: 0x001A3F10 File Offset: 0x001A2110
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 190011, XrefRangeEnd = 190028, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___TransferToProperty_3615296227(string code)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(code);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Employee.NativeMethodInfoPtr_RpcLogic___TransferToProperty_3615296227_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600598F RID: 22927 RVA: 0x001A3F54 File Offset: 0x001A2154
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 190028, XrefRangeEnd = 190041, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_TransferToProperty_3615296227(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref channel;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Employee.NativeMethodInfoPtr_RpcReader___Observers_TransferToProperty_3615296227_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005990 RID: 22928 RVA: 0x001A3FA4 File Offset: 0x001A21A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_SendFire_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Employee.NativeMethodInfoPtr_RpcWriter___Server_SendFire_2166136261_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005991 RID: 22929 RVA: 0x001A3FD8 File Offset: 0x001A21D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SendFire_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Employee.NativeMethodInfoPtr_RpcLogic___SendFire_2166136261_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005992 RID: 22930 RVA: 0x001A400C File Offset: 0x001A220C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 190041, XrefRangeEnd = 190051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_SendFire_2166136261(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref channel;
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Employee.NativeMethodInfoPtr_RpcReader___Server_SendFire_2166136261_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005993 RID: 22931 RVA: 0x001A4070 File Offset: 0x001A2270
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_ReceiveFire_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Employee.NativeMethodInfoPtr_RpcWriter___Observers_ReceiveFire_2166136261_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005994 RID: 22932 RVA: 0x001A40A4 File Offset: 0x001A22A4
		[CallerCount(0)]
		public unsafe void RpcLogic___ReceiveFire_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Employee.NativeMethodInfoPtr_RpcLogic___ReceiveFire_2166136261_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005995 RID: 22933 RVA: 0x001A40D8 File Offset: 0x001A22D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 190051, XrefRangeEnd = 190052, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_ReceiveFire_2166136261(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref channel;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Employee.NativeMethodInfoPtr_RpcReader___Observers_ReceiveFire_2166136261_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005996 RID: 22934 RVA: 0x001A4128 File Offset: 0x001A2328
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 190052, XrefRangeEnd = 190065, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_SubmitNoWorkReason_15643032(string reason, string fix, int priority = 0)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(reason);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(fix);
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref priority;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Employee.NativeMethodInfoPtr_RpcWriter___Observers_SubmitNoWorkReason_15643032_Private_Void_String_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005997 RID: 22935 RVA: 0x001A418C File Offset: 0x001A238C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 190080, RefRangeEnd = 190082, XrefRangeStart = 190065, XrefRangeEnd = 190080, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SubmitNoWorkReason_15643032(string reason, string fix, int priority = 0)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(reason);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(fix);
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref priority;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Employee.NativeMethodInfoPtr_RpcLogic___SubmitNoWorkReason_15643032_Public_Void_String_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005998 RID: 22936 RVA: 0x001A41F0 File Offset: 0x001A23F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 190082, XrefRangeEnd = 190089, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_SubmitNoWorkReason_15643032(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref channel;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Employee.NativeMethodInfoPtr_RpcReader___Observers_SubmitNoWorkReason_15643032_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x17001AEF RID: 6895
		// (get) Token: 0x06005999 RID: 22937 RVA: 0x001A4240 File Offset: 0x001A2440
		// (set) Token: 0x0600599A RID: 22938 RVA: 0x001A427C File Offset: 0x001A247C
		public unsafe bool SyncAccessor_<PaidForToday>k__BackingField
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 189240, RefRangeEnd = 189242, XrefRangeStart = 189240, XrefRangeEnd = 189242, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Employee.NativeMethodInfoPtr_sync___get_value__PaidForToday_k__BackingField_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 190097, RefRangeEnd = 190098, XrefRangeStart = 190089, XrefRangeEnd = 190097, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = ref value;
				ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref value;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Employee.NativeMethodInfoPtr_sync___set_value__PaidForToday_k__BackingField_Public_set_Void_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x0600599B RID: 22939 RVA: 0x001A42C8 File Offset: 0x001A24C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 190098, XrefRangeEnd = 190101, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool ReadSyncVar___ScheduleOne_Employees_Employee(PooledReader PooledReader0, uint UInt321, bool Boolean2)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref UInt321;
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref Boolean2;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Employee.NativeMethodInfoPtr_ReadSyncVar___ScheduleOne_Employees_Employee_Public_Virtual_Boolean_PooledReader_UInt32_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x0600599C RID: 22940 RVA: 0x001A433C File Offset: 0x001A253C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 147536, RefRangeEnd = 147540, XrefRangeStart = 147536, XrefRangeEnd = 147540, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Employee.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600599D RID: 22941 RVA: 0x0002A4D0 File Offset: 0x000286D0
		public Employee(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001ACB RID: 6859
		// (get) Token: 0x0600599E RID: 22942 RVA: 0x001A4378 File Offset: 0x001A2578
		// (set) Token: 0x0600599F RID: 22943 RVA: 0x0002A4D9 File Offset: 0x000286D9
		public unsafe static int MAX_CONSECUTIVE_PATHING_FAILURES
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(Employee.NativeFieldInfoPtr_MAX_CONSECUTIVE_PATHING_FAILURES, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Employee.NativeFieldInfoPtr_MAX_CONSECUTIVE_PATHING_FAILURES, (void*)(&value));
			}
		}

		// Token: 0x17001ACC RID: 6860
		// (get) Token: 0x060059A0 RID: 22944 RVA: 0x001A4394 File Offset: 0x001A2594
		// (set) Token: 0x060059A1 RID: 22945 RVA: 0x0002A4E7 File Offset: 0x000286E7
		public unsafe bool DEBUG
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Employee.NativeFieldInfoPtr_DEBUG);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Employee.NativeFieldInfoPtr_DEBUG)) = value;
			}
		}

		// Token: 0x17001ACD RID: 6861
		// (get) Token: 0x060059A2 RID: 22946 RVA: 0x001A43BC File Offset: 0x001A25BC
		// (set) Token: 0x060059A3 RID: 22947 RVA: 0x0002A502 File Offset: 0x00028702
		public unsafe Property _AssignedProperty_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Employee.NativeFieldInfoPtr__AssignedProperty_k__BackingField);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Property>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Employee.NativeFieldInfoPtr__AssignedProperty_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001ACE RID: 6862
		// (get) Token: 0x060059A4 RID: 22948 RVA: 0x001A43EC File Offset: 0x001A25EC
		// (set) Token: 0x060059A5 RID: 22949 RVA: 0x0002A521 File Offset: 0x00028721
		public unsafe int _EmployeeIndex_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Employee.NativeFieldInfoPtr__EmployeeIndex_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Employee.NativeFieldInfoPtr__EmployeeIndex_k__BackingField)) = value;
			}
		}

		// Token: 0x17001ACF RID: 6863
		// (get) Token: 0x060059A6 RID: 22950 RVA: 0x001A4414 File Offset: 0x001A2614
		// (set) Token: 0x060059A7 RID: 22951 RVA: 0x0002A53C File Offset: 0x0002873C
		public unsafe bool _PaidForToday_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Employee.NativeFieldInfoPtr__PaidForToday_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Employee.NativeFieldInfoPtr__PaidForToday_k__BackingField)) = value;
			}
		}

		// Token: 0x17001AD0 RID: 6864
		// (get) Token: 0x060059A8 RID: 22952 RVA: 0x001A443C File Offset: 0x001A263C
		// (set) Token: 0x060059A9 RID: 22953 RVA: 0x0002A557 File Offset: 0x00028757
		public unsafe bool _Fired_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Employee.NativeFieldInfoPtr__Fired_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Employee.NativeFieldInfoPtr__Fired_k__BackingField)) = value;
			}
		}

		// Token: 0x17001AD1 RID: 6865
		// (get) Token: 0x060059AA RID: 22954 RVA: 0x001A4464 File Offset: 0x001A2664
		// (set) Token: 0x060059AB RID: 22955 RVA: 0x0002A572 File Offset: 0x00028772
		public unsafe bool _IsMale_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Employee.NativeFieldInfoPtr__IsMale_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Employee.NativeFieldInfoPtr__IsMale_k__BackingField)) = value;
			}
		}

		// Token: 0x17001AD2 RID: 6866
		// (get) Token: 0x060059AC RID: 22956 RVA: 0x001A448C File Offset: 0x001A268C
		// (set) Token: 0x060059AD RID: 22957 RVA: 0x0002A58D File Offset: 0x0002878D
		public unsafe int _AppearanceIndex_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Employee.NativeFieldInfoPtr__AppearanceIndex_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Employee.NativeFieldInfoPtr__AppearanceIndex_k__BackingField)) = value;
			}
		}

		// Token: 0x17001AD3 RID: 6867
		// (get) Token: 0x060059AE RID: 22958 RVA: 0x001A44B4 File Offset: 0x001A26B4
		// (set) Token: 0x060059AF RID: 22959 RVA: 0x0002A5A8 File Offset: 0x000287A8
		public unsafe EEmployeeType Type
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Employee.NativeFieldInfoPtr_Type);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Employee.NativeFieldInfoPtr_Type)) = value;
			}
		}

		// Token: 0x17001AD4 RID: 6868
		// (get) Token: 0x060059B0 RID: 22960 RVA: 0x001A44DC File Offset: 0x001A26DC
		// (set) Token: 0x060059B1 RID: 22961 RVA: 0x0002A5C3 File Offset: 0x000287C3
		public unsafe float SigningFee
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Employee.NativeFieldInfoPtr_SigningFee);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Employee.NativeFieldInfoPtr_SigningFee)) = value;
			}
		}

		// Token: 0x17001AD5 RID: 6869
		// (get) Token: 0x060059B2 RID: 22962 RVA: 0x001A4504 File Offset: 0x001A2704
		// (set) Token: 0x060059B3 RID: 22963 RVA: 0x0002A5DE File Offset: 0x000287DE
		public unsafe float DailyWage
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Employee.NativeFieldInfoPtr_DailyWage);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Employee.NativeFieldInfoPtr_DailyWage)) = value;
			}
		}

		// Token: 0x17001AD6 RID: 6870
		// (get) Token: 0x060059B4 RID: 22964 RVA: 0x001A452C File Offset: 0x001A272C
		// (set) Token: 0x060059B5 RID: 22965 RVA: 0x0002A5F9 File Offset: 0x000287F9
		public unsafe IdleBehaviour WaitOutside
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Employee.NativeFieldInfoPtr_WaitOutside);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IdleBehaviour>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Employee.NativeFieldInfoPtr_WaitOutside), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001AD7 RID: 6871
		// (get) Token: 0x060059B6 RID: 22966 RVA: 0x001A455C File Offset: 0x001A275C
		// (set) Token: 0x060059B7 RID: 22967 RVA: 0x0002A618 File Offset: 0x00028818
		public unsafe MoveItemBehaviour MoveItemBehaviour
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Employee.NativeFieldInfoPtr_MoveItemBehaviour);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MoveItemBehaviour>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Employee.NativeFieldInfoPtr_MoveItemBehaviour), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001AD8 RID: 6872
		// (get) Token: 0x060059B8 RID: 22968 RVA: 0x001A458C File Offset: 0x001A278C
		// (set) Token: 0x060059B9 RID: 22969 RVA: 0x0002A637 File Offset: 0x00028837
		public unsafe DialogueContainer BedNotAssignedDialogue
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Employee.NativeFieldInfoPtr_BedNotAssignedDialogue);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DialogueContainer>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Employee.NativeFieldInfoPtr_BedNotAssignedDialogue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001AD9 RID: 6873
		// (get) Token: 0x060059BA RID: 22970 RVA: 0x001A45BC File Offset: 0x001A27BC
		// (set) Token: 0x060059BB RID: 22971 RVA: 0x0002A656 File Offset: 0x00028856
		public unsafe DialogueContainer NotPaidDialogue
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Employee.NativeFieldInfoPtr_NotPaidDialogue);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DialogueContainer>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Employee.NativeFieldInfoPtr_NotPaidDialogue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001ADA RID: 6874
		// (get) Token: 0x060059BC RID: 22972 RVA: 0x001A45EC File Offset: 0x001A27EC
		// (set) Token: 0x060059BD RID: 22973 RVA: 0x0002A675 File Offset: 0x00028875
		public unsafe DialogueContainer WorkIssueDialogueTemplate
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Employee.NativeFieldInfoPtr_WorkIssueDialogueTemplate);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DialogueContainer>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Employee.NativeFieldInfoPtr_WorkIssueDialogueTemplate), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001ADB RID: 6875
		// (get) Token: 0x060059BE RID: 22974 RVA: 0x001A461C File Offset: 0x001A281C
		// (set) Token: 0x060059BF RID: 22975 RVA: 0x0002A694 File Offset: 0x00028894
		public unsafe DialogueContainer FireDialogue
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Employee.NativeFieldInfoPtr_FireDialogue);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DialogueContainer>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Employee.NativeFieldInfoPtr_FireDialogue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001ADC RID: 6876
		// (get) Token: 0x060059C0 RID: 22976 RVA: 0x001A464C File Offset: 0x001A284C
		// (set) Token: 0x060059C1 RID: 22977 RVA: 0x0002A6B3 File Offset: 0x000288B3
		public unsafe DialogueContainer TransferDialogue
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Employee.NativeFieldInfoPtr_TransferDialogue);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DialogueContainer>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Employee.NativeFieldInfoPtr_TransferDialogue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001ADD RID: 6877
		// (get) Token: 0x060059C2 RID: 22978 RVA: 0x001A467C File Offset: 0x001A287C
		// (set) Token: 0x060059C3 RID: 22979 RVA: 0x0002A6D2 File Offset: 0x000288D2
		public unsafe List<Employee.NoWorkReason> WorkIssues
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Employee.NativeFieldInfoPtr_WorkIssues);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Employee.NoWorkReason>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Employee.NativeFieldInfoPtr_WorkIssues), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001ADE RID: 6878
		// (get) Token: 0x060059C4 RID: 22980 RVA: 0x001A46AC File Offset: 0x001A28AC
		// (set) Token: 0x060059C5 RID: 22981 RVA: 0x0002A6F1 File Offset: 0x000288F1
		public unsafe int _TimeSinceLastWorked_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Employee.NativeFieldInfoPtr__TimeSinceLastWorked_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Employee.NativeFieldInfoPtr__TimeSinceLastWorked_k__BackingField)) = value;
			}
		}

		// Token: 0x17001ADF RID: 6879
		// (get) Token: 0x060059C6 RID: 22982 RVA: 0x001A46D4 File Offset: 0x001A28D4
		// (set) Token: 0x060059C7 RID: 22983 RVA: 0x0002A70C File Offset: 0x0002890C
		public unsafe bool initialized
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Employee.NativeFieldInfoPtr_initialized);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Employee.NativeFieldInfoPtr_initialized)) = value;
			}
		}

		// Token: 0x17001AE0 RID: 6880
		// (get) Token: 0x060059C8 RID: 22984 RVA: 0x001A46FC File Offset: 0x001A28FC
		// (set) Token: 0x060059C9 RID: 22985 RVA: 0x0002A727 File Offset: 0x00028927
		public unsafe int consecutivePathingFailures
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Employee.NativeFieldInfoPtr_consecutivePathingFailures);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Employee.NativeFieldInfoPtr_consecutivePathingFailures)) = value;
			}
		}

		// Token: 0x17001AE1 RID: 6881
		// (get) Token: 0x060059CA RID: 22986 RVA: 0x001A4724 File Offset: 0x001A2924
		// (set) Token: 0x060059CB RID: 22987 RVA: 0x0002A742 File Offset: 0x00028942
		public unsafe float timeOnLastPathingFailure
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Employee.NativeFieldInfoPtr_timeOnLastPathingFailure);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Employee.NativeFieldInfoPtr_timeOnLastPathingFailure)) = value;
			}
		}

		// Token: 0x17001AE2 RID: 6882
		// (get) Token: 0x060059CC RID: 22988 RVA: 0x001A474C File Offset: 0x001A294C
		// (set) Token: 0x060059CD RID: 22989 RVA: 0x0002A75D File Offset: 0x0002895D
		public unsafe Transform cachedNPCSpawnPoint
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Employee.NativeFieldInfoPtr_cachedNPCSpawnPoint);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Employee.NativeFieldInfoPtr_cachedNPCSpawnPoint), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001AE3 RID: 6883
		// (get) Token: 0x060059CE RID: 22990 RVA: 0x001A477C File Offset: 0x001A297C
		// (set) Token: 0x060059CF RID: 22991 RVA: 0x0002A77C File Offset: 0x0002897C
		public unsafe SyncVar<bool> syncVar____PaidForToday_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Employee.NativeFieldInfoPtr_syncVar____PaidForToday_k__BackingField);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SyncVar<bool>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Employee.NativeFieldInfoPtr_syncVar____PaidForToday_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001AE4 RID: 6884
		// (get) Token: 0x060059D0 RID: 22992 RVA: 0x001A47AC File Offset: 0x001A29AC
		// (set) Token: 0x060059D1 RID: 22993 RVA: 0x0002A79B File Offset: 0x0002899B
		public new unsafe bool field_Private_Boolean_0
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Employee.NativeFieldInfoPtr_field_Private_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Employee.NativeFieldInfoPtr_field_Private_Boolean_0)) = value;
			}
		}

		// Token: 0x17001AE5 RID: 6885
		// (get) Token: 0x060059D2 RID: 22994 RVA: 0x001A47D4 File Offset: 0x001A29D4
		// (set) Token: 0x060059D3 RID: 22995 RVA: 0x0002A7B6 File Offset: 0x000289B6
		public new unsafe bool field_Private_Boolean_1
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Employee.NativeFieldInfoPtr_field_Private_Boolean_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Employee.NativeFieldInfoPtr_field_Private_Boolean_1)) = value;
			}
		}

		// Token: 0x04003CB3 RID: 15539
		private static readonly System.IntPtr NativeFieldInfoPtr_MAX_CONSECUTIVE_PATHING_FAILURES;

		// Token: 0x04003CB4 RID: 15540
		private static readonly System.IntPtr NativeFieldInfoPtr_DEBUG;

		// Token: 0x04003CB5 RID: 15541
		private static readonly System.IntPtr NativeFieldInfoPtr__AssignedProperty_k__BackingField;

		// Token: 0x04003CB6 RID: 15542
		private static readonly System.IntPtr NativeFieldInfoPtr__EmployeeIndex_k__BackingField;

		// Token: 0x04003CB7 RID: 15543
		private static readonly System.IntPtr NativeFieldInfoPtr__PaidForToday_k__BackingField;

		// Token: 0x04003CB8 RID: 15544
		private static readonly System.IntPtr NativeFieldInfoPtr__Fired_k__BackingField;

		// Token: 0x04003CB9 RID: 15545
		private static readonly System.IntPtr NativeFieldInfoPtr__IsMale_k__BackingField;

		// Token: 0x04003CBA RID: 15546
		private static readonly System.IntPtr NativeFieldInfoPtr__AppearanceIndex_k__BackingField;

		// Token: 0x04003CBB RID: 15547
		private static readonly System.IntPtr NativeFieldInfoPtr_Type;

		// Token: 0x04003CBC RID: 15548
		private static readonly System.IntPtr NativeFieldInfoPtr_SigningFee;

		// Token: 0x04003CBD RID: 15549
		private static readonly System.IntPtr NativeFieldInfoPtr_DailyWage;

		// Token: 0x04003CBE RID: 15550
		private static readonly System.IntPtr NativeFieldInfoPtr_WaitOutside;

		// Token: 0x04003CBF RID: 15551
		private static readonly System.IntPtr NativeFieldInfoPtr_MoveItemBehaviour;

		// Token: 0x04003CC0 RID: 15552
		private static readonly System.IntPtr NativeFieldInfoPtr_BedNotAssignedDialogue;

		// Token: 0x04003CC1 RID: 15553
		private static readonly System.IntPtr NativeFieldInfoPtr_NotPaidDialogue;

		// Token: 0x04003CC2 RID: 15554
		private static readonly System.IntPtr NativeFieldInfoPtr_WorkIssueDialogueTemplate;

		// Token: 0x04003CC3 RID: 15555
		private static readonly System.IntPtr NativeFieldInfoPtr_FireDialogue;

		// Token: 0x04003CC4 RID: 15556
		private static readonly System.IntPtr NativeFieldInfoPtr_TransferDialogue;

		// Token: 0x04003CC5 RID: 15557
		private static readonly System.IntPtr NativeFieldInfoPtr_WorkIssues;

		// Token: 0x04003CC6 RID: 15558
		private static readonly System.IntPtr NativeFieldInfoPtr__TimeSinceLastWorked_k__BackingField;

		// Token: 0x04003CC7 RID: 15559
		private static readonly System.IntPtr NativeFieldInfoPtr_initialized;

		// Token: 0x04003CC8 RID: 15560
		private static readonly System.IntPtr NativeFieldInfoPtr_consecutivePathingFailures;

		// Token: 0x04003CC9 RID: 15561
		private static readonly System.IntPtr NativeFieldInfoPtr_timeOnLastPathingFailure;

		// Token: 0x04003CCA RID: 15562
		private static readonly System.IntPtr NativeFieldInfoPtr_cachedNPCSpawnPoint;

		// Token: 0x04003CCB RID: 15563
		private static readonly System.IntPtr NativeFieldInfoPtr_syncVar____PaidForToday_k__BackingField;

		// Token: 0x04003CCC RID: 15564
		private static readonly System.IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

		// Token: 0x04003CCD RID: 15565
		private static readonly System.IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

		// Token: 0x04003CCE RID: 15566
		private static readonly System.IntPtr NativeMethodInfoPtr_get_AssignedProperty_Public_get_Property_0;

		// Token: 0x04003CCF RID: 15567
		private static readonly System.IntPtr NativeMethodInfoPtr_set_AssignedProperty_Protected_set_Void_Property_0;

		// Token: 0x04003CD0 RID: 15568
		private static readonly System.IntPtr NativeMethodInfoPtr_get_EmployeeIndex_Public_get_Int32_0;

		// Token: 0x04003CD1 RID: 15569
		private static readonly System.IntPtr NativeMethodInfoPtr_set_EmployeeIndex_Protected_set_Void_Int32_0;

		// Token: 0x04003CD2 RID: 15570
		private static readonly System.IntPtr NativeMethodInfoPtr_get_PaidForToday_Public_get_Boolean_0;

		// Token: 0x04003CD3 RID: 15571
		private static readonly System.IntPtr NativeMethodInfoPtr_set_PaidForToday_Private_set_Void_Boolean_0;

		// Token: 0x04003CD4 RID: 15572
		private static readonly System.IntPtr NativeMethodInfoPtr_get_Fired_Public_get_Boolean_0;

		// Token: 0x04003CD5 RID: 15573
		private static readonly System.IntPtr NativeMethodInfoPtr_set_Fired_Private_set_Void_Boolean_0;

		// Token: 0x04003CD6 RID: 15574
		private static readonly System.IntPtr NativeMethodInfoPtr_get_IsWaitingOutside_Public_get_Boolean_0;

		// Token: 0x04003CD7 RID: 15575
		private static readonly System.IntPtr NativeMethodInfoPtr_get_IsMale_Public_get_Boolean_0;

		// Token: 0x04003CD8 RID: 15576
		private static readonly System.IntPtr NativeMethodInfoPtr_set_IsMale_Private_set_Void_Boolean_0;

		// Token: 0x04003CD9 RID: 15577
		private static readonly System.IntPtr NativeMethodInfoPtr_get_AppearanceIndex_Protected_get_Int32_0;

		// Token: 0x04003CDA RID: 15578
		private static readonly System.IntPtr NativeMethodInfoPtr_set_AppearanceIndex_Private_set_Void_Int32_0;

		// Token: 0x04003CDB RID: 15579
		private static readonly System.IntPtr NativeMethodInfoPtr_get_EmployeeType_Public_get_EEmployeeType_0;

		// Token: 0x04003CDC RID: 15580
		private static readonly System.IntPtr NativeMethodInfoPtr_get_TimeSinceLastWorked_Public_get_Int32_0;

		// Token: 0x04003CDD RID: 15581
		private static readonly System.IntPtr NativeMethodInfoPtr_set_TimeSinceLastWorked_Private_set_Void_Int32_0;

		// Token: 0x04003CDE RID: 15582
		private static readonly System.IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x04003CDF RID: 15583
		private static readonly System.IntPtr NativeMethodInfoPtr_OnStartServer_Public_Virtual_Void_0;

		// Token: 0x04003CE0 RID: 15584
		private static readonly System.IntPtr NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0;

		// Token: 0x04003CE1 RID: 15585
		private static readonly System.IntPtr NativeMethodInfoPtr_Initialize_Public_Virtual_New_Void_NetworkConnection_String_String_String_String_String_Boolean_Int32_0;

		// Token: 0x04003CE2 RID: 15586
		private static readonly System.IntPtr NativeMethodInfoPtr_AssignProperty_Protected_Virtual_New_Void_Property_Boolean_0;

		// Token: 0x04003CE3 RID: 15587
		private static readonly System.IntPtr NativeMethodInfoPtr_UnassignProperty_Protected_Virtual_New_Void_0;

		// Token: 0x04003CE4 RID: 15588
		private static readonly System.IntPtr NativeMethodInfoPtr_SendTransfer_Public_Void_String_0;

		// Token: 0x04003CE5 RID: 15589
		private static readonly System.IntPtr NativeMethodInfoPtr_TransferToProperty_Private_Void_String_0;

		// Token: 0x04003CE6 RID: 15590
		private static readonly System.IntPtr NativeMethodInfoPtr_TransferToProperty_Protected_Virtual_New_Void_Property_0;

		// Token: 0x04003CE7 RID: 15591
		private static readonly System.IntPtr NativeMethodInfoPtr_InitializeInfo_Protected_Virtual_New_Void_String_String_String_0;

		// Token: 0x04003CE8 RID: 15592
		private static readonly System.IntPtr NativeMethodInfoPtr_InitializeAppearance_Protected_Virtual_New_Void_Boolean_Int32_0;

		// Token: 0x04003CE9 RID: 15593
		private static readonly System.IntPtr NativeMethodInfoPtr_CheckDialogueChoice_Protected_Virtual_New_Void_String_0;

		// Token: 0x04003CEA RID: 15594
		private static readonly System.IntPtr NativeMethodInfoPtr_SendFire_Public_Void_0;

		// Token: 0x04003CEB RID: 15595
		private static readonly System.IntPtr NativeMethodInfoPtr_ReceiveFire_Private_Void_0;

		// Token: 0x04003CEC RID: 15596
		private static readonly System.IntPtr NativeMethodInfoPtr_ResetConfiguration_Protected_Virtual_New_Void_0;

		// Token: 0x04003CED RID: 15597
		private static readonly System.IntPtr NativeMethodInfoPtr_Fire_Protected_Virtual_New_Void_0;

		// Token: 0x04003CEE RID: 15598
		private static readonly System.IntPtr NativeMethodInfoPtr_CanWork_Protected_Boolean_0;

		// Token: 0x04003CEF RID: 15599
		private static readonly System.IntPtr NativeMethodInfoPtr_OnDestroy_Protected_Virtual_New_Void_0;

		// Token: 0x04003CF0 RID: 15600
		private static readonly System.IntPtr NativeMethodInfoPtr_UpdateBehaviour_Protected_Virtual_New_Void_0;

		// Token: 0x04003CF1 RID: 15601
		private static readonly System.IntPtr NativeMethodInfoPtr_MarkIsWorking_Protected_Void_0;

		// Token: 0x04003CF2 RID: 15602
		private static readonly System.IntPtr NativeMethodInfoPtr_SetWaitOutside_Private_Void_Boolean_0;

		// Token: 0x04003CF3 RID: 15603
		private static readonly System.IntPtr NativeMethodInfoPtr_ShouldIdle_Protected_Virtual_New_Boolean_0;

		// Token: 0x04003CF4 RID: 15604
		private static readonly System.IntPtr NativeMethodInfoPtr_ShouldNoticeGeneralCrime_Protected_Virtual_Boolean_Player_0;

		// Token: 0x04003CF5 RID: 15605
		private static readonly System.IntPtr NativeMethodInfoPtr_MinPass_Protected_Virtual_Void_0;

		// Token: 0x04003CF6 RID: 15606
		private static readonly System.IntPtr NativeMethodInfoPtr_OnSleepEnd_Private_Void_Int32_0;

		// Token: 0x04003CF7 RID: 15607
		private static readonly System.IntPtr NativeMethodInfoPtr_SetIsPaid_Public_Void_0;

		// Token: 0x04003CF8 RID: 15608
		private static readonly System.IntPtr NativeMethodInfoPtr_ShouldSave_Public_Virtual_Boolean_0;

		// Token: 0x04003CF9 RID: 15609
		private static readonly System.IntPtr NativeMethodInfoPtr_GetNPCData_Public_Virtual_NPCData_0;

		// Token: 0x04003CFA RID: 15610
		private static readonly System.IntPtr NativeMethodInfoPtr_GetHome_Public_Virtual_New_EmployeeHome_0;

		// Token: 0x04003CFB RID: 15611
		private static readonly System.IntPtr NativeMethodInfoPtr_IsPayAvailable_Public_Boolean_0;

		// Token: 0x04003CFC RID: 15612
		private static readonly System.IntPtr NativeMethodInfoPtr_RemoveDailyWage_Public_Void_0;

		// Token: 0x04003CFD RID: 15613
		private static readonly System.IntPtr NativeMethodInfoPtr_GetWorkIssue_Public_Virtual_New_Boolean_byref_DialogueContainer_0;

		// Token: 0x04003CFE RID: 15614
		private static readonly System.IntPtr NativeMethodInfoPtr_SetIdle_Public_Virtual_New_Void_Boolean_0;

		// Token: 0x04003CFF RID: 15615
		private static readonly System.IntPtr NativeMethodInfoPtr_LeavePropertyAndDespawn_Protected_Void_0;

		// Token: 0x04003D00 RID: 15616
		private static readonly System.IntPtr NativeMethodInfoPtr_SubmitNoWorkReason_Public_Void_String_String_Int32_0;

		// Token: 0x04003D01 RID: 15617
		private static readonly System.IntPtr NativeMethodInfoPtr_ShouldShowNoWorkDialogue_Private_Boolean_Boolean_0;

		// Token: 0x04003D02 RID: 15618
		private static readonly System.IntPtr NativeMethodInfoPtr_OnNotWorkingDialogue_Private_Void_0;

		// Token: 0x04003D03 RID: 15619
		private static readonly System.IntPtr NativeMethodInfoPtr_ShouldShowFireDialogue_Private_Boolean_Boolean_0;

		// Token: 0x04003D04 RID: 15620
		private static readonly System.IntPtr NativeMethodInfoPtr_TradeItems_Private_Void_0;

		// Token: 0x04003D05 RID: 15621
		private static readonly System.IntPtr NativeMethodInfoPtr_TradeItemsDone_Private_Void_0;

		// Token: 0x04003D06 RID: 15622
		private static readonly System.IntPtr NativeMethodInfoPtr_SetDestination_Protected_Void_ITransitEntity_Boolean_0;

		// Token: 0x04003D07 RID: 15623
		private static readonly System.IntPtr NativeMethodInfoPtr_SetDestination_Protected_Void_Vector3_Boolean_0;

		// Token: 0x04003D08 RID: 15624
		private static readonly System.IntPtr NativeMethodInfoPtr_WalkCallback_Protected_Virtual_New_Void_WalkResult_0;

		// Token: 0x04003D09 RID: 15625
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04003D0A RID: 15626
		private static readonly System.IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

		// Token: 0x04003D0B RID: 15627
		private static readonly System.IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

		// Token: 0x04003D0C RID: 15628
		private static readonly System.IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

		// Token: 0x04003D0D RID: 15629
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcWriter___Observers_Initialize_2260823878_Private_Void_NetworkConnection_String_String_String_String_String_Boolean_Int32_0;

		// Token: 0x04003D0E RID: 15630
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcLogic___Initialize_2260823878_Public_Virtual_New_Void_NetworkConnection_String_String_String_String_String_Boolean_Int32_0;

		// Token: 0x04003D0F RID: 15631
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcReader___Observers_Initialize_2260823878_Private_Void_PooledReader_Channel_0;

		// Token: 0x04003D10 RID: 15632
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcWriter___Target_Initialize_2260823878_Private_Void_NetworkConnection_String_String_String_String_String_Boolean_Int32_0;

		// Token: 0x04003D11 RID: 15633
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcReader___Target_Initialize_2260823878_Private_Void_PooledReader_Channel_0;

		// Token: 0x04003D12 RID: 15634
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcWriter___Server_SendTransfer_3615296227_Private_Void_String_0;

		// Token: 0x04003D13 RID: 15635
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcLogic___SendTransfer_3615296227_Public_Void_String_0;

		// Token: 0x04003D14 RID: 15636
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcReader___Server_SendTransfer_3615296227_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x04003D15 RID: 15637
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcWriter___Observers_TransferToProperty_3615296227_Private_Void_String_0;

		// Token: 0x04003D16 RID: 15638
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcLogic___TransferToProperty_3615296227_Private_Void_String_0;

		// Token: 0x04003D17 RID: 15639
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcReader___Observers_TransferToProperty_3615296227_Private_Void_PooledReader_Channel_0;

		// Token: 0x04003D18 RID: 15640
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcWriter___Server_SendFire_2166136261_Private_Void_0;

		// Token: 0x04003D19 RID: 15641
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcLogic___SendFire_2166136261_Public_Void_0;

		// Token: 0x04003D1A RID: 15642
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcReader___Server_SendFire_2166136261_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x04003D1B RID: 15643
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcWriter___Observers_ReceiveFire_2166136261_Private_Void_0;

		// Token: 0x04003D1C RID: 15644
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcLogic___ReceiveFire_2166136261_Private_Void_0;

		// Token: 0x04003D1D RID: 15645
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcReader___Observers_ReceiveFire_2166136261_Private_Void_PooledReader_Channel_0;

		// Token: 0x04003D1E RID: 15646
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcWriter___Observers_SubmitNoWorkReason_15643032_Private_Void_String_String_Int32_0;

		// Token: 0x04003D1F RID: 15647
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcLogic___SubmitNoWorkReason_15643032_Public_Void_String_String_Int32_0;

		// Token: 0x04003D20 RID: 15648
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcReader___Observers_SubmitNoWorkReason_15643032_Private_Void_PooledReader_Channel_0;

		// Token: 0x04003D21 RID: 15649
		private static readonly System.IntPtr NativeMethodInfoPtr_sync___get_value__PaidForToday_k__BackingField_Public_get_Boolean_0;

		// Token: 0x04003D22 RID: 15650
		private static readonly System.IntPtr NativeMethodInfoPtr_sync___set_value__PaidForToday_k__BackingField_Public_set_Void_Boolean_Boolean_0;

		// Token: 0x04003D23 RID: 15651
		private static readonly System.IntPtr NativeMethodInfoPtr_ReadSyncVar___ScheduleOne_Employees_Employee_Public_Virtual_Boolean_PooledReader_UInt32_Boolean_0;

		// Token: 0x04003D24 RID: 15652
		private static readonly System.IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;

		// Token: 0x02000A1B RID: 2587
		public class NoWorkReason : Il2CppSystem.Object
		{
			// Token: 0x0600D1CE RID: 53710 RVA: 0x0032B4EC File Offset: 0x003296EC
			// Note: this type is marked as 'beforefieldinit'.
			static NoWorkReason()
			{
				Il2CppClassPointerStore<Employee.NoWorkReason>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Employee>.NativeClassPtr, "NoWorkReason");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Employee.NoWorkReason>.NativeClassPtr);
				Employee.NoWorkReason.NativeFieldInfoPtr_Reason = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Employee.NoWorkReason>.NativeClassPtr, "Reason");
				Employee.NoWorkReason.NativeFieldInfoPtr_Fix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Employee.NoWorkReason>.NativeClassPtr, "Fix");
				Employee.NoWorkReason.NativeFieldInfoPtr_Priority = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Employee.NoWorkReason>.NativeClassPtr, "Priority");
				Employee.NoWorkReason.NativeMethodInfoPtr__ctor_Public_Void_String_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Employee.NoWorkReason>.NativeClassPtr, 100674717);
			}

			// Token: 0x0600D1CF RID: 53711 RVA: 0x0032B568 File Offset: 0x00329768
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 189237, XrefRangeEnd = 189240, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe NoWorkReason(string reason, string fix, int priority) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Employee.NoWorkReason>.NativeClassPtr))
			{
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(reason);
				ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(fix);
				ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref priority;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Employee.NoWorkReason.NativeMethodInfoPtr__ctor_Public_Void_String_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600D1D0 RID: 53712 RVA: 0x00065B58 File Offset: 0x00063D58
			public NoWorkReason(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004109 RID: 16649
			// (get) Token: 0x0600D1D1 RID: 53713 RVA: 0x0032B5D4 File Offset: 0x003297D4
			// (set) Token: 0x0600D1D2 RID: 53714 RVA: 0x00065B61 File Offset: 0x00063D61
			public unsafe string Reason
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Employee.NoWorkReason.NativeFieldInfoPtr_Reason);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Employee.NoWorkReason.NativeFieldInfoPtr_Reason), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x1700410A RID: 16650
			// (get) Token: 0x0600D1D3 RID: 53715 RVA: 0x0032B5FC File Offset: 0x003297FC
			// (set) Token: 0x0600D1D4 RID: 53716 RVA: 0x00065B80 File Offset: 0x00063D80
			public unsafe string Fix
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Employee.NoWorkReason.NativeFieldInfoPtr_Fix);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Employee.NoWorkReason.NativeFieldInfoPtr_Fix), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x1700410B RID: 16651
			// (get) Token: 0x0600D1D5 RID: 53717 RVA: 0x0032B624 File Offset: 0x00329824
			// (set) Token: 0x0600D1D6 RID: 53718 RVA: 0x00065B9F File Offset: 0x00063D9F
			public unsafe int Priority
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Employee.NoWorkReason.NativeFieldInfoPtr_Priority);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Employee.NoWorkReason.NativeFieldInfoPtr_Priority)) = value;
				}
			}

			// Token: 0x04008DE4 RID: 36324
			private static readonly System.IntPtr NativeFieldInfoPtr_Reason;

			// Token: 0x04008DE5 RID: 36325
			private static readonly System.IntPtr NativeFieldInfoPtr_Fix;

			// Token: 0x04008DE6 RID: 36326
			private static readonly System.IntPtr NativeFieldInfoPtr_Priority;

			// Token: 0x04008DE7 RID: 36327
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_String_Int32_0;
		}
	}
}
