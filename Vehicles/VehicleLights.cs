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
using Il2CppScheduleOne.Vehicles.AI;
using Il2CppSystem.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace Il2CppScheduleOne.Vehicles
{
	// Token: 0x02000511 RID: 1297
	public class VehicleLights : NetworkBehaviour
	{
		// Token: 0x06007155 RID: 29013 RVA: 0x001F5E78 File Offset: 0x001F4078
		// Note: this type is marked as 'beforefieldinit'.
		static VehicleLights()
		{
			Il2CppClassPointerStore<VehicleLights>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Vehicles", "VehicleLights");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VehicleLights>.NativeClassPtr);
			VehicleLights.NativeFieldInfoPtr_vehicle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleLights>.NativeClassPtr, "vehicle");
			VehicleLights.NativeFieldInfoPtr_hasHeadLights = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleLights>.NativeClassPtr, "hasHeadLights");
			VehicleLights.NativeFieldInfoPtr_headLightMeshes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleLights>.NativeClassPtr, "headLightMeshes");
			VehicleLights.NativeFieldInfoPtr_headLightSources = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleLights>.NativeClassPtr, "headLightSources");
			VehicleLights.NativeFieldInfoPtr_headlightMat_On = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleLights>.NativeClassPtr, "headlightMat_On");
			VehicleLights.NativeFieldInfoPtr_headLightMat_Off = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleLights>.NativeClassPtr, "headLightMat_Off");
			VehicleLights.NativeFieldInfoPtr__headLightsOn_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleLights>.NativeClassPtr, "<headLightsOn>k__BackingField");
			VehicleLights.NativeFieldInfoPtr_headLightsApplied = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleLights>.NativeClassPtr, "headLightsApplied");
			VehicleLights.NativeFieldInfoPtr_hasBrakeLights = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleLights>.NativeClassPtr, "hasBrakeLights");
			VehicleLights.NativeFieldInfoPtr_brakeLightMeshes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleLights>.NativeClassPtr, "brakeLightMeshes");
			VehicleLights.NativeFieldInfoPtr_brakeLightSources = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleLights>.NativeClassPtr, "brakeLightSources");
			VehicleLights.NativeFieldInfoPtr_brakeLightMat_On = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleLights>.NativeClassPtr, "brakeLightMat_On");
			VehicleLights.NativeFieldInfoPtr_brakeLightMat_Off = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleLights>.NativeClassPtr, "brakeLightMat_Off");
			VehicleLights.NativeFieldInfoPtr_brakeLightMat_Ambient = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleLights>.NativeClassPtr, "brakeLightMat_Ambient");
			VehicleLights.NativeFieldInfoPtr_brakeLightsOn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleLights>.NativeClassPtr, "brakeLightsOn");
			VehicleLights.NativeFieldInfoPtr_brakeLightsApplied = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleLights>.NativeClassPtr, "brakeLightsApplied");
			VehicleLights.NativeFieldInfoPtr_hasReverseLights = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleLights>.NativeClassPtr, "hasReverseLights");
			VehicleLights.NativeFieldInfoPtr_reverseLightMeshes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleLights>.NativeClassPtr, "reverseLightMeshes");
			VehicleLights.NativeFieldInfoPtr_reverseLightSources = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleLights>.NativeClassPtr, "reverseLightSources");
			VehicleLights.NativeFieldInfoPtr_reverseLightMat_On = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleLights>.NativeClassPtr, "reverseLightMat_On");
			VehicleLights.NativeFieldInfoPtr_reverseLightMat_Off = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleLights>.NativeClassPtr, "reverseLightMat_Off");
			VehicleLights.NativeFieldInfoPtr_reverseLightsOn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleLights>.NativeClassPtr, "reverseLightsOn");
			VehicleLights.NativeFieldInfoPtr_reverseLightsApplied = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleLights>.NativeClassPtr, "reverseLightsApplied");
			VehicleLights.NativeFieldInfoPtr_onHeadlightsOn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleLights>.NativeClassPtr, "onHeadlightsOn");
			VehicleLights.NativeFieldInfoPtr_onHeadlightsOff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleLights>.NativeClassPtr, "onHeadlightsOff");
			VehicleLights.NativeFieldInfoPtr_brakesAppliedHistory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleLights>.NativeClassPtr, "brakesAppliedHistory");
			VehicleLights.NativeFieldInfoPtr_agent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleLights>.NativeClassPtr, "agent");
			VehicleLights.NativeFieldInfoPtr_syncVar____headLightsOn_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleLights>.NativeClassPtr, "syncVar___<headLightsOn>k__BackingField");
			VehicleLights.NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleLights>.NativeClassPtr, "NetworkInitialize___EarlyScheduleOne.Vehicles.VehicleLightsAssembly-CSharp.dll_Excuted");
			VehicleLights.NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleLights>.NativeClassPtr, "NetworkInitialize__LateScheduleOne.Vehicles.VehicleLightsAssembly-CSharp.dll_Excuted");
			VehicleLights.NativeMethodInfoPtr_get_headLightsOn_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleLights>.NativeClassPtr, 100677692);
			VehicleLights.NativeMethodInfoPtr_set_headLightsOn_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleLights>.NativeClassPtr, 100677693);
			VehicleLights.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleLights>.NativeClassPtr, 100677694);
			VehicleLights.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleLights>.NativeClassPtr, 100677695);
			VehicleLights.NativeMethodInfoPtr_FixedUpdate_Protected_Virtual_New_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleLights>.NativeClassPtr, 100677696);
			VehicleLights.NativeMethodInfoPtr_LateUpdate_Protected_Virtual_New_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleLights>.NativeClassPtr, 100677697);
			VehicleLights.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleLights>.NativeClassPtr, 100677698);
			VehicleLights.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleLights>.NativeClassPtr, 100677699);
			VehicleLights.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleLights>.NativeClassPtr, 100677700);
			VehicleLights.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleLights>.NativeClassPtr, 100677701);
			VehicleLights.NativeMethodInfoPtr_RpcWriter___Server_set_headLightsOn_1140765316_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleLights>.NativeClassPtr, 100677702);
			VehicleLights.NativeMethodInfoPtr_RpcLogic___set_headLightsOn_1140765316_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleLights>.NativeClassPtr, 100677703);
			VehicleLights.NativeMethodInfoPtr_RpcReader___Server_set_headLightsOn_1140765316_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleLights>.NativeClassPtr, 100677704);
			VehicleLights.NativeMethodInfoPtr_sync___get_value__headLightsOn_k__BackingField_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleLights>.NativeClassPtr, 100677705);
			VehicleLights.NativeMethodInfoPtr_sync___set_value__headLightsOn_k__BackingField_Public_set_Void_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleLights>.NativeClassPtr, 100677706);
			VehicleLights.NativeMethodInfoPtr_ReadSyncVar___ScheduleOne_Vehicles_VehicleLights_Public_Virtual_Boolean_PooledReader_UInt32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleLights>.NativeClassPtr, 100677707);
			VehicleLights.NativeMethodInfoPtr_Method_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleLights>.NativeClassPtr, 100677708);
		}

		// Token: 0x17002215 RID: 8725
		// (get) Token: 0x06007156 RID: 29014 RVA: 0x001F6254 File Offset: 0x001F4454
		// (set) Token: 0x06007157 RID: 29015 RVA: 0x001F6290 File Offset: 0x001F4490
		public unsafe bool headLightsOn
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr obj = IL2CPP.il2cpp_runtime_invoke(VehicleLights.NativeMethodInfoPtr_get_headLightsOn_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 224862, RefRangeEnd = 224864, XrefRangeStart = 224840, XrefRangeEnd = 224862, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleLights.NativeMethodInfoPtr_set_headLightsOn_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x06007158 RID: 29016 RVA: 0x001F62D0 File Offset: 0x001F44D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 224864, XrefRangeEnd = 224868, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VehicleLights.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007159 RID: 29017 RVA: 0x001F630C File Offset: 0x001F450C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 224868, XrefRangeEnd = 224894, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VehicleLights.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_1), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600715A RID: 29018 RVA: 0x001F6348 File Offset: 0x001F4548
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 224894, XrefRangeEnd = 224912, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void FixedUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VehicleLights.NativeMethodInfoPtr_FixedUpdate_Protected_Virtual_New_Void_1), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600715B RID: 29019 RVA: 0x001F6384 File Offset: 0x001F4584
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 224912, XrefRangeEnd = 224934, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void LateUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VehicleLights.NativeMethodInfoPtr_LateUpdate_Protected_Virtual_New_Void_1), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600715C RID: 29020 RVA: 0x001F63C0 File Offset: 0x001F45C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 224934, XrefRangeEnd = 224942, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe VehicleLights() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VehicleLights>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleLights.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600715D RID: 29021 RVA: 0x001F63FC File Offset: 0x001F45FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 224942, XrefRangeEnd = 224965, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void NetworkInitialize___Early()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VehicleLights.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600715E RID: 29022 RVA: 0x001F6438 File Offset: 0x001F4638
		[CallerCount(0)]
		public unsafe virtual void NetworkInitialize__Late()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VehicleLights.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600715F RID: 29023 RVA: 0x001F6474 File Offset: 0x001F4674
		[CallerCount(0)]
		public unsafe override void NetworkInitializeIfDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VehicleLights.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007160 RID: 29024 RVA: 0x001F64B0 File Offset: 0x001F46B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 224965, XrefRangeEnd = 224975, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_set_headLightsOn_1140765316(bool value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref value;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleLights.NativeMethodInfoPtr_RpcWriter___Server_set_headLightsOn_1140765316_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007161 RID: 29025 RVA: 0x001F64F0 File Offset: 0x001F46F0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 224982, RefRangeEnd = 224985, XrefRangeStart = 224975, XrefRangeEnd = 224982, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___set_headLightsOn_1140765316(bool value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref value;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleLights.NativeMethodInfoPtr_RpcLogic___set_headLightsOn_1140765316_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007162 RID: 29026 RVA: 0x001F6530 File Offset: 0x001F4730
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 224985, XrefRangeEnd = 224988, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_set_headLightsOn_1140765316(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleLights.NativeMethodInfoPtr_RpcReader___Server_set_headLightsOn_1140765316_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x17002216 RID: 8726
		// (get) Token: 0x06007163 RID: 29027 RVA: 0x001F6594 File Offset: 0x001F4794
		// (set) Token: 0x06007164 RID: 29028 RVA: 0x001F65D0 File Offset: 0x001F47D0
		public unsafe bool SyncAccessor_<headLightsOn>k__BackingField
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr obj = IL2CPP.il2cpp_runtime_invoke(VehicleLights.NativeMethodInfoPtr_sync___get_value__headLightsOn_k__BackingField_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 224996, RefRangeEnd = 224997, XrefRangeStart = 224988, XrefRangeEnd = 224996, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleLights.NativeMethodInfoPtr_sync___set_value__headLightsOn_k__BackingField_Public_set_Void_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x06007165 RID: 29029 RVA: 0x001F661C File Offset: 0x001F481C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 224997, XrefRangeEnd = 225000, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool ReadSyncVar___ScheduleOne_Vehicles_VehicleLights(PooledReader PooledReader0, uint UInt321, bool Boolean2)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref UInt321;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref Boolean2;
			IntPtr returnedException;
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VehicleLights.NativeMethodInfoPtr_ReadSyncVar___ScheduleOne_Vehicles_VehicleLights_Public_Virtual_Boolean_PooledReader_UInt32_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06007166 RID: 29030 RVA: 0x001F6690 File Offset: 0x001F4890
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 225000, XrefRangeEnd = 225004, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Method_Protected_Virtual_New_Void_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VehicleLights.NativeMethodInfoPtr_Method_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007167 RID: 29031 RVA: 0x000356A2 File Offset: 0x000338A2
		public VehicleLights(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170021F7 RID: 8695
		// (get) Token: 0x06007168 RID: 29032 RVA: 0x001F66CC File Offset: 0x001F48CC
		// (set) Token: 0x06007169 RID: 29033 RVA: 0x000356AB File Offset: 0x000338AB
		public unsafe LandVehicle vehicle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleLights.NativeFieldInfoPtr_vehicle);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LandVehicle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleLights.NativeFieldInfoPtr_vehicle), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170021F8 RID: 8696
		// (get) Token: 0x0600716A RID: 29034 RVA: 0x001F66FC File Offset: 0x001F48FC
		// (set) Token: 0x0600716B RID: 29035 RVA: 0x000356CA File Offset: 0x000338CA
		public unsafe bool hasHeadLights
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleLights.NativeFieldInfoPtr_hasHeadLights);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleLights.NativeFieldInfoPtr_hasHeadLights)) = value;
			}
		}

		// Token: 0x170021F9 RID: 8697
		// (get) Token: 0x0600716C RID: 29036 RVA: 0x001F6724 File Offset: 0x001F4924
		// (set) Token: 0x0600716D RID: 29037 RVA: 0x000356E5 File Offset: 0x000338E5
		public unsafe Il2CppReferenceArray<MeshRenderer> headLightMeshes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleLights.NativeFieldInfoPtr_headLightMeshes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<MeshRenderer>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleLights.NativeFieldInfoPtr_headLightMeshes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170021FA RID: 8698
		// (get) Token: 0x0600716E RID: 29038 RVA: 0x001F6754 File Offset: 0x001F4954
		// (set) Token: 0x0600716F RID: 29039 RVA: 0x00035704 File Offset: 0x00033904
		public unsafe Il2CppReferenceArray<OptimizedLight> headLightSources
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleLights.NativeFieldInfoPtr_headLightSources);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<OptimizedLight>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleLights.NativeFieldInfoPtr_headLightSources), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170021FB RID: 8699
		// (get) Token: 0x06007170 RID: 29040 RVA: 0x001F6784 File Offset: 0x001F4984
		// (set) Token: 0x06007171 RID: 29041 RVA: 0x00035723 File Offset: 0x00033923
		public unsafe Material headlightMat_On
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleLights.NativeFieldInfoPtr_headlightMat_On);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleLights.NativeFieldInfoPtr_headlightMat_On), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170021FC RID: 8700
		// (get) Token: 0x06007172 RID: 29042 RVA: 0x001F67B4 File Offset: 0x001F49B4
		// (set) Token: 0x06007173 RID: 29043 RVA: 0x00035742 File Offset: 0x00033942
		public unsafe Material headLightMat_Off
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleLights.NativeFieldInfoPtr_headLightMat_Off);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleLights.NativeFieldInfoPtr_headLightMat_Off), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170021FD RID: 8701
		// (get) Token: 0x06007174 RID: 29044 RVA: 0x001F67E4 File Offset: 0x001F49E4
		// (set) Token: 0x06007175 RID: 29045 RVA: 0x00035761 File Offset: 0x00033961
		public unsafe bool _headLightsOn_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleLights.NativeFieldInfoPtr__headLightsOn_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleLights.NativeFieldInfoPtr__headLightsOn_k__BackingField)) = value;
			}
		}

		// Token: 0x170021FE RID: 8702
		// (get) Token: 0x06007176 RID: 29046 RVA: 0x001F680C File Offset: 0x001F4A0C
		// (set) Token: 0x06007177 RID: 29047 RVA: 0x0003577C File Offset: 0x0003397C
		public unsafe bool headLightsApplied
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleLights.NativeFieldInfoPtr_headLightsApplied);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleLights.NativeFieldInfoPtr_headLightsApplied)) = value;
			}
		}

		// Token: 0x170021FF RID: 8703
		// (get) Token: 0x06007178 RID: 29048 RVA: 0x001F6834 File Offset: 0x001F4A34
		// (set) Token: 0x06007179 RID: 29049 RVA: 0x00035797 File Offset: 0x00033997
		public unsafe bool hasBrakeLights
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleLights.NativeFieldInfoPtr_hasBrakeLights);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleLights.NativeFieldInfoPtr_hasBrakeLights)) = value;
			}
		}

		// Token: 0x17002200 RID: 8704
		// (get) Token: 0x0600717A RID: 29050 RVA: 0x001F685C File Offset: 0x001F4A5C
		// (set) Token: 0x0600717B RID: 29051 RVA: 0x000357B2 File Offset: 0x000339B2
		public unsafe Il2CppReferenceArray<MeshRenderer> brakeLightMeshes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleLights.NativeFieldInfoPtr_brakeLightMeshes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<MeshRenderer>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleLights.NativeFieldInfoPtr_brakeLightMeshes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002201 RID: 8705
		// (get) Token: 0x0600717C RID: 29052 RVA: 0x001F688C File Offset: 0x001F4A8C
		// (set) Token: 0x0600717D RID: 29053 RVA: 0x000357D1 File Offset: 0x000339D1
		public unsafe Il2CppReferenceArray<Light> brakeLightSources
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleLights.NativeFieldInfoPtr_brakeLightSources);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Light>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleLights.NativeFieldInfoPtr_brakeLightSources), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002202 RID: 8706
		// (get) Token: 0x0600717E RID: 29054 RVA: 0x001F68BC File Offset: 0x001F4ABC
		// (set) Token: 0x0600717F RID: 29055 RVA: 0x000357F0 File Offset: 0x000339F0
		public unsafe Material brakeLightMat_On
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleLights.NativeFieldInfoPtr_brakeLightMat_On);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleLights.NativeFieldInfoPtr_brakeLightMat_On), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002203 RID: 8707
		// (get) Token: 0x06007180 RID: 29056 RVA: 0x001F68EC File Offset: 0x001F4AEC
		// (set) Token: 0x06007181 RID: 29057 RVA: 0x0003580F File Offset: 0x00033A0F
		public unsafe Material brakeLightMat_Off
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleLights.NativeFieldInfoPtr_brakeLightMat_Off);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleLights.NativeFieldInfoPtr_brakeLightMat_Off), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002204 RID: 8708
		// (get) Token: 0x06007182 RID: 29058 RVA: 0x001F691C File Offset: 0x001F4B1C
		// (set) Token: 0x06007183 RID: 29059 RVA: 0x0003582E File Offset: 0x00033A2E
		public unsafe Material brakeLightMat_Ambient
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleLights.NativeFieldInfoPtr_brakeLightMat_Ambient);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleLights.NativeFieldInfoPtr_brakeLightMat_Ambient), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002205 RID: 8709
		// (get) Token: 0x06007184 RID: 29060 RVA: 0x001F694C File Offset: 0x001F4B4C
		// (set) Token: 0x06007185 RID: 29061 RVA: 0x0003584D File Offset: 0x00033A4D
		public unsafe bool brakeLightsOn
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleLights.NativeFieldInfoPtr_brakeLightsOn);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleLights.NativeFieldInfoPtr_brakeLightsOn)) = value;
			}
		}

		// Token: 0x17002206 RID: 8710
		// (get) Token: 0x06007186 RID: 29062 RVA: 0x001F6974 File Offset: 0x001F4B74
		// (set) Token: 0x06007187 RID: 29063 RVA: 0x00035868 File Offset: 0x00033A68
		public unsafe bool brakeLightsApplied
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleLights.NativeFieldInfoPtr_brakeLightsApplied);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleLights.NativeFieldInfoPtr_brakeLightsApplied)) = value;
			}
		}

		// Token: 0x17002207 RID: 8711
		// (get) Token: 0x06007188 RID: 29064 RVA: 0x001F699C File Offset: 0x001F4B9C
		// (set) Token: 0x06007189 RID: 29065 RVA: 0x00035883 File Offset: 0x00033A83
		public unsafe bool hasReverseLights
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleLights.NativeFieldInfoPtr_hasReverseLights);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleLights.NativeFieldInfoPtr_hasReverseLights)) = value;
			}
		}

		// Token: 0x17002208 RID: 8712
		// (get) Token: 0x0600718A RID: 29066 RVA: 0x001F69C4 File Offset: 0x001F4BC4
		// (set) Token: 0x0600718B RID: 29067 RVA: 0x0003589E File Offset: 0x00033A9E
		public unsafe Il2CppReferenceArray<MeshRenderer> reverseLightMeshes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleLights.NativeFieldInfoPtr_reverseLightMeshes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<MeshRenderer>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleLights.NativeFieldInfoPtr_reverseLightMeshes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002209 RID: 8713
		// (get) Token: 0x0600718C RID: 29068 RVA: 0x001F69F4 File Offset: 0x001F4BF4
		// (set) Token: 0x0600718D RID: 29069 RVA: 0x000358BD File Offset: 0x00033ABD
		public unsafe Il2CppReferenceArray<Light> reverseLightSources
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleLights.NativeFieldInfoPtr_reverseLightSources);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Light>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleLights.NativeFieldInfoPtr_reverseLightSources), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700220A RID: 8714
		// (get) Token: 0x0600718E RID: 29070 RVA: 0x001F6A24 File Offset: 0x001F4C24
		// (set) Token: 0x0600718F RID: 29071 RVA: 0x000358DC File Offset: 0x00033ADC
		public unsafe Material reverseLightMat_On
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleLights.NativeFieldInfoPtr_reverseLightMat_On);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleLights.NativeFieldInfoPtr_reverseLightMat_On), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700220B RID: 8715
		// (get) Token: 0x06007190 RID: 29072 RVA: 0x001F6A54 File Offset: 0x001F4C54
		// (set) Token: 0x06007191 RID: 29073 RVA: 0x000358FB File Offset: 0x00033AFB
		public unsafe Material reverseLightMat_Off
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleLights.NativeFieldInfoPtr_reverseLightMat_Off);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleLights.NativeFieldInfoPtr_reverseLightMat_Off), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700220C RID: 8716
		// (get) Token: 0x06007192 RID: 29074 RVA: 0x001F6A84 File Offset: 0x001F4C84
		// (set) Token: 0x06007193 RID: 29075 RVA: 0x0003591A File Offset: 0x00033B1A
		public unsafe bool reverseLightsOn
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleLights.NativeFieldInfoPtr_reverseLightsOn);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleLights.NativeFieldInfoPtr_reverseLightsOn)) = value;
			}
		}

		// Token: 0x1700220D RID: 8717
		// (get) Token: 0x06007194 RID: 29076 RVA: 0x001F6AAC File Offset: 0x001F4CAC
		// (set) Token: 0x06007195 RID: 29077 RVA: 0x00035935 File Offset: 0x00033B35
		public unsafe bool reverseLightsApplied
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleLights.NativeFieldInfoPtr_reverseLightsApplied);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleLights.NativeFieldInfoPtr_reverseLightsApplied)) = value;
			}
		}

		// Token: 0x1700220E RID: 8718
		// (get) Token: 0x06007196 RID: 29078 RVA: 0x001F6AD4 File Offset: 0x001F4CD4
		// (set) Token: 0x06007197 RID: 29079 RVA: 0x00035950 File Offset: 0x00033B50
		public unsafe UnityEvent onHeadlightsOn
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleLights.NativeFieldInfoPtr_onHeadlightsOn);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleLights.NativeFieldInfoPtr_onHeadlightsOn), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700220F RID: 8719
		// (get) Token: 0x06007198 RID: 29080 RVA: 0x001F6B04 File Offset: 0x001F4D04
		// (set) Token: 0x06007199 RID: 29081 RVA: 0x0003596F File Offset: 0x00033B6F
		public unsafe UnityEvent onHeadlightsOff
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleLights.NativeFieldInfoPtr_onHeadlightsOff);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleLights.NativeFieldInfoPtr_onHeadlightsOff), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002210 RID: 8720
		// (get) Token: 0x0600719A RID: 29082 RVA: 0x001F6B34 File Offset: 0x001F4D34
		// (set) Token: 0x0600719B RID: 29083 RVA: 0x0003598E File Offset: 0x00033B8E
		public unsafe List<bool> brakesAppliedHistory
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleLights.NativeFieldInfoPtr_brakesAppliedHistory);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<bool>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleLights.NativeFieldInfoPtr_brakesAppliedHistory), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002211 RID: 8721
		// (get) Token: 0x0600719C RID: 29084 RVA: 0x001F6B64 File Offset: 0x001F4D64
		// (set) Token: 0x0600719D RID: 29085 RVA: 0x000359AD File Offset: 0x00033BAD
		public unsafe VehicleAgent agent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleLights.NativeFieldInfoPtr_agent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<VehicleAgent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleLights.NativeFieldInfoPtr_agent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002212 RID: 8722
		// (get) Token: 0x0600719E RID: 29086 RVA: 0x001F6B94 File Offset: 0x001F4D94
		// (set) Token: 0x0600719F RID: 29087 RVA: 0x000359CC File Offset: 0x00033BCC
		public unsafe SyncVar<bool> syncVar____headLightsOn_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleLights.NativeFieldInfoPtr_syncVar____headLightsOn_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SyncVar<bool>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleLights.NativeFieldInfoPtr_syncVar____headLightsOn_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002213 RID: 8723
		// (get) Token: 0x060071A0 RID: 29088 RVA: 0x001F6BC4 File Offset: 0x001F4DC4
		// (set) Token: 0x060071A1 RID: 29089 RVA: 0x000359EB File Offset: 0x00033BEB
		public unsafe bool field_Private_Boolean_0
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleLights.NativeFieldInfoPtr_field_Private_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleLights.NativeFieldInfoPtr_field_Private_Boolean_0)) = value;
			}
		}

		// Token: 0x17002214 RID: 8724
		// (get) Token: 0x060071A2 RID: 29090 RVA: 0x001F6BEC File Offset: 0x001F4DEC
		// (set) Token: 0x060071A3 RID: 29091 RVA: 0x00035A06 File Offset: 0x00033C06
		public unsafe bool field_Private_Boolean_1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleLights.NativeFieldInfoPtr_field_Private_Boolean_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleLights.NativeFieldInfoPtr_field_Private_Boolean_1)) = value;
			}
		}

		// Token: 0x04004D7D RID: 19837
		private static readonly IntPtr NativeFieldInfoPtr_vehicle;

		// Token: 0x04004D7E RID: 19838
		private static readonly IntPtr NativeFieldInfoPtr_hasHeadLights;

		// Token: 0x04004D7F RID: 19839
		private static readonly IntPtr NativeFieldInfoPtr_headLightMeshes;

		// Token: 0x04004D80 RID: 19840
		private static readonly IntPtr NativeFieldInfoPtr_headLightSources;

		// Token: 0x04004D81 RID: 19841
		private static readonly IntPtr NativeFieldInfoPtr_headlightMat_On;

		// Token: 0x04004D82 RID: 19842
		private static readonly IntPtr NativeFieldInfoPtr_headLightMat_Off;

		// Token: 0x04004D83 RID: 19843
		private static readonly IntPtr NativeFieldInfoPtr__headLightsOn_k__BackingField;

		// Token: 0x04004D84 RID: 19844
		private static readonly IntPtr NativeFieldInfoPtr_headLightsApplied;

		// Token: 0x04004D85 RID: 19845
		private static readonly IntPtr NativeFieldInfoPtr_hasBrakeLights;

		// Token: 0x04004D86 RID: 19846
		private static readonly IntPtr NativeFieldInfoPtr_brakeLightMeshes;

		// Token: 0x04004D87 RID: 19847
		private static readonly IntPtr NativeFieldInfoPtr_brakeLightSources;

		// Token: 0x04004D88 RID: 19848
		private static readonly IntPtr NativeFieldInfoPtr_brakeLightMat_On;

		// Token: 0x04004D89 RID: 19849
		private static readonly IntPtr NativeFieldInfoPtr_brakeLightMat_Off;

		// Token: 0x04004D8A RID: 19850
		private static readonly IntPtr NativeFieldInfoPtr_brakeLightMat_Ambient;

		// Token: 0x04004D8B RID: 19851
		private static readonly IntPtr NativeFieldInfoPtr_brakeLightsOn;

		// Token: 0x04004D8C RID: 19852
		private static readonly IntPtr NativeFieldInfoPtr_brakeLightsApplied;

		// Token: 0x04004D8D RID: 19853
		private static readonly IntPtr NativeFieldInfoPtr_hasReverseLights;

		// Token: 0x04004D8E RID: 19854
		private static readonly IntPtr NativeFieldInfoPtr_reverseLightMeshes;

		// Token: 0x04004D8F RID: 19855
		private static readonly IntPtr NativeFieldInfoPtr_reverseLightSources;

		// Token: 0x04004D90 RID: 19856
		private static readonly IntPtr NativeFieldInfoPtr_reverseLightMat_On;

		// Token: 0x04004D91 RID: 19857
		private static readonly IntPtr NativeFieldInfoPtr_reverseLightMat_Off;

		// Token: 0x04004D92 RID: 19858
		private static readonly IntPtr NativeFieldInfoPtr_reverseLightsOn;

		// Token: 0x04004D93 RID: 19859
		private static readonly IntPtr NativeFieldInfoPtr_reverseLightsApplied;

		// Token: 0x04004D94 RID: 19860
		private static readonly IntPtr NativeFieldInfoPtr_onHeadlightsOn;

		// Token: 0x04004D95 RID: 19861
		private static readonly IntPtr NativeFieldInfoPtr_onHeadlightsOff;

		// Token: 0x04004D96 RID: 19862
		private static readonly IntPtr NativeFieldInfoPtr_brakesAppliedHistory;

		// Token: 0x04004D97 RID: 19863
		private static readonly IntPtr NativeFieldInfoPtr_agent;

		// Token: 0x04004D98 RID: 19864
		private static readonly IntPtr NativeFieldInfoPtr_syncVar____headLightsOn_k__BackingField;

		// Token: 0x04004D99 RID: 19865
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

		// Token: 0x04004D9A RID: 19866
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

		// Token: 0x04004D9B RID: 19867
		private static readonly IntPtr NativeMethodInfoPtr_get_headLightsOn_Public_get_Boolean_0;

		// Token: 0x04004D9C RID: 19868
		private static readonly IntPtr NativeMethodInfoPtr_set_headLightsOn_Public_set_Void_Boolean_0;

		// Token: 0x04004D9D RID: 19869
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;

		// Token: 0x04004D9E RID: 19870
		private static readonly IntPtr NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_1;

		// Token: 0x04004D9F RID: 19871
		private static readonly IntPtr NativeMethodInfoPtr_FixedUpdate_Protected_Virtual_New_Void_1;

		// Token: 0x04004DA0 RID: 19872
		private static readonly IntPtr NativeMethodInfoPtr_LateUpdate_Protected_Virtual_New_Void_1;

		// Token: 0x04004DA1 RID: 19873
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04004DA2 RID: 19874
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

		// Token: 0x04004DA3 RID: 19875
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

		// Token: 0x04004DA4 RID: 19876
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

		// Token: 0x04004DA5 RID: 19877
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_set_headLightsOn_1140765316_Private_Void_Boolean_0;

		// Token: 0x04004DA6 RID: 19878
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___set_headLightsOn_1140765316_Public_Void_Boolean_0;

		// Token: 0x04004DA7 RID: 19879
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_set_headLightsOn_1140765316_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x04004DA8 RID: 19880
		private static readonly IntPtr NativeMethodInfoPtr_sync___get_value__headLightsOn_k__BackingField_Public_get_Boolean_0;

		// Token: 0x04004DA9 RID: 19881
		private static readonly IntPtr NativeMethodInfoPtr_sync___set_value__headLightsOn_k__BackingField_Public_set_Void_Boolean_Boolean_0;

		// Token: 0x04004DAA RID: 19882
		private static readonly IntPtr NativeMethodInfoPtr_ReadSyncVar___ScheduleOne_Vehicles_VehicleLights_Public_Virtual_Boolean_PooledReader_UInt32_Boolean_0;

		// Token: 0x04004DAB RID: 19883
		private static readonly IntPtr NativeMethodInfoPtr_Method_Protected_Virtual_New_Void_0;
	}
}
