using System;
using Il2CppFishNet.Connection;
using Il2CppFishNet.Object;
using Il2CppFishNet.Object.Synchronizing;
using Il2CppFishNet.Serializing;
using Il2CppFishNet.Transporting;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Audio;
using Il2CppScheduleOne.Law;
using Il2CppScheduleOne.NPCs;
using Il2CppScheduleOne.Police;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.PlayerScripts
{
	// Token: 0x02000405 RID: 1029
	public class PlayerCrimeData : NetworkBehaviour
	{
		// Token: 0x060051B4 RID: 20916 RVA: 0x00187C04 File Offset: 0x00185E04
		// Note: this type is marked as 'beforefieldinit'.
		static PlayerCrimeData()
		{
			Il2CppClassPointerStore<PlayerCrimeData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.PlayerScripts", "PlayerCrimeData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayerCrimeData>.NativeClassPtr);
			PlayerCrimeData.NativeFieldInfoPtr_SEARCH_TIME_INVESTIGATING = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCrimeData>.NativeClassPtr, "SEARCH_TIME_INVESTIGATING");
			PlayerCrimeData.NativeFieldInfoPtr_SEARCH_TIME_ARRESTING = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCrimeData>.NativeClassPtr, "SEARCH_TIME_ARRESTING");
			PlayerCrimeData.NativeFieldInfoPtr_SEARCH_TIME_NONLETHAL = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCrimeData>.NativeClassPtr, "SEARCH_TIME_NONLETHAL");
			PlayerCrimeData.NativeFieldInfoPtr_SEARCH_TIME_LETHAL = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCrimeData>.NativeClassPtr, "SEARCH_TIME_LETHAL");
			PlayerCrimeData.NativeFieldInfoPtr_ESCALATION_TIME_ARRESTING = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCrimeData>.NativeClassPtr, "ESCALATION_TIME_ARRESTING");
			PlayerCrimeData.NativeFieldInfoPtr_ESCALATION_TIME_NONLETHAL = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCrimeData>.NativeClassPtr, "ESCALATION_TIME_NONLETHAL");
			PlayerCrimeData.NativeFieldInfoPtr_SHOT_COOLDOWN_MIN = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCrimeData>.NativeClassPtr, "SHOT_COOLDOWN_MIN");
			PlayerCrimeData.NativeFieldInfoPtr_SHOT_COOLDOWN_MAX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCrimeData>.NativeClassPtr, "SHOT_COOLDOWN_MAX");
			PlayerCrimeData.NativeFieldInfoPtr_VEHICLE_COLLISION_LIFETIME = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCrimeData>.NativeClassPtr, "VEHICLE_COLLISION_LIFETIME");
			PlayerCrimeData.NativeFieldInfoPtr_VEHICLE_COLLISION_LIMIT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCrimeData>.NativeClassPtr, "VEHICLE_COLLISION_LIMIT");
			PlayerCrimeData.NativeFieldInfoPtr_NearestOfficer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCrimeData>.NativeClassPtr, "NearestOfficer");
			PlayerCrimeData.NativeFieldInfoPtr_Player = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCrimeData>.NativeClassPtr, "Player");
			PlayerCrimeData.NativeFieldInfoPtr_onPursuitEscapedSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCrimeData>.NativeClassPtr, "onPursuitEscapedSound");
			PlayerCrimeData.NativeFieldInfoPtr__CurrentPursuitLevel_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCrimeData>.NativeClassPtr, "<CurrentPursuitLevel>k__BackingField");
			PlayerCrimeData.NativeFieldInfoPtr__LastKnownPosition_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCrimeData>.NativeClassPtr, "<LastKnownPosition>k__BackingField");
			PlayerCrimeData.NativeFieldInfoPtr_Pursuers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCrimeData>.NativeClassPtr, "Pursuers");
			PlayerCrimeData.NativeFieldInfoPtr__CurrentArrestProgress_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCrimeData>.NativeClassPtr, "<CurrentArrestProgress>k__BackingField");
			PlayerCrimeData.NativeFieldInfoPtr__CurrentBodySearchProgress_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCrimeData>.NativeClassPtr, "<CurrentBodySearchProgress>k__BackingField");
			PlayerCrimeData.NativeFieldInfoPtr_TimeSincePursuitStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCrimeData>.NativeClassPtr, "TimeSincePursuitStart");
			PlayerCrimeData.NativeFieldInfoPtr_CurrentPursuitLevelDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCrimeData>.NativeClassPtr, "CurrentPursuitLevelDuration");
			PlayerCrimeData.NativeFieldInfoPtr_TimeSinceSighted = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCrimeData>.NativeClassPtr, "TimeSinceSighted");
			PlayerCrimeData.NativeFieldInfoPtr_Crimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCrimeData>.NativeClassPtr, "Crimes");
			PlayerCrimeData.NativeFieldInfoPtr_BodySearchPending = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCrimeData>.NativeClassPtr, "BodySearchPending");
			PlayerCrimeData.NativeFieldInfoPtr__TimeSinceLastBodySearch_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCrimeData>.NativeClassPtr, "<TimeSinceLastBodySearch>k__BackingField");
			PlayerCrimeData.NativeFieldInfoPtr__EvadedArrest_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCrimeData>.NativeClassPtr, "<EvadedArrest>k__BackingField");
			PlayerCrimeData.NativeFieldInfoPtr_timeSinceLastShot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCrimeData>.NativeClassPtr, "timeSinceLastShot");
			PlayerCrimeData.NativeFieldInfoPtr_Collisions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCrimeData>.NativeClassPtr, "Collisions");
			PlayerCrimeData.NativeFieldInfoPtr__lightCombatTrack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCrimeData>.NativeClassPtr, "_lightCombatTrack");
			PlayerCrimeData.NativeFieldInfoPtr__heavyCombatTrack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCrimeData>.NativeClassPtr, "_heavyCombatTrack");
			PlayerCrimeData.NativeFieldInfoPtr_outOfSightTimeToDipMusic = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCrimeData>.NativeClassPtr, "outOfSightTimeToDipMusic");
			PlayerCrimeData.NativeFieldInfoPtr_minMusicVolume = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCrimeData>.NativeClassPtr, "minMusicVolume");
			PlayerCrimeData.NativeFieldInfoPtr_musicChangeRate_Down = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCrimeData>.NativeClassPtr, "musicChangeRate_Down");
			PlayerCrimeData.NativeFieldInfoPtr_musicChangeRate_Up = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCrimeData>.NativeClassPtr, "musicChangeRate_Up");
			PlayerCrimeData.NativeFieldInfoPtr_syncVar____CurrentPursuitLevel_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCrimeData>.NativeClassPtr, "syncVar___<CurrentPursuitLevel>k__BackingField");
			PlayerCrimeData.NativeFieldInfoPtr_syncVar____LastKnownPosition_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCrimeData>.NativeClassPtr, "syncVar___<LastKnownPosition>k__BackingField");
			PlayerCrimeData.NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCrimeData>.NativeClassPtr, "NetworkInitialize___EarlyScheduleOne.PlayerScripts.PlayerCrimeDataAssembly-CSharp.dll_Excuted");
			PlayerCrimeData.NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCrimeData>.NativeClassPtr, "NetworkInitialize__LateScheduleOne.PlayerScripts.PlayerCrimeDataAssembly-CSharp.dll_Excuted");
			PlayerCrimeData.NativeMethodInfoPtr_get_CurrentPursuitLevel_Public_get_EPursuitLevel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCrimeData>.NativeClassPtr, 100673637);
			PlayerCrimeData.NativeMethodInfoPtr_set_CurrentPursuitLevel_Protected_set_Void_EPursuitLevel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCrimeData>.NativeClassPtr, 100673638);
			PlayerCrimeData.NativeMethodInfoPtr_get_LastKnownPosition_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCrimeData>.NativeClassPtr, 100673639);
			PlayerCrimeData.NativeMethodInfoPtr_set_LastKnownPosition_Protected_set_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCrimeData>.NativeClassPtr, 100673640);
			PlayerCrimeData.NativeMethodInfoPtr_get_CurrentArrestProgress_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCrimeData>.NativeClassPtr, 100673641);
			PlayerCrimeData.NativeMethodInfoPtr_set_CurrentArrestProgress_Protected_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCrimeData>.NativeClassPtr, 100673642);
			PlayerCrimeData.NativeMethodInfoPtr_get_CurrentBodySearchProgress_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCrimeData>.NativeClassPtr, 100673643);
			PlayerCrimeData.NativeMethodInfoPtr_set_CurrentBodySearchProgress_Protected_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCrimeData>.NativeClassPtr, 100673644);
			PlayerCrimeData.NativeMethodInfoPtr_get_TimeSinceLastBodySearch_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCrimeData>.NativeClassPtr, 100673645);
			PlayerCrimeData.NativeMethodInfoPtr_set_TimeSinceLastBodySearch_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCrimeData>.NativeClassPtr, 100673646);
			PlayerCrimeData.NativeMethodInfoPtr_get_EvadedArrest_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCrimeData>.NativeClassPtr, 100673647);
			PlayerCrimeData.NativeMethodInfoPtr_set_EvadedArrest_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCrimeData>.NativeClassPtr, 100673648);
			PlayerCrimeData.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCrimeData>.NativeClassPtr, 100673649);
			PlayerCrimeData.NativeMethodInfoPtr_Start_Private_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCrimeData>.NativeClassPtr, 100673650);
			PlayerCrimeData.NativeMethodInfoPtr_OnDestroy_Private_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCrimeData>.NativeClassPtr, 100673651);
			PlayerCrimeData.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCrimeData>.NativeClassPtr, 100673652);
			PlayerCrimeData.NativeMethodInfoPtr_LateUpdate_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCrimeData>.NativeClassPtr, 100673653);
			PlayerCrimeData.NativeMethodInfoPtr_SetPursuitLevel_Public_Void_EPursuitLevel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCrimeData>.NativeClassPtr, 100673654);
			PlayerCrimeData.NativeMethodInfoPtr_Escalate_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCrimeData>.NativeClassPtr, 100673655);
			PlayerCrimeData.NativeMethodInfoPtr_Deescalate_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCrimeData>.NativeClassPtr, 100673656);
			PlayerCrimeData.NativeMethodInfoPtr_RecordLastKnownPosition_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCrimeData>.NativeClassPtr, 100673657);
			PlayerCrimeData.NativeMethodInfoPtr_SetArrestProgress_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCrimeData>.NativeClassPtr, 100673658);
			PlayerCrimeData.NativeMethodInfoPtr_ResetBodysearchCooldown_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCrimeData>.NativeClassPtr, 100673659);
			PlayerCrimeData.NativeMethodInfoPtr_SetBodySearchProgress_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCrimeData>.NativeClassPtr, 100673660);
			PlayerCrimeData.NativeMethodInfoPtr_OnDie_Private_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCrimeData>.NativeClassPtr, 100673661);
			PlayerCrimeData.NativeMethodInfoPtr_AddCrime_Public_Void_Crime_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCrimeData>.NativeClassPtr, 100673662);
			PlayerCrimeData.NativeMethodInfoPtr_ClearCrimes_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCrimeData>.NativeClassPtr, 100673663);
			PlayerCrimeData.NativeMethodInfoPtr_IsCrimeOnRecord_Public_Boolean_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCrimeData>.NativeClassPtr, 100673664);
			PlayerCrimeData.NativeMethodInfoPtr_SetEvaded_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCrimeData>.NativeClassPtr, 100673665);
			PlayerCrimeData.NativeMethodInfoPtr_OnSleepStart_Private_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCrimeData>.NativeClassPtr, 100673666);
			PlayerCrimeData.NativeMethodInfoPtr_UpdateEscalation_Private_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCrimeData>.NativeClassPtr, 100673667);
			PlayerCrimeData.NativeMethodInfoPtr_UpdateTimeout_Private_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCrimeData>.NativeClassPtr, 100673668);
			PlayerCrimeData.NativeMethodInfoPtr_UpdateMusic_Private_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCrimeData>.NativeClassPtr, 100673669);
			PlayerCrimeData.NativeMethodInfoPtr_TimeoutPursuit_Private_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCrimeData>.NativeClassPtr, 100673670);
			PlayerCrimeData.NativeMethodInfoPtr_GetSearchTime_Public_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCrimeData>.NativeClassPtr, 100673671);
			PlayerCrimeData.NativeMethodInfoPtr_ResetShotAccuracy_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCrimeData>.NativeClassPtr, 100673672);
			PlayerCrimeData.NativeMethodInfoPtr_GetShotAccuracyMultiplier_Public_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCrimeData>.NativeClassPtr, 100673673);
			PlayerCrimeData.NativeMethodInfoPtr_RecordVehicleCollision_Public_Void_NPC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCrimeData>.NativeClassPtr, 100673674);
			PlayerCrimeData.NativeMethodInfoPtr_CheckNearestOfficer_Private_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCrimeData>.NativeClassPtr, 100673675);
			PlayerCrimeData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCrimeData>.NativeClassPtr, 100673676);
			PlayerCrimeData.NativeMethodInfoPtr__Awake_b__53_0_Private_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCrimeData>.NativeClassPtr, 100673677);
			PlayerCrimeData.NativeMethodInfoPtr__CheckNearestOfficer_b__79_0_Private_Single_PoliceOfficer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCrimeData>.NativeClassPtr, 100673678);
			PlayerCrimeData.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCrimeData>.NativeClassPtr, 100673679);
			PlayerCrimeData.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCrimeData>.NativeClassPtr, 100673680);
			PlayerCrimeData.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCrimeData>.NativeClassPtr, 100673681);
			PlayerCrimeData.NativeMethodInfoPtr_RpcWriter___Server_set_CurrentPursuitLevel_2979171596_Private_Void_EPursuitLevel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCrimeData>.NativeClassPtr, 100673682);
			PlayerCrimeData.NativeMethodInfoPtr_RpcLogic___set_CurrentPursuitLevel_2979171596_Protected_Void_EPursuitLevel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCrimeData>.NativeClassPtr, 100673683);
			PlayerCrimeData.NativeMethodInfoPtr_RpcReader___Server_set_CurrentPursuitLevel_2979171596_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCrimeData>.NativeClassPtr, 100673684);
			PlayerCrimeData.NativeMethodInfoPtr_RpcWriter___Server_set_LastKnownPosition_4276783012_Private_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCrimeData>.NativeClassPtr, 100673685);
			PlayerCrimeData.NativeMethodInfoPtr_RpcLogic___set_LastKnownPosition_4276783012_Protected_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCrimeData>.NativeClassPtr, 100673686);
			PlayerCrimeData.NativeMethodInfoPtr_RpcReader___Server_set_LastKnownPosition_4276783012_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCrimeData>.NativeClassPtr, 100673687);
			PlayerCrimeData.NativeMethodInfoPtr_RpcWriter___Observers_RecordLastKnownPosition_1140765316_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCrimeData>.NativeClassPtr, 100673688);
			PlayerCrimeData.NativeMethodInfoPtr_RpcLogic___RecordLastKnownPosition_1140765316_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCrimeData>.NativeClassPtr, 100673689);
			PlayerCrimeData.NativeMethodInfoPtr_RpcReader___Observers_RecordLastKnownPosition_1140765316_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCrimeData>.NativeClassPtr, 100673690);
			PlayerCrimeData.NativeMethodInfoPtr_sync___get_value__CurrentPursuitLevel_k__BackingField_Public_get_EPursuitLevel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCrimeData>.NativeClassPtr, 100673691);
			PlayerCrimeData.NativeMethodInfoPtr_sync___set_value__CurrentPursuitLevel_k__BackingField_Public_set_Void_EPursuitLevel_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCrimeData>.NativeClassPtr, 100673692);
			PlayerCrimeData.NativeMethodInfoPtr_ReadSyncVar___ScheduleOne_PlayerScripts_PlayerCrimeData_Public_Virtual_Boolean_PooledReader_UInt32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCrimeData>.NativeClassPtr, 100673693);
			PlayerCrimeData.NativeMethodInfoPtr_sync___get_value__LastKnownPosition_k__BackingField_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCrimeData>.NativeClassPtr, 100673694);
			PlayerCrimeData.NativeMethodInfoPtr_sync___set_value__LastKnownPosition_k__BackingField_Public_set_Void_Vector3_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCrimeData>.NativeClassPtr, 100673695);
			PlayerCrimeData.NativeMethodInfoPtr_Method_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCrimeData>.NativeClassPtr, 100673696);
		}

		// Token: 0x1700186D RID: 6253
		// (get) Token: 0x060051B5 RID: 20917 RVA: 0x001883C8 File Offset: 0x001865C8
		// (set) Token: 0x060051B6 RID: 20918 RVA: 0x00188404 File Offset: 0x00186604
		public unsafe PlayerCrimeData.EPursuitLevel CurrentPursuitLevel
		{
			[CallerCount(40)]
			[CachedScanResults(RefRangeStart = 63475, RefRangeEnd = 63515, XrefRangeStart = 63475, XrefRangeEnd = 63515, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(PlayerCrimeData.NativeMethodInfoPtr_get_CurrentPursuitLevel_Public_get_EPursuitLevel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 178819, RefRangeEnd = 178820, XrefRangeStart = 178786, XrefRangeEnd = 178819, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = ref value;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCrimeData.NativeMethodInfoPtr_set_CurrentPursuitLevel_Protected_set_Void_EPursuitLevel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x1700186E RID: 6254
		// (get) Token: 0x060051B7 RID: 20919 RVA: 0x00188444 File Offset: 0x00186644
		// (set) Token: 0x060051B8 RID: 20920 RVA: 0x00188480 File Offset: 0x00186680
		public unsafe Vector3 LastKnownPosition
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 178820, RefRangeEnd = 178834, XrefRangeStart = 178820, XrefRangeEnd = 178820, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(PlayerCrimeData.NativeMethodInfoPtr_get_LastKnownPosition_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 178834, XrefRangeEnd = 178842, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = ref value;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCrimeData.NativeMethodInfoPtr_set_LastKnownPosition_Protected_set_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x1700186F RID: 6255
		// (get) Token: 0x060051B9 RID: 20921 RVA: 0x001884C0 File Offset: 0x001866C0
		// (set) Token: 0x060051BA RID: 20922 RVA: 0x001884FC File Offset: 0x001866FC
		public unsafe float CurrentArrestProgress
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(PlayerCrimeData.NativeMethodInfoPtr_get_CurrentArrestProgress_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
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
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCrimeData.NativeMethodInfoPtr_set_CurrentArrestProgress_Protected_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x17001870 RID: 6256
		// (get) Token: 0x060051BB RID: 20923 RVA: 0x0018853C File Offset: 0x0018673C
		// (set) Token: 0x060051BC RID: 20924 RVA: 0x00188578 File Offset: 0x00186778
		public unsafe float CurrentBodySearchProgress
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(PlayerCrimeData.NativeMethodInfoPtr_get_CurrentBodySearchProgress_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
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
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCrimeData.NativeMethodInfoPtr_set_CurrentBodySearchProgress_Protected_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x17001871 RID: 6257
		// (get) Token: 0x060051BD RID: 20925 RVA: 0x001885B8 File Offset: 0x001867B8
		// (set) Token: 0x060051BE RID: 20926 RVA: 0x001885F4 File Offset: 0x001867F4
		public unsafe float TimeSinceLastBodySearch
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(PlayerCrimeData.NativeMethodInfoPtr_get_TimeSinceLastBodySearch_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
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
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCrimeData.NativeMethodInfoPtr_set_TimeSinceLastBodySearch_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x17001872 RID: 6258
		// (get) Token: 0x060051BF RID: 20927 RVA: 0x00188634 File Offset: 0x00186834
		// (set) Token: 0x060051C0 RID: 20928 RVA: 0x00188670 File Offset: 0x00186870
		public unsafe bool EvadedArrest
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(PlayerCrimeData.NativeMethodInfoPtr_get_EvadedArrest_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
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
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCrimeData.NativeMethodInfoPtr_set_EvadedArrest_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x060051C1 RID: 20929 RVA: 0x001886B0 File Offset: 0x001868B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 178842, XrefRangeEnd = 178843, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PlayerCrimeData.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060051C2 RID: 20930 RVA: 0x001886EC File Offset: 0x001868EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 178843, XrefRangeEnd = 178863, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCrimeData.NativeMethodInfoPtr_Start_Private_Void_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060051C3 RID: 20931 RVA: 0x00188720 File Offset: 0x00186920
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 178863, XrefRangeEnd = 178877, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCrimeData.NativeMethodInfoPtr_OnDestroy_Private_Void_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060051C4 RID: 20932 RVA: 0x00188754 File Offset: 0x00186954
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 178877, XrefRangeEnd = 178970, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PlayerCrimeData.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060051C5 RID: 20933 RVA: 0x00188790 File Offset: 0x00186990
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 178970, XrefRangeEnd = 178989, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void LateUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PlayerCrimeData.NativeMethodInfoPtr_LateUpdate_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060051C6 RID: 20934 RVA: 0x001887CC File Offset: 0x001869CC
		[CallerCount(30)]
		[CachedScanResults(RefRangeStart = 179024, RefRangeEnd = 179054, XrefRangeStart = 178989, XrefRangeEnd = 179024, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetPursuitLevel(PlayerCrimeData.EPursuitLevel level)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref level;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCrimeData.NativeMethodInfoPtr_SetPursuitLevel_Public_Void_EPursuitLevel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060051C7 RID: 20935 RVA: 0x0018880C File Offset: 0x00186A0C
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 179072, RefRangeEnd = 179079, XrefRangeStart = 179054, XrefRangeEnd = 179072, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Escalate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCrimeData.NativeMethodInfoPtr_Escalate_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060051C8 RID: 20936 RVA: 0x00188840 File Offset: 0x00186A40
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 179083, RefRangeEnd = 179084, XrefRangeStart = 179079, XrefRangeEnd = 179083, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Deescalate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCrimeData.NativeMethodInfoPtr_Deescalate_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060051C9 RID: 20937 RVA: 0x00188874 File Offset: 0x00186A74
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 179106, RefRangeEnd = 179120, XrefRangeStart = 179084, XrefRangeEnd = 179106, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RecordLastKnownPosition(bool resetTimeSinceSighted)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref resetTimeSinceSighted;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCrimeData.NativeMethodInfoPtr_RecordLastKnownPosition_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060051CA RID: 20938 RVA: 0x001888B4 File Offset: 0x00186AB4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 179122, RefRangeEnd = 179123, XrefRangeStart = 179120, XrefRangeEnd = 179122, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetArrestProgress(float progress)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref progress;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCrimeData.NativeMethodInfoPtr_SetArrestProgress_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060051CB RID: 20939 RVA: 0x001888F4 File Offset: 0x00186AF4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 179123, RefRangeEnd = 179126, XrefRangeStart = 179123, XrefRangeEnd = 179123, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ResetBodysearchCooldown()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCrimeData.NativeMethodInfoPtr_ResetBodysearchCooldown_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060051CC RID: 20940 RVA: 0x00188928 File Offset: 0x00186B28
		[CallerCount(0)]
		public unsafe void SetBodySearchProgress(float progress)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref progress;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCrimeData.NativeMethodInfoPtr_SetBodySearchProgress_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060051CD RID: 20941 RVA: 0x00188968 File Offset: 0x00186B68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 179126, XrefRangeEnd = 179128, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDie()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCrimeData.NativeMethodInfoPtr_OnDie_Private_Void_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060051CE RID: 20942 RVA: 0x0018899C File Offset: 0x00186B9C
		[CallerCount(16)]
		[CachedScanResults(RefRangeStart = 179155, RefRangeEnd = 179171, XrefRangeStart = 179128, XrefRangeEnd = 179155, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddCrime(Crime crime, int quantity = 1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(crime);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref quantity;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCrimeData.NativeMethodInfoPtr_AddCrime_Public_Void_Crime_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060051CF RID: 20943 RVA: 0x001889EC File Offset: 0x00186BEC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 179174, RefRangeEnd = 179176, XrefRangeStart = 179171, XrefRangeEnd = 179174, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ClearCrimes()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCrimeData.NativeMethodInfoPtr_ClearCrimes_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060051D0 RID: 20944 RVA: 0x00188A20 File Offset: 0x00186C20
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 179188, RefRangeEnd = 179190, XrefRangeStart = 179176, XrefRangeEnd = 179188, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsCrimeOnRecord(Il2CppSystem.Type crime)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(crime);
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(PlayerCrimeData.NativeMethodInfoPtr_IsCrimeOnRecord_Public_Boolean_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x060051D1 RID: 20945 RVA: 0x00188A70 File Offset: 0x00186C70
		[CallerCount(0)]
		public unsafe void SetEvaded()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCrimeData.NativeMethodInfoPtr_SetEvaded_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060051D2 RID: 20946 RVA: 0x00188AA4 File Offset: 0x00186CA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 179190, XrefRangeEnd = 179194, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnSleepStart()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCrimeData.NativeMethodInfoPtr_OnSleepStart_Private_Void_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060051D3 RID: 20947 RVA: 0x00188AD8 File Offset: 0x00186CD8
		[CallerCount(0)]
		public unsafe void UpdateEscalation()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCrimeData.NativeMethodInfoPtr_UpdateEscalation_Private_Void_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060051D4 RID: 20948 RVA: 0x00188B0C File Offset: 0x00186D0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 179194, XrefRangeEnd = 179213, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateTimeout()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCrimeData.NativeMethodInfoPtr_UpdateTimeout_Private_Void_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060051D5 RID: 20949 RVA: 0x00188B40 File Offset: 0x00186D40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 179213, XrefRangeEnd = 179218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateMusic()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCrimeData.NativeMethodInfoPtr_UpdateMusic_Private_Void_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060051D6 RID: 20950 RVA: 0x00188B74 File Offset: 0x00186D74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 179218, XrefRangeEnd = 179232, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void TimeoutPursuit()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCrimeData.NativeMethodInfoPtr_TimeoutPursuit_Private_Void_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060051D7 RID: 20951 RVA: 0x00188BA8 File Offset: 0x00186DA8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 179232, RefRangeEnd = 179235, XrefRangeStart = 179232, XrefRangeEnd = 179232, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float GetSearchTime()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(PlayerCrimeData.NativeMethodInfoPtr_GetSearchTime_Public_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x060051D8 RID: 20952 RVA: 0x00188BE4 File Offset: 0x00186DE4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 179235, RefRangeEnd = 179236, XrefRangeStart = 179235, XrefRangeEnd = 179235, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ResetShotAccuracy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCrimeData.NativeMethodInfoPtr_ResetShotAccuracy_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060051D9 RID: 20953 RVA: 0x00188C18 File Offset: 0x00186E18
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 179276, RefRangeEnd = 179277, XrefRangeStart = 179236, XrefRangeEnd = 179276, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float GetShotAccuracyMultiplier()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(PlayerCrimeData.NativeMethodInfoPtr_GetShotAccuracyMultiplier_Public_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x060051DA RID: 20954 RVA: 0x00188C54 File Offset: 0x00186E54
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 179288, RefRangeEnd = 179289, XrefRangeStart = 179277, XrefRangeEnd = 179288, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RecordVehicleCollision(NPC victim)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(victim);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCrimeData.NativeMethodInfoPtr_RecordVehicleCollision_Public_Void_NPC_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060051DB RID: 20955 RVA: 0x00188C98 File Offset: 0x00186E98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 179289, XrefRangeEnd = 179310, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CheckNearestOfficer()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCrimeData.NativeMethodInfoPtr_CheckNearestOfficer_Private_Void_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060051DC RID: 20956 RVA: 0x00188CCC File Offset: 0x00186ECC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 179310, XrefRangeEnd = 179334, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PlayerCrimeData() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayerCrimeData>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCrimeData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060051DD RID: 20957 RVA: 0x00188D08 File Offset: 0x00186F08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 179334, XrefRangeEnd = 179335, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _Awake_b__53_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCrimeData.NativeMethodInfoPtr__Awake_b__53_0_Private_Void_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060051DE RID: 20958 RVA: 0x00188D3C File Offset: 0x00186F3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 179335, XrefRangeEnd = 179342, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float _CheckNearestOfficer_b__79_0(PoliceOfficer x)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(PlayerCrimeData.NativeMethodInfoPtr__CheckNearestOfficer_b__79_0_Private_Single_PoliceOfficer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x060051DF RID: 20959 RVA: 0x00188D8C File Offset: 0x00186F8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 179342, XrefRangeEnd = 179387, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void NetworkInitialize___Early()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PlayerCrimeData.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060051E0 RID: 20960 RVA: 0x00188DC8 File Offset: 0x00186FC8
		[CallerCount(0)]
		public unsafe virtual void NetworkInitialize__Late()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PlayerCrimeData.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060051E1 RID: 20961 RVA: 0x00188E04 File Offset: 0x00187004
		[CallerCount(0)]
		public unsafe override void NetworkInitializeIfDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PlayerCrimeData.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060051E2 RID: 20962 RVA: 0x00188E40 File Offset: 0x00187040
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 179387, XrefRangeEnd = 179399, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_set_CurrentPursuitLevel_2979171596(PlayerCrimeData.EPursuitLevel value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref value;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCrimeData.NativeMethodInfoPtr_RpcWriter___Server_set_CurrentPursuitLevel_2979171596_Private_Void_EPursuitLevel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060051E3 RID: 20963 RVA: 0x00188E80 File Offset: 0x00187080
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 179406, RefRangeEnd = 179408, XrefRangeStart = 179399, XrefRangeEnd = 179406, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___set_CurrentPursuitLevel_2979171596(PlayerCrimeData.EPursuitLevel value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref value;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCrimeData.NativeMethodInfoPtr_RpcLogic___set_CurrentPursuitLevel_2979171596_Protected_Void_EPursuitLevel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060051E4 RID: 20964 RVA: 0x00188EC0 File Offset: 0x001870C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 179408, XrefRangeEnd = 179413, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_set_CurrentPursuitLevel_2979171596(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref channel;
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCrimeData.NativeMethodInfoPtr_RpcReader___Server_set_CurrentPursuitLevel_2979171596_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060051E5 RID: 20965 RVA: 0x00188F24 File Offset: 0x00187124
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 179427, RefRangeEnd = 179429, XrefRangeStart = 179413, XrefRangeEnd = 179427, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_set_LastKnownPosition_4276783012(Vector3 value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref value;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCrimeData.NativeMethodInfoPtr_RpcWriter___Server_set_LastKnownPosition_4276783012_Private_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060051E6 RID: 20966 RVA: 0x00188F64 File Offset: 0x00187164
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 179436, RefRangeEnd = 179437, XrefRangeStart = 179429, XrefRangeEnd = 179436, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___set_LastKnownPosition_4276783012(Vector3 value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref value;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCrimeData.NativeMethodInfoPtr_RpcLogic___set_LastKnownPosition_4276783012_Protected_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060051E7 RID: 20967 RVA: 0x00188FA4 File Offset: 0x001871A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 179437, XrefRangeEnd = 179444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_set_LastKnownPosition_4276783012(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref channel;
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCrimeData.NativeMethodInfoPtr_RpcReader___Server_set_LastKnownPosition_4276783012_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060051E8 RID: 20968 RVA: 0x00189008 File Offset: 0x00187208
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 179444, XrefRangeEnd = 179454, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_RecordLastKnownPosition_1140765316(bool resetTimeSinceSighted)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref resetTimeSinceSighted;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCrimeData.NativeMethodInfoPtr_RpcWriter___Observers_RecordLastKnownPosition_1140765316_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060051E9 RID: 20969 RVA: 0x00189048 File Offset: 0x00187248
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 179463, RefRangeEnd = 179466, XrefRangeStart = 179454, XrefRangeEnd = 179463, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___RecordLastKnownPosition_1140765316(bool resetTimeSinceSighted)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref resetTimeSinceSighted;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCrimeData.NativeMethodInfoPtr_RpcLogic___RecordLastKnownPosition_1140765316_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060051EA RID: 20970 RVA: 0x00189088 File Offset: 0x00187288
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 179466, XrefRangeEnd = 179469, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_RecordLastKnownPosition_1140765316(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref channel;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCrimeData.NativeMethodInfoPtr_RpcReader___Observers_RecordLastKnownPosition_1140765316_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x17001873 RID: 6259
		// (get) Token: 0x060051EB RID: 20971 RVA: 0x001890D8 File Offset: 0x001872D8
		// (set) Token: 0x060051EC RID: 20972 RVA: 0x00189114 File Offset: 0x00187314
		public unsafe PlayerCrimeData.EPursuitLevel SyncAccessor_<CurrentPursuitLevel>k__BackingField
		{
			[CallerCount(40)]
			[CachedScanResults(RefRangeStart = 63475, RefRangeEnd = 63515, XrefRangeStart = 63475, XrefRangeEnd = 63515, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(PlayerCrimeData.NativeMethodInfoPtr_sync___get_value__CurrentPursuitLevel_k__BackingField_Public_get_EPursuitLevel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 179477, RefRangeEnd = 179478, XrefRangeStart = 179469, XrefRangeEnd = 179477, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = ref value;
				ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref value;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCrimeData.NativeMethodInfoPtr_sync___set_value__CurrentPursuitLevel_k__BackingField_Public_set_Void_EPursuitLevel_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x060051ED RID: 20973 RVA: 0x00189160 File Offset: 0x00187360
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 179478, XrefRangeEnd = 179483, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool ReadSyncVar___ScheduleOne_PlayerScripts_PlayerCrimeData(PooledReader PooledReader0, uint UInt321, bool Boolean2)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref UInt321;
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref Boolean2;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PlayerCrimeData.NativeMethodInfoPtr_ReadSyncVar___ScheduleOne_PlayerScripts_PlayerCrimeData_Public_Virtual_Boolean_PooledReader_UInt32_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x17001874 RID: 6260
		// (get) Token: 0x060051EE RID: 20974 RVA: 0x001891D4 File Offset: 0x001873D4
		// (set) Token: 0x060051EF RID: 20975 RVA: 0x00189210 File Offset: 0x00187410
		public unsafe Vector3 SyncAccessor_<LastKnownPosition>k__BackingField
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 178820, RefRangeEnd = 178834, XrefRangeStart = 178820, XrefRangeEnd = 178834, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(PlayerCrimeData.NativeMethodInfoPtr_sync___get_value__LastKnownPosition_k__BackingField_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 179483, XrefRangeEnd = 179491, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = ref value;
				ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref value;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCrimeData.NativeMethodInfoPtr_sync___set_value__LastKnownPosition_k__BackingField_Public_set_Void_Vector3_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x060051F0 RID: 20976 RVA: 0x0018925C File Offset: 0x0018745C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 179556, RefRangeEnd = 179557, XrefRangeStart = 179491, XrefRangeEnd = 179556, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Method_Private_Void_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCrimeData.NativeMethodInfoPtr_Method_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060051F1 RID: 20977 RVA: 0x00026AE4 File Offset: 0x00024CE4
		public PlayerCrimeData(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001848 RID: 6216
		// (get) Token: 0x060051F2 RID: 20978 RVA: 0x00189290 File Offset: 0x00187490
		// (set) Token: 0x060051F3 RID: 20979 RVA: 0x00026AED File Offset: 0x00024CED
		public unsafe static float SEARCH_TIME_INVESTIGATING
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(PlayerCrimeData.NativeFieldInfoPtr_SEARCH_TIME_INVESTIGATING, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PlayerCrimeData.NativeFieldInfoPtr_SEARCH_TIME_INVESTIGATING, (void*)(&value));
			}
		}

		// Token: 0x17001849 RID: 6217
		// (get) Token: 0x060051F4 RID: 20980 RVA: 0x001892AC File Offset: 0x001874AC
		// (set) Token: 0x060051F5 RID: 20981 RVA: 0x00026AFB File Offset: 0x00024CFB
		public unsafe static float SEARCH_TIME_ARRESTING
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(PlayerCrimeData.NativeFieldInfoPtr_SEARCH_TIME_ARRESTING, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PlayerCrimeData.NativeFieldInfoPtr_SEARCH_TIME_ARRESTING, (void*)(&value));
			}
		}

		// Token: 0x1700184A RID: 6218
		// (get) Token: 0x060051F6 RID: 20982 RVA: 0x001892C8 File Offset: 0x001874C8
		// (set) Token: 0x060051F7 RID: 20983 RVA: 0x00026B09 File Offset: 0x00024D09
		public unsafe static float SEARCH_TIME_NONLETHAL
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(PlayerCrimeData.NativeFieldInfoPtr_SEARCH_TIME_NONLETHAL, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PlayerCrimeData.NativeFieldInfoPtr_SEARCH_TIME_NONLETHAL, (void*)(&value));
			}
		}

		// Token: 0x1700184B RID: 6219
		// (get) Token: 0x060051F8 RID: 20984 RVA: 0x001892E4 File Offset: 0x001874E4
		// (set) Token: 0x060051F9 RID: 20985 RVA: 0x00026B17 File Offset: 0x00024D17
		public unsafe static float SEARCH_TIME_LETHAL
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(PlayerCrimeData.NativeFieldInfoPtr_SEARCH_TIME_LETHAL, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PlayerCrimeData.NativeFieldInfoPtr_SEARCH_TIME_LETHAL, (void*)(&value));
			}
		}

		// Token: 0x1700184C RID: 6220
		// (get) Token: 0x060051FA RID: 20986 RVA: 0x00189300 File Offset: 0x00187500
		// (set) Token: 0x060051FB RID: 20987 RVA: 0x00026B25 File Offset: 0x00024D25
		public unsafe static float ESCALATION_TIME_ARRESTING
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(PlayerCrimeData.NativeFieldInfoPtr_ESCALATION_TIME_ARRESTING, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PlayerCrimeData.NativeFieldInfoPtr_ESCALATION_TIME_ARRESTING, (void*)(&value));
			}
		}

		// Token: 0x1700184D RID: 6221
		// (get) Token: 0x060051FC RID: 20988 RVA: 0x0018931C File Offset: 0x0018751C
		// (set) Token: 0x060051FD RID: 20989 RVA: 0x00026B33 File Offset: 0x00024D33
		public unsafe static float ESCALATION_TIME_NONLETHAL
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(PlayerCrimeData.NativeFieldInfoPtr_ESCALATION_TIME_NONLETHAL, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PlayerCrimeData.NativeFieldInfoPtr_ESCALATION_TIME_NONLETHAL, (void*)(&value));
			}
		}

		// Token: 0x1700184E RID: 6222
		// (get) Token: 0x060051FE RID: 20990 RVA: 0x00189338 File Offset: 0x00187538
		// (set) Token: 0x060051FF RID: 20991 RVA: 0x00026B41 File Offset: 0x00024D41
		public unsafe static float SHOT_COOLDOWN_MIN
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(PlayerCrimeData.NativeFieldInfoPtr_SHOT_COOLDOWN_MIN, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PlayerCrimeData.NativeFieldInfoPtr_SHOT_COOLDOWN_MIN, (void*)(&value));
			}
		}

		// Token: 0x1700184F RID: 6223
		// (get) Token: 0x06005200 RID: 20992 RVA: 0x00189354 File Offset: 0x00187554
		// (set) Token: 0x06005201 RID: 20993 RVA: 0x00026B4F File Offset: 0x00024D4F
		public unsafe static float SHOT_COOLDOWN_MAX
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(PlayerCrimeData.NativeFieldInfoPtr_SHOT_COOLDOWN_MAX, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PlayerCrimeData.NativeFieldInfoPtr_SHOT_COOLDOWN_MAX, (void*)(&value));
			}
		}

		// Token: 0x17001850 RID: 6224
		// (get) Token: 0x06005202 RID: 20994 RVA: 0x00189370 File Offset: 0x00187570
		// (set) Token: 0x06005203 RID: 20995 RVA: 0x00026B5D File Offset: 0x00024D5D
		public unsafe static float VEHICLE_COLLISION_LIFETIME
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(PlayerCrimeData.NativeFieldInfoPtr_VEHICLE_COLLISION_LIFETIME, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PlayerCrimeData.NativeFieldInfoPtr_VEHICLE_COLLISION_LIFETIME, (void*)(&value));
			}
		}

		// Token: 0x17001851 RID: 6225
		// (get) Token: 0x06005204 RID: 20996 RVA: 0x0018938C File Offset: 0x0018758C
		// (set) Token: 0x06005205 RID: 20997 RVA: 0x00026B6B File Offset: 0x00024D6B
		public unsafe static float VEHICLE_COLLISION_LIMIT
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(PlayerCrimeData.NativeFieldInfoPtr_VEHICLE_COLLISION_LIMIT, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PlayerCrimeData.NativeFieldInfoPtr_VEHICLE_COLLISION_LIMIT, (void*)(&value));
			}
		}

		// Token: 0x17001852 RID: 6226
		// (get) Token: 0x06005206 RID: 20998 RVA: 0x001893A8 File Offset: 0x001875A8
		// (set) Token: 0x06005207 RID: 20999 RVA: 0x00026B79 File Offset: 0x00024D79
		public unsafe PoliceOfficer NearestOfficer
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCrimeData.NativeFieldInfoPtr_NearestOfficer);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PoliceOfficer>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCrimeData.NativeFieldInfoPtr_NearestOfficer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001853 RID: 6227
		// (get) Token: 0x06005208 RID: 21000 RVA: 0x001893D8 File Offset: 0x001875D8
		// (set) Token: 0x06005209 RID: 21001 RVA: 0x00026B98 File Offset: 0x00024D98
		public unsafe Player Player
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCrimeData.NativeFieldInfoPtr_Player);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Player>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCrimeData.NativeFieldInfoPtr_Player), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001854 RID: 6228
		// (get) Token: 0x0600520A RID: 21002 RVA: 0x00189408 File Offset: 0x00187608
		// (set) Token: 0x0600520B RID: 21003 RVA: 0x00026BB7 File Offset: 0x00024DB7
		public unsafe AudioSourceController onPursuitEscapedSound
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCrimeData.NativeFieldInfoPtr_onPursuitEscapedSound);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCrimeData.NativeFieldInfoPtr_onPursuitEscapedSound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001855 RID: 6229
		// (get) Token: 0x0600520C RID: 21004 RVA: 0x00189438 File Offset: 0x00187638
		// (set) Token: 0x0600520D RID: 21005 RVA: 0x00026BD6 File Offset: 0x00024DD6
		public unsafe PlayerCrimeData.EPursuitLevel _CurrentPursuitLevel_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCrimeData.NativeFieldInfoPtr__CurrentPursuitLevel_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCrimeData.NativeFieldInfoPtr__CurrentPursuitLevel_k__BackingField)) = value;
			}
		}

		// Token: 0x17001856 RID: 6230
		// (get) Token: 0x0600520E RID: 21006 RVA: 0x00189460 File Offset: 0x00187660
		// (set) Token: 0x0600520F RID: 21007 RVA: 0x00026BF1 File Offset: 0x00024DF1
		public unsafe Vector3 _LastKnownPosition_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCrimeData.NativeFieldInfoPtr__LastKnownPosition_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCrimeData.NativeFieldInfoPtr__LastKnownPosition_k__BackingField)) = value;
			}
		}

		// Token: 0x17001857 RID: 6231
		// (get) Token: 0x06005210 RID: 21008 RVA: 0x00189488 File Offset: 0x00187688
		// (set) Token: 0x06005211 RID: 21009 RVA: 0x00026C0C File Offset: 0x00024E0C
		public unsafe List<PoliceOfficer> Pursuers
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCrimeData.NativeFieldInfoPtr_Pursuers);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<PoliceOfficer>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCrimeData.NativeFieldInfoPtr_Pursuers), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001858 RID: 6232
		// (get) Token: 0x06005212 RID: 21010 RVA: 0x001894B8 File Offset: 0x001876B8
		// (set) Token: 0x06005213 RID: 21011 RVA: 0x00026C2B File Offset: 0x00024E2B
		public unsafe float _CurrentArrestProgress_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCrimeData.NativeFieldInfoPtr__CurrentArrestProgress_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCrimeData.NativeFieldInfoPtr__CurrentArrestProgress_k__BackingField)) = value;
			}
		}

		// Token: 0x17001859 RID: 6233
		// (get) Token: 0x06005214 RID: 21012 RVA: 0x001894E0 File Offset: 0x001876E0
		// (set) Token: 0x06005215 RID: 21013 RVA: 0x00026C46 File Offset: 0x00024E46
		public unsafe float _CurrentBodySearchProgress_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCrimeData.NativeFieldInfoPtr__CurrentBodySearchProgress_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCrimeData.NativeFieldInfoPtr__CurrentBodySearchProgress_k__BackingField)) = value;
			}
		}

		// Token: 0x1700185A RID: 6234
		// (get) Token: 0x06005216 RID: 21014 RVA: 0x00189508 File Offset: 0x00187708
		// (set) Token: 0x06005217 RID: 21015 RVA: 0x00026C61 File Offset: 0x00024E61
		public unsafe float TimeSincePursuitStart
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCrimeData.NativeFieldInfoPtr_TimeSincePursuitStart);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCrimeData.NativeFieldInfoPtr_TimeSincePursuitStart)) = value;
			}
		}

		// Token: 0x1700185B RID: 6235
		// (get) Token: 0x06005218 RID: 21016 RVA: 0x00189530 File Offset: 0x00187730
		// (set) Token: 0x06005219 RID: 21017 RVA: 0x00026C7C File Offset: 0x00024E7C
		public unsafe float CurrentPursuitLevelDuration
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCrimeData.NativeFieldInfoPtr_CurrentPursuitLevelDuration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCrimeData.NativeFieldInfoPtr_CurrentPursuitLevelDuration)) = value;
			}
		}

		// Token: 0x1700185C RID: 6236
		// (get) Token: 0x0600521A RID: 21018 RVA: 0x00189558 File Offset: 0x00187758
		// (set) Token: 0x0600521B RID: 21019 RVA: 0x00026C97 File Offset: 0x00024E97
		public unsafe float TimeSinceSighted
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCrimeData.NativeFieldInfoPtr_TimeSinceSighted);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCrimeData.NativeFieldInfoPtr_TimeSinceSighted)) = value;
			}
		}

		// Token: 0x1700185D RID: 6237
		// (get) Token: 0x0600521C RID: 21020 RVA: 0x00189580 File Offset: 0x00187780
		// (set) Token: 0x0600521D RID: 21021 RVA: 0x00026CB2 File Offset: 0x00024EB2
		public unsafe Dictionary<Crime, int> Crimes
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCrimeData.NativeFieldInfoPtr_Crimes);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<Crime, int>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCrimeData.NativeFieldInfoPtr_Crimes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700185E RID: 6238
		// (get) Token: 0x0600521E RID: 21022 RVA: 0x001895B0 File Offset: 0x001877B0
		// (set) Token: 0x0600521F RID: 21023 RVA: 0x00026CD1 File Offset: 0x00024ED1
		public unsafe bool BodySearchPending
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCrimeData.NativeFieldInfoPtr_BodySearchPending);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCrimeData.NativeFieldInfoPtr_BodySearchPending)) = value;
			}
		}

		// Token: 0x1700185F RID: 6239
		// (get) Token: 0x06005220 RID: 21024 RVA: 0x001895D8 File Offset: 0x001877D8
		// (set) Token: 0x06005221 RID: 21025 RVA: 0x00026CEC File Offset: 0x00024EEC
		public unsafe float _TimeSinceLastBodySearch_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCrimeData.NativeFieldInfoPtr__TimeSinceLastBodySearch_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCrimeData.NativeFieldInfoPtr__TimeSinceLastBodySearch_k__BackingField)) = value;
			}
		}

		// Token: 0x17001860 RID: 6240
		// (get) Token: 0x06005222 RID: 21026 RVA: 0x00189600 File Offset: 0x00187800
		// (set) Token: 0x06005223 RID: 21027 RVA: 0x00026D07 File Offset: 0x00024F07
		public unsafe bool _EvadedArrest_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCrimeData.NativeFieldInfoPtr__EvadedArrest_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCrimeData.NativeFieldInfoPtr__EvadedArrest_k__BackingField)) = value;
			}
		}

		// Token: 0x17001861 RID: 6241
		// (get) Token: 0x06005224 RID: 21028 RVA: 0x00189628 File Offset: 0x00187828
		// (set) Token: 0x06005225 RID: 21029 RVA: 0x00026D22 File Offset: 0x00024F22
		public unsafe float timeSinceLastShot
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCrimeData.NativeFieldInfoPtr_timeSinceLastShot);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCrimeData.NativeFieldInfoPtr_timeSinceLastShot)) = value;
			}
		}

		// Token: 0x17001862 RID: 6242
		// (get) Token: 0x06005226 RID: 21030 RVA: 0x00189650 File Offset: 0x00187850
		// (set) Token: 0x06005227 RID: 21031 RVA: 0x00026D3D File Offset: 0x00024F3D
		public unsafe List<PlayerCrimeData.VehicleCollisionInstance> Collisions
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCrimeData.NativeFieldInfoPtr_Collisions);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<PlayerCrimeData.VehicleCollisionInstance>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCrimeData.NativeFieldInfoPtr_Collisions), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001863 RID: 6243
		// (get) Token: 0x06005228 RID: 21032 RVA: 0x00189680 File Offset: 0x00187880
		// (set) Token: 0x06005229 RID: 21033 RVA: 0x00026D5C File Offset: 0x00024F5C
		public unsafe MusicTrack _lightCombatTrack
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCrimeData.NativeFieldInfoPtr__lightCombatTrack);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MusicTrack>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCrimeData.NativeFieldInfoPtr__lightCombatTrack), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001864 RID: 6244
		// (get) Token: 0x0600522A RID: 21034 RVA: 0x001896B0 File Offset: 0x001878B0
		// (set) Token: 0x0600522B RID: 21035 RVA: 0x00026D7B File Offset: 0x00024F7B
		public unsafe MusicTrack _heavyCombatTrack
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCrimeData.NativeFieldInfoPtr__heavyCombatTrack);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MusicTrack>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCrimeData.NativeFieldInfoPtr__heavyCombatTrack), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001865 RID: 6245
		// (get) Token: 0x0600522C RID: 21036 RVA: 0x001896E0 File Offset: 0x001878E0
		// (set) Token: 0x0600522D RID: 21037 RVA: 0x00026D9A File Offset: 0x00024F9A
		public unsafe float outOfSightTimeToDipMusic
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCrimeData.NativeFieldInfoPtr_outOfSightTimeToDipMusic);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCrimeData.NativeFieldInfoPtr_outOfSightTimeToDipMusic)) = value;
			}
		}

		// Token: 0x17001866 RID: 6246
		// (get) Token: 0x0600522E RID: 21038 RVA: 0x00189708 File Offset: 0x00187908
		// (set) Token: 0x0600522F RID: 21039 RVA: 0x00026DB5 File Offset: 0x00024FB5
		public unsafe float minMusicVolume
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCrimeData.NativeFieldInfoPtr_minMusicVolume);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCrimeData.NativeFieldInfoPtr_minMusicVolume)) = value;
			}
		}

		// Token: 0x17001867 RID: 6247
		// (get) Token: 0x06005230 RID: 21040 RVA: 0x00189730 File Offset: 0x00187930
		// (set) Token: 0x06005231 RID: 21041 RVA: 0x00026DD0 File Offset: 0x00024FD0
		public unsafe float musicChangeRate_Down
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCrimeData.NativeFieldInfoPtr_musicChangeRate_Down);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCrimeData.NativeFieldInfoPtr_musicChangeRate_Down)) = value;
			}
		}

		// Token: 0x17001868 RID: 6248
		// (get) Token: 0x06005232 RID: 21042 RVA: 0x00189758 File Offset: 0x00187958
		// (set) Token: 0x06005233 RID: 21043 RVA: 0x00026DEB File Offset: 0x00024FEB
		public unsafe float musicChangeRate_Up
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCrimeData.NativeFieldInfoPtr_musicChangeRate_Up);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCrimeData.NativeFieldInfoPtr_musicChangeRate_Up)) = value;
			}
		}

		// Token: 0x17001869 RID: 6249
		// (get) Token: 0x06005234 RID: 21044 RVA: 0x00189780 File Offset: 0x00187980
		// (set) Token: 0x06005235 RID: 21045 RVA: 0x00026E06 File Offset: 0x00025006
		public unsafe SyncVar<PlayerCrimeData.EPursuitLevel> syncVar____CurrentPursuitLevel_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCrimeData.NativeFieldInfoPtr_syncVar____CurrentPursuitLevel_k__BackingField);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SyncVar<PlayerCrimeData.EPursuitLevel>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCrimeData.NativeFieldInfoPtr_syncVar____CurrentPursuitLevel_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700186A RID: 6250
		// (get) Token: 0x06005236 RID: 21046 RVA: 0x001897B0 File Offset: 0x001879B0
		// (set) Token: 0x06005237 RID: 21047 RVA: 0x00026E25 File Offset: 0x00025025
		public unsafe SyncVar<Vector3> syncVar____LastKnownPosition_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCrimeData.NativeFieldInfoPtr_syncVar____LastKnownPosition_k__BackingField);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SyncVar<Vector3>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCrimeData.NativeFieldInfoPtr_syncVar____LastKnownPosition_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700186B RID: 6251
		// (get) Token: 0x06005238 RID: 21048 RVA: 0x001897E0 File Offset: 0x001879E0
		// (set) Token: 0x06005239 RID: 21049 RVA: 0x00026E44 File Offset: 0x00025044
		public unsafe bool field_Private_Boolean_0
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCrimeData.NativeFieldInfoPtr_field_Private_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCrimeData.NativeFieldInfoPtr_field_Private_Boolean_0)) = value;
			}
		}

		// Token: 0x1700186C RID: 6252
		// (get) Token: 0x0600523A RID: 21050 RVA: 0x00189808 File Offset: 0x00187A08
		// (set) Token: 0x0600523B RID: 21051 RVA: 0x00026E5F File Offset: 0x0002505F
		public unsafe bool field_Private_Boolean_1
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCrimeData.NativeFieldInfoPtr_field_Private_Boolean_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCrimeData.NativeFieldInfoPtr_field_Private_Boolean_1)) = value;
			}
		}

		// Token: 0x04003769 RID: 14185
		private static readonly System.IntPtr NativeFieldInfoPtr_SEARCH_TIME_INVESTIGATING;

		// Token: 0x0400376A RID: 14186
		private static readonly System.IntPtr NativeFieldInfoPtr_SEARCH_TIME_ARRESTING;

		// Token: 0x0400376B RID: 14187
		private static readonly System.IntPtr NativeFieldInfoPtr_SEARCH_TIME_NONLETHAL;

		// Token: 0x0400376C RID: 14188
		private static readonly System.IntPtr NativeFieldInfoPtr_SEARCH_TIME_LETHAL;

		// Token: 0x0400376D RID: 14189
		private static readonly System.IntPtr NativeFieldInfoPtr_ESCALATION_TIME_ARRESTING;

		// Token: 0x0400376E RID: 14190
		private static readonly System.IntPtr NativeFieldInfoPtr_ESCALATION_TIME_NONLETHAL;

		// Token: 0x0400376F RID: 14191
		private static readonly System.IntPtr NativeFieldInfoPtr_SHOT_COOLDOWN_MIN;

		// Token: 0x04003770 RID: 14192
		private static readonly System.IntPtr NativeFieldInfoPtr_SHOT_COOLDOWN_MAX;

		// Token: 0x04003771 RID: 14193
		private static readonly System.IntPtr NativeFieldInfoPtr_VEHICLE_COLLISION_LIFETIME;

		// Token: 0x04003772 RID: 14194
		private static readonly System.IntPtr NativeFieldInfoPtr_VEHICLE_COLLISION_LIMIT;

		// Token: 0x04003773 RID: 14195
		private static readonly System.IntPtr NativeFieldInfoPtr_NearestOfficer;

		// Token: 0x04003774 RID: 14196
		private static readonly System.IntPtr NativeFieldInfoPtr_Player;

		// Token: 0x04003775 RID: 14197
		private static readonly System.IntPtr NativeFieldInfoPtr_onPursuitEscapedSound;

		// Token: 0x04003776 RID: 14198
		private static readonly System.IntPtr NativeFieldInfoPtr__CurrentPursuitLevel_k__BackingField;

		// Token: 0x04003777 RID: 14199
		private static readonly System.IntPtr NativeFieldInfoPtr__LastKnownPosition_k__BackingField;

		// Token: 0x04003778 RID: 14200
		private static readonly System.IntPtr NativeFieldInfoPtr_Pursuers;

		// Token: 0x04003779 RID: 14201
		private static readonly System.IntPtr NativeFieldInfoPtr__CurrentArrestProgress_k__BackingField;

		// Token: 0x0400377A RID: 14202
		private static readonly System.IntPtr NativeFieldInfoPtr__CurrentBodySearchProgress_k__BackingField;

		// Token: 0x0400377B RID: 14203
		private static readonly System.IntPtr NativeFieldInfoPtr_TimeSincePursuitStart;

		// Token: 0x0400377C RID: 14204
		private static readonly System.IntPtr NativeFieldInfoPtr_CurrentPursuitLevelDuration;

		// Token: 0x0400377D RID: 14205
		private static readonly System.IntPtr NativeFieldInfoPtr_TimeSinceSighted;

		// Token: 0x0400377E RID: 14206
		private static readonly System.IntPtr NativeFieldInfoPtr_Crimes;

		// Token: 0x0400377F RID: 14207
		private static readonly System.IntPtr NativeFieldInfoPtr_BodySearchPending;

		// Token: 0x04003780 RID: 14208
		private static readonly System.IntPtr NativeFieldInfoPtr__TimeSinceLastBodySearch_k__BackingField;

		// Token: 0x04003781 RID: 14209
		private static readonly System.IntPtr NativeFieldInfoPtr__EvadedArrest_k__BackingField;

		// Token: 0x04003782 RID: 14210
		private static readonly System.IntPtr NativeFieldInfoPtr_timeSinceLastShot;

		// Token: 0x04003783 RID: 14211
		private static readonly System.IntPtr NativeFieldInfoPtr_Collisions;

		// Token: 0x04003784 RID: 14212
		private static readonly System.IntPtr NativeFieldInfoPtr__lightCombatTrack;

		// Token: 0x04003785 RID: 14213
		private static readonly System.IntPtr NativeFieldInfoPtr__heavyCombatTrack;

		// Token: 0x04003786 RID: 14214
		private static readonly System.IntPtr NativeFieldInfoPtr_outOfSightTimeToDipMusic;

		// Token: 0x04003787 RID: 14215
		private static readonly System.IntPtr NativeFieldInfoPtr_minMusicVolume;

		// Token: 0x04003788 RID: 14216
		private static readonly System.IntPtr NativeFieldInfoPtr_musicChangeRate_Down;

		// Token: 0x04003789 RID: 14217
		private static readonly System.IntPtr NativeFieldInfoPtr_musicChangeRate_Up;

		// Token: 0x0400378A RID: 14218
		private static readonly System.IntPtr NativeFieldInfoPtr_syncVar____CurrentPursuitLevel_k__BackingField;

		// Token: 0x0400378B RID: 14219
		private static readonly System.IntPtr NativeFieldInfoPtr_syncVar____LastKnownPosition_k__BackingField;

		// Token: 0x0400378C RID: 14220
		private static readonly System.IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

		// Token: 0x0400378D RID: 14221
		private static readonly System.IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

		// Token: 0x0400378E RID: 14222
		private static readonly System.IntPtr NativeMethodInfoPtr_get_CurrentPursuitLevel_Public_get_EPursuitLevel_0;

		// Token: 0x0400378F RID: 14223
		private static readonly System.IntPtr NativeMethodInfoPtr_set_CurrentPursuitLevel_Protected_set_Void_EPursuitLevel_0;

		// Token: 0x04003790 RID: 14224
		private static readonly System.IntPtr NativeMethodInfoPtr_get_LastKnownPosition_Public_get_Vector3_0;

		// Token: 0x04003791 RID: 14225
		private static readonly System.IntPtr NativeMethodInfoPtr_set_LastKnownPosition_Protected_set_Void_Vector3_0;

		// Token: 0x04003792 RID: 14226
		private static readonly System.IntPtr NativeMethodInfoPtr_get_CurrentArrestProgress_Public_get_Single_0;

		// Token: 0x04003793 RID: 14227
		private static readonly System.IntPtr NativeMethodInfoPtr_set_CurrentArrestProgress_Protected_set_Void_Single_0;

		// Token: 0x04003794 RID: 14228
		private static readonly System.IntPtr NativeMethodInfoPtr_get_CurrentBodySearchProgress_Public_get_Single_0;

		// Token: 0x04003795 RID: 14229
		private static readonly System.IntPtr NativeMethodInfoPtr_set_CurrentBodySearchProgress_Protected_set_Void_Single_0;

		// Token: 0x04003796 RID: 14230
		private static readonly System.IntPtr NativeMethodInfoPtr_get_TimeSinceLastBodySearch_Public_get_Single_0;

		// Token: 0x04003797 RID: 14231
		private static readonly System.IntPtr NativeMethodInfoPtr_set_TimeSinceLastBodySearch_Public_set_Void_Single_0;

		// Token: 0x04003798 RID: 14232
		private static readonly System.IntPtr NativeMethodInfoPtr_get_EvadedArrest_Public_get_Boolean_0;

		// Token: 0x04003799 RID: 14233
		private static readonly System.IntPtr NativeMethodInfoPtr_set_EvadedArrest_Protected_set_Void_Boolean_0;

		// Token: 0x0400379A RID: 14234
		private static readonly System.IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;

		// Token: 0x0400379B RID: 14235
		private static readonly System.IntPtr NativeMethodInfoPtr_Start_Private_Void_1;

		// Token: 0x0400379C RID: 14236
		private static readonly System.IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_1;

		// Token: 0x0400379D RID: 14237
		private static readonly System.IntPtr NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0;

		// Token: 0x0400379E RID: 14238
		private static readonly System.IntPtr NativeMethodInfoPtr_LateUpdate_Protected_Virtual_New_Void_0;

		// Token: 0x0400379F RID: 14239
		private static readonly System.IntPtr NativeMethodInfoPtr_SetPursuitLevel_Public_Void_EPursuitLevel_0;

		// Token: 0x040037A0 RID: 14240
		private static readonly System.IntPtr NativeMethodInfoPtr_Escalate_Public_Void_0;

		// Token: 0x040037A1 RID: 14241
		private static readonly System.IntPtr NativeMethodInfoPtr_Deescalate_Public_Void_0;

		// Token: 0x040037A2 RID: 14242
		private static readonly System.IntPtr NativeMethodInfoPtr_RecordLastKnownPosition_Public_Void_Boolean_0;

		// Token: 0x040037A3 RID: 14243
		private static readonly System.IntPtr NativeMethodInfoPtr_SetArrestProgress_Public_Void_Single_0;

		// Token: 0x040037A4 RID: 14244
		private static readonly System.IntPtr NativeMethodInfoPtr_ResetBodysearchCooldown_Public_Void_0;

		// Token: 0x040037A5 RID: 14245
		private static readonly System.IntPtr NativeMethodInfoPtr_SetBodySearchProgress_Public_Void_Single_0;

		// Token: 0x040037A6 RID: 14246
		private static readonly System.IntPtr NativeMethodInfoPtr_OnDie_Private_Void_1;

		// Token: 0x040037A7 RID: 14247
		private static readonly System.IntPtr NativeMethodInfoPtr_AddCrime_Public_Void_Crime_Int32_0;

		// Token: 0x040037A8 RID: 14248
		private static readonly System.IntPtr NativeMethodInfoPtr_ClearCrimes_Public_Void_0;

		// Token: 0x040037A9 RID: 14249
		private static readonly System.IntPtr NativeMethodInfoPtr_IsCrimeOnRecord_Public_Boolean_Type_0;

		// Token: 0x040037AA RID: 14250
		private static readonly System.IntPtr NativeMethodInfoPtr_SetEvaded_Public_Void_0;

		// Token: 0x040037AB RID: 14251
		private static readonly System.IntPtr NativeMethodInfoPtr_OnSleepStart_Private_Void_1;

		// Token: 0x040037AC RID: 14252
		private static readonly System.IntPtr NativeMethodInfoPtr_UpdateEscalation_Private_Void_1;

		// Token: 0x040037AD RID: 14253
		private static readonly System.IntPtr NativeMethodInfoPtr_UpdateTimeout_Private_Void_1;

		// Token: 0x040037AE RID: 14254
		private static readonly System.IntPtr NativeMethodInfoPtr_UpdateMusic_Private_Void_1;

		// Token: 0x040037AF RID: 14255
		private static readonly System.IntPtr NativeMethodInfoPtr_TimeoutPursuit_Private_Void_1;

		// Token: 0x040037B0 RID: 14256
		private static readonly System.IntPtr NativeMethodInfoPtr_GetSearchTime_Public_Single_0;

		// Token: 0x040037B1 RID: 14257
		private static readonly System.IntPtr NativeMethodInfoPtr_ResetShotAccuracy_Public_Void_0;

		// Token: 0x040037B2 RID: 14258
		private static readonly System.IntPtr NativeMethodInfoPtr_GetShotAccuracyMultiplier_Public_Single_0;

		// Token: 0x040037B3 RID: 14259
		private static readonly System.IntPtr NativeMethodInfoPtr_RecordVehicleCollision_Public_Void_NPC_0;

		// Token: 0x040037B4 RID: 14260
		private static readonly System.IntPtr NativeMethodInfoPtr_CheckNearestOfficer_Private_Void_1;

		// Token: 0x040037B5 RID: 14261
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040037B6 RID: 14262
		private static readonly System.IntPtr NativeMethodInfoPtr__Awake_b__53_0_Private_Void_1;

		// Token: 0x040037B7 RID: 14263
		private static readonly System.IntPtr NativeMethodInfoPtr__CheckNearestOfficer_b__79_0_Private_Single_PoliceOfficer_0;

		// Token: 0x040037B8 RID: 14264
		private static readonly System.IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

		// Token: 0x040037B9 RID: 14265
		private static readonly System.IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

		// Token: 0x040037BA RID: 14266
		private static readonly System.IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

		// Token: 0x040037BB RID: 14267
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcWriter___Server_set_CurrentPursuitLevel_2979171596_Private_Void_EPursuitLevel_0;

		// Token: 0x040037BC RID: 14268
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcLogic___set_CurrentPursuitLevel_2979171596_Protected_Void_EPursuitLevel_0;

		// Token: 0x040037BD RID: 14269
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcReader___Server_set_CurrentPursuitLevel_2979171596_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x040037BE RID: 14270
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcWriter___Server_set_LastKnownPosition_4276783012_Private_Void_Vector3_0;

		// Token: 0x040037BF RID: 14271
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcLogic___set_LastKnownPosition_4276783012_Protected_Void_Vector3_0;

		// Token: 0x040037C0 RID: 14272
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcReader___Server_set_LastKnownPosition_4276783012_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x040037C1 RID: 14273
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcWriter___Observers_RecordLastKnownPosition_1140765316_Private_Void_Boolean_0;

		// Token: 0x040037C2 RID: 14274
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcLogic___RecordLastKnownPosition_1140765316_Public_Void_Boolean_0;

		// Token: 0x040037C3 RID: 14275
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcReader___Observers_RecordLastKnownPosition_1140765316_Private_Void_PooledReader_Channel_0;

		// Token: 0x040037C4 RID: 14276
		private static readonly System.IntPtr NativeMethodInfoPtr_sync___get_value__CurrentPursuitLevel_k__BackingField_Public_get_EPursuitLevel_0;

		// Token: 0x040037C5 RID: 14277
		private static readonly System.IntPtr NativeMethodInfoPtr_sync___set_value__CurrentPursuitLevel_k__BackingField_Public_set_Void_EPursuitLevel_Boolean_0;

		// Token: 0x040037C6 RID: 14278
		private static readonly System.IntPtr NativeMethodInfoPtr_ReadSyncVar___ScheduleOne_PlayerScripts_PlayerCrimeData_Public_Virtual_Boolean_PooledReader_UInt32_Boolean_0;

		// Token: 0x040037C7 RID: 14279
		private static readonly System.IntPtr NativeMethodInfoPtr_sync___get_value__LastKnownPosition_k__BackingField_Public_get_Vector3_0;

		// Token: 0x040037C8 RID: 14280
		private static readonly System.IntPtr NativeMethodInfoPtr_sync___set_value__LastKnownPosition_k__BackingField_Public_set_Void_Vector3_Boolean_0;

		// Token: 0x040037C9 RID: 14281
		private static readonly System.IntPtr NativeMethodInfoPtr_Method_Private_Void_0;

		// Token: 0x020009E9 RID: 2537
		public class VehicleCollisionInstance : Il2CppSystem.Object
		{
			// Token: 0x0600D038 RID: 53304 RVA: 0x00326B64 File Offset: 0x00324D64
			// Note: this type is marked as 'beforefieldinit'.
			static VehicleCollisionInstance()
			{
				Il2CppClassPointerStore<PlayerCrimeData.VehicleCollisionInstance>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PlayerCrimeData>.NativeClassPtr, "VehicleCollisionInstance");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayerCrimeData.VehicleCollisionInstance>.NativeClassPtr);
				PlayerCrimeData.VehicleCollisionInstance.NativeFieldInfoPtr_Victim = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCrimeData.VehicleCollisionInstance>.NativeClassPtr, "Victim");
				PlayerCrimeData.VehicleCollisionInstance.NativeFieldInfoPtr_TimeSince = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCrimeData.VehicleCollisionInstance>.NativeClassPtr, "TimeSince");
				PlayerCrimeData.VehicleCollisionInstance.NativeMethodInfoPtr__ctor_Public_Void_NPC_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCrimeData.VehicleCollisionInstance>.NativeClassPtr, 100673697);
			}

			// Token: 0x0600D039 RID: 53305 RVA: 0x00326BCC File Offset: 0x00324DCC
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 72740, RefRangeEnd = 72741, XrefRangeStart = 72740, XrefRangeEnd = 72741, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe VehicleCollisionInstance(NPC victim, float timeSince) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayerCrimeData.VehicleCollisionInstance>.NativeClassPtr))
			{
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(victim);
				ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref timeSince;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCrimeData.VehicleCollisionInstance.NativeMethodInfoPtr__ctor_Public_Void_NPC_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600D03A RID: 53306 RVA: 0x00064F36 File Offset: 0x00063136
			public VehicleCollisionInstance(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700408F RID: 16527
			// (get) Token: 0x0600D03B RID: 53307 RVA: 0x00326C28 File Offset: 0x00324E28
			// (set) Token: 0x0600D03C RID: 53308 RVA: 0x00064F3F File Offset: 0x0006313F
			public unsafe NPC Victim
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCrimeData.VehicleCollisionInstance.NativeFieldInfoPtr_Victim);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<NPC>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCrimeData.VehicleCollisionInstance.NativeFieldInfoPtr_Victim), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004090 RID: 16528
			// (get) Token: 0x0600D03D RID: 53309 RVA: 0x00326C58 File Offset: 0x00324E58
			// (set) Token: 0x0600D03E RID: 53310 RVA: 0x00064F5E File Offset: 0x0006315E
			public unsafe float TimeSince
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCrimeData.VehicleCollisionInstance.NativeFieldInfoPtr_TimeSince);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCrimeData.VehicleCollisionInstance.NativeFieldInfoPtr_TimeSince)) = value;
				}
			}

			// Token: 0x04008CD4 RID: 36052
			private static readonly System.IntPtr NativeFieldInfoPtr_Victim;

			// Token: 0x04008CD5 RID: 36053
			private static readonly System.IntPtr NativeFieldInfoPtr_TimeSince;

			// Token: 0x04008CD6 RID: 36054
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_NPC_Single_0;
		}

		// Token: 0x020009EA RID: 2538
		[OriginalName("Assembly-CSharp.dll", "", "EPursuitLevel")]
		public enum EPursuitLevel
		{
			// Token: 0x04008CD8 RID: 36056
			None,
			// Token: 0x04008CD9 RID: 36057
			Investigating,
			// Token: 0x04008CDA RID: 36058
			Arresting,
			// Token: 0x04008CDB RID: 36059
			NonLethal,
			// Token: 0x04008CDC RID: 36060
			Lethal
		}

		// Token: 0x020009EB RID: 2539
		[ObfuscatedName("ScheduleOne.PlayerScripts.PlayerCrimeData+<>c")]
		[System.Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x0600D03F RID: 53311 RVA: 0x00326C80 File Offset: 0x00324E80
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<PlayerCrimeData.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PlayerCrimeData>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayerCrimeData.__c>.NativeClassPtr);
				PlayerCrimeData.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCrimeData.__c>.NativeClassPtr, "<>9");
				PlayerCrimeData.__c.NativeFieldInfoPtr___9__53_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCrimeData.__c>.NativeClassPtr, "<>9__53_1");
				PlayerCrimeData.__c.NativeFieldInfoPtr___9__53_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCrimeData.__c>.NativeClassPtr, "<>9__53_2");
				PlayerCrimeData.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCrimeData.__c>.NativeClassPtr, 100673699);
				PlayerCrimeData.__c.NativeMethodInfoPtr__Awake_b__53_1_Internal_Boolean_MusicTrack_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCrimeData.__c>.NativeClassPtr, 100673700);
				PlayerCrimeData.__c.NativeMethodInfoPtr__Awake_b__53_2_Internal_Boolean_MusicTrack_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCrimeData.__c>.NativeClassPtr, 100673701);
			}

			// Token: 0x0600D040 RID: 53312 RVA: 0x00326D24 File Offset: 0x00324F24
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayerCrimeData.__c>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCrimeData.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600D041 RID: 53313 RVA: 0x00326D60 File Offset: 0x00324F60
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 178778, XrefRangeEnd = 178782, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _Awake_b__53_1(MusicTrack t)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(PlayerCrimeData.__c.NativeMethodInfoPtr__Awake_b__53_1_Internal_Boolean_MusicTrack_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x0600D042 RID: 53314 RVA: 0x00326DB0 File Offset: 0x00324FB0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 178782, XrefRangeEnd = 178786, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _Awake_b__53_2(MusicTrack t)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(PlayerCrimeData.__c.NativeMethodInfoPtr__Awake_b__53_2_Internal_Boolean_MusicTrack_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x0600D043 RID: 53315 RVA: 0x00064F79 File Offset: 0x00063179
			public __c(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004091 RID: 16529
			// (get) Token: 0x0600D044 RID: 53316 RVA: 0x00326E00 File Offset: 0x00325000
			// (set) Token: 0x0600D045 RID: 53317 RVA: 0x00064F82 File Offset: 0x00063182
			public unsafe static PlayerCrimeData.__c __9
			{
				get
				{
					System.IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(PlayerCrimeData.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlayerCrimeData.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(PlayerCrimeData.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004092 RID: 16530
			// (get) Token: 0x0600D046 RID: 53318 RVA: 0x00326E28 File Offset: 0x00325028
			// (set) Token: 0x0600D047 RID: 53319 RVA: 0x00064F94 File Offset: 0x00063194
			public unsafe static Il2CppSystem.Predicate<MusicTrack> __9__53_1
			{
				get
				{
					System.IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(PlayerCrimeData.__c.NativeFieldInfoPtr___9__53_1, (void*)(&intPtr));
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Predicate<MusicTrack>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(PlayerCrimeData.__c.NativeFieldInfoPtr___9__53_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004093 RID: 16531
			// (get) Token: 0x0600D048 RID: 53320 RVA: 0x00326E50 File Offset: 0x00325050
			// (set) Token: 0x0600D049 RID: 53321 RVA: 0x00064FA6 File Offset: 0x000631A6
			public unsafe static Il2CppSystem.Predicate<MusicTrack> __9__53_2
			{
				get
				{
					System.IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(PlayerCrimeData.__c.NativeFieldInfoPtr___9__53_2, (void*)(&intPtr));
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Predicate<MusicTrack>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(PlayerCrimeData.__c.NativeFieldInfoPtr___9__53_2, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008CDD RID: 36061
			private static readonly System.IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04008CDE RID: 36062
			private static readonly System.IntPtr NativeFieldInfoPtr___9__53_1;

			// Token: 0x04008CDF RID: 36063
			private static readonly System.IntPtr NativeFieldInfoPtr___9__53_2;

			// Token: 0x04008CE0 RID: 36064
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008CE1 RID: 36065
			private static readonly System.IntPtr NativeMethodInfoPtr__Awake_b__53_1_Internal_Boolean_MusicTrack_0;

			// Token: 0x04008CE2 RID: 36066
			private static readonly System.IntPtr NativeMethodInfoPtr__Awake_b__53_2_Internal_Boolean_MusicTrack_0;
		}
	}
}
