using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;
using UnityEngine.Events;

namespace Il2CppScheduleOne.Tools
{
	// Token: 0x0200056B RID: 1387
	public class RandomIntervalEvent : MonoBehaviour
	{
		// Token: 0x060079A4 RID: 31140 RVA: 0x002116A8 File Offset: 0x0020F8A8
		// Note: this type is marked as 'beforefieldinit'.
		static RandomIntervalEvent()
		{
			Il2CppClassPointerStore<RandomIntervalEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Tools", "RandomIntervalEvent");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RandomIntervalEvent>.NativeClassPtr);
			RandomIntervalEvent.NativeFieldInfoPtr_MinInterval = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RandomIntervalEvent>.NativeClassPtr, "MinInterval");
			RandomIntervalEvent.NativeFieldInfoPtr_MaxInterval = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RandomIntervalEvent>.NativeClassPtr, "MaxInterval");
			RandomIntervalEvent.NativeFieldInfoPtr_ExecuteOnEnable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RandomIntervalEvent>.NativeClassPtr, "ExecuteOnEnable");
			RandomIntervalEvent.NativeFieldInfoPtr_OnInterval = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RandomIntervalEvent>.NativeClassPtr, "OnInterval");
			RandomIntervalEvent.NativeFieldInfoPtr_nextInterval = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RandomIntervalEvent>.NativeClassPtr, "nextInterval");
			RandomIntervalEvent.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RandomIntervalEvent>.NativeClassPtr, 100678707);
			RandomIntervalEvent.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RandomIntervalEvent>.NativeClassPtr, 100678708);
			RandomIntervalEvent.NativeMethodInfoPtr_Execute_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RandomIntervalEvent>.NativeClassPtr, 100678709);
			RandomIntervalEvent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RandomIntervalEvent>.NativeClassPtr, 100678710);
		}

		// Token: 0x060079A5 RID: 31141 RVA: 0x0021178C File Offset: 0x0020F98C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 235685, XrefRangeEnd = 235690, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RandomIntervalEvent.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060079A6 RID: 31142 RVA: 0x002117C0 File Offset: 0x0020F9C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 235690, XrefRangeEnd = 235694, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RandomIntervalEvent.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060079A7 RID: 31143 RVA: 0x002117F4 File Offset: 0x0020F9F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 235694, XrefRangeEnd = 235697, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Execute()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RandomIntervalEvent.NativeMethodInfoPtr_Execute_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060079A8 RID: 31144 RVA: 0x00211828 File Offset: 0x0020FA28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 235697, XrefRangeEnd = 235698, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RandomIntervalEvent() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RandomIntervalEvent>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RandomIntervalEvent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060079A9 RID: 31145 RVA: 0x000395CD File Offset: 0x000377CD
		public RandomIntervalEvent(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002491 RID: 9361
		// (get) Token: 0x060079AA RID: 31146 RVA: 0x00211864 File Offset: 0x0020FA64
		// (set) Token: 0x060079AB RID: 31147 RVA: 0x000395D6 File Offset: 0x000377D6
		public unsafe float MinInterval
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RandomIntervalEvent.NativeFieldInfoPtr_MinInterval);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RandomIntervalEvent.NativeFieldInfoPtr_MinInterval)) = value;
			}
		}

		// Token: 0x17002492 RID: 9362
		// (get) Token: 0x060079AC RID: 31148 RVA: 0x0021188C File Offset: 0x0020FA8C
		// (set) Token: 0x060079AD RID: 31149 RVA: 0x000395F1 File Offset: 0x000377F1
		public unsafe float MaxInterval
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RandomIntervalEvent.NativeFieldInfoPtr_MaxInterval);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RandomIntervalEvent.NativeFieldInfoPtr_MaxInterval)) = value;
			}
		}

		// Token: 0x17002493 RID: 9363
		// (get) Token: 0x060079AE RID: 31150 RVA: 0x002118B4 File Offset: 0x0020FAB4
		// (set) Token: 0x060079AF RID: 31151 RVA: 0x0003960C File Offset: 0x0003780C
		public unsafe bool ExecuteOnEnable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RandomIntervalEvent.NativeFieldInfoPtr_ExecuteOnEnable);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RandomIntervalEvent.NativeFieldInfoPtr_ExecuteOnEnable)) = value;
			}
		}

		// Token: 0x17002494 RID: 9364
		// (get) Token: 0x060079B0 RID: 31152 RVA: 0x002118DC File Offset: 0x0020FADC
		// (set) Token: 0x060079B1 RID: 31153 RVA: 0x00039627 File Offset: 0x00037827
		public unsafe UnityEvent OnInterval
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RandomIntervalEvent.NativeFieldInfoPtr_OnInterval);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RandomIntervalEvent.NativeFieldInfoPtr_OnInterval), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002495 RID: 9365
		// (get) Token: 0x060079B2 RID: 31154 RVA: 0x0021190C File Offset: 0x0020FB0C
		// (set) Token: 0x060079B3 RID: 31155 RVA: 0x00039646 File Offset: 0x00037846
		public unsafe float nextInterval
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RandomIntervalEvent.NativeFieldInfoPtr_nextInterval);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RandomIntervalEvent.NativeFieldInfoPtr_nextInterval)) = value;
			}
		}

		// Token: 0x04005304 RID: 21252
		private static readonly IntPtr NativeFieldInfoPtr_MinInterval;

		// Token: 0x04005305 RID: 21253
		private static readonly IntPtr NativeFieldInfoPtr_MaxInterval;

		// Token: 0x04005306 RID: 21254
		private static readonly IntPtr NativeFieldInfoPtr_ExecuteOnEnable;

		// Token: 0x04005307 RID: 21255
		private static readonly IntPtr NativeFieldInfoPtr_OnInterval;

		// Token: 0x04005308 RID: 21256
		private static readonly IntPtr NativeFieldInfoPtr_nextInterval;

		// Token: 0x04005309 RID: 21257
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;

		// Token: 0x0400530A RID: 21258
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x0400530B RID: 21259
		private static readonly IntPtr NativeMethodInfoPtr_Execute_Private_Void_0;

		// Token: 0x0400530C RID: 21260
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
