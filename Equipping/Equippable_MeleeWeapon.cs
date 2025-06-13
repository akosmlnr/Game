using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Audio;
using Il2CppScheduleOne.Combat;
using Il2CppScheduleOne.ItemFramework;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine;

namespace Il2CppScheduleOne.Equipping
{
	// Token: 0x020005E4 RID: 1508
	public class Equippable_MeleeWeapon : Equippable_AvatarViewmodel
	{
		// Token: 0x0600832F RID: 33583 RVA: 0x00232688 File Offset: 0x00230888
		// Note: this type is marked as 'beforefieldinit'.
		static Equippable_MeleeWeapon()
		{
			Il2CppClassPointerStore<Equippable_MeleeWeapon>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Equipping", "Equippable_MeleeWeapon");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Equippable_MeleeWeapon>.NativeClassPtr);
			Equippable_MeleeWeapon.NativeFieldInfoPtr__IsAttacking_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_MeleeWeapon>.NativeClassPtr, "<IsAttacking>k__BackingField");
			Equippable_MeleeWeapon.NativeFieldInfoPtr_ImpactType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_MeleeWeapon>.NativeClassPtr, "ImpactType");
			Equippable_MeleeWeapon.NativeFieldInfoPtr_Range = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_MeleeWeapon>.NativeClassPtr, "Range");
			Equippable_MeleeWeapon.NativeFieldInfoPtr_HitRadius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_MeleeWeapon>.NativeClassPtr, "HitRadius");
			Equippable_MeleeWeapon.NativeFieldInfoPtr_MaxLoadTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_MeleeWeapon>.NativeClassPtr, "MaxLoadTime");
			Equippable_MeleeWeapon.NativeFieldInfoPtr_MinCooldown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_MeleeWeapon>.NativeClassPtr, "MinCooldown");
			Equippable_MeleeWeapon.NativeFieldInfoPtr_MaxCooldown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_MeleeWeapon>.NativeClassPtr, "MaxCooldown");
			Equippable_MeleeWeapon.NativeFieldInfoPtr_MinHitDelay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_MeleeWeapon>.NativeClassPtr, "MinHitDelay");
			Equippable_MeleeWeapon.NativeFieldInfoPtr_MaxHitDelay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_MeleeWeapon>.NativeClassPtr, "MaxHitDelay");
			Equippable_MeleeWeapon.NativeFieldInfoPtr_MinDamage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_MeleeWeapon>.NativeClassPtr, "MinDamage");
			Equippable_MeleeWeapon.NativeFieldInfoPtr_MaxDamage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_MeleeWeapon>.NativeClassPtr, "MaxDamage");
			Equippable_MeleeWeapon.NativeFieldInfoPtr_MinForce = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_MeleeWeapon>.NativeClassPtr, "MinForce");
			Equippable_MeleeWeapon.NativeFieldInfoPtr_MaxForce = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_MeleeWeapon>.NativeClassPtr, "MaxForce");
			Equippable_MeleeWeapon.NativeFieldInfoPtr_MinStaminaCost = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_MeleeWeapon>.NativeClassPtr, "MinStaminaCost");
			Equippable_MeleeWeapon.NativeFieldInfoPtr_MaxStaminaCost = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_MeleeWeapon>.NativeClassPtr, "MaxStaminaCost");
			Equippable_MeleeWeapon.NativeFieldInfoPtr_WhooshSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_MeleeWeapon>.NativeClassPtr, "WhooshSound");
			Equippable_MeleeWeapon.NativeFieldInfoPtr_WhooshSoundPitch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_MeleeWeapon>.NativeClassPtr, "WhooshSoundPitch");
			Equippable_MeleeWeapon.NativeFieldInfoPtr_ImpactSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_MeleeWeapon>.NativeClassPtr, "ImpactSound");
			Equippable_MeleeWeapon.NativeFieldInfoPtr_SwingAnimationTrigger = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_MeleeWeapon>.NativeClassPtr, "SwingAnimationTrigger");
			Equippable_MeleeWeapon.NativeFieldInfoPtr_load = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_MeleeWeapon>.NativeClassPtr, "load");
			Equippable_MeleeWeapon.NativeFieldInfoPtr_remainingCooldown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_MeleeWeapon>.NativeClassPtr, "remainingCooldown");
			Equippable_MeleeWeapon.NativeFieldInfoPtr_hitRoutine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_MeleeWeapon>.NativeClassPtr, "hitRoutine");
			Equippable_MeleeWeapon.NativeFieldInfoPtr_loadQueued = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_MeleeWeapon>.NativeClassPtr, "loadQueued");
			Equippable_MeleeWeapon.NativeFieldInfoPtr_clickReleased = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_MeleeWeapon>.NativeClassPtr, "clickReleased");
			Equippable_MeleeWeapon.NativeMethodInfoPtr_get_IsLoading_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_MeleeWeapon>.NativeClassPtr, 100679837);
			Equippable_MeleeWeapon.NativeMethodInfoPtr_get_IsAttacking_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_MeleeWeapon>.NativeClassPtr, 100679838);
			Equippable_MeleeWeapon.NativeMethodInfoPtr_set_IsAttacking_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_MeleeWeapon>.NativeClassPtr, 100679839);
			Equippable_MeleeWeapon.NativeMethodInfoPtr_Update_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_MeleeWeapon>.NativeClassPtr, 100679840);
			Equippable_MeleeWeapon.NativeMethodInfoPtr_Equip_Public_Virtual_Void_ItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_MeleeWeapon>.NativeClassPtr, 100679841);
			Equippable_MeleeWeapon.NativeMethodInfoPtr_Unequip_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_MeleeWeapon>.NativeClassPtr, 100679842);
			Equippable_MeleeWeapon.NativeMethodInfoPtr_UpdateCooldown_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_MeleeWeapon>.NativeClassPtr, 100679843);
			Equippable_MeleeWeapon.NativeMethodInfoPtr_UpdateInput_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_MeleeWeapon>.NativeClassPtr, 100679844);
			Equippable_MeleeWeapon.NativeMethodInfoPtr_CanStartLoading_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_MeleeWeapon>.NativeClassPtr, 100679845);
			Equippable_MeleeWeapon.NativeMethodInfoPtr_StartLoad_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_MeleeWeapon>.NativeClassPtr, 100679846);
			Equippable_MeleeWeapon.NativeMethodInfoPtr_Release_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_MeleeWeapon>.NativeClassPtr, 100679847);
			Equippable_MeleeWeapon.NativeMethodInfoPtr_Hit_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_MeleeWeapon>.NativeClassPtr, 100679848);
			Equippable_MeleeWeapon.NativeMethodInfoPtr_ExecuteHit_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_MeleeWeapon>.NativeClassPtr, 100679849);
			Equippable_MeleeWeapon.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_MeleeWeapon>.NativeClassPtr, 100679850);
		}

		// Token: 0x17002785 RID: 10117
		// (get) Token: 0x06008330 RID: 33584 RVA: 0x002329B0 File Offset: 0x00230BB0
		public unsafe bool IsLoading
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Equippable_MeleeWeapon.NativeMethodInfoPtr_get_IsLoading_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
		}

		// Token: 0x17002786 RID: 10118
		// (get) Token: 0x06008331 RID: 33585 RVA: 0x002329EC File Offset: 0x00230BEC
		// (set) Token: 0x06008332 RID: 33586 RVA: 0x00232A28 File Offset: 0x00230C28
		public unsafe bool IsAttacking
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Equippable_MeleeWeapon.NativeMethodInfoPtr_get_IsAttacking_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
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
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Equippable_MeleeWeapon.NativeMethodInfoPtr_set_IsAttacking_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x06008333 RID: 33587 RVA: 0x00232A68 File Offset: 0x00230C68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 248644, XrefRangeEnd = 248652, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Equippable_MeleeWeapon.NativeMethodInfoPtr_Update_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008334 RID: 33588 RVA: 0x00232AA4 File Offset: 0x00230CA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 248652, XrefRangeEnd = 248653, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Equip(ItemInstance item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Equippable_MeleeWeapon.NativeMethodInfoPtr_Equip_Public_Virtual_Void_ItemInstance_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008335 RID: 33589 RVA: 0x00232AF4 File Offset: 0x00230CF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 248653, XrefRangeEnd = 248662, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Unequip()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Equippable_MeleeWeapon.NativeMethodInfoPtr_Unequip_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008336 RID: 33590 RVA: 0x00232B30 File Offset: 0x00230D30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 248662, XrefRangeEnd = 248664, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateCooldown()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Equippable_MeleeWeapon.NativeMethodInfoPtr_UpdateCooldown_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008337 RID: 33591 RVA: 0x00232B64 File Offset: 0x00230D64
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 248672, RefRangeEnd = 248673, XrefRangeStart = 248664, XrefRangeEnd = 248672, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateInput()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Equippable_MeleeWeapon.NativeMethodInfoPtr_UpdateInput_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008338 RID: 33592 RVA: 0x00232B98 File Offset: 0x00230D98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 248673, XrefRangeEnd = 248677, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool CanStartLoading()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Equippable_MeleeWeapon.NativeMethodInfoPtr_CanStartLoading_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06008339 RID: 33593 RVA: 0x00232BD4 File Offset: 0x00230DD4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 248677, XrefRangeEnd = 248696, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StartLoad()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Equippable_MeleeWeapon.NativeMethodInfoPtr_StartLoad_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600833A RID: 33594 RVA: 0x00232C08 File Offset: 0x00230E08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 248696, XrefRangeEnd = 248743, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Release()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Equippable_MeleeWeapon.NativeMethodInfoPtr_Release_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600833B RID: 33595 RVA: 0x00232C3C File Offset: 0x00230E3C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 248758, RefRangeEnd = 248759, XrefRangeStart = 248743, XrefRangeEnd = 248758, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Hit(float power)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref power;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Equippable_MeleeWeapon.NativeMethodInfoPtr_Hit_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600833C RID: 33596 RVA: 0x00232C7C File Offset: 0x00230E7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 248759, XrefRangeEnd = 248834, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ExecuteHit(float power)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref power;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Equippable_MeleeWeapon.NativeMethodInfoPtr_ExecuteHit_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600833D RID: 33597 RVA: 0x00232CBC File Offset: 0x00230EBC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 248834, XrefRangeEnd = 248835, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Equippable_MeleeWeapon() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Equippable_MeleeWeapon>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Equippable_MeleeWeapon.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600833E RID: 33598 RVA: 0x0003E005 File Offset: 0x0003C205
		public Equippable_MeleeWeapon(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700276D RID: 10093
		// (get) Token: 0x0600833F RID: 33599 RVA: 0x00232CF8 File Offset: 0x00230EF8
		// (set) Token: 0x06008340 RID: 33600 RVA: 0x0003E00E File Offset: 0x0003C20E
		public unsafe bool _IsAttacking_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_MeleeWeapon.NativeFieldInfoPtr__IsAttacking_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_MeleeWeapon.NativeFieldInfoPtr__IsAttacking_k__BackingField)) = value;
			}
		}

		// Token: 0x1700276E RID: 10094
		// (get) Token: 0x06008341 RID: 33601 RVA: 0x00232D20 File Offset: 0x00230F20
		// (set) Token: 0x06008342 RID: 33602 RVA: 0x0003E029 File Offset: 0x0003C229
		public unsafe EImpactType ImpactType
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_MeleeWeapon.NativeFieldInfoPtr_ImpactType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_MeleeWeapon.NativeFieldInfoPtr_ImpactType)) = value;
			}
		}

		// Token: 0x1700276F RID: 10095
		// (get) Token: 0x06008343 RID: 33603 RVA: 0x00232D48 File Offset: 0x00230F48
		// (set) Token: 0x06008344 RID: 33604 RVA: 0x0003E044 File Offset: 0x0003C244
		public unsafe float Range
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_MeleeWeapon.NativeFieldInfoPtr_Range);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_MeleeWeapon.NativeFieldInfoPtr_Range)) = value;
			}
		}

		// Token: 0x17002770 RID: 10096
		// (get) Token: 0x06008345 RID: 33605 RVA: 0x00232D70 File Offset: 0x00230F70
		// (set) Token: 0x06008346 RID: 33606 RVA: 0x0003E05F File Offset: 0x0003C25F
		public unsafe float HitRadius
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_MeleeWeapon.NativeFieldInfoPtr_HitRadius);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_MeleeWeapon.NativeFieldInfoPtr_HitRadius)) = value;
			}
		}

		// Token: 0x17002771 RID: 10097
		// (get) Token: 0x06008347 RID: 33607 RVA: 0x00232D98 File Offset: 0x00230F98
		// (set) Token: 0x06008348 RID: 33608 RVA: 0x0003E07A File Offset: 0x0003C27A
		public unsafe float MaxLoadTime
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_MeleeWeapon.NativeFieldInfoPtr_MaxLoadTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_MeleeWeapon.NativeFieldInfoPtr_MaxLoadTime)) = value;
			}
		}

		// Token: 0x17002772 RID: 10098
		// (get) Token: 0x06008349 RID: 33609 RVA: 0x00232DC0 File Offset: 0x00230FC0
		// (set) Token: 0x0600834A RID: 33610 RVA: 0x0003E095 File Offset: 0x0003C295
		public unsafe float MinCooldown
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_MeleeWeapon.NativeFieldInfoPtr_MinCooldown);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_MeleeWeapon.NativeFieldInfoPtr_MinCooldown)) = value;
			}
		}

		// Token: 0x17002773 RID: 10099
		// (get) Token: 0x0600834B RID: 33611 RVA: 0x00232DE8 File Offset: 0x00230FE8
		// (set) Token: 0x0600834C RID: 33612 RVA: 0x0003E0B0 File Offset: 0x0003C2B0
		public unsafe float MaxCooldown
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_MeleeWeapon.NativeFieldInfoPtr_MaxCooldown);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_MeleeWeapon.NativeFieldInfoPtr_MaxCooldown)) = value;
			}
		}

		// Token: 0x17002774 RID: 10100
		// (get) Token: 0x0600834D RID: 33613 RVA: 0x00232E10 File Offset: 0x00231010
		// (set) Token: 0x0600834E RID: 33614 RVA: 0x0003E0CB File Offset: 0x0003C2CB
		public unsafe float MinHitDelay
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_MeleeWeapon.NativeFieldInfoPtr_MinHitDelay);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_MeleeWeapon.NativeFieldInfoPtr_MinHitDelay)) = value;
			}
		}

		// Token: 0x17002775 RID: 10101
		// (get) Token: 0x0600834F RID: 33615 RVA: 0x00232E38 File Offset: 0x00231038
		// (set) Token: 0x06008350 RID: 33616 RVA: 0x0003E0E6 File Offset: 0x0003C2E6
		public unsafe float MaxHitDelay
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_MeleeWeapon.NativeFieldInfoPtr_MaxHitDelay);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_MeleeWeapon.NativeFieldInfoPtr_MaxHitDelay)) = value;
			}
		}

		// Token: 0x17002776 RID: 10102
		// (get) Token: 0x06008351 RID: 33617 RVA: 0x00232E60 File Offset: 0x00231060
		// (set) Token: 0x06008352 RID: 33618 RVA: 0x0003E101 File Offset: 0x0003C301
		public unsafe float MinDamage
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_MeleeWeapon.NativeFieldInfoPtr_MinDamage);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_MeleeWeapon.NativeFieldInfoPtr_MinDamage)) = value;
			}
		}

		// Token: 0x17002777 RID: 10103
		// (get) Token: 0x06008353 RID: 33619 RVA: 0x00232E88 File Offset: 0x00231088
		// (set) Token: 0x06008354 RID: 33620 RVA: 0x0003E11C File Offset: 0x0003C31C
		public unsafe float MaxDamage
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_MeleeWeapon.NativeFieldInfoPtr_MaxDamage);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_MeleeWeapon.NativeFieldInfoPtr_MaxDamage)) = value;
			}
		}

		// Token: 0x17002778 RID: 10104
		// (get) Token: 0x06008355 RID: 33621 RVA: 0x00232EB0 File Offset: 0x002310B0
		// (set) Token: 0x06008356 RID: 33622 RVA: 0x0003E137 File Offset: 0x0003C337
		public unsafe float MinForce
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_MeleeWeapon.NativeFieldInfoPtr_MinForce);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_MeleeWeapon.NativeFieldInfoPtr_MinForce)) = value;
			}
		}

		// Token: 0x17002779 RID: 10105
		// (get) Token: 0x06008357 RID: 33623 RVA: 0x00232ED8 File Offset: 0x002310D8
		// (set) Token: 0x06008358 RID: 33624 RVA: 0x0003E152 File Offset: 0x0003C352
		public unsafe float MaxForce
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_MeleeWeapon.NativeFieldInfoPtr_MaxForce);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_MeleeWeapon.NativeFieldInfoPtr_MaxForce)) = value;
			}
		}

		// Token: 0x1700277A RID: 10106
		// (get) Token: 0x06008359 RID: 33625 RVA: 0x00232F00 File Offset: 0x00231100
		// (set) Token: 0x0600835A RID: 33626 RVA: 0x0003E16D File Offset: 0x0003C36D
		public unsafe float MinStaminaCost
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_MeleeWeapon.NativeFieldInfoPtr_MinStaminaCost);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_MeleeWeapon.NativeFieldInfoPtr_MinStaminaCost)) = value;
			}
		}

		// Token: 0x1700277B RID: 10107
		// (get) Token: 0x0600835B RID: 33627 RVA: 0x00232F28 File Offset: 0x00231128
		// (set) Token: 0x0600835C RID: 33628 RVA: 0x0003E188 File Offset: 0x0003C388
		public unsafe float MaxStaminaCost
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_MeleeWeapon.NativeFieldInfoPtr_MaxStaminaCost);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_MeleeWeapon.NativeFieldInfoPtr_MaxStaminaCost)) = value;
			}
		}

		// Token: 0x1700277C RID: 10108
		// (get) Token: 0x0600835D RID: 33629 RVA: 0x00232F50 File Offset: 0x00231150
		// (set) Token: 0x0600835E RID: 33630 RVA: 0x0003E1A3 File Offset: 0x0003C3A3
		public unsafe AudioSourceController WhooshSound
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_MeleeWeapon.NativeFieldInfoPtr_WhooshSound);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_MeleeWeapon.NativeFieldInfoPtr_WhooshSound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700277D RID: 10109
		// (get) Token: 0x0600835F RID: 33631 RVA: 0x00232F80 File Offset: 0x00231180
		// (set) Token: 0x06008360 RID: 33632 RVA: 0x0003E1C2 File Offset: 0x0003C3C2
		public unsafe float WhooshSoundPitch
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_MeleeWeapon.NativeFieldInfoPtr_WhooshSoundPitch);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_MeleeWeapon.NativeFieldInfoPtr_WhooshSoundPitch)) = value;
			}
		}

		// Token: 0x1700277E RID: 10110
		// (get) Token: 0x06008361 RID: 33633 RVA: 0x00232FA8 File Offset: 0x002311A8
		// (set) Token: 0x06008362 RID: 33634 RVA: 0x0003E1DD File Offset: 0x0003C3DD
		public unsafe AudioSourceController ImpactSound
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_MeleeWeapon.NativeFieldInfoPtr_ImpactSound);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_MeleeWeapon.NativeFieldInfoPtr_ImpactSound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700277F RID: 10111
		// (get) Token: 0x06008363 RID: 33635 RVA: 0x00232FD8 File Offset: 0x002311D8
		// (set) Token: 0x06008364 RID: 33636 RVA: 0x0003E1FC File Offset: 0x0003C3FC
		public unsafe string SwingAnimationTrigger
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_MeleeWeapon.NativeFieldInfoPtr_SwingAnimationTrigger);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_MeleeWeapon.NativeFieldInfoPtr_SwingAnimationTrigger), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17002780 RID: 10112
		// (get) Token: 0x06008365 RID: 33637 RVA: 0x00233000 File Offset: 0x00231200
		// (set) Token: 0x06008366 RID: 33638 RVA: 0x0003E21B File Offset: 0x0003C41B
		public unsafe float load
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_MeleeWeapon.NativeFieldInfoPtr_load);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_MeleeWeapon.NativeFieldInfoPtr_load)) = value;
			}
		}

		// Token: 0x17002781 RID: 10113
		// (get) Token: 0x06008367 RID: 33639 RVA: 0x00233028 File Offset: 0x00231228
		// (set) Token: 0x06008368 RID: 33640 RVA: 0x0003E236 File Offset: 0x0003C436
		public unsafe float remainingCooldown
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_MeleeWeapon.NativeFieldInfoPtr_remainingCooldown);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_MeleeWeapon.NativeFieldInfoPtr_remainingCooldown)) = value;
			}
		}

		// Token: 0x17002782 RID: 10114
		// (get) Token: 0x06008369 RID: 33641 RVA: 0x00233050 File Offset: 0x00231250
		// (set) Token: 0x0600836A RID: 33642 RVA: 0x0003E251 File Offset: 0x0003C451
		public unsafe Coroutine hitRoutine
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_MeleeWeapon.NativeFieldInfoPtr_hitRoutine);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_MeleeWeapon.NativeFieldInfoPtr_hitRoutine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002783 RID: 10115
		// (get) Token: 0x0600836B RID: 33643 RVA: 0x00233080 File Offset: 0x00231280
		// (set) Token: 0x0600836C RID: 33644 RVA: 0x0003E270 File Offset: 0x0003C470
		public unsafe bool loadQueued
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_MeleeWeapon.NativeFieldInfoPtr_loadQueued);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_MeleeWeapon.NativeFieldInfoPtr_loadQueued)) = value;
			}
		}

		// Token: 0x17002784 RID: 10116
		// (get) Token: 0x0600836D RID: 33645 RVA: 0x002330A8 File Offset: 0x002312A8
		// (set) Token: 0x0600836E RID: 33646 RVA: 0x0003E28B File Offset: 0x0003C48B
		public unsafe bool clickReleased
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_MeleeWeapon.NativeFieldInfoPtr_clickReleased);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_MeleeWeapon.NativeFieldInfoPtr_clickReleased)) = value;
			}
		}

		// Token: 0x04005956 RID: 22870
		private static readonly System.IntPtr NativeFieldInfoPtr__IsAttacking_k__BackingField;

		// Token: 0x04005957 RID: 22871
		private static readonly System.IntPtr NativeFieldInfoPtr_ImpactType;

		// Token: 0x04005958 RID: 22872
		private static readonly System.IntPtr NativeFieldInfoPtr_Range;

		// Token: 0x04005959 RID: 22873
		private static readonly System.IntPtr NativeFieldInfoPtr_HitRadius;

		// Token: 0x0400595A RID: 22874
		private static readonly System.IntPtr NativeFieldInfoPtr_MaxLoadTime;

		// Token: 0x0400595B RID: 22875
		private static readonly System.IntPtr NativeFieldInfoPtr_MinCooldown;

		// Token: 0x0400595C RID: 22876
		private static readonly System.IntPtr NativeFieldInfoPtr_MaxCooldown;

		// Token: 0x0400595D RID: 22877
		private static readonly System.IntPtr NativeFieldInfoPtr_MinHitDelay;

		// Token: 0x0400595E RID: 22878
		private static readonly System.IntPtr NativeFieldInfoPtr_MaxHitDelay;

		// Token: 0x0400595F RID: 22879
		private static readonly System.IntPtr NativeFieldInfoPtr_MinDamage;

		// Token: 0x04005960 RID: 22880
		private static readonly System.IntPtr NativeFieldInfoPtr_MaxDamage;

		// Token: 0x04005961 RID: 22881
		private static readonly System.IntPtr NativeFieldInfoPtr_MinForce;

		// Token: 0x04005962 RID: 22882
		private static readonly System.IntPtr NativeFieldInfoPtr_MaxForce;

		// Token: 0x04005963 RID: 22883
		private static readonly System.IntPtr NativeFieldInfoPtr_MinStaminaCost;

		// Token: 0x04005964 RID: 22884
		private static readonly System.IntPtr NativeFieldInfoPtr_MaxStaminaCost;

		// Token: 0x04005965 RID: 22885
		private static readonly System.IntPtr NativeFieldInfoPtr_WhooshSound;

		// Token: 0x04005966 RID: 22886
		private static readonly System.IntPtr NativeFieldInfoPtr_WhooshSoundPitch;

		// Token: 0x04005967 RID: 22887
		private static readonly System.IntPtr NativeFieldInfoPtr_ImpactSound;

		// Token: 0x04005968 RID: 22888
		private static readonly System.IntPtr NativeFieldInfoPtr_SwingAnimationTrigger;

		// Token: 0x04005969 RID: 22889
		private static readonly System.IntPtr NativeFieldInfoPtr_load;

		// Token: 0x0400596A RID: 22890
		private static readonly System.IntPtr NativeFieldInfoPtr_remainingCooldown;

		// Token: 0x0400596B RID: 22891
		private static readonly System.IntPtr NativeFieldInfoPtr_hitRoutine;

		// Token: 0x0400596C RID: 22892
		private static readonly System.IntPtr NativeFieldInfoPtr_loadQueued;

		// Token: 0x0400596D RID: 22893
		private static readonly System.IntPtr NativeFieldInfoPtr_clickReleased;

		// Token: 0x0400596E RID: 22894
		private static readonly System.IntPtr NativeMethodInfoPtr_get_IsLoading_Public_get_Boolean_0;

		// Token: 0x0400596F RID: 22895
		private static readonly System.IntPtr NativeMethodInfoPtr_get_IsAttacking_Public_get_Boolean_0;

		// Token: 0x04005970 RID: 22896
		private static readonly System.IntPtr NativeMethodInfoPtr_set_IsAttacking_Private_set_Void_Boolean_0;

		// Token: 0x04005971 RID: 22897
		private static readonly System.IntPtr NativeMethodInfoPtr_Update_Protected_Virtual_Void_0;

		// Token: 0x04005972 RID: 22898
		private static readonly System.IntPtr NativeMethodInfoPtr_Equip_Public_Virtual_Void_ItemInstance_0;

		// Token: 0x04005973 RID: 22899
		private static readonly System.IntPtr NativeMethodInfoPtr_Unequip_Public_Virtual_Void_0;

		// Token: 0x04005974 RID: 22900
		private static readonly System.IntPtr NativeMethodInfoPtr_UpdateCooldown_Private_Void_0;

		// Token: 0x04005975 RID: 22901
		private static readonly System.IntPtr NativeMethodInfoPtr_UpdateInput_Private_Void_0;

		// Token: 0x04005976 RID: 22902
		private static readonly System.IntPtr NativeMethodInfoPtr_CanStartLoading_Private_Boolean_0;

		// Token: 0x04005977 RID: 22903
		private static readonly System.IntPtr NativeMethodInfoPtr_StartLoad_Private_Void_0;

		// Token: 0x04005978 RID: 22904
		private static readonly System.IntPtr NativeMethodInfoPtr_Release_Private_Void_0;

		// Token: 0x04005979 RID: 22905
		private static readonly System.IntPtr NativeMethodInfoPtr_Hit_Private_Void_Single_0;

		// Token: 0x0400597A RID: 22906
		private static readonly System.IntPtr NativeMethodInfoPtr_ExecuteHit_Private_Void_Single_0;

		// Token: 0x0400597B RID: 22907
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000B2D RID: 2861
		[ObfuscatedName("ScheduleOne.Equipping.Equippable_MeleeWeapon+<>c__DisplayClass37_0")]
		public sealed class __c__DisplayClass37_0 : Il2CppSystem.Object
		{
			// Token: 0x0600DA2D RID: 55853 RVA: 0x00342870 File Offset: 0x00340A70
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass37_0()
			{
				Il2CppClassPointerStore<Equippable_MeleeWeapon.__c__DisplayClass37_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Equippable_MeleeWeapon>.NativeClassPtr, "<>c__DisplayClass37_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Equippable_MeleeWeapon.__c__DisplayClass37_0>.NativeClassPtr);
				Equippable_MeleeWeapon.__c__DisplayClass37_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_MeleeWeapon.__c__DisplayClass37_0>.NativeClassPtr, "<>4__this");
				Equippable_MeleeWeapon.__c__DisplayClass37_0.NativeFieldInfoPtr_power = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_MeleeWeapon.__c__DisplayClass37_0>.NativeClassPtr, "power");
				Equippable_MeleeWeapon.__c__DisplayClass37_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_MeleeWeapon.__c__DisplayClass37_0>.NativeClassPtr, 100679851);
				Equippable_MeleeWeapon.__c__DisplayClass37_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_MeleeWeapon.__c__DisplayClass37_0>.NativeClassPtr, 100679852);
			}

			// Token: 0x0600DA2E RID: 55854 RVA: 0x003428EC File Offset: 0x00340AEC
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass37_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Equippable_MeleeWeapon.__c__DisplayClass37_0>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Equippable_MeleeWeapon.__c__DisplayClass37_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600DA2F RID: 55855 RVA: 0x00342928 File Offset: 0x00340B28
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 248639, XrefRangeEnd = 248644, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator Method_Internal_IEnumerator_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Equippable_MeleeWeapon.__c__DisplayClass37_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr2) : null;
			}

			// Token: 0x0600DA30 RID: 55856 RVA: 0x00069D73 File Offset: 0x00067F73
			public __c__DisplayClass37_0(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700434B RID: 17227
			// (get) Token: 0x0600DA31 RID: 55857 RVA: 0x00342968 File Offset: 0x00340B68
			// (set) Token: 0x0600DA32 RID: 55858 RVA: 0x00069D7C File Offset: 0x00067F7C
			public unsafe Equippable_MeleeWeapon __4__this
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_MeleeWeapon.__c__DisplayClass37_0.NativeFieldInfoPtr___4__this);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Equippable_MeleeWeapon>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_MeleeWeapon.__c__DisplayClass37_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700434C RID: 17228
			// (get) Token: 0x0600DA33 RID: 55859 RVA: 0x00342998 File Offset: 0x00340B98
			// (set) Token: 0x0600DA34 RID: 55860 RVA: 0x00069D9B File Offset: 0x00067F9B
			public unsafe float power
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_MeleeWeapon.__c__DisplayClass37_0.NativeFieldInfoPtr_power);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_MeleeWeapon.__c__DisplayClass37_0.NativeFieldInfoPtr_power)) = value;
				}
			}

			// Token: 0x040092D6 RID: 37590
			private static readonly System.IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040092D7 RID: 37591
			private static readonly System.IntPtr NativeFieldInfoPtr_power;

			// Token: 0x040092D8 RID: 37592
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040092D9 RID: 37593
			private static readonly System.IntPtr NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0;

			// Token: 0x02000CC0 RID: 3264
			[ObfuscatedName("ScheduleOne.Equipping.Equippable_MeleeWeapon+<>c__DisplayClass37_0+<<Hit>g__HitRoutine|0>d")]
			public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique : Il2CppSystem.Object
			{
				// Token: 0x0600E9F9 RID: 59897 RVA: 0x0036FDF4 File Offset: 0x0036DFF4
				// Note: this type is marked as 'beforefieldinit'.
				static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique()
				{
					Il2CppClassPointerStore<Equippable_MeleeWeapon.__c__DisplayClass37_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Equippable_MeleeWeapon.__c__DisplayClass37_0>.NativeClassPtr, "<<Hit>g__HitRoutine|0>d");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Equippable_MeleeWeapon.__c__DisplayClass37_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr);
					Equippable_MeleeWeapon.__c__DisplayClass37_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_MeleeWeapon.__c__DisplayClass37_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>1__state");
					Equippable_MeleeWeapon.__c__DisplayClass37_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_MeleeWeapon.__c__DisplayClass37_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>2__current");
					Equippable_MeleeWeapon.__c__DisplayClass37_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_MeleeWeapon.__c__DisplayClass37_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>4__this");
					Equippable_MeleeWeapon.__c__DisplayClass37_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_MeleeWeapon.__c__DisplayClass37_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100679853);
					Equippable_MeleeWeapon.__c__DisplayClass37_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_MeleeWeapon.__c__DisplayClass37_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100679854);
					Equippable_MeleeWeapon.__c__DisplayClass37_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_MeleeWeapon.__c__DisplayClass37_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100679855);
					Equippable_MeleeWeapon.__c__DisplayClass37_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_MeleeWeapon.__c__DisplayClass37_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100679856);
					Equippable_MeleeWeapon.__c__DisplayClass37_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_MeleeWeapon.__c__DisplayClass37_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100679857);
					Equippable_MeleeWeapon.__c__DisplayClass37_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_MeleeWeapon.__c__DisplayClass37_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100679858);
				}

				// Token: 0x0600E9FA RID: 59898 RVA: 0x0036FED4 File Offset: 0x0036E0D4
				[CallerCount(54)]
				[CachedScanResults(RefRangeStart = 2646, RefRangeEnd = 2700, XrefRangeStart = 2646, XrefRangeEnd = 2700, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Equippable_MeleeWeapon.__c__DisplayClass37_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr))
				{
					System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
					*ptr = ref <>1__state;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Equippable_MeleeWeapon.__c__DisplayClass37_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				}

				// Token: 0x0600E9FB RID: 59899 RVA: 0x0036FF1C File Offset: 0x0036E11C
				[CallerCount(14558)]
				[CachedScanResults(RefRangeStart = 2769, RefRangeEnd = 17327, XrefRangeStart = 2769, XrefRangeEnd = 17327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Equippable_MeleeWeapon.__c__DisplayClass37_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				}

				// Token: 0x0600E9FC RID: 59900 RVA: 0x0036FF50 File Offset: 0x0036E150
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 248621, XrefRangeEnd = 248634, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Equippable_MeleeWeapon.__c__DisplayClass37_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
					return *IL2CPP.il2cpp_object_unbox(obj);
				}

				// Token: 0x1700485A RID: 18522
				// (get) Token: 0x0600E9FD RID: 59901 RVA: 0x0036FF8C File Offset: 0x0036E18C
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(24)]
					[CachedScanResults(RefRangeStart = 2740, RefRangeEnd = 2764, XrefRangeStart = 2740, XrefRangeEnd = 2764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						System.IntPtr* param = null;
						System.IntPtr returnedException;
						System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Equippable_MeleeWeapon.__c__DisplayClass37_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
						Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
						System.IntPtr intPtr2 = intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
				}

				// Token: 0x0600E9FE RID: 59902 RVA: 0x0036FFCC File Offset: 0x0036E1CC
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 248634, XrefRangeEnd = 248639, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Equippable_MeleeWeapon.__c__DisplayClass37_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				}

				// Token: 0x1700485B RID: 18523
				// (get) Token: 0x0600E9FF RID: 59903 RVA: 0x00370000 File Offset: 0x0036E200
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(24)]
					[CachedScanResults(RefRangeStart = 2740, RefRangeEnd = 2764, XrefRangeStart = 2740, XrefRangeEnd = 2764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						System.IntPtr* param = null;
						System.IntPtr returnedException;
						System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Equippable_MeleeWeapon.__c__DisplayClass37_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
						Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
						System.IntPtr intPtr2 = intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
				}

				// Token: 0x0600EA00 RID: 59904 RVA: 0x00071C40 File Offset: 0x0006FE40
				public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique(System.IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x17004857 RID: 18519
				// (get) Token: 0x0600EA01 RID: 59905 RVA: 0x00370040 File Offset: 0x0036E240
				// (set) Token: 0x0600EA02 RID: 59906 RVA: 0x00071C49 File Offset: 0x0006FE49
				public unsafe int __1__state
				{
					get
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_MeleeWeapon.__c__DisplayClass37_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_MeleeWeapon.__c__DisplayClass37_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x17004858 RID: 18520
				// (get) Token: 0x0600EA03 RID: 59907 RVA: 0x00370068 File Offset: 0x0036E268
				// (set) Token: 0x0600EA04 RID: 59908 RVA: 0x00071C64 File Offset: 0x0006FE64
				public unsafe Il2CppSystem.Object __2__current
				{
					get
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_MeleeWeapon.__c__DisplayClass37_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current);
						System.IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
					set
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_MeleeWeapon.__c__DisplayClass37_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17004859 RID: 18521
				// (get) Token: 0x0600EA05 RID: 59909 RVA: 0x00370098 File Offset: 0x0036E298
				// (set) Token: 0x0600EA06 RID: 59910 RVA: 0x00071C83 File Offset: 0x0006FE83
				public unsafe Equippable_MeleeWeapon.__c__DisplayClass37_0 __4__this
				{
					get
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_MeleeWeapon.__c__DisplayClass37_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this);
						System.IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Equippable_MeleeWeapon.__c__DisplayClass37_0>(intPtr2) : null;
					}
					set
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_MeleeWeapon.__c__DisplayClass37_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x04009C8E RID: 40078
				private static readonly System.IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x04009C8F RID: 40079
				private static readonly System.IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x04009C90 RID: 40080
				private static readonly System.IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x04009C91 RID: 40081
				private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x04009C92 RID: 40082
				private static readonly System.IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x04009C93 RID: 40083
				private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x04009C94 RID: 40084
				private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x04009C95 RID: 40085
				private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x04009C96 RID: 40086
				private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
			}
		}
	}
}
