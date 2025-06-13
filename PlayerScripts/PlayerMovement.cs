using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using Il2CppScheduleOne.Vehicles;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace Il2CppScheduleOne.PlayerScripts
{
	// Token: 0x02000409 RID: 1033
	public class PlayerMovement : PlayerSingleton<PlayerMovement>
	{
		// Token: 0x060052E4 RID: 21220 RVA: 0x0018BBF0 File Offset: 0x00189DF0
		// Note: this type is marked as 'beforefieldinit'.
		static PlayerMovement()
		{
			Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.PlayerScripts", "PlayerMovement");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr);
			PlayerMovement.NativeFieldInfoPtr_DEV_SPRINT_MULTIPLIER = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, "DEV_SPRINT_MULTIPLIER");
			PlayerMovement.NativeFieldInfoPtr_GROUNDED_THRESHOLD = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, "GROUNDED_THRESHOLD");
			PlayerMovement.NativeFieldInfoPtr_SLOPE_THRESHOLD = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, "SLOPE_THRESHOLD");
			PlayerMovement.NativeFieldInfoPtr_WalkSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, "WalkSpeed");
			PlayerMovement.NativeFieldInfoPtr_SprintMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, "SprintMultiplier");
			PlayerMovement.NativeFieldInfoPtr_StaticMoveSpeedMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, "StaticMoveSpeedMultiplier");
			PlayerMovement.NativeFieldInfoPtr_StaminaRestoreDelay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, "StaminaRestoreDelay");
			PlayerMovement.NativeFieldInfoPtr_JumpMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, "JumpMultiplier");
			PlayerMovement.NativeFieldInfoPtr_ControllerRadius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, "ControllerRadius");
			PlayerMovement.NativeFieldInfoPtr_StandingControllerHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, "StandingControllerHeight");
			PlayerMovement.NativeFieldInfoPtr_CrouchHeightMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, "CrouchHeightMultiplier");
			PlayerMovement.NativeFieldInfoPtr_CrouchTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, "CrouchTime");
			PlayerMovement.NativeFieldInfoPtr__GravityMultiplier_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, "<GravityMultiplier>k__BackingField");
			PlayerMovement.NativeFieldInfoPtr_StaminaDrainRate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, "StaminaDrainRate");
			PlayerMovement.NativeFieldInfoPtr_StaminaRestoreRate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, "StaminaRestoreRate");
			PlayerMovement.NativeFieldInfoPtr_StaminaReserveMax = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, "StaminaReserveMax");
			PlayerMovement.NativeFieldInfoPtr_SprintChangeRate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, "SprintChangeRate");
			PlayerMovement.NativeFieldInfoPtr_Player = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, "Player");
			PlayerMovement.NativeFieldInfoPtr_Controller = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, "Controller");
			PlayerMovement.NativeFieldInfoPtr_sensitivity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, "sensitivity");
			PlayerMovement.NativeFieldInfoPtr_dead = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, "dead");
			PlayerMovement.NativeFieldInfoPtr_canMove = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, "canMove");
			PlayerMovement.NativeFieldInfoPtr_canJump = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, "canJump");
			PlayerMovement.NativeFieldInfoPtr_SprintingRequiresStamina = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, "SprintingRequiresStamina");
			PlayerMovement.NativeFieldInfoPtr_MoveSpeedMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, "MoveSpeedMultiplier");
			PlayerMovement.NativeFieldInfoPtr_SlipperyMovementMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, "SlipperyMovementMultiplier");
			PlayerMovement.NativeFieldInfoPtr_ForceSprint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, "ForceSprint");
			PlayerMovement.NativeFieldInfoPtr_jumpForce = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, "jumpForce");
			PlayerMovement.NativeFieldInfoPtr_gravityMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, "gravityMultiplier");
			PlayerMovement.NativeFieldInfoPtr_groundDetectionMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, "groundDetectionMask");
			PlayerMovement.NativeFieldInfoPtr_slopeForce = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, "slopeForce");
			PlayerMovement.NativeFieldInfoPtr_slopeForceRayLength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, "slopeForceRayLength");
			PlayerMovement.NativeFieldInfoPtr_crouchSpeedMultipler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, "crouchSpeedMultipler");
			PlayerMovement.NativeFieldInfoPtr_Crouched_VigIntensity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, "Crouched_VigIntensity");
			PlayerMovement.NativeFieldInfoPtr_Crouched_VigSmoothness = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, "Crouched_VigSmoothness");
			PlayerMovement.NativeFieldInfoPtr_visibilityPointsToScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, "visibilityPointsToScale");
			PlayerMovement.NativeFieldInfoPtr_originalVisibilityPointOffsets = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, "originalVisibilityPointOffsets");
			PlayerMovement.NativeFieldInfoPtr__playerHeight_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, "<playerHeight>k__BackingField");
			PlayerMovement.NativeFieldInfoPtr_movement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, "movement");
			PlayerMovement.NativeFieldInfoPtr_movementY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, "movementY");
			PlayerMovement.NativeFieldInfoPtr__currentVehicle_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, "<currentVehicle>k__BackingField");
			PlayerMovement.NativeFieldInfoPtr_recentlyDrivenVehicles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, "recentlyDrivenVehicles");
			PlayerMovement.NativeFieldInfoPtr_isJumping = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, "isJumping");
			PlayerMovement.NativeFieldInfoPtr__airTime_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, "<airTime>k__BackingField");
			PlayerMovement.NativeFieldInfoPtr__isCrouched_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, "<isCrouched>k__BackingField");
			PlayerMovement.NativeFieldInfoPtr__standingScale_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, "<standingScale>k__BackingField");
			PlayerMovement.NativeFieldInfoPtr__isRagdolled_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, "<isRagdolled>k__BackingField");
			PlayerMovement.NativeFieldInfoPtr__isSprinting_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, "<isSprinting>k__BackingField");
			PlayerMovement.NativeFieldInfoPtr__CurrentSprintMultiplier_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, "<CurrentSprintMultiplier>k__BackingField");
			PlayerMovement.NativeFieldInfoPtr_CurrentStaminaReserve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, "CurrentStaminaReserve");
			PlayerMovement.NativeFieldInfoPtr__IsGrounded_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, "<IsGrounded>k__BackingField");
			PlayerMovement.NativeFieldInfoPtr_onStaminaReserveChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, "onStaminaReserveChanged");
			PlayerMovement.NativeFieldInfoPtr_onJump = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, "onJump");
			PlayerMovement.NativeFieldInfoPtr_onLand = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, "onLand");
			PlayerMovement.NativeFieldInfoPtr_onCrouch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, "onCrouch");
			PlayerMovement.NativeFieldInfoPtr_onUncrouch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, "onUncrouch");
			PlayerMovement.NativeFieldInfoPtr_horizontalAxis = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, "horizontalAxis");
			PlayerMovement.NativeFieldInfoPtr_verticalAxis = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, "verticalAxis");
			PlayerMovement.NativeFieldInfoPtr_timeGrounded = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, "timeGrounded");
			PlayerMovement.NativeFieldInfoPtr_movementEvents = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, "movementEvents");
			PlayerMovement.NativeFieldInfoPtr_timeSinceStaminaDrain = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, "timeSinceStaminaDrain");
			PlayerMovement.NativeFieldInfoPtr_sprintActive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, "sprintActive");
			PlayerMovement.NativeFieldInfoPtr_sprintReleased = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, "sprintReleased");
			PlayerMovement.NativeFieldInfoPtr_residualVelocityDirection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, "residualVelocityDirection");
			PlayerMovement.NativeFieldInfoPtr_residualVelocityForce = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, "residualVelocityForce");
			PlayerMovement.NativeFieldInfoPtr_residualVelocityDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, "residualVelocityDuration");
			PlayerMovement.NativeFieldInfoPtr_residualVelocityTimeRemaining = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, "residualVelocityTimeRemaining");
			PlayerMovement.NativeFieldInfoPtr_teleport = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, "teleport");
			PlayerMovement.NativeFieldInfoPtr_teleportPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, "teleportPosition");
			PlayerMovement.NativeFieldInfoPtr_sprintBlockers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, "sprintBlockers");
			PlayerMovement.NativeFieldInfoPtr_lastFrameMovement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, "lastFrameMovement");
			PlayerMovement.NativeFieldInfoPtr_playerRotCoroutine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, "playerRotCoroutine");
			PlayerMovement.NativeMethodInfoPtr_get_GravityMultiplier_Public_Static_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, 100673788);
			PlayerMovement.NativeMethodInfoPtr_set_GravityMultiplier_Public_Static_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, 100673789);
			PlayerMovement.NativeMethodInfoPtr_get_playerHeight_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, 100673790);
			PlayerMovement.NativeMethodInfoPtr_set_playerHeight_Protected_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, 100673791);
			PlayerMovement.NativeMethodInfoPtr_get_Movement_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, 100673792);
			PlayerMovement.NativeMethodInfoPtr_get_currentVehicle_Public_get_LandVehicle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, 100673793);
			PlayerMovement.NativeMethodInfoPtr_set_currentVehicle_Protected_set_Void_LandVehicle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, 100673794);
			PlayerMovement.NativeMethodInfoPtr_get_airTime_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, 100673795);
			PlayerMovement.NativeMethodInfoPtr_set_airTime_Protected_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, 100673796);
			PlayerMovement.NativeMethodInfoPtr_get_isCrouched_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, 100673797);
			PlayerMovement.NativeMethodInfoPtr_set_isCrouched_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, 100673798);
			PlayerMovement.NativeMethodInfoPtr_get_standingScale_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, 100673799);
			PlayerMovement.NativeMethodInfoPtr_set_standingScale_Protected_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, 100673800);
			PlayerMovement.NativeMethodInfoPtr_get_isRagdolled_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, 100673801);
			PlayerMovement.NativeMethodInfoPtr_set_isRagdolled_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, 100673802);
			PlayerMovement.NativeMethodInfoPtr_get_isSprinting_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, 100673803);
			PlayerMovement.NativeMethodInfoPtr_set_isSprinting_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, 100673804);
			PlayerMovement.NativeMethodInfoPtr_get_CurrentSprintMultiplier_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, 100673805);
			PlayerMovement.NativeMethodInfoPtr_set_CurrentSprintMultiplier_Protected_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, 100673806);
			PlayerMovement.NativeMethodInfoPtr_get_IsGrounded_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, 100673807);
			PlayerMovement.NativeMethodInfoPtr_set_IsGrounded_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, 100673808);
			PlayerMovement.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, 100673809);
			PlayerMovement.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, 100673810);
			PlayerMovement.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, 100673811);
			PlayerMovement.NativeMethodInfoPtr_FixedUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, 100673812);
			PlayerMovement.NativeMethodInfoPtr_LateUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, 100673813);
			PlayerMovement.NativeMethodInfoPtr_Move_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, 100673814);
			PlayerMovement.NativeMethodInfoPtr_ClampMovement_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, 100673815);
			PlayerMovement.NativeMethodInfoPtr_GetSurfaceAngle_Protected_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, 100673816);
			PlayerMovement.NativeMethodInfoPtr_isGrounded_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, 100673817);
			PlayerMovement.NativeMethodInfoPtr_UpdateHorizontalAxis_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, 100673818);
			PlayerMovement.NativeMethodInfoPtr_UpdateVerticalAxis_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, 100673819);
			PlayerMovement.NativeMethodInfoPtr_Jump_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, 100673820);
			PlayerMovement.NativeMethodInfoPtr_TryToggleCrouch_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, 100673821);
			PlayerMovement.NativeMethodInfoPtr_CanStand_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, 100673822);
			PlayerMovement.NativeMethodInfoPtr_SetCrouched_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, 100673823);
			PlayerMovement.NativeMethodInfoPtr_UpdateCrouchVignetteEffect_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, 100673824);
			PlayerMovement.NativeMethodInfoPtr_UpdatePlayerHeight_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, 100673825);
			PlayerMovement.NativeMethodInfoPtr_LerpPlayerRotation_Public_Void_Quaternion_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, 100673826);
			PlayerMovement.NativeMethodInfoPtr_LerpPlayerRotation_Process_Private_IEnumerator_Quaternion_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, 100673827);
			PlayerMovement.NativeMethodInfoPtr_EnterVehicle_Private_Void_LandVehicle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, 100673828);
			PlayerMovement.NativeMethodInfoPtr_ExitVehicle_Private_Void_LandVehicle_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, 100673829);
			PlayerMovement.NativeMethodInfoPtr_Teleport_Public_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, 100673830);
			PlayerMovement.NativeMethodInfoPtr_SetResidualVelocity_Public_Void_Vector3_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, 100673831);
			PlayerMovement.NativeMethodInfoPtr_WarpToNavMesh_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, 100673832);
			PlayerMovement.NativeMethodInfoPtr_RegisterMovementEvent_Public_Void_Int32_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, 100673833);
			PlayerMovement.NativeMethodInfoPtr_DeregisterMovementEvent_Public_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, 100673834);
			PlayerMovement.NativeMethodInfoPtr_UpdateMovementEvents_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, 100673835);
			PlayerMovement.NativeMethodInfoPtr_ChangeStamina_Public_Void_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, 100673836);
			PlayerMovement.NativeMethodInfoPtr_SetStamina_Public_Void_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, 100673837);
			PlayerMovement.NativeMethodInfoPtr_AddSprintBlocker_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, 100673838);
			PlayerMovement.NativeMethodInfoPtr_RemoveSprintBlocker_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, 100673839);
			PlayerMovement.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, 100673840);
			PlayerMovement.NativeMethodInfoPtr__Start_b__105_0_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, 100673842);
		}

		// Token: 0x170018FB RID: 6395
		// (get) Token: 0x060052E5 RID: 21221 RVA: 0x0018C5F8 File Offset: 0x0018A7F8
		// (set) Token: 0x060052E6 RID: 21222 RVA: 0x0018C628 File Offset: 0x0018A828
		public unsafe static float GravityMultiplier
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 181071, XrefRangeEnd = 181075, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(PlayerMovement.NativeMethodInfoPtr_get_GravityMultiplier_Public_Static_get_Single_0, 0, (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 181075, XrefRangeEnd = 181079, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = ref value;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerMovement.NativeMethodInfoPtr_set_GravityMultiplier_Public_Static_set_Void_Single_0, 0, (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x170018FC RID: 6396
		// (get) Token: 0x060052E7 RID: 21223 RVA: 0x0018C65C File Offset: 0x0018A85C
		// (set) Token: 0x060052E8 RID: 21224 RVA: 0x0018C698 File Offset: 0x0018A898
		public unsafe float playerHeight
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(PlayerMovement.NativeMethodInfoPtr_get_playerHeight_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
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
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerMovement.NativeMethodInfoPtr_set_playerHeight_Protected_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x170018FD RID: 6397
		// (get) Token: 0x060052E9 RID: 21225 RVA: 0x0018C6D8 File Offset: 0x0018A8D8
		public unsafe Vector3 Movement
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(PlayerMovement.NativeMethodInfoPtr_get_Movement_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
		}

		// Token: 0x170018FE RID: 6398
		// (get) Token: 0x060052EA RID: 21226 RVA: 0x0018C714 File Offset: 0x0018A914
		// (set) Token: 0x060052EB RID: 21227 RVA: 0x0018C754 File Offset: 0x0018A954
		public unsafe LandVehicle currentVehicle
		{
			[CallerCount(11)]
			[CachedScanResults(RefRangeStart = 32536, RefRangeEnd = 32547, XrefRangeStart = 32536, XrefRangeEnd = 32547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerMovement.NativeMethodInfoPtr_get_currentVehicle_Public_get_LandVehicle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LandVehicle>(intPtr2) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerMovement.NativeMethodInfoPtr_set_currentVehicle_Protected_set_Void_LandVehicle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x170018FF RID: 6399
		// (get) Token: 0x060052EC RID: 21228 RVA: 0x0018C798 File Offset: 0x0018A998
		// (set) Token: 0x060052ED RID: 21229 RVA: 0x0018C7D4 File Offset: 0x0018A9D4
		public unsafe float airTime
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(PlayerMovement.NativeMethodInfoPtr_get_airTime_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
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
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerMovement.NativeMethodInfoPtr_set_airTime_Protected_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x17001900 RID: 6400
		// (get) Token: 0x060052EE RID: 21230 RVA: 0x0018C814 File Offset: 0x0018AA14
		// (set) Token: 0x060052EF RID: 21231 RVA: 0x0018C850 File Offset: 0x0018AA50
		public unsafe bool isCrouched
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(PlayerMovement.NativeMethodInfoPtr_get_isCrouched_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
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
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerMovement.NativeMethodInfoPtr_set_isCrouched_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x17001901 RID: 6401
		// (get) Token: 0x060052F0 RID: 21232 RVA: 0x0018C890 File Offset: 0x0018AA90
		// (set) Token: 0x060052F1 RID: 21233 RVA: 0x0018C8CC File Offset: 0x0018AACC
		public unsafe float standingScale
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(PlayerMovement.NativeMethodInfoPtr_get_standingScale_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
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
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerMovement.NativeMethodInfoPtr_set_standingScale_Protected_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x17001902 RID: 6402
		// (get) Token: 0x060052F2 RID: 21234 RVA: 0x0018C90C File Offset: 0x0018AB0C
		// (set) Token: 0x060052F3 RID: 21235 RVA: 0x0018C948 File Offset: 0x0018AB48
		public unsafe bool isRagdolled
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(PlayerMovement.NativeMethodInfoPtr_get_isRagdolled_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
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
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerMovement.NativeMethodInfoPtr_set_isRagdolled_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x17001903 RID: 6403
		// (get) Token: 0x060052F4 RID: 21236 RVA: 0x0018C988 File Offset: 0x0018AB88
		// (set) Token: 0x060052F5 RID: 21237 RVA: 0x0018C9C4 File Offset: 0x0018ABC4
		public unsafe bool isSprinting
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(PlayerMovement.NativeMethodInfoPtr_get_isSprinting_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
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
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerMovement.NativeMethodInfoPtr_set_isSprinting_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x17001904 RID: 6404
		// (get) Token: 0x060052F6 RID: 21238 RVA: 0x0018CA04 File Offset: 0x0018AC04
		// (set) Token: 0x060052F7 RID: 21239 RVA: 0x0018CA40 File Offset: 0x0018AC40
		public unsafe float CurrentSprintMultiplier
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(PlayerMovement.NativeMethodInfoPtr_get_CurrentSprintMultiplier_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
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
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerMovement.NativeMethodInfoPtr_set_CurrentSprintMultiplier_Protected_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x17001905 RID: 6405
		// (get) Token: 0x060052F8 RID: 21240 RVA: 0x0018CA80 File Offset: 0x0018AC80
		// (set) Token: 0x060052F9 RID: 21241 RVA: 0x0018CABC File Offset: 0x0018ACBC
		public unsafe bool IsGrounded
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(PlayerMovement.NativeMethodInfoPtr_get_IsGrounded_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
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
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerMovement.NativeMethodInfoPtr_set_IsGrounded_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x060052FA RID: 21242 RVA: 0x0018CAFC File Offset: 0x0018ACFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 181079, XrefRangeEnd = 181095, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PlayerMovement.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060052FB RID: 21243 RVA: 0x0018CB38 File Offset: 0x0018AD38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 181095, XrefRangeEnd = 181138, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PlayerMovement.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060052FC RID: 21244 RVA: 0x0018CB74 File Offset: 0x0018AD74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 181138, XrefRangeEnd = 181161, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PlayerMovement.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060052FD RID: 21245 RVA: 0x0018CBB0 File Offset: 0x0018ADB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 181161, XrefRangeEnd = 181166, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FixedUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerMovement.NativeMethodInfoPtr_FixedUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060052FE RID: 21246 RVA: 0x0018CBE4 File Offset: 0x0018ADE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 181166, XrefRangeEnd = 181170, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LateUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerMovement.NativeMethodInfoPtr_LateUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060052FF RID: 21247 RVA: 0x0018CC18 File Offset: 0x0018AE18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 181170, XrefRangeEnd = 181317, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Move()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PlayerMovement.NativeMethodInfoPtr_Move_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005300 RID: 21248 RVA: 0x0018CC54 File Offset: 0x0018AE54
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 181322, RefRangeEnd = 181323, XrefRangeStart = 181317, XrefRangeEnd = 181322, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ClampMovement()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerMovement.NativeMethodInfoPtr_ClampMovement_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005301 RID: 21249 RVA: 0x0018CC88 File Offset: 0x0018AE88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 181323, XrefRangeEnd = 181332, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float GetSurfaceAngle()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(PlayerMovement.NativeMethodInfoPtr_GetSurfaceAngle_Protected_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06005302 RID: 21250 RVA: 0x0018CCC4 File Offset: 0x0018AEC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 181332, XrefRangeEnd = 181338, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool isGrounded()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(PlayerMovement.NativeMethodInfoPtr_isGrounded_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06005303 RID: 21251 RVA: 0x0018CD00 File Offset: 0x0018AF00
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 181354, RefRangeEnd = 181355, XrefRangeStart = 181338, XrefRangeEnd = 181354, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateHorizontalAxis()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerMovement.NativeMethodInfoPtr_UpdateHorizontalAxis_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005304 RID: 21252 RVA: 0x0018CD34 File Offset: 0x0018AF34
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 181371, RefRangeEnd = 181372, XrefRangeStart = 181355, XrefRangeEnd = 181371, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateVerticalAxis()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerMovement.NativeMethodInfoPtr_UpdateVerticalAxis_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005305 RID: 21253 RVA: 0x0018CD68 File Offset: 0x0018AF68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 181372, XrefRangeEnd = 181377, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator Jump()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerMovement.NativeMethodInfoPtr_Jump_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr2) : null;
		}

		// Token: 0x06005306 RID: 21254 RVA: 0x0018CDA8 File Offset: 0x0018AFA8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 181380, RefRangeEnd = 181382, XrefRangeStart = 181377, XrefRangeEnd = 181380, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void TryToggleCrouch()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerMovement.NativeMethodInfoPtr_TryToggleCrouch_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005307 RID: 21255 RVA: 0x0018CDDC File Offset: 0x0018AFDC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 181399, RefRangeEnd = 181400, XrefRangeStart = 181382, XrefRangeEnd = 181399, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool CanStand()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(PlayerMovement.NativeMethodInfoPtr_CanStand_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06005308 RID: 21256 RVA: 0x0018CE18 File Offset: 0x0018B018
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 181411, RefRangeEnd = 181414, XrefRangeStart = 181400, XrefRangeEnd = 181411, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetCrouched(bool c)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref c;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerMovement.NativeMethodInfoPtr_SetCrouched_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005309 RID: 21257 RVA: 0x0018CE58 File Offset: 0x0018B058
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 181430, RefRangeEnd = 181431, XrefRangeStart = 181414, XrefRangeEnd = 181430, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateCrouchVignetteEffect()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerMovement.NativeMethodInfoPtr_UpdateCrouchVignetteEffect_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600530A RID: 21258 RVA: 0x0018CE8C File Offset: 0x0018B08C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 181456, RefRangeEnd = 181457, XrefRangeStart = 181431, XrefRangeEnd = 181456, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdatePlayerHeight()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerMovement.NativeMethodInfoPtr_UpdatePlayerHeight_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600530B RID: 21259 RVA: 0x0018CEC0 File Offset: 0x0018B0C0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 181465, RefRangeEnd = 181466, XrefRangeStart = 181457, XrefRangeEnd = 181465, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LerpPlayerRotation(Quaternion rotation, float lerpTime)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref rotation;
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref lerpTime;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerMovement.NativeMethodInfoPtr_LerpPlayerRotation_Public_Void_Quaternion_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600530C RID: 21260 RVA: 0x0018CF0C File Offset: 0x0018B10C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 181466, XrefRangeEnd = 181471, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator LerpPlayerRotation_Process(Quaternion endRotation, float lerpTime)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref endRotation;
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref lerpTime;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerMovement.NativeMethodInfoPtr_LerpPlayerRotation_Process_Private_IEnumerator_Quaternion_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr2) : null;
		}

		// Token: 0x0600530D RID: 21261 RVA: 0x0018CF68 File Offset: 0x0018B168
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 181471, XrefRangeEnd = 181483, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EnterVehicle(LandVehicle vehicle)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(vehicle);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerMovement.NativeMethodInfoPtr_EnterVehicle_Private_Void_LandVehicle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600530E RID: 21262 RVA: 0x0018CFAC File Offset: 0x0018B1AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 181483, XrefRangeEnd = 181486, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ExitVehicle(LandVehicle veh, Transform exitPoint)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(veh);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(exitPoint);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerMovement.NativeMethodInfoPtr_ExitVehicle_Private_Void_LandVehicle_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600530F RID: 21263 RVA: 0x0018D000 File Offset: 0x0018B200
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 181503, RefRangeEnd = 181513, XrefRangeStart = 181486, XrefRangeEnd = 181503, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Teleport(Vector3 position)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref position;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerMovement.NativeMethodInfoPtr_Teleport_Public_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005310 RID: 21264 RVA: 0x0018D040 File Offset: 0x0018B240
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 181514, RefRangeEnd = 181517, XrefRangeStart = 181513, XrefRangeEnd = 181514, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetResidualVelocity(Vector3 dir, float force, float time)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref dir;
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref force;
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref time;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerMovement.NativeMethodInfoPtr_SetResidualVelocity_Public_Void_Vector3_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005311 RID: 21265 RVA: 0x0018D09C File Offset: 0x0018B29C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 181540, RefRangeEnd = 181541, XrefRangeStart = 181517, XrefRangeEnd = 181540, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WarpToNavMesh()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerMovement.NativeMethodInfoPtr_WarpToNavMesh_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005312 RID: 21266 RVA: 0x0018D0D0 File Offset: 0x0018B2D0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 181568, RefRangeEnd = 181570, XrefRangeStart = 181541, XrefRangeEnd = 181568, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RegisterMovementEvent(int threshold, Il2CppSystem.Action action)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref threshold;
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(action);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerMovement.NativeMethodInfoPtr_RegisterMovementEvent_Public_Void_Int32_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005313 RID: 21267 RVA: 0x0018D120 File Offset: 0x0018B320
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 181598, RefRangeEnd = 181600, XrefRangeStart = 181570, XrefRangeEnd = 181598, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DeregisterMovementEvent(Il2CppSystem.Action action)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(action);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerMovement.NativeMethodInfoPtr_DeregisterMovementEvent_Public_Void_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005314 RID: 21268 RVA: 0x0018D164 File Offset: 0x0018B364
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 181631, RefRangeEnd = 181632, XrefRangeStart = 181600, XrefRangeEnd = 181631, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateMovementEvents()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerMovement.NativeMethodInfoPtr_UpdateMovementEvents_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005315 RID: 21269 RVA: 0x0018D198 File Offset: 0x0018B398
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 181633, RefRangeEnd = 181636, XrefRangeStart = 181632, XrefRangeEnd = 181633, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ChangeStamina(float change, bool notify = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref change;
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref notify;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerMovement.NativeMethodInfoPtr_ChangeStamina_Public_Void_Single_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005316 RID: 21270 RVA: 0x0018D1E4 File Offset: 0x0018B3E4
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 181641, RefRangeEnd = 181646, XrefRangeStart = 181636, XrefRangeEnd = 181641, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetStamina(float value, bool notify = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref value;
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref notify;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerMovement.NativeMethodInfoPtr_SetStamina_Public_Void_Single_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005317 RID: 21271 RVA: 0x0018D230 File Offset: 0x0018B430
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 181652, RefRangeEnd = 181653, XrefRangeStart = 181646, XrefRangeEnd = 181652, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddSprintBlocker(string tag)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(tag);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerMovement.NativeMethodInfoPtr_AddSprintBlocker_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005318 RID: 21272 RVA: 0x0018D274 File Offset: 0x0018B474
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 181659, RefRangeEnd = 181661, XrefRangeStart = 181653, XrefRangeEnd = 181659, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveSprintBlocker(string tag)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(tag);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerMovement.NativeMethodInfoPtr_RemoveSprintBlocker_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005319 RID: 21273 RVA: 0x0018D2B8 File Offset: 0x0018B4B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 181661, XrefRangeEnd = 181711, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PlayerMovement() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerMovement.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600531A RID: 21274 RVA: 0x0018D2F4 File Offset: 0x0018B4F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 181711, XrefRangeEnd = 181719, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _Start_b__105_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerMovement.NativeMethodInfoPtr__Start_b__105_0_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600531B RID: 21275 RVA: 0x00027336 File Offset: 0x00025536
		public PlayerMovement(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170018B3 RID: 6323
		// (get) Token: 0x0600531C RID: 21276 RVA: 0x0018D328 File Offset: 0x0018B528
		// (set) Token: 0x0600531D RID: 21277 RVA: 0x0002733F File Offset: 0x0002553F
		public unsafe static float DEV_SPRINT_MULTIPLIER
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(PlayerMovement.NativeFieldInfoPtr_DEV_SPRINT_MULTIPLIER, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PlayerMovement.NativeFieldInfoPtr_DEV_SPRINT_MULTIPLIER, (void*)(&value));
			}
		}

		// Token: 0x170018B4 RID: 6324
		// (get) Token: 0x0600531E RID: 21278 RVA: 0x0018D344 File Offset: 0x0018B544
		// (set) Token: 0x0600531F RID: 21279 RVA: 0x0002734D File Offset: 0x0002554D
		public unsafe static float GROUNDED_THRESHOLD
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(PlayerMovement.NativeFieldInfoPtr_GROUNDED_THRESHOLD, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PlayerMovement.NativeFieldInfoPtr_GROUNDED_THRESHOLD, (void*)(&value));
			}
		}

		// Token: 0x170018B5 RID: 6325
		// (get) Token: 0x06005320 RID: 21280 RVA: 0x0018D360 File Offset: 0x0018B560
		// (set) Token: 0x06005321 RID: 21281 RVA: 0x0002735B File Offset: 0x0002555B
		public unsafe static float SLOPE_THRESHOLD
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(PlayerMovement.NativeFieldInfoPtr_SLOPE_THRESHOLD, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PlayerMovement.NativeFieldInfoPtr_SLOPE_THRESHOLD, (void*)(&value));
			}
		}

		// Token: 0x170018B6 RID: 6326
		// (get) Token: 0x06005322 RID: 21282 RVA: 0x0018D37C File Offset: 0x0018B57C
		// (set) Token: 0x06005323 RID: 21283 RVA: 0x00027369 File Offset: 0x00025569
		public unsafe static float WalkSpeed
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(PlayerMovement.NativeFieldInfoPtr_WalkSpeed, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PlayerMovement.NativeFieldInfoPtr_WalkSpeed, (void*)(&value));
			}
		}

		// Token: 0x170018B7 RID: 6327
		// (get) Token: 0x06005324 RID: 21284 RVA: 0x0018D398 File Offset: 0x0018B598
		// (set) Token: 0x06005325 RID: 21285 RVA: 0x00027377 File Offset: 0x00025577
		public unsafe static float SprintMultiplier
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(PlayerMovement.NativeFieldInfoPtr_SprintMultiplier, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PlayerMovement.NativeFieldInfoPtr_SprintMultiplier, (void*)(&value));
			}
		}

		// Token: 0x170018B8 RID: 6328
		// (get) Token: 0x06005326 RID: 21286 RVA: 0x0018D3B4 File Offset: 0x0018B5B4
		// (set) Token: 0x06005327 RID: 21287 RVA: 0x00027385 File Offset: 0x00025585
		public unsafe static float StaticMoveSpeedMultiplier
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(PlayerMovement.NativeFieldInfoPtr_StaticMoveSpeedMultiplier, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PlayerMovement.NativeFieldInfoPtr_StaticMoveSpeedMultiplier, (void*)(&value));
			}
		}

		// Token: 0x170018B9 RID: 6329
		// (get) Token: 0x06005328 RID: 21288 RVA: 0x0018D3D0 File Offset: 0x0018B5D0
		// (set) Token: 0x06005329 RID: 21289 RVA: 0x00027393 File Offset: 0x00025593
		public unsafe static float StaminaRestoreDelay
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(PlayerMovement.NativeFieldInfoPtr_StaminaRestoreDelay, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PlayerMovement.NativeFieldInfoPtr_StaminaRestoreDelay, (void*)(&value));
			}
		}

		// Token: 0x170018BA RID: 6330
		// (get) Token: 0x0600532A RID: 21290 RVA: 0x0018D3EC File Offset: 0x0018B5EC
		// (set) Token: 0x0600532B RID: 21291 RVA: 0x000273A1 File Offset: 0x000255A1
		public unsafe static float JumpMultiplier
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(PlayerMovement.NativeFieldInfoPtr_JumpMultiplier, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PlayerMovement.NativeFieldInfoPtr_JumpMultiplier, (void*)(&value));
			}
		}

		// Token: 0x170018BB RID: 6331
		// (get) Token: 0x0600532C RID: 21292 RVA: 0x0018D408 File Offset: 0x0018B608
		// (set) Token: 0x0600532D RID: 21293 RVA: 0x000273AF File Offset: 0x000255AF
		public unsafe static float ControllerRadius
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(PlayerMovement.NativeFieldInfoPtr_ControllerRadius, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PlayerMovement.NativeFieldInfoPtr_ControllerRadius, (void*)(&value));
			}
		}

		// Token: 0x170018BC RID: 6332
		// (get) Token: 0x0600532E RID: 21294 RVA: 0x0018D424 File Offset: 0x0018B624
		// (set) Token: 0x0600532F RID: 21295 RVA: 0x000273BD File Offset: 0x000255BD
		public unsafe static float StandingControllerHeight
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(PlayerMovement.NativeFieldInfoPtr_StandingControllerHeight, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PlayerMovement.NativeFieldInfoPtr_StandingControllerHeight, (void*)(&value));
			}
		}

		// Token: 0x170018BD RID: 6333
		// (get) Token: 0x06005330 RID: 21296 RVA: 0x0018D440 File Offset: 0x0018B640
		// (set) Token: 0x06005331 RID: 21297 RVA: 0x000273CB File Offset: 0x000255CB
		public unsafe static float CrouchHeightMultiplier
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(PlayerMovement.NativeFieldInfoPtr_CrouchHeightMultiplier, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PlayerMovement.NativeFieldInfoPtr_CrouchHeightMultiplier, (void*)(&value));
			}
		}

		// Token: 0x170018BE RID: 6334
		// (get) Token: 0x06005332 RID: 21298 RVA: 0x0018D45C File Offset: 0x0018B65C
		// (set) Token: 0x06005333 RID: 21299 RVA: 0x000273D9 File Offset: 0x000255D9
		public unsafe static float CrouchTime
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(PlayerMovement.NativeFieldInfoPtr_CrouchTime, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PlayerMovement.NativeFieldInfoPtr_CrouchTime, (void*)(&value));
			}
		}

		// Token: 0x170018BF RID: 6335
		// (get) Token: 0x06005334 RID: 21300 RVA: 0x0018D478 File Offset: 0x0018B678
		// (set) Token: 0x06005335 RID: 21301 RVA: 0x000273E7 File Offset: 0x000255E7
		public unsafe static float _GravityMultiplier_k__BackingField
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(PlayerMovement.NativeFieldInfoPtr__GravityMultiplier_k__BackingField, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PlayerMovement.NativeFieldInfoPtr__GravityMultiplier_k__BackingField, (void*)(&value));
			}
		}

		// Token: 0x170018C0 RID: 6336
		// (get) Token: 0x06005336 RID: 21302 RVA: 0x0018D494 File Offset: 0x0018B694
		// (set) Token: 0x06005337 RID: 21303 RVA: 0x000273F5 File Offset: 0x000255F5
		public unsafe static float StaminaDrainRate
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(PlayerMovement.NativeFieldInfoPtr_StaminaDrainRate, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PlayerMovement.NativeFieldInfoPtr_StaminaDrainRate, (void*)(&value));
			}
		}

		// Token: 0x170018C1 RID: 6337
		// (get) Token: 0x06005338 RID: 21304 RVA: 0x0018D4B0 File Offset: 0x0018B6B0
		// (set) Token: 0x06005339 RID: 21305 RVA: 0x00027403 File Offset: 0x00025603
		public unsafe static float StaminaRestoreRate
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(PlayerMovement.NativeFieldInfoPtr_StaminaRestoreRate, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PlayerMovement.NativeFieldInfoPtr_StaminaRestoreRate, (void*)(&value));
			}
		}

		// Token: 0x170018C2 RID: 6338
		// (get) Token: 0x0600533A RID: 21306 RVA: 0x0018D4CC File Offset: 0x0018B6CC
		// (set) Token: 0x0600533B RID: 21307 RVA: 0x00027411 File Offset: 0x00025611
		public unsafe static float StaminaReserveMax
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(PlayerMovement.NativeFieldInfoPtr_StaminaReserveMax, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PlayerMovement.NativeFieldInfoPtr_StaminaReserveMax, (void*)(&value));
			}
		}

		// Token: 0x170018C3 RID: 6339
		// (get) Token: 0x0600533C RID: 21308 RVA: 0x0018D4E8 File Offset: 0x0018B6E8
		// (set) Token: 0x0600533D RID: 21309 RVA: 0x0002741F File Offset: 0x0002561F
		public unsafe static float SprintChangeRate
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(PlayerMovement.NativeFieldInfoPtr_SprintChangeRate, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PlayerMovement.NativeFieldInfoPtr_SprintChangeRate, (void*)(&value));
			}
		}

		// Token: 0x170018C4 RID: 6340
		// (get) Token: 0x0600533E RID: 21310 RVA: 0x0018D504 File Offset: 0x0018B704
		// (set) Token: 0x0600533F RID: 21311 RVA: 0x0002742D File Offset: 0x0002562D
		public unsafe Player Player
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr_Player);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Player>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr_Player), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170018C5 RID: 6341
		// (get) Token: 0x06005340 RID: 21312 RVA: 0x0018D534 File Offset: 0x0018B734
		// (set) Token: 0x06005341 RID: 21313 RVA: 0x0002744C File Offset: 0x0002564C
		public unsafe CharacterController Controller
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr_Controller);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CharacterController>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr_Controller), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170018C6 RID: 6342
		// (get) Token: 0x06005342 RID: 21314 RVA: 0x0018D564 File Offset: 0x0018B764
		// (set) Token: 0x06005343 RID: 21315 RVA: 0x0002746B File Offset: 0x0002566B
		public unsafe float sensitivity
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr_sensitivity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr_sensitivity)) = value;
			}
		}

		// Token: 0x170018C7 RID: 6343
		// (get) Token: 0x06005344 RID: 21316 RVA: 0x0018D58C File Offset: 0x0018B78C
		// (set) Token: 0x06005345 RID: 21317 RVA: 0x00027486 File Offset: 0x00025686
		public unsafe float dead
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr_dead);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr_dead)) = value;
			}
		}

		// Token: 0x170018C8 RID: 6344
		// (get) Token: 0x06005346 RID: 21318 RVA: 0x0018D5B4 File Offset: 0x0018B7B4
		// (set) Token: 0x06005347 RID: 21319 RVA: 0x000274A1 File Offset: 0x000256A1
		public unsafe bool canMove
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr_canMove);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr_canMove)) = value;
			}
		}

		// Token: 0x170018C9 RID: 6345
		// (get) Token: 0x06005348 RID: 21320 RVA: 0x0018D5DC File Offset: 0x0018B7DC
		// (set) Token: 0x06005349 RID: 21321 RVA: 0x000274BC File Offset: 0x000256BC
		public unsafe bool canJump
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr_canJump);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr_canJump)) = value;
			}
		}

		// Token: 0x170018CA RID: 6346
		// (get) Token: 0x0600534A RID: 21322 RVA: 0x0018D604 File Offset: 0x0018B804
		// (set) Token: 0x0600534B RID: 21323 RVA: 0x000274D7 File Offset: 0x000256D7
		public unsafe bool SprintingRequiresStamina
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr_SprintingRequiresStamina);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr_SprintingRequiresStamina)) = value;
			}
		}

		// Token: 0x170018CB RID: 6347
		// (get) Token: 0x0600534C RID: 21324 RVA: 0x0018D62C File Offset: 0x0018B82C
		// (set) Token: 0x0600534D RID: 21325 RVA: 0x000274F2 File Offset: 0x000256F2
		public unsafe float MoveSpeedMultiplier
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr_MoveSpeedMultiplier);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr_MoveSpeedMultiplier)) = value;
			}
		}

		// Token: 0x170018CC RID: 6348
		// (get) Token: 0x0600534E RID: 21326 RVA: 0x0018D654 File Offset: 0x0018B854
		// (set) Token: 0x0600534F RID: 21327 RVA: 0x0002750D File Offset: 0x0002570D
		public unsafe float SlipperyMovementMultiplier
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr_SlipperyMovementMultiplier);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr_SlipperyMovementMultiplier)) = value;
			}
		}

		// Token: 0x170018CD RID: 6349
		// (get) Token: 0x06005350 RID: 21328 RVA: 0x0018D67C File Offset: 0x0018B87C
		// (set) Token: 0x06005351 RID: 21329 RVA: 0x00027528 File Offset: 0x00025728
		public unsafe bool ForceSprint
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr_ForceSprint);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr_ForceSprint)) = value;
			}
		}

		// Token: 0x170018CE RID: 6350
		// (get) Token: 0x06005352 RID: 21330 RVA: 0x0018D6A4 File Offset: 0x0018B8A4
		// (set) Token: 0x06005353 RID: 21331 RVA: 0x00027543 File Offset: 0x00025743
		public unsafe float jumpForce
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr_jumpForce);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr_jumpForce)) = value;
			}
		}

		// Token: 0x170018CF RID: 6351
		// (get) Token: 0x06005354 RID: 21332 RVA: 0x0018D6CC File Offset: 0x0018B8CC
		// (set) Token: 0x06005355 RID: 21333 RVA: 0x0002755E File Offset: 0x0002575E
		public unsafe float gravityMultiplier
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr_gravityMultiplier);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr_gravityMultiplier)) = value;
			}
		}

		// Token: 0x170018D0 RID: 6352
		// (get) Token: 0x06005356 RID: 21334 RVA: 0x0018D6F4 File Offset: 0x0018B8F4
		// (set) Token: 0x06005357 RID: 21335 RVA: 0x00027579 File Offset: 0x00025779
		public unsafe LayerMask groundDetectionMask
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr_groundDetectionMask);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr_groundDetectionMask)) = value;
			}
		}

		// Token: 0x170018D1 RID: 6353
		// (get) Token: 0x06005358 RID: 21336 RVA: 0x0018D71C File Offset: 0x0018B91C
		// (set) Token: 0x06005359 RID: 21337 RVA: 0x00027594 File Offset: 0x00025794
		public unsafe float slopeForce
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr_slopeForce);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr_slopeForce)) = value;
			}
		}

		// Token: 0x170018D2 RID: 6354
		// (get) Token: 0x0600535A RID: 21338 RVA: 0x0018D744 File Offset: 0x0018B944
		// (set) Token: 0x0600535B RID: 21339 RVA: 0x000275AF File Offset: 0x000257AF
		public unsafe float slopeForceRayLength
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr_slopeForceRayLength);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr_slopeForceRayLength)) = value;
			}
		}

		// Token: 0x170018D3 RID: 6355
		// (get) Token: 0x0600535C RID: 21340 RVA: 0x0018D76C File Offset: 0x0018B96C
		// (set) Token: 0x0600535D RID: 21341 RVA: 0x000275CA File Offset: 0x000257CA
		public unsafe float crouchSpeedMultipler
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr_crouchSpeedMultipler);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr_crouchSpeedMultipler)) = value;
			}
		}

		// Token: 0x170018D4 RID: 6356
		// (get) Token: 0x0600535E RID: 21342 RVA: 0x0018D794 File Offset: 0x0018B994
		// (set) Token: 0x0600535F RID: 21343 RVA: 0x000275E5 File Offset: 0x000257E5
		public unsafe float Crouched_VigIntensity
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr_Crouched_VigIntensity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr_Crouched_VigIntensity)) = value;
			}
		}

		// Token: 0x170018D5 RID: 6357
		// (get) Token: 0x06005360 RID: 21344 RVA: 0x0018D7BC File Offset: 0x0018B9BC
		// (set) Token: 0x06005361 RID: 21345 RVA: 0x00027600 File Offset: 0x00025800
		public unsafe float Crouched_VigSmoothness
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr_Crouched_VigSmoothness);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr_Crouched_VigSmoothness)) = value;
			}
		}

		// Token: 0x170018D6 RID: 6358
		// (get) Token: 0x06005362 RID: 21346 RVA: 0x0018D7E4 File Offset: 0x0018B9E4
		// (set) Token: 0x06005363 RID: 21347 RVA: 0x0002761B File Offset: 0x0002581B
		public unsafe List<Transform> visibilityPointsToScale
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr_visibilityPointsToScale);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Transform>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr_visibilityPointsToScale), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170018D7 RID: 6359
		// (get) Token: 0x06005364 RID: 21348 RVA: 0x0018D814 File Offset: 0x0018BA14
		// (set) Token: 0x06005365 RID: 21349 RVA: 0x0002763A File Offset: 0x0002583A
		public unsafe Dictionary<Transform, float> originalVisibilityPointOffsets
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr_originalVisibilityPointOffsets);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<Transform, float>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr_originalVisibilityPointOffsets), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170018D8 RID: 6360
		// (get) Token: 0x06005366 RID: 21350 RVA: 0x0018D844 File Offset: 0x0018BA44
		// (set) Token: 0x06005367 RID: 21351 RVA: 0x00027659 File Offset: 0x00025859
		public unsafe float _playerHeight_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr__playerHeight_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr__playerHeight_k__BackingField)) = value;
			}
		}

		// Token: 0x170018D9 RID: 6361
		// (get) Token: 0x06005368 RID: 21352 RVA: 0x0018D86C File Offset: 0x0018BA6C
		// (set) Token: 0x06005369 RID: 21353 RVA: 0x00027674 File Offset: 0x00025874
		public unsafe Vector3 movement
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr_movement);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr_movement)) = value;
			}
		}

		// Token: 0x170018DA RID: 6362
		// (get) Token: 0x0600536A RID: 21354 RVA: 0x0018D894 File Offset: 0x0018BA94
		// (set) Token: 0x0600536B RID: 21355 RVA: 0x0002768F File Offset: 0x0002588F
		public unsafe float movementY
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr_movementY);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr_movementY)) = value;
			}
		}

		// Token: 0x170018DB RID: 6363
		// (get) Token: 0x0600536C RID: 21356 RVA: 0x0018D8BC File Offset: 0x0018BABC
		// (set) Token: 0x0600536D RID: 21357 RVA: 0x000276AA File Offset: 0x000258AA
		public unsafe LandVehicle _currentVehicle_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr__currentVehicle_k__BackingField);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LandVehicle>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr__currentVehicle_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170018DC RID: 6364
		// (get) Token: 0x0600536E RID: 21358 RVA: 0x0018D8EC File Offset: 0x0018BAEC
		// (set) Token: 0x0600536F RID: 21359 RVA: 0x000276C9 File Offset: 0x000258C9
		public unsafe List<LandVehicle> recentlyDrivenVehicles
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr_recentlyDrivenVehicles);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<LandVehicle>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr_recentlyDrivenVehicles), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170018DD RID: 6365
		// (get) Token: 0x06005370 RID: 21360 RVA: 0x0018D91C File Offset: 0x0018BB1C
		// (set) Token: 0x06005371 RID: 21361 RVA: 0x000276E8 File Offset: 0x000258E8
		public unsafe bool isJumping
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr_isJumping);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr_isJumping)) = value;
			}
		}

		// Token: 0x170018DE RID: 6366
		// (get) Token: 0x06005372 RID: 21362 RVA: 0x0018D944 File Offset: 0x0018BB44
		// (set) Token: 0x06005373 RID: 21363 RVA: 0x00027703 File Offset: 0x00025903
		public unsafe float _airTime_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr__airTime_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr__airTime_k__BackingField)) = value;
			}
		}

		// Token: 0x170018DF RID: 6367
		// (get) Token: 0x06005374 RID: 21364 RVA: 0x0018D96C File Offset: 0x0018BB6C
		// (set) Token: 0x06005375 RID: 21365 RVA: 0x0002771E File Offset: 0x0002591E
		public unsafe bool _isCrouched_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr__isCrouched_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr__isCrouched_k__BackingField)) = value;
			}
		}

		// Token: 0x170018E0 RID: 6368
		// (get) Token: 0x06005376 RID: 21366 RVA: 0x0018D994 File Offset: 0x0018BB94
		// (set) Token: 0x06005377 RID: 21367 RVA: 0x00027739 File Offset: 0x00025939
		public unsafe float _standingScale_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr__standingScale_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr__standingScale_k__BackingField)) = value;
			}
		}

		// Token: 0x170018E1 RID: 6369
		// (get) Token: 0x06005378 RID: 21368 RVA: 0x0018D9BC File Offset: 0x0018BBBC
		// (set) Token: 0x06005379 RID: 21369 RVA: 0x00027754 File Offset: 0x00025954
		public unsafe bool _isRagdolled_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr__isRagdolled_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr__isRagdolled_k__BackingField)) = value;
			}
		}

		// Token: 0x170018E2 RID: 6370
		// (get) Token: 0x0600537A RID: 21370 RVA: 0x0018D9E4 File Offset: 0x0018BBE4
		// (set) Token: 0x0600537B RID: 21371 RVA: 0x0002776F File Offset: 0x0002596F
		public unsafe bool _isSprinting_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr__isSprinting_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr__isSprinting_k__BackingField)) = value;
			}
		}

		// Token: 0x170018E3 RID: 6371
		// (get) Token: 0x0600537C RID: 21372 RVA: 0x0018DA0C File Offset: 0x0018BC0C
		// (set) Token: 0x0600537D RID: 21373 RVA: 0x0002778A File Offset: 0x0002598A
		public unsafe float _CurrentSprintMultiplier_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr__CurrentSprintMultiplier_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr__CurrentSprintMultiplier_k__BackingField)) = value;
			}
		}

		// Token: 0x170018E4 RID: 6372
		// (get) Token: 0x0600537E RID: 21374 RVA: 0x0018DA34 File Offset: 0x0018BC34
		// (set) Token: 0x0600537F RID: 21375 RVA: 0x000277A5 File Offset: 0x000259A5
		public unsafe float CurrentStaminaReserve
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr_CurrentStaminaReserve);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr_CurrentStaminaReserve)) = value;
			}
		}

		// Token: 0x170018E5 RID: 6373
		// (get) Token: 0x06005380 RID: 21376 RVA: 0x0018DA5C File Offset: 0x0018BC5C
		// (set) Token: 0x06005381 RID: 21377 RVA: 0x000277C0 File Offset: 0x000259C0
		public unsafe bool _IsGrounded_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr__IsGrounded_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr__IsGrounded_k__BackingField)) = value;
			}
		}

		// Token: 0x170018E6 RID: 6374
		// (get) Token: 0x06005382 RID: 21378 RVA: 0x0018DA84 File Offset: 0x0018BC84
		// (set) Token: 0x06005383 RID: 21379 RVA: 0x000277DB File Offset: 0x000259DB
		public unsafe Il2CppSystem.Action<float> onStaminaReserveChanged
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr_onStaminaReserveChanged);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Action<float>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr_onStaminaReserveChanged), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170018E7 RID: 6375
		// (get) Token: 0x06005384 RID: 21380 RVA: 0x0018DAB4 File Offset: 0x0018BCB4
		// (set) Token: 0x06005385 RID: 21381 RVA: 0x000277FA File Offset: 0x000259FA
		public unsafe Il2CppSystem.Action onJump
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr_onJump);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Action>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr_onJump), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170018E8 RID: 6376
		// (get) Token: 0x06005386 RID: 21382 RVA: 0x0018DAE4 File Offset: 0x0018BCE4
		// (set) Token: 0x06005387 RID: 21383 RVA: 0x00027819 File Offset: 0x00025A19
		public unsafe Il2CppSystem.Action onLand
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr_onLand);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Action>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr_onLand), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170018E9 RID: 6377
		// (get) Token: 0x06005388 RID: 21384 RVA: 0x0018DB14 File Offset: 0x0018BD14
		// (set) Token: 0x06005389 RID: 21385 RVA: 0x00027838 File Offset: 0x00025A38
		public unsafe UnityEvent onCrouch
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr_onCrouch);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr_onCrouch), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170018EA RID: 6378
		// (get) Token: 0x0600538A RID: 21386 RVA: 0x0018DB44 File Offset: 0x0018BD44
		// (set) Token: 0x0600538B RID: 21387 RVA: 0x00027857 File Offset: 0x00025A57
		public unsafe UnityEvent onUncrouch
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr_onUncrouch);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr_onUncrouch), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170018EB RID: 6379
		// (get) Token: 0x0600538C RID: 21388 RVA: 0x0018DB74 File Offset: 0x0018BD74
		// (set) Token: 0x0600538D RID: 21389 RVA: 0x00027876 File Offset: 0x00025A76
		public unsafe float horizontalAxis
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr_horizontalAxis);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr_horizontalAxis)) = value;
			}
		}

		// Token: 0x170018EC RID: 6380
		// (get) Token: 0x0600538E RID: 21390 RVA: 0x0018DB9C File Offset: 0x0018BD9C
		// (set) Token: 0x0600538F RID: 21391 RVA: 0x00027891 File Offset: 0x00025A91
		public unsafe float verticalAxis
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr_verticalAxis);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr_verticalAxis)) = value;
			}
		}

		// Token: 0x170018ED RID: 6381
		// (get) Token: 0x06005390 RID: 21392 RVA: 0x0018DBC4 File Offset: 0x0018BDC4
		// (set) Token: 0x06005391 RID: 21393 RVA: 0x000278AC File Offset: 0x00025AAC
		public unsafe float timeGrounded
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr_timeGrounded);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr_timeGrounded)) = value;
			}
		}

		// Token: 0x170018EE RID: 6382
		// (get) Token: 0x06005392 RID: 21394 RVA: 0x0018DBEC File Offset: 0x0018BDEC
		// (set) Token: 0x06005393 RID: 21395 RVA: 0x000278C7 File Offset: 0x00025AC7
		public unsafe Dictionary<int, PlayerMovement.MovementEvent> movementEvents
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr_movementEvents);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<int, PlayerMovement.MovementEvent>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr_movementEvents), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170018EF RID: 6383
		// (get) Token: 0x06005394 RID: 21396 RVA: 0x0018DC1C File Offset: 0x0018BE1C
		// (set) Token: 0x06005395 RID: 21397 RVA: 0x000278E6 File Offset: 0x00025AE6
		public unsafe float timeSinceStaminaDrain
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr_timeSinceStaminaDrain);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr_timeSinceStaminaDrain)) = value;
			}
		}

		// Token: 0x170018F0 RID: 6384
		// (get) Token: 0x06005396 RID: 21398 RVA: 0x0018DC44 File Offset: 0x0018BE44
		// (set) Token: 0x06005397 RID: 21399 RVA: 0x00027901 File Offset: 0x00025B01
		public unsafe bool sprintActive
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr_sprintActive);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr_sprintActive)) = value;
			}
		}

		// Token: 0x170018F1 RID: 6385
		// (get) Token: 0x06005398 RID: 21400 RVA: 0x0018DC6C File Offset: 0x0018BE6C
		// (set) Token: 0x06005399 RID: 21401 RVA: 0x0002791C File Offset: 0x00025B1C
		public unsafe bool sprintReleased
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr_sprintReleased);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr_sprintReleased)) = value;
			}
		}

		// Token: 0x170018F2 RID: 6386
		// (get) Token: 0x0600539A RID: 21402 RVA: 0x0018DC94 File Offset: 0x0018BE94
		// (set) Token: 0x0600539B RID: 21403 RVA: 0x00027937 File Offset: 0x00025B37
		public unsafe Vector3 residualVelocityDirection
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr_residualVelocityDirection);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr_residualVelocityDirection)) = value;
			}
		}

		// Token: 0x170018F3 RID: 6387
		// (get) Token: 0x0600539C RID: 21404 RVA: 0x0018DCBC File Offset: 0x0018BEBC
		// (set) Token: 0x0600539D RID: 21405 RVA: 0x00027952 File Offset: 0x00025B52
		public unsafe float residualVelocityForce
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr_residualVelocityForce);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr_residualVelocityForce)) = value;
			}
		}

		// Token: 0x170018F4 RID: 6388
		// (get) Token: 0x0600539E RID: 21406 RVA: 0x0018DCE4 File Offset: 0x0018BEE4
		// (set) Token: 0x0600539F RID: 21407 RVA: 0x0002796D File Offset: 0x00025B6D
		public unsafe float residualVelocityDuration
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr_residualVelocityDuration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr_residualVelocityDuration)) = value;
			}
		}

		// Token: 0x170018F5 RID: 6389
		// (get) Token: 0x060053A0 RID: 21408 RVA: 0x0018DD0C File Offset: 0x0018BF0C
		// (set) Token: 0x060053A1 RID: 21409 RVA: 0x00027988 File Offset: 0x00025B88
		public unsafe float residualVelocityTimeRemaining
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr_residualVelocityTimeRemaining);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr_residualVelocityTimeRemaining)) = value;
			}
		}

		// Token: 0x170018F6 RID: 6390
		// (get) Token: 0x060053A2 RID: 21410 RVA: 0x0018DD34 File Offset: 0x0018BF34
		// (set) Token: 0x060053A3 RID: 21411 RVA: 0x000279A3 File Offset: 0x00025BA3
		public unsafe bool teleport
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr_teleport);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr_teleport)) = value;
			}
		}

		// Token: 0x170018F7 RID: 6391
		// (get) Token: 0x060053A4 RID: 21412 RVA: 0x0018DD5C File Offset: 0x0018BF5C
		// (set) Token: 0x060053A5 RID: 21413 RVA: 0x000279BE File Offset: 0x00025BBE
		public unsafe Vector3 teleportPosition
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr_teleportPosition);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr_teleportPosition)) = value;
			}
		}

		// Token: 0x170018F8 RID: 6392
		// (get) Token: 0x060053A6 RID: 21414 RVA: 0x0018DD84 File Offset: 0x0018BF84
		// (set) Token: 0x060053A7 RID: 21415 RVA: 0x000279D9 File Offset: 0x00025BD9
		public unsafe List<string> sprintBlockers
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr_sprintBlockers);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr_sprintBlockers), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170018F9 RID: 6393
		// (get) Token: 0x060053A8 RID: 21416 RVA: 0x0018DDB4 File Offset: 0x0018BFB4
		// (set) Token: 0x060053A9 RID: 21417 RVA: 0x000279F8 File Offset: 0x00025BF8
		public unsafe Vector3 lastFrameMovement
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr_lastFrameMovement);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr_lastFrameMovement)) = value;
			}
		}

		// Token: 0x170018FA RID: 6394
		// (get) Token: 0x060053AA RID: 21418 RVA: 0x0018DDDC File Offset: 0x0018BFDC
		// (set) Token: 0x060053AB RID: 21419 RVA: 0x00027A13 File Offset: 0x00025C13
		public unsafe Coroutine playerRotCoroutine
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr_playerRotCoroutine);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.NativeFieldInfoPtr_playerRotCoroutine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04003840 RID: 14400
		private static readonly System.IntPtr NativeFieldInfoPtr_DEV_SPRINT_MULTIPLIER;

		// Token: 0x04003841 RID: 14401
		private static readonly System.IntPtr NativeFieldInfoPtr_GROUNDED_THRESHOLD;

		// Token: 0x04003842 RID: 14402
		private static readonly System.IntPtr NativeFieldInfoPtr_SLOPE_THRESHOLD;

		// Token: 0x04003843 RID: 14403
		private static readonly System.IntPtr NativeFieldInfoPtr_WalkSpeed;

		// Token: 0x04003844 RID: 14404
		private static readonly System.IntPtr NativeFieldInfoPtr_SprintMultiplier;

		// Token: 0x04003845 RID: 14405
		private static readonly System.IntPtr NativeFieldInfoPtr_StaticMoveSpeedMultiplier;

		// Token: 0x04003846 RID: 14406
		private static readonly System.IntPtr NativeFieldInfoPtr_StaminaRestoreDelay;

		// Token: 0x04003847 RID: 14407
		private static readonly System.IntPtr NativeFieldInfoPtr_JumpMultiplier;

		// Token: 0x04003848 RID: 14408
		private static readonly System.IntPtr NativeFieldInfoPtr_ControllerRadius;

		// Token: 0x04003849 RID: 14409
		private static readonly System.IntPtr NativeFieldInfoPtr_StandingControllerHeight;

		// Token: 0x0400384A RID: 14410
		private static readonly System.IntPtr NativeFieldInfoPtr_CrouchHeightMultiplier;

		// Token: 0x0400384B RID: 14411
		private static readonly System.IntPtr NativeFieldInfoPtr_CrouchTime;

		// Token: 0x0400384C RID: 14412
		private static readonly System.IntPtr NativeFieldInfoPtr__GravityMultiplier_k__BackingField;

		// Token: 0x0400384D RID: 14413
		private static readonly System.IntPtr NativeFieldInfoPtr_StaminaDrainRate;

		// Token: 0x0400384E RID: 14414
		private static readonly System.IntPtr NativeFieldInfoPtr_StaminaRestoreRate;

		// Token: 0x0400384F RID: 14415
		private static readonly System.IntPtr NativeFieldInfoPtr_StaminaReserveMax;

		// Token: 0x04003850 RID: 14416
		private static readonly System.IntPtr NativeFieldInfoPtr_SprintChangeRate;

		// Token: 0x04003851 RID: 14417
		private static readonly System.IntPtr NativeFieldInfoPtr_Player;

		// Token: 0x04003852 RID: 14418
		private static readonly System.IntPtr NativeFieldInfoPtr_Controller;

		// Token: 0x04003853 RID: 14419
		private static readonly System.IntPtr NativeFieldInfoPtr_sensitivity;

		// Token: 0x04003854 RID: 14420
		private static readonly System.IntPtr NativeFieldInfoPtr_dead;

		// Token: 0x04003855 RID: 14421
		private static readonly System.IntPtr NativeFieldInfoPtr_canMove;

		// Token: 0x04003856 RID: 14422
		private static readonly System.IntPtr NativeFieldInfoPtr_canJump;

		// Token: 0x04003857 RID: 14423
		private static readonly System.IntPtr NativeFieldInfoPtr_SprintingRequiresStamina;

		// Token: 0x04003858 RID: 14424
		private static readonly System.IntPtr NativeFieldInfoPtr_MoveSpeedMultiplier;

		// Token: 0x04003859 RID: 14425
		private static readonly System.IntPtr NativeFieldInfoPtr_SlipperyMovementMultiplier;

		// Token: 0x0400385A RID: 14426
		private static readonly System.IntPtr NativeFieldInfoPtr_ForceSprint;

		// Token: 0x0400385B RID: 14427
		private static readonly System.IntPtr NativeFieldInfoPtr_jumpForce;

		// Token: 0x0400385C RID: 14428
		private static readonly System.IntPtr NativeFieldInfoPtr_gravityMultiplier;

		// Token: 0x0400385D RID: 14429
		private static readonly System.IntPtr NativeFieldInfoPtr_groundDetectionMask;

		// Token: 0x0400385E RID: 14430
		private static readonly System.IntPtr NativeFieldInfoPtr_slopeForce;

		// Token: 0x0400385F RID: 14431
		private static readonly System.IntPtr NativeFieldInfoPtr_slopeForceRayLength;

		// Token: 0x04003860 RID: 14432
		private static readonly System.IntPtr NativeFieldInfoPtr_crouchSpeedMultipler;

		// Token: 0x04003861 RID: 14433
		private static readonly System.IntPtr NativeFieldInfoPtr_Crouched_VigIntensity;

		// Token: 0x04003862 RID: 14434
		private static readonly System.IntPtr NativeFieldInfoPtr_Crouched_VigSmoothness;

		// Token: 0x04003863 RID: 14435
		private static readonly System.IntPtr NativeFieldInfoPtr_visibilityPointsToScale;

		// Token: 0x04003864 RID: 14436
		private static readonly System.IntPtr NativeFieldInfoPtr_originalVisibilityPointOffsets;

		// Token: 0x04003865 RID: 14437
		private static readonly System.IntPtr NativeFieldInfoPtr__playerHeight_k__BackingField;

		// Token: 0x04003866 RID: 14438
		private static readonly System.IntPtr NativeFieldInfoPtr_movement;

		// Token: 0x04003867 RID: 14439
		private static readonly System.IntPtr NativeFieldInfoPtr_movementY;

		// Token: 0x04003868 RID: 14440
		private static readonly System.IntPtr NativeFieldInfoPtr__currentVehicle_k__BackingField;

		// Token: 0x04003869 RID: 14441
		private static readonly System.IntPtr NativeFieldInfoPtr_recentlyDrivenVehicles;

		// Token: 0x0400386A RID: 14442
		private static readonly System.IntPtr NativeFieldInfoPtr_isJumping;

		// Token: 0x0400386B RID: 14443
		private static readonly System.IntPtr NativeFieldInfoPtr__airTime_k__BackingField;

		// Token: 0x0400386C RID: 14444
		private static readonly System.IntPtr NativeFieldInfoPtr__isCrouched_k__BackingField;

		// Token: 0x0400386D RID: 14445
		private static readonly System.IntPtr NativeFieldInfoPtr__standingScale_k__BackingField;

		// Token: 0x0400386E RID: 14446
		private static readonly System.IntPtr NativeFieldInfoPtr__isRagdolled_k__BackingField;

		// Token: 0x0400386F RID: 14447
		private static readonly System.IntPtr NativeFieldInfoPtr__isSprinting_k__BackingField;

		// Token: 0x04003870 RID: 14448
		private static readonly System.IntPtr NativeFieldInfoPtr__CurrentSprintMultiplier_k__BackingField;

		// Token: 0x04003871 RID: 14449
		private static readonly System.IntPtr NativeFieldInfoPtr_CurrentStaminaReserve;

		// Token: 0x04003872 RID: 14450
		private static readonly System.IntPtr NativeFieldInfoPtr__IsGrounded_k__BackingField;

		// Token: 0x04003873 RID: 14451
		private static readonly System.IntPtr NativeFieldInfoPtr_onStaminaReserveChanged;

		// Token: 0x04003874 RID: 14452
		private static readonly System.IntPtr NativeFieldInfoPtr_onJump;

		// Token: 0x04003875 RID: 14453
		private static readonly System.IntPtr NativeFieldInfoPtr_onLand;

		// Token: 0x04003876 RID: 14454
		private static readonly System.IntPtr NativeFieldInfoPtr_onCrouch;

		// Token: 0x04003877 RID: 14455
		private static readonly System.IntPtr NativeFieldInfoPtr_onUncrouch;

		// Token: 0x04003878 RID: 14456
		private static readonly System.IntPtr NativeFieldInfoPtr_horizontalAxis;

		// Token: 0x04003879 RID: 14457
		private static readonly System.IntPtr NativeFieldInfoPtr_verticalAxis;

		// Token: 0x0400387A RID: 14458
		private static readonly System.IntPtr NativeFieldInfoPtr_timeGrounded;

		// Token: 0x0400387B RID: 14459
		private static readonly System.IntPtr NativeFieldInfoPtr_movementEvents;

		// Token: 0x0400387C RID: 14460
		private static readonly System.IntPtr NativeFieldInfoPtr_timeSinceStaminaDrain;

		// Token: 0x0400387D RID: 14461
		private static readonly System.IntPtr NativeFieldInfoPtr_sprintActive;

		// Token: 0x0400387E RID: 14462
		private static readonly System.IntPtr NativeFieldInfoPtr_sprintReleased;

		// Token: 0x0400387F RID: 14463
		private static readonly System.IntPtr NativeFieldInfoPtr_residualVelocityDirection;

		// Token: 0x04003880 RID: 14464
		private static readonly System.IntPtr NativeFieldInfoPtr_residualVelocityForce;

		// Token: 0x04003881 RID: 14465
		private static readonly System.IntPtr NativeFieldInfoPtr_residualVelocityDuration;

		// Token: 0x04003882 RID: 14466
		private static readonly System.IntPtr NativeFieldInfoPtr_residualVelocityTimeRemaining;

		// Token: 0x04003883 RID: 14467
		private static readonly System.IntPtr NativeFieldInfoPtr_teleport;

		// Token: 0x04003884 RID: 14468
		private static readonly System.IntPtr NativeFieldInfoPtr_teleportPosition;

		// Token: 0x04003885 RID: 14469
		private static readonly System.IntPtr NativeFieldInfoPtr_sprintBlockers;

		// Token: 0x04003886 RID: 14470
		private static readonly System.IntPtr NativeFieldInfoPtr_lastFrameMovement;

		// Token: 0x04003887 RID: 14471
		private static readonly System.IntPtr NativeFieldInfoPtr_playerRotCoroutine;

		// Token: 0x04003888 RID: 14472
		private static readonly System.IntPtr NativeMethodInfoPtr_get_GravityMultiplier_Public_Static_get_Single_0;

		// Token: 0x04003889 RID: 14473
		private static readonly System.IntPtr NativeMethodInfoPtr_set_GravityMultiplier_Public_Static_set_Void_Single_0;

		// Token: 0x0400388A RID: 14474
		private static readonly System.IntPtr NativeMethodInfoPtr_get_playerHeight_Public_get_Single_0;

		// Token: 0x0400388B RID: 14475
		private static readonly System.IntPtr NativeMethodInfoPtr_set_playerHeight_Protected_set_Void_Single_0;

		// Token: 0x0400388C RID: 14476
		private static readonly System.IntPtr NativeMethodInfoPtr_get_Movement_Public_get_Vector3_0;

		// Token: 0x0400388D RID: 14477
		private static readonly System.IntPtr NativeMethodInfoPtr_get_currentVehicle_Public_get_LandVehicle_0;

		// Token: 0x0400388E RID: 14478
		private static readonly System.IntPtr NativeMethodInfoPtr_set_currentVehicle_Protected_set_Void_LandVehicle_0;

		// Token: 0x0400388F RID: 14479
		private static readonly System.IntPtr NativeMethodInfoPtr_get_airTime_Public_get_Single_0;

		// Token: 0x04003890 RID: 14480
		private static readonly System.IntPtr NativeMethodInfoPtr_set_airTime_Protected_set_Void_Single_0;

		// Token: 0x04003891 RID: 14481
		private static readonly System.IntPtr NativeMethodInfoPtr_get_isCrouched_Public_get_Boolean_0;

		// Token: 0x04003892 RID: 14482
		private static readonly System.IntPtr NativeMethodInfoPtr_set_isCrouched_Protected_set_Void_Boolean_0;

		// Token: 0x04003893 RID: 14483
		private static readonly System.IntPtr NativeMethodInfoPtr_get_standingScale_Public_get_Single_0;

		// Token: 0x04003894 RID: 14484
		private static readonly System.IntPtr NativeMethodInfoPtr_set_standingScale_Protected_set_Void_Single_0;

		// Token: 0x04003895 RID: 14485
		private static readonly System.IntPtr NativeMethodInfoPtr_get_isRagdolled_Public_get_Boolean_0;

		// Token: 0x04003896 RID: 14486
		private static readonly System.IntPtr NativeMethodInfoPtr_set_isRagdolled_Protected_set_Void_Boolean_0;

		// Token: 0x04003897 RID: 14487
		private static readonly System.IntPtr NativeMethodInfoPtr_get_isSprinting_Public_get_Boolean_0;

		// Token: 0x04003898 RID: 14488
		private static readonly System.IntPtr NativeMethodInfoPtr_set_isSprinting_Protected_set_Void_Boolean_0;

		// Token: 0x04003899 RID: 14489
		private static readonly System.IntPtr NativeMethodInfoPtr_get_CurrentSprintMultiplier_Public_get_Single_0;

		// Token: 0x0400389A RID: 14490
		private static readonly System.IntPtr NativeMethodInfoPtr_set_CurrentSprintMultiplier_Protected_set_Void_Single_0;

		// Token: 0x0400389B RID: 14491
		private static readonly System.IntPtr NativeMethodInfoPtr_get_IsGrounded_Public_get_Boolean_0;

		// Token: 0x0400389C RID: 14492
		private static readonly System.IntPtr NativeMethodInfoPtr_set_IsGrounded_Private_set_Void_Boolean_0;

		// Token: 0x0400389D RID: 14493
		private static readonly System.IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0;

		// Token: 0x0400389E RID: 14494
		private static readonly System.IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x0400389F RID: 14495
		private static readonly System.IntPtr NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0;

		// Token: 0x040038A0 RID: 14496
		private static readonly System.IntPtr NativeMethodInfoPtr_FixedUpdate_Private_Void_0;

		// Token: 0x040038A1 RID: 14497
		private static readonly System.IntPtr NativeMethodInfoPtr_LateUpdate_Private_Void_0;

		// Token: 0x040038A2 RID: 14498
		private static readonly System.IntPtr NativeMethodInfoPtr_Move_Protected_Virtual_New_Void_0;

		// Token: 0x040038A3 RID: 14499
		private static readonly System.IntPtr NativeMethodInfoPtr_ClampMovement_Private_Void_0;

		// Token: 0x040038A4 RID: 14500
		private static readonly System.IntPtr NativeMethodInfoPtr_GetSurfaceAngle_Protected_Single_0;

		// Token: 0x040038A5 RID: 14501
		private static readonly System.IntPtr NativeMethodInfoPtr_isGrounded_Private_Boolean_0;

		// Token: 0x040038A6 RID: 14502
		private static readonly System.IntPtr NativeMethodInfoPtr_UpdateHorizontalAxis_Protected_Void_0;

		// Token: 0x040038A7 RID: 14503
		private static readonly System.IntPtr NativeMethodInfoPtr_UpdateVerticalAxis_Protected_Void_0;

		// Token: 0x040038A8 RID: 14504
		private static readonly System.IntPtr NativeMethodInfoPtr_Jump_Private_IEnumerator_0;

		// Token: 0x040038A9 RID: 14505
		private static readonly System.IntPtr NativeMethodInfoPtr_TryToggleCrouch_Private_Void_0;

		// Token: 0x040038AA RID: 14506
		private static readonly System.IntPtr NativeMethodInfoPtr_CanStand_Public_Boolean_0;

		// Token: 0x040038AB RID: 14507
		private static readonly System.IntPtr NativeMethodInfoPtr_SetCrouched_Public_Void_Boolean_0;

		// Token: 0x040038AC RID: 14508
		private static readonly System.IntPtr NativeMethodInfoPtr_UpdateCrouchVignetteEffect_Private_Void_0;

		// Token: 0x040038AD RID: 14509
		private static readonly System.IntPtr NativeMethodInfoPtr_UpdatePlayerHeight_Private_Void_0;

		// Token: 0x040038AE RID: 14510
		private static readonly System.IntPtr NativeMethodInfoPtr_LerpPlayerRotation_Public_Void_Quaternion_Single_0;

		// Token: 0x040038AF RID: 14511
		private static readonly System.IntPtr NativeMethodInfoPtr_LerpPlayerRotation_Process_Private_IEnumerator_Quaternion_Single_0;

		// Token: 0x040038B0 RID: 14512
		private static readonly System.IntPtr NativeMethodInfoPtr_EnterVehicle_Private_Void_LandVehicle_0;

		// Token: 0x040038B1 RID: 14513
		private static readonly System.IntPtr NativeMethodInfoPtr_ExitVehicle_Private_Void_LandVehicle_Transform_0;

		// Token: 0x040038B2 RID: 14514
		private static readonly System.IntPtr NativeMethodInfoPtr_Teleport_Public_Void_Vector3_0;

		// Token: 0x040038B3 RID: 14515
		private static readonly System.IntPtr NativeMethodInfoPtr_SetResidualVelocity_Public_Void_Vector3_Single_Single_0;

		// Token: 0x040038B4 RID: 14516
		private static readonly System.IntPtr NativeMethodInfoPtr_WarpToNavMesh_Public_Void_0;

		// Token: 0x040038B5 RID: 14517
		private static readonly System.IntPtr NativeMethodInfoPtr_RegisterMovementEvent_Public_Void_Int32_Action_0;

		// Token: 0x040038B6 RID: 14518
		private static readonly System.IntPtr NativeMethodInfoPtr_DeregisterMovementEvent_Public_Void_Action_0;

		// Token: 0x040038B7 RID: 14519
		private static readonly System.IntPtr NativeMethodInfoPtr_UpdateMovementEvents_Private_Void_0;

		// Token: 0x040038B8 RID: 14520
		private static readonly System.IntPtr NativeMethodInfoPtr_ChangeStamina_Public_Void_Single_Boolean_0;

		// Token: 0x040038B9 RID: 14521
		private static readonly System.IntPtr NativeMethodInfoPtr_SetStamina_Public_Void_Single_Boolean_0;

		// Token: 0x040038BA RID: 14522
		private static readonly System.IntPtr NativeMethodInfoPtr_AddSprintBlocker_Public_Void_String_0;

		// Token: 0x040038BB RID: 14523
		private static readonly System.IntPtr NativeMethodInfoPtr_RemoveSprintBlocker_Public_Void_String_0;

		// Token: 0x040038BC RID: 14524
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040038BD RID: 14525
		private static readonly System.IntPtr NativeMethodInfoPtr__Start_b__105_0_Private_Void_0;

		// Token: 0x020009F3 RID: 2547
		public class MovementEvent : Il2CppSystem.Object
		{
			// Token: 0x0600D07A RID: 53370 RVA: 0x00327678 File Offset: 0x00325878
			// Note: this type is marked as 'beforefieldinit'.
			static MovementEvent()
			{
				Il2CppClassPointerStore<PlayerMovement.MovementEvent>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, "MovementEvent");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayerMovement.MovementEvent>.NativeClassPtr);
				PlayerMovement.MovementEvent.NativeFieldInfoPtr_actions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMovement.MovementEvent>.NativeClassPtr, "actions");
				PlayerMovement.MovementEvent.NativeFieldInfoPtr_LastUpdatedDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMovement.MovementEvent>.NativeClassPtr, "LastUpdatedDistance");
				PlayerMovement.MovementEvent.NativeMethodInfoPtr_Update_Public_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerMovement.MovementEvent>.NativeClassPtr, 100673843);
				PlayerMovement.MovementEvent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerMovement.MovementEvent>.NativeClassPtr, 100673844);
			}

			// Token: 0x0600D07B RID: 53371 RVA: 0x003276F4 File Offset: 0x003258F4
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 181016, RefRangeEnd = 181018, XrefRangeStart = 181002, XrefRangeEnd = 181016, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Update(Vector3 newPosition)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = ref newPosition;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerMovement.MovementEvent.NativeMethodInfoPtr_Update_Public_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600D07C RID: 53372 RVA: 0x00327734 File Offset: 0x00325934
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 181028, RefRangeEnd = 181029, XrefRangeStart = 181018, XrefRangeEnd = 181028, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe MovementEvent() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayerMovement.MovementEvent>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerMovement.MovementEvent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600D07D RID: 53373 RVA: 0x00065140 File Offset: 0x00063340
			public MovementEvent(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700409F RID: 16543
			// (get) Token: 0x0600D07E RID: 53374 RVA: 0x00327770 File Offset: 0x00325970
			// (set) Token: 0x0600D07F RID: 53375 RVA: 0x00065149 File Offset: 0x00063349
			public unsafe List<Il2CppSystem.Action> actions
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.MovementEvent.NativeFieldInfoPtr_actions);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Il2CppSystem.Action>>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.MovementEvent.NativeFieldInfoPtr_actions), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170040A0 RID: 16544
			// (get) Token: 0x0600D080 RID: 53376 RVA: 0x003277A0 File Offset: 0x003259A0
			// (set) Token: 0x0600D081 RID: 53377 RVA: 0x00065168 File Offset: 0x00063368
			public unsafe Vector3 LastUpdatedDistance
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.MovementEvent.NativeFieldInfoPtr_LastUpdatedDistance);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement.MovementEvent.NativeFieldInfoPtr_LastUpdatedDistance)) = value;
				}
			}

			// Token: 0x04008CFA RID: 36090
			private static readonly System.IntPtr NativeFieldInfoPtr_actions;

			// Token: 0x04008CFB RID: 36091
			private static readonly System.IntPtr NativeFieldInfoPtr_LastUpdatedDistance;

			// Token: 0x04008CFC RID: 36092
			private static readonly System.IntPtr NativeMethodInfoPtr_Update_Public_Void_Vector3_0;

			// Token: 0x04008CFD RID: 36093
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x020009F4 RID: 2548
		[ObfuscatedName("ScheduleOne.PlayerScripts.PlayerMovement+<Jump>d__115")]
		public sealed class _Jump_d__115 : Il2CppSystem.Object
		{
			// Token: 0x0600D082 RID: 53378 RVA: 0x003277C8 File Offset: 0x003259C8
			// Note: this type is marked as 'beforefieldinit'.
			static _Jump_d__115()
			{
				Il2CppClassPointerStore<PlayerMovement._Jump_d__115>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, "<Jump>d__115");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayerMovement._Jump_d__115>.NativeClassPtr);
				PlayerMovement._Jump_d__115.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMovement._Jump_d__115>.NativeClassPtr, "<>1__state");
				PlayerMovement._Jump_d__115.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMovement._Jump_d__115>.NativeClassPtr, "<>2__current");
				PlayerMovement._Jump_d__115.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMovement._Jump_d__115>.NativeClassPtr, "<>4__this");
				PlayerMovement._Jump_d__115.NativeFieldInfoPtr__savedSlopeLimit_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMovement._Jump_d__115>.NativeClassPtr, "<savedSlopeLimit>5__2");
				PlayerMovement._Jump_d__115.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerMovement._Jump_d__115>.NativeClassPtr, 100673845);
				PlayerMovement._Jump_d__115.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerMovement._Jump_d__115>.NativeClassPtr, 100673846);
				PlayerMovement._Jump_d__115.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerMovement._Jump_d__115>.NativeClassPtr, 100673847);
				PlayerMovement._Jump_d__115.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerMovement._Jump_d__115>.NativeClassPtr, 100673848);
				PlayerMovement._Jump_d__115.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerMovement._Jump_d__115>.NativeClassPtr, 100673849);
				PlayerMovement._Jump_d__115.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerMovement._Jump_d__115>.NativeClassPtr, 100673850);
			}

			// Token: 0x0600D083 RID: 53379 RVA: 0x003278BC File Offset: 0x00325ABC
			[CallerCount(54)]
			[CachedScanResults(RefRangeStart = 2646, RefRangeEnd = 2700, XrefRangeStart = 2646, XrefRangeEnd = 2700, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _Jump_d__115(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayerMovement._Jump_d__115>.NativeClassPtr))
			{
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = ref <>1__state;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerMovement._Jump_d__115.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600D084 RID: 53380 RVA: 0x00327904 File Offset: 0x00325B04
			[CallerCount(14558)]
			[CachedScanResults(RefRangeStart = 2769, RefRangeEnd = 17327, XrefRangeStart = 2769, XrefRangeEnd = 17327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerMovement._Jump_d__115.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600D085 RID: 53381 RVA: 0x00327938 File Offset: 0x00325B38
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 181029, XrefRangeEnd = 181048, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(PlayerMovement._Jump_d__115.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x170040A5 RID: 16549
			// (get) Token: 0x0600D086 RID: 53382 RVA: 0x00327974 File Offset: 0x00325B74
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 2740, RefRangeEnd = 2764, XrefRangeStart = 2740, XrefRangeEnd = 2764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerMovement._Jump_d__115.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
			}

			// Token: 0x0600D087 RID: 53383 RVA: 0x003279B4 File Offset: 0x00325BB4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 181048, XrefRangeEnd = 181053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerMovement._Jump_d__115.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x170040A6 RID: 16550
			// (get) Token: 0x0600D088 RID: 53384 RVA: 0x003279E8 File Offset: 0x00325BE8
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 2740, RefRangeEnd = 2764, XrefRangeStart = 2740, XrefRangeEnd = 2764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerMovement._Jump_d__115.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
			}

			// Token: 0x0600D089 RID: 53385 RVA: 0x00065183 File Offset: 0x00063383
			public _Jump_d__115(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170040A1 RID: 16545
			// (get) Token: 0x0600D08A RID: 53386 RVA: 0x00327A28 File Offset: 0x00325C28
			// (set) Token: 0x0600D08B RID: 53387 RVA: 0x0006518C File Offset: 0x0006338C
			public unsafe int __1__state
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement._Jump_d__115.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement._Jump_d__115.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170040A2 RID: 16546
			// (get) Token: 0x0600D08C RID: 53388 RVA: 0x00327A50 File Offset: 0x00325C50
			// (set) Token: 0x0600D08D RID: 53389 RVA: 0x000651A7 File Offset: 0x000633A7
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement._Jump_d__115.NativeFieldInfoPtr___2__current);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement._Jump_d__115.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170040A3 RID: 16547
			// (get) Token: 0x0600D08E RID: 53390 RVA: 0x00327A80 File Offset: 0x00325C80
			// (set) Token: 0x0600D08F RID: 53391 RVA: 0x000651C6 File Offset: 0x000633C6
			public unsafe PlayerMovement __4__this
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement._Jump_d__115.NativeFieldInfoPtr___4__this);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlayerMovement>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement._Jump_d__115.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170040A4 RID: 16548
			// (get) Token: 0x0600D090 RID: 53392 RVA: 0x00327AB0 File Offset: 0x00325CB0
			// (set) Token: 0x0600D091 RID: 53393 RVA: 0x000651E5 File Offset: 0x000633E5
			public unsafe float _savedSlopeLimit_5__2
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement._Jump_d__115.NativeFieldInfoPtr__savedSlopeLimit_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement._Jump_d__115.NativeFieldInfoPtr__savedSlopeLimit_5__2)) = value;
				}
			}

			// Token: 0x04008CFE RID: 36094
			private static readonly System.IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04008CFF RID: 36095
			private static readonly System.IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04008D00 RID: 36096
			private static readonly System.IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04008D01 RID: 36097
			private static readonly System.IntPtr NativeFieldInfoPtr__savedSlopeLimit_5__2;

			// Token: 0x04008D02 RID: 36098
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04008D03 RID: 36099
			private static readonly System.IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008D04 RID: 36100
			private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04008D05 RID: 36101
			private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04008D06 RID: 36102
			private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008D07 RID: 36103
			private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x020009F5 RID: 2549
		[ObfuscatedName("ScheduleOne.PlayerScripts.PlayerMovement+<LerpPlayerRotation_Process>d__123")]
		public sealed class _LerpPlayerRotation_Process_d__123 : Il2CppSystem.Object
		{
			// Token: 0x0600D092 RID: 53394 RVA: 0x00327AD8 File Offset: 0x00325CD8
			// Note: this type is marked as 'beforefieldinit'.
			static _LerpPlayerRotation_Process_d__123()
			{
				Il2CppClassPointerStore<PlayerMovement._LerpPlayerRotation_Process_d__123>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PlayerMovement>.NativeClassPtr, "<LerpPlayerRotation_Process>d__123");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayerMovement._LerpPlayerRotation_Process_d__123>.NativeClassPtr);
				PlayerMovement._LerpPlayerRotation_Process_d__123.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMovement._LerpPlayerRotation_Process_d__123>.NativeClassPtr, "<>1__state");
				PlayerMovement._LerpPlayerRotation_Process_d__123.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMovement._LerpPlayerRotation_Process_d__123>.NativeClassPtr, "<>2__current");
				PlayerMovement._LerpPlayerRotation_Process_d__123.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMovement._LerpPlayerRotation_Process_d__123>.NativeClassPtr, "<>4__this");
				PlayerMovement._LerpPlayerRotation_Process_d__123.NativeFieldInfoPtr_endRotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMovement._LerpPlayerRotation_Process_d__123>.NativeClassPtr, "endRotation");
				PlayerMovement._LerpPlayerRotation_Process_d__123.NativeFieldInfoPtr_lerpTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMovement._LerpPlayerRotation_Process_d__123>.NativeClassPtr, "lerpTime");
				PlayerMovement._LerpPlayerRotation_Process_d__123.NativeFieldInfoPtr__startRot_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMovement._LerpPlayerRotation_Process_d__123>.NativeClassPtr, "<startRot>5__2");
				PlayerMovement._LerpPlayerRotation_Process_d__123.NativeFieldInfoPtr__i_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMovement._LerpPlayerRotation_Process_d__123>.NativeClassPtr, "<i>5__3");
				PlayerMovement._LerpPlayerRotation_Process_d__123.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerMovement._LerpPlayerRotation_Process_d__123>.NativeClassPtr, 100673851);
				PlayerMovement._LerpPlayerRotation_Process_d__123.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerMovement._LerpPlayerRotation_Process_d__123>.NativeClassPtr, 100673852);
				PlayerMovement._LerpPlayerRotation_Process_d__123.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerMovement._LerpPlayerRotation_Process_d__123>.NativeClassPtr, 100673853);
				PlayerMovement._LerpPlayerRotation_Process_d__123.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerMovement._LerpPlayerRotation_Process_d__123>.NativeClassPtr, 100673854);
				PlayerMovement._LerpPlayerRotation_Process_d__123.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerMovement._LerpPlayerRotation_Process_d__123>.NativeClassPtr, 100673855);
				PlayerMovement._LerpPlayerRotation_Process_d__123.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerMovement._LerpPlayerRotation_Process_d__123>.NativeClassPtr, 100673856);
			}

			// Token: 0x0600D093 RID: 53395 RVA: 0x00327C08 File Offset: 0x00325E08
			[CallerCount(54)]
			[CachedScanResults(RefRangeStart = 2646, RefRangeEnd = 2700, XrefRangeStart = 2646, XrefRangeEnd = 2700, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _LerpPlayerRotation_Process_d__123(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayerMovement._LerpPlayerRotation_Process_d__123>.NativeClassPtr))
			{
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = ref <>1__state;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerMovement._LerpPlayerRotation_Process_d__123.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600D094 RID: 53396 RVA: 0x00327C50 File Offset: 0x00325E50
			[CallerCount(14558)]
			[CachedScanResults(RefRangeStart = 2769, RefRangeEnd = 17327, XrefRangeStart = 2769, XrefRangeEnd = 17327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerMovement._LerpPlayerRotation_Process_d__123.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600D095 RID: 53397 RVA: 0x00327C84 File Offset: 0x00325E84
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 181053, XrefRangeEnd = 181066, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(PlayerMovement._LerpPlayerRotation_Process_d__123.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x170040AE RID: 16558
			// (get) Token: 0x0600D096 RID: 53398 RVA: 0x00327CC0 File Offset: 0x00325EC0
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 2740, RefRangeEnd = 2764, XrefRangeStart = 2740, XrefRangeEnd = 2764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerMovement._LerpPlayerRotation_Process_d__123.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
			}

			// Token: 0x0600D097 RID: 53399 RVA: 0x00327D00 File Offset: 0x00325F00
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 181066, XrefRangeEnd = 181071, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerMovement._LerpPlayerRotation_Process_d__123.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x170040AF RID: 16559
			// (get) Token: 0x0600D098 RID: 53400 RVA: 0x00327D34 File Offset: 0x00325F34
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 2740, RefRangeEnd = 2764, XrefRangeStart = 2740, XrefRangeEnd = 2764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerMovement._LerpPlayerRotation_Process_d__123.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
			}

			// Token: 0x0600D099 RID: 53401 RVA: 0x00065200 File Offset: 0x00063400
			public _LerpPlayerRotation_Process_d__123(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170040A7 RID: 16551
			// (get) Token: 0x0600D09A RID: 53402 RVA: 0x00327D74 File Offset: 0x00325F74
			// (set) Token: 0x0600D09B RID: 53403 RVA: 0x00065209 File Offset: 0x00063409
			public unsafe int __1__state
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement._LerpPlayerRotation_Process_d__123.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement._LerpPlayerRotation_Process_d__123.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170040A8 RID: 16552
			// (get) Token: 0x0600D09C RID: 53404 RVA: 0x00327D9C File Offset: 0x00325F9C
			// (set) Token: 0x0600D09D RID: 53405 RVA: 0x00065224 File Offset: 0x00063424
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement._LerpPlayerRotation_Process_d__123.NativeFieldInfoPtr___2__current);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement._LerpPlayerRotation_Process_d__123.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170040A9 RID: 16553
			// (get) Token: 0x0600D09E RID: 53406 RVA: 0x00327DCC File Offset: 0x00325FCC
			// (set) Token: 0x0600D09F RID: 53407 RVA: 0x00065243 File Offset: 0x00063443
			public unsafe PlayerMovement __4__this
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement._LerpPlayerRotation_Process_d__123.NativeFieldInfoPtr___4__this);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlayerMovement>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement._LerpPlayerRotation_Process_d__123.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170040AA RID: 16554
			// (get) Token: 0x0600D0A0 RID: 53408 RVA: 0x00327DFC File Offset: 0x00325FFC
			// (set) Token: 0x0600D0A1 RID: 53409 RVA: 0x00065262 File Offset: 0x00063462
			public unsafe Quaternion endRotation
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement._LerpPlayerRotation_Process_d__123.NativeFieldInfoPtr_endRotation);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement._LerpPlayerRotation_Process_d__123.NativeFieldInfoPtr_endRotation)) = value;
				}
			}

			// Token: 0x170040AB RID: 16555
			// (get) Token: 0x0600D0A2 RID: 53410 RVA: 0x00327E24 File Offset: 0x00326024
			// (set) Token: 0x0600D0A3 RID: 53411 RVA: 0x0006527D File Offset: 0x0006347D
			public unsafe float lerpTime
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement._LerpPlayerRotation_Process_d__123.NativeFieldInfoPtr_lerpTime);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement._LerpPlayerRotation_Process_d__123.NativeFieldInfoPtr_lerpTime)) = value;
				}
			}

			// Token: 0x170040AC RID: 16556
			// (get) Token: 0x0600D0A4 RID: 53412 RVA: 0x00327E4C File Offset: 0x0032604C
			// (set) Token: 0x0600D0A5 RID: 53413 RVA: 0x00065298 File Offset: 0x00063498
			public unsafe Quaternion _startRot_5__2
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement._LerpPlayerRotation_Process_d__123.NativeFieldInfoPtr__startRot_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement._LerpPlayerRotation_Process_d__123.NativeFieldInfoPtr__startRot_5__2)) = value;
				}
			}

			// Token: 0x170040AD RID: 16557
			// (get) Token: 0x0600D0A6 RID: 53414 RVA: 0x00327E74 File Offset: 0x00326074
			// (set) Token: 0x0600D0A7 RID: 53415 RVA: 0x000652B3 File Offset: 0x000634B3
			public unsafe float _i_5__3
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement._LerpPlayerRotation_Process_d__123.NativeFieldInfoPtr__i_5__3);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerMovement._LerpPlayerRotation_Process_d__123.NativeFieldInfoPtr__i_5__3)) = value;
				}
			}

			// Token: 0x04008D08 RID: 36104
			private static readonly System.IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04008D09 RID: 36105
			private static readonly System.IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04008D0A RID: 36106
			private static readonly System.IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04008D0B RID: 36107
			private static readonly System.IntPtr NativeFieldInfoPtr_endRotation;

			// Token: 0x04008D0C RID: 36108
			private static readonly System.IntPtr NativeFieldInfoPtr_lerpTime;

			// Token: 0x04008D0D RID: 36109
			private static readonly System.IntPtr NativeFieldInfoPtr__startRot_5__2;

			// Token: 0x04008D0E RID: 36110
			private static readonly System.IntPtr NativeFieldInfoPtr__i_5__3;

			// Token: 0x04008D0F RID: 36111
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04008D10 RID: 36112
			private static readonly System.IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008D11 RID: 36113
			private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04008D12 RID: 36114
			private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04008D13 RID: 36115
			private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008D14 RID: 36116
			private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
