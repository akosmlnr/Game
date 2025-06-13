using System;
using Il2CppFishNet.Connection;
using Il2CppFishNet.Object;
using Il2CppFishNet.Serializing;
using Il2CppFishNet.Transporting;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Audio;
using Il2CppScheduleOne.DevUtilities;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.Dragging
{
	// Token: 0x02000440 RID: 1088
	public class DragManager : NetworkSingleton<DragManager>
	{
		// Token: 0x06005E9D RID: 24221 RVA: 0x001B6EE0 File Offset: 0x001B50E0
		// Note: this type is marked as 'beforefieldinit'.
		static DragManager()
		{
			Il2CppClassPointerStore<DragManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Dragging", "DragManager");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DragManager>.NativeClassPtr);
			DragManager.NativeFieldInfoPtr_DRAGGABLE_OFFSET = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DragManager>.NativeClassPtr, "DRAGGABLE_OFFSET");
			DragManager.NativeFieldInfoPtr_ThrowSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DragManager>.NativeClassPtr, "ThrowSound");
			DragManager.NativeFieldInfoPtr_DragForce = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DragManager>.NativeClassPtr, "DragForce");
			DragManager.NativeFieldInfoPtr_DampingFactor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DragManager>.NativeClassPtr, "DampingFactor");
			DragManager.NativeFieldInfoPtr_TorqueForce = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DragManager>.NativeClassPtr, "TorqueForce");
			DragManager.NativeFieldInfoPtr_TorqueDampingFactor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DragManager>.NativeClassPtr, "TorqueDampingFactor");
			DragManager.NativeFieldInfoPtr_ThrowForce = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DragManager>.NativeClassPtr, "ThrowForce");
			DragManager.NativeFieldInfoPtr_MassInfluence = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DragManager>.NativeClassPtr, "MassInfluence");
			DragManager.NativeFieldInfoPtr__CurrentDraggable_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DragManager>.NativeClassPtr, "<CurrentDraggable>k__BackingField");
			DragManager.NativeFieldInfoPtr_AllDraggables = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DragManager>.NativeClassPtr, "AllDraggables");
			DragManager.NativeFieldInfoPtr_lastThrownDraggable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DragManager>.NativeClassPtr, "lastThrownDraggable");
			DragManager.NativeFieldInfoPtr_lastHeldDraggable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DragManager>.NativeClassPtr, "lastHeldDraggable");
			DragManager.NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DragManager>.NativeClassPtr, "NetworkInitialize___EarlyScheduleOne.Dragging.DragManagerAssembly-CSharp.dll_Excuted");
			DragManager.NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DragManager>.NativeClassPtr, "NetworkInitialize__LateScheduleOne.Dragging.DragManagerAssembly-CSharp.dll_Excuted");
			DragManager.NativeMethodInfoPtr_get_CurrentDraggable_Public_get_Draggable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DragManager>.NativeClassPtr, 100675446);
			DragManager.NativeMethodInfoPtr_set_CurrentDraggable_Protected_set_Void_Draggable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DragManager>.NativeClassPtr, 100675447);
			DragManager.NativeMethodInfoPtr_get_IsDragging_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DragManager>.NativeClassPtr, 100675448);
			DragManager.NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DragManager>.NativeClassPtr, 100675449);
			DragManager.NativeMethodInfoPtr_Update_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DragManager>.NativeClassPtr, 100675450);
			DragManager.NativeMethodInfoPtr_FixedUpdate_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DragManager>.NativeClassPtr, 100675451);
			DragManager.NativeMethodInfoPtr_IsDraggingAllowed_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DragManager>.NativeClassPtr, 100675452);
			DragManager.NativeMethodInfoPtr_RegisterDraggable_Public_Void_Draggable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DragManager>.NativeClassPtr, 100675453);
			DragManager.NativeMethodInfoPtr_Deregister_Public_Void_Draggable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DragManager>.NativeClassPtr, 100675454);
			DragManager.NativeMethodInfoPtr_StartDragging_Public_Void_Draggable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DragManager>.NativeClassPtr, 100675455);
			DragManager.NativeMethodInfoPtr_SendDragger_Private_Void_String_NetworkObject_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DragManager>.NativeClassPtr, 100675456);
			DragManager.NativeMethodInfoPtr_SetDragger_Private_Void_String_NetworkObject_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DragManager>.NativeClassPtr, 100675457);
			DragManager.NativeMethodInfoPtr_StopDragging_Public_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DragManager>.NativeClassPtr, 100675458);
			DragManager.NativeMethodInfoPtr_SendDraggableTransformData_Private_Void_String_Vector3_Quaternion_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DragManager>.NativeClassPtr, 100675459);
			DragManager.NativeMethodInfoPtr_SetDraggableTransformData_Private_Void_NetworkConnection_String_Vector3_Quaternion_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DragManager>.NativeClassPtr, 100675460);
			DragManager.NativeMethodInfoPtr_GetTargetPosition_Private_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DragManager>.NativeClassPtr, 100675461);
			DragManager.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DragManager>.NativeClassPtr, 100675462);
			DragManager.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DragManager>.NativeClassPtr, 100675463);
			DragManager.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DragManager>.NativeClassPtr, 100675464);
			DragManager.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DragManager>.NativeClassPtr, 100675465);
			DragManager.NativeMethodInfoPtr_RpcWriter___Server_SendDragger_807933219_Private_Void_String_NetworkObject_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DragManager>.NativeClassPtr, 100675466);
			DragManager.NativeMethodInfoPtr_RpcLogic___SendDragger_807933219_Private_Void_String_NetworkObject_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DragManager>.NativeClassPtr, 100675467);
			DragManager.NativeMethodInfoPtr_RpcReader___Server_SendDragger_807933219_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DragManager>.NativeClassPtr, 100675468);
			DragManager.NativeMethodInfoPtr_RpcWriter___Observers_SetDragger_807933219_Private_Void_String_NetworkObject_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DragManager>.NativeClassPtr, 100675469);
			DragManager.NativeMethodInfoPtr_RpcLogic___SetDragger_807933219_Private_Void_String_NetworkObject_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DragManager>.NativeClassPtr, 100675470);
			DragManager.NativeMethodInfoPtr_RpcReader___Observers_SetDragger_807933219_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DragManager>.NativeClassPtr, 100675471);
			DragManager.NativeMethodInfoPtr_RpcWriter___Server_SendDraggableTransformData_4062762274_Private_Void_String_Vector3_Quaternion_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DragManager>.NativeClassPtr, 100675472);
			DragManager.NativeMethodInfoPtr_RpcLogic___SendDraggableTransformData_4062762274_Private_Void_String_Vector3_Quaternion_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DragManager>.NativeClassPtr, 100675473);
			DragManager.NativeMethodInfoPtr_RpcReader___Server_SendDraggableTransformData_4062762274_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DragManager>.NativeClassPtr, 100675474);
			DragManager.NativeMethodInfoPtr_RpcWriter___Observers_SetDraggableTransformData_3831223955_Private_Void_NetworkConnection_String_Vector3_Quaternion_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DragManager>.NativeClassPtr, 100675475);
			DragManager.NativeMethodInfoPtr_RpcLogic___SetDraggableTransformData_3831223955_Private_Void_NetworkConnection_String_Vector3_Quaternion_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DragManager>.NativeClassPtr, 100675476);
			DragManager.NativeMethodInfoPtr_RpcReader___Observers_SetDraggableTransformData_3831223955_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DragManager>.NativeClassPtr, 100675477);
			DragManager.NativeMethodInfoPtr_RpcWriter___Target_SetDraggableTransformData_3831223955_Private_Void_NetworkConnection_String_Vector3_Quaternion_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DragManager>.NativeClassPtr, 100675478);
			DragManager.NativeMethodInfoPtr_RpcReader___Target_SetDraggableTransformData_3831223955_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DragManager>.NativeClassPtr, 100675479);
			DragManager.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DragManager>.NativeClassPtr, 100675480);
		}

		// Token: 0x17001C5A RID: 7258
		// (get) Token: 0x06005E9E RID: 24222 RVA: 0x001B72E4 File Offset: 0x001B54E4
		// (set) Token: 0x06005E9F RID: 24223 RVA: 0x001B7324 File Offset: 0x001B5524
		public unsafe Draggable CurrentDraggable
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DragManager.NativeMethodInfoPtr_get_CurrentDraggable_Public_get_Draggable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Draggable>(intPtr2) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DragManager.NativeMethodInfoPtr_set_CurrentDraggable_Protected_set_Void_Draggable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x17001C5B RID: 7259
		// (get) Token: 0x06005EA0 RID: 24224 RVA: 0x001B7368 File Offset: 0x001B5568
		public unsafe bool IsDragging
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 199544, RefRangeEnd = 199546, XrefRangeStart = 199540, XrefRangeEnd = 199544, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr obj = IL2CPP.il2cpp_runtime_invoke(DragManager.NativeMethodInfoPtr_get_IsDragging_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
		}

		// Token: 0x06005EA1 RID: 24225 RVA: 0x001B73A4 File Offset: 0x001B55A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 199546, XrefRangeEnd = 199574, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnSpawnServer(NetworkConnection connection)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(connection);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DragManager.NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005EA2 RID: 24226 RVA: 0x001B73F4 File Offset: 0x001B55F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 199574, XrefRangeEnd = 199654, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DragManager.NativeMethodInfoPtr_Update_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005EA3 RID: 24227 RVA: 0x001B7428 File Offset: 0x001B5628
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 199654, XrefRangeEnd = 199668, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FixedUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DragManager.NativeMethodInfoPtr_FixedUpdate_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005EA4 RID: 24228 RVA: 0x001B745C File Offset: 0x001B565C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 199696, RefRangeEnd = 199698, XrefRangeStart = 199668, XrefRangeEnd = 199696, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsDraggingAllowed()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(DragManager.NativeMethodInfoPtr_IsDraggingAllowed_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06005EA5 RID: 24229 RVA: 0x001B7498 File Offset: 0x001B5698
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 199698, XrefRangeEnd = 199704, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RegisterDraggable(Draggable draggable)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(draggable);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DragManager.NativeMethodInfoPtr_RegisterDraggable_Public_Void_Draggable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005EA6 RID: 24230 RVA: 0x001B74DC File Offset: 0x001B56DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 199704, XrefRangeEnd = 199710, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Deregister(Draggable draggable)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(draggable);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DragManager.NativeMethodInfoPtr_Deregister_Public_Void_Draggable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005EA7 RID: 24231 RVA: 0x001B7520 File Offset: 0x001B5720
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 199710, XrefRangeEnd = 199727, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StartDragging(Draggable draggable)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(draggable);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DragManager.NativeMethodInfoPtr_StartDragging_Public_Void_Draggable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005EA8 RID: 24232 RVA: 0x001B7564 File Offset: 0x001B5764
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 199741, RefRangeEnd = 199744, XrefRangeStart = 199727, XrefRangeEnd = 199741, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendDragger(string draggableGUID, NetworkObject dragger, Vector3 position)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(draggableGUID);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(dragger);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref position;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DragManager.NativeMethodInfoPtr_SendDragger_Private_Void_String_NetworkObject_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005EA9 RID: 24233 RVA: 0x001B75C8 File Offset: 0x001B57C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 199744, XrefRangeEnd = 199758, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetDragger(string draggableGUID, NetworkObject dragger, Vector3 position)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(draggableGUID);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(dragger);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref position;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DragManager.NativeMethodInfoPtr_SetDragger_Private_Void_String_NetworkObject_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005EAA RID: 24234 RVA: 0x001B762C File Offset: 0x001B582C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 199776, RefRangeEnd = 199778, XrefRangeStart = 199758, XrefRangeEnd = 199776, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StopDragging(Vector3 velocity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref velocity;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DragManager.NativeMethodInfoPtr_StopDragging_Public_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005EAB RID: 24235 RVA: 0x001B766C File Offset: 0x001B586C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 199778, XrefRangeEnd = 199781, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendDraggableTransformData(string guid, Vector3 position, Quaternion rotation, Vector3 velocity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(guid);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref position;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rotation;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref velocity;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DragManager.NativeMethodInfoPtr_SendDraggableTransformData_Private_Void_String_Vector3_Quaternion_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005EAC RID: 24236 RVA: 0x001B76D8 File Offset: 0x001B58D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 199781, XrefRangeEnd = 199782, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetDraggableTransformData(NetworkConnection conn, string guid, Vector3 position, Quaternion rotation, Vector3 velocity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(guid);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref position;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rotation;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref velocity;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DragManager.NativeMethodInfoPtr_SetDraggableTransformData_Private_Void_NetworkConnection_String_Vector3_Quaternion_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005EAD RID: 24237 RVA: 0x001B7758 File Offset: 0x001B5958
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 199793, RefRangeEnd = 199795, XrefRangeStart = 199782, XrefRangeEnd = 199793, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector3 GetTargetPosition()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(DragManager.NativeMethodInfoPtr_GetTargetPosition_Private_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06005EAE RID: 24238 RVA: 0x001B7794 File Offset: 0x001B5994
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 199795, XrefRangeEnd = 199805, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DragManager() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DragManager>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DragManager.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005EAF RID: 24239 RVA: 0x001B77D0 File Offset: 0x001B59D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 199805, XrefRangeEnd = 199840, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize___Early()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DragManager.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005EB0 RID: 24240 RVA: 0x001B780C File Offset: 0x001B5A0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 199840, XrefRangeEnd = 199843, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize__Late()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DragManager.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005EB1 RID: 24241 RVA: 0x001B7848 File Offset: 0x001B5A48
		[CallerCount(0)]
		public unsafe override void NetworkInitializeIfDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DragManager.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005EB2 RID: 24242 RVA: 0x001B7884 File Offset: 0x001B5A84
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 199741, RefRangeEnd = 199744, XrefRangeStart = 199741, XrefRangeEnd = 199744, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_SendDragger_807933219(string draggableGUID, NetworkObject dragger, Vector3 position)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(draggableGUID);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(dragger);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref position;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DragManager.NativeMethodInfoPtr_RpcWriter___Server_SendDragger_807933219_Private_Void_String_NetworkObject_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005EB3 RID: 24243 RVA: 0x001B78E8 File Offset: 0x001B5AE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SendDragger_807933219(string draggableGUID, NetworkObject dragger, Vector3 position)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(draggableGUID);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(dragger);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref position;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DragManager.NativeMethodInfoPtr_RpcLogic___SendDragger_807933219_Private_Void_String_NetworkObject_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005EB4 RID: 24244 RVA: 0x001B794C File Offset: 0x001B5B4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 199843, XrefRangeEnd = 199863, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_SendDragger_807933219(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DragManager.NativeMethodInfoPtr_RpcReader___Server_SendDragger_807933219_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005EB5 RID: 24245 RVA: 0x001B79B0 File Offset: 0x001B5BB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_SetDragger_807933219(string draggableGUID, NetworkObject dragger, Vector3 position)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(draggableGUID);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(dragger);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref position;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DragManager.NativeMethodInfoPtr_RpcWriter___Observers_SetDragger_807933219_Private_Void_String_NetworkObject_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005EB6 RID: 24246 RVA: 0x001B7A14 File Offset: 0x001B5C14
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 199892, RefRangeEnd = 199893, XrefRangeStart = 199863, XrefRangeEnd = 199892, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SetDragger_807933219(string draggableGUID, NetworkObject dragger, Vector3 position)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(draggableGUID);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(dragger);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref position;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DragManager.NativeMethodInfoPtr_RpcLogic___SetDragger_807933219_Private_Void_String_NetworkObject_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005EB7 RID: 24247 RVA: 0x001B7A78 File Offset: 0x001B5C78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 199893, XrefRangeEnd = 199900, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_SetDragger_807933219(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DragManager.NativeMethodInfoPtr_RpcReader___Observers_SetDragger_807933219_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005EB8 RID: 24248 RVA: 0x001B7AC8 File Offset: 0x001B5CC8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 199928, RefRangeEnd = 199930, XrefRangeStart = 199900, XrefRangeEnd = 199928, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_SendDraggableTransformData_4062762274(string guid, Vector3 position, Quaternion rotation, Vector3 velocity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(guid);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref position;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rotation;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref velocity;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DragManager.NativeMethodInfoPtr_RpcWriter___Server_SendDraggableTransformData_4062762274_Private_Void_String_Vector3_Quaternion_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005EB9 RID: 24249 RVA: 0x001B7B34 File Offset: 0x001B5D34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 199930, XrefRangeEnd = 199932, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SendDraggableTransformData_4062762274(string guid, Vector3 position, Quaternion rotation, Vector3 velocity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(guid);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref position;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rotation;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref velocity;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DragManager.NativeMethodInfoPtr_RpcLogic___SendDraggableTransformData_4062762274_Private_Void_String_Vector3_Quaternion_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005EBA RID: 24250 RVA: 0x001B7BA0 File Offset: 0x001B5DA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 199932, XrefRangeEnd = 199945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_SendDraggableTransformData_4062762274(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DragManager.NativeMethodInfoPtr_RpcReader___Server_SendDraggableTransformData_4062762274_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005EBB RID: 24251 RVA: 0x001B7C04 File Offset: 0x001B5E04
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 199973, RefRangeEnd = 199978, XrefRangeStart = 199945, XrefRangeEnd = 199973, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_SetDraggableTransformData_3831223955(NetworkConnection conn, string guid, Vector3 position, Quaternion rotation, Vector3 velocity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(guid);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref position;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rotation;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref velocity;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DragManager.NativeMethodInfoPtr_RpcWriter___Observers_SetDraggableTransformData_3831223955_Private_Void_NetworkConnection_String_Vector3_Quaternion_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005EBC RID: 24252 RVA: 0x001B7C84 File Offset: 0x001B5E84
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 200008, RefRangeEnd = 200015, XrefRangeStart = 199978, XrefRangeEnd = 200008, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SetDraggableTransformData_3831223955(NetworkConnection conn, string guid, Vector3 position, Quaternion rotation, Vector3 velocity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(guid);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref position;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rotation;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref velocity;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DragManager.NativeMethodInfoPtr_RpcLogic___SetDraggableTransformData_3831223955_Private_Void_NetworkConnection_String_Vector3_Quaternion_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005EBD RID: 24253 RVA: 0x001B7D04 File Offset: 0x001B5F04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200015, XrefRangeEnd = 200027, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_SetDraggableTransformData_3831223955(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DragManager.NativeMethodInfoPtr_RpcReader___Observers_SetDraggableTransformData_3831223955_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005EBE RID: 24254 RVA: 0x001B7D54 File Offset: 0x001B5F54
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 200055, RefRangeEnd = 200057, XrefRangeStart = 200027, XrefRangeEnd = 200055, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Target_SetDraggableTransformData_3831223955(NetworkConnection conn, string guid, Vector3 position, Quaternion rotation, Vector3 velocity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(guid);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref position;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rotation;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref velocity;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DragManager.NativeMethodInfoPtr_RpcWriter___Target_SetDraggableTransformData_3831223955_Private_Void_NetworkConnection_String_Vector3_Quaternion_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005EBF RID: 24255 RVA: 0x001B7DD4 File Offset: 0x001B5FD4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200057, XrefRangeEnd = 200069, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Target_SetDraggableTransformData_3831223955(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DragManager.NativeMethodInfoPtr_RpcReader___Target_SetDraggableTransformData_3831223955_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005EC0 RID: 24256 RVA: 0x001B7E24 File Offset: 0x001B6024
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200069, XrefRangeEnd = 200072, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DragManager.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005EC1 RID: 24257 RVA: 0x0002C658 File Offset: 0x0002A858
		public DragManager(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001C4C RID: 7244
		// (get) Token: 0x06005EC2 RID: 24258 RVA: 0x001B7E60 File Offset: 0x001B6060
		// (set) Token: 0x06005EC3 RID: 24259 RVA: 0x0002C661 File Offset: 0x0002A861
		public unsafe static float DRAGGABLE_OFFSET
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(DragManager.NativeFieldInfoPtr_DRAGGABLE_OFFSET, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DragManager.NativeFieldInfoPtr_DRAGGABLE_OFFSET, (void*)(&value));
			}
		}

		// Token: 0x17001C4D RID: 7245
		// (get) Token: 0x06005EC4 RID: 24260 RVA: 0x001B7E7C File Offset: 0x001B607C
		// (set) Token: 0x06005EC5 RID: 24261 RVA: 0x0002C66F File Offset: 0x0002A86F
		public unsafe AudioSourceController ThrowSound
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DragManager.NativeFieldInfoPtr_ThrowSound);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DragManager.NativeFieldInfoPtr_ThrowSound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001C4E RID: 7246
		// (get) Token: 0x06005EC6 RID: 24262 RVA: 0x001B7EAC File Offset: 0x001B60AC
		// (set) Token: 0x06005EC7 RID: 24263 RVA: 0x0002C68E File Offset: 0x0002A88E
		public unsafe float DragForce
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DragManager.NativeFieldInfoPtr_DragForce);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DragManager.NativeFieldInfoPtr_DragForce)) = value;
			}
		}

		// Token: 0x17001C4F RID: 7247
		// (get) Token: 0x06005EC8 RID: 24264 RVA: 0x001B7ED4 File Offset: 0x001B60D4
		// (set) Token: 0x06005EC9 RID: 24265 RVA: 0x0002C6A9 File Offset: 0x0002A8A9
		public unsafe float DampingFactor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DragManager.NativeFieldInfoPtr_DampingFactor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DragManager.NativeFieldInfoPtr_DampingFactor)) = value;
			}
		}

		// Token: 0x17001C50 RID: 7248
		// (get) Token: 0x06005ECA RID: 24266 RVA: 0x001B7EFC File Offset: 0x001B60FC
		// (set) Token: 0x06005ECB RID: 24267 RVA: 0x0002C6C4 File Offset: 0x0002A8C4
		public unsafe float TorqueForce
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DragManager.NativeFieldInfoPtr_TorqueForce);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DragManager.NativeFieldInfoPtr_TorqueForce)) = value;
			}
		}

		// Token: 0x17001C51 RID: 7249
		// (get) Token: 0x06005ECC RID: 24268 RVA: 0x001B7F24 File Offset: 0x001B6124
		// (set) Token: 0x06005ECD RID: 24269 RVA: 0x0002C6DF File Offset: 0x0002A8DF
		public unsafe float TorqueDampingFactor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DragManager.NativeFieldInfoPtr_TorqueDampingFactor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DragManager.NativeFieldInfoPtr_TorqueDampingFactor)) = value;
			}
		}

		// Token: 0x17001C52 RID: 7250
		// (get) Token: 0x06005ECE RID: 24270 RVA: 0x001B7F4C File Offset: 0x001B614C
		// (set) Token: 0x06005ECF RID: 24271 RVA: 0x0002C6FA File Offset: 0x0002A8FA
		public unsafe float ThrowForce
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DragManager.NativeFieldInfoPtr_ThrowForce);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DragManager.NativeFieldInfoPtr_ThrowForce)) = value;
			}
		}

		// Token: 0x17001C53 RID: 7251
		// (get) Token: 0x06005ED0 RID: 24272 RVA: 0x001B7F74 File Offset: 0x001B6174
		// (set) Token: 0x06005ED1 RID: 24273 RVA: 0x0002C715 File Offset: 0x0002A915
		public unsafe float MassInfluence
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DragManager.NativeFieldInfoPtr_MassInfluence);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DragManager.NativeFieldInfoPtr_MassInfluence)) = value;
			}
		}

		// Token: 0x17001C54 RID: 7252
		// (get) Token: 0x06005ED2 RID: 24274 RVA: 0x001B7F9C File Offset: 0x001B619C
		// (set) Token: 0x06005ED3 RID: 24275 RVA: 0x0002C730 File Offset: 0x0002A930
		public unsafe Draggable _CurrentDraggable_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DragManager.NativeFieldInfoPtr__CurrentDraggable_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Draggable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DragManager.NativeFieldInfoPtr__CurrentDraggable_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001C55 RID: 7253
		// (get) Token: 0x06005ED4 RID: 24276 RVA: 0x001B7FCC File Offset: 0x001B61CC
		// (set) Token: 0x06005ED5 RID: 24277 RVA: 0x0002C74F File Offset: 0x0002A94F
		public unsafe List<Draggable> AllDraggables
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DragManager.NativeFieldInfoPtr_AllDraggables);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Draggable>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DragManager.NativeFieldInfoPtr_AllDraggables), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001C56 RID: 7254
		// (get) Token: 0x06005ED6 RID: 24278 RVA: 0x001B7FFC File Offset: 0x001B61FC
		// (set) Token: 0x06005ED7 RID: 24279 RVA: 0x0002C76E File Offset: 0x0002A96E
		public unsafe Draggable lastThrownDraggable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DragManager.NativeFieldInfoPtr_lastThrownDraggable);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Draggable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DragManager.NativeFieldInfoPtr_lastThrownDraggable), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001C57 RID: 7255
		// (get) Token: 0x06005ED8 RID: 24280 RVA: 0x001B802C File Offset: 0x001B622C
		// (set) Token: 0x06005ED9 RID: 24281 RVA: 0x0002C78D File Offset: 0x0002A98D
		public unsafe Draggable lastHeldDraggable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DragManager.NativeFieldInfoPtr_lastHeldDraggable);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Draggable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DragManager.NativeFieldInfoPtr_lastHeldDraggable), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001C58 RID: 7256
		// (get) Token: 0x06005EDA RID: 24282 RVA: 0x001B805C File Offset: 0x001B625C
		// (set) Token: 0x06005EDB RID: 24283 RVA: 0x0002C7AC File Offset: 0x0002A9AC
		public new unsafe bool field_Private_Boolean_0
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DragManager.NativeFieldInfoPtr_field_Private_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DragManager.NativeFieldInfoPtr_field_Private_Boolean_0)) = value;
			}
		}

		// Token: 0x17001C59 RID: 7257
		// (get) Token: 0x06005EDC RID: 24284 RVA: 0x001B8084 File Offset: 0x001B6284
		// (set) Token: 0x06005EDD RID: 24285 RVA: 0x0002C7C7 File Offset: 0x0002A9C7
		public new unsafe bool field_Private_Boolean_1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DragManager.NativeFieldInfoPtr_field_Private_Boolean_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DragManager.NativeFieldInfoPtr_field_Private_Boolean_1)) = value;
			}
		}

		// Token: 0x040040B8 RID: 16568
		private static readonly IntPtr NativeFieldInfoPtr_DRAGGABLE_OFFSET;

		// Token: 0x040040B9 RID: 16569
		private static readonly IntPtr NativeFieldInfoPtr_ThrowSound;

		// Token: 0x040040BA RID: 16570
		private static readonly IntPtr NativeFieldInfoPtr_DragForce;

		// Token: 0x040040BB RID: 16571
		private static readonly IntPtr NativeFieldInfoPtr_DampingFactor;

		// Token: 0x040040BC RID: 16572
		private static readonly IntPtr NativeFieldInfoPtr_TorqueForce;

		// Token: 0x040040BD RID: 16573
		private static readonly IntPtr NativeFieldInfoPtr_TorqueDampingFactor;

		// Token: 0x040040BE RID: 16574
		private static readonly IntPtr NativeFieldInfoPtr_ThrowForce;

		// Token: 0x040040BF RID: 16575
		private static readonly IntPtr NativeFieldInfoPtr_MassInfluence;

		// Token: 0x040040C0 RID: 16576
		private static readonly IntPtr NativeFieldInfoPtr__CurrentDraggable_k__BackingField;

		// Token: 0x040040C1 RID: 16577
		private static readonly IntPtr NativeFieldInfoPtr_AllDraggables;

		// Token: 0x040040C2 RID: 16578
		private static readonly IntPtr NativeFieldInfoPtr_lastThrownDraggable;

		// Token: 0x040040C3 RID: 16579
		private static readonly IntPtr NativeFieldInfoPtr_lastHeldDraggable;

		// Token: 0x040040C4 RID: 16580
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

		// Token: 0x040040C5 RID: 16581
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

		// Token: 0x040040C6 RID: 16582
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentDraggable_Public_get_Draggable_0;

		// Token: 0x040040C7 RID: 16583
		private static readonly IntPtr NativeMethodInfoPtr_set_CurrentDraggable_Protected_set_Void_Draggable_0;

		// Token: 0x040040C8 RID: 16584
		private static readonly IntPtr NativeMethodInfoPtr_get_IsDragging_Public_get_Boolean_0;

		// Token: 0x040040C9 RID: 16585
		private static readonly IntPtr NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0;

		// Token: 0x040040CA RID: 16586
		private static readonly IntPtr NativeMethodInfoPtr_Update_Public_Void_0;

		// Token: 0x040040CB RID: 16587
		private static readonly IntPtr NativeMethodInfoPtr_FixedUpdate_Public_Void_0;

		// Token: 0x040040CC RID: 16588
		private static readonly IntPtr NativeMethodInfoPtr_IsDraggingAllowed_Public_Boolean_0;

		// Token: 0x040040CD RID: 16589
		private static readonly IntPtr NativeMethodInfoPtr_RegisterDraggable_Public_Void_Draggable_0;

		// Token: 0x040040CE RID: 16590
		private static readonly IntPtr NativeMethodInfoPtr_Deregister_Public_Void_Draggable_0;

		// Token: 0x040040CF RID: 16591
		private static readonly IntPtr NativeMethodInfoPtr_StartDragging_Public_Void_Draggable_0;

		// Token: 0x040040D0 RID: 16592
		private static readonly IntPtr NativeMethodInfoPtr_SendDragger_Private_Void_String_NetworkObject_Vector3_0;

		// Token: 0x040040D1 RID: 16593
		private static readonly IntPtr NativeMethodInfoPtr_SetDragger_Private_Void_String_NetworkObject_Vector3_0;

		// Token: 0x040040D2 RID: 16594
		private static readonly IntPtr NativeMethodInfoPtr_StopDragging_Public_Void_Vector3_0;

		// Token: 0x040040D3 RID: 16595
		private static readonly IntPtr NativeMethodInfoPtr_SendDraggableTransformData_Private_Void_String_Vector3_Quaternion_Vector3_0;

		// Token: 0x040040D4 RID: 16596
		private static readonly IntPtr NativeMethodInfoPtr_SetDraggableTransformData_Private_Void_NetworkConnection_String_Vector3_Quaternion_Vector3_0;

		// Token: 0x040040D5 RID: 16597
		private static readonly IntPtr NativeMethodInfoPtr_GetTargetPosition_Private_Vector3_0;

		// Token: 0x040040D6 RID: 16598
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040040D7 RID: 16599
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

		// Token: 0x040040D8 RID: 16600
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

		// Token: 0x040040D9 RID: 16601
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

		// Token: 0x040040DA RID: 16602
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_SendDragger_807933219_Private_Void_String_NetworkObject_Vector3_0;

		// Token: 0x040040DB RID: 16603
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SendDragger_807933219_Private_Void_String_NetworkObject_Vector3_0;

		// Token: 0x040040DC RID: 16604
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_SendDragger_807933219_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x040040DD RID: 16605
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_SetDragger_807933219_Private_Void_String_NetworkObject_Vector3_0;

		// Token: 0x040040DE RID: 16606
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SetDragger_807933219_Private_Void_String_NetworkObject_Vector3_0;

		// Token: 0x040040DF RID: 16607
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_SetDragger_807933219_Private_Void_PooledReader_Channel_0;

		// Token: 0x040040E0 RID: 16608
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_SendDraggableTransformData_4062762274_Private_Void_String_Vector3_Quaternion_Vector3_0;

		// Token: 0x040040E1 RID: 16609
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SendDraggableTransformData_4062762274_Private_Void_String_Vector3_Quaternion_Vector3_0;

		// Token: 0x040040E2 RID: 16610
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_SendDraggableTransformData_4062762274_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x040040E3 RID: 16611
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_SetDraggableTransformData_3831223955_Private_Void_NetworkConnection_String_Vector3_Quaternion_Vector3_0;

		// Token: 0x040040E4 RID: 16612
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SetDraggableTransformData_3831223955_Private_Void_NetworkConnection_String_Vector3_Quaternion_Vector3_0;

		// Token: 0x040040E5 RID: 16613
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_SetDraggableTransformData_3831223955_Private_Void_PooledReader_Channel_0;

		// Token: 0x040040E6 RID: 16614
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Target_SetDraggableTransformData_3831223955_Private_Void_NetworkConnection_String_Vector3_Quaternion_Vector3_0;

		// Token: 0x040040E7 RID: 16615
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Target_SetDraggableTransformData_3831223955_Private_Void_PooledReader_Channel_0;

		// Token: 0x040040E8 RID: 16616
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;
	}
}
