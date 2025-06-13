using System;
using Il2CppFishNet.Connection;
using Il2CppFishNet.Serializing;
using Il2CppFishNet.Transporting;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Audio;
using Il2CppScheduleOne.DevUtilities;
using Il2CppScheduleOne.ObjectScripts;
using UnityEngine.Events;

namespace Il2CppScheduleOne.Law
{
	// Token: 0x020003F6 RID: 1014
	public class CurfewManager : NetworkSingleton<CurfewManager>
	{
		// Token: 0x06004D18 RID: 19736 RVA: 0x00175804 File Offset: 0x00173A04
		// Note: this type is marked as 'beforefieldinit'.
		static CurfewManager()
		{
			Il2CppClassPointerStore<CurfewManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Law", "CurfewManager");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CurfewManager>.NativeClassPtr);
			CurfewManager.NativeFieldInfoPtr_WARNING_TIME = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CurfewManager>.NativeClassPtr, "WARNING_TIME");
			CurfewManager.NativeFieldInfoPtr_CURFEW_START_TIME = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CurfewManager>.NativeClassPtr, "CURFEW_START_TIME");
			CurfewManager.NativeFieldInfoPtr_CURFEW_END_TIME = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CurfewManager>.NativeClassPtr, "CURFEW_END_TIME");
			CurfewManager.NativeFieldInfoPtr__IsEnabled_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CurfewManager>.NativeClassPtr, "<IsEnabled>k__BackingField");
			CurfewManager.NativeFieldInfoPtr__IsCurrentlyActive_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CurfewManager>.NativeClassPtr, "<IsCurrentlyActive>k__BackingField");
			CurfewManager.NativeFieldInfoPtr_VMSBoards = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CurfewManager>.NativeClassPtr, "VMSBoards");
			CurfewManager.NativeFieldInfoPtr_CurfewWarningSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CurfewManager>.NativeClassPtr, "CurfewWarningSound");
			CurfewManager.NativeFieldInfoPtr_CurfewAlarmSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CurfewManager>.NativeClassPtr, "CurfewAlarmSound");
			CurfewManager.NativeFieldInfoPtr_onCurfewEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CurfewManager>.NativeClassPtr, "onCurfewEnabled");
			CurfewManager.NativeFieldInfoPtr_onCurfewDisabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CurfewManager>.NativeClassPtr, "onCurfewDisabled");
			CurfewManager.NativeFieldInfoPtr_onCurfewHint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CurfewManager>.NativeClassPtr, "onCurfewHint");
			CurfewManager.NativeFieldInfoPtr_onCurfewWarning = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CurfewManager>.NativeClassPtr, "onCurfewWarning");
			CurfewManager.NativeFieldInfoPtr_warningPlayed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CurfewManager>.NativeClassPtr, "warningPlayed");
			CurfewManager.NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CurfewManager>.NativeClassPtr, "NetworkInitialize___EarlyScheduleOne.Law.CurfewManagerAssembly-CSharp.dll_Excuted");
			CurfewManager.NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CurfewManager>.NativeClassPtr, "NetworkInitialize__LateScheduleOne.Law.CurfewManagerAssembly-CSharp.dll_Excuted");
			CurfewManager.NativeMethodInfoPtr_get_IsEnabled_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CurfewManager>.NativeClassPtr, 100672921);
			CurfewManager.NativeMethodInfoPtr_set_IsEnabled_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CurfewManager>.NativeClassPtr, 100672922);
			CurfewManager.NativeMethodInfoPtr_get_IsCurrentlyActive_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CurfewManager>.NativeClassPtr, 100672923);
			CurfewManager.NativeMethodInfoPtr_set_IsCurrentlyActive_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CurfewManager>.NativeClassPtr, 100672924);
			CurfewManager.NativeMethodInfoPtr_get_IsCurrentlyActiveWithTolerance_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CurfewManager>.NativeClassPtr, 100672925);
			CurfewManager.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CurfewManager>.NativeClassPtr, 100672926);
			CurfewManager.NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CurfewManager>.NativeClassPtr, 100672927);
			CurfewManager.NativeMethodInfoPtr_Enable_Public_Void_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CurfewManager>.NativeClassPtr, 100672928);
			CurfewManager.NativeMethodInfoPtr_Disable_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CurfewManager>.NativeClassPtr, 100672929);
			CurfewManager.NativeMethodInfoPtr_MinPass_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CurfewManager>.NativeClassPtr, 100672930);
			CurfewManager.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CurfewManager>.NativeClassPtr, 100672931);
			CurfewManager.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CurfewManager>.NativeClassPtr, 100672932);
			CurfewManager.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CurfewManager>.NativeClassPtr, 100672933);
			CurfewManager.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CurfewManager>.NativeClassPtr, 100672934);
			CurfewManager.NativeMethodInfoPtr_RpcWriter___Observers_Enable_328543758_Private_Void_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CurfewManager>.NativeClassPtr, 100672935);
			CurfewManager.NativeMethodInfoPtr_RpcLogic___Enable_328543758_Public_Void_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CurfewManager>.NativeClassPtr, 100672936);
			CurfewManager.NativeMethodInfoPtr_RpcReader___Observers_Enable_328543758_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CurfewManager>.NativeClassPtr, 100672937);
			CurfewManager.NativeMethodInfoPtr_RpcWriter___Target_Enable_328543758_Private_Void_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CurfewManager>.NativeClassPtr, 100672938);
			CurfewManager.NativeMethodInfoPtr_RpcReader___Target_Enable_328543758_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CurfewManager>.NativeClassPtr, 100672939);
			CurfewManager.NativeMethodInfoPtr_RpcWriter___Observers_Disable_2166136261_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CurfewManager>.NativeClassPtr, 100672940);
			CurfewManager.NativeMethodInfoPtr_RpcLogic___Disable_2166136261_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CurfewManager>.NativeClassPtr, 100672941);
			CurfewManager.NativeMethodInfoPtr_RpcReader___Observers_Disable_2166136261_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CurfewManager>.NativeClassPtr, 100672942);
			CurfewManager.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CurfewManager>.NativeClassPtr, 100672943);
		}

		// Token: 0x17001704 RID: 5892
		// (get) Token: 0x06004D19 RID: 19737 RVA: 0x00175B2C File Offset: 0x00173D2C
		// (set) Token: 0x06004D1A RID: 19738 RVA: 0x00175B68 File Offset: 0x00173D68
		public unsafe bool IsEnabled
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr obj = IL2CPP.il2cpp_runtime_invoke(CurfewManager.NativeMethodInfoPtr_get_IsEnabled_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CurfewManager.NativeMethodInfoPtr_set_IsEnabled_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x17001705 RID: 5893
		// (get) Token: 0x06004D1B RID: 19739 RVA: 0x00175BA8 File Offset: 0x00173DA8
		// (set) Token: 0x06004D1C RID: 19740 RVA: 0x00175BE4 File Offset: 0x00173DE4
		public unsafe bool IsCurrentlyActive
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr obj = IL2CPP.il2cpp_runtime_invoke(CurfewManager.NativeMethodInfoPtr_get_IsCurrentlyActive_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CurfewManager.NativeMethodInfoPtr_set_IsCurrentlyActive_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x17001706 RID: 5894
		// (get) Token: 0x06004D1D RID: 19741 RVA: 0x00175C24 File Offset: 0x00173E24
		public unsafe bool IsCurrentlyActiveWithTolerance
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 169459, RefRangeEnd = 169460, XrefRangeStart = 169458, XrefRangeEnd = 169459, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr obj = IL2CPP.il2cpp_runtime_invoke(CurfewManager.NativeMethodInfoPtr_get_IsCurrentlyActiveWithTolerance_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
		}

		// Token: 0x06004D1E RID: 19742 RVA: 0x00175C60 File Offset: 0x00173E60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 169460, XrefRangeEnd = 169482, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CurfewManager.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004D1F RID: 19743 RVA: 0x00175C9C File Offset: 0x00173E9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 169482, XrefRangeEnd = 169484, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnSpawnServer(NetworkConnection connection)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(connection);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CurfewManager.NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004D20 RID: 19744 RVA: 0x00175CEC File Offset: 0x00173EEC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 169510, RefRangeEnd = 169512, XrefRangeStart = 169484, XrefRangeEnd = 169510, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Enable(NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CurfewManager.NativeMethodInfoPtr_Enable_Public_Void_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004D21 RID: 19745 RVA: 0x00175D30 File Offset: 0x00173F30
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 169521, RefRangeEnd = 169523, XrefRangeStart = 169512, XrefRangeEnd = 169521, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Disable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CurfewManager.NativeMethodInfoPtr_Disable_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004D22 RID: 19746 RVA: 0x00175D64 File Offset: 0x00173F64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 169523, XrefRangeEnd = 169529, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MinPass()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CurfewManager.NativeMethodInfoPtr_MinPass_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004D23 RID: 19747 RVA: 0x00175D98 File Offset: 0x00173F98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 169529, XrefRangeEnd = 169532, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CurfewManager() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CurfewManager>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CurfewManager.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004D24 RID: 19748 RVA: 0x00175DD4 File Offset: 0x00173FD4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 169532, XrefRangeEnd = 169554, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize___Early()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CurfewManager.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004D25 RID: 19749 RVA: 0x00175E10 File Offset: 0x00174010
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 169554, XrefRangeEnd = 169557, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize__Late()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CurfewManager.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004D26 RID: 19750 RVA: 0x00175E4C File Offset: 0x0017404C
		[CallerCount(0)]
		public unsafe override void NetworkInitializeIfDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CurfewManager.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004D27 RID: 19751 RVA: 0x00175E88 File Offset: 0x00174088
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 169557, XrefRangeEnd = 169566, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_Enable_328543758(NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CurfewManager.NativeMethodInfoPtr_RpcWriter___Observers_Enable_328543758_Private_Void_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004D28 RID: 19752 RVA: 0x00175ECC File Offset: 0x001740CC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 169570, RefRangeEnd = 169572, XrefRangeStart = 169566, XrefRangeEnd = 169570, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___Enable_328543758(NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CurfewManager.NativeMethodInfoPtr_RpcLogic___Enable_328543758_Public_Void_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004D29 RID: 19753 RVA: 0x00175F10 File Offset: 0x00174110
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 169572, XrefRangeEnd = 169574, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_Enable_328543758(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CurfewManager.NativeMethodInfoPtr_RpcReader___Observers_Enable_328543758_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004D2A RID: 19754 RVA: 0x00175F60 File Offset: 0x00174160
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 169574, XrefRangeEnd = 169583, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Target_Enable_328543758(NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CurfewManager.NativeMethodInfoPtr_RpcWriter___Target_Enable_328543758_Private_Void_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004D2B RID: 19755 RVA: 0x00175FA4 File Offset: 0x001741A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 169583, XrefRangeEnd = 169586, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Target_Enable_328543758(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CurfewManager.NativeMethodInfoPtr_RpcReader___Target_Enable_328543758_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004D2C RID: 19756 RVA: 0x00175FF4 File Offset: 0x001741F4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 169521, RefRangeEnd = 169523, XrefRangeStart = 169521, XrefRangeEnd = 169523, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_Disable_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CurfewManager.NativeMethodInfoPtr_RpcWriter___Observers_Disable_2166136261_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004D2D RID: 19757 RVA: 0x00176028 File Offset: 0x00174228
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 169586, XrefRangeEnd = 169590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___Disable_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CurfewManager.NativeMethodInfoPtr_RpcLogic___Disable_2166136261_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004D2E RID: 19758 RVA: 0x0017605C File Offset: 0x0017425C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 169590, XrefRangeEnd = 169595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_Disable_2166136261(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CurfewManager.NativeMethodInfoPtr_RpcReader___Observers_Disable_2166136261_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004D2F RID: 19759 RVA: 0x001760AC File Offset: 0x001742AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 169595, XrefRangeEnd = 169598, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CurfewManager.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004D30 RID: 19760 RVA: 0x00024E3A File Offset: 0x0002303A
		public CurfewManager(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170016F5 RID: 5877
		// (get) Token: 0x06004D31 RID: 19761 RVA: 0x001760E8 File Offset: 0x001742E8
		// (set) Token: 0x06004D32 RID: 19762 RVA: 0x00024E43 File Offset: 0x00023043
		public unsafe static int WARNING_TIME
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(CurfewManager.NativeFieldInfoPtr_WARNING_TIME, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CurfewManager.NativeFieldInfoPtr_WARNING_TIME, (void*)(&value));
			}
		}

		// Token: 0x170016F6 RID: 5878
		// (get) Token: 0x06004D33 RID: 19763 RVA: 0x00176104 File Offset: 0x00174304
		// (set) Token: 0x06004D34 RID: 19764 RVA: 0x00024E51 File Offset: 0x00023051
		public unsafe static int CURFEW_START_TIME
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(CurfewManager.NativeFieldInfoPtr_CURFEW_START_TIME, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CurfewManager.NativeFieldInfoPtr_CURFEW_START_TIME, (void*)(&value));
			}
		}

		// Token: 0x170016F7 RID: 5879
		// (get) Token: 0x06004D35 RID: 19765 RVA: 0x00176120 File Offset: 0x00174320
		// (set) Token: 0x06004D36 RID: 19766 RVA: 0x00024E5F File Offset: 0x0002305F
		public unsafe static int CURFEW_END_TIME
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(CurfewManager.NativeFieldInfoPtr_CURFEW_END_TIME, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CurfewManager.NativeFieldInfoPtr_CURFEW_END_TIME, (void*)(&value));
			}
		}

		// Token: 0x170016F8 RID: 5880
		// (get) Token: 0x06004D37 RID: 19767 RVA: 0x0017613C File Offset: 0x0017433C
		// (set) Token: 0x06004D38 RID: 19768 RVA: 0x00024E6D File Offset: 0x0002306D
		public unsafe bool _IsEnabled_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CurfewManager.NativeFieldInfoPtr__IsEnabled_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CurfewManager.NativeFieldInfoPtr__IsEnabled_k__BackingField)) = value;
			}
		}

		// Token: 0x170016F9 RID: 5881
		// (get) Token: 0x06004D39 RID: 19769 RVA: 0x00176164 File Offset: 0x00174364
		// (set) Token: 0x06004D3A RID: 19770 RVA: 0x00024E88 File Offset: 0x00023088
		public unsafe bool _IsCurrentlyActive_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CurfewManager.NativeFieldInfoPtr__IsCurrentlyActive_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CurfewManager.NativeFieldInfoPtr__IsCurrentlyActive_k__BackingField)) = value;
			}
		}

		// Token: 0x170016FA RID: 5882
		// (get) Token: 0x06004D3B RID: 19771 RVA: 0x0017618C File Offset: 0x0017438C
		// (set) Token: 0x06004D3C RID: 19772 RVA: 0x00024EA3 File Offset: 0x000230A3
		public unsafe Il2CppReferenceArray<VMSBoard> VMSBoards
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CurfewManager.NativeFieldInfoPtr_VMSBoards);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<VMSBoard>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CurfewManager.NativeFieldInfoPtr_VMSBoards), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170016FB RID: 5883
		// (get) Token: 0x06004D3D RID: 19773 RVA: 0x001761BC File Offset: 0x001743BC
		// (set) Token: 0x06004D3E RID: 19774 RVA: 0x00024EC2 File Offset: 0x000230C2
		public unsafe AudioSourceController CurfewWarningSound
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CurfewManager.NativeFieldInfoPtr_CurfewWarningSound);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CurfewManager.NativeFieldInfoPtr_CurfewWarningSound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170016FC RID: 5884
		// (get) Token: 0x06004D3F RID: 19775 RVA: 0x001761EC File Offset: 0x001743EC
		// (set) Token: 0x06004D40 RID: 19776 RVA: 0x00024EE1 File Offset: 0x000230E1
		public unsafe AudioSourceController CurfewAlarmSound
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CurfewManager.NativeFieldInfoPtr_CurfewAlarmSound);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CurfewManager.NativeFieldInfoPtr_CurfewAlarmSound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170016FD RID: 5885
		// (get) Token: 0x06004D41 RID: 19777 RVA: 0x0017621C File Offset: 0x0017441C
		// (set) Token: 0x06004D42 RID: 19778 RVA: 0x00024F00 File Offset: 0x00023100
		public unsafe UnityEvent onCurfewEnabled
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CurfewManager.NativeFieldInfoPtr_onCurfewEnabled);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CurfewManager.NativeFieldInfoPtr_onCurfewEnabled), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170016FE RID: 5886
		// (get) Token: 0x06004D43 RID: 19779 RVA: 0x0017624C File Offset: 0x0017444C
		// (set) Token: 0x06004D44 RID: 19780 RVA: 0x00024F1F File Offset: 0x0002311F
		public unsafe UnityEvent onCurfewDisabled
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CurfewManager.NativeFieldInfoPtr_onCurfewDisabled);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CurfewManager.NativeFieldInfoPtr_onCurfewDisabled), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170016FF RID: 5887
		// (get) Token: 0x06004D45 RID: 19781 RVA: 0x0017627C File Offset: 0x0017447C
		// (set) Token: 0x06004D46 RID: 19782 RVA: 0x00024F3E File Offset: 0x0002313E
		public unsafe UnityEvent onCurfewHint
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CurfewManager.NativeFieldInfoPtr_onCurfewHint);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CurfewManager.NativeFieldInfoPtr_onCurfewHint), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001700 RID: 5888
		// (get) Token: 0x06004D47 RID: 19783 RVA: 0x001762AC File Offset: 0x001744AC
		// (set) Token: 0x06004D48 RID: 19784 RVA: 0x00024F5D File Offset: 0x0002315D
		public unsafe UnityEvent onCurfewWarning
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CurfewManager.NativeFieldInfoPtr_onCurfewWarning);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CurfewManager.NativeFieldInfoPtr_onCurfewWarning), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001701 RID: 5889
		// (get) Token: 0x06004D49 RID: 19785 RVA: 0x001762DC File Offset: 0x001744DC
		// (set) Token: 0x06004D4A RID: 19786 RVA: 0x00024F7C File Offset: 0x0002317C
		public unsafe bool warningPlayed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CurfewManager.NativeFieldInfoPtr_warningPlayed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CurfewManager.NativeFieldInfoPtr_warningPlayed)) = value;
			}
		}

		// Token: 0x17001702 RID: 5890
		// (get) Token: 0x06004D4B RID: 19787 RVA: 0x00176304 File Offset: 0x00174504
		// (set) Token: 0x06004D4C RID: 19788 RVA: 0x00024F97 File Offset: 0x00023197
		public new unsafe bool field_Private_Boolean_0
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CurfewManager.NativeFieldInfoPtr_field_Private_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CurfewManager.NativeFieldInfoPtr_field_Private_Boolean_0)) = value;
			}
		}

		// Token: 0x17001703 RID: 5891
		// (get) Token: 0x06004D4D RID: 19789 RVA: 0x0017632C File Offset: 0x0017452C
		// (set) Token: 0x06004D4E RID: 19790 RVA: 0x00024FB2 File Offset: 0x000231B2
		public new unsafe bool field_Private_Boolean_1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CurfewManager.NativeFieldInfoPtr_field_Private_Boolean_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CurfewManager.NativeFieldInfoPtr_field_Private_Boolean_1)) = value;
			}
		}

		// Token: 0x040033EF RID: 13295
		private static readonly IntPtr NativeFieldInfoPtr_WARNING_TIME;

		// Token: 0x040033F0 RID: 13296
		private static readonly IntPtr NativeFieldInfoPtr_CURFEW_START_TIME;

		// Token: 0x040033F1 RID: 13297
		private static readonly IntPtr NativeFieldInfoPtr_CURFEW_END_TIME;

		// Token: 0x040033F2 RID: 13298
		private static readonly IntPtr NativeFieldInfoPtr__IsEnabled_k__BackingField;

		// Token: 0x040033F3 RID: 13299
		private static readonly IntPtr NativeFieldInfoPtr__IsCurrentlyActive_k__BackingField;

		// Token: 0x040033F4 RID: 13300
		private static readonly IntPtr NativeFieldInfoPtr_VMSBoards;

		// Token: 0x040033F5 RID: 13301
		private static readonly IntPtr NativeFieldInfoPtr_CurfewWarningSound;

		// Token: 0x040033F6 RID: 13302
		private static readonly IntPtr NativeFieldInfoPtr_CurfewAlarmSound;

		// Token: 0x040033F7 RID: 13303
		private static readonly IntPtr NativeFieldInfoPtr_onCurfewEnabled;

		// Token: 0x040033F8 RID: 13304
		private static readonly IntPtr NativeFieldInfoPtr_onCurfewDisabled;

		// Token: 0x040033F9 RID: 13305
		private static readonly IntPtr NativeFieldInfoPtr_onCurfewHint;

		// Token: 0x040033FA RID: 13306
		private static readonly IntPtr NativeFieldInfoPtr_onCurfewWarning;

		// Token: 0x040033FB RID: 13307
		private static readonly IntPtr NativeFieldInfoPtr_warningPlayed;

		// Token: 0x040033FC RID: 13308
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

		// Token: 0x040033FD RID: 13309
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

		// Token: 0x040033FE RID: 13310
		private static readonly IntPtr NativeMethodInfoPtr_get_IsEnabled_Public_get_Boolean_0;

		// Token: 0x040033FF RID: 13311
		private static readonly IntPtr NativeMethodInfoPtr_set_IsEnabled_Protected_set_Void_Boolean_0;

		// Token: 0x04003400 RID: 13312
		private static readonly IntPtr NativeMethodInfoPtr_get_IsCurrentlyActive_Public_get_Boolean_0;

		// Token: 0x04003401 RID: 13313
		private static readonly IntPtr NativeMethodInfoPtr_set_IsCurrentlyActive_Protected_set_Void_Boolean_0;

		// Token: 0x04003402 RID: 13314
		private static readonly IntPtr NativeMethodInfoPtr_get_IsCurrentlyActiveWithTolerance_Public_get_Boolean_0;

		// Token: 0x04003403 RID: 13315
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x04003404 RID: 13316
		private static readonly IntPtr NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0;

		// Token: 0x04003405 RID: 13317
		private static readonly IntPtr NativeMethodInfoPtr_Enable_Public_Void_NetworkConnection_0;

		// Token: 0x04003406 RID: 13318
		private static readonly IntPtr NativeMethodInfoPtr_Disable_Public_Void_0;

		// Token: 0x04003407 RID: 13319
		private static readonly IntPtr NativeMethodInfoPtr_MinPass_Private_Void_0;

		// Token: 0x04003408 RID: 13320
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04003409 RID: 13321
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

		// Token: 0x0400340A RID: 13322
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

		// Token: 0x0400340B RID: 13323
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

		// Token: 0x0400340C RID: 13324
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_Enable_328543758_Private_Void_NetworkConnection_0;

		// Token: 0x0400340D RID: 13325
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___Enable_328543758_Public_Void_NetworkConnection_0;

		// Token: 0x0400340E RID: 13326
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_Enable_328543758_Private_Void_PooledReader_Channel_0;

		// Token: 0x0400340F RID: 13327
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Target_Enable_328543758_Private_Void_NetworkConnection_0;

		// Token: 0x04003410 RID: 13328
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Target_Enable_328543758_Private_Void_PooledReader_Channel_0;

		// Token: 0x04003411 RID: 13329
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_Disable_2166136261_Private_Void_0;

		// Token: 0x04003412 RID: 13330
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___Disable_2166136261_Public_Void_0;

		// Token: 0x04003413 RID: 13331
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_Disable_2166136261_Private_Void_PooledReader_Channel_0;

		// Token: 0x04003414 RID: 13332
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;
	}
}
