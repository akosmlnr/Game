using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.Tools
{
	// Token: 0x02000564 RID: 1380
	public class OnlineBalanceActivationZone : MonoBehaviour
	{
		// Token: 0x06007944 RID: 31044 RVA: 0x0021044C File Offset: 0x0020E64C
		// Note: this type is marked as 'beforefieldinit'.
		static OnlineBalanceActivationZone()
		{
			Il2CppClassPointerStore<OnlineBalanceActivationZone>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Tools", "OnlineBalanceActivationZone");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OnlineBalanceActivationZone>.NativeClassPtr);
			OnlineBalanceActivationZone.NativeFieldInfoPtr_ActivationDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OnlineBalanceActivationZone>.NativeClassPtr, "ActivationDistance");
			OnlineBalanceActivationZone.NativeFieldInfoPtr_exclude = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OnlineBalanceActivationZone>.NativeClassPtr, "exclude");
			OnlineBalanceActivationZone.NativeFieldInfoPtr_collider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OnlineBalanceActivationZone>.NativeClassPtr, "collider");
			OnlineBalanceActivationZone.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnlineBalanceActivationZone>.NativeClassPtr, 100678669);
			OnlineBalanceActivationZone.NativeMethodInfoPtr_UpdateCollider_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnlineBalanceActivationZone>.NativeClassPtr, 100678670);
			OnlineBalanceActivationZone.NativeMethodInfoPtr_OnTriggerStay_Private_Void_Collider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnlineBalanceActivationZone>.NativeClassPtr, 100678671);
			OnlineBalanceActivationZone.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnlineBalanceActivationZone>.NativeClassPtr, 100678672);
		}

		// Token: 0x06007945 RID: 31045 RVA: 0x00210508 File Offset: 0x0020E708
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 235253, XrefRangeEnd = 235260, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OnlineBalanceActivationZone.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007946 RID: 31046 RVA: 0x0021053C File Offset: 0x0020E73C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 235260, XrefRangeEnd = 235267, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateCollider()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OnlineBalanceActivationZone.NativeMethodInfoPtr_UpdateCollider_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007947 RID: 31047 RVA: 0x00210570 File Offset: 0x0020E770
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 235267, XrefRangeEnd = 235283, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnTriggerStay(Collider other)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OnlineBalanceActivationZone.NativeMethodInfoPtr_OnTriggerStay_Private_Void_Collider_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007948 RID: 31048 RVA: 0x002105B4 File Offset: 0x0020E7B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 235283, XrefRangeEnd = 235291, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe OnlineBalanceActivationZone() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OnlineBalanceActivationZone>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OnlineBalanceActivationZone.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007949 RID: 31049 RVA: 0x00039333 File Offset: 0x00037533
		public OnlineBalanceActivationZone(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700247A RID: 9338
		// (get) Token: 0x0600794A RID: 31050 RVA: 0x002105F0 File Offset: 0x0020E7F0
		// (set) Token: 0x0600794B RID: 31051 RVA: 0x0003933C File Offset: 0x0003753C
		public unsafe static float ActivationDistance
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(OnlineBalanceActivationZone.NativeFieldInfoPtr_ActivationDistance, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(OnlineBalanceActivationZone.NativeFieldInfoPtr_ActivationDistance, (void*)(&value));
			}
		}

		// Token: 0x1700247B RID: 9339
		// (get) Token: 0x0600794C RID: 31052 RVA: 0x0021060C File Offset: 0x0020E80C
		// (set) Token: 0x0600794D RID: 31053 RVA: 0x0003934A File Offset: 0x0003754A
		public unsafe List<Collider> exclude
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OnlineBalanceActivationZone.NativeFieldInfoPtr_exclude);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Collider>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OnlineBalanceActivationZone.NativeFieldInfoPtr_exclude), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700247C RID: 9340
		// (get) Token: 0x0600794E RID: 31054 RVA: 0x0021063C File Offset: 0x0020E83C
		// (set) Token: 0x0600794F RID: 31055 RVA: 0x00039369 File Offset: 0x00037569
		public unsafe Collider collider
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OnlineBalanceActivationZone.NativeFieldInfoPtr_collider);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Collider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OnlineBalanceActivationZone.NativeFieldInfoPtr_collider), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040052C8 RID: 21192
		private static readonly IntPtr NativeFieldInfoPtr_ActivationDistance;

		// Token: 0x040052C9 RID: 21193
		private static readonly IntPtr NativeFieldInfoPtr_exclude;

		// Token: 0x040052CA RID: 21194
		private static readonly IntPtr NativeFieldInfoPtr_collider;

		// Token: 0x040052CB RID: 21195
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x040052CC RID: 21196
		private static readonly IntPtr NativeMethodInfoPtr_UpdateCollider_Private_Void_0;

		// Token: 0x040052CD RID: 21197
		private static readonly IntPtr NativeMethodInfoPtr_OnTriggerStay_Private_Void_Collider_0;

		// Token: 0x040052CE RID: 21198
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
