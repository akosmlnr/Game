using System;
using Il2CppFishNet.Object;
using Il2CppFishNet.Serializing;
using Il2CppFishNet.Transporting;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Audio;
using Il2CppScheduleOne.AvatarFramework.Equipping;
using Il2CppScheduleOne.Law;
using Il2CppScheduleOne.PlayerScripts;
using Il2CppScheduleOne.UI.WorldspacePopup;

namespace Il2CppScheduleOne.NPCs.Behaviour
{
	// Token: 0x02000363 RID: 867
	public class CallPoliceBehaviour : Behaviour
	{
		// Token: 0x06003F6C RID: 16236 RVA: 0x00142D0C File Offset: 0x00140F0C
		// Note: this type is marked as 'beforefieldinit'.
		static CallPoliceBehaviour()
		{
			Il2CppClassPointerStore<CallPoliceBehaviour>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.NPCs.Behaviour", "CallPoliceBehaviour");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CallPoliceBehaviour>.NativeClassPtr);
			CallPoliceBehaviour.NativeFieldInfoPtr_CALL_POLICE_TIME = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CallPoliceBehaviour>.NativeClassPtr, "CALL_POLICE_TIME");
			CallPoliceBehaviour.NativeFieldInfoPtr_PhoneCallPopup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CallPoliceBehaviour>.NativeClassPtr, "PhoneCallPopup");
			CallPoliceBehaviour.NativeFieldInfoPtr_PhonePrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CallPoliceBehaviour>.NativeClassPtr, "PhonePrefab");
			CallPoliceBehaviour.NativeFieldInfoPtr_CallSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CallPoliceBehaviour>.NativeClassPtr, "CallSound");
			CallPoliceBehaviour.NativeFieldInfoPtr_currentCallTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CallPoliceBehaviour>.NativeClassPtr, "currentCallTime");
			CallPoliceBehaviour.NativeFieldInfoPtr_Target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CallPoliceBehaviour>.NativeClassPtr, "Target");
			CallPoliceBehaviour.NativeFieldInfoPtr_ReportedCrime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CallPoliceBehaviour>.NativeClassPtr, "ReportedCrime");
			CallPoliceBehaviour.NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CallPoliceBehaviour>.NativeClassPtr, "NetworkInitialize___EarlyScheduleOne.NPCs.Behaviour.CallPoliceBehaviourAssembly-CSharp.dll_Excuted");
			CallPoliceBehaviour.NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CallPoliceBehaviour>.NativeClassPtr, "NetworkInitialize__LateScheduleOne.NPCs.Behaviour.CallPoliceBehaviourAssembly-CSharp.dll_Excuted");
			CallPoliceBehaviour.NativeMethodInfoPtr_Begin_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallPoliceBehaviour>.NativeClassPtr, 100670806);
			CallPoliceBehaviour.NativeMethodInfoPtr_SetData_Public_Void_NetworkObject_Crime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallPoliceBehaviour>.NativeClassPtr, 100670807);
			CallPoliceBehaviour.NativeMethodInfoPtr_Resume_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallPoliceBehaviour>.NativeClassPtr, 100670808);
			CallPoliceBehaviour.NativeMethodInfoPtr_End_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallPoliceBehaviour>.NativeClassPtr, 100670809);
			CallPoliceBehaviour.NativeMethodInfoPtr_Pause_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallPoliceBehaviour>.NativeClassPtr, 100670810);
			CallPoliceBehaviour.NativeMethodInfoPtr_BehaviourUpdate_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallPoliceBehaviour>.NativeClassPtr, 100670811);
			CallPoliceBehaviour.NativeMethodInfoPtr_RefreshIcon_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallPoliceBehaviour>.NativeClassPtr, 100670812);
			CallPoliceBehaviour.NativeMethodInfoPtr_FinalizeCall_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallPoliceBehaviour>.NativeClassPtr, 100670813);
			CallPoliceBehaviour.NativeMethodInfoPtr_IsTargetValid_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallPoliceBehaviour>.NativeClassPtr, 100670814);
			CallPoliceBehaviour.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallPoliceBehaviour>.NativeClassPtr, 100670815);
			CallPoliceBehaviour.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallPoliceBehaviour>.NativeClassPtr, 100670816);
			CallPoliceBehaviour.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallPoliceBehaviour>.NativeClassPtr, 100670817);
			CallPoliceBehaviour.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallPoliceBehaviour>.NativeClassPtr, 100670818);
			CallPoliceBehaviour.NativeMethodInfoPtr_RpcWriter___Observers_FinalizeCall_2166136261_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallPoliceBehaviour>.NativeClassPtr, 100670819);
			CallPoliceBehaviour.NativeMethodInfoPtr_RpcLogic___FinalizeCall_2166136261_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallPoliceBehaviour>.NativeClassPtr, 100670820);
			CallPoliceBehaviour.NativeMethodInfoPtr_RpcReader___Observers_FinalizeCall_2166136261_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallPoliceBehaviour>.NativeClassPtr, 100670821);
			CallPoliceBehaviour.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallPoliceBehaviour>.NativeClassPtr, 100670822);
		}

		// Token: 0x06003F6D RID: 16237 RVA: 0x00142F44 File Offset: 0x00141144
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 150807, XrefRangeEnd = 150827, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Begin()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CallPoliceBehaviour.NativeMethodInfoPtr_Begin_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06003F6E RID: 16238 RVA: 0x00142F80 File Offset: 0x00141180
		[CallerCount(14558)]
		[CachedScanResults(RefRangeStart = 2769, RefRangeEnd = 17327, XrefRangeStart = 2769, XrefRangeEnd = 17327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetData(NetworkObject player, Crime crime)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(crime);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallPoliceBehaviour.NativeMethodInfoPtr_SetData_Public_Void_NetworkObject_Crime_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06003F6F RID: 16239 RVA: 0x00142FD4 File Offset: 0x001411D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 150827, XrefRangeEnd = 150834, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Resume()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CallPoliceBehaviour.NativeMethodInfoPtr_Resume_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06003F70 RID: 16240 RVA: 0x00143010 File Offset: 0x00141210
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 150834, XrefRangeEnd = 150841, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void End()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CallPoliceBehaviour.NativeMethodInfoPtr_End_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06003F71 RID: 16241 RVA: 0x0014304C File Offset: 0x0014124C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 150841, XrefRangeEnd = 150848, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Pause()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CallPoliceBehaviour.NativeMethodInfoPtr_Pause_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06003F72 RID: 16242 RVA: 0x00143088 File Offset: 0x00141288
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 150848, XrefRangeEnd = 150871, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void BehaviourUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CallPoliceBehaviour.NativeMethodInfoPtr_BehaviourUpdate_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06003F73 RID: 16243 RVA: 0x001430C4 File Offset: 0x001412C4
		[CallerCount(0)]
		public unsafe void RefreshIcon()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallPoliceBehaviour.NativeMethodInfoPtr_RefreshIcon_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06003F74 RID: 16244 RVA: 0x001430F8 File Offset: 0x001412F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 150871, XrefRangeEnd = 150892, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FinalizeCall()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallPoliceBehaviour.NativeMethodInfoPtr_FinalizeCall_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06003F75 RID: 16245 RVA: 0x0014312C File Offset: 0x0014132C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 150896, RefRangeEnd = 150899, XrefRangeStart = 150892, XrefRangeEnd = 150896, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsTargetValid()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(CallPoliceBehaviour.NativeMethodInfoPtr_IsTargetValid_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06003F76 RID: 16246 RVA: 0x00143168 File Offset: 0x00141368
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CallPoliceBehaviour() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CallPoliceBehaviour>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallPoliceBehaviour.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06003F77 RID: 16247 RVA: 0x001431A4 File Offset: 0x001413A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 150899, XrefRangeEnd = 150907, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize___Early()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CallPoliceBehaviour.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06003F78 RID: 16248 RVA: 0x001431E0 File Offset: 0x001413E0
		[CallerCount(0)]
		public unsafe override void NetworkInitialize__Late()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CallPoliceBehaviour.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06003F79 RID: 16249 RVA: 0x0014321C File Offset: 0x0014141C
		[CallerCount(0)]
		public unsafe override void NetworkInitializeIfDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CallPoliceBehaviour.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06003F7A RID: 16250 RVA: 0x00143258 File Offset: 0x00141458
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 150907, XrefRangeEnd = 150916, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_FinalizeCall_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallPoliceBehaviour.NativeMethodInfoPtr_RpcWriter___Observers_FinalizeCall_2166136261_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06003F7B RID: 16251 RVA: 0x0014328C File Offset: 0x0014148C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 150934, RefRangeEnd = 150937, XrefRangeStart = 150916, XrefRangeEnd = 150934, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___FinalizeCall_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallPoliceBehaviour.NativeMethodInfoPtr_RpcLogic___FinalizeCall_2166136261_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06003F7C RID: 16252 RVA: 0x001432C0 File Offset: 0x001414C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 150937, XrefRangeEnd = 150940, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_FinalizeCall_2166136261(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallPoliceBehaviour.NativeMethodInfoPtr_RpcReader___Observers_FinalizeCall_2166136261_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06003F7D RID: 16253 RVA: 0x00143310 File Offset: 0x00141510
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CallPoliceBehaviour.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06003F7E RID: 16254 RVA: 0x0001FB50 File Offset: 0x0001DD50
		public CallPoliceBehaviour(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001374 RID: 4980
		// (get) Token: 0x06003F7F RID: 16255 RVA: 0x0014334C File Offset: 0x0014154C
		// (set) Token: 0x06003F80 RID: 16256 RVA: 0x0001FB59 File Offset: 0x0001DD59
		public unsafe static float CALL_POLICE_TIME
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(CallPoliceBehaviour.NativeFieldInfoPtr_CALL_POLICE_TIME, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CallPoliceBehaviour.NativeFieldInfoPtr_CALL_POLICE_TIME, (void*)(&value));
			}
		}

		// Token: 0x17001375 RID: 4981
		// (get) Token: 0x06003F81 RID: 16257 RVA: 0x00143368 File Offset: 0x00141568
		// (set) Token: 0x06003F82 RID: 16258 RVA: 0x0001FB67 File Offset: 0x0001DD67
		public unsafe WorldspacePopup PhoneCallPopup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallPoliceBehaviour.NativeFieldInfoPtr_PhoneCallPopup);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WorldspacePopup>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallPoliceBehaviour.NativeFieldInfoPtr_PhoneCallPopup), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001376 RID: 4982
		// (get) Token: 0x06003F83 RID: 16259 RVA: 0x00143398 File Offset: 0x00141598
		// (set) Token: 0x06003F84 RID: 16260 RVA: 0x0001FB86 File Offset: 0x0001DD86
		public unsafe AvatarEquippable PhonePrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallPoliceBehaviour.NativeFieldInfoPtr_PhonePrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AvatarEquippable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallPoliceBehaviour.NativeFieldInfoPtr_PhonePrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001377 RID: 4983
		// (get) Token: 0x06003F85 RID: 16261 RVA: 0x001433C8 File Offset: 0x001415C8
		// (set) Token: 0x06003F86 RID: 16262 RVA: 0x0001FBA5 File Offset: 0x0001DDA5
		public unsafe AudioSourceController CallSound
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallPoliceBehaviour.NativeFieldInfoPtr_CallSound);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallPoliceBehaviour.NativeFieldInfoPtr_CallSound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001378 RID: 4984
		// (get) Token: 0x06003F87 RID: 16263 RVA: 0x001433F8 File Offset: 0x001415F8
		// (set) Token: 0x06003F88 RID: 16264 RVA: 0x0001FBC4 File Offset: 0x0001DDC4
		public unsafe float currentCallTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallPoliceBehaviour.NativeFieldInfoPtr_currentCallTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallPoliceBehaviour.NativeFieldInfoPtr_currentCallTime)) = value;
			}
		}

		// Token: 0x17001379 RID: 4985
		// (get) Token: 0x06003F89 RID: 16265 RVA: 0x00143420 File Offset: 0x00141620
		// (set) Token: 0x06003F8A RID: 16266 RVA: 0x0001FBDF File Offset: 0x0001DDDF
		public unsafe Player Target
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallPoliceBehaviour.NativeFieldInfoPtr_Target);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Player>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallPoliceBehaviour.NativeFieldInfoPtr_Target), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700137A RID: 4986
		// (get) Token: 0x06003F8B RID: 16267 RVA: 0x00143450 File Offset: 0x00141650
		// (set) Token: 0x06003F8C RID: 16268 RVA: 0x0001FBFE File Offset: 0x0001DDFE
		public unsafe Crime ReportedCrime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallPoliceBehaviour.NativeFieldInfoPtr_ReportedCrime);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Crime>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallPoliceBehaviour.NativeFieldInfoPtr_ReportedCrime), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700137B RID: 4987
		// (get) Token: 0x06003F8D RID: 16269 RVA: 0x00143480 File Offset: 0x00141680
		// (set) Token: 0x06003F8E RID: 16270 RVA: 0x0001FC1D File Offset: 0x0001DE1D
		public new unsafe bool field_Private_Boolean_0
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallPoliceBehaviour.NativeFieldInfoPtr_field_Private_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallPoliceBehaviour.NativeFieldInfoPtr_field_Private_Boolean_0)) = value;
			}
		}

		// Token: 0x1700137C RID: 4988
		// (get) Token: 0x06003F8F RID: 16271 RVA: 0x001434A8 File Offset: 0x001416A8
		// (set) Token: 0x06003F90 RID: 16272 RVA: 0x0001FC38 File Offset: 0x0001DE38
		public new unsafe bool field_Private_Boolean_1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallPoliceBehaviour.NativeFieldInfoPtr_field_Private_Boolean_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallPoliceBehaviour.NativeFieldInfoPtr_field_Private_Boolean_1)) = value;
			}
		}

		// Token: 0x040029EB RID: 10731
		private static readonly IntPtr NativeFieldInfoPtr_CALL_POLICE_TIME;

		// Token: 0x040029EC RID: 10732
		private static readonly IntPtr NativeFieldInfoPtr_PhoneCallPopup;

		// Token: 0x040029ED RID: 10733
		private static readonly IntPtr NativeFieldInfoPtr_PhonePrefab;

		// Token: 0x040029EE RID: 10734
		private static readonly IntPtr NativeFieldInfoPtr_CallSound;

		// Token: 0x040029EF RID: 10735
		private static readonly IntPtr NativeFieldInfoPtr_currentCallTime;

		// Token: 0x040029F0 RID: 10736
		private static readonly IntPtr NativeFieldInfoPtr_Target;

		// Token: 0x040029F1 RID: 10737
		private static readonly IntPtr NativeFieldInfoPtr_ReportedCrime;

		// Token: 0x040029F2 RID: 10738
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

		// Token: 0x040029F3 RID: 10739
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

		// Token: 0x040029F4 RID: 10740
		private static readonly IntPtr NativeMethodInfoPtr_Begin_Protected_Virtual_Void_0;

		// Token: 0x040029F5 RID: 10741
		private static readonly IntPtr NativeMethodInfoPtr_SetData_Public_Void_NetworkObject_Crime_0;

		// Token: 0x040029F6 RID: 10742
		private static readonly IntPtr NativeMethodInfoPtr_Resume_Protected_Virtual_Void_0;

		// Token: 0x040029F7 RID: 10743
		private static readonly IntPtr NativeMethodInfoPtr_End_Protected_Virtual_Void_0;

		// Token: 0x040029F8 RID: 10744
		private static readonly IntPtr NativeMethodInfoPtr_Pause_Protected_Virtual_Void_0;

		// Token: 0x040029F9 RID: 10745
		private static readonly IntPtr NativeMethodInfoPtr_BehaviourUpdate_Public_Virtual_Void_0;

		// Token: 0x040029FA RID: 10746
		private static readonly IntPtr NativeMethodInfoPtr_RefreshIcon_Private_Void_0;

		// Token: 0x040029FB RID: 10747
		private static readonly IntPtr NativeMethodInfoPtr_FinalizeCall_Private_Void_0;

		// Token: 0x040029FC RID: 10748
		private static readonly IntPtr NativeMethodInfoPtr_IsTargetValid_Private_Boolean_0;

		// Token: 0x040029FD RID: 10749
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040029FE RID: 10750
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

		// Token: 0x040029FF RID: 10751
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

		// Token: 0x04002A00 RID: 10752
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

		// Token: 0x04002A01 RID: 10753
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_FinalizeCall_2166136261_Private_Void_0;

		// Token: 0x04002A02 RID: 10754
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___FinalizeCall_2166136261_Private_Void_0;

		// Token: 0x04002A03 RID: 10755
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_FinalizeCall_2166136261_Private_Void_PooledReader_Channel_0;

		// Token: 0x04002A04 RID: 10756
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;
	}
}
