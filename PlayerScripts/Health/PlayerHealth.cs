using System;
using Il2CppFishNet.Connection;
using Il2CppFishNet.Object;
using Il2CppFishNet.Serializing;
using Il2CppFishNet.Transporting;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;
using UnityEngine.Events;

namespace Il2CppScheduleOne.PlayerScripts.Health
{
	// Token: 0x0200040E RID: 1038
	public class PlayerHealth : NetworkBehaviour
	{
		// Token: 0x06005456 RID: 21590 RVA: 0x0018FB8C File Offset: 0x0018DD8C
		// Note: this type is marked as 'beforefieldinit'.
		static PlayerHealth()
		{
			Il2CppClassPointerStore<PlayerHealth>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.PlayerScripts.Health", "PlayerHealth");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayerHealth>.NativeClassPtr);
			PlayerHealth.NativeFieldInfoPtr_MAX_HEALTH = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerHealth>.NativeClassPtr, "MAX_HEALTH");
			PlayerHealth.NativeFieldInfoPtr_HEALTH_RECOVERY_PER_MINUTE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerHealth>.NativeClassPtr, "HEALTH_RECOVERY_PER_MINUTE");
			PlayerHealth.NativeFieldInfoPtr__IsAlive_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerHealth>.NativeClassPtr, "<IsAlive>k__BackingField");
			PlayerHealth.NativeFieldInfoPtr__CurrentHealth_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerHealth>.NativeClassPtr, "<CurrentHealth>k__BackingField");
			PlayerHealth.NativeFieldInfoPtr__TimeSinceLastDamage_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerHealth>.NativeClassPtr, "<TimeSinceLastDamage>k__BackingField");
			PlayerHealth.NativeFieldInfoPtr_Player = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerHealth>.NativeClassPtr, "Player");
			PlayerHealth.NativeFieldInfoPtr_BloodParticles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerHealth>.NativeClassPtr, "BloodParticles");
			PlayerHealth.NativeFieldInfoPtr_onHealthChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerHealth>.NativeClassPtr, "onHealthChanged");
			PlayerHealth.NativeFieldInfoPtr_onDie = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerHealth>.NativeClassPtr, "onDie");
			PlayerHealth.NativeFieldInfoPtr_onRevive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerHealth>.NativeClassPtr, "onRevive");
			PlayerHealth.NativeFieldInfoPtr_AfflictedWithLethalEffect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerHealth>.NativeClassPtr, "AfflictedWithLethalEffect");
			PlayerHealth.NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerHealth>.NativeClassPtr, "NetworkInitialize___EarlyScheduleOne.PlayerScripts.Health.PlayerHealthAssembly-CSharp.dll_Excuted");
			PlayerHealth.NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerHealth>.NativeClassPtr, "NetworkInitialize__LateScheduleOne.PlayerScripts.Health.PlayerHealthAssembly-CSharp.dll_Excuted");
			PlayerHealth.NativeMethodInfoPtr_get_IsAlive_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerHealth>.NativeClassPtr, 100673913);
			PlayerHealth.NativeMethodInfoPtr_set_IsAlive_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerHealth>.NativeClassPtr, 100673914);
			PlayerHealth.NativeMethodInfoPtr_get_CurrentHealth_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerHealth>.NativeClassPtr, 100673915);
			PlayerHealth.NativeMethodInfoPtr_set_CurrentHealth_Protected_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerHealth>.NativeClassPtr, 100673916);
			PlayerHealth.NativeMethodInfoPtr_get_TimeSinceLastDamage_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerHealth>.NativeClassPtr, 100673917);
			PlayerHealth.NativeMethodInfoPtr_set_TimeSinceLastDamage_Protected_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerHealth>.NativeClassPtr, 100673918);
			PlayerHealth.NativeMethodInfoPtr_get_CanTakeDamage_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerHealth>.NativeClassPtr, 100673919);
			PlayerHealth.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerHealth>.NativeClassPtr, 100673920);
			PlayerHealth.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerHealth>.NativeClassPtr, 100673921);
			PlayerHealth.NativeMethodInfoPtr_TakeDamage_Public_Void_Single_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerHealth>.NativeClassPtr, 100673922);
			PlayerHealth.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerHealth>.NativeClassPtr, 100673923);
			PlayerHealth.NativeMethodInfoPtr_MinPass_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerHealth>.NativeClassPtr, 100673924);
			PlayerHealth.NativeMethodInfoPtr_SetAfflictedWithLethalEffect_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerHealth>.NativeClassPtr, 100673925);
			PlayerHealth.NativeMethodInfoPtr_RecoverHealth_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerHealth>.NativeClassPtr, 100673926);
			PlayerHealth.NativeMethodInfoPtr_SetHealth_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerHealth>.NativeClassPtr, 100673927);
			PlayerHealth.NativeMethodInfoPtr_SendDie_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerHealth>.NativeClassPtr, 100673928);
			PlayerHealth.NativeMethodInfoPtr_Die_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerHealth>.NativeClassPtr, 100673929);
			PlayerHealth.NativeMethodInfoPtr_SendRevive_Public_Void_Vector3_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerHealth>.NativeClassPtr, 100673930);
			PlayerHealth.NativeMethodInfoPtr_Revive_Public_Void_Vector3_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerHealth>.NativeClassPtr, 100673931);
			PlayerHealth.NativeMethodInfoPtr_PlayBloodMist_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerHealth>.NativeClassPtr, 100673932);
			PlayerHealth.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerHealth>.NativeClassPtr, 100673933);
			PlayerHealth.NativeMethodInfoPtr__Awake_b__22_0_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerHealth>.NativeClassPtr, 100673934);
			PlayerHealth.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerHealth>.NativeClassPtr, 100673935);
			PlayerHealth.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerHealth>.NativeClassPtr, 100673936);
			PlayerHealth.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerHealth>.NativeClassPtr, 100673937);
			PlayerHealth.NativeMethodInfoPtr_RpcWriter___Observers_TakeDamage_3505310624_Private_Void_Single_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerHealth>.NativeClassPtr, 100673938);
			PlayerHealth.NativeMethodInfoPtr_RpcLogic___TakeDamage_3505310624_Public_Void_Single_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerHealth>.NativeClassPtr, 100673939);
			PlayerHealth.NativeMethodInfoPtr_RpcReader___Observers_TakeDamage_3505310624_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerHealth>.NativeClassPtr, 100673940);
			PlayerHealth.NativeMethodInfoPtr_RpcWriter___Server_SendDie_2166136261_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerHealth>.NativeClassPtr, 100673941);
			PlayerHealth.NativeMethodInfoPtr_RpcLogic___SendDie_2166136261_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerHealth>.NativeClassPtr, 100673942);
			PlayerHealth.NativeMethodInfoPtr_RpcReader___Server_SendDie_2166136261_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerHealth>.NativeClassPtr, 100673943);
			PlayerHealth.NativeMethodInfoPtr_RpcWriter___Observers_Die_2166136261_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerHealth>.NativeClassPtr, 100673944);
			PlayerHealth.NativeMethodInfoPtr_RpcLogic___Die_2166136261_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerHealth>.NativeClassPtr, 100673945);
			PlayerHealth.NativeMethodInfoPtr_RpcReader___Observers_Die_2166136261_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerHealth>.NativeClassPtr, 100673946);
			PlayerHealth.NativeMethodInfoPtr_RpcWriter___Server_SendRevive_3848837105_Private_Void_Vector3_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerHealth>.NativeClassPtr, 100673947);
			PlayerHealth.NativeMethodInfoPtr_RpcLogic___SendRevive_3848837105_Public_Void_Vector3_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerHealth>.NativeClassPtr, 100673948);
			PlayerHealth.NativeMethodInfoPtr_RpcReader___Server_SendRevive_3848837105_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerHealth>.NativeClassPtr, 100673949);
			PlayerHealth.NativeMethodInfoPtr_RpcWriter___Observers_Revive_3848837105_Private_Void_Vector3_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerHealth>.NativeClassPtr, 100673950);
			PlayerHealth.NativeMethodInfoPtr_RpcLogic___Revive_3848837105_Public_Void_Vector3_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerHealth>.NativeClassPtr, 100673951);
			PlayerHealth.NativeMethodInfoPtr_RpcReader___Observers_Revive_3848837105_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerHealth>.NativeClassPtr, 100673952);
			PlayerHealth.NativeMethodInfoPtr_RpcWriter___Observers_PlayBloodMist_2166136261_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerHealth>.NativeClassPtr, 100673953);
			PlayerHealth.NativeMethodInfoPtr_RpcLogic___PlayBloodMist_2166136261_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerHealth>.NativeClassPtr, 100673954);
			PlayerHealth.NativeMethodInfoPtr_RpcReader___Observers_PlayBloodMist_2166136261_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerHealth>.NativeClassPtr, 100673955);
			PlayerHealth.NativeMethodInfoPtr_Method_Private_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerHealth>.NativeClassPtr, 100673956);
		}

		// Token: 0x17001950 RID: 6480
		// (get) Token: 0x06005457 RID: 21591 RVA: 0x00190030 File Offset: 0x0018E230
		// (set) Token: 0x06005458 RID: 21592 RVA: 0x0019006C File Offset: 0x0018E26C
		public unsafe bool IsAlive
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr obj = IL2CPP.il2cpp_runtime_invoke(PlayerHealth.NativeMethodInfoPtr_get_IsAlive_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerHealth.NativeMethodInfoPtr_set_IsAlive_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x17001951 RID: 6481
		// (get) Token: 0x06005459 RID: 21593 RVA: 0x001900AC File Offset: 0x0018E2AC
		// (set) Token: 0x0600545A RID: 21594 RVA: 0x001900E8 File Offset: 0x0018E2E8
		public unsafe float CurrentHealth
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 89901, RefRangeEnd = 89903, XrefRangeStart = 89901, XrefRangeEnd = 89903, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr obj = IL2CPP.il2cpp_runtime_invoke(PlayerHealth.NativeMethodInfoPtr_get_CurrentHealth_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerHealth.NativeMethodInfoPtr_set_CurrentHealth_Protected_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x17001952 RID: 6482
		// (get) Token: 0x0600545B RID: 21595 RVA: 0x00190128 File Offset: 0x0018E328
		// (set) Token: 0x0600545C RID: 21596 RVA: 0x00190164 File Offset: 0x0018E364
		public unsafe float TimeSinceLastDamage
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr obj = IL2CPP.il2cpp_runtime_invoke(PlayerHealth.NativeMethodInfoPtr_get_TimeSinceLastDamage_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerHealth.NativeMethodInfoPtr_set_TimeSinceLastDamage_Protected_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x17001953 RID: 6483
		// (get) Token: 0x0600545D RID: 21597 RVA: 0x001901A4 File Offset: 0x0018E3A4
		public unsafe bool CanTakeDamage
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 182381, RefRangeEnd = 182382, XrefRangeStart = 182375, XrefRangeEnd = 182381, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr obj = IL2CPP.il2cpp_runtime_invoke(PlayerHealth.NativeMethodInfoPtr_get_CanTakeDamage_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
		}

		// Token: 0x0600545E RID: 21598 RVA: 0x001901E0 File Offset: 0x0018E3E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 182382, XrefRangeEnd = 182394, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PlayerHealth.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600545F RID: 21599 RVA: 0x0019021C File Offset: 0x0018E41C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 182394, XrefRangeEnd = 182426, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerHealth.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005460 RID: 21600 RVA: 0x00190250 File Offset: 0x0018E450
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 182438, RefRangeEnd = 182442, XrefRangeStart = 182426, XrefRangeEnd = 182438, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void TakeDamage(float damage, bool flinch = true, bool playBloodMist = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref damage;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref flinch;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref playBloodMist;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerHealth.NativeMethodInfoPtr_TakeDamage_Public_Void_Single_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005461 RID: 21601 RVA: 0x001902AC File Offset: 0x0018E4AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 182442, XrefRangeEnd = 182464, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerHealth.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005462 RID: 21602 RVA: 0x001902E0 File Offset: 0x0018E4E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 182464, XrefRangeEnd = 182474, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MinPass()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerHealth.NativeMethodInfoPtr_MinPass_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005463 RID: 21603 RVA: 0x00190314 File Offset: 0x0018E514
		[CallerCount(0)]
		public unsafe void SetAfflictedWithLethalEffect(bool value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref value;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerHealth.NativeMethodInfoPtr_SetAfflictedWithLethalEffect_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005464 RID: 21604 RVA: 0x00190354 File Offset: 0x0018E554
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 182484, RefRangeEnd = 182486, XrefRangeStart = 182474, XrefRangeEnd = 182484, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RecoverHealth(float recovery)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref recovery;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerHealth.NativeMethodInfoPtr_RecoverHealth_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005465 RID: 21605 RVA: 0x00190394 File Offset: 0x0018E594
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 182491, RefRangeEnd = 182493, XrefRangeStart = 182486, XrefRangeEnd = 182491, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetHealth(float health)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref health;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerHealth.NativeMethodInfoPtr_SetHealth_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005466 RID: 21606 RVA: 0x001903D4 File Offset: 0x0018E5D4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 182514, RefRangeEnd = 182517, XrefRangeStart = 182493, XrefRangeEnd = 182514, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendDie()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerHealth.NativeMethodInfoPtr_SendDie_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005467 RID: 21607 RVA: 0x00190408 File Offset: 0x0018E608
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 182538, RefRangeEnd = 182540, XrefRangeStart = 182517, XrefRangeEnd = 182538, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Die()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerHealth.NativeMethodInfoPtr_Die_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005468 RID: 21608 RVA: 0x0019043C File Offset: 0x0018E63C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 182543, RefRangeEnd = 182544, XrefRangeStart = 182540, XrefRangeEnd = 182543, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendRevive(Vector3 position, Quaternion rotation)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref position;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rotation;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerHealth.NativeMethodInfoPtr_SendRevive_Public_Void_Vector3_Quaternion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005469 RID: 21609 RVA: 0x00190488 File Offset: 0x0018E688
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 182544, XrefRangeEnd = 182546, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Revive(Vector3 position, Quaternion rotation)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref position;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rotation;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerHealth.NativeMethodInfoPtr_Revive_Public_Void_Vector3_Quaternion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600546A RID: 21610 RVA: 0x001904D4 File Offset: 0x0018E6D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 182546, XrefRangeEnd = 182555, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PlayBloodMist()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerHealth.NativeMethodInfoPtr_PlayBloodMist_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600546B RID: 21611 RVA: 0x00190508 File Offset: 0x0018E708
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 182555, XrefRangeEnd = 182556, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PlayerHealth() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayerHealth>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerHealth.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600546C RID: 21612 RVA: 0x00190544 File Offset: 0x0018E744
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 182556, XrefRangeEnd = 182560, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _Awake_b__22_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerHealth.NativeMethodInfoPtr__Awake_b__22_0_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600546D RID: 21613 RVA: 0x00190578 File Offset: 0x0018E778
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 182560, XrefRangeEnd = 182598, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void NetworkInitialize___Early()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PlayerHealth.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600546E RID: 21614 RVA: 0x001905B4 File Offset: 0x0018E7B4
		[CallerCount(0)]
		public unsafe virtual void NetworkInitialize__Late()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PlayerHealth.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600546F RID: 21615 RVA: 0x001905F0 File Offset: 0x0018E7F0
		[CallerCount(0)]
		public unsafe override void NetworkInitializeIfDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PlayerHealth.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005470 RID: 21616 RVA: 0x0019062C File Offset: 0x0018E82C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 182438, RefRangeEnd = 182442, XrefRangeStart = 182438, XrefRangeEnd = 182442, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_TakeDamage_3505310624(float damage, bool flinch = true, bool playBloodMist = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref damage;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref flinch;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref playBloodMist;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerHealth.NativeMethodInfoPtr_RpcWriter___Observers_TakeDamage_3505310624_Private_Void_Single_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005471 RID: 21617 RVA: 0x00190688 File Offset: 0x0018E888
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 182651, RefRangeEnd = 182652, XrefRangeStart = 182598, XrefRangeEnd = 182651, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___TakeDamage_3505310624(float damage, bool flinch = true, bool playBloodMist = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref damage;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref flinch;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref playBloodMist;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerHealth.NativeMethodInfoPtr_RpcLogic___TakeDamage_3505310624_Public_Void_Single_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005472 RID: 21618 RVA: 0x001906E4 File Offset: 0x0018E8E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 182652, XrefRangeEnd = 182655, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_TakeDamage_3505310624(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerHealth.NativeMethodInfoPtr_RpcReader___Observers_TakeDamage_3505310624_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005473 RID: 21619 RVA: 0x00190734 File Offset: 0x0018E934
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 182655, XrefRangeEnd = 182664, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_SendDie_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerHealth.NativeMethodInfoPtr_RpcWriter___Server_SendDie_2166136261_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005474 RID: 21620 RVA: 0x00190768 File Offset: 0x0018E968
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 182538, RefRangeEnd = 182540, XrefRangeStart = 182538, XrefRangeEnd = 182540, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SendDie_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerHealth.NativeMethodInfoPtr_RpcLogic___SendDie_2166136261_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005475 RID: 21621 RVA: 0x0019079C File Offset: 0x0018E99C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 182664, XrefRangeEnd = 182667, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_SendDie_2166136261(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerHealth.NativeMethodInfoPtr_RpcReader___Server_SendDie_2166136261_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005476 RID: 21622 RVA: 0x00190800 File Offset: 0x0018EA00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 182667, XrefRangeEnd = 182676, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_Die_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerHealth.NativeMethodInfoPtr_RpcWriter___Observers_Die_2166136261_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005477 RID: 21623 RVA: 0x00190834 File Offset: 0x0018EA34
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 182696, RefRangeEnd = 182699, XrefRangeStart = 182676, XrefRangeEnd = 182696, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___Die_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerHealth.NativeMethodInfoPtr_RpcLogic___Die_2166136261_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005478 RID: 21624 RVA: 0x00190868 File Offset: 0x0018EA68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 182699, XrefRangeEnd = 182702, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_Die_2166136261(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerHealth.NativeMethodInfoPtr_RpcReader___Observers_Die_2166136261_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005479 RID: 21625 RVA: 0x001908B8 File Offset: 0x0018EAB8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 182726, RefRangeEnd = 182727, XrefRangeStart = 182702, XrefRangeEnd = 182726, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_SendRevive_3848837105(Vector3 position, Quaternion rotation)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref position;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rotation;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerHealth.NativeMethodInfoPtr_RpcWriter___Server_SendRevive_3848837105_Private_Void_Vector3_Quaternion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600547A RID: 21626 RVA: 0x00190904 File Offset: 0x0018EB04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SendRevive_3848837105(Vector3 position, Quaternion rotation)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref position;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rotation;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerHealth.NativeMethodInfoPtr_RpcLogic___SendRevive_3848837105_Public_Void_Vector3_Quaternion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600547B RID: 21627 RVA: 0x00190950 File Offset: 0x0018EB50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 182727, XrefRangeEnd = 182736, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_SendRevive_3848837105(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerHealth.NativeMethodInfoPtr_RpcReader___Server_SendRevive_3848837105_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600547C RID: 21628 RVA: 0x001909B4 File Offset: 0x0018EBB4
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 182760, RefRangeEnd = 182764, XrefRangeStart = 182736, XrefRangeEnd = 182760, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_Revive_3848837105(Vector3 position, Quaternion rotation)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref position;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rotation;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerHealth.NativeMethodInfoPtr_RpcWriter___Observers_Revive_3848837105_Private_Void_Vector3_Quaternion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600547D RID: 21629 RVA: 0x00190A00 File Offset: 0x0018EC00
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 182795, RefRangeEnd = 182800, XrefRangeStart = 182764, XrefRangeEnd = 182795, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___Revive_3848837105(Vector3 position, Quaternion rotation)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref position;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rotation;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerHealth.NativeMethodInfoPtr_RpcLogic___Revive_3848837105_Public_Void_Vector3_Quaternion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600547E RID: 21630 RVA: 0x00190A4C File Offset: 0x0018EC4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 182800, XrefRangeEnd = 182808, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_Revive_3848837105(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerHealth.NativeMethodInfoPtr_RpcReader___Observers_Revive_3848837105_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600547F RID: 21631 RVA: 0x00190A9C File Offset: 0x0018EC9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_PlayBloodMist_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerHealth.NativeMethodInfoPtr_RpcWriter___Observers_PlayBloodMist_2166136261_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005480 RID: 21632 RVA: 0x00190AD0 File Offset: 0x0018ECD0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 182808, XrefRangeEnd = 182815, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___PlayBloodMist_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerHealth.NativeMethodInfoPtr_RpcLogic___PlayBloodMist_2166136261_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005481 RID: 21633 RVA: 0x00190B04 File Offset: 0x0018ED04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 182815, XrefRangeEnd = 182822, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_PlayBloodMist_2166136261(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerHealth.NativeMethodInfoPtr_RpcReader___Observers_PlayBloodMist_2166136261_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005482 RID: 21634 RVA: 0x00190B54 File Offset: 0x0018ED54
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 182822, XrefRangeEnd = 182834, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Method_Private_Void_PDM_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerHealth.NativeMethodInfoPtr_Method_Private_Void_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005483 RID: 21635 RVA: 0x000280BB File Offset: 0x000262BB
		public PlayerHealth(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001943 RID: 6467
		// (get) Token: 0x06005484 RID: 21636 RVA: 0x00190B88 File Offset: 0x0018ED88
		// (set) Token: 0x06005485 RID: 21637 RVA: 0x000280C4 File Offset: 0x000262C4
		public unsafe static float MAX_HEALTH
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(PlayerHealth.NativeFieldInfoPtr_MAX_HEALTH, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PlayerHealth.NativeFieldInfoPtr_MAX_HEALTH, (void*)(&value));
			}
		}

		// Token: 0x17001944 RID: 6468
		// (get) Token: 0x06005486 RID: 21638 RVA: 0x00190BA4 File Offset: 0x0018EDA4
		// (set) Token: 0x06005487 RID: 21639 RVA: 0x000280D2 File Offset: 0x000262D2
		public unsafe static float HEALTH_RECOVERY_PER_MINUTE
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(PlayerHealth.NativeFieldInfoPtr_HEALTH_RECOVERY_PER_MINUTE, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PlayerHealth.NativeFieldInfoPtr_HEALTH_RECOVERY_PER_MINUTE, (void*)(&value));
			}
		}

		// Token: 0x17001945 RID: 6469
		// (get) Token: 0x06005488 RID: 21640 RVA: 0x00190BC0 File Offset: 0x0018EDC0
		// (set) Token: 0x06005489 RID: 21641 RVA: 0x000280E0 File Offset: 0x000262E0
		public unsafe bool _IsAlive_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerHealth.NativeFieldInfoPtr__IsAlive_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerHealth.NativeFieldInfoPtr__IsAlive_k__BackingField)) = value;
			}
		}

		// Token: 0x17001946 RID: 6470
		// (get) Token: 0x0600548A RID: 21642 RVA: 0x00190BE8 File Offset: 0x0018EDE8
		// (set) Token: 0x0600548B RID: 21643 RVA: 0x000280FB File Offset: 0x000262FB
		public unsafe float _CurrentHealth_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerHealth.NativeFieldInfoPtr__CurrentHealth_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerHealth.NativeFieldInfoPtr__CurrentHealth_k__BackingField)) = value;
			}
		}

		// Token: 0x17001947 RID: 6471
		// (get) Token: 0x0600548C RID: 21644 RVA: 0x00190C10 File Offset: 0x0018EE10
		// (set) Token: 0x0600548D RID: 21645 RVA: 0x00028116 File Offset: 0x00026316
		public unsafe float _TimeSinceLastDamage_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerHealth.NativeFieldInfoPtr__TimeSinceLastDamage_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerHealth.NativeFieldInfoPtr__TimeSinceLastDamage_k__BackingField)) = value;
			}
		}

		// Token: 0x17001948 RID: 6472
		// (get) Token: 0x0600548E RID: 21646 RVA: 0x00190C38 File Offset: 0x0018EE38
		// (set) Token: 0x0600548F RID: 21647 RVA: 0x00028131 File Offset: 0x00026331
		public unsafe Player Player
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerHealth.NativeFieldInfoPtr_Player);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Player>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerHealth.NativeFieldInfoPtr_Player), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001949 RID: 6473
		// (get) Token: 0x06005490 RID: 21648 RVA: 0x00190C68 File Offset: 0x0018EE68
		// (set) Token: 0x06005491 RID: 21649 RVA: 0x00028150 File Offset: 0x00026350
		public unsafe ParticleSystem BloodParticles
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerHealth.NativeFieldInfoPtr_BloodParticles);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ParticleSystem>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerHealth.NativeFieldInfoPtr_BloodParticles), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700194A RID: 6474
		// (get) Token: 0x06005492 RID: 21650 RVA: 0x00190C98 File Offset: 0x0018EE98
		// (set) Token: 0x06005493 RID: 21651 RVA: 0x0002816F File Offset: 0x0002636F
		public unsafe UnityEvent<float> onHealthChanged
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerHealth.NativeFieldInfoPtr_onHealthChanged);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent<float>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerHealth.NativeFieldInfoPtr_onHealthChanged), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700194B RID: 6475
		// (get) Token: 0x06005494 RID: 21652 RVA: 0x00190CC8 File Offset: 0x0018EEC8
		// (set) Token: 0x06005495 RID: 21653 RVA: 0x0002818E File Offset: 0x0002638E
		public unsafe UnityEvent onDie
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerHealth.NativeFieldInfoPtr_onDie);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerHealth.NativeFieldInfoPtr_onDie), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700194C RID: 6476
		// (get) Token: 0x06005496 RID: 21654 RVA: 0x00190CF8 File Offset: 0x0018EEF8
		// (set) Token: 0x06005497 RID: 21655 RVA: 0x000281AD File Offset: 0x000263AD
		public unsafe UnityEvent onRevive
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerHealth.NativeFieldInfoPtr_onRevive);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerHealth.NativeFieldInfoPtr_onRevive), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700194D RID: 6477
		// (get) Token: 0x06005498 RID: 21656 RVA: 0x00190D28 File Offset: 0x0018EF28
		// (set) Token: 0x06005499 RID: 21657 RVA: 0x000281CC File Offset: 0x000263CC
		public unsafe bool AfflictedWithLethalEffect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerHealth.NativeFieldInfoPtr_AfflictedWithLethalEffect);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerHealth.NativeFieldInfoPtr_AfflictedWithLethalEffect)) = value;
			}
		}

		// Token: 0x1700194E RID: 6478
		// (get) Token: 0x0600549A RID: 21658 RVA: 0x00190D50 File Offset: 0x0018EF50
		// (set) Token: 0x0600549B RID: 21659 RVA: 0x000281E7 File Offset: 0x000263E7
		public unsafe bool field_Private_Boolean_0
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerHealth.NativeFieldInfoPtr_field_Private_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerHealth.NativeFieldInfoPtr_field_Private_Boolean_0)) = value;
			}
		}

		// Token: 0x1700194F RID: 6479
		// (get) Token: 0x0600549C RID: 21660 RVA: 0x00190D78 File Offset: 0x0018EF78
		// (set) Token: 0x0600549D RID: 21661 RVA: 0x00028202 File Offset: 0x00026402
		public unsafe bool field_Private_Boolean_1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerHealth.NativeFieldInfoPtr_field_Private_Boolean_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerHealth.NativeFieldInfoPtr_field_Private_Boolean_1)) = value;
			}
		}

		// Token: 0x04003925 RID: 14629
		private static readonly IntPtr NativeFieldInfoPtr_MAX_HEALTH;

		// Token: 0x04003926 RID: 14630
		private static readonly IntPtr NativeFieldInfoPtr_HEALTH_RECOVERY_PER_MINUTE;

		// Token: 0x04003927 RID: 14631
		private static readonly IntPtr NativeFieldInfoPtr__IsAlive_k__BackingField;

		// Token: 0x04003928 RID: 14632
		private static readonly IntPtr NativeFieldInfoPtr__CurrentHealth_k__BackingField;

		// Token: 0x04003929 RID: 14633
		private static readonly IntPtr NativeFieldInfoPtr__TimeSinceLastDamage_k__BackingField;

		// Token: 0x0400392A RID: 14634
		private static readonly IntPtr NativeFieldInfoPtr_Player;

		// Token: 0x0400392B RID: 14635
		private static readonly IntPtr NativeFieldInfoPtr_BloodParticles;

		// Token: 0x0400392C RID: 14636
		private static readonly IntPtr NativeFieldInfoPtr_onHealthChanged;

		// Token: 0x0400392D RID: 14637
		private static readonly IntPtr NativeFieldInfoPtr_onDie;

		// Token: 0x0400392E RID: 14638
		private static readonly IntPtr NativeFieldInfoPtr_onRevive;

		// Token: 0x0400392F RID: 14639
		private static readonly IntPtr NativeFieldInfoPtr_AfflictedWithLethalEffect;

		// Token: 0x04003930 RID: 14640
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

		// Token: 0x04003931 RID: 14641
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

		// Token: 0x04003932 RID: 14642
		private static readonly IntPtr NativeMethodInfoPtr_get_IsAlive_Public_get_Boolean_0;

		// Token: 0x04003933 RID: 14643
		private static readonly IntPtr NativeMethodInfoPtr_set_IsAlive_Protected_set_Void_Boolean_0;

		// Token: 0x04003934 RID: 14644
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentHealth_Public_get_Single_0;

		// Token: 0x04003935 RID: 14645
		private static readonly IntPtr NativeMethodInfoPtr_set_CurrentHealth_Protected_set_Void_Single_0;

		// Token: 0x04003936 RID: 14646
		private static readonly IntPtr NativeMethodInfoPtr_get_TimeSinceLastDamage_Public_get_Single_0;

		// Token: 0x04003937 RID: 14647
		private static readonly IntPtr NativeMethodInfoPtr_set_TimeSinceLastDamage_Protected_set_Void_Single_0;

		// Token: 0x04003938 RID: 14648
		private static readonly IntPtr NativeMethodInfoPtr_get_CanTakeDamage_Public_get_Boolean_0;

		// Token: 0x04003939 RID: 14649
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;

		// Token: 0x0400393A RID: 14650
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x0400393B RID: 14651
		private static readonly IntPtr NativeMethodInfoPtr_TakeDamage_Public_Void_Single_Boolean_Boolean_0;

		// Token: 0x0400393C RID: 14652
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x0400393D RID: 14653
		private static readonly IntPtr NativeMethodInfoPtr_MinPass_Private_Void_0;

		// Token: 0x0400393E RID: 14654
		private static readonly IntPtr NativeMethodInfoPtr_SetAfflictedWithLethalEffect_Public_Void_Boolean_0;

		// Token: 0x0400393F RID: 14655
		private static readonly IntPtr NativeMethodInfoPtr_RecoverHealth_Public_Void_Single_0;

		// Token: 0x04003940 RID: 14656
		private static readonly IntPtr NativeMethodInfoPtr_SetHealth_Public_Void_Single_0;

		// Token: 0x04003941 RID: 14657
		private static readonly IntPtr NativeMethodInfoPtr_SendDie_Public_Void_0;

		// Token: 0x04003942 RID: 14658
		private static readonly IntPtr NativeMethodInfoPtr_Die_Public_Void_0;

		// Token: 0x04003943 RID: 14659
		private static readonly IntPtr NativeMethodInfoPtr_SendRevive_Public_Void_Vector3_Quaternion_0;

		// Token: 0x04003944 RID: 14660
		private static readonly IntPtr NativeMethodInfoPtr_Revive_Public_Void_Vector3_Quaternion_0;

		// Token: 0x04003945 RID: 14661
		private static readonly IntPtr NativeMethodInfoPtr_PlayBloodMist_Public_Void_0;

		// Token: 0x04003946 RID: 14662
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04003947 RID: 14663
		private static readonly IntPtr NativeMethodInfoPtr__Awake_b__22_0_Private_Void_0;

		// Token: 0x04003948 RID: 14664
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

		// Token: 0x04003949 RID: 14665
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

		// Token: 0x0400394A RID: 14666
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

		// Token: 0x0400394B RID: 14667
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_TakeDamage_3505310624_Private_Void_Single_Boolean_Boolean_0;

		// Token: 0x0400394C RID: 14668
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___TakeDamage_3505310624_Public_Void_Single_Boolean_Boolean_0;

		// Token: 0x0400394D RID: 14669
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_TakeDamage_3505310624_Private_Void_PooledReader_Channel_0;

		// Token: 0x0400394E RID: 14670
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_SendDie_2166136261_Private_Void_0;

		// Token: 0x0400394F RID: 14671
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SendDie_2166136261_Public_Void_0;

		// Token: 0x04003950 RID: 14672
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_SendDie_2166136261_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x04003951 RID: 14673
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_Die_2166136261_Private_Void_0;

		// Token: 0x04003952 RID: 14674
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___Die_2166136261_Public_Void_0;

		// Token: 0x04003953 RID: 14675
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_Die_2166136261_Private_Void_PooledReader_Channel_0;

		// Token: 0x04003954 RID: 14676
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_SendRevive_3848837105_Private_Void_Vector3_Quaternion_0;

		// Token: 0x04003955 RID: 14677
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SendRevive_3848837105_Public_Void_Vector3_Quaternion_0;

		// Token: 0x04003956 RID: 14678
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_SendRevive_3848837105_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x04003957 RID: 14679
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_Revive_3848837105_Private_Void_Vector3_Quaternion_0;

		// Token: 0x04003958 RID: 14680
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___Revive_3848837105_Public_Void_Vector3_Quaternion_0;

		// Token: 0x04003959 RID: 14681
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_Revive_3848837105_Private_Void_PooledReader_Channel_0;

		// Token: 0x0400395A RID: 14682
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_PlayBloodMist_2166136261_Private_Void_0;

		// Token: 0x0400395B RID: 14683
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___PlayBloodMist_2166136261_Public_Void_0;

		// Token: 0x0400395C RID: 14684
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_PlayBloodMist_2166136261_Private_Void_PooledReader_Channel_0;

		// Token: 0x0400395D RID: 14685
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Void_PDM_0;
	}
}
