using System;
using Il2CppEPOOutline;
using Il2CppFishNet.Connection;
using Il2CppFishNet.Object;
using Il2CppFishNet.Object.Synchronizing;
using Il2CppFishNet.Serializing;
using Il2CppFishNet.Transporting;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppPathfinding;
using Il2CppScheduleOne.DevUtilities;
using Il2CppScheduleOne.EntityFramework;
using Il2CppScheduleOne.Interaction;
using Il2CppScheduleOne.ItemFramework;
using Il2CppScheduleOne.Map;
using Il2CppScheduleOne.Money;
using Il2CppScheduleOne.NPCs;
using Il2CppScheduleOne.Persistence.Datas;
using Il2CppScheduleOne.Persistence.Loaders;
using Il2CppScheduleOne.PlayerScripts;
using Il2CppScheduleOne.Storage;
using Il2CppScheduleOne.Tools;
using Il2CppScheduleOne.Vehicles.AI;
using Il2CppScheduleOne.Vehicles.Modification;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.Events;

namespace Il2CppScheduleOne.Vehicles
{
	// Token: 0x02000503 RID: 1283
	public class LandVehicle : NetworkBehaviour
	{
		// Token: 0x06006F11 RID: 28433 RVA: 0x001EE294 File Offset: 0x001EC494
		// Note: this type is marked as 'beforefieldinit'.
		static LandVehicle()
		{
			Il2CppClassPointerStore<LandVehicle>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Vehicles", "LandVehicle");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr);
			LandVehicle.NativeFieldInfoPtr_KINEMATIC_THRESHOLD_DISTANCE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, "KINEMATIC_THRESHOLD_DISTANCE");
			LandVehicle.NativeFieldInfoPtr_MAX_TURNOVER_SPEED = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, "MAX_TURNOVER_SPEED");
			LandVehicle.NativeFieldInfoPtr_TURNOVER_FORCE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, "TURNOVER_FORCE");
			LandVehicle.NativeFieldInfoPtr_USE_WHEEL = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, "USE_WHEEL");
			LandVehicle.NativeFieldInfoPtr_SPEED_DISPLAY_MULTIPLIER = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, "SPEED_DISPLAY_MULTIPLIER");
			LandVehicle.NativeFieldInfoPtr_DEBUG = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, "DEBUG");
			LandVehicle.NativeFieldInfoPtr_vehicleName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, "vehicleName");
			LandVehicle.NativeFieldInfoPtr_vehicleCode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, "vehicleCode");
			LandVehicle.NativeFieldInfoPtr_vehiclePrice = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, "vehiclePrice");
			LandVehicle.NativeFieldInfoPtr__IsPlayerOwned_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, "<IsPlayerOwned>k__BackingField");
			LandVehicle.NativeFieldInfoPtr__IsVisible_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, "<IsVisible>k__BackingField");
			LandVehicle.NativeFieldInfoPtr_UseHumanoidCollider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, "UseHumanoidCollider");
			LandVehicle.NativeFieldInfoPtr__GUID_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, "<GUID>k__BackingField");
			LandVehicle.NativeFieldInfoPtr_SpawnAsPlayerOwned = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, "SpawnAsPlayerOwned");
			LandVehicle.NativeFieldInfoPtr__DistanceToLocalCamera_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, "<DistanceToLocalCamera>k__BackingField");
			LandVehicle.NativeFieldInfoPtr_vehicleModel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, "vehicleModel");
			LandVehicle.NativeFieldInfoPtr_driveWheels = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, "driveWheels");
			LandVehicle.NativeFieldInfoPtr_steerWheels = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, "steerWheels");
			LandVehicle.NativeFieldInfoPtr_handbrakeWheels = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, "handbrakeWheels");
			LandVehicle.NativeFieldInfoPtr_wheels = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, "wheels");
			LandVehicle.NativeFieldInfoPtr_intObj = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, "intObj");
			LandVehicle.NativeFieldInfoPtr_exitPoints = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, "exitPoints");
			LandVehicle.NativeFieldInfoPtr_rb = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, "rb");
			LandVehicle.NativeFieldInfoPtr_Seats = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, "Seats");
			LandVehicle.NativeFieldInfoPtr_boundingBox = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, "boundingBox");
			LandVehicle.NativeFieldInfoPtr_Agent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, "Agent");
			LandVehicle.NativeFieldInfoPtr_VelocityCalculator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, "VelocityCalculator");
			LandVehicle.NativeFieldInfoPtr_Trunk = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, "Trunk");
			LandVehicle.NativeFieldInfoPtr_NavMeshObstacle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, "NavMeshObstacle");
			LandVehicle.NativeFieldInfoPtr_NavmeshCut = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, "NavmeshCut");
			LandVehicle.NativeFieldInfoPtr_HumanoidColliderContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, "HumanoidColliderContainer");
			LandVehicle.NativeFieldInfoPtr_POI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, "POI");
			LandVehicle.NativeFieldInfoPtr_centerOfMass = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, "centerOfMass");
			LandVehicle.NativeFieldInfoPtr_cameraOrigin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, "cameraOrigin");
			LandVehicle.NativeFieldInfoPtr_lights = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, "lights");
			LandVehicle.NativeFieldInfoPtr_maxSteeringAngle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, "maxSteeringAngle");
			LandVehicle.NativeFieldInfoPtr_steerRate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, "steerRate");
			LandVehicle.NativeFieldInfoPtr_flipSteer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, "flipSteer");
			LandVehicle.NativeFieldInfoPtr__MaxSteerAngleOverridden_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, "<MaxSteerAngleOverridden>k__BackingField");
			LandVehicle.NativeFieldInfoPtr__OverriddenMaxSteerAngle_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, "<OverriddenMaxSteerAngle>k__BackingField");
			LandVehicle.NativeFieldInfoPtr_motorTorque = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, "motorTorque");
			LandVehicle.NativeFieldInfoPtr_TopSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, "TopSpeed");
			LandVehicle.NativeFieldInfoPtr_diffGearing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, "diffGearing");
			LandVehicle.NativeFieldInfoPtr_handBrakeForce = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, "handBrakeForce");
			LandVehicle.NativeFieldInfoPtr_brakeForce = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, "brakeForce");
			LandVehicle.NativeFieldInfoPtr_downforce = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, "downforce");
			LandVehicle.NativeFieldInfoPtr_reverseMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, "reverseMultiplier");
			LandVehicle.NativeFieldInfoPtr_BodyMeshes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, "BodyMeshes");
			LandVehicle.NativeFieldInfoPtr_DefaultColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, "DefaultColor");
			LandVehicle.NativeFieldInfoPtr__OwnedColor_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, "<OwnedColor>k__BackingField");
			LandVehicle.NativeFieldInfoPtr_DisplayedColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, "DisplayedColor");
			LandVehicle.NativeFieldInfoPtr_outlineRenderers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, "outlineRenderers");
			LandVehicle.NativeFieldInfoPtr_outlineEffect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, "outlineEffect");
			LandVehicle.NativeFieldInfoPtr_overrideControls = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, "overrideControls");
			LandVehicle.NativeFieldInfoPtr_throttleOverride = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, "throttleOverride");
			LandVehicle.NativeFieldInfoPtr_steerOverride = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, "steerOverride");
			LandVehicle.NativeFieldInfoPtr_Storage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, "Storage");
			LandVehicle.NativeFieldInfoPtr_localPlayerSeat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, "localPlayerSeat");
			LandVehicle.NativeFieldInfoPtr__localPlayerIsDriver_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, "<localPlayerIsDriver>k__BackingField");
			LandVehicle.NativeFieldInfoPtr__localPlayerIsInVehicle_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, "<localPlayerIsInVehicle>k__BackingField");
			LandVehicle.NativeFieldInfoPtr__isOccupied_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, "<isOccupied>k__BackingField");
			LandVehicle.NativeFieldInfoPtr__OccupantNPCs_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, "<OccupantNPCs>k__BackingField");
			LandVehicle.NativeFieldInfoPtr__speed_Kmh_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, "<speed_Kmh>k__BackingField");
			LandVehicle.NativeFieldInfoPtr_previousSpeeds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, "previousSpeeds");
			LandVehicle.NativeFieldInfoPtr_previousSpeedsSampleSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, "previousSpeedsSampleSize");
			LandVehicle.NativeFieldInfoPtr__currentThrottle_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, "<currentThrottle>k__BackingField");
			LandVehicle.NativeFieldInfoPtr_currentSteerAngle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, "currentSteerAngle");
			LandVehicle.NativeFieldInfoPtr_lastFrameSteerAngle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, "lastFrameSteerAngle");
			LandVehicle.NativeFieldInfoPtr_lastReplicatedSteerAngle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, "lastReplicatedSteerAngle");
			LandVehicle.NativeFieldInfoPtr_justExitedVehicle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, "justExitedVehicle");
			LandVehicle.NativeFieldInfoPtr__brakesApplied_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, "<brakesApplied>k__BackingField");
			LandVehicle.NativeFieldInfoPtr__isReversing_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, "<isReversing>k__BackingField");
			LandVehicle.NativeFieldInfoPtr__isStatic_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, "<isStatic>k__BackingField");
			LandVehicle.NativeFieldInfoPtr__handbrakeApplied_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, "<handbrakeApplied>k__BackingField");
			LandVehicle.NativeFieldInfoPtr_lastFramePosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, "lastFramePosition");
			LandVehicle.NativeFieldInfoPtr_closestExitPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, "closestExitPoint");
			LandVehicle.NativeFieldInfoPtr_CurrentParkData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, "CurrentParkData");
			LandVehicle.NativeFieldInfoPtr__CurrentParkingLot_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, "<CurrentParkingLot>k__BackingField");
			LandVehicle.NativeFieldInfoPtr__CurrentParkingSpot_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, "<CurrentParkingSpot>k__BackingField");
			LandVehicle.NativeFieldInfoPtr_loader = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, "loader");
			LandVehicle.NativeFieldInfoPtr__LocalExtraFiles_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, "<LocalExtraFiles>k__BackingField");
			LandVehicle.NativeFieldInfoPtr__LocalExtraFolders_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, "<LocalExtraFolders>k__BackingField");
			LandVehicle.NativeFieldInfoPtr__HasChanged_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, "<HasChanged>k__BackingField");
			LandVehicle.NativeFieldInfoPtr_onPlayerEnterVehicle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, "onPlayerEnterVehicle");
			LandVehicle.NativeFieldInfoPtr_onPlayerExitVehicle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, "onPlayerExitVehicle");
			LandVehicle.NativeFieldInfoPtr_onVehicleStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, "onVehicleStart");
			LandVehicle.NativeFieldInfoPtr_onVehicleStop = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, "onVehicleStop");
			LandVehicle.NativeFieldInfoPtr_onHandbrakeApplied = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, "onHandbrakeApplied");
			LandVehicle.NativeFieldInfoPtr_onCollision = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, "onCollision");
			LandVehicle.NativeFieldInfoPtr_syncVar___currentSteerAngle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, "syncVar___currentSteerAngle");
			LandVehicle.NativeFieldInfoPtr_syncVar____brakesApplied_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, "syncVar___<brakesApplied>k__BackingField");
			LandVehicle.NativeFieldInfoPtr_syncVar____isReversing_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, "syncVar___<isReversing>k__BackingField");
			LandVehicle.NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, "NetworkInitialize___EarlyScheduleOne.Vehicles.LandVehicleAssembly-CSharp.dll_Excuted");
			LandVehicle.NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, "NetworkInitialize__LateScheduleOne.Vehicles.LandVehicleAssembly-CSharp.dll_Excuted");
			LandVehicle.NativeMethodInfoPtr_get_VehicleName_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677423);
			LandVehicle.NativeMethodInfoPtr_get_VehicleCode_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677424);
			LandVehicle.NativeMethodInfoPtr_get_VehiclePrice_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677425);
			LandVehicle.NativeMethodInfoPtr_get_IsPlayerOwned_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677426);
			LandVehicle.NativeMethodInfoPtr_set_IsPlayerOwned_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677427);
			LandVehicle.NativeMethodInfoPtr_get_IsVisible_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677428);
			LandVehicle.NativeMethodInfoPtr_set_IsVisible_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677429);
			LandVehicle.NativeMethodInfoPtr_get_GUID_Public_Virtual_Final_New_get_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677430);
			LandVehicle.NativeMethodInfoPtr_set_GUID_Protected_set_Void_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677431);
			LandVehicle.NativeMethodInfoPtr_get_DistanceToLocalCamera_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677432);
			LandVehicle.NativeMethodInfoPtr_set_DistanceToLocalCamera_Private_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677433);
			LandVehicle.NativeMethodInfoPtr_get_boundingBoxDimensions_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677434);
			LandVehicle.NativeMethodInfoPtr_get_driverEntryPoint_Public_get_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677435);
			LandVehicle.NativeMethodInfoPtr_get_Rb_Public_get_Rigidbody_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677436);
			LandVehicle.NativeMethodInfoPtr_get_ActualMaxSteeringAngle_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677437);
			LandVehicle.NativeMethodInfoPtr_get_MaxSteerAngleOverridden_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677438);
			LandVehicle.NativeMethodInfoPtr_set_MaxSteerAngleOverridden_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677439);
			LandVehicle.NativeMethodInfoPtr_get_OverriddenMaxSteerAngle_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677440);
			LandVehicle.NativeMethodInfoPtr_set_OverriddenMaxSteerAngle_Private_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677441);
			LandVehicle.NativeMethodInfoPtr_get_OwnedColor_Public_get_EVehicleColor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677442);
			LandVehicle.NativeMethodInfoPtr_set_OwnedColor_Private_set_Void_EVehicleColor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677443);
			LandVehicle.NativeMethodInfoPtr_get_Capacity_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677444);
			LandVehicle.NativeMethodInfoPtr_get_CurrentPlayerOccupancy_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677445);
			LandVehicle.NativeMethodInfoPtr_get_localPlayerIsDriver_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677446);
			LandVehicle.NativeMethodInfoPtr_set_localPlayerIsDriver_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677447);
			LandVehicle.NativeMethodInfoPtr_get_localPlayerIsInVehicle_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677448);
			LandVehicle.NativeMethodInfoPtr_set_localPlayerIsInVehicle_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677449);
			LandVehicle.NativeMethodInfoPtr_get_isOccupied_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677450);
			LandVehicle.NativeMethodInfoPtr_set_isOccupied_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677451);
			LandVehicle.NativeMethodInfoPtr_get_DriverPlayer_Public_get_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677452);
			LandVehicle.NativeMethodInfoPtr_get_OccupantPlayers_Public_get_List_1_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677453);
			LandVehicle.NativeMethodInfoPtr_get_OccupantNPCs_Public_get_Il2CppReferenceArray_1_NPC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677454);
			LandVehicle.NativeMethodInfoPtr_set_OccupantNPCs_Protected_set_Void_Il2CppReferenceArray_1_NPC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677455);
			LandVehicle.NativeMethodInfoPtr_get_speed_Kmh_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677456);
			LandVehicle.NativeMethodInfoPtr_set_speed_Kmh_Protected_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677457);
			LandVehicle.NativeMethodInfoPtr_get_speed_Ms_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677458);
			LandVehicle.NativeMethodInfoPtr_get_speed_Mph_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677459);
			LandVehicle.NativeMethodInfoPtr_get_currentThrottle_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677460);
			LandVehicle.NativeMethodInfoPtr_set_currentThrottle_Protected_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677461);
			LandVehicle.NativeMethodInfoPtr_get_brakesApplied_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677462);
			LandVehicle.NativeMethodInfoPtr_set_brakesApplied_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677463);
			LandVehicle.NativeMethodInfoPtr_get_isReversing_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677464);
			LandVehicle.NativeMethodInfoPtr_set_isReversing_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677465);
			LandVehicle.NativeMethodInfoPtr_get_isStatic_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677466);
			LandVehicle.NativeMethodInfoPtr_set_isStatic_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677467);
			LandVehicle.NativeMethodInfoPtr_get_handbrakeApplied_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677468);
			LandVehicle.NativeMethodInfoPtr_set_handbrakeApplied_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677469);
			LandVehicle.NativeMethodInfoPtr_get_boundingBaseOffset_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677470);
			LandVehicle.NativeMethodInfoPtr_get_isParked_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677471);
			LandVehicle.NativeMethodInfoPtr_get_CurrentParkingLot_Public_get_ParkingLot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677472);
			LandVehicle.NativeMethodInfoPtr_set_CurrentParkingLot_Protected_set_Void_ParkingLot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677473);
			LandVehicle.NativeMethodInfoPtr_get_CurrentParkingSpot_Public_get_ParkingSpot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677474);
			LandVehicle.NativeMethodInfoPtr_set_CurrentParkingSpot_Protected_set_Void_ParkingSpot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677475);
			LandVehicle.NativeMethodInfoPtr_get_SaveFolderName_Public_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677476);
			LandVehicle.NativeMethodInfoPtr_get_SaveFileName_Public_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677477);
			LandVehicle.NativeMethodInfoPtr_get_Loader_Public_Virtual_Final_New_get_Loader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677478);
			LandVehicle.NativeMethodInfoPtr_get_ShouldSaveUnderFolder_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677479);
			LandVehicle.NativeMethodInfoPtr_get_LocalExtraFiles_Public_Virtual_Final_New_get_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677480);
			LandVehicle.NativeMethodInfoPtr_set_LocalExtraFiles_Public_Virtual_Final_New_set_Void_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677481);
			LandVehicle.NativeMethodInfoPtr_get_LocalExtraFolders_Public_Virtual_Final_New_get_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677482);
			LandVehicle.NativeMethodInfoPtr_set_LocalExtraFolders_Public_Virtual_Final_New_set_Void_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677483);
			LandVehicle.NativeMethodInfoPtr_get_HasChanged_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677484);
			LandVehicle.NativeMethodInfoPtr_set_HasChanged_Public_Virtual_Final_New_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677485);
			LandVehicle.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677486);
			LandVehicle.NativeMethodInfoPtr_InitializeSaveable_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677487);
			LandVehicle.NativeMethodInfoPtr_OnStartServer_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677488);
			LandVehicle.NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677489);
			LandVehicle.NativeMethodInfoPtr_OnStartClient_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677490);
			LandVehicle.NativeMethodInfoPtr_SetIsPlayerOwned_Public_Void_NetworkConnection_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677491);
			LandVehicle.NativeMethodInfoPtr_RefreshPoI_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677492);
			LandVehicle.NativeMethodInfoPtr_SetGUID_Public_Virtual_Final_New_Void_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677493);
			LandVehicle.NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677494);
			LandVehicle.NativeMethodInfoPtr_Exit_Private_Void_ExitAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677495);
			LandVehicle.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_New_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677496);
			LandVehicle.NativeMethodInfoPtr_GetNetworth_Private_Void_FloatContainer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677497);
			LandVehicle.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677498);
			LandVehicle.NativeMethodInfoPtr_OnDrawGizmos_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677499);
			LandVehicle.NativeMethodInfoPtr_FixedUpdate_Protected_Virtual_New_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677500);
			LandVehicle.NativeMethodInfoPtr_OnMinPass_Protected_Virtual_New_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677501);
			LandVehicle.NativeMethodInfoPtr_LateUpdate_Protected_Virtual_New_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677502);
			LandVehicle.NativeMethodInfoPtr_OnCollisionEnter_Private_Void_Collision_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677503);
			LandVehicle.NativeMethodInfoPtr_SetOwner_Protected_Virtual_New_Void_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677504);
			LandVehicle.NativeMethodInfoPtr_OnOwnerChanged_Protected_Virtual_New_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677505);
			LandVehicle.NativeMethodInfoPtr_SetTransform_Server_Public_Void_Vector3_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677506);
			LandVehicle.NativeMethodInfoPtr_SetTransform_Public_Void_Vector3_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677507);
			LandVehicle.NativeMethodInfoPtr_DestroyVehicle_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677508);
			LandVehicle.NativeMethodInfoPtr_UpdateThrottle_Protected_Virtual_New_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677509);
			LandVehicle.NativeMethodInfoPtr_ApplyThrottle_Protected_Virtual_New_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677510);
			LandVehicle.NativeMethodInfoPtr_ApplyHandbrake_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677511);
			LandVehicle.NativeMethodInfoPtr_SetSteeringAngle_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677512);
			LandVehicle.NativeMethodInfoPtr_UpdateSteerAngle_Protected_Virtual_New_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677513);
			LandVehicle.NativeMethodInfoPtr_ApplySteerAngle_Protected_Virtual_New_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677514);
			LandVehicle.NativeMethodInfoPtr_DelaySetStatic_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677515);
			LandVehicle.NativeMethodInfoPtr_SetIsStatic_Public_Virtual_New_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677516);
			LandVehicle.NativeMethodInfoPtr_AlignTo_Public_Void_Transform_EParkingAlignment_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677517);
			LandVehicle.NativeMethodInfoPtr_GetAlignmentTransform_Public_Tuple_2_Vector3_Quaternion_Transform_EParkingAlignment_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677518);
			LandVehicle.NativeMethodInfoPtr_GetVehicleValue_Public_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677519);
			LandVehicle.NativeMethodInfoPtr_OverrideMaxSteerAngle_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677520);
			LandVehicle.NativeMethodInfoPtr_ResetMaxSteerAngle_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677521);
			LandVehicle.NativeMethodInfoPtr_SetObstaclesActive_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677522);
			LandVehicle.NativeMethodInfoPtr_GetFirstFreeSeat_Public_VehicleSeat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677523);
			LandVehicle.NativeMethodInfoPtr_SetSeatOccupant_Private_Void_NetworkConnection_Int32_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677524);
			LandVehicle.NativeMethodInfoPtr_SetSeatOccupant_Server_Private_Void_Int32_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677525);
			LandVehicle.NativeMethodInfoPtr_Hovered_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677526);
			LandVehicle.NativeMethodInfoPtr_Interacted_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677527);
			LandVehicle.NativeMethodInfoPtr_EnterVehicle_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677528);
			LandVehicle.NativeMethodInfoPtr_ExitVehicle_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677529);
			LandVehicle.NativeMethodInfoPtr_EndJustExited_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677530);
			LandVehicle.NativeMethodInfoPtr_GetExitPoint_Public_Transform_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677531);
			LandVehicle.NativeMethodInfoPtr_GetClosestExitPoint_Private_Transform_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677532);
			LandVehicle.NativeMethodInfoPtr_GetValidExitPoint_Private_Transform_List_1_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677533);
			LandVehicle.NativeMethodInfoPtr_AddNPCOccupant_Public_Void_NPC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677534);
			LandVehicle.NativeMethodInfoPtr_RemoveNPCOccupant_Public_Void_NPC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677535);
			LandVehicle.NativeMethodInfoPtr_CanBeRecovered_Public_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677536);
			LandVehicle.NativeMethodInfoPtr_RecoverVehicle_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677537);
			LandVehicle.NativeMethodInfoPtr_SendOwnedColor_Public_Void_EVehicleColor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677538);
			LandVehicle.NativeMethodInfoPtr_SetOwnedColor_Protected_Virtual_New_Void_NetworkConnection_EVehicleColor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677539);
			LandVehicle.NativeMethodInfoPtr_ApplyColor_Public_Virtual_New_Void_EVehicleColor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677540);
			LandVehicle.NativeMethodInfoPtr_ApplyOwnedColor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677541);
			LandVehicle.NativeMethodInfoPtr_ShowOutline_Public_Void_EOutlineColor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677542);
			LandVehicle.NativeMethodInfoPtr_HideOutline_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677543);
			LandVehicle.NativeMethodInfoPtr_Park_Networked_Private_Void_NetworkConnection_ParkData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677544);
			LandVehicle.NativeMethodInfoPtr_Park_Public_Void_NetworkConnection_ParkData_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677545);
			LandVehicle.NativeMethodInfoPtr_ExitPark_Networked_Public_Void_NetworkConnection_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677546);
			LandVehicle.NativeMethodInfoPtr_ExitPark_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677547);
			LandVehicle.NativeMethodInfoPtr_SetVisible_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677548);
			LandVehicle.NativeMethodInfoPtr_GetContents_Public_List_1_ItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677549);
			LandVehicle.NativeMethodInfoPtr_GetVehicleData_Public_Virtual_New_VehicleData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677550);
			LandVehicle.NativeMethodInfoPtr_GetSaveString_Public_Virtual_Final_New_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677551);
			LandVehicle.NativeMethodInfoPtr_GetContentsSet_Private_ItemSet_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677552);
			LandVehicle.NativeMethodInfoPtr_Load_Public_Virtual_New_Void_VehicleData_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677553);
			LandVehicle.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677554);
			LandVehicle.NativeMethodInfoPtr__ApplyColor_b__249_0_Private_Boolean_VehicleColorData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677555);
			LandVehicle.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677556);
			LandVehicle.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677557);
			LandVehicle.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677558);
			LandVehicle.NativeMethodInfoPtr_RpcWriter___Observers_SetIsPlayerOwned_214505783_Private_Void_NetworkConnection_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677559);
			LandVehicle.NativeMethodInfoPtr_RpcLogic___SetIsPlayerOwned_214505783_Public_Void_NetworkConnection_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677560);
			LandVehicle.NativeMethodInfoPtr_RpcReader___Observers_SetIsPlayerOwned_214505783_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677561);
			LandVehicle.NativeMethodInfoPtr_RpcWriter___Target_SetIsPlayerOwned_214505783_Private_Void_NetworkConnection_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677562);
			LandVehicle.NativeMethodInfoPtr_RpcReader___Target_SetIsPlayerOwned_214505783_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677563);
			LandVehicle.NativeMethodInfoPtr_RpcWriter___Server_SetOwner_328543758_Private_Void_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677564);
			LandVehicle.NativeMethodInfoPtr_RpcLogic___SetOwner_328543758_Protected_Virtual_New_Void_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677565);
			LandVehicle.NativeMethodInfoPtr_RpcReader___Server_SetOwner_328543758_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677566);
			LandVehicle.NativeMethodInfoPtr_RpcWriter___Observers_OnOwnerChanged_2166136261_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677567);
			LandVehicle.NativeMethodInfoPtr_RpcLogic___OnOwnerChanged_2166136261_Protected_Virtual_New_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677568);
			LandVehicle.NativeMethodInfoPtr_RpcReader___Observers_OnOwnerChanged_2166136261_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677569);
			LandVehicle.NativeMethodInfoPtr_RpcWriter___Server_SetTransform_Server_3848837105_Private_Void_Vector3_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677570);
			LandVehicle.NativeMethodInfoPtr_RpcLogic___SetTransform_Server_3848837105_Public_Void_Vector3_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677571);
			LandVehicle.NativeMethodInfoPtr_RpcReader___Server_SetTransform_Server_3848837105_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677572);
			LandVehicle.NativeMethodInfoPtr_RpcWriter___Observers_SetTransform_3848837105_Private_Void_Vector3_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677573);
			LandVehicle.NativeMethodInfoPtr_RpcLogic___SetTransform_3848837105_Public_Void_Vector3_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677574);
			LandVehicle.NativeMethodInfoPtr_RpcReader___Observers_SetTransform_3848837105_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677575);
			LandVehicle.NativeMethodInfoPtr_RpcWriter___Server_SetSteeringAngle_431000436_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677576);
			LandVehicle.NativeMethodInfoPtr_RpcLogic___SetSteeringAngle_431000436_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677577);
			LandVehicle.NativeMethodInfoPtr_RpcReader___Server_SetSteeringAngle_431000436_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677578);
			LandVehicle.NativeMethodInfoPtr_RpcWriter___Observers_SetSeatOccupant_3428404692_Private_Void_NetworkConnection_Int32_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677579);
			LandVehicle.NativeMethodInfoPtr_RpcLogic___SetSeatOccupant_3428404692_Private_Void_NetworkConnection_Int32_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677580);
			LandVehicle.NativeMethodInfoPtr_RpcReader___Observers_SetSeatOccupant_3428404692_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677581);
			LandVehicle.NativeMethodInfoPtr_RpcWriter___Target_SetSeatOccupant_3428404692_Private_Void_NetworkConnection_Int32_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677582);
			LandVehicle.NativeMethodInfoPtr_RpcReader___Target_SetSeatOccupant_3428404692_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677583);
			LandVehicle.NativeMethodInfoPtr_RpcWriter___Server_SetSeatOccupant_Server_3266232555_Private_Void_Int32_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677584);
			LandVehicle.NativeMethodInfoPtr_RpcLogic___SetSeatOccupant_Server_3266232555_Private_Void_Int32_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677585);
			LandVehicle.NativeMethodInfoPtr_RpcReader___Server_SetSeatOccupant_Server_3266232555_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677586);
			LandVehicle.NativeMethodInfoPtr_RpcWriter___Server_SendOwnedColor_911055161_Private_Void_EVehicleColor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677587);
			LandVehicle.NativeMethodInfoPtr_RpcLogic___SendOwnedColor_911055161_Public_Void_EVehicleColor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677588);
			LandVehicle.NativeMethodInfoPtr_RpcReader___Server_SendOwnedColor_911055161_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677589);
			LandVehicle.NativeMethodInfoPtr_RpcWriter___Target_SetOwnedColor_1679996372_Private_Void_NetworkConnection_EVehicleColor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677590);
			LandVehicle.NativeMethodInfoPtr_RpcLogic___SetOwnedColor_1679996372_Protected_Virtual_New_Void_NetworkConnection_EVehicleColor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677591);
			LandVehicle.NativeMethodInfoPtr_RpcReader___Target_SetOwnedColor_1679996372_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677592);
			LandVehicle.NativeMethodInfoPtr_RpcWriter___Observers_SetOwnedColor_1679996372_Private_Void_NetworkConnection_EVehicleColor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677593);
			LandVehicle.NativeMethodInfoPtr_RpcReader___Observers_SetOwnedColor_1679996372_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677594);
			LandVehicle.NativeMethodInfoPtr_RpcWriter___Observers_Park_Networked_2633993806_Private_Void_NetworkConnection_ParkData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677595);
			LandVehicle.NativeMethodInfoPtr_RpcLogic___Park_Networked_2633993806_Private_Void_NetworkConnection_ParkData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677596);
			LandVehicle.NativeMethodInfoPtr_RpcReader___Observers_Park_Networked_2633993806_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677597);
			LandVehicle.NativeMethodInfoPtr_RpcWriter___Target_Park_Networked_2633993806_Private_Void_NetworkConnection_ParkData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677598);
			LandVehicle.NativeMethodInfoPtr_RpcReader___Target_Park_Networked_2633993806_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677599);
			LandVehicle.NativeMethodInfoPtr_RpcWriter___Observers_ExitPark_Networked_214505783_Private_Void_NetworkConnection_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677600);
			LandVehicle.NativeMethodInfoPtr_RpcLogic___ExitPark_Networked_214505783_Public_Void_NetworkConnection_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677601);
			LandVehicle.NativeMethodInfoPtr_RpcReader___Observers_ExitPark_Networked_214505783_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677602);
			LandVehicle.NativeMethodInfoPtr_RpcWriter___Target_ExitPark_Networked_214505783_Private_Void_NetworkConnection_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677603);
			LandVehicle.NativeMethodInfoPtr_RpcReader___Target_ExitPark_Networked_214505783_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677604);
			LandVehicle.NativeMethodInfoPtr_sync___get_value_currentSteerAngle_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677605);
			LandVehicle.NativeMethodInfoPtr_sync___set_value_currentSteerAngle_Public_set_Void_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677606);
			LandVehicle.NativeMethodInfoPtr_ReadSyncVar___ScheduleOne_Vehicles_LandVehicle_Public_Virtual_Boolean_PooledReader_UInt32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677607);
			LandVehicle.NativeMethodInfoPtr_sync___get_value__brakesApplied_k__BackingField_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677608);
			LandVehicle.NativeMethodInfoPtr_sync___set_value__brakesApplied_k__BackingField_Public_set_Void_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677609);
			LandVehicle.NativeMethodInfoPtr_sync___get_value__isReversing_k__BackingField_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677610);
			LandVehicle.NativeMethodInfoPtr_sync___set_value__isReversing_k__BackingField_Public_set_Void_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677611);
			LandVehicle.NativeMethodInfoPtr_Method_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, 100677612);
		}

		// Token: 0x1700218F RID: 8591
		// (get) Token: 0x06006F12 RID: 28434 RVA: 0x001EF8F4 File Offset: 0x001EDAF4
		public unsafe string VehicleName
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_get_VehicleName_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return IL2CPP.Il2CppStringToManaged(il2CppString);
			}
		}

		// Token: 0x17002190 RID: 8592
		// (get) Token: 0x06006F13 RID: 28435 RVA: 0x001EF92C File Offset: 0x001EDB2C
		public unsafe string VehicleCode
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_get_VehicleCode_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return IL2CPP.Il2CppStringToManaged(il2CppString);
			}
		}

		// Token: 0x17002191 RID: 8593
		// (get) Token: 0x06006F14 RID: 28436 RVA: 0x001EF964 File Offset: 0x001EDB64
		public unsafe float VehiclePrice
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_get_VehiclePrice_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
		}

		// Token: 0x17002192 RID: 8594
		// (get) Token: 0x06006F15 RID: 28437 RVA: 0x001EF9A0 File Offset: 0x001EDBA0
		// (set) Token: 0x06006F16 RID: 28438 RVA: 0x001EF9DC File Offset: 0x001EDBDC
		public unsafe bool IsPlayerOwned
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_get_IsPlayerOwned_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
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
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_set_IsPlayerOwned_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x17002193 RID: 8595
		// (get) Token: 0x06006F17 RID: 28439 RVA: 0x001EFA1C File Offset: 0x001EDC1C
		// (set) Token: 0x06006F18 RID: 28440 RVA: 0x001EFA58 File Offset: 0x001EDC58
		public unsafe bool IsVisible
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_get_IsVisible_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
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
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_set_IsVisible_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x17002194 RID: 8596
		// (get) Token: 0x06006F19 RID: 28441 RVA: 0x001EFA98 File Offset: 0x001EDC98
		// (set) Token: 0x06006F1A RID: 28442 RVA: 0x001EFAD4 File Offset: 0x001EDCD4
		public unsafe virtual Il2CppSystem.Guid GUID
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_get_GUID_Public_Virtual_Final_New_get_Guid_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
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
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_set_GUID_Protected_set_Void_Guid_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x17002195 RID: 8597
		// (get) Token: 0x06006F1B RID: 28443 RVA: 0x001EFB14 File Offset: 0x001EDD14
		// (set) Token: 0x06006F1C RID: 28444 RVA: 0x001EFB50 File Offset: 0x001EDD50
		public unsafe float DistanceToLocalCamera
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_get_DistanceToLocalCamera_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
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
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_set_DistanceToLocalCamera_Private_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x17002196 RID: 8598
		// (get) Token: 0x06006F1D RID: 28445 RVA: 0x001EFB90 File Offset: 0x001EDD90
		public unsafe Vector3 boundingBoxDimensions
		{
			[CallerCount(9)]
			[CachedScanResults(RefRangeStart = 221905, RefRangeEnd = 221914, XrefRangeStart = 221896, XrefRangeEnd = 221905, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_get_boundingBoxDimensions_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
		}

		// Token: 0x17002197 RID: 8599
		// (get) Token: 0x06006F1E RID: 28446 RVA: 0x001EFBCC File Offset: 0x001EDDCC
		public unsafe Transform driverEntryPoint
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 221914, XrefRangeEnd = 221918, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_get_driverEntryPoint_Public_get_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
		}

		// Token: 0x17002198 RID: 8600
		// (get) Token: 0x06006F1F RID: 28447 RVA: 0x001EFC0C File Offset: 0x001EDE0C
		public unsafe Rigidbody Rb
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_get_Rb_Public_get_Rigidbody_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Rigidbody>(intPtr2) : null;
			}
		}

		// Token: 0x17002199 RID: 8601
		// (get) Token: 0x06006F20 RID: 28448 RVA: 0x001EFC4C File Offset: 0x001EDE4C
		public unsafe float ActualMaxSteeringAngle
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 221918, RefRangeEnd = 221925, XrefRangeStart = 221918, XrefRangeEnd = 221918, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_get_ActualMaxSteeringAngle_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
		}

		// Token: 0x1700219A RID: 8602
		// (get) Token: 0x06006F21 RID: 28449 RVA: 0x001EFC88 File Offset: 0x001EDE88
		// (set) Token: 0x06006F22 RID: 28450 RVA: 0x001EFCC4 File Offset: 0x001EDEC4
		public unsafe bool MaxSteerAngleOverridden
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_get_MaxSteerAngleOverridden_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
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
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_set_MaxSteerAngleOverridden_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x1700219B RID: 8603
		// (get) Token: 0x06006F23 RID: 28451 RVA: 0x001EFD04 File Offset: 0x001EDF04
		// (set) Token: 0x06006F24 RID: 28452 RVA: 0x001EFD40 File Offset: 0x001EDF40
		public unsafe float OverriddenMaxSteerAngle
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_get_OverriddenMaxSteerAngle_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
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
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_set_OverriddenMaxSteerAngle_Private_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x1700219C RID: 8604
		// (get) Token: 0x06006F25 RID: 28453 RVA: 0x001EFD80 File Offset: 0x001EDF80
		// (set) Token: 0x06006F26 RID: 28454 RVA: 0x001EFDBC File Offset: 0x001EDFBC
		public unsafe EVehicleColor OwnedColor
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_get_OwnedColor_Public_get_EVehicleColor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
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
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_set_OwnedColor_Private_set_Void_EVehicleColor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x1700219D RID: 8605
		// (get) Token: 0x06006F27 RID: 28455 RVA: 0x001EFDFC File Offset: 0x001EDFFC
		public unsafe int Capacity
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_get_Capacity_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
		}

		// Token: 0x1700219E RID: 8606
		// (get) Token: 0x06006F28 RID: 28456 RVA: 0x001EFE38 File Offset: 0x001EE038
		public unsafe int CurrentPlayerOccupancy
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 221943, RefRangeEnd = 221947, XrefRangeStart = 221925, XrefRangeEnd = 221943, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_get_CurrentPlayerOccupancy_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
		}

		// Token: 0x1700219F RID: 8607
		// (get) Token: 0x06006F29 RID: 28457 RVA: 0x001EFE74 File Offset: 0x001EE074
		// (set) Token: 0x06006F2A RID: 28458 RVA: 0x001EFEB0 File Offset: 0x001EE0B0
		public unsafe bool localPlayerIsDriver
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_get_localPlayerIsDriver_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
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
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_set_localPlayerIsDriver_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x170021A0 RID: 8608
		// (get) Token: 0x06006F2B RID: 28459 RVA: 0x001EFEF0 File Offset: 0x001EE0F0
		// (set) Token: 0x06006F2C RID: 28460 RVA: 0x001EFF2C File Offset: 0x001EE12C
		public unsafe bool localPlayerIsInVehicle
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_get_localPlayerIsInVehicle_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
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
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_set_localPlayerIsInVehicle_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x170021A1 RID: 8609
		// (get) Token: 0x06006F2D RID: 28461 RVA: 0x001EFF6C File Offset: 0x001EE16C
		// (set) Token: 0x06006F2E RID: 28462 RVA: 0x001EFFA8 File Offset: 0x001EE1A8
		public unsafe bool isOccupied
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_get_isOccupied_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
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
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_set_isOccupied_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x170021A2 RID: 8610
		// (get) Token: 0x06006F2F RID: 28463 RVA: 0x001EFFE8 File Offset: 0x001EE1E8
		public unsafe Player DriverPlayer
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 221951, RefRangeEnd = 221965, XrefRangeStart = 221947, XrefRangeEnd = 221951, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_get_DriverPlayer_Public_get_Player_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Player>(intPtr2) : null;
			}
		}

		// Token: 0x170021A3 RID: 8611
		// (get) Token: 0x06006F30 RID: 28464 RVA: 0x001F0028 File Offset: 0x001EE228
		public unsafe List<Player> OccupantPlayers
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 222003, RefRangeEnd = 222005, XrefRangeStart = 221965, XrefRangeEnd = 222003, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_get_OccupantPlayers_Public_get_List_1_Player_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Player>>(intPtr2) : null;
			}
		}

		// Token: 0x170021A4 RID: 8612
		// (get) Token: 0x06006F31 RID: 28465 RVA: 0x001F0068 File Offset: 0x001EE268
		// (set) Token: 0x06006F32 RID: 28466 RVA: 0x001F00A8 File Offset: 0x001EE2A8
		public unsafe Il2CppReferenceArray<NPC> OccupantNPCs
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 171183, RefRangeEnd = 171190, XrefRangeStart = 171183, XrefRangeEnd = 171190, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_get_OccupantNPCs_Public_get_Il2CppReferenceArray_1_NPC_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<NPC>>(intPtr2) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_set_OccupantNPCs_Protected_set_Void_Il2CppReferenceArray_1_NPC_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x170021A5 RID: 8613
		// (get) Token: 0x06006F33 RID: 28467 RVA: 0x001F00EC File Offset: 0x001EE2EC
		// (set) Token: 0x06006F34 RID: 28468 RVA: 0x001F0128 File Offset: 0x001EE328
		public unsafe float speed_Kmh
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_get_speed_Kmh_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
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
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_set_speed_Kmh_Protected_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x170021A6 RID: 8614
		// (get) Token: 0x06006F35 RID: 28469 RVA: 0x001F0168 File Offset: 0x001EE368
		public unsafe float speed_Ms
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_get_speed_Ms_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
		}

		// Token: 0x170021A7 RID: 8615
		// (get) Token: 0x06006F36 RID: 28470 RVA: 0x001F01A4 File Offset: 0x001EE3A4
		public unsafe float speed_Mph
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_get_speed_Mph_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
		}

		// Token: 0x170021A8 RID: 8616
		// (get) Token: 0x06006F37 RID: 28471 RVA: 0x001F01E0 File Offset: 0x001EE3E0
		// (set) Token: 0x06006F38 RID: 28472 RVA: 0x001F021C File Offset: 0x001EE41C
		public unsafe float currentThrottle
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_get_currentThrottle_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
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
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_set_currentThrottle_Protected_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x170021A9 RID: 8617
		// (get) Token: 0x06006F39 RID: 28473 RVA: 0x001F025C File Offset: 0x001EE45C
		// (set) Token: 0x06006F3A RID: 28474 RVA: 0x001F0298 File Offset: 0x001EE498
		public unsafe bool brakesApplied
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 222005, RefRangeEnd = 222007, XrefRangeStart = 222005, XrefRangeEnd = 222005, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_get_brakesApplied_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 222014, RefRangeEnd = 222019, XrefRangeStart = 222007, XrefRangeEnd = 222014, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = ref value;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_set_brakesApplied_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x170021AA RID: 8618
		// (get) Token: 0x06006F3B RID: 28475 RVA: 0x001F02D8 File Offset: 0x001EE4D8
		// (set) Token: 0x06006F3C RID: 28476 RVA: 0x001F0314 File Offset: 0x001EE514
		public unsafe bool isReversing
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 222019, RefRangeEnd = 222021, XrefRangeStart = 222019, XrefRangeEnd = 222019, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_get_isReversing_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 222028, RefRangeEnd = 222031, XrefRangeStart = 222021, XrefRangeEnd = 222028, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = ref value;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_set_isReversing_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x170021AB RID: 8619
		// (get) Token: 0x06006F3D RID: 28477 RVA: 0x001F0354 File Offset: 0x001EE554
		// (set) Token: 0x06006F3E RID: 28478 RVA: 0x001F0390 File Offset: 0x001EE590
		public unsafe bool isStatic
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_get_isStatic_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
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
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_set_isStatic_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x170021AC RID: 8620
		// (get) Token: 0x06006F3F RID: 28479 RVA: 0x001F03D0 File Offset: 0x001EE5D0
		// (set) Token: 0x06006F40 RID: 28480 RVA: 0x001F040C File Offset: 0x001EE60C
		public unsafe bool handbrakeApplied
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_get_handbrakeApplied_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
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
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_set_handbrakeApplied_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x170021AD RID: 8621
		// (get) Token: 0x06006F41 RID: 28481 RVA: 0x001F044C File Offset: 0x001EE64C
		public unsafe float boundingBaseOffset
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 222031, XrefRangeEnd = 222036, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_get_boundingBaseOffset_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
		}

		// Token: 0x170021AE RID: 8622
		// (get) Token: 0x06006F42 RID: 28482 RVA: 0x001F0488 File Offset: 0x001EE688
		public unsafe bool isParked
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 222040, RefRangeEnd = 222041, XrefRangeStart = 222036, XrefRangeEnd = 222040, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_get_isParked_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
		}

		// Token: 0x170021AF RID: 8623
		// (get) Token: 0x06006F43 RID: 28483 RVA: 0x001F04C4 File Offset: 0x001EE6C4
		// (set) Token: 0x06006F44 RID: 28484 RVA: 0x001F0504 File Offset: 0x001EE704
		public unsafe ParkingLot CurrentParkingLot
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_get_CurrentParkingLot_Public_get_ParkingLot_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ParkingLot>(intPtr2) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 222041, XrefRangeEnd = 222042, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_set_CurrentParkingLot_Protected_set_Void_ParkingLot_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x170021B0 RID: 8624
		// (get) Token: 0x06006F45 RID: 28485 RVA: 0x001F0548 File Offset: 0x001EE748
		// (set) Token: 0x06006F46 RID: 28486 RVA: 0x001F0588 File Offset: 0x001EE788
		public unsafe ParkingSpot CurrentParkingSpot
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 122677, RefRangeEnd = 122678, XrefRangeStart = 122677, XrefRangeEnd = 122678, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_get_CurrentParkingSpot_Public_get_ParkingSpot_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ParkingSpot>(intPtr2) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_set_CurrentParkingSpot_Protected_set_Void_ParkingSpot_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x170021B1 RID: 8625
		// (get) Token: 0x06006F47 RID: 28487 RVA: 0x001F05CC File Offset: 0x001EE7CC
		public unsafe virtual string SaveFolderName
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 222042, XrefRangeEnd = 222047, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_get_SaveFolderName_Public_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return IL2CPP.Il2CppStringToManaged(il2CppString);
			}
		}

		// Token: 0x170021B2 RID: 8626
		// (get) Token: 0x06006F48 RID: 28488 RVA: 0x001F0604 File Offset: 0x001EE804
		public unsafe virtual string SaveFileName
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 222047, XrefRangeEnd = 222049, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_get_SaveFileName_Public_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return IL2CPP.Il2CppStringToManaged(il2CppString);
			}
		}

		// Token: 0x170021B3 RID: 8627
		// (get) Token: 0x06006F49 RID: 28489 RVA: 0x001F063C File Offset: 0x001EE83C
		public unsafe virtual Loader Loader
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_get_Loader_Public_Virtual_Final_New_get_Loader_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Loader>(intPtr2) : null;
			}
		}

		// Token: 0x170021B4 RID: 8628
		// (get) Token: 0x06006F4A RID: 28490 RVA: 0x001F067C File Offset: 0x001EE87C
		public unsafe virtual bool ShouldSaveUnderFolder
		{
			[CallerCount(176)]
			[CachedScanResults(RefRangeStart = 38110, RefRangeEnd = 38286, XrefRangeStart = 38110, XrefRangeEnd = 38286, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_get_ShouldSaveUnderFolder_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
		}

		// Token: 0x170021B5 RID: 8629
		// (get) Token: 0x06006F4B RID: 28491 RVA: 0x001F06B8 File Offset: 0x001EE8B8
		// (set) Token: 0x06006F4C RID: 28492 RVA: 0x001F06F8 File Offset: 0x001EE8F8
		public unsafe virtual List<string> LocalExtraFiles
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_get_LocalExtraFiles_Public_Virtual_Final_New_get_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 222049, XrefRangeEnd = 222050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_set_LocalExtraFiles_Public_Virtual_Final_New_set_Void_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x170021B6 RID: 8630
		// (get) Token: 0x06006F4D RID: 28493 RVA: 0x001F073C File Offset: 0x001EE93C
		// (set) Token: 0x06006F4E RID: 28494 RVA: 0x001F077C File Offset: 0x001EE97C
		public unsafe virtual List<string> LocalExtraFolders
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_get_LocalExtraFolders_Public_Virtual_Final_New_get_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 222050, XrefRangeEnd = 222051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_set_LocalExtraFolders_Public_Virtual_Final_New_set_Void_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x170021B7 RID: 8631
		// (get) Token: 0x06006F4F RID: 28495 RVA: 0x001F07C0 File Offset: 0x001EE9C0
		// (set) Token: 0x06006F50 RID: 28496 RVA: 0x001F07FC File Offset: 0x001EE9FC
		public unsafe virtual bool HasChanged
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_get_HasChanged_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
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
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_set_HasChanged_Public_Virtual_Final_New_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x06006F51 RID: 28497 RVA: 0x001F083C File Offset: 0x001EEA3C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 222052, RefRangeEnd = 222053, XrefRangeStart = 222051, XrefRangeEnd = 222052, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LandVehicle.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006F52 RID: 28498 RVA: 0x001F0878 File Offset: 0x001EEA78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 222053, XrefRangeEnd = 222059, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void InitializeSaveable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LandVehicle.NativeMethodInfoPtr_InitializeSaveable_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006F53 RID: 28499 RVA: 0x001F08B4 File Offset: 0x001EEAB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 222059, XrefRangeEnd = 222065, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnStartServer()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LandVehicle.NativeMethodInfoPtr_OnStartServer_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006F54 RID: 28500 RVA: 0x001F08F0 File Offset: 0x001EEAF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 222065, XrefRangeEnd = 222079, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnSpawnServer(NetworkConnection connection)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(connection);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LandVehicle.NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006F55 RID: 28501 RVA: 0x001F0940 File Offset: 0x001EEB40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 222079, XrefRangeEnd = 222086, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnStartClient()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LandVehicle.NativeMethodInfoPtr_OnStartClient_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006F56 RID: 28502 RVA: 0x001F097C File Offset: 0x001EEB7C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 222128, RefRangeEnd = 222131, XrefRangeStart = 222086, XrefRangeEnd = 222128, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetIsPlayerOwned(NetworkConnection conn, bool playerOwned)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref playerOwned;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_SetIsPlayerOwned_Public_Void_NetworkConnection_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006F57 RID: 28503 RVA: 0x001F09CC File Offset: 0x001EEBCC
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 222141, RefRangeEnd = 222147, XrefRangeStart = 222131, XrefRangeEnd = 222141, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RefreshPoI()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_RefreshPoI_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006F58 RID: 28504 RVA: 0x001F0A00 File Offset: 0x001EEC00
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 222151, RefRangeEnd = 222152, XrefRangeStart = 222147, XrefRangeEnd = 222151, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetGUID(Il2CppSystem.Guid guid)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref guid;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_SetGUID_Public_Virtual_Final_New_Void_Guid_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006F59 RID: 28505 RVA: 0x001F0A40 File Offset: 0x001EEC40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 222152, XrefRangeEnd = 222276, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LandVehicle.NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_1), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006F5A RID: 28506 RVA: 0x001F0A7C File Offset: 0x001EEC7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 222276, XrefRangeEnd = 222278, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Exit(ExitAction action)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(action);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_Exit_Private_Void_ExitAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006F5B RID: 28507 RVA: 0x001F0AC0 File Offset: 0x001EECC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 222278, XrefRangeEnd = 222332, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LandVehicle.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_New_Void_1), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006F5C RID: 28508 RVA: 0x001F0AFC File Offset: 0x001EECFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 222332, XrefRangeEnd = 222333, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GetNetworth(MoneyManager.FloatContainer container)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(container);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_GetNetworth_Private_Void_FloatContainer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006F5D RID: 28509 RVA: 0x001F0B40 File Offset: 0x001EED40
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 222377, RefRangeEnd = 222378, XrefRangeStart = 222333, XrefRangeEnd = 222377, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LandVehicle.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_1), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006F5E RID: 28510 RVA: 0x001F0B7C File Offset: 0x001EED7C
		[CallerCount(14558)]
		[CachedScanResults(RefRangeStart = 2769, RefRangeEnd = 17327, XrefRangeStart = 2769, XrefRangeEnd = 17327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDrawGizmos()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_OnDrawGizmos_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006F5F RID: 28511 RVA: 0x001F0BB0 File Offset: 0x001EEDB0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 222468, RefRangeEnd = 222469, XrefRangeStart = 222378, XrefRangeEnd = 222468, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void FixedUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LandVehicle.NativeMethodInfoPtr_FixedUpdate_Protected_Virtual_New_Void_1), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006F60 RID: 28512 RVA: 0x001F0BEC File Offset: 0x001EEDEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 222469, XrefRangeEnd = 222492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnMinPass()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LandVehicle.NativeMethodInfoPtr_OnMinPass_Protected_Virtual_New_Void_1), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006F61 RID: 28513 RVA: 0x001F0C28 File Offset: 0x001EEE28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 222492, XrefRangeEnd = 222504, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void LateUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LandVehicle.NativeMethodInfoPtr_LateUpdate_Protected_Virtual_New_Void_1), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006F62 RID: 28514 RVA: 0x001F0C64 File Offset: 0x001EEE64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 222504, XrefRangeEnd = 222507, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnCollisionEnter(Collision collision)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(collision);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_OnCollisionEnter_Private_Void_Collision_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006F63 RID: 28515 RVA: 0x001F0CA8 File Offset: 0x001EEEA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 222507, XrefRangeEnd = 222517, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetOwner(NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LandVehicle.NativeMethodInfoPtr_SetOwner_Protected_Virtual_New_Void_NetworkConnection_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006F64 RID: 28516 RVA: 0x001F0CF8 File Offset: 0x001EEEF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 222517, XrefRangeEnd = 222526, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnOwnerChanged()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LandVehicle.NativeMethodInfoPtr_OnOwnerChanged_Protected_Virtual_New_Void_1), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006F65 RID: 28517 RVA: 0x001F0D34 File Offset: 0x001EEF34
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 222528, RefRangeEnd = 222529, XrefRangeStart = 222526, XrefRangeEnd = 222528, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetTransform_Server(Vector3 pos, Quaternion rot)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref pos;
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref rot;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_SetTransform_Server_Public_Void_Vector3_Quaternion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006F66 RID: 28518 RVA: 0x001F0D80 File Offset: 0x001EEF80
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 222536, RefRangeEnd = 222543, XrefRangeStart = 222529, XrefRangeEnd = 222536, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetTransform(Vector3 pos, Quaternion rot)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref pos;
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref rot;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_SetTransform_Public_Void_Vector3_Quaternion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006F67 RID: 28519 RVA: 0x001F0DCC File Offset: 0x001EEFCC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 222543, XrefRangeEnd = 222571, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DestroyVehicle()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_DestroyVehicle_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006F68 RID: 28520 RVA: 0x001F0E00 File Offset: 0x001EF000
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 222571, XrefRangeEnd = 222576, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void UpdateThrottle()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LandVehicle.NativeMethodInfoPtr_UpdateThrottle_Protected_Virtual_New_Void_1), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006F69 RID: 28521 RVA: 0x001F0E3C File Offset: 0x001EF03C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 222576, XrefRangeEnd = 222635, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void ApplyThrottle()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LandVehicle.NativeMethodInfoPtr_ApplyThrottle_Protected_Virtual_New_Void_1), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006F6A RID: 28522 RVA: 0x001F0E78 File Offset: 0x001EF078
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 222638, RefRangeEnd = 222639, XrefRangeStart = 222635, XrefRangeEnd = 222638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ApplyHandbrake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_ApplyHandbrake_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006F6B RID: 28523 RVA: 0x001F0EAC File Offset: 0x001EF0AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 222639, XrefRangeEnd = 222649, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetSteeringAngle(float sa)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref sa;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_SetSteeringAngle_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006F6C RID: 28524 RVA: 0x001F0EEC File Offset: 0x001EF0EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 222649, XrefRangeEnd = 222716, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void UpdateSteerAngle()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LandVehicle.NativeMethodInfoPtr_UpdateSteerAngle_Protected_Virtual_New_Void_1), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006F6D RID: 28525 RVA: 0x001F0F28 File Offset: 0x001EF128
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 222716, XrefRangeEnd = 222718, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void ApplySteerAngle()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LandVehicle.NativeMethodInfoPtr_ApplySteerAngle_Protected_Virtual_New_Void_1), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006F6E RID: 28526 RVA: 0x001F0F64 File Offset: 0x001EF164
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 222718, XrefRangeEnd = 222726, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DelaySetStatic(bool stat)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref stat;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_DelaySetStatic_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006F6F RID: 28527 RVA: 0x001F0FA4 File Offset: 0x001EF1A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 222726, XrefRangeEnd = 222742, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetIsStatic(bool stat)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref stat;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LandVehicle.NativeMethodInfoPtr_SetIsStatic_Public_Virtual_New_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006F70 RID: 28528 RVA: 0x001F0FF0 File Offset: 0x001EF1F0
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 222753, RefRangeEnd = 222757, XrefRangeStart = 222742, XrefRangeEnd = 222753, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AlignTo(Transform target, EParkingAlignment type, bool network = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref type;
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref network;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_AlignTo_Public_Void_Transform_EParkingAlignment_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006F71 RID: 28529 RVA: 0x001F1050 File Offset: 0x001EF250
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 222774, RefRangeEnd = 222777, XrefRangeStart = 222757, XrefRangeEnd = 222774, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppSystem.Tuple<Vector3, Quaternion> GetAlignmentTransform(Transform target, EParkingAlignment type)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref type;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_GetAlignmentTransform_Public_Tuple_2_Vector3_Quaternion_Transform_EParkingAlignment_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Tuple<Vector3, Quaternion>>(intPtr2) : null;
		}

		// Token: 0x06006F72 RID: 28530 RVA: 0x001F10B0 File Offset: 0x001EF2B0
		[CallerCount(0)]
		public unsafe float GetVehicleValue()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_GetVehicleValue_Public_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06006F73 RID: 28531 RVA: 0x001F10EC File Offset: 0x001EF2EC
		[CallerCount(0)]
		public unsafe void OverrideMaxSteerAngle(float maxAngle)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref maxAngle;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_OverrideMaxSteerAngle_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006F74 RID: 28532 RVA: 0x001F112C File Offset: 0x001EF32C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 222777, RefRangeEnd = 222779, XrefRangeStart = 222777, XrefRangeEnd = 222777, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ResetMaxSteerAngle()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_ResetMaxSteerAngle_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006F75 RID: 28533 RVA: 0x001F1160 File Offset: 0x001EF360
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 222779, XrefRangeEnd = 222782, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetObstaclesActive(bool active)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref active;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_SetObstaclesActive_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006F76 RID: 28534 RVA: 0x001F11A0 File Offset: 0x001EF3A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 222782, XrefRangeEnd = 222784, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe VehicleSeat GetFirstFreeSeat()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_GetFirstFreeSeat_Public_VehicleSeat_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<VehicleSeat>(intPtr2) : null;
		}

		// Token: 0x06006F77 RID: 28535 RVA: 0x001F11E0 File Offset: 0x001EF3E0
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 222830, RefRangeEnd = 222834, XrefRangeStart = 222784, XrefRangeEnd = 222830, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetSeatOccupant(NetworkConnection conn, int seatIndex, NetworkConnection occupant)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref seatIndex;
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(occupant);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_SetSeatOccupant_Private_Void_NetworkConnection_Int32_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006F78 RID: 28536 RVA: 0x001F1244 File Offset: 0x001EF444
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 222857, RefRangeEnd = 222859, XrefRangeStart = 222834, XrefRangeEnd = 222857, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetSeatOccupant_Server(int seatIndex, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref seatIndex;
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_SetSeatOccupant_Server_Private_Void_Int32_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006F79 RID: 28537 RVA: 0x001F1294 File Offset: 0x001EF494
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 222859, XrefRangeEnd = 222864, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Hovered()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_Hovered_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006F7A RID: 28538 RVA: 0x001F12C8 File Offset: 0x001EF4C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 222864, XrefRangeEnd = 222866, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Interacted()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_Interacted_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006F7B RID: 28539 RVA: 0x001F12FC File Offset: 0x001EF4FC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 222923, RefRangeEnd = 222924, XrefRangeStart = 222866, XrefRangeEnd = 222923, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EnterVehicle()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_EnterVehicle_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006F7C RID: 28540 RVA: 0x001F1330 File Offset: 0x001EF530
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 222983, RefRangeEnd = 222987, XrefRangeStart = 222924, XrefRangeEnd = 222983, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ExitVehicle()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_ExitVehicle_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006F7D RID: 28541 RVA: 0x001F1364 File Offset: 0x001EF564
		[CallerCount(0)]
		public unsafe void EndJustExited()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_EndJustExited_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006F7E RID: 28542 RVA: 0x001F1398 File Offset: 0x001EF598
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 222991, RefRangeEnd = 222992, XrefRangeStart = 222987, XrefRangeEnd = 222991, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Transform GetExitPoint(int seatIndex = 0)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref seatIndex;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_GetExitPoint_Public_Transform_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
		}

		// Token: 0x06006F7F RID: 28543 RVA: 0x001F13E4 File Offset: 0x001EF5E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 222992, XrefRangeEnd = 223008, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Transform GetClosestExitPoint(Vector3 pos)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref pos;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_GetClosestExitPoint_Private_Transform_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
		}

		// Token: 0x06006F80 RID: 28544 RVA: 0x001F1430 File Offset: 0x001EF630
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 223045, RefRangeEnd = 223046, XrefRangeStart = 223008, XrefRangeEnd = 223045, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Transform GetValidExitPoint(List<Transform> possibleExitPoints)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(possibleExitPoints);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_GetValidExitPoint_Private_Transform_List_1_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
		}

		// Token: 0x06006F81 RID: 28545 RVA: 0x001F1480 File Offset: 0x001EF680
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 223080, RefRangeEnd = 223081, XrefRangeStart = 223046, XrefRangeEnd = 223080, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddNPCOccupant(NPC npc)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(npc);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_AddNPCOccupant_Public_Void_NPC_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006F82 RID: 28546 RVA: 0x001F14C4 File Offset: 0x001EF6C4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 223113, RefRangeEnd = 223114, XrefRangeStart = 223081, XrefRangeEnd = 223113, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveNPCOccupant(NPC npc)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(npc);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_RemoveNPCOccupant_Public_Void_NPC_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006F83 RID: 28547 RVA: 0x001F1508 File Offset: 0x001EF708
		[CallerCount(0)]
		public unsafe virtual bool CanBeRecovered()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LandVehicle.NativeMethodInfoPtr_CanBeRecovered_Public_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06006F84 RID: 28548 RVA: 0x001F1550 File Offset: 0x001EF750
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 223114, XrefRangeEnd = 223130, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void RecoverVehicle()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LandVehicle.NativeMethodInfoPtr_RecoverVehicle_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006F85 RID: 28549 RVA: 0x001F158C File Offset: 0x001EF78C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 223151, RefRangeEnd = 223152, XrefRangeStart = 223130, XrefRangeEnd = 223151, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendOwnedColor(EVehicleColor col)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref col;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_SendOwnedColor_Public_Void_EVehicleColor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006F86 RID: 28550 RVA: 0x001F15CC File Offset: 0x001EF7CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 223152, XrefRangeEnd = 223194, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetOwnedColor(NetworkConnection conn, EVehicleColor col)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref col;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LandVehicle.NativeMethodInfoPtr_SetOwnedColor_Protected_Virtual_New_Void_NetworkConnection_EVehicleColor_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006F87 RID: 28551 RVA: 0x001F1628 File Offset: 0x001EF828
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 223194, XrefRangeEnd = 223211, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void ApplyColor(EVehicleColor col)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref col;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LandVehicle.NativeMethodInfoPtr_ApplyColor_Public_Virtual_New_Void_EVehicleColor_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006F88 RID: 28552 RVA: 0x001F1674 File Offset: 0x001EF874
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 223211, RefRangeEnd = 223212, XrefRangeStart = 223211, XrefRangeEnd = 223211, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ApplyOwnedColor()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_ApplyOwnedColor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006F89 RID: 28553 RVA: 0x001F16A8 File Offset: 0x001EF8A8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 223255, RefRangeEnd = 223258, XrefRangeStart = 223212, XrefRangeEnd = 223255, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ShowOutline(BuildableItem.EOutlineColor color)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref color;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_ShowOutline_Public_Void_EOutlineColor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006F8A RID: 28554 RVA: 0x001F16E8 File Offset: 0x001EF8E8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 223263, RefRangeEnd = 223265, XrefRangeStart = 223258, XrefRangeEnd = 223263, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void HideOutline()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_HideOutline_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006F8B RID: 28555 RVA: 0x001F171C File Offset: 0x001EF91C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 223307, RefRangeEnd = 223309, XrefRangeStart = 223265, XrefRangeEnd = 223307, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Park_Networked(NetworkConnection conn, ParkData parkData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parkData);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_Park_Networked_Private_Void_NetworkConnection_ParkData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006F8C RID: 28556 RVA: 0x001F1770 File Offset: 0x001EF970
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 223344, RefRangeEnd = 223350, XrefRangeStart = 223309, XrefRangeEnd = 223344, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Park(NetworkConnection conn, ParkData parkData, bool network)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parkData);
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref network;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_Park_Public_Void_NetworkConnection_ParkData_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006F8D RID: 28557 RVA: 0x001F17D4 File Offset: 0x001EF9D4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 223392, RefRangeEnd = 223393, XrefRangeStart = 223350, XrefRangeEnd = 223392, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ExitPark_Networked(NetworkConnection conn, bool moveToExitPoint = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref moveToExitPoint;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_ExitPark_Networked_Public_Void_NetworkConnection_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006F8E RID: 28558 RVA: 0x001F1824 File Offset: 0x001EFA24
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 223411, RefRangeEnd = 223417, XrefRangeStart = 223393, XrefRangeEnd = 223411, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ExitPark(bool moveToExitPoint = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref moveToExitPoint;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_ExitPark_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006F8F RID: 28559 RVA: 0x001F1864 File Offset: 0x001EFA64
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 223424, RefRangeEnd = 223428, XrefRangeStart = 223417, XrefRangeEnd = 223424, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetVisible(bool vis)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref vis;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_SetVisible_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006F90 RID: 28560 RVA: 0x001F18A4 File Offset: 0x001EFAA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 223428, XrefRangeEnd = 223442, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<ItemInstance> GetContents()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_GetContents_Public_List_1_ItemInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ItemInstance>>(intPtr2) : null;
		}

		// Token: 0x06006F91 RID: 28561 RVA: 0x001F18E4 File Offset: 0x001EFAE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 223442, XrefRangeEnd = 223460, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual VehicleData GetVehicleData()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LandVehicle.NativeMethodInfoPtr_GetVehicleData_Public_Virtual_New_VehicleData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<VehicleData>(intPtr2) : null;
		}

		// Token: 0x06006F92 RID: 28562 RVA: 0x001F1930 File Offset: 0x001EFB30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 223460, XrefRangeEnd = 223461, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual string GetSaveString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_GetSaveString_Public_Virtual_Final_New_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return IL2CPP.Il2CppStringToManaged(il2CppString);
		}

		// Token: 0x06006F93 RID: 28563 RVA: 0x001F1968 File Offset: 0x001EFB68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 223461, XrefRangeEnd = 223470, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ItemSet GetContentsSet()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_GetContentsSet_Private_ItemSet_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemSet>(intPtr2) : null;
		}

		// Token: 0x06006F94 RID: 28564 RVA: 0x001F19A8 File Offset: 0x001EFBA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 223470, XrefRangeEnd = 223506, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Load(VehicleData data, string containerPath)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(containerPath);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LandVehicle.NativeMethodInfoPtr_Load_Public_Virtual_New_Void_VehicleData_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006F95 RID: 28565 RVA: 0x001F1A08 File Offset: 0x001EFC08
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 223593, RefRangeEnd = 223595, XrefRangeStart = 223506, XrefRangeEnd = 223593, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LandVehicle() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006F96 RID: 28566 RVA: 0x001F1A44 File Offset: 0x001EFC44
		[CallerCount(0)]
		public unsafe bool _ApplyColor_b__249_0(VehicleColors.VehicleColorData x)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr__ApplyColor_b__249_0_Private_Boolean_VehicleColorData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06006F97 RID: 28567 RVA: 0x001F1A94 File Offset: 0x001EFC94
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 223731, RefRangeEnd = 223733, XrefRangeStart = 223595, XrefRangeEnd = 223731, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void NetworkInitialize___Early()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LandVehicle.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006F98 RID: 28568 RVA: 0x001F1AD0 File Offset: 0x001EFCD0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 223733, RefRangeEnd = 223734, XrefRangeStart = 223733, XrefRangeEnd = 223733, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void NetworkInitialize__Late()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LandVehicle.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006F99 RID: 28569 RVA: 0x001F1B0C File Offset: 0x001EFD0C
		[CallerCount(0)]
		public unsafe override void NetworkInitializeIfDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LandVehicle.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006F9A RID: 28570 RVA: 0x001F1B48 File Offset: 0x001EFD48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 223734, XrefRangeEnd = 223744, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_SetIsPlayerOwned_214505783(NetworkConnection conn, bool playerOwned)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref playerOwned;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_RpcWriter___Observers_SetIsPlayerOwned_214505783_Private_Void_NetworkConnection_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006F9B RID: 28571 RVA: 0x001F1B98 File Offset: 0x001EFD98
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 223763, RefRangeEnd = 223766, XrefRangeStart = 223744, XrefRangeEnd = 223763, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SetIsPlayerOwned_214505783(NetworkConnection conn, bool playerOwned)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref playerOwned;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_RpcLogic___SetIsPlayerOwned_214505783_Public_Void_NetworkConnection_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006F9C RID: 28572 RVA: 0x001F1BE8 File Offset: 0x001EFDE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 223766, XrefRangeEnd = 223769, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_SetIsPlayerOwned_214505783(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref channel;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_RpcReader___Observers_SetIsPlayerOwned_214505783_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006F9D RID: 28573 RVA: 0x001F1C38 File Offset: 0x001EFE38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 223769, XrefRangeEnd = 223779, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Target_SetIsPlayerOwned_214505783(NetworkConnection conn, bool playerOwned)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref playerOwned;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_RpcWriter___Target_SetIsPlayerOwned_214505783_Private_Void_NetworkConnection_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006F9E RID: 28574 RVA: 0x001F1C88 File Offset: 0x001EFE88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 223779, XrefRangeEnd = 223782, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Target_SetIsPlayerOwned_214505783(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref channel;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_RpcReader___Target_SetIsPlayerOwned_214505783_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006F9F RID: 28575 RVA: 0x001F1CD8 File Offset: 0x001EFED8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_SetOwner_328543758(NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_RpcWriter___Server_SetOwner_328543758_Private_Void_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006FA0 RID: 28576 RVA: 0x001F1D1C File Offset: 0x001EFF1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 223782, XrefRangeEnd = 223784, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void RpcLogic___SetOwner_328543758(NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LandVehicle.NativeMethodInfoPtr_RpcLogic___SetOwner_328543758_Protected_Virtual_New_Void_NetworkConnection_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006FA1 RID: 28577 RVA: 0x001F1D6C File Offset: 0x001EFF6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 223784, XrefRangeEnd = 223787, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_SetOwner_328543758(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref channel;
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_RpcReader___Server_SetOwner_328543758_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006FA2 RID: 28578 RVA: 0x001F1DD0 File Offset: 0x001EFFD0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_OnOwnerChanged_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_RpcWriter___Observers_OnOwnerChanged_2166136261_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006FA3 RID: 28579 RVA: 0x001F1E04 File Offset: 0x001F0004
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 223812, RefRangeEnd = 223813, XrefRangeStart = 223787, XrefRangeEnd = 223812, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void RpcLogic___OnOwnerChanged_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LandVehicle.NativeMethodInfoPtr_RpcLogic___OnOwnerChanged_2166136261_Protected_Virtual_New_Void_1), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006FA4 RID: 28580 RVA: 0x001F1E40 File Offset: 0x001F0040
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 223813, XrefRangeEnd = 223815, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_OnOwnerChanged_2166136261(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref channel;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_RpcReader___Observers_OnOwnerChanged_2166136261_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006FA5 RID: 28581 RVA: 0x001F1E90 File Offset: 0x001F0090
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 223839, RefRangeEnd = 223841, XrefRangeStart = 223815, XrefRangeEnd = 223839, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_SetTransform_Server_3848837105(Vector3 pos, Quaternion rot)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref pos;
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref rot;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_RpcWriter___Server_SetTransform_Server_3848837105_Private_Void_Vector3_Quaternion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006FA6 RID: 28582 RVA: 0x001F1EDC File Offset: 0x001F00DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 223841, XrefRangeEnd = 223842, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SetTransform_Server_3848837105(Vector3 pos, Quaternion rot)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref pos;
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref rot;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_RpcLogic___SetTransform_Server_3848837105_Public_Void_Vector3_Quaternion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006FA7 RID: 28583 RVA: 0x001F1F28 File Offset: 0x001F0128
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 223842, XrefRangeEnd = 223850, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_SetTransform_Server_3848837105(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref channel;
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_RpcReader___Server_SetTransform_Server_3848837105_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006FA8 RID: 28584 RVA: 0x001F1F8C File Offset: 0x001F018C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 223874, RefRangeEnd = 223875, XrefRangeStart = 223850, XrefRangeEnd = 223874, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_SetTransform_3848837105(Vector3 pos, Quaternion rot)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref pos;
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref rot;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_RpcWriter___Observers_SetTransform_3848837105_Private_Void_Vector3_Quaternion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006FA9 RID: 28585 RVA: 0x001F1FD8 File Offset: 0x001F01D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 223875, XrefRangeEnd = 223881, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SetTransform_3848837105(Vector3 pos, Quaternion rot)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref pos;
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref rot;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_RpcLogic___SetTransform_3848837105_Public_Void_Vector3_Quaternion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006FAA RID: 28586 RVA: 0x001F2024 File Offset: 0x001F0224
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 223881, XrefRangeEnd = 223894, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_SetTransform_3848837105(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref channel;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_RpcReader___Observers_SetTransform_3848837105_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006FAB RID: 28587 RVA: 0x001F2074 File Offset: 0x001F0274
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_SetSteeringAngle_431000436(float sa)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref sa;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_RpcWriter___Server_SetSteeringAngle_431000436_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006FAC RID: 28588 RVA: 0x001F20B4 File Offset: 0x001F02B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 223894, XrefRangeEnd = 223901, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SetSteeringAngle_431000436(float sa)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref sa;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_RpcLogic___SetSteeringAngle_431000436_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006FAD RID: 28589 RVA: 0x001F20F4 File Offset: 0x001F02F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 223901, XrefRangeEnd = 223910, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_SetSteeringAngle_431000436(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref channel;
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_RpcReader___Server_SetSteeringAngle_431000436_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006FAE RID: 28590 RVA: 0x001F2158 File Offset: 0x001F0358
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 223910, XrefRangeEnd = 223922, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_SetSeatOccupant_3428404692(NetworkConnection conn, int seatIndex, NetworkConnection occupant)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref seatIndex;
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(occupant);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_RpcWriter___Observers_SetSeatOccupant_3428404692_Private_Void_NetworkConnection_Int32_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006FAF RID: 28591 RVA: 0x001F21BC File Offset: 0x001F03BC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 223951, RefRangeEnd = 223954, XrefRangeStart = 223922, XrefRangeEnd = 223951, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SetSeatOccupant_3428404692(NetworkConnection conn, int seatIndex, NetworkConnection occupant)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref seatIndex;
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(occupant);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_RpcLogic___SetSeatOccupant_3428404692_Private_Void_NetworkConnection_Int32_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006FB0 RID: 28592 RVA: 0x001F2220 File Offset: 0x001F0420
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 223954, XrefRangeEnd = 223960, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_SetSeatOccupant_3428404692(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref channel;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_RpcReader___Observers_SetSeatOccupant_3428404692_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006FB1 RID: 28593 RVA: 0x001F2270 File Offset: 0x001F0470
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 223960, XrefRangeEnd = 223972, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Target_SetSeatOccupant_3428404692(NetworkConnection conn, int seatIndex, NetworkConnection occupant)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref seatIndex;
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(occupant);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_RpcWriter___Target_SetSeatOccupant_3428404692_Private_Void_NetworkConnection_Int32_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006FB2 RID: 28594 RVA: 0x001F22D4 File Offset: 0x001F04D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 223972, XrefRangeEnd = 223978, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Target_SetSeatOccupant_3428404692(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref channel;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_RpcReader___Target_SetSeatOccupant_3428404692_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006FB3 RID: 28595 RVA: 0x001F2324 File Offset: 0x001F0524
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 223978, XrefRangeEnd = 223990, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_SetSeatOccupant_Server_3266232555(int seatIndex, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref seatIndex;
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_RpcWriter___Server_SetSeatOccupant_Server_3266232555_Private_Void_Int32_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006FB4 RID: 28596 RVA: 0x001F2374 File Offset: 0x001F0574
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 223990, XrefRangeEnd = 223991, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SetSeatOccupant_Server_3266232555(int seatIndex, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref seatIndex;
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_RpcLogic___SetSeatOccupant_Server_3266232555_Private_Void_Int32_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006FB5 RID: 28597 RVA: 0x001F23C4 File Offset: 0x001F05C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 223991, XrefRangeEnd = 223997, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_SetSeatOccupant_Server_3266232555(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref channel;
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_RpcReader___Server_SetSeatOccupant_Server_3266232555_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006FB6 RID: 28598 RVA: 0x001F2428 File Offset: 0x001F0628
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 223997, XrefRangeEnd = 224007, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_SendOwnedColor_911055161(EVehicleColor col)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref col;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_RpcWriter___Server_SendOwnedColor_911055161_Private_Void_EVehicleColor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006FB7 RID: 28599 RVA: 0x001F2468 File Offset: 0x001F0668
		[CallerCount(0)]
		public unsafe void RpcLogic___SendOwnedColor_911055161(EVehicleColor col)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref col;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_RpcLogic___SendOwnedColor_911055161_Public_Void_EVehicleColor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006FB8 RID: 28600 RVA: 0x001F24A8 File Offset: 0x001F06A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 224007, XrefRangeEnd = 224010, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_SendOwnedColor_911055161(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref channel;
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_RpcReader___Server_SendOwnedColor_911055161_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006FB9 RID: 28601 RVA: 0x001F250C File Offset: 0x001F070C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 224010, XrefRangeEnd = 224020, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Target_SetOwnedColor_1679996372(NetworkConnection conn, EVehicleColor col)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref col;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_RpcWriter___Target_SetOwnedColor_1679996372_Private_Void_NetworkConnection_EVehicleColor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006FBA RID: 28602 RVA: 0x001F255C File Offset: 0x001F075C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 224020, XrefRangeEnd = 224021, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void RpcLogic___SetOwnedColor_1679996372(NetworkConnection conn, EVehicleColor col)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref col;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LandVehicle.NativeMethodInfoPtr_RpcLogic___SetOwnedColor_1679996372_Protected_Virtual_New_Void_NetworkConnection_EVehicleColor_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006FBB RID: 28603 RVA: 0x001F25B8 File Offset: 0x001F07B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 224021, XrefRangeEnd = 224025, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Target_SetOwnedColor_1679996372(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref channel;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_RpcReader___Target_SetOwnedColor_1679996372_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006FBC RID: 28604 RVA: 0x001F2608 File Offset: 0x001F0808
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 224025, XrefRangeEnd = 224035, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_SetOwnedColor_1679996372(NetworkConnection conn, EVehicleColor col)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref col;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_RpcWriter___Observers_SetOwnedColor_1679996372_Private_Void_NetworkConnection_EVehicleColor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006FBD RID: 28605 RVA: 0x001F2658 File Offset: 0x001F0858
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 224035, XrefRangeEnd = 224039, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_SetOwnedColor_1679996372(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref channel;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_RpcReader___Observers_SetOwnedColor_1679996372_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006FBE RID: 28606 RVA: 0x001F26A8 File Offset: 0x001F08A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 224039, XrefRangeEnd = 224049, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_Park_Networked_2633993806(NetworkConnection conn, ParkData parkData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parkData);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_RpcWriter___Observers_Park_Networked_2633993806_Private_Void_NetworkConnection_ParkData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006FBF RID: 28607 RVA: 0x001F26FC File Offset: 0x001F08FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 224049, XrefRangeEnd = 224050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___Park_Networked_2633993806(NetworkConnection conn, ParkData parkData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parkData);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_RpcLogic___Park_Networked_2633993806_Private_Void_NetworkConnection_ParkData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006FC0 RID: 28608 RVA: 0x001F2750 File Offset: 0x001F0950
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 224050, XrefRangeEnd = 224054, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_Park_Networked_2633993806(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref channel;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_RpcReader___Observers_Park_Networked_2633993806_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006FC1 RID: 28609 RVA: 0x001F27A0 File Offset: 0x001F09A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 224054, XrefRangeEnd = 224064, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Target_Park_Networked_2633993806(NetworkConnection conn, ParkData parkData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parkData);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_RpcWriter___Target_Park_Networked_2633993806_Private_Void_NetworkConnection_ParkData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006FC2 RID: 28610 RVA: 0x001F27F4 File Offset: 0x001F09F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 224064, XrefRangeEnd = 224068, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Target_Park_Networked_2633993806(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref channel;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_RpcReader___Target_Park_Networked_2633993806_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006FC3 RID: 28611 RVA: 0x001F2844 File Offset: 0x001F0A44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 224068, XrefRangeEnd = 224078, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_ExitPark_Networked_214505783(NetworkConnection conn, bool moveToExitPoint = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref moveToExitPoint;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_RpcWriter___Observers_ExitPark_Networked_214505783_Private_Void_NetworkConnection_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006FC4 RID: 28612 RVA: 0x001F2894 File Offset: 0x001F0A94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 224078, XrefRangeEnd = 224079, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___ExitPark_Networked_214505783(NetworkConnection conn, bool moveToExitPoint = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref moveToExitPoint;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_RpcLogic___ExitPark_Networked_214505783_Public_Void_NetworkConnection_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006FC5 RID: 28613 RVA: 0x001F28E4 File Offset: 0x001F0AE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 224079, XrefRangeEnd = 224082, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_ExitPark_Networked_214505783(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref channel;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_RpcReader___Observers_ExitPark_Networked_214505783_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006FC6 RID: 28614 RVA: 0x001F2934 File Offset: 0x001F0B34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 224082, XrefRangeEnd = 224092, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Target_ExitPark_Networked_214505783(NetworkConnection conn, bool moveToExitPoint = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref moveToExitPoint;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_RpcWriter___Target_ExitPark_Networked_214505783_Private_Void_NetworkConnection_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006FC7 RID: 28615 RVA: 0x001F2984 File Offset: 0x001F0B84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 224092, XrefRangeEnd = 224095, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Target_ExitPark_Networked_214505783(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref channel;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_RpcReader___Target_ExitPark_Networked_214505783_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x170021B8 RID: 8632
		// (get) Token: 0x06006FC8 RID: 28616 RVA: 0x001F29D4 File Offset: 0x001F0BD4
		// (set) Token: 0x06006FC9 RID: 28617 RVA: 0x001F2A10 File Offset: 0x001F0C10
		public unsafe float SyncAccessor_currentSteerAngle
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_sync___get_value_currentSteerAngle_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 224103, RefRangeEnd = 224107, XrefRangeStart = 224095, XrefRangeEnd = 224103, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = ref value;
				ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref value;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_sync___set_value_currentSteerAngle_Public_set_Void_Single_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x06006FCA RID: 28618 RVA: 0x001F2A5C File Offset: 0x001F0C5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 224107, XrefRangeEnd = 224112, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool ReadSyncVar___ScheduleOne_Vehicles_LandVehicle(PooledReader PooledReader0, uint UInt321, bool Boolean2)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref UInt321;
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref Boolean2;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LandVehicle.NativeMethodInfoPtr_ReadSyncVar___ScheduleOne_Vehicles_LandVehicle_Public_Virtual_Boolean_PooledReader_UInt32_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x170021B9 RID: 8633
		// (get) Token: 0x06006FCB RID: 28619 RVA: 0x001F2AD0 File Offset: 0x001F0CD0
		// (set) Token: 0x06006FCC RID: 28620 RVA: 0x001F2B0C File Offset: 0x001F0D0C
		public unsafe bool SyncAccessor_<brakesApplied>k__BackingField
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 222005, RefRangeEnd = 222007, XrefRangeStart = 222005, XrefRangeEnd = 222007, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_sync___get_value__brakesApplied_k__BackingField_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 224112, XrefRangeEnd = 224120, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = ref value;
				ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref value;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_sync___set_value__brakesApplied_k__BackingField_Public_set_Void_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x170021BA RID: 8634
		// (get) Token: 0x06006FCD RID: 28621 RVA: 0x001F2B58 File Offset: 0x001F0D58
		// (set) Token: 0x06006FCE RID: 28622 RVA: 0x001F2B94 File Offset: 0x001F0D94
		public unsafe bool SyncAccessor_<isReversing>k__BackingField
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 222019, RefRangeEnd = 222021, XrefRangeStart = 222019, XrefRangeEnd = 222021, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_sync___get_value__isReversing_k__BackingField_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 224120, XrefRangeEnd = 224128, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = ref value;
				ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref value;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.NativeMethodInfoPtr_sync___set_value__isReversing_k__BackingField_Public_set_Void_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x06006FCF RID: 28623 RVA: 0x001F2BE0 File Offset: 0x001F0DE0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 224170, RefRangeEnd = 224173, XrefRangeStart = 224128, XrefRangeEnd = 224170, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Method_Protected_Virtual_New_Void_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LandVehicle.NativeMethodInfoPtr_Method_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006FD0 RID: 28624 RVA: 0x0003457A File Offset: 0x0003277A
		public LandVehicle(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002131 RID: 8497
		// (get) Token: 0x06006FD1 RID: 28625 RVA: 0x001F2C1C File Offset: 0x001F0E1C
		// (set) Token: 0x06006FD2 RID: 28626 RVA: 0x00034583 File Offset: 0x00032783
		public unsafe static float KINEMATIC_THRESHOLD_DISTANCE
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(LandVehicle.NativeFieldInfoPtr_KINEMATIC_THRESHOLD_DISTANCE, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LandVehicle.NativeFieldInfoPtr_KINEMATIC_THRESHOLD_DISTANCE, (void*)(&value));
			}
		}

		// Token: 0x17002132 RID: 8498
		// (get) Token: 0x06006FD3 RID: 28627 RVA: 0x001F2C38 File Offset: 0x001F0E38
		// (set) Token: 0x06006FD4 RID: 28628 RVA: 0x00034591 File Offset: 0x00032791
		public unsafe static float MAX_TURNOVER_SPEED
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(LandVehicle.NativeFieldInfoPtr_MAX_TURNOVER_SPEED, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LandVehicle.NativeFieldInfoPtr_MAX_TURNOVER_SPEED, (void*)(&value));
			}
		}

		// Token: 0x17002133 RID: 8499
		// (get) Token: 0x06006FD5 RID: 28629 RVA: 0x001F2C54 File Offset: 0x001F0E54
		// (set) Token: 0x06006FD6 RID: 28630 RVA: 0x0003459F File Offset: 0x0003279F
		public unsafe static float TURNOVER_FORCE
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(LandVehicle.NativeFieldInfoPtr_TURNOVER_FORCE, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LandVehicle.NativeFieldInfoPtr_TURNOVER_FORCE, (void*)(&value));
			}
		}

		// Token: 0x17002134 RID: 8500
		// (get) Token: 0x06006FD7 RID: 28631 RVA: 0x001F2C70 File Offset: 0x001F0E70
		// (set) Token: 0x06006FD8 RID: 28632 RVA: 0x000345AD File Offset: 0x000327AD
		public unsafe static bool USE_WHEEL
		{
			get
			{
				bool result;
				IL2CPP.il2cpp_field_static_get_value(LandVehicle.NativeFieldInfoPtr_USE_WHEEL, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LandVehicle.NativeFieldInfoPtr_USE_WHEEL, (void*)(&value));
			}
		}

		// Token: 0x17002135 RID: 8501
		// (get) Token: 0x06006FD9 RID: 28633 RVA: 0x001F2C8C File Offset: 0x001F0E8C
		// (set) Token: 0x06006FDA RID: 28634 RVA: 0x000345BB File Offset: 0x000327BB
		public unsafe static float SPEED_DISPLAY_MULTIPLIER
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(LandVehicle.NativeFieldInfoPtr_SPEED_DISPLAY_MULTIPLIER, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LandVehicle.NativeFieldInfoPtr_SPEED_DISPLAY_MULTIPLIER, (void*)(&value));
			}
		}

		// Token: 0x17002136 RID: 8502
		// (get) Token: 0x06006FDB RID: 28635 RVA: 0x001F2CA8 File Offset: 0x001F0EA8
		// (set) Token: 0x06006FDC RID: 28636 RVA: 0x000345C9 File Offset: 0x000327C9
		public unsafe bool DEBUG
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_DEBUG);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_DEBUG)) = value;
			}
		}

		// Token: 0x17002137 RID: 8503
		// (get) Token: 0x06006FDD RID: 28637 RVA: 0x001F2CD0 File Offset: 0x001F0ED0
		// (set) Token: 0x06006FDE RID: 28638 RVA: 0x000345E4 File Offset: 0x000327E4
		public unsafe string vehicleName
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_vehicleName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_vehicleName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17002138 RID: 8504
		// (get) Token: 0x06006FDF RID: 28639 RVA: 0x001F2CF8 File Offset: 0x001F0EF8
		// (set) Token: 0x06006FE0 RID: 28640 RVA: 0x00034603 File Offset: 0x00032803
		public unsafe string vehicleCode
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_vehicleCode);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_vehicleCode), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17002139 RID: 8505
		// (get) Token: 0x06006FE1 RID: 28641 RVA: 0x001F2D20 File Offset: 0x001F0F20
		// (set) Token: 0x06006FE2 RID: 28642 RVA: 0x00034622 File Offset: 0x00032822
		public unsafe float vehiclePrice
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_vehiclePrice);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_vehiclePrice)) = value;
			}
		}

		// Token: 0x1700213A RID: 8506
		// (get) Token: 0x06006FE3 RID: 28643 RVA: 0x001F2D48 File Offset: 0x001F0F48
		// (set) Token: 0x06006FE4 RID: 28644 RVA: 0x0003463D File Offset: 0x0003283D
		public unsafe bool _IsPlayerOwned_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr__IsPlayerOwned_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr__IsPlayerOwned_k__BackingField)) = value;
			}
		}

		// Token: 0x1700213B RID: 8507
		// (get) Token: 0x06006FE5 RID: 28645 RVA: 0x001F2D70 File Offset: 0x001F0F70
		// (set) Token: 0x06006FE6 RID: 28646 RVA: 0x00034658 File Offset: 0x00032858
		public unsafe bool _IsVisible_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr__IsVisible_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr__IsVisible_k__BackingField)) = value;
			}
		}

		// Token: 0x1700213C RID: 8508
		// (get) Token: 0x06006FE7 RID: 28647 RVA: 0x001F2D98 File Offset: 0x001F0F98
		// (set) Token: 0x06006FE8 RID: 28648 RVA: 0x00034673 File Offset: 0x00032873
		public unsafe bool UseHumanoidCollider
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_UseHumanoidCollider);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_UseHumanoidCollider)) = value;
			}
		}

		// Token: 0x1700213D RID: 8509
		// (get) Token: 0x06006FE9 RID: 28649 RVA: 0x001F2DC0 File Offset: 0x001F0FC0
		// (set) Token: 0x06006FEA RID: 28650 RVA: 0x0003468E File Offset: 0x0003288E
		public unsafe Il2CppSystem.Guid _GUID_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr__GUID_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr__GUID_k__BackingField)) = value;
			}
		}

		// Token: 0x1700213E RID: 8510
		// (get) Token: 0x06006FEB RID: 28651 RVA: 0x001F2DE8 File Offset: 0x001F0FE8
		// (set) Token: 0x06006FEC RID: 28652 RVA: 0x000346A9 File Offset: 0x000328A9
		public unsafe bool SpawnAsPlayerOwned
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_SpawnAsPlayerOwned);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_SpawnAsPlayerOwned)) = value;
			}
		}

		// Token: 0x1700213F RID: 8511
		// (get) Token: 0x06006FED RID: 28653 RVA: 0x001F2E10 File Offset: 0x001F1010
		// (set) Token: 0x06006FEE RID: 28654 RVA: 0x000346C4 File Offset: 0x000328C4
		public unsafe float _DistanceToLocalCamera_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr__DistanceToLocalCamera_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr__DistanceToLocalCamera_k__BackingField)) = value;
			}
		}

		// Token: 0x17002140 RID: 8512
		// (get) Token: 0x06006FEF RID: 28655 RVA: 0x001F2E38 File Offset: 0x001F1038
		// (set) Token: 0x06006FF0 RID: 28656 RVA: 0x000346DF File Offset: 0x000328DF
		public unsafe GameObject vehicleModel
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_vehicleModel);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_vehicleModel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002141 RID: 8513
		// (get) Token: 0x06006FF1 RID: 28657 RVA: 0x001F2E68 File Offset: 0x001F1068
		// (set) Token: 0x06006FF2 RID: 28658 RVA: 0x000346FE File Offset: 0x000328FE
		public unsafe Il2CppReferenceArray<WheelCollider> driveWheels
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_driveWheels);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<WheelCollider>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_driveWheels), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002142 RID: 8514
		// (get) Token: 0x06006FF3 RID: 28659 RVA: 0x001F2E98 File Offset: 0x001F1098
		// (set) Token: 0x06006FF4 RID: 28660 RVA: 0x0003471D File Offset: 0x0003291D
		public unsafe Il2CppReferenceArray<WheelCollider> steerWheels
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_steerWheels);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<WheelCollider>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_steerWheels), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002143 RID: 8515
		// (get) Token: 0x06006FF5 RID: 28661 RVA: 0x001F2EC8 File Offset: 0x001F10C8
		// (set) Token: 0x06006FF6 RID: 28662 RVA: 0x0003473C File Offset: 0x0003293C
		public unsafe Il2CppReferenceArray<WheelCollider> handbrakeWheels
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_handbrakeWheels);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<WheelCollider>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_handbrakeWheels), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002144 RID: 8516
		// (get) Token: 0x06006FF7 RID: 28663 RVA: 0x001F2EF8 File Offset: 0x001F10F8
		// (set) Token: 0x06006FF8 RID: 28664 RVA: 0x0003475B File Offset: 0x0003295B
		public unsafe List<Wheel> wheels
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_wheels);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Wheel>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_wheels), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002145 RID: 8517
		// (get) Token: 0x06006FF9 RID: 28665 RVA: 0x001F2F28 File Offset: 0x001F1128
		// (set) Token: 0x06006FFA RID: 28666 RVA: 0x0003477A File Offset: 0x0003297A
		public unsafe InteractableObject intObj
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_intObj);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<InteractableObject>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_intObj), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002146 RID: 8518
		// (get) Token: 0x06006FFB RID: 28667 RVA: 0x001F2F58 File Offset: 0x001F1158
		// (set) Token: 0x06006FFC RID: 28668 RVA: 0x00034799 File Offset: 0x00032999
		public unsafe List<Transform> exitPoints
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_exitPoints);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Transform>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_exitPoints), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002147 RID: 8519
		// (get) Token: 0x06006FFD RID: 28669 RVA: 0x001F2F88 File Offset: 0x001F1188
		// (set) Token: 0x06006FFE RID: 28670 RVA: 0x000347B8 File Offset: 0x000329B8
		public unsafe Rigidbody rb
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_rb);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Rigidbody>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_rb), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002148 RID: 8520
		// (get) Token: 0x06006FFF RID: 28671 RVA: 0x001F2FB8 File Offset: 0x001F11B8
		// (set) Token: 0x06007000 RID: 28672 RVA: 0x000347D7 File Offset: 0x000329D7
		public unsafe Il2CppReferenceArray<VehicleSeat> Seats
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_Seats);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<VehicleSeat>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_Seats), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002149 RID: 8521
		// (get) Token: 0x06007001 RID: 28673 RVA: 0x001F2FE8 File Offset: 0x001F11E8
		// (set) Token: 0x06007002 RID: 28674 RVA: 0x000347F6 File Offset: 0x000329F6
		public unsafe BoxCollider boundingBox
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_boundingBox);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BoxCollider>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_boundingBox), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700214A RID: 8522
		// (get) Token: 0x06007003 RID: 28675 RVA: 0x001F3018 File Offset: 0x001F1218
		// (set) Token: 0x06007004 RID: 28676 RVA: 0x00034815 File Offset: 0x00032A15
		public unsafe VehicleAgent Agent
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_Agent);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<VehicleAgent>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_Agent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700214B RID: 8523
		// (get) Token: 0x06007005 RID: 28677 RVA: 0x001F3048 File Offset: 0x001F1248
		// (set) Token: 0x06007006 RID: 28678 RVA: 0x00034834 File Offset: 0x00032A34
		public unsafe SmoothedVelocityCalculator VelocityCalculator
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_VelocityCalculator);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SmoothedVelocityCalculator>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_VelocityCalculator), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700214C RID: 8524
		// (get) Token: 0x06007007 RID: 28679 RVA: 0x001F3078 File Offset: 0x001F1278
		// (set) Token: 0x06007008 RID: 28680 RVA: 0x00034853 File Offset: 0x00032A53
		public unsafe StorageDoorAnimation Trunk
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_Trunk);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StorageDoorAnimation>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_Trunk), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700214D RID: 8525
		// (get) Token: 0x06007009 RID: 28681 RVA: 0x001F30A8 File Offset: 0x001F12A8
		// (set) Token: 0x0600700A RID: 28682 RVA: 0x00034872 File Offset: 0x00032A72
		public unsafe NavMeshObstacle NavMeshObstacle
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_NavMeshObstacle);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NavMeshObstacle>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_NavMeshObstacle), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700214E RID: 8526
		// (get) Token: 0x0600700B RID: 28683 RVA: 0x001F30D8 File Offset: 0x001F12D8
		// (set) Token: 0x0600700C RID: 28684 RVA: 0x00034891 File Offset: 0x00032A91
		public unsafe NavmeshCut NavmeshCut
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_NavmeshCut);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NavmeshCut>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_NavmeshCut), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700214F RID: 8527
		// (get) Token: 0x0600700D RID: 28685 RVA: 0x001F3108 File Offset: 0x001F1308
		// (set) Token: 0x0600700E RID: 28686 RVA: 0x000348B0 File Offset: 0x00032AB0
		public unsafe VehicleHumanoidCollider HumanoidColliderContainer
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_HumanoidColliderContainer);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<VehicleHumanoidCollider>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_HumanoidColliderContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002150 RID: 8528
		// (get) Token: 0x0600700F RID: 28687 RVA: 0x001F3138 File Offset: 0x001F1338
		// (set) Token: 0x06007010 RID: 28688 RVA: 0x000348CF File Offset: 0x00032ACF
		public unsafe POI POI
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_POI);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<POI>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_POI), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002151 RID: 8529
		// (get) Token: 0x06007011 RID: 28689 RVA: 0x001F3168 File Offset: 0x001F1368
		// (set) Token: 0x06007012 RID: 28690 RVA: 0x000348EE File Offset: 0x00032AEE
		public unsafe Transform centerOfMass
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_centerOfMass);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_centerOfMass), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002152 RID: 8530
		// (get) Token: 0x06007013 RID: 28691 RVA: 0x001F3198 File Offset: 0x001F1398
		// (set) Token: 0x06007014 RID: 28692 RVA: 0x0003490D File Offset: 0x00032B0D
		public unsafe Transform cameraOrigin
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_cameraOrigin);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_cameraOrigin), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002153 RID: 8531
		// (get) Token: 0x06007015 RID: 28693 RVA: 0x001F31C8 File Offset: 0x001F13C8
		// (set) Token: 0x06007016 RID: 28694 RVA: 0x0003492C File Offset: 0x00032B2C
		public unsafe VehicleLights lights
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_lights);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<VehicleLights>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_lights), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002154 RID: 8532
		// (get) Token: 0x06007017 RID: 28695 RVA: 0x001F31F8 File Offset: 0x001F13F8
		// (set) Token: 0x06007018 RID: 28696 RVA: 0x0003494B File Offset: 0x00032B4B
		public unsafe float maxSteeringAngle
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_maxSteeringAngle);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_maxSteeringAngle)) = value;
			}
		}

		// Token: 0x17002155 RID: 8533
		// (get) Token: 0x06007019 RID: 28697 RVA: 0x001F3220 File Offset: 0x001F1420
		// (set) Token: 0x0600701A RID: 28698 RVA: 0x00034966 File Offset: 0x00032B66
		public unsafe float steerRate
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_steerRate);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_steerRate)) = value;
			}
		}

		// Token: 0x17002156 RID: 8534
		// (get) Token: 0x0600701B RID: 28699 RVA: 0x001F3248 File Offset: 0x001F1448
		// (set) Token: 0x0600701C RID: 28700 RVA: 0x00034981 File Offset: 0x00032B81
		public unsafe bool flipSteer
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_flipSteer);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_flipSteer)) = value;
			}
		}

		// Token: 0x17002157 RID: 8535
		// (get) Token: 0x0600701D RID: 28701 RVA: 0x001F3270 File Offset: 0x001F1470
		// (set) Token: 0x0600701E RID: 28702 RVA: 0x0003499C File Offset: 0x00032B9C
		public unsafe bool _MaxSteerAngleOverridden_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr__MaxSteerAngleOverridden_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr__MaxSteerAngleOverridden_k__BackingField)) = value;
			}
		}

		// Token: 0x17002158 RID: 8536
		// (get) Token: 0x0600701F RID: 28703 RVA: 0x001F3298 File Offset: 0x001F1498
		// (set) Token: 0x06007020 RID: 28704 RVA: 0x000349B7 File Offset: 0x00032BB7
		public unsafe float _OverriddenMaxSteerAngle_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr__OverriddenMaxSteerAngle_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr__OverriddenMaxSteerAngle_k__BackingField)) = value;
			}
		}

		// Token: 0x17002159 RID: 8537
		// (get) Token: 0x06007021 RID: 28705 RVA: 0x001F32C0 File Offset: 0x001F14C0
		// (set) Token: 0x06007022 RID: 28706 RVA: 0x000349D2 File Offset: 0x00032BD2
		public unsafe AnimationCurve motorTorque
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_motorTorque);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnimationCurve>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_motorTorque), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700215A RID: 8538
		// (get) Token: 0x06007023 RID: 28707 RVA: 0x001F32F0 File Offset: 0x001F14F0
		// (set) Token: 0x06007024 RID: 28708 RVA: 0x000349F1 File Offset: 0x00032BF1
		public unsafe float TopSpeed
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_TopSpeed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_TopSpeed)) = value;
			}
		}

		// Token: 0x1700215B RID: 8539
		// (get) Token: 0x06007025 RID: 28709 RVA: 0x001F3318 File Offset: 0x001F1518
		// (set) Token: 0x06007026 RID: 28710 RVA: 0x00034A0C File Offset: 0x00032C0C
		public unsafe float diffGearing
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_diffGearing);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_diffGearing)) = value;
			}
		}

		// Token: 0x1700215C RID: 8540
		// (get) Token: 0x06007027 RID: 28711 RVA: 0x001F3340 File Offset: 0x001F1540
		// (set) Token: 0x06007028 RID: 28712 RVA: 0x00034A27 File Offset: 0x00032C27
		public unsafe float handBrakeForce
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_handBrakeForce);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_handBrakeForce)) = value;
			}
		}

		// Token: 0x1700215D RID: 8541
		// (get) Token: 0x06007029 RID: 28713 RVA: 0x001F3368 File Offset: 0x001F1568
		// (set) Token: 0x0600702A RID: 28714 RVA: 0x00034A42 File Offset: 0x00032C42
		public unsafe AnimationCurve brakeForce
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_brakeForce);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnimationCurve>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_brakeForce), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700215E RID: 8542
		// (get) Token: 0x0600702B RID: 28715 RVA: 0x001F3398 File Offset: 0x001F1598
		// (set) Token: 0x0600702C RID: 28716 RVA: 0x00034A61 File Offset: 0x00032C61
		public unsafe float downforce
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_downforce);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_downforce)) = value;
			}
		}

		// Token: 0x1700215F RID: 8543
		// (get) Token: 0x0600702D RID: 28717 RVA: 0x001F33C0 File Offset: 0x001F15C0
		// (set) Token: 0x0600702E RID: 28718 RVA: 0x00034A7C File Offset: 0x00032C7C
		public unsafe float reverseMultiplier
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_reverseMultiplier);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_reverseMultiplier)) = value;
			}
		}

		// Token: 0x17002160 RID: 8544
		// (get) Token: 0x0600702F RID: 28719 RVA: 0x001F33E8 File Offset: 0x001F15E8
		// (set) Token: 0x06007030 RID: 28720 RVA: 0x00034A97 File Offset: 0x00032C97
		public unsafe Il2CppReferenceArray<LandVehicle.BodyMesh> BodyMeshes
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_BodyMeshes);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<LandVehicle.BodyMesh>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_BodyMeshes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002161 RID: 8545
		// (get) Token: 0x06007031 RID: 28721 RVA: 0x001F3418 File Offset: 0x001F1618
		// (set) Token: 0x06007032 RID: 28722 RVA: 0x00034AB6 File Offset: 0x00032CB6
		public unsafe EVehicleColor DefaultColor
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_DefaultColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_DefaultColor)) = value;
			}
		}

		// Token: 0x17002162 RID: 8546
		// (get) Token: 0x06007033 RID: 28723 RVA: 0x001F3440 File Offset: 0x001F1640
		// (set) Token: 0x06007034 RID: 28724 RVA: 0x00034AD1 File Offset: 0x00032CD1
		public unsafe EVehicleColor _OwnedColor_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr__OwnedColor_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr__OwnedColor_k__BackingField)) = value;
			}
		}

		// Token: 0x17002163 RID: 8547
		// (get) Token: 0x06007035 RID: 28725 RVA: 0x001F3468 File Offset: 0x001F1668
		// (set) Token: 0x06007036 RID: 28726 RVA: 0x00034AEC File Offset: 0x00032CEC
		public unsafe EVehicleColor DisplayedColor
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_DisplayedColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_DisplayedColor)) = value;
			}
		}

		// Token: 0x17002164 RID: 8548
		// (get) Token: 0x06007037 RID: 28727 RVA: 0x001F3490 File Offset: 0x001F1690
		// (set) Token: 0x06007038 RID: 28728 RVA: 0x00034B07 File Offset: 0x00032D07
		public unsafe List<GameObject> outlineRenderers
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_outlineRenderers);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<GameObject>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_outlineRenderers), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002165 RID: 8549
		// (get) Token: 0x06007039 RID: 28729 RVA: 0x001F34C0 File Offset: 0x001F16C0
		// (set) Token: 0x0600703A RID: 28730 RVA: 0x00034B26 File Offset: 0x00032D26
		public unsafe Outlinable outlineEffect
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_outlineEffect);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Outlinable>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_outlineEffect), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002166 RID: 8550
		// (get) Token: 0x0600703B RID: 28731 RVA: 0x001F34F0 File Offset: 0x001F16F0
		// (set) Token: 0x0600703C RID: 28732 RVA: 0x00034B45 File Offset: 0x00032D45
		public unsafe bool overrideControls
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_overrideControls);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_overrideControls)) = value;
			}
		}

		// Token: 0x17002167 RID: 8551
		// (get) Token: 0x0600703D RID: 28733 RVA: 0x001F3518 File Offset: 0x001F1718
		// (set) Token: 0x0600703E RID: 28734 RVA: 0x00034B60 File Offset: 0x00032D60
		public unsafe float throttleOverride
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_throttleOverride);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_throttleOverride)) = value;
			}
		}

		// Token: 0x17002168 RID: 8552
		// (get) Token: 0x0600703F RID: 28735 RVA: 0x001F3540 File Offset: 0x001F1740
		// (set) Token: 0x06007040 RID: 28736 RVA: 0x00034B7B File Offset: 0x00032D7B
		public unsafe float steerOverride
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_steerOverride);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_steerOverride)) = value;
			}
		}

		// Token: 0x17002169 RID: 8553
		// (get) Token: 0x06007041 RID: 28737 RVA: 0x001F3568 File Offset: 0x001F1768
		// (set) Token: 0x06007042 RID: 28738 RVA: 0x00034B96 File Offset: 0x00032D96
		public unsafe StorageEntity Storage
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_Storage);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StorageEntity>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_Storage), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700216A RID: 8554
		// (get) Token: 0x06007043 RID: 28739 RVA: 0x001F3598 File Offset: 0x001F1798
		// (set) Token: 0x06007044 RID: 28740 RVA: 0x00034BB5 File Offset: 0x00032DB5
		public unsafe VehicleSeat localPlayerSeat
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_localPlayerSeat);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<VehicleSeat>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_localPlayerSeat), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700216B RID: 8555
		// (get) Token: 0x06007045 RID: 28741 RVA: 0x001F35C8 File Offset: 0x001F17C8
		// (set) Token: 0x06007046 RID: 28742 RVA: 0x00034BD4 File Offset: 0x00032DD4
		public unsafe bool _localPlayerIsDriver_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr__localPlayerIsDriver_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr__localPlayerIsDriver_k__BackingField)) = value;
			}
		}

		// Token: 0x1700216C RID: 8556
		// (get) Token: 0x06007047 RID: 28743 RVA: 0x001F35F0 File Offset: 0x001F17F0
		// (set) Token: 0x06007048 RID: 28744 RVA: 0x00034BEF File Offset: 0x00032DEF
		public unsafe bool _localPlayerIsInVehicle_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr__localPlayerIsInVehicle_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr__localPlayerIsInVehicle_k__BackingField)) = value;
			}
		}

		// Token: 0x1700216D RID: 8557
		// (get) Token: 0x06007049 RID: 28745 RVA: 0x001F3618 File Offset: 0x001F1818
		// (set) Token: 0x0600704A RID: 28746 RVA: 0x00034C0A File Offset: 0x00032E0A
		public unsafe bool _isOccupied_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr__isOccupied_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr__isOccupied_k__BackingField)) = value;
			}
		}

		// Token: 0x1700216E RID: 8558
		// (get) Token: 0x0600704B RID: 28747 RVA: 0x001F3640 File Offset: 0x001F1840
		// (set) Token: 0x0600704C RID: 28748 RVA: 0x00034C25 File Offset: 0x00032E25
		public unsafe Il2CppReferenceArray<NPC> _OccupantNPCs_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr__OccupantNPCs_k__BackingField);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<NPC>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr__OccupantNPCs_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700216F RID: 8559
		// (get) Token: 0x0600704D RID: 28749 RVA: 0x001F3670 File Offset: 0x001F1870
		// (set) Token: 0x0600704E RID: 28750 RVA: 0x00034C44 File Offset: 0x00032E44
		public unsafe float _speed_Kmh_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr__speed_Kmh_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr__speed_Kmh_k__BackingField)) = value;
			}
		}

		// Token: 0x17002170 RID: 8560
		// (get) Token: 0x0600704F RID: 28751 RVA: 0x001F3698 File Offset: 0x001F1898
		// (set) Token: 0x06007050 RID: 28752 RVA: 0x00034C5F File Offset: 0x00032E5F
		public unsafe List<float> previousSpeeds
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_previousSpeeds);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<float>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_previousSpeeds), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002171 RID: 8561
		// (get) Token: 0x06007051 RID: 28753 RVA: 0x001F36C8 File Offset: 0x001F18C8
		// (set) Token: 0x06007052 RID: 28754 RVA: 0x00034C7E File Offset: 0x00032E7E
		public unsafe int previousSpeedsSampleSize
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_previousSpeedsSampleSize);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_previousSpeedsSampleSize)) = value;
			}
		}

		// Token: 0x17002172 RID: 8562
		// (get) Token: 0x06007053 RID: 28755 RVA: 0x001F36F0 File Offset: 0x001F18F0
		// (set) Token: 0x06007054 RID: 28756 RVA: 0x00034C99 File Offset: 0x00032E99
		public unsafe float _currentThrottle_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr__currentThrottle_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr__currentThrottle_k__BackingField)) = value;
			}
		}

		// Token: 0x17002173 RID: 8563
		// (get) Token: 0x06007055 RID: 28757 RVA: 0x001F3718 File Offset: 0x001F1918
		// (set) Token: 0x06007056 RID: 28758 RVA: 0x00034CB4 File Offset: 0x00032EB4
		public unsafe float currentSteerAngle
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_currentSteerAngle);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_currentSteerAngle)) = value;
			}
		}

		// Token: 0x17002174 RID: 8564
		// (get) Token: 0x06007057 RID: 28759 RVA: 0x001F3740 File Offset: 0x001F1940
		// (set) Token: 0x06007058 RID: 28760 RVA: 0x00034CCF File Offset: 0x00032ECF
		public unsafe float lastFrameSteerAngle
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_lastFrameSteerAngle);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_lastFrameSteerAngle)) = value;
			}
		}

		// Token: 0x17002175 RID: 8565
		// (get) Token: 0x06007059 RID: 28761 RVA: 0x001F3768 File Offset: 0x001F1968
		// (set) Token: 0x0600705A RID: 28762 RVA: 0x00034CEA File Offset: 0x00032EEA
		public unsafe float lastReplicatedSteerAngle
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_lastReplicatedSteerAngle);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_lastReplicatedSteerAngle)) = value;
			}
		}

		// Token: 0x17002176 RID: 8566
		// (get) Token: 0x0600705B RID: 28763 RVA: 0x001F3790 File Offset: 0x001F1990
		// (set) Token: 0x0600705C RID: 28764 RVA: 0x00034D05 File Offset: 0x00032F05
		public unsafe bool justExitedVehicle
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_justExitedVehicle);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_justExitedVehicle)) = value;
			}
		}

		// Token: 0x17002177 RID: 8567
		// (get) Token: 0x0600705D RID: 28765 RVA: 0x001F37B8 File Offset: 0x001F19B8
		// (set) Token: 0x0600705E RID: 28766 RVA: 0x00034D20 File Offset: 0x00032F20
		public unsafe bool _brakesApplied_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr__brakesApplied_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr__brakesApplied_k__BackingField)) = value;
			}
		}

		// Token: 0x17002178 RID: 8568
		// (get) Token: 0x0600705F RID: 28767 RVA: 0x001F37E0 File Offset: 0x001F19E0
		// (set) Token: 0x06007060 RID: 28768 RVA: 0x00034D3B File Offset: 0x00032F3B
		public unsafe bool _isReversing_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr__isReversing_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr__isReversing_k__BackingField)) = value;
			}
		}

		// Token: 0x17002179 RID: 8569
		// (get) Token: 0x06007061 RID: 28769 RVA: 0x001F3808 File Offset: 0x001F1A08
		// (set) Token: 0x06007062 RID: 28770 RVA: 0x00034D56 File Offset: 0x00032F56
		public unsafe bool _isStatic_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr__isStatic_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr__isStatic_k__BackingField)) = value;
			}
		}

		// Token: 0x1700217A RID: 8570
		// (get) Token: 0x06007063 RID: 28771 RVA: 0x001F3830 File Offset: 0x001F1A30
		// (set) Token: 0x06007064 RID: 28772 RVA: 0x00034D71 File Offset: 0x00032F71
		public unsafe bool _handbrakeApplied_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr__handbrakeApplied_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr__handbrakeApplied_k__BackingField)) = value;
			}
		}

		// Token: 0x1700217B RID: 8571
		// (get) Token: 0x06007065 RID: 28773 RVA: 0x001F3858 File Offset: 0x001F1A58
		// (set) Token: 0x06007066 RID: 28774 RVA: 0x00034D8C File Offset: 0x00032F8C
		public unsafe Vector3 lastFramePosition
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_lastFramePosition);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_lastFramePosition)) = value;
			}
		}

		// Token: 0x1700217C RID: 8572
		// (get) Token: 0x06007067 RID: 28775 RVA: 0x001F3880 File Offset: 0x001F1A80
		// (set) Token: 0x06007068 RID: 28776 RVA: 0x00034DA7 File Offset: 0x00032FA7
		public unsafe Transform closestExitPoint
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_closestExitPoint);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_closestExitPoint), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700217D RID: 8573
		// (get) Token: 0x06007069 RID: 28777 RVA: 0x001F38B0 File Offset: 0x001F1AB0
		// (set) Token: 0x0600706A RID: 28778 RVA: 0x00034DC6 File Offset: 0x00032FC6
		public unsafe ParkData CurrentParkData
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_CurrentParkData);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ParkData>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_CurrentParkData), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700217E RID: 8574
		// (get) Token: 0x0600706B RID: 28779 RVA: 0x001F38E0 File Offset: 0x001F1AE0
		// (set) Token: 0x0600706C RID: 28780 RVA: 0x00034DE5 File Offset: 0x00032FE5
		public unsafe ParkingLot _CurrentParkingLot_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr__CurrentParkingLot_k__BackingField);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ParkingLot>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr__CurrentParkingLot_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700217F RID: 8575
		// (get) Token: 0x0600706D RID: 28781 RVA: 0x001F3910 File Offset: 0x001F1B10
		// (set) Token: 0x0600706E RID: 28782 RVA: 0x00034E04 File Offset: 0x00033004
		public unsafe ParkingSpot _CurrentParkingSpot_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr__CurrentParkingSpot_k__BackingField);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ParkingSpot>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr__CurrentParkingSpot_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002180 RID: 8576
		// (get) Token: 0x0600706F RID: 28783 RVA: 0x001F3940 File Offset: 0x001F1B40
		// (set) Token: 0x06007070 RID: 28784 RVA: 0x00034E23 File Offset: 0x00033023
		public unsafe VehicleLoader loader
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_loader);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<VehicleLoader>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_loader), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002181 RID: 8577
		// (get) Token: 0x06007071 RID: 28785 RVA: 0x001F3970 File Offset: 0x001F1B70
		// (set) Token: 0x06007072 RID: 28786 RVA: 0x00034E42 File Offset: 0x00033042
		public unsafe List<string> _LocalExtraFiles_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr__LocalExtraFiles_k__BackingField);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr__LocalExtraFiles_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002182 RID: 8578
		// (get) Token: 0x06007073 RID: 28787 RVA: 0x001F39A0 File Offset: 0x001F1BA0
		// (set) Token: 0x06007074 RID: 28788 RVA: 0x00034E61 File Offset: 0x00033061
		public unsafe List<string> _LocalExtraFolders_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr__LocalExtraFolders_k__BackingField);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr__LocalExtraFolders_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002183 RID: 8579
		// (get) Token: 0x06007075 RID: 28789 RVA: 0x001F39D0 File Offset: 0x001F1BD0
		// (set) Token: 0x06007076 RID: 28790 RVA: 0x00034E80 File Offset: 0x00033080
		public unsafe bool _HasChanged_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr__HasChanged_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr__HasChanged_k__BackingField)) = value;
			}
		}

		// Token: 0x17002184 RID: 8580
		// (get) Token: 0x06007077 RID: 28791 RVA: 0x001F39F8 File Offset: 0x001F1BF8
		// (set) Token: 0x06007078 RID: 28792 RVA: 0x00034E9B File Offset: 0x0003309B
		public unsafe LandVehicle.VehiclePlayerEvent onPlayerEnterVehicle
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_onPlayerEnterVehicle);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LandVehicle.VehiclePlayerEvent>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_onPlayerEnterVehicle), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002185 RID: 8581
		// (get) Token: 0x06007079 RID: 28793 RVA: 0x001F3A28 File Offset: 0x001F1C28
		// (set) Token: 0x0600707A RID: 28794 RVA: 0x00034EBA File Offset: 0x000330BA
		public unsafe LandVehicle.VehiclePlayerEvent onPlayerExitVehicle
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_onPlayerExitVehicle);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LandVehicle.VehiclePlayerEvent>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_onPlayerExitVehicle), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002186 RID: 8582
		// (get) Token: 0x0600707B RID: 28795 RVA: 0x001F3A58 File Offset: 0x001F1C58
		// (set) Token: 0x0600707C RID: 28796 RVA: 0x00034ED9 File Offset: 0x000330D9
		public unsafe UnityEvent onVehicleStart
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_onVehicleStart);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_onVehicleStart), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002187 RID: 8583
		// (get) Token: 0x0600707D RID: 28797 RVA: 0x001F3A88 File Offset: 0x001F1C88
		// (set) Token: 0x0600707E RID: 28798 RVA: 0x00034EF8 File Offset: 0x000330F8
		public unsafe UnityEvent onVehicleStop
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_onVehicleStop);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_onVehicleStop), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002188 RID: 8584
		// (get) Token: 0x0600707F RID: 28799 RVA: 0x001F3AB8 File Offset: 0x001F1CB8
		// (set) Token: 0x06007080 RID: 28800 RVA: 0x00034F17 File Offset: 0x00033117
		public unsafe UnityEvent onHandbrakeApplied
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_onHandbrakeApplied);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_onHandbrakeApplied), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002189 RID: 8585
		// (get) Token: 0x06007081 RID: 28801 RVA: 0x001F3AE8 File Offset: 0x001F1CE8
		// (set) Token: 0x06007082 RID: 28802 RVA: 0x00034F36 File Offset: 0x00033136
		public unsafe UnityEvent<Collision> onCollision
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_onCollision);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent<Collision>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_onCollision), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700218A RID: 8586
		// (get) Token: 0x06007083 RID: 28803 RVA: 0x001F3B18 File Offset: 0x001F1D18
		// (set) Token: 0x06007084 RID: 28804 RVA: 0x00034F55 File Offset: 0x00033155
		public unsafe SyncVar<float> syncVar___currentSteerAngle
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_syncVar___currentSteerAngle);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SyncVar<float>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_syncVar___currentSteerAngle), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700218B RID: 8587
		// (get) Token: 0x06007085 RID: 28805 RVA: 0x001F3B48 File Offset: 0x001F1D48
		// (set) Token: 0x06007086 RID: 28806 RVA: 0x00034F74 File Offset: 0x00033174
		public unsafe SyncVar<bool> syncVar____brakesApplied_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_syncVar____brakesApplied_k__BackingField);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SyncVar<bool>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_syncVar____brakesApplied_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700218C RID: 8588
		// (get) Token: 0x06007087 RID: 28807 RVA: 0x001F3B78 File Offset: 0x001F1D78
		// (set) Token: 0x06007088 RID: 28808 RVA: 0x00034F93 File Offset: 0x00033193
		public unsafe SyncVar<bool> syncVar____isReversing_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_syncVar____isReversing_k__BackingField);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SyncVar<bool>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_syncVar____isReversing_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700218D RID: 8589
		// (get) Token: 0x06007089 RID: 28809 RVA: 0x001F3BA8 File Offset: 0x001F1DA8
		// (set) Token: 0x0600708A RID: 28810 RVA: 0x00034FB2 File Offset: 0x000331B2
		public unsafe bool field_Private_Boolean_0
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_field_Private_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_field_Private_Boolean_0)) = value;
			}
		}

		// Token: 0x1700218E RID: 8590
		// (get) Token: 0x0600708B RID: 28811 RVA: 0x001F3BD0 File Offset: 0x001F1DD0
		// (set) Token: 0x0600708C RID: 28812 RVA: 0x00034FCD File Offset: 0x000331CD
		public unsafe bool field_Private_Boolean_1
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_field_Private_Boolean_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.NativeFieldInfoPtr_field_Private_Boolean_1)) = value;
			}
		}

		// Token: 0x04004BEE RID: 19438
		private static readonly System.IntPtr NativeFieldInfoPtr_KINEMATIC_THRESHOLD_DISTANCE;

		// Token: 0x04004BEF RID: 19439
		private static readonly System.IntPtr NativeFieldInfoPtr_MAX_TURNOVER_SPEED;

		// Token: 0x04004BF0 RID: 19440
		private static readonly System.IntPtr NativeFieldInfoPtr_TURNOVER_FORCE;

		// Token: 0x04004BF1 RID: 19441
		private static readonly System.IntPtr NativeFieldInfoPtr_USE_WHEEL;

		// Token: 0x04004BF2 RID: 19442
		private static readonly System.IntPtr NativeFieldInfoPtr_SPEED_DISPLAY_MULTIPLIER;

		// Token: 0x04004BF3 RID: 19443
		private static readonly System.IntPtr NativeFieldInfoPtr_DEBUG;

		// Token: 0x04004BF4 RID: 19444
		private static readonly System.IntPtr NativeFieldInfoPtr_vehicleName;

		// Token: 0x04004BF5 RID: 19445
		private static readonly System.IntPtr NativeFieldInfoPtr_vehicleCode;

		// Token: 0x04004BF6 RID: 19446
		private static readonly System.IntPtr NativeFieldInfoPtr_vehiclePrice;

		// Token: 0x04004BF7 RID: 19447
		private static readonly System.IntPtr NativeFieldInfoPtr__IsPlayerOwned_k__BackingField;

		// Token: 0x04004BF8 RID: 19448
		private static readonly System.IntPtr NativeFieldInfoPtr__IsVisible_k__BackingField;

		// Token: 0x04004BF9 RID: 19449
		private static readonly System.IntPtr NativeFieldInfoPtr_UseHumanoidCollider;

		// Token: 0x04004BFA RID: 19450
		private static readonly System.IntPtr NativeFieldInfoPtr__GUID_k__BackingField;

		// Token: 0x04004BFB RID: 19451
		private static readonly System.IntPtr NativeFieldInfoPtr_SpawnAsPlayerOwned;

		// Token: 0x04004BFC RID: 19452
		private static readonly System.IntPtr NativeFieldInfoPtr__DistanceToLocalCamera_k__BackingField;

		// Token: 0x04004BFD RID: 19453
		private static readonly System.IntPtr NativeFieldInfoPtr_vehicleModel;

		// Token: 0x04004BFE RID: 19454
		private static readonly System.IntPtr NativeFieldInfoPtr_driveWheels;

		// Token: 0x04004BFF RID: 19455
		private static readonly System.IntPtr NativeFieldInfoPtr_steerWheels;

		// Token: 0x04004C00 RID: 19456
		private static readonly System.IntPtr NativeFieldInfoPtr_handbrakeWheels;

		// Token: 0x04004C01 RID: 19457
		private static readonly System.IntPtr NativeFieldInfoPtr_wheels;

		// Token: 0x04004C02 RID: 19458
		private static readonly System.IntPtr NativeFieldInfoPtr_intObj;

		// Token: 0x04004C03 RID: 19459
		private static readonly System.IntPtr NativeFieldInfoPtr_exitPoints;

		// Token: 0x04004C04 RID: 19460
		private static readonly System.IntPtr NativeFieldInfoPtr_rb;

		// Token: 0x04004C05 RID: 19461
		private static readonly System.IntPtr NativeFieldInfoPtr_Seats;

		// Token: 0x04004C06 RID: 19462
		private static readonly System.IntPtr NativeFieldInfoPtr_boundingBox;

		// Token: 0x04004C07 RID: 19463
		private static readonly System.IntPtr NativeFieldInfoPtr_Agent;

		// Token: 0x04004C08 RID: 19464
		private static readonly System.IntPtr NativeFieldInfoPtr_VelocityCalculator;

		// Token: 0x04004C09 RID: 19465
		private static readonly System.IntPtr NativeFieldInfoPtr_Trunk;

		// Token: 0x04004C0A RID: 19466
		private static readonly System.IntPtr NativeFieldInfoPtr_NavMeshObstacle;

		// Token: 0x04004C0B RID: 19467
		private static readonly System.IntPtr NativeFieldInfoPtr_NavmeshCut;

		// Token: 0x04004C0C RID: 19468
		private static readonly System.IntPtr NativeFieldInfoPtr_HumanoidColliderContainer;

		// Token: 0x04004C0D RID: 19469
		private static readonly System.IntPtr NativeFieldInfoPtr_POI;

		// Token: 0x04004C0E RID: 19470
		private static readonly System.IntPtr NativeFieldInfoPtr_centerOfMass;

		// Token: 0x04004C0F RID: 19471
		private static readonly System.IntPtr NativeFieldInfoPtr_cameraOrigin;

		// Token: 0x04004C10 RID: 19472
		private static readonly System.IntPtr NativeFieldInfoPtr_lights;

		// Token: 0x04004C11 RID: 19473
		private static readonly System.IntPtr NativeFieldInfoPtr_maxSteeringAngle;

		// Token: 0x04004C12 RID: 19474
		private static readonly System.IntPtr NativeFieldInfoPtr_steerRate;

		// Token: 0x04004C13 RID: 19475
		private static readonly System.IntPtr NativeFieldInfoPtr_flipSteer;

		// Token: 0x04004C14 RID: 19476
		private static readonly System.IntPtr NativeFieldInfoPtr__MaxSteerAngleOverridden_k__BackingField;

		// Token: 0x04004C15 RID: 19477
		private static readonly System.IntPtr NativeFieldInfoPtr__OverriddenMaxSteerAngle_k__BackingField;

		// Token: 0x04004C16 RID: 19478
		private static readonly System.IntPtr NativeFieldInfoPtr_motorTorque;

		// Token: 0x04004C17 RID: 19479
		private static readonly System.IntPtr NativeFieldInfoPtr_TopSpeed;

		// Token: 0x04004C18 RID: 19480
		private static readonly System.IntPtr NativeFieldInfoPtr_diffGearing;

		// Token: 0x04004C19 RID: 19481
		private static readonly System.IntPtr NativeFieldInfoPtr_handBrakeForce;

		// Token: 0x04004C1A RID: 19482
		private static readonly System.IntPtr NativeFieldInfoPtr_brakeForce;

		// Token: 0x04004C1B RID: 19483
		private static readonly System.IntPtr NativeFieldInfoPtr_downforce;

		// Token: 0x04004C1C RID: 19484
		private static readonly System.IntPtr NativeFieldInfoPtr_reverseMultiplier;

		// Token: 0x04004C1D RID: 19485
		private static readonly System.IntPtr NativeFieldInfoPtr_BodyMeshes;

		// Token: 0x04004C1E RID: 19486
		private static readonly System.IntPtr NativeFieldInfoPtr_DefaultColor;

		// Token: 0x04004C1F RID: 19487
		private static readonly System.IntPtr NativeFieldInfoPtr__OwnedColor_k__BackingField;

		// Token: 0x04004C20 RID: 19488
		private static readonly System.IntPtr NativeFieldInfoPtr_DisplayedColor;

		// Token: 0x04004C21 RID: 19489
		private static readonly System.IntPtr NativeFieldInfoPtr_outlineRenderers;

		// Token: 0x04004C22 RID: 19490
		private static readonly System.IntPtr NativeFieldInfoPtr_outlineEffect;

		// Token: 0x04004C23 RID: 19491
		private static readonly System.IntPtr NativeFieldInfoPtr_overrideControls;

		// Token: 0x04004C24 RID: 19492
		private static readonly System.IntPtr NativeFieldInfoPtr_throttleOverride;

		// Token: 0x04004C25 RID: 19493
		private static readonly System.IntPtr NativeFieldInfoPtr_steerOverride;

		// Token: 0x04004C26 RID: 19494
		private static readonly System.IntPtr NativeFieldInfoPtr_Storage;

		// Token: 0x04004C27 RID: 19495
		private static readonly System.IntPtr NativeFieldInfoPtr_localPlayerSeat;

		// Token: 0x04004C28 RID: 19496
		private static readonly System.IntPtr NativeFieldInfoPtr__localPlayerIsDriver_k__BackingField;

		// Token: 0x04004C29 RID: 19497
		private static readonly System.IntPtr NativeFieldInfoPtr__localPlayerIsInVehicle_k__BackingField;

		// Token: 0x04004C2A RID: 19498
		private static readonly System.IntPtr NativeFieldInfoPtr__isOccupied_k__BackingField;

		// Token: 0x04004C2B RID: 19499
		private static readonly System.IntPtr NativeFieldInfoPtr__OccupantNPCs_k__BackingField;

		// Token: 0x04004C2C RID: 19500
		private static readonly System.IntPtr NativeFieldInfoPtr__speed_Kmh_k__BackingField;

		// Token: 0x04004C2D RID: 19501
		private static readonly System.IntPtr NativeFieldInfoPtr_previousSpeeds;

		// Token: 0x04004C2E RID: 19502
		private static readonly System.IntPtr NativeFieldInfoPtr_previousSpeedsSampleSize;

		// Token: 0x04004C2F RID: 19503
		private static readonly System.IntPtr NativeFieldInfoPtr__currentThrottle_k__BackingField;

		// Token: 0x04004C30 RID: 19504
		private static readonly System.IntPtr NativeFieldInfoPtr_currentSteerAngle;

		// Token: 0x04004C31 RID: 19505
		private static readonly System.IntPtr NativeFieldInfoPtr_lastFrameSteerAngle;

		// Token: 0x04004C32 RID: 19506
		private static readonly System.IntPtr NativeFieldInfoPtr_lastReplicatedSteerAngle;

		// Token: 0x04004C33 RID: 19507
		private static readonly System.IntPtr NativeFieldInfoPtr_justExitedVehicle;

		// Token: 0x04004C34 RID: 19508
		private static readonly System.IntPtr NativeFieldInfoPtr__brakesApplied_k__BackingField;

		// Token: 0x04004C35 RID: 19509
		private static readonly System.IntPtr NativeFieldInfoPtr__isReversing_k__BackingField;

		// Token: 0x04004C36 RID: 19510
		private static readonly System.IntPtr NativeFieldInfoPtr__isStatic_k__BackingField;

		// Token: 0x04004C37 RID: 19511
		private static readonly System.IntPtr NativeFieldInfoPtr__handbrakeApplied_k__BackingField;

		// Token: 0x04004C38 RID: 19512
		private static readonly System.IntPtr NativeFieldInfoPtr_lastFramePosition;

		// Token: 0x04004C39 RID: 19513
		private static readonly System.IntPtr NativeFieldInfoPtr_closestExitPoint;

		// Token: 0x04004C3A RID: 19514
		private static readonly System.IntPtr NativeFieldInfoPtr_CurrentParkData;

		// Token: 0x04004C3B RID: 19515
		private static readonly System.IntPtr NativeFieldInfoPtr__CurrentParkingLot_k__BackingField;

		// Token: 0x04004C3C RID: 19516
		private static readonly System.IntPtr NativeFieldInfoPtr__CurrentParkingSpot_k__BackingField;

		// Token: 0x04004C3D RID: 19517
		private static readonly System.IntPtr NativeFieldInfoPtr_loader;

		// Token: 0x04004C3E RID: 19518
		private static readonly System.IntPtr NativeFieldInfoPtr__LocalExtraFiles_k__BackingField;

		// Token: 0x04004C3F RID: 19519
		private static readonly System.IntPtr NativeFieldInfoPtr__LocalExtraFolders_k__BackingField;

		// Token: 0x04004C40 RID: 19520
		private static readonly System.IntPtr NativeFieldInfoPtr__HasChanged_k__BackingField;

		// Token: 0x04004C41 RID: 19521
		private static readonly System.IntPtr NativeFieldInfoPtr_onPlayerEnterVehicle;

		// Token: 0x04004C42 RID: 19522
		private static readonly System.IntPtr NativeFieldInfoPtr_onPlayerExitVehicle;

		// Token: 0x04004C43 RID: 19523
		private static readonly System.IntPtr NativeFieldInfoPtr_onVehicleStart;

		// Token: 0x04004C44 RID: 19524
		private static readonly System.IntPtr NativeFieldInfoPtr_onVehicleStop;

		// Token: 0x04004C45 RID: 19525
		private static readonly System.IntPtr NativeFieldInfoPtr_onHandbrakeApplied;

		// Token: 0x04004C46 RID: 19526
		private static readonly System.IntPtr NativeFieldInfoPtr_onCollision;

		// Token: 0x04004C47 RID: 19527
		private static readonly System.IntPtr NativeFieldInfoPtr_syncVar___currentSteerAngle;

		// Token: 0x04004C48 RID: 19528
		private static readonly System.IntPtr NativeFieldInfoPtr_syncVar____brakesApplied_k__BackingField;

		// Token: 0x04004C49 RID: 19529
		private static readonly System.IntPtr NativeFieldInfoPtr_syncVar____isReversing_k__BackingField;

		// Token: 0x04004C4A RID: 19530
		private static readonly System.IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

		// Token: 0x04004C4B RID: 19531
		private static readonly System.IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

		// Token: 0x04004C4C RID: 19532
		private static readonly System.IntPtr NativeMethodInfoPtr_get_VehicleName_Public_get_String_0;

		// Token: 0x04004C4D RID: 19533
		private static readonly System.IntPtr NativeMethodInfoPtr_get_VehicleCode_Public_get_String_0;

		// Token: 0x04004C4E RID: 19534
		private static readonly System.IntPtr NativeMethodInfoPtr_get_VehiclePrice_Public_get_Single_0;

		// Token: 0x04004C4F RID: 19535
		private static readonly System.IntPtr NativeMethodInfoPtr_get_IsPlayerOwned_Public_get_Boolean_0;

		// Token: 0x04004C50 RID: 19536
		private static readonly System.IntPtr NativeMethodInfoPtr_set_IsPlayerOwned_Protected_set_Void_Boolean_0;

		// Token: 0x04004C51 RID: 19537
		private static readonly System.IntPtr NativeMethodInfoPtr_get_IsVisible_Public_get_Boolean_0;

		// Token: 0x04004C52 RID: 19538
		private static readonly System.IntPtr NativeMethodInfoPtr_set_IsVisible_Protected_set_Void_Boolean_0;

		// Token: 0x04004C53 RID: 19539
		private static readonly System.IntPtr NativeMethodInfoPtr_get_GUID_Public_Virtual_Final_New_get_Guid_0;

		// Token: 0x04004C54 RID: 19540
		private static readonly System.IntPtr NativeMethodInfoPtr_set_GUID_Protected_set_Void_Guid_0;

		// Token: 0x04004C55 RID: 19541
		private static readonly System.IntPtr NativeMethodInfoPtr_get_DistanceToLocalCamera_Public_get_Single_0;

		// Token: 0x04004C56 RID: 19542
		private static readonly System.IntPtr NativeMethodInfoPtr_set_DistanceToLocalCamera_Private_set_Void_Single_0;

		// Token: 0x04004C57 RID: 19543
		private static readonly System.IntPtr NativeMethodInfoPtr_get_boundingBoxDimensions_Public_get_Vector3_0;

		// Token: 0x04004C58 RID: 19544
		private static readonly System.IntPtr NativeMethodInfoPtr_get_driverEntryPoint_Public_get_Transform_0;

		// Token: 0x04004C59 RID: 19545
		private static readonly System.IntPtr NativeMethodInfoPtr_get_Rb_Public_get_Rigidbody_0;

		// Token: 0x04004C5A RID: 19546
		private static readonly System.IntPtr NativeMethodInfoPtr_get_ActualMaxSteeringAngle_Public_get_Single_0;

		// Token: 0x04004C5B RID: 19547
		private static readonly System.IntPtr NativeMethodInfoPtr_get_MaxSteerAngleOverridden_Public_get_Boolean_0;

		// Token: 0x04004C5C RID: 19548
		private static readonly System.IntPtr NativeMethodInfoPtr_set_MaxSteerAngleOverridden_Private_set_Void_Boolean_0;

		// Token: 0x04004C5D RID: 19549
		private static readonly System.IntPtr NativeMethodInfoPtr_get_OverriddenMaxSteerAngle_Public_get_Single_0;

		// Token: 0x04004C5E RID: 19550
		private static readonly System.IntPtr NativeMethodInfoPtr_set_OverriddenMaxSteerAngle_Private_set_Void_Single_0;

		// Token: 0x04004C5F RID: 19551
		private static readonly System.IntPtr NativeMethodInfoPtr_get_OwnedColor_Public_get_EVehicleColor_0;

		// Token: 0x04004C60 RID: 19552
		private static readonly System.IntPtr NativeMethodInfoPtr_set_OwnedColor_Private_set_Void_EVehicleColor_0;

		// Token: 0x04004C61 RID: 19553
		private static readonly System.IntPtr NativeMethodInfoPtr_get_Capacity_Public_get_Int32_0;

		// Token: 0x04004C62 RID: 19554
		private static readonly System.IntPtr NativeMethodInfoPtr_get_CurrentPlayerOccupancy_Public_get_Int32_0;

		// Token: 0x04004C63 RID: 19555
		private static readonly System.IntPtr NativeMethodInfoPtr_get_localPlayerIsDriver_Public_get_Boolean_0;

		// Token: 0x04004C64 RID: 19556
		private static readonly System.IntPtr NativeMethodInfoPtr_set_localPlayerIsDriver_Protected_set_Void_Boolean_0;

		// Token: 0x04004C65 RID: 19557
		private static readonly System.IntPtr NativeMethodInfoPtr_get_localPlayerIsInVehicle_Public_get_Boolean_0;

		// Token: 0x04004C66 RID: 19558
		private static readonly System.IntPtr NativeMethodInfoPtr_set_localPlayerIsInVehicle_Protected_set_Void_Boolean_0;

		// Token: 0x04004C67 RID: 19559
		private static readonly System.IntPtr NativeMethodInfoPtr_get_isOccupied_Public_get_Boolean_0;

		// Token: 0x04004C68 RID: 19560
		private static readonly System.IntPtr NativeMethodInfoPtr_set_isOccupied_Private_set_Void_Boolean_0;

		// Token: 0x04004C69 RID: 19561
		private static readonly System.IntPtr NativeMethodInfoPtr_get_DriverPlayer_Public_get_Player_0;

		// Token: 0x04004C6A RID: 19562
		private static readonly System.IntPtr NativeMethodInfoPtr_get_OccupantPlayers_Public_get_List_1_Player_0;

		// Token: 0x04004C6B RID: 19563
		private static readonly System.IntPtr NativeMethodInfoPtr_get_OccupantNPCs_Public_get_Il2CppReferenceArray_1_NPC_0;

		// Token: 0x04004C6C RID: 19564
		private static readonly System.IntPtr NativeMethodInfoPtr_set_OccupantNPCs_Protected_set_Void_Il2CppReferenceArray_1_NPC_0;

		// Token: 0x04004C6D RID: 19565
		private static readonly System.IntPtr NativeMethodInfoPtr_get_speed_Kmh_Public_get_Single_0;

		// Token: 0x04004C6E RID: 19566
		private static readonly System.IntPtr NativeMethodInfoPtr_set_speed_Kmh_Protected_set_Void_Single_0;

		// Token: 0x04004C6F RID: 19567
		private static readonly System.IntPtr NativeMethodInfoPtr_get_speed_Ms_Public_get_Single_0;

		// Token: 0x04004C70 RID: 19568
		private static readonly System.IntPtr NativeMethodInfoPtr_get_speed_Mph_Public_get_Single_0;

		// Token: 0x04004C71 RID: 19569
		private static readonly System.IntPtr NativeMethodInfoPtr_get_currentThrottle_Public_get_Single_0;

		// Token: 0x04004C72 RID: 19570
		private static readonly System.IntPtr NativeMethodInfoPtr_set_currentThrottle_Protected_set_Void_Single_0;

		// Token: 0x04004C73 RID: 19571
		private static readonly System.IntPtr NativeMethodInfoPtr_get_brakesApplied_Public_get_Boolean_0;

		// Token: 0x04004C74 RID: 19572
		private static readonly System.IntPtr NativeMethodInfoPtr_set_brakesApplied_Public_set_Void_Boolean_0;

		// Token: 0x04004C75 RID: 19573
		private static readonly System.IntPtr NativeMethodInfoPtr_get_isReversing_Public_get_Boolean_0;

		// Token: 0x04004C76 RID: 19574
		private static readonly System.IntPtr NativeMethodInfoPtr_set_isReversing_Public_set_Void_Boolean_0;

		// Token: 0x04004C77 RID: 19575
		private static readonly System.IntPtr NativeMethodInfoPtr_get_isStatic_Public_get_Boolean_0;

		// Token: 0x04004C78 RID: 19576
		private static readonly System.IntPtr NativeMethodInfoPtr_set_isStatic_Protected_set_Void_Boolean_0;

		// Token: 0x04004C79 RID: 19577
		private static readonly System.IntPtr NativeMethodInfoPtr_get_handbrakeApplied_Public_get_Boolean_0;

		// Token: 0x04004C7A RID: 19578
		private static readonly System.IntPtr NativeMethodInfoPtr_set_handbrakeApplied_Protected_set_Void_Boolean_0;

		// Token: 0x04004C7B RID: 19579
		private static readonly System.IntPtr NativeMethodInfoPtr_get_boundingBaseOffset_Public_get_Single_0;

		// Token: 0x04004C7C RID: 19580
		private static readonly System.IntPtr NativeMethodInfoPtr_get_isParked_Public_get_Boolean_0;

		// Token: 0x04004C7D RID: 19581
		private static readonly System.IntPtr NativeMethodInfoPtr_get_CurrentParkingLot_Public_get_ParkingLot_0;

		// Token: 0x04004C7E RID: 19582
		private static readonly System.IntPtr NativeMethodInfoPtr_set_CurrentParkingLot_Protected_set_Void_ParkingLot_0;

		// Token: 0x04004C7F RID: 19583
		private static readonly System.IntPtr NativeMethodInfoPtr_get_CurrentParkingSpot_Public_get_ParkingSpot_0;

		// Token: 0x04004C80 RID: 19584
		private static readonly System.IntPtr NativeMethodInfoPtr_set_CurrentParkingSpot_Protected_set_Void_ParkingSpot_0;

		// Token: 0x04004C81 RID: 19585
		private static readonly System.IntPtr NativeMethodInfoPtr_get_SaveFolderName_Public_Virtual_Final_New_get_String_0;

		// Token: 0x04004C82 RID: 19586
		private static readonly System.IntPtr NativeMethodInfoPtr_get_SaveFileName_Public_Virtual_Final_New_get_String_0;

		// Token: 0x04004C83 RID: 19587
		private static readonly System.IntPtr NativeMethodInfoPtr_get_Loader_Public_Virtual_Final_New_get_Loader_0;

		// Token: 0x04004C84 RID: 19588
		private static readonly System.IntPtr NativeMethodInfoPtr_get_ShouldSaveUnderFolder_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x04004C85 RID: 19589
		private static readonly System.IntPtr NativeMethodInfoPtr_get_LocalExtraFiles_Public_Virtual_Final_New_get_List_1_String_0;

		// Token: 0x04004C86 RID: 19590
		private static readonly System.IntPtr NativeMethodInfoPtr_set_LocalExtraFiles_Public_Virtual_Final_New_set_Void_List_1_String_0;

		// Token: 0x04004C87 RID: 19591
		private static readonly System.IntPtr NativeMethodInfoPtr_get_LocalExtraFolders_Public_Virtual_Final_New_get_List_1_String_0;

		// Token: 0x04004C88 RID: 19592
		private static readonly System.IntPtr NativeMethodInfoPtr_set_LocalExtraFolders_Public_Virtual_Final_New_set_Void_List_1_String_0;

		// Token: 0x04004C89 RID: 19593
		private static readonly System.IntPtr NativeMethodInfoPtr_get_HasChanged_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x04004C8A RID: 19594
		private static readonly System.IntPtr NativeMethodInfoPtr_set_HasChanged_Public_Virtual_Final_New_set_Void_Boolean_0;

		// Token: 0x04004C8B RID: 19595
		private static readonly System.IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;

		// Token: 0x04004C8C RID: 19596
		private static readonly System.IntPtr NativeMethodInfoPtr_InitializeSaveable_Public_Virtual_New_Void_0;

		// Token: 0x04004C8D RID: 19597
		private static readonly System.IntPtr NativeMethodInfoPtr_OnStartServer_Public_Virtual_Void_0;

		// Token: 0x04004C8E RID: 19598
		private static readonly System.IntPtr NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0;

		// Token: 0x04004C8F RID: 19599
		private static readonly System.IntPtr NativeMethodInfoPtr_OnStartClient_Public_Virtual_Void_0;

		// Token: 0x04004C90 RID: 19600
		private static readonly System.IntPtr NativeMethodInfoPtr_SetIsPlayerOwned_Public_Void_NetworkConnection_Boolean_0;

		// Token: 0x04004C91 RID: 19601
		private static readonly System.IntPtr NativeMethodInfoPtr_RefreshPoI_Private_Void_0;

		// Token: 0x04004C92 RID: 19602
		private static readonly System.IntPtr NativeMethodInfoPtr_SetGUID_Public_Virtual_Final_New_Void_Guid_0;

		// Token: 0x04004C93 RID: 19603
		private static readonly System.IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_1;

		// Token: 0x04004C94 RID: 19604
		private static readonly System.IntPtr NativeMethodInfoPtr_Exit_Private_Void_ExitAction_0;

		// Token: 0x04004C95 RID: 19605
		private static readonly System.IntPtr NativeMethodInfoPtr_OnDestroy_Protected_Virtual_New_Void_1;

		// Token: 0x04004C96 RID: 19606
		private static readonly System.IntPtr NativeMethodInfoPtr_GetNetworth_Private_Void_FloatContainer_0;

		// Token: 0x04004C97 RID: 19607
		private static readonly System.IntPtr NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_1;

		// Token: 0x04004C98 RID: 19608
		private static readonly System.IntPtr NativeMethodInfoPtr_OnDrawGizmos_Private_Void_0;

		// Token: 0x04004C99 RID: 19609
		private static readonly System.IntPtr NativeMethodInfoPtr_FixedUpdate_Protected_Virtual_New_Void_1;

		// Token: 0x04004C9A RID: 19610
		private static readonly System.IntPtr NativeMethodInfoPtr_OnMinPass_Protected_Virtual_New_Void_1;

		// Token: 0x04004C9B RID: 19611
		private static readonly System.IntPtr NativeMethodInfoPtr_LateUpdate_Protected_Virtual_New_Void_1;

		// Token: 0x04004C9C RID: 19612
		private static readonly System.IntPtr NativeMethodInfoPtr_OnCollisionEnter_Private_Void_Collision_0;

		// Token: 0x04004C9D RID: 19613
		private static readonly System.IntPtr NativeMethodInfoPtr_SetOwner_Protected_Virtual_New_Void_NetworkConnection_0;

		// Token: 0x04004C9E RID: 19614
		private static readonly System.IntPtr NativeMethodInfoPtr_OnOwnerChanged_Protected_Virtual_New_Void_1;

		// Token: 0x04004C9F RID: 19615
		private static readonly System.IntPtr NativeMethodInfoPtr_SetTransform_Server_Public_Void_Vector3_Quaternion_0;

		// Token: 0x04004CA0 RID: 19616
		private static readonly System.IntPtr NativeMethodInfoPtr_SetTransform_Public_Void_Vector3_Quaternion_0;

		// Token: 0x04004CA1 RID: 19617
		private static readonly System.IntPtr NativeMethodInfoPtr_DestroyVehicle_Public_Void_0;

		// Token: 0x04004CA2 RID: 19618
		private static readonly System.IntPtr NativeMethodInfoPtr_UpdateThrottle_Protected_Virtual_New_Void_1;

		// Token: 0x04004CA3 RID: 19619
		private static readonly System.IntPtr NativeMethodInfoPtr_ApplyThrottle_Protected_Virtual_New_Void_1;

		// Token: 0x04004CA4 RID: 19620
		private static readonly System.IntPtr NativeMethodInfoPtr_ApplyHandbrake_Public_Void_0;

		// Token: 0x04004CA5 RID: 19621
		private static readonly System.IntPtr NativeMethodInfoPtr_SetSteeringAngle_Private_Void_Single_0;

		// Token: 0x04004CA6 RID: 19622
		private static readonly System.IntPtr NativeMethodInfoPtr_UpdateSteerAngle_Protected_Virtual_New_Void_1;

		// Token: 0x04004CA7 RID: 19623
		private static readonly System.IntPtr NativeMethodInfoPtr_ApplySteerAngle_Protected_Virtual_New_Void_1;

		// Token: 0x04004CA8 RID: 19624
		private static readonly System.IntPtr NativeMethodInfoPtr_DelaySetStatic_Private_Void_Boolean_0;

		// Token: 0x04004CA9 RID: 19625
		private static readonly System.IntPtr NativeMethodInfoPtr_SetIsStatic_Public_Virtual_New_Void_Boolean_0;

		// Token: 0x04004CAA RID: 19626
		private static readonly System.IntPtr NativeMethodInfoPtr_AlignTo_Public_Void_Transform_EParkingAlignment_Boolean_0;

		// Token: 0x04004CAB RID: 19627
		private static readonly System.IntPtr NativeMethodInfoPtr_GetAlignmentTransform_Public_Tuple_2_Vector3_Quaternion_Transform_EParkingAlignment_0;

		// Token: 0x04004CAC RID: 19628
		private static readonly System.IntPtr NativeMethodInfoPtr_GetVehicleValue_Public_Single_0;

		// Token: 0x04004CAD RID: 19629
		private static readonly System.IntPtr NativeMethodInfoPtr_OverrideMaxSteerAngle_Public_Void_Single_0;

		// Token: 0x04004CAE RID: 19630
		private static readonly System.IntPtr NativeMethodInfoPtr_ResetMaxSteerAngle_Public_Void_0;

		// Token: 0x04004CAF RID: 19631
		private static readonly System.IntPtr NativeMethodInfoPtr_SetObstaclesActive_Public_Void_Boolean_0;

		// Token: 0x04004CB0 RID: 19632
		private static readonly System.IntPtr NativeMethodInfoPtr_GetFirstFreeSeat_Public_VehicleSeat_0;

		// Token: 0x04004CB1 RID: 19633
		private static readonly System.IntPtr NativeMethodInfoPtr_SetSeatOccupant_Private_Void_NetworkConnection_Int32_NetworkConnection_0;

		// Token: 0x04004CB2 RID: 19634
		private static readonly System.IntPtr NativeMethodInfoPtr_SetSeatOccupant_Server_Private_Void_Int32_NetworkConnection_0;

		// Token: 0x04004CB3 RID: 19635
		private static readonly System.IntPtr NativeMethodInfoPtr_Hovered_Private_Void_0;

		// Token: 0x04004CB4 RID: 19636
		private static readonly System.IntPtr NativeMethodInfoPtr_Interacted_Private_Void_0;

		// Token: 0x04004CB5 RID: 19637
		private static readonly System.IntPtr NativeMethodInfoPtr_EnterVehicle_Private_Void_0;

		// Token: 0x04004CB6 RID: 19638
		private static readonly System.IntPtr NativeMethodInfoPtr_ExitVehicle_Public_Void_0;

		// Token: 0x04004CB7 RID: 19639
		private static readonly System.IntPtr NativeMethodInfoPtr_EndJustExited_Private_Void_0;

		// Token: 0x04004CB8 RID: 19640
		private static readonly System.IntPtr NativeMethodInfoPtr_GetExitPoint_Public_Transform_Int32_0;

		// Token: 0x04004CB9 RID: 19641
		private static readonly System.IntPtr NativeMethodInfoPtr_GetClosestExitPoint_Private_Transform_Vector3_0;

		// Token: 0x04004CBA RID: 19642
		private static readonly System.IntPtr NativeMethodInfoPtr_GetValidExitPoint_Private_Transform_List_1_Transform_0;

		// Token: 0x04004CBB RID: 19643
		private static readonly System.IntPtr NativeMethodInfoPtr_AddNPCOccupant_Public_Void_NPC_0;

		// Token: 0x04004CBC RID: 19644
		private static readonly System.IntPtr NativeMethodInfoPtr_RemoveNPCOccupant_Public_Void_NPC_0;

		// Token: 0x04004CBD RID: 19645
		private static readonly System.IntPtr NativeMethodInfoPtr_CanBeRecovered_Public_Virtual_New_Boolean_0;

		// Token: 0x04004CBE RID: 19646
		private static readonly System.IntPtr NativeMethodInfoPtr_RecoverVehicle_Public_Virtual_New_Void_0;

		// Token: 0x04004CBF RID: 19647
		private static readonly System.IntPtr NativeMethodInfoPtr_SendOwnedColor_Public_Void_EVehicleColor_0;

		// Token: 0x04004CC0 RID: 19648
		private static readonly System.IntPtr NativeMethodInfoPtr_SetOwnedColor_Protected_Virtual_New_Void_NetworkConnection_EVehicleColor_0;

		// Token: 0x04004CC1 RID: 19649
		private static readonly System.IntPtr NativeMethodInfoPtr_ApplyColor_Public_Virtual_New_Void_EVehicleColor_0;

		// Token: 0x04004CC2 RID: 19650
		private static readonly System.IntPtr NativeMethodInfoPtr_ApplyOwnedColor_Public_Void_0;

		// Token: 0x04004CC3 RID: 19651
		private static readonly System.IntPtr NativeMethodInfoPtr_ShowOutline_Public_Void_EOutlineColor_0;

		// Token: 0x04004CC4 RID: 19652
		private static readonly System.IntPtr NativeMethodInfoPtr_HideOutline_Public_Void_0;

		// Token: 0x04004CC5 RID: 19653
		private static readonly System.IntPtr NativeMethodInfoPtr_Park_Networked_Private_Void_NetworkConnection_ParkData_0;

		// Token: 0x04004CC6 RID: 19654
		private static readonly System.IntPtr NativeMethodInfoPtr_Park_Public_Void_NetworkConnection_ParkData_Boolean_0;

		// Token: 0x04004CC7 RID: 19655
		private static readonly System.IntPtr NativeMethodInfoPtr_ExitPark_Networked_Public_Void_NetworkConnection_Boolean_0;

		// Token: 0x04004CC8 RID: 19656
		private static readonly System.IntPtr NativeMethodInfoPtr_ExitPark_Public_Void_Boolean_0;

		// Token: 0x04004CC9 RID: 19657
		private static readonly System.IntPtr NativeMethodInfoPtr_SetVisible_Public_Void_Boolean_0;

		// Token: 0x04004CCA RID: 19658
		private static readonly System.IntPtr NativeMethodInfoPtr_GetContents_Public_List_1_ItemInstance_0;

		// Token: 0x04004CCB RID: 19659
		private static readonly System.IntPtr NativeMethodInfoPtr_GetVehicleData_Public_Virtual_New_VehicleData_0;

		// Token: 0x04004CCC RID: 19660
		private static readonly System.IntPtr NativeMethodInfoPtr_GetSaveString_Public_Virtual_Final_New_String_0;

		// Token: 0x04004CCD RID: 19661
		private static readonly System.IntPtr NativeMethodInfoPtr_GetContentsSet_Private_ItemSet_0;

		// Token: 0x04004CCE RID: 19662
		private static readonly System.IntPtr NativeMethodInfoPtr_Load_Public_Virtual_New_Void_VehicleData_String_0;

		// Token: 0x04004CCF RID: 19663
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04004CD0 RID: 19664
		private static readonly System.IntPtr NativeMethodInfoPtr__ApplyColor_b__249_0_Private_Boolean_VehicleColorData_0;

		// Token: 0x04004CD1 RID: 19665
		private static readonly System.IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

		// Token: 0x04004CD2 RID: 19666
		private static readonly System.IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

		// Token: 0x04004CD3 RID: 19667
		private static readonly System.IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

		// Token: 0x04004CD4 RID: 19668
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcWriter___Observers_SetIsPlayerOwned_214505783_Private_Void_NetworkConnection_Boolean_0;

		// Token: 0x04004CD5 RID: 19669
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcLogic___SetIsPlayerOwned_214505783_Public_Void_NetworkConnection_Boolean_0;

		// Token: 0x04004CD6 RID: 19670
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcReader___Observers_SetIsPlayerOwned_214505783_Private_Void_PooledReader_Channel_0;

		// Token: 0x04004CD7 RID: 19671
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcWriter___Target_SetIsPlayerOwned_214505783_Private_Void_NetworkConnection_Boolean_0;

		// Token: 0x04004CD8 RID: 19672
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcReader___Target_SetIsPlayerOwned_214505783_Private_Void_PooledReader_Channel_0;

		// Token: 0x04004CD9 RID: 19673
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcWriter___Server_SetOwner_328543758_Private_Void_NetworkConnection_0;

		// Token: 0x04004CDA RID: 19674
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcLogic___SetOwner_328543758_Protected_Virtual_New_Void_NetworkConnection_0;

		// Token: 0x04004CDB RID: 19675
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcReader___Server_SetOwner_328543758_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x04004CDC RID: 19676
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcWriter___Observers_OnOwnerChanged_2166136261_Private_Void_0;

		// Token: 0x04004CDD RID: 19677
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcLogic___OnOwnerChanged_2166136261_Protected_Virtual_New_Void_1;

		// Token: 0x04004CDE RID: 19678
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcReader___Observers_OnOwnerChanged_2166136261_Private_Void_PooledReader_Channel_0;

		// Token: 0x04004CDF RID: 19679
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcWriter___Server_SetTransform_Server_3848837105_Private_Void_Vector3_Quaternion_0;

		// Token: 0x04004CE0 RID: 19680
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcLogic___SetTransform_Server_3848837105_Public_Void_Vector3_Quaternion_0;

		// Token: 0x04004CE1 RID: 19681
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcReader___Server_SetTransform_Server_3848837105_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x04004CE2 RID: 19682
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcWriter___Observers_SetTransform_3848837105_Private_Void_Vector3_Quaternion_0;

		// Token: 0x04004CE3 RID: 19683
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcLogic___SetTransform_3848837105_Public_Void_Vector3_Quaternion_0;

		// Token: 0x04004CE4 RID: 19684
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcReader___Observers_SetTransform_3848837105_Private_Void_PooledReader_Channel_0;

		// Token: 0x04004CE5 RID: 19685
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcWriter___Server_SetSteeringAngle_431000436_Private_Void_Single_0;

		// Token: 0x04004CE6 RID: 19686
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcLogic___SetSteeringAngle_431000436_Private_Void_Single_0;

		// Token: 0x04004CE7 RID: 19687
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcReader___Server_SetSteeringAngle_431000436_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x04004CE8 RID: 19688
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcWriter___Observers_SetSeatOccupant_3428404692_Private_Void_NetworkConnection_Int32_NetworkConnection_0;

		// Token: 0x04004CE9 RID: 19689
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcLogic___SetSeatOccupant_3428404692_Private_Void_NetworkConnection_Int32_NetworkConnection_0;

		// Token: 0x04004CEA RID: 19690
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcReader___Observers_SetSeatOccupant_3428404692_Private_Void_PooledReader_Channel_0;

		// Token: 0x04004CEB RID: 19691
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcWriter___Target_SetSeatOccupant_3428404692_Private_Void_NetworkConnection_Int32_NetworkConnection_0;

		// Token: 0x04004CEC RID: 19692
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcReader___Target_SetSeatOccupant_3428404692_Private_Void_PooledReader_Channel_0;

		// Token: 0x04004CED RID: 19693
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcWriter___Server_SetSeatOccupant_Server_3266232555_Private_Void_Int32_NetworkConnection_0;

		// Token: 0x04004CEE RID: 19694
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcLogic___SetSeatOccupant_Server_3266232555_Private_Void_Int32_NetworkConnection_0;

		// Token: 0x04004CEF RID: 19695
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcReader___Server_SetSeatOccupant_Server_3266232555_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x04004CF0 RID: 19696
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcWriter___Server_SendOwnedColor_911055161_Private_Void_EVehicleColor_0;

		// Token: 0x04004CF1 RID: 19697
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcLogic___SendOwnedColor_911055161_Public_Void_EVehicleColor_0;

		// Token: 0x04004CF2 RID: 19698
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcReader___Server_SendOwnedColor_911055161_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x04004CF3 RID: 19699
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcWriter___Target_SetOwnedColor_1679996372_Private_Void_NetworkConnection_EVehicleColor_0;

		// Token: 0x04004CF4 RID: 19700
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcLogic___SetOwnedColor_1679996372_Protected_Virtual_New_Void_NetworkConnection_EVehicleColor_0;

		// Token: 0x04004CF5 RID: 19701
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcReader___Target_SetOwnedColor_1679996372_Private_Void_PooledReader_Channel_0;

		// Token: 0x04004CF6 RID: 19702
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcWriter___Observers_SetOwnedColor_1679996372_Private_Void_NetworkConnection_EVehicleColor_0;

		// Token: 0x04004CF7 RID: 19703
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcReader___Observers_SetOwnedColor_1679996372_Private_Void_PooledReader_Channel_0;

		// Token: 0x04004CF8 RID: 19704
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcWriter___Observers_Park_Networked_2633993806_Private_Void_NetworkConnection_ParkData_0;

		// Token: 0x04004CF9 RID: 19705
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcLogic___Park_Networked_2633993806_Private_Void_NetworkConnection_ParkData_0;

		// Token: 0x04004CFA RID: 19706
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcReader___Observers_Park_Networked_2633993806_Private_Void_PooledReader_Channel_0;

		// Token: 0x04004CFB RID: 19707
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcWriter___Target_Park_Networked_2633993806_Private_Void_NetworkConnection_ParkData_0;

		// Token: 0x04004CFC RID: 19708
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcReader___Target_Park_Networked_2633993806_Private_Void_PooledReader_Channel_0;

		// Token: 0x04004CFD RID: 19709
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcWriter___Observers_ExitPark_Networked_214505783_Private_Void_NetworkConnection_Boolean_0;

		// Token: 0x04004CFE RID: 19710
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcLogic___ExitPark_Networked_214505783_Public_Void_NetworkConnection_Boolean_0;

		// Token: 0x04004CFF RID: 19711
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcReader___Observers_ExitPark_Networked_214505783_Private_Void_PooledReader_Channel_0;

		// Token: 0x04004D00 RID: 19712
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcWriter___Target_ExitPark_Networked_214505783_Private_Void_NetworkConnection_Boolean_0;

		// Token: 0x04004D01 RID: 19713
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcReader___Target_ExitPark_Networked_214505783_Private_Void_PooledReader_Channel_0;

		// Token: 0x04004D02 RID: 19714
		private static readonly System.IntPtr NativeMethodInfoPtr_sync___get_value_currentSteerAngle_Public_get_Single_0;

		// Token: 0x04004D03 RID: 19715
		private static readonly System.IntPtr NativeMethodInfoPtr_sync___set_value_currentSteerAngle_Public_set_Void_Single_Boolean_0;

		// Token: 0x04004D04 RID: 19716
		private static readonly System.IntPtr NativeMethodInfoPtr_ReadSyncVar___ScheduleOne_Vehicles_LandVehicle_Public_Virtual_Boolean_PooledReader_UInt32_Boolean_0;

		// Token: 0x04004D05 RID: 19717
		private static readonly System.IntPtr NativeMethodInfoPtr_sync___get_value__brakesApplied_k__BackingField_Public_get_Boolean_0;

		// Token: 0x04004D06 RID: 19718
		private static readonly System.IntPtr NativeMethodInfoPtr_sync___set_value__brakesApplied_k__BackingField_Public_set_Void_Boolean_Boolean_0;

		// Token: 0x04004D07 RID: 19719
		private static readonly System.IntPtr NativeMethodInfoPtr_sync___get_value__isReversing_k__BackingField_Public_get_Boolean_0;

		// Token: 0x04004D08 RID: 19720
		private static readonly System.IntPtr NativeMethodInfoPtr_sync___set_value__isReversing_k__BackingField_Public_set_Void_Boolean_Boolean_0;

		// Token: 0x04004D09 RID: 19721
		private static readonly System.IntPtr NativeMethodInfoPtr_Method_Protected_Virtual_New_Void_0;

		// Token: 0x02000AB2 RID: 2738
		[System.Serializable]
		public class BodyMesh : Il2CppSystem.Object
		{
			// Token: 0x0600D616 RID: 54806 RVA: 0x00336F84 File Offset: 0x00335184
			// Note: this type is marked as 'beforefieldinit'.
			static BodyMesh()
			{
				Il2CppClassPointerStore<LandVehicle.BodyMesh>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, "BodyMesh");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LandVehicle.BodyMesh>.NativeClassPtr);
				LandVehicle.BodyMesh.NativeFieldInfoPtr_Renderer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandVehicle.BodyMesh>.NativeClassPtr, "Renderer");
				LandVehicle.BodyMesh.NativeFieldInfoPtr_MaterialIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandVehicle.BodyMesh>.NativeClassPtr, "MaterialIndex");
				LandVehicle.BodyMesh.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle.BodyMesh>.NativeClassPtr, 100677613);
			}

			// Token: 0x0600D617 RID: 54807 RVA: 0x00336FEC File Offset: 0x003351EC
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe BodyMesh() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LandVehicle.BodyMesh>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.BodyMesh.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600D618 RID: 54808 RVA: 0x00067E93 File Offset: 0x00066093
			public BodyMesh(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700422F RID: 16943
			// (get) Token: 0x0600D619 RID: 54809 RVA: 0x00337028 File Offset: 0x00335228
			// (set) Token: 0x0600D61A RID: 54810 RVA: 0x00067E9C File Offset: 0x0006609C
			public unsafe MeshRenderer Renderer
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.BodyMesh.NativeFieldInfoPtr_Renderer);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<MeshRenderer>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.BodyMesh.NativeFieldInfoPtr_Renderer), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004230 RID: 16944
			// (get) Token: 0x0600D61B RID: 54811 RVA: 0x00337058 File Offset: 0x00335258
			// (set) Token: 0x0600D61C RID: 54812 RVA: 0x00067EBB File Offset: 0x000660BB
			public unsafe int MaterialIndex
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.BodyMesh.NativeFieldInfoPtr_MaterialIndex);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.BodyMesh.NativeFieldInfoPtr_MaterialIndex)) = value;
				}
			}

			// Token: 0x04009085 RID: 36997
			private static readonly System.IntPtr NativeFieldInfoPtr_Renderer;

			// Token: 0x04009086 RID: 36998
			private static readonly System.IntPtr NativeFieldInfoPtr_MaterialIndex;

			// Token: 0x04009087 RID: 36999
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000AB3 RID: 2739
		public sealed class VehiclePlayerEvent : Il2CppSystem.MulticastDelegate
		{
			// Token: 0x0600D61D RID: 54813 RVA: 0x00337080 File Offset: 0x00335280
			// Note: this type is marked as 'beforefieldinit'.
			static VehiclePlayerEvent()
			{
				Il2CppClassPointerStore<LandVehicle.VehiclePlayerEvent>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, "VehiclePlayerEvent");
				LandVehicle.VehiclePlayerEvent.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle.VehiclePlayerEvent>.NativeClassPtr, 100677614);
				LandVehicle.VehiclePlayerEvent.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle.VehiclePlayerEvent>.NativeClassPtr, 100677615);
				LandVehicle.VehiclePlayerEvent.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Player_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle.VehiclePlayerEvent>.NativeClassPtr, 100677616);
				LandVehicle.VehiclePlayerEvent.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle.VehiclePlayerEvent>.NativeClassPtr, 100677617);
			}

			// Token: 0x0600D61E RID: 54814 RVA: 0x003370F4 File Offset: 0x003352F4
			[CallerCount(90)]
			[CachedScanResults(RefRangeStart = 110018, RefRangeEnd = 110108, XrefRangeStart = 110018, XrefRangeEnd = 110108, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe VehiclePlayerEvent(Il2CppSystem.Object @object, System.IntPtr method) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LandVehicle.VehiclePlayerEvent>.NativeClassPtr))
			{
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref method;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.VehiclePlayerEvent.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600D61F RID: 54815 RVA: 0x00337150 File Offset: 0x00335350
			[CallerCount(0)]
			public unsafe void Invoke(Player player)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.VehiclePlayerEvent.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Player_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600D620 RID: 54816 RVA: 0x00337194 File Offset: 0x00335394
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 77936, RefRangeEnd = 77937, XrefRangeStart = 77936, XrefRangeEnd = 77937, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Il2CppSystem.IAsyncResult BeginInvoke(Player player, Il2CppSystem.AsyncCallback callback, Il2CppSystem.Object @object)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
				ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
				ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.VehiclePlayerEvent.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Player_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.IAsyncResult>(intPtr2) : null;
			}

			// Token: 0x0600D621 RID: 54817 RVA: 0x00337208 File Offset: 0x00335408
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void EndInvoke(Il2CppSystem.IAsyncResult result)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.VehiclePlayerEvent.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600D622 RID: 54818 RVA: 0x00067ED6 File Offset: 0x000660D6
			public VehiclePlayerEvent(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x0600D623 RID: 54819 RVA: 0x00067EDF File Offset: 0x000660DF
			public static implicit operator LandVehicle.VehiclePlayerEvent(System.Action<Player> A_0)
			{
				return DelegateSupport.ConvertDelegate<LandVehicle.VehiclePlayerEvent>(A_0);
			}

			// Token: 0x0600D624 RID: 54820 RVA: 0x00067EE7 File Offset: 0x000660E7
			public static LandVehicle.VehiclePlayerEvent operator +(LandVehicle.VehiclePlayerEvent A_0, LandVehicle.VehiclePlayerEvent A_1)
			{
				return Il2CppSystem.Delegate.Combine(A_0, A_1).Cast<LandVehicle.VehiclePlayerEvent>();
			}

			// Token: 0x0600D625 RID: 54821 RVA: 0x00067EF5 File Offset: 0x000660F5
			public static LandVehicle.VehiclePlayerEvent operator -(LandVehicle.VehiclePlayerEvent A_0, LandVehicle.VehiclePlayerEvent A_1)
			{
				Il2CppSystem.Delegate result;
				Il2CppSystem.Delegate @delegate = result = Il2CppSystem.Delegate.Remove(A_0, A_1);
				if (@delegate != null)
				{
					result = @delegate.Cast<LandVehicle.VehiclePlayerEvent>();
				}
				return result;
			}

			// Token: 0x04009088 RID: 37000
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x04009089 RID: 37001
			private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Player_0;

			// Token: 0x0400908A RID: 37002
			private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Player_AsyncCallback_Object_0;

			// Token: 0x0400908B RID: 37003
			private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
		}

		// Token: 0x02000AB4 RID: 2740
		[ObfuscatedName("ScheduleOne.Vehicles.LandVehicle+<>c")]
		[System.Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x0600D626 RID: 54822 RVA: 0x0033724C File Offset: 0x0033544C
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<LandVehicle.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LandVehicle.__c>.NativeClassPtr);
				LandVehicle.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandVehicle.__c>.NativeClassPtr, "<>9");
				LandVehicle.__c.NativeFieldInfoPtr___9__96_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandVehicle.__c>.NativeClassPtr, "<>9__96_0");
				LandVehicle.__c.NativeFieldInfoPtr___9__113_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandVehicle.__c>.NativeClassPtr, "<>9__113_0");
				LandVehicle.__c.NativeFieldInfoPtr___9__113_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandVehicle.__c>.NativeClassPtr, "<>9__113_1");
				LandVehicle.__c.NativeFieldInfoPtr___9__233_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandVehicle.__c>.NativeClassPtr, "<>9__233_0");
				LandVehicle.__c.NativeFieldInfoPtr___9__243_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandVehicle.__c>.NativeClassPtr, "<>9__243_0");
				LandVehicle.__c.NativeFieldInfoPtr___9__244_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandVehicle.__c>.NativeClassPtr, "<>9__244_0");
				LandVehicle.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle.__c>.NativeClassPtr, 100677619);
				LandVehicle.__c.NativeMethodInfoPtr__get_CurrentPlayerOccupancy_b__96_0_Internal_Boolean_VehicleSeat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle.__c>.NativeClassPtr, 100677620);
				LandVehicle.__c.NativeMethodInfoPtr__get_OccupantPlayers_b__113_0_Internal_Boolean_VehicleSeat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle.__c>.NativeClassPtr, 100677621);
				LandVehicle.__c.NativeMethodInfoPtr__get_OccupantPlayers_b__113_1_Internal_Player_VehicleSeat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle.__c>.NativeClassPtr, 100677622);
				LandVehicle.__c.NativeMethodInfoPtr__SetSeatOccupant_b__233_0_Internal_Boolean_VehicleSeat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle.__c>.NativeClassPtr, 100677623);
				LandVehicle.__c.NativeMethodInfoPtr__AddNPCOccupant_b__243_0_Internal_Boolean_NPC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle.__c>.NativeClassPtr, 100677624);
				LandVehicle.__c.NativeMethodInfoPtr__RemoveNPCOccupant_b__244_0_Internal_Boolean_NPC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle.__c>.NativeClassPtr, 100677625);
			}

			// Token: 0x0600D627 RID: 54823 RVA: 0x00337390 File Offset: 0x00335590
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LandVehicle.__c>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600D628 RID: 54824 RVA: 0x003373CC File Offset: 0x003355CC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 221867, XrefRangeEnd = 221872, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _get_CurrentPlayerOccupancy_b__96_0(VehicleSeat s)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(s);
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(LandVehicle.__c.NativeMethodInfoPtr__get_CurrentPlayerOccupancy_b__96_0_Internal_Boolean_VehicleSeat_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x0600D629 RID: 54825 RVA: 0x0033741C File Offset: 0x0033561C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _get_OccupantPlayers_b__113_0(VehicleSeat s)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(s);
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(LandVehicle.__c.NativeMethodInfoPtr__get_OccupantPlayers_b__113_0_Internal_Boolean_VehicleSeat_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x0600D62A RID: 54826 RVA: 0x0033746C File Offset: 0x0033566C
			[CallerCount(0)]
			public unsafe Player _get_OccupantPlayers_b__113_1(VehicleSeat s)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(s);
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.__c.NativeMethodInfoPtr__get_OccupantPlayers_b__113_1_Internal_Player_VehicleSeat_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Player>(intPtr2) : null;
			}

			// Token: 0x0600D62B RID: 54827 RVA: 0x003374BC File Offset: 0x003356BC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _SetSeatOccupant_b__233_0(VehicleSeat s)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(s);
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(LandVehicle.__c.NativeMethodInfoPtr__SetSeatOccupant_b__233_0_Internal_Boolean_VehicleSeat_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x0600D62C RID: 54828 RVA: 0x0033750C File Offset: 0x0033570C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 221872, XrefRangeEnd = 221876, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _AddNPCOccupant_b__243_0(NPC x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(LandVehicle.__c.NativeMethodInfoPtr__AddNPCOccupant_b__243_0_Internal_Boolean_NPC_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x0600D62D RID: 54829 RVA: 0x0033755C File Offset: 0x0033575C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 221876, XrefRangeEnd = 221880, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _RemoveNPCOccupant_b__244_0(NPC x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(LandVehicle.__c.NativeMethodInfoPtr__RemoveNPCOccupant_b__244_0_Internal_Boolean_NPC_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x0600D62E RID: 54830 RVA: 0x00067F06 File Offset: 0x00066106
			public __c(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004231 RID: 16945
			// (get) Token: 0x0600D62F RID: 54831 RVA: 0x003375AC File Offset: 0x003357AC
			// (set) Token: 0x0600D630 RID: 54832 RVA: 0x00067F0F File Offset: 0x0006610F
			public unsafe static LandVehicle.__c __9
			{
				get
				{
					System.IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(LandVehicle.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<LandVehicle.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(LandVehicle.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004232 RID: 16946
			// (get) Token: 0x0600D631 RID: 54833 RVA: 0x003375D4 File Offset: 0x003357D4
			// (set) Token: 0x0600D632 RID: 54834 RVA: 0x00067F21 File Offset: 0x00066121
			public unsafe static Il2CppSystem.Func<VehicleSeat, bool> __9__96_0
			{
				get
				{
					System.IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(LandVehicle.__c.NativeFieldInfoPtr___9__96_0, (void*)(&intPtr));
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Func<VehicleSeat, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(LandVehicle.__c.NativeFieldInfoPtr___9__96_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004233 RID: 16947
			// (get) Token: 0x0600D633 RID: 54835 RVA: 0x003375FC File Offset: 0x003357FC
			// (set) Token: 0x0600D634 RID: 54836 RVA: 0x00067F33 File Offset: 0x00066133
			public unsafe static Il2CppSystem.Func<VehicleSeat, bool> __9__113_0
			{
				get
				{
					System.IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(LandVehicle.__c.NativeFieldInfoPtr___9__113_0, (void*)(&intPtr));
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Func<VehicleSeat, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(LandVehicle.__c.NativeFieldInfoPtr___9__113_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004234 RID: 16948
			// (get) Token: 0x0600D635 RID: 54837 RVA: 0x00337624 File Offset: 0x00335824
			// (set) Token: 0x0600D636 RID: 54838 RVA: 0x00067F45 File Offset: 0x00066145
			public unsafe static Il2CppSystem.Func<VehicleSeat, Player> __9__113_1
			{
				get
				{
					System.IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(LandVehicle.__c.NativeFieldInfoPtr___9__113_1, (void*)(&intPtr));
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Func<VehicleSeat, Player>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(LandVehicle.__c.NativeFieldInfoPtr___9__113_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004235 RID: 16949
			// (get) Token: 0x0600D637 RID: 54839 RVA: 0x0033764C File Offset: 0x0033584C
			// (set) Token: 0x0600D638 RID: 54840 RVA: 0x00067F57 File Offset: 0x00066157
			public unsafe static Il2CppSystem.Func<VehicleSeat, bool> __9__233_0
			{
				get
				{
					System.IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(LandVehicle.__c.NativeFieldInfoPtr___9__233_0, (void*)(&intPtr));
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Func<VehicleSeat, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(LandVehicle.__c.NativeFieldInfoPtr___9__233_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004236 RID: 16950
			// (get) Token: 0x0600D639 RID: 54841 RVA: 0x00337674 File Offset: 0x00335874
			// (set) Token: 0x0600D63A RID: 54842 RVA: 0x00067F69 File Offset: 0x00066169
			public unsafe static Il2CppSystem.Func<NPC, bool> __9__243_0
			{
				get
				{
					System.IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(LandVehicle.__c.NativeFieldInfoPtr___9__243_0, (void*)(&intPtr));
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Func<NPC, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(LandVehicle.__c.NativeFieldInfoPtr___9__243_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004237 RID: 16951
			// (get) Token: 0x0600D63B RID: 54843 RVA: 0x0033769C File Offset: 0x0033589C
			// (set) Token: 0x0600D63C RID: 54844 RVA: 0x00067F7B File Offset: 0x0006617B
			public unsafe static Il2CppSystem.Func<NPC, bool> __9__244_0
			{
				get
				{
					System.IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(LandVehicle.__c.NativeFieldInfoPtr___9__244_0, (void*)(&intPtr));
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Func<NPC, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(LandVehicle.__c.NativeFieldInfoPtr___9__244_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400908C RID: 37004
			private static readonly System.IntPtr NativeFieldInfoPtr___9;

			// Token: 0x0400908D RID: 37005
			private static readonly System.IntPtr NativeFieldInfoPtr___9__96_0;

			// Token: 0x0400908E RID: 37006
			private static readonly System.IntPtr NativeFieldInfoPtr___9__113_0;

			// Token: 0x0400908F RID: 37007
			private static readonly System.IntPtr NativeFieldInfoPtr___9__113_1;

			// Token: 0x04009090 RID: 37008
			private static readonly System.IntPtr NativeFieldInfoPtr___9__233_0;

			// Token: 0x04009091 RID: 37009
			private static readonly System.IntPtr NativeFieldInfoPtr___9__243_0;

			// Token: 0x04009092 RID: 37010
			private static readonly System.IntPtr NativeFieldInfoPtr___9__244_0;

			// Token: 0x04009093 RID: 37011
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009094 RID: 37012
			private static readonly System.IntPtr NativeMethodInfoPtr__get_CurrentPlayerOccupancy_b__96_0_Internal_Boolean_VehicleSeat_0;

			// Token: 0x04009095 RID: 37013
			private static readonly System.IntPtr NativeMethodInfoPtr__get_OccupantPlayers_b__113_0_Internal_Boolean_VehicleSeat_0;

			// Token: 0x04009096 RID: 37014
			private static readonly System.IntPtr NativeMethodInfoPtr__get_OccupantPlayers_b__113_1_Internal_Player_VehicleSeat_0;

			// Token: 0x04009097 RID: 37015
			private static readonly System.IntPtr NativeMethodInfoPtr__SetSeatOccupant_b__233_0_Internal_Boolean_VehicleSeat_0;

			// Token: 0x04009098 RID: 37016
			private static readonly System.IntPtr NativeMethodInfoPtr__AddNPCOccupant_b__243_0_Internal_Boolean_NPC_0;

			// Token: 0x04009099 RID: 37017
			private static readonly System.IntPtr NativeMethodInfoPtr__RemoveNPCOccupant_b__244_0_Internal_Boolean_NPC_0;
		}

		// Token: 0x02000AB5 RID: 2741
		[ObfuscatedName("ScheduleOne.Vehicles.LandVehicle+<>c__DisplayClass224_0")]
		public sealed class __c__DisplayClass224_0 : Il2CppSystem.Object
		{
			// Token: 0x0600D63D RID: 54845 RVA: 0x003376C4 File Offset: 0x003358C4
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass224_0()
			{
				Il2CppClassPointerStore<LandVehicle.__c__DisplayClass224_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LandVehicle>.NativeClassPtr, "<>c__DisplayClass224_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LandVehicle.__c__DisplayClass224_0>.NativeClassPtr);
				LandVehicle.__c__DisplayClass224_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandVehicle.__c__DisplayClass224_0>.NativeClassPtr, "<>4__this");
				LandVehicle.__c__DisplayClass224_0.NativeFieldInfoPtr_stat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandVehicle.__c__DisplayClass224_0>.NativeClassPtr, "stat");
				LandVehicle.__c__DisplayClass224_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle.__c__DisplayClass224_0>.NativeClassPtr, 100677626);
				LandVehicle.__c__DisplayClass224_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle.__c__DisplayClass224_0>.NativeClassPtr, 100677627);
			}

			// Token: 0x0600D63E RID: 54846 RVA: 0x00337740 File Offset: 0x00335940
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass224_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LandVehicle.__c__DisplayClass224_0>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.__c__DisplayClass224_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600D63F RID: 54847 RVA: 0x0033777C File Offset: 0x0033597C
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 221895, RefRangeEnd = 221896, XrefRangeStart = 221890, XrefRangeEnd = 221895, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator Method_Internal_IEnumerator_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.__c__DisplayClass224_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr2) : null;
			}

			// Token: 0x0600D640 RID: 54848 RVA: 0x00067F8D File Offset: 0x0006618D
			public __c__DisplayClass224_0(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004238 RID: 16952
			// (get) Token: 0x0600D641 RID: 54849 RVA: 0x003377BC File Offset: 0x003359BC
			// (set) Token: 0x0600D642 RID: 54850 RVA: 0x00067F96 File Offset: 0x00066196
			public unsafe LandVehicle __4__this
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.__c__DisplayClass224_0.NativeFieldInfoPtr___4__this);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<LandVehicle>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.__c__DisplayClass224_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004239 RID: 16953
			// (get) Token: 0x0600D643 RID: 54851 RVA: 0x003377EC File Offset: 0x003359EC
			// (set) Token: 0x0600D644 RID: 54852 RVA: 0x00067FB5 File Offset: 0x000661B5
			public unsafe bool stat
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.__c__DisplayClass224_0.NativeFieldInfoPtr_stat);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.__c__DisplayClass224_0.NativeFieldInfoPtr_stat)) = value;
				}
			}

			// Token: 0x0400909A RID: 37018
			private static readonly System.IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400909B RID: 37019
			private static readonly System.IntPtr NativeFieldInfoPtr_stat;

			// Token: 0x0400909C RID: 37020
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400909D RID: 37021
			private static readonly System.IntPtr NativeMethodInfoPtr_Method_Internal_IEnumerator_0;

			// Token: 0x02000CBB RID: 3259
			[ObfuscatedName("ScheduleOne.Vehicles.LandVehicle+<>c__DisplayClass224_0+<<DelaySetStatic>g__Wait|0>d")]
			public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique : Il2CppSystem.Object
			{
				// Token: 0x0600E99B RID: 59803 RVA: 0x0036ECD0 File Offset: 0x0036CED0
				// Note: this type is marked as 'beforefieldinit'.
				static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique()
				{
					Il2CppClassPointerStore<LandVehicle.__c__DisplayClass224_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LandVehicle.__c__DisplayClass224_0>.NativeClassPtr, "<<DelaySetStatic>g__Wait|0>d");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LandVehicle.__c__DisplayClass224_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr);
					LandVehicle.__c__DisplayClass224_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandVehicle.__c__DisplayClass224_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>1__state");
					LandVehicle.__c__DisplayClass224_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandVehicle.__c__DisplayClass224_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>2__current");
					LandVehicle.__c__DisplayClass224_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LandVehicle.__c__DisplayClass224_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>4__this");
					LandVehicle.__c__DisplayClass224_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle.__c__DisplayClass224_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100677628);
					LandVehicle.__c__DisplayClass224_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle.__c__DisplayClass224_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100677629);
					LandVehicle.__c__DisplayClass224_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle.__c__DisplayClass224_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100677630);
					LandVehicle.__c__DisplayClass224_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle.__c__DisplayClass224_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100677631);
					LandVehicle.__c__DisplayClass224_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle.__c__DisplayClass224_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100677632);
					LandVehicle.__c__DisplayClass224_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LandVehicle.__c__DisplayClass224_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100677633);
				}

				// Token: 0x0600E99C RID: 59804 RVA: 0x0036EDB0 File Offset: 0x0036CFB0
				[CallerCount(54)]
				[CachedScanResults(RefRangeStart = 2646, RefRangeEnd = 2700, XrefRangeStart = 2646, XrefRangeEnd = 2700, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LandVehicle.__c__DisplayClass224_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr))
				{
					System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
					*ptr = ref <>1__state;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.__c__DisplayClass224_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				}

				// Token: 0x0600E99D RID: 59805 RVA: 0x0036EDF8 File Offset: 0x0036CFF8
				[CallerCount(14558)]
				[CachedScanResults(RefRangeStart = 2769, RefRangeEnd = 17327, XrefRangeStart = 2769, XrefRangeEnd = 17327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.__c__DisplayClass224_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				}

				// Token: 0x0600E99E RID: 59806 RVA: 0x0036EE2C File Offset: 0x0036D02C
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 221880, XrefRangeEnd = 221885, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(LandVehicle.__c__DisplayClass224_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
					return *IL2CPP.il2cpp_object_unbox(obj);
				}

				// Token: 0x17004835 RID: 18485
				// (get) Token: 0x0600E99F RID: 59807 RVA: 0x0036EE68 File Offset: 0x0036D068
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(24)]
					[CachedScanResults(RefRangeStart = 2740, RefRangeEnd = 2764, XrefRangeStart = 2740, XrefRangeEnd = 2764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						System.IntPtr* param = null;
						System.IntPtr returnedException;
						System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.__c__DisplayClass224_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
						Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
						System.IntPtr intPtr2 = intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
				}

				// Token: 0x0600E9A0 RID: 59808 RVA: 0x0036EEA8 File Offset: 0x0036D0A8
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 221885, XrefRangeEnd = 221890, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.__c__DisplayClass224_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				}

				// Token: 0x17004836 RID: 18486
				// (get) Token: 0x0600E9A1 RID: 59809 RVA: 0x0036EEDC File Offset: 0x0036D0DC
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(24)]
					[CachedScanResults(RefRangeStart = 2740, RefRangeEnd = 2764, XrefRangeStart = 2740, XrefRangeEnd = 2764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						System.IntPtr* param = null;
						System.IntPtr returnedException;
						System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LandVehicle.__c__DisplayClass224_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
						Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
						System.IntPtr intPtr2 = intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
				}

				// Token: 0x0600E9A2 RID: 59810 RVA: 0x000718FA File Offset: 0x0006FAFA
				public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique(System.IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x17004832 RID: 18482
				// (get) Token: 0x0600E9A3 RID: 59811 RVA: 0x0036EF1C File Offset: 0x0036D11C
				// (set) Token: 0x0600E9A4 RID: 59812 RVA: 0x00071903 File Offset: 0x0006FB03
				public unsafe int __1__state
				{
					get
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.__c__DisplayClass224_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.__c__DisplayClass224_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x17004833 RID: 18483
				// (get) Token: 0x0600E9A5 RID: 59813 RVA: 0x0036EF44 File Offset: 0x0036D144
				// (set) Token: 0x0600E9A6 RID: 59814 RVA: 0x0007191E File Offset: 0x0006FB1E
				public unsafe Il2CppSystem.Object __2__current
				{
					get
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.__c__DisplayClass224_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current);
						System.IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
					set
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.__c__DisplayClass224_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17004834 RID: 18484
				// (get) Token: 0x0600E9A7 RID: 59815 RVA: 0x0036EF74 File Offset: 0x0036D174
				// (set) Token: 0x0600E9A8 RID: 59816 RVA: 0x0007193D File Offset: 0x0006FB3D
				public unsafe LandVehicle.__c__DisplayClass224_0 __4__this
				{
					get
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.__c__DisplayClass224_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this);
						System.IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<LandVehicle.__c__DisplayClass224_0>(intPtr2) : null;
					}
					set
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LandVehicle.__c__DisplayClass224_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x04009C55 RID: 40021
				private static readonly System.IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x04009C56 RID: 40022
				private static readonly System.IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x04009C57 RID: 40023
				private static readonly System.IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x04009C58 RID: 40024
				private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x04009C59 RID: 40025
				private static readonly System.IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x04009C5A RID: 40026
				private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x04009C5B RID: 40027
				private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x04009C5C RID: 40028
				private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x04009C5D RID: 40029
				private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
			}
		}
	}
}
