using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Audio;
using Il2CppScheduleOne.DevUtilities;
using Il2CppScheduleOne.Tools;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;

namespace Il2CppScheduleOne.PlayerScripts
{
	// Token: 0x02000403 RID: 1027
	public class PlayerCamera : PlayerSingleton<PlayerCamera>
	{
		// Token: 0x060050A8 RID: 20648 RVA: 0x0018391C File Offset: 0x00181B1C
		// Note: this type is marked as 'beforefieldinit'.
		static PlayerCamera()
		{
			Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.PlayerScripts", "PlayerCamera");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr);
			PlayerCamera.NativeFieldInfoPtr_CAMERA_SHAKE_MULTIPLIER = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, "CAMERA_SHAKE_MULTIPLIER");
			PlayerCamera.NativeFieldInfoPtr__AntiAliasingMode_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, "<AntiAliasingMode>k__BackingField");
			PlayerCamera.NativeFieldInfoPtr_cameraOffsetFromTop = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, "cameraOffsetFromTop");
			PlayerCamera.NativeFieldInfoPtr_SprintFoVBoost = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, "SprintFoVBoost");
			PlayerCamera.NativeFieldInfoPtr_FoVChangeRate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, "FoVChangeRate");
			PlayerCamera.NativeFieldInfoPtr_HorizontalCameraBob = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, "HorizontalCameraBob");
			PlayerCamera.NativeFieldInfoPtr_VerticalCameraBob = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, "VerticalCameraBob");
			PlayerCamera.NativeFieldInfoPtr_BobRate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, "BobRate");
			PlayerCamera.NativeFieldInfoPtr_HorizontalBobCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, "HorizontalBobCurve");
			PlayerCamera.NativeFieldInfoPtr_VerticalBobCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, "VerticalBobCurve");
			PlayerCamera.NativeFieldInfoPtr_FreeCamSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, "FreeCamSpeed");
			PlayerCamera.NativeFieldInfoPtr_FreeCamAcceleration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, "FreeCamAcceleration");
			PlayerCamera.NativeFieldInfoPtr_SmoothLook = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, "SmoothLook");
			PlayerCamera.NativeFieldInfoPtr_SmoothLookSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, "SmoothLookSpeed");
			PlayerCamera.NativeFieldInfoPtr_FoVChangeSmoother = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, "FoVChangeSmoother");
			PlayerCamera.NativeFieldInfoPtr_SmoothLookSmoother = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, "SmoothLookSmoother");
			PlayerCamera.NativeFieldInfoPtr_CameraContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, "CameraContainer");
			PlayerCamera.NativeFieldInfoPtr_Camera = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, "Camera");
			PlayerCamera.NativeFieldInfoPtr_OverlayCamera = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, "OverlayCamera");
			PlayerCamera.NativeFieldInfoPtr_Animator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, "Animator");
			PlayerCamera.NativeFieldInfoPtr_JoltClips = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, "JoltClips");
			PlayerCamera.NativeFieldInfoPtr_URPAssets = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, "URPAssets");
			PlayerCamera.NativeFieldInfoPtr_ViewAvatarCameraPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, "ViewAvatarCameraPosition");
			PlayerCamera.NativeFieldInfoPtr_HeartbeatSoundController = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, "HeartbeatSoundController");
			PlayerCamera.NativeFieldInfoPtr_Flies = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, "Flies");
			PlayerCamera.NativeFieldInfoPtr_MethRumble = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, "MethRumble");
			PlayerCamera.NativeFieldInfoPtr_SchizoVoices = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, "SchizoVoices");
			PlayerCamera.NativeFieldInfoPtr__canLook_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, "<canLook>k__BackingField");
			PlayerCamera.NativeFieldInfoPtr__transformOverriden_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, "<transformOverriden>k__BackingField");
			PlayerCamera.NativeFieldInfoPtr__fovOverriden_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, "<fovOverriden>k__BackingField");
			PlayerCamera.NativeFieldInfoPtr_blockNextStopTransformOverride = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, "blockNextStopTransformOverride");
			PlayerCamera.NativeFieldInfoPtr__FreeCamEnabled_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, "<FreeCamEnabled>k__BackingField");
			PlayerCamera.NativeFieldInfoPtr__ViewingAvatar_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, "<ViewingAvatar>k__BackingField");
			PlayerCamera.NativeFieldInfoPtr__CameraMode_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, "<CameraMode>k__BackingField");
			PlayerCamera.NativeFieldInfoPtr__MethVisuals_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, "<MethVisuals>k__BackingField");
			PlayerCamera.NativeFieldInfoPtr__CocaineVisuals_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, "<CocaineVisuals>k__BackingField");
			PlayerCamera.NativeFieldInfoPtr__FovJitter_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, "<FovJitter>k__BackingField");
			PlayerCamera.NativeFieldInfoPtr_globalVolume = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, "globalVolume");
			PlayerCamera.NativeFieldInfoPtr_DoF = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, "DoF");
			PlayerCamera.NativeFieldInfoPtr__activeUIElements_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, "<activeUIElements>k__BackingField");
			PlayerCamera.NativeFieldInfoPtr_cameraShakeCoroutine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, "cameraShakeCoroutine");
			PlayerCamera.NativeFieldInfoPtr_cameraLocalPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, "cameraLocalPos");
			PlayerCamera.NativeFieldInfoPtr_freeCamMovement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, "freeCamMovement");
			PlayerCamera.NativeFieldInfoPtr_focusRoutine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, "focusRoutine");
			PlayerCamera.NativeFieldInfoPtr_focusMouseX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, "focusMouseX");
			PlayerCamera.NativeFieldInfoPtr_focusMouseY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, "focusMouseY");
			PlayerCamera.NativeFieldInfoPtr_movementEvents = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, "movementEvents");
			PlayerCamera.NativeFieldInfoPtr_freeCamSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, "freeCamSpeed");
			PlayerCamera.NativeFieldInfoPtr_mouseX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, "mouseX");
			PlayerCamera.NativeFieldInfoPtr_mouseY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, "mouseY");
			PlayerCamera.NativeFieldInfoPtr_seizureJitter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, "seizureJitter");
			PlayerCamera.NativeFieldInfoPtr_schizoFoV = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, "schizoFoV");
			PlayerCamera.NativeFieldInfoPtr_timeUntilNextSchizoVoice = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, "timeUntilNextSchizoVoice");
			PlayerCamera.NativeFieldInfoPtr_gizmos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, "gizmos");
			PlayerCamera.NativeFieldInfoPtr_cameralocalPos_PriorOverride = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, "cameralocalPos_PriorOverride");
			PlayerCamera.NativeFieldInfoPtr_cameraLocalRot_PriorOverride = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, "cameraLocalRot_PriorOverride");
			PlayerCamera.NativeFieldInfoPtr_ILerpCamera_Coroutine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, "ILerpCamera_Coroutine");
			PlayerCamera.NativeFieldInfoPtr_lookRoutine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, "lookRoutine");
			PlayerCamera.NativeFieldInfoPtr_DoFCoroutine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, "DoFCoroutine");
			PlayerCamera.NativeFieldInfoPtr_ILerpCameraFOV_Coroutine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, "ILerpCameraFOV_Coroutine");
			PlayerCamera.NativeMethodInfoPtr_get_AntiAliasingMode_Public_Static_get_EAntiAliasingMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, 100673457);
			PlayerCamera.NativeMethodInfoPtr_set_AntiAliasingMode_Private_Static_set_Void_EAntiAliasingMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, 100673458);
			PlayerCamera.NativeMethodInfoPtr_get_canLook_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, 100673459);
			PlayerCamera.NativeMethodInfoPtr_set_canLook_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, 100673460);
			PlayerCamera.NativeMethodInfoPtr_get_activeUIElementCount_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, 100673461);
			PlayerCamera.NativeMethodInfoPtr_get_transformOverriden_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, 100673462);
			PlayerCamera.NativeMethodInfoPtr_set_transformOverriden_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, 100673463);
			PlayerCamera.NativeMethodInfoPtr_get_fovOverriden_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, 100673464);
			PlayerCamera.NativeMethodInfoPtr_set_fovOverriden_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, 100673465);
			PlayerCamera.NativeMethodInfoPtr_get_FreeCamEnabled_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, 100673466);
			PlayerCamera.NativeMethodInfoPtr_set_FreeCamEnabled_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, 100673467);
			PlayerCamera.NativeMethodInfoPtr_get_ViewingAvatar_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, 100673468);
			PlayerCamera.NativeMethodInfoPtr_set_ViewingAvatar_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, 100673469);
			PlayerCamera.NativeMethodInfoPtr_get_CameraMode_Public_get_ECameraMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, 100673470);
			PlayerCamera.NativeMethodInfoPtr_set_CameraMode_Protected_set_Void_ECameraMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, 100673471);
			PlayerCamera.NativeMethodInfoPtr_get_MethVisuals_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, 100673472);
			PlayerCamera.NativeMethodInfoPtr_set_MethVisuals_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, 100673473);
			PlayerCamera.NativeMethodInfoPtr_get_CocaineVisuals_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, 100673474);
			PlayerCamera.NativeMethodInfoPtr_set_CocaineVisuals_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, 100673475);
			PlayerCamera.NativeMethodInfoPtr_get_FovJitter_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, 100673476);
			PlayerCamera.NativeMethodInfoPtr_set_FovJitter_Private_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, 100673477);
			PlayerCamera.NativeMethodInfoPtr_get_activeUIElements_Public_get_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, 100673478);
			PlayerCamera.NativeMethodInfoPtr_set_activeUIElements_Protected_set_Void_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, 100673479);
			PlayerCamera.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, 100673480);
			PlayerCamera.NativeMethodInfoPtr_OnStartClient_Public_Virtual_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, 100673481);
			PlayerCamera.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, 100673482);
			PlayerCamera.NativeMethodInfoPtr_PlayerSpawned_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, 100673483);
			PlayerCamera.NativeMethodInfoPtr_SetAntialiasingMode_Public_Static_Void_EAntiAliasingMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, 100673484);
			PlayerCamera.NativeMethodInfoPtr_ApplyAASettings_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, 100673485);
			PlayerCamera.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, 100673486);
			PlayerCamera.NativeMethodInfoPtr_Screenshot_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, 100673487);
			PlayerCamera.NativeMethodInfoPtr_LateUpdate_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, 100673488);
			PlayerCamera.NativeMethodInfoPtr_Exit_Private_Void_ExitAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, 100673489);
			PlayerCamera.NativeMethodInfoPtr_GetTargetLocalY_Public_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, 100673490);
			PlayerCamera.NativeMethodInfoPtr_SetCameraMode_Public_Void_ECameraMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, 100673491);
			PlayerCamera.NativeMethodInfoPtr_RotateCamera_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, 100673492);
			PlayerCamera.NativeMethodInfoPtr_LockMouse_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, 100673493);
			PlayerCamera.NativeMethodInfoPtr_FreeMouse_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, 100673494);
			PlayerCamera.NativeMethodInfoPtr_LookRaycast_Public_Boolean_Single_byref_RaycastHit_LayerMask_Boolean_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, 100673495);
			PlayerCamera.NativeMethodInfoPtr_LookRaycast_ExcludeBuildables_Public_Boolean_Single_byref_RaycastHit_LayerMask_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, 100673496);
			PlayerCamera.NativeMethodInfoPtr_OnDrawGizmosSelected_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, 100673497);
			PlayerCamera.NativeMethodInfoPtr_Raycast_ExcludeBuildables_Public_Boolean_Vector3_Vector3_Single_byref_RaycastHit_LayerMask_Boolean_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, 100673498);
			PlayerCamera.NativeMethodInfoPtr_MouseRaycast_Public_Boolean_Single_byref_RaycastHit_LayerMask_Boolean_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, 100673499);
			PlayerCamera.NativeMethodInfoPtr_LookSpherecast_Public_Boolean_Single_Single_byref_RaycastHit_LayerMask_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, 100673500);
			PlayerCamera.NativeMethodInfoPtr_OverrideTransform_Public_Void_Vector3_Quaternion_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, 100673501);
			PlayerCamera.NativeMethodInfoPtr_ILerpCamera_Protected_IEnumerator_Vector3_Quaternion_Single_Boolean_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, 100673502);
			PlayerCamera.NativeMethodInfoPtr_StopTransformOverride_Public_Void_Single_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, 100673503);
			PlayerCamera.NativeMethodInfoPtr_LookAt_Public_Void_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, 100673504);
			PlayerCamera.NativeMethodInfoPtr_SetCanLook_True_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, 100673505);
			PlayerCamera.NativeMethodInfoPtr_SetCanLook_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, 100673506);
			PlayerCamera.NativeMethodInfoPtr_SetDoFActive_Public_Void_Boolean_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, 100673507);
			PlayerCamera.NativeMethodInfoPtr_LerpDoF_Private_IEnumerator_Boolean_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, 100673508);
			PlayerCamera.NativeMethodInfoPtr_OverrideFOV_Public_Void_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, 100673509);
			PlayerCamera.NativeMethodInfoPtr_ILerpFOV_Protected_IEnumerator_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, 100673510);
			PlayerCamera.NativeMethodInfoPtr_StopFOVOverride_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, 100673511);
			PlayerCamera.NativeMethodInfoPtr_AddActiveUIElement_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, 100673512);
			PlayerCamera.NativeMethodInfoPtr_RemoveActiveUIElement_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, 100673513);
			PlayerCamera.NativeMethodInfoPtr_RegisterMovementEvent_Public_Void_Int32_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, 100673514);
			PlayerCamera.NativeMethodInfoPtr_DeregisterMovementEvent_Public_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, 100673515);
			PlayerCamera.NativeMethodInfoPtr_UpdateMovementEvents_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, 100673516);
			PlayerCamera.NativeMethodInfoPtr_ViewAvatar_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, 100673517);
			PlayerCamera.NativeMethodInfoPtr_StopViewingAvatar_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, 100673518);
			PlayerCamera.NativeMethodInfoPtr_JoltCamera_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, 100673519);
			PlayerCamera.NativeMethodInfoPtr_PointInCameraView_Public_Boolean_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, 100673520);
			PlayerCamera.NativeMethodInfoPtr_Is01_Public_Boolean_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, 100673521);
			PlayerCamera.NativeMethodInfoPtr_ResetRotation_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, 100673522);
			PlayerCamera.NativeMethodInfoPtr_FocusCameraOnTarget_Public_Void_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, 100673523);
			PlayerCamera.NativeMethodInfoPtr_StopFocus_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, 100673524);
			PlayerCamera.NativeMethodInfoPtr_StartCameraShake_Public_Void_Single_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, 100673525);
			PlayerCamera.NativeMethodInfoPtr_StopCameraShake_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, 100673526);
			PlayerCamera.NativeMethodInfoPtr_UpdateCameraBob_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, 100673527);
			PlayerCamera.NativeMethodInfoPtr_SetFreeCam_Public_Void_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, 100673528);
			PlayerCamera.NativeMethodInfoPtr_RotateFreeCam_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, 100673529);
			PlayerCamera.NativeMethodInfoPtr_UpdateFreeCamInput_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, 100673530);
			PlayerCamera.NativeMethodInfoPtr_MoveFreeCam_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, 100673531);
			PlayerCamera.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, 100673532);
			PlayerCamera.NativeMethodInfoPtr__PlayerSpawned_b__92_0_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, 100673533);
			PlayerCamera.NativeMethodInfoPtr_Method_Internal_Static_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, 100673534);
		}

		// Token: 0x17001834 RID: 6196
		// (get) Token: 0x060050A9 RID: 20649 RVA: 0x00184414 File Offset: 0x00182614
		// (set) Token: 0x060050AA RID: 20650 RVA: 0x00184444 File Offset: 0x00182644
		public unsafe static Il2CppScheduleOne.DevUtilities.GraphicsSettings.EAntiAliasingMode AntiAliasingMode
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 176419, XrefRangeEnd = 176421, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(PlayerCamera.NativeMethodInfoPtr_get_AntiAliasingMode_Public_Static_get_EAntiAliasingMode_0, 0, (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 176421, XrefRangeEnd = 176423, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = ref value;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCamera.NativeMethodInfoPtr_set_AntiAliasingMode_Private_Static_set_Void_EAntiAliasingMode_0, 0, (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x17001835 RID: 6197
		// (get) Token: 0x060050AB RID: 20651 RVA: 0x00184478 File Offset: 0x00182678
		// (set) Token: 0x060050AC RID: 20652 RVA: 0x001844B4 File Offset: 0x001826B4
		public unsafe bool canLook
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(PlayerCamera.NativeMethodInfoPtr_get_canLook_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
			[CallerCount(53)]
			[CachedScanResults(RefRangeStart = 51677, RefRangeEnd = 51730, XrefRangeStart = 51677, XrefRangeEnd = 51730, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = ref value;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCamera.NativeMethodInfoPtr_set_canLook_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x17001836 RID: 6198
		// (get) Token: 0x060050AD RID: 20653 RVA: 0x001844F4 File Offset: 0x001826F4
		public unsafe int activeUIElementCount
		{
			[CallerCount(18)]
			[CachedScanResults(RefRangeStart = 176424, RefRangeEnd = 176442, XrefRangeStart = 176423, XrefRangeEnd = 176424, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(PlayerCamera.NativeMethodInfoPtr_get_activeUIElementCount_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
		}

		// Token: 0x17001837 RID: 6199
		// (get) Token: 0x060050AE RID: 20654 RVA: 0x00184530 File Offset: 0x00182730
		// (set) Token: 0x060050AF RID: 20655 RVA: 0x0018456C File Offset: 0x0018276C
		public unsafe bool transformOverriden
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(PlayerCamera.NativeMethodInfoPtr_get_transformOverriden_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
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
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCamera.NativeMethodInfoPtr_set_transformOverriden_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x17001838 RID: 6200
		// (get) Token: 0x060050B0 RID: 20656 RVA: 0x001845AC File Offset: 0x001827AC
		// (set) Token: 0x060050B1 RID: 20657 RVA: 0x001845E8 File Offset: 0x001827E8
		public unsafe bool fovOverriden
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(PlayerCamera.NativeMethodInfoPtr_get_fovOverriden_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
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
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCamera.NativeMethodInfoPtr_set_fovOverriden_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x17001839 RID: 6201
		// (get) Token: 0x060050B2 RID: 20658 RVA: 0x00184628 File Offset: 0x00182828
		// (set) Token: 0x060050B3 RID: 20659 RVA: 0x00184664 File Offset: 0x00182864
		public unsafe bool FreeCamEnabled
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(PlayerCamera.NativeMethodInfoPtr_get_FreeCamEnabled_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
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
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCamera.NativeMethodInfoPtr_set_FreeCamEnabled_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x1700183A RID: 6202
		// (get) Token: 0x060050B4 RID: 20660 RVA: 0x001846A4 File Offset: 0x001828A4
		// (set) Token: 0x060050B5 RID: 20661 RVA: 0x001846E0 File Offset: 0x001828E0
		public unsafe bool ViewingAvatar
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(PlayerCamera.NativeMethodInfoPtr_get_ViewingAvatar_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
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
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCamera.NativeMethodInfoPtr_set_ViewingAvatar_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x1700183B RID: 6203
		// (get) Token: 0x060050B6 RID: 20662 RVA: 0x00184720 File Offset: 0x00182920
		// (set) Token: 0x060050B7 RID: 20663 RVA: 0x0018475C File Offset: 0x0018295C
		public unsafe PlayerCamera.ECameraMode CameraMode
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(PlayerCamera.NativeMethodInfoPtr_get_CameraMode_Public_get_ECameraMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 52321, RefRangeEnd = 52327, XrefRangeStart = 52321, XrefRangeEnd = 52327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = ref value;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCamera.NativeMethodInfoPtr_set_CameraMode_Protected_set_Void_ECameraMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x1700183C RID: 6204
		// (get) Token: 0x060050B8 RID: 20664 RVA: 0x0018479C File Offset: 0x0018299C
		// (set) Token: 0x060050B9 RID: 20665 RVA: 0x001847D8 File Offset: 0x001829D8
		public unsafe bool MethVisuals
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(PlayerCamera.NativeMethodInfoPtr_get_MethVisuals_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
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
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCamera.NativeMethodInfoPtr_set_MethVisuals_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x1700183D RID: 6205
		// (get) Token: 0x060050BA RID: 20666 RVA: 0x00184818 File Offset: 0x00182A18
		// (set) Token: 0x060050BB RID: 20667 RVA: 0x00184854 File Offset: 0x00182A54
		public unsafe bool CocaineVisuals
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(PlayerCamera.NativeMethodInfoPtr_get_CocaineVisuals_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
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
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCamera.NativeMethodInfoPtr_set_CocaineVisuals_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x1700183E RID: 6206
		// (get) Token: 0x060050BC RID: 20668 RVA: 0x00184894 File Offset: 0x00182A94
		// (set) Token: 0x060050BD RID: 20669 RVA: 0x001848D0 File Offset: 0x00182AD0
		public unsafe float FovJitter
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(PlayerCamera.NativeMethodInfoPtr_get_FovJitter_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
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
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCamera.NativeMethodInfoPtr_set_FovJitter_Private_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x1700183F RID: 6207
		// (get) Token: 0x060050BE RID: 20670 RVA: 0x00184910 File Offset: 0x00182B10
		// (set) Token: 0x060050BF RID: 20671 RVA: 0x00184950 File Offset: 0x00182B50
		public unsafe List<string> activeUIElements
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCamera.NativeMethodInfoPtr_get_activeUIElements_Public_get_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCamera.NativeMethodInfoPtr_set_activeUIElements_Protected_set_Void_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x060050C0 RID: 20672 RVA: 0x00184994 File Offset: 0x00182B94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 176442, XrefRangeEnd = 176491, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PlayerCamera.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060050C1 RID: 20673 RVA: 0x001849D0 File Offset: 0x00182BD0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 176491, XrefRangeEnd = 176501, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnStartClient(bool IsOwner)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref IsOwner;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PlayerCamera.NativeMethodInfoPtr_OnStartClient_Public_Virtual_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060050C2 RID: 20674 RVA: 0x00184A1C File Offset: 0x00182C1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 176501, XrefRangeEnd = 176544, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PlayerCamera.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060050C3 RID: 20675 RVA: 0x00184A58 File Offset: 0x00182C58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 176544, XrefRangeEnd = 176563, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PlayerSpawned()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCamera.NativeMethodInfoPtr_PlayerSpawned_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060050C4 RID: 20676 RVA: 0x00184A8C File Offset: 0x00182C8C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 176577, RefRangeEnd = 176580, XrefRangeStart = 176563, XrefRangeEnd = 176577, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetAntialiasingMode(Il2CppScheduleOne.DevUtilities.GraphicsSettings.EAntiAliasingMode mode)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref mode;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCamera.NativeMethodInfoPtr_SetAntialiasingMode_Public_Static_Void_EAntiAliasingMode_0, 0, (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060050C5 RID: 20677 RVA: 0x00184AC0 File Offset: 0x00182CC0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 176587, RefRangeEnd = 176589, XrefRangeStart = 176580, XrefRangeEnd = 176587, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ApplyAASettings()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCamera.NativeMethodInfoPtr_ApplyAASettings_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060050C6 RID: 20678 RVA: 0x00184AF4 File Offset: 0x00182CF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 176589, XrefRangeEnd = 176666, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PlayerCamera.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060050C7 RID: 20679 RVA: 0x00184B30 File Offset: 0x00182D30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 176666, XrefRangeEnd = 176671, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Screenshot()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCamera.NativeMethodInfoPtr_Screenshot_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060050C8 RID: 20680 RVA: 0x00184B64 File Offset: 0x00182D64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 176671, XrefRangeEnd = 176720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void LateUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PlayerCamera.NativeMethodInfoPtr_LateUpdate_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060050C9 RID: 20681 RVA: 0x00184BA0 File Offset: 0x00182DA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 176720, XrefRangeEnd = 176724, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Exit(ExitAction action)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(action);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCamera.NativeMethodInfoPtr_Exit_Private_Void_ExitAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060050CA RID: 20682 RVA: 0x00184BE4 File Offset: 0x00182DE4
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 176732, RefRangeEnd = 176738, XrefRangeStart = 176724, XrefRangeEnd = 176732, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float GetTargetLocalY()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(PlayerCamera.NativeMethodInfoPtr_GetTargetLocalY_Public_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x060050CB RID: 20683 RVA: 0x00184C20 File Offset: 0x00182E20
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 52321, RefRangeEnd = 52327, XrefRangeStart = 52321, XrefRangeEnd = 52327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetCameraMode(PlayerCamera.ECameraMode mode)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref mode;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCamera.NativeMethodInfoPtr_SetCameraMode_Public_Void_ECameraMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060050CC RID: 20684 RVA: 0x00184C60 File Offset: 0x00182E60
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 176816, RefRangeEnd = 176817, XrefRangeStart = 176738, XrefRangeEnd = 176816, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RotateCamera()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCamera.NativeMethodInfoPtr_RotateCamera_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060050CD RID: 20685 RVA: 0x00184C94 File Offset: 0x00182E94
		[CallerCount(41)]
		[CachedScanResults(RefRangeStart = 176827, RefRangeEnd = 176868, XrefRangeStart = 176817, XrefRangeEnd = 176827, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LockMouse()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCamera.NativeMethodInfoPtr_LockMouse_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060050CE RID: 20686 RVA: 0x00184CC8 File Offset: 0x00182EC8
		[CallerCount(41)]
		[CachedScanResults(RefRangeStart = 176878, RefRangeEnd = 176919, XrefRangeStart = 176868, XrefRangeEnd = 176878, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FreeMouse()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCamera.NativeMethodInfoPtr_FreeMouse_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060050CF RID: 20687 RVA: 0x00184CFC File Offset: 0x00182EFC
		[CallerCount(30)]
		[CachedScanResults(RefRangeStart = 176928, RefRangeEnd = 176958, XrefRangeStart = 176919, XrefRangeEnd = 176928, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool LookRaycast(float range, out RaycastHit hit, LayerMask layerMask, bool includeTriggers = true, float radius = 0f)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)5) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref range;
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = &hit;
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref layerMask;
			ptr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref includeTriggers;
			ptr[checked(unchecked((System.UIntPtr)4) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref radius;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(PlayerCamera.NativeMethodInfoPtr_LookRaycast_Public_Boolean_Single_byref_RaycastHit_LayerMask_Boolean_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x060050D0 RID: 20688 RVA: 0x00184D80 File Offset: 0x00182F80
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 176992, RefRangeEnd = 176996, XrefRangeStart = 176958, XrefRangeEnd = 176992, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool LookRaycast_ExcludeBuildables(float range, out RaycastHit hit, LayerMask layerMask, bool includeTriggers = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)4) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref range;
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = &hit;
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref layerMask;
			ptr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref includeTriggers;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(PlayerCamera.NativeMethodInfoPtr_LookRaycast_ExcludeBuildables_Public_Boolean_Single_byref_RaycastHit_LayerMask_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x060050D1 RID: 20689 RVA: 0x00184DF4 File Offset: 0x00182FF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 176996, XrefRangeEnd = 177003, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDrawGizmosSelected()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCamera.NativeMethodInfoPtr_OnDrawGizmosSelected_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060050D2 RID: 20690 RVA: 0x00184E28 File Offset: 0x00183028
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 177043, RefRangeEnd = 177051, XrefRangeStart = 177003, XrefRangeEnd = 177043, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Raycast_ExcludeBuildables(Vector3 origin, Vector3 direction, float range, out RaycastHit hit, LayerMask layerMask, bool includeTriggers = false, float radius = 0f, float maxAngleDifference = 0f)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)8) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref origin;
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref direction;
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref range;
			ptr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = &hit;
			ptr[checked(unchecked((System.UIntPtr)4) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref layerMask;
			ptr[checked(unchecked((System.UIntPtr)5) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref includeTriggers;
			ptr[checked(unchecked((System.UIntPtr)6) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref radius;
			ptr[checked(unchecked((System.UIntPtr)7) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref maxAngleDifference;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(PlayerCamera.NativeMethodInfoPtr_Raycast_ExcludeBuildables_Public_Boolean_Vector3_Vector3_Single_byref_RaycastHit_LayerMask_Boolean_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x060050D3 RID: 20691 RVA: 0x00184ED4 File Offset: 0x001830D4
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 177062, RefRangeEnd = 177074, XrefRangeStart = 177051, XrefRangeEnd = 177062, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool MouseRaycast(float range, out RaycastHit hit, LayerMask layerMask, bool includeTriggers = true, float radius = 0f)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)5) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref range;
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = &hit;
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref layerMask;
			ptr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref includeTriggers;
			ptr[checked(unchecked((System.UIntPtr)4) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref radius;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(PlayerCamera.NativeMethodInfoPtr_MouseRaycast_Public_Boolean_Single_byref_RaycastHit_LayerMask_Boolean_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x060050D4 RID: 20692 RVA: 0x00184F58 File Offset: 0x00183158
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 177074, XrefRangeEnd = 177083, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool LookSpherecast(float range, float radius, out RaycastHit hit, LayerMask layerMask)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)4) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref range;
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref radius;
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = &hit;
			ptr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref layerMask;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(PlayerCamera.NativeMethodInfoPtr_LookSpherecast_Public_Boolean_Single_Single_byref_RaycastHit_LayerMask_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x060050D5 RID: 20693 RVA: 0x00184FCC File Offset: 0x001831CC
		[CallerCount(55)]
		[CachedScanResults(RefRangeStart = 177104, RefRangeEnd = 177159, XrefRangeStart = 177083, XrefRangeEnd = 177104, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OverrideTransform(Vector3 worldPos, Quaternion rot, float lerpTime, bool keepParented = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)4) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref worldPos;
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref rot;
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref lerpTime;
			ptr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref keepParented;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCamera.NativeMethodInfoPtr_OverrideTransform_Public_Void_Vector3_Quaternion_Single_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060050D6 RID: 20694 RVA: 0x00185034 File Offset: 0x00183234
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 177159, XrefRangeEnd = 177164, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator ILerpCamera(Vector3 endPos, Quaternion endRot, float lerpTime, bool worldSpace, bool returnToRestingPosition = false, bool reenableLook = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)6) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref endPos;
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref endRot;
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref lerpTime;
			ptr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref worldSpace;
			ptr[checked(unchecked((System.UIntPtr)4) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref returnToRestingPosition;
			ptr[checked(unchecked((System.UIntPtr)5) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref reenableLook;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCamera.NativeMethodInfoPtr_ILerpCamera_Protected_IEnumerator_Vector3_Quaternion_Single_Boolean_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr2) : null;
		}

		// Token: 0x060050D7 RID: 20695 RVA: 0x001850C8 File Offset: 0x001832C8
		[CallerCount(32)]
		[CachedScanResults(RefRangeStart = 177186, RefRangeEnd = 177218, XrefRangeStart = 177164, XrefRangeEnd = 177186, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StopTransformOverride(float lerpTime, bool reenableCameraLook = true, bool returnToOriginalRotation = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref lerpTime;
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref reenableCameraLook;
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref returnToOriginalRotation;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCamera.NativeMethodInfoPtr_StopTransformOverride_Public_Void_Single_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060050D8 RID: 20696 RVA: 0x00185124 File Offset: 0x00183324
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 177218, XrefRangeEnd = 177227, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LookAt(Vector3 point, float duration = 0.25f)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref point;
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref duration;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCamera.NativeMethodInfoPtr_LookAt_Public_Void_Vector3_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060050D9 RID: 20697 RVA: 0x00185170 File Offset: 0x00183370
		[CallerCount(0)]
		public unsafe void SetCanLook_True()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCamera.NativeMethodInfoPtr_SetCanLook_True_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060050DA RID: 20698 RVA: 0x001851A4 File Offset: 0x001833A4
		[CallerCount(53)]
		[CachedScanResults(RefRangeStart = 51677, RefRangeEnd = 51730, XrefRangeStart = 51677, XrefRangeEnd = 51730, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetCanLook(bool c)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref c;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCamera.NativeMethodInfoPtr_SetCanLook_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060050DB RID: 20699 RVA: 0x001851E4 File Offset: 0x001833E4
		[CallerCount(22)]
		[CachedScanResults(RefRangeStart = 177236, RefRangeEnd = 177258, XrefRangeStart = 177227, XrefRangeEnd = 177236, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetDoFActive(bool active, float lerpTime)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref active;
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref lerpTime;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCamera.NativeMethodInfoPtr_SetDoFActive_Public_Void_Boolean_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060050DC RID: 20700 RVA: 0x00185230 File Offset: 0x00183430
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 177258, XrefRangeEnd = 177263, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator LerpDoF(bool active, float lerpTime)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref active;
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref lerpTime;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCamera.NativeMethodInfoPtr_LerpDoF_Private_IEnumerator_Boolean_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr2) : null;
		}

		// Token: 0x060050DD RID: 20701 RVA: 0x0018528C File Offset: 0x0018348C
		[CallerCount(45)]
		[CachedScanResults(RefRangeStart = 177276, RefRangeEnd = 177321, XrefRangeStart = 177263, XrefRangeEnd = 177276, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OverrideFOV(float fov, float lerpTime)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref fov;
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref lerpTime;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCamera.NativeMethodInfoPtr_OverrideFOV_Public_Void_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060050DE RID: 20702 RVA: 0x001852D8 File Offset: 0x001834D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 177321, XrefRangeEnd = 177326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator ILerpFOV(float endFov, float lerpTime)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref endFov;
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref lerpTime;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCamera.NativeMethodInfoPtr_ILerpFOV_Protected_IEnumerator_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr2) : null;
		}

		// Token: 0x060050DF RID: 20703 RVA: 0x00185334 File Offset: 0x00183534
		[CallerCount(27)]
		[CachedScanResults(RefRangeStart = 177338, RefRangeEnd = 177365, XrefRangeStart = 177326, XrefRangeEnd = 177338, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StopFOVOverride(float lerpTime)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref lerpTime;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCamera.NativeMethodInfoPtr_StopFOVOverride_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060050E0 RID: 20704 RVA: 0x00185374 File Offset: 0x00183574
		[CallerCount(64)]
		[CachedScanResults(RefRangeStart = 177371, RefRangeEnd = 177435, XrefRangeStart = 177365, XrefRangeEnd = 177371, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddActiveUIElement(string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCamera.NativeMethodInfoPtr_AddActiveUIElement_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060050E1 RID: 20705 RVA: 0x001853B8 File Offset: 0x001835B8
		[CallerCount(67)]
		[CachedScanResults(RefRangeStart = 177441, RefRangeEnd = 177508, XrefRangeStart = 177435, XrefRangeEnd = 177441, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveActiveUIElement(string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCamera.NativeMethodInfoPtr_RemoveActiveUIElement_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060050E2 RID: 20706 RVA: 0x001853FC File Offset: 0x001835FC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 177526, RefRangeEnd = 177528, XrefRangeStart = 177508, XrefRangeEnd = 177526, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RegisterMovementEvent(int threshold, Il2CppSystem.Action action)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref threshold;
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(action);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCamera.NativeMethodInfoPtr_RegisterMovementEvent_Public_Void_Int32_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060050E3 RID: 20707 RVA: 0x0018544C File Offset: 0x0018364C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 177556, RefRangeEnd = 177557, XrefRangeStart = 177528, XrefRangeEnd = 177556, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DeregisterMovementEvent(Il2CppSystem.Action action)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(action);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCamera.NativeMethodInfoPtr_DeregisterMovementEvent_Public_Void_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060050E4 RID: 20708 RVA: 0x00185490 File Offset: 0x00183690
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 177590, RefRangeEnd = 177591, XrefRangeStart = 177557, XrefRangeEnd = 177590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateMovementEvents()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCamera.NativeMethodInfoPtr_UpdateMovementEvents_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060050E5 RID: 20709 RVA: 0x001854C4 File Offset: 0x001836C4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 177639, RefRangeEnd = 177640, XrefRangeStart = 177591, XrefRangeEnd = 177639, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ViewAvatar()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCamera.NativeMethodInfoPtr_ViewAvatar_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060050E6 RID: 20710 RVA: 0x001854F8 File Offset: 0x001836F8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 177660, RefRangeEnd = 177662, XrefRangeStart = 177640, XrefRangeEnd = 177660, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StopViewingAvatar()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCamera.NativeMethodInfoPtr_StopViewingAvatar_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060050E7 RID: 20711 RVA: 0x0018552C File Offset: 0x0018372C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 177665, RefRangeEnd = 177668, XrefRangeStart = 177662, XrefRangeEnd = 177665, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void JoltCamera()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCamera.NativeMethodInfoPtr_JoltCamera_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060050E8 RID: 20712 RVA: 0x00185560 File Offset: 0x00183760
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 177668, XrefRangeEnd = 177692, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool PointInCameraView(Vector3 point)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref point;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(PlayerCamera.NativeMethodInfoPtr_PointInCameraView_Public_Boolean_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x060050E9 RID: 20713 RVA: 0x001855AC File Offset: 0x001837AC
		[CallerCount(0)]
		public unsafe bool Is01(float a)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref a;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(PlayerCamera.NativeMethodInfoPtr_Is01_Public_Boolean_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x060050EA RID: 20714 RVA: 0x001855F8 File Offset: 0x001837F8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 177696, RefRangeEnd = 177699, XrefRangeStart = 177692, XrefRangeEnd = 177696, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ResetRotation()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCamera.NativeMethodInfoPtr_ResetRotation_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060050EB RID: 20715 RVA: 0x0018562C File Offset: 0x0018382C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 177710, RefRangeEnd = 177711, XrefRangeStart = 177699, XrefRangeEnd = 177710, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FocusCameraOnTarget(Transform target)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCamera.NativeMethodInfoPtr_FocusCameraOnTarget_Public_Void_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060050EC RID: 20716 RVA: 0x00185670 File Offset: 0x00183870
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 177712, RefRangeEnd = 177713, XrefRangeStart = 177711, XrefRangeEnd = 177712, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StopFocus()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCamera.NativeMethodInfoPtr_StopFocus_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060050ED RID: 20717 RVA: 0x001856A4 File Offset: 0x001838A4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 177727, RefRangeEnd = 177730, XrefRangeStart = 177713, XrefRangeEnd = 177727, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StartCameraShake(float intensity, float duration = -1f, bool decreaseOverTime = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref intensity;
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref duration;
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref decreaseOverTime;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCamera.NativeMethodInfoPtr_StartCameraShake_Public_Void_Single_Single_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060050EE RID: 20718 RVA: 0x00185700 File Offset: 0x00183900
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 177730, XrefRangeEnd = 177735, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StopCameraShake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCamera.NativeMethodInfoPtr_StopCameraShake_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060050EF RID: 20719 RVA: 0x00185734 File Offset: 0x00183934
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 177752, RefRangeEnd = 177753, XrefRangeStart = 177735, XrefRangeEnd = 177752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateCameraBob()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCamera.NativeMethodInfoPtr_UpdateCameraBob_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060050F0 RID: 20720 RVA: 0x00185768 File Offset: 0x00183968
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 177776, RefRangeEnd = 177779, XrefRangeStart = 177753, XrefRangeEnd = 177776, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetFreeCam(bool enable, bool reenableLook = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref enable;
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref reenableLook;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCamera.NativeMethodInfoPtr_SetFreeCam_Public_Void_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060050F1 RID: 20721 RVA: 0x001857B4 File Offset: 0x001839B4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 177828, RefRangeEnd = 177829, XrefRangeStart = 177779, XrefRangeEnd = 177828, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RotateFreeCam()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCamera.NativeMethodInfoPtr_RotateFreeCam_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060050F2 RID: 20722 RVA: 0x001857E8 File Offset: 0x001839E8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 177853, RefRangeEnd = 177854, XrefRangeStart = 177829, XrefRangeEnd = 177853, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateFreeCamInput()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCamera.NativeMethodInfoPtr_UpdateFreeCamInput_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060050F3 RID: 20723 RVA: 0x0018581C File Offset: 0x00183A1C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 177865, RefRangeEnd = 177866, XrefRangeStart = 177854, XrefRangeEnd = 177865, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MoveFreeCam()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCamera.NativeMethodInfoPtr_MoveFreeCam_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060050F4 RID: 20724 RVA: 0x00185850 File Offset: 0x00183A50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 177866, XrefRangeEnd = 177900, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PlayerCamera() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCamera.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060050F5 RID: 20725 RVA: 0x0018588C File Offset: 0x00183A8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 177900, XrefRangeEnd = 177914, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _PlayerSpawned_b__92_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCamera.NativeMethodInfoPtr__PlayerSpawned_b__92_0_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060050F6 RID: 20726 RVA: 0x001858C0 File Offset: 0x00183AC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 177914, XrefRangeEnd = 177918, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IEnumerator Method_Internal_Static_IEnumerator_PDM_0()
		{
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCamera.NativeMethodInfoPtr_Method_Internal_Static_IEnumerator_PDM_0, 0, (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr2) : null;
		}

		// Token: 0x060050F7 RID: 20727 RVA: 0x0002637E File Offset: 0x0002457E
		public PlayerCamera(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170017F8 RID: 6136
		// (get) Token: 0x060050F8 RID: 20728 RVA: 0x001858F4 File Offset: 0x00183AF4
		// (set) Token: 0x060050F9 RID: 20729 RVA: 0x00026387 File Offset: 0x00024587
		public unsafe static float CAMERA_SHAKE_MULTIPLIER
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(PlayerCamera.NativeFieldInfoPtr_CAMERA_SHAKE_MULTIPLIER, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PlayerCamera.NativeFieldInfoPtr_CAMERA_SHAKE_MULTIPLIER, (void*)(&value));
			}
		}

		// Token: 0x170017F9 RID: 6137
		// (get) Token: 0x060050FA RID: 20730 RVA: 0x00185910 File Offset: 0x00183B10
		// (set) Token: 0x060050FB RID: 20731 RVA: 0x00026395 File Offset: 0x00024595
		public unsafe static Il2CppScheduleOne.DevUtilities.GraphicsSettings.EAntiAliasingMode _AntiAliasingMode_k__BackingField
		{
			get
			{
				Il2CppScheduleOne.DevUtilities.GraphicsSettings.EAntiAliasingMode result;
				IL2CPP.il2cpp_field_static_get_value(PlayerCamera.NativeFieldInfoPtr__AntiAliasingMode_k__BackingField, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PlayerCamera.NativeFieldInfoPtr__AntiAliasingMode_k__BackingField, (void*)(&value));
			}
		}

		// Token: 0x170017FA RID: 6138
		// (get) Token: 0x060050FC RID: 20732 RVA: 0x0018592C File Offset: 0x00183B2C
		// (set) Token: 0x060050FD RID: 20733 RVA: 0x000263A3 File Offset: 0x000245A3
		public unsafe float cameraOffsetFromTop
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.NativeFieldInfoPtr_cameraOffsetFromTop);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.NativeFieldInfoPtr_cameraOffsetFromTop)) = value;
			}
		}

		// Token: 0x170017FB RID: 6139
		// (get) Token: 0x060050FE RID: 20734 RVA: 0x00185954 File Offset: 0x00183B54
		// (set) Token: 0x060050FF RID: 20735 RVA: 0x000263BE File Offset: 0x000245BE
		public unsafe float SprintFoVBoost
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.NativeFieldInfoPtr_SprintFoVBoost);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.NativeFieldInfoPtr_SprintFoVBoost)) = value;
			}
		}

		// Token: 0x170017FC RID: 6140
		// (get) Token: 0x06005100 RID: 20736 RVA: 0x0018597C File Offset: 0x00183B7C
		// (set) Token: 0x06005101 RID: 20737 RVA: 0x000263D9 File Offset: 0x000245D9
		public unsafe float FoVChangeRate
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.NativeFieldInfoPtr_FoVChangeRate);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.NativeFieldInfoPtr_FoVChangeRate)) = value;
			}
		}

		// Token: 0x170017FD RID: 6141
		// (get) Token: 0x06005102 RID: 20738 RVA: 0x001859A4 File Offset: 0x00183BA4
		// (set) Token: 0x06005103 RID: 20739 RVA: 0x000263F4 File Offset: 0x000245F4
		public unsafe float HorizontalCameraBob
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.NativeFieldInfoPtr_HorizontalCameraBob);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.NativeFieldInfoPtr_HorizontalCameraBob)) = value;
			}
		}

		// Token: 0x170017FE RID: 6142
		// (get) Token: 0x06005104 RID: 20740 RVA: 0x001859CC File Offset: 0x00183BCC
		// (set) Token: 0x06005105 RID: 20741 RVA: 0x0002640F File Offset: 0x0002460F
		public unsafe float VerticalCameraBob
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.NativeFieldInfoPtr_VerticalCameraBob);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.NativeFieldInfoPtr_VerticalCameraBob)) = value;
			}
		}

		// Token: 0x170017FF RID: 6143
		// (get) Token: 0x06005106 RID: 20742 RVA: 0x001859F4 File Offset: 0x00183BF4
		// (set) Token: 0x06005107 RID: 20743 RVA: 0x0002642A File Offset: 0x0002462A
		public unsafe float BobRate
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.NativeFieldInfoPtr_BobRate);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.NativeFieldInfoPtr_BobRate)) = value;
			}
		}

		// Token: 0x17001800 RID: 6144
		// (get) Token: 0x06005108 RID: 20744 RVA: 0x00185A1C File Offset: 0x00183C1C
		// (set) Token: 0x06005109 RID: 20745 RVA: 0x00026445 File Offset: 0x00024645
		public unsafe AnimationCurve HorizontalBobCurve
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.NativeFieldInfoPtr_HorizontalBobCurve);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnimationCurve>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.NativeFieldInfoPtr_HorizontalBobCurve), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001801 RID: 6145
		// (get) Token: 0x0600510A RID: 20746 RVA: 0x00185A4C File Offset: 0x00183C4C
		// (set) Token: 0x0600510B RID: 20747 RVA: 0x00026464 File Offset: 0x00024664
		public unsafe AnimationCurve VerticalBobCurve
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.NativeFieldInfoPtr_VerticalBobCurve);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnimationCurve>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.NativeFieldInfoPtr_VerticalBobCurve), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001802 RID: 6146
		// (get) Token: 0x0600510C RID: 20748 RVA: 0x00185A7C File Offset: 0x00183C7C
		// (set) Token: 0x0600510D RID: 20749 RVA: 0x00026483 File Offset: 0x00024683
		public unsafe float FreeCamSpeed
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.NativeFieldInfoPtr_FreeCamSpeed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.NativeFieldInfoPtr_FreeCamSpeed)) = value;
			}
		}

		// Token: 0x17001803 RID: 6147
		// (get) Token: 0x0600510E RID: 20750 RVA: 0x00185AA4 File Offset: 0x00183CA4
		// (set) Token: 0x0600510F RID: 20751 RVA: 0x0002649E File Offset: 0x0002469E
		public unsafe float FreeCamAcceleration
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.NativeFieldInfoPtr_FreeCamAcceleration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.NativeFieldInfoPtr_FreeCamAcceleration)) = value;
			}
		}

		// Token: 0x17001804 RID: 6148
		// (get) Token: 0x06005110 RID: 20752 RVA: 0x00185ACC File Offset: 0x00183CCC
		// (set) Token: 0x06005111 RID: 20753 RVA: 0x000264B9 File Offset: 0x000246B9
		public unsafe bool SmoothLook
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.NativeFieldInfoPtr_SmoothLook);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.NativeFieldInfoPtr_SmoothLook)) = value;
			}
		}

		// Token: 0x17001805 RID: 6149
		// (get) Token: 0x06005112 RID: 20754 RVA: 0x00185AF4 File Offset: 0x00183CF4
		// (set) Token: 0x06005113 RID: 20755 RVA: 0x000264D4 File Offset: 0x000246D4
		public unsafe float SmoothLookSpeed
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.NativeFieldInfoPtr_SmoothLookSpeed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.NativeFieldInfoPtr_SmoothLookSpeed)) = value;
			}
		}

		// Token: 0x17001806 RID: 6150
		// (get) Token: 0x06005114 RID: 20756 RVA: 0x00185B1C File Offset: 0x00183D1C
		// (set) Token: 0x06005115 RID: 20757 RVA: 0x000264EF File Offset: 0x000246EF
		public unsafe FloatSmoother FoVChangeSmoother
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.NativeFieldInfoPtr_FoVChangeSmoother);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FloatSmoother>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.NativeFieldInfoPtr_FoVChangeSmoother), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001807 RID: 6151
		// (get) Token: 0x06005116 RID: 20758 RVA: 0x00185B4C File Offset: 0x00183D4C
		// (set) Token: 0x06005117 RID: 20759 RVA: 0x0002650E File Offset: 0x0002470E
		public unsafe FloatSmoother SmoothLookSmoother
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.NativeFieldInfoPtr_SmoothLookSmoother);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FloatSmoother>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.NativeFieldInfoPtr_SmoothLookSmoother), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001808 RID: 6152
		// (get) Token: 0x06005118 RID: 20760 RVA: 0x00185B7C File Offset: 0x00183D7C
		// (set) Token: 0x06005119 RID: 20761 RVA: 0x0002652D File Offset: 0x0002472D
		public unsafe Transform CameraContainer
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.NativeFieldInfoPtr_CameraContainer);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.NativeFieldInfoPtr_CameraContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001809 RID: 6153
		// (get) Token: 0x0600511A RID: 20762 RVA: 0x00185BAC File Offset: 0x00183DAC
		// (set) Token: 0x0600511B RID: 20763 RVA: 0x0002654C File Offset: 0x0002474C
		public unsafe Camera Camera
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.NativeFieldInfoPtr_Camera);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Camera>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.NativeFieldInfoPtr_Camera), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700180A RID: 6154
		// (get) Token: 0x0600511C RID: 20764 RVA: 0x00185BDC File Offset: 0x00183DDC
		// (set) Token: 0x0600511D RID: 20765 RVA: 0x0002656B File Offset: 0x0002476B
		public unsafe Camera OverlayCamera
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.NativeFieldInfoPtr_OverlayCamera);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Camera>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.NativeFieldInfoPtr_OverlayCamera), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700180B RID: 6155
		// (get) Token: 0x0600511E RID: 20766 RVA: 0x00185C0C File Offset: 0x00183E0C
		// (set) Token: 0x0600511F RID: 20767 RVA: 0x0002658A File Offset: 0x0002478A
		public unsafe Animator Animator
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.NativeFieldInfoPtr_Animator);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Animator>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.NativeFieldInfoPtr_Animator), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700180C RID: 6156
		// (get) Token: 0x06005120 RID: 20768 RVA: 0x00185C3C File Offset: 0x00183E3C
		// (set) Token: 0x06005121 RID: 20769 RVA: 0x000265A9 File Offset: 0x000247A9
		public unsafe Il2CppReferenceArray<AnimationClip> JoltClips
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.NativeFieldInfoPtr_JoltClips);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<AnimationClip>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.NativeFieldInfoPtr_JoltClips), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700180D RID: 6157
		// (get) Token: 0x06005122 RID: 20770 RVA: 0x00185C6C File Offset: 0x00183E6C
		// (set) Token: 0x06005123 RID: 20771 RVA: 0x000265C8 File Offset: 0x000247C8
		public unsafe Il2CppReferenceArray<UniversalRenderPipelineAsset> URPAssets
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.NativeFieldInfoPtr_URPAssets);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<UniversalRenderPipelineAsset>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.NativeFieldInfoPtr_URPAssets), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700180E RID: 6158
		// (get) Token: 0x06005124 RID: 20772 RVA: 0x00185C9C File Offset: 0x00183E9C
		// (set) Token: 0x06005125 RID: 20773 RVA: 0x000265E7 File Offset: 0x000247E7
		public unsafe Transform ViewAvatarCameraPosition
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.NativeFieldInfoPtr_ViewAvatarCameraPosition);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.NativeFieldInfoPtr_ViewAvatarCameraPosition), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700180F RID: 6159
		// (get) Token: 0x06005126 RID: 20774 RVA: 0x00185CCC File Offset: 0x00183ECC
		// (set) Token: 0x06005127 RID: 20775 RVA: 0x00026606 File Offset: 0x00024806
		public unsafe HeartbeatSoundController HeartbeatSoundController
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.NativeFieldInfoPtr_HeartbeatSoundController);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<HeartbeatSoundController>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.NativeFieldInfoPtr_HeartbeatSoundController), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001810 RID: 6160
		// (get) Token: 0x06005128 RID: 20776 RVA: 0x00185CFC File Offset: 0x00183EFC
		// (set) Token: 0x06005129 RID: 20777 RVA: 0x00026625 File Offset: 0x00024825
		public unsafe ParticleSystem Flies
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.NativeFieldInfoPtr_Flies);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ParticleSystem>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.NativeFieldInfoPtr_Flies), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001811 RID: 6161
		// (get) Token: 0x0600512A RID: 20778 RVA: 0x00185D2C File Offset: 0x00183F2C
		// (set) Token: 0x0600512B RID: 20779 RVA: 0x00026644 File Offset: 0x00024844
		public unsafe AudioSourceController MethRumble
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.NativeFieldInfoPtr_MethRumble);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.NativeFieldInfoPtr_MethRumble), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001812 RID: 6162
		// (get) Token: 0x0600512C RID: 20780 RVA: 0x00185D5C File Offset: 0x00183F5C
		// (set) Token: 0x0600512D RID: 20781 RVA: 0x00026663 File Offset: 0x00024863
		public unsafe RandomizedAudioSourceController SchizoVoices
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.NativeFieldInfoPtr_SchizoVoices);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RandomizedAudioSourceController>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.NativeFieldInfoPtr_SchizoVoices), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001813 RID: 6163
		// (get) Token: 0x0600512E RID: 20782 RVA: 0x00185D8C File Offset: 0x00183F8C
		// (set) Token: 0x0600512F RID: 20783 RVA: 0x00026682 File Offset: 0x00024882
		public unsafe bool _canLook_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.NativeFieldInfoPtr__canLook_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.NativeFieldInfoPtr__canLook_k__BackingField)) = value;
			}
		}

		// Token: 0x17001814 RID: 6164
		// (get) Token: 0x06005130 RID: 20784 RVA: 0x00185DB4 File Offset: 0x00183FB4
		// (set) Token: 0x06005131 RID: 20785 RVA: 0x0002669D File Offset: 0x0002489D
		public unsafe bool _transformOverriden_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.NativeFieldInfoPtr__transformOverriden_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.NativeFieldInfoPtr__transformOverriden_k__BackingField)) = value;
			}
		}

		// Token: 0x17001815 RID: 6165
		// (get) Token: 0x06005132 RID: 20786 RVA: 0x00185DDC File Offset: 0x00183FDC
		// (set) Token: 0x06005133 RID: 20787 RVA: 0x000266B8 File Offset: 0x000248B8
		public unsafe bool _fovOverriden_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.NativeFieldInfoPtr__fovOverriden_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.NativeFieldInfoPtr__fovOverriden_k__BackingField)) = value;
			}
		}

		// Token: 0x17001816 RID: 6166
		// (get) Token: 0x06005134 RID: 20788 RVA: 0x00185E04 File Offset: 0x00184004
		// (set) Token: 0x06005135 RID: 20789 RVA: 0x000266D3 File Offset: 0x000248D3
		public unsafe bool blockNextStopTransformOverride
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.NativeFieldInfoPtr_blockNextStopTransformOverride);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.NativeFieldInfoPtr_blockNextStopTransformOverride)) = value;
			}
		}

		// Token: 0x17001817 RID: 6167
		// (get) Token: 0x06005136 RID: 20790 RVA: 0x00185E2C File Offset: 0x0018402C
		// (set) Token: 0x06005137 RID: 20791 RVA: 0x000266EE File Offset: 0x000248EE
		public unsafe bool _FreeCamEnabled_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.NativeFieldInfoPtr__FreeCamEnabled_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.NativeFieldInfoPtr__FreeCamEnabled_k__BackingField)) = value;
			}
		}

		// Token: 0x17001818 RID: 6168
		// (get) Token: 0x06005138 RID: 20792 RVA: 0x00185E54 File Offset: 0x00184054
		// (set) Token: 0x06005139 RID: 20793 RVA: 0x00026709 File Offset: 0x00024909
		public unsafe bool _ViewingAvatar_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.NativeFieldInfoPtr__ViewingAvatar_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.NativeFieldInfoPtr__ViewingAvatar_k__BackingField)) = value;
			}
		}

		// Token: 0x17001819 RID: 6169
		// (get) Token: 0x0600513A RID: 20794 RVA: 0x00185E7C File Offset: 0x0018407C
		// (set) Token: 0x0600513B RID: 20795 RVA: 0x00026724 File Offset: 0x00024924
		public unsafe PlayerCamera.ECameraMode _CameraMode_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.NativeFieldInfoPtr__CameraMode_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.NativeFieldInfoPtr__CameraMode_k__BackingField)) = value;
			}
		}

		// Token: 0x1700181A RID: 6170
		// (get) Token: 0x0600513C RID: 20796 RVA: 0x00185EA4 File Offset: 0x001840A4
		// (set) Token: 0x0600513D RID: 20797 RVA: 0x0002673F File Offset: 0x0002493F
		public unsafe bool _MethVisuals_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.NativeFieldInfoPtr__MethVisuals_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.NativeFieldInfoPtr__MethVisuals_k__BackingField)) = value;
			}
		}

		// Token: 0x1700181B RID: 6171
		// (get) Token: 0x0600513E RID: 20798 RVA: 0x00185ECC File Offset: 0x001840CC
		// (set) Token: 0x0600513F RID: 20799 RVA: 0x0002675A File Offset: 0x0002495A
		public unsafe bool _CocaineVisuals_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.NativeFieldInfoPtr__CocaineVisuals_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.NativeFieldInfoPtr__CocaineVisuals_k__BackingField)) = value;
			}
		}

		// Token: 0x1700181C RID: 6172
		// (get) Token: 0x06005140 RID: 20800 RVA: 0x00185EF4 File Offset: 0x001840F4
		// (set) Token: 0x06005141 RID: 20801 RVA: 0x00026775 File Offset: 0x00024975
		public unsafe float _FovJitter_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.NativeFieldInfoPtr__FovJitter_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.NativeFieldInfoPtr__FovJitter_k__BackingField)) = value;
			}
		}

		// Token: 0x1700181D RID: 6173
		// (get) Token: 0x06005142 RID: 20802 RVA: 0x00185F1C File Offset: 0x0018411C
		// (set) Token: 0x06005143 RID: 20803 RVA: 0x00026790 File Offset: 0x00024990
		public unsafe Volume globalVolume
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.NativeFieldInfoPtr_globalVolume);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Volume>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.NativeFieldInfoPtr_globalVolume), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700181E RID: 6174
		// (get) Token: 0x06005144 RID: 20804 RVA: 0x00185F4C File Offset: 0x0018414C
		// (set) Token: 0x06005145 RID: 20805 RVA: 0x000267AF File Offset: 0x000249AF
		public unsafe DepthOfField DoF
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.NativeFieldInfoPtr_DoF);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DepthOfField>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.NativeFieldInfoPtr_DoF), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700181F RID: 6175
		// (get) Token: 0x06005146 RID: 20806 RVA: 0x00185F7C File Offset: 0x0018417C
		// (set) Token: 0x06005147 RID: 20807 RVA: 0x000267CE File Offset: 0x000249CE
		public unsafe List<string> _activeUIElements_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.NativeFieldInfoPtr__activeUIElements_k__BackingField);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.NativeFieldInfoPtr__activeUIElements_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001820 RID: 6176
		// (get) Token: 0x06005148 RID: 20808 RVA: 0x00185FAC File Offset: 0x001841AC
		// (set) Token: 0x06005149 RID: 20809 RVA: 0x000267ED File Offset: 0x000249ED
		public unsafe Coroutine cameraShakeCoroutine
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.NativeFieldInfoPtr_cameraShakeCoroutine);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.NativeFieldInfoPtr_cameraShakeCoroutine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001821 RID: 6177
		// (get) Token: 0x0600514A RID: 20810 RVA: 0x00185FDC File Offset: 0x001841DC
		// (set) Token: 0x0600514B RID: 20811 RVA: 0x0002680C File Offset: 0x00024A0C
		public unsafe Vector3 cameraLocalPos
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.NativeFieldInfoPtr_cameraLocalPos);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.NativeFieldInfoPtr_cameraLocalPos)) = value;
			}
		}

		// Token: 0x17001822 RID: 6178
		// (get) Token: 0x0600514C RID: 20812 RVA: 0x00186004 File Offset: 0x00184204
		// (set) Token: 0x0600514D RID: 20813 RVA: 0x00026827 File Offset: 0x00024A27
		public unsafe Vector3 freeCamMovement
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.NativeFieldInfoPtr_freeCamMovement);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.NativeFieldInfoPtr_freeCamMovement)) = value;
			}
		}

		// Token: 0x17001823 RID: 6179
		// (get) Token: 0x0600514E RID: 20814 RVA: 0x0018602C File Offset: 0x0018422C
		// (set) Token: 0x0600514F RID: 20815 RVA: 0x00026842 File Offset: 0x00024A42
		public unsafe Coroutine focusRoutine
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.NativeFieldInfoPtr_focusRoutine);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.NativeFieldInfoPtr_focusRoutine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001824 RID: 6180
		// (get) Token: 0x06005150 RID: 20816 RVA: 0x0018605C File Offset: 0x0018425C
		// (set) Token: 0x06005151 RID: 20817 RVA: 0x00026861 File Offset: 0x00024A61
		public unsafe float focusMouseX
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.NativeFieldInfoPtr_focusMouseX);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.NativeFieldInfoPtr_focusMouseX)) = value;
			}
		}

		// Token: 0x17001825 RID: 6181
		// (get) Token: 0x06005152 RID: 20818 RVA: 0x00186084 File Offset: 0x00184284
		// (set) Token: 0x06005153 RID: 20819 RVA: 0x0002687C File Offset: 0x00024A7C
		public unsafe float focusMouseY
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.NativeFieldInfoPtr_focusMouseY);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.NativeFieldInfoPtr_focusMouseY)) = value;
			}
		}

		// Token: 0x17001826 RID: 6182
		// (get) Token: 0x06005154 RID: 20820 RVA: 0x001860AC File Offset: 0x001842AC
		// (set) Token: 0x06005155 RID: 20821 RVA: 0x00026897 File Offset: 0x00024A97
		public unsafe Dictionary<int, PlayerMovement.MovementEvent> movementEvents
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.NativeFieldInfoPtr_movementEvents);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<int, PlayerMovement.MovementEvent>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.NativeFieldInfoPtr_movementEvents), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001827 RID: 6183
		// (get) Token: 0x06005156 RID: 20822 RVA: 0x001860DC File Offset: 0x001842DC
		// (set) Token: 0x06005157 RID: 20823 RVA: 0x000268B6 File Offset: 0x00024AB6
		public unsafe float freeCamSpeed
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.NativeFieldInfoPtr_freeCamSpeed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.NativeFieldInfoPtr_freeCamSpeed)) = value;
			}
		}

		// Token: 0x17001828 RID: 6184
		// (get) Token: 0x06005158 RID: 20824 RVA: 0x00186104 File Offset: 0x00184304
		// (set) Token: 0x06005159 RID: 20825 RVA: 0x000268D1 File Offset: 0x00024AD1
		public unsafe float mouseX
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.NativeFieldInfoPtr_mouseX);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.NativeFieldInfoPtr_mouseX)) = value;
			}
		}

		// Token: 0x17001829 RID: 6185
		// (get) Token: 0x0600515A RID: 20826 RVA: 0x0018612C File Offset: 0x0018432C
		// (set) Token: 0x0600515B RID: 20827 RVA: 0x000268EC File Offset: 0x00024AEC
		public unsafe float mouseY
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.NativeFieldInfoPtr_mouseY);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.NativeFieldInfoPtr_mouseY)) = value;
			}
		}

		// Token: 0x1700182A RID: 6186
		// (get) Token: 0x0600515C RID: 20828 RVA: 0x00186154 File Offset: 0x00184354
		// (set) Token: 0x0600515D RID: 20829 RVA: 0x00026907 File Offset: 0x00024B07
		public unsafe Vector2 seizureJitter
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.NativeFieldInfoPtr_seizureJitter);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.NativeFieldInfoPtr_seizureJitter)) = value;
			}
		}

		// Token: 0x1700182B RID: 6187
		// (get) Token: 0x0600515E RID: 20830 RVA: 0x0018617C File Offset: 0x0018437C
		// (set) Token: 0x0600515F RID: 20831 RVA: 0x00026922 File Offset: 0x00024B22
		public unsafe float schizoFoV
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.NativeFieldInfoPtr_schizoFoV);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.NativeFieldInfoPtr_schizoFoV)) = value;
			}
		}

		// Token: 0x1700182C RID: 6188
		// (get) Token: 0x06005160 RID: 20832 RVA: 0x001861A4 File Offset: 0x001843A4
		// (set) Token: 0x06005161 RID: 20833 RVA: 0x0002693D File Offset: 0x00024B3D
		public unsafe float timeUntilNextSchizoVoice
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.NativeFieldInfoPtr_timeUntilNextSchizoVoice);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.NativeFieldInfoPtr_timeUntilNextSchizoVoice)) = value;
			}
		}

		// Token: 0x1700182D RID: 6189
		// (get) Token: 0x06005162 RID: 20834 RVA: 0x001861CC File Offset: 0x001843CC
		// (set) Token: 0x06005163 RID: 20835 RVA: 0x00026958 File Offset: 0x00024B58
		public unsafe List<Vector3> gizmos
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.NativeFieldInfoPtr_gizmos);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Vector3>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.NativeFieldInfoPtr_gizmos), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700182E RID: 6190
		// (get) Token: 0x06005164 RID: 20836 RVA: 0x001861FC File Offset: 0x001843FC
		// (set) Token: 0x06005165 RID: 20837 RVA: 0x00026977 File Offset: 0x00024B77
		public unsafe Vector3 cameralocalPos_PriorOverride
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.NativeFieldInfoPtr_cameralocalPos_PriorOverride);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.NativeFieldInfoPtr_cameralocalPos_PriorOverride)) = value;
			}
		}

		// Token: 0x1700182F RID: 6191
		// (get) Token: 0x06005166 RID: 20838 RVA: 0x00186224 File Offset: 0x00184424
		// (set) Token: 0x06005167 RID: 20839 RVA: 0x00026992 File Offset: 0x00024B92
		public unsafe Quaternion cameraLocalRot_PriorOverride
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.NativeFieldInfoPtr_cameraLocalRot_PriorOverride);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.NativeFieldInfoPtr_cameraLocalRot_PriorOverride)) = value;
			}
		}

		// Token: 0x17001830 RID: 6192
		// (get) Token: 0x06005168 RID: 20840 RVA: 0x0018624C File Offset: 0x0018444C
		// (set) Token: 0x06005169 RID: 20841 RVA: 0x000269AD File Offset: 0x00024BAD
		public unsafe Coroutine ILerpCamera_Coroutine
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.NativeFieldInfoPtr_ILerpCamera_Coroutine);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.NativeFieldInfoPtr_ILerpCamera_Coroutine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001831 RID: 6193
		// (get) Token: 0x0600516A RID: 20842 RVA: 0x0018627C File Offset: 0x0018447C
		// (set) Token: 0x0600516B RID: 20843 RVA: 0x000269CC File Offset: 0x00024BCC
		public unsafe Coroutine lookRoutine
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.NativeFieldInfoPtr_lookRoutine);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.NativeFieldInfoPtr_lookRoutine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001832 RID: 6194
		// (get) Token: 0x0600516C RID: 20844 RVA: 0x001862AC File Offset: 0x001844AC
		// (set) Token: 0x0600516D RID: 20845 RVA: 0x000269EB File Offset: 0x00024BEB
		public unsafe Coroutine DoFCoroutine
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.NativeFieldInfoPtr_DoFCoroutine);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.NativeFieldInfoPtr_DoFCoroutine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001833 RID: 6195
		// (get) Token: 0x0600516E RID: 20846 RVA: 0x001862DC File Offset: 0x001844DC
		// (set) Token: 0x0600516F RID: 20847 RVA: 0x00026A0A File Offset: 0x00024C0A
		public unsafe Coroutine ILerpCameraFOV_Coroutine
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.NativeFieldInfoPtr_ILerpCameraFOV_Coroutine);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.NativeFieldInfoPtr_ILerpCameraFOV_Coroutine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040036A3 RID: 13987
		private static readonly System.IntPtr NativeFieldInfoPtr_CAMERA_SHAKE_MULTIPLIER;

		// Token: 0x040036A4 RID: 13988
		private static readonly System.IntPtr NativeFieldInfoPtr__AntiAliasingMode_k__BackingField;

		// Token: 0x040036A5 RID: 13989
		private static readonly System.IntPtr NativeFieldInfoPtr_cameraOffsetFromTop;

		// Token: 0x040036A6 RID: 13990
		private static readonly System.IntPtr NativeFieldInfoPtr_SprintFoVBoost;

		// Token: 0x040036A7 RID: 13991
		private static readonly System.IntPtr NativeFieldInfoPtr_FoVChangeRate;

		// Token: 0x040036A8 RID: 13992
		private static readonly System.IntPtr NativeFieldInfoPtr_HorizontalCameraBob;

		// Token: 0x040036A9 RID: 13993
		private static readonly System.IntPtr NativeFieldInfoPtr_VerticalCameraBob;

		// Token: 0x040036AA RID: 13994
		private static readonly System.IntPtr NativeFieldInfoPtr_BobRate;

		// Token: 0x040036AB RID: 13995
		private static readonly System.IntPtr NativeFieldInfoPtr_HorizontalBobCurve;

		// Token: 0x040036AC RID: 13996
		private static readonly System.IntPtr NativeFieldInfoPtr_VerticalBobCurve;

		// Token: 0x040036AD RID: 13997
		private static readonly System.IntPtr NativeFieldInfoPtr_FreeCamSpeed;

		// Token: 0x040036AE RID: 13998
		private static readonly System.IntPtr NativeFieldInfoPtr_FreeCamAcceleration;

		// Token: 0x040036AF RID: 13999
		private static readonly System.IntPtr NativeFieldInfoPtr_SmoothLook;

		// Token: 0x040036B0 RID: 14000
		private static readonly System.IntPtr NativeFieldInfoPtr_SmoothLookSpeed;

		// Token: 0x040036B1 RID: 14001
		private static readonly System.IntPtr NativeFieldInfoPtr_FoVChangeSmoother;

		// Token: 0x040036B2 RID: 14002
		private static readonly System.IntPtr NativeFieldInfoPtr_SmoothLookSmoother;

		// Token: 0x040036B3 RID: 14003
		private static readonly System.IntPtr NativeFieldInfoPtr_CameraContainer;

		// Token: 0x040036B4 RID: 14004
		private static readonly System.IntPtr NativeFieldInfoPtr_Camera;

		// Token: 0x040036B5 RID: 14005
		private static readonly System.IntPtr NativeFieldInfoPtr_OverlayCamera;

		// Token: 0x040036B6 RID: 14006
		private static readonly System.IntPtr NativeFieldInfoPtr_Animator;

		// Token: 0x040036B7 RID: 14007
		private static readonly System.IntPtr NativeFieldInfoPtr_JoltClips;

		// Token: 0x040036B8 RID: 14008
		private static readonly System.IntPtr NativeFieldInfoPtr_URPAssets;

		// Token: 0x040036B9 RID: 14009
		private static readonly System.IntPtr NativeFieldInfoPtr_ViewAvatarCameraPosition;

		// Token: 0x040036BA RID: 14010
		private static readonly System.IntPtr NativeFieldInfoPtr_HeartbeatSoundController;

		// Token: 0x040036BB RID: 14011
		private static readonly System.IntPtr NativeFieldInfoPtr_Flies;

		// Token: 0x040036BC RID: 14012
		private static readonly System.IntPtr NativeFieldInfoPtr_MethRumble;

		// Token: 0x040036BD RID: 14013
		private static readonly System.IntPtr NativeFieldInfoPtr_SchizoVoices;

		// Token: 0x040036BE RID: 14014
		private static readonly System.IntPtr NativeFieldInfoPtr__canLook_k__BackingField;

		// Token: 0x040036BF RID: 14015
		private static readonly System.IntPtr NativeFieldInfoPtr__transformOverriden_k__BackingField;

		// Token: 0x040036C0 RID: 14016
		private static readonly System.IntPtr NativeFieldInfoPtr__fovOverriden_k__BackingField;

		// Token: 0x040036C1 RID: 14017
		private static readonly System.IntPtr NativeFieldInfoPtr_blockNextStopTransformOverride;

		// Token: 0x040036C2 RID: 14018
		private static readonly System.IntPtr NativeFieldInfoPtr__FreeCamEnabled_k__BackingField;

		// Token: 0x040036C3 RID: 14019
		private static readonly System.IntPtr NativeFieldInfoPtr__ViewingAvatar_k__BackingField;

		// Token: 0x040036C4 RID: 14020
		private static readonly System.IntPtr NativeFieldInfoPtr__CameraMode_k__BackingField;

		// Token: 0x040036C5 RID: 14021
		private static readonly System.IntPtr NativeFieldInfoPtr__MethVisuals_k__BackingField;

		// Token: 0x040036C6 RID: 14022
		private static readonly System.IntPtr NativeFieldInfoPtr__CocaineVisuals_k__BackingField;

		// Token: 0x040036C7 RID: 14023
		private static readonly System.IntPtr NativeFieldInfoPtr__FovJitter_k__BackingField;

		// Token: 0x040036C8 RID: 14024
		private static readonly System.IntPtr NativeFieldInfoPtr_globalVolume;

		// Token: 0x040036C9 RID: 14025
		private static readonly System.IntPtr NativeFieldInfoPtr_DoF;

		// Token: 0x040036CA RID: 14026
		private static readonly System.IntPtr NativeFieldInfoPtr__activeUIElements_k__BackingField;

		// Token: 0x040036CB RID: 14027
		private static readonly System.IntPtr NativeFieldInfoPtr_cameraShakeCoroutine;

		// Token: 0x040036CC RID: 14028
		private static readonly System.IntPtr NativeFieldInfoPtr_cameraLocalPos;

		// Token: 0x040036CD RID: 14029
		private static readonly System.IntPtr NativeFieldInfoPtr_freeCamMovement;

		// Token: 0x040036CE RID: 14030
		private static readonly System.IntPtr NativeFieldInfoPtr_focusRoutine;

		// Token: 0x040036CF RID: 14031
		private static readonly System.IntPtr NativeFieldInfoPtr_focusMouseX;

		// Token: 0x040036D0 RID: 14032
		private static readonly System.IntPtr NativeFieldInfoPtr_focusMouseY;

		// Token: 0x040036D1 RID: 14033
		private static readonly System.IntPtr NativeFieldInfoPtr_movementEvents;

		// Token: 0x040036D2 RID: 14034
		private static readonly System.IntPtr NativeFieldInfoPtr_freeCamSpeed;

		// Token: 0x040036D3 RID: 14035
		private static readonly System.IntPtr NativeFieldInfoPtr_mouseX;

		// Token: 0x040036D4 RID: 14036
		private static readonly System.IntPtr NativeFieldInfoPtr_mouseY;

		// Token: 0x040036D5 RID: 14037
		private static readonly System.IntPtr NativeFieldInfoPtr_seizureJitter;

		// Token: 0x040036D6 RID: 14038
		private static readonly System.IntPtr NativeFieldInfoPtr_schizoFoV;

		// Token: 0x040036D7 RID: 14039
		private static readonly System.IntPtr NativeFieldInfoPtr_timeUntilNextSchizoVoice;

		// Token: 0x040036D8 RID: 14040
		private static readonly System.IntPtr NativeFieldInfoPtr_gizmos;

		// Token: 0x040036D9 RID: 14041
		private static readonly System.IntPtr NativeFieldInfoPtr_cameralocalPos_PriorOverride;

		// Token: 0x040036DA RID: 14042
		private static readonly System.IntPtr NativeFieldInfoPtr_cameraLocalRot_PriorOverride;

		// Token: 0x040036DB RID: 14043
		private static readonly System.IntPtr NativeFieldInfoPtr_ILerpCamera_Coroutine;

		// Token: 0x040036DC RID: 14044
		private static readonly System.IntPtr NativeFieldInfoPtr_lookRoutine;

		// Token: 0x040036DD RID: 14045
		private static readonly System.IntPtr NativeFieldInfoPtr_DoFCoroutine;

		// Token: 0x040036DE RID: 14046
		private static readonly System.IntPtr NativeFieldInfoPtr_ILerpCameraFOV_Coroutine;

		// Token: 0x040036DF RID: 14047
		private static readonly System.IntPtr NativeMethodInfoPtr_get_AntiAliasingMode_Public_Static_get_EAntiAliasingMode_0;

		// Token: 0x040036E0 RID: 14048
		private static readonly System.IntPtr NativeMethodInfoPtr_set_AntiAliasingMode_Private_Static_set_Void_EAntiAliasingMode_0;

		// Token: 0x040036E1 RID: 14049
		private static readonly System.IntPtr NativeMethodInfoPtr_get_canLook_Public_get_Boolean_0;

		// Token: 0x040036E2 RID: 14050
		private static readonly System.IntPtr NativeMethodInfoPtr_set_canLook_Protected_set_Void_Boolean_0;

		// Token: 0x040036E3 RID: 14051
		private static readonly System.IntPtr NativeMethodInfoPtr_get_activeUIElementCount_Public_get_Int32_0;

		// Token: 0x040036E4 RID: 14052
		private static readonly System.IntPtr NativeMethodInfoPtr_get_transformOverriden_Public_get_Boolean_0;

		// Token: 0x040036E5 RID: 14053
		private static readonly System.IntPtr NativeMethodInfoPtr_set_transformOverriden_Protected_set_Void_Boolean_0;

		// Token: 0x040036E6 RID: 14054
		private static readonly System.IntPtr NativeMethodInfoPtr_get_fovOverriden_Public_get_Boolean_0;

		// Token: 0x040036E7 RID: 14055
		private static readonly System.IntPtr NativeMethodInfoPtr_set_fovOverriden_Protected_set_Void_Boolean_0;

		// Token: 0x040036E8 RID: 14056
		private static readonly System.IntPtr NativeMethodInfoPtr_get_FreeCamEnabled_Public_get_Boolean_0;

		// Token: 0x040036E9 RID: 14057
		private static readonly System.IntPtr NativeMethodInfoPtr_set_FreeCamEnabled_Private_set_Void_Boolean_0;

		// Token: 0x040036EA RID: 14058
		private static readonly System.IntPtr NativeMethodInfoPtr_get_ViewingAvatar_Public_get_Boolean_0;

		// Token: 0x040036EB RID: 14059
		private static readonly System.IntPtr NativeMethodInfoPtr_set_ViewingAvatar_Private_set_Void_Boolean_0;

		// Token: 0x040036EC RID: 14060
		private static readonly System.IntPtr NativeMethodInfoPtr_get_CameraMode_Public_get_ECameraMode_0;

		// Token: 0x040036ED RID: 14061
		private static readonly System.IntPtr NativeMethodInfoPtr_set_CameraMode_Protected_set_Void_ECameraMode_0;

		// Token: 0x040036EE RID: 14062
		private static readonly System.IntPtr NativeMethodInfoPtr_get_MethVisuals_Public_get_Boolean_0;

		// Token: 0x040036EF RID: 14063
		private static readonly System.IntPtr NativeMethodInfoPtr_set_MethVisuals_Public_set_Void_Boolean_0;

		// Token: 0x040036F0 RID: 14064
		private static readonly System.IntPtr NativeMethodInfoPtr_get_CocaineVisuals_Public_get_Boolean_0;

		// Token: 0x040036F1 RID: 14065
		private static readonly System.IntPtr NativeMethodInfoPtr_set_CocaineVisuals_Public_set_Void_Boolean_0;

		// Token: 0x040036F2 RID: 14066
		private static readonly System.IntPtr NativeMethodInfoPtr_get_FovJitter_Public_get_Single_0;

		// Token: 0x040036F3 RID: 14067
		private static readonly System.IntPtr NativeMethodInfoPtr_set_FovJitter_Private_set_Void_Single_0;

		// Token: 0x040036F4 RID: 14068
		private static readonly System.IntPtr NativeMethodInfoPtr_get_activeUIElements_Public_get_List_1_String_0;

		// Token: 0x040036F5 RID: 14069
		private static readonly System.IntPtr NativeMethodInfoPtr_set_activeUIElements_Protected_set_Void_List_1_String_0;

		// Token: 0x040036F6 RID: 14070
		private static readonly System.IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0;

		// Token: 0x040036F7 RID: 14071
		private static readonly System.IntPtr NativeMethodInfoPtr_OnStartClient_Public_Virtual_Void_Boolean_0;

		// Token: 0x040036F8 RID: 14072
		private static readonly System.IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x040036F9 RID: 14073
		private static readonly System.IntPtr NativeMethodInfoPtr_PlayerSpawned_Private_Void_0;

		// Token: 0x040036FA RID: 14074
		private static readonly System.IntPtr NativeMethodInfoPtr_SetAntialiasingMode_Public_Static_Void_EAntiAliasingMode_0;

		// Token: 0x040036FB RID: 14075
		private static readonly System.IntPtr NativeMethodInfoPtr_ApplyAASettings_Public_Void_0;

		// Token: 0x040036FC RID: 14076
		private static readonly System.IntPtr NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0;

		// Token: 0x040036FD RID: 14077
		private static readonly System.IntPtr NativeMethodInfoPtr_Screenshot_Private_Void_0;

		// Token: 0x040036FE RID: 14078
		private static readonly System.IntPtr NativeMethodInfoPtr_LateUpdate_Protected_Virtual_New_Void_0;

		// Token: 0x040036FF RID: 14079
		private static readonly System.IntPtr NativeMethodInfoPtr_Exit_Private_Void_ExitAction_0;

		// Token: 0x04003700 RID: 14080
		private static readonly System.IntPtr NativeMethodInfoPtr_GetTargetLocalY_Public_Single_0;

		// Token: 0x04003701 RID: 14081
		private static readonly System.IntPtr NativeMethodInfoPtr_SetCameraMode_Public_Void_ECameraMode_0;

		// Token: 0x04003702 RID: 14082
		private static readonly System.IntPtr NativeMethodInfoPtr_RotateCamera_Private_Void_0;

		// Token: 0x04003703 RID: 14083
		private static readonly System.IntPtr NativeMethodInfoPtr_LockMouse_Public_Void_0;

		// Token: 0x04003704 RID: 14084
		private static readonly System.IntPtr NativeMethodInfoPtr_FreeMouse_Public_Void_0;

		// Token: 0x04003705 RID: 14085
		private static readonly System.IntPtr NativeMethodInfoPtr_LookRaycast_Public_Boolean_Single_byref_RaycastHit_LayerMask_Boolean_Single_0;

		// Token: 0x04003706 RID: 14086
		private static readonly System.IntPtr NativeMethodInfoPtr_LookRaycast_ExcludeBuildables_Public_Boolean_Single_byref_RaycastHit_LayerMask_Boolean_0;

		// Token: 0x04003707 RID: 14087
		private static readonly System.IntPtr NativeMethodInfoPtr_OnDrawGizmosSelected_Private_Void_0;

		// Token: 0x04003708 RID: 14088
		private static readonly System.IntPtr NativeMethodInfoPtr_Raycast_ExcludeBuildables_Public_Boolean_Vector3_Vector3_Single_byref_RaycastHit_LayerMask_Boolean_Single_Single_0;

		// Token: 0x04003709 RID: 14089
		private static readonly System.IntPtr NativeMethodInfoPtr_MouseRaycast_Public_Boolean_Single_byref_RaycastHit_LayerMask_Boolean_Single_0;

		// Token: 0x0400370A RID: 14090
		private static readonly System.IntPtr NativeMethodInfoPtr_LookSpherecast_Public_Boolean_Single_Single_byref_RaycastHit_LayerMask_0;

		// Token: 0x0400370B RID: 14091
		private static readonly System.IntPtr NativeMethodInfoPtr_OverrideTransform_Public_Void_Vector3_Quaternion_Single_Boolean_0;

		// Token: 0x0400370C RID: 14092
		private static readonly System.IntPtr NativeMethodInfoPtr_ILerpCamera_Protected_IEnumerator_Vector3_Quaternion_Single_Boolean_Boolean_Boolean_0;

		// Token: 0x0400370D RID: 14093
		private static readonly System.IntPtr NativeMethodInfoPtr_StopTransformOverride_Public_Void_Single_Boolean_Boolean_0;

		// Token: 0x0400370E RID: 14094
		private static readonly System.IntPtr NativeMethodInfoPtr_LookAt_Public_Void_Vector3_Single_0;

		// Token: 0x0400370F RID: 14095
		private static readonly System.IntPtr NativeMethodInfoPtr_SetCanLook_True_Private_Void_0;

		// Token: 0x04003710 RID: 14096
		private static readonly System.IntPtr NativeMethodInfoPtr_SetCanLook_Public_Void_Boolean_0;

		// Token: 0x04003711 RID: 14097
		private static readonly System.IntPtr NativeMethodInfoPtr_SetDoFActive_Public_Void_Boolean_Single_0;

		// Token: 0x04003712 RID: 14098
		private static readonly System.IntPtr NativeMethodInfoPtr_LerpDoF_Private_IEnumerator_Boolean_Single_0;

		// Token: 0x04003713 RID: 14099
		private static readonly System.IntPtr NativeMethodInfoPtr_OverrideFOV_Public_Void_Single_Single_0;

		// Token: 0x04003714 RID: 14100
		private static readonly System.IntPtr NativeMethodInfoPtr_ILerpFOV_Protected_IEnumerator_Single_Single_0;

		// Token: 0x04003715 RID: 14101
		private static readonly System.IntPtr NativeMethodInfoPtr_StopFOVOverride_Public_Void_Single_0;

		// Token: 0x04003716 RID: 14102
		private static readonly System.IntPtr NativeMethodInfoPtr_AddActiveUIElement_Public_Void_String_0;

		// Token: 0x04003717 RID: 14103
		private static readonly System.IntPtr NativeMethodInfoPtr_RemoveActiveUIElement_Public_Void_String_0;

		// Token: 0x04003718 RID: 14104
		private static readonly System.IntPtr NativeMethodInfoPtr_RegisterMovementEvent_Public_Void_Int32_Action_0;

		// Token: 0x04003719 RID: 14105
		private static readonly System.IntPtr NativeMethodInfoPtr_DeregisterMovementEvent_Public_Void_Action_0;

		// Token: 0x0400371A RID: 14106
		private static readonly System.IntPtr NativeMethodInfoPtr_UpdateMovementEvents_Private_Void_0;

		// Token: 0x0400371B RID: 14107
		private static readonly System.IntPtr NativeMethodInfoPtr_ViewAvatar_Private_Void_0;

		// Token: 0x0400371C RID: 14108
		private static readonly System.IntPtr NativeMethodInfoPtr_StopViewingAvatar_Private_Void_0;

		// Token: 0x0400371D RID: 14109
		private static readonly System.IntPtr NativeMethodInfoPtr_JoltCamera_Public_Void_0;

		// Token: 0x0400371E RID: 14110
		private static readonly System.IntPtr NativeMethodInfoPtr_PointInCameraView_Public_Boolean_Vector3_0;

		// Token: 0x0400371F RID: 14111
		private static readonly System.IntPtr NativeMethodInfoPtr_Is01_Public_Boolean_Single_0;

		// Token: 0x04003720 RID: 14112
		private static readonly System.IntPtr NativeMethodInfoPtr_ResetRotation_Public_Void_0;

		// Token: 0x04003721 RID: 14113
		private static readonly System.IntPtr NativeMethodInfoPtr_FocusCameraOnTarget_Public_Void_Transform_0;

		// Token: 0x04003722 RID: 14114
		private static readonly System.IntPtr NativeMethodInfoPtr_StopFocus_Public_Void_0;

		// Token: 0x04003723 RID: 14115
		private static readonly System.IntPtr NativeMethodInfoPtr_StartCameraShake_Public_Void_Single_Single_Boolean_0;

		// Token: 0x04003724 RID: 14116
		private static readonly System.IntPtr NativeMethodInfoPtr_StopCameraShake_Public_Void_0;

		// Token: 0x04003725 RID: 14117
		private static readonly System.IntPtr NativeMethodInfoPtr_UpdateCameraBob_Public_Void_0;

		// Token: 0x04003726 RID: 14118
		private static readonly System.IntPtr NativeMethodInfoPtr_SetFreeCam_Public_Void_Boolean_Boolean_0;

		// Token: 0x04003727 RID: 14119
		private static readonly System.IntPtr NativeMethodInfoPtr_RotateFreeCam_Private_Void_0;

		// Token: 0x04003728 RID: 14120
		private static readonly System.IntPtr NativeMethodInfoPtr_UpdateFreeCamInput_Private_Void_0;

		// Token: 0x04003729 RID: 14121
		private static readonly System.IntPtr NativeMethodInfoPtr_MoveFreeCam_Private_Void_0;

		// Token: 0x0400372A RID: 14122
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400372B RID: 14123
		private static readonly System.IntPtr NativeMethodInfoPtr__PlayerSpawned_b__92_0_Private_Void_0;

		// Token: 0x0400372C RID: 14124
		private static readonly System.IntPtr NativeMethodInfoPtr_Method_Internal_Static_IEnumerator_PDM_0;

		// Token: 0x020009E1 RID: 2529
		[OriginalName("Assembly-CSharp.dll", "", "ECameraMode")]
		public enum ECameraMode
		{
			// Token: 0x04008C8D RID: 35981
			Default,
			// Token: 0x04008C8E RID: 35982
			Vehicle,
			// Token: 0x04008C8F RID: 35983
			Skateboard
		}

		// Token: 0x020009E2 RID: 2530
		[ObfuscatedName("ScheduleOne.PlayerScripts.PlayerCamera+<<Screenshot>g__Routine|96_0>d")]
		public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique : Il2CppSystem.Object
		{
			// Token: 0x0600CFC0 RID: 53184 RVA: 0x00325774 File Offset: 0x00323974
			// Note: this type is marked as 'beforefieldinit'.
			static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique()
			{
				Il2CppClassPointerStore<PlayerCamera.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, "<<Screenshot>g__Routine|96_0>d");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayerCamera.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr);
				PlayerCamera.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCamera.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>1__state");
				PlayerCamera.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCamera.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>2__current");
				PlayerCamera.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100673535);
				PlayerCamera.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100673536);
				PlayerCamera.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100673537);
				PlayerCamera.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100673538);
				PlayerCamera.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100673539);
				PlayerCamera.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100673540);
			}

			// Token: 0x0600CFC1 RID: 53185 RVA: 0x00325840 File Offset: 0x00323A40
			[CallerCount(54)]
			[CachedScanResults(RefRangeStart = 2646, RefRangeEnd = 2700, XrefRangeStart = 2646, XrefRangeEnd = 2700, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayerCamera.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr))
			{
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = ref <>1__state;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCamera.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600CFC2 RID: 53186 RVA: 0x00325888 File Offset: 0x00323A88
			[CallerCount(14558)]
			[CachedScanResults(RefRangeStart = 2769, RefRangeEnd = 17327, XrefRangeStart = 2769, XrefRangeEnd = 17327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCamera.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600CFC3 RID: 53187 RVA: 0x003258BC File Offset: 0x00323ABC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 176193, XrefRangeEnd = 176201, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(PlayerCamera.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x17004063 RID: 16483
			// (get) Token: 0x0600CFC4 RID: 53188 RVA: 0x003258F8 File Offset: 0x00323AF8
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 2740, RefRangeEnd = 2764, XrefRangeStart = 2740, XrefRangeEnd = 2764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCamera.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
			}

			// Token: 0x0600CFC5 RID: 53189 RVA: 0x00325938 File Offset: 0x00323B38
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 176201, XrefRangeEnd = 176206, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCamera.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x17004064 RID: 16484
			// (get) Token: 0x0600CFC6 RID: 53190 RVA: 0x0032596C File Offset: 0x00323B6C
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 2740, RefRangeEnd = 2764, XrefRangeStart = 2740, XrefRangeEnd = 2764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCamera.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
			}

			// Token: 0x0600CFC7 RID: 53191 RVA: 0x00064AC9 File Offset: 0x00062CC9
			public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004061 RID: 16481
			// (get) Token: 0x0600CFC8 RID: 53192 RVA: 0x003259AC File Offset: 0x00323BAC
			// (set) Token: 0x0600CFC9 RID: 53193 RVA: 0x00064AD2 File Offset: 0x00062CD2
			public unsafe int __1__state
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17004062 RID: 16482
			// (get) Token: 0x0600CFCA RID: 53194 RVA: 0x003259D4 File Offset: 0x00323BD4
			// (set) Token: 0x0600CFCB RID: 53195 RVA: 0x00064AED File Offset: 0x00062CED
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008C90 RID: 35984
			private static readonly System.IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04008C91 RID: 35985
			private static readonly System.IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04008C92 RID: 35986
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04008C93 RID: 35987
			private static readonly System.IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008C94 RID: 35988
			private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04008C95 RID: 35989
			private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04008C96 RID: 35990
			private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008C97 RID: 35991
			private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x020009E3 RID: 2531
		[ObfuscatedName("ScheduleOne.PlayerScripts.PlayerCamera+<>c__DisplayClass118_0")]
		public sealed class __c__DisplayClass118_0 : Il2CppSystem.Object
		{
			// Token: 0x0600CFCC RID: 53196 RVA: 0x00325A04 File Offset: 0x00323C04
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass118_0()
			{
				Il2CppClassPointerStore<PlayerCamera.__c__DisplayClass118_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, "<>c__DisplayClass118_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayerCamera.__c__DisplayClass118_0>.NativeClassPtr);
				PlayerCamera.__c__DisplayClass118_0.NativeFieldInfoPtr_point = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCamera.__c__DisplayClass118_0>.NativeClassPtr, "point");
				PlayerCamera.__c__DisplayClass118_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCamera.__c__DisplayClass118_0>.NativeClassPtr, "<>4__this");
				PlayerCamera.__c__DisplayClass118_0.NativeFieldInfoPtr_duration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCamera.__c__DisplayClass118_0>.NativeClassPtr, "duration");
				PlayerCamera.__c__DisplayClass118_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera.__c__DisplayClass118_0>.NativeClassPtr, 100673541);
				PlayerCamera.__c__DisplayClass118_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera.__c__DisplayClass118_0>.NativeClassPtr, 100673542);
			}

			// Token: 0x0600CFCD RID: 53197 RVA: 0x00325A94 File Offset: 0x00323C94
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass118_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayerCamera.__c__DisplayClass118_0>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCamera.__c__DisplayClass118_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600CFCE RID: 53198 RVA: 0x00325AD0 File Offset: 0x00323CD0
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 176261, RefRangeEnd = 176262, XrefRangeStart = 176256, XrefRangeEnd = 176261, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator Method_Internal_IEnumerator_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCamera.__c__DisplayClass118_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr2) : null;
			}

			// Token: 0x0600CFCF RID: 53199 RVA: 0x00064B0C File Offset: 0x00062D0C
			public __c__DisplayClass118_0(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004065 RID: 16485
			// (get) Token: 0x0600CFD0 RID: 53200 RVA: 0x00325B10 File Offset: 0x00323D10
			// (set) Token: 0x0600CFD1 RID: 53201 RVA: 0x00064B15 File Offset: 0x00062D15
			public unsafe Vector3 point
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.__c__DisplayClass118_0.NativeFieldInfoPtr_point);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.__c__DisplayClass118_0.NativeFieldInfoPtr_point)) = value;
				}
			}

			// Token: 0x17004066 RID: 16486
			// (get) Token: 0x0600CFD2 RID: 53202 RVA: 0x00325B38 File Offset: 0x00323D38
			// (set) Token: 0x0600CFD3 RID: 53203 RVA: 0x00064B30 File Offset: 0x00062D30
			public unsafe PlayerCamera __4__this
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.__c__DisplayClass118_0.NativeFieldInfoPtr___4__this);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlayerCamera>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.__c__DisplayClass118_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004067 RID: 16487
			// (get) Token: 0x0600CFD4 RID: 53204 RVA: 0x00325B68 File Offset: 0x00323D68
			// (set) Token: 0x0600CFD5 RID: 53205 RVA: 0x00064B4F File Offset: 0x00062D4F
			public unsafe float duration
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.__c__DisplayClass118_0.NativeFieldInfoPtr_duration);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.__c__DisplayClass118_0.NativeFieldInfoPtr_duration)) = value;
				}
			}

			// Token: 0x04008C98 RID: 35992
			private static readonly System.IntPtr NativeFieldInfoPtr_point;

			// Token: 0x04008C99 RID: 35993
			private static readonly System.IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04008C9A RID: 35994
			private static readonly System.IntPtr NativeFieldInfoPtr_duration;

			// Token: 0x04008C9B RID: 35995
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008C9C RID: 35996
			private static readonly System.IntPtr NativeMethodInfoPtr_Method_Internal_IEnumerator_0;

			// Token: 0x02000CA0 RID: 3232
			[ObfuscatedName("ScheduleOne.PlayerScripts.PlayerCamera+<>c__DisplayClass118_0+<<LookAt>g__Look|0>d")]
			public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuSiQuObQuObQuUnique : Il2CppSystem.Object
			{
				// Token: 0x0600E80D RID: 59405 RVA: 0x00369F50 File Offset: 0x00368150
				// Note: this type is marked as 'beforefieldinit'.
				static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuSiQuObQuObQuUnique()
				{
					Il2CppClassPointerStore<PlayerCamera.__c__DisplayClass118_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuSiQuObQuObQuUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PlayerCamera.__c__DisplayClass118_0>.NativeClassPtr, "<<LookAt>g__Look|0>d");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayerCamera.__c__DisplayClass118_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuSiQuObQuObQuUnique>.NativeClassPtr);
					PlayerCamera.__c__DisplayClass118_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuSiQuObQuObQuUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCamera.__c__DisplayClass118_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuSiQuObQuObQuUnique>.NativeClassPtr, "<>1__state");
					PlayerCamera.__c__DisplayClass118_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuSiQuObQuObQuUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCamera.__c__DisplayClass118_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuSiQuObQuObQuUnique>.NativeClassPtr, "<>2__current");
					PlayerCamera.__c__DisplayClass118_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuSiQuObQuObQuUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCamera.__c__DisplayClass118_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuSiQuObQuObQuUnique>.NativeClassPtr, "<>4__this");
					PlayerCamera.__c__DisplayClass118_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuSiQuObQuObQuUnique.NativeFieldInfoPtr__playerEndRot_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCamera.__c__DisplayClass118_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuSiQuObQuObQuUnique>.NativeClassPtr, "<playerEndRot>5__2");
					PlayerCamera.__c__DisplayClass118_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuSiQuObQuObQuUnique.NativeFieldInfoPtr__cameraRotation_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCamera.__c__DisplayClass118_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuSiQuObQuObQuUnique>.NativeClassPtr, "<cameraRotation>5__3");
					PlayerCamera.__c__DisplayClass118_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuSiQuObQuObQuUnique.NativeFieldInfoPtr__playerStartRot_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCamera.__c__DisplayClass118_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuSiQuObQuObQuUnique>.NativeClassPtr, "<playerStartRot>5__4");
					PlayerCamera.__c__DisplayClass118_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuSiQuObQuObQuUnique.NativeFieldInfoPtr__cameraStartRot_5__5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCamera.__c__DisplayClass118_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuSiQuObQuObQuUnique>.NativeClassPtr, "<cameraStartRot>5__5");
					PlayerCamera.__c__DisplayClass118_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuSiQuObQuObQuUnique.NativeFieldInfoPtr__i_5__6 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCamera.__c__DisplayClass118_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuSiQuObQuObQuUnique>.NativeClassPtr, "<i>5__6");
					PlayerCamera.__c__DisplayClass118_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuSiQuObQuObQuUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera.__c__DisplayClass118_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuSiQuObQuObQuUnique>.NativeClassPtr, 100673543);
					PlayerCamera.__c__DisplayClass118_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuSiQuObQuObQuUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera.__c__DisplayClass118_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuSiQuObQuObQuUnique>.NativeClassPtr, 100673544);
					PlayerCamera.__c__DisplayClass118_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuSiQuObQuObQuUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera.__c__DisplayClass118_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuSiQuObQuObQuUnique>.NativeClassPtr, 100673545);
					PlayerCamera.__c__DisplayClass118_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuSiQuObQuObQuUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera.__c__DisplayClass118_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuSiQuObQuObQuUnique>.NativeClassPtr, 100673546);
					PlayerCamera.__c__DisplayClass118_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuSiQuObQuObQuUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera.__c__DisplayClass118_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuSiQuObQuObQuUnique>.NativeClassPtr, 100673547);
					PlayerCamera.__c__DisplayClass118_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuSiQuObQuObQuUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera.__c__DisplayClass118_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuSiQuObQuObQuUnique>.NativeClassPtr, 100673548);
				}

				// Token: 0x0600E80E RID: 59406 RVA: 0x0036A094 File Offset: 0x00368294
				[CallerCount(54)]
				[CachedScanResults(RefRangeStart = 2646, RefRangeEnd = 2700, XrefRangeStart = 2646, XrefRangeEnd = 2700, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuSiQuObQuObQuUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayerCamera.__c__DisplayClass118_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuSiQuObQuObQuUnique>.NativeClassPtr))
				{
					System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
					*ptr = ref <>1__state;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCamera.__c__DisplayClass118_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuSiQuObQuObQuUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				}

				// Token: 0x0600E80F RID: 59407 RVA: 0x0036A0DC File Offset: 0x003682DC
				[CallerCount(14558)]
				[CachedScanResults(RefRangeStart = 2769, RefRangeEnd = 17327, XrefRangeStart = 2769, XrefRangeEnd = 17327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCamera.__c__DisplayClass118_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuSiQuObQuObQuUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				}

				// Token: 0x0600E810 RID: 59408 RVA: 0x0036A110 File Offset: 0x00368310
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 176206, XrefRangeEnd = 176251, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(PlayerCamera.__c__DisplayClass118_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuSiQuObQuObQuUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
					return *IL2CPP.il2cpp_object_unbox(obj);
				}

				// Token: 0x170047AC RID: 18348
				// (get) Token: 0x0600E811 RID: 59409 RVA: 0x0036A14C File Offset: 0x0036834C
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(24)]
					[CachedScanResults(RefRangeStart = 2740, RefRangeEnd = 2764, XrefRangeStart = 2740, XrefRangeEnd = 2764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						System.IntPtr* param = null;
						System.IntPtr returnedException;
						System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCamera.__c__DisplayClass118_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuSiQuObQuObQuUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
						Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
						System.IntPtr intPtr2 = intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
				}

				// Token: 0x0600E812 RID: 59410 RVA: 0x0036A18C File Offset: 0x0036838C
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 176251, XrefRangeEnd = 176256, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCamera.__c__DisplayClass118_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuSiQuObQuObQuUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				}

				// Token: 0x170047AD RID: 18349
				// (get) Token: 0x0600E813 RID: 59411 RVA: 0x0036A1C0 File Offset: 0x003683C0
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(24)]
					[CachedScanResults(RefRangeStart = 2740, RefRangeEnd = 2764, XrefRangeStart = 2740, XrefRangeEnd = 2764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						System.IntPtr* param = null;
						System.IntPtr returnedException;
						System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCamera.__c__DisplayClass118_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuSiQuObQuObQuUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
						Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
						System.IntPtr intPtr2 = intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
				}

				// Token: 0x0600E814 RID: 59412 RVA: 0x00070D2E File Offset: 0x0006EF2E
				public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuSiQuObQuObQuUnique(System.IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x170047A4 RID: 18340
				// (get) Token: 0x0600E815 RID: 59413 RVA: 0x0036A200 File Offset: 0x00368400
				// (set) Token: 0x0600E816 RID: 59414 RVA: 0x00070D37 File Offset: 0x0006EF37
				public unsafe int __1__state
				{
					get
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.__c__DisplayClass118_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuSiQuObQuObQuUnique.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.__c__DisplayClass118_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuSiQuObQuObQuUnique.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x170047A5 RID: 18341
				// (get) Token: 0x0600E817 RID: 59415 RVA: 0x0036A228 File Offset: 0x00368428
				// (set) Token: 0x0600E818 RID: 59416 RVA: 0x00070D52 File Offset: 0x0006EF52
				public unsafe Il2CppSystem.Object __2__current
				{
					get
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.__c__DisplayClass118_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuSiQuObQuObQuUnique.NativeFieldInfoPtr___2__current);
						System.IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
					set
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.__c__DisplayClass118_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuSiQuObQuObQuUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x170047A6 RID: 18342
				// (get) Token: 0x0600E819 RID: 59417 RVA: 0x0036A258 File Offset: 0x00368458
				// (set) Token: 0x0600E81A RID: 59418 RVA: 0x00070D71 File Offset: 0x0006EF71
				public unsafe PlayerCamera.__c__DisplayClass118_0 __4__this
				{
					get
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.__c__DisplayClass118_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuSiQuObQuObQuUnique.NativeFieldInfoPtr___4__this);
						System.IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlayerCamera.__c__DisplayClass118_0>(intPtr2) : null;
					}
					set
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.__c__DisplayClass118_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuSiQuObQuObQuUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x170047A7 RID: 18343
				// (get) Token: 0x0600E81B RID: 59419 RVA: 0x0036A288 File Offset: 0x00368488
				// (set) Token: 0x0600E81C RID: 59420 RVA: 0x00070D90 File Offset: 0x0006EF90
				public unsafe Quaternion _playerEndRot_5__2
				{
					get
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.__c__DisplayClass118_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuSiQuObQuObQuUnique.NativeFieldInfoPtr__playerEndRot_5__2);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.__c__DisplayClass118_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuSiQuObQuObQuUnique.NativeFieldInfoPtr__playerEndRot_5__2)) = value;
					}
				}

				// Token: 0x170047A8 RID: 18344
				// (get) Token: 0x0600E81D RID: 59421 RVA: 0x0036A2B0 File Offset: 0x003684B0
				// (set) Token: 0x0600E81E RID: 59422 RVA: 0x00070DAB File Offset: 0x0006EFAB
				public unsafe Quaternion _cameraRotation_5__3
				{
					get
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.__c__DisplayClass118_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuSiQuObQuObQuUnique.NativeFieldInfoPtr__cameraRotation_5__3);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.__c__DisplayClass118_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuSiQuObQuObQuUnique.NativeFieldInfoPtr__cameraRotation_5__3)) = value;
					}
				}

				// Token: 0x170047A9 RID: 18345
				// (get) Token: 0x0600E81F RID: 59423 RVA: 0x0036A2D8 File Offset: 0x003684D8
				// (set) Token: 0x0600E820 RID: 59424 RVA: 0x00070DC6 File Offset: 0x0006EFC6
				public unsafe Quaternion _playerStartRot_5__4
				{
					get
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.__c__DisplayClass118_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuSiQuObQuObQuUnique.NativeFieldInfoPtr__playerStartRot_5__4);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.__c__DisplayClass118_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuSiQuObQuObQuUnique.NativeFieldInfoPtr__playerStartRot_5__4)) = value;
					}
				}

				// Token: 0x170047AA RID: 18346
				// (get) Token: 0x0600E821 RID: 59425 RVA: 0x0036A300 File Offset: 0x00368500
				// (set) Token: 0x0600E822 RID: 59426 RVA: 0x00070DE1 File Offset: 0x0006EFE1
				public unsafe Quaternion _cameraStartRot_5__5
				{
					get
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.__c__DisplayClass118_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuSiQuObQuObQuUnique.NativeFieldInfoPtr__cameraStartRot_5__5);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.__c__DisplayClass118_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuSiQuObQuObQuUnique.NativeFieldInfoPtr__cameraStartRot_5__5)) = value;
					}
				}

				// Token: 0x170047AB RID: 18347
				// (get) Token: 0x0600E823 RID: 59427 RVA: 0x0036A328 File Offset: 0x00368528
				// (set) Token: 0x0600E824 RID: 59428 RVA: 0x00070DFC File Offset: 0x0006EFFC
				public unsafe float _i_5__6
				{
					get
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.__c__DisplayClass118_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuSiQuObQuObQuUnique.NativeFieldInfoPtr__i_5__6);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.__c__DisplayClass118_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuSiQuObQuObQuUnique.NativeFieldInfoPtr__i_5__6)) = value;
					}
				}

				// Token: 0x04009B5E RID: 39774
				private static readonly System.IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x04009B5F RID: 39775
				private static readonly System.IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x04009B60 RID: 39776
				private static readonly System.IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x04009B61 RID: 39777
				private static readonly System.IntPtr NativeFieldInfoPtr__playerEndRot_5__2;

				// Token: 0x04009B62 RID: 39778
				private static readonly System.IntPtr NativeFieldInfoPtr__cameraRotation_5__3;

				// Token: 0x04009B63 RID: 39779
				private static readonly System.IntPtr NativeFieldInfoPtr__playerStartRot_5__4;

				// Token: 0x04009B64 RID: 39780
				private static readonly System.IntPtr NativeFieldInfoPtr__cameraStartRot_5__5;

				// Token: 0x04009B65 RID: 39781
				private static readonly System.IntPtr NativeFieldInfoPtr__i_5__6;

				// Token: 0x04009B66 RID: 39782
				private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x04009B67 RID: 39783
				private static readonly System.IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x04009B68 RID: 39784
				private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x04009B69 RID: 39785
				private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x04009B6A RID: 39786
				private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x04009B6B RID: 39787
				private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
			}
		}

		// Token: 0x020009E4 RID: 2532
		[ObfuscatedName("ScheduleOne.PlayerScripts.PlayerCamera+<>c__DisplayClass139_0")]
		public sealed class __c__DisplayClass139_0 : Il2CppSystem.Object
		{
			// Token: 0x0600CFD6 RID: 53206 RVA: 0x00325B90 File Offset: 0x00323D90
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass139_0()
			{
				Il2CppClassPointerStore<PlayerCamera.__c__DisplayClass139_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, "<>c__DisplayClass139_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayerCamera.__c__DisplayClass139_0>.NativeClassPtr);
				PlayerCamera.__c__DisplayClass139_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCamera.__c__DisplayClass139_0>.NativeClassPtr, "<>4__this");
				PlayerCamera.__c__DisplayClass139_0.NativeFieldInfoPtr_target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCamera.__c__DisplayClass139_0>.NativeClassPtr, "target");
				PlayerCamera.__c__DisplayClass139_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera.__c__DisplayClass139_0>.NativeClassPtr, 100673549);
				PlayerCamera.__c__DisplayClass139_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera.__c__DisplayClass139_0>.NativeClassPtr, 100673550);
			}

			// Token: 0x0600CFD7 RID: 53207 RVA: 0x00325C0C File Offset: 0x00323E0C
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass139_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayerCamera.__c__DisplayClass139_0>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCamera.__c__DisplayClass139_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600CFD8 RID: 53208 RVA: 0x00325C48 File Offset: 0x00323E48
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 176322, RefRangeEnd = 176323, XrefRangeStart = 176317, XrefRangeEnd = 176322, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator Method_Internal_IEnumerator_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCamera.__c__DisplayClass139_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr2) : null;
			}

			// Token: 0x0600CFD9 RID: 53209 RVA: 0x00064B6A File Offset: 0x00062D6A
			public __c__DisplayClass139_0(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004068 RID: 16488
			// (get) Token: 0x0600CFDA RID: 53210 RVA: 0x00325C88 File Offset: 0x00323E88
			// (set) Token: 0x0600CFDB RID: 53211 RVA: 0x00064B73 File Offset: 0x00062D73
			public unsafe PlayerCamera __4__this
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.__c__DisplayClass139_0.NativeFieldInfoPtr___4__this);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlayerCamera>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.__c__DisplayClass139_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004069 RID: 16489
			// (get) Token: 0x0600CFDC RID: 53212 RVA: 0x00325CB8 File Offset: 0x00323EB8
			// (set) Token: 0x0600CFDD RID: 53213 RVA: 0x00064B92 File Offset: 0x00062D92
			public unsafe Transform target
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.__c__DisplayClass139_0.NativeFieldInfoPtr_target);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.__c__DisplayClass139_0.NativeFieldInfoPtr_target), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008C9D RID: 35997
			private static readonly System.IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04008C9E RID: 35998
			private static readonly System.IntPtr NativeFieldInfoPtr_target;

			// Token: 0x04008C9F RID: 35999
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008CA0 RID: 36000
			private static readonly System.IntPtr NativeMethodInfoPtr_Method_Internal_IEnumerator_0;

			// Token: 0x02000CA1 RID: 3233
			[ObfuscatedName("ScheduleOne.PlayerScripts.PlayerCamera+<>c__DisplayClass139_0+<<FocusCameraOnTarget>g__FocusRoutine|0>d")]
			public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique : Il2CppSystem.Object
			{
				// Token: 0x0600E825 RID: 59429 RVA: 0x0036A350 File Offset: 0x00368550
				// Note: this type is marked as 'beforefieldinit'.
				static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique()
				{
					Il2CppClassPointerStore<PlayerCamera.__c__DisplayClass139_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PlayerCamera.__c__DisplayClass139_0>.NativeClassPtr, "<<FocusCameraOnTarget>g__FocusRoutine|0>d");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayerCamera.__c__DisplayClass139_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr);
					PlayerCamera.__c__DisplayClass139_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCamera.__c__DisplayClass139_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr, "<>1__state");
					PlayerCamera.__c__DisplayClass139_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCamera.__c__DisplayClass139_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr, "<>2__current");
					PlayerCamera.__c__DisplayClass139_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCamera.__c__DisplayClass139_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr, "<>4__this");
					PlayerCamera.__c__DisplayClass139_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeFieldInfoPtr__duration_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCamera.__c__DisplayClass139_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr, "<duration>5__2");
					PlayerCamera.__c__DisplayClass139_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera.__c__DisplayClass139_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr, 100673551);
					PlayerCamera.__c__DisplayClass139_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera.__c__DisplayClass139_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr, 100673552);
					PlayerCamera.__c__DisplayClass139_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera.__c__DisplayClass139_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr, 100673553);
					PlayerCamera.__c__DisplayClass139_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera.__c__DisplayClass139_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr, 100673554);
					PlayerCamera.__c__DisplayClass139_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera.__c__DisplayClass139_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr, 100673555);
					PlayerCamera.__c__DisplayClass139_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera.__c__DisplayClass139_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr, 100673556);
				}

				// Token: 0x0600E826 RID: 59430 RVA: 0x0036A444 File Offset: 0x00368644
				[CallerCount(54)]
				[CachedScanResults(RefRangeStart = 2646, RefRangeEnd = 2700, XrefRangeStart = 2646, XrefRangeEnd = 2700, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayerCamera.__c__DisplayClass139_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr))
				{
					System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
					*ptr = ref <>1__state;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCamera.__c__DisplayClass139_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				}

				// Token: 0x0600E827 RID: 59431 RVA: 0x0036A48C File Offset: 0x0036868C
				[CallerCount(14558)]
				[CachedScanResults(RefRangeStart = 2769, RefRangeEnd = 17327, XrefRangeStart = 2769, XrefRangeEnd = 17327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCamera.__c__DisplayClass139_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				}

				// Token: 0x0600E828 RID: 59432 RVA: 0x0036A4C0 File Offset: 0x003686C0
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 176262, XrefRangeEnd = 176312, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(PlayerCamera.__c__DisplayClass139_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
					return *IL2CPP.il2cpp_object_unbox(obj);
				}

				// Token: 0x170047B2 RID: 18354
				// (get) Token: 0x0600E829 RID: 59433 RVA: 0x0036A4FC File Offset: 0x003686FC
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(24)]
					[CachedScanResults(RefRangeStart = 2740, RefRangeEnd = 2764, XrefRangeStart = 2740, XrefRangeEnd = 2764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						System.IntPtr* param = null;
						System.IntPtr returnedException;
						System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCamera.__c__DisplayClass139_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
						Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
						System.IntPtr intPtr2 = intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
				}

				// Token: 0x0600E82A RID: 59434 RVA: 0x0036A53C File Offset: 0x0036873C
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 176312, XrefRangeEnd = 176317, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCamera.__c__DisplayClass139_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				}

				// Token: 0x170047B3 RID: 18355
				// (get) Token: 0x0600E82B RID: 59435 RVA: 0x0036A570 File Offset: 0x00368770
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(24)]
					[CachedScanResults(RefRangeStart = 2740, RefRangeEnd = 2764, XrefRangeStart = 2740, XrefRangeEnd = 2764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						System.IntPtr* param = null;
						System.IntPtr returnedException;
						System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCamera.__c__DisplayClass139_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
						Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
						System.IntPtr intPtr2 = intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
				}

				// Token: 0x0600E82C RID: 59436 RVA: 0x00070E17 File Offset: 0x0006F017
				public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique(System.IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x170047AE RID: 18350
				// (get) Token: 0x0600E82D RID: 59437 RVA: 0x0036A5B0 File Offset: 0x003687B0
				// (set) Token: 0x0600E82E RID: 59438 RVA: 0x00070E20 File Offset: 0x0006F020
				public unsafe int __1__state
				{
					get
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.__c__DisplayClass139_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.__c__DisplayClass139_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x170047AF RID: 18351
				// (get) Token: 0x0600E82F RID: 59439 RVA: 0x0036A5D8 File Offset: 0x003687D8
				// (set) Token: 0x0600E830 RID: 59440 RVA: 0x00070E3B File Offset: 0x0006F03B
				public unsafe Il2CppSystem.Object __2__current
				{
					get
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.__c__DisplayClass139_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeFieldInfoPtr___2__current);
						System.IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
					set
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.__c__DisplayClass139_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x170047B0 RID: 18352
				// (get) Token: 0x0600E831 RID: 59441 RVA: 0x0036A608 File Offset: 0x00368808
				// (set) Token: 0x0600E832 RID: 59442 RVA: 0x00070E5A File Offset: 0x0006F05A
				public unsafe PlayerCamera.__c__DisplayClass139_0 __4__this
				{
					get
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.__c__DisplayClass139_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeFieldInfoPtr___4__this);
						System.IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlayerCamera.__c__DisplayClass139_0>(intPtr2) : null;
					}
					set
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.__c__DisplayClass139_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x170047B1 RID: 18353
				// (get) Token: 0x0600E833 RID: 59443 RVA: 0x0036A638 File Offset: 0x00368838
				// (set) Token: 0x0600E834 RID: 59444 RVA: 0x00070E79 File Offset: 0x0006F079
				public unsafe float _duration_5__2
				{
					get
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.__c__DisplayClass139_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeFieldInfoPtr__duration_5__2);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.__c__DisplayClass139_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeFieldInfoPtr__duration_5__2)) = value;
					}
				}

				// Token: 0x04009B6C RID: 39788
				private static readonly System.IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x04009B6D RID: 39789
				private static readonly System.IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x04009B6E RID: 39790
				private static readonly System.IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x04009B6F RID: 39791
				private static readonly System.IntPtr NativeFieldInfoPtr__duration_5__2;

				// Token: 0x04009B70 RID: 39792
				private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x04009B71 RID: 39793
				private static readonly System.IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x04009B72 RID: 39794
				private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x04009B73 RID: 39795
				private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x04009B74 RID: 39796
				private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x04009B75 RID: 39797
				private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
			}
		}

		// Token: 0x020009E5 RID: 2533
		[ObfuscatedName("ScheduleOne.PlayerScripts.PlayerCamera+<>c__DisplayClass141_0")]
		public sealed class __c__DisplayClass141_0 : Il2CppSystem.Object
		{
			// Token: 0x0600CFDE RID: 53214 RVA: 0x00325CE8 File Offset: 0x00323EE8
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass141_0()
			{
				Il2CppClassPointerStore<PlayerCamera.__c__DisplayClass141_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, "<>c__DisplayClass141_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayerCamera.__c__DisplayClass141_0>.NativeClassPtr);
				PlayerCamera.__c__DisplayClass141_0.NativeFieldInfoPtr_duration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCamera.__c__DisplayClass141_0>.NativeClassPtr, "duration");
				PlayerCamera.__c__DisplayClass141_0.NativeFieldInfoPtr_intensity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCamera.__c__DisplayClass141_0>.NativeClassPtr, "intensity");
				PlayerCamera.__c__DisplayClass141_0.NativeFieldInfoPtr_decreaseOverTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCamera.__c__DisplayClass141_0>.NativeClassPtr, "decreaseOverTime");
				PlayerCamera.__c__DisplayClass141_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCamera.__c__DisplayClass141_0>.NativeClassPtr, "<>4__this");
				PlayerCamera.__c__DisplayClass141_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera.__c__DisplayClass141_0>.NativeClassPtr, 100673557);
				PlayerCamera.__c__DisplayClass141_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera.__c__DisplayClass141_0>.NativeClassPtr, 100673558);
			}

			// Token: 0x0600CFDF RID: 53215 RVA: 0x00325D8C File Offset: 0x00323F8C
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass141_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayerCamera.__c__DisplayClass141_0>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCamera.__c__DisplayClass141_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600CFE0 RID: 53216 RVA: 0x00325DC8 File Offset: 0x00323FC8
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 176343, RefRangeEnd = 176345, XrefRangeStart = 176338, XrefRangeEnd = 176343, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator Method_Internal_IEnumerator_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCamera.__c__DisplayClass141_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr2) : null;
			}

			// Token: 0x0600CFE1 RID: 53217 RVA: 0x00064BB1 File Offset: 0x00062DB1
			public __c__DisplayClass141_0(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700406A RID: 16490
			// (get) Token: 0x0600CFE2 RID: 53218 RVA: 0x00325E08 File Offset: 0x00324008
			// (set) Token: 0x0600CFE3 RID: 53219 RVA: 0x00064BBA File Offset: 0x00062DBA
			public unsafe float duration
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.__c__DisplayClass141_0.NativeFieldInfoPtr_duration);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.__c__DisplayClass141_0.NativeFieldInfoPtr_duration)) = value;
				}
			}

			// Token: 0x1700406B RID: 16491
			// (get) Token: 0x0600CFE4 RID: 53220 RVA: 0x00325E30 File Offset: 0x00324030
			// (set) Token: 0x0600CFE5 RID: 53221 RVA: 0x00064BD5 File Offset: 0x00062DD5
			public unsafe float intensity
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.__c__DisplayClass141_0.NativeFieldInfoPtr_intensity);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.__c__DisplayClass141_0.NativeFieldInfoPtr_intensity)) = value;
				}
			}

			// Token: 0x1700406C RID: 16492
			// (get) Token: 0x0600CFE6 RID: 53222 RVA: 0x00325E58 File Offset: 0x00324058
			// (set) Token: 0x0600CFE7 RID: 53223 RVA: 0x00064BF0 File Offset: 0x00062DF0
			public unsafe bool decreaseOverTime
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.__c__DisplayClass141_0.NativeFieldInfoPtr_decreaseOverTime);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.__c__DisplayClass141_0.NativeFieldInfoPtr_decreaseOverTime)) = value;
				}
			}

			// Token: 0x1700406D RID: 16493
			// (get) Token: 0x0600CFE8 RID: 53224 RVA: 0x00325E80 File Offset: 0x00324080
			// (set) Token: 0x0600CFE9 RID: 53225 RVA: 0x00064C0B File Offset: 0x00062E0B
			public unsafe PlayerCamera __4__this
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.__c__DisplayClass141_0.NativeFieldInfoPtr___4__this);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlayerCamera>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.__c__DisplayClass141_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008CA1 RID: 36001
			private static readonly System.IntPtr NativeFieldInfoPtr_duration;

			// Token: 0x04008CA2 RID: 36002
			private static readonly System.IntPtr NativeFieldInfoPtr_intensity;

			// Token: 0x04008CA3 RID: 36003
			private static readonly System.IntPtr NativeFieldInfoPtr_decreaseOverTime;

			// Token: 0x04008CA4 RID: 36004
			private static readonly System.IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04008CA5 RID: 36005
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008CA6 RID: 36006
			private static readonly System.IntPtr NativeMethodInfoPtr_Method_Internal_IEnumerator_0;

			// Token: 0x02000CA2 RID: 3234
			[ObfuscatedName("ScheduleOne.PlayerScripts.PlayerCamera+<>c__DisplayClass141_0+<<StartCameraShake>g__Shake|0>d")]
			public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique : Il2CppSystem.Object
			{
				// Token: 0x0600E835 RID: 59445 RVA: 0x0036A660 File Offset: 0x00368860
				// Note: this type is marked as 'beforefieldinit'.
				static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique()
				{
					Il2CppClassPointerStore<PlayerCamera.__c__DisplayClass141_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PlayerCamera.__c__DisplayClass141_0>.NativeClassPtr, "<<StartCameraShake>g__Shake|0>d");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayerCamera.__c__DisplayClass141_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr);
					PlayerCamera.__c__DisplayClass141_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCamera.__c__DisplayClass141_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr, "<>1__state");
					PlayerCamera.__c__DisplayClass141_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCamera.__c__DisplayClass141_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr, "<>2__current");
					PlayerCamera.__c__DisplayClass141_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCamera.__c__DisplayClass141_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr, "<>4__this");
					PlayerCamera.__c__DisplayClass141_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeFieldInfoPtr__timeRemaining_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCamera.__c__DisplayClass141_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr, "<timeRemaining>5__2");
					PlayerCamera.__c__DisplayClass141_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera.__c__DisplayClass141_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr, 100673559);
					PlayerCamera.__c__DisplayClass141_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera.__c__DisplayClass141_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr, 100673560);
					PlayerCamera.__c__DisplayClass141_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera.__c__DisplayClass141_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr, 100673561);
					PlayerCamera.__c__DisplayClass141_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera.__c__DisplayClass141_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr, 100673562);
					PlayerCamera.__c__DisplayClass141_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera.__c__DisplayClass141_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr, 100673563);
					PlayerCamera.__c__DisplayClass141_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera.__c__DisplayClass141_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr, 100673564);
				}

				// Token: 0x0600E836 RID: 59446 RVA: 0x0036A754 File Offset: 0x00368954
				[CallerCount(54)]
				[CachedScanResults(RefRangeStart = 2646, RefRangeEnd = 2700, XrefRangeStart = 2646, XrefRangeEnd = 2700, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayerCamera.__c__DisplayClass141_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr))
				{
					System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
					*ptr = ref <>1__state;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCamera.__c__DisplayClass141_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				}

				// Token: 0x0600E837 RID: 59447 RVA: 0x0036A79C File Offset: 0x0036899C
				[CallerCount(14558)]
				[CachedScanResults(RefRangeStart = 2769, RefRangeEnd = 17327, XrefRangeStart = 2769, XrefRangeEnd = 17327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCamera.__c__DisplayClass141_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				}

				// Token: 0x0600E838 RID: 59448 RVA: 0x0036A7D0 File Offset: 0x003689D0
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 176323, XrefRangeEnd = 176333, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(PlayerCamera.__c__DisplayClass141_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
					return *IL2CPP.il2cpp_object_unbox(obj);
				}

				// Token: 0x170047B8 RID: 18360
				// (get) Token: 0x0600E839 RID: 59449 RVA: 0x0036A80C File Offset: 0x00368A0C
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(24)]
					[CachedScanResults(RefRangeStart = 2740, RefRangeEnd = 2764, XrefRangeStart = 2740, XrefRangeEnd = 2764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						System.IntPtr* param = null;
						System.IntPtr returnedException;
						System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCamera.__c__DisplayClass141_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
						Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
						System.IntPtr intPtr2 = intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
				}

				// Token: 0x0600E83A RID: 59450 RVA: 0x0036A84C File Offset: 0x00368A4C
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 176333, XrefRangeEnd = 176338, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCamera.__c__DisplayClass141_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				}

				// Token: 0x170047B9 RID: 18361
				// (get) Token: 0x0600E83B RID: 59451 RVA: 0x0036A880 File Offset: 0x00368A80
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(24)]
					[CachedScanResults(RefRangeStart = 2740, RefRangeEnd = 2764, XrefRangeStart = 2740, XrefRangeEnd = 2764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						System.IntPtr* param = null;
						System.IntPtr returnedException;
						System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCamera.__c__DisplayClass141_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
						Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
						System.IntPtr intPtr2 = intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
				}

				// Token: 0x0600E83C RID: 59452 RVA: 0x00070E94 File Offset: 0x0006F094
				public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique(System.IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x170047B4 RID: 18356
				// (get) Token: 0x0600E83D RID: 59453 RVA: 0x0036A8C0 File Offset: 0x00368AC0
				// (set) Token: 0x0600E83E RID: 59454 RVA: 0x00070E9D File Offset: 0x0006F09D
				public unsafe int __1__state
				{
					get
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.__c__DisplayClass141_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.__c__DisplayClass141_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x170047B5 RID: 18357
				// (get) Token: 0x0600E83F RID: 59455 RVA: 0x0036A8E8 File Offset: 0x00368AE8
				// (set) Token: 0x0600E840 RID: 59456 RVA: 0x00070EB8 File Offset: 0x0006F0B8
				public unsafe Il2CppSystem.Object __2__current
				{
					get
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.__c__DisplayClass141_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeFieldInfoPtr___2__current);
						System.IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
					set
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.__c__DisplayClass141_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x170047B6 RID: 18358
				// (get) Token: 0x0600E841 RID: 59457 RVA: 0x0036A918 File Offset: 0x00368B18
				// (set) Token: 0x0600E842 RID: 59458 RVA: 0x00070ED7 File Offset: 0x0006F0D7
				public unsafe PlayerCamera.__c__DisplayClass141_0 __4__this
				{
					get
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.__c__DisplayClass141_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeFieldInfoPtr___4__this);
						System.IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlayerCamera.__c__DisplayClass141_0>(intPtr2) : null;
					}
					set
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.__c__DisplayClass141_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x170047B7 RID: 18359
				// (get) Token: 0x0600E843 RID: 59459 RVA: 0x0036A948 File Offset: 0x00368B48
				// (set) Token: 0x0600E844 RID: 59460 RVA: 0x00070EF6 File Offset: 0x0006F0F6
				public unsafe float _timeRemaining_5__2
				{
					get
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.__c__DisplayClass141_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeFieldInfoPtr__timeRemaining_5__2);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera.__c__DisplayClass141_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeFieldInfoPtr__timeRemaining_5__2)) = value;
					}
				}

				// Token: 0x04009B76 RID: 39798
				private static readonly System.IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x04009B77 RID: 39799
				private static readonly System.IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x04009B78 RID: 39800
				private static readonly System.IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x04009B79 RID: 39801
				private static readonly System.IntPtr NativeFieldInfoPtr__timeRemaining_5__2;

				// Token: 0x04009B7A RID: 39802
				private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x04009B7B RID: 39803
				private static readonly System.IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x04009B7C RID: 39804
				private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x04009B7D RID: 39805
				private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x04009B7E RID: 39806
				private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x04009B7F RID: 39807
				private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
			}
		}

		// Token: 0x020009E6 RID: 2534
		[ObfuscatedName("ScheduleOne.PlayerScripts.PlayerCamera+<ILerpCamera>d__115")]
		public sealed class _ILerpCamera_d__115 : Il2CppSystem.Object
		{
			// Token: 0x0600CFEA RID: 53226 RVA: 0x00325EB0 File Offset: 0x003240B0
			// Note: this type is marked as 'beforefieldinit'.
			static _ILerpCamera_d__115()
			{
				Il2CppClassPointerStore<PlayerCamera._ILerpCamera_d__115>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, "<ILerpCamera>d__115");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayerCamera._ILerpCamera_d__115>.NativeClassPtr);
				PlayerCamera._ILerpCamera_d__115.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCamera._ILerpCamera_d__115>.NativeClassPtr, "<>1__state");
				PlayerCamera._ILerpCamera_d__115.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCamera._ILerpCamera_d__115>.NativeClassPtr, "<>2__current");
				PlayerCamera._ILerpCamera_d__115.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCamera._ILerpCamera_d__115>.NativeClassPtr, "<>4__this");
				PlayerCamera._ILerpCamera_d__115.NativeFieldInfoPtr_worldSpace = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCamera._ILerpCamera_d__115>.NativeClassPtr, "worldSpace");
				PlayerCamera._ILerpCamera_d__115.NativeFieldInfoPtr_returnToRestingPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCamera._ILerpCamera_d__115>.NativeClassPtr, "returnToRestingPosition");
				PlayerCamera._ILerpCamera_d__115.NativeFieldInfoPtr_lerpTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCamera._ILerpCamera_d__115>.NativeClassPtr, "lerpTime");
				PlayerCamera._ILerpCamera_d__115.NativeFieldInfoPtr_endPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCamera._ILerpCamera_d__115>.NativeClassPtr, "endPos");
				PlayerCamera._ILerpCamera_d__115.NativeFieldInfoPtr_endRot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCamera._ILerpCamera_d__115>.NativeClassPtr, "endRot");
				PlayerCamera._ILerpCamera_d__115.NativeFieldInfoPtr_reenableLook = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCamera._ILerpCamera_d__115>.NativeClassPtr, "reenableLook");
				PlayerCamera._ILerpCamera_d__115.NativeFieldInfoPtr__startPos_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCamera._ILerpCamera_d__115>.NativeClassPtr, "<startPos>5__2");
				PlayerCamera._ILerpCamera_d__115.NativeFieldInfoPtr__startRot_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCamera._ILerpCamera_d__115>.NativeClassPtr, "<startRot>5__3");
				PlayerCamera._ILerpCamera_d__115.NativeFieldInfoPtr__elapsed_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCamera._ILerpCamera_d__115>.NativeClassPtr, "<elapsed>5__4");
				PlayerCamera._ILerpCamera_d__115.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera._ILerpCamera_d__115>.NativeClassPtr, 100673565);
				PlayerCamera._ILerpCamera_d__115.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera._ILerpCamera_d__115>.NativeClassPtr, 100673566);
				PlayerCamera._ILerpCamera_d__115.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera._ILerpCamera_d__115>.NativeClassPtr, 100673567);
				PlayerCamera._ILerpCamera_d__115.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera._ILerpCamera_d__115>.NativeClassPtr, 100673568);
				PlayerCamera._ILerpCamera_d__115.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera._ILerpCamera_d__115>.NativeClassPtr, 100673569);
				PlayerCamera._ILerpCamera_d__115.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera._ILerpCamera_d__115>.NativeClassPtr, 100673570);
			}

			// Token: 0x0600CFEB RID: 53227 RVA: 0x00326044 File Offset: 0x00324244
			[CallerCount(54)]
			[CachedScanResults(RefRangeStart = 2646, RefRangeEnd = 2700, XrefRangeStart = 2646, XrefRangeEnd = 2700, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _ILerpCamera_d__115(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayerCamera._ILerpCamera_d__115>.NativeClassPtr))
			{
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = ref <>1__state;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCamera._ILerpCamera_d__115.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600CFEC RID: 53228 RVA: 0x0032608C File Offset: 0x0032428C
			[CallerCount(14558)]
			[CachedScanResults(RefRangeStart = 2769, RefRangeEnd = 17327, XrefRangeStart = 2769, XrefRangeEnd = 17327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCamera._ILerpCamera_d__115.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600CFED RID: 53229 RVA: 0x003260C0 File Offset: 0x003242C0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 176345, XrefRangeEnd = 176385, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(PlayerCamera._ILerpCamera_d__115.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x1700407A RID: 16506
			// (get) Token: 0x0600CFEE RID: 53230 RVA: 0x003260FC File Offset: 0x003242FC
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 2740, RefRangeEnd = 2764, XrefRangeStart = 2740, XrefRangeEnd = 2764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCamera._ILerpCamera_d__115.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
			}

			// Token: 0x0600CFEF RID: 53231 RVA: 0x0032613C File Offset: 0x0032433C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 176385, XrefRangeEnd = 176390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCamera._ILerpCamera_d__115.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x1700407B RID: 16507
			// (get) Token: 0x0600CFF0 RID: 53232 RVA: 0x00326170 File Offset: 0x00324370
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 2740, RefRangeEnd = 2764, XrefRangeStart = 2740, XrefRangeEnd = 2764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCamera._ILerpCamera_d__115.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
			}

			// Token: 0x0600CFF1 RID: 53233 RVA: 0x00064C2A File Offset: 0x00062E2A
			public _ILerpCamera_d__115(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700406E RID: 16494
			// (get) Token: 0x0600CFF2 RID: 53234 RVA: 0x003261B0 File Offset: 0x003243B0
			// (set) Token: 0x0600CFF3 RID: 53235 RVA: 0x00064C33 File Offset: 0x00062E33
			public unsafe int __1__state
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera._ILerpCamera_d__115.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera._ILerpCamera_d__115.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700406F RID: 16495
			// (get) Token: 0x0600CFF4 RID: 53236 RVA: 0x003261D8 File Offset: 0x003243D8
			// (set) Token: 0x0600CFF5 RID: 53237 RVA: 0x00064C4E File Offset: 0x00062E4E
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera._ILerpCamera_d__115.NativeFieldInfoPtr___2__current);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera._ILerpCamera_d__115.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004070 RID: 16496
			// (get) Token: 0x0600CFF6 RID: 53238 RVA: 0x00326208 File Offset: 0x00324408
			// (set) Token: 0x0600CFF7 RID: 53239 RVA: 0x00064C6D File Offset: 0x00062E6D
			public unsafe PlayerCamera __4__this
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera._ILerpCamera_d__115.NativeFieldInfoPtr___4__this);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlayerCamera>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera._ILerpCamera_d__115.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004071 RID: 16497
			// (get) Token: 0x0600CFF8 RID: 53240 RVA: 0x00326238 File Offset: 0x00324438
			// (set) Token: 0x0600CFF9 RID: 53241 RVA: 0x00064C8C File Offset: 0x00062E8C
			public unsafe bool worldSpace
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera._ILerpCamera_d__115.NativeFieldInfoPtr_worldSpace);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera._ILerpCamera_d__115.NativeFieldInfoPtr_worldSpace)) = value;
				}
			}

			// Token: 0x17004072 RID: 16498
			// (get) Token: 0x0600CFFA RID: 53242 RVA: 0x00326260 File Offset: 0x00324460
			// (set) Token: 0x0600CFFB RID: 53243 RVA: 0x00064CA7 File Offset: 0x00062EA7
			public unsafe bool returnToRestingPosition
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera._ILerpCamera_d__115.NativeFieldInfoPtr_returnToRestingPosition);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera._ILerpCamera_d__115.NativeFieldInfoPtr_returnToRestingPosition)) = value;
				}
			}

			// Token: 0x17004073 RID: 16499
			// (get) Token: 0x0600CFFC RID: 53244 RVA: 0x00326288 File Offset: 0x00324488
			// (set) Token: 0x0600CFFD RID: 53245 RVA: 0x00064CC2 File Offset: 0x00062EC2
			public unsafe float lerpTime
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera._ILerpCamera_d__115.NativeFieldInfoPtr_lerpTime);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera._ILerpCamera_d__115.NativeFieldInfoPtr_lerpTime)) = value;
				}
			}

			// Token: 0x17004074 RID: 16500
			// (get) Token: 0x0600CFFE RID: 53246 RVA: 0x003262B0 File Offset: 0x003244B0
			// (set) Token: 0x0600CFFF RID: 53247 RVA: 0x00064CDD File Offset: 0x00062EDD
			public unsafe Vector3 endPos
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera._ILerpCamera_d__115.NativeFieldInfoPtr_endPos);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera._ILerpCamera_d__115.NativeFieldInfoPtr_endPos)) = value;
				}
			}

			// Token: 0x17004075 RID: 16501
			// (get) Token: 0x0600D000 RID: 53248 RVA: 0x003262D8 File Offset: 0x003244D8
			// (set) Token: 0x0600D001 RID: 53249 RVA: 0x00064CF8 File Offset: 0x00062EF8
			public unsafe Quaternion endRot
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera._ILerpCamera_d__115.NativeFieldInfoPtr_endRot);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera._ILerpCamera_d__115.NativeFieldInfoPtr_endRot)) = value;
				}
			}

			// Token: 0x17004076 RID: 16502
			// (get) Token: 0x0600D002 RID: 53250 RVA: 0x00326300 File Offset: 0x00324500
			// (set) Token: 0x0600D003 RID: 53251 RVA: 0x00064D13 File Offset: 0x00062F13
			public unsafe bool reenableLook
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera._ILerpCamera_d__115.NativeFieldInfoPtr_reenableLook);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera._ILerpCamera_d__115.NativeFieldInfoPtr_reenableLook)) = value;
				}
			}

			// Token: 0x17004077 RID: 16503
			// (get) Token: 0x0600D004 RID: 53252 RVA: 0x00326328 File Offset: 0x00324528
			// (set) Token: 0x0600D005 RID: 53253 RVA: 0x00064D2E File Offset: 0x00062F2E
			public unsafe Vector3 _startPos_5__2
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera._ILerpCamera_d__115.NativeFieldInfoPtr__startPos_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera._ILerpCamera_d__115.NativeFieldInfoPtr__startPos_5__2)) = value;
				}
			}

			// Token: 0x17004078 RID: 16504
			// (get) Token: 0x0600D006 RID: 53254 RVA: 0x00326350 File Offset: 0x00324550
			// (set) Token: 0x0600D007 RID: 53255 RVA: 0x00064D49 File Offset: 0x00062F49
			public unsafe Quaternion _startRot_5__3
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera._ILerpCamera_d__115.NativeFieldInfoPtr__startRot_5__3);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera._ILerpCamera_d__115.NativeFieldInfoPtr__startRot_5__3)) = value;
				}
			}

			// Token: 0x17004079 RID: 16505
			// (get) Token: 0x0600D008 RID: 53256 RVA: 0x00326378 File Offset: 0x00324578
			// (set) Token: 0x0600D009 RID: 53257 RVA: 0x00064D64 File Offset: 0x00062F64
			public unsafe float _elapsed_5__4
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera._ILerpCamera_d__115.NativeFieldInfoPtr__elapsed_5__4);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera._ILerpCamera_d__115.NativeFieldInfoPtr__elapsed_5__4)) = value;
				}
			}

			// Token: 0x04008CA7 RID: 36007
			private static readonly System.IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04008CA8 RID: 36008
			private static readonly System.IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04008CA9 RID: 36009
			private static readonly System.IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04008CAA RID: 36010
			private static readonly System.IntPtr NativeFieldInfoPtr_worldSpace;

			// Token: 0x04008CAB RID: 36011
			private static readonly System.IntPtr NativeFieldInfoPtr_returnToRestingPosition;

			// Token: 0x04008CAC RID: 36012
			private static readonly System.IntPtr NativeFieldInfoPtr_lerpTime;

			// Token: 0x04008CAD RID: 36013
			private static readonly System.IntPtr NativeFieldInfoPtr_endPos;

			// Token: 0x04008CAE RID: 36014
			private static readonly System.IntPtr NativeFieldInfoPtr_endRot;

			// Token: 0x04008CAF RID: 36015
			private static readonly System.IntPtr NativeFieldInfoPtr_reenableLook;

			// Token: 0x04008CB0 RID: 36016
			private static readonly System.IntPtr NativeFieldInfoPtr__startPos_5__2;

			// Token: 0x04008CB1 RID: 36017
			private static readonly System.IntPtr NativeFieldInfoPtr__startRot_5__3;

			// Token: 0x04008CB2 RID: 36018
			private static readonly System.IntPtr NativeFieldInfoPtr__elapsed_5__4;

			// Token: 0x04008CB3 RID: 36019
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04008CB4 RID: 36020
			private static readonly System.IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008CB5 RID: 36021
			private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04008CB6 RID: 36022
			private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04008CB7 RID: 36023
			private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008CB8 RID: 36024
			private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x020009E7 RID: 2535
		[ObfuscatedName("ScheduleOne.PlayerScripts.PlayerCamera+<ILerpFOV>d__126")]
		public sealed class _ILerpFOV_d__126 : Il2CppSystem.Object
		{
			// Token: 0x0600D00A RID: 53258 RVA: 0x003263A0 File Offset: 0x003245A0
			// Note: this type is marked as 'beforefieldinit'.
			static _ILerpFOV_d__126()
			{
				Il2CppClassPointerStore<PlayerCamera._ILerpFOV_d__126>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, "<ILerpFOV>d__126");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayerCamera._ILerpFOV_d__126>.NativeClassPtr);
				PlayerCamera._ILerpFOV_d__126.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCamera._ILerpFOV_d__126>.NativeClassPtr, "<>1__state");
				PlayerCamera._ILerpFOV_d__126.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCamera._ILerpFOV_d__126>.NativeClassPtr, "<>2__current");
				PlayerCamera._ILerpFOV_d__126.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCamera._ILerpFOV_d__126>.NativeClassPtr, "<>4__this");
				PlayerCamera._ILerpFOV_d__126.NativeFieldInfoPtr_endFov = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCamera._ILerpFOV_d__126>.NativeClassPtr, "endFov");
				PlayerCamera._ILerpFOV_d__126.NativeFieldInfoPtr_lerpTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCamera._ILerpFOV_d__126>.NativeClassPtr, "lerpTime");
				PlayerCamera._ILerpFOV_d__126.NativeFieldInfoPtr__startFov_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCamera._ILerpFOV_d__126>.NativeClassPtr, "<startFov>5__2");
				PlayerCamera._ILerpFOV_d__126.NativeFieldInfoPtr__i_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCamera._ILerpFOV_d__126>.NativeClassPtr, "<i>5__3");
				PlayerCamera._ILerpFOV_d__126.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera._ILerpFOV_d__126>.NativeClassPtr, 100673571);
				PlayerCamera._ILerpFOV_d__126.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera._ILerpFOV_d__126>.NativeClassPtr, 100673572);
				PlayerCamera._ILerpFOV_d__126.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera._ILerpFOV_d__126>.NativeClassPtr, 100673573);
				PlayerCamera._ILerpFOV_d__126.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera._ILerpFOV_d__126>.NativeClassPtr, 100673574);
				PlayerCamera._ILerpFOV_d__126.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera._ILerpFOV_d__126>.NativeClassPtr, 100673575);
				PlayerCamera._ILerpFOV_d__126.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera._ILerpFOV_d__126>.NativeClassPtr, 100673576);
			}

			// Token: 0x0600D00B RID: 53259 RVA: 0x003264D0 File Offset: 0x003246D0
			[CallerCount(54)]
			[CachedScanResults(RefRangeStart = 2646, RefRangeEnd = 2700, XrefRangeStart = 2646, XrefRangeEnd = 2700, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _ILerpFOV_d__126(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayerCamera._ILerpFOV_d__126>.NativeClassPtr))
			{
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = ref <>1__state;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCamera._ILerpFOV_d__126.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600D00C RID: 53260 RVA: 0x00326518 File Offset: 0x00324718
			[CallerCount(14558)]
			[CachedScanResults(RefRangeStart = 2769, RefRangeEnd = 17327, XrefRangeStart = 2769, XrefRangeEnd = 17327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCamera._ILerpFOV_d__126.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600D00D RID: 53261 RVA: 0x0032654C File Offset: 0x0032474C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 176390, XrefRangeEnd = 176400, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(PlayerCamera._ILerpFOV_d__126.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x17004083 RID: 16515
			// (get) Token: 0x0600D00E RID: 53262 RVA: 0x00326588 File Offset: 0x00324788
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 2740, RefRangeEnd = 2764, XrefRangeStart = 2740, XrefRangeEnd = 2764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCamera._ILerpFOV_d__126.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
			}

			// Token: 0x0600D00F RID: 53263 RVA: 0x003265C8 File Offset: 0x003247C8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 176400, XrefRangeEnd = 176405, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCamera._ILerpFOV_d__126.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x17004084 RID: 16516
			// (get) Token: 0x0600D010 RID: 53264 RVA: 0x003265FC File Offset: 0x003247FC
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 2740, RefRangeEnd = 2764, XrefRangeStart = 2740, XrefRangeEnd = 2764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCamera._ILerpFOV_d__126.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
			}

			// Token: 0x0600D011 RID: 53265 RVA: 0x00064D7F File Offset: 0x00062F7F
			public _ILerpFOV_d__126(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700407C RID: 16508
			// (get) Token: 0x0600D012 RID: 53266 RVA: 0x0032663C File Offset: 0x0032483C
			// (set) Token: 0x0600D013 RID: 53267 RVA: 0x00064D88 File Offset: 0x00062F88
			public unsafe int __1__state
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera._ILerpFOV_d__126.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera._ILerpFOV_d__126.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700407D RID: 16509
			// (get) Token: 0x0600D014 RID: 53268 RVA: 0x00326664 File Offset: 0x00324864
			// (set) Token: 0x0600D015 RID: 53269 RVA: 0x00064DA3 File Offset: 0x00062FA3
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera._ILerpFOV_d__126.NativeFieldInfoPtr___2__current);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera._ILerpFOV_d__126.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700407E RID: 16510
			// (get) Token: 0x0600D016 RID: 53270 RVA: 0x00326694 File Offset: 0x00324894
			// (set) Token: 0x0600D017 RID: 53271 RVA: 0x00064DC2 File Offset: 0x00062FC2
			public unsafe PlayerCamera __4__this
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera._ILerpFOV_d__126.NativeFieldInfoPtr___4__this);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlayerCamera>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera._ILerpFOV_d__126.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700407F RID: 16511
			// (get) Token: 0x0600D018 RID: 53272 RVA: 0x003266C4 File Offset: 0x003248C4
			// (set) Token: 0x0600D019 RID: 53273 RVA: 0x00064DE1 File Offset: 0x00062FE1
			public unsafe float endFov
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera._ILerpFOV_d__126.NativeFieldInfoPtr_endFov);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera._ILerpFOV_d__126.NativeFieldInfoPtr_endFov)) = value;
				}
			}

			// Token: 0x17004080 RID: 16512
			// (get) Token: 0x0600D01A RID: 53274 RVA: 0x003266EC File Offset: 0x003248EC
			// (set) Token: 0x0600D01B RID: 53275 RVA: 0x00064DFC File Offset: 0x00062FFC
			public unsafe float lerpTime
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera._ILerpFOV_d__126.NativeFieldInfoPtr_lerpTime);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera._ILerpFOV_d__126.NativeFieldInfoPtr_lerpTime)) = value;
				}
			}

			// Token: 0x17004081 RID: 16513
			// (get) Token: 0x0600D01C RID: 53276 RVA: 0x00326714 File Offset: 0x00324914
			// (set) Token: 0x0600D01D RID: 53277 RVA: 0x00064E17 File Offset: 0x00063017
			public unsafe float _startFov_5__2
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera._ILerpFOV_d__126.NativeFieldInfoPtr__startFov_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera._ILerpFOV_d__126.NativeFieldInfoPtr__startFov_5__2)) = value;
				}
			}

			// Token: 0x17004082 RID: 16514
			// (get) Token: 0x0600D01E RID: 53278 RVA: 0x0032673C File Offset: 0x0032493C
			// (set) Token: 0x0600D01F RID: 53279 RVA: 0x00064E32 File Offset: 0x00063032
			public unsafe float _i_5__3
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera._ILerpFOV_d__126.NativeFieldInfoPtr__i_5__3);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera._ILerpFOV_d__126.NativeFieldInfoPtr__i_5__3)) = value;
				}
			}

			// Token: 0x04008CB9 RID: 36025
			private static readonly System.IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04008CBA RID: 36026
			private static readonly System.IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04008CBB RID: 36027
			private static readonly System.IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04008CBC RID: 36028
			private static readonly System.IntPtr NativeFieldInfoPtr_endFov;

			// Token: 0x04008CBD RID: 36029
			private static readonly System.IntPtr NativeFieldInfoPtr_lerpTime;

			// Token: 0x04008CBE RID: 36030
			private static readonly System.IntPtr NativeFieldInfoPtr__startFov_5__2;

			// Token: 0x04008CBF RID: 36031
			private static readonly System.IntPtr NativeFieldInfoPtr__i_5__3;

			// Token: 0x04008CC0 RID: 36032
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04008CC1 RID: 36033
			private static readonly System.IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008CC2 RID: 36034
			private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04008CC3 RID: 36035
			private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04008CC4 RID: 36036
			private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008CC5 RID: 36037
			private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x020009E8 RID: 2536
		[ObfuscatedName("ScheduleOne.PlayerScripts.PlayerCamera+<LerpDoF>d__123")]
		public sealed class _LerpDoF_d__123 : Il2CppSystem.Object
		{
			// Token: 0x0600D020 RID: 53280 RVA: 0x00326764 File Offset: 0x00324964
			// Note: this type is marked as 'beforefieldinit'.
			static _LerpDoF_d__123()
			{
				Il2CppClassPointerStore<PlayerCamera._LerpDoF_d__123>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PlayerCamera>.NativeClassPtr, "<LerpDoF>d__123");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayerCamera._LerpDoF_d__123>.NativeClassPtr);
				PlayerCamera._LerpDoF_d__123.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCamera._LerpDoF_d__123>.NativeClassPtr, "<>1__state");
				PlayerCamera._LerpDoF_d__123.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCamera._LerpDoF_d__123>.NativeClassPtr, "<>2__current");
				PlayerCamera._LerpDoF_d__123.NativeFieldInfoPtr_active = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCamera._LerpDoF_d__123>.NativeClassPtr, "active");
				PlayerCamera._LerpDoF_d__123.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCamera._LerpDoF_d__123>.NativeClassPtr, "<>4__this");
				PlayerCamera._LerpDoF_d__123.NativeFieldInfoPtr_lerpTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCamera._LerpDoF_d__123>.NativeClassPtr, "lerpTime");
				PlayerCamera._LerpDoF_d__123.NativeFieldInfoPtr__startFocusDist_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCamera._LerpDoF_d__123>.NativeClassPtr, "<startFocusDist>5__2");
				PlayerCamera._LerpDoF_d__123.NativeFieldInfoPtr__endFocusDist_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCamera._LerpDoF_d__123>.NativeClassPtr, "<endFocusDist>5__3");
				PlayerCamera._LerpDoF_d__123.NativeFieldInfoPtr__i_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCamera._LerpDoF_d__123>.NativeClassPtr, "<i>5__4");
				PlayerCamera._LerpDoF_d__123.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera._LerpDoF_d__123>.NativeClassPtr, 100673577);
				PlayerCamera._LerpDoF_d__123.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera._LerpDoF_d__123>.NativeClassPtr, 100673578);
				PlayerCamera._LerpDoF_d__123.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera._LerpDoF_d__123>.NativeClassPtr, 100673579);
				PlayerCamera._LerpDoF_d__123.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera._LerpDoF_d__123>.NativeClassPtr, 100673580);
				PlayerCamera._LerpDoF_d__123.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera._LerpDoF_d__123>.NativeClassPtr, 100673581);
				PlayerCamera._LerpDoF_d__123.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCamera._LerpDoF_d__123>.NativeClassPtr, 100673582);
			}

			// Token: 0x0600D021 RID: 53281 RVA: 0x003268A8 File Offset: 0x00324AA8
			[CallerCount(54)]
			[CachedScanResults(RefRangeStart = 2646, RefRangeEnd = 2700, XrefRangeStart = 2646, XrefRangeEnd = 2700, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _LerpDoF_d__123(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayerCamera._LerpDoF_d__123>.NativeClassPtr))
			{
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = ref <>1__state;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCamera._LerpDoF_d__123.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600D022 RID: 53282 RVA: 0x003268F0 File Offset: 0x00324AF0
			[CallerCount(14558)]
			[CachedScanResults(RefRangeStart = 2769, RefRangeEnd = 17327, XrefRangeStart = 2769, XrefRangeEnd = 17327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCamera._LerpDoF_d__123.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600D023 RID: 53283 RVA: 0x00326924 File Offset: 0x00324B24
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 176405, XrefRangeEnd = 176414, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(PlayerCamera._LerpDoF_d__123.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x1700408D RID: 16525
			// (get) Token: 0x0600D024 RID: 53284 RVA: 0x00326960 File Offset: 0x00324B60
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 2740, RefRangeEnd = 2764, XrefRangeStart = 2740, XrefRangeEnd = 2764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCamera._LerpDoF_d__123.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
			}

			// Token: 0x0600D025 RID: 53285 RVA: 0x003269A0 File Offset: 0x00324BA0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 176414, XrefRangeEnd = 176419, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCamera._LerpDoF_d__123.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x1700408E RID: 16526
			// (get) Token: 0x0600D026 RID: 53286 RVA: 0x003269D4 File Offset: 0x00324BD4
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 2740, RefRangeEnd = 2764, XrefRangeStart = 2740, XrefRangeEnd = 2764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCamera._LerpDoF_d__123.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
			}

			// Token: 0x0600D027 RID: 53287 RVA: 0x00064E4D File Offset: 0x0006304D
			public _LerpDoF_d__123(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004085 RID: 16517
			// (get) Token: 0x0600D028 RID: 53288 RVA: 0x00326A14 File Offset: 0x00324C14
			// (set) Token: 0x0600D029 RID: 53289 RVA: 0x00064E56 File Offset: 0x00063056
			public unsafe int __1__state
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera._LerpDoF_d__123.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera._LerpDoF_d__123.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17004086 RID: 16518
			// (get) Token: 0x0600D02A RID: 53290 RVA: 0x00326A3C File Offset: 0x00324C3C
			// (set) Token: 0x0600D02B RID: 53291 RVA: 0x00064E71 File Offset: 0x00063071
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera._LerpDoF_d__123.NativeFieldInfoPtr___2__current);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera._LerpDoF_d__123.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004087 RID: 16519
			// (get) Token: 0x0600D02C RID: 53292 RVA: 0x00326A6C File Offset: 0x00324C6C
			// (set) Token: 0x0600D02D RID: 53293 RVA: 0x00064E90 File Offset: 0x00063090
			public unsafe bool active
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera._LerpDoF_d__123.NativeFieldInfoPtr_active);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera._LerpDoF_d__123.NativeFieldInfoPtr_active)) = value;
				}
			}

			// Token: 0x17004088 RID: 16520
			// (get) Token: 0x0600D02E RID: 53294 RVA: 0x00326A94 File Offset: 0x00324C94
			// (set) Token: 0x0600D02F RID: 53295 RVA: 0x00064EAB File Offset: 0x000630AB
			public unsafe PlayerCamera __4__this
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera._LerpDoF_d__123.NativeFieldInfoPtr___4__this);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlayerCamera>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera._LerpDoF_d__123.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004089 RID: 16521
			// (get) Token: 0x0600D030 RID: 53296 RVA: 0x00326AC4 File Offset: 0x00324CC4
			// (set) Token: 0x0600D031 RID: 53297 RVA: 0x00064ECA File Offset: 0x000630CA
			public unsafe float lerpTime
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera._LerpDoF_d__123.NativeFieldInfoPtr_lerpTime);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera._LerpDoF_d__123.NativeFieldInfoPtr_lerpTime)) = value;
				}
			}

			// Token: 0x1700408A RID: 16522
			// (get) Token: 0x0600D032 RID: 53298 RVA: 0x00326AEC File Offset: 0x00324CEC
			// (set) Token: 0x0600D033 RID: 53299 RVA: 0x00064EE5 File Offset: 0x000630E5
			public unsafe float _startFocusDist_5__2
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera._LerpDoF_d__123.NativeFieldInfoPtr__startFocusDist_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera._LerpDoF_d__123.NativeFieldInfoPtr__startFocusDist_5__2)) = value;
				}
			}

			// Token: 0x1700408B RID: 16523
			// (get) Token: 0x0600D034 RID: 53300 RVA: 0x00326B14 File Offset: 0x00324D14
			// (set) Token: 0x0600D035 RID: 53301 RVA: 0x00064F00 File Offset: 0x00063100
			public unsafe float _endFocusDist_5__3
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera._LerpDoF_d__123.NativeFieldInfoPtr__endFocusDist_5__3);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera._LerpDoF_d__123.NativeFieldInfoPtr__endFocusDist_5__3)) = value;
				}
			}

			// Token: 0x1700408C RID: 16524
			// (get) Token: 0x0600D036 RID: 53302 RVA: 0x00326B3C File Offset: 0x00324D3C
			// (set) Token: 0x0600D037 RID: 53303 RVA: 0x00064F1B File Offset: 0x0006311B
			public unsafe float _i_5__4
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera._LerpDoF_d__123.NativeFieldInfoPtr__i_5__4);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCamera._LerpDoF_d__123.NativeFieldInfoPtr__i_5__4)) = value;
				}
			}

			// Token: 0x04008CC6 RID: 36038
			private static readonly System.IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04008CC7 RID: 36039
			private static readonly System.IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04008CC8 RID: 36040
			private static readonly System.IntPtr NativeFieldInfoPtr_active;

			// Token: 0x04008CC9 RID: 36041
			private static readonly System.IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04008CCA RID: 36042
			private static readonly System.IntPtr NativeFieldInfoPtr_lerpTime;

			// Token: 0x04008CCB RID: 36043
			private static readonly System.IntPtr NativeFieldInfoPtr__startFocusDist_5__2;

			// Token: 0x04008CCC RID: 36044
			private static readonly System.IntPtr NativeFieldInfoPtr__endFocusDist_5__3;

			// Token: 0x04008CCD RID: 36045
			private static readonly System.IntPtr NativeFieldInfoPtr__i_5__4;

			// Token: 0x04008CCE RID: 36046
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04008CCF RID: 36047
			private static readonly System.IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008CD0 RID: 36048
			private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04008CD1 RID: 36049
			private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04008CD2 RID: 36050
			private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008CD3 RID: 36051
			private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
