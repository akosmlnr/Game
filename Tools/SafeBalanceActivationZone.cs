using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Storage;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.Tools
{
	// Token: 0x0200056F RID: 1391
	public class SafeBalanceActivationZone : MonoBehaviour
	{
		// Token: 0x060079C8 RID: 31176 RVA: 0x00211C9C File Offset: 0x0020FE9C
		// Note: this type is marked as 'beforefieldinit'.
		static SafeBalanceActivationZone()
		{
			Il2CppClassPointerStore<SafeBalanceActivationZone>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Tools", "SafeBalanceActivationZone");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SafeBalanceActivationZone>.NativeClassPtr);
			SafeBalanceActivationZone.NativeFieldInfoPtr_ActivationDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SafeBalanceActivationZone>.NativeClassPtr, "ActivationDistance");
			SafeBalanceActivationZone.NativeFieldInfoPtr_Safe = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SafeBalanceActivationZone>.NativeClassPtr, "Safe");
			SafeBalanceActivationZone.NativeFieldInfoPtr_exclude = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SafeBalanceActivationZone>.NativeClassPtr, "exclude");
			SafeBalanceActivationZone.NativeFieldInfoPtr_colliders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SafeBalanceActivationZone>.NativeClassPtr, "colliders");
			SafeBalanceActivationZone.NativeFieldInfoPtr_active = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SafeBalanceActivationZone>.NativeClassPtr, "active");
			SafeBalanceActivationZone.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SafeBalanceActivationZone>.NativeClassPtr, 100678717);
			SafeBalanceActivationZone.NativeMethodInfoPtr_UpdateCollider_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SafeBalanceActivationZone>.NativeClassPtr, 100678718);
			SafeBalanceActivationZone.NativeMethodInfoPtr_Activate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SafeBalanceActivationZone>.NativeClassPtr, 100678719);
			SafeBalanceActivationZone.NativeMethodInfoPtr_OnTriggerStay_Private_Void_Collider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SafeBalanceActivationZone>.NativeClassPtr, 100678720);
			SafeBalanceActivationZone.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SafeBalanceActivationZone>.NativeClassPtr, 100678721);
		}

		// Token: 0x060079C9 RID: 31177 RVA: 0x00211D94 File Offset: 0x0020FF94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 235735, XrefRangeEnd = 235745, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SafeBalanceActivationZone.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060079CA RID: 31178 RVA: 0x00211DC8 File Offset: 0x0020FFC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 235745, XrefRangeEnd = 235753, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateCollider()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SafeBalanceActivationZone.NativeMethodInfoPtr_UpdateCollider_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060079CB RID: 31179 RVA: 0x00211DFC File Offset: 0x0020FFFC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 235753, RefRangeEnd = 235754, XrefRangeStart = 235753, XrefRangeEnd = 235753, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Activate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SafeBalanceActivationZone.NativeMethodInfoPtr_Activate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060079CC RID: 31180 RVA: 0x00211E30 File Offset: 0x00210030
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 235754, XrefRangeEnd = 235774, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnTriggerStay(Collider other)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SafeBalanceActivationZone.NativeMethodInfoPtr_OnTriggerStay_Private_Void_Collider_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060079CD RID: 31181 RVA: 0x00211E74 File Offset: 0x00210074
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 235774, XrefRangeEnd = 235782, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SafeBalanceActivationZone() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SafeBalanceActivationZone>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SafeBalanceActivationZone.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060079CE RID: 31182 RVA: 0x000396F0 File Offset: 0x000378F0
		public SafeBalanceActivationZone(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700249A RID: 9370
		// (get) Token: 0x060079CF RID: 31183 RVA: 0x00211EB0 File Offset: 0x002100B0
		// (set) Token: 0x060079D0 RID: 31184 RVA: 0x000396F9 File Offset: 0x000378F9
		public unsafe static float ActivationDistance
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(SafeBalanceActivationZone.NativeFieldInfoPtr_ActivationDistance, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SafeBalanceActivationZone.NativeFieldInfoPtr_ActivationDistance, (void*)(&value));
			}
		}

		// Token: 0x1700249B RID: 9371
		// (get) Token: 0x060079D1 RID: 31185 RVA: 0x00211ECC File Offset: 0x002100CC
		// (set) Token: 0x060079D2 RID: 31186 RVA: 0x00039707 File Offset: 0x00037907
		public unsafe Safe Safe
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SafeBalanceActivationZone.NativeFieldInfoPtr_Safe);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Safe>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SafeBalanceActivationZone.NativeFieldInfoPtr_Safe), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700249C RID: 9372
		// (get) Token: 0x060079D3 RID: 31187 RVA: 0x00211EFC File Offset: 0x002100FC
		// (set) Token: 0x060079D4 RID: 31188 RVA: 0x00039726 File Offset: 0x00037926
		public unsafe List<Collider> exclude
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SafeBalanceActivationZone.NativeFieldInfoPtr_exclude);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Collider>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SafeBalanceActivationZone.NativeFieldInfoPtr_exclude), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700249D RID: 9373
		// (get) Token: 0x060079D5 RID: 31189 RVA: 0x00211F2C File Offset: 0x0021012C
		// (set) Token: 0x060079D6 RID: 31190 RVA: 0x00039745 File Offset: 0x00037945
		public unsafe Il2CppReferenceArray<Collider> colliders
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SafeBalanceActivationZone.NativeFieldInfoPtr_colliders);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Collider>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SafeBalanceActivationZone.NativeFieldInfoPtr_colliders), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700249E RID: 9374
		// (get) Token: 0x060079D7 RID: 31191 RVA: 0x00211F5C File Offset: 0x0021015C
		// (set) Token: 0x060079D8 RID: 31192 RVA: 0x00039764 File Offset: 0x00037964
		public unsafe bool active
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SafeBalanceActivationZone.NativeFieldInfoPtr_active);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SafeBalanceActivationZone.NativeFieldInfoPtr_active)) = value;
			}
		}

		// Token: 0x04005317 RID: 21271
		private static readonly IntPtr NativeFieldInfoPtr_ActivationDistance;

		// Token: 0x04005318 RID: 21272
		private static readonly IntPtr NativeFieldInfoPtr_Safe;

		// Token: 0x04005319 RID: 21273
		private static readonly IntPtr NativeFieldInfoPtr_exclude;

		// Token: 0x0400531A RID: 21274
		private static readonly IntPtr NativeFieldInfoPtr_colliders;

		// Token: 0x0400531B RID: 21275
		private static readonly IntPtr NativeFieldInfoPtr_active;

		// Token: 0x0400531C RID: 21276
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x0400531D RID: 21277
		private static readonly IntPtr NativeMethodInfoPtr_UpdateCollider_Private_Void_0;

		// Token: 0x0400531E RID: 21278
		private static readonly IntPtr NativeMethodInfoPtr_Activate_Private_Void_0;

		// Token: 0x0400531F RID: 21279
		private static readonly IntPtr NativeMethodInfoPtr_OnTriggerStay_Private_Void_Collider_0;

		// Token: 0x04005320 RID: 21280
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
