using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppPathfinding;
using Il2CppScheduleOne.DevUtilities;
using Il2CppScheduleOne.Math;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine;

namespace Il2CppScheduleOne.Vehicles.AI
{
	// Token: 0x0200052A RID: 1322
	public class VehicleAgent : MonoBehaviour
	{
		// Token: 0x0600733A RID: 29498 RVA: 0x001FB828 File Offset: 0x001F9A28
		// Note: this type is marked as 'beforefieldinit'.
		static VehicleAgent()
		{
			Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Vehicles.AI", "VehicleAgent");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr);
			VehicleAgent.NativeFieldInfoPtr_VehicleGraphName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, "VehicleGraphName");
			VehicleAgent.NativeFieldInfoPtr_RoadGraphName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, "RoadGraphName");
			VehicleAgent.NativeFieldInfoPtr_MaxDistanceFromPath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, "MaxDistanceFromPath");
			VehicleAgent.NativeFieldInfoPtr_MaxDistanceFromPathWhenReversing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, "MaxDistanceFromPathWhenReversing");
			VehicleAgent.NativeFieldInfoPtr_MainGraphSamplePoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, "MainGraphSamplePoint");
			VehicleAgent.NativeFieldInfoPtr_MinRenavigationRate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, "MinRenavigationRate");
			VehicleAgent.NativeFieldInfoPtr_Steer_P = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, "Steer_P");
			VehicleAgent.NativeFieldInfoPtr_Steer_I = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, "Steer_I");
			VehicleAgent.NativeFieldInfoPtr_Steer_D = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, "Steer_D");
			VehicleAgent.NativeFieldInfoPtr_Throttle_P = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, "Throttle_P");
			VehicleAgent.NativeFieldInfoPtr_Throttle_I = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, "Throttle_I");
			VehicleAgent.NativeFieldInfoPtr_Throttle_D = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, "Throttle_D");
			VehicleAgent.NativeFieldInfoPtr_Steer_Rate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, "Steer_Rate");
			VehicleAgent.NativeFieldInfoPtr_MaxAxlePositionShift = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, "MaxAxlePositionShift");
			VehicleAgent.NativeFieldInfoPtr_OBSTACLE_MIN_RANGE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, "OBSTACLE_MIN_RANGE");
			VehicleAgent.NativeFieldInfoPtr_OBSTACLE_MAX_RANGE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, "OBSTACLE_MAX_RANGE");
			VehicleAgent.NativeFieldInfoPtr_MAX_STEER_ANGLE_OVERRIDE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, "MAX_STEER_ANGLE_OVERRIDE");
			VehicleAgent.NativeFieldInfoPtr_KINEMATIC_MODE_MIN_DISTANCE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, "KINEMATIC_MODE_MIN_DISTANCE");
			VehicleAgent.NativeFieldInfoPtr_INFREQUENT_UPDATE_RATE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, "INFREQUENT_UPDATE_RATE");
			VehicleAgent.NativeFieldInfoPtr_DEBUG_MODE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, "DEBUG_MODE");
			VehicleAgent.NativeFieldInfoPtr__KinematicMode_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, "<KinematicMode>k__BackingField");
			VehicleAgent.NativeFieldInfoPtr__AutoDriving_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, "<AutoDriving>k__BackingField");
			VehicleAgent.NativeFieldInfoPtr__TargetLocation_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, "<TargetLocation>k__BackingField");
			VehicleAgent.NativeFieldInfoPtr_Flags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, "Flags");
			VehicleAgent.NativeFieldInfoPtr_roadSeeker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, "roadSeeker");
			VehicleAgent.NativeFieldInfoPtr_generalSeeker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, "generalSeeker");
			VehicleAgent.NativeFieldInfoPtr_CTE_Origin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, "CTE_Origin");
			VehicleAgent.NativeFieldInfoPtr_FrontAxlePosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, "FrontAxlePosition");
			VehicleAgent.NativeFieldInfoPtr_RearAxlePosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, "RearAxlePosition");
			VehicleAgent.NativeFieldInfoPtr_sensor_FL = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, "sensor_FL");
			VehicleAgent.NativeFieldInfoPtr_sensor_FM = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, "sensor_FM");
			VehicleAgent.NativeFieldInfoPtr_sensor_FR = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, "sensor_FR");
			VehicleAgent.NativeFieldInfoPtr_sensor_RR = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, "sensor_RR");
			VehicleAgent.NativeFieldInfoPtr_sensor_RL = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, "sensor_RL");
			VehicleAgent.NativeFieldInfoPtr_sweepMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, "sweepMask");
			VehicleAgent.NativeFieldInfoPtr_sweepOrigin_FL = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, "sweepOrigin_FL");
			VehicleAgent.NativeFieldInfoPtr_sweepOrigin_FR = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, "sweepOrigin_FR");
			VehicleAgent.NativeFieldInfoPtr_sweepOrigin_RL = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, "sweepOrigin_RL");
			VehicleAgent.NativeFieldInfoPtr_sweepOrigin_RR = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, "sweepOrigin_RR");
			VehicleAgent.NativeFieldInfoPtr_leftWheel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, "leftWheel");
			VehicleAgent.NativeFieldInfoPtr_rightWheel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, "rightWheel");
			VehicleAgent.NativeFieldInfoPtr_sweepSegment = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, "sweepSegment");
			VehicleAgent.NativeFieldInfoPtr_sampleStepSizeMin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, "sampleStepSizeMin");
			VehicleAgent.NativeFieldInfoPtr_sampleStepSizeMax = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, "sampleStepSizeMax");
			VehicleAgent.NativeFieldInfoPtr_aheadPointSamples = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, "aheadPointSamples");
			VehicleAgent.NativeFieldInfoPtr_DestinationDistanceSlowThreshold = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, "DestinationDistanceSlowThreshold");
			VehicleAgent.NativeFieldInfoPtr_DestinationArrivalThreshold = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, "DestinationArrivalThreshold");
			VehicleAgent.NativeFieldInfoPtr_steerTargetFollowRate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, "steerTargetFollowRate");
			VehicleAgent.NativeFieldInfoPtr_steerPID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, "steerPID");
			VehicleAgent.NativeFieldInfoPtr_turnSpeedReductionMinRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, "turnSpeedReductionMinRange");
			VehicleAgent.NativeFieldInfoPtr_turnSpeedReductionMaxRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, "turnSpeedReductionMaxRange");
			VehicleAgent.NativeFieldInfoPtr_turnSpeedReductionDivisor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, "turnSpeedReductionDivisor");
			VehicleAgent.NativeFieldInfoPtr_minTurnSpeedReductionAngleThreshold = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, "minTurnSpeedReductionAngleThreshold");
			VehicleAgent.NativeFieldInfoPtr_minTurningSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, "minTurningSpeed");
			VehicleAgent.NativeFieldInfoPtr_throttleMin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, "throttleMin");
			VehicleAgent.NativeFieldInfoPtr_throttleMax = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, "throttleMax");
			VehicleAgent.NativeFieldInfoPtr_throttlePID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, "throttlePID");
			VehicleAgent.NativeFieldInfoPtr_UnmarkedSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, "UnmarkedSpeed");
			VehicleAgent.NativeFieldInfoPtr_ReverseSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, "ReverseSpeed");
			VehicleAgent.NativeFieldInfoPtr_speedReductionTracker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, "speedReductionTracker");
			VehicleAgent.NativeFieldInfoPtr_PursuitModeEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, "PursuitModeEnabled");
			VehicleAgent.NativeFieldInfoPtr_PursuitTarget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, "PursuitTarget");
			VehicleAgent.NativeFieldInfoPtr_PursuitDistanceUpdateThreshold = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, "PursuitDistanceUpdateThreshold");
			VehicleAgent.NativeFieldInfoPtr_PursuitTargetLastPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, "PursuitTargetLastPosition");
			VehicleAgent.NativeFieldInfoPtr_Teleporter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, "Teleporter");
			VehicleAgent.NativeFieldInfoPtr_PositionHistoryTracker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, "PositionHistoryTracker");
			VehicleAgent.NativeFieldInfoPtr_StuckTimeThreshold = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, "StuckTimeThreshold");
			VehicleAgent.NativeFieldInfoPtr_StuckSamples = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, "StuckSamples");
			VehicleAgent.NativeFieldInfoPtr_StuckDistanceThreshold = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, "StuckDistanceThreshold");
			VehicleAgent.NativeFieldInfoPtr_storedNavigationCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, "storedNavigationCallback");
			VehicleAgent.NativeFieldInfoPtr_currentSpeedZone = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, "currentSpeedZone");
			VehicleAgent.NativeFieldInfoPtr_vehicle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, "vehicle");
			VehicleAgent.NativeFieldInfoPtr_wheelbase = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, "wheelbase");
			VehicleAgent.NativeFieldInfoPtr_wheeltrack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, "wheeltrack");
			VehicleAgent.NativeFieldInfoPtr_vehicleLength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, "vehicleLength");
			VehicleAgent.NativeFieldInfoPtr_vehicleWidth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, "vehicleWidth");
			VehicleAgent.NativeFieldInfoPtr_turnRadius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, "turnRadius");
			VehicleAgent.NativeFieldInfoPtr_sweepTrack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, "sweepTrack");
			VehicleAgent.NativeFieldInfoPtr_wheelBottomOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, "wheelBottomOffset");
			VehicleAgent.NativeFieldInfoPtr_targetSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, "targetSpeed");
			VehicleAgent.NativeFieldInfoPtr_targetSteerAngle_Normalized = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, "targetSteerAngle_Normalized");
			VehicleAgent.NativeFieldInfoPtr_lateralOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, "lateralOffset");
			VehicleAgent.NativeFieldInfoPtr_path = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, "path");
			VehicleAgent.NativeFieldInfoPtr_timeSinceLastNavigationCall = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, "timeSinceLastNavigationCall");
			VehicleAgent.NativeFieldInfoPtr_sweepTestFailedTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, "sweepTestFailedTime");
			VehicleAgent.NativeFieldInfoPtr_currentNavigationSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, "currentNavigationSettings");
			VehicleAgent.NativeFieldInfoPtr_navigationCalculationRoutine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, "navigationCalculationRoutine");
			VehicleAgent.NativeFieldInfoPtr_reverseCoroutine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, "reverseCoroutine");
			VehicleAgent.NativeMethodInfoPtr_get_KinematicMode_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, 100677875);
			VehicleAgent.NativeMethodInfoPtr_set_KinematicMode_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, 100677876);
			VehicleAgent.NativeMethodInfoPtr_get_AutoDriving_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, 100677877);
			VehicleAgent.NativeMethodInfoPtr_set_AutoDriving_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, 100677878);
			VehicleAgent.NativeMethodInfoPtr_get_IsReversing_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, 100677879);
			VehicleAgent.NativeMethodInfoPtr_get_TargetLocation_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, 100677880);
			VehicleAgent.NativeMethodInfoPtr_set_TargetLocation_Protected_set_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, 100677881);
			VehicleAgent.NativeMethodInfoPtr_get_sampleStepSize_Protected_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, 100677882);
			VehicleAgent.NativeMethodInfoPtr_get_turnSpeedReductionRange_Protected_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, 100677883);
			VehicleAgent.NativeMethodInfoPtr_get_maxSteerAngle_Protected_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, 100677884);
			VehicleAgent.NativeMethodInfoPtr_get_FrontOfVehiclePosition_Private_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, 100677885);
			VehicleAgent.NativeMethodInfoPtr_get_NavigationCalculationInProgress_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, 100677886);
			VehicleAgent.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, 100677887);
			VehicleAgent.NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, 100677888);
			VehicleAgent.NativeMethodInfoPtr_InitializeVehicleData_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, 100677889);
			VehicleAgent.NativeMethodInfoPtr_FixedUpdate_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, 100677890);
			VehicleAgent.NativeMethodInfoPtr_InfrequentUpdate_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, 100677891);
			VehicleAgent.NativeMethodInfoPtr_LateUpdate_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, 100677892);
			VehicleAgent.NativeMethodInfoPtr_UpdateKinematic_Protected_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, 100677893);
			VehicleAgent.NativeMethodInfoPtr_GetAxleGroundHit_Private_Vector3_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, 100677894);
			VehicleAgent.NativeMethodInfoPtr_UpdateSweep_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, 100677895);
			VehicleAgent.NativeMethodInfoPtr_UpdateSpeedReduction_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, 100677896);
			VehicleAgent.NativeMethodInfoPtr_UpdatePursuitMode_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, 100677897);
			VehicleAgent.NativeMethodInfoPtr_UpdateStuckDetection_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, 100677898);
			VehicleAgent.NativeMethodInfoPtr_CheckDistanceFromPath_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, 100677899);
			VehicleAgent.NativeMethodInfoPtr_UpdateOvertaking_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, 100677900);
			VehicleAgent.NativeMethodInfoPtr_RefreshSpeedZone_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, 100677901);
			VehicleAgent.NativeMethodInfoPtr_UpdateSpeed_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, 100677902);
			VehicleAgent.NativeMethodInfoPtr_UpdateSteering_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, 100677903);
			VehicleAgent.NativeMethodInfoPtr_Navigate_Public_Void_Vector3_NavigationSettings_NavigationCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, 100677904);
			VehicleAgent.NativeMethodInfoPtr_NavigationCalculationCallback_Private_Void_ENavigationCalculationResult_SmoothedPath_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, 100677905);
			VehicleAgent.NativeMethodInfoPtr_EndDriving_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, 100677906);
			VehicleAgent.NativeMethodInfoPtr_StopNavigating_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, 100677907);
			VehicleAgent.NativeMethodInfoPtr_RecalculateNavigation_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, 100677908);
			VehicleAgent.NativeMethodInfoPtr_SweepTurn_Public_Boolean_ESweepType_Single_Boolean_byref_Single_byref_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, 100677909);
			VehicleAgent.NativeMethodInfoPtr_BetterSweepTurn_Public_Void_ESweepType_Single_Boolean_LayerMask_byref_Single_byref_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, 100677910);
			VehicleAgent.NativeMethodInfoPtr_StartReverse_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, 100677911);
			VehicleAgent.NativeMethodInfoPtr_Reverse_Public_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, 100677912);
			VehicleAgent.NativeMethodInfoPtr_StopReversing_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, 100677913);
			VehicleAgent.NativeMethodInfoPtr_GetClosestForwardObstruction_Private_Collider_byref_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, 100677914);
			VehicleAgent.NativeMethodInfoPtr_IsOnVehicleGraph_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, 100677915);
			VehicleAgent.NativeMethodInfoPtr_GetDistanceFromVehicleGraph_Private_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, 100677916);
			VehicleAgent.NativeMethodInfoPtr_GetPathLateralDirection_Private_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, 100677917);
			VehicleAgent.NativeMethodInfoPtr_GetIsStuck_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, 100677918);
			VehicleAgent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, 100677919);
			VehicleAgent.NativeMethodInfoPtr__Reverse_b__139_0_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, 100677921);
		}

		// Token: 0x170022F7 RID: 8951
		// (get) Token: 0x0600733B RID: 29499 RVA: 0x001FC2D0 File Offset: 0x001FA4D0
		// (set) Token: 0x0600733C RID: 29500 RVA: 0x001FC30C File Offset: 0x001FA50C
		public unsafe bool KinematicMode
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(VehicleAgent.NativeMethodInfoPtr_get_KinematicMode_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
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
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleAgent.NativeMethodInfoPtr_set_KinematicMode_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x170022F8 RID: 8952
		// (get) Token: 0x0600733D RID: 29501 RVA: 0x001FC34C File Offset: 0x001FA54C
		// (set) Token: 0x0600733E RID: 29502 RVA: 0x001FC388 File Offset: 0x001FA588
		public unsafe bool AutoDriving
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(VehicleAgent.NativeMethodInfoPtr_get_AutoDriving_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
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
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleAgent.NativeMethodInfoPtr_set_AutoDriving_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x170022F9 RID: 8953
		// (get) Token: 0x0600733F RID: 29503 RVA: 0x001FC3C8 File Offset: 0x001FA5C8
		public unsafe bool IsReversing
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(VehicleAgent.NativeMethodInfoPtr_get_IsReversing_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
		}

		// Token: 0x170022FA RID: 8954
		// (get) Token: 0x06007340 RID: 29504 RVA: 0x001FC404 File Offset: 0x001FA604
		// (set) Token: 0x06007341 RID: 29505 RVA: 0x001FC440 File Offset: 0x001FA640
		public unsafe Vector3 TargetLocation
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(VehicleAgent.NativeMethodInfoPtr_get_TargetLocation_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
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
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleAgent.NativeMethodInfoPtr_set_TargetLocation_Protected_set_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x170022FB RID: 8955
		// (get) Token: 0x06007342 RID: 29506 RVA: 0x001FC480 File Offset: 0x001FA680
		public unsafe float sampleStepSize
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 226574, RefRangeEnd = 226576, XrefRangeStart = 226573, XrefRangeEnd = 226574, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(VehicleAgent.NativeMethodInfoPtr_get_sampleStepSize_Protected_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
		}

		// Token: 0x170022FC RID: 8956
		// (get) Token: 0x06007343 RID: 29507 RVA: 0x001FC4BC File Offset: 0x001FA6BC
		public unsafe float turnSpeedReductionRange
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 226576, XrefRangeEnd = 226577, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(VehicleAgent.NativeMethodInfoPtr_get_turnSpeedReductionRange_Protected_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
		}

		// Token: 0x170022FD RID: 8957
		// (get) Token: 0x06007344 RID: 29508 RVA: 0x001FC4F8 File Offset: 0x001FA6F8
		public unsafe float maxSteerAngle
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 226577, XrefRangeEnd = 226579, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(VehicleAgent.NativeMethodInfoPtr_get_maxSteerAngle_Protected_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
		}

		// Token: 0x170022FE RID: 8958
		// (get) Token: 0x06007345 RID: 29509 RVA: 0x001FC534 File Offset: 0x001FA734
		public unsafe Vector3 FrontOfVehiclePosition
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 226579, XrefRangeEnd = 226583, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(VehicleAgent.NativeMethodInfoPtr_get_FrontOfVehiclePosition_Private_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
		}

		// Token: 0x170022FF RID: 8959
		// (get) Token: 0x06007346 RID: 29510 RVA: 0x001FC570 File Offset: 0x001FA770
		public unsafe bool NavigationCalculationInProgress
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 226583, RefRangeEnd = 226584, XrefRangeStart = 226583, XrefRangeEnd = 226583, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(VehicleAgent.NativeMethodInfoPtr_get_NavigationCalculationInProgress_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
		}

		// Token: 0x06007347 RID: 29511 RVA: 0x001FC5AC File Offset: 0x001FA7AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 226584, XrefRangeEnd = 226603, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleAgent.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007348 RID: 29512 RVA: 0x001FC5E0 File Offset: 0x001FA7E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 226603, XrefRangeEnd = 226613, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VehicleAgent.NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007349 RID: 29513 RVA: 0x001FC61C File Offset: 0x001FA81C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 226699, RefRangeEnd = 226700, XrefRangeStart = 226613, XrefRangeEnd = 226699, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InitializeVehicleData()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleAgent.NativeMethodInfoPtr_InitializeVehicleData_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600734A RID: 29514 RVA: 0x001FC650 File Offset: 0x001FA850
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 226700, XrefRangeEnd = 226732, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void FixedUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VehicleAgent.NativeMethodInfoPtr_FixedUpdate_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600734B RID: 29515 RVA: 0x001FC68C File Offset: 0x001FA88C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 226732, XrefRangeEnd = 226761, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InfrequentUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleAgent.NativeMethodInfoPtr_InfrequentUpdate_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600734C RID: 29516 RVA: 0x001FC6C0 File Offset: 0x001FA8C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 226761, XrefRangeEnd = 226775, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LateUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleAgent.NativeMethodInfoPtr_LateUpdate_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600734D RID: 29517 RVA: 0x001FC6F4 File Offset: 0x001FA8F4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 226867, RefRangeEnd = 226868, XrefRangeStart = 226775, XrefRangeEnd = 226867, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateKinematic(float deltaTime)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref deltaTime;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleAgent.NativeMethodInfoPtr_UpdateKinematic_Protected_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600734E RID: 29518 RVA: 0x001FC734 File Offset: 0x001FA934
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 226924, RefRangeEnd = 226926, XrefRangeStart = 226868, XrefRangeEnd = 226924, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector3 GetAxleGroundHit(bool front)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref front;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(VehicleAgent.NativeMethodInfoPtr_GetAxleGroundHit_Private_Vector3_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x0600734F RID: 29519 RVA: 0x001FC780 File Offset: 0x001FA980
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 226941, RefRangeEnd = 226942, XrefRangeStart = 226926, XrefRangeEnd = 226941, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateSweep()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleAgent.NativeMethodInfoPtr_UpdateSweep_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007350 RID: 29520 RVA: 0x001FC7B4 File Offset: 0x001FA9B4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 226963, RefRangeEnd = 226964, XrefRangeStart = 226942, XrefRangeEnd = 226963, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateSpeedReduction()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleAgent.NativeMethodInfoPtr_UpdateSpeedReduction_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007351 RID: 29521 RVA: 0x001FC7E8 File Offset: 0x001FA9E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 226964, XrefRangeEnd = 226977, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdatePursuitMode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleAgent.NativeMethodInfoPtr_UpdatePursuitMode_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007352 RID: 29522 RVA: 0x001FC81C File Offset: 0x001FAA1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 226977, XrefRangeEnd = 227001, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateStuckDetection()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleAgent.NativeMethodInfoPtr_UpdateStuckDetection_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007353 RID: 29523 RVA: 0x001FC850 File Offset: 0x001FAA50
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 227030, RefRangeEnd = 227031, XrefRangeStart = 227001, XrefRangeEnd = 227030, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CheckDistanceFromPath()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleAgent.NativeMethodInfoPtr_CheckDistanceFromPath_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007354 RID: 29524 RVA: 0x001FC884 File Offset: 0x001FAA84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 227031, XrefRangeEnd = 227041, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateOvertaking()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleAgent.NativeMethodInfoPtr_UpdateOvertaking_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007355 RID: 29525 RVA: 0x001FC8B8 File Offset: 0x001FAAB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 227041, XrefRangeEnd = 227081, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void RefreshSpeedZone()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VehicleAgent.NativeMethodInfoPtr_RefreshSpeedZone_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007356 RID: 29526 RVA: 0x001FC8F4 File Offset: 0x001FAAF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 227081, XrefRangeEnd = 227090, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void UpdateSpeed()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VehicleAgent.NativeMethodInfoPtr_UpdateSpeed_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007357 RID: 29527 RVA: 0x001FC930 File Offset: 0x001FAB30
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 227146, RefRangeEnd = 227147, XrefRangeStart = 227090, XrefRangeEnd = 227146, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateSteering()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleAgent.NativeMethodInfoPtr_UpdateSteering_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007358 RID: 29528 RVA: 0x001FC964 File Offset: 0x001FAB64
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 227171, RefRangeEnd = 227177, XrefRangeStart = 227147, XrefRangeEnd = 227171, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Navigate(Vector3 location, NavigationSettings settings = null, VehicleAgent.NavigationCallback callback = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref location;
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(settings);
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleAgent.NativeMethodInfoPtr_Navigate_Public_Void_Vector3_NavigationSettings_NavigationCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007359 RID: 29529 RVA: 0x001FC9C8 File Offset: 0x001FABC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 227177, XrefRangeEnd = 227182, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void NavigationCalculationCallback(NavigationUtility.ENavigationCalculationResult result, PathSmoothingUtility.SmoothedPath _path)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref result;
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(_path);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleAgent.NativeMethodInfoPtr_NavigationCalculationCallback_Private_Void_ENavigationCalculationResult_SmoothedPath_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600735A RID: 29530 RVA: 0x001FCA18 File Offset: 0x001FAC18
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 227187, RefRangeEnd = 227189, XrefRangeStart = 227182, XrefRangeEnd = 227187, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EndDriving()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleAgent.NativeMethodInfoPtr_EndDriving_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600735B RID: 29531 RVA: 0x001FCA4C File Offset: 0x001FAC4C
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 227191, RefRangeEnd = 227196, XrefRangeStart = 227189, XrefRangeEnd = 227191, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StopNavigating()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleAgent.NativeMethodInfoPtr_StopNavigating_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600735C RID: 29532 RVA: 0x001FCA80 File Offset: 0x001FAC80
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 227197, RefRangeEnd = 227198, XrefRangeStart = 227196, XrefRangeEnd = 227197, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RecalculateNavigation()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleAgent.NativeMethodInfoPtr_RecalculateNavigation_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600735D RID: 29533 RVA: 0x001FCAB4 File Offset: 0x001FACB4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 227278, RefRangeEnd = 227280, XrefRangeStart = 227198, XrefRangeEnd = 227278, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool SweepTurn(VehicleAgent.ESweepType sweep, float sweepAngle, bool reverse, out float hitDistance, out Vector3 hitPoint, float steerAngle = 0f)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)6) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref sweep;
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref sweepAngle;
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref reverse;
			ptr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = &hitDistance;
			ptr[checked(unchecked((System.UIntPtr)4) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = &hitPoint;
			ptr[checked(unchecked((System.UIntPtr)5) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref steerAngle;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(VehicleAgent.NativeMethodInfoPtr_SweepTurn_Public_Boolean_ESweepType_Single_Boolean_byref_Single_byref_Vector3_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x0600735E RID: 29534 RVA: 0x001FCB48 File Offset: 0x001FAD48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 227280, XrefRangeEnd = 227414, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void BetterSweepTurn(VehicleAgent.ESweepType sweep, float steerAngle, bool reverse, LayerMask mask, out float hitDistance, out Vector3 hitPoint)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)6) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref sweep;
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref steerAngle;
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref reverse;
			ptr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref mask;
			ptr[checked(unchecked((System.UIntPtr)4) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = &hitDistance;
			ptr[checked(unchecked((System.UIntPtr)5) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = &hitPoint;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleAgent.NativeMethodInfoPtr_BetterSweepTurn_Public_Void_ESweepType_Single_Boolean_LayerMask_byref_Single_byref_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600735F RID: 29535 RVA: 0x001FCBD0 File Offset: 0x001FADD0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 227414, XrefRangeEnd = 227423, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StartReverse()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleAgent.NativeMethodInfoPtr_StartReverse_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007360 RID: 29536 RVA: 0x001FCC04 File Offset: 0x001FAE04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 227423, XrefRangeEnd = 227428, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator Reverse()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleAgent.NativeMethodInfoPtr_Reverse_Public_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr2) : null;
		}

		// Token: 0x06007361 RID: 29537 RVA: 0x001FCC44 File Offset: 0x001FAE44
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 227436, RefRangeEnd = 227439, XrefRangeStart = 227428, XrefRangeEnd = 227436, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StopReversing()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleAgent.NativeMethodInfoPtr_StopReversing_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007362 RID: 29538 RVA: 0x001FCC78 File Offset: 0x001FAE78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 227439, XrefRangeEnd = 227497, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Collider GetClosestForwardObstruction(out float obstructionDist)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = &obstructionDist;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleAgent.NativeMethodInfoPtr_GetClosestForwardObstruction_Private_Collider_byref_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Collider>(intPtr2) : null;
		}

		// Token: 0x06007363 RID: 29539 RVA: 0x001FCCC4 File Offset: 0x001FAEC4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 227498, RefRangeEnd = 227500, XrefRangeStart = 227497, XrefRangeEnd = 227498, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsOnVehicleGraph()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(VehicleAgent.NativeMethodInfoPtr_IsOnVehicleGraph_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06007364 RID: 29540 RVA: 0x001FCD00 File Offset: 0x001FAF00
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 227524, RefRangeEnd = 227527, XrefRangeStart = 227500, XrefRangeEnd = 227524, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float GetDistanceFromVehicleGraph()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(VehicleAgent.NativeMethodInfoPtr_GetDistanceFromVehicleGraph_Private_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06007365 RID: 29541 RVA: 0x001FCD3C File Offset: 0x001FAF3C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 227538, RefRangeEnd = 227539, XrefRangeStart = 227527, XrefRangeEnd = 227538, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector3 GetPathLateralDirection()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(VehicleAgent.NativeMethodInfoPtr_GetPathLateralDirection_Private_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06007366 RID: 29542 RVA: 0x001FCD78 File Offset: 0x001FAF78
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 227558, RefRangeEnd = 227560, XrefRangeStart = 227539, XrefRangeEnd = 227558, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool GetIsStuck()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(VehicleAgent.NativeMethodInfoPtr_GetIsStuck_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06007367 RID: 29543 RVA: 0x001FCDB4 File Offset: 0x001FAFB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 227560, XrefRangeEnd = 227565, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe VehicleAgent() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleAgent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007368 RID: 29544 RVA: 0x001FCDF0 File Offset: 0x001FAFF0
		[CallerCount(0)]
		public unsafe bool _Reverse_b__139_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(VehicleAgent.NativeMethodInfoPtr__Reverse_b__139_0_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06007369 RID: 29545 RVA: 0x000367F5 File Offset: 0x000349F5
		public VehicleAgent(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700229F RID: 8863
		// (get) Token: 0x0600736A RID: 29546 RVA: 0x001FCE2C File Offset: 0x001FB02C
		// (set) Token: 0x0600736B RID: 29547 RVA: 0x000367FE File Offset: 0x000349FE
		public unsafe static string VehicleGraphName
		{
			get
			{
				System.IntPtr il2CppString;
				IL2CPP.il2cpp_field_static_get_value(VehicleAgent.NativeFieldInfoPtr_VehicleGraphName, (void*)(&il2CppString));
				return IL2CPP.Il2CppStringToManaged(il2CppString);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(VehicleAgent.NativeFieldInfoPtr_VehicleGraphName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170022A0 RID: 8864
		// (get) Token: 0x0600736C RID: 29548 RVA: 0x001FCE4C File Offset: 0x001FB04C
		// (set) Token: 0x0600736D RID: 29549 RVA: 0x00036810 File Offset: 0x00034A10
		public unsafe static string RoadGraphName
		{
			get
			{
				System.IntPtr il2CppString;
				IL2CPP.il2cpp_field_static_get_value(VehicleAgent.NativeFieldInfoPtr_RoadGraphName, (void*)(&il2CppString));
				return IL2CPP.Il2CppStringToManaged(il2CppString);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(VehicleAgent.NativeFieldInfoPtr_RoadGraphName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170022A1 RID: 8865
		// (get) Token: 0x0600736E RID: 29550 RVA: 0x001FCE6C File Offset: 0x001FB06C
		// (set) Token: 0x0600736F RID: 29551 RVA: 0x00036822 File Offset: 0x00034A22
		public unsafe static float MaxDistanceFromPath
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(VehicleAgent.NativeFieldInfoPtr_MaxDistanceFromPath, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(VehicleAgent.NativeFieldInfoPtr_MaxDistanceFromPath, (void*)(&value));
			}
		}

		// Token: 0x170022A2 RID: 8866
		// (get) Token: 0x06007370 RID: 29552 RVA: 0x001FCE88 File Offset: 0x001FB088
		// (set) Token: 0x06007371 RID: 29553 RVA: 0x00036830 File Offset: 0x00034A30
		public unsafe static float MaxDistanceFromPathWhenReversing
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(VehicleAgent.NativeFieldInfoPtr_MaxDistanceFromPathWhenReversing, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(VehicleAgent.NativeFieldInfoPtr_MaxDistanceFromPathWhenReversing, (void*)(&value));
			}
		}

		// Token: 0x170022A3 RID: 8867
		// (get) Token: 0x06007372 RID: 29554 RVA: 0x001FCEA4 File Offset: 0x001FB0A4
		// (set) Token: 0x06007373 RID: 29555 RVA: 0x0003683E File Offset: 0x00034A3E
		public unsafe static Vector3 MainGraphSamplePoint
		{
			get
			{
				Vector3 result;
				IL2CPP.il2cpp_field_static_get_value(VehicleAgent.NativeFieldInfoPtr_MainGraphSamplePoint, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(VehicleAgent.NativeFieldInfoPtr_MainGraphSamplePoint, (void*)(&value));
			}
		}

		// Token: 0x170022A4 RID: 8868
		// (get) Token: 0x06007374 RID: 29556 RVA: 0x001FCEC0 File Offset: 0x001FB0C0
		// (set) Token: 0x06007375 RID: 29557 RVA: 0x0003684C File Offset: 0x00034A4C
		public unsafe static float MinRenavigationRate
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(VehicleAgent.NativeFieldInfoPtr_MinRenavigationRate, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(VehicleAgent.NativeFieldInfoPtr_MinRenavigationRate, (void*)(&value));
			}
		}

		// Token: 0x170022A5 RID: 8869
		// (get) Token: 0x06007376 RID: 29558 RVA: 0x001FCEDC File Offset: 0x001FB0DC
		// (set) Token: 0x06007377 RID: 29559 RVA: 0x0003685A File Offset: 0x00034A5A
		public unsafe static float Steer_P
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(VehicleAgent.NativeFieldInfoPtr_Steer_P, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(VehicleAgent.NativeFieldInfoPtr_Steer_P, (void*)(&value));
			}
		}

		// Token: 0x170022A6 RID: 8870
		// (get) Token: 0x06007378 RID: 29560 RVA: 0x001FCEF8 File Offset: 0x001FB0F8
		// (set) Token: 0x06007379 RID: 29561 RVA: 0x00036868 File Offset: 0x00034A68
		public unsafe static float Steer_I
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(VehicleAgent.NativeFieldInfoPtr_Steer_I, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(VehicleAgent.NativeFieldInfoPtr_Steer_I, (void*)(&value));
			}
		}

		// Token: 0x170022A7 RID: 8871
		// (get) Token: 0x0600737A RID: 29562 RVA: 0x001FCF14 File Offset: 0x001FB114
		// (set) Token: 0x0600737B RID: 29563 RVA: 0x00036876 File Offset: 0x00034A76
		public unsafe static float Steer_D
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(VehicleAgent.NativeFieldInfoPtr_Steer_D, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(VehicleAgent.NativeFieldInfoPtr_Steer_D, (void*)(&value));
			}
		}

		// Token: 0x170022A8 RID: 8872
		// (get) Token: 0x0600737C RID: 29564 RVA: 0x001FCF30 File Offset: 0x001FB130
		// (set) Token: 0x0600737D RID: 29565 RVA: 0x00036884 File Offset: 0x00034A84
		public unsafe static float Throttle_P
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(VehicleAgent.NativeFieldInfoPtr_Throttle_P, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(VehicleAgent.NativeFieldInfoPtr_Throttle_P, (void*)(&value));
			}
		}

		// Token: 0x170022A9 RID: 8873
		// (get) Token: 0x0600737E RID: 29566 RVA: 0x001FCF4C File Offset: 0x001FB14C
		// (set) Token: 0x0600737F RID: 29567 RVA: 0x00036892 File Offset: 0x00034A92
		public unsafe static float Throttle_I
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(VehicleAgent.NativeFieldInfoPtr_Throttle_I, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(VehicleAgent.NativeFieldInfoPtr_Throttle_I, (void*)(&value));
			}
		}

		// Token: 0x170022AA RID: 8874
		// (get) Token: 0x06007380 RID: 29568 RVA: 0x001FCF68 File Offset: 0x001FB168
		// (set) Token: 0x06007381 RID: 29569 RVA: 0x000368A0 File Offset: 0x00034AA0
		public unsafe static float Throttle_D
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(VehicleAgent.NativeFieldInfoPtr_Throttle_D, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(VehicleAgent.NativeFieldInfoPtr_Throttle_D, (void*)(&value));
			}
		}

		// Token: 0x170022AB RID: 8875
		// (get) Token: 0x06007382 RID: 29570 RVA: 0x001FCF84 File Offset: 0x001FB184
		// (set) Token: 0x06007383 RID: 29571 RVA: 0x000368AE File Offset: 0x00034AAE
		public unsafe static float Steer_Rate
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(VehicleAgent.NativeFieldInfoPtr_Steer_Rate, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(VehicleAgent.NativeFieldInfoPtr_Steer_Rate, (void*)(&value));
			}
		}

		// Token: 0x170022AC RID: 8876
		// (get) Token: 0x06007384 RID: 29572 RVA: 0x001FCFA0 File Offset: 0x001FB1A0
		// (set) Token: 0x06007385 RID: 29573 RVA: 0x000368BC File Offset: 0x00034ABC
		public unsafe static float MaxAxlePositionShift
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(VehicleAgent.NativeFieldInfoPtr_MaxAxlePositionShift, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(VehicleAgent.NativeFieldInfoPtr_MaxAxlePositionShift, (void*)(&value));
			}
		}

		// Token: 0x170022AD RID: 8877
		// (get) Token: 0x06007386 RID: 29574 RVA: 0x001FCFBC File Offset: 0x001FB1BC
		// (set) Token: 0x06007387 RID: 29575 RVA: 0x000368CA File Offset: 0x00034ACA
		public unsafe static float OBSTACLE_MIN_RANGE
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(VehicleAgent.NativeFieldInfoPtr_OBSTACLE_MIN_RANGE, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(VehicleAgent.NativeFieldInfoPtr_OBSTACLE_MIN_RANGE, (void*)(&value));
			}
		}

		// Token: 0x170022AE RID: 8878
		// (get) Token: 0x06007388 RID: 29576 RVA: 0x001FCFD8 File Offset: 0x001FB1D8
		// (set) Token: 0x06007389 RID: 29577 RVA: 0x000368D8 File Offset: 0x00034AD8
		public unsafe static float OBSTACLE_MAX_RANGE
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(VehicleAgent.NativeFieldInfoPtr_OBSTACLE_MAX_RANGE, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(VehicleAgent.NativeFieldInfoPtr_OBSTACLE_MAX_RANGE, (void*)(&value));
			}
		}

		// Token: 0x170022AF RID: 8879
		// (get) Token: 0x0600738A RID: 29578 RVA: 0x001FCFF4 File Offset: 0x001FB1F4
		// (set) Token: 0x0600738B RID: 29579 RVA: 0x000368E6 File Offset: 0x00034AE6
		public unsafe static float MAX_STEER_ANGLE_OVERRIDE
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(VehicleAgent.NativeFieldInfoPtr_MAX_STEER_ANGLE_OVERRIDE, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(VehicleAgent.NativeFieldInfoPtr_MAX_STEER_ANGLE_OVERRIDE, (void*)(&value));
			}
		}

		// Token: 0x170022B0 RID: 8880
		// (get) Token: 0x0600738C RID: 29580 RVA: 0x001FD010 File Offset: 0x001FB210
		// (set) Token: 0x0600738D RID: 29581 RVA: 0x000368F4 File Offset: 0x00034AF4
		public unsafe static float KINEMATIC_MODE_MIN_DISTANCE
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(VehicleAgent.NativeFieldInfoPtr_KINEMATIC_MODE_MIN_DISTANCE, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(VehicleAgent.NativeFieldInfoPtr_KINEMATIC_MODE_MIN_DISTANCE, (void*)(&value));
			}
		}

		// Token: 0x170022B1 RID: 8881
		// (get) Token: 0x0600738E RID: 29582 RVA: 0x001FD02C File Offset: 0x001FB22C
		// (set) Token: 0x0600738F RID: 29583 RVA: 0x00036902 File Offset: 0x00034B02
		public unsafe static float INFREQUENT_UPDATE_RATE
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(VehicleAgent.NativeFieldInfoPtr_INFREQUENT_UPDATE_RATE, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(VehicleAgent.NativeFieldInfoPtr_INFREQUENT_UPDATE_RATE, (void*)(&value));
			}
		}

		// Token: 0x170022B2 RID: 8882
		// (get) Token: 0x06007390 RID: 29584 RVA: 0x001FD048 File Offset: 0x001FB248
		// (set) Token: 0x06007391 RID: 29585 RVA: 0x00036910 File Offset: 0x00034B10
		public unsafe bool DEBUG_MODE
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_DEBUG_MODE);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_DEBUG_MODE)) = value;
			}
		}

		// Token: 0x170022B3 RID: 8883
		// (get) Token: 0x06007392 RID: 29586 RVA: 0x001FD070 File Offset: 0x001FB270
		// (set) Token: 0x06007393 RID: 29587 RVA: 0x0003692B File Offset: 0x00034B2B
		public unsafe bool _KinematicMode_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr__KinematicMode_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr__KinematicMode_k__BackingField)) = value;
			}
		}

		// Token: 0x170022B4 RID: 8884
		// (get) Token: 0x06007394 RID: 29588 RVA: 0x001FD098 File Offset: 0x001FB298
		// (set) Token: 0x06007395 RID: 29589 RVA: 0x00036946 File Offset: 0x00034B46
		public unsafe bool _AutoDriving_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr__AutoDriving_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr__AutoDriving_k__BackingField)) = value;
			}
		}

		// Token: 0x170022B5 RID: 8885
		// (get) Token: 0x06007396 RID: 29590 RVA: 0x001FD0C0 File Offset: 0x001FB2C0
		// (set) Token: 0x06007397 RID: 29591 RVA: 0x00036961 File Offset: 0x00034B61
		public unsafe Vector3 _TargetLocation_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr__TargetLocation_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr__TargetLocation_k__BackingField)) = value;
			}
		}

		// Token: 0x170022B6 RID: 8886
		// (get) Token: 0x06007398 RID: 29592 RVA: 0x001FD0E8 File Offset: 0x001FB2E8
		// (set) Token: 0x06007399 RID: 29593 RVA: 0x0003697C File Offset: 0x00034B7C
		public unsafe DriveFlags Flags
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_Flags);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DriveFlags>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_Flags), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170022B7 RID: 8887
		// (get) Token: 0x0600739A RID: 29594 RVA: 0x001FD118 File Offset: 0x001FB318
		// (set) Token: 0x0600739B RID: 29595 RVA: 0x0003699B File Offset: 0x00034B9B
		public unsafe Seeker roadSeeker
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_roadSeeker);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Seeker>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_roadSeeker), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170022B8 RID: 8888
		// (get) Token: 0x0600739C RID: 29596 RVA: 0x001FD148 File Offset: 0x001FB348
		// (set) Token: 0x0600739D RID: 29597 RVA: 0x000369BA File Offset: 0x00034BBA
		public unsafe Seeker generalSeeker
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_generalSeeker);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Seeker>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_generalSeeker), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170022B9 RID: 8889
		// (get) Token: 0x0600739E RID: 29598 RVA: 0x001FD178 File Offset: 0x001FB378
		// (set) Token: 0x0600739F RID: 29599 RVA: 0x000369D9 File Offset: 0x00034BD9
		public unsafe Transform CTE_Origin
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_CTE_Origin);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_CTE_Origin), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170022BA RID: 8890
		// (get) Token: 0x060073A0 RID: 29600 RVA: 0x001FD1A8 File Offset: 0x001FB3A8
		// (set) Token: 0x060073A1 RID: 29601 RVA: 0x000369F8 File Offset: 0x00034BF8
		public unsafe Transform FrontAxlePosition
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_FrontAxlePosition);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_FrontAxlePosition), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170022BB RID: 8891
		// (get) Token: 0x060073A2 RID: 29602 RVA: 0x001FD1D8 File Offset: 0x001FB3D8
		// (set) Token: 0x060073A3 RID: 29603 RVA: 0x00036A17 File Offset: 0x00034C17
		public unsafe Transform RearAxlePosition
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_RearAxlePosition);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_RearAxlePosition), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170022BC RID: 8892
		// (get) Token: 0x060073A4 RID: 29604 RVA: 0x001FD208 File Offset: 0x001FB408
		// (set) Token: 0x060073A5 RID: 29605 RVA: 0x00036A36 File Offset: 0x00034C36
		public unsafe Sensor sensor_FL
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_sensor_FL);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sensor>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_sensor_FL), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170022BD RID: 8893
		// (get) Token: 0x060073A6 RID: 29606 RVA: 0x001FD238 File Offset: 0x001FB438
		// (set) Token: 0x060073A7 RID: 29607 RVA: 0x00036A55 File Offset: 0x00034C55
		public unsafe Sensor sensor_FM
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_sensor_FM);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sensor>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_sensor_FM), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170022BE RID: 8894
		// (get) Token: 0x060073A8 RID: 29608 RVA: 0x001FD268 File Offset: 0x001FB468
		// (set) Token: 0x060073A9 RID: 29609 RVA: 0x00036A74 File Offset: 0x00034C74
		public unsafe Sensor sensor_FR
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_sensor_FR);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sensor>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_sensor_FR), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170022BF RID: 8895
		// (get) Token: 0x060073AA RID: 29610 RVA: 0x001FD298 File Offset: 0x001FB498
		// (set) Token: 0x060073AB RID: 29611 RVA: 0x00036A93 File Offset: 0x00034C93
		public unsafe Sensor sensor_RR
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_sensor_RR);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sensor>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_sensor_RR), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170022C0 RID: 8896
		// (get) Token: 0x060073AC RID: 29612 RVA: 0x001FD2C8 File Offset: 0x001FB4C8
		// (set) Token: 0x060073AD RID: 29613 RVA: 0x00036AB2 File Offset: 0x00034CB2
		public unsafe Sensor sensor_RL
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_sensor_RL);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sensor>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_sensor_RL), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170022C1 RID: 8897
		// (get) Token: 0x060073AE RID: 29614 RVA: 0x001FD2F8 File Offset: 0x001FB4F8
		// (set) Token: 0x060073AF RID: 29615 RVA: 0x00036AD1 File Offset: 0x00034CD1
		public unsafe LayerMask sweepMask
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_sweepMask);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_sweepMask)) = value;
			}
		}

		// Token: 0x170022C2 RID: 8898
		// (get) Token: 0x060073B0 RID: 29616 RVA: 0x001FD320 File Offset: 0x001FB520
		// (set) Token: 0x060073B1 RID: 29617 RVA: 0x00036AEC File Offset: 0x00034CEC
		public unsafe Transform sweepOrigin_FL
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_sweepOrigin_FL);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_sweepOrigin_FL), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170022C3 RID: 8899
		// (get) Token: 0x060073B2 RID: 29618 RVA: 0x001FD350 File Offset: 0x001FB550
		// (set) Token: 0x060073B3 RID: 29619 RVA: 0x00036B0B File Offset: 0x00034D0B
		public unsafe Transform sweepOrigin_FR
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_sweepOrigin_FR);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_sweepOrigin_FR), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170022C4 RID: 8900
		// (get) Token: 0x060073B4 RID: 29620 RVA: 0x001FD380 File Offset: 0x001FB580
		// (set) Token: 0x060073B5 RID: 29621 RVA: 0x00036B2A File Offset: 0x00034D2A
		public unsafe Transform sweepOrigin_RL
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_sweepOrigin_RL);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_sweepOrigin_RL), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170022C5 RID: 8901
		// (get) Token: 0x060073B6 RID: 29622 RVA: 0x001FD3B0 File Offset: 0x001FB5B0
		// (set) Token: 0x060073B7 RID: 29623 RVA: 0x00036B49 File Offset: 0x00034D49
		public unsafe Transform sweepOrigin_RR
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_sweepOrigin_RR);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_sweepOrigin_RR), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170022C6 RID: 8902
		// (get) Token: 0x060073B8 RID: 29624 RVA: 0x001FD3E0 File Offset: 0x001FB5E0
		// (set) Token: 0x060073B9 RID: 29625 RVA: 0x00036B68 File Offset: 0x00034D68
		public unsafe Wheel leftWheel
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_leftWheel);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Wheel>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_leftWheel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170022C7 RID: 8903
		// (get) Token: 0x060073BA RID: 29626 RVA: 0x001FD410 File Offset: 0x001FB610
		// (set) Token: 0x060073BB RID: 29627 RVA: 0x00036B87 File Offset: 0x00034D87
		public unsafe Wheel rightWheel
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_rightWheel);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Wheel>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_rightWheel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170022C8 RID: 8904
		// (get) Token: 0x060073BC RID: 29628 RVA: 0x001FD440 File Offset: 0x001FB640
		// (set) Token: 0x060073BD RID: 29629 RVA: 0x00036BA6 File Offset: 0x00034DA6
		public unsafe static float sweepSegment
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(VehicleAgent.NativeFieldInfoPtr_sweepSegment, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(VehicleAgent.NativeFieldInfoPtr_sweepSegment, (void*)(&value));
			}
		}

		// Token: 0x170022C9 RID: 8905
		// (get) Token: 0x060073BE RID: 29630 RVA: 0x001FD45C File Offset: 0x001FB65C
		// (set) Token: 0x060073BF RID: 29631 RVA: 0x00036BB4 File Offset: 0x00034DB4
		public unsafe float sampleStepSizeMin
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_sampleStepSizeMin);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_sampleStepSizeMin)) = value;
			}
		}

		// Token: 0x170022CA RID: 8906
		// (get) Token: 0x060073C0 RID: 29632 RVA: 0x001FD484 File Offset: 0x001FB684
		// (set) Token: 0x060073C1 RID: 29633 RVA: 0x00036BCF File Offset: 0x00034DCF
		public unsafe float sampleStepSizeMax
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_sampleStepSizeMax);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_sampleStepSizeMax)) = value;
			}
		}

		// Token: 0x170022CB RID: 8907
		// (get) Token: 0x060073C2 RID: 29634 RVA: 0x001FD4AC File Offset: 0x001FB6AC
		// (set) Token: 0x060073C3 RID: 29635 RVA: 0x00036BEA File Offset: 0x00034DEA
		public unsafe int aheadPointSamples
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_aheadPointSamples);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_aheadPointSamples)) = value;
			}
		}

		// Token: 0x170022CC RID: 8908
		// (get) Token: 0x060073C4 RID: 29636 RVA: 0x001FD4D4 File Offset: 0x001FB6D4
		// (set) Token: 0x060073C5 RID: 29637 RVA: 0x00036C05 File Offset: 0x00034E05
		public unsafe static float DestinationDistanceSlowThreshold
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(VehicleAgent.NativeFieldInfoPtr_DestinationDistanceSlowThreshold, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(VehicleAgent.NativeFieldInfoPtr_DestinationDistanceSlowThreshold, (void*)(&value));
			}
		}

		// Token: 0x170022CD RID: 8909
		// (get) Token: 0x060073C6 RID: 29638 RVA: 0x001FD4F0 File Offset: 0x001FB6F0
		// (set) Token: 0x060073C7 RID: 29639 RVA: 0x00036C13 File Offset: 0x00034E13
		public unsafe static float DestinationArrivalThreshold
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(VehicleAgent.NativeFieldInfoPtr_DestinationArrivalThreshold, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(VehicleAgent.NativeFieldInfoPtr_DestinationArrivalThreshold, (void*)(&value));
			}
		}

		// Token: 0x170022CE RID: 8910
		// (get) Token: 0x060073C8 RID: 29640 RVA: 0x001FD50C File Offset: 0x001FB70C
		// (set) Token: 0x060073C9 RID: 29641 RVA: 0x00036C21 File Offset: 0x00034E21
		public unsafe float steerTargetFollowRate
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_steerTargetFollowRate);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_steerTargetFollowRate)) = value;
			}
		}

		// Token: 0x170022CF RID: 8911
		// (get) Token: 0x060073CA RID: 29642 RVA: 0x001FD534 File Offset: 0x001FB734
		// (set) Token: 0x060073CB RID: 29643 RVA: 0x00036C3C File Offset: 0x00034E3C
		public unsafe SteerPID steerPID
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_steerPID);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SteerPID>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_steerPID), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170022D0 RID: 8912
		// (get) Token: 0x060073CC RID: 29644 RVA: 0x001FD564 File Offset: 0x001FB764
		// (set) Token: 0x060073CD RID: 29645 RVA: 0x00036C5B File Offset: 0x00034E5B
		public unsafe float turnSpeedReductionMinRange
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_turnSpeedReductionMinRange);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_turnSpeedReductionMinRange)) = value;
			}
		}

		// Token: 0x170022D1 RID: 8913
		// (get) Token: 0x060073CE RID: 29646 RVA: 0x001FD58C File Offset: 0x001FB78C
		// (set) Token: 0x060073CF RID: 29647 RVA: 0x00036C76 File Offset: 0x00034E76
		public unsafe float turnSpeedReductionMaxRange
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_turnSpeedReductionMaxRange);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_turnSpeedReductionMaxRange)) = value;
			}
		}

		// Token: 0x170022D2 RID: 8914
		// (get) Token: 0x060073D0 RID: 29648 RVA: 0x001FD5B4 File Offset: 0x001FB7B4
		// (set) Token: 0x060073D1 RID: 29649 RVA: 0x00036C91 File Offset: 0x00034E91
		public unsafe float turnSpeedReductionDivisor
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_turnSpeedReductionDivisor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_turnSpeedReductionDivisor)) = value;
			}
		}

		// Token: 0x170022D3 RID: 8915
		// (get) Token: 0x060073D2 RID: 29650 RVA: 0x001FD5DC File Offset: 0x001FB7DC
		// (set) Token: 0x060073D3 RID: 29651 RVA: 0x00036CAC File Offset: 0x00034EAC
		public unsafe float minTurnSpeedReductionAngleThreshold
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_minTurnSpeedReductionAngleThreshold);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_minTurnSpeedReductionAngleThreshold)) = value;
			}
		}

		// Token: 0x170022D4 RID: 8916
		// (get) Token: 0x060073D4 RID: 29652 RVA: 0x001FD604 File Offset: 0x001FB804
		// (set) Token: 0x060073D5 RID: 29653 RVA: 0x00036CC7 File Offset: 0x00034EC7
		public unsafe float minTurningSpeed
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_minTurningSpeed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_minTurningSpeed)) = value;
			}
		}

		// Token: 0x170022D5 RID: 8917
		// (get) Token: 0x060073D6 RID: 29654 RVA: 0x001FD62C File Offset: 0x001FB82C
		// (set) Token: 0x060073D7 RID: 29655 RVA: 0x00036CE2 File Offset: 0x00034EE2
		public unsafe float throttleMin
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_throttleMin);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_throttleMin)) = value;
			}
		}

		// Token: 0x170022D6 RID: 8918
		// (get) Token: 0x060073D8 RID: 29656 RVA: 0x001FD654 File Offset: 0x001FB854
		// (set) Token: 0x060073D9 RID: 29657 RVA: 0x00036CFD File Offset: 0x00034EFD
		public unsafe float throttleMax
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_throttleMax);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_throttleMax)) = value;
			}
		}

		// Token: 0x170022D7 RID: 8919
		// (get) Token: 0x060073DA RID: 29658 RVA: 0x001FD67C File Offset: 0x001FB87C
		// (set) Token: 0x060073DB RID: 29659 RVA: 0x00036D18 File Offset: 0x00034F18
		public unsafe PID throttlePID
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_throttlePID);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PID>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_throttlePID), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170022D8 RID: 8920
		// (get) Token: 0x060073DC RID: 29660 RVA: 0x001FD6AC File Offset: 0x001FB8AC
		// (set) Token: 0x060073DD RID: 29661 RVA: 0x00036D37 File Offset: 0x00034F37
		public unsafe static float UnmarkedSpeed
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(VehicleAgent.NativeFieldInfoPtr_UnmarkedSpeed, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(VehicleAgent.NativeFieldInfoPtr_UnmarkedSpeed, (void*)(&value));
			}
		}

		// Token: 0x170022D9 RID: 8921
		// (get) Token: 0x060073DE RID: 29662 RVA: 0x001FD6C8 File Offset: 0x001FB8C8
		// (set) Token: 0x060073DF RID: 29663 RVA: 0x00036D45 File Offset: 0x00034F45
		public unsafe static float ReverseSpeed
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(VehicleAgent.NativeFieldInfoPtr_ReverseSpeed, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(VehicleAgent.NativeFieldInfoPtr_ReverseSpeed, (void*)(&value));
			}
		}

		// Token: 0x170022DA RID: 8922
		// (get) Token: 0x060073E0 RID: 29664 RVA: 0x001FD6E4 File Offset: 0x001FB8E4
		// (set) Token: 0x060073E1 RID: 29665 RVA: 0x00036D53 File Offset: 0x00034F53
		public unsafe ValueTracker speedReductionTracker
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_speedReductionTracker);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ValueTracker>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_speedReductionTracker), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170022DB RID: 8923
		// (get) Token: 0x060073E2 RID: 29666 RVA: 0x001FD714 File Offset: 0x001FB914
		// (set) Token: 0x060073E3 RID: 29667 RVA: 0x00036D72 File Offset: 0x00034F72
		public unsafe bool PursuitModeEnabled
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_PursuitModeEnabled);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_PursuitModeEnabled)) = value;
			}
		}

		// Token: 0x170022DC RID: 8924
		// (get) Token: 0x060073E4 RID: 29668 RVA: 0x001FD73C File Offset: 0x001FB93C
		// (set) Token: 0x060073E5 RID: 29669 RVA: 0x00036D8D File Offset: 0x00034F8D
		public unsafe Transform PursuitTarget
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_PursuitTarget);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_PursuitTarget), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170022DD RID: 8925
		// (get) Token: 0x060073E6 RID: 29670 RVA: 0x001FD76C File Offset: 0x001FB96C
		// (set) Token: 0x060073E7 RID: 29671 RVA: 0x00036DAC File Offset: 0x00034FAC
		public unsafe float PursuitDistanceUpdateThreshold
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_PursuitDistanceUpdateThreshold);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_PursuitDistanceUpdateThreshold)) = value;
			}
		}

		// Token: 0x170022DE RID: 8926
		// (get) Token: 0x060073E8 RID: 29672 RVA: 0x001FD794 File Offset: 0x001FB994
		// (set) Token: 0x060073E9 RID: 29673 RVA: 0x00036DC7 File Offset: 0x00034FC7
		public unsafe Vector3 PursuitTargetLastPosition
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_PursuitTargetLastPosition);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_PursuitTargetLastPosition)) = value;
			}
		}

		// Token: 0x170022DF RID: 8927
		// (get) Token: 0x060073EA RID: 29674 RVA: 0x001FD7BC File Offset: 0x001FB9BC
		// (set) Token: 0x060073EB RID: 29675 RVA: 0x00036DE2 File Offset: 0x00034FE2
		public unsafe VehicleTeleporter Teleporter
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_Teleporter);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<VehicleTeleporter>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_Teleporter), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170022E0 RID: 8928
		// (get) Token: 0x060073EC RID: 29676 RVA: 0x001FD7EC File Offset: 0x001FB9EC
		// (set) Token: 0x060073ED RID: 29677 RVA: 0x00036E01 File Offset: 0x00035001
		public unsafe PositionHistoryTracker PositionHistoryTracker
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_PositionHistoryTracker);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PositionHistoryTracker>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_PositionHistoryTracker), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170022E1 RID: 8929
		// (get) Token: 0x060073EE RID: 29678 RVA: 0x001FD81C File Offset: 0x001FBA1C
		// (set) Token: 0x060073EF RID: 29679 RVA: 0x00036E20 File Offset: 0x00035020
		public unsafe float StuckTimeThreshold
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_StuckTimeThreshold);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_StuckTimeThreshold)) = value;
			}
		}

		// Token: 0x170022E2 RID: 8930
		// (get) Token: 0x060073F0 RID: 29680 RVA: 0x001FD844 File Offset: 0x001FBA44
		// (set) Token: 0x060073F1 RID: 29681 RVA: 0x00036E3B File Offset: 0x0003503B
		public unsafe int StuckSamples
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_StuckSamples);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_StuckSamples)) = value;
			}
		}

		// Token: 0x170022E3 RID: 8931
		// (get) Token: 0x060073F2 RID: 29682 RVA: 0x001FD86C File Offset: 0x001FBA6C
		// (set) Token: 0x060073F3 RID: 29683 RVA: 0x00036E56 File Offset: 0x00035056
		public unsafe float StuckDistanceThreshold
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_StuckDistanceThreshold);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_StuckDistanceThreshold)) = value;
			}
		}

		// Token: 0x170022E4 RID: 8932
		// (get) Token: 0x060073F4 RID: 29684 RVA: 0x001FD894 File Offset: 0x001FBA94
		// (set) Token: 0x060073F5 RID: 29685 RVA: 0x00036E71 File Offset: 0x00035071
		public unsafe VehicleAgent.NavigationCallback storedNavigationCallback
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_storedNavigationCallback);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<VehicleAgent.NavigationCallback>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_storedNavigationCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170022E5 RID: 8933
		// (get) Token: 0x060073F6 RID: 29686 RVA: 0x001FD8C4 File Offset: 0x001FBAC4
		// (set) Token: 0x060073F7 RID: 29687 RVA: 0x00036E90 File Offset: 0x00035090
		public unsafe SpeedZone currentSpeedZone
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_currentSpeedZone);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SpeedZone>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_currentSpeedZone), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170022E6 RID: 8934
		// (get) Token: 0x060073F8 RID: 29688 RVA: 0x001FD8F4 File Offset: 0x001FBAF4
		// (set) Token: 0x060073F9 RID: 29689 RVA: 0x00036EAF File Offset: 0x000350AF
		public unsafe LandVehicle vehicle
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_vehicle);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LandVehicle>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_vehicle), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170022E7 RID: 8935
		// (get) Token: 0x060073FA RID: 29690 RVA: 0x001FD924 File Offset: 0x001FBB24
		// (set) Token: 0x060073FB RID: 29691 RVA: 0x00036ECE File Offset: 0x000350CE
		public unsafe float wheelbase
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_wheelbase);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_wheelbase)) = value;
			}
		}

		// Token: 0x170022E8 RID: 8936
		// (get) Token: 0x060073FC RID: 29692 RVA: 0x001FD94C File Offset: 0x001FBB4C
		// (set) Token: 0x060073FD RID: 29693 RVA: 0x00036EE9 File Offset: 0x000350E9
		public unsafe float wheeltrack
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_wheeltrack);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_wheeltrack)) = value;
			}
		}

		// Token: 0x170022E9 RID: 8937
		// (get) Token: 0x060073FE RID: 29694 RVA: 0x001FD974 File Offset: 0x001FBB74
		// (set) Token: 0x060073FF RID: 29695 RVA: 0x00036F04 File Offset: 0x00035104
		public unsafe float vehicleLength
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_vehicleLength);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_vehicleLength)) = value;
			}
		}

		// Token: 0x170022EA RID: 8938
		// (get) Token: 0x06007400 RID: 29696 RVA: 0x001FD99C File Offset: 0x001FBB9C
		// (set) Token: 0x06007401 RID: 29697 RVA: 0x00036F1F File Offset: 0x0003511F
		public unsafe float vehicleWidth
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_vehicleWidth);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_vehicleWidth)) = value;
			}
		}

		// Token: 0x170022EB RID: 8939
		// (get) Token: 0x06007402 RID: 29698 RVA: 0x001FD9C4 File Offset: 0x001FBBC4
		// (set) Token: 0x06007403 RID: 29699 RVA: 0x00036F3A File Offset: 0x0003513A
		public unsafe float turnRadius
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_turnRadius);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_turnRadius)) = value;
			}
		}

		// Token: 0x170022EC RID: 8940
		// (get) Token: 0x06007404 RID: 29700 RVA: 0x001FD9EC File Offset: 0x001FBBEC
		// (set) Token: 0x06007405 RID: 29701 RVA: 0x00036F55 File Offset: 0x00035155
		public unsafe float sweepTrack
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_sweepTrack);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_sweepTrack)) = value;
			}
		}

		// Token: 0x170022ED RID: 8941
		// (get) Token: 0x06007406 RID: 29702 RVA: 0x001FDA14 File Offset: 0x001FBC14
		// (set) Token: 0x06007407 RID: 29703 RVA: 0x00036F70 File Offset: 0x00035170
		public unsafe float wheelBottomOffset
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_wheelBottomOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_wheelBottomOffset)) = value;
			}
		}

		// Token: 0x170022EE RID: 8942
		// (get) Token: 0x06007408 RID: 29704 RVA: 0x001FDA3C File Offset: 0x001FBC3C
		// (set) Token: 0x06007409 RID: 29705 RVA: 0x00036F8B File Offset: 0x0003518B
		public unsafe float targetSpeed
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_targetSpeed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_targetSpeed)) = value;
			}
		}

		// Token: 0x170022EF RID: 8943
		// (get) Token: 0x0600740A RID: 29706 RVA: 0x001FDA64 File Offset: 0x001FBC64
		// (set) Token: 0x0600740B RID: 29707 RVA: 0x00036FA6 File Offset: 0x000351A6
		public unsafe float targetSteerAngle_Normalized
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_targetSteerAngle_Normalized);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_targetSteerAngle_Normalized)) = value;
			}
		}

		// Token: 0x170022F0 RID: 8944
		// (get) Token: 0x0600740C RID: 29708 RVA: 0x001FDA8C File Offset: 0x001FBC8C
		// (set) Token: 0x0600740D RID: 29709 RVA: 0x00036FC1 File Offset: 0x000351C1
		public unsafe float lateralOffset
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_lateralOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_lateralOffset)) = value;
			}
		}

		// Token: 0x170022F1 RID: 8945
		// (get) Token: 0x0600740E RID: 29710 RVA: 0x001FDAB4 File Offset: 0x001FBCB4
		// (set) Token: 0x0600740F RID: 29711 RVA: 0x00036FDC File Offset: 0x000351DC
		public unsafe PathSmoothingUtility.SmoothedPath path
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_path);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PathSmoothingUtility.SmoothedPath>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_path), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170022F2 RID: 8946
		// (get) Token: 0x06007410 RID: 29712 RVA: 0x001FDAE4 File Offset: 0x001FBCE4
		// (set) Token: 0x06007411 RID: 29713 RVA: 0x00036FFB File Offset: 0x000351FB
		public unsafe float timeSinceLastNavigationCall
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_timeSinceLastNavigationCall);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_timeSinceLastNavigationCall)) = value;
			}
		}

		// Token: 0x170022F3 RID: 8947
		// (get) Token: 0x06007412 RID: 29714 RVA: 0x001FDB0C File Offset: 0x001FBD0C
		// (set) Token: 0x06007413 RID: 29715 RVA: 0x00037016 File Offset: 0x00035216
		public unsafe float sweepTestFailedTime
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_sweepTestFailedTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_sweepTestFailedTime)) = value;
			}
		}

		// Token: 0x170022F4 RID: 8948
		// (get) Token: 0x06007414 RID: 29716 RVA: 0x001FDB34 File Offset: 0x001FBD34
		// (set) Token: 0x06007415 RID: 29717 RVA: 0x00037031 File Offset: 0x00035231
		public unsafe NavigationSettings currentNavigationSettings
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_currentNavigationSettings);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NavigationSettings>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_currentNavigationSettings), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170022F5 RID: 8949
		// (get) Token: 0x06007416 RID: 29718 RVA: 0x001FDB64 File Offset: 0x001FBD64
		// (set) Token: 0x06007417 RID: 29719 RVA: 0x00037050 File Offset: 0x00035250
		public unsafe Coroutine navigationCalculationRoutine
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_navigationCalculationRoutine);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_navigationCalculationRoutine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170022F6 RID: 8950
		// (get) Token: 0x06007418 RID: 29720 RVA: 0x001FDB94 File Offset: 0x001FBD94
		// (set) Token: 0x06007419 RID: 29721 RVA: 0x0003706F File Offset: 0x0003526F
		public unsafe Coroutine reverseCoroutine
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_reverseCoroutine);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.NativeFieldInfoPtr_reverseCoroutine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04004EB4 RID: 20148
		private static readonly System.IntPtr NativeFieldInfoPtr_VehicleGraphName;

		// Token: 0x04004EB5 RID: 20149
		private static readonly System.IntPtr NativeFieldInfoPtr_RoadGraphName;

		// Token: 0x04004EB6 RID: 20150
		private static readonly System.IntPtr NativeFieldInfoPtr_MaxDistanceFromPath;

		// Token: 0x04004EB7 RID: 20151
		private static readonly System.IntPtr NativeFieldInfoPtr_MaxDistanceFromPathWhenReversing;

		// Token: 0x04004EB8 RID: 20152
		private static readonly System.IntPtr NativeFieldInfoPtr_MainGraphSamplePoint;

		// Token: 0x04004EB9 RID: 20153
		private static readonly System.IntPtr NativeFieldInfoPtr_MinRenavigationRate;

		// Token: 0x04004EBA RID: 20154
		private static readonly System.IntPtr NativeFieldInfoPtr_Steer_P;

		// Token: 0x04004EBB RID: 20155
		private static readonly System.IntPtr NativeFieldInfoPtr_Steer_I;

		// Token: 0x04004EBC RID: 20156
		private static readonly System.IntPtr NativeFieldInfoPtr_Steer_D;

		// Token: 0x04004EBD RID: 20157
		private static readonly System.IntPtr NativeFieldInfoPtr_Throttle_P;

		// Token: 0x04004EBE RID: 20158
		private static readonly System.IntPtr NativeFieldInfoPtr_Throttle_I;

		// Token: 0x04004EBF RID: 20159
		private static readonly System.IntPtr NativeFieldInfoPtr_Throttle_D;

		// Token: 0x04004EC0 RID: 20160
		private static readonly System.IntPtr NativeFieldInfoPtr_Steer_Rate;

		// Token: 0x04004EC1 RID: 20161
		private static readonly System.IntPtr NativeFieldInfoPtr_MaxAxlePositionShift;

		// Token: 0x04004EC2 RID: 20162
		private static readonly System.IntPtr NativeFieldInfoPtr_OBSTACLE_MIN_RANGE;

		// Token: 0x04004EC3 RID: 20163
		private static readonly System.IntPtr NativeFieldInfoPtr_OBSTACLE_MAX_RANGE;

		// Token: 0x04004EC4 RID: 20164
		private static readonly System.IntPtr NativeFieldInfoPtr_MAX_STEER_ANGLE_OVERRIDE;

		// Token: 0x04004EC5 RID: 20165
		private static readonly System.IntPtr NativeFieldInfoPtr_KINEMATIC_MODE_MIN_DISTANCE;

		// Token: 0x04004EC6 RID: 20166
		private static readonly System.IntPtr NativeFieldInfoPtr_INFREQUENT_UPDATE_RATE;

		// Token: 0x04004EC7 RID: 20167
		private static readonly System.IntPtr NativeFieldInfoPtr_DEBUG_MODE;

		// Token: 0x04004EC8 RID: 20168
		private static readonly System.IntPtr NativeFieldInfoPtr__KinematicMode_k__BackingField;

		// Token: 0x04004EC9 RID: 20169
		private static readonly System.IntPtr NativeFieldInfoPtr__AutoDriving_k__BackingField;

		// Token: 0x04004ECA RID: 20170
		private static readonly System.IntPtr NativeFieldInfoPtr__TargetLocation_k__BackingField;

		// Token: 0x04004ECB RID: 20171
		private static readonly System.IntPtr NativeFieldInfoPtr_Flags;

		// Token: 0x04004ECC RID: 20172
		private static readonly System.IntPtr NativeFieldInfoPtr_roadSeeker;

		// Token: 0x04004ECD RID: 20173
		private static readonly System.IntPtr NativeFieldInfoPtr_generalSeeker;

		// Token: 0x04004ECE RID: 20174
		private static readonly System.IntPtr NativeFieldInfoPtr_CTE_Origin;

		// Token: 0x04004ECF RID: 20175
		private static readonly System.IntPtr NativeFieldInfoPtr_FrontAxlePosition;

		// Token: 0x04004ED0 RID: 20176
		private static readonly System.IntPtr NativeFieldInfoPtr_RearAxlePosition;

		// Token: 0x04004ED1 RID: 20177
		private static readonly System.IntPtr NativeFieldInfoPtr_sensor_FL;

		// Token: 0x04004ED2 RID: 20178
		private static readonly System.IntPtr NativeFieldInfoPtr_sensor_FM;

		// Token: 0x04004ED3 RID: 20179
		private static readonly System.IntPtr NativeFieldInfoPtr_sensor_FR;

		// Token: 0x04004ED4 RID: 20180
		private static readonly System.IntPtr NativeFieldInfoPtr_sensor_RR;

		// Token: 0x04004ED5 RID: 20181
		private static readonly System.IntPtr NativeFieldInfoPtr_sensor_RL;

		// Token: 0x04004ED6 RID: 20182
		private static readonly System.IntPtr NativeFieldInfoPtr_sweepMask;

		// Token: 0x04004ED7 RID: 20183
		private static readonly System.IntPtr NativeFieldInfoPtr_sweepOrigin_FL;

		// Token: 0x04004ED8 RID: 20184
		private static readonly System.IntPtr NativeFieldInfoPtr_sweepOrigin_FR;

		// Token: 0x04004ED9 RID: 20185
		private static readonly System.IntPtr NativeFieldInfoPtr_sweepOrigin_RL;

		// Token: 0x04004EDA RID: 20186
		private static readonly System.IntPtr NativeFieldInfoPtr_sweepOrigin_RR;

		// Token: 0x04004EDB RID: 20187
		private static readonly System.IntPtr NativeFieldInfoPtr_leftWheel;

		// Token: 0x04004EDC RID: 20188
		private static readonly System.IntPtr NativeFieldInfoPtr_rightWheel;

		// Token: 0x04004EDD RID: 20189
		private static readonly System.IntPtr NativeFieldInfoPtr_sweepSegment;

		// Token: 0x04004EDE RID: 20190
		private static readonly System.IntPtr NativeFieldInfoPtr_sampleStepSizeMin;

		// Token: 0x04004EDF RID: 20191
		private static readonly System.IntPtr NativeFieldInfoPtr_sampleStepSizeMax;

		// Token: 0x04004EE0 RID: 20192
		private static readonly System.IntPtr NativeFieldInfoPtr_aheadPointSamples;

		// Token: 0x04004EE1 RID: 20193
		private static readonly System.IntPtr NativeFieldInfoPtr_DestinationDistanceSlowThreshold;

		// Token: 0x04004EE2 RID: 20194
		private static readonly System.IntPtr NativeFieldInfoPtr_DestinationArrivalThreshold;

		// Token: 0x04004EE3 RID: 20195
		private static readonly System.IntPtr NativeFieldInfoPtr_steerTargetFollowRate;

		// Token: 0x04004EE4 RID: 20196
		private static readonly System.IntPtr NativeFieldInfoPtr_steerPID;

		// Token: 0x04004EE5 RID: 20197
		private static readonly System.IntPtr NativeFieldInfoPtr_turnSpeedReductionMinRange;

		// Token: 0x04004EE6 RID: 20198
		private static readonly System.IntPtr NativeFieldInfoPtr_turnSpeedReductionMaxRange;

		// Token: 0x04004EE7 RID: 20199
		private static readonly System.IntPtr NativeFieldInfoPtr_turnSpeedReductionDivisor;

		// Token: 0x04004EE8 RID: 20200
		private static readonly System.IntPtr NativeFieldInfoPtr_minTurnSpeedReductionAngleThreshold;

		// Token: 0x04004EE9 RID: 20201
		private static readonly System.IntPtr NativeFieldInfoPtr_minTurningSpeed;

		// Token: 0x04004EEA RID: 20202
		private static readonly System.IntPtr NativeFieldInfoPtr_throttleMin;

		// Token: 0x04004EEB RID: 20203
		private static readonly System.IntPtr NativeFieldInfoPtr_throttleMax;

		// Token: 0x04004EEC RID: 20204
		private static readonly System.IntPtr NativeFieldInfoPtr_throttlePID;

		// Token: 0x04004EED RID: 20205
		private static readonly System.IntPtr NativeFieldInfoPtr_UnmarkedSpeed;

		// Token: 0x04004EEE RID: 20206
		private static readonly System.IntPtr NativeFieldInfoPtr_ReverseSpeed;

		// Token: 0x04004EEF RID: 20207
		private static readonly System.IntPtr NativeFieldInfoPtr_speedReductionTracker;

		// Token: 0x04004EF0 RID: 20208
		private static readonly System.IntPtr NativeFieldInfoPtr_PursuitModeEnabled;

		// Token: 0x04004EF1 RID: 20209
		private static readonly System.IntPtr NativeFieldInfoPtr_PursuitTarget;

		// Token: 0x04004EF2 RID: 20210
		private static readonly System.IntPtr NativeFieldInfoPtr_PursuitDistanceUpdateThreshold;

		// Token: 0x04004EF3 RID: 20211
		private static readonly System.IntPtr NativeFieldInfoPtr_PursuitTargetLastPosition;

		// Token: 0x04004EF4 RID: 20212
		private static readonly System.IntPtr NativeFieldInfoPtr_Teleporter;

		// Token: 0x04004EF5 RID: 20213
		private static readonly System.IntPtr NativeFieldInfoPtr_PositionHistoryTracker;

		// Token: 0x04004EF6 RID: 20214
		private static readonly System.IntPtr NativeFieldInfoPtr_StuckTimeThreshold;

		// Token: 0x04004EF7 RID: 20215
		private static readonly System.IntPtr NativeFieldInfoPtr_StuckSamples;

		// Token: 0x04004EF8 RID: 20216
		private static readonly System.IntPtr NativeFieldInfoPtr_StuckDistanceThreshold;

		// Token: 0x04004EF9 RID: 20217
		private static readonly System.IntPtr NativeFieldInfoPtr_storedNavigationCallback;

		// Token: 0x04004EFA RID: 20218
		private static readonly System.IntPtr NativeFieldInfoPtr_currentSpeedZone;

		// Token: 0x04004EFB RID: 20219
		private static readonly System.IntPtr NativeFieldInfoPtr_vehicle;

		// Token: 0x04004EFC RID: 20220
		private static readonly System.IntPtr NativeFieldInfoPtr_wheelbase;

		// Token: 0x04004EFD RID: 20221
		private static readonly System.IntPtr NativeFieldInfoPtr_wheeltrack;

		// Token: 0x04004EFE RID: 20222
		private static readonly System.IntPtr NativeFieldInfoPtr_vehicleLength;

		// Token: 0x04004EFF RID: 20223
		private static readonly System.IntPtr NativeFieldInfoPtr_vehicleWidth;

		// Token: 0x04004F00 RID: 20224
		private static readonly System.IntPtr NativeFieldInfoPtr_turnRadius;

		// Token: 0x04004F01 RID: 20225
		private static readonly System.IntPtr NativeFieldInfoPtr_sweepTrack;

		// Token: 0x04004F02 RID: 20226
		private static readonly System.IntPtr NativeFieldInfoPtr_wheelBottomOffset;

		// Token: 0x04004F03 RID: 20227
		private static readonly System.IntPtr NativeFieldInfoPtr_targetSpeed;

		// Token: 0x04004F04 RID: 20228
		private static readonly System.IntPtr NativeFieldInfoPtr_targetSteerAngle_Normalized;

		// Token: 0x04004F05 RID: 20229
		private static readonly System.IntPtr NativeFieldInfoPtr_lateralOffset;

		// Token: 0x04004F06 RID: 20230
		private static readonly System.IntPtr NativeFieldInfoPtr_path;

		// Token: 0x04004F07 RID: 20231
		private static readonly System.IntPtr NativeFieldInfoPtr_timeSinceLastNavigationCall;

		// Token: 0x04004F08 RID: 20232
		private static readonly System.IntPtr NativeFieldInfoPtr_sweepTestFailedTime;

		// Token: 0x04004F09 RID: 20233
		private static readonly System.IntPtr NativeFieldInfoPtr_currentNavigationSettings;

		// Token: 0x04004F0A RID: 20234
		private static readonly System.IntPtr NativeFieldInfoPtr_navigationCalculationRoutine;

		// Token: 0x04004F0B RID: 20235
		private static readonly System.IntPtr NativeFieldInfoPtr_reverseCoroutine;

		// Token: 0x04004F0C RID: 20236
		private static readonly System.IntPtr NativeMethodInfoPtr_get_KinematicMode_Public_get_Boolean_0;

		// Token: 0x04004F0D RID: 20237
		private static readonly System.IntPtr NativeMethodInfoPtr_set_KinematicMode_Protected_set_Void_Boolean_0;

		// Token: 0x04004F0E RID: 20238
		private static readonly System.IntPtr NativeMethodInfoPtr_get_AutoDriving_Public_get_Boolean_0;

		// Token: 0x04004F0F RID: 20239
		private static readonly System.IntPtr NativeMethodInfoPtr_set_AutoDriving_Protected_set_Void_Boolean_0;

		// Token: 0x04004F10 RID: 20240
		private static readonly System.IntPtr NativeMethodInfoPtr_get_IsReversing_Public_get_Boolean_0;

		// Token: 0x04004F11 RID: 20241
		private static readonly System.IntPtr NativeMethodInfoPtr_get_TargetLocation_Public_get_Vector3_0;

		// Token: 0x04004F12 RID: 20242
		private static readonly System.IntPtr NativeMethodInfoPtr_set_TargetLocation_Protected_set_Void_Vector3_0;

		// Token: 0x04004F13 RID: 20243
		private static readonly System.IntPtr NativeMethodInfoPtr_get_sampleStepSize_Protected_get_Single_0;

		// Token: 0x04004F14 RID: 20244
		private static readonly System.IntPtr NativeMethodInfoPtr_get_turnSpeedReductionRange_Protected_get_Single_0;

		// Token: 0x04004F15 RID: 20245
		private static readonly System.IntPtr NativeMethodInfoPtr_get_maxSteerAngle_Protected_get_Single_0;

		// Token: 0x04004F16 RID: 20246
		private static readonly System.IntPtr NativeMethodInfoPtr_get_FrontOfVehiclePosition_Private_get_Vector3_0;

		// Token: 0x04004F17 RID: 20247
		private static readonly System.IntPtr NativeMethodInfoPtr_get_NavigationCalculationInProgress_Public_get_Boolean_0;

		// Token: 0x04004F18 RID: 20248
		private static readonly System.IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x04004F19 RID: 20249
		private static readonly System.IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0;

		// Token: 0x04004F1A RID: 20250
		private static readonly System.IntPtr NativeMethodInfoPtr_InitializeVehicleData_Private_Void_0;

		// Token: 0x04004F1B RID: 20251
		private static readonly System.IntPtr NativeMethodInfoPtr_FixedUpdate_Protected_Virtual_New_Void_0;

		// Token: 0x04004F1C RID: 20252
		private static readonly System.IntPtr NativeMethodInfoPtr_InfrequentUpdate_Protected_Void_0;

		// Token: 0x04004F1D RID: 20253
		private static readonly System.IntPtr NativeMethodInfoPtr_LateUpdate_Protected_Void_0;

		// Token: 0x04004F1E RID: 20254
		private static readonly System.IntPtr NativeMethodInfoPtr_UpdateKinematic_Protected_Void_Single_0;

		// Token: 0x04004F1F RID: 20255
		private static readonly System.IntPtr NativeMethodInfoPtr_GetAxleGroundHit_Private_Vector3_Boolean_0;

		// Token: 0x04004F20 RID: 20256
		private static readonly System.IntPtr NativeMethodInfoPtr_UpdateSweep_Private_Void_0;

		// Token: 0x04004F21 RID: 20257
		private static readonly System.IntPtr NativeMethodInfoPtr_UpdateSpeedReduction_Private_Void_0;

		// Token: 0x04004F22 RID: 20258
		private static readonly System.IntPtr NativeMethodInfoPtr_UpdatePursuitMode_Private_Void_0;

		// Token: 0x04004F23 RID: 20259
		private static readonly System.IntPtr NativeMethodInfoPtr_UpdateStuckDetection_Private_Void_0;

		// Token: 0x04004F24 RID: 20260
		private static readonly System.IntPtr NativeMethodInfoPtr_CheckDistanceFromPath_Private_Void_0;

		// Token: 0x04004F25 RID: 20261
		private static readonly System.IntPtr NativeMethodInfoPtr_UpdateOvertaking_Private_Void_0;

		// Token: 0x04004F26 RID: 20262
		private static readonly System.IntPtr NativeMethodInfoPtr_RefreshSpeedZone_Protected_Virtual_New_Void_0;

		// Token: 0x04004F27 RID: 20263
		private static readonly System.IntPtr NativeMethodInfoPtr_UpdateSpeed_Protected_Virtual_New_Void_0;

		// Token: 0x04004F28 RID: 20264
		private static readonly System.IntPtr NativeMethodInfoPtr_UpdateSteering_Protected_Void_0;

		// Token: 0x04004F29 RID: 20265
		private static readonly System.IntPtr NativeMethodInfoPtr_Navigate_Public_Void_Vector3_NavigationSettings_NavigationCallback_0;

		// Token: 0x04004F2A RID: 20266
		private static readonly System.IntPtr NativeMethodInfoPtr_NavigationCalculationCallback_Private_Void_ENavigationCalculationResult_SmoothedPath_0;

		// Token: 0x04004F2B RID: 20267
		private static readonly System.IntPtr NativeMethodInfoPtr_EndDriving_Private_Void_0;

		// Token: 0x04004F2C RID: 20268
		private static readonly System.IntPtr NativeMethodInfoPtr_StopNavigating_Public_Void_0;

		// Token: 0x04004F2D RID: 20269
		private static readonly System.IntPtr NativeMethodInfoPtr_RecalculateNavigation_Public_Void_0;

		// Token: 0x04004F2E RID: 20270
		private static readonly System.IntPtr NativeMethodInfoPtr_SweepTurn_Public_Boolean_ESweepType_Single_Boolean_byref_Single_byref_Vector3_Single_0;

		// Token: 0x04004F2F RID: 20271
		private static readonly System.IntPtr NativeMethodInfoPtr_BetterSweepTurn_Public_Void_ESweepType_Single_Boolean_LayerMask_byref_Single_byref_Vector3_0;

		// Token: 0x04004F30 RID: 20272
		private static readonly System.IntPtr NativeMethodInfoPtr_StartReverse_Public_Void_0;

		// Token: 0x04004F31 RID: 20273
		private static readonly System.IntPtr NativeMethodInfoPtr_Reverse_Public_IEnumerator_0;

		// Token: 0x04004F32 RID: 20274
		private static readonly System.IntPtr NativeMethodInfoPtr_StopReversing_Private_Void_0;

		// Token: 0x04004F33 RID: 20275
		private static readonly System.IntPtr NativeMethodInfoPtr_GetClosestForwardObstruction_Private_Collider_byref_Single_0;

		// Token: 0x04004F34 RID: 20276
		private static readonly System.IntPtr NativeMethodInfoPtr_IsOnVehicleGraph_Public_Boolean_0;

		// Token: 0x04004F35 RID: 20277
		private static readonly System.IntPtr NativeMethodInfoPtr_GetDistanceFromVehicleGraph_Private_Single_0;

		// Token: 0x04004F36 RID: 20278
		private static readonly System.IntPtr NativeMethodInfoPtr_GetPathLateralDirection_Private_Vector3_0;

		// Token: 0x04004F37 RID: 20279
		private static readonly System.IntPtr NativeMethodInfoPtr_GetIsStuck_Public_Boolean_0;

		// Token: 0x04004F38 RID: 20280
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04004F39 RID: 20281
		private static readonly System.IntPtr NativeMethodInfoPtr__Reverse_b__139_0_Private_Boolean_0;

		// Token: 0x02000AC5 RID: 2757
		[OriginalName("Assembly-CSharp.dll", "", "ENavigationResult")]
		public enum ENavigationResult
		{
			// Token: 0x040090F5 RID: 37109
			Failed,
			// Token: 0x040090F6 RID: 37110
			Complete,
			// Token: 0x040090F7 RID: 37111
			Stopped
		}

		// Token: 0x02000AC6 RID: 2758
		[OriginalName("Assembly-CSharp.dll", "", "EAgentStatus")]
		public enum EAgentStatus
		{
			// Token: 0x040090F9 RID: 37113
			Inactive,
			// Token: 0x040090FA RID: 37114
			MovingToRoad,
			// Token: 0x040090FB RID: 37115
			OnRoad
		}

		// Token: 0x02000AC7 RID: 2759
		[OriginalName("Assembly-CSharp.dll", "", "EPathGroupStatus")]
		public enum EPathGroupStatus
		{
			// Token: 0x040090FD RID: 37117
			Inactive,
			// Token: 0x040090FE RID: 37118
			Calculating
		}

		// Token: 0x02000AC8 RID: 2760
		[OriginalName("Assembly-CSharp.dll", "", "ESweepType")]
		public enum ESweepType
		{
			// Token: 0x04009100 RID: 37120
			FL,
			// Token: 0x04009101 RID: 37121
			FR,
			// Token: 0x04009102 RID: 37122
			RL,
			// Token: 0x04009103 RID: 37123
			RR
		}

		// Token: 0x02000AC9 RID: 2761
		public sealed class NavigationCallback : Il2CppSystem.MulticastDelegate
		{
			// Token: 0x0600D6D6 RID: 54998 RVA: 0x003390B4 File Offset: 0x003372B4
			// Note: this type is marked as 'beforefieldinit'.
			static NavigationCallback()
			{
				Il2CppClassPointerStore<VehicleAgent.NavigationCallback>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, "NavigationCallback");
				VehicleAgent.NavigationCallback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleAgent.NavigationCallback>.NativeClassPtr, 100677922);
				VehicleAgent.NavigationCallback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ENavigationResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleAgent.NavigationCallback>.NativeClassPtr, 100677923);
				VehicleAgent.NavigationCallback.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ENavigationResult_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleAgent.NavigationCallback>.NativeClassPtr, 100677924);
				VehicleAgent.NavigationCallback.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleAgent.NavigationCallback>.NativeClassPtr, 100677925);
			}

			// Token: 0x0600D6D7 RID: 54999 RVA: 0x00339128 File Offset: 0x00337328
			[CallerCount(98)]
			[CachedScanResults(RefRangeStart = 226439, RefRangeEnd = 226537, XrefRangeStart = 226436, XrefRangeEnd = 226439, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe NavigationCallback(Il2CppSystem.Object @object, System.IntPtr method) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VehicleAgent.NavigationCallback>.NativeClassPtr))
			{
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref method;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleAgent.NavigationCallback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600D6D8 RID: 55000 RVA: 0x00339184 File Offset: 0x00337384
			[CallerCount(0)]
			public unsafe void Invoke(VehicleAgent.ENavigationResult status)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = ref status;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleAgent.NavigationCallback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ENavigationResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600D6D9 RID: 55001 RVA: 0x003391C4 File Offset: 0x003373C4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 226537, XrefRangeEnd = 226541, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Il2CppSystem.IAsyncResult BeginInvoke(VehicleAgent.ENavigationResult status, Il2CppSystem.AsyncCallback callback, Il2CppSystem.Object @object)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = ref status;
				ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
				ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleAgent.NavigationCallback.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ENavigationResult_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.IAsyncResult>(intPtr2) : null;
			}

			// Token: 0x0600D6DA RID: 55002 RVA: 0x00339234 File Offset: 0x00337434
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void EndInvoke(Il2CppSystem.IAsyncResult result)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleAgent.NavigationCallback.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600D6DB RID: 55003 RVA: 0x000684E5 File Offset: 0x000666E5
			public NavigationCallback(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x0600D6DC RID: 55004 RVA: 0x000684EE File Offset: 0x000666EE
			public static implicit operator VehicleAgent.NavigationCallback(System.Action<VehicleAgent.ENavigationResult> A_0)
			{
				return DelegateSupport.ConvertDelegate<VehicleAgent.NavigationCallback>(A_0);
			}

			// Token: 0x0600D6DD RID: 55005 RVA: 0x000684F6 File Offset: 0x000666F6
			public static VehicleAgent.NavigationCallback operator +(VehicleAgent.NavigationCallback A_0, VehicleAgent.NavigationCallback A_1)
			{
				return Il2CppSystem.Delegate.Combine(A_0, A_1).Cast<VehicleAgent.NavigationCallback>();
			}

			// Token: 0x0600D6DE RID: 55006 RVA: 0x00068504 File Offset: 0x00066704
			public static VehicleAgent.NavigationCallback operator -(VehicleAgent.NavigationCallback A_0, VehicleAgent.NavigationCallback A_1)
			{
				Il2CppSystem.Delegate result;
				Il2CppSystem.Delegate @delegate = result = Il2CppSystem.Delegate.Remove(A_0, A_1);
				if (@delegate != null)
				{
					result = @delegate.Cast<VehicleAgent.NavigationCallback>();
				}
				return result;
			}

			// Token: 0x04009104 RID: 37124
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x04009105 RID: 37125
			private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ENavigationResult_0;

			// Token: 0x04009106 RID: 37126
			private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ENavigationResult_AsyncCallback_Object_0;

			// Token: 0x04009107 RID: 37127
			private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
		}

		// Token: 0x02000ACA RID: 2762
		[ObfuscatedName("ScheduleOne.Vehicles.AI.VehicleAgent+<>c")]
		[System.Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x0600D6DF RID: 55007 RVA: 0x00339278 File Offset: 0x00337478
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<VehicleAgent.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VehicleAgent.__c>.NativeClassPtr);
				VehicleAgent.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleAgent.__c>.NativeClassPtr, "<>9");
				VehicleAgent.__c.NativeFieldInfoPtr___9__120_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleAgent.__c>.NativeClassPtr, "<>9__120_0");
				VehicleAgent.__c.NativeFieldInfoPtr___9__121_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleAgent.__c>.NativeClassPtr, "<>9__121_0");
				VehicleAgent.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleAgent.__c>.NativeClassPtr, 100677927);
				VehicleAgent.__c.NativeMethodInfoPtr__UpdateKinematic_b__120_0_Internal_Single_RaycastHit_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleAgent.__c>.NativeClassPtr, 100677928);
				VehicleAgent.__c.NativeMethodInfoPtr__GetAxleGroundHit_b__121_0_Internal_Single_RaycastHit_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleAgent.__c>.NativeClassPtr, 100677929);
			}

			// Token: 0x0600D6E0 RID: 55008 RVA: 0x0033931C File Offset: 0x0033751C
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VehicleAgent.__c>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleAgent.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600D6E1 RID: 55009 RVA: 0x00339358 File Offset: 0x00337558
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 226541, XrefRangeEnd = 226542, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe float _UpdateKinematic_b__120_0(RaycastHit h)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = ref h;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(VehicleAgent.__c.NativeMethodInfoPtr__UpdateKinematic_b__120_0_Internal_Single_RaycastHit_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x0600D6E2 RID: 55010 RVA: 0x003393A4 File Offset: 0x003375A4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe float _GetAxleGroundHit_b__121_0(RaycastHit h)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = ref h;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(VehicleAgent.__c.NativeMethodInfoPtr__GetAxleGroundHit_b__121_0_Internal_Single_RaycastHit_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x0600D6E3 RID: 55011 RVA: 0x00068515 File Offset: 0x00066715
			public __c(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004263 RID: 16995
			// (get) Token: 0x0600D6E4 RID: 55012 RVA: 0x003393F0 File Offset: 0x003375F0
			// (set) Token: 0x0600D6E5 RID: 55013 RVA: 0x0006851E File Offset: 0x0006671E
			public unsafe static VehicleAgent.__c __9
			{
				get
				{
					System.IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(VehicleAgent.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<VehicleAgent.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(VehicleAgent.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004264 RID: 16996
			// (get) Token: 0x0600D6E6 RID: 55014 RVA: 0x00339418 File Offset: 0x00337618
			// (set) Token: 0x0600D6E7 RID: 55015 RVA: 0x00068530 File Offset: 0x00066730
			public unsafe static Il2CppSystem.Func<RaycastHit, float> __9__120_0
			{
				get
				{
					System.IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(VehicleAgent.__c.NativeFieldInfoPtr___9__120_0, (void*)(&intPtr));
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Func<RaycastHit, float>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(VehicleAgent.__c.NativeFieldInfoPtr___9__120_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004265 RID: 16997
			// (get) Token: 0x0600D6E8 RID: 55016 RVA: 0x00339440 File Offset: 0x00337640
			// (set) Token: 0x0600D6E9 RID: 55017 RVA: 0x00068542 File Offset: 0x00066742
			public unsafe static Il2CppSystem.Func<RaycastHit, float> __9__121_0
			{
				get
				{
					System.IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(VehicleAgent.__c.NativeFieldInfoPtr___9__121_0, (void*)(&intPtr));
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Func<RaycastHit, float>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(VehicleAgent.__c.NativeFieldInfoPtr___9__121_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009108 RID: 37128
			private static readonly System.IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04009109 RID: 37129
			private static readonly System.IntPtr NativeFieldInfoPtr___9__120_0;

			// Token: 0x0400910A RID: 37130
			private static readonly System.IntPtr NativeFieldInfoPtr___9__121_0;

			// Token: 0x0400910B RID: 37131
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400910C RID: 37132
			private static readonly System.IntPtr NativeMethodInfoPtr__UpdateKinematic_b__120_0_Internal_Single_RaycastHit_0;

			// Token: 0x0400910D RID: 37133
			private static readonly System.IntPtr NativeMethodInfoPtr__GetAxleGroundHit_b__121_0_Internal_Single_RaycastHit_0;
		}

		// Token: 0x02000ACB RID: 2763
		[ObfuscatedName("ScheduleOne.Vehicles.AI.VehicleAgent+<>c__DisplayClass136_0")]
		public sealed class __c__DisplayClass136_0 : Il2CppSystem.Object
		{
			// Token: 0x0600D6EA RID: 55018 RVA: 0x00339468 File Offset: 0x00337668
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass136_0()
			{
				Il2CppClassPointerStore<VehicleAgent.__c__DisplayClass136_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, "<>c__DisplayClass136_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VehicleAgent.__c__DisplayClass136_0>.NativeClassPtr);
				VehicleAgent.__c__DisplayClass136_0.NativeFieldInfoPtr_castStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleAgent.__c__DisplayClass136_0>.NativeClassPtr, "castStart");
				VehicleAgent.__c__DisplayClass136_0.NativeFieldInfoPtr___9__0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleAgent.__c__DisplayClass136_0>.NativeClassPtr, "<>9__0");
				VehicleAgent.__c__DisplayClass136_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleAgent.__c__DisplayClass136_0>.NativeClassPtr, 100677930);
				VehicleAgent.__c__DisplayClass136_0.NativeMethodInfoPtr__SweepTurn_b__0_Internal_Single_RaycastHit_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleAgent.__c__DisplayClass136_0>.NativeClassPtr, 100677931);
			}

			// Token: 0x0600D6EB RID: 55019 RVA: 0x003394E4 File Offset: 0x003376E4
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass136_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VehicleAgent.__c__DisplayClass136_0>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleAgent.__c__DisplayClass136_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600D6EC RID: 55020 RVA: 0x00339520 File Offset: 0x00337720
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 226542, XrefRangeEnd = 226548, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe float _SweepTurn_b__0(RaycastHit x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = ref x;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(VehicleAgent.__c__DisplayClass136_0.NativeMethodInfoPtr__SweepTurn_b__0_Internal_Single_RaycastHit_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x0600D6ED RID: 55021 RVA: 0x00068554 File Offset: 0x00066754
			public __c__DisplayClass136_0(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004266 RID: 16998
			// (get) Token: 0x0600D6EE RID: 55022 RVA: 0x0033956C File Offset: 0x0033776C
			// (set) Token: 0x0600D6EF RID: 55023 RVA: 0x0006855D File Offset: 0x0006675D
			public unsafe Vector3 castStart
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.__c__DisplayClass136_0.NativeFieldInfoPtr_castStart);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.__c__DisplayClass136_0.NativeFieldInfoPtr_castStart)) = value;
				}
			}

			// Token: 0x17004267 RID: 16999
			// (get) Token: 0x0600D6F0 RID: 55024 RVA: 0x00339594 File Offset: 0x00337794
			// (set) Token: 0x0600D6F1 RID: 55025 RVA: 0x00068578 File Offset: 0x00066778
			public unsafe Il2CppSystem.Func<RaycastHit, float> __9__0
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.__c__DisplayClass136_0.NativeFieldInfoPtr___9__0);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Func<RaycastHit, float>>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.__c__DisplayClass136_0.NativeFieldInfoPtr___9__0), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400910E RID: 37134
			private static readonly System.IntPtr NativeFieldInfoPtr_castStart;

			// Token: 0x0400910F RID: 37135
			private static readonly System.IntPtr NativeFieldInfoPtr___9__0;

			// Token: 0x04009110 RID: 37136
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009111 RID: 37137
			private static readonly System.IntPtr NativeMethodInfoPtr__SweepTurn_b__0_Internal_Single_RaycastHit_0;
		}

		// Token: 0x02000ACC RID: 2764
		[ObfuscatedName("ScheduleOne.Vehicles.AI.VehicleAgent+<>c__DisplayClass137_0")]
		public sealed class __c__DisplayClass137_0 : Il2CppSystem.Object
		{
			// Token: 0x0600D6F2 RID: 55026 RVA: 0x003395C4 File Offset: 0x003377C4
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass137_0()
			{
				Il2CppClassPointerStore<VehicleAgent.__c__DisplayClass137_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, "<>c__DisplayClass137_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VehicleAgent.__c__DisplayClass137_0>.NativeClassPtr);
				VehicleAgent.__c__DisplayClass137_0.NativeFieldInfoPtr_castStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleAgent.__c__DisplayClass137_0>.NativeClassPtr, "castStart");
				VehicleAgent.__c__DisplayClass137_0.NativeFieldInfoPtr___9__0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleAgent.__c__DisplayClass137_0>.NativeClassPtr, "<>9__0");
				VehicleAgent.__c__DisplayClass137_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleAgent.__c__DisplayClass137_0>.NativeClassPtr, 100677932);
				VehicleAgent.__c__DisplayClass137_0.NativeMethodInfoPtr__BetterSweepTurn_b__0_Internal_Single_RaycastHit_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleAgent.__c__DisplayClass137_0>.NativeClassPtr, 100677933);
			}

			// Token: 0x0600D6F3 RID: 55027 RVA: 0x00339640 File Offset: 0x00337840
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass137_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VehicleAgent.__c__DisplayClass137_0>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleAgent.__c__DisplayClass137_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600D6F4 RID: 55028 RVA: 0x0033967C File Offset: 0x0033787C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe float _BetterSweepTurn_b__0(RaycastHit x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = ref x;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(VehicleAgent.__c__DisplayClass137_0.NativeMethodInfoPtr__BetterSweepTurn_b__0_Internal_Single_RaycastHit_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x0600D6F5 RID: 55029 RVA: 0x00068597 File Offset: 0x00066797
			public __c__DisplayClass137_0(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004268 RID: 17000
			// (get) Token: 0x0600D6F6 RID: 55030 RVA: 0x003396C8 File Offset: 0x003378C8
			// (set) Token: 0x0600D6F7 RID: 55031 RVA: 0x000685A0 File Offset: 0x000667A0
			public unsafe Vector3 castStart
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.__c__DisplayClass137_0.NativeFieldInfoPtr_castStart);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.__c__DisplayClass137_0.NativeFieldInfoPtr_castStart)) = value;
				}
			}

			// Token: 0x17004269 RID: 17001
			// (get) Token: 0x0600D6F8 RID: 55032 RVA: 0x003396F0 File Offset: 0x003378F0
			// (set) Token: 0x0600D6F9 RID: 55033 RVA: 0x000685BB File Offset: 0x000667BB
			public unsafe Il2CppSystem.Func<RaycastHit, float> __9__0
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.__c__DisplayClass137_0.NativeFieldInfoPtr___9__0);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Func<RaycastHit, float>>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent.__c__DisplayClass137_0.NativeFieldInfoPtr___9__0), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009112 RID: 37138
			private static readonly System.IntPtr NativeFieldInfoPtr_castStart;

			// Token: 0x04009113 RID: 37139
			private static readonly System.IntPtr NativeFieldInfoPtr___9__0;

			// Token: 0x04009114 RID: 37140
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009115 RID: 37141
			private static readonly System.IntPtr NativeMethodInfoPtr__BetterSweepTurn_b__0_Internal_Single_RaycastHit_0;
		}

		// Token: 0x02000ACD RID: 2765
		[ObfuscatedName("ScheduleOne.Vehicles.AI.VehicleAgent+<Reverse>d__139")]
		public sealed class _Reverse_d__139 : Il2CppSystem.Object
		{
			// Token: 0x0600D6FA RID: 55034 RVA: 0x00339720 File Offset: 0x00337920
			// Note: this type is marked as 'beforefieldinit'.
			static _Reverse_d__139()
			{
				Il2CppClassPointerStore<VehicleAgent._Reverse_d__139>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<VehicleAgent>.NativeClassPtr, "<Reverse>d__139");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VehicleAgent._Reverse_d__139>.NativeClassPtr);
				VehicleAgent._Reverse_d__139.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleAgent._Reverse_d__139>.NativeClassPtr, "<>1__state");
				VehicleAgent._Reverse_d__139.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleAgent._Reverse_d__139>.NativeClassPtr, "<>2__current");
				VehicleAgent._Reverse_d__139.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleAgent._Reverse_d__139>.NativeClassPtr, "<>4__this");
				VehicleAgent._Reverse_d__139.NativeFieldInfoPtr__futureTarget_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleAgent._Reverse_d__139>.NativeClassPtr, "<futureTarget>5__2");
				VehicleAgent._Reverse_d__139.NativeFieldInfoPtr__steerAngleNormal_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleAgent._Reverse_d__139>.NativeClassPtr, "<steerAngleNormal>5__3");
				VehicleAgent._Reverse_d__139.NativeFieldInfoPtr__frontWheel_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleAgent._Reverse_d__139>.NativeClassPtr, "<frontWheel>5__4");
				VehicleAgent._Reverse_d__139.NativeFieldInfoPtr__sweepAngle_5__5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleAgent._Reverse_d__139>.NativeClassPtr, "<sweepAngle>5__5");
				VehicleAgent._Reverse_d__139.NativeFieldInfoPtr__reverseSweepDistanceMin_5__6 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleAgent._Reverse_d__139>.NativeClassPtr, "<reverseSweepDistanceMin>5__6");
				VehicleAgent._Reverse_d__139.NativeFieldInfoPtr__canBeginSwing_5__7 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleAgent._Reverse_d__139>.NativeClassPtr, "<canBeginSwing>5__7");
				VehicleAgent._Reverse_d__139.NativeFieldInfoPtr__faceTarget_5__8 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleAgent._Reverse_d__139>.NativeClassPtr, "<faceTarget>5__8");
				VehicleAgent._Reverse_d__139.NativeFieldInfoPtr__continueReversing_5__9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleAgent._Reverse_d__139>.NativeClassPtr, "<continueReversing>5__9");
				VehicleAgent._Reverse_d__139.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleAgent._Reverse_d__139>.NativeClassPtr, 100677934);
				VehicleAgent._Reverse_d__139.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleAgent._Reverse_d__139>.NativeClassPtr, 100677935);
				VehicleAgent._Reverse_d__139.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleAgent._Reverse_d__139>.NativeClassPtr, 100677936);
				VehicleAgent._Reverse_d__139.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleAgent._Reverse_d__139>.NativeClassPtr, 100677937);
				VehicleAgent._Reverse_d__139.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleAgent._Reverse_d__139>.NativeClassPtr, 100677938);
				VehicleAgent._Reverse_d__139.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleAgent._Reverse_d__139>.NativeClassPtr, 100677939);
			}

			// Token: 0x0600D6FB RID: 55035 RVA: 0x003398A0 File Offset: 0x00337AA0
			[CallerCount(54)]
			[CachedScanResults(RefRangeStart = 2646, RefRangeEnd = 2700, XrefRangeStart = 2646, XrefRangeEnd = 2700, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _Reverse_d__139(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VehicleAgent._Reverse_d__139>.NativeClassPtr))
			{
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = ref <>1__state;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleAgent._Reverse_d__139.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600D6FC RID: 55036 RVA: 0x003398E8 File Offset: 0x00337AE8
			[CallerCount(14558)]
			[CachedScanResults(RefRangeStart = 2769, RefRangeEnd = 17327, XrefRangeStart = 2769, XrefRangeEnd = 17327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleAgent._Reverse_d__139.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600D6FD RID: 55037 RVA: 0x0033991C File Offset: 0x00337B1C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 226548, XrefRangeEnd = 226568, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(VehicleAgent._Reverse_d__139.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x17004275 RID: 17013
			// (get) Token: 0x0600D6FE RID: 55038 RVA: 0x00339958 File Offset: 0x00337B58
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 2740, RefRangeEnd = 2764, XrefRangeStart = 2740, XrefRangeEnd = 2764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleAgent._Reverse_d__139.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
			}

			// Token: 0x0600D6FF RID: 55039 RVA: 0x00339998 File Offset: 0x00337B98
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 226568, XrefRangeEnd = 226573, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleAgent._Reverse_d__139.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x17004276 RID: 17014
			// (get) Token: 0x0600D700 RID: 55040 RVA: 0x003399CC File Offset: 0x00337BCC
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 2740, RefRangeEnd = 2764, XrefRangeStart = 2740, XrefRangeEnd = 2764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleAgent._Reverse_d__139.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
			}

			// Token: 0x0600D701 RID: 55041 RVA: 0x000685DA File Offset: 0x000667DA
			public _Reverse_d__139(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700426A RID: 17002
			// (get) Token: 0x0600D702 RID: 55042 RVA: 0x00339A0C File Offset: 0x00337C0C
			// (set) Token: 0x0600D703 RID: 55043 RVA: 0x000685E3 File Offset: 0x000667E3
			public unsafe int __1__state
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent._Reverse_d__139.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent._Reverse_d__139.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700426B RID: 17003
			// (get) Token: 0x0600D704 RID: 55044 RVA: 0x00339A34 File Offset: 0x00337C34
			// (set) Token: 0x0600D705 RID: 55045 RVA: 0x000685FE File Offset: 0x000667FE
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent._Reverse_d__139.NativeFieldInfoPtr___2__current);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent._Reverse_d__139.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700426C RID: 17004
			// (get) Token: 0x0600D706 RID: 55046 RVA: 0x00339A64 File Offset: 0x00337C64
			// (set) Token: 0x0600D707 RID: 55047 RVA: 0x0006861D File Offset: 0x0006681D
			public unsafe VehicleAgent __4__this
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent._Reverse_d__139.NativeFieldInfoPtr___4__this);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<VehicleAgent>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent._Reverse_d__139.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700426D RID: 17005
			// (get) Token: 0x0600D708 RID: 55048 RVA: 0x00339A94 File Offset: 0x00337C94
			// (set) Token: 0x0600D709 RID: 55049 RVA: 0x0006863C File Offset: 0x0006683C
			public unsafe Vector3 _futureTarget_5__2
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent._Reverse_d__139.NativeFieldInfoPtr__futureTarget_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent._Reverse_d__139.NativeFieldInfoPtr__futureTarget_5__2)) = value;
				}
			}

			// Token: 0x1700426E RID: 17006
			// (get) Token: 0x0600D70A RID: 55050 RVA: 0x00339ABC File Offset: 0x00337CBC
			// (set) Token: 0x0600D70B RID: 55051 RVA: 0x00068657 File Offset: 0x00066857
			public unsafe float _steerAngleNormal_5__3
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent._Reverse_d__139.NativeFieldInfoPtr__steerAngleNormal_5__3);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent._Reverse_d__139.NativeFieldInfoPtr__steerAngleNormal_5__3)) = value;
				}
			}

			// Token: 0x1700426F RID: 17007
			// (get) Token: 0x0600D70C RID: 55052 RVA: 0x00339AE4 File Offset: 0x00337CE4
			// (set) Token: 0x0600D70D RID: 55053 RVA: 0x00068672 File Offset: 0x00066872
			public unsafe VehicleAgent.ESweepType _frontWheel_5__4
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent._Reverse_d__139.NativeFieldInfoPtr__frontWheel_5__4);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent._Reverse_d__139.NativeFieldInfoPtr__frontWheel_5__4)) = value;
				}
			}

			// Token: 0x17004270 RID: 17008
			// (get) Token: 0x0600D70E RID: 55054 RVA: 0x00339B0C File Offset: 0x00337D0C
			// (set) Token: 0x0600D70F RID: 55055 RVA: 0x0006868D File Offset: 0x0006688D
			public unsafe float _sweepAngle_5__5
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent._Reverse_d__139.NativeFieldInfoPtr__sweepAngle_5__5);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent._Reverse_d__139.NativeFieldInfoPtr__sweepAngle_5__5)) = value;
				}
			}

			// Token: 0x17004271 RID: 17009
			// (get) Token: 0x0600D710 RID: 55056 RVA: 0x00339B34 File Offset: 0x00337D34
			// (set) Token: 0x0600D711 RID: 55057 RVA: 0x000686A8 File Offset: 0x000668A8
			public unsafe float _reverseSweepDistanceMin_5__6
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent._Reverse_d__139.NativeFieldInfoPtr__reverseSweepDistanceMin_5__6);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent._Reverse_d__139.NativeFieldInfoPtr__reverseSweepDistanceMin_5__6)) = value;
				}
			}

			// Token: 0x17004272 RID: 17010
			// (get) Token: 0x0600D712 RID: 55058 RVA: 0x00339B5C File Offset: 0x00337D5C
			// (set) Token: 0x0600D713 RID: 55059 RVA: 0x000686C3 File Offset: 0x000668C3
			public unsafe bool _canBeginSwing_5__7
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent._Reverse_d__139.NativeFieldInfoPtr__canBeginSwing_5__7);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent._Reverse_d__139.NativeFieldInfoPtr__canBeginSwing_5__7)) = value;
				}
			}

			// Token: 0x17004273 RID: 17011
			// (get) Token: 0x0600D714 RID: 55060 RVA: 0x00339B84 File Offset: 0x00337D84
			// (set) Token: 0x0600D715 RID: 55061 RVA: 0x000686DE File Offset: 0x000668DE
			public unsafe Vector3 _faceTarget_5__8
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent._Reverse_d__139.NativeFieldInfoPtr__faceTarget_5__8);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent._Reverse_d__139.NativeFieldInfoPtr__faceTarget_5__8)) = value;
				}
			}

			// Token: 0x17004274 RID: 17012
			// (get) Token: 0x0600D716 RID: 55062 RVA: 0x00339BAC File Offset: 0x00337DAC
			// (set) Token: 0x0600D717 RID: 55063 RVA: 0x000686F9 File Offset: 0x000668F9
			public unsafe bool _continueReversing_5__9
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent._Reverse_d__139.NativeFieldInfoPtr__continueReversing_5__9);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAgent._Reverse_d__139.NativeFieldInfoPtr__continueReversing_5__9)) = value;
				}
			}

			// Token: 0x04009116 RID: 37142
			private static readonly System.IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04009117 RID: 37143
			private static readonly System.IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04009118 RID: 37144
			private static readonly System.IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04009119 RID: 37145
			private static readonly System.IntPtr NativeFieldInfoPtr__futureTarget_5__2;

			// Token: 0x0400911A RID: 37146
			private static readonly System.IntPtr NativeFieldInfoPtr__steerAngleNormal_5__3;

			// Token: 0x0400911B RID: 37147
			private static readonly System.IntPtr NativeFieldInfoPtr__frontWheel_5__4;

			// Token: 0x0400911C RID: 37148
			private static readonly System.IntPtr NativeFieldInfoPtr__sweepAngle_5__5;

			// Token: 0x0400911D RID: 37149
			private static readonly System.IntPtr NativeFieldInfoPtr__reverseSweepDistanceMin_5__6;

			// Token: 0x0400911E RID: 37150
			private static readonly System.IntPtr NativeFieldInfoPtr__canBeginSwing_5__7;

			// Token: 0x0400911F RID: 37151
			private static readonly System.IntPtr NativeFieldInfoPtr__faceTarget_5__8;

			// Token: 0x04009120 RID: 37152
			private static readonly System.IntPtr NativeFieldInfoPtr__continueReversing_5__9;

			// Token: 0x04009121 RID: 37153
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04009122 RID: 37154
			private static readonly System.IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04009123 RID: 37155
			private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04009124 RID: 37156
			private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04009125 RID: 37157
			private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04009126 RID: 37158
			private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
