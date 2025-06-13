using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using Il2CppScheduleOne.Equipping;
using Il2CppScheduleOne.ItemFramework;
using UnityEngine;

namespace Il2CppScheduleOne.Skating
{
	// Token: 0x020001B5 RID: 437
	public class Skateboard_Equippable : Equippable_Viewmodel
	{
		// Token: 0x06002491 RID: 9361 RVA: 0x000E4E38 File Offset: 0x000E3038
		// Note: this type is marked as 'beforefieldinit'.
		static Skateboard_Equippable()
		{
			Il2CppClassPointerStore<Skateboard_Equippable>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Skating", "Skateboard_Equippable");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Skateboard_Equippable>.NativeClassPtr);
			Skateboard_Equippable.NativeFieldInfoPtr_ModelLerpSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard_Equippable>.NativeClassPtr, "ModelLerpSpeed");
			Skateboard_Equippable.NativeFieldInfoPtr_SurfaceSampleDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard_Equippable>.NativeClassPtr, "SurfaceSampleDistance");
			Skateboard_Equippable.NativeFieldInfoPtr_SurfaceSampleRayLength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard_Equippable>.NativeClassPtr, "SurfaceSampleRayLength");
			Skateboard_Equippable.NativeFieldInfoPtr_BoardSpawnUpwardsShift = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard_Equippable>.NativeClassPtr, "BoardSpawnUpwardsShift");
			Skateboard_Equippable.NativeFieldInfoPtr_BoardSpawnAngleLimit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard_Equippable>.NativeClassPtr, "BoardSpawnAngleLimit");
			Skateboard_Equippable.NativeFieldInfoPtr_MountTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard_Equippable>.NativeClassPtr, "MountTime");
			Skateboard_Equippable.NativeFieldInfoPtr_BoardMomentumTransfer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard_Equippable>.NativeClassPtr, "BoardMomentumTransfer");
			Skateboard_Equippable.NativeFieldInfoPtr_DismountAngle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard_Equippable>.NativeClassPtr, "DismountAngle");
			Skateboard_Equippable.NativeFieldInfoPtr__IsRiding_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard_Equippable>.NativeClassPtr, "<IsRiding>k__BackingField");
			Skateboard_Equippable.NativeFieldInfoPtr__ActiveSkateboard_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard_Equippable>.NativeClassPtr, "<ActiveSkateboard>k__BackingField");
			Skateboard_Equippable.NativeFieldInfoPtr_SkateboardPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard_Equippable>.NativeClassPtr, "SkateboardPrefab");
			Skateboard_Equippable.NativeFieldInfoPtr_blockDismount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard_Equippable>.NativeClassPtr, "blockDismount");
			Skateboard_Equippable.NativeFieldInfoPtr_ModelContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard_Equippable>.NativeClassPtr, "ModelContainer");
			Skateboard_Equippable.NativeFieldInfoPtr_ModelPosition_Raised = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard_Equippable>.NativeClassPtr, "ModelPosition_Raised");
			Skateboard_Equippable.NativeFieldInfoPtr_ModelPosition_Lowered = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard_Equippable>.NativeClassPtr, "ModelPosition_Lowered");
			Skateboard_Equippable.NativeFieldInfoPtr_mountTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skateboard_Equippable>.NativeClassPtr, "mountTime");
			Skateboard_Equippable.NativeMethodInfoPtr_get_IsRiding_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Skateboard_Equippable>.NativeClassPtr, 100667383);
			Skateboard_Equippable.NativeMethodInfoPtr_set_IsRiding_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Skateboard_Equippable>.NativeClassPtr, 100667384);
			Skateboard_Equippable.NativeMethodInfoPtr_get_ActiveSkateboard_Public_get_Skateboard_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Skateboard_Equippable>.NativeClassPtr, 100667385);
			Skateboard_Equippable.NativeMethodInfoPtr_set_ActiveSkateboard_Private_set_Void_Skateboard_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Skateboard_Equippable>.NativeClassPtr, 100667386);
			Skateboard_Equippable.NativeMethodInfoPtr_Equip_Public_Virtual_Void_ItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Skateboard_Equippable>.NativeClassPtr, 100667387);
			Skateboard_Equippable.NativeMethodInfoPtr_Exit_Private_Void_ExitAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Skateboard_Equippable>.NativeClassPtr, 100667388);
			Skateboard_Equippable.NativeMethodInfoPtr_Update_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Skateboard_Equippable>.NativeClassPtr, 100667389);
			Skateboard_Equippable.NativeMethodInfoPtr_UpdateModel_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Skateboard_Equippable>.NativeClassPtr, 100667390);
			Skateboard_Equippable.NativeMethodInfoPtr_Unequip_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Skateboard_Equippable>.NativeClassPtr, 100667391);
			Skateboard_Equippable.NativeMethodInfoPtr_Mount_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Skateboard_Equippable>.NativeClassPtr, 100667392);
			Skateboard_Equippable.NativeMethodInfoPtr_Dismount_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Skateboard_Equippable>.NativeClassPtr, 100667393);
			Skateboard_Equippable.NativeMethodInfoPtr_CanMountHere_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Skateboard_Equippable>.NativeClassPtr, 100667394);
			Skateboard_Equippable.NativeMethodInfoPtr_GetSkateboardSpawnPose_Private_Pose_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Skateboard_Equippable>.NativeClassPtr, 100667395);
			Skateboard_Equippable.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Skateboard_Equippable>.NativeClassPtr, 100667396);
		}

		// Token: 0x17000C97 RID: 3223
		// (get) Token: 0x06002492 RID: 9362 RVA: 0x000E50C0 File Offset: 0x000E32C0
		// (set) Token: 0x06002493 RID: 9363 RVA: 0x000E50FC File Offset: 0x000E32FC
		public unsafe bool IsRiding
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Skateboard_Equippable.NativeMethodInfoPtr_get_IsRiding_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Skateboard_Equippable.NativeMethodInfoPtr_set_IsRiding_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x17000C98 RID: 3224
		// (get) Token: 0x06002494 RID: 9364 RVA: 0x000E513C File Offset: 0x000E333C
		// (set) Token: 0x06002495 RID: 9365 RVA: 0x000E517C File Offset: 0x000E337C
		public unsafe Skateboard ActiveSkateboard
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 24376, RefRangeEnd = 24377, XrefRangeStart = 24376, XrefRangeEnd = 24377, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Skateboard_Equippable.NativeMethodInfoPtr_get_ActiveSkateboard_Public_get_Skateboard_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Skateboard>(intPtr2) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 116324, XrefRangeEnd = 116325, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Skateboard_Equippable.NativeMethodInfoPtr_set_ActiveSkateboard_Private_set_Void_Skateboard_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x06002496 RID: 9366 RVA: 0x000E51C0 File Offset: 0x000E33C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 116325, XrefRangeEnd = 116344, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Equip(ItemInstance item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Skateboard_Equippable.NativeMethodInfoPtr_Equip_Public_Virtual_Void_ItemInstance_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06002497 RID: 9367 RVA: 0x000E5210 File Offset: 0x000E3410
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 116344, XrefRangeEnd = 116346, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Exit(ExitAction action)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(action);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Skateboard_Equippable.NativeMethodInfoPtr_Exit_Private_Void_ExitAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06002498 RID: 9368 RVA: 0x000E5254 File Offset: 0x000E3454
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 116346, XrefRangeEnd = 116392, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Skateboard_Equippable.NativeMethodInfoPtr_Update_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06002499 RID: 9369 RVA: 0x000E5290 File Offset: 0x000E3490
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 116392, XrefRangeEnd = 116398, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateModel()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Skateboard_Equippable.NativeMethodInfoPtr_UpdateModel_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600249A RID: 9370 RVA: 0x000E52C4 File Offset: 0x000E34C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 116398, XrefRangeEnd = 116415, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Unequip()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Skateboard_Equippable.NativeMethodInfoPtr_Unequip_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600249B RID: 9371 RVA: 0x000E5300 File Offset: 0x000E3500
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 116446, RefRangeEnd = 116447, XrefRangeStart = 116415, XrefRangeEnd = 116446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Mount()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Skateboard_Equippable.NativeMethodInfoPtr_Mount_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600249C RID: 9372 RVA: 0x000E5334 File Offset: 0x000E3534
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 116483, RefRangeEnd = 116488, XrefRangeStart = 116447, XrefRangeEnd = 116483, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Dismount()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Skateboard_Equippable.NativeMethodInfoPtr_Dismount_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600249D RID: 9373 RVA: 0x000E5368 File Offset: 0x000E3568
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 116488, XrefRangeEnd = 116495, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool CanMountHere()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Skateboard_Equippable.NativeMethodInfoPtr_CanMountHere_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x0600249E RID: 9374 RVA: 0x000E53A4 File Offset: 0x000E35A4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 116552, RefRangeEnd = 116555, XrefRangeStart = 116495, XrefRangeEnd = 116552, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Pose GetSkateboardSpawnPose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Skateboard_Equippable.NativeMethodInfoPtr_GetSkateboardSpawnPose_Private_Pose_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x0600249F RID: 9375 RVA: 0x000E53E0 File Offset: 0x000E35E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 116555, XrefRangeEnd = 116556, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Skateboard_Equippable() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Skateboard_Equippable>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Skateboard_Equippable.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060024A0 RID: 9376 RVA: 0x0001473E File Offset: 0x0001293E
		public Skateboard_Equippable(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000C87 RID: 3207
		// (get) Token: 0x060024A1 RID: 9377 RVA: 0x000E541C File Offset: 0x000E361C
		// (set) Token: 0x060024A2 RID: 9378 RVA: 0x00014747 File Offset: 0x00012947
		public unsafe static float ModelLerpSpeed
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(Skateboard_Equippable.NativeFieldInfoPtr_ModelLerpSpeed, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Skateboard_Equippable.NativeFieldInfoPtr_ModelLerpSpeed, (void*)(&value));
			}
		}

		// Token: 0x17000C88 RID: 3208
		// (get) Token: 0x060024A3 RID: 9379 RVA: 0x000E5438 File Offset: 0x000E3638
		// (set) Token: 0x060024A4 RID: 9380 RVA: 0x00014755 File Offset: 0x00012955
		public unsafe static float SurfaceSampleDistance
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(Skateboard_Equippable.NativeFieldInfoPtr_SurfaceSampleDistance, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Skateboard_Equippable.NativeFieldInfoPtr_SurfaceSampleDistance, (void*)(&value));
			}
		}

		// Token: 0x17000C89 RID: 3209
		// (get) Token: 0x060024A5 RID: 9381 RVA: 0x000E5454 File Offset: 0x000E3654
		// (set) Token: 0x060024A6 RID: 9382 RVA: 0x00014763 File Offset: 0x00012963
		public unsafe static float SurfaceSampleRayLength
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(Skateboard_Equippable.NativeFieldInfoPtr_SurfaceSampleRayLength, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Skateboard_Equippable.NativeFieldInfoPtr_SurfaceSampleRayLength, (void*)(&value));
			}
		}

		// Token: 0x17000C8A RID: 3210
		// (get) Token: 0x060024A7 RID: 9383 RVA: 0x000E5470 File Offset: 0x000E3670
		// (set) Token: 0x060024A8 RID: 9384 RVA: 0x00014771 File Offset: 0x00012971
		public unsafe static float BoardSpawnUpwardsShift
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(Skateboard_Equippable.NativeFieldInfoPtr_BoardSpawnUpwardsShift, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Skateboard_Equippable.NativeFieldInfoPtr_BoardSpawnUpwardsShift, (void*)(&value));
			}
		}

		// Token: 0x17000C8B RID: 3211
		// (get) Token: 0x060024A9 RID: 9385 RVA: 0x000E548C File Offset: 0x000E368C
		// (set) Token: 0x060024AA RID: 9386 RVA: 0x0001477F File Offset: 0x0001297F
		public unsafe static float BoardSpawnAngleLimit
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(Skateboard_Equippable.NativeFieldInfoPtr_BoardSpawnAngleLimit, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Skateboard_Equippable.NativeFieldInfoPtr_BoardSpawnAngleLimit, (void*)(&value));
			}
		}

		// Token: 0x17000C8C RID: 3212
		// (get) Token: 0x060024AB RID: 9387 RVA: 0x000E54A8 File Offset: 0x000E36A8
		// (set) Token: 0x060024AC RID: 9388 RVA: 0x0001478D File Offset: 0x0001298D
		public unsafe static float MountTime
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(Skateboard_Equippable.NativeFieldInfoPtr_MountTime, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Skateboard_Equippable.NativeFieldInfoPtr_MountTime, (void*)(&value));
			}
		}

		// Token: 0x17000C8D RID: 3213
		// (get) Token: 0x060024AD RID: 9389 RVA: 0x000E54C4 File Offset: 0x000E36C4
		// (set) Token: 0x060024AE RID: 9390 RVA: 0x0001479B File Offset: 0x0001299B
		public unsafe static float BoardMomentumTransfer
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(Skateboard_Equippable.NativeFieldInfoPtr_BoardMomentumTransfer, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Skateboard_Equippable.NativeFieldInfoPtr_BoardMomentumTransfer, (void*)(&value));
			}
		}

		// Token: 0x17000C8E RID: 3214
		// (get) Token: 0x060024AF RID: 9391 RVA: 0x000E54E0 File Offset: 0x000E36E0
		// (set) Token: 0x060024B0 RID: 9392 RVA: 0x000147A9 File Offset: 0x000129A9
		public unsafe static float DismountAngle
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(Skateboard_Equippable.NativeFieldInfoPtr_DismountAngle, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Skateboard_Equippable.NativeFieldInfoPtr_DismountAngle, (void*)(&value));
			}
		}

		// Token: 0x17000C8F RID: 3215
		// (get) Token: 0x060024B1 RID: 9393 RVA: 0x000E54FC File Offset: 0x000E36FC
		// (set) Token: 0x060024B2 RID: 9394 RVA: 0x000147B7 File Offset: 0x000129B7
		public unsafe bool _IsRiding_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard_Equippable.NativeFieldInfoPtr__IsRiding_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard_Equippable.NativeFieldInfoPtr__IsRiding_k__BackingField)) = value;
			}
		}

		// Token: 0x17000C90 RID: 3216
		// (get) Token: 0x060024B3 RID: 9395 RVA: 0x000E5524 File Offset: 0x000E3724
		// (set) Token: 0x060024B4 RID: 9396 RVA: 0x000147D2 File Offset: 0x000129D2
		public unsafe Skateboard _ActiveSkateboard_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard_Equippable.NativeFieldInfoPtr__ActiveSkateboard_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Skateboard>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard_Equippable.NativeFieldInfoPtr__ActiveSkateboard_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C91 RID: 3217
		// (get) Token: 0x060024B5 RID: 9397 RVA: 0x000E5554 File Offset: 0x000E3754
		// (set) Token: 0x060024B6 RID: 9398 RVA: 0x000147F1 File Offset: 0x000129F1
		public unsafe Skateboard SkateboardPrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard_Equippable.NativeFieldInfoPtr_SkateboardPrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Skateboard>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard_Equippable.NativeFieldInfoPtr_SkateboardPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C92 RID: 3218
		// (get) Token: 0x060024B7 RID: 9399 RVA: 0x000E5584 File Offset: 0x000E3784
		// (set) Token: 0x060024B8 RID: 9400 RVA: 0x00014810 File Offset: 0x00012A10
		public unsafe bool blockDismount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard_Equippable.NativeFieldInfoPtr_blockDismount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard_Equippable.NativeFieldInfoPtr_blockDismount)) = value;
			}
		}

		// Token: 0x17000C93 RID: 3219
		// (get) Token: 0x060024B9 RID: 9401 RVA: 0x000E55AC File Offset: 0x000E37AC
		// (set) Token: 0x060024BA RID: 9402 RVA: 0x0001482B File Offset: 0x00012A2B
		public unsafe Transform ModelContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard_Equippable.NativeFieldInfoPtr_ModelContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard_Equippable.NativeFieldInfoPtr_ModelContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C94 RID: 3220
		// (get) Token: 0x060024BB RID: 9403 RVA: 0x000E55DC File Offset: 0x000E37DC
		// (set) Token: 0x060024BC RID: 9404 RVA: 0x0001484A File Offset: 0x00012A4A
		public unsafe Transform ModelPosition_Raised
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard_Equippable.NativeFieldInfoPtr_ModelPosition_Raised);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard_Equippable.NativeFieldInfoPtr_ModelPosition_Raised), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C95 RID: 3221
		// (get) Token: 0x060024BD RID: 9405 RVA: 0x000E560C File Offset: 0x000E380C
		// (set) Token: 0x060024BE RID: 9406 RVA: 0x00014869 File Offset: 0x00012A69
		public unsafe Transform ModelPosition_Lowered
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard_Equippable.NativeFieldInfoPtr_ModelPosition_Lowered);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard_Equippable.NativeFieldInfoPtr_ModelPosition_Lowered), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C96 RID: 3222
		// (get) Token: 0x060024BF RID: 9407 RVA: 0x000E563C File Offset: 0x000E383C
		// (set) Token: 0x060024C0 RID: 9408 RVA: 0x00014888 File Offset: 0x00012A88
		public unsafe float mountTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard_Equippable.NativeFieldInfoPtr_mountTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Skateboard_Equippable.NativeFieldInfoPtr_mountTime)) = value;
			}
		}

		// Token: 0x04001839 RID: 6201
		private static readonly IntPtr NativeFieldInfoPtr_ModelLerpSpeed;

		// Token: 0x0400183A RID: 6202
		private static readonly IntPtr NativeFieldInfoPtr_SurfaceSampleDistance;

		// Token: 0x0400183B RID: 6203
		private static readonly IntPtr NativeFieldInfoPtr_SurfaceSampleRayLength;

		// Token: 0x0400183C RID: 6204
		private static readonly IntPtr NativeFieldInfoPtr_BoardSpawnUpwardsShift;

		// Token: 0x0400183D RID: 6205
		private static readonly IntPtr NativeFieldInfoPtr_BoardSpawnAngleLimit;

		// Token: 0x0400183E RID: 6206
		private static readonly IntPtr NativeFieldInfoPtr_MountTime;

		// Token: 0x0400183F RID: 6207
		private static readonly IntPtr NativeFieldInfoPtr_BoardMomentumTransfer;

		// Token: 0x04001840 RID: 6208
		private static readonly IntPtr NativeFieldInfoPtr_DismountAngle;

		// Token: 0x04001841 RID: 6209
		private static readonly IntPtr NativeFieldInfoPtr__IsRiding_k__BackingField;

		// Token: 0x04001842 RID: 6210
		private static readonly IntPtr NativeFieldInfoPtr__ActiveSkateboard_k__BackingField;

		// Token: 0x04001843 RID: 6211
		private static readonly IntPtr NativeFieldInfoPtr_SkateboardPrefab;

		// Token: 0x04001844 RID: 6212
		private static readonly IntPtr NativeFieldInfoPtr_blockDismount;

		// Token: 0x04001845 RID: 6213
		private static readonly IntPtr NativeFieldInfoPtr_ModelContainer;

		// Token: 0x04001846 RID: 6214
		private static readonly IntPtr NativeFieldInfoPtr_ModelPosition_Raised;

		// Token: 0x04001847 RID: 6215
		private static readonly IntPtr NativeFieldInfoPtr_ModelPosition_Lowered;

		// Token: 0x04001848 RID: 6216
		private static readonly IntPtr NativeFieldInfoPtr_mountTime;

		// Token: 0x04001849 RID: 6217
		private static readonly IntPtr NativeMethodInfoPtr_get_IsRiding_Public_get_Boolean_0;

		// Token: 0x0400184A RID: 6218
		private static readonly IntPtr NativeMethodInfoPtr_set_IsRiding_Private_set_Void_Boolean_0;

		// Token: 0x0400184B RID: 6219
		private static readonly IntPtr NativeMethodInfoPtr_get_ActiveSkateboard_Public_get_Skateboard_0;

		// Token: 0x0400184C RID: 6220
		private static readonly IntPtr NativeMethodInfoPtr_set_ActiveSkateboard_Private_set_Void_Skateboard_0;

		// Token: 0x0400184D RID: 6221
		private static readonly IntPtr NativeMethodInfoPtr_Equip_Public_Virtual_Void_ItemInstance_0;

		// Token: 0x0400184E RID: 6222
		private static readonly IntPtr NativeMethodInfoPtr_Exit_Private_Void_ExitAction_0;

		// Token: 0x0400184F RID: 6223
		private static readonly IntPtr NativeMethodInfoPtr_Update_Protected_Virtual_Void_0;

		// Token: 0x04001850 RID: 6224
		private static readonly IntPtr NativeMethodInfoPtr_UpdateModel_Private_Void_0;

		// Token: 0x04001851 RID: 6225
		private static readonly IntPtr NativeMethodInfoPtr_Unequip_Public_Virtual_Void_0;

		// Token: 0x04001852 RID: 6226
		private static readonly IntPtr NativeMethodInfoPtr_Mount_Public_Void_0;

		// Token: 0x04001853 RID: 6227
		private static readonly IntPtr NativeMethodInfoPtr_Dismount_Public_Void_0;

		// Token: 0x04001854 RID: 6228
		private static readonly IntPtr NativeMethodInfoPtr_CanMountHere_Private_Boolean_0;

		// Token: 0x04001855 RID: 6229
		private static readonly IntPtr NativeMethodInfoPtr_GetSkateboardSpawnPose_Private_Pose_0;

		// Token: 0x04001856 RID: 6230
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
