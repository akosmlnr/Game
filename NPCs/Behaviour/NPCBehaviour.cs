using System;
using Il2CppFishNet.Connection;
using Il2CppFishNet.Object;
using Il2CppFishNet.Serializing;
using Il2CppFishNet.Transporting;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Combat;
using Il2CppScheduleOne.Product;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.NPCs.Behaviour
{
	// Token: 0x0200037F RID: 895
	public class NPCBehaviour : NetworkBehaviour
	{
		// Token: 0x060043BF RID: 17343 RVA: 0x00153754 File Offset: 0x00151954
		// Note: this type is marked as 'beforefieldinit'.
		static NPCBehaviour()
		{
			Il2CppClassPointerStore<NPCBehaviour>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.NPCs.Behaviour", "NPCBehaviour");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NPCBehaviour>.NativeClassPtr);
			NPCBehaviour.NativeFieldInfoPtr_DEBUG_MODE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCBehaviour>.NativeClassPtr, "DEBUG_MODE");
			NPCBehaviour.NativeFieldInfoPtr_ScheduleManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCBehaviour>.NativeClassPtr, "ScheduleManager");
			NPCBehaviour.NativeFieldInfoPtr_CoweringBehaviour = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCBehaviour>.NativeClassPtr, "CoweringBehaviour");
			NPCBehaviour.NativeFieldInfoPtr_RagdollBehaviour = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCBehaviour>.NativeClassPtr, "RagdollBehaviour");
			NPCBehaviour.NativeFieldInfoPtr_CallPoliceBehaviour = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCBehaviour>.NativeClassPtr, "CallPoliceBehaviour");
			NPCBehaviour.NativeFieldInfoPtr_GenericDialogueBehaviour = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCBehaviour>.NativeClassPtr, "GenericDialogueBehaviour");
			NPCBehaviour.NativeFieldInfoPtr_HeavyFlinchBehaviour = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCBehaviour>.NativeClassPtr, "HeavyFlinchBehaviour");
			NPCBehaviour.NativeFieldInfoPtr_FacePlayerBehaviour = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCBehaviour>.NativeClassPtr, "FacePlayerBehaviour");
			NPCBehaviour.NativeFieldInfoPtr_DeadBehaviour = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCBehaviour>.NativeClassPtr, "DeadBehaviour");
			NPCBehaviour.NativeFieldInfoPtr_UnconsciousBehaviour = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCBehaviour>.NativeClassPtr, "UnconsciousBehaviour");
			NPCBehaviour.NativeFieldInfoPtr_SummonBehaviour = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCBehaviour>.NativeClassPtr, "SummonBehaviour");
			NPCBehaviour.NativeFieldInfoPtr_ConsumeProductBehaviour = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCBehaviour>.NativeClassPtr, "ConsumeProductBehaviour");
			NPCBehaviour.NativeFieldInfoPtr_CombatBehaviour = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCBehaviour>.NativeClassPtr, "CombatBehaviour");
			NPCBehaviour.NativeFieldInfoPtr_FleeBehaviour = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCBehaviour>.NativeClassPtr, "FleeBehaviour");
			NPCBehaviour.NativeFieldInfoPtr_StationaryBehaviour = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCBehaviour>.NativeClassPtr, "StationaryBehaviour");
			NPCBehaviour.NativeFieldInfoPtr_RequestProductBehaviour = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCBehaviour>.NativeClassPtr, "RequestProductBehaviour");
			NPCBehaviour.NativeFieldInfoPtr_behaviourStack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCBehaviour>.NativeClassPtr, "behaviourStack");
			NPCBehaviour.NativeFieldInfoPtr__activeBehaviour_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCBehaviour>.NativeClassPtr, "<activeBehaviour>k__BackingField");
			NPCBehaviour.NativeFieldInfoPtr__Npc_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCBehaviour>.NativeClassPtr, "<Npc>k__BackingField");
			NPCBehaviour.NativeFieldInfoPtr_summonRoutine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCBehaviour>.NativeClassPtr, "summonRoutine");
			NPCBehaviour.NativeFieldInfoPtr_enabledBehaviours = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCBehaviour>.NativeClassPtr, "enabledBehaviours");
			NPCBehaviour.NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCBehaviour>.NativeClassPtr, "NetworkInitialize___EarlyScheduleOne.NPCs.Behaviour.NPCBehaviourAssembly-CSharp.dll_Excuted");
			NPCBehaviour.NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCBehaviour>.NativeClassPtr, "NetworkInitialize__LateScheduleOne.NPCs.Behaviour.NPCBehaviourAssembly-CSharp.dll_Excuted");
			NPCBehaviour.NativeMethodInfoPtr_get_activeBehaviour_Public_get_Behaviour_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCBehaviour>.NativeClassPtr, 100671627);
			NPCBehaviour.NativeMethodInfoPtr_set_activeBehaviour_Public_set_Void_Behaviour_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCBehaviour>.NativeClassPtr, 100671628);
			NPCBehaviour.NativeMethodInfoPtr_get_Npc_Public_get_NPC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCBehaviour>.NativeClassPtr, 100671629);
			NPCBehaviour.NativeMethodInfoPtr_set_Npc_Private_set_Void_NPC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCBehaviour>.NativeClassPtr, 100671630);
			NPCBehaviour.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCBehaviour>.NativeClassPtr, 100671631);
			NPCBehaviour.NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCBehaviour>.NativeClassPtr, 100671632);
			NPCBehaviour.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCBehaviour>.NativeClassPtr, 100671633);
			NPCBehaviour.NativeMethodInfoPtr_OnValidate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCBehaviour>.NativeClassPtr, 100671634);
			NPCBehaviour.NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCBehaviour>.NativeClassPtr, 100671635);
			NPCBehaviour.NativeMethodInfoPtr_Summon_Public_Void_String_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCBehaviour>.NativeClassPtr, 100671636);
			NPCBehaviour.NativeMethodInfoPtr_ConsumeProduct_Public_Void_ProductItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCBehaviour>.NativeClassPtr, 100671637);
			NPCBehaviour.NativeMethodInfoPtr_OnKnockOut_Protected_Virtual_New_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCBehaviour>.NativeClassPtr, 100671638);
			NPCBehaviour.NativeMethodInfoPtr_OnDie_Protected_Virtual_New_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCBehaviour>.NativeClassPtr, 100671639);
			NPCBehaviour.NativeMethodInfoPtr_GetBehaviour_Public_Behaviour_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCBehaviour>.NativeClassPtr, 100671640);
			NPCBehaviour.NativeMethodInfoPtr_Update_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCBehaviour>.NativeClassPtr, 100671641);
			NPCBehaviour.NativeMethodInfoPtr_LateUpdate_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCBehaviour>.NativeClassPtr, 100671642);
			NPCBehaviour.NativeMethodInfoPtr_MinPass_Protected_Virtual_New_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCBehaviour>.NativeClassPtr, 100671643);
			NPCBehaviour.NativeMethodInfoPtr_SortBehaviourStack_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCBehaviour>.NativeClassPtr, 100671644);
			NPCBehaviour.NativeMethodInfoPtr_GetEnabledBehaviour_Private_Behaviour_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCBehaviour>.NativeClassPtr, 100671645);
			NPCBehaviour.NativeMethodInfoPtr_AddEnabledBehaviour_Private_Void_Behaviour_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCBehaviour>.NativeClassPtr, 100671646);
			NPCBehaviour.NativeMethodInfoPtr_RemoveEnabledBehaviour_Private_Void_Behaviour_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCBehaviour>.NativeClassPtr, 100671647);
			NPCBehaviour.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCBehaviour>.NativeClassPtr, 100671648);
			NPCBehaviour.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCBehaviour>.NativeClassPtr, 100671649);
			NPCBehaviour.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCBehaviour>.NativeClassPtr, 100671650);
			NPCBehaviour.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCBehaviour>.NativeClassPtr, 100671651);
			NPCBehaviour.NativeMethodInfoPtr_RpcWriter___Server_Summon_900355577_Private_Void_String_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCBehaviour>.NativeClassPtr, 100671652);
			NPCBehaviour.NativeMethodInfoPtr_RpcLogic___Summon_900355577_Public_Void_String_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCBehaviour>.NativeClassPtr, 100671653);
			NPCBehaviour.NativeMethodInfoPtr_RpcReader___Server_Summon_900355577_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCBehaviour>.NativeClassPtr, 100671654);
			NPCBehaviour.NativeMethodInfoPtr_RpcWriter___Server_ConsumeProduct_2622925554_Private_Void_ProductItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCBehaviour>.NativeClassPtr, 100671655);
			NPCBehaviour.NativeMethodInfoPtr_RpcLogic___ConsumeProduct_2622925554_Public_Void_ProductItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCBehaviour>.NativeClassPtr, 100671656);
			NPCBehaviour.NativeMethodInfoPtr_RpcReader___Server_ConsumeProduct_2622925554_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCBehaviour>.NativeClassPtr, 100671657);
			NPCBehaviour.NativeMethodInfoPtr_Method_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCBehaviour>.NativeClassPtr, 100671658);
		}

		// Token: 0x17001477 RID: 5239
		// (get) Token: 0x060043C0 RID: 17344 RVA: 0x00153BD0 File Offset: 0x00151DD0
		// (set) Token: 0x060043C1 RID: 17345 RVA: 0x00153C10 File Offset: 0x00151E10
		public unsafe Behaviour activeBehaviour
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCBehaviour.NativeMethodInfoPtr_get_activeBehaviour_Public_get_Behaviour_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Behaviour>(intPtr2) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 157249, XrefRangeEnd = 157250, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCBehaviour.NativeMethodInfoPtr_set_activeBehaviour_Public_set_Void_Behaviour_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x17001478 RID: 5240
		// (get) Token: 0x060043C2 RID: 17346 RVA: 0x00153C54 File Offset: 0x00151E54
		// (set) Token: 0x060043C3 RID: 17347 RVA: 0x00153C94 File Offset: 0x00151E94
		public unsafe NPC Npc
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 137931, RefRangeEnd = 137941, XrefRangeStart = 137931, XrefRangeEnd = 137941, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCBehaviour.NativeMethodInfoPtr_get_Npc_Public_get_NPC_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NPC>(intPtr2) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCBehaviour.NativeMethodInfoPtr_set_Npc_Private_set_Void_NPC_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x060043C4 RID: 17348 RVA: 0x00153CD8 File Offset: 0x00151ED8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 157250, XrefRangeEnd = 157264, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCBehaviour.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060043C5 RID: 17349 RVA: 0x00153D14 File Offset: 0x00151F14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 157264, XrefRangeEnd = 157321, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCBehaviour.NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_1), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060043C6 RID: 17350 RVA: 0x00153D50 File Offset: 0x00151F50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 157321, XrefRangeEnd = 157337, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCBehaviour.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060043C7 RID: 17351 RVA: 0x00153D84 File Offset: 0x00151F84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 157337, XrefRangeEnd = 157367, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnValidate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCBehaviour.NativeMethodInfoPtr_OnValidate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060043C8 RID: 17352 RVA: 0x00153DC0 File Offset: 0x00151FC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 157367, XrefRangeEnd = 157373, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnSpawnServer(NetworkConnection connection)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(connection);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCBehaviour.NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060043C9 RID: 17353 RVA: 0x00153E10 File Offset: 0x00152010
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 157386, RefRangeEnd = 157387, XrefRangeStart = 157373, XrefRangeEnd = 157386, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Summon(string buildingGUID, int doorIndex, float duration)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(buildingGUID);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref doorIndex;
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref duration;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCBehaviour.NativeMethodInfoPtr_Summon_Public_Void_String_Int32_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060043CA RID: 17354 RVA: 0x00153E70 File Offset: 0x00152070
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 157397, RefRangeEnd = 157398, XrefRangeStart = 157387, XrefRangeEnd = 157397, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ConsumeProduct(ProductItemInstance product)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(product);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCBehaviour.NativeMethodInfoPtr_ConsumeProduct_Public_Void_ProductItemInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060043CB RID: 17355 RVA: 0x00153EB4 File Offset: 0x001520B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 157398, XrefRangeEnd = 157432, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnKnockOut()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCBehaviour.NativeMethodInfoPtr_OnKnockOut_Protected_Virtual_New_Void_1), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060043CC RID: 17356 RVA: 0x00153EF0 File Offset: 0x001520F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 157432, XrefRangeEnd = 157434, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnDie()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCBehaviour.NativeMethodInfoPtr_OnDie_Protected_Virtual_New_Void_1), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060043CD RID: 17357 RVA: 0x00153F2C File Offset: 0x0015212C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 157461, RefRangeEnd = 157462, XrefRangeStart = 157434, XrefRangeEnd = 157461, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Behaviour GetBehaviour(string BehaviourName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(BehaviourName);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCBehaviour.NativeMethodInfoPtr_GetBehaviour_Public_Behaviour_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Behaviour>(intPtr2) : null;
		}

		// Token: 0x060043CE RID: 17358 RVA: 0x00153F7C File Offset: 0x0015217C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 157462, XrefRangeEnd = 157493, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCBehaviour.NativeMethodInfoPtr_Update_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060043CF RID: 17359 RVA: 0x00153FB8 File Offset: 0x001521B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 157493, XrefRangeEnd = 157497, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void LateUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCBehaviour.NativeMethodInfoPtr_LateUpdate_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060043D0 RID: 17360 RVA: 0x00153FF4 File Offset: 0x001521F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 157497, XrefRangeEnd = 157501, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void MinPass()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCBehaviour.NativeMethodInfoPtr_MinPass_Protected_Virtual_New_Void_1), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060043D1 RID: 17361 RVA: 0x00154030 File Offset: 0x00152230
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 157523, RefRangeEnd = 157524, XrefRangeStart = 157501, XrefRangeEnd = 157523, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SortBehaviourStack()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCBehaviour.NativeMethodInfoPtr_SortBehaviourStack_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060043D2 RID: 17362 RVA: 0x00154064 File Offset: 0x00152264
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 157524, XrefRangeEnd = 157527, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Behaviour GetEnabledBehaviour()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCBehaviour.NativeMethodInfoPtr_GetEnabledBehaviour_Private_Behaviour_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Behaviour>(intPtr2) : null;
		}

		// Token: 0x060043D3 RID: 17363 RVA: 0x001540A4 File Offset: 0x001522A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 157527, XrefRangeEnd = 157555, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddEnabledBehaviour(Behaviour b)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(b);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCBehaviour.NativeMethodInfoPtr_AddEnabledBehaviour_Private_Void_Behaviour_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060043D4 RID: 17364 RVA: 0x001540E8 File Offset: 0x001522E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 157555, XrefRangeEnd = 157583, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveEnabledBehaviour(Behaviour b)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(b);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCBehaviour.NativeMethodInfoPtr_RemoveEnabledBehaviour_Private_Void_Behaviour_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060043D5 RID: 17365 RVA: 0x0015412C File Offset: 0x0015232C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 157583, XrefRangeEnd = 157596, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NPCBehaviour() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NPCBehaviour>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCBehaviour.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060043D6 RID: 17366 RVA: 0x00154168 File Offset: 0x00152368
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 157596, XrefRangeEnd = 157609, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void NetworkInitialize___Early()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCBehaviour.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060043D7 RID: 17367 RVA: 0x001541A4 File Offset: 0x001523A4
		[CallerCount(0)]
		public unsafe virtual void NetworkInitialize__Late()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCBehaviour.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060043D8 RID: 17368 RVA: 0x001541E0 File Offset: 0x001523E0
		[CallerCount(0)]
		public unsafe override void NetworkInitializeIfDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCBehaviour.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060043D9 RID: 17369 RVA: 0x0015421C File Offset: 0x0015241C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 157386, RefRangeEnd = 157387, XrefRangeStart = 157386, XrefRangeEnd = 157387, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_Summon_900355577(string buildingGUID, int doorIndex, float duration)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(buildingGUID);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref doorIndex;
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref duration;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCBehaviour.NativeMethodInfoPtr_RpcWriter___Server_Summon_900355577_Private_Void_String_Int32_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060043DA RID: 17370 RVA: 0x0015427C File Offset: 0x0015247C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 157642, RefRangeEnd = 157643, XrefRangeStart = 157609, XrefRangeEnd = 157642, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___Summon_900355577(string buildingGUID, int doorIndex, float duration)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(buildingGUID);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref doorIndex;
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref duration;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCBehaviour.NativeMethodInfoPtr_RpcLogic___Summon_900355577_Public_Void_String_Int32_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060043DB RID: 17371 RVA: 0x001542DC File Offset: 0x001524DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 157643, XrefRangeEnd = 157649, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_Summon_900355577(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref channel;
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCBehaviour.NativeMethodInfoPtr_RpcReader___Server_Summon_900355577_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060043DC RID: 17372 RVA: 0x00154340 File Offset: 0x00152540
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 157397, RefRangeEnd = 157398, XrefRangeStart = 157397, XrefRangeEnd = 157398, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_ConsumeProduct_2622925554(ProductItemInstance product)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(product);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCBehaviour.NativeMethodInfoPtr_RpcWriter___Server_ConsumeProduct_2622925554_Private_Void_ProductItemInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060043DD RID: 17373 RVA: 0x00154384 File Offset: 0x00152584
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 157649, XrefRangeEnd = 157652, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___ConsumeProduct_2622925554(ProductItemInstance product)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(product);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCBehaviour.NativeMethodInfoPtr_RpcLogic___ConsumeProduct_2622925554_Public_Void_ProductItemInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060043DE RID: 17374 RVA: 0x001543C8 File Offset: 0x001525C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 157652, XrefRangeEnd = 157656, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_ConsumeProduct_2622925554(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref channel;
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCBehaviour.NativeMethodInfoPtr_RpcReader___Server_ConsumeProduct_2622925554_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060043DF RID: 17375 RVA: 0x0015442C File Offset: 0x0015262C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 157656, XrefRangeEnd = 157670, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Method_Protected_Virtual_New_Void_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCBehaviour.NativeMethodInfoPtr_Method_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060043E0 RID: 17376 RVA: 0x0002109C File Offset: 0x0001F29C
		public NPCBehaviour(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001460 RID: 5216
		// (get) Token: 0x060043E1 RID: 17377 RVA: 0x00154468 File Offset: 0x00152668
		// (set) Token: 0x060043E2 RID: 17378 RVA: 0x000210A5 File Offset: 0x0001F2A5
		public unsafe bool DEBUG_MODE
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NPCBehaviour.NativeFieldInfoPtr_DEBUG_MODE);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NPCBehaviour.NativeFieldInfoPtr_DEBUG_MODE)) = value;
			}
		}

		// Token: 0x17001461 RID: 5217
		// (get) Token: 0x060043E3 RID: 17379 RVA: 0x00154490 File Offset: 0x00152690
		// (set) Token: 0x060043E4 RID: 17380 RVA: 0x000210C0 File Offset: 0x0001F2C0
		public unsafe NPCScheduleManager ScheduleManager
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NPCBehaviour.NativeFieldInfoPtr_ScheduleManager);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NPCScheduleManager>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NPCBehaviour.NativeFieldInfoPtr_ScheduleManager), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001462 RID: 5218
		// (get) Token: 0x060043E5 RID: 17381 RVA: 0x001544C0 File Offset: 0x001526C0
		// (set) Token: 0x060043E6 RID: 17382 RVA: 0x000210DF File Offset: 0x0001F2DF
		public unsafe CoweringBehaviour CoweringBehaviour
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NPCBehaviour.NativeFieldInfoPtr_CoweringBehaviour);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CoweringBehaviour>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NPCBehaviour.NativeFieldInfoPtr_CoweringBehaviour), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001463 RID: 5219
		// (get) Token: 0x060043E7 RID: 17383 RVA: 0x001544F0 File Offset: 0x001526F0
		// (set) Token: 0x060043E8 RID: 17384 RVA: 0x000210FE File Offset: 0x0001F2FE
		public unsafe RagdollBehaviour RagdollBehaviour
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NPCBehaviour.NativeFieldInfoPtr_RagdollBehaviour);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RagdollBehaviour>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NPCBehaviour.NativeFieldInfoPtr_RagdollBehaviour), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001464 RID: 5220
		// (get) Token: 0x060043E9 RID: 17385 RVA: 0x00154520 File Offset: 0x00152720
		// (set) Token: 0x060043EA RID: 17386 RVA: 0x0002111D File Offset: 0x0001F31D
		public unsafe CallPoliceBehaviour CallPoliceBehaviour
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NPCBehaviour.NativeFieldInfoPtr_CallPoliceBehaviour);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CallPoliceBehaviour>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NPCBehaviour.NativeFieldInfoPtr_CallPoliceBehaviour), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001465 RID: 5221
		// (get) Token: 0x060043EB RID: 17387 RVA: 0x00154550 File Offset: 0x00152750
		// (set) Token: 0x060043EC RID: 17388 RVA: 0x0002113C File Offset: 0x0001F33C
		public unsafe GenericDialogueBehaviour GenericDialogueBehaviour
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NPCBehaviour.NativeFieldInfoPtr_GenericDialogueBehaviour);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GenericDialogueBehaviour>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NPCBehaviour.NativeFieldInfoPtr_GenericDialogueBehaviour), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001466 RID: 5222
		// (get) Token: 0x060043ED RID: 17389 RVA: 0x00154580 File Offset: 0x00152780
		// (set) Token: 0x060043EE RID: 17390 RVA: 0x0002115B File Offset: 0x0001F35B
		public unsafe HeavyFlinchBehaviour HeavyFlinchBehaviour
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NPCBehaviour.NativeFieldInfoPtr_HeavyFlinchBehaviour);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<HeavyFlinchBehaviour>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NPCBehaviour.NativeFieldInfoPtr_HeavyFlinchBehaviour), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001467 RID: 5223
		// (get) Token: 0x060043EF RID: 17391 RVA: 0x001545B0 File Offset: 0x001527B0
		// (set) Token: 0x060043F0 RID: 17392 RVA: 0x0002117A File Offset: 0x0001F37A
		public unsafe FacePlayerBehaviour FacePlayerBehaviour
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NPCBehaviour.NativeFieldInfoPtr_FacePlayerBehaviour);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FacePlayerBehaviour>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NPCBehaviour.NativeFieldInfoPtr_FacePlayerBehaviour), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001468 RID: 5224
		// (get) Token: 0x060043F1 RID: 17393 RVA: 0x001545E0 File Offset: 0x001527E0
		// (set) Token: 0x060043F2 RID: 17394 RVA: 0x00021199 File Offset: 0x0001F399
		public unsafe DeadBehaviour DeadBehaviour
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NPCBehaviour.NativeFieldInfoPtr_DeadBehaviour);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DeadBehaviour>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NPCBehaviour.NativeFieldInfoPtr_DeadBehaviour), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001469 RID: 5225
		// (get) Token: 0x060043F3 RID: 17395 RVA: 0x00154610 File Offset: 0x00152810
		// (set) Token: 0x060043F4 RID: 17396 RVA: 0x000211B8 File Offset: 0x0001F3B8
		public unsafe UnconsciousBehaviour UnconsciousBehaviour
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NPCBehaviour.NativeFieldInfoPtr_UnconsciousBehaviour);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnconsciousBehaviour>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NPCBehaviour.NativeFieldInfoPtr_UnconsciousBehaviour), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700146A RID: 5226
		// (get) Token: 0x060043F5 RID: 17397 RVA: 0x00154640 File Offset: 0x00152840
		// (set) Token: 0x060043F6 RID: 17398 RVA: 0x000211D7 File Offset: 0x0001F3D7
		public unsafe Behaviour SummonBehaviour
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NPCBehaviour.NativeFieldInfoPtr_SummonBehaviour);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Behaviour>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NPCBehaviour.NativeFieldInfoPtr_SummonBehaviour), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700146B RID: 5227
		// (get) Token: 0x060043F7 RID: 17399 RVA: 0x00154670 File Offset: 0x00152870
		// (set) Token: 0x060043F8 RID: 17400 RVA: 0x000211F6 File Offset: 0x0001F3F6
		public unsafe ConsumeProductBehaviour ConsumeProductBehaviour
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NPCBehaviour.NativeFieldInfoPtr_ConsumeProductBehaviour);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ConsumeProductBehaviour>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NPCBehaviour.NativeFieldInfoPtr_ConsumeProductBehaviour), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700146C RID: 5228
		// (get) Token: 0x060043F9 RID: 17401 RVA: 0x001546A0 File Offset: 0x001528A0
		// (set) Token: 0x060043FA RID: 17402 RVA: 0x00021215 File Offset: 0x0001F415
		public unsafe CombatBehaviour CombatBehaviour
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NPCBehaviour.NativeFieldInfoPtr_CombatBehaviour);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CombatBehaviour>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NPCBehaviour.NativeFieldInfoPtr_CombatBehaviour), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700146D RID: 5229
		// (get) Token: 0x060043FB RID: 17403 RVA: 0x001546D0 File Offset: 0x001528D0
		// (set) Token: 0x060043FC RID: 17404 RVA: 0x00021234 File Offset: 0x0001F434
		public unsafe FleeBehaviour FleeBehaviour
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NPCBehaviour.NativeFieldInfoPtr_FleeBehaviour);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FleeBehaviour>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NPCBehaviour.NativeFieldInfoPtr_FleeBehaviour), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700146E RID: 5230
		// (get) Token: 0x060043FD RID: 17405 RVA: 0x00154700 File Offset: 0x00152900
		// (set) Token: 0x060043FE RID: 17406 RVA: 0x00021253 File Offset: 0x0001F453
		public unsafe StationaryBehaviour StationaryBehaviour
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NPCBehaviour.NativeFieldInfoPtr_StationaryBehaviour);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StationaryBehaviour>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NPCBehaviour.NativeFieldInfoPtr_StationaryBehaviour), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700146F RID: 5231
		// (get) Token: 0x060043FF RID: 17407 RVA: 0x00154730 File Offset: 0x00152930
		// (set) Token: 0x06004400 RID: 17408 RVA: 0x00021272 File Offset: 0x0001F472
		public unsafe RequestProductBehaviour RequestProductBehaviour
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NPCBehaviour.NativeFieldInfoPtr_RequestProductBehaviour);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RequestProductBehaviour>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NPCBehaviour.NativeFieldInfoPtr_RequestProductBehaviour), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001470 RID: 5232
		// (get) Token: 0x06004401 RID: 17409 RVA: 0x00154760 File Offset: 0x00152960
		// (set) Token: 0x06004402 RID: 17410 RVA: 0x00021291 File Offset: 0x0001F491
		public unsafe List<Behaviour> behaviourStack
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NPCBehaviour.NativeFieldInfoPtr_behaviourStack);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Behaviour>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NPCBehaviour.NativeFieldInfoPtr_behaviourStack), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001471 RID: 5233
		// (get) Token: 0x06004403 RID: 17411 RVA: 0x00154790 File Offset: 0x00152990
		// (set) Token: 0x06004404 RID: 17412 RVA: 0x000212B0 File Offset: 0x0001F4B0
		public unsafe Behaviour _activeBehaviour_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NPCBehaviour.NativeFieldInfoPtr__activeBehaviour_k__BackingField);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Behaviour>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NPCBehaviour.NativeFieldInfoPtr__activeBehaviour_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001472 RID: 5234
		// (get) Token: 0x06004405 RID: 17413 RVA: 0x001547C0 File Offset: 0x001529C0
		// (set) Token: 0x06004406 RID: 17414 RVA: 0x000212CF File Offset: 0x0001F4CF
		public unsafe NPC _Npc_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NPCBehaviour.NativeFieldInfoPtr__Npc_k__BackingField);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NPC>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NPCBehaviour.NativeFieldInfoPtr__Npc_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001473 RID: 5235
		// (get) Token: 0x06004407 RID: 17415 RVA: 0x001547F0 File Offset: 0x001529F0
		// (set) Token: 0x06004408 RID: 17416 RVA: 0x000212EE File Offset: 0x0001F4EE
		public unsafe Coroutine summonRoutine
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NPCBehaviour.NativeFieldInfoPtr_summonRoutine);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NPCBehaviour.NativeFieldInfoPtr_summonRoutine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001474 RID: 5236
		// (get) Token: 0x06004409 RID: 17417 RVA: 0x00154820 File Offset: 0x00152A20
		// (set) Token: 0x0600440A RID: 17418 RVA: 0x0002130D File Offset: 0x0001F50D
		public unsafe List<Behaviour> enabledBehaviours
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NPCBehaviour.NativeFieldInfoPtr_enabledBehaviours);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Behaviour>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NPCBehaviour.NativeFieldInfoPtr_enabledBehaviours), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001475 RID: 5237
		// (get) Token: 0x0600440B RID: 17419 RVA: 0x00154850 File Offset: 0x00152A50
		// (set) Token: 0x0600440C RID: 17420 RVA: 0x0002132C File Offset: 0x0001F52C
		public unsafe bool field_Private_Boolean_0
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NPCBehaviour.NativeFieldInfoPtr_field_Private_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NPCBehaviour.NativeFieldInfoPtr_field_Private_Boolean_0)) = value;
			}
		}

		// Token: 0x17001476 RID: 5238
		// (get) Token: 0x0600440D RID: 17421 RVA: 0x00154878 File Offset: 0x00152A78
		// (set) Token: 0x0600440E RID: 17422 RVA: 0x00021347 File Offset: 0x0001F547
		public unsafe bool field_Private_Boolean_1
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NPCBehaviour.NativeFieldInfoPtr_field_Private_Boolean_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NPCBehaviour.NativeFieldInfoPtr_field_Private_Boolean_1)) = value;
			}
		}

		// Token: 0x04002D45 RID: 11589
		private static readonly System.IntPtr NativeFieldInfoPtr_DEBUG_MODE;

		// Token: 0x04002D46 RID: 11590
		private static readonly System.IntPtr NativeFieldInfoPtr_ScheduleManager;

		// Token: 0x04002D47 RID: 11591
		private static readonly System.IntPtr NativeFieldInfoPtr_CoweringBehaviour;

		// Token: 0x04002D48 RID: 11592
		private static readonly System.IntPtr NativeFieldInfoPtr_RagdollBehaviour;

		// Token: 0x04002D49 RID: 11593
		private static readonly System.IntPtr NativeFieldInfoPtr_CallPoliceBehaviour;

		// Token: 0x04002D4A RID: 11594
		private static readonly System.IntPtr NativeFieldInfoPtr_GenericDialogueBehaviour;

		// Token: 0x04002D4B RID: 11595
		private static readonly System.IntPtr NativeFieldInfoPtr_HeavyFlinchBehaviour;

		// Token: 0x04002D4C RID: 11596
		private static readonly System.IntPtr NativeFieldInfoPtr_FacePlayerBehaviour;

		// Token: 0x04002D4D RID: 11597
		private static readonly System.IntPtr NativeFieldInfoPtr_DeadBehaviour;

		// Token: 0x04002D4E RID: 11598
		private static readonly System.IntPtr NativeFieldInfoPtr_UnconsciousBehaviour;

		// Token: 0x04002D4F RID: 11599
		private static readonly System.IntPtr NativeFieldInfoPtr_SummonBehaviour;

		// Token: 0x04002D50 RID: 11600
		private static readonly System.IntPtr NativeFieldInfoPtr_ConsumeProductBehaviour;

		// Token: 0x04002D51 RID: 11601
		private static readonly System.IntPtr NativeFieldInfoPtr_CombatBehaviour;

		// Token: 0x04002D52 RID: 11602
		private static readonly System.IntPtr NativeFieldInfoPtr_FleeBehaviour;

		// Token: 0x04002D53 RID: 11603
		private static readonly System.IntPtr NativeFieldInfoPtr_StationaryBehaviour;

		// Token: 0x04002D54 RID: 11604
		private static readonly System.IntPtr NativeFieldInfoPtr_RequestProductBehaviour;

		// Token: 0x04002D55 RID: 11605
		private static readonly System.IntPtr NativeFieldInfoPtr_behaviourStack;

		// Token: 0x04002D56 RID: 11606
		private static readonly System.IntPtr NativeFieldInfoPtr__activeBehaviour_k__BackingField;

		// Token: 0x04002D57 RID: 11607
		private static readonly System.IntPtr NativeFieldInfoPtr__Npc_k__BackingField;

		// Token: 0x04002D58 RID: 11608
		private static readonly System.IntPtr NativeFieldInfoPtr_summonRoutine;

		// Token: 0x04002D59 RID: 11609
		private static readonly System.IntPtr NativeFieldInfoPtr_enabledBehaviours;

		// Token: 0x04002D5A RID: 11610
		private static readonly System.IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

		// Token: 0x04002D5B RID: 11611
		private static readonly System.IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

		// Token: 0x04002D5C RID: 11612
		private static readonly System.IntPtr NativeMethodInfoPtr_get_activeBehaviour_Public_get_Behaviour_0;

		// Token: 0x04002D5D RID: 11613
		private static readonly System.IntPtr NativeMethodInfoPtr_set_activeBehaviour_Public_set_Void_Behaviour_0;

		// Token: 0x04002D5E RID: 11614
		private static readonly System.IntPtr NativeMethodInfoPtr_get_Npc_Public_get_NPC_0;

		// Token: 0x04002D5F RID: 11615
		private static readonly System.IntPtr NativeMethodInfoPtr_set_Npc_Private_set_Void_NPC_0;

		// Token: 0x04002D60 RID: 11616
		private static readonly System.IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;

		// Token: 0x04002D61 RID: 11617
		private static readonly System.IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_1;

		// Token: 0x04002D62 RID: 11618
		private static readonly System.IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

		// Token: 0x04002D63 RID: 11619
		private static readonly System.IntPtr NativeMethodInfoPtr_OnValidate_Protected_Virtual_Void_0;

		// Token: 0x04002D64 RID: 11620
		private static readonly System.IntPtr NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0;

		// Token: 0x04002D65 RID: 11621
		private static readonly System.IntPtr NativeMethodInfoPtr_Summon_Public_Void_String_Int32_Single_0;

		// Token: 0x04002D66 RID: 11622
		private static readonly System.IntPtr NativeMethodInfoPtr_ConsumeProduct_Public_Void_ProductItemInstance_0;

		// Token: 0x04002D67 RID: 11623
		private static readonly System.IntPtr NativeMethodInfoPtr_OnKnockOut_Protected_Virtual_New_Void_1;

		// Token: 0x04002D68 RID: 11624
		private static readonly System.IntPtr NativeMethodInfoPtr_OnDie_Protected_Virtual_New_Void_1;

		// Token: 0x04002D69 RID: 11625
		private static readonly System.IntPtr NativeMethodInfoPtr_GetBehaviour_Public_Behaviour_String_0;

		// Token: 0x04002D6A RID: 11626
		private static readonly System.IntPtr NativeMethodInfoPtr_Update_Public_Virtual_New_Void_0;

		// Token: 0x04002D6B RID: 11627
		private static readonly System.IntPtr NativeMethodInfoPtr_LateUpdate_Public_Virtual_New_Void_0;

		// Token: 0x04002D6C RID: 11628
		private static readonly System.IntPtr NativeMethodInfoPtr_MinPass_Protected_Virtual_New_Void_1;

		// Token: 0x04002D6D RID: 11629
		private static readonly System.IntPtr NativeMethodInfoPtr_SortBehaviourStack_Public_Void_0;

		// Token: 0x04002D6E RID: 11630
		private static readonly System.IntPtr NativeMethodInfoPtr_GetEnabledBehaviour_Private_Behaviour_0;

		// Token: 0x04002D6F RID: 11631
		private static readonly System.IntPtr NativeMethodInfoPtr_AddEnabledBehaviour_Private_Void_Behaviour_0;

		// Token: 0x04002D70 RID: 11632
		private static readonly System.IntPtr NativeMethodInfoPtr_RemoveEnabledBehaviour_Private_Void_Behaviour_0;

		// Token: 0x04002D71 RID: 11633
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04002D72 RID: 11634
		private static readonly System.IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

		// Token: 0x04002D73 RID: 11635
		private static readonly System.IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

		// Token: 0x04002D74 RID: 11636
		private static readonly System.IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

		// Token: 0x04002D75 RID: 11637
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcWriter___Server_Summon_900355577_Private_Void_String_Int32_Single_0;

		// Token: 0x04002D76 RID: 11638
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcLogic___Summon_900355577_Public_Void_String_Int32_Single_0;

		// Token: 0x04002D77 RID: 11639
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcReader___Server_Summon_900355577_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x04002D78 RID: 11640
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcWriter___Server_ConsumeProduct_2622925554_Private_Void_ProductItemInstance_0;

		// Token: 0x04002D79 RID: 11641
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcLogic___ConsumeProduct_2622925554_Public_Void_ProductItemInstance_0;

		// Token: 0x04002D7A RID: 11642
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcReader___Server_ConsumeProduct_2622925554_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x04002D7B RID: 11643
		private static readonly System.IntPtr NativeMethodInfoPtr_Method_Protected_Virtual_New_Void_0;

		// Token: 0x020009A9 RID: 2473
		[ObfuscatedName("ScheduleOne.NPCs.Behaviour.NPCBehaviour+<>c")]
		[System.Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x0600CE02 RID: 52738 RVA: 0x003204E8 File Offset: 0x0031E6E8
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<NPCBehaviour.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NPCBehaviour>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NPCBehaviour.__c>.NativeClassPtr);
				NPCBehaviour.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCBehaviour.__c>.NativeClassPtr, "<>9");
				NPCBehaviour.__c.NativeFieldInfoPtr___9__40_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCBehaviour.__c>.NativeClassPtr, "<>9__40_0");
				NPCBehaviour.__c.NativeFieldInfoPtr___9__42_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCBehaviour.__c>.NativeClassPtr, "<>9__42_0");
				NPCBehaviour.__c.NativeFieldInfoPtr___9__43_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCBehaviour.__c>.NativeClassPtr, "<>9__43_0");
				NPCBehaviour.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCBehaviour.__c>.NativeClassPtr, 100671660);
				NPCBehaviour.__c.NativeMethodInfoPtr__SortBehaviourStack_b__40_0_Internal_Int32_Behaviour_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCBehaviour.__c>.NativeClassPtr, 100671661);
				NPCBehaviour.__c.NativeMethodInfoPtr__AddEnabledBehaviour_b__42_0_Internal_Int32_Behaviour_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCBehaviour.__c>.NativeClassPtr, 100671662);
				NPCBehaviour.__c.NativeMethodInfoPtr__RemoveEnabledBehaviour_b__43_0_Internal_Int32_Behaviour_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCBehaviour.__c>.NativeClassPtr, 100671663);
			}

			// Token: 0x0600CE03 RID: 52739 RVA: 0x003205B4 File Offset: 0x0031E7B4
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NPCBehaviour.__c>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCBehaviour.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600CE04 RID: 52740 RVA: 0x003205F0 File Offset: 0x0031E7F0
			[CallerCount(0)]
			public unsafe int _SortBehaviourStack_b__40_0(Behaviour x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NPCBehaviour.__c.NativeMethodInfoPtr__SortBehaviourStack_b__40_0_Internal_Int32_Behaviour_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x0600CE05 RID: 52741 RVA: 0x00320640 File Offset: 0x0031E840
			[CallerCount(0)]
			public unsafe int _AddEnabledBehaviour_b__42_0(Behaviour x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NPCBehaviour.__c.NativeMethodInfoPtr__AddEnabledBehaviour_b__42_0_Internal_Int32_Behaviour_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x0600CE06 RID: 52742 RVA: 0x00320690 File Offset: 0x0031E890
			[CallerCount(0)]
			public unsafe int _RemoveEnabledBehaviour_b__43_0(Behaviour x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NPCBehaviour.__c.NativeMethodInfoPtr__RemoveEnabledBehaviour_b__43_0_Internal_Int32_Behaviour_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x0600CE07 RID: 52743 RVA: 0x00063E54 File Offset: 0x00062054
			public __c(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003FF4 RID: 16372
			// (get) Token: 0x0600CE08 RID: 52744 RVA: 0x003206E0 File Offset: 0x0031E8E0
			// (set) Token: 0x0600CE09 RID: 52745 RVA: 0x00063E5D File Offset: 0x0006205D
			public unsafe static NPCBehaviour.__c __9
			{
				get
				{
					System.IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(NPCBehaviour.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<NPCBehaviour.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(NPCBehaviour.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003FF5 RID: 16373
			// (get) Token: 0x0600CE0A RID: 52746 RVA: 0x00320708 File Offset: 0x0031E908
			// (set) Token: 0x0600CE0B RID: 52747 RVA: 0x00063E6F File Offset: 0x0006206F
			public unsafe static Il2CppSystem.Func<Behaviour, int> __9__40_0
			{
				get
				{
					System.IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(NPCBehaviour.__c.NativeFieldInfoPtr___9__40_0, (void*)(&intPtr));
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Func<Behaviour, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(NPCBehaviour.__c.NativeFieldInfoPtr___9__40_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003FF6 RID: 16374
			// (get) Token: 0x0600CE0C RID: 52748 RVA: 0x00320730 File Offset: 0x0031E930
			// (set) Token: 0x0600CE0D RID: 52749 RVA: 0x00063E81 File Offset: 0x00062081
			public unsafe static Il2CppSystem.Func<Behaviour, int> __9__42_0
			{
				get
				{
					System.IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(NPCBehaviour.__c.NativeFieldInfoPtr___9__42_0, (void*)(&intPtr));
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Func<Behaviour, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(NPCBehaviour.__c.NativeFieldInfoPtr___9__42_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003FF7 RID: 16375
			// (get) Token: 0x0600CE0E RID: 52750 RVA: 0x00320758 File Offset: 0x0031E958
			// (set) Token: 0x0600CE0F RID: 52751 RVA: 0x00063E93 File Offset: 0x00062093
			public unsafe static Il2CppSystem.Func<Behaviour, int> __9__43_0
			{
				get
				{
					System.IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(NPCBehaviour.__c.NativeFieldInfoPtr___9__43_0, (void*)(&intPtr));
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Func<Behaviour, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(NPCBehaviour.__c.NativeFieldInfoPtr___9__43_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008B7C RID: 35708
			private static readonly System.IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04008B7D RID: 35709
			private static readonly System.IntPtr NativeFieldInfoPtr___9__40_0;

			// Token: 0x04008B7E RID: 35710
			private static readonly System.IntPtr NativeFieldInfoPtr___9__42_0;

			// Token: 0x04008B7F RID: 35711
			private static readonly System.IntPtr NativeFieldInfoPtr___9__43_0;

			// Token: 0x04008B80 RID: 35712
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008B81 RID: 35713
			private static readonly System.IntPtr NativeMethodInfoPtr__SortBehaviourStack_b__40_0_Internal_Int32_Behaviour_0;

			// Token: 0x04008B82 RID: 35714
			private static readonly System.IntPtr NativeMethodInfoPtr__AddEnabledBehaviour_b__42_0_Internal_Int32_Behaviour_0;

			// Token: 0x04008B83 RID: 35715
			private static readonly System.IntPtr NativeMethodInfoPtr__RemoveEnabledBehaviour_b__43_0_Internal_Int32_Behaviour_0;
		}

		// Token: 0x020009AA RID: 2474
		[ObfuscatedName("ScheduleOne.NPCs.Behaviour.NPCBehaviour+<>c__DisplayClass28_0")]
		public sealed class __c__DisplayClass28_0 : Il2CppSystem.Object
		{
			// Token: 0x0600CE10 RID: 52752 RVA: 0x00320780 File Offset: 0x0031E980
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass28_0()
			{
				Il2CppClassPointerStore<NPCBehaviour.__c__DisplayClass28_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NPCBehaviour>.NativeClassPtr, "<>c__DisplayClass28_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NPCBehaviour.__c__DisplayClass28_0>.NativeClassPtr);
				NPCBehaviour.__c__DisplayClass28_0.NativeFieldInfoPtr_b = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCBehaviour.__c__DisplayClass28_0>.NativeClassPtr, "b");
				NPCBehaviour.__c__DisplayClass28_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCBehaviour.__c__DisplayClass28_0>.NativeClassPtr, "<>4__this");
				NPCBehaviour.__c__DisplayClass28_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCBehaviour.__c__DisplayClass28_0>.NativeClassPtr, 100671664);
				NPCBehaviour.__c__DisplayClass28_0.NativeMethodInfoPtr__Start_b__0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCBehaviour.__c__DisplayClass28_0>.NativeClassPtr, 100671665);
				NPCBehaviour.__c__DisplayClass28_0.NativeMethodInfoPtr__Start_b__1_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCBehaviour.__c__DisplayClass28_0>.NativeClassPtr, 100671666);
			}

			// Token: 0x0600CE11 RID: 52753 RVA: 0x00320810 File Offset: 0x0031EA10
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass28_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NPCBehaviour.__c__DisplayClass28_0>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCBehaviour.__c__DisplayClass28_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600CE12 RID: 52754 RVA: 0x0032084C File Offset: 0x0031EA4C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 157157, XrefRangeEnd = 157185, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _Start_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCBehaviour.__c__DisplayClass28_0.NativeMethodInfoPtr__Start_b__0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600CE13 RID: 52755 RVA: 0x00320880 File Offset: 0x0031EA80
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 157185, XrefRangeEnd = 157213, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _Start_b__1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCBehaviour.__c__DisplayClass28_0.NativeMethodInfoPtr__Start_b__1_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600CE14 RID: 52756 RVA: 0x00063EA5 File Offset: 0x000620A5
			public __c__DisplayClass28_0(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003FF8 RID: 16376
			// (get) Token: 0x0600CE15 RID: 52757 RVA: 0x003208B4 File Offset: 0x0031EAB4
			// (set) Token: 0x0600CE16 RID: 52758 RVA: 0x00063EAE File Offset: 0x000620AE
			public unsafe Behaviour b
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NPCBehaviour.__c__DisplayClass28_0.NativeFieldInfoPtr_b);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Behaviour>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NPCBehaviour.__c__DisplayClass28_0.NativeFieldInfoPtr_b), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003FF9 RID: 16377
			// (get) Token: 0x0600CE17 RID: 52759 RVA: 0x003208E4 File Offset: 0x0031EAE4
			// (set) Token: 0x0600CE18 RID: 52760 RVA: 0x00063ECD File Offset: 0x000620CD
			public unsafe NPCBehaviour __4__this
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NPCBehaviour.__c__DisplayClass28_0.NativeFieldInfoPtr___4__this);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<NPCBehaviour>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NPCBehaviour.__c__DisplayClass28_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008B84 RID: 35716
			private static readonly System.IntPtr NativeFieldInfoPtr_b;

			// Token: 0x04008B85 RID: 35717
			private static readonly System.IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04008B86 RID: 35718
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008B87 RID: 35719
			private static readonly System.IntPtr NativeMethodInfoPtr__Start_b__0_Internal_Void_0;

			// Token: 0x04008B88 RID: 35720
			private static readonly System.IntPtr NativeMethodInfoPtr__Start_b__1_Internal_Void_0;
		}

		// Token: 0x020009AB RID: 2475
		[ObfuscatedName("ScheduleOne.NPCs.Behaviour.NPCBehaviour+<>c__DisplayClass32_0")]
		public sealed class __c__DisplayClass32_0 : Il2CppSystem.Object
		{
			// Token: 0x0600CE19 RID: 52761 RVA: 0x00320914 File Offset: 0x0031EB14
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass32_0()
			{
				Il2CppClassPointerStore<NPCBehaviour.__c__DisplayClass32_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NPCBehaviour>.NativeClassPtr, "<>c__DisplayClass32_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NPCBehaviour.__c__DisplayClass32_0>.NativeClassPtr);
				NPCBehaviour.__c__DisplayClass32_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCBehaviour.__c__DisplayClass32_0>.NativeClassPtr, "<>4__this");
				NPCBehaviour.__c__DisplayClass32_0.NativeFieldInfoPtr_duration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCBehaviour.__c__DisplayClass32_0>.NativeClassPtr, "duration");
				NPCBehaviour.__c__DisplayClass32_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCBehaviour.__c__DisplayClass32_0>.NativeClassPtr, 100671667);
				NPCBehaviour.__c__DisplayClass32_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCBehaviour.__c__DisplayClass32_0>.NativeClassPtr, 100671668);
			}

			// Token: 0x0600CE1A RID: 52762 RVA: 0x00320990 File Offset: 0x0031EB90
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass32_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NPCBehaviour.__c__DisplayClass32_0>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCBehaviour.__c__DisplayClass32_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600CE1B RID: 52763 RVA: 0x003209CC File Offset: 0x0031EBCC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 157226, XrefRangeEnd = 157231, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator Method_Internal_IEnumerator_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCBehaviour.__c__DisplayClass32_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr2) : null;
			}

			// Token: 0x0600CE1C RID: 52764 RVA: 0x00063EEC File Offset: 0x000620EC
			public __c__DisplayClass32_0(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003FFA RID: 16378
			// (get) Token: 0x0600CE1D RID: 52765 RVA: 0x00320A0C File Offset: 0x0031EC0C
			// (set) Token: 0x0600CE1E RID: 52766 RVA: 0x00063EF5 File Offset: 0x000620F5
			public unsafe NPCBehaviour __4__this
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NPCBehaviour.__c__DisplayClass32_0.NativeFieldInfoPtr___4__this);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<NPCBehaviour>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NPCBehaviour.__c__DisplayClass32_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003FFB RID: 16379
			// (get) Token: 0x0600CE1F RID: 52767 RVA: 0x00320A3C File Offset: 0x0031EC3C
			// (set) Token: 0x0600CE20 RID: 52768 RVA: 0x00063F14 File Offset: 0x00062114
			public unsafe float duration
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NPCBehaviour.__c__DisplayClass32_0.NativeFieldInfoPtr_duration);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NPCBehaviour.__c__DisplayClass32_0.NativeFieldInfoPtr_duration)) = value;
				}
			}

			// Token: 0x04008B89 RID: 35721
			private static readonly System.IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04008B8A RID: 35722
			private static readonly System.IntPtr NativeFieldInfoPtr_duration;

			// Token: 0x04008B8B RID: 35723
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008B8C RID: 35724
			private static readonly System.IntPtr NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0;

			// Token: 0x02000C9B RID: 3227
			[ObfuscatedName("ScheduleOne.NPCs.Behaviour.NPCBehaviour+<>c__DisplayClass32_0+<<Summon>g__Routine|0>d")]
			public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique : Il2CppSystem.Object
			{
				// Token: 0x0600E7BB RID: 59323 RVA: 0x00368FB4 File Offset: 0x003671B4
				// Note: this type is marked as 'beforefieldinit'.
				static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique()
				{
					Il2CppClassPointerStore<NPCBehaviour.__c__DisplayClass32_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NPCBehaviour.__c__DisplayClass32_0>.NativeClassPtr, "<<Summon>g__Routine|0>d");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NPCBehaviour.__c__DisplayClass32_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr);
					NPCBehaviour.__c__DisplayClass32_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCBehaviour.__c__DisplayClass32_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr, "<>1__state");
					NPCBehaviour.__c__DisplayClass32_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCBehaviour.__c__DisplayClass32_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr, "<>2__current");
					NPCBehaviour.__c__DisplayClass32_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCBehaviour.__c__DisplayClass32_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr, "<>4__this");
					NPCBehaviour.__c__DisplayClass32_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeFieldInfoPtr__t_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCBehaviour.__c__DisplayClass32_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr, "<t>5__2");
					NPCBehaviour.__c__DisplayClass32_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCBehaviour.__c__DisplayClass32_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr, 100671669);
					NPCBehaviour.__c__DisplayClass32_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCBehaviour.__c__DisplayClass32_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr, 100671670);
					NPCBehaviour.__c__DisplayClass32_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCBehaviour.__c__DisplayClass32_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr, 100671671);
					NPCBehaviour.__c__DisplayClass32_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCBehaviour.__c__DisplayClass32_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr, 100671672);
					NPCBehaviour.__c__DisplayClass32_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCBehaviour.__c__DisplayClass32_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr, 100671673);
					NPCBehaviour.__c__DisplayClass32_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCBehaviour.__c__DisplayClass32_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr, 100671674);
				}

				// Token: 0x0600E7BC RID: 59324 RVA: 0x003690A8 File Offset: 0x003672A8
				[CallerCount(54)]
				[CachedScanResults(RefRangeStart = 2646, RefRangeEnd = 2700, XrefRangeStart = 2646, XrefRangeEnd = 2700, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NPCBehaviour.__c__DisplayClass32_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr))
				{
					System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
					*ptr = ref <>1__state;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCBehaviour.__c__DisplayClass32_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				}

				// Token: 0x0600E7BD RID: 59325 RVA: 0x003690F0 File Offset: 0x003672F0
				[CallerCount(14558)]
				[CachedScanResults(RefRangeStart = 2769, RefRangeEnd = 17327, XrefRangeStart = 2769, XrefRangeEnd = 17327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCBehaviour.__c__DisplayClass32_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				}

				// Token: 0x0600E7BE RID: 59326 RVA: 0x00369124 File Offset: 0x00367324
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 157213, XrefRangeEnd = 157221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NPCBehaviour.__c__DisplayClass32_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
					return *IL2CPP.il2cpp_object_unbox(obj);
				}

				// Token: 0x17004789 RID: 18313
				// (get) Token: 0x0600E7BF RID: 59327 RVA: 0x00369160 File Offset: 0x00367360
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(24)]
					[CachedScanResults(RefRangeStart = 2740, RefRangeEnd = 2764, XrefRangeStart = 2740, XrefRangeEnd = 2764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						System.IntPtr* param = null;
						System.IntPtr returnedException;
						System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCBehaviour.__c__DisplayClass32_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
						Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
						System.IntPtr intPtr2 = intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
				}

				// Token: 0x0600E7C0 RID: 59328 RVA: 0x003691A0 File Offset: 0x003673A0
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 157221, XrefRangeEnd = 157226, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCBehaviour.__c__DisplayClass32_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				}

				// Token: 0x1700478A RID: 18314
				// (get) Token: 0x0600E7C1 RID: 59329 RVA: 0x003691D4 File Offset: 0x003673D4
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(24)]
					[CachedScanResults(RefRangeStart = 2740, RefRangeEnd = 2764, XrefRangeStart = 2740, XrefRangeEnd = 2764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						System.IntPtr* param = null;
						System.IntPtr returnedException;
						System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCBehaviour.__c__DisplayClass32_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
						Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
						System.IntPtr intPtr2 = intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
				}

				// Token: 0x0600E7C2 RID: 59330 RVA: 0x00070A9A File Offset: 0x0006EC9A
				public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique(System.IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x17004785 RID: 18309
				// (get) Token: 0x0600E7C3 RID: 59331 RVA: 0x00369214 File Offset: 0x00367414
				// (set) Token: 0x0600E7C4 RID: 59332 RVA: 0x00070AA3 File Offset: 0x0006ECA3
				public unsafe int __1__state
				{
					get
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NPCBehaviour.__c__DisplayClass32_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NPCBehaviour.__c__DisplayClass32_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x17004786 RID: 18310
				// (get) Token: 0x0600E7C5 RID: 59333 RVA: 0x0036923C File Offset: 0x0036743C
				// (set) Token: 0x0600E7C6 RID: 59334 RVA: 0x00070ABE File Offset: 0x0006ECBE
				public unsafe Il2CppSystem.Object __2__current
				{
					get
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NPCBehaviour.__c__DisplayClass32_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeFieldInfoPtr___2__current);
						System.IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
					set
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NPCBehaviour.__c__DisplayClass32_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17004787 RID: 18311
				// (get) Token: 0x0600E7C7 RID: 59335 RVA: 0x0036926C File Offset: 0x0036746C
				// (set) Token: 0x0600E7C8 RID: 59336 RVA: 0x00070ADD File Offset: 0x0006ECDD
				public unsafe NPCBehaviour.__c__DisplayClass32_0 __4__this
				{
					get
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NPCBehaviour.__c__DisplayClass32_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeFieldInfoPtr___4__this);
						System.IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<NPCBehaviour.__c__DisplayClass32_0>(intPtr2) : null;
					}
					set
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NPCBehaviour.__c__DisplayClass32_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17004788 RID: 18312
				// (get) Token: 0x0600E7C9 RID: 59337 RVA: 0x0036929C File Offset: 0x0036749C
				// (set) Token: 0x0600E7CA RID: 59338 RVA: 0x00070AFC File Offset: 0x0006ECFC
				public unsafe float _t_5__2
				{
					get
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NPCBehaviour.__c__DisplayClass32_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeFieldInfoPtr__t_5__2);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NPCBehaviour.__c__DisplayClass32_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeFieldInfoPtr__t_5__2)) = value;
					}
				}

				// Token: 0x04009B2B RID: 39723
				private static readonly System.IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x04009B2C RID: 39724
				private static readonly System.IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x04009B2D RID: 39725
				private static readonly System.IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x04009B2E RID: 39726
				private static readonly System.IntPtr NativeFieldInfoPtr__t_5__2;

				// Token: 0x04009B2F RID: 39727
				private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x04009B30 RID: 39728
				private static readonly System.IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x04009B31 RID: 39729
				private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x04009B32 RID: 39730
				private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x04009B33 RID: 39731
				private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x04009B34 RID: 39732
				private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
			}
		}

		// Token: 0x020009AC RID: 2476
		[ObfuscatedName("ScheduleOne.NPCs.Behaviour.NPCBehaviour+<>c__DisplayClass36_0")]
		public sealed class __c__DisplayClass36_0 : Il2CppSystem.Object
		{
			// Token: 0x0600CE21 RID: 52769 RVA: 0x00320A64 File Offset: 0x0031EC64
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass36_0()
			{
				Il2CppClassPointerStore<NPCBehaviour.__c__DisplayClass36_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NPCBehaviour>.NativeClassPtr, "<>c__DisplayClass36_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NPCBehaviour.__c__DisplayClass36_0>.NativeClassPtr);
				NPCBehaviour.__c__DisplayClass36_0.NativeFieldInfoPtr_BehaviourName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCBehaviour.__c__DisplayClass36_0>.NativeClassPtr, "BehaviourName");
				NPCBehaviour.__c__DisplayClass36_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCBehaviour.__c__DisplayClass36_0>.NativeClassPtr, 100671675);
				NPCBehaviour.__c__DisplayClass36_0.NativeMethodInfoPtr__GetBehaviour_b__0_Internal_Boolean_Behaviour_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCBehaviour.__c__DisplayClass36_0>.NativeClassPtr, 100671676);
			}

			// Token: 0x0600CE22 RID: 52770 RVA: 0x00320ACC File Offset: 0x0031ECCC
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass36_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NPCBehaviour.__c__DisplayClass36_0>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCBehaviour.__c__DisplayClass36_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600CE23 RID: 52771 RVA: 0x00320B08 File Offset: 0x0031ED08
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 157231, XrefRangeEnd = 157249, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GetBehaviour_b__0(Behaviour x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NPCBehaviour.__c__DisplayClass36_0.NativeMethodInfoPtr__GetBehaviour_b__0_Internal_Boolean_Behaviour_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x0600CE24 RID: 52772 RVA: 0x00063F2F File Offset: 0x0006212F
			public __c__DisplayClass36_0(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003FFC RID: 16380
			// (get) Token: 0x0600CE25 RID: 52773 RVA: 0x00320B58 File Offset: 0x0031ED58
			// (set) Token: 0x0600CE26 RID: 52774 RVA: 0x00063F38 File Offset: 0x00062138
			public unsafe string BehaviourName
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NPCBehaviour.__c__DisplayClass36_0.NativeFieldInfoPtr_BehaviourName);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NPCBehaviour.__c__DisplayClass36_0.NativeFieldInfoPtr_BehaviourName), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x04008B8D RID: 35725
			private static readonly System.IntPtr NativeFieldInfoPtr_BehaviourName;

			// Token: 0x04008B8E RID: 35726
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008B8F RID: 35727
			private static readonly System.IntPtr NativeMethodInfoPtr__GetBehaviour_b__0_Internal_Boolean_Behaviour_0;
		}
	}
}
