using System;
using Il2CppFishNet.Connection;
using Il2CppFishNet.Object;
using Il2CppFishNet.Object.Synchronizing;
using Il2CppFishNet.Serializing;
using Il2CppFishNet.Transporting;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.AvatarFramework.Equipping;
using Il2CppScheduleOne.PlayerScripts;
using Il2CppScheduleOne.Police;
using Il2CppScheduleOne.Vision;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine;

namespace Il2CppScheduleOne.NPCs.Behaviour
{
	// Token: 0x02000380 RID: 896
	public class PursuitBehaviour : Behaviour
	{
		// Token: 0x0600440F RID: 17423 RVA: 0x001548A0 File Offset: 0x00152AA0
		// Note: this type is marked as 'beforefieldinit'.
		static PursuitBehaviour()
		{
			Il2CppClassPointerStore<PursuitBehaviour>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.NPCs.Behaviour", "PursuitBehaviour");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PursuitBehaviour>.NativeClassPtr);
			PursuitBehaviour.NativeFieldInfoPtr_ARREST_RANGE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PursuitBehaviour>.NativeClassPtr, "ARREST_RANGE");
			PursuitBehaviour.NativeFieldInfoPtr_ARREST_TIME = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PursuitBehaviour>.NativeClassPtr, "ARREST_TIME");
			PursuitBehaviour.NativeFieldInfoPtr_EXTRA_VISIBILITY_TIME = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PursuitBehaviour>.NativeClassPtr, "EXTRA_VISIBILITY_TIME");
			PursuitBehaviour.NativeFieldInfoPtr_MOVE_SPEED_INVESTIGATING = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PursuitBehaviour>.NativeClassPtr, "MOVE_SPEED_INVESTIGATING");
			PursuitBehaviour.NativeFieldInfoPtr_MOVE_SPEED_ARRESTING = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PursuitBehaviour>.NativeClassPtr, "MOVE_SPEED_ARRESTING");
			PursuitBehaviour.NativeFieldInfoPtr_MOVE_SPEED_CHASE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PursuitBehaviour>.NativeClassPtr, "MOVE_SPEED_CHASE");
			PursuitBehaviour.NativeFieldInfoPtr_MOVE_SPEED_SHOOTING = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PursuitBehaviour>.NativeClassPtr, "MOVE_SPEED_SHOOTING");
			PursuitBehaviour.NativeFieldInfoPtr_SEARCH_RADIUS_MIN = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PursuitBehaviour>.NativeClassPtr, "SEARCH_RADIUS_MIN");
			PursuitBehaviour.NativeFieldInfoPtr_SEARCH_RADIUS_MAX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PursuitBehaviour>.NativeClassPtr, "SEARCH_RADIUS_MAX");
			PursuitBehaviour.NativeFieldInfoPtr_ARREST_MAX_DISTANCE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PursuitBehaviour>.NativeClassPtr, "ARREST_MAX_DISTANCE");
			PursuitBehaviour.NativeFieldInfoPtr_LEAVE_ARREST_CIRCLE_LIMIT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PursuitBehaviour>.NativeClassPtr, "LEAVE_ARREST_CIRCLE_LIMIT");
			PursuitBehaviour.NativeFieldInfoPtr_CONSECUTIVE_MISS_ACCURACY_BOOST = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PursuitBehaviour>.NativeClassPtr, "CONSECUTIVE_MISS_ACCURACY_BOOST");
			PursuitBehaviour.NativeFieldInfoPtr__TargetPlayer_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PursuitBehaviour>.NativeClassPtr, "<TargetPlayer>k__BackingField");
			PursuitBehaviour.NativeFieldInfoPtr__IsSearching_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PursuitBehaviour>.NativeClassPtr, "<IsSearching>k__BackingField");
			PursuitBehaviour.NativeFieldInfoPtr_ArrestCircle_MaxVisibleDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PursuitBehaviour>.NativeClassPtr, "ArrestCircle_MaxVisibleDistance");
			PursuitBehaviour.NativeFieldInfoPtr_ArrestCircle_MaxOpacity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PursuitBehaviour>.NativeClassPtr, "ArrestCircle_MaxOpacity");
			PursuitBehaviour.NativeFieldInfoPtr_isTargetVisible = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PursuitBehaviour>.NativeClassPtr, "isTargetVisible");
			PursuitBehaviour.NativeFieldInfoPtr_isTargetStrictlyVisible = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PursuitBehaviour>.NativeClassPtr, "isTargetStrictlyVisible");
			PursuitBehaviour.NativeFieldInfoPtr_arrestingEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PursuitBehaviour>.NativeClassPtr, "arrestingEnabled");
			PursuitBehaviour.NativeFieldInfoPtr_timeSinceLastSighting = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PursuitBehaviour>.NativeClassPtr, "timeSinceLastSighting");
			PursuitBehaviour.NativeFieldInfoPtr_currentPursuitLevelDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PursuitBehaviour>.NativeClassPtr, "currentPursuitLevelDuration");
			PursuitBehaviour.NativeFieldInfoPtr_timeWithinArrestRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PursuitBehaviour>.NativeClassPtr, "timeWithinArrestRange");
			PursuitBehaviour.NativeFieldInfoPtr_playerSightedDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PursuitBehaviour>.NativeClassPtr, "playerSightedDuration");
			PursuitBehaviour.NativeFieldInfoPtr_distanceOnPursuitStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PursuitBehaviour>.NativeClassPtr, "distanceOnPursuitStart");
			PursuitBehaviour.NativeFieldInfoPtr_searchRoutine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PursuitBehaviour>.NativeClassPtr, "searchRoutine");
			PursuitBehaviour.NativeFieldInfoPtr_rangedWeaponRoutine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PursuitBehaviour>.NativeClassPtr, "rangedWeaponRoutine");
			PursuitBehaviour.NativeFieldInfoPtr_currentSearchDestination = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PursuitBehaviour>.NativeClassPtr, "currentSearchDestination");
			PursuitBehaviour.NativeFieldInfoPtr_hasSearchDestination = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PursuitBehaviour>.NativeClassPtr, "hasSearchDestination");
			PursuitBehaviour.NativeFieldInfoPtr_officer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PursuitBehaviour>.NativeClassPtr, "officer");
			PursuitBehaviour.NativeFieldInfoPtr_targetWasDrivingOnPursuitStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PursuitBehaviour>.NativeClassPtr, "targetWasDrivingOnPursuitStart");
			PursuitBehaviour.NativeFieldInfoPtr_wasInArrestCircleLastFrame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PursuitBehaviour>.NativeClassPtr, "wasInArrestCircleLastFrame");
			PursuitBehaviour.NativeFieldInfoPtr_leaveArrestCircleCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PursuitBehaviour>.NativeClassPtr, "leaveArrestCircleCount");
			PursuitBehaviour.NativeFieldInfoPtr_rangedWeapon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PursuitBehaviour>.NativeClassPtr, "rangedWeapon");
			PursuitBehaviour.NativeFieldInfoPtr_consecutiveMissedShots = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PursuitBehaviour>.NativeClassPtr, "consecutiveMissedShots");
			PursuitBehaviour.NativeFieldInfoPtr_nextAngryVO = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PursuitBehaviour>.NativeClassPtr, "nextAngryVO");
			PursuitBehaviour.NativeFieldInfoPtr_syncVar___isTargetVisible = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PursuitBehaviour>.NativeClassPtr, "syncVar___isTargetVisible");
			PursuitBehaviour.NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PursuitBehaviour>.NativeClassPtr, "NetworkInitialize___EarlyScheduleOne.NPCs.Behaviour.PursuitBehaviourAssembly-CSharp.dll_Excuted");
			PursuitBehaviour.NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PursuitBehaviour>.NativeClassPtr, "NetworkInitialize__LateScheduleOne.NPCs.Behaviour.PursuitBehaviourAssembly-CSharp.dll_Excuted");
			PursuitBehaviour.NativeMethodInfoPtr_get_TargetPlayer_Public_get_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PursuitBehaviour>.NativeClassPtr, 100671677);
			PursuitBehaviour.NativeMethodInfoPtr_set_TargetPlayer_Protected_set_Void_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PursuitBehaviour>.NativeClassPtr, 100671678);
			PursuitBehaviour.NativeMethodInfoPtr_get_IsSearching_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PursuitBehaviour>.NativeClassPtr, 100671679);
			PursuitBehaviour.NativeMethodInfoPtr_set_IsSearching_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PursuitBehaviour>.NativeClassPtr, 100671680);
			PursuitBehaviour.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PursuitBehaviour>.NativeClassPtr, 100671681);
			PursuitBehaviour.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PursuitBehaviour>.NativeClassPtr, 100671682);
			PursuitBehaviour.NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PursuitBehaviour>.NativeClassPtr, 100671683);
			PursuitBehaviour.NativeMethodInfoPtr_AssignTarget_Public_Virtual_New_Void_NetworkConnection_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PursuitBehaviour>.NativeClassPtr, 100671684);
			PursuitBehaviour.NativeMethodInfoPtr_Begin_Protected_Virtual_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PursuitBehaviour>.NativeClassPtr, 100671685);
			PursuitBehaviour.NativeMethodInfoPtr_Resume_Protected_Virtual_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PursuitBehaviour>.NativeClassPtr, 100671686);
			PursuitBehaviour.NativeMethodInfoPtr_BehaviourUpdate_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PursuitBehaviour>.NativeClassPtr, 100671687);
			PursuitBehaviour.NativeMethodInfoPtr_ActiveMinPass_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PursuitBehaviour>.NativeClassPtr, 100671688);
			PursuitBehaviour.NativeMethodInfoPtr_IsTargetValid_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PursuitBehaviour>.NativeClassPtr, 100671689);
			PursuitBehaviour.NativeMethodInfoPtr_FixedUpdate_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PursuitBehaviour>.NativeClassPtr, 100671690);
			PursuitBehaviour.NativeMethodInfoPtr_UpdateInvestigatingBehaviour_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PursuitBehaviour>.NativeClassPtr, 100671691);
			PursuitBehaviour.NativeMethodInfoPtr_UpdateArrestBehaviour_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PursuitBehaviour>.NativeClassPtr, 100671692);
			PursuitBehaviour.NativeMethodInfoPtr_UpdateArrest_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PursuitBehaviour>.NativeClassPtr, 100671693);
			PursuitBehaviour.NativeMethodInfoPtr_GetNewArrestDestination_Private_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PursuitBehaviour>.NativeClassPtr, 100671694);
			PursuitBehaviour.NativeMethodInfoPtr_ClearSpeedControls_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PursuitBehaviour>.NativeClassPtr, 100671695);
			PursuitBehaviour.NativeMethodInfoPtr_UpdateNonLethalBehaviour_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PursuitBehaviour>.NativeClassPtr, 100671696);
			PursuitBehaviour.NativeMethodInfoPtr_UpdateLethalBehaviour_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PursuitBehaviour>.NativeClassPtr, 100671697);
			PursuitBehaviour.NativeMethodInfoPtr_RangedWeaponRoutine_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PursuitBehaviour>.NativeClassPtr, 100671698);
			PursuitBehaviour.NativeMethodInfoPtr_CanShoot_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PursuitBehaviour>.NativeClassPtr, 100671699);
			PursuitBehaviour.NativeMethodInfoPtr_Shoot_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PursuitBehaviour>.NativeClassPtr, 100671700);
			PursuitBehaviour.NativeMethodInfoPtr_SetWeaponRaised_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PursuitBehaviour>.NativeClassPtr, 100671701);
			PursuitBehaviour.NativeMethodInfoPtr_StopRangedWeaponRoutine_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PursuitBehaviour>.NativeClassPtr, 100671702);
			PursuitBehaviour.NativeMethodInfoPtr_UpdateLookAt_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PursuitBehaviour>.NativeClassPtr, 100671703);
			PursuitBehaviour.NativeMethodInfoPtr_UpdateEquippable_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PursuitBehaviour>.NativeClassPtr, 100671704);
			PursuitBehaviour.NativeMethodInfoPtr_Disable_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PursuitBehaviour>.NativeClassPtr, 100671705);
			PursuitBehaviour.NativeMethodInfoPtr_Pause_Protected_Virtual_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PursuitBehaviour>.NativeClassPtr, 100671706);
			PursuitBehaviour.NativeMethodInfoPtr_End_Protected_Virtual_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PursuitBehaviour>.NativeClassPtr, 100671707);
			PursuitBehaviour.NativeMethodInfoPtr_Stop_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PursuitBehaviour>.NativeClassPtr, 100671708);
			PursuitBehaviour.NativeMethodInfoPtr_ClearEquippables_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PursuitBehaviour>.NativeClassPtr, 100671709);
			PursuitBehaviour.NativeMethodInfoPtr_CheckPlayerVisibility_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PursuitBehaviour>.NativeClassPtr, 100671710);
			PursuitBehaviour.NativeMethodInfoPtr_MarkPlayerVisible_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PursuitBehaviour>.NativeClassPtr, 100671711);
			PursuitBehaviour.NativeMethodInfoPtr_IsPlayerVisible_Protected_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PursuitBehaviour>.NativeClassPtr, 100671712);
			PursuitBehaviour.NativeMethodInfoPtr_ProcessVisionEvent_Private_Void_VisionEventReceipt_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PursuitBehaviour>.NativeClassPtr, 100671713);
			PursuitBehaviour.NativeMethodInfoPtr_ProcessThirdPartyVisionEvent_Private_Void_VisionEventReceipt_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PursuitBehaviour>.NativeClassPtr, 100671714);
			PursuitBehaviour.NativeMethodInfoPtr_UpdateArrestCircle_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PursuitBehaviour>.NativeClassPtr, 100671715);
			PursuitBehaviour.NativeMethodInfoPtr_ResetArrestProgress_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PursuitBehaviour>.NativeClassPtr, 100671716);
			PursuitBehaviour.NativeMethodInfoPtr_SetArrestCircleAlpha_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PursuitBehaviour>.NativeClassPtr, 100671717);
			PursuitBehaviour.NativeMethodInfoPtr_SetArrestCircleColor_Private_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PursuitBehaviour>.NativeClassPtr, 100671718);
			PursuitBehaviour.NativeMethodInfoPtr_StartSearching_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PursuitBehaviour>.NativeClassPtr, 100671719);
			PursuitBehaviour.NativeMethodInfoPtr_StopSearching_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PursuitBehaviour>.NativeClassPtr, 100671720);
			PursuitBehaviour.NativeMethodInfoPtr_SearchRoutine_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PursuitBehaviour>.NativeClassPtr, 100671721);
			PursuitBehaviour.NativeMethodInfoPtr_GetNextSearchLocation_Private_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PursuitBehaviour>.NativeClassPtr, 100671722);
			PursuitBehaviour.NativeMethodInfoPtr_GetRandomReachablePointNear_Private_Vector3_Vector3_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PursuitBehaviour>.NativeClassPtr, 100671723);
			PursuitBehaviour.NativeMethodInfoPtr_SetWorldspaceIconsActive_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PursuitBehaviour>.NativeClassPtr, 100671724);
			PursuitBehaviour.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PursuitBehaviour>.NativeClassPtr, 100671725);
			PursuitBehaviour.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PursuitBehaviour>.NativeClassPtr, 100671726);
			PursuitBehaviour.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PursuitBehaviour>.NativeClassPtr, 100671727);
			PursuitBehaviour.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PursuitBehaviour>.NativeClassPtr, 100671728);
			PursuitBehaviour.NativeMethodInfoPtr_RpcWriter___Observers_AssignTarget_1824087381_Private_Void_NetworkConnection_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PursuitBehaviour>.NativeClassPtr, 100671729);
			PursuitBehaviour.NativeMethodInfoPtr_RpcLogic___AssignTarget_1824087381_Public_Virtual_New_Void_NetworkConnection_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PursuitBehaviour>.NativeClassPtr, 100671730);
			PursuitBehaviour.NativeMethodInfoPtr_RpcReader___Observers_AssignTarget_1824087381_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PursuitBehaviour>.NativeClassPtr, 100671731);
			PursuitBehaviour.NativeMethodInfoPtr_sync___get_value_isTargetVisible_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PursuitBehaviour>.NativeClassPtr, 100671732);
			PursuitBehaviour.NativeMethodInfoPtr_sync___set_value_isTargetVisible_Public_set_Void_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PursuitBehaviour>.NativeClassPtr, 100671733);
			PursuitBehaviour.NativeMethodInfoPtr_ReadSyncVar___ScheduleOne_NPCs_Behaviour_PursuitBehaviour_Public_Virtual_Boolean_PooledReader_UInt32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PursuitBehaviour>.NativeClassPtr, 100671734);
			PursuitBehaviour.NativeMethodInfoPtr_Method_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PursuitBehaviour>.NativeClassPtr, 100671735);
		}

		// Token: 0x1700149F RID: 5279
		// (get) Token: 0x06004410 RID: 17424 RVA: 0x00155064 File Offset: 0x00153264
		// (set) Token: 0x06004411 RID: 17425 RVA: 0x001550A4 File Offset: 0x001532A4
		public unsafe Player TargetPlayer
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PursuitBehaviour.NativeMethodInfoPtr_get_TargetPlayer_Public_get_Player_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Player>(intPtr2) : null;
			}
			[CallerCount(8)]
			[CachedScanResults(RefRangeStart = 118576, RefRangeEnd = 118584, XrefRangeStart = 118576, XrefRangeEnd = 118584, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PursuitBehaviour.NativeMethodInfoPtr_set_TargetPlayer_Protected_set_Void_Player_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x170014A0 RID: 5280
		// (get) Token: 0x06004412 RID: 17426 RVA: 0x001550E8 File Offset: 0x001532E8
		// (set) Token: 0x06004413 RID: 17427 RVA: 0x00155124 File Offset: 0x00153324
		public unsafe bool IsSearching
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(PursuitBehaviour.NativeMethodInfoPtr_get_IsSearching_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
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
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PursuitBehaviour.NativeMethodInfoPtr_set_IsSearching_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x06004414 RID: 17428 RVA: 0x00155164 File Offset: 0x00153364
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 157830, XrefRangeEnd = 157831, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PursuitBehaviour.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004415 RID: 17429 RVA: 0x001551A0 File Offset: 0x001533A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 157831, XrefRangeEnd = 157853, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PursuitBehaviour.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004416 RID: 17430 RVA: 0x001551D4 File Offset: 0x001533D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 157853, XrefRangeEnd = 157858, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnSpawnServer(NetworkConnection connection)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(connection);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PursuitBehaviour.NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004417 RID: 17431 RVA: 0x00155224 File Offset: 0x00153424
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 157858, XrefRangeEnd = 157860, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void AssignTarget(NetworkConnection conn, NetworkObject target)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(target);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PursuitBehaviour.NativeMethodInfoPtr_AssignTarget_Public_Virtual_New_Void_NetworkConnection_NetworkObject_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004418 RID: 17432 RVA: 0x00155284 File Offset: 0x00153484
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 157860, XrefRangeEnd = 157882, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Begin()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PursuitBehaviour.NativeMethodInfoPtr_Begin_Protected_Virtual_Void_1), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004419 RID: 17433 RVA: 0x001552C0 File Offset: 0x001534C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 157882, XrefRangeEnd = 157904, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Resume()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PursuitBehaviour.NativeMethodInfoPtr_Resume_Protected_Virtual_Void_1), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600441A RID: 17434 RVA: 0x001552FC File Offset: 0x001534FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 157904, XrefRangeEnd = 157909, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void BehaviourUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PursuitBehaviour.NativeMethodInfoPtr_BehaviourUpdate_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600441B RID: 17435 RVA: 0x00155338 File Offset: 0x00153538
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 157909, XrefRangeEnd = 157933, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ActiveMinPass()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PursuitBehaviour.NativeMethodInfoPtr_ActiveMinPass_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600441C RID: 17436 RVA: 0x00155374 File Offset: 0x00153574
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 157938, RefRangeEnd = 157940, XrefRangeStart = 157933, XrefRangeEnd = 157938, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsTargetValid()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(PursuitBehaviour.NativeMethodInfoPtr_IsTargetValid_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x0600441D RID: 17437 RVA: 0x001553B0 File Offset: 0x001535B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 157940, XrefRangeEnd = 157942, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void FixedUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PursuitBehaviour.NativeMethodInfoPtr_FixedUpdate_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600441E RID: 17438 RVA: 0x001553EC File Offset: 0x001535EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 157942, XrefRangeEnd = 157963, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void UpdateInvestigatingBehaviour()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PursuitBehaviour.NativeMethodInfoPtr_UpdateInvestigatingBehaviour_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600441F RID: 17439 RVA: 0x00155428 File Offset: 0x00153628
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 157963, XrefRangeEnd = 157995, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void UpdateArrestBehaviour()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PursuitBehaviour.NativeMethodInfoPtr_UpdateArrestBehaviour_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004420 RID: 17440 RVA: 0x00155464 File Offset: 0x00153664
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 158011, RefRangeEnd = 158012, XrefRangeStart = 157995, XrefRangeEnd = 158011, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateArrest(float tick)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref tick;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PursuitBehaviour.NativeMethodInfoPtr_UpdateArrest_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004421 RID: 17441 RVA: 0x001554A4 File Offset: 0x001536A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 158012, XrefRangeEnd = 158017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector3 GetNewArrestDestination()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(PursuitBehaviour.NativeMethodInfoPtr_GetNewArrestDestination_Private_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06004422 RID: 17442 RVA: 0x001554E0 File Offset: 0x001536E0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 158045, RefRangeEnd = 158048, XrefRangeStart = 158017, XrefRangeEnd = 158045, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ClearSpeedControls()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PursuitBehaviour.NativeMethodInfoPtr_ClearSpeedControls_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004423 RID: 17443 RVA: 0x00155514 File Offset: 0x00153714
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 158048, XrefRangeEnd = 158052, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void UpdateNonLethalBehaviour()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PursuitBehaviour.NativeMethodInfoPtr_UpdateNonLethalBehaviour_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004424 RID: 17444 RVA: 0x00155550 File Offset: 0x00153750
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void UpdateLethalBehaviour()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PursuitBehaviour.NativeMethodInfoPtr_UpdateLethalBehaviour_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004425 RID: 17445 RVA: 0x0015558C File Offset: 0x0015378C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 158057, RefRangeEnd = 158059, XrefRangeStart = 158052, XrefRangeEnd = 158057, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator RangedWeaponRoutine()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PursuitBehaviour.NativeMethodInfoPtr_RangedWeaponRoutine_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr2) : null;
		}

		// Token: 0x06004426 RID: 17446 RVA: 0x001555CC File Offset: 0x001537CC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 158064, RefRangeEnd = 158065, XrefRangeStart = 158059, XrefRangeEnd = 158064, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool CanShoot()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(PursuitBehaviour.NativeMethodInfoPtr_CanShoot_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06004427 RID: 17447 RVA: 0x00155608 File Offset: 0x00153808
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 158112, RefRangeEnd = 158113, XrefRangeStart = 158065, XrefRangeEnd = 158112, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Shoot()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(PursuitBehaviour.NativeMethodInfoPtr_Shoot_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06004428 RID: 17448 RVA: 0x00155644 File Offset: 0x00153844
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 158118, RefRangeEnd = 158119, XrefRangeStart = 158113, XrefRangeEnd = 158118, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetWeaponRaised(bool raised)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref raised;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PursuitBehaviour.NativeMethodInfoPtr_SetWeaponRaised_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004429 RID: 17449 RVA: 0x00155684 File Offset: 0x00153884
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 158121, RefRangeEnd = 158123, XrefRangeStart = 158119, XrefRangeEnd = 158121, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StopRangedWeaponRoutine()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PursuitBehaviour.NativeMethodInfoPtr_StopRangedWeaponRoutine_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600442A RID: 17450 RVA: 0x001556B8 File Offset: 0x001538B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 158123, XrefRangeEnd = 158130, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void UpdateLookAt()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PursuitBehaviour.NativeMethodInfoPtr_UpdateLookAt_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600442B RID: 17451 RVA: 0x001556F4 File Offset: 0x001538F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 158130, XrefRangeEnd = 158154, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void UpdateEquippable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PursuitBehaviour.NativeMethodInfoPtr_UpdateEquippable_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600442C RID: 17452 RVA: 0x00155730 File Offset: 0x00153930
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 158154, XrefRangeEnd = 158156, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Disable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PursuitBehaviour.NativeMethodInfoPtr_Disable_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600442D RID: 17453 RVA: 0x0015576C File Offset: 0x0015396C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 158156, XrefRangeEnd = 158158, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Pause()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PursuitBehaviour.NativeMethodInfoPtr_Pause_Protected_Virtual_Void_1), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600442E RID: 17454 RVA: 0x001557A8 File Offset: 0x001539A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 158158, XrefRangeEnd = 158160, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void End()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PursuitBehaviour.NativeMethodInfoPtr_End_Protected_Virtual_Void_1), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600442F RID: 17455 RVA: 0x001557E4 File Offset: 0x001539E4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 158194, RefRangeEnd = 158196, XrefRangeStart = 158160, XrefRangeEnd = 158194, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Stop()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PursuitBehaviour.NativeMethodInfoPtr_Stop_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004430 RID: 17456 RVA: 0x00155818 File Offset: 0x00153A18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 158196, XrefRangeEnd = 158207, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ClearEquippables()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PursuitBehaviour.NativeMethodInfoPtr_ClearEquippables_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004431 RID: 17457 RVA: 0x0015584C File Offset: 0x00153A4C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 158233, RefRangeEnd = 158236, XrefRangeStart = 158207, XrefRangeEnd = 158233, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CheckPlayerVisibility()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PursuitBehaviour.NativeMethodInfoPtr_CheckPlayerVisibility_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004432 RID: 17458 RVA: 0x00155880 File Offset: 0x00153A80
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 158240, RefRangeEnd = 158242, XrefRangeStart = 158236, XrefRangeEnd = 158240, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MarkPlayerVisible()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PursuitBehaviour.NativeMethodInfoPtr_MarkPlayerVisible_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004433 RID: 17459 RVA: 0x001558B4 File Offset: 0x00153AB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 158242, XrefRangeEnd = 158245, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsPlayerVisible()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(PursuitBehaviour.NativeMethodInfoPtr_IsPlayerVisible_Protected_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06004434 RID: 17460 RVA: 0x001558F0 File Offset: 0x00153AF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 158245, XrefRangeEnd = 158251, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ProcessVisionEvent(VisionEventReceipt visionEventReceipt)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(visionEventReceipt);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PursuitBehaviour.NativeMethodInfoPtr_ProcessVisionEvent_Private_Void_VisionEventReceipt_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004435 RID: 17461 RVA: 0x00155934 File Offset: 0x00153B34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 158251, XrefRangeEnd = 158256, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ProcessThirdPartyVisionEvent(VisionEventReceipt visionEventReceipt)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(visionEventReceipt);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PursuitBehaviour.NativeMethodInfoPtr_ProcessThirdPartyVisionEvent_Private_Void_VisionEventReceipt_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004436 RID: 17462 RVA: 0x00155978 File Offset: 0x00153B78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 158256, XrefRangeEnd = 158280, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void UpdateArrestCircle()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PursuitBehaviour.NativeMethodInfoPtr_UpdateArrestCircle_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004437 RID: 17463 RVA: 0x001559B4 File Offset: 0x00153BB4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 158280, RefRangeEnd = 158281, XrefRangeStart = 158280, XrefRangeEnd = 158280, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ResetArrestProgress()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PursuitBehaviour.NativeMethodInfoPtr_ResetArrestProgress_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004438 RID: 17464 RVA: 0x001559E8 File Offset: 0x00153BE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 158281, XrefRangeEnd = 158283, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetArrestCircleAlpha(float alpha)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref alpha;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PursuitBehaviour.NativeMethodInfoPtr_SetArrestCircleAlpha_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004439 RID: 17465 RVA: 0x00155A28 File Offset: 0x00153C28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 158283, XrefRangeEnd = 158284, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetArrestCircleColor(Color col)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref col;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PursuitBehaviour.NativeMethodInfoPtr_SetArrestCircleColor_Private_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600443A RID: 17466 RVA: 0x00155A68 File Offset: 0x00153C68
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 158292, RefRangeEnd = 158294, XrefRangeStart = 158284, XrefRangeEnd = 158292, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StartSearching()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PursuitBehaviour.NativeMethodInfoPtr_StartSearching_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600443B RID: 17467 RVA: 0x00155A9C File Offset: 0x00153C9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 158294, XrefRangeEnd = 158296, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StopSearching()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PursuitBehaviour.NativeMethodInfoPtr_StopSearching_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600443C RID: 17468 RVA: 0x00155AD0 File Offset: 0x00153CD0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 158296, XrefRangeEnd = 158301, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator SearchRoutine()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PursuitBehaviour.NativeMethodInfoPtr_SearchRoutine_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr2) : null;
		}

		// Token: 0x0600443D RID: 17469 RVA: 0x00155B10 File Offset: 0x00153D10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 158301, XrefRangeEnd = 158314, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector3 GetNextSearchLocation()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(PursuitBehaviour.NativeMethodInfoPtr_GetNextSearchLocation_Private_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x0600443E RID: 17470 RVA: 0x00155B4C File Offset: 0x00153D4C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 158333, RefRangeEnd = 158337, XrefRangeStart = 158314, XrefRangeEnd = 158333, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector3 GetRandomReachablePointNear(Vector3 point, float randomRadius, float minDistance = 0f)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref point;
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref randomRadius;
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref minDistance;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(PursuitBehaviour.NativeMethodInfoPtr_GetRandomReachablePointNear_Private_Vector3_Vector3_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x0600443F RID: 17471 RVA: 0x00155BB4 File Offset: 0x00153DB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 158337, XrefRangeEnd = 158338, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetWorldspaceIconsActive(bool active)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref active;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PursuitBehaviour.NativeMethodInfoPtr_SetWorldspaceIconsActive_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004440 RID: 17472 RVA: 0x00155BF4 File Offset: 0x00153DF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 158338, XrefRangeEnd = 158341, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PursuitBehaviour() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PursuitBehaviour>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PursuitBehaviour.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004441 RID: 17473 RVA: 0x00155C30 File Offset: 0x00153E30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 158341, XrefRangeEnd = 158365, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize___Early()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PursuitBehaviour.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004442 RID: 17474 RVA: 0x00155C6C File Offset: 0x00153E6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 158365, XrefRangeEnd = 158366, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize__Late()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PursuitBehaviour.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004443 RID: 17475 RVA: 0x00155CA8 File Offset: 0x00153EA8
		[CallerCount(0)]
		public unsafe override void NetworkInitializeIfDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PursuitBehaviour.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004444 RID: 17476 RVA: 0x00155CE4 File Offset: 0x00153EE4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 158385, RefRangeEnd = 158386, XrefRangeStart = 158366, XrefRangeEnd = 158385, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_AssignTarget_1824087381(NetworkConnection conn, NetworkObject target)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(target);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PursuitBehaviour.NativeMethodInfoPtr_RpcWriter___Observers_AssignTarget_1824087381_Private_Void_NetworkConnection_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004445 RID: 17477 RVA: 0x00155D38 File Offset: 0x00153F38
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 158403, RefRangeEnd = 158405, XrefRangeStart = 158386, XrefRangeEnd = 158403, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void RpcLogic___AssignTarget_1824087381(NetworkConnection conn, NetworkObject target)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(target);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PursuitBehaviour.NativeMethodInfoPtr_RpcLogic___AssignTarget_1824087381_Public_Virtual_New_Void_NetworkConnection_NetworkObject_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004446 RID: 17478 RVA: 0x00155D98 File Offset: 0x00153F98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 158405, XrefRangeEnd = 158410, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_AssignTarget_1824087381(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref channel;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PursuitBehaviour.NativeMethodInfoPtr_RpcReader___Observers_AssignTarget_1824087381_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x170014A1 RID: 5281
		// (get) Token: 0x06004447 RID: 17479 RVA: 0x00155DE8 File Offset: 0x00153FE8
		// (set) Token: 0x06004448 RID: 17480 RVA: 0x00155E24 File Offset: 0x00154024
		public unsafe bool SyncAccessor_isTargetVisible
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(PursuitBehaviour.NativeMethodInfoPtr_sync___get_value_isTargetVisible_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 158418, RefRangeEnd = 158422, XrefRangeStart = 158410, XrefRangeEnd = 158418, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = ref value;
				ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref value;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PursuitBehaviour.NativeMethodInfoPtr_sync___set_value_isTargetVisible_Public_set_Void_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x06004449 RID: 17481 RVA: 0x00155E70 File Offset: 0x00154070
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 158422, XrefRangeEnd = 158425, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool ReadSyncVar___ScheduleOne_NPCs_Behaviour_PursuitBehaviour(PooledReader PooledReader0, uint UInt321, bool Boolean2)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref UInt321;
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref Boolean2;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PursuitBehaviour.NativeMethodInfoPtr_ReadSyncVar___ScheduleOne_NPCs_Behaviour_PursuitBehaviour_Public_Virtual_Boolean_PooledReader_UInt32_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x0600444A RID: 17482 RVA: 0x00155EE4 File Offset: 0x001540E4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 158467, RefRangeEnd = 158468, XrefRangeStart = 158425, XrefRangeEnd = 158467, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Method_Protected_Virtual_Void_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PursuitBehaviour.NativeMethodInfoPtr_Method_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600444B RID: 17483 RVA: 0x00021362 File Offset: 0x0001F562
		public PursuitBehaviour(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001479 RID: 5241
		// (get) Token: 0x0600444C RID: 17484 RVA: 0x00155F20 File Offset: 0x00154120
		// (set) Token: 0x0600444D RID: 17485 RVA: 0x0002136B File Offset: 0x0001F56B
		public unsafe static float ARREST_RANGE
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(PursuitBehaviour.NativeFieldInfoPtr_ARREST_RANGE, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PursuitBehaviour.NativeFieldInfoPtr_ARREST_RANGE, (void*)(&value));
			}
		}

		// Token: 0x1700147A RID: 5242
		// (get) Token: 0x0600444E RID: 17486 RVA: 0x00155F3C File Offset: 0x0015413C
		// (set) Token: 0x0600444F RID: 17487 RVA: 0x00021379 File Offset: 0x0001F579
		public unsafe static float ARREST_TIME
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(PursuitBehaviour.NativeFieldInfoPtr_ARREST_TIME, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PursuitBehaviour.NativeFieldInfoPtr_ARREST_TIME, (void*)(&value));
			}
		}

		// Token: 0x1700147B RID: 5243
		// (get) Token: 0x06004450 RID: 17488 RVA: 0x00155F58 File Offset: 0x00154158
		// (set) Token: 0x06004451 RID: 17489 RVA: 0x00021387 File Offset: 0x0001F587
		public unsafe static float EXTRA_VISIBILITY_TIME
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(PursuitBehaviour.NativeFieldInfoPtr_EXTRA_VISIBILITY_TIME, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PursuitBehaviour.NativeFieldInfoPtr_EXTRA_VISIBILITY_TIME, (void*)(&value));
			}
		}

		// Token: 0x1700147C RID: 5244
		// (get) Token: 0x06004452 RID: 17490 RVA: 0x00155F74 File Offset: 0x00154174
		// (set) Token: 0x06004453 RID: 17491 RVA: 0x00021395 File Offset: 0x0001F595
		public unsafe static float MOVE_SPEED_INVESTIGATING
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(PursuitBehaviour.NativeFieldInfoPtr_MOVE_SPEED_INVESTIGATING, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PursuitBehaviour.NativeFieldInfoPtr_MOVE_SPEED_INVESTIGATING, (void*)(&value));
			}
		}

		// Token: 0x1700147D RID: 5245
		// (get) Token: 0x06004454 RID: 17492 RVA: 0x00155F90 File Offset: 0x00154190
		// (set) Token: 0x06004455 RID: 17493 RVA: 0x000213A3 File Offset: 0x0001F5A3
		public unsafe static float MOVE_SPEED_ARRESTING
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(PursuitBehaviour.NativeFieldInfoPtr_MOVE_SPEED_ARRESTING, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PursuitBehaviour.NativeFieldInfoPtr_MOVE_SPEED_ARRESTING, (void*)(&value));
			}
		}

		// Token: 0x1700147E RID: 5246
		// (get) Token: 0x06004456 RID: 17494 RVA: 0x00155FAC File Offset: 0x001541AC
		// (set) Token: 0x06004457 RID: 17495 RVA: 0x000213B1 File Offset: 0x0001F5B1
		public unsafe static float MOVE_SPEED_CHASE
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(PursuitBehaviour.NativeFieldInfoPtr_MOVE_SPEED_CHASE, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PursuitBehaviour.NativeFieldInfoPtr_MOVE_SPEED_CHASE, (void*)(&value));
			}
		}

		// Token: 0x1700147F RID: 5247
		// (get) Token: 0x06004458 RID: 17496 RVA: 0x00155FC8 File Offset: 0x001541C8
		// (set) Token: 0x06004459 RID: 17497 RVA: 0x000213BF File Offset: 0x0001F5BF
		public unsafe static float MOVE_SPEED_SHOOTING
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(PursuitBehaviour.NativeFieldInfoPtr_MOVE_SPEED_SHOOTING, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PursuitBehaviour.NativeFieldInfoPtr_MOVE_SPEED_SHOOTING, (void*)(&value));
			}
		}

		// Token: 0x17001480 RID: 5248
		// (get) Token: 0x0600445A RID: 17498 RVA: 0x00155FE4 File Offset: 0x001541E4
		// (set) Token: 0x0600445B RID: 17499 RVA: 0x000213CD File Offset: 0x0001F5CD
		public unsafe static float SEARCH_RADIUS_MIN
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(PursuitBehaviour.NativeFieldInfoPtr_SEARCH_RADIUS_MIN, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PursuitBehaviour.NativeFieldInfoPtr_SEARCH_RADIUS_MIN, (void*)(&value));
			}
		}

		// Token: 0x17001481 RID: 5249
		// (get) Token: 0x0600445C RID: 17500 RVA: 0x00156000 File Offset: 0x00154200
		// (set) Token: 0x0600445D RID: 17501 RVA: 0x000213DB File Offset: 0x0001F5DB
		public unsafe static float SEARCH_RADIUS_MAX
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(PursuitBehaviour.NativeFieldInfoPtr_SEARCH_RADIUS_MAX, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PursuitBehaviour.NativeFieldInfoPtr_SEARCH_RADIUS_MAX, (void*)(&value));
			}
		}

		// Token: 0x17001482 RID: 5250
		// (get) Token: 0x0600445E RID: 17502 RVA: 0x0015601C File Offset: 0x0015421C
		// (set) Token: 0x0600445F RID: 17503 RVA: 0x000213E9 File Offset: 0x0001F5E9
		public unsafe static float ARREST_MAX_DISTANCE
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(PursuitBehaviour.NativeFieldInfoPtr_ARREST_MAX_DISTANCE, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PursuitBehaviour.NativeFieldInfoPtr_ARREST_MAX_DISTANCE, (void*)(&value));
			}
		}

		// Token: 0x17001483 RID: 5251
		// (get) Token: 0x06004460 RID: 17504 RVA: 0x00156038 File Offset: 0x00154238
		// (set) Token: 0x06004461 RID: 17505 RVA: 0x000213F7 File Offset: 0x0001F5F7
		public unsafe static int LEAVE_ARREST_CIRCLE_LIMIT
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(PursuitBehaviour.NativeFieldInfoPtr_LEAVE_ARREST_CIRCLE_LIMIT, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PursuitBehaviour.NativeFieldInfoPtr_LEAVE_ARREST_CIRCLE_LIMIT, (void*)(&value));
			}
		}

		// Token: 0x17001484 RID: 5252
		// (get) Token: 0x06004462 RID: 17506 RVA: 0x00156054 File Offset: 0x00154254
		// (set) Token: 0x06004463 RID: 17507 RVA: 0x00021405 File Offset: 0x0001F605
		public unsafe static float CONSECUTIVE_MISS_ACCURACY_BOOST
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(PursuitBehaviour.NativeFieldInfoPtr_CONSECUTIVE_MISS_ACCURACY_BOOST, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PursuitBehaviour.NativeFieldInfoPtr_CONSECUTIVE_MISS_ACCURACY_BOOST, (void*)(&value));
			}
		}

		// Token: 0x17001485 RID: 5253
		// (get) Token: 0x06004464 RID: 17508 RVA: 0x00156070 File Offset: 0x00154270
		// (set) Token: 0x06004465 RID: 17509 RVA: 0x00021413 File Offset: 0x0001F613
		public unsafe Player _TargetPlayer_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PursuitBehaviour.NativeFieldInfoPtr__TargetPlayer_k__BackingField);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Player>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PursuitBehaviour.NativeFieldInfoPtr__TargetPlayer_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001486 RID: 5254
		// (get) Token: 0x06004466 RID: 17510 RVA: 0x001560A0 File Offset: 0x001542A0
		// (set) Token: 0x06004467 RID: 17511 RVA: 0x00021432 File Offset: 0x0001F632
		public unsafe bool _IsSearching_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PursuitBehaviour.NativeFieldInfoPtr__IsSearching_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PursuitBehaviour.NativeFieldInfoPtr__IsSearching_k__BackingField)) = value;
			}
		}

		// Token: 0x17001487 RID: 5255
		// (get) Token: 0x06004468 RID: 17512 RVA: 0x001560C8 File Offset: 0x001542C8
		// (set) Token: 0x06004469 RID: 17513 RVA: 0x0002144D File Offset: 0x0001F64D
		public unsafe float ArrestCircle_MaxVisibleDistance
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PursuitBehaviour.NativeFieldInfoPtr_ArrestCircle_MaxVisibleDistance);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PursuitBehaviour.NativeFieldInfoPtr_ArrestCircle_MaxVisibleDistance)) = value;
			}
		}

		// Token: 0x17001488 RID: 5256
		// (get) Token: 0x0600446A RID: 17514 RVA: 0x001560F0 File Offset: 0x001542F0
		// (set) Token: 0x0600446B RID: 17515 RVA: 0x00021468 File Offset: 0x0001F668
		public unsafe float ArrestCircle_MaxOpacity
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PursuitBehaviour.NativeFieldInfoPtr_ArrestCircle_MaxOpacity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PursuitBehaviour.NativeFieldInfoPtr_ArrestCircle_MaxOpacity)) = value;
			}
		}

		// Token: 0x17001489 RID: 5257
		// (get) Token: 0x0600446C RID: 17516 RVA: 0x00156118 File Offset: 0x00154318
		// (set) Token: 0x0600446D RID: 17517 RVA: 0x00021483 File Offset: 0x0001F683
		public unsafe bool isTargetVisible
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PursuitBehaviour.NativeFieldInfoPtr_isTargetVisible);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PursuitBehaviour.NativeFieldInfoPtr_isTargetVisible)) = value;
			}
		}

		// Token: 0x1700148A RID: 5258
		// (get) Token: 0x0600446E RID: 17518 RVA: 0x00156140 File Offset: 0x00154340
		// (set) Token: 0x0600446F RID: 17519 RVA: 0x0002149E File Offset: 0x0001F69E
		public unsafe bool isTargetStrictlyVisible
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PursuitBehaviour.NativeFieldInfoPtr_isTargetStrictlyVisible);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PursuitBehaviour.NativeFieldInfoPtr_isTargetStrictlyVisible)) = value;
			}
		}

		// Token: 0x1700148B RID: 5259
		// (get) Token: 0x06004470 RID: 17520 RVA: 0x00156168 File Offset: 0x00154368
		// (set) Token: 0x06004471 RID: 17521 RVA: 0x000214B9 File Offset: 0x0001F6B9
		public unsafe bool arrestingEnabled
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PursuitBehaviour.NativeFieldInfoPtr_arrestingEnabled);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PursuitBehaviour.NativeFieldInfoPtr_arrestingEnabled)) = value;
			}
		}

		// Token: 0x1700148C RID: 5260
		// (get) Token: 0x06004472 RID: 17522 RVA: 0x00156190 File Offset: 0x00154390
		// (set) Token: 0x06004473 RID: 17523 RVA: 0x000214D4 File Offset: 0x0001F6D4
		public unsafe float timeSinceLastSighting
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PursuitBehaviour.NativeFieldInfoPtr_timeSinceLastSighting);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PursuitBehaviour.NativeFieldInfoPtr_timeSinceLastSighting)) = value;
			}
		}

		// Token: 0x1700148D RID: 5261
		// (get) Token: 0x06004474 RID: 17524 RVA: 0x001561B8 File Offset: 0x001543B8
		// (set) Token: 0x06004475 RID: 17525 RVA: 0x000214EF File Offset: 0x0001F6EF
		public unsafe float currentPursuitLevelDuration
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PursuitBehaviour.NativeFieldInfoPtr_currentPursuitLevelDuration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PursuitBehaviour.NativeFieldInfoPtr_currentPursuitLevelDuration)) = value;
			}
		}

		// Token: 0x1700148E RID: 5262
		// (get) Token: 0x06004476 RID: 17526 RVA: 0x001561E0 File Offset: 0x001543E0
		// (set) Token: 0x06004477 RID: 17527 RVA: 0x0002150A File Offset: 0x0001F70A
		public unsafe float timeWithinArrestRange
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PursuitBehaviour.NativeFieldInfoPtr_timeWithinArrestRange);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PursuitBehaviour.NativeFieldInfoPtr_timeWithinArrestRange)) = value;
			}
		}

		// Token: 0x1700148F RID: 5263
		// (get) Token: 0x06004478 RID: 17528 RVA: 0x00156208 File Offset: 0x00154408
		// (set) Token: 0x06004479 RID: 17529 RVA: 0x00021525 File Offset: 0x0001F725
		public unsafe float playerSightedDuration
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PursuitBehaviour.NativeFieldInfoPtr_playerSightedDuration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PursuitBehaviour.NativeFieldInfoPtr_playerSightedDuration)) = value;
			}
		}

		// Token: 0x17001490 RID: 5264
		// (get) Token: 0x0600447A RID: 17530 RVA: 0x00156230 File Offset: 0x00154430
		// (set) Token: 0x0600447B RID: 17531 RVA: 0x00021540 File Offset: 0x0001F740
		public unsafe float distanceOnPursuitStart
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PursuitBehaviour.NativeFieldInfoPtr_distanceOnPursuitStart);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PursuitBehaviour.NativeFieldInfoPtr_distanceOnPursuitStart)) = value;
			}
		}

		// Token: 0x17001491 RID: 5265
		// (get) Token: 0x0600447C RID: 17532 RVA: 0x00156258 File Offset: 0x00154458
		// (set) Token: 0x0600447D RID: 17533 RVA: 0x0002155B File Offset: 0x0001F75B
		public unsafe Coroutine searchRoutine
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PursuitBehaviour.NativeFieldInfoPtr_searchRoutine);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PursuitBehaviour.NativeFieldInfoPtr_searchRoutine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001492 RID: 5266
		// (get) Token: 0x0600447E RID: 17534 RVA: 0x00156288 File Offset: 0x00154488
		// (set) Token: 0x0600447F RID: 17535 RVA: 0x0002157A File Offset: 0x0001F77A
		public unsafe Coroutine rangedWeaponRoutine
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PursuitBehaviour.NativeFieldInfoPtr_rangedWeaponRoutine);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PursuitBehaviour.NativeFieldInfoPtr_rangedWeaponRoutine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001493 RID: 5267
		// (get) Token: 0x06004480 RID: 17536 RVA: 0x001562B8 File Offset: 0x001544B8
		// (set) Token: 0x06004481 RID: 17537 RVA: 0x00021599 File Offset: 0x0001F799
		public unsafe Vector3 currentSearchDestination
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PursuitBehaviour.NativeFieldInfoPtr_currentSearchDestination);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PursuitBehaviour.NativeFieldInfoPtr_currentSearchDestination)) = value;
			}
		}

		// Token: 0x17001494 RID: 5268
		// (get) Token: 0x06004482 RID: 17538 RVA: 0x001562E0 File Offset: 0x001544E0
		// (set) Token: 0x06004483 RID: 17539 RVA: 0x000215B4 File Offset: 0x0001F7B4
		public unsafe bool hasSearchDestination
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PursuitBehaviour.NativeFieldInfoPtr_hasSearchDestination);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PursuitBehaviour.NativeFieldInfoPtr_hasSearchDestination)) = value;
			}
		}

		// Token: 0x17001495 RID: 5269
		// (get) Token: 0x06004484 RID: 17540 RVA: 0x00156308 File Offset: 0x00154508
		// (set) Token: 0x06004485 RID: 17541 RVA: 0x000215CF File Offset: 0x0001F7CF
		public unsafe PoliceOfficer officer
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PursuitBehaviour.NativeFieldInfoPtr_officer);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PoliceOfficer>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PursuitBehaviour.NativeFieldInfoPtr_officer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001496 RID: 5270
		// (get) Token: 0x06004486 RID: 17542 RVA: 0x00156338 File Offset: 0x00154538
		// (set) Token: 0x06004487 RID: 17543 RVA: 0x000215EE File Offset: 0x0001F7EE
		public unsafe bool targetWasDrivingOnPursuitStart
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PursuitBehaviour.NativeFieldInfoPtr_targetWasDrivingOnPursuitStart);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PursuitBehaviour.NativeFieldInfoPtr_targetWasDrivingOnPursuitStart)) = value;
			}
		}

		// Token: 0x17001497 RID: 5271
		// (get) Token: 0x06004488 RID: 17544 RVA: 0x00156360 File Offset: 0x00154560
		// (set) Token: 0x06004489 RID: 17545 RVA: 0x00021609 File Offset: 0x0001F809
		public unsafe bool wasInArrestCircleLastFrame
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PursuitBehaviour.NativeFieldInfoPtr_wasInArrestCircleLastFrame);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PursuitBehaviour.NativeFieldInfoPtr_wasInArrestCircleLastFrame)) = value;
			}
		}

		// Token: 0x17001498 RID: 5272
		// (get) Token: 0x0600448A RID: 17546 RVA: 0x00156388 File Offset: 0x00154588
		// (set) Token: 0x0600448B RID: 17547 RVA: 0x00021624 File Offset: 0x0001F824
		public unsafe int leaveArrestCircleCount
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PursuitBehaviour.NativeFieldInfoPtr_leaveArrestCircleCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PursuitBehaviour.NativeFieldInfoPtr_leaveArrestCircleCount)) = value;
			}
		}

		// Token: 0x17001499 RID: 5273
		// (get) Token: 0x0600448C RID: 17548 RVA: 0x001563B0 File Offset: 0x001545B0
		// (set) Token: 0x0600448D RID: 17549 RVA: 0x0002163F File Offset: 0x0001F83F
		public unsafe AvatarRangedWeapon rangedWeapon
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PursuitBehaviour.NativeFieldInfoPtr_rangedWeapon);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AvatarRangedWeapon>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PursuitBehaviour.NativeFieldInfoPtr_rangedWeapon), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700149A RID: 5274
		// (get) Token: 0x0600448E RID: 17550 RVA: 0x001563E0 File Offset: 0x001545E0
		// (set) Token: 0x0600448F RID: 17551 RVA: 0x0002165E File Offset: 0x0001F85E
		public unsafe int consecutiveMissedShots
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PursuitBehaviour.NativeFieldInfoPtr_consecutiveMissedShots);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PursuitBehaviour.NativeFieldInfoPtr_consecutiveMissedShots)) = value;
			}
		}

		// Token: 0x1700149B RID: 5275
		// (get) Token: 0x06004490 RID: 17552 RVA: 0x00156408 File Offset: 0x00154608
		// (set) Token: 0x06004491 RID: 17553 RVA: 0x00021679 File Offset: 0x0001F879
		public unsafe float nextAngryVO
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PursuitBehaviour.NativeFieldInfoPtr_nextAngryVO);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PursuitBehaviour.NativeFieldInfoPtr_nextAngryVO)) = value;
			}
		}

		// Token: 0x1700149C RID: 5276
		// (get) Token: 0x06004492 RID: 17554 RVA: 0x00156430 File Offset: 0x00154630
		// (set) Token: 0x06004493 RID: 17555 RVA: 0x00021694 File Offset: 0x0001F894
		public unsafe SyncVar<bool> syncVar___isTargetVisible
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PursuitBehaviour.NativeFieldInfoPtr_syncVar___isTargetVisible);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SyncVar<bool>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PursuitBehaviour.NativeFieldInfoPtr_syncVar___isTargetVisible), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700149D RID: 5277
		// (get) Token: 0x06004494 RID: 17556 RVA: 0x00156460 File Offset: 0x00154660
		// (set) Token: 0x06004495 RID: 17557 RVA: 0x000216B3 File Offset: 0x0001F8B3
		public new unsafe bool field_Private_Boolean_0
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PursuitBehaviour.NativeFieldInfoPtr_field_Private_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PursuitBehaviour.NativeFieldInfoPtr_field_Private_Boolean_0)) = value;
			}
		}

		// Token: 0x1700149E RID: 5278
		// (get) Token: 0x06004496 RID: 17558 RVA: 0x00156488 File Offset: 0x00154688
		// (set) Token: 0x06004497 RID: 17559 RVA: 0x000216CE File Offset: 0x0001F8CE
		public new unsafe bool field_Private_Boolean_1
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PursuitBehaviour.NativeFieldInfoPtr_field_Private_Boolean_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PursuitBehaviour.NativeFieldInfoPtr_field_Private_Boolean_1)) = value;
			}
		}

		// Token: 0x04002D7C RID: 11644
		private static readonly System.IntPtr NativeFieldInfoPtr_ARREST_RANGE;

		// Token: 0x04002D7D RID: 11645
		private static readonly System.IntPtr NativeFieldInfoPtr_ARREST_TIME;

		// Token: 0x04002D7E RID: 11646
		private static readonly System.IntPtr NativeFieldInfoPtr_EXTRA_VISIBILITY_TIME;

		// Token: 0x04002D7F RID: 11647
		private static readonly System.IntPtr NativeFieldInfoPtr_MOVE_SPEED_INVESTIGATING;

		// Token: 0x04002D80 RID: 11648
		private static readonly System.IntPtr NativeFieldInfoPtr_MOVE_SPEED_ARRESTING;

		// Token: 0x04002D81 RID: 11649
		private static readonly System.IntPtr NativeFieldInfoPtr_MOVE_SPEED_CHASE;

		// Token: 0x04002D82 RID: 11650
		private static readonly System.IntPtr NativeFieldInfoPtr_MOVE_SPEED_SHOOTING;

		// Token: 0x04002D83 RID: 11651
		private static readonly System.IntPtr NativeFieldInfoPtr_SEARCH_RADIUS_MIN;

		// Token: 0x04002D84 RID: 11652
		private static readonly System.IntPtr NativeFieldInfoPtr_SEARCH_RADIUS_MAX;

		// Token: 0x04002D85 RID: 11653
		private static readonly System.IntPtr NativeFieldInfoPtr_ARREST_MAX_DISTANCE;

		// Token: 0x04002D86 RID: 11654
		private static readonly System.IntPtr NativeFieldInfoPtr_LEAVE_ARREST_CIRCLE_LIMIT;

		// Token: 0x04002D87 RID: 11655
		private static readonly System.IntPtr NativeFieldInfoPtr_CONSECUTIVE_MISS_ACCURACY_BOOST;

		// Token: 0x04002D88 RID: 11656
		private static readonly System.IntPtr NativeFieldInfoPtr__TargetPlayer_k__BackingField;

		// Token: 0x04002D89 RID: 11657
		private static readonly System.IntPtr NativeFieldInfoPtr__IsSearching_k__BackingField;

		// Token: 0x04002D8A RID: 11658
		private static readonly System.IntPtr NativeFieldInfoPtr_ArrestCircle_MaxVisibleDistance;

		// Token: 0x04002D8B RID: 11659
		private static readonly System.IntPtr NativeFieldInfoPtr_ArrestCircle_MaxOpacity;

		// Token: 0x04002D8C RID: 11660
		private static readonly System.IntPtr NativeFieldInfoPtr_isTargetVisible;

		// Token: 0x04002D8D RID: 11661
		private static readonly System.IntPtr NativeFieldInfoPtr_isTargetStrictlyVisible;

		// Token: 0x04002D8E RID: 11662
		private static readonly System.IntPtr NativeFieldInfoPtr_arrestingEnabled;

		// Token: 0x04002D8F RID: 11663
		private static readonly System.IntPtr NativeFieldInfoPtr_timeSinceLastSighting;

		// Token: 0x04002D90 RID: 11664
		private static readonly System.IntPtr NativeFieldInfoPtr_currentPursuitLevelDuration;

		// Token: 0x04002D91 RID: 11665
		private static readonly System.IntPtr NativeFieldInfoPtr_timeWithinArrestRange;

		// Token: 0x04002D92 RID: 11666
		private static readonly System.IntPtr NativeFieldInfoPtr_playerSightedDuration;

		// Token: 0x04002D93 RID: 11667
		private static readonly System.IntPtr NativeFieldInfoPtr_distanceOnPursuitStart;

		// Token: 0x04002D94 RID: 11668
		private static readonly System.IntPtr NativeFieldInfoPtr_searchRoutine;

		// Token: 0x04002D95 RID: 11669
		private static readonly System.IntPtr NativeFieldInfoPtr_rangedWeaponRoutine;

		// Token: 0x04002D96 RID: 11670
		private static readonly System.IntPtr NativeFieldInfoPtr_currentSearchDestination;

		// Token: 0x04002D97 RID: 11671
		private static readonly System.IntPtr NativeFieldInfoPtr_hasSearchDestination;

		// Token: 0x04002D98 RID: 11672
		private static readonly System.IntPtr NativeFieldInfoPtr_officer;

		// Token: 0x04002D99 RID: 11673
		private static readonly System.IntPtr NativeFieldInfoPtr_targetWasDrivingOnPursuitStart;

		// Token: 0x04002D9A RID: 11674
		private static readonly System.IntPtr NativeFieldInfoPtr_wasInArrestCircleLastFrame;

		// Token: 0x04002D9B RID: 11675
		private static readonly System.IntPtr NativeFieldInfoPtr_leaveArrestCircleCount;

		// Token: 0x04002D9C RID: 11676
		private static readonly System.IntPtr NativeFieldInfoPtr_rangedWeapon;

		// Token: 0x04002D9D RID: 11677
		private static readonly System.IntPtr NativeFieldInfoPtr_consecutiveMissedShots;

		// Token: 0x04002D9E RID: 11678
		private static readonly System.IntPtr NativeFieldInfoPtr_nextAngryVO;

		// Token: 0x04002D9F RID: 11679
		private static readonly System.IntPtr NativeFieldInfoPtr_syncVar___isTargetVisible;

		// Token: 0x04002DA0 RID: 11680
		private static readonly System.IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

		// Token: 0x04002DA1 RID: 11681
		private static readonly System.IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

		// Token: 0x04002DA2 RID: 11682
		private static readonly System.IntPtr NativeMethodInfoPtr_get_TargetPlayer_Public_get_Player_0;

		// Token: 0x04002DA3 RID: 11683
		private static readonly System.IntPtr NativeMethodInfoPtr_set_TargetPlayer_Protected_set_Void_Player_0;

		// Token: 0x04002DA4 RID: 11684
		private static readonly System.IntPtr NativeMethodInfoPtr_get_IsSearching_Public_get_Boolean_0;

		// Token: 0x04002DA5 RID: 11685
		private static readonly System.IntPtr NativeMethodInfoPtr_set_IsSearching_Protected_set_Void_Boolean_0;

		// Token: 0x04002DA6 RID: 11686
		private static readonly System.IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;

		// Token: 0x04002DA7 RID: 11687
		private static readonly System.IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

		// Token: 0x04002DA8 RID: 11688
		private static readonly System.IntPtr NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0;

		// Token: 0x04002DA9 RID: 11689
		private static readonly System.IntPtr NativeMethodInfoPtr_AssignTarget_Public_Virtual_New_Void_NetworkConnection_NetworkObject_0;

		// Token: 0x04002DAA RID: 11690
		private static readonly System.IntPtr NativeMethodInfoPtr_Begin_Protected_Virtual_Void_1;

		// Token: 0x04002DAB RID: 11691
		private static readonly System.IntPtr NativeMethodInfoPtr_Resume_Protected_Virtual_Void_1;

		// Token: 0x04002DAC RID: 11692
		private static readonly System.IntPtr NativeMethodInfoPtr_BehaviourUpdate_Public_Virtual_Void_0;

		// Token: 0x04002DAD RID: 11693
		private static readonly System.IntPtr NativeMethodInfoPtr_ActiveMinPass_Public_Virtual_Void_0;

		// Token: 0x04002DAE RID: 11694
		private static readonly System.IntPtr NativeMethodInfoPtr_IsTargetValid_Private_Boolean_0;

		// Token: 0x04002DAF RID: 11695
		private static readonly System.IntPtr NativeMethodInfoPtr_FixedUpdate_Protected_Virtual_New_Void_0;

		// Token: 0x04002DB0 RID: 11696
		private static readonly System.IntPtr NativeMethodInfoPtr_UpdateInvestigatingBehaviour_Protected_Virtual_New_Void_0;

		// Token: 0x04002DB1 RID: 11697
		private static readonly System.IntPtr NativeMethodInfoPtr_UpdateArrestBehaviour_Protected_Virtual_New_Void_0;

		// Token: 0x04002DB2 RID: 11698
		private static readonly System.IntPtr NativeMethodInfoPtr_UpdateArrest_Private_Void_Single_0;

		// Token: 0x04002DB3 RID: 11699
		private static readonly System.IntPtr NativeMethodInfoPtr_GetNewArrestDestination_Private_Vector3_0;

		// Token: 0x04002DB4 RID: 11700
		private static readonly System.IntPtr NativeMethodInfoPtr_ClearSpeedControls_Private_Void_0;

		// Token: 0x04002DB5 RID: 11701
		private static readonly System.IntPtr NativeMethodInfoPtr_UpdateNonLethalBehaviour_Protected_Virtual_New_Void_0;

		// Token: 0x04002DB6 RID: 11702
		private static readonly System.IntPtr NativeMethodInfoPtr_UpdateLethalBehaviour_Protected_Virtual_New_Void_0;

		// Token: 0x04002DB7 RID: 11703
		private static readonly System.IntPtr NativeMethodInfoPtr_RangedWeaponRoutine_Private_IEnumerator_0;

		// Token: 0x04002DB8 RID: 11704
		private static readonly System.IntPtr NativeMethodInfoPtr_CanShoot_Private_Boolean_0;

		// Token: 0x04002DB9 RID: 11705
		private static readonly System.IntPtr NativeMethodInfoPtr_Shoot_Private_Boolean_0;

		// Token: 0x04002DBA RID: 11706
		private static readonly System.IntPtr NativeMethodInfoPtr_SetWeaponRaised_Private_Void_Boolean_0;

		// Token: 0x04002DBB RID: 11707
		private static readonly System.IntPtr NativeMethodInfoPtr_StopRangedWeaponRoutine_Private_Void_0;

		// Token: 0x04002DBC RID: 11708
		private static readonly System.IntPtr NativeMethodInfoPtr_UpdateLookAt_Protected_Virtual_New_Void_0;

		// Token: 0x04002DBD RID: 11709
		private static readonly System.IntPtr NativeMethodInfoPtr_UpdateEquippable_Protected_Virtual_New_Void_0;

		// Token: 0x04002DBE RID: 11710
		private static readonly System.IntPtr NativeMethodInfoPtr_Disable_Public_Virtual_Void_0;

		// Token: 0x04002DBF RID: 11711
		private static readonly System.IntPtr NativeMethodInfoPtr_Pause_Protected_Virtual_Void_1;

		// Token: 0x04002DC0 RID: 11712
		private static readonly System.IntPtr NativeMethodInfoPtr_End_Protected_Virtual_Void_1;

		// Token: 0x04002DC1 RID: 11713
		private static readonly System.IntPtr NativeMethodInfoPtr_Stop_Private_Void_0;

		// Token: 0x04002DC2 RID: 11714
		private static readonly System.IntPtr NativeMethodInfoPtr_ClearEquippables_Private_Void_0;

		// Token: 0x04002DC3 RID: 11715
		private static readonly System.IntPtr NativeMethodInfoPtr_CheckPlayerVisibility_Protected_Void_0;

		// Token: 0x04002DC4 RID: 11716
		private static readonly System.IntPtr NativeMethodInfoPtr_MarkPlayerVisible_Public_Void_0;

		// Token: 0x04002DC5 RID: 11717
		private static readonly System.IntPtr NativeMethodInfoPtr_IsPlayerVisible_Protected_Boolean_0;

		// Token: 0x04002DC6 RID: 11718
		private static readonly System.IntPtr NativeMethodInfoPtr_ProcessVisionEvent_Private_Void_VisionEventReceipt_0;

		// Token: 0x04002DC7 RID: 11719
		private static readonly System.IntPtr NativeMethodInfoPtr_ProcessThirdPartyVisionEvent_Private_Void_VisionEventReceipt_0;

		// Token: 0x04002DC8 RID: 11720
		private static readonly System.IntPtr NativeMethodInfoPtr_UpdateArrestCircle_Protected_Virtual_New_Void_0;

		// Token: 0x04002DC9 RID: 11721
		private static readonly System.IntPtr NativeMethodInfoPtr_ResetArrestProgress_Public_Void_0;

		// Token: 0x04002DCA RID: 11722
		private static readonly System.IntPtr NativeMethodInfoPtr_SetArrestCircleAlpha_Private_Void_Single_0;

		// Token: 0x04002DCB RID: 11723
		private static readonly System.IntPtr NativeMethodInfoPtr_SetArrestCircleColor_Private_Void_Color_0;

		// Token: 0x04002DCC RID: 11724
		private static readonly System.IntPtr NativeMethodInfoPtr_StartSearching_Private_Void_0;

		// Token: 0x04002DCD RID: 11725
		private static readonly System.IntPtr NativeMethodInfoPtr_StopSearching_Private_Void_0;

		// Token: 0x04002DCE RID: 11726
		private static readonly System.IntPtr NativeMethodInfoPtr_SearchRoutine_Private_IEnumerator_0;

		// Token: 0x04002DCF RID: 11727
		private static readonly System.IntPtr NativeMethodInfoPtr_GetNextSearchLocation_Private_Vector3_0;

		// Token: 0x04002DD0 RID: 11728
		private static readonly System.IntPtr NativeMethodInfoPtr_GetRandomReachablePointNear_Private_Vector3_Vector3_Single_Single_0;

		// Token: 0x04002DD1 RID: 11729
		private static readonly System.IntPtr NativeMethodInfoPtr_SetWorldspaceIconsActive_Private_Void_Boolean_0;

		// Token: 0x04002DD2 RID: 11730
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04002DD3 RID: 11731
		private static readonly System.IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

		// Token: 0x04002DD4 RID: 11732
		private static readonly System.IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

		// Token: 0x04002DD5 RID: 11733
		private static readonly System.IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

		// Token: 0x04002DD6 RID: 11734
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcWriter___Observers_AssignTarget_1824087381_Private_Void_NetworkConnection_NetworkObject_0;

		// Token: 0x04002DD7 RID: 11735
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcLogic___AssignTarget_1824087381_Public_Virtual_New_Void_NetworkConnection_NetworkObject_0;

		// Token: 0x04002DD8 RID: 11736
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcReader___Observers_AssignTarget_1824087381_Private_Void_PooledReader_Channel_0;

		// Token: 0x04002DD9 RID: 11737
		private static readonly System.IntPtr NativeMethodInfoPtr_sync___get_value_isTargetVisible_Public_get_Boolean_0;

		// Token: 0x04002DDA RID: 11738
		private static readonly System.IntPtr NativeMethodInfoPtr_sync___set_value_isTargetVisible_Public_set_Void_Boolean_Boolean_0;

		// Token: 0x04002DDB RID: 11739
		private static readonly System.IntPtr NativeMethodInfoPtr_ReadSyncVar___ScheduleOne_NPCs_Behaviour_PursuitBehaviour_Public_Virtual_Boolean_PooledReader_UInt32_Boolean_0;

		// Token: 0x04002DDC RID: 11740
		private static readonly System.IntPtr NativeMethodInfoPtr_Method_Protected_Virtual_Void_0;

		// Token: 0x020009AD RID: 2477
		[OriginalName("Assembly-CSharp.dll", "", "EPursuitAction")]
		public enum EPursuitAction
		{
			// Token: 0x04008B91 RID: 35729
			None,
			// Token: 0x04008B92 RID: 35730
			Move,
			// Token: 0x04008B93 RID: 35731
			Shoot,
			// Token: 0x04008B94 RID: 35732
			MoveAndShoot
		}

		// Token: 0x020009AE RID: 2478
		[ObfuscatedName("ScheduleOne.NPCs.Behaviour.PursuitBehaviour+<RangedWeaponRoutine>d__59")]
		public sealed class _RangedWeaponRoutine_d__59 : Il2CppSystem.Object
		{
			// Token: 0x0600CE27 RID: 52775 RVA: 0x00320B80 File Offset: 0x0031ED80
			// Note: this type is marked as 'beforefieldinit'.
			static _RangedWeaponRoutine_d__59()
			{
				Il2CppClassPointerStore<PursuitBehaviour._RangedWeaponRoutine_d__59>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PursuitBehaviour>.NativeClassPtr, "<RangedWeaponRoutine>d__59");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PursuitBehaviour._RangedWeaponRoutine_d__59>.NativeClassPtr);
				PursuitBehaviour._RangedWeaponRoutine_d__59.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PursuitBehaviour._RangedWeaponRoutine_d__59>.NativeClassPtr, "<>1__state");
				PursuitBehaviour._RangedWeaponRoutine_d__59.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PursuitBehaviour._RangedWeaponRoutine_d__59>.NativeClassPtr, "<>2__current");
				PursuitBehaviour._RangedWeaponRoutine_d__59.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PursuitBehaviour._RangedWeaponRoutine_d__59>.NativeClassPtr, "<>4__this");
				PursuitBehaviour._RangedWeaponRoutine_d__59.NativeFieldInfoPtr__currentAction_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PursuitBehaviour._RangedWeaponRoutine_d__59>.NativeClassPtr, "<currentAction>5__2");
				PursuitBehaviour._RangedWeaponRoutine_d__59.NativeFieldInfoPtr__currentActionDuration_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PursuitBehaviour._RangedWeaponRoutine_d__59>.NativeClassPtr, "<currentActionDuration>5__3");
				PursuitBehaviour._RangedWeaponRoutine_d__59.NativeFieldInfoPtr__currentActionTime_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PursuitBehaviour._RangedWeaponRoutine_d__59>.NativeClassPtr, "<currentActionTime>5__4");
				PursuitBehaviour._RangedWeaponRoutine_d__59.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PursuitBehaviour._RangedWeaponRoutine_d__59>.NativeClassPtr, 100671736);
				PursuitBehaviour._RangedWeaponRoutine_d__59.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PursuitBehaviour._RangedWeaponRoutine_d__59>.NativeClassPtr, 100671737);
				PursuitBehaviour._RangedWeaponRoutine_d__59.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PursuitBehaviour._RangedWeaponRoutine_d__59>.NativeClassPtr, 100671738);
				PursuitBehaviour._RangedWeaponRoutine_d__59.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PursuitBehaviour._RangedWeaponRoutine_d__59>.NativeClassPtr, 100671739);
				PursuitBehaviour._RangedWeaponRoutine_d__59.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PursuitBehaviour._RangedWeaponRoutine_d__59>.NativeClassPtr, 100671740);
				PursuitBehaviour._RangedWeaponRoutine_d__59.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PursuitBehaviour._RangedWeaponRoutine_d__59>.NativeClassPtr, 100671741);
			}

			// Token: 0x0600CE28 RID: 52776 RVA: 0x00320C9C File Offset: 0x0031EE9C
			[CallerCount(54)]
			[CachedScanResults(RefRangeStart = 2646, RefRangeEnd = 2700, XrefRangeStart = 2646, XrefRangeEnd = 2700, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _RangedWeaponRoutine_d__59(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PursuitBehaviour._RangedWeaponRoutine_d__59>.NativeClassPtr))
			{
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = ref <>1__state;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PursuitBehaviour._RangedWeaponRoutine_d__59.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600CE29 RID: 52777 RVA: 0x00320CE4 File Offset: 0x0031EEE4
			[CallerCount(14558)]
			[CachedScanResults(RefRangeStart = 2769, RefRangeEnd = 17327, XrefRangeStart = 2769, XrefRangeEnd = 17327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PursuitBehaviour._RangedWeaponRoutine_d__59.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600CE2A RID: 52778 RVA: 0x00320D18 File Offset: 0x0031EF18
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 157670, XrefRangeEnd = 157819, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(PursuitBehaviour._RangedWeaponRoutine_d__59.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x17004003 RID: 16387
			// (get) Token: 0x0600CE2B RID: 52779 RVA: 0x00320D54 File Offset: 0x0031EF54
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 2740, RefRangeEnd = 2764, XrefRangeStart = 2740, XrefRangeEnd = 2764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PursuitBehaviour._RangedWeaponRoutine_d__59.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
			}

			// Token: 0x0600CE2C RID: 52780 RVA: 0x00320D94 File Offset: 0x0031EF94
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 157819, XrefRangeEnd = 157824, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PursuitBehaviour._RangedWeaponRoutine_d__59.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x17004004 RID: 16388
			// (get) Token: 0x0600CE2D RID: 52781 RVA: 0x00320DC8 File Offset: 0x0031EFC8
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 2740, RefRangeEnd = 2764, XrefRangeStart = 2740, XrefRangeEnd = 2764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PursuitBehaviour._RangedWeaponRoutine_d__59.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
			}

			// Token: 0x0600CE2E RID: 52782 RVA: 0x00063F57 File Offset: 0x00062157
			public _RangedWeaponRoutine_d__59(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003FFD RID: 16381
			// (get) Token: 0x0600CE2F RID: 52783 RVA: 0x00320E08 File Offset: 0x0031F008
			// (set) Token: 0x0600CE30 RID: 52784 RVA: 0x00063F60 File Offset: 0x00062160
			public unsafe int __1__state
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PursuitBehaviour._RangedWeaponRoutine_d__59.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PursuitBehaviour._RangedWeaponRoutine_d__59.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17003FFE RID: 16382
			// (get) Token: 0x0600CE31 RID: 52785 RVA: 0x00320E30 File Offset: 0x0031F030
			// (set) Token: 0x0600CE32 RID: 52786 RVA: 0x00063F7B File Offset: 0x0006217B
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PursuitBehaviour._RangedWeaponRoutine_d__59.NativeFieldInfoPtr___2__current);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PursuitBehaviour._RangedWeaponRoutine_d__59.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003FFF RID: 16383
			// (get) Token: 0x0600CE33 RID: 52787 RVA: 0x00320E60 File Offset: 0x0031F060
			// (set) Token: 0x0600CE34 RID: 52788 RVA: 0x00063F9A File Offset: 0x0006219A
			public unsafe PursuitBehaviour __4__this
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PursuitBehaviour._RangedWeaponRoutine_d__59.NativeFieldInfoPtr___4__this);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PursuitBehaviour>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PursuitBehaviour._RangedWeaponRoutine_d__59.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004000 RID: 16384
			// (get) Token: 0x0600CE35 RID: 52789 RVA: 0x00320E90 File Offset: 0x0031F090
			// (set) Token: 0x0600CE36 RID: 52790 RVA: 0x00063FB9 File Offset: 0x000621B9
			public unsafe PursuitBehaviour.EPursuitAction _currentAction_5__2
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PursuitBehaviour._RangedWeaponRoutine_d__59.NativeFieldInfoPtr__currentAction_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PursuitBehaviour._RangedWeaponRoutine_d__59.NativeFieldInfoPtr__currentAction_5__2)) = value;
				}
			}

			// Token: 0x17004001 RID: 16385
			// (get) Token: 0x0600CE37 RID: 52791 RVA: 0x00320EB8 File Offset: 0x0031F0B8
			// (set) Token: 0x0600CE38 RID: 52792 RVA: 0x00063FD4 File Offset: 0x000621D4
			public unsafe float _currentActionDuration_5__3
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PursuitBehaviour._RangedWeaponRoutine_d__59.NativeFieldInfoPtr__currentActionDuration_5__3);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PursuitBehaviour._RangedWeaponRoutine_d__59.NativeFieldInfoPtr__currentActionDuration_5__3)) = value;
				}
			}

			// Token: 0x17004002 RID: 16386
			// (get) Token: 0x0600CE39 RID: 52793 RVA: 0x00320EE0 File Offset: 0x0031F0E0
			// (set) Token: 0x0600CE3A RID: 52794 RVA: 0x00063FEF File Offset: 0x000621EF
			public unsafe float _currentActionTime_5__4
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PursuitBehaviour._RangedWeaponRoutine_d__59.NativeFieldInfoPtr__currentActionTime_5__4);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PursuitBehaviour._RangedWeaponRoutine_d__59.NativeFieldInfoPtr__currentActionTime_5__4)) = value;
				}
			}

			// Token: 0x04008B95 RID: 35733
			private static readonly System.IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04008B96 RID: 35734
			private static readonly System.IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04008B97 RID: 35735
			private static readonly System.IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04008B98 RID: 35736
			private static readonly System.IntPtr NativeFieldInfoPtr__currentAction_5__2;

			// Token: 0x04008B99 RID: 35737
			private static readonly System.IntPtr NativeFieldInfoPtr__currentActionDuration_5__3;

			// Token: 0x04008B9A RID: 35738
			private static readonly System.IntPtr NativeFieldInfoPtr__currentActionTime_5__4;

			// Token: 0x04008B9B RID: 35739
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04008B9C RID: 35740
			private static readonly System.IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008B9D RID: 35741
			private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04008B9E RID: 35742
			private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04008B9F RID: 35743
			private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008BA0 RID: 35744
			private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x020009AF RID: 2479
		[ObfuscatedName("ScheduleOne.NPCs.Behaviour.PursuitBehaviour+<SearchRoutine>d__82")]
		public sealed class _SearchRoutine_d__82 : Il2CppSystem.Object
		{
			// Token: 0x0600CE3B RID: 52795 RVA: 0x00320F08 File Offset: 0x0031F108
			// Note: this type is marked as 'beforefieldinit'.
			static _SearchRoutine_d__82()
			{
				Il2CppClassPointerStore<PursuitBehaviour._SearchRoutine_d__82>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PursuitBehaviour>.NativeClassPtr, "<SearchRoutine>d__82");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PursuitBehaviour._SearchRoutine_d__82>.NativeClassPtr);
				PursuitBehaviour._SearchRoutine_d__82.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PursuitBehaviour._SearchRoutine_d__82>.NativeClassPtr, "<>1__state");
				PursuitBehaviour._SearchRoutine_d__82.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PursuitBehaviour._SearchRoutine_d__82>.NativeClassPtr, "<>2__current");
				PursuitBehaviour._SearchRoutine_d__82.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PursuitBehaviour._SearchRoutine_d__82>.NativeClassPtr, "<>4__this");
				PursuitBehaviour._SearchRoutine_d__82.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PursuitBehaviour._SearchRoutine_d__82>.NativeClassPtr, 100671742);
				PursuitBehaviour._SearchRoutine_d__82.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PursuitBehaviour._SearchRoutine_d__82>.NativeClassPtr, 100671743);
				PursuitBehaviour._SearchRoutine_d__82.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PursuitBehaviour._SearchRoutine_d__82>.NativeClassPtr, 100671744);
				PursuitBehaviour._SearchRoutine_d__82.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PursuitBehaviour._SearchRoutine_d__82>.NativeClassPtr, 100671745);
				PursuitBehaviour._SearchRoutine_d__82.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PursuitBehaviour._SearchRoutine_d__82>.NativeClassPtr, 100671746);
				PursuitBehaviour._SearchRoutine_d__82.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PursuitBehaviour._SearchRoutine_d__82>.NativeClassPtr, 100671747);
			}

			// Token: 0x0600CE3C RID: 52796 RVA: 0x00320FE8 File Offset: 0x0031F1E8
			[CallerCount(54)]
			[CachedScanResults(RefRangeStart = 2646, RefRangeEnd = 2700, XrefRangeStart = 2646, XrefRangeEnd = 2700, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _SearchRoutine_d__82(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PursuitBehaviour._SearchRoutine_d__82>.NativeClassPtr))
			{
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = ref <>1__state;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PursuitBehaviour._SearchRoutine_d__82.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600CE3D RID: 52797 RVA: 0x00321030 File Offset: 0x0031F230
			[CallerCount(14558)]
			[CachedScanResults(RefRangeStart = 2769, RefRangeEnd = 17327, XrefRangeStart = 2769, XrefRangeEnd = 17327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PursuitBehaviour._SearchRoutine_d__82.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600CE3E RID: 52798 RVA: 0x00321064 File Offset: 0x0031F264
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 157824, XrefRangeEnd = 157825, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(PursuitBehaviour._SearchRoutine_d__82.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x17004008 RID: 16392
			// (get) Token: 0x0600CE3F RID: 52799 RVA: 0x003210A0 File Offset: 0x0031F2A0
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 2740, RefRangeEnd = 2764, XrefRangeStart = 2740, XrefRangeEnd = 2764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PursuitBehaviour._SearchRoutine_d__82.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
			}

			// Token: 0x0600CE40 RID: 52800 RVA: 0x003210E0 File Offset: 0x0031F2E0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 157825, XrefRangeEnd = 157830, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PursuitBehaviour._SearchRoutine_d__82.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x17004009 RID: 16393
			// (get) Token: 0x0600CE41 RID: 52801 RVA: 0x00321114 File Offset: 0x0031F314
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 2740, RefRangeEnd = 2764, XrefRangeStart = 2740, XrefRangeEnd = 2764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PursuitBehaviour._SearchRoutine_d__82.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
			}

			// Token: 0x0600CE42 RID: 52802 RVA: 0x0006400A File Offset: 0x0006220A
			public _SearchRoutine_d__82(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004005 RID: 16389
			// (get) Token: 0x0600CE43 RID: 52803 RVA: 0x00321154 File Offset: 0x0031F354
			// (set) Token: 0x0600CE44 RID: 52804 RVA: 0x00064013 File Offset: 0x00062213
			public unsafe int __1__state
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PursuitBehaviour._SearchRoutine_d__82.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PursuitBehaviour._SearchRoutine_d__82.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17004006 RID: 16390
			// (get) Token: 0x0600CE45 RID: 52805 RVA: 0x0032117C File Offset: 0x0031F37C
			// (set) Token: 0x0600CE46 RID: 52806 RVA: 0x0006402E File Offset: 0x0006222E
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PursuitBehaviour._SearchRoutine_d__82.NativeFieldInfoPtr___2__current);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PursuitBehaviour._SearchRoutine_d__82.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004007 RID: 16391
			// (get) Token: 0x0600CE47 RID: 52807 RVA: 0x003211AC File Offset: 0x0031F3AC
			// (set) Token: 0x0600CE48 RID: 52808 RVA: 0x0006404D File Offset: 0x0006224D
			public unsafe PursuitBehaviour __4__this
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PursuitBehaviour._SearchRoutine_d__82.NativeFieldInfoPtr___4__this);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PursuitBehaviour>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PursuitBehaviour._SearchRoutine_d__82.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008BA1 RID: 35745
			private static readonly System.IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04008BA2 RID: 35746
			private static readonly System.IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04008BA3 RID: 35747
			private static readonly System.IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04008BA4 RID: 35748
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04008BA5 RID: 35749
			private static readonly System.IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008BA6 RID: 35750
			private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04008BA7 RID: 35751
			private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04008BA8 RID: 35752
			private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008BA9 RID: 35753
			private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
