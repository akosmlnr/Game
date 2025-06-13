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
using Il2CppScheduleOne.DevUtilities;
using Il2CppScheduleOne.PlayerScripts;
using Il2CppScheduleOne.Tools;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace Il2CppScheduleOne.Skating
{
	// Token: 0x020001AF RID: 431
	public class Skateboard : NetworkBehaviour
	{
		// Token: 0x060022E3 RID: 8931 RVA: 0x000E0904 File Offset: 0x000DEB04
		// Note: this type is marked as 'beforefieldinit'.
		static Skateboard()
		{
			Il2CppClassPointerStore<Skateboard>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Skating", "Skateboard");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Skateboard>.NativeClassPtr);
			Skateboard.NativeFieldInfoPtr_GroundedRaycastDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, "GroundedRaycastDistance");
			Skateboard.NativeFieldInfoPtr_JumpCooldown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, "JumpCooldown");
			Skateboard.NativeFieldInfoPtr_JumpForceMin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, "JumpForceMin");
			Skateboard.NativeFieldInfoPtr_JumpForceBuildTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, "JumpForceBuildTime");
			Skateboard.NativeFieldInfoPtr_PushCooldown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, "PushCooldown");
			Skateboard.NativeFieldInfoPtr_PushStaminaConsumption = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, "PushStaminaConsumption");
			Skateboard.NativeFieldInfoPtr_PitchLimit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, "PitchLimit");
			Skateboard.NativeFieldInfoPtr_RollLimit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, "RollLimit");
			Skateboard.NativeFieldInfoPtr_CurrentSpeed_Kmh = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, "CurrentSpeed_Kmh");
			Skateboard.NativeFieldInfoPtr__CurrentSteerInput_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, "<CurrentSteerInput>k__BackingField");
			Skateboard.NativeFieldInfoPtr__JumpBuildAmount_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, "<JumpBuildAmount>k__BackingField");
			Skateboard.NativeFieldInfoPtr__Rider_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, "<Rider>k__BackingField");
			Skateboard.NativeFieldInfoPtr_Rb = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, "Rb");
			Skateboard.NativeFieldInfoPtr_CoM = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, "CoM");
			Skateboard.NativeFieldInfoPtr_HoverPoints = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, "HoverPoints");
			Skateboard.NativeFieldInfoPtr_FrontAxlePosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, "FrontAxlePosition");
			Skateboard.NativeFieldInfoPtr_RearAxlePosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, "RearAxlePosition");
			Skateboard.NativeFieldInfoPtr_PlayerContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, "PlayerContainer");
			Skateboard.NativeFieldInfoPtr_Animation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, "Animation");
			Skateboard.NativeFieldInfoPtr_VelocityCalculator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, "VelocityCalculator");
			Skateboard.NativeFieldInfoPtr_Accelerometer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, "Accelerometer");
			Skateboard.NativeFieldInfoPtr_Equippable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, "Equippable");
			Skateboard.NativeFieldInfoPtr_IKAlignmentsContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, "IKAlignmentsContainer");
			Skateboard.NativeFieldInfoPtr_TurnForce = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, "TurnForce");
			Skateboard.NativeFieldInfoPtr_TurnChangeRate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, "TurnChangeRate");
			Skateboard.NativeFieldInfoPtr_TurnReturnToRestRate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, "TurnReturnToRestRate");
			Skateboard.NativeFieldInfoPtr_TurnSpeedBoost = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, "TurnSpeedBoost");
			Skateboard.NativeFieldInfoPtr_TurnForceMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, "TurnForceMap");
			Skateboard.NativeFieldInfoPtr_Gravity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, "Gravity");
			Skateboard.NativeFieldInfoPtr_BrakeForce = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, "BrakeForce");
			Skateboard.NativeFieldInfoPtr_ReverseTopSpeed_Kmh = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, "ReverseTopSpeed_Kmh");
			Skateboard.NativeFieldInfoPtr_GroundDetectionMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, "GroundDetectionMask");
			Skateboard.NativeFieldInfoPtr_MainColliders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, "MainColliders");
			Skateboard.NativeFieldInfoPtr_RotationClampForce = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, "RotationClampForce");
			Skateboard.NativeFieldInfoPtr_FrictionEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, "FrictionEnabled");
			Skateboard.NativeFieldInfoPtr_LongitudinalFrictionCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, "LongitudinalFrictionCurve");
			Skateboard.NativeFieldInfoPtr_LongitudinalFrictionMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, "LongitudinalFrictionMultiplier");
			Skateboard.NativeFieldInfoPtr_LateralFrictionForceMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, "LateralFrictionForceMultiplier");
			Skateboard.NativeFieldInfoPtr_JumpForce = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, "JumpForce");
			Skateboard.NativeFieldInfoPtr_JumpDuration_Min = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, "JumpDuration_Min");
			Skateboard.NativeFieldInfoPtr_JumpDuration_Max = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, "JumpDuration_Max");
			Skateboard.NativeFieldInfoPtr_FrontAxleJumpCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, "FrontAxleJumpCurve");
			Skateboard.NativeFieldInfoPtr_RearAxleJumpCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, "RearAxleJumpCurve");
			Skateboard.NativeFieldInfoPtr_JumpForwardForceCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, "JumpForwardForceCurve");
			Skateboard.NativeFieldInfoPtr_JumpForwardBoost = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, "JumpForwardBoost");
			Skateboard.NativeFieldInfoPtr_HoverForce = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, "HoverForce");
			Skateboard.NativeFieldInfoPtr_HoverRayLength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, "HoverRayLength");
			Skateboard.NativeFieldInfoPtr_HoverHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, "HoverHeight");
			Skateboard.NativeFieldInfoPtr_Hover_P = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, "Hover_P");
			Skateboard.NativeFieldInfoPtr_Hover_I = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, "Hover_I");
			Skateboard.NativeFieldInfoPtr_Hover_D = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, "Hover_D");
			Skateboard.NativeFieldInfoPtr_TopSpeed_Kmh = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, "TopSpeed_Kmh");
			Skateboard.NativeFieldInfoPtr_PushForceMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, "PushForceMultiplier");
			Skateboard.NativeFieldInfoPtr_PushForceMultiplierMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, "PushForceMultiplierMap");
			Skateboard.NativeFieldInfoPtr_PushForceDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, "PushForceDuration");
			Skateboard.NativeFieldInfoPtr_PushDelay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, "PushDelay");
			Skateboard.NativeFieldInfoPtr_PushForceCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, "PushForceCurve");
			Skateboard.NativeFieldInfoPtr_AirMovementEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, "AirMovementEnabled");
			Skateboard.NativeFieldInfoPtr_AirMovementForce = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, "AirMovementForce");
			Skateboard.NativeFieldInfoPtr_AirMovementJumpReductionDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, "AirMovementJumpReductionDuration");
			Skateboard.NativeFieldInfoPtr_AirMovementJumpReductionCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, "AirMovementJumpReductionCurve");
			Skateboard.NativeFieldInfoPtr_OnPushStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, "OnPushStart");
			Skateboard.NativeFieldInfoPtr_OnJump = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, "OnJump");
			Skateboard.NativeFieldInfoPtr_OnLand = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, "OnLand");
			Skateboard.NativeFieldInfoPtr_horizontalInput = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, "horizontalInput");
			Skateboard.NativeFieldInfoPtr_jumpReleased = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, "jumpReleased");
			Skateboard.NativeFieldInfoPtr_timeSinceLastJump = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, "timeSinceLastJump");
			Skateboard.NativeFieldInfoPtr_timeGrounded = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, "timeGrounded");
			Skateboard.NativeFieldInfoPtr_timeAirborne = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, "timeAirborne");
			Skateboard.NativeFieldInfoPtr_jumpHeldTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, "jumpHeldTime");
			Skateboard.NativeFieldInfoPtr_frontAxleForce = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, "frontAxleForce");
			Skateboard.NativeFieldInfoPtr_rearAxleForce = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, "rearAxleForce");
			Skateboard.NativeFieldInfoPtr_jumpForwardForce = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, "jumpForwardForce");
			Skateboard.NativeFieldInfoPtr_hoverPIDs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, "hoverPIDs");
			Skateboard.NativeFieldInfoPtr_pushQueued = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, "pushQueued");
			Skateboard.NativeFieldInfoPtr_isPushing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, "isPushing");
			Skateboard.NativeFieldInfoPtr_thisFramePushForce = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, "thisFramePushForce");
			Skateboard.NativeFieldInfoPtr_timeSincePushStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, "timeSincePushStart");
			Skateboard.NativeFieldInfoPtr_braking = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, "braking");
			Skateboard.NativeFieldInfoPtr_syncVar____JumpBuildAmount_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, "syncVar___<JumpBuildAmount>k__BackingField");
			Skateboard.NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, "NetworkInitialize___EarlyScheduleOne.Skating.SkateboardAssembly-CSharp.dll_Excuted");
			Skateboard.NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, "NetworkInitialize__LateScheduleOne.Skating.SkateboardAssembly-CSharp.dll_Excuted");
			Skateboard.NativeMethodInfoPtr_get_CurrentSteerInput_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, 100667276);
			Skateboard.NativeMethodInfoPtr_set_CurrentSteerInput_Protected_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, 100667277);
			Skateboard.NativeMethodInfoPtr_get_IsPushing_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, 100667278);
			Skateboard.NativeMethodInfoPtr_get_TimeSincePushStart_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, 100667279);
			Skateboard.NativeMethodInfoPtr_get_isGrounded_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, 100667280);
			Skateboard.NativeMethodInfoPtr_get_AirTime_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, 100667281);
			Skateboard.NativeMethodInfoPtr_get_JumpBuildAmount_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, 100667282);
			Skateboard.NativeMethodInfoPtr_set_JumpBuildAmount_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, 100667283);
			Skateboard.NativeMethodInfoPtr_get_Rider_Public_get_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, 100667284);
			Skateboard.NativeMethodInfoPtr_set_Rider_Private_set_Void_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, 100667285);
			Skateboard.NativeMethodInfoPtr_get_TopSpeed_Ms_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, 100667286);
			Skateboard.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, 100667287);
			Skateboard.NativeMethodInfoPtr_OnStartClient_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, 100667288);
			Skateboard.NativeMethodInfoPtr_Update_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, 100667289);
			Skateboard.NativeMethodInfoPtr_GetInput_Private_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, 100667290);
			Skateboard.NativeMethodInfoPtr_FixedUpdate_Private_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, 100667291);
			Skateboard.NativeMethodInfoPtr_LateUpdate_Private_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, 100667292);
			Skateboard.NativeMethodInfoPtr_ApplyInput_Private_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, 100667293);
			Skateboard.NativeMethodInfoPtr_ApplyLateralFriction_Private_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, 100667294);
			Skateboard.NativeMethodInfoPtr_UpdateHover_Private_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, 100667295);
			Skateboard.NativeMethodInfoPtr_ApplyGravity_Private_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, 100667296);
			Skateboard.NativeMethodInfoPtr_CheckGrounded_Private_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, 100667297);
			Skateboard.NativeMethodInfoPtr_CheckJump_Private_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, 100667298);
			Skateboard.NativeMethodInfoPtr_SendJump_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, 100667299);
			Skateboard.NativeMethodInfoPtr_ReceiveJump_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, 100667300);
			Skateboard.NativeMethodInfoPtr_Jump_Private_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, 100667301);
			Skateboard.NativeMethodInfoPtr_Push_Private_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, 100667302);
			Skateboard.NativeMethodInfoPtr_IsGrounded_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, 100667303);
			Skateboard.NativeMethodInfoPtr_IsGrounded_Public_Boolean_byref_RaycastHit_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, 100667304);
			Skateboard.NativeMethodInfoPtr_SetVelocity_Public_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, 100667305);
			Skateboard.NativeMethodInfoPtr_ClampRotation_Private_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, 100667306);
			Skateboard.NativeMethodInfoPtr_ApplyPlayerScale_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, 100667307);
			Skateboard.NativeMethodInfoPtr_GetSurfaceSmoothness_Public_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, 100667308);
			Skateboard.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, 100667309);
			Skateboard.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, 100667310);
			Skateboard.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, 100667311);
			Skateboard.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, 100667312);
			Skateboard.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, 100667313);
			Skateboard.NativeMethodInfoPtr_RpcWriter___Server_set_JumpBuildAmount_431000436_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, 100667314);
			Skateboard.NativeMethodInfoPtr_RpcLogic___set_JumpBuildAmount_431000436_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, 100667315);
			Skateboard.NativeMethodInfoPtr_RpcReader___Server_set_JumpBuildAmount_431000436_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, 100667316);
			Skateboard.NativeMethodInfoPtr_RpcWriter___Server_SendJump_431000436_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, 100667317);
			Skateboard.NativeMethodInfoPtr_RpcLogic___SendJump_431000436_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, 100667318);
			Skateboard.NativeMethodInfoPtr_RpcReader___Server_SendJump_431000436_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, 100667319);
			Skateboard.NativeMethodInfoPtr_RpcWriter___Observers_ReceiveJump_431000436_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, 100667320);
			Skateboard.NativeMethodInfoPtr_RpcLogic___ReceiveJump_431000436_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, 100667321);
			Skateboard.NativeMethodInfoPtr_RpcReader___Observers_ReceiveJump_431000436_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, 100667322);
			Skateboard.NativeMethodInfoPtr_sync___get_value__JumpBuildAmount_k__BackingField_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, 100667323);
			Skateboard.NativeMethodInfoPtr_sync___set_value__JumpBuildAmount_k__BackingField_Public_set_Void_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, 100667324);
			Skateboard.NativeMethodInfoPtr_ReadSyncVar___ScheduleOne_Skating_Skateboard_Public_Virtual_Boolean_PooledReader_UInt32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, 100667325);
			Skateboard.NativeMethodInfoPtr_Method_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, 100667326);
		}

		// Token: 0x17000C2B RID: 3115
		// (get) Token: 0x060022E4 RID: 8932 RVA: 0x000E1398 File Offset: 0x000DF598
		// (set) Token: 0x060022E5 RID: 8933 RVA: 0x000E13D4 File Offset: 0x000DF5D4
		public unsafe float CurrentSteerInput
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 89901, RefRangeEnd = 89903, XrefRangeStart = 89901, XrefRangeEnd = 89903, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Skateboard.NativeMethodInfoPtr_get_CurrentSteerInput_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
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
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Skateboard.NativeMethodInfoPtr_set_CurrentSteerInput_Protected_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x17000C2C RID: 3116
		// (get) Token: 0x060022E6 RID: 8934 RVA: 0x000E1414 File Offset: 0x000DF614
		public unsafe bool IsPushing
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Skateboard.NativeMethodInfoPtr_get_IsPushing_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
		}

		// Token: 0x17000C2D RID: 3117
		// (get) Token: 0x060022E7 RID: 8935 RVA: 0x000E1450 File Offset: 0x000DF650
		public unsafe float TimeSincePushStart
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Skateboard.NativeMethodInfoPtr_get_TimeSincePushStart_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
		}

		// Token: 0x17000C2E RID: 3118
		// (get) Token: 0x060022E8 RID: 8936 RVA: 0x000E148C File Offset: 0x000DF68C
		public unsafe bool isGrounded
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Skateboard.NativeMethodInfoPtr_get_isGrounded_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
		}

		// Token: 0x17000C2F RID: 3119
		// (get) Token: 0x060022E9 RID: 8937 RVA: 0x000E14C8 File Offset: 0x000DF6C8
		public unsafe float AirTime
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Skateboard.NativeMethodInfoPtr_get_AirTime_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
		}

		// Token: 0x17000C30 RID: 3120
		// (get) Token: 0x060022EA RID: 8938 RVA: 0x000E1504 File Offset: 0x000DF704
		// (set) Token: 0x060022EB RID: 8939 RVA: 0x000E1540 File Offset: 0x000DF740
		public unsafe float JumpBuildAmount
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Skateboard.NativeMethodInfoPtr_get_JumpBuildAmount_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 115269, XrefRangeEnd = 115281, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = ref value;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Skateboard.NativeMethodInfoPtr_set_JumpBuildAmount_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x17000C31 RID: 3121
		// (get) Token: 0x060022EC RID: 8940 RVA: 0x000E1580 File Offset: 0x000DF780
		// (set) Token: 0x060022ED RID: 8941 RVA: 0x000E15C0 File Offset: 0x000DF7C0
		public unsafe Player Rider
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Skateboard.NativeMethodInfoPtr_get_Rider_Public_get_Player_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Player>(intPtr2) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Skateboard.NativeMethodInfoPtr_set_Rider_Private_set_Void_Player_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x17000C32 RID: 3122
		// (get) Token: 0x060022EE RID: 8942 RVA: 0x000E1604 File Offset: 0x000DF804
		public unsafe float TopSpeed_Ms
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Skateboard.NativeMethodInfoPtr_get_TopSpeed_Ms_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
		}

		// Token: 0x060022EF RID: 8943 RVA: 0x000E1640 File Offset: 0x000DF840
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 115281, XrefRangeEnd = 115282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Skateboard.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060022F0 RID: 8944 RVA: 0x000E167C File Offset: 0x000DF87C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 115282, XrefRangeEnd = 115295, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnStartClient()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Skateboard.NativeMethodInfoPtr_OnStartClient_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060022F1 RID: 8945 RVA: 0x000E16B8 File Offset: 0x000DF8B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 115295, XrefRangeEnd = 115298, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Skateboard.NativeMethodInfoPtr_Update_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060022F2 RID: 8946 RVA: 0x000E16EC File Offset: 0x000DF8EC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 115373, RefRangeEnd = 115374, XrefRangeStart = 115298, XrefRangeEnd = 115373, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GetInput()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Skateboard.NativeMethodInfoPtr_GetInput_Private_Void_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060022F3 RID: 8947 RVA: 0x000E1720 File Offset: 0x000DF920
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 115374, XrefRangeEnd = 115392, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FixedUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Skateboard.NativeMethodInfoPtr_FixedUpdate_Private_Void_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060022F4 RID: 8948 RVA: 0x000E1754 File Offset: 0x000DF954
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 115392, XrefRangeEnd = 115394, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LateUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Skateboard.NativeMethodInfoPtr_LateUpdate_Private_Void_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060022F5 RID: 8949 RVA: 0x000E1788 File Offset: 0x000DF988
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 115444, RefRangeEnd = 115445, XrefRangeStart = 115394, XrefRangeEnd = 115444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ApplyInput()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Skateboard.NativeMethodInfoPtr_ApplyInput_Private_Void_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060022F6 RID: 8950 RVA: 0x000E17BC File Offset: 0x000DF9BC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 115472, RefRangeEnd = 115473, XrefRangeStart = 115445, XrefRangeEnd = 115472, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ApplyLateralFriction()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Skateboard.NativeMethodInfoPtr_ApplyLateralFriction_Private_Void_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060022F7 RID: 8951 RVA: 0x000E17F0 File Offset: 0x000DF9F0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 115518, RefRangeEnd = 115519, XrefRangeStart = 115473, XrefRangeEnd = 115518, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateHover()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Skateboard.NativeMethodInfoPtr_UpdateHover_Private_Void_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060022F8 RID: 8952 RVA: 0x000E1824 File Offset: 0x000DFA24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 115519, XrefRangeEnd = 115531, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ApplyGravity()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Skateboard.NativeMethodInfoPtr_ApplyGravity_Private_Void_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060022F9 RID: 8953 RVA: 0x000E1858 File Offset: 0x000DFA58
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 115533, RefRangeEnd = 115534, XrefRangeStart = 115531, XrefRangeEnd = 115533, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CheckGrounded()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Skateboard.NativeMethodInfoPtr_CheckGrounded_Private_Void_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060022FA RID: 8954 RVA: 0x000E188C File Offset: 0x000DFA8C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 115565, RefRangeEnd = 115566, XrefRangeStart = 115534, XrefRangeEnd = 115565, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CheckJump()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Skateboard.NativeMethodInfoPtr_CheckJump_Private_Void_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060022FB RID: 8955 RVA: 0x000E18C0 File Offset: 0x000DFAC0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 115599, RefRangeEnd = 115601, XrefRangeStart = 115566, XrefRangeEnd = 115599, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendJump(float jumpHeldTime)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref jumpHeldTime;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Skateboard.NativeMethodInfoPtr_SendJump_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060022FC RID: 8956 RVA: 0x000E1900 File Offset: 0x000DFB00
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 115623, RefRangeEnd = 115625, XrefRangeStart = 115601, XrefRangeEnd = 115623, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReceiveJump(float _jumpHeldTime)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref _jumpHeldTime;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Skateboard.NativeMethodInfoPtr_ReceiveJump_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060022FD RID: 8957 RVA: 0x000E1940 File Offset: 0x000DFB40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 115625, XrefRangeEnd = 115640, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Jump()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Skateboard.NativeMethodInfoPtr_Jump_Private_Void_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060022FE RID: 8958 RVA: 0x000E1974 File Offset: 0x000DFB74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 115640, XrefRangeEnd = 115647, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Push()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Skateboard.NativeMethodInfoPtr_Push_Private_Void_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060022FF RID: 8959 RVA: 0x000E19A8 File Offset: 0x000DFBA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 115647, XrefRangeEnd = 115648, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsGrounded()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Skateboard.NativeMethodInfoPtr_IsGrounded_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06002300 RID: 8960 RVA: 0x000E19E4 File Offset: 0x000DFBE4
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 115667, RefRangeEnd = 115672, XrefRangeStart = 115648, XrefRangeEnd = 115667, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsGrounded(out RaycastHit hit)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = &hit;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Skateboard.NativeMethodInfoPtr_IsGrounded_Public_Boolean_byref_RaycastHit_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06002301 RID: 8961 RVA: 0x000E1A30 File Offset: 0x000DFC30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 115672, XrefRangeEnd = 115674, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetVelocity(Vector3 velocity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref velocity;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Skateboard.NativeMethodInfoPtr_SetVelocity_Public_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06002302 RID: 8962 RVA: 0x000E1A70 File Offset: 0x000DFC70
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 115707, RefRangeEnd = 115708, XrefRangeStart = 115674, XrefRangeEnd = 115707, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ClampRotation()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Skateboard.NativeMethodInfoPtr_ClampRotation_Private_Void_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06002303 RID: 8963 RVA: 0x000E1AA4 File Offset: 0x000DFCA4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 115715, RefRangeEnd = 115717, XrefRangeStart = 115708, XrefRangeEnd = 115715, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ApplyPlayerScale()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Skateboard.NativeMethodInfoPtr_ApplyPlayerScale_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06002304 RID: 8964 RVA: 0x000E1AD8 File Offset: 0x000DFCD8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 115717, XrefRangeEnd = 115724, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float GetSurfaceSmoothness()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Skateboard.NativeMethodInfoPtr_GetSurfaceSmoothness_Public_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06002305 RID: 8965 RVA: 0x000E1B14 File Offset: 0x000DFD14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 115724, XrefRangeEnd = 115732, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Skateboard() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Skateboard>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Skateboard.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06002306 RID: 8966 RVA: 0x000E1B50 File Offset: 0x000DFD50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 115732, XrefRangeEnd = 115737, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator Method_Private_IEnumerator_PDM_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Skateboard.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr2) : null;
		}

		// Token: 0x06002307 RID: 8967 RVA: 0x000E1B90 File Offset: 0x000DFD90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 115737, XrefRangeEnd = 115773, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void NetworkInitialize___Early()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Skateboard.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06002308 RID: 8968 RVA: 0x000E1BCC File Offset: 0x000DFDCC
		[CallerCount(0)]
		public unsafe virtual void NetworkInitialize__Late()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Skateboard.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06002309 RID: 8969 RVA: 0x000E1C08 File Offset: 0x000DFE08
		[CallerCount(0)]
		public unsafe override void NetworkInitializeIfDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Skateboard.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600230A RID: 8970 RVA: 0x000E1C44 File Offset: 0x000DFE44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_set_JumpBuildAmount_431000436(float value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref value;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Skateboard.NativeMethodInfoPtr_RpcWriter___Server_set_JumpBuildAmount_431000436_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600230B RID: 8971 RVA: 0x000E1C84 File Offset: 0x000DFE84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 115773, XrefRangeEnd = 115780, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___set_JumpBuildAmount_431000436(float value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref value;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Skateboard.NativeMethodInfoPtr_RpcLogic___set_JumpBuildAmount_431000436_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600230C RID: 8972 RVA: 0x000E1CC4 File Offset: 0x000DFEC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 115780, XrefRangeEnd = 115790, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_set_JumpBuildAmount_431000436(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref channel;
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Skateboard.NativeMethodInfoPtr_RpcReader___Server_set_JumpBuildAmount_431000436_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600230D RID: 8973 RVA: 0x000E1D28 File Offset: 0x000DFF28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 115790, XrefRangeEnd = 115802, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_SendJump_431000436(float jumpHeldTime)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref jumpHeldTime;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Skateboard.NativeMethodInfoPtr_RpcWriter___Server_SendJump_431000436_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600230E RID: 8974 RVA: 0x000E1D68 File Offset: 0x000DFF68
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 115623, RefRangeEnd = 115625, XrefRangeStart = 115623, XrefRangeEnd = 115625, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SendJump_431000436(float jumpHeldTime)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref jumpHeldTime;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Skateboard.NativeMethodInfoPtr_RpcLogic___SendJump_431000436_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600230F RID: 8975 RVA: 0x000E1DA8 File Offset: 0x000DFFA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 115802, XrefRangeEnd = 115807, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_SendJump_431000436(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref channel;
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Skateboard.NativeMethodInfoPtr_RpcReader___Server_SendJump_431000436_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06002310 RID: 8976 RVA: 0x000E1E0C File Offset: 0x000E000C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 115807, XrefRangeEnd = 115817, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_ReceiveJump_431000436(float _jumpHeldTime)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref _jumpHeldTime;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Skateboard.NativeMethodInfoPtr_RpcWriter___Observers_ReceiveJump_431000436_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06002311 RID: 8977 RVA: 0x000E1E4C File Offset: 0x000E004C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 115821, RefRangeEnd = 115824, XrefRangeStart = 115817, XrefRangeEnd = 115821, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___ReceiveJump_431000436(float _jumpHeldTime)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref _jumpHeldTime;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Skateboard.NativeMethodInfoPtr_RpcLogic___ReceiveJump_431000436_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06002312 RID: 8978 RVA: 0x000E1E8C File Offset: 0x000E008C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 115824, XrefRangeEnd = 115828, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_ReceiveJump_431000436(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref channel;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Skateboard.NativeMethodInfoPtr_RpcReader___Observers_ReceiveJump_431000436_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x17000C33 RID: 3123
		// (get) Token: 0x06002313 RID: 8979 RVA: 0x000E1EDC File Offset: 0x000E00DC
		// (set) Token: 0x06002314 RID: 8980 RVA: 0x000E1F18 File Offset: 0x000E0118
		public unsafe float SyncAccessor_<JumpBuildAmount>k__BackingField
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Skateboard.NativeMethodInfoPtr_sync___get_value__JumpBuildAmount_k__BackingField_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 115828, XrefRangeEnd = 115836, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = ref value;
				ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref value;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Skateboard.NativeMethodInfoPtr_sync___set_value__JumpBuildAmount_k__BackingField_Public_set_Void_Single_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x06002315 RID: 8981 RVA: 0x000E1F64 File Offset: 0x000E0164
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 115836, XrefRangeEnd = 115837, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool ReadSyncVar___ScheduleOne_Skating_Skateboard(PooledReader PooledReader0, uint UInt321, bool Boolean2)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref UInt321;
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref Boolean2;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Skateboard.NativeMethodInfoPtr_ReadSyncVar___ScheduleOne_Skating_Skateboard_Public_Virtual_Boolean_PooledReader_UInt32_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06002316 RID: 8982 RVA: 0x000E1FD8 File Offset: 0x000E01D8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 115861, RefRangeEnd = 115862, XrefRangeStart = 115837, XrefRangeEnd = 115861, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Method_Private_Void_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Skateboard.NativeMethodInfoPtr_Method_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06002317 RID: 8983 RVA: 0x000135AE File Offset: 0x000117AE
		public Skateboard(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000BD9 RID: 3033
		// (get) Token: 0x06002318 RID: 8984 RVA: 0x000E200C File Offset: 0x000E020C
		// (set) Token: 0x06002319 RID: 8985 RVA: 0x000135B7 File Offset: 0x000117B7
		public unsafe static float GroundedRaycastDistance
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(Skateboard.NativeFieldInfoPtr_GroundedRaycastDistance, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Skateboard.NativeFieldInfoPtr_GroundedRaycastDistance, (void*)(&value));
			}
		}

		// Token: 0x17000BDA RID: 3034
		// (get) Token: 0x0600231A RID: 8986 RVA: 0x000E2028 File Offset: 0x000E0228
		// (set) Token: 0x0600231B RID: 8987 RVA: 0x000135C5 File Offset: 0x000117C5
		public unsafe static float JumpCooldown
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(Skateboard.NativeFieldInfoPtr_JumpCooldown, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Skateboard.NativeFieldInfoPtr_JumpCooldown, (void*)(&value));
			}
		}

		// Token: 0x17000BDB RID: 3035
		// (get) Token: 0x0600231C RID: 8988 RVA: 0x000E2044 File Offset: 0x000E0244
		// (set) Token: 0x0600231D RID: 8989 RVA: 0x000135D3 File Offset: 0x000117D3
		public unsafe static float JumpForceMin
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(Skateboard.NativeFieldInfoPtr_JumpForceMin, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Skateboard.NativeFieldInfoPtr_JumpForceMin, (void*)(&value));
			}
		}

		// Token: 0x17000BDC RID: 3036
		// (get) Token: 0x0600231E RID: 8990 RVA: 0x000E2060 File Offset: 0x000E0260
		// (set) Token: 0x0600231F RID: 8991 RVA: 0x000135E1 File Offset: 0x000117E1
		public unsafe static float JumpForceBuildTime
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(Skateboard.NativeFieldInfoPtr_JumpForceBuildTime, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Skateboard.NativeFieldInfoPtr_JumpForceBuildTime, (void*)(&value));
			}
		}

		// Token: 0x17000BDD RID: 3037
		// (get) Token: 0x06002320 RID: 8992 RVA: 0x000E207C File Offset: 0x000E027C
		// (set) Token: 0x06002321 RID: 8993 RVA: 0x000135EF File Offset: 0x000117EF
		public unsafe static float PushCooldown
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(Skateboard.NativeFieldInfoPtr_PushCooldown, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Skateboard.NativeFieldInfoPtr_PushCooldown, (void*)(&value));
			}
		}

		// Token: 0x17000BDE RID: 3038
		// (get) Token: 0x06002322 RID: 8994 RVA: 0x000E2098 File Offset: 0x000E0298
		// (set) Token: 0x06002323 RID: 8995 RVA: 0x000135FD File Offset: 0x000117FD
		public unsafe static float PushStaminaConsumption
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(Skateboard.NativeFieldInfoPtr_PushStaminaConsumption, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Skateboard.NativeFieldInfoPtr_PushStaminaConsumption, (void*)(&value));
			}
		}

		// Token: 0x17000BDF RID: 3039
		// (get) Token: 0x06002324 RID: 8996 RVA: 0x000E20B4 File Offset: 0x000E02B4
		// (set) Token: 0x06002325 RID: 8997 RVA: 0x0001360B File Offset: 0x0001180B
		public unsafe static float PitchLimit
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(Skateboard.NativeFieldInfoPtr_PitchLimit, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Skateboard.NativeFieldInfoPtr_PitchLimit, (void*)(&value));
			}
		}

		// Token: 0x17000BE0 RID: 3040
		// (get) Token: 0x06002326 RID: 8998 RVA: 0x000E20D0 File Offset: 0x000E02D0
		// (set) Token: 0x06002327 RID: 8999 RVA: 0x00013619 File Offset: 0x00011819
		public unsafe static float RollLimit
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(Skateboard.NativeFieldInfoPtr_RollLimit, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Skateboard.NativeFieldInfoPtr_RollLimit, (void*)(&value));
			}
		}

		// Token: 0x17000BE1 RID: 3041
		// (get) Token: 0x06002328 RID: 9000 RVA: 0x000E20EC File Offset: 0x000E02EC
		// (set) Token: 0x06002329 RID: 9001 RVA: 0x00013627 File Offset: 0x00011827
		public unsafe float CurrentSpeed_Kmh
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_CurrentSpeed_Kmh);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_CurrentSpeed_Kmh)) = value;
			}
		}

		// Token: 0x17000BE2 RID: 3042
		// (get) Token: 0x0600232A RID: 9002 RVA: 0x000E2114 File Offset: 0x000E0314
		// (set) Token: 0x0600232B RID: 9003 RVA: 0x00013642 File Offset: 0x00011842
		public unsafe float _CurrentSteerInput_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr__CurrentSteerInput_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr__CurrentSteerInput_k__BackingField)) = value;
			}
		}

		// Token: 0x17000BE3 RID: 3043
		// (get) Token: 0x0600232C RID: 9004 RVA: 0x000E213C File Offset: 0x000E033C
		// (set) Token: 0x0600232D RID: 9005 RVA: 0x0001365D File Offset: 0x0001185D
		public unsafe float _JumpBuildAmount_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr__JumpBuildAmount_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr__JumpBuildAmount_k__BackingField)) = value;
			}
		}

		// Token: 0x17000BE4 RID: 3044
		// (get) Token: 0x0600232E RID: 9006 RVA: 0x000E2164 File Offset: 0x000E0364
		// (set) Token: 0x0600232F RID: 9007 RVA: 0x00013678 File Offset: 0x00011878
		public unsafe Player _Rider_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr__Rider_k__BackingField);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Player>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr__Rider_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000BE5 RID: 3045
		// (get) Token: 0x06002330 RID: 9008 RVA: 0x000E2194 File Offset: 0x000E0394
		// (set) Token: 0x06002331 RID: 9009 RVA: 0x00013697 File Offset: 0x00011897
		public unsafe Rigidbody Rb
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_Rb);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Rigidbody>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_Rb), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000BE6 RID: 3046
		// (get) Token: 0x06002332 RID: 9010 RVA: 0x000E21C4 File Offset: 0x000E03C4
		// (set) Token: 0x06002333 RID: 9011 RVA: 0x000136B6 File Offset: 0x000118B6
		public unsafe Transform CoM
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_CoM);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_CoM), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000BE7 RID: 3047
		// (get) Token: 0x06002334 RID: 9012 RVA: 0x000E21F4 File Offset: 0x000E03F4
		// (set) Token: 0x06002335 RID: 9013 RVA: 0x000136D5 File Offset: 0x000118D5
		public unsafe Il2CppReferenceArray<Transform> HoverPoints
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_HoverPoints);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Transform>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_HoverPoints), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000BE8 RID: 3048
		// (get) Token: 0x06002336 RID: 9014 RVA: 0x000E2224 File Offset: 0x000E0424
		// (set) Token: 0x06002337 RID: 9015 RVA: 0x000136F4 File Offset: 0x000118F4
		public unsafe Transform FrontAxlePosition
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_FrontAxlePosition);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_FrontAxlePosition), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000BE9 RID: 3049
		// (get) Token: 0x06002338 RID: 9016 RVA: 0x000E2254 File Offset: 0x000E0454
		// (set) Token: 0x06002339 RID: 9017 RVA: 0x00013713 File Offset: 0x00011913
		public unsafe Transform RearAxlePosition
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_RearAxlePosition);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_RearAxlePosition), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000BEA RID: 3050
		// (get) Token: 0x0600233A RID: 9018 RVA: 0x000E2284 File Offset: 0x000E0484
		// (set) Token: 0x0600233B RID: 9019 RVA: 0x00013732 File Offset: 0x00011932
		public unsafe Transform PlayerContainer
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_PlayerContainer);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_PlayerContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000BEB RID: 3051
		// (get) Token: 0x0600233C RID: 9020 RVA: 0x000E22B4 File Offset: 0x000E04B4
		// (set) Token: 0x0600233D RID: 9021 RVA: 0x00013751 File Offset: 0x00011951
		public unsafe SkateboardAnimation Animation
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_Animation);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SkateboardAnimation>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_Animation), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000BEC RID: 3052
		// (get) Token: 0x0600233E RID: 9022 RVA: 0x000E22E4 File Offset: 0x000E04E4
		// (set) Token: 0x0600233F RID: 9023 RVA: 0x00013770 File Offset: 0x00011970
		public unsafe SmoothedVelocityCalculator VelocityCalculator
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_VelocityCalculator);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SmoothedVelocityCalculator>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_VelocityCalculator), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000BED RID: 3053
		// (get) Token: 0x06002340 RID: 9024 RVA: 0x000E2314 File Offset: 0x000E0514
		// (set) Token: 0x06002341 RID: 9025 RVA: 0x0001378F File Offset: 0x0001198F
		public unsafe AverageAcceleration Accelerometer
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_Accelerometer);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AverageAcceleration>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_Accelerometer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000BEE RID: 3054
		// (get) Token: 0x06002342 RID: 9026 RVA: 0x000E2344 File Offset: 0x000E0544
		// (set) Token: 0x06002343 RID: 9027 RVA: 0x000137AE File Offset: 0x000119AE
		public unsafe Skateboard_Equippable Equippable
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_Equippable);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Skateboard_Equippable>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_Equippable), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000BEF RID: 3055
		// (get) Token: 0x06002344 RID: 9028 RVA: 0x000E2374 File Offset: 0x000E0574
		// (set) Token: 0x06002345 RID: 9029 RVA: 0x000137CD File Offset: 0x000119CD
		public unsafe Transform IKAlignmentsContainer
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_IKAlignmentsContainer);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_IKAlignmentsContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000BF0 RID: 3056
		// (get) Token: 0x06002346 RID: 9030 RVA: 0x000E23A4 File Offset: 0x000E05A4
		// (set) Token: 0x06002347 RID: 9031 RVA: 0x000137EC File Offset: 0x000119EC
		public unsafe float TurnForce
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_TurnForce);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_TurnForce)) = value;
			}
		}

		// Token: 0x17000BF1 RID: 3057
		// (get) Token: 0x06002348 RID: 9032 RVA: 0x000E23CC File Offset: 0x000E05CC
		// (set) Token: 0x06002349 RID: 9033 RVA: 0x00013807 File Offset: 0x00011A07
		public unsafe float TurnChangeRate
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_TurnChangeRate);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_TurnChangeRate)) = value;
			}
		}

		// Token: 0x17000BF2 RID: 3058
		// (get) Token: 0x0600234A RID: 9034 RVA: 0x000E23F4 File Offset: 0x000E05F4
		// (set) Token: 0x0600234B RID: 9035 RVA: 0x00013822 File Offset: 0x00011A22
		public unsafe float TurnReturnToRestRate
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_TurnReturnToRestRate);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_TurnReturnToRestRate)) = value;
			}
		}

		// Token: 0x17000BF3 RID: 3059
		// (get) Token: 0x0600234C RID: 9036 RVA: 0x000E241C File Offset: 0x000E061C
		// (set) Token: 0x0600234D RID: 9037 RVA: 0x0001383D File Offset: 0x00011A3D
		public unsafe float TurnSpeedBoost
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_TurnSpeedBoost);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_TurnSpeedBoost)) = value;
			}
		}

		// Token: 0x17000BF4 RID: 3060
		// (get) Token: 0x0600234E RID: 9038 RVA: 0x000E2444 File Offset: 0x000E0644
		// (set) Token: 0x0600234F RID: 9039 RVA: 0x00013858 File Offset: 0x00011A58
		public unsafe AnimationCurve TurnForceMap
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_TurnForceMap);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnimationCurve>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_TurnForceMap), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000BF5 RID: 3061
		// (get) Token: 0x06002350 RID: 9040 RVA: 0x000E2474 File Offset: 0x000E0674
		// (set) Token: 0x06002351 RID: 9041 RVA: 0x00013877 File Offset: 0x00011A77
		public unsafe float Gravity
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_Gravity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_Gravity)) = value;
			}
		}

		// Token: 0x17000BF6 RID: 3062
		// (get) Token: 0x06002352 RID: 9042 RVA: 0x000E249C File Offset: 0x000E069C
		// (set) Token: 0x06002353 RID: 9043 RVA: 0x00013892 File Offset: 0x00011A92
		public unsafe float BrakeForce
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_BrakeForce);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_BrakeForce)) = value;
			}
		}

		// Token: 0x17000BF7 RID: 3063
		// (get) Token: 0x06002354 RID: 9044 RVA: 0x000E24C4 File Offset: 0x000E06C4
		// (set) Token: 0x06002355 RID: 9045 RVA: 0x000138AD File Offset: 0x00011AAD
		public unsafe float ReverseTopSpeed_Kmh
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_ReverseTopSpeed_Kmh);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_ReverseTopSpeed_Kmh)) = value;
			}
		}

		// Token: 0x17000BF8 RID: 3064
		// (get) Token: 0x06002356 RID: 9046 RVA: 0x000E24EC File Offset: 0x000E06EC
		// (set) Token: 0x06002357 RID: 9047 RVA: 0x000138C8 File Offset: 0x00011AC8
		public unsafe LayerMask GroundDetectionMask
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_GroundDetectionMask);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_GroundDetectionMask)) = value;
			}
		}

		// Token: 0x17000BF9 RID: 3065
		// (get) Token: 0x06002358 RID: 9048 RVA: 0x000E2514 File Offset: 0x000E0714
		// (set) Token: 0x06002359 RID: 9049 RVA: 0x000138E3 File Offset: 0x00011AE3
		public unsafe Il2CppReferenceArray<Collider> MainColliders
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_MainColliders);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Collider>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_MainColliders), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000BFA RID: 3066
		// (get) Token: 0x0600235A RID: 9050 RVA: 0x000E2544 File Offset: 0x000E0744
		// (set) Token: 0x0600235B RID: 9051 RVA: 0x00013902 File Offset: 0x00011B02
		public unsafe float RotationClampForce
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_RotationClampForce);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_RotationClampForce)) = value;
			}
		}

		// Token: 0x17000BFB RID: 3067
		// (get) Token: 0x0600235C RID: 9052 RVA: 0x000E256C File Offset: 0x000E076C
		// (set) Token: 0x0600235D RID: 9053 RVA: 0x0001391D File Offset: 0x00011B1D
		public unsafe bool FrictionEnabled
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_FrictionEnabled);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_FrictionEnabled)) = value;
			}
		}

		// Token: 0x17000BFC RID: 3068
		// (get) Token: 0x0600235E RID: 9054 RVA: 0x000E2594 File Offset: 0x000E0794
		// (set) Token: 0x0600235F RID: 9055 RVA: 0x00013938 File Offset: 0x00011B38
		public unsafe AnimationCurve LongitudinalFrictionCurve
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_LongitudinalFrictionCurve);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnimationCurve>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_LongitudinalFrictionCurve), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000BFD RID: 3069
		// (get) Token: 0x06002360 RID: 9056 RVA: 0x000E25C4 File Offset: 0x000E07C4
		// (set) Token: 0x06002361 RID: 9057 RVA: 0x00013957 File Offset: 0x00011B57
		public unsafe float LongitudinalFrictionMultiplier
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_LongitudinalFrictionMultiplier);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_LongitudinalFrictionMultiplier)) = value;
			}
		}

		// Token: 0x17000BFE RID: 3070
		// (get) Token: 0x06002362 RID: 9058 RVA: 0x000E25EC File Offset: 0x000E07EC
		// (set) Token: 0x06002363 RID: 9059 RVA: 0x00013972 File Offset: 0x00011B72
		public unsafe float LateralFrictionForceMultiplier
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_LateralFrictionForceMultiplier);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_LateralFrictionForceMultiplier)) = value;
			}
		}

		// Token: 0x17000BFF RID: 3071
		// (get) Token: 0x06002364 RID: 9060 RVA: 0x000E2614 File Offset: 0x000E0814
		// (set) Token: 0x06002365 RID: 9061 RVA: 0x0001398D File Offset: 0x00011B8D
		public unsafe float JumpForce
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_JumpForce);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_JumpForce)) = value;
			}
		}

		// Token: 0x17000C00 RID: 3072
		// (get) Token: 0x06002366 RID: 9062 RVA: 0x000E263C File Offset: 0x000E083C
		// (set) Token: 0x06002367 RID: 9063 RVA: 0x000139A8 File Offset: 0x00011BA8
		public unsafe float JumpDuration_Min
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_JumpDuration_Min);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_JumpDuration_Min)) = value;
			}
		}

		// Token: 0x17000C01 RID: 3073
		// (get) Token: 0x06002368 RID: 9064 RVA: 0x000E2664 File Offset: 0x000E0864
		// (set) Token: 0x06002369 RID: 9065 RVA: 0x000139C3 File Offset: 0x00011BC3
		public unsafe float JumpDuration_Max
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_JumpDuration_Max);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_JumpDuration_Max)) = value;
			}
		}

		// Token: 0x17000C02 RID: 3074
		// (get) Token: 0x0600236A RID: 9066 RVA: 0x000E268C File Offset: 0x000E088C
		// (set) Token: 0x0600236B RID: 9067 RVA: 0x000139DE File Offset: 0x00011BDE
		public unsafe AnimationCurve FrontAxleJumpCurve
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_FrontAxleJumpCurve);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnimationCurve>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_FrontAxleJumpCurve), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C03 RID: 3075
		// (get) Token: 0x0600236C RID: 9068 RVA: 0x000E26BC File Offset: 0x000E08BC
		// (set) Token: 0x0600236D RID: 9069 RVA: 0x000139FD File Offset: 0x00011BFD
		public unsafe AnimationCurve RearAxleJumpCurve
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_RearAxleJumpCurve);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnimationCurve>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_RearAxleJumpCurve), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C04 RID: 3076
		// (get) Token: 0x0600236E RID: 9070 RVA: 0x000E26EC File Offset: 0x000E08EC
		// (set) Token: 0x0600236F RID: 9071 RVA: 0x00013A1C File Offset: 0x00011C1C
		public unsafe AnimationCurve JumpForwardForceCurve
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_JumpForwardForceCurve);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnimationCurve>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_JumpForwardForceCurve), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C05 RID: 3077
		// (get) Token: 0x06002370 RID: 9072 RVA: 0x000E271C File Offset: 0x000E091C
		// (set) Token: 0x06002371 RID: 9073 RVA: 0x00013A3B File Offset: 0x00011C3B
		public unsafe float JumpForwardBoost
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_JumpForwardBoost);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_JumpForwardBoost)) = value;
			}
		}

		// Token: 0x17000C06 RID: 3078
		// (get) Token: 0x06002372 RID: 9074 RVA: 0x000E2744 File Offset: 0x000E0944
		// (set) Token: 0x06002373 RID: 9075 RVA: 0x00013A56 File Offset: 0x00011C56
		public unsafe float HoverForce
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_HoverForce);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_HoverForce)) = value;
			}
		}

		// Token: 0x17000C07 RID: 3079
		// (get) Token: 0x06002374 RID: 9076 RVA: 0x000E276C File Offset: 0x000E096C
		// (set) Token: 0x06002375 RID: 9077 RVA: 0x00013A71 File Offset: 0x00011C71
		public unsafe float HoverRayLength
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_HoverRayLength);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_HoverRayLength)) = value;
			}
		}

		// Token: 0x17000C08 RID: 3080
		// (get) Token: 0x06002376 RID: 9078 RVA: 0x000E2794 File Offset: 0x000E0994
		// (set) Token: 0x06002377 RID: 9079 RVA: 0x00013A8C File Offset: 0x00011C8C
		public unsafe float HoverHeight
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_HoverHeight);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_HoverHeight)) = value;
			}
		}

		// Token: 0x17000C09 RID: 3081
		// (get) Token: 0x06002378 RID: 9080 RVA: 0x000E27BC File Offset: 0x000E09BC
		// (set) Token: 0x06002379 RID: 9081 RVA: 0x00013AA7 File Offset: 0x00011CA7
		public unsafe float Hover_P
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_Hover_P);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_Hover_P)) = value;
			}
		}

		// Token: 0x17000C0A RID: 3082
		// (get) Token: 0x0600237A RID: 9082 RVA: 0x000E27E4 File Offset: 0x000E09E4
		// (set) Token: 0x0600237B RID: 9083 RVA: 0x00013AC2 File Offset: 0x00011CC2
		public unsafe float Hover_I
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_Hover_I);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_Hover_I)) = value;
			}
		}

		// Token: 0x17000C0B RID: 3083
		// (get) Token: 0x0600237C RID: 9084 RVA: 0x000E280C File Offset: 0x000E0A0C
		// (set) Token: 0x0600237D RID: 9085 RVA: 0x00013ADD File Offset: 0x00011CDD
		public unsafe float Hover_D
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_Hover_D);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_Hover_D)) = value;
			}
		}

		// Token: 0x17000C0C RID: 3084
		// (get) Token: 0x0600237E RID: 9086 RVA: 0x000E2834 File Offset: 0x000E0A34
		// (set) Token: 0x0600237F RID: 9087 RVA: 0x00013AF8 File Offset: 0x00011CF8
		public unsafe float TopSpeed_Kmh
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_TopSpeed_Kmh);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_TopSpeed_Kmh)) = value;
			}
		}

		// Token: 0x17000C0D RID: 3085
		// (get) Token: 0x06002380 RID: 9088 RVA: 0x000E285C File Offset: 0x000E0A5C
		// (set) Token: 0x06002381 RID: 9089 RVA: 0x00013B13 File Offset: 0x00011D13
		public unsafe float PushForceMultiplier
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_PushForceMultiplier);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_PushForceMultiplier)) = value;
			}
		}

		// Token: 0x17000C0E RID: 3086
		// (get) Token: 0x06002382 RID: 9090 RVA: 0x000E2884 File Offset: 0x000E0A84
		// (set) Token: 0x06002383 RID: 9091 RVA: 0x00013B2E File Offset: 0x00011D2E
		public unsafe AnimationCurve PushForceMultiplierMap
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_PushForceMultiplierMap);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnimationCurve>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_PushForceMultiplierMap), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C0F RID: 3087
		// (get) Token: 0x06002384 RID: 9092 RVA: 0x000E28B4 File Offset: 0x000E0AB4
		// (set) Token: 0x06002385 RID: 9093 RVA: 0x00013B4D File Offset: 0x00011D4D
		public unsafe float PushForceDuration
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_PushForceDuration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_PushForceDuration)) = value;
			}
		}

		// Token: 0x17000C10 RID: 3088
		// (get) Token: 0x06002386 RID: 9094 RVA: 0x000E28DC File Offset: 0x000E0ADC
		// (set) Token: 0x06002387 RID: 9095 RVA: 0x00013B68 File Offset: 0x00011D68
		public unsafe float PushDelay
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_PushDelay);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_PushDelay)) = value;
			}
		}

		// Token: 0x17000C11 RID: 3089
		// (get) Token: 0x06002388 RID: 9096 RVA: 0x000E2904 File Offset: 0x000E0B04
		// (set) Token: 0x06002389 RID: 9097 RVA: 0x00013B83 File Offset: 0x00011D83
		public unsafe AnimationCurve PushForceCurve
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_PushForceCurve);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnimationCurve>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_PushForceCurve), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C12 RID: 3090
		// (get) Token: 0x0600238A RID: 9098 RVA: 0x000E2934 File Offset: 0x000E0B34
		// (set) Token: 0x0600238B RID: 9099 RVA: 0x00013BA2 File Offset: 0x00011DA2
		public unsafe bool AirMovementEnabled
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_AirMovementEnabled);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_AirMovementEnabled)) = value;
			}
		}

		// Token: 0x17000C13 RID: 3091
		// (get) Token: 0x0600238C RID: 9100 RVA: 0x000E295C File Offset: 0x000E0B5C
		// (set) Token: 0x0600238D RID: 9101 RVA: 0x00013BBD File Offset: 0x00011DBD
		public unsafe float AirMovementForce
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_AirMovementForce);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_AirMovementForce)) = value;
			}
		}

		// Token: 0x17000C14 RID: 3092
		// (get) Token: 0x0600238E RID: 9102 RVA: 0x000E2984 File Offset: 0x000E0B84
		// (set) Token: 0x0600238F RID: 9103 RVA: 0x00013BD8 File Offset: 0x00011DD8
		public unsafe float AirMovementJumpReductionDuration
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_AirMovementJumpReductionDuration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_AirMovementJumpReductionDuration)) = value;
			}
		}

		// Token: 0x17000C15 RID: 3093
		// (get) Token: 0x06002390 RID: 9104 RVA: 0x000E29AC File Offset: 0x000E0BAC
		// (set) Token: 0x06002391 RID: 9105 RVA: 0x00013BF3 File Offset: 0x00011DF3
		public unsafe AnimationCurve AirMovementJumpReductionCurve
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_AirMovementJumpReductionCurve);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnimationCurve>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_AirMovementJumpReductionCurve), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C16 RID: 3094
		// (get) Token: 0x06002392 RID: 9106 RVA: 0x000E29DC File Offset: 0x000E0BDC
		// (set) Token: 0x06002393 RID: 9107 RVA: 0x00013C12 File Offset: 0x00011E12
		public unsafe UnityEvent OnPushStart
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_OnPushStart);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_OnPushStart), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C17 RID: 3095
		// (get) Token: 0x06002394 RID: 9108 RVA: 0x000E2A0C File Offset: 0x000E0C0C
		// (set) Token: 0x06002395 RID: 9109 RVA: 0x00013C31 File Offset: 0x00011E31
		public unsafe UnityEvent<float> OnJump
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_OnJump);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent<float>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_OnJump), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C18 RID: 3096
		// (get) Token: 0x06002396 RID: 9110 RVA: 0x000E2A3C File Offset: 0x000E0C3C
		// (set) Token: 0x06002397 RID: 9111 RVA: 0x00013C50 File Offset: 0x00011E50
		public unsafe UnityEvent OnLand
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_OnLand);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_OnLand), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C19 RID: 3097
		// (get) Token: 0x06002398 RID: 9112 RVA: 0x000E2A6C File Offset: 0x000E0C6C
		// (set) Token: 0x06002399 RID: 9113 RVA: 0x00013C6F File Offset: 0x00011E6F
		public unsafe int horizontalInput
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_horizontalInput);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_horizontalInput)) = value;
			}
		}

		// Token: 0x17000C1A RID: 3098
		// (get) Token: 0x0600239A RID: 9114 RVA: 0x000E2A94 File Offset: 0x000E0C94
		// (set) Token: 0x0600239B RID: 9115 RVA: 0x00013C8A File Offset: 0x00011E8A
		public unsafe bool jumpReleased
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_jumpReleased);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_jumpReleased)) = value;
			}
		}

		// Token: 0x17000C1B RID: 3099
		// (get) Token: 0x0600239C RID: 9116 RVA: 0x000E2ABC File Offset: 0x000E0CBC
		// (set) Token: 0x0600239D RID: 9117 RVA: 0x00013CA5 File Offset: 0x00011EA5
		public unsafe float timeSinceLastJump
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_timeSinceLastJump);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_timeSinceLastJump)) = value;
			}
		}

		// Token: 0x17000C1C RID: 3100
		// (get) Token: 0x0600239E RID: 9118 RVA: 0x000E2AE4 File Offset: 0x000E0CE4
		// (set) Token: 0x0600239F RID: 9119 RVA: 0x00013CC0 File Offset: 0x00011EC0
		public unsafe float timeGrounded
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_timeGrounded);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_timeGrounded)) = value;
			}
		}

		// Token: 0x17000C1D RID: 3101
		// (get) Token: 0x060023A0 RID: 9120 RVA: 0x000E2B0C File Offset: 0x000E0D0C
		// (set) Token: 0x060023A1 RID: 9121 RVA: 0x00013CDB File Offset: 0x00011EDB
		public unsafe float timeAirborne
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_timeAirborne);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_timeAirborne)) = value;
			}
		}

		// Token: 0x17000C1E RID: 3102
		// (get) Token: 0x060023A2 RID: 9122 RVA: 0x000E2B34 File Offset: 0x000E0D34
		// (set) Token: 0x060023A3 RID: 9123 RVA: 0x00013CF6 File Offset: 0x00011EF6
		public unsafe float jumpHeldTime
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_jumpHeldTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_jumpHeldTime)) = value;
			}
		}

		// Token: 0x17000C1F RID: 3103
		// (get) Token: 0x060023A4 RID: 9124 RVA: 0x000E2B5C File Offset: 0x000E0D5C
		// (set) Token: 0x060023A5 RID: 9125 RVA: 0x00013D11 File Offset: 0x00011F11
		public unsafe float frontAxleForce
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_frontAxleForce);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_frontAxleForce)) = value;
			}
		}

		// Token: 0x17000C20 RID: 3104
		// (get) Token: 0x060023A6 RID: 9126 RVA: 0x000E2B84 File Offset: 0x000E0D84
		// (set) Token: 0x060023A7 RID: 9127 RVA: 0x00013D2C File Offset: 0x00011F2C
		public unsafe float rearAxleForce
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_rearAxleForce);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_rearAxleForce)) = value;
			}
		}

		// Token: 0x17000C21 RID: 3105
		// (get) Token: 0x060023A8 RID: 9128 RVA: 0x000E2BAC File Offset: 0x000E0DAC
		// (set) Token: 0x060023A9 RID: 9129 RVA: 0x00013D47 File Offset: 0x00011F47
		public unsafe float jumpForwardForce
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_jumpForwardForce);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_jumpForwardForce)) = value;
			}
		}

		// Token: 0x17000C22 RID: 3106
		// (get) Token: 0x060023AA RID: 9130 RVA: 0x000E2BD4 File Offset: 0x000E0DD4
		// (set) Token: 0x060023AB RID: 9131 RVA: 0x00013D62 File Offset: 0x00011F62
		public unsafe List<PID> hoverPIDs
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_hoverPIDs);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<PID>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_hoverPIDs), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C23 RID: 3107
		// (get) Token: 0x060023AC RID: 9132 RVA: 0x000E2C04 File Offset: 0x000E0E04
		// (set) Token: 0x060023AD RID: 9133 RVA: 0x00013D81 File Offset: 0x00011F81
		public unsafe bool pushQueued
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_pushQueued);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_pushQueued)) = value;
			}
		}

		// Token: 0x17000C24 RID: 3108
		// (get) Token: 0x060023AE RID: 9134 RVA: 0x000E2C2C File Offset: 0x000E0E2C
		// (set) Token: 0x060023AF RID: 9135 RVA: 0x00013D9C File Offset: 0x00011F9C
		public unsafe bool isPushing
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_isPushing);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_isPushing)) = value;
			}
		}

		// Token: 0x17000C25 RID: 3109
		// (get) Token: 0x060023B0 RID: 9136 RVA: 0x000E2C54 File Offset: 0x000E0E54
		// (set) Token: 0x060023B1 RID: 9137 RVA: 0x00013DB7 File Offset: 0x00011FB7
		public unsafe float thisFramePushForce
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_thisFramePushForce);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_thisFramePushForce)) = value;
			}
		}

		// Token: 0x17000C26 RID: 3110
		// (get) Token: 0x060023B2 RID: 9138 RVA: 0x000E2C7C File Offset: 0x000E0E7C
		// (set) Token: 0x060023B3 RID: 9139 RVA: 0x00013DD2 File Offset: 0x00011FD2
		public unsafe float timeSincePushStart
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_timeSincePushStart);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_timeSincePushStart)) = value;
			}
		}

		// Token: 0x17000C27 RID: 3111
		// (get) Token: 0x060023B4 RID: 9140 RVA: 0x000E2CA4 File Offset: 0x000E0EA4
		// (set) Token: 0x060023B5 RID: 9141 RVA: 0x00013DED File Offset: 0x00011FED
		public unsafe bool braking
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_braking);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_braking)) = value;
			}
		}

		// Token: 0x17000C28 RID: 3112
		// (get) Token: 0x060023B6 RID: 9142 RVA: 0x000E2CCC File Offset: 0x000E0ECC
		// (set) Token: 0x060023B7 RID: 9143 RVA: 0x00013E08 File Offset: 0x00012008
		public unsafe SyncVar<float> syncVar____JumpBuildAmount_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_syncVar____JumpBuildAmount_k__BackingField);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SyncVar<float>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_syncVar____JumpBuildAmount_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C29 RID: 3113
		// (get) Token: 0x060023B8 RID: 9144 RVA: 0x000E2CFC File Offset: 0x000E0EFC
		// (set) Token: 0x060023B9 RID: 9145 RVA: 0x00013E27 File Offset: 0x00012027
		public unsafe bool field_Private_Boolean_0
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_field_Private_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_field_Private_Boolean_0)) = value;
			}
		}

		// Token: 0x17000C2A RID: 3114
		// (get) Token: 0x060023BA RID: 9146 RVA: 0x000E2D24 File Offset: 0x000E0F24
		// (set) Token: 0x060023BB RID: 9147 RVA: 0x00013E42 File Offset: 0x00012042
		public unsafe bool field_Private_Boolean_1
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_field_Private_Boolean_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.NativeFieldInfoPtr_field_Private_Boolean_1)) = value;
			}
		}

		// Token: 0x0400173A RID: 5946
		private static readonly System.IntPtr NativeFieldInfoPtr_GroundedRaycastDistance;

		// Token: 0x0400173B RID: 5947
		private static readonly System.IntPtr NativeFieldInfoPtr_JumpCooldown;

		// Token: 0x0400173C RID: 5948
		private static readonly System.IntPtr NativeFieldInfoPtr_JumpForceMin;

		// Token: 0x0400173D RID: 5949
		private static readonly System.IntPtr NativeFieldInfoPtr_JumpForceBuildTime;

		// Token: 0x0400173E RID: 5950
		private static readonly System.IntPtr NativeFieldInfoPtr_PushCooldown;

		// Token: 0x0400173F RID: 5951
		private static readonly System.IntPtr NativeFieldInfoPtr_PushStaminaConsumption;

		// Token: 0x04001740 RID: 5952
		private static readonly System.IntPtr NativeFieldInfoPtr_PitchLimit;

		// Token: 0x04001741 RID: 5953
		private static readonly System.IntPtr NativeFieldInfoPtr_RollLimit;

		// Token: 0x04001742 RID: 5954
		private static readonly System.IntPtr NativeFieldInfoPtr_CurrentSpeed_Kmh;

		// Token: 0x04001743 RID: 5955
		private static readonly System.IntPtr NativeFieldInfoPtr__CurrentSteerInput_k__BackingField;

		// Token: 0x04001744 RID: 5956
		private static readonly System.IntPtr NativeFieldInfoPtr__JumpBuildAmount_k__BackingField;

		// Token: 0x04001745 RID: 5957
		private static readonly System.IntPtr NativeFieldInfoPtr__Rider_k__BackingField;

		// Token: 0x04001746 RID: 5958
		private static readonly System.IntPtr NativeFieldInfoPtr_Rb;

		// Token: 0x04001747 RID: 5959
		private static readonly System.IntPtr NativeFieldInfoPtr_CoM;

		// Token: 0x04001748 RID: 5960
		private static readonly System.IntPtr NativeFieldInfoPtr_HoverPoints;

		// Token: 0x04001749 RID: 5961
		private static readonly System.IntPtr NativeFieldInfoPtr_FrontAxlePosition;

		// Token: 0x0400174A RID: 5962
		private static readonly System.IntPtr NativeFieldInfoPtr_RearAxlePosition;

		// Token: 0x0400174B RID: 5963
		private static readonly System.IntPtr NativeFieldInfoPtr_PlayerContainer;

		// Token: 0x0400174C RID: 5964
		private static readonly System.IntPtr NativeFieldInfoPtr_Animation;

		// Token: 0x0400174D RID: 5965
		private static readonly System.IntPtr NativeFieldInfoPtr_VelocityCalculator;

		// Token: 0x0400174E RID: 5966
		private static readonly System.IntPtr NativeFieldInfoPtr_Accelerometer;

		// Token: 0x0400174F RID: 5967
		private static readonly System.IntPtr NativeFieldInfoPtr_Equippable;

		// Token: 0x04001750 RID: 5968
		private static readonly System.IntPtr NativeFieldInfoPtr_IKAlignmentsContainer;

		// Token: 0x04001751 RID: 5969
		private static readonly System.IntPtr NativeFieldInfoPtr_TurnForce;

		// Token: 0x04001752 RID: 5970
		private static readonly System.IntPtr NativeFieldInfoPtr_TurnChangeRate;

		// Token: 0x04001753 RID: 5971
		private static readonly System.IntPtr NativeFieldInfoPtr_TurnReturnToRestRate;

		// Token: 0x04001754 RID: 5972
		private static readonly System.IntPtr NativeFieldInfoPtr_TurnSpeedBoost;

		// Token: 0x04001755 RID: 5973
		private static readonly System.IntPtr NativeFieldInfoPtr_TurnForceMap;

		// Token: 0x04001756 RID: 5974
		private static readonly System.IntPtr NativeFieldInfoPtr_Gravity;

		// Token: 0x04001757 RID: 5975
		private static readonly System.IntPtr NativeFieldInfoPtr_BrakeForce;

		// Token: 0x04001758 RID: 5976
		private static readonly System.IntPtr NativeFieldInfoPtr_ReverseTopSpeed_Kmh;

		// Token: 0x04001759 RID: 5977
		private static readonly System.IntPtr NativeFieldInfoPtr_GroundDetectionMask;

		// Token: 0x0400175A RID: 5978
		private static readonly System.IntPtr NativeFieldInfoPtr_MainColliders;

		// Token: 0x0400175B RID: 5979
		private static readonly System.IntPtr NativeFieldInfoPtr_RotationClampForce;

		// Token: 0x0400175C RID: 5980
		private static readonly System.IntPtr NativeFieldInfoPtr_FrictionEnabled;

		// Token: 0x0400175D RID: 5981
		private static readonly System.IntPtr NativeFieldInfoPtr_LongitudinalFrictionCurve;

		// Token: 0x0400175E RID: 5982
		private static readonly System.IntPtr NativeFieldInfoPtr_LongitudinalFrictionMultiplier;

		// Token: 0x0400175F RID: 5983
		private static readonly System.IntPtr NativeFieldInfoPtr_LateralFrictionForceMultiplier;

		// Token: 0x04001760 RID: 5984
		private static readonly System.IntPtr NativeFieldInfoPtr_JumpForce;

		// Token: 0x04001761 RID: 5985
		private static readonly System.IntPtr NativeFieldInfoPtr_JumpDuration_Min;

		// Token: 0x04001762 RID: 5986
		private static readonly System.IntPtr NativeFieldInfoPtr_JumpDuration_Max;

		// Token: 0x04001763 RID: 5987
		private static readonly System.IntPtr NativeFieldInfoPtr_FrontAxleJumpCurve;

		// Token: 0x04001764 RID: 5988
		private static readonly System.IntPtr NativeFieldInfoPtr_RearAxleJumpCurve;

		// Token: 0x04001765 RID: 5989
		private static readonly System.IntPtr NativeFieldInfoPtr_JumpForwardForceCurve;

		// Token: 0x04001766 RID: 5990
		private static readonly System.IntPtr NativeFieldInfoPtr_JumpForwardBoost;

		// Token: 0x04001767 RID: 5991
		private static readonly System.IntPtr NativeFieldInfoPtr_HoverForce;

		// Token: 0x04001768 RID: 5992
		private static readonly System.IntPtr NativeFieldInfoPtr_HoverRayLength;

		// Token: 0x04001769 RID: 5993
		private static readonly System.IntPtr NativeFieldInfoPtr_HoverHeight;

		// Token: 0x0400176A RID: 5994
		private static readonly System.IntPtr NativeFieldInfoPtr_Hover_P;

		// Token: 0x0400176B RID: 5995
		private static readonly System.IntPtr NativeFieldInfoPtr_Hover_I;

		// Token: 0x0400176C RID: 5996
		private static readonly System.IntPtr NativeFieldInfoPtr_Hover_D;

		// Token: 0x0400176D RID: 5997
		private static readonly System.IntPtr NativeFieldInfoPtr_TopSpeed_Kmh;

		// Token: 0x0400176E RID: 5998
		private static readonly System.IntPtr NativeFieldInfoPtr_PushForceMultiplier;

		// Token: 0x0400176F RID: 5999
		private static readonly System.IntPtr NativeFieldInfoPtr_PushForceMultiplierMap;

		// Token: 0x04001770 RID: 6000
		private static readonly System.IntPtr NativeFieldInfoPtr_PushForceDuration;

		// Token: 0x04001771 RID: 6001
		private static readonly System.IntPtr NativeFieldInfoPtr_PushDelay;

		// Token: 0x04001772 RID: 6002
		private static readonly System.IntPtr NativeFieldInfoPtr_PushForceCurve;

		// Token: 0x04001773 RID: 6003
		private static readonly System.IntPtr NativeFieldInfoPtr_AirMovementEnabled;

		// Token: 0x04001774 RID: 6004
		private static readonly System.IntPtr NativeFieldInfoPtr_AirMovementForce;

		// Token: 0x04001775 RID: 6005
		private static readonly System.IntPtr NativeFieldInfoPtr_AirMovementJumpReductionDuration;

		// Token: 0x04001776 RID: 6006
		private static readonly System.IntPtr NativeFieldInfoPtr_AirMovementJumpReductionCurve;

		// Token: 0x04001777 RID: 6007
		private static readonly System.IntPtr NativeFieldInfoPtr_OnPushStart;

		// Token: 0x04001778 RID: 6008
		private static readonly System.IntPtr NativeFieldInfoPtr_OnJump;

		// Token: 0x04001779 RID: 6009
		private static readonly System.IntPtr NativeFieldInfoPtr_OnLand;

		// Token: 0x0400177A RID: 6010
		private static readonly System.IntPtr NativeFieldInfoPtr_horizontalInput;

		// Token: 0x0400177B RID: 6011
		private static readonly System.IntPtr NativeFieldInfoPtr_jumpReleased;

		// Token: 0x0400177C RID: 6012
		private static readonly System.IntPtr NativeFieldInfoPtr_timeSinceLastJump;

		// Token: 0x0400177D RID: 6013
		private static readonly System.IntPtr NativeFieldInfoPtr_timeGrounded;

		// Token: 0x0400177E RID: 6014
		private static readonly System.IntPtr NativeFieldInfoPtr_timeAirborne;

		// Token: 0x0400177F RID: 6015
		private static readonly System.IntPtr NativeFieldInfoPtr_jumpHeldTime;

		// Token: 0x04001780 RID: 6016
		private static readonly System.IntPtr NativeFieldInfoPtr_frontAxleForce;

		// Token: 0x04001781 RID: 6017
		private static readonly System.IntPtr NativeFieldInfoPtr_rearAxleForce;

		// Token: 0x04001782 RID: 6018
		private static readonly System.IntPtr NativeFieldInfoPtr_jumpForwardForce;

		// Token: 0x04001783 RID: 6019
		private static readonly System.IntPtr NativeFieldInfoPtr_hoverPIDs;

		// Token: 0x04001784 RID: 6020
		private static readonly System.IntPtr NativeFieldInfoPtr_pushQueued;

		// Token: 0x04001785 RID: 6021
		private static readonly System.IntPtr NativeFieldInfoPtr_isPushing;

		// Token: 0x04001786 RID: 6022
		private static readonly System.IntPtr NativeFieldInfoPtr_thisFramePushForce;

		// Token: 0x04001787 RID: 6023
		private static readonly System.IntPtr NativeFieldInfoPtr_timeSincePushStart;

		// Token: 0x04001788 RID: 6024
		private static readonly System.IntPtr NativeFieldInfoPtr_braking;

		// Token: 0x04001789 RID: 6025
		private static readonly System.IntPtr NativeFieldInfoPtr_syncVar____JumpBuildAmount_k__BackingField;

		// Token: 0x0400178A RID: 6026
		private static readonly System.IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

		// Token: 0x0400178B RID: 6027
		private static readonly System.IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

		// Token: 0x0400178C RID: 6028
		private static readonly System.IntPtr NativeMethodInfoPtr_get_CurrentSteerInput_Public_get_Single_0;

		// Token: 0x0400178D RID: 6029
		private static readonly System.IntPtr NativeMethodInfoPtr_set_CurrentSteerInput_Protected_set_Void_Single_0;

		// Token: 0x0400178E RID: 6030
		private static readonly System.IntPtr NativeMethodInfoPtr_get_IsPushing_Public_get_Boolean_0;

		// Token: 0x0400178F RID: 6031
		private static readonly System.IntPtr NativeMethodInfoPtr_get_TimeSincePushStart_Public_get_Single_0;

		// Token: 0x04001790 RID: 6032
		private static readonly System.IntPtr NativeMethodInfoPtr_get_isGrounded_Public_get_Boolean_0;

		// Token: 0x04001791 RID: 6033
		private static readonly System.IntPtr NativeMethodInfoPtr_get_AirTime_Public_get_Single_0;

		// Token: 0x04001792 RID: 6034
		private static readonly System.IntPtr NativeMethodInfoPtr_get_JumpBuildAmount_Public_get_Single_0;

		// Token: 0x04001793 RID: 6035
		private static readonly System.IntPtr NativeMethodInfoPtr_set_JumpBuildAmount_Public_set_Void_Single_0;

		// Token: 0x04001794 RID: 6036
		private static readonly System.IntPtr NativeMethodInfoPtr_get_Rider_Public_get_Player_0;

		// Token: 0x04001795 RID: 6037
		private static readonly System.IntPtr NativeMethodInfoPtr_set_Rider_Private_set_Void_Player_0;

		// Token: 0x04001796 RID: 6038
		private static readonly System.IntPtr NativeMethodInfoPtr_get_TopSpeed_Ms_Public_get_Single_0;

		// Token: 0x04001797 RID: 6039
		private static readonly System.IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;

		// Token: 0x04001798 RID: 6040
		private static readonly System.IntPtr NativeMethodInfoPtr_OnStartClient_Public_Virtual_Void_0;

		// Token: 0x04001799 RID: 6041
		private static readonly System.IntPtr NativeMethodInfoPtr_Update_Public_Void_0;

		// Token: 0x0400179A RID: 6042
		private static readonly System.IntPtr NativeMethodInfoPtr_GetInput_Private_Void_1;

		// Token: 0x0400179B RID: 6043
		private static readonly System.IntPtr NativeMethodInfoPtr_FixedUpdate_Private_Void_1;

		// Token: 0x0400179C RID: 6044
		private static readonly System.IntPtr NativeMethodInfoPtr_LateUpdate_Private_Void_1;

		// Token: 0x0400179D RID: 6045
		private static readonly System.IntPtr NativeMethodInfoPtr_ApplyInput_Private_Void_1;

		// Token: 0x0400179E RID: 6046
		private static readonly System.IntPtr NativeMethodInfoPtr_ApplyLateralFriction_Private_Void_1;

		// Token: 0x0400179F RID: 6047
		private static readonly System.IntPtr NativeMethodInfoPtr_UpdateHover_Private_Void_1;

		// Token: 0x040017A0 RID: 6048
		private static readonly System.IntPtr NativeMethodInfoPtr_ApplyGravity_Private_Void_1;

		// Token: 0x040017A1 RID: 6049
		private static readonly System.IntPtr NativeMethodInfoPtr_CheckGrounded_Private_Void_1;

		// Token: 0x040017A2 RID: 6050
		private static readonly System.IntPtr NativeMethodInfoPtr_CheckJump_Private_Void_1;

		// Token: 0x040017A3 RID: 6051
		private static readonly System.IntPtr NativeMethodInfoPtr_SendJump_Private_Void_Single_0;

		// Token: 0x040017A4 RID: 6052
		private static readonly System.IntPtr NativeMethodInfoPtr_ReceiveJump_Private_Void_Single_0;

		// Token: 0x040017A5 RID: 6053
		private static readonly System.IntPtr NativeMethodInfoPtr_Jump_Private_Void_1;

		// Token: 0x040017A6 RID: 6054
		private static readonly System.IntPtr NativeMethodInfoPtr_Push_Private_Void_1;

		// Token: 0x040017A7 RID: 6055
		private static readonly System.IntPtr NativeMethodInfoPtr_IsGrounded_Public_Boolean_0;

		// Token: 0x040017A8 RID: 6056
		private static readonly System.IntPtr NativeMethodInfoPtr_IsGrounded_Public_Boolean_byref_RaycastHit_0;

		// Token: 0x040017A9 RID: 6057
		private static readonly System.IntPtr NativeMethodInfoPtr_SetVelocity_Public_Void_Vector3_0;

		// Token: 0x040017AA RID: 6058
		private static readonly System.IntPtr NativeMethodInfoPtr_ClampRotation_Private_Void_1;

		// Token: 0x040017AB RID: 6059
		private static readonly System.IntPtr NativeMethodInfoPtr_ApplyPlayerScale_Public_Void_0;

		// Token: 0x040017AC RID: 6060
		private static readonly System.IntPtr NativeMethodInfoPtr_GetSurfaceSmoothness_Public_Single_0;

		// Token: 0x040017AD RID: 6061
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040017AE RID: 6062
		private static readonly System.IntPtr NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0;

		// Token: 0x040017AF RID: 6063
		private static readonly System.IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

		// Token: 0x040017B0 RID: 6064
		private static readonly System.IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

		// Token: 0x040017B1 RID: 6065
		private static readonly System.IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

		// Token: 0x040017B2 RID: 6066
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcWriter___Server_set_JumpBuildAmount_431000436_Private_Void_Single_0;

		// Token: 0x040017B3 RID: 6067
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcLogic___set_JumpBuildAmount_431000436_Public_Void_Single_0;

		// Token: 0x040017B4 RID: 6068
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcReader___Server_set_JumpBuildAmount_431000436_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x040017B5 RID: 6069
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcWriter___Server_SendJump_431000436_Private_Void_Single_0;

		// Token: 0x040017B6 RID: 6070
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcLogic___SendJump_431000436_Private_Void_Single_0;

		// Token: 0x040017B7 RID: 6071
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcReader___Server_SendJump_431000436_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x040017B8 RID: 6072
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcWriter___Observers_ReceiveJump_431000436_Private_Void_Single_0;

		// Token: 0x040017B9 RID: 6073
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcLogic___ReceiveJump_431000436_Private_Void_Single_0;

		// Token: 0x040017BA RID: 6074
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcReader___Observers_ReceiveJump_431000436_Private_Void_PooledReader_Channel_0;

		// Token: 0x040017BB RID: 6075
		private static readonly System.IntPtr NativeMethodInfoPtr_sync___get_value__JumpBuildAmount_k__BackingField_Public_get_Single_0;

		// Token: 0x040017BC RID: 6076
		private static readonly System.IntPtr NativeMethodInfoPtr_sync___set_value__JumpBuildAmount_k__BackingField_Public_set_Void_Single_Boolean_0;

		// Token: 0x040017BD RID: 6077
		private static readonly System.IntPtr NativeMethodInfoPtr_ReadSyncVar___ScheduleOne_Skating_Skateboard_Public_Virtual_Boolean_PooledReader_UInt32_Boolean_0;

		// Token: 0x040017BE RID: 6078
		private static readonly System.IntPtr NativeMethodInfoPtr_Method_Private_Void_0;

		// Token: 0x020008F8 RID: 2296
		[ObfuscatedName("ScheduleOne.Skating.Skateboard+<<Push>g__Push|113_0>d")]
		public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSkSiObObUnique : Il2CppSystem.Object
		{
			// Token: 0x0600C821 RID: 51233 RVA: 0x0030F32C File Offset: 0x0030D52C
			// Note: this type is marked as 'beforefieldinit'.
			static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSkSiObObUnique()
			{
				Il2CppClassPointerStore<Skateboard.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSkSiObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, "<<Push>g__Push|113_0>d");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Skateboard.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSkSiObObUnique>.NativeClassPtr);
				Skateboard.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSkSiObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSkSiObObUnique>.NativeClassPtr, "<>1__state");
				Skateboard.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSkSiObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSkSiObObUnique>.NativeClassPtr, "<>2__current");
				Skateboard.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSkSiObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSkSiObObUnique>.NativeClassPtr, "<>4__this");
				Skateboard.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSkSiObObUnique.NativeFieldInfoPtr__i_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSkSiObObUnique>.NativeClassPtr, "<i>5__2");
				Skateboard.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSkSiObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Skateboard.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSkSiObObUnique>.NativeClassPtr, 100667327);
				Skateboard.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSkSiObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Skateboard.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSkSiObObUnique>.NativeClassPtr, 100667328);
				Skateboard.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSkSiObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Skateboard.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSkSiObObUnique>.NativeClassPtr, 100667329);
				Skateboard.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSkSiObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Skateboard.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSkSiObObUnique>.NativeClassPtr, 100667330);
				Skateboard.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSkSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Skateboard.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSkSiObObUnique>.NativeClassPtr, 100667331);
				Skateboard.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSkSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Skateboard.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSkSiObObUnique>.NativeClassPtr, 100667332);
			}

			// Token: 0x0600C822 RID: 51234 RVA: 0x0030F420 File Offset: 0x0030D620
			[CallerCount(54)]
			[CachedScanResults(RefRangeStart = 2646, RefRangeEnd = 2700, XrefRangeStart = 2646, XrefRangeEnd = 2700, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSkSiObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Skateboard.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSkSiObObUnique>.NativeClassPtr))
			{
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = ref <>1__state;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Skateboard.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSkSiObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600C823 RID: 51235 RVA: 0x0030F468 File Offset: 0x0030D668
			[CallerCount(14558)]
			[CachedScanResults(RefRangeStart = 2769, RefRangeEnd = 17327, XrefRangeStart = 2769, XrefRangeEnd = 17327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Skateboard.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSkSiObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600C824 RID: 51236 RVA: 0x0030F49C File Offset: 0x0030D69C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 115232, XrefRangeEnd = 115241, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Skateboard.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSkSiObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x17003E35 RID: 15925
			// (get) Token: 0x0600C825 RID: 51237 RVA: 0x0030F4D8 File Offset: 0x0030D6D8
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 2740, RefRangeEnd = 2764, XrefRangeStart = 2740, XrefRangeEnd = 2764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Skateboard.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSkSiObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
			}

			// Token: 0x0600C826 RID: 51238 RVA: 0x0030F518 File Offset: 0x0030D718
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 115241, XrefRangeEnd = 115246, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Skateboard.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSkSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x17003E36 RID: 15926
			// (get) Token: 0x0600C827 RID: 51239 RVA: 0x0030F54C File Offset: 0x0030D74C
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 2740, RefRangeEnd = 2764, XrefRangeStart = 2740, XrefRangeEnd = 2764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Skateboard.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSkSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
			}

			// Token: 0x0600C828 RID: 51240 RVA: 0x000610C4 File Offset: 0x0005F2C4
			public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSkSiObObUnique(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003E31 RID: 15921
			// (get) Token: 0x0600C829 RID: 51241 RVA: 0x0030F58C File Offset: 0x0030D78C
			// (set) Token: 0x0600C82A RID: 51242 RVA: 0x000610CD File Offset: 0x0005F2CD
			public unsafe int __1__state
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSkSiObObUnique.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSkSiObObUnique.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17003E32 RID: 15922
			// (get) Token: 0x0600C82B RID: 51243 RVA: 0x0030F5B4 File Offset: 0x0030D7B4
			// (set) Token: 0x0600C82C RID: 51244 RVA: 0x000610E8 File Offset: 0x0005F2E8
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSkSiObObUnique.NativeFieldInfoPtr___2__current);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSkSiObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003E33 RID: 15923
			// (get) Token: 0x0600C82D RID: 51245 RVA: 0x0030F5E4 File Offset: 0x0030D7E4
			// (set) Token: 0x0600C82E RID: 51246 RVA: 0x00061107 File Offset: 0x0005F307
			public unsafe Skateboard __4__this
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSkSiObObUnique.NativeFieldInfoPtr___4__this);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Skateboard>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSkSiObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003E34 RID: 15924
			// (get) Token: 0x0600C82F RID: 51247 RVA: 0x0030F614 File Offset: 0x0030D814
			// (set) Token: 0x0600C830 RID: 51248 RVA: 0x00061126 File Offset: 0x0005F326
			public unsafe float _i_5__2
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSkSiObObUnique.NativeFieldInfoPtr__i_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSkSiObObUnique.NativeFieldInfoPtr__i_5__2)) = value;
				}
			}

			// Token: 0x040087C8 RID: 34760
			private static readonly System.IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040087C9 RID: 34761
			private static readonly System.IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040087CA RID: 34762
			private static readonly System.IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040087CB RID: 34763
			private static readonly System.IntPtr NativeFieldInfoPtr__i_5__2;

			// Token: 0x040087CC RID: 34764
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040087CD RID: 34765
			private static readonly System.IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040087CE RID: 34766
			private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040087CF RID: 34767
			private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040087D0 RID: 34768
			private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040087D1 RID: 34769
			private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x020008F9 RID: 2297
		[ObfuscatedName("ScheduleOne.Skating.Skateboard+<>c__DisplayClass112_0")]
		public sealed class __c__DisplayClass112_0 : Il2CppSystem.Object
		{
			// Token: 0x0600C831 RID: 51249 RVA: 0x0030F63C File Offset: 0x0030D83C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass112_0()
			{
				Il2CppClassPointerStore<Skateboard.__c__DisplayClass112_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Skateboard>.NativeClassPtr, "<>c__DisplayClass112_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Skateboard.__c__DisplayClass112_0>.NativeClassPtr);
				Skateboard.__c__DisplayClass112_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard.__c__DisplayClass112_0>.NativeClassPtr, "<>4__this");
				Skateboard.__c__DisplayClass112_0.NativeFieldInfoPtr_JumpDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard.__c__DisplayClass112_0>.NativeClassPtr, "JumpDuration");
				Skateboard.__c__DisplayClass112_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Skateboard.__c__DisplayClass112_0>.NativeClassPtr, 100667333);
				Skateboard.__c__DisplayClass112_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Skateboard.__c__DisplayClass112_0>.NativeClassPtr, 100667334);
			}

			// Token: 0x0600C832 RID: 51250 RVA: 0x0030F6B8 File Offset: 0x0030D8B8
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass112_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Skateboard.__c__DisplayClass112_0>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Skateboard.__c__DisplayClass112_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600C833 RID: 51251 RVA: 0x0030F6F4 File Offset: 0x0030D8F4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 115264, XrefRangeEnd = 115269, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator Method_Internal_IEnumerator_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Skateboard.__c__DisplayClass112_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr2) : null;
			}

			// Token: 0x0600C834 RID: 51252 RVA: 0x00061141 File Offset: 0x0005F341
			public __c__DisplayClass112_0(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003E37 RID: 15927
			// (get) Token: 0x0600C835 RID: 51253 RVA: 0x0030F734 File Offset: 0x0030D934
			// (set) Token: 0x0600C836 RID: 51254 RVA: 0x0006114A File Offset: 0x0005F34A
			public unsafe Skateboard __4__this
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.__c__DisplayClass112_0.NativeFieldInfoPtr___4__this);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Skateboard>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.__c__DisplayClass112_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003E38 RID: 15928
			// (get) Token: 0x0600C837 RID: 51255 RVA: 0x0030F764 File Offset: 0x0030D964
			// (set) Token: 0x0600C838 RID: 51256 RVA: 0x00061169 File Offset: 0x0005F369
			public unsafe float JumpDuration
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.__c__DisplayClass112_0.NativeFieldInfoPtr_JumpDuration);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.__c__DisplayClass112_0.NativeFieldInfoPtr_JumpDuration)) = value;
				}
			}

			// Token: 0x040087D2 RID: 34770
			private static readonly System.IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040087D3 RID: 34771
			private static readonly System.IntPtr NativeFieldInfoPtr_JumpDuration;

			// Token: 0x040087D4 RID: 34772
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040087D5 RID: 34773
			private static readonly System.IntPtr NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0;

			// Token: 0x02000C8D RID: 3213
			[ObfuscatedName("ScheduleOne.Skating.Skateboard+<>c__DisplayClass112_0+<<Jump>g__Jump|0>d")]
			public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique : Il2CppSystem.Object
			{
				// Token: 0x0600E6E7 RID: 59111 RVA: 0x00366614 File Offset: 0x00364814
				// Note: this type is marked as 'beforefieldinit'.
				static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique()
				{
					Il2CppClassPointerStore<Skateboard.__c__DisplayClass112_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Skateboard.__c__DisplayClass112_0>.NativeClassPtr, "<<Jump>g__Jump|0>d");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Skateboard.__c__DisplayClass112_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr);
					Skateboard.__c__DisplayClass112_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard.__c__DisplayClass112_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr, "<>1__state");
					Skateboard.__c__DisplayClass112_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard.__c__DisplayClass112_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr, "<>2__current");
					Skateboard.__c__DisplayClass112_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard.__c__DisplayClass112_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr, "<>4__this");
					Skateboard.__c__DisplayClass112_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeFieldInfoPtr__i_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard.__c__DisplayClass112_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr, "<i>5__2");
					Skateboard.__c__DisplayClass112_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Skateboard.__c__DisplayClass112_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr, 100667335);
					Skateboard.__c__DisplayClass112_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Skateboard.__c__DisplayClass112_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr, 100667336);
					Skateboard.__c__DisplayClass112_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Skateboard.__c__DisplayClass112_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr, 100667337);
					Skateboard.__c__DisplayClass112_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Skateboard.__c__DisplayClass112_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr, 100667338);
					Skateboard.__c__DisplayClass112_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Skateboard.__c__DisplayClass112_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr, 100667339);
					Skateboard.__c__DisplayClass112_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Skateboard.__c__DisplayClass112_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr, 100667340);
				}

				// Token: 0x0600E6E8 RID: 59112 RVA: 0x00366708 File Offset: 0x00364908
				[CallerCount(54)]
				[CachedScanResults(RefRangeStart = 2646, RefRangeEnd = 2700, XrefRangeStart = 2646, XrefRangeEnd = 2700, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Skateboard.__c__DisplayClass112_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr))
				{
					System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
					*ptr = ref <>1__state;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Skateboard.__c__DisplayClass112_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				}

				// Token: 0x0600E6E9 RID: 59113 RVA: 0x00366750 File Offset: 0x00364950
				[CallerCount(14558)]
				[CachedScanResults(RefRangeStart = 2769, RefRangeEnd = 17327, XrefRangeStart = 2769, XrefRangeEnd = 17327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Skateboard.__c__DisplayClass112_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				}

				// Token: 0x0600E6EA RID: 59114 RVA: 0x00366784 File Offset: 0x00364984
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 115246, XrefRangeEnd = 115259, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Skateboard.__c__DisplayClass112_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
					return *IL2CPP.il2cpp_object_unbox(obj);
				}

				// Token: 0x1700473B RID: 18235
				// (get) Token: 0x0600E6EB RID: 59115 RVA: 0x003667C0 File Offset: 0x003649C0
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(24)]
					[CachedScanResults(RefRangeStart = 2740, RefRangeEnd = 2764, XrefRangeStart = 2740, XrefRangeEnd = 2764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						System.IntPtr* param = null;
						System.IntPtr returnedException;
						System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Skateboard.__c__DisplayClass112_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
						Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
						System.IntPtr intPtr2 = intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
				}

				// Token: 0x0600E6EC RID: 59116 RVA: 0x00366800 File Offset: 0x00364A00
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 115259, XrefRangeEnd = 115264, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Skateboard.__c__DisplayClass112_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				}

				// Token: 0x1700473C RID: 18236
				// (get) Token: 0x0600E6ED RID: 59117 RVA: 0x00366834 File Offset: 0x00364A34
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(24)]
					[CachedScanResults(RefRangeStart = 2740, RefRangeEnd = 2764, XrefRangeStart = 2740, XrefRangeEnd = 2764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						System.IntPtr* param = null;
						System.IntPtr returnedException;
						System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Skateboard.__c__DisplayClass112_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
						Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
						System.IntPtr intPtr2 = intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
				}

				// Token: 0x0600E6EE RID: 59118 RVA: 0x00070452 File Offset: 0x0006E652
				public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique(System.IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x17004737 RID: 18231
				// (get) Token: 0x0600E6EF RID: 59119 RVA: 0x00366874 File Offset: 0x00364A74
				// (set) Token: 0x0600E6F0 RID: 59120 RVA: 0x0007045B File Offset: 0x0006E65B
				public unsafe int __1__state
				{
					get
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.__c__DisplayClass112_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.__c__DisplayClass112_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x17004738 RID: 18232
				// (get) Token: 0x0600E6F1 RID: 59121 RVA: 0x0036689C File Offset: 0x00364A9C
				// (set) Token: 0x0600E6F2 RID: 59122 RVA: 0x00070476 File Offset: 0x0006E676
				public unsafe Il2CppSystem.Object __2__current
				{
					get
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.__c__DisplayClass112_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeFieldInfoPtr___2__current);
						System.IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
					set
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.__c__DisplayClass112_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17004739 RID: 18233
				// (get) Token: 0x0600E6F3 RID: 59123 RVA: 0x003668CC File Offset: 0x00364ACC
				// (set) Token: 0x0600E6F4 RID: 59124 RVA: 0x00070495 File Offset: 0x0006E695
				public unsafe Skateboard.__c__DisplayClass112_0 __4__this
				{
					get
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.__c__DisplayClass112_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeFieldInfoPtr___4__this);
						System.IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Skateboard.__c__DisplayClass112_0>(intPtr2) : null;
					}
					set
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.__c__DisplayClass112_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x1700473A RID: 18234
				// (get) Token: 0x0600E6F5 RID: 59125 RVA: 0x003668FC File Offset: 0x00364AFC
				// (set) Token: 0x0600E6F6 RID: 59126 RVA: 0x000704B4 File Offset: 0x0006E6B4
				public unsafe float _i_5__2
				{
					get
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.__c__DisplayClass112_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeFieldInfoPtr__i_5__2);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard.__c__DisplayClass112_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeFieldInfoPtr__i_5__2)) = value;
					}
				}

				// Token: 0x04009AA5 RID: 39589
				private static readonly System.IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x04009AA6 RID: 39590
				private static readonly System.IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x04009AA7 RID: 39591
				private static readonly System.IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x04009AA8 RID: 39592
				private static readonly System.IntPtr NativeFieldInfoPtr__i_5__2;

				// Token: 0x04009AA9 RID: 39593
				private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x04009AAA RID: 39594
				private static readonly System.IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x04009AAB RID: 39595
				private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x04009AAC RID: 39596
				private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x04009AAD RID: 39597
				private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x04009AAE RID: 39598
				private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
			}
		}
	}
}
