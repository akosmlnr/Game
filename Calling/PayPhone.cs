using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Audio;
using Il2CppScheduleOne.Interaction;
using Il2CppScheduleOne.Lighting;
using Il2CppScheduleOne.ScriptableObjects;
using UnityEngine;

namespace Il2CppScheduleOne.Calling
{
	// Token: 0x020004D0 RID: 1232
	public class PayPhone : MonoBehaviour
	{
		// Token: 0x06006B8B RID: 27531 RVA: 0x001E34F8 File Offset: 0x001E16F8
		// Note: this type is marked as 'beforefieldinit'.
		static PayPhone()
		{
			Il2CppClassPointerStore<PayPhone>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Calling", "PayPhone");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PayPhone>.NativeClassPtr);
			PayPhone.NativeFieldInfoPtr_RING_INTERVAL = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PayPhone>.NativeClassPtr, "RING_INTERVAL");
			PayPhone.NativeFieldInfoPtr_RING_RANGE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PayPhone>.NativeClassPtr, "RING_RANGE");
			PayPhone.NativeFieldInfoPtr_Light = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PayPhone>.NativeClassPtr, "Light");
			PayPhone.NativeFieldInfoPtr_RingSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PayPhone>.NativeClassPtr, "RingSound");
			PayPhone.NativeFieldInfoPtr_AnswerSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PayPhone>.NativeClassPtr, "AnswerSound");
			PayPhone.NativeFieldInfoPtr_IntObj = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PayPhone>.NativeClassPtr, "IntObj");
			PayPhone.NativeFieldInfoPtr_CameraPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PayPhone>.NativeClassPtr, "CameraPosition");
			PayPhone.NativeFieldInfoPtr_timeSinceLastRing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PayPhone>.NativeClassPtr, "timeSinceLastRing");
			PayPhone.NativeFieldInfoPtr_ringRangeSquared = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PayPhone>.NativeClassPtr, "ringRangeSquared");
			PayPhone.NativeMethodInfoPtr_get_QueuedCall_Public_get_PhoneCallData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PayPhone>.NativeClassPtr, 100677052);
			PayPhone.NativeMethodInfoPtr_get_ActiveCall_Public_get_PhoneCallData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PayPhone>.NativeClassPtr, 100677053);
			PayPhone.NativeMethodInfoPtr_FixedUpdate_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PayPhone>.NativeClassPtr, 100677054);
			PayPhone.NativeMethodInfoPtr_Hovered_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PayPhone>.NativeClassPtr, 100677055);
			PayPhone.NativeMethodInfoPtr_Interacted_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PayPhone>.NativeClassPtr, 100677056);
			PayPhone.NativeMethodInfoPtr_CanInteract_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PayPhone>.NativeClassPtr, 100677057);
			PayPhone.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PayPhone>.NativeClassPtr, 100677058);
		}

		// Token: 0x17002027 RID: 8231
		// (get) Token: 0x06006B8C RID: 27532 RVA: 0x001E3668 File Offset: 0x001E1868
		public unsafe PhoneCallData QueuedCall
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 217193, RefRangeEnd = 217198, XrefRangeStart = 217189, XrefRangeEnd = 217193, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PayPhone.NativeMethodInfoPtr_get_QueuedCall_Public_get_PhoneCallData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PhoneCallData>(intPtr2) : null;
			}
		}

		// Token: 0x17002028 RID: 8232
		// (get) Token: 0x06006B8D RID: 27533 RVA: 0x001E36A8 File Offset: 0x001E18A8
		public unsafe PhoneCallData ActiveCall
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 217202, RefRangeEnd = 217205, XrefRangeStart = 217198, XrefRangeEnd = 217202, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PayPhone.NativeMethodInfoPtr_get_ActiveCall_Public_get_PhoneCallData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PhoneCallData>(intPtr2) : null;
			}
		}

		// Token: 0x06006B8E RID: 27534 RVA: 0x001E36E8 File Offset: 0x001E18E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 217205, XrefRangeEnd = 217235, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FixedUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PayPhone.NativeMethodInfoPtr_FixedUpdate_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006B8F RID: 27535 RVA: 0x001E371C File Offset: 0x001E191C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 217235, XrefRangeEnd = 217237, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Hovered()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PayPhone.NativeMethodInfoPtr_Hovered_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006B90 RID: 27536 RVA: 0x001E3750 File Offset: 0x001E1950
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 217237, XrefRangeEnd = 217257, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Interacted()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PayPhone.NativeMethodInfoPtr_Interacted_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006B91 RID: 27537 RVA: 0x001E3784 File Offset: 0x001E1984
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 217269, RefRangeEnd = 217271, XrefRangeStart = 217257, XrefRangeEnd = 217269, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool CanInteract()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(PayPhone.NativeMethodInfoPtr_CanInteract_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06006B92 RID: 27538 RVA: 0x001E37C0 File Offset: 0x001E19C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 217271, XrefRangeEnd = 217272, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PayPhone() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PayPhone>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PayPhone.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006B93 RID: 27539 RVA: 0x0003295C File Offset: 0x00030B5C
		public PayPhone(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700201E RID: 8222
		// (get) Token: 0x06006B94 RID: 27540 RVA: 0x001E37FC File Offset: 0x001E19FC
		// (set) Token: 0x06006B95 RID: 27541 RVA: 0x00032965 File Offset: 0x00030B65
		public unsafe static float RING_INTERVAL
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(PayPhone.NativeFieldInfoPtr_RING_INTERVAL, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PayPhone.NativeFieldInfoPtr_RING_INTERVAL, (void*)(&value));
			}
		}

		// Token: 0x1700201F RID: 8223
		// (get) Token: 0x06006B96 RID: 27542 RVA: 0x001E3818 File Offset: 0x001E1A18
		// (set) Token: 0x06006B97 RID: 27543 RVA: 0x00032973 File Offset: 0x00030B73
		public unsafe static float RING_RANGE
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(PayPhone.NativeFieldInfoPtr_RING_RANGE, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PayPhone.NativeFieldInfoPtr_RING_RANGE, (void*)(&value));
			}
		}

		// Token: 0x17002020 RID: 8224
		// (get) Token: 0x06006B98 RID: 27544 RVA: 0x001E3834 File Offset: 0x001E1A34
		// (set) Token: 0x06006B99 RID: 27545 RVA: 0x00032981 File Offset: 0x00030B81
		public unsafe BlinkingLight Light
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PayPhone.NativeFieldInfoPtr_Light);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BlinkingLight>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PayPhone.NativeFieldInfoPtr_Light), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002021 RID: 8225
		// (get) Token: 0x06006B9A RID: 27546 RVA: 0x001E3864 File Offset: 0x001E1A64
		// (set) Token: 0x06006B9B RID: 27547 RVA: 0x000329A0 File Offset: 0x00030BA0
		public unsafe AudioSourceController RingSound
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PayPhone.NativeFieldInfoPtr_RingSound);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PayPhone.NativeFieldInfoPtr_RingSound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002022 RID: 8226
		// (get) Token: 0x06006B9C RID: 27548 RVA: 0x001E3894 File Offset: 0x001E1A94
		// (set) Token: 0x06006B9D RID: 27549 RVA: 0x000329BF File Offset: 0x00030BBF
		public unsafe AudioSourceController AnswerSound
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PayPhone.NativeFieldInfoPtr_AnswerSound);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PayPhone.NativeFieldInfoPtr_AnswerSound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002023 RID: 8227
		// (get) Token: 0x06006B9E RID: 27550 RVA: 0x001E38C4 File Offset: 0x001E1AC4
		// (set) Token: 0x06006B9F RID: 27551 RVA: 0x000329DE File Offset: 0x00030BDE
		public unsafe InteractableObject IntObj
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PayPhone.NativeFieldInfoPtr_IntObj);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<InteractableObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PayPhone.NativeFieldInfoPtr_IntObj), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002024 RID: 8228
		// (get) Token: 0x06006BA0 RID: 27552 RVA: 0x001E38F4 File Offset: 0x001E1AF4
		// (set) Token: 0x06006BA1 RID: 27553 RVA: 0x000329FD File Offset: 0x00030BFD
		public unsafe Transform CameraPosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PayPhone.NativeFieldInfoPtr_CameraPosition);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PayPhone.NativeFieldInfoPtr_CameraPosition), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002025 RID: 8229
		// (get) Token: 0x06006BA2 RID: 27554 RVA: 0x001E3924 File Offset: 0x001E1B24
		// (set) Token: 0x06006BA3 RID: 27555 RVA: 0x00032A1C File Offset: 0x00030C1C
		public unsafe float timeSinceLastRing
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PayPhone.NativeFieldInfoPtr_timeSinceLastRing);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PayPhone.NativeFieldInfoPtr_timeSinceLastRing)) = value;
			}
		}

		// Token: 0x17002026 RID: 8230
		// (get) Token: 0x06006BA4 RID: 27556 RVA: 0x001E394C File Offset: 0x001E1B4C
		// (set) Token: 0x06006BA5 RID: 27557 RVA: 0x00032A37 File Offset: 0x00030C37
		public unsafe static float ringRangeSquared
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(PayPhone.NativeFieldInfoPtr_ringRangeSquared, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PayPhone.NativeFieldInfoPtr_ringRangeSquared, (void*)(&value));
			}
		}

		// Token: 0x040049B0 RID: 18864
		private static readonly IntPtr NativeFieldInfoPtr_RING_INTERVAL;

		// Token: 0x040049B1 RID: 18865
		private static readonly IntPtr NativeFieldInfoPtr_RING_RANGE;

		// Token: 0x040049B2 RID: 18866
		private static readonly IntPtr NativeFieldInfoPtr_Light;

		// Token: 0x040049B3 RID: 18867
		private static readonly IntPtr NativeFieldInfoPtr_RingSound;

		// Token: 0x040049B4 RID: 18868
		private static readonly IntPtr NativeFieldInfoPtr_AnswerSound;

		// Token: 0x040049B5 RID: 18869
		private static readonly IntPtr NativeFieldInfoPtr_IntObj;

		// Token: 0x040049B6 RID: 18870
		private static readonly IntPtr NativeFieldInfoPtr_CameraPosition;

		// Token: 0x040049B7 RID: 18871
		private static readonly IntPtr NativeFieldInfoPtr_timeSinceLastRing;

		// Token: 0x040049B8 RID: 18872
		private static readonly IntPtr NativeFieldInfoPtr_ringRangeSquared;

		// Token: 0x040049B9 RID: 18873
		private static readonly IntPtr NativeMethodInfoPtr_get_QueuedCall_Public_get_PhoneCallData_0;

		// Token: 0x040049BA RID: 18874
		private static readonly IntPtr NativeMethodInfoPtr_get_ActiveCall_Public_get_PhoneCallData_0;

		// Token: 0x040049BB RID: 18875
		private static readonly IntPtr NativeMethodInfoPtr_FixedUpdate_Public_Void_0;

		// Token: 0x040049BC RID: 18876
		private static readonly IntPtr NativeMethodInfoPtr_Hovered_Public_Void_0;

		// Token: 0x040049BD RID: 18877
		private static readonly IntPtr NativeMethodInfoPtr_Interacted_Public_Void_0;

		// Token: 0x040049BE RID: 18878
		private static readonly IntPtr NativeMethodInfoPtr_CanInteract_Private_Boolean_0;

		// Token: 0x040049BF RID: 18879
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
