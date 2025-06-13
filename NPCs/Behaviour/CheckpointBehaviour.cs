using System;
using Il2CppFishNet.Connection;
using Il2CppFishNet.Object;
using Il2CppFishNet.Serializing;
using Il2CppFishNet.Transporting;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Dialogue;
using Il2CppScheduleOne.ItemFramework;
using Il2CppScheduleOne.Law;
using Il2CppScheduleOne.PlayerScripts;
using Il2CppScheduleOne.Police;
using Il2CppScheduleOne.Vehicles;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppScheduleOne.NPCs.Behaviour
{
	// Token: 0x02000364 RID: 868
	public class CheckpointBehaviour : Behaviour
	{
		// Token: 0x06003F91 RID: 16273 RVA: 0x001434D0 File Offset: 0x001416D0
		// Note: this type is marked as 'beforefieldinit'.
		static CheckpointBehaviour()
		{
			Il2CppClassPointerStore<CheckpointBehaviour>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.NPCs.Behaviour", "CheckpointBehaviour");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CheckpointBehaviour>.NativeClassPtr);
			CheckpointBehaviour.NativeFieldInfoPtr_LOOK_TIME = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CheckpointBehaviour>.NativeClassPtr, "LOOK_TIME");
			CheckpointBehaviour.NativeFieldInfoPtr__AssignedCheckpoint_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CheckpointBehaviour>.NativeClassPtr, "<AssignedCheckpoint>k__BackingField");
			CheckpointBehaviour.NativeFieldInfoPtr__Checkpoint_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CheckpointBehaviour>.NativeClassPtr, "<Checkpoint>k__BackingField");
			CheckpointBehaviour.NativeFieldInfoPtr__IsSearching_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CheckpointBehaviour>.NativeClassPtr, "<IsSearching>k__BackingField");
			CheckpointBehaviour.NativeFieldInfoPtr__CurrentSearchedVehicle_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CheckpointBehaviour>.NativeClassPtr, "<CurrentSearchedVehicle>k__BackingField");
			CheckpointBehaviour.NativeFieldInfoPtr__Initiator_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CheckpointBehaviour>.NativeClassPtr, "<Initiator>k__BackingField");
			CheckpointBehaviour.NativeFieldInfoPtr_currentLookTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CheckpointBehaviour>.NativeClassPtr, "currentLookTime");
			CheckpointBehaviour.NativeFieldInfoPtr_trunkOpened = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CheckpointBehaviour>.NativeClassPtr, "trunkOpened");
			CheckpointBehaviour.NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CheckpointBehaviour>.NativeClassPtr, "NetworkInitialize___EarlyScheduleOne.NPCs.Behaviour.CheckpointBehaviourAssembly-CSharp.dll_Excuted");
			CheckpointBehaviour.NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CheckpointBehaviour>.NativeClassPtr, "NetworkInitialize__LateScheduleOne.NPCs.Behaviour.CheckpointBehaviourAssembly-CSharp.dll_Excuted");
			CheckpointBehaviour.NativeMethodInfoPtr_get_AssignedCheckpoint_Public_get_ECheckpointLocation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CheckpointBehaviour>.NativeClassPtr, 100670823);
			CheckpointBehaviour.NativeMethodInfoPtr_set_AssignedCheckpoint_Protected_set_Void_ECheckpointLocation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CheckpointBehaviour>.NativeClassPtr, 100670824);
			CheckpointBehaviour.NativeMethodInfoPtr_get_Checkpoint_Public_get_RoadCheckpoint_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CheckpointBehaviour>.NativeClassPtr, 100670825);
			CheckpointBehaviour.NativeMethodInfoPtr_set_Checkpoint_Protected_set_Void_RoadCheckpoint_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CheckpointBehaviour>.NativeClassPtr, 100670826);
			CheckpointBehaviour.NativeMethodInfoPtr_get_IsSearching_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CheckpointBehaviour>.NativeClassPtr, 100670827);
			CheckpointBehaviour.NativeMethodInfoPtr_set_IsSearching_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CheckpointBehaviour>.NativeClassPtr, 100670828);
			CheckpointBehaviour.NativeMethodInfoPtr_get_CurrentSearchedVehicle_Public_get_LandVehicle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CheckpointBehaviour>.NativeClassPtr, 100670829);
			CheckpointBehaviour.NativeMethodInfoPtr_set_CurrentSearchedVehicle_Protected_set_Void_LandVehicle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CheckpointBehaviour>.NativeClassPtr, 100670830);
			CheckpointBehaviour.NativeMethodInfoPtr_get_Initiator_Public_get_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CheckpointBehaviour>.NativeClassPtr, 100670831);
			CheckpointBehaviour.NativeMethodInfoPtr_set_Initiator_Protected_set_Void_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CheckpointBehaviour>.NativeClassPtr, 100670832);
			CheckpointBehaviour.NativeMethodInfoPtr_get_standPoint_Private_get_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CheckpointBehaviour>.NativeClassPtr, 100670833);
			CheckpointBehaviour.NativeMethodInfoPtr_get_dialogueDatabase_Private_get_DialogueDatabase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CheckpointBehaviour>.NativeClassPtr, 100670834);
			CheckpointBehaviour.NativeMethodInfoPtr_Begin_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CheckpointBehaviour>.NativeClassPtr, 100670835);
			CheckpointBehaviour.NativeMethodInfoPtr_Resume_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CheckpointBehaviour>.NativeClassPtr, 100670836);
			CheckpointBehaviour.NativeMethodInfoPtr_End_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CheckpointBehaviour>.NativeClassPtr, 100670837);
			CheckpointBehaviour.NativeMethodInfoPtr_Pause_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CheckpointBehaviour>.NativeClassPtr, 100670838);
			CheckpointBehaviour.NativeMethodInfoPtr_ActiveMinPass_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CheckpointBehaviour>.NativeClassPtr, 100670839);
			CheckpointBehaviour.NativeMethodInfoPtr_SetCheckpoint_Public_Void_ECheckpointLocation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CheckpointBehaviour>.NativeClassPtr, 100670840);
			CheckpointBehaviour.NativeMethodInfoPtr_SetInitiator_Public_Void_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CheckpointBehaviour>.NativeClassPtr, 100670841);
			CheckpointBehaviour.NativeMethodInfoPtr_StartSearch_Public_Void_NetworkObject_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CheckpointBehaviour>.NativeClassPtr, 100670842);
			CheckpointBehaviour.NativeMethodInfoPtr_StopSearch_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CheckpointBehaviour>.NativeClassPtr, 100670843);
			CheckpointBehaviour.NativeMethodInfoPtr_SetIsSearching_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CheckpointBehaviour>.NativeClassPtr, 100670844);
			CheckpointBehaviour.NativeMethodInfoPtr_GetSearchPoint_Private_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CheckpointBehaviour>.NativeClassPtr, 100670845);
			CheckpointBehaviour.NativeMethodInfoPtr_ConcludeSearch_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CheckpointBehaviour>.NativeClassPtr, 100670846);
			CheckpointBehaviour.NativeMethodInfoPtr_DoesVehicleContainIllicitItems_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CheckpointBehaviour>.NativeClassPtr, 100670847);
			CheckpointBehaviour.NativeMethodInfoPtr_PlayerWalkedThroughCheckPoint_Private_Void_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CheckpointBehaviour>.NativeClassPtr, 100670848);
			CheckpointBehaviour.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CheckpointBehaviour>.NativeClassPtr, 100670849);
			CheckpointBehaviour.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CheckpointBehaviour>.NativeClassPtr, 100670850);
			CheckpointBehaviour.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CheckpointBehaviour>.NativeClassPtr, 100670851);
			CheckpointBehaviour.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CheckpointBehaviour>.NativeClassPtr, 100670852);
			CheckpointBehaviour.NativeMethodInfoPtr_RpcWriter___Observers_SetCheckpoint_4087078542_Private_Void_ECheckpointLocation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CheckpointBehaviour>.NativeClassPtr, 100670853);
			CheckpointBehaviour.NativeMethodInfoPtr_RpcLogic___SetCheckpoint_4087078542_Public_Void_ECheckpointLocation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CheckpointBehaviour>.NativeClassPtr, 100670854);
			CheckpointBehaviour.NativeMethodInfoPtr_RpcReader___Observers_SetCheckpoint_4087078542_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CheckpointBehaviour>.NativeClassPtr, 100670855);
			CheckpointBehaviour.NativeMethodInfoPtr_RpcWriter___Observers_SetInitiator_3323014238_Private_Void_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CheckpointBehaviour>.NativeClassPtr, 100670856);
			CheckpointBehaviour.NativeMethodInfoPtr_RpcLogic___SetInitiator_3323014238_Public_Void_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CheckpointBehaviour>.NativeClassPtr, 100670857);
			CheckpointBehaviour.NativeMethodInfoPtr_RpcReader___Observers_SetInitiator_3323014238_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CheckpointBehaviour>.NativeClassPtr, 100670858);
			CheckpointBehaviour.NativeMethodInfoPtr_RpcWriter___Server_StartSearch_3694055493_Private_Void_NetworkObject_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CheckpointBehaviour>.NativeClassPtr, 100670859);
			CheckpointBehaviour.NativeMethodInfoPtr_RpcLogic___StartSearch_3694055493_Public_Void_NetworkObject_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CheckpointBehaviour>.NativeClassPtr, 100670860);
			CheckpointBehaviour.NativeMethodInfoPtr_RpcReader___Server_StartSearch_3694055493_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CheckpointBehaviour>.NativeClassPtr, 100670861);
			CheckpointBehaviour.NativeMethodInfoPtr_RpcWriter___Server_StopSearch_2166136261_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CheckpointBehaviour>.NativeClassPtr, 100670862);
			CheckpointBehaviour.NativeMethodInfoPtr_RpcLogic___StopSearch_2166136261_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CheckpointBehaviour>.NativeClassPtr, 100670863);
			CheckpointBehaviour.NativeMethodInfoPtr_RpcReader___Server_StopSearch_2166136261_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CheckpointBehaviour>.NativeClassPtr, 100670864);
			CheckpointBehaviour.NativeMethodInfoPtr_RpcWriter___Observers_SetIsSearching_1140765316_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CheckpointBehaviour>.NativeClassPtr, 100670865);
			CheckpointBehaviour.NativeMethodInfoPtr_RpcLogic___SetIsSearching_1140765316_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CheckpointBehaviour>.NativeClassPtr, 100670866);
			CheckpointBehaviour.NativeMethodInfoPtr_RpcReader___Observers_SetIsSearching_1140765316_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CheckpointBehaviour>.NativeClassPtr, 100670867);
			CheckpointBehaviour.NativeMethodInfoPtr_RpcWriter___Observers_ConcludeSearch_2166136261_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CheckpointBehaviour>.NativeClassPtr, 100670868);
			CheckpointBehaviour.NativeMethodInfoPtr_RpcLogic___ConcludeSearch_2166136261_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CheckpointBehaviour>.NativeClassPtr, 100670869);
			CheckpointBehaviour.NativeMethodInfoPtr_RpcReader___Observers_ConcludeSearch_2166136261_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CheckpointBehaviour>.NativeClassPtr, 100670870);
			CheckpointBehaviour.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CheckpointBehaviour>.NativeClassPtr, 100670871);
		}

		// Token: 0x17001387 RID: 4999
		// (get) Token: 0x06003F92 RID: 16274 RVA: 0x0014399C File Offset: 0x00141B9C
		// (set) Token: 0x06003F93 RID: 16275 RVA: 0x001439D8 File Offset: 0x00141BD8
		public unsafe CheckpointManager.ECheckpointLocation AssignedCheckpoint
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(CheckpointBehaviour.NativeMethodInfoPtr_get_AssignedCheckpoint_Public_get_ECheckpointLocation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
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
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CheckpointBehaviour.NativeMethodInfoPtr_set_AssignedCheckpoint_Protected_set_Void_ECheckpointLocation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x17001388 RID: 5000
		// (get) Token: 0x06003F94 RID: 16276 RVA: 0x00143A18 File Offset: 0x00141C18
		// (set) Token: 0x06003F95 RID: 16277 RVA: 0x00143A58 File Offset: 0x00141C58
		public unsafe RoadCheckpoint Checkpoint
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CheckpointBehaviour.NativeMethodInfoPtr_get_Checkpoint_Public_get_RoadCheckpoint_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RoadCheckpoint>(intPtr2) : null;
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 118585, RefRangeEnd = 118586, XrefRangeStart = 118585, XrefRangeEnd = 118586, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CheckpointBehaviour.NativeMethodInfoPtr_set_Checkpoint_Protected_set_Void_RoadCheckpoint_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x17001389 RID: 5001
		// (get) Token: 0x06003F96 RID: 16278 RVA: 0x00143A9C File Offset: 0x00141C9C
		// (set) Token: 0x06003F97 RID: 16279 RVA: 0x00143AD8 File Offset: 0x00141CD8
		public unsafe bool IsSearching
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(CheckpointBehaviour.NativeMethodInfoPtr_get_IsSearching_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
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
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CheckpointBehaviour.NativeMethodInfoPtr_set_IsSearching_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x1700138A RID: 5002
		// (get) Token: 0x06003F98 RID: 16280 RVA: 0x00143B18 File Offset: 0x00141D18
		// (set) Token: 0x06003F99 RID: 16281 RVA: 0x00143B58 File Offset: 0x00141D58
		public unsafe LandVehicle CurrentSearchedVehicle
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CheckpointBehaviour.NativeMethodInfoPtr_get_CurrentSearchedVehicle_Public_get_LandVehicle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LandVehicle>(intPtr2) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 150940, XrefRangeEnd = 150941, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CheckpointBehaviour.NativeMethodInfoPtr_set_CurrentSearchedVehicle_Protected_set_Void_LandVehicle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x1700138B RID: 5003
		// (get) Token: 0x06003F9A RID: 16282 RVA: 0x00143B9C File Offset: 0x00141D9C
		// (set) Token: 0x06003F9B RID: 16283 RVA: 0x00143BDC File Offset: 0x00141DDC
		public unsafe Player Initiator
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CheckpointBehaviour.NativeMethodInfoPtr_get_Initiator_Public_get_Player_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Player>(intPtr2) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 150941, XrefRangeEnd = 150942, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CheckpointBehaviour.NativeMethodInfoPtr_set_Initiator_Protected_set_Void_Player_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x1700138C RID: 5004
		// (get) Token: 0x06003F9C RID: 16284 RVA: 0x00143C20 File Offset: 0x00141E20
		public unsafe Transform standPoint
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 150946, RefRangeEnd = 150949, XrefRangeStart = 150942, XrefRangeEnd = 150946, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CheckpointBehaviour.NativeMethodInfoPtr_get_standPoint_Private_get_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
		}

		// Token: 0x1700138D RID: 5005
		// (get) Token: 0x06003F9D RID: 16285 RVA: 0x00143C60 File Offset: 0x00141E60
		public unsafe DialogueDatabase dialogueDatabase
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CheckpointBehaviour.NativeMethodInfoPtr_get_dialogueDatabase_Private_get_DialogueDatabase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DialogueDatabase>(intPtr2) : null;
			}
		}

		// Token: 0x06003F9E RID: 16286 RVA: 0x00143CA0 File Offset: 0x00141EA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 150949, XrefRangeEnd = 150972, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Begin()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CheckpointBehaviour.NativeMethodInfoPtr_Begin_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06003F9F RID: 16287 RVA: 0x00143CDC File Offset: 0x00141EDC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 150972, XrefRangeEnd = 150995, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Resume()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CheckpointBehaviour.NativeMethodInfoPtr_Resume_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06003FA0 RID: 16288 RVA: 0x00143D18 File Offset: 0x00141F18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 150995, XrefRangeEnd = 151017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void End()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CheckpointBehaviour.NativeMethodInfoPtr_End_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06003FA1 RID: 16289 RVA: 0x00143D54 File Offset: 0x00141F54
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 151017, XrefRangeEnd = 151039, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Pause()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CheckpointBehaviour.NativeMethodInfoPtr_Pause_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06003FA2 RID: 16290 RVA: 0x00143D90 File Offset: 0x00141F90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 151039, XrefRangeEnd = 151108, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ActiveMinPass()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CheckpointBehaviour.NativeMethodInfoPtr_ActiveMinPass_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06003FA3 RID: 16291 RVA: 0x00143DCC File Offset: 0x00141FCC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 151128, RefRangeEnd = 151129, XrefRangeStart = 151108, XrefRangeEnd = 151128, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetCheckpoint(CheckpointManager.ECheckpointLocation loc)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref loc;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CheckpointBehaviour.NativeMethodInfoPtr_SetCheckpoint_Public_Void_ECheckpointLocation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06003FA4 RID: 16292 RVA: 0x00143E0C File Offset: 0x0014200C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 151129, XrefRangeEnd = 151154, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetInitiator(NetworkObject init)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(init);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CheckpointBehaviour.NativeMethodInfoPtr_SetInitiator_Public_Void_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06003FA5 RID: 16293 RVA: 0x00143E50 File Offset: 0x00142050
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 151177, RefRangeEnd = 151178, XrefRangeStart = 151154, XrefRangeEnd = 151177, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StartSearch(NetworkObject targetVehicle, NetworkObject initiator)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(targetVehicle);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(initiator);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CheckpointBehaviour.NativeMethodInfoPtr_StartSearch_Public_Void_NetworkObject_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06003FA6 RID: 16294 RVA: 0x00143EA4 File Offset: 0x001420A4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 151199, RefRangeEnd = 151201, XrefRangeStart = 151178, XrefRangeEnd = 151199, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StopSearch()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CheckpointBehaviour.NativeMethodInfoPtr_StopSearch_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06003FA7 RID: 16295 RVA: 0x00143ED8 File Offset: 0x001420D8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 151223, RefRangeEnd = 151225, XrefRangeStart = 151201, XrefRangeEnd = 151223, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetIsSearching(bool s)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref s;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CheckpointBehaviour.NativeMethodInfoPtr_SetIsSearching_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06003FA8 RID: 16296 RVA: 0x00143F18 File Offset: 0x00142118
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 151230, RefRangeEnd = 151233, XrefRangeStart = 151225, XrefRangeEnd = 151230, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector3 GetSearchPoint()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(CheckpointBehaviour.NativeMethodInfoPtr_GetSearchPoint_Private_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06003FA9 RID: 16297 RVA: 0x00143F54 File Offset: 0x00142154
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 151233, XrefRangeEnd = 151254, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ConcludeSearch()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CheckpointBehaviour.NativeMethodInfoPtr_ConcludeSearch_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06003FAA RID: 16298 RVA: 0x00143F88 File Offset: 0x00142188
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 151306, RefRangeEnd = 151307, XrefRangeStart = 151254, XrefRangeEnd = 151306, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool DoesVehicleContainIllicitItems()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(CheckpointBehaviour.NativeMethodInfoPtr_DoesVehicleContainIllicitItems_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06003FAB RID: 16299 RVA: 0x00143FC4 File Offset: 0x001421C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 151307, XrefRangeEnd = 151360, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PlayerWalkedThroughCheckPoint(Player player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CheckpointBehaviour.NativeMethodInfoPtr_PlayerWalkedThroughCheckPoint_Private_Void_Player_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06003FAC RID: 16300 RVA: 0x00144008 File Offset: 0x00142208
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CheckpointBehaviour() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CheckpointBehaviour>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CheckpointBehaviour.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06003FAD RID: 16301 RVA: 0x00144044 File Offset: 0x00142244
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 151360, XrefRangeEnd = 151399, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize___Early()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CheckpointBehaviour.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06003FAE RID: 16302 RVA: 0x00144080 File Offset: 0x00142280
		[CallerCount(0)]
		public unsafe override void NetworkInitialize__Late()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CheckpointBehaviour.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06003FAF RID: 16303 RVA: 0x001440BC File Offset: 0x001422BC
		[CallerCount(0)]
		public unsafe override void NetworkInitializeIfDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CheckpointBehaviour.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06003FB0 RID: 16304 RVA: 0x001440F8 File Offset: 0x001422F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 151399, XrefRangeEnd = 151409, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_SetCheckpoint_4087078542(CheckpointManager.ECheckpointLocation loc)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref loc;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CheckpointBehaviour.NativeMethodInfoPtr_RpcWriter___Observers_SetCheckpoint_4087078542_Private_Void_ECheckpointLocation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06003FB1 RID: 16305 RVA: 0x00144138 File Offset: 0x00142338
		[CallerCount(0)]
		public unsafe void RpcLogic___SetCheckpoint_4087078542(CheckpointManager.ECheckpointLocation loc)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref loc;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CheckpointBehaviour.NativeMethodInfoPtr_RpcLogic___SetCheckpoint_4087078542_Public_Void_ECheckpointLocation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06003FB2 RID: 16306 RVA: 0x00144178 File Offset: 0x00142378
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 151409, XrefRangeEnd = 151412, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_SetCheckpoint_4087078542(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref channel;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CheckpointBehaviour.NativeMethodInfoPtr_RpcReader___Observers_SetCheckpoint_4087078542_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06003FB3 RID: 16307 RVA: 0x001441C8 File Offset: 0x001423C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 151412, XrefRangeEnd = 151422, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_SetInitiator_3323014238(NetworkObject init)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(init);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CheckpointBehaviour.NativeMethodInfoPtr_RpcWriter___Observers_SetInitiator_3323014238_Private_Void_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06003FB4 RID: 16308 RVA: 0x0014420C File Offset: 0x0014240C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 151422, XrefRangeEnd = 151427, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SetInitiator_3323014238(NetworkObject init)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(init);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CheckpointBehaviour.NativeMethodInfoPtr_RpcLogic___SetInitiator_3323014238_Public_Void_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06003FB5 RID: 16309 RVA: 0x00144250 File Offset: 0x00142450
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 151427, XrefRangeEnd = 151434, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_SetInitiator_3323014238(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref channel;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CheckpointBehaviour.NativeMethodInfoPtr_RpcReader___Observers_SetInitiator_3323014238_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06003FB6 RID: 16310 RVA: 0x001442A0 File Offset: 0x001424A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 151434, XrefRangeEnd = 151445, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_StartSearch_3694055493(NetworkObject targetVehicle, NetworkObject initiator)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(targetVehicle);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(initiator);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CheckpointBehaviour.NativeMethodInfoPtr_RpcWriter___Server_StartSearch_3694055493_Private_Void_NetworkObject_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06003FB7 RID: 16311 RVA: 0x001442F4 File Offset: 0x001424F4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 151482, RefRangeEnd = 151485, XrefRangeStart = 151445, XrefRangeEnd = 151482, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___StartSearch_3694055493(NetworkObject targetVehicle, NetworkObject initiator)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(targetVehicle);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(initiator);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CheckpointBehaviour.NativeMethodInfoPtr_RpcLogic___StartSearch_3694055493_Public_Void_NetworkObject_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06003FB8 RID: 16312 RVA: 0x00144348 File Offset: 0x00142548
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 151485, XrefRangeEnd = 151490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_StartSearch_3694055493(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref channel;
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CheckpointBehaviour.NativeMethodInfoPtr_RpcReader___Server_StartSearch_3694055493_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06003FB9 RID: 16313 RVA: 0x001443AC File Offset: 0x001425AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 151490, XrefRangeEnd = 151499, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_StopSearch_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CheckpointBehaviour.NativeMethodInfoPtr_RpcWriter___Server_StopSearch_2166136261_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06003FBA RID: 16314 RVA: 0x001443E0 File Offset: 0x001425E0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 151511, RefRangeEnd = 151513, XrefRangeStart = 151499, XrefRangeEnd = 151511, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___StopSearch_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CheckpointBehaviour.NativeMethodInfoPtr_RpcLogic___StopSearch_2166136261_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06003FBB RID: 16315 RVA: 0x00144414 File Offset: 0x00142614
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 151513, XrefRangeEnd = 151516, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_StopSearch_2166136261(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref channel;
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CheckpointBehaviour.NativeMethodInfoPtr_RpcReader___Server_StopSearch_2166136261_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06003FBC RID: 16316 RVA: 0x00144478 File Offset: 0x00142678
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 151516, XrefRangeEnd = 151526, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_SetIsSearching_1140765316(bool s)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref s;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CheckpointBehaviour.NativeMethodInfoPtr_RpcWriter___Observers_SetIsSearching_1140765316_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06003FBD RID: 16317 RVA: 0x001444B8 File Offset: 0x001426B8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 151529, RefRangeEnd = 151531, XrefRangeStart = 151526, XrefRangeEnd = 151529, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SetIsSearching_1140765316(bool s)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref s;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CheckpointBehaviour.NativeMethodInfoPtr_RpcLogic___SetIsSearching_1140765316_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06003FBE RID: 16318 RVA: 0x001444F8 File Offset: 0x001426F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 151531, XrefRangeEnd = 151534, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_SetIsSearching_1140765316(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref channel;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CheckpointBehaviour.NativeMethodInfoPtr_RpcReader___Observers_SetIsSearching_1140765316_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06003FBF RID: 16319 RVA: 0x00144548 File Offset: 0x00142748
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 151534, XrefRangeEnd = 151543, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_ConcludeSearch_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CheckpointBehaviour.NativeMethodInfoPtr_RpcWriter___Observers_ConcludeSearch_2166136261_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06003FC0 RID: 16320 RVA: 0x0014457C File Offset: 0x0014277C
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 151598, RefRangeEnd = 151603, XrefRangeStart = 151543, XrefRangeEnd = 151598, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___ConcludeSearch_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CheckpointBehaviour.NativeMethodInfoPtr_RpcLogic___ConcludeSearch_2166136261_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06003FC1 RID: 16321 RVA: 0x001445B0 File Offset: 0x001427B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 151603, XrefRangeEnd = 151606, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_ConcludeSearch_2166136261(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref channel;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CheckpointBehaviour.NativeMethodInfoPtr_RpcReader___Observers_ConcludeSearch_2166136261_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06003FC2 RID: 16322 RVA: 0x00144600 File Offset: 0x00142800
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CheckpointBehaviour.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06003FC3 RID: 16323 RVA: 0x0001FC53 File Offset: 0x0001DE53
		public CheckpointBehaviour(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700137D RID: 4989
		// (get) Token: 0x06003FC4 RID: 16324 RVA: 0x0014463C File Offset: 0x0014283C
		// (set) Token: 0x06003FC5 RID: 16325 RVA: 0x0001FC5C File Offset: 0x0001DE5C
		public unsafe static float LOOK_TIME
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(CheckpointBehaviour.NativeFieldInfoPtr_LOOK_TIME, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CheckpointBehaviour.NativeFieldInfoPtr_LOOK_TIME, (void*)(&value));
			}
		}

		// Token: 0x1700137E RID: 4990
		// (get) Token: 0x06003FC6 RID: 16326 RVA: 0x00144658 File Offset: 0x00142858
		// (set) Token: 0x06003FC7 RID: 16327 RVA: 0x0001FC6A File Offset: 0x0001DE6A
		public unsafe CheckpointManager.ECheckpointLocation _AssignedCheckpoint_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CheckpointBehaviour.NativeFieldInfoPtr__AssignedCheckpoint_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CheckpointBehaviour.NativeFieldInfoPtr__AssignedCheckpoint_k__BackingField)) = value;
			}
		}

		// Token: 0x1700137F RID: 4991
		// (get) Token: 0x06003FC8 RID: 16328 RVA: 0x00144680 File Offset: 0x00142880
		// (set) Token: 0x06003FC9 RID: 16329 RVA: 0x0001FC85 File Offset: 0x0001DE85
		public unsafe RoadCheckpoint _Checkpoint_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CheckpointBehaviour.NativeFieldInfoPtr__Checkpoint_k__BackingField);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RoadCheckpoint>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CheckpointBehaviour.NativeFieldInfoPtr__Checkpoint_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001380 RID: 4992
		// (get) Token: 0x06003FCA RID: 16330 RVA: 0x001446B0 File Offset: 0x001428B0
		// (set) Token: 0x06003FCB RID: 16331 RVA: 0x0001FCA4 File Offset: 0x0001DEA4
		public unsafe bool _IsSearching_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CheckpointBehaviour.NativeFieldInfoPtr__IsSearching_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CheckpointBehaviour.NativeFieldInfoPtr__IsSearching_k__BackingField)) = value;
			}
		}

		// Token: 0x17001381 RID: 4993
		// (get) Token: 0x06003FCC RID: 16332 RVA: 0x001446D8 File Offset: 0x001428D8
		// (set) Token: 0x06003FCD RID: 16333 RVA: 0x0001FCBF File Offset: 0x0001DEBF
		public unsafe LandVehicle _CurrentSearchedVehicle_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CheckpointBehaviour.NativeFieldInfoPtr__CurrentSearchedVehicle_k__BackingField);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LandVehicle>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CheckpointBehaviour.NativeFieldInfoPtr__CurrentSearchedVehicle_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001382 RID: 4994
		// (get) Token: 0x06003FCE RID: 16334 RVA: 0x00144708 File Offset: 0x00142908
		// (set) Token: 0x06003FCF RID: 16335 RVA: 0x0001FCDE File Offset: 0x0001DEDE
		public unsafe Player _Initiator_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CheckpointBehaviour.NativeFieldInfoPtr__Initiator_k__BackingField);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Player>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CheckpointBehaviour.NativeFieldInfoPtr__Initiator_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001383 RID: 4995
		// (get) Token: 0x06003FD0 RID: 16336 RVA: 0x00144738 File Offset: 0x00142938
		// (set) Token: 0x06003FD1 RID: 16337 RVA: 0x0001FCFD File Offset: 0x0001DEFD
		public unsafe float currentLookTime
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CheckpointBehaviour.NativeFieldInfoPtr_currentLookTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CheckpointBehaviour.NativeFieldInfoPtr_currentLookTime)) = value;
			}
		}

		// Token: 0x17001384 RID: 4996
		// (get) Token: 0x06003FD2 RID: 16338 RVA: 0x00144760 File Offset: 0x00142960
		// (set) Token: 0x06003FD3 RID: 16339 RVA: 0x0001FD18 File Offset: 0x0001DF18
		public unsafe bool trunkOpened
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CheckpointBehaviour.NativeFieldInfoPtr_trunkOpened);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CheckpointBehaviour.NativeFieldInfoPtr_trunkOpened)) = value;
			}
		}

		// Token: 0x17001385 RID: 4997
		// (get) Token: 0x06003FD4 RID: 16340 RVA: 0x00144788 File Offset: 0x00142988
		// (set) Token: 0x06003FD5 RID: 16341 RVA: 0x0001FD33 File Offset: 0x0001DF33
		public new unsafe bool field_Private_Boolean_0
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CheckpointBehaviour.NativeFieldInfoPtr_field_Private_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CheckpointBehaviour.NativeFieldInfoPtr_field_Private_Boolean_0)) = value;
			}
		}

		// Token: 0x17001386 RID: 4998
		// (get) Token: 0x06003FD6 RID: 16342 RVA: 0x001447B0 File Offset: 0x001429B0
		// (set) Token: 0x06003FD7 RID: 16343 RVA: 0x0001FD4E File Offset: 0x0001DF4E
		public new unsafe bool field_Private_Boolean_1
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CheckpointBehaviour.NativeFieldInfoPtr_field_Private_Boolean_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CheckpointBehaviour.NativeFieldInfoPtr_field_Private_Boolean_1)) = value;
			}
		}

		// Token: 0x04002A05 RID: 10757
		private static readonly System.IntPtr NativeFieldInfoPtr_LOOK_TIME;

		// Token: 0x04002A06 RID: 10758
		private static readonly System.IntPtr NativeFieldInfoPtr__AssignedCheckpoint_k__BackingField;

		// Token: 0x04002A07 RID: 10759
		private static readonly System.IntPtr NativeFieldInfoPtr__Checkpoint_k__BackingField;

		// Token: 0x04002A08 RID: 10760
		private static readonly System.IntPtr NativeFieldInfoPtr__IsSearching_k__BackingField;

		// Token: 0x04002A09 RID: 10761
		private static readonly System.IntPtr NativeFieldInfoPtr__CurrentSearchedVehicle_k__BackingField;

		// Token: 0x04002A0A RID: 10762
		private static readonly System.IntPtr NativeFieldInfoPtr__Initiator_k__BackingField;

		// Token: 0x04002A0B RID: 10763
		private static readonly System.IntPtr NativeFieldInfoPtr_currentLookTime;

		// Token: 0x04002A0C RID: 10764
		private static readonly System.IntPtr NativeFieldInfoPtr_trunkOpened;

		// Token: 0x04002A0D RID: 10765
		private static readonly System.IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

		// Token: 0x04002A0E RID: 10766
		private static readonly System.IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

		// Token: 0x04002A0F RID: 10767
		private static readonly System.IntPtr NativeMethodInfoPtr_get_AssignedCheckpoint_Public_get_ECheckpointLocation_0;

		// Token: 0x04002A10 RID: 10768
		private static readonly System.IntPtr NativeMethodInfoPtr_set_AssignedCheckpoint_Protected_set_Void_ECheckpointLocation_0;

		// Token: 0x04002A11 RID: 10769
		private static readonly System.IntPtr NativeMethodInfoPtr_get_Checkpoint_Public_get_RoadCheckpoint_0;

		// Token: 0x04002A12 RID: 10770
		private static readonly System.IntPtr NativeMethodInfoPtr_set_Checkpoint_Protected_set_Void_RoadCheckpoint_0;

		// Token: 0x04002A13 RID: 10771
		private static readonly System.IntPtr NativeMethodInfoPtr_get_IsSearching_Public_get_Boolean_0;

		// Token: 0x04002A14 RID: 10772
		private static readonly System.IntPtr NativeMethodInfoPtr_set_IsSearching_Protected_set_Void_Boolean_0;

		// Token: 0x04002A15 RID: 10773
		private static readonly System.IntPtr NativeMethodInfoPtr_get_CurrentSearchedVehicle_Public_get_LandVehicle_0;

		// Token: 0x04002A16 RID: 10774
		private static readonly System.IntPtr NativeMethodInfoPtr_set_CurrentSearchedVehicle_Protected_set_Void_LandVehicle_0;

		// Token: 0x04002A17 RID: 10775
		private static readonly System.IntPtr NativeMethodInfoPtr_get_Initiator_Public_get_Player_0;

		// Token: 0x04002A18 RID: 10776
		private static readonly System.IntPtr NativeMethodInfoPtr_set_Initiator_Protected_set_Void_Player_0;

		// Token: 0x04002A19 RID: 10777
		private static readonly System.IntPtr NativeMethodInfoPtr_get_standPoint_Private_get_Transform_0;

		// Token: 0x04002A1A RID: 10778
		private static readonly System.IntPtr NativeMethodInfoPtr_get_dialogueDatabase_Private_get_DialogueDatabase_0;

		// Token: 0x04002A1B RID: 10779
		private static readonly System.IntPtr NativeMethodInfoPtr_Begin_Protected_Virtual_Void_0;

		// Token: 0x04002A1C RID: 10780
		private static readonly System.IntPtr NativeMethodInfoPtr_Resume_Protected_Virtual_Void_0;

		// Token: 0x04002A1D RID: 10781
		private static readonly System.IntPtr NativeMethodInfoPtr_End_Protected_Virtual_Void_0;

		// Token: 0x04002A1E RID: 10782
		private static readonly System.IntPtr NativeMethodInfoPtr_Pause_Protected_Virtual_Void_0;

		// Token: 0x04002A1F RID: 10783
		private static readonly System.IntPtr NativeMethodInfoPtr_ActiveMinPass_Public_Virtual_Void_0;

		// Token: 0x04002A20 RID: 10784
		private static readonly System.IntPtr NativeMethodInfoPtr_SetCheckpoint_Public_Void_ECheckpointLocation_0;

		// Token: 0x04002A21 RID: 10785
		private static readonly System.IntPtr NativeMethodInfoPtr_SetInitiator_Public_Void_NetworkObject_0;

		// Token: 0x04002A22 RID: 10786
		private static readonly System.IntPtr NativeMethodInfoPtr_StartSearch_Public_Void_NetworkObject_NetworkObject_0;

		// Token: 0x04002A23 RID: 10787
		private static readonly System.IntPtr NativeMethodInfoPtr_StopSearch_Public_Void_0;

		// Token: 0x04002A24 RID: 10788
		private static readonly System.IntPtr NativeMethodInfoPtr_SetIsSearching_Public_Void_Boolean_0;

		// Token: 0x04002A25 RID: 10789
		private static readonly System.IntPtr NativeMethodInfoPtr_GetSearchPoint_Private_Vector3_0;

		// Token: 0x04002A26 RID: 10790
		private static readonly System.IntPtr NativeMethodInfoPtr_ConcludeSearch_Private_Void_0;

		// Token: 0x04002A27 RID: 10791
		private static readonly System.IntPtr NativeMethodInfoPtr_DoesVehicleContainIllicitItems_Private_Boolean_0;

		// Token: 0x04002A28 RID: 10792
		private static readonly System.IntPtr NativeMethodInfoPtr_PlayerWalkedThroughCheckPoint_Private_Void_Player_0;

		// Token: 0x04002A29 RID: 10793
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04002A2A RID: 10794
		private static readonly System.IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

		// Token: 0x04002A2B RID: 10795
		private static readonly System.IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

		// Token: 0x04002A2C RID: 10796
		private static readonly System.IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

		// Token: 0x04002A2D RID: 10797
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcWriter___Observers_SetCheckpoint_4087078542_Private_Void_ECheckpointLocation_0;

		// Token: 0x04002A2E RID: 10798
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcLogic___SetCheckpoint_4087078542_Public_Void_ECheckpointLocation_0;

		// Token: 0x04002A2F RID: 10799
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcReader___Observers_SetCheckpoint_4087078542_Private_Void_PooledReader_Channel_0;

		// Token: 0x04002A30 RID: 10800
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcWriter___Observers_SetInitiator_3323014238_Private_Void_NetworkObject_0;

		// Token: 0x04002A31 RID: 10801
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcLogic___SetInitiator_3323014238_Public_Void_NetworkObject_0;

		// Token: 0x04002A32 RID: 10802
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcReader___Observers_SetInitiator_3323014238_Private_Void_PooledReader_Channel_0;

		// Token: 0x04002A33 RID: 10803
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcWriter___Server_StartSearch_3694055493_Private_Void_NetworkObject_NetworkObject_0;

		// Token: 0x04002A34 RID: 10804
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcLogic___StartSearch_3694055493_Public_Void_NetworkObject_NetworkObject_0;

		// Token: 0x04002A35 RID: 10805
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcReader___Server_StartSearch_3694055493_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x04002A36 RID: 10806
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcWriter___Server_StopSearch_2166136261_Private_Void_0;

		// Token: 0x04002A37 RID: 10807
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcLogic___StopSearch_2166136261_Public_Void_0;

		// Token: 0x04002A38 RID: 10808
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcReader___Server_StopSearch_2166136261_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x04002A39 RID: 10809
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcWriter___Observers_SetIsSearching_1140765316_Private_Void_Boolean_0;

		// Token: 0x04002A3A RID: 10810
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcLogic___SetIsSearching_1140765316_Public_Void_Boolean_0;

		// Token: 0x04002A3B RID: 10811
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcReader___Observers_SetIsSearching_1140765316_Private_Void_PooledReader_Channel_0;

		// Token: 0x04002A3C RID: 10812
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcWriter___Observers_ConcludeSearch_2166136261_Private_Void_0;

		// Token: 0x04002A3D RID: 10813
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcLogic___ConcludeSearch_2166136261_Private_Void_0;

		// Token: 0x04002A3E RID: 10814
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcReader___Observers_ConcludeSearch_2166136261_Private_Void_PooledReader_Channel_0;

		// Token: 0x04002A3F RID: 10815
		private static readonly System.IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;

		// Token: 0x0200098A RID: 2442
		[ObfuscatedName("ScheduleOne.NPCs.Behaviour.CheckpointBehaviour+<>c")]
		[System.Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x0600CC78 RID: 52344 RVA: 0x0031B82C File Offset: 0x00319A2C
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<CheckpointBehaviour.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CheckpointBehaviour>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CheckpointBehaviour.__c>.NativeClassPtr);
				CheckpointBehaviour.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CheckpointBehaviour.__c>.NativeClassPtr, "<>9");
				CheckpointBehaviour.__c.NativeFieldInfoPtr___9__39_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CheckpointBehaviour.__c>.NativeClassPtr, "<>9__39_0");
				CheckpointBehaviour.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CheckpointBehaviour.__c>.NativeClassPtr, 100670873);
				CheckpointBehaviour.__c.NativeMethodInfoPtr__DoesVehicleContainIllicitItems_b__39_0_Internal_ItemInstance_ItemSlot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CheckpointBehaviour.__c>.NativeClassPtr, 100670874);
			}

			// Token: 0x0600CC79 RID: 52345 RVA: 0x0031B8A8 File Offset: 0x00319AA8
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CheckpointBehaviour.__c>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CheckpointBehaviour.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600CC7A RID: 52346 RVA: 0x0031B8E4 File Offset: 0x00319AE4
			[CallerCount(0)]
			public unsafe ItemInstance _DoesVehicleContainIllicitItems_b__39_0(ItemSlot x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CheckpointBehaviour.__c.NativeMethodInfoPtr__DoesVehicleContainIllicitItems_b__39_0_Internal_ItemInstance_ItemSlot_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemInstance>(intPtr2) : null;
			}

			// Token: 0x0600CC7B RID: 52347 RVA: 0x000632E2 File Offset: 0x000614E2
			public __c(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003F65 RID: 16229
			// (get) Token: 0x0600CC7C RID: 52348 RVA: 0x0031B934 File Offset: 0x00319B34
			// (set) Token: 0x0600CC7D RID: 52349 RVA: 0x000632EB File Offset: 0x000614EB
			public unsafe static CheckpointBehaviour.__c __9
			{
				get
				{
					System.IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(CheckpointBehaviour.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<CheckpointBehaviour.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(CheckpointBehaviour.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003F66 RID: 16230
			// (get) Token: 0x0600CC7E RID: 52350 RVA: 0x0031B95C File Offset: 0x00319B5C
			// (set) Token: 0x0600CC7F RID: 52351 RVA: 0x000632FD File Offset: 0x000614FD
			public unsafe static Il2CppSystem.Func<ItemSlot, ItemInstance> __9__39_0
			{
				get
				{
					System.IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(CheckpointBehaviour.__c.NativeFieldInfoPtr___9__39_0, (void*)(&intPtr));
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Func<ItemSlot, ItemInstance>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(CheckpointBehaviour.__c.NativeFieldInfoPtr___9__39_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008A6E RID: 35438
			private static readonly System.IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04008A6F RID: 35439
			private static readonly System.IntPtr NativeFieldInfoPtr___9__39_0;

			// Token: 0x04008A70 RID: 35440
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008A71 RID: 35441
			private static readonly System.IntPtr NativeMethodInfoPtr__DoesVehicleContainIllicitItems_b__39_0_Internal_ItemInstance_ItemSlot_0;
		}
	}
}
