using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.PlayerScripts;
using Il2CppScheduleOne.Vehicles;
using Il2CppScheduleOne.Vehicles.AI;
using Il2CppScheduleOne.Vision;
using UnityEngine;

namespace Il2CppScheduleOne.NPCs.Behaviour
{
	// Token: 0x02000389 RID: 905
	public class VehiclePursuitBehaviour : Behaviour
	{
		// Token: 0x0600457F RID: 17791 RVA: 0x001596E0 File Offset: 0x001578E0
		// Note: this type is marked as 'beforefieldinit'.
		static VehiclePursuitBehaviour()
		{
			Il2CppClassPointerStore<VehiclePursuitBehaviour>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.NPCs.Behaviour", "VehiclePursuitBehaviour");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VehiclePursuitBehaviour>.NativeClassPtr);
			VehiclePursuitBehaviour.NativeFieldInfoPtr_MAX_CONSECUTIVE_PATHING_FAILURES = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehiclePursuitBehaviour>.NativeClassPtr, "MAX_CONSECUTIVE_PATHING_FAILURES");
			VehiclePursuitBehaviour.NativeFieldInfoPtr_EXTRA_VISIBILITY_TIME = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehiclePursuitBehaviour>.NativeClassPtr, "EXTRA_VISIBILITY_TIME");
			VehiclePursuitBehaviour.NativeFieldInfoPtr_EXIT_VEHICLE_MAX_SPEED = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehiclePursuitBehaviour>.NativeClassPtr, "EXIT_VEHICLE_MAX_SPEED");
			VehiclePursuitBehaviour.NativeFieldInfoPtr_CLOSE_ENOUGH_THRESHOLD = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehiclePursuitBehaviour>.NativeClassPtr, "CLOSE_ENOUGH_THRESHOLD");
			VehiclePursuitBehaviour.NativeFieldInfoPtr_UPDATE_FREQUENCY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehiclePursuitBehaviour>.NativeClassPtr, "UPDATE_FREQUENCY");
			VehiclePursuitBehaviour.NativeFieldInfoPtr_STATIONARY_THRESHOLD = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehiclePursuitBehaviour>.NativeClassPtr, "STATIONARY_THRESHOLD");
			VehiclePursuitBehaviour.NativeFieldInfoPtr_TIME_STATIONARY_TO_EXIT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehiclePursuitBehaviour>.NativeClassPtr, "TIME_STATIONARY_TO_EXIT");
			VehiclePursuitBehaviour.NativeFieldInfoPtr__TargetPlayer_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehiclePursuitBehaviour>.NativeClassPtr, "<TargetPlayer>k__BackingField");
			VehiclePursuitBehaviour.NativeFieldInfoPtr_RepathDistanceThresholdMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehiclePursuitBehaviour>.NativeClassPtr, "RepathDistanceThresholdMap");
			VehiclePursuitBehaviour.NativeFieldInfoPtr_vehicle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehiclePursuitBehaviour>.NativeClassPtr, "vehicle");
			VehiclePursuitBehaviour.NativeFieldInfoPtr_initialContactMade = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehiclePursuitBehaviour>.NativeClassPtr, "initialContactMade");
			VehiclePursuitBehaviour.NativeFieldInfoPtr_aggressiveDrivingEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehiclePursuitBehaviour>.NativeClassPtr, "aggressiveDrivingEnabled");
			VehiclePursuitBehaviour.NativeFieldInfoPtr_isTargetVisible = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehiclePursuitBehaviour>.NativeClassPtr, "isTargetVisible");
			VehiclePursuitBehaviour.NativeFieldInfoPtr_isTargetStrictlyVisible = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehiclePursuitBehaviour>.NativeClassPtr, "isTargetStrictlyVisible");
			VehiclePursuitBehaviour.NativeFieldInfoPtr_playerSightedDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehiclePursuitBehaviour>.NativeClassPtr, "playerSightedDuration");
			VehiclePursuitBehaviour.NativeFieldInfoPtr_timeSinceLastSighting = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehiclePursuitBehaviour>.NativeClassPtr, "timeSinceLastSighting");
			VehiclePursuitBehaviour.NativeFieldInfoPtr_consecutivePathingFailures = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehiclePursuitBehaviour>.NativeClassPtr, "consecutivePathingFailures");
			VehiclePursuitBehaviour.NativeFieldInfoPtr_timeStationary = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehiclePursuitBehaviour>.NativeClassPtr, "timeStationary");
			VehiclePursuitBehaviour.NativeFieldInfoPtr_currentDriveTarget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehiclePursuitBehaviour>.NativeClassPtr, "currentDriveTarget");
			VehiclePursuitBehaviour.NativeFieldInfoPtr_targetChanges = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehiclePursuitBehaviour>.NativeClassPtr, "targetChanges");
			VehiclePursuitBehaviour.NativeFieldInfoPtr_timeSincePursuitStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehiclePursuitBehaviour>.NativeClassPtr, "timeSincePursuitStart");
			VehiclePursuitBehaviour.NativeFieldInfoPtr_beginAsSighted = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehiclePursuitBehaviour>.NativeClassPtr, "beginAsSighted");
			VehiclePursuitBehaviour.NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehiclePursuitBehaviour>.NativeClassPtr, "NetworkInitialize___EarlyScheduleOne.NPCs.Behaviour.VehiclePursuitBehaviourAssembly-CSharp.dll_Excuted");
			VehiclePursuitBehaviour.NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehiclePursuitBehaviour>.NativeClassPtr, "NetworkInitialize__LateScheduleOne.NPCs.Behaviour.VehiclePursuitBehaviourAssembly-CSharp.dll_Excuted");
			VehiclePursuitBehaviour.NativeMethodInfoPtr_get_TargetPlayer_Public_get_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehiclePursuitBehaviour>.NativeClassPtr, 100671871);
			VehiclePursuitBehaviour.NativeMethodInfoPtr_set_TargetPlayer_Protected_set_Void_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehiclePursuitBehaviour>.NativeClassPtr, 100671872);
			VehiclePursuitBehaviour.NativeMethodInfoPtr_get_isDriving_Private_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehiclePursuitBehaviour>.NativeClassPtr, 100671873);
			VehiclePursuitBehaviour.NativeMethodInfoPtr_get_Agent_Private_get_VehicleAgent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehiclePursuitBehaviour>.NativeClassPtr, 100671874);
			VehiclePursuitBehaviour.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehiclePursuitBehaviour>.NativeClassPtr, 100671875);
			VehiclePursuitBehaviour.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehiclePursuitBehaviour>.NativeClassPtr, 100671876);
			VehiclePursuitBehaviour.NativeMethodInfoPtr_BeginAsSighted_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehiclePursuitBehaviour>.NativeClassPtr, 100671877);
			VehiclePursuitBehaviour.NativeMethodInfoPtr_Begin_Protected_Virtual_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehiclePursuitBehaviour>.NativeClassPtr, 100671878);
			VehiclePursuitBehaviour.NativeMethodInfoPtr_Resume_Protected_Virtual_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehiclePursuitBehaviour>.NativeClassPtr, 100671879);
			VehiclePursuitBehaviour.NativeMethodInfoPtr_Pause_Protected_Virtual_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehiclePursuitBehaviour>.NativeClassPtr, 100671880);
			VehiclePursuitBehaviour.NativeMethodInfoPtr_End_Protected_Virtual_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehiclePursuitBehaviour>.NativeClassPtr, 100671881);
			VehiclePursuitBehaviour.NativeMethodInfoPtr_AssignTarget_Public_Virtual_New_Void_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehiclePursuitBehaviour>.NativeClassPtr, 100671882);
			VehiclePursuitBehaviour.NativeMethodInfoPtr_StartPursuit_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehiclePursuitBehaviour>.NativeClassPtr, 100671883);
			VehiclePursuitBehaviour.NativeMethodInfoPtr_BehaviourUpdate_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehiclePursuitBehaviour>.NativeClassPtr, 100671884);
			VehiclePursuitBehaviour.NativeMethodInfoPtr_ActiveMinPass_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehiclePursuitBehaviour>.NativeClassPtr, 100671885);
			VehiclePursuitBehaviour.NativeMethodInfoPtr_FixedUpdate_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehiclePursuitBehaviour>.NativeClassPtr, 100671886);
			VehiclePursuitBehaviour.NativeMethodInfoPtr_UpdateDestination_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehiclePursuitBehaviour>.NativeClassPtr, 100671887);
			VehiclePursuitBehaviour.NativeMethodInfoPtr_IsTargetValid_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehiclePursuitBehaviour>.NativeClassPtr, 100671888);
			VehiclePursuitBehaviour.NativeMethodInfoPtr_CheckExitVehicle_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehiclePursuitBehaviour>.NativeClassPtr, 100671889);
			VehiclePursuitBehaviour.NativeMethodInfoPtr_GetPlayerChasePoint_Private_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehiclePursuitBehaviour>.NativeClassPtr, 100671890);
			VehiclePursuitBehaviour.NativeMethodInfoPtr_SetAggressiveDriving_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehiclePursuitBehaviour>.NativeClassPtr, 100671891);
			VehiclePursuitBehaviour.NativeMethodInfoPtr_DriveTo_Private_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehiclePursuitBehaviour>.NativeClassPtr, 100671892);
			VehiclePursuitBehaviour.NativeMethodInfoPtr_NavigationCallback_Private_Void_ENavigationResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehiclePursuitBehaviour>.NativeClassPtr, 100671893);
			VehiclePursuitBehaviour.NativeMethodInfoPtr_IsAsCloseAsPossible_Private_Boolean_Vector3_byref_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehiclePursuitBehaviour>.NativeClassPtr, 100671894);
			VehiclePursuitBehaviour.NativeMethodInfoPtr_IsPlayerVisible_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehiclePursuitBehaviour>.NativeClassPtr, 100671895);
			VehiclePursuitBehaviour.NativeMethodInfoPtr_CheckPlayerVisibility_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehiclePursuitBehaviour>.NativeClassPtr, 100671896);
			VehiclePursuitBehaviour.NativeMethodInfoPtr_ProcessVisionEvent_Private_Void_VisionEventReceipt_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehiclePursuitBehaviour>.NativeClassPtr, 100671897);
			VehiclePursuitBehaviour.NativeMethodInfoPtr_ProcessThirdPartyVisionEvent_Private_Void_VisionEventReceipt_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehiclePursuitBehaviour>.NativeClassPtr, 100671898);
			VehiclePursuitBehaviour.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehiclePursuitBehaviour>.NativeClassPtr, 100671899);
			VehiclePursuitBehaviour.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehiclePursuitBehaviour>.NativeClassPtr, 100671900);
			VehiclePursuitBehaviour.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehiclePursuitBehaviour>.NativeClassPtr, 100671901);
			VehiclePursuitBehaviour.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehiclePursuitBehaviour>.NativeClassPtr, 100671902);
			VehiclePursuitBehaviour.NativeMethodInfoPtr_Method_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehiclePursuitBehaviour>.NativeClassPtr, 100671903);
		}

		// Token: 0x170014F2 RID: 5362
		// (get) Token: 0x06004580 RID: 17792 RVA: 0x00159B84 File Offset: 0x00157D84
		// (set) Token: 0x06004581 RID: 17793 RVA: 0x00159BC4 File Offset: 0x00157DC4
		public unsafe Player TargetPlayer
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehiclePursuitBehaviour.NativeMethodInfoPtr_get_TargetPlayer_Public_get_Player_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Player>(intPtr2) : null;
			}
			[CallerCount(8)]
			[CachedScanResults(RefRangeStart = 118576, RefRangeEnd = 118584, XrefRangeStart = 118576, XrefRangeEnd = 118584, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehiclePursuitBehaviour.NativeMethodInfoPtr_set_TargetPlayer_Protected_set_Void_Player_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x170014F3 RID: 5363
		// (get) Token: 0x06004582 RID: 17794 RVA: 0x00159C08 File Offset: 0x00157E08
		public unsafe bool isDriving
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 159473, RefRangeEnd = 159478, XrefRangeStart = 159466, XrefRangeEnd = 159473, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr obj = IL2CPP.il2cpp_runtime_invoke(VehiclePursuitBehaviour.NativeMethodInfoPtr_get_isDriving_Private_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
		}

		// Token: 0x170014F4 RID: 5364
		// (get) Token: 0x06004583 RID: 17795 RVA: 0x00159C44 File Offset: 0x00157E44
		public unsafe VehicleAgent Agent
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehiclePursuitBehaviour.NativeMethodInfoPtr_get_Agent_Private_get_VehicleAgent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<VehicleAgent>(intPtr2) : null;
			}
		}

		// Token: 0x06004584 RID: 17796 RVA: 0x00159C84 File Offset: 0x00157E84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 159478, XrefRangeEnd = 159479, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VehiclePursuitBehaviour.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004585 RID: 17797 RVA: 0x00159CC0 File Offset: 0x00157EC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 159479, XrefRangeEnd = 159501, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehiclePursuitBehaviour.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004586 RID: 17798 RVA: 0x00159CF4 File Offset: 0x00157EF4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 159501, RefRangeEnd = 159502, XrefRangeStart = 159501, XrefRangeEnd = 159501, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void BeginAsSighted()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehiclePursuitBehaviour.NativeMethodInfoPtr_BeginAsSighted_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004587 RID: 17799 RVA: 0x00159D28 File Offset: 0x00157F28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 159502, XrefRangeEnd = 159509, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Begin()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VehiclePursuitBehaviour.NativeMethodInfoPtr_Begin_Protected_Virtual_Void_1), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004588 RID: 17800 RVA: 0x00159D64 File Offset: 0x00157F64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 159509, XrefRangeEnd = 159511, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Resume()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VehiclePursuitBehaviour.NativeMethodInfoPtr_Resume_Protected_Virtual_Void_1), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004589 RID: 17801 RVA: 0x00159DA0 File Offset: 0x00157FA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 159511, XrefRangeEnd = 159519, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Pause()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VehiclePursuitBehaviour.NativeMethodInfoPtr_Pause_Protected_Virtual_Void_1), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600458A RID: 17802 RVA: 0x00159DDC File Offset: 0x00157FDC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 159519, XrefRangeEnd = 159546, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void End()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VehiclePursuitBehaviour.NativeMethodInfoPtr_End_Protected_Virtual_Void_1), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600458B RID: 17803 RVA: 0x00159E18 File Offset: 0x00158018
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 118576, RefRangeEnd = 118584, XrefRangeStart = 118576, XrefRangeEnd = 118584, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void AssignTarget(Player target)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VehiclePursuitBehaviour.NativeMethodInfoPtr_AssignTarget_Public_Virtual_New_Void_Player_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600458C RID: 17804 RVA: 0x00159E68 File Offset: 0x00158068
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 159591, RefRangeEnd = 159593, XrefRangeStart = 159546, XrefRangeEnd = 159591, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StartPursuit()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehiclePursuitBehaviour.NativeMethodInfoPtr_StartPursuit_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600458D RID: 17805 RVA: 0x00159E9C File Offset: 0x0015809C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 159593, XrefRangeEnd = 159596, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void BehaviourUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VehiclePursuitBehaviour.NativeMethodInfoPtr_BehaviourUpdate_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600458E RID: 17806 RVA: 0x00159ED8 File Offset: 0x001580D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 159596, XrefRangeEnd = 159613, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ActiveMinPass()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VehiclePursuitBehaviour.NativeMethodInfoPtr_ActiveMinPass_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600458F RID: 17807 RVA: 0x00159F14 File Offset: 0x00158114
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 159613, XrefRangeEnd = 159614, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void FixedUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VehiclePursuitBehaviour.NativeMethodInfoPtr_FixedUpdate_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004590 RID: 17808 RVA: 0x00159F50 File Offset: 0x00158150
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 159662, RefRangeEnd = 159663, XrefRangeStart = 159614, XrefRangeEnd = 159662, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateDestination()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehiclePursuitBehaviour.NativeMethodInfoPtr_UpdateDestination_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004591 RID: 17809 RVA: 0x00159F84 File Offset: 0x00158184
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 159663, XrefRangeEnd = 159668, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsTargetValid()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(VehiclePursuitBehaviour.NativeMethodInfoPtr_IsTargetValid_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06004592 RID: 17810 RVA: 0x00159FC0 File Offset: 0x001581C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 159668, XrefRangeEnd = 159675, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CheckExitVehicle()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehiclePursuitBehaviour.NativeMethodInfoPtr_CheckExitVehicle_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004593 RID: 17811 RVA: 0x00159FF4 File Offset: 0x001581F4
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 159683, RefRangeEnd = 159690, XrefRangeStart = 159675, XrefRangeEnd = 159683, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector3 GetPlayerChasePoint()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(VehiclePursuitBehaviour.NativeMethodInfoPtr_GetPlayerChasePoint_Private_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06004594 RID: 17812 RVA: 0x0015A030 File Offset: 0x00158230
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 159692, RefRangeEnd = 159694, XrefRangeStart = 159690, XrefRangeEnd = 159692, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetAggressiveDriving(bool aggressive)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref aggressive;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehiclePursuitBehaviour.NativeMethodInfoPtr_SetAggressiveDriving_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004595 RID: 17813 RVA: 0x0015A070 File Offset: 0x00158270
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 159696, RefRangeEnd = 159702, XrefRangeStart = 159694, XrefRangeEnd = 159696, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DriveTo(Vector3 location)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref location;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehiclePursuitBehaviour.NativeMethodInfoPtr_DriveTo_Private_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004596 RID: 17814 RVA: 0x0015A0B0 File Offset: 0x001582B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 159702, XrefRangeEnd = 159705, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void NavigationCallback(VehicleAgent.ENavigationResult status)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref status;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehiclePursuitBehaviour.NativeMethodInfoPtr_NavigationCallback_Private_Void_ENavigationResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004597 RID: 17815 RVA: 0x0015A0F0 File Offset: 0x001582F0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 159428, RefRangeEnd = 159431, XrefRangeStart = 159428, XrefRangeEnd = 159431, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsAsCloseAsPossible(Vector3 pos, out Vector3 closestPosition)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref pos;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &closestPosition;
			IntPtr returnedException;
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(VehiclePursuitBehaviour.NativeMethodInfoPtr_IsAsCloseAsPossible_Private_Boolean_Vector3_byref_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06004598 RID: 17816 RVA: 0x0015A148 File Offset: 0x00158348
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsPlayerVisible()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(VehiclePursuitBehaviour.NativeMethodInfoPtr_IsPlayerVisible_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06004599 RID: 17817 RVA: 0x0015A184 File Offset: 0x00158384
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 159717, RefRangeEnd = 159718, XrefRangeStart = 159705, XrefRangeEnd = 159717, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CheckPlayerVisibility()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehiclePursuitBehaviour.NativeMethodInfoPtr_CheckPlayerVisibility_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600459A RID: 17818 RVA: 0x0015A1B8 File Offset: 0x001583B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 159718, XrefRangeEnd = 159727, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ProcessVisionEvent(VisionEventReceipt visionEventReceipt)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(visionEventReceipt);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehiclePursuitBehaviour.NativeMethodInfoPtr_ProcessVisionEvent_Private_Void_VisionEventReceipt_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600459B RID: 17819 RVA: 0x0015A1FC File Offset: 0x001583FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 159727, XrefRangeEnd = 159733, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ProcessThirdPartyVisionEvent(VisionEventReceipt visionEventReceipt)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(visionEventReceipt);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehiclePursuitBehaviour.NativeMethodInfoPtr_ProcessThirdPartyVisionEvent_Private_Void_VisionEventReceipt_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600459C RID: 17820 RVA: 0x0015A240 File Offset: 0x00158440
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 159733, XrefRangeEnd = 159736, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe VehiclePursuitBehaviour() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VehiclePursuitBehaviour>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehiclePursuitBehaviour.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600459D RID: 17821 RVA: 0x0015A27C File Offset: 0x0015847C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 159736, XrefRangeEnd = 159737, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize___Early()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VehiclePursuitBehaviour.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600459E RID: 17822 RVA: 0x0015A2B8 File Offset: 0x001584B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 159737, XrefRangeEnd = 159738, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize__Late()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VehiclePursuitBehaviour.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600459F RID: 17823 RVA: 0x0015A2F4 File Offset: 0x001584F4
		[CallerCount(0)]
		public unsafe override void NetworkInitializeIfDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VehiclePursuitBehaviour.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060045A0 RID: 17824 RVA: 0x0015A330 File Offset: 0x00158530
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 159781, RefRangeEnd = 159782, XrefRangeStart = 159738, XrefRangeEnd = 159781, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Method_Protected_Virtual_Void_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VehiclePursuitBehaviour.NativeMethodInfoPtr_Method_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060045A1 RID: 17825 RVA: 0x00021C1F File Offset: 0x0001FE1F
		public VehiclePursuitBehaviour(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170014DA RID: 5338
		// (get) Token: 0x060045A2 RID: 17826 RVA: 0x0015A36C File Offset: 0x0015856C
		// (set) Token: 0x060045A3 RID: 17827 RVA: 0x00021C28 File Offset: 0x0001FE28
		public new unsafe static float MAX_CONSECUTIVE_PATHING_FAILURES
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(VehiclePursuitBehaviour.NativeFieldInfoPtr_MAX_CONSECUTIVE_PATHING_FAILURES, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(VehiclePursuitBehaviour.NativeFieldInfoPtr_MAX_CONSECUTIVE_PATHING_FAILURES, (void*)(&value));
			}
		}

		// Token: 0x170014DB RID: 5339
		// (get) Token: 0x060045A4 RID: 17828 RVA: 0x0015A388 File Offset: 0x00158588
		// (set) Token: 0x060045A5 RID: 17829 RVA: 0x00021C36 File Offset: 0x0001FE36
		public unsafe static float EXTRA_VISIBILITY_TIME
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(VehiclePursuitBehaviour.NativeFieldInfoPtr_EXTRA_VISIBILITY_TIME, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(VehiclePursuitBehaviour.NativeFieldInfoPtr_EXTRA_VISIBILITY_TIME, (void*)(&value));
			}
		}

		// Token: 0x170014DC RID: 5340
		// (get) Token: 0x060045A6 RID: 17830 RVA: 0x0015A3A4 File Offset: 0x001585A4
		// (set) Token: 0x060045A7 RID: 17831 RVA: 0x00021C44 File Offset: 0x0001FE44
		public unsafe static float EXIT_VEHICLE_MAX_SPEED
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(VehiclePursuitBehaviour.NativeFieldInfoPtr_EXIT_VEHICLE_MAX_SPEED, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(VehiclePursuitBehaviour.NativeFieldInfoPtr_EXIT_VEHICLE_MAX_SPEED, (void*)(&value));
			}
		}

		// Token: 0x170014DD RID: 5341
		// (get) Token: 0x060045A8 RID: 17832 RVA: 0x0015A3C0 File Offset: 0x001585C0
		// (set) Token: 0x060045A9 RID: 17833 RVA: 0x00021C52 File Offset: 0x0001FE52
		public unsafe static float CLOSE_ENOUGH_THRESHOLD
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(VehiclePursuitBehaviour.NativeFieldInfoPtr_CLOSE_ENOUGH_THRESHOLD, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(VehiclePursuitBehaviour.NativeFieldInfoPtr_CLOSE_ENOUGH_THRESHOLD, (void*)(&value));
			}
		}

		// Token: 0x170014DE RID: 5342
		// (get) Token: 0x060045AA RID: 17834 RVA: 0x0015A3DC File Offset: 0x001585DC
		// (set) Token: 0x060045AB RID: 17835 RVA: 0x00021C60 File Offset: 0x0001FE60
		public unsafe static float UPDATE_FREQUENCY
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(VehiclePursuitBehaviour.NativeFieldInfoPtr_UPDATE_FREQUENCY, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(VehiclePursuitBehaviour.NativeFieldInfoPtr_UPDATE_FREQUENCY, (void*)(&value));
			}
		}

		// Token: 0x170014DF RID: 5343
		// (get) Token: 0x060045AC RID: 17836 RVA: 0x0015A3F8 File Offset: 0x001585F8
		// (set) Token: 0x060045AD RID: 17837 RVA: 0x00021C6E File Offset: 0x0001FE6E
		public unsafe static float STATIONARY_THRESHOLD
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(VehiclePursuitBehaviour.NativeFieldInfoPtr_STATIONARY_THRESHOLD, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(VehiclePursuitBehaviour.NativeFieldInfoPtr_STATIONARY_THRESHOLD, (void*)(&value));
			}
		}

		// Token: 0x170014E0 RID: 5344
		// (get) Token: 0x060045AE RID: 17838 RVA: 0x0015A414 File Offset: 0x00158614
		// (set) Token: 0x060045AF RID: 17839 RVA: 0x00021C7C File Offset: 0x0001FE7C
		public unsafe static float TIME_STATIONARY_TO_EXIT
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(VehiclePursuitBehaviour.NativeFieldInfoPtr_TIME_STATIONARY_TO_EXIT, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(VehiclePursuitBehaviour.NativeFieldInfoPtr_TIME_STATIONARY_TO_EXIT, (void*)(&value));
			}
		}

		// Token: 0x170014E1 RID: 5345
		// (get) Token: 0x060045B0 RID: 17840 RVA: 0x0015A430 File Offset: 0x00158630
		// (set) Token: 0x060045B1 RID: 17841 RVA: 0x00021C8A File Offset: 0x0001FE8A
		public unsafe Player _TargetPlayer_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehiclePursuitBehaviour.NativeFieldInfoPtr__TargetPlayer_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Player>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehiclePursuitBehaviour.NativeFieldInfoPtr__TargetPlayer_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170014E2 RID: 5346
		// (get) Token: 0x060045B2 RID: 17842 RVA: 0x0015A460 File Offset: 0x00158660
		// (set) Token: 0x060045B3 RID: 17843 RVA: 0x00021CA9 File Offset: 0x0001FEA9
		public unsafe AnimationCurve RepathDistanceThresholdMap
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehiclePursuitBehaviour.NativeFieldInfoPtr_RepathDistanceThresholdMap);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnimationCurve>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehiclePursuitBehaviour.NativeFieldInfoPtr_RepathDistanceThresholdMap), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170014E3 RID: 5347
		// (get) Token: 0x060045B4 RID: 17844 RVA: 0x0015A490 File Offset: 0x00158690
		// (set) Token: 0x060045B5 RID: 17845 RVA: 0x00021CC8 File Offset: 0x0001FEC8
		public unsafe LandVehicle vehicle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehiclePursuitBehaviour.NativeFieldInfoPtr_vehicle);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LandVehicle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehiclePursuitBehaviour.NativeFieldInfoPtr_vehicle), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170014E4 RID: 5348
		// (get) Token: 0x060045B6 RID: 17846 RVA: 0x0015A4C0 File Offset: 0x001586C0
		// (set) Token: 0x060045B7 RID: 17847 RVA: 0x00021CE7 File Offset: 0x0001FEE7
		public unsafe bool initialContactMade
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehiclePursuitBehaviour.NativeFieldInfoPtr_initialContactMade);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehiclePursuitBehaviour.NativeFieldInfoPtr_initialContactMade)) = value;
			}
		}

		// Token: 0x170014E5 RID: 5349
		// (get) Token: 0x060045B8 RID: 17848 RVA: 0x0015A4E8 File Offset: 0x001586E8
		// (set) Token: 0x060045B9 RID: 17849 RVA: 0x00021D02 File Offset: 0x0001FF02
		public unsafe bool aggressiveDrivingEnabled
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehiclePursuitBehaviour.NativeFieldInfoPtr_aggressiveDrivingEnabled);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehiclePursuitBehaviour.NativeFieldInfoPtr_aggressiveDrivingEnabled)) = value;
			}
		}

		// Token: 0x170014E6 RID: 5350
		// (get) Token: 0x060045BA RID: 17850 RVA: 0x0015A510 File Offset: 0x00158710
		// (set) Token: 0x060045BB RID: 17851 RVA: 0x00021D1D File Offset: 0x0001FF1D
		public unsafe bool isTargetVisible
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehiclePursuitBehaviour.NativeFieldInfoPtr_isTargetVisible);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehiclePursuitBehaviour.NativeFieldInfoPtr_isTargetVisible)) = value;
			}
		}

		// Token: 0x170014E7 RID: 5351
		// (get) Token: 0x060045BC RID: 17852 RVA: 0x0015A538 File Offset: 0x00158738
		// (set) Token: 0x060045BD RID: 17853 RVA: 0x00021D38 File Offset: 0x0001FF38
		public unsafe bool isTargetStrictlyVisible
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehiclePursuitBehaviour.NativeFieldInfoPtr_isTargetStrictlyVisible);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehiclePursuitBehaviour.NativeFieldInfoPtr_isTargetStrictlyVisible)) = value;
			}
		}

		// Token: 0x170014E8 RID: 5352
		// (get) Token: 0x060045BE RID: 17854 RVA: 0x0015A560 File Offset: 0x00158760
		// (set) Token: 0x060045BF RID: 17855 RVA: 0x00021D53 File Offset: 0x0001FF53
		public unsafe float playerSightedDuration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehiclePursuitBehaviour.NativeFieldInfoPtr_playerSightedDuration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehiclePursuitBehaviour.NativeFieldInfoPtr_playerSightedDuration)) = value;
			}
		}

		// Token: 0x170014E9 RID: 5353
		// (get) Token: 0x060045C0 RID: 17856 RVA: 0x0015A588 File Offset: 0x00158788
		// (set) Token: 0x060045C1 RID: 17857 RVA: 0x00021D6E File Offset: 0x0001FF6E
		public unsafe float timeSinceLastSighting
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehiclePursuitBehaviour.NativeFieldInfoPtr_timeSinceLastSighting);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehiclePursuitBehaviour.NativeFieldInfoPtr_timeSinceLastSighting)) = value;
			}
		}

		// Token: 0x170014EA RID: 5354
		// (get) Token: 0x060045C2 RID: 17858 RVA: 0x0015A5B0 File Offset: 0x001587B0
		// (set) Token: 0x060045C3 RID: 17859 RVA: 0x00021D89 File Offset: 0x0001FF89
		public new unsafe int consecutivePathingFailures
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehiclePursuitBehaviour.NativeFieldInfoPtr_consecutivePathingFailures);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehiclePursuitBehaviour.NativeFieldInfoPtr_consecutivePathingFailures)) = value;
			}
		}

		// Token: 0x170014EB RID: 5355
		// (get) Token: 0x060045C4 RID: 17860 RVA: 0x0015A5D8 File Offset: 0x001587D8
		// (set) Token: 0x060045C5 RID: 17861 RVA: 0x00021DA4 File Offset: 0x0001FFA4
		public unsafe float timeStationary
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehiclePursuitBehaviour.NativeFieldInfoPtr_timeStationary);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehiclePursuitBehaviour.NativeFieldInfoPtr_timeStationary)) = value;
			}
		}

		// Token: 0x170014EC RID: 5356
		// (get) Token: 0x060045C6 RID: 17862 RVA: 0x0015A600 File Offset: 0x00158800
		// (set) Token: 0x060045C7 RID: 17863 RVA: 0x00021DBF File Offset: 0x0001FFBF
		public unsafe Vector3 currentDriveTarget
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehiclePursuitBehaviour.NativeFieldInfoPtr_currentDriveTarget);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehiclePursuitBehaviour.NativeFieldInfoPtr_currentDriveTarget)) = value;
			}
		}

		// Token: 0x170014ED RID: 5357
		// (get) Token: 0x060045C8 RID: 17864 RVA: 0x0015A628 File Offset: 0x00158828
		// (set) Token: 0x060045C9 RID: 17865 RVA: 0x00021DDA File Offset: 0x0001FFDA
		public unsafe int targetChanges
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehiclePursuitBehaviour.NativeFieldInfoPtr_targetChanges);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehiclePursuitBehaviour.NativeFieldInfoPtr_targetChanges)) = value;
			}
		}

		// Token: 0x170014EE RID: 5358
		// (get) Token: 0x060045CA RID: 17866 RVA: 0x0015A650 File Offset: 0x00158850
		// (set) Token: 0x060045CB RID: 17867 RVA: 0x00021DF5 File Offset: 0x0001FFF5
		public unsafe float timeSincePursuitStart
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehiclePursuitBehaviour.NativeFieldInfoPtr_timeSincePursuitStart);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehiclePursuitBehaviour.NativeFieldInfoPtr_timeSincePursuitStart)) = value;
			}
		}

		// Token: 0x170014EF RID: 5359
		// (get) Token: 0x060045CC RID: 17868 RVA: 0x0015A678 File Offset: 0x00158878
		// (set) Token: 0x060045CD RID: 17869 RVA: 0x00021E10 File Offset: 0x00020010
		public unsafe bool beginAsSighted
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehiclePursuitBehaviour.NativeFieldInfoPtr_beginAsSighted);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehiclePursuitBehaviour.NativeFieldInfoPtr_beginAsSighted)) = value;
			}
		}

		// Token: 0x170014F0 RID: 5360
		// (get) Token: 0x060045CE RID: 17870 RVA: 0x0015A6A0 File Offset: 0x001588A0
		// (set) Token: 0x060045CF RID: 17871 RVA: 0x00021E2B File Offset: 0x0002002B
		public new unsafe bool field_Private_Boolean_0
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehiclePursuitBehaviour.NativeFieldInfoPtr_field_Private_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehiclePursuitBehaviour.NativeFieldInfoPtr_field_Private_Boolean_0)) = value;
			}
		}

		// Token: 0x170014F1 RID: 5361
		// (get) Token: 0x060045D0 RID: 17872 RVA: 0x0015A6C8 File Offset: 0x001588C8
		// (set) Token: 0x060045D1 RID: 17873 RVA: 0x00021E46 File Offset: 0x00020046
		public new unsafe bool field_Private_Boolean_1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehiclePursuitBehaviour.NativeFieldInfoPtr_field_Private_Boolean_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehiclePursuitBehaviour.NativeFieldInfoPtr_field_Private_Boolean_1)) = value;
			}
		}

		// Token: 0x04002E83 RID: 11907
		private static readonly IntPtr NativeFieldInfoPtr_MAX_CONSECUTIVE_PATHING_FAILURES;

		// Token: 0x04002E84 RID: 11908
		private static readonly IntPtr NativeFieldInfoPtr_EXTRA_VISIBILITY_TIME;

		// Token: 0x04002E85 RID: 11909
		private static readonly IntPtr NativeFieldInfoPtr_EXIT_VEHICLE_MAX_SPEED;

		// Token: 0x04002E86 RID: 11910
		private static readonly IntPtr NativeFieldInfoPtr_CLOSE_ENOUGH_THRESHOLD;

		// Token: 0x04002E87 RID: 11911
		private static readonly IntPtr NativeFieldInfoPtr_UPDATE_FREQUENCY;

		// Token: 0x04002E88 RID: 11912
		private static readonly IntPtr NativeFieldInfoPtr_STATIONARY_THRESHOLD;

		// Token: 0x04002E89 RID: 11913
		private static readonly IntPtr NativeFieldInfoPtr_TIME_STATIONARY_TO_EXIT;

		// Token: 0x04002E8A RID: 11914
		private static readonly IntPtr NativeFieldInfoPtr__TargetPlayer_k__BackingField;

		// Token: 0x04002E8B RID: 11915
		private static readonly IntPtr NativeFieldInfoPtr_RepathDistanceThresholdMap;

		// Token: 0x04002E8C RID: 11916
		private static readonly IntPtr NativeFieldInfoPtr_vehicle;

		// Token: 0x04002E8D RID: 11917
		private static readonly IntPtr NativeFieldInfoPtr_initialContactMade;

		// Token: 0x04002E8E RID: 11918
		private static readonly IntPtr NativeFieldInfoPtr_aggressiveDrivingEnabled;

		// Token: 0x04002E8F RID: 11919
		private static readonly IntPtr NativeFieldInfoPtr_isTargetVisible;

		// Token: 0x04002E90 RID: 11920
		private static readonly IntPtr NativeFieldInfoPtr_isTargetStrictlyVisible;

		// Token: 0x04002E91 RID: 11921
		private static readonly IntPtr NativeFieldInfoPtr_playerSightedDuration;

		// Token: 0x04002E92 RID: 11922
		private static readonly IntPtr NativeFieldInfoPtr_timeSinceLastSighting;

		// Token: 0x04002E93 RID: 11923
		private static readonly IntPtr NativeFieldInfoPtr_consecutivePathingFailures;

		// Token: 0x04002E94 RID: 11924
		private static readonly IntPtr NativeFieldInfoPtr_timeStationary;

		// Token: 0x04002E95 RID: 11925
		private static readonly IntPtr NativeFieldInfoPtr_currentDriveTarget;

		// Token: 0x04002E96 RID: 11926
		private static readonly IntPtr NativeFieldInfoPtr_targetChanges;

		// Token: 0x04002E97 RID: 11927
		private static readonly IntPtr NativeFieldInfoPtr_timeSincePursuitStart;

		// Token: 0x04002E98 RID: 11928
		private static readonly IntPtr NativeFieldInfoPtr_beginAsSighted;

		// Token: 0x04002E99 RID: 11929
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

		// Token: 0x04002E9A RID: 11930
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

		// Token: 0x04002E9B RID: 11931
		private static readonly IntPtr NativeMethodInfoPtr_get_TargetPlayer_Public_get_Player_0;

		// Token: 0x04002E9C RID: 11932
		private static readonly IntPtr NativeMethodInfoPtr_set_TargetPlayer_Protected_set_Void_Player_0;

		// Token: 0x04002E9D RID: 11933
		private static readonly IntPtr NativeMethodInfoPtr_get_isDriving_Private_get_Boolean_0;

		// Token: 0x04002E9E RID: 11934
		private static readonly IntPtr NativeMethodInfoPtr_get_Agent_Private_get_VehicleAgent_0;

		// Token: 0x04002E9F RID: 11935
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;

		// Token: 0x04002EA0 RID: 11936
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

		// Token: 0x04002EA1 RID: 11937
		private static readonly IntPtr NativeMethodInfoPtr_BeginAsSighted_Public_Void_0;

		// Token: 0x04002EA2 RID: 11938
		private static readonly IntPtr NativeMethodInfoPtr_Begin_Protected_Virtual_Void_1;

		// Token: 0x04002EA3 RID: 11939
		private static readonly IntPtr NativeMethodInfoPtr_Resume_Protected_Virtual_Void_1;

		// Token: 0x04002EA4 RID: 11940
		private static readonly IntPtr NativeMethodInfoPtr_Pause_Protected_Virtual_Void_1;

		// Token: 0x04002EA5 RID: 11941
		private static readonly IntPtr NativeMethodInfoPtr_End_Protected_Virtual_Void_1;

		// Token: 0x04002EA6 RID: 11942
		private static readonly IntPtr NativeMethodInfoPtr_AssignTarget_Public_Virtual_New_Void_Player_0;

		// Token: 0x04002EA7 RID: 11943
		private static readonly IntPtr NativeMethodInfoPtr_StartPursuit_Private_Void_0;

		// Token: 0x04002EA8 RID: 11944
		private static readonly IntPtr NativeMethodInfoPtr_BehaviourUpdate_Public_Virtual_Void_0;

		// Token: 0x04002EA9 RID: 11945
		private static readonly IntPtr NativeMethodInfoPtr_ActiveMinPass_Public_Virtual_Void_0;

		// Token: 0x04002EAA RID: 11946
		private static readonly IntPtr NativeMethodInfoPtr_FixedUpdate_Protected_Virtual_New_Void_0;

		// Token: 0x04002EAB RID: 11947
		private static readonly IntPtr NativeMethodInfoPtr_UpdateDestination_Private_Void_0;

		// Token: 0x04002EAC RID: 11948
		private static readonly IntPtr NativeMethodInfoPtr_IsTargetValid_Private_Boolean_0;

		// Token: 0x04002EAD RID: 11949
		private static readonly IntPtr NativeMethodInfoPtr_CheckExitVehicle_Private_Void_0;

		// Token: 0x04002EAE RID: 11950
		private static readonly IntPtr NativeMethodInfoPtr_GetPlayerChasePoint_Private_Vector3_0;

		// Token: 0x04002EAF RID: 11951
		private static readonly IntPtr NativeMethodInfoPtr_SetAggressiveDriving_Private_Void_Boolean_0;

		// Token: 0x04002EB0 RID: 11952
		private static readonly IntPtr NativeMethodInfoPtr_DriveTo_Private_Void_Vector3_0;

		// Token: 0x04002EB1 RID: 11953
		private static readonly IntPtr NativeMethodInfoPtr_NavigationCallback_Private_Void_ENavigationResult_0;

		// Token: 0x04002EB2 RID: 11954
		private static readonly IntPtr NativeMethodInfoPtr_IsAsCloseAsPossible_Private_Boolean_Vector3_byref_Vector3_0;

		// Token: 0x04002EB3 RID: 11955
		private static readonly IntPtr NativeMethodInfoPtr_IsPlayerVisible_Private_Boolean_0;

		// Token: 0x04002EB4 RID: 11956
		private static readonly IntPtr NativeMethodInfoPtr_CheckPlayerVisibility_Private_Void_0;

		// Token: 0x04002EB5 RID: 11957
		private static readonly IntPtr NativeMethodInfoPtr_ProcessVisionEvent_Private_Void_VisionEventReceipt_0;

		// Token: 0x04002EB6 RID: 11958
		private static readonly IntPtr NativeMethodInfoPtr_ProcessThirdPartyVisionEvent_Private_Void_VisionEventReceipt_0;

		// Token: 0x04002EB7 RID: 11959
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04002EB8 RID: 11960
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

		// Token: 0x04002EB9 RID: 11961
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

		// Token: 0x04002EBA RID: 11962
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

		// Token: 0x04002EBB RID: 11963
		private static readonly IntPtr NativeMethodInfoPtr_Method_Protected_Virtual_Void_0;
	}
}
