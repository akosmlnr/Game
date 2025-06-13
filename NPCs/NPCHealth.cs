using System;
using Il2CppFishNet.Object;
using Il2CppFishNet.Object.Synchronizing;
using Il2CppFishNet.Serializing;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Persistence.Datas;
using UnityEngine.Events;

namespace Il2CppScheduleOne.NPCs
{
	// Token: 0x020002F7 RID: 759
	public class NPCHealth : NetworkBehaviour
	{
		// Token: 0x060035AF RID: 13743 RVA: 0x0011FF1C File Offset: 0x0011E11C
		// Note: this type is marked as 'beforefieldinit'.
		static NPCHealth()
		{
			Il2CppClassPointerStore<NPCHealth>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.NPCs", "NPCHealth");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NPCHealth>.NativeClassPtr);
			NPCHealth.NativeFieldInfoPtr_REVIVE_DAYS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCHealth>.NativeClassPtr, "REVIVE_DAYS");
			NPCHealth.NativeFieldInfoPtr__Health_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCHealth>.NativeClassPtr, "<Health>k__BackingField");
			NPCHealth.NativeFieldInfoPtr__IsDead_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCHealth>.NativeClassPtr, "<IsDead>k__BackingField");
			NPCHealth.NativeFieldInfoPtr__IsKnockedOut_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCHealth>.NativeClassPtr, "<IsKnockedOut>k__BackingField");
			NPCHealth.NativeFieldInfoPtr__DaysPassedSinceDeath_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCHealth>.NativeClassPtr, "<DaysPassedSinceDeath>k__BackingField");
			NPCHealth.NativeFieldInfoPtr_Invincible = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCHealth>.NativeClassPtr, "Invincible");
			NPCHealth.NativeFieldInfoPtr_MaxHealth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCHealth>.NativeClassPtr, "MaxHealth");
			NPCHealth.NativeFieldInfoPtr_npc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCHealth>.NativeClassPtr, "npc");
			NPCHealth.NativeFieldInfoPtr_onDie = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCHealth>.NativeClassPtr, "onDie");
			NPCHealth.NativeFieldInfoPtr_onKnockedOut = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCHealth>.NativeClassPtr, "onKnockedOut");
			NPCHealth.NativeFieldInfoPtr_AfflictedWithLethalEffect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCHealth>.NativeClassPtr, "AfflictedWithLethalEffect");
			NPCHealth.NativeFieldInfoPtr_syncVar____Health_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCHealth>.NativeClassPtr, "syncVar___<Health>k__BackingField");
			NPCHealth.NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCHealth>.NativeClassPtr, "NetworkInitialize___EarlyScheduleOne.NPCs.NPCHealthAssembly-CSharp.dll_Excuted");
			NPCHealth.NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCHealth>.NativeClassPtr, "NetworkInitialize__LateScheduleOne.NPCs.NPCHealthAssembly-CSharp.dll_Excuted");
			NPCHealth.NativeMethodInfoPtr_get_Health_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCHealth>.NativeClassPtr, 100669438);
			NPCHealth.NativeMethodInfoPtr_set_Health_Private_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCHealth>.NativeClassPtr, 100669439);
			NPCHealth.NativeMethodInfoPtr_get_IsDead_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCHealth>.NativeClassPtr, 100669440);
			NPCHealth.NativeMethodInfoPtr_set_IsDead_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCHealth>.NativeClassPtr, 100669441);
			NPCHealth.NativeMethodInfoPtr_get_IsKnockedOut_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCHealth>.NativeClassPtr, 100669442);
			NPCHealth.NativeMethodInfoPtr_set_IsKnockedOut_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCHealth>.NativeClassPtr, 100669443);
			NPCHealth.NativeMethodInfoPtr_get_DaysPassedSinceDeath_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCHealth>.NativeClassPtr, 100669444);
			NPCHealth.NativeMethodInfoPtr_set_DaysPassedSinceDeath_Private_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCHealth>.NativeClassPtr, 100669445);
			NPCHealth.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCHealth>.NativeClassPtr, 100669446);
			NPCHealth.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCHealth>.NativeClassPtr, 100669447);
			NPCHealth.NativeMethodInfoPtr_OnStartServer_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCHealth>.NativeClassPtr, 100669448);
			NPCHealth.NativeMethodInfoPtr_Load_Public_Void_NPCHealthData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCHealth>.NativeClassPtr, 100669449);
			NPCHealth.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCHealth>.NativeClassPtr, 100669450);
			NPCHealth.NativeMethodInfoPtr_SetAfflictedWithLethalEffect_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCHealth>.NativeClassPtr, 100669451);
			NPCHealth.NativeMethodInfoPtr_SleepStart_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCHealth>.NativeClassPtr, 100669452);
			NPCHealth.NativeMethodInfoPtr_TakeDamage_Public_Void_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCHealth>.NativeClassPtr, 100669453);
			NPCHealth.NativeMethodInfoPtr_Die_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCHealth>.NativeClassPtr, 100669454);
			NPCHealth.NativeMethodInfoPtr_KnockOut_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCHealth>.NativeClassPtr, 100669455);
			NPCHealth.NativeMethodInfoPtr_Revive_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCHealth>.NativeClassPtr, 100669456);
			NPCHealth.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCHealth>.NativeClassPtr, 100669457);
			NPCHealth.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCHealth>.NativeClassPtr, 100669458);
			NPCHealth.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCHealth>.NativeClassPtr, 100669459);
			NPCHealth.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCHealth>.NativeClassPtr, 100669460);
			NPCHealth.NativeMethodInfoPtr_sync___get_value__Health_k__BackingField_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCHealth>.NativeClassPtr, 100669461);
			NPCHealth.NativeMethodInfoPtr_sync___set_value__Health_k__BackingField_Public_set_Void_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCHealth>.NativeClassPtr, 100669462);
			NPCHealth.NativeMethodInfoPtr_ReadSyncVar___ScheduleOne_NPCs_NPCHealth_Public_Virtual_Boolean_PooledReader_UInt32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCHealth>.NativeClassPtr, 100669463);
			NPCHealth.NativeMethodInfoPtr_Method_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCHealth>.NativeClassPtr, 100669464);
		}

		// Token: 0x17001139 RID: 4409
		// (get) Token: 0x060035B0 RID: 13744 RVA: 0x00120280 File Offset: 0x0011E480
		// (set) Token: 0x060035B1 RID: 13745 RVA: 0x001202BC File Offset: 0x0011E4BC
		public unsafe float Health
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 97015, RefRangeEnd = 97018, XrefRangeStart = 97015, XrefRangeEnd = 97018, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NPCHealth.NativeMethodInfoPtr_get_Health_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 140718, RefRangeEnd = 140724, XrefRangeStart = 140711, XrefRangeEnd = 140718, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCHealth.NativeMethodInfoPtr_set_Health_Private_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x1700113A RID: 4410
		// (get) Token: 0x060035B2 RID: 13746 RVA: 0x001202FC File Offset: 0x0011E4FC
		// (set) Token: 0x060035B3 RID: 13747 RVA: 0x00120338 File Offset: 0x0011E538
		public unsafe bool IsDead
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NPCHealth.NativeMethodInfoPtr_get_IsDead_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCHealth.NativeMethodInfoPtr_set_IsDead_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x1700113B RID: 4411
		// (get) Token: 0x060035B4 RID: 13748 RVA: 0x00120378 File Offset: 0x0011E578
		// (set) Token: 0x060035B5 RID: 13749 RVA: 0x001203B4 File Offset: 0x0011E5B4
		public unsafe bool IsKnockedOut
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NPCHealth.NativeMethodInfoPtr_get_IsKnockedOut_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCHealth.NativeMethodInfoPtr_set_IsKnockedOut_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x1700113C RID: 4412
		// (get) Token: 0x060035B6 RID: 13750 RVA: 0x001203F4 File Offset: 0x0011E5F4
		// (set) Token: 0x060035B7 RID: 13751 RVA: 0x00120430 File Offset: 0x0011E630
		public unsafe int DaysPassedSinceDeath
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NPCHealth.NativeMethodInfoPtr_get_DaysPassedSinceDeath_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCHealth.NativeMethodInfoPtr_set_DaysPassedSinceDeath_Private_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x060035B8 RID: 13752 RVA: 0x00120470 File Offset: 0x0011E670
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 140724, XrefRangeEnd = 140725, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCHealth.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060035B9 RID: 13753 RVA: 0x001204AC File Offset: 0x0011E6AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 140725, XrefRangeEnd = 140743, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCHealth.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060035BA RID: 13754 RVA: 0x001204E0 File Offset: 0x0011E6E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 140743, XrefRangeEnd = 140745, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnStartServer()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCHealth.NativeMethodInfoPtr_OnStartServer_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060035BB RID: 13755 RVA: 0x0012051C File Offset: 0x0011E71C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 140746, RefRangeEnd = 140748, XrefRangeStart = 140745, XrefRangeEnd = 140746, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Load(NPCHealthData healthData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(healthData);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCHealth.NativeMethodInfoPtr_Load_Public_Void_NPCHealthData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060035BC RID: 13756 RVA: 0x00120560 File Offset: 0x0011E760
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 140748, XrefRangeEnd = 140750, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCHealth.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060035BD RID: 13757 RVA: 0x00120594 File Offset: 0x0011E794
		[CallerCount(0)]
		public unsafe void SetAfflictedWithLethalEffect(bool value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref value;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCHealth.NativeMethodInfoPtr_SetAfflictedWithLethalEffect_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060035BE RID: 13758 RVA: 0x001205D4 File Offset: 0x0011E7D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 140750, XrefRangeEnd = 140766, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SleepStart()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCHealth.NativeMethodInfoPtr_SleepStart_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060035BF RID: 13759 RVA: 0x00120608 File Offset: 0x0011E808
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 140779, RefRangeEnd = 140781, XrefRangeStart = 140766, XrefRangeEnd = 140779, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void TakeDamage(float damage, bool isLethal = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref damage;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isLethal;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCHealth.NativeMethodInfoPtr_TakeDamage_Public_Void_Single_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060035C0 RID: 13760 RVA: 0x00120654 File Offset: 0x0011E854
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 140781, XrefRangeEnd = 140791, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Die()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCHealth.NativeMethodInfoPtr_Die_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060035C1 RID: 13761 RVA: 0x00120690 File Offset: 0x0011E890
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 140791, XrefRangeEnd = 140801, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void KnockOut()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCHealth.NativeMethodInfoPtr_KnockOut_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060035C2 RID: 13762 RVA: 0x001206CC File Offset: 0x0011E8CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 140801, XrefRangeEnd = 140813, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Revive()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCHealth.NativeMethodInfoPtr_Revive_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060035C3 RID: 13763 RVA: 0x00120708 File Offset: 0x0011E908
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 140813, XrefRangeEnd = 140814, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NPCHealth() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NPCHealth>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCHealth.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060035C4 RID: 13764 RVA: 0x00120744 File Offset: 0x0011E944
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 140814, XrefRangeEnd = 140830, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void NetworkInitialize___Early()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCHealth.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060035C5 RID: 13765 RVA: 0x00120780 File Offset: 0x0011E980
		[CallerCount(0)]
		public unsafe virtual void NetworkInitialize__Late()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCHealth.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060035C6 RID: 13766 RVA: 0x001207BC File Offset: 0x0011E9BC
		[CallerCount(0)]
		public unsafe override void NetworkInitializeIfDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCHealth.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x1700113D RID: 4413
		// (get) Token: 0x060035C7 RID: 13767 RVA: 0x001207F8 File Offset: 0x0011E9F8
		// (set) Token: 0x060035C8 RID: 13768 RVA: 0x00120834 File Offset: 0x0011EA34
		public unsafe float SyncAccessor_<Health>k__BackingField
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 97015, RefRangeEnd = 97018, XrefRangeStart = 97015, XrefRangeEnd = 97018, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NPCHealth.NativeMethodInfoPtr_sync___get_value__Health_k__BackingField_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 140830, XrefRangeEnd = 140838, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCHealth.NativeMethodInfoPtr_sync___set_value__Health_k__BackingField_Public_set_Void_Single_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x060035C9 RID: 13769 RVA: 0x00120880 File Offset: 0x0011EA80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 140838, XrefRangeEnd = 140839, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool ReadSyncVar___ScheduleOne_NPCs_NPCHealth(PooledReader PooledReader0, uint UInt321, bool Boolean2)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref UInt321;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref Boolean2;
			IntPtr returnedException;
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCHealth.NativeMethodInfoPtr_ReadSyncVar___ScheduleOne_NPCs_NPCHealth_Public_Virtual_Boolean_PooledReader_UInt32_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x060035CA RID: 13770 RVA: 0x001208F4 File Offset: 0x0011EAF4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 140876, RefRangeEnd = 140877, XrefRangeStart = 140839, XrefRangeEnd = 140876, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Method_Protected_Virtual_New_Void_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCHealth.NativeMethodInfoPtr_Method_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060035CB RID: 13771 RVA: 0x0001C23E File Offset: 0x0001A43E
		public NPCHealth(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700112B RID: 4395
		// (get) Token: 0x060035CC RID: 13772 RVA: 0x00120930 File Offset: 0x0011EB30
		// (set) Token: 0x060035CD RID: 13773 RVA: 0x0001C247 File Offset: 0x0001A447
		public unsafe static int REVIVE_DAYS
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(NPCHealth.NativeFieldInfoPtr_REVIVE_DAYS, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NPCHealth.NativeFieldInfoPtr_REVIVE_DAYS, (void*)(&value));
			}
		}

		// Token: 0x1700112C RID: 4396
		// (get) Token: 0x060035CE RID: 13774 RVA: 0x0012094C File Offset: 0x0011EB4C
		// (set) Token: 0x060035CF RID: 13775 RVA: 0x0001C255 File Offset: 0x0001A455
		public unsafe float _Health_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCHealth.NativeFieldInfoPtr__Health_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCHealth.NativeFieldInfoPtr__Health_k__BackingField)) = value;
			}
		}

		// Token: 0x1700112D RID: 4397
		// (get) Token: 0x060035D0 RID: 13776 RVA: 0x00120974 File Offset: 0x0011EB74
		// (set) Token: 0x060035D1 RID: 13777 RVA: 0x0001C270 File Offset: 0x0001A470
		public unsafe bool _IsDead_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCHealth.NativeFieldInfoPtr__IsDead_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCHealth.NativeFieldInfoPtr__IsDead_k__BackingField)) = value;
			}
		}

		// Token: 0x1700112E RID: 4398
		// (get) Token: 0x060035D2 RID: 13778 RVA: 0x0012099C File Offset: 0x0011EB9C
		// (set) Token: 0x060035D3 RID: 13779 RVA: 0x0001C28B File Offset: 0x0001A48B
		public unsafe bool _IsKnockedOut_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCHealth.NativeFieldInfoPtr__IsKnockedOut_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCHealth.NativeFieldInfoPtr__IsKnockedOut_k__BackingField)) = value;
			}
		}

		// Token: 0x1700112F RID: 4399
		// (get) Token: 0x060035D4 RID: 13780 RVA: 0x001209C4 File Offset: 0x0011EBC4
		// (set) Token: 0x060035D5 RID: 13781 RVA: 0x0001C2A6 File Offset: 0x0001A4A6
		public unsafe int _DaysPassedSinceDeath_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCHealth.NativeFieldInfoPtr__DaysPassedSinceDeath_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCHealth.NativeFieldInfoPtr__DaysPassedSinceDeath_k__BackingField)) = value;
			}
		}

		// Token: 0x17001130 RID: 4400
		// (get) Token: 0x060035D6 RID: 13782 RVA: 0x001209EC File Offset: 0x0011EBEC
		// (set) Token: 0x060035D7 RID: 13783 RVA: 0x0001C2C1 File Offset: 0x0001A4C1
		public unsafe bool Invincible
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCHealth.NativeFieldInfoPtr_Invincible);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCHealth.NativeFieldInfoPtr_Invincible)) = value;
			}
		}

		// Token: 0x17001131 RID: 4401
		// (get) Token: 0x060035D8 RID: 13784 RVA: 0x00120A14 File Offset: 0x0011EC14
		// (set) Token: 0x060035D9 RID: 13785 RVA: 0x0001C2DC File Offset: 0x0001A4DC
		public unsafe float MaxHealth
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCHealth.NativeFieldInfoPtr_MaxHealth);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCHealth.NativeFieldInfoPtr_MaxHealth)) = value;
			}
		}

		// Token: 0x17001132 RID: 4402
		// (get) Token: 0x060035DA RID: 13786 RVA: 0x00120A3C File Offset: 0x0011EC3C
		// (set) Token: 0x060035DB RID: 13787 RVA: 0x0001C2F7 File Offset: 0x0001A4F7
		public unsafe NPC npc
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCHealth.NativeFieldInfoPtr_npc);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NPC>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCHealth.NativeFieldInfoPtr_npc), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001133 RID: 4403
		// (get) Token: 0x060035DC RID: 13788 RVA: 0x00120A6C File Offset: 0x0011EC6C
		// (set) Token: 0x060035DD RID: 13789 RVA: 0x0001C316 File Offset: 0x0001A516
		public unsafe UnityEvent onDie
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCHealth.NativeFieldInfoPtr_onDie);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCHealth.NativeFieldInfoPtr_onDie), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001134 RID: 4404
		// (get) Token: 0x060035DE RID: 13790 RVA: 0x00120A9C File Offset: 0x0011EC9C
		// (set) Token: 0x060035DF RID: 13791 RVA: 0x0001C335 File Offset: 0x0001A535
		public unsafe UnityEvent onKnockedOut
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCHealth.NativeFieldInfoPtr_onKnockedOut);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCHealth.NativeFieldInfoPtr_onKnockedOut), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001135 RID: 4405
		// (get) Token: 0x060035E0 RID: 13792 RVA: 0x00120ACC File Offset: 0x0011ECCC
		// (set) Token: 0x060035E1 RID: 13793 RVA: 0x0001C354 File Offset: 0x0001A554
		public unsafe bool AfflictedWithLethalEffect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCHealth.NativeFieldInfoPtr_AfflictedWithLethalEffect);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCHealth.NativeFieldInfoPtr_AfflictedWithLethalEffect)) = value;
			}
		}

		// Token: 0x17001136 RID: 4406
		// (get) Token: 0x060035E2 RID: 13794 RVA: 0x00120AF4 File Offset: 0x0011ECF4
		// (set) Token: 0x060035E3 RID: 13795 RVA: 0x0001C36F File Offset: 0x0001A56F
		public unsafe SyncVar<float> syncVar____Health_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCHealth.NativeFieldInfoPtr_syncVar____Health_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SyncVar<float>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCHealth.NativeFieldInfoPtr_syncVar____Health_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001137 RID: 4407
		// (get) Token: 0x060035E4 RID: 13796 RVA: 0x00120B24 File Offset: 0x0011ED24
		// (set) Token: 0x060035E5 RID: 13797 RVA: 0x0001C38E File Offset: 0x0001A58E
		public unsafe bool field_Private_Boolean_0
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCHealth.NativeFieldInfoPtr_field_Private_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCHealth.NativeFieldInfoPtr_field_Private_Boolean_0)) = value;
			}
		}

		// Token: 0x17001138 RID: 4408
		// (get) Token: 0x060035E6 RID: 13798 RVA: 0x00120B4C File Offset: 0x0011ED4C
		// (set) Token: 0x060035E7 RID: 13799 RVA: 0x0001C3A9 File Offset: 0x0001A5A9
		public unsafe bool field_Private_Boolean_1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCHealth.NativeFieldInfoPtr_field_Private_Boolean_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCHealth.NativeFieldInfoPtr_field_Private_Boolean_1)) = value;
			}
		}

		// Token: 0x040022FA RID: 8954
		private static readonly IntPtr NativeFieldInfoPtr_REVIVE_DAYS;

		// Token: 0x040022FB RID: 8955
		private static readonly IntPtr NativeFieldInfoPtr__Health_k__BackingField;

		// Token: 0x040022FC RID: 8956
		private static readonly IntPtr NativeFieldInfoPtr__IsDead_k__BackingField;

		// Token: 0x040022FD RID: 8957
		private static readonly IntPtr NativeFieldInfoPtr__IsKnockedOut_k__BackingField;

		// Token: 0x040022FE RID: 8958
		private static readonly IntPtr NativeFieldInfoPtr__DaysPassedSinceDeath_k__BackingField;

		// Token: 0x040022FF RID: 8959
		private static readonly IntPtr NativeFieldInfoPtr_Invincible;

		// Token: 0x04002300 RID: 8960
		private static readonly IntPtr NativeFieldInfoPtr_MaxHealth;

		// Token: 0x04002301 RID: 8961
		private static readonly IntPtr NativeFieldInfoPtr_npc;

		// Token: 0x04002302 RID: 8962
		private static readonly IntPtr NativeFieldInfoPtr_onDie;

		// Token: 0x04002303 RID: 8963
		private static readonly IntPtr NativeFieldInfoPtr_onKnockedOut;

		// Token: 0x04002304 RID: 8964
		private static readonly IntPtr NativeFieldInfoPtr_AfflictedWithLethalEffect;

		// Token: 0x04002305 RID: 8965
		private static readonly IntPtr NativeFieldInfoPtr_syncVar____Health_k__BackingField;

		// Token: 0x04002306 RID: 8966
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

		// Token: 0x04002307 RID: 8967
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

		// Token: 0x04002308 RID: 8968
		private static readonly IntPtr NativeMethodInfoPtr_get_Health_Public_get_Single_0;

		// Token: 0x04002309 RID: 8969
		private static readonly IntPtr NativeMethodInfoPtr_set_Health_Private_set_Void_Single_0;

		// Token: 0x0400230A RID: 8970
		private static readonly IntPtr NativeMethodInfoPtr_get_IsDead_Public_get_Boolean_0;

		// Token: 0x0400230B RID: 8971
		private static readonly IntPtr NativeMethodInfoPtr_set_IsDead_Private_set_Void_Boolean_0;

		// Token: 0x0400230C RID: 8972
		private static readonly IntPtr NativeMethodInfoPtr_get_IsKnockedOut_Public_get_Boolean_0;

		// Token: 0x0400230D RID: 8973
		private static readonly IntPtr NativeMethodInfoPtr_set_IsKnockedOut_Private_set_Void_Boolean_0;

		// Token: 0x0400230E RID: 8974
		private static readonly IntPtr NativeMethodInfoPtr_get_DaysPassedSinceDeath_Public_get_Int32_0;

		// Token: 0x0400230F RID: 8975
		private static readonly IntPtr NativeMethodInfoPtr_set_DaysPassedSinceDeath_Private_set_Void_Int32_0;

		// Token: 0x04002310 RID: 8976
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;

		// Token: 0x04002311 RID: 8977
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

		// Token: 0x04002312 RID: 8978
		private static readonly IntPtr NativeMethodInfoPtr_OnStartServer_Public_Virtual_Void_0;

		// Token: 0x04002313 RID: 8979
		private static readonly IntPtr NativeMethodInfoPtr_Load_Public_Void_NPCHealthData_0;

		// Token: 0x04002314 RID: 8980
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x04002315 RID: 8981
		private static readonly IntPtr NativeMethodInfoPtr_SetAfflictedWithLethalEffect_Public_Void_Boolean_0;

		// Token: 0x04002316 RID: 8982
		private static readonly IntPtr NativeMethodInfoPtr_SleepStart_Public_Void_0;

		// Token: 0x04002317 RID: 8983
		private static readonly IntPtr NativeMethodInfoPtr_TakeDamage_Public_Void_Single_Boolean_0;

		// Token: 0x04002318 RID: 8984
		private static readonly IntPtr NativeMethodInfoPtr_Die_Public_Virtual_New_Void_0;

		// Token: 0x04002319 RID: 8985
		private static readonly IntPtr NativeMethodInfoPtr_KnockOut_Public_Virtual_New_Void_0;

		// Token: 0x0400231A RID: 8986
		private static readonly IntPtr NativeMethodInfoPtr_Revive_Public_Virtual_New_Void_0;

		// Token: 0x0400231B RID: 8987
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400231C RID: 8988
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

		// Token: 0x0400231D RID: 8989
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

		// Token: 0x0400231E RID: 8990
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

		// Token: 0x0400231F RID: 8991
		private static readonly IntPtr NativeMethodInfoPtr_sync___get_value__Health_k__BackingField_Public_get_Single_0;

		// Token: 0x04002320 RID: 8992
		private static readonly IntPtr NativeMethodInfoPtr_sync___set_value__Health_k__BackingField_Public_set_Void_Single_Boolean_0;

		// Token: 0x04002321 RID: 8993
		private static readonly IntPtr NativeMethodInfoPtr_ReadSyncVar___ScheduleOne_NPCs_NPCHealth_Public_Virtual_Boolean_PooledReader_UInt32_Boolean_0;

		// Token: 0x04002322 RID: 8994
		private static readonly IntPtr NativeMethodInfoPtr_Method_Protected_Virtual_New_Void_0;
	}
}
