using System;
using Il2CppFishNet.Connection;
using Il2CppFishNet.Serializing;
using Il2CppFishNet.Transporting;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.Combat
{
	// Token: 0x020004B2 RID: 1202
	public class CombatManager : NetworkSingleton<CombatManager>
	{
		// Token: 0x0600670B RID: 26379 RVA: 0x001D3124 File Offset: 0x001D1324
		// Note: this type is marked as 'beforefieldinit'.
		static CombatManager()
		{
			Il2CppClassPointerStore<CombatManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Combat", "CombatManager");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CombatManager>.NativeClassPtr);
			CombatManager.NativeFieldInfoPtr_MeleeLayerMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombatManager>.NativeClassPtr, "MeleeLayerMask");
			CombatManager.NativeFieldInfoPtr_ExplosionLayerMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombatManager>.NativeClassPtr, "ExplosionLayerMask");
			CombatManager.NativeFieldInfoPtr_RangedWeaponLayerMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombatManager>.NativeClassPtr, "RangedWeaponLayerMask");
			CombatManager.NativeFieldInfoPtr_ExplosionPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombatManager>.NativeClassPtr, "ExplosionPrefab");
			CombatManager.NativeFieldInfoPtr_explosionIDs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombatManager>.NativeClassPtr, "explosionIDs");
			CombatManager.NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombatManager>.NativeClassPtr, "NetworkInitialize___EarlyScheduleOne.Combat.CombatManagerAssembly-CSharp.dll_Excuted");
			CombatManager.NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombatManager>.NativeClassPtr, "NetworkInitialize__LateScheduleOne.Combat.CombatManagerAssembly-CSharp.dll_Excuted");
			CombatManager.NativeMethodInfoPtr_CreateTestExplosion_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatManager>.NativeClassPtr, 100676434);
			CombatManager.NativeMethodInfoPtr_CreateExplosion_Public_Void_Vector3_ExplosionData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatManager>.NativeClassPtr, 100676435);
			CombatManager.NativeMethodInfoPtr_CreateExplosion_Private_Void_Vector3_ExplosionData_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatManager>.NativeClassPtr, 100676436);
			CombatManager.NativeMethodInfoPtr_Explosion_Private_Void_Vector3_ExplosionData_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatManager>.NativeClassPtr, 100676437);
			CombatManager.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatManager>.NativeClassPtr, 100676438);
			CombatManager.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatManager>.NativeClassPtr, 100676439);
			CombatManager.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatManager>.NativeClassPtr, 100676440);
			CombatManager.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatManager>.NativeClassPtr, 100676441);
			CombatManager.NativeMethodInfoPtr_RpcWriter___Server_CreateExplosion_2907189355_Private_Void_Vector3_ExplosionData_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatManager>.NativeClassPtr, 100676442);
			CombatManager.NativeMethodInfoPtr_RpcLogic___CreateExplosion_2907189355_Private_Void_Vector3_ExplosionData_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatManager>.NativeClassPtr, 100676443);
			CombatManager.NativeMethodInfoPtr_RpcReader___Server_CreateExplosion_2907189355_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatManager>.NativeClassPtr, 100676444);
			CombatManager.NativeMethodInfoPtr_RpcWriter___Observers_Explosion_2907189355_Private_Void_Vector3_ExplosionData_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatManager>.NativeClassPtr, 100676445);
			CombatManager.NativeMethodInfoPtr_RpcLogic___Explosion_2907189355_Private_Void_Vector3_ExplosionData_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatManager>.NativeClassPtr, 100676446);
			CombatManager.NativeMethodInfoPtr_RpcReader___Observers_Explosion_2907189355_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatManager>.NativeClassPtr, 100676447);
			CombatManager.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatManager>.NativeClassPtr, 100676448);
		}

		// Token: 0x0600670C RID: 26380 RVA: 0x001D330C File Offset: 0x001D150C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 209962, XrefRangeEnd = 209984, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CreateTestExplosion()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CombatManager.NativeMethodInfoPtr_CreateTestExplosion_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600670D RID: 26381 RVA: 0x001D3340 File Offset: 0x001D1540
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 209986, RefRangeEnd = 209987, XrefRangeStart = 209984, XrefRangeEnd = 209986, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CreateExplosion(Vector3 origin, ExplosionData data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref origin;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref data;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CombatManager.NativeMethodInfoPtr_CreateExplosion_Public_Void_Vector3_ExplosionData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600670E RID: 26382 RVA: 0x001D338C File Offset: 0x001D158C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 210013, RefRangeEnd = 210015, XrefRangeStart = 209987, XrefRangeEnd = 210013, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CreateExplosion(Vector3 origin, ExplosionData data, int id)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref origin;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref data;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref id;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CombatManager.NativeMethodInfoPtr_CreateExplosion_Private_Void_Vector3_ExplosionData_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600670F RID: 26383 RVA: 0x001D33E8 File Offset: 0x001D15E8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 210041, RefRangeEnd = 210044, XrefRangeStart = 210015, XrefRangeEnd = 210041, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Explosion(Vector3 origin, ExplosionData data, int id)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref origin;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref data;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref id;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CombatManager.NativeMethodInfoPtr_Explosion_Private_Void_Vector3_ExplosionData_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006710 RID: 26384 RVA: 0x001D3444 File Offset: 0x001D1644
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 210044, XrefRangeEnd = 210054, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CombatManager() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CombatManager>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CombatManager.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006711 RID: 26385 RVA: 0x001D3480 File Offset: 0x001D1680
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 210054, XrefRangeEnd = 210071, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize___Early()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CombatManager.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006712 RID: 26386 RVA: 0x001D34BC File Offset: 0x001D16BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 210071, XrefRangeEnd = 210074, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize__Late()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CombatManager.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006713 RID: 26387 RVA: 0x001D34F8 File Offset: 0x001D16F8
		[CallerCount(0)]
		public unsafe override void NetworkInitializeIfDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CombatManager.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006714 RID: 26388 RVA: 0x001D3534 File Offset: 0x001D1734
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 210074, XrefRangeEnd = 210089, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_CreateExplosion_2907189355(Vector3 origin, ExplosionData data, int id)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref origin;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref data;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref id;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CombatManager.NativeMethodInfoPtr_RpcWriter___Server_CreateExplosion_2907189355_Private_Void_Vector3_ExplosionData_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006715 RID: 26389 RVA: 0x001D3590 File Offset: 0x001D1790
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 210089, XrefRangeEnd = 210090, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___CreateExplosion_2907189355(Vector3 origin, ExplosionData data, int id)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref origin;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref data;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref id;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CombatManager.NativeMethodInfoPtr_RpcLogic___CreateExplosion_2907189355_Private_Void_Vector3_ExplosionData_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006716 RID: 26390 RVA: 0x001D35EC File Offset: 0x001D17EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 210090, XrefRangeEnd = 210099, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_CreateExplosion_2907189355(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CombatManager.NativeMethodInfoPtr_RpcReader___Server_CreateExplosion_2907189355_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006717 RID: 26391 RVA: 0x001D3650 File Offset: 0x001D1850
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 210099, XrefRangeEnd = 210114, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_Explosion_2907189355(Vector3 origin, ExplosionData data, int id)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref origin;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref data;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref id;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CombatManager.NativeMethodInfoPtr_RpcWriter___Observers_Explosion_2907189355_Private_Void_Vector3_ExplosionData_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006718 RID: 26392 RVA: 0x001D36AC File Offset: 0x001D18AC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 210130, RefRangeEnd = 210132, XrefRangeStart = 210114, XrefRangeEnd = 210130, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___Explosion_2907189355(Vector3 origin, ExplosionData data, int id)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref origin;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref data;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref id;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CombatManager.NativeMethodInfoPtr_RpcLogic___Explosion_2907189355_Private_Void_Vector3_ExplosionData_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006719 RID: 26393 RVA: 0x001D3708 File Offset: 0x001D1908
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 210132, XrefRangeEnd = 210141, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_Explosion_2907189355(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CombatManager.NativeMethodInfoPtr_RpcReader___Observers_Explosion_2907189355_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600671A RID: 26394 RVA: 0x001D3758 File Offset: 0x001D1958
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 210141, XrefRangeEnd = 210144, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CombatManager.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600671B RID: 26395 RVA: 0x00030813 File Offset: 0x0002EA13
		public CombatManager(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001ED3 RID: 7891
		// (get) Token: 0x0600671C RID: 26396 RVA: 0x001D3794 File Offset: 0x001D1994
		// (set) Token: 0x0600671D RID: 26397 RVA: 0x0003081C File Offset: 0x0002EA1C
		public unsafe LayerMask MeleeLayerMask
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatManager.NativeFieldInfoPtr_MeleeLayerMask);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatManager.NativeFieldInfoPtr_MeleeLayerMask)) = value;
			}
		}

		// Token: 0x17001ED4 RID: 7892
		// (get) Token: 0x0600671E RID: 26398 RVA: 0x001D37BC File Offset: 0x001D19BC
		// (set) Token: 0x0600671F RID: 26399 RVA: 0x00030837 File Offset: 0x0002EA37
		public unsafe LayerMask ExplosionLayerMask
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatManager.NativeFieldInfoPtr_ExplosionLayerMask);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatManager.NativeFieldInfoPtr_ExplosionLayerMask)) = value;
			}
		}

		// Token: 0x17001ED5 RID: 7893
		// (get) Token: 0x06006720 RID: 26400 RVA: 0x001D37E4 File Offset: 0x001D19E4
		// (set) Token: 0x06006721 RID: 26401 RVA: 0x00030852 File Offset: 0x0002EA52
		public unsafe LayerMask RangedWeaponLayerMask
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatManager.NativeFieldInfoPtr_RangedWeaponLayerMask);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatManager.NativeFieldInfoPtr_RangedWeaponLayerMask)) = value;
			}
		}

		// Token: 0x17001ED6 RID: 7894
		// (get) Token: 0x06006722 RID: 26402 RVA: 0x001D380C File Offset: 0x001D1A0C
		// (set) Token: 0x06006723 RID: 26403 RVA: 0x0003086D File Offset: 0x0002EA6D
		public unsafe Explosion ExplosionPrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatManager.NativeFieldInfoPtr_ExplosionPrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Explosion>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatManager.NativeFieldInfoPtr_ExplosionPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001ED7 RID: 7895
		// (get) Token: 0x06006724 RID: 26404 RVA: 0x001D383C File Offset: 0x001D1A3C
		// (set) Token: 0x06006725 RID: 26405 RVA: 0x0003088C File Offset: 0x0002EA8C
		public unsafe List<int> explosionIDs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatManager.NativeFieldInfoPtr_explosionIDs);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatManager.NativeFieldInfoPtr_explosionIDs), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001ED8 RID: 7896
		// (get) Token: 0x06006726 RID: 26406 RVA: 0x001D386C File Offset: 0x001D1A6C
		// (set) Token: 0x06006727 RID: 26407 RVA: 0x000308AB File Offset: 0x0002EAAB
		public new unsafe bool field_Private_Boolean_0
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatManager.NativeFieldInfoPtr_field_Private_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatManager.NativeFieldInfoPtr_field_Private_Boolean_0)) = value;
			}
		}

		// Token: 0x17001ED9 RID: 7897
		// (get) Token: 0x06006728 RID: 26408 RVA: 0x001D3894 File Offset: 0x001D1A94
		// (set) Token: 0x06006729 RID: 26409 RVA: 0x000308C6 File Offset: 0x0002EAC6
		public new unsafe bool field_Private_Boolean_1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatManager.NativeFieldInfoPtr_field_Private_Boolean_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatManager.NativeFieldInfoPtr_field_Private_Boolean_1)) = value;
			}
		}

		// Token: 0x0400464D RID: 17997
		private static readonly IntPtr NativeFieldInfoPtr_MeleeLayerMask;

		// Token: 0x0400464E RID: 17998
		private static readonly IntPtr NativeFieldInfoPtr_ExplosionLayerMask;

		// Token: 0x0400464F RID: 17999
		private static readonly IntPtr NativeFieldInfoPtr_RangedWeaponLayerMask;

		// Token: 0x04004650 RID: 18000
		private static readonly IntPtr NativeFieldInfoPtr_ExplosionPrefab;

		// Token: 0x04004651 RID: 18001
		private static readonly IntPtr NativeFieldInfoPtr_explosionIDs;

		// Token: 0x04004652 RID: 18002
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

		// Token: 0x04004653 RID: 18003
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

		// Token: 0x04004654 RID: 18004
		private static readonly IntPtr NativeMethodInfoPtr_CreateTestExplosion_Public_Void_0;

		// Token: 0x04004655 RID: 18005
		private static readonly IntPtr NativeMethodInfoPtr_CreateExplosion_Public_Void_Vector3_ExplosionData_0;

		// Token: 0x04004656 RID: 18006
		private static readonly IntPtr NativeMethodInfoPtr_CreateExplosion_Private_Void_Vector3_ExplosionData_Int32_0;

		// Token: 0x04004657 RID: 18007
		private static readonly IntPtr NativeMethodInfoPtr_Explosion_Private_Void_Vector3_ExplosionData_Int32_0;

		// Token: 0x04004658 RID: 18008
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04004659 RID: 18009
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

		// Token: 0x0400465A RID: 18010
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

		// Token: 0x0400465B RID: 18011
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

		// Token: 0x0400465C RID: 18012
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_CreateExplosion_2907189355_Private_Void_Vector3_ExplosionData_Int32_0;

		// Token: 0x0400465D RID: 18013
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___CreateExplosion_2907189355_Private_Void_Vector3_ExplosionData_Int32_0;

		// Token: 0x0400465E RID: 18014
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_CreateExplosion_2907189355_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x0400465F RID: 18015
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_Explosion_2907189355_Private_Void_Vector3_ExplosionData_Int32_0;

		// Token: 0x04004660 RID: 18016
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___Explosion_2907189355_Private_Void_Vector3_ExplosionData_Int32_0;

		// Token: 0x04004661 RID: 18017
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_Explosion_2907189355_Private_Void_PooledReader_Channel_0;

		// Token: 0x04004662 RID: 18018
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;
	}
}
