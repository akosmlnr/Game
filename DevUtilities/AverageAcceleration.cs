using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.DevUtilities
{
	// Token: 0x02000472 RID: 1138
	public class AverageAcceleration : MonoBehaviour
	{
		// Token: 0x060061B4 RID: 25012 RVA: 0x001C1C64 File Offset: 0x001BFE64
		// Note: this type is marked as 'beforefieldinit'.
		static AverageAcceleration()
		{
			Il2CppClassPointerStore<AverageAcceleration>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.DevUtilities", "AverageAcceleration");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AverageAcceleration>.NativeClassPtr);
			AverageAcceleration.NativeFieldInfoPtr__Acceleration_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AverageAcceleration>.NativeClassPtr, "<Acceleration>k__BackingField");
			AverageAcceleration.NativeFieldInfoPtr_Rb = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AverageAcceleration>.NativeClassPtr, "Rb");
			AverageAcceleration.NativeFieldInfoPtr_TimeWindow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AverageAcceleration>.NativeClassPtr, "TimeWindow");
			AverageAcceleration.NativeFieldInfoPtr_accelerations = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AverageAcceleration>.NativeClassPtr, "accelerations");
			AverageAcceleration.NativeFieldInfoPtr_currentIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AverageAcceleration>.NativeClassPtr, "currentIndex");
			AverageAcceleration.NativeFieldInfoPtr_timer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AverageAcceleration>.NativeClassPtr, "timer");
			AverageAcceleration.NativeFieldInfoPtr_prevVelocity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AverageAcceleration>.NativeClassPtr, "prevVelocity");
			AverageAcceleration.NativeMethodInfoPtr_get_Acceleration_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AverageAcceleration>.NativeClassPtr, 100675853);
			AverageAcceleration.NativeMethodInfoPtr_set_Acceleration_Private_set_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AverageAcceleration>.NativeClassPtr, 100675854);
			AverageAcceleration.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AverageAcceleration>.NativeClassPtr, 100675855);
			AverageAcceleration.NativeMethodInfoPtr_FixedUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AverageAcceleration>.NativeClassPtr, 100675856);
			AverageAcceleration.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AverageAcceleration>.NativeClassPtr, 100675857);
		}

		// Token: 0x17001D23 RID: 7459
		// (get) Token: 0x060061B5 RID: 25013 RVA: 0x001C1D84 File Offset: 0x001BFF84
		// (set) Token: 0x060061B6 RID: 25014 RVA: 0x001C1DC0 File Offset: 0x001BFFC0
		public unsafe Vector3 Acceleration
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr obj = IL2CPP.il2cpp_runtime_invoke(AverageAcceleration.NativeMethodInfoPtr_get_Acceleration_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AverageAcceleration.NativeMethodInfoPtr_set_Acceleration_Private_set_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x060061B7 RID: 25015 RVA: 0x001C1E00 File Offset: 0x001C0000
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 203227, XrefRangeEnd = 203248, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AverageAcceleration.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060061B8 RID: 25016 RVA: 0x001C1E34 File Offset: 0x001C0034
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 203248, XrefRangeEnd = 203258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FixedUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AverageAcceleration.NativeMethodInfoPtr_FixedUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060061B9 RID: 25017 RVA: 0x001C1E68 File Offset: 0x001C0068
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 203258, XrefRangeEnd = 203261, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AverageAcceleration() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AverageAcceleration>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AverageAcceleration.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060061BA RID: 25018 RVA: 0x0002DDCB File Offset: 0x0002BFCB
		public AverageAcceleration(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001D1C RID: 7452
		// (get) Token: 0x060061BB RID: 25019 RVA: 0x001C1EA4 File Offset: 0x001C00A4
		// (set) Token: 0x060061BC RID: 25020 RVA: 0x0002DDD4 File Offset: 0x0002BFD4
		public unsafe Vector3 _Acceleration_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AverageAcceleration.NativeFieldInfoPtr__Acceleration_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AverageAcceleration.NativeFieldInfoPtr__Acceleration_k__BackingField)) = value;
			}
		}

		// Token: 0x17001D1D RID: 7453
		// (get) Token: 0x060061BD RID: 25021 RVA: 0x001C1ECC File Offset: 0x001C00CC
		// (set) Token: 0x060061BE RID: 25022 RVA: 0x0002DDEF File Offset: 0x0002BFEF
		public unsafe Rigidbody Rb
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AverageAcceleration.NativeFieldInfoPtr_Rb);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Rigidbody>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AverageAcceleration.NativeFieldInfoPtr_Rb), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001D1E RID: 7454
		// (get) Token: 0x060061BF RID: 25023 RVA: 0x001C1EFC File Offset: 0x001C00FC
		// (set) Token: 0x060061C0 RID: 25024 RVA: 0x0002DE0E File Offset: 0x0002C00E
		public unsafe float TimeWindow
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AverageAcceleration.NativeFieldInfoPtr_TimeWindow);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AverageAcceleration.NativeFieldInfoPtr_TimeWindow)) = value;
			}
		}

		// Token: 0x17001D1F RID: 7455
		// (get) Token: 0x060061C1 RID: 25025 RVA: 0x001C1F24 File Offset: 0x001C0124
		// (set) Token: 0x060061C2 RID: 25026 RVA: 0x0002DE29 File Offset: 0x0002C029
		public unsafe Il2CppStructArray<Vector3> accelerations
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AverageAcceleration.NativeFieldInfoPtr_accelerations);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector3>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AverageAcceleration.NativeFieldInfoPtr_accelerations), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001D20 RID: 7456
		// (get) Token: 0x060061C3 RID: 25027 RVA: 0x001C1F54 File Offset: 0x001C0154
		// (set) Token: 0x060061C4 RID: 25028 RVA: 0x0002DE48 File Offset: 0x0002C048
		public unsafe int currentIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AverageAcceleration.NativeFieldInfoPtr_currentIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AverageAcceleration.NativeFieldInfoPtr_currentIndex)) = value;
			}
		}

		// Token: 0x17001D21 RID: 7457
		// (get) Token: 0x060061C5 RID: 25029 RVA: 0x001C1F7C File Offset: 0x001C017C
		// (set) Token: 0x060061C6 RID: 25030 RVA: 0x0002DE63 File Offset: 0x0002C063
		public unsafe float timer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AverageAcceleration.NativeFieldInfoPtr_timer);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AverageAcceleration.NativeFieldInfoPtr_timer)) = value;
			}
		}

		// Token: 0x17001D22 RID: 7458
		// (get) Token: 0x060061C7 RID: 25031 RVA: 0x001C1FA4 File Offset: 0x001C01A4
		// (set) Token: 0x060061C8 RID: 25032 RVA: 0x0002DE7E File Offset: 0x0002C07E
		public unsafe Vector3 prevVelocity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AverageAcceleration.NativeFieldInfoPtr_prevVelocity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AverageAcceleration.NativeFieldInfoPtr_prevVelocity)) = value;
			}
		}

		// Token: 0x040042C3 RID: 17091
		private static readonly IntPtr NativeFieldInfoPtr__Acceleration_k__BackingField;

		// Token: 0x040042C4 RID: 17092
		private static readonly IntPtr NativeFieldInfoPtr_Rb;

		// Token: 0x040042C5 RID: 17093
		private static readonly IntPtr NativeFieldInfoPtr_TimeWindow;

		// Token: 0x040042C6 RID: 17094
		private static readonly IntPtr NativeFieldInfoPtr_accelerations;

		// Token: 0x040042C7 RID: 17095
		private static readonly IntPtr NativeFieldInfoPtr_currentIndex;

		// Token: 0x040042C8 RID: 17096
		private static readonly IntPtr NativeFieldInfoPtr_timer;

		// Token: 0x040042C9 RID: 17097
		private static readonly IntPtr NativeFieldInfoPtr_prevVelocity;

		// Token: 0x040042CA RID: 17098
		private static readonly IntPtr NativeMethodInfoPtr_get_Acceleration_Public_get_Vector3_0;

		// Token: 0x040042CB RID: 17099
		private static readonly IntPtr NativeMethodInfoPtr_set_Acceleration_Private_set_Void_Vector3_0;

		// Token: 0x040042CC RID: 17100
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x040042CD RID: 17101
		private static readonly IntPtr NativeMethodInfoPtr_FixedUpdate_Private_Void_0;

		// Token: 0x040042CE RID: 17102
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
