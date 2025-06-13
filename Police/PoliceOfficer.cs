using System;
using Il2CppFishNet.Connection;
using Il2CppFishNet.Object;
using Il2CppFishNet.Object.Synchronizing;
using Il2CppFishNet.Serializing;
using Il2CppFishNet.Transporting;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.AvatarFramework.Customization;
using Il2CppScheduleOne.AvatarFramework.Equipping;
using Il2CppScheduleOne.Dialogue;
using Il2CppScheduleOne.FX;
using Il2CppScheduleOne.Law;
using Il2CppScheduleOne.NPCs;
using Il2CppScheduleOne.NPCs.Behaviour;
using Il2CppScheduleOne.PlayerScripts;
using Il2CppScheduleOne.Vehicles;
using Il2CppScheduleOne.Vision;
using Il2CppScheduleOne.VoiceOver;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;

namespace Il2CppScheduleOne.Police
{
	// Token: 0x02000209 RID: 521
	public class PoliceOfficer : NPC
	{
		// Token: 0x0600299F RID: 10655 RVA: 0x000F7238 File Offset: 0x000F5438
		// Note: this type is marked as 'beforefieldinit'.
		static PoliceOfficer()
		{
			Il2CppClassPointerStore<PoliceOfficer>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Police", "PoliceOfficer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PoliceOfficer>.NativeClassPtr);
			PoliceOfficer.NativeFieldInfoPtr_DEACTIVATION_TIME = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PoliceOfficer>.NativeClassPtr, "DEACTIVATION_TIME");
			PoliceOfficer.NativeFieldInfoPtr_INVESTIGATION_COOLDOWN = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PoliceOfficer>.NativeClassPtr, "INVESTIGATION_COOLDOWN");
			PoliceOfficer.NativeFieldInfoPtr_INVESTIGATION_MAX_DISTANCE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PoliceOfficer>.NativeClassPtr, "INVESTIGATION_MAX_DISTANCE");
			PoliceOfficer.NativeFieldInfoPtr_INVESTIGATION_MIN_VISIBILITY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PoliceOfficer>.NativeClassPtr, "INVESTIGATION_MIN_VISIBILITY");
			PoliceOfficer.NativeFieldInfoPtr_INVESTIGATION_CHECK_INTERVAL = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PoliceOfficer>.NativeClassPtr, "INVESTIGATION_CHECK_INTERVAL");
			PoliceOfficer.NativeFieldInfoPtr_BODY_SEARCH_CHANCE_DEFAULT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PoliceOfficer>.NativeClassPtr, "BODY_SEARCH_CHANCE_DEFAULT");
			PoliceOfficer.NativeFieldInfoPtr_MIN_CHATTER_INTERVAL = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PoliceOfficer>.NativeClassPtr, "MIN_CHATTER_INTERVAL");
			PoliceOfficer.NativeFieldInfoPtr_MAX_CHATTER_INTERVAL = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PoliceOfficer>.NativeClassPtr, "MAX_CHATTER_INTERVAL");
			PoliceOfficer.NativeFieldInfoPtr_OnPoliceVisionEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PoliceOfficer>.NativeClassPtr, "OnPoliceVisionEvent");
			PoliceOfficer.NativeFieldInfoPtr_Officers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PoliceOfficer>.NativeClassPtr, "Officers");
			PoliceOfficer.NativeFieldInfoPtr__TargetPlayerNOB_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PoliceOfficer>.NativeClassPtr, "<TargetPlayerNOB>k__BackingField");
			PoliceOfficer.NativeFieldInfoPtr_AssignedVehicle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PoliceOfficer>.NativeClassPtr, "AssignedVehicle");
			PoliceOfficer.NativeFieldInfoPtr_PursuitBehaviour = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PoliceOfficer>.NativeClassPtr, "PursuitBehaviour");
			PoliceOfficer.NativeFieldInfoPtr_VehiclePursuitBehaviour = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PoliceOfficer>.NativeClassPtr, "VehiclePursuitBehaviour");
			PoliceOfficer.NativeFieldInfoPtr_BodySearchBehaviour = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PoliceOfficer>.NativeClassPtr, "BodySearchBehaviour");
			PoliceOfficer.NativeFieldInfoPtr_CheckpointBehaviour = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PoliceOfficer>.NativeClassPtr, "CheckpointBehaviour");
			PoliceOfficer.NativeFieldInfoPtr_FootPatrolBehaviour = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PoliceOfficer>.NativeClassPtr, "FootPatrolBehaviour");
			PoliceOfficer.NativeFieldInfoPtr_ProxCircle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PoliceOfficer>.NativeClassPtr, "ProxCircle");
			PoliceOfficer.NativeFieldInfoPtr_VehiclePatrolBehaviour = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PoliceOfficer>.NativeClassPtr, "VehiclePatrolBehaviour");
			PoliceOfficer.NativeFieldInfoPtr_SentryBehaviour = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PoliceOfficer>.NativeClassPtr, "SentryBehaviour");
			PoliceOfficer.NativeFieldInfoPtr_ChatterVO = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PoliceOfficer>.NativeClassPtr, "ChatterVO");
			PoliceOfficer.NativeFieldInfoPtr_CheckpointDialogue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PoliceOfficer>.NativeClassPtr, "CheckpointDialogue");
			PoliceOfficer.NativeFieldInfoPtr_BatonPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PoliceOfficer>.NativeClassPtr, "BatonPrefab");
			PoliceOfficer.NativeFieldInfoPtr_TaserPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PoliceOfficer>.NativeClassPtr, "TaserPrefab");
			PoliceOfficer.NativeFieldInfoPtr_GunPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PoliceOfficer>.NativeClassPtr, "GunPrefab");
			PoliceOfficer.NativeFieldInfoPtr_AutoDeactivate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PoliceOfficer>.NativeClassPtr, "AutoDeactivate");
			PoliceOfficer.NativeFieldInfoPtr_ChatterEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PoliceOfficer>.NativeClassPtr, "ChatterEnabled");
			PoliceOfficer.NativeFieldInfoPtr_Suspicion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PoliceOfficer>.NativeClassPtr, "Suspicion");
			PoliceOfficer.NativeFieldInfoPtr_Leniency = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PoliceOfficer>.NativeClassPtr, "Leniency");
			PoliceOfficer.NativeFieldInfoPtr_BodySearchChance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PoliceOfficer>.NativeClassPtr, "BodySearchChance");
			PoliceOfficer.NativeFieldInfoPtr_BodySearchDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PoliceOfficer>.NativeClassPtr, "BodySearchDuration");
			PoliceOfficer.NativeFieldInfoPtr_belt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PoliceOfficer>.NativeClassPtr, "belt");
			PoliceOfficer.NativeFieldInfoPtr_timeSinceReadyToPool = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PoliceOfficer>.NativeClassPtr, "timeSinceReadyToPool");
			PoliceOfficer.NativeFieldInfoPtr_timeSinceOutOfSight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PoliceOfficer>.NativeClassPtr, "timeSinceOutOfSight");
			PoliceOfficer.NativeFieldInfoPtr_chatterCountDown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PoliceOfficer>.NativeClassPtr, "chatterCountDown");
			PoliceOfficer.NativeFieldInfoPtr_currentBodySearchInvestigation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PoliceOfficer>.NativeClassPtr, "currentBodySearchInvestigation");
			PoliceOfficer.NativeFieldInfoPtr_syncVar____TargetPlayerNOB_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PoliceOfficer>.NativeClassPtr, "syncVar___<TargetPlayerNOB>k__BackingField");
			PoliceOfficer.NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PoliceOfficer>.NativeClassPtr, "NetworkInitialize___EarlyScheduleOne.Police.PoliceOfficerAssembly-CSharp.dll_Excuted");
			PoliceOfficer.NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PoliceOfficer>.NativeClassPtr, "NetworkInitialize__LateScheduleOne.Police.PoliceOfficerAssembly-CSharp.dll_Excuted");
			PoliceOfficer.NativeMethodInfoPtr_get_TargetPlayerNOB_Public_get_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoliceOfficer>.NativeClassPtr, 100668039);
			PoliceOfficer.NativeMethodInfoPtr_set_TargetPlayerNOB_Protected_set_Void_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoliceOfficer>.NativeClassPtr, 100668040);
			PoliceOfficer.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoliceOfficer>.NativeClassPtr, 100668041);
			PoliceOfficer.NativeMethodInfoPtr_Start_Protected_Virtual_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoliceOfficer>.NativeClassPtr, 100668042);
			PoliceOfficer.NativeMethodInfoPtr_Update_Protected_Virtual_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoliceOfficer>.NativeClassPtr, 100668043);
			PoliceOfficer.NativeMethodInfoPtr_FixedUpdate_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoliceOfficer>.NativeClassPtr, 100668044);
			PoliceOfficer.NativeMethodInfoPtr_MinPass_Protected_Virtual_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoliceOfficer>.NativeClassPtr, 100668045);
			PoliceOfficer.NativeMethodInfoPtr_CheckDeactivation_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoliceOfficer>.NativeClassPtr, 100668046);
			PoliceOfficer.NativeMethodInfoPtr_BeginFootPursuit_Networked_Public_Virtual_New_Void_NetworkObject_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoliceOfficer>.NativeClassPtr, 100668047);
			PoliceOfficer.NativeMethodInfoPtr_BeginFootPursuitTest_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoliceOfficer>.NativeClassPtr, 100668048);
			PoliceOfficer.NativeMethodInfoPtr_BeginVehiclePursuit_Networked_Public_Virtual_New_Void_NetworkObject_NetworkObject_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoliceOfficer>.NativeClassPtr, 100668049);
			PoliceOfficer.NativeMethodInfoPtr_BeginVehiclePursuit_Private_Void_NetworkObject_NetworkObject_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoliceOfficer>.NativeClassPtr, 100668050);
			PoliceOfficer.NativeMethodInfoPtr_BeginBodySearch_LocalPlayer_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoliceOfficer>.NativeClassPtr, 100668051);
			PoliceOfficer.NativeMethodInfoPtr_BeginBodySearch_Networked_Public_Virtual_New_Void_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoliceOfficer>.NativeClassPtr, 100668052);
			PoliceOfficer.NativeMethodInfoPtr_BeginBodySearch_Private_Void_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoliceOfficer>.NativeClassPtr, 100668053);
			PoliceOfficer.NativeMethodInfoPtr_AssignToCheckpoint_Public_Virtual_New_Void_ECheckpointLocation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoliceOfficer>.NativeClassPtr, 100668054);
			PoliceOfficer.NativeMethodInfoPtr_UnassignFromCheckpoint_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoliceOfficer>.NativeClassPtr, 100668055);
			PoliceOfficer.NativeMethodInfoPtr_StartFootPatrol_Public_Void_PatrolGroup_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoliceOfficer>.NativeClassPtr, 100668056);
			PoliceOfficer.NativeMethodInfoPtr_StartVehiclePatrol_Public_Void_VehiclePatrolRoute_LandVehicle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoliceOfficer>.NativeClassPtr, 100668057);
			PoliceOfficer.NativeMethodInfoPtr_AssignToSentryLocation_Public_Virtual_New_Void_SentryLocation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoliceOfficer>.NativeClassPtr, 100668058);
			PoliceOfficer.NativeMethodInfoPtr_UnassignFromSentryLocation_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoliceOfficer>.NativeClassPtr, 100668059);
			PoliceOfficer.NativeMethodInfoPtr_Activate_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoliceOfficer>.NativeClassPtr, 100668060);
			PoliceOfficer.NativeMethodInfoPtr_Deactivate_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoliceOfficer>.NativeClassPtr, 100668061);
			PoliceOfficer.NativeMethodInfoPtr_ShouldNoticeGeneralCrime_Protected_Virtual_Boolean_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoliceOfficer>.NativeClassPtr, 100668062);
			PoliceOfficer.NativeMethodInfoPtr_ShouldSave_Public_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoliceOfficer>.NativeClassPtr, 100668063);
			PoliceOfficer.NativeMethodInfoPtr_GetNameAddress_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoliceOfficer>.NativeClassPtr, 100668064);
			PoliceOfficer.NativeMethodInfoPtr_UpdateChatter_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoliceOfficer>.NativeClassPtr, 100668065);
			PoliceOfficer.NativeMethodInfoPtr_ProcessVisionEvent_Private_Void_VisionEventReceipt_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoliceOfficer>.NativeClassPtr, 100668066);
			PoliceOfficer.NativeMethodInfoPtr_UpdateBodySearch_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoliceOfficer>.NativeClassPtr, 100668067);
			PoliceOfficer.NativeMethodInfoPtr_CanInvestigate_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoliceOfficer>.NativeClassPtr, 100668068);
			PoliceOfficer.NativeMethodInfoPtr_UpdateExistingInvestigation_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoliceOfficer>.NativeClassPtr, 100668069);
			PoliceOfficer.NativeMethodInfoPtr_CheckNewInvestigation_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoliceOfficer>.NativeClassPtr, 100668070);
			PoliceOfficer.NativeMethodInfoPtr_StartBodySearchInvestigation_Private_Void_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoliceOfficer>.NativeClassPtr, 100668071);
			PoliceOfficer.NativeMethodInfoPtr_StopBodySearchInvestigation_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoliceOfficer>.NativeClassPtr, 100668072);
			PoliceOfficer.NativeMethodInfoPtr_ConductBodySearch_Public_Void_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoliceOfficer>.NativeClassPtr, 100668073);
			PoliceOfficer.NativeMethodInfoPtr_CanInvestigatePlayer_Private_Boolean_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoliceOfficer>.NativeClassPtr, 100668074);
			PoliceOfficer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoliceOfficer>.NativeClassPtr, 100668075);
			PoliceOfficer.NativeMethodInfoPtr__Awake_b__39_0_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoliceOfficer>.NativeClassPtr, 100668077);
			PoliceOfficer.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoliceOfficer>.NativeClassPtr, 100668078);
			PoliceOfficer.NativeMethodInfoPtr__Deactivate_b__59_1_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoliceOfficer>.NativeClassPtr, 100668079);
			PoliceOfficer.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoliceOfficer>.NativeClassPtr, 100668080);
			PoliceOfficer.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoliceOfficer>.NativeClassPtr, 100668081);
			PoliceOfficer.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoliceOfficer>.NativeClassPtr, 100668082);
			PoliceOfficer.NativeMethodInfoPtr_RpcWriter___Server_BeginFootPursuit_Networked_419679943_Private_Void_NetworkObject_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoliceOfficer>.NativeClassPtr, 100668083);
			PoliceOfficer.NativeMethodInfoPtr_RpcLogic___BeginFootPursuit_Networked_419679943_Public_Virtual_New_Void_NetworkObject_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoliceOfficer>.NativeClassPtr, 100668084);
			PoliceOfficer.NativeMethodInfoPtr_RpcReader___Server_BeginFootPursuit_Networked_419679943_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoliceOfficer>.NativeClassPtr, 100668085);
			PoliceOfficer.NativeMethodInfoPtr_RpcWriter___Observers_BeginFootPursuitTest_3615296227_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoliceOfficer>.NativeClassPtr, 100668086);
			PoliceOfficer.NativeMethodInfoPtr_RpcLogic___BeginFootPursuitTest_3615296227_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoliceOfficer>.NativeClassPtr, 100668087);
			PoliceOfficer.NativeMethodInfoPtr_RpcReader___Observers_BeginFootPursuitTest_3615296227_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoliceOfficer>.NativeClassPtr, 100668088);
			PoliceOfficer.NativeMethodInfoPtr_RpcWriter___Server_BeginVehiclePursuit_Networked_2261819652_Private_Void_NetworkObject_NetworkObject_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoliceOfficer>.NativeClassPtr, 100668089);
			PoliceOfficer.NativeMethodInfoPtr_RpcLogic___BeginVehiclePursuit_Networked_2261819652_Public_Virtual_New_Void_NetworkObject_NetworkObject_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoliceOfficer>.NativeClassPtr, 100668090);
			PoliceOfficer.NativeMethodInfoPtr_RpcReader___Server_BeginVehiclePursuit_Networked_2261819652_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoliceOfficer>.NativeClassPtr, 100668091);
			PoliceOfficer.NativeMethodInfoPtr_RpcWriter___Observers_BeginVehiclePursuit_2261819652_Private_Void_NetworkObject_NetworkObject_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoliceOfficer>.NativeClassPtr, 100668092);
			PoliceOfficer.NativeMethodInfoPtr_RpcLogic___BeginVehiclePursuit_2261819652_Private_Void_NetworkObject_NetworkObject_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoliceOfficer>.NativeClassPtr, 100668093);
			PoliceOfficer.NativeMethodInfoPtr_RpcReader___Observers_BeginVehiclePursuit_2261819652_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoliceOfficer>.NativeClassPtr, 100668094);
			PoliceOfficer.NativeMethodInfoPtr_RpcWriter___Server_BeginBodySearch_Networked_3323014238_Private_Void_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoliceOfficer>.NativeClassPtr, 100668095);
			PoliceOfficer.NativeMethodInfoPtr_RpcLogic___BeginBodySearch_Networked_3323014238_Public_Virtual_New_Void_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoliceOfficer>.NativeClassPtr, 100668096);
			PoliceOfficer.NativeMethodInfoPtr_RpcReader___Server_BeginBodySearch_Networked_3323014238_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoliceOfficer>.NativeClassPtr, 100668097);
			PoliceOfficer.NativeMethodInfoPtr_RpcWriter___Observers_BeginBodySearch_3323014238_Private_Void_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoliceOfficer>.NativeClassPtr, 100668098);
			PoliceOfficer.NativeMethodInfoPtr_RpcLogic___BeginBodySearch_3323014238_Private_Void_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoliceOfficer>.NativeClassPtr, 100668099);
			PoliceOfficer.NativeMethodInfoPtr_RpcReader___Observers_BeginBodySearch_3323014238_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoliceOfficer>.NativeClassPtr, 100668100);
			PoliceOfficer.NativeMethodInfoPtr_RpcWriter___Observers_AssignToCheckpoint_4087078542_Private_Void_ECheckpointLocation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoliceOfficer>.NativeClassPtr, 100668101);
			PoliceOfficer.NativeMethodInfoPtr_RpcLogic___AssignToCheckpoint_4087078542_Public_Virtual_New_Void_ECheckpointLocation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoliceOfficer>.NativeClassPtr, 100668102);
			PoliceOfficer.NativeMethodInfoPtr_RpcReader___Observers_AssignToCheckpoint_4087078542_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoliceOfficer>.NativeClassPtr, 100668103);
			PoliceOfficer.NativeMethodInfoPtr_sync___get_value__TargetPlayerNOB_k__BackingField_Public_get_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoliceOfficer>.NativeClassPtr, 100668104);
			PoliceOfficer.NativeMethodInfoPtr_sync___set_value__TargetPlayerNOB_k__BackingField_Public_set_Void_NetworkObject_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoliceOfficer>.NativeClassPtr, 100668105);
			PoliceOfficer.NativeMethodInfoPtr_ReadSyncVar___ScheduleOne_Police_PoliceOfficer_Public_Virtual_Boolean_PooledReader_UInt32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoliceOfficer>.NativeClassPtr, 100668106);
			PoliceOfficer.NativeMethodInfoPtr_Method_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoliceOfficer>.NativeClassPtr, 100668107);
		}

		// Token: 0x17000DEB RID: 3563
		// (get) Token: 0x060029A0 RID: 10656 RVA: 0x000F7AC4 File Offset: 0x000F5CC4
		// (set) Token: 0x060029A1 RID: 10657 RVA: 0x000F7B04 File Offset: 0x000F5D04
		public unsafe NetworkObject TargetPlayerNOB
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 122677, RefRangeEnd = 122678, XrefRangeStart = 122677, XrefRangeEnd = 122677, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PoliceOfficer.NativeMethodInfoPtr_get_TargetPlayerNOB_Public_get_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NetworkObject>(intPtr2) : null;
			}
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 122686, RefRangeEnd = 122690, XrefRangeStart = 122678, XrefRangeEnd = 122686, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PoliceOfficer.NativeMethodInfoPtr_set_TargetPlayerNOB_Protected_set_Void_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x060029A2 RID: 10658 RVA: 0x000F7B48 File Offset: 0x000F5D48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 122690, XrefRangeEnd = 122691, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PoliceOfficer.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060029A3 RID: 10659 RVA: 0x000F7B84 File Offset: 0x000F5D84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 122691, XrefRangeEnd = 122697, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PoliceOfficer.NativeMethodInfoPtr_Start_Protected_Virtual_Void_1), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060029A4 RID: 10660 RVA: 0x000F7BC0 File Offset: 0x000F5DC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 122697, XrefRangeEnd = 122703, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PoliceOfficer.NativeMethodInfoPtr_Update_Protected_Virtual_Void_1), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060029A5 RID: 10661 RVA: 0x000F7BFC File Offset: 0x000F5DFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 122703, XrefRangeEnd = 122795, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FixedUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PoliceOfficer.NativeMethodInfoPtr_FixedUpdate_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060029A6 RID: 10662 RVA: 0x000F7C30 File Offset: 0x000F5E30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 122795, XrefRangeEnd = 122802, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void MinPass()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PoliceOfficer.NativeMethodInfoPtr_MinPass_Protected_Virtual_Void_1), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060029A7 RID: 10663 RVA: 0x000F7C6C File Offset: 0x000F5E6C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 122867, RefRangeEnd = 122868, XrefRangeStart = 122802, XrefRangeEnd = 122867, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CheckDeactivation()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PoliceOfficer.NativeMethodInfoPtr_CheckDeactivation_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060029A8 RID: 10664 RVA: 0x000F7CA0 File Offset: 0x000F5EA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 122868, XrefRangeEnd = 122891, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void BeginFootPursuit_Networked(NetworkObject target, bool includeColleagues = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref includeColleagues;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PoliceOfficer.NativeMethodInfoPtr_BeginFootPursuit_Networked_Public_Virtual_New_Void_NetworkObject_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060029A9 RID: 10665 RVA: 0x000F7CFC File Offset: 0x000F5EFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 122891, XrefRangeEnd = 122893, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void BeginFootPursuitTest(string playerCode)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(playerCode);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PoliceOfficer.NativeMethodInfoPtr_BeginFootPursuitTest_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060029AA RID: 10666 RVA: 0x000F7D40 File Offset: 0x000F5F40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 122893, XrefRangeEnd = 122917, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void BeginVehiclePursuit_Networked(NetworkObject target, NetworkObject vehicle, bool beginAsSighted)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(vehicle);
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref beginAsSighted;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PoliceOfficer.NativeMethodInfoPtr_BeginVehiclePursuit_Networked_Public_Virtual_New_Void_NetworkObject_NetworkObject_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060029AB RID: 10667 RVA: 0x000F7DB0 File Offset: 0x000F5FB0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 122941, RefRangeEnd = 122943, XrefRangeStart = 122917, XrefRangeEnd = 122941, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void BeginVehiclePursuit(NetworkObject target, NetworkObject vehicle, bool beginAsSighted)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(vehicle);
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref beginAsSighted;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PoliceOfficer.NativeMethodInfoPtr_BeginVehiclePursuit_Private_Void_NetworkObject_NetworkObject_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060029AC RID: 10668 RVA: 0x000F7E14 File Offset: 0x000F6014
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 122943, XrefRangeEnd = 122948, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void BeginBodySearch_LocalPlayer()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PoliceOfficer.NativeMethodInfoPtr_BeginBodySearch_LocalPlayer_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060029AD RID: 10669 RVA: 0x000F7E48 File Offset: 0x000F6048
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 122948, XrefRangeEnd = 122970, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void BeginBodySearch_Networked(NetworkObject target)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PoliceOfficer.NativeMethodInfoPtr_BeginBodySearch_Networked_Public_Virtual_New_Void_NetworkObject_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060029AE RID: 10670 RVA: 0x000F7E98 File Offset: 0x000F6098
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 122992, RefRangeEnd = 122994, XrefRangeStart = 122970, XrefRangeEnd = 122992, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void BeginBodySearch(NetworkObject target)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PoliceOfficer.NativeMethodInfoPtr_BeginBodySearch_Private_Void_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060029AF RID: 10671 RVA: 0x000F7EDC File Offset: 0x000F60DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 122994, XrefRangeEnd = 123016, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void AssignToCheckpoint(CheckpointManager.ECheckpointLocation location)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref location;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PoliceOfficer.NativeMethodInfoPtr_AssignToCheckpoint_Public_Virtual_New_Void_ECheckpointLocation_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060029B0 RID: 10672 RVA: 0x000F7F28 File Offset: 0x000F6128
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 123016, XrefRangeEnd = 123022, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UnassignFromCheckpoint()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PoliceOfficer.NativeMethodInfoPtr_UnassignFromCheckpoint_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060029B1 RID: 10673 RVA: 0x000F7F5C File Offset: 0x000F615C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 123026, RefRangeEnd = 123027, XrefRangeStart = 123022, XrefRangeEnd = 123026, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StartFootPatrol(PatrolGroup group, bool warpToStartPoint)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(group);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref warpToStartPoint;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PoliceOfficer.NativeMethodInfoPtr_StartFootPatrol_Public_Void_PatrolGroup_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060029B2 RID: 10674 RVA: 0x000F7FAC File Offset: 0x000F61AC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 123031, RefRangeEnd = 123032, XrefRangeStart = 123027, XrefRangeEnd = 123031, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StartVehiclePatrol(VehiclePatrolRoute route, LandVehicle vehicle)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(route);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(vehicle);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PoliceOfficer.NativeMethodInfoPtr_StartVehiclePatrol_Public_Void_VehiclePatrolRoute_LandVehicle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060029B3 RID: 10675 RVA: 0x000F8000 File Offset: 0x000F6200
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 123032, XrefRangeEnd = 123034, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void AssignToSentryLocation(SentryLocation location)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(location);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PoliceOfficer.NativeMethodInfoPtr_AssignToSentryLocation_Public_Virtual_New_Void_SentryLocation_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060029B4 RID: 10676 RVA: 0x000F8050 File Offset: 0x000F6250
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 123036, RefRangeEnd = 123037, XrefRangeStart = 123034, XrefRangeEnd = 123036, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UnassignFromSentryLocation()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PoliceOfficer.NativeMethodInfoPtr_UnassignFromSentryLocation_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060029B5 RID: 10677 RVA: 0x000F8084 File Offset: 0x000F6284
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 123040, RefRangeEnd = 123041, XrefRangeStart = 123037, XrefRangeEnd = 123040, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Activate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PoliceOfficer.NativeMethodInfoPtr_Activate_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060029B6 RID: 10678 RVA: 0x000F80B8 File Offset: 0x000F62B8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 123063, RefRangeEnd = 123065, XrefRangeStart = 123041, XrefRangeEnd = 123063, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Deactivate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PoliceOfficer.NativeMethodInfoPtr_Deactivate_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060029B7 RID: 10679 RVA: 0x000F80EC File Offset: 0x000F62EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 123065, XrefRangeEnd = 123070, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool ShouldNoticeGeneralCrime(Player player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PoliceOfficer.NativeMethodInfoPtr_ShouldNoticeGeneralCrime_Protected_Virtual_Boolean_Player_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x060029B8 RID: 10680 RVA: 0x000F8144 File Offset: 0x000F6344
		[CallerCount(176)]
		[CachedScanResults(RefRangeStart = 38110, RefRangeEnd = 38286, XrefRangeStart = 38110, XrefRangeEnd = 38286, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool ShouldSave()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PoliceOfficer.NativeMethodInfoPtr_ShouldSave_Public_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x060029B9 RID: 10681 RVA: 0x000F818C File Offset: 0x000F638C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 123070, XrefRangeEnd = 123073, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string GetNameAddress()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PoliceOfficer.NativeMethodInfoPtr_GetNameAddress_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return IL2CPP.Il2CppStringToManaged(il2CppString);
		}

		// Token: 0x060029BA RID: 10682 RVA: 0x000F81D0 File Offset: 0x000F63D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 123073, XrefRangeEnd = 123077, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateChatter()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PoliceOfficer.NativeMethodInfoPtr_UpdateChatter_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060029BB RID: 10683 RVA: 0x000F8204 File Offset: 0x000F6404
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 123077, XrefRangeEnd = 123083, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ProcessVisionEvent(VisionEventReceipt visionEventReceipt)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(visionEventReceipt);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PoliceOfficer.NativeMethodInfoPtr_ProcessVisionEvent_Private_Void_VisionEventReceipt_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060029BC RID: 10684 RVA: 0x000F8248 File Offset: 0x000F6448
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 123083, XrefRangeEnd = 123086, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void UpdateBodySearch()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PoliceOfficer.NativeMethodInfoPtr_UpdateBodySearch_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060029BD RID: 10685 RVA: 0x000F8284 File Offset: 0x000F6484
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 123090, RefRangeEnd = 123092, XrefRangeStart = 123086, XrefRangeEnd = 123090, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool CanInvestigate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(PoliceOfficer.NativeMethodInfoPtr_CanInvestigate_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x060029BE RID: 10686 RVA: 0x000F82C0 File Offset: 0x000F64C0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 123121, RefRangeEnd = 123122, XrefRangeStart = 123092, XrefRangeEnd = 123121, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateExistingInvestigation()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PoliceOfficer.NativeMethodInfoPtr_UpdateExistingInvestigation_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060029BF RID: 10687 RVA: 0x000F82F4 File Offset: 0x000F64F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 123122, XrefRangeEnd = 123159, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CheckNewInvestigation()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PoliceOfficer.NativeMethodInfoPtr_CheckNewInvestigation_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060029C0 RID: 10688 RVA: 0x000F8328 File Offset: 0x000F6528
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 123159, XrefRangeEnd = 123171, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StartBodySearchInvestigation(Player player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PoliceOfficer.NativeMethodInfoPtr_StartBodySearchInvestigation_Private_Void_Player_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060029C1 RID: 10689 RVA: 0x000F836C File Offset: 0x000F656C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 123171, XrefRangeEnd = 123176, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StopBodySearchInvestigation()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PoliceOfficer.NativeMethodInfoPtr_StopBodySearchInvestigation_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060029C2 RID: 10690 RVA: 0x000F83A0 File Offset: 0x000F65A0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 123186, RefRangeEnd = 123187, XrefRangeStart = 123176, XrefRangeEnd = 123186, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ConductBodySearch(Player player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PoliceOfficer.NativeMethodInfoPtr_ConductBodySearch_Public_Void_Player_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060029C3 RID: 10691 RVA: 0x000F83E4 File Offset: 0x000F65E4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 123192, RefRangeEnd = 123194, XrefRangeStart = 123187, XrefRangeEnd = 123192, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool CanInvestigatePlayer(Player player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(PoliceOfficer.NativeMethodInfoPtr_CanInvestigatePlayer_Private_Boolean_Player_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x060029C4 RID: 10692 RVA: 0x000F8434 File Offset: 0x000F6634
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 123194, XrefRangeEnd = 123195, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PoliceOfficer() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PoliceOfficer>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PoliceOfficer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060029C5 RID: 10693 RVA: 0x000F8470 File Offset: 0x000F6670
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 123195, XrefRangeEnd = 123196, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _Awake_b__39_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PoliceOfficer.NativeMethodInfoPtr__Awake_b__39_0_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060029C6 RID: 10694 RVA: 0x000F84A4 File Offset: 0x000F66A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 123196, XrefRangeEnd = 123201, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator Method_Private_IEnumerator_PDM_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PoliceOfficer.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr2) : null;
		}

		// Token: 0x060029C7 RID: 10695 RVA: 0x000F84E4 File Offset: 0x000F66E4
		[CallerCount(0)]
		public unsafe bool _Deactivate_b__59_1()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(PoliceOfficer.NativeMethodInfoPtr__Deactivate_b__59_1_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x060029C8 RID: 10696 RVA: 0x000F8520 File Offset: 0x000F6720
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 123201, XrefRangeEnd = 123262, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize___Early()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PoliceOfficer.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060029C9 RID: 10697 RVA: 0x000F855C File Offset: 0x000F675C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 123262, XrefRangeEnd = 123263, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize__Late()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PoliceOfficer.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060029CA RID: 10698 RVA: 0x000F8598 File Offset: 0x000F6798
		[CallerCount(0)]
		public unsafe override void NetworkInitializeIfDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PoliceOfficer.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060029CB RID: 10699 RVA: 0x000F85D4 File Offset: 0x000F67D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 123263, XrefRangeEnd = 123274, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_BeginFootPursuit_Networked_419679943(NetworkObject target, bool includeColleagues = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref includeColleagues;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PoliceOfficer.NativeMethodInfoPtr_RpcWriter___Server_BeginFootPursuit_Networked_419679943_Private_Void_NetworkObject_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060029CC RID: 10700 RVA: 0x000F8624 File Offset: 0x000F6824
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 123344, RefRangeEnd = 123346, XrefRangeStart = 123274, XrefRangeEnd = 123344, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void RpcLogic___BeginFootPursuit_Networked_419679943(NetworkObject target, bool includeColleagues = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref includeColleagues;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PoliceOfficer.NativeMethodInfoPtr_RpcLogic___BeginFootPursuit_Networked_419679943_Public_Virtual_New_Void_NetworkObject_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060029CD RID: 10701 RVA: 0x000F8680 File Offset: 0x000F6880
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 123346, XrefRangeEnd = 123350, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_BeginFootPursuit_Networked_419679943(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref channel;
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PoliceOfficer.NativeMethodInfoPtr_RpcReader___Server_BeginFootPursuit_Networked_419679943_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060029CE RID: 10702 RVA: 0x000F86E4 File Offset: 0x000F68E4
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 123370, RefRangeEnd = 123375, XrefRangeStart = 123350, XrefRangeEnd = 123370, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_BeginFootPursuitTest_3615296227(string playerCode)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(playerCode);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PoliceOfficer.NativeMethodInfoPtr_RpcWriter___Observers_BeginFootPursuitTest_3615296227_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060029CF RID: 10703 RVA: 0x000F8728 File Offset: 0x000F6928
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 123391, RefRangeEnd = 123397, XrefRangeStart = 123375, XrefRangeEnd = 123391, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___BeginFootPursuitTest_3615296227(string playerCode)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(playerCode);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PoliceOfficer.NativeMethodInfoPtr_RpcLogic___BeginFootPursuitTest_3615296227_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060029D0 RID: 10704 RVA: 0x000F876C File Offset: 0x000F696C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 123397, XrefRangeEnd = 123401, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_BeginFootPursuitTest_3615296227(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref channel;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PoliceOfficer.NativeMethodInfoPtr_RpcReader___Observers_BeginFootPursuitTest_3615296227_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060029D1 RID: 10705 RVA: 0x000F87BC File Offset: 0x000F69BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 123401, XrefRangeEnd = 123413, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_BeginVehiclePursuit_Networked_2261819652(NetworkObject target, NetworkObject vehicle, bool beginAsSighted)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(vehicle);
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref beginAsSighted;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PoliceOfficer.NativeMethodInfoPtr_RpcWriter___Server_BeginVehiclePursuit_Networked_2261819652_Private_Void_NetworkObject_NetworkObject_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060029D2 RID: 10706 RVA: 0x000F8820 File Offset: 0x000F6A20
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 122941, RefRangeEnd = 122943, XrefRangeStart = 122941, XrefRangeEnd = 122943, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void RpcLogic___BeginVehiclePursuit_Networked_2261819652(NetworkObject target, NetworkObject vehicle, bool beginAsSighted)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(vehicle);
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref beginAsSighted;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PoliceOfficer.NativeMethodInfoPtr_RpcLogic___BeginVehiclePursuit_Networked_2261819652_Public_Virtual_New_Void_NetworkObject_NetworkObject_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060029D3 RID: 10707 RVA: 0x000F8890 File Offset: 0x000F6A90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 123413, XrefRangeEnd = 123418, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_BeginVehiclePursuit_Networked_2261819652(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref channel;
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PoliceOfficer.NativeMethodInfoPtr_RpcReader___Server_BeginVehiclePursuit_Networked_2261819652_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060029D4 RID: 10708 RVA: 0x000F88F4 File Offset: 0x000F6AF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 123418, XrefRangeEnd = 123430, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_BeginVehiclePursuit_2261819652(NetworkObject target, NetworkObject vehicle, bool beginAsSighted)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(vehicle);
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref beginAsSighted;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PoliceOfficer.NativeMethodInfoPtr_RpcWriter___Observers_BeginVehiclePursuit_2261819652_Private_Void_NetworkObject_NetworkObject_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060029D5 RID: 10709 RVA: 0x000F8958 File Offset: 0x000F6B58
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 123442, RefRangeEnd = 123445, XrefRangeStart = 123430, XrefRangeEnd = 123442, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___BeginVehiclePursuit_2261819652(NetworkObject target, NetworkObject vehicle, bool beginAsSighted)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(vehicle);
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref beginAsSighted;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PoliceOfficer.NativeMethodInfoPtr_RpcLogic___BeginVehiclePursuit_2261819652_Private_Void_NetworkObject_NetworkObject_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060029D6 RID: 10710 RVA: 0x000F89BC File Offset: 0x000F6BBC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 123445, XrefRangeEnd = 123450, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_BeginVehiclePursuit_2261819652(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref channel;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PoliceOfficer.NativeMethodInfoPtr_RpcReader___Observers_BeginVehiclePursuit_2261819652_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060029D7 RID: 10711 RVA: 0x000F8A0C File Offset: 0x000F6C0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 123450, XrefRangeEnd = 123460, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_BeginBodySearch_Networked_3323014238(NetworkObject target)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PoliceOfficer.NativeMethodInfoPtr_RpcWriter___Server_BeginBodySearch_Networked_3323014238_Private_Void_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060029D8 RID: 10712 RVA: 0x000F8A50 File Offset: 0x000F6C50
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 122992, RefRangeEnd = 122994, XrefRangeStart = 122992, XrefRangeEnd = 122994, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void RpcLogic___BeginBodySearch_Networked_3323014238(NetworkObject target)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PoliceOfficer.NativeMethodInfoPtr_RpcLogic___BeginBodySearch_Networked_3323014238_Public_Virtual_New_Void_NetworkObject_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060029D9 RID: 10713 RVA: 0x000F8AA0 File Offset: 0x000F6CA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 123460, XrefRangeEnd = 123464, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_BeginBodySearch_Networked_3323014238(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref channel;
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PoliceOfficer.NativeMethodInfoPtr_RpcReader___Server_BeginBodySearch_Networked_3323014238_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060029DA RID: 10714 RVA: 0x000F8B04 File Offset: 0x000F6D04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 123464, XrefRangeEnd = 123474, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_BeginBodySearch_3323014238(NetworkObject target)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PoliceOfficer.NativeMethodInfoPtr_RpcWriter___Observers_BeginBodySearch_3323014238_Private_Void_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060029DB RID: 10715 RVA: 0x000F8B48 File Offset: 0x000F6D48
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 123479, RefRangeEnd = 123482, XrefRangeStart = 123474, XrefRangeEnd = 123479, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___BeginBodySearch_3323014238(NetworkObject target)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PoliceOfficer.NativeMethodInfoPtr_RpcLogic___BeginBodySearch_3323014238_Private_Void_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060029DC RID: 10716 RVA: 0x000F8B8C File Offset: 0x000F6D8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 123482, XrefRangeEnd = 123486, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_BeginBodySearch_3323014238(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref channel;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PoliceOfficer.NativeMethodInfoPtr_RpcReader___Observers_BeginBodySearch_3323014238_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060029DD RID: 10717 RVA: 0x000F8BDC File Offset: 0x000F6DDC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 123486, XrefRangeEnd = 123496, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_AssignToCheckpoint_4087078542(CheckpointManager.ECheckpointLocation location)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref location;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PoliceOfficer.NativeMethodInfoPtr_RpcWriter___Observers_AssignToCheckpoint_4087078542_Private_Void_ECheckpointLocation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060029DE RID: 10718 RVA: 0x000F8C1C File Offset: 0x000F6E1C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 123510, RefRangeEnd = 123512, XrefRangeStart = 123496, XrefRangeEnd = 123510, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void RpcLogic___AssignToCheckpoint_4087078542(CheckpointManager.ECheckpointLocation location)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref location;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PoliceOfficer.NativeMethodInfoPtr_RpcLogic___AssignToCheckpoint_4087078542_Public_Virtual_New_Void_ECheckpointLocation_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060029DF RID: 10719 RVA: 0x000F8C68 File Offset: 0x000F6E68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 123512, XrefRangeEnd = 123516, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_AssignToCheckpoint_4087078542(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref channel;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PoliceOfficer.NativeMethodInfoPtr_RpcReader___Observers_AssignToCheckpoint_4087078542_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x17000DEC RID: 3564
		// (get) Token: 0x060029E0 RID: 10720 RVA: 0x000F8CB8 File Offset: 0x000F6EB8
		// (set) Token: 0x060029E1 RID: 10721 RVA: 0x000F8CF8 File Offset: 0x000F6EF8
		public unsafe NetworkObject SyncAccessor_<TargetPlayerNOB>k__BackingField
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 122677, RefRangeEnd = 122678, XrefRangeStart = 122677, XrefRangeEnd = 122678, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PoliceOfficer.NativeMethodInfoPtr_sync___get_value__TargetPlayerNOB_k__BackingField_Public_get_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NetworkObject>(intPtr2) : null;
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 123525, RefRangeEnd = 123526, XrefRangeStart = 123516, XrefRangeEnd = 123525, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref value;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PoliceOfficer.NativeMethodInfoPtr_sync___set_value__TargetPlayerNOB_k__BackingField_Public_set_Void_NetworkObject_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x060029E2 RID: 10722 RVA: 0x000F8D48 File Offset: 0x000F6F48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 123526, XrefRangeEnd = 123530, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool ReadSyncVar___ScheduleOne_Police_PoliceOfficer(PooledReader PooledReader0, uint UInt321, bool Boolean2)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref UInt321;
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref Boolean2;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PoliceOfficer.NativeMethodInfoPtr_ReadSyncVar___ScheduleOne_Police_PoliceOfficer_Public_Virtual_Boolean_PooledReader_UInt32_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x060029E3 RID: 10723 RVA: 0x000F8DBC File Offset: 0x000F6FBC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 123572, RefRangeEnd = 123573, XrefRangeStart = 123530, XrefRangeEnd = 123572, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Method_Protected_Virtual_Void_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PoliceOfficer.NativeMethodInfoPtr_Method_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060029E4 RID: 10724 RVA: 0x00016768 File Offset: 0x00014968
		public PoliceOfficer(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000DC4 RID: 3524
		// (get) Token: 0x060029E5 RID: 10725 RVA: 0x000F8DF8 File Offset: 0x000F6FF8
		// (set) Token: 0x060029E6 RID: 10726 RVA: 0x00016771 File Offset: 0x00014971
		public unsafe static float DEACTIVATION_TIME
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(PoliceOfficer.NativeFieldInfoPtr_DEACTIVATION_TIME, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PoliceOfficer.NativeFieldInfoPtr_DEACTIVATION_TIME, (void*)(&value));
			}
		}

		// Token: 0x17000DC5 RID: 3525
		// (get) Token: 0x060029E7 RID: 10727 RVA: 0x000F8E14 File Offset: 0x000F7014
		// (set) Token: 0x060029E8 RID: 10728 RVA: 0x0001677F File Offset: 0x0001497F
		public unsafe static float INVESTIGATION_COOLDOWN
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(PoliceOfficer.NativeFieldInfoPtr_INVESTIGATION_COOLDOWN, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PoliceOfficer.NativeFieldInfoPtr_INVESTIGATION_COOLDOWN, (void*)(&value));
			}
		}

		// Token: 0x17000DC6 RID: 3526
		// (get) Token: 0x060029E9 RID: 10729 RVA: 0x000F8E30 File Offset: 0x000F7030
		// (set) Token: 0x060029EA RID: 10730 RVA: 0x0001678D File Offset: 0x0001498D
		public unsafe static float INVESTIGATION_MAX_DISTANCE
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(PoliceOfficer.NativeFieldInfoPtr_INVESTIGATION_MAX_DISTANCE, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PoliceOfficer.NativeFieldInfoPtr_INVESTIGATION_MAX_DISTANCE, (void*)(&value));
			}
		}

		// Token: 0x17000DC7 RID: 3527
		// (get) Token: 0x060029EB RID: 10731 RVA: 0x000F8E4C File Offset: 0x000F704C
		// (set) Token: 0x060029EC RID: 10732 RVA: 0x0001679B File Offset: 0x0001499B
		public unsafe static float INVESTIGATION_MIN_VISIBILITY
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(PoliceOfficer.NativeFieldInfoPtr_INVESTIGATION_MIN_VISIBILITY, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PoliceOfficer.NativeFieldInfoPtr_INVESTIGATION_MIN_VISIBILITY, (void*)(&value));
			}
		}

		// Token: 0x17000DC8 RID: 3528
		// (get) Token: 0x060029ED RID: 10733 RVA: 0x000F8E68 File Offset: 0x000F7068
		// (set) Token: 0x060029EE RID: 10734 RVA: 0x000167A9 File Offset: 0x000149A9
		public unsafe static float INVESTIGATION_CHECK_INTERVAL
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(PoliceOfficer.NativeFieldInfoPtr_INVESTIGATION_CHECK_INTERVAL, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PoliceOfficer.NativeFieldInfoPtr_INVESTIGATION_CHECK_INTERVAL, (void*)(&value));
			}
		}

		// Token: 0x17000DC9 RID: 3529
		// (get) Token: 0x060029EF RID: 10735 RVA: 0x000F8E84 File Offset: 0x000F7084
		// (set) Token: 0x060029F0 RID: 10736 RVA: 0x000167B7 File Offset: 0x000149B7
		public unsafe static float BODY_SEARCH_CHANCE_DEFAULT
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(PoliceOfficer.NativeFieldInfoPtr_BODY_SEARCH_CHANCE_DEFAULT, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PoliceOfficer.NativeFieldInfoPtr_BODY_SEARCH_CHANCE_DEFAULT, (void*)(&value));
			}
		}

		// Token: 0x17000DCA RID: 3530
		// (get) Token: 0x060029F1 RID: 10737 RVA: 0x000F8EA0 File Offset: 0x000F70A0
		// (set) Token: 0x060029F2 RID: 10738 RVA: 0x000167C5 File Offset: 0x000149C5
		public unsafe static float MIN_CHATTER_INTERVAL
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(PoliceOfficer.NativeFieldInfoPtr_MIN_CHATTER_INTERVAL, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PoliceOfficer.NativeFieldInfoPtr_MIN_CHATTER_INTERVAL, (void*)(&value));
			}
		}

		// Token: 0x17000DCB RID: 3531
		// (get) Token: 0x060029F3 RID: 10739 RVA: 0x000F8EBC File Offset: 0x000F70BC
		// (set) Token: 0x060029F4 RID: 10740 RVA: 0x000167D3 File Offset: 0x000149D3
		public unsafe static float MAX_CHATTER_INTERVAL
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(PoliceOfficer.NativeFieldInfoPtr_MAX_CHATTER_INTERVAL, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PoliceOfficer.NativeFieldInfoPtr_MAX_CHATTER_INTERVAL, (void*)(&value));
			}
		}

		// Token: 0x17000DCC RID: 3532
		// (get) Token: 0x060029F5 RID: 10741 RVA: 0x000F8ED8 File Offset: 0x000F70D8
		// (set) Token: 0x060029F6 RID: 10742 RVA: 0x000167E1 File Offset: 0x000149E1
		public unsafe static Il2CppSystem.Action<VisionEventReceipt> OnPoliceVisionEvent
		{
			get
			{
				System.IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(PoliceOfficer.NativeFieldInfoPtr_OnPoliceVisionEvent, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Action<VisionEventReceipt>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PoliceOfficer.NativeFieldInfoPtr_OnPoliceVisionEvent, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000DCD RID: 3533
		// (get) Token: 0x060029F7 RID: 10743 RVA: 0x000F8F00 File Offset: 0x000F7100
		// (set) Token: 0x060029F8 RID: 10744 RVA: 0x000167F3 File Offset: 0x000149F3
		public unsafe static List<PoliceOfficer> Officers
		{
			get
			{
				System.IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(PoliceOfficer.NativeFieldInfoPtr_Officers, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<PoliceOfficer>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PoliceOfficer.NativeFieldInfoPtr_Officers, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000DCE RID: 3534
		// (get) Token: 0x060029F9 RID: 10745 RVA: 0x000F8F28 File Offset: 0x000F7128
		// (set) Token: 0x060029FA RID: 10746 RVA: 0x00016805 File Offset: 0x00014A05
		public unsafe NetworkObject _TargetPlayerNOB_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PoliceOfficer.NativeFieldInfoPtr__TargetPlayerNOB_k__BackingField);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NetworkObject>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PoliceOfficer.NativeFieldInfoPtr__TargetPlayerNOB_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000DCF RID: 3535
		// (get) Token: 0x060029FB RID: 10747 RVA: 0x000F8F58 File Offset: 0x000F7158
		// (set) Token: 0x060029FC RID: 10748 RVA: 0x00016824 File Offset: 0x00014A24
		public unsafe LandVehicle AssignedVehicle
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PoliceOfficer.NativeFieldInfoPtr_AssignedVehicle);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LandVehicle>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PoliceOfficer.NativeFieldInfoPtr_AssignedVehicle), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000DD0 RID: 3536
		// (get) Token: 0x060029FD RID: 10749 RVA: 0x000F8F88 File Offset: 0x000F7188
		// (set) Token: 0x060029FE RID: 10750 RVA: 0x00016843 File Offset: 0x00014A43
		public unsafe PursuitBehaviour PursuitBehaviour
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PoliceOfficer.NativeFieldInfoPtr_PursuitBehaviour);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PursuitBehaviour>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PoliceOfficer.NativeFieldInfoPtr_PursuitBehaviour), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000DD1 RID: 3537
		// (get) Token: 0x060029FF RID: 10751 RVA: 0x000F8FB8 File Offset: 0x000F71B8
		// (set) Token: 0x06002A00 RID: 10752 RVA: 0x00016862 File Offset: 0x00014A62
		public unsafe VehiclePursuitBehaviour VehiclePursuitBehaviour
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PoliceOfficer.NativeFieldInfoPtr_VehiclePursuitBehaviour);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<VehiclePursuitBehaviour>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PoliceOfficer.NativeFieldInfoPtr_VehiclePursuitBehaviour), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000DD2 RID: 3538
		// (get) Token: 0x06002A01 RID: 10753 RVA: 0x000F8FE8 File Offset: 0x000F71E8
		// (set) Token: 0x06002A02 RID: 10754 RVA: 0x00016881 File Offset: 0x00014A81
		public unsafe BodySearchBehaviour BodySearchBehaviour
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PoliceOfficer.NativeFieldInfoPtr_BodySearchBehaviour);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BodySearchBehaviour>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PoliceOfficer.NativeFieldInfoPtr_BodySearchBehaviour), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000DD3 RID: 3539
		// (get) Token: 0x06002A03 RID: 10755 RVA: 0x000F9018 File Offset: 0x000F7218
		// (set) Token: 0x06002A04 RID: 10756 RVA: 0x000168A0 File Offset: 0x00014AA0
		public unsafe CheckpointBehaviour CheckpointBehaviour
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PoliceOfficer.NativeFieldInfoPtr_CheckpointBehaviour);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CheckpointBehaviour>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PoliceOfficer.NativeFieldInfoPtr_CheckpointBehaviour), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000DD4 RID: 3540
		// (get) Token: 0x06002A05 RID: 10757 RVA: 0x000F9048 File Offset: 0x000F7248
		// (set) Token: 0x06002A06 RID: 10758 RVA: 0x000168BF File Offset: 0x00014ABF
		public unsafe FootPatrolBehaviour FootPatrolBehaviour
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PoliceOfficer.NativeFieldInfoPtr_FootPatrolBehaviour);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FootPatrolBehaviour>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PoliceOfficer.NativeFieldInfoPtr_FootPatrolBehaviour), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000DD5 RID: 3541
		// (get) Token: 0x06002A07 RID: 10759 RVA: 0x000F9078 File Offset: 0x000F7278
		// (set) Token: 0x06002A08 RID: 10760 RVA: 0x000168DE File Offset: 0x00014ADE
		public unsafe ProximityCircle ProxCircle
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PoliceOfficer.NativeFieldInfoPtr_ProxCircle);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ProximityCircle>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PoliceOfficer.NativeFieldInfoPtr_ProxCircle), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000DD6 RID: 3542
		// (get) Token: 0x06002A09 RID: 10761 RVA: 0x000F90A8 File Offset: 0x000F72A8
		// (set) Token: 0x06002A0A RID: 10762 RVA: 0x000168FD File Offset: 0x00014AFD
		public unsafe VehiclePatrolBehaviour VehiclePatrolBehaviour
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PoliceOfficer.NativeFieldInfoPtr_VehiclePatrolBehaviour);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<VehiclePatrolBehaviour>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PoliceOfficer.NativeFieldInfoPtr_VehiclePatrolBehaviour), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000DD7 RID: 3543
		// (get) Token: 0x06002A0B RID: 10763 RVA: 0x000F90D8 File Offset: 0x000F72D8
		// (set) Token: 0x06002A0C RID: 10764 RVA: 0x0001691C File Offset: 0x00014B1C
		public unsafe SentryBehaviour SentryBehaviour
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PoliceOfficer.NativeFieldInfoPtr_SentryBehaviour);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SentryBehaviour>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PoliceOfficer.NativeFieldInfoPtr_SentryBehaviour), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000DD8 RID: 3544
		// (get) Token: 0x06002A0D RID: 10765 RVA: 0x000F9108 File Offset: 0x000F7308
		// (set) Token: 0x06002A0E RID: 10766 RVA: 0x0001693B File Offset: 0x00014B3B
		public unsafe PoliceChatterVO ChatterVO
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PoliceOfficer.NativeFieldInfoPtr_ChatterVO);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PoliceChatterVO>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PoliceOfficer.NativeFieldInfoPtr_ChatterVO), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000DD9 RID: 3545
		// (get) Token: 0x06002A0F RID: 10767 RVA: 0x000F9138 File Offset: 0x000F7338
		// (set) Token: 0x06002A10 RID: 10768 RVA: 0x0001695A File Offset: 0x00014B5A
		public unsafe DialogueContainer CheckpointDialogue
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PoliceOfficer.NativeFieldInfoPtr_CheckpointDialogue);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DialogueContainer>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PoliceOfficer.NativeFieldInfoPtr_CheckpointDialogue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000DDA RID: 3546
		// (get) Token: 0x06002A11 RID: 10769 RVA: 0x000F9168 File Offset: 0x000F7368
		// (set) Token: 0x06002A12 RID: 10770 RVA: 0x00016979 File Offset: 0x00014B79
		public unsafe AvatarEquippable BatonPrefab
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PoliceOfficer.NativeFieldInfoPtr_BatonPrefab);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AvatarEquippable>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PoliceOfficer.NativeFieldInfoPtr_BatonPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000DDB RID: 3547
		// (get) Token: 0x06002A13 RID: 10771 RVA: 0x000F9198 File Offset: 0x000F7398
		// (set) Token: 0x06002A14 RID: 10772 RVA: 0x00016998 File Offset: 0x00014B98
		public unsafe AvatarEquippable TaserPrefab
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PoliceOfficer.NativeFieldInfoPtr_TaserPrefab);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AvatarEquippable>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PoliceOfficer.NativeFieldInfoPtr_TaserPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000DDC RID: 3548
		// (get) Token: 0x06002A15 RID: 10773 RVA: 0x000F91C8 File Offset: 0x000F73C8
		// (set) Token: 0x06002A16 RID: 10774 RVA: 0x000169B7 File Offset: 0x00014BB7
		public unsafe AvatarEquippable GunPrefab
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PoliceOfficer.NativeFieldInfoPtr_GunPrefab);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AvatarEquippable>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PoliceOfficer.NativeFieldInfoPtr_GunPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000DDD RID: 3549
		// (get) Token: 0x06002A17 RID: 10775 RVA: 0x000F91F8 File Offset: 0x000F73F8
		// (set) Token: 0x06002A18 RID: 10776 RVA: 0x000169D6 File Offset: 0x00014BD6
		public unsafe bool AutoDeactivate
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PoliceOfficer.NativeFieldInfoPtr_AutoDeactivate);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PoliceOfficer.NativeFieldInfoPtr_AutoDeactivate)) = value;
			}
		}

		// Token: 0x17000DDE RID: 3550
		// (get) Token: 0x06002A19 RID: 10777 RVA: 0x000F9220 File Offset: 0x000F7420
		// (set) Token: 0x06002A1A RID: 10778 RVA: 0x000169F1 File Offset: 0x00014BF1
		public unsafe bool ChatterEnabled
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PoliceOfficer.NativeFieldInfoPtr_ChatterEnabled);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PoliceOfficer.NativeFieldInfoPtr_ChatterEnabled)) = value;
			}
		}

		// Token: 0x17000DDF RID: 3551
		// (get) Token: 0x06002A1B RID: 10779 RVA: 0x000F9248 File Offset: 0x000F7448
		// (set) Token: 0x06002A1C RID: 10780 RVA: 0x00016A0C File Offset: 0x00014C0C
		public unsafe float Suspicion
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PoliceOfficer.NativeFieldInfoPtr_Suspicion);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PoliceOfficer.NativeFieldInfoPtr_Suspicion)) = value;
			}
		}

		// Token: 0x17000DE0 RID: 3552
		// (get) Token: 0x06002A1D RID: 10781 RVA: 0x000F9270 File Offset: 0x000F7470
		// (set) Token: 0x06002A1E RID: 10782 RVA: 0x00016A27 File Offset: 0x00014C27
		public unsafe float Leniency
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PoliceOfficer.NativeFieldInfoPtr_Leniency);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PoliceOfficer.NativeFieldInfoPtr_Leniency)) = value;
			}
		}

		// Token: 0x17000DE1 RID: 3553
		// (get) Token: 0x06002A1F RID: 10783 RVA: 0x000F9298 File Offset: 0x000F7498
		// (set) Token: 0x06002A20 RID: 10784 RVA: 0x00016A42 File Offset: 0x00014C42
		public unsafe float BodySearchChance
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PoliceOfficer.NativeFieldInfoPtr_BodySearchChance);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PoliceOfficer.NativeFieldInfoPtr_BodySearchChance)) = value;
			}
		}

		// Token: 0x17000DE2 RID: 3554
		// (get) Token: 0x06002A21 RID: 10785 RVA: 0x000F92C0 File Offset: 0x000F74C0
		// (set) Token: 0x06002A22 RID: 10786 RVA: 0x00016A5D File Offset: 0x00014C5D
		public unsafe float BodySearchDuration
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PoliceOfficer.NativeFieldInfoPtr_BodySearchDuration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PoliceOfficer.NativeFieldInfoPtr_BodySearchDuration)) = value;
			}
		}

		// Token: 0x17000DE3 RID: 3555
		// (get) Token: 0x06002A23 RID: 10787 RVA: 0x000F92E8 File Offset: 0x000F74E8
		// (set) Token: 0x06002A24 RID: 10788 RVA: 0x00016A78 File Offset: 0x00014C78
		public unsafe PoliceBelt belt
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PoliceOfficer.NativeFieldInfoPtr_belt);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PoliceBelt>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PoliceOfficer.NativeFieldInfoPtr_belt), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000DE4 RID: 3556
		// (get) Token: 0x06002A25 RID: 10789 RVA: 0x000F9318 File Offset: 0x000F7518
		// (set) Token: 0x06002A26 RID: 10790 RVA: 0x00016A97 File Offset: 0x00014C97
		public unsafe float timeSinceReadyToPool
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PoliceOfficer.NativeFieldInfoPtr_timeSinceReadyToPool);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PoliceOfficer.NativeFieldInfoPtr_timeSinceReadyToPool)) = value;
			}
		}

		// Token: 0x17000DE5 RID: 3557
		// (get) Token: 0x06002A27 RID: 10791 RVA: 0x000F9340 File Offset: 0x000F7540
		// (set) Token: 0x06002A28 RID: 10792 RVA: 0x00016AB2 File Offset: 0x00014CB2
		public unsafe float timeSinceOutOfSight
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PoliceOfficer.NativeFieldInfoPtr_timeSinceOutOfSight);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PoliceOfficer.NativeFieldInfoPtr_timeSinceOutOfSight)) = value;
			}
		}

		// Token: 0x17000DE6 RID: 3558
		// (get) Token: 0x06002A29 RID: 10793 RVA: 0x000F9368 File Offset: 0x000F7568
		// (set) Token: 0x06002A2A RID: 10794 RVA: 0x00016ACD File Offset: 0x00014CCD
		public unsafe float chatterCountDown
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PoliceOfficer.NativeFieldInfoPtr_chatterCountDown);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PoliceOfficer.NativeFieldInfoPtr_chatterCountDown)) = value;
			}
		}

		// Token: 0x17000DE7 RID: 3559
		// (get) Token: 0x06002A2B RID: 10795 RVA: 0x000F9390 File Offset: 0x000F7590
		// (set) Token: 0x06002A2C RID: 10796 RVA: 0x00016AE8 File Offset: 0x00014CE8
		public unsafe Investigation currentBodySearchInvestigation
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PoliceOfficer.NativeFieldInfoPtr_currentBodySearchInvestigation);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Investigation>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PoliceOfficer.NativeFieldInfoPtr_currentBodySearchInvestigation), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000DE8 RID: 3560
		// (get) Token: 0x06002A2D RID: 10797 RVA: 0x000F93C0 File Offset: 0x000F75C0
		// (set) Token: 0x06002A2E RID: 10798 RVA: 0x00016B07 File Offset: 0x00014D07
		public unsafe SyncVar<NetworkObject> syncVar____TargetPlayerNOB_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PoliceOfficer.NativeFieldInfoPtr_syncVar____TargetPlayerNOB_k__BackingField);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SyncVar<NetworkObject>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PoliceOfficer.NativeFieldInfoPtr_syncVar____TargetPlayerNOB_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000DE9 RID: 3561
		// (get) Token: 0x06002A2F RID: 10799 RVA: 0x000F93F0 File Offset: 0x000F75F0
		// (set) Token: 0x06002A30 RID: 10800 RVA: 0x00016B26 File Offset: 0x00014D26
		public new unsafe bool field_Private_Boolean_0
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PoliceOfficer.NativeFieldInfoPtr_field_Private_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PoliceOfficer.NativeFieldInfoPtr_field_Private_Boolean_0)) = value;
			}
		}

		// Token: 0x17000DEA RID: 3562
		// (get) Token: 0x06002A31 RID: 10801 RVA: 0x000F9418 File Offset: 0x000F7618
		// (set) Token: 0x06002A32 RID: 10802 RVA: 0x00016B41 File Offset: 0x00014D41
		public new unsafe bool field_Private_Boolean_1
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PoliceOfficer.NativeFieldInfoPtr_field_Private_Boolean_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PoliceOfficer.NativeFieldInfoPtr_field_Private_Boolean_1)) = value;
			}
		}

		// Token: 0x04001B9B RID: 7067
		private static readonly System.IntPtr NativeFieldInfoPtr_DEACTIVATION_TIME;

		// Token: 0x04001B9C RID: 7068
		private static readonly System.IntPtr NativeFieldInfoPtr_INVESTIGATION_COOLDOWN;

		// Token: 0x04001B9D RID: 7069
		private static readonly System.IntPtr NativeFieldInfoPtr_INVESTIGATION_MAX_DISTANCE;

		// Token: 0x04001B9E RID: 7070
		private static readonly System.IntPtr NativeFieldInfoPtr_INVESTIGATION_MIN_VISIBILITY;

		// Token: 0x04001B9F RID: 7071
		private static readonly System.IntPtr NativeFieldInfoPtr_INVESTIGATION_CHECK_INTERVAL;

		// Token: 0x04001BA0 RID: 7072
		private static readonly System.IntPtr NativeFieldInfoPtr_BODY_SEARCH_CHANCE_DEFAULT;

		// Token: 0x04001BA1 RID: 7073
		private static readonly System.IntPtr NativeFieldInfoPtr_MIN_CHATTER_INTERVAL;

		// Token: 0x04001BA2 RID: 7074
		private static readonly System.IntPtr NativeFieldInfoPtr_MAX_CHATTER_INTERVAL;

		// Token: 0x04001BA3 RID: 7075
		private static readonly System.IntPtr NativeFieldInfoPtr_OnPoliceVisionEvent;

		// Token: 0x04001BA4 RID: 7076
		private static readonly System.IntPtr NativeFieldInfoPtr_Officers;

		// Token: 0x04001BA5 RID: 7077
		private static readonly System.IntPtr NativeFieldInfoPtr__TargetPlayerNOB_k__BackingField;

		// Token: 0x04001BA6 RID: 7078
		private static readonly System.IntPtr NativeFieldInfoPtr_AssignedVehicle;

		// Token: 0x04001BA7 RID: 7079
		private static readonly System.IntPtr NativeFieldInfoPtr_PursuitBehaviour;

		// Token: 0x04001BA8 RID: 7080
		private static readonly System.IntPtr NativeFieldInfoPtr_VehiclePursuitBehaviour;

		// Token: 0x04001BA9 RID: 7081
		private static readonly System.IntPtr NativeFieldInfoPtr_BodySearchBehaviour;

		// Token: 0x04001BAA RID: 7082
		private static readonly System.IntPtr NativeFieldInfoPtr_CheckpointBehaviour;

		// Token: 0x04001BAB RID: 7083
		private static readonly System.IntPtr NativeFieldInfoPtr_FootPatrolBehaviour;

		// Token: 0x04001BAC RID: 7084
		private static readonly System.IntPtr NativeFieldInfoPtr_ProxCircle;

		// Token: 0x04001BAD RID: 7085
		private static readonly System.IntPtr NativeFieldInfoPtr_VehiclePatrolBehaviour;

		// Token: 0x04001BAE RID: 7086
		private static readonly System.IntPtr NativeFieldInfoPtr_SentryBehaviour;

		// Token: 0x04001BAF RID: 7087
		private static readonly System.IntPtr NativeFieldInfoPtr_ChatterVO;

		// Token: 0x04001BB0 RID: 7088
		private static readonly System.IntPtr NativeFieldInfoPtr_CheckpointDialogue;

		// Token: 0x04001BB1 RID: 7089
		private static readonly System.IntPtr NativeFieldInfoPtr_BatonPrefab;

		// Token: 0x04001BB2 RID: 7090
		private static readonly System.IntPtr NativeFieldInfoPtr_TaserPrefab;

		// Token: 0x04001BB3 RID: 7091
		private static readonly System.IntPtr NativeFieldInfoPtr_GunPrefab;

		// Token: 0x04001BB4 RID: 7092
		private static readonly System.IntPtr NativeFieldInfoPtr_AutoDeactivate;

		// Token: 0x04001BB5 RID: 7093
		private static readonly System.IntPtr NativeFieldInfoPtr_ChatterEnabled;

		// Token: 0x04001BB6 RID: 7094
		private static readonly System.IntPtr NativeFieldInfoPtr_Suspicion;

		// Token: 0x04001BB7 RID: 7095
		private static readonly System.IntPtr NativeFieldInfoPtr_Leniency;

		// Token: 0x04001BB8 RID: 7096
		private static readonly System.IntPtr NativeFieldInfoPtr_BodySearchChance;

		// Token: 0x04001BB9 RID: 7097
		private static readonly System.IntPtr NativeFieldInfoPtr_BodySearchDuration;

		// Token: 0x04001BBA RID: 7098
		private static readonly System.IntPtr NativeFieldInfoPtr_belt;

		// Token: 0x04001BBB RID: 7099
		private static readonly System.IntPtr NativeFieldInfoPtr_timeSinceReadyToPool;

		// Token: 0x04001BBC RID: 7100
		private static readonly System.IntPtr NativeFieldInfoPtr_timeSinceOutOfSight;

		// Token: 0x04001BBD RID: 7101
		private static readonly System.IntPtr NativeFieldInfoPtr_chatterCountDown;

		// Token: 0x04001BBE RID: 7102
		private static readonly System.IntPtr NativeFieldInfoPtr_currentBodySearchInvestigation;

		// Token: 0x04001BBF RID: 7103
		private static readonly System.IntPtr NativeFieldInfoPtr_syncVar____TargetPlayerNOB_k__BackingField;

		// Token: 0x04001BC0 RID: 7104
		private static readonly System.IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

		// Token: 0x04001BC1 RID: 7105
		private static readonly System.IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

		// Token: 0x04001BC2 RID: 7106
		private static readonly System.IntPtr NativeMethodInfoPtr_get_TargetPlayerNOB_Public_get_NetworkObject_0;

		// Token: 0x04001BC3 RID: 7107
		private static readonly System.IntPtr NativeMethodInfoPtr_set_TargetPlayerNOB_Protected_set_Void_NetworkObject_0;

		// Token: 0x04001BC4 RID: 7108
		private static readonly System.IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;

		// Token: 0x04001BC5 RID: 7109
		private static readonly System.IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_1;

		// Token: 0x04001BC6 RID: 7110
		private static readonly System.IntPtr NativeMethodInfoPtr_Update_Protected_Virtual_Void_1;

		// Token: 0x04001BC7 RID: 7111
		private static readonly System.IntPtr NativeMethodInfoPtr_FixedUpdate_Protected_Void_0;

		// Token: 0x04001BC8 RID: 7112
		private static readonly System.IntPtr NativeMethodInfoPtr_MinPass_Protected_Virtual_Void_1;

		// Token: 0x04001BC9 RID: 7113
		private static readonly System.IntPtr NativeMethodInfoPtr_CheckDeactivation_Private_Void_0;

		// Token: 0x04001BCA RID: 7114
		private static readonly System.IntPtr NativeMethodInfoPtr_BeginFootPursuit_Networked_Public_Virtual_New_Void_NetworkObject_Boolean_0;

		// Token: 0x04001BCB RID: 7115
		private static readonly System.IntPtr NativeMethodInfoPtr_BeginFootPursuitTest_Private_Void_String_0;

		// Token: 0x04001BCC RID: 7116
		private static readonly System.IntPtr NativeMethodInfoPtr_BeginVehiclePursuit_Networked_Public_Virtual_New_Void_NetworkObject_NetworkObject_Boolean_0;

		// Token: 0x04001BCD RID: 7117
		private static readonly System.IntPtr NativeMethodInfoPtr_BeginVehiclePursuit_Private_Void_NetworkObject_NetworkObject_Boolean_0;

		// Token: 0x04001BCE RID: 7118
		private static readonly System.IntPtr NativeMethodInfoPtr_BeginBodySearch_LocalPlayer_Public_Void_0;

		// Token: 0x04001BCF RID: 7119
		private static readonly System.IntPtr NativeMethodInfoPtr_BeginBodySearch_Networked_Public_Virtual_New_Void_NetworkObject_0;

		// Token: 0x04001BD0 RID: 7120
		private static readonly System.IntPtr NativeMethodInfoPtr_BeginBodySearch_Private_Void_NetworkObject_0;

		// Token: 0x04001BD1 RID: 7121
		private static readonly System.IntPtr NativeMethodInfoPtr_AssignToCheckpoint_Public_Virtual_New_Void_ECheckpointLocation_0;

		// Token: 0x04001BD2 RID: 7122
		private static readonly System.IntPtr NativeMethodInfoPtr_UnassignFromCheckpoint_Public_Void_0;

		// Token: 0x04001BD3 RID: 7123
		private static readonly System.IntPtr NativeMethodInfoPtr_StartFootPatrol_Public_Void_PatrolGroup_Boolean_0;

		// Token: 0x04001BD4 RID: 7124
		private static readonly System.IntPtr NativeMethodInfoPtr_StartVehiclePatrol_Public_Void_VehiclePatrolRoute_LandVehicle_0;

		// Token: 0x04001BD5 RID: 7125
		private static readonly System.IntPtr NativeMethodInfoPtr_AssignToSentryLocation_Public_Virtual_New_Void_SentryLocation_0;

		// Token: 0x04001BD6 RID: 7126
		private static readonly System.IntPtr NativeMethodInfoPtr_UnassignFromSentryLocation_Public_Void_0;

		// Token: 0x04001BD7 RID: 7127
		private static readonly System.IntPtr NativeMethodInfoPtr_Activate_Public_Void_0;

		// Token: 0x04001BD8 RID: 7128
		private static readonly System.IntPtr NativeMethodInfoPtr_Deactivate_Public_Void_0;

		// Token: 0x04001BD9 RID: 7129
		private static readonly System.IntPtr NativeMethodInfoPtr_ShouldNoticeGeneralCrime_Protected_Virtual_Boolean_Player_0;

		// Token: 0x04001BDA RID: 7130
		private static readonly System.IntPtr NativeMethodInfoPtr_ShouldSave_Public_Virtual_Boolean_0;

		// Token: 0x04001BDB RID: 7131
		private static readonly System.IntPtr NativeMethodInfoPtr_GetNameAddress_Public_Virtual_String_0;

		// Token: 0x04001BDC RID: 7132
		private static readonly System.IntPtr NativeMethodInfoPtr_UpdateChatter_Private_Void_0;

		// Token: 0x04001BDD RID: 7133
		private static readonly System.IntPtr NativeMethodInfoPtr_ProcessVisionEvent_Private_Void_VisionEventReceipt_0;

		// Token: 0x04001BDE RID: 7134
		private static readonly System.IntPtr NativeMethodInfoPtr_UpdateBodySearch_Public_Virtual_New_Void_0;

		// Token: 0x04001BDF RID: 7135
		private static readonly System.IntPtr NativeMethodInfoPtr_CanInvestigate_Private_Boolean_0;

		// Token: 0x04001BE0 RID: 7136
		private static readonly System.IntPtr NativeMethodInfoPtr_UpdateExistingInvestigation_Private_Void_0;

		// Token: 0x04001BE1 RID: 7137
		private static readonly System.IntPtr NativeMethodInfoPtr_CheckNewInvestigation_Private_Void_0;

		// Token: 0x04001BE2 RID: 7138
		private static readonly System.IntPtr NativeMethodInfoPtr_StartBodySearchInvestigation_Private_Void_Player_0;

		// Token: 0x04001BE3 RID: 7139
		private static readonly System.IntPtr NativeMethodInfoPtr_StopBodySearchInvestigation_Private_Void_0;

		// Token: 0x04001BE4 RID: 7140
		private static readonly System.IntPtr NativeMethodInfoPtr_ConductBodySearch_Public_Void_Player_0;

		// Token: 0x04001BE5 RID: 7141
		private static readonly System.IntPtr NativeMethodInfoPtr_CanInvestigatePlayer_Private_Boolean_Player_0;

		// Token: 0x04001BE6 RID: 7142
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04001BE7 RID: 7143
		private static readonly System.IntPtr NativeMethodInfoPtr__Awake_b__39_0_Private_Void_0;

		// Token: 0x04001BE8 RID: 7144
		private static readonly System.IntPtr NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0;

		// Token: 0x04001BE9 RID: 7145
		private static readonly System.IntPtr NativeMethodInfoPtr__Deactivate_b__59_1_Private_Boolean_0;

		// Token: 0x04001BEA RID: 7146
		private static readonly System.IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

		// Token: 0x04001BEB RID: 7147
		private static readonly System.IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

		// Token: 0x04001BEC RID: 7148
		private static readonly System.IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

		// Token: 0x04001BED RID: 7149
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcWriter___Server_BeginFootPursuit_Networked_419679943_Private_Void_NetworkObject_Boolean_0;

		// Token: 0x04001BEE RID: 7150
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcLogic___BeginFootPursuit_Networked_419679943_Public_Virtual_New_Void_NetworkObject_Boolean_0;

		// Token: 0x04001BEF RID: 7151
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcReader___Server_BeginFootPursuit_Networked_419679943_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x04001BF0 RID: 7152
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcWriter___Observers_BeginFootPursuitTest_3615296227_Private_Void_String_0;

		// Token: 0x04001BF1 RID: 7153
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcLogic___BeginFootPursuitTest_3615296227_Private_Void_String_0;

		// Token: 0x04001BF2 RID: 7154
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcReader___Observers_BeginFootPursuitTest_3615296227_Private_Void_PooledReader_Channel_0;

		// Token: 0x04001BF3 RID: 7155
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcWriter___Server_BeginVehiclePursuit_Networked_2261819652_Private_Void_NetworkObject_NetworkObject_Boolean_0;

		// Token: 0x04001BF4 RID: 7156
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcLogic___BeginVehiclePursuit_Networked_2261819652_Public_Virtual_New_Void_NetworkObject_NetworkObject_Boolean_0;

		// Token: 0x04001BF5 RID: 7157
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcReader___Server_BeginVehiclePursuit_Networked_2261819652_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x04001BF6 RID: 7158
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcWriter___Observers_BeginVehiclePursuit_2261819652_Private_Void_NetworkObject_NetworkObject_Boolean_0;

		// Token: 0x04001BF7 RID: 7159
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcLogic___BeginVehiclePursuit_2261819652_Private_Void_NetworkObject_NetworkObject_Boolean_0;

		// Token: 0x04001BF8 RID: 7160
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcReader___Observers_BeginVehiclePursuit_2261819652_Private_Void_PooledReader_Channel_0;

		// Token: 0x04001BF9 RID: 7161
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcWriter___Server_BeginBodySearch_Networked_3323014238_Private_Void_NetworkObject_0;

		// Token: 0x04001BFA RID: 7162
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcLogic___BeginBodySearch_Networked_3323014238_Public_Virtual_New_Void_NetworkObject_0;

		// Token: 0x04001BFB RID: 7163
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcReader___Server_BeginBodySearch_Networked_3323014238_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x04001BFC RID: 7164
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcWriter___Observers_BeginBodySearch_3323014238_Private_Void_NetworkObject_0;

		// Token: 0x04001BFD RID: 7165
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcLogic___BeginBodySearch_3323014238_Private_Void_NetworkObject_0;

		// Token: 0x04001BFE RID: 7166
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcReader___Observers_BeginBodySearch_3323014238_Private_Void_PooledReader_Channel_0;

		// Token: 0x04001BFF RID: 7167
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcWriter___Observers_AssignToCheckpoint_4087078542_Private_Void_ECheckpointLocation_0;

		// Token: 0x04001C00 RID: 7168
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcLogic___AssignToCheckpoint_4087078542_Public_Virtual_New_Void_ECheckpointLocation_0;

		// Token: 0x04001C01 RID: 7169
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcReader___Observers_AssignToCheckpoint_4087078542_Private_Void_PooledReader_Channel_0;

		// Token: 0x04001C02 RID: 7170
		private static readonly System.IntPtr NativeMethodInfoPtr_sync___get_value__TargetPlayerNOB_k__BackingField_Public_get_NetworkObject_0;

		// Token: 0x04001C03 RID: 7171
		private static readonly System.IntPtr NativeMethodInfoPtr_sync___set_value__TargetPlayerNOB_k__BackingField_Public_set_Void_NetworkObject_Boolean_0;

		// Token: 0x04001C04 RID: 7172
		private static readonly System.IntPtr NativeMethodInfoPtr_ReadSyncVar___ScheduleOne_Police_PoliceOfficer_Public_Virtual_Boolean_PooledReader_UInt32_Boolean_0;

		// Token: 0x04001C05 RID: 7173
		private static readonly System.IntPtr NativeMethodInfoPtr_Method_Protected_Virtual_Void_0;

		// Token: 0x02000910 RID: 2320
		[ObfuscatedName("ScheduleOne.Police.PoliceOfficer+<<Deactivate>g__Wait|59_0>d")]
		public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoObObUnique : Il2CppSystem.Object
		{
			// Token: 0x0600C8EB RID: 51435 RVA: 0x00311730 File Offset: 0x0030F930
			// Note: this type is marked as 'beforefieldinit'.
			static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoObObUnique()
			{
				Il2CppClassPointerStore<PoliceOfficer.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PoliceOfficer>.NativeClassPtr, "<<Deactivate>g__Wait|59_0>d");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PoliceOfficer.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoObObUnique>.NativeClassPtr);
				PoliceOfficer.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PoliceOfficer.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoObObUnique>.NativeClassPtr, "<>1__state");
				PoliceOfficer.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PoliceOfficer.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoObObUnique>.NativeClassPtr, "<>2__current");
				PoliceOfficer.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PoliceOfficer.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoObObUnique>.NativeClassPtr, "<>4__this");
				PoliceOfficer.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoliceOfficer.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoObObUnique>.NativeClassPtr, 100668108);
				PoliceOfficer.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoliceOfficer.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoObObUnique>.NativeClassPtr, 100668109);
				PoliceOfficer.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoliceOfficer.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoObObUnique>.NativeClassPtr, 100668110);
				PoliceOfficer.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoliceOfficer.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoObObUnique>.NativeClassPtr, 100668111);
				PoliceOfficer.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoliceOfficer.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoObObUnique>.NativeClassPtr, 100668112);
				PoliceOfficer.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoliceOfficer.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoObObUnique>.NativeClassPtr, 100668113);
			}

			// Token: 0x0600C8EC RID: 51436 RVA: 0x00311810 File Offset: 0x0030FA10
			[CallerCount(54)]
			[CachedScanResults(RefRangeStart = 2646, RefRangeEnd = 2700, XrefRangeStart = 2646, XrefRangeEnd = 2700, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PoliceOfficer.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoObObUnique>.NativeClassPtr))
			{
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = ref <>1__state;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PoliceOfficer.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600C8ED RID: 51437 RVA: 0x00311858 File Offset: 0x0030FA58
			[CallerCount(14558)]
			[CachedScanResults(RefRangeStart = 2769, RefRangeEnd = 17327, XrefRangeStart = 2769, XrefRangeEnd = 17327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PoliceOfficer.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600C8EE RID: 51438 RVA: 0x0031188C File Offset: 0x0030FA8C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 122661, XrefRangeEnd = 122672, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(PoliceOfficer.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x17003E6F RID: 15983
			// (get) Token: 0x0600C8EF RID: 51439 RVA: 0x003118C8 File Offset: 0x0030FAC8
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 2740, RefRangeEnd = 2764, XrefRangeStart = 2740, XrefRangeEnd = 2764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PoliceOfficer.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
			}

			// Token: 0x0600C8F0 RID: 51440 RVA: 0x00311908 File Offset: 0x0030FB08
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 122672, XrefRangeEnd = 122677, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PoliceOfficer.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x17003E70 RID: 15984
			// (get) Token: 0x0600C8F1 RID: 51441 RVA: 0x0031193C File Offset: 0x0030FB3C
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 2740, RefRangeEnd = 2764, XrefRangeStart = 2740, XrefRangeEnd = 2764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PoliceOfficer.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
			}

			// Token: 0x0600C8F2 RID: 51442 RVA: 0x00061726 File Offset: 0x0005F926
			public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoObObUnique(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003E6C RID: 15980
			// (get) Token: 0x0600C8F3 RID: 51443 RVA: 0x0031197C File Offset: 0x0030FB7C
			// (set) Token: 0x0600C8F4 RID: 51444 RVA: 0x0006172F File Offset: 0x0005F92F
			public unsafe int __1__state
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PoliceOfficer.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoObObUnique.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PoliceOfficer.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoObObUnique.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17003E6D RID: 15981
			// (get) Token: 0x0600C8F5 RID: 51445 RVA: 0x003119A4 File Offset: 0x0030FBA4
			// (set) Token: 0x0600C8F6 RID: 51446 RVA: 0x0006174A File Offset: 0x0005F94A
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PoliceOfficer.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoObObUnique.NativeFieldInfoPtr___2__current);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PoliceOfficer.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003E6E RID: 15982
			// (get) Token: 0x0600C8F7 RID: 51447 RVA: 0x003119D4 File Offset: 0x0030FBD4
			// (set) Token: 0x0600C8F8 RID: 51448 RVA: 0x00061769 File Offset: 0x0005F969
			public unsafe PoliceOfficer __4__this
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PoliceOfficer.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoObObUnique.NativeFieldInfoPtr___4__this);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PoliceOfficer>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PoliceOfficer.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008840 RID: 34880
			private static readonly System.IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04008841 RID: 34881
			private static readonly System.IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04008842 RID: 34882
			private static readonly System.IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04008843 RID: 34883
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04008844 RID: 34884
			private static readonly System.IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008845 RID: 34885
			private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04008846 RID: 34886
			private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04008847 RID: 34887
			private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008848 RID: 34888
			private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
