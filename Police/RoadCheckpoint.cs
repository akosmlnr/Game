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
using Il2CppScheduleOne.DevUtilities;
using Il2CppScheduleOne.Misc;
using Il2CppScheduleOne.NPCs;
using Il2CppScheduleOne.PlayerScripts;
using Il2CppScheduleOne.Product.Packaging;
using Il2CppScheduleOne.Vehicles;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace Il2CppScheduleOne.Police
{
	// Token: 0x0200020A RID: 522
	public class RoadCheckpoint : NetworkBehaviour
	{
		// Token: 0x06002A33 RID: 10803 RVA: 0x000F9440 File Offset: 0x000F7640
		// Note: this type is marked as 'beforefieldinit'.
		static RoadCheckpoint()
		{
			Il2CppClassPointerStore<RoadCheckpoint>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Police", "RoadCheckpoint");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RoadCheckpoint>.NativeClassPtr);
			RoadCheckpoint.NativeFieldInfoPtr_MAX_TIME_OPEN = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoadCheckpoint>.NativeClassPtr, "MAX_TIME_OPEN");
			RoadCheckpoint.NativeFieldInfoPtr__ActivationState_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoadCheckpoint>.NativeClassPtr, "<ActivationState>k__BackingField");
			RoadCheckpoint.NativeFieldInfoPtr_appliedState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoadCheckpoint>.NativeClassPtr, "appliedState");
			RoadCheckpoint.NativeFieldInfoPtr__Gate1Open_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoadCheckpoint>.NativeClassPtr, "<Gate1Open>k__BackingField");
			RoadCheckpoint.NativeFieldInfoPtr__Gate2Open_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoadCheckpoint>.NativeClassPtr, "<Gate2Open>k__BackingField");
			RoadCheckpoint.NativeFieldInfoPtr_AssignedNPCs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoadCheckpoint>.NativeClassPtr, "AssignedNPCs");
			RoadCheckpoint.NativeFieldInfoPtr_MaxStealthLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoadCheckpoint>.NativeClassPtr, "MaxStealthLevel");
			RoadCheckpoint.NativeFieldInfoPtr_OpenForNPCs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoadCheckpoint>.NativeClassPtr, "OpenForNPCs");
			RoadCheckpoint.NativeFieldInfoPtr_EnabledOnStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoadCheckpoint>.NativeClassPtr, "EnabledOnStart");
			RoadCheckpoint.NativeFieldInfoPtr_container = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoadCheckpoint>.NativeClassPtr, "container");
			RoadCheckpoint.NativeFieldInfoPtr_Stopper1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoadCheckpoint>.NativeClassPtr, "Stopper1");
			RoadCheckpoint.NativeFieldInfoPtr_Stopper2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoadCheckpoint>.NativeClassPtr, "Stopper2");
			RoadCheckpoint.NativeFieldInfoPtr_SearchArea1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoadCheckpoint>.NativeClassPtr, "SearchArea1");
			RoadCheckpoint.NativeFieldInfoPtr_SearchArea2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoadCheckpoint>.NativeClassPtr, "SearchArea2");
			RoadCheckpoint.NativeFieldInfoPtr_VehicleObstacle1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoadCheckpoint>.NativeClassPtr, "VehicleObstacle1");
			RoadCheckpoint.NativeFieldInfoPtr_VehicleObstacle2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoadCheckpoint>.NativeClassPtr, "VehicleObstacle2");
			RoadCheckpoint.NativeFieldInfoPtr_NPCVehicleDetectionArea1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoadCheckpoint>.NativeClassPtr, "NPCVehicleDetectionArea1");
			RoadCheckpoint.NativeFieldInfoPtr_NPCVehicleDetectionArea2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoadCheckpoint>.NativeClassPtr, "NPCVehicleDetectionArea2");
			RoadCheckpoint.NativeFieldInfoPtr_ImmediateVehicleDetector = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoadCheckpoint>.NativeClassPtr, "ImmediateVehicleDetector");
			RoadCheckpoint.NativeFieldInfoPtr_TrafficCones = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoadCheckpoint>.NativeClassPtr, "TrafficCones");
			RoadCheckpoint.NativeFieldInfoPtr_StandPoints = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoadCheckpoint>.NativeClassPtr, "StandPoints");
			RoadCheckpoint.NativeFieldInfoPtr_trafficConeOriginalTransforms = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoadCheckpoint>.NativeClassPtr, "trafficConeOriginalTransforms");
			RoadCheckpoint.NativeFieldInfoPtr_timeSinceGate1Open = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoadCheckpoint>.NativeClassPtr, "timeSinceGate1Open");
			RoadCheckpoint.NativeFieldInfoPtr_vehicleDetectedSinceGate1Open = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoadCheckpoint>.NativeClassPtr, "vehicleDetectedSinceGate1Open");
			RoadCheckpoint.NativeFieldInfoPtr_timeSinceGate2Open = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoadCheckpoint>.NativeClassPtr, "timeSinceGate2Open");
			RoadCheckpoint.NativeFieldInfoPtr_vehicleDetectedSinceGate2Open = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoadCheckpoint>.NativeClassPtr, "vehicleDetectedSinceGate2Open");
			RoadCheckpoint.NativeFieldInfoPtr_onPlayerWalkThrough = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoadCheckpoint>.NativeClassPtr, "onPlayerWalkThrough");
			RoadCheckpoint.NativeFieldInfoPtr_syncVar____Gate1Open_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoadCheckpoint>.NativeClassPtr, "syncVar___<Gate1Open>k__BackingField");
			RoadCheckpoint.NativeFieldInfoPtr_syncVar____Gate2Open_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoadCheckpoint>.NativeClassPtr, "syncVar___<Gate2Open>k__BackingField");
			RoadCheckpoint.NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoadCheckpoint>.NativeClassPtr, "NetworkInitialize___EarlyScheduleOne.Police.RoadCheckpointAssembly-CSharp.dll_Excuted");
			RoadCheckpoint.NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoadCheckpoint>.NativeClassPtr, "NetworkInitialize__LateScheduleOne.Police.RoadCheckpointAssembly-CSharp.dll_Excuted");
			RoadCheckpoint.NativeMethodInfoPtr_get_ActivationState_Public_get_ECheckpointState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RoadCheckpoint>.NativeClassPtr, 100668114);
			RoadCheckpoint.NativeMethodInfoPtr_set_ActivationState_Protected_set_Void_ECheckpointState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RoadCheckpoint>.NativeClassPtr, 100668115);
			RoadCheckpoint.NativeMethodInfoPtr_get_Gate1Open_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RoadCheckpoint>.NativeClassPtr, 100668116);
			RoadCheckpoint.NativeMethodInfoPtr_set_Gate1Open_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RoadCheckpoint>.NativeClassPtr, 100668117);
			RoadCheckpoint.NativeMethodInfoPtr_get_Gate2Open_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RoadCheckpoint>.NativeClassPtr, 100668118);
			RoadCheckpoint.NativeMethodInfoPtr_set_Gate2Open_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RoadCheckpoint>.NativeClassPtr, 100668119);
			RoadCheckpoint.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RoadCheckpoint>.NativeClassPtr, 100668120);
			RoadCheckpoint.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RoadCheckpoint>.NativeClassPtr, 100668121);
			RoadCheckpoint.NativeMethodInfoPtr_ApplyState_Protected_Virtual_New_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RoadCheckpoint>.NativeClassPtr, 100668122);
			RoadCheckpoint.NativeMethodInfoPtr_Enable_Public_Void_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RoadCheckpoint>.NativeClassPtr, 100668123);
			RoadCheckpoint.NativeMethodInfoPtr_Disable_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RoadCheckpoint>.NativeClassPtr, 100668124);
			RoadCheckpoint.NativeMethodInfoPtr_SetGate1Open_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RoadCheckpoint>.NativeClassPtr, 100668125);
			RoadCheckpoint.NativeMethodInfoPtr_SetGate2Open_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RoadCheckpoint>.NativeClassPtr, 100668126);
			RoadCheckpoint.NativeMethodInfoPtr_ResetTrafficCones_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RoadCheckpoint>.NativeClassPtr, 100668127);
			RoadCheckpoint.NativeMethodInfoPtr_PlayerDetected_Public_Void_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RoadCheckpoint>.NativeClassPtr, 100668128);
			RoadCheckpoint.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RoadCheckpoint>.NativeClassPtr, 100668129);
			RoadCheckpoint.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RoadCheckpoint>.NativeClassPtr, 100668130);
			RoadCheckpoint.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RoadCheckpoint>.NativeClassPtr, 100668131);
			RoadCheckpoint.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RoadCheckpoint>.NativeClassPtr, 100668132);
			RoadCheckpoint.NativeMethodInfoPtr_RpcWriter___Observers_Enable_328543758_Private_Void_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RoadCheckpoint>.NativeClassPtr, 100668133);
			RoadCheckpoint.NativeMethodInfoPtr_RpcLogic___Enable_328543758_Public_Void_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RoadCheckpoint>.NativeClassPtr, 100668134);
			RoadCheckpoint.NativeMethodInfoPtr_RpcReader___Observers_Enable_328543758_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RoadCheckpoint>.NativeClassPtr, 100668135);
			RoadCheckpoint.NativeMethodInfoPtr_RpcWriter___Target_Enable_328543758_Private_Void_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RoadCheckpoint>.NativeClassPtr, 100668136);
			RoadCheckpoint.NativeMethodInfoPtr_RpcReader___Target_Enable_328543758_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RoadCheckpoint>.NativeClassPtr, 100668137);
			RoadCheckpoint.NativeMethodInfoPtr_RpcWriter___Observers_Disable_2166136261_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RoadCheckpoint>.NativeClassPtr, 100668138);
			RoadCheckpoint.NativeMethodInfoPtr_RpcLogic___Disable_2166136261_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RoadCheckpoint>.NativeClassPtr, 100668139);
			RoadCheckpoint.NativeMethodInfoPtr_RpcReader___Observers_Disable_2166136261_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RoadCheckpoint>.NativeClassPtr, 100668140);
			RoadCheckpoint.NativeMethodInfoPtr_sync___get_value__Gate1Open_k__BackingField_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RoadCheckpoint>.NativeClassPtr, 100668141);
			RoadCheckpoint.NativeMethodInfoPtr_sync___set_value__Gate1Open_k__BackingField_Public_set_Void_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RoadCheckpoint>.NativeClassPtr, 100668142);
			RoadCheckpoint.NativeMethodInfoPtr_ReadSyncVar___ScheduleOne_Police_RoadCheckpoint_Public_Virtual_Boolean_PooledReader_UInt32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RoadCheckpoint>.NativeClassPtr, 100668143);
			RoadCheckpoint.NativeMethodInfoPtr_sync___get_value__Gate2Open_k__BackingField_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RoadCheckpoint>.NativeClassPtr, 100668144);
			RoadCheckpoint.NativeMethodInfoPtr_sync___set_value__Gate2Open_k__BackingField_Public_set_Void_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RoadCheckpoint>.NativeClassPtr, 100668145);
			RoadCheckpoint.NativeMethodInfoPtr_Method_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RoadCheckpoint>.NativeClassPtr, 100668146);
		}

		// Token: 0x17000E0C RID: 3596
		// (get) Token: 0x06002A34 RID: 10804 RVA: 0x000F9970 File Offset: 0x000F7B70
		// (set) Token: 0x06002A35 RID: 10805 RVA: 0x000F99AC File Offset: 0x000F7BAC
		public unsafe RoadCheckpoint.ECheckpointState ActivationState
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(RoadCheckpoint.NativeMethodInfoPtr_get_ActivationState_Public_get_ECheckpointState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
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
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RoadCheckpoint.NativeMethodInfoPtr_set_ActivationState_Protected_set_Void_ECheckpointState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x17000E0D RID: 3597
		// (get) Token: 0x06002A36 RID: 10806 RVA: 0x000F99EC File Offset: 0x000F7BEC
		// (set) Token: 0x06002A37 RID: 10807 RVA: 0x000F9A28 File Offset: 0x000F7C28
		public unsafe bool Gate1Open
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(RoadCheckpoint.NativeMethodInfoPtr_get_Gate1Open_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 123580, RefRangeEnd = 123584, XrefRangeStart = 123573, XrefRangeEnd = 123580, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = ref value;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RoadCheckpoint.NativeMethodInfoPtr_set_Gate1Open_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x17000E0E RID: 3598
		// (get) Token: 0x06002A38 RID: 10808 RVA: 0x000F9A68 File Offset: 0x000F7C68
		// (set) Token: 0x06002A39 RID: 10809 RVA: 0x000F9AA4 File Offset: 0x000F7CA4
		public unsafe bool Gate2Open
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(RoadCheckpoint.NativeMethodInfoPtr_get_Gate2Open_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 123591, RefRangeEnd = 123594, XrefRangeStart = 123584, XrefRangeEnd = 123591, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = ref value;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RoadCheckpoint.NativeMethodInfoPtr_set_Gate2Open_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x06002A3A RID: 10810 RVA: 0x000F9AE4 File Offset: 0x000F7CE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 123594, XrefRangeEnd = 123595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RoadCheckpoint.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06002A3B RID: 10811 RVA: 0x000F9B20 File Offset: 0x000F7D20
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 123595, XrefRangeEnd = 123618, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RoadCheckpoint.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_1), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06002A3C RID: 10812 RVA: 0x000F9B5C File Offset: 0x000F7D5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 123618, XrefRangeEnd = 123621, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void ApplyState()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RoadCheckpoint.NativeMethodInfoPtr_ApplyState_Protected_Virtual_New_Void_1), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06002A3D RID: 10813 RVA: 0x000F9B98 File Offset: 0x000F7D98
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 123658, RefRangeEnd = 123662, XrefRangeStart = 123621, XrefRangeEnd = 123658, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Enable(NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RoadCheckpoint.NativeMethodInfoPtr_Enable_Public_Void_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06002A3E RID: 10814 RVA: 0x000F9BDC File Offset: 0x000F7DDC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 123683, RefRangeEnd = 123685, XrefRangeStart = 123662, XrefRangeEnd = 123683, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Disable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RoadCheckpoint.NativeMethodInfoPtr_Disable_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06002A3F RID: 10815 RVA: 0x000F9C10 File Offset: 0x000F7E10
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 123580, RefRangeEnd = 123584, XrefRangeStart = 123580, XrefRangeEnd = 123584, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetGate1Open(bool o)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref o;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RoadCheckpoint.NativeMethodInfoPtr_SetGate1Open_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06002A40 RID: 10816 RVA: 0x000F9C50 File Offset: 0x000F7E50
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 123591, RefRangeEnd = 123594, XrefRangeStart = 123591, XrefRangeEnd = 123594, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetGate2Open(bool o)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref o;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RoadCheckpoint.NativeMethodInfoPtr_SetGate2Open_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06002A41 RID: 10817 RVA: 0x000F9C90 File Offset: 0x000F7E90
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 123700, RefRangeEnd = 123704, XrefRangeStart = 123685, XrefRangeEnd = 123700, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ResetTrafficCones()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RoadCheckpoint.NativeMethodInfoPtr_ResetTrafficCones_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06002A42 RID: 10818 RVA: 0x000F9CC4 File Offset: 0x000F7EC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 123704, XrefRangeEnd = 123707, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PlayerDetected(Player player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RoadCheckpoint.NativeMethodInfoPtr_PlayerDetected_Public_Void_Player_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06002A43 RID: 10819 RVA: 0x000F9D08 File Offset: 0x000F7F08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 123707, XrefRangeEnd = 123722, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RoadCheckpoint() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RoadCheckpoint>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RoadCheckpoint.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06002A44 RID: 10820 RVA: 0x000F9D44 File Offset: 0x000F7F44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 123722, XrefRangeEnd = 123764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void NetworkInitialize___Early()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RoadCheckpoint.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06002A45 RID: 10821 RVA: 0x000F9D80 File Offset: 0x000F7F80
		[CallerCount(0)]
		public unsafe virtual void NetworkInitialize__Late()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RoadCheckpoint.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06002A46 RID: 10822 RVA: 0x000F9DBC File Offset: 0x000F7FBC
		[CallerCount(0)]
		public unsafe override void NetworkInitializeIfDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RoadCheckpoint.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06002A47 RID: 10823 RVA: 0x000F9DF8 File Offset: 0x000F7FF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 123764, XrefRangeEnd = 123773, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_Enable_328543758(NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RoadCheckpoint.NativeMethodInfoPtr_RpcWriter___Observers_Enable_328543758_Private_Void_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06002A48 RID: 10824 RVA: 0x000F9E3C File Offset: 0x000F803C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 123773, XrefRangeEnd = 123774, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___Enable_328543758(NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RoadCheckpoint.NativeMethodInfoPtr_RpcLogic___Enable_328543758_Public_Void_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06002A49 RID: 10825 RVA: 0x000F9E80 File Offset: 0x000F8080
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 123774, XrefRangeEnd = 123777, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_Enable_328543758(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref channel;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RoadCheckpoint.NativeMethodInfoPtr_RpcReader___Observers_Enable_328543758_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06002A4A RID: 10826 RVA: 0x000F9ED0 File Offset: 0x000F80D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 123777, XrefRangeEnd = 123786, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Target_Enable_328543758(NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RoadCheckpoint.NativeMethodInfoPtr_RpcWriter___Target_Enable_328543758_Private_Void_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06002A4B RID: 10827 RVA: 0x000F9F14 File Offset: 0x000F8114
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 123786, XrefRangeEnd = 123789, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Target_Enable_328543758(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref channel;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RoadCheckpoint.NativeMethodInfoPtr_RpcReader___Target_Enable_328543758_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06002A4C RID: 10828 RVA: 0x000F9F64 File Offset: 0x000F8164
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 123789, XrefRangeEnd = 123798, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_Disable_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RoadCheckpoint.NativeMethodInfoPtr_RpcWriter___Observers_Disable_2166136261_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06002A4D RID: 10829 RVA: 0x000F9F98 File Offset: 0x000F8198
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 123811, RefRangeEnd = 123813, XrefRangeStart = 123798, XrefRangeEnd = 123811, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___Disable_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RoadCheckpoint.NativeMethodInfoPtr_RpcLogic___Disable_2166136261_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06002A4E RID: 10830 RVA: 0x000F9FCC File Offset: 0x000F81CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 123813, XrefRangeEnd = 123816, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_Disable_2166136261(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref channel;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RoadCheckpoint.NativeMethodInfoPtr_RpcReader___Observers_Disable_2166136261_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x17000E0F RID: 3599
		// (get) Token: 0x06002A4F RID: 10831 RVA: 0x000FA01C File Offset: 0x000F821C
		// (set) Token: 0x06002A50 RID: 10832 RVA: 0x000FA058 File Offset: 0x000F8258
		public unsafe bool SyncAccessor_<Gate1Open>k__BackingField
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(RoadCheckpoint.NativeMethodInfoPtr_sync___get_value__Gate1Open_k__BackingField_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 123824, RefRangeEnd = 123825, XrefRangeStart = 123816, XrefRangeEnd = 123824, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = ref value;
				ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref value;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RoadCheckpoint.NativeMethodInfoPtr_sync___set_value__Gate1Open_k__BackingField_Public_set_Void_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x06002A51 RID: 10833 RVA: 0x000FA0A4 File Offset: 0x000F82A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 123825, XrefRangeEnd = 123828, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool ReadSyncVar___ScheduleOne_Police_RoadCheckpoint(PooledReader PooledReader0, uint UInt321, bool Boolean2)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref UInt321;
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref Boolean2;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RoadCheckpoint.NativeMethodInfoPtr_ReadSyncVar___ScheduleOne_Police_RoadCheckpoint_Public_Virtual_Boolean_PooledReader_UInt32_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x17000E10 RID: 3600
		// (get) Token: 0x06002A52 RID: 10834 RVA: 0x000FA118 File Offset: 0x000F8318
		// (set) Token: 0x06002A53 RID: 10835 RVA: 0x000FA154 File Offset: 0x000F8354
		public unsafe bool SyncAccessor_<Gate2Open>k__BackingField
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(RoadCheckpoint.NativeMethodInfoPtr_sync___get_value__Gate2Open_k__BackingField_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 123828, XrefRangeEnd = 123836, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = ref value;
				ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref value;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RoadCheckpoint.NativeMethodInfoPtr_sync___set_value__Gate2Open_k__BackingField_Public_set_Void_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x06002A54 RID: 10836 RVA: 0x000FA1A0 File Offset: 0x000F83A0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 123853, RefRangeEnd = 123854, XrefRangeStart = 123836, XrefRangeEnd = 123853, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Method_Protected_Virtual_New_Void_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RoadCheckpoint.NativeMethodInfoPtr_Method_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06002A55 RID: 10837 RVA: 0x00016B5C File Offset: 0x00014D5C
		public RoadCheckpoint(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000DED RID: 3565
		// (get) Token: 0x06002A56 RID: 10838 RVA: 0x000FA1DC File Offset: 0x000F83DC
		// (set) Token: 0x06002A57 RID: 10839 RVA: 0x00016B65 File Offset: 0x00014D65
		public unsafe static float MAX_TIME_OPEN
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(RoadCheckpoint.NativeFieldInfoPtr_MAX_TIME_OPEN, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RoadCheckpoint.NativeFieldInfoPtr_MAX_TIME_OPEN, (void*)(&value));
			}
		}

		// Token: 0x17000DEE RID: 3566
		// (get) Token: 0x06002A58 RID: 10840 RVA: 0x000FA1F8 File Offset: 0x000F83F8
		// (set) Token: 0x06002A59 RID: 10841 RVA: 0x00016B73 File Offset: 0x00014D73
		public unsafe RoadCheckpoint.ECheckpointState _ActivationState_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(RoadCheckpoint.NativeFieldInfoPtr__ActivationState_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(RoadCheckpoint.NativeFieldInfoPtr__ActivationState_k__BackingField)) = value;
			}
		}

		// Token: 0x17000DEF RID: 3567
		// (get) Token: 0x06002A5A RID: 10842 RVA: 0x000FA220 File Offset: 0x000F8420
		// (set) Token: 0x06002A5B RID: 10843 RVA: 0x00016B8E File Offset: 0x00014D8E
		public unsafe RoadCheckpoint.ECheckpointState appliedState
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(RoadCheckpoint.NativeFieldInfoPtr_appliedState);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(RoadCheckpoint.NativeFieldInfoPtr_appliedState)) = value;
			}
		}

		// Token: 0x17000DF0 RID: 3568
		// (get) Token: 0x06002A5C RID: 10844 RVA: 0x000FA248 File Offset: 0x000F8448
		// (set) Token: 0x06002A5D RID: 10845 RVA: 0x00016BA9 File Offset: 0x00014DA9
		public unsafe bool _Gate1Open_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(RoadCheckpoint.NativeFieldInfoPtr__Gate1Open_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(RoadCheckpoint.NativeFieldInfoPtr__Gate1Open_k__BackingField)) = value;
			}
		}

		// Token: 0x17000DF1 RID: 3569
		// (get) Token: 0x06002A5E RID: 10846 RVA: 0x000FA270 File Offset: 0x000F8470
		// (set) Token: 0x06002A5F RID: 10847 RVA: 0x00016BC4 File Offset: 0x00014DC4
		public unsafe bool _Gate2Open_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(RoadCheckpoint.NativeFieldInfoPtr__Gate2Open_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(RoadCheckpoint.NativeFieldInfoPtr__Gate2Open_k__BackingField)) = value;
			}
		}

		// Token: 0x17000DF2 RID: 3570
		// (get) Token: 0x06002A60 RID: 10848 RVA: 0x000FA298 File Offset: 0x000F8498
		// (set) Token: 0x06002A61 RID: 10849 RVA: 0x00016BDF File Offset: 0x00014DDF
		public unsafe List<NPC> AssignedNPCs
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(RoadCheckpoint.NativeFieldInfoPtr_AssignedNPCs);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<NPC>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(RoadCheckpoint.NativeFieldInfoPtr_AssignedNPCs), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000DF3 RID: 3571
		// (get) Token: 0x06002A62 RID: 10850 RVA: 0x000FA2C8 File Offset: 0x000F84C8
		// (set) Token: 0x06002A63 RID: 10851 RVA: 0x00016BFE File Offset: 0x00014DFE
		public unsafe EStealthLevel MaxStealthLevel
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(RoadCheckpoint.NativeFieldInfoPtr_MaxStealthLevel);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(RoadCheckpoint.NativeFieldInfoPtr_MaxStealthLevel)) = value;
			}
		}

		// Token: 0x17000DF4 RID: 3572
		// (get) Token: 0x06002A64 RID: 10852 RVA: 0x000FA2F0 File Offset: 0x000F84F0
		// (set) Token: 0x06002A65 RID: 10853 RVA: 0x00016C19 File Offset: 0x00014E19
		public unsafe bool OpenForNPCs
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(RoadCheckpoint.NativeFieldInfoPtr_OpenForNPCs);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(RoadCheckpoint.NativeFieldInfoPtr_OpenForNPCs)) = value;
			}
		}

		// Token: 0x17000DF5 RID: 3573
		// (get) Token: 0x06002A66 RID: 10854 RVA: 0x000FA318 File Offset: 0x000F8518
		// (set) Token: 0x06002A67 RID: 10855 RVA: 0x00016C34 File Offset: 0x00014E34
		public unsafe bool EnabledOnStart
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(RoadCheckpoint.NativeFieldInfoPtr_EnabledOnStart);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(RoadCheckpoint.NativeFieldInfoPtr_EnabledOnStart)) = value;
			}
		}

		// Token: 0x17000DF6 RID: 3574
		// (get) Token: 0x06002A68 RID: 10856 RVA: 0x000FA340 File Offset: 0x000F8540
		// (set) Token: 0x06002A69 RID: 10857 RVA: 0x00016C4F File Offset: 0x00014E4F
		public unsafe GameObject container
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(RoadCheckpoint.NativeFieldInfoPtr_container);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(RoadCheckpoint.NativeFieldInfoPtr_container), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000DF7 RID: 3575
		// (get) Token: 0x06002A6A RID: 10858 RVA: 0x000FA370 File Offset: 0x000F8570
		// (set) Token: 0x06002A6B RID: 10859 RVA: 0x00016C6E File Offset: 0x00014E6E
		public unsafe CarStopper Stopper1
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(RoadCheckpoint.NativeFieldInfoPtr_Stopper1);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CarStopper>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(RoadCheckpoint.NativeFieldInfoPtr_Stopper1), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000DF8 RID: 3576
		// (get) Token: 0x06002A6C RID: 10860 RVA: 0x000FA3A0 File Offset: 0x000F85A0
		// (set) Token: 0x06002A6D RID: 10861 RVA: 0x00016C8D File Offset: 0x00014E8D
		public unsafe CarStopper Stopper2
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(RoadCheckpoint.NativeFieldInfoPtr_Stopper2);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CarStopper>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(RoadCheckpoint.NativeFieldInfoPtr_Stopper2), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000DF9 RID: 3577
		// (get) Token: 0x06002A6E RID: 10862 RVA: 0x000FA3D0 File Offset: 0x000F85D0
		// (set) Token: 0x06002A6F RID: 10863 RVA: 0x00016CAC File Offset: 0x00014EAC
		public unsafe VehicleDetector SearchArea1
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(RoadCheckpoint.NativeFieldInfoPtr_SearchArea1);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<VehicleDetector>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(RoadCheckpoint.NativeFieldInfoPtr_SearchArea1), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000DFA RID: 3578
		// (get) Token: 0x06002A70 RID: 10864 RVA: 0x000FA400 File Offset: 0x000F8600
		// (set) Token: 0x06002A71 RID: 10865 RVA: 0x00016CCB File Offset: 0x00014ECB
		public unsafe VehicleDetector SearchArea2
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(RoadCheckpoint.NativeFieldInfoPtr_SearchArea2);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<VehicleDetector>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(RoadCheckpoint.NativeFieldInfoPtr_SearchArea2), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000DFB RID: 3579
		// (get) Token: 0x06002A72 RID: 10866 RVA: 0x000FA430 File Offset: 0x000F8630
		// (set) Token: 0x06002A73 RID: 10867 RVA: 0x00016CEA File Offset: 0x00014EEA
		public unsafe VehicleObstacle VehicleObstacle1
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(RoadCheckpoint.NativeFieldInfoPtr_VehicleObstacle1);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<VehicleObstacle>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(RoadCheckpoint.NativeFieldInfoPtr_VehicleObstacle1), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000DFC RID: 3580
		// (get) Token: 0x06002A74 RID: 10868 RVA: 0x000FA460 File Offset: 0x000F8660
		// (set) Token: 0x06002A75 RID: 10869 RVA: 0x00016D09 File Offset: 0x00014F09
		public unsafe VehicleObstacle VehicleObstacle2
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(RoadCheckpoint.NativeFieldInfoPtr_VehicleObstacle2);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<VehicleObstacle>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(RoadCheckpoint.NativeFieldInfoPtr_VehicleObstacle2), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000DFD RID: 3581
		// (get) Token: 0x06002A76 RID: 10870 RVA: 0x000FA490 File Offset: 0x000F8690
		// (set) Token: 0x06002A77 RID: 10871 RVA: 0x00016D28 File Offset: 0x00014F28
		public unsafe VehicleDetector NPCVehicleDetectionArea1
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(RoadCheckpoint.NativeFieldInfoPtr_NPCVehicleDetectionArea1);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<VehicleDetector>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(RoadCheckpoint.NativeFieldInfoPtr_NPCVehicleDetectionArea1), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000DFE RID: 3582
		// (get) Token: 0x06002A78 RID: 10872 RVA: 0x000FA4C0 File Offset: 0x000F86C0
		// (set) Token: 0x06002A79 RID: 10873 RVA: 0x00016D47 File Offset: 0x00014F47
		public unsafe VehicleDetector NPCVehicleDetectionArea2
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(RoadCheckpoint.NativeFieldInfoPtr_NPCVehicleDetectionArea2);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<VehicleDetector>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(RoadCheckpoint.NativeFieldInfoPtr_NPCVehicleDetectionArea2), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000DFF RID: 3583
		// (get) Token: 0x06002A7A RID: 10874 RVA: 0x000FA4F0 File Offset: 0x000F86F0
		// (set) Token: 0x06002A7B RID: 10875 RVA: 0x00016D66 File Offset: 0x00014F66
		public unsafe VehicleDetector ImmediateVehicleDetector
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(RoadCheckpoint.NativeFieldInfoPtr_ImmediateVehicleDetector);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<VehicleDetector>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(RoadCheckpoint.NativeFieldInfoPtr_ImmediateVehicleDetector), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E00 RID: 3584
		// (get) Token: 0x06002A7C RID: 10876 RVA: 0x000FA520 File Offset: 0x000F8720
		// (set) Token: 0x06002A7D RID: 10877 RVA: 0x00016D85 File Offset: 0x00014F85
		public unsafe Il2CppReferenceArray<Rigidbody> TrafficCones
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(RoadCheckpoint.NativeFieldInfoPtr_TrafficCones);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Rigidbody>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(RoadCheckpoint.NativeFieldInfoPtr_TrafficCones), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E01 RID: 3585
		// (get) Token: 0x06002A7E RID: 10878 RVA: 0x000FA550 File Offset: 0x000F8750
		// (set) Token: 0x06002A7F RID: 10879 RVA: 0x00016DA4 File Offset: 0x00014FA4
		public unsafe Il2CppReferenceArray<Transform> StandPoints
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(RoadCheckpoint.NativeFieldInfoPtr_StandPoints);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Transform>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(RoadCheckpoint.NativeFieldInfoPtr_StandPoints), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E02 RID: 3586
		// (get) Token: 0x06002A80 RID: 10880 RVA: 0x000FA580 File Offset: 0x000F8780
		// (set) Token: 0x06002A81 RID: 10881 RVA: 0x00016DC3 File Offset: 0x00014FC3
		public unsafe Dictionary<Rigidbody, Il2CppSystem.Tuple<Vector3, Quaternion>> trafficConeOriginalTransforms
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(RoadCheckpoint.NativeFieldInfoPtr_trafficConeOriginalTransforms);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<Rigidbody, Il2CppSystem.Tuple<Vector3, Quaternion>>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(RoadCheckpoint.NativeFieldInfoPtr_trafficConeOriginalTransforms), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E03 RID: 3587
		// (get) Token: 0x06002A82 RID: 10882 RVA: 0x000FA5B0 File Offset: 0x000F87B0
		// (set) Token: 0x06002A83 RID: 10883 RVA: 0x00016DE2 File Offset: 0x00014FE2
		public unsafe float timeSinceGate1Open
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(RoadCheckpoint.NativeFieldInfoPtr_timeSinceGate1Open);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(RoadCheckpoint.NativeFieldInfoPtr_timeSinceGate1Open)) = value;
			}
		}

		// Token: 0x17000E04 RID: 3588
		// (get) Token: 0x06002A84 RID: 10884 RVA: 0x000FA5D8 File Offset: 0x000F87D8
		// (set) Token: 0x06002A85 RID: 10885 RVA: 0x00016DFD File Offset: 0x00014FFD
		public unsafe bool vehicleDetectedSinceGate1Open
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(RoadCheckpoint.NativeFieldInfoPtr_vehicleDetectedSinceGate1Open);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(RoadCheckpoint.NativeFieldInfoPtr_vehicleDetectedSinceGate1Open)) = value;
			}
		}

		// Token: 0x17000E05 RID: 3589
		// (get) Token: 0x06002A86 RID: 10886 RVA: 0x000FA600 File Offset: 0x000F8800
		// (set) Token: 0x06002A87 RID: 10887 RVA: 0x00016E18 File Offset: 0x00015018
		public unsafe float timeSinceGate2Open
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(RoadCheckpoint.NativeFieldInfoPtr_timeSinceGate2Open);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(RoadCheckpoint.NativeFieldInfoPtr_timeSinceGate2Open)) = value;
			}
		}

		// Token: 0x17000E06 RID: 3590
		// (get) Token: 0x06002A88 RID: 10888 RVA: 0x000FA628 File Offset: 0x000F8828
		// (set) Token: 0x06002A89 RID: 10889 RVA: 0x00016E33 File Offset: 0x00015033
		public unsafe bool vehicleDetectedSinceGate2Open
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(RoadCheckpoint.NativeFieldInfoPtr_vehicleDetectedSinceGate2Open);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(RoadCheckpoint.NativeFieldInfoPtr_vehicleDetectedSinceGate2Open)) = value;
			}
		}

		// Token: 0x17000E07 RID: 3591
		// (get) Token: 0x06002A8A RID: 10890 RVA: 0x000FA650 File Offset: 0x000F8850
		// (set) Token: 0x06002A8B RID: 10891 RVA: 0x00016E4E File Offset: 0x0001504E
		public unsafe UnityEvent<Player> onPlayerWalkThrough
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(RoadCheckpoint.NativeFieldInfoPtr_onPlayerWalkThrough);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent<Player>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(RoadCheckpoint.NativeFieldInfoPtr_onPlayerWalkThrough), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E08 RID: 3592
		// (get) Token: 0x06002A8C RID: 10892 RVA: 0x000FA680 File Offset: 0x000F8880
		// (set) Token: 0x06002A8D RID: 10893 RVA: 0x00016E6D File Offset: 0x0001506D
		public unsafe SyncVar<bool> syncVar____Gate1Open_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(RoadCheckpoint.NativeFieldInfoPtr_syncVar____Gate1Open_k__BackingField);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SyncVar<bool>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(RoadCheckpoint.NativeFieldInfoPtr_syncVar____Gate1Open_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E09 RID: 3593
		// (get) Token: 0x06002A8E RID: 10894 RVA: 0x000FA6B0 File Offset: 0x000F88B0
		// (set) Token: 0x06002A8F RID: 10895 RVA: 0x00016E8C File Offset: 0x0001508C
		public unsafe SyncVar<bool> syncVar____Gate2Open_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(RoadCheckpoint.NativeFieldInfoPtr_syncVar____Gate2Open_k__BackingField);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SyncVar<bool>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(RoadCheckpoint.NativeFieldInfoPtr_syncVar____Gate2Open_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E0A RID: 3594
		// (get) Token: 0x06002A90 RID: 10896 RVA: 0x000FA6E0 File Offset: 0x000F88E0
		// (set) Token: 0x06002A91 RID: 10897 RVA: 0x00016EAB File Offset: 0x000150AB
		public unsafe bool field_Private_Boolean_0
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(RoadCheckpoint.NativeFieldInfoPtr_field_Private_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(RoadCheckpoint.NativeFieldInfoPtr_field_Private_Boolean_0)) = value;
			}
		}

		// Token: 0x17000E0B RID: 3595
		// (get) Token: 0x06002A92 RID: 10898 RVA: 0x000FA708 File Offset: 0x000F8908
		// (set) Token: 0x06002A93 RID: 10899 RVA: 0x00016EC6 File Offset: 0x000150C6
		public unsafe bool field_Private_Boolean_1
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(RoadCheckpoint.NativeFieldInfoPtr_field_Private_Boolean_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(RoadCheckpoint.NativeFieldInfoPtr_field_Private_Boolean_1)) = value;
			}
		}

		// Token: 0x04001C06 RID: 7174
		private static readonly System.IntPtr NativeFieldInfoPtr_MAX_TIME_OPEN;

		// Token: 0x04001C07 RID: 7175
		private static readonly System.IntPtr NativeFieldInfoPtr__ActivationState_k__BackingField;

		// Token: 0x04001C08 RID: 7176
		private static readonly System.IntPtr NativeFieldInfoPtr_appliedState;

		// Token: 0x04001C09 RID: 7177
		private static readonly System.IntPtr NativeFieldInfoPtr__Gate1Open_k__BackingField;

		// Token: 0x04001C0A RID: 7178
		private static readonly System.IntPtr NativeFieldInfoPtr__Gate2Open_k__BackingField;

		// Token: 0x04001C0B RID: 7179
		private static readonly System.IntPtr NativeFieldInfoPtr_AssignedNPCs;

		// Token: 0x04001C0C RID: 7180
		private static readonly System.IntPtr NativeFieldInfoPtr_MaxStealthLevel;

		// Token: 0x04001C0D RID: 7181
		private static readonly System.IntPtr NativeFieldInfoPtr_OpenForNPCs;

		// Token: 0x04001C0E RID: 7182
		private static readonly System.IntPtr NativeFieldInfoPtr_EnabledOnStart;

		// Token: 0x04001C0F RID: 7183
		private static readonly System.IntPtr NativeFieldInfoPtr_container;

		// Token: 0x04001C10 RID: 7184
		private static readonly System.IntPtr NativeFieldInfoPtr_Stopper1;

		// Token: 0x04001C11 RID: 7185
		private static readonly System.IntPtr NativeFieldInfoPtr_Stopper2;

		// Token: 0x04001C12 RID: 7186
		private static readonly System.IntPtr NativeFieldInfoPtr_SearchArea1;

		// Token: 0x04001C13 RID: 7187
		private static readonly System.IntPtr NativeFieldInfoPtr_SearchArea2;

		// Token: 0x04001C14 RID: 7188
		private static readonly System.IntPtr NativeFieldInfoPtr_VehicleObstacle1;

		// Token: 0x04001C15 RID: 7189
		private static readonly System.IntPtr NativeFieldInfoPtr_VehicleObstacle2;

		// Token: 0x04001C16 RID: 7190
		private static readonly System.IntPtr NativeFieldInfoPtr_NPCVehicleDetectionArea1;

		// Token: 0x04001C17 RID: 7191
		private static readonly System.IntPtr NativeFieldInfoPtr_NPCVehicleDetectionArea2;

		// Token: 0x04001C18 RID: 7192
		private static readonly System.IntPtr NativeFieldInfoPtr_ImmediateVehicleDetector;

		// Token: 0x04001C19 RID: 7193
		private static readonly System.IntPtr NativeFieldInfoPtr_TrafficCones;

		// Token: 0x04001C1A RID: 7194
		private static readonly System.IntPtr NativeFieldInfoPtr_StandPoints;

		// Token: 0x04001C1B RID: 7195
		private static readonly System.IntPtr NativeFieldInfoPtr_trafficConeOriginalTransforms;

		// Token: 0x04001C1C RID: 7196
		private static readonly System.IntPtr NativeFieldInfoPtr_timeSinceGate1Open;

		// Token: 0x04001C1D RID: 7197
		private static readonly System.IntPtr NativeFieldInfoPtr_vehicleDetectedSinceGate1Open;

		// Token: 0x04001C1E RID: 7198
		private static readonly System.IntPtr NativeFieldInfoPtr_timeSinceGate2Open;

		// Token: 0x04001C1F RID: 7199
		private static readonly System.IntPtr NativeFieldInfoPtr_vehicleDetectedSinceGate2Open;

		// Token: 0x04001C20 RID: 7200
		private static readonly System.IntPtr NativeFieldInfoPtr_onPlayerWalkThrough;

		// Token: 0x04001C21 RID: 7201
		private static readonly System.IntPtr NativeFieldInfoPtr_syncVar____Gate1Open_k__BackingField;

		// Token: 0x04001C22 RID: 7202
		private static readonly System.IntPtr NativeFieldInfoPtr_syncVar____Gate2Open_k__BackingField;

		// Token: 0x04001C23 RID: 7203
		private static readonly System.IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

		// Token: 0x04001C24 RID: 7204
		private static readonly System.IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

		// Token: 0x04001C25 RID: 7205
		private static readonly System.IntPtr NativeMethodInfoPtr_get_ActivationState_Public_get_ECheckpointState_0;

		// Token: 0x04001C26 RID: 7206
		private static readonly System.IntPtr NativeMethodInfoPtr_set_ActivationState_Protected_set_Void_ECheckpointState_0;

		// Token: 0x04001C27 RID: 7207
		private static readonly System.IntPtr NativeMethodInfoPtr_get_Gate1Open_Public_get_Boolean_0;

		// Token: 0x04001C28 RID: 7208
		private static readonly System.IntPtr NativeMethodInfoPtr_set_Gate1Open_Protected_set_Void_Boolean_0;

		// Token: 0x04001C29 RID: 7209
		private static readonly System.IntPtr NativeMethodInfoPtr_get_Gate2Open_Public_get_Boolean_0;

		// Token: 0x04001C2A RID: 7210
		private static readonly System.IntPtr NativeMethodInfoPtr_set_Gate2Open_Protected_set_Void_Boolean_0;

		// Token: 0x04001C2B RID: 7211
		private static readonly System.IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;

		// Token: 0x04001C2C RID: 7212
		private static readonly System.IntPtr NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_1;

		// Token: 0x04001C2D RID: 7213
		private static readonly System.IntPtr NativeMethodInfoPtr_ApplyState_Protected_Virtual_New_Void_1;

		// Token: 0x04001C2E RID: 7214
		private static readonly System.IntPtr NativeMethodInfoPtr_Enable_Public_Void_NetworkConnection_0;

		// Token: 0x04001C2F RID: 7215
		private static readonly System.IntPtr NativeMethodInfoPtr_Disable_Public_Void_0;

		// Token: 0x04001C30 RID: 7216
		private static readonly System.IntPtr NativeMethodInfoPtr_SetGate1Open_Public_Void_Boolean_0;

		// Token: 0x04001C31 RID: 7217
		private static readonly System.IntPtr NativeMethodInfoPtr_SetGate2Open_Public_Void_Boolean_0;

		// Token: 0x04001C32 RID: 7218
		private static readonly System.IntPtr NativeMethodInfoPtr_ResetTrafficCones_Private_Void_0;

		// Token: 0x04001C33 RID: 7219
		private static readonly System.IntPtr NativeMethodInfoPtr_PlayerDetected_Public_Void_Player_0;

		// Token: 0x04001C34 RID: 7220
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04001C35 RID: 7221
		private static readonly System.IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

		// Token: 0x04001C36 RID: 7222
		private static readonly System.IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

		// Token: 0x04001C37 RID: 7223
		private static readonly System.IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

		// Token: 0x04001C38 RID: 7224
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcWriter___Observers_Enable_328543758_Private_Void_NetworkConnection_0;

		// Token: 0x04001C39 RID: 7225
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcLogic___Enable_328543758_Public_Void_NetworkConnection_0;

		// Token: 0x04001C3A RID: 7226
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcReader___Observers_Enable_328543758_Private_Void_PooledReader_Channel_0;

		// Token: 0x04001C3B RID: 7227
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcWriter___Target_Enable_328543758_Private_Void_NetworkConnection_0;

		// Token: 0x04001C3C RID: 7228
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcReader___Target_Enable_328543758_Private_Void_PooledReader_Channel_0;

		// Token: 0x04001C3D RID: 7229
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcWriter___Observers_Disable_2166136261_Private_Void_0;

		// Token: 0x04001C3E RID: 7230
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcLogic___Disable_2166136261_Public_Void_0;

		// Token: 0x04001C3F RID: 7231
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcReader___Observers_Disable_2166136261_Private_Void_PooledReader_Channel_0;

		// Token: 0x04001C40 RID: 7232
		private static readonly System.IntPtr NativeMethodInfoPtr_sync___get_value__Gate1Open_k__BackingField_Public_get_Boolean_0;

		// Token: 0x04001C41 RID: 7233
		private static readonly System.IntPtr NativeMethodInfoPtr_sync___set_value__Gate1Open_k__BackingField_Public_set_Void_Boolean_Boolean_0;

		// Token: 0x04001C42 RID: 7234
		private static readonly System.IntPtr NativeMethodInfoPtr_ReadSyncVar___ScheduleOne_Police_RoadCheckpoint_Public_Virtual_Boolean_PooledReader_UInt32_Boolean_0;

		// Token: 0x04001C43 RID: 7235
		private static readonly System.IntPtr NativeMethodInfoPtr_sync___get_value__Gate2Open_k__BackingField_Public_get_Boolean_0;

		// Token: 0x04001C44 RID: 7236
		private static readonly System.IntPtr NativeMethodInfoPtr_sync___set_value__Gate2Open_k__BackingField_Public_set_Void_Boolean_Boolean_0;

		// Token: 0x04001C45 RID: 7237
		private static readonly System.IntPtr NativeMethodInfoPtr_Method_Protected_Virtual_New_Void_0;

		// Token: 0x02000911 RID: 2321
		[OriginalName("Assembly-CSharp.dll", "", "ECheckpointState")]
		public enum ECheckpointState
		{
			// Token: 0x0400884A RID: 34890
			Disabled,
			// Token: 0x0400884B RID: 34891
			Enabled
		}
	}
}
