using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;
using UnityEngine.Events;

namespace Il2CppScheduleOne.Tools
{
	// Token: 0x02000561 RID: 1377
	public class IntervalEvent : MonoBehaviour
	{
		// Token: 0x06007925 RID: 31013 RVA: 0x0020FF14 File Offset: 0x0020E114
		// Note: this type is marked as 'beforefieldinit'.
		static IntervalEvent()
		{
			Il2CppClassPointerStore<IntervalEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Tools", "IntervalEvent");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IntervalEvent>.NativeClassPtr);
			IntervalEvent.NativeFieldInfoPtr_Interval = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IntervalEvent>.NativeClassPtr, "Interval");
			IntervalEvent.NativeFieldInfoPtr_Event = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IntervalEvent>.NativeClassPtr, "Event");
			IntervalEvent.NativeMethodInfoPtr_Start_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntervalEvent>.NativeClassPtr, 100678660);
			IntervalEvent.NativeMethodInfoPtr_Execute_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntervalEvent>.NativeClassPtr, 100678661);
			IntervalEvent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntervalEvent>.NativeClassPtr, 100678662);
		}

		// Token: 0x06007926 RID: 31014 RVA: 0x0020FFA8 File Offset: 0x0020E1A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 235241, XrefRangeEnd = 235244, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IntervalEvent.NativeMethodInfoPtr_Start_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007927 RID: 31015 RVA: 0x0020FFDC File Offset: 0x0020E1DC
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 130895, RefRangeEnd = 130899, XrefRangeStart = 130895, XrefRangeEnd = 130899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Execute()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IntervalEvent.NativeMethodInfoPtr_Execute_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007928 RID: 31016 RVA: 0x00210010 File Offset: 0x0020E210
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 77482, RefRangeEnd = 77486, XrefRangeStart = 77482, XrefRangeEnd = 77486, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IntervalEvent() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IntervalEvent>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IntervalEvent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007929 RID: 31017 RVA: 0x0003922C File Offset: 0x0003742C
		public IntervalEvent(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002472 RID: 9330
		// (get) Token: 0x0600792A RID: 31018 RVA: 0x0021004C File Offset: 0x0020E24C
		// (set) Token: 0x0600792B RID: 31019 RVA: 0x00039235 File Offset: 0x00037435
		public unsafe float Interval
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IntervalEvent.NativeFieldInfoPtr_Interval);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IntervalEvent.NativeFieldInfoPtr_Interval)) = value;
			}
		}

		// Token: 0x17002473 RID: 9331
		// (get) Token: 0x0600792C RID: 31020 RVA: 0x00210074 File Offset: 0x0020E274
		// (set) Token: 0x0600792D RID: 31021 RVA: 0x00039250 File Offset: 0x00037450
		public unsafe UnityEvent Event
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IntervalEvent.NativeFieldInfoPtr_Event);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IntervalEvent.NativeFieldInfoPtr_Event), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040052B7 RID: 21175
		private static readonly IntPtr NativeFieldInfoPtr_Interval;

		// Token: 0x040052B8 RID: 21176
		private static readonly IntPtr NativeFieldInfoPtr_Event;

		// Token: 0x040052B9 RID: 21177
		private static readonly IntPtr NativeMethodInfoPtr_Start_Public_Void_0;

		// Token: 0x040052BA RID: 21178
		private static readonly IntPtr NativeMethodInfoPtr_Execute_Private_Void_0;

		// Token: 0x040052BB RID: 21179
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
