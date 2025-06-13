using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2CppScheduleOne.Property
{
	// Token: 0x0200052F RID: 1327
	public class LaunderingOperation : Il2CppSystem.Object
	{
		// Token: 0x0600747D RID: 29821 RVA: 0x001FF450 File Offset: 0x001FD650
		// Note: this type is marked as 'beforefieldinit'.
		static LaunderingOperation()
		{
			Il2CppClassPointerStore<LaunderingOperation>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Property", "LaunderingOperation");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LaunderingOperation>.NativeClassPtr);
			LaunderingOperation.NativeFieldInfoPtr_business = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LaunderingOperation>.NativeClassPtr, "business");
			LaunderingOperation.NativeFieldInfoPtr_amount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LaunderingOperation>.NativeClassPtr, "amount");
			LaunderingOperation.NativeFieldInfoPtr_minutesSinceStarted = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LaunderingOperation>.NativeClassPtr, "minutesSinceStarted");
			LaunderingOperation.NativeFieldInfoPtr_completionTime_Minutes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LaunderingOperation>.NativeClassPtr, "completionTime_Minutes");
			LaunderingOperation.NativeMethodInfoPtr__ctor_Public_Void_Business_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LaunderingOperation>.NativeClassPtr, 100678010);
		}

		// Token: 0x0600747E RID: 29822 RVA: 0x001FF4E4 File Offset: 0x001FD6E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 228387, XrefRangeEnd = 228389, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LaunderingOperation(Business _business, float _amount, int _minutesSinceStarted) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LaunderingOperation>.NativeClassPtr))
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(_business);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref _amount;
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref _minutesSinceStarted;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LaunderingOperation.NativeMethodInfoPtr__ctor_Public_Void_Business_Single_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600747F RID: 29823 RVA: 0x00037268 File Offset: 0x00035468
		public LaunderingOperation(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700231B RID: 8987
		// (get) Token: 0x06007480 RID: 29824 RVA: 0x001FF54C File Offset: 0x001FD74C
		// (set) Token: 0x06007481 RID: 29825 RVA: 0x00037271 File Offset: 0x00035471
		public unsafe Business business
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LaunderingOperation.NativeFieldInfoPtr_business);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Business>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LaunderingOperation.NativeFieldInfoPtr_business), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700231C RID: 8988
		// (get) Token: 0x06007482 RID: 29826 RVA: 0x001FF57C File Offset: 0x001FD77C
		// (set) Token: 0x06007483 RID: 29827 RVA: 0x00037290 File Offset: 0x00035490
		public unsafe float amount
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LaunderingOperation.NativeFieldInfoPtr_amount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LaunderingOperation.NativeFieldInfoPtr_amount)) = value;
			}
		}

		// Token: 0x1700231D RID: 8989
		// (get) Token: 0x06007484 RID: 29828 RVA: 0x001FF5A4 File Offset: 0x001FD7A4
		// (set) Token: 0x06007485 RID: 29829 RVA: 0x000372AB File Offset: 0x000354AB
		public unsafe int minutesSinceStarted
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LaunderingOperation.NativeFieldInfoPtr_minutesSinceStarted);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LaunderingOperation.NativeFieldInfoPtr_minutesSinceStarted)) = value;
			}
		}

		// Token: 0x1700231E RID: 8990
		// (get) Token: 0x06007486 RID: 29830 RVA: 0x001FF5CC File Offset: 0x001FD7CC
		// (set) Token: 0x06007487 RID: 29831 RVA: 0x000372C6 File Offset: 0x000354C6
		public unsafe int completionTime_Minutes
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LaunderingOperation.NativeFieldInfoPtr_completionTime_Minutes);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LaunderingOperation.NativeFieldInfoPtr_completionTime_Minutes)) = value;
			}
		}

		// Token: 0x04004F84 RID: 20356
		private static readonly System.IntPtr NativeFieldInfoPtr_business;

		// Token: 0x04004F85 RID: 20357
		private static readonly System.IntPtr NativeFieldInfoPtr_amount;

		// Token: 0x04004F86 RID: 20358
		private static readonly System.IntPtr NativeFieldInfoPtr_minutesSinceStarted;

		// Token: 0x04004F87 RID: 20359
		private static readonly System.IntPtr NativeFieldInfoPtr_completionTime_Minutes;

		// Token: 0x04004F88 RID: 20360
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Business_Single_Int32_0;
	}
}
