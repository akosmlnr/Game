using System;
using Il2Cpp;
using Il2CppFishNet.Connection;
using Il2CppFishNet.Object;
using Il2CppFishNet.Serializing;
using Il2CppFishNet.Transporting;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.AvatarFramework.Animation;
using Il2CppScheduleOne.Dragging;
using Il2CppScheduleOne.Management;
using Il2CppScheduleOne.Tools;
using Il2CppScheduleOne.Vehicles;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.Events;

namespace Il2CppScheduleOne.NPCs
{
	// Token: 0x020002FA RID: 762
	public class NPCMovement : NetworkBehaviour
	{
		// Token: 0x06003689 RID: 13961 RVA: 0x00123734 File Offset: 0x00121934
		// Note: this type is marked as 'beforefieldinit'.
		static NPCMovement()
		{
			Il2CppClassPointerStore<NPCMovement>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.NPCs", "NPCMovement");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr);
			NPCMovement.NativeFieldInfoPtr_VEHICLE_RUNOVER_THRESHOLD = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, "VEHICLE_RUNOVER_THRESHOLD");
			NPCMovement.NativeFieldInfoPtr_SKATEBOARD_RUNOVER_THRESHOLD = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, "SKATEBOARD_RUNOVER_THRESHOLD");
			NPCMovement.NativeFieldInfoPtr_LIGHT_FLINCH_THRESHOLD = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, "LIGHT_FLINCH_THRESHOLD");
			NPCMovement.NativeFieldInfoPtr_HEAVY_FLINCH_THRESHOLD = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, "HEAVY_FLINCH_THRESHOLD");
			NPCMovement.NativeFieldInfoPtr_RAGDOLL_THRESHOLD = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, "RAGDOLL_THRESHOLD");
			NPCMovement.NativeFieldInfoPtr_MOMENTUM_ANNOYED_THRESHOLD = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, "MOMENTUM_ANNOYED_THRESHOLD");
			NPCMovement.NativeFieldInfoPtr_MOMENTUM_LIGHT_FLINCH_THRESHOLD = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, "MOMENTUM_LIGHT_FLINCH_THRESHOLD");
			NPCMovement.NativeFieldInfoPtr_MOMENTUM_HEAVY_FLINCH_THRESHOLD = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, "MOMENTUM_HEAVY_FLINCH_THRESHOLD");
			NPCMovement.NativeFieldInfoPtr_MOMENTUM_RAGDOLL_THRESHOLD = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, "MOMENTUM_RAGDOLL_THRESHOLD");
			NPCMovement.NativeFieldInfoPtr_USE_PATH_CACHE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, "USE_PATH_CACHE");
			NPCMovement.NativeFieldInfoPtr_STUMBLE_DURATION = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, "STUMBLE_DURATION");
			NPCMovement.NativeFieldInfoPtr_STUMBLE_FORCE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, "STUMBLE_FORCE");
			NPCMovement.NativeFieldInfoPtr_OBSTACLE_AVOIDANCE_RANGE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, "OBSTACLE_AVOIDANCE_RANGE");
			NPCMovement.NativeFieldInfoPtr_PLAYER_DIST_IMPACT_THRESHOLD = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, "PLAYER_DIST_IMPACT_THRESHOLD");
			NPCMovement.NativeFieldInfoPtr_cachedClosestReachablePoints = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, "cachedClosestReachablePoints");
			NPCMovement.NativeFieldInfoPtr_cachedClosestPointKeys = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, "cachedClosestPointKeys");
			NPCMovement.NativeFieldInfoPtr_CLOSEST_REACHABLE_POINT_CACHE_MAX_SQR_OFFSET = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, "CLOSEST_REACHABLE_POINT_CACHE_MAX_SQR_OFFSET");
			NPCMovement.NativeFieldInfoPtr_DEBUG = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, "DEBUG");
			NPCMovement.NativeFieldInfoPtr_WalkSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, "WalkSpeed");
			NPCMovement.NativeFieldInfoPtr_RunSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, "RunSpeed");
			NPCMovement.NativeFieldInfoPtr_MoveSpeedMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, "MoveSpeedMultiplier");
			NPCMovement.NativeFieldInfoPtr_SlipperyMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, "SlipperyMode");
			NPCMovement.NativeFieldInfoPtr_SlipperyModeMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, "SlipperyModeMultiplier");
			NPCMovement.NativeFieldInfoPtr_DefaultObstacleAvoidanceType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, "DefaultObstacleAvoidanceType");
			NPCMovement.NativeFieldInfoPtr_Agent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, "Agent");
			NPCMovement.NativeFieldInfoPtr_SpeedController = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, "SpeedController");
			NPCMovement.NativeFieldInfoPtr_npc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, "npc");
			NPCMovement.NativeFieldInfoPtr_capsuleCollider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, "capsuleCollider");
			NPCMovement.NativeFieldInfoPtr_anim = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, "anim");
			NPCMovement.NativeFieldInfoPtr_ragdollCentralRB = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, "ragdollCentralRB");
			NPCMovement.NativeFieldInfoPtr_velocityCalculator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, "velocityCalculator");
			NPCMovement.NativeFieldInfoPtr_RagdollDraggable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, "RagdollDraggable");
			NPCMovement.NativeFieldInfoPtr_RagdollDraggableCollider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, "RagdollDraggableCollider");
			NPCMovement.NativeFieldInfoPtr_MovementSpeedScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, "MovementSpeedScale");
			NPCMovement.NativeFieldInfoPtr__hasDestination_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, "<hasDestination>k__BackingField");
			NPCMovement.NativeFieldInfoPtr__IsPaused_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, "<IsPaused>k__BackingField");
			NPCMovement.NativeFieldInfoPtr__GravityMultiplier_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, "<GravityMultiplier>k__BackingField");
			NPCMovement.NativeFieldInfoPtr__Stance_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, "<Stance>k__BackingField");
			NPCMovement.NativeFieldInfoPtr__timeSinceHitByCar_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, "<timeSinceHitByCar>k__BackingField");
			NPCMovement.NativeFieldInfoPtr_ragdollTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, "ragdollTime");
			NPCMovement.NativeFieldInfoPtr_ragdollStaticTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, "ragdollStaticTime");
			NPCMovement.NativeFieldInfoPtr_onHitByCar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, "onHitByCar");
			NPCMovement.NativeFieldInfoPtr_onRagdollStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, "onRagdollStart");
			NPCMovement.NativeFieldInfoPtr_onRagdollEnd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, "onRagdollEnd");
			NPCMovement.NativeFieldInfoPtr__CurrentDestination_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, "<CurrentDestination>k__BackingField");
			NPCMovement.NativeFieldInfoPtr__PathCache_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, "<PathCache>k__BackingField");
			NPCMovement.NativeFieldInfoPtr_cacheNextPath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, "cacheNextPath");
			NPCMovement.NativeFieldInfoPtr_currentDestination_Reachable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, "currentDestination_Reachable");
			NPCMovement.NativeFieldInfoPtr_walkResultCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, "walkResultCallback");
			NPCMovement.NativeFieldInfoPtr_currentMaxDistanceForSuccess = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, "currentMaxDistanceForSuccess");
			NPCMovement.NativeFieldInfoPtr_forceIsMoving = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, "forceIsMoving");
			NPCMovement.NativeFieldInfoPtr_FaceDirectionRoutine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, "FaceDirectionRoutine");
			NPCMovement.NativeFieldInfoPtr_ragdollForceComponents = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, "ragdollForceComponents");
			NPCMovement.NativeFieldInfoPtr__Disoriented_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, "<Disoriented>k__BackingField");
			NPCMovement.NativeFieldInfoPtr_timeUntilNextStumble = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, "timeUntilNextStumble");
			NPCMovement.NativeFieldInfoPtr_timeSinceStumble = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, "timeSinceStumble");
			NPCMovement.NativeFieldInfoPtr_stumbleDirection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, "stumbleDirection");
			NPCMovement.NativeFieldInfoPtr_desiredVelocityHistory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, "desiredVelocityHistory");
			NPCMovement.NativeFieldInfoPtr_desiredVelocityHistoryLength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, "desiredVelocityHistoryLength");
			NPCMovement.NativeFieldInfoPtr_velocityHistorySpacing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, "velocityHistorySpacing");
			NPCMovement.NativeFieldInfoPtr_timeSinceLastVelocityHistoryRecord = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, "timeSinceLastVelocityHistoryRecord");
			NPCMovement.NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, "NetworkInitialize___EarlyScheduleOne.NPCs.NPCMovementAssembly-CSharp.dll_Excuted");
			NPCMovement.NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, "NetworkInitialize__LateScheduleOne.NPCs.NPCMovementAssembly-CSharp.dll_Excuted");
			NPCMovement.NativeMethodInfoPtr_get_hasDestination_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, 100669566);
			NPCMovement.NativeMethodInfoPtr_set_hasDestination_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, 100669567);
			NPCMovement.NativeMethodInfoPtr_get_IsMoving_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, 100669568);
			NPCMovement.NativeMethodInfoPtr_get_IsPaused_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, 100669569);
			NPCMovement.NativeMethodInfoPtr_set_IsPaused_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, 100669570);
			NPCMovement.NativeMethodInfoPtr_get_FootPosition_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, 100669571);
			NPCMovement.NativeMethodInfoPtr_get_GravityMultiplier_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, 100669572);
			NPCMovement.NativeMethodInfoPtr_set_GravityMultiplier_Protected_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, 100669573);
			NPCMovement.NativeMethodInfoPtr_get_Stance_Public_get_EStance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, 100669574);
			NPCMovement.NativeMethodInfoPtr_set_Stance_Protected_set_Void_EStance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, 100669575);
			NPCMovement.NativeMethodInfoPtr_get_timeSinceHitByCar_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, 100669576);
			NPCMovement.NativeMethodInfoPtr_set_timeSinceHitByCar_Protected_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, 100669577);
			NPCMovement.NativeMethodInfoPtr_get_FaceDirectionInProgress_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, 100669578);
			NPCMovement.NativeMethodInfoPtr_get_CurrentDestination_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, 100669579);
			NPCMovement.NativeMethodInfoPtr_set_CurrentDestination_Protected_set_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, 100669580);
			NPCMovement.NativeMethodInfoPtr_get_PathCache_Public_get_NPCPathCache_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, 100669581);
			NPCMovement.NativeMethodInfoPtr_set_PathCache_Private_set_Void_NPCPathCache_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, 100669582);
			NPCMovement.NativeMethodInfoPtr_get_Disoriented_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, 100669583);
			NPCMovement.NativeMethodInfoPtr_set_Disoriented_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, 100669584);
			NPCMovement.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, 100669585);
			NPCMovement.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, 100669586);
			NPCMovement.NativeMethodInfoPtr_OnStartClient_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, 100669587);
			NPCMovement.NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, 100669588);
			NPCMovement.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, 100669589);
			NPCMovement.NativeMethodInfoPtr_LateUpdate_Protected_Virtual_New_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, 100669590);
			NPCMovement.NativeMethodInfoPtr_UpdateRagdoll_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, 100669591);
			NPCMovement.NativeMethodInfoPtr_Stumble_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, 100669592);
			NPCMovement.NativeMethodInfoPtr_UpdateDestination_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, 100669593);
			NPCMovement.NativeMethodInfoPtr_FixedUpdate_Protected_Virtual_New_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, 100669594);
			NPCMovement.NativeMethodInfoPtr_UpdateStumble_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, 100669595);
			NPCMovement.NativeMethodInfoPtr_UpdateSpeed_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, 100669596);
			NPCMovement.NativeMethodInfoPtr_RecordVelocity_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, 100669597);
			NPCMovement.NativeMethodInfoPtr_UpdateSlippery_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, 100669598);
			NPCMovement.NativeMethodInfoPtr_UpdateCache_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, 100669599);
			NPCMovement.NativeMethodInfoPtr_CanRecoverFromRagdoll_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, 100669600);
			NPCMovement.NativeMethodInfoPtr_UpdateAvoidance_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, 100669601);
			NPCMovement.NativeMethodInfoPtr_OnTriggerEnter_Public_Void_Collider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, 100669602);
			NPCMovement.NativeMethodInfoPtr_OnCollisionEnter_Public_Void_Collision_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, 100669603);
			NPCMovement.NativeMethodInfoPtr_CheckHit_Private_Void_Collider_Collider_Boolean_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, 100669604);
			NPCMovement.NativeMethodInfoPtr_Warp_Public_Void_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, 100669605);
			NPCMovement.NativeMethodInfoPtr_Warp_Public_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, 100669606);
			NPCMovement.NativeMethodInfoPtr_ReceiveWarp_Private_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, 100669607);
			NPCMovement.NativeMethodInfoPtr_VisibilityChange_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, 100669608);
			NPCMovement.NativeMethodInfoPtr_CanMove_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, 100669609);
			NPCMovement.NativeMethodInfoPtr_SetAgentType_Public_Void_EAgentType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, 100669610);
			NPCMovement.NativeMethodInfoPtr_SetSeat_Public_Void_AvatarSeat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, 100669611);
			NPCMovement.NativeMethodInfoPtr_SetStance_Public_Void_EStance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, 100669612);
			NPCMovement.NativeMethodInfoPtr_SetGravityMultiplier_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, 100669613);
			NPCMovement.NativeMethodInfoPtr_SetRagdollDraggable_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, 100669614);
			NPCMovement.NativeMethodInfoPtr_ActivateRagdoll_Server_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, 100669615);
			NPCMovement.NativeMethodInfoPtr_ActivateRagdoll_Public_Void_Vector3_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, 100669616);
			NPCMovement.NativeMethodInfoPtr_ApplyRagdollForce_Public_Void_Vector3_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, 100669617);
			NPCMovement.NativeMethodInfoPtr_DeactivateRagdoll_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, 100669618);
			NPCMovement.NativeMethodInfoPtr_SmartSampleNavMesh_Private_Boolean_Vector3_byref_NavMeshHit_Single_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, 100669619);
			NPCMovement.NativeMethodInfoPtr_SetDestination_Public_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, 100669620);
			NPCMovement.NativeMethodInfoPtr_SetDestination_Public_Void_ITransitEntity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, 100669621);
			NPCMovement.NativeMethodInfoPtr_SetDestination_Public_Void_Vector3_Action_1_WalkResult_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, 100669622);
			NPCMovement.NativeMethodInfoPtr_SetDestination_Private_Void_Vector3_Action_1_WalkResult_Boolean_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, 100669623);
			NPCMovement.NativeMethodInfoPtr_IsNPCPositionValid_Private_Boolean_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, 100669624);
			NPCMovement.NativeMethodInfoPtr_EndSetDestination_Private_Void_WalkResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, 100669625);
			NPCMovement.NativeMethodInfoPtr_Stop_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, 100669626);
			NPCMovement.NativeMethodInfoPtr_WarpToNavMesh_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, 100669627);
			NPCMovement.NativeMethodInfoPtr_FacePoint_Public_Void_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, 100669628);
			NPCMovement.NativeMethodInfoPtr_FaceDirection_Public_Void_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, 100669629);
			NPCMovement.NativeMethodInfoPtr_FaceDirection_Process_Protected_IEnumerator_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, 100669630);
			NPCMovement.NativeMethodInfoPtr_PauseMovement_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, 100669631);
			NPCMovement.NativeMethodInfoPtr_ResumeMovement_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, 100669632);
			NPCMovement.NativeMethodInfoPtr_IsAsCloseAsPossible_Public_Boolean_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, 100669633);
			NPCMovement.NativeMethodInfoPtr_GetClosestReachablePoint_Public_Boolean_Vector3_byref_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, 100669634);
			NPCMovement.NativeMethodInfoPtr_CanGetTo_Public_Boolean_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, 100669635);
			NPCMovement.NativeMethodInfoPtr_CanGetTo_Public_Boolean_ITransitEntity_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, 100669636);
			NPCMovement.NativeMethodInfoPtr_CanGetTo_Public_Boolean_Vector3_Single_byref_NavMeshPath_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, 100669637);
			NPCMovement.NativeMethodInfoPtr_GetPathTo_Private_NavMeshPath_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, 100669638);
			NPCMovement.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, 100669639);
			NPCMovement.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, 100669641);
			NPCMovement.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, 100669642);
			NPCMovement.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, 100669643);
			NPCMovement.NativeMethodInfoPtr_RpcWriter___Observers_ReceiveWarp_4276783012_Private_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, 100669644);
			NPCMovement.NativeMethodInfoPtr_RpcLogic___ReceiveWarp_4276783012_Private_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, 100669645);
			NPCMovement.NativeMethodInfoPtr_RpcReader___Observers_ReceiveWarp_4276783012_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, 100669646);
			NPCMovement.NativeMethodInfoPtr_RpcWriter___Server_ActivateRagdoll_Server_2166136261_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, 100669647);
			NPCMovement.NativeMethodInfoPtr_RpcLogic___ActivateRagdoll_Server_2166136261_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, 100669648);
			NPCMovement.NativeMethodInfoPtr_RpcReader___Server_ActivateRagdoll_Server_2166136261_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, 100669649);
			NPCMovement.NativeMethodInfoPtr_RpcWriter___Observers_ActivateRagdoll_2690242654_Private_Void_Vector3_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, 100669650);
			NPCMovement.NativeMethodInfoPtr_RpcLogic___ActivateRagdoll_2690242654_Public_Void_Vector3_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, 100669651);
			NPCMovement.NativeMethodInfoPtr_RpcReader___Observers_ActivateRagdoll_2690242654_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, 100669652);
			NPCMovement.NativeMethodInfoPtr_RpcWriter___Observers_ApplyRagdollForce_2690242654_Private_Void_Vector3_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, 100669653);
			NPCMovement.NativeMethodInfoPtr_RpcLogic___ApplyRagdollForce_2690242654_Public_Void_Vector3_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, 100669654);
			NPCMovement.NativeMethodInfoPtr_RpcReader___Observers_ApplyRagdollForce_2690242654_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, 100669655);
			NPCMovement.NativeMethodInfoPtr_RpcWriter___Observers_DeactivateRagdoll_2166136261_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, 100669656);
			NPCMovement.NativeMethodInfoPtr_RpcLogic___DeactivateRagdoll_2166136261_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, 100669657);
			NPCMovement.NativeMethodInfoPtr_RpcReader___Observers_DeactivateRagdoll_2166136261_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, 100669658);
			NPCMovement.NativeMethodInfoPtr_Method_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, 100669659);
		}

		// Token: 0x170011A6 RID: 4518
		// (get) Token: 0x0600368A RID: 13962 RVA: 0x00124394 File Offset: 0x00122594
		// (set) Token: 0x0600368B RID: 13963 RVA: 0x001243D0 File Offset: 0x001225D0
		public unsafe bool hasDestination
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NPCMovement.NativeMethodInfoPtr_get_hasDestination_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
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
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCMovement.NativeMethodInfoPtr_set_hasDestination_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x170011A7 RID: 4519
		// (get) Token: 0x0600368C RID: 13964 RVA: 0x00124410 File Offset: 0x00122610
		public unsafe bool IsMoving
		{
			[CallerCount(79)]
			[CachedScanResults(RefRangeStart = 142359, RefRangeEnd = 142438, XrefRangeStart = 142356, XrefRangeEnd = 142359, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NPCMovement.NativeMethodInfoPtr_get_IsMoving_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
		}

		// Token: 0x170011A8 RID: 4520
		// (get) Token: 0x0600368D RID: 13965 RVA: 0x0012444C File Offset: 0x0012264C
		// (set) Token: 0x0600368E RID: 13966 RVA: 0x00124488 File Offset: 0x00122688
		public unsafe bool IsPaused
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NPCMovement.NativeMethodInfoPtr_get_IsPaused_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
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
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCMovement.NativeMethodInfoPtr_set_IsPaused_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x170011A9 RID: 4521
		// (get) Token: 0x0600368F RID: 13967 RVA: 0x001244C8 File Offset: 0x001226C8
		public unsafe Vector3 FootPosition
		{
			[CallerCount(17)]
			[CachedScanResults(RefRangeStart = 142440, RefRangeEnd = 142457, XrefRangeStart = 142438, XrefRangeEnd = 142440, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NPCMovement.NativeMethodInfoPtr_get_FootPosition_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
		}

		// Token: 0x170011AA RID: 4522
		// (get) Token: 0x06003690 RID: 13968 RVA: 0x00124504 File Offset: 0x00122704
		// (set) Token: 0x06003691 RID: 13969 RVA: 0x00124540 File Offset: 0x00122740
		public unsafe float GravityMultiplier
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NPCMovement.NativeMethodInfoPtr_get_GravityMultiplier_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
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
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCMovement.NativeMethodInfoPtr_set_GravityMultiplier_Protected_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x170011AB RID: 4523
		// (get) Token: 0x06003692 RID: 13970 RVA: 0x00124580 File Offset: 0x00122780
		// (set) Token: 0x06003693 RID: 13971 RVA: 0x001245BC File Offset: 0x001227BC
		public unsafe NPCMovement.EStance Stance
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NPCMovement.NativeMethodInfoPtr_get_Stance_Public_get_EStance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 142457, RefRangeEnd = 142462, XrefRangeStart = 142457, XrefRangeEnd = 142457, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = ref value;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCMovement.NativeMethodInfoPtr_set_Stance_Protected_set_Void_EStance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x170011AC RID: 4524
		// (get) Token: 0x06003694 RID: 13972 RVA: 0x001245FC File Offset: 0x001227FC
		// (set) Token: 0x06003695 RID: 13973 RVA: 0x00124638 File Offset: 0x00122838
		public unsafe float timeSinceHitByCar
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NPCMovement.NativeMethodInfoPtr_get_timeSinceHitByCar_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
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
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCMovement.NativeMethodInfoPtr_set_timeSinceHitByCar_Protected_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x170011AD RID: 4525
		// (get) Token: 0x06003696 RID: 13974 RVA: 0x00124678 File Offset: 0x00122878
		public unsafe bool FaceDirectionInProgress
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 142462, RefRangeEnd = 142465, XrefRangeStart = 142462, XrefRangeEnd = 142462, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NPCMovement.NativeMethodInfoPtr_get_FaceDirectionInProgress_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
		}

		// Token: 0x170011AE RID: 4526
		// (get) Token: 0x06003697 RID: 13975 RVA: 0x001246B4 File Offset: 0x001228B4
		// (set) Token: 0x06003698 RID: 13976 RVA: 0x001246F0 File Offset: 0x001228F0
		public unsafe Vector3 CurrentDestination
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NPCMovement.NativeMethodInfoPtr_get_CurrentDestination_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
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
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCMovement.NativeMethodInfoPtr_set_CurrentDestination_Protected_set_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x170011AF RID: 4527
		// (get) Token: 0x06003699 RID: 13977 RVA: 0x00124730 File Offset: 0x00122930
		// (set) Token: 0x0600369A RID: 13978 RVA: 0x00124770 File Offset: 0x00122970
		public unsafe NPCPathCache PathCache
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCMovement.NativeMethodInfoPtr_get_PathCache_Public_get_NPCPathCache_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NPCPathCache>(intPtr2) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 142465, XrefRangeEnd = 142466, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCMovement.NativeMethodInfoPtr_set_PathCache_Private_set_Void_NPCPathCache_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x170011B0 RID: 4528
		// (get) Token: 0x0600369B RID: 13979 RVA: 0x001247B4 File Offset: 0x001229B4
		// (set) Token: 0x0600369C RID: 13980 RVA: 0x001247F0 File Offset: 0x001229F0
		public unsafe bool Disoriented
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NPCMovement.NativeMethodInfoPtr_get_Disoriented_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
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
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCMovement.NativeMethodInfoPtr_set_Disoriented_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x0600369D RID: 13981 RVA: 0x00124830 File Offset: 0x00122A30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 142466, XrefRangeEnd = 142467, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCMovement.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600369E RID: 13982 RVA: 0x0012486C File Offset: 0x00122A6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 142467, XrefRangeEnd = 142481, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCMovement.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600369F RID: 13983 RVA: 0x001248A0 File Offset: 0x00122AA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 142481, XrefRangeEnd = 142484, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnStartClient()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCMovement.NativeMethodInfoPtr_OnStartClient_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060036A0 RID: 13984 RVA: 0x001248DC File Offset: 0x00122ADC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 142484, XrefRangeEnd = 142485, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnSpawnServer(NetworkConnection connection)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(connection);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCMovement.NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060036A1 RID: 13985 RVA: 0x0012492C File Offset: 0x00122B2C
		[CallerCount(14558)]
		[CachedScanResults(RefRangeStart = 2769, RefRangeEnd = 17327, XrefRangeStart = 2769, XrefRangeEnd = 17327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCMovement.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_1), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060036A2 RID: 13986 RVA: 0x00124968 File Offset: 0x00122B68
		[CallerCount(0)]
		public unsafe virtual void LateUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCMovement.NativeMethodInfoPtr_LateUpdate_Protected_Virtual_New_Void_1), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060036A3 RID: 13987 RVA: 0x001249A4 File Offset: 0x00122BA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 142485, XrefRangeEnd = 142506, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateRagdoll()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCMovement.NativeMethodInfoPtr_UpdateRagdoll_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060036A4 RID: 13988 RVA: 0x001249D8 File Offset: 0x00122BD8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 142506, XrefRangeEnd = 142516, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Stumble()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCMovement.NativeMethodInfoPtr_Stumble_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060036A5 RID: 13989 RVA: 0x00124A0C File Offset: 0x00122C0C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 142539, RefRangeEnd = 142540, XrefRangeStart = 142516, XrefRangeEnd = 142539, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateDestination()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCMovement.NativeMethodInfoPtr_UpdateDestination_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060036A6 RID: 13990 RVA: 0x00124A40 File Offset: 0x00122C40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 142540, XrefRangeEnd = 142590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void FixedUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCMovement.NativeMethodInfoPtr_FixedUpdate_Protected_Virtual_New_Void_1), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060036A7 RID: 13991 RVA: 0x00124A7C File Offset: 0x00122C7C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 142608, RefRangeEnd = 142609, XrefRangeStart = 142590, XrefRangeEnd = 142608, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateStumble()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCMovement.NativeMethodInfoPtr_UpdateStumble_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060036A8 RID: 13992 RVA: 0x00124AB0 File Offset: 0x00122CB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 142609, XrefRangeEnd = 142613, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateSpeed()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCMovement.NativeMethodInfoPtr_UpdateSpeed_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060036A9 RID: 13993 RVA: 0x00124AE4 File Offset: 0x00122CE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 142613, XrefRangeEnd = 142617, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RecordVelocity()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCMovement.NativeMethodInfoPtr_RecordVelocity_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060036AA RID: 13994 RVA: 0x00124B18 File Offset: 0x00122D18
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 142642, RefRangeEnd = 142643, XrefRangeStart = 142617, XrefRangeEnd = 142642, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateSlippery()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCMovement.NativeMethodInfoPtr_UpdateSlippery_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060036AB RID: 13995 RVA: 0x00124B4C File Offset: 0x00122D4C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 142661, RefRangeEnd = 142662, XrefRangeStart = 142643, XrefRangeEnd = 142661, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateCache()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCMovement.NativeMethodInfoPtr_UpdateCache_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060036AC RID: 13996 RVA: 0x00124B80 File Offset: 0x00122D80
		[CallerCount(0)]
		public unsafe bool CanRecoverFromRagdoll()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NPCMovement.NativeMethodInfoPtr_CanRecoverFromRagdoll_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x060036AD RID: 13997 RVA: 0x00124BBC File Offset: 0x00122DBC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 142662, XrefRangeEnd = 142669, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateAvoidance()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCMovement.NativeMethodInfoPtr_UpdateAvoidance_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060036AE RID: 13998 RVA: 0x00124BF0 File Offset: 0x00122DF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 142669, XrefRangeEnd = 142672, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnTriggerEnter(Collider other)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCMovement.NativeMethodInfoPtr_OnTriggerEnter_Public_Void_Collider_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060036AF RID: 13999 RVA: 0x00124C34 File Offset: 0x00122E34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 142672, XrefRangeEnd = 142678, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnCollisionEnter(Collision collision)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(collision);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCMovement.NativeMethodInfoPtr_OnCollisionEnter_Public_Void_Collision_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060036B0 RID: 14000 RVA: 0x00124C78 File Offset: 0x00122E78
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 142711, RefRangeEnd = 142713, XrefRangeStart = 142678, XrefRangeEnd = 142711, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CheckHit(Collider other, Collider thisCollider, bool isCollision, Vector3 hitPoint)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)4) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(thisCollider);
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref isCollision;
			ptr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref hitPoint;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCMovement.NativeMethodInfoPtr_CheckHit_Private_Void_Collider_Collider_Boolean_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060036B1 RID: 14001 RVA: 0x00124CE8 File Offset: 0x00122EE8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 142717, RefRangeEnd = 142719, XrefRangeStart = 142713, XrefRangeEnd = 142717, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Warp(Transform target)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCMovement.NativeMethodInfoPtr_Warp_Public_Void_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060036B2 RID: 14002 RVA: 0x00124D2C File Offset: 0x00122F2C
		[CallerCount(22)]
		[CachedScanResults(RefRangeStart = 142736, RefRangeEnd = 142758, XrefRangeStart = 142719, XrefRangeEnd = 142736, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Warp(Vector3 position)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref position;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCMovement.NativeMethodInfoPtr_Warp_Public_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060036B3 RID: 14003 RVA: 0x00124D6C File Offset: 0x00122F6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 142758, XrefRangeEnd = 142770, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReceiveWarp(Vector3 position)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref position;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCMovement.NativeMethodInfoPtr_ReceiveWarp_Private_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060036B4 RID: 14004 RVA: 0x00124DAC File Offset: 0x00122FAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 142770, XrefRangeEnd = 142773, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void VisibilityChange(bool visible)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref visible;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCMovement.NativeMethodInfoPtr_VisibilityChange_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060036B5 RID: 14005 RVA: 0x00124DEC File Offset: 0x00122FEC
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 142775, RefRangeEnd = 142782, XrefRangeStart = 142773, XrefRangeEnd = 142775, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool CanMove()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NPCMovement.NativeMethodInfoPtr_CanMove_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x060036B6 RID: 14006 RVA: 0x00124E28 File Offset: 0x00123028
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 142796, RefRangeEnd = 142807, XrefRangeStart = 142782, XrefRangeEnd = 142796, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetAgentType(NPCMovement.EAgentType type)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref type;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCMovement.NativeMethodInfoPtr_SetAgentType_Public_Void_EAgentType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060036B7 RID: 14007 RVA: 0x00124E68 File Offset: 0x00123068
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 142816, RefRangeEnd = 142819, XrefRangeStart = 142807, XrefRangeEnd = 142816, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetSeat(AvatarSeat seat)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(seat);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCMovement.NativeMethodInfoPtr_SetSeat_Public_Void_AvatarSeat_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060036B8 RID: 14008 RVA: 0x00124EAC File Offset: 0x001230AC
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 142457, RefRangeEnd = 142462, XrefRangeStart = 142457, XrefRangeEnd = 142462, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetStance(NPCMovement.EStance stance)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref stance;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCMovement.NativeMethodInfoPtr_SetStance_Public_Void_EStance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060036B9 RID: 14009 RVA: 0x00124EEC File Offset: 0x001230EC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 142842, RefRangeEnd = 142845, XrefRangeStart = 142819, XrefRangeEnd = 142842, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetGravityMultiplier(float multiplier)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref multiplier;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCMovement.NativeMethodInfoPtr_SetGravityMultiplier_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060036BA RID: 14010 RVA: 0x00124F2C File Offset: 0x0012312C
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 142848, RefRangeEnd = 142853, XrefRangeStart = 142845, XrefRangeEnd = 142848, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetRagdollDraggable(bool draggable)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref draggable;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCMovement.NativeMethodInfoPtr_SetRagdollDraggable_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060036BB RID: 14011 RVA: 0x00124F6C File Offset: 0x0012316C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 142874, RefRangeEnd = 142877, XrefRangeStart = 142853, XrefRangeEnd = 142874, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ActivateRagdoll_Server()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCMovement.NativeMethodInfoPtr_ActivateRagdoll_Server_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060036BC RID: 14012 RVA: 0x00124FA0 File Offset: 0x001231A0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 142879, RefRangeEnd = 142881, XrefRangeStart = 142877, XrefRangeEnd = 142879, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ActivateRagdoll(Vector3 forcePoint, Vector3 forceDir, float forceMagnitude)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref forcePoint;
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref forceDir;
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref forceMagnitude;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCMovement.NativeMethodInfoPtr_ActivateRagdoll_Public_Void_Vector3_Vector3_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060036BD RID: 14013 RVA: 0x00124FFC File Offset: 0x001231FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 142881, XrefRangeEnd = 142883, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ApplyRagdollForce(Vector3 forcePoint, Vector3 forceDir, float forceMagnitude)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref forcePoint;
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref forceDir;
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref forceMagnitude;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCMovement.NativeMethodInfoPtr_ApplyRagdollForce_Public_Void_Vector3_Vector3_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060036BE RID: 14014 RVA: 0x00125058 File Offset: 0x00123258
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 142904, RefRangeEnd = 142907, XrefRangeStart = 142883, XrefRangeEnd = 142904, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DeactivateRagdoll()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCMovement.NativeMethodInfoPtr_DeactivateRagdoll_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060036BF RID: 14015 RVA: 0x0012508C File Offset: 0x0012328C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 142917, RefRangeEnd = 142919, XrefRangeStart = 142907, XrefRangeEnd = 142917, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool SmartSampleNavMesh(Vector3 position, out NavMeshHit hit, float minRadius = 1f, float maxRadius = 10f, int steps = 3)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)5) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref position;
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = &hit;
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref minRadius;
			ptr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref maxRadius;
			ptr[checked(unchecked((System.UIntPtr)4) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref steps;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NPCMovement.NativeMethodInfoPtr_SmartSampleNavMesh_Private_Boolean_Vector3_byref_NavMeshHit_Single_Single_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x060036C0 RID: 14016 RVA: 0x00125110 File Offset: 0x00123310
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 142920, RefRangeEnd = 142934, XrefRangeStart = 142919, XrefRangeEnd = 142920, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetDestination(Vector3 pos)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref pos;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCMovement.NativeMethodInfoPtr_SetDestination_Public_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060036C1 RID: 14017 RVA: 0x00125150 File Offset: 0x00123350
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 142934, XrefRangeEnd = 142940, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetDestination(ITransitEntity entity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(entity);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCMovement.NativeMethodInfoPtr_SetDestination_Public_Void_ITransitEntity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060036C2 RID: 14018 RVA: 0x00125194 File Offset: 0x00123394
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 142941, RefRangeEnd = 142943, XrefRangeStart = 142940, XrefRangeEnd = 142941, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetDestination(Vector3 pos, Il2CppSystem.Action<NPCMovement.WalkResult> callback = null, float maximumDistanceForSuccess = 1f, float cacheMaxDistSqr = 1f)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)4) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref pos;
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref maximumDistanceForSuccess;
			ptr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref cacheMaxDistSqr;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCMovement.NativeMethodInfoPtr_SetDestination_Public_Void_Vector3_Action_1_WalkResult_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060036C3 RID: 14019 RVA: 0x00125200 File Offset: 0x00123400
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 143075, RefRangeEnd = 143078, XrefRangeStart = 142943, XrefRangeEnd = 143075, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetDestination(Vector3 pos, Il2CppSystem.Action<NPCMovement.WalkResult> callback = null, bool interruptExistingCallback = true, float successThreshold = 1f, float cacheMaxDistSqr = 1f)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)5) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref pos;
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref interruptExistingCallback;
			ptr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref successThreshold;
			ptr[checked(unchecked((System.UIntPtr)4) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref cacheMaxDistSqr;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCMovement.NativeMethodInfoPtr_SetDestination_Private_Void_Vector3_Action_1_WalkResult_Boolean_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060036C4 RID: 14020 RVA: 0x0012527C File Offset: 0x0012347C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 143079, RefRangeEnd = 143080, XrefRangeStart = 143078, XrefRangeEnd = 143079, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsNPCPositionValid(Vector3 position)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref position;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NPCMovement.NativeMethodInfoPtr_IsNPCPositionValid_Private_Boolean_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x060036C5 RID: 14021 RVA: 0x001252C8 File Offset: 0x001234C8
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 143096, RefRangeEnd = 143102, XrefRangeStart = 143080, XrefRangeEnd = 143096, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EndSetDestination(NPCMovement.WalkResult result)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref result;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCMovement.NativeMethodInfoPtr_EndSetDestination_Private_Void_WalkResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060036C6 RID: 14022 RVA: 0x00125308 File Offset: 0x00123508
		[CallerCount(35)]
		[CachedScanResults(RefRangeStart = 143111, RefRangeEnd = 143146, XrefRangeStart = 143102, XrefRangeEnd = 143111, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Stop()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCMovement.NativeMethodInfoPtr_Stop_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060036C7 RID: 14023 RVA: 0x0012533C File Offset: 0x0012353C
		[CallerCount(14558)]
		[CachedScanResults(RefRangeStart = 2769, RefRangeEnd = 17327, XrefRangeStart = 2769, XrefRangeEnd = 17327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WarpToNavMesh()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCMovement.NativeMethodInfoPtr_WarpToNavMesh_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060036C8 RID: 14024 RVA: 0x00125370 File Offset: 0x00123570
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 143166, RefRangeEnd = 143174, XrefRangeStart = 143146, XrefRangeEnd = 143166, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FacePoint(Vector3 point, float lerpTime = 0.5f)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref point;
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref lerpTime;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCMovement.NativeMethodInfoPtr_FacePoint_Public_Void_Vector3_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060036C9 RID: 14025 RVA: 0x001253BC File Offset: 0x001235BC
		[CallerCount(19)]
		[CachedScanResults(RefRangeStart = 143197, RefRangeEnd = 143216, XrefRangeStart = 143174, XrefRangeEnd = 143197, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FaceDirection(Vector3 forward, float lerpTime = 0.5f)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref forward;
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref lerpTime;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCMovement.NativeMethodInfoPtr_FaceDirection_Public_Void_Vector3_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060036CA RID: 14026 RVA: 0x00125408 File Offset: 0x00123608
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 143216, XrefRangeEnd = 143221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator FaceDirection_Process(Vector3 forward, float lerpTime)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref forward;
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref lerpTime;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCMovement.NativeMethodInfoPtr_FaceDirection_Process_Protected_IEnumerator_Vector3_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr2) : null;
		}

		// Token: 0x060036CB RID: 14027 RVA: 0x00125464 File Offset: 0x00123664
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 143221, XrefRangeEnd = 143225, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PauseMovement()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCMovement.NativeMethodInfoPtr_PauseMovement_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060036CC RID: 14028 RVA: 0x00125498 File Offset: 0x00123698
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 143227, RefRangeEnd = 143228, XrefRangeStart = 143225, XrefRangeEnd = 143227, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ResumeMovement()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCMovement.NativeMethodInfoPtr_ResumeMovement_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060036CD RID: 14029 RVA: 0x001254CC File Offset: 0x001236CC
		[CallerCount(17)]
		[CachedScanResults(RefRangeStart = 143236, RefRangeEnd = 143253, XrefRangeStart = 143228, XrefRangeEnd = 143236, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsAsCloseAsPossible(Vector3 location, float distanceThreshold = 0.5f)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref location;
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref distanceThreshold;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NPCMovement.NativeMethodInfoPtr_IsAsCloseAsPossible_Public_Boolean_Vector3_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x060036CE RID: 14030 RVA: 0x00125524 File Offset: 0x00123724
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 143279, RefRangeEnd = 143282, XrefRangeStart = 143253, XrefRangeEnd = 143279, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool GetClosestReachablePoint(Vector3 targetPosition, out Vector3 closestPoint)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref targetPosition;
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = &closestPoint;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NPCMovement.NativeMethodInfoPtr_GetClosestReachablePoint_Public_Boolean_Vector3_byref_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x060036CF RID: 14031 RVA: 0x0012557C File Offset: 0x0012377C
		[CallerCount(23)]
		[CachedScanResults(RefRangeStart = 143283, RefRangeEnd = 143306, XrefRangeStart = 143282, XrefRangeEnd = 143283, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool CanGetTo(Vector3 position, float proximityReq = 1f)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref position;
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref proximityReq;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NPCMovement.NativeMethodInfoPtr_CanGetTo_Public_Boolean_Vector3_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x060036D0 RID: 14032 RVA: 0x001255D4 File Offset: 0x001237D4
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 143318, RefRangeEnd = 143322, XrefRangeStart = 143306, XrefRangeEnd = 143318, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool CanGetTo(ITransitEntity entity, float proximityReq = 1f)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(entity);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref proximityReq;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NPCMovement.NativeMethodInfoPtr_CanGetTo_Public_Boolean_ITransitEntity_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x060036D1 RID: 14033 RVA: 0x00125630 File Offset: 0x00123830
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 143353, RefRangeEnd = 143356, XrefRangeStart = 143322, XrefRangeEnd = 143353, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool CanGetTo(Vector3 position, float proximityReq, out NavMeshPath path)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref position;
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref proximityReq;
			ref System.IntPtr ptr2 = ref ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)];
			System.IntPtr intPtr = 0;
			ptr2 = &intPtr;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NPCMovement.NativeMethodInfoPtr_CanGetTo_Public_Boolean_Vector3_Single_byref_NavMeshPath_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			path = ((intPtr2 == 0) ? null : new NavMeshPath(intPtr2));
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x060036D2 RID: 14034 RVA: 0x001256AC File Offset: 0x001238AC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 143383, RefRangeEnd = 143384, XrefRangeStart = 143356, XrefRangeEnd = 143383, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NavMeshPath GetPathTo(Vector3 position, float proximityReq = 1f)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref position;
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref proximityReq;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCMovement.NativeMethodInfoPtr_GetPathTo_Private_NavMeshPath_Vector3_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<NavMeshPath>(intPtr2) : null;
		}

		// Token: 0x060036D3 RID: 14035 RVA: 0x00125708 File Offset: 0x00123908
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 143384, XrefRangeEnd = 143417, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NPCMovement() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCMovement.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060036D4 RID: 14036 RVA: 0x00125744 File Offset: 0x00123944
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 143417, XrefRangeEnd = 143449, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void NetworkInitialize___Early()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCMovement.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060036D5 RID: 14037 RVA: 0x00125780 File Offset: 0x00123980
		[CallerCount(0)]
		public unsafe virtual void NetworkInitialize__Late()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCMovement.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060036D6 RID: 14038 RVA: 0x001257BC File Offset: 0x001239BC
		[CallerCount(0)]
		public unsafe override void NetworkInitializeIfDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCMovement.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060036D7 RID: 14039 RVA: 0x001257F8 File Offset: 0x001239F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_ReceiveWarp_4276783012(Vector3 position)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref position;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCMovement.NativeMethodInfoPtr_RpcWriter___Observers_ReceiveWarp_4276783012_Private_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060036D8 RID: 14040 RVA: 0x00125838 File Offset: 0x00123A38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 143449, XrefRangeEnd = 143453, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___ReceiveWarp_4276783012(Vector3 position)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref position;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCMovement.NativeMethodInfoPtr_RpcLogic___ReceiveWarp_4276783012_Private_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060036D9 RID: 14041 RVA: 0x00125878 File Offset: 0x00123A78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 143453, XrefRangeEnd = 143461, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_ReceiveWarp_4276783012(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref channel;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCMovement.NativeMethodInfoPtr_RpcReader___Observers_ReceiveWarp_4276783012_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060036DA RID: 14042 RVA: 0x001258C8 File Offset: 0x00123AC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 143461, XrefRangeEnd = 143470, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_ActivateRagdoll_Server_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCMovement.NativeMethodInfoPtr_RpcWriter___Server_ActivateRagdoll_Server_2166136261_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060036DB RID: 14043 RVA: 0x001258FC File Offset: 0x00123AFC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 143476, RefRangeEnd = 143478, XrefRangeStart = 143470, XrefRangeEnd = 143476, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___ActivateRagdoll_Server_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCMovement.NativeMethodInfoPtr_RpcLogic___ActivateRagdoll_Server_2166136261_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060036DC RID: 14044 RVA: 0x00125930 File Offset: 0x00123B30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 143478, XrefRangeEnd = 143481, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_ActivateRagdoll_Server_2166136261(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref channel;
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCMovement.NativeMethodInfoPtr_RpcReader___Server_ActivateRagdoll_Server_2166136261_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060036DD RID: 14045 RVA: 0x00125994 File Offset: 0x00123B94
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 143497, RefRangeEnd = 143499, XrefRangeStart = 143481, XrefRangeEnd = 143497, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_ActivateRagdoll_2690242654(Vector3 forcePoint, Vector3 forceDir, float forceMagnitude)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref forcePoint;
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref forceDir;
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref forceMagnitude;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCMovement.NativeMethodInfoPtr_RpcWriter___Observers_ActivateRagdoll_2690242654_Private_Void_Vector3_Vector3_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060036DE RID: 14046 RVA: 0x001259F0 File Offset: 0x00123BF0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 143507, RefRangeEnd = 143510, XrefRangeStart = 143499, XrefRangeEnd = 143507, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___ActivateRagdoll_2690242654(Vector3 forcePoint, Vector3 forceDir, float forceMagnitude)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref forcePoint;
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref forceDir;
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref forceMagnitude;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCMovement.NativeMethodInfoPtr_RpcLogic___ActivateRagdoll_2690242654_Public_Void_Vector3_Vector3_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060036DF RID: 14047 RVA: 0x00125A4C File Offset: 0x00123C4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 143510, XrefRangeEnd = 143520, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_ActivateRagdoll_2690242654(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref channel;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCMovement.NativeMethodInfoPtr_RpcReader___Observers_ActivateRagdoll_2690242654_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060036E0 RID: 14048 RVA: 0x00125A9C File Offset: 0x00123C9C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 143536, RefRangeEnd = 143538, XrefRangeStart = 143520, XrefRangeEnd = 143536, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_ApplyRagdollForce_2690242654(Vector3 forcePoint, Vector3 forceDir, float forceMagnitude)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref forcePoint;
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref forceDir;
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref forceMagnitude;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCMovement.NativeMethodInfoPtr_RpcWriter___Observers_ApplyRagdollForce_2690242654_Private_Void_Vector3_Vector3_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060036E1 RID: 14049 RVA: 0x00125AF8 File Offset: 0x00123CF8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 143575, RefRangeEnd = 143578, XrefRangeStart = 143538, XrefRangeEnd = 143575, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___ApplyRagdollForce_2690242654(Vector3 forcePoint, Vector3 forceDir, float forceMagnitude)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref forcePoint;
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref forceDir;
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref forceMagnitude;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCMovement.NativeMethodInfoPtr_RpcLogic___ApplyRagdollForce_2690242654_Public_Void_Vector3_Vector3_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060036E2 RID: 14050 RVA: 0x00125B54 File Offset: 0x00123D54
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 143578, XrefRangeEnd = 143588, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_ApplyRagdollForce_2690242654(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref channel;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCMovement.NativeMethodInfoPtr_RpcReader___Observers_ApplyRagdollForce_2690242654_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060036E3 RID: 14051 RVA: 0x00125BA4 File Offset: 0x00123DA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 143588, XrefRangeEnd = 143597, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_DeactivateRagdoll_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCMovement.NativeMethodInfoPtr_RpcWriter___Observers_DeactivateRagdoll_2166136261_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060036E4 RID: 14052 RVA: 0x00125BD8 File Offset: 0x00123DD8
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 143633, RefRangeEnd = 143637, XrefRangeStart = 143597, XrefRangeEnd = 143633, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___DeactivateRagdoll_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCMovement.NativeMethodInfoPtr_RpcLogic___DeactivateRagdoll_2166136261_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060036E5 RID: 14053 RVA: 0x00125C0C File Offset: 0x00123E0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 143637, XrefRangeEnd = 143640, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_DeactivateRagdoll_2166136261(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref channel;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCMovement.NativeMethodInfoPtr_RpcReader___Observers_DeactivateRagdoll_2166136261_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060036E6 RID: 14054 RVA: 0x00125C5C File Offset: 0x00123E5C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 143679, RefRangeEnd = 143680, XrefRangeStart = 143640, XrefRangeEnd = 143679, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Method_Protected_Virtual_New_Void_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCMovement.NativeMethodInfoPtr_Method_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060036E7 RID: 14055 RVA: 0x0001C77B File Offset: 0x0001A97B
		public NPCMovement(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001167 RID: 4455
		// (get) Token: 0x060036E8 RID: 14056 RVA: 0x00125C98 File Offset: 0x00123E98
		// (set) Token: 0x060036E9 RID: 14057 RVA: 0x0001C784 File Offset: 0x0001A984
		public unsafe static float VEHICLE_RUNOVER_THRESHOLD
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(NPCMovement.NativeFieldInfoPtr_VEHICLE_RUNOVER_THRESHOLD, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NPCMovement.NativeFieldInfoPtr_VEHICLE_RUNOVER_THRESHOLD, (void*)(&value));
			}
		}

		// Token: 0x17001168 RID: 4456
		// (get) Token: 0x060036EA RID: 14058 RVA: 0x00125CB4 File Offset: 0x00123EB4
		// (set) Token: 0x060036EB RID: 14059 RVA: 0x0001C792 File Offset: 0x0001A992
		public unsafe static float SKATEBOARD_RUNOVER_THRESHOLD
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(NPCMovement.NativeFieldInfoPtr_SKATEBOARD_RUNOVER_THRESHOLD, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NPCMovement.NativeFieldInfoPtr_SKATEBOARD_RUNOVER_THRESHOLD, (void*)(&value));
			}
		}

		// Token: 0x17001169 RID: 4457
		// (get) Token: 0x060036EC RID: 14060 RVA: 0x00125CD0 File Offset: 0x00123ED0
		// (set) Token: 0x060036ED RID: 14061 RVA: 0x0001C7A0 File Offset: 0x0001A9A0
		public unsafe static float LIGHT_FLINCH_THRESHOLD
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(NPCMovement.NativeFieldInfoPtr_LIGHT_FLINCH_THRESHOLD, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NPCMovement.NativeFieldInfoPtr_LIGHT_FLINCH_THRESHOLD, (void*)(&value));
			}
		}

		// Token: 0x1700116A RID: 4458
		// (get) Token: 0x060036EE RID: 14062 RVA: 0x00125CEC File Offset: 0x00123EEC
		// (set) Token: 0x060036EF RID: 14063 RVA: 0x0001C7AE File Offset: 0x0001A9AE
		public unsafe static float HEAVY_FLINCH_THRESHOLD
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(NPCMovement.NativeFieldInfoPtr_HEAVY_FLINCH_THRESHOLD, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NPCMovement.NativeFieldInfoPtr_HEAVY_FLINCH_THRESHOLD, (void*)(&value));
			}
		}

		// Token: 0x1700116B RID: 4459
		// (get) Token: 0x060036F0 RID: 14064 RVA: 0x00125D08 File Offset: 0x00123F08
		// (set) Token: 0x060036F1 RID: 14065 RVA: 0x0001C7BC File Offset: 0x0001A9BC
		public unsafe static float RAGDOLL_THRESHOLD
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(NPCMovement.NativeFieldInfoPtr_RAGDOLL_THRESHOLD, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NPCMovement.NativeFieldInfoPtr_RAGDOLL_THRESHOLD, (void*)(&value));
			}
		}

		// Token: 0x1700116C RID: 4460
		// (get) Token: 0x060036F2 RID: 14066 RVA: 0x00125D24 File Offset: 0x00123F24
		// (set) Token: 0x060036F3 RID: 14067 RVA: 0x0001C7CA File Offset: 0x0001A9CA
		public unsafe static float MOMENTUM_ANNOYED_THRESHOLD
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(NPCMovement.NativeFieldInfoPtr_MOMENTUM_ANNOYED_THRESHOLD, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NPCMovement.NativeFieldInfoPtr_MOMENTUM_ANNOYED_THRESHOLD, (void*)(&value));
			}
		}

		// Token: 0x1700116D RID: 4461
		// (get) Token: 0x060036F4 RID: 14068 RVA: 0x00125D40 File Offset: 0x00123F40
		// (set) Token: 0x060036F5 RID: 14069 RVA: 0x0001C7D8 File Offset: 0x0001A9D8
		public unsafe static float MOMENTUM_LIGHT_FLINCH_THRESHOLD
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(NPCMovement.NativeFieldInfoPtr_MOMENTUM_LIGHT_FLINCH_THRESHOLD, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NPCMovement.NativeFieldInfoPtr_MOMENTUM_LIGHT_FLINCH_THRESHOLD, (void*)(&value));
			}
		}

		// Token: 0x1700116E RID: 4462
		// (get) Token: 0x060036F6 RID: 14070 RVA: 0x00125D5C File Offset: 0x00123F5C
		// (set) Token: 0x060036F7 RID: 14071 RVA: 0x0001C7E6 File Offset: 0x0001A9E6
		public unsafe static float MOMENTUM_HEAVY_FLINCH_THRESHOLD
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(NPCMovement.NativeFieldInfoPtr_MOMENTUM_HEAVY_FLINCH_THRESHOLD, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NPCMovement.NativeFieldInfoPtr_MOMENTUM_HEAVY_FLINCH_THRESHOLD, (void*)(&value));
			}
		}

		// Token: 0x1700116F RID: 4463
		// (get) Token: 0x060036F8 RID: 14072 RVA: 0x00125D78 File Offset: 0x00123F78
		// (set) Token: 0x060036F9 RID: 14073 RVA: 0x0001C7F4 File Offset: 0x0001A9F4
		public unsafe static float MOMENTUM_RAGDOLL_THRESHOLD
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(NPCMovement.NativeFieldInfoPtr_MOMENTUM_RAGDOLL_THRESHOLD, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NPCMovement.NativeFieldInfoPtr_MOMENTUM_RAGDOLL_THRESHOLD, (void*)(&value));
			}
		}

		// Token: 0x17001170 RID: 4464
		// (get) Token: 0x060036FA RID: 14074 RVA: 0x00125D94 File Offset: 0x00123F94
		// (set) Token: 0x060036FB RID: 14075 RVA: 0x0001C802 File Offset: 0x0001AA02
		public unsafe static bool USE_PATH_CACHE
		{
			get
			{
				bool result;
				IL2CPP.il2cpp_field_static_get_value(NPCMovement.NativeFieldInfoPtr_USE_PATH_CACHE, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NPCMovement.NativeFieldInfoPtr_USE_PATH_CACHE, (void*)(&value));
			}
		}

		// Token: 0x17001171 RID: 4465
		// (get) Token: 0x060036FC RID: 14076 RVA: 0x00125DB0 File Offset: 0x00123FB0
		// (set) Token: 0x060036FD RID: 14077 RVA: 0x0001C810 File Offset: 0x0001AA10
		public unsafe static float STUMBLE_DURATION
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(NPCMovement.NativeFieldInfoPtr_STUMBLE_DURATION, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NPCMovement.NativeFieldInfoPtr_STUMBLE_DURATION, (void*)(&value));
			}
		}

		// Token: 0x17001172 RID: 4466
		// (get) Token: 0x060036FE RID: 14078 RVA: 0x00125DCC File Offset: 0x00123FCC
		// (set) Token: 0x060036FF RID: 14079 RVA: 0x0001C81E File Offset: 0x0001AA1E
		public unsafe static float STUMBLE_FORCE
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(NPCMovement.NativeFieldInfoPtr_STUMBLE_FORCE, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NPCMovement.NativeFieldInfoPtr_STUMBLE_FORCE, (void*)(&value));
			}
		}

		// Token: 0x17001173 RID: 4467
		// (get) Token: 0x06003700 RID: 14080 RVA: 0x00125DE8 File Offset: 0x00123FE8
		// (set) Token: 0x06003701 RID: 14081 RVA: 0x0001C82C File Offset: 0x0001AA2C
		public unsafe static float OBSTACLE_AVOIDANCE_RANGE
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(NPCMovement.NativeFieldInfoPtr_OBSTACLE_AVOIDANCE_RANGE, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NPCMovement.NativeFieldInfoPtr_OBSTACLE_AVOIDANCE_RANGE, (void*)(&value));
			}
		}

		// Token: 0x17001174 RID: 4468
		// (get) Token: 0x06003702 RID: 14082 RVA: 0x00125E04 File Offset: 0x00124004
		// (set) Token: 0x06003703 RID: 14083 RVA: 0x0001C83A File Offset: 0x0001AA3A
		public unsafe static float PLAYER_DIST_IMPACT_THRESHOLD
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(NPCMovement.NativeFieldInfoPtr_PLAYER_DIST_IMPACT_THRESHOLD, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NPCMovement.NativeFieldInfoPtr_PLAYER_DIST_IMPACT_THRESHOLD, (void*)(&value));
			}
		}

		// Token: 0x17001175 RID: 4469
		// (get) Token: 0x06003704 RID: 14084 RVA: 0x00125E20 File Offset: 0x00124020
		// (set) Token: 0x06003705 RID: 14085 RVA: 0x0001C848 File Offset: 0x0001AA48
		public unsafe static Dictionary<Vector3, Vector3> cachedClosestReachablePoints
		{
			get
			{
				System.IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(NPCMovement.NativeFieldInfoPtr_cachedClosestReachablePoints, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<Vector3, Vector3>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NPCMovement.NativeFieldInfoPtr_cachedClosestReachablePoints, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001176 RID: 4470
		// (get) Token: 0x06003706 RID: 14086 RVA: 0x00125E48 File Offset: 0x00124048
		// (set) Token: 0x06003707 RID: 14087 RVA: 0x0001C85A File Offset: 0x0001AA5A
		public unsafe static List<Vector3> cachedClosestPointKeys
		{
			get
			{
				System.IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(NPCMovement.NativeFieldInfoPtr_cachedClosestPointKeys, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Vector3>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NPCMovement.NativeFieldInfoPtr_cachedClosestPointKeys, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001177 RID: 4471
		// (get) Token: 0x06003708 RID: 14088 RVA: 0x00125E70 File Offset: 0x00124070
		// (set) Token: 0x06003709 RID: 14089 RVA: 0x0001C86C File Offset: 0x0001AA6C
		public unsafe static float CLOSEST_REACHABLE_POINT_CACHE_MAX_SQR_OFFSET
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(NPCMovement.NativeFieldInfoPtr_CLOSEST_REACHABLE_POINT_CACHE_MAX_SQR_OFFSET, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NPCMovement.NativeFieldInfoPtr_CLOSEST_REACHABLE_POINT_CACHE_MAX_SQR_OFFSET, (void*)(&value));
			}
		}

		// Token: 0x17001178 RID: 4472
		// (get) Token: 0x0600370A RID: 14090 RVA: 0x00125E8C File Offset: 0x0012408C
		// (set) Token: 0x0600370B RID: 14091 RVA: 0x0001C87A File Offset: 0x0001AA7A
		public unsafe bool DEBUG
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement.NativeFieldInfoPtr_DEBUG);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement.NativeFieldInfoPtr_DEBUG)) = value;
			}
		}

		// Token: 0x17001179 RID: 4473
		// (get) Token: 0x0600370C RID: 14092 RVA: 0x00125EB4 File Offset: 0x001240B4
		// (set) Token: 0x0600370D RID: 14093 RVA: 0x0001C895 File Offset: 0x0001AA95
		public unsafe float WalkSpeed
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement.NativeFieldInfoPtr_WalkSpeed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement.NativeFieldInfoPtr_WalkSpeed)) = value;
			}
		}

		// Token: 0x1700117A RID: 4474
		// (get) Token: 0x0600370E RID: 14094 RVA: 0x00125EDC File Offset: 0x001240DC
		// (set) Token: 0x0600370F RID: 14095 RVA: 0x0001C8B0 File Offset: 0x0001AAB0
		public unsafe float RunSpeed
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement.NativeFieldInfoPtr_RunSpeed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement.NativeFieldInfoPtr_RunSpeed)) = value;
			}
		}

		// Token: 0x1700117B RID: 4475
		// (get) Token: 0x06003710 RID: 14096 RVA: 0x00125F04 File Offset: 0x00124104
		// (set) Token: 0x06003711 RID: 14097 RVA: 0x0001C8CB File Offset: 0x0001AACB
		public unsafe float MoveSpeedMultiplier
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement.NativeFieldInfoPtr_MoveSpeedMultiplier);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement.NativeFieldInfoPtr_MoveSpeedMultiplier)) = value;
			}
		}

		// Token: 0x1700117C RID: 4476
		// (get) Token: 0x06003712 RID: 14098 RVA: 0x00125F2C File Offset: 0x0012412C
		// (set) Token: 0x06003713 RID: 14099 RVA: 0x0001C8E6 File Offset: 0x0001AAE6
		public unsafe bool SlipperyMode
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement.NativeFieldInfoPtr_SlipperyMode);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement.NativeFieldInfoPtr_SlipperyMode)) = value;
			}
		}

		// Token: 0x1700117D RID: 4477
		// (get) Token: 0x06003714 RID: 14100 RVA: 0x00125F54 File Offset: 0x00124154
		// (set) Token: 0x06003715 RID: 14101 RVA: 0x0001C901 File Offset: 0x0001AB01
		public unsafe float SlipperyModeMultiplier
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement.NativeFieldInfoPtr_SlipperyModeMultiplier);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement.NativeFieldInfoPtr_SlipperyModeMultiplier)) = value;
			}
		}

		// Token: 0x1700117E RID: 4478
		// (get) Token: 0x06003716 RID: 14102 RVA: 0x00125F7C File Offset: 0x0012417C
		// (set) Token: 0x06003717 RID: 14103 RVA: 0x0001C91C File Offset: 0x0001AB1C
		public unsafe ObstacleAvoidanceType DefaultObstacleAvoidanceType
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement.NativeFieldInfoPtr_DefaultObstacleAvoidanceType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement.NativeFieldInfoPtr_DefaultObstacleAvoidanceType)) = value;
			}
		}

		// Token: 0x1700117F RID: 4479
		// (get) Token: 0x06003718 RID: 14104 RVA: 0x00125FA4 File Offset: 0x001241A4
		// (set) Token: 0x06003719 RID: 14105 RVA: 0x0001C937 File Offset: 0x0001AB37
		public unsafe NavMeshAgent Agent
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement.NativeFieldInfoPtr_Agent);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NavMeshAgent>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement.NativeFieldInfoPtr_Agent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001180 RID: 4480
		// (get) Token: 0x0600371A RID: 14106 RVA: 0x00125FD4 File Offset: 0x001241D4
		// (set) Token: 0x0600371B RID: 14107 RVA: 0x0001C956 File Offset: 0x0001AB56
		public unsafe NPCSpeedController SpeedController
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement.NativeFieldInfoPtr_SpeedController);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NPCSpeedController>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement.NativeFieldInfoPtr_SpeedController), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001181 RID: 4481
		// (get) Token: 0x0600371C RID: 14108 RVA: 0x00126004 File Offset: 0x00124204
		// (set) Token: 0x0600371D RID: 14109 RVA: 0x0001C975 File Offset: 0x0001AB75
		public unsafe NPC npc
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement.NativeFieldInfoPtr_npc);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NPC>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement.NativeFieldInfoPtr_npc), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001182 RID: 4482
		// (get) Token: 0x0600371E RID: 14110 RVA: 0x00126034 File Offset: 0x00124234
		// (set) Token: 0x0600371F RID: 14111 RVA: 0x0001C994 File Offset: 0x0001AB94
		public unsafe CapsuleCollider capsuleCollider
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement.NativeFieldInfoPtr_capsuleCollider);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CapsuleCollider>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement.NativeFieldInfoPtr_capsuleCollider), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001183 RID: 4483
		// (get) Token: 0x06003720 RID: 14112 RVA: 0x00126064 File Offset: 0x00124264
		// (set) Token: 0x06003721 RID: 14113 RVA: 0x0001C9B3 File Offset: 0x0001ABB3
		public unsafe NPCAnimation anim
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement.NativeFieldInfoPtr_anim);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NPCAnimation>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement.NativeFieldInfoPtr_anim), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001184 RID: 4484
		// (get) Token: 0x06003722 RID: 14114 RVA: 0x00126094 File Offset: 0x00124294
		// (set) Token: 0x06003723 RID: 14115 RVA: 0x0001C9D2 File Offset: 0x0001ABD2
		public unsafe Rigidbody ragdollCentralRB
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement.NativeFieldInfoPtr_ragdollCentralRB);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Rigidbody>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement.NativeFieldInfoPtr_ragdollCentralRB), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001185 RID: 4485
		// (get) Token: 0x06003724 RID: 14116 RVA: 0x001260C4 File Offset: 0x001242C4
		// (set) Token: 0x06003725 RID: 14117 RVA: 0x0001C9F1 File Offset: 0x0001ABF1
		public unsafe SmoothedVelocityCalculator velocityCalculator
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement.NativeFieldInfoPtr_velocityCalculator);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SmoothedVelocityCalculator>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement.NativeFieldInfoPtr_velocityCalculator), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001186 RID: 4486
		// (get) Token: 0x06003726 RID: 14118 RVA: 0x001260F4 File Offset: 0x001242F4
		// (set) Token: 0x06003727 RID: 14119 RVA: 0x0001CA10 File Offset: 0x0001AC10
		public unsafe Draggable RagdollDraggable
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement.NativeFieldInfoPtr_RagdollDraggable);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Draggable>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement.NativeFieldInfoPtr_RagdollDraggable), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001187 RID: 4487
		// (get) Token: 0x06003728 RID: 14120 RVA: 0x00126124 File Offset: 0x00124324
		// (set) Token: 0x06003729 RID: 14121 RVA: 0x0001CA2F File Offset: 0x0001AC2F
		public unsafe Collider RagdollDraggableCollider
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement.NativeFieldInfoPtr_RagdollDraggableCollider);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Collider>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement.NativeFieldInfoPtr_RagdollDraggableCollider), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001188 RID: 4488
		// (get) Token: 0x0600372A RID: 14122 RVA: 0x00126154 File Offset: 0x00124354
		// (set) Token: 0x0600372B RID: 14123 RVA: 0x0001CA4E File Offset: 0x0001AC4E
		public unsafe float MovementSpeedScale
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement.NativeFieldInfoPtr_MovementSpeedScale);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement.NativeFieldInfoPtr_MovementSpeedScale)) = value;
			}
		}

		// Token: 0x17001189 RID: 4489
		// (get) Token: 0x0600372C RID: 14124 RVA: 0x0012617C File Offset: 0x0012437C
		// (set) Token: 0x0600372D RID: 14125 RVA: 0x0001CA69 File Offset: 0x0001AC69
		public unsafe bool _hasDestination_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement.NativeFieldInfoPtr__hasDestination_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement.NativeFieldInfoPtr__hasDestination_k__BackingField)) = value;
			}
		}

		// Token: 0x1700118A RID: 4490
		// (get) Token: 0x0600372E RID: 14126 RVA: 0x001261A4 File Offset: 0x001243A4
		// (set) Token: 0x0600372F RID: 14127 RVA: 0x0001CA84 File Offset: 0x0001AC84
		public unsafe bool _IsPaused_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement.NativeFieldInfoPtr__IsPaused_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement.NativeFieldInfoPtr__IsPaused_k__BackingField)) = value;
			}
		}

		// Token: 0x1700118B RID: 4491
		// (get) Token: 0x06003730 RID: 14128 RVA: 0x001261CC File Offset: 0x001243CC
		// (set) Token: 0x06003731 RID: 14129 RVA: 0x0001CA9F File Offset: 0x0001AC9F
		public unsafe float _GravityMultiplier_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement.NativeFieldInfoPtr__GravityMultiplier_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement.NativeFieldInfoPtr__GravityMultiplier_k__BackingField)) = value;
			}
		}

		// Token: 0x1700118C RID: 4492
		// (get) Token: 0x06003732 RID: 14130 RVA: 0x001261F4 File Offset: 0x001243F4
		// (set) Token: 0x06003733 RID: 14131 RVA: 0x0001CABA File Offset: 0x0001ACBA
		public unsafe NPCMovement.EStance _Stance_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement.NativeFieldInfoPtr__Stance_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement.NativeFieldInfoPtr__Stance_k__BackingField)) = value;
			}
		}

		// Token: 0x1700118D RID: 4493
		// (get) Token: 0x06003734 RID: 14132 RVA: 0x0012621C File Offset: 0x0012441C
		// (set) Token: 0x06003735 RID: 14133 RVA: 0x0001CAD5 File Offset: 0x0001ACD5
		public unsafe float _timeSinceHitByCar_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement.NativeFieldInfoPtr__timeSinceHitByCar_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement.NativeFieldInfoPtr__timeSinceHitByCar_k__BackingField)) = value;
			}
		}

		// Token: 0x1700118E RID: 4494
		// (get) Token: 0x06003736 RID: 14134 RVA: 0x00126244 File Offset: 0x00124444
		// (set) Token: 0x06003737 RID: 14135 RVA: 0x0001CAF0 File Offset: 0x0001ACF0
		public unsafe float ragdollTime
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement.NativeFieldInfoPtr_ragdollTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement.NativeFieldInfoPtr_ragdollTime)) = value;
			}
		}

		// Token: 0x1700118F RID: 4495
		// (get) Token: 0x06003738 RID: 14136 RVA: 0x0012626C File Offset: 0x0012446C
		// (set) Token: 0x06003739 RID: 14137 RVA: 0x0001CB0B File Offset: 0x0001AD0B
		public unsafe float ragdollStaticTime
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement.NativeFieldInfoPtr_ragdollStaticTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement.NativeFieldInfoPtr_ragdollStaticTime)) = value;
			}
		}

		// Token: 0x17001190 RID: 4496
		// (get) Token: 0x0600373A RID: 14138 RVA: 0x00126294 File Offset: 0x00124494
		// (set) Token: 0x0600373B RID: 14139 RVA: 0x0001CB26 File Offset: 0x0001AD26
		public unsafe UnityEvent<LandVehicle> onHitByCar
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement.NativeFieldInfoPtr_onHitByCar);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent<LandVehicle>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement.NativeFieldInfoPtr_onHitByCar), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001191 RID: 4497
		// (get) Token: 0x0600373C RID: 14140 RVA: 0x001262C4 File Offset: 0x001244C4
		// (set) Token: 0x0600373D RID: 14141 RVA: 0x0001CB45 File Offset: 0x0001AD45
		public unsafe UnityEvent onRagdollStart
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement.NativeFieldInfoPtr_onRagdollStart);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement.NativeFieldInfoPtr_onRagdollStart), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001192 RID: 4498
		// (get) Token: 0x0600373E RID: 14142 RVA: 0x001262F4 File Offset: 0x001244F4
		// (set) Token: 0x0600373F RID: 14143 RVA: 0x0001CB64 File Offset: 0x0001AD64
		public unsafe UnityEvent onRagdollEnd
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement.NativeFieldInfoPtr_onRagdollEnd);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement.NativeFieldInfoPtr_onRagdollEnd), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001193 RID: 4499
		// (get) Token: 0x06003740 RID: 14144 RVA: 0x00126324 File Offset: 0x00124524
		// (set) Token: 0x06003741 RID: 14145 RVA: 0x0001CB83 File Offset: 0x0001AD83
		public unsafe Vector3 _CurrentDestination_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement.NativeFieldInfoPtr__CurrentDestination_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement.NativeFieldInfoPtr__CurrentDestination_k__BackingField)) = value;
			}
		}

		// Token: 0x17001194 RID: 4500
		// (get) Token: 0x06003742 RID: 14146 RVA: 0x0012634C File Offset: 0x0012454C
		// (set) Token: 0x06003743 RID: 14147 RVA: 0x0001CB9E File Offset: 0x0001AD9E
		public unsafe NPCPathCache _PathCache_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement.NativeFieldInfoPtr__PathCache_k__BackingField);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NPCPathCache>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement.NativeFieldInfoPtr__PathCache_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001195 RID: 4501
		// (get) Token: 0x06003744 RID: 14148 RVA: 0x0012637C File Offset: 0x0012457C
		// (set) Token: 0x06003745 RID: 14149 RVA: 0x0001CBBD File Offset: 0x0001ADBD
		public unsafe bool cacheNextPath
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement.NativeFieldInfoPtr_cacheNextPath);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement.NativeFieldInfoPtr_cacheNextPath)) = value;
			}
		}

		// Token: 0x17001196 RID: 4502
		// (get) Token: 0x06003746 RID: 14150 RVA: 0x001263A4 File Offset: 0x001245A4
		// (set) Token: 0x06003747 RID: 14151 RVA: 0x0001CBD8 File Offset: 0x0001ADD8
		public unsafe Vector3 currentDestination_Reachable
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement.NativeFieldInfoPtr_currentDestination_Reachable);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement.NativeFieldInfoPtr_currentDestination_Reachable)) = value;
			}
		}

		// Token: 0x17001197 RID: 4503
		// (get) Token: 0x06003748 RID: 14152 RVA: 0x001263CC File Offset: 0x001245CC
		// (set) Token: 0x06003749 RID: 14153 RVA: 0x0001CBF3 File Offset: 0x0001ADF3
		public unsafe Il2CppSystem.Action<NPCMovement.WalkResult> walkResultCallback
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement.NativeFieldInfoPtr_walkResultCallback);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Action<NPCMovement.WalkResult>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement.NativeFieldInfoPtr_walkResultCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001198 RID: 4504
		// (get) Token: 0x0600374A RID: 14154 RVA: 0x001263FC File Offset: 0x001245FC
		// (set) Token: 0x0600374B RID: 14155 RVA: 0x0001CC12 File Offset: 0x0001AE12
		public unsafe float currentMaxDistanceForSuccess
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement.NativeFieldInfoPtr_currentMaxDistanceForSuccess);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement.NativeFieldInfoPtr_currentMaxDistanceForSuccess)) = value;
			}
		}

		// Token: 0x17001199 RID: 4505
		// (get) Token: 0x0600374C RID: 14156 RVA: 0x00126424 File Offset: 0x00124624
		// (set) Token: 0x0600374D RID: 14157 RVA: 0x0001CC2D File Offset: 0x0001AE2D
		public unsafe bool forceIsMoving
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement.NativeFieldInfoPtr_forceIsMoving);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement.NativeFieldInfoPtr_forceIsMoving)) = value;
			}
		}

		// Token: 0x1700119A RID: 4506
		// (get) Token: 0x0600374E RID: 14158 RVA: 0x0012644C File Offset: 0x0012464C
		// (set) Token: 0x0600374F RID: 14159 RVA: 0x0001CC48 File Offset: 0x0001AE48
		public unsafe Coroutine FaceDirectionRoutine
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement.NativeFieldInfoPtr_FaceDirectionRoutine);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement.NativeFieldInfoPtr_FaceDirectionRoutine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700119B RID: 4507
		// (get) Token: 0x06003750 RID: 14160 RVA: 0x0012647C File Offset: 0x0012467C
		// (set) Token: 0x06003751 RID: 14161 RVA: 0x0001CC67 File Offset: 0x0001AE67
		public unsafe List<ConstantForce> ragdollForceComponents
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement.NativeFieldInfoPtr_ragdollForceComponents);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ConstantForce>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement.NativeFieldInfoPtr_ragdollForceComponents), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700119C RID: 4508
		// (get) Token: 0x06003752 RID: 14162 RVA: 0x001264AC File Offset: 0x001246AC
		// (set) Token: 0x06003753 RID: 14163 RVA: 0x0001CC86 File Offset: 0x0001AE86
		public unsafe bool _Disoriented_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement.NativeFieldInfoPtr__Disoriented_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement.NativeFieldInfoPtr__Disoriented_k__BackingField)) = value;
			}
		}

		// Token: 0x1700119D RID: 4509
		// (get) Token: 0x06003754 RID: 14164 RVA: 0x001264D4 File Offset: 0x001246D4
		// (set) Token: 0x06003755 RID: 14165 RVA: 0x0001CCA1 File Offset: 0x0001AEA1
		public unsafe float timeUntilNextStumble
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement.NativeFieldInfoPtr_timeUntilNextStumble);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement.NativeFieldInfoPtr_timeUntilNextStumble)) = value;
			}
		}

		// Token: 0x1700119E RID: 4510
		// (get) Token: 0x06003756 RID: 14166 RVA: 0x001264FC File Offset: 0x001246FC
		// (set) Token: 0x06003757 RID: 14167 RVA: 0x0001CCBC File Offset: 0x0001AEBC
		public unsafe float timeSinceStumble
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement.NativeFieldInfoPtr_timeSinceStumble);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement.NativeFieldInfoPtr_timeSinceStumble)) = value;
			}
		}

		// Token: 0x1700119F RID: 4511
		// (get) Token: 0x06003758 RID: 14168 RVA: 0x00126524 File Offset: 0x00124724
		// (set) Token: 0x06003759 RID: 14169 RVA: 0x0001CCD7 File Offset: 0x0001AED7
		public unsafe Vector3 stumbleDirection
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement.NativeFieldInfoPtr_stumbleDirection);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement.NativeFieldInfoPtr_stumbleDirection)) = value;
			}
		}

		// Token: 0x170011A0 RID: 4512
		// (get) Token: 0x0600375A RID: 14170 RVA: 0x0012654C File Offset: 0x0012474C
		// (set) Token: 0x0600375B RID: 14171 RVA: 0x0001CCF2 File Offset: 0x0001AEF2
		public unsafe List<Vector3> desiredVelocityHistory
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement.NativeFieldInfoPtr_desiredVelocityHistory);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Vector3>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement.NativeFieldInfoPtr_desiredVelocityHistory), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170011A1 RID: 4513
		// (get) Token: 0x0600375C RID: 14172 RVA: 0x0012657C File Offset: 0x0012477C
		// (set) Token: 0x0600375D RID: 14173 RVA: 0x0001CD11 File Offset: 0x0001AF11
		public unsafe int desiredVelocityHistoryLength
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement.NativeFieldInfoPtr_desiredVelocityHistoryLength);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement.NativeFieldInfoPtr_desiredVelocityHistoryLength)) = value;
			}
		}

		// Token: 0x170011A2 RID: 4514
		// (get) Token: 0x0600375E RID: 14174 RVA: 0x001265A4 File Offset: 0x001247A4
		// (set) Token: 0x0600375F RID: 14175 RVA: 0x0001CD2C File Offset: 0x0001AF2C
		public unsafe float velocityHistorySpacing
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement.NativeFieldInfoPtr_velocityHistorySpacing);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement.NativeFieldInfoPtr_velocityHistorySpacing)) = value;
			}
		}

		// Token: 0x170011A3 RID: 4515
		// (get) Token: 0x06003760 RID: 14176 RVA: 0x001265CC File Offset: 0x001247CC
		// (set) Token: 0x06003761 RID: 14177 RVA: 0x0001CD47 File Offset: 0x0001AF47
		public unsafe float timeSinceLastVelocityHistoryRecord
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement.NativeFieldInfoPtr_timeSinceLastVelocityHistoryRecord);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement.NativeFieldInfoPtr_timeSinceLastVelocityHistoryRecord)) = value;
			}
		}

		// Token: 0x170011A4 RID: 4516
		// (get) Token: 0x06003762 RID: 14178 RVA: 0x001265F4 File Offset: 0x001247F4
		// (set) Token: 0x06003763 RID: 14179 RVA: 0x0001CD62 File Offset: 0x0001AF62
		public unsafe bool field_Private_Boolean_0
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement.NativeFieldInfoPtr_field_Private_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement.NativeFieldInfoPtr_field_Private_Boolean_0)) = value;
			}
		}

		// Token: 0x170011A5 RID: 4517
		// (get) Token: 0x06003764 RID: 14180 RVA: 0x0012661C File Offset: 0x0012481C
		// (set) Token: 0x06003765 RID: 14181 RVA: 0x0001CD7D File Offset: 0x0001AF7D
		public unsafe bool field_Private_Boolean_1
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement.NativeFieldInfoPtr_field_Private_Boolean_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement.NativeFieldInfoPtr_field_Private_Boolean_1)) = value;
			}
		}

		// Token: 0x0400239F RID: 9119
		private static readonly System.IntPtr NativeFieldInfoPtr_VEHICLE_RUNOVER_THRESHOLD;

		// Token: 0x040023A0 RID: 9120
		private static readonly System.IntPtr NativeFieldInfoPtr_SKATEBOARD_RUNOVER_THRESHOLD;

		// Token: 0x040023A1 RID: 9121
		private static readonly System.IntPtr NativeFieldInfoPtr_LIGHT_FLINCH_THRESHOLD;

		// Token: 0x040023A2 RID: 9122
		private static readonly System.IntPtr NativeFieldInfoPtr_HEAVY_FLINCH_THRESHOLD;

		// Token: 0x040023A3 RID: 9123
		private static readonly System.IntPtr NativeFieldInfoPtr_RAGDOLL_THRESHOLD;

		// Token: 0x040023A4 RID: 9124
		private static readonly System.IntPtr NativeFieldInfoPtr_MOMENTUM_ANNOYED_THRESHOLD;

		// Token: 0x040023A5 RID: 9125
		private static readonly System.IntPtr NativeFieldInfoPtr_MOMENTUM_LIGHT_FLINCH_THRESHOLD;

		// Token: 0x040023A6 RID: 9126
		private static readonly System.IntPtr NativeFieldInfoPtr_MOMENTUM_HEAVY_FLINCH_THRESHOLD;

		// Token: 0x040023A7 RID: 9127
		private static readonly System.IntPtr NativeFieldInfoPtr_MOMENTUM_RAGDOLL_THRESHOLD;

		// Token: 0x040023A8 RID: 9128
		private static readonly System.IntPtr NativeFieldInfoPtr_USE_PATH_CACHE;

		// Token: 0x040023A9 RID: 9129
		private static readonly System.IntPtr NativeFieldInfoPtr_STUMBLE_DURATION;

		// Token: 0x040023AA RID: 9130
		private static readonly System.IntPtr NativeFieldInfoPtr_STUMBLE_FORCE;

		// Token: 0x040023AB RID: 9131
		private static readonly System.IntPtr NativeFieldInfoPtr_OBSTACLE_AVOIDANCE_RANGE;

		// Token: 0x040023AC RID: 9132
		private static readonly System.IntPtr NativeFieldInfoPtr_PLAYER_DIST_IMPACT_THRESHOLD;

		// Token: 0x040023AD RID: 9133
		private static readonly System.IntPtr NativeFieldInfoPtr_cachedClosestReachablePoints;

		// Token: 0x040023AE RID: 9134
		private static readonly System.IntPtr NativeFieldInfoPtr_cachedClosestPointKeys;

		// Token: 0x040023AF RID: 9135
		private static readonly System.IntPtr NativeFieldInfoPtr_CLOSEST_REACHABLE_POINT_CACHE_MAX_SQR_OFFSET;

		// Token: 0x040023B0 RID: 9136
		private static readonly System.IntPtr NativeFieldInfoPtr_DEBUG;

		// Token: 0x040023B1 RID: 9137
		private static readonly System.IntPtr NativeFieldInfoPtr_WalkSpeed;

		// Token: 0x040023B2 RID: 9138
		private static readonly System.IntPtr NativeFieldInfoPtr_RunSpeed;

		// Token: 0x040023B3 RID: 9139
		private static readonly System.IntPtr NativeFieldInfoPtr_MoveSpeedMultiplier;

		// Token: 0x040023B4 RID: 9140
		private static readonly System.IntPtr NativeFieldInfoPtr_SlipperyMode;

		// Token: 0x040023B5 RID: 9141
		private static readonly System.IntPtr NativeFieldInfoPtr_SlipperyModeMultiplier;

		// Token: 0x040023B6 RID: 9142
		private static readonly System.IntPtr NativeFieldInfoPtr_DefaultObstacleAvoidanceType;

		// Token: 0x040023B7 RID: 9143
		private static readonly System.IntPtr NativeFieldInfoPtr_Agent;

		// Token: 0x040023B8 RID: 9144
		private static readonly System.IntPtr NativeFieldInfoPtr_SpeedController;

		// Token: 0x040023B9 RID: 9145
		private static readonly System.IntPtr NativeFieldInfoPtr_npc;

		// Token: 0x040023BA RID: 9146
		private static readonly System.IntPtr NativeFieldInfoPtr_capsuleCollider;

		// Token: 0x040023BB RID: 9147
		private static readonly System.IntPtr NativeFieldInfoPtr_anim;

		// Token: 0x040023BC RID: 9148
		private static readonly System.IntPtr NativeFieldInfoPtr_ragdollCentralRB;

		// Token: 0x040023BD RID: 9149
		private static readonly System.IntPtr NativeFieldInfoPtr_velocityCalculator;

		// Token: 0x040023BE RID: 9150
		private static readonly System.IntPtr NativeFieldInfoPtr_RagdollDraggable;

		// Token: 0x040023BF RID: 9151
		private static readonly System.IntPtr NativeFieldInfoPtr_RagdollDraggableCollider;

		// Token: 0x040023C0 RID: 9152
		private static readonly System.IntPtr NativeFieldInfoPtr_MovementSpeedScale;

		// Token: 0x040023C1 RID: 9153
		private static readonly System.IntPtr NativeFieldInfoPtr__hasDestination_k__BackingField;

		// Token: 0x040023C2 RID: 9154
		private static readonly System.IntPtr NativeFieldInfoPtr__IsPaused_k__BackingField;

		// Token: 0x040023C3 RID: 9155
		private static readonly System.IntPtr NativeFieldInfoPtr__GravityMultiplier_k__BackingField;

		// Token: 0x040023C4 RID: 9156
		private static readonly System.IntPtr NativeFieldInfoPtr__Stance_k__BackingField;

		// Token: 0x040023C5 RID: 9157
		private static readonly System.IntPtr NativeFieldInfoPtr__timeSinceHitByCar_k__BackingField;

		// Token: 0x040023C6 RID: 9158
		private static readonly System.IntPtr NativeFieldInfoPtr_ragdollTime;

		// Token: 0x040023C7 RID: 9159
		private static readonly System.IntPtr NativeFieldInfoPtr_ragdollStaticTime;

		// Token: 0x040023C8 RID: 9160
		private static readonly System.IntPtr NativeFieldInfoPtr_onHitByCar;

		// Token: 0x040023C9 RID: 9161
		private static readonly System.IntPtr NativeFieldInfoPtr_onRagdollStart;

		// Token: 0x040023CA RID: 9162
		private static readonly System.IntPtr NativeFieldInfoPtr_onRagdollEnd;

		// Token: 0x040023CB RID: 9163
		private static readonly System.IntPtr NativeFieldInfoPtr__CurrentDestination_k__BackingField;

		// Token: 0x040023CC RID: 9164
		private static readonly System.IntPtr NativeFieldInfoPtr__PathCache_k__BackingField;

		// Token: 0x040023CD RID: 9165
		private static readonly System.IntPtr NativeFieldInfoPtr_cacheNextPath;

		// Token: 0x040023CE RID: 9166
		private static readonly System.IntPtr NativeFieldInfoPtr_currentDestination_Reachable;

		// Token: 0x040023CF RID: 9167
		private static readonly System.IntPtr NativeFieldInfoPtr_walkResultCallback;

		// Token: 0x040023D0 RID: 9168
		private static readonly System.IntPtr NativeFieldInfoPtr_currentMaxDistanceForSuccess;

		// Token: 0x040023D1 RID: 9169
		private static readonly System.IntPtr NativeFieldInfoPtr_forceIsMoving;

		// Token: 0x040023D2 RID: 9170
		private static readonly System.IntPtr NativeFieldInfoPtr_FaceDirectionRoutine;

		// Token: 0x040023D3 RID: 9171
		private static readonly System.IntPtr NativeFieldInfoPtr_ragdollForceComponents;

		// Token: 0x040023D4 RID: 9172
		private static readonly System.IntPtr NativeFieldInfoPtr__Disoriented_k__BackingField;

		// Token: 0x040023D5 RID: 9173
		private static readonly System.IntPtr NativeFieldInfoPtr_timeUntilNextStumble;

		// Token: 0x040023D6 RID: 9174
		private static readonly System.IntPtr NativeFieldInfoPtr_timeSinceStumble;

		// Token: 0x040023D7 RID: 9175
		private static readonly System.IntPtr NativeFieldInfoPtr_stumbleDirection;

		// Token: 0x040023D8 RID: 9176
		private static readonly System.IntPtr NativeFieldInfoPtr_desiredVelocityHistory;

		// Token: 0x040023D9 RID: 9177
		private static readonly System.IntPtr NativeFieldInfoPtr_desiredVelocityHistoryLength;

		// Token: 0x040023DA RID: 9178
		private static readonly System.IntPtr NativeFieldInfoPtr_velocityHistorySpacing;

		// Token: 0x040023DB RID: 9179
		private static readonly System.IntPtr NativeFieldInfoPtr_timeSinceLastVelocityHistoryRecord;

		// Token: 0x040023DC RID: 9180
		private static readonly System.IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

		// Token: 0x040023DD RID: 9181
		private static readonly System.IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

		// Token: 0x040023DE RID: 9182
		private static readonly System.IntPtr NativeMethodInfoPtr_get_hasDestination_Public_get_Boolean_0;

		// Token: 0x040023DF RID: 9183
		private static readonly System.IntPtr NativeMethodInfoPtr_set_hasDestination_Protected_set_Void_Boolean_0;

		// Token: 0x040023E0 RID: 9184
		private static readonly System.IntPtr NativeMethodInfoPtr_get_IsMoving_Public_get_Boolean_0;

		// Token: 0x040023E1 RID: 9185
		private static readonly System.IntPtr NativeMethodInfoPtr_get_IsPaused_Public_get_Boolean_0;

		// Token: 0x040023E2 RID: 9186
		private static readonly System.IntPtr NativeMethodInfoPtr_set_IsPaused_Protected_set_Void_Boolean_0;

		// Token: 0x040023E3 RID: 9187
		private static readonly System.IntPtr NativeMethodInfoPtr_get_FootPosition_Public_get_Vector3_0;

		// Token: 0x040023E4 RID: 9188
		private static readonly System.IntPtr NativeMethodInfoPtr_get_GravityMultiplier_Public_get_Single_0;

		// Token: 0x040023E5 RID: 9189
		private static readonly System.IntPtr NativeMethodInfoPtr_set_GravityMultiplier_Protected_set_Void_Single_0;

		// Token: 0x040023E6 RID: 9190
		private static readonly System.IntPtr NativeMethodInfoPtr_get_Stance_Public_get_EStance_0;

		// Token: 0x040023E7 RID: 9191
		private static readonly System.IntPtr NativeMethodInfoPtr_set_Stance_Protected_set_Void_EStance_0;

		// Token: 0x040023E8 RID: 9192
		private static readonly System.IntPtr NativeMethodInfoPtr_get_timeSinceHitByCar_Public_get_Single_0;

		// Token: 0x040023E9 RID: 9193
		private static readonly System.IntPtr NativeMethodInfoPtr_set_timeSinceHitByCar_Protected_set_Void_Single_0;

		// Token: 0x040023EA RID: 9194
		private static readonly System.IntPtr NativeMethodInfoPtr_get_FaceDirectionInProgress_Public_get_Boolean_0;

		// Token: 0x040023EB RID: 9195
		private static readonly System.IntPtr NativeMethodInfoPtr_get_CurrentDestination_Public_get_Vector3_0;

		// Token: 0x040023EC RID: 9196
		private static readonly System.IntPtr NativeMethodInfoPtr_set_CurrentDestination_Protected_set_Void_Vector3_0;

		// Token: 0x040023ED RID: 9197
		private static readonly System.IntPtr NativeMethodInfoPtr_get_PathCache_Public_get_NPCPathCache_0;

		// Token: 0x040023EE RID: 9198
		private static readonly System.IntPtr NativeMethodInfoPtr_set_PathCache_Private_set_Void_NPCPathCache_0;

		// Token: 0x040023EF RID: 9199
		private static readonly System.IntPtr NativeMethodInfoPtr_get_Disoriented_Public_get_Boolean_0;

		// Token: 0x040023F0 RID: 9200
		private static readonly System.IntPtr NativeMethodInfoPtr_set_Disoriented_Public_set_Void_Boolean_0;

		// Token: 0x040023F1 RID: 9201
		private static readonly System.IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;

		// Token: 0x040023F2 RID: 9202
		private static readonly System.IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x040023F3 RID: 9203
		private static readonly System.IntPtr NativeMethodInfoPtr_OnStartClient_Public_Virtual_Void_0;

		// Token: 0x040023F4 RID: 9204
		private static readonly System.IntPtr NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0;

		// Token: 0x040023F5 RID: 9205
		private static readonly System.IntPtr NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_1;

		// Token: 0x040023F6 RID: 9206
		private static readonly System.IntPtr NativeMethodInfoPtr_LateUpdate_Protected_Virtual_New_Void_1;

		// Token: 0x040023F7 RID: 9207
		private static readonly System.IntPtr NativeMethodInfoPtr_UpdateRagdoll_Private_Void_0;

		// Token: 0x040023F8 RID: 9208
		private static readonly System.IntPtr NativeMethodInfoPtr_Stumble_Private_Void_0;

		// Token: 0x040023F9 RID: 9209
		private static readonly System.IntPtr NativeMethodInfoPtr_UpdateDestination_Private_Void_0;

		// Token: 0x040023FA RID: 9210
		private static readonly System.IntPtr NativeMethodInfoPtr_FixedUpdate_Protected_Virtual_New_Void_1;

		// Token: 0x040023FB RID: 9211
		private static readonly System.IntPtr NativeMethodInfoPtr_UpdateStumble_Private_Void_0;

		// Token: 0x040023FC RID: 9212
		private static readonly System.IntPtr NativeMethodInfoPtr_UpdateSpeed_Private_Void_0;

		// Token: 0x040023FD RID: 9213
		private static readonly System.IntPtr NativeMethodInfoPtr_RecordVelocity_Private_Void_0;

		// Token: 0x040023FE RID: 9214
		private static readonly System.IntPtr NativeMethodInfoPtr_UpdateSlippery_Private_Void_0;

		// Token: 0x040023FF RID: 9215
		private static readonly System.IntPtr NativeMethodInfoPtr_UpdateCache_Private_Void_0;

		// Token: 0x04002400 RID: 9216
		private static readonly System.IntPtr NativeMethodInfoPtr_CanRecoverFromRagdoll_Public_Boolean_0;

		// Token: 0x04002401 RID: 9217
		private static readonly System.IntPtr NativeMethodInfoPtr_UpdateAvoidance_Private_Void_0;

		// Token: 0x04002402 RID: 9218
		private static readonly System.IntPtr NativeMethodInfoPtr_OnTriggerEnter_Public_Void_Collider_0;

		// Token: 0x04002403 RID: 9219
		private static readonly System.IntPtr NativeMethodInfoPtr_OnCollisionEnter_Public_Void_Collision_0;

		// Token: 0x04002404 RID: 9220
		private static readonly System.IntPtr NativeMethodInfoPtr_CheckHit_Private_Void_Collider_Collider_Boolean_Vector3_0;

		// Token: 0x04002405 RID: 9221
		private static readonly System.IntPtr NativeMethodInfoPtr_Warp_Public_Void_Transform_0;

		// Token: 0x04002406 RID: 9222
		private static readonly System.IntPtr NativeMethodInfoPtr_Warp_Public_Void_Vector3_0;

		// Token: 0x04002407 RID: 9223
		private static readonly System.IntPtr NativeMethodInfoPtr_ReceiveWarp_Private_Void_Vector3_0;

		// Token: 0x04002408 RID: 9224
		private static readonly System.IntPtr NativeMethodInfoPtr_VisibilityChange_Public_Void_Boolean_0;

		// Token: 0x04002409 RID: 9225
		private static readonly System.IntPtr NativeMethodInfoPtr_CanMove_Public_Boolean_0;

		// Token: 0x0400240A RID: 9226
		private static readonly System.IntPtr NativeMethodInfoPtr_SetAgentType_Public_Void_EAgentType_0;

		// Token: 0x0400240B RID: 9227
		private static readonly System.IntPtr NativeMethodInfoPtr_SetSeat_Public_Void_AvatarSeat_0;

		// Token: 0x0400240C RID: 9228
		private static readonly System.IntPtr NativeMethodInfoPtr_SetStance_Public_Void_EStance_0;

		// Token: 0x0400240D RID: 9229
		private static readonly System.IntPtr NativeMethodInfoPtr_SetGravityMultiplier_Public_Void_Single_0;

		// Token: 0x0400240E RID: 9230
		private static readonly System.IntPtr NativeMethodInfoPtr_SetRagdollDraggable_Public_Void_Boolean_0;

		// Token: 0x0400240F RID: 9231
		private static readonly System.IntPtr NativeMethodInfoPtr_ActivateRagdoll_Server_Public_Void_0;

		// Token: 0x04002410 RID: 9232
		private static readonly System.IntPtr NativeMethodInfoPtr_ActivateRagdoll_Public_Void_Vector3_Vector3_Single_0;

		// Token: 0x04002411 RID: 9233
		private static readonly System.IntPtr NativeMethodInfoPtr_ApplyRagdollForce_Public_Void_Vector3_Vector3_Single_0;

		// Token: 0x04002412 RID: 9234
		private static readonly System.IntPtr NativeMethodInfoPtr_DeactivateRagdoll_Public_Void_0;

		// Token: 0x04002413 RID: 9235
		private static readonly System.IntPtr NativeMethodInfoPtr_SmartSampleNavMesh_Private_Boolean_Vector3_byref_NavMeshHit_Single_Single_Int32_0;

		// Token: 0x04002414 RID: 9236
		private static readonly System.IntPtr NativeMethodInfoPtr_SetDestination_Public_Void_Vector3_0;

		// Token: 0x04002415 RID: 9237
		private static readonly System.IntPtr NativeMethodInfoPtr_SetDestination_Public_Void_ITransitEntity_0;

		// Token: 0x04002416 RID: 9238
		private static readonly System.IntPtr NativeMethodInfoPtr_SetDestination_Public_Void_Vector3_Action_1_WalkResult_Single_Single_0;

		// Token: 0x04002417 RID: 9239
		private static readonly System.IntPtr NativeMethodInfoPtr_SetDestination_Private_Void_Vector3_Action_1_WalkResult_Boolean_Single_Single_0;

		// Token: 0x04002418 RID: 9240
		private static readonly System.IntPtr NativeMethodInfoPtr_IsNPCPositionValid_Private_Boolean_Vector3_0;

		// Token: 0x04002419 RID: 9241
		private static readonly System.IntPtr NativeMethodInfoPtr_EndSetDestination_Private_Void_WalkResult_0;

		// Token: 0x0400241A RID: 9242
		private static readonly System.IntPtr NativeMethodInfoPtr_Stop_Public_Void_0;

		// Token: 0x0400241B RID: 9243
		private static readonly System.IntPtr NativeMethodInfoPtr_WarpToNavMesh_Public_Void_0;

		// Token: 0x0400241C RID: 9244
		private static readonly System.IntPtr NativeMethodInfoPtr_FacePoint_Public_Void_Vector3_Single_0;

		// Token: 0x0400241D RID: 9245
		private static readonly System.IntPtr NativeMethodInfoPtr_FaceDirection_Public_Void_Vector3_Single_0;

		// Token: 0x0400241E RID: 9246
		private static readonly System.IntPtr NativeMethodInfoPtr_FaceDirection_Process_Protected_IEnumerator_Vector3_Single_0;

		// Token: 0x0400241F RID: 9247
		private static readonly System.IntPtr NativeMethodInfoPtr_PauseMovement_Public_Void_0;

		// Token: 0x04002420 RID: 9248
		private static readonly System.IntPtr NativeMethodInfoPtr_ResumeMovement_Public_Void_0;

		// Token: 0x04002421 RID: 9249
		private static readonly System.IntPtr NativeMethodInfoPtr_IsAsCloseAsPossible_Public_Boolean_Vector3_Single_0;

		// Token: 0x04002422 RID: 9250
		private static readonly System.IntPtr NativeMethodInfoPtr_GetClosestReachablePoint_Public_Boolean_Vector3_byref_Vector3_0;

		// Token: 0x04002423 RID: 9251
		private static readonly System.IntPtr NativeMethodInfoPtr_CanGetTo_Public_Boolean_Vector3_Single_0;

		// Token: 0x04002424 RID: 9252
		private static readonly System.IntPtr NativeMethodInfoPtr_CanGetTo_Public_Boolean_ITransitEntity_Single_0;

		// Token: 0x04002425 RID: 9253
		private static readonly System.IntPtr NativeMethodInfoPtr_CanGetTo_Public_Boolean_Vector3_Single_byref_NavMeshPath_0;

		// Token: 0x04002426 RID: 9254
		private static readonly System.IntPtr NativeMethodInfoPtr_GetPathTo_Private_NavMeshPath_Vector3_Single_0;

		// Token: 0x04002427 RID: 9255
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04002428 RID: 9256
		private static readonly System.IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

		// Token: 0x04002429 RID: 9257
		private static readonly System.IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

		// Token: 0x0400242A RID: 9258
		private static readonly System.IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

		// Token: 0x0400242B RID: 9259
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcWriter___Observers_ReceiveWarp_4276783012_Private_Void_Vector3_0;

		// Token: 0x0400242C RID: 9260
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcLogic___ReceiveWarp_4276783012_Private_Void_Vector3_0;

		// Token: 0x0400242D RID: 9261
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcReader___Observers_ReceiveWarp_4276783012_Private_Void_PooledReader_Channel_0;

		// Token: 0x0400242E RID: 9262
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcWriter___Server_ActivateRagdoll_Server_2166136261_Private_Void_0;

		// Token: 0x0400242F RID: 9263
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcLogic___ActivateRagdoll_Server_2166136261_Public_Void_0;

		// Token: 0x04002430 RID: 9264
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcReader___Server_ActivateRagdoll_Server_2166136261_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x04002431 RID: 9265
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcWriter___Observers_ActivateRagdoll_2690242654_Private_Void_Vector3_Vector3_Single_0;

		// Token: 0x04002432 RID: 9266
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcLogic___ActivateRagdoll_2690242654_Public_Void_Vector3_Vector3_Single_0;

		// Token: 0x04002433 RID: 9267
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcReader___Observers_ActivateRagdoll_2690242654_Private_Void_PooledReader_Channel_0;

		// Token: 0x04002434 RID: 9268
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcWriter___Observers_ApplyRagdollForce_2690242654_Private_Void_Vector3_Vector3_Single_0;

		// Token: 0x04002435 RID: 9269
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcLogic___ApplyRagdollForce_2690242654_Public_Void_Vector3_Vector3_Single_0;

		// Token: 0x04002436 RID: 9270
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcReader___Observers_ApplyRagdollForce_2690242654_Private_Void_PooledReader_Channel_0;

		// Token: 0x04002437 RID: 9271
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcWriter___Observers_DeactivateRagdoll_2166136261_Private_Void_0;

		// Token: 0x04002438 RID: 9272
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcLogic___DeactivateRagdoll_2166136261_Public_Void_0;

		// Token: 0x04002439 RID: 9273
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcReader___Observers_DeactivateRagdoll_2166136261_Private_Void_PooledReader_Channel_0;

		// Token: 0x0400243A RID: 9274
		private static readonly System.IntPtr NativeMethodInfoPtr_Method_Protected_Virtual_New_Void_0;

		// Token: 0x0200096B RID: 2411
		[OriginalName("Assembly-CSharp.dll", "", "EAgentType")]
		public enum EAgentType
		{
			// Token: 0x040089BB RID: 35259
			Humanoid,
			// Token: 0x040089BC RID: 35260
			BigHumanoid,
			// Token: 0x040089BD RID: 35261
			IgnoreCosts
		}

		// Token: 0x0200096C RID: 2412
		[OriginalName("Assembly-CSharp.dll", "", "EStance")]
		public enum EStance
		{
			// Token: 0x040089BF RID: 35263
			None,
			// Token: 0x040089C0 RID: 35264
			Stanced
		}

		// Token: 0x0200096D RID: 2413
		[OriginalName("Assembly-CSharp.dll", "", "WalkResult")]
		public enum WalkResult
		{
			// Token: 0x040089C2 RID: 35266
			Failed,
			// Token: 0x040089C3 RID: 35267
			Interrupted,
			// Token: 0x040089C4 RID: 35268
			Stopped,
			// Token: 0x040089C5 RID: 35269
			Partial,
			// Token: 0x040089C6 RID: 35270
			Success
		}

		// Token: 0x0200096E RID: 2414
		[ObfuscatedName("ScheduleOne.NPCs.NPCMovement+<>c")]
		[System.Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x0600CB6C RID: 52076 RVA: 0x003186A4 File Offset: 0x003168A4
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<NPCMovement.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NPCMovement.__c>.NativeClassPtr);
				NPCMovement.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCMovement.__c>.NativeClassPtr, "<>9");
				NPCMovement.__c.NativeFieldInfoPtr___9__126_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCMovement.__c>.NativeClassPtr, "<>9__126_1");
				NPCMovement.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCMovement.__c>.NativeClassPtr, 100669661);
				NPCMovement.__c.NativeMethodInfoPtr__ApplyRagdollForce_b__126_1_Internal_Single___f__AnonymousType0_2_Rigidbody_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCMovement.__c>.NativeClassPtr, 100669662);
			}

			// Token: 0x0600CB6D RID: 52077 RVA: 0x00318720 File Offset: 0x00316920
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NPCMovement.__c>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCMovement.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600CB6E RID: 52078 RVA: 0x0031875C File Offset: 0x0031695C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 142315, XrefRangeEnd = 142316, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe float _ApplyRagdollForce_b__126_1(__f__AnonymousType0<Rigidbody, float> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NPCMovement.__c.NativeMethodInfoPtr__ApplyRagdollForce_b__126_1_Internal_Single___f__AnonymousType0_2_Rigidbody_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x0600CB6F RID: 52079 RVA: 0x00062B1E File Offset: 0x00060D1E
			public __c(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003F10 RID: 16144
			// (get) Token: 0x0600CB70 RID: 52080 RVA: 0x003187AC File Offset: 0x003169AC
			// (set) Token: 0x0600CB71 RID: 52081 RVA: 0x00062B27 File Offset: 0x00060D27
			public unsafe static NPCMovement.__c __9
			{
				get
				{
					System.IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(NPCMovement.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<NPCMovement.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(NPCMovement.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003F11 RID: 16145
			// (get) Token: 0x0600CB72 RID: 52082 RVA: 0x003187D4 File Offset: 0x003169D4
			// (set) Token: 0x0600CB73 RID: 52083 RVA: 0x00062B39 File Offset: 0x00060D39
			public unsafe static Il2CppSystem.Func<__f__AnonymousType0<Rigidbody, float>, float> __9__126_1
			{
				get
				{
					System.IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(NPCMovement.__c.NativeFieldInfoPtr___9__126_1, (void*)(&intPtr));
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Func<__f__AnonymousType0<Rigidbody, float>, float>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(NPCMovement.__c.NativeFieldInfoPtr___9__126_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040089C7 RID: 35271
			private static readonly System.IntPtr NativeFieldInfoPtr___9;

			// Token: 0x040089C8 RID: 35272
			private static readonly System.IntPtr NativeFieldInfoPtr___9__126_1;

			// Token: 0x040089C9 RID: 35273
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040089CA RID: 35274
			private static readonly System.IntPtr NativeMethodInfoPtr__ApplyRagdollForce_b__126_1_Internal_Single___f__AnonymousType0_2_Rigidbody_Single_0;
		}

		// Token: 0x0200096F RID: 2415
		[ObfuscatedName("ScheduleOne.NPCs.NPCMovement+<>c__DisplayClass126_0")]
		public sealed class __c__DisplayClass126_0 : Il2CppSystem.Object
		{
			// Token: 0x0600CB74 RID: 52084 RVA: 0x003187FC File Offset: 0x003169FC
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass126_0()
			{
				Il2CppClassPointerStore<NPCMovement.__c__DisplayClass126_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, "<>c__DisplayClass126_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NPCMovement.__c__DisplayClass126_0>.NativeClassPtr);
				NPCMovement.__c__DisplayClass126_0.NativeFieldInfoPtr_forcePoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCMovement.__c__DisplayClass126_0>.NativeClassPtr, "forcePoint");
				NPCMovement.__c__DisplayClass126_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCMovement.__c__DisplayClass126_0>.NativeClassPtr, 100669663);
				NPCMovement.__c__DisplayClass126_0.NativeMethodInfoPtr__ApplyRagdollForce_b__0_Internal___f__AnonymousType0_2_Rigidbody_Single_Rigidbody_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCMovement.__c__DisplayClass126_0>.NativeClassPtr, 100669664);
			}

			// Token: 0x0600CB75 RID: 52085 RVA: 0x00318864 File Offset: 0x00316A64
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass126_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NPCMovement.__c__DisplayClass126_0>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCMovement.__c__DisplayClass126_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600CB76 RID: 52086 RVA: 0x003188A0 File Offset: 0x00316AA0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 142316, XrefRangeEnd = 142329, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __f__AnonymousType0<Rigidbody, float> _ApplyRagdollForce_b__0(Rigidbody x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCMovement.__c__DisplayClass126_0.NativeMethodInfoPtr__ApplyRagdollForce_b__0_Internal___f__AnonymousType0_2_Rigidbody_Single_Rigidbody_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<__f__AnonymousType0<Rigidbody, float>>(intPtr2) : null;
			}

			// Token: 0x0600CB77 RID: 52087 RVA: 0x00062B4B File Offset: 0x00060D4B
			public __c__DisplayClass126_0(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003F12 RID: 16146
			// (get) Token: 0x0600CB78 RID: 52088 RVA: 0x003188F0 File Offset: 0x00316AF0
			// (set) Token: 0x0600CB79 RID: 52089 RVA: 0x00062B54 File Offset: 0x00060D54
			public unsafe Vector3 forcePoint
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement.__c__DisplayClass126_0.NativeFieldInfoPtr_forcePoint);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement.__c__DisplayClass126_0.NativeFieldInfoPtr_forcePoint)) = value;
				}
			}

			// Token: 0x040089CB RID: 35275
			private static readonly System.IntPtr NativeFieldInfoPtr_forcePoint;

			// Token: 0x040089CC RID: 35276
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040089CD RID: 35277
			private static readonly System.IntPtr NativeMethodInfoPtr__ApplyRagdollForce_b__0_Internal___f__AnonymousType0_2_Rigidbody_Single_Rigidbody_0;
		}

		// Token: 0x02000970 RID: 2416
		[ObfuscatedName("ScheduleOne.NPCs.NPCMovement+<FaceDirection_Process>d__139")]
		public sealed class _FaceDirection_Process_d__139 : Il2CppSystem.Object
		{
			// Token: 0x0600CB7A RID: 52090 RVA: 0x00318918 File Offset: 0x00316B18
			// Note: this type is marked as 'beforefieldinit'.
			static _FaceDirection_Process_d__139()
			{
				Il2CppClassPointerStore<NPCMovement._FaceDirection_Process_d__139>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NPCMovement>.NativeClassPtr, "<FaceDirection_Process>d__139");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NPCMovement._FaceDirection_Process_d__139>.NativeClassPtr);
				NPCMovement._FaceDirection_Process_d__139.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCMovement._FaceDirection_Process_d__139>.NativeClassPtr, "<>1__state");
				NPCMovement._FaceDirection_Process_d__139.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCMovement._FaceDirection_Process_d__139>.NativeClassPtr, "<>2__current");
				NPCMovement._FaceDirection_Process_d__139.NativeFieldInfoPtr_lerpTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCMovement._FaceDirection_Process_d__139>.NativeClassPtr, "lerpTime");
				NPCMovement._FaceDirection_Process_d__139.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCMovement._FaceDirection_Process_d__139>.NativeClassPtr, "<>4__this");
				NPCMovement._FaceDirection_Process_d__139.NativeFieldInfoPtr_forward = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCMovement._FaceDirection_Process_d__139>.NativeClassPtr, "forward");
				NPCMovement._FaceDirection_Process_d__139.NativeFieldInfoPtr__startRot_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCMovement._FaceDirection_Process_d__139>.NativeClassPtr, "<startRot>5__2");
				NPCMovement._FaceDirection_Process_d__139.NativeFieldInfoPtr__i_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCMovement._FaceDirection_Process_d__139>.NativeClassPtr, "<i>5__3");
				NPCMovement._FaceDirection_Process_d__139.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCMovement._FaceDirection_Process_d__139>.NativeClassPtr, 100669665);
				NPCMovement._FaceDirection_Process_d__139.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCMovement._FaceDirection_Process_d__139>.NativeClassPtr, 100669666);
				NPCMovement._FaceDirection_Process_d__139.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCMovement._FaceDirection_Process_d__139>.NativeClassPtr, 100669667);
				NPCMovement._FaceDirection_Process_d__139.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCMovement._FaceDirection_Process_d__139>.NativeClassPtr, 100669668);
				NPCMovement._FaceDirection_Process_d__139.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCMovement._FaceDirection_Process_d__139>.NativeClassPtr, 100669669);
				NPCMovement._FaceDirection_Process_d__139.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCMovement._FaceDirection_Process_d__139>.NativeClassPtr, 100669670);
			}

			// Token: 0x0600CB7B RID: 52091 RVA: 0x00318A48 File Offset: 0x00316C48
			[CallerCount(54)]
			[CachedScanResults(RefRangeStart = 2646, RefRangeEnd = 2700, XrefRangeStart = 2646, XrefRangeEnd = 2700, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _FaceDirection_Process_d__139(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NPCMovement._FaceDirection_Process_d__139>.NativeClassPtr))
			{
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = ref <>1__state;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCMovement._FaceDirection_Process_d__139.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600CB7C RID: 52092 RVA: 0x00318A90 File Offset: 0x00316C90
			[CallerCount(14558)]
			[CachedScanResults(RefRangeStart = 2769, RefRangeEnd = 17327, XrefRangeStart = 2769, XrefRangeEnd = 17327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCMovement._FaceDirection_Process_d__139.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600CB7D RID: 52093 RVA: 0x00318AC4 File Offset: 0x00316CC4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 142329, XrefRangeEnd = 142351, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NPCMovement._FaceDirection_Process_d__139.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x17003F1A RID: 16154
			// (get) Token: 0x0600CB7E RID: 52094 RVA: 0x00318B00 File Offset: 0x00316D00
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 2740, RefRangeEnd = 2764, XrefRangeStart = 2740, XrefRangeEnd = 2764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCMovement._FaceDirection_Process_d__139.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
			}

			// Token: 0x0600CB7F RID: 52095 RVA: 0x00318B40 File Offset: 0x00316D40
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 142351, XrefRangeEnd = 142356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCMovement._FaceDirection_Process_d__139.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x17003F1B RID: 16155
			// (get) Token: 0x0600CB80 RID: 52096 RVA: 0x00318B74 File Offset: 0x00316D74
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 2740, RefRangeEnd = 2764, XrefRangeStart = 2740, XrefRangeEnd = 2764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCMovement._FaceDirection_Process_d__139.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
			}

			// Token: 0x0600CB81 RID: 52097 RVA: 0x00062B6F File Offset: 0x00060D6F
			public _FaceDirection_Process_d__139(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003F13 RID: 16147
			// (get) Token: 0x0600CB82 RID: 52098 RVA: 0x00318BB4 File Offset: 0x00316DB4
			// (set) Token: 0x0600CB83 RID: 52099 RVA: 0x00062B78 File Offset: 0x00060D78
			public unsafe int __1__state
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement._FaceDirection_Process_d__139.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement._FaceDirection_Process_d__139.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17003F14 RID: 16148
			// (get) Token: 0x0600CB84 RID: 52100 RVA: 0x00318BDC File Offset: 0x00316DDC
			// (set) Token: 0x0600CB85 RID: 52101 RVA: 0x00062B93 File Offset: 0x00060D93
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement._FaceDirection_Process_d__139.NativeFieldInfoPtr___2__current);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement._FaceDirection_Process_d__139.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003F15 RID: 16149
			// (get) Token: 0x0600CB86 RID: 52102 RVA: 0x00318C0C File Offset: 0x00316E0C
			// (set) Token: 0x0600CB87 RID: 52103 RVA: 0x00062BB2 File Offset: 0x00060DB2
			public unsafe float lerpTime
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement._FaceDirection_Process_d__139.NativeFieldInfoPtr_lerpTime);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement._FaceDirection_Process_d__139.NativeFieldInfoPtr_lerpTime)) = value;
				}
			}

			// Token: 0x17003F16 RID: 16150
			// (get) Token: 0x0600CB88 RID: 52104 RVA: 0x00318C34 File Offset: 0x00316E34
			// (set) Token: 0x0600CB89 RID: 52105 RVA: 0x00062BCD File Offset: 0x00060DCD
			public unsafe NPCMovement __4__this
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement._FaceDirection_Process_d__139.NativeFieldInfoPtr___4__this);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<NPCMovement>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement._FaceDirection_Process_d__139.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003F17 RID: 16151
			// (get) Token: 0x0600CB8A RID: 52106 RVA: 0x00318C64 File Offset: 0x00316E64
			// (set) Token: 0x0600CB8B RID: 52107 RVA: 0x00062BEC File Offset: 0x00060DEC
			public unsafe Vector3 forward
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement._FaceDirection_Process_d__139.NativeFieldInfoPtr_forward);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement._FaceDirection_Process_d__139.NativeFieldInfoPtr_forward)) = value;
				}
			}

			// Token: 0x17003F18 RID: 16152
			// (get) Token: 0x0600CB8C RID: 52108 RVA: 0x00318C8C File Offset: 0x00316E8C
			// (set) Token: 0x0600CB8D RID: 52109 RVA: 0x00062C07 File Offset: 0x00060E07
			public unsafe Quaternion _startRot_5__2
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement._FaceDirection_Process_d__139.NativeFieldInfoPtr__startRot_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement._FaceDirection_Process_d__139.NativeFieldInfoPtr__startRot_5__2)) = value;
				}
			}

			// Token: 0x17003F19 RID: 16153
			// (get) Token: 0x0600CB8E RID: 52110 RVA: 0x00318CB4 File Offset: 0x00316EB4
			// (set) Token: 0x0600CB8F RID: 52111 RVA: 0x00062C22 File Offset: 0x00060E22
			public unsafe float _i_5__3
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement._FaceDirection_Process_d__139.NativeFieldInfoPtr__i_5__3);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NPCMovement._FaceDirection_Process_d__139.NativeFieldInfoPtr__i_5__3)) = value;
				}
			}

			// Token: 0x040089CE RID: 35278
			private static readonly System.IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040089CF RID: 35279
			private static readonly System.IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040089D0 RID: 35280
			private static readonly System.IntPtr NativeFieldInfoPtr_lerpTime;

			// Token: 0x040089D1 RID: 35281
			private static readonly System.IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040089D2 RID: 35282
			private static readonly System.IntPtr NativeFieldInfoPtr_forward;

			// Token: 0x040089D3 RID: 35283
			private static readonly System.IntPtr NativeFieldInfoPtr__startRot_5__2;

			// Token: 0x040089D4 RID: 35284
			private static readonly System.IntPtr NativeFieldInfoPtr__i_5__3;

			// Token: 0x040089D5 RID: 35285
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040089D6 RID: 35286
			private static readonly System.IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040089D7 RID: 35287
			private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040089D8 RID: 35288
			private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040089D9 RID: 35289
			private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040089DA RID: 35290
			private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
