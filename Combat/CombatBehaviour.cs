using System;
using Il2CppFishNet.Connection;
using Il2CppFishNet.Object;
using Il2CppFishNet.Serializing;
using Il2CppFishNet.Transporting;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.AvatarFramework.Equipping;
using Il2CppScheduleOne.NPCs.Behaviour;
using Il2CppScheduleOne.PlayerScripts;
using Il2CppScheduleOne.Vision;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine;

namespace Il2CppScheduleOne.Combat
{
	// Token: 0x020004BA RID: 1210
	public class CombatBehaviour : Il2CppScheduleOne.NPCs.Behaviour.Behaviour
	{
		// Token: 0x060067A7 RID: 26535 RVA: 0x001D4F0C File Offset: 0x001D310C
		// Note: this type is marked as 'beforefieldinit'.
		static CombatBehaviour()
		{
			Il2CppClassPointerStore<CombatBehaviour>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Combat", "CombatBehaviour");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CombatBehaviour>.NativeClassPtr);
			CombatBehaviour.NativeFieldInfoPtr_EXTRA_VISIBILITY_TIME = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombatBehaviour>.NativeClassPtr, "EXTRA_VISIBILITY_TIME");
			CombatBehaviour.NativeFieldInfoPtr_SEARCH_RADIUS_MIN = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombatBehaviour>.NativeClassPtr, "SEARCH_RADIUS_MIN");
			CombatBehaviour.NativeFieldInfoPtr_SEARCH_RADIUS_MAX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombatBehaviour>.NativeClassPtr, "SEARCH_RADIUS_MAX");
			CombatBehaviour.NativeFieldInfoPtr_SEARCH_SPEED = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombatBehaviour>.NativeClassPtr, "SEARCH_SPEED");
			CombatBehaviour.NativeFieldInfoPtr_CONSECUTIVE_MISS_ACCURACY_BOOST = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombatBehaviour>.NativeClassPtr, "CONSECUTIVE_MISS_ACCURACY_BOOST");
			CombatBehaviour.NativeFieldInfoPtr_REACHED_DESTINATION_DISTANCE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombatBehaviour>.NativeClassPtr, "REACHED_DESTINATION_DISTANCE");
			CombatBehaviour.NativeFieldInfoPtr__TargetPlayer_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombatBehaviour>.NativeClassPtr, "<TargetPlayer>k__BackingField");
			CombatBehaviour.NativeFieldInfoPtr__IsSearching_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombatBehaviour>.NativeClassPtr, "<IsSearching>k__BackingField");
			CombatBehaviour.NativeFieldInfoPtr__TimeSinceTargetReacquired_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombatBehaviour>.NativeClassPtr, "<TimeSinceTargetReacquired>k__BackingField");
			CombatBehaviour.NativeFieldInfoPtr_GiveUpRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombatBehaviour>.NativeClassPtr, "GiveUpRange");
			CombatBehaviour.NativeFieldInfoPtr_GiveUpTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombatBehaviour>.NativeClassPtr, "GiveUpTime");
			CombatBehaviour.NativeFieldInfoPtr_GiveUpAfterSuccessfulHits = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombatBehaviour>.NativeClassPtr, "GiveUpAfterSuccessfulHits");
			CombatBehaviour.NativeFieldInfoPtr_PlayAngryVO = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombatBehaviour>.NativeClassPtr, "PlayAngryVO");
			CombatBehaviour.NativeFieldInfoPtr_DefaultMovementSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombatBehaviour>.NativeClassPtr, "DefaultMovementSpeed");
			CombatBehaviour.NativeFieldInfoPtr_DefaultWeapon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombatBehaviour>.NativeClassPtr, "DefaultWeapon");
			CombatBehaviour.NativeFieldInfoPtr_VirtualPunchWeapon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombatBehaviour>.NativeClassPtr, "VirtualPunchWeapon");
			CombatBehaviour.NativeFieldInfoPtr_DefaultSearchTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombatBehaviour>.NativeClassPtr, "DefaultSearchTime");
			CombatBehaviour.NativeFieldInfoPtr_overrideTargetDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombatBehaviour>.NativeClassPtr, "overrideTargetDistance");
			CombatBehaviour.NativeFieldInfoPtr_targetDistanceOverride = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombatBehaviour>.NativeClassPtr, "targetDistanceOverride");
			CombatBehaviour.NativeFieldInfoPtr_isTargetRecentlyVisible = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombatBehaviour>.NativeClassPtr, "isTargetRecentlyVisible");
			CombatBehaviour.NativeFieldInfoPtr_isTargetImmediatelyVisible = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombatBehaviour>.NativeClassPtr, "isTargetImmediatelyVisible");
			CombatBehaviour.NativeFieldInfoPtr_timeSinceLastSighting = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombatBehaviour>.NativeClassPtr, "timeSinceLastSighting");
			CombatBehaviour.NativeFieldInfoPtr_playerSightedDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombatBehaviour>.NativeClassPtr, "playerSightedDuration");
			CombatBehaviour.NativeFieldInfoPtr_lastKnownTargetPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombatBehaviour>.NativeClassPtr, "lastKnownTargetPosition");
			CombatBehaviour.NativeFieldInfoPtr_currentWeapon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombatBehaviour>.NativeClassPtr, "currentWeapon");
			CombatBehaviour.NativeFieldInfoPtr_successfulHits = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombatBehaviour>.NativeClassPtr, "successfulHits");
			CombatBehaviour.NativeFieldInfoPtr_consecutiveMissedShots = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombatBehaviour>.NativeClassPtr, "consecutiveMissedShots");
			CombatBehaviour.NativeFieldInfoPtr_rangedWeaponRoutine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombatBehaviour>.NativeClassPtr, "rangedWeaponRoutine");
			CombatBehaviour.NativeFieldInfoPtr_searchRoutine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombatBehaviour>.NativeClassPtr, "searchRoutine");
			CombatBehaviour.NativeFieldInfoPtr_currentSearchDestination = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombatBehaviour>.NativeClassPtr, "currentSearchDestination");
			CombatBehaviour.NativeFieldInfoPtr_hasSearchDestination = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombatBehaviour>.NativeClassPtr, "hasSearchDestination");
			CombatBehaviour.NativeFieldInfoPtr_nextAngryVO = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombatBehaviour>.NativeClassPtr, "nextAngryVO");
			CombatBehaviour.NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombatBehaviour>.NativeClassPtr, "NetworkInitialize___EarlyScheduleOne.Combat.CombatBehaviourAssembly-CSharp.dll_Excuted");
			CombatBehaviour.NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombatBehaviour>.NativeClassPtr, "NetworkInitialize__LateScheduleOne.Combat.CombatBehaviourAssembly-CSharp.dll_Excuted");
			CombatBehaviour.NativeMethodInfoPtr_get_TargetPlayer_Public_get_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatBehaviour>.NativeClassPtr, 100676493);
			CombatBehaviour.NativeMethodInfoPtr_set_TargetPlayer_Protected_set_Void_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatBehaviour>.NativeClassPtr, 100676494);
			CombatBehaviour.NativeMethodInfoPtr_get_IsSearching_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatBehaviour>.NativeClassPtr, 100676495);
			CombatBehaviour.NativeMethodInfoPtr_set_IsSearching_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatBehaviour>.NativeClassPtr, 100676496);
			CombatBehaviour.NativeMethodInfoPtr_get_TimeSinceTargetReacquired_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatBehaviour>.NativeClassPtr, 100676497);
			CombatBehaviour.NativeMethodInfoPtr_set_TimeSinceTargetReacquired_Protected_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatBehaviour>.NativeClassPtr, 100676498);
			CombatBehaviour.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatBehaviour>.NativeClassPtr, 100676499);
			CombatBehaviour.NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatBehaviour>.NativeClassPtr, 100676500);
			CombatBehaviour.NativeMethodInfoPtr_SetTarget_Public_Virtual_New_Void_NetworkConnection_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatBehaviour>.NativeClassPtr, 100676501);
			CombatBehaviour.NativeMethodInfoPtr_Begin_Protected_Virtual_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatBehaviour>.NativeClassPtr, 100676502);
			CombatBehaviour.NativeMethodInfoPtr_Resume_Protected_Virtual_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatBehaviour>.NativeClassPtr, 100676503);
			CombatBehaviour.NativeMethodInfoPtr_Pause_Protected_Virtual_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatBehaviour>.NativeClassPtr, 100676504);
			CombatBehaviour.NativeMethodInfoPtr_End_Protected_Virtual_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatBehaviour>.NativeClassPtr, 100676505);
			CombatBehaviour.NativeMethodInfoPtr_Disable_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatBehaviour>.NativeClassPtr, 100676506);
			CombatBehaviour.NativeMethodInfoPtr_StartCombat_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatBehaviour>.NativeClassPtr, 100676507);
			CombatBehaviour.NativeMethodInfoPtr_EndCombat_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatBehaviour>.NativeClassPtr, 100676508);
			CombatBehaviour.NativeMethodInfoPtr_BehaviourUpdate_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatBehaviour>.NativeClassPtr, 100676509);
			CombatBehaviour.NativeMethodInfoPtr_FixedUpdate_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatBehaviour>.NativeClassPtr, 100676510);
			CombatBehaviour.NativeMethodInfoPtr_UpdateTimeout_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatBehaviour>.NativeClassPtr, 100676511);
			CombatBehaviour.NativeMethodInfoPtr_UpdateLookAt_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatBehaviour>.NativeClassPtr, 100676512);
			CombatBehaviour.NativeMethodInfoPtr_SetMovementSpeed_Protected_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatBehaviour>.NativeClassPtr, 100676513);
			CombatBehaviour.NativeMethodInfoPtr_SetWeapon_Protected_Virtual_New_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatBehaviour>.NativeClassPtr, 100676514);
			CombatBehaviour.NativeMethodInfoPtr_ClearWeapon_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatBehaviour>.NativeClassPtr, 100676515);
			CombatBehaviour.NativeMethodInfoPtr_ReadyToAttack_Protected_Virtual_New_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatBehaviour>.NativeClassPtr, 100676516);
			CombatBehaviour.NativeMethodInfoPtr_Attack_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatBehaviour>.NativeClassPtr, 100676517);
			CombatBehaviour.NativeMethodInfoPtr_SucessfulHit_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatBehaviour>.NativeClassPtr, 100676518);
			CombatBehaviour.NativeMethodInfoPtr_CheckPlayerVisibility_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatBehaviour>.NativeClassPtr, 100676519);
			CombatBehaviour.NativeMethodInfoPtr_MarkPlayerVisible_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatBehaviour>.NativeClassPtr, 100676520);
			CombatBehaviour.NativeMethodInfoPtr_IsPlayerVisible_Protected_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatBehaviour>.NativeClassPtr, 100676521);
			CombatBehaviour.NativeMethodInfoPtr_ProcessVisionEvent_Private_Void_VisionEventReceipt_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatBehaviour>.NativeClassPtr, 100676522);
			CombatBehaviour.NativeMethodInfoPtr_GetSearchTime_Protected_Virtual_New_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatBehaviour>.NativeClassPtr, 100676523);
			CombatBehaviour.NativeMethodInfoPtr_StartSearching_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatBehaviour>.NativeClassPtr, 100676524);
			CombatBehaviour.NativeMethodInfoPtr_StopSearching_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatBehaviour>.NativeClassPtr, 100676525);
			CombatBehaviour.NativeMethodInfoPtr_SearchRoutine_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatBehaviour>.NativeClassPtr, 100676526);
			CombatBehaviour.NativeMethodInfoPtr_GetNextSearchLocation_Private_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatBehaviour>.NativeClassPtr, 100676527);
			CombatBehaviour.NativeMethodInfoPtr_IsTargetValid_Protected_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatBehaviour>.NativeClassPtr, 100676528);
			CombatBehaviour.NativeMethodInfoPtr_RepositionToTargetRange_Private_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatBehaviour>.NativeClassPtr, 100676529);
			CombatBehaviour.NativeMethodInfoPtr_GetRandomReachablePointNear_Private_Vector3_Vector3_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatBehaviour>.NativeClassPtr, 100676530);
			CombatBehaviour.NativeMethodInfoPtr_GetMinTargetDistance_Protected_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatBehaviour>.NativeClassPtr, 100676531);
			CombatBehaviour.NativeMethodInfoPtr_GetMaxTargetDistance_Protected_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatBehaviour>.NativeClassPtr, 100676532);
			CombatBehaviour.NativeMethodInfoPtr_IsTargetInRange_Protected_Boolean_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatBehaviour>.NativeClassPtr, 100676533);
			CombatBehaviour.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatBehaviour>.NativeClassPtr, 100676534);
			CombatBehaviour.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatBehaviour>.NativeClassPtr, 100676535);
			CombatBehaviour.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatBehaviour>.NativeClassPtr, 100676536);
			CombatBehaviour.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatBehaviour>.NativeClassPtr, 100676537);
			CombatBehaviour.NativeMethodInfoPtr_RpcWriter___Observers_SetTarget_1824087381_Private_Void_NetworkConnection_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatBehaviour>.NativeClassPtr, 100676538);
			CombatBehaviour.NativeMethodInfoPtr_RpcLogic___SetTarget_1824087381_Public_Virtual_New_Void_NetworkConnection_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatBehaviour>.NativeClassPtr, 100676539);
			CombatBehaviour.NativeMethodInfoPtr_RpcReader___Observers_SetTarget_1824087381_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatBehaviour>.NativeClassPtr, 100676540);
			CombatBehaviour.NativeMethodInfoPtr_RpcWriter___Observers_SetWeapon_3615296227_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatBehaviour>.NativeClassPtr, 100676541);
			CombatBehaviour.NativeMethodInfoPtr_RpcLogic___SetWeapon_3615296227_Protected_Virtual_New_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatBehaviour>.NativeClassPtr, 100676542);
			CombatBehaviour.NativeMethodInfoPtr_RpcReader___Observers_SetWeapon_3615296227_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatBehaviour>.NativeClassPtr, 100676543);
			CombatBehaviour.NativeMethodInfoPtr_RpcWriter___Observers_ClearWeapon_2166136261_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatBehaviour>.NativeClassPtr, 100676544);
			CombatBehaviour.NativeMethodInfoPtr_RpcLogic___ClearWeapon_2166136261_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatBehaviour>.NativeClassPtr, 100676545);
			CombatBehaviour.NativeMethodInfoPtr_RpcReader___Observers_ClearWeapon_2166136261_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatBehaviour>.NativeClassPtr, 100676546);
			CombatBehaviour.NativeMethodInfoPtr_RpcWriter___Observers_Attack_2166136261_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatBehaviour>.NativeClassPtr, 100676547);
			CombatBehaviour.NativeMethodInfoPtr_RpcLogic___Attack_2166136261_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatBehaviour>.NativeClassPtr, 100676548);
			CombatBehaviour.NativeMethodInfoPtr_RpcReader___Observers_Attack_2166136261_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatBehaviour>.NativeClassPtr, 100676549);
			CombatBehaviour.NativeMethodInfoPtr_Method_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatBehaviour>.NativeClassPtr, 100676550);
		}

		// Token: 0x17001F27 RID: 7975
		// (get) Token: 0x060067A8 RID: 26536 RVA: 0x001D566C File Offset: 0x001D386C
		// (set) Token: 0x060067A9 RID: 26537 RVA: 0x001D56AC File Offset: 0x001D38AC
		public unsafe Player TargetPlayer
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CombatBehaviour.NativeMethodInfoPtr_get_TargetPlayer_Public_get_Player_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
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
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CombatBehaviour.NativeMethodInfoPtr_set_TargetPlayer_Protected_set_Void_Player_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x17001F28 RID: 7976
		// (get) Token: 0x060067AA RID: 26538 RVA: 0x001D56F0 File Offset: 0x001D38F0
		// (set) Token: 0x060067AB RID: 26539 RVA: 0x001D572C File Offset: 0x001D392C
		public unsafe bool IsSearching
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(CombatBehaviour.NativeMethodInfoPtr_get_IsSearching_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
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
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CombatBehaviour.NativeMethodInfoPtr_set_IsSearching_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x17001F29 RID: 7977
		// (get) Token: 0x060067AC RID: 26540 RVA: 0x001D576C File Offset: 0x001D396C
		// (set) Token: 0x060067AD RID: 26541 RVA: 0x001D57A8 File Offset: 0x001D39A8
		public unsafe float TimeSinceTargetReacquired
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(CombatBehaviour.NativeMethodInfoPtr_get_TimeSinceTargetReacquired_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
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
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CombatBehaviour.NativeMethodInfoPtr_set_TimeSinceTargetReacquired_Protected_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x060067AE RID: 26542 RVA: 0x001D57E8 File Offset: 0x001D39E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 210600, XrefRangeEnd = 210617, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CombatBehaviour.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060067AF RID: 26543 RVA: 0x001D5824 File Offset: 0x001D3A24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 210617, XrefRangeEnd = 210622, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnSpawnServer(NetworkConnection connection)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(connection);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CombatBehaviour.NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060067B0 RID: 26544 RVA: 0x001D5874 File Offset: 0x001D3A74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 210622, XrefRangeEnd = 210627, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetTarget(NetworkConnection conn, NetworkObject target)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(target);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CombatBehaviour.NativeMethodInfoPtr_SetTarget_Public_Virtual_New_Void_NetworkConnection_NetworkObject_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060067B1 RID: 26545 RVA: 0x001D58D4 File Offset: 0x001D3AD4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 210627, XrefRangeEnd = 210634, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Begin()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CombatBehaviour.NativeMethodInfoPtr_Begin_Protected_Virtual_Void_1), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060067B2 RID: 26546 RVA: 0x001D5910 File Offset: 0x001D3B10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 210634, XrefRangeEnd = 210635, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Resume()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CombatBehaviour.NativeMethodInfoPtr_Resume_Protected_Virtual_Void_1), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060067B3 RID: 26547 RVA: 0x001D594C File Offset: 0x001D3B4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 210635, XrefRangeEnd = 210637, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Pause()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CombatBehaviour.NativeMethodInfoPtr_Pause_Protected_Virtual_Void_1), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060067B4 RID: 26548 RVA: 0x001D5988 File Offset: 0x001D3B88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 210637, XrefRangeEnd = 210639, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void End()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CombatBehaviour.NativeMethodInfoPtr_End_Protected_Virtual_Void_1), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060067B5 RID: 26549 RVA: 0x001D59C4 File Offset: 0x001D3BC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Disable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CombatBehaviour.NativeMethodInfoPtr_Disable_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060067B6 RID: 26550 RVA: 0x001D5A00 File Offset: 0x001D3C00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 210639, XrefRangeEnd = 210664, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void StartCombat()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CombatBehaviour.NativeMethodInfoPtr_StartCombat_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060067B7 RID: 26551 RVA: 0x001D5A3C File Offset: 0x001D3C3C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 210692, RefRangeEnd = 210694, XrefRangeStart = 210664, XrefRangeEnd = 210692, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EndCombat()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CombatBehaviour.NativeMethodInfoPtr_EndCombat_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060067B8 RID: 26552 RVA: 0x001D5A70 File Offset: 0x001D3C70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 210694, XrefRangeEnd = 210759, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void BehaviourUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CombatBehaviour.NativeMethodInfoPtr_BehaviourUpdate_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060067B9 RID: 26553 RVA: 0x001D5AAC File Offset: 0x001D3CAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 210759, XrefRangeEnd = 210762, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void FixedUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CombatBehaviour.NativeMethodInfoPtr_FixedUpdate_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060067BA RID: 26554 RVA: 0x001D5AE8 File Offset: 0x001D3CE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 210762, XrefRangeEnd = 210764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateTimeout()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CombatBehaviour.NativeMethodInfoPtr_UpdateTimeout_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060067BB RID: 26555 RVA: 0x001D5B1C File Offset: 0x001D3D1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 210764, XrefRangeEnd = 210771, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void UpdateLookAt()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CombatBehaviour.NativeMethodInfoPtr_UpdateLookAt_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060067BC RID: 26556 RVA: 0x001D5B58 File Offset: 0x001D3D58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 210771, XrefRangeEnd = 210780, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetMovementSpeed(float speed)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref speed;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CombatBehaviour.NativeMethodInfoPtr_SetMovementSpeed_Protected_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060067BD RID: 26557 RVA: 0x001D5B98 File Offset: 0x001D3D98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 210780, XrefRangeEnd = 210802, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetWeapon(string weaponPath)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(weaponPath);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CombatBehaviour.NativeMethodInfoPtr_SetWeapon_Protected_Virtual_New_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060067BE RID: 26558 RVA: 0x001D5BE8 File Offset: 0x001D3DE8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 210823, RefRangeEnd = 210825, XrefRangeStart = 210802, XrefRangeEnd = 210823, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ClearWeapon()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CombatBehaviour.NativeMethodInfoPtr_ClearWeapon_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060067BF RID: 26559 RVA: 0x001D5C1C File Offset: 0x001D3E1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 210825, XrefRangeEnd = 210830, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool ReadyToAttack(bool checkTarget = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref checkTarget;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CombatBehaviour.NativeMethodInfoPtr_ReadyToAttack_Protected_Virtual_New_Boolean_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x060067C0 RID: 26560 RVA: 0x001D5C70 File Offset: 0x001D3E70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 210830, XrefRangeEnd = 210851, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Attack()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CombatBehaviour.NativeMethodInfoPtr_Attack_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060067C1 RID: 26561 RVA: 0x001D5CAC File Offset: 0x001D3EAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 210851, XrefRangeEnd = 210852, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SucessfulHit()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CombatBehaviour.NativeMethodInfoPtr_SucessfulHit_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060067C2 RID: 26562 RVA: 0x001D5CE0 File Offset: 0x001D3EE0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 210873, RefRangeEnd = 210875, XrefRangeStart = 210852, XrefRangeEnd = 210873, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CheckPlayerVisibility()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CombatBehaviour.NativeMethodInfoPtr_CheckPlayerVisibility_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060067C3 RID: 26563 RVA: 0x001D5D14 File Offset: 0x001D3F14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 210875, XrefRangeEnd = 210879, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MarkPlayerVisible()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CombatBehaviour.NativeMethodInfoPtr_MarkPlayerVisible_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060067C4 RID: 26564 RVA: 0x001D5D48 File Offset: 0x001D3F48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsPlayerVisible()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(CombatBehaviour.NativeMethodInfoPtr_IsPlayerVisible_Protected_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x060067C5 RID: 26565 RVA: 0x001D5D84 File Offset: 0x001D3F84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 210879, XrefRangeEnd = 210887, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ProcessVisionEvent(VisionEventReceipt visionEventReceipt)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(visionEventReceipt);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CombatBehaviour.NativeMethodInfoPtr_ProcessVisionEvent_Private_Void_VisionEventReceipt_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060067C6 RID: 26566 RVA: 0x001D5DC8 File Offset: 0x001D3FC8
		[CallerCount(0)]
		public unsafe virtual float GetSearchTime()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CombatBehaviour.NativeMethodInfoPtr_GetSearchTime_Protected_Virtual_New_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x060067C7 RID: 26567 RVA: 0x001D5E10 File Offset: 0x001D4010
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 210887, XrefRangeEnd = 210909, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StartSearching()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CombatBehaviour.NativeMethodInfoPtr_StartSearching_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060067C8 RID: 26568 RVA: 0x001D5E44 File Offset: 0x001D4044
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 210921, RefRangeEnd = 210923, XrefRangeStart = 210909, XrefRangeEnd = 210921, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StopSearching()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CombatBehaviour.NativeMethodInfoPtr_StopSearching_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060067C9 RID: 26569 RVA: 0x001D5E78 File Offset: 0x001D4078
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 210923, XrefRangeEnd = 210928, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator SearchRoutine()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CombatBehaviour.NativeMethodInfoPtr_SearchRoutine_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr2) : null;
		}

		// Token: 0x060067CA RID: 26570 RVA: 0x001D5EB8 File Offset: 0x001D40B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 210928, XrefRangeEnd = 210941, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector3 GetNextSearchLocation()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(CombatBehaviour.NativeMethodInfoPtr_GetNextSearchLocation_Private_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x060067CB RID: 26571 RVA: 0x001D5EF4 File Offset: 0x001D40F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 210941, XrefRangeEnd = 210949, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsTargetValid()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(CombatBehaviour.NativeMethodInfoPtr_IsTargetValid_Protected_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x060067CC RID: 26572 RVA: 0x001D5F30 File Offset: 0x001D4130
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 210949, XrefRangeEnd = 210958, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RepositionToTargetRange(Vector3 origin)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref origin;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CombatBehaviour.NativeMethodInfoPtr_RepositionToTargetRange_Private_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060067CD RID: 26573 RVA: 0x001D5F70 File Offset: 0x001D4170
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 210977, RefRangeEnd = 210979, XrefRangeStart = 210958, XrefRangeEnd = 210977, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector3 GetRandomReachablePointNear(Vector3 point, float randomRadius, float minDistance = 0f)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref point;
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref randomRadius;
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref minDistance;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(CombatBehaviour.NativeMethodInfoPtr_GetRandomReachablePointNear_Private_Vector3_Vector3_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x060067CE RID: 26574 RVA: 0x001D5FD8 File Offset: 0x001D41D8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 210983, RefRangeEnd = 210985, XrefRangeStart = 210979, XrefRangeEnd = 210983, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float GetMinTargetDistance()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(CombatBehaviour.NativeMethodInfoPtr_GetMinTargetDistance_Protected_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x060067CF RID: 26575 RVA: 0x001D6014 File Offset: 0x001D4214
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 210989, RefRangeEnd = 210990, XrefRangeStart = 210985, XrefRangeEnd = 210989, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float GetMaxTargetDistance()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(CombatBehaviour.NativeMethodInfoPtr_GetMaxTargetDistance_Protected_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x060067D0 RID: 26576 RVA: 0x001D6050 File Offset: 0x001D4250
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 210990, XrefRangeEnd = 210999, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsTargetInRange(Vector3 origin = default(Vector3))
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref origin;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(CombatBehaviour.NativeMethodInfoPtr_IsTargetInRange_Protected_Boolean_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x060067D1 RID: 26577 RVA: 0x001D609C File Offset: 0x001D429C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 210999, XrefRangeEnd = 211004, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CombatBehaviour() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CombatBehaviour>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CombatBehaviour.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060067D2 RID: 26578 RVA: 0x001D60D8 File Offset: 0x001D42D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 211004, XrefRangeEnd = 211030, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize___Early()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CombatBehaviour.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060067D3 RID: 26579 RVA: 0x001D6114 File Offset: 0x001D4314
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 211030, XrefRangeEnd = 211031, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize__Late()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CombatBehaviour.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060067D4 RID: 26580 RVA: 0x001D6150 File Offset: 0x001D4350
		[CallerCount(0)]
		public unsafe override void NetworkInitializeIfDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CombatBehaviour.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060067D5 RID: 26581 RVA: 0x001D618C File Offset: 0x001D438C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 211050, RefRangeEnd = 211051, XrefRangeStart = 211031, XrefRangeEnd = 211050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_SetTarget_1824087381(NetworkConnection conn, NetworkObject target)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(target);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CombatBehaviour.NativeMethodInfoPtr_RpcWriter___Observers_SetTarget_1824087381_Private_Void_NetworkConnection_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060067D6 RID: 26582 RVA: 0x001D61E0 File Offset: 0x001D43E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 211051, XrefRangeEnd = 211055, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void RpcLogic___SetTarget_1824087381(NetworkConnection conn, NetworkObject target)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(target);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CombatBehaviour.NativeMethodInfoPtr_RpcLogic___SetTarget_1824087381_Public_Virtual_New_Void_NetworkConnection_NetworkObject_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060067D7 RID: 26583 RVA: 0x001D6240 File Offset: 0x001D4440
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 211055, XrefRangeEnd = 211063, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_SetTarget_1824087381(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref channel;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CombatBehaviour.NativeMethodInfoPtr_RpcReader___Observers_SetTarget_1824087381_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060067D8 RID: 26584 RVA: 0x001D6290 File Offset: 0x001D4490
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 211063, XrefRangeEnd = 211073, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_SetWeapon_3615296227(string weaponPath)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(weaponPath);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CombatBehaviour.NativeMethodInfoPtr_RpcWriter___Observers_SetWeapon_3615296227_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060067D9 RID: 26585 RVA: 0x001D62D4 File Offset: 0x001D44D4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 211110, RefRangeEnd = 211112, XrefRangeStart = 211073, XrefRangeEnd = 211110, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void RpcLogic___SetWeapon_3615296227(string weaponPath)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(weaponPath);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CombatBehaviour.NativeMethodInfoPtr_RpcLogic___SetWeapon_3615296227_Protected_Virtual_New_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060067DA RID: 26586 RVA: 0x001D6324 File Offset: 0x001D4524
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 211112, XrefRangeEnd = 211116, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_SetWeapon_3615296227(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref channel;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CombatBehaviour.NativeMethodInfoPtr_RpcReader___Observers_SetWeapon_3615296227_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060067DB RID: 26587 RVA: 0x001D6374 File Offset: 0x001D4574
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 211116, XrefRangeEnd = 211125, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_ClearWeapon_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CombatBehaviour.NativeMethodInfoPtr_RpcWriter___Observers_ClearWeapon_2166136261_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060067DC RID: 26588 RVA: 0x001D63A8 File Offset: 0x001D45A8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 211146, RefRangeEnd = 211148, XrefRangeStart = 211125, XrefRangeEnd = 211146, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___ClearWeapon_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CombatBehaviour.NativeMethodInfoPtr_RpcLogic___ClearWeapon_2166136261_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060067DD RID: 26589 RVA: 0x001D63DC File Offset: 0x001D45DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 211148, XrefRangeEnd = 211151, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_ClearWeapon_2166136261(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref channel;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CombatBehaviour.NativeMethodInfoPtr_RpcReader___Observers_ClearWeapon_2166136261_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060067DE RID: 26590 RVA: 0x001D642C File Offset: 0x001D462C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 211151, XrefRangeEnd = 211160, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_Attack_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CombatBehaviour.NativeMethodInfoPtr_RpcWriter___Observers_Attack_2166136261_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060067DF RID: 26591 RVA: 0x001D6460 File Offset: 0x001D4660
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 211164, RefRangeEnd = 211166, XrefRangeStart = 211160, XrefRangeEnd = 211164, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void RpcLogic___Attack_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CombatBehaviour.NativeMethodInfoPtr_RpcLogic___Attack_2166136261_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060067E0 RID: 26592 RVA: 0x001D649C File Offset: 0x001D469C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 211166, XrefRangeEnd = 211169, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_Attack_2166136261(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref channel;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CombatBehaviour.NativeMethodInfoPtr_RpcReader___Observers_Attack_2166136261_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060067E1 RID: 26593 RVA: 0x001D64EC File Offset: 0x001D46EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 211169, XrefRangeEnd = 211186, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Method_Protected_Virtual_Void_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CombatBehaviour.NativeMethodInfoPtr_Method_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060067E2 RID: 26594 RVA: 0x00030D0A File Offset: 0x0002EF0A
		public CombatBehaviour(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001F05 RID: 7941
		// (get) Token: 0x060067E3 RID: 26595 RVA: 0x001D6528 File Offset: 0x001D4728
		// (set) Token: 0x060067E4 RID: 26596 RVA: 0x00030D13 File Offset: 0x0002EF13
		public unsafe static float EXTRA_VISIBILITY_TIME
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(CombatBehaviour.NativeFieldInfoPtr_EXTRA_VISIBILITY_TIME, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CombatBehaviour.NativeFieldInfoPtr_EXTRA_VISIBILITY_TIME, (void*)(&value));
			}
		}

		// Token: 0x17001F06 RID: 7942
		// (get) Token: 0x060067E5 RID: 26597 RVA: 0x001D6544 File Offset: 0x001D4744
		// (set) Token: 0x060067E6 RID: 26598 RVA: 0x00030D21 File Offset: 0x0002EF21
		public unsafe static float SEARCH_RADIUS_MIN
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(CombatBehaviour.NativeFieldInfoPtr_SEARCH_RADIUS_MIN, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CombatBehaviour.NativeFieldInfoPtr_SEARCH_RADIUS_MIN, (void*)(&value));
			}
		}

		// Token: 0x17001F07 RID: 7943
		// (get) Token: 0x060067E7 RID: 26599 RVA: 0x001D6560 File Offset: 0x001D4760
		// (set) Token: 0x060067E8 RID: 26600 RVA: 0x00030D2F File Offset: 0x0002EF2F
		public unsafe static float SEARCH_RADIUS_MAX
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(CombatBehaviour.NativeFieldInfoPtr_SEARCH_RADIUS_MAX, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CombatBehaviour.NativeFieldInfoPtr_SEARCH_RADIUS_MAX, (void*)(&value));
			}
		}

		// Token: 0x17001F08 RID: 7944
		// (get) Token: 0x060067E9 RID: 26601 RVA: 0x001D657C File Offset: 0x001D477C
		// (set) Token: 0x060067EA RID: 26602 RVA: 0x00030D3D File Offset: 0x0002EF3D
		public unsafe static float SEARCH_SPEED
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(CombatBehaviour.NativeFieldInfoPtr_SEARCH_SPEED, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CombatBehaviour.NativeFieldInfoPtr_SEARCH_SPEED, (void*)(&value));
			}
		}

		// Token: 0x17001F09 RID: 7945
		// (get) Token: 0x060067EB RID: 26603 RVA: 0x001D6598 File Offset: 0x001D4798
		// (set) Token: 0x060067EC RID: 26604 RVA: 0x00030D4B File Offset: 0x0002EF4B
		public unsafe static float CONSECUTIVE_MISS_ACCURACY_BOOST
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(CombatBehaviour.NativeFieldInfoPtr_CONSECUTIVE_MISS_ACCURACY_BOOST, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CombatBehaviour.NativeFieldInfoPtr_CONSECUTIVE_MISS_ACCURACY_BOOST, (void*)(&value));
			}
		}

		// Token: 0x17001F0A RID: 7946
		// (get) Token: 0x060067ED RID: 26605 RVA: 0x001D65B4 File Offset: 0x001D47B4
		// (set) Token: 0x060067EE RID: 26606 RVA: 0x00030D59 File Offset: 0x0002EF59
		public unsafe static float REACHED_DESTINATION_DISTANCE
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(CombatBehaviour.NativeFieldInfoPtr_REACHED_DESTINATION_DISTANCE, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CombatBehaviour.NativeFieldInfoPtr_REACHED_DESTINATION_DISTANCE, (void*)(&value));
			}
		}

		// Token: 0x17001F0B RID: 7947
		// (get) Token: 0x060067EF RID: 26607 RVA: 0x001D65D0 File Offset: 0x001D47D0
		// (set) Token: 0x060067F0 RID: 26608 RVA: 0x00030D67 File Offset: 0x0002EF67
		public unsafe Player _TargetPlayer_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CombatBehaviour.NativeFieldInfoPtr__TargetPlayer_k__BackingField);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Player>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CombatBehaviour.NativeFieldInfoPtr__TargetPlayer_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001F0C RID: 7948
		// (get) Token: 0x060067F1 RID: 26609 RVA: 0x001D6600 File Offset: 0x001D4800
		// (set) Token: 0x060067F2 RID: 26610 RVA: 0x00030D86 File Offset: 0x0002EF86
		public unsafe bool _IsSearching_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CombatBehaviour.NativeFieldInfoPtr__IsSearching_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CombatBehaviour.NativeFieldInfoPtr__IsSearching_k__BackingField)) = value;
			}
		}

		// Token: 0x17001F0D RID: 7949
		// (get) Token: 0x060067F3 RID: 26611 RVA: 0x001D6628 File Offset: 0x001D4828
		// (set) Token: 0x060067F4 RID: 26612 RVA: 0x00030DA1 File Offset: 0x0002EFA1
		public unsafe float _TimeSinceTargetReacquired_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CombatBehaviour.NativeFieldInfoPtr__TimeSinceTargetReacquired_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CombatBehaviour.NativeFieldInfoPtr__TimeSinceTargetReacquired_k__BackingField)) = value;
			}
		}

		// Token: 0x17001F0E RID: 7950
		// (get) Token: 0x060067F5 RID: 26613 RVA: 0x001D6650 File Offset: 0x001D4850
		// (set) Token: 0x060067F6 RID: 26614 RVA: 0x00030DBC File Offset: 0x0002EFBC
		public unsafe float GiveUpRange
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CombatBehaviour.NativeFieldInfoPtr_GiveUpRange);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CombatBehaviour.NativeFieldInfoPtr_GiveUpRange)) = value;
			}
		}

		// Token: 0x17001F0F RID: 7951
		// (get) Token: 0x060067F7 RID: 26615 RVA: 0x001D6678 File Offset: 0x001D4878
		// (set) Token: 0x060067F8 RID: 26616 RVA: 0x00030DD7 File Offset: 0x0002EFD7
		public unsafe float GiveUpTime
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CombatBehaviour.NativeFieldInfoPtr_GiveUpTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CombatBehaviour.NativeFieldInfoPtr_GiveUpTime)) = value;
			}
		}

		// Token: 0x17001F10 RID: 7952
		// (get) Token: 0x060067F9 RID: 26617 RVA: 0x001D66A0 File Offset: 0x001D48A0
		// (set) Token: 0x060067FA RID: 26618 RVA: 0x00030DF2 File Offset: 0x0002EFF2
		public unsafe int GiveUpAfterSuccessfulHits
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CombatBehaviour.NativeFieldInfoPtr_GiveUpAfterSuccessfulHits);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CombatBehaviour.NativeFieldInfoPtr_GiveUpAfterSuccessfulHits)) = value;
			}
		}

		// Token: 0x17001F11 RID: 7953
		// (get) Token: 0x060067FB RID: 26619 RVA: 0x001D66C8 File Offset: 0x001D48C8
		// (set) Token: 0x060067FC RID: 26620 RVA: 0x00030E0D File Offset: 0x0002F00D
		public unsafe bool PlayAngryVO
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CombatBehaviour.NativeFieldInfoPtr_PlayAngryVO);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CombatBehaviour.NativeFieldInfoPtr_PlayAngryVO)) = value;
			}
		}

		// Token: 0x17001F12 RID: 7954
		// (get) Token: 0x060067FD RID: 26621 RVA: 0x001D66F0 File Offset: 0x001D48F0
		// (set) Token: 0x060067FE RID: 26622 RVA: 0x00030E28 File Offset: 0x0002F028
		public unsafe float DefaultMovementSpeed
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CombatBehaviour.NativeFieldInfoPtr_DefaultMovementSpeed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CombatBehaviour.NativeFieldInfoPtr_DefaultMovementSpeed)) = value;
			}
		}

		// Token: 0x17001F13 RID: 7955
		// (get) Token: 0x060067FF RID: 26623 RVA: 0x001D6718 File Offset: 0x001D4918
		// (set) Token: 0x06006800 RID: 26624 RVA: 0x00030E43 File Offset: 0x0002F043
		public unsafe AvatarWeapon DefaultWeapon
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CombatBehaviour.NativeFieldInfoPtr_DefaultWeapon);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AvatarWeapon>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CombatBehaviour.NativeFieldInfoPtr_DefaultWeapon), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001F14 RID: 7956
		// (get) Token: 0x06006801 RID: 26625 RVA: 0x001D6748 File Offset: 0x001D4948
		// (set) Token: 0x06006802 RID: 26626 RVA: 0x00030E62 File Offset: 0x0002F062
		public unsafe AvatarMeleeWeapon VirtualPunchWeapon
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CombatBehaviour.NativeFieldInfoPtr_VirtualPunchWeapon);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AvatarMeleeWeapon>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CombatBehaviour.NativeFieldInfoPtr_VirtualPunchWeapon), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001F15 RID: 7957
		// (get) Token: 0x06006803 RID: 26627 RVA: 0x001D6778 File Offset: 0x001D4978
		// (set) Token: 0x06006804 RID: 26628 RVA: 0x00030E81 File Offset: 0x0002F081
		public unsafe float DefaultSearchTime
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CombatBehaviour.NativeFieldInfoPtr_DefaultSearchTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CombatBehaviour.NativeFieldInfoPtr_DefaultSearchTime)) = value;
			}
		}

		// Token: 0x17001F16 RID: 7958
		// (get) Token: 0x06006805 RID: 26629 RVA: 0x001D67A0 File Offset: 0x001D49A0
		// (set) Token: 0x06006806 RID: 26630 RVA: 0x00030E9C File Offset: 0x0002F09C
		public unsafe bool overrideTargetDistance
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CombatBehaviour.NativeFieldInfoPtr_overrideTargetDistance);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CombatBehaviour.NativeFieldInfoPtr_overrideTargetDistance)) = value;
			}
		}

		// Token: 0x17001F17 RID: 7959
		// (get) Token: 0x06006807 RID: 26631 RVA: 0x001D67C8 File Offset: 0x001D49C8
		// (set) Token: 0x06006808 RID: 26632 RVA: 0x00030EB7 File Offset: 0x0002F0B7
		public unsafe float targetDistanceOverride
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CombatBehaviour.NativeFieldInfoPtr_targetDistanceOverride);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CombatBehaviour.NativeFieldInfoPtr_targetDistanceOverride)) = value;
			}
		}

		// Token: 0x17001F18 RID: 7960
		// (get) Token: 0x06006809 RID: 26633 RVA: 0x001D67F0 File Offset: 0x001D49F0
		// (set) Token: 0x0600680A RID: 26634 RVA: 0x00030ED2 File Offset: 0x0002F0D2
		public unsafe bool isTargetRecentlyVisible
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CombatBehaviour.NativeFieldInfoPtr_isTargetRecentlyVisible);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CombatBehaviour.NativeFieldInfoPtr_isTargetRecentlyVisible)) = value;
			}
		}

		// Token: 0x17001F19 RID: 7961
		// (get) Token: 0x0600680B RID: 26635 RVA: 0x001D6818 File Offset: 0x001D4A18
		// (set) Token: 0x0600680C RID: 26636 RVA: 0x00030EED File Offset: 0x0002F0ED
		public unsafe bool isTargetImmediatelyVisible
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CombatBehaviour.NativeFieldInfoPtr_isTargetImmediatelyVisible);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CombatBehaviour.NativeFieldInfoPtr_isTargetImmediatelyVisible)) = value;
			}
		}

		// Token: 0x17001F1A RID: 7962
		// (get) Token: 0x0600680D RID: 26637 RVA: 0x001D6840 File Offset: 0x001D4A40
		// (set) Token: 0x0600680E RID: 26638 RVA: 0x00030F08 File Offset: 0x0002F108
		public unsafe float timeSinceLastSighting
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CombatBehaviour.NativeFieldInfoPtr_timeSinceLastSighting);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CombatBehaviour.NativeFieldInfoPtr_timeSinceLastSighting)) = value;
			}
		}

		// Token: 0x17001F1B RID: 7963
		// (get) Token: 0x0600680F RID: 26639 RVA: 0x001D6868 File Offset: 0x001D4A68
		// (set) Token: 0x06006810 RID: 26640 RVA: 0x00030F23 File Offset: 0x0002F123
		public unsafe float playerSightedDuration
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CombatBehaviour.NativeFieldInfoPtr_playerSightedDuration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CombatBehaviour.NativeFieldInfoPtr_playerSightedDuration)) = value;
			}
		}

		// Token: 0x17001F1C RID: 7964
		// (get) Token: 0x06006811 RID: 26641 RVA: 0x001D6890 File Offset: 0x001D4A90
		// (set) Token: 0x06006812 RID: 26642 RVA: 0x00030F3E File Offset: 0x0002F13E
		public unsafe Vector3 lastKnownTargetPosition
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CombatBehaviour.NativeFieldInfoPtr_lastKnownTargetPosition);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CombatBehaviour.NativeFieldInfoPtr_lastKnownTargetPosition)) = value;
			}
		}

		// Token: 0x17001F1D RID: 7965
		// (get) Token: 0x06006813 RID: 26643 RVA: 0x001D68B8 File Offset: 0x001D4AB8
		// (set) Token: 0x06006814 RID: 26644 RVA: 0x00030F59 File Offset: 0x0002F159
		public unsafe AvatarWeapon currentWeapon
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CombatBehaviour.NativeFieldInfoPtr_currentWeapon);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AvatarWeapon>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CombatBehaviour.NativeFieldInfoPtr_currentWeapon), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001F1E RID: 7966
		// (get) Token: 0x06006815 RID: 26645 RVA: 0x001D68E8 File Offset: 0x001D4AE8
		// (set) Token: 0x06006816 RID: 26646 RVA: 0x00030F78 File Offset: 0x0002F178
		public unsafe int successfulHits
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CombatBehaviour.NativeFieldInfoPtr_successfulHits);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CombatBehaviour.NativeFieldInfoPtr_successfulHits)) = value;
			}
		}

		// Token: 0x17001F1F RID: 7967
		// (get) Token: 0x06006817 RID: 26647 RVA: 0x001D6910 File Offset: 0x001D4B10
		// (set) Token: 0x06006818 RID: 26648 RVA: 0x00030F93 File Offset: 0x0002F193
		public unsafe int consecutiveMissedShots
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CombatBehaviour.NativeFieldInfoPtr_consecutiveMissedShots);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CombatBehaviour.NativeFieldInfoPtr_consecutiveMissedShots)) = value;
			}
		}

		// Token: 0x17001F20 RID: 7968
		// (get) Token: 0x06006819 RID: 26649 RVA: 0x001D6938 File Offset: 0x001D4B38
		// (set) Token: 0x0600681A RID: 26650 RVA: 0x00030FAE File Offset: 0x0002F1AE
		public unsafe Coroutine rangedWeaponRoutine
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CombatBehaviour.NativeFieldInfoPtr_rangedWeaponRoutine);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CombatBehaviour.NativeFieldInfoPtr_rangedWeaponRoutine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001F21 RID: 7969
		// (get) Token: 0x0600681B RID: 26651 RVA: 0x001D6968 File Offset: 0x001D4B68
		// (set) Token: 0x0600681C RID: 26652 RVA: 0x00030FCD File Offset: 0x0002F1CD
		public unsafe Coroutine searchRoutine
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CombatBehaviour.NativeFieldInfoPtr_searchRoutine);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CombatBehaviour.NativeFieldInfoPtr_searchRoutine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001F22 RID: 7970
		// (get) Token: 0x0600681D RID: 26653 RVA: 0x001D6998 File Offset: 0x001D4B98
		// (set) Token: 0x0600681E RID: 26654 RVA: 0x00030FEC File Offset: 0x0002F1EC
		public unsafe Vector3 currentSearchDestination
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CombatBehaviour.NativeFieldInfoPtr_currentSearchDestination);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CombatBehaviour.NativeFieldInfoPtr_currentSearchDestination)) = value;
			}
		}

		// Token: 0x17001F23 RID: 7971
		// (get) Token: 0x0600681F RID: 26655 RVA: 0x001D69C0 File Offset: 0x001D4BC0
		// (set) Token: 0x06006820 RID: 26656 RVA: 0x00031007 File Offset: 0x0002F207
		public unsafe bool hasSearchDestination
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CombatBehaviour.NativeFieldInfoPtr_hasSearchDestination);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CombatBehaviour.NativeFieldInfoPtr_hasSearchDestination)) = value;
			}
		}

		// Token: 0x17001F24 RID: 7972
		// (get) Token: 0x06006821 RID: 26657 RVA: 0x001D69E8 File Offset: 0x001D4BE8
		// (set) Token: 0x06006822 RID: 26658 RVA: 0x00031022 File Offset: 0x0002F222
		public unsafe float nextAngryVO
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CombatBehaviour.NativeFieldInfoPtr_nextAngryVO);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CombatBehaviour.NativeFieldInfoPtr_nextAngryVO)) = value;
			}
		}

		// Token: 0x17001F25 RID: 7973
		// (get) Token: 0x06006823 RID: 26659 RVA: 0x001D6A10 File Offset: 0x001D4C10
		// (set) Token: 0x06006824 RID: 26660 RVA: 0x0003103D File Offset: 0x0002F23D
		public new unsafe bool field_Private_Boolean_0
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CombatBehaviour.NativeFieldInfoPtr_field_Private_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CombatBehaviour.NativeFieldInfoPtr_field_Private_Boolean_0)) = value;
			}
		}

		// Token: 0x17001F26 RID: 7974
		// (get) Token: 0x06006825 RID: 26661 RVA: 0x001D6A38 File Offset: 0x001D4C38
		// (set) Token: 0x06006826 RID: 26662 RVA: 0x00031058 File Offset: 0x0002F258
		public new unsafe bool field_Private_Boolean_1
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CombatBehaviour.NativeFieldInfoPtr_field_Private_Boolean_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CombatBehaviour.NativeFieldInfoPtr_field_Private_Boolean_1)) = value;
			}
		}

		// Token: 0x040046BC RID: 18108
		private static readonly System.IntPtr NativeFieldInfoPtr_EXTRA_VISIBILITY_TIME;

		// Token: 0x040046BD RID: 18109
		private static readonly System.IntPtr NativeFieldInfoPtr_SEARCH_RADIUS_MIN;

		// Token: 0x040046BE RID: 18110
		private static readonly System.IntPtr NativeFieldInfoPtr_SEARCH_RADIUS_MAX;

		// Token: 0x040046BF RID: 18111
		private static readonly System.IntPtr NativeFieldInfoPtr_SEARCH_SPEED;

		// Token: 0x040046C0 RID: 18112
		private static readonly System.IntPtr NativeFieldInfoPtr_CONSECUTIVE_MISS_ACCURACY_BOOST;

		// Token: 0x040046C1 RID: 18113
		private static readonly System.IntPtr NativeFieldInfoPtr_REACHED_DESTINATION_DISTANCE;

		// Token: 0x040046C2 RID: 18114
		private static readonly System.IntPtr NativeFieldInfoPtr__TargetPlayer_k__BackingField;

		// Token: 0x040046C3 RID: 18115
		private static readonly System.IntPtr NativeFieldInfoPtr__IsSearching_k__BackingField;

		// Token: 0x040046C4 RID: 18116
		private static readonly System.IntPtr NativeFieldInfoPtr__TimeSinceTargetReacquired_k__BackingField;

		// Token: 0x040046C5 RID: 18117
		private static readonly System.IntPtr NativeFieldInfoPtr_GiveUpRange;

		// Token: 0x040046C6 RID: 18118
		private static readonly System.IntPtr NativeFieldInfoPtr_GiveUpTime;

		// Token: 0x040046C7 RID: 18119
		private static readonly System.IntPtr NativeFieldInfoPtr_GiveUpAfterSuccessfulHits;

		// Token: 0x040046C8 RID: 18120
		private static readonly System.IntPtr NativeFieldInfoPtr_PlayAngryVO;

		// Token: 0x040046C9 RID: 18121
		private static readonly System.IntPtr NativeFieldInfoPtr_DefaultMovementSpeed;

		// Token: 0x040046CA RID: 18122
		private static readonly System.IntPtr NativeFieldInfoPtr_DefaultWeapon;

		// Token: 0x040046CB RID: 18123
		private static readonly System.IntPtr NativeFieldInfoPtr_VirtualPunchWeapon;

		// Token: 0x040046CC RID: 18124
		private static readonly System.IntPtr NativeFieldInfoPtr_DefaultSearchTime;

		// Token: 0x040046CD RID: 18125
		private static readonly System.IntPtr NativeFieldInfoPtr_overrideTargetDistance;

		// Token: 0x040046CE RID: 18126
		private static readonly System.IntPtr NativeFieldInfoPtr_targetDistanceOverride;

		// Token: 0x040046CF RID: 18127
		private static readonly System.IntPtr NativeFieldInfoPtr_isTargetRecentlyVisible;

		// Token: 0x040046D0 RID: 18128
		private static readonly System.IntPtr NativeFieldInfoPtr_isTargetImmediatelyVisible;

		// Token: 0x040046D1 RID: 18129
		private static readonly System.IntPtr NativeFieldInfoPtr_timeSinceLastSighting;

		// Token: 0x040046D2 RID: 18130
		private static readonly System.IntPtr NativeFieldInfoPtr_playerSightedDuration;

		// Token: 0x040046D3 RID: 18131
		private static readonly System.IntPtr NativeFieldInfoPtr_lastKnownTargetPosition;

		// Token: 0x040046D4 RID: 18132
		private static readonly System.IntPtr NativeFieldInfoPtr_currentWeapon;

		// Token: 0x040046D5 RID: 18133
		private static readonly System.IntPtr NativeFieldInfoPtr_successfulHits;

		// Token: 0x040046D6 RID: 18134
		private static readonly System.IntPtr NativeFieldInfoPtr_consecutiveMissedShots;

		// Token: 0x040046D7 RID: 18135
		private static readonly System.IntPtr NativeFieldInfoPtr_rangedWeaponRoutine;

		// Token: 0x040046D8 RID: 18136
		private static readonly System.IntPtr NativeFieldInfoPtr_searchRoutine;

		// Token: 0x040046D9 RID: 18137
		private static readonly System.IntPtr NativeFieldInfoPtr_currentSearchDestination;

		// Token: 0x040046DA RID: 18138
		private static readonly System.IntPtr NativeFieldInfoPtr_hasSearchDestination;

		// Token: 0x040046DB RID: 18139
		private static readonly System.IntPtr NativeFieldInfoPtr_nextAngryVO;

		// Token: 0x040046DC RID: 18140
		private static readonly System.IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

		// Token: 0x040046DD RID: 18141
		private static readonly System.IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

		// Token: 0x040046DE RID: 18142
		private static readonly System.IntPtr NativeMethodInfoPtr_get_TargetPlayer_Public_get_Player_0;

		// Token: 0x040046DF RID: 18143
		private static readonly System.IntPtr NativeMethodInfoPtr_set_TargetPlayer_Protected_set_Void_Player_0;

		// Token: 0x040046E0 RID: 18144
		private static readonly System.IntPtr NativeMethodInfoPtr_get_IsSearching_Public_get_Boolean_0;

		// Token: 0x040046E1 RID: 18145
		private static readonly System.IntPtr NativeMethodInfoPtr_set_IsSearching_Protected_set_Void_Boolean_0;

		// Token: 0x040046E2 RID: 18146
		private static readonly System.IntPtr NativeMethodInfoPtr_get_TimeSinceTargetReacquired_Public_get_Single_0;

		// Token: 0x040046E3 RID: 18147
		private static readonly System.IntPtr NativeMethodInfoPtr_set_TimeSinceTargetReacquired_Protected_set_Void_Single_0;

		// Token: 0x040046E4 RID: 18148
		private static readonly System.IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;

		// Token: 0x040046E5 RID: 18149
		private static readonly System.IntPtr NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0;

		// Token: 0x040046E6 RID: 18150
		private static readonly System.IntPtr NativeMethodInfoPtr_SetTarget_Public_Virtual_New_Void_NetworkConnection_NetworkObject_0;

		// Token: 0x040046E7 RID: 18151
		private static readonly System.IntPtr NativeMethodInfoPtr_Begin_Protected_Virtual_Void_1;

		// Token: 0x040046E8 RID: 18152
		private static readonly System.IntPtr NativeMethodInfoPtr_Resume_Protected_Virtual_Void_1;

		// Token: 0x040046E9 RID: 18153
		private static readonly System.IntPtr NativeMethodInfoPtr_Pause_Protected_Virtual_Void_1;

		// Token: 0x040046EA RID: 18154
		private static readonly System.IntPtr NativeMethodInfoPtr_End_Protected_Virtual_Void_1;

		// Token: 0x040046EB RID: 18155
		private static readonly System.IntPtr NativeMethodInfoPtr_Disable_Public_Virtual_Void_0;

		// Token: 0x040046EC RID: 18156
		private static readonly System.IntPtr NativeMethodInfoPtr_StartCombat_Protected_Virtual_New_Void_0;

		// Token: 0x040046ED RID: 18157
		private static readonly System.IntPtr NativeMethodInfoPtr_EndCombat_Protected_Void_0;

		// Token: 0x040046EE RID: 18158
		private static readonly System.IntPtr NativeMethodInfoPtr_BehaviourUpdate_Public_Virtual_Void_0;

		// Token: 0x040046EF RID: 18159
		private static readonly System.IntPtr NativeMethodInfoPtr_FixedUpdate_Protected_Virtual_New_Void_0;

		// Token: 0x040046F0 RID: 18160
		private static readonly System.IntPtr NativeMethodInfoPtr_UpdateTimeout_Protected_Void_0;

		// Token: 0x040046F1 RID: 18161
		private static readonly System.IntPtr NativeMethodInfoPtr_UpdateLookAt_Protected_Virtual_New_Void_0;

		// Token: 0x040046F2 RID: 18162
		private static readonly System.IntPtr NativeMethodInfoPtr_SetMovementSpeed_Protected_Void_Single_0;

		// Token: 0x040046F3 RID: 18163
		private static readonly System.IntPtr NativeMethodInfoPtr_SetWeapon_Protected_Virtual_New_Void_String_0;

		// Token: 0x040046F4 RID: 18164
		private static readonly System.IntPtr NativeMethodInfoPtr_ClearWeapon_Protected_Void_0;

		// Token: 0x040046F5 RID: 18165
		private static readonly System.IntPtr NativeMethodInfoPtr_ReadyToAttack_Protected_Virtual_New_Boolean_Boolean_0;

		// Token: 0x040046F6 RID: 18166
		private static readonly System.IntPtr NativeMethodInfoPtr_Attack_Protected_Virtual_New_Void_0;

		// Token: 0x040046F7 RID: 18167
		private static readonly System.IntPtr NativeMethodInfoPtr_SucessfulHit_Protected_Void_0;

		// Token: 0x040046F8 RID: 18168
		private static readonly System.IntPtr NativeMethodInfoPtr_CheckPlayerVisibility_Protected_Void_0;

		// Token: 0x040046F9 RID: 18169
		private static readonly System.IntPtr NativeMethodInfoPtr_MarkPlayerVisible_Public_Void_0;

		// Token: 0x040046FA RID: 18170
		private static readonly System.IntPtr NativeMethodInfoPtr_IsPlayerVisible_Protected_Boolean_0;

		// Token: 0x040046FB RID: 18171
		private static readonly System.IntPtr NativeMethodInfoPtr_ProcessVisionEvent_Private_Void_VisionEventReceipt_0;

		// Token: 0x040046FC RID: 18172
		private static readonly System.IntPtr NativeMethodInfoPtr_GetSearchTime_Protected_Virtual_New_Single_0;

		// Token: 0x040046FD RID: 18173
		private static readonly System.IntPtr NativeMethodInfoPtr_StartSearching_Private_Void_0;

		// Token: 0x040046FE RID: 18174
		private static readonly System.IntPtr NativeMethodInfoPtr_StopSearching_Private_Void_0;

		// Token: 0x040046FF RID: 18175
		private static readonly System.IntPtr NativeMethodInfoPtr_SearchRoutine_Private_IEnumerator_0;

		// Token: 0x04004700 RID: 18176
		private static readonly System.IntPtr NativeMethodInfoPtr_GetNextSearchLocation_Private_Vector3_0;

		// Token: 0x04004701 RID: 18177
		private static readonly System.IntPtr NativeMethodInfoPtr_IsTargetValid_Protected_Boolean_0;

		// Token: 0x04004702 RID: 18178
		private static readonly System.IntPtr NativeMethodInfoPtr_RepositionToTargetRange_Private_Void_Vector3_0;

		// Token: 0x04004703 RID: 18179
		private static readonly System.IntPtr NativeMethodInfoPtr_GetRandomReachablePointNear_Private_Vector3_Vector3_Single_Single_0;

		// Token: 0x04004704 RID: 18180
		private static readonly System.IntPtr NativeMethodInfoPtr_GetMinTargetDistance_Protected_Single_0;

		// Token: 0x04004705 RID: 18181
		private static readonly System.IntPtr NativeMethodInfoPtr_GetMaxTargetDistance_Protected_Single_0;

		// Token: 0x04004706 RID: 18182
		private static readonly System.IntPtr NativeMethodInfoPtr_IsTargetInRange_Protected_Boolean_Vector3_0;

		// Token: 0x04004707 RID: 18183
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04004708 RID: 18184
		private static readonly System.IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

		// Token: 0x04004709 RID: 18185
		private static readonly System.IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

		// Token: 0x0400470A RID: 18186
		private static readonly System.IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

		// Token: 0x0400470B RID: 18187
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcWriter___Observers_SetTarget_1824087381_Private_Void_NetworkConnection_NetworkObject_0;

		// Token: 0x0400470C RID: 18188
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcLogic___SetTarget_1824087381_Public_Virtual_New_Void_NetworkConnection_NetworkObject_0;

		// Token: 0x0400470D RID: 18189
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcReader___Observers_SetTarget_1824087381_Private_Void_PooledReader_Channel_0;

		// Token: 0x0400470E RID: 18190
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcWriter___Observers_SetWeapon_3615296227_Private_Void_String_0;

		// Token: 0x0400470F RID: 18191
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcLogic___SetWeapon_3615296227_Protected_Virtual_New_Void_String_0;

		// Token: 0x04004710 RID: 18192
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcReader___Observers_SetWeapon_3615296227_Private_Void_PooledReader_Channel_0;

		// Token: 0x04004711 RID: 18193
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcWriter___Observers_ClearWeapon_2166136261_Private_Void_0;

		// Token: 0x04004712 RID: 18194
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcLogic___ClearWeapon_2166136261_Protected_Void_0;

		// Token: 0x04004713 RID: 18195
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcReader___Observers_ClearWeapon_2166136261_Private_Void_PooledReader_Channel_0;

		// Token: 0x04004714 RID: 18196
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcWriter___Observers_Attack_2166136261_Private_Void_0;

		// Token: 0x04004715 RID: 18197
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcLogic___Attack_2166136261_Protected_Virtual_New_Void_0;

		// Token: 0x04004716 RID: 18198
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcReader___Observers_Attack_2166136261_Private_Void_PooledReader_Channel_0;

		// Token: 0x04004717 RID: 18199
		private static readonly System.IntPtr NativeMethodInfoPtr_Method_Protected_Virtual_Void_0;

		// Token: 0x02000A7D RID: 2685
		[ObfuscatedName("ScheduleOne.Combat.CombatBehaviour+<SearchRoutine>d__68")]
		public sealed class _SearchRoutine_d__68 : Il2CppSystem.Object
		{
			// Token: 0x0600D4A0 RID: 54432 RVA: 0x00333184 File Offset: 0x00331384
			// Note: this type is marked as 'beforefieldinit'.
			static _SearchRoutine_d__68()
			{
				Il2CppClassPointerStore<CombatBehaviour._SearchRoutine_d__68>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CombatBehaviour>.NativeClassPtr, "<SearchRoutine>d__68");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CombatBehaviour._SearchRoutine_d__68>.NativeClassPtr);
				CombatBehaviour._SearchRoutine_d__68.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombatBehaviour._SearchRoutine_d__68>.NativeClassPtr, "<>1__state");
				CombatBehaviour._SearchRoutine_d__68.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombatBehaviour._SearchRoutine_d__68>.NativeClassPtr, "<>2__current");
				CombatBehaviour._SearchRoutine_d__68.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombatBehaviour._SearchRoutine_d__68>.NativeClassPtr, "<>4__this");
				CombatBehaviour._SearchRoutine_d__68.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatBehaviour._SearchRoutine_d__68>.NativeClassPtr, 100676551);
				CombatBehaviour._SearchRoutine_d__68.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatBehaviour._SearchRoutine_d__68>.NativeClassPtr, 100676552);
				CombatBehaviour._SearchRoutine_d__68.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatBehaviour._SearchRoutine_d__68>.NativeClassPtr, 100676553);
				CombatBehaviour._SearchRoutine_d__68.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatBehaviour._SearchRoutine_d__68>.NativeClassPtr, 100676554);
				CombatBehaviour._SearchRoutine_d__68.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatBehaviour._SearchRoutine_d__68>.NativeClassPtr, 100676555);
				CombatBehaviour._SearchRoutine_d__68.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatBehaviour._SearchRoutine_d__68>.NativeClassPtr, 100676556);
			}

			// Token: 0x0600D4A1 RID: 54433 RVA: 0x00333264 File Offset: 0x00331464
			[CallerCount(54)]
			[CachedScanResults(RefRangeStart = 2646, RefRangeEnd = 2700, XrefRangeStart = 2646, XrefRangeEnd = 2700, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _SearchRoutine_d__68(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CombatBehaviour._SearchRoutine_d__68>.NativeClassPtr))
			{
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = ref <>1__state;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CombatBehaviour._SearchRoutine_d__68.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600D4A2 RID: 54434 RVA: 0x003332AC File Offset: 0x003314AC
			[CallerCount(14558)]
			[CachedScanResults(RefRangeStart = 2769, RefRangeEnd = 17327, XrefRangeStart = 2769, XrefRangeEnd = 17327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CombatBehaviour._SearchRoutine_d__68.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600D4A3 RID: 54435 RVA: 0x003332E0 File Offset: 0x003314E0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 210594, XrefRangeEnd = 210595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(CombatBehaviour._SearchRoutine_d__68.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x170041C7 RID: 16839
			// (get) Token: 0x0600D4A4 RID: 54436 RVA: 0x0033331C File Offset: 0x0033151C
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 2740, RefRangeEnd = 2764, XrefRangeStart = 2740, XrefRangeEnd = 2764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CombatBehaviour._SearchRoutine_d__68.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
			}

			// Token: 0x0600D4A5 RID: 54437 RVA: 0x0033335C File Offset: 0x0033155C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 210595, XrefRangeEnd = 210600, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CombatBehaviour._SearchRoutine_d__68.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x170041C8 RID: 16840
			// (get) Token: 0x0600D4A6 RID: 54438 RVA: 0x00333390 File Offset: 0x00331590
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 2740, RefRangeEnd = 2764, XrefRangeStart = 2740, XrefRangeEnd = 2764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CombatBehaviour._SearchRoutine_d__68.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
			}

			// Token: 0x0600D4A7 RID: 54439 RVA: 0x00067228 File Offset: 0x00065428
			public _SearchRoutine_d__68(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170041C4 RID: 16836
			// (get) Token: 0x0600D4A8 RID: 54440 RVA: 0x003333D0 File Offset: 0x003315D0
			// (set) Token: 0x0600D4A9 RID: 54441 RVA: 0x00067231 File Offset: 0x00065431
			public unsafe int __1__state
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CombatBehaviour._SearchRoutine_d__68.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CombatBehaviour._SearchRoutine_d__68.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170041C5 RID: 16837
			// (get) Token: 0x0600D4AA RID: 54442 RVA: 0x003333F8 File Offset: 0x003315F8
			// (set) Token: 0x0600D4AB RID: 54443 RVA: 0x0006724C File Offset: 0x0006544C
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CombatBehaviour._SearchRoutine_d__68.NativeFieldInfoPtr___2__current);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CombatBehaviour._SearchRoutine_d__68.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170041C6 RID: 16838
			// (get) Token: 0x0600D4AC RID: 54444 RVA: 0x00333428 File Offset: 0x00331628
			// (set) Token: 0x0600D4AD RID: 54445 RVA: 0x0006726B File Offset: 0x0006546B
			public unsafe CombatBehaviour __4__this
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CombatBehaviour._SearchRoutine_d__68.NativeFieldInfoPtr___4__this);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<CombatBehaviour>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CombatBehaviour._SearchRoutine_d__68.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008F75 RID: 36725
			private static readonly System.IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04008F76 RID: 36726
			private static readonly System.IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04008F77 RID: 36727
			private static readonly System.IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04008F78 RID: 36728
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04008F79 RID: 36729
			private static readonly System.IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008F7A RID: 36730
			private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04008F7B RID: 36731
			private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04008F7C RID: 36732
			private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008F7D RID: 36733
			private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
