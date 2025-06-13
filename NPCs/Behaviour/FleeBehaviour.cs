using System;
using Il2CppFishNet.Object;
using Il2CppFishNet.Serializing;
using Il2CppFishNet.Transporting;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.NPCs.Behaviour
{
	// Token: 0x02000378 RID: 888
	public class FleeBehaviour : Behaviour
	{
		// Token: 0x06004309 RID: 17161 RVA: 0x00150F3C File Offset: 0x0014F13C
		// Note: this type is marked as 'beforefieldinit'.
		static FleeBehaviour()
		{
			Il2CppClassPointerStore<FleeBehaviour>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.NPCs.Behaviour", "FleeBehaviour");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FleeBehaviour>.NativeClassPtr);
			FleeBehaviour.NativeFieldInfoPtr_FLEE_DIST_MIN = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FleeBehaviour>.NativeClassPtr, "FLEE_DIST_MIN");
			FleeBehaviour.NativeFieldInfoPtr_FLEE_DIST_MAX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FleeBehaviour>.NativeClassPtr, "FLEE_DIST_MAX");
			FleeBehaviour.NativeFieldInfoPtr_FLEE_SPEED = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FleeBehaviour>.NativeClassPtr, "FLEE_SPEED");
			FleeBehaviour.NativeFieldInfoPtr__EntityToFlee_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FleeBehaviour>.NativeClassPtr, "<EntityToFlee>k__BackingField");
			FleeBehaviour.NativeFieldInfoPtr__FleeMode_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FleeBehaviour>.NativeClassPtr, "<FleeMode>k__BackingField");
			FleeBehaviour.NativeFieldInfoPtr__FleeOrigin_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FleeBehaviour>.NativeClassPtr, "<FleeOrigin>k__BackingField");
			FleeBehaviour.NativeFieldInfoPtr_currentFleeTarget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FleeBehaviour>.NativeClassPtr, "currentFleeTarget");
			FleeBehaviour.NativeFieldInfoPtr_nextVO = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FleeBehaviour>.NativeClassPtr, "nextVO");
			FleeBehaviour.NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FleeBehaviour>.NativeClassPtr, "NetworkInitialize___EarlyScheduleOne.NPCs.Behaviour.FleeBehaviourAssembly-CSharp.dll_Excuted");
			FleeBehaviour.NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FleeBehaviour>.NativeClassPtr, "NetworkInitialize__LateScheduleOne.NPCs.Behaviour.FleeBehaviourAssembly-CSharp.dll_Excuted");
			FleeBehaviour.NativeMethodInfoPtr_get_EntityToFlee_Public_get_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FleeBehaviour>.NativeClassPtr, 100671533);
			FleeBehaviour.NativeMethodInfoPtr_set_EntityToFlee_Private_set_Void_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FleeBehaviour>.NativeClassPtr, 100671534);
			FleeBehaviour.NativeMethodInfoPtr_get_PointToFlee_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FleeBehaviour>.NativeClassPtr, 100671535);
			FleeBehaviour.NativeMethodInfoPtr_get_FleeMode_Public_get_EFleeMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FleeBehaviour>.NativeClassPtr, 100671536);
			FleeBehaviour.NativeMethodInfoPtr_set_FleeMode_Private_set_Void_EFleeMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FleeBehaviour>.NativeClassPtr, 100671537);
			FleeBehaviour.NativeMethodInfoPtr_get_FleeOrigin_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FleeBehaviour>.NativeClassPtr, 100671538);
			FleeBehaviour.NativeMethodInfoPtr_set_FleeOrigin_Private_set_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FleeBehaviour>.NativeClassPtr, 100671539);
			FleeBehaviour.NativeMethodInfoPtr_SetEntityToFlee_Public_Void_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FleeBehaviour>.NativeClassPtr, 100671540);
			FleeBehaviour.NativeMethodInfoPtr_SetPointToFlee_Public_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FleeBehaviour>.NativeClassPtr, 100671541);
			FleeBehaviour.NativeMethodInfoPtr_Begin_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FleeBehaviour>.NativeClassPtr, 100671542);
			FleeBehaviour.NativeMethodInfoPtr_Resume_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FleeBehaviour>.NativeClassPtr, 100671543);
			FleeBehaviour.NativeMethodInfoPtr_End_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FleeBehaviour>.NativeClassPtr, 100671544);
			FleeBehaviour.NativeMethodInfoPtr_Pause_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FleeBehaviour>.NativeClassPtr, 100671545);
			FleeBehaviour.NativeMethodInfoPtr_StartFlee_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FleeBehaviour>.NativeClassPtr, 100671546);
			FleeBehaviour.NativeMethodInfoPtr_ActiveMinPass_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FleeBehaviour>.NativeClassPtr, 100671547);
			FleeBehaviour.NativeMethodInfoPtr_BehaviourUpdate_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FleeBehaviour>.NativeClassPtr, 100671548);
			FleeBehaviour.NativeMethodInfoPtr_Stop_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FleeBehaviour>.NativeClassPtr, 100671549);
			FleeBehaviour.NativeMethodInfoPtr_Flee_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FleeBehaviour>.NativeClassPtr, 100671550);
			FleeBehaviour.NativeMethodInfoPtr_GetFleePosition_Public_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FleeBehaviour>.NativeClassPtr, 100671551);
			FleeBehaviour.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FleeBehaviour>.NativeClassPtr, 100671552);
			FleeBehaviour.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FleeBehaviour>.NativeClassPtr, 100671553);
			FleeBehaviour.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FleeBehaviour>.NativeClassPtr, 100671554);
			FleeBehaviour.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FleeBehaviour>.NativeClassPtr, 100671555);
			FleeBehaviour.NativeMethodInfoPtr_RpcWriter___Observers_SetEntityToFlee_3323014238_Private_Void_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FleeBehaviour>.NativeClassPtr, 100671556);
			FleeBehaviour.NativeMethodInfoPtr_RpcLogic___SetEntityToFlee_3323014238_Public_Void_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FleeBehaviour>.NativeClassPtr, 100671557);
			FleeBehaviour.NativeMethodInfoPtr_RpcReader___Observers_SetEntityToFlee_3323014238_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FleeBehaviour>.NativeClassPtr, 100671558);
			FleeBehaviour.NativeMethodInfoPtr_RpcWriter___Observers_SetPointToFlee_4276783012_Private_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FleeBehaviour>.NativeClassPtr, 100671559);
			FleeBehaviour.NativeMethodInfoPtr_RpcLogic___SetPointToFlee_4276783012_Public_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FleeBehaviour>.NativeClassPtr, 100671560);
			FleeBehaviour.NativeMethodInfoPtr_RpcReader___Observers_SetPointToFlee_4276783012_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FleeBehaviour>.NativeClassPtr, 100671561);
			FleeBehaviour.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FleeBehaviour>.NativeClassPtr, 100671562);
		}

		// Token: 0x17001440 RID: 5184
		// (get) Token: 0x0600430A RID: 17162 RVA: 0x0015128C File Offset: 0x0014F48C
		// (set) Token: 0x0600430B RID: 17163 RVA: 0x001512CC File Offset: 0x0014F4CC
		public unsafe NetworkObject EntityToFlee
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FleeBehaviour.NativeMethodInfoPtr_get_EntityToFlee_Public_get_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NetworkObject>(intPtr2) : null;
			}
			[CallerCount(8)]
			[CachedScanResults(RefRangeStart = 118576, RefRangeEnd = 118584, XrefRangeStart = 118576, XrefRangeEnd = 118584, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FleeBehaviour.NativeMethodInfoPtr_set_EntityToFlee_Private_set_Void_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x17001441 RID: 5185
		// (get) Token: 0x0600430C RID: 17164 RVA: 0x00151310 File Offset: 0x0014F510
		public unsafe Vector3 PointToFlee
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr obj = IL2CPP.il2cpp_runtime_invoke(FleeBehaviour.NativeMethodInfoPtr_get_PointToFlee_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
		}

		// Token: 0x17001442 RID: 5186
		// (get) Token: 0x0600430D RID: 17165 RVA: 0x0015134C File Offset: 0x0014F54C
		// (set) Token: 0x0600430E RID: 17166 RVA: 0x00151388 File Offset: 0x0014F588
		public unsafe FleeBehaviour.EFleeMode FleeMode
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr obj = IL2CPP.il2cpp_runtime_invoke(FleeBehaviour.NativeMethodInfoPtr_get_FleeMode_Public_get_EFleeMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FleeBehaviour.NativeMethodInfoPtr_set_FleeMode_Private_set_Void_EFleeMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x17001443 RID: 5187
		// (get) Token: 0x0600430F RID: 17167 RVA: 0x001513C8 File Offset: 0x0014F5C8
		// (set) Token: 0x06004310 RID: 17168 RVA: 0x00151404 File Offset: 0x0014F604
		public unsafe Vector3 FleeOrigin
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr obj = IL2CPP.il2cpp_runtime_invoke(FleeBehaviour.NativeMethodInfoPtr_get_FleeOrigin_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FleeBehaviour.NativeMethodInfoPtr_set_FleeOrigin_Private_set_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x06004311 RID: 17169 RVA: 0x00151444 File Offset: 0x0014F644
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 156408, XrefRangeEnd = 156429, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetEntityToFlee(NetworkObject entity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(entity);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FleeBehaviour.NativeMethodInfoPtr_SetEntityToFlee_Public_Void_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004312 RID: 17170 RVA: 0x00151488 File Offset: 0x0014F688
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 156429, XrefRangeEnd = 156451, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetPointToFlee(Vector3 point)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref point;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FleeBehaviour.NativeMethodInfoPtr_SetPointToFlee_Public_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004313 RID: 17171 RVA: 0x001514C8 File Offset: 0x0014F6C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 156451, XrefRangeEnd = 156457, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Begin()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FleeBehaviour.NativeMethodInfoPtr_Begin_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004314 RID: 17172 RVA: 0x00151504 File Offset: 0x0014F704
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 156457, XrefRangeEnd = 156459, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Resume()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FleeBehaviour.NativeMethodInfoPtr_Resume_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004315 RID: 17173 RVA: 0x00151540 File Offset: 0x0014F740
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 156459, XrefRangeEnd = 156466, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void End()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FleeBehaviour.NativeMethodInfoPtr_End_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004316 RID: 17174 RVA: 0x0015157C File Offset: 0x0014F77C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 156466, XrefRangeEnd = 156468, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Pause()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FleeBehaviour.NativeMethodInfoPtr_Pause_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004317 RID: 17175 RVA: 0x001515B8 File Offset: 0x0014F7B8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 156483, RefRangeEnd = 156485, XrefRangeStart = 156468, XrefRangeEnd = 156483, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StartFlee()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FleeBehaviour.NativeMethodInfoPtr_StartFlee_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004318 RID: 17176 RVA: 0x001515EC File Offset: 0x0014F7EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 156485, XrefRangeEnd = 156504, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ActiveMinPass()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FleeBehaviour.NativeMethodInfoPtr_ActiveMinPass_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004319 RID: 17177 RVA: 0x00151628 File Offset: 0x0014F828
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 156504, XrefRangeEnd = 156511, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void BehaviourUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FleeBehaviour.NativeMethodInfoPtr_BehaviourUpdate_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600431A RID: 17178 RVA: 0x00151664 File Offset: 0x0014F864
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 156518, RefRangeEnd = 156520, XrefRangeStart = 156511, XrefRangeEnd = 156518, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Stop()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FleeBehaviour.NativeMethodInfoPtr_Stop_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600431B RID: 17179 RVA: 0x00151698 File Offset: 0x0014F898
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 156523, RefRangeEnd = 156524, XrefRangeStart = 156520, XrefRangeEnd = 156523, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Flee()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FleeBehaviour.NativeMethodInfoPtr_Flee_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600431C RID: 17180 RVA: 0x001516CC File Offset: 0x0014F8CC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 156575, RefRangeEnd = 156576, XrefRangeStart = 156524, XrefRangeEnd = 156575, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector3 GetFleePosition()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(FleeBehaviour.NativeMethodInfoPtr_GetFleePosition_Public_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x0600431D RID: 17181 RVA: 0x00151708 File Offset: 0x0014F908
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 156576, XrefRangeEnd = 156581, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FleeBehaviour() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FleeBehaviour>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FleeBehaviour.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600431E RID: 17182 RVA: 0x00151744 File Offset: 0x0014F944
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 156581, XrefRangeEnd = 156595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize___Early()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FleeBehaviour.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600431F RID: 17183 RVA: 0x00151780 File Offset: 0x0014F980
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 156595, XrefRangeEnd = 156596, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize__Late()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FleeBehaviour.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004320 RID: 17184 RVA: 0x001517BC File Offset: 0x0014F9BC
		[CallerCount(0)]
		public unsafe override void NetworkInitializeIfDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FleeBehaviour.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004321 RID: 17185 RVA: 0x001517F8 File Offset: 0x0014F9F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 156596, XrefRangeEnd = 156606, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_SetEntityToFlee_3323014238(NetworkObject entity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(entity);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FleeBehaviour.NativeMethodInfoPtr_RpcWriter___Observers_SetEntityToFlee_3323014238_Private_Void_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004322 RID: 17186 RVA: 0x0015183C File Offset: 0x0014FA3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 156606, XrefRangeEnd = 156607, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SetEntityToFlee_3323014238(NetworkObject entity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(entity);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FleeBehaviour.NativeMethodInfoPtr_RpcLogic___SetEntityToFlee_3323014238_Public_Void_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004323 RID: 17187 RVA: 0x00151880 File Offset: 0x0014FA80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 156607, XrefRangeEnd = 156611, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_SetEntityToFlee_3323014238(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FleeBehaviour.NativeMethodInfoPtr_RpcReader___Observers_SetEntityToFlee_3323014238_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004324 RID: 17188 RVA: 0x001518D0 File Offset: 0x0014FAD0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 156611, XrefRangeEnd = 156623, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_SetPointToFlee_4276783012(Vector3 point)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref point;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FleeBehaviour.NativeMethodInfoPtr_RpcWriter___Observers_SetPointToFlee_4276783012_Private_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004325 RID: 17189 RVA: 0x00151910 File Offset: 0x0014FB10
		[CallerCount(0)]
		public unsafe void RpcLogic___SetPointToFlee_4276783012(Vector3 point)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref point;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FleeBehaviour.NativeMethodInfoPtr_RpcLogic___SetPointToFlee_4276783012_Public_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004326 RID: 17190 RVA: 0x00151950 File Offset: 0x0014FB50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 156623, XrefRangeEnd = 156628, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_SetPointToFlee_4276783012(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FleeBehaviour.NativeMethodInfoPtr_RpcReader___Observers_SetPointToFlee_4276783012_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004327 RID: 17191 RVA: 0x001519A0 File Offset: 0x0014FBA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FleeBehaviour.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004328 RID: 17192 RVA: 0x00020CAD File Offset: 0x0001EEAD
		public FleeBehaviour(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001436 RID: 5174
		// (get) Token: 0x06004329 RID: 17193 RVA: 0x001519DC File Offset: 0x0014FBDC
		// (set) Token: 0x0600432A RID: 17194 RVA: 0x00020CB6 File Offset: 0x0001EEB6
		public unsafe static float FLEE_DIST_MIN
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(FleeBehaviour.NativeFieldInfoPtr_FLEE_DIST_MIN, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(FleeBehaviour.NativeFieldInfoPtr_FLEE_DIST_MIN, (void*)(&value));
			}
		}

		// Token: 0x17001437 RID: 5175
		// (get) Token: 0x0600432B RID: 17195 RVA: 0x001519F8 File Offset: 0x0014FBF8
		// (set) Token: 0x0600432C RID: 17196 RVA: 0x00020CC4 File Offset: 0x0001EEC4
		public unsafe static float FLEE_DIST_MAX
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(FleeBehaviour.NativeFieldInfoPtr_FLEE_DIST_MAX, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(FleeBehaviour.NativeFieldInfoPtr_FLEE_DIST_MAX, (void*)(&value));
			}
		}

		// Token: 0x17001438 RID: 5176
		// (get) Token: 0x0600432D RID: 17197 RVA: 0x00151A14 File Offset: 0x0014FC14
		// (set) Token: 0x0600432E RID: 17198 RVA: 0x00020CD2 File Offset: 0x0001EED2
		public unsafe static float FLEE_SPEED
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(FleeBehaviour.NativeFieldInfoPtr_FLEE_SPEED, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(FleeBehaviour.NativeFieldInfoPtr_FLEE_SPEED, (void*)(&value));
			}
		}

		// Token: 0x17001439 RID: 5177
		// (get) Token: 0x0600432F RID: 17199 RVA: 0x00151A30 File Offset: 0x0014FC30
		// (set) Token: 0x06004330 RID: 17200 RVA: 0x00020CE0 File Offset: 0x0001EEE0
		public unsafe NetworkObject _EntityToFlee_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FleeBehaviour.NativeFieldInfoPtr__EntityToFlee_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NetworkObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FleeBehaviour.NativeFieldInfoPtr__EntityToFlee_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700143A RID: 5178
		// (get) Token: 0x06004331 RID: 17201 RVA: 0x00151A60 File Offset: 0x0014FC60
		// (set) Token: 0x06004332 RID: 17202 RVA: 0x00020CFF File Offset: 0x0001EEFF
		public unsafe FleeBehaviour.EFleeMode _FleeMode_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FleeBehaviour.NativeFieldInfoPtr__FleeMode_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FleeBehaviour.NativeFieldInfoPtr__FleeMode_k__BackingField)) = value;
			}
		}

		// Token: 0x1700143B RID: 5179
		// (get) Token: 0x06004333 RID: 17203 RVA: 0x00151A88 File Offset: 0x0014FC88
		// (set) Token: 0x06004334 RID: 17204 RVA: 0x00020D1A File Offset: 0x0001EF1A
		public unsafe Vector3 _FleeOrigin_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FleeBehaviour.NativeFieldInfoPtr__FleeOrigin_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FleeBehaviour.NativeFieldInfoPtr__FleeOrigin_k__BackingField)) = value;
			}
		}

		// Token: 0x1700143C RID: 5180
		// (get) Token: 0x06004335 RID: 17205 RVA: 0x00151AB0 File Offset: 0x0014FCB0
		// (set) Token: 0x06004336 RID: 17206 RVA: 0x00020D35 File Offset: 0x0001EF35
		public unsafe Vector3 currentFleeTarget
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FleeBehaviour.NativeFieldInfoPtr_currentFleeTarget);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FleeBehaviour.NativeFieldInfoPtr_currentFleeTarget)) = value;
			}
		}

		// Token: 0x1700143D RID: 5181
		// (get) Token: 0x06004337 RID: 17207 RVA: 0x00151AD8 File Offset: 0x0014FCD8
		// (set) Token: 0x06004338 RID: 17208 RVA: 0x00020D50 File Offset: 0x0001EF50
		public unsafe float nextVO
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FleeBehaviour.NativeFieldInfoPtr_nextVO);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FleeBehaviour.NativeFieldInfoPtr_nextVO)) = value;
			}
		}

		// Token: 0x1700143E RID: 5182
		// (get) Token: 0x06004339 RID: 17209 RVA: 0x00151B00 File Offset: 0x0014FD00
		// (set) Token: 0x0600433A RID: 17210 RVA: 0x00020D6B File Offset: 0x0001EF6B
		public new unsafe bool field_Private_Boolean_0
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FleeBehaviour.NativeFieldInfoPtr_field_Private_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FleeBehaviour.NativeFieldInfoPtr_field_Private_Boolean_0)) = value;
			}
		}

		// Token: 0x1700143F RID: 5183
		// (get) Token: 0x0600433B RID: 17211 RVA: 0x00151B28 File Offset: 0x0014FD28
		// (set) Token: 0x0600433C RID: 17212 RVA: 0x00020D86 File Offset: 0x0001EF86
		public new unsafe bool field_Private_Boolean_1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FleeBehaviour.NativeFieldInfoPtr_field_Private_Boolean_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FleeBehaviour.NativeFieldInfoPtr_field_Private_Boolean_1)) = value;
			}
		}

		// Token: 0x04002CC2 RID: 11458
		private static readonly IntPtr NativeFieldInfoPtr_FLEE_DIST_MIN;

		// Token: 0x04002CC3 RID: 11459
		private static readonly IntPtr NativeFieldInfoPtr_FLEE_DIST_MAX;

		// Token: 0x04002CC4 RID: 11460
		private static readonly IntPtr NativeFieldInfoPtr_FLEE_SPEED;

		// Token: 0x04002CC5 RID: 11461
		private static readonly IntPtr NativeFieldInfoPtr__EntityToFlee_k__BackingField;

		// Token: 0x04002CC6 RID: 11462
		private static readonly IntPtr NativeFieldInfoPtr__FleeMode_k__BackingField;

		// Token: 0x04002CC7 RID: 11463
		private static readonly IntPtr NativeFieldInfoPtr__FleeOrigin_k__BackingField;

		// Token: 0x04002CC8 RID: 11464
		private static readonly IntPtr NativeFieldInfoPtr_currentFleeTarget;

		// Token: 0x04002CC9 RID: 11465
		private static readonly IntPtr NativeFieldInfoPtr_nextVO;

		// Token: 0x04002CCA RID: 11466
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

		// Token: 0x04002CCB RID: 11467
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

		// Token: 0x04002CCC RID: 11468
		private static readonly IntPtr NativeMethodInfoPtr_get_EntityToFlee_Public_get_NetworkObject_0;

		// Token: 0x04002CCD RID: 11469
		private static readonly IntPtr NativeMethodInfoPtr_set_EntityToFlee_Private_set_Void_NetworkObject_0;

		// Token: 0x04002CCE RID: 11470
		private static readonly IntPtr NativeMethodInfoPtr_get_PointToFlee_Public_get_Vector3_0;

		// Token: 0x04002CCF RID: 11471
		private static readonly IntPtr NativeMethodInfoPtr_get_FleeMode_Public_get_EFleeMode_0;

		// Token: 0x04002CD0 RID: 11472
		private static readonly IntPtr NativeMethodInfoPtr_set_FleeMode_Private_set_Void_EFleeMode_0;

		// Token: 0x04002CD1 RID: 11473
		private static readonly IntPtr NativeMethodInfoPtr_get_FleeOrigin_Public_get_Vector3_0;

		// Token: 0x04002CD2 RID: 11474
		private static readonly IntPtr NativeMethodInfoPtr_set_FleeOrigin_Private_set_Void_Vector3_0;

		// Token: 0x04002CD3 RID: 11475
		private static readonly IntPtr NativeMethodInfoPtr_SetEntityToFlee_Public_Void_NetworkObject_0;

		// Token: 0x04002CD4 RID: 11476
		private static readonly IntPtr NativeMethodInfoPtr_SetPointToFlee_Public_Void_Vector3_0;

		// Token: 0x04002CD5 RID: 11477
		private static readonly IntPtr NativeMethodInfoPtr_Begin_Protected_Virtual_Void_0;

		// Token: 0x04002CD6 RID: 11478
		private static readonly IntPtr NativeMethodInfoPtr_Resume_Protected_Virtual_Void_0;

		// Token: 0x04002CD7 RID: 11479
		private static readonly IntPtr NativeMethodInfoPtr_End_Protected_Virtual_Void_0;

		// Token: 0x04002CD8 RID: 11480
		private static readonly IntPtr NativeMethodInfoPtr_Pause_Protected_Virtual_Void_0;

		// Token: 0x04002CD9 RID: 11481
		private static readonly IntPtr NativeMethodInfoPtr_StartFlee_Private_Void_0;

		// Token: 0x04002CDA RID: 11482
		private static readonly IntPtr NativeMethodInfoPtr_ActiveMinPass_Public_Virtual_Void_0;

		// Token: 0x04002CDB RID: 11483
		private static readonly IntPtr NativeMethodInfoPtr_BehaviourUpdate_Public_Virtual_Void_0;

		// Token: 0x04002CDC RID: 11484
		private static readonly IntPtr NativeMethodInfoPtr_Stop_Private_Void_0;

		// Token: 0x04002CDD RID: 11485
		private static readonly IntPtr NativeMethodInfoPtr_Flee_Private_Void_0;

		// Token: 0x04002CDE RID: 11486
		private static readonly IntPtr NativeMethodInfoPtr_GetFleePosition_Public_Vector3_0;

		// Token: 0x04002CDF RID: 11487
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04002CE0 RID: 11488
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

		// Token: 0x04002CE1 RID: 11489
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

		// Token: 0x04002CE2 RID: 11490
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

		// Token: 0x04002CE3 RID: 11491
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_SetEntityToFlee_3323014238_Private_Void_NetworkObject_0;

		// Token: 0x04002CE4 RID: 11492
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SetEntityToFlee_3323014238_Public_Void_NetworkObject_0;

		// Token: 0x04002CE5 RID: 11493
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_SetEntityToFlee_3323014238_Private_Void_PooledReader_Channel_0;

		// Token: 0x04002CE6 RID: 11494
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_SetPointToFlee_4276783012_Private_Void_Vector3_0;

		// Token: 0x04002CE7 RID: 11495
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SetPointToFlee_4276783012_Public_Void_Vector3_0;

		// Token: 0x04002CE8 RID: 11496
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_SetPointToFlee_4276783012_Private_Void_PooledReader_Channel_0;

		// Token: 0x04002CE9 RID: 11497
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;

		// Token: 0x020009A8 RID: 2472
		[OriginalName("Assembly-CSharp.dll", "", "EFleeMode")]
		public enum EFleeMode
		{
			// Token: 0x04008B7A RID: 35706
			Entity,
			// Token: 0x04008B7B RID: 35707
			Point
		}
	}
}
