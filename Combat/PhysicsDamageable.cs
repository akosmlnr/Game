using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.Combat
{
	// Token: 0x020004B8 RID: 1208
	public class PhysicsDamageable : MonoBehaviour
	{
		// Token: 0x0600674F RID: 26447 RVA: 0x001D3FD8 File Offset: 0x001D21D8
		// Note: this type is marked as 'beforefieldinit'.
		static PhysicsDamageable()
		{
			Il2CppClassPointerStore<PhysicsDamageable>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Combat", "PhysicsDamageable");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PhysicsDamageable>.NativeClassPtr);
			PhysicsDamageable.NativeFieldInfoPtr_VELOCITY_HISTORY_LENGTH = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PhysicsDamageable>.NativeClassPtr, "VELOCITY_HISTORY_LENGTH");
			PhysicsDamageable.NativeFieldInfoPtr_Rb = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PhysicsDamageable>.NativeClassPtr, "Rb");
			PhysicsDamageable.NativeFieldInfoPtr_ForceMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PhysicsDamageable>.NativeClassPtr, "ForceMultiplier");
			PhysicsDamageable.NativeFieldInfoPtr_impactHistory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PhysicsDamageable>.NativeClassPtr, "impactHistory");
			PhysicsDamageable.NativeFieldInfoPtr_onImpacted = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PhysicsDamageable>.NativeClassPtr, "onImpacted");
			PhysicsDamageable.NativeFieldInfoPtr__averageVelocity_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PhysicsDamageable>.NativeClassPtr, "<averageVelocity>k__BackingField");
			PhysicsDamageable.NativeFieldInfoPtr_velocityHistory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PhysicsDamageable>.NativeClassPtr, "velocityHistory");
			PhysicsDamageable.NativeMethodInfoPtr_get_averageVelocity_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhysicsDamageable>.NativeClassPtr, 100676459);
			PhysicsDamageable.NativeMethodInfoPtr_set_averageVelocity_Private_set_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhysicsDamageable>.NativeClassPtr, 100676460);
			PhysicsDamageable.NativeMethodInfoPtr_OnValidate_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhysicsDamageable>.NativeClassPtr, 100676461);
			PhysicsDamageable.NativeMethodInfoPtr_SendImpact_Public_Virtual_New_Void_Impact_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhysicsDamageable>.NativeClassPtr, 100676462);
			PhysicsDamageable.NativeMethodInfoPtr_ReceiveImpact_Public_Virtual_New_Void_Impact_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhysicsDamageable>.NativeClassPtr, 100676463);
			PhysicsDamageable.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhysicsDamageable>.NativeClassPtr, 100676464);
		}

		// Token: 0x17001EEB RID: 7915
		// (get) Token: 0x06006750 RID: 26448 RVA: 0x001D410C File Offset: 0x001D230C
		// (set) Token: 0x06006751 RID: 26449 RVA: 0x001D4148 File Offset: 0x001D2348
		public unsafe Vector3 averageVelocity
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(PhysicsDamageable.NativeMethodInfoPtr_get_averageVelocity_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 210270, RefRangeEnd = 210271, XrefRangeStart = 210270, XrefRangeEnd = 210270, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = ref value;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PhysicsDamageable.NativeMethodInfoPtr_set_averageVelocity_Private_set_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x06006752 RID: 26450 RVA: 0x001D4188 File Offset: 0x001D2388
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 210271, XrefRangeEnd = 210279, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnValidate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PhysicsDamageable.NativeMethodInfoPtr_OnValidate_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006753 RID: 26451 RVA: 0x001D41BC File Offset: 0x001D23BC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 210279, RefRangeEnd = 210281, XrefRangeStart = 210279, XrefRangeEnd = 210279, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SendImpact(Impact impact)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(impact);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PhysicsDamageable.NativeMethodInfoPtr_SendImpact_Public_Virtual_New_Void_Impact_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006754 RID: 26452 RVA: 0x001D420C File Offset: 0x001D240C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 210281, XrefRangeEnd = 210295, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void ReceiveImpact(Impact impact)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(impact);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PhysicsDamageable.NativeMethodInfoPtr_ReceiveImpact_Public_Virtual_New_Void_Impact_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006755 RID: 26453 RVA: 0x001D425C File Offset: 0x001D245C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 210295, XrefRangeEnd = 210312, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PhysicsDamageable() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PhysicsDamageable>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PhysicsDamageable.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006756 RID: 26454 RVA: 0x00030A17 File Offset: 0x0002EC17
		public PhysicsDamageable(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001EE4 RID: 7908
		// (get) Token: 0x06006757 RID: 26455 RVA: 0x001D4298 File Offset: 0x001D2498
		// (set) Token: 0x06006758 RID: 26456 RVA: 0x00030A20 File Offset: 0x0002EC20
		public unsafe static int VELOCITY_HISTORY_LENGTH
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(PhysicsDamageable.NativeFieldInfoPtr_VELOCITY_HISTORY_LENGTH, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PhysicsDamageable.NativeFieldInfoPtr_VELOCITY_HISTORY_LENGTH, (void*)(&value));
			}
		}

		// Token: 0x17001EE5 RID: 7909
		// (get) Token: 0x06006759 RID: 26457 RVA: 0x001D42B4 File Offset: 0x001D24B4
		// (set) Token: 0x0600675A RID: 26458 RVA: 0x00030A2E File Offset: 0x0002EC2E
		public unsafe Rigidbody Rb
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PhysicsDamageable.NativeFieldInfoPtr_Rb);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Rigidbody>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PhysicsDamageable.NativeFieldInfoPtr_Rb), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001EE6 RID: 7910
		// (get) Token: 0x0600675B RID: 26459 RVA: 0x001D42E4 File Offset: 0x001D24E4
		// (set) Token: 0x0600675C RID: 26460 RVA: 0x00030A4D File Offset: 0x0002EC4D
		public unsafe float ForceMultiplier
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PhysicsDamageable.NativeFieldInfoPtr_ForceMultiplier);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PhysicsDamageable.NativeFieldInfoPtr_ForceMultiplier)) = value;
			}
		}

		// Token: 0x17001EE7 RID: 7911
		// (get) Token: 0x0600675D RID: 26461 RVA: 0x001D430C File Offset: 0x001D250C
		// (set) Token: 0x0600675E RID: 26462 RVA: 0x00030A68 File Offset: 0x0002EC68
		public unsafe List<int> impactHistory
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PhysicsDamageable.NativeFieldInfoPtr_impactHistory);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<int>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PhysicsDamageable.NativeFieldInfoPtr_impactHistory), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001EE8 RID: 7912
		// (get) Token: 0x0600675F RID: 26463 RVA: 0x001D433C File Offset: 0x001D253C
		// (set) Token: 0x06006760 RID: 26464 RVA: 0x00030A87 File Offset: 0x0002EC87
		public unsafe Il2CppSystem.Action<Impact> onImpacted
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PhysicsDamageable.NativeFieldInfoPtr_onImpacted);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Action<Impact>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PhysicsDamageable.NativeFieldInfoPtr_onImpacted), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001EE9 RID: 7913
		// (get) Token: 0x06006761 RID: 26465 RVA: 0x001D436C File Offset: 0x001D256C
		// (set) Token: 0x06006762 RID: 26466 RVA: 0x00030AA6 File Offset: 0x0002ECA6
		public unsafe Vector3 _averageVelocity_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PhysicsDamageable.NativeFieldInfoPtr__averageVelocity_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PhysicsDamageable.NativeFieldInfoPtr__averageVelocity_k__BackingField)) = value;
			}
		}

		// Token: 0x17001EEA RID: 7914
		// (get) Token: 0x06006763 RID: 26467 RVA: 0x001D4394 File Offset: 0x001D2594
		// (set) Token: 0x06006764 RID: 26468 RVA: 0x00030AC1 File Offset: 0x0002ECC1
		public unsafe List<Vector3> velocityHistory
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PhysicsDamageable.NativeFieldInfoPtr_velocityHistory);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Vector3>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PhysicsDamageable.NativeFieldInfoPtr_velocityHistory), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04004685 RID: 18053
		private static readonly System.IntPtr NativeFieldInfoPtr_VELOCITY_HISTORY_LENGTH;

		// Token: 0x04004686 RID: 18054
		private static readonly System.IntPtr NativeFieldInfoPtr_Rb;

		// Token: 0x04004687 RID: 18055
		private static readonly System.IntPtr NativeFieldInfoPtr_ForceMultiplier;

		// Token: 0x04004688 RID: 18056
		private static readonly System.IntPtr NativeFieldInfoPtr_impactHistory;

		// Token: 0x04004689 RID: 18057
		private static readonly System.IntPtr NativeFieldInfoPtr_onImpacted;

		// Token: 0x0400468A RID: 18058
		private static readonly System.IntPtr NativeFieldInfoPtr__averageVelocity_k__BackingField;

		// Token: 0x0400468B RID: 18059
		private static readonly System.IntPtr NativeFieldInfoPtr_velocityHistory;

		// Token: 0x0400468C RID: 18060
		private static readonly System.IntPtr NativeMethodInfoPtr_get_averageVelocity_Public_get_Vector3_0;

		// Token: 0x0400468D RID: 18061
		private static readonly System.IntPtr NativeMethodInfoPtr_set_averageVelocity_Private_set_Void_Vector3_0;

		// Token: 0x0400468E RID: 18062
		private static readonly System.IntPtr NativeMethodInfoPtr_OnValidate_Public_Void_0;

		// Token: 0x0400468F RID: 18063
		private static readonly System.IntPtr NativeMethodInfoPtr_SendImpact_Public_Virtual_New_Void_Impact_0;

		// Token: 0x04004690 RID: 18064
		private static readonly System.IntPtr NativeMethodInfoPtr_ReceiveImpact_Public_Virtual_New_Void_Impact_0;

		// Token: 0x04004691 RID: 18065
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
