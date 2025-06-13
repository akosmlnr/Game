using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Audio;
using Il2CppScheduleOne.ItemFramework;
using Il2CppScheduleOne.Storage;
using Il2CppScheduleOne.Trash;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine;
using UnityEngine.Events;

namespace Il2CppScheduleOne.Equipping
{
	// Token: 0x020005E6 RID: 1510
	public class Equippable_RangedWeapon : Equippable_AvatarViewmodel
	{
		// Token: 0x0600837D RID: 33661 RVA: 0x00233404 File Offset: 0x00231604
		// Note: this type is marked as 'beforefieldinit'.
		static Equippable_RangedWeapon()
		{
			Il2CppClassPointerStore<Equippable_RangedWeapon>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Equipping", "Equippable_RangedWeapon");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Equippable_RangedWeapon>.NativeClassPtr);
			Equippable_RangedWeapon.NativeFieldInfoPtr_NPC_AIM_DETECTION_RANGE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_RangedWeapon>.NativeClassPtr, "NPC_AIM_DETECTION_RANGE");
			Equippable_RangedWeapon.NativeFieldInfoPtr__Aim_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_RangedWeapon>.NativeClassPtr, "<Aim>k__BackingField");
			Equippable_RangedWeapon.NativeFieldInfoPtr__Accuracy_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_RangedWeapon>.NativeClassPtr, "<Accuracy>k__BackingField");
			Equippable_RangedWeapon.NativeFieldInfoPtr__TimeSinceFire_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_RangedWeapon>.NativeClassPtr, "<TimeSinceFire>k__BackingField");
			Equippable_RangedWeapon.NativeFieldInfoPtr__IsReloading_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_RangedWeapon>.NativeClassPtr, "<IsReloading>k__BackingField");
			Equippable_RangedWeapon.NativeFieldInfoPtr__IsCocked_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_RangedWeapon>.NativeClassPtr, "<IsCocked>k__BackingField");
			Equippable_RangedWeapon.NativeFieldInfoPtr__IsCocking_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_RangedWeapon>.NativeClassPtr, "<IsCocking>k__BackingField");
			Equippable_RangedWeapon.NativeFieldInfoPtr_MagazineSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_RangedWeapon>.NativeClassPtr, "MagazineSize");
			Equippable_RangedWeapon.NativeFieldInfoPtr_AimDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_RangedWeapon>.NativeClassPtr, "AimDuration");
			Equippable_RangedWeapon.NativeFieldInfoPtr_AimFOVReduction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_RangedWeapon>.NativeClassPtr, "AimFOVReduction");
			Equippable_RangedWeapon.NativeFieldInfoPtr_FOVChangeDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_RangedWeapon>.NativeClassPtr, "FOVChangeDuration");
			Equippable_RangedWeapon.NativeFieldInfoPtr_FireSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_RangedWeapon>.NativeClassPtr, "FireSound");
			Equippable_RangedWeapon.NativeFieldInfoPtr_EmptySound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_RangedWeapon>.NativeClassPtr, "EmptySound");
			Equippable_RangedWeapon.NativeFieldInfoPtr_FireCooldown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_RangedWeapon>.NativeClassPtr, "FireCooldown");
			Equippable_RangedWeapon.NativeFieldInfoPtr_FireAnimTriggers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_RangedWeapon>.NativeClassPtr, "FireAnimTriggers");
			Equippable_RangedWeapon.NativeFieldInfoPtr_AccuracyChangeDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_RangedWeapon>.NativeClassPtr, "AccuracyChangeDuration");
			Equippable_RangedWeapon.NativeFieldInfoPtr_Range = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_RangedWeapon>.NativeClassPtr, "Range");
			Equippable_RangedWeapon.NativeFieldInfoPtr_RayRadius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_RangedWeapon>.NativeClassPtr, "RayRadius");
			Equippable_RangedWeapon.NativeFieldInfoPtr_MinSpread = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_RangedWeapon>.NativeClassPtr, "MinSpread");
			Equippable_RangedWeapon.NativeFieldInfoPtr_MaxSpread = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_RangedWeapon>.NativeClassPtr, "MaxSpread");
			Equippable_RangedWeapon.NativeFieldInfoPtr_Damage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_RangedWeapon>.NativeClassPtr, "Damage");
			Equippable_RangedWeapon.NativeFieldInfoPtr_ImpactForce = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_RangedWeapon>.NativeClassPtr, "ImpactForce");
			Equippable_RangedWeapon.NativeFieldInfoPtr_CanReload = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_RangedWeapon>.NativeClassPtr, "CanReload");
			Equippable_RangedWeapon.NativeFieldInfoPtr_IncrementalReload = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_RangedWeapon>.NativeClassPtr, "IncrementalReload");
			Equippable_RangedWeapon.NativeFieldInfoPtr_Magazine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_RangedWeapon>.NativeClassPtr, "Magazine");
			Equippable_RangedWeapon.NativeFieldInfoPtr_ReloadStartTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_RangedWeapon>.NativeClassPtr, "ReloadStartTime");
			Equippable_RangedWeapon.NativeFieldInfoPtr_ReloadIndividalTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_RangedWeapon>.NativeClassPtr, "ReloadIndividalTime");
			Equippable_RangedWeapon.NativeFieldInfoPtr_ReloadEndTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_RangedWeapon>.NativeClassPtr, "ReloadEndTime");
			Equippable_RangedWeapon.NativeFieldInfoPtr_ReloadStartAnimTrigger = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_RangedWeapon>.NativeClassPtr, "ReloadStartAnimTrigger");
			Equippable_RangedWeapon.NativeFieldInfoPtr_ReloadIndividualAnimTrigger = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_RangedWeapon>.NativeClassPtr, "ReloadIndividualAnimTrigger");
			Equippable_RangedWeapon.NativeFieldInfoPtr_ReloadEndAnimTrigger = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_RangedWeapon>.NativeClassPtr, "ReloadEndAnimTrigger");
			Equippable_RangedWeapon.NativeFieldInfoPtr_ReloadTrash = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_RangedWeapon>.NativeClassPtr, "ReloadTrash");
			Equippable_RangedWeapon.NativeFieldInfoPtr_MustBeCocked = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_RangedWeapon>.NativeClassPtr, "MustBeCocked");
			Equippable_RangedWeapon.NativeFieldInfoPtr_CockTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_RangedWeapon>.NativeClassPtr, "CockTime");
			Equippable_RangedWeapon.NativeFieldInfoPtr_CockAnimTrigger = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_RangedWeapon>.NativeClassPtr, "CockAnimTrigger");
			Equippable_RangedWeapon.NativeFieldInfoPtr_TracerSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_RangedWeapon>.NativeClassPtr, "TracerSpeed");
			Equippable_RangedWeapon.NativeFieldInfoPtr_onFire = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_RangedWeapon>.NativeClassPtr, "onFire");
			Equippable_RangedWeapon.NativeFieldInfoPtr_onReloadStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_RangedWeapon>.NativeClassPtr, "onReloadStart");
			Equippable_RangedWeapon.NativeFieldInfoPtr_onReloadIndividual = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_RangedWeapon>.NativeClassPtr, "onReloadIndividual");
			Equippable_RangedWeapon.NativeFieldInfoPtr_onReloadEnd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_RangedWeapon>.NativeClassPtr, "onReloadEnd");
			Equippable_RangedWeapon.NativeFieldInfoPtr_onCockStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_RangedWeapon>.NativeClassPtr, "onCockStart");
			Equippable_RangedWeapon.NativeFieldInfoPtr_weaponItem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_RangedWeapon>.NativeClassPtr, "weaponItem");
			Equippable_RangedWeapon.NativeFieldInfoPtr_fovOverridden = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_RangedWeapon>.NativeClassPtr, "fovOverridden");
			Equippable_RangedWeapon.NativeFieldInfoPtr_aimVelocity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_RangedWeapon>.NativeClassPtr, "aimVelocity");
			Equippable_RangedWeapon.NativeFieldInfoPtr_reloadRoutine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_RangedWeapon>.NativeClassPtr, "reloadRoutine");
			Equippable_RangedWeapon.NativeFieldInfoPtr_shotQueued = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_RangedWeapon>.NativeClassPtr, "shotQueued");
			Equippable_RangedWeapon.NativeFieldInfoPtr_reloadQueued = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_RangedWeapon>.NativeClassPtr, "reloadQueued");
			Equippable_RangedWeapon.NativeFieldInfoPtr_timeSincePrimaryClick = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_RangedWeapon>.NativeClassPtr, "timeSincePrimaryClick");
			Equippable_RangedWeapon.NativeMethodInfoPtr_get_Aim_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_RangedWeapon>.NativeClassPtr, 100679865);
			Equippable_RangedWeapon.NativeMethodInfoPtr_set_Aim_Private_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_RangedWeapon>.NativeClassPtr, 100679866);
			Equippable_RangedWeapon.NativeMethodInfoPtr_get_Accuracy_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_RangedWeapon>.NativeClassPtr, 100679867);
			Equippable_RangedWeapon.NativeMethodInfoPtr_set_Accuracy_Private_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_RangedWeapon>.NativeClassPtr, 100679868);
			Equippable_RangedWeapon.NativeMethodInfoPtr_get_TimeSinceFire_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_RangedWeapon>.NativeClassPtr, 100679869);
			Equippable_RangedWeapon.NativeMethodInfoPtr_set_TimeSinceFire_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_RangedWeapon>.NativeClassPtr, 100679870);
			Equippable_RangedWeapon.NativeMethodInfoPtr_get_IsReloading_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_RangedWeapon>.NativeClassPtr, 100679871);
			Equippable_RangedWeapon.NativeMethodInfoPtr_set_IsReloading_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_RangedWeapon>.NativeClassPtr, 100679872);
			Equippable_RangedWeapon.NativeMethodInfoPtr_get_IsCocked_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_RangedWeapon>.NativeClassPtr, 100679873);
			Equippable_RangedWeapon.NativeMethodInfoPtr_set_IsCocked_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_RangedWeapon>.NativeClassPtr, 100679874);
			Equippable_RangedWeapon.NativeMethodInfoPtr_get_IsCocking_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_RangedWeapon>.NativeClassPtr, 100679875);
			Equippable_RangedWeapon.NativeMethodInfoPtr_set_IsCocking_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_RangedWeapon>.NativeClassPtr, 100679876);
			Equippable_RangedWeapon.NativeMethodInfoPtr_get_Ammo_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_RangedWeapon>.NativeClassPtr, 100679877);
			Equippable_RangedWeapon.NativeMethodInfoPtr_get_aimFov_Private_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_RangedWeapon>.NativeClassPtr, 100679878);
			Equippable_RangedWeapon.NativeMethodInfoPtr_Equip_Public_Virtual_Void_ItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_RangedWeapon>.NativeClassPtr, 100679879);
			Equippable_RangedWeapon.NativeMethodInfoPtr_Unequip_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_RangedWeapon>.NativeClassPtr, 100679880);
			Equippable_RangedWeapon.NativeMethodInfoPtr_Update_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_RangedWeapon>.NativeClassPtr, 100679881);
			Equippable_RangedWeapon.NativeMethodInfoPtr_UpdateInput_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_RangedWeapon>.NativeClassPtr, 100679882);
			Equippable_RangedWeapon.NativeMethodInfoPtr_UpdateAnim_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_RangedWeapon>.NativeClassPtr, 100679883);
			Equippable_RangedWeapon.NativeMethodInfoPtr_CanAim_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_RangedWeapon>.NativeClassPtr, 100679884);
			Equippable_RangedWeapon.NativeMethodInfoPtr_Fire_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_RangedWeapon>.NativeClassPtr, 100679885);
			Equippable_RangedWeapon.NativeMethodInfoPtr_Reload_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_RangedWeapon>.NativeClassPtr, 100679886);
			Equippable_RangedWeapon.NativeMethodInfoPtr_NotifyIncrementalReload_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_RangedWeapon>.NativeClassPtr, 100679887);
			Equippable_RangedWeapon.NativeMethodInfoPtr_IsReloadReady_Private_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_RangedWeapon>.NativeClassPtr, 100679888);
			Equippable_RangedWeapon.NativeMethodInfoPtr_GetMagazine_Protected_Virtual_New_Boolean_byref_StorableItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_RangedWeapon>.NativeClassPtr, 100679889);
			Equippable_RangedWeapon.NativeMethodInfoPtr_CanFire_Private_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_RangedWeapon>.NativeClassPtr, 100679890);
			Equippable_RangedWeapon.NativeMethodInfoPtr_CanCock_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_RangedWeapon>.NativeClassPtr, 100679891);
			Equippable_RangedWeapon.NativeMethodInfoPtr_Cock_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_RangedWeapon>.NativeClassPtr, 100679892);
			Equippable_RangedWeapon.NativeMethodInfoPtr_GetSpread_Private_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_RangedWeapon>.NativeClassPtr, 100679893);
			Equippable_RangedWeapon.NativeMethodInfoPtr_CheckAimingAtNPC_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_RangedWeapon>.NativeClassPtr, 100679894);
			Equippable_RangedWeapon.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_RangedWeapon>.NativeClassPtr, 100679895);
			Equippable_RangedWeapon.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_RangedWeapon>.NativeClassPtr, 100679896);
			Equippable_RangedWeapon.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_RangedWeapon>.NativeClassPtr, 100679897);
		}

		// Token: 0x170027BB RID: 10171
		// (get) Token: 0x0600837E RID: 33662 RVA: 0x00233A88 File Offset: 0x00231C88
		// (set) Token: 0x0600837F RID: 33663 RVA: 0x00233AC4 File Offset: 0x00231CC4
		public unsafe float Aim
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Equippable_RangedWeapon.NativeMethodInfoPtr_get_Aim_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
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
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Equippable_RangedWeapon.NativeMethodInfoPtr_set_Aim_Private_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x170027BC RID: 10172
		// (get) Token: 0x06008380 RID: 33664 RVA: 0x00233B04 File Offset: 0x00231D04
		// (set) Token: 0x06008381 RID: 33665 RVA: 0x00233B40 File Offset: 0x00231D40
		public unsafe float Accuracy
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Equippable_RangedWeapon.NativeMethodInfoPtr_get_Accuracy_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
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
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Equippable_RangedWeapon.NativeMethodInfoPtr_set_Accuracy_Private_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x170027BD RID: 10173
		// (get) Token: 0x06008382 RID: 33666 RVA: 0x00233B80 File Offset: 0x00231D80
		// (set) Token: 0x06008383 RID: 33667 RVA: 0x00233BBC File Offset: 0x00231DBC
		public unsafe float TimeSinceFire
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Equippable_RangedWeapon.NativeMethodInfoPtr_get_TimeSinceFire_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
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
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Equippable_RangedWeapon.NativeMethodInfoPtr_set_TimeSinceFire_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x170027BE RID: 10174
		// (get) Token: 0x06008384 RID: 33668 RVA: 0x00233BFC File Offset: 0x00231DFC
		// (set) Token: 0x06008385 RID: 33669 RVA: 0x00233C38 File Offset: 0x00231E38
		public unsafe bool IsReloading
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 248941, RefRangeEnd = 248942, XrefRangeStart = 248941, XrefRangeEnd = 248941, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Equippable_RangedWeapon.NativeMethodInfoPtr_get_IsReloading_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
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
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Equippable_RangedWeapon.NativeMethodInfoPtr_set_IsReloading_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x170027BF RID: 10175
		// (get) Token: 0x06008386 RID: 33670 RVA: 0x00233C78 File Offset: 0x00231E78
		// (set) Token: 0x06008387 RID: 33671 RVA: 0x00233CB4 File Offset: 0x00231EB4
		public unsafe bool IsCocked
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Equippable_RangedWeapon.NativeMethodInfoPtr_get_IsCocked_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
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
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Equippable_RangedWeapon.NativeMethodInfoPtr_set_IsCocked_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x170027C0 RID: 10176
		// (get) Token: 0x06008388 RID: 33672 RVA: 0x00233CF4 File Offset: 0x00231EF4
		// (set) Token: 0x06008389 RID: 33673 RVA: 0x00233D30 File Offset: 0x00231F30
		public unsafe bool IsCocking
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Equippable_RangedWeapon.NativeMethodInfoPtr_get_IsCocking_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
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
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Equippable_RangedWeapon.NativeMethodInfoPtr_set_IsCocking_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x170027C1 RID: 10177
		// (get) Token: 0x0600838A RID: 33674 RVA: 0x00233D70 File Offset: 0x00231F70
		public unsafe int Ammo
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Equippable_RangedWeapon.NativeMethodInfoPtr_get_Ammo_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
		}

		// Token: 0x170027C2 RID: 10178
		// (get) Token: 0x0600838B RID: 33675 RVA: 0x00233DAC File Offset: 0x00231FAC
		public unsafe float aimFov
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 248942, XrefRangeEnd = 248946, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Equippable_RangedWeapon.NativeMethodInfoPtr_get_aimFov_Private_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
		}

		// Token: 0x0600838C RID: 33676 RVA: 0x00233DE8 File Offset: 0x00231FE8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 248968, RefRangeEnd = 248969, XrefRangeStart = 248946, XrefRangeEnd = 248968, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Equip(ItemInstance item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Equippable_RangedWeapon.NativeMethodInfoPtr_Equip_Public_Virtual_Void_ItemInstance_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600838D RID: 33677 RVA: 0x00233E38 File Offset: 0x00232038
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 248969, XrefRangeEnd = 248993, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Unequip()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Equippable_RangedWeapon.NativeMethodInfoPtr_Unequip_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600838E RID: 33678 RVA: 0x00233E74 File Offset: 0x00232074
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 248993, XrefRangeEnd = 249008, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Equippable_RangedWeapon.NativeMethodInfoPtr_Update_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600838F RID: 33679 RVA: 0x00233EB0 File Offset: 0x002320B0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 249109, RefRangeEnd = 249110, XrefRangeStart = 249008, XrefRangeEnd = 249109, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateInput()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Equippable_RangedWeapon.NativeMethodInfoPtr_UpdateInput_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008390 RID: 33680 RVA: 0x00233EE4 File Offset: 0x002320E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 249110, XrefRangeEnd = 249118, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateAnim()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Equippable_RangedWeapon.NativeMethodInfoPtr_UpdateAnim_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008391 RID: 33681 RVA: 0x00233F18 File Offset: 0x00232118
		[CallerCount(21)]
		[CachedScanResults(RefRangeStart = 31612, RefRangeEnd = 31633, XrefRangeStart = 31612, XrefRangeEnd = 31633, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool CanAim()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Equippable_RangedWeapon.NativeMethodInfoPtr_CanAim_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06008392 RID: 33682 RVA: 0x00233F54 File Offset: 0x00232154
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 249255, RefRangeEnd = 249256, XrefRangeStart = 249118, XrefRangeEnd = 249255, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Fire()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Equippable_RangedWeapon.NativeMethodInfoPtr_Fire_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008393 RID: 33683 RVA: 0x00233F90 File Offset: 0x00232190
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 249256, XrefRangeEnd = 249269, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Reload()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Equippable_RangedWeapon.NativeMethodInfoPtr_Reload_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008394 RID: 33684 RVA: 0x00233FCC File Offset: 0x002321CC
		[CallerCount(14558)]
		[CachedScanResults(RefRangeStart = 2769, RefRangeEnd = 17327, XrefRangeStart = 2769, XrefRangeEnd = 17327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void NotifyIncrementalReload()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Equippable_RangedWeapon.NativeMethodInfoPtr_NotifyIncrementalReload_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008395 RID: 33685 RVA: 0x00234008 File Offset: 0x00232208
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 249269, RefRangeEnd = 249270, XrefRangeStart = 249269, XrefRangeEnd = 249269, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsReloadReady(bool ignoreTiming)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref ignoreTiming;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Equippable_RangedWeapon.NativeMethodInfoPtr_IsReloadReady_Private_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06008396 RID: 33686 RVA: 0x00234054 File Offset: 0x00232254
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 249270, XrefRangeEnd = 249298, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool GetMagazine(out StorableItemInstance mag)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			ref System.IntPtr ptr2 = ref *ptr;
			System.IntPtr intPtr = 0;
			ptr2 = &intPtr;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Equippable_RangedWeapon.NativeMethodInfoPtr_GetMagazine_Protected_Virtual_New_Boolean_byref_StorableItemInstance_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			mag = ((intPtr2 == 0) ? null : new StorableItemInstance(intPtr2));
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06008397 RID: 33687 RVA: 0x002340C0 File Offset: 0x002322C0
		[CallerCount(0)]
		public unsafe bool CanFire(bool checkAmmo = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref checkAmmo;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Equippable_RangedWeapon.NativeMethodInfoPtr_CanFire_Private_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06008398 RID: 33688 RVA: 0x0023410C File Offset: 0x0023230C
		[CallerCount(0)]
		public unsafe bool CanCock()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Equippable_RangedWeapon.NativeMethodInfoPtr_CanCock_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06008399 RID: 33689 RVA: 0x00234148 File Offset: 0x00232348
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 249298, XrefRangeEnd = 249310, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Cock()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Equippable_RangedWeapon.NativeMethodInfoPtr_Cock_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600839A RID: 33690 RVA: 0x0023417C File Offset: 0x0023237C
		[CallerCount(0)]
		public unsafe float GetSpread()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Equippable_RangedWeapon.NativeMethodInfoPtr_GetSpread_Private_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x0600839B RID: 33691 RVA: 0x002341B8 File Offset: 0x002323B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 249310, XrefRangeEnd = 249367, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CheckAimingAtNPC()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Equippable_RangedWeapon.NativeMethodInfoPtr_CheckAimingAtNPC_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600839C RID: 33692 RVA: 0x002341EC File Offset: 0x002323EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 249367, XrefRangeEnd = 249380, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Equippable_RangedWeapon() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Equippable_RangedWeapon>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Equippable_RangedWeapon.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600839D RID: 33693 RVA: 0x00234228 File Offset: 0x00232428
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 249380, XrefRangeEnd = 249385, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator Method_Private_IEnumerator_PDM_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Equippable_RangedWeapon.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr2) : null;
		}

		// Token: 0x0600839E RID: 33694 RVA: 0x00234268 File Offset: 0x00232468
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 249385, XrefRangeEnd = 249390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator Method_Private_IEnumerator_PDM_1()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Equippable_RangedWeapon.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr2) : null;
		}

		// Token: 0x0600839F RID: 33695 RVA: 0x0003E308 File Offset: 0x0003C508
		public Equippable_RangedWeapon(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700278B RID: 10123
		// (get) Token: 0x060083A0 RID: 33696 RVA: 0x002342A8 File Offset: 0x002324A8
		// (set) Token: 0x060083A1 RID: 33697 RVA: 0x0003E311 File Offset: 0x0003C511
		public unsafe static float NPC_AIM_DETECTION_RANGE
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(Equippable_RangedWeapon.NativeFieldInfoPtr_NPC_AIM_DETECTION_RANGE, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Equippable_RangedWeapon.NativeFieldInfoPtr_NPC_AIM_DETECTION_RANGE, (void*)(&value));
			}
		}

		// Token: 0x1700278C RID: 10124
		// (get) Token: 0x060083A2 RID: 33698 RVA: 0x002342C4 File Offset: 0x002324C4
		// (set) Token: 0x060083A3 RID: 33699 RVA: 0x0003E31F File Offset: 0x0003C51F
		public unsafe float _Aim_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_RangedWeapon.NativeFieldInfoPtr__Aim_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_RangedWeapon.NativeFieldInfoPtr__Aim_k__BackingField)) = value;
			}
		}

		// Token: 0x1700278D RID: 10125
		// (get) Token: 0x060083A4 RID: 33700 RVA: 0x002342EC File Offset: 0x002324EC
		// (set) Token: 0x060083A5 RID: 33701 RVA: 0x0003E33A File Offset: 0x0003C53A
		public unsafe float _Accuracy_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_RangedWeapon.NativeFieldInfoPtr__Accuracy_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_RangedWeapon.NativeFieldInfoPtr__Accuracy_k__BackingField)) = value;
			}
		}

		// Token: 0x1700278E RID: 10126
		// (get) Token: 0x060083A6 RID: 33702 RVA: 0x00234314 File Offset: 0x00232514
		// (set) Token: 0x060083A7 RID: 33703 RVA: 0x0003E355 File Offset: 0x0003C555
		public unsafe float _TimeSinceFire_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_RangedWeapon.NativeFieldInfoPtr__TimeSinceFire_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_RangedWeapon.NativeFieldInfoPtr__TimeSinceFire_k__BackingField)) = value;
			}
		}

		// Token: 0x1700278F RID: 10127
		// (get) Token: 0x060083A8 RID: 33704 RVA: 0x0023433C File Offset: 0x0023253C
		// (set) Token: 0x060083A9 RID: 33705 RVA: 0x0003E370 File Offset: 0x0003C570
		public unsafe bool _IsReloading_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_RangedWeapon.NativeFieldInfoPtr__IsReloading_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_RangedWeapon.NativeFieldInfoPtr__IsReloading_k__BackingField)) = value;
			}
		}

		// Token: 0x17002790 RID: 10128
		// (get) Token: 0x060083AA RID: 33706 RVA: 0x00234364 File Offset: 0x00232564
		// (set) Token: 0x060083AB RID: 33707 RVA: 0x0003E38B File Offset: 0x0003C58B
		public unsafe bool _IsCocked_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_RangedWeapon.NativeFieldInfoPtr__IsCocked_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_RangedWeapon.NativeFieldInfoPtr__IsCocked_k__BackingField)) = value;
			}
		}

		// Token: 0x17002791 RID: 10129
		// (get) Token: 0x060083AC RID: 33708 RVA: 0x0023438C File Offset: 0x0023258C
		// (set) Token: 0x060083AD RID: 33709 RVA: 0x0003E3A6 File Offset: 0x0003C5A6
		public unsafe bool _IsCocking_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_RangedWeapon.NativeFieldInfoPtr__IsCocking_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_RangedWeapon.NativeFieldInfoPtr__IsCocking_k__BackingField)) = value;
			}
		}

		// Token: 0x17002792 RID: 10130
		// (get) Token: 0x060083AE RID: 33710 RVA: 0x002343B4 File Offset: 0x002325B4
		// (set) Token: 0x060083AF RID: 33711 RVA: 0x0003E3C1 File Offset: 0x0003C5C1
		public unsafe int MagazineSize
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_RangedWeapon.NativeFieldInfoPtr_MagazineSize);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_RangedWeapon.NativeFieldInfoPtr_MagazineSize)) = value;
			}
		}

		// Token: 0x17002793 RID: 10131
		// (get) Token: 0x060083B0 RID: 33712 RVA: 0x002343DC File Offset: 0x002325DC
		// (set) Token: 0x060083B1 RID: 33713 RVA: 0x0003E3DC File Offset: 0x0003C5DC
		public unsafe float AimDuration
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_RangedWeapon.NativeFieldInfoPtr_AimDuration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_RangedWeapon.NativeFieldInfoPtr_AimDuration)) = value;
			}
		}

		// Token: 0x17002794 RID: 10132
		// (get) Token: 0x060083B2 RID: 33714 RVA: 0x00234404 File Offset: 0x00232604
		// (set) Token: 0x060083B3 RID: 33715 RVA: 0x0003E3F7 File Offset: 0x0003C5F7
		public unsafe float AimFOVReduction
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_RangedWeapon.NativeFieldInfoPtr_AimFOVReduction);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_RangedWeapon.NativeFieldInfoPtr_AimFOVReduction)) = value;
			}
		}

		// Token: 0x17002795 RID: 10133
		// (get) Token: 0x060083B4 RID: 33716 RVA: 0x0023442C File Offset: 0x0023262C
		// (set) Token: 0x060083B5 RID: 33717 RVA: 0x0003E412 File Offset: 0x0003C612
		public unsafe float FOVChangeDuration
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_RangedWeapon.NativeFieldInfoPtr_FOVChangeDuration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_RangedWeapon.NativeFieldInfoPtr_FOVChangeDuration)) = value;
			}
		}

		// Token: 0x17002796 RID: 10134
		// (get) Token: 0x060083B6 RID: 33718 RVA: 0x00234454 File Offset: 0x00232654
		// (set) Token: 0x060083B7 RID: 33719 RVA: 0x0003E42D File Offset: 0x0003C62D
		public unsafe AudioSourceController FireSound
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_RangedWeapon.NativeFieldInfoPtr_FireSound);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_RangedWeapon.NativeFieldInfoPtr_FireSound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002797 RID: 10135
		// (get) Token: 0x060083B8 RID: 33720 RVA: 0x00234484 File Offset: 0x00232684
		// (set) Token: 0x060083B9 RID: 33721 RVA: 0x0003E44C File Offset: 0x0003C64C
		public unsafe AudioSourceController EmptySound
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_RangedWeapon.NativeFieldInfoPtr_EmptySound);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_RangedWeapon.NativeFieldInfoPtr_EmptySound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002798 RID: 10136
		// (get) Token: 0x060083BA RID: 33722 RVA: 0x002344B4 File Offset: 0x002326B4
		// (set) Token: 0x060083BB RID: 33723 RVA: 0x0003E46B File Offset: 0x0003C66B
		public unsafe float FireCooldown
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_RangedWeapon.NativeFieldInfoPtr_FireCooldown);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_RangedWeapon.NativeFieldInfoPtr_FireCooldown)) = value;
			}
		}

		// Token: 0x17002799 RID: 10137
		// (get) Token: 0x060083BC RID: 33724 RVA: 0x002344DC File Offset: 0x002326DC
		// (set) Token: 0x060083BD RID: 33725 RVA: 0x0003E486 File Offset: 0x0003C686
		public unsafe Il2CppStringArray FireAnimTriggers
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_RangedWeapon.NativeFieldInfoPtr_FireAnimTriggers);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_RangedWeapon.NativeFieldInfoPtr_FireAnimTriggers), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700279A RID: 10138
		// (get) Token: 0x060083BE RID: 33726 RVA: 0x0023450C File Offset: 0x0023270C
		// (set) Token: 0x060083BF RID: 33727 RVA: 0x0003E4A5 File Offset: 0x0003C6A5
		public unsafe float AccuracyChangeDuration
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_RangedWeapon.NativeFieldInfoPtr_AccuracyChangeDuration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_RangedWeapon.NativeFieldInfoPtr_AccuracyChangeDuration)) = value;
			}
		}

		// Token: 0x1700279B RID: 10139
		// (get) Token: 0x060083C0 RID: 33728 RVA: 0x00234534 File Offset: 0x00232734
		// (set) Token: 0x060083C1 RID: 33729 RVA: 0x0003E4C0 File Offset: 0x0003C6C0
		public unsafe float Range
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_RangedWeapon.NativeFieldInfoPtr_Range);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_RangedWeapon.NativeFieldInfoPtr_Range)) = value;
			}
		}

		// Token: 0x1700279C RID: 10140
		// (get) Token: 0x060083C2 RID: 33730 RVA: 0x0023455C File Offset: 0x0023275C
		// (set) Token: 0x060083C3 RID: 33731 RVA: 0x0003E4DB File Offset: 0x0003C6DB
		public unsafe float RayRadius
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_RangedWeapon.NativeFieldInfoPtr_RayRadius);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_RangedWeapon.NativeFieldInfoPtr_RayRadius)) = value;
			}
		}

		// Token: 0x1700279D RID: 10141
		// (get) Token: 0x060083C4 RID: 33732 RVA: 0x00234584 File Offset: 0x00232784
		// (set) Token: 0x060083C5 RID: 33733 RVA: 0x0003E4F6 File Offset: 0x0003C6F6
		public unsafe float MinSpread
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_RangedWeapon.NativeFieldInfoPtr_MinSpread);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_RangedWeapon.NativeFieldInfoPtr_MinSpread)) = value;
			}
		}

		// Token: 0x1700279E RID: 10142
		// (get) Token: 0x060083C6 RID: 33734 RVA: 0x002345AC File Offset: 0x002327AC
		// (set) Token: 0x060083C7 RID: 33735 RVA: 0x0003E511 File Offset: 0x0003C711
		public unsafe float MaxSpread
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_RangedWeapon.NativeFieldInfoPtr_MaxSpread);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_RangedWeapon.NativeFieldInfoPtr_MaxSpread)) = value;
			}
		}

		// Token: 0x1700279F RID: 10143
		// (get) Token: 0x060083C8 RID: 33736 RVA: 0x002345D4 File Offset: 0x002327D4
		// (set) Token: 0x060083C9 RID: 33737 RVA: 0x0003E52C File Offset: 0x0003C72C
		public unsafe float Damage
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_RangedWeapon.NativeFieldInfoPtr_Damage);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_RangedWeapon.NativeFieldInfoPtr_Damage)) = value;
			}
		}

		// Token: 0x170027A0 RID: 10144
		// (get) Token: 0x060083CA RID: 33738 RVA: 0x002345FC File Offset: 0x002327FC
		// (set) Token: 0x060083CB RID: 33739 RVA: 0x0003E547 File Offset: 0x0003C747
		public unsafe float ImpactForce
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_RangedWeapon.NativeFieldInfoPtr_ImpactForce);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_RangedWeapon.NativeFieldInfoPtr_ImpactForce)) = value;
			}
		}

		// Token: 0x170027A1 RID: 10145
		// (get) Token: 0x060083CC RID: 33740 RVA: 0x00234624 File Offset: 0x00232824
		// (set) Token: 0x060083CD RID: 33741 RVA: 0x0003E562 File Offset: 0x0003C762
		public unsafe bool CanReload
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_RangedWeapon.NativeFieldInfoPtr_CanReload);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_RangedWeapon.NativeFieldInfoPtr_CanReload)) = value;
			}
		}

		// Token: 0x170027A2 RID: 10146
		// (get) Token: 0x060083CE RID: 33742 RVA: 0x0023464C File Offset: 0x0023284C
		// (set) Token: 0x060083CF RID: 33743 RVA: 0x0003E57D File Offset: 0x0003C77D
		public unsafe bool IncrementalReload
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_RangedWeapon.NativeFieldInfoPtr_IncrementalReload);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_RangedWeapon.NativeFieldInfoPtr_IncrementalReload)) = value;
			}
		}

		// Token: 0x170027A3 RID: 10147
		// (get) Token: 0x060083D0 RID: 33744 RVA: 0x00234674 File Offset: 0x00232874
		// (set) Token: 0x060083D1 RID: 33745 RVA: 0x0003E598 File Offset: 0x0003C798
		public unsafe StorableItemDefinition Magazine
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_RangedWeapon.NativeFieldInfoPtr_Magazine);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StorableItemDefinition>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_RangedWeapon.NativeFieldInfoPtr_Magazine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170027A4 RID: 10148
		// (get) Token: 0x060083D2 RID: 33746 RVA: 0x002346A4 File Offset: 0x002328A4
		// (set) Token: 0x060083D3 RID: 33747 RVA: 0x0003E5B7 File Offset: 0x0003C7B7
		public unsafe float ReloadStartTime
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_RangedWeapon.NativeFieldInfoPtr_ReloadStartTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_RangedWeapon.NativeFieldInfoPtr_ReloadStartTime)) = value;
			}
		}

		// Token: 0x170027A5 RID: 10149
		// (get) Token: 0x060083D4 RID: 33748 RVA: 0x002346CC File Offset: 0x002328CC
		// (set) Token: 0x060083D5 RID: 33749 RVA: 0x0003E5D2 File Offset: 0x0003C7D2
		public unsafe float ReloadIndividalTime
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_RangedWeapon.NativeFieldInfoPtr_ReloadIndividalTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_RangedWeapon.NativeFieldInfoPtr_ReloadIndividalTime)) = value;
			}
		}

		// Token: 0x170027A6 RID: 10150
		// (get) Token: 0x060083D6 RID: 33750 RVA: 0x002346F4 File Offset: 0x002328F4
		// (set) Token: 0x060083D7 RID: 33751 RVA: 0x0003E5ED File Offset: 0x0003C7ED
		public unsafe float ReloadEndTime
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_RangedWeapon.NativeFieldInfoPtr_ReloadEndTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_RangedWeapon.NativeFieldInfoPtr_ReloadEndTime)) = value;
			}
		}

		// Token: 0x170027A7 RID: 10151
		// (get) Token: 0x060083D8 RID: 33752 RVA: 0x0023471C File Offset: 0x0023291C
		// (set) Token: 0x060083D9 RID: 33753 RVA: 0x0003E608 File Offset: 0x0003C808
		public unsafe string ReloadStartAnimTrigger
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_RangedWeapon.NativeFieldInfoPtr_ReloadStartAnimTrigger);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_RangedWeapon.NativeFieldInfoPtr_ReloadStartAnimTrigger), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170027A8 RID: 10152
		// (get) Token: 0x060083DA RID: 33754 RVA: 0x00234744 File Offset: 0x00232944
		// (set) Token: 0x060083DB RID: 33755 RVA: 0x0003E627 File Offset: 0x0003C827
		public unsafe string ReloadIndividualAnimTrigger
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_RangedWeapon.NativeFieldInfoPtr_ReloadIndividualAnimTrigger);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_RangedWeapon.NativeFieldInfoPtr_ReloadIndividualAnimTrigger), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170027A9 RID: 10153
		// (get) Token: 0x060083DC RID: 33756 RVA: 0x0023476C File Offset: 0x0023296C
		// (set) Token: 0x060083DD RID: 33757 RVA: 0x0003E646 File Offset: 0x0003C846
		public unsafe string ReloadEndAnimTrigger
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_RangedWeapon.NativeFieldInfoPtr_ReloadEndAnimTrigger);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_RangedWeapon.NativeFieldInfoPtr_ReloadEndAnimTrigger), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170027AA RID: 10154
		// (get) Token: 0x060083DE RID: 33758 RVA: 0x00234794 File Offset: 0x00232994
		// (set) Token: 0x060083DF RID: 33759 RVA: 0x0003E665 File Offset: 0x0003C865
		public unsafe TrashItem ReloadTrash
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_RangedWeapon.NativeFieldInfoPtr_ReloadTrash);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TrashItem>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_RangedWeapon.NativeFieldInfoPtr_ReloadTrash), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170027AB RID: 10155
		// (get) Token: 0x060083E0 RID: 33760 RVA: 0x002347C4 File Offset: 0x002329C4
		// (set) Token: 0x060083E1 RID: 33761 RVA: 0x0003E684 File Offset: 0x0003C884
		public unsafe bool MustBeCocked
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_RangedWeapon.NativeFieldInfoPtr_MustBeCocked);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_RangedWeapon.NativeFieldInfoPtr_MustBeCocked)) = value;
			}
		}

		// Token: 0x170027AC RID: 10156
		// (get) Token: 0x060083E2 RID: 33762 RVA: 0x002347EC File Offset: 0x002329EC
		// (set) Token: 0x060083E3 RID: 33763 RVA: 0x0003E69F File Offset: 0x0003C89F
		public unsafe float CockTime
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_RangedWeapon.NativeFieldInfoPtr_CockTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_RangedWeapon.NativeFieldInfoPtr_CockTime)) = value;
			}
		}

		// Token: 0x170027AD RID: 10157
		// (get) Token: 0x060083E4 RID: 33764 RVA: 0x00234814 File Offset: 0x00232A14
		// (set) Token: 0x060083E5 RID: 33765 RVA: 0x0003E6BA File Offset: 0x0003C8BA
		public unsafe string CockAnimTrigger
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_RangedWeapon.NativeFieldInfoPtr_CockAnimTrigger);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_RangedWeapon.NativeFieldInfoPtr_CockAnimTrigger), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170027AE RID: 10158
		// (get) Token: 0x060083E6 RID: 33766 RVA: 0x0023483C File Offset: 0x00232A3C
		// (set) Token: 0x060083E7 RID: 33767 RVA: 0x0003E6D9 File Offset: 0x0003C8D9
		public unsafe float TracerSpeed
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_RangedWeapon.NativeFieldInfoPtr_TracerSpeed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_RangedWeapon.NativeFieldInfoPtr_TracerSpeed)) = value;
			}
		}

		// Token: 0x170027AF RID: 10159
		// (get) Token: 0x060083E8 RID: 33768 RVA: 0x00234864 File Offset: 0x00232A64
		// (set) Token: 0x060083E9 RID: 33769 RVA: 0x0003E6F4 File Offset: 0x0003C8F4
		public unsafe UnityEvent onFire
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_RangedWeapon.NativeFieldInfoPtr_onFire);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_RangedWeapon.NativeFieldInfoPtr_onFire), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170027B0 RID: 10160
		// (get) Token: 0x060083EA RID: 33770 RVA: 0x00234894 File Offset: 0x00232A94
		// (set) Token: 0x060083EB RID: 33771 RVA: 0x0003E713 File Offset: 0x0003C913
		public unsafe UnityEvent onReloadStart
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_RangedWeapon.NativeFieldInfoPtr_onReloadStart);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_RangedWeapon.NativeFieldInfoPtr_onReloadStart), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170027B1 RID: 10161
		// (get) Token: 0x060083EC RID: 33772 RVA: 0x002348C4 File Offset: 0x00232AC4
		// (set) Token: 0x060083ED RID: 33773 RVA: 0x0003E732 File Offset: 0x0003C932
		public unsafe UnityEvent onReloadIndividual
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_RangedWeapon.NativeFieldInfoPtr_onReloadIndividual);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_RangedWeapon.NativeFieldInfoPtr_onReloadIndividual), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170027B2 RID: 10162
		// (get) Token: 0x060083EE RID: 33774 RVA: 0x002348F4 File Offset: 0x00232AF4
		// (set) Token: 0x060083EF RID: 33775 RVA: 0x0003E751 File Offset: 0x0003C951
		public unsafe UnityEvent onReloadEnd
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_RangedWeapon.NativeFieldInfoPtr_onReloadEnd);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_RangedWeapon.NativeFieldInfoPtr_onReloadEnd), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170027B3 RID: 10163
		// (get) Token: 0x060083F0 RID: 33776 RVA: 0x00234924 File Offset: 0x00232B24
		// (set) Token: 0x060083F1 RID: 33777 RVA: 0x0003E770 File Offset: 0x0003C970
		public unsafe UnityEvent onCockStart
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_RangedWeapon.NativeFieldInfoPtr_onCockStart);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_RangedWeapon.NativeFieldInfoPtr_onCockStart), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170027B4 RID: 10164
		// (get) Token: 0x060083F2 RID: 33778 RVA: 0x00234954 File Offset: 0x00232B54
		// (set) Token: 0x060083F3 RID: 33779 RVA: 0x0003E78F File Offset: 0x0003C98F
		public unsafe IntegerItemInstance weaponItem
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_RangedWeapon.NativeFieldInfoPtr_weaponItem);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IntegerItemInstance>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_RangedWeapon.NativeFieldInfoPtr_weaponItem), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170027B5 RID: 10165
		// (get) Token: 0x060083F4 RID: 33780 RVA: 0x00234984 File Offset: 0x00232B84
		// (set) Token: 0x060083F5 RID: 33781 RVA: 0x0003E7AE File Offset: 0x0003C9AE
		public unsafe bool fovOverridden
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_RangedWeapon.NativeFieldInfoPtr_fovOverridden);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_RangedWeapon.NativeFieldInfoPtr_fovOverridden)) = value;
			}
		}

		// Token: 0x170027B6 RID: 10166
		// (get) Token: 0x060083F6 RID: 33782 RVA: 0x002349AC File Offset: 0x00232BAC
		// (set) Token: 0x060083F7 RID: 33783 RVA: 0x0003E7C9 File Offset: 0x0003C9C9
		public unsafe float aimVelocity
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_RangedWeapon.NativeFieldInfoPtr_aimVelocity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_RangedWeapon.NativeFieldInfoPtr_aimVelocity)) = value;
			}
		}

		// Token: 0x170027B7 RID: 10167
		// (get) Token: 0x060083F8 RID: 33784 RVA: 0x002349D4 File Offset: 0x00232BD4
		// (set) Token: 0x060083F9 RID: 33785 RVA: 0x0003E7E4 File Offset: 0x0003C9E4
		public unsafe Coroutine reloadRoutine
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_RangedWeapon.NativeFieldInfoPtr_reloadRoutine);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_RangedWeapon.NativeFieldInfoPtr_reloadRoutine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170027B8 RID: 10168
		// (get) Token: 0x060083FA RID: 33786 RVA: 0x00234A04 File Offset: 0x00232C04
		// (set) Token: 0x060083FB RID: 33787 RVA: 0x0003E803 File Offset: 0x0003CA03
		public unsafe bool shotQueued
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_RangedWeapon.NativeFieldInfoPtr_shotQueued);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_RangedWeapon.NativeFieldInfoPtr_shotQueued)) = value;
			}
		}

		// Token: 0x170027B9 RID: 10169
		// (get) Token: 0x060083FC RID: 33788 RVA: 0x00234A2C File Offset: 0x00232C2C
		// (set) Token: 0x060083FD RID: 33789 RVA: 0x0003E81E File Offset: 0x0003CA1E
		public unsafe bool reloadQueued
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_RangedWeapon.NativeFieldInfoPtr_reloadQueued);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_RangedWeapon.NativeFieldInfoPtr_reloadQueued)) = value;
			}
		}

		// Token: 0x170027BA RID: 10170
		// (get) Token: 0x060083FE RID: 33790 RVA: 0x00234A54 File Offset: 0x00232C54
		// (set) Token: 0x060083FF RID: 33791 RVA: 0x0003E839 File Offset: 0x0003CA39
		public unsafe float timeSincePrimaryClick
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_RangedWeapon.NativeFieldInfoPtr_timeSincePrimaryClick);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_RangedWeapon.NativeFieldInfoPtr_timeSincePrimaryClick)) = value;
			}
		}

		// Token: 0x04005985 RID: 22917
		private static readonly System.IntPtr NativeFieldInfoPtr_NPC_AIM_DETECTION_RANGE;

		// Token: 0x04005986 RID: 22918
		private static readonly System.IntPtr NativeFieldInfoPtr__Aim_k__BackingField;

		// Token: 0x04005987 RID: 22919
		private static readonly System.IntPtr NativeFieldInfoPtr__Accuracy_k__BackingField;

		// Token: 0x04005988 RID: 22920
		private static readonly System.IntPtr NativeFieldInfoPtr__TimeSinceFire_k__BackingField;

		// Token: 0x04005989 RID: 22921
		private static readonly System.IntPtr NativeFieldInfoPtr__IsReloading_k__BackingField;

		// Token: 0x0400598A RID: 22922
		private static readonly System.IntPtr NativeFieldInfoPtr__IsCocked_k__BackingField;

		// Token: 0x0400598B RID: 22923
		private static readonly System.IntPtr NativeFieldInfoPtr__IsCocking_k__BackingField;

		// Token: 0x0400598C RID: 22924
		private static readonly System.IntPtr NativeFieldInfoPtr_MagazineSize;

		// Token: 0x0400598D RID: 22925
		private static readonly System.IntPtr NativeFieldInfoPtr_AimDuration;

		// Token: 0x0400598E RID: 22926
		private static readonly System.IntPtr NativeFieldInfoPtr_AimFOVReduction;

		// Token: 0x0400598F RID: 22927
		private static readonly System.IntPtr NativeFieldInfoPtr_FOVChangeDuration;

		// Token: 0x04005990 RID: 22928
		private static readonly System.IntPtr NativeFieldInfoPtr_FireSound;

		// Token: 0x04005991 RID: 22929
		private static readonly System.IntPtr NativeFieldInfoPtr_EmptySound;

		// Token: 0x04005992 RID: 22930
		private static readonly System.IntPtr NativeFieldInfoPtr_FireCooldown;

		// Token: 0x04005993 RID: 22931
		private static readonly System.IntPtr NativeFieldInfoPtr_FireAnimTriggers;

		// Token: 0x04005994 RID: 22932
		private static readonly System.IntPtr NativeFieldInfoPtr_AccuracyChangeDuration;

		// Token: 0x04005995 RID: 22933
		private static readonly System.IntPtr NativeFieldInfoPtr_Range;

		// Token: 0x04005996 RID: 22934
		private static readonly System.IntPtr NativeFieldInfoPtr_RayRadius;

		// Token: 0x04005997 RID: 22935
		private static readonly System.IntPtr NativeFieldInfoPtr_MinSpread;

		// Token: 0x04005998 RID: 22936
		private static readonly System.IntPtr NativeFieldInfoPtr_MaxSpread;

		// Token: 0x04005999 RID: 22937
		private static readonly System.IntPtr NativeFieldInfoPtr_Damage;

		// Token: 0x0400599A RID: 22938
		private static readonly System.IntPtr NativeFieldInfoPtr_ImpactForce;

		// Token: 0x0400599B RID: 22939
		private static readonly System.IntPtr NativeFieldInfoPtr_CanReload;

		// Token: 0x0400599C RID: 22940
		private static readonly System.IntPtr NativeFieldInfoPtr_IncrementalReload;

		// Token: 0x0400599D RID: 22941
		private static readonly System.IntPtr NativeFieldInfoPtr_Magazine;

		// Token: 0x0400599E RID: 22942
		private static readonly System.IntPtr NativeFieldInfoPtr_ReloadStartTime;

		// Token: 0x0400599F RID: 22943
		private static readonly System.IntPtr NativeFieldInfoPtr_ReloadIndividalTime;

		// Token: 0x040059A0 RID: 22944
		private static readonly System.IntPtr NativeFieldInfoPtr_ReloadEndTime;

		// Token: 0x040059A1 RID: 22945
		private static readonly System.IntPtr NativeFieldInfoPtr_ReloadStartAnimTrigger;

		// Token: 0x040059A2 RID: 22946
		private static readonly System.IntPtr NativeFieldInfoPtr_ReloadIndividualAnimTrigger;

		// Token: 0x040059A3 RID: 22947
		private static readonly System.IntPtr NativeFieldInfoPtr_ReloadEndAnimTrigger;

		// Token: 0x040059A4 RID: 22948
		private static readonly System.IntPtr NativeFieldInfoPtr_ReloadTrash;

		// Token: 0x040059A5 RID: 22949
		private static readonly System.IntPtr NativeFieldInfoPtr_MustBeCocked;

		// Token: 0x040059A6 RID: 22950
		private static readonly System.IntPtr NativeFieldInfoPtr_CockTime;

		// Token: 0x040059A7 RID: 22951
		private static readonly System.IntPtr NativeFieldInfoPtr_CockAnimTrigger;

		// Token: 0x040059A8 RID: 22952
		private static readonly System.IntPtr NativeFieldInfoPtr_TracerSpeed;

		// Token: 0x040059A9 RID: 22953
		private static readonly System.IntPtr NativeFieldInfoPtr_onFire;

		// Token: 0x040059AA RID: 22954
		private static readonly System.IntPtr NativeFieldInfoPtr_onReloadStart;

		// Token: 0x040059AB RID: 22955
		private static readonly System.IntPtr NativeFieldInfoPtr_onReloadIndividual;

		// Token: 0x040059AC RID: 22956
		private static readonly System.IntPtr NativeFieldInfoPtr_onReloadEnd;

		// Token: 0x040059AD RID: 22957
		private static readonly System.IntPtr NativeFieldInfoPtr_onCockStart;

		// Token: 0x040059AE RID: 22958
		private static readonly System.IntPtr NativeFieldInfoPtr_weaponItem;

		// Token: 0x040059AF RID: 22959
		private static readonly System.IntPtr NativeFieldInfoPtr_fovOverridden;

		// Token: 0x040059B0 RID: 22960
		private static readonly System.IntPtr NativeFieldInfoPtr_aimVelocity;

		// Token: 0x040059B1 RID: 22961
		private static readonly System.IntPtr NativeFieldInfoPtr_reloadRoutine;

		// Token: 0x040059B2 RID: 22962
		private static readonly System.IntPtr NativeFieldInfoPtr_shotQueued;

		// Token: 0x040059B3 RID: 22963
		private static readonly System.IntPtr NativeFieldInfoPtr_reloadQueued;

		// Token: 0x040059B4 RID: 22964
		private static readonly System.IntPtr NativeFieldInfoPtr_timeSincePrimaryClick;

		// Token: 0x040059B5 RID: 22965
		private static readonly System.IntPtr NativeMethodInfoPtr_get_Aim_Public_get_Single_0;

		// Token: 0x040059B6 RID: 22966
		private static readonly System.IntPtr NativeMethodInfoPtr_set_Aim_Private_set_Void_Single_0;

		// Token: 0x040059B7 RID: 22967
		private static readonly System.IntPtr NativeMethodInfoPtr_get_Accuracy_Public_get_Single_0;

		// Token: 0x040059B8 RID: 22968
		private static readonly System.IntPtr NativeMethodInfoPtr_set_Accuracy_Private_set_Void_Single_0;

		// Token: 0x040059B9 RID: 22969
		private static readonly System.IntPtr NativeMethodInfoPtr_get_TimeSinceFire_Public_get_Single_0;

		// Token: 0x040059BA RID: 22970
		private static readonly System.IntPtr NativeMethodInfoPtr_set_TimeSinceFire_Public_set_Void_Single_0;

		// Token: 0x040059BB RID: 22971
		private static readonly System.IntPtr NativeMethodInfoPtr_get_IsReloading_Public_get_Boolean_0;

		// Token: 0x040059BC RID: 22972
		private static readonly System.IntPtr NativeMethodInfoPtr_set_IsReloading_Private_set_Void_Boolean_0;

		// Token: 0x040059BD RID: 22973
		private static readonly System.IntPtr NativeMethodInfoPtr_get_IsCocked_Public_get_Boolean_0;

		// Token: 0x040059BE RID: 22974
		private static readonly System.IntPtr NativeMethodInfoPtr_set_IsCocked_Private_set_Void_Boolean_0;

		// Token: 0x040059BF RID: 22975
		private static readonly System.IntPtr NativeMethodInfoPtr_get_IsCocking_Public_get_Boolean_0;

		// Token: 0x040059C0 RID: 22976
		private static readonly System.IntPtr NativeMethodInfoPtr_set_IsCocking_Private_set_Void_Boolean_0;

		// Token: 0x040059C1 RID: 22977
		private static readonly System.IntPtr NativeMethodInfoPtr_get_Ammo_Public_get_Int32_0;

		// Token: 0x040059C2 RID: 22978
		private static readonly System.IntPtr NativeMethodInfoPtr_get_aimFov_Private_get_Single_0;

		// Token: 0x040059C3 RID: 22979
		private static readonly System.IntPtr NativeMethodInfoPtr_Equip_Public_Virtual_Void_ItemInstance_0;

		// Token: 0x040059C4 RID: 22980
		private static readonly System.IntPtr NativeMethodInfoPtr_Unequip_Public_Virtual_Void_0;

		// Token: 0x040059C5 RID: 22981
		private static readonly System.IntPtr NativeMethodInfoPtr_Update_Protected_Virtual_Void_0;

		// Token: 0x040059C6 RID: 22982
		private static readonly System.IntPtr NativeMethodInfoPtr_UpdateInput_Private_Void_0;

		// Token: 0x040059C7 RID: 22983
		private static readonly System.IntPtr NativeMethodInfoPtr_UpdateAnim_Private_Void_0;

		// Token: 0x040059C8 RID: 22984
		private static readonly System.IntPtr NativeMethodInfoPtr_CanAim_Private_Boolean_0;

		// Token: 0x040059C9 RID: 22985
		private static readonly System.IntPtr NativeMethodInfoPtr_Fire_Public_Virtual_New_Void_0;

		// Token: 0x040059CA RID: 22986
		private static readonly System.IntPtr NativeMethodInfoPtr_Reload_Public_Virtual_New_Void_0;

		// Token: 0x040059CB RID: 22987
		private static readonly System.IntPtr NativeMethodInfoPtr_NotifyIncrementalReload_Protected_Virtual_New_Void_0;

		// Token: 0x040059CC RID: 22988
		private static readonly System.IntPtr NativeMethodInfoPtr_IsReloadReady_Private_Boolean_Boolean_0;

		// Token: 0x040059CD RID: 22989
		private static readonly System.IntPtr NativeMethodInfoPtr_GetMagazine_Protected_Virtual_New_Boolean_byref_StorableItemInstance_0;

		// Token: 0x040059CE RID: 22990
		private static readonly System.IntPtr NativeMethodInfoPtr_CanFire_Private_Boolean_Boolean_0;

		// Token: 0x040059CF RID: 22991
		private static readonly System.IntPtr NativeMethodInfoPtr_CanCock_Private_Boolean_0;

		// Token: 0x040059D0 RID: 22992
		private static readonly System.IntPtr NativeMethodInfoPtr_Cock_Private_Void_0;

		// Token: 0x040059D1 RID: 22993
		private static readonly System.IntPtr NativeMethodInfoPtr_GetSpread_Private_Single_0;

		// Token: 0x040059D2 RID: 22994
		private static readonly System.IntPtr NativeMethodInfoPtr_CheckAimingAtNPC_Private_Void_0;

		// Token: 0x040059D3 RID: 22995
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040059D4 RID: 22996
		private static readonly System.IntPtr NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0;

		// Token: 0x040059D5 RID: 22997
		private static readonly System.IntPtr NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_1;

		// Token: 0x02000B2E RID: 2862
		[ObfuscatedName("ScheduleOne.Equipping.Equippable_RangedWeapon+<<Cock>g__CockRoutine|83_0>d")]
		public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEqObObUnique : Il2CppSystem.Object
		{
			// Token: 0x0600DA35 RID: 55861 RVA: 0x003429C0 File Offset: 0x00340BC0
			// Note: this type is marked as 'beforefieldinit'.
			static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEqObObUnique()
			{
				Il2CppClassPointerStore<Equippable_RangedWeapon.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEqObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Equippable_RangedWeapon>.NativeClassPtr, "<<Cock>g__CockRoutine|83_0>d");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Equippable_RangedWeapon.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEqObObUnique>.NativeClassPtr);
				Equippable_RangedWeapon.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEqObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_RangedWeapon.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEqObObUnique>.NativeClassPtr, "<>1__state");
				Equippable_RangedWeapon.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEqObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_RangedWeapon.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEqObObUnique>.NativeClassPtr, "<>2__current");
				Equippable_RangedWeapon.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEqObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_RangedWeapon.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEqObObUnique>.NativeClassPtr, "<>4__this");
				Equippable_RangedWeapon.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEqObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_RangedWeapon.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEqObObUnique>.NativeClassPtr, 100679898);
				Equippable_RangedWeapon.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEqObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_RangedWeapon.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEqObObUnique>.NativeClassPtr, 100679899);
				Equippable_RangedWeapon.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEqObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_RangedWeapon.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEqObObUnique>.NativeClassPtr, 100679900);
				Equippable_RangedWeapon.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEqObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_RangedWeapon.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEqObObUnique>.NativeClassPtr, 100679901);
				Equippable_RangedWeapon.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEqObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_RangedWeapon.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEqObObUnique>.NativeClassPtr, 100679902);
				Equippable_RangedWeapon.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEqObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_RangedWeapon.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEqObObUnique>.NativeClassPtr, 100679903);
			}

			// Token: 0x0600DA36 RID: 55862 RVA: 0x00342AA0 File Offset: 0x00340CA0
			[CallerCount(54)]
			[CachedScanResults(RefRangeStart = 2646, RefRangeEnd = 2700, XrefRangeStart = 2646, XrefRangeEnd = 2700, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEqObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Equippable_RangedWeapon.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEqObObUnique>.NativeClassPtr))
			{
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = ref <>1__state;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Equippable_RangedWeapon.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEqObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600DA37 RID: 55863 RVA: 0x00342AE8 File Offset: 0x00340CE8
			[CallerCount(14558)]
			[CachedScanResults(RefRangeStart = 2769, RefRangeEnd = 17327, XrefRangeStart = 2769, XrefRangeEnd = 17327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Equippable_RangedWeapon.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEqObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600DA38 RID: 55864 RVA: 0x00342B1C File Offset: 0x00340D1C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 248902, XrefRangeEnd = 248913, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Equippable_RangedWeapon.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEqObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x17004350 RID: 17232
			// (get) Token: 0x0600DA39 RID: 55865 RVA: 0x00342B58 File Offset: 0x00340D58
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 2740, RefRangeEnd = 2764, XrefRangeStart = 2740, XrefRangeEnd = 2764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Equippable_RangedWeapon.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEqObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
			}

			// Token: 0x0600DA3A RID: 55866 RVA: 0x00342B98 File Offset: 0x00340D98
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 248913, XrefRangeEnd = 248918, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Equippable_RangedWeapon.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEqObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x17004351 RID: 17233
			// (get) Token: 0x0600DA3B RID: 55867 RVA: 0x00342BCC File Offset: 0x00340DCC
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 2740, RefRangeEnd = 2764, XrefRangeStart = 2740, XrefRangeEnd = 2764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Equippable_RangedWeapon.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEqObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
			}

			// Token: 0x0600DA3C RID: 55868 RVA: 0x00069DB6 File Offset: 0x00067FB6
			public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEqObObUnique(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700434D RID: 17229
			// (get) Token: 0x0600DA3D RID: 55869 RVA: 0x00342C0C File Offset: 0x00340E0C
			// (set) Token: 0x0600DA3E RID: 55870 RVA: 0x00069DBF File Offset: 0x00067FBF
			public unsafe int __1__state
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_RangedWeapon.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEqObObUnique.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_RangedWeapon.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEqObObUnique.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700434E RID: 17230
			// (get) Token: 0x0600DA3F RID: 55871 RVA: 0x00342C34 File Offset: 0x00340E34
			// (set) Token: 0x0600DA40 RID: 55872 RVA: 0x00069DDA File Offset: 0x00067FDA
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_RangedWeapon.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEqObObUnique.NativeFieldInfoPtr___2__current);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_RangedWeapon.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEqObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700434F RID: 17231
			// (get) Token: 0x0600DA41 RID: 55873 RVA: 0x00342C64 File Offset: 0x00340E64
			// (set) Token: 0x0600DA42 RID: 55874 RVA: 0x00069DF9 File Offset: 0x00067FF9
			public unsafe Equippable_RangedWeapon __4__this
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_RangedWeapon.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEqObObUnique.NativeFieldInfoPtr___4__this);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Equippable_RangedWeapon>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_RangedWeapon.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEqObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040092DA RID: 37594
			private static readonly System.IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040092DB RID: 37595
			private static readonly System.IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040092DC RID: 37596
			private static readonly System.IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040092DD RID: 37597
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040092DE RID: 37598
			private static readonly System.IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040092DF RID: 37599
			private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040092E0 RID: 37600
			private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040092E1 RID: 37601
			private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040092E2 RID: 37602
			private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x02000B2F RID: 2863
		[ObfuscatedName("ScheduleOne.Equipping.Equippable_RangedWeapon+<<Reload>g__ReloadRoutine|77_0>d")]
		public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEqStObObUnique : Il2CppSystem.Object
		{
			// Token: 0x0600DA43 RID: 55875 RVA: 0x00342C94 File Offset: 0x00340E94
			// Note: this type is marked as 'beforefieldinit'.
			static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEqStObObUnique()
			{
				Il2CppClassPointerStore<Equippable_RangedWeapon.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEqStObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Equippable_RangedWeapon>.NativeClassPtr, "<<Reload>g__ReloadRoutine|77_0>d");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Equippable_RangedWeapon.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEqStObObUnique>.NativeClassPtr);
				Equippable_RangedWeapon.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEqStObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_RangedWeapon.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEqStObObUnique>.NativeClassPtr, "<>1__state");
				Equippable_RangedWeapon.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEqStObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_RangedWeapon.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEqStObObUnique>.NativeClassPtr, "<>2__current");
				Equippable_RangedWeapon.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEqStObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_RangedWeapon.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEqStObObUnique>.NativeClassPtr, "<>4__this");
				Equippable_RangedWeapon.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEqStObObUnique.NativeFieldInfoPtr__mag_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_RangedWeapon.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEqStObObUnique>.NativeClassPtr, "<mag>5__2");
				Equippable_RangedWeapon.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEqStObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_RangedWeapon.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEqStObObUnique>.NativeClassPtr, 100679904);
				Equippable_RangedWeapon.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEqStObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_RangedWeapon.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEqStObObUnique>.NativeClassPtr, 100679905);
				Equippable_RangedWeapon.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEqStObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_RangedWeapon.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEqStObObUnique>.NativeClassPtr, 100679906);
				Equippable_RangedWeapon.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEqStObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_RangedWeapon.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEqStObObUnique>.NativeClassPtr, 100679907);
				Equippable_RangedWeapon.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEqStObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_RangedWeapon.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEqStObObUnique>.NativeClassPtr, 100679908);
				Equippable_RangedWeapon.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEqStObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_RangedWeapon.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEqStObObUnique>.NativeClassPtr, 100679909);
			}

			// Token: 0x0600DA44 RID: 55876 RVA: 0x00342D88 File Offset: 0x00340F88
			[CallerCount(54)]
			[CachedScanResults(RefRangeStart = 2646, RefRangeEnd = 2700, XrefRangeStart = 2646, XrefRangeEnd = 2700, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEqStObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Equippable_RangedWeapon.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEqStObObUnique>.NativeClassPtr))
			{
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = ref <>1__state;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Equippable_RangedWeapon.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEqStObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600DA45 RID: 55877 RVA: 0x00342DD0 File Offset: 0x00340FD0
			[CallerCount(14558)]
			[CachedScanResults(RefRangeStart = 2769, RefRangeEnd = 17327, XrefRangeStart = 2769, XrefRangeEnd = 17327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Equippable_RangedWeapon.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEqStObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600DA46 RID: 55878 RVA: 0x00342E04 File Offset: 0x00341004
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 248918, XrefRangeEnd = 248936, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Equippable_RangedWeapon.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEqStObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x17004356 RID: 17238
			// (get) Token: 0x0600DA47 RID: 55879 RVA: 0x00342E40 File Offset: 0x00341040
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 2740, RefRangeEnd = 2764, XrefRangeStart = 2740, XrefRangeEnd = 2764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Equippable_RangedWeapon.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEqStObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
			}

			// Token: 0x0600DA48 RID: 55880 RVA: 0x00342E80 File Offset: 0x00341080
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 248936, XrefRangeEnd = 248941, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Equippable_RangedWeapon.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEqStObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x17004357 RID: 17239
			// (get) Token: 0x0600DA49 RID: 55881 RVA: 0x00342EB4 File Offset: 0x003410B4
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 2740, RefRangeEnd = 2764, XrefRangeStart = 2740, XrefRangeEnd = 2764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Equippable_RangedWeapon.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEqStObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
			}

			// Token: 0x0600DA4A RID: 55882 RVA: 0x00069E18 File Offset: 0x00068018
			public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEqStObObUnique(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004352 RID: 17234
			// (get) Token: 0x0600DA4B RID: 55883 RVA: 0x00342EF4 File Offset: 0x003410F4
			// (set) Token: 0x0600DA4C RID: 55884 RVA: 0x00069E21 File Offset: 0x00068021
			public unsafe int __1__state
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_RangedWeapon.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEqStObObUnique.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_RangedWeapon.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEqStObObUnique.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17004353 RID: 17235
			// (get) Token: 0x0600DA4D RID: 55885 RVA: 0x00342F1C File Offset: 0x0034111C
			// (set) Token: 0x0600DA4E RID: 55886 RVA: 0x00069E3C File Offset: 0x0006803C
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_RangedWeapon.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEqStObObUnique.NativeFieldInfoPtr___2__current);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_RangedWeapon.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEqStObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004354 RID: 17236
			// (get) Token: 0x0600DA4F RID: 55887 RVA: 0x00342F4C File Offset: 0x0034114C
			// (set) Token: 0x0600DA50 RID: 55888 RVA: 0x00069E5B File Offset: 0x0006805B
			public unsafe Equippable_RangedWeapon __4__this
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_RangedWeapon.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEqStObObUnique.NativeFieldInfoPtr___4__this);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Equippable_RangedWeapon>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_RangedWeapon.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEqStObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004355 RID: 17237
			// (get) Token: 0x0600DA51 RID: 55889 RVA: 0x00342F7C File Offset: 0x0034117C
			// (set) Token: 0x0600DA52 RID: 55890 RVA: 0x00069E7A File Offset: 0x0006807A
			public unsafe StorableItemInstance _mag_5__2
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_RangedWeapon.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEqStObObUnique.NativeFieldInfoPtr__mag_5__2);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<StorableItemInstance>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_RangedWeapon.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEqStObObUnique.NativeFieldInfoPtr__mag_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040092E3 RID: 37603
			private static readonly System.IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040092E4 RID: 37604
			private static readonly System.IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040092E5 RID: 37605
			private static readonly System.IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040092E6 RID: 37606
			private static readonly System.IntPtr NativeFieldInfoPtr__mag_5__2;

			// Token: 0x040092E7 RID: 37607
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040092E8 RID: 37608
			private static readonly System.IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040092E9 RID: 37609
			private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040092EA RID: 37610
			private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040092EB RID: 37611
			private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040092EC RID: 37612
			private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x02000B30 RID: 2864
		[ObfuscatedName("ScheduleOne.Equipping.Equippable_RangedWeapon+<>c")]
		[System.Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x0600DA53 RID: 55891 RVA: 0x00342FAC File Offset: 0x003411AC
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<Equippable_RangedWeapon.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Equippable_RangedWeapon>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Equippable_RangedWeapon.__c>.NativeClassPtr);
				Equippable_RangedWeapon.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_RangedWeapon.__c>.NativeClassPtr, "<>9");
				Equippable_RangedWeapon.__c.NativeFieldInfoPtr___9__76_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_RangedWeapon.__c>.NativeClassPtr, "<>9__76_0");
				Equippable_RangedWeapon.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_RangedWeapon.__c>.NativeClassPtr, 100679911);
				Equippable_RangedWeapon.__c.NativeMethodInfoPtr__Fire_b__76_0_Internal_Int32_RaycastHit_RaycastHit_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_RangedWeapon.__c>.NativeClassPtr, 100679912);
			}

			// Token: 0x0600DA54 RID: 55892 RVA: 0x00343028 File Offset: 0x00341228
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Equippable_RangedWeapon.__c>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Equippable_RangedWeapon.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600DA55 RID: 55893 RVA: 0x00343064 File Offset: 0x00341264
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _Fire_b__76_0(RaycastHit a, RaycastHit b)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = ref a;
				ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref b;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Equippable_RangedWeapon.__c.NativeMethodInfoPtr__Fire_b__76_0_Internal_Int32_RaycastHit_RaycastHit_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x0600DA56 RID: 55894 RVA: 0x00069E99 File Offset: 0x00068099
			public __c(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004358 RID: 17240
			// (get) Token: 0x0600DA57 RID: 55895 RVA: 0x003430BC File Offset: 0x003412BC
			// (set) Token: 0x0600DA58 RID: 55896 RVA: 0x00069EA2 File Offset: 0x000680A2
			public unsafe static Equippable_RangedWeapon.__c __9
			{
				get
				{
					System.IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Equippable_RangedWeapon.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Equippable_RangedWeapon.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Equippable_RangedWeapon.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004359 RID: 17241
			// (get) Token: 0x0600DA59 RID: 55897 RVA: 0x003430E4 File Offset: 0x003412E4
			// (set) Token: 0x0600DA5A RID: 55898 RVA: 0x00069EB4 File Offset: 0x000680B4
			public unsafe static Il2CppSystem.Comparison<RaycastHit> __9__76_0
			{
				get
				{
					System.IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Equippable_RangedWeapon.__c.NativeFieldInfoPtr___9__76_0, (void*)(&intPtr));
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Comparison<RaycastHit>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Equippable_RangedWeapon.__c.NativeFieldInfoPtr___9__76_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040092ED RID: 37613
			private static readonly System.IntPtr NativeFieldInfoPtr___9;

			// Token: 0x040092EE RID: 37614
			private static readonly System.IntPtr NativeFieldInfoPtr___9__76_0;

			// Token: 0x040092EF RID: 37615
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040092F0 RID: 37616
			private static readonly System.IntPtr NativeMethodInfoPtr__Fire_b__76_0_Internal_Int32_RaycastHit_RaycastHit_0;
		}
	}
}
