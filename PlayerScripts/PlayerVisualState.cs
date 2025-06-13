using System;
using Il2CppFishNet.Connection;
using Il2CppFishNet.Object;
using Il2CppFishNet.Serializing;
using Il2CppFishNet.Transporting;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.PlayerScripts
{
	// Token: 0x0200040B RID: 1035
	public class PlayerVisualState : NetworkBehaviour
	{
		// Token: 0x060053B0 RID: 21424 RVA: 0x0018DEE4 File Offset: 0x0018C0E4
		// Note: this type is marked as 'beforefieldinit'.
		static PlayerVisualState()
		{
			Il2CppClassPointerStore<PlayerVisualState>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.PlayerScripts", "PlayerVisualState");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayerVisualState>.NativeClassPtr);
			PlayerVisualState.NativeFieldInfoPtr_Suspiciousness = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerVisualState>.NativeClassPtr, "Suspiciousness");
			PlayerVisualState.NativeFieldInfoPtr_visualStates = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerVisualState>.NativeClassPtr, "visualStates");
			PlayerVisualState.NativeFieldInfoPtr_player = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerVisualState>.NativeClassPtr, "player");
			PlayerVisualState.NativeFieldInfoPtr_removalRoutinesDict = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerVisualState>.NativeClassPtr, "removalRoutinesDict");
			PlayerVisualState.NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerVisualState>.NativeClassPtr, "NetworkInitialize___EarlyScheduleOne.PlayerScripts.PlayerVisualStateAssembly-CSharp.dll_Excuted");
			PlayerVisualState.NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerVisualState>.NativeClassPtr, "NetworkInitialize__LateScheduleOne.PlayerScripts.PlayerVisualStateAssembly-CSharp.dll_Excuted");
			PlayerVisualState.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerVisualState>.NativeClassPtr, 100673859);
			PlayerVisualState.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerVisualState>.NativeClassPtr, 100673860);
			PlayerVisualState.NativeMethodInfoPtr_ApplyState_Public_Void_String_EVisualState_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerVisualState>.NativeClassPtr, 100673861);
			PlayerVisualState.NativeMethodInfoPtr_RemoveState_Public_Void_String_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerVisualState>.NativeClassPtr, 100673862);
			PlayerVisualState.NativeMethodInfoPtr_GetState_Public_VisualState_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerVisualState>.NativeClassPtr, 100673863);
			PlayerVisualState.NativeMethodInfoPtr_ClearStates_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerVisualState>.NativeClassPtr, 100673864);
			PlayerVisualState.NativeMethodInfoPtr_UpdateSuspiciousness_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerVisualState>.NativeClassPtr, 100673865);
			PlayerVisualState.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerVisualState>.NativeClassPtr, 100673866);
			PlayerVisualState.NativeMethodInfoPtr__Awake_b__6_0_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerVisualState>.NativeClassPtr, 100673867);
			PlayerVisualState.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerVisualState>.NativeClassPtr, 100673868);
			PlayerVisualState.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerVisualState>.NativeClassPtr, 100673869);
			PlayerVisualState.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerVisualState>.NativeClassPtr, 100673870);
			PlayerVisualState.NativeMethodInfoPtr_RpcWriter___Server_ApplyState_868472085_Private_Void_String_EVisualState_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerVisualState>.NativeClassPtr, 100673871);
			PlayerVisualState.NativeMethodInfoPtr_RpcLogic___ApplyState_868472085_Public_Void_String_EVisualState_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerVisualState>.NativeClassPtr, 100673872);
			PlayerVisualState.NativeMethodInfoPtr_RpcReader___Server_ApplyState_868472085_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerVisualState>.NativeClassPtr, 100673873);
			PlayerVisualState.NativeMethodInfoPtr_RpcWriter___Server_RemoveState_606697822_Private_Void_String_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerVisualState>.NativeClassPtr, 100673874);
			PlayerVisualState.NativeMethodInfoPtr_RpcLogic___RemoveState_606697822_Public_Void_String_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerVisualState>.NativeClassPtr, 100673875);
			PlayerVisualState.NativeMethodInfoPtr_RpcReader___Server_RemoveState_606697822_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerVisualState>.NativeClassPtr, 100673876);
			PlayerVisualState.NativeMethodInfoPtr_Method_Private_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerVisualState>.NativeClassPtr, 100673877);
		}

		// Token: 0x060053B1 RID: 21425 RVA: 0x0018E108 File Offset: 0x0018C308
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 181787, XrefRangeEnd = 181803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PlayerVisualState.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060053B2 RID: 21426 RVA: 0x0018E144 File Offset: 0x0018C344
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 181803, XrefRangeEnd = 181831, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerVisualState.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060053B3 RID: 21427 RVA: 0x0018E178 File Offset: 0x0018C378
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 181833, RefRangeEnd = 181839, XrefRangeStart = 181831, XrefRangeEnd = 181833, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ApplyState(string label, PlayerVisualState.EVisualState state, float autoRemoveAfter = 0f)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(label);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref state;
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref autoRemoveAfter;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerVisualState.NativeMethodInfoPtr_ApplyState_Public_Void_String_EVisualState_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060053B4 RID: 21428 RVA: 0x0018E1D8 File Offset: 0x0018C3D8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 181841, RefRangeEnd = 181844, XrefRangeStart = 181839, XrefRangeEnd = 181841, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveState(string label, float delay = 0f)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(label);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref delay;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerVisualState.NativeMethodInfoPtr_RemoveState_Public_Void_String_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060053B5 RID: 21429 RVA: 0x0018E228 File Offset: 0x0018C428
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 181859, RefRangeEnd = 181863, XrefRangeStart = 181844, XrefRangeEnd = 181859, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PlayerVisualState.VisualState GetState(string label)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(label);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerVisualState.NativeMethodInfoPtr_GetState_Public_VisualState_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlayerVisualState.VisualState>(intPtr2) : null;
		}

		// Token: 0x060053B6 RID: 21430 RVA: 0x0018E278 File Offset: 0x0018C478
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 181863, XrefRangeEnd = 181872, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ClearStates()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerVisualState.NativeMethodInfoPtr_ClearStates_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060053B7 RID: 21431 RVA: 0x0018E2AC File Offset: 0x0018C4AC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 181886, RefRangeEnd = 181887, XrefRangeStart = 181872, XrefRangeEnd = 181886, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateSuspiciousness()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerVisualState.NativeMethodInfoPtr_UpdateSuspiciousness_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060053B8 RID: 21432 RVA: 0x0018E2E0 File Offset: 0x0018C4E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 181887, XrefRangeEnd = 181902, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PlayerVisualState() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayerVisualState>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerVisualState.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060053B9 RID: 21433 RVA: 0x0018E31C File Offset: 0x0018C51C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _Awake_b__6_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerVisualState.NativeMethodInfoPtr__Awake_b__6_0_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060053BA RID: 21434 RVA: 0x0018E350 File Offset: 0x0018C550
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 181902, XrefRangeEnd = 181915, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void NetworkInitialize___Early()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PlayerVisualState.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060053BB RID: 21435 RVA: 0x0018E38C File Offset: 0x0018C58C
		[CallerCount(0)]
		public unsafe virtual void NetworkInitialize__Late()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PlayerVisualState.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060053BC RID: 21436 RVA: 0x0018E3C8 File Offset: 0x0018C5C8
		[CallerCount(0)]
		public unsafe override void NetworkInitializeIfDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PlayerVisualState.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060053BD RID: 21437 RVA: 0x0018E404 File Offset: 0x0018C604
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 181929, RefRangeEnd = 181934, XrefRangeStart = 181915, XrefRangeEnd = 181929, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_ApplyState_868472085(string label, PlayerVisualState.EVisualState state, float autoRemoveAfter = 0f)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(label);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref state;
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref autoRemoveAfter;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerVisualState.NativeMethodInfoPtr_RpcWriter___Server_ApplyState_868472085_Private_Void_String_EVisualState_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060053BE RID: 21438 RVA: 0x0018E464 File Offset: 0x0018C664
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 181961, RefRangeEnd = 181967, XrefRangeStart = 181934, XrefRangeEnd = 181961, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___ApplyState_868472085(string label, PlayerVisualState.EVisualState state, float autoRemoveAfter = 0f)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(label);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref state;
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref autoRemoveAfter;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerVisualState.NativeMethodInfoPtr_RpcLogic___ApplyState_868472085_Public_Void_String_EVisualState_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060053BF RID: 21439 RVA: 0x0018E4C4 File Offset: 0x0018C6C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 181967, XrefRangeEnd = 181974, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_ApplyState_868472085(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref channel;
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerVisualState.NativeMethodInfoPtr_RpcReader___Server_ApplyState_868472085_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060053C0 RID: 21440 RVA: 0x0018E528 File Offset: 0x0018C728
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 181987, RefRangeEnd = 181994, XrefRangeStart = 181974, XrefRangeEnd = 181987, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_RemoveState_606697822(string label, float delay = 0f)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(label);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref delay;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerVisualState.NativeMethodInfoPtr_RpcWriter___Server_RemoveState_606697822_Private_Void_String_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060053C1 RID: 21441 RVA: 0x0018E578 File Offset: 0x0018C778
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 182008, RefRangeEnd = 182016, XrefRangeStart = 181994, XrefRangeEnd = 182008, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___RemoveState_606697822(string label, float delay = 0f)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(label);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref delay;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerVisualState.NativeMethodInfoPtr_RpcLogic___RemoveState_606697822_Public_Void_String_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060053C2 RID: 21442 RVA: 0x0018E5C8 File Offset: 0x0018C7C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 182016, XrefRangeEnd = 182022, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_RemoveState_606697822(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref channel;
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerVisualState.NativeMethodInfoPtr_RpcReader___Server_RemoveState_606697822_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060053C3 RID: 21443 RVA: 0x0018E62C File Offset: 0x0018C82C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 182022, XrefRangeEnd = 182037, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Method_Private_Void_PDM_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerVisualState.NativeMethodInfoPtr_Method_Private_Void_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060053C4 RID: 21444 RVA: 0x00027A3B File Offset: 0x00025C3B
		public PlayerVisualState(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001906 RID: 6406
		// (get) Token: 0x060053C5 RID: 21445 RVA: 0x0018E660 File Offset: 0x0018C860
		// (set) Token: 0x060053C6 RID: 21446 RVA: 0x00027A44 File Offset: 0x00025C44
		public unsafe float Suspiciousness
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerVisualState.NativeFieldInfoPtr_Suspiciousness);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerVisualState.NativeFieldInfoPtr_Suspiciousness)) = value;
			}
		}

		// Token: 0x17001907 RID: 6407
		// (get) Token: 0x060053C7 RID: 21447 RVA: 0x0018E688 File Offset: 0x0018C888
		// (set) Token: 0x060053C8 RID: 21448 RVA: 0x00027A5F File Offset: 0x00025C5F
		public unsafe List<PlayerVisualState.VisualState> visualStates
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerVisualState.NativeFieldInfoPtr_visualStates);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<PlayerVisualState.VisualState>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerVisualState.NativeFieldInfoPtr_visualStates), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001908 RID: 6408
		// (get) Token: 0x060053C9 RID: 21449 RVA: 0x0018E6B8 File Offset: 0x0018C8B8
		// (set) Token: 0x060053CA RID: 21450 RVA: 0x00027A7E File Offset: 0x00025C7E
		public unsafe Player player
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerVisualState.NativeFieldInfoPtr_player);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Player>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerVisualState.NativeFieldInfoPtr_player), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001909 RID: 6409
		// (get) Token: 0x060053CB RID: 21451 RVA: 0x0018E6E8 File Offset: 0x0018C8E8
		// (set) Token: 0x060053CC RID: 21452 RVA: 0x00027A9D File Offset: 0x00025C9D
		public unsafe Dictionary<string, Coroutine> removalRoutinesDict
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerVisualState.NativeFieldInfoPtr_removalRoutinesDict);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, Coroutine>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerVisualState.NativeFieldInfoPtr_removalRoutinesDict), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700190A RID: 6410
		// (get) Token: 0x060053CD RID: 21453 RVA: 0x0018E718 File Offset: 0x0018C918
		// (set) Token: 0x060053CE RID: 21454 RVA: 0x00027ABC File Offset: 0x00025CBC
		public unsafe bool field_Private_Boolean_0
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerVisualState.NativeFieldInfoPtr_field_Private_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerVisualState.NativeFieldInfoPtr_field_Private_Boolean_0)) = value;
			}
		}

		// Token: 0x1700190B RID: 6411
		// (get) Token: 0x060053CF RID: 21455 RVA: 0x0018E740 File Offset: 0x0018C940
		// (set) Token: 0x060053D0 RID: 21456 RVA: 0x00027AD7 File Offset: 0x00025CD7
		public unsafe bool field_Private_Boolean_1
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerVisualState.NativeFieldInfoPtr_field_Private_Boolean_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerVisualState.NativeFieldInfoPtr_field_Private_Boolean_1)) = value;
			}
		}

		// Token: 0x040038C0 RID: 14528
		private static readonly System.IntPtr NativeFieldInfoPtr_Suspiciousness;

		// Token: 0x040038C1 RID: 14529
		private static readonly System.IntPtr NativeFieldInfoPtr_visualStates;

		// Token: 0x040038C2 RID: 14530
		private static readonly System.IntPtr NativeFieldInfoPtr_player;

		// Token: 0x040038C3 RID: 14531
		private static readonly System.IntPtr NativeFieldInfoPtr_removalRoutinesDict;

		// Token: 0x040038C4 RID: 14532
		private static readonly System.IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

		// Token: 0x040038C5 RID: 14533
		private static readonly System.IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

		// Token: 0x040038C6 RID: 14534
		private static readonly System.IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;

		// Token: 0x040038C7 RID: 14535
		private static readonly System.IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x040038C8 RID: 14536
		private static readonly System.IntPtr NativeMethodInfoPtr_ApplyState_Public_Void_String_EVisualState_Single_0;

		// Token: 0x040038C9 RID: 14537
		private static readonly System.IntPtr NativeMethodInfoPtr_RemoveState_Public_Void_String_Single_0;

		// Token: 0x040038CA RID: 14538
		private static readonly System.IntPtr NativeMethodInfoPtr_GetState_Public_VisualState_String_0;

		// Token: 0x040038CB RID: 14539
		private static readonly System.IntPtr NativeMethodInfoPtr_ClearStates_Public_Void_0;

		// Token: 0x040038CC RID: 14540
		private static readonly System.IntPtr NativeMethodInfoPtr_UpdateSuspiciousness_Private_Void_0;

		// Token: 0x040038CD RID: 14541
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040038CE RID: 14542
		private static readonly System.IntPtr NativeMethodInfoPtr__Awake_b__6_0_Private_Void_0;

		// Token: 0x040038CF RID: 14543
		private static readonly System.IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

		// Token: 0x040038D0 RID: 14544
		private static readonly System.IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

		// Token: 0x040038D1 RID: 14545
		private static readonly System.IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

		// Token: 0x040038D2 RID: 14546
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcWriter___Server_ApplyState_868472085_Private_Void_String_EVisualState_Single_0;

		// Token: 0x040038D3 RID: 14547
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcLogic___ApplyState_868472085_Public_Void_String_EVisualState_Single_0;

		// Token: 0x040038D4 RID: 14548
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcReader___Server_ApplyState_868472085_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x040038D5 RID: 14549
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcWriter___Server_RemoveState_606697822_Private_Void_String_Single_0;

		// Token: 0x040038D6 RID: 14550
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcLogic___RemoveState_606697822_Public_Void_String_Single_0;

		// Token: 0x040038D7 RID: 14551
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcReader___Server_RemoveState_606697822_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x040038D8 RID: 14552
		private static readonly System.IntPtr NativeMethodInfoPtr_Method_Private_Void_PDM_0;

		// Token: 0x020009F6 RID: 2550
		[OriginalName("Assembly-CSharp.dll", "", "EVisualState")]
		public enum EVisualState
		{
			// Token: 0x04008D16 RID: 36118
			Visible,
			// Token: 0x04008D17 RID: 36119
			Suspicious,
			// Token: 0x04008D18 RID: 36120
			DisobeyingCurfew,
			// Token: 0x04008D19 RID: 36121
			Vandalizing,
			// Token: 0x04008D1A RID: 36122
			PettyCrime,
			// Token: 0x04008D1B RID: 36123
			DrugDealing,
			// Token: 0x04008D1C RID: 36124
			SearchedFor,
			// Token: 0x04008D1D RID: 36125
			Wanted,
			// Token: 0x04008D1E RID: 36126
			Pickpocketing,
			// Token: 0x04008D1F RID: 36127
			DischargingWeapon,
			// Token: 0x04008D20 RID: 36128
			Brandishing
		}

		// Token: 0x020009F7 RID: 2551
		[System.Serializable]
		public class VisualState : Il2CppSystem.Object
		{
			// Token: 0x0600D0A8 RID: 53416 RVA: 0x00327E9C File Offset: 0x0032609C
			// Note: this type is marked as 'beforefieldinit'.
			static VisualState()
			{
				Il2CppClassPointerStore<PlayerVisualState.VisualState>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PlayerVisualState>.NativeClassPtr, "VisualState");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayerVisualState.VisualState>.NativeClassPtr);
				PlayerVisualState.VisualState.NativeFieldInfoPtr_state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerVisualState.VisualState>.NativeClassPtr, "state");
				PlayerVisualState.VisualState.NativeFieldInfoPtr_label = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerVisualState.VisualState>.NativeClassPtr, "label");
				PlayerVisualState.VisualState.NativeFieldInfoPtr_stateDestroyed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerVisualState.VisualState>.NativeClassPtr, "stateDestroyed");
				PlayerVisualState.VisualState.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerVisualState.VisualState>.NativeClassPtr, 100673878);
			}

			// Token: 0x0600D0A9 RID: 53417 RVA: 0x00327F18 File Offset: 0x00326118
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe VisualState() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayerVisualState.VisualState>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerVisualState.VisualState.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600D0AA RID: 53418 RVA: 0x000652CE File Offset: 0x000634CE
			public VisualState(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170040B0 RID: 16560
			// (get) Token: 0x0600D0AB RID: 53419 RVA: 0x00327F54 File Offset: 0x00326154
			// (set) Token: 0x0600D0AC RID: 53420 RVA: 0x000652D7 File Offset: 0x000634D7
			public unsafe PlayerVisualState.EVisualState state
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerVisualState.VisualState.NativeFieldInfoPtr_state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerVisualState.VisualState.NativeFieldInfoPtr_state)) = value;
				}
			}

			// Token: 0x170040B1 RID: 16561
			// (get) Token: 0x0600D0AD RID: 53421 RVA: 0x00327F7C File Offset: 0x0032617C
			// (set) Token: 0x0600D0AE RID: 53422 RVA: 0x000652F2 File Offset: 0x000634F2
			public unsafe string label
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerVisualState.VisualState.NativeFieldInfoPtr_label);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerVisualState.VisualState.NativeFieldInfoPtr_label), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x170040B2 RID: 16562
			// (get) Token: 0x0600D0AF RID: 53423 RVA: 0x00327FA4 File Offset: 0x003261A4
			// (set) Token: 0x0600D0B0 RID: 53424 RVA: 0x00065311 File Offset: 0x00063511
			public unsafe Il2CppSystem.Action stateDestroyed
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerVisualState.VisualState.NativeFieldInfoPtr_stateDestroyed);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Action>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerVisualState.VisualState.NativeFieldInfoPtr_stateDestroyed), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008D21 RID: 36129
			private static readonly System.IntPtr NativeFieldInfoPtr_state;

			// Token: 0x04008D22 RID: 36130
			private static readonly System.IntPtr NativeFieldInfoPtr_label;

			// Token: 0x04008D23 RID: 36131
			private static readonly System.IntPtr NativeFieldInfoPtr_stateDestroyed;

			// Token: 0x04008D24 RID: 36132
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x020009F8 RID: 2552
		[ObfuscatedName("ScheduleOne.PlayerScripts.PlayerVisualState+<>c__DisplayClass10_0")]
		public sealed class __c__DisplayClass10_0 : Il2CppSystem.Object
		{
			// Token: 0x0600D0B1 RID: 53425 RVA: 0x00327FD4 File Offset: 0x003261D4
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass10_0()
			{
				Il2CppClassPointerStore<PlayerVisualState.__c__DisplayClass10_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PlayerVisualState>.NativeClassPtr, "<>c__DisplayClass10_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayerVisualState.__c__DisplayClass10_0>.NativeClassPtr);
				PlayerVisualState.__c__DisplayClass10_0.NativeFieldInfoPtr_label = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerVisualState.__c__DisplayClass10_0>.NativeClassPtr, "label");
				PlayerVisualState.__c__DisplayClass10_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerVisualState.__c__DisplayClass10_0>.NativeClassPtr, 100673879);
				PlayerVisualState.__c__DisplayClass10_0.NativeMethodInfoPtr__GetState_b__0_Internal_Boolean_VisualState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerVisualState.__c__DisplayClass10_0>.NativeClassPtr, 100673880);
			}

			// Token: 0x0600D0B2 RID: 53426 RVA: 0x0032803C File Offset: 0x0032623C
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass10_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayerVisualState.__c__DisplayClass10_0>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerVisualState.__c__DisplayClass10_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600D0B3 RID: 53427 RVA: 0x00328078 File Offset: 0x00326278
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GetState_b__0(PlayerVisualState.VisualState x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(PlayerVisualState.__c__DisplayClass10_0.NativeMethodInfoPtr__GetState_b__0_Internal_Boolean_VisualState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x0600D0B4 RID: 53428 RVA: 0x00065330 File Offset: 0x00063530
			public __c__DisplayClass10_0(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170040B3 RID: 16563
			// (get) Token: 0x0600D0B5 RID: 53429 RVA: 0x003280C8 File Offset: 0x003262C8
			// (set) Token: 0x0600D0B6 RID: 53430 RVA: 0x00065339 File Offset: 0x00063539
			public unsafe string label
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerVisualState.__c__DisplayClass10_0.NativeFieldInfoPtr_label);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerVisualState.__c__DisplayClass10_0.NativeFieldInfoPtr_label), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x04008D25 RID: 36133
			private static readonly System.IntPtr NativeFieldInfoPtr_label;

			// Token: 0x04008D26 RID: 36134
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008D27 RID: 36135
			private static readonly System.IntPtr NativeMethodInfoPtr__GetState_b__0_Internal_Boolean_VisualState_0;
		}

		// Token: 0x020009F9 RID: 2553
		[ObfuscatedName("ScheduleOne.PlayerScripts.PlayerVisualState+<>c__DisplayClass9_0")]
		public sealed class __c__DisplayClass9_0 : Il2CppSystem.Object
		{
			// Token: 0x0600D0B7 RID: 53431 RVA: 0x003280F0 File Offset: 0x003262F0
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass9_0()
			{
				Il2CppClassPointerStore<PlayerVisualState.__c__DisplayClass9_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PlayerVisualState>.NativeClassPtr, "<>c__DisplayClass9_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayerVisualState.__c__DisplayClass9_0>.NativeClassPtr);
				PlayerVisualState.__c__DisplayClass9_0.NativeFieldInfoPtr_delay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerVisualState.__c__DisplayClass9_0>.NativeClassPtr, "delay");
				PlayerVisualState.__c__DisplayClass9_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerVisualState.__c__DisplayClass9_0>.NativeClassPtr, "<>4__this");
				PlayerVisualState.__c__DisplayClass9_0.NativeFieldInfoPtr_label = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerVisualState.__c__DisplayClass9_0>.NativeClassPtr, "label");
				PlayerVisualState.__c__DisplayClass9_0.NativeFieldInfoPtr_newState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerVisualState.__c__DisplayClass9_0>.NativeClassPtr, "newState");
				PlayerVisualState.__c__DisplayClass9_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerVisualState.__c__DisplayClass9_0>.NativeClassPtr, 100673881);
				PlayerVisualState.__c__DisplayClass9_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerVisualState.__c__DisplayClass9_0>.NativeClassPtr, 100673882);
				PlayerVisualState.__c__DisplayClass9_0.NativeMethodInfoPtr_Method_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerVisualState.__c__DisplayClass9_0>.NativeClassPtr, 100673883);
			}

			// Token: 0x0600D0B8 RID: 53432 RVA: 0x003281A8 File Offset: 0x003263A8
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass9_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayerVisualState.__c__DisplayClass9_0>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerVisualState.__c__DisplayClass9_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600D0B9 RID: 53433 RVA: 0x003281E4 File Offset: 0x003263E4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 181749, XrefRangeEnd = 181754, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator Method_Internal_IEnumerator_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerVisualState.__c__DisplayClass9_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr2) : null;
			}

			// Token: 0x0600D0BA RID: 53434 RVA: 0x00328224 File Offset: 0x00326424
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 181786, RefRangeEnd = 181787, XrefRangeStart = 181754, XrefRangeEnd = 181786, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Method_Internal_Void_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerVisualState.__c__DisplayClass9_0.NativeMethodInfoPtr_Method_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600D0BB RID: 53435 RVA: 0x00065358 File Offset: 0x00063558
			public __c__DisplayClass9_0(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170040B4 RID: 16564
			// (get) Token: 0x0600D0BC RID: 53436 RVA: 0x00328258 File Offset: 0x00326458
			// (set) Token: 0x0600D0BD RID: 53437 RVA: 0x00065361 File Offset: 0x00063561
			public unsafe float delay
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerVisualState.__c__DisplayClass9_0.NativeFieldInfoPtr_delay);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerVisualState.__c__DisplayClass9_0.NativeFieldInfoPtr_delay)) = value;
				}
			}

			// Token: 0x170040B5 RID: 16565
			// (get) Token: 0x0600D0BE RID: 53438 RVA: 0x00328280 File Offset: 0x00326480
			// (set) Token: 0x0600D0BF RID: 53439 RVA: 0x0006537C File Offset: 0x0006357C
			public unsafe PlayerVisualState __4__this
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerVisualState.__c__DisplayClass9_0.NativeFieldInfoPtr___4__this);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlayerVisualState>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerVisualState.__c__DisplayClass9_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170040B6 RID: 16566
			// (get) Token: 0x0600D0C0 RID: 53440 RVA: 0x003282B0 File Offset: 0x003264B0
			// (set) Token: 0x0600D0C1 RID: 53441 RVA: 0x0006539B File Offset: 0x0006359B
			public unsafe string label
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerVisualState.__c__DisplayClass9_0.NativeFieldInfoPtr_label);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerVisualState.__c__DisplayClass9_0.NativeFieldInfoPtr_label), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x170040B7 RID: 16567
			// (get) Token: 0x0600D0C2 RID: 53442 RVA: 0x003282D8 File Offset: 0x003264D8
			// (set) Token: 0x0600D0C3 RID: 53443 RVA: 0x000653BA File Offset: 0x000635BA
			public unsafe PlayerVisualState.VisualState newState
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerVisualState.__c__DisplayClass9_0.NativeFieldInfoPtr_newState);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlayerVisualState.VisualState>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerVisualState.__c__DisplayClass9_0.NativeFieldInfoPtr_newState), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008D28 RID: 36136
			private static readonly System.IntPtr NativeFieldInfoPtr_delay;

			// Token: 0x04008D29 RID: 36137
			private static readonly System.IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04008D2A RID: 36138
			private static readonly System.IntPtr NativeFieldInfoPtr_label;

			// Token: 0x04008D2B RID: 36139
			private static readonly System.IntPtr NativeFieldInfoPtr_newState;

			// Token: 0x04008D2C RID: 36140
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008D2D RID: 36141
			private static readonly System.IntPtr NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0;

			// Token: 0x04008D2E RID: 36142
			private static readonly System.IntPtr NativeMethodInfoPtr_Method_Internal_Void_0;

			// Token: 0x02000CA3 RID: 3235
			[ObfuscatedName("ScheduleOne.PlayerScripts.PlayerVisualState+<>c__DisplayClass9_0+<<RemoveState>g__DelayedRemove|0>d")]
			public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique : Il2CppSystem.Object
			{
				// Token: 0x0600E845 RID: 59461 RVA: 0x0036A970 File Offset: 0x00368B70
				// Note: this type is marked as 'beforefieldinit'.
				static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique()
				{
					Il2CppClassPointerStore<PlayerVisualState.__c__DisplayClass9_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PlayerVisualState.__c__DisplayClass9_0>.NativeClassPtr, "<<RemoveState>g__DelayedRemove|0>d");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayerVisualState.__c__DisplayClass9_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr);
					PlayerVisualState.__c__DisplayClass9_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerVisualState.__c__DisplayClass9_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>1__state");
					PlayerVisualState.__c__DisplayClass9_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerVisualState.__c__DisplayClass9_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>2__current");
					PlayerVisualState.__c__DisplayClass9_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerVisualState.__c__DisplayClass9_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>4__this");
					PlayerVisualState.__c__DisplayClass9_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerVisualState.__c__DisplayClass9_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100673884);
					PlayerVisualState.__c__DisplayClass9_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerVisualState.__c__DisplayClass9_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100673885);
					PlayerVisualState.__c__DisplayClass9_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerVisualState.__c__DisplayClass9_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100673886);
					PlayerVisualState.__c__DisplayClass9_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerVisualState.__c__DisplayClass9_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100673887);
					PlayerVisualState.__c__DisplayClass9_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerVisualState.__c__DisplayClass9_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100673888);
					PlayerVisualState.__c__DisplayClass9_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerVisualState.__c__DisplayClass9_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100673889);
				}

				// Token: 0x0600E846 RID: 59462 RVA: 0x0036AA50 File Offset: 0x00368C50
				[CallerCount(54)]
				[CachedScanResults(RefRangeStart = 2646, RefRangeEnd = 2700, XrefRangeStart = 2646, XrefRangeEnd = 2700, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayerVisualState.__c__DisplayClass9_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr))
				{
					System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
					*ptr = ref <>1__state;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerVisualState.__c__DisplayClass9_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				}

				// Token: 0x0600E847 RID: 59463 RVA: 0x0036AA98 File Offset: 0x00368C98
				[CallerCount(14558)]
				[CachedScanResults(RefRangeStart = 2769, RefRangeEnd = 17327, XrefRangeStart = 2769, XrefRangeEnd = 17327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerVisualState.__c__DisplayClass9_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				}

				// Token: 0x0600E848 RID: 59464 RVA: 0x0036AACC File Offset: 0x00368CCC
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 181738, XrefRangeEnd = 181744, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(PlayerVisualState.__c__DisplayClass9_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
					return *IL2CPP.il2cpp_object_unbox(obj);
				}

				// Token: 0x170047BD RID: 18365
				// (get) Token: 0x0600E849 RID: 59465 RVA: 0x0036AB08 File Offset: 0x00368D08
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(24)]
					[CachedScanResults(RefRangeStart = 2740, RefRangeEnd = 2764, XrefRangeStart = 2740, XrefRangeEnd = 2764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						System.IntPtr* param = null;
						System.IntPtr returnedException;
						System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerVisualState.__c__DisplayClass9_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
						Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
						System.IntPtr intPtr2 = intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
				}

				// Token: 0x0600E84A RID: 59466 RVA: 0x0036AB48 File Offset: 0x00368D48
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 181744, XrefRangeEnd = 181749, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerVisualState.__c__DisplayClass9_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				}

				// Token: 0x170047BE RID: 18366
				// (get) Token: 0x0600E84B RID: 59467 RVA: 0x0036AB7C File Offset: 0x00368D7C
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(24)]
					[CachedScanResults(RefRangeStart = 2740, RefRangeEnd = 2764, XrefRangeStart = 2740, XrefRangeEnd = 2764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						System.IntPtr* param = null;
						System.IntPtr returnedException;
						System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerVisualState.__c__DisplayClass9_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
						Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
						System.IntPtr intPtr2 = intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
				}

				// Token: 0x0600E84C RID: 59468 RVA: 0x00070F11 File Offset: 0x0006F111
				public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique(System.IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x170047BA RID: 18362
				// (get) Token: 0x0600E84D RID: 59469 RVA: 0x0036ABBC File Offset: 0x00368DBC
				// (set) Token: 0x0600E84E RID: 59470 RVA: 0x00070F1A File Offset: 0x0006F11A
				public unsafe int __1__state
				{
					get
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerVisualState.__c__DisplayClass9_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerVisualState.__c__DisplayClass9_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x170047BB RID: 18363
				// (get) Token: 0x0600E84F RID: 59471 RVA: 0x0036ABE4 File Offset: 0x00368DE4
				// (set) Token: 0x0600E850 RID: 59472 RVA: 0x00070F35 File Offset: 0x0006F135
				public unsafe Il2CppSystem.Object __2__current
				{
					get
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerVisualState.__c__DisplayClass9_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current);
						System.IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
					set
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerVisualState.__c__DisplayClass9_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x170047BC RID: 18364
				// (get) Token: 0x0600E851 RID: 59473 RVA: 0x0036AC14 File Offset: 0x00368E14
				// (set) Token: 0x0600E852 RID: 59474 RVA: 0x00070F54 File Offset: 0x0006F154
				public unsafe PlayerVisualState.__c__DisplayClass9_0 __4__this
				{
					get
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerVisualState.__c__DisplayClass9_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this);
						System.IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlayerVisualState.__c__DisplayClass9_0>(intPtr2) : null;
					}
					set
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerVisualState.__c__DisplayClass9_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x04009B80 RID: 39808
				private static readonly System.IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x04009B81 RID: 39809
				private static readonly System.IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x04009B82 RID: 39810
				private static readonly System.IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x04009B83 RID: 39811
				private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x04009B84 RID: 39812
				private static readonly System.IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x04009B85 RID: 39813
				private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x04009B86 RID: 39814
				private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x04009B87 RID: 39815
				private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x04009B88 RID: 39816
				private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
			}
		}
	}
}
