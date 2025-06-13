using System;
using Il2CppFishNet.Connection;
using Il2CppFishNet.Object;
using Il2CppFishNet.Serializing;
using Il2CppFishNet.Transporting;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine.Events;

namespace Il2CppScheduleOne.Interaction
{
	// Token: 0x02000414 RID: 1044
	public class NetworkedInteractableToggleable : NetworkBehaviour
	{
		// Token: 0x0600557F RID: 21887 RVA: 0x001934E4 File Offset: 0x001916E4
		// Note: this type is marked as 'beforefieldinit'.
		static NetworkedInteractableToggleable()
		{
			Il2CppClassPointerStore<NetworkedInteractableToggleable>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Interaction", "NetworkedInteractableToggleable");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NetworkedInteractableToggleable>.NativeClassPtr);
			NetworkedInteractableToggleable.NativeFieldInfoPtr__IsActivated_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkedInteractableToggleable>.NativeClassPtr, "<IsActivated>k__BackingField");
			NetworkedInteractableToggleable.NativeFieldInfoPtr_ActivateMessage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkedInteractableToggleable>.NativeClassPtr, "ActivateMessage");
			NetworkedInteractableToggleable.NativeFieldInfoPtr_DeactivateMessage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkedInteractableToggleable>.NativeClassPtr, "DeactivateMessage");
			NetworkedInteractableToggleable.NativeFieldInfoPtr_CoolDown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkedInteractableToggleable>.NativeClassPtr, "CoolDown");
			NetworkedInteractableToggleable.NativeFieldInfoPtr_IntObj = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkedInteractableToggleable>.NativeClassPtr, "IntObj");
			NetworkedInteractableToggleable.NativeFieldInfoPtr_onToggle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkedInteractableToggleable>.NativeClassPtr, "onToggle");
			NetworkedInteractableToggleable.NativeFieldInfoPtr_onActivate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkedInteractableToggleable>.NativeClassPtr, "onActivate");
			NetworkedInteractableToggleable.NativeFieldInfoPtr_onDeactivate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkedInteractableToggleable>.NativeClassPtr, "onDeactivate");
			NetworkedInteractableToggleable.NativeFieldInfoPtr_lastActivated = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkedInteractableToggleable>.NativeClassPtr, "lastActivated");
			NetworkedInteractableToggleable.NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkedInteractableToggleable>.NativeClassPtr, "NetworkInitialize___EarlyScheduleOne.Interaction.NetworkedInteractableToggleableAssembly-CSharp.dll_Excuted");
			NetworkedInteractableToggleable.NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkedInteractableToggleable>.NativeClassPtr, "NetworkInitialize__LateScheduleOne.Interaction.NetworkedInteractableToggleableAssembly-CSharp.dll_Excuted");
			NetworkedInteractableToggleable.NativeMethodInfoPtr_get_IsActivated_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkedInteractableToggleable>.NativeClassPtr, 100674043);
			NetworkedInteractableToggleable.NativeMethodInfoPtr_set_IsActivated_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkedInteractableToggleable>.NativeClassPtr, 100674044);
			NetworkedInteractableToggleable.NativeMethodInfoPtr_Start_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkedInteractableToggleable>.NativeClassPtr, 100674045);
			NetworkedInteractableToggleable.NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkedInteractableToggleable>.NativeClassPtr, 100674046);
			NetworkedInteractableToggleable.NativeMethodInfoPtr_Hovered_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkedInteractableToggleable>.NativeClassPtr, 100674047);
			NetworkedInteractableToggleable.NativeMethodInfoPtr_Interacted_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkedInteractableToggleable>.NativeClassPtr, 100674048);
			NetworkedInteractableToggleable.NativeMethodInfoPtr_SendToggle_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkedInteractableToggleable>.NativeClassPtr, 100674049);
			NetworkedInteractableToggleable.NativeMethodInfoPtr_SetState_Public_Void_NetworkConnection_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkedInteractableToggleable>.NativeClassPtr, 100674050);
			NetworkedInteractableToggleable.NativeMethodInfoPtr_PoliceDetected_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkedInteractableToggleable>.NativeClassPtr, 100674051);
			NetworkedInteractableToggleable.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkedInteractableToggleable>.NativeClassPtr, 100674052);
			NetworkedInteractableToggleable.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkedInteractableToggleable>.NativeClassPtr, 100674053);
			NetworkedInteractableToggleable.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkedInteractableToggleable>.NativeClassPtr, 100674054);
			NetworkedInteractableToggleable.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkedInteractableToggleable>.NativeClassPtr, 100674055);
			NetworkedInteractableToggleable.NativeMethodInfoPtr_RpcWriter___Server_SendToggle_2166136261_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkedInteractableToggleable>.NativeClassPtr, 100674056);
			NetworkedInteractableToggleable.NativeMethodInfoPtr_RpcLogic___SendToggle_2166136261_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkedInteractableToggleable>.NativeClassPtr, 100674057);
			NetworkedInteractableToggleable.NativeMethodInfoPtr_RpcReader___Server_SendToggle_2166136261_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkedInteractableToggleable>.NativeClassPtr, 100674058);
			NetworkedInteractableToggleable.NativeMethodInfoPtr_RpcWriter___Observers_SetState_214505783_Private_Void_NetworkConnection_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkedInteractableToggleable>.NativeClassPtr, 100674059);
			NetworkedInteractableToggleable.NativeMethodInfoPtr_RpcLogic___SetState_214505783_Public_Void_NetworkConnection_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkedInteractableToggleable>.NativeClassPtr, 100674060);
			NetworkedInteractableToggleable.NativeMethodInfoPtr_RpcReader___Observers_SetState_214505783_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkedInteractableToggleable>.NativeClassPtr, 100674061);
			NetworkedInteractableToggleable.NativeMethodInfoPtr_RpcWriter___Target_SetState_214505783_Private_Void_NetworkConnection_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkedInteractableToggleable>.NativeClassPtr, 100674062);
			NetworkedInteractableToggleable.NativeMethodInfoPtr_RpcReader___Target_SetState_214505783_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkedInteractableToggleable>.NativeClassPtr, 100674063);
			NetworkedInteractableToggleable.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkedInteractableToggleable>.NativeClassPtr, 100674064);
		}

		// Token: 0x170019B8 RID: 6584
		// (get) Token: 0x06005580 RID: 21888 RVA: 0x001937A8 File Offset: 0x001919A8
		// (set) Token: 0x06005581 RID: 21889 RVA: 0x001937E4 File Offset: 0x001919E4
		public unsafe bool IsActivated
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NetworkedInteractableToggleable.NativeMethodInfoPtr_get_IsActivated_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NetworkedInteractableToggleable.NativeMethodInfoPtr_set_IsActivated_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x06005582 RID: 21890 RVA: 0x00193824 File Offset: 0x00191A24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 183834, XrefRangeEnd = 183848, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NetworkedInteractableToggleable.NativeMethodInfoPtr_Start_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005583 RID: 21891 RVA: 0x00193858 File Offset: 0x00191A58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 183848, XrefRangeEnd = 183850, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnSpawnServer(NetworkConnection connection)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(connection);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NetworkedInteractableToggleable.NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005584 RID: 21892 RVA: 0x001938A8 File Offset: 0x00191AA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 183850, XrefRangeEnd = 183852, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Hovered()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NetworkedInteractableToggleable.NativeMethodInfoPtr_Hovered_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005585 RID: 21893 RVA: 0x001938DC File Offset: 0x00191ADC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 183852, XrefRangeEnd = 183853, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Interacted()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NetworkedInteractableToggleable.NativeMethodInfoPtr_Interacted_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005586 RID: 21894 RVA: 0x00193910 File Offset: 0x00191B10
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 183874, RefRangeEnd = 183876, XrefRangeStart = 183853, XrefRangeEnd = 183874, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendToggle()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NetworkedInteractableToggleable.NativeMethodInfoPtr_SendToggle_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005587 RID: 21895 RVA: 0x00193944 File Offset: 0x00191B44
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 183918, RefRangeEnd = 183922, XrefRangeStart = 183876, XrefRangeEnd = 183918, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetState(NetworkConnection conn, bool activated)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref activated;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NetworkedInteractableToggleable.NativeMethodInfoPtr_SetState_Public_Void_NetworkConnection_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005588 RID: 21896 RVA: 0x00193994 File Offset: 0x00191B94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 183922, XrefRangeEnd = 183924, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PoliceDetected()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NetworkedInteractableToggleable.NativeMethodInfoPtr_PoliceDetected_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005589 RID: 21897 RVA: 0x001939C8 File Offset: 0x00191BC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 183924, XrefRangeEnd = 183946, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NetworkedInteractableToggleable() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NetworkedInteractableToggleable>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NetworkedInteractableToggleable.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600558A RID: 21898 RVA: 0x00193A04 File Offset: 0x00191C04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 183946, XrefRangeEnd = 183966, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void NetworkInitialize___Early()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NetworkedInteractableToggleable.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600558B RID: 21899 RVA: 0x00193A40 File Offset: 0x00191C40
		[CallerCount(26)]
		[CachedScanResults(RefRangeStart = 150118, RefRangeEnd = 150144, XrefRangeStart = 150118, XrefRangeEnd = 150144, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void NetworkInitialize__Late()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NetworkedInteractableToggleable.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600558C RID: 21900 RVA: 0x00193A7C File Offset: 0x00191C7C
		[CallerCount(0)]
		public unsafe override void NetworkInitializeIfDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NetworkedInteractableToggleable.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600558D RID: 21901 RVA: 0x00193AB8 File Offset: 0x00191CB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 183966, XrefRangeEnd = 183975, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_SendToggle_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NetworkedInteractableToggleable.NativeMethodInfoPtr_RpcWriter___Server_SendToggle_2166136261_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600558E RID: 21902 RVA: 0x00193AEC File Offset: 0x00191CEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 183975, XrefRangeEnd = 183976, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SendToggle_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NetworkedInteractableToggleable.NativeMethodInfoPtr_RpcLogic___SendToggle_2166136261_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600558F RID: 21903 RVA: 0x00193B20 File Offset: 0x00191D20
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 183976, XrefRangeEnd = 183979, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_SendToggle_2166136261(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NetworkedInteractableToggleable.NativeMethodInfoPtr_RpcReader___Server_SendToggle_2166136261_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005590 RID: 21904 RVA: 0x00193B84 File Offset: 0x00191D84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 183979, XrefRangeEnd = 183989, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_SetState_214505783(NetworkConnection conn, bool activated)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref activated;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NetworkedInteractableToggleable.NativeMethodInfoPtr_RpcWriter___Observers_SetState_214505783_Private_Void_NetworkConnection_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005591 RID: 21905 RVA: 0x00193BD4 File Offset: 0x00191DD4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 183992, RefRangeEnd = 183995, XrefRangeStart = 183989, XrefRangeEnd = 183992, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SetState_214505783(NetworkConnection conn, bool activated)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref activated;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NetworkedInteractableToggleable.NativeMethodInfoPtr_RpcLogic___SetState_214505783_Public_Void_NetworkConnection_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005592 RID: 21906 RVA: 0x00193C24 File Offset: 0x00191E24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 183995, XrefRangeEnd = 183998, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_SetState_214505783(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NetworkedInteractableToggleable.NativeMethodInfoPtr_RpcReader___Observers_SetState_214505783_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005593 RID: 21907 RVA: 0x00193C74 File Offset: 0x00191E74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 183998, XrefRangeEnd = 184008, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Target_SetState_214505783(NetworkConnection conn, bool activated)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref activated;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NetworkedInteractableToggleable.NativeMethodInfoPtr_RpcWriter___Target_SetState_214505783_Private_Void_NetworkConnection_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005594 RID: 21908 RVA: 0x00193CC4 File Offset: 0x00191EC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 184008, XrefRangeEnd = 184011, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Target_SetState_214505783(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NetworkedInteractableToggleable.NativeMethodInfoPtr_RpcReader___Target_SetState_214505783_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005595 RID: 21909 RVA: 0x00193D14 File Offset: 0x00191F14
		[CallerCount(0)]
		public unsafe virtual void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NetworkedInteractableToggleable.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005596 RID: 21910 RVA: 0x00028B24 File Offset: 0x00026D24
		public NetworkedInteractableToggleable(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170019AD RID: 6573
		// (get) Token: 0x06005597 RID: 21911 RVA: 0x00193D50 File Offset: 0x00191F50
		// (set) Token: 0x06005598 RID: 21912 RVA: 0x00028B2D File Offset: 0x00026D2D
		public unsafe bool _IsActivated_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NetworkedInteractableToggleable.NativeFieldInfoPtr__IsActivated_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NetworkedInteractableToggleable.NativeFieldInfoPtr__IsActivated_k__BackingField)) = value;
			}
		}

		// Token: 0x170019AE RID: 6574
		// (get) Token: 0x06005599 RID: 21913 RVA: 0x00193D78 File Offset: 0x00191F78
		// (set) Token: 0x0600559A RID: 21914 RVA: 0x00028B48 File Offset: 0x00026D48
		public unsafe string ActivateMessage
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NetworkedInteractableToggleable.NativeFieldInfoPtr_ActivateMessage);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NetworkedInteractableToggleable.NativeFieldInfoPtr_ActivateMessage), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170019AF RID: 6575
		// (get) Token: 0x0600559B RID: 21915 RVA: 0x00193DA0 File Offset: 0x00191FA0
		// (set) Token: 0x0600559C RID: 21916 RVA: 0x00028B67 File Offset: 0x00026D67
		public unsafe string DeactivateMessage
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NetworkedInteractableToggleable.NativeFieldInfoPtr_DeactivateMessage);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NetworkedInteractableToggleable.NativeFieldInfoPtr_DeactivateMessage), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170019B0 RID: 6576
		// (get) Token: 0x0600559D RID: 21917 RVA: 0x00193DC8 File Offset: 0x00191FC8
		// (set) Token: 0x0600559E RID: 21918 RVA: 0x00028B86 File Offset: 0x00026D86
		public unsafe float CoolDown
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NetworkedInteractableToggleable.NativeFieldInfoPtr_CoolDown);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NetworkedInteractableToggleable.NativeFieldInfoPtr_CoolDown)) = value;
			}
		}

		// Token: 0x170019B1 RID: 6577
		// (get) Token: 0x0600559F RID: 21919 RVA: 0x00193DF0 File Offset: 0x00191FF0
		// (set) Token: 0x060055A0 RID: 21920 RVA: 0x00028BA1 File Offset: 0x00026DA1
		public unsafe InteractableObject IntObj
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NetworkedInteractableToggleable.NativeFieldInfoPtr_IntObj);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<InteractableObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NetworkedInteractableToggleable.NativeFieldInfoPtr_IntObj), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170019B2 RID: 6578
		// (get) Token: 0x060055A1 RID: 21921 RVA: 0x00193E20 File Offset: 0x00192020
		// (set) Token: 0x060055A2 RID: 21922 RVA: 0x00028BC0 File Offset: 0x00026DC0
		public unsafe UnityEvent onToggle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NetworkedInteractableToggleable.NativeFieldInfoPtr_onToggle);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NetworkedInteractableToggleable.NativeFieldInfoPtr_onToggle), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170019B3 RID: 6579
		// (get) Token: 0x060055A3 RID: 21923 RVA: 0x00193E50 File Offset: 0x00192050
		// (set) Token: 0x060055A4 RID: 21924 RVA: 0x00028BDF File Offset: 0x00026DDF
		public unsafe UnityEvent onActivate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NetworkedInteractableToggleable.NativeFieldInfoPtr_onActivate);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NetworkedInteractableToggleable.NativeFieldInfoPtr_onActivate), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170019B4 RID: 6580
		// (get) Token: 0x060055A5 RID: 21925 RVA: 0x00193E80 File Offset: 0x00192080
		// (set) Token: 0x060055A6 RID: 21926 RVA: 0x00028BFE File Offset: 0x00026DFE
		public unsafe UnityEvent onDeactivate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NetworkedInteractableToggleable.NativeFieldInfoPtr_onDeactivate);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NetworkedInteractableToggleable.NativeFieldInfoPtr_onDeactivate), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170019B5 RID: 6581
		// (get) Token: 0x060055A7 RID: 21927 RVA: 0x00193EB0 File Offset: 0x001920B0
		// (set) Token: 0x060055A8 RID: 21928 RVA: 0x00028C1D File Offset: 0x00026E1D
		public unsafe float lastActivated
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NetworkedInteractableToggleable.NativeFieldInfoPtr_lastActivated);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NetworkedInteractableToggleable.NativeFieldInfoPtr_lastActivated)) = value;
			}
		}

		// Token: 0x170019B6 RID: 6582
		// (get) Token: 0x060055A9 RID: 21929 RVA: 0x00193ED8 File Offset: 0x001920D8
		// (set) Token: 0x060055AA RID: 21930 RVA: 0x00028C38 File Offset: 0x00026E38
		public unsafe bool field_Private_Boolean_0
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NetworkedInteractableToggleable.NativeFieldInfoPtr_field_Private_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NetworkedInteractableToggleable.NativeFieldInfoPtr_field_Private_Boolean_0)) = value;
			}
		}

		// Token: 0x170019B7 RID: 6583
		// (get) Token: 0x060055AB RID: 21931 RVA: 0x00193F00 File Offset: 0x00192100
		// (set) Token: 0x060055AC RID: 21932 RVA: 0x00028C53 File Offset: 0x00026E53
		public unsafe bool field_Private_Boolean_1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NetworkedInteractableToggleable.NativeFieldInfoPtr_field_Private_Boolean_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NetworkedInteractableToggleable.NativeFieldInfoPtr_field_Private_Boolean_1)) = value;
			}
		}

		// Token: 0x040039EA RID: 14826
		private static readonly IntPtr NativeFieldInfoPtr__IsActivated_k__BackingField;

		// Token: 0x040039EB RID: 14827
		private static readonly IntPtr NativeFieldInfoPtr_ActivateMessage;

		// Token: 0x040039EC RID: 14828
		private static readonly IntPtr NativeFieldInfoPtr_DeactivateMessage;

		// Token: 0x040039ED RID: 14829
		private static readonly IntPtr NativeFieldInfoPtr_CoolDown;

		// Token: 0x040039EE RID: 14830
		private static readonly IntPtr NativeFieldInfoPtr_IntObj;

		// Token: 0x040039EF RID: 14831
		private static readonly IntPtr NativeFieldInfoPtr_onToggle;

		// Token: 0x040039F0 RID: 14832
		private static readonly IntPtr NativeFieldInfoPtr_onActivate;

		// Token: 0x040039F1 RID: 14833
		private static readonly IntPtr NativeFieldInfoPtr_onDeactivate;

		// Token: 0x040039F2 RID: 14834
		private static readonly IntPtr NativeFieldInfoPtr_lastActivated;

		// Token: 0x040039F3 RID: 14835
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

		// Token: 0x040039F4 RID: 14836
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

		// Token: 0x040039F5 RID: 14837
		private static readonly IntPtr NativeMethodInfoPtr_get_IsActivated_Public_get_Boolean_0;

		// Token: 0x040039F6 RID: 14838
		private static readonly IntPtr NativeMethodInfoPtr_set_IsActivated_Private_set_Void_Boolean_0;

		// Token: 0x040039F7 RID: 14839
		private static readonly IntPtr NativeMethodInfoPtr_Start_Public_Void_0;

		// Token: 0x040039F8 RID: 14840
		private static readonly IntPtr NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0;

		// Token: 0x040039F9 RID: 14841
		private static readonly IntPtr NativeMethodInfoPtr_Hovered_Public_Void_0;

		// Token: 0x040039FA RID: 14842
		private static readonly IntPtr NativeMethodInfoPtr_Interacted_Public_Void_0;

		// Token: 0x040039FB RID: 14843
		private static readonly IntPtr NativeMethodInfoPtr_SendToggle_Public_Void_0;

		// Token: 0x040039FC RID: 14844
		private static readonly IntPtr NativeMethodInfoPtr_SetState_Public_Void_NetworkConnection_Boolean_0;

		// Token: 0x040039FD RID: 14845
		private static readonly IntPtr NativeMethodInfoPtr_PoliceDetected_Public_Void_0;

		// Token: 0x040039FE RID: 14846
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040039FF RID: 14847
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

		// Token: 0x04003A00 RID: 14848
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

		// Token: 0x04003A01 RID: 14849
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

		// Token: 0x04003A02 RID: 14850
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_SendToggle_2166136261_Private_Void_0;

		// Token: 0x04003A03 RID: 14851
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SendToggle_2166136261_Public_Void_0;

		// Token: 0x04003A04 RID: 14852
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_SendToggle_2166136261_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x04003A05 RID: 14853
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_SetState_214505783_Private_Void_NetworkConnection_Boolean_0;

		// Token: 0x04003A06 RID: 14854
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SetState_214505783_Public_Void_NetworkConnection_Boolean_0;

		// Token: 0x04003A07 RID: 14855
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_SetState_214505783_Private_Void_PooledReader_Channel_0;

		// Token: 0x04003A08 RID: 14856
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Target_SetState_214505783_Private_Void_NetworkConnection_Boolean_0;

		// Token: 0x04003A09 RID: 14857
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Target_SetState_214505783_Private_Void_PooledReader_Channel_0;

		// Token: 0x04003A0A RID: 14858
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;
	}
}
