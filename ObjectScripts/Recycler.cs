using System;
using Il2CppFishNet.Connection;
using Il2CppFishNet.Object;
using Il2CppFishNet.Serializing;
using Il2CppFishNet.Transporting;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Audio;
using Il2CppScheduleOne.Interaction;
using Il2CppScheduleOne.Misc;
using Il2CppScheduleOne.Trash;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppTMPro;
using UnityEngine;
using UnityEngine.Events;

namespace Il2CppScheduleOne.ObjectScripts
{
	// Token: 0x02000755 RID: 1877
	public class Recycler : NetworkBehaviour
	{
		// Token: 0x0600A8CA RID: 43210 RVA: 0x002A591C File Offset: 0x002A3B1C
		// Note: this type is marked as 'beforefieldinit'.
		static Recycler()
		{
			Il2CppClassPointerStore<Recycler>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.ObjectScripts", "Recycler");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Recycler>.NativeClassPtr);
			Recycler.NativeFieldInfoPtr__State_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Recycler>.NativeClassPtr, "<State>k__BackingField");
			Recycler.NativeFieldInfoPtr__IsHatchOpen_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Recycler>.NativeClassPtr, "<IsHatchOpen>k__BackingField");
			Recycler.NativeFieldInfoPtr_DetectionMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Recycler>.NativeClassPtr, "DetectionMask");
			Recycler.NativeFieldInfoPtr_HandleIntObj = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Recycler>.NativeClassPtr, "HandleIntObj");
			Recycler.NativeFieldInfoPtr_ButtonIntObj = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Recycler>.NativeClassPtr, "ButtonIntObj");
			Recycler.NativeFieldInfoPtr_CashIntObj = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Recycler>.NativeClassPtr, "CashIntObj");
			Recycler.NativeFieldInfoPtr_ButtonLight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Recycler>.NativeClassPtr, "ButtonLight");
			Recycler.NativeFieldInfoPtr_ButtonAnim = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Recycler>.NativeClassPtr, "ButtonAnim");
			Recycler.NativeFieldInfoPtr_HatchAnim = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Recycler>.NativeClassPtr, "HatchAnim");
			Recycler.NativeFieldInfoPtr_CashAnim = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Recycler>.NativeClassPtr, "CashAnim");
			Recycler.NativeFieldInfoPtr_OpenHatchInstruction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Recycler>.NativeClassPtr, "OpenHatchInstruction");
			Recycler.NativeFieldInfoPtr_InsertTrashInstruction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Recycler>.NativeClassPtr, "InsertTrashInstruction");
			Recycler.NativeFieldInfoPtr_PressBeginInstruction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Recycler>.NativeClassPtr, "PressBeginInstruction");
			Recycler.NativeFieldInfoPtr_ProcessingScreen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Recycler>.NativeClassPtr, "ProcessingScreen");
			Recycler.NativeFieldInfoPtr_ProcessingLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Recycler>.NativeClassPtr, "ProcessingLabel");
			Recycler.NativeFieldInfoPtr_ValueLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Recycler>.NativeClassPtr, "ValueLabel");
			Recycler.NativeFieldInfoPtr_CheckCollider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Recycler>.NativeClassPtr, "CheckCollider");
			Recycler.NativeFieldInfoPtr_Cash = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Recycler>.NativeClassPtr, "Cash");
			Recycler.NativeFieldInfoPtr_BankNote = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Recycler>.NativeClassPtr, "BankNote");
			Recycler.NativeFieldInfoPtr_OpenSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Recycler>.NativeClassPtr, "OpenSound");
			Recycler.NativeFieldInfoPtr_CloseSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Recycler>.NativeClassPtr, "CloseSound");
			Recycler.NativeFieldInfoPtr_PressSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Recycler>.NativeClassPtr, "PressSound");
			Recycler.NativeFieldInfoPtr_DoneSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Recycler>.NativeClassPtr, "DoneSound");
			Recycler.NativeFieldInfoPtr_CashEjectSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Recycler>.NativeClassPtr, "CashEjectSound");
			Recycler.NativeFieldInfoPtr_cashValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Recycler>.NativeClassPtr, "cashValue");
			Recycler.NativeFieldInfoPtr_onStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Recycler>.NativeClassPtr, "onStart");
			Recycler.NativeFieldInfoPtr_onStop = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Recycler>.NativeClassPtr, "onStop");
			Recycler.NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Recycler>.NativeClassPtr, "NetworkInitialize___EarlyScheduleOne.ObjectScripts.RecyclerAssembly-CSharp.dll_Excuted");
			Recycler.NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Recycler>.NativeClassPtr, "NetworkInitialize__LateScheduleOne.ObjectScripts.RecyclerAssembly-CSharp.dll_Excuted");
			Recycler.NativeMethodInfoPtr_get_State_Public_get_EState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Recycler>.NativeClassPtr, 100684040);
			Recycler.NativeMethodInfoPtr_set_State_Protected_set_Void_EState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Recycler>.NativeClassPtr, 100684041);
			Recycler.NativeMethodInfoPtr_get_IsHatchOpen_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Recycler>.NativeClassPtr, 100684042);
			Recycler.NativeMethodInfoPtr_set_IsHatchOpen_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Recycler>.NativeClassPtr, 100684043);
			Recycler.NativeMethodInfoPtr_Start_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Recycler>.NativeClassPtr, 100684044);
			Recycler.NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Recycler>.NativeClassPtr, 100684045);
			Recycler.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Recycler>.NativeClassPtr, 100684046);
			Recycler.NativeMethodInfoPtr_MinPass_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Recycler>.NativeClassPtr, 100684047);
			Recycler.NativeMethodInfoPtr_HandleInteracted_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Recycler>.NativeClassPtr, 100684048);
			Recycler.NativeMethodInfoPtr_ButtonInteracted_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Recycler>.NativeClassPtr, 100684049);
			Recycler.NativeMethodInfoPtr_CashInteracted_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Recycler>.NativeClassPtr, 100684050);
			Recycler.NativeMethodInfoPtr_SendCashCollected_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Recycler>.NativeClassPtr, 100684051);
			Recycler.NativeMethodInfoPtr_CashCollected_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Recycler>.NativeClassPtr, 100684052);
			Recycler.NativeMethodInfoPtr_EnableCash_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Recycler>.NativeClassPtr, 100684053);
			Recycler.NativeMethodInfoPtr_SetCashValue_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Recycler>.NativeClassPtr, 100684054);
			Recycler.NativeMethodInfoPtr_Process_Private_IEnumerator_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Recycler>.NativeClassPtr, 100684055);
			Recycler.NativeMethodInfoPtr_SendState_Public_Void_EState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Recycler>.NativeClassPtr, 100684056);
			Recycler.NativeMethodInfoPtr_SetState_Private_Void_NetworkConnection_EState_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Recycler>.NativeClassPtr, 100684057);
			Recycler.NativeMethodInfoPtr_SetHatchOpen_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Recycler>.NativeClassPtr, 100684058);
			Recycler.NativeMethodInfoPtr_GetTrash_Private_Il2CppReferenceArray_1_TrashItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Recycler>.NativeClassPtr, 100684059);
			Recycler.NativeMethodInfoPtr_OnDrawGizmos_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Recycler>.NativeClassPtr, 100684060);
			Recycler.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Recycler>.NativeClassPtr, 100684061);
			Recycler.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Recycler>.NativeClassPtr, 100684062);
			Recycler.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Recycler>.NativeClassPtr, 100684063);
			Recycler.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Recycler>.NativeClassPtr, 100684064);
			Recycler.NativeMethodInfoPtr_RpcWriter___Server_SendCashCollected_2166136261_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Recycler>.NativeClassPtr, 100684065);
			Recycler.NativeMethodInfoPtr_RpcLogic___SendCashCollected_2166136261_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Recycler>.NativeClassPtr, 100684066);
			Recycler.NativeMethodInfoPtr_RpcReader___Server_SendCashCollected_2166136261_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Recycler>.NativeClassPtr, 100684067);
			Recycler.NativeMethodInfoPtr_RpcWriter___Observers_CashCollected_2166136261_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Recycler>.NativeClassPtr, 100684068);
			Recycler.NativeMethodInfoPtr_RpcLogic___CashCollected_2166136261_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Recycler>.NativeClassPtr, 100684069);
			Recycler.NativeMethodInfoPtr_RpcReader___Observers_CashCollected_2166136261_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Recycler>.NativeClassPtr, 100684070);
			Recycler.NativeMethodInfoPtr_RpcWriter___Observers_EnableCash_2166136261_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Recycler>.NativeClassPtr, 100684071);
			Recycler.NativeMethodInfoPtr_RpcLogic___EnableCash_2166136261_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Recycler>.NativeClassPtr, 100684072);
			Recycler.NativeMethodInfoPtr_RpcReader___Observers_EnableCash_2166136261_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Recycler>.NativeClassPtr, 100684073);
			Recycler.NativeMethodInfoPtr_RpcWriter___Observers_SetCashValue_431000436_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Recycler>.NativeClassPtr, 100684074);
			Recycler.NativeMethodInfoPtr_RpcLogic___SetCashValue_431000436_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Recycler>.NativeClassPtr, 100684075);
			Recycler.NativeMethodInfoPtr_RpcReader___Observers_SetCashValue_431000436_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Recycler>.NativeClassPtr, 100684076);
			Recycler.NativeMethodInfoPtr_RpcWriter___Server_SendState_3569965459_Private_Void_EState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Recycler>.NativeClassPtr, 100684077);
			Recycler.NativeMethodInfoPtr_RpcLogic___SendState_3569965459_Public_Void_EState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Recycler>.NativeClassPtr, 100684078);
			Recycler.NativeMethodInfoPtr_RpcReader___Server_SendState_3569965459_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Recycler>.NativeClassPtr, 100684079);
			Recycler.NativeMethodInfoPtr_RpcWriter___Observers_SetState_3790170803_Private_Void_NetworkConnection_EState_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Recycler>.NativeClassPtr, 100684080);
			Recycler.NativeMethodInfoPtr_RpcLogic___SetState_3790170803_Private_Void_NetworkConnection_EState_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Recycler>.NativeClassPtr, 100684081);
			Recycler.NativeMethodInfoPtr_RpcReader___Observers_SetState_3790170803_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Recycler>.NativeClassPtr, 100684082);
			Recycler.NativeMethodInfoPtr_RpcWriter___Target_SetState_3790170803_Private_Void_NetworkConnection_EState_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Recycler>.NativeClassPtr, 100684083);
			Recycler.NativeMethodInfoPtr_RpcReader___Target_SetState_3790170803_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Recycler>.NativeClassPtr, 100684084);
			Recycler.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Recycler>.NativeClassPtr, 100684085);
		}

		// Token: 0x17003402 RID: 13314
		// (get) Token: 0x0600A8CB RID: 43211 RVA: 0x002A5F28 File Offset: 0x002A4128
		// (set) Token: 0x0600A8CC RID: 43212 RVA: 0x002A5F64 File Offset: 0x002A4164
		public unsafe Recycler.EState State
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Recycler.NativeMethodInfoPtr_get_State_Public_get_EState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
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
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Recycler.NativeMethodInfoPtr_set_State_Protected_set_Void_EState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x17003403 RID: 13315
		// (get) Token: 0x0600A8CD RID: 43213 RVA: 0x002A5FA4 File Offset: 0x002A41A4
		// (set) Token: 0x0600A8CE RID: 43214 RVA: 0x002A5FE0 File Offset: 0x002A41E0
		public unsafe bool IsHatchOpen
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Recycler.NativeMethodInfoPtr_get_IsHatchOpen_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
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
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Recycler.NativeMethodInfoPtr_set_IsHatchOpen_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x0600A8CF RID: 43215 RVA: 0x002A6020 File Offset: 0x002A4220
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 294602, XrefRangeEnd = 294639, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Recycler.NativeMethodInfoPtr_Start_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A8D0 RID: 43216 RVA: 0x002A6054 File Offset: 0x002A4254
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 294639, XrefRangeEnd = 294641, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnSpawnServer(NetworkConnection connection)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(connection);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Recycler.NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A8D1 RID: 43217 RVA: 0x002A60A4 File Offset: 0x002A42A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 294641, XrefRangeEnd = 294659, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Recycler.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A8D2 RID: 43218 RVA: 0x002A60D8 File Offset: 0x002A42D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 294659, XrefRangeEnd = 294670, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MinPass()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Recycler.NativeMethodInfoPtr_MinPass_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A8D3 RID: 43219 RVA: 0x002A610C File Offset: 0x002A430C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 294670, XrefRangeEnd = 294671, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void HandleInteracted()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Recycler.NativeMethodInfoPtr_HandleInteracted_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A8D4 RID: 43220 RVA: 0x002A6140 File Offset: 0x002A4340
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 294671, XrefRangeEnd = 294678, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ButtonInteracted()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Recycler.NativeMethodInfoPtr_ButtonInteracted_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A8D5 RID: 43221 RVA: 0x002A6174 File Offset: 0x002A4374
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 294678, XrefRangeEnd = 294718, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CashInteracted()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Recycler.NativeMethodInfoPtr_CashInteracted_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A8D6 RID: 43222 RVA: 0x002A61A8 File Offset: 0x002A43A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 294718, XrefRangeEnd = 294727, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendCashCollected()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Recycler.NativeMethodInfoPtr_SendCashCollected_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A8D7 RID: 43223 RVA: 0x002A61DC File Offset: 0x002A43DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 294727, XrefRangeEnd = 294749, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CashCollected()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Recycler.NativeMethodInfoPtr_CashCollected_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A8D8 RID: 43224 RVA: 0x002A6210 File Offset: 0x002A4410
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 294749, XrefRangeEnd = 294768, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EnableCash()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Recycler.NativeMethodInfoPtr_EnableCash_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A8D9 RID: 43225 RVA: 0x002A6244 File Offset: 0x002A4444
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 294768, XrefRangeEnd = 294788, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetCashValue(float amount)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref amount;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Recycler.NativeMethodInfoPtr_SetCashValue_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A8DA RID: 43226 RVA: 0x002A6284 File Offset: 0x002A4484
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 294793, RefRangeEnd = 294795, XrefRangeStart = 294788, XrefRangeEnd = 294793, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator Process(bool startedByLocalPlayer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref startedByLocalPlayer;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Recycler.NativeMethodInfoPtr_Process_Private_IEnumerator_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr2) : null;
		}

		// Token: 0x0600A8DB RID: 43227 RVA: 0x002A62D0 File Offset: 0x002A44D0
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 294816, RefRangeEnd = 294824, XrefRangeStart = 294795, XrefRangeEnd = 294816, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendState(Recycler.EState state)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref state;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Recycler.NativeMethodInfoPtr_SendState_Public_Void_EState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A8DC RID: 43228 RVA: 0x002A6310 File Offset: 0x002A4510
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 294868, RefRangeEnd = 294872, XrefRangeStart = 294824, XrefRangeEnd = 294868, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetState(NetworkConnection conn, Recycler.EState state, bool force = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref state;
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref force;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Recycler.NativeMethodInfoPtr_SetState_Private_Void_NetworkConnection_EState_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A8DD RID: 43229 RVA: 0x002A6370 File Offset: 0x002A4570
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 294876, RefRangeEnd = 294877, XrefRangeStart = 294872, XrefRangeEnd = 294876, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetHatchOpen(bool open)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref open;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Recycler.NativeMethodInfoPtr_SetHatchOpen_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A8DE RID: 43230 RVA: 0x002A63B0 File Offset: 0x002A45B0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 294915, RefRangeEnd = 294917, XrefRangeStart = 294877, XrefRangeEnd = 294915, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppReferenceArray<TrashItem> GetTrash()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Recycler.NativeMethodInfoPtr_GetTrash_Private_Il2CppReferenceArray_1_TrashItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<TrashItem>>(intPtr2) : null;
		}

		// Token: 0x0600A8DF RID: 43231 RVA: 0x002A63F0 File Offset: 0x002A45F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 294917, XrefRangeEnd = 294925, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDrawGizmos()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Recycler.NativeMethodInfoPtr_OnDrawGizmos_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A8E0 RID: 43232 RVA: 0x002A6424 File Offset: 0x002A4624
		[CallerCount(22)]
		[CachedScanResults(RefRangeStart = 140600, RefRangeEnd = 140622, XrefRangeStart = 140600, XrefRangeEnd = 140622, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Recycler() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Recycler>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Recycler.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A8E1 RID: 43233 RVA: 0x002A6460 File Offset: 0x002A4660
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 294925, XrefRangeEnd = 294969, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void NetworkInitialize___Early()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Recycler.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A8E2 RID: 43234 RVA: 0x002A649C File Offset: 0x002A469C
		[CallerCount(0)]
		public unsafe virtual void NetworkInitialize__Late()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Recycler.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A8E3 RID: 43235 RVA: 0x002A64D8 File Offset: 0x002A46D8
		[CallerCount(0)]
		public unsafe override void NetworkInitializeIfDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Recycler.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A8E4 RID: 43236 RVA: 0x002A6514 File Offset: 0x002A4714
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_SendCashCollected_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Recycler.NativeMethodInfoPtr_RpcWriter___Server_SendCashCollected_2166136261_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A8E5 RID: 43237 RVA: 0x002A6548 File Offset: 0x002A4748
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SendCashCollected_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Recycler.NativeMethodInfoPtr_RpcLogic___SendCashCollected_2166136261_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A8E6 RID: 43238 RVA: 0x002A657C File Offset: 0x002A477C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 294969, XrefRangeEnd = 294992, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_SendCashCollected_2166136261(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref channel;
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Recycler.NativeMethodInfoPtr_RpcReader___Server_SendCashCollected_2166136261_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A8E7 RID: 43239 RVA: 0x002A65E0 File Offset: 0x002A47E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 294992, XrefRangeEnd = 295001, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_CashCollected_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Recycler.NativeMethodInfoPtr_RpcWriter___Observers_CashCollected_2166136261_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A8E8 RID: 43240 RVA: 0x002A6614 File Offset: 0x002A4814
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 295001, XrefRangeEnd = 295004, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___CashCollected_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Recycler.NativeMethodInfoPtr_RpcLogic___CashCollected_2166136261_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A8E9 RID: 43241 RVA: 0x002A6648 File Offset: 0x002A4848
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 295004, XrefRangeEnd = 295009, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_CashCollected_2166136261(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref channel;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Recycler.NativeMethodInfoPtr_RpcReader___Observers_CashCollected_2166136261_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A8EA RID: 43242 RVA: 0x002A6698 File Offset: 0x002A4898
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 295009, XrefRangeEnd = 295018, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_EnableCash_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Recycler.NativeMethodInfoPtr_RpcWriter___Observers_EnableCash_2166136261_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A8EB RID: 43243 RVA: 0x002A66CC File Offset: 0x002A48CC
		[CallerCount(0)]
		public unsafe void RpcLogic___EnableCash_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Recycler.NativeMethodInfoPtr_RpcLogic___EnableCash_2166136261_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A8EC RID: 43244 RVA: 0x002A6700 File Offset: 0x002A4900
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 295018, XrefRangeEnd = 295020, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_EnableCash_2166136261(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref channel;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Recycler.NativeMethodInfoPtr_RpcReader___Observers_EnableCash_2166136261_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A8ED RID: 43245 RVA: 0x002A6750 File Offset: 0x002A4950
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 295020, XrefRangeEnd = 295030, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_SetCashValue_431000436(float amount)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref amount;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Recycler.NativeMethodInfoPtr_RpcWriter___Observers_SetCashValue_431000436_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A8EE RID: 43246 RVA: 0x002A6790 File Offset: 0x002A4990
		[CallerCount(0)]
		public unsafe void RpcLogic___SetCashValue_431000436(float amount)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref amount;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Recycler.NativeMethodInfoPtr_RpcLogic___SetCashValue_431000436_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A8EF RID: 43247 RVA: 0x002A67D0 File Offset: 0x002A49D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 295030, XrefRangeEnd = 295033, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_SetCashValue_431000436(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref channel;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Recycler.NativeMethodInfoPtr_RpcReader___Observers_SetCashValue_431000436_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A8F0 RID: 43248 RVA: 0x002A6820 File Offset: 0x002A4A20
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 295033, XrefRangeEnd = 295043, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_SendState_3569965459(Recycler.EState state)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref state;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Recycler.NativeMethodInfoPtr_RpcWriter___Server_SendState_3569965459_Private_Void_EState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A8F1 RID: 43249 RVA: 0x002A6860 File Offset: 0x002A4A60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 295043, XrefRangeEnd = 295044, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SendState_3569965459(Recycler.EState state)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref state;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Recycler.NativeMethodInfoPtr_RpcLogic___SendState_3569965459_Public_Void_EState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A8F2 RID: 43250 RVA: 0x002A68A0 File Offset: 0x002A4AA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 295044, XrefRangeEnd = 295048, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_SendState_3569965459(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref channel;
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Recycler.NativeMethodInfoPtr_RpcReader___Server_SendState_3569965459_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A8F3 RID: 43251 RVA: 0x002A6904 File Offset: 0x002A4B04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 295048, XrefRangeEnd = 295059, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_SetState_3790170803(NetworkConnection conn, Recycler.EState state, bool force = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref state;
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref force;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Recycler.NativeMethodInfoPtr_RpcWriter___Observers_SetState_3790170803_Private_Void_NetworkConnection_EState_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A8F4 RID: 43252 RVA: 0x002A6964 File Offset: 0x002A4B64
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 295075, RefRangeEnd = 295078, XrefRangeStart = 295059, XrefRangeEnd = 295075, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SetState_3790170803(NetworkConnection conn, Recycler.EState state, bool force = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref state;
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref force;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Recycler.NativeMethodInfoPtr_RpcLogic___SetState_3790170803_Private_Void_NetworkConnection_EState_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A8F5 RID: 43253 RVA: 0x002A69C4 File Offset: 0x002A4BC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 295078, XrefRangeEnd = 295082, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_SetState_3790170803(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref channel;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Recycler.NativeMethodInfoPtr_RpcReader___Observers_SetState_3790170803_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A8F6 RID: 43254 RVA: 0x002A6A14 File Offset: 0x002A4C14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 295082, XrefRangeEnd = 295093, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Target_SetState_3790170803(NetworkConnection conn, Recycler.EState state, bool force = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref state;
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref force;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Recycler.NativeMethodInfoPtr_RpcWriter___Target_SetState_3790170803_Private_Void_NetworkConnection_EState_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A8F7 RID: 43255 RVA: 0x002A6A74 File Offset: 0x002A4C74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 295093, XrefRangeEnd = 295097, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Target_SetState_3790170803(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref channel;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Recycler.NativeMethodInfoPtr_RpcReader___Target_SetState_3790170803_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A8F8 RID: 43256 RVA: 0x002A6AC4 File Offset: 0x002A4CC4
		[CallerCount(0)]
		public unsafe virtual void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Recycler.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A8F9 RID: 43257 RVA: 0x00052F93 File Offset: 0x00051193
		public Recycler(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170033E5 RID: 13285
		// (get) Token: 0x0600A8FA RID: 43258 RVA: 0x002A6B00 File Offset: 0x002A4D00
		// (set) Token: 0x0600A8FB RID: 43259 RVA: 0x00052F9C File Offset: 0x0005119C
		public unsafe Recycler.EState _State_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Recycler.NativeFieldInfoPtr__State_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Recycler.NativeFieldInfoPtr__State_k__BackingField)) = value;
			}
		}

		// Token: 0x170033E6 RID: 13286
		// (get) Token: 0x0600A8FC RID: 43260 RVA: 0x002A6B28 File Offset: 0x002A4D28
		// (set) Token: 0x0600A8FD RID: 43261 RVA: 0x00052FB7 File Offset: 0x000511B7
		public unsafe bool _IsHatchOpen_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Recycler.NativeFieldInfoPtr__IsHatchOpen_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Recycler.NativeFieldInfoPtr__IsHatchOpen_k__BackingField)) = value;
			}
		}

		// Token: 0x170033E7 RID: 13287
		// (get) Token: 0x0600A8FE RID: 43262 RVA: 0x002A6B50 File Offset: 0x002A4D50
		// (set) Token: 0x0600A8FF RID: 43263 RVA: 0x00052FD2 File Offset: 0x000511D2
		public unsafe LayerMask DetectionMask
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Recycler.NativeFieldInfoPtr_DetectionMask);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Recycler.NativeFieldInfoPtr_DetectionMask)) = value;
			}
		}

		// Token: 0x170033E8 RID: 13288
		// (get) Token: 0x0600A900 RID: 43264 RVA: 0x002A6B78 File Offset: 0x002A4D78
		// (set) Token: 0x0600A901 RID: 43265 RVA: 0x00052FED File Offset: 0x000511ED
		public unsafe InteractableObject HandleIntObj
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Recycler.NativeFieldInfoPtr_HandleIntObj);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<InteractableObject>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Recycler.NativeFieldInfoPtr_HandleIntObj), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170033E9 RID: 13289
		// (get) Token: 0x0600A902 RID: 43266 RVA: 0x002A6BA8 File Offset: 0x002A4DA8
		// (set) Token: 0x0600A903 RID: 43267 RVA: 0x0005300C File Offset: 0x0005120C
		public unsafe InteractableObject ButtonIntObj
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Recycler.NativeFieldInfoPtr_ButtonIntObj);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<InteractableObject>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Recycler.NativeFieldInfoPtr_ButtonIntObj), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170033EA RID: 13290
		// (get) Token: 0x0600A904 RID: 43268 RVA: 0x002A6BD8 File Offset: 0x002A4DD8
		// (set) Token: 0x0600A905 RID: 43269 RVA: 0x0005302B File Offset: 0x0005122B
		public unsafe InteractableObject CashIntObj
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Recycler.NativeFieldInfoPtr_CashIntObj);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<InteractableObject>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Recycler.NativeFieldInfoPtr_CashIntObj), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170033EB RID: 13291
		// (get) Token: 0x0600A906 RID: 43270 RVA: 0x002A6C08 File Offset: 0x002A4E08
		// (set) Token: 0x0600A907 RID: 43271 RVA: 0x0005304A File Offset: 0x0005124A
		public unsafe ToggleableLight ButtonLight
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Recycler.NativeFieldInfoPtr_ButtonLight);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ToggleableLight>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Recycler.NativeFieldInfoPtr_ButtonLight), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170033EC RID: 13292
		// (get) Token: 0x0600A908 RID: 43272 RVA: 0x002A6C38 File Offset: 0x002A4E38
		// (set) Token: 0x0600A909 RID: 43273 RVA: 0x00053069 File Offset: 0x00051269
		public unsafe Animation ButtonAnim
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Recycler.NativeFieldInfoPtr_ButtonAnim);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Animation>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Recycler.NativeFieldInfoPtr_ButtonAnim), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170033ED RID: 13293
		// (get) Token: 0x0600A90A RID: 43274 RVA: 0x002A6C68 File Offset: 0x002A4E68
		// (set) Token: 0x0600A90B RID: 43275 RVA: 0x00053088 File Offset: 0x00051288
		public unsafe Animation HatchAnim
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Recycler.NativeFieldInfoPtr_HatchAnim);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Animation>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Recycler.NativeFieldInfoPtr_HatchAnim), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170033EE RID: 13294
		// (get) Token: 0x0600A90C RID: 43276 RVA: 0x002A6C98 File Offset: 0x002A4E98
		// (set) Token: 0x0600A90D RID: 43277 RVA: 0x000530A7 File Offset: 0x000512A7
		public unsafe Animation CashAnim
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Recycler.NativeFieldInfoPtr_CashAnim);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Animation>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Recycler.NativeFieldInfoPtr_CashAnim), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170033EF RID: 13295
		// (get) Token: 0x0600A90E RID: 43278 RVA: 0x002A6CC8 File Offset: 0x002A4EC8
		// (set) Token: 0x0600A90F RID: 43279 RVA: 0x000530C6 File Offset: 0x000512C6
		public unsafe RectTransform OpenHatchInstruction
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Recycler.NativeFieldInfoPtr_OpenHatchInstruction);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Recycler.NativeFieldInfoPtr_OpenHatchInstruction), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170033F0 RID: 13296
		// (get) Token: 0x0600A910 RID: 43280 RVA: 0x002A6CF8 File Offset: 0x002A4EF8
		// (set) Token: 0x0600A911 RID: 43281 RVA: 0x000530E5 File Offset: 0x000512E5
		public unsafe RectTransform InsertTrashInstruction
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Recycler.NativeFieldInfoPtr_InsertTrashInstruction);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Recycler.NativeFieldInfoPtr_InsertTrashInstruction), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170033F1 RID: 13297
		// (get) Token: 0x0600A912 RID: 43282 RVA: 0x002A6D28 File Offset: 0x002A4F28
		// (set) Token: 0x0600A913 RID: 43283 RVA: 0x00053104 File Offset: 0x00051304
		public unsafe RectTransform PressBeginInstruction
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Recycler.NativeFieldInfoPtr_PressBeginInstruction);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Recycler.NativeFieldInfoPtr_PressBeginInstruction), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170033F2 RID: 13298
		// (get) Token: 0x0600A914 RID: 43284 RVA: 0x002A6D58 File Offset: 0x002A4F58
		// (set) Token: 0x0600A915 RID: 43285 RVA: 0x00053123 File Offset: 0x00051323
		public unsafe RectTransform ProcessingScreen
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Recycler.NativeFieldInfoPtr_ProcessingScreen);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Recycler.NativeFieldInfoPtr_ProcessingScreen), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170033F3 RID: 13299
		// (get) Token: 0x0600A916 RID: 43286 RVA: 0x002A6D88 File Offset: 0x002A4F88
		// (set) Token: 0x0600A917 RID: 43287 RVA: 0x00053142 File Offset: 0x00051342
		public unsafe TextMeshProUGUI ProcessingLabel
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Recycler.NativeFieldInfoPtr_ProcessingLabel);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Recycler.NativeFieldInfoPtr_ProcessingLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170033F4 RID: 13300
		// (get) Token: 0x0600A918 RID: 43288 RVA: 0x002A6DB8 File Offset: 0x002A4FB8
		// (set) Token: 0x0600A919 RID: 43289 RVA: 0x00053161 File Offset: 0x00051361
		public unsafe TextMeshProUGUI ValueLabel
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Recycler.NativeFieldInfoPtr_ValueLabel);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Recycler.NativeFieldInfoPtr_ValueLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170033F5 RID: 13301
		// (get) Token: 0x0600A91A RID: 43290 RVA: 0x002A6DE8 File Offset: 0x002A4FE8
		// (set) Token: 0x0600A91B RID: 43291 RVA: 0x00053180 File Offset: 0x00051380
		public unsafe BoxCollider CheckCollider
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Recycler.NativeFieldInfoPtr_CheckCollider);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BoxCollider>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Recycler.NativeFieldInfoPtr_CheckCollider), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170033F6 RID: 13302
		// (get) Token: 0x0600A91C RID: 43292 RVA: 0x002A6E18 File Offset: 0x002A5018
		// (set) Token: 0x0600A91D RID: 43293 RVA: 0x0005319F File Offset: 0x0005139F
		public unsafe Transform Cash
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Recycler.NativeFieldInfoPtr_Cash);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Recycler.NativeFieldInfoPtr_Cash), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170033F7 RID: 13303
		// (get) Token: 0x0600A91E RID: 43294 RVA: 0x002A6E48 File Offset: 0x002A5048
		// (set) Token: 0x0600A91F RID: 43295 RVA: 0x000531BE File Offset: 0x000513BE
		public unsafe GameObject BankNote
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Recycler.NativeFieldInfoPtr_BankNote);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Recycler.NativeFieldInfoPtr_BankNote), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170033F8 RID: 13304
		// (get) Token: 0x0600A920 RID: 43296 RVA: 0x002A6E78 File Offset: 0x002A5078
		// (set) Token: 0x0600A921 RID: 43297 RVA: 0x000531DD File Offset: 0x000513DD
		public unsafe AudioSourceController OpenSound
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Recycler.NativeFieldInfoPtr_OpenSound);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Recycler.NativeFieldInfoPtr_OpenSound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170033F9 RID: 13305
		// (get) Token: 0x0600A922 RID: 43298 RVA: 0x002A6EA8 File Offset: 0x002A50A8
		// (set) Token: 0x0600A923 RID: 43299 RVA: 0x000531FC File Offset: 0x000513FC
		public unsafe AudioSourceController CloseSound
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Recycler.NativeFieldInfoPtr_CloseSound);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Recycler.NativeFieldInfoPtr_CloseSound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170033FA RID: 13306
		// (get) Token: 0x0600A924 RID: 43300 RVA: 0x002A6ED8 File Offset: 0x002A50D8
		// (set) Token: 0x0600A925 RID: 43301 RVA: 0x0005321B File Offset: 0x0005141B
		public unsafe AudioSourceController PressSound
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Recycler.NativeFieldInfoPtr_PressSound);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Recycler.NativeFieldInfoPtr_PressSound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170033FB RID: 13307
		// (get) Token: 0x0600A926 RID: 43302 RVA: 0x002A6F08 File Offset: 0x002A5108
		// (set) Token: 0x0600A927 RID: 43303 RVA: 0x0005323A File Offset: 0x0005143A
		public unsafe AudioSourceController DoneSound
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Recycler.NativeFieldInfoPtr_DoneSound);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Recycler.NativeFieldInfoPtr_DoneSound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170033FC RID: 13308
		// (get) Token: 0x0600A928 RID: 43304 RVA: 0x002A6F38 File Offset: 0x002A5138
		// (set) Token: 0x0600A929 RID: 43305 RVA: 0x00053259 File Offset: 0x00051459
		public unsafe AudioSourceController CashEjectSound
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Recycler.NativeFieldInfoPtr_CashEjectSound);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Recycler.NativeFieldInfoPtr_CashEjectSound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170033FD RID: 13309
		// (get) Token: 0x0600A92A RID: 43306 RVA: 0x002A6F68 File Offset: 0x002A5168
		// (set) Token: 0x0600A92B RID: 43307 RVA: 0x00053278 File Offset: 0x00051478
		public unsafe float cashValue
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Recycler.NativeFieldInfoPtr_cashValue);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Recycler.NativeFieldInfoPtr_cashValue)) = value;
			}
		}

		// Token: 0x170033FE RID: 13310
		// (get) Token: 0x0600A92C RID: 43308 RVA: 0x002A6F90 File Offset: 0x002A5190
		// (set) Token: 0x0600A92D RID: 43309 RVA: 0x00053293 File Offset: 0x00051493
		public unsafe UnityEvent onStart
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Recycler.NativeFieldInfoPtr_onStart);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Recycler.NativeFieldInfoPtr_onStart), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170033FF RID: 13311
		// (get) Token: 0x0600A92E RID: 43310 RVA: 0x002A6FC0 File Offset: 0x002A51C0
		// (set) Token: 0x0600A92F RID: 43311 RVA: 0x000532B2 File Offset: 0x000514B2
		public unsafe UnityEvent onStop
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Recycler.NativeFieldInfoPtr_onStop);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Recycler.NativeFieldInfoPtr_onStop), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003400 RID: 13312
		// (get) Token: 0x0600A930 RID: 43312 RVA: 0x002A6FF0 File Offset: 0x002A51F0
		// (set) Token: 0x0600A931 RID: 43313 RVA: 0x000532D1 File Offset: 0x000514D1
		public unsafe bool field_Private_Boolean_0
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Recycler.NativeFieldInfoPtr_field_Private_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Recycler.NativeFieldInfoPtr_field_Private_Boolean_0)) = value;
			}
		}

		// Token: 0x17003401 RID: 13313
		// (get) Token: 0x0600A932 RID: 43314 RVA: 0x002A7018 File Offset: 0x002A5218
		// (set) Token: 0x0600A933 RID: 43315 RVA: 0x000532EC File Offset: 0x000514EC
		public unsafe bool field_Private_Boolean_1
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Recycler.NativeFieldInfoPtr_field_Private_Boolean_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Recycler.NativeFieldInfoPtr_field_Private_Boolean_1)) = value;
			}
		}

		// Token: 0x0400712E RID: 28974
		private static readonly System.IntPtr NativeFieldInfoPtr__State_k__BackingField;

		// Token: 0x0400712F RID: 28975
		private static readonly System.IntPtr NativeFieldInfoPtr__IsHatchOpen_k__BackingField;

		// Token: 0x04007130 RID: 28976
		private static readonly System.IntPtr NativeFieldInfoPtr_DetectionMask;

		// Token: 0x04007131 RID: 28977
		private static readonly System.IntPtr NativeFieldInfoPtr_HandleIntObj;

		// Token: 0x04007132 RID: 28978
		private static readonly System.IntPtr NativeFieldInfoPtr_ButtonIntObj;

		// Token: 0x04007133 RID: 28979
		private static readonly System.IntPtr NativeFieldInfoPtr_CashIntObj;

		// Token: 0x04007134 RID: 28980
		private static readonly System.IntPtr NativeFieldInfoPtr_ButtonLight;

		// Token: 0x04007135 RID: 28981
		private static readonly System.IntPtr NativeFieldInfoPtr_ButtonAnim;

		// Token: 0x04007136 RID: 28982
		private static readonly System.IntPtr NativeFieldInfoPtr_HatchAnim;

		// Token: 0x04007137 RID: 28983
		private static readonly System.IntPtr NativeFieldInfoPtr_CashAnim;

		// Token: 0x04007138 RID: 28984
		private static readonly System.IntPtr NativeFieldInfoPtr_OpenHatchInstruction;

		// Token: 0x04007139 RID: 28985
		private static readonly System.IntPtr NativeFieldInfoPtr_InsertTrashInstruction;

		// Token: 0x0400713A RID: 28986
		private static readonly System.IntPtr NativeFieldInfoPtr_PressBeginInstruction;

		// Token: 0x0400713B RID: 28987
		private static readonly System.IntPtr NativeFieldInfoPtr_ProcessingScreen;

		// Token: 0x0400713C RID: 28988
		private static readonly System.IntPtr NativeFieldInfoPtr_ProcessingLabel;

		// Token: 0x0400713D RID: 28989
		private static readonly System.IntPtr NativeFieldInfoPtr_ValueLabel;

		// Token: 0x0400713E RID: 28990
		private static readonly System.IntPtr NativeFieldInfoPtr_CheckCollider;

		// Token: 0x0400713F RID: 28991
		private static readonly System.IntPtr NativeFieldInfoPtr_Cash;

		// Token: 0x04007140 RID: 28992
		private static readonly System.IntPtr NativeFieldInfoPtr_BankNote;

		// Token: 0x04007141 RID: 28993
		private static readonly System.IntPtr NativeFieldInfoPtr_OpenSound;

		// Token: 0x04007142 RID: 28994
		private static readonly System.IntPtr NativeFieldInfoPtr_CloseSound;

		// Token: 0x04007143 RID: 28995
		private static readonly System.IntPtr NativeFieldInfoPtr_PressSound;

		// Token: 0x04007144 RID: 28996
		private static readonly System.IntPtr NativeFieldInfoPtr_DoneSound;

		// Token: 0x04007145 RID: 28997
		private static readonly System.IntPtr NativeFieldInfoPtr_CashEjectSound;

		// Token: 0x04007146 RID: 28998
		private static readonly System.IntPtr NativeFieldInfoPtr_cashValue;

		// Token: 0x04007147 RID: 28999
		private static readonly System.IntPtr NativeFieldInfoPtr_onStart;

		// Token: 0x04007148 RID: 29000
		private static readonly System.IntPtr NativeFieldInfoPtr_onStop;

		// Token: 0x04007149 RID: 29001
		private static readonly System.IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

		// Token: 0x0400714A RID: 29002
		private static readonly System.IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

		// Token: 0x0400714B RID: 29003
		private static readonly System.IntPtr NativeMethodInfoPtr_get_State_Public_get_EState_0;

		// Token: 0x0400714C RID: 29004
		private static readonly System.IntPtr NativeMethodInfoPtr_set_State_Protected_set_Void_EState_0;

		// Token: 0x0400714D RID: 29005
		private static readonly System.IntPtr NativeMethodInfoPtr_get_IsHatchOpen_Public_get_Boolean_0;

		// Token: 0x0400714E RID: 29006
		private static readonly System.IntPtr NativeMethodInfoPtr_set_IsHatchOpen_Private_set_Void_Boolean_0;

		// Token: 0x0400714F RID: 29007
		private static readonly System.IntPtr NativeMethodInfoPtr_Start_Public_Void_0;

		// Token: 0x04007150 RID: 29008
		private static readonly System.IntPtr NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0;

		// Token: 0x04007151 RID: 29009
		private static readonly System.IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

		// Token: 0x04007152 RID: 29010
		private static readonly System.IntPtr NativeMethodInfoPtr_MinPass_Private_Void_0;

		// Token: 0x04007153 RID: 29011
		private static readonly System.IntPtr NativeMethodInfoPtr_HandleInteracted_Public_Void_0;

		// Token: 0x04007154 RID: 29012
		private static readonly System.IntPtr NativeMethodInfoPtr_ButtonInteracted_Public_Void_0;

		// Token: 0x04007155 RID: 29013
		private static readonly System.IntPtr NativeMethodInfoPtr_CashInteracted_Public_Void_0;

		// Token: 0x04007156 RID: 29014
		private static readonly System.IntPtr NativeMethodInfoPtr_SendCashCollected_Private_Void_0;

		// Token: 0x04007157 RID: 29015
		private static readonly System.IntPtr NativeMethodInfoPtr_CashCollected_Private_Void_0;

		// Token: 0x04007158 RID: 29016
		private static readonly System.IntPtr NativeMethodInfoPtr_EnableCash_Private_Void_0;

		// Token: 0x04007159 RID: 29017
		private static readonly System.IntPtr NativeMethodInfoPtr_SetCashValue_Private_Void_Single_0;

		// Token: 0x0400715A RID: 29018
		private static readonly System.IntPtr NativeMethodInfoPtr_Process_Private_IEnumerator_Boolean_0;

		// Token: 0x0400715B RID: 29019
		private static readonly System.IntPtr NativeMethodInfoPtr_SendState_Public_Void_EState_0;

		// Token: 0x0400715C RID: 29020
		private static readonly System.IntPtr NativeMethodInfoPtr_SetState_Private_Void_NetworkConnection_EState_Boolean_0;

		// Token: 0x0400715D RID: 29021
		private static readonly System.IntPtr NativeMethodInfoPtr_SetHatchOpen_Private_Void_Boolean_0;

		// Token: 0x0400715E RID: 29022
		private static readonly System.IntPtr NativeMethodInfoPtr_GetTrash_Private_Il2CppReferenceArray_1_TrashItem_0;

		// Token: 0x0400715F RID: 29023
		private static readonly System.IntPtr NativeMethodInfoPtr_OnDrawGizmos_Private_Void_0;

		// Token: 0x04007160 RID: 29024
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04007161 RID: 29025
		private static readonly System.IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

		// Token: 0x04007162 RID: 29026
		private static readonly System.IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

		// Token: 0x04007163 RID: 29027
		private static readonly System.IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

		// Token: 0x04007164 RID: 29028
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcWriter___Server_SendCashCollected_2166136261_Private_Void_0;

		// Token: 0x04007165 RID: 29029
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcLogic___SendCashCollected_2166136261_Private_Void_0;

		// Token: 0x04007166 RID: 29030
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcReader___Server_SendCashCollected_2166136261_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x04007167 RID: 29031
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcWriter___Observers_CashCollected_2166136261_Private_Void_0;

		// Token: 0x04007168 RID: 29032
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcLogic___CashCollected_2166136261_Private_Void_0;

		// Token: 0x04007169 RID: 29033
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcReader___Observers_CashCollected_2166136261_Private_Void_PooledReader_Channel_0;

		// Token: 0x0400716A RID: 29034
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcWriter___Observers_EnableCash_2166136261_Private_Void_0;

		// Token: 0x0400716B RID: 29035
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcLogic___EnableCash_2166136261_Private_Void_0;

		// Token: 0x0400716C RID: 29036
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcReader___Observers_EnableCash_2166136261_Private_Void_PooledReader_Channel_0;

		// Token: 0x0400716D RID: 29037
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcWriter___Observers_SetCashValue_431000436_Private_Void_Single_0;

		// Token: 0x0400716E RID: 29038
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcLogic___SetCashValue_431000436_Private_Void_Single_0;

		// Token: 0x0400716F RID: 29039
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcReader___Observers_SetCashValue_431000436_Private_Void_PooledReader_Channel_0;

		// Token: 0x04007170 RID: 29040
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcWriter___Server_SendState_3569965459_Private_Void_EState_0;

		// Token: 0x04007171 RID: 29041
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcLogic___SendState_3569965459_Public_Void_EState_0;

		// Token: 0x04007172 RID: 29042
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcReader___Server_SendState_3569965459_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x04007173 RID: 29043
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcWriter___Observers_SetState_3790170803_Private_Void_NetworkConnection_EState_Boolean_0;

		// Token: 0x04007174 RID: 29044
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcLogic___SetState_3790170803_Private_Void_NetworkConnection_EState_Boolean_0;

		// Token: 0x04007175 RID: 29045
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcReader___Observers_SetState_3790170803_Private_Void_PooledReader_Channel_0;

		// Token: 0x04007176 RID: 29046
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcWriter___Target_SetState_3790170803_Private_Void_NetworkConnection_EState_Boolean_0;

		// Token: 0x04007177 RID: 29047
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcReader___Target_SetState_3790170803_Private_Void_PooledReader_Channel_0;

		// Token: 0x04007178 RID: 29048
		private static readonly System.IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;

		// Token: 0x02000C25 RID: 3109
		[OriginalName("Assembly-CSharp.dll", "", "EState")]
		public enum EState
		{
			// Token: 0x04009886 RID: 39046
			HatchClosed,
			// Token: 0x04009887 RID: 39047
			HatchOpen,
			// Token: 0x04009888 RID: 39048
			Processing
		}

		// Token: 0x02000C26 RID: 3110
		[ObfuscatedName("ScheduleOne.ObjectScripts.Recycler+<Process>d__45")]
		public sealed class _Process_d__45 : Il2CppSystem.Object
		{
			// Token: 0x0600E3B8 RID: 58296 RVA: 0x0035DB8C File Offset: 0x0035BD8C
			// Note: this type is marked as 'beforefieldinit'.
			static _Process_d__45()
			{
				Il2CppClassPointerStore<Recycler._Process_d__45>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Recycler>.NativeClassPtr, "<Process>d__45");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Recycler._Process_d__45>.NativeClassPtr);
				Recycler._Process_d__45.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Recycler._Process_d__45>.NativeClassPtr, "<>1__state");
				Recycler._Process_d__45.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Recycler._Process_d__45>.NativeClassPtr, "<>2__current");
				Recycler._Process_d__45.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Recycler._Process_d__45>.NativeClassPtr, "<>4__this");
				Recycler._Process_d__45.NativeFieldInfoPtr_startedByLocalPlayer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Recycler._Process_d__45>.NativeClassPtr, "startedByLocalPlayer");
				Recycler._Process_d__45.NativeFieldInfoPtr__value_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Recycler._Process_d__45>.NativeClassPtr, "<value>5__2");
				Recycler._Process_d__45.NativeFieldInfoPtr__lerpTime_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Recycler._Process_d__45>.NativeClassPtr, "<lerpTime>5__3");
				Recycler._Process_d__45.NativeFieldInfoPtr__i_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Recycler._Process_d__45>.NativeClassPtr, "<i>5__4");
				Recycler._Process_d__45.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Recycler._Process_d__45>.NativeClassPtr, 100684086);
				Recycler._Process_d__45.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Recycler._Process_d__45>.NativeClassPtr, 100684087);
				Recycler._Process_d__45.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Recycler._Process_d__45>.NativeClassPtr, 100684088);
				Recycler._Process_d__45.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Recycler._Process_d__45>.NativeClassPtr, 100684089);
				Recycler._Process_d__45.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Recycler._Process_d__45>.NativeClassPtr, 100684090);
				Recycler._Process_d__45.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Recycler._Process_d__45>.NativeClassPtr, 100684091);
			}

			// Token: 0x0600E3B9 RID: 58297 RVA: 0x0035DCBC File Offset: 0x0035BEBC
			[CallerCount(54)]
			[CachedScanResults(RefRangeStart = 2646, RefRangeEnd = 2700, XrefRangeStart = 2646, XrefRangeEnd = 2700, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _Process_d__45(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Recycler._Process_d__45>.NativeClassPtr))
			{
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = ref <>1__state;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Recycler._Process_d__45.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600E3BA RID: 58298 RVA: 0x0035DD04 File Offset: 0x0035BF04
			[CallerCount(14558)]
			[CachedScanResults(RefRangeStart = 2769, RefRangeEnd = 17327, XrefRangeStart = 2769, XrefRangeEnd = 17327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Recycler._Process_d__45.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600E3BB RID: 58299 RVA: 0x0035DD38 File Offset: 0x0035BF38
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 294487, XrefRangeEnd = 294597, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Recycler._Process_d__45.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x17004648 RID: 17992
			// (get) Token: 0x0600E3BC RID: 58300 RVA: 0x0035DD74 File Offset: 0x0035BF74
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 2740, RefRangeEnd = 2764, XrefRangeStart = 2740, XrefRangeEnd = 2764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Recycler._Process_d__45.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
			}

			// Token: 0x0600E3BD RID: 58301 RVA: 0x0035DDB4 File Offset: 0x0035BFB4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 294597, XrefRangeEnd = 294602, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Recycler._Process_d__45.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x17004649 RID: 17993
			// (get) Token: 0x0600E3BE RID: 58302 RVA: 0x0035DDE8 File Offset: 0x0035BFE8
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 2740, RefRangeEnd = 2764, XrefRangeStart = 2740, XrefRangeEnd = 2764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Recycler._Process_d__45.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
			}

			// Token: 0x0600E3BF RID: 58303 RVA: 0x0006EB0C File Offset: 0x0006CD0C
			public _Process_d__45(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004641 RID: 17985
			// (get) Token: 0x0600E3C0 RID: 58304 RVA: 0x0035DE28 File Offset: 0x0035C028
			// (set) Token: 0x0600E3C1 RID: 58305 RVA: 0x0006EB15 File Offset: 0x0006CD15
			public unsafe int __1__state
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Recycler._Process_d__45.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Recycler._Process_d__45.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17004642 RID: 17986
			// (get) Token: 0x0600E3C2 RID: 58306 RVA: 0x0035DE50 File Offset: 0x0035C050
			// (set) Token: 0x0600E3C3 RID: 58307 RVA: 0x0006EB30 File Offset: 0x0006CD30
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Recycler._Process_d__45.NativeFieldInfoPtr___2__current);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Recycler._Process_d__45.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004643 RID: 17987
			// (get) Token: 0x0600E3C4 RID: 58308 RVA: 0x0035DE80 File Offset: 0x0035C080
			// (set) Token: 0x0600E3C5 RID: 58309 RVA: 0x0006EB4F File Offset: 0x0006CD4F
			public unsafe Recycler __4__this
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Recycler._Process_d__45.NativeFieldInfoPtr___4__this);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Recycler>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Recycler._Process_d__45.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004644 RID: 17988
			// (get) Token: 0x0600E3C6 RID: 58310 RVA: 0x0035DEB0 File Offset: 0x0035C0B0
			// (set) Token: 0x0600E3C7 RID: 58311 RVA: 0x0006EB6E File Offset: 0x0006CD6E
			public unsafe bool startedByLocalPlayer
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Recycler._Process_d__45.NativeFieldInfoPtr_startedByLocalPlayer);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Recycler._Process_d__45.NativeFieldInfoPtr_startedByLocalPlayer)) = value;
				}
			}

			// Token: 0x17004645 RID: 17989
			// (get) Token: 0x0600E3C8 RID: 58312 RVA: 0x0035DED8 File Offset: 0x0035C0D8
			// (set) Token: 0x0600E3C9 RID: 58313 RVA: 0x0006EB89 File Offset: 0x0006CD89
			public unsafe float _value_5__2
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Recycler._Process_d__45.NativeFieldInfoPtr__value_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Recycler._Process_d__45.NativeFieldInfoPtr__value_5__2)) = value;
				}
			}

			// Token: 0x17004646 RID: 17990
			// (get) Token: 0x0600E3CA RID: 58314 RVA: 0x0035DF00 File Offset: 0x0035C100
			// (set) Token: 0x0600E3CB RID: 58315 RVA: 0x0006EBA4 File Offset: 0x0006CDA4
			public unsafe float _lerpTime_5__3
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Recycler._Process_d__45.NativeFieldInfoPtr__lerpTime_5__3);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Recycler._Process_d__45.NativeFieldInfoPtr__lerpTime_5__3)) = value;
				}
			}

			// Token: 0x17004647 RID: 17991
			// (get) Token: 0x0600E3CC RID: 58316 RVA: 0x0035DF28 File Offset: 0x0035C128
			// (set) Token: 0x0600E3CD RID: 58317 RVA: 0x0006EBBF File Offset: 0x0006CDBF
			public unsafe float _i_5__4
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Recycler._Process_d__45.NativeFieldInfoPtr__i_5__4);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Recycler._Process_d__45.NativeFieldInfoPtr__i_5__4)) = value;
				}
			}

			// Token: 0x04009889 RID: 39049
			private static readonly System.IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400988A RID: 39050
			private static readonly System.IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x0400988B RID: 39051
			private static readonly System.IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400988C RID: 39052
			private static readonly System.IntPtr NativeFieldInfoPtr_startedByLocalPlayer;

			// Token: 0x0400988D RID: 39053
			private static readonly System.IntPtr NativeFieldInfoPtr__value_5__2;

			// Token: 0x0400988E RID: 39054
			private static readonly System.IntPtr NativeFieldInfoPtr__lerpTime_5__3;

			// Token: 0x0400988F RID: 39055
			private static readonly System.IntPtr NativeFieldInfoPtr__i_5__4;

			// Token: 0x04009890 RID: 39056
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04009891 RID: 39057
			private static readonly System.IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04009892 RID: 39058
			private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04009893 RID: 39059
			private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04009894 RID: 39060
			private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04009895 RID: 39061
			private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
