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
using Il2CppScheduleOne.Audio;
using Il2CppScheduleOne.AvatarFramework;
using Il2CppScheduleOne.AvatarFramework.Animation;
using Il2CppScheduleOne.AvatarFramework.Customization;
using Il2CppScheduleOne.Combat;
using Il2CppScheduleOne.DevUtilities;
using Il2CppScheduleOne.ItemFramework;
using Il2CppScheduleOne.Map;
using Il2CppScheduleOne.Money;
using Il2CppScheduleOne.Persistence.Datas;
using Il2CppScheduleOne.Persistence.Loaders;
using Il2CppScheduleOne.PlayerScripts.Health;
using Il2CppScheduleOne.Product;
using Il2CppScheduleOne.Property;
using Il2CppScheduleOne.Skating;
using Il2CppScheduleOne.Stealth;
using Il2CppScheduleOne.Tools;
using Il2CppScheduleOne.UI;
using Il2CppScheduleOne.Variables;
using Il2CppScheduleOne.Vehicles;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;
using UnityEngine;
using UnityEngine.Events;

namespace Il2CppScheduleOne.PlayerScripts
{
	// Token: 0x02000402 RID: 1026
	public class Player : NetworkBehaviour
	{
		// Token: 0x06004E41 RID: 20033 RVA: 0x00178EA4 File Offset: 0x001770A4
		// Note: this type is marked as 'beforefieldinit'.
		static Player()
		{
			Il2CppClassPointerStore<Player>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.PlayerScripts", "Player");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Player>.NativeClassPtr);
			Player.NativeFieldInfoPtr_OWNER_PLAYER_CODE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player>.NativeClassPtr, "OWNER_PLAYER_CODE");
			Player.NativeFieldInfoPtr_CapColDefaultHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player>.NativeClassPtr, "CapColDefaultHeight");
			Player.NativeFieldInfoPtr_objectsTemporarilyOwnedByPlayer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player>.NativeClassPtr, "objectsTemporarilyOwnedByPlayer");
			Player.NativeFieldInfoPtr_onLocalPlayerSpawned = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player>.NativeClassPtr, "onLocalPlayerSpawned");
			Player.NativeFieldInfoPtr_onPlayerSpawned = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player>.NativeClassPtr, "onPlayerSpawned");
			Player.NativeFieldInfoPtr_onPlayerDespawned = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player>.NativeClassPtr, "onPlayerDespawned");
			Player.NativeFieldInfoPtr_Local = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player>.NativeClassPtr, "Local");
			Player.NativeFieldInfoPtr_PlayerList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player>.NativeClassPtr, "PlayerList");
			Player.NativeFieldInfoPtr_LocalGameObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player>.NativeClassPtr, "LocalGameObject");
			Player.NativeFieldInfoPtr_Avatar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player>.NativeClassPtr, "Avatar");
			Player.NativeFieldInfoPtr_Anim = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player>.NativeClassPtr, "Anim");
			Player.NativeFieldInfoPtr_VelocityCalculator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player>.NativeClassPtr, "VelocityCalculator");
			Player.NativeFieldInfoPtr_EyePosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player>.NativeClassPtr, "EyePosition");
			Player.NativeFieldInfoPtr_TestAvatarSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player>.NativeClassPtr, "TestAvatarSettings");
			Player.NativeFieldInfoPtr_VisualState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player>.NativeClassPtr, "VisualState");
			Player.NativeFieldInfoPtr_Visibility = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player>.NativeClassPtr, "Visibility");
			Player.NativeFieldInfoPtr_CapCol = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player>.NativeClassPtr, "CapCol");
			Player.NativeFieldInfoPtr_PoI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player>.NativeClassPtr, "PoI");
			Player.NativeFieldInfoPtr_Health = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player>.NativeClassPtr, "Health");
			Player.NativeFieldInfoPtr_CrimeData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player>.NativeClassPtr, "CrimeData");
			Player.NativeFieldInfoPtr_Energy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player>.NativeClassPtr, "Energy");
			Player.NativeFieldInfoPtr_MimicCamera = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player>.NativeClassPtr, "MimicCamera");
			Player.NativeFieldInfoPtr_FootstepDetector = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player>.NativeClassPtr, "FootstepDetector");
			Player.NativeFieldInfoPtr_LocalFootstepDetector = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player>.NativeClassPtr, "LocalFootstepDetector");
			Player.NativeFieldInfoPtr_CharacterController = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player>.NativeClassPtr, "CharacterController");
			Player.NativeFieldInfoPtr_PunchSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player>.NativeClassPtr, "PunchSound");
			Player.NativeFieldInfoPtr_ThirdPersonFlashlight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player>.NativeClassPtr, "ThirdPersonFlashlight");
			Player.NativeFieldInfoPtr_NameLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player>.NativeClassPtr, "NameLabel");
			Player.NativeFieldInfoPtr_Clothing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player>.NativeClassPtr, "Clothing");
			Player.NativeFieldInfoPtr_GroundDetectionMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player>.NativeClassPtr, "GroundDetectionMask");
			Player.NativeFieldInfoPtr_AvatarOffset_Standing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player>.NativeClassPtr, "AvatarOffset_Standing");
			Player.NativeFieldInfoPtr_AvatarOffset_Crouched = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player>.NativeClassPtr, "AvatarOffset_Crouched");
			Player.NativeFieldInfoPtr_WalkingMapCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player>.NativeClassPtr, "WalkingMapCurve");
			Player.NativeFieldInfoPtr_CrouchWalkMapCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player>.NativeClassPtr, "CrouchWalkMapCurve");
			Player.NativeFieldInfoPtr__PlayerName_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player>.NativeClassPtr, "<PlayerName>k__BackingField");
			Player.NativeFieldInfoPtr_Connection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player>.NativeClassPtr, "Connection");
			Player.NativeFieldInfoPtr__PlayerCode_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player>.NativeClassPtr, "<PlayerCode>k__BackingField");
			Player.NativeFieldInfoPtr__CurrentVehicle_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player>.NativeClassPtr, "<CurrentVehicle>k__BackingField");
			Player.NativeFieldInfoPtr_onEnterVehicle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player>.NativeClassPtr, "onEnterVehicle");
			Player.NativeFieldInfoPtr_onExitVehicle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player>.NativeClassPtr, "onExitVehicle");
			Player.NativeFieldInfoPtr_LastDrivenVehicle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player>.NativeClassPtr, "LastDrivenVehicle");
			Player.NativeFieldInfoPtr__TimeSinceVehicleExit_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player>.NativeClassPtr, "<TimeSinceVehicleExit>k__BackingField");
			Player.NativeFieldInfoPtr__Crouched_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player>.NativeClassPtr, "<Crouched>k__BackingField");
			Player.NativeFieldInfoPtr__CurrentBed_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player>.NativeClassPtr, "<CurrentBed>k__BackingField");
			Player.NativeFieldInfoPtr__IsReadyToSleep_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player>.NativeClassPtr, "<IsReadyToSleep>k__BackingField");
			Player.NativeFieldInfoPtr__IsSkating_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player>.NativeClassPtr, "<IsSkating>k__BackingField");
			Player.NativeFieldInfoPtr__ActiveSkateboard_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player>.NativeClassPtr, "<ActiveSkateboard>k__BackingField");
			Player.NativeFieldInfoPtr_onSkateboardMounted = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player>.NativeClassPtr, "onSkateboardMounted");
			Player.NativeFieldInfoPtr_onSkateboardDismounted = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player>.NativeClassPtr, "onSkateboardDismounted");
			Player.NativeFieldInfoPtr__IsSleeping_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player>.NativeClassPtr, "<IsSleeping>k__BackingField");
			Player.NativeFieldInfoPtr__IsRagdolled_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player>.NativeClassPtr, "<IsRagdolled>k__BackingField");
			Player.NativeFieldInfoPtr__IsArrested_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player>.NativeClassPtr, "<IsArrested>k__BackingField");
			Player.NativeFieldInfoPtr__IsTased_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player>.NativeClassPtr, "<IsTased>k__BackingField");
			Player.NativeFieldInfoPtr__IsUnconscious_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player>.NativeClassPtr, "<IsUnconscious>k__BackingField");
			Player.NativeFieldInfoPtr__Scale_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player>.NativeClassPtr, "<Scale>k__BackingField");
			Player.NativeFieldInfoPtr__CurrentProperty_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player>.NativeClassPtr, "<CurrentProperty>k__BackingField");
			Player.NativeFieldInfoPtr__LastVisitedProperty_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player>.NativeClassPtr, "<LastVisitedProperty>k__BackingField");
			Player.NativeFieldInfoPtr__CurrentBusiness_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player>.NativeClassPtr, "<CurrentBusiness>k__BackingField");
			Player.NativeFieldInfoPtr_HasCompletedIntro = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player>.NativeClassPtr, "HasCompletedIntro");
			Player.NativeFieldInfoPtr__CameraPosition_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player>.NativeClassPtr, "<CameraPosition>k__BackingField");
			Player.NativeFieldInfoPtr__CameraRotation_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player>.NativeClassPtr, "<CameraRotation>k__BackingField");
			Player.NativeFieldInfoPtr_Inventory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player>.NativeClassPtr, "Inventory");
			Player.NativeFieldInfoPtr__CurrentAvatarSettings_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player>.NativeClassPtr, "<CurrentAvatarSettings>k__BackingField");
			Player.NativeFieldInfoPtr__ConsumedProduct_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player>.NativeClassPtr, "<ConsumedProduct>k__BackingField");
			Player.NativeFieldInfoPtr__TimeSinceProductConsumed_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player>.NativeClassPtr, "<TimeSinceProductConsumed>k__BackingField");
			Player.NativeFieldInfoPtr_DebugAvatarSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player>.NativeClassPtr, "DebugAvatarSettings");
			Player.NativeFieldInfoPtr_loader = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player>.NativeClassPtr, "loader");
			Player.NativeFieldInfoPtr__LocalExtraFiles_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player>.NativeClassPtr, "<LocalExtraFiles>k__BackingField");
			Player.NativeFieldInfoPtr__LocalExtraFolders_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player>.NativeClassPtr, "<LocalExtraFolders>k__BackingField");
			Player.NativeFieldInfoPtr__HasChanged_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player>.NativeClassPtr, "<HasChanged>k__BackingField");
			Player.NativeFieldInfoPtr_onRagdoll = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player>.NativeClassPtr, "onRagdoll");
			Player.NativeFieldInfoPtr_onRagdollEnd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player>.NativeClassPtr, "onRagdollEnd");
			Player.NativeFieldInfoPtr_onArrested = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player>.NativeClassPtr, "onArrested");
			Player.NativeFieldInfoPtr_onFreed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player>.NativeClassPtr, "onFreed");
			Player.NativeFieldInfoPtr_onTased = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player>.NativeClassPtr, "onTased");
			Player.NativeFieldInfoPtr_onTasedEnd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player>.NativeClassPtr, "onTasedEnd");
			Player.NativeFieldInfoPtr_onPassedOut = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player>.NativeClassPtr, "onPassedOut");
			Player.NativeFieldInfoPtr_onPassOutRecovery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player>.NativeClassPtr, "onPassOutRecovery");
			Player.NativeFieldInfoPtr_PlayerVariables = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player>.NativeClassPtr, "PlayerVariables");
			Player.NativeFieldInfoPtr_VariableDict = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player>.NativeClassPtr, "VariableDict");
			Player.NativeFieldInfoPtr_standingScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player>.NativeClassPtr, "standingScale");
			Player.NativeFieldInfoPtr_timeAirborne = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player>.NativeClassPtr, "timeAirborne");
			Player.NativeFieldInfoPtr__avatarVisibleToLocalPlayer_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player>.NativeClassPtr, "<avatarVisibleToLocalPlayer>k__BackingField");
			Player.NativeFieldInfoPtr__playerDataRetrieveReturned_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player>.NativeClassPtr, "<playerDataRetrieveReturned>k__BackingField");
			Player.NativeFieldInfoPtr_taseCoroutine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player>.NativeClassPtr, "taseCoroutine");
			Player.NativeFieldInfoPtr_ragdollForceComponents = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player>.NativeClassPtr, "ragdollForceComponents");
			Player.NativeFieldInfoPtr__playerSaveRequestReturned_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player>.NativeClassPtr, "<playerSaveRequestReturned>k__BackingField");
			Player.NativeFieldInfoPtr__PlayerInitializedOverNetwork_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player>.NativeClassPtr, "<PlayerInitializedOverNetwork>k__BackingField");
			Player.NativeFieldInfoPtr_impactHistory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player>.NativeClassPtr, "impactHistory");
			Player.NativeFieldInfoPtr__Paranoid_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player>.NativeClassPtr, "<Paranoid>k__BackingField");
			Player.NativeFieldInfoPtr__Sneaky_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player>.NativeClassPtr, "<Sneaky>k__BackingField");
			Player.NativeFieldInfoPtr__Disoriented_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player>.NativeClassPtr, "<Disoriented>k__BackingField");
			Player.NativeFieldInfoPtr__Seizure_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player>.NativeClassPtr, "<Seizure>k__BackingField");
			Player.NativeFieldInfoPtr_seizureRotations = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player>.NativeClassPtr, "seizureRotations");
			Player.NativeFieldInfoPtr__Slippery_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player>.NativeClassPtr, "<Slippery>k__BackingField");
			Player.NativeFieldInfoPtr__Schizophrenic_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player>.NativeClassPtr, "<Schizophrenic>k__BackingField");
			Player.NativeFieldInfoPtr_equippableMessageIDHistory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player>.NativeClassPtr, "equippableMessageIDHistory");
			Player.NativeFieldInfoPtr_lerpScaleRoutine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player>.NativeClassPtr, "lerpScaleRoutine");
			Player.NativeFieldInfoPtr_syncVar____PlayerName_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player>.NativeClassPtr, "syncVar___<PlayerName>k__BackingField");
			Player.NativeFieldInfoPtr_syncVar____PlayerCode_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player>.NativeClassPtr, "syncVar___<PlayerCode>k__BackingField");
			Player.NativeFieldInfoPtr_syncVar____CurrentVehicle_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player>.NativeClassPtr, "syncVar___<CurrentVehicle>k__BackingField");
			Player.NativeFieldInfoPtr_syncVar____CurrentBed_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player>.NativeClassPtr, "syncVar___<CurrentBed>k__BackingField");
			Player.NativeFieldInfoPtr_syncVar____IsReadyToSleep_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player>.NativeClassPtr, "syncVar___<IsReadyToSleep>k__BackingField");
			Player.NativeFieldInfoPtr_syncVar____CameraPosition_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player>.NativeClassPtr, "syncVar___<CameraPosition>k__BackingField");
			Player.NativeFieldInfoPtr_syncVar____CameraRotation_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player>.NativeClassPtr, "syncVar___<CameraRotation>k__BackingField");
			Player.NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player>.NativeClassPtr, "NetworkInitialize___EarlyScheduleOne.PlayerScripts.PlayerAssembly-CSharp.dll_Excuted");
			Player.NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player>.NativeClassPtr, "NetworkInitialize__LateScheduleOne.PlayerScripts.PlayerAssembly-CSharp.dll_Excuted");
			Player.NativeMethodInfoPtr_get_IsLocalPlayer_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673031);
			Player.NativeMethodInfoPtr_get_PlayerName_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673032);
			Player.NativeMethodInfoPtr_set_PlayerName_Protected_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673033);
			Player.NativeMethodInfoPtr_get_PlayerCode_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673034);
			Player.NativeMethodInfoPtr_set_PlayerCode_Protected_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673035);
			Player.NativeMethodInfoPtr_get_CurrentVehicle_Public_get_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673036);
			Player.NativeMethodInfoPtr_set_CurrentVehicle_Public_set_Void_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673037);
			Player.NativeMethodInfoPtr_get_TimeSinceVehicleExit_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673038);
			Player.NativeMethodInfoPtr_set_TimeSinceVehicleExit_Protected_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673039);
			Player.NativeMethodInfoPtr_get_Crouched_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673040);
			Player.NativeMethodInfoPtr_set_Crouched_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673041);
			Player.NativeMethodInfoPtr_get_CurrentBed_Public_get_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673042);
			Player.NativeMethodInfoPtr_set_CurrentBed_Public_set_Void_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673043);
			Player.NativeMethodInfoPtr_get_IsReadyToSleep_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673044);
			Player.NativeMethodInfoPtr_set_IsReadyToSleep_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673045);
			Player.NativeMethodInfoPtr_get_IsSkating_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673046);
			Player.NativeMethodInfoPtr_set_IsSkating_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673047);
			Player.NativeMethodInfoPtr_get_ActiveSkateboard_Public_get_Skateboard_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673048);
			Player.NativeMethodInfoPtr_set_ActiveSkateboard_Private_set_Void_Skateboard_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673049);
			Player.NativeMethodInfoPtr_get_IsSleeping_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673050);
			Player.NativeMethodInfoPtr_set_IsSleeping_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673051);
			Player.NativeMethodInfoPtr_get_IsRagdolled_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673052);
			Player.NativeMethodInfoPtr_set_IsRagdolled_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673053);
			Player.NativeMethodInfoPtr_get_IsArrested_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673054);
			Player.NativeMethodInfoPtr_set_IsArrested_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673055);
			Player.NativeMethodInfoPtr_get_IsTased_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673056);
			Player.NativeMethodInfoPtr_set_IsTased_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673057);
			Player.NativeMethodInfoPtr_get_IsUnconscious_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673058);
			Player.NativeMethodInfoPtr_set_IsUnconscious_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673059);
			Player.NativeMethodInfoPtr_get_Scale_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673060);
			Player.NativeMethodInfoPtr_set_Scale_Private_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673061);
			Player.NativeMethodInfoPtr_get_CurrentProperty_Public_get_Property_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673062);
			Player.NativeMethodInfoPtr_set_CurrentProperty_Protected_set_Void_Property_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673063);
			Player.NativeMethodInfoPtr_get_LastVisitedProperty_Public_get_Property_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673064);
			Player.NativeMethodInfoPtr_set_LastVisitedProperty_Protected_set_Void_Property_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673065);
			Player.NativeMethodInfoPtr_get_CurrentBusiness_Public_get_Business_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673066);
			Player.NativeMethodInfoPtr_set_CurrentBusiness_Protected_set_Void_Business_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673067);
			Player.NativeMethodInfoPtr_get_PlayerBasePosition_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673068);
			Player.NativeMethodInfoPtr_get_CameraPosition_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673069);
			Player.NativeMethodInfoPtr_set_CameraPosition_Public_set_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673070);
			Player.NativeMethodInfoPtr_get_CameraRotation_Public_get_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673071);
			Player.NativeMethodInfoPtr_set_CameraRotation_Public_set_Void_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673072);
			Player.NativeMethodInfoPtr_get_CurrentAvatarSettings_Public_get_BasicAvatarSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673073);
			Player.NativeMethodInfoPtr_set_CurrentAvatarSettings_Protected_set_Void_BasicAvatarSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673074);
			Player.NativeMethodInfoPtr_get_ConsumedProduct_Public_get_ProductItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673075);
			Player.NativeMethodInfoPtr_set_ConsumedProduct_Private_set_Void_ProductItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673076);
			Player.NativeMethodInfoPtr_get_TimeSinceProductConsumed_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673077);
			Player.NativeMethodInfoPtr_set_TimeSinceProductConsumed_Private_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673078);
			Player.NativeMethodInfoPtr_LoadDebugAvatarSettings_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673079);
			Player.NativeMethodInfoPtr_get_SaveFolderName_Public_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673080);
			Player.NativeMethodInfoPtr_get_SaveFileName_Public_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673081);
			Player.NativeMethodInfoPtr_get_Loader_Public_Virtual_Final_New_get_Loader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673082);
			Player.NativeMethodInfoPtr_get_ShouldSaveUnderFolder_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673083);
			Player.NativeMethodInfoPtr_get_LocalExtraFiles_Public_Virtual_Final_New_get_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673084);
			Player.NativeMethodInfoPtr_set_LocalExtraFiles_Public_Virtual_Final_New_set_Void_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673085);
			Player.NativeMethodInfoPtr_get_LocalExtraFolders_Public_Virtual_Final_New_get_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673086);
			Player.NativeMethodInfoPtr_set_LocalExtraFolders_Public_Virtual_Final_New_set_Void_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673087);
			Player.NativeMethodInfoPtr_get_HasChanged_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673088);
			Player.NativeMethodInfoPtr_set_HasChanged_Public_Virtual_Final_New_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673089);
			Player.NativeMethodInfoPtr_get_avatarVisibleToLocalPlayer_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673090);
			Player.NativeMethodInfoPtr_set_avatarVisibleToLocalPlayer_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673091);
			Player.NativeMethodInfoPtr_get_playerDataRetrieveReturned_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673092);
			Player.NativeMethodInfoPtr_set_playerDataRetrieveReturned_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673093);
			Player.NativeMethodInfoPtr_get_playerSaveRequestReturned_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673094);
			Player.NativeMethodInfoPtr_set_playerSaveRequestReturned_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673095);
			Player.NativeMethodInfoPtr_get_PlayerInitializedOverNetwork_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673096);
			Player.NativeMethodInfoPtr_set_PlayerInitializedOverNetwork_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673097);
			Player.NativeMethodInfoPtr_get_Paranoid_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673098);
			Player.NativeMethodInfoPtr_set_Paranoid_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673099);
			Player.NativeMethodInfoPtr_get_Sneaky_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673100);
			Player.NativeMethodInfoPtr_set_Sneaky_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673101);
			Player.NativeMethodInfoPtr_get_Disoriented_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673102);
			Player.NativeMethodInfoPtr_set_Disoriented_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673103);
			Player.NativeMethodInfoPtr_get_Seizure_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673104);
			Player.NativeMethodInfoPtr_set_Seizure_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673105);
			Player.NativeMethodInfoPtr_get_Slippery_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673106);
			Player.NativeMethodInfoPtr_set_Slippery_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673107);
			Player.NativeMethodInfoPtr_get_Schizophrenic_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673108);
			Player.NativeMethodInfoPtr_set_Schizophrenic_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673109);
			Player.NativeMethodInfoPtr_GetPlayer_Public_Static_Player_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673110);
			Player.NativeMethodInfoPtr_GetRandomPlayer_Public_Static_Player_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673111);
			Player.NativeMethodInfoPtr_GetPlayer_Public_Static_Player_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673112);
			Player.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673113);
			Player.NativeMethodInfoPtr_InitializeSaveable_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673114);
			Player.NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673115);
			Player.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_New_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673116);
			Player.NativeMethodInfoPtr_OnStartClient_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673117);
			Player.NativeMethodInfoPtr_PlayerLoaded_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673118);
			Player.NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673119);
			Player.NativeMethodInfoPtr_RequestSavePlayer_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673120);
			Player.NativeMethodInfoPtr_ReturnSaveRequest_Private_Void_NetworkConnection_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673121);
			Player.NativeMethodInfoPtr_HostExitedGame_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673122);
			Player.NativeMethodInfoPtr_ClientConnectionStateChanged_Private_Void_ClientConnectionStateArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673123);
			Player.NativeMethodInfoPtr_SendPlayerNameData_Public_Void_String_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673124);
			Player.NativeMethodInfoPtr_RequestPlayerData_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673125);
			Player.NativeMethodInfoPtr_MarkPlayerInitialized_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673126);
			Player.NativeMethodInfoPtr_ReceivePlayerData_Public_Void_NetworkConnection_PlayerData_String_String_String_Il2CppReferenceArray_1_VariableData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673127);
			Player.NativeMethodInfoPtr_SetGravityMultiplier_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673128);
			Player.NativeMethodInfoPtr_ReceivePlayerNameData_Private_Void_NetworkConnection_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673129);
			Player.NativeMethodInfoPtr_SendFlashlightOn_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673130);
			Player.NativeMethodInfoPtr_SendFlashlightOnNetworked_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673131);
			Player.NativeMethodInfoPtr_SetFlashlightOn_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673132);
			Player.NativeMethodInfoPtr_OnStopClient_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673133);
			Player.NativeMethodInfoPtr_OnStartServer_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673134);
			Player.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673135);
			Player.NativeMethodInfoPtr_MinPass_Protected_Virtual_New_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673136);
			Player.NativeMethodInfoPtr_Tick_Protected_Virtual_New_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673137);
			Player.NativeMethodInfoPtr_LateUpdate_Protected_Virtual_New_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673138);
			Player.NativeMethodInfoPtr_RecalculateCurrentProperty_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673139);
			Player.NativeMethodInfoPtr_FixedUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673140);
			Player.NativeMethodInfoPtr_ApplyMovementVisuals_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673141);
			Player.NativeMethodInfoPtr_SetVisible_Public_Void_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673142);
			Player.NativeMethodInfoPtr_PlayJumpAnimation_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673143);
			Player.NativeMethodInfoPtr_GetIsGrounded_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673144);
			Player.NativeMethodInfoPtr_SendCrouched_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673145);
			Player.NativeMethodInfoPtr_SetCrouchedLocal_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673146);
			Player.NativeMethodInfoPtr_ReceiveCrouched_Private_Void_NetworkConnection_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673147);
			Player.NativeMethodInfoPtr_SendAvatarSettings_Public_Void_AvatarSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673148);
			Player.NativeMethodInfoPtr_SetAvatarSettings_Public_Void_AvatarSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673149);
			Player.NativeMethodInfoPtr_SetVisible_Networked_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673150);
			Player.NativeMethodInfoPtr_EnterVehicle_Public_Void_LandVehicle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673151);
			Player.NativeMethodInfoPtr_ExitVehicle_Public_Void_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673152);
			Player.NativeMethodInfoPtr_PreDestroyClientObjects_Private_Void_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673153);
			Player.NativeMethodInfoPtr_CurrentVehicleChanged_Private_Void_NetworkObject_NetworkObject_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673154);
			Player.NativeMethodInfoPtr_AreAllPlayersReadyToSleep_Public_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673155);
			Player.NativeMethodInfoPtr_SleepStart_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673156);
			Player.NativeMethodInfoPtr_SetReadyToSleep_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673157);
			Player.NativeMethodInfoPtr_SleepEnd_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673158);
			Player.NativeMethodInfoPtr_Activate_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673159);
			Player.NativeMethodInfoPtr_Deactivate_Public_Static_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673160);
			Player.NativeMethodInfoPtr_ExitAll_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673161);
			Player.NativeMethodInfoPtr_SetVisibleToLocalPlayer_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673162);
			Player.NativeMethodInfoPtr_SetPlayerCode_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673163);
			Player.NativeMethodInfoPtr_SendPunch_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673164);
			Player.NativeMethodInfoPtr_Punch_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673165);
			Player.NativeMethodInfoPtr_MarkIntroCompleted_Private_Void_BasicAvatarSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673166);
			Player.NativeMethodInfoPtr_IsPointVisibleToPlayer_Public_Boolean_Vector3_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673167);
			Player.NativeMethodInfoPtr_GetClosestPlayer_Public_Static_Player_Vector3_byref_Single_List_1_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673168);
			Player.NativeMethodInfoPtr_SetCapsuleColliderHeight_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673169);
			Player.NativeMethodInfoPtr_SetScale_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673170);
			Player.NativeMethodInfoPtr_SetScale_Public_Void_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673171);
			Player.NativeMethodInfoPtr_ApplyScale_Protected_Virtual_New_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673172);
			Player.NativeMethodInfoPtr_GetSaveString_Public_Virtual_New_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673173);
			Player.NativeMethodInfoPtr_GetPlayerData_Public_PlayerData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673174);
			Player.NativeMethodInfoPtr_WriteData_Public_Virtual_New_List_1_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673175);
			Player.NativeMethodInfoPtr_GetInventoryString_Public_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673176);
			Player.NativeMethodInfoPtr_GetAppearanceString_Public_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673177);
			Player.NativeMethodInfoPtr_GetClothingString_Public_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673178);
			Player.NativeMethodInfoPtr_GetVariablesString_Public_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673179);
			Player.NativeMethodInfoPtr_Load_Public_Virtual_New_Void_PlayerData_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673180);
			Player.NativeMethodInfoPtr_Load_Public_Virtual_New_Void_PlayerData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673181);
			Player.NativeMethodInfoPtr_LoadInventory_Public_Virtual_New_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673182);
			Player.NativeMethodInfoPtr_LoadAppearance_Public_Virtual_New_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673183);
			Player.NativeMethodInfoPtr_LoadClothing_Public_Virtual_New_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673184);
			Player.NativeMethodInfoPtr_SetRagdolled_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673185);
			Player.NativeMethodInfoPtr_SendImpact_Public_Virtual_New_Void_Impact_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673186);
			Player.NativeMethodInfoPtr_ReceiveImpact_Public_Virtual_New_Void_Impact_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673187);
			Player.NativeMethodInfoPtr_ProcessImpactForce_Public_Virtual_New_Void_Vector3_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673188);
			Player.NativeMethodInfoPtr_OnDied_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673189);
			Player.NativeMethodInfoPtr_OnRevived_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673190);
			Player.NativeMethodInfoPtr_Arrest_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673191);
			Player.NativeMethodInfoPtr_Free_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673192);
			Player.NativeMethodInfoPtr_SendPassOut_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673193);
			Player.NativeMethodInfoPtr_PassOut_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673194);
			Player.NativeMethodInfoPtr_SendPassOutRecovery_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673195);
			Player.NativeMethodInfoPtr_PassOutRecovery_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673196);
			Player.NativeMethodInfoPtr_SendEquippable_Networked_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673197);
			Player.NativeMethodInfoPtr_SetEquippable_Networked_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673198);
			Player.NativeMethodInfoPtr_SendEquippableMessage_Networked_Public_Void_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673199);
			Player.NativeMethodInfoPtr_ReceiveEquippableMessage_Networked_Private_Void_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673200);
			Player.NativeMethodInfoPtr_SendEquippableMessage_Networked_Vector_Public_Void_String_Int32_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673201);
			Player.NativeMethodInfoPtr_ReceiveEquippableMessage_Networked_Vector_Private_Void_String_Int32_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673202);
			Player.NativeMethodInfoPtr_SendAnimationTrigger_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673203);
			Player.NativeMethodInfoPtr_SetAnimationTrigger_Networked_Public_Void_NetworkConnection_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673204);
			Player.NativeMethodInfoPtr_SetAnimationTrigger_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673205);
			Player.NativeMethodInfoPtr_ResetAnimationTrigger_Networked_Public_Void_NetworkConnection_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673206);
			Player.NativeMethodInfoPtr_ResetAnimationTrigger_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673207);
			Player.NativeMethodInfoPtr_SendAnimationBool_Public_Void_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673208);
			Player.NativeMethodInfoPtr_SetAnimationBool_Public_Void_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673209);
			Player.NativeMethodInfoPtr_Taze_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673210);
			Player.NativeMethodInfoPtr_SetInventoryItem_Public_Void_Int32_ItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673211);
			Player.NativeMethodInfoPtr_GetNetworth_Private_Void_FloatContainer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673212);
			Player.NativeMethodInfoPtr_SendAppearance_Public_Void_BasicAvatarSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673213);
			Player.NativeMethodInfoPtr_SetAppearance_Public_Void_BasicAvatarSettings_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673214);
			Player.NativeMethodInfoPtr_MountSkateboard_Public_Void_Skateboard_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673215);
			Player.NativeMethodInfoPtr_SendMountedSkateboard_Private_Void_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673216);
			Player.NativeMethodInfoPtr_SetMountedSkateboard_Private_Void_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673217);
			Player.NativeMethodInfoPtr_DismountSkateboard_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673218);
			Player.NativeMethodInfoPtr_ConsumeProduct_Public_Void_ProductItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673219);
			Player.NativeMethodInfoPtr_SendConsumeProduct_Private_Void_ProductItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673220);
			Player.NativeMethodInfoPtr_ReceiveConsumeProduct_Private_Void_ProductItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673221);
			Player.NativeMethodInfoPtr_ConsumeProductInternal_Private_Void_ProductItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673222);
			Player.NativeMethodInfoPtr_ClearProduct_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673223);
			Player.NativeMethodInfoPtr_CreatePlayerVariables_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673224);
			Player.NativeMethodInfoPtr_GetVariable_Public_BaseVariable_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673225);
			Player.NativeMethodInfoPtr_GetValue_Public_T_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673226);
			Player.NativeMethodInfoPtr_SetVariableValue_Public_Void_String_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673227);
			Player.NativeMethodInfoPtr_AddVariable_Public_Void_BaseVariable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673228);
			Player.NativeMethodInfoPtr_SendValue_Public_Void_String_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673229);
			Player.NativeMethodInfoPtr_ReceiveValue_Private_Void_NetworkConnection_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673230);
			Player.NativeMethodInfoPtr_ReceiveValue_Private_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673231);
			Player.NativeMethodInfoPtr_LoadVariable_Public_Void_VariableData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673232);
			Player.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673233);
			Player.NativeMethodInfoPtr__RecalculateCurrentProperty_b__249_0_Private_Single_Property_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673235);
			Player.NativeMethodInfoPtr__RecalculateCurrentProperty_b__249_1_Private_Single_Business_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673236);
			Player.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673237);
			Player.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673238);
			Player.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673239);
			Player.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673240);
			Player.NativeMethodInfoPtr_RpcWriter___Server_set_CurrentVehicle_3323014238_Private_Void_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673241);
			Player.NativeMethodInfoPtr_RpcLogic___set_CurrentVehicle_3323014238_Public_Void_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673242);
			Player.NativeMethodInfoPtr_RpcReader___Server_set_CurrentVehicle_3323014238_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673243);
			Player.NativeMethodInfoPtr_RpcWriter___Server_set_CurrentBed_3323014238_Private_Void_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673244);
			Player.NativeMethodInfoPtr_RpcLogic___set_CurrentBed_3323014238_Public_Void_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673245);
			Player.NativeMethodInfoPtr_RpcReader___Server_set_CurrentBed_3323014238_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673246);
			Player.NativeMethodInfoPtr_RpcWriter___Server_set_IsSkating_1140765316_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673247);
			Player.NativeMethodInfoPtr_RpcLogic___set_IsSkating_1140765316_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673248);
			Player.NativeMethodInfoPtr_RpcReader___Server_set_IsSkating_1140765316_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673249);
			Player.NativeMethodInfoPtr_RpcWriter___Server_set_CameraPosition_4276783012_Private_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673250);
			Player.NativeMethodInfoPtr_RpcLogic___set_CameraPosition_4276783012_Public_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673251);
			Player.NativeMethodInfoPtr_RpcReader___Server_set_CameraPosition_4276783012_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673252);
			Player.NativeMethodInfoPtr_RpcWriter___Server_set_CameraRotation_3429297120_Private_Void_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673253);
			Player.NativeMethodInfoPtr_RpcLogic___set_CameraRotation_3429297120_Public_Void_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673254);
			Player.NativeMethodInfoPtr_RpcReader___Server_set_CameraRotation_3429297120_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673255);
			Player.NativeMethodInfoPtr_RpcWriter___Server_RequestSavePlayer_2166136261_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673256);
			Player.NativeMethodInfoPtr_RpcLogic___RequestSavePlayer_2166136261_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673257);
			Player.NativeMethodInfoPtr_RpcReader___Server_RequestSavePlayer_2166136261_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673258);
			Player.NativeMethodInfoPtr_RpcWriter___Observers_ReturnSaveRequest_214505783_Private_Void_NetworkConnection_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673259);
			Player.NativeMethodInfoPtr_RpcLogic___ReturnSaveRequest_214505783_Private_Void_NetworkConnection_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673260);
			Player.NativeMethodInfoPtr_RpcReader___Observers_ReturnSaveRequest_214505783_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673261);
			Player.NativeMethodInfoPtr_RpcWriter___Target_ReturnSaveRequest_214505783_Private_Void_NetworkConnection_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673262);
			Player.NativeMethodInfoPtr_RpcReader___Target_ReturnSaveRequest_214505783_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673263);
			Player.NativeMethodInfoPtr_RpcWriter___Observers_HostExitedGame_2166136261_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673264);
			Player.NativeMethodInfoPtr_RpcLogic___HostExitedGame_2166136261_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673265);
			Player.NativeMethodInfoPtr_RpcReader___Observers_HostExitedGame_2166136261_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673266);
			Player.NativeMethodInfoPtr_RpcWriter___Server_SendPlayerNameData_586648380_Private_Void_String_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673267);
			Player.NativeMethodInfoPtr_RpcLogic___SendPlayerNameData_586648380_Public_Void_String_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673268);
			Player.NativeMethodInfoPtr_RpcReader___Server_SendPlayerNameData_586648380_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673269);
			Player.NativeMethodInfoPtr_RpcWriter___Server_RequestPlayerData_3615296227_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673270);
			Player.NativeMethodInfoPtr_RpcLogic___RequestPlayerData_3615296227_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673271);
			Player.NativeMethodInfoPtr_RpcReader___Server_RequestPlayerData_3615296227_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673272);
			Player.NativeMethodInfoPtr_RpcWriter___Server_MarkPlayerInitialized_2166136261_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673273);
			Player.NativeMethodInfoPtr_RpcLogic___MarkPlayerInitialized_2166136261_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673274);
			Player.NativeMethodInfoPtr_RpcReader___Server_MarkPlayerInitialized_2166136261_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673275);
			Player.NativeMethodInfoPtr_RpcWriter___Observers_ReceivePlayerData_3244732873_Private_Void_NetworkConnection_PlayerData_String_String_String_Il2CppReferenceArray_1_VariableData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673276);
			Player.NativeMethodInfoPtr_RpcLogic___ReceivePlayerData_3244732873_Public_Void_NetworkConnection_PlayerData_String_String_String_Il2CppReferenceArray_1_VariableData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673277);
			Player.NativeMethodInfoPtr_RpcReader___Observers_ReceivePlayerData_3244732873_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673278);
			Player.NativeMethodInfoPtr_RpcWriter___Target_ReceivePlayerData_3244732873_Private_Void_NetworkConnection_PlayerData_String_String_String_Il2CppReferenceArray_1_VariableData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673279);
			Player.NativeMethodInfoPtr_RpcReader___Target_ReceivePlayerData_3244732873_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673280);
			Player.NativeMethodInfoPtr_RpcWriter___Observers_ReceivePlayerNameData_3895153758_Private_Void_NetworkConnection_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673281);
			Player.NativeMethodInfoPtr_RpcLogic___ReceivePlayerNameData_3895153758_Private_Void_NetworkConnection_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673282);
			Player.NativeMethodInfoPtr_RpcReader___Observers_ReceivePlayerNameData_3895153758_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673283);
			Player.NativeMethodInfoPtr_RpcWriter___Target_ReceivePlayerNameData_3895153758_Private_Void_NetworkConnection_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673284);
			Player.NativeMethodInfoPtr_RpcReader___Target_ReceivePlayerNameData_3895153758_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673285);
			Player.NativeMethodInfoPtr_RpcWriter___Server_SendFlashlightOnNetworked_1140765316_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673286);
			Player.NativeMethodInfoPtr_RpcLogic___SendFlashlightOnNetworked_1140765316_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673287);
			Player.NativeMethodInfoPtr_RpcReader___Server_SendFlashlightOnNetworked_1140765316_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673288);
			Player.NativeMethodInfoPtr_RpcWriter___Observers_SetFlashlightOn_1140765316_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673289);
			Player.NativeMethodInfoPtr_RpcLogic___SetFlashlightOn_1140765316_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673290);
			Player.NativeMethodInfoPtr_RpcReader___Observers_SetFlashlightOn_1140765316_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673291);
			Player.NativeMethodInfoPtr_RpcWriter___Observers_PlayJumpAnimation_2166136261_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673292);
			Player.NativeMethodInfoPtr_RpcLogic___PlayJumpAnimation_2166136261_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673293);
			Player.NativeMethodInfoPtr_RpcReader___Observers_PlayJumpAnimation_2166136261_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673294);
			Player.NativeMethodInfoPtr_RpcWriter___Server_SendCrouched_1140765316_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673295);
			Player.NativeMethodInfoPtr_RpcLogic___SendCrouched_1140765316_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673296);
			Player.NativeMethodInfoPtr_RpcReader___Server_SendCrouched_1140765316_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673297);
			Player.NativeMethodInfoPtr_RpcWriter___Target_ReceiveCrouched_214505783_Private_Void_NetworkConnection_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673298);
			Player.NativeMethodInfoPtr_RpcLogic___ReceiveCrouched_214505783_Private_Void_NetworkConnection_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673299);
			Player.NativeMethodInfoPtr_RpcReader___Target_ReceiveCrouched_214505783_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673300);
			Player.NativeMethodInfoPtr_RpcWriter___Observers_ReceiveCrouched_214505783_Private_Void_NetworkConnection_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673301);
			Player.NativeMethodInfoPtr_RpcReader___Observers_ReceiveCrouched_214505783_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673302);
			Player.NativeMethodInfoPtr_RpcWriter___Server_SendAvatarSettings_4281687581_Private_Void_AvatarSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673303);
			Player.NativeMethodInfoPtr_RpcLogic___SendAvatarSettings_4281687581_Public_Void_AvatarSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673304);
			Player.NativeMethodInfoPtr_RpcReader___Server_SendAvatarSettings_4281687581_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673305);
			Player.NativeMethodInfoPtr_RpcWriter___Observers_SetAvatarSettings_4281687581_Private_Void_AvatarSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673306);
			Player.NativeMethodInfoPtr_RpcLogic___SetAvatarSettings_4281687581_Public_Void_AvatarSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673307);
			Player.NativeMethodInfoPtr_RpcReader___Observers_SetAvatarSettings_4281687581_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673308);
			Player.NativeMethodInfoPtr_RpcWriter___Observers_SetVisible_Networked_1140765316_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673309);
			Player.NativeMethodInfoPtr_RpcLogic___SetVisible_Networked_1140765316_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673310);
			Player.NativeMethodInfoPtr_RpcReader___Observers_SetVisible_Networked_1140765316_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673311);
			Player.NativeMethodInfoPtr_RpcWriter___Server_SetReadyToSleep_1140765316_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673312);
			Player.NativeMethodInfoPtr_RpcLogic___SetReadyToSleep_1140765316_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673313);
			Player.NativeMethodInfoPtr_RpcReader___Server_SetReadyToSleep_1140765316_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673314);
			Player.NativeMethodInfoPtr_RpcWriter___Observers_SetPlayerCode_3615296227_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673315);
			Player.NativeMethodInfoPtr_RpcLogic___SetPlayerCode_3615296227_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673316);
			Player.NativeMethodInfoPtr_RpcReader___Observers_SetPlayerCode_3615296227_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673317);
			Player.NativeMethodInfoPtr_RpcWriter___Server_SendPunch_2166136261_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673318);
			Player.NativeMethodInfoPtr_RpcLogic___SendPunch_2166136261_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673319);
			Player.NativeMethodInfoPtr_RpcReader___Server_SendPunch_2166136261_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673320);
			Player.NativeMethodInfoPtr_RpcWriter___Observers_Punch_2166136261_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673321);
			Player.NativeMethodInfoPtr_RpcLogic___Punch_2166136261_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673322);
			Player.NativeMethodInfoPtr_RpcReader___Observers_Punch_2166136261_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673323);
			Player.NativeMethodInfoPtr_RpcWriter___Server_MarkIntroCompleted_3281254764_Private_Void_BasicAvatarSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673324);
			Player.NativeMethodInfoPtr_RpcLogic___MarkIntroCompleted_3281254764_Private_Void_BasicAvatarSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673325);
			Player.NativeMethodInfoPtr_RpcReader___Server_MarkIntroCompleted_3281254764_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673326);
			Player.NativeMethodInfoPtr_RpcWriter___Server_SendImpact_427288424_Private_Void_Impact_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673327);
			Player.NativeMethodInfoPtr_RpcLogic___SendImpact_427288424_Public_Virtual_New_Void_Impact_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673328);
			Player.NativeMethodInfoPtr_RpcReader___Server_SendImpact_427288424_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673329);
			Player.NativeMethodInfoPtr_RpcWriter___Observers_ReceiveImpact_427288424_Private_Void_Impact_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673330);
			Player.NativeMethodInfoPtr_RpcLogic___ReceiveImpact_427288424_Public_Virtual_New_Void_Impact_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673331);
			Player.NativeMethodInfoPtr_RpcReader___Observers_ReceiveImpact_427288424_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673332);
			Player.NativeMethodInfoPtr_RpcWriter___Observers_Arrest_2166136261_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673333);
			Player.NativeMethodInfoPtr_RpcLogic___Arrest_2166136261_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673334);
			Player.NativeMethodInfoPtr_RpcReader___Observers_Arrest_2166136261_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673335);
			Player.NativeMethodInfoPtr_RpcWriter___Server_SendPassOut_2166136261_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673336);
			Player.NativeMethodInfoPtr_RpcLogic___SendPassOut_2166136261_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673337);
			Player.NativeMethodInfoPtr_RpcReader___Server_SendPassOut_2166136261_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673338);
			Player.NativeMethodInfoPtr_RpcWriter___Observers_PassOut_2166136261_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673339);
			Player.NativeMethodInfoPtr_RpcLogic___PassOut_2166136261_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673340);
			Player.NativeMethodInfoPtr_RpcReader___Observers_PassOut_2166136261_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673341);
			Player.NativeMethodInfoPtr_RpcWriter___Server_SendPassOutRecovery_2166136261_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673342);
			Player.NativeMethodInfoPtr_RpcLogic___SendPassOutRecovery_2166136261_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673343);
			Player.NativeMethodInfoPtr_RpcReader___Server_SendPassOutRecovery_2166136261_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673344);
			Player.NativeMethodInfoPtr_RpcWriter___Observers_PassOutRecovery_2166136261_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673345);
			Player.NativeMethodInfoPtr_RpcLogic___PassOutRecovery_2166136261_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673346);
			Player.NativeMethodInfoPtr_RpcReader___Observers_PassOutRecovery_2166136261_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673347);
			Player.NativeMethodInfoPtr_RpcWriter___Server_SendEquippable_Networked_3615296227_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673348);
			Player.NativeMethodInfoPtr_RpcLogic___SendEquippable_Networked_3615296227_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673349);
			Player.NativeMethodInfoPtr_RpcReader___Server_SendEquippable_Networked_3615296227_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673350);
			Player.NativeMethodInfoPtr_RpcWriter___Observers_SetEquippable_Networked_3615296227_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673351);
			Player.NativeMethodInfoPtr_RpcLogic___SetEquippable_Networked_3615296227_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673352);
			Player.NativeMethodInfoPtr_RpcReader___Observers_SetEquippable_Networked_3615296227_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673353);
			Player.NativeMethodInfoPtr_RpcWriter___Server_SendEquippableMessage_Networked_3643459082_Private_Void_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673354);
			Player.NativeMethodInfoPtr_RpcLogic___SendEquippableMessage_Networked_3643459082_Public_Void_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673355);
			Player.NativeMethodInfoPtr_RpcReader___Server_SendEquippableMessage_Networked_3643459082_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673356);
			Player.NativeMethodInfoPtr_RpcWriter___Observers_ReceiveEquippableMessage_Networked_3643459082_Private_Void_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673357);
			Player.NativeMethodInfoPtr_RpcLogic___ReceiveEquippableMessage_Networked_3643459082_Private_Void_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673358);
			Player.NativeMethodInfoPtr_RpcReader___Observers_ReceiveEquippableMessage_Networked_3643459082_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673359);
			Player.NativeMethodInfoPtr_RpcWriter___Server_SendEquippableMessage_Networked_Vector_3190074053_Private_Void_String_Int32_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673360);
			Player.NativeMethodInfoPtr_RpcLogic___SendEquippableMessage_Networked_Vector_3190074053_Public_Void_String_Int32_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673361);
			Player.NativeMethodInfoPtr_RpcReader___Server_SendEquippableMessage_Networked_Vector_3190074053_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673362);
			Player.NativeMethodInfoPtr_RpcWriter___Observers_ReceiveEquippableMessage_Networked_Vector_3190074053_Private_Void_String_Int32_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673363);
			Player.NativeMethodInfoPtr_RpcLogic___ReceiveEquippableMessage_Networked_Vector_3190074053_Private_Void_String_Int32_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673364);
			Player.NativeMethodInfoPtr_RpcReader___Observers_ReceiveEquippableMessage_Networked_Vector_3190074053_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673365);
			Player.NativeMethodInfoPtr_RpcWriter___Server_SendAnimationTrigger_3615296227_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673366);
			Player.NativeMethodInfoPtr_RpcLogic___SendAnimationTrigger_3615296227_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673367);
			Player.NativeMethodInfoPtr_RpcReader___Server_SendAnimationTrigger_3615296227_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673368);
			Player.NativeMethodInfoPtr_RpcWriter___Observers_SetAnimationTrigger_Networked_2971853958_Private_Void_NetworkConnection_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673369);
			Player.NativeMethodInfoPtr_RpcLogic___SetAnimationTrigger_Networked_2971853958_Public_Void_NetworkConnection_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673370);
			Player.NativeMethodInfoPtr_RpcReader___Observers_SetAnimationTrigger_Networked_2971853958_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673371);
			Player.NativeMethodInfoPtr_RpcWriter___Target_SetAnimationTrigger_Networked_2971853958_Private_Void_NetworkConnection_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673372);
			Player.NativeMethodInfoPtr_RpcReader___Target_SetAnimationTrigger_Networked_2971853958_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673373);
			Player.NativeMethodInfoPtr_RpcWriter___Observers_ResetAnimationTrigger_Networked_2971853958_Private_Void_NetworkConnection_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673374);
			Player.NativeMethodInfoPtr_RpcLogic___ResetAnimationTrigger_Networked_2971853958_Public_Void_NetworkConnection_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673375);
			Player.NativeMethodInfoPtr_RpcReader___Observers_ResetAnimationTrigger_Networked_2971853958_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673376);
			Player.NativeMethodInfoPtr_RpcWriter___Target_ResetAnimationTrigger_Networked_2971853958_Private_Void_NetworkConnection_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673377);
			Player.NativeMethodInfoPtr_RpcReader___Target_ResetAnimationTrigger_Networked_2971853958_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673378);
			Player.NativeMethodInfoPtr_RpcWriter___Server_SendAnimationBool_310431262_Private_Void_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673379);
			Player.NativeMethodInfoPtr_RpcLogic___SendAnimationBool_310431262_Public_Void_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673380);
			Player.NativeMethodInfoPtr_RpcReader___Server_SendAnimationBool_310431262_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673381);
			Player.NativeMethodInfoPtr_RpcWriter___Observers_SetAnimationBool_310431262_Private_Void_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673382);
			Player.NativeMethodInfoPtr_RpcLogic___SetAnimationBool_310431262_Public_Void_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673383);
			Player.NativeMethodInfoPtr_RpcReader___Observers_SetAnimationBool_310431262_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673384);
			Player.NativeMethodInfoPtr_RpcWriter___Observers_Taze_2166136261_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673385);
			Player.NativeMethodInfoPtr_RpcLogic___Taze_2166136261_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673386);
			Player.NativeMethodInfoPtr_RpcReader___Observers_Taze_2166136261_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673387);
			Player.NativeMethodInfoPtr_RpcWriter___Server_SetInventoryItem_2317364410_Private_Void_Int32_ItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673388);
			Player.NativeMethodInfoPtr_RpcLogic___SetInventoryItem_2317364410_Public_Void_Int32_ItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673389);
			Player.NativeMethodInfoPtr_RpcReader___Server_SetInventoryItem_2317364410_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673390);
			Player.NativeMethodInfoPtr_RpcWriter___Server_SendAppearance_3281254764_Private_Void_BasicAvatarSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673391);
			Player.NativeMethodInfoPtr_RpcLogic___SendAppearance_3281254764_Public_Void_BasicAvatarSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673392);
			Player.NativeMethodInfoPtr_RpcReader___Server_SendAppearance_3281254764_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673393);
			Player.NativeMethodInfoPtr_RpcWriter___Observers_SetAppearance_2139595489_Private_Void_BasicAvatarSettings_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673394);
			Player.NativeMethodInfoPtr_RpcLogic___SetAppearance_2139595489_Public_Void_BasicAvatarSettings_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673395);
			Player.NativeMethodInfoPtr_RpcReader___Observers_SetAppearance_2139595489_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673396);
			Player.NativeMethodInfoPtr_RpcWriter___Server_SendMountedSkateboard_3323014238_Private_Void_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673397);
			Player.NativeMethodInfoPtr_RpcLogic___SendMountedSkateboard_3323014238_Private_Void_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673398);
			Player.NativeMethodInfoPtr_RpcReader___Server_SendMountedSkateboard_3323014238_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673399);
			Player.NativeMethodInfoPtr_RpcWriter___Observers_SetMountedSkateboard_3323014238_Private_Void_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673400);
			Player.NativeMethodInfoPtr_RpcLogic___SetMountedSkateboard_3323014238_Private_Void_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673401);
			Player.NativeMethodInfoPtr_RpcReader___Observers_SetMountedSkateboard_3323014238_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673402);
			Player.NativeMethodInfoPtr_RpcWriter___Server_SendConsumeProduct_2622925554_Private_Void_ProductItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673403);
			Player.NativeMethodInfoPtr_RpcLogic___SendConsumeProduct_2622925554_Private_Void_ProductItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673404);
			Player.NativeMethodInfoPtr_RpcReader___Server_SendConsumeProduct_2622925554_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673405);
			Player.NativeMethodInfoPtr_RpcWriter___Observers_ReceiveConsumeProduct_2622925554_Private_Void_ProductItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673406);
			Player.NativeMethodInfoPtr_RpcLogic___ReceiveConsumeProduct_2622925554_Private_Void_ProductItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673407);
			Player.NativeMethodInfoPtr_RpcReader___Observers_ReceiveConsumeProduct_2622925554_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673408);
			Player.NativeMethodInfoPtr_RpcWriter___Server_SendValue_3589193952_Private_Void_String_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673409);
			Player.NativeMethodInfoPtr_RpcLogic___SendValue_3589193952_Public_Void_String_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673410);
			Player.NativeMethodInfoPtr_RpcReader___Server_SendValue_3589193952_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673411);
			Player.NativeMethodInfoPtr_RpcWriter___Target_ReceiveValue_3895153758_Private_Void_NetworkConnection_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673412);
			Player.NativeMethodInfoPtr_RpcLogic___ReceiveValue_3895153758_Private_Void_NetworkConnection_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673413);
			Player.NativeMethodInfoPtr_RpcReader___Target_ReceiveValue_3895153758_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673414);
			Player.NativeMethodInfoPtr_sync___get_value__PlayerName_k__BackingField_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673415);
			Player.NativeMethodInfoPtr_sync___set_value__PlayerName_k__BackingField_Public_set_Void_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673416);
			Player.NativeMethodInfoPtr_ReadSyncVar___ScheduleOne_PlayerScripts_Player_Public_Virtual_Boolean_PooledReader_UInt32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673417);
			Player.NativeMethodInfoPtr_sync___get_value__PlayerCode_k__BackingField_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673418);
			Player.NativeMethodInfoPtr_sync___set_value__PlayerCode_k__BackingField_Public_set_Void_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673419);
			Player.NativeMethodInfoPtr_sync___get_value__CurrentVehicle_k__BackingField_Public_get_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673420);
			Player.NativeMethodInfoPtr_sync___set_value__CurrentVehicle_k__BackingField_Public_set_Void_NetworkObject_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673421);
			Player.NativeMethodInfoPtr_sync___get_value__CurrentBed_k__BackingField_Public_get_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673422);
			Player.NativeMethodInfoPtr_sync___set_value__CurrentBed_k__BackingField_Public_set_Void_NetworkObject_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673423);
			Player.NativeMethodInfoPtr_sync___get_value__IsReadyToSleep_k__BackingField_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673424);
			Player.NativeMethodInfoPtr_sync___set_value__IsReadyToSleep_k__BackingField_Public_set_Void_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673425);
			Player.NativeMethodInfoPtr_sync___get_value__CameraPosition_k__BackingField_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673426);
			Player.NativeMethodInfoPtr_sync___set_value__CameraPosition_k__BackingField_Public_set_Void_Vector3_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673427);
			Player.NativeMethodInfoPtr_sync___get_value__CameraRotation_k__BackingField_Public_get_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673428);
			Player.NativeMethodInfoPtr_sync___set_value__CameraRotation_k__BackingField_Public_set_Void_Quaternion_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673429);
			Player.NativeMethodInfoPtr_Method_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100673430);
		}

		// Token: 0x170017C7 RID: 6087
		// (get) Token: 0x06004E42 RID: 20034 RVA: 0x0017B65C File Offset: 0x0017985C
		public unsafe bool IsLocalPlayer
		{
			[CallerCount(13)]
			[CachedScanResults(RefRangeStart = 171031, RefRangeEnd = 171044, XrefRangeStart = 171030, XrefRangeEnd = 171031, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_get_IsLocalPlayer_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
		}

		// Token: 0x170017C8 RID: 6088
		// (get) Token: 0x06004E43 RID: 20035 RVA: 0x0017B698 File Offset: 0x00179898
		// (set) Token: 0x06004E44 RID: 20036 RVA: 0x0017B6D0 File Offset: 0x001798D0
		public unsafe string PlayerName
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 171044, RefRangeEnd = 171059, XrefRangeStart = 171044, XrefRangeEnd = 171044, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_get_PlayerName_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return IL2CPP.Il2CppStringToManaged(il2CppString);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 171067, RefRangeEnd = 171069, XrefRangeStart = 171059, XrefRangeEnd = 171067, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_set_PlayerName_Protected_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x170017C9 RID: 6089
		// (get) Token: 0x06004E45 RID: 20037 RVA: 0x0017B714 File Offset: 0x00179914
		// (set) Token: 0x06004E46 RID: 20038 RVA: 0x0017B74C File Offset: 0x0017994C
		public unsafe string PlayerCode
		{
			[CallerCount(9)]
			[CachedScanResults(RefRangeStart = 171069, RefRangeEnd = 171078, XrefRangeStart = 171069, XrefRangeEnd = 171069, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_get_PlayerCode_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return IL2CPP.Il2CppStringToManaged(il2CppString);
			}
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 171086, RefRangeEnd = 171090, XrefRangeStart = 171078, XrefRangeEnd = 171086, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_set_PlayerCode_Protected_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x170017CA RID: 6090
		// (get) Token: 0x06004E47 RID: 20039 RVA: 0x0017B790 File Offset: 0x00179990
		// (set) Token: 0x06004E48 RID: 20040 RVA: 0x0017B7D0 File Offset: 0x001799D0
		public unsafe NetworkObject CurrentVehicle
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 171090, RefRangeEnd = 171104, XrefRangeStart = 171090, XrefRangeEnd = 171090, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_get_CurrentVehicle_Public_get_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NetworkObject>(intPtr2) : null;
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 171137, RefRangeEnd = 171140, XrefRangeStart = 171104, XrefRangeEnd = 171137, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_set_CurrentVehicle_Public_set_Void_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x170017CB RID: 6091
		// (get) Token: 0x06004E49 RID: 20041 RVA: 0x0017B814 File Offset: 0x00179A14
		// (set) Token: 0x06004E4A RID: 20042 RVA: 0x0017B850 File Offset: 0x00179A50
		public unsafe float TimeSinceVehicleExit
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_get_TimeSinceVehicleExit_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
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
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_set_TimeSinceVehicleExit_Protected_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x170017CC RID: 6092
		// (get) Token: 0x06004E4B RID: 20043 RVA: 0x0017B890 File Offset: 0x00179A90
		// (set) Token: 0x06004E4C RID: 20044 RVA: 0x0017B8CC File Offset: 0x00179ACC
		public unsafe bool Crouched
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_get_Crouched_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 171140, RefRangeEnd = 171141, XrefRangeStart = 171140, XrefRangeEnd = 171140, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = ref value;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_set_Crouched_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x170017CD RID: 6093
		// (get) Token: 0x06004E4D RID: 20045 RVA: 0x0017B90C File Offset: 0x00179B0C
		// (set) Token: 0x06004E4E RID: 20046 RVA: 0x0017B94C File Offset: 0x00179B4C
		public unsafe NetworkObject CurrentBed
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_get_CurrentBed_Public_get_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NetworkObject>(intPtr2) : null;
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 171153, RefRangeEnd = 171155, XrefRangeStart = 171141, XrefRangeEnd = 171153, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_set_CurrentBed_Public_set_Void_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x170017CE RID: 6094
		// (get) Token: 0x06004E4F RID: 20047 RVA: 0x0017B990 File Offset: 0x00179B90
		// (set) Token: 0x06004E50 RID: 20048 RVA: 0x0017B9CC File Offset: 0x00179BCC
		public unsafe bool IsReadyToSleep
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 171155, RefRangeEnd = 171158, XrefRangeStart = 171155, XrefRangeEnd = 171155, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_get_IsReadyToSleep_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 171165, RefRangeEnd = 171167, XrefRangeStart = 171158, XrefRangeEnd = 171165, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = ref value;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_set_IsReadyToSleep_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x170017CF RID: 6095
		// (get) Token: 0x06004E51 RID: 20049 RVA: 0x0017BA0C File Offset: 0x00179C0C
		// (set) Token: 0x06004E52 RID: 20050 RVA: 0x0017BA48 File Offset: 0x00179C48
		public unsafe bool IsSkating
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_get_IsSkating_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 171179, RefRangeEnd = 171180, XrefRangeStart = 171167, XrefRangeEnd = 171179, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = ref value;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_set_IsSkating_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x170017D0 RID: 6096
		// (get) Token: 0x06004E53 RID: 20051 RVA: 0x0017BA88 File Offset: 0x00179C88
		// (set) Token: 0x06004E54 RID: 20052 RVA: 0x0017BAC8 File Offset: 0x00179CC8
		public unsafe Skateboard ActiveSkateboard
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_get_ActiveSkateboard_Public_get_Skateboard_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Skateboard>(intPtr2) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_set_ActiveSkateboard_Private_set_Void_Skateboard_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x170017D1 RID: 6097
		// (get) Token: 0x06004E55 RID: 20053 RVA: 0x0017BB0C File Offset: 0x00179D0C
		// (set) Token: 0x06004E56 RID: 20054 RVA: 0x0017BB48 File Offset: 0x00179D48
		public unsafe bool IsSleeping
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_get_IsSleeping_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
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
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_set_IsSleeping_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x170017D2 RID: 6098
		// (get) Token: 0x06004E57 RID: 20055 RVA: 0x0017BB88 File Offset: 0x00179D88
		// (set) Token: 0x06004E58 RID: 20056 RVA: 0x0017BBC4 File Offset: 0x00179DC4
		public unsafe bool IsRagdolled
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_get_IsRagdolled_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
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
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_set_IsRagdolled_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x170017D3 RID: 6099
		// (get) Token: 0x06004E59 RID: 20057 RVA: 0x0017BC04 File Offset: 0x00179E04
		// (set) Token: 0x06004E5A RID: 20058 RVA: 0x0017BC40 File Offset: 0x00179E40
		public unsafe bool IsArrested
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_get_IsArrested_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
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
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_set_IsArrested_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x170017D4 RID: 6100
		// (get) Token: 0x06004E5B RID: 20059 RVA: 0x0017BC80 File Offset: 0x00179E80
		// (set) Token: 0x06004E5C RID: 20060 RVA: 0x0017BCBC File Offset: 0x00179EBC
		public unsafe bool IsTased
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_get_IsTased_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
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
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_set_IsTased_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x170017D5 RID: 6101
		// (get) Token: 0x06004E5D RID: 20061 RVA: 0x0017BCFC File Offset: 0x00179EFC
		// (set) Token: 0x06004E5E RID: 20062 RVA: 0x0017BD38 File Offset: 0x00179F38
		public unsafe bool IsUnconscious
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_get_IsUnconscious_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
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
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_set_IsUnconscious_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x170017D6 RID: 6102
		// (get) Token: 0x06004E5F RID: 20063 RVA: 0x0017BD78 File Offset: 0x00179F78
		// (set) Token: 0x06004E60 RID: 20064 RVA: 0x0017BDB4 File Offset: 0x00179FB4
		public unsafe float Scale
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_get_Scale_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
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
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_set_Scale_Private_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x170017D7 RID: 6103
		// (get) Token: 0x06004E61 RID: 20065 RVA: 0x0017BDF4 File Offset: 0x00179FF4
		// (set) Token: 0x06004E62 RID: 20066 RVA: 0x0017BE34 File Offset: 0x0017A034
		public unsafe Property CurrentProperty
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_get_CurrentProperty_Public_get_Property_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Property>(intPtr2) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 171180, XrefRangeEnd = 171181, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_set_CurrentProperty_Protected_set_Void_Property_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x170017D8 RID: 6104
		// (get) Token: 0x06004E63 RID: 20067 RVA: 0x0017BE78 File Offset: 0x0017A078
		// (set) Token: 0x06004E64 RID: 20068 RVA: 0x0017BEB8 File Offset: 0x0017A0B8
		public unsafe Property LastVisitedProperty
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 171181, RefRangeEnd = 171182, XrefRangeStart = 171181, XrefRangeEnd = 171181, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_get_LastVisitedProperty_Public_get_Property_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Property>(intPtr2) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 171182, XrefRangeEnd = 171183, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_set_LastVisitedProperty_Protected_set_Void_Property_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x170017D9 RID: 6105
		// (get) Token: 0x06004E65 RID: 20069 RVA: 0x0017BEFC File Offset: 0x0017A0FC
		// (set) Token: 0x06004E66 RID: 20070 RVA: 0x0017BF3C File Offset: 0x0017A13C
		public unsafe Business CurrentBusiness
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 171183, RefRangeEnd = 171190, XrefRangeStart = 171183, XrefRangeEnd = 171183, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_get_CurrentBusiness_Public_get_Business_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Business>(intPtr2) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 171190, XrefRangeEnd = 171191, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_set_CurrentBusiness_Protected_set_Void_Business_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x170017DA RID: 6106
		// (get) Token: 0x06004E67 RID: 20071 RVA: 0x0017BF80 File Offset: 0x0017A180
		public unsafe Vector3 PlayerBasePosition
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 171196, RefRangeEnd = 171198, XrefRangeStart = 171191, XrefRangeEnd = 171196, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_get_PlayerBasePosition_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
		}

		// Token: 0x170017DB RID: 6107
		// (get) Token: 0x06004E68 RID: 20072 RVA: 0x0017BFBC File Offset: 0x0017A1BC
		// (set) Token: 0x06004E69 RID: 20073 RVA: 0x0017BFF8 File Offset: 0x0017A1F8
		public unsafe Vector3 CameraPosition
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_get_CameraPosition_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 171198, XrefRangeEnd = 171199, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = ref value;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_set_CameraPosition_Public_set_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x170017DC RID: 6108
		// (get) Token: 0x06004E6A RID: 20074 RVA: 0x0017C038 File Offset: 0x0017A238
		// (set) Token: 0x06004E6B RID: 20075 RVA: 0x0017C074 File Offset: 0x0017A274
		public unsafe Quaternion CameraRotation
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_get_CameraRotation_Public_get_Quaternion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 171199, XrefRangeEnd = 171211, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = ref value;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_set_CameraRotation_Public_set_Void_Quaternion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x170017DD RID: 6109
		// (get) Token: 0x06004E6C RID: 20076 RVA: 0x0017C0B4 File Offset: 0x0017A2B4
		// (set) Token: 0x06004E6D RID: 20077 RVA: 0x0017C0F4 File Offset: 0x0017A2F4
		public unsafe BasicAvatarSettings CurrentAvatarSettings
		{
			[CallerCount(12)]
			[CachedScanResults(RefRangeStart = 171211, RefRangeEnd = 171223, XrefRangeStart = 171211, XrefRangeEnd = 171211, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_get_CurrentAvatarSettings_Public_get_BasicAvatarSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BasicAvatarSettings>(intPtr2) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 171223, XrefRangeEnd = 171224, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_set_CurrentAvatarSettings_Protected_set_Void_BasicAvatarSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x170017DE RID: 6110
		// (get) Token: 0x06004E6E RID: 20078 RVA: 0x0017C138 File Offset: 0x0017A338
		// (set) Token: 0x06004E6F RID: 20079 RVA: 0x0017C178 File Offset: 0x0017A378
		public unsafe ProductItemInstance ConsumedProduct
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_get_ConsumedProduct_Public_get_ProductItemInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ProductItemInstance>(intPtr2) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 171224, XrefRangeEnd = 171225, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_set_ConsumedProduct_Private_set_Void_ProductItemInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x170017DF RID: 6111
		// (get) Token: 0x06004E70 RID: 20080 RVA: 0x0017C1BC File Offset: 0x0017A3BC
		// (set) Token: 0x06004E71 RID: 20081 RVA: 0x0017C1F8 File Offset: 0x0017A3F8
		public unsafe int TimeSinceProductConsumed
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_get_TimeSinceProductConsumed_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
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
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_set_TimeSinceProductConsumed_Private_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x06004E72 RID: 20082 RVA: 0x0017C238 File Offset: 0x0017A438
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 171225, XrefRangeEnd = 171226, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LoadDebugAvatarSettings()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_LoadDebugAvatarSettings_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x170017E0 RID: 6112
		// (get) Token: 0x06004E73 RID: 20083 RVA: 0x0017C26C File Offset: 0x0017A46C
		public unsafe virtual string SaveFolderName
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 171231, RefRangeEnd = 171236, XrefRangeStart = 171226, XrefRangeEnd = 171231, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_get_SaveFolderName_Public_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return IL2CPP.Il2CppStringToManaged(il2CppString);
			}
		}

		// Token: 0x170017E1 RID: 6113
		// (get) Token: 0x06004E74 RID: 20084 RVA: 0x0017C2A4 File Offset: 0x0017A4A4
		public unsafe virtual string SaveFileName
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 171236, XrefRangeEnd = 171238, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_get_SaveFileName_Public_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return IL2CPP.Il2CppStringToManaged(il2CppString);
			}
		}

		// Token: 0x170017E2 RID: 6114
		// (get) Token: 0x06004E75 RID: 20085 RVA: 0x0017C2DC File Offset: 0x0017A4DC
		public unsafe virtual Loader Loader
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_get_Loader_Public_Virtual_Final_New_get_Loader_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Loader>(intPtr2) : null;
			}
		}

		// Token: 0x170017E3 RID: 6115
		// (get) Token: 0x06004E76 RID: 20086 RVA: 0x0017C31C File Offset: 0x0017A51C
		public unsafe virtual bool ShouldSaveUnderFolder
		{
			[CallerCount(21)]
			[CachedScanResults(RefRangeStart = 31612, RefRangeEnd = 31633, XrefRangeStart = 31612, XrefRangeEnd = 31633, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_get_ShouldSaveUnderFolder_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
		}

		// Token: 0x170017E4 RID: 6116
		// (get) Token: 0x06004E77 RID: 20087 RVA: 0x0017C358 File Offset: 0x0017A558
		// (set) Token: 0x06004E78 RID: 20088 RVA: 0x0017C398 File Offset: 0x0017A598
		public unsafe virtual List<string> LocalExtraFiles
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 122677, RefRangeEnd = 122678, XrefRangeStart = 122677, XrefRangeEnd = 122678, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_get_LocalExtraFiles_Public_Virtual_Final_New_get_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 171238, XrefRangeEnd = 171239, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_set_LocalExtraFiles_Public_Virtual_Final_New_set_Void_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x170017E5 RID: 6117
		// (get) Token: 0x06004E79 RID: 20089 RVA: 0x0017C3DC File Offset: 0x0017A5DC
		// (set) Token: 0x06004E7A RID: 20090 RVA: 0x0017C41C File Offset: 0x0017A61C
		public unsafe virtual List<string> LocalExtraFolders
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_get_LocalExtraFolders_Public_Virtual_Final_New_get_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 171239, XrefRangeEnd = 171240, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_set_LocalExtraFolders_Public_Virtual_Final_New_set_Void_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x170017E6 RID: 6118
		// (get) Token: 0x06004E7B RID: 20091 RVA: 0x0017C460 File Offset: 0x0017A660
		// (set) Token: 0x06004E7C RID: 20092 RVA: 0x0017C49C File Offset: 0x0017A69C
		public unsafe virtual bool HasChanged
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_get_HasChanged_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
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
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_set_HasChanged_Public_Virtual_Final_New_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x170017E7 RID: 6119
		// (get) Token: 0x06004E7D RID: 20093 RVA: 0x0017C4DC File Offset: 0x0017A6DC
		// (set) Token: 0x06004E7E RID: 20094 RVA: 0x0017C518 File Offset: 0x0017A718
		public unsafe bool avatarVisibleToLocalPlayer
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_get_avatarVisibleToLocalPlayer_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
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
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_set_avatarVisibleToLocalPlayer_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x170017E8 RID: 6120
		// (get) Token: 0x06004E7F RID: 20095 RVA: 0x0017C558 File Offset: 0x0017A758
		// (set) Token: 0x06004E80 RID: 20096 RVA: 0x0017C594 File Offset: 0x0017A794
		public unsafe bool playerDataRetrieveReturned
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_get_playerDataRetrieveReturned_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
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
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_set_playerDataRetrieveReturned_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x170017E9 RID: 6121
		// (get) Token: 0x06004E81 RID: 20097 RVA: 0x0017C5D4 File Offset: 0x0017A7D4
		// (set) Token: 0x06004E82 RID: 20098 RVA: 0x0017C610 File Offset: 0x0017A810
		public unsafe bool playerSaveRequestReturned
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_get_playerSaveRequestReturned_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
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
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_set_playerSaveRequestReturned_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x170017EA RID: 6122
		// (get) Token: 0x06004E83 RID: 20099 RVA: 0x0017C650 File Offset: 0x0017A850
		// (set) Token: 0x06004E84 RID: 20100 RVA: 0x0017C68C File Offset: 0x0017A88C
		public unsafe bool PlayerInitializedOverNetwork
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_get_PlayerInitializedOverNetwork_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
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
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_set_PlayerInitializedOverNetwork_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x170017EB RID: 6123
		// (get) Token: 0x06004E85 RID: 20101 RVA: 0x0017C6CC File Offset: 0x0017A8CC
		// (set) Token: 0x06004E86 RID: 20102 RVA: 0x0017C708 File Offset: 0x0017A908
		public unsafe bool Paranoid
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_get_Paranoid_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
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
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_set_Paranoid_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x170017EC RID: 6124
		// (get) Token: 0x06004E87 RID: 20103 RVA: 0x0017C748 File Offset: 0x0017A948
		// (set) Token: 0x06004E88 RID: 20104 RVA: 0x0017C784 File Offset: 0x0017A984
		public unsafe bool Sneaky
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_get_Sneaky_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
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
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_set_Sneaky_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x170017ED RID: 6125
		// (get) Token: 0x06004E89 RID: 20105 RVA: 0x0017C7C4 File Offset: 0x0017A9C4
		// (set) Token: 0x06004E8A RID: 20106 RVA: 0x0017C800 File Offset: 0x0017AA00
		public unsafe bool Disoriented
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_get_Disoriented_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
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
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_set_Disoriented_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x170017EE RID: 6126
		// (get) Token: 0x06004E8B RID: 20107 RVA: 0x0017C840 File Offset: 0x0017AA40
		// (set) Token: 0x06004E8C RID: 20108 RVA: 0x0017C87C File Offset: 0x0017AA7C
		public unsafe bool Seizure
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_get_Seizure_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
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
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_set_Seizure_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x170017EF RID: 6127
		// (get) Token: 0x06004E8D RID: 20109 RVA: 0x0017C8BC File Offset: 0x0017AABC
		// (set) Token: 0x06004E8E RID: 20110 RVA: 0x0017C8F8 File Offset: 0x0017AAF8
		public unsafe bool Slippery
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_get_Slippery_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
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
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_set_Slippery_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x170017F0 RID: 6128
		// (get) Token: 0x06004E8F RID: 20111 RVA: 0x0017C938 File Offset: 0x0017AB38
		// (set) Token: 0x06004E90 RID: 20112 RVA: 0x0017C974 File Offset: 0x0017AB74
		public unsafe bool Schizophrenic
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_get_Schizophrenic_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
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
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_set_Schizophrenic_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x06004E91 RID: 20113 RVA: 0x0017C9B4 File Offset: 0x0017ABB4
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 171257, RefRangeEnd = 171266, XrefRangeStart = 171240, XrefRangeEnd = 171257, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Player GetPlayer(NetworkConnection conn)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_GetPlayer_Public_Static_Player_NetworkConnection_0, 0, (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Player>(intPtr2) : null;
		}

		// Token: 0x06004E92 RID: 20114 RVA: 0x0017C9F8 File Offset: 0x0017ABF8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 171304, RefRangeEnd = 171306, XrefRangeStart = 171266, XrefRangeEnd = 171304, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Player GetRandomPlayer(bool excludeArrestedOrDead = true, bool excludeSleeping = true)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref excludeArrestedOrDead;
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref excludeSleeping;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_GetRandomPlayer_Public_Static_Player_Boolean_Boolean_0, 0, (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Player>(intPtr2) : null;
		}

		// Token: 0x06004E93 RID: 20115 RVA: 0x0017CA48 File Offset: 0x0017AC48
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 171325, RefRangeEnd = 171326, XrefRangeStart = 171306, XrefRangeEnd = 171325, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Player GetPlayer(string playerCode)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(playerCode);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_GetPlayer_Public_Static_Player_String_0, 0, (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Player>(intPtr2) : null;
		}

		// Token: 0x06004E94 RID: 20116 RVA: 0x0017CA8C File Offset: 0x0017AC8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 171326, XrefRangeEnd = 171327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Player.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004E95 RID: 20117 RVA: 0x0017CAC8 File Offset: 0x0017ACC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 171327, XrefRangeEnd = 171333, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void InitializeSaveable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Player.NativeMethodInfoPtr_InitializeSaveable_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004E96 RID: 20118 RVA: 0x0017CB04 File Offset: 0x0017AD04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 171333, XrefRangeEnd = 171381, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Player.NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_1), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004E97 RID: 20119 RVA: 0x0017CB40 File Offset: 0x0017AD40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 171381, XrefRangeEnd = 171428, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Player.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_New_Void_1), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004E98 RID: 20120 RVA: 0x0017CB7C File Offset: 0x0017AD7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 171428, XrefRangeEnd = 171600, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnStartClient()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Player.NativeMethodInfoPtr_OnStartClient_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004E99 RID: 20121 RVA: 0x0017CBB8 File Offset: 0x0017ADB8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 171704, RefRangeEnd = 171706, XrefRangeStart = 171600, XrefRangeEnd = 171704, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PlayerLoaded()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_PlayerLoaded_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004E9A RID: 20122 RVA: 0x0017CBEC File Offset: 0x0017ADEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 171706, XrefRangeEnd = 171729, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnSpawnServer(NetworkConnection connection)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(connection);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Player.NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004E9B RID: 20123 RVA: 0x0017CC3C File Offset: 0x0017AE3C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 171750, RefRangeEnd = 171752, XrefRangeStart = 171729, XrefRangeEnd = 171750, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RequestSavePlayer()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_RequestSavePlayer_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004E9C RID: 20124 RVA: 0x0017CC70 File Offset: 0x0017AE70
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 171783, RefRangeEnd = 171784, XrefRangeStart = 171752, XrefRangeEnd = 171783, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReturnSaveRequest(NetworkConnection conn, bool successful)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref successful;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_ReturnSaveRequest_Private_Void_NetworkConnection_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004E9D RID: 20125 RVA: 0x0017CCC0 File Offset: 0x0017AEC0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 171805, RefRangeEnd = 171806, XrefRangeStart = 171784, XrefRangeEnd = 171805, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void HostExitedGame()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_HostExitedGame_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004E9E RID: 20126 RVA: 0x0017CCF4 File Offset: 0x0017AEF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 171806, XrefRangeEnd = 171836, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ClientConnectionStateChanged(ClientConnectionStateArgs args)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref args;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_ClientConnectionStateChanged_Private_Void_ClientConnectionStateArgs_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004E9F RID: 20127 RVA: 0x0017CD34 File Offset: 0x0017AF34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 171836, XrefRangeEnd = 171838, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendPlayerNameData(string playerName, ulong id)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(playerName);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref id;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_SendPlayerNameData_Public_Void_String_UInt64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004EA0 RID: 20128 RVA: 0x0017CD84 File Offset: 0x0017AF84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 171838, XrefRangeEnd = 171848, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RequestPlayerData(string playerCode)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(playerCode);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_RequestPlayerData_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004EA1 RID: 20129 RVA: 0x0017CDC8 File Offset: 0x0017AFC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 171848, XrefRangeEnd = 171880, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MarkPlayerInitialized()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_MarkPlayerInitialized_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004EA2 RID: 20130 RVA: 0x0017CDFC File Offset: 0x0017AFFC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 171930, RefRangeEnd = 171932, XrefRangeStart = 171880, XrefRangeEnd = 171930, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReceivePlayerData(NetworkConnection conn, PlayerData data, string inventoryString, string appearanceString, string clothigString, Il2CppReferenceArray<VariableData> vars)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)6) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(data);
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(inventoryString);
			ptr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(appearanceString);
			ptr[checked(unchecked((System.UIntPtr)4) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(clothigString);
			ptr[checked(unchecked((System.UIntPtr)5) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(vars);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_ReceivePlayerData_Public_Void_NetworkConnection_PlayerData_String_String_String_Il2CppReferenceArray_1_VariableData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004EA3 RID: 20131 RVA: 0x0017CE9C File Offset: 0x0017B09C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 171963, RefRangeEnd = 171966, XrefRangeStart = 171932, XrefRangeEnd = 171963, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetGravityMultiplier(float multiplier)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref multiplier;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_SetGravityMultiplier_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004EA4 RID: 20132 RVA: 0x0017CEDC File Offset: 0x0017B0DC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 172010, RefRangeEnd = 172012, XrefRangeStart = 171966, XrefRangeEnd = 172010, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReceivePlayerNameData(NetworkConnection conn, string playerName, string id)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(playerName);
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(id);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_ReceivePlayerNameData_Private_Void_NetworkConnection_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004EA5 RID: 20133 RVA: 0x0017CF44 File Offset: 0x0017B144
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 172034, RefRangeEnd = 172036, XrefRangeStart = 172012, XrefRangeEnd = 172034, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendFlashlightOn(bool on)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref on;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_SendFlashlightOn_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004EA6 RID: 20134 RVA: 0x0017CF84 File Offset: 0x0017B184
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 172034, RefRangeEnd = 172036, XrefRangeStart = 172034, XrefRangeEnd = 172036, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendFlashlightOnNetworked(bool on)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref on;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_SendFlashlightOnNetworked_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004EA7 RID: 20135 RVA: 0x0017CFC4 File Offset: 0x0017B1C4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 172061, RefRangeEnd = 172064, XrefRangeStart = 172036, XrefRangeEnd = 172061, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetFlashlightOn(bool on)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref on;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_SetFlashlightOn_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004EA8 RID: 20136 RVA: 0x0017D004 File Offset: 0x0017B204
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 172064, XrefRangeEnd = 172073, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnStopClient()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Player.NativeMethodInfoPtr_OnStopClient_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004EA9 RID: 20137 RVA: 0x0017D040 File Offset: 0x0017B240
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 172073, XrefRangeEnd = 172083, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnStartServer()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Player.NativeMethodInfoPtr_OnStartServer_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004EAA RID: 20138 RVA: 0x0017D07C File Offset: 0x0017B27C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 172083, XrefRangeEnd = 172135, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Player.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_1), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004EAB RID: 20139 RVA: 0x0017D0B8 File Offset: 0x0017B2B8
		[CallerCount(14558)]
		[CachedScanResults(RefRangeStart = 2769, RefRangeEnd = 17327, XrefRangeStart = 2769, XrefRangeEnd = 17327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void MinPass()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Player.NativeMethodInfoPtr_MinPass_Protected_Virtual_New_Void_1), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004EAC RID: 20140 RVA: 0x0017D0F4 File Offset: 0x0017B2F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 172135, XrefRangeEnd = 172139, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Tick()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Player.NativeMethodInfoPtr_Tick_Protected_Virtual_New_Void_1), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004EAD RID: 20141 RVA: 0x0017D130 File Offset: 0x0017B330
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 172139, XrefRangeEnd = 172212, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void LateUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Player.NativeMethodInfoPtr_LateUpdate_Protected_Virtual_New_Void_1), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004EAE RID: 20142 RVA: 0x0017D16C File Offset: 0x0017B36C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 172212, XrefRangeEnd = 172261, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RecalculateCurrentProperty()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_RecalculateCurrentProperty_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004EAF RID: 20143 RVA: 0x0017D1A0 File Offset: 0x0017B3A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 172261, XrefRangeEnd = 172262, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FixedUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_FixedUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004EB0 RID: 20144 RVA: 0x0017D1D4 File Offset: 0x0017B3D4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 172320, RefRangeEnd = 172321, XrefRangeStart = 172262, XrefRangeEnd = 172320, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ApplyMovementVisuals()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_ApplyMovementVisuals_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004EB1 RID: 20145 RVA: 0x0017D208 File Offset: 0x0017B408
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 172333, RefRangeEnd = 172335, XrefRangeStart = 172321, XrefRangeEnd = 172333, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetVisible(bool vis, bool network = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref vis;
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref network;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_SetVisible_Public_Void_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004EB2 RID: 20146 RVA: 0x0017D254 File Offset: 0x0017B454
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 172344, RefRangeEnd = 172345, XrefRangeStart = 172335, XrefRangeEnd = 172344, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PlayJumpAnimation()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_PlayJumpAnimation_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004EB3 RID: 20147 RVA: 0x0017D288 File Offset: 0x0017B488
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 172364, RefRangeEnd = 172366, XrefRangeStart = 172345, XrefRangeEnd = 172364, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool GetIsGrounded()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_GetIsGrounded_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06004EB4 RID: 20148 RVA: 0x0017D2C4 File Offset: 0x0017B4C4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 172388, RefRangeEnd = 172389, XrefRangeStart = 172366, XrefRangeEnd = 172388, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendCrouched(bool crouched)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref crouched;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_SendCrouched_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004EB5 RID: 20149 RVA: 0x0017D304 File Offset: 0x0017B504
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 171140, RefRangeEnd = 171141, XrefRangeStart = 171140, XrefRangeEnd = 171141, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetCrouchedLocal(bool crouched)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref crouched;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_SetCrouchedLocal_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004EB6 RID: 20150 RVA: 0x0017D344 File Offset: 0x0017B544
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 172399, RefRangeEnd = 172403, XrefRangeStart = 172389, XrefRangeEnd = 172399, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReceiveCrouched(NetworkConnection conn, bool crouched)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref crouched;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_ReceiveCrouched_Private_Void_NetworkConnection_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004EB7 RID: 20151 RVA: 0x0017D394 File Offset: 0x0017B594
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 172403, XrefRangeEnd = 172436, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendAvatarSettings(AvatarSettings settings)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(settings);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_SendAvatarSettings_Public_Void_AvatarSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004EB8 RID: 20152 RVA: 0x0017D3D8 File Offset: 0x0017B5D8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 172458, RefRangeEnd = 172461, XrefRangeStart = 172436, XrefRangeEnd = 172458, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetAvatarSettings(AvatarSettings settings)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(settings);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_SetAvatarSettings_Public_Void_AvatarSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004EB9 RID: 20153 RVA: 0x0017D41C File Offset: 0x0017B61C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 172461, XrefRangeEnd = 172471, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetVisible_Networked(bool vis)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref vis;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_SetVisible_Networked_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004EBA RID: 20154 RVA: 0x0017D45C File Offset: 0x0017B65C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 172486, RefRangeEnd = 172487, XrefRangeStart = 172471, XrefRangeEnd = 172486, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EnterVehicle(LandVehicle vehicle)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(vehicle);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_EnterVehicle_Public_Void_LandVehicle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004EBB RID: 20155 RVA: 0x0017D4A0 File Offset: 0x0017B6A0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 172528, RefRangeEnd = 172529, XrefRangeStart = 172487, XrefRangeEnd = 172528, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ExitVehicle(Transform exitPoint)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(exitPoint);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_ExitVehicle_Public_Void_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004EBC RID: 20156 RVA: 0x0017D4E4 File Offset: 0x0017B6E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 172529, XrefRangeEnd = 172554, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PreDestroyClientObjects(NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_PreDestroyClientObjects_Private_Void_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004EBD RID: 20157 RVA: 0x0017D528 File Offset: 0x0017B728
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 172554, XrefRangeEnd = 172575, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CurrentVehicleChanged(NetworkObject oldVeh, NetworkObject newVeh, bool asServer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(oldVeh);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(newVeh);
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref asServer;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_CurrentVehicleChanged_Private_Void_NetworkObject_NetworkObject_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004EBE RID: 20158 RVA: 0x0017D58C File Offset: 0x0017B78C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 172598, RefRangeEnd = 172599, XrefRangeStart = 172575, XrefRangeEnd = 172598, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool AreAllPlayersReadyToSleep()
		{
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_AreAllPlayersReadyToSleep_Public_Static_Boolean_0, 0, (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06004EBF RID: 20159 RVA: 0x0017D5BC File Offset: 0x0017B7BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 172599, XrefRangeEnd = 172600, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SleepStart()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_SleepStart_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004EC0 RID: 20160 RVA: 0x0017D5F0 File Offset: 0x0017B7F0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 172622, RefRangeEnd = 172625, XrefRangeStart = 172600, XrefRangeEnd = 172622, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetReadyToSleep(bool ready)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref ready;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_SetReadyToSleep_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004EC1 RID: 20161 RVA: 0x0017D630 File Offset: 0x0017B830
		[CallerCount(0)]
		public unsafe void SleepEnd(int minsSlept)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref minsSlept;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_SleepEnd_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004EC2 RID: 20162 RVA: 0x0017D670 File Offset: 0x0017B870
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 172649, RefRangeEnd = 172650, XrefRangeStart = 172625, XrefRangeEnd = 172649, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Activate()
		{
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_Activate_Public_Static_Void_0, 0, (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004EC3 RID: 20163 RVA: 0x0017D698 File Offset: 0x0017B898
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 172672, RefRangeEnd = 172674, XrefRangeStart = 172650, XrefRangeEnd = 172672, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Deactivate(bool freeMouse)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref freeMouse;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_Deactivate_Public_Static_Void_Boolean_0, 0, (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004EC4 RID: 20164 RVA: 0x0017D6CC File Offset: 0x0017B8CC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 172713, RefRangeEnd = 172716, XrefRangeStart = 172674, XrefRangeEnd = 172713, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ExitAll()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_ExitAll_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004EC5 RID: 20165 RVA: 0x0017D700 File Offset: 0x0017B900
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 172724, RefRangeEnd = 172730, XrefRangeStart = 172716, XrefRangeEnd = 172724, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetVisibleToLocalPlayer(bool vis)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref vis;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_SetVisibleToLocalPlayer_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004EC6 RID: 20166 RVA: 0x0017D740 File Offset: 0x0017B940
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 172730, XrefRangeEnd = 172752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetPlayerCode(string code)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(code);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_SetPlayerCode_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004EC7 RID: 20167 RVA: 0x0017D784 File Offset: 0x0017B984
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 172763, RefRangeEnd = 172764, XrefRangeStart = 172752, XrefRangeEnd = 172763, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendPunch()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_SendPunch_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004EC8 RID: 20168 RVA: 0x0017D7B8 File Offset: 0x0017B9B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 172764, XrefRangeEnd = 172773, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Punch()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_Punch_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004EC9 RID: 20169 RVA: 0x0017D7EC File Offset: 0x0017B9EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 172773, XrefRangeEnd = 172806, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MarkIntroCompleted(BasicAvatarSettings appearance)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(appearance);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_MarkIntroCompleted_Private_Void_BasicAvatarSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004ECA RID: 20170 RVA: 0x0017D830 File Offset: 0x0017BA30
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 172833, RefRangeEnd = 172835, XrefRangeStart = 172806, XrefRangeEnd = 172833, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsPointVisibleToPlayer(Vector3 point, float maxDistance_Visible = 30f, float minDistance_Invisible = 5f)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref point;
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref maxDistance_Visible;
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref minDistance_Invisible;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_IsPointVisibleToPlayer_Public_Boolean_Vector3_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06004ECB RID: 20171 RVA: 0x0017D898 File Offset: 0x0017BA98
		[CallerCount(18)]
		[CachedScanResults(RefRangeStart = 172874, RefRangeEnd = 172892, XrefRangeStart = 172835, XrefRangeEnd = 172874, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Player GetClosestPlayer(Vector3 point, out float distance, List<Player> exclude = null)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref point;
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = &distance;
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(exclude);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_GetClosestPlayer_Public_Static_Player_Vector3_byref_Single_List_1_Player_0, 0, (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Player>(intPtr2) : null;
		}

		// Token: 0x06004ECC RID: 20172 RVA: 0x0017D8F8 File Offset: 0x0017BAF8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 172895, RefRangeEnd = 172896, XrefRangeStart = 172892, XrefRangeEnd = 172895, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetCapsuleColliderHeight(float normalizedHeight)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref normalizedHeight;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_SetCapsuleColliderHeight_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004ECD RID: 20173 RVA: 0x0017D938 File Offset: 0x0017BB38
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 172896, RefRangeEnd = 172897, XrefRangeStart = 172896, XrefRangeEnd = 172896, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetScale(float scale)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref scale;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_SetScale_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004ECE RID: 20174 RVA: 0x0017D978 File Offset: 0x0017BB78
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 172911, RefRangeEnd = 172913, XrefRangeStart = 172897, XrefRangeEnd = 172911, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetScale(float scale, float lerpTime)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref scale;
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref lerpTime;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_SetScale_Public_Void_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004ECF RID: 20175 RVA: 0x0017D9C4 File Offset: 0x0017BBC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 172913, XrefRangeEnd = 172919, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void ApplyScale()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Player.NativeMethodInfoPtr_ApplyScale_Protected_Virtual_New_Void_1), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004ED0 RID: 20176 RVA: 0x0017DA00 File Offset: 0x0017BC00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 172919, XrefRangeEnd = 172928, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual string GetSaveString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Player.NativeMethodInfoPtr_GetSaveString_Public_Virtual_New_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return IL2CPP.Il2CppStringToManaged(il2CppString);
		}

		// Token: 0x06004ED1 RID: 20177 RVA: 0x0017DA44 File Offset: 0x0017BC44
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 172936, RefRangeEnd = 172938, XrefRangeStart = 172928, XrefRangeEnd = 172936, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PlayerData GetPlayerData()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_GetPlayerData_Public_PlayerData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlayerData>(intPtr2) : null;
		}

		// Token: 0x06004ED2 RID: 20178 RVA: 0x0017DA84 File Offset: 0x0017BC84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 172938, XrefRangeEnd = 172982, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual List<string> WriteData(string parentFolderPath)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(parentFolderPath);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Player.NativeMethodInfoPtr_WriteData_Public_Virtual_New_List_1_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
		}

		// Token: 0x06004ED3 RID: 20179 RVA: 0x0017DAE0 File Offset: 0x0017BCE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 172982, XrefRangeEnd = 172991, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetInventoryString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_GetInventoryString_Public_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return IL2CPP.Il2CppStringToManaged(il2CppString);
		}

		// Token: 0x06004ED4 RID: 20180 RVA: 0x0017DB18 File Offset: 0x0017BD18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 172991, XrefRangeEnd = 172997, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetAppearanceString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_GetAppearanceString_Public_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return IL2CPP.Il2CppStringToManaged(il2CppString);
		}

		// Token: 0x06004ED5 RID: 20181 RVA: 0x0017DB50 File Offset: 0x0017BD50
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 173006, RefRangeEnd = 173008, XrefRangeStart = 172997, XrefRangeEnd = 173006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetClothingString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_GetClothingString_Public_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return IL2CPP.Il2CppStringToManaged(il2CppString);
		}

		// Token: 0x06004ED6 RID: 20182 RVA: 0x0017DB88 File Offset: 0x0017BD88
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 173040, RefRangeEnd = 173041, XrefRangeStart = 173008, XrefRangeEnd = 173040, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetVariablesString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_GetVariablesString_Public_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return IL2CPP.Il2CppStringToManaged(il2CppString);
		}

		// Token: 0x06004ED7 RID: 20183 RVA: 0x0017DBC0 File Offset: 0x0017BDC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 173041, XrefRangeEnd = 173101, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Load(PlayerData data, string containerPath)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(containerPath);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Player.NativeMethodInfoPtr_Load_Public_Virtual_New_Void_PlayerData_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004ED8 RID: 20184 RVA: 0x0017DC20 File Offset: 0x0017BE20
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 173101, XrefRangeEnd = 173110, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Load(PlayerData data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Player.NativeMethodInfoPtr_Load_Public_Virtual_New_Void_PlayerData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004ED9 RID: 20185 RVA: 0x0017DC70 File Offset: 0x0017BE70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 173110, XrefRangeEnd = 173139, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void LoadInventory(string contentsString)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(contentsString);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Player.NativeMethodInfoPtr_LoadInventory_Public_Virtual_New_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004EDA RID: 20186 RVA: 0x0017DCC0 File Offset: 0x0017BEC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 173139, XrefRangeEnd = 173151, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void LoadAppearance(string appearanceString)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(appearanceString);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Player.NativeMethodInfoPtr_LoadAppearance_Public_Virtual_New_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004EDB RID: 20187 RVA: 0x0017DD10 File Offset: 0x0017BF10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 173151, XrefRangeEnd = 173157, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void LoadClothing(string contentsString)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(contentsString);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Player.NativeMethodInfoPtr_LoadClothing_Public_Virtual_New_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004EDC RID: 20188 RVA: 0x0017DD60 File Offset: 0x0017BF60
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 173172, RefRangeEnd = 173176, XrefRangeStart = 173157, XrefRangeEnd = 173172, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetRagdolled(bool ragdolled)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref ragdolled;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_SetRagdolled_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004EDD RID: 20189 RVA: 0x0017DDA0 File Offset: 0x0017BFA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 173176, XrefRangeEnd = 173197, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SendImpact(Impact impact)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(impact);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Player.NativeMethodInfoPtr_SendImpact_Public_Virtual_New_Void_Impact_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004EDE RID: 20190 RVA: 0x0017DDF0 File Offset: 0x0017BFF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 173197, XrefRangeEnd = 173219, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void ReceiveImpact(Impact impact)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(impact);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Player.NativeMethodInfoPtr_ReceiveImpact_Public_Virtual_New_Void_Impact_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004EDF RID: 20191 RVA: 0x0017DE40 File Offset: 0x0017C040
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 173219, XrefRangeEnd = 173220, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void ProcessImpactForce(Vector3 forcePoint, Vector3 forceDirection, float force)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref forcePoint;
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref forceDirection;
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref force;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Player.NativeMethodInfoPtr_ProcessImpactForce_Public_Virtual_New_Void_Vector3_Vector3_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004EE0 RID: 20192 RVA: 0x0017DEA8 File Offset: 0x0017C0A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 173220, XrefRangeEnd = 173273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnDied()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Player.NativeMethodInfoPtr_OnDied_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004EE1 RID: 20193 RVA: 0x0017DEE4 File Offset: 0x0017C0E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 173273, XrefRangeEnd = 173291, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnRevived()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Player.NativeMethodInfoPtr_OnRevived_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004EE2 RID: 20194 RVA: 0x0017DF20 File Offset: 0x0017C120
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 173312, RefRangeEnd = 173314, XrefRangeStart = 173291, XrefRangeEnd = 173312, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Arrest()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_Arrest_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004EE3 RID: 20195 RVA: 0x0017DF54 File Offset: 0x0017C154
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 173370, RefRangeEnd = 173372, XrefRangeStart = 173314, XrefRangeEnd = 173370, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Free()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_Free_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004EE4 RID: 20196 RVA: 0x0017DF88 File Offset: 0x0017C188
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 173372, XrefRangeEnd = 173404, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendPassOut()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_SendPassOut_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004EE5 RID: 20197 RVA: 0x0017DFBC File Offset: 0x0017C1BC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 173425, RefRangeEnd = 173427, XrefRangeStart = 173404, XrefRangeEnd = 173425, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PassOut()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_PassOut_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004EE6 RID: 20198 RVA: 0x0017DFF0 File Offset: 0x0017C1F0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 173459, RefRangeEnd = 173460, XrefRangeStart = 173427, XrefRangeEnd = 173459, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendPassOutRecovery()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_SendPassOutRecovery_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004EE7 RID: 20199 RVA: 0x0017E024 File Offset: 0x0017C224
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 173481, RefRangeEnd = 173483, XrefRangeStart = 173460, XrefRangeEnd = 173481, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PassOutRecovery()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_PassOutRecovery_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004EE8 RID: 20200 RVA: 0x0017E058 File Offset: 0x0017C258
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 173505, RefRangeEnd = 173511, XrefRangeStart = 173483, XrefRangeEnd = 173505, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendEquippable_Networked(string assetPath)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(assetPath);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_SendEquippable_Networked_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004EE9 RID: 20201 RVA: 0x0017E09C File Offset: 0x0017C29C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 173532, RefRangeEnd = 173534, XrefRangeStart = 173511, XrefRangeEnd = 173532, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetEquippable_Networked(string assetPath)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(assetPath);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_SetEquippable_Networked_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004EEA RID: 20202 RVA: 0x0017E0E0 File Offset: 0x0017C2E0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 173536, RefRangeEnd = 173537, XrefRangeStart = 173534, XrefRangeEnd = 173536, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendEquippableMessage_Networked(string message, int receipt)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref receipt;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_SendEquippableMessage_Networked_Public_Void_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004EEB RID: 20203 RVA: 0x0017E130 File Offset: 0x0017C330
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 173561, RefRangeEnd = 173563, XrefRangeStart = 173537, XrefRangeEnd = 173561, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReceiveEquippableMessage_Networked(string message, int receipt)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref receipt;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_ReceiveEquippableMessage_Networked_Private_Void_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004EEC RID: 20204 RVA: 0x0017E180 File Offset: 0x0017C380
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 173565, RefRangeEnd = 173566, XrefRangeStart = 173563, XrefRangeEnd = 173565, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendEquippableMessage_Networked_Vector(string message, int receipt, Vector3 data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref receipt;
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref data;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_SendEquippableMessage_Networked_Vector_Public_Void_String_Int32_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004EED RID: 20205 RVA: 0x0017E1E0 File Offset: 0x0017C3E0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 173592, RefRangeEnd = 173595, XrefRangeStart = 173566, XrefRangeEnd = 173592, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReceiveEquippableMessage_Networked_Vector(string message, int receipt, Vector3 data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref receipt;
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref data;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_ReceiveEquippableMessage_Networked_Vector_Private_Void_String_Int32_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004EEE RID: 20206 RVA: 0x0017E240 File Offset: 0x0017C440
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 173628, RefRangeEnd = 173631, XrefRangeStart = 173595, XrefRangeEnd = 173628, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendAnimationTrigger(string trigger)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(trigger);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_SendAnimationTrigger_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004EEF RID: 20207 RVA: 0x0017E284 File Offset: 0x0017C484
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 173641, RefRangeEnd = 173644, XrefRangeStart = 173631, XrefRangeEnd = 173641, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetAnimationTrigger_Networked(NetworkConnection conn, string trigger)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(trigger);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_SetAnimationTrigger_Networked_Public_Void_NetworkConnection_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004EF0 RID: 20208 RVA: 0x0017E2D8 File Offset: 0x0017C4D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 173644, XrefRangeEnd = 173646, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetAnimationTrigger(string trigger)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(trigger);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_SetAnimationTrigger_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004EF1 RID: 20209 RVA: 0x0017E31C File Offset: 0x0017C51C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 173646, XrefRangeEnd = 173656, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ResetAnimationTrigger_Networked(NetworkConnection conn, string trigger)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(trigger);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_ResetAnimationTrigger_Networked_Public_Void_NetworkConnection_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004EF2 RID: 20210 RVA: 0x0017E370 File Offset: 0x0017C570
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 173656, XrefRangeEnd = 173658, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ResetAnimationTrigger(string trigger)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(trigger);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_ResetAnimationTrigger_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004EF3 RID: 20211 RVA: 0x0017E3B4 File Offset: 0x0017C5B4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 173660, RefRangeEnd = 173663, XrefRangeStart = 173658, XrefRangeEnd = 173660, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendAnimationBool(string name, bool val)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref val;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_SendAnimationBool_Public_Void_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004EF4 RID: 20212 RVA: 0x0017E404 File Offset: 0x0017C604
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 173686, RefRangeEnd = 173688, XrefRangeStart = 173663, XrefRangeEnd = 173686, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetAnimationBool(string name, bool val)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref val;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_SetAnimationBool_Public_Void_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004EF5 RID: 20213 RVA: 0x0017E454 File Offset: 0x0017C654
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 173697, RefRangeEnd = 173698, XrefRangeStart = 173688, XrefRangeEnd = 173697, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Taze()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_Taze_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004EF6 RID: 20214 RVA: 0x0017E488 File Offset: 0x0017C688
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 173701, RefRangeEnd = 173705, XrefRangeStart = 173698, XrefRangeEnd = 173701, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetInventoryItem(int index, ItemInstance item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref index;
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(item);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_SetInventoryItem_Public_Void_Int32_ItemInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004EF7 RID: 20215 RVA: 0x0017E4D8 File Offset: 0x0017C6D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 173705, XrefRangeEnd = 173707, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GetNetworth(MoneyManager.FloatContainer container)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(container);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_GetNetworth_Private_Void_FloatContainer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004EF8 RID: 20216 RVA: 0x0017E51C File Offset: 0x0017C71C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 173740, RefRangeEnd = 173741, XrefRangeStart = 173707, XrefRangeEnd = 173740, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendAppearance(BasicAvatarSettings settings)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(settings);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_SendAppearance_Public_Void_BasicAvatarSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004EF9 RID: 20217 RVA: 0x0017E560 File Offset: 0x0017C760
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 173764, RefRangeEnd = 173771, XrefRangeStart = 173741, XrefRangeEnd = 173764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetAppearance(BasicAvatarSettings settings, bool refreshClothing)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(settings);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref refreshClothing;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_SetAppearance_Public_Void_BasicAvatarSettings_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004EFA RID: 20218 RVA: 0x0017E5B0 File Offset: 0x0017C7B0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 173841, RefRangeEnd = 173842, XrefRangeStart = 173771, XrefRangeEnd = 173841, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MountSkateboard(Skateboard board)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(board);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_MountSkateboard_Public_Void_Skateboard_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004EFB RID: 20219 RVA: 0x0017E5F4 File Offset: 0x0017C7F4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 173875, RefRangeEnd = 173877, XrefRangeStart = 173842, XrefRangeEnd = 173875, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendMountedSkateboard(NetworkObject skateboardObj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(skateboardObj);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_SendMountedSkateboard_Private_Void_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004EFC RID: 20220 RVA: 0x0017E638 File Offset: 0x0017C838
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 173899, RefRangeEnd = 173901, XrefRangeStart = 173877, XrefRangeEnd = 173899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetMountedSkateboard(NetworkObject skateboardObj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(skateboardObj);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_SetMountedSkateboard_Private_Void_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004EFD RID: 20221 RVA: 0x0017E67C File Offset: 0x0017C87C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 173941, RefRangeEnd = 173942, XrefRangeStart = 173901, XrefRangeEnd = 173941, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DismountSkateboard()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_DismountSkateboard_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004EFE RID: 20222 RVA: 0x0017E6B0 File Offset: 0x0017C8B0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 173965, RefRangeEnd = 173966, XrefRangeStart = 173942, XrefRangeEnd = 173965, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ConsumeProduct(ProductItemInstance product)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(product);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_ConsumeProduct_Public_Void_ProductItemInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004EFF RID: 20223 RVA: 0x0017E6F4 File Offset: 0x0017C8F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 173966, XrefRangeEnd = 173976, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendConsumeProduct(ProductItemInstance product)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(product);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_SendConsumeProduct_Private_Void_ProductItemInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004F00 RID: 20224 RVA: 0x0017E738 File Offset: 0x0017C938
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 173976, XrefRangeEnd = 173986, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReceiveConsumeProduct(ProductItemInstance product)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(product);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_ReceiveConsumeProduct_Private_Void_ProductItemInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004F01 RID: 20225 RVA: 0x0017E77C File Offset: 0x0017C97C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 173986, XrefRangeEnd = 173989, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ConsumeProductInternal(ProductItemInstance product)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(product);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_ConsumeProductInternal_Private_Void_ProductItemInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004F02 RID: 20226 RVA: 0x0017E7C0 File Offset: 0x0017C9C0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 173990, RefRangeEnd = 173991, XrefRangeStart = 173989, XrefRangeEnd = 173990, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ClearProduct()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_ClearProduct_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004F03 RID: 20227 RVA: 0x0017E7F4 File Offset: 0x0017C9F4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 174037, RefRangeEnd = 174038, XrefRangeStart = 173991, XrefRangeEnd = 174037, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CreatePlayerVariables()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_CreatePlayerVariables_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004F04 RID: 20228 RVA: 0x0017E828 File Offset: 0x0017CA28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 174038, XrefRangeEnd = 174050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BaseVariable GetVariable(string variableName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(variableName);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_GetVariable_Public_BaseVariable_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<BaseVariable>(intPtr2) : null;
		}

		// Token: 0x06004F05 RID: 20229 RVA: 0x0017E878 File Offset: 0x0017CA78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 174050, XrefRangeEnd = 174065, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe T GetValue<T>(string variableName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(variableName);
			System.IntPtr returnedException;
			System.IntPtr objectPointer = IL2CPP.il2cpp_runtime_invoke(Player.MethodInfoStoreGeneric_GetValue_Public_T_String_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return IL2CPP.PointerToValueGeneric<T>(objectPointer, false, true);
		}

		// Token: 0x06004F06 RID: 20230 RVA: 0x0017E8C4 File Offset: 0x0017CAC4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 174077, RefRangeEnd = 174078, XrefRangeStart = 174065, XrefRangeEnd = 174077, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetVariableValue(string variableName, string value, bool network = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(variableName);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref network;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_SetVariableValue_Public_Void_String_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004F07 RID: 20231 RVA: 0x0017E928 File Offset: 0x0017CB28
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 174102, RefRangeEnd = 174103, XrefRangeStart = 174078, XrefRangeEnd = 174102, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddVariable(BaseVariable variable)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(variable);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_AddVariable_Public_Void_BaseVariable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004F08 RID: 20232 RVA: 0x0017E96C File Offset: 0x0017CB6C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 174127, RefRangeEnd = 174128, XrefRangeStart = 174103, XrefRangeEnd = 174127, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendValue(string variableName, string value, bool sendToOwner)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(variableName);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref sendToOwner;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_SendValue_Public_Void_String_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004F09 RID: 20233 RVA: 0x0017E9D0 File Offset: 0x0017CBD0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 174128, XrefRangeEnd = 174139, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReceiveValue(NetworkConnection conn, string variableName, string value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(variableName);
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_ReceiveValue_Private_Void_NetworkConnection_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004F0A RID: 20234 RVA: 0x0017EA38 File Offset: 0x0017CC38
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 174154, RefRangeEnd = 174157, XrefRangeStart = 174139, XrefRangeEnd = 174154, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReceiveValue(string variableName, string value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(variableName);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_ReceiveValue_Private_Void_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004F0B RID: 20235 RVA: 0x0017EA8C File Offset: 0x0017CC8C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 174179, RefRangeEnd = 174181, XrefRangeStart = 174157, XrefRangeEnd = 174179, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LoadVariable(VariableData data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_LoadVariable_Public_Void_VariableData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004F0C RID: 20236 RVA: 0x0017EAD0 File Offset: 0x0017CCD0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 174181, XrefRangeEnd = 174290, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Player() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Player>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004F0D RID: 20237 RVA: 0x0017EB0C File Offset: 0x0017CD0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 174290, XrefRangeEnd = 174298, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float _RecalculateCurrentProperty_b__249_0(Property x)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr__RecalculateCurrentProperty_b__249_0_Private_Single_Property_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06004F0E RID: 20238 RVA: 0x0017EB5C File Offset: 0x0017CD5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float _RecalculateCurrentProperty_b__249_1(Business x)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr__RecalculateCurrentProperty_b__249_1_Private_Single_Business_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06004F0F RID: 20239 RVA: 0x0017EBAC File Offset: 0x0017CDAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 174298, XrefRangeEnd = 174303, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator Method_Private_IEnumerator_PDM_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr2) : null;
		}

		// Token: 0x06004F10 RID: 20240 RVA: 0x0017EBEC File Offset: 0x0017CDEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 174303, XrefRangeEnd = 174740, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void NetworkInitialize___Early()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Player.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004F11 RID: 20241 RVA: 0x0017EC28 File Offset: 0x0017CE28
		[CallerCount(0)]
		public unsafe virtual void NetworkInitialize__Late()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Player.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004F12 RID: 20242 RVA: 0x0017EC64 File Offset: 0x0017CE64
		[CallerCount(0)]
		public unsafe override void NetworkInitializeIfDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Player.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004F13 RID: 20243 RVA: 0x0017ECA0 File Offset: 0x0017CEA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 174740, XrefRangeEnd = 174752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_set_CurrentVehicle_3323014238(NetworkObject value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_RpcWriter___Server_set_CurrentVehicle_3323014238_Private_Void_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004F14 RID: 20244 RVA: 0x0017ECE4 File Offset: 0x0017CEE4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 174760, RefRangeEnd = 174762, XrefRangeStart = 174752, XrefRangeEnd = 174760, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___set_CurrentVehicle_3323014238(NetworkObject value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_RpcLogic___set_CurrentVehicle_3323014238_Public_Void_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004F15 RID: 20245 RVA: 0x0017ED28 File Offset: 0x0017CF28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 174762, XrefRangeEnd = 174767, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_set_CurrentVehicle_3323014238(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref channel;
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_RpcReader___Server_set_CurrentVehicle_3323014238_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004F16 RID: 20246 RVA: 0x0017ED8C File Offset: 0x0017CF8C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 171153, RefRangeEnd = 171155, XrefRangeStart = 171153, XrefRangeEnd = 171155, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_set_CurrentBed_3323014238(NetworkObject value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_RpcWriter___Server_set_CurrentBed_3323014238_Private_Void_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004F17 RID: 20247 RVA: 0x0017EDD0 File Offset: 0x0017CFD0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 174767, XrefRangeEnd = 174775, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___set_CurrentBed_3323014238(NetworkObject value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_RpcLogic___set_CurrentBed_3323014238_Public_Void_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004F18 RID: 20248 RVA: 0x0017EE14 File Offset: 0x0017D014
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 174775, XrefRangeEnd = 174786, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_set_CurrentBed_3323014238(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref channel;
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_RpcReader___Server_set_CurrentBed_3323014238_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004F19 RID: 20249 RVA: 0x0017EE78 File Offset: 0x0017D078
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 171179, RefRangeEnd = 171180, XrefRangeStart = 171179, XrefRangeEnd = 171180, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_set_IsSkating_1140765316(bool value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref value;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_RpcWriter___Server_set_IsSkating_1140765316_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004F1A RID: 20250 RVA: 0x0017EEB8 File Offset: 0x0017D0B8
		[CallerCount(0)]
		public unsafe void RpcLogic___set_IsSkating_1140765316(bool value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref value;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_RpcLogic___set_IsSkating_1140765316_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004F1B RID: 20251 RVA: 0x0017EEF8 File Offset: 0x0017D0F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 174786, XrefRangeEnd = 174788, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_set_IsSkating_1140765316(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref channel;
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_RpcReader___Server_set_IsSkating_1140765316_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004F1C RID: 20252 RVA: 0x0017EF5C File Offset: 0x0017D15C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 174802, RefRangeEnd = 174804, XrefRangeStart = 174788, XrefRangeEnd = 174802, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_set_CameraPosition_4276783012(Vector3 value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref value;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_RpcWriter___Server_set_CameraPosition_4276783012_Private_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004F1D RID: 20253 RVA: 0x0017EF9C File Offset: 0x0017D19C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 174804, XrefRangeEnd = 174811, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___set_CameraPosition_4276783012(Vector3 value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref value;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_RpcLogic___set_CameraPosition_4276783012_Public_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004F1E RID: 20254 RVA: 0x0017EFDC File Offset: 0x0017D1DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 174811, XrefRangeEnd = 174823, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_set_CameraPosition_4276783012(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref channel;
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_RpcReader___Server_set_CameraPosition_4276783012_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004F1F RID: 20255 RVA: 0x0017F040 File Offset: 0x0017D240
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_set_CameraRotation_3429297120(Quaternion value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref value;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_RpcWriter___Server_set_CameraRotation_3429297120_Private_Void_Quaternion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004F20 RID: 20256 RVA: 0x0017F080 File Offset: 0x0017D280
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 174823, XrefRangeEnd = 174830, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___set_CameraRotation_3429297120(Quaternion value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref value;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_RpcLogic___set_CameraRotation_3429297120_Public_Void_Quaternion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004F21 RID: 20257 RVA: 0x0017F0C0 File Offset: 0x0017D2C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 174830, XrefRangeEnd = 174841, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_set_CameraRotation_3429297120(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref channel;
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_RpcReader___Server_set_CameraRotation_3429297120_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004F22 RID: 20258 RVA: 0x0017F124 File Offset: 0x0017D324
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 174841, XrefRangeEnd = 174850, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_RequestSavePlayer_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_RpcWriter___Server_RequestSavePlayer_2166136261_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004F23 RID: 20259 RVA: 0x0017F158 File Offset: 0x0017D358
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 174864, RefRangeEnd = 174866, XrefRangeStart = 174850, XrefRangeEnd = 174864, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___RequestSavePlayer_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_RpcLogic___RequestSavePlayer_2166136261_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004F24 RID: 20260 RVA: 0x0017F18C File Offset: 0x0017D38C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 174866, XrefRangeEnd = 174869, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_RequestSavePlayer_2166136261(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref channel;
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_RpcReader___Server_RequestSavePlayer_2166136261_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004F25 RID: 20261 RVA: 0x0017F1F0 File Offset: 0x0017D3F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 174869, XrefRangeEnd = 174879, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_ReturnSaveRequest_214505783(NetworkConnection conn, bool successful)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref successful;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_RpcWriter___Observers_ReturnSaveRequest_214505783_Private_Void_NetworkConnection_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004F26 RID: 20262 RVA: 0x0017F240 File Offset: 0x0017D440
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 174890, RefRangeEnd = 174892, XrefRangeStart = 174879, XrefRangeEnd = 174890, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___ReturnSaveRequest_214505783(NetworkConnection conn, bool successful)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref successful;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_RpcLogic___ReturnSaveRequest_214505783_Private_Void_NetworkConnection_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004F27 RID: 20263 RVA: 0x0017F290 File Offset: 0x0017D490
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 174892, XrefRangeEnd = 174894, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_ReturnSaveRequest_214505783(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref channel;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_RpcReader___Observers_ReturnSaveRequest_214505783_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004F28 RID: 20264 RVA: 0x0017F2E0 File Offset: 0x0017D4E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 174894, XrefRangeEnd = 174904, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Target_ReturnSaveRequest_214505783(NetworkConnection conn, bool successful)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref successful;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_RpcWriter___Target_ReturnSaveRequest_214505783_Private_Void_NetworkConnection_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004F29 RID: 20265 RVA: 0x0017F330 File Offset: 0x0017D530
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 174904, XrefRangeEnd = 174907, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Target_ReturnSaveRequest_214505783(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref channel;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_RpcReader___Target_ReturnSaveRequest_214505783_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004F2A RID: 20266 RVA: 0x0017F380 File Offset: 0x0017D580
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 174907, XrefRangeEnd = 174916, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_HostExitedGame_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_RpcWriter___Observers_HostExitedGame_2166136261_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004F2B RID: 20267 RVA: 0x0017F3B4 File Offset: 0x0017D5B4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 174942, RefRangeEnd = 174945, XrefRangeStart = 174916, XrefRangeEnd = 174942, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___HostExitedGame_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_RpcLogic___HostExitedGame_2166136261_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004F2C RID: 20268 RVA: 0x0017F3E8 File Offset: 0x0017D5E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 174945, XrefRangeEnd = 174948, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_HostExitedGame_2166136261(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref channel;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_RpcReader___Observers_HostExitedGame_2166136261_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004F2D RID: 20269 RVA: 0x0017F438 File Offset: 0x0017D638
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 174962, RefRangeEnd = 174964, XrefRangeStart = 174948, XrefRangeEnd = 174962, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_SendPlayerNameData_586648380(string playerName, ulong id)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(playerName);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref id;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_RpcWriter___Server_SendPlayerNameData_586648380_Private_Void_String_UInt64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004F2E RID: 20270 RVA: 0x0017F488 File Offset: 0x0017D688
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 174983, RefRangeEnd = 174986, XrefRangeStart = 174964, XrefRangeEnd = 174983, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SendPlayerNameData_586648380(string playerName, ulong id)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(playerName);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref id;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_RpcLogic___SendPlayerNameData_586648380_Public_Void_String_UInt64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004F2F RID: 20271 RVA: 0x0017F4D8 File Offset: 0x0017D6D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 174986, XrefRangeEnd = 174992, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_SendPlayerNameData_586648380(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref channel;
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_RpcReader___Server_SendPlayerNameData_586648380_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004F30 RID: 20272 RVA: 0x0017F53C File Offset: 0x0017D73C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_RequestPlayerData_3615296227(string playerCode)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(playerCode);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_RpcWriter___Server_RequestPlayerData_3615296227_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004F31 RID: 20273 RVA: 0x0017F580 File Offset: 0x0017D780
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 175018, RefRangeEnd = 175019, XrefRangeStart = 174992, XrefRangeEnd = 175018, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___RequestPlayerData_3615296227(string playerCode)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(playerCode);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_RpcLogic___RequestPlayerData_3615296227_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004F32 RID: 20274 RVA: 0x0017F5C4 File Offset: 0x0017D7C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 175019, XrefRangeEnd = 175022, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_RequestPlayerData_3615296227(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref channel;
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_RpcReader___Server_RequestPlayerData_3615296227_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004F33 RID: 20275 RVA: 0x0017F628 File Offset: 0x0017D828
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 175022, XrefRangeEnd = 175033, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_MarkPlayerInitialized_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_RpcWriter___Server_MarkPlayerInitialized_2166136261_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004F34 RID: 20276 RVA: 0x0017F65C File Offset: 0x0017D85C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 175040, RefRangeEnd = 175043, XrefRangeStart = 175033, XrefRangeEnd = 175040, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___MarkPlayerInitialized_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_RpcLogic___MarkPlayerInitialized_2166136261_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004F35 RID: 20277 RVA: 0x0017F690 File Offset: 0x0017D890
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 175043, XrefRangeEnd = 175047, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_MarkPlayerInitialized_2166136261(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref channel;
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_RpcReader___Server_MarkPlayerInitialized_2166136261_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004F36 RID: 20278 RVA: 0x0017F6F4 File Offset: 0x0017D8F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 175047, XrefRangeEnd = 175061, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_ReceivePlayerData_3244732873(NetworkConnection conn, PlayerData data, string inventoryString, string appearanceString, string clothigString, Il2CppReferenceArray<VariableData> vars)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)6) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(data);
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(inventoryString);
			ptr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(appearanceString);
			ptr[checked(unchecked((System.UIntPtr)4) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(clothigString);
			ptr[checked(unchecked((System.UIntPtr)5) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(vars);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_RpcWriter___Observers_ReceivePlayerData_3244732873_Private_Void_NetworkConnection_PlayerData_String_String_String_Il2CppReferenceArray_1_VariableData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004F37 RID: 20279 RVA: 0x0017F794 File Offset: 0x0017D994
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 175076, RefRangeEnd = 175079, XrefRangeStart = 175061, XrefRangeEnd = 175076, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___ReceivePlayerData_3244732873(NetworkConnection conn, PlayerData data, string inventoryString, string appearanceString, string clothigString, Il2CppReferenceArray<VariableData> vars)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)6) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(data);
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(inventoryString);
			ptr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(appearanceString);
			ptr[checked(unchecked((System.UIntPtr)4) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(clothigString);
			ptr[checked(unchecked((System.UIntPtr)5) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(vars);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_RpcLogic___ReceivePlayerData_3244732873_Public_Void_NetworkConnection_PlayerData_String_String_String_Il2CppReferenceArray_1_VariableData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004F38 RID: 20280 RVA: 0x0017F834 File Offset: 0x0017DA34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 175079, XrefRangeEnd = 175087, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_ReceivePlayerData_3244732873(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref channel;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_RpcReader___Observers_ReceivePlayerData_3244732873_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004F39 RID: 20281 RVA: 0x0017F884 File Offset: 0x0017DA84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 175087, XrefRangeEnd = 175101, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Target_ReceivePlayerData_3244732873(NetworkConnection conn, PlayerData data, string inventoryString, string appearanceString, string clothigString, Il2CppReferenceArray<VariableData> vars)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)6) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(data);
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(inventoryString);
			ptr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(appearanceString);
			ptr[checked(unchecked((System.UIntPtr)4) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(clothigString);
			ptr[checked(unchecked((System.UIntPtr)5) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(vars);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_RpcWriter___Target_ReceivePlayerData_3244732873_Private_Void_NetworkConnection_PlayerData_String_String_String_Il2CppReferenceArray_1_VariableData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004F3A RID: 20282 RVA: 0x0017F924 File Offset: 0x0017DB24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 175101, XrefRangeEnd = 175109, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Target_ReceivePlayerData_3244732873(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref channel;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_RpcReader___Target_ReceivePlayerData_3244732873_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004F3B RID: 20283 RVA: 0x0017F974 File Offset: 0x0017DB74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 175109, XrefRangeEnd = 175120, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_ReceivePlayerNameData_3895153758(NetworkConnection conn, string playerName, string id)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(playerName);
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(id);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_RpcWriter___Observers_ReceivePlayerNameData_3895153758_Private_Void_NetworkConnection_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004F3C RID: 20284 RVA: 0x0017F9DC File Offset: 0x0017DBDC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 175132, RefRangeEnd = 175135, XrefRangeStart = 175120, XrefRangeEnd = 175132, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___ReceivePlayerNameData_3895153758(NetworkConnection conn, string playerName, string id)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(playerName);
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(id);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_RpcLogic___ReceivePlayerNameData_3895153758_Private_Void_NetworkConnection_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004F3D RID: 20285 RVA: 0x0017FA44 File Offset: 0x0017DC44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 175135, XrefRangeEnd = 175140, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_ReceivePlayerNameData_3895153758(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref channel;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_RpcReader___Observers_ReceivePlayerNameData_3895153758_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004F3E RID: 20286 RVA: 0x0017FA94 File Offset: 0x0017DC94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 175140, XrefRangeEnd = 175151, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Target_ReceivePlayerNameData_3895153758(NetworkConnection conn, string playerName, string id)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(playerName);
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(id);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_RpcWriter___Target_ReceivePlayerNameData_3895153758_Private_Void_NetworkConnection_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004F3F RID: 20287 RVA: 0x0017FAFC File Offset: 0x0017DCFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 175151, XrefRangeEnd = 175156, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Target_ReceivePlayerNameData_3895153758(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref channel;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_RpcReader___Target_ReceivePlayerNameData_3895153758_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004F40 RID: 20288 RVA: 0x0017FB4C File Offset: 0x0017DD4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 175156, XrefRangeEnd = 175166, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_SendFlashlightOnNetworked_1140765316(bool on)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref on;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_RpcWriter___Server_SendFlashlightOnNetworked_1140765316_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004F41 RID: 20289 RVA: 0x0017FB8C File Offset: 0x0017DD8C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 172061, RefRangeEnd = 172064, XrefRangeStart = 172061, XrefRangeEnd = 172064, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SendFlashlightOnNetworked_1140765316(bool on)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref on;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_RpcLogic___SendFlashlightOnNetworked_1140765316_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004F42 RID: 20290 RVA: 0x0017FBCC File Offset: 0x0017DDCC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 175166, XrefRangeEnd = 175169, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_SendFlashlightOnNetworked_1140765316(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref channel;
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_RpcReader___Server_SendFlashlightOnNetworked_1140765316_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004F43 RID: 20291 RVA: 0x0017FC30 File Offset: 0x0017DE30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 175169, XrefRangeEnd = 175179, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_SetFlashlightOn_1140765316(bool on)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref on;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_RpcWriter___Observers_SetFlashlightOn_1140765316_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004F44 RID: 20292 RVA: 0x0017FC70 File Offset: 0x0017DE70
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 175184, RefRangeEnd = 175185, XrefRangeStart = 175179, XrefRangeEnd = 175184, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SetFlashlightOn_1140765316(bool on)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref on;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_RpcLogic___SetFlashlightOn_1140765316_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004F45 RID: 20293 RVA: 0x0017FCB0 File Offset: 0x0017DEB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 175185, XrefRangeEnd = 175188, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_SetFlashlightOn_1140765316(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref channel;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_RpcReader___Observers_SetFlashlightOn_1140765316_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004F46 RID: 20294 RVA: 0x0017FD00 File Offset: 0x0017DF00
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 172344, RefRangeEnd = 172345, XrefRangeStart = 172344, XrefRangeEnd = 172345, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_PlayJumpAnimation_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_RpcWriter___Observers_PlayJumpAnimation_2166136261_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004F47 RID: 20295 RVA: 0x0017FD34 File Offset: 0x0017DF34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 175188, XrefRangeEnd = 175190, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___PlayJumpAnimation_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_RpcLogic___PlayJumpAnimation_2166136261_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004F48 RID: 20296 RVA: 0x0017FD68 File Offset: 0x0017DF68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 175190, XrefRangeEnd = 175192, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_PlayJumpAnimation_2166136261(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref channel;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_RpcReader___Observers_PlayJumpAnimation_2166136261_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004F49 RID: 20297 RVA: 0x0017FDB8 File Offset: 0x0017DFB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 175192, XrefRangeEnd = 175202, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_SendCrouched_1140765316(bool crouched)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref crouched;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_RpcWriter___Server_SendCrouched_1140765316_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004F4A RID: 20298 RVA: 0x0017FDF8 File Offset: 0x0017DFF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 175202, XrefRangeEnd = 175203, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SendCrouched_1140765316(bool crouched)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref crouched;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_RpcLogic___SendCrouched_1140765316_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004F4B RID: 20299 RVA: 0x0017FE38 File Offset: 0x0017E038
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 175203, XrefRangeEnd = 175206, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_SendCrouched_1140765316(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref channel;
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_RpcReader___Server_SendCrouched_1140765316_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004F4C RID: 20300 RVA: 0x0017FE9C File Offset: 0x0017E09C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 175206, XrefRangeEnd = 175216, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Target_ReceiveCrouched_214505783(NetworkConnection conn, bool crouched)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref crouched;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_RpcWriter___Target_ReceiveCrouched_214505783_Private_Void_NetworkConnection_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004F4D RID: 20301 RVA: 0x0017FEEC File Offset: 0x0017E0EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 175216, XrefRangeEnd = 175218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___ReceiveCrouched_214505783(NetworkConnection conn, bool crouched)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref crouched;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_RpcLogic___ReceiveCrouched_214505783_Private_Void_NetworkConnection_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004F4E RID: 20302 RVA: 0x0017FF3C File Offset: 0x0017E13C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 175218, XrefRangeEnd = 175222, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Target_ReceiveCrouched_214505783(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref channel;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_RpcReader___Target_ReceiveCrouched_214505783_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004F4F RID: 20303 RVA: 0x0017FF8C File Offset: 0x0017E18C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 175222, XrefRangeEnd = 175232, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_ReceiveCrouched_214505783(NetworkConnection conn, bool crouched)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref crouched;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_RpcWriter___Observers_ReceiveCrouched_214505783_Private_Void_NetworkConnection_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004F50 RID: 20304 RVA: 0x0017FFDC File Offset: 0x0017E1DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 175232, XrefRangeEnd = 175236, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_ReceiveCrouched_214505783(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref channel;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_RpcReader___Observers_ReceiveCrouched_214505783_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004F51 RID: 20305 RVA: 0x0018002C File Offset: 0x0017E22C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 175236, XrefRangeEnd = 175248, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_SendAvatarSettings_4281687581(AvatarSettings settings)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(settings);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_RpcWriter___Server_SendAvatarSettings_4281687581_Private_Void_AvatarSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004F52 RID: 20306 RVA: 0x00180070 File Offset: 0x0017E270
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 172458, RefRangeEnd = 172461, XrefRangeStart = 172458, XrefRangeEnd = 172461, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SendAvatarSettings_4281687581(AvatarSettings settings)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(settings);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_RpcLogic___SendAvatarSettings_4281687581_Public_Void_AvatarSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004F53 RID: 20307 RVA: 0x001800B4 File Offset: 0x0017E2B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 175248, XrefRangeEnd = 175253, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_SendAvatarSettings_4281687581(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref channel;
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_RpcReader___Server_SendAvatarSettings_4281687581_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004F54 RID: 20308 RVA: 0x00180118 File Offset: 0x0017E318
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 175253, XrefRangeEnd = 175263, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_SetAvatarSettings_4281687581(AvatarSettings settings)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(settings);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_RpcWriter___Observers_SetAvatarSettings_4281687581_Private_Void_AvatarSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004F55 RID: 20309 RVA: 0x0018015C File Offset: 0x0017E35C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 175270, RefRangeEnd = 175273, XrefRangeStart = 175263, XrefRangeEnd = 175270, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SetAvatarSettings_4281687581(AvatarSettings settings)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(settings);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_RpcLogic___SetAvatarSettings_4281687581_Public_Void_AvatarSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004F56 RID: 20310 RVA: 0x001801A0 File Offset: 0x0017E3A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 175273, XrefRangeEnd = 175277, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_SetAvatarSettings_4281687581(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref channel;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_RpcReader___Observers_SetAvatarSettings_4281687581_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004F57 RID: 20311 RVA: 0x001801F0 File Offset: 0x0017E3F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_SetVisible_Networked_1140765316(bool vis)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref vis;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_RpcWriter___Observers_SetVisible_Networked_1140765316_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004F58 RID: 20312 RVA: 0x00180230 File Offset: 0x0017E430
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 175277, XrefRangeEnd = 175280, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SetVisible_Networked_1140765316(bool vis)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref vis;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_RpcLogic___SetVisible_Networked_1140765316_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004F59 RID: 20313 RVA: 0x00180270 File Offset: 0x0017E470
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 175280, XrefRangeEnd = 175283, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_SetVisible_Networked_1140765316(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref channel;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_RpcReader___Observers_SetVisible_Networked_1140765316_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004F5A RID: 20314 RVA: 0x001802C0 File Offset: 0x0017E4C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 175283, XrefRangeEnd = 175293, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_SetReadyToSleep_1140765316(bool ready)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref ready;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_RpcWriter___Server_SetReadyToSleep_1140765316_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004F5B RID: 20315 RVA: 0x00180300 File Offset: 0x0017E500
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 171165, RefRangeEnd = 171167, XrefRangeStart = 171165, XrefRangeEnd = 171167, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SetReadyToSleep_1140765316(bool ready)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref ready;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_RpcLogic___SetReadyToSleep_1140765316_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004F5C RID: 20316 RVA: 0x00180340 File Offset: 0x0017E540
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 175293, XrefRangeEnd = 175296, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_SetReadyToSleep_1140765316(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref channel;
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_RpcReader___Server_SetReadyToSleep_1140765316_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004F5D RID: 20317 RVA: 0x001803A4 File Offset: 0x0017E5A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 175296, XrefRangeEnd = 175306, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_SetPlayerCode_3615296227(string code)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(code);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_RpcWriter___Observers_SetPlayerCode_3615296227_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004F5E RID: 20318 RVA: 0x001803E8 File Offset: 0x0017E5E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 175306, XrefRangeEnd = 175307, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SetPlayerCode_3615296227(string code)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(code);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_RpcLogic___SetPlayerCode_3615296227_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004F5F RID: 20319 RVA: 0x0018042C File Offset: 0x0017E62C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 175307, XrefRangeEnd = 175311, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_SetPlayerCode_3615296227(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref channel;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_RpcReader___Observers_SetPlayerCode_3615296227_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004F60 RID: 20320 RVA: 0x0018047C File Offset: 0x0017E67C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 172763, RefRangeEnd = 172764, XrefRangeStart = 172763, XrefRangeEnd = 172764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_SendPunch_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_RpcWriter___Server_SendPunch_2166136261_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004F61 RID: 20321 RVA: 0x001804B0 File Offset: 0x0017E6B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SendPunch_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_RpcLogic___SendPunch_2166136261_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004F62 RID: 20322 RVA: 0x001804E4 File Offset: 0x0017E6E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 175311, XrefRangeEnd = 175330, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_SendPunch_2166136261(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref channel;
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_RpcReader___Server_SendPunch_2166136261_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004F63 RID: 20323 RVA: 0x00180548 File Offset: 0x0017E748
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_Punch_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_RpcWriter___Observers_Punch_2166136261_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004F64 RID: 20324 RVA: 0x0018057C File Offset: 0x0017E77C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 175330, XrefRangeEnd = 175334, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___Punch_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_RpcLogic___Punch_2166136261_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004F65 RID: 20325 RVA: 0x001805B0 File Offset: 0x0017E7B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 175334, XrefRangeEnd = 175339, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_Punch_2166136261(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref channel;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_RpcReader___Observers_Punch_2166136261_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004F66 RID: 20326 RVA: 0x00180600 File Offset: 0x0017E800
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 175339, XrefRangeEnd = 175351, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_MarkIntroCompleted_3281254764(BasicAvatarSettings appearance)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(appearance);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_RpcWriter___Server_MarkIntroCompleted_3281254764_Private_Void_BasicAvatarSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004F67 RID: 20327 RVA: 0x00180644 File Offset: 0x0017E844
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 175359, RefRangeEnd = 175361, XrefRangeStart = 175351, XrefRangeEnd = 175359, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___MarkIntroCompleted_3281254764(BasicAvatarSettings appearance)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(appearance);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_RpcLogic___MarkIntroCompleted_3281254764_Private_Void_BasicAvatarSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004F68 RID: 20328 RVA: 0x00180688 File Offset: 0x0017E888
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 175361, XrefRangeEnd = 175366, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_MarkIntroCompleted_3281254764(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref channel;
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_RpcReader___Server_MarkIntroCompleted_3281254764_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004F69 RID: 20329 RVA: 0x001806EC File Offset: 0x0017E8EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 175366, XrefRangeEnd = 175376, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_SendImpact_427288424(Impact impact)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(impact);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_RpcWriter___Server_SendImpact_427288424_Private_Void_Impact_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004F6A RID: 20330 RVA: 0x00180730 File Offset: 0x0017E930
		[CallerCount(0)]
		public unsafe virtual void RpcLogic___SendImpact_427288424(Impact impact)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(impact);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Player.NativeMethodInfoPtr_RpcLogic___SendImpact_427288424_Public_Virtual_New_Void_Impact_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004F6B RID: 20331 RVA: 0x00180780 File Offset: 0x0017E980
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 175376, XrefRangeEnd = 175379, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_SendImpact_427288424(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref channel;
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_RpcReader___Server_SendImpact_427288424_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004F6C RID: 20332 RVA: 0x001807E4 File Offset: 0x0017E9E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 175379, XrefRangeEnd = 175389, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_ReceiveImpact_427288424(Impact impact)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(impact);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_RpcWriter___Observers_ReceiveImpact_427288424_Private_Void_Impact_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004F6D RID: 20333 RVA: 0x00180828 File Offset: 0x0017EA28
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 175404, RefRangeEnd = 175406, XrefRangeStart = 175389, XrefRangeEnd = 175404, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void RpcLogic___ReceiveImpact_427288424(Impact impact)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(impact);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Player.NativeMethodInfoPtr_RpcLogic___ReceiveImpact_427288424_Public_Virtual_New_Void_Impact_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004F6E RID: 20334 RVA: 0x00180878 File Offset: 0x0017EA78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 175406, XrefRangeEnd = 175410, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_ReceiveImpact_427288424(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref channel;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_RpcReader___Observers_ReceiveImpact_427288424_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004F6F RID: 20335 RVA: 0x001808C8 File Offset: 0x0017EAC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 175410, XrefRangeEnd = 175419, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_Arrest_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_RpcWriter___Observers_Arrest_2166136261_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004F70 RID: 20336 RVA: 0x001808FC File Offset: 0x0017EAFC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 175444, RefRangeEnd = 175446, XrefRangeStart = 175419, XrefRangeEnd = 175444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___Arrest_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_RpcLogic___Arrest_2166136261_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004F71 RID: 20337 RVA: 0x00180930 File Offset: 0x0017EB30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 175446, XrefRangeEnd = 175449, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_Arrest_2166136261(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref channel;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_RpcReader___Observers_Arrest_2166136261_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004F72 RID: 20338 RVA: 0x00180980 File Offset: 0x0017EB80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 175449, XrefRangeEnd = 175460, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_SendPassOut_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_RpcWriter___Server_SendPassOut_2166136261_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004F73 RID: 20339 RVA: 0x001809B4 File Offset: 0x0017EBB4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 173425, RefRangeEnd = 173427, XrefRangeStart = 173425, XrefRangeEnd = 173427, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SendPassOut_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_RpcLogic___SendPassOut_2166136261_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004F74 RID: 20340 RVA: 0x001809E8 File Offset: 0x0017EBE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 175460, XrefRangeEnd = 175464, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_SendPassOut_2166136261(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref channel;
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_RpcReader___Server_SendPassOut_2166136261_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004F75 RID: 20341 RVA: 0x00180A4C File Offset: 0x0017EC4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 175464, XrefRangeEnd = 175473, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_PassOut_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_RpcWriter___Observers_PassOut_2166136261_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004F76 RID: 20342 RVA: 0x00180A80 File Offset: 0x0017EC80
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 175496, RefRangeEnd = 175499, XrefRangeStart = 175473, XrefRangeEnd = 175496, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___PassOut_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_RpcLogic___PassOut_2166136261_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004F77 RID: 20343 RVA: 0x00180AB4 File Offset: 0x0017ECB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 175499, XrefRangeEnd = 175502, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_PassOut_2166136261(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref channel;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_RpcReader___Observers_PassOut_2166136261_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004F78 RID: 20344 RVA: 0x00180B04 File Offset: 0x0017ED04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 175502, XrefRangeEnd = 175513, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_SendPassOutRecovery_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_RpcWriter___Server_SendPassOutRecovery_2166136261_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004F79 RID: 20345 RVA: 0x00180B38 File Offset: 0x0017ED38
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 173481, RefRangeEnd = 173483, XrefRangeStart = 173481, XrefRangeEnd = 173483, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SendPassOutRecovery_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_RpcLogic___SendPassOutRecovery_2166136261_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004F7A RID: 20346 RVA: 0x00180B6C File Offset: 0x0017ED6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 175513, XrefRangeEnd = 175517, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_SendPassOutRecovery_2166136261(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref channel;
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_RpcReader___Server_SendPassOutRecovery_2166136261_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004F7B RID: 20347 RVA: 0x00180BD0 File Offset: 0x0017EDD0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 175517, XrefRangeEnd = 175526, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_PassOutRecovery_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_RpcWriter___Observers_PassOutRecovery_2166136261_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004F7C RID: 20348 RVA: 0x00180C04 File Offset: 0x0017EE04
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 175549, RefRangeEnd = 175552, XrefRangeStart = 175526, XrefRangeEnd = 175549, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___PassOutRecovery_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_RpcLogic___PassOutRecovery_2166136261_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004F7D RID: 20349 RVA: 0x00180C38 File Offset: 0x0017EE38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 175552, XrefRangeEnd = 175555, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_PassOutRecovery_2166136261(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref channel;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_RpcReader___Observers_PassOutRecovery_2166136261_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004F7E RID: 20350 RVA: 0x00180C88 File Offset: 0x0017EE88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 175555, XrefRangeEnd = 175565, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_SendEquippable_Networked_3615296227(string assetPath)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(assetPath);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_RpcWriter___Server_SendEquippable_Networked_3615296227_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004F7F RID: 20351 RVA: 0x00180CCC File Offset: 0x0017EECC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 173532, RefRangeEnd = 173534, XrefRangeStart = 173532, XrefRangeEnd = 173534, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SendEquippable_Networked_3615296227(string assetPath)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(assetPath);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_RpcLogic___SendEquippable_Networked_3615296227_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004F80 RID: 20352 RVA: 0x00180D10 File Offset: 0x0017EF10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 175565, XrefRangeEnd = 175569, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_SendEquippable_Networked_3615296227(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref channel;
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_RpcReader___Server_SendEquippable_Networked_3615296227_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004F81 RID: 20353 RVA: 0x00180D74 File Offset: 0x0017EF74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 175569, XrefRangeEnd = 175579, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_SetEquippable_Networked_3615296227(string assetPath)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(assetPath);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_RpcWriter___Observers_SetEquippable_Networked_3615296227_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004F82 RID: 20354 RVA: 0x00180DB8 File Offset: 0x0017EFB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 175579, XrefRangeEnd = 175580, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SetEquippable_Networked_3615296227(string assetPath)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(assetPath);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_RpcLogic___SetEquippable_Networked_3615296227_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004F83 RID: 20355 RVA: 0x00180DFC File Offset: 0x0017EFFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 175580, XrefRangeEnd = 175583, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_SetEquippable_Networked_3615296227(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref channel;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_RpcReader___Observers_SetEquippable_Networked_3615296227_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004F84 RID: 20356 RVA: 0x00180E4C File Offset: 0x0017F04C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 175597, RefRangeEnd = 175598, XrefRangeStart = 175583, XrefRangeEnd = 175597, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_SendEquippableMessage_Networked_3643459082(string message, int receipt)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref receipt;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_RpcWriter___Server_SendEquippableMessage_Networked_3643459082_Private_Void_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004F85 RID: 20357 RVA: 0x00180E9C File Offset: 0x0017F09C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 173561, RefRangeEnd = 173563, XrefRangeStart = 173561, XrefRangeEnd = 173563, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SendEquippableMessage_Networked_3643459082(string message, int receipt)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref receipt;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_RpcLogic___SendEquippableMessage_Networked_3643459082_Public_Void_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004F86 RID: 20358 RVA: 0x00180EEC File Offset: 0x0017F0EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 175598, XrefRangeEnd = 175605, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_SendEquippableMessage_Networked_3643459082(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref channel;
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_RpcReader___Server_SendEquippableMessage_Networked_3643459082_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004F87 RID: 20359 RVA: 0x00180F50 File Offset: 0x0017F150
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 175605, XrefRangeEnd = 175617, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_ReceiveEquippableMessage_Networked_3643459082(string message, int receipt)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref receipt;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_RpcWriter___Observers_ReceiveEquippableMessage_Networked_3643459082_Private_Void_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004F88 RID: 20360 RVA: 0x00180FA0 File Offset: 0x0017F1A0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 175624, RefRangeEnd = 175627, XrefRangeStart = 175617, XrefRangeEnd = 175624, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___ReceiveEquippableMessage_Networked_3643459082(string message, int receipt)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref receipt;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_RpcLogic___ReceiveEquippableMessage_Networked_3643459082_Private_Void_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004F89 RID: 20361 RVA: 0x00180FF0 File Offset: 0x0017F1F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 175627, XrefRangeEnd = 175633, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_ReceiveEquippableMessage_Networked_3643459082(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref channel;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_RpcReader___Observers_ReceiveEquippableMessage_Networked_3643459082_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004F8A RID: 20362 RVA: 0x00181040 File Offset: 0x0017F240
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 175650, RefRangeEnd = 175651, XrefRangeStart = 175633, XrefRangeEnd = 175650, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_SendEquippableMessage_Networked_Vector_3190074053(string message, int receipt, Vector3 data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref receipt;
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref data;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_RpcWriter___Server_SendEquippableMessage_Networked_Vector_3190074053_Private_Void_String_Int32_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004F8B RID: 20363 RVA: 0x001810A0 File Offset: 0x0017F2A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 175651, XrefRangeEnd = 175652, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SendEquippableMessage_Networked_Vector_3190074053(string message, int receipt, Vector3 data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref receipt;
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref data;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_RpcLogic___SendEquippableMessage_Networked_Vector_3190074053_Public_Void_String_Int32_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004F8C RID: 20364 RVA: 0x00181100 File Offset: 0x0017F300
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 175652, XrefRangeEnd = 175662, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_SendEquippableMessage_Networked_Vector_3190074053(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref channel;
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_RpcReader___Server_SendEquippableMessage_Networked_Vector_3190074053_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004F8D RID: 20365 RVA: 0x00181164 File Offset: 0x0017F364
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 175662, XrefRangeEnd = 175677, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_ReceiveEquippableMessage_Networked_Vector_3190074053(string message, int receipt, Vector3 data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref receipt;
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref data;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_RpcWriter___Observers_ReceiveEquippableMessage_Networked_Vector_3190074053_Private_Void_String_Int32_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004F8E RID: 20366 RVA: 0x001811C4 File Offset: 0x0017F3C4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 175687, RefRangeEnd = 175689, XrefRangeStart = 175677, XrefRangeEnd = 175687, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___ReceiveEquippableMessage_Networked_Vector_3190074053(string message, int receipt, Vector3 data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref receipt;
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref data;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_RpcLogic___ReceiveEquippableMessage_Networked_Vector_3190074053_Private_Void_String_Int32_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004F8F RID: 20367 RVA: 0x00181224 File Offset: 0x0017F424
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 175689, XrefRangeEnd = 175698, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_ReceiveEquippableMessage_Networked_Vector_3190074053(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref channel;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_RpcReader___Observers_ReceiveEquippableMessage_Networked_Vector_3190074053_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004F90 RID: 20368 RVA: 0x00181274 File Offset: 0x0017F474
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 175698, XrefRangeEnd = 175710, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_SendAnimationTrigger_3615296227(string trigger)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(trigger);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_RpcWriter___Server_SendAnimationTrigger_3615296227_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004F91 RID: 20369 RVA: 0x001812B8 File Offset: 0x0017F4B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 175710, XrefRangeEnd = 175711, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SendAnimationTrigger_3615296227(string trigger)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(trigger);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_RpcLogic___SendAnimationTrigger_3615296227_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004F92 RID: 20370 RVA: 0x001812FC File Offset: 0x0017F4FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 175711, XrefRangeEnd = 175716, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_SendAnimationTrigger_3615296227(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref channel;
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_RpcReader___Server_SendAnimationTrigger_3615296227_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004F93 RID: 20371 RVA: 0x00181360 File Offset: 0x0017F560
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 175716, XrefRangeEnd = 175726, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_SetAnimationTrigger_Networked_2971853958(NetworkConnection conn, string trigger)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(trigger);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_RpcWriter___Observers_SetAnimationTrigger_Networked_2971853958_Private_Void_NetworkConnection_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004F94 RID: 20372 RVA: 0x001813B4 File Offset: 0x0017F5B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 175726, XrefRangeEnd = 175728, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SetAnimationTrigger_Networked_2971853958(NetworkConnection conn, string trigger)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(trigger);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_RpcLogic___SetAnimationTrigger_Networked_2971853958_Public_Void_NetworkConnection_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004F95 RID: 20373 RVA: 0x00181408 File Offset: 0x0017F608
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 175728, XrefRangeEnd = 175732, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_SetAnimationTrigger_Networked_2971853958(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref channel;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_RpcReader___Observers_SetAnimationTrigger_Networked_2971853958_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004F96 RID: 20374 RVA: 0x00181458 File Offset: 0x0017F658
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 175732, XrefRangeEnd = 175742, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Target_SetAnimationTrigger_Networked_2971853958(NetworkConnection conn, string trigger)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(trigger);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_RpcWriter___Target_SetAnimationTrigger_Networked_2971853958_Private_Void_NetworkConnection_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004F97 RID: 20375 RVA: 0x001814AC File Offset: 0x0017F6AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 175742, XrefRangeEnd = 175746, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Target_SetAnimationTrigger_Networked_2971853958(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref channel;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_RpcReader___Target_SetAnimationTrigger_Networked_2971853958_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004F98 RID: 20376 RVA: 0x001814FC File Offset: 0x0017F6FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 175746, XrefRangeEnd = 175756, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_ResetAnimationTrigger_Networked_2971853958(NetworkConnection conn, string trigger)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(trigger);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_RpcWriter___Observers_ResetAnimationTrigger_Networked_2971853958_Private_Void_NetworkConnection_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004F99 RID: 20377 RVA: 0x00181550 File Offset: 0x0017F750
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 175756, XrefRangeEnd = 175758, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___ResetAnimationTrigger_Networked_2971853958(NetworkConnection conn, string trigger)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(trigger);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_RpcLogic___ResetAnimationTrigger_Networked_2971853958_Public_Void_NetworkConnection_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004F9A RID: 20378 RVA: 0x001815A4 File Offset: 0x0017F7A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 175758, XrefRangeEnd = 175762, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_ResetAnimationTrigger_Networked_2971853958(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref channel;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_RpcReader___Observers_ResetAnimationTrigger_Networked_2971853958_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004F9B RID: 20379 RVA: 0x001815F4 File Offset: 0x0017F7F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 175762, XrefRangeEnd = 175772, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Target_ResetAnimationTrigger_Networked_2971853958(NetworkConnection conn, string trigger)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(trigger);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_RpcWriter___Target_ResetAnimationTrigger_Networked_2971853958_Private_Void_NetworkConnection_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004F9C RID: 20380 RVA: 0x00181648 File Offset: 0x0017F848
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 175772, XrefRangeEnd = 175776, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Target_ResetAnimationTrigger_Networked_2971853958(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref channel;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_RpcReader___Target_ResetAnimationTrigger_Networked_2971853958_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004F9D RID: 20381 RVA: 0x00181698 File Offset: 0x0017F898
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 175789, RefRangeEnd = 175790, XrefRangeStart = 175776, XrefRangeEnd = 175789, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_SendAnimationBool_310431262(string name, bool val)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref val;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_RpcWriter___Server_SendAnimationBool_310431262_Private_Void_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004F9E RID: 20382 RVA: 0x001816E8 File Offset: 0x0017F8E8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 173686, RefRangeEnd = 173688, XrefRangeStart = 173686, XrefRangeEnd = 173688, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SendAnimationBool_310431262(string name, bool val)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref val;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_RpcLogic___SendAnimationBool_310431262_Public_Void_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004F9F RID: 20383 RVA: 0x00181738 File Offset: 0x0017F938
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 175790, XrefRangeEnd = 175795, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_SendAnimationBool_310431262(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref channel;
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_RpcReader___Server_SendAnimationBool_310431262_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004FA0 RID: 20384 RVA: 0x0018179C File Offset: 0x0017F99C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 175795, XrefRangeEnd = 175806, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_SetAnimationBool_310431262(string name, bool val)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref val;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_RpcWriter___Observers_SetAnimationBool_310431262_Private_Void_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004FA1 RID: 20385 RVA: 0x001817EC File Offset: 0x0017F9EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 175806, XrefRangeEnd = 175808, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SetAnimationBool_310431262(string name, bool val)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref val;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_RpcLogic___SetAnimationBool_310431262_Public_Void_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004FA2 RID: 20386 RVA: 0x0018183C File Offset: 0x0017FA3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 175808, XrefRangeEnd = 175812, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_SetAnimationBool_310431262(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref channel;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_RpcReader___Observers_SetAnimationBool_310431262_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004FA3 RID: 20387 RVA: 0x0018188C File Offset: 0x0017FA8C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 173697, RefRangeEnd = 173698, XrefRangeStart = 173697, XrefRangeEnd = 173698, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_Taze_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_RpcWriter___Observers_Taze_2166136261_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004FA4 RID: 20388 RVA: 0x001818C0 File Offset: 0x0017FAC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 175812, XrefRangeEnd = 175822, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___Taze_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_RpcLogic___Taze_2166136261_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004FA5 RID: 20389 RVA: 0x001818F4 File Offset: 0x0017FAF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 175822, XrefRangeEnd = 175832, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_Taze_2166136261(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref channel;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_RpcReader___Observers_Taze_2166136261_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004FA6 RID: 20390 RVA: 0x00181944 File Offset: 0x0017FB44
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 175846, RefRangeEnd = 175847, XrefRangeStart = 175832, XrefRangeEnd = 175846, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_SetInventoryItem_2317364410(int index, ItemInstance item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref index;
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(item);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_RpcWriter___Server_SetInventoryItem_2317364410_Private_Void_Int32_ItemInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004FA7 RID: 20391 RVA: 0x00181994 File Offset: 0x0017FB94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 175847, XrefRangeEnd = 175849, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SetInventoryItem_2317364410(int index, ItemInstance item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref index;
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(item);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_RpcLogic___SetInventoryItem_2317364410_Public_Void_Int32_ItemInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004FA8 RID: 20392 RVA: 0x001819E4 File Offset: 0x0017FBE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 175849, XrefRangeEnd = 175855, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_SetInventoryItem_2317364410(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref channel;
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_RpcReader___Server_SetInventoryItem_2317364410_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004FA9 RID: 20393 RVA: 0x00181A48 File Offset: 0x0017FC48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 175855, XrefRangeEnd = 175867, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_SendAppearance_3281254764(BasicAvatarSettings settings)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(settings);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_RpcWriter___Server_SendAppearance_3281254764_Private_Void_BasicAvatarSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004FAA RID: 20394 RVA: 0x00181A8C File Offset: 0x0017FC8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 175867, XrefRangeEnd = 175868, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SendAppearance_3281254764(BasicAvatarSettings settings)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(settings);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_RpcLogic___SendAppearance_3281254764_Public_Void_BasicAvatarSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004FAB RID: 20395 RVA: 0x00181AD0 File Offset: 0x0017FCD0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 175868, XrefRangeEnd = 175873, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_SendAppearance_3281254764(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref channel;
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_RpcReader___Server_SendAppearance_3281254764_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004FAC RID: 20396 RVA: 0x00181B34 File Offset: 0x0017FD34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 175873, XrefRangeEnd = 175884, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_SetAppearance_2139595489(BasicAvatarSettings settings, bool refreshClothing)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(settings);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref refreshClothing;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_RpcWriter___Observers_SetAppearance_2139595489_Private_Void_BasicAvatarSettings_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004FAD RID: 20397 RVA: 0x00181B84 File Offset: 0x0017FD84
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 175890, RefRangeEnd = 175892, XrefRangeStart = 175884, XrefRangeEnd = 175890, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SetAppearance_2139595489(BasicAvatarSettings settings, bool refreshClothing)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(settings);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref refreshClothing;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_RpcLogic___SetAppearance_2139595489_Public_Void_BasicAvatarSettings_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004FAE RID: 20398 RVA: 0x00181BD4 File Offset: 0x0017FDD4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 175892, XrefRangeEnd = 175896, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_SetAppearance_2139595489(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref channel;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_RpcReader___Observers_SetAppearance_2139595489_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004FAF RID: 20399 RVA: 0x00181C24 File Offset: 0x0017FE24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 175896, XrefRangeEnd = 175908, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_SendMountedSkateboard_3323014238(NetworkObject skateboardObj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(skateboardObj);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_RpcWriter___Server_SendMountedSkateboard_3323014238_Private_Void_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004FB0 RID: 20400 RVA: 0x00181C68 File Offset: 0x0017FE68
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 173899, RefRangeEnd = 173901, XrefRangeStart = 173899, XrefRangeEnd = 173901, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SendMountedSkateboard_3323014238(NetworkObject skateboardObj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(skateboardObj);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_RpcLogic___SendMountedSkateboard_3323014238_Private_Void_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004FB1 RID: 20401 RVA: 0x00181CAC File Offset: 0x0017FEAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 175908, XrefRangeEnd = 175913, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_SendMountedSkateboard_3323014238(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref channel;
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_RpcReader___Server_SendMountedSkateboard_3323014238_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004FB2 RID: 20402 RVA: 0x00181D10 File Offset: 0x0017FF10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 175913, XrefRangeEnd = 175923, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_SetMountedSkateboard_3323014238(NetworkObject skateboardObj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(skateboardObj);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_RpcWriter___Observers_SetMountedSkateboard_3323014238_Private_Void_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004FB3 RID: 20403 RVA: 0x00181D54 File Offset: 0x0017FF54
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 175946, RefRangeEnd = 175949, XrefRangeStart = 175923, XrefRangeEnd = 175946, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SetMountedSkateboard_3323014238(NetworkObject skateboardObj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(skateboardObj);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_RpcLogic___SetMountedSkateboard_3323014238_Private_Void_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004FB4 RID: 20404 RVA: 0x00181D98 File Offset: 0x0017FF98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 175949, XrefRangeEnd = 175953, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_SetMountedSkateboard_3323014238(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref channel;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_RpcReader___Observers_SetMountedSkateboard_3323014238_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004FB5 RID: 20405 RVA: 0x00181DE8 File Offset: 0x0017FFE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_SendConsumeProduct_2622925554(ProductItemInstance product)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(product);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_RpcWriter___Server_SendConsumeProduct_2622925554_Private_Void_ProductItemInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004FB6 RID: 20406 RVA: 0x00181E2C File Offset: 0x0018002C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SendConsumeProduct_2622925554(ProductItemInstance product)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(product);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_RpcLogic___SendConsumeProduct_2622925554_Private_Void_ProductItemInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004FB7 RID: 20407 RVA: 0x00181E70 File Offset: 0x00180070
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 175953, XrefRangeEnd = 175965, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_SendConsumeProduct_2622925554(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref channel;
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_RpcReader___Server_SendConsumeProduct_2622925554_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004FB8 RID: 20408 RVA: 0x00181ED4 File Offset: 0x001800D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_ReceiveConsumeProduct_2622925554(ProductItemInstance product)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(product);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_RpcWriter___Observers_ReceiveConsumeProduct_2622925554_Private_Void_ProductItemInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004FB9 RID: 20409 RVA: 0x00181F18 File Offset: 0x00180118
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 175965, XrefRangeEnd = 175968, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___ReceiveConsumeProduct_2622925554(ProductItemInstance product)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(product);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_RpcLogic___ReceiveConsumeProduct_2622925554_Private_Void_ProductItemInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004FBA RID: 20410 RVA: 0x00181F5C File Offset: 0x0018015C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 175968, XrefRangeEnd = 175973, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_ReceiveConsumeProduct_2622925554(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref channel;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_RpcReader___Observers_ReceiveConsumeProduct_2622925554_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004FBB RID: 20411 RVA: 0x00181FAC File Offset: 0x001801AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 175973, XrefRangeEnd = 175985, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_SendValue_3589193952(string variableName, string value, bool sendToOwner)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(variableName);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref sendToOwner;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_RpcWriter___Server_SendValue_3589193952_Private_Void_String_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004FBC RID: 20412 RVA: 0x00182010 File Offset: 0x00180210
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 176009, RefRangeEnd = 176011, XrefRangeStart = 175985, XrefRangeEnd = 176009, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SendValue_3589193952(string variableName, string value, bool sendToOwner)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(variableName);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref sendToOwner;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_RpcLogic___SendValue_3589193952_Public_Void_String_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004FBD RID: 20413 RVA: 0x00182074 File Offset: 0x00180274
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 176011, XrefRangeEnd = 176016, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_SendValue_3589193952(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref channel;
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_RpcReader___Server_SendValue_3589193952_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004FBE RID: 20414 RVA: 0x001820D8 File Offset: 0x001802D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Target_ReceiveValue_3895153758(NetworkConnection conn, string variableName, string value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(variableName);
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_RpcWriter___Target_ReceiveValue_3895153758_Private_Void_NetworkConnection_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004FBF RID: 20415 RVA: 0x00182140 File Offset: 0x00180340
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 176016, XrefRangeEnd = 176017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___ReceiveValue_3895153758(NetworkConnection conn, string variableName, string value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(variableName);
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_RpcLogic___ReceiveValue_3895153758_Private_Void_NetworkConnection_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004FC0 RID: 20416 RVA: 0x001821A8 File Offset: 0x001803A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 176017, XrefRangeEnd = 176022, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Target_ReceiveValue_3895153758(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref channel;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_RpcReader___Target_ReceiveValue_3895153758_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x170017F1 RID: 6129
		// (get) Token: 0x06004FC1 RID: 20417 RVA: 0x001821F8 File Offset: 0x001803F8
		// (set) Token: 0x06004FC2 RID: 20418 RVA: 0x00182230 File Offset: 0x00180430
		public unsafe string SyncAccessor_<PlayerName>k__BackingField
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 171044, RefRangeEnd = 171059, XrefRangeStart = 171044, XrefRangeEnd = 171059, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_sync___get_value__PlayerName_k__BackingField_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return IL2CPP.Il2CppStringToManaged(il2CppString);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 176031, RefRangeEnd = 176032, XrefRangeStart = 176022, XrefRangeEnd = 176031, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref value;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_sync___set_value__PlayerName_k__BackingField_Public_set_Void_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x06004FC3 RID: 20419 RVA: 0x00182280 File Offset: 0x00180480
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 176032, XrefRangeEnd = 176040, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool ReadSyncVar___ScheduleOne_PlayerScripts_Player(PooledReader PooledReader0, uint UInt321, bool Boolean2)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref UInt321;
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref Boolean2;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Player.NativeMethodInfoPtr_ReadSyncVar___ScheduleOne_PlayerScripts_Player_Public_Virtual_Boolean_PooledReader_UInt32_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x170017F2 RID: 6130
		// (get) Token: 0x06004FC4 RID: 20420 RVA: 0x001822F4 File Offset: 0x001804F4
		// (set) Token: 0x06004FC5 RID: 20421 RVA: 0x0018232C File Offset: 0x0018052C
		public unsafe string SyncAccessor_<PlayerCode>k__BackingField
		{
			[CallerCount(9)]
			[CachedScanResults(RefRangeStart = 171069, RefRangeEnd = 171078, XrefRangeStart = 171069, XrefRangeEnd = 171078, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_sync___get_value__PlayerCode_k__BackingField_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return IL2CPP.Il2CppStringToManaged(il2CppString);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 176040, XrefRangeEnd = 176049, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref value;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_sync___set_value__PlayerCode_k__BackingField_Public_set_Void_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x170017F3 RID: 6131
		// (get) Token: 0x06004FC6 RID: 20422 RVA: 0x0018237C File Offset: 0x0018057C
		// (set) Token: 0x06004FC7 RID: 20423 RVA: 0x001823BC File Offset: 0x001805BC
		public unsafe NetworkObject SyncAccessor_<CurrentVehicle>k__BackingField
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 171090, RefRangeEnd = 171104, XrefRangeStart = 171090, XrefRangeEnd = 171104, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_sync___get_value__CurrentVehicle_k__BackingField_Public_get_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NetworkObject>(intPtr2) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 176049, XrefRangeEnd = 176058, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref value;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_sync___set_value__CurrentVehicle_k__BackingField_Public_set_Void_NetworkObject_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x170017F4 RID: 6132
		// (get) Token: 0x06004FC8 RID: 20424 RVA: 0x0018240C File Offset: 0x0018060C
		// (set) Token: 0x06004FC9 RID: 20425 RVA: 0x0018244C File Offset: 0x0018064C
		public unsafe NetworkObject SyncAccessor_<CurrentBed>k__BackingField
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_sync___get_value__CurrentBed_k__BackingField_Public_get_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NetworkObject>(intPtr2) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 176058, XrefRangeEnd = 176067, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref value;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_sync___set_value__CurrentBed_k__BackingField_Public_set_Void_NetworkObject_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x170017F5 RID: 6133
		// (get) Token: 0x06004FCA RID: 20426 RVA: 0x0018249C File Offset: 0x0018069C
		// (set) Token: 0x06004FCB RID: 20427 RVA: 0x001824D8 File Offset: 0x001806D8
		public unsafe bool SyncAccessor_<IsReadyToSleep>k__BackingField
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 171155, RefRangeEnd = 171158, XrefRangeStart = 171155, XrefRangeEnd = 171158, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_sync___get_value__IsReadyToSleep_k__BackingField_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 176067, XrefRangeEnd = 176075, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = ref value;
				ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref value;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_sync___set_value__IsReadyToSleep_k__BackingField_Public_set_Void_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x170017F6 RID: 6134
		// (get) Token: 0x06004FCC RID: 20428 RVA: 0x00182524 File Offset: 0x00180724
		// (set) Token: 0x06004FCD RID: 20429 RVA: 0x00182560 File Offset: 0x00180760
		public unsafe Vector3 SyncAccessor_<CameraPosition>k__BackingField
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_sync___get_value__CameraPosition_k__BackingField_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 176075, XrefRangeEnd = 176083, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = ref value;
				ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref value;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_sync___set_value__CameraPosition_k__BackingField_Public_set_Void_Vector3_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x170017F7 RID: 6135
		// (get) Token: 0x06004FCE RID: 20430 RVA: 0x001825AC File Offset: 0x001807AC
		// (set) Token: 0x06004FCF RID: 20431 RVA: 0x001825E8 File Offset: 0x001807E8
		public unsafe Quaternion SyncAccessor_<CameraRotation>k__BackingField
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_sync___get_value__CameraRotation_k__BackingField_Public_get_Quaternion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 176083, XrefRangeEnd = 176091, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = ref value;
				ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref value;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_sync___set_value__CameraRotation_k__BackingField_Public_set_Void_Quaternion_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x06004FD0 RID: 20432 RVA: 0x00182634 File Offset: 0x00180834
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 176192, RefRangeEnd = 176193, XrefRangeStart = 176091, XrefRangeEnd = 176192, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Method_Protected_Virtual_New_Void_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Player.NativeMethodInfoPtr_Method_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004FD1 RID: 20433 RVA: 0x00025763 File Offset: 0x00023963
		public Player(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700175C RID: 5980
		// (get) Token: 0x06004FD2 RID: 20434 RVA: 0x00182670 File Offset: 0x00180870
		// (set) Token: 0x06004FD3 RID: 20435 RVA: 0x0002576C File Offset: 0x0002396C
		public unsafe static string OWNER_PLAYER_CODE
		{
			get
			{
				System.IntPtr il2CppString;
				IL2CPP.il2cpp_field_static_get_value(Player.NativeFieldInfoPtr_OWNER_PLAYER_CODE, (void*)(&il2CppString));
				return IL2CPP.Il2CppStringToManaged(il2CppString);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Player.NativeFieldInfoPtr_OWNER_PLAYER_CODE, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700175D RID: 5981
		// (get) Token: 0x06004FD4 RID: 20436 RVA: 0x00182690 File Offset: 0x00180890
		// (set) Token: 0x06004FD5 RID: 20437 RVA: 0x0002577E File Offset: 0x0002397E
		public unsafe static float CapColDefaultHeight
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(Player.NativeFieldInfoPtr_CapColDefaultHeight, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Player.NativeFieldInfoPtr_CapColDefaultHeight, (void*)(&value));
			}
		}

		// Token: 0x1700175E RID: 5982
		// (get) Token: 0x06004FD6 RID: 20438 RVA: 0x001826AC File Offset: 0x001808AC
		// (set) Token: 0x06004FD7 RID: 20439 RVA: 0x0002578C File Offset: 0x0002398C
		public unsafe List<NetworkObject> objectsTemporarilyOwnedByPlayer
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr_objectsTemporarilyOwnedByPlayer);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<NetworkObject>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr_objectsTemporarilyOwnedByPlayer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700175F RID: 5983
		// (get) Token: 0x06004FD8 RID: 20440 RVA: 0x001826DC File Offset: 0x001808DC
		// (set) Token: 0x06004FD9 RID: 20441 RVA: 0x000257AB File Offset: 0x000239AB
		public unsafe static Il2CppSystem.Action onLocalPlayerSpawned
		{
			get
			{
				System.IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Player.NativeFieldInfoPtr_onLocalPlayerSpawned, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Action>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Player.NativeFieldInfoPtr_onLocalPlayerSpawned, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001760 RID: 5984
		// (get) Token: 0x06004FDA RID: 20442 RVA: 0x00182704 File Offset: 0x00180904
		// (set) Token: 0x06004FDB RID: 20443 RVA: 0x000257BD File Offset: 0x000239BD
		public unsafe static Il2CppSystem.Action<Player> onPlayerSpawned
		{
			get
			{
				System.IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Player.NativeFieldInfoPtr_onPlayerSpawned, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Action<Player>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Player.NativeFieldInfoPtr_onPlayerSpawned, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001761 RID: 5985
		// (get) Token: 0x06004FDC RID: 20444 RVA: 0x0018272C File Offset: 0x0018092C
		// (set) Token: 0x06004FDD RID: 20445 RVA: 0x000257CF File Offset: 0x000239CF
		public unsafe static Il2CppSystem.Action<Player> onPlayerDespawned
		{
			get
			{
				System.IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Player.NativeFieldInfoPtr_onPlayerDespawned, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Action<Player>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Player.NativeFieldInfoPtr_onPlayerDespawned, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001762 RID: 5986
		// (get) Token: 0x06004FDE RID: 20446 RVA: 0x00182754 File Offset: 0x00180954
		// (set) Token: 0x06004FDF RID: 20447 RVA: 0x000257E1 File Offset: 0x000239E1
		public unsafe static Player Local
		{
			get
			{
				System.IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Player.NativeFieldInfoPtr_Local, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Player>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Player.NativeFieldInfoPtr_Local, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001763 RID: 5987
		// (get) Token: 0x06004FE0 RID: 20448 RVA: 0x0018277C File Offset: 0x0018097C
		// (set) Token: 0x06004FE1 RID: 20449 RVA: 0x000257F3 File Offset: 0x000239F3
		public unsafe static List<Player> PlayerList
		{
			get
			{
				System.IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Player.NativeFieldInfoPtr_PlayerList, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Player>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Player.NativeFieldInfoPtr_PlayerList, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001764 RID: 5988
		// (get) Token: 0x06004FE2 RID: 20450 RVA: 0x001827A4 File Offset: 0x001809A4
		// (set) Token: 0x06004FE3 RID: 20451 RVA: 0x00025805 File Offset: 0x00023A05
		public unsafe GameObject LocalGameObject
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr_LocalGameObject);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr_LocalGameObject), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001765 RID: 5989
		// (get) Token: 0x06004FE4 RID: 20452 RVA: 0x001827D4 File Offset: 0x001809D4
		// (set) Token: 0x06004FE5 RID: 20453 RVA: 0x00025824 File Offset: 0x00023A24
		public unsafe Il2CppScheduleOne.AvatarFramework.Avatar Avatar
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr_Avatar);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppScheduleOne.AvatarFramework.Avatar>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr_Avatar), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001766 RID: 5990
		// (get) Token: 0x06004FE6 RID: 20454 RVA: 0x00182804 File Offset: 0x00180A04
		// (set) Token: 0x06004FE7 RID: 20455 RVA: 0x00025843 File Offset: 0x00023A43
		public unsafe AvatarAnimation Anim
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr_Anim);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AvatarAnimation>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr_Anim), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001767 RID: 5991
		// (get) Token: 0x06004FE8 RID: 20456 RVA: 0x00182834 File Offset: 0x00180A34
		// (set) Token: 0x06004FE9 RID: 20457 RVA: 0x00025862 File Offset: 0x00023A62
		public unsafe SmoothedVelocityCalculator VelocityCalculator
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr_VelocityCalculator);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SmoothedVelocityCalculator>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr_VelocityCalculator), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001768 RID: 5992
		// (get) Token: 0x06004FEA RID: 20458 RVA: 0x00182864 File Offset: 0x00180A64
		// (set) Token: 0x06004FEB RID: 20459 RVA: 0x00025881 File Offset: 0x00023A81
		public unsafe Vector3 EyePosition
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr_EyePosition);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr_EyePosition)) = value;
			}
		}

		// Token: 0x17001769 RID: 5993
		// (get) Token: 0x06004FEC RID: 20460 RVA: 0x0018288C File Offset: 0x00180A8C
		// (set) Token: 0x06004FED RID: 20461 RVA: 0x0002589C File Offset: 0x00023A9C
		public unsafe AvatarSettings TestAvatarSettings
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr_TestAvatarSettings);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AvatarSettings>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr_TestAvatarSettings), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700176A RID: 5994
		// (get) Token: 0x06004FEE RID: 20462 RVA: 0x001828BC File Offset: 0x00180ABC
		// (set) Token: 0x06004FEF RID: 20463 RVA: 0x000258BB File Offset: 0x00023ABB
		public unsafe PlayerVisualState VisualState
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr_VisualState);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlayerVisualState>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr_VisualState), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700176B RID: 5995
		// (get) Token: 0x06004FF0 RID: 20464 RVA: 0x001828EC File Offset: 0x00180AEC
		// (set) Token: 0x06004FF1 RID: 20465 RVA: 0x000258DA File Offset: 0x00023ADA
		public unsafe PlayerVisibility Visibility
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr_Visibility);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlayerVisibility>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr_Visibility), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700176C RID: 5996
		// (get) Token: 0x06004FF2 RID: 20466 RVA: 0x0018291C File Offset: 0x00180B1C
		// (set) Token: 0x06004FF3 RID: 20467 RVA: 0x000258F9 File Offset: 0x00023AF9
		public unsafe CapsuleCollider CapCol
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr_CapCol);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CapsuleCollider>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr_CapCol), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700176D RID: 5997
		// (get) Token: 0x06004FF4 RID: 20468 RVA: 0x0018294C File Offset: 0x00180B4C
		// (set) Token: 0x06004FF5 RID: 20469 RVA: 0x00025918 File Offset: 0x00023B18
		public unsafe POI PoI
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr_PoI);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<POI>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr_PoI), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700176E RID: 5998
		// (get) Token: 0x06004FF6 RID: 20470 RVA: 0x0018297C File Offset: 0x00180B7C
		// (set) Token: 0x06004FF7 RID: 20471 RVA: 0x00025937 File Offset: 0x00023B37
		public unsafe PlayerHealth Health
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr_Health);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlayerHealth>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr_Health), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700176F RID: 5999
		// (get) Token: 0x06004FF8 RID: 20472 RVA: 0x001829AC File Offset: 0x00180BAC
		// (set) Token: 0x06004FF9 RID: 20473 RVA: 0x00025956 File Offset: 0x00023B56
		public unsafe PlayerCrimeData CrimeData
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr_CrimeData);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlayerCrimeData>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr_CrimeData), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001770 RID: 6000
		// (get) Token: 0x06004FFA RID: 20474 RVA: 0x001829DC File Offset: 0x00180BDC
		// (set) Token: 0x06004FFB RID: 20475 RVA: 0x00025975 File Offset: 0x00023B75
		public unsafe PlayerEnergy Energy
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr_Energy);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlayerEnergy>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr_Energy), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001771 RID: 6001
		// (get) Token: 0x06004FFC RID: 20476 RVA: 0x00182A0C File Offset: 0x00180C0C
		// (set) Token: 0x06004FFD RID: 20477 RVA: 0x00025994 File Offset: 0x00023B94
		public unsafe Transform MimicCamera
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr_MimicCamera);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr_MimicCamera), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001772 RID: 6002
		// (get) Token: 0x06004FFE RID: 20478 RVA: 0x00182A3C File Offset: 0x00180C3C
		// (set) Token: 0x06004FFF RID: 20479 RVA: 0x000259B3 File Offset: 0x00023BB3
		public unsafe AvatarFootstepDetector FootstepDetector
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr_FootstepDetector);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AvatarFootstepDetector>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr_FootstepDetector), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001773 RID: 6003
		// (get) Token: 0x06005000 RID: 20480 RVA: 0x00182A6C File Offset: 0x00180C6C
		// (set) Token: 0x06005001 RID: 20481 RVA: 0x000259D2 File Offset: 0x00023BD2
		public unsafe LocalPlayerFootstepGenerator LocalFootstepDetector
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr_LocalFootstepDetector);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LocalPlayerFootstepGenerator>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr_LocalFootstepDetector), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001774 RID: 6004
		// (get) Token: 0x06005002 RID: 20482 RVA: 0x00182A9C File Offset: 0x00180C9C
		// (set) Token: 0x06005003 RID: 20483 RVA: 0x000259F1 File Offset: 0x00023BF1
		public unsafe CharacterController CharacterController
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr_CharacterController);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CharacterController>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr_CharacterController), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001775 RID: 6005
		// (get) Token: 0x06005004 RID: 20484 RVA: 0x00182ACC File Offset: 0x00180CCC
		// (set) Token: 0x06005005 RID: 20485 RVA: 0x00025A10 File Offset: 0x00023C10
		public unsafe AudioSourceController PunchSound
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr_PunchSound);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr_PunchSound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001776 RID: 6006
		// (get) Token: 0x06005006 RID: 20486 RVA: 0x00182AFC File Offset: 0x00180CFC
		// (set) Token: 0x06005007 RID: 20487 RVA: 0x00025A2F File Offset: 0x00023C2F
		public unsafe OptimizedLight ThirdPersonFlashlight
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr_ThirdPersonFlashlight);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<OptimizedLight>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr_ThirdPersonFlashlight), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001777 RID: 6007
		// (get) Token: 0x06005008 RID: 20488 RVA: 0x00182B2C File Offset: 0x00180D2C
		// (set) Token: 0x06005009 RID: 20489 RVA: 0x00025A4E File Offset: 0x00023C4E
		public unsafe WorldspaceDialogueRenderer NameLabel
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr_NameLabel);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WorldspaceDialogueRenderer>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr_NameLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001778 RID: 6008
		// (get) Token: 0x0600500A RID: 20490 RVA: 0x00182B5C File Offset: 0x00180D5C
		// (set) Token: 0x0600500B RID: 20491 RVA: 0x00025A6D File Offset: 0x00023C6D
		public unsafe PlayerClothing Clothing
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr_Clothing);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlayerClothing>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr_Clothing), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001779 RID: 6009
		// (get) Token: 0x0600500C RID: 20492 RVA: 0x00182B8C File Offset: 0x00180D8C
		// (set) Token: 0x0600500D RID: 20493 RVA: 0x00025A8C File Offset: 0x00023C8C
		public unsafe LayerMask GroundDetectionMask
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr_GroundDetectionMask);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr_GroundDetectionMask)) = value;
			}
		}

		// Token: 0x1700177A RID: 6010
		// (get) Token: 0x0600500E RID: 20494 RVA: 0x00182BB4 File Offset: 0x00180DB4
		// (set) Token: 0x0600500F RID: 20495 RVA: 0x00025AA7 File Offset: 0x00023CA7
		public unsafe float AvatarOffset_Standing
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr_AvatarOffset_Standing);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr_AvatarOffset_Standing)) = value;
			}
		}

		// Token: 0x1700177B RID: 6011
		// (get) Token: 0x06005010 RID: 20496 RVA: 0x00182BDC File Offset: 0x00180DDC
		// (set) Token: 0x06005011 RID: 20497 RVA: 0x00025AC2 File Offset: 0x00023CC2
		public unsafe float AvatarOffset_Crouched
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr_AvatarOffset_Crouched);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr_AvatarOffset_Crouched)) = value;
			}
		}

		// Token: 0x1700177C RID: 6012
		// (get) Token: 0x06005012 RID: 20498 RVA: 0x00182C04 File Offset: 0x00180E04
		// (set) Token: 0x06005013 RID: 20499 RVA: 0x00025ADD File Offset: 0x00023CDD
		public unsafe AnimationCurve WalkingMapCurve
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr_WalkingMapCurve);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnimationCurve>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr_WalkingMapCurve), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700177D RID: 6013
		// (get) Token: 0x06005014 RID: 20500 RVA: 0x00182C34 File Offset: 0x00180E34
		// (set) Token: 0x06005015 RID: 20501 RVA: 0x00025AFC File Offset: 0x00023CFC
		public unsafe AnimationCurve CrouchWalkMapCurve
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr_CrouchWalkMapCurve);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnimationCurve>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr_CrouchWalkMapCurve), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700177E RID: 6014
		// (get) Token: 0x06005016 RID: 20502 RVA: 0x00182C64 File Offset: 0x00180E64
		// (set) Token: 0x06005017 RID: 20503 RVA: 0x00025B1B File Offset: 0x00023D1B
		public unsafe string _PlayerName_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr__PlayerName_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr__PlayerName_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700177F RID: 6015
		// (get) Token: 0x06005018 RID: 20504 RVA: 0x00182C8C File Offset: 0x00180E8C
		// (set) Token: 0x06005019 RID: 20505 RVA: 0x00025B3A File Offset: 0x00023D3A
		public unsafe NetworkConnection Connection
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr_Connection);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NetworkConnection>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr_Connection), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001780 RID: 6016
		// (get) Token: 0x0600501A RID: 20506 RVA: 0x00182CBC File Offset: 0x00180EBC
		// (set) Token: 0x0600501B RID: 20507 RVA: 0x00025B59 File Offset: 0x00023D59
		public unsafe string _PlayerCode_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr__PlayerCode_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr__PlayerCode_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001781 RID: 6017
		// (get) Token: 0x0600501C RID: 20508 RVA: 0x00182CE4 File Offset: 0x00180EE4
		// (set) Token: 0x0600501D RID: 20509 RVA: 0x00025B78 File Offset: 0x00023D78
		public unsafe NetworkObject _CurrentVehicle_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr__CurrentVehicle_k__BackingField);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NetworkObject>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr__CurrentVehicle_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001782 RID: 6018
		// (get) Token: 0x0600501E RID: 20510 RVA: 0x00182D14 File Offset: 0x00180F14
		// (set) Token: 0x0600501F RID: 20511 RVA: 0x00025B97 File Offset: 0x00023D97
		public unsafe Player.VehicleEvent onEnterVehicle
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr_onEnterVehicle);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Player.VehicleEvent>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr_onEnterVehicle), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001783 RID: 6019
		// (get) Token: 0x06005020 RID: 20512 RVA: 0x00182D44 File Offset: 0x00180F44
		// (set) Token: 0x06005021 RID: 20513 RVA: 0x00025BB6 File Offset: 0x00023DB6
		public unsafe Player.VehicleTransformEvent onExitVehicle
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr_onExitVehicle);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Player.VehicleTransformEvent>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr_onExitVehicle), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001784 RID: 6020
		// (get) Token: 0x06005022 RID: 20514 RVA: 0x00182D74 File Offset: 0x00180F74
		// (set) Token: 0x06005023 RID: 20515 RVA: 0x00025BD5 File Offset: 0x00023DD5
		public unsafe LandVehicle LastDrivenVehicle
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr_LastDrivenVehicle);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LandVehicle>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr_LastDrivenVehicle), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001785 RID: 6021
		// (get) Token: 0x06005024 RID: 20516 RVA: 0x00182DA4 File Offset: 0x00180FA4
		// (set) Token: 0x06005025 RID: 20517 RVA: 0x00025BF4 File Offset: 0x00023DF4
		public unsafe float _TimeSinceVehicleExit_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr__TimeSinceVehicleExit_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr__TimeSinceVehicleExit_k__BackingField)) = value;
			}
		}

		// Token: 0x17001786 RID: 6022
		// (get) Token: 0x06005026 RID: 20518 RVA: 0x00182DCC File Offset: 0x00180FCC
		// (set) Token: 0x06005027 RID: 20519 RVA: 0x00025C0F File Offset: 0x00023E0F
		public unsafe bool _Crouched_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr__Crouched_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr__Crouched_k__BackingField)) = value;
			}
		}

		// Token: 0x17001787 RID: 6023
		// (get) Token: 0x06005028 RID: 20520 RVA: 0x00182DF4 File Offset: 0x00180FF4
		// (set) Token: 0x06005029 RID: 20521 RVA: 0x00025C2A File Offset: 0x00023E2A
		public unsafe NetworkObject _CurrentBed_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr__CurrentBed_k__BackingField);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NetworkObject>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr__CurrentBed_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001788 RID: 6024
		// (get) Token: 0x0600502A RID: 20522 RVA: 0x00182E24 File Offset: 0x00181024
		// (set) Token: 0x0600502B RID: 20523 RVA: 0x00025C49 File Offset: 0x00023E49
		public unsafe bool _IsReadyToSleep_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr__IsReadyToSleep_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr__IsReadyToSleep_k__BackingField)) = value;
			}
		}

		// Token: 0x17001789 RID: 6025
		// (get) Token: 0x0600502C RID: 20524 RVA: 0x00182E4C File Offset: 0x0018104C
		// (set) Token: 0x0600502D RID: 20525 RVA: 0x00025C64 File Offset: 0x00023E64
		public unsafe bool _IsSkating_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr__IsSkating_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr__IsSkating_k__BackingField)) = value;
			}
		}

		// Token: 0x1700178A RID: 6026
		// (get) Token: 0x0600502E RID: 20526 RVA: 0x00182E74 File Offset: 0x00181074
		// (set) Token: 0x0600502F RID: 20527 RVA: 0x00025C7F File Offset: 0x00023E7F
		public unsafe Skateboard _ActiveSkateboard_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr__ActiveSkateboard_k__BackingField);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Skateboard>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr__ActiveSkateboard_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700178B RID: 6027
		// (get) Token: 0x06005030 RID: 20528 RVA: 0x00182EA4 File Offset: 0x001810A4
		// (set) Token: 0x06005031 RID: 20529 RVA: 0x00025C9E File Offset: 0x00023E9E
		public unsafe Il2CppSystem.Action<Skateboard> onSkateboardMounted
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr_onSkateboardMounted);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Action<Skateboard>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr_onSkateboardMounted), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700178C RID: 6028
		// (get) Token: 0x06005032 RID: 20530 RVA: 0x00182ED4 File Offset: 0x001810D4
		// (set) Token: 0x06005033 RID: 20531 RVA: 0x00025CBD File Offset: 0x00023EBD
		public unsafe Il2CppSystem.Action onSkateboardDismounted
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr_onSkateboardDismounted);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Action>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr_onSkateboardDismounted), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700178D RID: 6029
		// (get) Token: 0x06005034 RID: 20532 RVA: 0x00182F04 File Offset: 0x00181104
		// (set) Token: 0x06005035 RID: 20533 RVA: 0x00025CDC File Offset: 0x00023EDC
		public unsafe bool _IsSleeping_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr__IsSleeping_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr__IsSleeping_k__BackingField)) = value;
			}
		}

		// Token: 0x1700178E RID: 6030
		// (get) Token: 0x06005036 RID: 20534 RVA: 0x00182F2C File Offset: 0x0018112C
		// (set) Token: 0x06005037 RID: 20535 RVA: 0x00025CF7 File Offset: 0x00023EF7
		public unsafe bool _IsRagdolled_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr__IsRagdolled_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr__IsRagdolled_k__BackingField)) = value;
			}
		}

		// Token: 0x1700178F RID: 6031
		// (get) Token: 0x06005038 RID: 20536 RVA: 0x00182F54 File Offset: 0x00181154
		// (set) Token: 0x06005039 RID: 20537 RVA: 0x00025D12 File Offset: 0x00023F12
		public unsafe bool _IsArrested_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr__IsArrested_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr__IsArrested_k__BackingField)) = value;
			}
		}

		// Token: 0x17001790 RID: 6032
		// (get) Token: 0x0600503A RID: 20538 RVA: 0x00182F7C File Offset: 0x0018117C
		// (set) Token: 0x0600503B RID: 20539 RVA: 0x00025D2D File Offset: 0x00023F2D
		public unsafe bool _IsTased_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr__IsTased_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr__IsTased_k__BackingField)) = value;
			}
		}

		// Token: 0x17001791 RID: 6033
		// (get) Token: 0x0600503C RID: 20540 RVA: 0x00182FA4 File Offset: 0x001811A4
		// (set) Token: 0x0600503D RID: 20541 RVA: 0x00025D48 File Offset: 0x00023F48
		public unsafe bool _IsUnconscious_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr__IsUnconscious_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr__IsUnconscious_k__BackingField)) = value;
			}
		}

		// Token: 0x17001792 RID: 6034
		// (get) Token: 0x0600503E RID: 20542 RVA: 0x00182FCC File Offset: 0x001811CC
		// (set) Token: 0x0600503F RID: 20543 RVA: 0x00025D63 File Offset: 0x00023F63
		public unsafe float _Scale_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr__Scale_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr__Scale_k__BackingField)) = value;
			}
		}

		// Token: 0x17001793 RID: 6035
		// (get) Token: 0x06005040 RID: 20544 RVA: 0x00182FF4 File Offset: 0x001811F4
		// (set) Token: 0x06005041 RID: 20545 RVA: 0x00025D7E File Offset: 0x00023F7E
		public unsafe Property _CurrentProperty_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr__CurrentProperty_k__BackingField);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Property>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr__CurrentProperty_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001794 RID: 6036
		// (get) Token: 0x06005042 RID: 20546 RVA: 0x00183024 File Offset: 0x00181224
		// (set) Token: 0x06005043 RID: 20547 RVA: 0x00025D9D File Offset: 0x00023F9D
		public unsafe Property _LastVisitedProperty_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr__LastVisitedProperty_k__BackingField);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Property>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr__LastVisitedProperty_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001795 RID: 6037
		// (get) Token: 0x06005044 RID: 20548 RVA: 0x00183054 File Offset: 0x00181254
		// (set) Token: 0x06005045 RID: 20549 RVA: 0x00025DBC File Offset: 0x00023FBC
		public unsafe Business _CurrentBusiness_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr__CurrentBusiness_k__BackingField);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Business>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr__CurrentBusiness_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001796 RID: 6038
		// (get) Token: 0x06005046 RID: 20550 RVA: 0x00183084 File Offset: 0x00181284
		// (set) Token: 0x06005047 RID: 20551 RVA: 0x00025DDB File Offset: 0x00023FDB
		public unsafe bool HasCompletedIntro
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr_HasCompletedIntro);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr_HasCompletedIntro)) = value;
			}
		}

		// Token: 0x17001797 RID: 6039
		// (get) Token: 0x06005048 RID: 20552 RVA: 0x001830AC File Offset: 0x001812AC
		// (set) Token: 0x06005049 RID: 20553 RVA: 0x00025DF6 File Offset: 0x00023FF6
		public unsafe Vector3 _CameraPosition_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr__CameraPosition_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr__CameraPosition_k__BackingField)) = value;
			}
		}

		// Token: 0x17001798 RID: 6040
		// (get) Token: 0x0600504A RID: 20554 RVA: 0x001830D4 File Offset: 0x001812D4
		// (set) Token: 0x0600504B RID: 20555 RVA: 0x00025E11 File Offset: 0x00024011
		public unsafe Quaternion _CameraRotation_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr__CameraRotation_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr__CameraRotation_k__BackingField)) = value;
			}
		}

		// Token: 0x17001799 RID: 6041
		// (get) Token: 0x0600504C RID: 20556 RVA: 0x001830FC File Offset: 0x001812FC
		// (set) Token: 0x0600504D RID: 20557 RVA: 0x00025E2C File Offset: 0x0002402C
		public unsafe Il2CppReferenceArray<ItemSlot> Inventory
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr_Inventory);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<ItemSlot>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr_Inventory), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700179A RID: 6042
		// (get) Token: 0x0600504E RID: 20558 RVA: 0x0018312C File Offset: 0x0018132C
		// (set) Token: 0x0600504F RID: 20559 RVA: 0x00025E4B File Offset: 0x0002404B
		public unsafe BasicAvatarSettings _CurrentAvatarSettings_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr__CurrentAvatarSettings_k__BackingField);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BasicAvatarSettings>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr__CurrentAvatarSettings_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700179B RID: 6043
		// (get) Token: 0x06005050 RID: 20560 RVA: 0x0018315C File Offset: 0x0018135C
		// (set) Token: 0x06005051 RID: 20561 RVA: 0x00025E6A File Offset: 0x0002406A
		public unsafe ProductItemInstance _ConsumedProduct_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr__ConsumedProduct_k__BackingField);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ProductItemInstance>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr__ConsumedProduct_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700179C RID: 6044
		// (get) Token: 0x06005052 RID: 20562 RVA: 0x0018318C File Offset: 0x0018138C
		// (set) Token: 0x06005053 RID: 20563 RVA: 0x00025E89 File Offset: 0x00024089
		public unsafe int _TimeSinceProductConsumed_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr__TimeSinceProductConsumed_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr__TimeSinceProductConsumed_k__BackingField)) = value;
			}
		}

		// Token: 0x1700179D RID: 6045
		// (get) Token: 0x06005054 RID: 20564 RVA: 0x001831B4 File Offset: 0x001813B4
		// (set) Token: 0x06005055 RID: 20565 RVA: 0x00025EA4 File Offset: 0x000240A4
		public unsafe BasicAvatarSettings DebugAvatarSettings
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr_DebugAvatarSettings);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BasicAvatarSettings>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr_DebugAvatarSettings), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700179E RID: 6046
		// (get) Token: 0x06005056 RID: 20566 RVA: 0x001831E4 File Offset: 0x001813E4
		// (set) Token: 0x06005057 RID: 20567 RVA: 0x00025EC3 File Offset: 0x000240C3
		public unsafe PlayerLoader loader
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr_loader);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlayerLoader>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr_loader), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700179F RID: 6047
		// (get) Token: 0x06005058 RID: 20568 RVA: 0x00183214 File Offset: 0x00181414
		// (set) Token: 0x06005059 RID: 20569 RVA: 0x00025EE2 File Offset: 0x000240E2
		public unsafe List<string> _LocalExtraFiles_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr__LocalExtraFiles_k__BackingField);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr__LocalExtraFiles_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170017A0 RID: 6048
		// (get) Token: 0x0600505A RID: 20570 RVA: 0x00183244 File Offset: 0x00181444
		// (set) Token: 0x0600505B RID: 20571 RVA: 0x00025F01 File Offset: 0x00024101
		public unsafe List<string> _LocalExtraFolders_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr__LocalExtraFolders_k__BackingField);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr__LocalExtraFolders_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170017A1 RID: 6049
		// (get) Token: 0x0600505C RID: 20572 RVA: 0x00183274 File Offset: 0x00181474
		// (set) Token: 0x0600505D RID: 20573 RVA: 0x00025F20 File Offset: 0x00024120
		public unsafe bool _HasChanged_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr__HasChanged_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr__HasChanged_k__BackingField)) = value;
			}
		}

		// Token: 0x170017A2 RID: 6050
		// (get) Token: 0x0600505E RID: 20574 RVA: 0x0018329C File Offset: 0x0018149C
		// (set) Token: 0x0600505F RID: 20575 RVA: 0x00025F3B File Offset: 0x0002413B
		public unsafe UnityEvent onRagdoll
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr_onRagdoll);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr_onRagdoll), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170017A3 RID: 6051
		// (get) Token: 0x06005060 RID: 20576 RVA: 0x001832CC File Offset: 0x001814CC
		// (set) Token: 0x06005061 RID: 20577 RVA: 0x00025F5A File Offset: 0x0002415A
		public unsafe UnityEvent onRagdollEnd
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr_onRagdollEnd);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr_onRagdollEnd), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170017A4 RID: 6052
		// (get) Token: 0x06005062 RID: 20578 RVA: 0x001832FC File Offset: 0x001814FC
		// (set) Token: 0x06005063 RID: 20579 RVA: 0x00025F79 File Offset: 0x00024179
		public unsafe UnityEvent onArrested
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr_onArrested);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr_onArrested), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170017A5 RID: 6053
		// (get) Token: 0x06005064 RID: 20580 RVA: 0x0018332C File Offset: 0x0018152C
		// (set) Token: 0x06005065 RID: 20581 RVA: 0x00025F98 File Offset: 0x00024198
		public unsafe UnityEvent onFreed
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr_onFreed);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr_onFreed), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170017A6 RID: 6054
		// (get) Token: 0x06005066 RID: 20582 RVA: 0x0018335C File Offset: 0x0018155C
		// (set) Token: 0x06005067 RID: 20583 RVA: 0x00025FB7 File Offset: 0x000241B7
		public unsafe UnityEvent onTased
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr_onTased);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr_onTased), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170017A7 RID: 6055
		// (get) Token: 0x06005068 RID: 20584 RVA: 0x0018338C File Offset: 0x0018158C
		// (set) Token: 0x06005069 RID: 20585 RVA: 0x00025FD6 File Offset: 0x000241D6
		public unsafe UnityEvent onTasedEnd
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr_onTasedEnd);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr_onTasedEnd), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170017A8 RID: 6056
		// (get) Token: 0x0600506A RID: 20586 RVA: 0x001833BC File Offset: 0x001815BC
		// (set) Token: 0x0600506B RID: 20587 RVA: 0x00025FF5 File Offset: 0x000241F5
		public unsafe UnityEvent onPassedOut
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr_onPassedOut);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr_onPassedOut), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170017A9 RID: 6057
		// (get) Token: 0x0600506C RID: 20588 RVA: 0x001833EC File Offset: 0x001815EC
		// (set) Token: 0x0600506D RID: 20589 RVA: 0x00026014 File Offset: 0x00024214
		public unsafe UnityEvent onPassOutRecovery
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr_onPassOutRecovery);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr_onPassOutRecovery), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170017AA RID: 6058
		// (get) Token: 0x0600506E RID: 20590 RVA: 0x0018341C File Offset: 0x0018161C
		// (set) Token: 0x0600506F RID: 20591 RVA: 0x00026033 File Offset: 0x00024233
		public unsafe List<BaseVariable> PlayerVariables
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr_PlayerVariables);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<BaseVariable>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr_PlayerVariables), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170017AB RID: 6059
		// (get) Token: 0x06005070 RID: 20592 RVA: 0x0018344C File Offset: 0x0018164C
		// (set) Token: 0x06005071 RID: 20593 RVA: 0x00026052 File Offset: 0x00024252
		public unsafe Dictionary<string, BaseVariable> VariableDict
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr_VariableDict);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, BaseVariable>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr_VariableDict), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170017AC RID: 6060
		// (get) Token: 0x06005072 RID: 20594 RVA: 0x0018347C File Offset: 0x0018167C
		// (set) Token: 0x06005073 RID: 20595 RVA: 0x00026071 File Offset: 0x00024271
		public unsafe float standingScale
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr_standingScale);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr_standingScale)) = value;
			}
		}

		// Token: 0x170017AD RID: 6061
		// (get) Token: 0x06005074 RID: 20596 RVA: 0x001834A4 File Offset: 0x001816A4
		// (set) Token: 0x06005075 RID: 20597 RVA: 0x0002608C File Offset: 0x0002428C
		public unsafe float timeAirborne
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr_timeAirborne);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr_timeAirborne)) = value;
			}
		}

		// Token: 0x170017AE RID: 6062
		// (get) Token: 0x06005076 RID: 20598 RVA: 0x001834CC File Offset: 0x001816CC
		// (set) Token: 0x06005077 RID: 20599 RVA: 0x000260A7 File Offset: 0x000242A7
		public unsafe bool _avatarVisibleToLocalPlayer_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr__avatarVisibleToLocalPlayer_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr__avatarVisibleToLocalPlayer_k__BackingField)) = value;
			}
		}

		// Token: 0x170017AF RID: 6063
		// (get) Token: 0x06005078 RID: 20600 RVA: 0x001834F4 File Offset: 0x001816F4
		// (set) Token: 0x06005079 RID: 20601 RVA: 0x000260C2 File Offset: 0x000242C2
		public unsafe bool _playerDataRetrieveReturned_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr__playerDataRetrieveReturned_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr__playerDataRetrieveReturned_k__BackingField)) = value;
			}
		}

		// Token: 0x170017B0 RID: 6064
		// (get) Token: 0x0600507A RID: 20602 RVA: 0x0018351C File Offset: 0x0018171C
		// (set) Token: 0x0600507B RID: 20603 RVA: 0x000260DD File Offset: 0x000242DD
		public unsafe Coroutine taseCoroutine
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr_taseCoroutine);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr_taseCoroutine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170017B1 RID: 6065
		// (get) Token: 0x0600507C RID: 20604 RVA: 0x0018354C File Offset: 0x0018174C
		// (set) Token: 0x0600507D RID: 20605 RVA: 0x000260FC File Offset: 0x000242FC
		public unsafe List<ConstantForce> ragdollForceComponents
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr_ragdollForceComponents);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ConstantForce>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr_ragdollForceComponents), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170017B2 RID: 6066
		// (get) Token: 0x0600507E RID: 20606 RVA: 0x0018357C File Offset: 0x0018177C
		// (set) Token: 0x0600507F RID: 20607 RVA: 0x0002611B File Offset: 0x0002431B
		public unsafe bool _playerSaveRequestReturned_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr__playerSaveRequestReturned_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr__playerSaveRequestReturned_k__BackingField)) = value;
			}
		}

		// Token: 0x170017B3 RID: 6067
		// (get) Token: 0x06005080 RID: 20608 RVA: 0x001835A4 File Offset: 0x001817A4
		// (set) Token: 0x06005081 RID: 20609 RVA: 0x00026136 File Offset: 0x00024336
		public unsafe bool _PlayerInitializedOverNetwork_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr__PlayerInitializedOverNetwork_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr__PlayerInitializedOverNetwork_k__BackingField)) = value;
			}
		}

		// Token: 0x170017B4 RID: 6068
		// (get) Token: 0x06005082 RID: 20610 RVA: 0x001835CC File Offset: 0x001817CC
		// (set) Token: 0x06005083 RID: 20611 RVA: 0x00026151 File Offset: 0x00024351
		public unsafe List<int> impactHistory
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr_impactHistory);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<int>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr_impactHistory), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170017B5 RID: 6069
		// (get) Token: 0x06005084 RID: 20612 RVA: 0x001835FC File Offset: 0x001817FC
		// (set) Token: 0x06005085 RID: 20613 RVA: 0x00026170 File Offset: 0x00024370
		public unsafe bool _Paranoid_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr__Paranoid_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr__Paranoid_k__BackingField)) = value;
			}
		}

		// Token: 0x170017B6 RID: 6070
		// (get) Token: 0x06005086 RID: 20614 RVA: 0x00183624 File Offset: 0x00181824
		// (set) Token: 0x06005087 RID: 20615 RVA: 0x0002618B File Offset: 0x0002438B
		public unsafe bool _Sneaky_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr__Sneaky_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr__Sneaky_k__BackingField)) = value;
			}
		}

		// Token: 0x170017B7 RID: 6071
		// (get) Token: 0x06005088 RID: 20616 RVA: 0x0018364C File Offset: 0x0018184C
		// (set) Token: 0x06005089 RID: 20617 RVA: 0x000261A6 File Offset: 0x000243A6
		public unsafe bool _Disoriented_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr__Disoriented_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr__Disoriented_k__BackingField)) = value;
			}
		}

		// Token: 0x170017B8 RID: 6072
		// (get) Token: 0x0600508A RID: 20618 RVA: 0x00183674 File Offset: 0x00181874
		// (set) Token: 0x0600508B RID: 20619 RVA: 0x000261C1 File Offset: 0x000243C1
		public unsafe bool _Seizure_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr__Seizure_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr__Seizure_k__BackingField)) = value;
			}
		}

		// Token: 0x170017B9 RID: 6073
		// (get) Token: 0x0600508C RID: 20620 RVA: 0x0018369C File Offset: 0x0018189C
		// (set) Token: 0x0600508D RID: 20621 RVA: 0x000261DC File Offset: 0x000243DC
		public unsafe List<Quaternion> seizureRotations
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr_seizureRotations);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Quaternion>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr_seizureRotations), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170017BA RID: 6074
		// (get) Token: 0x0600508E RID: 20622 RVA: 0x001836CC File Offset: 0x001818CC
		// (set) Token: 0x0600508F RID: 20623 RVA: 0x000261FB File Offset: 0x000243FB
		public unsafe bool _Slippery_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr__Slippery_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr__Slippery_k__BackingField)) = value;
			}
		}

		// Token: 0x170017BB RID: 6075
		// (get) Token: 0x06005090 RID: 20624 RVA: 0x001836F4 File Offset: 0x001818F4
		// (set) Token: 0x06005091 RID: 20625 RVA: 0x00026216 File Offset: 0x00024416
		public unsafe bool _Schizophrenic_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr__Schizophrenic_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr__Schizophrenic_k__BackingField)) = value;
			}
		}

		// Token: 0x170017BC RID: 6076
		// (get) Token: 0x06005092 RID: 20626 RVA: 0x0018371C File Offset: 0x0018191C
		// (set) Token: 0x06005093 RID: 20627 RVA: 0x00026231 File Offset: 0x00024431
		public unsafe List<int> equippableMessageIDHistory
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr_equippableMessageIDHistory);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<int>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr_equippableMessageIDHistory), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170017BD RID: 6077
		// (get) Token: 0x06005094 RID: 20628 RVA: 0x0018374C File Offset: 0x0018194C
		// (set) Token: 0x06005095 RID: 20629 RVA: 0x00026250 File Offset: 0x00024450
		public unsafe Coroutine lerpScaleRoutine
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr_lerpScaleRoutine);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr_lerpScaleRoutine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170017BE RID: 6078
		// (get) Token: 0x06005096 RID: 20630 RVA: 0x0018377C File Offset: 0x0018197C
		// (set) Token: 0x06005097 RID: 20631 RVA: 0x0002626F File Offset: 0x0002446F
		public unsafe SyncVar<string> syncVar____PlayerName_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr_syncVar____PlayerName_k__BackingField);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SyncVar<string>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr_syncVar____PlayerName_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170017BF RID: 6079
		// (get) Token: 0x06005098 RID: 20632 RVA: 0x001837AC File Offset: 0x001819AC
		// (set) Token: 0x06005099 RID: 20633 RVA: 0x0002628E File Offset: 0x0002448E
		public unsafe SyncVar<string> syncVar____PlayerCode_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr_syncVar____PlayerCode_k__BackingField);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SyncVar<string>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr_syncVar____PlayerCode_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170017C0 RID: 6080
		// (get) Token: 0x0600509A RID: 20634 RVA: 0x001837DC File Offset: 0x001819DC
		// (set) Token: 0x0600509B RID: 20635 RVA: 0x000262AD File Offset: 0x000244AD
		public unsafe SyncVar<NetworkObject> syncVar____CurrentVehicle_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr_syncVar____CurrentVehicle_k__BackingField);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SyncVar<NetworkObject>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr_syncVar____CurrentVehicle_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170017C1 RID: 6081
		// (get) Token: 0x0600509C RID: 20636 RVA: 0x0018380C File Offset: 0x00181A0C
		// (set) Token: 0x0600509D RID: 20637 RVA: 0x000262CC File Offset: 0x000244CC
		public unsafe SyncVar<NetworkObject> syncVar____CurrentBed_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr_syncVar____CurrentBed_k__BackingField);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SyncVar<NetworkObject>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr_syncVar____CurrentBed_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170017C2 RID: 6082
		// (get) Token: 0x0600509E RID: 20638 RVA: 0x0018383C File Offset: 0x00181A3C
		// (set) Token: 0x0600509F RID: 20639 RVA: 0x000262EB File Offset: 0x000244EB
		public unsafe SyncVar<bool> syncVar____IsReadyToSleep_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr_syncVar____IsReadyToSleep_k__BackingField);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SyncVar<bool>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr_syncVar____IsReadyToSleep_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170017C3 RID: 6083
		// (get) Token: 0x060050A0 RID: 20640 RVA: 0x0018386C File Offset: 0x00181A6C
		// (set) Token: 0x060050A1 RID: 20641 RVA: 0x0002630A File Offset: 0x0002450A
		public unsafe SyncVar<Vector3> syncVar____CameraPosition_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr_syncVar____CameraPosition_k__BackingField);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SyncVar<Vector3>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr_syncVar____CameraPosition_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170017C4 RID: 6084
		// (get) Token: 0x060050A2 RID: 20642 RVA: 0x0018389C File Offset: 0x00181A9C
		// (set) Token: 0x060050A3 RID: 20643 RVA: 0x00026329 File Offset: 0x00024529
		public unsafe SyncVar<Quaternion> syncVar____CameraRotation_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr_syncVar____CameraRotation_k__BackingField);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SyncVar<Quaternion>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr_syncVar____CameraRotation_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170017C5 RID: 6085
		// (get) Token: 0x060050A4 RID: 20644 RVA: 0x001838CC File Offset: 0x00181ACC
		// (set) Token: 0x060050A5 RID: 20645 RVA: 0x00026348 File Offset: 0x00024548
		public unsafe bool field_Private_Boolean_0
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr_field_Private_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr_field_Private_Boolean_0)) = value;
			}
		}

		// Token: 0x170017C6 RID: 6086
		// (get) Token: 0x060050A6 RID: 20646 RVA: 0x001838F4 File Offset: 0x00181AF4
		// (set) Token: 0x060050A7 RID: 20647 RVA: 0x00026363 File Offset: 0x00024563
		public unsafe bool field_Private_Boolean_1
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr_field_Private_Boolean_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr_field_Private_Boolean_1)) = value;
			}
		}

		// Token: 0x040034A9 RID: 13481
		private static readonly System.IntPtr NativeFieldInfoPtr_OWNER_PLAYER_CODE;

		// Token: 0x040034AA RID: 13482
		private static readonly System.IntPtr NativeFieldInfoPtr_CapColDefaultHeight;

		// Token: 0x040034AB RID: 13483
		private static readonly System.IntPtr NativeFieldInfoPtr_objectsTemporarilyOwnedByPlayer;

		// Token: 0x040034AC RID: 13484
		private static readonly System.IntPtr NativeFieldInfoPtr_onLocalPlayerSpawned;

		// Token: 0x040034AD RID: 13485
		private static readonly System.IntPtr NativeFieldInfoPtr_onPlayerSpawned;

		// Token: 0x040034AE RID: 13486
		private static readonly System.IntPtr NativeFieldInfoPtr_onPlayerDespawned;

		// Token: 0x040034AF RID: 13487
		private static readonly System.IntPtr NativeFieldInfoPtr_Local;

		// Token: 0x040034B0 RID: 13488
		private static readonly System.IntPtr NativeFieldInfoPtr_PlayerList;

		// Token: 0x040034B1 RID: 13489
		private static readonly System.IntPtr NativeFieldInfoPtr_LocalGameObject;

		// Token: 0x040034B2 RID: 13490
		private static readonly System.IntPtr NativeFieldInfoPtr_Avatar;

		// Token: 0x040034B3 RID: 13491
		private static readonly System.IntPtr NativeFieldInfoPtr_Anim;

		// Token: 0x040034B4 RID: 13492
		private static readonly System.IntPtr NativeFieldInfoPtr_VelocityCalculator;

		// Token: 0x040034B5 RID: 13493
		private static readonly System.IntPtr NativeFieldInfoPtr_EyePosition;

		// Token: 0x040034B6 RID: 13494
		private static readonly System.IntPtr NativeFieldInfoPtr_TestAvatarSettings;

		// Token: 0x040034B7 RID: 13495
		private static readonly System.IntPtr NativeFieldInfoPtr_VisualState;

		// Token: 0x040034B8 RID: 13496
		private static readonly System.IntPtr NativeFieldInfoPtr_Visibility;

		// Token: 0x040034B9 RID: 13497
		private static readonly System.IntPtr NativeFieldInfoPtr_CapCol;

		// Token: 0x040034BA RID: 13498
		private static readonly System.IntPtr NativeFieldInfoPtr_PoI;

		// Token: 0x040034BB RID: 13499
		private static readonly System.IntPtr NativeFieldInfoPtr_Health;

		// Token: 0x040034BC RID: 13500
		private static readonly System.IntPtr NativeFieldInfoPtr_CrimeData;

		// Token: 0x040034BD RID: 13501
		private static readonly System.IntPtr NativeFieldInfoPtr_Energy;

		// Token: 0x040034BE RID: 13502
		private static readonly System.IntPtr NativeFieldInfoPtr_MimicCamera;

		// Token: 0x040034BF RID: 13503
		private static readonly System.IntPtr NativeFieldInfoPtr_FootstepDetector;

		// Token: 0x040034C0 RID: 13504
		private static readonly System.IntPtr NativeFieldInfoPtr_LocalFootstepDetector;

		// Token: 0x040034C1 RID: 13505
		private static readonly System.IntPtr NativeFieldInfoPtr_CharacterController;

		// Token: 0x040034C2 RID: 13506
		private static readonly System.IntPtr NativeFieldInfoPtr_PunchSound;

		// Token: 0x040034C3 RID: 13507
		private static readonly System.IntPtr NativeFieldInfoPtr_ThirdPersonFlashlight;

		// Token: 0x040034C4 RID: 13508
		private static readonly System.IntPtr NativeFieldInfoPtr_NameLabel;

		// Token: 0x040034C5 RID: 13509
		private static readonly System.IntPtr NativeFieldInfoPtr_Clothing;

		// Token: 0x040034C6 RID: 13510
		private static readonly System.IntPtr NativeFieldInfoPtr_GroundDetectionMask;

		// Token: 0x040034C7 RID: 13511
		private static readonly System.IntPtr NativeFieldInfoPtr_AvatarOffset_Standing;

		// Token: 0x040034C8 RID: 13512
		private static readonly System.IntPtr NativeFieldInfoPtr_AvatarOffset_Crouched;

		// Token: 0x040034C9 RID: 13513
		private static readonly System.IntPtr NativeFieldInfoPtr_WalkingMapCurve;

		// Token: 0x040034CA RID: 13514
		private static readonly System.IntPtr NativeFieldInfoPtr_CrouchWalkMapCurve;

		// Token: 0x040034CB RID: 13515
		private static readonly System.IntPtr NativeFieldInfoPtr__PlayerName_k__BackingField;

		// Token: 0x040034CC RID: 13516
		private static readonly System.IntPtr NativeFieldInfoPtr_Connection;

		// Token: 0x040034CD RID: 13517
		private static readonly System.IntPtr NativeFieldInfoPtr__PlayerCode_k__BackingField;

		// Token: 0x040034CE RID: 13518
		private static readonly System.IntPtr NativeFieldInfoPtr__CurrentVehicle_k__BackingField;

		// Token: 0x040034CF RID: 13519
		private static readonly System.IntPtr NativeFieldInfoPtr_onEnterVehicle;

		// Token: 0x040034D0 RID: 13520
		private static readonly System.IntPtr NativeFieldInfoPtr_onExitVehicle;

		// Token: 0x040034D1 RID: 13521
		private static readonly System.IntPtr NativeFieldInfoPtr_LastDrivenVehicle;

		// Token: 0x040034D2 RID: 13522
		private static readonly System.IntPtr NativeFieldInfoPtr__TimeSinceVehicleExit_k__BackingField;

		// Token: 0x040034D3 RID: 13523
		private static readonly System.IntPtr NativeFieldInfoPtr__Crouched_k__BackingField;

		// Token: 0x040034D4 RID: 13524
		private static readonly System.IntPtr NativeFieldInfoPtr__CurrentBed_k__BackingField;

		// Token: 0x040034D5 RID: 13525
		private static readonly System.IntPtr NativeFieldInfoPtr__IsReadyToSleep_k__BackingField;

		// Token: 0x040034D6 RID: 13526
		private static readonly System.IntPtr NativeFieldInfoPtr__IsSkating_k__BackingField;

		// Token: 0x040034D7 RID: 13527
		private static readonly System.IntPtr NativeFieldInfoPtr__ActiveSkateboard_k__BackingField;

		// Token: 0x040034D8 RID: 13528
		private static readonly System.IntPtr NativeFieldInfoPtr_onSkateboardMounted;

		// Token: 0x040034D9 RID: 13529
		private static readonly System.IntPtr NativeFieldInfoPtr_onSkateboardDismounted;

		// Token: 0x040034DA RID: 13530
		private static readonly System.IntPtr NativeFieldInfoPtr__IsSleeping_k__BackingField;

		// Token: 0x040034DB RID: 13531
		private static readonly System.IntPtr NativeFieldInfoPtr__IsRagdolled_k__BackingField;

		// Token: 0x040034DC RID: 13532
		private static readonly System.IntPtr NativeFieldInfoPtr__IsArrested_k__BackingField;

		// Token: 0x040034DD RID: 13533
		private static readonly System.IntPtr NativeFieldInfoPtr__IsTased_k__BackingField;

		// Token: 0x040034DE RID: 13534
		private static readonly System.IntPtr NativeFieldInfoPtr__IsUnconscious_k__BackingField;

		// Token: 0x040034DF RID: 13535
		private static readonly System.IntPtr NativeFieldInfoPtr__Scale_k__BackingField;

		// Token: 0x040034E0 RID: 13536
		private static readonly System.IntPtr NativeFieldInfoPtr__CurrentProperty_k__BackingField;

		// Token: 0x040034E1 RID: 13537
		private static readonly System.IntPtr NativeFieldInfoPtr__LastVisitedProperty_k__BackingField;

		// Token: 0x040034E2 RID: 13538
		private static readonly System.IntPtr NativeFieldInfoPtr__CurrentBusiness_k__BackingField;

		// Token: 0x040034E3 RID: 13539
		private static readonly System.IntPtr NativeFieldInfoPtr_HasCompletedIntro;

		// Token: 0x040034E4 RID: 13540
		private static readonly System.IntPtr NativeFieldInfoPtr__CameraPosition_k__BackingField;

		// Token: 0x040034E5 RID: 13541
		private static readonly System.IntPtr NativeFieldInfoPtr__CameraRotation_k__BackingField;

		// Token: 0x040034E6 RID: 13542
		private static readonly System.IntPtr NativeFieldInfoPtr_Inventory;

		// Token: 0x040034E7 RID: 13543
		private static readonly System.IntPtr NativeFieldInfoPtr__CurrentAvatarSettings_k__BackingField;

		// Token: 0x040034E8 RID: 13544
		private static readonly System.IntPtr NativeFieldInfoPtr__ConsumedProduct_k__BackingField;

		// Token: 0x040034E9 RID: 13545
		private static readonly System.IntPtr NativeFieldInfoPtr__TimeSinceProductConsumed_k__BackingField;

		// Token: 0x040034EA RID: 13546
		private static readonly System.IntPtr NativeFieldInfoPtr_DebugAvatarSettings;

		// Token: 0x040034EB RID: 13547
		private static readonly System.IntPtr NativeFieldInfoPtr_loader;

		// Token: 0x040034EC RID: 13548
		private static readonly System.IntPtr NativeFieldInfoPtr__LocalExtraFiles_k__BackingField;

		// Token: 0x040034ED RID: 13549
		private static readonly System.IntPtr NativeFieldInfoPtr__LocalExtraFolders_k__BackingField;

		// Token: 0x040034EE RID: 13550
		private static readonly System.IntPtr NativeFieldInfoPtr__HasChanged_k__BackingField;

		// Token: 0x040034EF RID: 13551
		private static readonly System.IntPtr NativeFieldInfoPtr_onRagdoll;

		// Token: 0x040034F0 RID: 13552
		private static readonly System.IntPtr NativeFieldInfoPtr_onRagdollEnd;

		// Token: 0x040034F1 RID: 13553
		private static readonly System.IntPtr NativeFieldInfoPtr_onArrested;

		// Token: 0x040034F2 RID: 13554
		private static readonly System.IntPtr NativeFieldInfoPtr_onFreed;

		// Token: 0x040034F3 RID: 13555
		private static readonly System.IntPtr NativeFieldInfoPtr_onTased;

		// Token: 0x040034F4 RID: 13556
		private static readonly System.IntPtr NativeFieldInfoPtr_onTasedEnd;

		// Token: 0x040034F5 RID: 13557
		private static readonly System.IntPtr NativeFieldInfoPtr_onPassedOut;

		// Token: 0x040034F6 RID: 13558
		private static readonly System.IntPtr NativeFieldInfoPtr_onPassOutRecovery;

		// Token: 0x040034F7 RID: 13559
		private static readonly System.IntPtr NativeFieldInfoPtr_PlayerVariables;

		// Token: 0x040034F8 RID: 13560
		private static readonly System.IntPtr NativeFieldInfoPtr_VariableDict;

		// Token: 0x040034F9 RID: 13561
		private static readonly System.IntPtr NativeFieldInfoPtr_standingScale;

		// Token: 0x040034FA RID: 13562
		private static readonly System.IntPtr NativeFieldInfoPtr_timeAirborne;

		// Token: 0x040034FB RID: 13563
		private static readonly System.IntPtr NativeFieldInfoPtr__avatarVisibleToLocalPlayer_k__BackingField;

		// Token: 0x040034FC RID: 13564
		private static readonly System.IntPtr NativeFieldInfoPtr__playerDataRetrieveReturned_k__BackingField;

		// Token: 0x040034FD RID: 13565
		private static readonly System.IntPtr NativeFieldInfoPtr_taseCoroutine;

		// Token: 0x040034FE RID: 13566
		private static readonly System.IntPtr NativeFieldInfoPtr_ragdollForceComponents;

		// Token: 0x040034FF RID: 13567
		private static readonly System.IntPtr NativeFieldInfoPtr__playerSaveRequestReturned_k__BackingField;

		// Token: 0x04003500 RID: 13568
		private static readonly System.IntPtr NativeFieldInfoPtr__PlayerInitializedOverNetwork_k__BackingField;

		// Token: 0x04003501 RID: 13569
		private static readonly System.IntPtr NativeFieldInfoPtr_impactHistory;

		// Token: 0x04003502 RID: 13570
		private static readonly System.IntPtr NativeFieldInfoPtr__Paranoid_k__BackingField;

		// Token: 0x04003503 RID: 13571
		private static readonly System.IntPtr NativeFieldInfoPtr__Sneaky_k__BackingField;

		// Token: 0x04003504 RID: 13572
		private static readonly System.IntPtr NativeFieldInfoPtr__Disoriented_k__BackingField;

		// Token: 0x04003505 RID: 13573
		private static readonly System.IntPtr NativeFieldInfoPtr__Seizure_k__BackingField;

		// Token: 0x04003506 RID: 13574
		private static readonly System.IntPtr NativeFieldInfoPtr_seizureRotations;

		// Token: 0x04003507 RID: 13575
		private static readonly System.IntPtr NativeFieldInfoPtr__Slippery_k__BackingField;

		// Token: 0x04003508 RID: 13576
		private static readonly System.IntPtr NativeFieldInfoPtr__Schizophrenic_k__BackingField;

		// Token: 0x04003509 RID: 13577
		private static readonly System.IntPtr NativeFieldInfoPtr_equippableMessageIDHistory;

		// Token: 0x0400350A RID: 13578
		private static readonly System.IntPtr NativeFieldInfoPtr_lerpScaleRoutine;

		// Token: 0x0400350B RID: 13579
		private static readonly System.IntPtr NativeFieldInfoPtr_syncVar____PlayerName_k__BackingField;

		// Token: 0x0400350C RID: 13580
		private static readonly System.IntPtr NativeFieldInfoPtr_syncVar____PlayerCode_k__BackingField;

		// Token: 0x0400350D RID: 13581
		private static readonly System.IntPtr NativeFieldInfoPtr_syncVar____CurrentVehicle_k__BackingField;

		// Token: 0x0400350E RID: 13582
		private static readonly System.IntPtr NativeFieldInfoPtr_syncVar____CurrentBed_k__BackingField;

		// Token: 0x0400350F RID: 13583
		private static readonly System.IntPtr NativeFieldInfoPtr_syncVar____IsReadyToSleep_k__BackingField;

		// Token: 0x04003510 RID: 13584
		private static readonly System.IntPtr NativeFieldInfoPtr_syncVar____CameraPosition_k__BackingField;

		// Token: 0x04003511 RID: 13585
		private static readonly System.IntPtr NativeFieldInfoPtr_syncVar____CameraRotation_k__BackingField;

		// Token: 0x04003512 RID: 13586
		private static readonly System.IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

		// Token: 0x04003513 RID: 13587
		private static readonly System.IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

		// Token: 0x04003514 RID: 13588
		private static readonly System.IntPtr NativeMethodInfoPtr_get_IsLocalPlayer_Public_get_Boolean_0;

		// Token: 0x04003515 RID: 13589
		private static readonly System.IntPtr NativeMethodInfoPtr_get_PlayerName_Public_get_String_0;

		// Token: 0x04003516 RID: 13590
		private static readonly System.IntPtr NativeMethodInfoPtr_set_PlayerName_Protected_set_Void_String_0;

		// Token: 0x04003517 RID: 13591
		private static readonly System.IntPtr NativeMethodInfoPtr_get_PlayerCode_Public_get_String_0;

		// Token: 0x04003518 RID: 13592
		private static readonly System.IntPtr NativeMethodInfoPtr_set_PlayerCode_Protected_set_Void_String_0;

		// Token: 0x04003519 RID: 13593
		private static readonly System.IntPtr NativeMethodInfoPtr_get_CurrentVehicle_Public_get_NetworkObject_0;

		// Token: 0x0400351A RID: 13594
		private static readonly System.IntPtr NativeMethodInfoPtr_set_CurrentVehicle_Public_set_Void_NetworkObject_0;

		// Token: 0x0400351B RID: 13595
		private static readonly System.IntPtr NativeMethodInfoPtr_get_TimeSinceVehicleExit_Public_get_Single_0;

		// Token: 0x0400351C RID: 13596
		private static readonly System.IntPtr NativeMethodInfoPtr_set_TimeSinceVehicleExit_Protected_set_Void_Single_0;

		// Token: 0x0400351D RID: 13597
		private static readonly System.IntPtr NativeMethodInfoPtr_get_Crouched_Public_get_Boolean_0;

		// Token: 0x0400351E RID: 13598
		private static readonly System.IntPtr NativeMethodInfoPtr_set_Crouched_Private_set_Void_Boolean_0;

		// Token: 0x0400351F RID: 13599
		private static readonly System.IntPtr NativeMethodInfoPtr_get_CurrentBed_Public_get_NetworkObject_0;

		// Token: 0x04003520 RID: 13600
		private static readonly System.IntPtr NativeMethodInfoPtr_set_CurrentBed_Public_set_Void_NetworkObject_0;

		// Token: 0x04003521 RID: 13601
		private static readonly System.IntPtr NativeMethodInfoPtr_get_IsReadyToSleep_Public_get_Boolean_0;

		// Token: 0x04003522 RID: 13602
		private static readonly System.IntPtr NativeMethodInfoPtr_set_IsReadyToSleep_Private_set_Void_Boolean_0;

		// Token: 0x04003523 RID: 13603
		private static readonly System.IntPtr NativeMethodInfoPtr_get_IsSkating_Public_get_Boolean_0;

		// Token: 0x04003524 RID: 13604
		private static readonly System.IntPtr NativeMethodInfoPtr_set_IsSkating_Public_set_Void_Boolean_0;

		// Token: 0x04003525 RID: 13605
		private static readonly System.IntPtr NativeMethodInfoPtr_get_ActiveSkateboard_Public_get_Skateboard_0;

		// Token: 0x04003526 RID: 13606
		private static readonly System.IntPtr NativeMethodInfoPtr_set_ActiveSkateboard_Private_set_Void_Skateboard_0;

		// Token: 0x04003527 RID: 13607
		private static readonly System.IntPtr NativeMethodInfoPtr_get_IsSleeping_Public_get_Boolean_0;

		// Token: 0x04003528 RID: 13608
		private static readonly System.IntPtr NativeMethodInfoPtr_set_IsSleeping_Protected_set_Void_Boolean_0;

		// Token: 0x04003529 RID: 13609
		private static readonly System.IntPtr NativeMethodInfoPtr_get_IsRagdolled_Public_get_Boolean_0;

		// Token: 0x0400352A RID: 13610
		private static readonly System.IntPtr NativeMethodInfoPtr_set_IsRagdolled_Protected_set_Void_Boolean_0;

		// Token: 0x0400352B RID: 13611
		private static readonly System.IntPtr NativeMethodInfoPtr_get_IsArrested_Public_get_Boolean_0;

		// Token: 0x0400352C RID: 13612
		private static readonly System.IntPtr NativeMethodInfoPtr_set_IsArrested_Protected_set_Void_Boolean_0;

		// Token: 0x0400352D RID: 13613
		private static readonly System.IntPtr NativeMethodInfoPtr_get_IsTased_Public_get_Boolean_0;

		// Token: 0x0400352E RID: 13614
		private static readonly System.IntPtr NativeMethodInfoPtr_set_IsTased_Protected_set_Void_Boolean_0;

		// Token: 0x0400352F RID: 13615
		private static readonly System.IntPtr NativeMethodInfoPtr_get_IsUnconscious_Public_get_Boolean_0;

		// Token: 0x04003530 RID: 13616
		private static readonly System.IntPtr NativeMethodInfoPtr_set_IsUnconscious_Protected_set_Void_Boolean_0;

		// Token: 0x04003531 RID: 13617
		private static readonly System.IntPtr NativeMethodInfoPtr_get_Scale_Public_get_Single_0;

		// Token: 0x04003532 RID: 13618
		private static readonly System.IntPtr NativeMethodInfoPtr_set_Scale_Private_set_Void_Single_0;

		// Token: 0x04003533 RID: 13619
		private static readonly System.IntPtr NativeMethodInfoPtr_get_CurrentProperty_Public_get_Property_0;

		// Token: 0x04003534 RID: 13620
		private static readonly System.IntPtr NativeMethodInfoPtr_set_CurrentProperty_Protected_set_Void_Property_0;

		// Token: 0x04003535 RID: 13621
		private static readonly System.IntPtr NativeMethodInfoPtr_get_LastVisitedProperty_Public_get_Property_0;

		// Token: 0x04003536 RID: 13622
		private static readonly System.IntPtr NativeMethodInfoPtr_set_LastVisitedProperty_Protected_set_Void_Property_0;

		// Token: 0x04003537 RID: 13623
		private static readonly System.IntPtr NativeMethodInfoPtr_get_CurrentBusiness_Public_get_Business_0;

		// Token: 0x04003538 RID: 13624
		private static readonly System.IntPtr NativeMethodInfoPtr_set_CurrentBusiness_Protected_set_Void_Business_0;

		// Token: 0x04003539 RID: 13625
		private static readonly System.IntPtr NativeMethodInfoPtr_get_PlayerBasePosition_Public_get_Vector3_0;

		// Token: 0x0400353A RID: 13626
		private static readonly System.IntPtr NativeMethodInfoPtr_get_CameraPosition_Public_get_Vector3_0;

		// Token: 0x0400353B RID: 13627
		private static readonly System.IntPtr NativeMethodInfoPtr_set_CameraPosition_Public_set_Void_Vector3_0;

		// Token: 0x0400353C RID: 13628
		private static readonly System.IntPtr NativeMethodInfoPtr_get_CameraRotation_Public_get_Quaternion_0;

		// Token: 0x0400353D RID: 13629
		private static readonly System.IntPtr NativeMethodInfoPtr_set_CameraRotation_Public_set_Void_Quaternion_0;

		// Token: 0x0400353E RID: 13630
		private static readonly System.IntPtr NativeMethodInfoPtr_get_CurrentAvatarSettings_Public_get_BasicAvatarSettings_0;

		// Token: 0x0400353F RID: 13631
		private static readonly System.IntPtr NativeMethodInfoPtr_set_CurrentAvatarSettings_Protected_set_Void_BasicAvatarSettings_0;

		// Token: 0x04003540 RID: 13632
		private static readonly System.IntPtr NativeMethodInfoPtr_get_ConsumedProduct_Public_get_ProductItemInstance_0;

		// Token: 0x04003541 RID: 13633
		private static readonly System.IntPtr NativeMethodInfoPtr_set_ConsumedProduct_Private_set_Void_ProductItemInstance_0;

		// Token: 0x04003542 RID: 13634
		private static readonly System.IntPtr NativeMethodInfoPtr_get_TimeSinceProductConsumed_Public_get_Int32_0;

		// Token: 0x04003543 RID: 13635
		private static readonly System.IntPtr NativeMethodInfoPtr_set_TimeSinceProductConsumed_Private_set_Void_Int32_0;

		// Token: 0x04003544 RID: 13636
		private static readonly System.IntPtr NativeMethodInfoPtr_LoadDebugAvatarSettings_Public_Void_0;

		// Token: 0x04003545 RID: 13637
		private static readonly System.IntPtr NativeMethodInfoPtr_get_SaveFolderName_Public_Virtual_Final_New_get_String_0;

		// Token: 0x04003546 RID: 13638
		private static readonly System.IntPtr NativeMethodInfoPtr_get_SaveFileName_Public_Virtual_Final_New_get_String_0;

		// Token: 0x04003547 RID: 13639
		private static readonly System.IntPtr NativeMethodInfoPtr_get_Loader_Public_Virtual_Final_New_get_Loader_0;

		// Token: 0x04003548 RID: 13640
		private static readonly System.IntPtr NativeMethodInfoPtr_get_ShouldSaveUnderFolder_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x04003549 RID: 13641
		private static readonly System.IntPtr NativeMethodInfoPtr_get_LocalExtraFiles_Public_Virtual_Final_New_get_List_1_String_0;

		// Token: 0x0400354A RID: 13642
		private static readonly System.IntPtr NativeMethodInfoPtr_set_LocalExtraFiles_Public_Virtual_Final_New_set_Void_List_1_String_0;

		// Token: 0x0400354B RID: 13643
		private static readonly System.IntPtr NativeMethodInfoPtr_get_LocalExtraFolders_Public_Virtual_Final_New_get_List_1_String_0;

		// Token: 0x0400354C RID: 13644
		private static readonly System.IntPtr NativeMethodInfoPtr_set_LocalExtraFolders_Public_Virtual_Final_New_set_Void_List_1_String_0;

		// Token: 0x0400354D RID: 13645
		private static readonly System.IntPtr NativeMethodInfoPtr_get_HasChanged_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x0400354E RID: 13646
		private static readonly System.IntPtr NativeMethodInfoPtr_set_HasChanged_Public_Virtual_Final_New_set_Void_Boolean_0;

		// Token: 0x0400354F RID: 13647
		private static readonly System.IntPtr NativeMethodInfoPtr_get_avatarVisibleToLocalPlayer_Public_get_Boolean_0;

		// Token: 0x04003550 RID: 13648
		private static readonly System.IntPtr NativeMethodInfoPtr_set_avatarVisibleToLocalPlayer_Private_set_Void_Boolean_0;

		// Token: 0x04003551 RID: 13649
		private static readonly System.IntPtr NativeMethodInfoPtr_get_playerDataRetrieveReturned_Public_get_Boolean_0;

		// Token: 0x04003552 RID: 13650
		private static readonly System.IntPtr NativeMethodInfoPtr_set_playerDataRetrieveReturned_Private_set_Void_Boolean_0;

		// Token: 0x04003553 RID: 13651
		private static readonly System.IntPtr NativeMethodInfoPtr_get_playerSaveRequestReturned_Public_get_Boolean_0;

		// Token: 0x04003554 RID: 13652
		private static readonly System.IntPtr NativeMethodInfoPtr_set_playerSaveRequestReturned_Private_set_Void_Boolean_0;

		// Token: 0x04003555 RID: 13653
		private static readonly System.IntPtr NativeMethodInfoPtr_get_PlayerInitializedOverNetwork_Public_get_Boolean_0;

		// Token: 0x04003556 RID: 13654
		private static readonly System.IntPtr NativeMethodInfoPtr_set_PlayerInitializedOverNetwork_Private_set_Void_Boolean_0;

		// Token: 0x04003557 RID: 13655
		private static readonly System.IntPtr NativeMethodInfoPtr_get_Paranoid_Public_get_Boolean_0;

		// Token: 0x04003558 RID: 13656
		private static readonly System.IntPtr NativeMethodInfoPtr_set_Paranoid_Public_set_Void_Boolean_0;

		// Token: 0x04003559 RID: 13657
		private static readonly System.IntPtr NativeMethodInfoPtr_get_Sneaky_Public_get_Boolean_0;

		// Token: 0x0400355A RID: 13658
		private static readonly System.IntPtr NativeMethodInfoPtr_set_Sneaky_Public_set_Void_Boolean_0;

		// Token: 0x0400355B RID: 13659
		private static readonly System.IntPtr NativeMethodInfoPtr_get_Disoriented_Public_get_Boolean_0;

		// Token: 0x0400355C RID: 13660
		private static readonly System.IntPtr NativeMethodInfoPtr_set_Disoriented_Public_set_Void_Boolean_0;

		// Token: 0x0400355D RID: 13661
		private static readonly System.IntPtr NativeMethodInfoPtr_get_Seizure_Public_get_Boolean_0;

		// Token: 0x0400355E RID: 13662
		private static readonly System.IntPtr NativeMethodInfoPtr_set_Seizure_Public_set_Void_Boolean_0;

		// Token: 0x0400355F RID: 13663
		private static readonly System.IntPtr NativeMethodInfoPtr_get_Slippery_Public_get_Boolean_0;

		// Token: 0x04003560 RID: 13664
		private static readonly System.IntPtr NativeMethodInfoPtr_set_Slippery_Public_set_Void_Boolean_0;

		// Token: 0x04003561 RID: 13665
		private static readonly System.IntPtr NativeMethodInfoPtr_get_Schizophrenic_Public_get_Boolean_0;

		// Token: 0x04003562 RID: 13666
		private static readonly System.IntPtr NativeMethodInfoPtr_set_Schizophrenic_Public_set_Void_Boolean_0;

		// Token: 0x04003563 RID: 13667
		private static readonly System.IntPtr NativeMethodInfoPtr_GetPlayer_Public_Static_Player_NetworkConnection_0;

		// Token: 0x04003564 RID: 13668
		private static readonly System.IntPtr NativeMethodInfoPtr_GetRandomPlayer_Public_Static_Player_Boolean_Boolean_0;

		// Token: 0x04003565 RID: 13669
		private static readonly System.IntPtr NativeMethodInfoPtr_GetPlayer_Public_Static_Player_String_0;

		// Token: 0x04003566 RID: 13670
		private static readonly System.IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;

		// Token: 0x04003567 RID: 13671
		private static readonly System.IntPtr NativeMethodInfoPtr_InitializeSaveable_Public_Virtual_New_Void_0;

		// Token: 0x04003568 RID: 13672
		private static readonly System.IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_1;

		// Token: 0x04003569 RID: 13673
		private static readonly System.IntPtr NativeMethodInfoPtr_OnDestroy_Protected_Virtual_New_Void_1;

		// Token: 0x0400356A RID: 13674
		private static readonly System.IntPtr NativeMethodInfoPtr_OnStartClient_Public_Virtual_Void_0;

		// Token: 0x0400356B RID: 13675
		private static readonly System.IntPtr NativeMethodInfoPtr_PlayerLoaded_Private_Void_0;

		// Token: 0x0400356C RID: 13676
		private static readonly System.IntPtr NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0;

		// Token: 0x0400356D RID: 13677
		private static readonly System.IntPtr NativeMethodInfoPtr_RequestSavePlayer_Public_Void_0;

		// Token: 0x0400356E RID: 13678
		private static readonly System.IntPtr NativeMethodInfoPtr_ReturnSaveRequest_Private_Void_NetworkConnection_Boolean_0;

		// Token: 0x0400356F RID: 13679
		private static readonly System.IntPtr NativeMethodInfoPtr_HostExitedGame_Public_Void_0;

		// Token: 0x04003570 RID: 13680
		private static readonly System.IntPtr NativeMethodInfoPtr_ClientConnectionStateChanged_Private_Void_ClientConnectionStateArgs_0;

		// Token: 0x04003571 RID: 13681
		private static readonly System.IntPtr NativeMethodInfoPtr_SendPlayerNameData_Public_Void_String_UInt64_0;

		// Token: 0x04003572 RID: 13682
		private static readonly System.IntPtr NativeMethodInfoPtr_RequestPlayerData_Public_Void_String_0;

		// Token: 0x04003573 RID: 13683
		private static readonly System.IntPtr NativeMethodInfoPtr_MarkPlayerInitialized_Public_Void_0;

		// Token: 0x04003574 RID: 13684
		private static readonly System.IntPtr NativeMethodInfoPtr_ReceivePlayerData_Public_Void_NetworkConnection_PlayerData_String_String_String_Il2CppReferenceArray_1_VariableData_0;

		// Token: 0x04003575 RID: 13685
		private static readonly System.IntPtr NativeMethodInfoPtr_SetGravityMultiplier_Public_Void_Single_0;

		// Token: 0x04003576 RID: 13686
		private static readonly System.IntPtr NativeMethodInfoPtr_ReceivePlayerNameData_Private_Void_NetworkConnection_String_String_0;

		// Token: 0x04003577 RID: 13687
		private static readonly System.IntPtr NativeMethodInfoPtr_SendFlashlightOn_Public_Void_Boolean_0;

		// Token: 0x04003578 RID: 13688
		private static readonly System.IntPtr NativeMethodInfoPtr_SendFlashlightOnNetworked_Private_Void_Boolean_0;

		// Token: 0x04003579 RID: 13689
		private static readonly System.IntPtr NativeMethodInfoPtr_SetFlashlightOn_Private_Void_Boolean_0;

		// Token: 0x0400357A RID: 13690
		private static readonly System.IntPtr NativeMethodInfoPtr_OnStopClient_Public_Virtual_Void_0;

		// Token: 0x0400357B RID: 13691
		private static readonly System.IntPtr NativeMethodInfoPtr_OnStartServer_Public_Virtual_Void_0;

		// Token: 0x0400357C RID: 13692
		private static readonly System.IntPtr NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_1;

		// Token: 0x0400357D RID: 13693
		private static readonly System.IntPtr NativeMethodInfoPtr_MinPass_Protected_Virtual_New_Void_1;

		// Token: 0x0400357E RID: 13694
		private static readonly System.IntPtr NativeMethodInfoPtr_Tick_Protected_Virtual_New_Void_1;

		// Token: 0x0400357F RID: 13695
		private static readonly System.IntPtr NativeMethodInfoPtr_LateUpdate_Protected_Virtual_New_Void_1;

		// Token: 0x04003580 RID: 13696
		private static readonly System.IntPtr NativeMethodInfoPtr_RecalculateCurrentProperty_Private_Void_0;

		// Token: 0x04003581 RID: 13697
		private static readonly System.IntPtr NativeMethodInfoPtr_FixedUpdate_Private_Void_0;

		// Token: 0x04003582 RID: 13698
		private static readonly System.IntPtr NativeMethodInfoPtr_ApplyMovementVisuals_Private_Void_0;

		// Token: 0x04003583 RID: 13699
		private static readonly System.IntPtr NativeMethodInfoPtr_SetVisible_Public_Void_Boolean_Boolean_0;

		// Token: 0x04003584 RID: 13700
		private static readonly System.IntPtr NativeMethodInfoPtr_PlayJumpAnimation_Public_Void_0;

		// Token: 0x04003585 RID: 13701
		private static readonly System.IntPtr NativeMethodInfoPtr_GetIsGrounded_Public_Boolean_0;

		// Token: 0x04003586 RID: 13702
		private static readonly System.IntPtr NativeMethodInfoPtr_SendCrouched_Public_Void_Boolean_0;

		// Token: 0x04003587 RID: 13703
		private static readonly System.IntPtr NativeMethodInfoPtr_SetCrouchedLocal_Public_Void_Boolean_0;

		// Token: 0x04003588 RID: 13704
		private static readonly System.IntPtr NativeMethodInfoPtr_ReceiveCrouched_Private_Void_NetworkConnection_Boolean_0;

		// Token: 0x04003589 RID: 13705
		private static readonly System.IntPtr NativeMethodInfoPtr_SendAvatarSettings_Public_Void_AvatarSettings_0;

		// Token: 0x0400358A RID: 13706
		private static readonly System.IntPtr NativeMethodInfoPtr_SetAvatarSettings_Public_Void_AvatarSettings_0;

		// Token: 0x0400358B RID: 13707
		private static readonly System.IntPtr NativeMethodInfoPtr_SetVisible_Networked_Private_Void_Boolean_0;

		// Token: 0x0400358C RID: 13708
		private static readonly System.IntPtr NativeMethodInfoPtr_EnterVehicle_Public_Void_LandVehicle_0;

		// Token: 0x0400358D RID: 13709
		private static readonly System.IntPtr NativeMethodInfoPtr_ExitVehicle_Public_Void_Transform_0;

		// Token: 0x0400358E RID: 13710
		private static readonly System.IntPtr NativeMethodInfoPtr_PreDestroyClientObjects_Private_Void_NetworkConnection_0;

		// Token: 0x0400358F RID: 13711
		private static readonly System.IntPtr NativeMethodInfoPtr_CurrentVehicleChanged_Private_Void_NetworkObject_NetworkObject_Boolean_0;

		// Token: 0x04003590 RID: 13712
		private static readonly System.IntPtr NativeMethodInfoPtr_AreAllPlayersReadyToSleep_Public_Static_Boolean_0;

		// Token: 0x04003591 RID: 13713
		private static readonly System.IntPtr NativeMethodInfoPtr_SleepStart_Private_Void_0;

		// Token: 0x04003592 RID: 13714
		private static readonly System.IntPtr NativeMethodInfoPtr_SetReadyToSleep_Public_Void_Boolean_0;

		// Token: 0x04003593 RID: 13715
		private static readonly System.IntPtr NativeMethodInfoPtr_SleepEnd_Private_Void_Int32_0;

		// Token: 0x04003594 RID: 13716
		private static readonly System.IntPtr NativeMethodInfoPtr_Activate_Public_Static_Void_0;

		// Token: 0x04003595 RID: 13717
		private static readonly System.IntPtr NativeMethodInfoPtr_Deactivate_Public_Static_Void_Boolean_0;

		// Token: 0x04003596 RID: 13718
		private static readonly System.IntPtr NativeMethodInfoPtr_ExitAll_Public_Void_0;

		// Token: 0x04003597 RID: 13719
		private static readonly System.IntPtr NativeMethodInfoPtr_SetVisibleToLocalPlayer_Public_Void_Boolean_0;

		// Token: 0x04003598 RID: 13720
		private static readonly System.IntPtr NativeMethodInfoPtr_SetPlayerCode_Public_Void_String_0;

		// Token: 0x04003599 RID: 13721
		private static readonly System.IntPtr NativeMethodInfoPtr_SendPunch_Public_Void_0;

		// Token: 0x0400359A RID: 13722
		private static readonly System.IntPtr NativeMethodInfoPtr_Punch_Private_Void_0;

		// Token: 0x0400359B RID: 13723
		private static readonly System.IntPtr NativeMethodInfoPtr_MarkIntroCompleted_Private_Void_BasicAvatarSettings_0;

		// Token: 0x0400359C RID: 13724
		private static readonly System.IntPtr NativeMethodInfoPtr_IsPointVisibleToPlayer_Public_Boolean_Vector3_Single_Single_0;

		// Token: 0x0400359D RID: 13725
		private static readonly System.IntPtr NativeMethodInfoPtr_GetClosestPlayer_Public_Static_Player_Vector3_byref_Single_List_1_Player_0;

		// Token: 0x0400359E RID: 13726
		private static readonly System.IntPtr NativeMethodInfoPtr_SetCapsuleColliderHeight_Public_Void_Single_0;

		// Token: 0x0400359F RID: 13727
		private static readonly System.IntPtr NativeMethodInfoPtr_SetScale_Public_Void_Single_0;

		// Token: 0x040035A0 RID: 13728
		private static readonly System.IntPtr NativeMethodInfoPtr_SetScale_Public_Void_Single_Single_0;

		// Token: 0x040035A1 RID: 13729
		private static readonly System.IntPtr NativeMethodInfoPtr_ApplyScale_Protected_Virtual_New_Void_1;

		// Token: 0x040035A2 RID: 13730
		private static readonly System.IntPtr NativeMethodInfoPtr_GetSaveString_Public_Virtual_New_String_0;

		// Token: 0x040035A3 RID: 13731
		private static readonly System.IntPtr NativeMethodInfoPtr_GetPlayerData_Public_PlayerData_0;

		// Token: 0x040035A4 RID: 13732
		private static readonly System.IntPtr NativeMethodInfoPtr_WriteData_Public_Virtual_New_List_1_String_String_0;

		// Token: 0x040035A5 RID: 13733
		private static readonly System.IntPtr NativeMethodInfoPtr_GetInventoryString_Public_String_0;

		// Token: 0x040035A6 RID: 13734
		private static readonly System.IntPtr NativeMethodInfoPtr_GetAppearanceString_Public_String_0;

		// Token: 0x040035A7 RID: 13735
		private static readonly System.IntPtr NativeMethodInfoPtr_GetClothingString_Public_String_0;

		// Token: 0x040035A8 RID: 13736
		private static readonly System.IntPtr NativeMethodInfoPtr_GetVariablesString_Public_String_0;

		// Token: 0x040035A9 RID: 13737
		private static readonly System.IntPtr NativeMethodInfoPtr_Load_Public_Virtual_New_Void_PlayerData_String_0;

		// Token: 0x040035AA RID: 13738
		private static readonly System.IntPtr NativeMethodInfoPtr_Load_Public_Virtual_New_Void_PlayerData_0;

		// Token: 0x040035AB RID: 13739
		private static readonly System.IntPtr NativeMethodInfoPtr_LoadInventory_Public_Virtual_New_Void_String_0;

		// Token: 0x040035AC RID: 13740
		private static readonly System.IntPtr NativeMethodInfoPtr_LoadAppearance_Public_Virtual_New_Void_String_0;

		// Token: 0x040035AD RID: 13741
		private static readonly System.IntPtr NativeMethodInfoPtr_LoadClothing_Public_Virtual_New_Void_String_0;

		// Token: 0x040035AE RID: 13742
		private static readonly System.IntPtr NativeMethodInfoPtr_SetRagdolled_Public_Void_Boolean_0;

		// Token: 0x040035AF RID: 13743
		private static readonly System.IntPtr NativeMethodInfoPtr_SendImpact_Public_Virtual_New_Void_Impact_0;

		// Token: 0x040035B0 RID: 13744
		private static readonly System.IntPtr NativeMethodInfoPtr_ReceiveImpact_Public_Virtual_New_Void_Impact_0;

		// Token: 0x040035B1 RID: 13745
		private static readonly System.IntPtr NativeMethodInfoPtr_ProcessImpactForce_Public_Virtual_New_Void_Vector3_Vector3_Single_0;

		// Token: 0x040035B2 RID: 13746
		private static readonly System.IntPtr NativeMethodInfoPtr_OnDied_Public_Virtual_New_Void_0;

		// Token: 0x040035B3 RID: 13747
		private static readonly System.IntPtr NativeMethodInfoPtr_OnRevived_Public_Virtual_New_Void_0;

		// Token: 0x040035B4 RID: 13748
		private static readonly System.IntPtr NativeMethodInfoPtr_Arrest_Public_Void_0;

		// Token: 0x040035B5 RID: 13749
		private static readonly System.IntPtr NativeMethodInfoPtr_Free_Public_Void_0;

		// Token: 0x040035B6 RID: 13750
		private static readonly System.IntPtr NativeMethodInfoPtr_SendPassOut_Public_Void_0;

		// Token: 0x040035B7 RID: 13751
		private static readonly System.IntPtr NativeMethodInfoPtr_PassOut_Public_Void_0;

		// Token: 0x040035B8 RID: 13752
		private static readonly System.IntPtr NativeMethodInfoPtr_SendPassOutRecovery_Public_Void_0;

		// Token: 0x040035B9 RID: 13753
		private static readonly System.IntPtr NativeMethodInfoPtr_PassOutRecovery_Public_Void_0;

		// Token: 0x040035BA RID: 13754
		private static readonly System.IntPtr NativeMethodInfoPtr_SendEquippable_Networked_Public_Void_String_0;

		// Token: 0x040035BB RID: 13755
		private static readonly System.IntPtr NativeMethodInfoPtr_SetEquippable_Networked_Private_Void_String_0;

		// Token: 0x040035BC RID: 13756
		private static readonly System.IntPtr NativeMethodInfoPtr_SendEquippableMessage_Networked_Public_Void_String_Int32_0;

		// Token: 0x040035BD RID: 13757
		private static readonly System.IntPtr NativeMethodInfoPtr_ReceiveEquippableMessage_Networked_Private_Void_String_Int32_0;

		// Token: 0x040035BE RID: 13758
		private static readonly System.IntPtr NativeMethodInfoPtr_SendEquippableMessage_Networked_Vector_Public_Void_String_Int32_Vector3_0;

		// Token: 0x040035BF RID: 13759
		private static readonly System.IntPtr NativeMethodInfoPtr_ReceiveEquippableMessage_Networked_Vector_Private_Void_String_Int32_Vector3_0;

		// Token: 0x040035C0 RID: 13760
		private static readonly System.IntPtr NativeMethodInfoPtr_SendAnimationTrigger_Public_Void_String_0;

		// Token: 0x040035C1 RID: 13761
		private static readonly System.IntPtr NativeMethodInfoPtr_SetAnimationTrigger_Networked_Public_Void_NetworkConnection_String_0;

		// Token: 0x040035C2 RID: 13762
		private static readonly System.IntPtr NativeMethodInfoPtr_SetAnimationTrigger_Public_Void_String_0;

		// Token: 0x040035C3 RID: 13763
		private static readonly System.IntPtr NativeMethodInfoPtr_ResetAnimationTrigger_Networked_Public_Void_NetworkConnection_String_0;

		// Token: 0x040035C4 RID: 13764
		private static readonly System.IntPtr NativeMethodInfoPtr_ResetAnimationTrigger_Public_Void_String_0;

		// Token: 0x040035C5 RID: 13765
		private static readonly System.IntPtr NativeMethodInfoPtr_SendAnimationBool_Public_Void_String_Boolean_0;

		// Token: 0x040035C6 RID: 13766
		private static readonly System.IntPtr NativeMethodInfoPtr_SetAnimationBool_Public_Void_String_Boolean_0;

		// Token: 0x040035C7 RID: 13767
		private static readonly System.IntPtr NativeMethodInfoPtr_Taze_Public_Void_0;

		// Token: 0x040035C8 RID: 13768
		private static readonly System.IntPtr NativeMethodInfoPtr_SetInventoryItem_Public_Void_Int32_ItemInstance_0;

		// Token: 0x040035C9 RID: 13769
		private static readonly System.IntPtr NativeMethodInfoPtr_GetNetworth_Private_Void_FloatContainer_0;

		// Token: 0x040035CA RID: 13770
		private static readonly System.IntPtr NativeMethodInfoPtr_SendAppearance_Public_Void_BasicAvatarSettings_0;

		// Token: 0x040035CB RID: 13771
		private static readonly System.IntPtr NativeMethodInfoPtr_SetAppearance_Public_Void_BasicAvatarSettings_Boolean_0;

		// Token: 0x040035CC RID: 13772
		private static readonly System.IntPtr NativeMethodInfoPtr_MountSkateboard_Public_Void_Skateboard_0;

		// Token: 0x040035CD RID: 13773
		private static readonly System.IntPtr NativeMethodInfoPtr_SendMountedSkateboard_Private_Void_NetworkObject_0;

		// Token: 0x040035CE RID: 13774
		private static readonly System.IntPtr NativeMethodInfoPtr_SetMountedSkateboard_Private_Void_NetworkObject_0;

		// Token: 0x040035CF RID: 13775
		private static readonly System.IntPtr NativeMethodInfoPtr_DismountSkateboard_Public_Void_0;

		// Token: 0x040035D0 RID: 13776
		private static readonly System.IntPtr NativeMethodInfoPtr_ConsumeProduct_Public_Void_ProductItemInstance_0;

		// Token: 0x040035D1 RID: 13777
		private static readonly System.IntPtr NativeMethodInfoPtr_SendConsumeProduct_Private_Void_ProductItemInstance_0;

		// Token: 0x040035D2 RID: 13778
		private static readonly System.IntPtr NativeMethodInfoPtr_ReceiveConsumeProduct_Private_Void_ProductItemInstance_0;

		// Token: 0x040035D3 RID: 13779
		private static readonly System.IntPtr NativeMethodInfoPtr_ConsumeProductInternal_Private_Void_ProductItemInstance_0;

		// Token: 0x040035D4 RID: 13780
		private static readonly System.IntPtr NativeMethodInfoPtr_ClearProduct_Public_Void_0;

		// Token: 0x040035D5 RID: 13781
		private static readonly System.IntPtr NativeMethodInfoPtr_CreatePlayerVariables_Private_Void_0;

		// Token: 0x040035D6 RID: 13782
		private static readonly System.IntPtr NativeMethodInfoPtr_GetVariable_Public_BaseVariable_String_0;

		// Token: 0x040035D7 RID: 13783
		private static readonly System.IntPtr NativeMethodInfoPtr_GetValue_Public_T_String_0;

		// Token: 0x040035D8 RID: 13784
		private static readonly System.IntPtr NativeMethodInfoPtr_SetVariableValue_Public_Void_String_String_Boolean_0;

		// Token: 0x040035D9 RID: 13785
		private static readonly System.IntPtr NativeMethodInfoPtr_AddVariable_Public_Void_BaseVariable_0;

		// Token: 0x040035DA RID: 13786
		private static readonly System.IntPtr NativeMethodInfoPtr_SendValue_Public_Void_String_String_Boolean_0;

		// Token: 0x040035DB RID: 13787
		private static readonly System.IntPtr NativeMethodInfoPtr_ReceiveValue_Private_Void_NetworkConnection_String_String_0;

		// Token: 0x040035DC RID: 13788
		private static readonly System.IntPtr NativeMethodInfoPtr_ReceiveValue_Private_Void_String_String_0;

		// Token: 0x040035DD RID: 13789
		private static readonly System.IntPtr NativeMethodInfoPtr_LoadVariable_Public_Void_VariableData_0;

		// Token: 0x040035DE RID: 13790
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040035DF RID: 13791
		private static readonly System.IntPtr NativeMethodInfoPtr__RecalculateCurrentProperty_b__249_0_Private_Single_Property_0;

		// Token: 0x040035E0 RID: 13792
		private static readonly System.IntPtr NativeMethodInfoPtr__RecalculateCurrentProperty_b__249_1_Private_Single_Business_0;

		// Token: 0x040035E1 RID: 13793
		private static readonly System.IntPtr NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0;

		// Token: 0x040035E2 RID: 13794
		private static readonly System.IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

		// Token: 0x040035E3 RID: 13795
		private static readonly System.IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

		// Token: 0x040035E4 RID: 13796
		private static readonly System.IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

		// Token: 0x040035E5 RID: 13797
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcWriter___Server_set_CurrentVehicle_3323014238_Private_Void_NetworkObject_0;

		// Token: 0x040035E6 RID: 13798
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcLogic___set_CurrentVehicle_3323014238_Public_Void_NetworkObject_0;

		// Token: 0x040035E7 RID: 13799
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcReader___Server_set_CurrentVehicle_3323014238_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x040035E8 RID: 13800
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcWriter___Server_set_CurrentBed_3323014238_Private_Void_NetworkObject_0;

		// Token: 0x040035E9 RID: 13801
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcLogic___set_CurrentBed_3323014238_Public_Void_NetworkObject_0;

		// Token: 0x040035EA RID: 13802
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcReader___Server_set_CurrentBed_3323014238_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x040035EB RID: 13803
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcWriter___Server_set_IsSkating_1140765316_Private_Void_Boolean_0;

		// Token: 0x040035EC RID: 13804
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcLogic___set_IsSkating_1140765316_Public_Void_Boolean_0;

		// Token: 0x040035ED RID: 13805
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcReader___Server_set_IsSkating_1140765316_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x040035EE RID: 13806
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcWriter___Server_set_CameraPosition_4276783012_Private_Void_Vector3_0;

		// Token: 0x040035EF RID: 13807
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcLogic___set_CameraPosition_4276783012_Public_Void_Vector3_0;

		// Token: 0x040035F0 RID: 13808
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcReader___Server_set_CameraPosition_4276783012_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x040035F1 RID: 13809
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcWriter___Server_set_CameraRotation_3429297120_Private_Void_Quaternion_0;

		// Token: 0x040035F2 RID: 13810
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcLogic___set_CameraRotation_3429297120_Public_Void_Quaternion_0;

		// Token: 0x040035F3 RID: 13811
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcReader___Server_set_CameraRotation_3429297120_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x040035F4 RID: 13812
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcWriter___Server_RequestSavePlayer_2166136261_Private_Void_0;

		// Token: 0x040035F5 RID: 13813
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcLogic___RequestSavePlayer_2166136261_Public_Void_0;

		// Token: 0x040035F6 RID: 13814
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcReader___Server_RequestSavePlayer_2166136261_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x040035F7 RID: 13815
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcWriter___Observers_ReturnSaveRequest_214505783_Private_Void_NetworkConnection_Boolean_0;

		// Token: 0x040035F8 RID: 13816
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcLogic___ReturnSaveRequest_214505783_Private_Void_NetworkConnection_Boolean_0;

		// Token: 0x040035F9 RID: 13817
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcReader___Observers_ReturnSaveRequest_214505783_Private_Void_PooledReader_Channel_0;

		// Token: 0x040035FA RID: 13818
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcWriter___Target_ReturnSaveRequest_214505783_Private_Void_NetworkConnection_Boolean_0;

		// Token: 0x040035FB RID: 13819
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcReader___Target_ReturnSaveRequest_214505783_Private_Void_PooledReader_Channel_0;

		// Token: 0x040035FC RID: 13820
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcWriter___Observers_HostExitedGame_2166136261_Private_Void_0;

		// Token: 0x040035FD RID: 13821
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcLogic___HostExitedGame_2166136261_Public_Void_0;

		// Token: 0x040035FE RID: 13822
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcReader___Observers_HostExitedGame_2166136261_Private_Void_PooledReader_Channel_0;

		// Token: 0x040035FF RID: 13823
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcWriter___Server_SendPlayerNameData_586648380_Private_Void_String_UInt64_0;

		// Token: 0x04003600 RID: 13824
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcLogic___SendPlayerNameData_586648380_Public_Void_String_UInt64_0;

		// Token: 0x04003601 RID: 13825
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcReader___Server_SendPlayerNameData_586648380_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x04003602 RID: 13826
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcWriter___Server_RequestPlayerData_3615296227_Private_Void_String_0;

		// Token: 0x04003603 RID: 13827
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcLogic___RequestPlayerData_3615296227_Public_Void_String_0;

		// Token: 0x04003604 RID: 13828
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcReader___Server_RequestPlayerData_3615296227_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x04003605 RID: 13829
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcWriter___Server_MarkPlayerInitialized_2166136261_Private_Void_0;

		// Token: 0x04003606 RID: 13830
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcLogic___MarkPlayerInitialized_2166136261_Public_Void_0;

		// Token: 0x04003607 RID: 13831
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcReader___Server_MarkPlayerInitialized_2166136261_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x04003608 RID: 13832
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcWriter___Observers_ReceivePlayerData_3244732873_Private_Void_NetworkConnection_PlayerData_String_String_String_Il2CppReferenceArray_1_VariableData_0;

		// Token: 0x04003609 RID: 13833
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcLogic___ReceivePlayerData_3244732873_Public_Void_NetworkConnection_PlayerData_String_String_String_Il2CppReferenceArray_1_VariableData_0;

		// Token: 0x0400360A RID: 13834
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcReader___Observers_ReceivePlayerData_3244732873_Private_Void_PooledReader_Channel_0;

		// Token: 0x0400360B RID: 13835
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcWriter___Target_ReceivePlayerData_3244732873_Private_Void_NetworkConnection_PlayerData_String_String_String_Il2CppReferenceArray_1_VariableData_0;

		// Token: 0x0400360C RID: 13836
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcReader___Target_ReceivePlayerData_3244732873_Private_Void_PooledReader_Channel_0;

		// Token: 0x0400360D RID: 13837
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcWriter___Observers_ReceivePlayerNameData_3895153758_Private_Void_NetworkConnection_String_String_0;

		// Token: 0x0400360E RID: 13838
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcLogic___ReceivePlayerNameData_3895153758_Private_Void_NetworkConnection_String_String_0;

		// Token: 0x0400360F RID: 13839
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcReader___Observers_ReceivePlayerNameData_3895153758_Private_Void_PooledReader_Channel_0;

		// Token: 0x04003610 RID: 13840
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcWriter___Target_ReceivePlayerNameData_3895153758_Private_Void_NetworkConnection_String_String_0;

		// Token: 0x04003611 RID: 13841
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcReader___Target_ReceivePlayerNameData_3895153758_Private_Void_PooledReader_Channel_0;

		// Token: 0x04003612 RID: 13842
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcWriter___Server_SendFlashlightOnNetworked_1140765316_Private_Void_Boolean_0;

		// Token: 0x04003613 RID: 13843
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcLogic___SendFlashlightOnNetworked_1140765316_Private_Void_Boolean_0;

		// Token: 0x04003614 RID: 13844
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcReader___Server_SendFlashlightOnNetworked_1140765316_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x04003615 RID: 13845
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcWriter___Observers_SetFlashlightOn_1140765316_Private_Void_Boolean_0;

		// Token: 0x04003616 RID: 13846
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcLogic___SetFlashlightOn_1140765316_Private_Void_Boolean_0;

		// Token: 0x04003617 RID: 13847
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcReader___Observers_SetFlashlightOn_1140765316_Private_Void_PooledReader_Channel_0;

		// Token: 0x04003618 RID: 13848
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcWriter___Observers_PlayJumpAnimation_2166136261_Private_Void_0;

		// Token: 0x04003619 RID: 13849
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcLogic___PlayJumpAnimation_2166136261_Public_Void_0;

		// Token: 0x0400361A RID: 13850
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcReader___Observers_PlayJumpAnimation_2166136261_Private_Void_PooledReader_Channel_0;

		// Token: 0x0400361B RID: 13851
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcWriter___Server_SendCrouched_1140765316_Private_Void_Boolean_0;

		// Token: 0x0400361C RID: 13852
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcLogic___SendCrouched_1140765316_Public_Void_Boolean_0;

		// Token: 0x0400361D RID: 13853
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcReader___Server_SendCrouched_1140765316_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x0400361E RID: 13854
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcWriter___Target_ReceiveCrouched_214505783_Private_Void_NetworkConnection_Boolean_0;

		// Token: 0x0400361F RID: 13855
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcLogic___ReceiveCrouched_214505783_Private_Void_NetworkConnection_Boolean_0;

		// Token: 0x04003620 RID: 13856
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcReader___Target_ReceiveCrouched_214505783_Private_Void_PooledReader_Channel_0;

		// Token: 0x04003621 RID: 13857
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcWriter___Observers_ReceiveCrouched_214505783_Private_Void_NetworkConnection_Boolean_0;

		// Token: 0x04003622 RID: 13858
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcReader___Observers_ReceiveCrouched_214505783_Private_Void_PooledReader_Channel_0;

		// Token: 0x04003623 RID: 13859
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcWriter___Server_SendAvatarSettings_4281687581_Private_Void_AvatarSettings_0;

		// Token: 0x04003624 RID: 13860
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcLogic___SendAvatarSettings_4281687581_Public_Void_AvatarSettings_0;

		// Token: 0x04003625 RID: 13861
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcReader___Server_SendAvatarSettings_4281687581_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x04003626 RID: 13862
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcWriter___Observers_SetAvatarSettings_4281687581_Private_Void_AvatarSettings_0;

		// Token: 0x04003627 RID: 13863
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcLogic___SetAvatarSettings_4281687581_Public_Void_AvatarSettings_0;

		// Token: 0x04003628 RID: 13864
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcReader___Observers_SetAvatarSettings_4281687581_Private_Void_PooledReader_Channel_0;

		// Token: 0x04003629 RID: 13865
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcWriter___Observers_SetVisible_Networked_1140765316_Private_Void_Boolean_0;

		// Token: 0x0400362A RID: 13866
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcLogic___SetVisible_Networked_1140765316_Private_Void_Boolean_0;

		// Token: 0x0400362B RID: 13867
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcReader___Observers_SetVisible_Networked_1140765316_Private_Void_PooledReader_Channel_0;

		// Token: 0x0400362C RID: 13868
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcWriter___Server_SetReadyToSleep_1140765316_Private_Void_Boolean_0;

		// Token: 0x0400362D RID: 13869
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcLogic___SetReadyToSleep_1140765316_Public_Void_Boolean_0;

		// Token: 0x0400362E RID: 13870
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcReader___Server_SetReadyToSleep_1140765316_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x0400362F RID: 13871
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcWriter___Observers_SetPlayerCode_3615296227_Private_Void_String_0;

		// Token: 0x04003630 RID: 13872
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcLogic___SetPlayerCode_3615296227_Public_Void_String_0;

		// Token: 0x04003631 RID: 13873
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcReader___Observers_SetPlayerCode_3615296227_Private_Void_PooledReader_Channel_0;

		// Token: 0x04003632 RID: 13874
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcWriter___Server_SendPunch_2166136261_Private_Void_0;

		// Token: 0x04003633 RID: 13875
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcLogic___SendPunch_2166136261_Public_Void_0;

		// Token: 0x04003634 RID: 13876
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcReader___Server_SendPunch_2166136261_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x04003635 RID: 13877
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcWriter___Observers_Punch_2166136261_Private_Void_0;

		// Token: 0x04003636 RID: 13878
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcLogic___Punch_2166136261_Private_Void_0;

		// Token: 0x04003637 RID: 13879
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcReader___Observers_Punch_2166136261_Private_Void_PooledReader_Channel_0;

		// Token: 0x04003638 RID: 13880
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcWriter___Server_MarkIntroCompleted_3281254764_Private_Void_BasicAvatarSettings_0;

		// Token: 0x04003639 RID: 13881
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcLogic___MarkIntroCompleted_3281254764_Private_Void_BasicAvatarSettings_0;

		// Token: 0x0400363A RID: 13882
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcReader___Server_MarkIntroCompleted_3281254764_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x0400363B RID: 13883
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcWriter___Server_SendImpact_427288424_Private_Void_Impact_0;

		// Token: 0x0400363C RID: 13884
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcLogic___SendImpact_427288424_Public_Virtual_New_Void_Impact_0;

		// Token: 0x0400363D RID: 13885
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcReader___Server_SendImpact_427288424_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x0400363E RID: 13886
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcWriter___Observers_ReceiveImpact_427288424_Private_Void_Impact_0;

		// Token: 0x0400363F RID: 13887
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcLogic___ReceiveImpact_427288424_Public_Virtual_New_Void_Impact_0;

		// Token: 0x04003640 RID: 13888
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcReader___Observers_ReceiveImpact_427288424_Private_Void_PooledReader_Channel_0;

		// Token: 0x04003641 RID: 13889
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcWriter___Observers_Arrest_2166136261_Private_Void_0;

		// Token: 0x04003642 RID: 13890
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcLogic___Arrest_2166136261_Public_Void_0;

		// Token: 0x04003643 RID: 13891
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcReader___Observers_Arrest_2166136261_Private_Void_PooledReader_Channel_0;

		// Token: 0x04003644 RID: 13892
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcWriter___Server_SendPassOut_2166136261_Private_Void_0;

		// Token: 0x04003645 RID: 13893
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcLogic___SendPassOut_2166136261_Public_Void_0;

		// Token: 0x04003646 RID: 13894
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcReader___Server_SendPassOut_2166136261_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x04003647 RID: 13895
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcWriter___Observers_PassOut_2166136261_Private_Void_0;

		// Token: 0x04003648 RID: 13896
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcLogic___PassOut_2166136261_Public_Void_0;

		// Token: 0x04003649 RID: 13897
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcReader___Observers_PassOut_2166136261_Private_Void_PooledReader_Channel_0;

		// Token: 0x0400364A RID: 13898
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcWriter___Server_SendPassOutRecovery_2166136261_Private_Void_0;

		// Token: 0x0400364B RID: 13899
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcLogic___SendPassOutRecovery_2166136261_Public_Void_0;

		// Token: 0x0400364C RID: 13900
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcReader___Server_SendPassOutRecovery_2166136261_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x0400364D RID: 13901
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcWriter___Observers_PassOutRecovery_2166136261_Private_Void_0;

		// Token: 0x0400364E RID: 13902
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcLogic___PassOutRecovery_2166136261_Public_Void_0;

		// Token: 0x0400364F RID: 13903
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcReader___Observers_PassOutRecovery_2166136261_Private_Void_PooledReader_Channel_0;

		// Token: 0x04003650 RID: 13904
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcWriter___Server_SendEquippable_Networked_3615296227_Private_Void_String_0;

		// Token: 0x04003651 RID: 13905
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcLogic___SendEquippable_Networked_3615296227_Public_Void_String_0;

		// Token: 0x04003652 RID: 13906
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcReader___Server_SendEquippable_Networked_3615296227_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x04003653 RID: 13907
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcWriter___Observers_SetEquippable_Networked_3615296227_Private_Void_String_0;

		// Token: 0x04003654 RID: 13908
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcLogic___SetEquippable_Networked_3615296227_Private_Void_String_0;

		// Token: 0x04003655 RID: 13909
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcReader___Observers_SetEquippable_Networked_3615296227_Private_Void_PooledReader_Channel_0;

		// Token: 0x04003656 RID: 13910
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcWriter___Server_SendEquippableMessage_Networked_3643459082_Private_Void_String_Int32_0;

		// Token: 0x04003657 RID: 13911
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcLogic___SendEquippableMessage_Networked_3643459082_Public_Void_String_Int32_0;

		// Token: 0x04003658 RID: 13912
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcReader___Server_SendEquippableMessage_Networked_3643459082_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x04003659 RID: 13913
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcWriter___Observers_ReceiveEquippableMessage_Networked_3643459082_Private_Void_String_Int32_0;

		// Token: 0x0400365A RID: 13914
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcLogic___ReceiveEquippableMessage_Networked_3643459082_Private_Void_String_Int32_0;

		// Token: 0x0400365B RID: 13915
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcReader___Observers_ReceiveEquippableMessage_Networked_3643459082_Private_Void_PooledReader_Channel_0;

		// Token: 0x0400365C RID: 13916
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcWriter___Server_SendEquippableMessage_Networked_Vector_3190074053_Private_Void_String_Int32_Vector3_0;

		// Token: 0x0400365D RID: 13917
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcLogic___SendEquippableMessage_Networked_Vector_3190074053_Public_Void_String_Int32_Vector3_0;

		// Token: 0x0400365E RID: 13918
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcReader___Server_SendEquippableMessage_Networked_Vector_3190074053_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x0400365F RID: 13919
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcWriter___Observers_ReceiveEquippableMessage_Networked_Vector_3190074053_Private_Void_String_Int32_Vector3_0;

		// Token: 0x04003660 RID: 13920
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcLogic___ReceiveEquippableMessage_Networked_Vector_3190074053_Private_Void_String_Int32_Vector3_0;

		// Token: 0x04003661 RID: 13921
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcReader___Observers_ReceiveEquippableMessage_Networked_Vector_3190074053_Private_Void_PooledReader_Channel_0;

		// Token: 0x04003662 RID: 13922
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcWriter___Server_SendAnimationTrigger_3615296227_Private_Void_String_0;

		// Token: 0x04003663 RID: 13923
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcLogic___SendAnimationTrigger_3615296227_Public_Void_String_0;

		// Token: 0x04003664 RID: 13924
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcReader___Server_SendAnimationTrigger_3615296227_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x04003665 RID: 13925
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcWriter___Observers_SetAnimationTrigger_Networked_2971853958_Private_Void_NetworkConnection_String_0;

		// Token: 0x04003666 RID: 13926
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcLogic___SetAnimationTrigger_Networked_2971853958_Public_Void_NetworkConnection_String_0;

		// Token: 0x04003667 RID: 13927
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcReader___Observers_SetAnimationTrigger_Networked_2971853958_Private_Void_PooledReader_Channel_0;

		// Token: 0x04003668 RID: 13928
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcWriter___Target_SetAnimationTrigger_Networked_2971853958_Private_Void_NetworkConnection_String_0;

		// Token: 0x04003669 RID: 13929
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcReader___Target_SetAnimationTrigger_Networked_2971853958_Private_Void_PooledReader_Channel_0;

		// Token: 0x0400366A RID: 13930
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcWriter___Observers_ResetAnimationTrigger_Networked_2971853958_Private_Void_NetworkConnection_String_0;

		// Token: 0x0400366B RID: 13931
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcLogic___ResetAnimationTrigger_Networked_2971853958_Public_Void_NetworkConnection_String_0;

		// Token: 0x0400366C RID: 13932
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcReader___Observers_ResetAnimationTrigger_Networked_2971853958_Private_Void_PooledReader_Channel_0;

		// Token: 0x0400366D RID: 13933
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcWriter___Target_ResetAnimationTrigger_Networked_2971853958_Private_Void_NetworkConnection_String_0;

		// Token: 0x0400366E RID: 13934
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcReader___Target_ResetAnimationTrigger_Networked_2971853958_Private_Void_PooledReader_Channel_0;

		// Token: 0x0400366F RID: 13935
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcWriter___Server_SendAnimationBool_310431262_Private_Void_String_Boolean_0;

		// Token: 0x04003670 RID: 13936
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcLogic___SendAnimationBool_310431262_Public_Void_String_Boolean_0;

		// Token: 0x04003671 RID: 13937
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcReader___Server_SendAnimationBool_310431262_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x04003672 RID: 13938
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcWriter___Observers_SetAnimationBool_310431262_Private_Void_String_Boolean_0;

		// Token: 0x04003673 RID: 13939
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcLogic___SetAnimationBool_310431262_Public_Void_String_Boolean_0;

		// Token: 0x04003674 RID: 13940
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcReader___Observers_SetAnimationBool_310431262_Private_Void_PooledReader_Channel_0;

		// Token: 0x04003675 RID: 13941
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcWriter___Observers_Taze_2166136261_Private_Void_0;

		// Token: 0x04003676 RID: 13942
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcLogic___Taze_2166136261_Public_Void_0;

		// Token: 0x04003677 RID: 13943
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcReader___Observers_Taze_2166136261_Private_Void_PooledReader_Channel_0;

		// Token: 0x04003678 RID: 13944
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcWriter___Server_SetInventoryItem_2317364410_Private_Void_Int32_ItemInstance_0;

		// Token: 0x04003679 RID: 13945
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcLogic___SetInventoryItem_2317364410_Public_Void_Int32_ItemInstance_0;

		// Token: 0x0400367A RID: 13946
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcReader___Server_SetInventoryItem_2317364410_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x0400367B RID: 13947
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcWriter___Server_SendAppearance_3281254764_Private_Void_BasicAvatarSettings_0;

		// Token: 0x0400367C RID: 13948
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcLogic___SendAppearance_3281254764_Public_Void_BasicAvatarSettings_0;

		// Token: 0x0400367D RID: 13949
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcReader___Server_SendAppearance_3281254764_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x0400367E RID: 13950
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcWriter___Observers_SetAppearance_2139595489_Private_Void_BasicAvatarSettings_Boolean_0;

		// Token: 0x0400367F RID: 13951
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcLogic___SetAppearance_2139595489_Public_Void_BasicAvatarSettings_Boolean_0;

		// Token: 0x04003680 RID: 13952
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcReader___Observers_SetAppearance_2139595489_Private_Void_PooledReader_Channel_0;

		// Token: 0x04003681 RID: 13953
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcWriter___Server_SendMountedSkateboard_3323014238_Private_Void_NetworkObject_0;

		// Token: 0x04003682 RID: 13954
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcLogic___SendMountedSkateboard_3323014238_Private_Void_NetworkObject_0;

		// Token: 0x04003683 RID: 13955
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcReader___Server_SendMountedSkateboard_3323014238_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x04003684 RID: 13956
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcWriter___Observers_SetMountedSkateboard_3323014238_Private_Void_NetworkObject_0;

		// Token: 0x04003685 RID: 13957
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcLogic___SetMountedSkateboard_3323014238_Private_Void_NetworkObject_0;

		// Token: 0x04003686 RID: 13958
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcReader___Observers_SetMountedSkateboard_3323014238_Private_Void_PooledReader_Channel_0;

		// Token: 0x04003687 RID: 13959
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcWriter___Server_SendConsumeProduct_2622925554_Private_Void_ProductItemInstance_0;

		// Token: 0x04003688 RID: 13960
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcLogic___SendConsumeProduct_2622925554_Private_Void_ProductItemInstance_0;

		// Token: 0x04003689 RID: 13961
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcReader___Server_SendConsumeProduct_2622925554_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x0400368A RID: 13962
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcWriter___Observers_ReceiveConsumeProduct_2622925554_Private_Void_ProductItemInstance_0;

		// Token: 0x0400368B RID: 13963
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcLogic___ReceiveConsumeProduct_2622925554_Private_Void_ProductItemInstance_0;

		// Token: 0x0400368C RID: 13964
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcReader___Observers_ReceiveConsumeProduct_2622925554_Private_Void_PooledReader_Channel_0;

		// Token: 0x0400368D RID: 13965
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcWriter___Server_SendValue_3589193952_Private_Void_String_String_Boolean_0;

		// Token: 0x0400368E RID: 13966
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcLogic___SendValue_3589193952_Public_Void_String_String_Boolean_0;

		// Token: 0x0400368F RID: 13967
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcReader___Server_SendValue_3589193952_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x04003690 RID: 13968
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcWriter___Target_ReceiveValue_3895153758_Private_Void_NetworkConnection_String_String_0;

		// Token: 0x04003691 RID: 13969
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcLogic___ReceiveValue_3895153758_Private_Void_NetworkConnection_String_String_0;

		// Token: 0x04003692 RID: 13970
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcReader___Target_ReceiveValue_3895153758_Private_Void_PooledReader_Channel_0;

		// Token: 0x04003693 RID: 13971
		private static readonly System.IntPtr NativeMethodInfoPtr_sync___get_value__PlayerName_k__BackingField_Public_get_String_0;

		// Token: 0x04003694 RID: 13972
		private static readonly System.IntPtr NativeMethodInfoPtr_sync___set_value__PlayerName_k__BackingField_Public_set_Void_String_Boolean_0;

		// Token: 0x04003695 RID: 13973
		private static readonly System.IntPtr NativeMethodInfoPtr_ReadSyncVar___ScheduleOne_PlayerScripts_Player_Public_Virtual_Boolean_PooledReader_UInt32_Boolean_0;

		// Token: 0x04003696 RID: 13974
		private static readonly System.IntPtr NativeMethodInfoPtr_sync___get_value__PlayerCode_k__BackingField_Public_get_String_0;

		// Token: 0x04003697 RID: 13975
		private static readonly System.IntPtr NativeMethodInfoPtr_sync___set_value__PlayerCode_k__BackingField_Public_set_Void_String_Boolean_0;

		// Token: 0x04003698 RID: 13976
		private static readonly System.IntPtr NativeMethodInfoPtr_sync___get_value__CurrentVehicle_k__BackingField_Public_get_NetworkObject_0;

		// Token: 0x04003699 RID: 13977
		private static readonly System.IntPtr NativeMethodInfoPtr_sync___set_value__CurrentVehicle_k__BackingField_Public_set_Void_NetworkObject_Boolean_0;

		// Token: 0x0400369A RID: 13978
		private static readonly System.IntPtr NativeMethodInfoPtr_sync___get_value__CurrentBed_k__BackingField_Public_get_NetworkObject_0;

		// Token: 0x0400369B RID: 13979
		private static readonly System.IntPtr NativeMethodInfoPtr_sync___set_value__CurrentBed_k__BackingField_Public_set_Void_NetworkObject_Boolean_0;

		// Token: 0x0400369C RID: 13980
		private static readonly System.IntPtr NativeMethodInfoPtr_sync___get_value__IsReadyToSleep_k__BackingField_Public_get_Boolean_0;

		// Token: 0x0400369D RID: 13981
		private static readonly System.IntPtr NativeMethodInfoPtr_sync___set_value__IsReadyToSleep_k__BackingField_Public_set_Void_Boolean_Boolean_0;

		// Token: 0x0400369E RID: 13982
		private static readonly System.IntPtr NativeMethodInfoPtr_sync___get_value__CameraPosition_k__BackingField_Public_get_Vector3_0;

		// Token: 0x0400369F RID: 13983
		private static readonly System.IntPtr NativeMethodInfoPtr_sync___set_value__CameraPosition_k__BackingField_Public_set_Void_Vector3_Boolean_0;

		// Token: 0x040036A0 RID: 13984
		private static readonly System.IntPtr NativeMethodInfoPtr_sync___get_value__CameraRotation_k__BackingField_Public_get_Quaternion_0;

		// Token: 0x040036A1 RID: 13985
		private static readonly System.IntPtr NativeMethodInfoPtr_sync___set_value__CameraRotation_k__BackingField_Public_set_Void_Quaternion_Boolean_0;

		// Token: 0x040036A2 RID: 13986
		private static readonly System.IntPtr NativeMethodInfoPtr_Method_Protected_Virtual_New_Void_0;

		// Token: 0x020009DA RID: 2522
		public sealed class VehicleEvent : Il2CppSystem.MulticastDelegate
		{
			// Token: 0x0600CF87 RID: 53127 RVA: 0x00324C90 File Offset: 0x00322E90
			// Note: this type is marked as 'beforefieldinit'.
			static VehicleEvent()
			{
				Il2CppClassPointerStore<Player.VehicleEvent>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Player>.NativeClassPtr, "VehicleEvent");
				Player.VehicleEvent.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player.VehicleEvent>.NativeClassPtr, 100673431);
				Player.VehicleEvent.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_LandVehicle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player.VehicleEvent>.NativeClassPtr, 100673432);
				Player.VehicleEvent.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_LandVehicle_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player.VehicleEvent>.NativeClassPtr, 100673433);
				Player.VehicleEvent.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player.VehicleEvent>.NativeClassPtr, 100673434);
			}

			// Token: 0x0600CF88 RID: 53128 RVA: 0x00324D04 File Offset: 0x00322F04
			[CallerCount(90)]
			[CachedScanResults(RefRangeStart = 110018, RefRangeEnd = 110108, XrefRangeStart = 110018, XrefRangeEnd = 110108, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe VehicleEvent(Il2CppSystem.Object @object, System.IntPtr method) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Player.VehicleEvent>.NativeClassPtr))
			{
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref method;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.VehicleEvent.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600CF89 RID: 53129 RVA: 0x00324D60 File Offset: 0x00322F60
			[CallerCount(0)]
			public unsafe void Invoke(LandVehicle vehicle)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(vehicle);
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.VehicleEvent.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_LandVehicle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600CF8A RID: 53130 RVA: 0x00324DA4 File Offset: 0x00322FA4
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 77936, RefRangeEnd = 77937, XrefRangeStart = 77936, XrefRangeEnd = 77937, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Il2CppSystem.IAsyncResult BeginInvoke(LandVehicle vehicle, Il2CppSystem.AsyncCallback callback, Il2CppSystem.Object @object)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(vehicle);
				ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
				ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.VehicleEvent.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_LandVehicle_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.IAsyncResult>(intPtr2) : null;
			}

			// Token: 0x0600CF8B RID: 53131 RVA: 0x00324E18 File Offset: 0x00323018
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void EndInvoke(Il2CppSystem.IAsyncResult result)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.VehicleEvent.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600CF8C RID: 53132 RVA: 0x00064942 File Offset: 0x00062B42
			public VehicleEvent(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x0600CF8D RID: 53133 RVA: 0x0006494B File Offset: 0x00062B4B
			public static implicit operator Player.VehicleEvent(System.Action<LandVehicle> A_0)
			{
				return DelegateSupport.ConvertDelegate<Player.VehicleEvent>(A_0);
			}

			// Token: 0x0600CF8E RID: 53134 RVA: 0x00064953 File Offset: 0x00062B53
			public static Player.VehicleEvent operator +(Player.VehicleEvent A_0, Player.VehicleEvent A_1)
			{
				return Il2CppSystem.Delegate.Combine(A_0, A_1).Cast<Player.VehicleEvent>();
			}

			// Token: 0x0600CF8F RID: 53135 RVA: 0x00064961 File Offset: 0x00062B61
			public static Player.VehicleEvent operator -(Player.VehicleEvent A_0, Player.VehicleEvent A_1)
			{
				Il2CppSystem.Delegate result;
				Il2CppSystem.Delegate @delegate = result = Il2CppSystem.Delegate.Remove(A_0, A_1);
				if (@delegate != null)
				{
					result = @delegate.Cast<Player.VehicleEvent>();
				}
				return result;
			}

			// Token: 0x04008C6E RID: 35950
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x04008C6F RID: 35951
			private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_LandVehicle_0;

			// Token: 0x04008C70 RID: 35952
			private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_LandVehicle_AsyncCallback_Object_0;

			// Token: 0x04008C71 RID: 35953
			private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
		}

		// Token: 0x020009DB RID: 2523
		public sealed class VehicleTransformEvent : Il2CppSystem.MulticastDelegate
		{
			// Token: 0x0600CF90 RID: 53136 RVA: 0x00324E5C File Offset: 0x0032305C
			// Note: this type is marked as 'beforefieldinit'.
			static VehicleTransformEvent()
			{
				Il2CppClassPointerStore<Player.VehicleTransformEvent>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Player>.NativeClassPtr, "VehicleTransformEvent");
				Player.VehicleTransformEvent.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player.VehicleTransformEvent>.NativeClassPtr, 100673435);
				Player.VehicleTransformEvent.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_LandVehicle_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player.VehicleTransformEvent>.NativeClassPtr, 100673436);
				Player.VehicleTransformEvent.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_LandVehicle_Transform_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player.VehicleTransformEvent>.NativeClassPtr, 100673437);
				Player.VehicleTransformEvent.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player.VehicleTransformEvent>.NativeClassPtr, 100673438);
			}

			// Token: 0x0600CF91 RID: 53137 RVA: 0x00324ED0 File Offset: 0x003230D0
			[CallerCount(466)]
			[CachedScanResults(RefRangeStart = 170529, RefRangeEnd = 170995, XrefRangeStart = 170519, XrefRangeEnd = 170529, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe VehicleTransformEvent(Il2CppSystem.Object @object, System.IntPtr method) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Player.VehicleTransformEvent>.NativeClassPtr))
			{
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref method;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.VehicleTransformEvent.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600CF92 RID: 53138 RVA: 0x00324F2C File Offset: 0x0032312C
			[CallerCount(0)]
			public unsafe void Invoke(LandVehicle vehicle, Transform exitPoint)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(vehicle);
				ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(exitPoint);
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.VehicleTransformEvent.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_LandVehicle_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600CF93 RID: 53139 RVA: 0x00324F80 File Offset: 0x00323180
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Il2CppSystem.IAsyncResult BeginInvoke(LandVehicle vehicle, Transform exitPoint, Il2CppSystem.AsyncCallback callback, Il2CppSystem.Object @object)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)4) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(vehicle);
				ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(exitPoint);
				ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
				ptr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.VehicleTransformEvent.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_LandVehicle_Transform_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.IAsyncResult>(intPtr2) : null;
			}

			// Token: 0x0600CF94 RID: 53140 RVA: 0x00325008 File Offset: 0x00323208
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void EndInvoke(Il2CppSystem.IAsyncResult result)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.VehicleTransformEvent.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600CF95 RID: 53141 RVA: 0x00064972 File Offset: 0x00062B72
			public VehicleTransformEvent(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x0600CF96 RID: 53142 RVA: 0x0006497B File Offset: 0x00062B7B
			public static implicit operator Player.VehicleTransformEvent(System.Action<LandVehicle, Transform> A_0)
			{
				return DelegateSupport.ConvertDelegate<Player.VehicleTransformEvent>(A_0);
			}

			// Token: 0x0600CF97 RID: 53143 RVA: 0x00064983 File Offset: 0x00062B83
			public static Player.VehicleTransformEvent operator +(Player.VehicleTransformEvent A_0, Player.VehicleTransformEvent A_1)
			{
				return Il2CppSystem.Delegate.Combine(A_0, A_1).Cast<Player.VehicleTransformEvent>();
			}

			// Token: 0x0600CF98 RID: 53144 RVA: 0x00064991 File Offset: 0x00062B91
			public static Player.VehicleTransformEvent operator -(Player.VehicleTransformEvent A_0, Player.VehicleTransformEvent A_1)
			{
				Il2CppSystem.Delegate result;
				Il2CppSystem.Delegate @delegate = result = Il2CppSystem.Delegate.Remove(A_0, A_1);
				if (@delegate != null)
				{
					result = @delegate.Cast<Player.VehicleTransformEvent>();
				}
				return result;
			}

			// Token: 0x04008C72 RID: 35954
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x04008C73 RID: 35955
			private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_LandVehicle_Transform_0;

			// Token: 0x04008C74 RID: 35956
			private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_LandVehicle_Transform_AsyncCallback_Object_0;

			// Token: 0x04008C75 RID: 35957
			private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
		}

		// Token: 0x020009DC RID: 2524
		[ObfuscatedName("ScheduleOne.PlayerScripts.Player+<<Taze>g__Tase|321_0>d")]
		public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPlObObUnique : Il2CppSystem.Object
		{
			// Token: 0x0600CF99 RID: 53145 RVA: 0x0032504C File Offset: 0x0032324C
			// Note: this type is marked as 'beforefieldinit'.
			static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPlObObUnique()
			{
				Il2CppClassPointerStore<Player.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPlObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Player>.NativeClassPtr, "<<Taze>g__Tase|321_0>d");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Player.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPlObObUnique>.NativeClassPtr);
				Player.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPlObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPlObObUnique>.NativeClassPtr, "<>1__state");
				Player.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPlObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPlObObUnique>.NativeClassPtr, "<>2__current");
				Player.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPlObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPlObObUnique>.NativeClassPtr, "<>4__this");
				Player.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPlObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPlObObUnique>.NativeClassPtr, 100673439);
				Player.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPlObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPlObObUnique>.NativeClassPtr, 100673440);
				Player.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPlObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPlObObUnique>.NativeClassPtr, 100673441);
				Player.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPlObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPlObObUnique>.NativeClassPtr, 100673442);
				Player.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPlObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPlObObUnique>.NativeClassPtr, 100673443);
				Player.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPlObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPlObObUnique>.NativeClassPtr, 100673444);
			}

			// Token: 0x0600CF9A RID: 53146 RVA: 0x0032512C File Offset: 0x0032332C
			[CallerCount(54)]
			[CachedScanResults(RefRangeStart = 2646, RefRangeEnd = 2700, XrefRangeStart = 2646, XrefRangeEnd = 2700, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPlObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Player.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPlObObUnique>.NativeClassPtr))
			{
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = ref <>1__state;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPlObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600CF9B RID: 53147 RVA: 0x00325174 File Offset: 0x00323374
			[CallerCount(14558)]
			[CachedScanResults(RefRangeStart = 2769, RefRangeEnd = 17327, XrefRangeStart = 2769, XrefRangeEnd = 17327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPlObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600CF9C RID: 53148 RVA: 0x003251A8 File Offset: 0x003233A8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 170995, XrefRangeEnd = 171001, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Player.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPlObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x17004059 RID: 16473
			// (get) Token: 0x0600CF9D RID: 53149 RVA: 0x003251E4 File Offset: 0x003233E4
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 2740, RefRangeEnd = 2764, XrefRangeStart = 2740, XrefRangeEnd = 2764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPlObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
			}

			// Token: 0x0600CF9E RID: 53150 RVA: 0x00325224 File Offset: 0x00323424
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 171001, XrefRangeEnd = 171006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPlObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x1700405A RID: 16474
			// (get) Token: 0x0600CF9F RID: 53151 RVA: 0x00325258 File Offset: 0x00323458
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 2740, RefRangeEnd = 2764, XrefRangeStart = 2740, XrefRangeEnd = 2764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPlObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
			}

			// Token: 0x0600CFA0 RID: 53152 RVA: 0x000649A2 File Offset: 0x00062BA2
			public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPlObObUnique(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004056 RID: 16470
			// (get) Token: 0x0600CFA1 RID: 53153 RVA: 0x00325298 File Offset: 0x00323498
			// (set) Token: 0x0600CFA2 RID: 53154 RVA: 0x000649AB File Offset: 0x00062BAB
			public unsafe int __1__state
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Player.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPlObObUnique.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Player.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPlObObUnique.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17004057 RID: 16471
			// (get) Token: 0x0600CFA3 RID: 53155 RVA: 0x003252C0 File Offset: 0x003234C0
			// (set) Token: 0x0600CFA4 RID: 53156 RVA: 0x000649C6 File Offset: 0x00062BC6
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Player.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPlObObUnique.NativeFieldInfoPtr___2__current);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Player.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPlObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004058 RID: 16472
			// (get) Token: 0x0600CFA5 RID: 53157 RVA: 0x003252F0 File Offset: 0x003234F0
			// (set) Token: 0x0600CFA6 RID: 53158 RVA: 0x000649E5 File Offset: 0x00062BE5
			public unsafe Player __4__this
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Player.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPlObObUnique.NativeFieldInfoPtr___4__this);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Player>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Player.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPlObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008C76 RID: 35958
			private static readonly System.IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04008C77 RID: 35959
			private static readonly System.IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04008C78 RID: 35960
			private static readonly System.IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04008C79 RID: 35961
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04008C7A RID: 35962
			private static readonly System.IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008C7B RID: 35963
			private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04008C7C RID: 35964
			private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04008C7D RID: 35965
			private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008C7E RID: 35966
			private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x020009DD RID: 2525
		[ObfuscatedName("ScheduleOne.PlayerScripts.Player+<>c__DisplayClass222_0")]
		public sealed class __c__DisplayClass222_0 : Il2CppSystem.Object
		{
			// Token: 0x0600CFA7 RID: 53159 RVA: 0x00325320 File Offset: 0x00323520
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass222_0()
			{
				Il2CppClassPointerStore<Player.__c__DisplayClass222_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Player>.NativeClassPtr, "<>c__DisplayClass222_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Player.__c__DisplayClass222_0>.NativeClassPtr);
				Player.__c__DisplayClass222_0.NativeFieldInfoPtr_playerCode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player.__c__DisplayClass222_0>.NativeClassPtr, "playerCode");
				Player.__c__DisplayClass222_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player.__c__DisplayClass222_0>.NativeClassPtr, 100673445);
				Player.__c__DisplayClass222_0.NativeMethodInfoPtr__GetPlayer_b__0_Internal_Boolean_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player.__c__DisplayClass222_0>.NativeClassPtr, 100673446);
			}

			// Token: 0x0600CFA8 RID: 53160 RVA: 0x00325388 File Offset: 0x00323588
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass222_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Player.__c__DisplayClass222_0>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.__c__DisplayClass222_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600CFA9 RID: 53161 RVA: 0x003253C4 File Offset: 0x003235C4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 171006, XrefRangeEnd = 171009, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GetPlayer_b__0(Player x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Player.__c__DisplayClass222_0.NativeMethodInfoPtr__GetPlayer_b__0_Internal_Boolean_Player_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x0600CFAA RID: 53162 RVA: 0x00064A04 File Offset: 0x00062C04
			public __c__DisplayClass222_0(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700405B RID: 16475
			// (get) Token: 0x0600CFAB RID: 53163 RVA: 0x00325414 File Offset: 0x00323614
			// (set) Token: 0x0600CFAC RID: 53164 RVA: 0x00064A0D File Offset: 0x00062C0D
			public unsafe string playerCode
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Player.__c__DisplayClass222_0.NativeFieldInfoPtr_playerCode);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Player.__c__DisplayClass222_0.NativeFieldInfoPtr_playerCode), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x04008C7F RID: 35967
			private static readonly System.IntPtr NativeFieldInfoPtr_playerCode;

			// Token: 0x04008C80 RID: 35968
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008C81 RID: 35969
			private static readonly System.IntPtr NativeMethodInfoPtr__GetPlayer_b__0_Internal_Boolean_Player_0;
		}

		// Token: 0x020009DE RID: 2526
		[ObfuscatedName("ScheduleOne.PlayerScripts.Player+<>c__DisplayClass278_0")]
		public sealed class __c__DisplayClass278_0 : Il2CppSystem.Object
		{
			// Token: 0x0600CFAD RID: 53165 RVA: 0x0032543C File Offset: 0x0032363C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass278_0()
			{
				Il2CppClassPointerStore<Player.__c__DisplayClass278_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Player>.NativeClassPtr, "<>c__DisplayClass278_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Player.__c__DisplayClass278_0>.NativeClassPtr);
				Player.__c__DisplayClass278_0.NativeFieldInfoPtr_point = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player.__c__DisplayClass278_0>.NativeClassPtr, "point");
				Player.__c__DisplayClass278_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player.__c__DisplayClass278_0>.NativeClassPtr, 100673447);
				Player.__c__DisplayClass278_0.NativeMethodInfoPtr__GetClosestPlayer_b__0_Internal_Single_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player.__c__DisplayClass278_0>.NativeClassPtr, 100673448);
			}

			// Token: 0x0600CFAE RID: 53166 RVA: 0x003254A4 File Offset: 0x003236A4
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass278_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Player.__c__DisplayClass278_0>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.__c__DisplayClass278_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600CFAF RID: 53167 RVA: 0x003254E0 File Offset: 0x003236E0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 171009, XrefRangeEnd = 171010, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe float _GetClosestPlayer_b__0(Player x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Player.__c__DisplayClass278_0.NativeMethodInfoPtr__GetClosestPlayer_b__0_Internal_Single_Player_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x0600CFB0 RID: 53168 RVA: 0x00064A2C File Offset: 0x00062C2C
			public __c__DisplayClass278_0(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700405C RID: 16476
			// (get) Token: 0x0600CFB1 RID: 53169 RVA: 0x00325530 File Offset: 0x00323730
			// (set) Token: 0x0600CFB2 RID: 53170 RVA: 0x00064A35 File Offset: 0x00062C35
			public unsafe Vector3 point
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Player.__c__DisplayClass278_0.NativeFieldInfoPtr_point);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Player.__c__DisplayClass278_0.NativeFieldInfoPtr_point)) = value;
				}
			}

			// Token: 0x04008C82 RID: 35970
			private static readonly System.IntPtr NativeFieldInfoPtr_point;

			// Token: 0x04008C83 RID: 35971
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008C84 RID: 35972
			private static readonly System.IntPtr NativeMethodInfoPtr__GetClosestPlayer_b__0_Internal_Single_Player_0;
		}

		// Token: 0x020009DF RID: 2527
		[ObfuscatedName("ScheduleOne.PlayerScripts.Player+<>c__DisplayClass282_0")]
		public sealed class __c__DisplayClass282_0 : Il2CppSystem.Object
		{
			// Token: 0x0600CFB3 RID: 53171 RVA: 0x00325558 File Offset: 0x00323758
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass282_0()
			{
				Il2CppClassPointerStore<Player.__c__DisplayClass282_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Player>.NativeClassPtr, "<>c__DisplayClass282_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Player.__c__DisplayClass282_0>.NativeClassPtr);
				Player.__c__DisplayClass282_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player.__c__DisplayClass282_0>.NativeClassPtr, "<>4__this");
				Player.__c__DisplayClass282_0.NativeFieldInfoPtr_startScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player.__c__DisplayClass282_0>.NativeClassPtr, "startScale");
				Player.__c__DisplayClass282_0.NativeFieldInfoPtr_scale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player.__c__DisplayClass282_0>.NativeClassPtr, "scale");
				Player.__c__DisplayClass282_0.NativeFieldInfoPtr_lerpTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player.__c__DisplayClass282_0>.NativeClassPtr, "lerpTime");
				Player.__c__DisplayClass282_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player.__c__DisplayClass282_0>.NativeClassPtr, 100673449);
				Player.__c__DisplayClass282_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player.__c__DisplayClass282_0>.NativeClassPtr, 100673450);
			}

			// Token: 0x0600CFB4 RID: 53172 RVA: 0x003255FC File Offset: 0x003237FC
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass282_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Player.__c__DisplayClass282_0>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.__c__DisplayClass282_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600CFB5 RID: 53173 RVA: 0x00325638 File Offset: 0x00323838
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 171029, RefRangeEnd = 171030, XrefRangeStart = 171024, XrefRangeEnd = 171029, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator Method_Internal_IEnumerator_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.__c__DisplayClass282_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr2) : null;
			}

			// Token: 0x0600CFB6 RID: 53174 RVA: 0x00064A50 File Offset: 0x00062C50
			public __c__DisplayClass282_0(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700405D RID: 16477
			// (get) Token: 0x0600CFB7 RID: 53175 RVA: 0x00325678 File Offset: 0x00323878
			// (set) Token: 0x0600CFB8 RID: 53176 RVA: 0x00064A59 File Offset: 0x00062C59
			public unsafe Player __4__this
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Player.__c__DisplayClass282_0.NativeFieldInfoPtr___4__this);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Player>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Player.__c__DisplayClass282_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700405E RID: 16478
			// (get) Token: 0x0600CFB9 RID: 53177 RVA: 0x003256A8 File Offset: 0x003238A8
			// (set) Token: 0x0600CFBA RID: 53178 RVA: 0x00064A78 File Offset: 0x00062C78
			public unsafe float startScale
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Player.__c__DisplayClass282_0.NativeFieldInfoPtr_startScale);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Player.__c__DisplayClass282_0.NativeFieldInfoPtr_startScale)) = value;
				}
			}

			// Token: 0x1700405F RID: 16479
			// (get) Token: 0x0600CFBB RID: 53179 RVA: 0x003256D0 File Offset: 0x003238D0
			// (set) Token: 0x0600CFBC RID: 53180 RVA: 0x00064A93 File Offset: 0x00062C93
			public unsafe float scale
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Player.__c__DisplayClass282_0.NativeFieldInfoPtr_scale);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Player.__c__DisplayClass282_0.NativeFieldInfoPtr_scale)) = value;
				}
			}

			// Token: 0x17004060 RID: 16480
			// (get) Token: 0x0600CFBD RID: 53181 RVA: 0x003256F8 File Offset: 0x003238F8
			// (set) Token: 0x0600CFBE RID: 53182 RVA: 0x00064AAE File Offset: 0x00062CAE
			public unsafe float lerpTime
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Player.__c__DisplayClass282_0.NativeFieldInfoPtr_lerpTime);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Player.__c__DisplayClass282_0.NativeFieldInfoPtr_lerpTime)) = value;
				}
			}

			// Token: 0x04008C85 RID: 35973
			private static readonly System.IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04008C86 RID: 35974
			private static readonly System.IntPtr NativeFieldInfoPtr_startScale;

			// Token: 0x04008C87 RID: 35975
			private static readonly System.IntPtr NativeFieldInfoPtr_scale;

			// Token: 0x04008C88 RID: 35976
			private static readonly System.IntPtr NativeFieldInfoPtr_lerpTime;

			// Token: 0x04008C89 RID: 35977
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008C8A RID: 35978
			private static readonly System.IntPtr NativeMethodInfoPtr_Method_Internal_IEnumerator_0;

			// Token: 0x02000C9F RID: 3231
			[ObfuscatedName("ScheduleOne.PlayerScripts.Player+<>c__DisplayClass282_0+<<SetScale>g__LerpScale|0>d")]
			public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique : Il2CppSystem.Object
			{
				// Token: 0x0600E7FD RID: 59389 RVA: 0x00369C40 File Offset: 0x00367E40
				// Note: this type is marked as 'beforefieldinit'.
				static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique()
				{
					Il2CppClassPointerStore<Player.__c__DisplayClass282_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Player.__c__DisplayClass282_0>.NativeClassPtr, "<<SetScale>g__LerpScale|0>d");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Player.__c__DisplayClass282_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr);
					Player.__c__DisplayClass282_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player.__c__DisplayClass282_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr, "<>1__state");
					Player.__c__DisplayClass282_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player.__c__DisplayClass282_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr, "<>2__current");
					Player.__c__DisplayClass282_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player.__c__DisplayClass282_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr, "<>4__this");
					Player.__c__DisplayClass282_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeFieldInfoPtr__i_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player.__c__DisplayClass282_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr, "<i>5__2");
					Player.__c__DisplayClass282_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player.__c__DisplayClass282_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr, 100673451);
					Player.__c__DisplayClass282_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player.__c__DisplayClass282_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr, 100673452);
					Player.__c__DisplayClass282_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player.__c__DisplayClass282_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr, 100673453);
					Player.__c__DisplayClass282_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player.__c__DisplayClass282_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr, 100673454);
					Player.__c__DisplayClass282_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player.__c__DisplayClass282_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr, 100673455);
					Player.__c__DisplayClass282_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player.__c__DisplayClass282_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr, 100673456);
				}

				// Token: 0x0600E7FE RID: 59390 RVA: 0x00369D34 File Offset: 0x00367F34
				[CallerCount(54)]
				[CachedScanResults(RefRangeStart = 2646, RefRangeEnd = 2700, XrefRangeStart = 2646, XrefRangeEnd = 2700, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Player.__c__DisplayClass282_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr))
				{
					System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
					*ptr = ref <>1__state;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.__c__DisplayClass282_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				}

				// Token: 0x0600E7FF RID: 59391 RVA: 0x00369D7C File Offset: 0x00367F7C
				[CallerCount(14558)]
				[CachedScanResults(RefRangeStart = 2769, RefRangeEnd = 17327, XrefRangeStart = 2769, XrefRangeEnd = 17327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.__c__DisplayClass282_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				}

				// Token: 0x0600E800 RID: 59392 RVA: 0x00369DB0 File Offset: 0x00367FB0
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 171010, XrefRangeEnd = 171019, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Player.__c__DisplayClass282_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
					return *IL2CPP.il2cpp_object_unbox(obj);
				}

				// Token: 0x170047A2 RID: 18338
				// (get) Token: 0x0600E801 RID: 59393 RVA: 0x00369DEC File Offset: 0x00367FEC
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(24)]
					[CachedScanResults(RefRangeStart = 2740, RefRangeEnd = 2764, XrefRangeStart = 2740, XrefRangeEnd = 2764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						System.IntPtr* param = null;
						System.IntPtr returnedException;
						System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.__c__DisplayClass282_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
						Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
						System.IntPtr intPtr2 = intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
				}

				// Token: 0x0600E802 RID: 59394 RVA: 0x00369E2C File Offset: 0x0036802C
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 171019, XrefRangeEnd = 171024, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.__c__DisplayClass282_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				}

				// Token: 0x170047A3 RID: 18339
				// (get) Token: 0x0600E803 RID: 59395 RVA: 0x00369E60 File Offset: 0x00368060
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(24)]
					[CachedScanResults(RefRangeStart = 2740, RefRangeEnd = 2764, XrefRangeStart = 2740, XrefRangeEnd = 2764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						System.IntPtr* param = null;
						System.IntPtr returnedException;
						System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.__c__DisplayClass282_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
						Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
						System.IntPtr intPtr2 = intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
				}

				// Token: 0x0600E804 RID: 59396 RVA: 0x00070CB1 File Offset: 0x0006EEB1
				public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique(System.IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x1700479E RID: 18334
				// (get) Token: 0x0600E805 RID: 59397 RVA: 0x00369EA0 File Offset: 0x003680A0
				// (set) Token: 0x0600E806 RID: 59398 RVA: 0x00070CBA File Offset: 0x0006EEBA
				public unsafe int __1__state
				{
					get
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Player.__c__DisplayClass282_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Player.__c__DisplayClass282_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x1700479F RID: 18335
				// (get) Token: 0x0600E807 RID: 59399 RVA: 0x00369EC8 File Offset: 0x003680C8
				// (set) Token: 0x0600E808 RID: 59400 RVA: 0x00070CD5 File Offset: 0x0006EED5
				public unsafe Il2CppSystem.Object __2__current
				{
					get
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Player.__c__DisplayClass282_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeFieldInfoPtr___2__current);
						System.IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
					set
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Player.__c__DisplayClass282_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x170047A0 RID: 18336
				// (get) Token: 0x0600E809 RID: 59401 RVA: 0x00369EF8 File Offset: 0x003680F8
				// (set) Token: 0x0600E80A RID: 59402 RVA: 0x00070CF4 File Offset: 0x0006EEF4
				public unsafe Player.__c__DisplayClass282_0 __4__this
				{
					get
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Player.__c__DisplayClass282_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeFieldInfoPtr___4__this);
						System.IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Player.__c__DisplayClass282_0>(intPtr2) : null;
					}
					set
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Player.__c__DisplayClass282_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x170047A1 RID: 18337
				// (get) Token: 0x0600E80B RID: 59403 RVA: 0x00369F28 File Offset: 0x00368128
				// (set) Token: 0x0600E80C RID: 59404 RVA: 0x00070D13 File Offset: 0x0006EF13
				public unsafe float _i_5__2
				{
					get
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Player.__c__DisplayClass282_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeFieldInfoPtr__i_5__2);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Player.__c__DisplayClass282_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeFieldInfoPtr__i_5__2)) = value;
					}
				}

				// Token: 0x04009B54 RID: 39764
				private static readonly System.IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x04009B55 RID: 39765
				private static readonly System.IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x04009B56 RID: 39766
				private static readonly System.IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x04009B57 RID: 39767
				private static readonly System.IntPtr NativeFieldInfoPtr__i_5__2;

				// Token: 0x04009B58 RID: 39768
				private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x04009B59 RID: 39769
				private static readonly System.IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x04009B5A RID: 39770
				private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x04009B5B RID: 39771
				private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x04009B5C RID: 39772
				private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x04009B5D RID: 39773
				private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
			}
		}

		// Token: 0x020009E0 RID: 2528
		private sealed class MethodInfoStoreGeneric_GetValue_Public_T_String_0<T>
		{
			// Token: 0x04008C8B RID: 35979
			internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Player.NativeMethodInfoPtr_GetValue_Public_T_String_0, Il2CppClassPointerStore<Player>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[]
			{
				Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
			}))));
		}
	}
}
