using System;
using Il2CppFishNet.Connection;
using Il2CppFishNet.Object;
using Il2CppFishNet.Serializing;
using Il2CppFishNet.Transporting;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Management;
using UnityEngine;
using UnityEngine.Events;

namespace Il2CppScheduleOne.NPCs.Behaviour
{
	// Token: 0x02000361 RID: 865
	public class Behaviour : NetworkBehaviour
	{
		// Token: 0x06003EAA RID: 16042 RVA: 0x0013FD74 File Offset: 0x0013DF74
		// Note: this type is marked as 'beforefieldinit'.
		static Behaviour()
		{
			Il2CppClassPointerStore<Behaviour>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.NPCs.Behaviour", "Behaviour");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Behaviour>.NativeClassPtr);
			Behaviour.NativeFieldInfoPtr_MAX_CONSECUTIVE_PATHING_FAILURES = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Behaviour>.NativeClassPtr, "MAX_CONSECUTIVE_PATHING_FAILURES");
			Behaviour.NativeFieldInfoPtr_EnabledOnAwake = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Behaviour>.NativeClassPtr, "EnabledOnAwake");
			Behaviour.NativeFieldInfoPtr__Enabled_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Behaviour>.NativeClassPtr, "<Enabled>k__BackingField");
			Behaviour.NativeFieldInfoPtr_Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Behaviour>.NativeClassPtr, "Name");
			Behaviour.NativeFieldInfoPtr_Priority = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Behaviour>.NativeClassPtr, "Priority");
			Behaviour.NativeFieldInfoPtr__Started_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Behaviour>.NativeClassPtr, "<Started>k__BackingField");
			Behaviour.NativeFieldInfoPtr__Active_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Behaviour>.NativeClassPtr, "<Active>k__BackingField");
			Behaviour.NativeFieldInfoPtr__beh_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Behaviour>.NativeClassPtr, "<beh>k__BackingField");
			Behaviour.NativeFieldInfoPtr_onEnable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Behaviour>.NativeClassPtr, "onEnable");
			Behaviour.NativeFieldInfoPtr_onDisable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Behaviour>.NativeClassPtr, "onDisable");
			Behaviour.NativeFieldInfoPtr_onBegin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Behaviour>.NativeClassPtr, "onBegin");
			Behaviour.NativeFieldInfoPtr_onEnd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Behaviour>.NativeClassPtr, "onEnd");
			Behaviour.NativeFieldInfoPtr_consecutivePathingFailures = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Behaviour>.NativeClassPtr, "consecutivePathingFailures");
			Behaviour.NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Behaviour>.NativeClassPtr, "NetworkInitialize___EarlyScheduleOne.NPCs.Behaviour.BehaviourAssembly-CSharp.dll_Excuted");
			Behaviour.NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Behaviour>.NativeClassPtr, "NetworkInitialize__LateScheduleOne.NPCs.Behaviour.BehaviourAssembly-CSharp.dll_Excuted");
			Behaviour.NativeMethodInfoPtr_get_Enabled_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Behaviour>.NativeClassPtr, 100670692);
			Behaviour.NativeMethodInfoPtr_set_Enabled_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Behaviour>.NativeClassPtr, 100670693);
			Behaviour.NativeMethodInfoPtr_get_Started_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Behaviour>.NativeClassPtr, 100670694);
			Behaviour.NativeMethodInfoPtr_set_Started_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Behaviour>.NativeClassPtr, 100670695);
			Behaviour.NativeMethodInfoPtr_get_Active_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Behaviour>.NativeClassPtr, 100670696);
			Behaviour.NativeMethodInfoPtr_set_Active_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Behaviour>.NativeClassPtr, 100670697);
			Behaviour.NativeMethodInfoPtr_get_beh_Public_get_NPCBehaviour_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Behaviour>.NativeClassPtr, 100670698);
			Behaviour.NativeMethodInfoPtr_set_beh_Private_set_Void_NPCBehaviour_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Behaviour>.NativeClassPtr, 100670699);
			Behaviour.NativeMethodInfoPtr_get_Npc_Public_get_NPC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Behaviour>.NativeClassPtr, 100670700);
			Behaviour.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Behaviour>.NativeClassPtr, 100670701);
			Behaviour.NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Behaviour>.NativeClassPtr, 100670702);
			Behaviour.NativeMethodInfoPtr_OnValidate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Behaviour>.NativeClassPtr, 100670703);
			Behaviour.NativeMethodInfoPtr_Enable_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Behaviour>.NativeClassPtr, 100670704);
			Behaviour.NativeMethodInfoPtr_SendEnable_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Behaviour>.NativeClassPtr, 100670705);
			Behaviour.NativeMethodInfoPtr_Enable_Networked_Public_Void_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Behaviour>.NativeClassPtr, 100670706);
			Behaviour.NativeMethodInfoPtr_Disable_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Behaviour>.NativeClassPtr, 100670707);
			Behaviour.NativeMethodInfoPtr_SendDisable_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Behaviour>.NativeClassPtr, 100670708);
			Behaviour.NativeMethodInfoPtr_Disable_Networked_Public_Void_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Behaviour>.NativeClassPtr, 100670709);
			Behaviour.NativeMethodInfoPtr_UpdateGameObjectName_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Behaviour>.NativeClassPtr, 100670710);
			Behaviour.NativeMethodInfoPtr_Begin_Networked_Public_Void_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Behaviour>.NativeClassPtr, 100670711);
			Behaviour.NativeMethodInfoPtr_Begin_Protected_Virtual_New_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Behaviour>.NativeClassPtr, 100670712);
			Behaviour.NativeMethodInfoPtr_SendEnd_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Behaviour>.NativeClassPtr, 100670713);
			Behaviour.NativeMethodInfoPtr_End_Networked_Public_Void_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Behaviour>.NativeClassPtr, 100670714);
			Behaviour.NativeMethodInfoPtr_End_Protected_Virtual_New_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Behaviour>.NativeClassPtr, 100670715);
			Behaviour.NativeMethodInfoPtr_Pause_Networked_Public_Void_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Behaviour>.NativeClassPtr, 100670716);
			Behaviour.NativeMethodInfoPtr_Pause_Protected_Virtual_New_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Behaviour>.NativeClassPtr, 100670717);
			Behaviour.NativeMethodInfoPtr_Resume_Networked_Public_Void_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Behaviour>.NativeClassPtr, 100670718);
			Behaviour.NativeMethodInfoPtr_Resume_Protected_Virtual_New_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Behaviour>.NativeClassPtr, 100670719);
			Behaviour.NativeMethodInfoPtr_BehaviourUpdate_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Behaviour>.NativeClassPtr, 100670720);
			Behaviour.NativeMethodInfoPtr_BehaviourLateUpdate_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Behaviour>.NativeClassPtr, 100670721);
			Behaviour.NativeMethodInfoPtr_ActiveMinPass_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Behaviour>.NativeClassPtr, 100670722);
			Behaviour.NativeMethodInfoPtr_SetPriority_Protected_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Behaviour>.NativeClassPtr, 100670723);
			Behaviour.NativeMethodInfoPtr_SetDestination_Protected_Void_ITransitEntity_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Behaviour>.NativeClassPtr, 100670724);
			Behaviour.NativeMethodInfoPtr_SetDestination_Protected_Void_Vector3_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Behaviour>.NativeClassPtr, 100670725);
			Behaviour.NativeMethodInfoPtr_WalkCallback_Protected_Virtual_New_Void_WalkResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Behaviour>.NativeClassPtr, 100670726);
			Behaviour.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Behaviour>.NativeClassPtr, 100670727);
			Behaviour.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Behaviour>.NativeClassPtr, 100670728);
			Behaviour.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Behaviour>.NativeClassPtr, 100670729);
			Behaviour.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Behaviour>.NativeClassPtr, 100670730);
			Behaviour.NativeMethodInfoPtr_RpcWriter___Server_SendEnable_2166136261_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Behaviour>.NativeClassPtr, 100670731);
			Behaviour.NativeMethodInfoPtr_RpcLogic___SendEnable_2166136261_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Behaviour>.NativeClassPtr, 100670732);
			Behaviour.NativeMethodInfoPtr_RpcReader___Server_SendEnable_2166136261_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Behaviour>.NativeClassPtr, 100670733);
			Behaviour.NativeMethodInfoPtr_RpcWriter___Observers_Enable_Networked_328543758_Private_Void_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Behaviour>.NativeClassPtr, 100670734);
			Behaviour.NativeMethodInfoPtr_RpcLogic___Enable_Networked_328543758_Public_Void_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Behaviour>.NativeClassPtr, 100670735);
			Behaviour.NativeMethodInfoPtr_RpcReader___Observers_Enable_Networked_328543758_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Behaviour>.NativeClassPtr, 100670736);
			Behaviour.NativeMethodInfoPtr_RpcWriter___Target_Enable_Networked_328543758_Private_Void_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Behaviour>.NativeClassPtr, 100670737);
			Behaviour.NativeMethodInfoPtr_RpcReader___Target_Enable_Networked_328543758_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Behaviour>.NativeClassPtr, 100670738);
			Behaviour.NativeMethodInfoPtr_RpcWriter___Server_SendDisable_2166136261_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Behaviour>.NativeClassPtr, 100670739);
			Behaviour.NativeMethodInfoPtr_RpcLogic___SendDisable_2166136261_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Behaviour>.NativeClassPtr, 100670740);
			Behaviour.NativeMethodInfoPtr_RpcReader___Server_SendDisable_2166136261_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Behaviour>.NativeClassPtr, 100670741);
			Behaviour.NativeMethodInfoPtr_RpcWriter___Observers_Disable_Networked_328543758_Private_Void_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Behaviour>.NativeClassPtr, 100670742);
			Behaviour.NativeMethodInfoPtr_RpcLogic___Disable_Networked_328543758_Public_Void_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Behaviour>.NativeClassPtr, 100670743);
			Behaviour.NativeMethodInfoPtr_RpcReader___Observers_Disable_Networked_328543758_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Behaviour>.NativeClassPtr, 100670744);
			Behaviour.NativeMethodInfoPtr_RpcWriter___Target_Disable_Networked_328543758_Private_Void_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Behaviour>.NativeClassPtr, 100670745);
			Behaviour.NativeMethodInfoPtr_RpcReader___Target_Disable_Networked_328543758_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Behaviour>.NativeClassPtr, 100670746);
			Behaviour.NativeMethodInfoPtr_RpcWriter___Observers_Begin_Networked_328543758_Private_Void_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Behaviour>.NativeClassPtr, 100670747);
			Behaviour.NativeMethodInfoPtr_RpcLogic___Begin_Networked_328543758_Public_Void_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Behaviour>.NativeClassPtr, 100670748);
			Behaviour.NativeMethodInfoPtr_RpcReader___Observers_Begin_Networked_328543758_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Behaviour>.NativeClassPtr, 100670749);
			Behaviour.NativeMethodInfoPtr_RpcWriter___Target_Begin_Networked_328543758_Private_Void_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Behaviour>.NativeClassPtr, 100670750);
			Behaviour.NativeMethodInfoPtr_RpcReader___Target_Begin_Networked_328543758_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Behaviour>.NativeClassPtr, 100670751);
			Behaviour.NativeMethodInfoPtr_RpcWriter___Server_SendEnd_2166136261_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Behaviour>.NativeClassPtr, 100670752);
			Behaviour.NativeMethodInfoPtr_RpcLogic___SendEnd_2166136261_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Behaviour>.NativeClassPtr, 100670753);
			Behaviour.NativeMethodInfoPtr_RpcReader___Server_SendEnd_2166136261_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Behaviour>.NativeClassPtr, 100670754);
			Behaviour.NativeMethodInfoPtr_RpcWriter___Observers_End_Networked_328543758_Private_Void_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Behaviour>.NativeClassPtr, 100670755);
			Behaviour.NativeMethodInfoPtr_RpcLogic___End_Networked_328543758_Public_Void_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Behaviour>.NativeClassPtr, 100670756);
			Behaviour.NativeMethodInfoPtr_RpcReader___Observers_End_Networked_328543758_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Behaviour>.NativeClassPtr, 100670757);
			Behaviour.NativeMethodInfoPtr_RpcWriter___Target_End_Networked_328543758_Private_Void_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Behaviour>.NativeClassPtr, 100670758);
			Behaviour.NativeMethodInfoPtr_RpcReader___Target_End_Networked_328543758_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Behaviour>.NativeClassPtr, 100670759);
			Behaviour.NativeMethodInfoPtr_RpcWriter___Observers_Pause_Networked_328543758_Private_Void_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Behaviour>.NativeClassPtr, 100670760);
			Behaviour.NativeMethodInfoPtr_RpcLogic___Pause_Networked_328543758_Public_Void_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Behaviour>.NativeClassPtr, 100670761);
			Behaviour.NativeMethodInfoPtr_RpcReader___Observers_Pause_Networked_328543758_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Behaviour>.NativeClassPtr, 100670762);
			Behaviour.NativeMethodInfoPtr_RpcWriter___Target_Pause_Networked_328543758_Private_Void_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Behaviour>.NativeClassPtr, 100670763);
			Behaviour.NativeMethodInfoPtr_RpcReader___Target_Pause_Networked_328543758_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Behaviour>.NativeClassPtr, 100670764);
			Behaviour.NativeMethodInfoPtr_RpcWriter___Observers_Resume_Networked_328543758_Private_Void_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Behaviour>.NativeClassPtr, 100670765);
			Behaviour.NativeMethodInfoPtr_RpcLogic___Resume_Networked_328543758_Public_Void_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Behaviour>.NativeClassPtr, 100670766);
			Behaviour.NativeMethodInfoPtr_RpcReader___Observers_Resume_Networked_328543758_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Behaviour>.NativeClassPtr, 100670767);
			Behaviour.NativeMethodInfoPtr_RpcWriter___Target_Resume_Networked_328543758_Private_Void_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Behaviour>.NativeClassPtr, 100670768);
			Behaviour.NativeMethodInfoPtr_RpcReader___Target_Resume_Networked_328543758_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Behaviour>.NativeClassPtr, 100670769);
			Behaviour.NativeMethodInfoPtr_Method_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Behaviour>.NativeClassPtr, 100670770);
		}

		// Token: 0x17001355 RID: 4949
		// (get) Token: 0x06003EAB RID: 16043 RVA: 0x001404FC File Offset: 0x0013E6FC
		// (set) Token: 0x06003EAC RID: 16044 RVA: 0x00140538 File Offset: 0x0013E738
		public unsafe bool Enabled
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Behaviour.NativeMethodInfoPtr_get_Enabled_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Behaviour.NativeMethodInfoPtr_set_Enabled_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x17001356 RID: 4950
		// (get) Token: 0x06003EAD RID: 16045 RVA: 0x00140578 File Offset: 0x0013E778
		// (set) Token: 0x06003EAE RID: 16046 RVA: 0x001405B4 File Offset: 0x0013E7B4
		public unsafe bool Started
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Behaviour.NativeMethodInfoPtr_get_Started_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Behaviour.NativeMethodInfoPtr_set_Started_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x17001357 RID: 4951
		// (get) Token: 0x06003EAF RID: 16047 RVA: 0x001405F4 File Offset: 0x0013E7F4
		// (set) Token: 0x06003EB0 RID: 16048 RVA: 0x00140630 File Offset: 0x0013E830
		public unsafe bool Active
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Behaviour.NativeMethodInfoPtr_get_Active_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Behaviour.NativeMethodInfoPtr_set_Active_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x17001358 RID: 4952
		// (get) Token: 0x06003EB1 RID: 16049 RVA: 0x00140670 File Offset: 0x0013E870
		// (set) Token: 0x06003EB2 RID: 16050 RVA: 0x001406B0 File Offset: 0x0013E8B0
		public unsafe NPCBehaviour beh
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Behaviour.NativeMethodInfoPtr_get_beh_Public_get_NPCBehaviour_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NPCBehaviour>(intPtr2) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 148766, XrefRangeEnd = 148767, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Behaviour.NativeMethodInfoPtr_set_beh_Private_set_Void_NPCBehaviour_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x17001359 RID: 4953
		// (get) Token: 0x06003EB3 RID: 16051 RVA: 0x001406F4 File Offset: 0x0013E8F4
		public unsafe NPC Npc
		{
			[CallerCount(411)]
			[CachedScanResults(RefRangeStart = 148767, RefRangeEnd = 149178, XrefRangeStart = 148767, XrefRangeEnd = 148767, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Behaviour.NativeMethodInfoPtr_get_Npc_Public_get_NPC_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NPC>(intPtr2) : null;
			}
		}

		// Token: 0x06003EB4 RID: 16052 RVA: 0x00140734 File Offset: 0x0013E934
		[CallerCount(48)]
		[CachedScanResults(RefRangeStart = 149182, RefRangeEnd = 149230, XrefRangeStart = 149178, XrefRangeEnd = 149182, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Behaviour.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06003EB5 RID: 16053 RVA: 0x00140770 File Offset: 0x0013E970
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 149233, RefRangeEnd = 149235, XrefRangeStart = 149230, XrefRangeEnd = 149233, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnSpawnServer(NetworkConnection connection)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(connection);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Behaviour.NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06003EB6 RID: 16054 RVA: 0x001407C0 File Offset: 0x0013E9C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 149235, XrefRangeEnd = 149237, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnValidate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Behaviour.NativeMethodInfoPtr_OnValidate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06003EB7 RID: 16055 RVA: 0x001407FC File Offset: 0x0013E9FC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 149245, RefRangeEnd = 149246, XrefRangeStart = 149237, XrefRangeEnd = 149245, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Enable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Behaviour.NativeMethodInfoPtr_Enable_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06003EB8 RID: 16056 RVA: 0x00140838 File Offset: 0x0013EA38
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 149267, RefRangeEnd = 149270, XrefRangeStart = 149246, XrefRangeEnd = 149267, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Behaviour.NativeMethodInfoPtr_SendEnable_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06003EB9 RID: 16057 RVA: 0x0014086C File Offset: 0x0013EA6C
		[CallerCount(44)]
		[CachedScanResults(RefRangeStart = 149306, RefRangeEnd = 149350, XrefRangeStart = 149270, XrefRangeEnd = 149306, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Enable_Networked(NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Behaviour.NativeMethodInfoPtr_Enable_Networked_Public_Void_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06003EBA RID: 16058 RVA: 0x001408B0 File Offset: 0x0013EAB0
		[CallerCount(22)]
		[CachedScanResults(RefRangeStart = 149358, RefRangeEnd = 149380, XrefRangeStart = 149350, XrefRangeEnd = 149358, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Disable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Behaviour.NativeMethodInfoPtr_Disable_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06003EBB RID: 16059 RVA: 0x001408EC File Offset: 0x0013EAEC
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 149401, RefRangeEnd = 149409, XrefRangeStart = 149380, XrefRangeEnd = 149401, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendDisable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Behaviour.NativeMethodInfoPtr_SendDisable_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06003EBC RID: 16060 RVA: 0x00140920 File Offset: 0x0013EB20
		[CallerCount(59)]
		[CachedScanResults(RefRangeStart = 149445, RefRangeEnd = 149504, XrefRangeStart = 149409, XrefRangeEnd = 149445, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Disable_Networked(NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Behaviour.NativeMethodInfoPtr_Disable_Networked_Public_Void_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06003EBD RID: 16061 RVA: 0x00140964 File Offset: 0x0013EB64
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 149525, RefRangeEnd = 149530, XrefRangeStart = 149504, XrefRangeEnd = 149525, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateGameObjectName()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Behaviour.NativeMethodInfoPtr_UpdateGameObjectName_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06003EBE RID: 16062 RVA: 0x00140998 File Offset: 0x0013EB98
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 149566, RefRangeEnd = 149568, XrefRangeStart = 149530, XrefRangeEnd = 149566, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Begin_Networked(NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Behaviour.NativeMethodInfoPtr_Begin_Networked_Public_Void_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06003EBF RID: 16063 RVA: 0x001409DC File Offset: 0x0013EBDC
		[CallerCount(31)]
		[CachedScanResults(RefRangeStart = 149580, RefRangeEnd = 149611, XrefRangeStart = 149568, XrefRangeEnd = 149580, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Begin()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Behaviour.NativeMethodInfoPtr_Begin_Protected_Virtual_New_Void_1), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06003EC0 RID: 16064 RVA: 0x00140A18 File Offset: 0x0013EC18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 149611, XrefRangeEnd = 149632, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendEnd()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Behaviour.NativeMethodInfoPtr_SendEnd_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06003EC1 RID: 16065 RVA: 0x00140A4C File Offset: 0x0013EC4C
		[CallerCount(20)]
		[CachedScanResults(RefRangeStart = 149668, RefRangeEnd = 149688, XrefRangeStart = 149632, XrefRangeEnd = 149668, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void End_Networked(NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Behaviour.NativeMethodInfoPtr_End_Networked_Public_Void_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06003EC2 RID: 16066 RVA: 0x00140A90 File Offset: 0x0013EC90
		[CallerCount(33)]
		[CachedScanResults(RefRangeStart = 149700, RefRangeEnd = 149733, XrefRangeStart = 149688, XrefRangeEnd = 149700, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void End()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Behaviour.NativeMethodInfoPtr_End_Protected_Virtual_New_Void_1), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06003EC3 RID: 16067 RVA: 0x00140ACC File Offset: 0x0013ECCC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 149769, RefRangeEnd = 149770, XrefRangeStart = 149733, XrefRangeEnd = 149769, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Pause_Networked(NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Behaviour.NativeMethodInfoPtr_Pause_Networked_Public_Void_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06003EC4 RID: 16068 RVA: 0x00140B10 File Offset: 0x0013ED10
		[CallerCount(25)]
		[CachedScanResults(RefRangeStart = 149781, RefRangeEnd = 149806, XrefRangeStart = 149770, XrefRangeEnd = 149781, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Pause()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Behaviour.NativeMethodInfoPtr_Pause_Protected_Virtual_New_Void_1), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06003EC5 RID: 16069 RVA: 0x00140B4C File Offset: 0x0013ED4C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 149842, RefRangeEnd = 149843, XrefRangeStart = 149806, XrefRangeEnd = 149842, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Resume_Networked(NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Behaviour.NativeMethodInfoPtr_Resume_Networked_Public_Void_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06003EC6 RID: 16070 RVA: 0x00140B90 File Offset: 0x0013ED90
		[CallerCount(27)]
		[CachedScanResults(RefRangeStart = 149855, RefRangeEnd = 149882, XrefRangeStart = 149843, XrefRangeEnd = 149855, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Resume()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Behaviour.NativeMethodInfoPtr_Resume_Protected_Virtual_New_Void_1), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06003EC7 RID: 16071 RVA: 0x00140BCC File Offset: 0x0013EDCC
		[CallerCount(14558)]
		[CachedScanResults(RefRangeStart = 2769, RefRangeEnd = 17327, XrefRangeStart = 2769, XrefRangeEnd = 17327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void BehaviourUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Behaviour.NativeMethodInfoPtr_BehaviourUpdate_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06003EC8 RID: 16072 RVA: 0x00140C08 File Offset: 0x0013EE08
		[CallerCount(14558)]
		[CachedScanResults(RefRangeStart = 2769, RefRangeEnd = 17327, XrefRangeStart = 2769, XrefRangeEnd = 17327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void BehaviourLateUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Behaviour.NativeMethodInfoPtr_BehaviourLateUpdate_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06003EC9 RID: 16073 RVA: 0x00140C44 File Offset: 0x0013EE44
		[CallerCount(14558)]
		[CachedScanResults(RefRangeStart = 2769, RefRangeEnd = 17327, XrefRangeStart = 2769, XrefRangeEnd = 17327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void ActiveMinPass()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Behaviour.NativeMethodInfoPtr_ActiveMinPass_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06003ECA RID: 16074 RVA: 0x00140C80 File Offset: 0x0013EE80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 149882, XrefRangeEnd = 149884, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetPriority(int p)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref p;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Behaviour.NativeMethodInfoPtr_SetPriority_Protected_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06003ECB RID: 16075 RVA: 0x00140CC0 File Offset: 0x0013EEC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 149884, XrefRangeEnd = 149890, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetDestination(ITransitEntity transitEntity, bool teleportIfFail = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(transitEntity);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref teleportIfFail;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Behaviour.NativeMethodInfoPtr_SetDestination_Protected_Void_ITransitEntity_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06003ECC RID: 16076 RVA: 0x00140D10 File Offset: 0x0013EF10
		[CallerCount(18)]
		[CachedScanResults(RefRangeStart = 149907, RefRangeEnd = 149925, XrefRangeStart = 149890, XrefRangeEnd = 149907, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetDestination(Vector3 position, bool teleportIfFail = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref position;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref teleportIfFail;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Behaviour.NativeMethodInfoPtr_SetDestination_Protected_Void_Vector3_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06003ECD RID: 16077 RVA: 0x00140D5C File Offset: 0x0013EF5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 149925, XrefRangeEnd = 149936, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void WalkCallback(NPCMovement.WalkResult result)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref result;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Behaviour.NativeMethodInfoPtr_WalkCallback_Protected_Virtual_New_Void_WalkResult_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06003ECE RID: 16078 RVA: 0x00140DA8 File Offset: 0x0013EFA8
		[CallerCount(38)]
		[CachedScanResults(RefRangeStart = 149950, RefRangeEnd = 149988, XrefRangeStart = 149936, XrefRangeEnd = 149950, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Behaviour() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Behaviour>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Behaviour.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06003ECF RID: 16079 RVA: 0x00140DE4 File Offset: 0x0013EFE4
		[CallerCount(38)]
		[CachedScanResults(RefRangeStart = 150080, RefRangeEnd = 150118, XrefRangeStart = 149988, XrefRangeEnd = 150080, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void NetworkInitialize___Early()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Behaviour.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06003ED0 RID: 16080 RVA: 0x00140E20 File Offset: 0x0013F020
		[CallerCount(26)]
		[CachedScanResults(RefRangeStart = 150118, RefRangeEnd = 150144, XrefRangeStart = 150118, XrefRangeEnd = 150118, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void NetworkInitialize__Late()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Behaviour.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06003ED1 RID: 16081 RVA: 0x00140E5C File Offset: 0x0013F05C
		[CallerCount(0)]
		public unsafe override void NetworkInitializeIfDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Behaviour.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06003ED2 RID: 16082 RVA: 0x00140E98 File Offset: 0x0013F098
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 150144, XrefRangeEnd = 150153, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_SendEnable_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Behaviour.NativeMethodInfoPtr_RpcWriter___Server_SendEnable_2166136261_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06003ED3 RID: 16083 RVA: 0x00140ECC File Offset: 0x0013F0CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 150153, XrefRangeEnd = 150154, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SendEnable_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Behaviour.NativeMethodInfoPtr_RpcLogic___SendEnable_2166136261_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06003ED4 RID: 16084 RVA: 0x00140F00 File Offset: 0x0013F100
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 150154, XrefRangeEnd = 150157, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_SendEnable_2166136261(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Behaviour.NativeMethodInfoPtr_RpcReader___Server_SendEnable_2166136261_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06003ED5 RID: 16085 RVA: 0x00140F64 File Offset: 0x0013F164
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 150157, XrefRangeEnd = 150166, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_Enable_Networked_328543758(NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Behaviour.NativeMethodInfoPtr_RpcWriter___Observers_Enable_Networked_328543758_Private_Void_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06003ED6 RID: 16086 RVA: 0x00140FA8 File Offset: 0x0013F1A8
		[CallerCount(45)]
		[CachedScanResults(RefRangeStart = 150166, RefRangeEnd = 150211, XrefRangeStart = 150166, XrefRangeEnd = 150166, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___Enable_Networked_328543758(NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Behaviour.NativeMethodInfoPtr_RpcLogic___Enable_Networked_328543758_Public_Void_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06003ED7 RID: 16087 RVA: 0x00140FEC File Offset: 0x0013F1EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 150211, XrefRangeEnd = 150213, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_Enable_Networked_328543758(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Behaviour.NativeMethodInfoPtr_RpcReader___Observers_Enable_Networked_328543758_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06003ED8 RID: 16088 RVA: 0x0014103C File Offset: 0x0013F23C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 150213, XrefRangeEnd = 150222, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Target_Enable_Networked_328543758(NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Behaviour.NativeMethodInfoPtr_RpcWriter___Target_Enable_Networked_328543758_Private_Void_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06003ED9 RID: 16089 RVA: 0x00141080 File Offset: 0x0013F280
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 150222, XrefRangeEnd = 150224, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Target_Enable_Networked_328543758(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Behaviour.NativeMethodInfoPtr_RpcReader___Target_Enable_Networked_328543758_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06003EDA RID: 16090 RVA: 0x001410D0 File Offset: 0x0013F2D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 150224, XrefRangeEnd = 150233, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_SendDisable_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Behaviour.NativeMethodInfoPtr_RpcWriter___Server_SendDisable_2166136261_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06003EDB RID: 16091 RVA: 0x00141104 File Offset: 0x0013F304
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 150233, XrefRangeEnd = 150234, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SendDisable_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Behaviour.NativeMethodInfoPtr_RpcLogic___SendDisable_2166136261_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06003EDC RID: 16092 RVA: 0x00141138 File Offset: 0x0013F338
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 150234, XrefRangeEnd = 150237, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_SendDisable_2166136261(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Behaviour.NativeMethodInfoPtr_RpcReader___Server_SendDisable_2166136261_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06003EDD RID: 16093 RVA: 0x0014119C File Offset: 0x0013F39C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 150237, XrefRangeEnd = 150246, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_Disable_Networked_328543758(NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Behaviour.NativeMethodInfoPtr_RpcWriter___Observers_Disable_Networked_328543758_Private_Void_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06003EDE RID: 16094 RVA: 0x001411E0 File Offset: 0x0013F3E0
		[CallerCount(0)]
		public unsafe void RpcLogic___Disable_Networked_328543758(NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Behaviour.NativeMethodInfoPtr_RpcLogic___Disable_Networked_328543758_Public_Void_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06003EDF RID: 16095 RVA: 0x00141224 File Offset: 0x0013F424
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 150246, XrefRangeEnd = 150248, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_Disable_Networked_328543758(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Behaviour.NativeMethodInfoPtr_RpcReader___Observers_Disable_Networked_328543758_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06003EE0 RID: 16096 RVA: 0x00141274 File Offset: 0x0013F474
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 150248, XrefRangeEnd = 150257, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Target_Disable_Networked_328543758(NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Behaviour.NativeMethodInfoPtr_RpcWriter___Target_Disable_Networked_328543758_Private_Void_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06003EE1 RID: 16097 RVA: 0x001412B8 File Offset: 0x0013F4B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 150257, XrefRangeEnd = 150259, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Target_Disable_Networked_328543758(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Behaviour.NativeMethodInfoPtr_RpcReader___Target_Disable_Networked_328543758_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06003EE2 RID: 16098 RVA: 0x00141308 File Offset: 0x0013F508
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 150259, XrefRangeEnd = 150268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_Begin_Networked_328543758(NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Behaviour.NativeMethodInfoPtr_RpcWriter___Observers_Begin_Networked_328543758_Private_Void_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06003EE3 RID: 16099 RVA: 0x0014134C File Offset: 0x0013F54C
		[CallerCount(0)]
		public unsafe void RpcLogic___Begin_Networked_328543758(NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Behaviour.NativeMethodInfoPtr_RpcLogic___Begin_Networked_328543758_Public_Void_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06003EE4 RID: 16100 RVA: 0x00141390 File Offset: 0x0013F590
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 150268, XrefRangeEnd = 150270, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_Begin_Networked_328543758(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Behaviour.NativeMethodInfoPtr_RpcReader___Observers_Begin_Networked_328543758_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06003EE5 RID: 16101 RVA: 0x001413E0 File Offset: 0x0013F5E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 150270, XrefRangeEnd = 150279, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Target_Begin_Networked_328543758(NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Behaviour.NativeMethodInfoPtr_RpcWriter___Target_Begin_Networked_328543758_Private_Void_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06003EE6 RID: 16102 RVA: 0x00141424 File Offset: 0x0013F624
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 150279, XrefRangeEnd = 150281, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Target_Begin_Networked_328543758(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Behaviour.NativeMethodInfoPtr_RpcReader___Target_Begin_Networked_328543758_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06003EE7 RID: 16103 RVA: 0x00141474 File Offset: 0x0013F674
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 150281, XrefRangeEnd = 150290, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_SendEnd_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Behaviour.NativeMethodInfoPtr_RpcWriter___Server_SendEnd_2166136261_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06003EE8 RID: 16104 RVA: 0x001414A8 File Offset: 0x0013F6A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 150290, XrefRangeEnd = 150291, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SendEnd_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Behaviour.NativeMethodInfoPtr_RpcLogic___SendEnd_2166136261_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06003EE9 RID: 16105 RVA: 0x001414DC File Offset: 0x0013F6DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 150291, XrefRangeEnd = 150294, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_SendEnd_2166136261(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Behaviour.NativeMethodInfoPtr_RpcReader___Server_SendEnd_2166136261_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06003EEA RID: 16106 RVA: 0x00141540 File Offset: 0x0013F740
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 150294, XrefRangeEnd = 150303, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_End_Networked_328543758(NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Behaviour.NativeMethodInfoPtr_RpcWriter___Observers_End_Networked_328543758_Private_Void_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06003EEB RID: 16107 RVA: 0x00141584 File Offset: 0x0013F784
		[CallerCount(0)]
		public unsafe void RpcLogic___End_Networked_328543758(NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Behaviour.NativeMethodInfoPtr_RpcLogic___End_Networked_328543758_Public_Void_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06003EEC RID: 16108 RVA: 0x001415C8 File Offset: 0x0013F7C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 150303, XrefRangeEnd = 150305, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_End_Networked_328543758(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Behaviour.NativeMethodInfoPtr_RpcReader___Observers_End_Networked_328543758_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06003EED RID: 16109 RVA: 0x00141618 File Offset: 0x0013F818
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 150305, XrefRangeEnd = 150314, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Target_End_Networked_328543758(NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Behaviour.NativeMethodInfoPtr_RpcWriter___Target_End_Networked_328543758_Private_Void_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06003EEE RID: 16110 RVA: 0x0014165C File Offset: 0x0013F85C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 150314, XrefRangeEnd = 150316, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Target_End_Networked_328543758(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Behaviour.NativeMethodInfoPtr_RpcReader___Target_End_Networked_328543758_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06003EEF RID: 16111 RVA: 0x001416AC File Offset: 0x0013F8AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 150316, XrefRangeEnd = 150325, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_Pause_Networked_328543758(NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Behaviour.NativeMethodInfoPtr_RpcWriter___Observers_Pause_Networked_328543758_Private_Void_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06003EF0 RID: 16112 RVA: 0x001416F0 File Offset: 0x0013F8F0
		[CallerCount(0)]
		public unsafe void RpcLogic___Pause_Networked_328543758(NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Behaviour.NativeMethodInfoPtr_RpcLogic___Pause_Networked_328543758_Public_Void_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06003EF1 RID: 16113 RVA: 0x00141734 File Offset: 0x0013F934
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 150325, XrefRangeEnd = 150327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_Pause_Networked_328543758(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Behaviour.NativeMethodInfoPtr_RpcReader___Observers_Pause_Networked_328543758_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06003EF2 RID: 16114 RVA: 0x00141784 File Offset: 0x0013F984
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 150327, XrefRangeEnd = 150336, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Target_Pause_Networked_328543758(NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Behaviour.NativeMethodInfoPtr_RpcWriter___Target_Pause_Networked_328543758_Private_Void_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06003EF3 RID: 16115 RVA: 0x001417C8 File Offset: 0x0013F9C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 150336, XrefRangeEnd = 150338, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Target_Pause_Networked_328543758(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Behaviour.NativeMethodInfoPtr_RpcReader___Target_Pause_Networked_328543758_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06003EF4 RID: 16116 RVA: 0x00141818 File Offset: 0x0013FA18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 150338, XrefRangeEnd = 150347, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_Resume_Networked_328543758(NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Behaviour.NativeMethodInfoPtr_RpcWriter___Observers_Resume_Networked_328543758_Private_Void_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06003EF5 RID: 16117 RVA: 0x0014185C File Offset: 0x0013FA5C
		[CallerCount(0)]
		public unsafe void RpcLogic___Resume_Networked_328543758(NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Behaviour.NativeMethodInfoPtr_RpcLogic___Resume_Networked_328543758_Public_Void_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06003EF6 RID: 16118 RVA: 0x001418A0 File Offset: 0x0013FAA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 150347, XrefRangeEnd = 150349, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_Resume_Networked_328543758(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Behaviour.NativeMethodInfoPtr_RpcReader___Observers_Resume_Networked_328543758_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06003EF7 RID: 16119 RVA: 0x001418F0 File Offset: 0x0013FAF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 150349, XrefRangeEnd = 150358, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Target_Resume_Networked_328543758(NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Behaviour.NativeMethodInfoPtr_RpcWriter___Target_Resume_Networked_328543758_Private_Void_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06003EF8 RID: 16120 RVA: 0x00141934 File Offset: 0x0013FB34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 150358, XrefRangeEnd = 150360, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Target_Resume_Networked_328543758(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Behaviour.NativeMethodInfoPtr_RpcReader___Target_Resume_Networked_328543758_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06003EF9 RID: 16121 RVA: 0x00141984 File Offset: 0x0013FB84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 150360, XrefRangeEnd = 150364, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Method_Protected_Virtual_New_Void_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Behaviour.NativeMethodInfoPtr_Method_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06003EFA RID: 16122 RVA: 0x0001F77C File Offset: 0x0001D97C
		public Behaviour(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001346 RID: 4934
		// (get) Token: 0x06003EFB RID: 16123 RVA: 0x001419C0 File Offset: 0x0013FBC0
		// (set) Token: 0x06003EFC RID: 16124 RVA: 0x0001F785 File Offset: 0x0001D985
		public unsafe static int MAX_CONSECUTIVE_PATHING_FAILURES
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(Behaviour.NativeFieldInfoPtr_MAX_CONSECUTIVE_PATHING_FAILURES, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Behaviour.NativeFieldInfoPtr_MAX_CONSECUTIVE_PATHING_FAILURES, (void*)(&value));
			}
		}

		// Token: 0x17001347 RID: 4935
		// (get) Token: 0x06003EFD RID: 16125 RVA: 0x001419DC File Offset: 0x0013FBDC
		// (set) Token: 0x06003EFE RID: 16126 RVA: 0x0001F793 File Offset: 0x0001D993
		public unsafe bool EnabledOnAwake
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Behaviour.NativeFieldInfoPtr_EnabledOnAwake);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Behaviour.NativeFieldInfoPtr_EnabledOnAwake)) = value;
			}
		}

		// Token: 0x17001348 RID: 4936
		// (get) Token: 0x06003EFF RID: 16127 RVA: 0x00141A04 File Offset: 0x0013FC04
		// (set) Token: 0x06003F00 RID: 16128 RVA: 0x0001F7AE File Offset: 0x0001D9AE
		public unsafe bool _Enabled_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Behaviour.NativeFieldInfoPtr__Enabled_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Behaviour.NativeFieldInfoPtr__Enabled_k__BackingField)) = value;
			}
		}

		// Token: 0x17001349 RID: 4937
		// (get) Token: 0x06003F01 RID: 16129 RVA: 0x00141A2C File Offset: 0x0013FC2C
		// (set) Token: 0x06003F02 RID: 16130 RVA: 0x0001F7C9 File Offset: 0x0001D9C9
		public unsafe string Name
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Behaviour.NativeFieldInfoPtr_Name);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Behaviour.NativeFieldInfoPtr_Name), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700134A RID: 4938
		// (get) Token: 0x06003F03 RID: 16131 RVA: 0x00141A54 File Offset: 0x0013FC54
		// (set) Token: 0x06003F04 RID: 16132 RVA: 0x0001F7E8 File Offset: 0x0001D9E8
		public unsafe int Priority
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Behaviour.NativeFieldInfoPtr_Priority);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Behaviour.NativeFieldInfoPtr_Priority)) = value;
			}
		}

		// Token: 0x1700134B RID: 4939
		// (get) Token: 0x06003F05 RID: 16133 RVA: 0x00141A7C File Offset: 0x0013FC7C
		// (set) Token: 0x06003F06 RID: 16134 RVA: 0x0001F803 File Offset: 0x0001DA03
		public unsafe bool _Started_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Behaviour.NativeFieldInfoPtr__Started_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Behaviour.NativeFieldInfoPtr__Started_k__BackingField)) = value;
			}
		}

		// Token: 0x1700134C RID: 4940
		// (get) Token: 0x06003F07 RID: 16135 RVA: 0x00141AA4 File Offset: 0x0013FCA4
		// (set) Token: 0x06003F08 RID: 16136 RVA: 0x0001F81E File Offset: 0x0001DA1E
		public unsafe bool _Active_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Behaviour.NativeFieldInfoPtr__Active_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Behaviour.NativeFieldInfoPtr__Active_k__BackingField)) = value;
			}
		}

		// Token: 0x1700134D RID: 4941
		// (get) Token: 0x06003F09 RID: 16137 RVA: 0x00141ACC File Offset: 0x0013FCCC
		// (set) Token: 0x06003F0A RID: 16138 RVA: 0x0001F839 File Offset: 0x0001DA39
		public unsafe NPCBehaviour _beh_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Behaviour.NativeFieldInfoPtr__beh_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NPCBehaviour>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Behaviour.NativeFieldInfoPtr__beh_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700134E RID: 4942
		// (get) Token: 0x06003F0B RID: 16139 RVA: 0x00141AFC File Offset: 0x0013FCFC
		// (set) Token: 0x06003F0C RID: 16140 RVA: 0x0001F858 File Offset: 0x0001DA58
		public unsafe UnityEvent onEnable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Behaviour.NativeFieldInfoPtr_onEnable);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Behaviour.NativeFieldInfoPtr_onEnable), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700134F RID: 4943
		// (get) Token: 0x06003F0D RID: 16141 RVA: 0x00141B2C File Offset: 0x0013FD2C
		// (set) Token: 0x06003F0E RID: 16142 RVA: 0x0001F877 File Offset: 0x0001DA77
		public unsafe UnityEvent onDisable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Behaviour.NativeFieldInfoPtr_onDisable);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Behaviour.NativeFieldInfoPtr_onDisable), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001350 RID: 4944
		// (get) Token: 0x06003F0F RID: 16143 RVA: 0x00141B5C File Offset: 0x0013FD5C
		// (set) Token: 0x06003F10 RID: 16144 RVA: 0x0001F896 File Offset: 0x0001DA96
		public unsafe UnityEvent onBegin
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Behaviour.NativeFieldInfoPtr_onBegin);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Behaviour.NativeFieldInfoPtr_onBegin), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001351 RID: 4945
		// (get) Token: 0x06003F11 RID: 16145 RVA: 0x00141B8C File Offset: 0x0013FD8C
		// (set) Token: 0x06003F12 RID: 16146 RVA: 0x0001F8B5 File Offset: 0x0001DAB5
		public unsafe UnityEvent onEnd
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Behaviour.NativeFieldInfoPtr_onEnd);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Behaviour.NativeFieldInfoPtr_onEnd), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001352 RID: 4946
		// (get) Token: 0x06003F13 RID: 16147 RVA: 0x00141BBC File Offset: 0x0013FDBC
		// (set) Token: 0x06003F14 RID: 16148 RVA: 0x0001F8D4 File Offset: 0x0001DAD4
		public unsafe int consecutivePathingFailures
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Behaviour.NativeFieldInfoPtr_consecutivePathingFailures);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Behaviour.NativeFieldInfoPtr_consecutivePathingFailures)) = value;
			}
		}

		// Token: 0x17001353 RID: 4947
		// (get) Token: 0x06003F15 RID: 16149 RVA: 0x00141BE4 File Offset: 0x0013FDE4
		// (set) Token: 0x06003F16 RID: 16150 RVA: 0x0001F8EF File Offset: 0x0001DAEF
		public unsafe bool field_Private_Boolean_0
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Behaviour.NativeFieldInfoPtr_field_Private_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Behaviour.NativeFieldInfoPtr_field_Private_Boolean_0)) = value;
			}
		}

		// Token: 0x17001354 RID: 4948
		// (get) Token: 0x06003F17 RID: 16151 RVA: 0x00141C0C File Offset: 0x0013FE0C
		// (set) Token: 0x06003F18 RID: 16152 RVA: 0x0001F90A File Offset: 0x0001DB0A
		public unsafe bool field_Private_Boolean_1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Behaviour.NativeFieldInfoPtr_field_Private_Boolean_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Behaviour.NativeFieldInfoPtr_field_Private_Boolean_1)) = value;
			}
		}

		// Token: 0x04002953 RID: 10579
		private static readonly IntPtr NativeFieldInfoPtr_MAX_CONSECUTIVE_PATHING_FAILURES;

		// Token: 0x04002954 RID: 10580
		private static readonly IntPtr NativeFieldInfoPtr_EnabledOnAwake;

		// Token: 0x04002955 RID: 10581
		private static readonly IntPtr NativeFieldInfoPtr__Enabled_k__BackingField;

		// Token: 0x04002956 RID: 10582
		private static readonly IntPtr NativeFieldInfoPtr_Name;

		// Token: 0x04002957 RID: 10583
		private static readonly IntPtr NativeFieldInfoPtr_Priority;

		// Token: 0x04002958 RID: 10584
		private static readonly IntPtr NativeFieldInfoPtr__Started_k__BackingField;

		// Token: 0x04002959 RID: 10585
		private static readonly IntPtr NativeFieldInfoPtr__Active_k__BackingField;

		// Token: 0x0400295A RID: 10586
		private static readonly IntPtr NativeFieldInfoPtr__beh_k__BackingField;

		// Token: 0x0400295B RID: 10587
		private static readonly IntPtr NativeFieldInfoPtr_onEnable;

		// Token: 0x0400295C RID: 10588
		private static readonly IntPtr NativeFieldInfoPtr_onDisable;

		// Token: 0x0400295D RID: 10589
		private static readonly IntPtr NativeFieldInfoPtr_onBegin;

		// Token: 0x0400295E RID: 10590
		private static readonly IntPtr NativeFieldInfoPtr_onEnd;

		// Token: 0x0400295F RID: 10591
		private static readonly IntPtr NativeFieldInfoPtr_consecutivePathingFailures;

		// Token: 0x04002960 RID: 10592
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

		// Token: 0x04002961 RID: 10593
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

		// Token: 0x04002962 RID: 10594
		private static readonly IntPtr NativeMethodInfoPtr_get_Enabled_Public_get_Boolean_0;

		// Token: 0x04002963 RID: 10595
		private static readonly IntPtr NativeMethodInfoPtr_set_Enabled_Protected_set_Void_Boolean_0;

		// Token: 0x04002964 RID: 10596
		private static readonly IntPtr NativeMethodInfoPtr_get_Started_Public_get_Boolean_0;

		// Token: 0x04002965 RID: 10597
		private static readonly IntPtr NativeMethodInfoPtr_set_Started_Private_set_Void_Boolean_0;

		// Token: 0x04002966 RID: 10598
		private static readonly IntPtr NativeMethodInfoPtr_get_Active_Public_get_Boolean_0;

		// Token: 0x04002967 RID: 10599
		private static readonly IntPtr NativeMethodInfoPtr_set_Active_Private_set_Void_Boolean_0;

		// Token: 0x04002968 RID: 10600
		private static readonly IntPtr NativeMethodInfoPtr_get_beh_Public_get_NPCBehaviour_0;

		// Token: 0x04002969 RID: 10601
		private static readonly IntPtr NativeMethodInfoPtr_set_beh_Private_set_Void_NPCBehaviour_0;

		// Token: 0x0400296A RID: 10602
		private static readonly IntPtr NativeMethodInfoPtr_get_Npc_Public_get_NPC_0;

		// Token: 0x0400296B RID: 10603
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;

		// Token: 0x0400296C RID: 10604
		private static readonly IntPtr NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0;

		// Token: 0x0400296D RID: 10605
		private static readonly IntPtr NativeMethodInfoPtr_OnValidate_Protected_Virtual_Void_0;

		// Token: 0x0400296E RID: 10606
		private static readonly IntPtr NativeMethodInfoPtr_Enable_Public_Virtual_New_Void_0;

		// Token: 0x0400296F RID: 10607
		private static readonly IntPtr NativeMethodInfoPtr_SendEnable_Public_Void_0;

		// Token: 0x04002970 RID: 10608
		private static readonly IntPtr NativeMethodInfoPtr_Enable_Networked_Public_Void_NetworkConnection_0;

		// Token: 0x04002971 RID: 10609
		private static readonly IntPtr NativeMethodInfoPtr_Disable_Public_Virtual_New_Void_0;

		// Token: 0x04002972 RID: 10610
		private static readonly IntPtr NativeMethodInfoPtr_SendDisable_Public_Void_0;

		// Token: 0x04002973 RID: 10611
		private static readonly IntPtr NativeMethodInfoPtr_Disable_Networked_Public_Void_NetworkConnection_0;

		// Token: 0x04002974 RID: 10612
		private static readonly IntPtr NativeMethodInfoPtr_UpdateGameObjectName_Private_Void_0;

		// Token: 0x04002975 RID: 10613
		private static readonly IntPtr NativeMethodInfoPtr_Begin_Networked_Public_Void_NetworkConnection_0;

		// Token: 0x04002976 RID: 10614
		private static readonly IntPtr NativeMethodInfoPtr_Begin_Protected_Virtual_New_Void_1;

		// Token: 0x04002977 RID: 10615
		private static readonly IntPtr NativeMethodInfoPtr_SendEnd_Public_Void_0;

		// Token: 0x04002978 RID: 10616
		private static readonly IntPtr NativeMethodInfoPtr_End_Networked_Public_Void_NetworkConnection_0;

		// Token: 0x04002979 RID: 10617
		private static readonly IntPtr NativeMethodInfoPtr_End_Protected_Virtual_New_Void_1;

		// Token: 0x0400297A RID: 10618
		private static readonly IntPtr NativeMethodInfoPtr_Pause_Networked_Public_Void_NetworkConnection_0;

		// Token: 0x0400297B RID: 10619
		private static readonly IntPtr NativeMethodInfoPtr_Pause_Protected_Virtual_New_Void_1;

		// Token: 0x0400297C RID: 10620
		private static readonly IntPtr NativeMethodInfoPtr_Resume_Networked_Public_Void_NetworkConnection_0;

		// Token: 0x0400297D RID: 10621
		private static readonly IntPtr NativeMethodInfoPtr_Resume_Protected_Virtual_New_Void_1;

		// Token: 0x0400297E RID: 10622
		private static readonly IntPtr NativeMethodInfoPtr_BehaviourUpdate_Public_Virtual_New_Void_0;

		// Token: 0x0400297F RID: 10623
		private static readonly IntPtr NativeMethodInfoPtr_BehaviourLateUpdate_Public_Virtual_New_Void_0;

		// Token: 0x04002980 RID: 10624
		private static readonly IntPtr NativeMethodInfoPtr_ActiveMinPass_Public_Virtual_New_Void_0;

		// Token: 0x04002981 RID: 10625
		private static readonly IntPtr NativeMethodInfoPtr_SetPriority_Protected_Void_Int32_0;

		// Token: 0x04002982 RID: 10626
		private static readonly IntPtr NativeMethodInfoPtr_SetDestination_Protected_Void_ITransitEntity_Boolean_0;

		// Token: 0x04002983 RID: 10627
		private static readonly IntPtr NativeMethodInfoPtr_SetDestination_Protected_Void_Vector3_Boolean_0;

		// Token: 0x04002984 RID: 10628
		private static readonly IntPtr NativeMethodInfoPtr_WalkCallback_Protected_Virtual_New_Void_WalkResult_0;

		// Token: 0x04002985 RID: 10629
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04002986 RID: 10630
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

		// Token: 0x04002987 RID: 10631
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

		// Token: 0x04002988 RID: 10632
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

		// Token: 0x04002989 RID: 10633
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_SendEnable_2166136261_Private_Void_0;

		// Token: 0x0400298A RID: 10634
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SendEnable_2166136261_Public_Void_0;

		// Token: 0x0400298B RID: 10635
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_SendEnable_2166136261_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x0400298C RID: 10636
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_Enable_Networked_328543758_Private_Void_NetworkConnection_0;

		// Token: 0x0400298D RID: 10637
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___Enable_Networked_328543758_Public_Void_NetworkConnection_0;

		// Token: 0x0400298E RID: 10638
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_Enable_Networked_328543758_Private_Void_PooledReader_Channel_0;

		// Token: 0x0400298F RID: 10639
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Target_Enable_Networked_328543758_Private_Void_NetworkConnection_0;

		// Token: 0x04002990 RID: 10640
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Target_Enable_Networked_328543758_Private_Void_PooledReader_Channel_0;

		// Token: 0x04002991 RID: 10641
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_SendDisable_2166136261_Private_Void_0;

		// Token: 0x04002992 RID: 10642
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SendDisable_2166136261_Public_Void_0;

		// Token: 0x04002993 RID: 10643
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_SendDisable_2166136261_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x04002994 RID: 10644
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_Disable_Networked_328543758_Private_Void_NetworkConnection_0;

		// Token: 0x04002995 RID: 10645
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___Disable_Networked_328543758_Public_Void_NetworkConnection_0;

		// Token: 0x04002996 RID: 10646
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_Disable_Networked_328543758_Private_Void_PooledReader_Channel_0;

		// Token: 0x04002997 RID: 10647
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Target_Disable_Networked_328543758_Private_Void_NetworkConnection_0;

		// Token: 0x04002998 RID: 10648
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Target_Disable_Networked_328543758_Private_Void_PooledReader_Channel_0;

		// Token: 0x04002999 RID: 10649
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_Begin_Networked_328543758_Private_Void_NetworkConnection_0;

		// Token: 0x0400299A RID: 10650
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___Begin_Networked_328543758_Public_Void_NetworkConnection_0;

		// Token: 0x0400299B RID: 10651
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_Begin_Networked_328543758_Private_Void_PooledReader_Channel_0;

		// Token: 0x0400299C RID: 10652
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Target_Begin_Networked_328543758_Private_Void_NetworkConnection_0;

		// Token: 0x0400299D RID: 10653
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Target_Begin_Networked_328543758_Private_Void_PooledReader_Channel_0;

		// Token: 0x0400299E RID: 10654
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_SendEnd_2166136261_Private_Void_0;

		// Token: 0x0400299F RID: 10655
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SendEnd_2166136261_Public_Void_0;

		// Token: 0x040029A0 RID: 10656
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_SendEnd_2166136261_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x040029A1 RID: 10657
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_End_Networked_328543758_Private_Void_NetworkConnection_0;

		// Token: 0x040029A2 RID: 10658
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___End_Networked_328543758_Public_Void_NetworkConnection_0;

		// Token: 0x040029A3 RID: 10659
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_End_Networked_328543758_Private_Void_PooledReader_Channel_0;

		// Token: 0x040029A4 RID: 10660
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Target_End_Networked_328543758_Private_Void_NetworkConnection_0;

		// Token: 0x040029A5 RID: 10661
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Target_End_Networked_328543758_Private_Void_PooledReader_Channel_0;

		// Token: 0x040029A6 RID: 10662
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_Pause_Networked_328543758_Private_Void_NetworkConnection_0;

		// Token: 0x040029A7 RID: 10663
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___Pause_Networked_328543758_Public_Void_NetworkConnection_0;

		// Token: 0x040029A8 RID: 10664
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_Pause_Networked_328543758_Private_Void_PooledReader_Channel_0;

		// Token: 0x040029A9 RID: 10665
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Target_Pause_Networked_328543758_Private_Void_NetworkConnection_0;

		// Token: 0x040029AA RID: 10666
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Target_Pause_Networked_328543758_Private_Void_PooledReader_Channel_0;

		// Token: 0x040029AB RID: 10667
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_Resume_Networked_328543758_Private_Void_NetworkConnection_0;

		// Token: 0x040029AC RID: 10668
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___Resume_Networked_328543758_Public_Void_NetworkConnection_0;

		// Token: 0x040029AD RID: 10669
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_Resume_Networked_328543758_Private_Void_PooledReader_Channel_0;

		// Token: 0x040029AE RID: 10670
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Target_Resume_Networked_328543758_Private_Void_NetworkConnection_0;

		// Token: 0x040029AF RID: 10671
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Target_Resume_Networked_328543758_Private_Void_PooledReader_Channel_0;

		// Token: 0x040029B0 RID: 10672
		private static readonly IntPtr NativeMethodInfoPtr_Method_Protected_Virtual_New_Void_0;
	}
}
