using System;
using Il2CppFishNet.Connection;
using Il2CppFishNet.Object;
using Il2CppFishNet.Serializing;
using Il2CppFishNet.Transporting;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Dialogue;
using Il2CppScheduleOne.Economy;
using Il2CppScheduleOne.ItemFramework;
using Il2CppScheduleOne.PlayerScripts;
using Il2CppScheduleOne.UI.Handover;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.NPCs.Behaviour
{
	// Token: 0x02000382 RID: 898
	public class RequestProductBehaviour : Behaviour
	{
		// Token: 0x060044A9 RID: 17577 RVA: 0x001567F0 File Offset: 0x001549F0
		// Note: this type is marked as 'beforefieldinit'.
		static RequestProductBehaviour()
		{
			Il2CppClassPointerStore<RequestProductBehaviour>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.NPCs.Behaviour", "RequestProductBehaviour");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RequestProductBehaviour>.NativeClassPtr);
			RequestProductBehaviour.NativeFieldInfoPtr_CONVERSATION_RANGE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RequestProductBehaviour>.NativeClassPtr, "CONVERSATION_RANGE");
			RequestProductBehaviour.NativeFieldInfoPtr_FOLLOW_MAX_RANGE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RequestProductBehaviour>.NativeClassPtr, "FOLLOW_MAX_RANGE");
			RequestProductBehaviour.NativeFieldInfoPtr_MINS_TO_ASK_AGAIN = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RequestProductBehaviour>.NativeClassPtr, "MINS_TO_ASK_AGAIN");
			RequestProductBehaviour.NativeFieldInfoPtr__TargetPlayer_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RequestProductBehaviour>.NativeClassPtr, "<TargetPlayer>k__BackingField");
			RequestProductBehaviour.NativeFieldInfoPtr__State_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RequestProductBehaviour>.NativeClassPtr, "<State>k__BackingField");
			RequestProductBehaviour.NativeFieldInfoPtr_minsSinceLastDialogue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RequestProductBehaviour>.NativeClassPtr, "minsSinceLastDialogue");
			RequestProductBehaviour.NativeFieldInfoPtr_requestGreeting = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RequestProductBehaviour>.NativeClassPtr, "requestGreeting");
			RequestProductBehaviour.NativeFieldInfoPtr_acceptRequestChoice = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RequestProductBehaviour>.NativeClassPtr, "acceptRequestChoice");
			RequestProductBehaviour.NativeFieldInfoPtr_followChoice = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RequestProductBehaviour>.NativeClassPtr, "followChoice");
			RequestProductBehaviour.NativeFieldInfoPtr_rejectChoice = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RequestProductBehaviour>.NativeClassPtr, "rejectChoice");
			RequestProductBehaviour.NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RequestProductBehaviour>.NativeClassPtr, "NetworkInitialize___EarlyScheduleOne.NPCs.Behaviour.RequestProductBehaviourAssembly-CSharp.dll_Excuted");
			RequestProductBehaviour.NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RequestProductBehaviour>.NativeClassPtr, "NetworkInitialize__LateScheduleOne.NPCs.Behaviour.RequestProductBehaviourAssembly-CSharp.dll_Excuted");
			RequestProductBehaviour.NativeMethodInfoPtr_get_TargetPlayer_Public_get_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RequestProductBehaviour>.NativeClassPtr, 100671755);
			RequestProductBehaviour.NativeMethodInfoPtr_set_TargetPlayer_Private_set_Void_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RequestProductBehaviour>.NativeClassPtr, 100671756);
			RequestProductBehaviour.NativeMethodInfoPtr_get_State_Public_get_EState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RequestProductBehaviour>.NativeClassPtr, 100671757);
			RequestProductBehaviour.NativeMethodInfoPtr_set_State_Private_set_Void_EState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RequestProductBehaviour>.NativeClassPtr, 100671758);
			RequestProductBehaviour.NativeMethodInfoPtr_get_customer_Private_get_Customer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RequestProductBehaviour>.NativeClassPtr, 100671759);
			RequestProductBehaviour.NativeMethodInfoPtr_AssignTarget_Public_Void_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RequestProductBehaviour>.NativeClassPtr, 100671760);
			RequestProductBehaviour.NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RequestProductBehaviour>.NativeClassPtr, 100671761);
			RequestProductBehaviour.NativeMethodInfoPtr_Begin_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RequestProductBehaviour>.NativeClassPtr, 100671762);
			RequestProductBehaviour.NativeMethodInfoPtr_End_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RequestProductBehaviour>.NativeClassPtr, 100671763);
			RequestProductBehaviour.NativeMethodInfoPtr_Disable_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RequestProductBehaviour>.NativeClassPtr, 100671764);
			RequestProductBehaviour.NativeMethodInfoPtr_ActiveMinPass_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RequestProductBehaviour>.NativeClassPtr, 100671765);
			RequestProductBehaviour.NativeMethodInfoPtr_IsTargetDestinationValid_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RequestProductBehaviour>.NativeClassPtr, 100671766);
			RequestProductBehaviour.NativeMethodInfoPtr_GetNewDestination_Private_Boolean_byref_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RequestProductBehaviour>.NativeClassPtr, 100671767);
			RequestProductBehaviour.NativeMethodInfoPtr_IsTargetValid_Public_Static_Boolean_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RequestProductBehaviour>.NativeClassPtr, 100671768);
			RequestProductBehaviour.NativeMethodInfoPtr_CanStartDialogue_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RequestProductBehaviour>.NativeClassPtr, 100671769);
			RequestProductBehaviour.NativeMethodInfoPtr_SetUpDialogue_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RequestProductBehaviour>.NativeClassPtr, 100671770);
			RequestProductBehaviour.NativeMethodInfoPtr_SendStartInitialDialogue_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RequestProductBehaviour>.NativeClassPtr, 100671771);
			RequestProductBehaviour.NativeMethodInfoPtr_StartInitialDialogue_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RequestProductBehaviour>.NativeClassPtr, 100671772);
			RequestProductBehaviour.NativeMethodInfoPtr_SendStartFollowUpDialogue_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RequestProductBehaviour>.NativeClassPtr, 100671773);
			RequestProductBehaviour.NativeMethodInfoPtr_StartFollowUpDialogue_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RequestProductBehaviour>.NativeClassPtr, 100671774);
			RequestProductBehaviour.NativeMethodInfoPtr_DialogueActive_Private_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RequestProductBehaviour>.NativeClassPtr, 100671775);
			RequestProductBehaviour.NativeMethodInfoPtr_RequestAccepted_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RequestProductBehaviour>.NativeClassPtr, 100671776);
			RequestProductBehaviour.NativeMethodInfoPtr_HandoverClosed_Private_Void_EHandoverOutcome_List_1_ItemInstance_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RequestProductBehaviour>.NativeClassPtr, 100671777);
			RequestProductBehaviour.NativeMethodInfoPtr_Follow_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RequestProductBehaviour>.NativeClassPtr, 100671778);
			RequestProductBehaviour.NativeMethodInfoPtr_RequestRejected_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RequestProductBehaviour>.NativeClassPtr, 100671779);
			RequestProductBehaviour.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RequestProductBehaviour>.NativeClassPtr, 100671780);
			RequestProductBehaviour.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RequestProductBehaviour>.NativeClassPtr, 100671781);
			RequestProductBehaviour.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RequestProductBehaviour>.NativeClassPtr, 100671782);
			RequestProductBehaviour.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RequestProductBehaviour>.NativeClassPtr, 100671783);
			RequestProductBehaviour.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RequestProductBehaviour>.NativeClassPtr, 100671784);
			RequestProductBehaviour.NativeMethodInfoPtr_RpcWriter___Observers_AssignTarget_3323014238_Private_Void_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RequestProductBehaviour>.NativeClassPtr, 100671785);
			RequestProductBehaviour.NativeMethodInfoPtr_RpcLogic___AssignTarget_3323014238_Public_Void_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RequestProductBehaviour>.NativeClassPtr, 100671786);
			RequestProductBehaviour.NativeMethodInfoPtr_RpcReader___Observers_AssignTarget_3323014238_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RequestProductBehaviour>.NativeClassPtr, 100671787);
			RequestProductBehaviour.NativeMethodInfoPtr_RpcWriter___Server_SendStartInitialDialogue_2166136261_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RequestProductBehaviour>.NativeClassPtr, 100671788);
			RequestProductBehaviour.NativeMethodInfoPtr_RpcLogic___SendStartInitialDialogue_2166136261_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RequestProductBehaviour>.NativeClassPtr, 100671789);
			RequestProductBehaviour.NativeMethodInfoPtr_RpcReader___Server_SendStartInitialDialogue_2166136261_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RequestProductBehaviour>.NativeClassPtr, 100671790);
			RequestProductBehaviour.NativeMethodInfoPtr_RpcWriter___Observers_StartInitialDialogue_2166136261_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RequestProductBehaviour>.NativeClassPtr, 100671791);
			RequestProductBehaviour.NativeMethodInfoPtr_RpcLogic___StartInitialDialogue_2166136261_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RequestProductBehaviour>.NativeClassPtr, 100671792);
			RequestProductBehaviour.NativeMethodInfoPtr_RpcReader___Observers_StartInitialDialogue_2166136261_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RequestProductBehaviour>.NativeClassPtr, 100671793);
			RequestProductBehaviour.NativeMethodInfoPtr_RpcWriter___Server_SendStartFollowUpDialogue_2166136261_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RequestProductBehaviour>.NativeClassPtr, 100671794);
			RequestProductBehaviour.NativeMethodInfoPtr_RpcLogic___SendStartFollowUpDialogue_2166136261_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RequestProductBehaviour>.NativeClassPtr, 100671795);
			RequestProductBehaviour.NativeMethodInfoPtr_RpcReader___Server_SendStartFollowUpDialogue_2166136261_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RequestProductBehaviour>.NativeClassPtr, 100671796);
			RequestProductBehaviour.NativeMethodInfoPtr_RpcWriter___Observers_StartFollowUpDialogue_2166136261_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RequestProductBehaviour>.NativeClassPtr, 100671797);
			RequestProductBehaviour.NativeMethodInfoPtr_RpcLogic___StartFollowUpDialogue_2166136261_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RequestProductBehaviour>.NativeClassPtr, 100671798);
			RequestProductBehaviour.NativeMethodInfoPtr_RpcReader___Observers_StartFollowUpDialogue_2166136261_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RequestProductBehaviour>.NativeClassPtr, 100671799);
			RequestProductBehaviour.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RequestProductBehaviour>.NativeClassPtr, 100671800);
		}

		// Token: 0x170014B2 RID: 5298
		// (get) Token: 0x060044AA RID: 17578 RVA: 0x00156CA8 File Offset: 0x00154EA8
		// (set) Token: 0x060044AB RID: 17579 RVA: 0x00156CE8 File Offset: 0x00154EE8
		public unsafe Player TargetPlayer
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RequestProductBehaviour.NativeMethodInfoPtr_get_TargetPlayer_Public_get_Player_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
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
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RequestProductBehaviour.NativeMethodInfoPtr_set_TargetPlayer_Private_set_Void_Player_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x170014B3 RID: 5299
		// (get) Token: 0x060044AC RID: 17580 RVA: 0x00156D2C File Offset: 0x00154F2C
		// (set) Token: 0x060044AD RID: 17581 RVA: 0x00156D68 File Offset: 0x00154F68
		public unsafe RequestProductBehaviour.EState State
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(RequestProductBehaviour.NativeMethodInfoPtr_get_State_Public_get_EState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
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
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RequestProductBehaviour.NativeMethodInfoPtr_set_State_Private_set_Void_EState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x170014B4 RID: 5300
		// (get) Token: 0x060044AE RID: 17582 RVA: 0x00156DA8 File Offset: 0x00154FA8
		public unsafe Customer customer
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 158492, RefRangeEnd = 158493, XrefRangeStart = 158487, XrefRangeEnd = 158492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RequestProductBehaviour.NativeMethodInfoPtr_get_customer_Private_get_Customer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Customer>(intPtr2) : null;
			}
		}

		// Token: 0x060044AF RID: 17583 RVA: 0x00156DE8 File Offset: 0x00154FE8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 158522, RefRangeEnd = 158523, XrefRangeStart = 158493, XrefRangeEnd = 158522, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AssignTarget(NetworkObject plr)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(plr);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RequestProductBehaviour.NativeMethodInfoPtr_AssignTarget_Public_Void_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060044B0 RID: 17584 RVA: 0x00156E2C File Offset: 0x0015502C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 158523, XrefRangeEnd = 158524, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RequestProductBehaviour.NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060044B1 RID: 17585 RVA: 0x00156E68 File Offset: 0x00155068
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 158524, XrefRangeEnd = 158566, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Begin()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RequestProductBehaviour.NativeMethodInfoPtr_Begin_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060044B2 RID: 17586 RVA: 0x00156EA4 File Offset: 0x001550A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 158566, XrefRangeEnd = 158574, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void End()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RequestProductBehaviour.NativeMethodInfoPtr_End_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060044B3 RID: 17587 RVA: 0x00156EE0 File Offset: 0x001550E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Disable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RequestProductBehaviour.NativeMethodInfoPtr_Disable_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060044B4 RID: 17588 RVA: 0x00156F1C File Offset: 0x0015511C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 158574, XrefRangeEnd = 158640, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ActiveMinPass()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RequestProductBehaviour.NativeMethodInfoPtr_ActiveMinPass_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060044B5 RID: 17589 RVA: 0x00156F58 File Offset: 0x00155158
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 158653, RefRangeEnd = 158654, XrefRangeStart = 158640, XrefRangeEnd = 158653, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsTargetDestinationValid()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(RequestProductBehaviour.NativeMethodInfoPtr_IsTargetDestinationValid_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x060044B6 RID: 17590 RVA: 0x00156F94 File Offset: 0x00155194
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 158668, RefRangeEnd = 158669, XrefRangeStart = 158654, XrefRangeEnd = 158668, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool GetNewDestination(out Vector3 dest)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = &dest;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(RequestProductBehaviour.NativeMethodInfoPtr_GetNewDestination_Private_Boolean_byref_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x060044B7 RID: 17591 RVA: 0x00156FE0 File Offset: 0x001551E0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 158674, RefRangeEnd = 158676, XrefRangeStart = 158669, XrefRangeEnd = 158674, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsTargetValid(Player player)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(RequestProductBehaviour.NativeMethodInfoPtr_IsTargetValid_Public_Static_Boolean_Player_0, 0, (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x060044B8 RID: 17592 RVA: 0x00157024 File Offset: 0x00155224
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 158700, RefRangeEnd = 158702, XrefRangeStart = 158676, XrefRangeEnd = 158700, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool CanStartDialogue()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(RequestProductBehaviour.NativeMethodInfoPtr_CanStartDialogue_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x060044B9 RID: 17593 RVA: 0x00157060 File Offset: 0x00155260
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 158802, RefRangeEnd = 158803, XrefRangeStart = 158702, XrefRangeEnd = 158802, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetUpDialogue()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RequestProductBehaviour.NativeMethodInfoPtr_SetUpDialogue_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060044BA RID: 17594 RVA: 0x00157094 File Offset: 0x00155294
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 158803, XrefRangeEnd = 158824, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendStartInitialDialogue()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RequestProductBehaviour.NativeMethodInfoPtr_SendStartInitialDialogue_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060044BB RID: 17595 RVA: 0x001570C8 File Offset: 0x001552C8
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 158845, RefRangeEnd = 158849, XrefRangeStart = 158824, XrefRangeEnd = 158845, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StartInitialDialogue()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RequestProductBehaviour.NativeMethodInfoPtr_StartInitialDialogue_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060044BC RID: 17596 RVA: 0x001570FC File Offset: 0x001552FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 158849, XrefRangeEnd = 158870, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendStartFollowUpDialogue()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RequestProductBehaviour.NativeMethodInfoPtr_SendStartFollowUpDialogue_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060044BD RID: 17597 RVA: 0x00157130 File Offset: 0x00155330
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 158891, RefRangeEnd = 158894, XrefRangeStart = 158870, XrefRangeEnd = 158891, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StartFollowUpDialogue()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RequestProductBehaviour.NativeMethodInfoPtr_StartFollowUpDialogue_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060044BE RID: 17598 RVA: 0x00157164 File Offset: 0x00155364
		[CallerCount(0)]
		public unsafe bool DialogueActive(bool enabled)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref enabled;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(RequestProductBehaviour.NativeMethodInfoPtr_DialogueActive_Private_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x060044BF RID: 17599 RVA: 0x001571B0 File Offset: 0x001553B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 158894, XrefRangeEnd = 158918, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RequestAccepted()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RequestProductBehaviour.NativeMethodInfoPtr_RequestAccepted_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060044C0 RID: 17600 RVA: 0x001571E4 File Offset: 0x001553E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 158918, XrefRangeEnd = 158985, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void HandoverClosed(HandoverScreen.EHandoverOutcome outcome, List<ItemInstance> items, float askingPrice)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref outcome;
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(items);
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref askingPrice;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RequestProductBehaviour.NativeMethodInfoPtr_HandoverClosed_Private_Void_EHandoverOutcome_List_1_ItemInstance_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060044C1 RID: 17601 RVA: 0x00157244 File Offset: 0x00155444
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 158985, XrefRangeEnd = 159002, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Follow()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RequestProductBehaviour.NativeMethodInfoPtr_Follow_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060044C2 RID: 17602 RVA: 0x00157278 File Offset: 0x00155478
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 159002, XrefRangeEnd = 159009, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RequestRejected()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RequestProductBehaviour.NativeMethodInfoPtr_RequestRejected_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060044C3 RID: 17603 RVA: 0x001572AC File Offset: 0x001554AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RequestProductBehaviour() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RequestProductBehaviour>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RequestProductBehaviour.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060044C4 RID: 17604 RVA: 0x001572E8 File Offset: 0x001554E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 159009, XrefRangeEnd = 159014, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator Method_Private_IEnumerator_PDM_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RequestProductBehaviour.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr2) : null;
		}

		// Token: 0x060044C5 RID: 17605 RVA: 0x00157328 File Offset: 0x00155528
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 159014, XrefRangeEnd = 159047, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize___Early()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RequestProductBehaviour.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060044C6 RID: 17606 RVA: 0x00157364 File Offset: 0x00155564
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 159047, XrefRangeEnd = 159048, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize__Late()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RequestProductBehaviour.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060044C7 RID: 17607 RVA: 0x001573A0 File Offset: 0x001555A0
		[CallerCount(0)]
		public unsafe override void NetworkInitializeIfDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RequestProductBehaviour.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060044C8 RID: 17608 RVA: 0x001573DC File Offset: 0x001555DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 159048, XrefRangeEnd = 159058, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_AssignTarget_3323014238(NetworkObject plr)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(plr);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RequestProductBehaviour.NativeMethodInfoPtr_RpcWriter___Observers_AssignTarget_3323014238_Private_Void_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060044C9 RID: 17609 RVA: 0x00157420 File Offset: 0x00155620
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 159058, XrefRangeEnd = 159068, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___AssignTarget_3323014238(NetworkObject plr)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(plr);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RequestProductBehaviour.NativeMethodInfoPtr_RpcLogic___AssignTarget_3323014238_Public_Void_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060044CA RID: 17610 RVA: 0x00157464 File Offset: 0x00155664
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 159068, XrefRangeEnd = 159079, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_AssignTarget_3323014238(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref channel;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RequestProductBehaviour.NativeMethodInfoPtr_RpcReader___Observers_AssignTarget_3323014238_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060044CB RID: 17611 RVA: 0x001574B4 File Offset: 0x001556B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 159079, XrefRangeEnd = 159088, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_SendStartInitialDialogue_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RequestProductBehaviour.NativeMethodInfoPtr_RpcWriter___Server_SendStartInitialDialogue_2166136261_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060044CC RID: 17612 RVA: 0x001574E8 File Offset: 0x001556E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 159088, XrefRangeEnd = 159089, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SendStartInitialDialogue_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RequestProductBehaviour.NativeMethodInfoPtr_RpcLogic___SendStartInitialDialogue_2166136261_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060044CD RID: 17613 RVA: 0x0015751C File Offset: 0x0015571C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 159089, XrefRangeEnd = 159092, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_SendStartInitialDialogue_2166136261(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref channel;
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RequestProductBehaviour.NativeMethodInfoPtr_RpcReader___Server_SendStartInitialDialogue_2166136261_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060044CE RID: 17614 RVA: 0x00157580 File Offset: 0x00155780
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 159092, XrefRangeEnd = 159101, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_StartInitialDialogue_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RequestProductBehaviour.NativeMethodInfoPtr_RpcWriter___Observers_StartInitialDialogue_2166136261_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060044CF RID: 17615 RVA: 0x001575B4 File Offset: 0x001557B4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 159120, RefRangeEnd = 159122, XrefRangeStart = 159101, XrefRangeEnd = 159120, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___StartInitialDialogue_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RequestProductBehaviour.NativeMethodInfoPtr_RpcLogic___StartInitialDialogue_2166136261_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060044D0 RID: 17616 RVA: 0x001575E8 File Offset: 0x001557E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 159122, XrefRangeEnd = 159125, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_StartInitialDialogue_2166136261(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref channel;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RequestProductBehaviour.NativeMethodInfoPtr_RpcReader___Observers_StartInitialDialogue_2166136261_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060044D1 RID: 17617 RVA: 0x00157638 File Offset: 0x00155838
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 159125, XrefRangeEnd = 159134, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_SendStartFollowUpDialogue_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RequestProductBehaviour.NativeMethodInfoPtr_RpcWriter___Server_SendStartFollowUpDialogue_2166136261_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060044D2 RID: 17618 RVA: 0x0015766C File Offset: 0x0015586C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 158891, RefRangeEnd = 158894, XrefRangeStart = 158891, XrefRangeEnd = 158894, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SendStartFollowUpDialogue_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RequestProductBehaviour.NativeMethodInfoPtr_RpcLogic___SendStartFollowUpDialogue_2166136261_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060044D3 RID: 17619 RVA: 0x001576A0 File Offset: 0x001558A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 159134, XrefRangeEnd = 159137, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_SendStartFollowUpDialogue_2166136261(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref channel;
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RequestProductBehaviour.NativeMethodInfoPtr_RpcReader___Server_SendStartFollowUpDialogue_2166136261_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060044D4 RID: 17620 RVA: 0x00157704 File Offset: 0x00155904
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 159137, XrefRangeEnd = 159146, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_StartFollowUpDialogue_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RequestProductBehaviour.NativeMethodInfoPtr_RpcWriter___Observers_StartFollowUpDialogue_2166136261_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060044D5 RID: 17621 RVA: 0x00157738 File Offset: 0x00155938
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 159165, RefRangeEnd = 159168, XrefRangeStart = 159146, XrefRangeEnd = 159165, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___StartFollowUpDialogue_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RequestProductBehaviour.NativeMethodInfoPtr_RpcLogic___StartFollowUpDialogue_2166136261_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060044D6 RID: 17622 RVA: 0x0015776C File Offset: 0x0015596C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 159168, XrefRangeEnd = 159171, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_StartFollowUpDialogue_2166136261(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref channel;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RequestProductBehaviour.NativeMethodInfoPtr_RpcReader___Observers_StartFollowUpDialogue_2166136261_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060044D7 RID: 17623 RVA: 0x001577BC File Offset: 0x001559BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RequestProductBehaviour.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060044D8 RID: 17624 RVA: 0x0002175E File Offset: 0x0001F95E
		public RequestProductBehaviour(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170014A6 RID: 5286
		// (get) Token: 0x060044D9 RID: 17625 RVA: 0x001577F8 File Offset: 0x001559F8
		// (set) Token: 0x060044DA RID: 17626 RVA: 0x00021767 File Offset: 0x0001F967
		public unsafe static float CONVERSATION_RANGE
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(RequestProductBehaviour.NativeFieldInfoPtr_CONVERSATION_RANGE, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RequestProductBehaviour.NativeFieldInfoPtr_CONVERSATION_RANGE, (void*)(&value));
			}
		}

		// Token: 0x170014A7 RID: 5287
		// (get) Token: 0x060044DB RID: 17627 RVA: 0x00157814 File Offset: 0x00155A14
		// (set) Token: 0x060044DC RID: 17628 RVA: 0x00021775 File Offset: 0x0001F975
		public unsafe static float FOLLOW_MAX_RANGE
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(RequestProductBehaviour.NativeFieldInfoPtr_FOLLOW_MAX_RANGE, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RequestProductBehaviour.NativeFieldInfoPtr_FOLLOW_MAX_RANGE, (void*)(&value));
			}
		}

		// Token: 0x170014A8 RID: 5288
		// (get) Token: 0x060044DD RID: 17629 RVA: 0x00157830 File Offset: 0x00155A30
		// (set) Token: 0x060044DE RID: 17630 RVA: 0x00021783 File Offset: 0x0001F983
		public unsafe static int MINS_TO_ASK_AGAIN
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(RequestProductBehaviour.NativeFieldInfoPtr_MINS_TO_ASK_AGAIN, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RequestProductBehaviour.NativeFieldInfoPtr_MINS_TO_ASK_AGAIN, (void*)(&value));
			}
		}

		// Token: 0x170014A9 RID: 5289
		// (get) Token: 0x060044DF RID: 17631 RVA: 0x0015784C File Offset: 0x00155A4C
		// (set) Token: 0x060044E0 RID: 17632 RVA: 0x00021791 File Offset: 0x0001F991
		public unsafe Player _TargetPlayer_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(RequestProductBehaviour.NativeFieldInfoPtr__TargetPlayer_k__BackingField);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Player>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(RequestProductBehaviour.NativeFieldInfoPtr__TargetPlayer_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170014AA RID: 5290
		// (get) Token: 0x060044E1 RID: 17633 RVA: 0x0015787C File Offset: 0x00155A7C
		// (set) Token: 0x060044E2 RID: 17634 RVA: 0x000217B0 File Offset: 0x0001F9B0
		public unsafe RequestProductBehaviour.EState _State_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(RequestProductBehaviour.NativeFieldInfoPtr__State_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(RequestProductBehaviour.NativeFieldInfoPtr__State_k__BackingField)) = value;
			}
		}

		// Token: 0x170014AB RID: 5291
		// (get) Token: 0x060044E3 RID: 17635 RVA: 0x001578A4 File Offset: 0x00155AA4
		// (set) Token: 0x060044E4 RID: 17636 RVA: 0x000217CB File Offset: 0x0001F9CB
		public unsafe int minsSinceLastDialogue
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(RequestProductBehaviour.NativeFieldInfoPtr_minsSinceLastDialogue);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(RequestProductBehaviour.NativeFieldInfoPtr_minsSinceLastDialogue)) = value;
			}
		}

		// Token: 0x170014AC RID: 5292
		// (get) Token: 0x060044E5 RID: 17637 RVA: 0x001578CC File Offset: 0x00155ACC
		// (set) Token: 0x060044E6 RID: 17638 RVA: 0x000217E6 File Offset: 0x0001F9E6
		public unsafe DialogueController.GreetingOverride requestGreeting
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(RequestProductBehaviour.NativeFieldInfoPtr_requestGreeting);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DialogueController.GreetingOverride>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(RequestProductBehaviour.NativeFieldInfoPtr_requestGreeting), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170014AD RID: 5293
		// (get) Token: 0x060044E7 RID: 17639 RVA: 0x001578FC File Offset: 0x00155AFC
		// (set) Token: 0x060044E8 RID: 17640 RVA: 0x00021805 File Offset: 0x0001FA05
		public unsafe DialogueController.DialogueChoice acceptRequestChoice
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(RequestProductBehaviour.NativeFieldInfoPtr_acceptRequestChoice);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DialogueController.DialogueChoice>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(RequestProductBehaviour.NativeFieldInfoPtr_acceptRequestChoice), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170014AE RID: 5294
		// (get) Token: 0x060044E9 RID: 17641 RVA: 0x0015792C File Offset: 0x00155B2C
		// (set) Token: 0x060044EA RID: 17642 RVA: 0x00021824 File Offset: 0x0001FA24
		public unsafe DialogueController.DialogueChoice followChoice
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(RequestProductBehaviour.NativeFieldInfoPtr_followChoice);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DialogueController.DialogueChoice>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(RequestProductBehaviour.NativeFieldInfoPtr_followChoice), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170014AF RID: 5295
		// (get) Token: 0x060044EB RID: 17643 RVA: 0x0015795C File Offset: 0x00155B5C
		// (set) Token: 0x060044EC RID: 17644 RVA: 0x00021843 File Offset: 0x0001FA43
		public unsafe DialogueController.DialogueChoice rejectChoice
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(RequestProductBehaviour.NativeFieldInfoPtr_rejectChoice);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DialogueController.DialogueChoice>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(RequestProductBehaviour.NativeFieldInfoPtr_rejectChoice), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170014B0 RID: 5296
		// (get) Token: 0x060044ED RID: 17645 RVA: 0x0015798C File Offset: 0x00155B8C
		// (set) Token: 0x060044EE RID: 17646 RVA: 0x00021862 File Offset: 0x0001FA62
		public new unsafe bool field_Private_Boolean_0
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(RequestProductBehaviour.NativeFieldInfoPtr_field_Private_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(RequestProductBehaviour.NativeFieldInfoPtr_field_Private_Boolean_0)) = value;
			}
		}

		// Token: 0x170014B1 RID: 5297
		// (get) Token: 0x060044EF RID: 17647 RVA: 0x001579B4 File Offset: 0x00155BB4
		// (set) Token: 0x060044F0 RID: 17648 RVA: 0x0002187D File Offset: 0x0001FA7D
		public new unsafe bool field_Private_Boolean_1
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(RequestProductBehaviour.NativeFieldInfoPtr_field_Private_Boolean_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(RequestProductBehaviour.NativeFieldInfoPtr_field_Private_Boolean_1)) = value;
			}
		}

		// Token: 0x04002DE8 RID: 11752
		private static readonly System.IntPtr NativeFieldInfoPtr_CONVERSATION_RANGE;

		// Token: 0x04002DE9 RID: 11753
		private static readonly System.IntPtr NativeFieldInfoPtr_FOLLOW_MAX_RANGE;

		// Token: 0x04002DEA RID: 11754
		private static readonly System.IntPtr NativeFieldInfoPtr_MINS_TO_ASK_AGAIN;

		// Token: 0x04002DEB RID: 11755
		private static readonly System.IntPtr NativeFieldInfoPtr__TargetPlayer_k__BackingField;

		// Token: 0x04002DEC RID: 11756
		private static readonly System.IntPtr NativeFieldInfoPtr__State_k__BackingField;

		// Token: 0x04002DED RID: 11757
		private static readonly System.IntPtr NativeFieldInfoPtr_minsSinceLastDialogue;

		// Token: 0x04002DEE RID: 11758
		private static readonly System.IntPtr NativeFieldInfoPtr_requestGreeting;

		// Token: 0x04002DEF RID: 11759
		private static readonly System.IntPtr NativeFieldInfoPtr_acceptRequestChoice;

		// Token: 0x04002DF0 RID: 11760
		private static readonly System.IntPtr NativeFieldInfoPtr_followChoice;

		// Token: 0x04002DF1 RID: 11761
		private static readonly System.IntPtr NativeFieldInfoPtr_rejectChoice;

		// Token: 0x04002DF2 RID: 11762
		private static readonly System.IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

		// Token: 0x04002DF3 RID: 11763
		private static readonly System.IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

		// Token: 0x04002DF4 RID: 11764
		private static readonly System.IntPtr NativeMethodInfoPtr_get_TargetPlayer_Public_get_Player_0;

		// Token: 0x04002DF5 RID: 11765
		private static readonly System.IntPtr NativeMethodInfoPtr_set_TargetPlayer_Private_set_Void_Player_0;

		// Token: 0x04002DF6 RID: 11766
		private static readonly System.IntPtr NativeMethodInfoPtr_get_State_Public_get_EState_0;

		// Token: 0x04002DF7 RID: 11767
		private static readonly System.IntPtr NativeMethodInfoPtr_set_State_Private_set_Void_EState_0;

		// Token: 0x04002DF8 RID: 11768
		private static readonly System.IntPtr NativeMethodInfoPtr_get_customer_Private_get_Customer_0;

		// Token: 0x04002DF9 RID: 11769
		private static readonly System.IntPtr NativeMethodInfoPtr_AssignTarget_Public_Void_NetworkObject_0;

		// Token: 0x04002DFA RID: 11770
		private static readonly System.IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0;

		// Token: 0x04002DFB RID: 11771
		private static readonly System.IntPtr NativeMethodInfoPtr_Begin_Protected_Virtual_Void_0;

		// Token: 0x04002DFC RID: 11772
		private static readonly System.IntPtr NativeMethodInfoPtr_End_Protected_Virtual_Void_0;

		// Token: 0x04002DFD RID: 11773
		private static readonly System.IntPtr NativeMethodInfoPtr_Disable_Public_Virtual_Void_0;

		// Token: 0x04002DFE RID: 11774
		private static readonly System.IntPtr NativeMethodInfoPtr_ActiveMinPass_Public_Virtual_Void_0;

		// Token: 0x04002DFF RID: 11775
		private static readonly System.IntPtr NativeMethodInfoPtr_IsTargetDestinationValid_Private_Boolean_0;

		// Token: 0x04002E00 RID: 11776
		private static readonly System.IntPtr NativeMethodInfoPtr_GetNewDestination_Private_Boolean_byref_Vector3_0;

		// Token: 0x04002E01 RID: 11777
		private static readonly System.IntPtr NativeMethodInfoPtr_IsTargetValid_Public_Static_Boolean_Player_0;

		// Token: 0x04002E02 RID: 11778
		private static readonly System.IntPtr NativeMethodInfoPtr_CanStartDialogue_Public_Boolean_0;

		// Token: 0x04002E03 RID: 11779
		private static readonly System.IntPtr NativeMethodInfoPtr_SetUpDialogue_Private_Void_0;

		// Token: 0x04002E04 RID: 11780
		private static readonly System.IntPtr NativeMethodInfoPtr_SendStartInitialDialogue_Private_Void_0;

		// Token: 0x04002E05 RID: 11781
		private static readonly System.IntPtr NativeMethodInfoPtr_StartInitialDialogue_Private_Void_0;

		// Token: 0x04002E06 RID: 11782
		private static readonly System.IntPtr NativeMethodInfoPtr_SendStartFollowUpDialogue_Private_Void_0;

		// Token: 0x04002E07 RID: 11783
		private static readonly System.IntPtr NativeMethodInfoPtr_StartFollowUpDialogue_Private_Void_0;

		// Token: 0x04002E08 RID: 11784
		private static readonly System.IntPtr NativeMethodInfoPtr_DialogueActive_Private_Boolean_Boolean_0;

		// Token: 0x04002E09 RID: 11785
		private static readonly System.IntPtr NativeMethodInfoPtr_RequestAccepted_Private_Void_0;

		// Token: 0x04002E0A RID: 11786
		private static readonly System.IntPtr NativeMethodInfoPtr_HandoverClosed_Private_Void_EHandoverOutcome_List_1_ItemInstance_Single_0;

		// Token: 0x04002E0B RID: 11787
		private static readonly System.IntPtr NativeMethodInfoPtr_Follow_Private_Void_0;

		// Token: 0x04002E0C RID: 11788
		private static readonly System.IntPtr NativeMethodInfoPtr_RequestRejected_Private_Void_0;

		// Token: 0x04002E0D RID: 11789
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04002E0E RID: 11790
		private static readonly System.IntPtr NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0;

		// Token: 0x04002E0F RID: 11791
		private static readonly System.IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

		// Token: 0x04002E10 RID: 11792
		private static readonly System.IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

		// Token: 0x04002E11 RID: 11793
		private static readonly System.IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

		// Token: 0x04002E12 RID: 11794
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcWriter___Observers_AssignTarget_3323014238_Private_Void_NetworkObject_0;

		// Token: 0x04002E13 RID: 11795
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcLogic___AssignTarget_3323014238_Public_Void_NetworkObject_0;

		// Token: 0x04002E14 RID: 11796
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcReader___Observers_AssignTarget_3323014238_Private_Void_PooledReader_Channel_0;

		// Token: 0x04002E15 RID: 11797
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcWriter___Server_SendStartInitialDialogue_2166136261_Private_Void_0;

		// Token: 0x04002E16 RID: 11798
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcLogic___SendStartInitialDialogue_2166136261_Private_Void_0;

		// Token: 0x04002E17 RID: 11799
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcReader___Server_SendStartInitialDialogue_2166136261_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x04002E18 RID: 11800
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcWriter___Observers_StartInitialDialogue_2166136261_Private_Void_0;

		// Token: 0x04002E19 RID: 11801
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcLogic___StartInitialDialogue_2166136261_Private_Void_0;

		// Token: 0x04002E1A RID: 11802
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcReader___Observers_StartInitialDialogue_2166136261_Private_Void_PooledReader_Channel_0;

		// Token: 0x04002E1B RID: 11803
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcWriter___Server_SendStartFollowUpDialogue_2166136261_Private_Void_0;

		// Token: 0x04002E1C RID: 11804
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcLogic___SendStartFollowUpDialogue_2166136261_Private_Void_0;

		// Token: 0x04002E1D RID: 11805
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcReader___Server_SendStartFollowUpDialogue_2166136261_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x04002E1E RID: 11806
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcWriter___Observers_StartFollowUpDialogue_2166136261_Private_Void_0;

		// Token: 0x04002E1F RID: 11807
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcLogic___StartFollowUpDialogue_2166136261_Private_Void_0;

		// Token: 0x04002E20 RID: 11808
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcReader___Observers_StartFollowUpDialogue_2166136261_Private_Void_PooledReader_Channel_0;

		// Token: 0x04002E21 RID: 11809
		private static readonly System.IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;

		// Token: 0x020009B0 RID: 2480
		[OriginalName("Assembly-CSharp.dll", "", "EState")]
		public enum EState
		{
			// Token: 0x04008BAB RID: 35755
			InitialApproach,
			// Token: 0x04008BAC RID: 35756
			FollowPlayer
		}

		// Token: 0x020009B1 RID: 2481
		[ObfuscatedName("ScheduleOne.NPCs.Behaviour.RequestProductBehaviour+<<HandoverClosed>g__Wait|36_0>d")]
		public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReObObUnique : Il2CppSystem.Object
		{
			// Token: 0x0600CE49 RID: 52809 RVA: 0x003211DC File Offset: 0x0031F3DC
			// Note: this type is marked as 'beforefieldinit'.
			static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReObObUnique()
			{
				Il2CppClassPointerStore<RequestProductBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RequestProductBehaviour>.NativeClassPtr, "<<HandoverClosed>g__Wait|36_0>d");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RequestProductBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReObObUnique>.NativeClassPtr);
				RequestProductBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RequestProductBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReObObUnique>.NativeClassPtr, "<>1__state");
				RequestProductBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RequestProductBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReObObUnique>.NativeClassPtr, "<>2__current");
				RequestProductBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RequestProductBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReObObUnique>.NativeClassPtr, "<>4__this");
				RequestProductBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RequestProductBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReObObUnique>.NativeClassPtr, 100671801);
				RequestProductBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RequestProductBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReObObUnique>.NativeClassPtr, 100671802);
				RequestProductBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RequestProductBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReObObUnique>.NativeClassPtr, 100671803);
				RequestProductBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RequestProductBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReObObUnique>.NativeClassPtr, 100671804);
				RequestProductBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RequestProductBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReObObUnique>.NativeClassPtr, 100671805);
				RequestProductBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RequestProductBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReObObUnique>.NativeClassPtr, 100671806);
			}

			// Token: 0x0600CE4A RID: 52810 RVA: 0x003212BC File Offset: 0x0031F4BC
			[CallerCount(54)]
			[CachedScanResults(RefRangeStart = 2646, RefRangeEnd = 2700, XrefRangeStart = 2646, XrefRangeEnd = 2700, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RequestProductBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReObObUnique>.NativeClassPtr))
			{
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = ref <>1__state;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RequestProductBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600CE4B RID: 52811 RVA: 0x00321304 File Offset: 0x0031F504
			[CallerCount(14558)]
			[CachedScanResults(RefRangeStart = 2769, RefRangeEnd = 17327, XrefRangeStart = 2769, XrefRangeEnd = 17327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RequestProductBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600CE4C RID: 52812 RVA: 0x00321338 File Offset: 0x0031F538
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 158477, XrefRangeEnd = 158482, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(RequestProductBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x1700400D RID: 16397
			// (get) Token: 0x0600CE4D RID: 52813 RVA: 0x00321374 File Offset: 0x0031F574
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 2740, RefRangeEnd = 2764, XrefRangeStart = 2740, XrefRangeEnd = 2764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RequestProductBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
			}

			// Token: 0x0600CE4E RID: 52814 RVA: 0x003213B4 File Offset: 0x0031F5B4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 158482, XrefRangeEnd = 158487, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RequestProductBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x1700400E RID: 16398
			// (get) Token: 0x0600CE4F RID: 52815 RVA: 0x003213E8 File Offset: 0x0031F5E8
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 2740, RefRangeEnd = 2764, XrefRangeStart = 2740, XrefRangeEnd = 2764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RequestProductBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
			}

			// Token: 0x0600CE50 RID: 52816 RVA: 0x0006406C File Offset: 0x0006226C
			public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReObObUnique(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700400A RID: 16394
			// (get) Token: 0x0600CE51 RID: 52817 RVA: 0x00321428 File Offset: 0x0031F628
			// (set) Token: 0x0600CE52 RID: 52818 RVA: 0x00064075 File Offset: 0x00062275
			public unsafe int __1__state
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(RequestProductBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReObObUnique.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(RequestProductBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReObObUnique.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700400B RID: 16395
			// (get) Token: 0x0600CE53 RID: 52819 RVA: 0x00321450 File Offset: 0x0031F650
			// (set) Token: 0x0600CE54 RID: 52820 RVA: 0x00064090 File Offset: 0x00062290
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(RequestProductBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReObObUnique.NativeFieldInfoPtr___2__current);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(RequestProductBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700400C RID: 16396
			// (get) Token: 0x0600CE55 RID: 52821 RVA: 0x00321480 File Offset: 0x0031F680
			// (set) Token: 0x0600CE56 RID: 52822 RVA: 0x000640AF File Offset: 0x000622AF
			public unsafe RequestProductBehaviour __4__this
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(RequestProductBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReObObUnique.NativeFieldInfoPtr___4__this);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RequestProductBehaviour>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(RequestProductBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008BAD RID: 35757
			private static readonly System.IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04008BAE RID: 35758
			private static readonly System.IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04008BAF RID: 35759
			private static readonly System.IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04008BB0 RID: 35760
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04008BB1 RID: 35761
			private static readonly System.IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008BB2 RID: 35762
			private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04008BB3 RID: 35763
			private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04008BB4 RID: 35764
			private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008BB5 RID: 35765
			private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
