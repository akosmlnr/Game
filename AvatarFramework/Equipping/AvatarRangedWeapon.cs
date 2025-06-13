using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Audio;
using Il2CppScheduleOne.PlayerScripts;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine;

namespace Il2CppScheduleOne.AvatarFramework.Equipping
{
	// Token: 0x02000625 RID: 1573
	public class AvatarRangedWeapon : AvatarWeapon
	{
		// Token: 0x0600899E RID: 35230 RVA: 0x002475A8 File Offset: 0x002457A8
		// Note: this type is marked as 'beforefieldinit'.
		static AvatarRangedWeapon()
		{
			Il2CppClassPointerStore<AvatarRangedWeapon>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.AvatarFramework.Equipping", "AvatarRangedWeapon");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AvatarRangedWeapon>.NativeClassPtr);
			AvatarRangedWeapon.NativeFieldInfoPtr_RaycastLayers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarRangedWeapon>.NativeClassPtr, "RaycastLayers");
			AvatarRangedWeapon.NativeFieldInfoPtr_MagazineSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarRangedWeapon>.NativeClassPtr, "MagazineSize");
			AvatarRangedWeapon.NativeFieldInfoPtr_ReloadTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarRangedWeapon>.NativeClassPtr, "ReloadTime");
			AvatarRangedWeapon.NativeFieldInfoPtr_MaxFireRate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarRangedWeapon>.NativeClassPtr, "MaxFireRate");
			AvatarRangedWeapon.NativeFieldInfoPtr_CanShootWhileMoving = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarRangedWeapon>.NativeClassPtr, "CanShootWhileMoving");
			AvatarRangedWeapon.NativeFieldInfoPtr_EquipTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarRangedWeapon>.NativeClassPtr, "EquipTime");
			AvatarRangedWeapon.NativeFieldInfoPtr_RaiseTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarRangedWeapon>.NativeClassPtr, "RaiseTime");
			AvatarRangedWeapon.NativeFieldInfoPtr_Damage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarRangedWeapon>.NativeClassPtr, "Damage");
			AvatarRangedWeapon.NativeFieldInfoPtr_HitChange_MinRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarRangedWeapon>.NativeClassPtr, "HitChange_MinRange");
			AvatarRangedWeapon.NativeFieldInfoPtr_HitChange_MaxRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarRangedWeapon>.NativeClassPtr, "HitChange_MaxRange");
			AvatarRangedWeapon.NativeFieldInfoPtr_MuzzlePoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarRangedWeapon>.NativeClassPtr, "MuzzlePoint");
			AvatarRangedWeapon.NativeFieldInfoPtr_FireSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarRangedWeapon>.NativeClassPtr, "FireSound");
			AvatarRangedWeapon.NativeFieldInfoPtr_LoweredAnimationTrigger = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarRangedWeapon>.NativeClassPtr, "LoweredAnimationTrigger");
			AvatarRangedWeapon.NativeFieldInfoPtr_RaisedAnimationTrigger = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarRangedWeapon>.NativeClassPtr, "RaisedAnimationTrigger");
			AvatarRangedWeapon.NativeFieldInfoPtr_RecoilAnimationTrigger = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarRangedWeapon>.NativeClassPtr, "RecoilAnimationTrigger");
			AvatarRangedWeapon.NativeFieldInfoPtr__IsRaised_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarRangedWeapon>.NativeClassPtr, "<IsRaised>k__BackingField");
			AvatarRangedWeapon.NativeFieldInfoPtr_isReloading = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarRangedWeapon>.NativeClassPtr, "isReloading");
			AvatarRangedWeapon.NativeFieldInfoPtr_timeEquipped = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarRangedWeapon>.NativeClassPtr, "timeEquipped");
			AvatarRangedWeapon.NativeFieldInfoPtr_timeRaised = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarRangedWeapon>.NativeClassPtr, "timeRaised");
			AvatarRangedWeapon.NativeFieldInfoPtr_timeSinceLastShot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarRangedWeapon>.NativeClassPtr, "timeSinceLastShot");
			AvatarRangedWeapon.NativeFieldInfoPtr_currentAmmo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarRangedWeapon>.NativeClassPtr, "currentAmmo");
			AvatarRangedWeapon.NativeMethodInfoPtr_get_IsRaised_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarRangedWeapon>.NativeClassPtr, 100680571);
			AvatarRangedWeapon.NativeMethodInfoPtr_set_IsRaised_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarRangedWeapon>.NativeClassPtr, 100680572);
			AvatarRangedWeapon.NativeMethodInfoPtr_Equip_Public_Virtual_Void_Avatar_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarRangedWeapon>.NativeClassPtr, 100680573);
			AvatarRangedWeapon.NativeMethodInfoPtr_SetIsRaised_Public_Virtual_New_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarRangedWeapon>.NativeClassPtr, 100680574);
			AvatarRangedWeapon.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarRangedWeapon>.NativeClassPtr, 100680575);
			AvatarRangedWeapon.NativeMethodInfoPtr_ReceiveMessage_Public_Virtual_Void_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarRangedWeapon>.NativeClassPtr, 100680576);
			AvatarRangedWeapon.NativeMethodInfoPtr_CanShoot_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarRangedWeapon>.NativeClassPtr, 100680577);
			AvatarRangedWeapon.NativeMethodInfoPtr_Shoot_Public_Virtual_New_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarRangedWeapon>.NativeClassPtr, 100680578);
			AvatarRangedWeapon.NativeMethodInfoPtr_Reload_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarRangedWeapon>.NativeClassPtr, 100680579);
			AvatarRangedWeapon.NativeMethodInfoPtr_IsPlayerInLoS_Public_Boolean_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarRangedWeapon>.NativeClassPtr, 100680580);
			AvatarRangedWeapon.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarRangedWeapon>.NativeClassPtr, 100680581);
		}

		// Token: 0x170029B2 RID: 10674
		// (get) Token: 0x0600899F RID: 35231 RVA: 0x00247858 File Offset: 0x00245A58
		// (set) Token: 0x060089A0 RID: 35232 RVA: 0x00247894 File Offset: 0x00245A94
		public unsafe bool IsRaised
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(AvatarRangedWeapon.NativeMethodInfoPtr_get_IsRaised_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
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
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarRangedWeapon.NativeMethodInfoPtr_set_IsRaised_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x060089A1 RID: 35233 RVA: 0x002478D4 File Offset: 0x00245AD4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 255513, XrefRangeEnd = 255520, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Equip(Avatar _avatar)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(_avatar);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AvatarRangedWeapon.NativeMethodInfoPtr_Equip_Public_Virtual_Void_Avatar_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060089A2 RID: 35234 RVA: 0x00247924 File Offset: 0x00245B24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 255520, XrefRangeEnd = 255524, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetIsRaised(bool raised)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref raised;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AvatarRangedWeapon.NativeMethodInfoPtr_SetIsRaised_Public_Virtual_New_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060089A3 RID: 35235 RVA: 0x00247970 File Offset: 0x00245B70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 255524, XrefRangeEnd = 255527, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarRangedWeapon.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060089A4 RID: 35236 RVA: 0x002479A4 File Offset: 0x00245BA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 255527, XrefRangeEnd = 255539, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ReceiveMessage(string message, Il2CppSystem.Object data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(data);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AvatarRangedWeapon.NativeMethodInfoPtr_ReceiveMessage_Public_Virtual_Void_String_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060089A5 RID: 35237 RVA: 0x00247A04 File Offset: 0x00245C04
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 255539, RefRangeEnd = 255540, XrefRangeStart = 255539, XrefRangeEnd = 255539, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool CanShoot()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(AvatarRangedWeapon.NativeMethodInfoPtr_CanShoot_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x060089A6 RID: 35238 RVA: 0x00247A40 File Offset: 0x00245C40
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 255559, RefRangeEnd = 255561, XrefRangeStart = 255540, XrefRangeEnd = 255559, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Shoot(Vector3 endPoint)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref endPoint;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AvatarRangedWeapon.NativeMethodInfoPtr_Shoot_Public_Virtual_New_Void_Vector3_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060089A7 RID: 35239 RVA: 0x00247A8C File Offset: 0x00245C8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 255561, XrefRangeEnd = 255566, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator Reload()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarRangedWeapon.NativeMethodInfoPtr_Reload_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr2) : null;
		}

		// Token: 0x060089A8 RID: 35240 RVA: 0x00247ACC File Offset: 0x00245CCC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 255611, RefRangeEnd = 255612, XrefRangeStart = 255566, XrefRangeEnd = 255611, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsPlayerInLoS(Player target)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(AvatarRangedWeapon.NativeMethodInfoPtr_IsPlayerInLoS_Public_Boolean_Player_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x060089A9 RID: 35241 RVA: 0x00247B1C File Offset: 0x00245D1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 255612, XrefRangeEnd = 255613, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AvatarRangedWeapon() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AvatarRangedWeapon>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarRangedWeapon.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060089AA RID: 35242 RVA: 0x000413CF File Offset: 0x0003F5CF
		public AvatarRangedWeapon(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700299D RID: 10653
		// (get) Token: 0x060089AB RID: 35243 RVA: 0x00247B58 File Offset: 0x00245D58
		// (set) Token: 0x060089AC RID: 35244 RVA: 0x000413D8 File Offset: 0x0003F5D8
		public unsafe static Il2CppStringArray RaycastLayers
		{
			get
			{
				System.IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(AvatarRangedWeapon.NativeFieldInfoPtr_RaycastLayers, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AvatarRangedWeapon.NativeFieldInfoPtr_RaycastLayers, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700299E RID: 10654
		// (get) Token: 0x060089AD RID: 35245 RVA: 0x00247B80 File Offset: 0x00245D80
		// (set) Token: 0x060089AE RID: 35246 RVA: 0x000413EA File Offset: 0x0003F5EA
		public unsafe int MagazineSize
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarRangedWeapon.NativeFieldInfoPtr_MagazineSize);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarRangedWeapon.NativeFieldInfoPtr_MagazineSize)) = value;
			}
		}

		// Token: 0x1700299F RID: 10655
		// (get) Token: 0x060089AF RID: 35247 RVA: 0x00247BA8 File Offset: 0x00245DA8
		// (set) Token: 0x060089B0 RID: 35248 RVA: 0x00041405 File Offset: 0x0003F605
		public unsafe float ReloadTime
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarRangedWeapon.NativeFieldInfoPtr_ReloadTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarRangedWeapon.NativeFieldInfoPtr_ReloadTime)) = value;
			}
		}

		// Token: 0x170029A0 RID: 10656
		// (get) Token: 0x060089B1 RID: 35249 RVA: 0x00247BD0 File Offset: 0x00245DD0
		// (set) Token: 0x060089B2 RID: 35250 RVA: 0x00041420 File Offset: 0x0003F620
		public unsafe float MaxFireRate
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarRangedWeapon.NativeFieldInfoPtr_MaxFireRate);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarRangedWeapon.NativeFieldInfoPtr_MaxFireRate)) = value;
			}
		}

		// Token: 0x170029A1 RID: 10657
		// (get) Token: 0x060089B3 RID: 35251 RVA: 0x00247BF8 File Offset: 0x00245DF8
		// (set) Token: 0x060089B4 RID: 35252 RVA: 0x0004143B File Offset: 0x0003F63B
		public unsafe bool CanShootWhileMoving
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarRangedWeapon.NativeFieldInfoPtr_CanShootWhileMoving);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarRangedWeapon.NativeFieldInfoPtr_CanShootWhileMoving)) = value;
			}
		}

		// Token: 0x170029A2 RID: 10658
		// (get) Token: 0x060089B5 RID: 35253 RVA: 0x00247C20 File Offset: 0x00245E20
		// (set) Token: 0x060089B6 RID: 35254 RVA: 0x00041456 File Offset: 0x0003F656
		public unsafe float EquipTime
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarRangedWeapon.NativeFieldInfoPtr_EquipTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarRangedWeapon.NativeFieldInfoPtr_EquipTime)) = value;
			}
		}

		// Token: 0x170029A3 RID: 10659
		// (get) Token: 0x060089B7 RID: 35255 RVA: 0x00247C48 File Offset: 0x00245E48
		// (set) Token: 0x060089B8 RID: 35256 RVA: 0x00041471 File Offset: 0x0003F671
		public unsafe float RaiseTime
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarRangedWeapon.NativeFieldInfoPtr_RaiseTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarRangedWeapon.NativeFieldInfoPtr_RaiseTime)) = value;
			}
		}

		// Token: 0x170029A4 RID: 10660
		// (get) Token: 0x060089B9 RID: 35257 RVA: 0x00247C70 File Offset: 0x00245E70
		// (set) Token: 0x060089BA RID: 35258 RVA: 0x0004148C File Offset: 0x0003F68C
		public unsafe float Damage
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarRangedWeapon.NativeFieldInfoPtr_Damage);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarRangedWeapon.NativeFieldInfoPtr_Damage)) = value;
			}
		}

		// Token: 0x170029A5 RID: 10661
		// (get) Token: 0x060089BB RID: 35259 RVA: 0x00247C98 File Offset: 0x00245E98
		// (set) Token: 0x060089BC RID: 35260 RVA: 0x000414A7 File Offset: 0x0003F6A7
		public unsafe float HitChange_MinRange
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarRangedWeapon.NativeFieldInfoPtr_HitChange_MinRange);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarRangedWeapon.NativeFieldInfoPtr_HitChange_MinRange)) = value;
			}
		}

		// Token: 0x170029A6 RID: 10662
		// (get) Token: 0x060089BD RID: 35261 RVA: 0x00247CC0 File Offset: 0x00245EC0
		// (set) Token: 0x060089BE RID: 35262 RVA: 0x000414C2 File Offset: 0x0003F6C2
		public unsafe float HitChange_MaxRange
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarRangedWeapon.NativeFieldInfoPtr_HitChange_MaxRange);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarRangedWeapon.NativeFieldInfoPtr_HitChange_MaxRange)) = value;
			}
		}

		// Token: 0x170029A7 RID: 10663
		// (get) Token: 0x060089BF RID: 35263 RVA: 0x00247CE8 File Offset: 0x00245EE8
		// (set) Token: 0x060089C0 RID: 35264 RVA: 0x000414DD File Offset: 0x0003F6DD
		public unsafe Transform MuzzlePoint
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarRangedWeapon.NativeFieldInfoPtr_MuzzlePoint);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarRangedWeapon.NativeFieldInfoPtr_MuzzlePoint), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170029A8 RID: 10664
		// (get) Token: 0x060089C1 RID: 35265 RVA: 0x00247D18 File Offset: 0x00245F18
		// (set) Token: 0x060089C2 RID: 35266 RVA: 0x000414FC File Offset: 0x0003F6FC
		public unsafe AudioSourceController FireSound
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarRangedWeapon.NativeFieldInfoPtr_FireSound);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarRangedWeapon.NativeFieldInfoPtr_FireSound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170029A9 RID: 10665
		// (get) Token: 0x060089C3 RID: 35267 RVA: 0x00247D48 File Offset: 0x00245F48
		// (set) Token: 0x060089C4 RID: 35268 RVA: 0x0004151B File Offset: 0x0003F71B
		public unsafe string LoweredAnimationTrigger
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarRangedWeapon.NativeFieldInfoPtr_LoweredAnimationTrigger);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarRangedWeapon.NativeFieldInfoPtr_LoweredAnimationTrigger), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170029AA RID: 10666
		// (get) Token: 0x060089C5 RID: 35269 RVA: 0x00247D70 File Offset: 0x00245F70
		// (set) Token: 0x060089C6 RID: 35270 RVA: 0x0004153A File Offset: 0x0003F73A
		public unsafe string RaisedAnimationTrigger
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarRangedWeapon.NativeFieldInfoPtr_RaisedAnimationTrigger);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarRangedWeapon.NativeFieldInfoPtr_RaisedAnimationTrigger), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170029AB RID: 10667
		// (get) Token: 0x060089C7 RID: 35271 RVA: 0x00247D98 File Offset: 0x00245F98
		// (set) Token: 0x060089C8 RID: 35272 RVA: 0x00041559 File Offset: 0x0003F759
		public unsafe string RecoilAnimationTrigger
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarRangedWeapon.NativeFieldInfoPtr_RecoilAnimationTrigger);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarRangedWeapon.NativeFieldInfoPtr_RecoilAnimationTrigger), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170029AC RID: 10668
		// (get) Token: 0x060089C9 RID: 35273 RVA: 0x00247DC0 File Offset: 0x00245FC0
		// (set) Token: 0x060089CA RID: 35274 RVA: 0x00041578 File Offset: 0x0003F778
		public unsafe bool _IsRaised_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarRangedWeapon.NativeFieldInfoPtr__IsRaised_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarRangedWeapon.NativeFieldInfoPtr__IsRaised_k__BackingField)) = value;
			}
		}

		// Token: 0x170029AD RID: 10669
		// (get) Token: 0x060089CB RID: 35275 RVA: 0x00247DE8 File Offset: 0x00245FE8
		// (set) Token: 0x060089CC RID: 35276 RVA: 0x00041593 File Offset: 0x0003F793
		public unsafe bool isReloading
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarRangedWeapon.NativeFieldInfoPtr_isReloading);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarRangedWeapon.NativeFieldInfoPtr_isReloading)) = value;
			}
		}

		// Token: 0x170029AE RID: 10670
		// (get) Token: 0x060089CD RID: 35277 RVA: 0x00247E10 File Offset: 0x00246010
		// (set) Token: 0x060089CE RID: 35278 RVA: 0x000415AE File Offset: 0x0003F7AE
		public unsafe float timeEquipped
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarRangedWeapon.NativeFieldInfoPtr_timeEquipped);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarRangedWeapon.NativeFieldInfoPtr_timeEquipped)) = value;
			}
		}

		// Token: 0x170029AF RID: 10671
		// (get) Token: 0x060089CF RID: 35279 RVA: 0x00247E38 File Offset: 0x00246038
		// (set) Token: 0x060089D0 RID: 35280 RVA: 0x000415C9 File Offset: 0x0003F7C9
		public unsafe float timeRaised
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarRangedWeapon.NativeFieldInfoPtr_timeRaised);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarRangedWeapon.NativeFieldInfoPtr_timeRaised)) = value;
			}
		}

		// Token: 0x170029B0 RID: 10672
		// (get) Token: 0x060089D1 RID: 35281 RVA: 0x00247E60 File Offset: 0x00246060
		// (set) Token: 0x060089D2 RID: 35282 RVA: 0x000415E4 File Offset: 0x0003F7E4
		public unsafe float timeSinceLastShot
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarRangedWeapon.NativeFieldInfoPtr_timeSinceLastShot);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarRangedWeapon.NativeFieldInfoPtr_timeSinceLastShot)) = value;
			}
		}

		// Token: 0x170029B1 RID: 10673
		// (get) Token: 0x060089D3 RID: 35283 RVA: 0x00247E88 File Offset: 0x00246088
		// (set) Token: 0x060089D4 RID: 35284 RVA: 0x000415FF File Offset: 0x0003F7FF
		public unsafe int currentAmmo
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarRangedWeapon.NativeFieldInfoPtr_currentAmmo);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarRangedWeapon.NativeFieldInfoPtr_currentAmmo)) = value;
			}
		}

		// Token: 0x04005DA4 RID: 23972
		private static readonly System.IntPtr NativeFieldInfoPtr_RaycastLayers;

		// Token: 0x04005DA5 RID: 23973
		private static readonly System.IntPtr NativeFieldInfoPtr_MagazineSize;

		// Token: 0x04005DA6 RID: 23974
		private static readonly System.IntPtr NativeFieldInfoPtr_ReloadTime;

		// Token: 0x04005DA7 RID: 23975
		private static readonly System.IntPtr NativeFieldInfoPtr_MaxFireRate;

		// Token: 0x04005DA8 RID: 23976
		private static readonly System.IntPtr NativeFieldInfoPtr_CanShootWhileMoving;

		// Token: 0x04005DA9 RID: 23977
		private static readonly System.IntPtr NativeFieldInfoPtr_EquipTime;

		// Token: 0x04005DAA RID: 23978
		private static readonly System.IntPtr NativeFieldInfoPtr_RaiseTime;

		// Token: 0x04005DAB RID: 23979
		private static readonly System.IntPtr NativeFieldInfoPtr_Damage;

		// Token: 0x04005DAC RID: 23980
		private static readonly System.IntPtr NativeFieldInfoPtr_HitChange_MinRange;

		// Token: 0x04005DAD RID: 23981
		private static readonly System.IntPtr NativeFieldInfoPtr_HitChange_MaxRange;

		// Token: 0x04005DAE RID: 23982
		private static readonly System.IntPtr NativeFieldInfoPtr_MuzzlePoint;

		// Token: 0x04005DAF RID: 23983
		private static readonly System.IntPtr NativeFieldInfoPtr_FireSound;

		// Token: 0x04005DB0 RID: 23984
		private static readonly System.IntPtr NativeFieldInfoPtr_LoweredAnimationTrigger;

		// Token: 0x04005DB1 RID: 23985
		private static readonly System.IntPtr NativeFieldInfoPtr_RaisedAnimationTrigger;

		// Token: 0x04005DB2 RID: 23986
		private static readonly System.IntPtr NativeFieldInfoPtr_RecoilAnimationTrigger;

		// Token: 0x04005DB3 RID: 23987
		private static readonly System.IntPtr NativeFieldInfoPtr__IsRaised_k__BackingField;

		// Token: 0x04005DB4 RID: 23988
		private static readonly System.IntPtr NativeFieldInfoPtr_isReloading;

		// Token: 0x04005DB5 RID: 23989
		private static readonly System.IntPtr NativeFieldInfoPtr_timeEquipped;

		// Token: 0x04005DB6 RID: 23990
		private static readonly System.IntPtr NativeFieldInfoPtr_timeRaised;

		// Token: 0x04005DB7 RID: 23991
		private static readonly System.IntPtr NativeFieldInfoPtr_timeSinceLastShot;

		// Token: 0x04005DB8 RID: 23992
		private static readonly System.IntPtr NativeFieldInfoPtr_currentAmmo;

		// Token: 0x04005DB9 RID: 23993
		private static readonly System.IntPtr NativeMethodInfoPtr_get_IsRaised_Public_get_Boolean_0;

		// Token: 0x04005DBA RID: 23994
		private static readonly System.IntPtr NativeMethodInfoPtr_set_IsRaised_Protected_set_Void_Boolean_0;

		// Token: 0x04005DBB RID: 23995
		private static readonly System.IntPtr NativeMethodInfoPtr_Equip_Public_Virtual_Void_Avatar_0;

		// Token: 0x04005DBC RID: 23996
		private static readonly System.IntPtr NativeMethodInfoPtr_SetIsRaised_Public_Virtual_New_Void_Boolean_0;

		// Token: 0x04005DBD RID: 23997
		private static readonly System.IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x04005DBE RID: 23998
		private static readonly System.IntPtr NativeMethodInfoPtr_ReceiveMessage_Public_Virtual_Void_String_Object_0;

		// Token: 0x04005DBF RID: 23999
		private static readonly System.IntPtr NativeMethodInfoPtr_CanShoot_Public_Boolean_0;

		// Token: 0x04005DC0 RID: 24000
		private static readonly System.IntPtr NativeMethodInfoPtr_Shoot_Public_Virtual_New_Void_Vector3_0;

		// Token: 0x04005DC1 RID: 24001
		private static readonly System.IntPtr NativeMethodInfoPtr_Reload_Private_IEnumerator_0;

		// Token: 0x04005DC2 RID: 24002
		private static readonly System.IntPtr NativeMethodInfoPtr_IsPlayerInLoS_Public_Boolean_Player_0;

		// Token: 0x04005DC3 RID: 24003
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000B47 RID: 2887
		[ObfuscatedName("ScheduleOne.AvatarFramework.Equipping.AvatarRangedWeapon+<Reload>d__30")]
		public sealed class _Reload_d__30 : Il2CppSystem.Object
		{
			// Token: 0x0600DB0E RID: 56078 RVA: 0x00345004 File Offset: 0x00343204
			// Note: this type is marked as 'beforefieldinit'.
			static _Reload_d__30()
			{
				Il2CppClassPointerStore<AvatarRangedWeapon._Reload_d__30>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AvatarRangedWeapon>.NativeClassPtr, "<Reload>d__30");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AvatarRangedWeapon._Reload_d__30>.NativeClassPtr);
				AvatarRangedWeapon._Reload_d__30.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarRangedWeapon._Reload_d__30>.NativeClassPtr, "<>1__state");
				AvatarRangedWeapon._Reload_d__30.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarRangedWeapon._Reload_d__30>.NativeClassPtr, "<>2__current");
				AvatarRangedWeapon._Reload_d__30.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarRangedWeapon._Reload_d__30>.NativeClassPtr, "<>4__this");
				AvatarRangedWeapon._Reload_d__30.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarRangedWeapon._Reload_d__30>.NativeClassPtr, 100680583);
				AvatarRangedWeapon._Reload_d__30.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarRangedWeapon._Reload_d__30>.NativeClassPtr, 100680584);
				AvatarRangedWeapon._Reload_d__30.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarRangedWeapon._Reload_d__30>.NativeClassPtr, 100680585);
				AvatarRangedWeapon._Reload_d__30.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarRangedWeapon._Reload_d__30>.NativeClassPtr, 100680586);
				AvatarRangedWeapon._Reload_d__30.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarRangedWeapon._Reload_d__30>.NativeClassPtr, 100680587);
				AvatarRangedWeapon._Reload_d__30.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarRangedWeapon._Reload_d__30>.NativeClassPtr, 100680588);
			}

			// Token: 0x0600DB0F RID: 56079 RVA: 0x003450E4 File Offset: 0x003432E4
			[CallerCount(54)]
			[CachedScanResults(RefRangeStart = 2646, RefRangeEnd = 2700, XrefRangeStart = 2646, XrefRangeEnd = 2700, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _Reload_d__30(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AvatarRangedWeapon._Reload_d__30>.NativeClassPtr))
			{
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = ref <>1__state;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarRangedWeapon._Reload_d__30.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600DB10 RID: 56080 RVA: 0x0034512C File Offset: 0x0034332C
			[CallerCount(14558)]
			[CachedScanResults(RefRangeStart = 2769, RefRangeEnd = 17327, XrefRangeStart = 2769, XrefRangeEnd = 17327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarRangedWeapon._Reload_d__30.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600DB11 RID: 56081 RVA: 0x00345160 File Offset: 0x00343360
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 255503, XrefRangeEnd = 255508, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(AvatarRangedWeapon._Reload_d__30.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x17004397 RID: 17303
			// (get) Token: 0x0600DB12 RID: 56082 RVA: 0x0034519C File Offset: 0x0034339C
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 2740, RefRangeEnd = 2764, XrefRangeStart = 2740, XrefRangeEnd = 2764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarRangedWeapon._Reload_d__30.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
			}

			// Token: 0x0600DB13 RID: 56083 RVA: 0x003451DC File Offset: 0x003433DC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 255508, XrefRangeEnd = 255513, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarRangedWeapon._Reload_d__30.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x17004398 RID: 17304
			// (get) Token: 0x0600DB14 RID: 56084 RVA: 0x00345210 File Offset: 0x00343410
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 2740, RefRangeEnd = 2764, XrefRangeStart = 2740, XrefRangeEnd = 2764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarRangedWeapon._Reload_d__30.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
			}

			// Token: 0x0600DB15 RID: 56085 RVA: 0x0006A49E File Offset: 0x0006869E
			public _Reload_d__30(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004394 RID: 17300
			// (get) Token: 0x0600DB16 RID: 56086 RVA: 0x00345250 File Offset: 0x00343450
			// (set) Token: 0x0600DB17 RID: 56087 RVA: 0x0006A4A7 File Offset: 0x000686A7
			public unsafe int __1__state
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarRangedWeapon._Reload_d__30.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarRangedWeapon._Reload_d__30.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17004395 RID: 17301
			// (get) Token: 0x0600DB18 RID: 56088 RVA: 0x00345278 File Offset: 0x00343478
			// (set) Token: 0x0600DB19 RID: 56089 RVA: 0x0006A4C2 File Offset: 0x000686C2
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarRangedWeapon._Reload_d__30.NativeFieldInfoPtr___2__current);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarRangedWeapon._Reload_d__30.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004396 RID: 17302
			// (get) Token: 0x0600DB1A RID: 56090 RVA: 0x003452A8 File Offset: 0x003434A8
			// (set) Token: 0x0600DB1B RID: 56091 RVA: 0x0006A4E1 File Offset: 0x000686E1
			public unsafe AvatarRangedWeapon __4__this
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarRangedWeapon._Reload_d__30.NativeFieldInfoPtr___4__this);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AvatarRangedWeapon>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarRangedWeapon._Reload_d__30.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400936B RID: 37739
			private static readonly System.IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400936C RID: 37740
			private static readonly System.IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x0400936D RID: 37741
			private static readonly System.IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400936E RID: 37742
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400936F RID: 37743
			private static readonly System.IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04009370 RID: 37744
			private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04009371 RID: 37745
			private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04009372 RID: 37746
			private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04009373 RID: 37747
			private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
