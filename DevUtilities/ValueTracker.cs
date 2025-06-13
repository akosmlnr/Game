using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Il2CppScheduleOne.DevUtilities
{
	// Token: 0x0200048E RID: 1166
	public class ValueTracker : Il2CppSystem.Object
	{
		// Token: 0x060063EA RID: 25578 RVA: 0x001C8AA8 File Offset: 0x001C6CA8
		// Note: this type is marked as 'beforefieldinit'.
		static ValueTracker()
		{
			Il2CppClassPointerStore<ValueTracker>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.DevUtilities", "ValueTracker");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ValueTracker>.NativeClassPtr);
			ValueTracker.NativeFieldInfoPtr_historyDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ValueTracker>.NativeClassPtr, "historyDuration");
			ValueTracker.NativeFieldInfoPtr_valueHistory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ValueTracker>.NativeClassPtr, "valueHistory");
			ValueTracker.NativeMethodInfoPtr__ctor_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValueTracker>.NativeClassPtr, 100676073);
			ValueTracker.NativeMethodInfoPtr_Destroy_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValueTracker>.NativeClassPtr, 100676074);
			ValueTracker.NativeMethodInfoPtr_Update_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValueTracker>.NativeClassPtr, 100676075);
			ValueTracker.NativeMethodInfoPtr_SubmitValue_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValueTracker>.NativeClassPtr, 100676076);
			ValueTracker.NativeMethodInfoPtr_RecordedHistoryLength_Public_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValueTracker>.NativeClassPtr, 100676077);
			ValueTracker.NativeMethodInfoPtr_GetLowestValue_Public_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValueTracker>.NativeClassPtr, 100676078);
			ValueTracker.NativeMethodInfoPtr_GetAverageValue_Public_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValueTracker>.NativeClassPtr, 100676079);
		}

		// Token: 0x060063EB RID: 25579 RVA: 0x001C8B8C File Offset: 0x001C6D8C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 206116, RefRangeEnd = 206117, XrefRangeStart = 206090, XrefRangeEnd = 206116, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ValueTracker(float HistoryDuration) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ValueTracker>.NativeClassPtr))
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref HistoryDuration;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ValueTracker.NativeMethodInfoPtr__ctor_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060063EC RID: 25580 RVA: 0x001C8BD4 File Offset: 0x001C6DD4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 206117, XrefRangeEnd = 206135, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Destroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ValueTracker.NativeMethodInfoPtr_Destroy_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060063ED RID: 25581 RVA: 0x001C8C08 File Offset: 0x001C6E08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 206135, XrefRangeEnd = 206144, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ValueTracker.NativeMethodInfoPtr_Update_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060063EE RID: 25582 RVA: 0x001C8C3C File Offset: 0x001C6E3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 206144, XrefRangeEnd = 206152, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SubmitValue(float value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref value;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ValueTracker.NativeMethodInfoPtr_SubmitValue_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060063EF RID: 25583 RVA: 0x001C8C7C File Offset: 0x001C6E7C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 206157, RefRangeEnd = 206159, XrefRangeStart = 206152, XrefRangeEnd = 206157, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float RecordedHistoryLength()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(ValueTracker.NativeMethodInfoPtr_RecordedHistoryLength_Public_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x060063F0 RID: 25584 RVA: 0x001C8CB8 File Offset: 0x001C6EB8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 206180, RefRangeEnd = 206182, XrefRangeStart = 206159, XrefRangeEnd = 206180, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float GetLowestValue()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(ValueTracker.NativeMethodInfoPtr_GetLowestValue_Public_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x060063F1 RID: 25585 RVA: 0x001C8CF4 File Offset: 0x001C6EF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 206182, XrefRangeEnd = 206197, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float GetAverageValue()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(ValueTracker.NativeMethodInfoPtr_GetAverageValue_Public_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x060063F2 RID: 25586 RVA: 0x0002EFB7 File Offset: 0x0002D1B7
		public ValueTracker(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001DDA RID: 7642
		// (get) Token: 0x060063F3 RID: 25587 RVA: 0x001C8D30 File Offset: 0x001C6F30
		// (set) Token: 0x060063F4 RID: 25588 RVA: 0x0002EFC0 File Offset: 0x0002D1C0
		public unsafe float historyDuration
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ValueTracker.NativeFieldInfoPtr_historyDuration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ValueTracker.NativeFieldInfoPtr_historyDuration)) = value;
			}
		}

		// Token: 0x17001DDB RID: 7643
		// (get) Token: 0x060063F5 RID: 25589 RVA: 0x001C8D58 File Offset: 0x001C6F58
		// (set) Token: 0x060063F6 RID: 25590 RVA: 0x0002EFDB File Offset: 0x0002D1DB
		public unsafe List<ValueTracker.Value> valueHistory
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ValueTracker.NativeFieldInfoPtr_valueHistory);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ValueTracker.Value>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ValueTracker.NativeFieldInfoPtr_valueHistory), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04004424 RID: 17444
		private static readonly System.IntPtr NativeFieldInfoPtr_historyDuration;

		// Token: 0x04004425 RID: 17445
		private static readonly System.IntPtr NativeFieldInfoPtr_valueHistory;

		// Token: 0x04004426 RID: 17446
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Single_0;

		// Token: 0x04004427 RID: 17447
		private static readonly System.IntPtr NativeMethodInfoPtr_Destroy_Public_Void_0;

		// Token: 0x04004428 RID: 17448
		private static readonly System.IntPtr NativeMethodInfoPtr_Update_Public_Void_0;

		// Token: 0x04004429 RID: 17449
		private static readonly System.IntPtr NativeMethodInfoPtr_SubmitValue_Public_Void_Single_0;

		// Token: 0x0400442A RID: 17450
		private static readonly System.IntPtr NativeMethodInfoPtr_RecordedHistoryLength_Public_Single_0;

		// Token: 0x0400442B RID: 17451
		private static readonly System.IntPtr NativeMethodInfoPtr_GetLowestValue_Public_Single_0;

		// Token: 0x0400442C RID: 17452
		private static readonly System.IntPtr NativeMethodInfoPtr_GetAverageValue_Public_Single_0;

		// Token: 0x02000A66 RID: 2662
		public class Value : Il2CppSystem.Object
		{
			// Token: 0x0600D41A RID: 54298 RVA: 0x00331BD8 File Offset: 0x0032FDD8
			// Note: this type is marked as 'beforefieldinit'.
			static Value()
			{
				Il2CppClassPointerStore<ValueTracker.Value>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ValueTracker>.NativeClassPtr, "Value");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ValueTracker.Value>.NativeClassPtr);
				ValueTracker.Value.NativeFieldInfoPtr_val = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ValueTracker.Value>.NativeClassPtr, "val");
				ValueTracker.Value.NativeFieldInfoPtr_time = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ValueTracker.Value>.NativeClassPtr, "time");
				ValueTracker.Value.NativeMethodInfoPtr__ctor_Public_Void_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValueTracker.Value>.NativeClassPtr, 100676080);
			}

			// Token: 0x0600D41B RID: 54299 RVA: 0x00331C40 File Offset: 0x0032FE40
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 98951, RefRangeEnd = 98958, XrefRangeStart = 98951, XrefRangeEnd = 98958, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Value(float val, float time) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ValueTracker.Value>.NativeClassPtr))
			{
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = ref val;
				ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref time;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ValueTracker.Value.NativeMethodInfoPtr__ctor_Public_Void_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600D41C RID: 54300 RVA: 0x00066D84 File Offset: 0x00064F84
			public Value(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170041A5 RID: 16805
			// (get) Token: 0x0600D41D RID: 54301 RVA: 0x00331C98 File Offset: 0x0032FE98
			// (set) Token: 0x0600D41E RID: 54302 RVA: 0x00066D8D File Offset: 0x00064F8D
			public unsafe float val
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ValueTracker.Value.NativeFieldInfoPtr_val);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ValueTracker.Value.NativeFieldInfoPtr_val)) = value;
				}
			}

			// Token: 0x170041A6 RID: 16806
			// (get) Token: 0x0600D41F RID: 54303 RVA: 0x00331CC0 File Offset: 0x0032FEC0
			// (set) Token: 0x0600D420 RID: 54304 RVA: 0x00066DA8 File Offset: 0x00064FA8
			public unsafe float time
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ValueTracker.Value.NativeFieldInfoPtr_time);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ValueTracker.Value.NativeFieldInfoPtr_time)) = value;
				}
			}

			// Token: 0x04008F22 RID: 36642
			private static readonly System.IntPtr NativeFieldInfoPtr_val;

			// Token: 0x04008F23 RID: 36643
			private static readonly System.IntPtr NativeFieldInfoPtr_time;

			// Token: 0x04008F24 RID: 36644
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Single_Single_0;
		}

		// Token: 0x02000A67 RID: 2663
		[ObfuscatedName("ScheduleOne.DevUtilities.ValueTracker+<>c")]
		[System.Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x0600D421 RID: 54305 RVA: 0x00331CE8 File Offset: 0x0032FEE8
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<ValueTracker.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ValueTracker>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ValueTracker.__c>.NativeClassPtr);
				ValueTracker.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ValueTracker.__c>.NativeClassPtr, "<>9");
				ValueTracker.__c.NativeFieldInfoPtr___9__8_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ValueTracker.__c>.NativeClassPtr, "<>9__8_0");
				ValueTracker.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValueTracker.__c>.NativeClassPtr, 100676082);
				ValueTracker.__c.NativeMethodInfoPtr__GetLowestValue_b__8_0_Internal_Single_Value_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValueTracker.__c>.NativeClassPtr, 100676083);
			}

			// Token: 0x0600D422 RID: 54306 RVA: 0x00331D64 File Offset: 0x0032FF64
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ValueTracker.__c>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ValueTracker.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600D423 RID: 54307 RVA: 0x00331DA0 File Offset: 0x0032FFA0
			[CallerCount(0)]
			public unsafe float _GetLowestValue_b__8_0(ValueTracker.Value x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(ValueTracker.__c.NativeMethodInfoPtr__GetLowestValue_b__8_0_Internal_Single_Value_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x0600D424 RID: 54308 RVA: 0x00066DC3 File Offset: 0x00064FC3
			public __c(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170041A7 RID: 16807
			// (get) Token: 0x0600D425 RID: 54309 RVA: 0x00331DF0 File Offset: 0x0032FFF0
			// (set) Token: 0x0600D426 RID: 54310 RVA: 0x00066DCC File Offset: 0x00064FCC
			public unsafe static ValueTracker.__c __9
			{
				get
				{
					System.IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ValueTracker.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ValueTracker.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ValueTracker.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170041A8 RID: 16808
			// (get) Token: 0x0600D427 RID: 54311 RVA: 0x00331E18 File Offset: 0x00330018
			// (set) Token: 0x0600D428 RID: 54312 RVA: 0x00066DDE File Offset: 0x00064FDE
			public unsafe static Il2CppSystem.Func<ValueTracker.Value, float> __9__8_0
			{
				get
				{
					System.IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ValueTracker.__c.NativeFieldInfoPtr___9__8_0, (void*)(&intPtr));
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Func<ValueTracker.Value, float>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ValueTracker.__c.NativeFieldInfoPtr___9__8_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008F25 RID: 36645
			private static readonly System.IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04008F26 RID: 36646
			private static readonly System.IntPtr NativeFieldInfoPtr___9__8_0;

			// Token: 0x04008F27 RID: 36647
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008F28 RID: 36648
			private static readonly System.IntPtr NativeMethodInfoPtr__GetLowestValue_b__8_0_Internal_Single_Value_0;
		}
	}
}
