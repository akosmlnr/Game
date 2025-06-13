using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Audio;
using UnityEngine;
using UnityEngine.Events;

namespace Il2CppScheduleOne.AvatarFramework.Equipping
{
	// Token: 0x02000626 RID: 1574
	public class AvatarWeapon : AvatarEquippable
	{
		// Token: 0x060089D5 RID: 35285 RVA: 0x00247EB0 File Offset: 0x002460B0
		// Note: this type is marked as 'beforefieldinit'.
		static AvatarWeapon()
		{
			Il2CppClassPointerStore<AvatarWeapon>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.AvatarFramework.Equipping", "AvatarWeapon");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AvatarWeapon>.NativeClassPtr);
			AvatarWeapon.NativeFieldInfoPtr_MinUseRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarWeapon>.NativeClassPtr, "MinUseRange");
			AvatarWeapon.NativeFieldInfoPtr_MaxUseRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarWeapon>.NativeClassPtr, "MaxUseRange");
			AvatarWeapon.NativeFieldInfoPtr_CooldownDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarWeapon>.NativeClassPtr, "CooldownDuration");
			AvatarWeapon.NativeFieldInfoPtr_EquipClips = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarWeapon>.NativeClassPtr, "EquipClips");
			AvatarWeapon.NativeFieldInfoPtr_EquipSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarWeapon>.NativeClassPtr, "EquipSound");
			AvatarWeapon.NativeFieldInfoPtr__LastUseTime_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarWeapon>.NativeClassPtr, "<LastUseTime>k__BackingField");
			AvatarWeapon.NativeFieldInfoPtr_onSuccessfulHit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarWeapon>.NativeClassPtr, "onSuccessfulHit");
			AvatarWeapon.NativeMethodInfoPtr_get_LastUseTime_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarWeapon>.NativeClassPtr, 100680589);
			AvatarWeapon.NativeMethodInfoPtr_set_LastUseTime_Private_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarWeapon>.NativeClassPtr, 100680590);
			AvatarWeapon.NativeMethodInfoPtr_Equip_Public_Virtual_Void_Avatar_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarWeapon>.NativeClassPtr, 100680591);
			AvatarWeapon.NativeMethodInfoPtr_Attack_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarWeapon>.NativeClassPtr, 100680592);
			AvatarWeapon.NativeMethodInfoPtr_IsReadyToAttack_Public_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarWeapon>.NativeClassPtr, 100680593);
			AvatarWeapon.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarWeapon>.NativeClassPtr, 100680594);
		}

		// Token: 0x170029BA RID: 10682
		// (get) Token: 0x060089D6 RID: 35286 RVA: 0x00247FE4 File Offset: 0x002461E4
		// (set) Token: 0x060089D7 RID: 35287 RVA: 0x00248020 File Offset: 0x00246220
		public unsafe float LastUseTime
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr obj = IL2CPP.il2cpp_runtime_invoke(AvatarWeapon.NativeMethodInfoPtr_get_LastUseTime_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarWeapon.NativeMethodInfoPtr_set_LastUseTime_Private_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x060089D8 RID: 35288 RVA: 0x00248060 File Offset: 0x00246260
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 255613, XrefRangeEnd = 255620, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Equip(Avatar _avatar)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(_avatar);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AvatarWeapon.NativeMethodInfoPtr_Equip_Public_Virtual_Void_Avatar_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060089D9 RID: 35289 RVA: 0x002480B0 File Offset: 0x002462B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 255620, XrefRangeEnd = 255621, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Attack()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AvatarWeapon.NativeMethodInfoPtr_Attack_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060089DA RID: 35290 RVA: 0x002480EC File Offset: 0x002462EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 255621, XrefRangeEnd = 255622, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool IsReadyToAttack()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AvatarWeapon.NativeMethodInfoPtr_IsReadyToAttack_Public_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x060089DB RID: 35291 RVA: 0x00248134 File Offset: 0x00246334
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 255630, RefRangeEnd = 255634, XrefRangeStart = 255622, XrefRangeEnd = 255630, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AvatarWeapon() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AvatarWeapon>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarWeapon.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060089DC RID: 35292 RVA: 0x0004161A File Offset: 0x0003F81A
		public AvatarWeapon(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170029B3 RID: 10675
		// (get) Token: 0x060089DD RID: 35293 RVA: 0x00248170 File Offset: 0x00246370
		// (set) Token: 0x060089DE RID: 35294 RVA: 0x00041623 File Offset: 0x0003F823
		public unsafe float MinUseRange
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarWeapon.NativeFieldInfoPtr_MinUseRange);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarWeapon.NativeFieldInfoPtr_MinUseRange)) = value;
			}
		}

		// Token: 0x170029B4 RID: 10676
		// (get) Token: 0x060089DF RID: 35295 RVA: 0x00248198 File Offset: 0x00246398
		// (set) Token: 0x060089E0 RID: 35296 RVA: 0x0004163E File Offset: 0x0003F83E
		public unsafe float MaxUseRange
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarWeapon.NativeFieldInfoPtr_MaxUseRange);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarWeapon.NativeFieldInfoPtr_MaxUseRange)) = value;
			}
		}

		// Token: 0x170029B5 RID: 10677
		// (get) Token: 0x060089E1 RID: 35297 RVA: 0x002481C0 File Offset: 0x002463C0
		// (set) Token: 0x060089E2 RID: 35298 RVA: 0x00041659 File Offset: 0x0003F859
		public unsafe float CooldownDuration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarWeapon.NativeFieldInfoPtr_CooldownDuration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarWeapon.NativeFieldInfoPtr_CooldownDuration)) = value;
			}
		}

		// Token: 0x170029B6 RID: 10678
		// (get) Token: 0x060089E3 RID: 35299 RVA: 0x002481E8 File Offset: 0x002463E8
		// (set) Token: 0x060089E4 RID: 35300 RVA: 0x00041674 File Offset: 0x0003F874
		public unsafe Il2CppReferenceArray<AudioClip> EquipClips
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarWeapon.NativeFieldInfoPtr_EquipClips);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<AudioClip>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarWeapon.NativeFieldInfoPtr_EquipClips), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170029B7 RID: 10679
		// (get) Token: 0x060089E5 RID: 35301 RVA: 0x00248218 File Offset: 0x00246418
		// (set) Token: 0x060089E6 RID: 35302 RVA: 0x00041693 File Offset: 0x0003F893
		public unsafe AudioSourceController EquipSound
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarWeapon.NativeFieldInfoPtr_EquipSound);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarWeapon.NativeFieldInfoPtr_EquipSound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170029B8 RID: 10680
		// (get) Token: 0x060089E7 RID: 35303 RVA: 0x00248248 File Offset: 0x00246448
		// (set) Token: 0x060089E8 RID: 35304 RVA: 0x000416B2 File Offset: 0x0003F8B2
		public unsafe float _LastUseTime_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarWeapon.NativeFieldInfoPtr__LastUseTime_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarWeapon.NativeFieldInfoPtr__LastUseTime_k__BackingField)) = value;
			}
		}

		// Token: 0x170029B9 RID: 10681
		// (get) Token: 0x060089E9 RID: 35305 RVA: 0x00248270 File Offset: 0x00246470
		// (set) Token: 0x060089EA RID: 35306 RVA: 0x000416CD File Offset: 0x0003F8CD
		public unsafe UnityEvent onSuccessfulHit
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarWeapon.NativeFieldInfoPtr_onSuccessfulHit);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarWeapon.NativeFieldInfoPtr_onSuccessfulHit), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04005DC4 RID: 24004
		private static readonly IntPtr NativeFieldInfoPtr_MinUseRange;

		// Token: 0x04005DC5 RID: 24005
		private static readonly IntPtr NativeFieldInfoPtr_MaxUseRange;

		// Token: 0x04005DC6 RID: 24006
		private static readonly IntPtr NativeFieldInfoPtr_CooldownDuration;

		// Token: 0x04005DC7 RID: 24007
		private static readonly IntPtr NativeFieldInfoPtr_EquipClips;

		// Token: 0x04005DC8 RID: 24008
		private static readonly IntPtr NativeFieldInfoPtr_EquipSound;

		// Token: 0x04005DC9 RID: 24009
		private static readonly IntPtr NativeFieldInfoPtr__LastUseTime_k__BackingField;

		// Token: 0x04005DCA RID: 24010
		private static readonly IntPtr NativeFieldInfoPtr_onSuccessfulHit;

		// Token: 0x04005DCB RID: 24011
		private static readonly IntPtr NativeMethodInfoPtr_get_LastUseTime_Public_get_Single_0;

		// Token: 0x04005DCC RID: 24012
		private static readonly IntPtr NativeMethodInfoPtr_set_LastUseTime_Private_set_Void_Single_0;

		// Token: 0x04005DCD RID: 24013
		private static readonly IntPtr NativeMethodInfoPtr_Equip_Public_Virtual_Void_Avatar_0;

		// Token: 0x04005DCE RID: 24014
		private static readonly IntPtr NativeMethodInfoPtr_Attack_Public_Virtual_New_Void_0;

		// Token: 0x04005DCF RID: 24015
		private static readonly IntPtr NativeMethodInfoPtr_IsReadyToAttack_Public_Virtual_New_Boolean_0;

		// Token: 0x04005DD0 RID: 24016
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
